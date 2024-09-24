'
' * OutlookDataObject - Drag and drop of outlook messages and attachments - http://www.iwantedue.com
' * Copyright (C) 2008 David Ewen
' *
' * == BEGIN LICENSE ==
' *
' * Licensed under the terms of following license:
' *
' *  - The Code Project Open License 1.02 or later (the "CPOL")
' *    http://www.codeproject.com/info/cpol10.aspx
' *
' * == END LICENSE ==
' *
' * This file defines the OutlookDataObject class used to gain access to dropped outlook
' * messages and attachments
' 

Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.ComTypes
Imports System.Text
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.BandedGrid




Public Class ComDoc

    Enum FileUploadType
        Paste
        FileChoose
        DragLocal
        DragAttach
    End Enum
    Private uploadPath As String = "/EDMS/DOC/" & Common.SavedSessionDomain & "/" & ClientSessionOfficeInfo.CustomsCode & "/"
    Private tempFolder As String = Application.StartupPath & "\TMP_OUTPUT"
    Private imgComboBox As RepositoryItemImageComboBox
    Private imgExtension As ImageCollection
    Private MouseIsDown As Boolean
    Dim WG1 As YJIT.SC.UI.SCControls.WebGrid
    Dim GV1 As AdvBandedGridView
    Public byteUploadFiles As Dictionary(Of String, Object)
    Dim specialChars() As Char = "\/:*?<>|"""
    Dim locLzr As Localizer
    Dim ToolTipController1 As New DevExpress.Utils.ToolTipController

