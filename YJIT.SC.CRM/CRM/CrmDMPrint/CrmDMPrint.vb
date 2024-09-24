Imports YJIT.SC.UI
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraGrid.Views.Grid

Public Class CrmDMPrint

#Region "=================Data logic actions==========="
    Public Sub SearchData()
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmDMPrint", "Search", Me.ConvertToDataset, AddressOf SearchOnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub SearchOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again !")
            End If

            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Search", MessageBoxIcon.Warning)
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")

            Me.DataState = UI.DataStates.Retrieved

            GV1.BestFitColumns()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Private Sub PrintData()
        Try
            If GV1.RowCount = 0 Then
                Exit Sub
            End If
            Dim ds As DataSet = Me.ConvertToDataset
            Dim rpt As New DevExpress.XtraReports.UI.XtraReport
            Dim RptParameters As New Dictionary(Of String, Object)

            Dim dt As DataTable
            Dim dtLeft As DataTable
            Dim dtRight As DataTable
            Dim dtTemp As DataTable
            'RptParameters("From") = "양재아이티(주)" & vbCrLf & GV1.GetRowCellValue(GV1.FocusedRowHandle, "OUR_ADDR").ToString
            'RptParameters("To") = GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_NM").ToString & vbCrLf & GV1.GetRowCellValue(GV1.FocusedRowHandle, "CUST_ADDR").ToString &
            '    vbCrLf & GV1.GetRowCellValue(GV1.FocusedRowHandle, GV1_CEO_PIC_NM).ToString
            Dim count As Integer = 1
            GV1.FocusedRowHandle = -1
            For i As Integer = 0 To GV1.RowCount - 1
                If GV1.GetRowCellValue(i, "CHK") = "Y" Then
                    '    RptParameters("From" & count) = "양재아이티(주)" & vbCrLf & GV1.GetRowCellValue(i, "OUR_ADDR").ToString
                    '    RptParameters("To" & count) = GV1.GetRowCellValue(i, "CUST_NM").ToString & vbCrLf & GV1.GetRowCellValue(i, "CUST_ADDR").ToString &
                    'vbCrLf & GV1.GetRowCellValue(i, GV1_CEO_PIC_NM).ToString
                    '    count += 1
                    If GV1.GetDataRow(i).RowState = DataRowState.Unchanged Then
                        GV1.GetDataRow(i).SetAdded()
                    End If
                Else
                    If GV1.GetDataRow(i).RowState = DataRowState.Modified Then
                        GV1.GetDataRow(i).AcceptChanges()
                    End If
                End If
            Next
            ds = Me.ConvertToDataset
            dt = ds.Tables("WG1")
            'dt.TableName = "DETAIL"

            dtTemp = dt.Clone

            dtTemp.Columns.Add("CUST_INFO1")
            dtTemp.Columns.Add("CUST_INFO2")

            dtTemp.TableName = "DETAIL"
            ds.Tables.Remove(dt)
            ds.Tables.Add(dtTemp)
            For i As Integer = 0 To dt.Rows.Count - 1
                If i Mod 2 = 0 Then
                    dtTemp.Rows.Add()
                    dtTemp.Rows(dtTemp.Rows.Count - 1)("CUST_INFO1") = dt.Rows(i)("CUST_INFO")
                Else
                    dtTemp.Rows(dtTemp.Rows.Count - 1)("CUST_INFO2") = dt.Rows(i)("CUST_INFO")
                End If

                'If (i * 2) > dt.Rows.Count Then
                '    Exit For
                'Else
                '    dtLeft.Rows.Add()
                '    dtLeft.Rows(i)("CUST_INFO") = dt.Rows(i * 2)("CUST_INFO")
                'End If
            Next
            'For j As Integer = 0 To dt.Rows.Count - 1
            '    If (j * 2) + 1 > dt.Rows.Count Then
            '        Exit For
            '    Else
            '        dtRight.Rows.Add()
            '        dtRight.Rows(j)("CUST_INFO") = dt.Rows((j * 2) + 1)("CUST_INFO")
            '    End If
            'Next
            rpt = RptBaseSetting("DM", "DMPost.repx", ds, RptParameters)


            'Dim obj1 As Object = rpt.FindControl("label1", True)
            'Dim obj2 As Object = rpt.FindControl("label2", True)
            'obj1.LocationFloat = New DevExpress.Utils.PointFloat(0, PRINT_LANE.SelectedValue * 118.2 - 118.2)
            'obj2.LocationFloat = New DevExpress.Utils.PointFloat(407, PRINT_LANE.SelectedValue * 118.2 - 118.2)
            'If OUR_ADDR.Checked = True Then
            '    obj1.Visible = True
            'Else
            '    obj1.Visible = False
            'End If
            'If CUST_ADDR.Checked = True Then
            '    obj2.Visible = True
            'Else
            '    obj2.Visible = False
            'End If

            If Not rpt Is Nothing Then
                ReportPrintTool(rpt)
            End If



        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

#End Region
#Region "=================Control Events==========="

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub CrmDMPrint_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Common.DrawRowIndicator(GV1)
    End Sub

    Private Sub S_RECEIVER_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_RECEIVER.SelectedIndexChanged
        If S_RECEIVER.Value = "P" Then
            GV1.Columns(5).FieldName = "PIC_NM"
        Else
            GV1.Columns(5).FieldName = "CEO"
        End If
    End Sub

    Private Sub CUST_ORDER_A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUST_ORDER_A.CheckedChanged
        If CUST_ORDER_A.Checked = True Then
            CUST_ORDER_Z.Checked = False
        Else
            CUST_ORDER_Z.Checked = True
        End If
    End Sub

    Private Sub CUST_ORDER_Z_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUST_ORDER_Z.CheckedChanged
        If CUST_ORDER_Z.Checked = True Then
            CUST_ORDER_A.Checked = False
        Else
            CUST_ORDER_A.Checked = True
        End If
    End Sub

    Private Sub btnDMPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDMPrint.Click
        PrintData()
    End Sub
    Private Sub S_LOC_FRGN_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_LOC_FRGN_TYPE.SelectedIndexChanged
        If S_LOC_FRGN_TYPE.SelectedValue = "L" Then
            S_CTRY.Enabled = False
        Else
            S_CTRY.Enabled = True
        End If
    End Sub
#End Region

End Class