Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Imports System.Drawing
Imports System.Drawing.Text
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Public Class SysHelpMgt
    Protected helpFilePath As String = String.Empty
    Protected isCurrentNodeModified As Boolean = False
    Protected m_currentNode As TreeNode
    Private m_projectRoot As String = Application.StartupPath & "\FAQ"             'Path to root help folder
    Private m_projectRoot21 As String = Application.StartupPath & "\FAQ21"             'Path to root help folder
    Private tempRoot As String = Application.StartupPath & "\TMP_OUTPUT"
    Private FindNodeYn As Boolean = False
    Private NodeType As String = String.Empty
    Private ParentNodeId As String = String.Empty
    Protected filePath As String = String.Empty
    Private DefaultFontFamily As String = "Tahoma"
    Private DefaultFontSize As Integer = 9
    Private PreNodeId As String = String.Empty
    Private isLoadingContent As Boolean = False
    Private Sub NewData()

        TITLE.Text = ""
        NODE_ID.Text = ""
        Call clearRTF()
        Call SetDefault()
    End Sub
    Protected Overrides Sub OnKeyPress(e As System.Windows.Forms.KeyPressEventArgs)
        If Me.ActiveControl Is CONTENT Then
            Exit Sub
        Else
            MyBase.OnKeyPress(e)
        End If
    End Sub

    Private Sub AddBulletedListToDocument()
        Dim doc As Document = CONTENT.Document
        ' Define an abstract numbered list and add it to the document.
        DefineAbstractList(doc)
        ' Create a numbering list. It is based on a previously defined abstract list with ID = 0.
        doc.NumberingLists.Add(0)
    End Sub
    Private Sub DefineAbstractList(ByVal doc As Document)
        doc.BeginUpdate()
        'Describe the pattern used for the numbered list.
        'Specify parameters used to represent each list level.

        Dim list As AbstractNumberingList = CONTENT.Document.AbstractNumberingLists.Add()
        list.NumberingType = NumberingType.Bullet

        Dim level As ListLevel = list.Levels(0)
        level.ParagraphProperties.LeftIndent = 0
        level.DisplayFormatString = ""

        level = list.Levels(1)
        level.ParagraphProperties.LeftIndent = 75
        level.Start = 1
        level.NumberingFormat = NumberingFormat.Decimal
        level.DisplayFormatString = "{1}"

        level = list.Levels(2)
        level.ParagraphProperties.LeftIndent = 75
        level.CharacterProperties.FontName = "Symbol"
        level.DisplayFormatString = New String(ChrW(&HB7), 1)

        doc.EndUpdate()
    End Sub

    Private Sub DeleteNode(ByVal node As String, ByVal nodeType As String)
        'If helpFilePath = "" Then Exit Sub

        If nodeType = "G" AndAlso MsgBox("Group node may contain child nodes. Are you sure to delete?", MsgBoxStyle.OkCancel) <> MsgBoxResult.Ok Then
            Exit Sub
        End If
        '////////WCF Service Call/////////
        Dim ds As DataSet = Me.ConvertToDataset
        Dim params() As Object = {node, nodeType, ds}
        Dim dsResult As DataSet = Nothing
        Dim drPairs As DataRow
        Try
            Select Case S_SOURCE.SelectedValue
                Case "01"
                    dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "DeleteNode", params)
                    Call loadHelpRoots()
                Case "07"
                    dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "DeleteNode_Sys", params)
                    Call LoadHelpRoots_Sys()
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        '//////Parsing WCF returned data///////
        drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode") <> "SUCCESS" Then
            MsgBoxLocalized(drPairs("TrxMsg"))
            Exit Sub
        End If

        Call clearRTF()
        Call SetDefault()

    End Sub

    Private Sub UpdateTitle(ByVal NodeId As String, ByVal title As String)
        Dim ds As DataSet = New DataSet

        If NodeId = "" Then Exit Sub
        ds = Me.ConvertToDataset
        Dim params() As Object = {NodeId, title, ds}
        Try
            If S_SOURCE.SelectedValue = "01" Then
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "UpdateTitle", params)
            Else '07
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "UpdateTitle_Sys", params)
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        Dim dr As DataRow
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Private Sub ChangeParentNode(ByVal NodeId As String, ByVal ChangeParentId As String)

        ''2. Load again to datatable==================================
        Dim ds As DataSet = New DataSet
        ds = Me.ConvertToDataset
        Dim params() As Object = {NodeId, ChangeParentId, ds}
        Try
            Select Case S_SOURCE.SelectedValue
                Case "01"
                    ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "ChangeParentNode", params)
                Case "07"
                    ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "ChangeParentNode_Sys", params)
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        Dim dr As DataRow
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub


    Private Function SaveFile() As Boolean
        Try
            '1. clear all temp file, to make sure same generated image index
            Dim sTempPath As String = tempRoot & "\" & NODE_ID.Text & "_files"
            If IO.Directory.Exists(sTempPath) Then IO.Directory.Delete(sTempPath, True)

            '2. Save document to HTML format, images will be saved into node_id_images
            filePath = tempRoot & "\" & NODE_ID.Text & ".html"
            CONTENT.SaveDocument(filePath, DocumentFormat.Html)

        Catch ex As Exception
            MsgBoxLocalized("Error while saving file!" & ex.Message)
            Return False
        End Try

        Return True
    End Function

    Private Sub SaveData()

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        If NODE_ID.Text = "" Then Exit Sub

        '1. First, save to local==================================
        If SaveFile() = False Then Exit Sub

        ''2. Load again to datatable==================================
        Dim ds As DataSet = New DataSet
        ds = Me.ConvertToDataset

        ds.Tables("MAIN").Columns.Add("NODE_TYPE")
        ds.Tables("MAIN").Rows(0)("NODE_TYPE") = NodeType

        ds.Tables("MAIN").Columns.Add("PARENT_NODE_ID")
        ds.Tables("MAIN").Rows(0)("PARENT_NODE_ID") = ParentNodeId

        ds.Tables("MAIN").Columns.Add("CONTENT")
        ds.Tables("MAIN").Rows(0)("CONTENT") = IO.File.ReadAllText(filePath)

        Dim params() As Object = {ds}
        Try
            If S_SOURCE.SelectedValue = "01" Then
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "UpdateContent", params)
            Else
                ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "UpdateContent_Sys", params)
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        Dim dr As DataRow
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim arlUploadClient As New ArrayList
        Dim sUpdPath As String = tempRoot & "\" & NODE_ID.Text & "_files\"
        If IO.Directory.Exists(sUpdPath) Then
            Try
                Dim files() As String = Directory.GetFiles(sUpdPath, "*.*", SearchOption.AllDirectories)
                For Each sFile As String In files
                    arlUploadClient.Add(sFile)
                Next
            Catch ex As Exception
                MsgBoxSC("Error while preparing file list!" & vbCrLf & ex.StackTrace)
                Exit Sub
            End Try

            Dim dlg As New SysHelpUpload
            dlg.ArlClientFiles = arlUploadClient 'syshelpupload
            dlg.NodeId = NODE_ID.Text
            dlg.Source = S_SOURCE.SelectedValue
            dlg.ShowDialog()
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
        End If

        If S_SOURCE.SelectedValue = "01" Then
            Call loadHelpRoots()
            Call LoadNodeFileForEdit(NODE_ID.Text)
        Else
            Call LoadHelpRoots_Sys()
            Call LoadNodeFileForEdit21(NODE_ID.Text)
        End If

    End Sub
    Private Sub loadHelpRoots() '01 - ELVIS

        HelpTree.ClearNodes()

        Dim params() As String = {SEARCH_KEY.Text}
        Dim dsResult As DataSet
        Dim drPairs As DataRow
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "GetNodeList", params)
        Catch ex As Exception
            MsgBoxSC(ex.Message)
            Exit Sub
        End Try

        '//////Parsing WCF returned data///////
        drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode") <> "SUCCESS" Then
            MsgBoxLocalized(drPairs("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Warning)
            Exit Sub
        End If
        HelpTree.DataSource = dsResult.Tables("Data.ViewTree").Copy
        HelpTree.ExpandAll()
        HelpTree.BestFitColumns()
    End Sub

    '20240314 김정현 ELVIS_21 FAQ 추가
    Private Sub LoadHelpRoots_Sys() '07 - ELVIS_21

        HelpTree.ClearNodes()

        Dim ds As DataSet
        Dim dsResult As DataSet
        Dim drPairs As DataRow

        ds = Me.ConvertToDataset

        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "GetNodeList_Sys", ds)
        Catch ex As Exception
            MsgBoxSC(ex.Message)
            Exit Sub
        End Try

        drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode") <> "SUCCESS" Then
            MsgBoxLocalized(drPairs("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Warning)
            Exit Sub
        End If
        HelpTree.DataSource = dsResult.Tables("Data.ViewTree").Copy
        HelpTree.ExpandAll()
        HelpTree.BestFitColumns()
    End Sub


    Private Sub LoadNodeFileForEdit(ByVal node As String)
        Try
            isLoadingContent = True
            Dim a As String = tempRoot & "\" & NODE_ID.Text & "_files"
            helpFilePath = m_projectRoot & "\" & node & ".html"
            Me.Cursor = Cursors.WaitCursor

            Dim ds As DataSet = Me.ConvertToDataset
            Dim params() As Object = {node, ds}
            Dim dsResult As DataSet
            Dim drPairs As DataRow
            Try
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "GetNode", params)
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End Try
            drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
            If drPairs("TrxCode") <> "SUCCESS" Then
                MsgBoxLocalized(drPairs("TrxMsg"))
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If

            Dim dt As DataTable = dsResult.Tables("Data.NodeData")
            IO.File.WriteAllText(helpFilePath, dt.Rows(0)("CONTENT") & "")

            '2. check if the local _files not exists, download from server
            Dim sLocalPath As String = m_projectRoot & "\" & node & "_files\"

            If Not IO.Directory.Exists(sLocalPath) Then IO.Directory.CreateDirectory(sLocalPath)

            'Download all files from corresponding path on server
            Dim sHelpHome As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "FAQ/"

            Dim wc As New System.Net.WebClient

            Dim sResult As String = wc.DownloadString(sHelpHome & "FolderManifest.aspx?FolderURI=Data/" & node & "_files/")
            If sResult.StartsWith("OK") Then
                Dim files() As String = sResult.Split(vbCrLf)
                For i As Integer = 1 To files.Count - 1  'first line is "OK"
                    If files(i).Trim = "" Then Continue For
                    Try
                        wc.DownloadFile(sHelpHome & "Data/" & node & "_files/" & files(i).Trim, sLocalPath & files(i).Trim)
                    Catch ex As Exception
                        Me.Cursor = Cursors.Arrow
                        MsgBoxLocalized("Download failed!" & sHelpHome & "Data/" & node & "_files/" & files(i).Trim, MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Warning)
                    End Try
                Next
            End If

            '3. Load content to editor
            CONTENT.LoadDocument(helpFilePath, DocumentFormat.Html)
            CONTENT.ReadOnly = False
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            isLoadingContent = False
        End Try
    End Sub

    Private Sub LoadNodeFileForEdit21(ByVal node As String)
        Try
            isLoadingContent = True
            Dim a As String = tempRoot & "\" & NODE_ID.Text & "_files"
            helpFilePath = m_projectRoot21 & "\" & node & ".html"
            Me.Cursor = Cursors.WaitCursor

            Dim ds As DataSet = Me.ConvertToDataset
            Dim params() As Object = {node, ds}
            Dim dsResult As DataSet
            Dim drPairs As DataRow
            Try
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "GetNode_Sys", params)
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End Try
            drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
            If drPairs("TrxCode") <> "SUCCESS" Then
                MsgBoxLocalized(drPairs("TrxMsg"))
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If

            Dim dt As DataTable = dsResult.Tables("Data.NodeData")
            IO.File.WriteAllText(helpFilePath, dt.Rows(0)("CONTENT") & "")

            '2. check if the local _files not exists, download from server
            Dim sLocalPath As String = m_projectRoot21 & "\" & node & "_files\"

            If Not IO.Directory.Exists(sLocalPath) Then IO.Directory.CreateDirectory(sLocalPath)

            'Download all files from corresponding path on server
            Dim sHelpHome As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "FAQ21/"

            Dim wc As New System.Net.WebClient

            Dim sResult As String = wc.DownloadString(sHelpHome & "FolderManifest.aspx?FolderURI=Data/" & node & "_files/")
            If sResult.StartsWith("OK") Then
                Dim files() As String = sResult.Split(vbCrLf)
                For i As Integer = 1 To files.Count - 1  'first line is "OK"
                    If files(i).Trim = "" Then Continue For
                    Try
                        wc.DownloadFile(sHelpHome & "Data/" & node & "_files/" & files(i).Trim, sLocalPath & files(i).Trim)
                    Catch ex As Exception
                        Me.Cursor = Cursors.Arrow
                        MsgBoxLocalized("Download failed!" & sHelpHome & "Data/" & node & "_files/" & files(i).Trim, MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Warning)
                    End Try
                Next
            End If

            '3. Load content to editor
            CONTENT.LoadDocument(helpFilePath, DocumentFormat.Html)
            CONTENT.ReadOnly = False
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            isLoadingContent = False
        End Try
    End Sub

    Public Function GetCurrentRange() As DocumentRange
        Dim range As DocumentRange = CONTENT.Document.Selection
        If CONTENT.Document.Selection.Start = CONTENT.Document.Selection.End Then
            range = CONTENT.Document.CreateRange(CONTENT.Document.Selection.Start, 1)
        End If
        Return range
    End Function
    Public Sub clearRTF()
        CONTENT.CreateNewDocument()
    End Sub

    Public Sub SetDefault()
        Try

            Dim cp As CharacterProperties = CONTENT.Document.BeginUpdateCharacters(CONTENT.Document.Range)
            cp.FontName = DefaultFontFamily
            cp.AllCaps = False
            cp.FontSize = DefaultFontSize
            CONTENT.Document.EndUpdateCharacters(cp)

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub FindFocus(ByVal nodes As DevExpress.XtraTreeList.Nodes.TreeListNodes, ByVal NodeId As String)

        If FindNodeYn = True Then Exit Sub

        For Each node As DevExpress.XtraTreeList.Nodes.TreeListNode In nodes
            If node.GetValue("NODE_ID").ToString = NodeId Then
                HelpTree.FocusedNode = node
                FindNodeYn = True
                Exit Sub
            End If
            If node.HasChildren Then
                FindFocus(node.Nodes, NodeId)
            End If
        Next

    End Sub

    Public Sub AddNode(ByVal ToTree As Object, Optional ByVal ParentAdd As Boolean = False)
        Dim ParentNode As String = ""
        Dim ToDt As DataTable = CType(ToTree.DataSource, DataTable).Copy
        If Not ToTree.FocusedNode Is Nothing Then ParentNode = ToTree.FocusedNode.GetValue("NODE_ID")

        Dim ds As DataSet = Me.ConvertToDataset
        Dim params() As Object = {"G", ParentNode, ds}
        Dim dsResult As DataSet
        Dim drPairs As DataRow
        Try
            If S_SOURCE.SelectedValue = "01" Then
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "AddNewNode", params)
            Else
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "AddNewNode_Sys", params)
            End If
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

    End Sub

    Private Sub SysHelpMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Validate existance
        If Not IO.Directory.Exists(m_projectRoot) Then IO.Directory.CreateDirectory(m_projectRoot)
        If Not IO.Directory.Exists(m_projectRoot21) Then IO.Directory.CreateDirectory(m_projectRoot21)
        HelpTree.KeyFieldName = "NODE_ID"
        HelpTree.ParentFieldName = "PARENT_NODE_ID"
    End Sub

    Private Sub SysHelpMgt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        HelpTree.ExpandAll()
        HelpTree.BestFitColumns()
    End Sub

