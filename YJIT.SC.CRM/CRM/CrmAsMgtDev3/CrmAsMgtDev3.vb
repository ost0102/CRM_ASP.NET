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


Public Class CrmAsMgtDev3
    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    Dim second As Integer = 0
    Dim MaxInterval As Integer = 0
    Dim Gv1PopUp As New PopupBase
    Dim Gv2PopUp As New PopupBase
    Dim Gv3PopUp As New PopupBase
    Dim MainPopUp As New PopupBase
    Dim Gv1ChangeFlag As Boolean = False
    Dim ShownFlag As Boolean = True
    Private comdoc As ComDoc
    Dim UserInfoDt As DataTable = Nothing
    Dim ContolList As Dictionary(Of String, Object)
    Dim REQ_SVC2_dt As DataTable

#Region "=================Client Function==========="
    Public Sub SearchFromMsg(ByVal key1 As String, ByVal key2 As String, ByVal key3 As String, ByVal key4 As String, ByVal key5 As String)
        Select Case key2
            Case "PIC"
                Call SearchData("")

                If Not String.IsNullOrEmpty(key1) Then
                    With GV3
                        For i = 0 To .RowCount - 1
                            If key1 = .GetRowCellValue(i, "MNGT_NO").ToString Then
                                .FocusedRowHandle = i
                                Exit For
                            End If
                        Next
                    End With
                End If
            Case Else
                Call SearchReq("SearchFromMsg")

                If Not String.IsNullOrEmpty(key1) Then
                    With GV1
                        For i = 0 To .RowCount - 1
                            If key1 = .GetRowCellValue(i, "MNGT_NO").ToString Then
                                .FocusedRowHandle = i
                                Exit For
                            End If
                        Next
                    End With
                End If
        End Select
    End Sub
#End Region

