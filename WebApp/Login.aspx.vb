Imports System.Data
Imports YJIT
Imports System.Net

''' <summary>
''' Login screen which is also used for relogin and logout
''' </summary>
''' <remarks>In case of FormAuthentication timeout, only this screen have access to resources in web root (as configured in web.config)</remarks>
Partial Public Class Login
    Inherits YJIT.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

        '*************************************
        ' Decide the screen mode
        '*************************************
        Me.FIRST_LOGIN_BLOCK.Style("display") = "none"
        Me.LOGOUT_BLOCK.Style("display") = "none"
        Me.RE_LOGIN_BLOCK.Style("display") = "none"
        txtDomain.Text = "POLARIS.COM"

        Dim sMode As String = Request("Mode")
        Select Case sMode
            Case "RELOGIN"
                Me.RE_LOGIN_BLOCK.Style("display") = ""
                Me.PageTitle.Text = "Re-Login"
            Case "LOGOUT"
                Me.LOGOUT_BLOCK.Style("display") = ""
                Me.PageTitle.Text = "Logout Confirm"
            Case Else   'Default is LOGIN
                Me.FIRST_LOGIN_BLOCK.Style("display") = ""
                Me.txtUsername.Focus()
        End Select
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sUserID As String
        Dim sPassWord As String

        If IsPostBack Then
            'Postback FIRST_LOGIN/RELOGIN mode
            If txtUsername.Text <> "" Then
                sUserID = txtUsername.Text.Trim.ToUpper
                sPassWord = txtPassword.Text.Trim.ToUpper
                Login(sUserID, sPassWord, txtDomain.Text.Trim)
                If chkRememberMe.Checked Then
                    Dim cookieRemember As New HttpCookie("YJIT.SC.FMS")
                    cookieRemember.Values.Add("Domain", txtDomain.Text)
                    cookieRemember.Values.Add("User", txtUsername.Text)
                    cookieRemember.Values.Add("Password", txtPassword.Text)
                    Response.Cookies.Add(cookieRemember)
                End If
            End If
            If txtReUsername.Text <> "" Then
                'Process re-login if user ID is provided
                sUserID = txtReUsername.Text.Trim.ToUpper
                sPassWord = txtRePassword.Text.Trim.ToUpper
                processRelogin(sUserID, sPassWord)
            End If

            'Process logout when it is confirm
            If Request("Mode") = "LOGOUT" Then
                processLogout()

            End If
        Else
            If Request.Cookies("YJIT.SC.FMS") IsNot Nothing Then
                Dim cookieRemember As HttpCookie = Request.Cookies.Get("YJIT.SC.FMS")
                txtDomain.Text = cookieRemember.Values("Domain")
                txtUsername.Text = cookieRemember.Values("User")
                txtPassword.Attributes.Add("value", cookieRemember.Values("Password"))
                If (txtDomain.Text <> "" AndAlso txtUsername.Text <> "") Then
                    chkRememberMe.Checked = True
                End If
            End If
        End If
    End Sub

    Protected Sub processLogin(ByVal sUserID As String, ByVal sPassword As String)

        Try
            Select Case YJIT.SessionInfo.AuthenticateUser(sUserID, sPassword, YJIT.Config.UseEncPass)
                Case LoginResult.Successful
                    'Authorize valid user
                    Try
                        YJIT.SessionInfo.AuthorizeUser(sUserID)
                    Catch ex As Exception
                        lblMessage.Text = ex.Message
                        LOGIN_STATUS.Value = "FAIL"
                        Return
                    End Try
                    '.NET will automatically redirect user to whichever page they were trying to access
                    If Request("RELOGIN") = "Y" Then
                        lblMessage.Text = "Successfully re-logged in !"
                    ElseIf Request("WCF_LOGIN") = "Y" Then      'Login from WCF client
                        'The WCF login division must process this return data
                        Response.Write("SUCCESS" & "," & sUserID & "," & sPassword)
                        Response.End()
                    Else    'Asp.net webform login
                        FormsAuthentication.RedirectFromLoginPage(sUserID, False)

                        ' REDIRECT USER TO CUSTOMER DEFAULT PAGE
                        'FormsAuthentication.SetAuthCookie(sUserID, False)
                        'Server.Transfer(YJIT.SessionAuth.HomePageUrl)

                    End If
                    LOGIN_STATUS.Value = "SUCCESS"

                Case LoginResult.UserClosed
                    lblMessage.Text = "User has been closed!"
                    LOGIN_STATUS.Value = "FAIL"
                    txtUsername.Focus()
                Case LoginResult.UserNotFound
                    lblMessage.Text = "User is not found!"
                    LOGIN_STATUS.Value = "FAIL"
                    txtUsername.Focus()
                Case LoginResult.WrongPassword
                    lblMessage.Text = "Password is incorrect!"
                    LOGIN_STATUS.Value = "FAIL"
                Case Else
                    lblMessage.Text = "Login failed! Unknown reason!"
                    chkSignMeAuto.Checked = False
                    txtUsername.Focus()
            End Select
        Catch ex As Exception
            lblMessage.Text = "Exception occurred while log in! " & ex.Message
            chkSignMeAuto.Checked = False
            LOGIN_STATUS.Value = "FAIL"
        End Try
    End Sub

    Protected Sub processLogin(ByVal sUserID As String, ByVal sPassword As String, ByVal sDomain As String)

        Dim BIZ As YJIT.WCF.BizService = New YJIT.WCF.BizService()
        Dim dtLoginInfo As DataTable = New DataTable()

        Dim dsParams As DataSet = New DataSet()
        Dim dsResult As DataSet = New DataSet()
        Dim drPairs As DataRow
        dtLoginInfo.Columns.Add("USERID")
        dtLoginInfo.Columns.Add("PASSWORD")
        dtLoginInfo.Columns.Add("DOMAIN")

        dtLoginInfo.TableName = "WCF_CLIENT_INFO"
        dtLoginInfo.Rows.Add(sUserID, sPassword, sDomain)
        dsParams.Tables.Add(dtLoginInfo)


        Try
            dsResult = BIZ.MethodCall("YJIT.Biz", "RequestLogin", dsParams)
            drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)


            If drPairs("TrxCode") = "SUCCESS" Then
                Try
                    YJIT.SessionInfo.AuthorizeUser(sUserID)
                Catch ex As Exception
                    lblMessage.Text = ex.Message
                    LOGIN_STATUS.Value = "FAIL"
                    Return
                End Try
                If Request("RELOGIN") = "Y" Then
                    lblMessage.Text = "Successfully re-logged in !"
                ElseIf Request("WCF_LOGIN") = "Y" Then
                    Response.Write("SUCCESS" & "," & sUserID & "," & sPassword)
                    Response.End()
                Else
                    FormsAuthentication.RedirectFromLoginPage(sUserID, False)
                End If
                Response.Redirect(SessionInfo.AspxDefaultPage)
                LOGIN_STATUS.Value = "SUCCESS"
            Else
                lblMessage.Text = drPairs("TrxMsg")
                LOGIN_STATUS.Value = "FAIL"
                txtUsername.Focus()
            End If

        Catch ex As Exception
            lblMessage.Text = "Exception occurred while log in! " & ex.Message
            chkSignMeAuto.Checked = False
            LOGIN_STATUS.Value = "FAIL"
        End Try

    End Sub

    Protected Sub Login(ByVal sUserID As String, ByVal sPassword As String, ByVal sDomain As String)
        Dim BIZ As YJIT.WCF.BizService = New YJIT.WCF.BizService()
        Dim dsResult As DataSet = New DataSet()
        Dim drPairs As DataRow
        Try
            dsResult = BIZ.ExternalLogin(createDBDataTable(sUserID, sPassword, sDomain))
            drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

            If drPairs("TrxCode") = "SUCCESS" Then
                If CheckAddress(Request.Url.ToString) Then
                    FormsAuthentication.RedirectFromLoginPage(sUserID, False)
                Else
                    If (SessionInfo.AspxDefaultPage = "") Then
                        Response.Redirect(FormsAuthentication.DefaultUrl)
                    Else
                        Response.Redirect(SessionInfo.AspxDefaultPage)
                    End If
                End If
            End If

            LOGIN_STATUS.Value = drPairs("TrxCode")
            lblMessage.Text = drPairs("TrxMsg")

        Catch ex As Exception
            lblMessage.Text = "Exception occurred while log in! " & ex.Message
            chkSignMeAuto.Checked = False
            LOGIN_STATUS.Value = "FAIL"
        End Try
    End Sub

    Public Function createDBDataTable(ByVal sUserID As String, ByVal sPassword As String, ByVal sDomain As String) As DataSet

        Dim dtLoginInfo As DataTable = New DataTable()

        dtLoginInfo.Columns.Add("USERID")
        dtLoginInfo.Columns.Add("PASSWORD")
        dtLoginInfo.Columns.Add("DOMAIN")

        dtLoginInfo.TableName = "WCF_CLIENT_INFO"
        dtLoginInfo.Rows.Add(sUserID, sPassword, sDomain)

        Dim dsParams As DataSet = New DataSet()
        dsParams.Tables.Add(dtLoginInfo)

        Return dsParams

    End Function

    Protected Sub processRelogin(ByVal sUserID As String, ByVal sPassword As String)
        Try

            lblRE_LOGIN_FAILED.Style("display") = ""
            Select Case YJIT.SessionInfo.AuthenticateUser(sUserID, sPassword, YJIT.Config.UseEncPass)
                Case LoginResult.Successful
                    'Authorize valid user
                    Try
                        YJIT.SessionInfo.AuthorizeUser(sUserID)
                        lblRE_LOGIN_FAILED.Style("display") = "none"
                        lblRE_LOGIN_DONE.Style("display") = ""
                        RE_LOGIN_UI.Style("display") = "none"
                        RE_LOGIN_DONE.Style("display") = ""
                        lblRE_LOGIN_DONE.Text = "Re-login successfully! Moving back to work..."
                        FormsAuthentication.SetAuthCookie(sUserID, False)
                    Catch ex As Exception
                        lblRE_LOGIN_FAILED.Text = ex.Message
                        LOGIN_STATUS.Value = "FAIL"
                        Return
                    End Try
                    LOGIN_STATUS.Value = "SUCCESS"
                Case LoginResult.UserClosed
                    lblRE_LOGIN_FAILED.Text = "User has been closed!"
                    LOGIN_STATUS.Value = "FAIL"
                Case LoginResult.UserNotFound
                    lblRE_LOGIN_FAILED.Text = "User is not found!"
                    LOGIN_STATUS.Value = "FAIL"
                Case LoginResult.WrongPassword
                    lblRE_LOGIN_FAILED.Text = "Password is incorrect!"
                    LOGIN_STATUS.Value = "FAIL"
                Case Else
                    lblRE_LOGIN_FAILED.Text = "Login failed! Unknown reason!"
                    LOGIN_STATUS.Value = "FAIL"
            End Select
        Catch ex As Exception
            lblRE_LOGIN_FAILED.Text = "Exception occurred while log in! " & ex.Message
            chkSignMeAuto.Checked = False
            LOGIN_STATUS.Value = "FAIL"
        End Try

    End Sub

    Protected Sub processLogout()
        FormsAuthentication.SignOut()
        Session.Abandon()
        LOGOUT_CONFIRM_UI.Style("display") = "none"
        LOGOUT_DONE.Style("display") = ""
        lblLOGOUT_DONE.Text = "Logout successful! Moving out..."
    End Sub

    Public Function CheckAddress(ByVal URL As String) As Boolean
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim response As WebResponse = request.GetResponse()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

End Class
