Public Class YjediSpecDetailMgt
    Dim WG1_PopUp As New PopupBase

#Region "=================GetConvertToDataSet Function==========="
    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim IsSingleSearch As Boolean = False

        Try
            YJSql.SqlBox("WG1", "YjediSpecDetailMgt@Search", False, True)
            YJSql.Params("OFFICE_CD", ClientSessionInfo.OfficeCode)
            YJSql.Params("CUSTOMS_CD", CUSTOMS_CD.Text.Trim)
            YJSql.Params("SYS_ID", SYS_ID.Text.Trim)
            YJSql.Params("SPEC_CD", SPEC_CD.SelectedValue.Trim)

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
        GV1.Columns("SYS_ID").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx({"ESVC:E-Service"})
        GV1.Columns("SPEC_CD").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx({"IFTSAI_D04B:Schedule", "IFTMBF_D99B:Booking Request", "IFTMBC_D99B:Booking Confrim", "IFTMIN_D99B:Shipping Request", "IFTMCS_D99B:Draft B/L", "VERMAS_D16A:VGM", "IFTSTA_D00A:Export License", "IFTSTA_D99B:Cargo Tracking", "APERAK_99B:Application Acknowledge", "INVOIC_D99B:Invoice Message"})
        GV1.Columns("USE_YN").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"Y:YES", "N:NO"})
        GV1.Columns("GROUP_YN").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"Y:YES", "N:NO"})
        GV1.Columns("MAND_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"M:M", "O:O", "C:C"})
        GV1.Columns("DATA_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"N:N", "AN:AN", "X:X", "A:A", "ID:ID", "R:R"})
    End Sub
    Private Sub GV1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        If GV1 Is Nothing Then Exit Sub
        If GV1.RowCount = 0 Then Exit Sub
        If e.RowHandle < 0 Then Exit Sub

        Select Case e.Column.FieldName
            Case "QUAL"
                Select Case GV1.GetRowCellValue(e.RowHandle, "QUAL")
                    Case "COL1"
                        GV1.SetRowCellValue(e.RowHandle, "UPPER_QUAL", "+")
                    Case Else
                        GV1.SetRowCellValue(e.RowHandle, "UPPER_QUAL", ":")
                End Select
            Case "SPEC_SEQ"
                'For i = 0 To GV1.RowCount - 1
                '    If GV1.GetRowCellValue(i, "SPEC_SEQ").ToString >= GV1.GetRowCellValue(GV1.FocusedRowHandle, "SPEC_SEQ").ToString Then
                '        If IsNumeric(GV1.GetRowCellValue(i, "SPEC_SEQ").ToString) Then
                '            GV1.SetRowCellValue(i, "SPEC_SEQ", CDec(GV1.GetRowCellValue(i, "SPEC_SEQ").ToString) + 1)
                '        End If
                '    End If
                'Next


                'For i = 0 To GV1.RowCount - 1
                '    If GV1.GetRowCellValue(i, "SPEC_SEQ").ToString >= GV1.GetRowCellValue(GV1.FocusedRowHandle, "SPEC_SEQ").ToString Then
                '        If IsNumeric(GV1.GetRowCellValue(i, "SPEC_SEQ").ToString) Then
                '            Dim row As DataRow = GV1.GetDataRow(e.RowHandle)
                '            row("SPEC_SEQ") = CDec(row("SPEC_SEQ").ToString) + 1
                '        End If
                '    End If
                'Next

                Dim dt As DataTable = CType(WG1.DataSource, DataTable)
                For i As Integer = 0 To dt.Rows.Count - 1
                    If i = e.RowHandle Then Continue For
                    If CDec(dt.Rows(i)("SPEC_SEQ").ToString) >= CDec(dt.Rows(e.RowHandle)("SPEC_SEQ").ToString) Then
                        If IsNumeric(dt.Rows(i)("SPEC_SEQ").ToString) Then
                            dt.Rows(i)("SPEC_SEQ") = CDec(dt.Rows(i)("SPEC_SEQ").ToString) + 1
                        End If
                    End If
                Next

                'For Each dr As DataRow In dt.Rows
                '    If dr.RowState = DataRowState.Modified Then Continue For
                '    If CDec(dr("SPEC_SEQ").ToString) >= CDec(GV1.GetRowCellValue(GV1.FocusedRowHandle, "SPEC_SEQ").ToString) Then
                '        If IsNumeric(dr("SPEC_SEQ").ToString) Then
                '            dr("SPEC_SEQ") = CDec(dr("SPEC_SEQ").ToString) + 1
                '            'ElseIf CDec(dr("SPEC_SEQ").ToString) = CDec(GV1.GetRowCellValue(GV1.FocusedRowHandle, "SPEC_SEQ").ToString) Then
                '            '    If IsNumeric(dr("SPEC_SEQ").ToString) Then
                '            '        dr("SPEC_SEQ") = CDec(dr("SPEC_SEQ").ToString)
                '            '    End If
                '            '    'ElseIf CDec(dr("SPEC_SEQ").ToString) < CDec(GV1.GetRowCellValue(GV1.FocusedRowHandle, "SPEC_SEQ").ToString) Then
                '            '    '    If IsNumeric(dr("SPEC_SEQ").ToString) Then
                '            '    '        dr("SPEC_SEQ") = CDec(dr("SPEC_SEQ").ToString) + 1
                '            '    '    End If
                '        End If
                '    End If
                'Next

                'Dim dt As DataTable = CType(WG1.DataSource, DataTable)
                'For Each dr As DataRow In dt.Rows
                '    If CDec(dr("SPEC_SEQ").ToString) >= CDec(GV1.GetRowCellValue(GV1.FocusedRowHandle, "SPEC_SEQ").ToString) Then
                '        If IsNumeric(dr("SPEC_SEQ").ToString) Then
                '            dr("SPEC_SEQ") = CDec(dr("SPEC_SEQ").ToString) + 1
                '        End If
                '    End If
                'Next
        End Select
    End Sub

    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = Dr("Sender")

        Select Case Dr("Action")
            Case Action.Addrow
                Select Case Sender
                    Case "WG1"
                        If GV1.RowCount = 1 Then
                            '메인값 자료연동
                            GV1.SetFocusedRowCellValue("CUSTOMS_CD", (CUSTOMS_CD.Text).ToString)
                            GV1.SetFocusedRowCellValue("SYS_ID", (SYS_ID.Text).ToString)
                            GV1.SetFocusedRowCellValue("SPEC_CD", (SPEC_CD.SelectedValue).ToString)
                        Else
                            '그리드 상위 행 자료연동
                            If Not GV1.IsValidRowHandle(GV1.FocusedRowHandle - 1) Then Exit Sub

                            GV1.SetFocusedRowCellValue("CUSTOMS_CD", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "CUSTOMS_CD").ToString)
                            GV1.SetFocusedRowCellValue("SYS_ID", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "SYS_ID").ToString)
                            GV1.SetFocusedRowCellValue("SPEC_CD", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "SPEC_CD").ToString)
                            GV1.SetFocusedRowCellValue("SPEC_VER", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "SPEC_VER").ToString)
                            GV1.SetFocusedRowCellValue("SEG", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "SEG").ToString)
                            GV1.SetFocusedRowCellValue("DATA_TYPE", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "DATA_TYPE").ToString)
                            GV1.SetFocusedRowCellValue("GROUP_YN", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "GROUP_YN").ToString)
                            GV1.SetFocusedRowCellValue("USE_YN", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "USE_YN").ToString)
                            GV1.SetFocusedRowCellValue("UPPER_SEG", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "UPPER_SEG").ToString)
                            GV1.SetFocusedRowCellValue("UPPER_QUAL", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "UPPER_QUAL").ToString)
                            GV1.SetFocusedRowCellValue("MAND_TYPE", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "MAND_TYPE").ToString)
                            GV1.SetFocusedRowCellValue("SPEC_SEQ", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "SPEC_SEQ".ToString) + 1)
                            GV1.SetFocusedRowCellValue("DATA_LEN", 0)
                            GV1.SetFocusedRowCellValue("QUAL", GV1.GetRowCellValue(GV1.FocusedRowHandle - 1, "QUAL").ToString.Substring(0, 3))
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
        ds = Func.MethodCall(Me, "YJIT.Biz.YjediSpecDetailMgt", "Search", {ds})
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
            ds = Func.MethodCall(Me, "YJIT.Biz.YjediSpecDetailMgt", "Save", {ds})
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

    Private Sub YjediSpecDetailMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitGrid()
    End Sub

    Private Sub YjediSpecDetailMgt_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call PopupInit()
        CUSTOMS_CD.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call ClearView()
        CUSTOMS_CD.Focus()
        SPEC_CD.SelectedValue = "IFTSAI_D04B"
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