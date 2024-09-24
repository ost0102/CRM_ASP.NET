Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Public Class EvbChargeSet
    Public result As String
#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal Type As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False
        Dim drMain As DataRow = ds.Tables("MAIN").Rows(0)
        Select Case Type.ToUpper
            Case "SEARCH"
                YJSql.SqlBox("WG1", "EvbChargeSet@Search")
        End Select
        Return YJSql.DataSet
    End Function
#End Region
#Region "=================Client Function==========="
    Private Sub PopupInit()
        Dim WG1_PopUp As New PopupBase
        WG1_PopUp.ItemAdd(Action.Excel, "WG1_ExcelExport", "&Export Excel", True)
        WG1_PopUp.PopUpInit(Me, WG1)
    End Sub
#End Region
#Region "=================Data logic actions==========="
    Public Sub SearchData()
        Dim ds As DataSet = GetConvertToDataSet("SEARCH")

        ds = MethodCallEx(Me, "YJIT.Biz.EvbMembers", "Search", {ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                If GV1.RowCount = 0 Then
                    MsgBoxLocalized("Data not found!")
                End If
                Me.DataState = UI.DataStates.Retrieved

            Case "E"
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
#End Region
#Region "=================Control Events==========="
    Private Sub btnSearch_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub EvbChargeSet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        result = "N"
    End Sub
    Private Sub EvbChargeSet_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call PopupInit()

        Call SearchData()
    End Sub
    Private Sub GV1_KeyDown(sender As Object, e As KeyEventArgs) Handles GV1.KeyDown
        If e.KeyCode = Keys.Enter Then
            result = "Y"
            ' 저장 후 창 닫기
            Me.Close()
        End If
    End Sub
    Private Sub GV1_DoubleClick(sender As Object, e As EventArgs) Handles GV1.DoubleClick
        result = "Y"
        ' 저장 후 창 닫기
        Me.Close()
    End Sub
#End Region
End Class