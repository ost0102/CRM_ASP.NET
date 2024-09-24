<%@ Application Language="VB" %>
<script runat="server">
    
    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        'Code that runs on application startup
        Dim appConfig = New YJIT.Config
        'Set the sql path
        'YJIT.Data.SqlBox.WorkingPath = Server.MapPath("/App_Data/Sql/")
        YJIT.Data.SqlBox.WorkingPath = Server.MapPath("/App_Data/PLSQL/")
    End Sub
    
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        'Code that runs on application shutdown
    End Sub
        
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when an unhandled error occurs
        'Error occurs may prevent re-login effort => We should destroy session until next time user must re-login again
        'Session.Abandon()
    End Sub

    
    Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As System.EventArgs)
        If (Request.IsAuthenticated() = False) Then
            'System.Diagnostics.Debug.WriteLine("FormAuthentication timeout!")
            If Request.Path = "/Handler.ashx" Then
                Response.Write("FormsAuthenticationTimeout")
                'Response.End()
                HttpContext.Current.ApplicationInstance.CompleteRequest()

            ElseIf Request.Path = "/FileUpload.ashx" Then
                Response.Write("FormsAuthenticationTimeout")
                'Response.End()
                HttpContext.Current.ApplicationInstance.CompleteRequest()
                
            ElseIf Request.Path = "/AsyncTaskHandler.ashx" Then
                Response.Write("FormsAuthenticationTimeout")
                'Response.End()
                HttpContext.Current.ApplicationInstance.CompleteRequest()
                
            Else
                'Let ASP.NET auto redirect to login page
            End If
        End If
    End sub
    
    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        'START NEW SESSION detected===========================
        'Code that runs whenever a new session is started 
        
        '=======Dectecting Session timeout based on new session event=======
        'This is obviously a new session being created; it can be created at the first hit of a user, or when the user
        'previous session has expired (timeout). We are only interested in the timeout scenario, so we look at the request cookies
        'and if we have a previous session ID cookie, it means this is a new session due to the timing out of the old one.
        'Note: slight problem here: in .Net 2.0 the ASP Session ID cookie name is configurable, but we don't have a way to
        'retrieve that from the web.config - so if you customize the session cookie name in the web.config you'll have to
        'use the same name here. Ref: http://www.abstraction.net/ViewArticle.aspx?articleID=74
        Dim request_cookies As String = Request.Headers("Cookie")
        
        If (request_cookies IsNot Nothing) AndAlso (request_cookies.IndexOf("ASP.NET_SessionId") >= 0) Then
            'SESSION TIMEOUT detected======================
            'cookie existed, so this new one is due to timeout.
	        'Redirect the user to the login page
	        'System.Diagnostics.Debug.WriteLine("Session timeout!")
	        
            If Request.Path = "/Handler.ashx" Then
                '1.1. Process ajax postback request
                Response.Write("SessionTimeout")
                'Response.End()
                HttpContext.Current.ApplicationInstance.CompleteRequest()

            ElseIf Request.Path = "/FileUpload.ashx" Then
                Response.Write("SessionTimeout")
                'Response.End()
                HttpContext.Current.ApplicationInstance.CompleteRequest()

            ElseIf Request.Path = "/AsyncTaskHandler.ashx" Then
                Response.Write("SessionTimeout")
                'Response.End()
                HttpContext.Current.ApplicationInstance.CompleteRequest()
                
            ElseIf Request.Path.ToUpper.Contains("/COMMON/OZRPT/POPOZRPT.ASPX") Then

            Else
                '1.2. Process GET request timeout. Can use 1 of 2 methods:
                'Method 1: Borrow this method from FormAuthentication
                If Request.Path.ToUpper.Contains("/LOGIN.ASPX") Then
                    'Allow to load this page
                ElseIf Request.Path.ToUpper.Contains("/LOGIN_YJADMIN.ASPX") Then
                
                Else
                    'Move to the login page
                    FormsAuthentication.RedirectToLoginPage()
                End If
                'Method 2: Or using generic Redirect method (with redirect parameter)
                'Response.Redirect("/Login.aspx?ReturnUrl=%2f" & Request.Url.ToString)
            End If
        End If
        
    End Sub
</script>