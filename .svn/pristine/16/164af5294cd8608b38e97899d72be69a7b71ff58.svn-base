Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports System.Drawing
Imports YJIT.SC.UI
Imports YJIT.SC.UI.SCControls
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports System.IO

Public Class WBSProjectMgt
    Public init As Boolean = False

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal Type As String) As DataSet
        Dim YJSql As New YJQuery
        'Dim ds As DataSet = Me.ConvertToDataset
        'Dim drMain As DataRow = ds.Tables("MAIN").Rows(0)
        Dim IsSingleSearch As Boolean = False

        Select Case Type.ToUpper
            Case "Search".ToUpper
                YJSql.SqlBox("WG1", "CrmWBSMgt@Search", True)
            Case "SearchDetail".ToUpper
                YJSql.SqlBox("MAIN", "CrmWBSMgt@Search", True)
                YJSql.Params("MNGT_NO", GV1.GetFocusedRowCellValue("MNGT_NO").ToString)
        End Select
        Return YJSql.DataSet
    End Function
#End Region

#Region "=================Client Function==========="
    Private Sub PopupInit()
    End Sub
#End Region

#Region "=================Data logic actions================="
    Public Sub SearchData()
        Dim ds As DataSet = GetConvertToDataSet("Search")
        ds = MethodCallEx(Me, "YJIT.Biz.CrmWBSMgt", "Search", {ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                If GV1.RowCount = 0 Then
                    MsgBoxLocalized(dr("TrxMsg"))
                End If
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(dr("TrxMsgs"))
        End Select
    End Sub
    Public Sub SearchDetailData()
        If IsNothing(GV1.GetRowCellValue(GV1.FocusedRowHandle, "MNGT_NO")) Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SearchDetail")
        ds = MethodCallEx(Me, "YJIT.Biz.CrmWBSMgt", "Search", {ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode").ToString
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(dr("TrxMsg").ToString)
        End Select
    End Sub
    Public Sub SaveData()
        If SaveValidate() = False Then Exit Sub

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset

        Try
            ds = MethodCallEx(Me, "YJIT.Biz.CrmWBSMgt", "SaveWBS", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))
        Call SearchData()
    End Sub
    Private Function SaveValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrGrid As Object = Nothing
        Dim ErrGridRow As Integer = Nothing
        Dim ErrGridCol As Object = Nothing

        Try
            If String.IsNullOrEmpty(PROJECT_NM.Text) Then
                ErrMsg = "프로젝트명을 입력해주세요."
            End If
            If String.IsNullOrEmpty(USR_ID.Text) Then
                ErrMsg = "등록자를 입력해주세요."
            End If
            If String.IsNullOrEmpty(FM_YMD.Text) OrElse String.IsNullOrEmpty(TO_YMD.Text) Then
                ErrMsg = "프로젝트 기간을 입력해주세요."
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
    Public Sub DeleteData()
        If DeleteValidate() = False Then Exit Sub

        If MsgBoxLocalized("Do you want to Delete?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset

        Try
            ds = MethodCallEx(Me, "YJIT.Biz.CrmWBSMgt", "DeleteWBS", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))
        Call SearchData()
    End Sub
    Private Function DeleteValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrGrid As Object = Nothing
        Dim ErrGridRow As Integer = Nothing
        Dim ErrGridCol As Object = Nothing

        Try
            If String.IsNullOrEmpty(MNGT_NO.Text) Then
                ErrMsg = "관리번호가 존재하지 않습니다." & vbNewLine
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
    Public Sub NewData()
        ClearView(UI.AppliedRangeTypes.Only, {MNGT_NO, PROJECT_NM, RMK})
        FM_YMD.Text = Now.ToString("yyyyMMdd")
        TO_YMD.Text = DateAdd(DateInterval.Month, 1, Now()).ToString("yyyyMMdd")
        USR_ID.Text = ClientSessionInfo.LocalName
    End Sub
#End Region

#Region "=================Control Events================="
    Private Sub WBSProjectMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SearchData()
    End Sub
    Private Sub WBSProjectMgt_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call DeleteData()
    End Sub
    'Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
    '    Call SearchData()
    'End Sub

    Private Sub GV1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Call SearchDetailData()
    End Sub
    Private Sub GV1_Click(sender As Object, e As EventArgs) Handles GV1.Click
        Call SearchDetailData()
    End Sub

    'Private Sub FM_YMD_TextChanged(sender As Object, e As EventArgs) Handles FM_YMD.TextChanged
    '    Dim DayDiff As Long
    '    If DB_FM_YMD.Text = FM_YMD.Text Then Exit Sub
    '    If Not String.IsNullOrEmpty(DB_FM_YMD.Text) AndAlso DB_FM_YMD.Text <> FM_YMD.Text Then
    '        DayDiff = DateDiff(DateInterval.Day, FM_YMD, DB_FM_YMD)
    '    End If
    '    '날짜형식을 DATE 로 바꾸지 못했어.....
    'End Sub
#End Region
End Class