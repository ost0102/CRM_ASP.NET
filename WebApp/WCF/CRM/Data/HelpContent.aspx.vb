Imports System.Data
Imports YJIT.Data

Partial Class WCF_Help_Content
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Id As String = Request("Id")
        If Id = "" Then
            Response.Write("Invalide request! Please provide Notice ID... ")
        Else
            Dim db As New YJIT.Data.DBA()
            Dim dt As DataTable = db.SqlGet("SELECT (SELECT CONTENT FROM DUAL) AS CONTENT FROM ELVIS.SYS_FAQ_MST WHERE NODE_ID='" & Id & "'")
            If dt.Rows.Count = 0 Then
                Response.Write("Help NODE_ID (" & Id & ") is not found!")
            Else
                Response.Write(dt.Rows(0)("CONTENT"))
            End If
        End If
        Response.End()
    End Sub



End Class
