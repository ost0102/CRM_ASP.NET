Imports System
Imports System.IO
Imports System.Drawing
Imports YJIT.SC.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports YJIT.SC.UI.SCControls

'Imports Microsoft.Office



Public Class ComExcelMgt
    Dim dtREQ_SVC2 As DataTable = Nothing
    Dim bShowDateBoxEdit As Boolean = True
    Dim isFormLoaded As Boolean = False

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToString.ToUpper
                    YJSql.SqlBox("WG1", "ComExcelMgt@Search")
                    YJSql.Params("TABLE_ID", drMAIN("S_TABLE_ID").ToString)
                Case "SearchExcelInfo".ToString.ToUpper
                    YJSql.SqlBox("MAIN", "ComExcelMgt@SearchExcelInfo")
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region

#Region "=================Client Function==========="
    'Client Function : 클라이언트 동작 함수
    Public Sub PopupInit()
        Dim Popup As New PopupBase
        Popup.ItemAdd(Action.EventKey, "GV2_SelectAll", "&Select All")
        Popup.ItemAdd(Action.EventKey, "GV2_SelectAll2", "동일자료 선택", True)
        Popup.ItemAdd(Action.Addrow, "WG2_AddRow", "행추가")
        Popup.ItemAdd(Action.DeleteRow, "WG2_DelRow", "행삭제")
        Popup.ItemAdd(Action.Excel, "WG2_ExcelExport", "엑셀다운로드", True)
        Popup.PopUpInit(Me, WG2, btnQuickFwg2, "REQ_YMDHM", "CMPT_YMDHM")
    End Sub

    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = ""
        If Not Dr("Sender") Is System.DBNull.Value Then Sender = Dr("Sender")

        Dim Id As String = ""
        If Key = "Enter" Then Id = Dr("ID")

        Dim rowIndex As Integer = 0

        Select Case Dr("Action")
            Case Action.Addrow, Action.EventKey
                Select Case Key
                    Case "GV2_SelectAll"
                        Call SelectAll()
                    Case "GV2_SelectAll2"
                        Call SelectAll2()
                    Case Else
                        Select Case Sender
                            Case "WG2"
                                rowIndex = GV2.FocusedRowHandle
                                If rowIndex > 0 Then
                                    GV2.SetRowCellValue(rowIndex, "REQ_YMD", GV2.GetRowCellValue(rowIndex - 1, "REQ_YMD").ToString)
                                    GV2.SetRowCellValue(rowIndex, "REQ_HM", GV2.GetRowCellValue(rowIndex - 1, "REQ_HM").ToString)
                                    GV2.SetRowCellValue(rowIndex, "PROC_TYPE", GV2.GetRowCellValue(rowIndex - 1, "PROC_TYPE").ToString)
                                    GV2.SetRowCellValue(rowIndex, "DEPT_CD", ClientSessionInfo.OrganizationCode.ToString)
                                    GV2.SetRowCellValue(rowIndex, "CUST_CD", GV2.GetRowCellValue(rowIndex - 1, "CUST_CD").ToString)
                                    GV2.SetRowCellValue(rowIndex, "CUST_NM", GV2.GetRowCellValue(rowIndex - 1, "CUST_NM").ToString)

                                    If ClientSessionInfo.OrganizationCode = "09" Then
                                        GV2.SetRowCellValue(rowIndex, "PROC_TYPE", GV2.GetRowCellValue(rowIndex - 1, "PROC_TYPE").ToString)
                                    End If
                                Else
                                    GV2.SetFocusedRowCellValue("REQ_YMD", Now.ToString("yyyyMMdd"))
                                    GV2.SetFocusedRowCellValue("REQ_HM", Now.ToString("HHmm"))
                                    GV2.SetFocusedRowCellValue("PROC_TYPE", "0")
                                    GV2.SetRowCellValue(rowIndex, "DEPT_CD", ClientSessionInfo.OrganizationCode.ToString)

                                    If ClientSessionInfo.OrganizationCode = "09" Then
                                        If Now.ToString("HHmm") > "1800" Then
                                            GV2.SetFocusedRowCellValue("PROC_TYPE", "1")
                                        End If
                                        GV2.SetFocusedRowCellValue("CUST_CD", "YJIT")
                                        GV2.FocusedColumn = GV2.Columns("CUST_CD")
                                        GV2.ShowEditor()
                                        CType(GV2.ActiveEditor(), YJIT.SC.UI.SCControls.CodeBoxEdit).ValidateCode()
                                    End If
                                End If
                                GV2.ShowEditor()
                        End Select
                End Select
            Case Action.Excel
                If Key = "WG2_ExportExcel" Then
                    GV2.OptionsView.ShowViewCaption = True
                End If
        End Select
    End Sub

    Private Sub SelectAll()
        Dim CurrentCursor As Cursor = Me.Cursor
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim checkAll As Boolean = False
            For i As Integer = 0 To GV2.RowCount - 1
                If GV2.GetRowCellValue(i, "CHK").ToString = "N" Then
                    checkAll = True
                    Exit For
                End If
            Next
            If checkAll = True Then
                'Select All
                'For i As Integer = 0 To GV2.RowCount - 1
                '    GV2.SetRowCellValue(i, "CHK", "Y")
                'Next
                For Each row As DataRow In CType(WG2.DataSource, DataTable).Rows
                    row("CHK") = "Y"
                Next
            Else
                'Deselect All
                'For i As Integer = 0 To GV2.RowCount - 1
                '    GV2.SetRowCellValue(i, "CHK", "N")
                'Next
                For Each row As DataRow In CType(WG2.DataSource, DataTable).Rows
                    row("CHK") = "N"
                Next
            End If

            Dim iFocusedRowHandle As Integer = GV2.FocusedRowHandle
            GV2.FocusedRowHandle = -1
            GV2.FocusedRowHandle = iFocusedRowHandle
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            Me.Cursor = CurrentCursor
        End Try
    End Sub
    Private Sub SelectAll2()
        Dim CurrentCursor As Cursor = Me.Cursor
        Try
            Me.Cursor = Cursors.WaitCursor

            'Dim checkAll As Boolean = False

            'For i As Integer = 0 To GV2.RowCount - 1
            '    If GV2.GetRowCellValue(i, "CHK").ToString = "N" AndAlso GV2.GetRowCellValue(i, GV2.FocusedColumn).ToString = GV2.GetRowCellValue(GV2.FocusedRowHandle, GV2.FocusedColumn).ToString Then
            '        checkAll = True
            '        Exit For
            '    End If
            'Next
            'If checkAll = True Then
            For i As Integer = 0 To GV2.RowCount - 1
                If GV2.GetRowCellValue(i, GV2.FocusedColumn).ToString = GV2.GetRowCellValue(GV2.FocusedRowHandle, GV2.FocusedColumn).ToString Then
                    GV2.SetRowCellValue(i, "CHK", "Y")
                Else
                    GV2.SetRowCellValue(i, "CHK", "N")
                End If
            Next
            'Else
            '    For i As Integer = 0 To GV2.RowCount - 1
            '        If GV2.GetRowCellValue(i, GV2.FocusedColumn).ToString = GV2.GetRowCellValue(GV2.FocusedRowHandle, GV2.FocusedColumn).ToString Then
            '            GV2.SetRowCellValue(i, "CHK", "N")
            '        End If
            '    Next
            'End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            Me.Cursor = CurrentCursor         
        End Try
    End Sub

    Private Sub InitGrid()
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim dt As DataTable = Nothing

        '업무구분3
        dt = New DataTable : dt.Columns.Add("CODE", GetType(String)) : dt.Columns.Add("NAME", GetType(String))
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            'Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T09' AND OPT_ITEM4 LIKE '%" & ClientSessionInfo.OrganizationCode & "%'", "SORT ASC")
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T09'", "SORT ASC")
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
        GV2.Columns("REQ_TYPE2").ColumnEdit = editorCombo
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
        AddHandler editorCombo.Closed, AddressOf REQ_TYPE2_Closed


        '상태
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T07")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV2.Columns("PROC_TYPE").ColumnEdit = editorCombo
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
        AddHandler editorCombo.Closed, AddressOf PROC_TYPE_Closed


        '업무구분1
        dt = New DataTable : dt.Columns.Add("CODE", GetType(String)) : dt.Columns.Add("NAME", GetType(String))
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            'Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T02' AND OPT_ITEM4 LIKE '%" & ClientSessionInfo.OrganizationCode & "%'", "SORT ASC")
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T02'", "SORT ASC")
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
        GV2.Columns("REQ_SVC").ColumnEdit = editorCombo
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
        AddHandler editorCombo.Closed, AddressOf REQ_SVC_Closed

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
            GV2.Columns("REQ_SVC2").ColumnEdit = editorCombo
            editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
            editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
            editorCombo.Columns("OPT_ITEM1").Visible = False
            AddHandler editorCombo.Closed, AddressOf REQ_SVC2_Closed
        End If

        '거래처
        editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        editor.CodeType = "YJIT.CodeService.Customer"
        editor.DisplayParams = "Code:#CUST_CD,Name:#CUST_NM,OUTSTAND_AMT:#OUTSTAND_AMT,STOP_YMD:#STOP_YMD,BANK_YN:#BANK_YN,CHECK_YN:#CHECK_YN,STOP_YN:#STOP_YN"
        editor.ValidateKeys = "KEY:#CUST_CD"
        editor.DataParams = "USE_YN:'Y',NameType:''"
        editor.KeepIntegrity = True
        editor.AutoSuggestion = False
        editor.CharacterCasing = CharacterCasing.Upper
        GV2.Columns("CUST_CD").ColumnEdit = editor

        '프로젝트
        editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        editor.CodeType = "YJIT.CodeService.CommonCode"
        editor.DisplayParams = "CODE:#PROJECT_CD,Name:#PROJECT_NM"
        editor.ValidateKeys = "KEY:#PROJECT_CD"
        editor.DataParams = "GroupCode:'T16',NameType:'',Valid:'V'"
        editor.KeepIntegrity = True
        editor.AutoSuggestion = False
        GV2.Columns("PROJECT_CD").ColumnEdit = editor
    End Sub

    Private Sub SetReqSvc()
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})

        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            'Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T02' AND OPT_ITEM4 LIKE '%" & ClientSessionInfo.OrganizationCode & "%'", "SORT ASC")
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T02'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        REQ_SVC.DataSource = dt

        'Select Case ClientSessionInfo.OrganizationCode
        '    Case "02"
        '        REQ_SVC.SelectedValue = "E"
        '    Case "05"
        '        REQ_SVC.SelectedValue = "C"
        '    Case "07"
        '        REQ_SVC.SelectedValue = "M"
        '    Case Else
        '        REQ_SVC.SelectedValue = "B"
        'End Select
    End Sub


    Private Sub SetReqSvc2(ByVal GrpCd As String)
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})

        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then

            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T10' AND OPT_ITEM1 = '" & GrpCd & "'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        REQ_SVC2.DataSource = dt
    End Sub

    Private Sub SetReqSvc3()
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        dt.Rows.Add({"", "--Select--"})

        If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
            '20190214 김성은 / 로그인사용자 기준으로 적용
            'Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T09' AND OPT_ITEM4 LIKE '%" & DEPT_CD.SelectedValue & "%'", "SORT ASC")
            'Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T09' AND OPT_ITEM4 LIKE '%" & ClientSessionInfo.OrganizationCode & "%'", "SORT ASC")
            Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select("GRP_CD='T09'", "SORT ASC")
            If drMdm.Count > 0 Then
                For Each drRow As DataRow In drMdm
                    Dim dr As DataRow = dt.NewRow
                    dr("CODE") = drRow("COMN_CD").ToString
                    dr("NAME") = drRow("CD_NM").ToString
                    dt.Rows.Add(dr)
                Next
            End If
        End If
        REQ_TYPE2.DataSource = dt
    End Sub

    Private Sub REQ_TYPE2_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs)
        GV2.FocusedColumn = GV2.Columns(GV2.FocusedColumn.VisibleIndex + 1)
        GV2.ShowEditor()
    End Sub
    Private Sub REQ_SVC_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs)
        GV2.FocusedColumn = GV2.Columns(GV2.FocusedColumn.VisibleIndex + 1)
        GV2.ShowEditor()
    End Sub
    Private Sub REQ_SVC2_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs)
        GV2.FocusedColumn = GV2.Columns(GV2.FocusedColumn.VisibleIndex + 1)
        GV2.ShowEditor()
    End Sub
    Private Sub PROC_TYPE_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs)
        GV2.FocusedColumn = GV2.Columns(GV2.FocusedColumn.VisibleIndex + 1)
        GV2.ShowEditor()
    End Sub


