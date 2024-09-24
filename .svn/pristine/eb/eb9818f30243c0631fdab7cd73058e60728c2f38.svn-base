Imports System.Collections.Generic

Partial Class WCF_Client_Manifest
    Inherits System.Web.UI.Page

    Protected dicFileManifest As New Dictionary(Of String, String)
    Protected dicFileModifiedDate As New Dictionary(Of String, String)
    Protected dicFileManifestComments As New Dictionary(Of String, String)
    Protected dicFileAuthor As New Dictionary(Of String, String)

    Protected commentFile As String = "ManifestComments.txt"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Prepare the manifest dictionary of files
        Call loadFileManifest()
        Call loadFileManifestComments()

        If Request("Mode") = "Edit" Then
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Handle manifest comment editing
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Page.IsPostBack Then

                For Each key As String In dicFileManifest.Keys
                    dicFileManifestComments(key) = Request("c_" & key)
                    dicFileAuthor(key) = Request("a_" & key)
                Next
                Call saveFileManifestComments()
            End If

            'Displaying the editing form

        Else
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Write manifest to client
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Call responseFileManifest()
        End If
    End Sub

    Private Sub loadFileManifest()
        'Generate the mannifest of files in current folder
        Dim currentPath As String = Server.MapPath(Request.ServerVariables("PATH_INFO"))
        currentPath = Left(currentPath, currentPath.LastIndexOf("\") + 1)

        Dim files() As String = System.IO.File.ReadAllLines(currentPath & "\PreManifest.txt")
        Dim sModifiedDate As String
        Dim sSubUrl As String
        Dim sVersion As String
        Dim dSize As Double
        Dim items() As String

        For Each sFile As String In files

            items = sFile.Split(",")

            sSubUrl = trim(items(0))
            dSize = trim(items(1))
            sModifiedDate = trim(items(2))
            sVersion = trim(items(3))

            If Request("SingleFileURI") <> "" Then
                '================WHEN UPDATE FILE IN RUNTIME MODE============================'
                'In this mode, if file ID has found => just return one file only
                Dim locFile As String = Request("SingleFileURI").ToUpper()
                Dim prfix As String = ""
                If sSubUrl.Contains("/") Then prfix = "/"
                If (locFile = sSubUrl.ToUpper()) OrElse
                    (Not locFile.Contains("/") AndAlso sSubUrl.ToUpper().EndsWith(prfix & locFile)) Then
                    dicFileManifest(sSubUrl) = sSubUrl & "," & dSize & "," & sModifiedDate & "," & sVersion
                    dicFileModifiedDate(sSubUrl) = sModifiedDate
                    dicFileManifestComments(sSubUrl) = ""
                    dicFileAuthor(sSubUrl) = ""
                    Exit For  'Only return one file info
                End If
            Else
                'Assign to a global dictionary
                dicFileManifest(sSubUrl) = sSubUrl & "," & dSize & "," & sModifiedDate & "," & sVersion
                dicFileModifiedDate(sSubUrl) = sModifiedDate
                dicFileManifestComments(sSubUrl) = ""
                dicFileAuthor(sSubUrl) = ""
            End If
        Next

    End Sub

    Private Sub loadFileManifest_BackUp()
        'Generate the mannifest of files in current folder
        Dim currentPath As String = Server.MapPath(Request.ServerVariables("PATH_INFO"))
        currentPath = Left(currentPath, currentPath.LastIndexOf("\") + 1)

        currentPath = currentPath & "Bin\"                  'e.g.: D:\...\WCF\Bin\

        Dim sBaseUrl As String = Request.ServerVariables("URL")
        sBaseUrl = Left(sBaseUrl, sBaseUrl.LastIndexOf("/") + 1)                   'e.g.: /WCF/Client/Modules/


        Dim files() As String = System.IO.Directory.GetFiles(currentPath, "*.*", System.IO.SearchOption.AllDirectories)

        Dim sModifiedDate As String
        Dim sSubUrl As String
        Dim sVersion As String
        Dim dSize As Double

        For Each sFile As String In files
            'not exclude file types
            'If Not (sFile.ToUpper.EndsWith(".DLL") OrElse sFile.ToUpper.EndsWith(".EXE") OrElse sFile.ToUpper.EndsWith(".REPX")) OrElse sFile.ToUpper.EndsWith(".CONFIG") Then Continue For
            'Exclude svn files
            If sFile.Contains("\.svn\") Then Continue For

            'Extract file information
            Dim fi As System.IO.FileInfo = New System.IO.FileInfo(sFile)
            sModifiedDate = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")
            sSubUrl = sFile.Remove(0, currentPath.Length).Replace("\", "/")


            sVersion = "N/A"

            'Get File size
            dSize = fi.Length

            If Request("SingleFileURI") <> "" Then
                '================WHEN UPDATE FILE IN RUNTIME MODE============================'
                'In this mode, if file ID has found => just return one file only

                Dim locFile As String = Request("SingleFileURI").ToUpper()
                Dim prfix As String = ""

                If sSubUrl.Contains("/") Then prfix = "/"

                If (locFile = sSubUrl.ToUpper()) OrElse
                    (Not locFile.Contains("/") AndAlso sSubUrl.ToUpper().EndsWith(prfix & locFile)) Then
                    dicFileManifest(sSubUrl) = sSubUrl & "," & dSize & "," & sModifiedDate & "," & sVersion
                    dicFileModifiedDate(sSubUrl) = sModifiedDate
                    dicFileManifestComments(sSubUrl) = ""
                    dicFileAuthor(sSubUrl) = ""
                    Exit For  'Only return one file info
                End If
            Else
                'Assign to a global dictionary
                dicFileManifest(sSubUrl) = sSubUrl & "," & dSize & "," & sModifiedDate & "," & sVersion
                dicFileModifiedDate(sSubUrl) = sModifiedDate
                dicFileManifestComments(sSubUrl) = ""
                dicFileAuthor(sSubUrl) = ""
            End If
            'Response.Write(sSubUrl & "," & dSize & "," & sModifiedDate & "," & sVersion & vbCrLf)
        Next

    End Sub

    Private Sub loadFileManifestComments()
        'Generate the mannifest of files in current folder
        Dim currentPath As String = Server.MapPath(Request.ServerVariables("PATH_INFO"))
        currentPath = Left(currentPath, currentPath.LastIndexOf("\") + 1)

        If Not System.IO.File.Exists(currentPath & commentFile) Then
            Try
                System.IO.File.CreateText(currentPath & commentFile).Close()
            Catch ex As Exception
                Response.Write("Could not create file " & currentPath & commentFile & "! Please make sure file exists with write permission to everyone!")
                Response.End()
            End Try
        End If

        Dim sr As New IO.StreamReader(currentPath & commentFile)
        Dim sLine As String
        Dim sPendingLine As String = ""

        Dim sFileID As String
        Dim sFileComment As String
        Dim sFileAuthor As String
        Dim sFileModifiedData As String

        While sr.Peek() >= 0
            sFileID = ""
            sFileAuthor = ""
            sFileComment = ""
            sFileModifiedData = ""

            If sPendingLine <> "" Then
                sLine = sPendingLine
                sPendingLine = ""
            Else
                sLine = sr.ReadLine()
            End If

            If sLine.StartsWith("#") Then
                sFileID = sLine.Trim.Substring(1)


                If sr.Peek() >= 0 Then
                    sLine = sr.ReadLine
                    If sLine.StartsWith("@") Then sFileModifiedData = sLine.Trim.Substring(1)
                    If sr.Peek() >= 0 Then
                        sLine = sr.ReadLine
                        If sLine.StartsWith("@") Then sFileAuthor = sLine.Trim.Substring(1)
                    End If
                End If

                'First line is author
                While sr.Peek() >= 0
                    sPendingLine = sr.ReadLine
                    If sPendingLine.StartsWith("#") Then Exit While
                    If sFileComment <> "" Then sFileComment &= vbCrLf
                    sFileComment &= sPendingLine
                End While

                'NOTE: check if the new file has been updated
                If sFileModifiedData <> "" AndAlso sFileModifiedData <> dicFileModifiedDate(sFileID) Then
                    sFileComment = ""
                    sFileAuthor = ""
                End If


                dicFileManifestComments(sFileID) = sFileComment
                dicFileAuthor(sFileID) = sFileAuthor
            End If
        End While
        sr.Close()
    End Sub

    Private Sub saveFileManifestComments()
        'Generate the mannifest of files in current folder
        Dim currentPath As String = Server.MapPath(Request.ServerVariables("PATH_INFO"))
        currentPath = Left(currentPath, currentPath.LastIndexOf("\") + 1)

        Dim sw As IO.StreamWriter = Nothing
        If Not System.IO.File.Exists(currentPath & commentFile) Then
            Try
                sw = System.IO.File.CreateText(currentPath & commentFile)
            Catch ex As Exception
                Response.Write("Could not create file " & currentPath & commentFile & "! Please make sure file exists with write permission to everyone!")
                Response.End()
            End Try
        Else
            sw = New IO.StreamWriter(currentPath & commentFile, False)
        End If

        For Each key As String In dicFileManifest.Keys
            sw.WriteLine("#" & key)
            sw.WriteLine("@" & dicFileModifiedDate(key))
            sw.WriteLine("@" & dicFileAuthor(key))
            sw.WriteLine(dicFileManifestComments(key))
        Next
        sw.Close()
    End Sub

    Private Sub responseFileManifest()
        Response.ContentType = "text/plain"

        For Each key As String In dicFileManifest.Keys
            Response.Write(dicFileManifest(key) & "," & dicFileManifestComments(key).Replace(vbCrLf, "<br>").Replace(",", "<cm>") & "," & dicFileAuthor(key).Replace(",", "<cm>") & vbCrLf)
        Next
        Response.End()
    End Sub

End Class
