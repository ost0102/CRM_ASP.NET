Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports YJIT.SC.UI
Public Class SvrModuleMgt
    Dim ProcSave As Boolean = False
    Dim WG1_PopUp As New PopupBase
    Dim WG2_PopUp As New PopupBase
    Dim WG3_PopUp As New PopupBase

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal Type As String) As DataSet
        Dim YJSql As New YJQuery
        'Dim IsSingleSearch As Boolean = False

        Select Case Type.ToUpper
            Case "Search".ToUpper
                YJSql.SqlBox("WG1", "SvrModuleMgt@Search")
                YJSql.Params("DATE_FROM", S_DATE_FROM.Text)
                YJSql.Params("DATE_TO", S_DATE_TO.Text)
                YJSql.Blocks("SEARCH_KEY_TYPE_" & S_SEARCH_KEY_TYPE.SelectedValue, S_SEARCH_KEY.Text)
                YJSql.Params("SEARCH_KEY", S_SEARCH_KEY.Text)
                YJSql.Params("USE_YN", S_USE_YN.SelectedValue)
            Case "SearchModule".ToUpper
                YJSql.SqlBox("WG2", "SvrModuleMgt@SearchModule")
                YJSql.Params("MNGT_NO", GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO").ToString, False)
            Case "SearchModuleAutoCheck".ToUpper
                YJSql.SqlBox("WG3", "SvrModuleMgt@SearchModuleAutoCheck")
        End Select
        Return YJSql.DataSet
    End Function
#End Region

#Region "=================Client Function==========="
    Private Sub InitPage()
        'S_DATE_FROM.Text = Now.ToString("yyyyMMdd")
        'S_DATE_TO.Text = Now.ToString("yyyyMMdd")
    End Sub
    Private Sub InitGrid()
        Call DrawRowIndicator({GV1, GV2, GV3})

        GV1.Columns("SERVER_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:SVR02, NameType:")
        GV1.Columns("LOC_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:SVR03, NameType:")
        GV1.Columns("CTRT_YMD").ColumnEdit = GridFunc.GetRepositoryItemDateBoxEdit
        GV1.Columns("MATN_START_YMD").ColumnEdit = GridFunc.GetRepositoryItemDateBoxEdit
        GV1.Columns("MATN_END_YMD").ColumnEdit = GridFunc.GetRepositoryItemDateBoxEdit
        GV1.Columns("USE_YN").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"Y:Yes", "N:No"})
        GV1.Columns("VAC_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:SVR08, NameType:",, "", " ")
        GV1.Columns("RANSOM_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:SVR09, NameType:",, "", " ")
        GV1.Columns("OS_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx("CommonCode", "GroupCode:SVR10, NameType:",, "", " ")


        GV2.Columns("MODULE_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:SVR01, NameType:")
        GV2.Columns("LOOP_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:SVR05, NameType:")
        GV2.Columns("PROC_WAIT_SEC").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:SVR06, NameType:")
        GV2.Columns("PROC_LOG_SEC").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:SVR07, NameType:")
        GV2.Columns("USE_YN").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"Y:Yes", "N:No"})

        GV3.Columns("SERVER_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:SVR02, NameType:")
        GV3.Columns("MODULE_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:SVR01, NameType:")

        Dim memoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        memoExEdit.PopupFormSize = New Size(GV1.Columns("RMK").Width, 300)
        memoExEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        memoExEdit.ShowIcon = False
        memoExEdit.MaxLength = 4000
        memoExEdit.ScrollBars = ScrollBars.Vertical

        GV1.Columns("RMK").ColumnEdit = memoExEdit
        RemoveHandler memoExEdit.KeyPress, AddressOf MemoExEdit_KeyPress
        AddHandler memoExEdit.KeyPress, AddressOf MemoExEdit_KeyPress
    End Sub
    Private Sub MemoExEdit_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If AscW(e.KeyChar) = Keys.Space Then
                'e.Handled = True
                Dim memoExEdit = TryCast(sender, DevExpress.XtraEditors.MemoExEdit)
                memoExEdit.ShowPopup()
                SendKeys.Send("^+{End}")
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message & " (MemoExEdit_KeyPress)")
        End Try
    End Sub
    Private Sub PopUpInit()

        WG1_PopUp = New PopupBase
        WG1_PopUp.ItemAdd(Action.Addrow, "WG1_AddRow", "&Add Row")
        WG1_PopUp.ItemAdd(Action.DeleteRow, "WG1_DeleteRow", "&Delete Row")
        WG1_PopUp.ItemAdd(Action.Excel, "WG1_ExcelExport", "&Export Excel", True)
        WG1_PopUp.PopUpInit(Me, WG1, "SERVER_IP", "USE_YN")

        WG2_PopUp = New PopupBase
        WG2_PopUp.ItemAdd(Action.Addrow, "WG2_AddRow", "&Add Row")
        WG2_PopUp.ItemAdd(Action.DeleteRow, "WG2_DeleteRow", "&Delete Row")
        WG2_PopUp.ItemAdd(Action.Excel, "WG2_ExcelExport", "&Export Excel", True)
        WG2_PopUp.PopUpInit(Me, WG2, "MODULE_TYPE", "USE_YN")

        WG3_PopUp = New PopupBase
        'WG3_PopUp.ItemAdd(Action.NavigateTo, "MsgKakaoMgt", "문자 보내기", True)
        WG3_PopUp.ItemAdd(Action.NavigateTo, "MsgKakaoMgt", "PC카톡 메세지 보내기", True)
        WG3_PopUp.ItemAdd(Action.Other, "AutoSend", "PC카톡 자동메세지 보내기", True)
        WG3_PopUp.ItemAdd(Action.Excel, "WG3_ExcelExport", "&Export Excel", True)
        WG3_PopUp.PopUpInit(Me, WG3)

    End Sub
    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Try
            Select Case Dr("Sender").ToString
                Case "WG1"
                    Select Case Dr("Action").ToString
                        Case Action.Addrow, Action.EventKey
                            If Dr("Action").ToString = Action.EventKey AndAlso Not Dr("Key").ToString = "Enter" Then Exit Sub

                            '## CellValueChanged 발생 ##
                            'GV1.SetRowCellValue(GV1.FocusedRowHandle, "USE_YMD", Now.ToString("yyyyMMdd"))

                            '## CellValueChanged 미발생 ##
                            Dim dt As DataTable = CType(WG1.DataSource, DataTable)

                            dt.Rows(dt.Rows.Count - 1)("SERVER_TYPE") = "WEB"
                            dt.Rows(dt.Rows.Count - 1)("LOC_TYPE") = "G"
                            dt.Rows(dt.Rows.Count - 1)("CTRT_AMT") = 0
                            dt.Rows(dt.Rows.Count - 1)("MATN_AMT") = 0
                            dt.Rows(dt.Rows.Count - 1)("USE_YN") = "Y"
                    End Select
                Case "WG2"
                    Select Case Dr("Action").ToString
                        Case Action.Addrow, Action.EventKey
                            If Dr("Action").ToString = Action.EventKey AndAlso Not Dr("Key").ToString = "Enter" Then Exit Sub
                            If GV1.RowCount = 0 Then Exit Sub

                            '## CellValueChanged 발생 ##

                            '## CellValueChanged 미발생 ##
                            Dim dt As DataTable = CType(WG2.DataSource, DataTable)
                            dt.Rows(dt.Rows.Count - 1)("MNGT_NO") = GV1.GetFocusedRowCellValue("MNGT_NO").ToString
                            dt.Rows(dt.Rows.Count - 1)("LOOP_TYPE") = "S"
                            dt.Rows(dt.Rows.Count - 1)("LOOP_VALUE") = "1"
                            dt.Rows(dt.Rows.Count - 1)("PROC_WAIT_SEC") = "30"
                            dt.Rows(dt.Rows.Count - 1)("PROC_LOG_SEC") = "300"
                            dt.Rows(dt.Rows.Count - 1)("USE_YN") = "Y"
                    End Select
                Case "WG3"
                    Select Case Dr("Action").ToString
                        Case Action.NavigateTo
                            Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                            Dim fTarget As Object = frmMain.NavigateTo("MsgKakaoMgt", NavigatedWindowModes.Dialog, False)
                            If Not IsNothing(fTarget) Then
                                fTarget.AuthSendType.SelectedIndex = 1
                                fTarget.SendAutoMsg.YesNo = "N"
                                fTarget.SendAutoMsg.YesNo = "N"
                                fTarget.kakaoMSG.Text = GV3.GetFocusedRowCellValue("CHK_MSG").ToString
                                fTarget.SendAutoMsgList.Text = GV3.GetFocusedRowCellValue("KAKAOPC_LIST").ToString
                                fTarget.ShowDialog()
                                fTarget = Nothing
                            End If
                        Case Action.Other
                            Select Case Dr("Key").ToString
                                Case "AutoSend"
                                    Call KakaoAutoSend(GV3.FocusedRowHandle)
                            End Select
                    End Select
            End Select
        Catch ex As Exception
            MsgBoxLocalized(String.Format("{0} (PopUpOnAfterClick)", ex.Message))
        End Try
    End Sub
    Private Sub KakaoAutoSend(ByVal iFousedRowHandle As Integer)
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = frmMain.NavigateTo("MsgKakaoMgt", NavigatedWindowModes.Dialog, False)
        If Not IsNothing(fTarget) Then
            fTarget.AuthSendType.SelectedIndex = 1
            fTarget.SendAutoMsg.YesNo = "Y"
            fTarget.SendAutoMsg.YesNo = "Y"
            fTarget.kakaoMSG.Text = GV3.GetRowCellValue(iFousedRowHandle, "CHK_MSG").ToString
            fTarget.SendAutoMsgList.Text = GV3.GetRowCellValue(iFousedRowHandle, "KAKAOPC_LIST").ToString
            fTarget.ShowDialog()
            fTarget = Nothing
        End If
    End Sub
    Public Sub PopUpOnBeforeClick(ByRef DataRow As DataRow)
        Try
            If DataRow("KEY") = "WG1_AddRow" Then
                GV1.ClearSorting()
            ElseIf DataRow("KEY") = "WG2_AddRow" Then
                GV2.ClearSorting()
            End If
        Catch ex As Exception
            MsgBoxLocalized(String.Format("{0} (PopUpOnBeforeClick)", ex.Message))
        End Try
    End Sub
    Public Sub MenuListBeforeShow(ByRef DataDic As Dictionary(Of String, Boolean))
        'Try
        '    If READONLY_YN.Text = "Y" Then
        '        DataDic("WG1_AddRow") = False
        '        DataDic("WG1_DelRow") = False
        '    Else
        '        DataDic("WG1_AddRow") = True
        '        DataDic("WG1_DelRow") = True
        '    End If
        'Catch ex As Exception
        '    MsgBoxLocalized(String.Format("{0} (MenuListBeforeShow)", ex.Message))
        'End Try
    End Sub
