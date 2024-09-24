Imports System.Drawing
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports YJIT.SC.UI
Public Class CrmAsMonthly
    Dim SearchFlag As Boolean = False
    Private bBindToDataset As Boolean = False

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    Select Case xtcAnalysis.SelectedTabPage.Name
                        Case xtpDev.Name
                            YJSql.SqlBox("WG2", "CrmAsMonthly@Search", True)
                            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                            YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                            YJSql.Params("DEV_PIC_CD", S_DEV_PIC_LIST.EditValue.ToString.Replace(" ", "").Replace(";", "','"))

                            YJSql.SqlBox("WG2_PREV", "CrmAsMonthly@SearchDetail", True)
                            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                            YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                            YJSql.Params("DEV_PIC_CD", S_DEV_PIC_LIST.EditValue.ToString.Replace(" ", "").Replace(";", "','"))

                            Dim FocusRow As Integer = GV1.FocusedRowHandle
                            Dim WorkType As String = GV1.GetRowCellValue(FocusRow, "WORK_TYPE").ToString
                            Dim NewDev As String = GV1.GetRowCellValue(FocusRow, "NEW_DEV").ToString
                            Dim FuncInpr As String = GV1.GetRowCellValue(FocusRow, "FUNC_INPR").ToString
                            Dim ErrCorr As String = GV1.GetRowCellValue(FocusRow, "ERR_CORR").ToString
                            Dim Etc As String = GV1.GetRowCellValue(FocusRow, "ETC").ToString
                            Dim Summ As String = GV1.GetRowCellValue(FocusRow, "SUMM").ToString
                            Dim Ratio As String = GV1.GetRowCellValue(FocusRow, "RATIO").ToString
                            YJSql.Params("WORK_TYPE", WorkType)
                            YJSql.Params("NEW_DEV", NewDev)
                            YJSql.Params("FUNC_INPR", FuncInpr)
                            YJSql.Params("ERR_CORR", ErrCorr)
                            YJSql.Params("ETC", Etc)
                            YJSql.Params("SUMM", Summ)
                            YJSql.Params("RATIO", Ratio)
                    End Select
                Case "CrmUserInfo".ToUpper
                    YJSql.SqlBox("CrmUserInfo", "CrmAsMgtDev@CrmUserInfo", True)
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()

    End Sub

    Public Sub SearchData()
        Try
            If SearchFlag = True Then Exit Sub
            SearchFlag = True

            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")
            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsMonthly", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {WG2, WG2_PREV})
                    Me.BindToDataset(dsRet, "Data")

                    For i As Integer = 0 To dsRet.Tables("Data.WG2").Rows.Count - 1
                        Dim minRatio As Integer = Integer.MaxValue
                        Dim maxRatio As Integer = Integer.MinValue
                        Dim dr As DataRow = dsRet.Tables("Data.WG2").Rows(i)

                        Dim ratioValue As Integer = dr("RATIO") 'Convert.ToInt32(dr("RATIO"))

                        If ratioValue < minRatio Then
                            minRatio = ratioValue
                        End If

                        If ratioValue > maxRatio Then
                            maxRatio = ratioValue
                        End If

                        Dim totalRatio As Integer = GV2.Columns("RATIO").SummaryItem.SummaryValue 'Convert.ToInt32(GV2.Columns("RATIO").SummaryItem.SummaryValue)

                        If totalRatio < 100 Then
                            Dim finalMin As Integer = minRatio + (100 - totalRatio)
                            dr("RATIO") = finalMin
                        ElseIf totalRatio > 100 Then
                            Dim finalMax As Integer = maxRatio - (totalRatio - 100)
                            dr("RATIO") = finalMax
                        End If
                    Next
                    '==================
                    Me.DataState = UI.DataStates.Retrieved

                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG2, WG2_PREV})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    Call ClearView(AppliedRangeTypes.Only, {WG2, WG2_PREV})
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            SearchFlag = False
        End Try
    End Sub

    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(S_FM_YMD.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = S_FM_YMD
                ErrMsg &= "완료일자는 필수입니다."
            ElseIf S_FM_YMD.Text.Length <> 6 Then
                If ErrControl Is Nothing Then ErrControl = S_FM_YMD
                ErrMsg &= "완료일자가 잘못되었습니다."
            End If

            If String.IsNullOrEmpty(S_DEV_PIC_LIST.Text) Then
                If ErrControl Is Nothing Then ErrControl = S_DEV_PIC_LIST
                ErrMsg &= "담당자를 선택해주세요"
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

    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG2_Excel", "&Excel Export", True)
        PopUp.PopUpInit(Me, WG2)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG2_PREV_Excel", "&Excel Export", True)
        PopUp.PopUpInit(Me, WG2_PREV)
    End Sub

    Private Sub SetDefault()
        S_FM_YMD.Text = DateAdd(DateInterval.Day, -31, Now).ToString("yyyyMM")
        S_DEPT_CD.SelectedValue = ClientSessionInfo.OrganizationCode
    End Sub

    Private Sub CrmAsMonthly_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call SetDefault()
        Call SetDevPicList()
        Call GridFunc.SetGridViewStyle(GV1)
    End Sub
    Private Sub CrmAsMonthly_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call PopUpInit()
        SaveControlValues(Me, {S_DEPT_CD, S_DEV_PIC_LIST})
        If GV1.RowCount < 1 Then
            Wg1AddRow()
        End If
        Call SetWorkType()
    End Sub

    Private Sub SetDevPicList()
        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        Dim bindingSourceProduct = New BindingSource()
        bindingSourceProduct = New BindingSource()
        bindingSourceProduct.DataSource = dt.Copy
        S_DEV_PIC_LIST.Properties.DataSource = bindingSourceProduct.DataSource
        S_DEV_PIC_LIST.Properties.ValueMember = "CODE"
        S_DEV_PIC_LIST.Properties.DisplayMember = "NAME"
        S_DEV_PIC_LIST.Properties.NullText = String.Empty
        S_DEV_PIC_LIST.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
        S_DEV_PIC_LIST.Properties.SeparatorChar = ";"

        If Not S_DEPT_CD.SelectedValue Is Nothing Then
            If Not String.IsNullOrEmpty(S_DEPT_CD.SelectedValue) Then
                Call SetDevPicList(S_DEV_PIC_LIST, S_DEPT_CD.SelectedValue)
            End If
        End If
    End Sub

    Private Sub S_FM_YMD_TextChanged(sender As Object, e As EventArgs) Handles S_FM_YMD.TextChanged
        Try
            SetWorkType()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub SetWorkType()
        Try
            If Not String.IsNullOrEmpty(S_FM_YMD.Text) AndAlso S_FM_YMD.Text.Length = 6 Then
                Dim year As Integer = S_FM_YMD.Text.Substring(0, 4)
                Dim month As Integer = S_FM_YMD.Text.Substring(4, 2)

                If month < 1 OrElse month > 12 Then
                    MsgBoxLocalized("완료일자가 잘못되었습니다.")
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    Wg1AddRow()
                    S_FM_YMD.Clear()
                    S_FM_YMD.Focus()
                    Exit Sub
                ElseIf month = 1 Then
                    year -= 1
                    month = 12
                ElseIf month = 12 Then
                    year += 1
                    month = 1
                Else
                    month -= 1
                End If
                Dim newWorkType As String = year & "-" & If(month < 10, "0" & month, month)

                If GV1.RowCount > 0 Then
                    GV1.SetRowCellValue(0, "WORK_TYPE", newWorkType)
                End If
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub S_DEPT_CD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_DEPT_CD.SelectedIndexChanged
        Call SetDevPicList(S_DEV_PIC_LIST, S_DEPT_CD.SelectedValue)
    End Sub
    Private Sub SetDevPicList(ByVal sender As Object, ByVal Dept_Cd As String)
        Dim dtCrmUserInfo As DataTable = Nothing
        If IsNothing(dtCrmUserInfo) Then
            Dim dsRet As DataSet = GetConvertToDataSet("CrmUserInfo")
            Try
                dsRet = MethodCallEx(Me, "YJIT.Biz.YJQuery", "Search", {dsRet})
            Catch ex As Exception
                MsgBoxLocalized(ex.Message & " (SetDevPicList)")
            End Try
            If dsRet.Tables.Contains("Data.CrmUserInfo") Then
                dtCrmUserInfo = dsRet.Tables("Data.CrmUserInfo").Copy
            End If
        End If
        If IsNothing(dtCrmUserInfo) Then Exit Sub
        If String.IsNullOrEmpty(Dept_Cd) Then Exit Sub

        Dim dt As New DataTable
        dt.Columns.Add("CODE")
        dt.Columns.Add("NAME")
        Try
            Dim Drs() As DataRow
            If Dept_Cd = "ALL" Then
                Drs = dtCrmUserInfo.Select("1=1", "DEPT_CD ASC,LOC_NM ASC")
            Else
                If Dept_Cd.Contains(";") Then
                    Drs = dtCrmUserInfo.Select("DEPT_CD IN ('" & Dept_Cd.Replace(" ", "").Replace(";", "','") & "')", "LOC_NM ASC")
                Else
                    Drs = dtCrmUserInfo.Select("DEPT_CD = '" & Dept_Cd & "'", "LOC_NM ASC")
                End If
            End If
            If Drs.Length > 0 Then
                dt = Drs.CopyToDataTable
                dt.Columns("USR_ID").ColumnName = "CODE"
                dt.Columns("LOC_NM").ColumnName = "NAME"
            End If

            If TypeName(sender) = "CheckedComboBoxEdit" Then
                sender.Properties.DataSource = dt.Copy

                S_DEV_PIC_LIST.EditValue = String.Empty
            Else
                Dim dr As DataRow = dt.NewRow
                dr("CODE") = ""
                dr("NAME") = ""
                dt.Rows.InsertAt(dr, 0)
                sender.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Wg1AddRow()
        If GV1.RowCount = 0 Then Call setGridAddRow(WG1)
        WG1.Focus()
        GV1.FocusedColumn = GV1.Columns("NEW_DEV")
    End Sub

    Private Sub setGridAddRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        If obj.Visible = False And obj.Enabled = False Then Exit Sub
        Dim GvAddRow As New DataTable
        Dim dr As DataRow
        GvAddRow.Columns.Add("Key")
        GvAddRow.Columns.Add("Sender")
        GvAddRow.Columns.Add("Action", GetType(Action))
        GvAddRow.Rows.Add()
        dr = GvAddRow.Rows(0)

        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_AddRow"
        dr("Action") = Action.Addrow

        obj.AddRow()
        SetGridAddRowDefault(GV1)
    End Sub

    Private Sub SetGridAddRowDefault(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            bBindToDataset = True
            Select Case view.Name
                Case "GV1"
                    view.SetRowCellValue(view.FocusedRowHandle, "NEW_DEV", 0)
                    view.SetRowCellValue(view.FocusedRowHandle, "FUNC_INPR", 0)
                    view.SetRowCellValue(view.FocusedRowHandle, "ERR_CORR", 0)
                    view.SetRowCellValue(view.FocusedRowHandle, "ETC", 0)
                    view.SetRowCellValue(view.FocusedRowHandle, "SUMM", 0)
                    view.SetRowCellValue(view.FocusedRowHandle, "RATIO", 0)
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            bBindToDataset = False
        End Try
    End Sub
    Private Sub SetGridColumnDefault(ByVal View As GridView, ByVal col As String)
        Try
            bBindToDataset = True
            Select Case View.Name
                Case "GV1"
                    If col = "NEW_DEV" Then
                        View.SetRowCellValue(View.FocusedRowHandle, "NEW_DEV", 0)
                    ElseIf col = "FUNC_INPR" Then
                        View.SetRowCellValue(View.FocusedRowHandle, "FUNC_INPR", 0)
                    ElseIf col = "ERR_CORR" Then
                        View.SetRowCellValue(View.FocusedRowHandle, "ERR_CORR", 0)
                    ElseIf col = "ETC" Then
                        View.SetRowCellValue(View.FocusedRowHandle, "ETC", 0)
                    ElseIf col = "RATIO" Then
                        View.SetRowCellValue(View.FocusedRowHandle, "RATIO", 0)
                    End If
            End Select

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            bBindToDataset = False
        End Try
    End Sub
    Private Sub GV1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged, GV2.CellValueChanged
        Try
            Select Case e.Column.FieldName
                Case "WORK_TYPE"
                    Call ClearView(AppliedRangeTypes.Only, {WG2, WG2_PREV})
                    SetGridAddRowDefault(GV1)
                Case "NEW_DEV", "FUNC_INPR", "ERR_CORR", "ETC", "RATIO"
                    Try
                        Dim newdev As Integer = If(IsDBNull(GV1.GetRowCellValue(e.RowHandle, "NEW_DEV")), 0, Convert.ToInt32(GV1.GetRowCellValue(e.RowHandle, "NEW_DEV")))
                        Dim funcinpr As Integer = If(IsDBNull(GV1.GetRowCellValue(e.RowHandle, "FUNC_INPR")), 0, Convert.ToInt32(GV1.GetRowCellValue(e.RowHandle, "FUNC_INPR")))
                        Dim errcorr As Integer = If(IsDBNull(GV1.GetRowCellValue(e.RowHandle, "ERR_CORR")), 0, Convert.ToInt32(GV1.GetRowCellValue(e.RowHandle, "ERR_CORR")))
                        Dim etc As Integer = If(IsDBNull(GV1.GetRowCellValue(e.RowHandle, "ETC")), 0, Convert.ToInt32(GV1.GetRowCellValue(e.RowHandle, "ETC")))
                        Dim summ As Integer = newdev + funcinpr + errcorr + etc
                        Dim ratio As Integer = If(IsDBNull(GV1.GetRowCellValue(e.RowHandle, "RATIO")), 0, Convert.ToInt32(GV1.GetRowCellValue(e.RowHandle, "RATIO")))
                        GV1.SetRowCellValue(e.RowHandle, "SUMM", summ)
                    Catch ex As Exception
                        SetGridColumnDefault(GV1, e.Column.FieldName)
                    End Try
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub S_DEPT_CD_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles S_DEPT_CD.PreviewKeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If GV1.RowCount > 0 Then
                WG1.Focus()
                GV1.FocusedColumn = GV1.Columns("NEW_DEV")
            End If
        End If
    End Sub

    Private Sub WG1_EditorKeyDown(sender As Object, e As KeyEventArgs) Handles WG1.EditorKeyDown
        If GV1.FocusedColumn.FieldName = "RATIO" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                S_DEV_PIC_LIST.Focus()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub S_DEV_PIC_LIST_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles S_DEV_PIC_LIST.PreviewKeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            btnSearch.Focus()
        End If
    End Sub
End Class