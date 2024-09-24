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

Public Class CrmTaxMgt

    Private Sub Initdata()
        S_CRMM.Text = Now.ToString("yyyyMM")
        S_CRMM.Focus()
    End Sub
    Private Sub GridInit()  
        Common.DrawRowIndicator({GV1, GV2, GV3})

    End Sub

#Region "=================Data logic actions===========" 
    Private Sub SearchData()
        Dim dsRet As New DataSet
        If S_CRMM.Text = "" Then
            MsgBoxLocalized("청구월 입력은 필수 입니다.")
            S_CRMM.Focus()  
        End If
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmTaxMgt", "Search", Me.ConvertToDataset, AddressOf search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs) 
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
                Exit Sub
            End If

            Me.BindToDataset(ds, "Data") 
            Me.DataState = UI.DataStates.Retrieved
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub


#End Region
#Region "=================Control Events==========="
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub CrmTaxMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        GridInit()
        InitData()
    End Sub 
#End Region
     
End Class