Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Public Class SysDBChk

    Private conn As OleDbConnection

#Region "=================Data logic actions==========="
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)

        Dim Key As String = dr("Key")

        Select Case dr("Action")
            Case Action.EventKey
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
            'Select All
            For i As Integer = 0 To GV2.RowCount - 1
                GV2.SetRowCellValue(i, "CHK", "Y")
            Next
        Else
            'Deselect All
            For i As Integer = 0 To GV2.RowCount - 1
                GV2.SetRowCellValue(i, "CHK", "N")
            Next
        End If
    End Sub
    Public Sub SearchApplyYn(ByVal SqlId As String, ByVal APPLY_SOURCE As String, ByVal DB_LINK As String)

        'If the sql lenght is long enough, It cannot be parsed into xml. So first we delete sql and than pass the dataset
        Dim ds As DataSet = Me.ConvertToDataset
        Dim dt As DataTable = ds.Tables("WG1").Copy
        dt.Columns.Remove("SQL_STR")
        dt.Columns.Add("SQL_STR")
        dt.TableName = "WG1NEW"
        ds.Tables.Remove("WG1")
        ds.Tables.Add(dt)

        Dim params() As Object = {ds, SqlId, APPLY_SOURCE, DB_LINK}
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.SysDBChk", "SearchApplyYn", params, AddressOf searchYnOnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub searchYnOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG2})
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If

            Me.BindToDataset(ds, "Data")
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub
    Public Sub Search()
        'If the sql lenght is long enough, It cannot be parsed into xml. So first we delete sql and than pass the dataset
        Dim ds As DataSet = Me.ConvertToDataset
        ds.Tables.Remove("WG1")
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.SysDBChk", "Search", ds, AddressOf search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG1, WG2, WG3})
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub Execute()

        Dim dsResult As DataSet

        Call ClearView(AppliedRangeTypes.Only, {WG3})

        If MsgBoxLocalized("Do you want to execute queries?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        GV2.FocusedRowHandle = -1
        'If the sql lenght is long enough, It cannot be parsed into xml. So first we delete sql and than pass the dataset
        Dim ds As DataSet = Me.ConvertToDataset
        Dim dt As DataTable = ds.Tables("WG1").Copy
        dt.Columns.Remove("SQL_STR")
        dt.Columns.Add("SQL_STR")
        dt.TableName = "WG1NEW"
        ds.Tables.Remove("WG1")
        ds.Tables.Add(dt)

        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysDBChk", "Execute", ds)
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
    Public Sub Execute2()

        Dim dsResult As DataSet

        Call ClearView(AppliedRangeTypes.Only, {WG3})

        If MsgBoxLocalized("Do you want to execute queries?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        GV2.FocusedRowHandle = -1
        'If the sql lenght is long enough, It cannot be parsed into xml. So first we delete sql and than pass the dataset
        Dim ds As DataSet = Me.ConvertToDataset
        Dim dt As DataTable = ds.Tables("WG1").Copy
        dt.Columns.Remove("SQL_STR")
        dt.Columns.Add("SQL_STR")
        dt.TableName = "WG1NEW"
        ds.Tables.Remove("WG1")
        ds.Tables.Add(dt)

        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysDBChk", "ExecuteString", ds)
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

        WG3.DataSource = dsResult.Tables("Data.WG3")

        MsgBoxLocalized(dr("TrxMsg"))

    End Sub
    Public Sub Save()
        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset

        Dim dsResult As DataSet
        Dim dr As DataRow

        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysDBChk", "Save", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(dsResult, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))

    End Sub
    Private Sub NewData()
        ClearView(AppliedRangeTypes.Only, {SQL_ID, USE_YN, TITLE, RMK, SQL_STR})
        USE_YN.SelectedValue = "Y"
    End Sub
    Private Sub PopupInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.EventKey, "GV2_SelectAll", "&Select All")
        PopUp.ItemAdd(Action.Excel, "ExportExcel", "Export Excel", True)
        PopUp.PopUpInit(Me, WG2)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "ExportExcel", "Export Excel", True)
        PopUp.PopUpInit(Me, WG3)

    End Sub
#End Region

#Region "=================Control Events==========="
    Private Sub SysDBMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call DrawRowIndicator(GV1)
        Call DrawRowIndicator(GV2)
    End Sub
    Private Sub SysDBChk_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call PopupInit()
    End Sub
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call Search()
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call Save()
    End Sub
    Private Sub btnExecute_Click(sender As System.Object, e As System.EventArgs) Handles btnExecute.Click
        Call Execute()
    End Sub
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub
    Private Sub GV1_Click(sender As System.Object, e As System.EventArgs) Handles GV1.Click
        Dim SqlId As String = ""
        Dim APPLY_SOURCE As String = ""
        Dim DB_LINK As String = ""
        If GV1.RowCount > 0 Then
            SQL_STR.Text = GV1.GetRowCellValue(GV1.FocusedRowHandle, "SQL_STR").ToString
            SqlId = GV1.GetRowCellValue(GV1.FocusedRowHandle, "SQL_ID").ToString
            APPLY_SOURCE = GV1.GetRowCellValue(GV1.FocusedRowHandle, "APPLY_SOURCE").ToString
            DB_LINK = GV1.GetRowCellValue(GV1.FocusedRowHandle, "DB_LINK").ToString
            Call SearchApplyYn(SqlId, APPLY_SOURCE, DB_LINK)

            GV3.Columns.Clear()
        End If

    End Sub
    Private Sub GV2_RowStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GV2.RowStyle
        If GV2.RowCount > 0 Then
            If Not IsNothing(GV2.GetRowCellValue(e.RowHandle, "ERROR_YN")) Then
                If GV2.GetRowCellValue(e.RowHandle, "ERROR_YN").ToString.ToUpper.Trim = "TRUE" Then
                    e.Appearance.BackColor = Color.Yellow
                End If
            End If
        End If
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        GV1.FocusedColumn = GV1.Columns("SQL_ID")
        GV1.FocusedColumn = GV1.Columns("CHK")
    End Sub
    Private Sub RepositoryItemCheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit2.CheckedChanged
        GV2.FocusedColumn = GV2.Columns("DB_IP")
        GV2.FocusedColumn = GV2.Columns("CHK")
    End Sub


    Private Sub S_APPLY_SOURCE_SelectedValueChanged(sender As Object, e As EventArgs) Handles S_APPLY_SOURCE.SelectedValueChanged
        Select Case S_APPLY_SOURCE.SelectedValue
            Case "07", "10"
                S_DB_LINK.SelectedValue = "ELVIS_PLUS"
            Case Else
                S_DB_LINK.SelectedValue = "ELVIS"
        End Select
    End Sub

    Private Sub btnExecute2_Click(sender As Object, e As EventArgs) Handles btnExecute2.Click
        Call Execute2()
    End Sub


#End Region

End Class