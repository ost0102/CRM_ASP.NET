Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports System.Reflection
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Ribbon
Imports System.Globalization
Imports System.Threading
Imports DevExpress.XtraTabbedMdi
Imports YJIT.SC.UI
Imports System.Net
Imports YJIT.SC.App.MainForm
Imports Microsoft.AspNet.SignalR.Client.Hubs
Imports System.Threading.Tasks
Imports DevExpress.XtraBars.Alerter

Partial Public Class MainForm
    Implements IMainForm
    Dim UseMenuPanel As Boolean = True
    Private isFormLoaded As Boolean = False         'To avoid init menu 2 times
    Public ConfirmOnExit As Boolean = True
    '런타임 업데이트 적용 상수변수
    Private Const UseRuntimeUpdate As Boolean = True

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' 담당자 영문 상호 표시
        Me.Text = ClientSessionOfficeInfo.OfficeName

        'Login success and BizClient has been created
        RemoveHandler WCF.WCFBiz.Instance.AsyncRequestCountChanged, AddressOf onAsyncRequestCountChanged
        AddHandler WCF.WCFBiz.Instance.AsyncRequestCountChanged, AddressOf onAsyncRequestCountChanged
        'Handle application idle timeout, default is 6 hours (to let users get client updates)
        RemoveHandler WCF.WCFBiz.Instance.OnAppSessionRequestTimeout, AddressOf onAppSessionRequestTimeout
        AddHandler WCF.WCFBiz.Instance.OnAppSessionRequestTimeout, AddressOf onAppSessionRequestTimeout

        'Show Login user
        bsiLoginUserName.Caption = "User : " & ClientSessionInfo.LocalName
        bsiStartLoginTime.Caption = "Login time : " & ClientSessionInfo.StartLoginTime
        'bsiCodeBoxAutoSuggestion.Caption = "Auto Suggestion(F11) : " & IIf(YJIT.SC.UI.SCView.AppAutoSuggestion, "On", "Off")
        'Pending: Load details of user info and display to status or title bar



        'Set default tab windows mode
        Call setMDIMode()

        Call initSkinList()

        Call initRibbonLanguageList()

        Call initProgressBar()


        Dim OsName As String = My.Computer.Info.OSFullName.ToString.ToUpper
        If InStr(OsName, "WINDOWS 10") OrElse InStr(OsName, "WINDOWS 11") Then
            DevExpress.Utils.AppearanceObject.DefaultFont = New System.Drawing.Font("Segoe UI", 9)
        Else
            DevExpress.Utils.AppearanceObject.DefaultFont = New System.Drawing.Font("Tahoma", 9)
        End If

        '20231012 김성은 추후 제거 예정
        YJIT.SC.UI.SCView.AppAutoSuggestion = False
        Common.SaveUserSetting("CodeBoxAutoSuggestion", YJIT.SC.UI.SCView.AppAutoSuggestion.ToString)

        YJIT.SC.UI.SCView.MainFormInstance = Me
        isFormLoaded = True
    End Sub

    Private Sub MainForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call CreateMenuFromTable()

        Call initMenuList()

        Call initLeftPanel()

        Common.IMainForm = Me

        Common.SavedSessionDomain = "CRM.ELVIS.COM"
        '아이피 주소 관련 오류 때문에 막음 . 이병호
        'frmClient.RunClient(Common.SavedSessionDomain, ClientSessionInfo.UserID, ClientSessionInfo.LocalName)

        If ClientSessionInfo.OrganizationCode = "01" Then
            Call NavigateTo("CrmAsMgt_v4")
        End If

        ''20191101 김성은 알림 / 추후 오픈예정
        'Call ReadyRcvMessage()

        'Timer2.Start()
    End Sub
    Private Sub MainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        webviewPCKakao = Nothing
        End
    End Sub

    ''' <summary>
    ''' 2014.04.07 최초 작성 (작성자 : msKang)
    ''' SYS_MENU_MST 테이블을 읽어서 메뉴를 동적으로 생성하는 함수
    ''' 테이블을 읽는데 실패하면 소스에서 작성된 메뉴를 불러온다.
    ''' 메뉴 이름을 기본으로 보여주고 메뉴코드는 .Tag 속성에 저장된다.
    ''' 메뉴코드는 상위메뉴를 찾기위한 필수요소이므로 .Tag를 임의로 변경하면 메뉴구성이 제대로 수행되지 않는다.
    ''' 이 함수는 기존에 initMenuList() 함수를 대체해서 호출된다(MainForm_Shown, bbiRefresh_ItemClick)
    ''' Me.Localizer1.SetWordID 함수를 통해서 다국어 지원을 할 수 있도록 했음
    ''' MenuPosition 변수를 사용하여 리프레쉬 다음 부터 차례로 메뉴가 생성될 수 있도록 하였음
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CreateMenuFromTable()

        Dim dtUserMenu As DataTable = Nothing
        Dim dsUserMenu As DataSet = Nothing
        Dim MenuPosition As Integer = 1 '메뉴위치 refresh(0) 버튼 다음부터 넣어줌

        '메뉴테이블 검색
        Try
            dsUserMenu = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MainForm", "RetrieveMenu", {"YJITADMIN"})
            dtUserMenu = dsUserMenu.Tables("Data.Menu")

            ' ADMIN 일 경우 메뉴 설정 적용 안함
            If ClientSessionInfo.UserID = "ADMIN" Then
                Call initMenuList()
                Exit Sub
            End If

            '메뉴가 설정되어 있지 않으면 코딩된 메뉴를 보여줌
            If dtUserMenu Is Nothing OrElse dtUserMenu.Rows.Count = 0 Then
                Call initMenuList()
                Exit Sub
            End If
        Catch ex As Exception
            'MsgBox("Could not retrieve menu! Loading default menu...")
            '에러가 발생하면 코딩된 메뉴를 보여줌
            Call initMenuList()
            Exit Sub
        End Try

        Dim drPairs As DataRow
        drPairs = dsUserMenu.Tables("KEY_VALUE_PAIRS").Rows(0)

        ' 기존에 생성된 메뉴 삭제(Mdi Mode 및 Skin menu 제외)
        For i As Integer = barMainMenu.ItemLinks.Count - 1 To 0 Step -1
            Dim m As BarItemLink = barMainMenu.ItemLinks(i)
            If (TypeOf m.Item Is BarSubItem) AndAlso
                m.Item.Name <> "bsiMdiMode" AndAlso
                m.Item.Name <> "bsiSkinList" Then   'Mdi Mode 및 Skin menu 제외
                m.Item.Dispose()
                barMainMenu.RemoveLink(m)
                m.Dispose()
                m = Nothing
            End If
        Next

        If (dtUserMenu Is Nothing OrElse dtUserMenu.Rows.Count = 0) AndAlso ClientSessionInfo.AuthorizationType = "0" Then
            '현재 테이블만 있고 ROW가 없는 경우에도 전체 메뉴를 보여주기로 해서 일단은 막아둔 상태 - 2014.04.09
            '앞으로 문제가 없으면 삭제해도 상관없습니다.
            ''메뉴가 없고 SYSADMIN 권한인 경우 메뉴구성을 할 수 있는 메뉴만 보여준다.
            'Dim MenuGroup As BarSubItem
            'Dim itemMenu As BarButtonItem
            'Dim MenuName As String = ""
            'Dim link As BarItemLink = Nothing
            'Dim sublink As BarSubItemLink = Nothing

            ''SYSTEM Menu 생성
            'MenuGroup = New BarSubItem(barManager1, "SYSTEM")
            'MenuGroup.Name = "000001"
            'MenuGroup.Caption = "SYSTEM"
            'MenuGroup.Tag = "000001"
            'MenuGroup.Alignment = BarItemLinkAlignment.Left
            'Me.Localizer1.SetWordID(MenuGroup, "SYSTEM")
            ''Main Menu 추가
            'link = barMainMenu.InsertItem(barMainMenu.ItemLinks(MenuPosition), MenuGroup)
            'MenuPosition = MenuPosition + 1

            ''Menu 설정 Menu 생성
            'itemMenu = New BarButtonItem(barManager1, "MENU MANAGEMENT")
            'itemMenu.Name = "SYSMENUMGT"
            'itemMenu.Caption = "MENU MANAGEMENT"
            'itemMenu.Tag = "000002"
            'itemMenu.GroupIndex = 0
            'Me.Localizer1.SetWordID(itemMenu, "MENU MANAGEMENT")
            'CreateMenuLink(itemMenu, barMainMenu.ItemLinks, "000001")
            'AddHandler itemMenu.ItemClick, AddressOf onMenuItemClick

            ''Program 등록화면 Menu 생성
            'itemMenu = New BarButtonItem(barManager1, "PROGRAM MANAGEMENT")
            'itemMenu.Name = "MDMPROGRAMMGT"""
            'itemMenu.Caption = "PROGRAM MANAGEMENT"
            'itemMenu.Tag = "000003"
            'itemMenu.GroupIndex = 0
            'Me.Localizer1.SetWordID(itemMenu, "PROGRAM MANAGEMENT")
            'CreateMenuLink(itemMenu, barMainMenu.ItemLinks, "000001")
            'AddHandler itemMenu.ItemClick, AddressOf onMenuItemClick

        Else

            For Each dr As DataRow In dtUserMenu.Rows
                Dim MenuGroup As BarSubItem
                Dim itemMenu As BarButtonItem
                Dim MenuName As String = ""
                Dim link As BarItemLink = Nothing
                Dim sublink As BarSubItemLink = Nothing

                Dim groupLine As String = ""

                If dr("FORM_ID").ToString = "" Then
                    '서브 메뉴가 있는 경우 
                    MenuGroup = New BarSubItem(barManager1, dr("FORM_NM").ToString)
                    MenuGroup.Name = dr("MENU_CD").ToString
                    MenuGroup.Caption = dr("FORM_NM").ToString
                    MenuGroup.Tag = dr("MENU_CD").ToString
                    MenuGroup.Alignment = BarItemLinkAlignment.Left
                    Me.Localizer1.SetWordID(MenuGroup, dr("FORM_NM").ToString)

                    groupLine = dr("GRP_TAG").ToString

                    'Sub Menu인 경우
                    If dr("UPPER_MENU_CD").ToString <> "" Then
                        '서브메뉴 추가
                        For Each obj In barMainMenu.ItemLinks
                            If TypeOf obj Is BarSubItemLink Then
                                Dim subItem As BarSubItem = obj.item
                                If subItem.Tag = dr("UPPER_MENU_CD") Then
                                    sublink = subItem.AddItem(MenuGroup)

                                    If groupLine = "T" Then
                                        sublink.BeginGroup = True
                                    End If

                                End If
                            End If
                        Next
                    Else
                        'Main Menu 추가
                        link = barMainMenu.InsertItem(barMainMenu.ItemLinks(MenuPosition), MenuGroup)
                        MenuPosition = MenuPosition + 1
                    End If
                Else
                    '프로그램 메뉴인 경우
                    itemMenu = New BarButtonItem(barManager1, dr("FORM_NM").ToString)
                    itemMenu.Name = dr("FORM_ID").ToString.ToUpper
                    itemMenu.Caption = dr("FORM_NM").ToString
                    itemMenu.Tag = dr("MENU_CD").ToString

                    groupLine = dr("GRP_TAG").ToString

                    itemMenu.GroupIndex = 0
                    Me.Localizer1.SetWordID(itemMenu, dr("FORM_NM").ToString)
                    'Sub Menu인 경우
                    If dr("UPPER_MENU_CD").ToString <> "" Then
                        CreateMenuLink(itemMenu, barMainMenu.ItemLinks, dr("UPPER_MENU_CD").ToString, groupLine)
                    End If

                    ''HRM 이벤트 추가
                    'If itemMenu.Name = "INSALOGIN" Then
                    '    AddHandler itemMenu.ItemClick, AddressOf InsaLogIn_ItemClick
                    'Else
                    RemoveHandler itemMenu.ItemClick, AddressOf onMenuItemClick
                    AddHandler itemMenu.ItemClick, AddressOf onMenuItemClick
                    'End If
                End If
            Next

            '권한설정
            For Each obj In barMainMenu.ItemLinks
                If Not (TypeOf obj Is BarSubItemLink) Then Continue For
                Dim bsil As BarSubItemLink = obj
                'Harry Kim (Note): We distinguise the Menu group and other BarSubItem (s) by the Alignment (Menu groups are supposed to be on the left)
                If bsil.Item.Alignment = BarItemLinkAlignment.Right Then Continue For
                'Now we only process the top menu group BarSubItem (s)
                Call showHideMenu(bsil, ClientSessionInfo.UserPgmAuthInfo)
            Next

            Call beiLanguages_Changed()


        End If
    End Sub

    Private Sub TeamViewer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles TeamViewer.ItemClick
        Try
            'Harry:Try to close any instance of teamviewer to avoid wrong instance
            Dim proc = System.Diagnostics.Process.GetProcessesByName("TeamViewer")
            For i As Integer = 0 To proc.Count - 1
                proc(i).Kill()
            Next i
        Catch ex As Exception
            'Not handle this
        End Try

        'Start Teamviewer quicksuport instance
        Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
        process.StartInfo.FileName = Application.StartupPath & "\TeamViewerQS.exe"
        process.StartInfo.Verb = "Open"
        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
        process.Start()
    End Sub

    Private Sub ComUpdateLog_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        NavigateTo(e.Item.Name, NavigatedWindowModes.Popup)
    End Sub



#Region "================Main background cheat=============="
    Private _begingClosedForm As Form
    'This will be called whenever a MDI child is opened or closed
    Private Sub MainForm_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        If Me.MdiChildren.Count > 0 Then
            If MdiChildren(0) IsNot _begingClosedForm OrElse MdiChildren.Count > 1 Then
                'Hide the background image in case of MDi children exists
                PalBackground.Visible = False
                _begingClosedForm = Nothing
            Else
                PalBackground.Visible = True
            End If
        End If
        'This would check whether or not the last mdi child was closed
        If Me.ActiveMdiChild IsNot Nothing Then
            RemoveHandler ActiveMdiChild.FormClosed, AddressOf onMdiChildClosed
            AddHandler ActiveMdiChild.FormClosed, AddressOf onMdiChildClosed
        End If
    End Sub

    Private Sub onMdiChildClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        _begingClosedForm = sender
    End Sub
#End Region

#Region "========MDI functions related========="

    Private Sub initProgressBar()
        'Customize progress bar
        Me.pbarMainProgressBar.ProgressViewStyle = ProgressViewStyle.Solid
        Me.pbarMainProgressBar.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Default
        Me.pbarMainProgressBar.UseParentBackground = True
        Me.pbarMainProgressBar.Stopped = True
    End Sub

    Private Sub onAsyncRequestCountChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If WCF.WCFBiz.Instance.AsyncRequestCount > 0 Then
            Me.pbarMainProgressBar.Stopped = 0
            Me.Cursor = Cursors.WaitCursor
        Else
            Me.pbarMainProgressBar.Stopped = True
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub swapMDIMode(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUseTabbedMDI.ItemClick
        'Swap between MDI windows and Tabbed Windows
        If Common.UseTabbedMDI = "N" Then  'Tabbed Windows
            Common.UseTabbedMDI = "Y"
        Else     'MDI windows
            Common.UseTabbedMDI = "N"
        End If
        Call setMDIMode()
    End Sub

    Private Sub setMDIMode()
        If Common.UseTabbedMDI = "Y" Then
            xtraTabbedMdiManager1.MdiParent = Me
            xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader
            bbiMDICascade.Visibility = BarItemVisibility.Never
            bbiMDITileHorizontal.Visibility = BarItemVisibility.Never
            bbiMDITileVertical.Visibility = BarItemVisibility.Never
            bbiUseTabbedMDI.Down = True
        Else
            xtraTabbedMdiManager1.MdiParent = Nothing
            bbiMDICascade.Visibility = BarItemVisibility.Always
            bbiMDITileHorizontal.Visibility = BarItemVisibility.Always
            bbiMDITileVertical.Visibility = BarItemVisibility.Always
            bbiUseTabbedMDI.Down = False
        End If
    End Sub

    Private Sub bbiMDICascade_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMDICascade.ItemClick
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub bbiMDITileHorizontal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMDITileHorizontal.ItemClick
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub bbiMDITileVertical_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiMDITileVertical.ItemClick
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub bbiRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefresh.ItemClick
        'Synchronize again user session info
        Call Common.SynchronizeUserSessionInfo(ClientSessionInfo.UserID)


        '기존 메뉴생성
        Call initMenuList()

        '동적 메뉴생성 

        'Refresh current active Child
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim frm As Form = Me.ActiveMdiChild
            Dim sMenuName As String = frm.Name.ToUpper
            'If found, close it and create the form again
            frm.Close()

            Dim assContainer As Assembly = Nothing
            'Open the selected form as a new child
            Dim assExecuting As Assembly = Assembly.GetExecutingAssembly()
            'In that case, focus to opened form

            'Check if current assembly contains module definition
            If assExecuting.GetType(Common.APP_ROOT_NAMESPACE & "." & frm.Name) IsNot Nothing Then
                assContainer = assExecuting
            Else
                'Lookup through the Modules folder to locate module container
                If Common.ModuleManifest.ContainsKey(Common.APP_ROOT_NAMESPACE & "." & sMenuName) Then
                    'assContainer = Common.ModuleManifest(sID)
                    assContainer = Assembly.Load(System.IO.File.ReadAllBytes(Common.ModuleManifest(Common.APP_ROOT_NAMESPACE & "." & sMenuName)))       'This will reload assembly without locking it
                    'Update loaded module manifest
                    Common.ModuleLoadedManifest(Common.APP_ROOT_NAMESPACE & "." & sMenuName) = assContainer
                End If
            End If
            Try
                frm = assContainer.CreateInstance(Common.APP_ROOT_NAMESPACE & "." & sMenuName, True)
            Catch ex As Exception
                While (ex.InnerException IsNot Nothing)
                    ex = ex.InnerException
                End While
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.Localizer1.GetLocalizedString("Failed to load") & " " & sMenuName & "!" & ex.Message)
                Exit Sub
            End Try

            If frm IsNot Nothing AndAlso TypeOf frm Is System.Windows.Forms.Form Then
                CType(frm, Form).MdiParent = Me
                CType(frm, Form).Show()
            Else
                'Pending: Inform user of non-existance
            End If
            '이병호 : 기존에 언어 선택시 적용되는 부분을 refresh 했을때도 적용 하기 위해 함수따로 뺌.
            beiLanguages_Changed()
        End If
    End Sub

    Private Sub bbiLogout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLogout.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.Localizer1.GetLocalizedString("Are you sure want to logout?"), "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            frmClient.CloseClient()

            Me.Visible = False

            'Forge user to provide ID/password to connect to WCF Services
            Dim tmpWcfInfo As New WCF.SRBiz.BizServiceClient(WCF.WCFBiz.EndPointName)
            ' Login 1234

            Dim frmLogin As Object = Common.GetLoginFormIntance 'LoginForm.Instance
            If frmLogin Is Nothing Then frmLogin = Common.GetCreateLoginForm
            frmLogin.Show()

            ''20191101 김성은 알림
            'Try
            '    Call CloseAllMessage()
            'Catch ex As Exception
            'End Try

            Me.Close()
        End If
    End Sub

    Private nPerformActionCount As Integer
    Private Sub performActionOnChild(ByVal actType As YJIT.SC.UI.ButtonTypes, Optional ByVal ctrl As Control = Nothing)
        If ctrl Is Nothing Then 'First call
            nPerformActionCount = 0 'Reset counter
            'Determine if there is an active child
            If Me.ActiveMdiChild IsNot Nothing Then
                Dim frm As Form = Me.ActiveMdiChild
                'call to active child
                Call performActionOnChild(actType, frm)
            End If
        Else 'Recursive call
            If ctrl.Controls.Count > 0 Then
                For Each childCtrl In ctrl.Controls
                    If nPerformActionCount = 1 Then Exit Sub 'NOTE: Call only one time.
                    Call performActionOnChild(actType, childCtrl)
                Next
            Else
                If TypeOf ctrl Is SCControls.Button AndAlso CType(ctrl, SCControls.Button).ButtonType = actType Then
                    CType(ctrl, SCControls.Button).PerformClick()  'click button
                    nPerformActionCount += 1
                End If
            End If
        End If
    End Sub

    Private Sub bbiClearQueue_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClearQueue.ItemClick
        SC.WCF.WCFBiz.Instance.ClearAsyncTaskQueue()
    End Sub

    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ''20191101 김성은 알림 
        'Try
        '    Call CloseAllMessage()
        'Catch ex As Exception
        'End Try

        'If user want to quit application, must close only one LoginForm instance (if hidden), then application will shutdown
        'Login 1234
        frmClient.CloseClient()
        If Common.GetLoginFormIntance.Instance IsNot Nothing AndAlso Common.GetLoginFormIntance.Instance.Visible = False Then
            Common.GetLoginFormIntance.Instance.Close()
        End If
    End Sub

    Private Sub bbiBugReport_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiBugReport.ItemClick
        Call Common.ShowBugReporterClient()
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.ConfirmOnExit = False Then
            e.Cancel = False
        ElseIf Me.Visible AndAlso MsgBoxSC("Do you want to quit application?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub onAppSessionRequestTimeout(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Common.IsDeploymentMode AndAlso
        '    MsgBoxSC("Your session has been timeout! Restart now?", MessageBoxButtons.OK) = MsgBoxResult.Ok Then 'No other choice than restart
        '===================================RESTART APPLICATION FOR LIVE UPDATE================================'

        For Each frm As Object In Me.MdiChildren
            frm.DataState = DataStates.Retrieved
            frm.Close()
            frm.Dispose()
        Next

        'Get application ID
        Dim sAppID As String
        Try
            Dim tmp() As String = Application.StartupPath.Split("\")
            sAppID = tmp(tmp.Length - 1)
            If sAppID = "" Then sAppID = tmp(tmp.Length - 2)
        Catch ex As Exception
            MsgBoxSC("Failed to get application identity!" & ex.Message)
            Exit Sub
        End Try

        'Get full application URI 
        Dim sAppFullPath As String = System.Environment.CurrentDirectory & "\"
        If Not sAppFullPath.EndsWith("\") Then sAppFullPath &= "\"
        sAppFullPath &= sAppID & ".exe"

        Try
            'Start entry application again
            System.Diagnostics.Process.Start(sAppFullPath)
        Catch ex As Exception
            MsgBoxSC("Could not start " & sAppFullPath & "!" & vbNewLine & "Please start yourself!")
        Finally
            'Close current running instance
            Me.ConfirmOnExit = False
            Application.Exit()
        End Try
        '======================================================================================================='
        'End If
    End Sub
#End Region

#Region "==========Menu open related=========="
    ''' <summary>
    ''' Recursively check the show/hide status of menu and assign the click event handler if user has right
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <param name="dtAuth"></param>
    ''' <remarks></remarks>
    Private Function showHideMenu(ByVal obj As Object, ByVal dtAuth As DataTable) As Boolean
        Dim bVisible As Boolean = False

        If TypeOf obj Is BarButtonItemLink Then
            'This is end-point menu, we must decide show/hide it and if show, add the click handler
            Dim bbi As BarButtonItem = obj.Item
            '이병호 추가. WIZARD 오픈 해야 할경우.
            If Common.OpenWizard = False Then
                If ClientSessionInfo.UserID = "ADMIN" Then
                    'Special user -> Show all menu items
                    bVisible = True
                Else
                    Dim sName As String = bbi.Name
                    If dtAuth IsNot Nothing Then
                        For Each dr As DataRow In dtAuth.Rows
                            If dr("PGM_ID").ToString.ToUpper = sName.ToUpper Then
                                bVisible = True
                                Exit For
                            End If
                        Next
                    End If
                End If
            End If
            If bVisible Then
                bbi.Visibility = BarItemVisibility.Always
                'We auto adding the click event handler
                'HRM 외에만 이벤트 추가
                If bbi.Name = "INSALOGIN" Then
                Else
                    RemoveHandler bbi.ItemClick, AddressOf onMenuItemClick
                    AddHandler bbi.ItemClick, AddressOf onMenuItemClick
                End If
                If bbi.Name.ToUpper = "WIZARD" Then
                    bbi.Visibility = BarItemVisibility.Never
                End If
            Else
                bbi.Visibility = BarItemVisibility.Never
                '초기 셋팅시 위자드 화면만 열어줌
                If Common.OpenWizard AndAlso bbi.Name.ToUpper = "WIZARD" Then
                    bbi.Visibility = BarItemVisibility.Always
                    'HRM 외에만 이벤트 추가
                    If bbi.Name = "INSALOGIN" Then
                    Else
                        RemoveHandler bbi.ItemClick, AddressOf onMenuItemClick
                        AddHandler bbi.ItemClick, AddressOf onMenuItemClick
                    End If
                    bVisible = True
                End If
            End If

            Return bVisible

        ElseIf TypeOf obj Is BarSubItemLink Then
            'This is a sub menu group,we recursively call
            Dim bsi As BarSubItem = obj.Item
            For Each obj1 In bsi.ItemLinks
                If showHideMenu(obj1, dtAuth) = True Then
                    bVisible = True
                End If
            Next
            'If one of its children menu is visible => it will be visible
            If bVisible Then
                bsi.Visibility = BarItemVisibility.Always
            Else
                bsi.Visibility = BarItemVisibility.Never
            End If
            Return bVisible
        Else
            'Currently do not process other item types
            Try
                obj.Visibility = BarItemVisibility.Never
            Catch ex As Exception
                'Do nothing
            End Try
            Return False    '-> should invisible
        End If
    End Function

    Private Sub initMenuList()
        For Each obj In barMainMenu.ItemLinks
            If Not (TypeOf obj Is BarSubItemLink) Then Continue For
            Dim bsil As BarSubItemLink = obj
            'Harry Kim (Note): We distinguise the Menu group and other BarSubItem (s) by the Alignment (Menu groups are supposed to be on the left)
            If bsil.Item.Alignment = BarItemLinkAlignment.Right Then Continue For
            'Now we only process the top menu group BarSubItem (s)
            Call showHideMenu(bsil, ClientSessionInfo.UserPgmAuthInfo)
        Next
    End Sub

    Private Sub onMenuItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        NavigateTo(e.Item.Name)
    End Sub

    ''' <summary>
    ''' 2014.04.07 최초 작성 (작성자 : msKang)
    ''' SYS_MENU_MST 테이블을 읽어서 메뉴를 동적으로 생성하는 함수
    ''' 테이블을 읽는데 실패하면 소스에서 작성된 메뉴를 불러온다.
    ''' 메뉴 이름을 기본으로 보여주고 메뉴코드는 .Tag 속성에 저장된다.
    ''' 메뉴코드는 상위메뉴를 찾기위한 필수요소이므로 .Tag를 임의로 변경하면 메뉴구성이 제대로 수행되지 않는다.
    ''' 이 함수는 기존에 initMenuList() 함수를 대체해서 호출된다(MainForm_Shown, bbiRefresh_ItemClick)
    ''' Me.Localizer1.SetWordID 함수를 통해서 다국어 지원을 할 수 있도록 했음
    ''' MenuPosition 변수를 사용하여 리프레쉬 다음 부터 차례로 메뉴가 생성될 수 있도록 하였음
    ''' </summary>
    ''' <remarks></remarks>


    Private Sub CreateMenuLink(ByVal item As BarButtonItem, ByVal link As BarItemLinkCollection, ByVal upper_menu As String, ByVal groupLine As String)
        'Sub Item만 체크해서 해당 Sub Item이 상위메뉴이면 해당 메뉴의 Link를 생성시키고
        '아니면 해당 Sub Item의 하위 Link를 검사한다.
        For Each obj In link
            Dim blink As BarButtonItemLink

            If TypeOf obj Is BarSubItemLink Then
                Dim subItem As BarSubItem = obj.Item

                If obj.Item.Tag = upper_menu Then
                    '메뉴추가
                    blink = subItem.AddItem(item)

                    If groupLine = "T" Then
                        blink.BeginGroup = True
                    End If

                Else
                    '하위 Link 검색
                    CreateMenuLink(item, subItem.ItemLinks, upper_menu, groupLine)
                End If
            End If
        Next
    End Sub

#End Region

#Region "========Skin related========"
    Private Sub initSkinList()

        'Register additional skins from Devexpress
        DevExpress.Skins.SkinManager.Default.RegisterAssembly(Assembly.GetAssembly(GetType(DevExpress.UserSkins.OfficeSkins)))
        DevExpress.Skins.SkinManager.Default.RegisterAssembly(Assembly.GetAssembly(GetType(DevExpress.UserSkins.BonusSkins)))

        For Each skin As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins

            Dim item As BarCheckItem = Me.barManager1.Items.CreateCheckItem(skin.SkinName, False)
            item.Tag = skin.SkinName
            RemoveHandler item.ItemClick, AddressOf onPaintSkinClick
            AddHandler item.ItemClick, AddressOf onPaintSkinClick
            bsiSkinList.ItemLinks.Add(item)
        Next skin
        'AddHandler Me.barManager1.ItemClick, AddressOf barManager_ItemClick

        'Set user settings's skin
        If Not String.IsNullOrEmpty(Common.UserSkinID) Then
            Try
                DefaultLookAndFeel1.LookAndFeel.SetSkinStyle(Common.UserSkinID)
            Catch ex As Exception
                'Can not apply previous saved skin
            End Try
        Else
            Common.UserSkinID = DefaultLookAndFeel1.LookAndFeel.ActiveSkinName
        End If
    End Sub

    'Private Sub barManager_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    '    Dim subMenu As BarSubItem = TryCast(e.Item, BarSubItem)
    '    If Not subMenu Is Nothing Then Return
    '    'MessageBox.Show("Item '" & e.Item.Caption & "' has been clicked")

    '    DefaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Caption)
    '    Common.UserSkinID = DefaultLookAndFeel1.LookAndFeel.ActiveSkinName
    'End Sub

    Private Sub onPaintSkinClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        DefaultLookAndFeel1.LookAndFeel.SetSkinStyle(e.Item.Tag.ToString())
        Common.UserSkinID = DefaultLookAndFeel1.LookAndFeel.ActiveSkinName
    End Sub

    Private Sub bsiSkinList_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsiSkinList.Popup
        For Each link As BarItemLink In bsiSkinList.ItemLinks
            CType(link.Item, BarCheckItem).Checked = link.Item.Caption = DefaultLookAndFeel1.LookAndFeel.ActiveSkinName
        Next link
    End Sub

#End Region

#Region "============Language/Locale/Culture related============"
    Private Sub beiLanguages_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beiLanguages.EditValueChanged
        beiLanguages_Changed()
    End Sub

    Private Sub beiLanguages_Changed()
        Common.UserLanguageID = beiLanguages.EditValue
        'Process language changed
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(beiLanguages.EditValue.ToString)
        'Set language for it self
        ApplyLanguageSettingToForm(Me)
        'Set language for its children
        For Each frm As Object In Me.MdiChildren
            ApplyLanguageSettingToForm(frm)
        Next
    End Sub

    Private Sub initRibbonLanguageList()
        riicLanguages.Items.Add(New ImageComboBoxItem("--Select--", "", -1))
        For Each culture As CultureInfo In CultureInfo.GetCultures(CultureTypes.AllCultures)
            'list only supported language
            If culture.Name = "ja-JP" OrElse culture.Name = "en-US" OrElse culture.Name = "ko-KR" _
                OrElse culture.Name = "zh-CN" OrElse culture.Name = "vi-VN" OrElse culture.Name = "zh-HK" Then
                riicLanguages.Items.Add(New ImageComboBoxItem(culture.NativeName, culture.Name, -1))
            End If
        Next
        beiLanguages.EditValue = Common.UserLanguageID
    End Sub
#End Region

#Region "================Public API=============="
    ''' <summary>
    ''' Navigate to a child window (A)
    ''' </summary>
    ''' <param name="sID">Container ModuleId and ClassId in form of [ModuleId_]ClassId</param>
    ''' <returns>Handle of opened child window</returns>
    ''' <remarks>classId can not contains the _ character</remarks>
    Public Function NavigateTo(ByVal SrcID As String, Optional ByVal targetMode As NavigatedWindowModes = NavigatedWindowModes.MDIWindow,
                               Optional ByVal showImmediately As Boolean = True) As Object Implements IMainForm.NavigateTo
        Dim stopWatch As Stopwatch = New Stopwatch()
        stopWatch.Start()


        Dim sID As String = ""

        Dim pgmOption As String = ""
        'Dim pos As Integer = InStr(SrcID, "_")

        'If pos = 0 Then
        '    ' 사업장별로 소스 분기 부분
        '    sID = GetOfficeFormId(SrcID)
        'Else
        '    sID = Mid(SrcID, 1, pos - 1)
        '    pgmOption = Mid(SrcID, pos + 1, Len(SrcID) - pos + 1)
        'End If

        sID = SrcID

        Dim sOriginID As String = sID   'Without capitalization
        sID = sID.ToUpper

        If showImmediately Then
            For Each frm As Object In Me.MdiChildren
                If String.Equals(frm.GetType.Name, sID, StringComparison.InvariantCultureIgnoreCase) Then
                    frm.Focus()
                    Return frm
                End If
            Next
        End If

        'Open the selected form as a new child
        Dim assContainer As Assembly = Nothing
        Dim assExecuting As Assembly = Assembly.GetExecutingAssembly()
        Dim frmView As Object = Nothing
        Try
            'Wizard 오픈 상태 일경우( customs 초기 셋팅 )
            If Not Common.OpenWizard Then
                'Check if current assembly contains module definition
                If assExecuting.GetType(Common.APP_ROOT_NAMESPACE & "." & sOriginID) IsNot Nothing Then
                    assContainer = assExecuting
                Else
                    If Common.IsDeploymentMode = True Then
                        If Not UseRuntimeUpdate Then
                            If Common.UseRuntimeUpdate = "Y" Then 'Harry (20150725): Perform Runtime Update first, then load dll
                                'Call Common.UR_ProcessRuntimeUpdateFile(Common.ModuleManifest(Common.APP_ROOT_NAMESPACE & "." & sID))
                                Call RuntimeUpdate.UR_ProcessRuntimeUpdateFile(Common.ModuleManifest(Common.APP_ROOT_NAMESPACE & "." & sID))
                                assContainer = Assembly.Load(System.IO.File.ReadAllBytes(Common.ModuleManifest(Common.APP_ROOT_NAMESPACE & "." & sID)))       'This will reload assembly without locking it
                            Else
                                assContainer = ModuleLoadedManifest(Common.APP_ROOT_NAMESPACE & "." & sID)                                                    'Refer to yet loaded assembly
                            End If
                        Else
                            'Dll Update - RunTime Update 수정 버전 - mskang 2017.09.01
                            If Common.IsDeploymentMode = True Then 'AndAlso Common.UseRuntimeUpdate = "Y" Then
                                Dim sFileID As String = ""
                                If Common.ModuleManifest.ContainsKey(Common.APP_ROOT_NAMESPACE & "." & sID) Then
                                    '파일은 있는데 Localmanifest.inf 파일에 없는 경우에는 업데이트를 수행한다.
                                    sFileID = Common.ModuleManifest(Common.APP_ROOT_NAMESPACE & "." & sID)
                                    Dim chkLocalManifest As String = sFileID.Replace(System.Windows.Forms.Application.StartupPath, "")
                                    Dim bExist As Boolean = False
                                    If chkLocalManifest.StartsWith("\") Then
                                        chkLocalManifest = chkLocalManifest.Substring(1)
                                    End If

                                    chkLocalManifest = chkLocalManifest.Replace("\", "/")

                                    For i = 0 To RU_LocalManifest.Count - 1
                                        If InStr(RU_LocalManifest(i).ToString, chkLocalManifest) Then
                                            bExist = True
                                            Exit For
                                        End If
                                    Next

                                    If Not bExist Then RuntimeUpdate.UR_ProcessRuntimeUpdateFile(sFileID)
                                Else
                                    '파일이 없는 경우 다운로드 받음
                                    '해당 클래스에 해당하는 파일 명을 가져온다.
                                    Try
                                        Dim dsRet As DataSet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MainForm", "RetrieveDLLFileName", {sID.ToUpper})
                                        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
                                        If drPairs("TrxCode") = "Y" Then
                                            Dim dtDLL As DataTable = dsRet.Tables("Data.DLL_NAME")

                                            If dtDLL IsNot Nothing AndAlso dtDLL.Rows.Count > 0 Then
                                                sFileID = dtDLL.Rows(0)("DLL_NAME").ToString
                                            End If
                                        End If
                                    Catch ex As Exception

                                    End Try
                                    If sFileID = "" Then sFileID = sID & ".DLL"
                                    sFileID = RuntimeUpdate.UR_ProcessRuntimeUpdateFile(sFileID)
                                End If

                                '다운로드를 새로운 Thread를 생성해서 처리하는 방식으로 인해서 old version dll이 호출되는 문제가 있어서
                                '다시 호출할 수 있도록 Module을 재생성함
                                '-------------------------------------------------------------------------------------
                                'Load module/plugin, then create manifest
                                '-------------------------------------------------------------------------------------
                                If sFileID <> "" Then
                                    Dim ass As Assembly = Assembly.Load(System.IO.File.ReadAllBytes(sFileID))      'This method will not lock assembly file
                                    For Each tp As Type In ass.GetTypes()
                                        ModuleManifest(APP_ROOT_NAMESPACE & "." & tp.Name.ToUpper) = sFileID      'Store assembly file path
                                        ModuleLoadedManifest(APP_ROOT_NAMESPACE & "." & tp.Name.ToUpper) = ass     'Store assembly loaded reference
                                    Next
                                End If
                            End If
                        End If
                        assContainer = ModuleLoadedManifest(Common.APP_ROOT_NAMESPACE & "." & sID)                                                    'Refer to yet loaded assembly
                    Else
                        assContainer = Assembly.Load(System.IO.File.ReadAllBytes(Common.ModuleManifest(Common.APP_ROOT_NAMESPACE & "." & sID)))       'This will reload assembly without locking it
                    End If
                End If

                If assContainer Is Nothing Then
                    Throw New Exception(Me.Localizer1.GetLocalizedString("Could not locate module:") & Common.APP_ROOT_NAMESPACE & sID)
                End If
            Else
                assContainer = Assembly.Load(System.IO.File.ReadAllBytes(Common.ModuleManifest(Common.APP_ROOT_NAMESPACE & "." & sID)))
            End If
            frmView = assContainer.CreateInstance(Common.APP_ROOT_NAMESPACE & "." & sID, True)
        Catch ex As Exception
            While (ex.InnerException IsNot Nothing)
                ex = ex.InnerException
            End While
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.Localizer1.GetLocalizedString("Failed to load") & " " & sID & "!" & ex.Message)
            Return Nothing
        End Try

        If frmView IsNot Nothing AndAlso TypeOf frmView Is System.Windows.Forms.Form Then
            'Set display language
            If beiLanguages.EditValue & "" <> "" Then
                RemoveHandler CType(frmView, Form).Load, AddressOf onTargetFormLoad
                AddHandler CType(frmView, Form).Load, AddressOf onTargetFormLoad
            End If

            Select Case targetMode
                Case NavigatedWindowModes.MDIWindow
                    CType(frmView, Form).MdiParent = Me
                    If showImmediately Then CType(frmView, Form).Show()
                Case NavigatedWindowModes.Dialog
                    CType(frmView, Form).StartPosition = FormStartPosition.CenterScreen
                    If showImmediately Then CType(frmView, Form).ShowDialog()
                Case NavigatedWindowModes.Popup
                    CType(frmView, Form).StartPosition = FormStartPosition.CenterScreen
                    If showImmediately Then CType(frmView, Form).Show()
            End Select
        Else
            'Pending: Inform user of non-existance
        End If


        Select Case pgmOption
            Case "SEA"
                'frmView.MBL_NO.text = "SEA"
        End Select

        stopWatch.Stop()
        bsiLodingTime.Caption = "Loading Seconds : " & stopWatch.Elapsed.Seconds & "." & stopWatch.Elapsed.Milliseconds

        Return frmView

    End Function

    Private Sub onTargetFormLoad(ByVal sender As Object, ByVal e As EventArgs)
        Call ApplyLanguageSettingToForm(sender)
    End Sub

    Public Sub ApplyLanguageSettingToForm(ByVal frm As Object) Implements UI.IMainForm.ApplyLanguageSettingToForm
        Try
            For Each field As FieldInfo In frm.GetType.GetFields(BindingFlags.NonPublic Or BindingFlags.Instance)
                If field.FieldType Is GetType(YJIT.SC.UI.SCControls.Localizer) Then
                    Dim fieldValue As Object = field.GetValue(frm)
                    'Set the "ResourceManager" property on the localizer object
                    fieldValue.ResourceManager = My.Resources.ResourceManager
                    'Call the "UpdateResourceStrings" on the localizer object
                    fieldValue.UpdateResourceStrings()
                End If
            Next
        Catch ex As Exception
            'DevExpress.XtraEditors.XtraMessageBox.Show("Could not change language to " & beiLanguages.EditValue)
        End Try
    End Sub

    ''' <summary>
    ''' Access to localizer object if have
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This is same purpose as SCView.Localizer property</remarks>
    Public ReadOnly Property Localizer As YJIT.SC.UI.SCControls.Localizer
        Get
            For Each field As FieldInfo In Me.GetType.GetFields(BindingFlags.NonPublic Or BindingFlags.Instance)
                If field.FieldType Is GetType(YJIT.SC.UI.SCControls.Localizer) Then
                    Return field.GetValue(Me)
                End If
            Next
            Return Nothing
        End Get
    End Property

#End Region


    'Process the system function key
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Try
            Select Case keyData
                Case Keys.F5    'Refresh
                    Call bbiRefresh_ItemClick(Me, Nothing)
                'Case Keys.F11
                '    'Turn on, off the CodeBox's Auto Suggestion
                '    YJIT.SC.UI.SCView.AppAutoSuggestion = Not YJIT.SC.UI.SCView.AppAutoSuggestion
                '    bsiCodeBoxAutoSuggestion.Caption = "Auto Suggestion(F11):" & IIf(YJIT.SC.UI.SCView.AppAutoSuggestion, "On", "Off")
                Case Keys.F3
                    Call performActionOnChild(ButtonTypes.Save)
                Case Keys.F6
                    Call performActionOnChild(ButtonTypes.Print)
                    'Case Keys.F4
                    '    Call performActionOnChild(ButtonTypes.Search) 
                Case (Keys.Shift Or Keys.Control Or Keys.F12)
                    Dim tempChild As Form = Me.ActiveMdiChild
                    MsgBox(tempChild.Name)
                Case (Keys.Control Or Keys.P)  'Ctrl + P => Capture
                    Call showCapturer(True)
                Case (Keys.Control Or Keys.Alt Or Keys.S)
                    NavigateTo("RuntimeInfo", NavigatedWindowModes.Popup)
            End Select
            Return MyBase.ProcessCmdKey(msg, keyData)
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub showCapturer(Optional ByVal autoCapture As Boolean = False)
        Dim frmCapturer As Object = NavigateTo("SysCapturer", NavigatedWindowModes.Popup)
        If frmCapturer Is Nothing Then
            MsgBoxSC("Capturer module is not available!")
        Else
            frmCapturer.Owner = Me
            If autoCapture Then frmCapturer.ProcessCapture()
        End If
    End Sub

    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Call showCapturer(False)
    End Sub



    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        NavigateTo("SysSmartHelpViewer", NavigatedWindowModes.MDIWindow)
    End Sub




#Region "====== Menu Panel ======"
    Private Sub initLeftPanel()
        Dim dockManager As New Docking.DockManager(Me)
        Dim LeftPanel As Docking.DockPanel = dockManager.AddPanel(Docking.DockingStyle.Left)
        Dim sLeftName As String = "CrmLeftForm"
        Try
            RemoveHandler dockManager.StartDocking, AddressOf onStartDocking
            AddHandler dockManager.StartDocking, AddressOf onStartDocking

            With LeftPanel
                .Name = "LeftPanel"
                .Options.ShowCloseButton = False
                .Options.ShowAutoHideButton = True
                .Text = "작업접수현황"

                If Common.LoadUserSetting("MenuPanelWidth") = "" Then
                    .Width = 300
                Else
                    .Width = CInt(Common.LoadUserSetting("MenuPanelWidth"))
                End If

                If Common.LoadUserSetting("MenuPanelVisibility") = "" Then
                    .Visibility = Docking.DockVisibility.Visible
                Else
                    .Visibility = Common.LoadUserSetting("MenuPanelVisibility")
                End If

                RemoveHandler .SizeChanged, AddressOf onMenuPanelSizeChanged
                AddHandler .SizeChanged, AddressOf onMenuPanelSizeChanged
            End With

            Dim frm As Object = Nothing
            frm = NavigateTo(sLeftName, NavigatedWindowModes.Popup, False)
            If frm IsNot Nothing Then
                With frm
                    frm.TopLevel = False
                    frm.Left = 0
                    frm.Top = 0

                    ' Active Tab Name
                    LeftPanel.Controls.Add(frm)
                    frm.Dock = DockStyle.Fill
                    frm.show()
                End With
            End If
        Catch ex As Exception
            MsgBoxSC(ex.Message)
        End Try

    End Sub
    Private Sub onStartDocking(ByVal sender As Object, ByVal e As Docking.DockPanelCancelEventArgs)
        e.Cancel = True
    End Sub
    Private Sub onMenuPanelSizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pnl As Docking.DockPanel = CType(sender, Docking.DockPanel)
        Common.SaveUserSetting("MenuPanelWidth", pnl.Width)
    End Sub
#End Region

    Private Sub btnSRInfo_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSRInfo.ItemClick
        Dim Day As Integer = CInt(Mid(Now.ToString("yyyyMMdd"), 1, 1)) _
                                     + CInt(Mid(Now.ToString("yyyyMMdd"), 2, 1)) _
                                     + CInt(Mid(Now.ToString("yyyyMMdd"), 3, 1)) _
                                     + CInt(Mid(Now.ToString("yyyyMMdd"), 4, 1)) _
                                     + CInt(Mid(Now.ToString("yyyyMMdd"), 5, 1)) _
                                     + CInt(Mid(Now.ToString("yyyyMMdd"), 6, 1)) _
                                     + CInt(Mid(Now.ToString("yyyyMMdd"), 7, 1)) _
                                     + CInt(Mid(Now.ToString("yyyyMMdd"), 8, 1))
        Dim key As String = ((40 + Day) * 19) Mod 127
        Process.Start("http://portal.fwdnet.co.kr/User/Login.aspx?bsn=1148183347&auk=" & key & "&doc=M01")
        'Shell("C:\Program Files\Internet Explorer\IEXPLORE.EXE http://portal.fwdnet.co.kr/User/Login.aspx?bsn=1148183347&auk=" & key & "&doc=M01", AppWinStyle.NormalFocus)
    End Sub



    '#Region "====== Alert Message ====== '20191101 김성은 알림"
    '    Private Sub ShowNotReadMessage()
    '        Try
    '            '메시지 수신 시 오동작 방지를 위해서 비동기 방식으로 호출
    '            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.MsgMessageMgt", "GetNoReadMessage", {ClientSessionInfo.UserID}, AddressOf ShowNotReadMessage_OnComplete)
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub
    '    Private Sub ShowNotReadMessage_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
    '        Try
    '            Dim dsRet As DataSet = e.Result
    '            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

    '            If dr("TrxCode") <> "Y" Then
    '                MsgBox(dr("TrxMsg"))
    '                Exit Sub
    '            Else
    '                '메시지 수신 시, 알림창을 띄움
    '                Dim dtMsg As DataTable = dsRet.Tables("Data.RCVMSG")
    '                'Dim drMsg As DataRow
    '                Dim bExist As Boolean = False
    '                Dim dtTag As DataTable = Nothing
    '                Dim array() As Alerter.AlertForm = AlertControl1.AlertFormList.ToArray()
    '                If array.Count() > 0 Then
    '                    For j As Integer = 0 To array.Count() - 1
    '                        If dtTag Is Nothing Then
    '                            dtTag = New DataTable
    '                            dtTag = (GetAlertTagToDatatable(array(j).Info.Tag))
    '                        Else
    '                            dtTag.Merge(GetAlertTagToDatatable(array(j).Info.Tag))
    '                        End If
    '                    Next
    '                Else
    '                    dtTag = Nothing
    '                End If

    '                For Each drMsg As DataRow In dtMsg.Rows
    '                    If dtTag Is Nothing OrElse dtTag.Select("MSG_ID = '" & drMsg("MSG_ID").ToString & "'").Count = 0 Then
    '                        'https://documentation.devexpress.com/WindowsForms/DevExpress.XtraBars.Alerter.AlertControl.class

    '                        '창이 열려있지 않으면 창을 띄움
    '                        AlertControl1.Show(Me, drMsg("SENDER").ToString, drMsg("MSG").ToString, Nothing, Nothing, drMsg("MSG_TAG").ToString)
    '                    End If
    '                Next
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub
    '    Public Sub CloseReadMessage(ByVal msgid As String)
    '        Try
    '            'msgid와 같은 창을 찾아서 닫음
    '            Dim array() As Alerter.AlertForm = AlertControl1.AlertFormList.ToArray()

    '            If array.Count() > 0 Then
    '                For i As Integer = 0 To array.Count() - 1
    '                    Dim dtTag As DataTable = GetAlertTagToDatatable(array(i).Info.Tag)
    '                    For Each drTag As DataRow In dtTag.Rows
    '                        'If msgid = array(i).Info.HotTrackedText Then
    '                        If msgid = drTag("MSG_ID").ToString Then
    '                            AlertControl1.AlertFormList.Item(i).Close()
    '                        End If
    '                    Next
    '                Next
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub
    '    Public Sub CloseReadMessage()
    '        Try
    '            Dim dsRet As DataSet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "GetNoReadMessage", {ClientSessionInfo.UserID})
    '            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
    '            Dim msgid As String = String.Empty

    '            If dr("TrxCode") <> "Y" Then
    '                MsgBox(dr("TrxMsg"))
    '                Exit Sub
    '            Else
    '                '메시지 수신 시, 알림창을 띄움
    '                Dim dtMsg As DataTable = dsRet.Tables("Data.RCVMSG")

    '                '이미 창이 열려있는지 체크
    '                Dim array() As Alerter.AlertForm = AlertControl1.AlertFormList.ToArray()
    '                Dim alert_form_text As String = String.Empty
    '                If array.Count() > 0 Then
    '                    For i As Integer = 0 To array.Count() - 1
    '                        Dim dtTag As DataTable = GetAlertTagToDatatable(array(i).Info.Tag)
    '                        For Each drTag As DataRow In dtTag.Rows
    '                            'msgid = array(i).Info.HotTrackedText
    '                            msgid = drTag("MSG_ID").ToString
    '                            If dtMsg.Select("MSG_ID = '" & msgid & "' ").Length = 0 Then
    '                                AlertControl1.AlertFormList.Item(i).Close()
    '                            End If
    '                        Next
    '                    Next
    '                End If
    '            End If

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub

    '    Private Sub CloseReadMessage_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
    '        Try
    '            Dim dsRet As DataSet = e.Result
    '            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

    '            If dr("TrxCode") <> "Y" Then
    '                MsgBox(dr("TrxMsg"))
    '                Exit Sub
    '            Else
    '                '읽지 않은 메시지를 받아서 열린 창과 비교함
    '                Dim dtMsg As DataTable = dsRet.Tables("Data.RCVMSG")
    '                Dim array() As Alerter.AlertForm = AlertControl1.AlertFormList.ToArray()

    '                '열려있는 창을 체크해서 읽지 않은 메시지 테이블에 없으면 닫음
    '                If array.Count() > 0 Then
    '                    For i As Integer = 0 To array.Count() - 1
    '                        Dim dtTag As DataTable = GetAlertTagToDatatable(array(i).Info.Tag)
    '                        For Each drTag As DataRow In dtTag.Rows
    '                            'If dtMsg.Select("MSG_ID = '" & drTag("MSG_ID").ToString & "' ").Length = 0 Then
    '                            If dtMsg.Select("MSG_ID = '" & array(i).Info.HotTrackedText & "' ").Length = 0 Then
    '                                AlertControl1.AlertFormList.Item(i).Close()
    '                            End If
    '                        Next
    '                    Next
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub
    '    Public Sub ShowNotReadChatting(ByVal sender As String, ByVal msgTag As String, ByVal firstMsgID As String)
    '        Try
    '            Dim dtChatList As DataTable = Nothing
    '            Do
    '                For Each ctrl As Object In Me.Controls
    '                    If ctrl.Name = "menuPanel" Then
    '                        For Each ctrlMenuPanel As Object In ctrl.Controls
    '                            For Each frm As Object In ctrlMenuPanel.Controls
    '                                If String.Equals(frm.GetType.Name, "SysMenuList", StringComparison.InvariantCultureIgnoreCase) Then
    '                                    dtChatList = CType(frm.WG_CHAT_LIST.DataSource, DataTable).Copy
    '                                    frm.SearchChatListData()
    '                                    Exit Do
    '                                End If
    '                            Next
    '                        Next
    '                    End If
    '                Next
    '            Loop While False

    '            If dtChatList.Select("FIRST_MSG_ID = '" & firstMsgID & "'").Count = 0 Then
    '                sender = sender & " - " & Now.ToString("yyyy-MM-dd hh24:mi:ss")
    '                '' - ' || TO_CHAR(TO_DATE(SUBSTR(MST.MSG_ID,1,14), 'yyyyMMddhh24miss'),'yyyy-MM-dd hh24:mi:ss')
    '                Dim msg As String = String.Format("{0}{1}웹채팅(총{2}건) 내용을 확인해주세요.", "새로운 웹채팅 요청이 접수되었습니다.", vbCrLf, dtChatList.Rows.Count + 1)
    '                AlertControl1.Show(Me, sender, msg, Nothing, Nothing, msgTag)
    '            End If
    '        Catch ex As Exception
    '            '임시
    '            'MsgBoxLocalized(ex.Message)
    '            If ClientSessionInfo.AuthorizationType.Substring(0, 1) = "0" Then MsgBox(ex.Message)
    '        End Try
    '    End Sub
    '    Private Sub AlertControl1_FormLoad(ByVal sender As Object, ByVal e As Alerter.AlertFormLoadEventArgs) Handles AlertControl1.FormLoad
    '        e.Buttons.PinButton.SetDown(True)   '창이 자동으로 닫히지 않도록 핀을 고정시킴
    '        e.AlertForm.OpacityLevel = 1
    '        If e.AlertForm.Info.Text.StartsWith("[매우급함]") OrElse e.AlertForm.Info.Text.StartsWith("[급함]") Then
    '            e.AlertForm.BackColor = Color.Red
    '            e.AlertForm.ForeColor = Color.Red
    '        End If
    '    End Sub
    '    'Private Sub AlertControl1_BeforeFormShow(sender As Object, e As AlertFormEventArgs) Handles AlertControl1.BeforeFormShow
    '    '    If e.AlertForm.Info.Text.StartsWith("[매우급함]") OrElse e.AlertForm.Info.Text.StartsWith("[급함]") Then
    '    '        e.AlertForm.BackColor = Color.Red
    '    '    End If
    '    'End Sub

    '    Private Sub UpdateNoReadMessageCount(ByVal drAlertTag As DataRow)
    '        Dim dsRet As DataSet = New DataSet
    '        Dim drPairs As DataRow = Nothing

    '        Dim dt As DataTable = New DataTable("WG_RCV")
    '        dt.Columns.Add("_INSFLAG", GetType(String)) : dt.Columns.Add("MSG_ID", GetType(String)) : dt.Columns.Add("READ_YN", GetType(String))

    '        Dim dr As DataRow = dt.NewRow
    '        dr("_INSFLAG") = "U"
    '        dr("MSG_ID") = drAlertTag("MSG_ID").ToString
    '        dr("READ_YN") = "Y"
    '        dt.Rows.Add(dr)

    '        dsRet.Tables.Add(dt)

    '        Try
    '            dsRet = Common.MethodCallEx(Me, "YJIT.Biz.MsgMessageMgt", "UpdateNoReadMessageCount", {ClientSessionInfo.UserID, dsRet})

    '            '//////Parsing WCF returned data///////
    '            drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

    '            If drPairs("TrxCode") <> "Y" Then
    '                MsgBox(drPairs("TrxMsg"))
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub
    '    Private Sub UpdateAlert(ByVal drAlertTag As DataRow)
    '        Dim dsRet As DataSet = New DataSet
    '        Dim drPairs As DataRow = Nothing

    '        Dim dt As DataTable = New DataTable("WG_RCV")
    '        dt.Columns.Add("_INSFLAG", GetType(String)) : dt.Columns.Add("MSG_ID", GetType(String)) : dt.Columns.Add("READ_YN", GetType(String))

    '        Dim dr As DataRow = dt.NewRow
    '        dr("_INSFLAG") = "U"
    '        dr("MSG_ID") = drAlertTag("MSG_ID").ToString
    '        dr("READ_YN") = "Y"
    '        dt.Rows.Add(dr)

    '        dsRet.Tables.Add(dt)

    '        Try
    '            dsRet = Common.MethodCallEx(Me, "YJIT.Biz.MsgMessageMgt", "UpdateAlert", {ClientSessionInfo.UserID, dsRet})

    '            '//////Parsing WCF returned data///////
    '            drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

    '            If drPairs("TrxCode") <> "Y" Then
    '                MsgBox(drPairs("TrxMsg"))
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub
    '    Private Sub AlertControl1_AlertClick(ByVal sender As Object, ByVal e As Alerter.AlertClickEventArgs) Handles AlertControl1.AlertClick
    '        If IsNothing(e.Info.Tag) Then Exit Sub
    '        If String.IsNullOrEmpty(e.Info.Tag) Then Exit Sub

    '        Try
    '            Dim dtTag As DataTable = GetAlertTagToDatatable(e.Info.Tag)
    '            For Each drTag As DataRow In dtTag.Rows
    '                'If drTag("JOB_TYPE").ToString <> "ZZ" AndAlso Not String.IsNullOrEmpty(drTag("KEY1").ToString) Then
    '                If drTag("JOB_TYPE").ToString.Trim = "" OrElse drTag("FORMNM").ToString = "" Then
    '                    If drTag("MSG_TYPE").ToString.Trim = "C" Then
    '                        Do
    '                            For Each ctrl As Object In Me.Controls
    '                                If ctrl.Name = "menuPanel" Then
    '                                    For Each ctrlMenuPanel As Object In ctrl.Controls
    '                                        For Each frm As Object In ctrlMenuPanel.Controls
    '                                            If String.Equals(frm.GetType.Name, "SysMenuList", StringComparison.InvariantCultureIgnoreCase) Then
    '                                                'frm.tabMain.SelectedTabPage = frm.tabChat
    '                                                'frm.MSG_CONTENT.Focus()
    '                                                frm.SetTabChatChange()
    '                                                Call CloseReadMessage(drTag("MSG_ID").ToString.Trim)
    '                                                Exit Do
    '                                            End If
    '                                        Next
    '                                    Next
    '                                End If
    '                            Next
    '                        Loop While False
    '                    Else
    '                        Dim fTarget As Object = Nothing
    '                        fTarget = NavigateTo("MsgMessageMgt", NavigatedWindowModes.Dialog, False)
    '                        If fTarget IsNot Nothing Then
    '                            e.AlertForm.Close()
    '                            fTarget.parentWindow = Me
    '                            'fTarget.paramMsgID = e.Info.HotTrackedText
    '                            fTarget.paramMsgID = drTag("MSG_ID").ToString
    '                            fTarget.ShowDialog()
    '                            'Call UpdateNoReadMessageCount() '메세지화면에서 확인처리 로직이 있음
    '                            Call GetNoReadMessageCount()
    '                            Call CloseReadMessage()
    '                        End If
    '                    End If
    '                Else
    '                    If Not String.IsNullOrEmpty(drTag("KEY1").ToString) Then
    '                        Dim fTarget As Object = Nothing
    '                        Dim frmMain As YJIT.SC.UI.IMainForm = SCView.MainFormInstance
    '                        fTarget = Nothing
    '                        fTarget = frmMain.NavigateTo(drTag("FORMNM").ToString, NavigatedWindowModes.MDIWindow, True)
    '                        fTarget.SearchFromMsg(drTag("KEY1").ToString, drTag("KEY2").ToString, drTag("KEY3").ToString, drTag("KEY4").ToString, drTag("KEY5").ToString)

    '                        e.AlertForm.Close()
    '                        'Call UpdateNoReadMessageCount(drTag)
    '                        Call UpdateAlert(drTag)
    '                        Call GetNoReadMessageCount()
    '                        Call CloseReadMessage()

    '                        Call Common.SendElvisToAll(SavedSessionDomain, ClientSessionInfo.UserID, {ClientSessionInfo.UserID}, "EE", "P", "ALERT_CLOSE", "Alert Close", "", "", "", "", "", "", "", "N", "N")
    '                    End If
    '                End If
    '            Next
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub
    '    Private Function GetAlertTagToDatatable(ByVal alertTag As String) As DataTable
    '        Dim dt As DataTable = Nothing

    '        Try
    '            Dim arrParam() As String = Split(alertTag, "|")
    '            If arrParam.Count = 0 Then Exit Try

    '            dt = New DataTable("AlertTag")
    '            dt.Columns.Add("MSG_ID", GetType(String))
    '            dt.Columns.Add("DOMAIN", GetType(String))
    '            dt.Columns.Add("SENDER", GetType(String))
    '            dt.Columns.Add("SYS_TYPE", GetType(String))
    '            dt.Columns.Add("MSG_TYPE", GetType(String))
    '            dt.Columns.Add("JOB_TYPE", GetType(String))
    '            dt.Columns.Add("MSG", GetType(String))
    '            dt.Columns.Add("FIRST_MSG_ID", GetType(String))
    '            dt.Columns.Add("PARENT_MSG_ID", GetType(String))
    '            dt.Columns.Add("KEY1", GetType(String))
    '            dt.Columns.Add("KEY2", GetType(String))
    '            dt.Columns.Add("KEY3", GetType(String))
    '            dt.Columns.Add("KEY4", GetType(String))
    '            dt.Columns.Add("KEY5", GetType(String))
    '            dt.Columns.Add("FORMNM", GetType(String))

    '            Dim dr As DataRow = dt.NewRow
    '            For i = 0 To arrParam.Count - 1
    '                If i > (dr.Table.Columns.Count - 1) Then Exit For
    '                dr(i) = arrParam(i)
    '            Next
    '            dt.Rows.Add(dr)
    '        Catch ex As Exception
    '            MsgBox(ex.Message & " (GetAlertTagToDatatable)")
    '        End Try

    '        Return dt
    '    End Function
    '    Private Function GetReceiveTagToDatatable(ByVal ReceiveTag As String) As DataTable
    '        Dim dt As DataTable = Nothing

    '        Try
    '            Dim arrParam() As String = Split(ReceiveTag, "|")
    '            If arrParam.Count = 0 Then Exit Try

    '            dt = New DataTable("ReceiveTag")

    '            'rcvid : DOMAIN|MSG_ID|SENDER|RECEIVER|SYS_TYPE|MSG_TYPE|JOB_TYPE|MSG|FIRST_MSG_ID 형태로 rcvid 정의함
    '            'DOMAIN : 도메인
    '            'SENDER : 전송자(E-MAIL또는USR_ID)
    '            'RECEIVER : 수신자(E-MAIL또는USR_ID)
    '            'SYS_TYPE : 요청서비스 (W:WEB, E:ELVIS, C:CRM)
    '            'MSG_TYPE : 메세지구분 (C:CHAT, P:PUSH, M:MESSAGE)
    '            'JOB_TYPE : 업무구분 (공통코드:MSG01 / USR:회원가입 등등)
    '            'MSG : 메시지내용
    '            'FIRST_MSG_ID : 최초메세지번호 (년월일+시분초+밀리초+랜덤3자리)

    '            dt.Columns.Add("DOMAIN", GetType(String))
    '            dt.Columns.Add("SENDER", GetType(String))
    '            dt.Columns.Add("RECEIVER", GetType(String))
    '            dt.Columns.Add("SYS_TYPE", GetType(String))
    '            dt.Columns.Add("MSG_TYPE", GetType(String))
    '            dt.Columns.Add("JOB_TYPE", GetType(String))
    '            dt.Columns.Add("MSG", GetType(String))
    '            dt.Columns.Add("FIRST_MSG_ID", GetType(String))

    '            Dim dr As DataRow = dt.NewRow
    '            For i = 0 To arrParam.Count - 1
    '                If i > (dr.Table.Columns.Count - 1) Then Exit For
    '                dr(i) = arrParam(i)
    '            Next

    '            dt.Rows.Add(dr)
    '        Catch ex As Exception
    '            MsgBox(ex.Message & " (GetReceiveTagToDatatable)")
    '        End Try

    '        Return dt
    '    End Function
    '    Private Sub CloseAllMessage()

    '        Dim dicChat As Dictionary(Of String, String) = New Dictionary(Of String, String)
    '        dicChat.Add("NAME", ClientSessionInfo.UserID)
    '        dicChat.Add("DOMAIN", SavedSessionDomain)
    '        messageHub.Invoke("Disconnect", dicChat)

    '        messageHub = Nothing
    '        HubConnection = Nothing

    '        '열려있는 메시지 창을 모두 닫음
    '        Dim array() As Alerter.AlertForm = AlertControl1.AlertFormList.ToArray()
    '        Dim alert_form_text As String = String.Empty
    '        If array.Count() > 0 Then
    '            For i As Integer = 0 To array.Count() - 1
    '                AlertControl1.AlertFormList(i).Close()
    '            Next
    '        End If
    '    End Sub
    '#End Region

    '#Region "======Message====== '20191101 김성은 알림"
    '    Private Sub bbiMessage_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiMessage.ItemClick
    '        If IsNothing(HubConnection) Then
    '            Call ConnectToCallChatHub()
    '        ElseIf HubConnection.State = Microsoft.AspNet.SignalR.Client.ConnectionState.Disconnected Then
    '            Call ConnectToCallChatHub()
    '        End If

    '        Dim fTarget As Object = Nothing
    '        fTarget = NavigateTo("MsgMessageMgt", NavigatedWindowModes.Dialog, False)
    '        If Not IsNothing(fTarget) Then
    '            fTarget.parentWindow = Me
    '            fTarget.ShowDialog()
    '            Call GetNoReadMessageCount()
    '            Call CloseReadMessage()
    '        End If
    '    End Sub

    '    'Private Function CreateSignalR() As Boolean
    '    '    Dim reTry = True
    '    '    While reTry
    '    '        Try
    '    '            HubConnection = New HubConnection("http://chat.elvisprime.com/signalr/")
    '    '            messageHub = HubConnection.CreateHubProxy("chatHub")
    '    '            messageHub.[On](Of String, String, String)("messageelvis", Sub(domain As String, rcvid As String, msg As String)
    '    '                                                                           MessageElvisToAll(domain, rcvid, msg)
    '    '                                                                       End Sub)

    '    '            ServicePointManager.DefaultConnectionLimit = 10

    '    '            HubConnection.Start().ContinueWith(Sub(task As Task)
    '    '                                                   If Not task.IsFaulted Then
    '    '                                                       reTry = False
    '    '                                                   Else
    '    '                                                       reTry = True
    '    '                                                       Thread.Sleep(3000)
    '    '                                                   End If
    '    '                                               End Sub).Wait()


    '    '        Catch ex As Exception
    '    '            HubConnection.Stop()
    '    '            Return False
    '    '        End Try
    '    '    End While
    '    'End Function

    '    Public Sub ConnectToCallChatHub()

    '        'Dim MessageHubURL As String = "http://chat.mytestelvisprime.tk/"
    '        Dim MessageHubURL As String = "http://chat.elvisprime.com"
    '        'Dim MessageHubURL As String = ClientSessionOfficeInfo.MessageHubURL

    '        Try
    '            'Message Hub 서버로부터 메시지를 받는 함수6
    '            If MessageHubURL <> "" Then
    '                HubConnection = New Microsoft.AspNet.SignalR.Client.Hubs.HubConnection(MessageHubURL)
    '                messageHub = HubConnection.CreateHubProxy("chatHub")
    '                messageHub.[On](Of String, String, String)("messageelvis", Sub(domain As String, rcvid As String, msg As String)
    '                                                                               MessageElvisToAll(domain, rcvid, msg)
    '                                                                           End Sub)

    '                'prime_message로 sys_type를 ee로 전송시 수신
    '                messageHub.[On](Of String, String, String)("sendprivatemessage", Sub(windowid As String, fromusername As String, message As String)
    '                                                                                     MessageFunction(windowid, fromusername, message)
    '                                                                                 End Sub)
    '                '보낼때
    '                'messageHub.[On](Of String, String, String)("prime_Message", Sub(windowId As String, fromUserName As String, message As String)
    '                '                                                                MessageFunction(windowId, fromUserName, message)
    '                '                                                            End Sub)


    '                HubConnection.Start.Wait()
    '                AddHandler HubConnection.StateChanged, (AddressOf HubConnectionState)
    '                HubConnection.OnReconnecting()

    '                Dim dicChat As Dictionary(Of String, String) = New Dictionary(Of String, String)
    '                dicChat.Add("NAME", ClientSessionInfo.UserID)
    '                dicChat.Add("DOMAIN", SavedSessionDomain)

    '                'messageHub.Invoke("Connect", String.Format("{0} ({1}", ClientSessionInfo.UserID)) '채팅리스트 표시
    '                messageHub.Invoke("Connect", dicChat) '채팅리스트 표시
    '            End If
    '        Catch ex As Exception
    '            Dim Message As String = Me.Localizer1.GetLocalizedString("The message server connection failed. Please try again later.{0}") '메세지 서버연결에 실패했습니다. 잠시후 다시 시도해주세요.
    '            Message = Message.Replace("{0}", vbCrLf & "(" & ex.Message & ")")
    '            MsgBox(Message)
    '        End Try
    '    End Sub
    '    Public Delegate Function OnConnectionSateChangedDelegate(ByVal State As Microsoft.AspNet.SignalR.Client.ConnectionState)
    '    Private Sub HubConnectionState(ByVal State As Microsoft.AspNet.SignalR.Client.StateChange)
    '        Try
    '            Me.BeginInvoke(New OnConnectionSateChangedDelegate(AddressOf OnConnectionSateChanged), State.NewState)
    '        Catch ex As Exception
    '        End Try
    '    End Sub
    '    Public Function OnConnectionSateChanged(ByVal State As Microsoft.AspNet.SignalR.Client.ConnectionState)
    '        Try
    '            If State = Microsoft.AspNet.SignalR.Client.ConnectionState.Disconnected Then
    '                Call ConnectToCallChatHub()
    '            End If
    '        Catch ex As Exception
    '        End Try
    '        Return False
    '    End Function
    '    Public Sub ReadyRcvMessage()
    '        If IsNothing(HubConnection) Then
    '            Call ConnectToCallChatHub()
    '        ElseIf HubConnection.State = Microsoft.AspNet.SignalR.Client.ConnectionState.Disconnected Then
    '            Call ConnectToCallChatHub()
    '        End If

    '        Try
    '            Select Case HubConnection.State
    '                Case Microsoft.AspNet.SignalR.Client.ConnectionState.Connected, Microsoft.AspNet.SignalR.Client.ConnectionState.Connecting
    '                    bbiMessage.Visibility = BarItemVisibility.Always
    '                    Call GetNoReadMessageCount()
    '                    Me.BeginInvoke(New MethodInvoker(Sub() ShowNotReadMessage()), Me)
    '            End Select
    '        Catch ex As Exception
    '            MsgBox(ex.Message & " (ReadyRcvMessage)")
    '        End Try
    '    End Sub
    '    Private Sub MessageElvisToAll(ByVal domain As String, ByVal userName As String, ByVal msg As String)
    '        'rcvid : DOMAIN|SENDER|RECEIVER|SYS_TYPE|MSG_TYPE|JOB_TYPE|MSG|FIRST_MSG_ID 형태로 rcvid 정의함
    '        'DOMAIN : 도메인
    '        'SENDER : 전송자(E-MAIL또는USR_ID)
    '        'RECEIVER : 수신자(E-MAIL또는USR_ID)
    '        'SYS_TYPE : 요청서비스 (W:WEB, E:ELVIS, C:CRM)
    '        'MSG_TYPE : 메세지구분 (C:CHAT, P:PUSH, M:MESSAGE)
    '        'JOB_TYPE : 업무구분 (공통코드:MSG01 / USR:회원가입 등등)
    '        'MSG : 메시지내용
    '        'FIRST_MSG_ID : 최초메세지번호 (년월일+시분초+밀리초+랜덤3자리)

    '        Try
    '            Dim dtTag As DataTable = GetReceiveTagToDatatable(msg)
    '            For Each drTag As DataRow In dtTag.Rows
    '                If drTag("DOMAIN").ToString = SavedSessionDomain Then
    '                    Select Case drTag("MSG_TYPE").ToString
    '                        Case "P"
    '                            If drTag("JOB_TYPE").ToString.Trim = "ALERT_CLOSE" Then
    '                                Call GetNoReadMessageCount()
    '                                Me.BeginInvoke(New MethodInvoker(Sub() CloseReadMessage()), Me)
    '                                Exit For
    '                            End If
    '                    End Select
    '                End If
    '            Next
    '        Catch ex As Exception
    '            MsgBox(ex.Message & " (MessageFunction)")
    '        End Try
    '    End Sub
    '    Private Sub MessageFunction(ByVal userName As String, ByVal rtnStr As String, ByVal msg As String)
    '        'rcvid : DOMAIN|SENDER|RECEIVER|SYS_TYPE|MSG_TYPE|JOB_TYPE|MSG|FIRST_MSG_ID 형태로 rcvid 정의함
    '        'DOMAIN : 도메인
    '        'SENDER : 전송자(E-MAIL또는USR_ID)
    '        'RECEIVER : 수신자(E-MAIL또는USR_ID)
    '        'SYS_TYPE : 요청서비스 (W:WEB, E:ELVIS, C:CRM)
    '        'MSG_TYPE : 메세지구분 (C:CHAT, P:PUSH, M:MESSAGE)
    '        'JOB_TYPE : 업무구분 (공통코드:MSG01 / USR:회원가입 등등)
    '        'MSG : 메시지내용
    '        'FIRST_MSG_ID : 최초메세지번호 (년월일+시분초+밀리초+랜덤3자리)

    '        Try
    '            Dim dtTag As DataTable = GetReceiveTagToDatatable(rtnStr)
    '            For Each drTag As DataRow In dtTag.Rows
    '                If drTag("DOMAIN").ToString = SavedSessionDomain Then
    '                    Select Case drTag("MSG_TYPE").ToString
    '                        Case "C"
    '                            '채팅
    '                            Select Case drTag("SYS_TYPE").ToString
    '                                Case "WE"
    '                                    'WEB->ELVIS / ELVIS->WEB은 처리할 필요없음
    '                                    If drTag("RECEIVER").ToString.ToUpper() = ClientSessionInfo.UserID.ToUpper() Then
    '                                        'Call GetNoReadMessageCount()

    '                                        '직접 호출하면 화면에 띄우지 못하는 문제가 있어서 비동기 방식으로 처리함
    '                                        Me.BeginInvoke(New MethodInvoker(Sub() ShowNotReadChatting(drTag("SENDER").ToString, rtnStr, drTag("FIRST_MSG_ID").ToString)), Me)
    '                                    End If
    '                            End Select
    '                        Case "P"
    '                            '푸시알림 / 사내메신저
    '                            'WEB->ELVIS 정보를 모든 사용자에 표시하고 최초메세지를 선택한 사용자외에는 ELVIS->ELVIS 메세지를 보내서 팝업창을 모두 제거
    '                            If drTag("RECEIVER").ToString.ToUpper() = ClientSessionInfo.UserID.ToUpper() Then
    '                                Call GetNoReadMessageCount()

    '                                '직접 호출하면 화면에 띄우지 못하는 문제가 있어서 비동기 방식으로 처리함
    '                                Me.BeginInvoke(New MethodInvoker(Sub() ShowNotReadMessage()), Me)
    '                                Exit For
    '                            End If
    '                    End Select
    '                End If
    '            Next
    '        Catch ex As Exception
    '            MsgBox(ex.Message & " (MessageFunction)")
    '        End Try
    '    End Sub

    '    Public Sub GetNoReadMessageCount()
    '        Try
    '            Dim dsRet As DataSet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "GetNoReadMessageCount", {ClientSessionInfo.UserID})
    '            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

    '            If dr("TrxCode") <> "Y" Then
    '                MsgBox(dr("TrxMsg"))
    '                Exit Sub
    '            Else
    '                Dim strCnt As String = dr("MSG_CNT").ToString()
    '                If strCnt = "0" Then
    '                    bbiMessage.Glyph = imageCollection1.Images(36)
    '                Else
    '                    bbiMessage.Glyph = imageCollection1.Images(35)
    '                End If
    '                bbiMessage.Caption = strCnt
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub
    '#End Region

End Class

'#Region "=============================== Soket ==================================================="

'    'Delegate Sub _ViewNotice(ByVal Ds As DataSet)
'    'Delegate Sub _ShowNotic(ByVal NoticeParam As Object)

'    'Enum NoticeAction
'    '    Dialog = 0
'    '    ShowDialog = 1
'    '    Restart = 2
'    '    NoHidden = 3
'    '    MsgBox = 4
'    'End Enum

'    ''1 Server에서 받은 data 가공
'    'Public Sub RcvMsg(ByVal msg As String)

'    '    Dim MsgChar() As Char = msg.ToCharArray
'    '    Dim MsgArr As System.Collections.Generic.IEnumerable(Of Char) = MsgChar.Distinct
'    '    '오류 시 msg null 값이 1024개 들어옴
'    '    If MsgArr.Count = 1 Then
'    '        If Asc(MsgArr(0)) = 0 Then
'    '            frmClient.CloseClient()
'    '            Exit Sub
'    '        End If
'    '    End If


'    '    Dim TempName As String = Application.StartupPath & "\" & Now.ToString("yyMMddHHmmssFFFFFFF")
'    '    FileIO.FileSystem.WriteAllText(TempName, msg, False)

'    '    Try
'    '        Dim myThread As Threading.Thread
'    '        Dim ds As New DataSet

'    '        ds.ReadXml(TempName)

'    '        myThread = New Threading.Thread(AddressOf ViewNotice)
'    '        myThread.Start(ds)
'    '    Catch ex As Exception
'    '        frmClient.CloseClient()

'    '        MsgBoxSC("RcvMsg" & vbCrLf & ex.Message)
'    '    End Try
'    '    FileIO.FileSystem.DeleteFile(TempName)

'    'End Sub
'    ''2 data 가공한 후 상태에 따른 로직 
'    'Public Sub ViewNotice(ByVal ds As DataSet)
'    '    Try

'    '        If InvokeRequired Then
'    '            Invoke(New _ViewNotice(AddressOf ViewNotice), ds)
'    '            Exit Sub
'    '        End If

'    '        'Data 가공
'    '        Dim NoticeParam As New NoticeParam
'    '        Dim Maindt As DataTable = ds.Tables("RcvToUserMsg")
'    '        NoticeParam.SetDataParam(Maindt)

'    '        If NoticeParam.Msg = "" Then
'    '            Exit Sub
'    '        End If
'    '        If NoticeParam.MsgCode = "SysMsg01" Then
'    '            '   frmClient.CloseClient()
'    '        End If
'    '        ' NoticeAction 으로 분계
'    '        Select Case NoticeParam.NoticeAction
'    '            Case NoticeAction.Restart
'    '                Me.Activate()
'    '                If MsgBoxSC(NoticeParam.Msg, MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
'    '                    CloseMainForm()
'    '                End If
'    '            Case NoticeAction.MsgBox
'    '                Me.Activate()
'    '                MsgBoxSC(NoticeParam.Msg, MessageBoxButtons.OK)
'    '            Case Else
'    '                Dim Frm As Object = NavigateTo("CrmUserNoice", NavigatedWindowModes.Popup, False)
'    '                If ds.Tables.Contains("SearchKey") Then
'    '                    Frm.NaviInfo = ds.Tables("SearchKey")
'    '                End If

'    '                NoticeParam.Form = Frm

'    '                Dim myThread As Threading.Thread
'    '                myThread = New Threading.Thread(AddressOf ShowNotic)
'    '                myThread.Start(NoticeParam)
'    '        End Select
'    '    Catch ex As Exception
'    '        MsgBoxSC("ViewNotice" & vbCrLf & ex.Message)
'    '    End Try

'    'End Sub
'    ''3 ShowNotic 띄움
'    'Public Sub ShowNotic(ByVal NoticeParam As NoticeParam)
'    '    Try
'    '        If InvokeRequired Then
'    '            Invoke(New _ShowNotic(AddressOf ShowNotic), NoticeParam)
'    '            Exit Sub
'    '        End If

'    '        NoticeParam.SetDataNoticeForm()

'    '        Select Case NoticeParam.NoticeAction
'    '            Case NoticeAction.Dialog
'    '                NoticeParam.Form.show()
'    '            Case NoticeAction.ShowDialog
'    '                Me.Activate()
'    '                NoticeParam.Form.ShowDialog()
'    '        End Select
'    '    Catch ex As Exception
'    '        MsgBoxSC("ShowNotic" & vbCrLf & ex.Message)
'    '    End Try

'    'End Sub

'    'Public Sub CloseMainForm()
'    '    Me.ConfirmOnExit = False
'    '    For Each frm As Object In Me.MdiChildren
'    '        frm.DataState = DataStates.Retrieved
'    '        frm.Close()
'    '        frm.Dispose()
'    '    Next

'    '    Dim FilePath As String = Application.StartupPath & "\STARTUP.appref-ms"
'    '    FileIO.FileSystem.WriteAllText(FilePath, Common.ServerIP & "/wcf/client/ELVIS_CRM.application#ELVIS_CRM.application", False)
'    '    Dim proc As New System.Diagnostics.Process()

'    '    proc = Process.Start(FilePath, "")
'    '    Application.Exit()
'    'End Sub

'    'Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
'    '    CloseMainForm()
'    'End Sub

'    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
'    '    Try

'    '        frmClient.PushToUserMsg(ClientSessionInfo.UserID, "SysMsg01", "", Nothing)
'    '        Timer1.Stop()
'    '    Catch ex As Exception

'    '    End Try
'    'End Sub

'    ''소켓 일정 주기마다 리 커넥션
'    'Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

'    '    Try
'    '        ' Dim MM As Integer = Now.Minute

'    '        '  If MM Mod 5 = 0 Then

'    '        '  
'    '        If frmClient.Connected = False Then
'    '            frmClient.CloseClient()
'    '            frmClient.RunClient(Common.SavedSessionDomain, ClientSessionInfo.UserID, ClientSessionInfo.LocalName)
'    '        End If

'    '        '   End If

'    '    Catch ex As Exception

'    '    End Try
'    'End Sub

'#End Region


''Noitce 화면에 전달되는 파라미터 셋팅 
'Public Class NoticeParam
'    Public NoticeAction As NoticeAction
'    Public Form As Object
'    Public Msg As String = ""
'    Public MsgCode As String = ""

'    Public Sub SetDataParam(ByVal Maindt As DataTable)
'        If Maindt.Columns.Contains("NoticeAction") Then
'            NoticeAction = Maindt.Rows(0)("NoticeAction")
'        End If
'        Msg = Maindt.Rows(0)("MSG")
'        If Maindt.Columns.Contains("MSG_CODE") Then
'            MsgCode = Maindt.Rows(0)("MSG_CODE")
'        End If
'    End Sub

'    Public Sub SetDataNoticeForm()
'        If NoticeAction = MainForm.NoticeAction.ShowDialog Then
'            Form.Msg.AutoSize = True
'            Form.Msg.TextAlign = ContentAlignment.TopLeft
'            Form.AutoSize = True
'        End If

'        Form.NoticeAction = NoticeAction
'        Form.Msg.text = Msg
'    End Sub
'End Class

