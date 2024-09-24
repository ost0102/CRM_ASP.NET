Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Public Class CrmETaxList

    Private conn As OleDbConnection

#Region "=================Data logic actions==========="

    Public Sub Search()
        'If the sql lenght is long enough, It cannot be parsed into xml. So first we delete sql and than pass the dataset
        Dim ds As DataSet = Me.ConvertToDataset
        'ds.Tables.Remove("WG1")
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmETaxList", "Search", ds, AddressOf search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG2})
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")
            GV2.BestFitColumns()

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub Execute()

        Dim dsResult As DataSet

        If MsgBoxLocalized("Do you want to execute queries?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        GV2.FocusedRowHandle = -1
        'If the sql lenght is long enough, It cannot be parsed into xml. So first we delete sql and than pass the dataset

        For i As Integer = 0 To GV2.RowCount - 1
            If GV2.GetDataRow(i).RowState <> DataRowState.Unchanged Then
                GV2.GetDataRow(i).AcceptChanges()
            End If
            GV2.GetDataRow(i).SetAdded() 'set add to all rows
        Next

        Dim ds As DataSet = Me.ConvertToDataset
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmETaxList", "Execute", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

        Dim dtLog As DataTable = dsResult.Tables("Data.Log")
        For Each logRow In dtLog.Rows
            Dim domain As String = logRow("DOMAIN").ToString
            Dim result As String = logRow("RESULT").ToString
            Dim ERROR_YN As String = logRow("ERROR_YN").ToString.ToUpper

            For i As Integer = 0 To GV2.RowCount - 1
                If GV2.GetRowCellValue(i, "DOMAIN").ToString = domain Then
                    GV2.SetRowCellValue(i, "RESULT", result)
                    GV2.SetRowCellValue(i, "ERROR_YN", ERROR_YN)
                End If
            Next
        Next

        MsgBoxLocalized(dr("TrxMsg"))

    End Sub
    Private Sub NewData()
        SEND_YYMM.Text = Now.ToString("yyyyMM")
        S_SVC_CD.SelectedValue = "E"
    End Sub
    Private Sub PopupInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.EventKey, "GV2_SelectAll", "&Select All")
        PopUp.ItemAdd(Action.Excel, "ExportExcel", "Export Excel", True)
        PopUp.PopUpInit(Me, WG2)

    End Sub

    Public Sub GridInit()
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim dt As DataTable = Nothing

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C01")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV2.Columns("SVC_CD").ColumnEdit = editorCombo

    End Sub

#End Region

#Region "=================Control Events==========="

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call Search()
    End Sub

    Private Sub btnExecute_Click(sender As System.Object, e As System.EventArgs) Handles btnExecute.Click
        Call Execute()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub

    Private Sub SysDBMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call DrawRowIndicator(GV2)
        Call GridInit()
        SEND_YYMM.Text = Now.ToString("yyyyMM")
        Call Search()
    End Sub

    Private Sub GV2_RowStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)
        If GV2.RowCount > 0 Then
            If Not IsNothing(GV2.GetRowCellValue(e.RowHandle, "ERROR_YN")) Then
                If GV2.GetRowCellValue(e.RowHandle, "ERROR_YN").ToString.ToUpper.Trim = "TRUE" Then
                    e.Appearance.BackColor = Color.Yellow
                End If
            End If
        End If
    End Sub

    Private Sub CrmETaxList_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        PopupInit()
    End Sub
#End Region

End Class