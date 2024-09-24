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

Public Class EchCustomerTariff

#Region "=================Data logic actions==========="
    Public Sub PopUpInit()

        Dim PopUp As New PopupBase
        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG1)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG3_Excel", "&Excel Export")
        PopUp.PopUpInit(Me, WG3)
    End Sub
    Public Sub SaveVendorTariff()

        If MsgBoxLocalized("저장 하시겠습니까?", MessageBoxButtons.YesNo, "확인", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub


        Dim ds As DataSet = New DataSet
        ds = Me.ConvertToDataset
        Dim params() As Object = {ds}
        Dim dsResult As DataSet
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EchCustomerTariff", "SaveVendorTariff", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(dsResult, "Data")
            Me.DataState = UI.DataStates.Retrieved
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If


    End Sub

    Public Sub SearchVendorTariff()

        Dim dsRet As DataSet = Me.ConvertToDataset
        dsRet = MethodCallEx(Me, "YJIT.Biz.EchCustomerTariff", "SearchVendorTariff", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case drPairs("TrxCode")
            Case "Y"
                Me.BindToDataset(dsRet, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

    End Sub
    Public Sub SearchData()

        Dim dsRet As DataSet = Me.ConvertToDataset
        dsRet = MethodCallEx(Me, "YJIT.Biz.EchCustomerTariff", "Search", {dsRet})
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
        GV2.Columns("KLNET_TYPE").ColumnEdit = editorCombo
        GV2.Columns("KTNET_TYPE").ColumnEdit = editorCombo
        GV2.Columns("KCNET_TYPE").ColumnEdit = editorCombo

        dt = New DataTable : dt.Columns.Add("CODE", GetType(String)) : dt.Columns.Add("NAME", GetType(String))
        dt.Rows.Add("KLNET", "KLNET")
        dt.Rows.Add("KTNET", "KLNET")
        dt.Rows.Add("KCNET", "KCNET")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DataSource = dt
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        editorCombo.ShowHeader = False
        GV1.Columns("VENDOR").ColumnEdit = editorCombo

        dt = New DataTable : dt.Columns.Add("CODE", GetType(String)) : dt.Columns.Add("NAME", GetType(String))
        dt.Rows.Add("V", "Vendor 단가")
        dt.Rows.Add("S", "특별단가")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DataSource = dt
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        editorCombo.ShowHeader = False
        GV1.Columns("UNIT_TYPE").ColumnEdit = editorCombo

    End Sub
    '2018.11.14 허진욱 CHAIN 등록업체 현황 추가
    Public Sub SearchChainData()
        Dim dsRet As DataSet = Me.ConvertToDataset

        Try
            dsRet = MethodCallEx(Me, "YJIT.Biz.EchCustomerTariff", "SearchECH", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Call ClearView(AppliedRangeTypes.Only, {WG3})
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception

        End Try

    End Sub

#End Region
#Region "=================Control Events==========="
    Private Sub EchCustomerTariff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Common.DrawRowIndicator({GV1, GV2, GV3})


        Call GridInit()
        Call SearchVendorTariff()
        Call SearchChainData()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnGv2Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGv2Save.Click
        Call SaveVendorTariff()
    End Sub
    Private Sub EchCustomerTariff_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        PopUpInit()
    End Sub

    Private Sub btnECHSearch_Click(sender As Object, e As System.EventArgs) Handles btnECHSearch.Click
        Call SearchChainData()
    End Sub
#End Region


End Class