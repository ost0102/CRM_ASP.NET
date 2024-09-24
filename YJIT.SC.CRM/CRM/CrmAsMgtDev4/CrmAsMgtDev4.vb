Imports YJIT.SC.UI
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils


Public Class CrmAsMgtDev4
    'Dim CustomTypeCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    'Dim GV_Flag As Boolean = False
    'Private tempRoot As String = Application.StartupPath & "\TMP_OUTPUT"
    'Protected filePath As String = String.Empty
    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    Dim second As Integer = 0
    Dim MaxInterval As Integer = 0
    Dim Gv1PopUp As New PopupBase
    Dim Gv3PopUp As New PopupBase
    Dim MainPopUp As New PopupBase
    Dim Gv1ChangeFlag As Boolean = False
    Dim ShownFlag As Boolean = True
    Private comdoc As ComDoc
    Dim UserInfoDt As DataTable = Nothing
    Dim ContolList As Dictionary(Of String, Object)
    Dim REQ_SVC2_dt As DataTable

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "SearchRefresh".ToUpper
                    YJSql.SqlBox("WG3", "CrmAsMgtDev4@Search", False, False)
                    YJSql.Params("DEPT_CD", ClientSessionInfo.OrganizationCode)
                    YJSql.Params("FM_YMD", DateAdd(DateInterval.Day, -15, Now).ToString("yyyyMMdd"))
                    YJSql.Params("TO_YMD", Now.ToString("yyyyMMdd"))
                    If drMAIN("INCLUDE_EXCEPT").ToString = "N" Then
                        YJSql.Blocks("EXCEPT_LIST", "TRUE")
                    End If
                    YJSql.Blocks("NON_ASSIGN", "TRUE")
                Case "SearchList".ToUpper
                    YJSql.SqlBox("WG1", "CrmAsMgtDev4@Search", True, False)
                    YJSql.Params("DEPT_CD", ClientSessionInfo.OrganizationCode)
                    YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    YJSql.Params("PROC_TYPE", S_PROC_TYPE.EditValue.ToString.Replace(";", "','").Replace(" ", ""))
                    YJSql.Params("WORK_USR", drMAIN("S_WORK_USR").ToString)
                    YJSql.Params("SEARCH_KEY", drMAIN("S_SEARCH_KEY").ToString)
                    YJSql.Params("WORK_AREA", drMAIN("S_WORK_AREA").ToString)
                    YJSql.Blocks("ASSIGN", "TRUE")
                Case "Search".ToUpper
                    YJSql.SqlBox("MAIN", "CrmAsMgtDev4@Search", True, False)
                    YJSql.Params("DEPT_CD", ClientSessionInfo.OrganizationCode)
                    YJSql.Params("MNGT_NO", drMAIN("MNGT_NO").ToString)
                Case "CrmUserInfo".ToUpper
                    YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
                Case "REQ_SVC2".ToUpper
                    YJSql.SqlBox("REQ_SVC2", "CrmAsMgt_v3@GetReqSvc2List", True)
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region


    Public Sub SearchRefreshData()
        Dim nCnt As Integer = GV3.RowCount
        
        Dim ds As DataSet = GetConvertToDataSet("SearchRefresh")
        ds = MethodCallEx(Me, "YJIT.Biz.CrmAsMgtDev4", "Search", ds)
        Dim drPairs As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode").ToString <> "Y" Then
            MsgBoxLocalized(drPairs("TrxMsg"))
            Call ClearView(AppliedRangeTypes.Only, {WG3})
            Me.DataState = UI.DataStates.Retrieved
            Exit Sub
        End If
        Me.BindToDataset(ds, "Data")
        Me.DataState = UI.DataStates.Retrieved

        Select Case ClientSessionInfo.UserID
            Case "HCS", "NNOW"
                If nCnt < GV3.RowCount Then
                    Call NotiPopup()
                End If
        End Select
    End Sub

    Public Sub SearchListData()
        If SearchListValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SearchList")
        ds = MethodCallEx(Me, "YJIT.Biz.CrmAsMgtDev4", "Search", ds)
        Dim drPairs As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Except, {S_SEARCH_KEY, S_FM_YMD, S_TO_YMD, REF_TIME, S_WORK_USR, SCREEN, WG3, S_WORK_AREA})
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Except, {S_SEARCH_KEY, S_FM_YMD, S_TO_YMD, REF_TIME, S_WORK_USR, SCREEN, WG3, S_WORK_AREA})
                MsgBoxLocalized(drPairs("TrxMsg"))
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

        CMPT_RMK.ReadOnly = True
    End Sub
    Private Function SearchListValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(S_FM_YMD.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = S_FM_YMD
                ErrMsg &= "등록일자 시작일은 필수 입니다." & vbNewLine
            End If

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

    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("Search")
        ds = MethodCallEx(Me, "YJIT.Biz.CrmAsMgtDev4", "Search", ds)
        Dim drPairs As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Except, {S_SEARCH_KEY, S_FM_YMD, S_TO_YMD, REF_TIME, S_WORK_USR, SCREEN, WG3, S_WORK_AREA})
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Except, {S_SEARCH_KEY, S_FM_YMD, S_TO_YMD, REF_TIME, S_WORK_USR, SCREEN, WG3, S_WORK_AREA})
                MsgBoxLocalized(drPairs("TrxMsg"))
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

        CMPT_RMK.ReadOnly = True
    End Sub

    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(MNGT_NO.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = S_FM_YMD
                ErrMsg &= "관리번호는 필수 입니다." & vbNewLine
            End If

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










#Region "=================Data logic actions==========="
    Private Sub NotiPopup()
        'CrmNotification.exe
        Try
            Dim proc = System.Diagnostics.Process.GetProcessesByName("CrmNotification")
            For i As Integer = 0 To proc.Count - 1
                proc(i).Kill()
            Next i
        Catch ex As Exception
        End Try

        'Start Teamviewer quicksuport instance
        Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
        process.StartInfo.FileName = "C:\CrmNotification.exe"
        process.StartInfo.Verb = "Open"
        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        process.Start()

    End Sub
    Public Sub ExceptList(ByVal MngtNo As String)

        If MngtNo = "" Then Exit Sub


        Dim dsResult As DataSet
        Dim params As Object = {MngtNo}
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev4", "ExceptList", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Call SearchRefreshData()
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Public Sub ExceptCancel(ByVal MngtNo As String)

        If MngtNo = "" Then Exit Sub


        Dim dsResult As DataSet
        Dim params As Object = {MngtNo}
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev4", "ExceptCancel", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Call SearchRefreshData()
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Public Sub AssignData()
        Dim tMNGT_NO As String = ""

        If MNGT_NO.Text = "" Then Exit Sub

        If RANK.Text = "" OrElse PRAR_YMD.Text = "" Then
            MsgBoxLocalized("난이도와 예정일자는 필수 항목 입니다!", MessageBoxButtons.OK, "error", MessageBoxIcon.Error)
            Exit Sub
        End If

        If REQ_YMD.Text = "" Then REQ_YMD.Text = Now.ToString("yyyyMMdd")
        If REQ_HM.Text = "" Then REQ_HM.Text = Now.ToString("HHmm")

        tMNGT_NO = MNGT_NO.Text
        Dim dsResult As DataSet
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev4", "AssignData2", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(dsResult, "Data")
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        Call SearchRefreshData()
        Call SearchData()
        Call SearchDetail(tMNGT_NO, ClientSessionInfo.UserID)

    End Sub



    Private Sub SetReqsvc2(ByVal Grp_Cd As String, ByVal SelIndex As Integer)
        Dim DRS() As DataRow = REQ_SVC2_dt.Select("GRP_CD = '" & Grp_Cd & "'", "SORT ASC")
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        If DRS.Length > 0 Then
            dt = DRS.CopyToDataTable
            Dim dr As DataRow = dt.NewRow
            dr("CODE") = ""
            dr("NAME") = "--Select--"
            dt.Rows.InsertAt(dr, 0)
        Else
            dt.Rows.Add({"", "--Select--"})
        End If
        REQ_SVC2.DataSource = dt
        REQ_SVC2.SelectedIndex = SelIndex
    End Sub

    Private Sub GetControlList(ByVal controls As Control.ControlCollection)
        For Each Control In controls
            Dim cntr As Control = CType(Control, Control)
            If Not ContolList.ContainsValue(cntr) Then
                ContolList(cntr.Name) = cntr
            End If
            Try
                GetControlList(cntr.Controls)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Function GetControlList()
        Try
            If ContolList Is Nothing Then
                ContolList = New Dictionary(Of String, Object)
            End If
            Dim controlList As Control.ControlCollection = CType(Me.Controls, Control.ControlCollection)
            GetControlList(controlList)
        Catch ex As Exception
            ContolList = Nothing
        End Try
        Return ContolList
    End Function

    '
    'Private Sub Save
    Private Sub SetUserList(ByVal sender As Object, ByVal Dept_Cd As String)
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        Try
            Dim Drs() As DataRow
            If Dept_Cd = "ALL" Then
                Drs = UserInfoDt.Select("1=1", "DEPT_CD ASC,LOC_NM ASC")
            Else
                Drs = UserInfoDt.Select("DEPT_CD ='" & Dept_Cd & "'", "LOC_NM ASC")
            End If
            If Drs.Length > 0 Then
                dt = Drs.CopyToDataTable
                dt.Columns("USR_ID").ColumnName = "CODE"
                dt.Columns("LOC_NM").ColumnName = "NAME"
            End If
            Dim dr As DataRow = dt.NewRow
            dr("CODE") = ""
            dr("NAME") = ""
            dt.Rows.InsertAt(dr, 0)

            sender.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NewDetail()
    End Sub



    Public Function YJQuerySearch(ByVal key As String) As DataSet

        Dim ParamDsRet As DataSet = GetConvertToDataSet(key)
        Dim dsRet As DataSet = Nothing
        Try
            dsRet = MethodCallEx(Me, "YJIT.Biz.YJQuery", "Search", {ParamDsRet})
        Catch ex As Exception

        End Try
        Return dsRet
    End Function

    Private Sub InitData()

        Dim dtCol As DataTable = New DataTable
        dtCol.Columns.Add(New DataColumn("CODE"))
        dtCol.Columns.Add(New DataColumn("NAME"))


        Dim searchParams = New Dictionary(Of String, Object)
        Dim dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T07")
        dataParams.Add("NameType", "")
        dtCol = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)

        Dim bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = dtCol
        S_PROC_TYPE.Properties.DataSource = bindingSourceProduct.DataSource
        S_PROC_TYPE.Properties.ValueMember = "CODE"
        S_PROC_TYPE.Properties.DisplayMember = "NAME"
        S_PROC_TYPE.Properties.NullText = String.Empty
        S_PROC_TYPE.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_PROC_TYPE.Properties.SeparatorChar = ";"

        Timer2.Interval = 1000
        Timer2.Start()

        comdoc = New ComDoc(WG2)


        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        Try
            Dim ds As DataSet = YJQuerySearch("CrmUserInfo")
            ds = AdaptDataSourceForReport(ds)
            If ds.Tables.Contains("CrmUserInfo") Then
                UserInfoDt = ds.Tables("CrmUserInfo")
            End If
            ds = YJQuerySearch("REQ_SVC2")
            ds = AdaptDataSourceForReport(ds)
            If ds.Tables.Contains("REQ_SVC2") Then
                REQ_SVC2_dt = ds.Tables("REQ_SVC2")
            End If
        Catch ex As Exception

        End Try

        SetUserList(S_WORK_USR, ClientSessionInfo.OrganizationCode)
        SetUserList(WORK_USR, ClientSessionInfo.OrganizationCode)

        xtcETC.SelectedTabPageIndex = 0


    End Sub

    Private Property HotTrackRow() As Integer
        Get
            Return HotTrackRowValue
        End Get

        Set(ByVal Value As Integer)
            If HotTrackRowValue <> Value Then
                Dim PrevHotTrackRow As Integer
                PrevHotTrackRow = HotTrackRowValue
                HotTrackRowValue = Value
                GV1.RefreshRow(PrevHotTrackRow)
                GV1.RefreshRow(HotTrackRowValue)
            End If
        End Set

    End Property

    Private Sub DeleteData()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim insFlag As String = ""

        Try
            If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Delete", MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then Exit Sub
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev4", "Delete", Me.ConvertToDataset)

        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Delete", MessageBoxIcon.Error)
            Exit Sub
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Delete", MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.BindToDataset(ds, "Data")
        Me.DataState = UI.DataStates.Retrieved


    End Sub

    Public Sub PopUpOnBeforeClick(ByVal dr As DataRow)
        Dim Key As String = dr("KEY")
        Dim Sender As String = ""
        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")

        Try
            Select Case dr("Action")
                Case Action.Addrow, Action.EventKey
                    Select Case Key
                        Case "WG1_ADDROW"
                            NewDetail()
                    End Select
                Case Action.Other
                    Select Case Key

                        'Gv1PopUp.ItemAdd(Action.Other, "SplitHorizontal", "가로/세로", "OPTION")
                    End Select
            End Select

        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Process failed!", MessageBoxIcon.Error)
            dr("Cancel") = True
        End Try

    End Sub

    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = Dr("Sender")
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = Nothing
        Dim rowIndex As Integer = 0
        Select Case Dr("Action")
            Case Action.NavigateTo
                Select Case Key
                    Case "ComDocumentMgt"
                        fTarget = frmMain.NavigateTo(Key, NavigatedWindowModes.Dialog, False)
                        If fTarget IsNot Nothing Then
                            fTarget.S_MNGT_NO.text = GV1.GetFocusedRowCellValue("MNGT_NO").ToString
                            fTarget.SCREEN.Text = "사이트 지원 등록"
                            fTarget.DirList.Text = "CrmAsMgt"
                            fTarget.SearchData()
                            fTarget.ShowDialog()
                        End If
                    Case "CrmCustomerMgt"
                        fTarget = frmMain.NavigateTo(Key)
                        If fTarget IsNot Nothing Then
                            fTarget.SEARCH_KEY.Text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                            fTarget.SearchData()
                        End If
                End Select
            Case Action.Addrow
                Select Case Key
                    Case "WG1_ADDROW"
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "REQ_YMD", DateTime.Now.ToString("yyyyMMdd"))
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "REQ_HM", DateTime.Now.ToString("yyyyMMddHHmmss").Substring(8, 4))
                        GV1.OptionsBehavior.Editable = True

                End Select
                'Case Action.CheckBox

            Case Action.Other
                Select Case Key
                    Case "ExceptList"
                        Call ExceptList(GV3.GetFocusedRowCellValue("MNGT_NO").ToString)
                    Case "ExceptCancel"
                        Call ExceptCancel(GV3.GetFocusedRowCellValue("MNGT_NO").ToString)
                    Case "WG1_SEARCH", "WG1_DOUBLE_CLICK_DETAIL"
                        SaveUserSetting(Key, "Horizontal")
                        SaveUserSetting(Key, "SplitterPosition")
                    Case "DEFAULT"
                        '  ResetLayout()
                    Case "Complete"
                        GV1.SetRowCellValue(GV1.FocusedRowHandle, "PROC_TYPE", "1")
                    Case "SplitHorizontal"
                        If Not ContolList(Sender) Is Nothing Then
                            Dim obj As Object = ContolList(Sender)
                            Do While True
                                If obj Is Nothing Then
                                    Exit Do
                                End If
                                If obj.GetType.ToString.Contains("SplitContainerControl") Then
                                    If obj.Horizontal = True Then
                                        obj.Horizontal = False
                                    Else
                                        obj.Horizontal = True
                                    End If
                                    Exit Do
                                Else
                                    obj = obj.Parent
                                End If
                            Loop
                            'DevExpress.XtraEditors.

                        End If
                End Select
        End Select

    End Sub

    Private Sub SearchOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again !")
            End If

            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            Me.ClearView(UI.AppliedRangeTypes.Except, {S_SEARCH_KEY, S_FM_YMD, S_TO_YMD, REF_TIME, S_WORK_USR, SCREEN})

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Search", MessageBoxIcon.Warning)
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Private Sub NewData()

        ClearView(UI.AppliedRangeTypes.Except, {WG1, WG3, S_SEARCH_KEY, S_PROC_TYPE, REF_TIME, S_WORK_USR, SCREEN})
    End Sub

    Public Sub SaveData()

        If REQ_SVC.SelectedValue = "" Then
            MsgBoxLocalized("업무구분1 누락", MessageBoxButtons.OK, "error", MessageBoxIcon.Error)
            REQ_SVC.Focus()
            Exit Sub
        End If

        If REQ_SVC2.SelectedValue = "" Then
            MsgBoxLocalized("업무구분2 누락", MessageBoxButtons.OK, "error", MessageBoxIcon.Error)
            REQ_SVC2.Focus()
            Exit Sub
        End If

        If REQ_SVC3.SelectedValue = "" Then
            MsgBoxLocalized("업무구분3 누락", MessageBoxButtons.OK, "error", MessageBoxIcon.Error)
            REQ_SVC3.Focus()
            Exit Sub
        End If

        If WORK_USR.SelectedValue = "" Then
            MsgBoxLocalized("담당자 누락", MessageBoxButtons.OK, "error", MessageBoxIcon.Error)
            WORK_USR.Focus()
            Exit Sub
        End If

        Select Case PROC_TYPE.SelectedValue
            Case "2"
                If REQ_YMD.Text = "" Then REQ_YMD.Text = Now.ToString("yyyyMMdd")
                If REQ_HM.Text = "" Then REQ_HM.Text = Now.ToString("HHmm")
            Case "3", "9"
                If CMPT_YMD.Text = "" Then CMPT_YMD.Text = Now.ToString("yyyyMMdd")
                If CMPT_HM.Text = "" Then CMPT_HM.Text = Now.ToString("HHmm")

                If REQ_YMD.Text = "" OrElse REQ_HM.Text = "" Then
                    MsgBoxLocalized("시작일자가 누락되었습니다. 자료입력후 저장하세요.")
                    REQ_YMD.Focus()
                    Exit Sub
                End If
        End Select

        Dim dsResult As DataSet

        'Dim DS As DataSet = GetConvertToDataSet("Search")
        'DS.Merge(Me.ConvertToDataset)
        'Dim params As Object = {DS, comdoc.getUploadPath}
        'Dim byteUploadFiles()() As Byte = comdoc.byteUploadFiles
        'Dim tempFolder As String = comdoc.getTempFolder
        'Dim strFileName As String = ""
        'For i As Integer = 0 To GV2.RowCount - 1
        '    GV2.SetRowCellValue(i, "SEQ", comdoc.GetSeq(i, MNGT_NO.Text))
        'Next
        'comdoc.SetUploadPath(Split("CrmAsMgt", "/"))

        dsResult = Me.ConvertToDataset
        dsResult.Tables("MAIN").Columns.Add("S_DEV_PROC_TYPE")
        dsResult.Tables("MAIN").Rows(0)("S_DEV_PROC_TYPE") = S_PROC_TYPE.EditValue

        Dim params As Object = {dsResult, comdoc.getUploadPath}
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev4", "Save3", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(dsResult, "Data")
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            '작업지원현황 자동 조회
            For Each frm As Object In Me.ParentForm.Controls
                Debug.Print(frm.GetType.Name & "   /   " & frm.Name)
                If frm.GetType.Name = "DockPanel" AndAlso frm.Name = "LeftPanel" Then
                    Call SearchLeftForm(frm)
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SearchLeftForm(ByVal ctrlContainer As Object)
        For Each ctrl As Object In ctrlContainer.Controls
            Debug.Print(ctrl.GetType.Name & "   /   " & ctrl.Name)
            If String.Equals(ctrl.GetType.Name, "CrmLeftForm", StringComparison.InvariantCultureIgnoreCase) Then
                ctrl.SearchData()
                Exit For
            End If

            ' If the control has children, 
            ' recursively call this function 
            If ctrl.HasChildren Then
                SearchLeftForm(ctrl)
            End If
        Next
    End Sub

    Public Sub initPopup()
        Gv1PopUp = New PopupBase
        Gv1PopUp.ItemAdd(Action.NavigateTo, "ComDocumentMgt", "문서관리")
        Gv1PopUp.ItemAdd(Action.NavigateTo, "CrmCustomerMgt", "거래처 관리", True)
        Gv1PopUp.ItemAdd(Action.Excel, "WG1_EXCEL", "Excel Export", True)
        Gv1PopUp.PopUpInit(Me, WG1, "REQ_SVC", "CMPT_YMD")

        Gv3PopUp = New PopupBase
        Gv3PopUp.ItemAdd(Action.Other, "ExceptList", "제외처리")
        Gv3PopUp.ItemAdd(Action.Other, "ExceptCancel", "제외처리 취소", True)
        Gv3PopUp.PopUpInit(Me, WG3)

        MainPopUp = New PopupBase
        MainPopUp.ItemAdd(Action.NavigateTo, "CrmCustomerMgt", "거래처 관리", True)
        MainPopUp.PopUpInit(Me)
    End Sub

    Public Sub InitGrid()

        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        Dim dt As DataTable = New DataTable
        editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        editor.CodeType = "YJIT.CodeService.Customer"
        editor.DisplayParams = "Code:#CUST_CD,CUST_LOCNM:#CUST_NM"
        editor.ValidateKeys = "KEY:#CUST_CD"
        editor.DataParams = "Type:''"
        editor.KeepIntegrity = True
        editor.AutoSuggestion = False
        editor.MaxLength = "10"
        editor.SearchPopup = "CustomerMaster"
        editor.CharacterCasing = CharacterCasing.Upper
        GV1.Columns("CUST_CD").ColumnEdit = editor


        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T07")
        dataParams.Add("NameType", "")
        Dim T07 As DataTable = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = T07
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("PROC_TYPE").ColumnEdit = editorCombo

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "0", "매우급함")
        AddNewRow(dt, "1", "급함")
        AddNewRow(dt, "2", "당일처리")
        AddNewRow(dt, "3", "내일처리")
        AddNewRow(dt, "4", "일주일")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV1.Columns("PRIORITY").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "Z01")
        dataParams.Add("NameType", "")
        editorCombo.ShowHeader = False
        editorCombo.ReadOnly = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("REQ_SVC").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "Z02")
        dataParams.Add("NameType", "")
        editorCombo.ShowHeader = False
        editorCombo.ReadOnly = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("REQ_SVC2").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "Z03")
        dataParams.Add("NameType", "")
        editorCombo.ShowHeader = False
        editorCombo.ReadOnly = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("REQ_SVC3").ColumnEdit = editorCombo

        Common.DrawRowIndicator(GV1)

        Dim editorImgCombo As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox = comdoc.getImageComboBox()
        editorImgCombo.SmallImages = comdoc.getIcons()
        GV2.Columns("FILE_ICON").ColumnEdit = editorImgCombo
        GV2.Columns("SUCCESS").ColumnEdit = editorImgCombo

        'GV3 *********************************************************************

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T02")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV3.Columns("REQ_SVC").ColumnEdit = editorCombo

        ''업무2
        'If Not REQ_SVC2_dt Is Nothing Then
        '    dt = New DataTable
        '    dt.Columns.Add("CODE")
        '    dt.Columns.Add("NAME")
        '    dt = REQ_SVC2_dt.Copy

        '    Dim drAdd As DataRow = dt.NewRow
        '    drAdd("CODE") = ""
        '    drAdd("NAME") = " "
        '    dt.Rows.InsertAt(drAdd, 0)

        '    editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        '    editorCombo.DisplayMember = "NAME"
        '    editorCombo.ValueMember = "CODE"
        '    editorCombo.NullText = ""
        '    editorCombo.DataSource = dt.Copy
        '    editorCombo.ForceInitialize()
        '    editorCombo.PopulateColumns()
        '    editorCombo.Columns("CODE").Visible = False
        '    editorCombo.ShowHeader = False
        '    GV3.Columns("REQ_SVC2").ColumnEdit = editorCombo
        'End If


        ''비용 내역 항목
        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.ValueMember = "CODE"
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.NullText = ""
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "T05")
        'dataParams.Add("NameType", "")
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'GV3.Columns("REQ_TYPE").ColumnEdit = editorCombo

        ''요청상세
        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.ValueMember = "CODE"
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.NullText = ""
        'searchParams = New Dictionary(Of String, Object)
        'dataParams = New Dictionary(Of String, Object)
        'dataParams.Add("GroupCode", "T09")
        'dataParams.Add("NameType", "")
        'editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'GV3.Columns("REQ_TYPE2").ColumnEdit = editorCombo

        editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        editor.CodeType = "YJIT.CodeService.Customer"
        editor.DisplayParams = "Code:#CUST_CD,CUST_LOCNM:#CUST_NM"
        editor.ValidateKeys = "KEY:#CUST_CD"
        editor.DataParams = "Type:''"
        editor.KeepIntegrity = True
        editor.AutoSuggestion = False
        editor.MaxLength = "10"
        editor.SearchPopup = "CustomerMaster"
        editor.CharacterCasing = CharacterCasing.Upper
        GV3.Columns("CUST_CD").ColumnEdit = editor


        editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        editor.CodeType = "YJIT.CodeService.CustomerPic"
        editor.DisplayParams = "Code:#REQ_USR,Name:#TEL_NO"
        editor.ValidateKeys = "KEY:#REQ_USR"
        editor.DataParams = "Customer:@CUST_CD"
        editor.KeepIntegrity = False
        editor.AutoSuggestion = False
        editor.MaxLength = "10"
        editor.SearchPopup = "CodeMaster"
        editor.CharacterCasing = CharacterCasing.Normal
        GV3.Columns("REQ_USR").ColumnEdit = editor

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "0", "미확인")
        AddNewRow(dt, "7", "처리중")
        AddNewRow(dt, "1", "완료")
        AddNewRow(dt, "2", "즉시처리")
        AddNewRow(dt, "3", "재발신예정")
        AddNewRow(dt, "4", "재발신")
        AddNewRow(dt, "5", "수정요청")
        AddNewRow(dt, "6", "추가요청")
        AddNewRow(dt, "8", "보류")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("PROC_TYPE").ColumnEdit = editorCombo

        dt = New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "0", "매우급함")
        AddNewRow(dt, "1", "급함")
        AddNewRow(dt, "2", "당일처리")
        AddNewRow(dt, "3", "내일처리")
        AddNewRow(dt, "4", "일주일")

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = ""
        editorCombo.DataSource = dt.Copy
        editorCombo.ForceInitialize()
        editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
        editorCombo.ShowHeader = False
        GV3.Columns("PRIORITY").ColumnEdit = editorCombo

        'dt = New DataTable
        'dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        'dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        'AddNewRow(dt, "Y", "무상")
        'AddNewRow(dt, "N", "유상")

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.ValueMember = "CODE"
        'editorCombo.NullText = ""
        'editorCombo.DataSource = dt.Copy
        'editorCombo.ForceInitialize()
        'editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'editorCombo.ShowHeader = False
        'GV3.Columns("FREE_YN").ColumnEdit = editorCombo

    End Sub

    Private Function GetCustomerInfo() As DataTable
        '/////////// 거래처정보 ///////////'
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        AddNewRow(dt, "01", "ETC")

        Return dt
    End Function

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

