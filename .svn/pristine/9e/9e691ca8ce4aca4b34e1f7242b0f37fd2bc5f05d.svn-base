Imports System
Imports System.Reflection
Imports System.IO

Public Class MdmProgramMgt

#Region "=================Data logic actions==========="
    Public Sub SearchData()
        '////////Validation Check///////////
        If Me.ValidateActionDataLogic(UI.ActionTypes.LoadData) = False Then Exit Sub
        If Me.ValidateRequiredData({S_SYS_ID}) = False Then Exit Sub

        '////////WCF Service Call/////////
        'Build up the parameter (array type)
        Dim params() As Object = {Me.S_SYS_ID.SelectedValue, S_PGM_GRP.Text, S_PGM_ID.Text}

        Dim dsRet As DataSet
        Dim drPairs As DataRow

        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CodProg", "Search", params)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        '//////Parsing WCF returned data///////
        drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        If drPairs("TrxCode") = "SUCCESS" Then
            Me.BindToDataset(dsRet, "Data")
        ElseIf drPairs("TrxCode") = "NODATA" Then
            Me.BindToDataset(dsRet, "Data")
            MsgBox(drPairs("TrxMsg"))
            Exit Sub
        End If


        '/////Set post datastate/////////
        Me.DataState = UI.DataStates.None
    End Sub

    Public Sub SaveData()
        '////////Validation Check///////////
        If Me.ValidateActionDataLogic(UI.ActionTypes.UpdateData) = False Then Exit Sub
        If Me.ValidateRequiredData({S_SYS_ID}) = False Then Exit Sub

        '////////WCF Service Call/////////
        Dim dsParams As DataSet = Me.ConvertToDataset()

        Dim dsResult As DataSet
        Dim drPairs As DataRow

        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CodProg", "Save", dsParams)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        '//////Exploring the returned information///////
        drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode") = "SUCCESS" Then
            MsgBox(drPairs("TrxMsg"))
            'Re-display again the retrieve result
            Me.BindToDataset(dsResult, "SearchResult.Data")
        Else
            Exit Sub
        End If

        '/////Set post datastate/////////
        Me.DataState = UI.DataStates.Retrieved
    End Sub
    Private Function GetGrpId(ByVal sys_id As String, ByVal pgm_id As String, ByVal func_id As String, ByVal grp_id As String) As String

        Dim params() As Object = {sys_id, pgm_id, func_id}
        Dim dsRet As DataSet
        Dim drPairs As DataRow
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CodProg", "GetGrpId", params)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ""
        End Try

        '//////Parsing WCF returned data///////
        drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        If drPairs("GRP_ID").ToString = "NODATA" Then
            Return grp_id
        Else
            Return drPairs("GRP_ID").ToString
        End If
        Me.DataState = UI.DataStates.None

    End Function

#End Region

