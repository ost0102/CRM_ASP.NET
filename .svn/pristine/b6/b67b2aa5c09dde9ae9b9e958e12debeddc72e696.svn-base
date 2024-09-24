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

Public Class EchCustomerMgt

#Region "=================Data logic actions==========="

    Public Sub PopUpInit()

        'Dim PopUp As New PopupBase
        'PopUp = New PopupBase
        'PopUp.ItemAdd(Action.DeleteRow, "EchCustomerMgt", "&Delete Row")
        'PopUp.PopUpInit(Me, WG1)

    End Sub

    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try

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

    Public Sub SearchData()

        If SearchValidate() = False Then Exit Sub

        Dim dsRet As DataSet = Me.ConvertToDataset

        Try
            dsRet = MethodCallEx(Me, "YJIT.Biz.EchCustomerMgt", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.ResetView(UI.AppliedRangeTypes.Except, {SEARCH_TYPE, SEARCH_KEY})
                    Me.BindToDataset(dsRet, "Data")

                    GV1.BestFitColumns()
                    If GV1.RowCount > 0 Then Call SearchDetail(GV1.GetFocusedRowCellValue("CUST_CD").ToString)

                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    Me.ResetView(UI.AppliedRangeTypes.Except, {SEARCH_TYPE, SEARCH_KEY})

                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Call ResetView(AppliedRangeTypes.Only, {WG1})

                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub SearchDetail(ByVal CustCode As String)
        Dim dsRet As DataSet = Me.ConvertToDataset

        Try
            If GV1.RowCount = 0 Then Exit Sub
            If CustCode = "" Then Exit Sub

            ResetView(UI.AppliedRangeTypes.Except, {WG1, SEARCH_TYPE, SEARCH_KEY})

            dsRet = MethodCallEx(Me, "YJIT.Biz.EchCustomerMgt", "SearchDetail", {CustCode})

            Try
                Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
                Select Case drPairs("TrxCode")
                    Case "Y"
                        Me.BindToDataset(dsRet, "Data")
                        Me.DataState = UI.DataStates.Retrieved

                    Case "N"
                        MsgBoxLocalized(drPairs("TrxMsg"))
                        Call ClearView(AppliedRangeTypes.Only, {WG2})
                        Me.DataState = UI.DataStates.Retrieved
                    Case Else
                        MsgBoxLocalized(drPairs("TrxMsg"))
                End Select

            Catch ex As Exception
                MsgBoxLocalized(ex.Message)
            End Try
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    'Grid View Sequence 표시 함수
    Private Sub SetGridViewSequence(ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Dim rowIndex As Integer = e.RowHandle

        e.Info.DisplayText = "No"

        If rowIndex >= 0 Then
            rowIndex += 1
            e.Info.DisplayText = rowIndex.ToString()
        End If

        e.Info.ImageIndex = -1
    End Sub

    Public Sub ClearData()
        Me.ClearView()
    End Sub

    Private Sub SaveData()
        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        Dim paramsDs As DataSet = Me.ConvertToDataset
        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EchCustomerMgt", "SaveData", {paramsDs})
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            Select Case dr("TrxCode")
                Case "N"
                Case "E"
                    MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    Exit Sub
            End Select
        Else
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If
        MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
    End Sub

#End Region
#Region "=================Control Events==========="
    Private Sub EchCustomerMgt_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Common.DrawRowIndicator(GV1)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Call SaveData()
    End Sub

    Private Sub WG1_Click(sender As Object, e As System.EventArgs) Handles WG1.Click
        If GV1.RowCount = 0 Then Exit Sub
        SearchDetail(GV1.GetFocusedRowCellValue("CUST_CD").ToString)
    End Sub

    Private Sub GV1_CustomDrawRowIndicator(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GV1.CustomDrawRowIndicator
        Call SetGridViewSequence(e)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
#End Region


End Class