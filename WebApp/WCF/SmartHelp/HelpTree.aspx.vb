Imports System.Data

Partial Class WCF_SmartHelp_HelpTree
    Inherits System.Web.UI.Page

    Dim sbXMLTree As New StringBuilder

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim db As New YJIT.Data.DBA()
        Dim sqlTree As String

        'Get tree structure (support by P/L sql) Ref: http://philip.greenspun.com/sql/trees.html
        sqlTree = "SELECT NODE_ID,NODE_TYPE,PARENT_NODE_ID, TITLE, LEVEL, DISPLAY_SEQ "
        sqlTree &= " FROM  CRM.SYS_HELP_MST WHERE NODE_TYPE IN ('R','G','N')"
        sqlTree &= "                connect by prior NODE_ID=PARENT_NODE_ID"
        sqlTree &= "                start with NODE_TYPE = 'R'"


        Dim dt As DataTable = db.SqlGet(sqlTree)
        Dim dictTree As New Dictionary(Of String, TreeNode)
        Dim helpRoot As New TreeNode("SmartHelpRoot", "R", "", "Smart Help Home", 0)
        dictTree("SmartHelpRoot") = helpRoot

        'Build Tree structure
        Dim node As TreeNode
        Dim sTitle As String = "" 'Must process special character for XML parsing
        'Please convert following special characters 
        '   1. & - &amp;
        '   2. < - &lt;
        '   3. > - &gt;
        '   4. " - &quot;
        '   5. ' - &#39; 
        For Each dr As DataRow In dt.Rows
            sTitle = dr("TITLE").ToString.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("'", "&#39;").Replace("""", "&quot;")

            node = New TreeNode(dr("NODE_ID") & "", dr("NODE_TYPE") & "", dr("PARENT_NODE_ID") & "", sTitle & "", CInt("0" & dr("DISPLAY_SEQ")))
            dictTree(dr("NODE_ID")) = node  'Set pointer to be ref later

            If dr("PARENT_NODE_ID") & "" = "" Then
                helpRoot.ChildNodes.Add(node)
            Else
                'The order of row must be returned in form of Tree order to make sure parent node created before children
                dictTree(dr("PARENT_NODE_ID")).ChildNodes.Add(node)
            End If
        Next


        'Startwrite tree
        Call writeTree(helpRoot)
        Response.End()

    End Sub



    Private Sub writeTree(ByVal rootNode As TreeNode)
        sbXMLTree.AppendLine("<?xml version=""1.0"" encoding=""UTF-8""?>")
        sbXMLTree.AppendLine("<menuTree>")

        rootNode.ChildNodes.Sort(New TreeNodeComparer())

        For Each node In rootNode.ChildNodes
            Call writeNode(node)
        Next

        sbXMLTree.AppendLine("</menuTree>")


        Response.ContentType = "text/xml"
        Response.Write(sbXMLTree.ToString)
    End Sub

    Private Sub writeNode(ByVal node As TreeNode)
        Select Case node.NodeType
            Case "R"
                sbXMLTree.AppendLine("<link linkName=""" & node.Title & """ linkOnClick="";"" type=""parent"" parentId=""" & node.NodeID & _
                             """ parentIcon=""homeIcon"" linkTarget=""/WCF/SmartHelp/Data/HelpContent.aspx?id=" & node.NodeID & """ linkTargetStatus=""help_content"">")
            Case "G"
                sbXMLTree.AppendLine("<link linkName=""" & node.Title & """ linkOnClick="";"" type=""parent"" parentId=""" & node.NodeID & _
                             """ parentIcon=""lectureIcon"" linkTarget=""/WCF/SmartHelp/Data/HelpContent.aspx?id=" & node.NodeID & """ linkTargetStatus=""help_content"">")
            Case "N"
                sbXMLTree.AppendLine("<link linkName=""" & node.Title & """ linkOnClick="";"" type=""child"" parentId=""" & node.NodeID & _
                             """ childIcon=""pdfIcon"" linkTarget=""/WCF/SmartHelp/Data/HelpContent.aspx?id=" & node.NodeID & """ linkTargetStatus=""help_content"">")
        End Select

        node.ChildNodes.Sort(New TreeNodeComparer())

        If node.ChildNodes.Count > 0 Then
            For Each nChild In node.ChildNodes
                writeNode(nChild)
            Next
        End If


        sbXMLTree.AppendLine("</link>")
    End Sub
End Class


Public Class TreeNode
    Public NodeID As String
    Public ParentNodeID As String
    Public NodeType As String
    Public Title As String
    Public DisplaySeq As Integer
    Public ChildNodes As New ArrayList

    Public Sub New(ByVal id As String, ByVal type As String, ByVal parentId As String, ByVal sTitle As String, ByVal sDisplaySeq As Integer)
        NodeID = id
        NodeType = type
        ParentNodeID = parentId
        Title = sTitle
        DisplaySeq = sDisplaySeq
    End Sub

End Class

Class TreeNodeComparer
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        'ORDER BY DISPLAY_SEQ, NODE_ID

        If x.DisplaySeq = y.DisplaySeq Then
            Return String.Compare(x.NodeID, y.NodeID)
        Else
            Return compareNumber(x.DisplaySeq, y.DisplaySeq)
        End If

    End Function

    Private Function compareNumber(ByVal x As Double, ByVal y As Double) As Integer
        If x = y Then
            Return 0
        ElseIf x > y Then
            Return 1
        Else 'x < y
            Return -1
        End If
    End Function

End Class
