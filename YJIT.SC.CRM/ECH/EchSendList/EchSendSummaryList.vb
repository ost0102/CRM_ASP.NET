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

Public Class EchSendSummaryList

#Region "=================Data logic actions==========="
    Public Sub PopUpInit()

        Dim PopUp As New PopupBase
        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG1)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG2_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG2)

    End Sub
    Public Sub SearchData(ByVal SearchType As String)

        If FM_YMD.Text = "" Then
            MsgBox("검색일자는 필수항목 입니다!")
            FM_YMD.Focus()
            Exit Sub
        End If

        If TO_YMD.Text = "" Then
            MsgBox("검색일자는 필수항목 입니다!")
            TO_YMD.Focus()
            Exit Sub
        End If

        Dim dsRet As DataSet = Me.ConvertToDataset
        If SearchType = "D" Then
            dsRet = MethodCallEx(Me, "YJIT.Biz.EchSendList", "SearchSummary", {dsRet})
        Else
            dsRet = MethodCallEx(Me, "YJIT.Biz.EchSendList", "SearchSendStatus", {dsRet})
        End If

        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case drPairs("TrxCode")
            Case "Y"
                Me.BindToDataset(dsRet, "Data")

                If dsRet.Tables.Contains("Data.SearchCustCnt") Then
                    If dsRet.Tables("Data.SearchCustCnt").Rows.Count = 0 Then
                        GridBand4.Caption = String.Format("총 {0} 고객", "0")
                    Else
                        GridBand4.Caption = String.Format("총 {0} 고객", dsRet.Tables("Data.SearchCustCnt").Rows(0)("ECH_CUST_CNT").ToString)
                    End If
                End If

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(drPairs("TrxMsg"))
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

    End Sub
    Public Sub GridInit()

        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editor As New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim dt As DataTable = Nothing

        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "Y02")
        dataParams.Add("NameType", "")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("VENDOR_TYPE").ColumnEdit = editorCombo


    End Sub
#End Region
#Region "=================Control Events==========="
    Private Sub EchSendSummaryList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Common.DrawRowIndicator(GV1)

        FM_YMD.Text = Now.ToString("yyyyMM") & "01"
        TO_YMD.Text = Now.ToString("yyyyMMdd")

    End Sub
    Private Sub EchSendSummaryList_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call GridInit()
        Call PopUpInit()
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        xtcRemark.SelectedTabPageIndex = 0
        Call SearchData("D")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        xtcRemark.SelectedTabPageIndex = 1
        Call SearchData("S")

        Dim SeaCust As Integer = 0 : Dim SeaCnt As Integer = 0 : Dim SeaTot As Integer = 0
        Dim AirCust As Integer = 0 : Dim AirCnt As Integer = 0 : Dim AirTot As Integer = 0
        Dim AmsCust As Integer = 0 : Dim AmsCnt As Integer = 0 : Dim AmsTot As Integer = 0
        Dim TotCust As Integer = 0 : Dim TotCnt As Integer = 0 : Dim TotTot As Integer = 0

        Dim dt As New DataTable
        dt.Columns.Add("SEA")
        dt.Columns.Add("AIR")
        dt.Columns.Add("AMS")
        dt.Columns.Add("TOT")

        Dim nR As Integer = 0

        For i = 0 To GV2.RowCount - 1

            dt.Rows.Add()
            dt.Rows(nR)("SEA") = Format(CDbl(GV2.GetRowCellValue(i, "SEA_CUST_CNT")), "#,###,###,##0") & " / " & Format(CDbl(GV2.GetRowCellValue(i, "SEA_SEND_CNT")), "#,###,###,##0") & " / " & Format(CDbl(GV2.GetRowCellValue(i, "SEA_SEND_CNT2")), "#,###,###,##0")
            dt.Rows(nR)("AIR") = Format(CDbl(GV2.GetRowCellValue(i, "AIR_CUST_CNT")), "#,###,###,##0") & " / " & Format(CDbl(GV2.GetRowCellValue(i, "AIR_SEND_CNT")), "#,###,###,##0") & " / " & Format(CDbl(GV2.GetRowCellValue(i, "AIR_SEND_CNT2")), "#,###,###,##0")
            dt.Rows(nR)("AMS") = Format(CDbl(GV2.GetRowCellValue(i, "AMS_CUST_CNT")), "#,###,###,##0") & " / " & Format(CDbl(GV2.GetRowCellValue(i, "AMS_SEND_CNT")), "#,###,###,##0") & " / " & Format(CDbl(GV2.GetRowCellValue(i, "AMS_SEND_CNT2")), "#,###,###,##0")
            dt.Rows(nR)("TOT") = Format(CDbl(GV2.GetRowCellValue(i, "TOT_CUST_CNT")), "#,###,###,##0") & " / " & Format(CDbl(GV2.GetRowCellValue(i, "TOT_SEND_CNT")), "#,###,###,##0") & " / " & Format(CDbl(GV2.GetRowCellValue(i, "TOT_SEND_CNT2")), "#,###,###,##0")
            nR += 1
            SeaCust += CDbl(GV2.GetRowCellValue(i, "SEA_CUST_CNT"))
            SeaCnt += CDbl(GV2.GetRowCellValue(i, "SEA_SEND_CNT"))
            SeaTot += CDbl(GV2.GetRowCellValue(i, "SEA_SEND_CNT2"))
            AirCust += CDbl(GV2.GetRowCellValue(i, "AIR_CUST_CNT"))
            AirCnt += CDbl(GV2.GetRowCellValue(i, "AIR_SEND_CNT"))
            AirTot += CDbl(GV2.GetRowCellValue(i, "AIR_SEND_CNT2"))
            AmsCust += CDbl(GV2.GetRowCellValue(i, "AMS_CUST_CNT"))
            AmsCnt += CDbl(GV2.GetRowCellValue(i, "AMS_SEND_CNT"))
            AmsTot += CDbl(GV2.GetRowCellValue(i, "AMS_SEND_CNT2"))
            TotCust += CDbl(GV2.GetRowCellValue(i, "TOT_CUST_CNT"))
            TotCnt += CDbl(GV2.GetRowCellValue(i, "TOT_SEND_CNT"))
            TotTot += CDbl(GV2.GetRowCellValue(i, "TOT_SEND_CNT2"))
        Next


        dt.Rows.Add()
        dt.Rows(nR)("SEA") = Format(SeaCust, "#,###,###,##0") & " / " & Format(SeaCnt, "#,###,###,##0") & " / " & Format(SeaTot, "#,###,###,##0")
        dt.Rows(nR)("AIR") = Format(AirCust, "#,###,###,##0") & " / " & Format(AirCnt, "#,###,###,##0") & " / " & Format(AirTot, "#,###,###,##0")
        dt.Rows(nR)("AMS") = Format(AmsCust, "#,###,###,##0") & " / " & Format(AmsCnt, "#,###,###,##0") & " / " & Format(AmsTot, "#,###,###,##0")
        dt.Rows(nR)("TOT") = Format(TotCust, "#,###,###,##0") & " / " & Format(TotCnt, "#,###,###,##0") & " / " & Format(TotTot, "#,###,###,##0")

        WG3.DataSource = dt

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Common.ExportToExcel(WG3)
    End Sub

#End Region

   
End Class