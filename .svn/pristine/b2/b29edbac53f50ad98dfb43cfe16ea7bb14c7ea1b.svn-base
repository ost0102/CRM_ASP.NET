Imports System.IO
Imports System.Threading
Imports System.DirectoryServices

Partial Class WCF_Client_Plugins_Downloader
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim fileUrl As String = Request("fileUrl").ToString
        'fileUrl = "Bin/" & fileUrl
        fileDownload(Server.MapPath("./" & fileUrl))
        'Response.Write(Server.MapPath("./" & fileUrl))
        'Response.End()
    End Sub

    Private Sub fileDownload(ByVal fileUrl As String)
        Response.Clear()
        Dim success As Boolean = responseFile(fileUrl)
        If Not success Then
            Response.Write("Downloading Error!")
        End If
        Response.End()
    End Sub

    Private Function responseFile(ByVal filePath As String) As Boolean
        Dim fileName As String
        If filePath.Contains("\") Then
            fileName = filePath.Substring(filePath.LastIndexOf("\") + 1)
        Else
            fileName = filePath
        End If
        'Response.Write(filePath)
        'Response.End()
        Try
            Dim myFile As New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            Dim br As New BinaryReader(myFile)

            Try
                Response.AddHeader("Accept-Ranges", "bytes")
                Response.Buffer = False
                Dim fileLength As Long = myFile.Length
                Dim startBytes As Long = 0

                Dim pack As Integer = 10240 '10K bytes
                If Request.Headers("Range") IsNot Nothing Then
                    Response.StatusCode = 206
                    Dim range As String() = Request.Headers("Range").Split(New Char() {"="c, "-"c})
                    startBytes = Convert.ToInt64(range(1))
                End If
                Response.AddHeader("Content-Length", (fileLength - startBytes).ToString())
                If startBytes <> 0 Then
                    Response.AddHeader("Content-Range", String.Format(" bytes {0}-{1}/{2}", startBytes, fileLength - 1, fileLength))
                End If
                Response.AddHeader("Connection", "Keep-Alive")
                Response.ContentType = "application/octet-stream"
                Response.AddHeader("Content-Disposition", "attachment;filename=" & HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8))

                br.BaseStream.Seek(startBytes, SeekOrigin.Begin)
                Dim maxCount As Integer = CInt(Math.Floor(CDbl((fileLength - startBytes) \ pack))) + 1

                For i As Integer = 0 To maxCount - 1
                    If Response.IsClientConnected Then
                        Response.BinaryWrite(br.ReadBytes(pack))
                    Else
                        i = maxCount
                    End If
                Next
            Catch
                Return False
            Finally
                br.Close()
                myFile.Close()
                myFile.Dispose()
            End Try
        Catch ex As Exception
            Response.Write(ex.StackTrace)
            Return False
        End Try
        Return True
    End Function
End Class
