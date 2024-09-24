Public Class SysSmartHelp_Upload
    Public ArlClientFiles As ArrayList
    Public Node As TreeNode

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub SysSmartHelp_Upload_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If ArlClientFiles Is Nothing OrElse Node Is Nothing Then
            MsgBoxSC("Please supply upload files list & treen node!")
            Me.Close()
        Else
            Call startUpload()
        End If
    End Sub

    Private Sub startUpload()
        Dim sResult As String = ""
        Dim nErrCount As Integer = 0
        Dim sLogMsg As String = ""

        'Init progress bar
        pbMain.Maximum = ArlClientFiles.Count
        pbMain.Minimum = 0


        Dim sFileFullPath As String
        Dim sFilePath As String
        Dim sFileName As String

        For i As Integer = 0 To ArlClientFiles.Count - 1

            'Reflect data progress
            txtInfo.Text = "Uploading..: " & ArlClientFiles(i)
            Me.Update()

            sFileFullPath = ArlClientFiles(i).ToString
            sFilePath = sFileFullPath.Substring(0, sFileFullPath.LastIndexOf("\") + 1)
            sFileName = sFileFullPath.Substring(sFileFullPath.LastIndexOf("\") + 1)

            sResult = Common.UploadFile(sFilePath, sFileName, "?Flag=ALL&URI=/WCF/SmartHelp/Data/" & Node.Tag("NODE_ID") & "_files/")
            If sResult = String.Empty Then
                'Error count
                nErrCount += 1
            End If

            'Reflect data progress
            pbMain.Value = i + 1
            Me.Update()

        Next

        If nErrCount > 0 Then
            lblTotalResult.Text = "Upload done with " & nErrCount & " files failed! Please check action logs!"
        End If

        lblTotalResult.Visible = True
        btnCreate.Enabled = True

    End Sub

End Class