#Region "=================Data logic actions==========="
    Private Sub NotiPopup()
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
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev", "ExceptList", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Call SearchReq("ExceptList")
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
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev", "ExceptCancel", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Call SearchReq("ExceptCancel")
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
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev", "AssignData2", Me.ConvertToDataset)
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

        Call SearchReq("AssignData")
        Call SearchData(MNGT_NO.Text)
        Call SearchDetail(tMNGT_NO, "1", ClientSessionInfo.UserID)
    End Sub

    Public Sub SearchReq(ByVal eventName As String)
        If eventName = "Timer2_Tick" Then
            If Now.Hour >= 0 AndAlso Now.Hour <= 7 Then Exit Sub
            If Now.Hour >= 20 AndAlso Now.Hour <= 23 Then Exit Sub
        End If


        Dim nCnt As Integer = GV3.RowCount

        Dim dsRet As DataSet = Nothing
        dsRet = Me.ConvertToDataset
        dsRet.Tables("MAIN").Columns.Add("S_DEPT_LIST")
        dsRet.Tables("MAIN").Rows(0)("S_DEPT_LIST") = S_DEPT_LIST.EditValue
        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsMgtDev", "SearchReq", dsRet)
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode").ToString <> "Y" Then
            MsgBoxLocalized(drPairs("TrxMsg"))
            Me.DataState = UI.DataStates.Retrieved
            Exit Sub
        End If
        Me.BindToDataset(dsRet, "Data")
        Me.DataState = UI.DataStates.Retrieved

        If ClientSessionInfo.UserID = "HCS" And nCnt < GV3.RowCount Then
            Call NotiPopup()
        End If

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

    Private Sub SetUserList(ByVal sender As Object, ByVal Dept_Cd As String)
        If IsNothing(UserInfoDt) Then Exit Sub

        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        Try
            Dim Drs() As DataRow
            If Dept_Cd = "ALL" Then
                Drs = UserInfoDt.Select("1=1", "DEPT_CD ASC,LOC_NM ASC")
            Else
                If Dept_Cd.Contains(";") Then
                    Drs = UserInfoDt.Select("DEPT_CD IN ('" & Dept_Cd.Replace(" ", "").Replace(";", "','") & "')", "LOC_NM ASC")
                Else
                    Drs = UserInfoDt.Select("DEPT_CD = '" & Dept_Cd & "'", "LOC_NM ASC")
                End If
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

    Private Function GetConvertToDataSet(ByVal KEY As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            Select Case KEY
                Case "CrmUserInfo"
                    YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
                Case "REQ_SVC2"
                    YJSql.SqlBox("REQ_SVC2", "CrmAsMgtDev@GetReqSvc2List", True)
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

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
        S_DEV_PROC_TYPE.Properties.DataSource = bindingSourceProduct.DataSource
        S_DEV_PROC_TYPE.Properties.ValueMember = "CODE"
        S_DEV_PROC_TYPE.Properties.DisplayMember = "NAME"
        S_DEV_PROC_TYPE.Properties.NullText = String.Empty
        S_DEV_PROC_TYPE.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_DEV_PROC_TYPE.Properties.SeparatorChar = ";"

        dtCol = New DataTable
        dtCol.Columns.Add(New DataColumn("CODE"))
        dtCol.Columns.Add(New DataColumn("NAME"))

        dtCol.Rows.Add()
        dtCol.Rows(0)("CODE") = "E"
        dtCol.Rows(0)("NAME") = "ELVIS"

        dtCol.Rows.Add()
        dtCol.Rows(1)("CODE") = "O"
        dtCol.Rows(1)("NAME") = "ELVIS(Etc)"

        dtCol.Rows.Add()
        dtCol.Rows(2)("CODE") = "V"
        dtCol.Rows(2)("NAME") = "일반"

        dtCol.Rows.Add()
        dtCol.Rows(3)("CODE") = "W"
        dtCol.Rows(3)("NAME") = "WMS"

        dtCol.Rows.Add()
        dtCol.Rows(4)("CODE") = "L"
        dtCol.Rows(4)("NAME") = "운송"

        dtCol.Rows.Add()
        dtCol.Rows(5)("CODE") = "H"
        dtCol.Rows(5)("NAME") = "인사급여"

        dtCol.Rows.Add()
        dtCol.Rows(6)("CODE") = "A"
        dtCol.Rows(6)("NAME") = "대리점"

        dtCol.Rows.Add()
        dtCol.Rows(7)("CODE") = "B"
        dtCol.Rows(7)("NAME") = "보세"

        dtCol.Rows.Add()
        dtCol.Rows(8)("CODE") = "C"
        dtCol.Rows(8)("NAME") = "쿠리어"

        dtCol.Rows.Add()
        dtCol.Rows(9)("CODE") = "M"
        dtCol.Rows(9)("NAME") = "적하목록"

        dtCol.Rows.Add()
        dtCol.Rows(10)("CODE") = "T"
        dtCol.Rows(10)("NAME") = "T/S"

        dtCol.Rows.Add()
        dtCol.Rows(11)("CODE") = "Z"
        dtCol.Rows(11)("NAME") = "기타"

        bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = dtCol
        S_SVC_CD.Properties.DataSource = bindingSourceProduct.DataSource
        S_SVC_CD.Properties.ValueMember = "CODE"
        S_SVC_CD.Properties.DisplayMember = "NAME"
        S_SVC_CD.Properties.NullText = String.Empty
        S_SVC_CD.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_SVC_CD.Properties.SeparatorChar = ";"


        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        Dim DeptDt As DataTable = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        'For I = DeptDt.Rows.Count - 1 To 0 Step -1
        '    If DeptDt.Rows(I)("CODE") <> ClientSessionInfo.OrganizationCode Then
        '        DeptDt.Rows.RemoveAt(I)
        '    End If
        'Next
        'DeptDt.Rows.Add("ETC", "타부서 요청사항")
        For I = DeptDt.Rows.Count - 1 To 0 Step -1
            If Not DeptDt.Rows(I)("NAME").ToString.Contains("개발") Then
                DeptDt.Rows.RemoveAt(I)
            End If
        Next
        bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = DeptDt.Copy
        S_DEPT_LIST.Properties.DataSource = bindingSourceProduct.DataSource
        S_DEPT_LIST.Properties.ValueMember = "CODE"
        S_DEPT_LIST.Properties.DisplayMember = "NAME"
        S_DEPT_LIST.Properties.NullText = String.Empty
        S_DEPT_LIST.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_DEPT_LIST.Properties.SeparatorChar = ";"


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

        SetUserList(S_DEV_WORK_USR, ClientSessionInfo.OrganizationCode)
        SetUserList(WORK_USR, ClientSessionInfo.OrganizationCode)
        SetUserList(DEV_ERR_NM, ClientSessionInfo.OrganizationCode)
        SetUserList(QC_TESTER, ClientSessionInfo.OrganizationCode)

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
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev2", "Delete", Me.ConvertToDataset)

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
                        End If
                    Case "WG2_Download"
                        If GV2.FocusedRowHandle >= 0 < GV2.RowCount AndAlso GV2.GetFocusedRowCellValue("SUCCESS").ToString() <> "N" Then
                            If GV2.GetFocusedRowCellValue("FILE_NM").ToString.Trim <> "" Then
                                SaveFileDialog1.FileName = GV2.GetFocusedRowCellValue("FILE_NM").ToString
                                SaveFileDialog1.Filter = "All files (*.*)|*.*"
                                SaveFileDialog1.ValidateNames = True
                                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK And SaveFileDialog1.FileName <> "" Then
                                    Dim retD As New Dictionary(Of String, String)
                                    If GV2.GetFocusedRowCellValue("FORM_ID").ToString <> "OnlineHelp" Then
                                        retD = comdoc.DownLoadFile(GV2.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV2.GetFocusedRowCellValue("SEQ").ToString,
                                  GV2.GetFocusedRowCellValue("FILE_NM").ToString,
                                  GV2.GetFocusedRowCellValue("FILE_PATH").ToString,
                                  SaveFileDialog1.FileName)
                                    Else
                                        retD = comdoc.DownLoadFileOnline(GV2.GetFocusedRowCellValue("FILE_NM").ToString,
                                  GV2.GetFocusedRowCellValue("FILE_PATH").ToString,
                                  SaveFileDialog1.FileName)
                                    End If

                                    If retD("TrxCode").ToString <> "Y" Then
                                        MsgBoxLocalized(retD("TrxMsg").ToString, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                                    End If
                                End If
                            End If
                        Else
                            MsgBoxLocalized("File is not selected or file size is exceeded.", MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Warning)
                        End If
                End Select
        End Select
    End Sub

    Public Sub SearchData(ByVal sMngtNo As String)
        If SearchValidate() = False Then Exit Sub

        If FM_YMD.Text = "" Then
            FM_YMD.Focus()
            MsgBoxLocalized("등록일자 시작일은 필수 입니다.")
            Exit Sub
        End If

        Dim FmYmd As String = FM_YMD.Text
        Dim ToYmd As String = Now.ToString("yyyyMMdd")
        If Not String.IsNullOrEmpty(TO_YMD.Text.ToString) Then ToYmd = TO_YMD.Text
        If FmYmd.Count < 8 Then
            MsgBoxLocalized("등록일자 시작일이 잘못되었습니다.")
            Exit Sub
        End If
        If ToYmd.Count < 8 Then
            MsgBoxLocalized("등록일자 종료일이 잘못되었습니다.")
            Exit Sub
        End If
        Dim Mondths As Long = DateDiff(DateInterval.Month, CDate(String.Format("{0}-{1}-{2}", FmYmd.Substring(0, 4), FmYmd.Substring(4, 2), FmYmd.Substring(6, 2))), CDate(String.Format("{0}-{1}-{2}", ToYmd.Substring(0, 4), ToYmd.Substring(4, 2), ToYmd.Substring(6, 2))))
        If Mondths + 1 > 6 Then
            MsgBoxLocalized("등록일자 기간은 최대 6개월까지 조회 가능합니다.")
            Exit Sub
        End If

        Dim dsRet As DataSet = Nothing
        dsRet = Me.ConvertToDataset
        dsRet.Tables("MAIN").Columns.Add("S_DEV_PROC_TYPE")
        dsRet.Tables("MAIN").Rows(0)("S_DEV_PROC_TYPE") = S_DEV_PROC_TYPE.EditValue
        dsRet.Tables("MAIN").Columns.Add("S_DEPT_LIST")
        dsRet.Tables("MAIN").Rows(0)("S_DEPT_LIST") = S_DEPT_LIST.EditValue

        If Not String.IsNullOrEmpty(dsRet.Tables("MAIN").Rows(0)("S_DEPT_LIST").ToString.Trim) Then
            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsMgtDev", "SearchAssign", {dsRet, sMngtNo, dsRet.Tables("MAIN").Rows(0)("S_DEPT_LIST").ToString.Trim})
        Else
            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsMgtDev", "SearchAssign", {dsRet, sMngtNo, ClientSessionInfo.OrganizationCode})
        End If


        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, FM_YMD, TO_YMD, S_ROW_BEST, REF_TIME, S_PRIORITY, S_DEV_WORK_USR, SCREEN, WG3, WORK_AREA, CMPT_YMD_YN, PGM_MDF_YN, S_YEAR, S_SEARCH_TYPE, S_SEARCH_KEY})
                Me.BindToDataset(dsRet, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, FM_YMD, TO_YMD, S_ROW_BEST, REF_TIME, S_PRIORITY, S_DEV_WORK_USR, SCREEN, WG3, WORK_AREA, CMPT_YMD_YN, PGM_MDF_YN, S_YEAR, S_SEARCH_TYPE, S_SEARCH_KEY})
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

        If PGM_MDF.Text = "" Then
            '==20210908 정윤기 / 진행현황 : 개발완료,요청완료,완료 상태일때 체크하도록 수정
            Select Case PROC_TYPE.SelectedValue
                Case "Z", "9", "1"
                    If RANK1.YesNo = "Y" Or RANK2.YesNo = "Y" Or RANK3.YesNo = "Y" Or RANK4.YesNo = "Y" Or RANK5.YesNo = "Y" Or RANK6.YesNo = "Y" Then
                        MsgBoxLocalized("프로그램 수정사항을 입력해주세요.", MessageBoxButtons.OK, "error", MessageBoxIcon.Error)
                        PGM_MDF.Focus()
                        Exit Sub
                    End If
            End Select
        End If

        Select Case PROC_TYPE.SelectedValue
            Case "7"
                If REQ_YMD.Text = "" Then REQ_YMD.Text = Now.ToString("yyyyMMdd")
                If REQ_HM.Text = "" Then REQ_HM.Text = Now.ToString("HHmm")
            Case "Z" '고객지원관리 색상미표시 처리
                CMPT_YMD.Text = ""
                CMPT_HM.Text = ""
            Case "1", "9"
                If CMPT_YMD.Text = "" Then CMPT_YMD.Text = Now.ToString("yyyyMMdd")
                If CMPT_HM.Text = "" Then CMPT_HM.Text = Now.ToString("HHmm")

                If REQ_YMD.Text = "" OrElse REQ_HM.Text = "" Then
                    MsgBoxLocalized("시작일자가 누락되었습니다. 자료입력후 저장하세요.")
                    REQ_YMD.Focus()
                    Exit Sub
                End If
        End Select

        Select Case PROC_TYPE.SelectedValue
            Case "Z", "9", "1"
                If RANK1.YesNo = "N" _
                          AndAlso RANK2.YesNo = "N" _
                          AndAlso RANK3.YesNo = "N" _
                          AndAlso RANK4.YesNo = "N" _
                          AndAlso RANK5.YesNo = "N" _
                          AndAlso RANK6.YesNo = "N" _
                          AndAlso RANK7.YesNo = "N" _
                          AndAlso RANK8.YesNo = "N" _
                          AndAlso RANK9.YesNo = "N" _
                          AndAlso RANK10.YesNo = "N" _
                          AndAlso RANK11.YesNo = "N" _
                          AndAlso RANK12.YesNo = "N" _
                          AndAlso RANK13.YesNo = "N" _
                          AndAlso RANK14.YesNo = "N" _
                          AndAlso RANK15.YesNo = "N" _
                          AndAlso RANK16.YesNo = "N" _
                          AndAlso RANK17.YesNo = "N" Then
                    MsgBoxLocalized("처리 상세항목이 누락되었습니다. 자료선택후 저장하세요.", MessageBoxButtons.OK, "error", MessageBoxIcon.Error)
                    WORK_USR.Focus()
                    Exit Sub
                End If
        End Select

        If CDec(System.Math.Abs(DEV_SCORE.Value)) > CDec(10) Then
            MsgBoxLocalized("팀장점수(10~0.1)를 확인해 주세요.", MessageBoxButtons.OK, "error", MessageBoxIcon.Error)
            DEV_SCORE.Focus()
            Exit Sub
        End If

        If CMPT_YMD.Text = "" AndAlso (PROC_TYPE.SelectedValue = "1" OrElse PROC_TYPE.SelectedValue = "9") Then
            CMPT_YMD.Text = Now.ToString("yyyyMMdd")
            CMPT_HM.Text = Now.ToString("HHmm")
        End If


        Dim dsResult As DataSet
        dsResult = Me.ConvertToDataset
        dsResult.Tables("MAIN").Columns.Add("S_DEV_PROC_TYPE")
        dsResult.Tables("MAIN").Rows(0)("S_DEV_PROC_TYPE") = S_DEV_PROC_TYPE.EditValue

        Dim params As Object = {dsResult, comdoc.getUploadPath}
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev", "Save3", params)
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
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub SearchLeftForm(ByVal ctrlContainer As Object)
        For Each ctrl As Object In ctrlContainer.Controls
            Debug.Print(ctrl.GetType.Name & "   /   " & ctrl.Name)
            If String.Equals(ctrl.GetType.Name, "CrmLeftForm", StringComparison.InvariantCultureIgnoreCase) Then
                ctrl.SearchData("")
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

        Gv2PopUp = New PopupBase
        Gv2PopUp.ItemAdd(Action.Other, "WG2_Download", "Download")
        Gv2PopUp.PopUpInit(Me, WG2)

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

        Common.DrawRowIndicator({GV1, GV3})

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


        'editor = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        'editor.CodeType = "YJIT.CodeService.CustomerPic"
        'editor.DisplayParams = "Code:#REQ_USR,Name:#TEL_NO"
        'editor.ValidateKeys = "KEY:#REQ_USR"
        'editor.DataParams = "Customer:@CUST_CD"
        'editor.KeepIntegrity = False
        'editor.AutoSuggestion = False
        'editor.MaxLength = "10"
        'editor.SearchPopup = "CodeMaster"
        'editor.CharacterCasing = CharacterCasing.Normal
        'GV3.Columns("REQ_USR").ColumnEdit = editor

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

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub
#End Region

