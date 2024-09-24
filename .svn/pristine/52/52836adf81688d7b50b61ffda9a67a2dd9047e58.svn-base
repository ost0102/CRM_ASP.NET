Public Class SysHelpHyperLink
    Public ProjectRoot As String

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub rdoLinkType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoLinkType.EditValueChanged
        If rdoLinkType.EditValue = "N" Then
            trwFileExplorer.Visible = True
            LINK_URL.ReadOnly = True
        Else
            trwFileExplorer.Visible = False
            LINK_URL.ReadOnly = False
            LINK_URL.Text = "http://"
            LINK_URL.SelectAll()
            LINK_TOOLTIP.Text = ""
        End If
    End Sub

    Private Sub SysHelpHyperLink_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ProjectRoot <> "" Then
            Call loadHelpRoots()
        End If
    End Sub

#Region "===============Tree Displaying============="
    Private Sub loadHelpRoots()
        'Load all help project as roots
        '////////WCF Service Call/////////
        Dim params() As String = {}

        Dim dsResult As DataSet
        Dim drPairs As DataRow
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "GetHelpRoots", params)
        Catch ex As Exception
            MsgBoxSC(ex.Message)
            Exit Sub
        End Try

        '//////Parsing WCF returned data///////
        drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode") <> "SUCCESS" Then
            MsgBoxSC(drPairs("TrxMsg"))
            Exit Sub
        End If

        '--------------Adding Roots to Tree--------------
        Dim dtRoots As DataTable = dsResult.Tables("Data.HelpRoots")
        For Each dr As DataRow In dtRoots.Rows
            addNodeToTree(Nothing, dr)  'Register roots to tree
        Next

        If trwFileExplorer.TopNode IsNot Nothing Then trwFileExplorer.TopNode.Expand()
    End Sub

    Private Function addNodeToTree(ByVal parentNode As TreeNode, ByVal drNodeInfo As DataRow) As TreeNode
        Dim node As New TreeNode

        node.Text = drNodeInfo("TITLE")
        node.Name = drNodeInfo("NODE_ID")
        node.Tag = drNodeInfo 'Store all info of node

        If drNodeInfo("NODE_TYPE") = "G" OrElse drNodeInfo("NODE_TYPE") = "R" Then
            node.Nodes.Add("")      'Add the empty child to mark this is not a leaf (***)
            node.ImageKey = "Folder"
            node.SelectedImageKey = "Folder"

            'node.ContextMenuStrip = cmsFileExFolder
        Else
            node.ImageKey = "File"
            node.SelectedImageKey = "File"

            'node.ContextMenuStrip = cmsFileExFile
        End If

        If drNodeInfo("NODE_TYPE") = "R" Then 'Root
            trwFileExplorer.Nodes.Add(node)
        Else
            parentNode.Nodes.Add(node)
        End If

        Return node
    End Function

    Private Sub trwFileExplorer_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trwFileExplorer.BeforeExpand
        If e.Node.Tag("NODE_TYPE") = "R" OrElse e.Node.Tag("NODE_TYPE") = "G" Then
            Call loadChildren(e.Node)
        End If
    End Sub

    Private Sub loadChildren(ByVal parentNode As TreeNode)
        Try

            '////////WCF Service Call/////////
            Dim params() As String = {parentNode.Tag("NODE_ID")}

            Dim dsResult As DataSet
            Dim drPairs As DataRow
            Try
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "GetChildNodes", params)
            Catch ex As Exception
                MsgBoxSC(ex.Message)
                Exit Sub
            End Try

            '//////Parsing WCF returned data///////
            drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
            If drPairs("TrxCode") <> "SUCCESS" Then
                MsgBoxSC(drPairs("TrxMsg"))
                Exit Sub
            End If

            parentNode.Nodes.Clear()  'Clear the empty (default) children

            Dim dtNodes As DataTable = dsResult.Tables("Data.ChildNodes")
            For Each dr As DataRow In dtNodes.Rows
                Call addNodeToTree(parentNode, dr)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub trwFileExplorer_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles trwFileExplorer.NodeMouseDoubleClick
        If e.Node.Tag("NODE_TYPE") = "N" Then
            LINK_URL.Text = "./Data/HelpContent.aspx?id=" & e.Node.Tag("NODE_ID")
            LINK_TOOLTIP.Text = e.Node.Text
        End If
    End Sub

#End Region

    



End Class