Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Public Class SysTableMgt

#Region "=================Data logic actions==========="
    Public Sub Search()
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.SysTableMgt", "Search", Me.ConvertToDataset, AddressOf Search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub Search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
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
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub SearchDetail()
        Try
            If GV1.RowCount = 0 Then Exit Sub

            Dim params() As Object = {GV1.GetFocusedRowCellValue("SQL_ID").ToString()}
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.SysTableMgt", "SearchDetail", params, AddressOf SearchDetail_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub SearchDetail2()
        Try

            Dim params() As Object = {SQL_ID.Text}
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.SysTableMgt", "SearchDetail", params, AddressOf SearchDetail_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub SearchDetail_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)

        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            ClearView(UI.AppliedRangeTypes.Except, {WG1, S_INS_YMD_FROM, S_INS_YMD_TO, S_SQL_ID, S_USR_NM, S_APPLY_SOURCE})

            Me.BindToDataset(ds, "Data")
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If

            Me.DataState = UI.DataStates.Retrieved
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub
    Public Sub Save()
        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset
        Dim dsResult As DataSet
        Dim dr As DataRow

        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysTableMgt", "Save", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(dsResult, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If
        SQL_ID.Text = dr("SqlId").ToString

        Call SearchDetail2()



    End Sub
    Private Sub NewData()
        ClearView(AppliedRangeTypes.Except, {S_INS_YMD_FROM, S_INS_YMD_TO, S_SQL_ID, S_USR_NM, WG1})
        APPLY_SOURCE.SelectedValue = "01"
    End Sub
#End Region

#Region "=================Control Events==========="
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call Search()
    End Sub
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call NewData()
        USE_YN.SelectedValue = "Y"
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call Save()
    End Sub
    Private Sub WG1_Click(sender As System.Object, e As System.EventArgs) Handles WG1.Click
        Call SearchDetail()
    End Sub
    Private Sub SysTableMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Search()
        Call DrawRowIndicator(GV1)
    End Sub
    Private Sub SQL_STR_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles SQL_STR.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.A Then
            SQL_STR.SelectAll()
        End If
    End Sub
#End Region

End Class