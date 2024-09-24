Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports YJIT.SC.UI

Public Class SvrInfoLogList
#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal Type As String) As DataSet
        Dim YJSql As New YJQuery
        'Dim IsSingleSearch As Boolean = False

        Select Case Type.ToUpper
            Case "Search".ToUpper
                YJSql.SqlBox("WG1", "SvrInfoLogList@Search")
                If S_LAST_DATA_YN.SelectedValue = "Y" Then
                    '최종자료는 기간없이 조회
                Else
                    YJSql.Params("DATE_FROM", S_DATE_FROM.Text, False)
                    YJSql.Params("DATE_TO", S_DATE_TO.Text, False)
                End If
                YJSql.Blocks("IP_SEH_DIV_" & S_IP_SEH_DIV.SelectedValue, S_IP_SEH_DIV.SelectedValue)
                YJSql.Params("IP_SEH", S_IP_SEH.Text)
                YJSql.Params("LAST_DATA_" & S_LAST_DATA_YN.SelectedValue, S_LAST_DATA_YN.SelectedValue)
                YJSql.Params("DATA_DIV", S_DATA_DIV.SelectedValue)
                '20230829 / 김성은, 김태룡 조회조건 및 그리드 변경 / YJITS2023080230
                YJSql.Params("TIME_FROM", S_TIME_FROM.Text)
                YJSql.Params("TIME_TO", S_TIME_TO.Text)
            Case "SearchDetail".ToUpper
                YJSql.SqlBox("WG2", "SvrInfoLogList@SearchDetail")
                YJSql.Params("SERVER_IP", GV1.GetRowCellValue(GV1.FocusedRowHandle, "SERVER_IP").ToString, False)
                YJSql.Params("DATA_DIV", GV1.GetRowCellValue(GV1.FocusedRowHandle, "DATA_DIV").ToString, False)
                YJSql.Params("CHECK_YMD", GV1.GetRowCellValue(GV1.FocusedRowHandle, "CHECK_YMD").ToString.Replace("-", ""), False)
                YJSql.Params("CHECK_HM", GV1.GetRowCellValue(GV1.FocusedRowHandle, "CHECK_HM").ToString.Replace(":", ""), False)
            Case "SearchActive".ToUpper
                YJSql.SqlBox("MAIN", "SvrInfoLogList@SearchActive")
                YJSql.Params("SERVER_IP", GV1.GetRowCellValue(GV1.FocusedRowHandle, "SERVER_IP").ToString, False)
                YJSql.Params("DATA_DIV", GV1.GetRowCellValue(GV1.FocusedRowHandle, "DATA_DIV").ToString, False)
                YJSql.Params("CHECK_YMD", GV1.GetRowCellValue(GV1.FocusedRowHandle, "CHECK_YMD").ToString.Replace("-", ""), False)
                YJSql.Params("CHECK_HM", GV1.GetRowCellValue(GV1.FocusedRowHandle, "CHECK_HM").ToString.Replace(":", ""), False)
                YJSql.Params("TABLESPACE", GV2.GetRowCellValue(GV2.FocusedRowHandle, "TABLESPACE").ToString, False)
        End Select
        Return YJSql.DataSet
    End Function
#End Region

#Region "=================Client Function==========="
    Private Sub InitPage()
        S_LAST_DATA_YN.SelectedValue = "Y"
        S_DATA_DIV.SelectedValue = "SC"
        S_DATE_FROM.Text = Now.ToString("yyyyMMdd")
        S_DATE_TO.Text = Now.ToString("yyyyMMdd")
    End Sub
    Private Sub InitGrid()
        Call DrawRowIndicator({GV1, GV2})

        GV1.Columns("DATA_DIV").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:SVR01, NameType:")
    End Sub

    '20230829 / 김성은, 김태룡 조회조건 및 그리드 변경 / YJITS2023080230
    Public Sub PopupInit()
        Dim Popup As New PopupBase

        Popup = New PopupBase
        Popup.ItemAdd(Action.Excel, "WG1_ExportExcel", "&Export Excel")
        Popup.PopUpInit(Me, WG1)
    End Sub
#End Region