#End Region

#Region "=================Data logic actions==========="
    Private Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("Search")
        ds = Func.MethodCall(Me, "YJIT.Biz.SvrModuleMgt", "Search", ds)

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case dr("TrxCode").ToString
            Case "Y"
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.None
            Case "N"
                ClearView(UI.AppliedRangeTypes.Only, {WG1})
                Me.DataState = UI.DataStates.None
            Case Else
                MsgBoxLocalized(dr("trxMsg").ToString)
                Exit Sub
        End Select
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            'If String.IsNullOrEmpty(S_DATE_FROM.Text) OrElse String.IsNullOrEmpty(S_DATE_TO.Text) Then
            '    If String.IsNullOrEmpty(S_DATE_FROM.Text) Then
            '        ErrControl = S_DATE_FROM
            '    Else
            '        ErrControl = S_DATE_TO
            '    End If
            '    ErrMsg = Func.Msg(Me, "{0}을 입력해주세요.", lbl_S_DATE.Text) & vbNewLine
            'End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
        Return True
    End Function
    Private Sub SearchModuleData()
        If GV1.RowCount = 0 Then Exit Sub
        If GV1.FocusedRowHandle < 0 Then Exit Sub

        Call ClearView(AppliedRangeTypes.Only, {WG2})

        Dim ds As DataSet = GetConvertToDataSet("SearchModule")
        ds = Func.MethodCall(Me, "YJIT.Biz.SvrModuleMgt", "Search", ds)
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode").ToString
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.None
            Case "E"
                MsgBoxLocalized(dr("TrxMsg").ToString)
        End Select


        'If String.IsNullOrEmpty(GV1.GetRowCellValue(GV1.FocusedRowHandle, "CRM_SERVER_MODULE").ToString) Then Exit Sub
        'Dim xmlDetail As System.IO.StringReader = New System.IO.StringReader(GV1.GetRowCellValue(GV1.FocusedRowHandle, "CRM_SERVER_MODULE").ToString)
        'Dim dsDetail As DataSet = New DataSet
        'dsDetail.ReadXml(xmlDetail)
        'If Not IsNothing(dsDetail.Tables("ROW")) Then
        '    dsDetail.Tables("ROW").TableName = "Data.WG2"
        '    Me.BindToDataset(dsDetail, "Data")
        'End If
    End Sub
    Public Sub SaveData()
        Try
            If MandatoryGridvalue("GV1") Then Exit Sub
            If SaveValidate() = False Then Exit Sub

            If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

            Dim ds As DataSet = GetConvertToDataSet("Search")
            ds.Tables.Add(Me.ConvertToDataset.Tables("WG1").Copy)
            ds.Tables.Add(Me.ConvertToDataset.Tables("WG2").Copy)

            Try
                ds = MethodCallEx(Me, "YJIT.Biz.SvrModuleMgt", "Save", {ds})
            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
            End Try

            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") = "Y" Then
                Try
                    ProcSave = True

                    Me.BindToDataset(ds, "Data")

                    For i = 0 To GV1.RowCount - 1
                        If Not dr.Table.Columns.Contains("MngtNo") Then Exit For
                        If GV1.GetRowCellValue(i, "MNGT_NO").ToString = dr("MngtNo").ToString Then
                            GV1.FocusedRowHandle = i
                            Exit For
                        End If
                    Next

                    Call SearchModuleData()
                Catch ex As Exception
                    Throw New Exception(ex.Message & " (BindToDataset)")
                Finally
                    ProcSave = False
                End Try

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
        Dim ErrGrid As Object = Nothing
        Dim ErrGridRow As Integer = Nothing
        Dim ErrGridCol As Object = Nothing

        Try
            'If String.IsNullOrEmpty(S_USE_FM_YMD.Text) OrElse String.IsNullOrEmpty(S_USE_TO_YMD.Text) Then
            '    ErrMsg = "이용일은 필수값입니다." & vbNewLine
            '    If String.IsNullOrEmpty(S_USE_FM_YMD.Text) Then
            '        ErrControl = S_USE_FM_YMD
            '    Else
            '        ErrControl = S_USE_TO_YMD
            '    End If
            'End If

            Dim ds As DataSet = Me.ConvertToDataset

            If ds.Tables("WG1").Rows.Count = 0 AndAlso ds.Tables("WG2").Rows.Count = 0 Then
                ErrMsg = "저장할 자료가 없습니다." & vbNewLine
                If ds.Tables("WG2").Rows.Count = 0 Then
                    ErrControl = WG2
                Else
                    ErrControl = WG1
                End If
            End If

            Try
                For i = 0 To GV1.RowCount - 1
                    Dim row As DataRow = GV1.GetDataRow(i)
                    If row.RowState = DataRowState.Unchanged Then Continue For
                    If row.RowState = DataRowState.Deleted Then Continue For
                    If row.RowState = DataRowState.Detached Then Continue For

                    If String.IsNullOrEmpty(row("SERVER_IP").ToString) Then
                        ErrMsg &= String.Format("{0} 필수로 입력해 주세요", GV1.Columns("SERVER_IP").Caption)
                        If ErrGrid Is Nothing Then
                            ErrGrid = GV1
                            ErrGridRow = i
                            ErrGridCol = CType(GV1, DevExpress.XtraGrid.Views.Grid.GridView).Columns("SERVER_IP")
                        End If
                        Exit Try
                    End If
                Next

                For i = 0 To GV2.RowCount - 1
                    Dim row As DataRow = GV2.GetDataRow(i)
                    If row.RowState = DataRowState.Unchanged Then Continue For
                    If row.RowState = DataRowState.Deleted Then Continue For
                    If row.RowState = DataRowState.Detached Then Continue For

                    If String.IsNullOrEmpty(row("SMS_LIST").ToString) AndAlso String.IsNullOrEmpty(row("EMAIL_LIST").ToString) Then
                        ErrMsg &= String.Format("{0}, {1} 둘중 하나는 필수로 입력해 주세요", GV2.Columns("SMS_LIST").Caption, GV2.Columns("EMAIL_LIST").Caption)
                        If ErrGrid Is Nothing Then
                            ErrGrid = GV2
                            ErrGridRow = i
                            If String.IsNullOrEmpty(row("SMS_LIST").ToString) Then
                                ErrGridCol = CType(GV2, DevExpress.XtraGrid.Views.Grid.GridView).Columns("SMS_LIST")
                            Else
                                ErrGridCol = CType(GV2, DevExpress.XtraGrid.Views.Grid.GridView).Columns("EMAIL_LIST")
                            End If
                        End If
                        Exit Try
                    End If
                Next
            Catch ex As Exception
                Throw New Exception(ex.Message & " (GridSaveValidate)")
            End Try



            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then
                    ErrControl.Focus()
                Else
                    If Not ErrGrid Is Nothing Then
                        ErrGrid.FocusedRowHandle = ErrGridRow
                        ErrGrid.FocusedColumn = ErrGridCol
                        ErrGrid.ShowEditor()
                    End If
                End If
                Throw New Exception(ErrMsg)
            End If


            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function
    Private Sub SearchModuleAutoCheckData()
        Call ClearView(AppliedRangeTypes.Only, {WG3})

        Dim ds As DataSet = GetConvertToDataSet("SearchModuleAutoCheck")
        ds = Func.MethodCall(Me, "YJIT.Biz.SvrModuleMgt", "Search", ds)
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case dr("TrxCode").ToString
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")

                If SendAutoMsg.YesNo = "Y" Then
                    '동일메세지 취합후 전송되도록 수정해야함
                    For i = 0 To GV3.RowCount - 1
                        Call KakaoAutoSend(i)
                    Next
                End If

                Me.DataState = UI.DataStates.None
            Case "E"
                MsgBoxLocalized(dr("TrxMsg").ToString)
        End Select

        lblModuleAutoCheck.Text = "체크시간 : " & Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub
    Public Function MandatoryGridvalue(ByVal gridview As String) As Boolean
        Dim param As New Dictionary(Of String, Object)
        Dim checknull() As String = Nothing
        Select Case gridview
            Case "GV1"
                checknull = {"SERVER_IP"}
                param("SERVER_TYPE") = GV1_SERVER_TYPE.Caption()
                param("LOC_TYPE") = GV1_LOC_TYPE.Caption()
                param("USE_YN") = GV1_USE_YN.Caption()

                Return ValidateGridValue(GV1, param, checknull)
            Case "GV2"
                checknull = {"MODULE_TYPE"}
                param("LOOP_TYPE") = GV2_LOOP_TYPE.Caption()
                param("LOOP_VALUE") = GV2_LOOP_VALUE.Caption()
                param("USE_YN") = GV2_USE_YN.Caption()

                Return ValidateGridValue(GV2, param, checknull)
        End Select
        Return False
    End Function
