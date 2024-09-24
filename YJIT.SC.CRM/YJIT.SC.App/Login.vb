Imports System.Reflection

Public Class Login
    'This will be set to true from Logout process to show login form again
    Public IsBackFromLogout As Boolean = False

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'At firt, browse the homepage of server, which would redirect to the login page
        Dim sHomeUrl As String
        Dim sv As New YJIT.SC.WCF.SRBiz.BizServiceClient
        With sv.Endpoint.Address.Uri
            sHomeUrl = .Scheme & System.Uri.SchemeDelimiter & .Authority & "?WCF_LOGIN=Y"     'E.g: http://localhost:32434?WCF_LOGIN=Y
            If IsBackFromLogout Then
                sHomeUrl &= "&AUTO_LOGIN=false"
            End If
        End With
        wbMain.Navigate(sHomeUrl)

        lblLoading.SendToBack()
    End Sub

    Private Sub wbMain_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wbMain.DocumentCompleted
        'Check if the ID/Pass has been authrorized
        Dim sResult As String = wbMain.DocumentText.Trim
        'If user is validated -> the return will be in format: SUCCESS,User_id, Password
        If sResult.StartsWith("SUCCESS") Then
            wbMain.Hide()
            lblLoading.Update()
            Dim sParts() As String = sResult.Split(",")
            If sParts.Length = 3 Then
                'Successful pre-validate user id/password
                'Init the Client
                YJIT.SC.WCF.WCFBiz.Instance = New YJIT.SC.WCF.WCFBiz(sParts(1), sParts(2))

                ClientSessionInfo.StartLoginTime = Now()

                'Synchronize client-server session information
                Call Common.SynchronizeUserSessionInfo(sParts(1))

                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub


    Protected Overrides Sub ProcessUserFuncAuthorities(Optional parent As Control = Nothing)
        'NOTE:This is a special form that do not requires function authorities, otherwise, error occurs
        'MyBase.ProcessUserFuncAuthorities()
    End Sub


    Private Sub wbMain_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles wbMain.ProgressChanged
        ProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress)
        If e.CurrentProgress >= 0 And e.CurrentProgress < 100000 Then
            ProgressBar1.Value = Convert.ToInt32(Math.Min(e.CurrentProgress, 10000))
        End If
    End Sub


 
End Class