#End Region

#Region "=================Data logic actions==========="
    Public Sub SearchData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.ComExcelMgt", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            'If String.IsNullOrEmpty(GRP_CD.Text.ToString) Then
            '    'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = GRP_CD
            '    ErrMsg &= "Please input the [" & lbl_GRP_CD.Text & "]" & vbNewLine
            'End If

            'If String.IsNullOrEmpty(S_CUST_CD.Text.ToString) Then
            '    'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = S_CUST_CD
            '    ErrMsg &= "Please input the [" & lbl_S_CUST_CD.Text & "]" & vbNewLine
            'End If


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
    Public Sub SearchExcelInfoData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("SearchExcelInfo")

            dsRet = MethodCallEx(Me, "YJIT.Biz.ComExcelMgt", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.BindToDataset(dsRet, "Data")
                Case "N"

                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    '    Public Sub SearchGridData()
    '        Try
    '            If SearchGridValidate() = False Then Exit Sub

    '            Dim dsRet As DataSet = GetConvertToDataSet("Grid")

    '            dsRet = MethodCallEx(Me, "YJIT.Biz.ComExcelMgt", "Search", {dsRet})
    '            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

    '            Select Case drPairs("TrxCode")
    '                Case "Y"
    '                    Call ClearView(AppliedRangeTypes.Except, {WG1, WG2})
    '                    Me.BindToDataset(dsRet, "Data")
    '                    Me.DataState = UI.DataStates.Retrieved
    '                Case "N"
    '                    Call ClearView(AppliedRangeTypes.Except, {WG1, WG2})
    '                    MsgBoxLocalized(drPairs("TrxMsg"))
    '                    Me.DataState = UI.DataStates.Retrieved
    '                Case Else
    '                    MsgBoxLocalized(drPairs("TrxMsg"))
    '            End Select
    '        Catch ex As Exception
    '            MsgBoxLocalized(ex.Message)
    '        End Try
    '    End Sub
    '    Private Function SearchGridValidate() As Boolean
    '        Dim ErrMsg As String = String.Empty
    '        Dim ErrControl As Control = Nothing
    '        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

    '        Try
    '            If GV1.RowCount = 0 Then
    '                If ErrControl Is Nothing Then ErrControl = btnSearch
    '                ErrMsg &= "[Code] Data Not Found!" & vbNewLine
    '            End If

    '            'If String.IsNullOrEmpty(S_CUST_CD.Text.ToString) Then
    '            '    'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
    '            '    If ErrControl Is Nothing Then ErrControl = S_CUST_CD
    '            '    ErrMsg &= "Please input the [" & lbl_S_CUST_CD.Text & "]" & vbNewLine
    '            'End If


    '            If Not String.IsNullOrEmpty(ErrMsg) Then
    '                'If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
    '                If Not ErrControl Is Nothing Then ErrControl.Focus()
    '                Throw New Exception(ErrMsg)
    '            End If

    '            Return True
    '        Catch ex As Exception
    '            MsgBoxLocalized(ex.Message)
    '            Return False
    '        End Try
    '    End Function

    '    Public Sub SearchRmkListData()
    '        Try
    '            Dim dsRet As DataSet = GetConvertToDataSetRmkList()

    '            dsRet = MethodCallEx(Me, "YJIT.Biz.ComExcelMgt", "Search", {dsRet})
    '            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

    '            Select Case drPairs("TrxCode")
    '                Case "Y"
    '                    Me.BindToDataset(dsRet, "Data")
    '                    Me.DataState = UI.DataStates.Retrieved
    '                Case "N"
    '                    MsgBoxLocalized(drPairs("TrxMsg"))
    '                    Me.DataState = UI.DataStates.Retrieved
    '                Case Else
    '                    MsgBoxLocalized(drPairs("TrxMsg"))
    '            End Select
    '        Catch ex As Exception
    '            MsgBoxLocalized(ex.Message)
    '        End Try
    '    End Sub

    Private Sub NewData()
        Call ClearView()
        If S_TABLE_ID.Items.Count >= 1 Then S_TABLE_ID.SelectedIndex = 0
        SetReqSvc2(REQ_SVC.SelectedValue)

        Me.DataState = UI.DataStates.New
    End Sub



    Public Sub SaveData()
        If MandatoryGridValue("GV2") Then Exit Sub
        If SaveValidate() = False Then Exit Sub

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        '## 상태값 변경 ##
        Dim dt As DataTable = CType(WG2.DataSource, DataTable)
        dt.AcceptChanges()
        For Each row As DataRow In dt.Rows
            If String.IsNullOrEmpty(row("MNGT_NO").ToString.Trim) Then
                row.AcceptChanges()
                row.SetAdded()
            Else
                row.AcceptChanges()
                row.SetModified()
            End If
        Next

        Dim dsRet As DataSet = Me.ConvertToDataset

        dsRet = MethodCallEx(Me, "YJIT.Biz.ComExcelMgt", "Save", dsRet)
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(dsRet, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))
    End Sub
    Private Function SaveValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            Dim dsRet As DataSet = Me.ConvertToDataset
            If dsRet.Tables("WG2").Rows.Count = 0 Then
                ErrMsg &= "저장할 자료가 없습니다. 작업이 취소되었습니다." & vbNewLine
            End If
            'If String.IsNullOrEmpty(CONTENTS.Text.ToString) Then
            '    If ErrControl Is Nothing Then ErrControl = CONTENTS
            '    ErrMsg &= "Please input the [" & lbl_CONTENTS.Text & "]" & vbNewLine
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

    '    Public Sub DeleteData()
    '        If DeleteValidate() = False Then Exit Sub

    '        If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

    '        Dim dsRet As DataSet = GetConvertToDataSet("Search")
    '        dsRet.Tables.Add(Me.ConvertToDataset.Tables("MAIN").Copy)

    '        dsRet = MethodCallEx(Me, "YJIT.Biz.ComExcelMgt", "Delete", dsRet)

    '        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

    '        If dr("TrxCode") = "Y" Then
    '            Call ClearView(AppliedRangeTypes.Only, {WG1})
    '            Me.BindToDataset(dsRet, "Data")
    '            Me.DataState = UI.DataStates.Retrieved
    '        End If

    '        MsgBoxLocalized(dr("TrxMsg"))

    '    End Sub
    '    Private Function DeleteValidate() As Boolean
    '        Dim ErrMsg As String = String.Empty
    '        Dim ErrControl As Control = Nothing
    '        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

    '        Try
    '            If String.IsNullOrEmpty(COMN_CD.Text.ToString) Then
    '                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
    '                If ErrControl Is Nothing Then ErrControl = COMN_CD
    '                ErrMsg &= "Please input the [" & lbl_COMN_CD.Text & "]" & vbNewLine
    '            End If


    '            If Not String.IsNullOrEmpty(ErrMsg) Then
    '                'If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
    '                If Not ErrControl Is Nothing Then ErrControl.Focus()
    '                Throw New Exception(ErrMsg)
    '            End If

    '            Return True
    '        Catch ex As Exception
    '            MsgBoxLocalized(ex.Message)
    '            Return False
    '        End Try
    '    End Function

    Private Sub ApplyData()
        Dim iFocusedRowHandle As Integer = GV2.FocusedRowHandle
        GV2.FocusedRowHandle = -1
        GV2.FocusedRowHandle = iFocusedRowHandle

        Dim dr() As DataRow = CType(WG2.DataSource, DataTable).Select("CHK = 'Y'")
        If dr.Count = 0 Then
            If MsgBoxLocalized("선택된 자료가 없습니다. 전체자료에 적용 하시겠습니까?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then
                Exit Sub
            Else
                Call SelectAll()
            End If
        End If

        Dim dt As DataTable = CType(WG2.DataSource, DataTable)
        For Each row As DataRow In dt.Rows
            If row.RowState = DataRowState.Deleted Then Continue For
            If row("CHK").ToString = "N" Then Continue For
            If Not String.IsNullOrEmpty(CUST_CD.Text) Then row("CUST_CD") = CUST_CD.Text
            If Not String.IsNullOrEmpty(CUST_NM.Text) Then row("CUST_NM") = CUST_NM.Text
            If Not String.IsNullOrEmpty(REQ_YMD.Text) Then row("REQ_YMD") = REQ_YMD.Text
            If Not String.IsNullOrEmpty(REQ_HM.Text) Then row("REQ_HM") = REQ_HM.Text
            If Not String.IsNullOrEmpty(CMPT_YMD.Text) Then row("CMPT_YMD") = CMPT_YMD.Text
            If Not String.IsNullOrEmpty(CMPT_HM.Text) Then row("CMPT_HM") = CMPT_HM.Text
            If Not String.IsNullOrEmpty(REQ_SVC.SelectedValue) Then row("REQ_SVC") = REQ_SVC.SelectedValue
            If Not String.IsNullOrEmpty(REQ_SVC2.SelectedValue) Then row("REQ_SVC2") = REQ_SVC2.SelectedValue
            If Not String.IsNullOrEmpty(REQ_TYPE2.SelectedValue) Then row("REQ_TYPE2") = REQ_TYPE2.SelectedValue
            If Not String.IsNullOrEmpty(PROC_TYPE.SelectedValue) Then row("PROC_TYPE") = PROC_TYPE.SelectedValue
            If Not String.IsNullOrEmpty(PROJECT_CD.Text) Then row("PROJECT_CD") = PROJECT_CD.Text
            If Not String.IsNullOrEmpty(PROJECT_NM.Text) Then row("PROJECT_NM") = PROJECT_NM.Text
        Next
    End Sub

    Private Sub ClearData()
        ClearView(AppliedRangeTypes.Only, {CUST_CD, CUST_NM, REQ_YMD, REQ_HM, CMPT_YMD, CMPT_HM, REQ_SVC, REQ_SVC2, REQ_TYPE2, PROC_TYPE, PROJECT_CD, PROJECT_NM})
    End Sub

    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing
        Select Case gridView
            Case "GV2"
                checkNull = {"CONTENT"}
                Param("REQ_YMD") = GV2_REQ_YMD.Caption()
                Param("REQ_HM") = GV2_REQ_HM.Caption()
                'Param("REQ_TYPE2") = GV2_REQ_TYPE2.Caption()
                Param("CONTENT") = GV2_CONTENT.Caption()
                Param("CUST_CD") = GV2_CUST_CD.Caption()
                Return ValidateGridValue(GV2, Param, checkNull)
        End Select
        Return False
    End Function

    Private Function LinqToDataTable(Of T)(source As IEnumerable(Of T)) As DataTable
        Dim properties As Reflection.PropertyInfo() = GetType(T).GetProperties()

        Dim output As New DataTable()

        For Each prop In properties
            output.Columns.Add(prop.Name, prop.PropertyType)
        Next

        For Each item In source
            Dim row As DataRow = output.NewRow()

            For Each prop In properties
                row(prop.Name) = prop.GetValue(item, Nothing)
            Next

            output.Rows.Add(row)
        Next

        Return output
    End Function

    Public Sub ExcelUpLoad()
        Dim ds As DataSet
        Dim Dialog As OpenFileDialog = New OpenFileDialog()
        Dim intRow As Integer = 0
        Dim strPath As String = Environment.CurrentDirectory()
        Dim bErrMsg As String = String.Empty

        Dialog.Title = "Excel Import"
        'Dialog.InitialDirectory = "C:\"
        Dialog.FilterIndex = 2
        Dialog.RestoreDirectory = True
        Dialog.Multiselect = True
        Dialog.Filter = "Excel Spreadsheets (*.xls)|*.xls|Excel 2007 and later (*.xlsx)|*.xlsx"

        Call ClearView(AppliedRangeTypes.Only, {WG2})

        Try
            If Dialog.ShowDialog() <> DialogResult.OK Then Exit Sub
            ds = ExcelConnection.ImportExcel2(Dialog.FileName, False)

            Dim dt As DataTable = New DataTable
            Dim bolTF As Boolean = False

            dt = ds.Tables(0)

            '## 컬럼명 재정의 ##
            Dim i As Integer = 0
            Dim j As Integer = -1
            For Each col As DataColumn In dt.Columns
                If j = -1 Then
                    col.Caption = "COL_" & Chr(65 + i)
                    col.ColumnName = "COL_" & Chr(65 + i)
                Else
                    col.Caption = "COL_" & Chr(65 + j) & Chr(65 + i)
                    col.ColumnName = "COL_" & Chr(65 + j) & Chr(65 + i)
                End If

                If Chr(65 + i) = "Z" Then
                    j += 1
                    i = 0
                Else
                    i += 1
                End If
            Next

            '## 시작행 적용 ## 6입력시 5행까지만 삭제
            If IsNumeric(START_ROW.Text) = True Then
                For i = 0 To CInt(START_ROW.Text) - 1 - 1
                    dt.Rows.RemoveAt(0)
                Next
            Else
                dt.Rows.RemoveAt(0)
            End If

            '## 컬럼 삭제 ##
            Dim dtWG1 As DataTable = CType(WG1.DataSource, DataTable)
            For i = dt.Columns.Count - 1 To 0 Step -1
                Dim arrRows() As DataRow = dtWG1.Select("FM_CD = '" & dt.Columns(i).ColumnName & "'", "")
                If arrRows.Count = 0 Then
                    dt.Columns.RemoveAt(i)
                End If
            Next

            '## 컬럼 생성 ##
            For Each row As DataRow In dtWG1.Rows
                If Not dt.Columns.Contains(row("FM_CD").ToString) Then
                    dt.Columns.Add(row("FM_CD").ToString, GetType(String))
                End If
            Next

            '## 자료 조작 ##
            For Each row As DataRow In dtWG1.Rows
                Select Case row("FIELD_TYPE").ToString
                    Case "TIME"
                        For Each col As DataRow In dt.Rows
                            Dim colDate As String = col(row("FM_CD").ToString).ToString
                            If IsDate(colDate) Then
                                col(row("FM_CD").ToString) = Format(CDate(colDate), "HHmm")
                            Else
                                col(row("FM_CD").ToString) = Nothing
                            End If
                        Next
                    Case "DATE"
                        For Each col As DataRow In dt.Rows
                            Dim colDate As String = col(row("FM_CD").ToString).ToString
                            If colDate.Contains("(") Then colDate = colDate.Substring(0, colDate.IndexOf("("))

                            If IsDate(colDate) Then
                                col(row("FM_CD").ToString) = Format(CDate(colDate), "yyyyMMdd")
                            Else
                                col(row("FM_CD").ToString) = Nothing
                            End If
                        Next
                    Case Else
                        For Each col As DataRow In dt.Rows
                            If String.IsNullOrEmpty(col(row("FM_CD").ToString).ToString.Trim) Then
                                col(row("FM_CD").ToString) = Nothing
                            End If
                        Next
                End Select
            Next

            '## 컬럼 맵핑 ##
            For Each row As DataRow In dtWG1.Rows
                If dt.Columns.Contains(row("FM_CD").ToString) = True Then
                    dt.Columns(row("FM_CD").ToString).ColumnName = row("TO_CD").ToString
                End If
            Next

            '## 컬럼 추가 ##
            Dim dtWG2 As DataTable = CType(WG2.DataSource, DataTable)
            For Each row As DataColumn In dtWG2.Columns
                If dt.Columns.Contains(row.ColumnName) = False Then
                    dt.Columns.Add(row.ColumnName, GetType(String))
                End If
            Next

            '## 체크용 컬럼 추가 ##
            For i = dt.Columns.Count - 1 To 0 Step -1
                If dt.Columns.Contains("DB_" & dt.Columns(i).ColumnName) Then Continue For
                dt.Columns.Add("DB_" & dt.Columns(i).ColumnName, dt.Columns(i).DataType)
            Next

            '## 기본값 적용 ##
            For Each col As DataRow In dt.Rows
                If dt.Columns.Contains("CHK") = True Then
                    If String.IsNullOrEmpty(col("CHK").ToString.Trim) Then
                        col("CHK") = "Y"
                    End If
                End If
                If dt.Columns.Contains("REQ_YMD") = True Then
                    If String.IsNullOrEmpty(col("REQ_YMD").ToString.Trim) Then
                        col("REQ_YMD") = Now.ToString("yyyyMMdd")
                    End If
                End If
                If dt.Columns.Contains("REQ_HM") = True Then
                    If String.IsNullOrEmpty(col("REQ_HM").ToString.Trim) Then
                        col("REQ_HM") = Now.ToString("HHmm")
                    End If
                End If
                If dt.Columns.Contains("PROC_TYPE") = True Then
                    If String.IsNullOrEmpty(col("PROC_TYPE").ToString.Trim) Then
                        col("PROC_TYPE") = "0"
                    End If
                End If
                '## 체크용 컬럼 자료복사 ##
                For Each colDb As DataColumn In dt.Columns
                    If colDb.ColumnName.StartsWith("DB_") Then
                        col(colDb.ColumnName) = col(colDb.ColumnName.Replace("DB_", "")).ToString.Trim
                    End If
                Next
            Next


            '## 자료 1차 맵핑 / 테이블기준 ##
            If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                        AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_MAPPING_MST") Then

                Dim drMdm() As DataRow = Nothing
                Dim sWhere As String = String.Empty
                For Each col As DataColumn In dt.Columns
                    sWhere = "OFFICE_CD ='" & ClientSessionInfo.OfficeCode & "' AND TABLE_ID = '" & MAPPING_TABLE.Text & "' AND FM_TYPE = '" & MAPPING_TYPE.Text & "' AND FIELD_ID = '" & col.ColumnName & "'"
                    drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_MAPPING_MST").Select(sWhere, "FM_CD ASC")
                    If drMdm.Count > 0 Then
                        Select Case drMdm(0)("FIELD_TYPE").ToString
                            Case "COMBO"
                                For Each row As DataRow In dt.Rows
                                    If col.ColumnName = "REQ_SVC2" Then
                                        If String.IsNullOrEmpty(row("REQ_SVC").ToString.Trim) Then
                                            row(col.ColumnName) = Nothing
                                        Else
                                            sWhere = "OFFICE_CD ='" & ClientSessionInfo.OfficeCode & "' AND TABLE_ID = '" & MAPPING_TABLE.Text & "' AND FM_TYPE = '" & MAPPING_TYPE.Text & "' AND FIELD_ID = '" & col.ColumnName & "' " _
                                                       & "AND FM_CD = '" & row(col.ColumnName).ToString.Trim & "' AND UPPER_FM_CD = '" & row("REQ_SVC").ToString.Trim & "'"
                                            drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_MAPPING_MST").Select(sWhere, "FM_CD ASC")

                                            If drMdm.Count > 0 Then
                                                row(col.ColumnName) = drMdm(0)("TO_CD").ToString.Trim
                                                '2차 적용으로 주석처리
                                                'Else
                                                '    row(col.ColumnName) = Nothing
                                            End If
                                        End If
                                    ElseIf col.ColumnName = "REQ_TYPE2" Then
                                        sWhere = "OFFICE_CD ='" & ClientSessionInfo.OfficeCode & "' AND TABLE_ID = '" & MAPPING_TABLE.Text & "' AND FM_TYPE = '" & MAPPING_TYPE.Text & "' AND FIELD_ID = '" & col.ColumnName & "' " _
                                                       & " AND FM_CD = '" & row(col.ColumnName).ToString.Trim & "'"
                                        drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_MAPPING_MST").Select(sWhere, "FM_CD ASC")

                                        If drMdm.Count > 0 Then
                                            row(col.ColumnName) = drMdm(0)("TO_CD").ToString.Trim
                                            'Else
                                            '    row(col.ColumnName) = Nothing
                                        End If
                                    Else
                                        sWhere = "OFFICE_CD ='" & ClientSessionInfo.OfficeCode & "' AND TABLE_ID = '" & MAPPING_TABLE.Text & "' AND FM_TYPE = '" & MAPPING_TYPE.Text & "' AND FIELD_ID = '" & col.ColumnName & "' " _
                                                       & " AND FM_CD = '" & row(col.ColumnName).ToString.Trim & "'"
                                        drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_MAPPING_MST").Select(sWhere, "FM_CD ASC")

                                        If drMdm.Count > 0 Then
                                            row(col.ColumnName) = drMdm(0)("TO_CD").ToString.Trim
                                            'Else
                                            '    row(col.ColumnName) = Nothing
                                        End If
                                    End If
                                Next
                            Case Else
                                For Each row As DataRow In dt.Rows
                                    sWhere = "OFFICE_CD ='" & ClientSessionInfo.OfficeCode & "' AND TABLE_ID = '" & MAPPING_TABLE.Text & "' AND FM_TYPE = '" & MAPPING_TYPE.Text & "' AND FIELD_ID = '" & col.ColumnName & "' " _
                                                       & " AND FM_CD = '" & row(drMdm("FIELD_ID").ToString).ToString.Trim & "'"
                                    drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_MAPPING_MST").Select(sWhere, "FM_CD ASC")
                                    If drMdm.Count > 0 Then
                                        row(drMdm("FIELD_ID").ToString) = drMdm("TO_CD").ToString.Trim
                                    End If
                                Next
                        End Select
                    End If
                Next

                '빈값으로 적용되는 오류 수정해야함
                ''## 자료 2차 맵핑 / 콤보박스 기준 ##
                'For Each row As DataRow In dt.Rows
                '    Dim drCmb() As DataRow = CType(REQ_SVC.DataSource, DataTable).Select("TRIM(NAME) = '" & row("REQ_SVC").ToString.Trim & "'")
                '    If drCmb.Count > 0 Then
                '        row("REQ_SVC") = drCmb(0)("CODE").ToString.Trim
                '    Else
                '        row("REQ_SVC") = Nothing
                '        If bErrMsg.IndexOf("[업무구분1]") = -1 Then
                '            If Not String.IsNullOrEmpty(bErrMsg) Then bErrMsg &= ","
                '            bErrMsg &= "[업무구분1]"
                '        End If
                '    End If
                '    Dim dtCmb As DataTable = dtREQ_SVC2
                '    drCmb = dtCmb.Select("TRIM(OPT_ITEM1) = '" & row("REQ_SVC").ToString.Trim & "' AND TRIM(NAME) = '" & row("REQ_SVC2").ToString.Trim & "'")
                '    If drCmb.Count > 0 Then
                '        row("REQ_SVC2") = drCmb(0)("CODE").ToString.Trim
                '    Else
                '        row("REQ_SVC2") = Nothing
                '        If bErrMsg.IndexOf("[업무구분2]") = -1 Then
                '            If Not String.IsNullOrEmpty(bErrMsg) Then bErrMsg &= ","
                '            bErrMsg &= "[업무구분2]"
                '        End If
                '    End If

                '    drCmb = CType(REQ_TYPE2.DataSource, DataTable).Select("TRIM(NAME) = '" & row("REQ_TYPE2").ToString.Trim & "'")
                '    If drCmb.Count > 0 Then
                '        row("REQ_TYPE2") = drCmb(0)("CODE").ToString.Trim
                '    Else
                '        row("REQ_TYPE2") = Nothing
                '        If bErrMsg.IndexOf("[업무구분3]") = -1 Then
                '            If Not String.IsNullOrEmpty(bErrMsg) Then bErrMsg &= ","
                '            bErrMsg &= "[업무구분3]"
                '        End If
                '    End If
                'Next

                'PROJECT_CD, CUST_CD
                Dim dtCode As DataTable = Nothing
                Dim q1 = From p In dt.AsEnumerable _
                        Where p("PROJECT_CD").ToString <> ""
                        Group By ProjectCode = p("PROJECT_CD").ToString _
                         Into Count = Count(1) _
                       Select ProjectCode, Count
                Dim dtQ1 As DataTable = LinqToDataTable(q1)
                For Each row As DataRow In dtQ1.Rows
                    dtCode = Func.GetCodeValidate("CommonCode", "GroupCode:T16,NameType:,Valid:V", "KEY:" & row("ProjectCode").ToString)
                    If IsNothing(dtCode) Then
                        For Each col As DataRow In dt.Rows
                            If col("PROJECT_CD").ToString = row("ProjectCode").ToString Then
                                col("PROJECT_CD") = ""
                            End If
                        Next

                        If bErrMsg.IndexOf("[프로젝트]") = -1 Then
                            If Not String.IsNullOrEmpty(bErrMsg) Then bErrMsg &= ","
                            bErrMsg &= "[프로젝트]"
                        End If
                    Else
                        For Each col As DataRow In dt.Rows
                            If col("PROJECT_CD").ToString = row("ProjectCode").ToString Then
                                col("PROJECT_NM") = dtCode(0)("NAME").ToString
                            End If
                        Next
                    End If
                Next

                Dim q2 = From p In dt.AsEnumerable _
                        Where p("PROJECT_CD").ToString <> ""
                        Group By CustomerCode = p("PROJECT_CD").ToString _
                         Into Count = Count(1) _
                       Select CustomerCode, Count

                Dim dtQ2 As DataTable = Func.LinqToDataTable(q2)
                For Each row As DataRow In dtQ2.Rows
                    dtCode = Func.GetCodeValidate("Customer", "USE_YN:Y,NameType:", "KEY:" & row("CustomerCode").ToString)
                    If IsNothing(dtCode) Then
                        For Each col As DataRow In dt.Rows
                            If col("CUST_CD").ToString = row("CustomerCode").ToString Then
                                col("CUST_CD") = ""
                            End If
                        Next

                        If bErrMsg.IndexOf("[거래처 코드]") = -1 Then
                            If Not String.IsNullOrEmpty(bErrMsg) Then bErrMsg &= ","
                            bErrMsg &= "[거래처 코드]"
                        End If
                    Else
                        For Each col As DataRow In dt.Rows
                            If col("CUST_CD").ToString = row("CustomerCode").ToString Then
                                col("CUST_NM") = dtCode(0)("CUST_LOCNM").ToString
                            End If
                        Next
                    End If
                Next
            End If

            '## 상태값 변경 ##
            For Each row As DataRow In CType(WG2.DataSource, DataTable).Rows
                row.AcceptChanges()
                row.SetAdded()
            Next

            dt.TableName = "Data.WG1"
            WG2.DataSource = dt

            If Not String.IsNullOrEmpty(bErrMsg) Then
                MsgBoxLocalized(String.Format("{0} 항목에 잘못된 자료가 포함되었습니다.{1}자료입력후 저장하겠습니다.", bErrMsg, vbCrLf))
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

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
        If GV2.FocusedRowHandle < 0 Then Exit Sub
        If Not String.IsNullOrEmpty(GV2.GetFocusedRowCellValue("MNGT_NO").ToString) Then
            MsgBoxLocalized("저장된 자료는 삭제가 불가합니다.")
            Exit Sub
        End If

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

#Region "=================Control Events==========="
    'Control Event : Form Control 관련 프로시져
    Private Sub ComExcelMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetMandatoryLine(Me)

            Call InitGrid()
            Call DrawRowIndicator({GV1, GV2})

            Call NewData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            isFormLoaded = True
        End Try
    End Sub

    Private Sub ComExcelMgt_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        PopupInit()

        Call SearchExcelInfoData()
        Call SearchData()

        Call SetReqSvc()
        Call SetReqSvc2(REQ_SVC.SelectedValue)
        Call SetReqSvc3()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    '    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    '        Call DeleteData()
    '    End Sub


    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        Call ApplyData()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub

    Private Sub S_DOC_TYPE_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles S_TABLE_ID.SelectedValueChanged
        If isFormLoaded = False Then Exit Sub
        Call SearchExcelInfoData()
        Call SearchData()
    End Sub

    Private Sub btnExcelUpload_Click(sender As System.Object, e As System.EventArgs) Handles btnExcelUpload.Click
        If String.IsNullOrEmpty(START_ROW.Text) Then Call SearchExcelInfoData()
        Call SearchData()
        Call ExcelUpLoad()
    End Sub

    Private Sub btnAddWg2_Click(sender As System.Object, e As System.EventArgs) Handles btnAddWg2.Click
        Call AddGridRow(WG2)
    End Sub

    Private Sub btnDelWg2_Click(sender As System.Object, e As System.EventArgs) Handles btnDelWg2.Click
        Call DelGridRow(WG2)
    End Sub

    Private Sub btnExpWg2_Click(sender As System.Object, e As System.EventArgs) Handles btnExpWg2.Click
        Common.ExportToExcel(WG2)
    End Sub

    Private Sub DEPT_CD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles REQ_TYPE2.KeyDown, REQ_SVC2.KeyDown, REQ_SVC.KeyDown, PROC_TYPE.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.DroppedDown = True
        End If
    End Sub

    Private Sub REQ_SVC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REQ_SVC.SelectedIndexChanged
        If isFormLoaded = False Then Exit Sub

        Call SetReqSvc2(REQ_SVC.SelectedValue)
        Call SetReqSvc3()

        Select Case REQ_SVC.SelectedValue
            Case "A"
                REQ_TYPE2.SelectedValue = "99"
            Case "Q"
                REQ_TYPE2.SelectedValue = "99"
        End Select
    End Sub

    Private Sub GV2_Click(sender As Object, e As System.EventArgs) Handles GV2.Click
        If GV2.RowCount = 0 Then Exit Sub

        If GV2.FocusedColumn.FieldName = "CHK" Then
            Dim dr As DataRow = GV2.GetDataRow(GV2.FocusedRowHandle)
            If dr("CHK").ToString = "Y" Then
                dr("CHK") = "N"
            Else
                dr("CHK") = "Y"
            End If
        End If
    End Sub

    Private Sub GV2_CustomColumnDisplayText(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV2.CustomColumnDisplayText
        Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = TryCast(sender, DevExpress.XtraGrid.Views.Base.ColumnView)
        If e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            If e.Column.FieldName = "CUST_CD" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CUST_NM").ToString) Then
                    e.DisplayText = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CUST_NM").ToString
                End If
            ElseIf e.Column.FieldName = "PROJECT_CD" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "PROJECT_NM").ToString) Then
                    e.DisplayText = view.GetListSourceRowCellValue(e.ListSourceRowIndex, "PROJECT_NM").ToString
                End If
            End If
        End If
    End Sub
    Private Sub GV2_ShowingEditor(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles GV2.ShowingEditor
        If GV2.FocusedColumn.FieldName = "CHK" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub GV2_ShownEditor(sender As System.Object, e As System.EventArgs) Handles GV2.ShownEditor
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
            Case "DateBoxEdit"
                If bShowDateBoxEdit = False Then Exit Sub
                Dim edit As DateBoxEdit = CType(view.ActiveEditor, DateBoxEdit)
                edit.ShowDatePicker()
                bShowDateBoxEdit = False
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
    Private Sub GV2_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV2.CellValueChanged
        Select Case e.Column.FieldName
            Case "PROC_TYPE"
                If GV2.GetRowCellValue(GV2.FocusedRowHandle, "PROC_TYPE").ToString = "1" Then
                    GV2.SetRowCellValue(GV2.FocusedRowHandle, "CMPT_YMDHM", Now.ToString("yyyyMMddHHmm"))
                End If
        End Select
    End Sub

    Private Sub GV2_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV2.RowCellStyle
        If e.Column.OptionsColumn.ReadOnly = True Or e.Column.FieldName = "CHK" Then Exit Sub
        If e.Column.FieldName.StartsWith("DB_") Then Exit Sub

        Dim row As DataRow = GV2.GetDataRow(e.RowHandle)

        If Not row.Table.Columns.Contains("DB_" & e.Column.FieldName) Then Exit Sub

        If String.IsNullOrEmpty(row(e.Column.FieldName).ToString) AndAlso Not String.IsNullOrEmpty(row("DB_" & e.Column.FieldName).ToString) Then
            e.Appearance.BackColor = System.Drawing.Color.LightSalmon
        End If
    End Sub


    '    Private Sub MSG_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSG_TYPE.SelectedIndexChanged
    '        Dim searchParams As Dictionary(Of String, Object)
    '        Dim dataParams As Dictionary(Of String, Object)
    '        searchParams = New Dictionary(Of String, Object)
    '        dataParams = New Dictionary(Of String, Object)
    '        dataParams.Add("GroupCode", "C08")
    '        dataParams.Add("OPT_ITEM1", MSG_TYPE.SelectedValue)
    '        dataParams.Add("NameType", "")
    '        MSG_TYPE2.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
    '    End Sub

    '    Private Sub GV1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GV1.Click
    '        Try
    '            If GV1.RowCount = 0 Then Exit Sub
    '            If bGV1_FocusedRowChanged = True Then Exit Sub

    '            Call SearchGridData()
    '        Catch ex As Exception
    '            MsgBoxLocalized(ex.Message)
    '        Finally
    '            bGV1_FocusedRowChanged = False
    '        End Try
    '    End Sub

    '    Dim bGV1_FocusedRowChanged As Boolean = False
    '    Private Sub GV1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
    '        Try
    '            If GV1.RowCount = 0 Then Exit Sub
    '            If GV1.IsValidRowHandle(e.FocusedRowHandle) = False Then Exit Sub

    '            If e.PrevFocusedRowHandle >= 0 Then bGV1_FocusedRowChanged = True

    '            Call SearchGridData()
    '        Catch ex As Exception
    '            MsgBoxLocalized(ex.Message)
    '        End Try
    '    End Sub

    '    Private Sub GV2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV2.DoubleClick
    '        'If Not String.IsNullOrEmpty(CONTENTS.Text) Then CONTENTS.Text &= vbCrLf
    '        CONTENTS.Text &= GV2.GetFocusedRowCellValue("CAPTION").ToString & GV2.GetFocusedRowCellValue("TAG").ToString
    '    End Sub
#End Region

End Class
