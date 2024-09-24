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

Public Class CrmMaintenanceMgt

#Region "=================Client Function==========="
    'Client Function : 클라이언트 동작 함수

    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG1", "CrmMaintenanceMgt@Search")
            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString.Trim)
            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString.Trim)
            YJSql.Params("SEARCH_KEY", drMAIN("S_SEARCH_KEY").ToString.Trim)
            YJSql.Params("SVC_CD", drMAIN("S_SVC_CD").ToString.Trim)
            YJSql.Params("MATN_YN", drMAIN("S_MATN_YN").ToString.Trim)


            YJSql.SqlBox("PGC1", "CrmMaintenanceMgt@SearchPivot")
            YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString.Trim)
            YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString.Trim)
            YJSql.Params("SEARCH_KEY", drMAIN("S_SEARCH_KEY").ToString.Trim)
            YJSql.Params("SVC_CD", drMAIN("S_SVC_CD").ToString.Trim)
            YJSql.Params("MATN_YN", drMAIN("S_MATN_YN").ToString.Trim)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function


    Public Sub PopupInit()
        Dim PopUp As New PopupBase
        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_EXCEL", "Export Excel", True)
        PopUp.PopUpInit(Me, WG1)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "PGC1_EXCEL", "Export Excel", True)
        PopUp.PopUpInit(Me, PGC1)

    End Sub

#End Region

#Region "=================Data logic actions==========="
    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet()

        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmMaintenanceMgt", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG1, PGC1})

                Me.BindToDataset(dsRet, "Data")
                PGC1.DataSource = dsRet.Tables("Data.PGC1")

                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(drPairs("TrxMsg"))
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG1, PGC1})

                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            'If String.IsNullOrEmpty(S_COMN_CD.SelectedValue.ToString) Then
            '    If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = S_COMN_CD
            '    ErrMsg &= "Please input the [Mapping Type]" & vbNewLine
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

#Region "=================Control Events==========="
    Private Sub CrmMaintenanceMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopupInit()
        Common.DrawRowIndicator(GV1)
    End Sub

    Private Sub SEARCH_KEY_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles S_SEARCH_KEY.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Call SearchData()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
#End Region

End Class