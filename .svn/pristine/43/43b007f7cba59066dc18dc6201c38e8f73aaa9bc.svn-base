Public Class SysHelpPopup
   
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub LoadNodeInfo(ByVal sNodeId As String)
        '////////WCF Service Call/////////
        Dim params() As String = {sNodeId}

        Dim dsResult As DataSet
        Dim drPairs As DataRow
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "GetNodeProperties", params)
        Catch ex As Exception
            MsgBoxSC(ex.Message)
            Exit Sub
        End Try

        '//////Parsing WCF returned data///////
        drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

        Me.BindToDataset(dsResult, "Data")

        If drPairs("TrxCode") <> "SUCCESS" Then
            MsgBoxSC(drPairs("TrxMsg"))
            Exit Sub
        End If

        'Locate current Node in his siblings
        For i = 0 To GV1.RowCount - 1
            If GV1.GetRowCellValue(i, "NODE_ID") = sNodeId Then
                GV1.FocusedRowHandle = i
                Exit For
            End If
        Next

    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If GV1.FocusedRowHandle <= 0 Then Exit Sub

        Dim nRow As Integer = GV1.FocusedRowHandle
        Dim sTempID As String
        Dim sTempTitle As String

        'Swapping 2 rows
        sTempID = GV1.GetRowCellValue(nRow, "NODE_ID")
        sTempTitle = GV1.GetRowCellValue(nRow, "TITLE")

        GV1.SetRowCellValue(nRow, "NODE_ID", GV1.GetRowCellValue(nRow - 1, "NODE_ID"))
        GV1.SetRowCellValue(nRow, "TITLE", GV1.GetRowCellValue(nRow - 1, "TITLE"))

        GV1.SetRowCellValue(nRow - 1, "NODE_ID", sTempID)
        GV1.SetRowCellValue(nRow - 1, "TITLE", sTempTitle)

        GV1.FocusedRowHandle = nRow - 1

    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If GV1.FocusedRowHandle < 0 OrElse GV1.FocusedRowHandle = GV1.RowCount - 1 Then Exit Sub

        Dim nRow As Integer = GV1.FocusedRowHandle
        Dim sTempID As String
        Dim sTempTitle As String

        'Swapping 2 rows
        sTempID = GV1.GetRowCellValue(nRow, "NODE_ID")
        sTempTitle = GV1.GetRowCellValue(nRow, "TITLE")

        GV1.SetRowCellValue(nRow, "NODE_ID", GV1.GetRowCellValue(nRow + 1, "NODE_ID"))
        GV1.SetRowCellValue(nRow, "TITLE", GV1.GetRowCellValue(nRow + 1, "TITLE"))

        GV1.SetRowCellValue(nRow + 1, "NODE_ID", sTempID)
        GV1.SetRowCellValue(nRow + 1, "TITLE", sTempTitle)

        GV1.FocusedRowHandle = nRow + 1
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Update title + display Seq
        For i As Integer = 0 To GV1.RowCount - 1
            If GV1.GetDataRow(i).RowState <> DataRowState.Unchanged Then
                GV1.GetDataRow(i).AcceptChanges()
            End If
            GV1.GetDataRow(i).SetAdded() 'set add to all rows
        Next

        '////////WCF Service Call/////////
        Dim params() As Object = {Me.ConvertToDataset()}

        Dim dsResult As DataSet
        Dim drPairs As DataRow
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Sys.SysHelpMgt", "UpdateNodeProperties", params)
        Catch ex As Exception
            MsgBoxSC(ex.Message)
            Exit Sub
        End Try

        '//////Parsing WCF returned data///////
        drPairs = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

        If drPairs("TrxCode") <> "SUCCESS" Then
            MsgBoxSC(drPairs("TrxMsg"))
        Else
            lblResult.Text = drPairs("TrxMsg")
        End If
    End Sub

End Class