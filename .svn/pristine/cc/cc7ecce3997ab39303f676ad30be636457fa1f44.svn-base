Imports YJIT.SC.UI
Imports YJIT.SC.App.FreightCommon
Imports YJIT.SC.App.Common
Imports System.Net.Mail
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Text.RegularExpressions

Public Class MetaStlMgt
#Region "=================GetConvertToDataSet Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String, Optional ByVal dtWG1 As DataTable = Nothing) As DataSet
        Dim YJSql As New YJQuery

        Select Case SearchType.ToUpper
            Case "Search".ToUpper
                YJSql.SqlBox("WG1", "MetaStlMgt@Search",, False)
                YJSql.Params("STL_YMD", S_STL_YMD.Text)
                YJSql.Params("CRN", S_CRN.Text)
                YJSql.Params("CUST_NM", S_CUST_NM.Text)
                YJSql.Params("USR_TYPE", S_USR_TYPE.SelectedValue)
        End Select

        Return YJSql.DataSet
    End Function
#End Region
#Region "=================Data logic actions==========="
    'Search
    Private Sub SearchData()
        If SearchValidate() = False Then Exit Sub
        Dim dsret As DataSet = GetConvertToDataSet("Search")
        dsret = MethodCallEx(Me, "YJIT.Biz.MetaStlMgt", "Search", {dsret})
        Dim drpairs As DataRow = dsret.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drpairs("TrxCode").ToString
            Case "Y"
                Me.BindToDataset(dsret, "Data")
            Case "N"
                MsgBoxLocalized(drpairs("TrxMsg").ToString)
                Call ClearView(AppliedRangeTypes.Only, {WG1})
            Case Else
                MsgBoxLocalized(drpairs("trxMsg").ToString)
        End Select
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Try
            If String.IsNullOrEmpty(S_STL_YMD.Text) Then
                If ErrControl Is Nothing Then ErrControl = pickerDATE
                ErrMsg &= "청구년월을 입력해 주세요." & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If
            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function
#End Region
#Region "=================Client Function==========="
    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Export Excel", True)
        PopUp.PopUpInit(Me, WG1)
    End Sub
    Private Sub InitGrid()
        Call DrawRowIndicator({GV1})

        GV1.Columns("USR_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEditEx({"S:화주", "F:물류실행사"})
    End Sub
    Private Sub InitDefault()
        pickerDATE.Value = Now
    End Sub
    '엑셀 출력
    Private Sub GridToExcel(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Common.ExportToExcel(obj)
    End Sub
#End Region
#Region "=================Control Events==========="
    'Client Function : 클라이언트 동작 함수
    Private Sub MetaStlMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitDefault()
        Call InitGrid()
        Call SetMandatoryLine(Me)
    End Sub
    Private Sub MetaStlMgt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call PopUpInit()

        pickerDATE.Focus()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnExpFwg1_Click(sender As Object, e As EventArgs) Handles btnExpFwg1.Click
        Call GridToExcel(WG1)
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call ClearView()
        Call InitDefault()

        pickerDATE.Focus()
    End Sub
    Private Sub pickerDATE_ValueChanged(sender As Object, e As EventArgs) Handles pickerDATE.ValueChanged
        S_STL_YMD.Text = pickerDATE.Value.ToString("yyyyMM")
    End Sub
    Private Sub pickerDATE_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles pickerDATE.PreviewKeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            S_CRN.Focus()
        End If
    End Sub
#End Region
End Class