#Region "comdoc"
    Public Function CreateFile() As String
        Dim fullName As String = String.Empty
        Dim strMessage As String = String.Empty
        If GV1.RowCount < 1 Then Return String.Empty
        If GV1.GetFocusedRowCellValue("SUCCESS").ToString() = "N" Then Return String.Empty
        If GV1.GetFocusedRowCellValue("FILE_NM").ToString.Trim() = String.Empty Then Return String.Empty
        Try

            If Not byteUploadFiles.ContainsKey(GV1.GetFocusedRowCellValue("FILE_NM").ToString) Then

                Dim retD As New Dictionary(Of String, String)
                Dim strFileName As String = removeSpecialChars(GV1.GetFocusedRowCellValue("MNGT_NO").ToString) & "_" & GV1.GetFocusedRowCellValue("SEQ").ToString

                If GV1.GetFocusedRowCellValue("FORM_ID").ToString <> "OnlineHelp" Then
                    'If the file is already uploaded.
                    retD = DownLoadFile(strFileName, GV1.GetFocusedRowCellValue("FILE_NM").ToString, GV1.GetFocusedRowCellValue("FILE_PATH").ToString, "")
                Else
                    retD = DownLoadFileOnline(GV1.GetFocusedRowCellValue("FILE_NM").ToString, GV1.GetFocusedRowCellValue("FILE_PATH").ToString, "")
                End If
                If retD("TrxCode").ToString = "Y" Then
                    fullName = retD("FullName").ToString
                Else
                    MsgBox(retD("TrxMsg").ToString, MessageBoxButtons.OK, "Document Management")
                End If
                strMessage = "Error occured during attachment download."
            Else

                fullName = getTempFolder() & "\" & removeSpecialChars(GV1.GetFocusedRowCellValue("FILE_NM").ToString)
                File.WriteAllBytes(fullName, byteUploadFiles(GV1.GetFocusedRowCellValue("FILE_NM").ToString))

                strMessage = "Couldn't load file. " & fullName
            End If
        Catch ex As Exception
            Throw New Exception(strMessage + ex.Message)
        End Try
        Return fullName
    End Function
    Public Sub OpenFile(ByVal fileName As String)
        Dim p As New System.Diagnostics.Process
        Dim s As New System.Diagnostics.ProcessStartInfo(fileName)
        s.UseShellExecute = True
        s.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo = s
        p.Start()
    End Sub
    Public Sub SetUploadPath(ByVal DirList() As String)
        uploadPath = "/EDMS/DOC/"
        For i As Integer = 0 To DirList.Length - 1
            If DirList(i) = "" Then
                Continue For
            Else
                uploadPath &= DirList(i) & "/"
            End If
        Next
    End Sub
    Private Sub SetIMGCombo()
        imgComboBox = New RepositoryItemImageComboBox()
        imgExtension = CType(YJIT.SC.UI.SCView.MainFormInstance, Object).DocumentImage
        imgComboBox.Items.Add(New ImageComboBoxItem("", "dft", 0))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "avi", 1))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "exe", 3))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "pdf", 8))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "mp3", 6))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "mp4", 7))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "jpg", 5))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "png", 9))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "rar", 11))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "doc", 2))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "docx", 2))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "ppt", 10))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "pptx", 10))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "xls", 14))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "xlsx", 14))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "txt", 12))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "wmv", 13))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "zip", 15))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "hwp", 4))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "UPLOAD", 16))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "N", 17))
        imgComboBox.Items.Add(New ImageComboBoxItem("", "Y", 18))
        imgComboBox.SmallImages = CType(YJIT.SC.UI.SCView.MainFormInstance, Object).DocumentImage
    End Sub
    Private Sub TooltipAcctGrid(ByVal hitInfo As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo)

        Dim HintString As String = ""

        If hitInfo.InRowCell AndAlso hitInfo.Column.FieldName = "FILE_NM" Then
            If hitInfo.Column.FieldName = "FILE_NM" Then
                HintString = "You can drag and drop files from/to MS Outlook and Windows Explorer."
            Else
                ToolTipController1.HideHint()
            End If
            ToolTipController1.ShowHint(HintString)
        Else
            ToolTipController1.HideHint()
        End If
    End Sub
    Public Function getImageComboBox() As RepositoryItemImageComboBox
        Return imgComboBox
    End Function
    Public Function removeSpecialChars(ByVal strInput As String)
        For Each ch As Char In specialChars
            If strInput.Contains(ch) Then
                strInput = strInput.Replace(ch, String.Empty)
            End If
        Next
        Return strInput
    End Function
    Public Function IsContainExtension(ByVal strExtension As String) As Boolean
        Dim isContain As Boolean = False
        For Each item As DevExpress.XtraEditors.Controls.ImageComboBoxItem In imgComboBox.Items
            If item.Value.ToString = strExtension Then
                isContain = True
            End If
        Next
        Return isContain
    End Function
    Public Function getIcons() As ImageCollection
        Return imgExtension
    End Function
    Public Function fileExist(ByVal fullname As String, ByVal gv1 As AdvBandedGridView) As Boolean
        Dim isExist As Boolean = False
        For i As Integer = 0 To gv1.RowCount - 1
            If (gv1.GetRowCellValue(i, "FILE_NM").ToString = fullname) Then
                isExist = True
            End If
        Next
        Return isExist
    End Function


    Public Function DownLoadFile(ByVal strPrefix As String, ByVal sourcefile As String, ByVal sourcepath As String, ByVal targetfile As String) As Dictionary(Of String, String)
        Dim retD As New Dictionary(Of String, String)
        Try
            'Me.Cursor = Cursors.WaitCursor

            'Folder validation
            If Not IO.Directory.Exists(tempFolder) Then
                IO.Directory.CreateDirectory(tempFolder)
            End If

            'Default file path and name
            If targetfile = "" Then
                targetfile = IO.Path.Combine(tempFolder & "\", sourcefile)
            End If

            'If target file exists, it will be deleted and overwritten.
            If IO.File.Exists(targetfile) Then
                IO.File.Delete(targetfile)
            End If

            'Copy file to WCF\UploadFiles\UserID folder
            Dim dsResult As DataSet
            Dim dr As DataRow
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ComDocumentMgt", "Copy", {sourcepath, strPrefix & "_" & sourcefile})
            dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

            'If the file is copied, it can be downloaded.
            If dr("TrxCode") = "Y" Then
                Dim urlPath As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "UploadFiles/" & ClientSessionInfo.UserID & "/" & strPrefix & "_" & sourcefile
                My.Computer.Network.DownloadFile(urlPath, targetfile)
                retD.Add("TrxCode", "Y")
                retD.Add("FileName", Path.GetFileName(targetfile))
                retD.Add("FilePath", Path.GetDirectoryName(targetfile))
                retD.Add("FullName", targetfile)
            Else
                retD.Add("TrxCode", "N")
                retD.Add("TrxMsg", "Couldn't download file! " & dr("TrxMsg").ToString)
            End If
        Catch ex As Exception
            retD.Add("TrxCode", "E")
            retD.Add("TrxMsg", "During download process, error occured! " & ex.Message)
        Finally
            'Me.Cursor = Cursors.Default
        End Try
        Return retD
    End Function
    Public Function DownLoadFileOnline(ByVal sourcefile As String, ByVal sourcepath As String, ByVal targetfile As String) As Dictionary(Of String, String)
        Dim retD As New Dictionary(Of String, String)
        Try
            'Me.Cursor = Cursors.WaitCursor

            'Folder validation
            If Not IO.Directory.Exists(tempFolder) Then
                IO.Directory.CreateDirectory(tempFolder)
            End If

            'Default file path and name
            If targetfile = "" Then
                targetfile = IO.Path.Combine(tempFolder & "\", sourcefile)
            End If

            'If target file exists, it will be deleted and overwritten.
            If IO.File.Exists(targetfile) Then
                IO.File.Delete(targetfile)
            End If

            'Copy file to WCF\UploadFiles\UserID folder
            Dim dsResult As DataSet
            Dim dr As DataRow
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ComDocumentMgt", "Copy", {sourcepath, sourcefile})
            dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

            'If the file is copied, it can be downloaded.
            If dr("TrxCode") = "Y" Then
                Dim urlPath As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "UploadFiles/" & ClientSessionInfo.UserID & "/" & sourcefile
                My.Computer.Network.DownloadFile(urlPath, targetfile)
                retD.Add("TrxCode", "Y")
                retD.Add("FileName", Path.GetFileName(targetfile))
                retD.Add("FilePath", Path.GetDirectoryName(targetfile))
                retD.Add("FullName", targetfile)
            Else
                retD.Add("TrxCode", "N")
                retD.Add("TrxMsg", "Couldn't download file! " & dr("TrxMsg").ToString)
            End If
        Catch ex As Exception
            retD.Add("TrxCode", "E")
            retD.Add("TrxMsg", "During download process, error occured! " & ex.Message)
        Finally
            'Me.Cursor = Cursors.Default
        End Try
        Return retD
    End Function
    Public Function MandatoryGridValue(ByVal GV1 As AdvBandedGridView) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing
        checkNull = {"DOC_NO"}
        Param("DOC_TYPE") = "Document Type"
        Param("DOC_NO") = "Document No"
        Return ValidateGridValue(GV1, Param, checkNull)
    End Function


    Private Sub SetGridViewSequence(ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Dim rowIndex As Integer = e.RowHandle
        e.Info.DisplayText = locLzr.GetLocalizedString("NO")
        If rowIndex >= 0 Then
            rowIndex += 1
            e.Info.DisplayText = rowIndex.ToString()
        End If
        e.Info.ImageIndex = -1
    End Sub
    Private Sub WG1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Or e.Data.GetDataPresent("FileGroupDescriptor") Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub WG1_EditorKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If GV1.FocusedColumn.FieldName = "FILE_NM" Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub WG1_ProcessGridKey(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If GV1.FocusedColumn.FieldName = "FILE_NM" Then
                If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
                    GV1.SetFocusedRowCellValue("FILE_NM", "")
                    GV1.SetFocusedRowCellValue("FILE_ICON", "")
                    byteUploadFiles(Integer.Parse(GV1.GetFocusedRowCellValue("SEQ"))) = Nothing
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub WG1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim fileNames As String() = {}
        Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo
        hitInfo = GV1.CalcHitInfo(WG1.PointToClient(New Point(e.X, e.Y)))
        Dim intTargetRow As Integer = hitInfo.RowHandle

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            fileNames = e.Data.GetData(DataFormats.FileDrop)
            InsertFile(FileUploadType.DragLocal, intTargetRow, fileNames, DBNull.Value)
        End If
        If e.Data.GetDataPresent("FileGroupDescriptor") Then
            Dim dataObject As OutlookDataObject = New OutlookDataObject(e.Data)
            fileNames = DirectCast(dataObject.GetData("FileGroupDescriptorW"), String())
            InsertFile(FileUploadType.DragAttach, intTargetRow, fileNames, dataObject.GetData("FileContents"))
        End If
    End Sub
    Private Sub WG1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            If GV1.RowCount > 0 And GV1.FocusedColumn.FieldName = "UPLOAD" Then
                Dim ofd As OpenFileDialog = New OpenFileDialog()
                If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim FileNames() As String = ofd.FileNames
                    InsertFile(FileUploadType.FileChoose, GV1.FocusedRowHandle, FileNames, DBNull.Value)
                End If
                GV1.FocusedColumn = GV1.Columns("FILE_NM")
            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub GV1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim hitinfo As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = GV1.CalcHitInfo(New Point(e.X, e.Y))
        Call TooltipAcctGrid(hitinfo)


        Dim fullName As String = ""
        If MouseIsDown Then
            Try
                Dim Index As Integer = GV1.CalcHitInfo(e.X, e.Y).RowHandle
                If Index > -1 _
                            And e.Button = Windows.Forms.MouseButtons.Left Then
                    Dim retD As New Dictionary(Of String, String)

                    GV1.FocusedRowHandle = Index

                    If byteUploadFiles(Integer.Parse(GV1.GetFocusedRowCellValue("SEQ"))) Is Nothing Then
                        'If the file is already uploaded.
                        If GV1.GetFocusedRowCellValue("FORM_ID").ToString <> "OnlineHelp" Then
                            fullName = DownLoadFile(removeSpecialChars(GV1.GetRowCellValue(Index, "MNGT_NO").ToString) & "_" & GV1.GetRowCellValue(Index, "SEQ").ToString, _
                                            GV1.GetRowCellValue(Index, "FILE_NM").ToString, _
                                            GV1.GetRowCellValue(Index, "FILE_PATH").ToString, "")("FullName")
                        Else
                            fullName = DownLoadFileOnline(GV1.GetRowCellValue(Index, "FILE_NM").ToString, _
                            GV1.GetRowCellValue(Index, "FILE_PATH").ToString, "")("FullName")
                        End If


                    ElseIf IO.File.Exists(GV1.GetRowCellValue(Index, "FILE_PATH").ToString) Then
                        'if the file is not uploaded yet, but inserted
                        fullName = GV1.GetFocusedRowCellValue("FILE_PATH").ToString
                    Else
                        'file is downloaded
                        fullName = getTempFolder() & "\" & GV1.GetFocusedRowCellValue("FILE_NM").ToString
                        If IO.File.Exists(fullName) Then
                            IO.File.Delete(fullName)
                        End If
                        File.WriteAllBytes(fullName, byteUploadFiles(Integer.Parse(GV1.GetFocusedRowCellValue("SEQ"))))
                    End If

                    If fullName <> "" Then
                        ' Initiate dragging.
                        Dim data As DataObject = New DataObject()
                        data.SetData(DataFormats.FileDrop, New String() {fullName})
                        GV1.GridControl.DoDragDrop(data, DragDropEffects.Copy)
                    End If
                End If
            Catch ex As Exception
            End Try
        End If

        MouseIsDown = False
    End Sub
    Private Sub GV1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        MouseIsDown = True
    End Sub
    Private Sub GV1_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Call SetGridViewSequence(e)
    End Sub


    Private Sub GV1_DoubleClick(sender As System.Object, e As DevExpress.Utils.DXMouseEventArgs)

        If GV1.FocusedRowHandle < 0 Then Exit Sub

        If (e.Handled = True) Then Exit Sub

        Try
            Dim fullName As String = String.Empty
            If (GV1.FocusedColumn.FieldName = "FILE_NM" Or GV1.FocusedColumn.FieldName = "FILE_ICON") Then fullName = CreateFile()
            If System.IO.File.Exists(fullName) Then OpenFile(fullName)

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxButtons.OK, "Document Management")
        End Try

        e.Handled = True
    End Sub
    '2018.08.28 Bilgun. Sequence will not be used as a key anymore.
    'Private Sub GV1_DoubleClick(ByVal sender As System.Object, e As DevExpress.Utils.DXMouseEventArgs)
    '    Dim strMessage As String = ""

    '    If GV1.FocusedRowHandle < 0 Then Exit Sub

    '    If e.Handled = True Then Exit Sub


    '    Try
    '        If GV1.GetFocusedRowCellValue("SEQ").ToString = "" Then Exit Sub
    '        If byteUploadFiles(Integer.Parse(GV1.GetFocusedRowCellValue("SEQ"))) Is Nothing Then
    '            If (GV1.FocusedColumn.FieldName = "FILE_NM" Or GV1.FocusedColumn.FieldName = "FILE_ICON") And GV1.RowCount > 0 And GV1.GetFocusedRowCellValue("SUCCESS").ToString() <> "N" Then
    '                If GV1.GetFocusedRowCellValue("FILE_NM").ToString.Trim() <> "" Then
    '                    Dim retD As New Dictionary(Of String, String)
    '                    Dim strFileName As String = removeSpecialChars(GV1.GetFocusedRowCellValue("MNGT_NO").ToString) & "_" & GV1.GetFocusedRowCellValue("SEQ").ToString
    '                    If GV1.GetFocusedRowCellValue("FORM_ID").ToString <> "OnlineHelp" Then
    '                        retD = DownLoadFile(strFileName, GV1.GetFocusedRowCellValue("FILE_NM").ToString, GV1.GetFocusedRowCellValue("FILE_PATH").ToString, "")
    '                    Else
    '                        retD = DownLoadFileOnline(GV1.GetFocusedRowCellValue("FILE_NM").ToString, GV1.GetFocusedRowCellValue("FILE_PATH").ToString, "")
    '                    End If


    '                    If retD("TrxCode").ToString = "Y" Then
    '                        Dim p As New System.Diagnostics.Process
    '                        Dim s As New System.Diagnostics.ProcessStartInfo(retD("FullName").ToString)
    '                        s.UseShellExecute = True
    '                        s.WindowStyle = ProcessWindowStyle.Normal
    '                        p.StartInfo = s
    '                        p.Start()
    '                    Else
    '                        MsgBox(retD("TrxMsg").ToString, MessageBoxButtons.OK, "Document Management")
    '                    End If
    '                End If
    '            End If
    '            strMessage = "Error occured during attachment download."
    '        Else
    '            If GV1.GetFocusedRowCellValue("FILE_NM").ToString.Trim() <> "" And GV1.GetFocusedRowCellValue("SUCCESS").ToString() <> "N" Then
    '                Dim fullname As String = getTempFolder() & "\" & GV1.GetFocusedRowCellValue("FILE_NM").ToString
    '                File.WriteAllBytes(fullname, byteUploadFiles(Integer.Parse(GV1.GetFocusedRowCellValue("SEQ"))))


    '                Dim p As New System.Diagnostics.Process
    '                Dim s As New System.Diagnostics.ProcessStartInfo(fullname)
    '                s.UseShellExecute = True
    '                s.WindowStyle = ProcessWindowStyle.Normal
    '                p.StartInfo = s
    '                p.Start()


    '                strMessage = "Couldn't load file. " & fullname
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(strMessage & " " & ex.Message, MessageBoxButtons.OK, "Document Management")
    '    End Try
    'End Sub
    Private Sub GV1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
        If e.Column.FieldName = "UPLOAD" Then
            Dim row As DataRow = GV1.GetDataRow(e.RowHandle)
            e.Appearance.FillRectangle(e.Cache, e.Bounds)
            e.Graphics.DrawImage(imgExtension.Images(16), New Rectangle(e.Bounds.X + e.Bounds.Width / 2 - 8, e.Bounds.Y, 16, 16))
            e.Handled = True
        End If
    End Sub
    Private Sub GV1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim fileNames As String() = {}
        If (e.KeyCode = Keys.V AndAlso e.Control) Then
            If Clipboard.GetDataObject.GetDataPresent("FileGroupDescriptor") Then
                Dim dataObject As OutlookDataObject = New OutlookDataObject(Clipboard.GetDataObject)
                fileNames = DirectCast(dataObject.GetData("FileGroupDescriptorW"), String())
                InsertFile(FileUploadType.DragAttach, GV1.FocusedRowHandle, fileNames, dataObject.GetData("FileContents"))
            End If
            If Clipboard.GetDataObject.GetDataPresent(DataFormats.FileDrop) Then
                InsertFile(FileUploadType.Paste, GV1.FocusedRowHandle, Clipboard.GetDataObject.GetData(DataFormats.FileDrop), DBNull.Value)
            End If
        End If
    End Sub
#End Region

#Region "Data"
    Public Sub New()
        locLzr = New Localizer()
        SetIMGCombo()
        ClearFiles()
    End Sub
    Public Sub New(ByVal WebGrid As YJIT.SC.UI.SCControls.WebGrid)
        locLzr = New Localizer()
        initGrid(WebGrid)
        SetIMGCombo()
        ClearFiles()
    End Sub
    Public Sub ClearFiles()
        byteUploadFiles = New Dictionary(Of String, Object)
    End Sub
    Public Sub initGrid(ByVal WebGrid As YJIT.SC.UI.SCControls.WebGrid)
        WG1 = WebGrid
        GV1 = WebGrid.MainView
        AddHandler WG1.DragEnter, New DragEventHandler(AddressOf WG1_DragEnter)
        AddHandler WG1.EditorKeyPress, New KeyPressEventHandler(AddressOf WG1_EditorKeyPress)
        AddHandler WG1.ProcessGridKey, New KeyEventHandler(AddressOf WG1_ProcessGridKey)
        AddHandler WG1.DragDrop, New DragEventHandler(AddressOf WG1_DragDrop)
        AddHandler GV1.MouseMove, New MouseEventHandler(AddressOf GV1_MouseMove)
        AddHandler GV1.MouseDown, New MouseEventHandler(AddressOf GV1_MouseDown)
        AddHandler GV1.CustomDrawRowIndicator, New DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(AddressOf GV1_CustomDrawRowIndicator)
        AddHandler GV1.DoubleClick, New EventHandler(AddressOf GV1_DoubleClick)
        AddHandler GV1.CustomDrawCell, New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(AddressOf GV1_CustomDrawCell)
        AddHandler WG1.Click, New EventHandler(AddressOf WG1_Click)
        AddHandler GV1.KeyDown, New KeyEventHandler(AddressOf GV1_KeyDown)
    End Sub
    Public Function getUploadPath() As String
        Return uploadPath
    End Function
    Public Function getTempFolder() As String
        Return tempFolder
    End Function
    Public Function getFiles()
        Return byteUploadFiles
    End Function
    Public Sub InsertFile(ByVal fct As FileUploadType, ByVal CurrentRow As Integer, ByVal fileNames() As String, ByVal fileContents As Object)

        GV1.FocusedRowHandle = CurrentRow
        Dim filestreams As IO.MemoryStream() = Nothing


        Try
            If fct = FileUploadType.DragAttach Then
                filestreams = DirectCast(fileContents, IO.MemoryStream())
            End If

            If fileNames.Length < 1 Then
                Exit Sub
            End If

            Dim strMNGT_NO As String = ""
            Dim strDOC_TYPE As String = ""
            Dim strDOC_NO As String = ""
            Dim strFILE_PATH As String = ""
            Dim strFILE_NM As String = ""

            'Values to be copied
            If (CurrentRow > -1 And CurrentRow < GV1.RowCount) Then
                GV1.FocusedColumn = GV1.VisibleColumns(2)
                strMNGT_NO = GV1.GetRowCellValue(CurrentRow, "MNGT_NO").ToString
                'strDOC_TYPE = GV1.GetRowCellValue(intTargetRow, "DOC_TYPE").ToString
                'strDOC_NO = GV1.GetRowCellDisplayText(intTargetRow, "DOC_NO").ToString
            End If

            For fileIndex As Integer = 0 To fileNames.Length - 1

                Dim fInfo As IO.FileInfo
                Dim fileName As String = ""
                Dim fileSize As String = ""
                Dim strExtension As String = ""
                Dim strSUCCESS As String = ""
                Dim bData As Byte() = New Byte() {}

                If fct <> FileUploadType.DragAttach Then
                    fInfo = New IO.FileInfo(fileNames(fileIndex))

                    'full path
                    strFILE_PATH = fInfo.FullName

                    Try
                        'file content
                        Dim br As IO.BinaryReader = New IO.BinaryReader(File.OpenRead(fInfo.FullName))
                        bData = br.ReadBytes(br.BaseStream.Length)
                        If bData.Length > 10485760 Then
                            strSUCCESS = "N"
                        Else
                            strSUCCESS = "Y"
                        End If
                    Catch ex As Exception
                        If ex.Message.Contains("Could not find file") Then
                            Throw New Exception("선택한 파일을 찾을 수 없습니다. 다시 시도해주세요." & vbNewLine & vbNewLine & "(" & ex.Message & ")")
                        ElseIf ex.Message.Contains("used by another process") Then
                            Throw New Exception("파일이 잠겨있습니다. 사용중인 프로그램 종료후 다시 시도해주세요." & vbNewLine & vbNewLine & "(" & ex.Message & ")")
                        Else
                            Throw New Exception(ex.Message)
                        End If
                    End Try

                    'extension
                    strExtension = fInfo.Extension.Replace(".", "").ToLower()
                    If Not IsContainExtension(strExtension) Then
                        strExtension = "dft"
                    End If

                    'file name
                    fileName = fInfo.Name

                    'file size
                    fileSize = fInfo.Length
                Else
                    'file name
                    fileName = fileNames(fileIndex)

                    If (filestreams.Length = 0) Then
                        Exit Sub
                    End If

                    'file content
                    Dim filestream As IO.MemoryStream = filestreams(fileIndex)
                    bData = New Byte(filestream.Length) {}

                    If bData.Length > 10485760 Then
                        strSUCCESS = "N"
                    Else
                        strSUCCESS = "Y"
                    End If


                    filestream.Read(bData, 0, CInt(filestream.Length))

                    'extension
                    strExtension = Path.GetExtension(fileName)
                    strExtension = strExtension.Replace(".", "")
                    If Not IsContainExtension(strExtension) Then
                        strExtension = "dft"
                    End If

                    'file size
                    fileSize = bData.Length
                End If


                'If Not fileExist(fileName, GV1) Then

                If Not (CurrentRow > -1 And CurrentRow < GV1.RowCount) Then
                    WG1.AddRow()
                    CurrentRow = GV1.RowCount - 1
                End If

                GV1.SetRowCellValue(CurrentRow, "FILE_NM", fileName)
                GV1.SetRowCellValue(CurrentRow, "FILE_ICON", strExtension)
                GV1.SetRowCellValue(CurrentRow, "MNGT_NO", strMNGT_NO)
                ' GV1.SetRowCellValue(intTargetRow, "DOC_TYPE", strDOC_TYPE)
                ' GV1.SetRowCellValue(intTargetRow, "DOC_NO", strDOC_NO)
                GV1.SetRowCellValue(CurrentRow, "FILE_PATH", strFILE_PATH)
                GV1.SetRowCellValue(CurrentRow, "SUCCESS", strSUCCESS)


                If CType(WG1.DataSource, DataTable).Columns.Contains("FILE_SIZE") = False Then
                    CType(WG1.DataSource, DataTable).Columns.Add("FILE_SIZE", GetType(String))
                End If
                GV1.SetRowCellValue(CurrentRow, "FILE_SIZE", fileSize)


                GV1.SetRowCellValue(CurrentRow, "SEQ", GetSeq(CurrentRow, strMNGT_NO))



                If byteUploadFiles.ContainsKey(fileName) Then
                    byteUploadFiles(fileName) = bData
                Else
                    byteUploadFiles.Add(fileName, bData)
                End If


                CurrentRow = GV1.RowCount
                'End If
            Next
        Catch ex As Exception
            MsgBoxSC(ex.Message)
        End Try
    End Sub
    Public Function GetSeq(ByVal intTargetRow As Integer, ByVal strMNGT_NO As String) As Integer
        Dim intSeq As Integer = -1

        If Not IsNothing(GV1.GetRowCellValue(intTargetRow, "SEQ")) AndAlso GV1.GetRowCellValue(intTargetRow, "SEQ").ToString <> "" Then
            intSeq = Integer.Parse(GV1.GetRowCellValue(intTargetRow, "SEQ"))
        Else
            Try
                Dim dsResult As DataSet
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ComDocumentMgt", "GetSequence", {New DataSet, strMNGT_NO})
                Dim dr As DataRow = dsResult.Tables("Data.Main").Rows(0)
                intSeq = Integer.Parse(dr("SEQ"))
            Catch ex As Exception
                intSeq = GV1.RowCount
            End Try

            If intSeq < GetMaxSeq() + 1 Then
                intSeq = GetMaxSeq() + 1
            End If
        End If
        Return intSeq
    End Function
    Public Function GetMaxSeq() As Integer
        Dim maxSeq As Integer = -1
        Dim curSeq As Integer = -1
        For i As Integer = 0 To GV1.RowCount - 1
            If Not IsNothing(GV1.GetRowCellValue(i, "SEQ")) AndAlso Integer.TryParse(GV1.GetRowCellValue(i, "SEQ").ToString, curSeq) Then
                If curSeq > maxSeq Then
                    maxSeq = curSeq
                End If
            End If
        Next
        Return maxSeq
    End Function
#End Region

End Class



'Outlook Data object 
    Public Class OutlookDataObject
        Implements System.Windows.Forms.IDataObject

#Region "NativeMethods"

        Private Class NativeMethods
            <DllImport("kernel32.dll")> _
            Shared Function GlobalLock(ByVal hMem As IntPtr) As IntPtr
            End Function

            <DllImport("ole32.dll", PreserveSig:=False)> _
            Public Shared Function CreateILockBytesOnHGlobal(ByVal hGlobal As IntPtr, ByVal fDeleteOnRelease As Boolean) As ILockBytes
            End Function

            <DllImport("OLE32.DLL", CharSet:=CharSet.Auto, PreserveSig:=False)> _
            Public Shared Function GetHGlobalFromILockBytes(ByVal pLockBytes As ILockBytes) As IntPtr
            End Function

            <DllImport("OLE32.DLL", CharSet:=CharSet.Unicode, PreserveSig:=False)> _
            Public Shared Function StgCreateDocfileOnILockBytes(ByVal plkbyt As ILockBytes, ByVal grfMode As UInteger, ByVal reserved As UInteger) As IStorage
            End Function

            <ComImport(), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0000000B-0000-0000-C000-000000000046")> _
            Public Interface IStorage
                Function CreateStream(<[In](), MarshalAs(UnmanagedType.BStr)> ByVal pwcsName As String, <[In](), MarshalAs(UnmanagedType.U4)> ByVal grfMode As Integer, <[In](), MarshalAs(UnmanagedType.U4)> ByVal reserved1 As Integer, <[In](), MarshalAs(UnmanagedType.U4)> ByVal reserved2 As Integer) As <MarshalAs(UnmanagedType.Interface)> IStream
                Function OpenStream(<[In](), MarshalAs(UnmanagedType.BStr)> ByVal pwcsName As String, ByVal reserved1 As IntPtr, <[In](), MarshalAs(UnmanagedType.U4)> ByVal grfMode As Integer, <[In](), MarshalAs(UnmanagedType.U4)> ByVal reserved2 As Integer) As <MarshalAs(UnmanagedType.Interface)> IStream
                Function CreateStorage(<[In](), MarshalAs(UnmanagedType.BStr)> ByVal pwcsName As String, <[In](), MarshalAs(UnmanagedType.U4)> ByVal grfMode As Integer, <[In](), MarshalAs(UnmanagedType.U4)> ByVal reserved1 As Integer, <[In](), MarshalAs(UnmanagedType.U4)> ByVal reserved2 As Integer) As <MarshalAs(UnmanagedType.Interface)> IStorage
                Function OpenStorage(<[In](), MarshalAs(UnmanagedType.BStr)> ByVal pwcsName As String, ByVal pstgPriority As IntPtr, <[In](), MarshalAs(UnmanagedType.U4)> ByVal grfMode As Integer, ByVal snbExclude As IntPtr, <[In](), MarshalAs(UnmanagedType.U4)> ByVal reserved As Integer) As <MarshalAs(UnmanagedType.Interface)> IStorage
                Sub CopyTo(ByVal ciidExclude As Integer, <[In](), MarshalAs(UnmanagedType.LPArray)> ByVal pIIDExclude() As Guid, ByVal snbExclude As IntPtr, <[In](), MarshalAs(UnmanagedType.Interface)> ByVal stgDest As IStorage)
                Sub MoveElementTo(<[In](), MarshalAs(UnmanagedType.BStr)> ByVal pwcsName As String, <[In](), MarshalAs(UnmanagedType.Interface)> ByVal stgDest As IStorage, <[In](), MarshalAs(UnmanagedType.BStr)> ByVal pwcsNewName As String, <[In](), MarshalAs(UnmanagedType.U4)> ByVal grfFlags As Integer)
                Sub Commit(ByVal grfCommitFlags As Integer)
                Sub Revert()
                Sub EnumElements(<[In](), MarshalAs(UnmanagedType.U4)> ByVal reserved1 As Integer, ByVal reserved2 As IntPtr, <[In](), MarshalAs(UnmanagedType.U4)> ByVal reserved3 As Integer, <MarshalAs(UnmanagedType.Interface)> ByRef ppVal As Object)
                Sub DestroyElement(<[In](), MarshalAs(UnmanagedType.BStr)> ByVal pwcsName As String)
                Sub RenameElement(<[In](), MarshalAs(UnmanagedType.BStr)> ByVal pwcsOldName As String, <[In](), MarshalAs(UnmanagedType.BStr)> ByVal pwcsNewName As String)
                Sub SetElementTimes(<[In](), MarshalAs(UnmanagedType.BStr)> ByVal pwcsName As String, <[In]()> ByVal pctime As System.Runtime.InteropServices.ComTypes.FILETIME, <[In]()> ByVal patime As System.Runtime.InteropServices.ComTypes.FILETIME, <[In]()> ByVal pmtime As System.Runtime.InteropServices.ComTypes.FILETIME)
                Sub SetClass(<[In]()> ByRef clsid As Guid)
                Sub SetStateBits(ByVal grfStateBits As Integer, ByVal grfMask As Integer)
                Sub Stat(<Out()> ByRef pStatStg As System.Runtime.InteropServices.ComTypes.STATSTG, ByVal grfStatFlag As Integer)
            End Interface

            <ComImport(), Guid("0000000A-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> _
            Public Interface ILockBytes
                Sub ReadAt(<[In](), MarshalAs(UnmanagedType.U8)> ByVal ulOffset As Long, <Out(), MarshalAs(UnmanagedType.LPArray, SizeParamIndex:=1)> ByVal pv() As Byte, <[In](), MarshalAs(UnmanagedType.U4)> ByVal cb As Integer, <Out(), MarshalAs(UnmanagedType.LPArray)> ByVal pcbRead() As Integer)
                Sub WriteAt(<[In](), MarshalAs(UnmanagedType.U8)> ByVal ulOffset As Long, ByVal pv As IntPtr, <[In](), MarshalAs(UnmanagedType.U4)> ByVal cb As Integer, <Out(), MarshalAs(UnmanagedType.LPArray)> ByVal pcbWritten() As Integer)
                Sub Flush()
                Sub SetSize(<[In](), MarshalAs(UnmanagedType.U8)> ByVal cb As Long)
                Sub LockRegion(<[In](), MarshalAs(UnmanagedType.U8)> ByVal libOffset As Long, <[In](), MarshalAs(UnmanagedType.U8)> ByVal cb As Long, <[In](), MarshalAs(UnmanagedType.U4)> ByVal dwLockType As Integer)
                Sub UnlockRegion(<[In](), MarshalAs(UnmanagedType.U8)> ByVal libOffset As Long, <[In](), MarshalAs(UnmanagedType.U8)> ByVal cb As Long, <[In](), MarshalAs(UnmanagedType.U4)> ByVal dwLockType As Integer)
                Sub Stat(<Out()> ByRef pstatstg As System.Runtime.InteropServices.ComTypes.STATSTG, <[In](), MarshalAs(UnmanagedType.U4)> ByVal grfStatFlag As Integer)
            End Interface

            <StructLayout(LayoutKind.Sequential)> _
            Public NotInheritable Class POINTL
                Public x As Integer
                Public y As Integer
            End Class

            <StructLayout(LayoutKind.Sequential)> _
            Public NotInheritable Class SIZEL
                Public cx As Integer
                Public cy As Integer
            End Class

            <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
            Public NotInheritable Class FILEGROUPDESCRIPTORA
                Public cItems As UInteger
                Public fgd() As FILEDESCRIPTORA
            End Class

            <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
            Public NotInheritable Class FILEDESCRIPTORA
                Public dwFlags As UInteger
                Public clsid As Guid
                Public sizel As SIZEL
                Public pointl As POINTL
                Public dwFileAttributes As UInteger
                Public ftCreationTime As System.Runtime.InteropServices.ComTypes.FILETIME
                Public ftLastAccessTime As System.Runtime.InteropServices.ComTypes.FILETIME
                Public ftLastWriteTime As System.Runtime.InteropServices.ComTypes.FILETIME
                Public nFileSizeHigh As UInteger
                Public nFileSizeLow As UInteger
                <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
                Public cFileName As String
            End Class

            <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
            Public NotInheritable Class FILEGROUPDESCRIPTORW
                Public cItems As UInteger
                Public fgd() As FILEDESCRIPTORW
            End Class

            <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
            Public NotInheritable Class FILEDESCRIPTORW
                Public dwFlags As UInteger
                Public clsid As Guid
                Public sizel As SIZEL
                Public pointl As POINTL
                Public dwFileAttributes As UInteger
                Public ftCreationTime As System.Runtime.InteropServices.ComTypes.FILETIME
                Public ftLastAccessTime As System.Runtime.InteropServices.ComTypes.FILETIME
                Public ftLastWriteTime As System.Runtime.InteropServices.ComTypes.FILETIME
                Public nFileSizeHigh As UInteger
                Public nFileSizeLow As UInteger
                <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
                Public cFileName As String
            End Class
        End Class

#End Region

#Region "Property(s)"

        ''' <summary>
        ''' Holds the <see cref="System.Windows.Forms.IDataObject"/> that this class is wrapping
        ''' </summary>
        Private underlyingDataObject As System.Windows.Forms.IDataObject

        ''' <summary>
        ''' Holds the <see cref="System.Runtime.InteropServices.ComTypes.IDataObject"/> interface to the <see cref="System.Windows.Forms.IDataObject"/> that this class is wrapping.
        ''' </summary>
        Private comUnderlyingDataObject As System.Runtime.InteropServices.ComTypes.IDataObject

        ''' <summary>
        ''' Holds the internal ole <see cref="System.Windows.Forms.IDataObject"/> to the <see cref="System.Windows.Forms.IDataObject"/> that this class is wrapping.
        ''' </summary>
        Private oleUnderlyingDataObject As System.Windows.Forms.IDataObject

        ''' <summary>
        ''' Holds the <see cref="MethodInfo"/> of the "GetDataFromHGLOBLAL" method of the internal ole <see cref="System.Windows.Forms.IDataObject"/>.
        ''' </summary>
        Private getDataFromHGLOBLALMethod As MethodInfo

#End Region

#Region "Constructor(s)"

        ''' <summary>
        ''' Initializes a new instance of the <see cref="OutlookDataObject"/> class.
        ''' </summary>
        ''' <param name="underlyingDataObject">The underlying data object to wrap.</param>
        Public Sub New(ByVal underlyingDataObject As System.Windows.Forms.IDataObject)
            'get the underlying dataobject and its ComType IDataObject interface to it
            Me.underlyingDataObject = underlyingDataObject
            Me.comUnderlyingDataObject = DirectCast(Me.underlyingDataObject, System.Runtime.InteropServices.ComTypes.IDataObject)

            'get the internal ole dataobject and its GetDataFromHGLOBLAL so it can be called later
            Dim innerDataField As FieldInfo = DirectCast(Me.underlyingDataObject, Object).GetType().GetField("innerData", BindingFlags.NonPublic Or BindingFlags.Instance)
            Me.oleUnderlyingDataObject = DirectCast(innerDataField.GetValue(Me.underlyingDataObject), System.Windows.Forms.IDataObject)
            Me.getDataFromHGLOBLALMethod = DirectCast(Me.oleUnderlyingDataObject, Object).GetType().GetMethod("GetDataFromHGLOBLAL", BindingFlags.NonPublic Or BindingFlags.Instance)
        End Sub

#End Region

#Region "IDataObject Members"

        ''' <summary>
        ''' Retrieves the data associated with the specified class type format.
        ''' </summary>
        ''' <param name="format">A <see cref="T:System.Type"></see> representing the format of the data to retrieve. See <see cref="T:System.Windows.Forms.DataFormats"></see> for predefined formats.</param>
        ''' <returns>
        ''' The data associated with the specified format, or null.
        ''' </returns>
        Public Function GetData(ByVal format As Type) As Object Implements System.Windows.Forms.IDataObject.GetData
            Return Me.GetData(format.FullName)
        End Function

        ''' <summary>
        ''' Retrieves the data associated with the specified data format.
        ''' </summary>
        ''' <param name="format">The format of the data to retrieve. See <see cref="T:System.Windows.Forms.DataFormats"></see> for predefined formats.</param>
        ''' <returns>
        ''' The data associated with the specified format, or null.
        ''' </returns>
        Public Function GetData(ByVal format As String) As Object Implements System.Windows.Forms.IDataObject.GetData
            Return Me.GetData(format, True)
        End Function

        ''' <summary>
        ''' Retrieves the data associated with the specified data format, using a Boolean to determine whether to convert the data to the format.
        ''' </summary>
        ''' <param name="format">The format of the data to retrieve. See <see cref="T:System.Windows.Forms.DataFormats"></see> for predefined formats.</param>
        ''' <param name="autoConvert">true to convert the data to the specified format; otherwise, false.</param>
        ''' <returns>
        ''' The data associated with the specified format, or null.
        ''' </returns>
        Public Function GetData(ByVal format As String, ByVal autoConvert As Boolean) As Object Implements System.Windows.Forms.IDataObject.GetData
            'handle the "FileGroupDescriptor" and "FileContents" format request in this class otherwise pass through to underlying IDataObject 
            Select Case format
                Case "FileGroupDescriptor"
                    'override the default handling of FileGroupDescriptor which returns a
                    'MemoryStream and instead return a string array of file names
                    Dim fileGroupDescriptorAPointer As IntPtr = IntPtr.Zero
                    Try
                        'use the underlying IDataObject to get the FileGroupDescriptor as a MemoryStream
                        Dim fileGroupDescriptorStream As MemoryStream = DirectCast(Me.underlyingDataObject.GetData("FileGroupDescriptor", autoConvert), MemoryStream)
                        Dim fileGroupDescriptorBytes(fileGroupDescriptorStream.Length - 1) As Byte
                        fileGroupDescriptorStream.Read(fileGroupDescriptorBytes, 0, fileGroupDescriptorBytes.Length)
                        fileGroupDescriptorStream.Close()

                        'copy the file group descriptor into unmanaged memory 
                        fileGroupDescriptorAPointer = Marshal.AllocHGlobal(fileGroupDescriptorBytes.Length)
                        Marshal.Copy(fileGroupDescriptorBytes, 0, fileGroupDescriptorAPointer, fileGroupDescriptorBytes.Length)

                        'marshal the unmanaged memory to to FILEGROUPDESCRIPTORA struct
                        Dim fileGroupDescriptorObject As Object = Marshal.PtrToStructure(fileGroupDescriptorAPointer, GetType(NativeMethods.FILEGROUPDESCRIPTORA))
                        Dim fileGroupDescriptor As NativeMethods.FILEGROUPDESCRIPTORA = DirectCast(fileGroupDescriptorObject, NativeMethods.FILEGROUPDESCRIPTORA)

                        'create a new array to store file names in of the number of items in the file group descriptor
                        Dim fileNames(fileGroupDescriptor.cItems - 1) As String

                        'get the pointer to the first file descriptor
                        Dim fileDescriptorPointer As IntPtr = New IntPtr(Integer.Parse(fileGroupDescriptorAPointer) + Marshal.SizeOf(fileGroupDescriptorAPointer))

                        'loop for the number of files acording to the file group descriptor
                        For fileDescriptorIndex As Integer = 0 To fileGroupDescriptor.cItems - 1
                            'marshal the pointer top the file descriptor as a FILEDESCRIPTORA struct and get the file name
                            Dim fileDescriptor As NativeMethods.FILEDESCRIPTORA = DirectCast(Marshal.PtrToStructure(fileDescriptorPointer, GetType(NativeMethods.FILEDESCRIPTORA)), NativeMethods.FILEDESCRIPTORA)
                            fileNames(fileDescriptorIndex) = fileDescriptor.cFileName

                            'move the file descriptor pointer to the next file descriptor
                            fileDescriptorPointer = New IntPtr(Integer.Parse(fileDescriptorPointer) + Marshal.SizeOf(fileDescriptor))
                        Next fileDescriptorIndex

                        'return the array of filenames
                        Return fileNames
                    Finally
                        'free unmanaged memory pointer
                        Marshal.FreeHGlobal(fileGroupDescriptorAPointer)
                    End Try

                Case "FileGroupDescriptorW"
                    'override the default handling of FileGroupDescriptorW which returns a
                    'MemoryStream and instead return a string array of file names
                    Dim fileGroupDescriptorWPointer As IntPtr = IntPtr.Zero
                    Try
                        'use the underlying IDataObject to get the FileGroupDescriptorW as a MemoryStream
                        Dim fileGroupDescriptorStream As MemoryStream = DirectCast(Me.underlyingDataObject.GetData("FileGroupDescriptorW"), MemoryStream)
                        Dim fileGroupDescriptorBytes(fileGroupDescriptorStream.Length - 1) As Byte
                        fileGroupDescriptorStream.Read(fileGroupDescriptorBytes, 0, fileGroupDescriptorBytes.Length)
                        fileGroupDescriptorStream.Close()

                        'copy the file group descriptor into unmanaged memory
                        fileGroupDescriptorWPointer = Marshal.AllocHGlobal(fileGroupDescriptorBytes.Length)
                        Marshal.Copy(fileGroupDescriptorBytes, 0, fileGroupDescriptorWPointer, fileGroupDescriptorBytes.Length)

                        'marshal the unmanaged memory to to FILEGROUPDESCRIPTORW struct
                        Dim fileGroupDescriptorObject As Object = Marshal.PtrToStructure(fileGroupDescriptorWPointer, GetType(NativeMethods.FILEGROUPDESCRIPTORW))
                        Dim fileGroupDescriptor As NativeMethods.FILEGROUPDESCRIPTORW = DirectCast(fileGroupDescriptorObject, NativeMethods.FILEGROUPDESCRIPTORW)

                        'create a new array to store file names in of the number of items in the file group descriptor
                        Dim fileNames(fileGroupDescriptor.cItems - 1) As String

                        'get the pointer to the first file descriptor
                        Dim fileDescriptorPointer As IntPtr = New IntPtr(Integer.Parse(fileGroupDescriptorWPointer) + Marshal.SizeOf(fileGroupDescriptorWPointer))

                        'loop for the number of files acording to the file group descriptor
                        For fileDescriptorIndex As Integer = 0 To fileGroupDescriptor.cItems - 1
                            'marshal the pointer top the file descriptor as a FILEDESCRIPTORW struct and get the file name
                            Dim fileDescriptor As NativeMethods.FILEDESCRIPTORW = DirectCast(Marshal.PtrToStructure(fileDescriptorPointer, GetType(NativeMethods.FILEDESCRIPTORW)), NativeMethods.FILEDESCRIPTORW)
                            fileNames(fileDescriptorIndex) = fileDescriptor.cFileName

                            'move the file descriptor pointer to the next file descriptor
                            fileDescriptorPointer = New IntPtr(Integer.Parse(fileDescriptorPointer) + Marshal.SizeOf(fileDescriptor))
                        Next fileDescriptorIndex

                        'return the array of filenamess
                        Return fileNames
                    Finally
                        'free unmanaged memory pointer
                        Marshal.FreeHGlobal(fileGroupDescriptorWPointer)
                    End Try

                Case "FileContents"
                    'override the default handling of FileContents which returns the
                    'contents of the first file as a memory stream and instead return
                    'a array of MemoryStreams containing the data to each file dropped

                    'get the array of filenames which lets us know how many file contents exist
                    Dim fileContentNames() As String = DirectCast(Me.GetData("FileGroupDescriptor"), String())

                    'create a MemoryStream array to store the file contents
                    Dim fileContents(fileContentNames.Length - 1) As MemoryStream

                    'loop for the number of files acording to the file names
                    For fileIndex As Integer = 0 To fileContentNames.Length - 1
                        'get the data at the file index and store in array
                        fileContents(fileIndex) = Me.GetData(format, fileIndex)
                    Next fileIndex

                    'return array of MemoryStreams containing file contents
                    Return fileContents
            End Select

            'use underlying IDataObject to handle getting of data
            Return Me.underlyingDataObject.GetData(format, autoConvert)
        End Function

        ''' <summary>
        ''' Retrieves the data associated with the specified data format at the specified index.
        ''' </summary>
        ''' <param name="format">The format of the data to retrieve. See <see cref="T:System.Windows.Forms.DataFormats"></see> for predefined formats.</param>
        ''' <param name="index">The index of the data to retrieve.</param>
        ''' <returns>
        ''' A <see cref="MemoryStream"/> containing the raw data for the specified data format at the specified index.
        ''' </returns>
        Public Function GetData(ByVal format As String, ByVal index As Integer) As MemoryStream
            'create a FORMATETC struct to request the data with
            Dim formatetc As New FORMATETC()

        Try
            formatetc.cfFormat = CShort(DataFormats.GetFormat(format).Id)
        Catch ex As Exception
            Dim myShort As Integer = DataFormats.GetFormat(format).Id
            myShort = (myShort - 65536)
            formatetc.cfFormat = CShort(myShort)
        End Try

        'formatetc.cfFormat = CShort(DataFormats.GetFormat(format).Id)
            formatetc.dwAspect = DVASPECT.DVASPECT_CONTENT
            formatetc.lindex = index
            formatetc.ptd = New IntPtr(0)
            formatetc.tymed = TYMED.TYMED_ISTREAM Or TYMED.TYMED_ISTORAGE Or TYMED.TYMED_HGLOBAL

            'create STGMEDIUM to output request results into
            Dim medium As New STGMEDIUM()

            'using the Com IDataObject interface get the data using the defined FORMATETC
            Me.comUnderlyingDataObject.GetData(formatetc, medium)

            'retrieve the data depending on the returned store type
            Select Case medium.tymed
                Case TYMED.TYMED_ISTORAGE
                    'to handle a IStorage it needs to be written into a second unmanaged
                    'memory mapped storage and then the data can be read from memory into
                    'a managed byte and returned as a MemoryStream

                    Dim iStorage As NativeMethods.IStorage = Nothing
                    Dim iStorage2 As NativeMethods.IStorage = Nothing
                    Dim iLockBytes As NativeMethods.ILockBytes = Nothing
                    Dim iLockBytesStat As System.Runtime.InteropServices.ComTypes.STATSTG
                    Try
                        'marshal the returned pointer to a IStorage object
                        iStorage = DirectCast(Marshal.GetObjectForIUnknown(medium.unionmember), NativeMethods.IStorage)
                        Marshal.Release(medium.unionmember)

                        'create a ILockBytes (unmanaged byte array) and then create a IStorage using the byte array as a backing store
                        iLockBytes = NativeMethods.CreateILockBytesOnHGlobal(IntPtr.Zero, True)
                        iStorage2 = NativeMethods.StgCreateDocfileOnILockBytes(iLockBytes, &H1012, 0)

                        'copy the returned IStorage into the new IStorage
                        iStorage.CopyTo(0, Nothing, IntPtr.Zero, iStorage2)
                        iLockBytes.Flush()
                        iStorage2.Commit(0)

                        'get the STATSTG of the ILockBytes to determine how many bytes were written to it
                        iLockBytesStat = New System.Runtime.InteropServices.ComTypes.STATSTG()
                        iLockBytes.Stat(iLockBytesStat, 1)
                        Dim iLockBytesSize As Integer = CInt(iLockBytesStat.cbSize)

                        'read the data from the ILockBytes (unmanaged byte array) into a managed byte array
                        Dim iLockBytesContent(iLockBytesSize - 1) As Byte
                        iLockBytes.ReadAt(0, iLockBytesContent, iLockBytesContent.Length, Nothing)

                        'wrapped the managed byte array into a memory stream and return it
                        Return New MemoryStream(iLockBytesContent)
                    Finally
                        'release all unmanaged objects
                        Marshal.ReleaseComObject(iStorage2)
                        Marshal.ReleaseComObject(iLockBytes)
                        Marshal.ReleaseComObject(iStorage)
                    End Try

                Case TYMED.TYMED_ISTREAM
                    'to handle a IStream it needs to be read into a managed byte and
                    'returned as a MemoryStream

                    Dim iStream As IStream = Nothing
                    Dim iStreamStat As System.Runtime.InteropServices.ComTypes.STATSTG
                    Try
                        'marshal the returned pointer to a IStream object
                        iStream = DirectCast(Marshal.GetObjectForIUnknown(medium.unionmember), IStream)
                        Marshal.Release(medium.unionmember)

                        'get the STATSTG of the IStream to determine how many bytes are in it
                        iStreamStat = New System.Runtime.InteropServices.ComTypes.STATSTG()
                        iStream.Stat(iStreamStat, 0)
                        Dim iStreamSize As Integer = CInt(iStreamStat.cbSize)

                        'read the data from the IStream into a managed byte array
                        Dim iStreamContent(iStreamSize - 1) As Byte
                        iStream.Read(iStreamContent, iStreamContent.Length, IntPtr.Zero)

                        'wrapped the managed byte array into a memory stream and return it
                        Return New MemoryStream(iStreamContent)
                    Finally
                        'release all unmanaged objects
                        Marshal.ReleaseComObject(iStream)
                    End Try

                Case TYMED.TYMED_HGLOBAL
                    'to handle a HGlobal the exisitng "GetDataFromHGLOBLAL" method is invoked via
                    'reflection

                    Return DirectCast(Me.getDataFromHGLOBLALMethod.Invoke(Me.oleUnderlyingDataObject, New Object() {DataFormats.GetFormat(CShort(formatetc.cfFormat)).Name, medium.unionmember}), MemoryStream)
            End Select

            Return Nothing
        End Function

        ''' <summary>
        ''' Determines whether data stored in this instance is associated with, or can be converted to, the specified format.
        ''' </summary>
        ''' <param name="format">A <see cref="T:System.Type"></see> representing the format for which to check. See <see cref="T:System.Windows.Forms.DataFormats"></see> for predefined formats.</param>
        ''' <returns>
        ''' true if data stored in this instance is associated with, or can be converted to, the specified format; otherwise, false.
        ''' </returns>
        Public Function GetDataPresent(ByVal format As Type) As Boolean Implements System.Windows.Forms.IDataObject.GetDataPresent
            Return Me.underlyingDataObject.GetDataPresent(format)
        End Function

        ''' <summary>
        ''' Determines whether data stored in this instance is associated with, or can be converted to, the specified format.
        ''' </summary>
        ''' <param name="format">The format for which to check. See <see cref="T:System.Windows.Forms.DataFormats"></see> for predefined formats.</param>
        ''' <returns>
        ''' true if data stored in this instance is associated with, or can be converted to, the specified format; otherwise false.
        ''' </returns>
        Public Function GetDataPresent(ByVal format As String) As Boolean Implements System.Windows.Forms.IDataObject.GetDataPresent
            Return Me.underlyingDataObject.GetDataPresent(format)
        End Function

        ''' <summary>
        ''' Determines whether data stored in this instance is associated with the specified format, using a Boolean value to determine whether to convert the data to the format.
        ''' </summary>
        ''' <param name="format">The format for which to check. See <see cref="T:System.Windows.Forms.DataFormats"></see> for predefined formats.</param>
        ''' <param name="autoConvert">true to determine whether data stored in this instance can be converted to the specified format; false to check whether the data is in the specified format.</param>
        ''' <returns>
        ''' true if the data is in, or can be converted to, the specified format; otherwise, false.
        ''' </returns>
        Public Function GetDataPresent(ByVal format As String, ByVal autoConvert As Boolean) As Boolean Implements System.Windows.Forms.IDataObject.GetDataPresent
            Return Me.underlyingDataObject.GetDataPresent(format, autoConvert)
        End Function

        ''' <summary>
        ''' Returns a list of all formats that data stored in this instance is associated with or can be converted to.
        ''' </summary>
        ''' <returns>
        ''' An array of the names that represents a list of all formats that are supported by the data stored in this object.
        ''' </returns>
        Public Function GetFormats() As String() Implements System.Windows.Forms.IDataObject.GetFormats
            Return Me.underlyingDataObject.GetFormats()
        End Function

        ''' <summary>
        ''' Gets a list of all formats that data stored in this instance is associated with or can be converted to, using a Boolean value to determine whether to retrieve all formats that the data can be converted to or only native data formats.
        ''' </summary>
        ''' <param name="autoConvert">true to retrieve all formats that data stored in this instance is associated with or can be converted to; false to retrieve only native data formats.</param>
        ''' <returns>
        ''' An array of the names that represents a list of all formats that are supported by the data stored in this object.
        ''' </returns>
        Public Function GetFormats(ByVal autoConvert As Boolean) As String() Implements System.Windows.Forms.IDataObject.GetFormats
            Return Me.underlyingDataObject.GetFormats(autoConvert)
        End Function

        ''' <summary>
        ''' Stores the specified data in this instance, using the class of the data for the format.
        ''' </summary>
        ''' <param name="data">The data to store.</param>
        Public Sub SetData(ByVal data As Object) Implements System.Windows.Forms.IDataObject.SetData
            Me.underlyingDataObject.SetData(data)
        End Sub

        ''' <summary>
        ''' Stores the specified data and its associated class type in this instance.
        ''' </summary>
        ''' <param name="format">A <see cref="T:System.Type"></see> representing the format associated with the data. See <see cref="T:System.Windows.Forms.DataFormats"></see> for predefined formats.</param>
        ''' <param name="data">The data to store.</param>
        Public Sub SetData(ByVal format As Type, ByVal data As Object) Implements System.Windows.Forms.IDataObject.SetData
            Me.underlyingDataObject.SetData(format, data)
        End Sub

        ''' <summary>
        ''' Stores the specified data and its associated format in this instance.
        ''' </summary>
        ''' <param name="format">The format associated with the data. See <see cref="T:System.Windows.Forms.DataFormats"></see> for predefined formats.</param>
        ''' <param name="data">The data to store.</param>
        Public Sub SetData(ByVal format As String, ByVal data As Object) Implements System.Windows.Forms.IDataObject.SetData
            Me.underlyingDataObject.SetData(format, data)
        End Sub

        ''' <summary>
        ''' Stores the specified data and its associated format in this instance, using a Boolean value to specify whether the data can be converted to another format.
        ''' </summary>
        ''' <param name="format">The format associated with the data. See <see cref="T:System.Windows.Forms.DataFormats"></see> for predefined formats.</param>
        ''' <param name="autoConvert">true to allow the data to be converted to another format; otherwise, false.</param>
        ''' <param name="data">The data to store.</param>
        Public Sub SetData(ByVal format As String, ByVal autoConvert As Boolean, ByVal data As Object) Implements System.Windows.Forms.IDataObject.SetData
            Me.underlyingDataObject.SetData(format, autoConvert, data)
        End Sub

#End Region
    End Class