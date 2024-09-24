Imports YJIT.SC.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class EvbMgmtHistory
    Dim WG2_PopUp As New PopupBase
    Dim WG3_PopUp As New PopupBase
#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal Type As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim drMain As DataRow = ds.Tables("MAIN").Rows(0)

        Select Case Type.ToUpper
            Case "Search".ToUpper
                YJSql.SqlBox("WG1", "EvbMgmtHistory@Search", True)
                YJSql.Params("SEARCH_KEY", drMain("S_SEARCH_KEY").ToString)
            Case "SearchDetail".ToUpper
                YJSql.SqlBox("WG2", "EvbMgmtHistory@SearchDetail", True)
                YJSql.Params("USER_AUTH_ID", GV1.GetRowCellValue(GV1.FocusedRowHandle, "USER_AUTH_ID").ToString)
                YJSql.Params("INS_YMD_FROM", drMain("S_INS_YMD_FROM").ToString)
                YJSql.Params("INS_YMD_TO", drMain("S_INS_YMD_TO").ToString)
                YJSql.Params("TAX_MGMT_NO", drMain("S_TAX_MGMT_NO").ToString)
                YJSql.Params("BL_INV_NO", drMain("S_BL_INV_NO").ToString)
                YJSql.Params("TRADE_NM", drMain("S_TRADE_NM").ToString)
                YJSql.Params("EMAIL", drMain("S_EMAIL").ToString)
                If S_TAX.Checked = True AndAlso S_DOC_CLASS.Checked = False Then
                    YJSql.Params("DOC_DIV", "TAX")
                ElseIf S_DOC_CLASS.Checked = True AndAlso S_TAX.Checked = False Then
                    YJSql.Params("DOC_DIV", "CRD")
                End If
            Case "SearchHistory".ToUpper
                If GV2.RowCount > 0 Then
                    YJSql.SqlBox("WG3", "EvbMgmtHistory@SearchStatus", True)
                    YJSql.Params("TAX_DOC_NO", GV2.GetRowCellValue(GV2.FocusedRowHandle, "TAX_DOC_NO").ToString)

                    YJSql.SqlBox("WG4", "EvbMgmtHistory@SearchEmail", True)
                    YJSql.Params("DOC_NO", GV2.GetRowCellValue(GV2.FocusedRowHandle, "TAX_DOC_NO").ToString)
                End If
        End Select
        Return YJSql.DataSet
    End Function
#End Region
#Region "=================Client Function==========="
    Private Sub PopupInit()
        'WG2 우클릭
        WG2_PopUp.ItemAdd(Action.EventKey, "GV2_SelectAll", "전체 선택", True)
        WG2_PopUp.ItemAdd(Action.Excel, "WG2_ExcelExport", "&Export Excel", True)
        WG2_PopUp.PopUpInit(Me, WG2)
        'WG3 우클릭
        WG3_PopUp.ItemAdd(Action.Other, "ReprocessData", "응답 재처리", True)
        WG3_PopUp.PopUpInit(Me, WG3)
    End Sub
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim Key As String = dr("Key")
        Dim fTarget As Object = Nothing

        Select Case dr("Action")
            Case Action.Other
                Select Case Key
                    Case "ReprocessData"
                        Call ReprocessData()
                End Select
            Case Else
                If fTarget IsNot Nothing Then
                    For i As Integer = 0 To GV1.RowCount - 1
                        If GV2.GetRowCellValue(i, "CHK").ToString = "Y" Then
                            GV2.GetDataRow(i).AcceptChanges()
                            GV2.GetDataRow(i).SetAdded()
                        Else
                            GV2.GetDataRow(i).AcceptChanges()
                        End If
                    Next

                    Dim dt As DataTable = Me.ConvertToDataset.Tables("WG2")
                    For Each dr In dt.Rows
                        If dr("CHK").ToString = "N" Then
                            dt.Rows.Remove(dr)
                        End If
                    Next
                    fTarget.ClearView()
                    fTarget.showDialog()
                End If

                Select Case Key
                    Case "GV2_SelectAll"
                        Call SelectAll()
                End Select
        End Select
    End Sub
    Private Sub SelectAll()
        Dim checkAll As Boolean = False
        For i As Integer = 0 To GV2.RowCount - 1
            If GV2.GetRowCellValue(i, "CHK").ToString = "N" Then
                checkAll = True
                Exit For
            End If
        Next
        If checkAll = True Then
            For i As Integer = 0 To GV2.RowCount - 1
                GV2.SetRowCellValue(i, "CHK", "Y")
            Next
        Else
            For i As Integer = 0 To GV2.RowCount - 1
                GV2.SetRowCellValue(i, "CHK", "N")
            Next
        End If
        Dim rowIndex As Integer = GV2.FocusedRowHandle
    End Sub
    Private Sub InitGrid()

    End Sub
