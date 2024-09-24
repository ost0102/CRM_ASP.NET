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

Public Class EchSendList

#Region "=================Data logic actions==========="
    Public Sub PopUpInit()

        Dim PopUp As New PopupBase
        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG1)

    End Sub
    Public Sub SearchData()

        Dim dsRet As DataSet = Me.ConvertToDataset
        dsRet = MethodCallEx(Me, "YJIT.Biz.EchSendList", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case drPairs("TrxCode")
            Case "Y"
                Me.BindToDataset(dsRet, "Data")
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
    End Sub

#End Region
#Region "=================Control Events==========="
    Private Sub EchSendList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Common.DrawRowIndicator(GV1)

        GV1.IndicatorWidth = 100

        FM_YMD.Text = Now.ToString("yyyyMM") & "01"
        TO_YMD.Text = Now.ToString("yyyyMMdd")

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
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

        Call SearchData()
    End Sub
    Private Sub EchSendList_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        PopUpInit()
    End Sub

#End Region

   
End Class