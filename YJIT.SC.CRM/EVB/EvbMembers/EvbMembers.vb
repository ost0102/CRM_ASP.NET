Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports YJIT.SC.UI
Public Class EvbMembers

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet(ByVal Type As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False
        Dim drMain As DataRow = ds.Tables("MAIN").Rows(0)
        Select Case Type.ToUpper
            Case "Search".ToUpper
                YJSql.SqlBox("WG1", "EvbMembers@Search", , False)
                YJSql.Params("SEARCH_KEY", drMain("SEARCH_KEY").ToString)
                YJSql.Params("USE_YN", drMain("USE_YN").ToString)
            Case "SearchDetail".ToUpper
                YJSql.SqlBox("MAIN", "EvbMembers@SearchDetail")
                YJSql.Params("USER_AUTH_ID", GV1.GetRowCellValue(GV1.FocusedRowHandle, "USER_AUTH_ID").ToString)
            Case "SearchCust".ToUpper
                YJSql.SqlBox("MAIN", "EvbMembers@SearchCust")
                YJSql.Params("CRM_CD", drMain("CRM_CD").ToString)
            Case "CrnValidate".ToUpper
                YJSql.SqlBox("MAIN", "EvbMembers@CrnValidate")
                YJSql.Params("BUSN_NO", drMain("BUSN_NO").ToString)
            Case "UserAuthIDValidate".ToUpper
                YJSql.SqlBox("MAIN", "EvbMembers@UserIdValidate")
                YJSql.Params("USER_AUTH_ID", drMain("USER_AUTH_ID").ToString)
            Case "AutoCreateKey".ToUpper
                YJSql.SqlBox("MAIN", "EvbMembers@AutoCreateKey")
                YJSql.Params("USER_AUTH_ID", drMain("USER_AUTH_ID").ToString)
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
    Private Sub EnabledCheck(ByVal Method As String, ByVal E_type As Boolean, Optional R_type As Boolean = True)
        Select Case Method.ToUpper
            Case "NewData".ToUpper, "SearchDetailData".ToUpper
                btnValidate.Enabled = E_type
                btnAuto.Visible = E_type
                btnValidate2.Enabled = E_type
                CRM_CD.Enabled = E_type
                CRM_CD.ReadOnly = R_type
                If Method = "NewData".ToUpper Then
                    BUSN_NO.Enabled = E_type
                Else
                    BUSN_NO.Enabled = True '20210719 정지수 YJITS2021070480
                End If
                BUSN_NO.ReadOnly = R_type
            Case "CrnValidate".ToUpper
                btnValidate.Enabled = E_type
            Case "UserAuthIDValidate".ToUpper, "AutoCreateCode".ToUpper
                btnAuto.Enabled = E_type
        End Select
    End Sub
    Public Sub NewData()
        ClearView(UI.AppliedRangeTypes.Except, {WG1, USE_YN, SEARCH_KEY})
        Call EnabledCheck("NewData", True, False)
        BASE_AMT.Text = 4000
        BASE_TAX_CNT.Text = 20
        TAX_PRICE.Text = 180
        CRD_PRICE.Text = 100
        MAIL_PRT_TYPE.SelectedValue = "I"

        BS_EMAIL_YN.Checked = True
        BR_EMAIL_YN.Checked = True
        LF_EMAIL_YN.Checked = True
        NS_EMAIL_YN.Checked = False
        NE_EMAIL_YN.Checked = True

        CRM_CD.Focus()
    End Sub
    Public Sub SearchData()
        Dim ds As DataSet = GetConvertToDataSet("Search")

        ds = MethodCallEx(Me, "YJIT.Biz.EvbMembers", "Search", {ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y"
                Me.BindToDataset(ds, "Data")
                Call SearchDetailData()
                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                ClearView(UI.AppliedRangeTypes.Except, {USE_YN})
                MsgBoxLocalized(dr("TrxMsg"))
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    Private Sub SearchDetailData()
        If IsNothing(GV1.GetRowCellValue(GV1.FocusedRowHandle, "USER_AUTH_ID")) Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("SearchDetail")
        Try
            ds = MethodCallEx(Me, "YJIT.Biz.EvbMembers", "Search", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case dr("TrxCode")
            Case "Y"
                Me.BindToDataset(ds, "Data")
                Call EnabledCheck("SearchDetailData", False, True)
                Me.DataState = UI.DataStates.Retrieved
                If EXPIR_DT.Text <> "" Then
                    EXPIR_DT_MSG.Visible = False
                Else
                    EXPIR_DT_MSG.Visible = True
                End If
            Case "N"
                ClearView(UI.AppliedRangeTypes.Except, {WG1, USE_YN, SEARCH_KEY})
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    Public Sub SearchCustData()
        Dim ds As DataSet = GetConvertToDataSet("SearchCust")

        ds = MethodCallEx(Me, "YJIT.Biz.EvbMembers", "Search", {ds})
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y", "N"
                Me.BindToDataset(ds, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case "E"
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    Public Sub SaveData()
        If SaveValidate() = False Then Exit Sub

        If MsgBoxLocalized("저장하시겠습니까?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim ds As DataSet = GetConvertToDataSet("Search")
        Dim dsRet As DataSet = Me.ConvertToDataset
        Dim userAuthID As String = ""
        If GV1.RowCount <> 0 Then
            userAuthID = GV1.GetFocusedRowCellValue("USER_AUTH_ID").ToString
            GV1.GetRowCellValue(GV1.FocusedRowHandle, "USER_AUTH_ID")
        Else
            userAuthID = USER_AUTH_ID.Text.ToString
        End If


        Try
            ds.Tables.Add(dsRet.Tables("MAIN").Copy)
            ds = MethodCallEx(Me, "YJIT.Biz.EvbMembers", "Save", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case dr("TrxCode")
            Case "Y"
                Me.BindToDataset(ds, "Data")
                'Call SearchDetailData()
                For i As Integer = 0 To GV1.RowCount - 1
                    If GV1.GetRowCellValue(i, "USER_AUTH_ID").ToString = userAuthID Then
                        GV1.FocusedRowHandle = i
                        Exit For
                    End If
                Next
                MsgBoxLocalized(dr("TrxMsg"))
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(dr("TrxMsg"))
        End Select
    End Sub
    Private Function SaveValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(CRM_CD.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = CRM_CD
                ErrMsg &= "[" & lbl_CRM_CD.Text & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(BUSN_NO.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = BUSN_NO
                ErrMsg &= "[" & lbl_BUSN_NO.Text & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(BUSN_NM.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = BUSN_NM
                ErrMsg &= "[" & lbl_BUSN_NM.Text & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(CHIEF_NM.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = CHIEF_NM
                ErrMsg &= "[" & lbl_CHIEF_NM.Text & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(DETAIL_NM.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = DETAIL_NM
                ErrMsg &= "[" & lbl_DETAIL_NM.Text & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(USER_EMAIL.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = USER_EMAIL
                ErrMsg &= "[" & lbl_USER_EMAIL.Text & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(USER_AUTH_ID.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = USER_AUTH_ID
                ErrMsg &= "[" & lbl_USER_AUTH_ID.Text & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(MEMB_STATE.Value.ToString) Then
                If ErrControl Is Nothing Then ErrControl = MEMB_STATE
                ErrMsg &= "[" & lbl_MEMB_STATE.Text & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(USE_START_DT.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = USE_START_DT
                ErrMsg &= "[" & lbl_USE_START_DT.Text & "]을 입력해주세요." & vbNewLine
            End If

            If TAX_USE_YN.Checked = False AndAlso CRD_USE_YN.Checked = False Then
                If ErrControl Is Nothing Then ErrControl = TAX_USE_YN
                ErrMsg &= "[" & lbl_DOC_USE_YN.Text & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(NTS_SND_SET.Value.ToString) Then
                If ErrControl Is Nothing Then ErrControl = NTS_SND_SET
                ErrMsg &= "[" & lbl_NTS_SND_SET.Text & "]을 입력해주세요." & vbNewLine
            End If

            If String.IsNullOrEmpty(DOMAIN.Text.ToString) Then
                If ErrControl Is Nothing Then ErrControl = DOMAIN
                ErrMsg &= "거래처 관리에서 [" & lbl_DOMAIN.Text & "]을 입력해주세요." & vbNewLine
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            If btnValidate.Enabled = True Then
                If String.IsNullOrEmpty(USER_AUTH_ID_CHECK.Text.ToString) Then
                    MsgBoxLocalized("사업자 번호 [중복체크]를 하지 않아 저장할 수 없습니다. 확인하세요.")
                    Return False
                End If
            End If

            If btnValidate2.Enabled = True Then
                If Not String.IsNullOrEmpty(CSTM4_CD.Text.ToString) Then
                    If CSTM4_CD.Text.ToString <> USER_AUTH_ID.Text.ToString.Substring(0, 4) Then
                        MsgBoxLocalized("세관코드가 존재할 경우 자동부여버튼을 눌러주세요.")
                        Return False
                    End If
                End If

                If String.IsNullOrEmpty(USER_AUTH_ID_CHECK.Text.ToString) Then
                    MsgBoxLocalized("사용자 인증 ID [중복체크]를 하지 않아 저장할 수 없습니다. 확인하세요.")
                    Return False
                ElseIf USER_AUTH_ID.Text.ToString <> USER_AUTH_ID_CHECK.Text.ToString Then
                    MsgBoxLocalized("중복체크된 ID와 입력된 ID가 다릅니다." & vbNewLine & "중복체크된 ID [" & USER_AUTH_ID_CHECK.Text.ToString & "]")
                    Return False
                End If
            End If

            If USER_AUTH_ID.Text.Length <= 3 Then
                MsgBoxLocalized("사용자 인증 ID에 영문 4자리 기재 후 자동부여버튼을 눌러주세요.")
                USER_AUTH_ID.Focus()
                Return False
            ElseIf USER_AUTH_ID.Text.Length = 4 Then
                MsgBoxLocalized(" 자동부여버튼을 눌러주세요.")
                USER_AUTH_ID.Focus()
                Return False
            ElseIf USER_AUTH_ID.Text.Length < 6 Then
                MsgBoxLocalized("사용자 인증 ID는 6자리로 입력해주세요.")
                USER_AUTH_ID.Focus()
                Return False
            End If

            If String.IsNullOrEmpty(CSTM4_CD.Text.ToString) Then
                If String.IsNullOrEmpty(USER_AUTH_ID.Text.ToString) Then
                    MsgBoxLocalized("중복체크할 ID를 기재해주세요.")
                    Return False
                End If
            ElseIf CSTM4_CD.Text.ToString <> USER_AUTH_ID.Text.ToString.Substring(0, 4) Then
                MsgBoxLocalized("세관코드가 존재할 경우 자동부여버튼을 눌러주세요.")
                Return False
            End If

            If NTS_SND_SET.Value.ToString = "C" Then
                If String.IsNullOrEmpty(NTS_CLS_DAY.Value.ToString) Then
                    If ErrControl Is Nothing Then ErrControl = NTS_CLS_DAY
                    MsgBoxLocalized("[" & lbl_NTS_CLS_DAY.Text & "]을 입력해주세요." & vbNewLine)
                    Return False
                End If
            End If



            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
        Return True
    End Function
    Private Sub CrnValidate()
        If String.IsNullOrEmpty(BUSN_NO.Text.ToString) Then
            MsgBoxLocalized("사업자번호를 입력해주세요.")
            Exit Sub
        End If

        Dim ds As DataSet = GetConvertToDataSet("CrnValidate")
        Dim dr As DataRow

        Try
            ds = MethodCallEx(Me, "YJIT.Biz.EvbMembers", "Search", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            If ds.Tables("Data.MAIN").Rows.Count = 0 Then
                MsgBoxLocalized("사용가능한 사업자번호 입니다.")
                Call EnabledCheck("CrnValidate", False)
                CHIEF_NM.Focus()
            Else
                MsgBoxLocalized("해당 사업자번호는 이미 존재하는 사업자번호입니다.")
                BUSN_NO.Focus()
            End If
        Else
            MsgBoxLocalized(dr("TrxMsg"))
        End If
    End Sub
    Private Sub UserAuthIDValidate()
        If String.IsNullOrEmpty(CRM_CD.Text.ToString) Then
            MsgBoxLocalized("CRM 코드를 기재해주세요.")
            Exit Sub
        End If

        If USER_AUTH_ID.Text.ToString.Length <= 3 Then
            MsgBoxLocalized("사용자 인증 ID에 영문 4자리 기재 후 자동부여버튼을 눌러주세요.")
            USER_AUTH_ID.Focus()
            Exit Sub
        ElseIf USER_AUTH_ID.Text.ToString.Length = 4 Then
            MsgBoxLocalized(" 자동부여버튼을 눌러주세요.")
            USER_AUTH_ID.Focus()
            Exit Sub
        ElseIf USER_AUTH_ID.Text.ToString.Length < 6 Then
            MsgBoxLocalized("사용자 인증 ID는 6자리로 입력해주세요.")
            USER_AUTH_ID.Focus()
            Exit Sub
        End If

        If btnValidate2.Enabled = True Then
            If String.IsNullOrEmpty(CSTM4_CD.Text.ToString) Then
                If String.IsNullOrEmpty(USER_AUTH_ID.Text.ToString) Then
                    MsgBoxLocalized("중복체크할 ID를 기재해주세요.")
                    Exit Sub
                End If
            ElseIf CSTM4_CD.Text.ToString <> USER_AUTH_ID.Text.ToString.Substring(0, 4) Then
                MsgBoxLocalized("세관코드가 존재할 경우 자동부여버튼을 눌러주세요.")
                Exit Sub
            End If
        End If

        Dim ds As DataSet = GetConvertToDataSet("UserAuthIDValidate")

        Try
            ds = MethodCallEx(Me, "YJIT.Biz.EvbMembers", "Search", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            If ds.Tables("Data.MAIN").Rows.Count = 0 Then
                MsgBoxLocalized("사용가능한 ID 입니다.")
                USER_AUTH_ID_CHECK.Text = USER_AUTH_ID.Text.ToString
                MEMB_STATE.Focus()
            Else
                MsgBoxLocalized("해당 사용자 인증 ID는 이미 존재하는 ID입니다.")
                USER_AUTH_ID.Focus()
            End If
        Else
            MsgBoxLocalized(dr("TrxMsg"))
        End If
    End Sub
    Private Sub NavigateToPopUP(ByVal type As String)
        Select Case type
            Case "Charge"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("EvbChargeSet", UI.NavigatedWindowModes.Dialog, False)

                If fTarget IsNot Nothing Then
                    fTarget.ShowDialog()
                End If

                If fTarget.result = "N" Then Exit Sub

                BASE_AMT.Text = fTarget.GV1.GetRowCellValue(fTarget.GV1.FocusedRowHandle, "BASE_AMT").ToString
                BASE_TAX_CNT.Text = fTarget.GV1.GetRowCellValue(fTarget.GV1.FocusedRowHandle, "BASE_TAX_CNT").ToString
                TAX_PRICE.Text = fTarget.GV1.GetRowCellValue(fTarget.GV1.FocusedRowHandle, "TAX_PRICE").ToString
                CRD_PRICE.Text = fTarget.GV1.GetRowCellValue(fTarget.GV1.FocusedRowHandle, "CRD_PRICE").ToString
            Case "Discount"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("EvbDiscountSet", UI.NavigatedWindowModes.Dialog, False)

                If fTarget IsNot Nothing Then
                    fTarget.ShowDialog()
                End If
            Case "StmpUpload"
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("EvbStmpUpload", UI.NavigatedWindowModes.Dialog, False)

                fTarget.USER_AUTH_ID.Text = USER_AUTH_ID.Text

                If fTarget IsNot Nothing Then
                    fTarget.ShowDialog()
                End If

                If Not String.IsNullOrEmpty(fTarget.result) Then
                    STMP_FILE_NM.Text = fTarget.result
                End If
        End Select
    End Sub
    Private Sub AutoCreateCode()
        If String.IsNullOrEmpty(CSTM4_CD.Text.ToString) Then
            If String.IsNullOrEmpty(USER_AUTH_ID.Text.ToString) Then
                MsgBoxLocalized("사용자 인증 ID 4자리를 입력하세요.")
                USER_AUTH_ID.Focus()
                Exit Sub
            End If
        Else
            If CSTM4_CD.Text.Length <> 4 Then
                MsgBoxLocalized("세관코드는 4자리로 입력가능합니다.")
                ClearView(UI.AppliedRangeTypes.Only, {CSTM4_CD})
                CSTM4_CD.Focus()
                Exit Sub
            End If
            USER_AUTH_ID.Text = CSTM4_CD.Text.ToString
        End If

        Dim ds As DataSet = GetConvertToDataSet("AutoCreateKey")

        Try
            ds = MethodCallEx(Me, "YJIT.Biz.EvbMembers", "Search", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(ds, "Data")
            USER_AUTH_ID_CHECK.Text = USER_AUTH_ID.Text.ToString
            Me.DataState = UI.DataStates.Retrieved
        Else
            MsgBoxLocalized(dr("TrxMsg"))
        End If
    End Sub
#End Region
#Region "=================Control Events==========="
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub
    Private Sub btnSearch_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub EvbMembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call DrawRowIndicator(GV1)
    End Sub
    Private Sub EvbMembers_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call PopupInit()

        Call SearchData()
    End Sub
    'Private Sub GV1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
    '    Call SearchDetailData()
    'End Sub
    Private Sub BUSN_ADDR1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BUSN_ADDR1.KeyPress
        If (Split(sender.Text, vbNewLine).Length > 3) And AscW(e.KeyChar) = Keys.Enter Then
            e.KeyChar = String.Empty
            USER_NM.Focus()
        End If
    End Sub

    Private Sub TAX_FIX_NOTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TAX_FIX_NOTE.KeyPress
        If (Split(sender.Text, vbNewLine).Length > 3) And AscW(e.KeyChar) = Keys.Enter Then
            e.KeyChar = String.Empty
            CRD_FIX_NOTE.Focus()
        End If
    End Sub
    Private Sub CRD_FIX_NOTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CRD_FIX_NOTE.KeyPress
        If (Split(sender.Text, vbNewLine).Length > 3) And AscW(e.KeyChar) = Keys.Enter Then
            e.KeyChar = String.Empty
            MAIL_FIX_NOTE.Focus()
        End If
    End Sub
    Private Sub MAIL_FIX_NOTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MAIL_FIX_NOTE.KeyPress
        If (Split(sender.Text, vbNewLine).Length > 3) And AscW(e.KeyChar) = Keys.Enter Then
            e.KeyChar = String.Empty
            BASE_AMT.Focus()
        End If
    End Sub
    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Call CrnValidate()
    End Sub
    Private Sub btnSearchChag_Click(sender As Object, e As EventArgs) Handles btnSearchChag.Click
        Call NavigateToPopUP("Charge")
    End Sub
    Private Sub btnSearchDisc_Click(sender As Object, e As EventArgs) Handles btnSearchDisc.Click
        Call NavigateToPopUP("Discount")
    End Sub
    Private Sub btnValidate2_Click(sender As Object, e As EventArgs) Handles btnValidate2.Click
        Call UserAuthIDValidate()
    End Sub
    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        Call AutoCreateCode()
    End Sub
    Private Sub USER_AUTH_ID_EnabledChanged(sender As Object, e As EventArgs) Handles USER_AUTH_ID.EnabledChanged
        If USER_AUTH_ID.Enabled = True Then
            USER_EMAIL.NextFocus = "USER_AUTH_ID"
            USER_AUTH_ID.NextFocus = "MEMB_STATE"
        Else
            USER_EMAIL.NextFocus = "MEMB_STATE"
        End If
    End Sub
    Private Sub CRM_NM_TextChanged(sender As Object, e As EventArgs) Handles CRM_NM.TextChanged
        '20210312 정지수 신규 클릭 시 CRM_CD가 재검색되면서 완전히 CLEAR되지 않는 현상 수정
        If String.IsNullOrEmpty(CRM_CD.Text) OrElse String.IsNullOrEmpty(CRM_NM.Text) Then Exit Sub

        Call SearchCustData()
    End Sub
    Private Sub btnStmp_Click(sender As Object, e As EventArgs) Handles btnStmp.Click
        Call NavigateToPopUP("StmpUpload")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub GV1_RowClick(sender As Object, e As RowClickEventArgs) Handles GV1.RowClick
        Call SearchDetailData()
    End Sub
    Dim bGV1_FocusedRowChanged As Boolean = False
    Private Sub GV1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Try
            If GV1.RowCount = 0 Then Exit Sub
            If GV1.IsValidRowHandle(e.FocusedRowHandle) = False Then Exit Sub

            If e.PrevFocusedRowHandle >= 0 Then bGV1_FocusedRowChanged = True
            Call SearchDetailData()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub NE_EMAIL_YN_CheckedChanged(sender As Object, e As EventArgs) Handles NE_EMAIL_YN.CheckedChanged

    End Sub
#End Region
End Class