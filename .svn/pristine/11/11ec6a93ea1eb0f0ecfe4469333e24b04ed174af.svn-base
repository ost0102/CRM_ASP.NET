Imports YJIT.SC.UI

Public Class StlPaymentList
#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            Select Case SearchType.ToString.ToUpper
                Case "Search".ToUpper
                    YJSql.SqlBox("WG1", "StlPaymentList@Search", True)
                    YJSql.Params("FM_YMD", drMAIN("S_FM_YMD").ToString)
                    YJSql.Params("TO_YMD", drMAIN("S_TO_YMD").ToString)
                    If drMAIN("S_DATE_TYPE").ToString = "C" Then
                        YJSql.Blocks("CMPT_YMD", "TRUE")
                    Else
                        YJSql.Blocks("REQ_YMD", "TRUE")
                    End If
                    YJSql.Blocks("DEPT_TYPE_" & drMAIN("S_DEPT_TYPE").ToString, "TRUE")

                    If S_DEPT_CD_M.Visible = True Then
                        YJSql.Params("DEPT_CD", S_DEPT_CD_M.EditValue.ToString.Replace(";", "','").Replace(" ", ""))
                    Else
                        YJSql.Params("DEPT_CD", drMAIN("S_DEPT_CD").ToString)
                    End If

                    YJSql.Params("CUST_CD", drMAIN("S_CUST_CD").ToString)
                    If drMAIN("S_WORK_TYPE").ToString = "W" Then
                        YJSql.Blocks("WORK_TYPE_" & drMAIN("S_WORK_TYPE").ToString, "TRUE")
                    ElseIf drMAIN("S_WORK_TYPE").ToString = "I" Then
                        YJSql.Blocks("WORK_TYPE_" & drMAIN("S_WORK_TYPE").ToString, "TRUE")
                    End If
                    YJSql.Params("WORK_USR", drMAIN("S_WORK_USR").ToString)
                    YJSql.Params("SEARCH_KEY", drMAIN("SEARCH_KEY").ToString)
                    YJSql.Params("PROJECT_CD", drMAIN("S_PROJECT_CD").ToString)
                    YJSql.Params("CARD_ACCT_CD", drMAIN("S_CARD_ACCT_CD").ToString)
                    YJSql.Params("CARD_TYPE", drMAIN("S_CARD_TYPE").ToString)
                Case Else
                    Throw New Exception("No match type found. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region
#Region "=================Data logic actions==========="
    Private Sub SearchData()
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
            If String.IsNullOrEmpty(S_FM_YMD.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = S_FM_YMD
                ErrMsg &= "조회기간은 필수 입니다." & vbNewLine
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
    Private Function SaveCardValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            Dim CheckYN As String = "N"

            For i = 0 To GV1.RowCount - 1
                GV1.GetDataRow(i).AcceptChanges()
                If GV1.GetRowCellValue(i, "CHK").ToString = "Y" Then
                    GV1.GetDataRow(i).SetAdded()
                    CheckYN = "Y"
                End If
            Next

            If CheckYN = "N" Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = WG1
                ErrMsg &= "회계이관할 자료를 선택후 진행하세요." & vbNewLine
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
    Public Sub InitData()
        S_FM_YMD.Text = DateAdd(DateInterval.Month, -1, Now).ToString("yyyyMM") & "01"
        S_TO_YMD.Text = DateSerial(Now.ToString("yyyy"), Now.ToString("MM"), 1 - 1).ToString("yyyyMMdd")
        S_FM_YMD.Focus()
    End Sub
    Public Sub GridInit()
        Common.DrawRowIndicator({GV1})

        GV1.Columns("REQ_YMD").ColumnEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    End Sub
    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.NavigateTo, "CrmAsMgt_v4", "고객지원 등록")
        PopUp.PopUpInit(Me)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.NavigateTo, "WG1_CrmAsMgt_v4", "고객지원 등록")
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", "&Excel Export", True)
        PopUp.PopUpInit(Me, WG1)
    End Sub
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString

        Select Case key
            Case "CrmAsMgt_v4"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("CrmAsMgt_v4")
            Case "CrmAsScore"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("CrmAsScore")
            Case "WG1_CrmAsMgt_v4"
                Call NavigetToCrmAsMgt(GV1)
        End Select
    End Sub
#End Region

#Region "=================Control Events==========="
    Private Sub StlPaymentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GridInit()
        Call InitData()
    End Sub
    Private Sub StlPaymentList_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopUpInit()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub GV1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GV1.DoubleClick
        Call NavigetToCrmAsMgt(sender)
    End Sub
    Private Sub NavigetToCrmAsMgt(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = Me.MdiParent
        fTarget = frmMain.NavigateTo("CrmAsMgt_v4")
        If Not IsNothing(fTarget) Then
            fTarget.MNGT_NO.Text = view.GetFocusedRowCellValue("MNGT_NO").ToString
            fTarget.SearchData()
        End If
    End Sub
#End Region

End Class