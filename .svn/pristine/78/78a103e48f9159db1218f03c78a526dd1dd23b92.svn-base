Imports System.Drawing
Imports DevExpress.XtraEditors
Imports YJIT.SC.UI

Public Class CrmProjectMgt
    Private bBindToDataset As Boolean = False
    Private SearchFlag As Boolean = False
    Private bFormLoding As Boolean = False

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    YJSql.SqlBox("WG1", "CrmProjectMgt@Search", True)
                    YJSql.Params("DATE_TYPE_" & drMAIN("S_DATE_TYPE").ToString, drMAIN("S_DATE_TYPE").ToString)
                    YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                    YJSql.Params("CUST_NM", drMAIN("S_CUST_NM").ToString)
                    YJSql.Params("S_USR_ID", drMAIN("S_USR_ID").ToString) 'YJQuery 기본값하고 중복됨
                    YJSql.Params("PROC_TYPE", drMAIN("S_PROC_TYPE").ToString)

                    YJSql.SqlBox("WG2", "CrmProjectMgt@SearchUserCnt", True)
                    YJSql.Params("DATE_TYPE_" & drMAIN("S_DATE_TYPE").ToString, drMAIN("S_DATE_TYPE").ToString)
                    YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                    YJSql.Params("CUST_NM", drMAIN("S_CUST_NM").ToString)
                    YJSql.Params("S_USR_ID", drMAIN("S_USR_ID").ToString)
                    YJSql.Params("PROC_TYPE", drMAIN("S_PROC_TYPE").ToString)

                    YJSql.SqlBox("WG3", "CrmProjectMgt@SearchProcessCnt", True)
                    YJSql.Params("DATE_TYPE_" & drMAIN("S_DATE_TYPE").ToString, drMAIN("S_DATE_TYPE").ToString)
                    YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                    YJSql.Params("CUST_NM", drMAIN("S_CUST_NM").ToString)
                    YJSql.Params("S_USR_ID", drMAIN("S_USR_ID").ToString)
                    YJSql.Params("PROC_TYPE", drMAIN("S_PROC_TYPE").ToString)

                    YJSql.SqlBox("WG4", "CrmProjectMgt@SearchUserAmt", True)
                    YJSql.Params("DATE_TYPE_" & drMAIN("S_DATE_TYPE").ToString, drMAIN("S_DATE_TYPE").ToString)
                    YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                    YJSql.Params("CUST_NM", drMAIN("S_CUST_NM").ToString)
                    YJSql.Params("S_USR_ID", drMAIN("S_USR_ID").ToString)
                    YJSql.Params("PROC_TYPE", drMAIN("S_PROC_TYPE").ToString)

                    YJSql.SqlBox("WG5", "CrmProjectMgt@SearchNewCancel", True)
                    YJSql.Params("DATE_TYPE_" & drMAIN("S_DATE_TYPE").ToString, drMAIN("S_DATE_TYPE").ToString)
                    YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                    YJSql.Params("CUST_NM", drMAIN("S_CUST_NM").ToString)
                    YJSql.Params("S_USR_ID", drMAIN("S_USR_ID").ToString)
                    YJSql.Params("PROC_TYPE", drMAIN("S_PROC_TYPE").ToString)

                    YJSql.SqlBox("WG6", "CrmProjectMgt@SearchCntAmt", True)
                    YJSql.Params("DATE_TYPE_" & drMAIN("S_DATE_TYPE").ToString, drMAIN("S_DATE_TYPE").ToString)
                    YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                    YJSql.Params("CUST_NM", drMAIN("S_CUST_NM").ToString)
                    YJSql.Params("S_USR_ID", drMAIN("S_USR_ID").ToString)
                    YJSql.Params("PROC_TYPE", drMAIN("S_PROC_TYPE").ToString)

                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region


    Private Sub CrmProjectMgt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GridInit()
        Call SetDefault()
    End Sub

    Private Sub CrmProjectMgt_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            Call PopupInit()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            bFormLoding = True
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If MODIFY_YN.Text = "Y" Then
            If MsgBoxLocalized("기존 자료가 수정되었습니다. 초기화를 진행하시겠습니까?", MessageBoxButtons.YesNo, , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Call SearchData()
    End Sub

    Public Sub SearchData()
        Try
            If SearchFlag = True Then Exit Sub
            SearchFlag = True

            Call SetDateSync("Search")

            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsWeekly", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {WG1, WG2, WG3, WG4, WG5, WG6})
                    Me.BindToDataset(dsRet, "Data")
                    Call SetGridUserID()
                    MODIFY_YN.Text = "N"
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG1, WG2, WG3, WG4, WG5, WG6})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Call SetGridUserID()
                    MODIFY_YN.Text = "N"
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            SearchFlag = False
        End Try
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(S_DATE_TYPE.SelectedValue) Then
                If ErrControl Is Nothing Then ErrControl = S_DATE_TYPE
                'ErrMsg &= "Please input the Process Type" & vbNewLine
                ErrMsg &= "[날짜타입]을 선택해주세요." & vbNewLine
            End If
            If String.IsNullOrEmpty(S_FM_YMD.Text) OrElse String.IsNullOrEmpty(S_TO_YMD.Text) Then
                If String.IsNullOrEmpty(S_FM_YMD.Text) Then
                    If ErrControl Is Nothing Then ErrControl = S_FM_YMD
                Else
                    If ErrControl Is Nothing Then ErrControl = S_TO_YMD
                End If
                ErrMsg &= "[" & S_DATE_TYPE.Text & "]를 입력해주세요." & vbNewLine
            End If


            If Not String.IsNullOrEmpty(ErrMsg) Then
                'If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub SaveData()
        Call SetDateSync("Save")

        If SaveValidate() = False Then Exit Sub

        If MandatoryGridValue("GV1") Then Exit Sub

        Try
            Dim ds As DataSet = Me.ConvertToDataset
            If ds.Tables("WG1").Rows.Count = 0 Then
                MsgBoxLocalized("Save Data not found!")
                Exit Sub
            End If
            For Each dt As DataTable In GetConvertToDataSet("Search").Tables
                ds.Tables.Add(dt.Copy)
            Next
            Try
                ds = MethodCallEx(Me, "YJIT.Biz.CrmProjectMgt", "Save", ds)
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
                Exit Sub
            End Try

            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") = "Y" Then
                bBindToDataset = True
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.BindToDataset(ds, "Data")
                bBindToDataset = False
                MODIFY_YN.Text = "N"
                Me.DataState = UI.DataStates.Retrieved
            End If

            MsgBoxLocalized(dr("TrxMsg"))
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Function SaveValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrGrid As Object = Nothing
        Dim ErrGridRow As Integer = Nothing
        Dim ErrGridCol As Object = Nothing

        Try
            'MandatoryGridValue 사용중이라 일단 보류, datatable로 체크시 포커스 이동 불가

            'Dim dt As DataTable = Me.ConvertToDataset.Tables("WG1").Copy
            'For Each row As DataRow In dt.Rows
            '    If String.IsNullOrEmpty(row("BIZ_YMD").ToString) Then
            '        If ErrControl Is Nothing Then ErrControl = S_FM_YMD
            '        ErrMsg &= "[" & S_DATE_TYPE.SelectedText & "]를 입력해주세요." & vbNewLine
            '    End If

            '    Param("BIZ_YMD") = GV1_BIZ_YMD.Caption()
            '    Param("PROD_CD") = GV1_PROD_CD.Caption()
            '    Param("BIZ_TYPE") = GV1_BIZ_TYPE.Caption()

            'Next


            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then
                    ErrControl.Focus()
                Else
                    If Not ErrGrid Is Nothing Then
                        ErrGrid.FocusedRowHandle = ErrGridRow
                        ErrGrid.FocusedColumn = ErrGridCol
                        'ErrGrid.ShowEditor()
                    End If
                End If
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized("입력된 자료에 오류가 발견되었습니다. 아래 내용을 확인해주세요." & vbNewLine & vbNewLine & ex.Message)
            Return False
        End Try
    End Function
    Private Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing
        Select Case gridView
            Case "GV1"
                checkNull = {"BIZ_YMD", "USR_ID", "PROD_CD", "CUST_NM"}
                Param("BIZ_YMD") = GV1_BIZ_YMD.Caption()
                Param("USR_ID") = GV1_USR_ID.Caption()
                Param("PROD_CD") = GV1_PROD_CD.Caption()
                Param("CUST_NM") = GV1_CUST_NM.Caption()
                Return ValidateGridValue(GV1, Param, checkNull)
        End Select
        Return False
    End Function
    Private Sub setGridAddRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        If obj.Visible = False And obj.Enabled = False Then Exit Sub
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

        PopUpOnBeforeClick(GvAddRow.Rows(0))

        obj.AddRow()

        PopUpOnAfterClick(GvAddRow.Rows(0))
    End Sub

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    Private Sub SetDefault()
        '20201220 김성은 김은규과장 요청 
        'Dim thisWeekDay As Integer = Weekday(Now)
        'Dim toDate As Date = DateAdd(DateInterval.Day, 5 - thisWeekDay, Now)
        'S_FM_YMD.Text = DateAdd(DateInterval.Day, -6, toDate).ToString("yyyyMMdd")
        'S_TO_YMD.Text = toDate.ToString("yyyyMMdd")
        'S_DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode

        S_FM_YMD.Text = Now.ToString("yyyy") & "0101" '20210617 정지수 YJITS2021060407
        S_TO_YMD.Text = Now.ToString("yyyy") & "1231"

        MODIFY_YN.Text = "N"

        S_FM_YMD.Focus()
    End Sub

    Public Sub PopupInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd("InsertRow", "Add row", BarIcon.AddRow)
        PopUp.ItemAdd(Action.DeleteRow, "WG1_DELETEROW", "Delete row")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG1, "BIZ_YMD", "PIC_EMAIL")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG2)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG3)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG4)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG5)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG6)
    End Sub
    Private Sub SetGridFilterClear()
        GV2.ApplyFindFilter("")
        GV2.ClearSorting()
        GV2.ActiveFilterString = String.Empty
    End Sub
    Public Sub PopUpOnBeforeClick(ByVal dr As DataRow)
        Dim Key As String = dr("KEY")
        Dim Sender As String = ""
        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")

        Select Case dr("Action")
            Case Action.Addrow, Action.EventKey
                Select Case Sender
                    Case "WG1"
                        Call SetGridFilterClear()
                End Select
            Case Action.DeleteRow
                Select Case Sender
                    Case "WG1"
                        Call SetGridFilterClear()
                End Select
            Case Else
                Call SetGridFilterClear()
        End Select

    End Sub
    '# PopUpOnAfterClick
    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = ""
        If Not Dr("Sender") Is System.DBNull.Value Then Sender = Dr("Sender")

        Dim Id As String = ""
        If Key = "Enter" Then Id = Dr("ID")

        'Navigato 사용할떄
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        Dim rowIndex As Integer = 0

        Select Case Dr("Action")
            Case Action.NavigateTo
                'frmMain = Me.MdiParent
                'Select Case Key
                '    Case "ManifestPrint"
                '        Call ManifestPrint()
                '    Case "OmsOrdMgt_v2"
                '        fTarget = frmMain.NavigateTo("OmsOrdMgt")
                '        If Not IsNothing(fTarget) Then
                '            'fTarget.HBL_NO.text = HBL_NO.Text
                '            'fTarget.ShowDialog()
                '            fTarget.SearchOrdNo(HBL_NO.Text)
                '        End If
                'End Select
            Case Action.Addrow, Action.EventKey
                Select Case Sender
                    Case "WG1"
                        Call SetAddRowDefault()
                End Select
            Case Action.DeleteRow
                'Select Case Key
                '    Case "FWG1_DelRow"
                '        If UseSortSeq = True Then
                '            SetGridSortSeq(FGV1)
                '        End If
                'End Select
            Case Action.Other
                Select Case Dr("KEY").ToString
                    Case "InsertRow"
                        Call InsertGridRow(WG1)
                End Select
            Case Action.Excel
                'If Key = "WG1_ExportExcel" Then
                '    GV1.OptionsView.ShowViewCaption = True
                'End If
        End Select
    End Sub
    Private Sub InsertGridRow(ByVal Wg As YJIT.SC.UI.SCControls.WebGrid)
        Dim Gv As DevExpress.XtraGrid.Views.Grid.GridView = Wg.MainView

        If Gv.RowCount > 0 Then
            'Dim insRowIndex As Integer = Gv.FocusedRowHandle
            Dim insRowIndex As Integer = 0
            Dim dt As DataTable = CType(Wg.DataSource, DataTable)
            Dim dr2 As DataRow = dt.NewRow
            CType(Wg.DataSource, DataTable).Rows.InsertAt(dr2, insRowIndex)
            Gv.FocusedRowHandle = Gv.FocusedRowHandle - 1

            Call SetAddRowDefault()
        End If
    End Sub
    Private Sub SetAddRowDefault()
        Try
            bBindToDataset = True
            GV1.ApplyFindFilter("")
            GV1.ClearSorting()
            GV1.ActiveFilterString = String.Empty

            For i = 0 To GV1.RowCount - 1
                If String.IsNullOrEmpty(GV1.GetRowCellValue(i, "BIZ_YMD").ToString) Then
                    GV1.FocusedRowHandle = i

                    GV1.SetFocusedRowCellValue("BIZ_YMD", Now.ToString("yyyyMMdd"))
                    GV1.SetFocusedRowCellValue("DEPT_CD", ClientSessionInfo.OrganizationCode)
                    GV1.SetFocusedRowCellValue("USR_ID", ClientSessionInfo.UserID)
                    GV1.SetFocusedRowCellValue("CMPT_RATE", 0)
                    GV1.SetFocusedRowCellValue("ORD_AMT", 0)
                    GV1.SetFocusedRowCellValue("CTRT_AMT", 0)
                    GV1.SetFocusedRowCellValue("IDC_AMT", 0)
                    GV1.SetFocusedRowCellValue("MATN_AMT", 0)
                    GV1.SetFocusedRowCellValue("COST_AMT", 0)
                    GV1.SetFocusedRowCellValue("PROFIT_AMT", 0)

                    If GV1.FocusedRowHandle < GV1.TopRowIndex Then
                        GV1.TopRowIndex = GV1.FocusedRowHandle - 1
                    End If

                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            bBindToDataset = False
        End Try
    End Sub

    Private Sub SetGridUserID()
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        dt = New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                            AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("CRM_USR_MST") Then
            Dim drUser() As DataRow = Nothing
            If String.IsNullOrEmpty(S_DEPT_CD.SelectedValue) Then
                drUser = YJIT.SC.UI.SCView.PreloadedCodeListData("CRM_USR_MST").Select("1 = 1", "SORT ASC ,LOC_NM ASC")
            Else
                drUser = YJIT.SC.UI.SCView.PreloadedCodeListData("CRM_USR_MST").Select("DEPT_CD ='" & S_DEPT_CD.SelectedValue & "'", "SORT ASC ,LOC_NM ASC")
            End If
            For Each drRow As DataRow In drUser
                dr = dt.NewRow
                dr("CODE") = drRow("USR_ID").ToString
                'dr("NAME") = dt.Rows.Count + 1 & "." & drRow("LOC_NM").ToString
                dr("NAME") = drRow("LOC_NM").ToString
                dt.Rows.Add(dr)
            Next
        End If
        dr = dt.NewRow
        dr("CODE") = ""
        dr("NAME") = "--Select--"
        dt.Rows.InsertAt(dr, 0)
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("USR_ID").ColumnEdit = editorCombo

    End Sub

    Private Sub GridInit()
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim dt As DataTable = Nothing


        Common.DrawRowIndicator({GV1, GV2, GV3, GV4})
        Call SetGridUserID()


        Dim editorDate As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        editorDate = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV1.Columns("BIZ_YMD").ColumnEdit = editorDate

        'GV1.Columns("CTRT_YMD").ColumnEdit = editorDate

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "P01")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("PROD_CD").ColumnEdit = editorCombo


        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "P02")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("BIZ_TYPE").ColumnEdit = editorCombo

        editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        editor.CodeType = "YJIT.CodeService.Customer"
        editor.DisplayParams = "Code:#CUST_CD,CUST_LOCNM:#CUST_NM"
        editor.ValidateKeys = "KEY:#CUST_CD"
        editor.DataParams = "Type:''"
        editor.KeepIntegrity = False '거래처명 별도 관리
        editor.AutoSuggestion = False
        editor.MaxLength = "10"
        editor.SearchPopup = "CustomerMaster"
        editor.CharacterCasing = CharacterCasing.Upper
        GV1.Columns("CUST_CD").ColumnEdit = editor

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))
        AddNewRow(dt, "0", "0%")
        AddNewRow(dt, "10", "10%")
        AddNewRow(dt, "20", "20%")
        AddNewRow(dt, "30", "30%")
        AddNewRow(dt, "40", "40%")
        AddNewRow(dt, "50", "50%")
        AddNewRow(dt, "60", "60%")
        AddNewRow(dt, "70", "70%")
        AddNewRow(dt, "80", "80%")
        AddNewRow(dt, "90", "90%")
        AddNewRow(dt, "100", "100%")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("CMPT_RATE").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DropDownRows = 10
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "P03")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("PROC_TYPE").ColumnEdit = editorCombo




        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "P04")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("CTRT_RCV_YN").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "P05")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("SETUP_TAX_YN").ColumnEdit = editorCombo
        GV1.Columns("MONTH_TAX_YN").ColumnEdit = editorCombo


        Dim memoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        memoExEdit.PopupFormSize = New Size(GV1.Columns("RMK").Width * 2, 200)
        memoExEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        memoExEdit.ShowIcon = False
        memoExEdit.MaxLength = 2000
        memoExEdit.ScrollBars = ScrollBars.Vertical
        'memoExEdit.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Space)
        GV1.Columns("RMK").ColumnEdit = memoExEdit
        RemoveHandler memoExEdit.KeyPress, AddressOf MemoExEdit_KeyPress
        AddHandler memoExEdit.KeyPress, AddressOf MemoExEdit_KeyPress

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.ValueMember = "CODE"
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.NullText = ""
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "P06")
        'dataParams.Add("NameType", "")
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'editorCombo.ForceInitialize()
        'editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'editorCombo.ShowHeader = False
        'GV1.Columns("JOIN_TYPE").ColumnEdit = editorCombo

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.ValueMember = "CODE"
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.NullText = ""
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "P07")
        'dataParams.Add("NameType", "")
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'editorCombo.ForceInitialize()
        'editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'editorCombo.ShowHeader = False
        'GV1.Columns("JOIN_ROUTE").ColumnEdit = editorCombo

    End Sub
    Private Sub MemoExEdit_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If AscW(e.KeyChar) = Keys.Space Then
                'e.Handled = True
                Dim memoExEdit = TryCast(sender, MemoExEdit)
                memoExEdit.ShowPopup()
                SendKeys.Send("^+{End}")
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message & " (MemoExEdit_KeyPress)")
        End Try
    End Sub

    Private Sub SetDateSync(ByVal EventName As String)
        If bFormLoding = False Then Exit Sub

        Select Case EventName.ToUpper
            Case "SelectedValueChanged".ToUpper
                If S_DATE_TYPE.SelectedValue = "C" Then
                    S_FM_YM.Text = Mid(S_FM_YMD.Text.Replace("-", ""), 1, 6)
                    S_TO_YM.Text = Mid(S_TO_YMD.Text.Replace("-", ""), 1, 6)
                Else
                    S_FM_YMD.Text = S_FM_YM.Text.Replace("-", "") & "01"

                    Dim sToymd As String = String.Format("{0}-{1}-01", Mid(S_TO_YM.Text.Replace("-", ""), 1, 4), Mid(S_TO_YM.Text.Replace("-", ""), 5, 2))
                    If Not IsDate(sToymd) Then Exit Sub
                    S_TO_YMD.Text = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, CDate(sToymd))).ToString("yyyyMMdd")
                End If
            Case Else
                If S_DATE_TYPE.SelectedValue = "C" Then
                    S_FM_YMD.Text = S_FM_YM.Text.Replace("-", "") & "01"

                    Dim sToymd As String = String.Format("{0}-{1}-01", Mid(S_TO_YM.Text.Replace("-", ""), 1, 4), Mid(S_TO_YM.Text.Replace("-", ""), 5, 2))
                    If Not IsDate(sToymd) Then Exit Sub
                    S_TO_YMD.Text = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, CDate(sToymd))).ToString("yyyyMMdd")
                End If
        End Select
    End Sub

    Private Sub GV1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        If bBindToDataset = True Then Exit Sub
        If sender.RowCount = 0 Then Exit Sub
        If e.RowHandle < 0 Then Exit Sub
        If sender.IsValidRowHandle(e.RowHandle) = False Then Exit Sub
        If Not sender.Tag Is Nothing AndAlso sender.Tag.Equals("SetGridSelectAll") Then Exit Sub

        Select Case e.Column.FieldName
            Case "IDC_AMT"
                Dim dr As DataRow = sender.GetDataRow(e.RowHandle)
                If Not IsNumeric(dr("IDC_AMT").ToString) Then dr("IDC_AMT") = 0
            Case "MATN_AMT"
                Dim dr As DataRow = sender.GetDataRow(e.RowHandle)
                If Not IsNumeric(dr("MATN_AMT").ToString) Then dr("MATN_AMT") = 0
            Case "PROFIT_AMT"
                Dim dr As DataRow = sender.GetDataRow(e.RowHandle)
                If Not IsNumeric(dr("PROFIT_AMT").ToString) Then dr("PROFIT_AMT") = 0
            Case "ORD_AMT", "CTRT_AMT", "COST_AMT"
                Try
                    Dim dr As DataRow = sender.GetDataRow(e.RowHandle)

                    If Not IsNumeric(dr("ORD_AMT").ToString) Then dr("ORD_AMT") = 0
                    If Not IsNumeric(dr("CTRT_AMT").ToString) Then dr("CTRT_AMT") = 0
                    If Not IsNumeric(dr("COST_AMT").ToString) Then dr("COST_AMT") = 0

                    If IsDBNull(dr("ORD_AMT").ToString) OrElse
                               IsDBNull(dr("CTRT_AMT").ToString) OrElse
                               IsDBNull(dr("COST_AMT").ToString) Then
                        Exit Sub
                    End If
                    If Not IsNumeric(dr("ORD_AMT").ToString) OrElse
                               Not IsNumeric(dr("CTRT_AMT").ToString) OrElse
                               Not IsNumeric(dr("COST_AMT").ToString) Then
                        Exit Sub
                    End If

                    dr("PROFIT_AMT") = (CDec(dr("ORD_AMT")) + CDec(dr("CTRT_AMT"))) - CDec(dr("COST_AMT"))
                Catch ex As Exception
                    MsgBoxLocalized(ex.Message & " (PROFIT_AMT)")
                End Try
            Case "BIZ_TYPE", "PROC_TYPE"
                Dim dr As DataRow = sender.GetDataRow(e.RowHandle)
                dr("BIZ_COND") = GV1.GetRowCellDisplayText(e.RowHandle, "BIZ_TYPE").ToString & GV1.GetRowCellDisplayText(e.RowHandle, "PROC_TYPE").ToString
        End Select

        sender.RefreshData()

        MODIFY_YN.Text = "Y"
    End Sub



    Private Sub S_DEPT_CD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_DEPT_CD.SelectedIndexChanged, S_PROC_TYPE.SelectedIndexChanged
        'Call SetGridUserID()
        S_USR_ID.DataParams = "Type:'',Office:'" & ClientSessionInfo.OfficeCode & "',Dept:'" & S_DEPT_CD.SelectedValue & "'"
    End Sub

    Private Sub S_DATE_TYPE_SelectedValueChanged(sender As Object, e As EventArgs) Handles S_DATE_TYPE.SelectedValueChanged
        If bFormLoding = False Then Exit Sub

        If S_DATE_TYPE.SelectedValue = "C" Then
            S_DATE_TYPE.NextFocus = "S_FM_YM"

            S_FM_YM.Visible = True
            S_TO_YM.Visible = True
            S_FM_YM.Left = S_FM_YMD.Left
            S_FM_YM.Top = S_FM_YMD.Top
            S_FM_YM.Size = New Size(S_FM_YMD.Width - 21, S_FM_YMD.Height)
            S_FM_YM.Text = S_FM_YMD.Text

            S_TO_YM.Left = S_TO_YMD.Left
            S_TO_YM.Top = S_TO_YMD.Top
            S_TO_YM.Size = New Size(S_TO_YMD.Width - 21, S_TO_YMD.Height)
            S_TO_YM.SelectionStart = 0
            S_TO_YM.Text = S_TO_YMD.Text

            S_FM_YM.Focus()
        Else
            S_DATE_TYPE.NextFocus = "S_FM_YMD"

            S_FM_YM.Visible = False
            S_TO_YM.Visible = False

            S_FM_YMD.Focus()
        End If

        Call SetDateSync("SelectedValueChanged")
    End Sub

    'Private Sub S_FM_YM_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles S_FM_YM.PreviewKeyDown
    '    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
    '        S_FM_YM.Focus()
    '    End If
    'End Sub

    Private Sub S_TO_YM_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles S_TO_YM.PreviewKeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            S_TO_YMD.Focus()
        End If
    End Sub

    'Private Sub S_FM_YM_KeyDown(sender As Object, e As KeyEventArgs) Handles S_FM_YM.KeyDown
    '    MsgBox("2")
    'End Sub
End Class