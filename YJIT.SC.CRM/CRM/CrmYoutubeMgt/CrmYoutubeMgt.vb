Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Imports System.IO

Public Class CrmYoutubeMgt

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    YJSql.SqlBox("WG1", "CrmYoutubeMgt@Search", , False)
                    YJSql.Params("DATE_TYPE_" & S_DATE_TYPE.SelectedValue, True)
                    YJSql.Params("DATE_FM", drMAIN("S_DATE_FM").ToString)
                    YJSql.Params("DATE_TO", drMAIN("S_DATE_TO").ToString)
                    YJSql.Params("BOARD_TYPE", drMAIN("S_BOARD_TYPE").ToString)
                    YJSql.Params("SEARCH_TYPE_" & S_SEARCH_TYPE.SelectedValue, True)
                    YJSql.Params("SEARCH_KEY", drMAIN("S_SEARCH_KEY").ToString)
                Case "SearchDetail".ToUpper
                    YJSql.SqlBox("MAIN", "CrmYoutubeMgt@Search")
                    YJSql.Params("BOARD_ID", GV1.GetFocusedRowCellValue("BOARD_ID").ToString)
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
        'Select Case key
        '    Case "WG2_Download"
        '        If GV2.FocusedRowHandle >= 0 < GV2.RowCount AndAlso GV2.GetFocusedRowCellValue("SUCCESS").ToString() <> "N" Then
        '            If GV2.GetFocusedRowCellValue("FILE_NM").ToString.Trim <> "" Then
        '                SaveFileDialog1.FileName = GV2.GetFocusedRowCellValue("FILE_NM").ToString
        '                SaveFileDialog1.Filter = "All files (*.*)|*.*"
        '                SaveFileDialog1.ValidateNames = True
        '                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK And SaveFileDialog1.FileName <> "" Then
        '                    Dim retD As New Dictionary(Of String, String)
        '                    retD = comdoc.DownLoadFile(GV2.GetFocusedRowCellValue("MNGT_NO").ToString & "_" & GV2.GetFocusedRowCellValue("SEQ").ToString, _
        '                                 GV2.GetFocusedRowCellValue("FILE_NM").ToString, _
        '                                 GV2.GetFocusedRowCellValue("FILE_PATH").ToString, _
        '                                 SaveFileDialog1.FileName)
        '                    If retD("TrxCode").ToString <> "Y" Then
        '                        MsgBoxLocalized(retD("TrxMsg").ToString, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
        '                    End If
        '                End If
        '            End If
        '        Else
        '            MsgBoxLocalized("File is not selected or file size is exceeded.", MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Warning)
        '        End If
        '        'Case "SeaHouseMgt"
        '        '    fTarget = frmMain.NavigateTo("SeaHouseMgt")

        '        '    If fTarget IsNot Nothing Then
        '        '        fTarget.HBL_NO.Text = hblNo
        '        '        fTarget.SearchData()
        '        '    End If
        'End Select
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
        S_DATE_FM.Text = DateAdd(DateInterval.Year, -1, Now).ToString("yyyyMMdd")
        S_DATE_TO.Text = Now.ToString("yyyyMMdd")
    End Sub

    Private Sub ClearData()
        ClearView(UI.AppliedRangeTypes.Except, {SCREEN, DirList})
        Call PageInit()
    End Sub

    Private Sub NewData()
        ClearView(UI.AppliedRangeTypes.Only, {BOARD_ID, BOARD_TYPE, BOARD_TITLE, BOARD_BODY, YOUTUBE_URL, YOUTUBE_CODE})
        BOARD_TYPE.Focus()
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
        dataParams.Add("GroupCode", "R01")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("BOARD_TYPE").ColumnEdit = editorCombo
    End Sub

    Private Sub MoveSaveRow(ByVal SaveValue As String)
        Dim i As Integer
        Dim GrpRowCnt As Integer = 0
        For i = 0 To GV1.RowCount - 1
            GV1.MoveNext()
            If GV1.GetRowCellValue(GV1.FocusedRowHandle, "BOARD_ID").ToString = SaveValue Then
                GV1.TopRowIndex = GV1.FocusedRowHandle
                Exit Sub
            End If
        Next
        GV1.TopRowIndex = 0
    End Sub
#End Region

#Region "=================Data logic actions================="
    Public Sub SearchData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmYoutubeMgt", "Search", {dsRet})
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

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmYoutubeMgt", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {BOARD_ID, BOARD_TYPE, BOARD_TITLE, BOARD_BODY, YOUTUBE_URL, YOUTUBE_CODE})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {BOARD_ID, BOARD_TYPE, BOARD_TITLE, BOARD_BODY, YOUTUBE_URL, YOUTUBE_CODE})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SaveData()
        Try
            If SaveValidate() = False Then Exit Sub

            If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")
            dsRet.Tables.Add(Me.ConvertToDataset.Tables("MAIN").Copy)

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmYoutubeMgt", "Save", {dsRet})

            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") = "Y" Then
                Dim boardID As String = BOARD_ID.Text
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.BindToDataset(dsRet, "Data")
                Call MoveSaveRow(boardID)
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
            If String.IsNullOrEmpty(BOARD_TYPE.SelectedValue) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = BOARD_TYPE
                ErrMsg &= "Please input the [" & lbl_BOARD_TYPE.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(BOARD_TITLE.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = BOARD_TITLE
                ErrMsg &= "Please input the [" & lbl_BOARD_TITLE.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(YOUTUBE_URL.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = YOUTUBE_URL
                ErrMsg &= "Please input the [" & lbl_YOUTUBE_URL.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(YOUTUBE_CODE.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = YOUTUBE_CODE
                ErrMsg &= "Please input the [" & lbl_YOUTUBE_CODE.Text & "]" & vbNewLine
            End If


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

        Dim dsRet As DataSet = GetConvertToDataSet("Search")
        dsRet.Tables.Add(Me.ConvertToDataset.Tables("MAIN").Copy)

        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmYoutubeMgt", "Delete", dsRet)

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
            If String.IsNullOrEmpty(BOARD_ID.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = BOARD_ID
                ErrMsg &= "Please input the [" & lbl_BOARD_ID.Text & "]" & vbNewLine
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
    Private Sub CrmYoutubeMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GridInit()
        Call PageInit()
    End Sub

    Private Sub CrmYoutubeMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopUpInit()
        Call DrawRowIndicator({GV1})
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

    Private Sub YOUTUBE_URL_EditValueChanged(oldValue As System.Object, newValue As System.Object) Handles YOUTUBE_URL.EditValueChanged
        'https://www.youtube.com/watch?v=z_8SWnr4l2I
        If YOUTUBE_URL.Text.IndexOf("v=") >= 0 Then
            YOUTUBE_CODE.Text = YOUTUBE_URL.Text.Substring(YOUTUBE_URL.Text.IndexOf("v=") + 2)
        End If
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
#End Region



End Class