#End Region

#Region "=================Control Events==========="
    Dim NextFoucsList() As String = {"REQ_YMD", "REQ_HM", "DEPT_AUTH_LIST", "CUST_CD", "REQ_USR", "TEL_NO", "DEV_REQ_TYPE", "DEV_PRIORITY", "DEV_CONTENT", "PRAR_YMD", "CMPT_YMD", "CMPT_HM", "AS_CONTENT", "DEV_WORK_USR", "DEV_PRAR_YMD", "DEV_TEST_USR", "DEV_CMPT_YMD"}
    Dim NextFocusDt As DataTable

    Private Sub CrmAsMgtDev4_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call InitData()
        Call InitGrid()
        Call initPopup()
        SaveControlValues(Me, {WG1, S_FM_YMD, S_TO_YMD, S_WORK_USR, S_PROC_TYPE, REF_TIME, S_WORK_AREA})

        ShownFlag = False
        If REF_TIME.SelectedValue = "0" Then
            Timer2.Stop()
        Else
            MaxInterval = 60 * CDbl(REF_TIME.SelectedValue)
        End If

        GetControlList()

        SaveUserSetting("DEFAULT", "Horizontal")
        SaveUserSetting("DEFAULT", "SplitterPosition")

        GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default
        GV1.OptionsBehavior.Editable = False

        For I = 0 To My.Settings.controlLocations.Count - 1
            Dim KEY As String = My.Settings.controlLocations(I)
            Dim KeySplt() As String = KEY.Split("!")
            Select Case KeySplt(0)
                Case MainSplit.Name
                    MainSplit.SplitterPosition = KeySplt(1)
                Case ModifySplit.Name
                    ModifySplit.SplitterPosition = KeySplt(1)
                Case FileInputSplit.Name
                    FileInputSplit.SplitterPosition = KeySplt(1)

            End Select
        Next



        GroupControl3.Text = ClientSessionInfo.OrganizationName
        Me.Localizer1.SetWordID(Me.GroupControl3, ClientSessionInfo.OrganizationName)
        Me.Text = ClientSessionInfo.OrganizationName & " 작업 현황"
        For Each ctrl As Object In palAutoButton.Controls
            If ctrl.GetType.ToString.Contains("Label") Then
                ctrl.Text = ClientSessionInfo.OrganizationName & " 작업 현황"
                'Exit For
            End If
        Next

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchListData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveData()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call DeleteData()
    End Sub

    Private Sub SEARCH_KEY_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles S_SEARCH_KEY.PreviewKeyDown, SCREEN.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Call SearchData()
        End If
    End Sub

    Private Sub GV1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.Click
        Try
            If GV1.RowCount > 0 Then
                SearchDetail(GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO").ToString, GV1.GetRowCellValue(GV1.FocusedRowHandle, "WORK_USR").ToString)
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub SearchDetail(ByVal MNGT_NO As String, ByVal WORK_USR As String)

        If comdoc Is Nothing Then comdoc = New ComDoc(WG2)

        Dim ds As DataSet = Me.ConvertToDataset
        ds.Tables("MAIN").Rows(0)("MNGT_NO") = MNGT_NO
        ds.Tables("MAIN").Rows(0)("WORK_USR") = WORK_USR

        Dim retDs As DataSet = Nothing
        Try
            retDs = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev4", "SearchInput", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Try
            Dim dr As DataRow = retDs.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg").ToString)

                SearchData()
                Exit Sub
            End If
            Me.BindToDataset(retDs, "Data")

            Call InitIcons()

            If REQ_SVC2.SelectedValue = "" Then
                SetReqsvc2(REQ_SVC.SelectedValue, 0)
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Private Sub InitIcons()
        For i = 0 To GV2.RowCount - 1
            If Not comdoc.IsContainExtension(GV2.GetRowCellValue(i, "FILE_ICON").ToString) And GV2.GetRowCellValue(i, "FILE_NM").ToString <> "" Then
                GV2.SetRowCellValue(i, "FILE_ICON", "dft")
            End If
            GV2.SetRowCellValue(i, "UPLOAD", "UPLOAD")
        Next
    End Sub

    Private Sub GV1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle
        If e.RowHandle = HotTrackRow Then
            e.Appearance.BackColor = Color.PaleGoldenrod
        End If

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If e.RowHandle < 0 Then Exit Sub

            Select Case e.Column.FieldName
                Case "MNGT_NO"
                    If view.GetRowCellValue(e.RowHandle, "SYS_ID").ToString = "ELVIS" Then
                        e.Appearance.BackColor = System.Drawing.Color.Violet
                    End If
            End Select

            If view.GetRowCellValue(e.RowHandle, "PRIORITY").ToString = "0" Or view.GetRowCellValue(e.RowHandle, "PRIORITY").ToString = "1" Then
                e.Appearance.BackColor = System.Drawing.Color.Orange
                e.Appearance.ForeColor = System.Drawing.Color.Blue
            Else
                If view.GetRowCellValue(e.RowHandle, "DELAY_YN").ToString = "Y" Then
                    e.Appearance.BackColor = System.Drawing.Color.LightYellow
                    e.Appearance.ForeColor = System.Drawing.Color.Black
                End If
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub GV3_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV3.RowCellStyle

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If e.RowHandle < 0 Then Exit Sub
            Select Case e.Column.FieldName
                Case "MNGT_NO"
                    If view.GetRowCellValue(e.RowHandle, "SYS_ID").ToString = "ELVIS" Then
                        e.Appearance.BackColor = System.Drawing.Color.Violet
                    End If
            End Select
            If view.GetRowCellValue(e.RowHandle, "PRIORITY").ToString = "0" Or view.GetRowCellValue(e.RowHandle, "PRIORITY").ToString = "1" Then
                e.Appearance.BackColor = System.Drawing.Color.Orange
                e.Appearance.ForeColor = System.Drawing.Color.Blue
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

    End Sub


    Private Sub S_ROW_BEST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GV1.OptionsView.RowAutoHeight = False
    End Sub

    Private Sub REF_TIME_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REF_TIME.SelectedValueChanged
        If REF_TIME.SelectedValue = "0" Then
            Timer2.Stop()
        Else
            MaxInterval = 60 * CDbl(REF_TIME.SelectedValue)
        End If

    End Sub

    Private Sub MainSplit_SplitterPositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainSplit.SplitterPositionChanged, ModifySplit.SplitterPositionChanged, FileInputSplit.SplitterPositionChanged


        Dim Max As Integer = sender.Size.Width
        Dim N As Integer = sender.SplitterPosition

        If sender.Horizontal = False Then
            Max = sender.Size.Height
        End If
        If Max - N <= 10 Then
            sender.SplitterPosition = Max - 11
        End If
        If sender.SplitterPosition <= 10 Then
            sender.SplitterPosition = 11
        End If

    End Sub

    Private Sub DEPT_AUTH_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'CUST_CD.Focus()
        End If
    End Sub

    Private Sub DEV_WORK_USR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            PROC_TYPE.Focus()
        End If
    End Sub

    Private Sub TO_YMD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_TO_YMD.KeyDown
        If e.KeyCode = Keys.Enter Then
            S_PROC_TYPE.Focus()
        End If
        '
    End Sub

    Private Sub S_DEPT_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            S_WORK_USR.Focus()
        End If
    End Sub

    Private Sub SEARCH_KEY_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_SEARCH_KEY.KeyDown, SCREEN.KeyDown
        'SEARCH_KEY
        If e.KeyCode = Keys.Enter Then
            S_SEARCH_KEY.Focus()
        End If
    End Sub

    Private Sub S_DEV_WORK_USR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            S_PROC_TYPE.Focus()
        End If
    End Sub

    Private Sub S_DEV_PROC_TYPE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_PROC_TYPE.KeyDown
        'S_DEV_PROC_TYPE
        If e.KeyCode = Keys.Enter Then
            S_SEARCH_KEY.Focus()
        End If
    End Sub

    Private Sub CrmAsMgtDev4_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Reset()
        For Each Control As Control In {MainSplit, ModifySplit, FileInputSplit}
            My.Settings.controlLocations.Add(Control.Name & "!" & CType(Control, DevExpress.XtraEditors.SplitContainerControl).SplitterPosition)
        Next
        My.Settings.Save()
    End Sub

    Private Sub PROC_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROC_TYPE.SelectedIndexChanged
        If PROC_TYPE.SelectedValue = "9" Then
            If CMPT_YMD.Text = "" Then
                CMPT_YMD.Text = Now.ToString("yyyyMMdd")
                CMPT_HM.Text = Now.ToString("HHmmss")
                If InStr(RMK.Text, "개발팀 수정완료, 거래처에 안내요망") = 0 Then
                    Do While True
                        If InStrRev(RMK.Text, vbCrLf) = 0 Then Exit Do
                        If InStrRev(RMK.Text, vbCrLf) < Len(RMK.Text) - 1 Then Exit Do
                        If InStrRev(RMK.Text, vbCrLf) = Len(RMK.Text) - 1 Then RMK.Text = Mid(RMK.Text, 1, Len(RMK.Text) - 2)
                    Loop
                    If Not String.IsNullOrEmpty(RMK.Text.Trim.Replace(vbCrLf, "")) Then
                        RMK.Text &= vbCrLf & vbCrLf
                    End If
                    RMK.Text &= "개발팀 수정완료, 거래처에 안내요망"
                End If
            End If
        ElseIf PROC_TYPE.SelectedValue = "3" Then
            If CMPT_YMD.Text = "" Then
                CMPT_YMD.Text = Now.ToString("yyyyMMdd")
                CMPT_HM.Text = Now.ToString("HHmmss")
                If InStr(RMK.Text, "개발팀 수정완료, 거래처에 안내완료") = 0 Then
                    Do While True
                        If InStrRev(RMK.Text, vbCrLf) = 0 Then Exit Do
                        If InStrRev(RMK.Text, vbCrLf) < Len(RMK.Text) - 1 Then Exit Do
                        If InStrRev(RMK.Text, vbCrLf) = Len(RMK.Text) - 1 Then RMK.Text = Mid(RMK.Text, 1, Len(RMK.Text) - 2)
                    Loop
                    If Not String.IsNullOrEmpty(RMK.Text.Trim.Replace(vbCrLf, "")) Then
                        RMK.Text &= vbCrLf & vbCrLf
                    End If
                    RMK.Text &= "개발팀 수정완료, 거래처에 안내완료"
                End If
            End If
        ElseIf PROC_TYPE.SelectedValue = "2" Then
            REQ_YMD.Text = Now.ToString("yyyyMMdd")
            REQ_HM.Text = Now.ToString("HHmmss")
        End If
    End Sub

    Private Sub REQ_SVC_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REQ_SVC.SelectionChangeCommitted
        SetReqsvc2(REQ_SVC.SelectedValue, 1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = Me.MdiParent
        fTarget = frmMain.NavigateTo("DetailView", NavigatedWindowModes.Dialog, False)
        If Not IsNothing(fTarget) Then
            fTarget.RMK.Text = CONTENT.Text
            fTarget.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CUST_CD.Text <> "" Then
            Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
            Dim fTarget As Object = Nothing
            frmMain = Me.MdiParent
            fTarget = frmMain.NavigateTo("CrmCustomerMgt")
            If Not IsNothing(fTarget) Then
                fTarget.SEARCH_TYPE.SelectedValue = "CUST_CD"
                fTarget.SEARCH_KEY.Text = CUST_CD.Text
                fTarget.SearchData()
            End If

        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call SearchRefreshData()
    End Sub

    Private Sub GV3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV3.Click
        Try

            Me.ClearView(UI.AppliedRangeTypes.Except, {S_SEARCH_KEY, S_FM_YMD, S_TO_YMD, REF_TIME, S_WORK_USR, SCREEN, WG1, WG3})

            MNGT_NO.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "MNGT_NO").ToString
            AS_REQ_YMD.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "REQ_YMD").ToString
            CONTENT.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "CONTENT").ToString
            RMK.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "RMK").ToString
            INS_USR_NM.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "INS_USR_NM").ToString
            CUST_CD.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "CUST_CD").ToString
            CUST_NM.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "CUST_NM").ToString
            REQ_USR.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "REQ_USR").ToString
            TEL_NO.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "TEL_NO").ToString
            PRIORITY.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "PRIORITY").ToString
            REQ_SVC.SelectedValue = GV3.GetRowCellValue(GV3.FocusedRowHandle, "REQ_SVC").ToString
            RANK_NM.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "RANK_NM").ToString

            If MNGT_NO.Text <> "" Then
                Dim dsRet As DataSet = Nothing
                dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsMgtDev4", "SearchFileList", {MNGT_NO.Text})
                Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
                If drPairs("TrxCode").ToString <> "Y" Then
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                    Exit Sub
                End If
                Me.BindToDataset(dsRet, "Data")
                Me.DataState = UI.DataStates.Retrieved
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub CmdAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAssign.Click
        Call AssignData()
    End Sub

    'Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
    '    Try

    '        If CDbl(REF_TIME.SelectedValue) <> 0 Then
    '            lblTime.Text = "Refresh : " & second & " 초"
    '        Else
    '            lblTime.Text = ""
    '        End If

    '        second = second + 1
    '        If second >= MaxInterval Then
    '            second = 0
    '            Call SearchRefreshData()
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub WG3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WG3.Click
        CmdAssign.Enabled = True
        btnSave.Enabled = False
    End Sub

    Private Sub WG1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WG1.Click
        Try
            CmdAssign.Enabled = False
            btnSave.Enabled = True
            CMPT_RMK.ReadOnly = True
        Catch ex As Exception
        End Try

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CMPT_RMK.ReadOnly = False
        CMPT_RMK.Focus()
    End Sub

    Private Sub RANK_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RANK.SelectedValueChanged
        If RANK.SelectedValue = "C" Then
            PRAR_YMD.Text = Now.AddDays(1).ToString("yyyyMMdd")
        ElseIf RANK.SelectedValue = "B" Then
            PRAR_YMD.Text = Now.AddDays(4).ToString("yyyyMMdd")
        ElseIf RANK.SelectedValue = "A" Then
            PRAR_YMD.Text = Now.AddDays(7).ToString("yyyyMMdd")
        End If
    End Sub
    Private Sub DEV_ERR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEV_ERR_YN.CheckedChanged

        If DEV_ERR_YN.Checked = True Then
            DEV_ERR_NM.Text = ClientSessionInfo.LocalName
        End If

    End Sub

#End Region

End Class