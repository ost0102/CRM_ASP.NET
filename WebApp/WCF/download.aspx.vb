Imports System.IO
Imports System.Net
Imports System.Web

''' <summary>
''' File upload handler for WCF client
''' </summary>
''' <remarks>The max file size of upload file is specified in web.config -> httpRuntime -> maxRequestLength (default is 1024 KB)</remarks>
Partial Class download
    Inherits System.Web.UI.Page

    Private Const WCF_DOWNLOAD_TEMP As String = "/WCF/UploadFiles/"

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sSuccessMsg As String = "Y"
        Dim sFailedMsg As String = "N"
        Dim file As HttpPostedFile

        Try
            Dim sDploadPath As String = Server.MapPath(WCF_DOWNLOAD_TEMP)

            For Each f In Request.Files.AllKeys
                file = Request.Files(f)
                Dim fileInfo() As String = Split(file.FileName, "file_Info_")
                Dim fileName As String = fileInfo(0)
                Dim filepath As String = fileInfo(1).Replace("Folder_", "\")
                Dim savePath As String = fileInfo(2).Replace("Dir_", ":\").Replace("Folder_", "\")
                If My.Computer.FileSystem.FileExists(savePath & fileName) Then
                    My.Computer.FileSystem.DeleteFile(savePath & fileName)
                End If
                Dim downPath As String = sDploadPath & filepath & fileName

                My.Computer.Network.DownloadFile _
                    (downPath, savePath & fileName)
            Next f

            ' Response.Write(sSuccessMsg)
        Catch ex As Exception
            sFailedMsg &= vbCr & ex.Message & vbCr & ex.ToString
            '   Response.Write(sFailedMsg)
        End Try

        '   Response.End()
    End Sub
End Class
