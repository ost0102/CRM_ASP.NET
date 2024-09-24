Imports System.Drawing
Imports System.Drawing.Icon
Imports YJIT.SC.UI
Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Collections.Specialized
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPivotGrid

Public Class CrmArMgt

#Region "=================Data logic actions==========="

    Public Sub PopupInit()
        Dim PopUp As New PopupBase

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Excel, "WG1_Excel", Me.Localizer.GetLocalizedString("&Export Excel"), True)
        PopUp.PopUpInit(Me, WG1)
    End Sub

    Private Sub InitGrid()
        Dim dtComboSource As DataTable
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim editorDate As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit

        editorDate = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV1.Columns("STOP_YMD").ColumnEdit = editorDate
        GV1.Columns("INFO_YMD").ColumnEdit = editorDate
        GV1.Columns("CREDIT_YMD").ColumnEdit = editorDate

        dtComboSource = New DataTable : dtComboSource.Columns.Add("CODE", GetType(String)) : dtComboSource.Columns.Add("NAME", GetType(String))
        dtComboSource.Rows.Add("Y", "Yes")
        dtComboSource.Rows.Add("N", "No")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DataSource = dtComboSource
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.ShowHeader = False
        editorCombo.NullText = ""
        GV1.Columns("INFO_YN").ColumnEdit = editorCombo
        GV1.Columns("STOP_YN").ColumnEdit = editorCombo
        GV1.Columns("USE_YN").ColumnEdit = editorCombo

        dtComboSource = New DataTable : dtComboSource.Columns.Add("CODE", GetType(String)) : dtComboSource.Columns.Add("NAME", GetType(String))
        dtComboSource.Rows.Add("A", "일반")
        dtComboSource.Rows.Add("B", "악성")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DataSource = dtComboSource
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.ShowHeader = False
        editorCombo.NullText = ""
        GV1.Columns("AR_TYPE").ColumnEdit = editorCombo

        dtComboSource = New DataTable : dtComboSource.Columns.Add("CODE", GetType(String)) : dtComboSource.Columns.Add("NAME", GetType(String))
        dtComboSource.Rows.Add("A", "고객사")
        dtComboSource.Rows.Add("B", "영업")
        dtComboSource.Rows.Add("C", "개발")
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.DataSource = dtComboSource
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.ShowHeader = False
        editorCombo.NullText = ""
        GV1.Columns("ISSUE_TYPE").ColumnEdit = editorCombo

    End Sub
    Public Sub SearchData()
        'If the sql lenght is long enough, It cannot be parsed into xml. So first we delete sql and than pass the dataset
        Dim ds As DataSet = Me.ConvertToDataset
        'ds.Tables.Remove("WG1")
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmArMgt", "Search", ds, AddressOf search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG1})
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SaveData()
        Dim chkCnt As Integer = 0

        For i As Integer = 0 To GV1.RowCount - 1
            If GV1.GetRowCellValue(i, "CHK_FLAG") = "Y" Then
                chkCnt = chkCnt + 1
            End If
        Next

        'Slip Count Check
        If chkCnt = 0 Then
            MsgBoxLocalized("No data checked!", MessageBoxButtons.OK, "Save", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        ds = Me.ConvertToDataset

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim params As DataSet = ds

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmArMgt", "Save", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Save", MessageBoxIcon.Information)

        If dr("TrxCode") = "Y" Then
            Call SearchData()
        End If

    End Sub
    '20240520 김정현 미수금액 갱신 로직 추가
    Private Sub RefreshRecAmt()
        Dim ds As DataSet = New DataSet

        If MsgBoxLocalized("모든 업체의 미수금액을 일괄 갱신하시겠습니까?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmArMgt", "RefreshRecAmt", Me.ConvertToDataset)

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK)
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
        End If
        SearchData()
    End Sub

