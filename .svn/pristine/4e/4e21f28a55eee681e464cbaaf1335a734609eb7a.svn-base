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


Public Class CrmAsMgtDev
    'Dim CustomTypeCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    'Dim GV_Flag As Boolean = False
    'Private tempRoot As String = Application.StartupPath & "\TMP_OUTPUT"
    'Protected filePath As String = String.Empty
    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    Dim second As Integer = 0
    Dim MaxInterval As Integer = 0
    Dim Gv1PopUp As New PopupBase
    Dim MainPopUp As New PopupBase
    'Dim CrmAsInput As CrmAsInputDev = Nothing

    Dim Gv1ChangeFlag As Boolean = False
    Dim ShownFlag As Boolean = True

    Private comdoc As ComDoc
    Dim UserInfoDt As DataTable = Nothing
    'Dim SavedEventList() As String = {"WG1_SEARCH", "WG1_DOUBLE_CLICK_DETAIL", "WG1_DOUBLE_CLICK_DETAIL_CASE1", "WG1_DOUBLE_CLICK_DETAIL_CASE2", "WG1_DOUBLE_CLICK_DETAIL_CASE3"}
    Dim ContolList As Dictionary(Of String, Object)
    Dim REQ_SVC2_dt As DataTable
#Region "=================Data logic actions==========="

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


    'Private Sub ResetLayout()
    '    For I = My.Settings.controlLocations.Count - 1 To 0 Step -1
    '        If My.Settings.controlLocations(I).StartsWith("DEFAULT") = False Then
    '            My.Settings.controlLocations.RemoveAt(I)
    '        End If
    '    Next
    '    My.Settings.Save()
    '    LoadUserSetting("DEFAULT")
    'End Sub
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
    'Private Sub SaveUserSetting(ByVal EventCode As String, ByVal propertyname As String)
    '    Dim dt As New DataTable
    '    dt.Columns.Add("KEY")
    '    dt.Columns.Add("INDEX")
    '    For i = 0 To My.Settings.controlLocations.Count - 1
    '        ' UserSettingDic(i) = My.Settings.controlLocations(i)
    '        dt.Rows.Add({My.Settings.controlLocations(i), i})
    '    Next
    '    '   Select Case EventCode
    '    ' Case "WG1_SEARCH"
    '    Dim SaveEventControlList() As Object = {MainSplit, ModifySplit, TeamSplit, FileInputSplit}
    '    For Each cntr In SaveEventControlList
    '        Dim key As String = EventCode & "!" & cntr.Name & "!" & propertyname & "!" & CallByName(cntr, propertyname, CallType.Get)
    '        Dim index As Integer = 0

    '        Dim DRs() As DataRow = dt.Select("KEY LIKE '" & key.Split("!")(0) & "!" & key.Split("!")(1) & "!" & key.Split("!")(2) & "%'")
    '        If DRs.Length > 0 Then
    '            index = DRs(0)("INDEX")
    '            My.Settings.controlLocations(index) = key
    '        Else
    '            My.Settings.controlLocations.Add(key)
    '        End If
    '    Next
    '    My.Settings.Save()
    '    'End Select
    'End Sub
    'Private Sub LoadUserSetting(ByVal key As String)
    '    'UserSettingDic.sele()
    '    Dim dt As New DataTable
    '    dt.Columns.Add("KEY")
    '    dt.Columns.Add("INDEX")
    '    For i = 0 To My.Settings.controlLocations.Count - 1
    '        ' UserSettingDic(i) = My.Settings.controlLocations(i)
    '        dt.Rows.Add({My.Settings.controlLocations(i), i})
    '    Next

    '    Dim DRs() As DataRow = dt.Select("KEY like '" & key.Split("!")(0) & "%'", "INDEX ASC")
    '    If DRs.Length > 0 Then
    '        For Each DR In DRs
    '            Dim v As String = DR("KEY").ToString
    '            Dim Info() As String = v.Split("!")
    '            '0. 이벤트 코드
    '            '1. 컨트롤명 
    '            '2. 프로퍼티(함수)
    '            '3. value
    '            Dim cntr As Object = ContolList(Info(1))
    '            Dim val As Object = Info(3)
    '            If val = "True" Then
    '                val = True
    '            ElseIf val = "False" Then
    '                val = False
    '            End If
    '            If Not cntr Is Nothing Then
    '                CallByName(cntr, Info(2), CallType.Let, val)
    '            End If

    '        Next
    '    End If
    '    'My.Settings.controlLocations.Clear()
    '    'For Each Control As Control In Me.Controls
    '    '    My.Settings.controlLocations.Add(Control.Name & "!" & Control.Location.X & "!" & Control.Location.Y)
    '    'Next
    '    'My.Settings.Save()
    '    'My.Settings.Reset() 
    'End Sub
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
                'dt.Columns("DEPT_CD").ColumnName = "CODE"
                dt.Columns("USR_ID").ColumnName = "CODE"
                dt.Columns("LOC_NM").ColumnName = "NAME"
            End If
            Dim dr As DataRow = dt.NewRow
            dr("CODE") = ""
            dr("NAME") = "--Select--"
            dt.Rows.InsertAt(dr, 0)

            sender.DataSource = dt
            'Dim bindingSourceProduct As BindingSource
            'bindingSourceProduct = New BindingSource()
            'bindingSourceProduct.DataSource = dt
            'sender.Properties.DataSource = bindingSourceProduct.DataSource
            'sender.Properties.ValueMember = "CODE"
            'sender.Properties.DisplayMember = "NAME"
            'sender.Properties.NullText = String.Empty
            'sender.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
            'sender.Properties.SeparatorChar = ";"

        Catch ex As Exception

        End Try
    End Sub
    Private Sub NewDetail()
        '추후 세션값
        'LoadUserSetting("WG1_DOUBLE_CLICK_DETAIL")
        'DEPT_AUTH_LIST.EditValue = ClientSessionInfo.OrganizationCode
        'DEPT_AUTH_LIST.EditValue = "02"
    End Sub
    Private Function GetConvertToDataSet(ByVal KEY As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            Select Case KEY
                Case "CrmUserInfo"
                    YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
                Case "Search"
                    YJSql.SqlBox("WG1", "CrmAsMgtDev@Search", True)
                    YJSql.Params("FM_YMD", drMAIN("FM_YMD").ToString.Trim, True)
                    YJSql.Params("TO_YMD", drMAIN("TO_YMD").ToString.Trim, True)
                    YJSql.Params("S_PROC_TYPE", S_DEV_PROC_TYPE.EditValue.ToString.Replace(";", "','").Replace(" ", ""), True)
                    YJSql.Params("S_SVC_CD", S_SVC_CD.EditValue.ToString.Replace(";", "','").Replace(" ", ""), True)
                    'YJSql.Params("S_MNGT_NO", drMAIN("S_MNGT_NO").ToString.Trim, True)
                    YJSql.Params("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString.Trim, True)
                    YJSql.Params("WORK_USR", S_DEV_WORK_USR.Text, True)
                    YJSql.Params("DEPT_CD", ClientSessionInfo.OrganizationCode)
                    Dim S_DEPT_LIST_VALUE As String = S_DEPT_LIST.EditValue.ToString.Replace(" ", "") & ";"
                    If S_DEPT_LIST_VALUE <> ";" Then
                        If S_DEPT_LIST_VALUE.Contains(ClientSessionInfo.OrganizationCode & ";") Then
                            YJSql.Blocks("ORGN_LIST", True)
                        End If
                        '  S_DEPT_LIST_VALUE = S_DEPT_LIST_VALUE.Substring(0, S_DEPT_LIST_VALUE.Length - 1)
                        S_DEPT_LIST_VALUE = S_DEPT_LIST_VALUE.Replace(ClientSessionInfo.OrganizationCode & ";", "")
                        If S_DEPT_LIST_VALUE <> "" And S_DEPT_LIST_VALUE <> ";" Then
                            'YJSql.Params("SHARE_DEPT_LIST", S_DEPT_LIST_VALUE)
                            YJSql.Blocks("SHARE_LIST", True)
                        End If
                    End If

                    If drMAIN("S_PRIORITY").ToString.Trim <> "" Then
                        If drMAIN("S_PRIORITY").ToString.Trim = "Y" Then
                            YJSql.Blocks("PRIORITY", drMAIN("S_PRIORITY").ToString.Trim, True)
                        End If
                    End If
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
        For I = DeptDt.Rows.Count - 1 To 0 Step -1
            If DeptDt.Rows(I)("CODE") <> ClientSessionInfo.OrganizationCode Then
                DeptDt.Rows.RemoveAt(I)
            End If
        Next
        DeptDt.Rows.Add("ETC", "타부서 요청사항")

        bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = DeptDt.Copy
        S_DEPT_LIST.Properties.DataSource = bindingSourceProduct.DataSource
        S_DEPT_LIST.Properties.ValueMember = "CODE"
        S_DEPT_LIST.Properties.DisplayMember = "NAME"
        S_DEPT_LIST.Properties.NullText = String.Empty
        S_DEPT_LIST.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_DEPT_LIST.Properties.SeparatorChar = ";"


        Timer1.Interval = 1000
        Timer1.Stop()

        comdoc = New ComDoc(WG2)


        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        '        DEPT_CD.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        '       DEPT_CD.DefVal = ClientSessionInfo.OrganizationCode 
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

        SetUserList(DEV_WORK_USR, "02")
        SetUserList(S_DEV_WORK_USR, "02")
        'DEV_WORK_USR
        SetUserList(TEST_USR_ID, "02")


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
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev", "Delete", Me.ConvertToDataset)

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

            Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, FM_YMD, TO_YMD, S_ROW_BEST, REF_TIME, S_PRIORITY, S_DEV_WORK_USR, SCREEN})

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Search", MessageBoxIcon.Warning)
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub SearchData(Optional ByVal LayoutChange As Boolean = True)

        If SearchValidate() = False Then Exit Sub
        If LayoutChange = True Then
            'LoadUserSetting("WG1_SEARCH")
        End If
        If FM_YMD.Text = "" Then
            If LayoutChange = True Then
                FM_YMD.Focus()
                MsgBoxLocalized("등록일자 시작일은 필수 입니다.")
                Exit Sub
            Else
                FM_YMD.Text = Now.ToString("yyyyMMdd")
            End If
        End If
        Dim dsRet As DataSet = GetConvertToDataSet("Search")
        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsMgtDev", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, FM_YMD, TO_YMD, S_ROW_BEST, REF_TIME, S_PRIORITY, S_DEV_WORK_USR, SCREEN})
                Me.BindToDataset(dsRet, "Data")

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Except, {SEARCH_KEY, FM_YMD, TO_YMD, S_ROW_BEST, REF_TIME, S_PRIORITY, S_DEV_WORK_USR, SCREEN})
                MsgBoxLocalized(drPairs("TrxMsg"))

                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            'If String.IsNullOrEmpty(S_COMN_CD.SelectedValue.ToString) Then
            '    If ErrControl Is Nothing Then ErrControl = S_COMN_CD
            '    ErrMsg &= "Please input the [Mapping Type]" & vbNewLine
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


    Private Sub NewData()

        ClearView(UI.AppliedRangeTypes.Except, {WG1, SEARCH_KEY, S_ROW_BEST, S_DEV_PROC_TYPE, REF_TIME, S_PRIORITY, S_DEV_WORK_USR, SCREEN})
    End Sub

    Public Sub SaveData()

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub


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

        Dim dsResult As DataSet
        Dim ds As DataSet = Nothing

        For i As Integer = 0 To GV2.RowCount - 1
            GV2.SetRowCellValue(i, "SEQ", comdoc.GetSeq(i, MNGT_NO.Text))
        Next
        comdoc.SetUploadPath(Split("CrmAsMgt", "/"))


        ds = GetConvertToDataSet("Search")
        ds.Merge(Me.ConvertToDataset)
        Dim params As Object = {ds, comdoc.getUploadPath}

        Dim byteUploadFiles As Dictionary(Of String, Object) = comdoc.byteUploadFiles
        Dim tempFolder As String = comdoc.getTempFolder
        Dim strFileName As String = ""

        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgtDev", "SaveInput", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            'Call SearchData()
            Me.BindToDataset(dsResult, "Data")
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Public Sub initPopup()
        Gv1PopUp = New PopupBase
        'Gv1PopUp.ItemAdd(Action.Addrow, "WG1_ADDROW", "Add row")
        'Gv1PopUp.ItemAdd(Action.DeleteRow, "WG1_DELETEROW", "Delete row")
        Gv1PopUp.ItemAdd(Action.NavigateTo, "ComDocumentMgt", "Document", True)
        Gv1PopUp.ItemAdd(Action.NavigateTo, "CrmCustomerMgt", "Customer Management")
        'Gv1PopUp.ItemAdd(Action.Other, "DEFAULT", "Reset Layout ", "OPTION") 
        'Gv1PopUp.ItemAdd(Action.Other, "Complete", "완료처리")
        Gv1PopUp.ItemAdd(Action.Excel, "WG1_EXCEL", "Excel Export", True)
        Gv1PopUp.PopUpInit(Me, WG1, "REQ_SVC", "CMPT_YMD")

        'MainPopUp = New PopupBase
        ''MainPopUp.ItemAdd(Action.GroupHeader, "OPTION", "설정", True)
        ''MainPopUp.ItemAdd(Action.Other, "SplitHorizontal", "가로/세로", "OPTION") 
        'Gv1PopUp.ItemAdd(Action.GroupHeader, "OPTION", "설정", True)
        ''Gv1PopUp.ItemAdd(Action.Other, "SplitHorizontal", "가로/세로", "OPTION")
        'Gv1PopUp.ItemAdd(Action.Other, "WG1_SEARCH", "Save Layout - Search 버튼시", "OPTION")
        'Gv1PopUp.ItemAdd(Action.Other, "WG1_DOUBLE_CLICK_DETAIL", "Save Layout - 입력 자료 조회시", "OPTION")
        'MainPopUp.PopUpInit(Me)
    End Sub
    Public Sub InitGrid()

        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        Dim dt As DataTable = New DataTable
        'dt.Columns.Add(New DataColumn("CODE", GetType(String)))
        'dt.Columns.Add(New DataColumn("NAME", GetType(String)))

        'AddNewRow(dt, "A", "설치업무")
        'AddNewRow(dt, "B", "공통업무")
        'AddNewRow(dt, "C", "ACCOUNT")
        'AddNewRow(dt, "D", "AIR")
        'AddNewRow(dt, "E", "OCEAN")
        'AddNewRow(dt, "F", "인사급여")
        'AddNewRow(dt, "G", "쿠리어")
        'AddNewRow(dt, "H", "통관업무")
        'AddNewRow(dt, "I", "운송업무")
        'AddNewRow(dt, "J", "대리점")
        'AddNewRow(dt, "K", "CFS")
        'AddNewRow(dt, "L", "EDMS")
        'AddNewRow(dt, "M", "WMS")
        'AddNewRow(dt, "N", "영업")
        'AddNewRow(dt, "O", "SCM")
        'AddNewRow(dt, "Z", "ETC")

        'editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        'editorCombo.DisplayMember = "NAME"
        'editorCombo.ValueMember = "CODE"
        'editorCombo.NullText = ""
        'editorCombo.DataSource = dt.Copy
        'editorCombo.ForceInitialize()
        'editorCombo.PopulateColumns()
        'editorCombo.Columns("CODE").Visible = False
        'editorCombo.ShowHeader = False
        'GV1.Columns("REQ_SVC").ColumnEdit = editorCombo

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
        'GV1.Columns("REQ_TYPE").ColumnEdit = editorCombo


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
    Dim NextFoucsList() As String = {"REQ_YMD", "REQ_HM", "DEPT_AUTH_LIST", "CUST_CD", "REQ_USR", "TEL_NO", "DEV_REQ_TYPE", "DEV_PRIORITY", "DEV_CONTENT", "PRAR_YMD", "CMPT_YMD", "AS_CONTENT", "DEV_WORK_USR", "DEV_PRAR_YMD", "DEV_TEST_USR", "DEV_CMPT_YMD"}
    Dim NextFocusDt As DataTable
    Private Sub CrmAsMgtDev_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call InitData()
        Call InitGrid()
        Call initPopup()
        SaveControlValues(Me, {WG1, FM_YMD, TO_YMD, S_ROW_BEST, S_DEV_WORK_USR, S_PRIORITY, S_DEV_PROC_TYPE, REF_TIME})

        ShownFlag = False
        If REF_TIME.SelectedValue = "0" Then
            Timer1.Stop()
        Else
            MaxInterval = 60 * CDbl(REF_TIME.SelectedValue)
            ' Timer1.Start()
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

    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveData()
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call DeleteData()
    End Sub

    Private Sub SEARCH_KEY_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SEARCH_KEY.PreviewKeyDown, USR_ID.PreviewKeyDown, SEQ.PreviewKeyDown, S_DEV_WORK_USR.PreviewKeyDown, SCREEN.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Call SearchData()
        End If
    End Sub

    Private Sub GV1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        Try
            '            CUST_CD.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub


    Private Sub GV1_FocusedColumnChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GV1.FocusedColumnChanged
        Try
            '  CUST_CD.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_CD").ToString
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GV1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.Click

        'Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        'Dim fTarget As Object = Nothing 

        If GV1.RowCount > 0 Then
            SearchDetail(GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO").ToString, GV1.GetRowCellValue(GV1.FocusedRowHandle, "SEQ").ToString, GV1.GetRowCellValue(GV1.FocusedRowHandle, "USR_ID").ToString)
        End If

        'If CrmAsInput Is Nothing Then
        '    CrmAsInput = New CrmAsInputDev
        'Else
        '     If CrmAsInput.IsDisposed = True Then
        '        CrmAsInput.Dispose()
        '        CrmAsInput = Nothing
        '        CrmAsInput = New CrmAsInputDev
        '    End If
        'End If 
        'CrmAsInput.StartPosition = FormStartPosition.CenterScreen
        'CrmAsInput.TopMost = True
        'CrmAsInput.Show()
        'If MNGT_NO = "" Then
        '    CrmAsInput.NewData()
        'Else
        '    CrmAsInput.MNGT_NO.Text = MNGT_NO
        '    CrmAsInput.SearchData()
        'End If 

    End Sub

    Public Sub SearchDetail(ByVal MNGT_NO As String, ByVal SEQ As String, ByVal USR_ID As String)

        Dim ds As DataSet = Me.ConvertToDataset
        ds.Tables("MAIN").Rows(0)("MNGT_NO") = MNGT_NO
        ds.Tables("MAIN").Rows(0)("SEQ") = SEQ
        ds.Tables("MAIN").Rows(0)("USR_ID") = USR_ID
        YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmAsMgtDev", "SearchInput", ds, AddressOf SearchDetailOnComplete)
    End Sub

    Private Sub SearchDetailOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If

            Dim retDs As DataSet = e.Result
            Dim dr As DataRow = retDs.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                SearchData()
                Exit Sub
            End If
            Me.BindToDataset(retDs, "Data")
            Call InitIcons()
            If REQ_SVC2.SelectedValue = "" Then
                SetReqsvc2(REQ_SVC.SelectedValue, 0)
                REQ_SVC2.SelectedValue = T_REQ_SVC2.Text
            End If


            '20180205 김성은 파일다운로드시 메모리 참조하는 부분이 있어서 초기화 처리
            comdoc.ClearFiles()

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
                Case "PROC_TYPE"
                    If view.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString = "0" Then
                        e.Appearance.BackColor = System.Drawing.Color.Salmon
                    End If
                Case "CUST_NM"
                    If view.GetRowCellValue(e.RowHandle, "SYS_ID").ToString = "ELVIS" Then
                        e.Appearance.BackColor = System.Drawing.Color.Red
                    End If
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub GV1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GV1.RowStyle

        Try
            If GV1.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString <> "3" AndAlso GV1.GetRowCellValue(e.RowHandle, "DELAY_YN").ToString = "Y" Then
                e.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub S_ROW_BEST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_ROW_BEST.SelectedIndexChanged
        'If S_ROW_BEST.SelectedValue = "Y" Then
        '    GV1.OptionsView.RowAutoHeight = True
        'Else
        GV1.OptionsView.RowAutoHeight = False
        'End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Try
            second = second + 1
            If second >= MaxInterval Then
                second = 0
                SearchData(False)
            End If
        Catch ex As Exception
            MsgBoxLocalized("Timer1_Tick " & ex.Message)
        End Try
    End Sub

    Private Sub REF_TIME_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REF_TIME.SelectedValueChanged
        If REF_TIME.SelectedValue = "0" Then
            Timer1.Stop()
        Else
            MaxInterval = 60 * CDbl(REF_TIME.SelectedValue)
            'Timer1.Start()
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

    Private Sub DEV_PRIORITY_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            DEV_CONTENT.Focus()
        End If
    End Sub

    Private Sub DEV_WORK_USR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DEV_WORK_USR.KeyDown
        If e.KeyCode = Keys.Enter Then
            PROC_TYPE.Focus()
        End If
    End Sub

    Private Sub DEV_TEST_USR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TEST_RESULT.Focus()
        End If
    End Sub


    Private Sub TO_YMD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TO_YMD.KeyDown
        If e.KeyCode = Keys.Enter Then
            S_DEV_PROC_TYPE.Focus()
        End If
        '
    End Sub
    Private Sub S_DEPT_LIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles S_DEPT_LIST.KeyDown
        If e.KeyCode = Keys.Enter Then
            S_DEV_WORK_USR.Focus()
        End If
    End Sub

    Private Sub SEARCH_KEY_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SEARCH_KEY.KeyDown, USR_ID.KeyDown, SEQ.KeyDown, S_DEV_WORK_USR.KeyDown, SCREEN.KeyDown
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
        'S_DEV_PROC_TYPE
        If e.KeyCode = Keys.Enter Then
            SEARCH_KEY.Focus()
        End If
    End Sub

    Private Sub CrmAsMgtDev_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Reset()
        For Each Control As Control In {MainSplit, ModifySplit, FileInputSplit}
            My.Settings.controlLocations.Add(Control.Name & "!" & CType(Control, DevExpress.XtraEditors.SplitContainerControl).SplitterPosition)
        Next
        My.Settings.Save()
    End Sub

    Private Sub PROC_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROC_TYPE.SelectedIndexChanged
        If USR_ID.Text = ClientSessionInfo.UserID Then
            If PROC_TYPE.SelectedValue = "3" Then
                If CMPT_YMD.Text = "" Then
                    CMPT_YMD.Text = Now.ToString("yyyyMMdd")
                    If DEV_CONTENT.Text = "" Then DEV_CONTENT.Text = "수정완료"
                End If
            End If
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


#End Region



End Class