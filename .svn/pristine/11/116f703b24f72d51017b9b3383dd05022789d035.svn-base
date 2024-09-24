Public Class SysHelpUpload
    Public ArlClientFiles As ArrayList
    Public NodeId As String
    Public Source As String

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

    Private Sub SysHelpUpload_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If ArlClientFiles Is Nothing Then
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
        Dim flag As String
        For i As Integer = 0 To ArlClientFiles.Count - 1

            'Reflect data progress
            txtInfo.Text = "Uploading..: " & ArlClientFiles(i)
            Me.Update()

            If i = 0 Then
                flag = "FAQ"
            Else
                flag = "ALL"
            End If
            sFileFullPath = ArlClientFiles(i).ToString
            sFilePath = sFileFullPath.Substring(0, sFileFullPath.LastIndexOf("\") + 1)
            sFileName = sFileFullPath.Substring(sFileFullPath.LastIndexOf("\") + 1)
            '20240314 김정현 소스 버전에 따라 파일 업로드 경로 분리
            'sResult = Common.UploadFile(sFilePath, sFileName, "?Flag=ALL&URI=/WCF/FAQ/Data/" & NodeId & "_files/")
            Select Case Source
                Case "01"
                    sResult = Common.UploadFile(sFilePath, sFileName, "?Flag=" & flag & "&URI=/WCF/FAQ/Data/" & NodeId & "_files/")
                Case "07"
                    sResult = Common.UploadFile(sFilePath, sFileName, "?Flag=" & flag & "&URI=/WCF/FAQ21/Data/" & NodeId & "_files/")
            End Select
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