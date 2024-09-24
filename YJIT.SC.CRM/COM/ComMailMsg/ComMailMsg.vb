Imports System
Imports System.IO
Imports System.Drawing
Imports YJIT.SC.UI
Imports Microsoft.Office



Public Class ComMailMsg
#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToString.ToUpper
                    YJSql.SqlBox("WG1", "ComMailMsg@Search")
                    YJSql.Params("GRP_CD", "S31")
                Case "Grid".ToString.ToUpper
                    YJSql.SqlBox("MAIN", "ComMailMsg@Search")
                    YJSql.Params("GRP_CD", "S31")
                    YJSql.Params("COMN_CD", GV1.GetFocusedRowCellValue("COMN_CD").ToString)
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    Private Function GetConvertToDataSetRmkList() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG2", "ComMailMsg@SearchRmkList")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region

#Region "=================Client Function==========="
    'Client Function : 클라이언트 동작 함수
    Public Sub PopupInit()
        Dim Popup As New PopupBase

        Popup = New PopupBase
        Popup.ItemAdd(Action.Excel, "WG1_ExportExcel", "&Export Excel")
        Popup.PopUpInit(Me, WG1)
    End Sub

    Private Sub InitGrid()
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim dt As DataTable = Nothing

        '==================Grid1============================
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C07")
        dataParams.Add("NameType", "")
        editorCombo.ShowHeader = False
        editorCombo.ReadOnly = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("MSG_TYPE").ColumnEdit = editorCombo


        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C08")
        dataParams.Add("NameType", "")
        editorCombo.ShowHeader = False
        editorCombo.ReadOnly = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("MSG_TYPE2").ColumnEdit = editorCombo


        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DisplayMember = "NAME"
        editorCombo.ValueMember = "CODE"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        editorCombo.ShowHeader = False
        editorCombo.ReadOnly = False
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("DEPT_CD").ColumnEdit = editorCombo

    End Sub

#End Region

#Region "=================Data logic actions==========="
    Public Sub SearchData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Search")

            dsRet = MethodCallEx(Me, "YJIT.Biz.ComMailMsg", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Except, {WG1, WG2})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    Call ClearView(AppliedRangeTypes.Except, {WG1, WG2})
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
            If String.IsNullOrEmpty(GRP_CD.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = GRP_CD
                ErrMsg &= "Please input the [" & lbl_GRP_CD.Text & "]" & vbNewLine
            End If

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

    Public Sub SearchGridData()
        Try
            If SearchGridValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet("Grid")

            dsRet = MethodCallEx(Me, "YJIT.Biz.ComMailMsg", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Except, {WG1, WG2})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    Call ClearView(AppliedRangeTypes.Except, {WG1, WG2})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Function SearchGridValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If GV1.RowCount = 0 Then
                If ErrControl Is Nothing Then ErrControl = btnSearch
                ErrMsg &= "[Code] Data Not Found!" & vbNewLine
            End If

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

    Public Sub SearchRmkListData()
        Try
            Dim dsRet As DataSet = GetConvertToDataSetRmkList()

            dsRet = MethodCallEx(Me, "YJIT.Biz.ComMailMsg", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.Retrieved
                Case "N"
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.Retrieved
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub NewData()
        ClearView(UI.AppliedRangeTypes.Except, {WG1, WG2})
        GRP_CD.Text = "S31"
        MSG_TYPE.SelectedValue = "001"
        MSG_TYPE2.SelectedValue = "001"


        Me.DataState = UI.DataStates.New
    End Sub

    Public Sub SaveData()
        If SaveValidate() = False Then Exit Sub

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet("Search")
        dsRet.Tables.Add(Me.ConvertToDataset.Tables("MAIN").Copy)

        dsRet = MethodCallEx(Me, "YJIT.Biz.ComMailMsg", "Save", dsRet)
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(dsRet, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))
    End Sub
    Private Function SaveValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(MSG_TYPE.SelectedValue) OrElse String.IsNullOrEmpty(MSG_TYPE2.SelectedValue) Then
                If ErrControl Is Nothing Then ErrControl = MSG_TYPE
                ErrMsg &= "Please input the [" & lbl_REQ_SVC.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(CONTENTS.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = CONTENTS
                ErrMsg &= "Please input the [" & lbl_CONTENTS.Text & "]" & vbNewLine
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

        If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet("Search")
        dsRet.Tables.Add(Me.ConvertToDataset.Tables("MAIN").Copy)

        dsRet = MethodCallEx(Me, "YJIT.Biz.ComMailMsg", "Delete", dsRet)

        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Call ClearView(AppliedRangeTypes.Only, {WG1})
            Me.BindToDataset(dsRet, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))

    End Sub
    Private Function DeleteValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(COMN_CD.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = COMN_CD
                ErrMsg &= "Please input the [" & lbl_COMN_CD.Text & "]" & vbNewLine
            End If


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
    'Control Event : Form Control 관련 프로시져
    Private Sub ComMailMsg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComMailMsg_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        PopupInit()
        SetMandatoryLine(Me)

        Call InitGrid()
        Call DrawRowIndicator({GV1, GV2})

        Call NewData()
        Call SearchRmkListData()
        If GV1.RowCount <> 0 Then Call SearchGridData()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call DeleteData()
    End Sub

    Private Sub MSG_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSG_TYPE.SelectedIndexChanged
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C08")
        dataParams.Add("OPT_ITEM1", MSG_TYPE.SelectedValue)
        dataParams.Add("NameType", "")
        MSG_TYPE2.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
    End Sub

    Private Sub GV1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GV1.Click
        Try
            If GV1.RowCount = 0 Then Exit Sub
            If bGV1_FocusedRowChanged = True Then Exit Sub

            Call SearchGridData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            bGV1_FocusedRowChanged = False
        End Try
    End Sub

    Dim bGV1_FocusedRowChanged As Boolean = False
    Private Sub GV1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Try
            If GV1.RowCount = 0 Then Exit Sub
            If GV1.IsValidRowHandle(e.FocusedRowHandle) = False Then Exit Sub

            If e.PrevFocusedRowHandle >= 0 Then bGV1_FocusedRowChanged = True

            Call SearchGridData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub GV2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV2.DoubleClick
        'If Not String.IsNullOrEmpty(CONTENTS.Text) Then CONTENTS.Text &= vbCrLf
        CONTENTS.Text &= GV2.GetFocusedRowCellValue("CAPTION").ToString & GV2.GetFocusedRowCellValue("TAG").ToString
    End Sub
#End Region






End Class
