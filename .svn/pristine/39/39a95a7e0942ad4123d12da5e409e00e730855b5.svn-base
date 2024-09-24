Imports System.Reflection
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid

Public Class MdmUserMgt

    Dim searchFlag As Boolean = False

#Region "=================Data logic actions==========="

    Public Sub SearchData()
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.MdmUserMgt", "Search", Me.ConvertToDataset, AddressOf search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            Me.ClearView(AppliedRangeTypes.Except, {S_USR_ID, S_USR_NM, S_USE_YN, S_USER_CNT_YN})

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If

            Me.BindToDataset(ds, "Data")

            Call SearchDetail()
            Me.DataState = UI.DataStates.Retrieved

            searchFlag = True

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SearchDetail()
        Try
            If GV1.RowCount = 0 Then
                Exit Sub
            End If
            Dim params() As Object = {GV1.GetFocusedRowCellValue("USR_ID").ToString()}
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.MdmUserMgt", "SearchDetail", params, AddressOf search_OnComplete2)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SearchDetail(ByVal UserId As String)
        Try
            If GV1.RowCount = 0 Then
                Exit Sub
            End If
            Dim params() As Object = {UserId}
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.MdmUserMgt", "SearchDetailOffice", params, AddressOf search_OnComplete2)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub Search()
        Try
            Dim ds As DataSet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmUserMgt", "Search", Me.ConvertToDataset)
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG1})
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If

            Me.BindToDataset(ds, "Data")

            Me.DataState = UI.DataStates.Retrieved
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub search_OnComplete2(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)

        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            ClearView(UI.AppliedRangeTypes.Except, {WG1, S_USR_ID, S_USR_NM, S_USE_YN, S_USER_CNT_YN, USR_ID, USE_YN})

            Me.BindToDataset(ds, "Data")
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If

            ' Password editable = false
            Call EnableControls(AppliedRangeTypes.Only, {USR_ID, PSWD, PSWD1}, False)
            'Call SetPrintType()
            Me.DataState = UI.DataStates.Retrieved
            'MAIN_BL_FORM.EditValue = ds.Tables("data.MAIN").Rows(0)("MAIN_BL_FORM").ToString
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub SaveData()

        If ValidateOfficeValue(Me) Then Exit Sub

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        If (Me.DataState = UI.DataStates.New) Then
            If (PSWD.Text = "") Then
                MsgBoxLocalized("Password cannot be empty!")
                PSWD.Focus()
                Exit Sub
            End If
            If (PSWD.Text <> PSWD1.Text) Then
                MsgBoxLocalized("Password didn't match!")
                PSWD.Focus()
                Exit Sub
            End If
        End If

        Dim ds As DataSet = Me.ConvertToDataset
        Dim dt1 As DataTable = ds.Tables("WG1")

        Dim dsResult As DataSet
        Dim dr As DataRow
        If (Me.DataState <> UI.DataStates.Modified) Then
            If USR_ID.Text <> "" Then
                Dim params() As Object = {USR_ID.Text}
                dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmUserMgt", "ValidateUserId", params)
                dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
                If dr("TrxCode") <> "Y" Then
                    MsgBoxLocalized("User ID cannot be duplicated!")
                    Exit Sub
                End If
            End If
        End If
        
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmUserMgt", "Save", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Me.BindToDataset(dsResult, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If

        MsgBoxLocalized(dr("TrxMsg"))

    End Sub

    Public Sub InitLookUp()
        Try
            Dim ds As DataSet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmUserMgt", "InitLookUp", Me.ConvertToDataset)
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            Dim dt As DataTable = ds.Tables("Data.Main")


            Dim bv As BandedGridView = New BandedGridView()
            Dim gb As GridBand = New GridBand()
            gb.Caption = "Program Group"

            Dim bgc As BandedGridColumn = bv.Columns.AddField("PGM_GRP")
            bgc.OwnerBand = gb
            bgc.Caption = "Program group"
            bgc.Visible = False
            bgc.GroupIndex = 0

            bgc = bv.Columns.AddField("PGM_ID")
            bgc.Caption = "Program Id"
            bgc.OwnerBand = gb
            bgc.Visible = True

            bgc = bv.Columns.AddField("PGM_NM")
            bgc.Caption = "Program Name"
            bgc.OwnerBand = gb
            bgc.Visible = True

            Me.DataState = UI.DataStates.Retrieved
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub NewData()
        ClearView(UI.AppliedRangeTypes.Except, {WG1, S_USR_ID, S_USR_NM})

        ' Password editable = true
        Call EnableControls(AppliedRangeTypes.Only, {USR_ID, PSWD, PSWD1}, True)
        
        ' 사업장정보 설정
        USE_YN.SelectedValue = "Y"

        S_USE_YN.SelectedValue = "Y"
        S_USER_CNT_YN.SelectedValue = "Y"

        Me.DataState = UI.DataStates.New
        USR_ID.Focus()
    End Sub

    Private Sub InitLoad()

        ClearView()

        S_USE_YN.SelectedValue = "Y"
        S_USER_CNT_YN.SelectedValue = "Y"

        '암호화 확인 되어있는지 확인 ENC 노경선 씨만 확인 가능 (AEO인증 제출용)
        If ClientSessionOfficeInfo.HqOfficeCode = "ENCHQ" AndAlso ClientSessionInfo.UserID = "RKS" Then
            GV1_PSWD.Visible = True
            GV1_PSWD.VisibleIndex = 3
            GV1_PSWD_CHG_YMD.Visible = True
        Else
            GV1_PSWD.Visible = False
        End If

        Call InitLookUp()

        Call SearchData()
        SetMandatoryLine(Me)



    End Sub

#End Region

#Region "=================Control Events================="

    Private Sub MdmUserMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call DrawRowIndicator(GV1)
        USE_YN.SelectedValue = "Y"
        S_USE_YN.SelectedValue = "Y"
        S_USER_CNT_YN.SelectedValue = "Y"
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        SaveData()
    End Sub

    Private Sub MdmUserMgt_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        InitLoad()
        Call PopUpInit()

        If ClientSessionInfo.AuthorizationType.Substring(0, 1) = "0" Then
            S_USER_CNT_YN.Visible = True
        Else
            S_USER_CNT_YN.Visible = False
        End If
    End Sub
    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_ExcelExport", "Excel Export")
        PopUp.PopUpInit(Me, WG1, "USR_ID")
    End Sub

    Private Sub WG1_Click(sender As System.Object, e As System.EventArgs) Handles WG1.Click
        SearchDetail()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub

    Private Sub S_OFFICE_CD_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If searchFlag = True Then
            Call SearchData()
        End If
    End Sub

    Private Sub USR_ID_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles USR_ID.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) And USR_ID.Text <> "" Then
            Call SearchDetail(USR_ID.Text)
        End If
    End Sub
#End Region
End Class