#End Region

#Region "=================Control Events==========="
    Private Sub SvrModuleMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitPage()
        Call InitGrid()
    End Sub

    Private Sub SvrModuleMgt_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call PopUpInit()

        Call SearchData()

        S_SEARCH_KEY.Focus()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub SvrModuleMgt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        timerCheck.Stop()
    End Sub

    Private Sub btnSearchCheck_Click(sender As Object, e As EventArgs) Handles btnSearchCheck.Click
        Call SearchModuleAutoCheckData()
    End Sub
    Private Sub btnCheckStartStop_Click(sender As Object, e As EventArgs) Handles btnCheckStartStop.Click
        If btnCheckStartStop.Text.EndsWith("종료") Then
            btnCheckStartStop.Text = btnCheckStartStop.Text.Replace("종료", "시작")
            timerCheck.Stop()

            lblModuleAutoCheck.Text = "체크중단 : " & Now.ToString("yyyy-MM-dd HH:mm:ss")
        Else
            btnCheckStartStop.Text = btnCheckStartStop.Text.Replace("시작", "종료")
            timerCheck.Interval = cmbLoopType.Value
            timerCheck.Start()
            Call timerCheck_Tick(Nothing, Nothing)
        End If
    End Sub
    Private Sub timerCheck_Tick(sender As Object, e As EventArgs) Handles timerCheck.Tick
        Call SearchModuleAutoCheckData()
    End Sub
    Private Sub cmbLoopType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbLoopType.SelectionChangeCommitted
        timerCheck.Interval = cmbLoopType.Value
        Call SearchModuleAutoCheckData()
    End Sub
    Private Sub SendAutoMsg_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles SendAutoMsg.EditValueChanging
        Try
            If SendAutoMsg.Checked = False Then
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("MsgKakaoMgt", NavigatedWindowModes.Dialog, False)
                If Not IsNothing(fTarget) Then
                    fTarget.AuthSendType.SelectedIndex = 0
                    fTarget.SendAutoMsg.YesNo = "N"
                    If GV3.RowCount > 0 Then
                        fTarget.kakaoMSG.Text = GV3.GetFocusedRowCellValue("CHK_MSG").ToString
                        fTarget.SendAutoMsgList.Text = GV3.GetFocusedRowCellValue("KAKAOPC_LIST").ToString
                    End If
                    fTarget.ShowDialog()
                    If String.IsNullOrEmpty(fTarget.authCD.Text) Then
                        MsgBoxLocalized("PC카톡 인증을 진행하세요.")
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub SendAutoMsg_CheckedChanged(sender As Object, e As EventArgs) Handles SendAutoMsg.CheckedChanged

    End Sub
    Private Sub GV1_Click(sender As Object, e As EventArgs) Handles GV1.Click
        Try
            If GV1.RowCount = 0 Then Exit Sub
            If bGV1_FocusedRowChanged = True Then Exit Sub

            Call SearchModuleData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            bGV1_FocusedRowChanged = False
        End Try
    End Sub
    Dim bGV1_FocusedRowChanged As Boolean = False
    Private Sub GV1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Try
            If ProcSave = True Then Exit Sub
            If GV1.RowCount = 0 Then Exit Sub
            If GV1.IsValidRowHandle(e.FocusedRowHandle) = False Then Exit Sub

            If e.PrevFocusedRowHandle >= 0 Then bGV1_FocusedRowChanged = True

            Call SearchModuleData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub GV1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GV1.CellValueChanged
        If GV1 Is Nothing Then Exit Sub
        If GV1.RowCount = 0 Then Exit Sub
        If e.RowHandle < 0 Then Exit Sub

        Select Case e.Column.FieldName
                '미입력시 0처리
            Case "CTRT_AMT", "MATN_AMT"
                Dim row As DataRow = GV1.GetFocusedDataRow
                If Not IsNumeric(row(e.Column.FieldName).ToString) Then row(e.Column.FieldName) = 0
        End Select
    End Sub
    Private Sub GV2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GV2.CellValueChanged
        If GV2 Is Nothing Then Exit Sub
        If GV2.RowCount = 0 Then Exit Sub
        If e.RowHandle < 0 Then Exit Sub

        Select Case e.Column.FieldName
                '미입력시 기본값 처리
            Case "PROC_WAIT_SEC"
                Dim row As DataRow = GV1.GetFocusedDataRow
                If Not IsNumeric(row(e.Column.FieldName).ToString) Then row(e.Column.FieldName) = 30
            Case "PROC_LOG_SEC"
                Dim row As DataRow = GV1.GetFocusedDataRow
                If Not IsNumeric(row(e.Column.FieldName).ToString) Then row(e.Column.FieldName) = 300
        End Select

        ''DATATABLE TO XML / 추가된 내용 적용안됨
        'Dim dsWG2 As DataSet = New DataSet("ROWSET")
        'dsWG2.Tables.Add(CType(WG2.DataSource, DataTable).Copy)
        'dsWG2.Tables(0).TableName = "ROW"
        'Dim drWG1 As DataRow = GV1.GetFocusedDataRow
        'drWG1("CRM_SERVER_MODULE") = "<?xml version=""1.0""?>" & vbNewLine & dsWG2.GetXml
    End Sub








#End Region
End Class