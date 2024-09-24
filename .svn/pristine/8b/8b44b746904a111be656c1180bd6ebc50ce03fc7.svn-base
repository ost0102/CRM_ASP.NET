Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI

Public Class HelpPswdReset
    Public Domain As String = ""
#Region "=================Data logic actions==========="
    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG1", "CrmCustomerMgt@SearchMain", True)
            YJSql.Params("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString.Trim, True)
            YJSql.Params("SVC_CD", drMAIN("S_SVC_CD").ToString.Trim, True)
            YJSql.Params("USE_YN", drMAIN("S_USE_YN").ToString.Trim, True)
            YJSql.Params("CUST_TYPE", drMAIN("S_CUST_TYPE").ToString.Trim, True)

            'Office's EDI Info Search
            YJSql.SqlBox("DomainList", "HelpPswdReset@GetDBInfo", True)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function



    Private Sub SetAppConfig()

        Dim DS1 As New DataSet
        Dim ServerIp As String = ""
        Dim ServerPort As String = ""
        Dim IdentityID As String = ""
        Dim EndPointName As String = "RemoteDeploymentServer"

        If FileIO.FileSystem.DirectoryExists(Application.StartupPath & "\EmailSend\") = False Then
            FileIO.FileSystem.CreateDirectory(Application.StartupPath & "\EmailSend\")
        End If

        If FileIO.FileSystem.DirectoryExists(Application.StartupPath & "\EmailSend\SendConfig\") = False Then
            FileIO.FileSystem.CreateDirectory(Application.StartupPath & "\EmailSend\SendConfig\")
        End If

        If FileIO.FileSystem.FileExists(Application.StartupPath & "\EmailSend\SendConfig\EmailSend.exe.config") = False Then
            FileIO.FileSystem.CopyFile(Application.StartupPath & "\YJIT.SC.App.exe.config", Application.StartupPath & "\EmailSend\SendConfig\EmailSend.exe.config")
        End If

        '  Dim DomainInfo As Dictionary(Of String, String) = Common.GetBaseInfo(Domain)
        ' 내부 관리 목적용
        Dim SubPath As String = Application.StartupPath & "\EmailSend\SendConfig\EmailSend.exe.config"
        '실제 읽는 파일
        Dim DefualtPath As String = Application.StartupPath & "\EmailSend\EmailSend.exe.config"

        Dim readPath As String = ""

        Dim SavedAppPath As String = "" ' "http://localhost:8081/WCF/"
        Dim Domain As String = ""

        If OfficeTree.Nodes.Count > 0 Then

            Domain = OfficeTree.Nodes(0)("OFFICE_CD").ToString
            SavedAppPath = OfficeTree.Nodes(0)("OFFICE_NM").ToString
        End If

        Dim S As String = ""

        If SavedAppPath = "" Then  
            MsgBoxLocalized("접속 서버 아이피 누락.")
            Exit Sub

        Else
            If SavedAppPath.Contains(":") Then
                Dim D() As String = SavedAppPath.Split(":")

                ServerIp = D(0)
                ServerPort = D(1)

            End If
        End If


        If Not FileIO.FileSystem.FileExists(DefualtPath) Then
            readPath = SubPath
        Else
            readPath = DefualtPath
        End If

        DS1.ReadXml(readPath)
        Dim dt As DataTable = DS1.Tables("EndPoint")
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("name").ToString.ToUpper = EndPointName.ToUpper Then
                dt.Rows(i)("address") = "http://" & ServerIp & ":" & ServerPort & "/WCF/BizService.svc"
                IdentityID = dt.Rows(i)("EndPoint_Id")
                Exit For
            End If
        Next
        dt = DS1.Tables("dns")
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("identity_Id").ToString.ToUpper = IdentityID Then
                dt.Rows(i)("Value") = ServerIp
                Exit For
            End If
        Next
        dt = DS1.Tables("Setting")
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("Name").ToString.ToUpper = "Domain".ToUpper Then
                dt.Rows(i)("Value") = Domain
                Continue For
            End If
            If dt.Rows(i)("Name").ToString.ToUpper = "SenderEmail".ToUpper Then
                dt.Rows(i)("Value") = ClientSessionInfo.Email
                Continue For
            End If
            If dt.Rows(i)("Name").ToString.ToUpper = "IDPswd".ToUpper Then
                dt.Rows(i)("Value") = ""
                Continue For
            End If
            If dt.Rows(i)("Name").ToString.ToUpper = "SavedAppPath".ToUpper Then
                dt.Rows(i)("Value") = SavedAppPath
                Continue For
            End If

            If dt.Rows(i)("Name").ToString.ToUpper = "USR_ID".ToUpper Then
                dt.Rows(i)("Value") = UserView.GetFocusedDataRow("USR_ID")
                Continue For
            End If
        Next

        'Dim MSG As String = ""
        Dim MSG1 As String = "Domain : " & Domain & vbCrLf
        Dim MSG2 As String = "Server : " & SavedAppPath & vbCrLf
        Dim MSG3 As String = "User ID : " & UserView.GetFocusedDataRow("USR_ID").ToString & vbCrLf
        Dim msg4 As String = "Sender Email :" & ClientSessionInfo.Email & vbCrLf

        Dim Result As String = "아래와 같은 정보로 초기화를 시작합니다. 진행 하시겠습니까? " & vbCrLf & vbCrLf & MSG1 & MSG2 & MSG3 & msg4 & vbCrLf & ""

        If ClientSessionInfo.Email = "" Then
            MsgBoxLocalized("송신자의 Email정보가 없으면 전송이 불가능 합니다.")
            Exit Sub
        End If

        If MsgBoxLocalized(Result, MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If


        DS1.WriteXml(DefualtPath)

        Process.Start(Application.StartupPath & "\EmailSend\EmailSend.exe")

    End Sub

    Public Sub PopUpOnAfterClick(ByVal DataRow As DataRow)
        Dim key As String = DataRow("Key") 

        Select Case key
            Case "Reset Password" 
                Try
                    SetAppConfig() 

                Catch ex As Exception
                    MsgBoxLocalized(ex.Message)
                End Try 
        End Select
    End Sub

    'Public Sub SearchData()
    '    Try

    '        Me.ClearView(UI.AppliedRangeTypes.Only, {WG1})

    '        Dim ds As DataSet = Me.ConvertToDataset
    '        ds.Tables("MAIN").Columns.Add("HelpPswdReset") 
    '        YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmCustomerMgt", "Search", ds, AddressOf SearchOnComplete)

    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message)
    '    End Try
    'End Sub

    'Private Sub SearchOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
    '    Try
    '        If IsNothing(e.Result) Then
    '            Throw New Exception("Try Again !")
    '        End If

    '        Dim ds As DataSet = e.Result
    '        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

    '        If dr("TrxCode") <> "Y" Then
    '            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Search", MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If 

    '        HelpCommon.DomainInfo = ds.Tables("Data.DomainList")

    '        SetDomainList(DomainList.Text)

    '        Me.BindToDataset(ds, "Data")
    '        GV1.BestFitColumns()

    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message)
    '    End Try

    'End Sub


    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet()

        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsMgt", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG1})
                Me.BindToDataset(dsRet, "Data")

                HelpCommon.DomainInfo = dsRet.Tables("Data.DomainList")
                SetDomainList(DomainList.Text)
                GV1.BestFitColumns()

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG1})
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




    Public Sub SetDomainList(ByVal FocusDomain As String)
        Dim TEMP As String = DomainList.Text
        DomainList.Properties.Items.Clear()
        For Each dr In HelpCommon.DomainInfo.Rows
            DomainList.Properties.Items.Add(dr("Domain"))
        Next
        DomainList.EditValue = TEMP
    End Sub


    Private Sub RefreshOfficeList(Optional serverInfo As String = "")

        Domain = DomainList.EditValue
        If Domain = "" Then Exit Sub
        If DbCheck.Checked = True Then
            Dim t As String = serverInfo
            Dim dt As DataTable = HelpCommon.ReadXml(Domain, HelpCommon.RootType.OfficeList)
            If dt.Columns.Count = 1 And serverInfo = "" Then
                t = dt.Rows(0)("OFFICE_NM").ToString() 
            ElseIf dt.Columns.Count = 0 Then
                MsgBoxLocalized("한번도 선택하지 않은 자료(Crm 거래처 코드)에 대해선 바로 조회(오피스,유저정보)가 불가능 합니다.")
                Exit Sub
            Else
                t = dt.Rows(0)("OFFICE_NM").ToString()
            End If
            Dim ParamDic As New Dictionary(Of String, String)
            ParamDic("DOMAIN") = Domain
            ParamDic("OFFICE_NM") = t

            Dim Dbdt As DataTable = HelpCommon.SetSql(Domain, "SystemSql@OfficeList", ParamDic, Nothing)
            OfficeTree.DataSource = Dbdt.DefaultView
            HelpCommon.WriteXml(Domain, HelpCommon.RootType.OfficeList, Dbdt)

        Else
            Dim dt As DataTable = HelpCommon.ReadXml(Domain, HelpCommon.RootType.OfficeList)
            If dt.Columns.Count = 0 Then
                If serverInfo = "" Then Exit Sub
                dt.Columns.Add("OFFICE_CD")
                dt.Columns.Add("OFFICE_NM")
                dt.Columns.Add("UPPER_OFFICE_CD")
                dt.Rows.Add({Domain, serverInfo, ""})
                HelpCommon.WriteXml(Domain, HelpCommon.RootType.OfficeList, dt)
            End If
            OfficeTree.DataSource = dt.DefaultView
        End If

        OfficeTree.ParentFieldName = "UPPER_OFFICE_CD"
        OfficeTree.KeyFieldName = "OFFICE_CD"
        OfficeTree.BestFitColumns()
        OfficeTree.ExpandAll()
    End Sub

     
    Private Sub RefreshUserList()
        Try
            If ShowningFlag = True Then Exit Sub
            If OfficeTree.FocusedNode Is Nothing Then Exit Sub
            Dim Office_cd As String = OfficeTree.FocusedNode.GetValue("OFFICE_CD")

            Dim dt As DataTable = Nothing
            If Domain = "" Then Exit Sub

            If DbCheck.Checked = True Then

                Dim ParamData As New Dictionary(Of String, String)
                Dim dr() As DataRow = HelpCommon.DomainInfo.Select("DOMAIN = '" & Domain & "'")
                If dr.Length > 0 Then
                    'ParamData("LOGINID") = dr(0)("SavedUserID").ToString
                    'ParamData("LOGINPASS") = dr(0)("SavedUserPwd").ToString
                End If
                dt = HelpCommon.SetSql(Domain, "SystemSql@UserList", ParamData, Nothing)

                HelpCommon.WriteXml(Domain, HelpCommon.RootType.UserList, dt)

            Else
                dt = HelpCommon.ReadXml(Domain, HelpCommon.RootType.UserList)

            End If



            If Not dt Is Nothing Then
                If SearchKey2.Text <> "" Then
                    Dim ListDt As DataTable = dt.Clone

                    Dim KeyList() As String = SearchKey2.Text.Split(",")
                    dt.CaseSensitive = True
                    For Each Key In KeyList
                        If Key = "" Then Exit For

                        For i = 0 To dt.Columns.Count - 1

                            Dim T As String = dt.Columns(i).DataType.FullName.ToUpper.ToString
                            Dim drs() As DataRow = Nothing
                            Dim colname As String = dt.Columns(i).ColumnName
                            If T.Contains("STRING") = True Then
                                drs = dt.Select(colname & " like '%" & Key & "%'")
                            Else
                                If IsNumeric(Key) Then
                                    drs = dt.Select(colname & " = '" & Key & "'")
                                End If
                            End If

                            If Not drs Is Nothing Then
                                For Each dr In drs
                                    ListDt.ImportRow(dr)
                                Next
                            End If
                        Next
                    Next

                    ListDt = ListDt.DefaultView.ToTable(True)
                    ViewControl.DataSource = ListDt.DefaultView
                Else
                    If dt.Columns.Contains("OFFICE_CD") Then
                        Dim drs() As DataRow = dt.Select("OFFICE_CD = '" & Office_cd & "'")

                        Dim ListDt As DataTable = dt.Clone

                        For Each dr In drs
                            ListDt.ImportRow(dr)
                        Next
                        ViewControl.DataSource = ListDt.DefaultView
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
  
    End Sub

#End Region
#Region "=================Control Events==========="



#End Region
#Region "=================Helper Methods==========="

#End Region

    Public Shared SpliteKey As Char = ChrW(35)
    Public Shared InI As Inifile
    Public Shared DbConn As DbConnet
    Private Shared _DomainInfo As DataTable

    Dim ShowningFlag As Boolean = False

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub HelpPswdReset_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

        S_SVC_CD.SelectedValue = "E"
         
        InI = New Inifile("List.Dat")
          
        OfficeTree.ParentFieldName = "UPPER_OFFICE_CD"
        OfficeTree.KeyFieldName = "OFFICE_CD"

        RefreshOfficeList()

        ShowningFlag = True

        Common.DrawRowIndicator(UserView)

        DomainList.Focus()

        RefreshUserList()

        Dim popup As New PopupBase
        popup.ItemAdd(Action.Other, "Reset Password", "Reset Password") ', ELVISMGT.Icon.Undo)
        popup.PopUpInit(Me, ViewControl)

        ShowningFlag = False

    End Sub

    Private Sub GV1_RowClick(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GV1.RowClick
        If GV1 Is Nothing Then Exit Sub
        If GV1.FocusedRowHandle < 0 Then Exit Sub
        Dim APP_IP_PORT As String = GV1.GetFocusedRowCellValue("APP_IP_PORT").ToString

        If APP_IP_PORT = "" Then
            MsgBoxLocalized("App Server의 정보를 알 수 없습니다.")
            Exit Sub  
        End If

        DomainList.Text = GV1.GetFocusedRowCellValue("DOMAIN")
        RefreshOfficeList(APP_IP_PORT)
    End Sub

    Private Sub BtnDomainSearch_Click(sender As System.Object, e As System.EventArgs) Handles BtnDomainSearch.Click
        RefreshOfficeList()
    End Sub
   
    Private Sub DomainList_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles DomainList.SelectedValueChanged, SearchKey2.SelectedValueChanged
        If ShowningFlag = True Then Exit Sub
        Domain = DomainList.EditValue
 
        '        ViewControl.DataSource = ListDt.DefaultView

        If Not ViewControl.DataSource Is Nothing Then
            CType(ViewControl.DataSource, System.Data.DataView).Table.Rows.Clear()
        End If

        If HelpCommon.DomainExist(Domain) = False Then Exit Sub


        Dim dt As DataTable = HelpCommon.ReadXml(Domain, HelpCommon.RootType.OfficeList)

        OfficeTree.DataSource = dt.DefaultView
        OfficeTree.BestFitColumns()
        OfficeTree.ExpandAll()


    End Sub
   
    Private Sub DomainList_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles DomainList.PreviewKeyDown, SearchKey2.PreviewKeyDown
        'If e.KeyCode = Keys.Enter Then
        '    RefreshOfficeList() 
        'End If
    End Sub

    Private Sub OfficeTree_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles OfficeTree.FocusedNodeChanged
        RefreshUserList()
    End Sub

    Private Sub SearchKey2_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs)

    End Sub

    Private Sub DomainList_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DomainList.KeyUp
        If e.KeyCode = Keys.Enter Then
            RefreshOfficeList()
            SearchKey2.Focus()
        End If
    End Sub

    Private Sub SearchKey2_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles SearchKey2.KeyUp
        If e.KeyCode = Keys.Enter Then
            RefreshUserList()
            SearchKey2.Focus()
            'ElseIf e.KeyCode = Keys.Tab Then
            '    RefreshUserList()
            '    If UserView.RowCount = 0 Then
            '        SearchKey2.Focus()
            '    Else
            '        UserView.Focus()
            '    End If
        End If
    End Sub
End Class