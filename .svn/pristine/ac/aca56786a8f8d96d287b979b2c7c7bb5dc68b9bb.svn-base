Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Imports System.IO

Public Class CrmAsScore

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    YJSql.SqlBox("WG1", "CrmAsList@SearchScore")
                    YJSql.Params("GRP_CD", drMAIN("S_GRP_CD").ToString)
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region

#Region "=================Client Function==========="
    Public Sub PopUpInit()
        Dim itemCaption = {"&Add Row", "&Delete Row", "&Export Excel"}

        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", itemCaption(2))
        PopUp.PopUpInit(Me, WG1)
    End Sub

    Private Sub PageInit()
        S_GRP_CD.SelectedValue = "T02"
    End Sub

    Private Sub GridInit()
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T13")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("GRP_CD").ColumnEdit = editorCombo
    End Sub

    Private Sub ClearData()
        Call ClearView()
        Call PageInit()
    End Sub

    Private Sub NewData()
        Call ClearView()
    End Sub
#End Region

#Region "=================Data logic actions================="
    Public Sub SearchData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsList", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            'If String.IsNullOrEmpty(S_CUST_CD.Text.ToString) Then
            '    'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = S_CUST_CD
            '    ErrMsg &= "Please input the [" & lbl_S_CUST_CD.Text & "]" & vbNewLine
            'End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                'If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function

    Public Sub SaveData()
        Try
            If SaveValidate() = False Then Exit Sub

            If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")
            dsRet.Tables.Add(Me.ConvertToDataset.Tables("MAIN").Copy)
            dsRet.Tables.Add(Me.ConvertToDataset.Tables("WG1").Copy)

            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmAsList", "SaveScore", {dsRet})

            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") = "Y" Then
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.BindToDataset(dsRet, "Data")
                Me.DataState = UI.DataStates.Retrieved
            End If

            MsgBoxLocalized(dr("TrxMsg"))
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Function SaveValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            'If String.IsNullOrEmpty(MANUAL_TYPE.SelectedValue) Then
            '    'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = MANUAL_TYPE
            '    ErrMsg &= "Please input the [" & lbl_MANUAL_TYPE.Text & "]" & vbNewLine
            'End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                'If Not ErrTabPage Is Nothing Then xtcMAIN.SelectedTabPage = ErrTabPage
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

#Region "=================Control Events================="
    Private Sub CrmAsScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrmAsScore_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PageInit()
        Call GridInit()
        Call PopUpInit()
        Call DrawRowIndicator({GV1})
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
#End Region


End Class