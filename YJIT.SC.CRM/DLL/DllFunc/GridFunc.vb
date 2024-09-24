'Imports System.Drawing
'Imports YJIT.SC.UI
'Imports YJIT.SC.App
'Imports YJIT.SC.WCF

Public Class GridFunc
    'Inherits YJIT.SC.UI.SCView
    'Dim ErpFunc As ErpCommon.ErpFunc

    Public Enum EqmGProcType
        Auto = 0
        Manual = 1
    End Enum
    Public Enum EqmRowCheckType
        All = 0
        Row = 1
        Check = 2
    End Enum

    'Private Property MainForm As Type

    ''' <summary>
    ''' ComboBox선택시 사용
    ''' </summary>
    ''' <param name="WebGrid">WebGrid Name</param>
    ''' <param name="ProcType">Auto, Manual, Auto - Title에 * 표시된 항목 체크, Manual - Columns 으로 지정한 항목 체크</param>
    ''' <param name="Columns">FieldName (구분자 ",")</param>
    ''' <param name="IsZeroNull">금액관련 필드중 0 입력불가 처리</param>
    ''' <param name="RowCheckType">ALL, ROW, CHECK</param>
    ''' <remarks>금액중 0 입력 불가 처리시 기본체크후 한번 더 함수를 호출해서 해당 필드만 다시 체크하세요. IsZeroNull = True 로 설정</remarks>
    ''' <remarks>선언된 필드의 값들에 숫자가 모두 0이 아닌지 확인</remarks>
    Public Function SetGridMandatoryCheck(ByVal WebGrid As YJIT.SC.UI.SCControls.WebGrid _
                                      , Optional ByVal ProcType As GridFunc.EqmGProcType = GridFunc.EqmGProcType.Auto _
                                      , Optional ByVal Columns As String = "" _
                                      , Optional ByVal IsZeroNull As Boolean = False _
                                      , Optional ByVal RowCheckType As GridFunc.EqmRowCheckType = GridFunc.EqmRowCheckType.All _
                                      , Optional ByVal CheckBoxName As String = "CHK") As Boolean

        Try
            'ProcType : Auto, Manual
            '           Auto - Title에 * 표시된 항목 체크
            '           Manual - Columns 으로 지정한 항목 체크
            'Columns : FieldName (구분자 ",")
            'IsChargeGrid : InvId 없는 경우만 체크하기 위한 조건
            'RowCheckType : ALL, ROW, CHECK


            Dim Grid As YJIT.SC.UI.SCControls.WebGrid
            Dim View As DevExpress.XtraGrid.Views.Grid.GridView

            Grid = CType(WebGrid, YJIT.SC.UI.SCControls.WebGrid)
            View = CType(WebGrid.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

            'Caption 중에 * 시작하는 항목 체크
            If ProcType = GridFunc.EqmGProcType.Auto Then
                Dim iCol As Integer
                For iCol = 0 To View.Columns.Count - 1
                    If Mid(Trim(View.Columns(iCol).Caption.ToString), 1, 1) = "*" Then
                        If Trim(Columns) <> "" Then Columns &= ", "
                        Columns &= Trim(View.Columns(iCol).FieldName.ToString)
                    End If
                Next
            End If


            Dim arrFildName() As String
            Dim iRow As Integer
            Dim FieldRow As Integer
            Dim FieldName As String
            Dim ErrRow As String = ""
            Dim ErrMsg As String = ""
            Dim FirstErrorRow As Decimal = -1
            Dim FirstErrorColName As String = ""

            Columns = Replace(Columns, ", ", ",")
            arrFildName = Split(Columns, ",")

            For FieldRow = 0 To arrFildName.Count - 1
                FieldName = arrFildName(FieldRow)
                ErrRow = ""

                If Trim(FieldName) = "" Then Continue For


                ''## IsCurrentRow
                Dim StartRow As Integer
                Dim EndRow As Integer

                If RowCheckType = GridFunc.EqmRowCheckType.Row Then
                    StartRow = View.FocusedRowHandle
                    EndRow = View.FocusedRowHandle
                Else
                    StartRow = 0
                    EndRow = View.RowCount - 1
                End If
                '## ============

                Dim ColumnDataType As String
                Select Case Trim(UCase(TypeName(View.Columns(FieldName).ColumnEdit)))
                    Case Trim(UCase("RepositoryItemTimeEdit"))
                        ColumnDataType = "TIME"
                    Case Trim(UCase("RepositoryItemDateBoxEdit"))
                        ColumnDataType = "DATE"
                    Case Else
                        ColumnDataType = "STRING"
                End Select

                For iRow = StartRow To EndRow

                    If RowCheckType = GridFunc.EqmRowCheckType.Check Then
                        If View.GetRowCellValue(iRow, CheckBoxName) = False Then
                            Continue For '체크안된 경우 다음자료 체크
                        End If
                    End If

                    Select Case View.GetDataRow(iRow).RowState
                        Case DataRowState.Deleted, DataRowState.Unchanged
                            '체크 의미 없음
                        Case Else
                            If IsZeroNull = True Then
                                If IsNumeric(View.GetRowCellValue(iRow, FieldName).ToString) Then
                                    If CDbl(View.GetRowCellValue(iRow, FieldName).ToString) = CDbl(0.0) Then
                                        If Trim(ErrRow) <> "" Then ErrRow &= ", "
                                        ErrRow &= iRow + 1 'Row가 0에서 시작함

                                        '처음 오류난 컬럼으로 이동하기 위해서 자료 취합
                                        If FirstErrorRow = -1 Then
                                            FirstErrorRow = iRow
                                            FirstErrorColName = FieldName
                                        End If
                                    End If
                                End If
                            End If

                            If Trim(View.GetRowCellValue(iRow, FieldName).ToString) = "" Then
                                If Trim(ErrRow) <> "" Then ErrRow &= ", "
                                ErrRow &= iRow + 1 'Row가 0에서 시작함

                                '처음 오류난 컬럼으로 이동하기 위해서 자료 취합
                                If FirstErrorRow = -1 Then
                                    FirstErrorRow = iRow
                                    FirstErrorColName = FieldName
                                End If
                            Else
                                If ColumnDataType = "DATE" Then
                                    If View.GetRowCellValue(iRow, FieldName).ToString.Trim <> "" Then
                                        Dim convertDate As String = View.GetRowCellValue(iRow, FieldName).ToString.Substring(0, 4) & "-" & View.GetRowCellValue(iRow, FieldName).ToString.Substring(4, 2) & "-" & View.GetRowCellValue(iRow, FieldName).ToString.Substring(6, 2)
                                        If IsDate(convertDate) = False Then
                                            If Trim(ErrRow) <> "" Then ErrRow &= ", "
                                            ErrRow &= iRow + 1 'Row가 0에서 시작함

                                            '처음 오류난 컬럼으로 이동하기 위해서 자료 취합
                                            If FirstErrorRow = -1 Then
                                                FirstErrorRow = iRow
                                                FirstErrorColName = FieldName
                                            End If
                                        End If
                                    End If
                                End If
                            End If

                            '기본값이 0이 아닐수 있어서 제거
                            ''MaskType가 Numeric 인경우 기본값 0 으로 처리함
                            'Dim objColumn As Object = View.Columns.Item(FieldName).ColumnEdit
                            'If Not objColumn Is Nothing Then
                            '    If TypeName(objColumn) = "RepositoryItemTextEdit" Then
                            '        If objColumn.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric Then
                            '            If Trim(View.GetRowCellValue(iRow, FieldName).ToString) = "" Then
                            '                Call View.SetRowCellValue(iRow, FieldName, 0)
                            '            End If
                            '        End If
                            '    End If
                            'End If

                    End Select
                Next

                If Trim(ErrRow) <> "" Then
                    If Trim(ErrMsg) <> "" Then ErrMsg &= vbCrLf

                    Select Case TypeName(WebGrid.MainView)
                        Case "BandedGridView", "AdvBandedGridView"
                            Dim column As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn = View.Columns(FieldName)
                            If column Is Nothing Then
                                ErrMsg &= "Please Input [" & View.Columns(FieldName).Caption.ToString.Replace("<br>", " ") & "]"
                            Else
                                If column.OwnerBand.Caption = View.Columns(FieldName).Caption.ToString.Replace("*", "").Replace("<br>", " ") Then
                                    ErrMsg &= "Please Input [" & View.Columns(FieldName).Caption.ToString.Replace("<br>", " ") & "]"
                                Else
                                    ErrMsg &= "Please Input [" & column.OwnerBand.Caption & " " & View.Columns(FieldName).Caption.ToString.Replace("<br>", " ") & "]"
                                End If
                            End If
                        Case Else
                            ErrMsg &= "Please Input [" & View.Columns(FieldName).Caption.ToString.Replace("<br>", " ") & "]"
                    End Select

                    ErrMsg &= vbCrLf & " - Row : " & ErrRow & ""
                End If
            Next




            If Trim(ErrMsg) <> "" Then
                MsgBox("Value is required!" & vbCrLf & vbCrLf & ErrMsg)

                If FirstErrorRow <> -1 Then
                    View.FocusedRowHandle = FirstErrorRow
                    View.FocusedColumn = View.Columns.ColumnByFieldName(FirstErrorColName)
                    View.ShowEditor()
                End If

                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Shared Function SetGridDuplicationCheck(ByVal WebGrid As YJIT.SC.UI.SCControls.WebGrid, ByVal ParamArray Columns As String()) As Boolean
        Try
            Dim Grid As YJIT.SC.UI.SCControls.WebGrid
            Dim View As DevExpress.XtraGrid.Views.Grid.GridView
            Dim ErrMsg As String = String.Empty

            Grid = CType(WebGrid, YJIT.SC.UI.SCControls.WebGrid)
            View = CType(WebGrid.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

            Dim FirstErrorRow As Decimal = -1
            Dim FirstErrorColName As String = ""
            Dim bDuplication As Boolean = False

            For Each EachColumn As String In Columns
                bDuplication = False
                For i As Integer = 0 To View.RowCount - 1
                    If View.GetDataRow(i).RowState = DataRowState.Deleted Then Continue For

                    For j As Integer = i + 1 To View.RowCount - 1
                        If View.GetRowCellValue(i, EachColumn) = View.GetRowCellValue(j, EachColumn) Then
                            If ErrMsg.ToString.Trim <> "" Then ErrMsg &= vbCrLf
                            ErrMsg &= "[" & View.Columns(EachColumn).Caption.ToString & "] is duplication!"

                            '처음 오류난 컬럼으로 이동하기 위해서 자료 취합
                            If FirstErrorRow = -1 Then
                                FirstErrorRow = i
                                FirstErrorColName = EachColumn
                            End If
                            bDuplication = True
                            Exit For
                        End If
                    Next
                    If bDuplication = True Then Exit For
                Next
            Next

            If Trim(ErrMsg) <> "" Then
                MsgBox(ErrMsg)

                If FirstErrorRow <> -1 Then
                    View.TopRowIndex = FirstErrorRow
                    View.FocusedRowHandle = FirstErrorRow
                    View.FocusedColumn = View.Columns.ColumnByFieldName(FirstErrorColName)
                    View.ShowEditor()
                End If

                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Function SetGridNonDuplicationCheck(ByVal WebGrid As YJIT.SC.UI.SCControls.WebGrid, ByVal ParamArray Columns As String()) As Boolean
        Try
            Dim Grid As YJIT.SC.UI.SCControls.WebGrid
            Dim View As DevExpress.XtraGrid.Views.Grid.GridView
            Dim ErrMsg As String = String.Empty

            Grid = CType(WebGrid, YJIT.SC.UI.SCControls.WebGrid)
            View = CType(WebGrid.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

            Dim FirstErrorRow As Decimal = -1
            Dim FirstErrorColName As String = ""
            Dim bNonDuplication As Boolean = False

            For Each EachColumn As String In Columns
                bNonDuplication = False
                For i As Integer = 0 To View.RowCount - 1
                    If View.GetDataRow(i).RowState = DataRowState.Deleted Then Continue For

                    For j As Integer = i + 1 To View.RowCount - 1
                        If View.GetRowCellValue(i, EachColumn) <> View.GetRowCellValue(j, EachColumn) Then
                            If ErrMsg.ToString.Trim <> "" Then ErrMsg &= vbCrLf
                            ErrMsg &= "[" & View.Columns(EachColumn).Caption.ToString & "] is invalid!"

                            '처음 오류난 컬럼으로 이동하기 위해서 자료 취합
                            If FirstErrorRow = -1 Then
                                FirstErrorRow = i
                                FirstErrorColName = EachColumn
                            End If
                            bNonDuplication = True
                            Exit For
                        End If
                    Next
                    If bNonDuplication = True Then Exit For
                Next
            Next

            If Trim(ErrMsg) <> "" Then
                MsgBox(ErrMsg)

                If FirstErrorRow <> -1 Then
                    View.TopRowIndex = FirstErrorRow
                    View.FocusedRowHandle = FirstErrorRow
                    View.FocusedColumn = View.Columns.ColumnByFieldName(FirstErrorColName)
                    View.ShowEditor()
                End If

                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function


    ''' <summary>
    ''' Key Column 수정 불가 처리 
    ''' FocusedRowChanged 이벤트에 추가 
    ''' Call GridFunc.SetGridKeyProtectEx(sender, e, "MAIL_ADDR")
    ''' Call GridFunc.SetGridKeyProtectEx(sender, e, "MAIL_ADDR","MAIN_USR_NM")
    ''' 컬럼 1개 이상인 경우 컬럼별로 개별 체크
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <param name="FieldNames"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetGridKeyProtectEx(ByVal sender As Object, ByVal e As Object, ByVal ParamArray FieldNames As String())
        'Dim gv As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView = sender
        Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = sender

        Select Case Mid(e.ToString, InStrRev(e.ToString, ".") + 1)
            Case "FocusedRowChangedEventArgs"
                If gv.FocusedRowHandle < 0 Then Exit Sub

                For Each FieldName As String In FieldNames
                    If gv.GetDataRow(gv.FocusedRowHandle).RowState = DataRowState.Added Then
                        gv.Columns(FieldName).OptionsColumn.AllowEdit = True
                        gv.Columns(FieldName).OptionsColumn.ReadOnly = False
                    Else
                        gv.Columns(FieldName).OptionsColumn.AllowEdit = False
                        gv.Columns(FieldName).OptionsColumn.ReadOnly = True
                    End If
                Next
            Case "RowCellStyleEventArgs"
                If e.RowHandle < 0 Then Exit Sub
                For Each FieldName As String In FieldNames
                    Select Case e.Column.FieldName
                        Case FieldName
                            If gv.GetDataRow(e.RowHandle).RowState = DataRowState.Added Then
                                '추가된 행은 수정가능 표시
                                e.Appearance.BackColor = System.Drawing.Color.Transparent
                            End If
                    End Select
                Next
        End Select
    End Sub

    Public Shared Sub SetGridViewStyle(ByVal gv() As DevExpress.XtraGrid.Views.Grid.GridView)
        For Each EachGv In gv
            SetGridViewStyle(EachGv)
        Next
    End Sub

    Public Shared Sub SetGridViewStyle(ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView)
        'Call DrawRowIndicator({gv})
        '가로스크롤 이동범위
        gv.HorzScrollStep = "100"

        '자료입력시마다 정렬기준으로 위치 변경안되도록 설정
        gv.OptionsBehavior.ImmediateUpdateRowPosition = False

        '엔터키 사용시 다음칸으로 이동
        gv.OptionsNavigation.EnterMoveNextColumn = True

        ''그리드 포커스 제외
        'If gv.OptionsBehavior.Editable = False Then
        '    gv.OptionsSelection.EnableAppearanceFocusedRow = True
        'Else
        '    gv.OptionsSelection.EnableAppearanceFocusedRow = False
        'End If
        gv.OptionsSelection.EnableAppearanceFocusedRow = True


        'Editable = False인 경우는 컬럼 색깔 표시 안함
        If gv.Editable = True Then
            For Each EachColumn As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                'AllowEdit 색상표시
                Call SetGridViewColumnBackColor(EachColumn)
            Next
        End If
    End Sub

    'Public Sub SetDefaultStyle(ByVal View As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Stlye As GridStlye)
    '    Try
    '        With View

    '            .HorzScrollStep = "100"

    '            ''.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightPink
    '            .Appearance.FocusedRow.Options.UseBackColor = False
    '            ''.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightPink
    '            .Appearance.HideSelectionRow.Options.UseBackColor = False
    '            ''.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightPink
    '            .Appearance.SelectedRow.Options.UseBackColor = False

    '            .OptionsSelection.InvertSelection = True '선택셀만 표시

    '            .OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default   '바로 편집모드 적용 / 그리드 클릭시 선택후 편집 모드 들어갈껀지 바로 편집모드 들어갈껀지 옵션 / 일반적으로 Default, MouseDownFocused 를 많이 사용함

    '            .OptionsPrint.AutoWidth = False

    '            .OptionsView.ShowGroupPanel = False
    '            .OptionsView.ColumnAutoWidth = False
    '            .OptionsNavigation.EnterMoveNextColumn = True

    '            .OptionsCustomization.AllowColumnMoving = True
    '            .OptionsCustomization.AllowColumnResizing = True

    '            Select Case Stlye
    '                Case GridStlye.IsEditable
    '                    .OptionsBehavior.Editable = True
    '                    .OptionsBehavior.ReadOnly = False
    '                    '.OptionsCustomization.AllowFilter = False
    '                    '.OptionsCustomization.AllowGroup = False
    '                    '.OptionsCustomization.AllowQuickHideColumns = False
    '                    '.OptionsCustomization.AllowSort = False
    '                    .OptionsCustomization.AllowSort = True

    '                    '.OptionsMenu.EnableColumnMenu = True

    '                Case Else 'Trim(UCase("ReadOnly"))
    '                    .OptionsBehavior.Editable = False
    '                    .OptionsBehavior.ReadOnly = True
    '                    .OptionsCustomization.AllowFilter = False
    '                    .OptionsCustomization.AllowGroup = False
    '                    .OptionsCustomization.AllowQuickHideColumns = False
    '                    '.OptionsCustomization.AllowSort = False
    '                    .OptionsCustomization.AllowSort = True

    '                    .OptionsMenu.EnableColumnMenu = False
    '                    '.OptionsView.ShowFooter = True
    '            End Select
    '        End With
    '    Catch ex As Exception
    '        MsgBoxLocalized("Error Message : " & ex.Message & vbCrLf & vbCrLf & "Error Function : " & "GridCommon.SetDefaultStyle")
    '    End Try
    'End Sub



    Private Shared Sub SetGridViewColumnBackColor(ByRef gvColumn As DevExpress.XtraGrid.Columns.GridColumn)
        If gvColumn.OptionsColumn.AllowEdit = False Then
            'gvColumn.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            gvColumn.AppearanceCell.BackColor = System.Drawing.Color.GhostWhite
            'gvColumn.AppearanceCell.BackColor = System.Drawing.Color.FloralWhite
            gvColumn.AppearanceCell.Options.UseBackColor = True
        Else
            If gvColumn.AppearanceCell.BackColor = System.Drawing.Color.GhostWhite Then
                gvColumn.AppearanceCell.BackColor = System.Drawing.Color.White
                gvColumn.AppearanceCell.Options.UseBackColor = True
            End If
        End If
    End Sub


    'Public Sub SetGridAddRow(ByRef PopUp As PopupBase, ByRef WebGrid As YJIT.SC.UI.SCControls.WebGrid)
    '    Dim dt As New DataTable
    '    dt.Columns.Add("Key")
    '    dt.Columns.Add("Sender")
    '    dt.Columns.Add("Action", GetType(Action))
    '    dt.Rows.Add("AddRow", WebGrid.Name, Action.Addrow)
    '    PopUp.AddRow(dt.Rows(0))
    'End Sub

    Public Shared Sub SetGridSelectAll(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            view.Tag = view.Tag & "SetGridSelectAll"

            Dim firstRowChk As String = view.GetRowCellValue(0, "CHK")
            For i As Integer = 0 To view.RowCount - 1
                If firstRowChk = "N" Then
                    view.SetRowCellValue(i, "CHK", "Y")
                    view.UpdateCurrentRow()
                Else
                    view.SetRowCellValue(i, "CHK", "N")
                    view.UpdateCurrentRow()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " (SetGridSelectAll)")
        Finally
            view.Tag = view.Tag.ToString.Replace("SetGridSelectAll", "")
        End Try
    End Sub




    Public Shared Function GetRepositoryItemDateBoxEdit() As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        Dim editorDate As New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        Return editorDate
    End Function

    Public Shared Function GetRepositoryItemLookUpEdit(ByVal CodeType As String, Optional ByVal DataParams As String = "", Optional ByVal SearchParams As String = "") As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim dicSearchParams As Dictionary(Of String, Object)
        Dim dicDataParams As Dictionary(Of String, Object)

        dicSearchParams = GetStringToDictionary(SearchParams)
        dicDataParams = GetStringToDictionary(DataParams)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList(CodeType, dicSearchParams, dicDataParams)

        Return editorCombo
    End Function
    ''' <summary>
    ''' GetRepositoryItemLookUpEdit 공통함수
    ''' GV1.Columns("AS_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:I06, NameType:")
    ''' GV1.Columns("AS_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:I06, NameType:",,"Code,Name")
    ''' </summary>
    ''' <param name="CodeType"></param>
    ''' <param name="DataParams"></param>
    ''' <param name="SearchParams"></param>
    ''' <param name="HideColumn"></param>
    ''' <remarks></remarks>
    Public Shared Function GetRepositoryItemLookUpEditEx(ByVal CodeType As String, Optional ByVal DataParams As String = "", Optional ByVal SearchParams As String = "", Optional ByVal HideColumn As String = "Code", Optional NullText As String = "") As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim dicSearchParams As Dictionary(Of String, Object)
        Dim dicDataParams As Dictionary(Of String, Object)

        dicSearchParams = GetStringToDictionary(SearchParams)
        dicDataParams = GetStringToDictionary(DataParams)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        editorCombo.Appearance.Options.UseFont = True
        editorCombo.AppearanceDropDown.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        editorCombo.AppearanceDropDown.Options.UseFont = True

        Dim dt As DataTable = Common.CodeServiceAPI.GetCodeList(CodeType, dicSearchParams, dicDataParams)
        If Not String.IsNullOrEmpty(NullText) Then
            Dim dr As DataRow = dt.NewRow
            dr("CODE") = String.Empty
            dr("NAME") = NullText
            dt.Rows.InsertAt(dr, 0)
        End If
        editorCombo.DataSource = dt

        If Not String.IsNullOrEmpty(HideColumn) Then
            editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
            For Each colName As String In Split(HideColumn, ",")
                If editorCombo.DataSource Is Nothing Then Continue For
                editorCombo.Columns(colName.ToUpper.Trim).Visible = False 'Show/Hide one column (by default, all columns in datasource is visible)
            Next
        End If

        Return editorCombo
    End Function
    Public Shared Function GetRepositoryItemLookUpEditEx(ByVal Params() As String, Optional ByVal HideColumn As String = "Code") As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim dtParams As DataTable = New DataTable
        dtParams = GetStringToDatatable(Params)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        editorCombo.Appearance.Options.UseFont = True
        editorCombo.AppearanceDropDown.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        editorCombo.AppearanceDropDown.Options.UseFont = True
        editorCombo.DataSource = dtParams

        If Not String.IsNullOrEmpty(HideColumn) Then
            editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
            For Each colName As String In Split(HideColumn, ",")
                editorCombo.Columns(colName.ToUpper.Trim).Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
            Next
        End If

        Return editorCombo
    End Function
    Public Shared Function GetStringToDictionary(ByVal Params As String) As Dictionary(Of String, Object)
        Dim dicParams As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        Dim arrayParamList() As String = Split(Params, ",")
        Dim arrayParam() As String = Nothing

        For Each EachParam In arrayParamList
            arrayParam = Split(EachParam, ":")
            If arrayParam(0).ToString = "" Then Continue For
            dicParams.Add(arrayParam(0), arrayParam(1))
        Next

        Return dicParams
    End Function

    Public Shared Function GetRepositoryItemLookUpEdit(ByVal Params() As String) As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Dim dtParams As DataTable = New DataTable
        dtParams = GetStringToDatatable(Params)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dtParams

        Return editorCombo
    End Function
    Private Shared Function GetStringToDatatable(ByVal Params() As String) As DataTable
        Dim dtParams As DataTable = New DataTable
        dtParams.Columns.Add(New DataColumn("CODE", GetType(String)))
        dtParams.Columns.Add(New DataColumn("NAME", GetType(String)))

        Dim arrayParam() As String = Nothing

        For Each EachParam In Params
            arrayParam = Split(EachParam, ":")
            If arrayParam(0).ToString = "" Then Continue For
            dtParams.Rows.Add(arrayParam(0), arrayParam(1))
        Next

        Return dtParams
    End Function

    Public Shared Function GetRepositoryItemCodeBoxEdit(ByVal CodeType As String, Optional ByVal DataParams As String = "", Optional ByVal DisplayParams As String = "", Optional ByVal ValidateKeys As String = "") As YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim editorCode As YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit

        With editorCode
            .CodeType = "YJIT.CodeService." & CodeType
            .DataParams = DataParams
            .SearchPopup = "CodeMaster"
        End With

        Select Case CodeType.ToUpper.Trim
            Case "CommonCode".ToUpper.Trim
                With editorCode
                    .DisplayParams = DisplayParams
                    .ValidateKeys = ValidateKeys
                    '.MaxLength = 3 'GroupCode기준으로 틀려짐
                End With
            Case "Customer".ToUpper.Trim
                With editorCode
                    .DisplayParams = IIf(DisplayParams = "", "CODE:#CUST_CD,CUST_LOCNM:#CUST_NM", DisplayParams)
                    .ValidateKeys = IIf(ValidateKeys = "", "KEY:#CUST_CD", ValidateKeys)
                    '.MaxLength = 10
                End With
            Case "AccountCode".ToUpper.Trim
                With editorCode
                    .DisplayParams = IIf(DisplayParams = "", "CODE:#ACCT_CD,NAME:#ACCT_NM", DisplayParams)
                    .ValidateKeys = IIf(ValidateKeys = "", "KEY:#ACCT_CD", ValidateKeys)
                    '.MaxLength = 10
                End With
            Case Else

        End Select

        Return editorCode
    End Function

    Public Shared Sub SetGridAddRow(ByRef FormObj As Object, ByVal WebGrid As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvAddRow As New DataTable
        Dim dr As DataRow
        GvAddRow.Columns.Add("Key")
        GvAddRow.Columns.Add("Sender")
        GvAddRow.Columns.Add("Action", GetType(Action))
        GvAddRow.Rows.Add()
        dr = GvAddRow.Rows(0)

        dr("Sender") = WebGrid.Name
        dr("Key") = WebGrid.Name + "_AddRow"
        dr("Action") = Action.Addrow
        WebGrid.AddRow()
        FormObj.PopUpOnAfterClick(GvAddRow.Rows(0))
    End Sub


    ''' <summary>
    ''' 그리드 로컬운임 소수점 적용 함수
    ''' </summary>
    ''' <param name="WebGrid">WebGrid Name</param>
    ''' <param name="arrFieldName">그리드 컬럼명을 배열로 입력 Call GridFunc.SetGridColumnLocAmt(WG1, {"DR_LOC_AMT", "CR_LOC_AMT"})</param>
    ''' <remarks></remarks>
    Public Shared Sub SetGridColumnLocAmt(ByVal WebGrid As YJIT.SC.UI.SCControls.WebGrid, ByVal arrFieldName() As String, Optional ByVal DecimalPoint As Integer = -1)
        Try
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(WebGrid.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            For Each FieldName In arrFieldName
                If DecimalPoint = -1 Then DecimalPoint = ClientSessionOfficeInfo.DecimalPoint

                'Column기준으로 전체 Format을 적용합니다.
                Dim ri As New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
                view.Columns(FieldName).ColumnEdit = ri
                ri.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                ri.Mask.EditMask = "n" & ClientSessionOfficeInfo.DecimalPoint
                ri.Mask.UseMaskAsDisplayFormat = True

                view.Columns(FieldName).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                view.Columns(FieldName).DisplayFormat.FormatString = "{0:N" & DecimalPoint & "}"

                For Each col As DevExpress.XtraGrid.GridGroupSummaryItem In view.GroupSummary
                    Debug.Print(col.FieldName & vbTab & vbTab & FieldName)
                    If col.FieldName = FieldName Then
                        col.DisplayFormat = "{0:N" & DecimalPoint & "}"
                        'Exit For '컬럼 BAL_LOC_AMT2 이면서 합계컬럼이 BAL_LOC_AMT인경우 문제가 있어서 전체체크 하도록 변경
                    End If
                Next

                view.Columns(FieldName).SummaryItem.DisplayFormat = "{0:N" & DecimalPoint & "}"
            Next

            view.RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message & "(SetGridColumnLocAmt)")
        End Try
    End Sub

    ''' <summary>
    ''' 그리드 Row별로 CURR_CD 기준으로 Decimal Point 을 적용합니다.
    ''' </summary>
    ''' <param name="FieldName">그리드 컬럼명을 입력 Call GridFunc.SetGridCustomRowCellCurrAmt(sender, e, {"DR_LOC_AMT"})</param>
    ''' <remarks>GV1_CustomRowCellEdit 이벤트에서 사용해주세요.</remarks>
    ''' <remarks>DCM_POINT 컬럼이 그리드에 존재해야 합니다. (Decimal Point)</remarks>
    Public Shared Sub SetGridCustomRowCellCurrAmt(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs, ByVal arrFieldName() As String)
        Try
            Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
            If Not View.Columns.Contains(View.Columns("DCM_POINT")) Then Exit Sub

            If arrFieldName.Contains(e.Column.FieldName) Then
                Dim rpEdit As New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
                Dim DecimalPoint As Integer = View.GetRowCellValue(e.RowHandle, "DCM_POINT")

                rpEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                rpEdit.Mask.EditMask = "n" & DecimalPoint
                rpEdit.Mask.UseMaskAsDisplayFormat = True
                e.RepositoryItem = rpEdit

                e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                e.Column.DisplayFormat.FormatString = "{0:N" & DecimalPoint & "}"

                'For Each col As DevExpress.XtraGrid.GridGroupSummaryItem In View.GroupSummary
                '    If col.FieldName = e.Column.FieldName Then
                '        col.DisplayFormat = "{0:N" & DecimalPoint & "}"
                '        Exit For
                '    End If
                'Next

                '합계는 기준이 모호함
                'view.Columns.Item(e.Column.FieldName).SummaryItem.DisplayFormat = "{0:" & "n" & DecimalPoint & "}"
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "(SetGridCustomRowCellCurrAmt)")
        End Try

    End Sub
    Public Shared Sub AddGridRow(ByRef obj As YJIT.SC.UI.SCControls.WebGrid, ByRef popup As PopupBase)
        Dim GvAddRow As New DataTable
        Dim dr As DataRow

        GvAddRow.Columns.Add("Key")
        GvAddRow.Columns.Add("Sender")
        GvAddRow.Columns.Add("Action", GetType(Action))
        GvAddRow.Rows.Add()
        dr = GvAddRow.Rows(0)
        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_AddRow"
        dr("Action") = Action.Addrow

        popup.AddRow(dr)
    End Sub
    Public Shared Sub DelGridRow(ByRef obj As YJIT.SC.UI.SCControls.WebGrid, ByRef popup As PopupBase)
        Dim GvAddRow As New DataTable
        Dim dr As DataRow

        GvAddRow.Columns.Add("Key")
        GvAddRow.Columns.Add("Sender")
        GvAddRow.Columns.Add("Action", GetType(Action))
        GvAddRow.Rows.Add()
        dr = GvAddRow.Rows(0)
        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_DeleteRow"
        dr("Action") = Action.DeleteRow

        popup.DeleteRow(dr)
    End Sub
End Class

