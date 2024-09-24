Imports System.Drawing
Imports System.Drawing.Icon
Imports YJIT.SC.UI
Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Collections.Specialized
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPivotGrid

Public Class CrmArList

#Region "=================Data logic actions==========="

    Public Sub SearchData()
        'If the sql lenght is long enough, It cannot be parsed into xml. So first we delete sql and than pass the dataset
        Dim ds As DataSet = Me.ConvertToDataset
        'ds.Tables.Remove("WG1")
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmArMgt", "SearchArList", ds, AddressOf search_OnComplete)
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

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

#End Region

#Region "=================Control Events==========="

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub CrmArMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call DrawRowIndicator(GV1)
    End Sub

#End Region

End Class