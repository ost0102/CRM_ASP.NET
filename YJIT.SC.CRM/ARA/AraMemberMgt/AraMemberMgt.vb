Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Public Class AraMemberMgt

#Region "=================GetConvertToDataset Function==========="

#End Region
#Region "=================Client Function==========="

#End Region
#Region "=================Data logic actions==========="
    Dim CrnValidate_Result As Boolean
    Public Sub SearchData()
        Try
            Dim ds As DataSet = ChangeDBAddr()
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.AraMemberMgt", "Search", ds, AddressOf Search_Result)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub Search_Result(sender As Object, e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                ClearView(UI.AppliedRangeTypes.Except, {WG1, USE_YN, SEARCH_KEY})
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                Me.DataState = UI.DataStates.Retrieved
                Me.SEARCH_KEY.Focus()
                Call SearchDetailData()
                Exit Sub
            End If


            Me.BindToDataset(ds, "Data")
            Call SearchDetailData()
            Me.DataState = UI.DataStates.Retrieved

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub SearchDetailData()
        Dim ds As DataSet = ChangeDBAddr()
        Dim dr As DataRow

        ds.Tables("MAIN").Rows(0)("CRM_CD") = GV1.GetRowCellValue(GV1.FocusedRowHandle, "CRM_CD").ToString

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.AraMemberMgt", "SearchDetail", {ds})
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            ClearView(UI.AppliedRangeTypes.Except, {WG1, USE_YN, SEARCH_KEY})
            Me.DataState = UI.DataStates.Retrieved
            Me.SEARCH_KEY.Focus()
            Exit Sub
        End If

        Me.btnValidate.Enabled = False
        Me.CRM_CD.Enabled = False
        Me.BUSN_NO.ReadOnly = True

        Me.BindToDataset(ds, "Data")
        Me.DataState = UI.DataStates.Retrieved

    End Sub

    Public Sub NewData()
        ClearView(UI.AppliedRangeTypes.Except, {WG1, USE_YN, SEARCH_KEY})
        Me.ERP_LINK_SERVICE.SelectedIndex = 2
        Me.MEMB_STATE.SelectedIndex = 0
        Me.USE_START_DT.Text = Today.ToString("yyyyMMdd")
        Me.BASE_AMT.Text = 0
        Me.BASE_ISSUE_CNT.Text = 0
        Me.PRICE.Text = 0
        Me.CRM_CD.Enabled = True
        Me.BUSN_NO.ReadOnly = False
        Me.btnValidate.Enabled = True
        Me.CRM_CD.Focus()
    End Sub

    Public Sub SaveData()

        Dim ds As New DataSet
        Dim dr As DataRow
        Dim MsgRtn As Object = Nothing
        Dim CRMCD As String = ""

        MsgRtn = MsgBoxLocalized("저장하시겠습니까?", MessageBoxButtons.YesNo, "Comfirm", MessageBoxIcon.Question)
        If MsgRtn = MsgBoxResult.No Then
            Exit Sub
        End If

        '필수값 검사
        If SaveValidate() = False Then Exit Sub

        Try
            ds = ChangeDBAddr()
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.AraMemberMgt", "Save", {ds})
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"))
            Exit Sub
        End If

        Me.BindToDataset(ds, "Data")
        Me.SEARCH_KEY.Text = ""
        Call SearchData()
        MsgBoxLocalized(dr("TrxMsg"))


        For i As Integer = 0 To GV1.RowCount - 1
            If GV1.GetRowCellValue(i, "CRM_CD").ToString = dr("CRM_CD").ToString Then
                GV1.FocusedRowHandle = i
                Exit For
            End If
        Next

        Call SearchDetailData()
        Me.DataState = UI.DataStates.Retrieved
        CUST_NM.Focus()

    End Sub

    Public Sub SearchCustData()
        Dim ds As DataSet = ChangeDBAddr()
        Dim dr As DataRow

        ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.AraMemberMgt", "SearchCust", {ds})
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"))
            Exit Sub
        End If

        Me.BindToDataset(ds, "Data")
        Me.DataState = UI.DataStates.Retrieved

    End Sub

    Public Sub CrnValidate()

        If String.IsNullOrEmpty(BUSN_NO.Text.ToString) Then
            MsgBoxLocalized("사업자번호를 입력해주세요.")
            Me.BUSN_NO.Focus()
            Exit Sub
        End If

        Dim ds As DataSet = ChangeDBAddr()
        Dim dr As DataRow

        Try
            ds = Common.MethodCallEx(Me, "YJIT.Biz.AraMemberMgt", "CrnValidate", {ds})
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            BUSN_NO.Focus()
            Exit Sub
        End If

        MsgBoxLocalized("사용가능한 사업자번호 입니다.")
        CrnValidate_Result = True
        CUST_NM.Focus()

    End Sub

    Public Function SaveValidate() As Boolean
        Dim ErrControl As Control = Nothing
        Dim ErrMsg As String = ""
        Try
            If String.IsNullOrEmpty(CRM_CD.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = CRM_CD
                ErrMsg &= "[" & lbl_CRM_CD.Text.Replace("*", "") & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(CUST_NM.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = CUST_NM
                ErrMsg &= "[" & lbl_CUST_NM.Text.Replace("*", "") & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(CEO.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = CEO
                ErrMsg &= "[" & lbl_CEO.Text.Replace("*", "") & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(BIZ_COND.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = BIZ_COND
                ErrMsg &= "[" & lbl_BIZ_COND.Text.Replace("*", "") & "]을 입력해주세요." & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            If USE_END_DT.Text <> "" Then
                If Int(USE_START_DT.Text) > Int(USE_END_DT.Text) Then
                    MsgBoxLocalized("사용해지일이 사용시작일보다 빠릅니다. 확인하세요.")
                    USE_START_DT.Focus()
                    Return False
                End If
            End If

            If Not CrnValidate_Result Then
                MsgBoxLocalized("사업자 번호 [중복체크]를 하지 않아 저장할 수 없습니다. 확인하세요.")
                Return False
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Function ChangeDBAddr()
        Dim ds As DataSet = Me.ConvertToDataset
        ds.Tables("MAIN").Columns().Add("S_IP", GetType(String))
        ds.Tables("MAIN").Columns().Add("S_PORT", GetType(String))
        ds.Tables("MAIN").Columns().Add("S_SID", GetType(String))
        ds.Tables("MAIN").Columns().Add("S_USER_ID", GetType(String))
        ds.Tables("MAIN").Columns().Add("S_PASSWORD", GetType(String))

        ds.Tables("MAIN").Rows(0)("S_IP") = "110.45.209.61"
        ds.Tables("MAIN").Rows(0)("S_PORT") = "1521"
        ds.Tables("MAIN").Rows(0)("S_SID") = "ORCL"
        ds.Tables("MAIN").Rows(0)("S_USER_ID") = "PLISM_ARA"
        ds.Tables("MAIN").Rows(0)("S_PASSWORD") = "PLISM_ARA"

        Return ds
    End Function

#End Region
#Region "=================Control Events==========="
    Private Sub AraMemberMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetMandatoryLine(Me)
        CrnValidate_Result = False
        Call DrawRowIndicator(GV1)
    End Sub

    Private Sub AraMemberMgt_Show(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call SearchData()
        Me.SEARCH_KEY.Focus()
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

    Private Sub CRM_NM_Text_Changed(sender As Object, e As EventArgs) Handles CRM_NM.TextChanged
        If String.IsNullOrEmpty(CRM_CD.Text) OrElse String.IsNullOrEmpty(CRM_NM.Text) Then Exit Sub
        Call SearchCustData()
    End Sub

    Private Sub btnValidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidate.Click
        Call CrnValidate()
    End Sub

    Private Sub BUSN_NO_Text_Changed(sender As Object, e As EventArgs) Handles BUSN_NO.TextChanged
        If Not Me.btnValidate.Enabled Then
            CrnValidate_Result = True
        Else
            CrnValidate_Result = False
        End If
    End Sub

    Private Sub btnNaviCRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNaviCRM.Click
        If CRM_CD.Text = "" Then Exit Sub

        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        frmMain = IMainForm
        fTarget = frmMain.NavigateTo("CrmCustomerMgt")
        If Not IsNothing(fTarget) Then
            Dim SearchType As String = fTarget.SEARCH_TYPE.SelectedValue.ToString
            fTarget.SEARCH_TYPE.SelectedValue = "CUST_CD"
            fTarget.SEARCH_KEY.Text = CRM_CD.Text
            fTarget.SearchData()
            fTarget.SEARCH_TYPE.SelectedValue = SearchType
        End If
    End Sub
    Private Sub GV1_RowClick(ByVal sender As Object, e As RowClickEventArgs) Handles GV1.RowClick
        Call SearchDetailData()
        Me.CUST_NM.Focus()
    End Sub

    Private Sub GV1_Row_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GV1.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            e.KeyChar = String.Empty
            If Me.CRM_CD.Text.ToString() = "" Then
                Call SearchDetailData()
            End If
            CUST_NM.Focus()
        End If
    End Sub

    Private Sub GV1_FocusedRowChanged(ByVal sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Try
            If GV1.RowCount = 0 Then Exit Sub
            If GV1.IsValidRowHandle(e.FocusedRowHandle) = False Then Exit Sub

            Call SearchDetailData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub


#End Region
End Class