#Region "============Control events============"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub btnAddRowWG1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRowWG1.Click
        WG1.AddRow()
        WG1_PGM_GRP.Focus()
    End Sub

    Private Sub btnRemoveRowWG1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRowWG1.Click
        WG1.DeleteRow()
    End Sub

    Private Sub CodProg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.S_SYS_ID.DefVal = "FMS"

        'fill combo
        Dim cboObject As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        cboObject.DisplayMember = "NAME"
        cboObject.ValueMember = "CODE"
        cboObject.DataSource = CType(WG1_PGM_TYPE.DataSource, DataTable).Copy
        GV1.Columns("PGM_TYPE").ColumnEdit = cboObject
        '--------------------------------------------------------------------------------------------------------------------------
        'Init the Assembly browsers
        '--------------------------------------------------------------------------------------------------------------------------
        loadFEDirectory(Nothing)
    End Sub

    Private Sub trwFileExplorer_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trwFileExplorer.BeforeExpand
        If e.Node.Tag = "Folder" Then
            Dim node As TreeNode = loadFEDirectory(e.Node)
        End If
    End Sub

    Private Function loadFEDirectory(ByVal parentNode As TreeNode) As TreeNode
        Try
            Dim sNodePath As String
            Dim rootDir As DirectoryInfo    'in this context only
            Dim parentNodeCollection As TreeNodeCollection

            If parentNode Is Nothing Then
                'Load the root specified from the combo
                sNodePath = Application.StartupPath
                parentNodeCollection = trwFileExplorer.Nodes
                'Clear the tree before loading
                parentNodeCollection.Clear()

            Else
                sNodePath = Application.StartupPath & "\" & parentNode.FullPath
                parentNodeCollection = parentNode.Nodes
                'Remove the empty child added (See: (***))
                parentNodeCollection.Clear()
            End If

            'Get the selected dir infor
            rootDir = New DirectoryInfo(sNodePath & "\")

            For Each dir As DirectoryInfo In rootDir.GetDirectories()
                If dir.Attributes <> FileAttributes.Directory Then
                    Continue For
                End If
                Dim node As New TreeNode()
                node.Text = dir.Name
                node.Name = dir.Name
                node.Nodes.Add("")      'Add the empty child to mark this is not a leaf (***)
                parentNodeCollection.Add(node)
                node.ImageKey = "Folder"
                node.SelectedImageKey = "Folder"
                node.Tag = "Folder"
            Next
            'Fill files
            For Each file As FileInfo In rootDir.GetFiles()

                If file.Attributes = FileAttributes.Hidden Then
                    Continue For
                End If

                If sNodePath = Application.StartupPath Then
                    'If root app folder, only display user defined ass
                    If Not file.Name.StartsWith("YJIT.") Then
                        Continue For
                    End If
                End If
                If file.Extension.ToLower <> ".dll" And file.Extension.ToLower <> ".exe" Then
                    Continue For   'Only display sql files
                End If

                Dim node As New TreeNode()
                node.Text = file.Name
                If file.FullName.ToLower.EndsWith(".dll") Then
                    node.ImageKey = "DllFile"
                    node.SelectedImageKey = "DllFile"
                ElseIf file.FullName.ToLower.EndsWith(".exe") Then
                    node.ImageKey = "ExeFile"
                    node.SelectedImageKey = "ExeFile"
                End If

                node.Tag = "File"
                node.Name = file.Name

                If parentNode IsNot Nothing Then
                    parentNode.Nodes.Add(node)
                Else
                    'Attach to root
                    trwFileExplorer.Nodes.Add(node)
                End If
            Next
            'TODO : 
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return parentNode
    End Function

    ''' <summary>
    ''' Load all programs and their function buttons from the Assembly for management
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>This function is only for the first time of program management only</remarks>
    Private Sub trwFileExplorer_NodeMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles trwFileExplorer.NodeMouseDoubleClick
        Dim ass As Assembly

        If trwFileExplorer.SelectedNode Is Nothing OrElse trwFileExplorer.SelectedNode.Tag = "Folder" Then Exit Sub
        If Not (trwFileExplorer.SelectedNode.FullPath.ToLower.EndsWith(".dll") OrElse trwFileExplorer.SelectedNode.FullPath.ToLower.EndsWith(".exe")) Then
            MsgBox("Please select a module/assembly!")
            Exit Sub
        End If
        Dim filePath As String = Application.StartupPath & "\" & trwFileExplorer.SelectedNode.FullPath

        If Not System.IO.File.Exists(filePath) Then
            MsgBox("File is not existed!")
            Exit Sub
        End If

        Try
            ass = Assembly.Load(System.IO.File.ReadAllBytes(filePath))
        Catch ex As Exception
            MsgBox("Could not load assembly from file!" & ex.Message)
            Exit Sub
        End Try

        Dim strFileName As String = trwFileExplorer.SelectedNode.Name.ToUpper

        Dim frmAsk As New MdmProgramMgtF
        Dim sPGM_ID As String
        If frmAsk.ShowDialog = DialogResult.OK Then
            sPGM_ID = frmAsk.PGM_ID.Text.Trim
        Else
            Exit Sub
        End If

        'Load all program from assembly
        If Me.ValidateRequiredData({S_SYS_ID}) = False Then Exit Sub
        Dim dtRet As DataTable = New DataTable
        Dim dr As DataRow
        dtRet.Columns.Add(New DataColumn("SYS_ID"))
        dtRet.Columns.Add(New DataColumn("PGM_ID"))
        dtRet.Columns.Add(New DataColumn("FUNC_ID"))
        dtRet.Columns.Add(New DataColumn("PGM_NM"))
        dtRet.Columns.Add(New DataColumn("PGM_GRP"))
        dtRet.Columns.Add(New DataColumn("PGM_TYPE"))
        dtRet.Columns.Add(New DataColumn("DLL_NAME"))

        Dim oView As SC.UI.SCView = Nothing
        For Each tp As Type In ass.GetTypes
            If tp.BaseType Is GetType(SC.UI.SCView) Then

                If sPGM_ID <> "*" AndAlso sPGM_ID.ToUpper <> tp.Name.ToUpper.Trim Then Continue For

                dr = dtRet.NewRow
                dr("SYS_ID") = (S_SYS_ID.SelectedValue & "").ToUpper
                dr("PGM_ID") = tp.Name.ToUpper
                dr("FUNC_ID") = tp.Name.ToUpper
                Try
                    oView = ass.CreateInstance(tp.FullName, True)
                    dr("PGM_NM") = oView.Text.ToUpper
                Catch ex As Exception
                    dr("PGM_NM") = "UNKNOWN"
                End Try

                'Extract group ID
                Dim grpID As String = ""
                If tp.Name.ToUpper.StartsWith(S_SYS_ID.SelectedValue.trim.toupper) AndAlso tp.Name.Length > S_SYS_ID.SelectedValue.ToString.Trim.Length + 3 Then
                    Dim temp As String = tp.Name.Substring(3)
                    For i = 2 To temp.Length - 1
                        If Char.IsUpper(temp(i)) Then
                            temp = temp.Remove(i)
                            Exit For
                        End If
                    Next
                    grpID = temp.ToUpper     'Get third 3 characters as Group name
                Else
                    grpID = tp.Name.Substring(0, 3).ToUpper     'Get third 3 characters as Group name
                End If

                grpID = GetGrpId(dr("SYS_ID").ToString, dr("PGM_ID").ToString, dr("FUNC_ID").ToString, grpID)
                dr("PGM_GRP") = grpID

                dr("PGM_TYPE") = "P"
                dr("DLL_NAME") = strFileName    'DLL 파일명
                dtRet.Rows.Add(dr)

                'Retrieve button info recursively
                Call getButtonInfo(dtRet, oView, tp, grpID)

            End If
        Next
        WG1.DataSource = dtRet
        GV1.BestFitColumns()

    End Sub


    Private Sub getButtonInfo(ByVal dtRet As DataTable, ByVal ctrl As Object, ByVal tp As Type, ByVal grpId As String)
        Dim dr As DataRow
        If TypeOf ctrl Is SC.UI.SCControls.Button AndAlso ctrl.ButtonType <> YJIT.SC.UI.ButtonTypes.None Then
            dr = dtRet.NewRow
            dr("SYS_ID") = S_SYS_ID.SelectedValue.ToUpper
            dr("PGM_ID") = tp.Name.ToUpper
            dr("FUNC_ID") = ctrl.Name.ToString.ToUpper
            dr("PGM_NM") = ctrl.Text.ToUpper
            dr("PGM_GRP") = grpId
            dr("PGM_TYPE") = "F"
            dtRet.Rows.Add(dr)
        Else
            If ctrl.Controls.Count > 0 Then
                For Each child In ctrl.controls
                    Call getButtonInfo(dtRet, child, tp, grpId)
                Next
            End If
        End If
    End Sub

    Private Sub GV1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GV1.RowStyle
        If Trim(GV1.GetRowCellValue(e.RowHandle, "PGM_TYPE") & "") = "P" Then
            e.Appearance.BackColor = Drawing.Color.LightSkyBlue
        End If
    End Sub

    Private Sub GV1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GV1.CustomDrawRowIndicator
        Dim rowIndex As Integer = e.RowHandle
        If rowIndex >= 0 Then
            rowIndex += 1
            e.Info.DisplayText = rowIndex.ToString()
        End If

        e.Info.ImageIndex = -1
    End Sub
#End Region


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnDllAuto.Click
        'Load all program from assembly
        If Me.ValidateRequiredData({S_SYS_ID}) = False Then Exit Sub
        Dim dtRet As DataTable = New DataTable
        Dim dr As DataRow
        dtRet.Columns.Add(New DataColumn("SYS_ID"))
        dtRet.Columns.Add(New DataColumn("PGM_ID"))
        dtRet.Columns.Add(New DataColumn("FUNC_ID"))
        dtRet.Columns.Add(New DataColumn("PGM_NM"))
        dtRet.Columns.Add(New DataColumn("PGM_GRP"))
        dtRet.Columns.Add(New DataColumn("PGM_TYPE"))
        dtRet.Columns.Add(New DataColumn("DLL_NAME"))

        Dim ass As Assembly

        For Each node As System.Windows.Forms.TreeNode In trwFileExplorer.SelectedNode.Nodes
            If node Is Nothing OrElse node.Tag = "Folder" Then Continue For
            If Not (node.FullPath.ToLower.EndsWith(".dll") OrElse node.FullPath.ToLower.EndsWith(".exe")) Then
                'MsgBox("Please select a module/assembly!")
                Continue For
            End If
            Dim filePath As String = Application.StartupPath & "\" & node.FullPath

            If Not System.IO.File.Exists(filePath) Then
                'MsgBox("File is not existed!")
                Continue For
            End If

            Try
                ass = Assembly.Load(System.IO.File.ReadAllBytes(filePath))
            Catch ex As Exception
                'MsgBox("Could not load assembly from file!" & ex.Message)
                Continue For
            End Try

            Dim strFileName As String = node.Name.ToUpper
            Dim sPGM_ID As String = "*"


            Dim oView As SC.UI.SCView = Nothing
            For Each tp As Type In ass.GetTypes
                If tp.BaseType Is GetType(SC.UI.SCView) Then

                    If sPGM_ID <> "*" AndAlso sPGM_ID.ToUpper <> tp.Name.ToUpper.Trim Then Continue For

                    dr = dtRet.NewRow
                    dr("SYS_ID") = (S_SYS_ID.SelectedValue & "").ToUpper
                    dr("PGM_ID") = tp.Name.ToUpper
                    dr("FUNC_ID") = tp.Name.ToUpper
                    Try
                        oView = ass.CreateInstance(tp.FullName, True)
                        dr("PGM_NM") = oView.Text.ToUpper
                    Catch ex As Exception
                        dr("PGM_NM") = "UNKNOWN"
                    End Try

                    'Extract group ID
                    Dim grpID As String = ""
                    If tp.Name.ToUpper.StartsWith(S_SYS_ID.SelectedValue.trim.toupper) AndAlso tp.Name.Length > S_SYS_ID.SelectedValue.ToString.Trim.Length + 3 Then
                        Dim temp As String = tp.Name.Substring(3)
                        For i = 2 To temp.Length - 1
                            If Char.IsUpper(temp(i)) Then
                                temp = temp.Remove(i)
                                Exit For
                            End If
                        Next
                        grpID = temp.ToUpper     'Get third 3 characters as Group name
                    Else
                        grpID = tp.Name.Substring(0, 3).ToUpper     'Get third 3 characters as Group name
                    End If

                    grpID = GetGrpId(dr("SYS_ID").ToString, dr("PGM_ID").ToString, dr("FUNC_ID").ToString, grpID)
                    dr("PGM_GRP") = grpID

                    dr("PGM_TYPE") = "P"
                    dr("DLL_NAME") = strFileName    'DLL 파일명
                    dtRet.Rows.Add(dr)
                End If
            Next
        Next


        Dim sw As New System.IO.StreamWriter("C:\Temp\NotExistDllNameList.txt", True)
        Dim bExist As Boolean = False
        For Each row As DataRow In dtRet.Rows
            bExist = False
            For i = 0 To GV1.RowCount - 1
                Dim pgmid As String = GV1.GetRowCellValue(i, "PGM_ID").ToString
                Dim pgmgb As String = GV1.GetRowCellValue(i, "PGM_TYPE").ToString
                Dim dllname As String = GV1.GetRowCellValue(i, "DLL_NAME").ToString
                If pgmgb = "P" AndAlso dllname = "" AndAlso pgmid = row("PGM_ID").ToString Then
                    GV1.SetRowCellValue(i, "DLL_NAME", row("DLL_NAME".ToString))
                    bExist = True
                End If
            Next

            If bExist = False Then
                sw.WriteLine(row("DLL_NAME".ToString))
            End If
        Next
        sw.Close()
    End Sub
End Class