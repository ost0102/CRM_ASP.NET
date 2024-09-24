Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Imports System.IO

Public Class CrmManualMgt
    Dim comdoc As ComDoc = New ComDoc()

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    YJSql.SqlBox("WG1", "CrmManualMgt@Search")
                    YJSql.Params("DATE_FM", drMAIN("S_DATE_FM").ToString)
                    YJSql.Params("DATE_TO", drMAIN("S_DATE_TO").ToString)
                Case "SearchDetail".ToUpper
                    YJSql.SqlBox("MAIN", "CrmManualMgt@Search")
                    YJSql.Params("MNGT_NO", GV1.GetFocusedRowCellValue("MNGT_NO").ToString)

                    YJSql.SqlBox("WG2", "ComDocumentMgt@Search")
                    YJSql.Params("MNGT_NO", GV1.GetFocusedRowCellValue("MNGT_NO").ToString)
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region

#Region "=================Client Function==========="
    Public Sub PopUpInit()
        Dim itemCaption = {"&Add Row", "&Delete Row", "&Export Excel"}

        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", itemCaption(2))
        PopUp.PopUpInit(Me, WG1)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG2_AddRow", "&Add Row")
        PopUp.ItemAdd(Action.DeleteRow, "WG2_DeleteRow", "&Delete Row")
        PopUp.ItemAdd(Action.Other, "WG2_Download", "Download", True)
        PopUp.PopUpInit(Me, WG2, "DOC_TYPE", "DOC_NO")

    End Sub

    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = Nothing
        'Dim svcType As String = GV1.GetFocusedRowCellValue("REQ_SVC").ToString.Substring(0, 1)
        'Dim svcType As String = ""
        'Dim hblNo As String = GV1.GetFocusedRowCellValue("HBL_NO").ToString
        'Dim mblNo As String = GV1.GetFocusedRowCellValue("MBL_NO").ToString
        'If GV1.GetFocusedRowCellValue("REQ_SVC").ToString = "" Then
        '    svcType = ""
        'Else
        '    svcType = GV1.GetFocusedRowCellValue("REQ_SVC").ToString.Substring(0, 1)
        'End If
        Select Case key
            Case "WG2_Download"
                If GV2.FocusedRowHandle >= 0 < GV2.RowCount AndAlso GV2.GetFocusedRowCellValue("SUCCESS").ToString() <> "N" Then
                    If GV2.GetFocusedRowCellValue("FILE_NM").ToString.Trim <> "" Then
                        SaveFileDialog1.FileName = GV2.GetFocusedRowCellValue("FILE_NM").ToString
                        SaveFileDialog1.Filter = "All files (*.*)|*.*"
                        SaveFileDialog1.ValidateNames = True
                        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK And SaveFileDialog1.FileName <> "" Then
                            Dim retD As New Dictionary(Of String, String)
                            retD = comdoc.DownLoadFile(GV2.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV2.GetFocusedRowCellValue("SEQ").ToString, _
                                         GV2.GetFocusedRowCellValue("FILE_NM").ToString, _
                                         GV2.GetFocusedRowCellValue("FILE_PATH").ToString, _
                                         SaveFileDialog1.FileName)
                            If retD("TrxCode").ToString <> "Y" Then
                                MsgBoxLocalized(retD("TrxMsg").ToString, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
                            End If
                        End If
                    End If
                Else
                    MsgBoxLocalized("File is not selected or file size is exceeded.", MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Warning)
                End If
                'Case "SeaHouseMgt"
                '    fTarget = frmMain.NavigateTo("SeaHouseMgt")

                '    If fTarget IsNot Nothing Then
                '        fTarget.HBL_NO.Text = hblNo
                '        fTarget.SearchData()
                '    End If
        End Select
    End Sub

    Public Sub MenuListBeforeShow(ByRef param As Dictionary(Of String, Boolean))
        'If GV1.GetFocusedRowCellValue("REQ_SVC").ToString <> "" Then
        '    param("SeaHouseMgt") = True
        '    param("SeaMasterMgt") = True
        'Else
        '    param("SeaHouseMgt") = False
        '    param("SeaMasterMgt") = False
        'End If
    End Sub


    Private Sub PageInit()
        S_DATE_TYPE.SelectedValue = "REG"
        S_DATE_FM.Text = DateAdd(DateInterval.Day, -7, Now).ToString("yyyyMMdd")
        S_DATE_TO.Text = Now.ToString("yyyyMMdd")
    End Sub

    Private Sub GridInit()
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "M01")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("MANUAL_TYPE").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "S01")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("SYS_ID").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T02")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("REQ_SVC").ColumnEdit = editorCombo



        Dim editorImgCombo As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox = comdoc.getImageComboBox()
        editorImgCombo.SmallImages = comdoc.getIcons()
        GV2.Columns("FILE_ICON").ColumnEdit = editorImgCombo
        GV2.Columns("SUCCESS").ColumnEdit = editorImgCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "M33")
        dataParams.Add("NameType", "")
        editorCombo.ShowHeader = False
        editorCombo.ReadOnly = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV2.Columns("DOC_TYPE").ColumnEdit = editorCombo
    End Sub

    Private Sub InitIcons()
        For i = 0 To GV2.RowCount - 1
            If Not comdoc.IsContainExtension(GV2.GetRowCellValue(i, "FILE_ICON").ToString) And GV2.GetRowCellValue(i, "FILE_NM").ToString <> "" Then
                GV2.SetRowCellValue(i, "FILE_ICON", "dft")
            End If
            GV2.SetRowCellValue(i, "UPLOAD", "UPLOAD")
        Next
        Me.DataState = DataStates.Retrieved
    End Sub

    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV2"
                checkNull = {"FILE_NM"}
                'Param("FILE_NM") = GV2_FILE_NM.Caption

                Return ValidateGridValue(GV2, Param, checkNull)
        End Select

        Return True

    End Function

    Private Sub ClearData()
        ClearView(UI.AppliedRangeTypes.Except, {SCREEN, DirList})
        Call PageInit()
    End Sub

    Private Sub NewData()
        ClearView(UI.AppliedRangeTypes.Only, {MNGT_NO, MANUAL_TYPE, SYS_ID, REQ_SVC, CONTENT, RMK, WG2})
        MANUAL_TYPE.Focus()
    End Sub
