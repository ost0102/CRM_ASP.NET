Public Class YjediMappingMgt
    Dim WG1_PopUp As New PopupBase

#Region "=================GetConvertToDataSet Function==========="
    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim IsSingleSearch As Boolean = False

        Try
            YJSql.SqlBox("WG1", "YjediMappingMgt@Search", False, True)
            YJSql.Params("OFFICE_CD", ClientSessionInfo.OfficeCode)
            YJSql.Params("CUSTOMS_CD", CUSTOMS_CD.Text.Trim)
            YJSql.Params("SYS_ID", SYS_ID.Text.Trim)
            YJSql.Params("TABLE_NM", TABLE_NM.Text.Trim)
            YJSql.Params("FM_CD", FM_CD.Text.Trim)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region
#Region "=================Client Function=============="
    Private Sub GridToExcel(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Common.ExportToExcel(obj)
    End Sub
    Private Sub PopupInit()

        WG1_PopUp = New PopupBase
        WG1_PopUp.ItemAdd(Action.Addrow, "InsertRow", "행추가(&A)")
        WG1_PopUp.ItemAdd(Action.DeleteRow, "DeleteRow", "행삭제(&D)")
        WG1_PopUp.ItemAdd(Action.Excel, "Excel", "엑셀내려받기")
        WG1_PopUp.PopUpInit(Me, WG1, btnQuickWg1, "CUSTOMS_CD", "RMK")
    End Sub
    Private Sub InitGrid()
        GridFunc.SetGridViewStyle(GV1)
        Call DrawRowIndicator(GV1)

        '## WG1 ##
        GV1.Columns("CUSTOMS_CD").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx({"NEXN:넥센"})
        GV1.Columns("SYS_ID").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx({"ESVC:E-Service", "N:NO"})
    End Sub

    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = Dr("Sender")

        Select Case Dr("Action")
            Case Action.Addrow, Action.EventKey
                Select Case Sender
                    Case "WG1"
                        If GV1.RowCount = 1 Then
                            '메인값 자료연동
                            GV1.SetFocusedRowCellValue("CUSTOMS_CD", (CUSTOMS_CD.Text).ToString)
                            GV1.SetFocusedRowCellValue("SYS_ID", (SYS_ID.Text).ToString)
                            GV1.SetFocusedRowCellValue("FM_CD", (FM_CD.Text).ToString)
                        Else
                            '그리드 상위 행 자료연동
                            If Not GV1.IsValidRowHandle(GV1.FocusedRowHandle - 1) Then Exit Sub

                            GV1.SetFocusedRowCellValue("CUSTOMS_CD", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "CUSTOMS_CD").ToString)
                            GV1.SetFocusedRowCellValue("SYS_ID", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "SYS_ID").ToString)
                            GV1.SetFocusedRowCellValue("TABLE_NM", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "TABLE_NM").ToString)
                            GV1.SetFocusedRowCellValue("TO_GRP_CD", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "TO_GRP_CD").ToString)
                        End If
                End Select
        End Select
    End Sub
#End Region
#Region "=================Data logic actions==========="
    'Data Logic Action : Server 함수 호출 부분 및 메인 버튼 동작 함수 모음
    Public Sub SearchData()

        If SearchValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet()
        ds = Func.MethodCall(Me, "YJIT.Biz.YjediMappingMgt", "Search", {ds})
        Dim drPairs As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("trxCode")
            Case "Y"
                Try
                    ClearView(UI.AppliedRangeTypes.Only, {WG1})

                    Me.BindToDataset(ds, "Data")
                Catch ex As Exception
                    MsgBoxLocalized(ex.Message & " (BindToDataset)")
                End Try

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(drPairs("trxMsg"))
                ClearView(UI.AppliedRangeTypes.Only, {WG1})

                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("trxMsg"))
        End Select
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(CUSTOMS_CD.Text) Then
                If ErrControl Is Nothing Then ErrControl = CUSTOMS_CD
                'ErrMsg &= "Please input the [" & S_CUST_TYPE.SelectedText & "]" & vbNewLine
                '다국어 지원
                ErrMsg &= "[" & LBL_CUSTOMS_CD.Text & "]를 입력해주세요." & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized("전체 필수항목입니다." & vbCrLf & vbCrLf & ex.Message)
            Return False
        End Try
    End Function

    Public Sub SaveData()
        Try
            Dim ds As DataSet = Me.ConvertToDataset
            ds.Merge(GetConvertToDataSet)
            ds = Func.MethodCall(Me, "YJIT.Biz.YjediMappingMgt", "Save", {ds})
            Dim drPairs As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If drPairs("TrxCode") = "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG1})
                Me.BindToDataset(ds, "Data")
                GV1.ExpandAllGroups()
                Me.DataState = UI.DataStates.Retrieved
            End If

            MsgBoxLocalized(drPairs("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub
#End Region
#Region "=================Control Events==========="
    Private Sub YjediSpecMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitGrid()
    End Sub
    Private Sub YjediSpecMgt_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call PopupInit()
        CUSTOMS_CD.Focus()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call ClearView()
        CUSTOMS_CD.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub btnAddWG1_Click(sender As Object, e As EventArgs) Handles btnAddWG1.Click
        Call GridFunc.AddGridRow(WG1, WG1_PopUp)
    End Sub

    Private Sub btnDelWG1_Click(sender As Object, e As EventArgs) Handles btnDelWG1.Click
        Call GridFunc.DelGridRow(WG1, WG1_PopUp)
    End Sub

    Private Sub btnExpWg1_Click(sender As Object, e As EventArgs) Handles btnExpWg1.Click
        Call GridToExcel(WG1)
    End Sub
#End Region
End Class