#Region "=================Control Events==========="
    Private Sub CrmAsMgtDev3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CrmAsMgtDev3_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call InitData()

        FM_YMD.Text = DateAdd(DateInterval.Month, -1, Now).ToString("yyyyMMdd")
        FM_YMD.DefVal = FM_YMD.Text
        TO_YMD.Text = Now.ToString("yyyyMMdd")
        TO_YMD.DefVal = TO_YMD.Text

        Call InitGrid()
        Call initPopup()
        SaveControlValues(Me, {WG1, S_ROW_BEST, S_DEV_WORK_USR, S_PRIORITY, S_DEV_PROC_TYPE, REF_TIME, WORK_AREA, S_DEPT_LIST, S_YEAR})

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

        If Mid(ClientSessionInfo.AuthorizationType, 1, 1) <= 3 Then
            DEV_SCORE.Enabled = True
            DEV_SCORE_RMK.Enabled = True
        End If

        btnRefresh.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData("")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveData()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call DeleteData()
    End Sub

    Private Sub SEARCH_KEY_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SEARCH_KEY.PreviewKeyDown, USR_ID.PreviewKeyDown, SEQ.PreviewKeyDown, SCREEN.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Call SearchData("")
        End If
    End Sub

    Private Sub GV1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.Click
        Try
            If GV1.RowCount > 0 Then
                SearchDetail(GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO").ToString, GV1.GetRowCellValue(GV1.FocusedRowHandle, "SEQ").ToString, GV1.GetRowCellValue(GV1.FocusedRowHandle, "USR_ID").ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SearchDetail(ByVal MNGT_NO As String, ByVal SEQ As String, ByVal USR_ID As String)
        If comdoc Is Nothing Then comdoc = New ComDoc(WG2)

        Dim ds As DataSet = Me.ConvertToDataset
        ds.Tables("MAIN").Rows(0)("MNGT_NO") = MNGT_NO
        ds.Tables("MAIN").Rows(0)("SEQ") = SEQ
        ds.Tables("MAIN").Rows(0)("USR_ID") = USR_ID

        Dim retDs As DataSet = Nothing
        Try
            retDs = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev", "SearchInput", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Try
            Dim dr As DataRow = retDs.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                SearchData("")
                Exit Sub
            End If
            Me.BindToDataset(retDs, "Data")

            Call InitIcons()

            If REQ_SVC2.SelectedValue = "" Then
                SetReqsvc2(REQ_SVC.SelectedValue, 0)
                REQ_SVC2.SelectedValue = T_REQ_SVC2.Text
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

            If view.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString = "1" Or view.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString = "9" Then
                e.Appearance.BackColor = System.Drawing.Color.LightGray
                e.Appearance.ForeColor = System.Drawing.Color.DarkGray
            Else
                If view.GetRowCellValue(e.RowHandle, "PRIORITY").ToString = "0" Or view.GetRowCellValue(e.RowHandle, "PRIORITY").ToString = "1" Then
                    e.Appearance.BackColor = System.Drawing.Color.Lavender
                    'e.Appearance.ForeColor = System.Drawing.Color.Blue
                Else
                    If view.GetRowCellValue(e.RowHandle, "DELAY_YN").ToString = "Y" Then
                        e.Appearance.BackColor = System.Drawing.Color.LightYellow
                        e.Appearance.ForeColor = System.Drawing.Color.Black
                    End If
                End If
            End If

            If e.RowHandle = view.FocusedRowHandle Then
                e.Appearance.BackColor = Color.Green
                e.Appearance.ForeColor = Color.White
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
                    If view.GetRowCellValue(e.RowHandle, "SYS_ID").ToString.StartsWith("ELVIS") Then
                        e.Appearance.BackColor = System.Drawing.Color.Violet
                    End If
            End Select
            If view.GetRowCellValue(e.RowHandle, "PRIORITY").ToString = "0" Or view.GetRowCellValue(e.RowHandle, "PRIORITY").ToString = "1" Then
                e.Appearance.BackColor = System.Drawing.Color.Lavender
                'e.Appearance.ForeColor = System.Drawing.Color.Black
            End If

            If e.RowHandle = view.FocusedRowHandle Then
                e.Appearance.BackColor = Color.Green
                e.Appearance.ForeColor = Color.White
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub S_ROW_BEST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_ROW_BEST.SelectedIndexChanged
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

    Private Sub TO_YMD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TO_YMD.KeyDown
        If e.KeyCode = Keys.Enter Then
            S_DEV_PROC_TYPE.Focus()
        End If
    End Sub

    Private Sub S_DEPT_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_DEPT_LIST.KeyDown
        If e.KeyCode = Keys.Enter Then
            REF_TIME.Focus()
        End If
    End Sub

    Private Sub SEARCH_KEY_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SEARCH_KEY.KeyDown, USR_ID.KeyDown, SEQ.KeyDown, SCREEN.KeyDown
        'SEARCH_KEY
        If e.KeyCode = Keys.Enter Then
            SEARCH_KEY.Focus()
        End If
    End Sub

    Private Sub S_DEV_WORK_USR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            S_DEV_PROC_TYPE.Focus()
        End If
    End Sub

    Private Sub S_DEV_PROC_TYPE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_DEV_PROC_TYPE.KeyDown
        If e.KeyCode = Keys.Enter Then
            SEARCH_KEY.Focus()
        End If
    End Sub

    Private Sub CrmAsMgtDev2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Reset()
        For Each Control As Control In {MainSplit, ModifySplit, FileInputSplit}
            My.Settings.controlLocations.Add(Control.Name & "!" & CType(Control, DevExpress.XtraEditors.SplitContainerControl).SplitterPosition)
        Next
        My.Settings.Save()
    End Sub

    Private Sub PROC_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROC_TYPE.SelectedIndexChanged
        If PROC_TYPE.SelectedValue = "9" Then
            If CMPT_YMD.Text = "" Then
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
        ElseIf PROC_TYPE.SelectedValue = "1" Then
            If CMPT_YMD.Text = "" Then
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
        ElseIf PROC_TYPE.SelectedValue = "7" Then
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
        Call SearchReq("btnRefresh_Click")
    End Sub

    Private Sub GV3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV3.Click
        Try
            Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, FM_YMD, TO_YMD, S_ROW_BEST, REF_TIME, S_PRIORITY, S_DEV_WORK_USR, SCREEN, WG1, WG3, S_YEAR, S_SEARCH_TYPE, S_SEARCH_KEY})

            If GV3.RowCount = 0 Then Exit Sub
            If GV3.FocusedRowHandle < 0 Then Exit Sub

            MNGT_NO.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "MNGT_NO").ToString
            AS_REQ_YMD.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "REQ_YMD").ToString
            CONTENT.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "CONTENT").ToString
            RMK.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "RMK").ToString
            INS_USR_NM.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "INS_USR_NM").ToString
            HELP_WORK_USR.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "WORK_USR").ToString
            CUST_CD.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "CUST_CD").ToString
            CUST_NM.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "CUST_NM").ToString
            REQ_USR.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "REQ_USR").ToString
            TEL_NO.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "TEL_NO").ToString
            PRIORITY.SelectedValue = GV3.GetRowCellValue(GV3.FocusedRowHandle, "PRIORITY").ToString
            REQ_SVC.SelectedValue = GV3.GetRowCellValue(GV3.FocusedRowHandle, "REQ_SVC").ToString
            RANK_NM.Text = GV3.GetRowCellValue(GV3.FocusedRowHandle, "RANK_NM").ToString
            PRAR_YMD.Text = Now.ToString("yyyyMMdd")

            '20220701 손홍일 추가 배정하기전에 기본값 세팅
            Select Case ClientSessionInfo.UserID
                Case "HISON"
                    REQ_SVC.SelectedValue = "M" 'R:해운&항공 / E:해운 / D:항공 / C:회계 /V:정산 / P:EDI / M:창고 / I:운송 /Z :ETC / B:공통업무 / CM:CRM 
                    SetReqsvc2(REQ_SVC.SelectedValue, 1)
                    REQ_SVC2.SelectedValue = "M002"
                    REQ_SVC3.SelectedValue = "03"  '01: 설계 / 02:신규개발 / 03:기능분석 / 04:기능추가 / 05:기능변경 / 06:기능개선 / 07:오류수정 / 99:기타 / 54:월말수정
                    PROC_TYPE.SelectedValue = "7"  '0:미확인 / 7:처리중 / Z :개발완료 / 9:요청완료 / 1:완료 / 8:보류
                    WORK_USR.SelectedValue = ClientSessionInfo.UserID
                    RANK.SelectedValue = "C"
                Case "IHNAM"
                    REQ_SVC.SelectedValue = "M"
                    SetReqsvc2(REQ_SVC.SelectedValue, 1)
                    REQ_SVC2.SelectedValue = "M001"
                    REQ_SVC3.SelectedValue = "03"
                    PROC_TYPE.SelectedValue = "7"
                    WORK_USR.SelectedValue = ClientSessionInfo.UserID
                    RANK.SelectedValue = "C"
                Case "KTPARK", "SKKWON"
                    'REQ_SVC.SelectedValue = "M"
                    'SetReqsvc2(REQ_SVC.SelectedValue, 1)
                    'REQ_SVC2.SelectedValue = "M001"
                    'REQ_SVC3.SelectedValue = "03"
                    PROC_TYPE.SelectedValue = "0"
                    WORK_USR.SelectedValue = ClientSessionInfo.UserID
                    RANK.SelectedValue = "C"
            End Select


            If MNGT_NO.Text <> "" Then
                Dim dsRet As DataSet = Nothing
                dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsMgtDev", "SearchFileList", {MNGT_NO.Text})
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
            MsgBoxLocalized(ex.Message & "(GV3_Click)")
        End Try
    End Sub

    Private Sub CmdAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAssign.Click
        Call AssignData()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            If CDbl(REF_TIME.SelectedValue) <> 0 Then
                lblTime.Text = "Refresh : " & second & " 초"
            Else
                lblTime.Text = ""
            End If

            second = second + 1
            If second >= MaxInterval Then
                second = 0
                SearchReq("Timer2_Tick")
            End If
        Catch ex As Exception

        End Try
    End Sub

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

    Private Sub DEV_ERR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEV_ERR_YN.CheckedChanged
        If DEV_ERR_YN.Checked = True Then
            DEV_ERR_NM.SelectedValue = ClientSessionInfo.UserID
        End If
    End Sub

    Private Sub QC_TEST_YN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QC_TEST_YN.CheckedChanged
        If QC_TEST_YN.Checked Then
            QC_TESTER.SelectedValue = ClientSessionInfo.UserID
        Else
            QC_TESTER.SelectedValue = ""
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        RMK.Text = RMK.Text & vbCrLf & "-> "
        RMK.Select()
        RMK.SelectionStart = Len(RMK.Text) + 1
    End Sub

    Private Sub S_DEPT_LIST_EditValueChanged(sender As Object, e As EventArgs) Handles S_DEPT_LIST.EditValueChanged
        If Not String.IsNullOrEmpty(S_DEPT_LIST.EditValue) Then
            SetUserList(S_DEV_WORK_USR, S_DEPT_LIST.EditValue)
        Else
            SetUserList(S_DEV_WORK_USR, ClientSessionInfo.OrganizationCode)
        End If
    End Sub

#End Region


End Class