Imports System.Collections.Generic

Partial Class WCF_Client_FolderManifest
    Inherits System.Web.UI.Page

    Protected dicFileManifest As New Dictionary(Of String, String)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Prepare the manifest dictionary of files
        Call loadFileManifest()

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Write manifest to client
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Call responseFileManifest()
    End Sub

    Private Sub loadFileManifest()
        Dim sURI As String = Request("FolderURI")  'expecting: /WCF/SmartHelp/NodeID_files
        'Generate the mannifest of files in current folder
        Dim currentPath As String = Server.MapPath(sURI)
        If IO.Directory.Exists(currentPath) Then
            Dim files() As String = System.IO.Directory.GetFiles(currentPath, "*.*", System.IO.SearchOption.AllDirectories)
            Dim sSubUrl As String

            For Each sFile As String In files
                'not exclude file types
                'If Not (sFile.ToUpper.EndsWith(".DLL") OrElse sFile.ToUpper.EndsWith(".EXE") OrElse sFile.ToUpper.EndsWith(".REPX")) OrElse sFile.ToUpper.EndsWith(".CONFIG") Then Continue For
                'Exclude svn files
                If sFile.Contains("\.svn\") Then Continue For

                'Extract file information
                Dim fi As System.IO.FileInfo = New System.IO.FileInfo(sFile)
                sSubUrl = sFile.Remove(0, currentPath.Length).Replace("\", "/")
                'Assign to a global dictionary
                dicFileManifest(sSubUrl) = sSubUrl
            Next
        End If
    End Sub

    
    Private Sub responseFileManifest()
        Response.ContentType = "text/plain"

        Response.Write("OK" & vbCrLf) 'Success
        For Each key As String In dicFileManifest.Keys
            Response.Write(dicFileManifest(key) & vbCrLf)
        Next
        Response.End()
    End Sub

End Class
