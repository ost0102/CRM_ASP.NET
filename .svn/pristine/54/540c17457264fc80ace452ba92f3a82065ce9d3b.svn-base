Public Class SysSmartHelpViewer

    Public HomeURI As String

    Private Sub SysSmartHelpViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        wbMain.IsWebBrowserContextMenuEnabled = False
        wbMain.AllowWebBrowserDrop = False
    End Sub

    Private Sub SysSmartHelpViewer_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If HomeURI = "" Then
            HomeURI = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "SmartHelp/HelpViewer.aspx"
        End If
        wbMain.Navigate(HomeURI)
    End Sub

End Class