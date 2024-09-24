Imports Microsoft.VisualBasic
Imports System
Imports YJIT.SC.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports YJIT.SC.UI.SCControls
Imports DevExpress.XtraEditors
Imports System.Drawing

Public Class CrmAsDaily
    Dim bShowDateBoxEdit As Boolean = True
    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    Dim dtREQ_SVC2 As DataTable = Nothing
#Region "=================Data logic actions==========="
    Public Sub NewData()
        Me.ClearView(UI.AppliedRangeTypes.All)
        Call SetDefault()
        Call AddGridRow(WG1)
        GV1.FocusedColumn = GV1.Columns("REQ_YMDHM")
        GV1.ShowEditor()
    End Sub
    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            YJSql.SqlBox("WG1", "CrmAsDaily@Search", , False)
            If drMAIN("S_DATE_TYPE").ToString = "R" Then
                YJSql.Params("REQ_FM_YMD", drMAIN("S_REQ_FM_YMD").ToString.Trim)
                YJSql.Params("REQ_TO_YMD", drMAIN("S_REQ_TO_YMD").ToString.Trim)
            ElseIf drMAIN("S_DATE_TYPE").ToString = "P" Then
                YJSql.Params("PRAR_FM_YMD", drMAIN("S_REQ_FM_YMD").ToString.Trim)
                YJSql.Params("PRAR_TO_YMD", drMAIN("S_REQ_TO_YMD").ToString.Trim)
            ElseIf drMAIN("S_DATE_TYPE").ToString = "C" Then
                YJSql.Params("CMPT_FM_YMD", drMAIN("S_REQ_FM_YMD").ToString.Trim)
                YJSql.Params("CMPT_TO_YMD", drMAIN("S_REQ_TO_YMD").ToString.Trim)
            End If
            YJSql.Params("INS_USR", drMAIN("S_WORK_USR").ToString.Trim)
            YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString.Trim)
            YJSql.Params("PROJECT_CD", drMAIN("S_PROJECT_CD").ToString.Trim)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet()

        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 자료검색중입니다.")
            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsDaily", "Search", {dsRet})
        End Using
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.BindToDataset(dsRet, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                YJIT.SC.UI.SCView.MsgBoxTimeout = 1
                YJIT.SC.UI.SCView.MsgBoxTimeoutKeyWords = drPairs("TrxMsg")
                MsgBoxLocalized(drPairs("TrxMsg"))
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(S_REQ_FM_YMD.Text.ToString) OrElse String.IsNullOrEmpty(S_REQ_TO_YMD.Text.ToString) Then
                If ErrControl Is Nothing Then
                    If String.IsNullOrEmpty(S_REQ_TO_YMD.Text) Then
                        ErrControl = S_REQ_TO_YMD
                    Else
                        ErrControl = S_REQ_FM_YMD
                    End If
                End If
                ErrMsg &= "요청일자를 입력해주세요!" & vbNewLine
            End If

            '20200122 김성은 전체조회 가능하도록 변경
            'If String.IsNullOrEmpty(S_DEPT_CD.SelectedValue.ToString) Then
            '    If ErrControl Is Nothing Then ErrControl = S_DEPT_CD
            '    ErrMsg &= "등록부서를 선택해주세요!" & vbNewLine
            'End If


            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function
    Public Sub SaveData()

        If MandatoryGridValue("GV1") Then Exit Sub
        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset
        If ds.Tables("WG1").Rows.Count = 0 Then
            MsgBoxLocalized("Data is empty!")
            Exit Sub
        End If

        'Save Data
        Dim dr As DataRow
        For Each dt As DataTable In GetConvertToDataSet.Tables
            ds.Tables.Add(dt.Copy)
        Next

        Try
            'ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmWBSMgt", "Save", ds)
            ds = MethodCallEx(Me, "YJIT.Biz.CrmAsDaily", "Save", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Call ClearView(AppliedRangeTypes.Only, {WG1})
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
            YJIT.SC.UI.SCView.MsgBoxTimeout = 1
            YJIT.SC.UI.SCView.MsgBoxTimeoutKeyWords = "저장되었습니다."
            MsgBoxLocalized("저장되었습니다.")
        Else
            MsgBoxLocalized(dr("TrxMsg"))
        End If



    End Sub
    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing
        Select Case gridView
            Case "GV1"
                checkNull = {"CONTENT"}
                Param("REQ_YMD") = GV1_REQ_YMD.Caption()
                Param("REQ_HM") = GV1_REQ_HM.Caption()
                Param("REQ_TYPE2") = GV1_REQ_TYPE2.Caption()
                Param("CONTENT") = GV1_CONTENT.Caption()
                Param("CUST_CD") = GV1_CUST_CD.Caption()
                Return ValidateGridValue(GV1, Param, checkNull)
        End Select
        Return False
    End Function
    Private Sub initGrid()
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim dt As New DataTable


        '상태
        GV1.Columns("PROC_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:'T07',NameType:''")

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.ValueMember = "CODE"
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.NullText = ""
        'Dim searchParams As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        'Dim dataParams As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "T07")
        'dataParams.Add("NameType", "")
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'GV1.Columns("PROC_TYPE").ColumnEdit = editorCombo
        'editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
        ''AddHandler editorCombo.Closed, AddressOf PROC_TYPE_Closed


        '업무구분1
        dt = New DataTable : dt.Columns.Add("CODE", GetType(String)) : dt.Columns.Add("NAME", GetType(String))
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T02' AND OPT_ITEM4 LIKE '%" & ClientSessionInfo.OrganizationCode & "%'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        editorCombo.DataSource = dt
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        editorCombo.ShowHeader = False
        GV1.Columns("REQ_SVC").ColumnEdit = editorCombo
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
        'AddHandler editorCombo.Closed, AddressOf REQ_SVC_Closed

        '업무구분2
        dtREQ_SVC2 = New DataTable : dtREQ_SVC2.Columns.Add("CODE", GetType(String)) : dtREQ_SVC2.Columns.Add("NAME", GetType(String)) : dtREQ_SVC2.Columns.Add("OPT_ITEM1", GetType(String))
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
               AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T10'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dtREQ_SVC2.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dr("OPT_ITEM1") = drRow("OPT_ITEM1").ToString
                    dtREQ_SVC2.Rows.Add(dr)
                Next
            End If
        End If
        If dtREQ_SVC2 IsNot Nothing Then
            editorCombo.DataSource = dtREQ_SVC2
            editorCombo.ValueMember = "CODE"
            editorCombo.DisplayMember = "NAME"
            editorCombo.NullText = ""
            editorCombo.ShowHeader = False
            GV1.Columns("REQ_SVC2").ColumnEdit = editorCombo
            editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
            editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
            editorCombo.Columns("OPT_ITEM1").Visible = False
            'AddHandler editorCombo.Closed, AddressOf REQ_SVC2_Closed
        End If


        '업무구분3
        dt = New DataTable : dt.Columns.Add("CODE", GetType(String)) : dt.Columns.Add("NAME", GetType(String))
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T09' AND OPT_ITEM4 LIKE '%" & ClientSessionInfo.OrganizationCode & "%'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DataSource = dt
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        editorCombo.ShowHeader = False
        GV1.Columns("REQ_TYPE2").ColumnEdit = editorCombo
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
        'AddHandler editorCombo.Closed, AddressOf REQ_TYPE2_Closed


        '거래처
        GV1.Columns("CUST_CD").ColumnEdit = GridFunc.GetRepositoryItemCodeBoxEdit("Customer", "USE_YN:'Y',NameType:''", "Code:#CUST_CD,Name:#CUST_NM", "KEY:#CUST_CD")
        'editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        'editor.CodeType = "YJIT.CodeService.Customer"
        'editor.DisplayParams = "Code:#CUST_CD,Name:#CUST_NM"
        'editor.ValidateKeys = "KEY:#CUST_CD"
        'editor.DataParams = "USE_YN:'Y',NameType:''"
        'editor.KeepIntegrity = True
        'editor.AutoSuggestion = False
        'editor.CharacterCasing = CharacterCasing.Upper
        'GV1.Columns("CUST_CD").ColumnEdit = editor

        '프로젝트
        GV1.Columns("PROJECT_CD").ColumnEdit = GridFunc.GetRepositoryItemCodeBoxEdit("CommonCode", "GroupCode:'T16',NameType:'',Valid:'V'", "CODE:#PROJECT_CD,Name:#PROJECT_NM", "KEY:#PROJECT_CD")
        'editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        'editor.CodeType = "YJIT.CodeService.CommonCode"
        'editor.DisplayParams = "CODE:#PROJECT_CD,Name:#PROJECT_NM"
        'editor.ValidateKeys = "KEY:#PROJECT_CD"
        'editor.DataParams = "GroupCode:'T16',NameType:'',Valid:'V'"
        'editor.KeepIntegrity = True
        'editor.AutoSuggestion = False
        'GV1.Columns("PROJECT_CD").ColumnEdit = editor

        '담당자공유
        GV1.Columns("DEV_AUTH").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:'C11',NameType:''",,, " ")

        '타부서공유
        GV1.Columns("DEPT_AUTH_LIST").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:'C03',NameType:''",,, " ")
        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.ValueMember = "CODE"
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.NullText = ""
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "C03")
        'dataParams.Add("NameType", "")
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'GV1.Columns("DEPT_AUTH_LIST").ColumnEdit = editorCombo
        'editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)



        GV1.Columns("SYS_ID").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx({"CRM:CRM", "MAIL:MAIL", "ELVIS:ELVIS", "ELVISCONSOL:ELVISCONSOL", "ELVIS21:ELVIS21", "WEB:WEB", "WEBQ:WEBQ"})
        GV1.Columns("RANK").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:'T01',NameType:''")


        Dim memoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        memoExEdit.PopupFormSize = New Size(GV1.Columns("CONTENT").Width, 300)
        memoExEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        memoExEdit.ShowIcon = False
        'memoExEdit.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        'memoExEdit.Appearance.Options.UseFont = True
        'memoExEdit.AppearanceDropDown.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        'memoExEdit.AppearanceDropDown.Options.UseFont = True
        'memoExEdit.AppearanceDropDown.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        'memoExEdit.AppearanceDropDown.Options.UseFont = True
        memoExEdit.MaxLength = 4000
        memoExEdit.ScrollBars = ScrollBars.Vertical
        'memoExEdit.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Space)
        GV1.Columns("CONTENT").ColumnEdit = memoExEdit
        GV1.Columns("RMK").ColumnEdit = memoExEdit
        RemoveHandler memoExEdit.KeyPress, AddressOf MemoExEdit_KeyPress
        AddHandler memoExEdit.KeyPress, AddressOf MemoExEdit_KeyPress
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
#End Region
#Region "=================Control Events==========="
    Private Sub ComDelLogMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'YJIT.SC.UI.SCView.AppAutoSuggestion = False
        Call initGrid
        Call SetDefault()
    End Sub
    Private Sub ComDelLogMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopupInit()
        Call AddGridRow(WG1)
        GV1.FocusedColumn = GV1.Columns("REQ_YMDHM")
        GV1.ShowEditor()
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub GV1_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV1.CustomColumnDisplayText
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = TryCast(sender, DevExpress.XtraGrid.Views.Base.ColumnView)
        If e.Column.FieldName = "CUST_CD" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CUST_NM").ToString) Then
                e.DisplayText = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CUST_NM").ToString
            End If
        ElseIf e.Column.FieldName = "PROJECT_CD" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "PROJECT_NM").ToString) Then
                e.DisplayText = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "PROJECT_NM").ToString
            End If
        End If
    End Sub
    Private Sub GV1_ShownEditor(sender As System.Object, e As System.EventArgs) Handles GV1.ShownEditor
        Dim view As GridView = TryCast(sender, GridView)



        Select Case view.FocusedColumn.FieldName
            Case "REQ_YMDHM"
                Dim te As TextEdit = CType(view.ActiveEditor, TextEdit)
                If Not String.IsNullOrEmpty(te.EditValue) Then
                    te.SelectionStart = te.Text.Length
                    te.SelectionLength = 0
                End If
            Case "REQ_SVC2"
                Dim dt As DataTable = dtREQ_SVC2.Copy
                Dim clone As DataView = New DataView(dt)
                clone.RowFilter = "[OPT_ITEM1] = '" & view.GetRowCellValue(view.FocusedRowHandle, "REQ_SVC").ToString & "'"
                Dim edit As DevExpress.XtraEditors.LookUpEdit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
                edit.Properties.DataSource = clone
        End Select





        Select Case view.ActiveEditor.EditorTypeName
            '20200810 김성은 불편해서 제거
            'Case "DateBoxEdit"
            '    If bShowDateBoxEdit = False Then Exit Sub
            '    Dim edit As DateBoxEdit = CType(view.ActiveEditor, DateBoxEdit)
            '    edit.ShowDatePicker()
            '    bShowDateBoxEdit = False
            Case Else
                view.GridControl.BeginInvoke(New MethodInvoker(Sub()
                                                                   Dim edit As PopupBaseEdit = TryCast(view.ActiveEditor, PopupBaseEdit)
                                                                   If edit Is Nothing Then
                                                                       Return
                                                                   End If
                                                                   edit.ShowPopup()
                                                                   edit.SelectionStart = edit.Text.Length
                                                                   edit.SelectionLength = 0
                                                               End Sub))
        End Select

    End Sub
    Private Sub GV1_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        Select Case e.Column.FieldName
            Case "REQ_YMDHM"
                If GV1.GetRowCellValue(GV1.FocusedRowHandle, "REQ_YMDHM").ToString <> "" Then
                    Dim day As String = Mid(GV1.GetRowCellValue(GV1.FocusedRowHandle, "REQ_YMDHM").ToString.Trim, 1, 8)
                    Dim time As String = Mid(GV1.GetRowCellValue(GV1.FocusedRowHandle, "REQ_YMDHM").ToString.Trim, 9, 4)
                    GV1.SetRowCellValue(GV1.FocusedRowHandle, "REQ_YMD", day)
                    GV1.SetRowCellValue(GV1.FocusedRowHandle, "REQ_HM", time)
                End If

            Case "CMPT_YMDHM"
                If GV1.GetRowCellValue(GV1.FocusedRowHandle, "CMPT_YMDHM").ToString <> "" Then
                    Dim day As String = Mid(GV1.GetRowCellValue(GV1.FocusedRowHandle, "CMPT_YMDHM").ToString.Trim, 1, 8)
                    Dim time As String = Mid(GV1.GetRowCellValue(GV1.FocusedRowHandle, "CMPT_YMDHM").ToString.Trim, 9, 4)
                    GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_YMD", day)
                    GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_HM", time)
                Else
                    GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_YMD", "")
                    GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_HM", "")
                End If
                'Case "REQ_SVC"
                '    Dim dt As DataTable = New DataTable : dt.Columns.Add("CODE", GetType(String)) : dt.Columns.Add("NAME", GetType(String))
                '    Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
                '    editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
                '    If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                '           AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then

                '        Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T10' AND OPT_ITEM1 = '" & GV1.GetRowCellValue(GV1.FocusedRowHandle, "REQ_SVC").ToString & "'", "SORT ASC")
                '        If drMdm.Count > 0 Then
                '            For Each drRow As DataRow In drMdm
                '                Dim dr As DataRow = dt.NewRow
                '                dr("CODE") = drRow("COMN_CD").ToString
                '                dr("NAME") = drRow("CD_NM").ToString
                '                dt.Rows.Add(dr)
                '            Next
                '        End If
                '    End If
                '    editorCombo.DataSource = dt
                '    editorCombo.ValueMember = "CODE"
                '    editorCombo.DisplayMember = "NAME"
                '    editorCombo.NullText = ""
                '    editorCombo.ShowHeader = False
                '    GV1.Columns("REQ_SVC2").ColumnEdit = editorCombo

            Case "PROC_TYPE"
                If GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString = "1" Then
                    GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_YMDHM", Now.ToString("yyyyMMddHHmm"))
                End If
            Case "DEV_AUTH"
                If String.IsNullOrEmpty(GV1.GetRowCellValue(GV1.FocusedRowHandle, "DEV_AUTH").ToString) Then
                    Dim row As DataRow = GV1.GetFocusedDataRow
                    row("DEPT_AUTH_LIST") = String.Empty
                    Exit Sub
                End If

                If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
                    Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='C11' AND COMN_CD = '" & GV1.GetRowCellValue(GV1.FocusedRowHandle, "DEV_AUTH").ToString & "'", "SORT ASC")
                    If drMdm.Count > 0 Then
                        For Each drRow As DataRow In drMdm
                            GV1.SetRowCellValue(GV1.FocusedRowHandle, "DEV_USR_ID", drRow("OPT_ITEM1").ToString)
                            GV1.SetRowCellValue(GV1.FocusedRowHandle, "DEPT_AUTH_LIST", drRow("OPT_ITEM2").ToString)
                            Exit For
                        Next
                    Else
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "DEV_USR_ID", String.Empty)
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "DEPT_AUTH_LIST", String.Empty)
                    End If
                    If Not String.IsNullOrEmpty(GV1.GetRowCellValue(GV1.FocusedRowHandle, "DEV_AUTH").ToString) AndAlso GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString = "7" Then
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_YMD", Now.ToString("yyyyMMdd"))
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_HM", Now.ToString("HHmmss"))
                    End If
                End If
            Case "DEPT_AUTH_LIST"
                If String.IsNullOrEmpty(GV1.GetRowCellValue(GV1.FocusedRowHandle, "DEPT_AUTH_LIST").ToString) Then
                    Dim row As DataRow = GV1.GetFocusedDataRow
                    row("DEV_AUTH") = String.Empty
                    Exit Sub
                End If

                If Not String.IsNullOrEmpty(GV1.GetRowCellValue(GV1.FocusedRowHandle, "DEPT_AUTH_LIST").ToString) _
                         AndAlso (String.IsNullOrEmpty(GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString) OrElse GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString = 0) Then
                    GV1.SetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE", "7")
                End If
                If Not String.IsNullOrEmpty(GV1.GetRowCellValue(GV1.FocusedRowHandle, "DEPT_AUTH_LIST").ToString) AndAlso GV1.GetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE").ToString = "7" Then
                    GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_YMD", Now.ToString("yyyyMMdd"))
                    GV1.SetRowCellValue(GV1.FocusedRowHandle, "CMPT_HM", Now.ToString("HHmmss"))
                End If
        End Select
    End Sub
    Private Sub btnDelWg2_Click(sender As System.Object, e As System.EventArgs) Handles btnDelWg2.Click
        Call DelGridRow(WG1)
    End Sub
    'Private Sub REQ_TYPE2_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs)
    '    GV1.FocusedColumn = GV1.Columns(GV1.FocusedColumn.VisibleIndex + 1)
    '    GV1.ShowEditor()
    'End Sub
    'Private Sub REQ_SVC_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs)
    '    GV1.FocusedColumn = GV1.Columns(GV1.FocusedColumn.VisibleIndex + 1)
    '    GV1.ShowEditor()
    'End Sub
    'Private Sub REQ_SVC2_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs)
    '    GV1.FocusedColumn = GV1.Columns(GV1.FocusedColumn.VisibleIndex + 1)
    '    GV1.ShowEditor()
    'End Sub
    'Private Sub PROC_TYPE_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs)
    '    GV1.FocusedColumn = GV1.Columns(GV1.FocusedColumn.VisibleIndex + 1)
    '    GV1.ShowEditor()
    'End Sub
    Private Sub btnAddWg2_Click(sender As System.Object, e As System.EventArgs) Handles btnAddWg2.Click
        Call AddGridRow(WG1)
    End Sub
    Private Sub GV1_FocusedColumnChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GV1.FocusedColumnChanged
        bShowDateBoxEdit = True
    End Sub
    Private Sub btnExpWg2_Click(sender As System.Object, e As System.EventArgs) Handles btnExpWg2.Click
        Common.ExportToExcel(WG1)
    End Sub
    Private Sub GV1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If e.RowHandle < 0 Then Exit Sub
        Select Case e.Column.FieldName
            Case "PROC_TYPE"
                If GV1.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString = "7" Then
                    e.Appearance.BackColor = System.Drawing.Color.Salmon
                End If
        End Select
    End Sub
    Private Sub btn_schcopy_Click(sender As System.Object, e As System.EventArgs) Handles btn_schcopy.Click
        Call ApplyProc()
    End Sub
    Private Sub S_REQ_FM_YMD_Leave(sender As System.Object, e As System.EventArgs) Handles S_REQ_FM_YMD.Leave
        If S_REQ_FM_YMD.Text > S_REQ_TO_YMD.Text Then
            S_REQ_TO_YMD.Text = S_REQ_FM_YMD.Text
        End If
    End Sub
