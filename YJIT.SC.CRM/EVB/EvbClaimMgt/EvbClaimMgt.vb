Imports YJIT.SC.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class EvbClaimMgt
    Dim WG1_Popup As PopupBase = New PopupBase
#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal Type As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim drMain As DataRow = ds.Tables("MAIN").Rows(0)

        Select Case Type.ToUpper
            Case "SEARCH"
                YJSql.SqlBox("WG1", "EvbClaimMgt@Search", False, False)
                YJSql.Params("YEAR_MONTH", drMain("YEAR_MONTH").ToString)
        End Select
        Return YJSql.DataSet
    End Function
#End Region
#Region "=================Data logic actions============"
    'Search
    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SEARCH")

        ds = MethodCallEx(Me, "YJIT.Biz.EvbClaimMgt", "Search", {ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y"
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(dr("TrxMsg"))
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub

    'SearchValidate
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(YEAR_MONTH.Text.ToString) Then
                ErrMsg = "청구년월을 입력하세요." & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    'Save
    Public Sub SaveData()
        If SaveValidate() = False Then Exit Sub

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SEARCH")
        ds.Tables.Add(Me.ConvertToDataset.Tables("WG1").Copy)

        Try
            ds = MethodCallEx(Me, "YJIT.Biz.EvbClaimMgt", "Save", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Call ClearView(UI.AppliedRangeTypes.Only, {WG1})
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If
        MsgBoxLocalized(dr("TrxMsg"))
    End Sub

    'SaveValidate
    Private Function SaveValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            Dim ds As DataSet = Me.ConvertToDataset

            If ds.Tables("WG1").Rows.Count = 0 Then
                ErrMsg = "저장할 자료가 없습니다." & vbNewLine
                ErrControl = WG1
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    '재정산
    Private Sub RecalcData()
        If RecalcValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SEARCH")
        ds.Tables.Add(Me.ConvertToDataset.Tables("MAIN").Copy)

        Try
            ds = MethodCallEx(Me, "YJIT.Biz.EvbClaimMgt", "Recalc", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Call ClearView(UI.AppliedRangeTypes.Only, {WG1})
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
        Else
            MsgBoxLocalized(dr("TrxMsg"))
        End If

    End Sub

    Private Function RecalcValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(YEAR_MONTH.Text.ToString) Then
                ErrMsg = "청구년월을 입력하세요." & vbNewLine
            End If

            If GV1.RowCount = 0 Then
                ErrMsg = "재정산할 자료가 없습니다." & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    '마감
    Private Sub CloseData()
        For Each row As DataRow In CType(WG1.DataSource, DataTable).Rows
            If row("CLOSE_YN").ToString = "Y" Then
                row.AcceptChanges()
            Else
                row.AcceptChanges()
                row.SetAdded()
            End If
        Next

        Dim ds As DataSet = GetConvertToDataSet("SEARCH")
        ds.Tables.Add(Me.ConvertToDataset.Tables("WG1").Copy)

        If CloseValidate() = False Then Exit Sub

        Try
            ds = MethodCallEx(Me, "YJIT.Biz.EvbClaimMgt", "Close", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y"
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(dr("TrxMsg"))
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub

    Private Function CloseValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrGrid As Object = Nothing
        Dim ErrGridRow As Integer = Nothing
        Dim ErrGridCol As Object = Nothing
        'Dim ChkYn As Boolean = False

        Try
            ''CRM 코드 필수값 체크
            'Try
            '    For i = 0 To GV1.RowCount - 1
            '        If String.IsNullOrEmpty(GV1.GetRowCellValue(i, "CRM_CD").ToString) Then
            '            ErrMsg &= Me.Localizer1.GetLocalizedString("[" & GV1.GetRowCellValue(i, "BUSN_NO").ToString & "]" & GV1.GetRowCellValue(i, "BUSN_NM").ToString & "의 CRM 코드가 등록되지 않았습니다.") & vbNewLine
            '            If ErrGrid Is Nothing Then
            '                ErrGrid = GV1
            '                ErrGridRow = i
            '                'ErrGridCol = CType(GV1, DevExpress.XtraGrid.Views.Grid.GridView).Columns("CRM_CD")
            '                ErrGridCol = GV1_CRM_CD
            '            End If
            '            Exit Try
            '        End If
            '    Next
            'Catch ex As Exception
            '    MsgBoxLocalized(ex.Message)
            'End Try


            ''체크로직
            'For Each row As DataRow In ds.Tables("WG1").Rows
            '    If row("CLOSE_YN").ToString = "N" Then
            '        ChkYn = True
            '        Exit For
            '    End If
            'Next

            'If ChkYn = False Then
            '    ErrMsg = "이미 마감이 완료되었습니다." & vbNewLine
            'End If


            Dim ds As DataSet = Me.ConvertToDataset()
            If ds.Tables("WG1").Rows.Count = 0 Then
                MsgBoxLocalized("마감할 자료가 없습니다!")
                Return False
                Exit Function
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then
                    ErrControl.Focus()
                Else
                    If Not ErrGrid Is Nothing Then
                        ErrGrid.FocusedRowHandle = ErrGridRow
                        ErrGrid.FocusedColumn = ErrGridCol
                    End If
                End If
                Throw New Exception(ErrMsg)
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
        Return True
    End Function
    Public Sub SetDefaultValue()
        Me.YEAR_MONTH.Text = Now.ToString("yyyyMM")
    End Sub
    Private Sub PopupInit()
        WG1_Popup.ItemAdd(Action.Excel, "WG1_ExcelExport", "&Export Excel", True)
        WG1_Popup.PopUpInit(Me, WG1)
    End Sub
    Private Sub GridToExcel(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Common.ExportToExcel(obj)
    End Sub
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString
        Dim Sender As String = ""
        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")
        Select Case dr("Action")
            Case Action.Other

        End Select
    End Sub
#End Region

#Region "=================Control Events==========="
    Private Sub EvbClaimMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SetDefaultValue()
        Call DrawRowIndicator(GV1)
    End Sub
    Private Sub EvbClaimMgt_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.YEAR_MONTH.Focus()
        Call PopupInit()
    End Sub
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub btnRecalc_Click(sender As Object, e As EventArgs) Handles btnRecalc.Click
        Call RecalcData()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Call CloseData()
    End Sub
    '마감 후 폰트 변경
    Private Sub GV1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GV1.RowCellStyle
        If e.RowHandle < 0 Then Exit Sub
        Select Case e.Column.FieldName
            Case "BUSN_NO", "BUSN_NM"
                If GV1.GetRowCellValue(e.RowHandle, "CLOSE_YN").ToString = "Y" Then
                    e.Appearance.ForeColor = System.Drawing.Color.Blue
                    e.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
                End If
        End Select
    End Sub
    Private Sub GV1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GV1.CellValueChanged
        Select Case e.Column.FieldName
            Case "CLAIM_DISC_AMT"
                '최종 청구금액
                Dim LastAmt As Decimal = CDec(GV1.GetRowCellValue(e.RowHandle, "TOT_CLAIM_AMT").ToString) - CDec(GV1.GetRowCellValue(e.RowHandle, "CLAIM_DISC_AMT").ToString)
                GV1.SetRowCellValue(e.RowHandle, "LAST_CLAIM_AMT", LastAmt)

                '부가세
                Dim VatAmt As Decimal = CDec(GV1.GetRowCellValue(e.RowHandle, "LAST_CLAIM_AMT").ToString) * 0.1
                GV1.SetRowCellValue(e.RowHandle, "VAT_AMT", FreightCommon.CustomerRound(VatAmt, "2")) '소수점 버림

                '합계
                Dim TotalAmt As Decimal = CDec(GV1.GetRowCellValue(e.RowHandle, "LAST_CLAIM_AMT").ToString) + CDec(GV1.GetRowCellValue(e.RowHandle, "VAT_AMT").ToString)
                GV1.SetRowCellValue(e.RowHandle, "TOTAL_AMT", TotalAmt)
        End Select
    End Sub
    Private Sub GV1_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GV1.ShowingEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = sender
        Select Case view.FocusedColumn.FieldName
            Case "CLAIM_DISC_AMT"
                If view.GetFocusedRowCellValue("CLOSE_YN").ToString = "Y" Then e.Cancel = True '마감 후 수정불가
        End Select
    End Sub
End Class
#End Region