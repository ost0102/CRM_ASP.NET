Imports System.Data
Imports YJIT
Imports System.Net

''' <summary>
''' Login screen which is also used for relogin and logout
''' </summary>
''' <remarks>In case of FormAuthentication timeout, only this screen have access to resources in web root (as configured in web.config)</remarks>
Partial Public Class Tracing_login
    Inherits YJIT.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

        '*************************************
        ' Decide the screen mode
        '*************************************

        Dim sMode As String = Request("Mode")
        Me.FIRST_LOGIN_BLOCK.Style("display") = ""
        Me.txtUsername.Focus()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sUserID As String
        Dim sPassWord As String

        If IsPostBack Then
            'Postback FIRST_LOGIN/RELOGIN mode
            If txtUsername.Text <> "" Then
                sUserID = txtUsername.Text.Trim.ToUpper
                sPassWord = txtPassword.Text.Trim.ToUpper
                'Login(sUserID, sPassWord, "POLARIS.COM")
              
            End If
        Else
            If Request.Cookies("YJIT.SC.FMS") IsNot Nothing Then
                Dim cookieRemember As HttpCookie = Request.Cookies.Get("YJIT.SC.FMS")
                txtUsername.Text = cookieRemember.Values("User")
                txtPassword.Attributes.Add("value", cookieRemember.Values("Password"))

            End If
        End If
    End Sub

    Protected Sub processLogin(ByVal sUserID As String, ByVal sPassword As String, ByVal sDomain As String, Optional ByVal directUri As String = "")

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

                If directUri.Trim <> "" Then
                    Response.Redirect(directUri)
                Else
                    Response.Redirect(SessionInfo.AspxDefaultPage)
                End If

                LOGIN_STATUS.Value = "SUCCESS"
            Else
                lblMessage.Text = drPairs("TrxMsg")
                LOGIN_STATUS.Value = "FAIL"
                txtUsername.Focus()
            End If

        Catch ex As Exception
            lblMessage.Text = "Exception occurred while log in! " & ex.Message
            LOGIN_STATUS.Value = "FAIL"
        End Try

    End Sub

    Protected Sub Login(ByVal sUserID As String, ByVal sPassword As String, ByVal sDomain As String, Optional ByVal directUri As String = "")
        Dim BIZ As YJIT.WCF.BizService = New YJIT.WCF.BizService()
        Dim dsResult As DataSet = New DataSet()
        Dim drPairs As DataRow
        Try
            dsResult = BIZ.ExternalLogin(createDBDataTable(sUserID, sPassword, sDomain))
            drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

            If drPairs("TrxCode") = "SUCCESS" Then
                
                FormsAuthentication.RedirectFromLoginPage(sUserID, True)

                If directUri.Trim <> "" Then
                    Session("TrcCargoSrch." & sUserID & ".SearchType") = CNTR_HBL_TYPE.SelectedValue.ToString.Trim
                    Session("TrcCargoSrch." & sUserID & ".SearchNo") = CNTR_HBL_NO.Text.Trim
                    Response.Redirect(directUri)
                Else

                    If Request.QueryString("ReturnUrl") <> Nothing Then
                        If Request.QueryString("ReturnUrl").Contains("tracing_login.aspx") Then
                            Response.Redirect(FormsAuthentication.DefaultUrl)
                            Exit Sub
                        End If
                    End If
                    If UrlExists(SessionInfo.AspxDefaultPage) Then
                        Response.Redirect(SessionInfo.AspxDefaultPage)
                    End If
                End If

            End If

            LOGIN_STATUS.Value = drPairs("TrxCode")
            lblMessage.Text = drPairs("TrxMsg")

        Catch ex As Exception
            lblMessage.Text = "Exception occurred while log in! " & ex.Message
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

    Public Function CheckAddress(ByVal URL As String) As Boolean
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim response As WebResponse = request.GetResponse()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Protected Sub btnSearch_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnSearch.Click
        Call Login("GUEST", "GUEST", "POLARIS.COM", "/TRC/TrcCargoSrch.aspx")
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnLogin.Click
        Call Login(txtUsername.Text.Trim, txtPassword.Text.Trim, "POLARIS.COM")
    End Sub

    Public Function UrlExists(ByVal url As String) As Boolean
        Try
            Dim request As HttpWebRequest = WebRequest.Create(url)
            If IsNothing(request) Then Return False
            request.Method = "HEAD"
            Using response As Object = TryCast(request.GetResponse, HttpWebResponse)
                Return response.StatusCode = HttpStatusCode.OK
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