#End Region
#Region "=================Client Function==========="
    Private Sub SetDefault()
        S_REQ_FM_YMD.Text = Now.ToString("yyyyMMdd")
        S_REQ_TO_YMD.Text = Now.ToString("yyyyMMdd")
        S_WORK_USR.Text = ClientSessionInfo.UserID
        Call S_WORK_USR.ValidateCode()
        S_DEPT_CD.DefVal = ClientSessionInfo.OrganizationCode
        S_DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode
        S_DATE_TYPE.DefVal = "R"
        S_DATE_TYPE.SelectedValue = "R"
        PROC_TYPE.DefVal = "0"
        PROC_TYPE.SelectedValue = "0"

    End Sub
    Private Sub PopupInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG1_AddRow", "행추가")
        PopUp.ItemAdd(Action.DeleteRow, "WG1_DelRow", "행삭제")
        PopUp.ItemAdd(Action.Excel, "WG1_ExcelExport", "엑셀다운로드", True)
        PopUp.ItemAdd(Action.Other, "WG1_CrmAsMgt", "고객지원등록 바로가기", True)
        PopUp.PopUpInit(Me, WG1, btnQuickFwg2, "REQ_YMD", "CMPT_HM")
    End Sub
    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = ""
        If Not Dr("Sender") Is System.DBNull.Value Then Sender = Dr("Sender")

        Dim Id As String = ""
        If Key = "Enter" Then Id = Dr("ID")

        Dim rowIndex As Integer = 0

        Select Case Dr("Action")
            Case Action.Other
                Select Case Key
                    Case "WG1_CrmAsMgt"
                        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                        Dim mngt_no As String = ""
                        If IsNothing(GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO")) = False Then
                            mngt_no = GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO").ToString
                        End If
                        Dim fTarget As Object = frmMain.NavigateTo("CrmAsMgt_v4", NavigatedWindowModes.MDIWindow, True)
                        If fTarget IsNot Nothing Then
                            fTarget.MNGT_NO.Text = mngt_no
                            fTarget.SearchData()
                        End If
                End Select

            Case Action.Addrow, Action.EventKey
                Select Case Sender
                    Case "WG1"
                        rowIndex = GV1.FocusedRowHandle
                        If rowIndex > 0 Then
                            If Mid(GV1.GetRowCellValue(GV1.FocusedRowHandle, "REQ_YMDHM").ToString.Trim, 1, 8) = Mid(GV1.GetRowCellValue(rowIndex - 1, "CMPT_YMDHM").ToString, 1, 8) Then
                                GV1.SetRowCellValue(rowIndex, "REQ_YMDHM", GV1.GetRowCellValue(rowIndex - 1, "CMPT_YMDHM").ToString)
                            Else
                                GV1.SetRowCellValue(rowIndex, "REQ_YMDHM", Now.ToString("yyyyMMddHHmm"))
                            End If

                            GV1.SetRowCellValue(rowIndex, "PROC_TYPE", GV1.GetRowCellValue(rowIndex - 1, "PROC_TYPE").ToString)
                            GV1.SetRowCellValue(rowIndex, "DEPT_CD", ClientSessionInfo.OrganizationCode.ToString)
                            GV1.SetRowCellValue(rowIndex, "CUST_CD", GV1.GetRowCellValue(rowIndex - 1, "CUST_CD").ToString)
                            GV1.SetRowCellValue(rowIndex, "CUST_NM", GV1.GetRowCellValue(rowIndex - 1, "CUST_NM").ToString)
                            GV1.SetRowCellValue(rowIndex, "PROJECT_CD", GV1.GetRowCellValue(rowIndex - 1, "PROJECT_CD").ToString)
                            GV1.SetRowCellValue(rowIndex, "PROJECT_NM", GV1.GetRowCellValue(rowIndex - 1, "PROJECT_NM").ToString)
                            If ClientSessionInfo.OrganizationCode = "09" Then
                                GV1.SetRowCellValue(rowIndex, "PROC_TYPE", GV1.GetRowCellValue(rowIndex - 1, "PROC_TYPE").ToString)
                            End If
                        Else
                            GV1.SetFocusedRowCellValue("REQ_YMDHM", Now.ToString("yyyyMMddHHmm"))
                            GV1.SetFocusedRowCellValue("PROC_TYPE", "0")
                            GV1.SetRowCellValue(rowIndex, "DEPT_CD", ClientSessionInfo.OrganizationCode.ToString)
                            If ClientSessionInfo.OrganizationCode = "09" Then
                                If Now.ToString("HHmm") > "1800" Then
                                    GV1.SetFocusedRowCellValue("PROC_TYPE", "1")
                                End If
                                GV1.SetFocusedRowCellValue("CUST_CD", "YJIT")
                                GV1.FocusedColumn = GV1.Columns("CUST_CD")
                                GV1.ShowEditor()
                                CType(GV1.ActiveEditor(), YJIT.SC.UI.SCControls.CodeBoxEdit).ValidateCode()
                            End If
                        End If
                        GV1.ShowEditor()
                End Select
            Case Action.Excel
                If Key = "WG1_ExportExcel" Then
                    GV1.OptionsView.ShowViewCaption = True
                End If
        End Select

    End Sub
    Private Sub ApplyProc()
        For i = 0 To GV1.RowCount - 1
            GV1.SetRowCellValue(i, "PROC_TYPE", PROC_TYPE.SelectedValue)
            GV1.SetRowCellValue(i, "CMPT_YMDHM", Now.ToString("yyyyMMddHHmm"))
            GV1.SetRowCellValue(i, "CMPT_YMD", Now.ToString("yyyyMMdd"))
            GV1.SetRowCellValue(i, "CMPT_HM", Now.ToString("HHmm"))
        Next
    End Sub
    Private Sub AddGridRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvAddRow As New DataTable
        Dim dr As DataRow

        If obj.Visible = False And obj.Enabled = False Then Exit Sub
        GvAddRow.Columns.Add("Key")
        GvAddRow.Columns.Add("Sender")
        GvAddRow.Columns.Add("Action", GetType(Action))
        GvAddRow.Rows.Add()
        dr = GvAddRow.Rows(0)
        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_AddRow"
        dr("Action") = Action.Addrow
        obj.AddRow()

        PopUpOnAfterClick(GvAddRow.Rows(0))

    End Sub
    Private Sub DelGridRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvDelRow As New DataTable
        Dim dr As DataRow

        If obj.Visible = False And obj.Enabled = False Then Exit Sub
        GvDelRow.Columns.Add("Key")
        GvDelRow.Columns.Add("Sender")
        GvDelRow.Columns.Add("Action", GetType(Action))
        GvDelRow.Rows.Add()
        dr = GvDelRow.Rows(0)
        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_DeleteRow"
        dr("Action") = Action.DeleteRow
        obj.DeleteRow()

        PopUpOnAfterClick(GvDelRow.Rows(0))

    End Sub
#End Region
End Class