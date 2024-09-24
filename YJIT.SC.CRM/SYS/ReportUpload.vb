
Public Class ReportUpload

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        If Common.IsDeploymentMode = False Then
            MsgBoxSC("This function only works in deployment mode!")  'Common.AppDeployUrl = "http://localhost:8085/WCF/Client/"   '
            Exit Sub
        End If

        Dim sClientId As String
        sClientId = Common.AppDeployUrl.Substring(Common.AppDeployUrl.IndexOf("/WCF/"))  'E.g: /WCF/Client1/

        Dim sFileName As String = txtLocalFullPath.Text.Substring(txtLocalFullPath.Text.LastIndexOf("\") + 1)
        Dim sFilePath As String = txtLocalFullPath.Text.Substring(0, txtLocalFullPath.Text.LastIndexOf("\") + 1)

        Dim sServerPath As String
        sServerPath = sClientId & "Bin/" & txtRemoteFile.Text   'e.g.: /WCF/Client/Bin/  + path
        sServerPath = sServerPath.Substring(0, sServerPath.LastIndexOf(sFileName)) 'Exclude file name from server path

        'Start upload process
        Dim sResult As String
        sResult = Common.UploadFile(sFilePath, sFileName, "?Flag=RPT&URI=" & sServerPath)

        If sResult <> "" Then
            MsgBoxSC("Report upload has been successfully!")
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Protected Overrides Sub ProcessUserFuncAuthorities(Optional ByVal parent As System.Windows.Forms.Control = Nothing)
        'MyBase.ProcessUserFuncAuthorities(parent)
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class