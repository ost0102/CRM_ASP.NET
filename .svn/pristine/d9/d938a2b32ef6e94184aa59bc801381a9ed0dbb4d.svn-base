Imports YJIT.SC.UI
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands

Public Class SysBoardMgt

#Region "=================Data logic actions==========="
    Private byteUploadFiles(100)() As Byte
    Private tempRoot As String = Application.StartupPath & "\TMP_OUTPUT"
    Private DefaultFontFamily As String = "¸¼Àº °íµñ"
    Private DefaultFontSize As Integer = 11
    Protected filePath As String = String.Empty


    Private Function CreateKeyNo() As Boolean

        'key create 
        Dim ds As DataSet = New DataSet
        Dim drPairs As DataRow
        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysBoardMgt", "CreateKeyNo", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
        drPairs = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        BOARD_ID.Text = drPairs("BOARD_ID").ToString

        Return True

    End Function

    Private Function SaveFile() As Boolean

        Try
            '1. clear all temp file, to make sure same generated image index
            Dim sTempPath As String = tempRoot & "\Notice_" & BOARD_ID.Text & "_files"
            If IO.Directory.Exists(sTempPath) Then IO.Directory.Delete(sTempPath, True)

            '2. Save document to HTML format, images will be saved into node_id_images
            filePath = tempRoot & "\Notice_" & BOARD_ID.Text & ".html"
            BOARD_BODY.SaveDocument(filePath, DocumentFormat.Html)

        Catch ex As Exception
            MsgBoxSC("Error while saving file!" & ex.Message)
            Return False
        End Try

        Return True
    End Function

    Private Sub SaveData()
        Dim InsFlag As String = ""

        'key create 
        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        'key create 
        If BOARD_ID.Text = "" Then
            If CreateKeyNo() = False Then Exit Sub
            InsFlag = "I"
        Else
            InsFlag = "U"
        End If

        '1. First, save to local==================================
        If SaveFile() = False Then Exit Sub

        '2. Load again to datatable==================================
        Dim ds As DataSet = New DataSet
        ds = Me.ConvertToDataset
        ds.Tables("MAIN").Columns.Add("CONTENT")
        ds.Tables("MAIN").Rows(0)("CONTENT") = IO.File.ReadAllText(filePath)
        ds.Tables("MAIN").Columns.Add("INS_FLAG")
        ds.Tables("MAIN").Rows(0)("INS_FLAG") = InsFlag

        Dim params() As Object = {ds}
        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysBoardMgt", "Save", params)
        Catch ex As Exception
            MsgBoxSC(ex.Message)
            Exit Sub
        End Try
        Dim dr As DataRow
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If

        '3. Preparlist of upload file==================================
        Dim arlUploadClient As New ArrayList
        'Image files are stored in NODE_ID_files
        Dim sUpdPath As String = tempRoot & "\Notice_" & BOARD_ID.Text & "_files\"
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

            Dim dlg As New SysBoardUpload
            dlg.ArlClientFiles = arlUploadClient
            dlg.BoardId = BOARD_ID.Text

            dlg.ShowDialog()
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
        End If



    End Sub

    Public Sub NewData()

        ClearView(UI.AppliedRangeTypes.Only, {BOARD_ID, WG1, TITLE, NOTICE_YN})
        Call clearRTF()
        Call SetDefault()

    End Sub
    Public Sub SearchData()

        Try

            filePath = tempRoot & "\Notice_" & BOARD_ID.Text & ".html"

            Me.Cursor = Cursors.WaitCursor

            '1. Load HTML content from DB
            Dim params() As String = {BOARD_ID.Text}
            Dim dsResult As DataSet
            Dim drPairs As DataRow
            Try
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysBoardMgt", "Search", params)
            Catch ex As Exception
                MsgBoxSC(ex.Message)
                Exit Sub
            End Try
            drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
            If drPairs("TrxCode") <> "Y" Then
                MsgBox(drPairs("TrxMsg"))
                Exit Sub
            End If
            Me.BindToDataset(dsResult, "Data")
            BOARD_TYPE.DefVal = dsResult.Tables("Data.Main")(0)("BOARD_TYPE").ToString

            Dim dt As DataTable = dsResult.Tables("Data.Main")
            'Write to file for editing
            IO.File.WriteAllText(filePath, dt.Rows(0)("BOARD_BODY") & "")


            '2. check if the local _files not exists, download from server
            Dim sLocalPath As String = tempRoot & "\Notice_" & BOARD_ID.Text & "_files\"
            If Not IO.Directory.Exists(sLocalPath) Then
                'Create local path
                IO.Directory.CreateDirectory(sLocalPath)
            End If

            'Download all files from corresponding path on server
            Dim sSmartHelpHome As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "Notice/"

            Dim wc As New System.Net.WebClient
            Dim sResult As String = wc.DownloadString(sSmartHelpHome & "FolderManifest.aspx?FolderURI=" & "Data/Notice_" & BOARD_ID.Text & "_files/")

            If sResult.StartsWith("OK") Then
                Dim files() As String = sResult.Split(vbCrLf)
                For i As Integer = 1 To files.Count - 1  'first line is "OK"
                    If files(i).Trim = "" Then Continue For
                    Try
                        wc.DownloadFile(sSmartHelpHome & "Data/Notice_" & BOARD_ID.Text & "_files/" & files(i).Trim, sLocalPath & files(i).Trim)
                    Catch ex As Exception
                        MsgBoxSC("Download failed!" & sSmartHelpHome & "Data/Notice_" & BOARD_ID.Text & "_files/" & files(i).Trim)
                    End Try
                Next
            End If

            '3. Load content to editor
            BOARD_BODY.LoadDocument(filePath, DocumentFormat.Html)
            BOARD_BODY.ReadOnly = False

            Me.Cursor = Cursors.Arrow


        Catch ex As Exception
        End Try

    End Sub

    Public Sub DeleteData()

        If Me.ValidateRequiredData({BOARD_ID}) = False Then Exit Sub

        If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        Dim dsRet As DataSet
        Dim dr As DataRow
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysBoardMgt", "Delete", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        ClearView(UI.AppliedRangeTypes.Only, {BOARD_ID, WG1, TITLE})
        Call clearRTF()

        'Must be called after clearing RTF document
        Call SetDefault()

        dr = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
        End If
    End Sub

    'Toolbar functions
    Public Sub clearRTF()
        BOARD_BODY.CreateNewDocument()
    End Sub
    Private Function fileExist(ByVal fullName As String) As Boolean
        Dim isExist As Boolean = False
        For i As Integer = 0 To GV1.RowCount - 1
            If (GV1.GetRowCellValue(i, "FILE_PATH").ToString = fullName) Then
                isExist = True
            End If
        Next
        Return isExist
    End Function
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString
        Select Case key
            Case "WG1_Attach"
                Dim ofd As New OpenFileDialog()
                If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim FileNames() As String = ofd.FileNames
                    For Each FullPath As String In FileNames
                        If Not fileExist(FullPath) Then
                            Dim fileName As String = FullPath.Substring(FullPath.LastIndexOf("\") + 1, FullPath.Length - 1 - FullPath.LastIndexOf("\"))

                            Dim br As IO.BinaryReader = New IO.BinaryReader(File.OpenRead(FullPath))
                            byteUploadFiles(WG1.AddRow()) = br.ReadBytes(br.BaseStream.Length)

                            GV1.SetFocusedRowCellValue("FILE_PATH", FullPath)
                            GV1.SetFocusedRowCellValue("FILE_NM", fileName)
                        End If
                    Next
                End If
            Case "WG1_Detach"
                WG1.DeleteRow()
            Case "WG1_Download"
                If GV1.FocusedRowHandle >= 0 < GV1.RowCount Then
                    If GV1.GetFocusedRowCellValue("FILE_NM").ToString.Trim <> "" Then
                        Dim SFD As New SaveFileDialog
                        SFD.FileName = GV1.GetFocusedRowCellValue("FILE_NM").ToString
                        SFD.Filter = "All files (*.*)|*.*"
                        SFD.ValidateNames = True
                        If SFD.ShowDialog = Windows.Forms.DialogResult.OK And SFD.FileName <> "" Then
                            Dim retD As New Dictionary(Of String, String)
                            retD = DownLoadFile(GV1.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV1.GetFocusedRowCellValue("SEQ").ToString, _
                                         GV1.GetFocusedRowCellValue("FILE_NM").ToString, _
                                         GV1.GetFocusedRowCellValue("FILE_PATH").ToString, _
                                         SFD.FileName)
                            If retD("TrxCode").ToString <> "Y" Then
                                MsgBoxLocalized(retD("TrxMsg").ToString, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                            End If
                        End If
                    End If
                Else
                    MsgBoxLocalized("Please select the file to download.", MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Warning)
                End If
        End Select

    End Sub
    Public Function DownLoadFile(ByVal strPrefix As String, ByVal sourcefile As String, ByVal sourcepath As String, ByVal targetfile As String) As Dictionary(Of String, String)
        Dim retD As New Dictionary(Of String, String)
        Try
            'Me.Cursor = Cursors.WaitCursor

            'Folder validation
            If Not IO.Directory.Exists(tempRoot) Then
                IO.Directory.CreateDirectory(tempRoot)
            End If

            'Default file path and name
            If targetfile = "" Then
                targetfile = IO.Path.Combine(tempRoot & "\", sourcefile)
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
            If File.Exists(sourcepath) Then
                'Fie which is on the local computer
                File.Copy(sourcepath, targetfile)
            Else
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
            End If

        Catch ex As Exception
            retD.Add("TrxCode", "E")
            retD.Add("TrxMsg", "During download process, error occured! " & ex.Message)
        Finally
            'Me.Cursor = Cursors.Default
        End Try
        Return retD
    End Function
    Public Function GetCurrentRange() As DocumentRange
        Dim range As DocumentRange = BOARD_BODY.Document.Selection
        If BOARD_BODY.Document.Selection.Start = BOARD_BODY.Document.Selection.End Then
            range = BOARD_BODY.Document.CreateRange(BOARD_BODY.Document.Selection.Start, 1)
        End If
        Return range
    End Function
    Protected Overrides Sub OnKeyPress(e As System.Windows.Forms.KeyPressEventArgs)
        If Me.ActiveControl Is BOARD_BODY Then
            Exit Sub
        Else
            MyBase.OnKeyPress(e)
        End If
    End Sub
    Public Sub SetDefault()
        Try

            AddBulletedListToDocument()

            For Each sect In BOARD_BODY.Document.Sections
                sect.Margins.Left = 50
                sect.Margins.Right = 50
                sect.Margins.Top = 50
                sect.Margins.Bottom = 50
            Next


            Dim cp As CharacterProperties = BOARD_BODY.Document.BeginUpdateCharacters(BOARD_BODY.Document.Range)
            cp.FontName = DefaultFontFamily
            cp.AllCaps = False
            cp.FontSize = DefaultFontSize
            BOARD_BODY.Document.EndUpdateCharacters(cp)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub AddBulletedListToDocument()
        Dim doc As Document = BOARD_BODY.Document
        ' Define an abstract numbered list and add it to the document.
        DefineAbstractList(doc)
        ' Create a numbering list. It is based on a previously defined abstract list with ID = 0.
        doc.NumberingLists.Add(0)
    End Sub
    Private Sub DefineAbstractList(ByVal doc As Document)
        doc.BeginUpdate()
        'Describe the pattern used for the numbered list.
        'Specify parameters used to represent each list level.

        Dim list As AbstractNumberingList = BOARD_BODY.Document.AbstractNumberingLists.Add()
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
#End Region
#Region "=================Control Events==========="

    Private Sub SysBoardMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If Not IO.Directory.Exists(tempRoot) Then IO.Directory.CreateDirectory(tempRoot)

        SetDefault()

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        SaveData()
    End Sub
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Call DeleteData()
    End Sub
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub

#End Region

End Class
