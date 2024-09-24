Imports System.IO
Imports System.Net
Imports System.Web

''' <summary>
''' File upload handler for WCF client
''' </summary>
''' <remarks>The max file size of upload file is specified in web.config -> httpRuntime -> maxRequestLength (default is 1024 KB)</remarks>
Partial Class UploadHandler
    Inherits System.Web.UI.Page

    Private Const WCF_UPLOAD_TEMP As String = "/WCF/Client/Bin/"
    Dim time As String = ""

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sSuccessMsg As String = "Y"
        Dim sFailedMsg As String = "N"
        '  Dim fullPath As String = ""
        Dim time As String = ""
        Dim path As String = ""
        Dim FileLength As String = ""
        Dim sFileSavedName As String = ""
        Try

 
            Dim f As String
            Dim file As HttpPostedFile
            Dim s As String



            For Each s In Request.QueryString.AllKeys
                '  s = Request.QueryString(s)
                If s = "Time" Then
                    time = Request.QueryString(s)
                ElseIf s = "SavePath" Then 
                    path = HttpContext.Current.Server.MapPath(Request.QueryString(s))
                ElseIf s = "AbsolutePath" Then 
                    path = Request.QueryString(s)
                ElseIf s = "FileLength" Then
                    FileLength = Request.QueryString(s)
                End If
            Next
            For Each f In Request.Files.AllKeys
                file = Request.Files(f)

                sFileSavedName = file.FileName

                '        fullPath = path 'sUploadPath&
                If Not FileIO.FileSystem.DirectoryExists(path) Then
                    FileIO.FileSystem.CreateDirectory(path)
                End If
                If FileIO.FileSystem.FileExists(path & sFileSavedName) Then
                    FileIO.FileSystem.DeleteFile(path & sFileSavedName)
                End If
                ' 저장 처리
                file.SaveAs(path & sFileSavedName)
                If Trim(time) <> "" Then
                    IO.File.SetLastWriteTime(path & sFileSavedName, CDate(time))
                End If

                'If FileLength = FileIO.FileSystem.GetFileInfo(fullPath & sFileSavedName).Length.ToString Then
                sSuccessMsg &= vbCr & sFileSavedName
                Response.Write(sSuccessMsg)
                'Else
                '    sFailedMsg &= vbCr & sFileSavedName & " 파일 업로드를 처리 하지 못했습니다. 다시 시도 해주세요."
                '    If FileIO.FileSystem.FileExists(fullPath & sFileSavedName) Then
                '        FileIO.FileSystem.DeleteFile(fullPath & sFileSavedName)
                '    End If
                '    Response.Write(sFailedMsg)
                'End If

            Next f

        Catch ex As Exception
            sFailedMsg &= vbCr & sFileSavedName & " 파일 업로드를 처리 하지 못했습니다. 다시 시도 해주세요." & path & sFileSavedName
            If FileIO.FileSystem.FileExists(path & sFileSavedName) Then 
                FileIO.FileSystem.DeleteFile(path & sFileSavedName)
            End If
            Response.Write(sFailedMsg)
        End Try

        Response.End()
    End Sub

End Class