#End Region
#Region "=================Data logic actions============"
    '조회
    Public Sub SearchData()
        Dim ds As DataSet = GetConvertToDataSet("Search")
        ds = MethodCallEx(Me, "YJIT.Biz.EvbMgmtHistory", "Search", {ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                If GV1.RowCount = 0 Then
                    MsgBoxLocalized("Data not found!")
                End If
                Me.DataState = UI.DataStates.Retrieved
            Case "E"
                MsgBoxLocalized(dr("TrxMsg"))
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    '리스트 조회
    Private Sub SearchDetailData()
        If IsNothing(GV1.GetRowCellValue(GV1.FocusedRowHandle, "USER_AUTH_ID")) Then Exit Sub
        If SearchDetailValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SearchDetail")
        ds = MethodCallEx(Me, "YJIT.Biz.EvbMgmtHistory", "Search", {ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                If GV1.RowCount = 0 Then
                    Call ClearView(AppliedRangeTypes.Only, {WG3, WG4})
                    MsgBoxLocalized("Data not found!")
                End If
                If GV2.RowCount = 0 Then
                    Call ClearView(AppliedRangeTypes.Only, {WG3, WG4})
                    MsgBoxLocalized("Data not found!")
                End If
                Me.DataState = UI.DataStates.Retrieved
            Case "E"
                MsgBoxLocalized(dr("TrxMsg"))
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    '전송상태 조회
    Private Sub SearchHistory()
        Dim ds As DataSet = GetConvertToDataSet("SearchHistory")
        ds = MethodCallEx(Me, "YJIT.Biz.EvbMgmtHistory", "Search", {ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case "E"
                MsgBoxLocalized(dr("TrxMsg"))
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    Private Function SearchDetailValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Try
            If String.IsNullOrEmpty(S_INS_YMD_FROM.Text.ToString) OrElse String.IsNullOrEmpty(S_INS_YMD_TO.Text.ToString) Then
                ErrMsg = "발행일자를 입력하세요." & vbNewLine
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
    '일괄 응답 재처리
    Private Sub ReprocessData_All()
        If ReprocessAllValidate() = False Then Exit Sub

        If MsgBoxLocalized("일괄 응답 재처리 하시겠습니까?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim dt As DataTable = CType(WG2.DataSource, DataTable)
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i).AcceptChanges()
            If dt(i)("CHK").ToString = "Y" Then
                dt.Rows(i).SetModified()
            End If
        Next

        Dim ds As DataSet = Me.ConvertToDataset
        Try
            ds = MethodCallEx(Me, "YJIT.Biz.EVBMgmtHistory", "Reprocess", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If
        MsgBoxLocalized(dr("TrxMsg"))

        Call SearchDetailData()
        Call SearchDetailValidate()
    End Sub
    '응답 재처리
    Private Sub ReprocessData()
        If MsgBoxLocalized("응답 재처리 하시겠습니까?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim dt As DataTable = CType(WG3.DataSource, DataTable)
        dt.Rows(GV3.FocusedRowHandle).AcceptChanges()
        dt.Rows(GV3.FocusedRowHandle).SetModified()

        Dim ds As DataSet = Me.ConvertToDataset
        Try
            ds = MethodCallEx(Me, "YJIT.Biz.EVBMgmtHistory", "Reprocess", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        Call SearchDetailData()
        Call SearchDetailValidate()
    End Sub
    Private Function ReprocessAllValidate() As Boolean
        Dim RowHandle = GV3.FocusedRowHandle
        Dim ErrMsg As String = String.Empty
        Try
            If Not String.IsNullOrEmpty(GV3.GetRowCellValue(RowHandle, "RCPT_ACK_DTM").ToString) Then
                ErrMsg = "" & vbNewLine
            End If
            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    Public Sub BillLink()
        Dim Crn As String = GV2.GetRowCellValue(GV2.FocusedRowHandle, "DMDER_BUSN_ID").ToString
        Dim TaxBillNo As String = GV2.GetRowCellValue(GV2.FocusedRowHandle, "TAX_MGMT_NO").ToString

        Process.Start("http://www.elvisbill.com/RelayPage/RelayPage?ContentType=A&SearchType=N&CRN_NO=" & Crn & "&N_Value=" & TaxBillNo)
        'Shell("C:\Program Files\Internet Explorer\IEXPLORE.EXE  http://www.elvisbill.com/RelayPage/RelayPage?ContentType=A&SearchType=N&CRN_NO=" & Crn & "&N_Value=" & TaxBillNo, AppWinStyle.NormalFocus)
    End Sub
#End Region
#Region "=================Control Events==========="
    Private Sub EvbMgmtHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DrawRowIndicator({GV1, GV2, GV3, GV4})
    End Sub
    Private Sub EvbMgmtHistory_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call SearchData()
        Call PopupInit()
        S_INS_YMD_FROM.Text = Now.ToString("yyyyMMdd")
        S_INS_YMD_TO.Text = Now.ToString("yyyyMMdd")
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnSearchDetail_Click(sender As Object, e As EventArgs) Handles btnSearchDetail.Click
        Call SearchDetailData()
    End Sub
    Private Sub btnReprocess_Click(sender As Object, e As EventArgs) Handles btnReprocess.Click
        Call ReprocessData_All()
    End Sub
    Private Sub GV1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Call ClearView(AppliedRangeTypes.Only, {WG2, WG3, WG4})
    End Sub
    Private Sub GV2_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GV2.FocusedRowChanged
        Call SearchHistory()
    End Sub
    Private Sub GV2_DoubleClick(sender As Object, e As EventArgs) Handles GV2.DoubleClick
        Call BillLink()
    End Sub
#End Region
End Class