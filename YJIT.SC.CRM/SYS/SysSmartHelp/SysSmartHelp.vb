Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Imports System.Drawing
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Public Class SysSmartHelp
    Protected helpFilePath As String = String.Empty
    Protected isCurrentNodeModified As Boolean = False
    Protected m_currentNode As TreeNode

    Private m_projectRoot As String = Application.StartupPath & "\SmartHelp"             'Path to root help folder

    Private Sub SysHelpEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Validate existance
        If Not IO.Directory.Exists(m_projectRoot) Then IO.Directory.CreateDirectory(m_projectRoot)

        If m_projectRoot <> "" Then
            Call loadHelpRoots()
        End If

    End Sub

    ''' <summary>
    ''' Currently Editing tree node
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CurrentNode As TreeNode
        Get
            Return m_currentNode
        End Get
        Set(ByVal value As TreeNode)
            m_currentNode = value
            grpXtraRichEdit.Text = "Current Editing : " & m_currentNode.Tag("TITLE") & " (" & m_currentNode.Tag("NODE_ID") & ")"
        End Set
    End Property


#Region "===============Main Form=============="
    Private Sub timerMessage_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerMessage.Tick
        displayStatus("", -1)   'Reset 
    End Sub
#End Region

#Region "===============Help Explorer==============="

    Private Sub loadChildren(ByVal parentNode As TreeNode)
        Try

            '////////WCF Service Call/////////
            Dim params() As String = {parentNode.Tag("NODE_ID")}

            Dim dsResult As DataSet
            Dim drPairs As DataRow
            Try
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysSmartHelp", "GetChildNodes", params)
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

    Private Sub tsmiRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmiRefresh.Click
        Try
            trwFileExplorer.SelectedNode.Collapse()
            trwFileExplorer.SelectedNode.Expand()
        Catch ex As Exception
            'Error free
        End Try
    End Sub

    Private Sub tsmiRename_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmiRename.Click
        'Rename Node Title
        Dim node As TreeNode = trwFileExplorer.SelectedNode
        If node IsNot Nothing Then node.BeginEdit()
    End Sub

    Private Sub trwFileExplorer_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles trwFileExplorer.AfterLabelEdit
        If e.Label Is Nothing Then Exit Sub 'no change

        Dim node As TreeNode = e.Node
        'We allow update title only


        '////////WCF Service Call/////////
        Dim params() As Object = {node.Tag("NODE_ID"), e.Label}

        Dim dsResult As DataSet
        Dim drPairs As DataRow
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysSmartHelp", "UpdateNodeTitle", params)
        Catch ex As Exception
            MsgBoxSC(ex.Message)
            Exit Sub
        End Try

        '//////Parsing WCF returned data///////
        drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode") <> "SUCCESS" Then
            MsgBoxSC(drPairs("TrxMsg"))

            'client rollback
            node.Text = node.Tag("TITLE")
        Else
            'client commit
            node.Tag("TITLE") = e.Label
        End If
    End Sub

    Private Sub tsmiAddFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmiAddFile.Click
        Try
            Dim parentNode As TreeNode = trwFileExplorer.SelectedNode

            '////////WCF Service Call/////////
            Dim params() As String = {"N", parentNode.Tag("NODE_ID")}

            Dim dsResult As DataSet
            Dim drPairs As DataRow
            Try
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysSmartHelp", "AddNewNode", params)
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

            Dim dr As DataRow = dsResult.Tables("Data.NodeInfo").Rows(0)
            Dim newNode As TreeNode = addNodeToTree(parentNode, dr)

            ''actual adding file
            'Dim filePath As String = m_projectRoot & "\" & node.FullPath & "\" & newFileName
            'Dim fsTemp As New System.IO.FileStream(filePath, IO.FileMode.Create)
            'fsTemp.Close()

            'Refresh
            trwFileExplorer.SelectedNode = newNode

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tsmiAddSubFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmiAddSubFolder.Click
        Try
            Dim parentNode As TreeNode = trwFileExplorer.SelectedNode

            '////////WCF Service Call/////////
            Dim params() As String = {"G", parentNode.Tag("NODE_ID")}

            Dim dsResult As DataSet
            Dim drPairs As DataRow
            Try
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysSmartHelp", "AddNewNode", params)
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

            Dim dr As DataRow = dsResult.Tables("Data.NodeInfo").Rows(0)
            Dim newNode As TreeNode = addNodeToTree(parentNode, dr)

            'Refresh
            trwFileExplorer.SelectedNode = newNode

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tsmiCopyFile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            'Get the unique new name
            Dim newFileName As String
            Dim i As Integer = 1
            Dim node As TreeNode = trwFileExplorer.SelectedNode
            Dim nodeCollection As TreeNodeCollection
            Dim path As String  'Path to the parent folder

            If node.Parent Is Nothing Then
                nodeCollection = trwFileExplorer.Nodes
                path = m_projectRoot & "\"
            Else
                nodeCollection = node.Parent.Nodes
                path = m_projectRoot & "\" & node.Parent.FullPath & "\"
            End If

            newFileName = "Copy of " & node.Text

            Dim newNode As TreeNode = nodeCollection.Add(newFileName)
            newNode.Tag = "File"
            newNode.Name = newFileName

            'actual copy file

            Dim filePath As String = path & node.Text

            Dim newFilePath As String = path & newFileName
            File.Copy(filePath, newFilePath)

            'Refresh
            If node.Parent IsNot Nothing Then
                node.Parent.Collapse()
                node.Parent.Expand()
            End If

            trwFileExplorer.SelectedNode = nodeCollection(newNode.Name)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tsmiDeleteFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmiDeleteFile.Click
        Dim node As TreeNode = trwFileExplorer.SelectedNode
        Call deleteNode(node)
    End Sub

    Private Sub tsmiDeleteFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmiDeleteFolder.Click
        Dim node As TreeNode = trwFileExplorer.SelectedNode
        Call deleteNode(node)
    End Sub

    Private Sub trwFileExplorer_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trwFileExplorer.BeforeExpand
        If e.Node.Tag("NODE_TYPE") = "R" OrElse e.Node.Tag("NODE_TYPE") = "G" Then
            Call loadChildren(e.Node)
        End If
    End Sub

    Private Sub trwFileExplorer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles trwFileExplorer.KeyDown
        Dim node As TreeNode = trwFileExplorer.SelectedNode
        Select Case e.KeyCode
            Case Keys.F2
                If node IsNot Nothing Then
                    node.BeginEdit()
                End If
            Case Keys.Enter
            Case Else
        End Select

    End Sub

    Private Sub trwFileExplorer_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles trwFileExplorer.NodeMouseClick
        'Make sure right click on node will select it
        If e.Button = Windows.Forms.MouseButtons.Right Then
            trwFileExplorer.SelectedNode = e.Node
        End If
    End Sub

    Private Sub trwFileExplorer_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles trwFileExplorer.NodeMouseDoubleClick
        'Validattion:
        If isCurrentNodeModified And Me.CurrentNode IsNot Nothing Then
            Select Case MsgBoxSC("Current editing node has changed! Do you want to save?", MessageBoxButtons.YesNoCancel)
                Case MsgBoxResult.Yes
                    Call commitNodeFile(Me.CurrentNode)
                    'continue after save
                Case MsgBoxResult.Cancel
                    Exit Sub
                Case MsgBoxResult.No
                    'continue without save
            End Select
        End If

        Dim node As TreeNode = trwFileExplorer.SelectedNode

        If node IsNot Nothing Then
            Try
                Me.CurrentNode = node
                Call loadNodeFileForEdit(node)
            Catch ex As Exception
                MsgBoxSC("Could not open selected node!" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub tmsiProperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmsiProperty.Click
        If trwFileExplorer.SelectedNode Is Nothing Then Exit Sub
        Dim dlg As New SysSmartHelp_Popup
        dlg.LoadNodeInfo(trwFileExplorer.SelectedNode.Tag("NODE_ID"))
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Call loadChildren(trwFileExplorer.SelectedNode.Parent)
        End If
    End Sub

    Private Sub tmsProperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmsProperty.Click
        If trwFileExplorer.SelectedNode Is Nothing Then Exit Sub
        Dim dlg As New SysSmartHelp_Popup
        dlg.LoadNodeInfo(trwFileExplorer.SelectedNode.Tag("NODE_ID"))
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Call loadChildren(trwFileExplorer.SelectedNode.Parent)
        End If
    End Sub

    Private Function locateFileInTree(ByVal filePath As String) As TreeNode
        Dim sRoot As String
        Dim sNodePath As String 'Path of node with in tree
        Dim nRootEndIndex As Integer
        Try
            If filePath.StartsWith("\\") Then
                'Handle network drive
                nRootEndIndex = filePath.IndexOf("\", 2)     'E.g.: //192.1681.1/Temp/file.sql

            Else
                'Handle local drive
                nRootEndIndex = 2       'Ex: C:\Temp\file.sql, D:\Temp\file.sql
            End If
            sRoot = filePath.Substring(0, nRootEndIndex + 1)
            sNodePath = filePath.Substring(nRootEndIndex + 1)

            'Load & expand the nodes to the previous


            Dim arr As [Char]() = {"\"c}
            Dim arParts() As String = filePath.Split(arr)
            'First part is drive name => append \ at last
            If arParts.Length > 0 Then arParts(0) &= "\"

            Dim node As TreeNode = Nothing
            Dim nodeCollection As TreeNodeCollection

            For Each part As String In arParts
                If node Is Nothing Then
                    nodeCollection = trwFileExplorer.Nodes
                Else
                    nodeCollection = node.Nodes
                End If
                'Find the matched node in the tree
                For Each childNode As TreeNode In nodeCollection
                    If childNode.Text.Equals(part, StringComparison.InvariantCultureIgnoreCase) Then
                        If childNode.Tag = "Folder" Then
                            'Expand this node
                            childNode.Expand()
                            'Repeatly process the child
                            node = childNode
                            'Quit this loop
                            Exit For
                        Else
                            trwFileExplorer.SelectedNode = childNode
                        End If
                    End If
                Next
            Next

            Return trwFileExplorer.SelectedNode
        Catch ex As Exception
            'Error free or display failed message at status bar
            displayStatus("Failed to locate file in the tree!")
            Return Nothing
        End Try
    End Function

    Private Sub loadHelpRoots()
        'Load all help project as roots
        '////////WCF Service Call/////////
        Dim params() As String = {}

        Dim dsResult As DataSet
        Dim drPairs As DataRow
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysSmartHelp", "GetHelpRoots", params)
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

            node.ContextMenuStrip = cmsFileExFolder
        Else
            node.ImageKey = "File"
            node.SelectedImageKey = "File"

            node.ContextMenuStrip = cmsFileExFile
        End If

        If drNodeInfo("NODE_TYPE") = "R" Then 'Root
            trwFileExplorer.Nodes.Add(node)
        Else
            parentNode.Nodes.Add(node)
        End If

        Return node
    End Function

    Private isLoadingContent As Boolean = False
    Private Sub loadNodeFileForEdit(ByVal node As TreeNode)
        Try
            isLoadingContent = True

            'If node.Tag("NODE_TYPE") <> "N" Then Exit Sub
            helpFilePath = m_projectRoot & "\" & node.Tag("NODE_ID") & ".html"

            Me.Cursor = Cursors.WaitCursor

            '1. Load HTML content from DB
            '////////WCF Service Call/////////
            Dim params() As String = {node.Tag("NODE_ID")}

            Dim dsResult As DataSet
            Dim drPairs As DataRow
            Try
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysSmartHelp", "GetNode", params)
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

            Dim dt As DataTable = dsResult.Tables("Data.NodeData")
            'Write to file for editing
            IO.File.WriteAllText(helpFilePath, dt.Rows(0)("CONTENT") & "")

            '2. check if the local _files not exists, download from server
            Dim sLocalPath As String = m_projectRoot & "\" & node.Tag("NODE_ID") & "_files\"

            If Not IO.Directory.Exists(sLocalPath) Then
                'Create local path
                IO.Directory.CreateDirectory(sLocalPath)

                'Download all files from corresponding path on server
                Dim sSmartHelpHome As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "SmartHelp/"

                Dim wc As New System.Net.WebClient
                Dim sResult As String = wc.DownloadString(sSmartHelpHome & "FolderManifest.aspx?FolderURI=Data/" & node.Tag("NODE_ID") & "_files/")
                If sResult.StartsWith("OK") Then
                    Dim files() As String = sResult.Split(vbCrLf)
                    For i As Integer = 1 To files.Count - 1  'first line is "OK"
                        If files(i).Trim = "" Then Continue For
                        Try
                            wc.DownloadFile(sSmartHelpHome & "Data/" & node.Tag("NODE_ID") & "_files/" & files(i).Trim, sLocalPath & files(i).Trim)
                        Catch ex As Exception
                            MsgBoxSC("Download failed!" & sSmartHelpHome & "Data/" & node.Tag("NODE_ID") & "_files/" & files(i).Trim)
                        End Try
                    Next
                End If
            End If

            '3. Load content to editor
            richEditControl.LoadDocument(helpFilePath, DocumentFormat.Html)
            richEditControl.ReadOnly = False

            Me.Cursor = Cursors.Arrow

            'Show status info
            tsslWorkingFile.Text = helpFilePath

            setModifiedState(False)
            displayCurrentFileStatus()

            'isLoadingContent = True   (Set to be true at DocumentChanged event)
        Catch ex As Exception
            isLoadingContent = False
        End Try
    End Sub

    Private Function saveNodeFile(ByVal node As TreeNode) As Boolean
        If helpFilePath = "" Then Return False
        'If node.Tag("NODE_TYPE") <> "N" Then Return False

        '1. clear all temp file, to make sure same generated image index
        Try
            Dim sTempPath As String = m_projectRoot & "\" & node.Tag("NODE_ID") & "_files"
            If IO.Directory.Exists(sTempPath) Then IO.Directory.Delete(sTempPath, True)
            '2. Save document to HTML format, images will be saved into node_id_images
            richEditControl.SaveDocument(helpFilePath, DocumentFormat.Html)
        Catch ex As Exception
            MsgBoxSC("Error while saving node!" & ex.Message)
            Return False
        End Try

        Return True
    End Function

    Private Sub commitNodeFile(ByVal node As TreeNode)

        '1. First, save to local==================================
        If saveNodeFile(node) = False Then Exit Sub

        '2. Load again to datatable==================================
        Dim dtParam As New DataTable
        dtParam.TableName = "NodeInfo"
        dtParam.Columns.Add("NODE_ID", GetType(String))
        dtParam.Columns.Add("CONTENT", GetType(String))
        dtParam.Rows.Add({node.Tag("NODE_ID"), IO.File.ReadAllText(helpFilePath)})
        Dim dsParam As New DataSet
        dsParam.Tables.Add(dtParam)


        '////////WCF Service Call/////////
        Dim dsResult As DataSet
        Dim drPairs As DataRow
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysSmartHelp", "UpdateNodeContent", dsParam)
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

        '3. Preparlist of upload file==================================
        Dim arlUploadClient As New ArrayList
        'Image files are stored in NODE_ID_files
        Dim sUpdPath As String = m_projectRoot & "\" & node.Tag("NODE_ID") & "_files\"
        If IO.Directory.Exists(sUpdPath) Then
            Try
                'For directory, we list all file within that directory
                Dim files() As String = Directory.GetFiles(sUpdPath, "*.*", SearchOption.AllDirectories)
                For Each sFile As String In files
                    arlUploadClient.Add(sFile)
                Next
            Catch ex As Exception
                MsgBoxSC("Error while preparing file list!" & vbCrLf & ex.StackTrace)
                Exit Sub
            End Try

            Dim dlg As New SysSmartHelp_Upload
            dlg.ArlClientFiles = arlUploadClient
            dlg.Node = node

            dlg.ShowDialog()
        End If
    End Sub

    Private Sub deleteNode(ByVal node As TreeNode)
        If helpFilePath = "" Then Exit Sub

        If node.Tag("NODE_TYPE") = "G" AndAlso MsgBox("Group node may contain child nodes. Are you sure to delete?", MsgBoxStyle.OkCancel) <> MsgBoxResult.Ok Then
            Exit Sub
        End If

        '////////WCF Service Call/////////
        Dim params() As Object = {node.Tag("NODE_ID"), node.Tag("NODE_TYPE")}
        Dim dsResult As DataSet
        Dim drPairs As DataRow
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysSmartHelp", "DeleteNode", params)
        Catch ex As Exception
            MsgBoxSC(ex.Message)
            Exit Sub
        End Try

        '//////Parsing WCF returned data///////
        drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode") <> "SUCCESS" Then
            MsgBoxSC(drPairs("TrxMsg"))
            Exit Sub
        Else
            'Delete node on the client tree
            If node.Parent Is Nothing Then
                trwFileExplorer.Nodes.RemoveByKey(node.Name)
            Else
                node.Parent.Nodes.RemoveByKey(node.Name)
            End If

            'Pending: delete temp file


        End If

    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Not use auto capitalize logic of SCView
    End Sub

#End Region

#Region "===================Content editor================="

    Private Sub richEditControl_ContentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles richEditControl.ContentChanged
        If Not isLoadingContent Then
            setModifiedState(True)
        Else
            isLoadingContent = False 'End loading process
        End If
    End Sub

    Private Sub richEditControl_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.DocumentLoaded
        'Set the default behavior for the editor
        Call initEditorDefaultSettings()

        setModifiedState(False)
    End Sub

    Private Sub richEditControl_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl.EmptyDocumentCreated
        'Set default font settings for editor
        Dim charProperties As CharacterProperties = richEditControl.Document.BeginUpdateCharacters(richEditControl.Document.Range)
        charProperties.FontName = "Arial"
        charProperties.FontSize = 10
        richEditControl.Document.EndUpdateCharacters(charProperties)

        setModifiedState(False)
    End Sub

    Private Sub btnCommitSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCommitSave.ItemClick
        'Not used any more
        Call saveNodeFile(trwFileExplorer.SelectedNode)
    End Sub

    Private Sub btnServerUpload_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnServerUpload.ItemClick
        commitNodeFile(Me.CurrentNode)
        setModifiedState(False)
    End Sub

    Private Sub bbiHelpViewer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiHelpViewer.ItemClick
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object
        fTarget = frmMain.NavigateTo("SysSmartHelpViewer")
        If fTarget IsNot Nothing Then
            'fTarget.HomeURI = ""
        End If
    End Sub

    Private Sub initEditorDefaultSettings()
        richEditControl.Document.DefaultCharacterProperties.FontName = "Arial"
        richEditControl.Document.DefaultCharacterProperties.FontSize = 10
    End Sub

    Private Sub bbiHyperLink_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiHyperLink.ItemClick
        Dim dlg As New SysSmartHelp_HyperLink
        dlg.ProjectRoot = m_projectRoot

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlg.LINK_URL.Text <> "" Then
                'Add Link to selected URL
                Dim range As DocumentRange = richEditControl.Document.Selection
                Dim hyperLink As Hyperlink = richEditControl.Document.CreateHyperlink(range)
                hyperLink.ToolTip = dlg.LINK_TOOLTIP.Text
                hyperLink.NavigateUri = dlg.LINK_URL.Text
            End If
        End If

    End Sub
#End Region

#Region "================Helper methods==========="
    Private Sub setModifiedState(ByVal flag As Boolean)
        isCurrentNodeModified = flag
        If isCurrentNodeModified Then
            If Not tsslWorkingFile.Text.StartsWith("*") Then
                tsslWorkingFile.Text = "*" & tsslWorkingFile.Text
            End If
            tsslWorkingFile.ForeColor = Color.DarkRed
            grpXtraRichEdit.AppearanceCaption.ForeColor = Color.Maroon
            tsslWorkingFile.ToolTipText = tsslWorkingFile.Text
        Else
            If tsslWorkingFile.Text.StartsWith("*") Then
                tsslWorkingFile.Text = tsslWorkingFile.Text.Substring(1)
            End If
            tsslWorkingFile.ForeColor = Color.Black
            grpXtraRichEdit.AppearanceCaption.ForeColor = Color.Black
            tsslWorkingFile.ToolTipText = tsslWorkingFile.Text
        End If
    End Sub

    Private Sub displayStatus(ByVal msg As String, Optional ByVal interval As Integer = 5000)
        If interval <> -1 Then
            timerMessage.Interval = interval
            tsslMessage.Text = msg
            timerMessage.Start()
        Else
            tsslMessage.Text = msg
            timerMessage.Stop()
        End If
    End Sub

    Private Sub displayCurrentFileStatus()
        If String.IsNullOrEmpty(helpFilePath) Then Exit Sub
        Dim file As FileInfo = New FileInfo(helpFilePath)
        'tsslFileInfo.Text = ">>Total sql: " & currentBox.Count & "        >>Last modified:" & file.LastWriteTime
    End Sub

#End Region

End Class



