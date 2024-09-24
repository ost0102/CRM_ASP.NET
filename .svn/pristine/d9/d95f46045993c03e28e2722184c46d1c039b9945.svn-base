Imports System.Data
Imports YJIT.Data

Partial Class WCF_SmartHelp_HelpContent
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Id As String = Request("Id")
        If Id = "" Then
            Response.Write("Invalide request! Please provide help NODE_ID... ")
        Else
            Dim db As New YJIT.Data.DBA()
            Dim dt As DataTable = db.SqlGet("SELECT CONTENT FROM CRM.SYS_HELP_MST WHERE NODE_ID='" & Id & "'")
            If dt.Rows.Count = 0 Then
                Response.Write("Help NODE_ID (" & Id & ") is not found!")
            Else
                Response.Write(dt.Rows(0)("CONTENT"))
            End If
        End If

        Response.Write("<script language='javascript' >")
        Response.Write("window.parent.document.getElementById('nodePositionPath').innerHTML=""" & getNodePath(Id) & """;")
        Response.Write("</script>")

        Response.End()
    End Sub


    Private Function getNodePath(ByVal sNodeId As String) As String
        Dim db As New YJIT.Data.DBA()
        Dim sResult As String = String.Empty

        While True
            Dim dt As DataTable = db.SqlGet("SELECT NODE_ID,PARENT_NODE_ID,NODE_TYPE,TITLE FROM CRM.SYS_HELP_MST WHERE NODE_ID='" & sNodeId & "'", False)
            If dt.Rows.Count > 0 Then
                If sResult <> "" Then sResult = " > " & sResult
                sResult = "<a class='node_path' href='./Data/HelpContent.aspx?Id=" & dt.Rows(0)("NODE_ID") & "' target='help_content'>" & dt.Rows(0)("TITLE") & "</a>" & sResult

                sNodeId = dt.Rows(0)("PARENT_NODE_ID") & ""

                If sNodeId = "" OrElse dt.Rows(0)("NODE_TYPE") = "R" Then
                    Exit While
                End If
            Else
                Exit While
            End If
        End While

        Return sResult
    End Function
End Class