#Region "=================Data logic actions==========="
    Private Sub SearchData()

        If SearchValidate() = False Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("Search")
        ds = Func.MethodCall(Me, "YJIT.Biz.SvrInfoLogList", "Search", ds)

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
            If S_LAST_DATA_YN.SelectedValue = "Y" Then
                '최종자료는 기간없이 조회
            Else
                If String.IsNullOrEmpty(S_DATE_FROM.Text) OrElse String.IsNullOrEmpty(S_DATE_TO.Text) Then
                    If String.IsNullOrEmpty(S_DATE_FROM.Text) Then
                        ErrControl = S_DATE_FROM
                    Else
                        ErrControl = S_DATE_TO
                    End If
                    ErrMsg = Func.Msg(Me, "{0}을 입력해주세요.", lbl_S_DATE.Text) & vbNewLine
                End If
                '20230828 / 김성은, 김태룡 조회조건 및 그리드 변경 / YJITS2023080230
                If String.IsNullOrEmpty(S_IP_SEH.Text) Then
                    If ErrControl Is Nothing Then ErrControl = S_IP_SEH
                    ErrMsg = Func.Msg(Me, "검색조건 키워드를 입력해주세요.")
                End If
            End If

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
    Private Sub SearchDetailData()
        If GV1.RowCount = 0 Then Exit Sub
        If GV1.FocusedRowHandle < 0 Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SearchDetail")
        ds = Func.MethodCall(Me, "YJIT.Biz.SvrInfoLogList", "Search", ds)
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode").ToString
            Case "Y", "N"
                ClearView(AppliedRangeTypes.Only, {WG2, USER_ACTIVE_INFO})
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.None
            Case "E"
                MsgBoxLocalized(dr("TrxMsg").ToString)
        End Select
    End Sub
    Private Sub SearchActiveData()
        If GV1.RowCount = 0 Then Exit Sub
        If GV1.FocusedRowHandle < 0 Then Exit Sub
        If GV2.RowCount = 0 Then Exit Sub
        If GV2.FocusedRowHandle < 0 Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SearchActive")
        ds = Func.MethodCall(Me, "YJIT.Biz.SvrInfoLogList", "Search", ds)
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode").ToString
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.None
            Case "E"
                MsgBoxLocalized(dr("TrxMsg").ToString)
        End Select
    End Sub
#End Region

