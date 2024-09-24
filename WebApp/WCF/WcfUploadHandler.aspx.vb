Imports System.IO
Imports System.Net
Imports System.Web

''' <summary>
''' File upload handler for WCF client
''' </summary>
''' <remarks>The max file size of upload file is specified in web.config -> httpRuntime -> maxRequestLength (default is 1024 KB)</remarks>
Partial Class WCF_WcfUploadHandler
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim flag = Request("Flag") & ""

        Select Case flag.ToUpper
            Case "ALL"
                processUploadALLFile()
            Case "FAQ"
                processUploadFAQFile()
            Case "RPT"
                Call processUploadReportFile()
            Case Else 'Default upload document
                Call processUploadEDMFile()
        End Select
    End Sub

    'Handling upload documents to EDM only
    Private Sub processUploadEDMFile()
        Dim sSuccessMsg As String = "Y"
        Dim sFailedMsg As String = "N"
        Try
            Dim sRelativePath As String = ""
            Dim sTmp As String = ""

            'Verify existence of Upload folder
            Dim sUploadPath As String = Server.MapPath(YJIT.WCF.ClientService.WCF_UPLOAD_DIR)
            If Not sUploadPath.EndsWith("\") Then sUploadPath &= "\"
            If Not IO.Directory.Exists(sUploadPath) Then
                IO.Directory.CreateDirectory(sUploadPath)
            End If

            'Get Year
            sTmp = Strings.Left(Now.ToString("yyyyMMddhhmmss"), 4)  ' YYYY
            sUploadPath &= sTmp & "\"
            sRelativePath &= sTmp & "/"
            If Not IO.Directory.Exists(sUploadPath) Then
                IO.Directory.CreateDirectory(sUploadPath)
            End If

            'Get Month
            sTmp = Strings.Mid(Now.ToString("yyyyMMddhhmmss"), 5, 2) ' MM
            sUploadPath &= sTmp & "\"
            sRelativePath &= sTmp & "/"
            If Not IO.Directory.Exists(sUploadPath) Then
                IO.Directory.CreateDirectory(sUploadPath)
            End If

            sTmp = Strings.Mid(Now.ToString("yyyyMMddhhmmss"), 7, 2) 'DD
            sUploadPath &= sTmp & "\"
            sRelativePath &= sTmp & "/"
            If Not IO.Directory.Exists(sUploadPath) Then
                IO.Directory.CreateDirectory(sUploadPath)
            End If


            'Store file into upload folder
            Dim f As String
            Dim file As HttpPostedFile
            Dim sFileSavedName As String
            For Each f In Request.Files.AllKeys
                file = Request.Files(f)
                sFileSavedName = file.FileName
                sFileSavedName = Now.ToString("yyyyMMddhhmmss") & "_" & file.FileName
                file.SaveAs(sUploadPath & sFileSavedName)

                'Return relative path to file
                sSuccessMsg &= vbCr & sRelativePath & sFileSavedName
                Exit For 'NOTE: Only support upload 1 file at a time
            Next f
            Response.Write(sSuccessMsg)
        Catch ex As Exception
            sFailedMsg &= vbCr & ex.Message & vbCr & ex.ToString
            Response.Write(sFailedMsg)
        End Try
        Response.End()
    End Sub

    'Handling Report's EURD only
    Private Sub processUploadReportFile()
        Dim sSuccessMsg As String = "Y"
        Dim sFailedMsg As String = "N"
        Try

            Dim sRelativePath As String = ""


            'Verify existence of Upload folder
            Dim sUploadPath As String = Request("URI")  'Must be provided via the submit URL

            sUploadPath = Server.MapPath(sUploadPath)   'Server absolute path

            If Not sUploadPath.EndsWith("\") Then sUploadPath &= "\"
            If Not IO.Directory.Exists(sUploadPath) Then
                IO.Directory.CreateDirectory(sUploadPath)
            End If


            'Store file into upload folder
            Dim f As String
            Dim file As HttpPostedFile
            Dim sFileSavedName As String
            For Each f In Request.Files.AllKeys
                file = Request.Files(f)
                sFileSavedName = file.FileName
                'sFileSavedName = Now.ToString("yyyyMMddhhmmss") & "_" & file.FileName
                file.SaveAs(sUploadPath & sFileSavedName)

                'Return relative path to file
                sSuccessMsg &= vbCr & sRelativePath & sFileSavedName
                Exit For 'NOTE: Only support upload 1 file at a time
            Next f
            Response.Write(sSuccessMsg)
        Catch ex As Exception
            sFailedMsg &= vbCr & ex.Message & vbCr & ex.ToString
            Response.Write(sFailedMsg)
        End Try
        Response.End()
    End Sub

    'Handling All files with dest path specified
    Private Sub processUploadALLFile()
        Dim sSuccessMsg As String = "Y"
        Dim sFailedMsg As String = "N"
        Try

            Dim sRelativePath As String = ""


            'Verify existence of Upload folder
            Dim sUploadPath As String = Request("URI")  'Must be provided via the submit URL

            sUploadPath = Server.MapPath(sUploadPath)   'Server absolute path

            If Not sUploadPath.EndsWith("\") Then sUploadPath &= "\"
            If Not IO.Directory.Exists(sUploadPath) Then
                IO.Directory.CreateDirectory(sUploadPath)
            End If


            'Store file into upload folder
            Dim f As String
            Dim file As HttpPostedFile
            Dim sFileSavedName As String
            For Each f In Request.Files.AllKeys
                file = Request.Files(f)
                sFileSavedName = file.FileName
                'sFileSavedName = Now.ToString("yyyyMMddhhmmss") & "_" & file.FileName
                file.SaveAs(sUploadPath & sFileSavedName)

                'Return relative path to file
                sSuccessMsg &= vbCr & sRelativePath & sFileSavedName
                Exit For 'NOTE: Only support upload 1 file at a time
            Next f
            Response.Write(sSuccessMsg)
        Catch ex As Exception
            sFailedMsg &= vbCr & ex.Message & vbCr & ex.ToString
            Response.Write(sFailedMsg)
        End Try
        Response.End()
    End Sub

    Private Sub processUploadFAQFile()
        Dim sSuccessMsg As String = "Y"
        Dim sFailedMsg As String = "N"
        Try

            Dim sRelativePath As String = ""


            'Verify existence of Upload folder
            Dim sUploadPath As String = Request("URI")  'Must be provided via the submit URL

            sUploadPath = Server.MapPath(sUploadPath)   'Server absolute path

            If Not sUploadPath.EndsWith("\") Then sUploadPath &= "\"
            If Not IO.Directory.Exists(sUploadPath) Then
                IO.Directory.CreateDirectory(sUploadPath)
            Else
                '폴더가 있으면 폴더내용 모두 삭제한다.
                IO.Directory.Delete(sUploadPath, True)
                IO.Directory.CreateDirectory(sUploadPath)
            End If


            'Store file into upload folder
            Dim f As String
            Dim file As HttpPostedFile
            Dim sFileSavedName As String
            For Each f In Request.Files.AllKeys
                file = Request.Files(f)
                sFileSavedName = file.FileName
                'sFileSavedName = Now.ToString("yyyyMMddhhmmss") & "_" & file.FileName
                file.SaveAs(sUploadPath & sFileSavedName)

                'Return relative path to file
                sSuccessMsg &= vbCr & sRelativePath & sFileSavedName
                Exit For 'NOTE: Only support upload 1 file at a time
            Next f
            Response.Write(sSuccessMsg)
        Catch ex As Exception
            sFailedMsg &= vbCr & ex.Message & vbCr & ex.ToString
            Response.Write(sFailedMsg)
        End Try
        Response.End()
    End Sub


End Class