#End Region
#Region "=================Control Events==========="

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub CrmArMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call DrawRowIndicator(GV1)
        Call InitGrid()
    End Sub

    Private Sub GV1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GV1.DoubleClick
        If GV1.RowCount = 0 Then
            Exit Sub
        End If

        If GV1.IsGroupRow(GV1.FocusedRowHandle) = True Then
            Exit Sub
        End If

        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        frmMain = Me.MdiParent

        Select Case GV1.FocusedColumn.FieldName
            Case "CUST_CD"
                fTarget = frmMain.NavigateTo("CrmCustomerMgt")
                If Not IsNothing(fTarget) Then
                    fTarget.SEARCH_TYPE.SelectedValue = "CUST_CD"
                    fTarget.SEARCH_KEY.Text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                    fTarget.SearchData()
                End If

            Case "OUTSTAND_AMT"
                fTarget = frmMain.NavigateTo("CrmArList", NavigatedWindowModes.Dialog, False)
                If Not IsNothing(fTarget) Then
                    fTarget.S_CUST_CD.Text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                    fTarget.S_CUST_NM.Text = GV1.GetFocusedRowCellValue("CUST_NM").ToString
                    fTarget.SearchData()
                    fTarget.ShowDialog()
                End If

            Case "AR_SEND_YN"
                fTarget = frmMain.NavigateTo("CrmAsList")
                If Not IsNothing(fTarget) Then
                    fTarget.S_CUST_CD.Text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                    fTarget.S_CUST_NM.Text = GV1.GetFocusedRowCellValue("CUST_NM").ToString
                    fTarget.S_FM_YMD.Text = "20191001"
                    fTarget.S_TO_YMD.Text = GV1.GetFocusedRowCellValue("AR_SEND_YN").ToString
                    fTarget.S_REQ_SVC.SelectedValue = "AR"
                    fTarget.S_REQ_SVC2.SelectedValue = "AR001"
                    fTarget.SearchData()
                End If

            Case "STOP_SEND"
                fTarget = frmMain.NavigateTo("CrmAsList")
                If Not IsNothing(fTarget) Then
                    fTarget.S_CUST_CD.Text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                    fTarget.S_CUST_NM.Text = GV1.GetFocusedRowCellValue("CUST_NM").ToString
                    fTarget.S_FM_YMD.Text = "20191001"
                    fTarget.S_TO_YMD.Text = GV1.GetFocusedRowCellValue("STOP_SEND").ToString
                    fTarget.S_REQ_SVC.SelectedValue = "AR"
                    fTarget.S_REQ_SVC2.SelectedValue = "AR002"
                    fTarget.SearchData()
                End If

            Case "CFRM_SEND"
                fTarget = frmMain.NavigateTo("CrmAsList")
                If Not IsNothing(fTarget) Then
                    fTarget.S_CUST_CD.Text = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                    fTarget.S_CUST_NM.Text = GV1.GetFocusedRowCellValue("CUST_NM").ToString
                    fTarget.S_FM_YMD.Text = "20191001"
                    fTarget.S_TO_YMD.Text = GV1.GetFocusedRowCellValue("CFRM_SEND").ToString
                    fTarget.S_REQ_SVC.SelectedValue = "AR"
                    fTarget.S_REQ_SVC2.SelectedValue = "AR003"
                    fTarget.SearchData()
                End If
        End Select

    End Sub
    Private Sub SendMail(ByVal SendType As SendMailType)
        'If SendMailValidate(SendType) = False Then Exit Sub

        Select Case SendType
            Case SendMailType.ARInfo
                Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
                Dim fTarget As Object = Nothing
                frmMain = Me.MdiParent
                fTarget = frmMain.NavigateTo("ComSendMail", NavigatedWindowModes.Dialog, False)
                If Not IsNothing(fTarget) Then
                    fTarget.S_CUST_CD.TEXT = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                    fTarget.S_MSG_TYPE.Text = "201" '미수안내문
                    fTarget.S_MSG_TYPE2.Text = "201"
                    fTarget.ShowDialog()
                End If
            Case SendMailType.STOPInfo
                Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
                Dim fTarget As Object = Nothing
                frmMain = Me.MdiParent
                fTarget = frmMain.NavigateTo("ComSendMail", NavigatedWindowModes.Dialog, False)
                If Not IsNothing(fTarget) Then
                    fTarget.S_CUST_CD.TEXT = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                    fTarget.S_MSG_TYPE.Text = "202" '중지안내문
                    fTarget.S_MSG_TYPE2.Text = "202"
                    fTarget.ShowDialog()
                End If
            Case SendMailType.CONFIRMInfo
                Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
                Dim fTarget As Object = Nothing
                frmMain = Me.MdiParent
                fTarget = frmMain.NavigateTo("ComSendMail", NavigatedWindowModes.Dialog, False)
                If Not IsNothing(fTarget) Then
                    fTarget.S_CUST_CD.TEXT = GV1.GetFocusedRowCellValue("CUST_CD").ToString
                    fTarget.S_MSG_TYPE.Text = "203" '지불확약서
                    fTarget.S_MSG_TYPE2.Text = "203"
                    fTarget.ShowDialog()
                End If
        End Select
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub btnArNotice_Click(sender As System.Object, e As System.EventArgs) Handles btnArNotice.Click
        MsgBoxLocalized("개발중입니다.")
        'Call SendMail(SendMailType.ARInfo)
    End Sub

    Private Sub btnStopNotice_Click(sender As System.Object, e As System.EventArgs) Handles btnStopNotice.Click
        MsgBoxLocalized("개발중입니다.")
        'Call SendMail(SendMailType.STOPInfo)
    End Sub

    Private Sub btnRcvConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnRcvConfirm.Click
        MsgBoxLocalized("개발중입니다.")
        'Call SendMail(SendMailType.CONFIRMInfo)
    End Sub

    'Private Sub GV1_RowStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GV1.RowStyle
    '    If GV1 Is Nothing Then Exit Sub
    '    If GV1.RowCount = 0 Then Exit Sub
    '    If e.RowHandle < 0 Then Exit Sub

    '    If GV1.GetRowCellValue(e.RowHandle, "STOP_YN").ToString = "Y" And GV1.GetRowCellValue(e.RowHandle, "STOP_DELAY").ToString = "N" Then
    '        e.Appearance.BackColor = Color.IndianRed
    '    ElseIf GV1.GetRowCellValue(e.RowHandle, "STOP_YN").ToString = "Y" And GV1.GetRowCellValue(e.RowHandle, "STOP_DELAY").ToString = "Y" Then
    '        e.Appearance.BackColor = Color.LightPink
    '    End If
    'End Sub

    Private Sub GV1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle
        If GV1 Is Nothing Then Exit Sub
        If GV1.RowCount = 0 Then Exit Sub
        If e.RowHandle < 0 Then Exit Sub

        Select Case e.Column.FieldName
            Case "AR_CNT"
                If GV1.GetRowCellValue(e.RowHandle, "STOP_YMD").ToString <> "" And GV1.GetRowCellValue(e.RowHandle, "CREDIT_YMD").ToString = "" Then
                    e.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
                    e.Appearance.BackColor = Color.IndianRed
                ElseIf GV1.GetRowCellValue(e.RowHandle, "STOP_YMD").ToString <> "" And GV1.GetRowCellValue(e.RowHandle, "CREDIT_YMD").ToString <> "" Then
                    e.Appearance.BackColor = Color.LightPink
                End If
        End Select
    End Sub

    Private Sub CrmArMgt_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Call PopupInit()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call RefreshRecAmt()
    End Sub

#End Region

End Class