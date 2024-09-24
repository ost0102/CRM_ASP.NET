Imports System.Drawing
Imports YJIT.SC.UI

Public Class ComLogMgt

#Region "=================Data logic actions==========="

    Private Sub SetGridViewSequence(ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Dim rowIndex As Integer = e.RowHandle

        e.Info.DisplayText = "No"

        If rowIndex >= 0 Then
            rowIndex += 1
            e.Info.DisplayText = rowIndex.ToString()
        End If

        e.Info.ImageIndex = -1
    End Sub


    Public Sub SearchData()
        Try

            CType(WG2.DataSource, DataTable).Rows.Clear()

            If S_COL_NM.EditValue Is Nothing Then S_COL_NM.EditValue = ""

            Dim params() As Object = {HBL_NO.Text, S_COL_NM.EditValue}
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.ComLogMgt", "Search", params, AddressOf search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG1})
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If

            Me.BindToDataset(ds, "Data")
            Call SearchDetail()
            Me.DataState = UI.DataStates.Retrieved
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SearchDetail()
        Try
            If GV1.RowCount = 0 Then
                Exit Sub
            End If
            Dim params() As String = {GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO"), GV1.GetRowCellValue(GV1.FocusedRowHandle, "CHANGE_USR"), GV1.GetRowCellValue(GV1.FocusedRowHandle, "CHANGE_DATE"), S_COL_NM.EditValue}
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.ComLogMgt", "SearchDetail", params, AddressOf searchDetail_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub searchDetail_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)

        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")

            Me.DataState = UI.DataStates.Retrieved
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Private Sub ColumnLookup()
        Dim ds As DataSet
        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.ComLogMgt", "SearchColumn", {HBL_NO.Text})
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


        ' Column Lookup : S_COLUMN
        Dim bindingSourceProduct = New BindingSource()
        'bindingSourceProduct.DataSource = Common.CodeServiceAPI.GetCodeList("OfficeLookup", searchParams, dataParams)

        bindingSourceProduct.DataSource = ds.Tables("Data.S_COLUMN")
        If bindingSourceProduct.Count <> 0 Then
            S_COL_NM.Properties.DataSource = bindingSourceProduct.DataSource
            S_COL_NM.Properties.ValueMember = "CODE"
            S_COL_NM.Properties.DisplayMember = "NAME"
            S_COL_NM.Properties.NullText = String.Empty
            S_COL_NM.DataBindings.Clear()
            S_COL_NM.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
            S_COL_NM.Properties.SeparatorChar = ";"
            'S_COLUMN.CheckAll()
            'S_COLUMN.SetEditValue("")
        End If

    End Sub
#End Region

#Region "=================Control Events==========="
    Private Sub ComLogMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HBL_NO.Focus()
    End Sub

    Private Sub ComLogMgt_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Call ColumnLookup()
    End Sub

    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    
    Private Sub WG1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WG1.Click
        Call SearchDetail()
    End Sub

    Private Sub HBL_NO_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles HBL_NO.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Call SearchData()
        End If
    End Sub

    Private Sub GV1_CustomDrawRowIndicator(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GV1.CustomDrawRowIndicator
        Call SetGridViewSequence(e)
    End Sub

    Private Sub GV2_CustomDrawRowIndicator(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Call SetGridViewSequence(e)
    End Sub

#End Region


End Class