#Region "=================Control Events==========="
    Private Sub SvrInfoLogList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitPage()
        Call InitGrid()
    End Sub
    Private Sub SvrInfoLogList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '20230829 / 김성은, 김태룡 조회조건 및 그리드 변경 / YJITS2023080230
        Call PopupInit()
        If S_DATA_DIV.Enabled = True Then
            S_DATA_DIV.Focus()
        Else S_DATA_DIV.Enabled = False
            S_LAST_DATA_YN.Focus()
        End If
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub WG1_Click(sender As Object, e As EventArgs) Handles WG1.Click
        Try
            If GV1.RowCount = 0 Then Exit Sub
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
            If GV1.RowCount = 0 Then Exit Sub
            If GV1.IsValidRowHandle(e.FocusedRowHandle) = False Then Exit Sub

            If e.PrevFocusedRowHandle >= 0 Then bGV1_FocusedRowChanged = True

            Call SearchDetailData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub GV1_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV1.CustomColumnDisplayText
        Try
            If e.ListSourceRowIndex = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then Exit Sub

            Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = TryCast(sender, DevExpress.XtraGrid.Views.Base.ColumnView)

            If e.Column.FieldName = "CPU_USE_RATE" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CPU_USE_RATE").ToString) Then
                    e.DisplayText = String.Format("{0}%", view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CPU_USE_RATE").ToString)
                End If
            ElseIf e.Column.FieldName = "RAM_USE_RATE" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "RAM_USE_RATE").ToString) Then
                    e.DisplayText = String.Format("{0}%", view.GetListSourceRowCellValue(e.ListSourceRowIndex, "RAM_USE_RATE").ToString)
                End If
            ElseIf e.Column.FieldName = "HDD_1_USE_RATE" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_1_USE_RATE").ToString) Then
                    e.DisplayText = String.Format("{0}%", view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_1_USE_RATE").ToString)
                End If
            ElseIf e.Column.FieldName = "HDD_2_USE_RATE" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_2_USE_RATE").ToString) Then
                    e.DisplayText = String.Format("{0}%", view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_2_USE_RATE").ToString)
                End If
            ElseIf e.Column.FieldName = "HDD_3_USE_RATE" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_3_USE_RATE").ToString) Then
                    e.DisplayText = String.Format("{0}%", view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_3_USE_RATE").ToString)
                End If
                '20230829 / 김성은, 김태룡 조회조건 및 그리드 변경 / YJITS2023080230
            ElseIf e.Column.FieldName = "HDD_4_USE_RATE" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_4_USE_RATE").ToString) Then
                    e.DisplayText = String.Format("{0}%", view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_4_USE_RATE").ToString)
                End If
            ElseIf e.Column.FieldName = "HDD_5_USE_RATE" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_5_USE_RATE").ToString) Then
                    e.DisplayText = String.Format("{0}%", view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_5_USE_RATE").ToString)
                End If
            ElseIf e.Column.FieldName = "HDD_6_USE_RATE" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_6_USE_RATE").ToString) Then
                    e.DisplayText = String.Format("{0}%", view.GetListSourceRowCellValue(e.ListSourceRowIndex, "HDD_6_USE_RATE").ToString)
                End If
            End If

        Catch ex As Exception
            MsgBoxLocalized(String.Format("{0} (GV1_CustomColumnDisplayText", ex.Message))
        End Try
    End Sub
    Private Sub GV1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GV1.RowCellStyle
        Select Case e.Column.FieldName.ToUpper
            Case "CPU_INFO", "CPU_CORE", "CPU_USE_RATE", "HDD_INFO", "HDD_2_TOTAL", "HDD_2_USE", "HDD_2_USE_RATE", "DB_PROC_USE", "DB_PROC_MAX_USE", "DB_PROC_LIMIT"
                e.Appearance.BackColor = Color.FromArgb(230, 230, 230)
        End Select
    End Sub
    Private Sub WG2_Click(sender As Object, e As EventArgs) Handles WG2.Click
        Try
            If GV2.RowCount = 0 Then Exit Sub
            If bGV2_FocusedRowChanged = True Then Exit Sub

            Call SearchActiveData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            bGV2_FocusedRowChanged = False
        End Try
    End Sub

    Dim bGV2_FocusedRowChanged As Boolean = False
    Private Sub GV2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV2.FocusedRowChanged
        Try
            If GV2.RowCount = 0 Then Exit Sub

            If GV2.IsValidRowHandle(e.FocusedRowHandle) = False Then Exit Sub

            If e.PrevFocusedRowHandle >= 0 Then bGV2_FocusedRowChanged = True

            Call SearchActiveData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub GV2_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV2.CustomColumnDisplayText
        Try
            If e.ListSourceRowIndex = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then Exit Sub

            Dim view As DevExpress.XtraGrid.Views.Base.ColumnView = TryCast(sender, DevExpress.XtraGrid.Views.Base.ColumnView)

            If e.Column.FieldName = "USED_RATE" Then
                If Not String.IsNullOrEmpty(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "USED_RATE").ToString) Then
                    e.DisplayText = String.Format("{0}%", view.GetListSourceRowCellValue(e.ListSourceRowIndex, "USED_RATE").ToString)
                End If
            End If
        Catch ex As Exception
            MsgBoxLocalized(String.Format("{0} (GV2_CustomColumnDisplayText", ex.Message))
        End Try
    End Sub

    '20230828 / 김성은, 김태룡 조회조건 및 그리드 변경 / YJITS2023080230
    Private Sub S_LAST_DATA_YN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S_LAST_DATA_YN.SelectedIndexChanged
        S_DATE_FROM.Enabled = True
        S_DATE_TO.Enabled = True
        S_TIME_FROM.Enabled = True
        S_TIME_TO.Enabled = True

        If S_LAST_DATA_YN.SelectedValue = "Y" Then
            S_DATE_FROM.Enabled = False
            S_DATE_TO.Enabled = False
            S_TIME_FROM.Enabled = False
            S_TIME_TO.Enabled = False
            S_TIME_FROM.Text = String.Empty
            S_TIME_TO.Text = String.Empty
        End If

        S_LAST_DATA_YN.NextFocus = "S_DATE_FROM"
        If S_DATE_FROM.Enabled = False Then
            S_LAST_DATA_YN.NextFocus = "S_IP_SEH_DIV"
        End If
    End Sub

    Private Sub btnRPAInfo_Click(sender As Object, e As EventArgs) Handles btnRPAInfo.Click
        Dim ds As DataSet
        ds = Func.MethodCall(Me, "YJIT.Biz.SvrInfoLogList", "SearchRPAInfo", {"CKPA"})

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
#End Region
End Class