Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Public Class EvbStmpUpload
    Public result As String = ""
    Dim mouse_x As Integer = 0
    Dim mouse_Y As Integer = 0
#Region "=================Data logic actions==========="
    Public Sub DialSetbound(ByVal x As Integer, ByVal y As Integer)
        mouse_x = x
        mouse_Y = y
    End Sub
    'Grid View Sequence 표시 함수
    Private Sub SetGridViewSequence(ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Dim rowIndex As Integer = e.RowHandle

        e.Info.DisplayText = "No"

        If rowIndex >= 0 Then
            rowIndex += 1
            e.Info.DisplayText = rowIndex.ToString()
        End If

        e.Info.ImageIndex = -1
    End Sub
    Public Sub FileSearch()
        Dim filePath As String = ""
        Dim ds As DataSet
        Dim Dialog As OpenFileDialog = New OpenFileDialog()
        Dim FileInfo As System.IO.FileInfo

        Dialog.Title = "Logo Image Search"
        'Dialog.InitialDirectory = "c:\"
        Dialog.FilterIndex = 1
        Dialog.RestoreDirectory = True
        Dialog.Multiselect = True
        Dialog.Filter = "JPEG (*.jpg)|*.jpg"

        If Dialog.ShowDialog() = DialogResult.OK Then
            LOCAL_FILE_PATH.Text = Dialog.FileName
            PictureBox1.Image = Image.FromFile(Dialog.FileName)
            FILE_SIZE.Text = New FileInfo(Dialog.FileName).Length

            FileInfo = My.Computer.FileSystem.GetFileInfo(LOCAL_FILE_PATH.Text)
            LOCAL_FILE_PATH.Text = My.Computer.FileSystem.CombinePath(FileInfo.DirectoryName, FileInfo.Name)
        End If
    End Sub

    Public Sub SaveData()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim dt As DataTable

        If LOCAL_FILE_PATH.Text = "" Then
            MsgBoxLocalized("File Path is empty!", MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo, Me.Text, MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        '먼저 서버에 업로드
        result = UploadLogo()
        'Me.Close()
    End Sub
    Private Function UploadLogo() As String
        Try
            Dim sClientId As String
            'sClientId = Common.AppDeployUrl.Substring(Common.AppDeployUrl.IndexOf("/WCF/"))  'E.g: /WCF/Client1/
            'sClientId = "/WCF/Client/"
            sClientId = ""
            Dim sFileName As String = LOCAL_FILE_PATH.Text.Substring(LOCAL_FILE_PATH.Text.LastIndexOf("\") + 1)
            Dim sFilePath As String = LOCAL_FILE_PATH.Text.Substring(0, LOCAL_FILE_PATH.Text.LastIndexOf("\") + 1)
            Dim sServerPath As String
            sServerPath = SERVER_FILE_PATH.Text   'e.g.: /WCF/Client/Bin/  + path
            sServerPath = sServerPath.Substring(0, sServerPath.LastIndexOf("Logo.jpg")) 'Exclude file name from server path

            '20190401 김성은 Logo.jpg 파일로 변경후 업로드처리
            Dim tempFolder As String = Application.StartupPath & "\TMP_OUTPUT\"
            If Not IO.Directory.Exists(tempFolder) Then
                IO.Directory.CreateDirectory(tempFolder)
            End If
            If IO.File.Exists(tempFolder & "Logo.jpg") Then
                IO.File.Delete(tempFolder & "Logo.jpg")
            End If
            IO.File.Copy(sFilePath & sFileName, tempFolder & "Logo.jpg")

            'Start upload process
            Dim sResult As Boolean
            'sResult = Common.FileUpload(tempFolder, "Logo.jpg", "?Flag=RPT&URI=" & sServerPath)
            sResult = Common.FileUploadElvisBill(sFilePath & sFileName, USER_AUTH_ID.Text.ToString, "/NAS_USER/")

            If sResult = True Then
                MsgBoxSC("Logo upload has been successfully!")
                Me.Close()
            End If

            Return sFileName
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Function
#End Region
#Region "=================Control Events==========="
    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        'result = "Y"
        result = ""
        Call SaveData()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'result = "N"
        Me.Close()
    End Sub
    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        Call FileSearch()
    End Sub
    Private Sub GV1_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Call SetGridViewSequence(e)
    End Sub
    Private Sub MdmLogoUpload_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim sReportFile As String = "\Client\Bin\RPT\Image\" & Common.SavedSessionDomain & "\Logo.jpg"
        sReportFile = sReportFile.Substring(sReportFile.IndexOf("\Client\Bin\RPT\"))


        Dim sSeverPath As String = sReportFile.Substring(sReportFile.IndexOf("\Client\Bin\RPT\") + 1).Replace("\", "/") 'E.g: RPT/SEA/BL_FORM/

        SERVER_FILE_PATH.Text = sSeverPath 'For use during upload

        TextBox1.Text = Common.SavedUserId & " / " & Common.SavedUserState
        TextBox2.Text = Common.SavedUserPwd
    End Sub
#End Region
End Class