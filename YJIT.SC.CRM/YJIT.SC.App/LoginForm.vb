Imports System.IO
Imports System.Globalization
Imports System.Reflection
Imports System.Net
Imports System.Net.NetworkInformation


Public Class LoginForm

    Public Shared SavedUserID As String
    Public Shared SavedUserPwd As String
    Public Shared SaveUserState As String       'Check/Uncheckbox
    Public Shared Instance As LoginForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoginForm.Instance = Me



    End Sub

    Protected Overrides Sub ProcessUserFuncAuthorities(Optional parent As Control = Nothing)
        'Do nothing, just stop process of its base
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        btnLogin.Enabled = False
        picProgress.Visible = True
        picProgress.Update()
        lblResult.Text = ""

        'Temporary create an instance to request WCF authentication
        YJIT.SC.WCF.WCFBiz.Instance = New YJIT.SC.WCF.WCFBiz(USER_ID.Text, USER_PWD.Text, "CRM.ELVIS.COM")
        '20170403 김성은   중복체크
        AddHandler YJIT.SC.WCF.WCFBiz.Instance.OnInjectingClientInfo, AddressOf injectingCustomClientInfo

        'Build up the parameter (array type)
        Dim params() As Object = {}
        Try
            Call YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz", "RequestLogin", params, AddressOf onRequestLoginCompleted)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Preload xtrareport component for better performance later (work in background)
        Dim thd As New System.Threading.Thread(AddressOf preloadReportComponents)
        thd.IsBackground = True
        thd.Start()
    End Sub

    Private Sub injectingCustomClientInfo(ByVal sender As Object, ByVal dtInfo As DataTable)
        'dtInfo has alreayd ve: 1 row
        Try
            '20170714 김성은 IIS 죽는경우 생겨서 임시 주석
            'Dim IpAddr As String = String.Empty
            'For Each IPA As IPAddress In Dns.GetHostAddresses(Dns.GetHostName())
            '    If IPA.AddressFamily.ToString() = "InterNetwork" Then
            '        IpAddr = IPA.ToString()
            '        Exit For
            '    End If
            'Next

            'Dim nics() As NetworkInterface = _
            '             NetworkInterface.GetAllNetworkInterfaces
            'Dim MacAddr As String = nics(0).GetPhysicalAddress.ToString()


            'dtInfo.Columns.Add("IP_ADDR", GetType(String))
            'dtInfo.Columns.Add("MAC_ADDR", GetType(String))
            'dtInfo.Rows(0)("IP_ADDR") = IpAddr
            'dtInfo.Rows(0)("MAC_ADDR") = MacAddr
        Catch ex As Exception

        End Try
    End Sub

    Private Sub onRequestLoginCompleted(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Dim dsRet As DataSet
        Dim drPairs As DataRow
        Try
            dsRet = e.Result
        Catch ex As Exception
            Exit Sub
        End Try
        '//////Parsing WCF returned data///////
        drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        'Defualt Message


        '=============================================================
        'Localized Setting
        '=============================================================  
        Dim LocalizerCode As String = Common.LoadUserSetting("UserLanguageID")
        ApplyLanguageSettingToForm(Me)
        If Trim(LocalizerCode) = "" Then
            Select Case ClientSessionOfficeInfo.CountryCode
                Case "KR"
                    LocalizerCode = "ko-KR"
                Case Else
                    LocalizerCode = "en-US"
            End Select
        End If
        System.Threading.Thread.CurrentThread.CurrentUICulture = New CultureInfo(LocalizerCode)
        '=============================================================  
        Dim StatusMessage As String = Me.Localizer1.GetLocalizedString(drPairs("StatusMessage"))

        If drPairs("Status") = "FAIL" Then
            lblResult.Text = StatusMessage
            USER_ID.Focus()
            USER_ID.SelectAll()
        ElseIf drPairs("Status") = "LOGIN_DUPLICATE" Then
            '20170403 김성은 중복체크
            Dim LoginErrMsg As String = String.Empty
            If drPairs.Table.Columns.Contains("StatusMessage2") Then
                LoginErrMsg = drPairs("StatusMessage2")
            End If

            If MsgBoxLocalized(StatusMessage & " " & Me.Localizer1.GetLocalizedString("기존 사용자를 로그아웃 시키겠습니까?") & vbCrLf & vbCrLf & LoginErrMsg, vbYesNo) = vbYes Then 'Are you sure you want to log out that ID?
                Dim dsLoginRet As DataSet = MethodCallEx(Me, "YJIT.Biz", "ResetLogin", {""})
                Dim drLoginPairs As DataRow = dsLoginRet.Tables("KEY_VALUE_PAIRS").Rows(0)
                Select Case drLoginPairs("Status")
                    Case "SUCCESS"
                        MsgBoxLocalized(Me.Localizer1.GetLocalizedString("기존 아이디가 로그아웃 되었습니다.") & " " & Me.Localizer1.GetLocalizedString("다시 로그인 하십시오.")) 'The ID loged out at the other place. 'Please log on again.
                    Case Else
                        lblResult.Text = Me.Localizer1.GetLocalizedString(Me.Localizer1.GetLocalizedString(drLoginPairs("StatusMessage")) & " " & Me.Localizer1.GetLocalizedString("다시 로그인 하십시오.")) 'Please log on again.
                End Select
            Else
                lblResult.Text = StatusMessage
            End If
            USER_ID.Focus()
            USER_ID.SelectAll()
        ElseIf drPairs("Status") = "SUCCESS" Or _
               drPairs("Status") = "CHANGE" Or _
               drPairs("Status") = "UNLOCK" Or _
               drPairs("Status") = "WIZARD" Then
            'Synchronize client-server user session information
            ''이병호 추가 2014 02 10
            'login logic modify

            Dim FIRST_LOAD_FORM As String = ""
            ClientSessionInfo.StartLoginTime = Now()
            Me.DialogResult = DialogResult.OK
            '첫 셋팅일경우 위자드 화면을 호출

            Common.OpenWizard = False
            Dim AuthDs As DataSet = Common.SynchronizeUserSessionInfo(USER_ID.Text)


            Dim frmMain As Object = Nothing
            Dim ass As Assembly = Assembly.GetExecutingAssembly()
            frmMain = ass.CreateInstance("YJIT.SC.App.MainForm", True)
            frmMain.Show()

            '로그인 성공시 세션 셋팅
            Common.SavedSessionDomain = "CRM.ELVIS.COM"

            Me.Hide()
        Else
            lblResult.Text = Me.Localizer1.GetLocalizedString("Unrecognized login result!")
        End If
        btnLogin.Enabled = True
        picProgress.Visible = False

    End Sub

    Public Sub ApplyLanguageSettingToForm(ByVal frm As Object) ' Implements UI.IMainForm.ApplyLanguageSettingToForm
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

    Private Sub LoginForm_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        'Check for WebLogin request
        Dim args() As String = Environment.GetCommandLineArgs
        Dim isWebLogin As Boolean = False
        Dim sWebLoginParams As String = ""
        For Each arg As String In args
            If arg.StartsWith("-WebLogin") Then
                sWebLoginParams = arg.Replace("-WebLogin", "")
                isWebLogin = True
                Exit For
            End If
        Next

        If isWebLogin Then
            'Login Request from Website===========================================
            Dim parts() As String = sWebLoginParams.Split("&")
            For Each part As String In parts
                'If part.StartsWith("domain=") Then DOMAIN.Text = part.Replace("domain=", "").Trim
                If part.StartsWith("userid=") Then USER_ID.Text = part.Replace("userid=", "").Trim
                If part.StartsWith("pswd=") Then USER_PWD.Text = part.Replace("pswd=", "").Trim
            Next
            'automatically login
            Call btnLogin_Click(Me, Nothing)
        Else
            'Normal Login==========================================================
            'DOMAIN.Text = Common.SavedSessionDomain
            If Common.SavedUserState = "Y" Then
                chkSaveUser.Checked = True
                USER_ID.Text = Common.SavedUserId
                USER_PWD.Text = Common.SavedUserPwd
            Else
                chkSaveUser.Checked = False
            End If
            If Common.UseRibbonMDI = "Y" Then
                chkUseRibbon.Checked = True
            Else
                chkUseRibbon.Checked = False
            End If

            Me.USER_ID.Focus()
        End If
    End Sub

    Private Sub lblExit_Click(sender As System.Object, e As System.EventArgs) Handles lblExit.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If chkSaveUser.Checked Then
            Common.SavedUserState = "Y"
            Common.SavedUserId = USER_ID.Text
            Common.SavedUserPwd = USER_PWD.Text
        Else
            Common.SavedUserState = "N"
            Common.SavedUserId = ""
            Common.SavedUserPwd = ""
        End If

        Common.SavedSessionDomain = "CRM.ELVIS.COM"

        If chkUseRibbon.Checked Then
            Common.UseRibbonMDI = "Y"
        Else
            Common.UseRibbonMDI = "N"
        End If
    End Sub
    'wizard popup 
    Private Function SetupWizard() As Object
        Dim SrcId As String = "SetupWizard"
        Dim sID As String = ""
        'Without capitalization
        sID = sID.ToUpper

        'Open the selected form as a new child
        Dim assContainer As Assembly = Nothing
        Dim assExecuting As Assembly = Assembly.GetExecutingAssembly()
        Dim frmView As Object = Nothing
        Try
            'Check if current assembly contains module definition
            If assExecuting.GetType(Common.APP_ROOT_NAMESPACE & "." & sID) IsNot Nothing Then
                assContainer = assExecuting
            Else
                If Common.IsDeploymentMode = True Then
                    assContainer = ModuleLoadedManifest(Common.APP_ROOT_NAMESPACE & "." & sID)                                                    'Refer to yet loaded assembly
                Else
                    assContainer = Assembly.Load(System.IO.File.ReadAllBytes(Common.ModuleManifest(Common.APP_ROOT_NAMESPACE & "." & sID)))       'This will reload assembly without locking it
                End If
            End If

            If assContainer Is Nothing Then
                Throw New Exception(Me.Localizer1.GetLocalizedString("Could not locate module:") & Common.APP_ROOT_NAMESPACE & sID)
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
            CType(frmView, Form).StartPosition = FormStartPosition.CenterScreen
            CType(frmView, Form).ShowDialog()
        Else
            'Pending: Inform user of non-existance
        End If
        Return frmView
    End Function

    Private Sub preloadReportComponents()
        'We invisibly load a dummy report and show into ReportPrintTool, so that next call to them will be run faster
        'Harry tested (20131111): Ok
        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(New DevExpress.XtraReports.UI.XtraReport)
        pt.PreviewForm.TopLevel = False
        Dim pal As New Panel : pal.Controls.Add(pt.PreviewForm)
        pt.ShowPreview()  'Just showing into a invisible panel
        pt.ClosePreview()
    End Sub

#Region "============Drag to move borderless form=============="
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub picBackground_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picBackground.MouseDown
        drag = True
        mouseX = Windows.Forms.Cursor.Position.X - Me.Left
        mouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub picBackground_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picBackground.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mouseY
            Me.Left = Windows.Forms.Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub picBackground_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picBackground.MouseUp
        drag = False
    End Sub

    Private Sub USER_PWD_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles USER_PWD.PreviewKeyDown
        If e.KeyCode = Keys.Enter And btnLogin.Enabled Then
            Call btnLogin_Click(USER_PWD, Nothing)
        End If
    End Sub




#End Region




End Class