#End Region

#Region "=================Data logic actions================="
    Public Sub SearchData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmManualMgt", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(S_DATE_FM.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = S_DATE_TYPE
                ErrMsg &= "Please input the [" & S_DATE_TYPE.SelectedValue & "]" & vbNewLine
            ElseIf String.IsNullOrEmpty(S_DATE_TO.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = S_DATE_TYPE
                ErrMsg &= "Please input the [" & S_DATE_TYPE.SelectedValue & "]" & vbNewLine
            End If


            'If String.IsNullOrEmpty(S_CUST_CD.Text.ToString) Then
            '    'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = S_CUST_CD
            '    ErrMsg &= "Please input the [" & lbl_S_CUST_CD.Text & "]" & vbNewLine
            'End If


            If Not String.IsNullOrEmpty(ErrMsg) Then
                'If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    Public Sub SearchDetailData()
        Try
            Dim dsRet As DataSet = GetConvertToDataSet("SearchDetail")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmManualMgt", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {MNGT_NO, MANUAL_TYPE, SYS_ID, REQ_SVC, CONTENT, RMK, WG2})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {MNGT_NO, MANUAL_TYPE, SYS_ID, REQ_SVC, CONTENT, RMK, WG2})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select

            Call InitIcons()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SaveData()
        Try
            If SaveValidate() = False Then Exit Sub
            If MandatoryGridValue("GV2") Then Exit Sub

            If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

            '## 파일첨부 처리 시작
            Dim byteUploadFiles As Dictionary(Of String, Object) = comdoc.byteUploadFiles
            Dim tempFolder As String = comdoc.getTempFolder
            Dim strFileName As String = ""
            For i As Integer = 0 To GV2.RowCount - 1
                GV2.SetRowCellValue(i, "SEQ", comdoc.GetSeq(i, MNGT_NO.Text))
            Next
            comdoc.SetUploadPath(Split(DirList.Text, "/"))
            '## 파일첨부 처리 끝


            Dim dsRet As DataSet = GetConvertToDataSet("Search")
            dsRet.Tables.Add(Me.ConvertToDataset.Tables("MAIN").Copy)
            dsRet.Tables.Add(Me.ConvertToDataset.Tables("WG2").Copy)

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmManualMgt", "Save", {dsRet, comdoc.getUploadPath})

            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") = "Y" Then
                '## 파일첨부 처리 시작
                'For Each drDoc As DataRow In dsRet.Tables("Data.WG2").Rows
                '    MNGT_NO.Text = drDoc("MNGT_NO").ToString
                '    Dim strSeq As String = drDoc("SEQ").ToString
                '    strFileName = tempFolder & "\" & comdoc.removeSpecialChars(MNGT_NO.Text) & "_" & strSeq & "_" & drDoc("FILE_NM").ToString
                '    Try
                '        Dim rowNumber As Integer = Integer.Parse(drDoc("SEQ"))
                '        'if directory doesn't exist
                '        If Not Directory.Exists(tempFolder) Then
                '            Directory.CreateDirectory(tempFolder)
                '        End If
                '        'if the file is changed, following actions can be done
                '        If byteUploadFiles(rowNumber) IsNot Nothing AndAlso drDoc("SUCCESS").ToString() = "Y" Then
                '            File.WriteAllBytes(strFileName, byteUploadFiles(rowNumber))
                '            If Not FileUpload(strFileName, drDoc("FILE_PATH").ToString()) Then
                '                Throw New Exception("Couldn't upload file!")
                '            End If
                '            If System.IO.File.Exists(strFileName) Then
                '                System.IO.File.Delete(strFileName)
                '            End If
                '        End If
                '    Catch ex As Exception
                '        dr("TrxMsg") = ex.ToString
                '        Call YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ComDocumentMgt", "Delete", {MNGT_NO.Text, strSeq})
                '    End Try
                'Next

                For Each drRow In dsRet.Tables("Data.WG2").Rows
                    MNGT_NO.Text = drRow("MNGT_NO").ToString

                    Dim strSeq As String = drRow("SEQ").ToString
                    strFileName = tempFolder & "\" & comdoc.removeSpecialChars(MNGT_NO.Text) & "_" & strSeq & "_" & drRow("FILE_NM").ToString

                    Try
                        Dim rowNumber As Integer = Integer.Parse(drRow("SEQ"))

                        'if directory doesn't exist
                        If Not Directory.Exists(tempFolder) Then
                            Directory.CreateDirectory(tempFolder)
                        End If

                        'if the file is changed, following actions can be done
                        If comdoc.byteUploadFiles.ContainsKey(drRow("FILE_NM").ToString) AndAlso drRow("SUCCESS").ToString() = "Y" Then
                            File.WriteAllBytes(strFileName, byteUploadFiles(drRow("FILE_NM").ToString))

                            If Not FileUpload(strFileName, drRow("FILE_PATH").ToString()) Then Throw New Exception("Couldn't upload file!")

                            If System.IO.File.Exists(strFileName) Then System.IO.File.Delete(strFileName)
                        End If
                    Catch ex As Exception
                        dr("TrxMsg") = ex.ToString
                        Dim dsDocDel As DataSet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ComDocumentMgt", "Delete", {MNGT_NO.Text, strSeq})
                    End Try
                Next
                '## 파일첨부 처리 끝

                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.BindToDataset(dsRet, "Data")
                Me.DataState = UI.DataStates.Retrieved
            End If

            MsgBoxLocalized(dr("TrxMsg"))
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Function SaveValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(MANUAL_TYPE.SelectedValue) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = MANUAL_TYPE
                ErrMsg &= "Please input the [" & lbl_MANUAL_TYPE.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(SYS_ID.SelectedValue) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = SYS_ID
                ErrMsg &= "Please input the [" & lbl_SYS_ID.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(REQ_SVC.SelectedValue) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = REQ_SVC
                ErrMsg &= "Please input the [" & lbl_REQ_SVC.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(CONTENT.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = CONTENT
                ErrMsg &= "Please input the [" & lbl_CONTENT.Text & "]" & vbNewLine
            End If

            'If String.IsNullOrEmpty(S_CUST_CD.Text.ToString) Then
            '    'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = S_CUST_CD
            '    ErrMsg &= "Please input the [" & lbl_S_CUST_CD.Text & "]" & vbNewLine
            'End If


            If String.IsNullOrEmpty(SCREEN.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                'If ErrControl Is Nothing Then ErrControl = CONTENT
                ErrMsg &= "Please input the [Screen Name]" & vbNewLine
            End If

            If String.IsNullOrEmpty(DirList.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                'If ErrControl Is Nothing Then ErrControl = CONTENT
                ErrMsg &= "Please input the [Directory]" & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                'If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function


    Public Sub DeleteData()

        If DeleteValidate() = False Then Exit Sub

        If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        For i = GV2.RowCount - 1 To 0 Step -1
            'GV2.GetDataRow(i).AcceptChanges()
            'GV2.GetDataRow(i).SetModified()
            GV2.DeleteRow(i)
        Next

        Dim dsRet As DataSet = GetConvertToDataSet("Search")
        dsRet.Tables.Add(Me.ConvertToDataset.Tables("MAIN").Copy)
        dsRet.Tables("MAIN").Columns.Add("UploadPath")
        dsRet.Tables("MAIN").Rows(0)("UploadPath") = comdoc.getUploadPath()
        dsRet.Tables.Add(Me.ConvertToDataset.Tables("WG2").Copy)

        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmManualMgt", "Delete", dsRet)

        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Call ClearView(AppliedRangeTypes.Only, {WG1})
            Me.BindToDataset(dsRet, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))

    End Sub
    Private Function DeleteValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(MNGT_NO.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = MNGT_NO
                ErrMsg &= "Please input the [" & lbl_MNGT_NO.Text & "]" & vbNewLine
            End If


            If Not String.IsNullOrEmpty(ErrMsg) Then
                'If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "=================Control Events================="
    Private Sub CrmManualMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrmManualMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PageInit()
        Call GridInit()
        Call PopUpInit()
        Call DrawRowIndicator({GV1})

        comdoc = New ComDoc(WG2)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call DeleteData()
    End Sub

    Private Sub GV1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GV1.Click
        Try
            If sender.RowCount = 0 Then Exit Sub
            If bGV1_FocusedRowChanged = True Then Exit Sub

            Call SearchDetailData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            bGV1_FocusedRowChanged = False
        End Try
    End Sub

    Dim bGV1_FocusedRowChanged As Boolean = False
    Private Sub GV1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Try
            If sender.RowCount = 0 Then Exit Sub
            If sender.IsValidRowHandle(e.FocusedRowHandle) = False Then Exit Sub

            If e.PrevFocusedRowHandle >= 0 Then bGV1_FocusedRowChanged = True

            Call SearchDetailData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub


    'Private Sub GV1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.DoubleClick
    '    Dim strMessage As String = ""

    '    If GV1.FocusedRowHandle < 0 Then
    '        Exit Sub
    '    End If

    '    Try
    '        If (GV1.FocusedColumn.FieldName = "FILE_NM" Or GV1.FocusedColumn.FieldName = "FILE_ICON") And GV1.RowCount > 0 Then
    '            Dim retD As New Dictionary(Of String, String)
    '            If GV1.GetFocusedRowCellValue("FILE_NM").ToString.Trim <> "" Then
    '                retD = comdoc.DownLoadFile(GV1.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV1.GetFocusedRowCellValue("SEQ").ToString, _
    '                                    GV1.GetFocusedRowCellValue("FILE_NM").ToString, _
    '                                    GV1.GetFocusedRowCellValue("FILE_PATH").ToString, "")
    '                If retD("TrxCode").ToString = "Y" Then
    '                    'Microsoft.VisualBasic.Shell("explorer " & retD("FullName").ToString, AppWinStyle.NormalFocus)
    '                    Dim p As New System.Diagnostics.Process
    '                    Dim s As New System.Diagnostics.ProcessStartInfo(retD("FullName").ToString)
    '                    s.UseShellExecute = True
    '                    s.WindowStyle = ProcessWindowStyle.Normal
    '                    p.StartInfo = s
    '                    p.Start()
    '                Else
    '                    MsgBoxLocalized(retD("TrxMsg"), MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        'MsgBoxLocalized(strMessage & " " & ex.Message, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
    '    End Try
    'End Sub

#End Region






End Class