#Region "===============TooScrip Event=============="

    Private Sub HelpTree_FocusedNodeChanged(sender As System.Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles HelpTree.FocusedNodeChanged

        Try
            If HelpTree.Nodes.Count = 0 Then Exit Sub

            If sender.FocusedNode.GetValue("NODE_TYPE") Is Nothing Then Exit Sub
            If sender.FocusedNode.GetValue("NODE_TYPE") = "G" OrElse sender.FocusedNode.GetValue("NODE_TYPE") = "R" Then
                HelpTree.ContextMenuStrip = cmsFileExFolder
            Else
                HelpTree.ContextMenuStrip = cmsFileExFile
            End If
            HelpTree.Columns("TITLE").OptionsColumn.AllowEdit = False

        Catch ex As Exception

        End Try

    End Sub
    Private Sub HelpTree_GetSelectImage(sender As System.Object, e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles HelpTree.GetSelectImage
        Try
            If e.Node.GetValue("NODE_TYPE") = "G" OrElse e.Node.GetValue("NODE_TYPE") = "R" Then
                e.NodeImageIndex = 19
            Else
                e.NodeImageIndex = 18
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub HelpTree_DoubleClick(sender As System.Object, e As System.EventArgs) Handles HelpTree.DoubleClick

        If sender.FocusedNode.GetValue("NODE_TYPE").ToString <> "N" Then Exit Sub

        NODE_ID.Text = sender.FocusedNode.GetValue("NODE_ID").ToString
        TITLE.Text = sender.FocusedNode.GetValue("TITLE").ToString
        NodeType = sender.FocusedNode.GetValue("NODE_TYPE").ToString
        ParentNodeId = sender.FocusedNode.GetValue("PARENT_NODE_ID").ToString
        LANG_CD.SelectedValue = sender.FocusedNode.GetValue("LANG_CD").ToString

        Try
            Select Case S_SOURCE.SelectedValue
                Case "01"
                    Call LoadNodeFileForEdit(NODE_ID.Text)
                Case "07"
                    Call LoadNodeFileForEdit21(NODE_ID.Text)
            End Select
        Catch ex As Exception
            MsgBoxLocalized("Could not open selected node!" & ex.Message)
        End Try


    End Sub


    Private Sub tsmiAddFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmiAddFile.Click
        Try

            Call NewData()

            '////////WCF Service Call/////////
            Dim parentNode As String = HelpTree.FocusedNode.GetValue("NODE_ID").ToString
            Dim ds As DataSet = Me.ConvertToDataset
            Dim params() As Object = {"N", parentNode, ds} ' string -> object / ds 추가
            Dim dsResult As DataSet
            Dim drPairs As DataRow
            Try
                If S_SOURCE.SelectedValue = "01" Then
                    dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "AddNewNode", params)
                Else
                    dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "AddNewNode_Sys", params)
                End If
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
                Exit Sub
            End Try
            drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
            If drPairs("TrxCode") <> "SUCCESS" Then
                MsgBoxLocalized(drPairs("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim dr As DataRow = dsResult.Tables("Data.NodeInfo").Rows(0)
            Dim HelpDt As DataTable = CType(HelpTree.DataSource, DataTable).Copy
            HelpDt.Rows.Add()
            HelpDt.Rows(HelpDt.Rows.Count - 1)("NODE_ID") = dr("NODE_ID").ToString
            HelpDt.Rows(HelpDt.Rows.Count - 1)("NODE_TYPE") = dr("NODE_TYPE").ToString
            HelpDt.Rows(HelpDt.Rows.Count - 1)("TITLE") = dr("TITLE").ToString
            HelpDt.Rows(HelpDt.Rows.Count - 1)("PARENT_NODE_ID") = dr("PARENT_NODE_ID").ToString
            HelpDt.Rows(HelpDt.Rows.Count - 1)("DISPLAY_SEQ") = dr("DISPLAY_SEQ")

            HelpTree.DataSource = HelpDt
            HelpTree.ExpandAll()

            FindNodeYn = False
            FindFocus(HelpTree.Nodes, dr("NODE_ID").ToString)

            TITLE.Select()
            TITLE.Text = dr("TITLE").ToString
            NODE_ID.Text = dr("NODE_ID").ToString
            NodeType = dr("NODE_TYPE").ToString
            ParentNodeId = dr("PARENT_NODE_ID").ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tsmiAddSubFolder_Click(sender As System.Object, e As System.EventArgs) Handles tsmiAddSubFolder.Click
        Try
            Dim parentNode As String = HelpTree.FocusedNode.GetValue("NODE_ID").ToString

            '////////WCF Service Call/////////
            Dim ds As DataSet = Me.ConvertToDataset
            Dim params() As Object = {"G", parentNode, ds}
            Dim dsResult As DataSet
            Dim drPairs As DataRow
            Try
                If S_SOURCE.SelectedValue = "01" Then
                    dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "AddNewNode", params)
                Else
                    dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "AddNewNode_Sys", params)
                End If

            Catch ex As Exception
                MsgBoxSC(ex.Message)
                Exit Sub
            End Try

            drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
            If drPairs("TrxCode") <> "SUCCESS" Then
                MsgBoxLocalized(drPairs("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim dr As DataRow = dsResult.Tables("Data.NodeInfo").Rows(0)
            Dim HelpDt As DataTable = CType(HelpTree.DataSource, DataTable).Copy
            HelpDt.Rows.Add()
            HelpDt.Rows(HelpDt.Rows.Count - 1)("NODE_ID") = dr("NODE_ID").ToString
            HelpDt.Rows(HelpDt.Rows.Count - 1)("NODE_TYPE") = dr("NODE_TYPE").ToString
            HelpDt.Rows(HelpDt.Rows.Count - 1)("TITLE") = dr("TITLE").ToString
            HelpDt.Rows(HelpDt.Rows.Count - 1)("PARENT_NODE_ID") = dr("PARENT_NODE_ID").ToString
            HelpDt.Rows(HelpDt.Rows.Count - 1)("DISPLAY_SEQ") = dr("DISPLAY_SEQ")

            HelpTree.DataSource = HelpDt
            HelpTree.ExpandAll()

            FindNodeYn = False
            FindFocus(HelpTree.Nodes, dr("NODE_ID").ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub HelpTree_BeforeDragNode(sender As System.Object, e As DevExpress.XtraTreeList.BeforeDragNodeEventArgs) Handles HelpTree.BeforeDragNode
        PreNodeId = sender.FocusedNode.GetValue("PARENT_NODE_ID").ToString
    End Sub

    Private Sub HelpTree_AfterDragNode(sender As System.Object, e As DevExpress.XtraTreeList.NodeEventArgs) Handles HelpTree.AfterDragNode

        If PreNodeId <> sender.FocusedNode.GetValue("PARENT_NODE_ID").ToString Then
            Call ChangeParentNode(sender.FocusedNode.GetValue("NODE_ID").ToString, sender.FocusedNode.GetValue("PARENT_NODE_ID").ToString)
        End If

    End Sub

    Private Sub SEARCH_KEY_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles SEARCH_KEY.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            If S_SOURCE.SelectedValue = "01" Then
                Call loadHelpRoots()
            Else
                Call LoadHelpRoots_Sys()
            End If
        End If
    End Sub
    Private Sub tbSave_Click(sender As System.Object, e As System.EventArgs)
        SaveData()
    End Sub
    Private Sub tbNew_Click(sender As System.Object, e As System.EventArgs)
        Call clearRTF()
        Call SetDefault()
    End Sub


    Private Sub tsmiRefresh_Click_1(sender As System.Object, e As System.EventArgs) Handles tsmiRefresh.Click
        Call loadHelpRoots()
    End Sub
    Private Sub tsmiDeleteFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmiDeleteFolder.Click
        If MsgBoxLocalized("Do you want to Delete?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        Dim node As String = HelpTree.FocusedNode("NODE_ID").ToString
        Dim nodeType As String = HelpTree.FocusedNode("NODE_TYPE").ToString
        Call DeleteNode(node, nodeType)
    End Sub

    Private Sub tsmiDeleteFile_Click(sender As Object, e As EventArgs) Handles tsmiDeleteFile.Click
        If MsgBoxLocalized("Do you want to Delete?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        Dim node As String = HelpTree.FocusedNode("NODE_ID").ToString
        Dim nodeType As String = HelpTree.FocusedNode("NODE_TYPE").ToString
        Call DeleteNode(node, nodeType)
    End Sub


    Private Sub tsmiRename_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmiRename.Click

        Dim NodeId As String = HelpTree.FocusedNode.GetValue("NODE_ID").ToString
        Dim Title As String = HelpTree.FocusedNode.GetValue("TITLE").ToString
        NodeType = HelpTree.FocusedNode.GetValue("NODE_TYPE").ToString
        ParentNodeId = HelpTree.FocusedNode.GetValue("PARENT_NODE_ID").ToString

        HelpTree.Columns("TITLE").OptionsColumn.AllowEdit = True
        HelpTree.ShowEditor()

    End Sub

    Private Sub tsmiRenameFolder_Click(sender As System.Object, e As System.EventArgs) Handles tsmiRenameFolder.Click

        Dim NodeId As String = HelpTree.FocusedNode.GetValue("NODE_ID").ToString
        Dim Title As String = HelpTree.FocusedNode.GetValue("TITLE").ToString
        NodeType = HelpTree.FocusedNode.GetValue("NODE_TYPE").ToString
        ParentNodeId = HelpTree.FocusedNode.GetValue("PARENT_NODE_ID").ToString

        HelpTree.Columns("TITLE").OptionsColumn.AllowEdit = True
        HelpTree.ShowEditor()

    End Sub

    Private Sub HelpTree_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles HelpTree.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim NodeId As String = HelpTree.FocusedNode.GetValue("NODE_ID").ToString
            Dim Title As String = HelpTree.FocusedNode.GetValue("TITLE").ToString
            NodeType = HelpTree.FocusedNode.GetValue("NODE_TYPE").ToString
            ParentNodeId = HelpTree.FocusedNode.GetValue("PARENT_NODE_ID").ToString

            HelpTree.Columns("TITLE").OptionsColumn.AllowEdit = True
            HelpTree.ShowEditor()
        End If

    End Sub

    Private Sub HelpTree_CellValueChanged(sender As System.Object, e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles HelpTree.CellValueChanged
        Select Case e.Column.FieldName
            Case "TITLE"
                Call UpdateTitle(HelpTree.FocusedNode.GetValue("NODE_ID").ToString, HelpTree.FocusedNode.GetValue("TITLE").ToString)
        End Select
    End Sub
    Private Sub tsmiRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Select Case S_SOURCE.SelectedValue
            Case "01" 'ELVIS
                Call loadHelpRoots()
            Case "07" 'ELVIS_21
                Call LoadHelpRoots_Sys()
        End Select
    End Sub
    Private Sub tmsRefresh_Click(sender As System.Object, e As System.EventArgs) Handles tmsRefresh.Click
        Select Case S_SOURCE.SelectedValue
            Case "01" 'ELVIS
                Call loadHelpRoots()
            Case "07" 'ELVIS_21
                Call LoadHelpRoots_Sys()
        End Select
    End Sub

    Private Sub tsmiOpenFile_Click(sender As System.Object, e As System.EventArgs) Handles tsmiOpenFile.Click

        If HelpTree.FocusedNode.GetValue("NODE_TYPE").ToString <> "N" Then Exit Sub

        NODE_ID.Text = HelpTree.FocusedNode.GetValue("NODE_ID").ToString
        TITLE.Text = HelpTree.FocusedNode.GetValue("TITLE").ToString
        NodeType = HelpTree.FocusedNode.GetValue("NODE_TYPE").ToString
        ParentNodeId = HelpTree.FocusedNode.GetValue("PARENT_NODE_ID").ToString
        Try
            Call LoadNodeFileForEdit(NODE_ID.Text)
        Catch ex As Exception
            MsgBoxLocalized("Could not open selected node!" & ex.Message)
        End Try

    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Call clearRTF()
        Call SetDefault()
    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If MsgBoxLocalized("Do you want to Delete?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        Dim node As String = HelpTree.FocusedNode("NODE_ID").ToString
        Dim nodeType As String = HelpTree.FocusedNode("NODE_TYPE").ToString
        '20240308 김정현 loadHelpRoots -> DeleteNode로 이동
        Call DeleteNode(node, nodeType)
        'Call loadHelpRoots()
    End Sub
    Private Sub BarButtonItem3_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        SaveData()
    End Sub

    '20240314 김정현 소스 버전 콤보박스 추가
    Private Sub S_SOURCE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S_SOURCE.SelectedIndexChanged
        Call SetDefault()
        Select Case S_SOURCE.SelectedValue
            Case "01" 'ELVIS
                Call loadHelpRoots()
            Case "07" 'ELVIS_21 - 버전 추가시 테이블명도 변수로 전달
                S_IP.Text = "110.45.209.98"
                S_PORT.Text = "1521"
                S_SID.Text = "ORCL"
                S_USER_ID.Text = "ELVIS_PLUS_SYS"
                S_PASSWORD.Text = "YJITSYS21@!"
                Call LoadHelpRoots_Sys()
        End Select
        Call AddBulletedListToDocument()
    End Sub


#End Region

End Class



