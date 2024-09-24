Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing

Public Class CrmCustomize

    Dim langChk As Boolean = False

#Region "=================Data logic actions==========="
    Public Sub GridInit()

        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)
        Dim editorDate As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit

        Dim dt2 As New DataTable
        dt2.Columns.Add(New DataColumn("CODE", GetType(String)))
        dt2.Columns.Add(New DataColumn("NAME", GetType(String)))

        ' Date
        editorDate = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
        GV1.Columns("CUSTOM_YMD").ColumnEdit = editorDate
        GV3.Columns("ISSUED_YMD").ColumnEdit = editorDate
        GV4.Columns("ESTM_YMD").ColumnEdit = editorDate

        '비용 내역 항목
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C04")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV2.Columns("CUST_ITEM").ColumnEdit = editorCombo

        '자금 집행 계획 항목
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C04")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV3.Columns("FUND_ITEM").ColumnEdit = editorCombo

    End Sub
    'Popup Setting
    Private Sub PopupInit()
        Dim PopUp As New PopupBase

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG2_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG2_DELETEROW", "Delete row")
        PopUp.PopUpInit(Me, WG2, "CUST_ITEM", "CUST_DTL")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG3_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG3_DELETEROW", "Delete row")
        PopUp.PopUpInit(Me, WG3, "FUND_ITEM", "FUND_RMK")

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG4_ADDROW", "Add row", True)
        PopUp.ItemAdd(Action.DeleteRow, "WG4_DELETEROW", "Delete row")
        PopUp.PopUpInit(Me, WG4, "ESTM_YMD", "ESTM_RMK")
    End Sub

    Private Sub SearchCustomer()

        CUST_NM.Text = ""

        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmAsMgt", "SearchCustomer", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "M" Then
            Call SetCustByList(ds)
            Exit Sub
        End If

        If dr("TrxCode").ToString <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg").ToString, MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
            Exit Sub
        Else
            CUST_CD.Text = dr("CUST_CD").ToString
            CUST_NM.Text = dr("CUST_NM").ToString
            CUST_CD.Focus()
        End If

    End Sub

    Private Sub SetCustByList(ByVal ds As DataSet)

        PanelControl2.Controls.Add(CUST_LIST)
        CUST_LIST.Location = New Size(CUST_CD.Location.X, CUST_CD.Location.Y + 1)
        CUST_CD.BringToFront()

        CUST_LIST.EditValue = ""
        CUST_LIST.DataBindings.Clear()
        CUST_LIST.Properties.DataSource = Nothing

        CUST_LIST.Properties.DataSource = ds.Tables("Data.CUST_LIST")
        CUST_LIST.Properties.DisplayMember = "CUST_LOC_NM"
        CUST_LIST.Properties.ValueMember = "CUST_CD"
        CUST_LIST.EditValue = Nothing
        CUST_LIST.ShowPopup()
        CUST_LIST.Focus()

    End Sub

    Private Sub GV1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle

        If e.Column.FieldName = "PROFITS" Then
            If IsNumeric(e.CellValue) Then
                If e.CellValue < 0 Then
                    e.Appearance.ForeColor = System.Drawing.Color.Red
                ElseIf e.CellValue > 0 Then
                    e.Appearance.ForeColor = System.Drawing.Color.Blue
                End If
            End If
        End If

    End Sub

    Public Sub PrintData(ByVal MngtNo As String, ByVal CustCode As String)

        If MsgBoxLocalized("Do you want to print?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        Dim dt As DataTable = Nothing
        Dim FileName As String = ""
        Dim ds As DataSet = Nothing

        Dim params() As Object = {MngtNo, CustCode}

        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmCustomizing", "Print", params, AddressOf PrintOnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Private Sub PrintOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)

        Dim dsRet As DataSet = e.Result
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        Dim rpt As DevExpress.XtraReports.UI.XtraReport
        Dim FileName As String = ""
        Dim RptParameters As New Dictionary(Of String, Object)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Print", MessageBoxIcon.Error)
            Exit Sub
        End If


        Try
            FileName = "ElvisCustomizing.repx"

            rpt = RptBaseSetting("CRM", FileName, dsRet, RptParameters)

            Dim ndt As DataTable
            Dim nDs As DataSet
            Dim SubRpt As DevExpress.XtraReports.UI.XtraReport

            If Not rpt Is Nothing Then
                'Sub Summary
                Dim obj = rpt.FindControl("ElvisCustomizing_Sub3", True)
                If Not obj Is Nothing Then
                    nDs = New DataSet
                    ndt = dsRet.Tables("Detail3").Copy
                    nDs.Tables.Add(ndt)

                    For i As Integer = ndt.Rows.Count + 1 To 5
                        ndt.Rows.Add()
                    Next

                    If ndt.Rows.Count > 0 Then

                        If obj.GetType.FullName = "DevExpress.XtraReports.UI.XRSubreport" Then
                            SubRpt = New DevExpress.XtraReports.UI.XtraReport
                            SubRpt.LoadLayout(Common.ReportPath & "CRM\ElvisCustomizing_Sub3.repx")
                            SubRpt.DataSource = nDs
                            SubRpt = TryRptParam(SubRpt, RptParameters)
                            SubRpt.RequestParameters = False
                            CType(obj, DevExpress.XtraReports.UI.XRSubreport).ReportSource = SubRpt
                        End If
                    End If
                End If



                obj = rpt.FindControl("ElvisCustomizing_Sub2", True)
                If Not obj Is Nothing Then
                    nDs = New DataSet
                    ndt = dsRet.Tables("Detail2").Copy
                    nDs.Tables.Add(ndt)

                    For i As Integer = ndt.Rows.Count + 1 To 5
                        ndt.Rows.Add()
                    Next

                    If ndt.Rows.Count > 0 Then

                        If obj.GetType.FullName = "DevExpress.XtraReports.UI.XRSubreport" Then
                            SubRpt = New DevExpress.XtraReports.UI.XtraReport
                            SubRpt.LoadLayout(Common.ReportPath & "CRM\ElvisCustomizing_Sub2.repx")
                            SubRpt.DataSource = nDs
                            SubRpt = TryRptParam(SubRpt, RptParameters)
                            SubRpt.RequestParameters = False
                            CType(obj, DevExpress.XtraReports.UI.XRSubreport).ReportSource = SubRpt
                        End If
                    End If
                End If

                obj = rpt.FindControl("ElvisCustomizing_Sub1", True)
                If Not obj Is Nothing Then
                    nDs = New DataSet
                    ndt = dsRet.Tables("Detail1").Copy
                    nDs.Tables.Add(ndt)

                    For i As Integer = ndt.Rows.Count + 1 To 5
                        ndt.Rows.Add()
                    Next

                    If ndt.Rows.Count > 0 Then

                        If obj.GetType.FullName = "DevExpress.XtraReports.UI.XRSubreport" Then
                            SubRpt = New DevExpress.XtraReports.UI.XtraReport
                            SubRpt.LoadLayout(Common.ReportPath & "CRM\ElvisCustomizing_Sub1.repx")
                            SubRpt.DataSource = nDs
                            SubRpt = TryRptParam(SubRpt, RptParameters)
                            SubRpt.RequestParameters = False
                            CType(obj, DevExpress.XtraReports.UI.XRSubreport).ReportSource = SubRpt
                        End If
                    End If
                End If
            End If


            If rpt IsNot Nothing Then
                ReportPrintTool(rpt)
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Private Sub DeleteData()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim insFlag As String = ""

        Try
            If MsgBoxLocalized("Do you want to delete?", MessageBoxButtons.YesNo, "Delete", MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then Exit Sub

            Dim params() As Object = {CUST_CD.Text, MNGT_NO.Text}

            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmCustomizing", "Delete", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message, MessageBoxButtons.OK, "Delete", MessageBoxIcon.Error)
            Exit Sub
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Delete", MessageBoxIcon.Error)
        Else
            Me.BindToDataset(ds, "Data")
            ClearView(AppliedRangeTypes.Only, {MNGT_NO, CUSTOM_YMD, DOWN_PAY, PROFITS, TOT_AMT, DEVELOPER, REQUESTOR, CUSTOM_DTL})
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
        End If
        Me.DataState = UI.DataStates.Retrieved

        Call SearchData()

    End Sub

    Public Sub NewData()
        ClearView(UI.AppliedRangeTypes.Except, {CUST_CD, CUST_NM, WG1})
        CUSTOM_YMD.Focus()
        Me.DataState = DataStates.New
    End Sub
    Public Sub SearchData()

        If CUST_CD.Text = "" Then
            MsgBox("거래처를 입력하세요.")
            CUST_CD.Focus()
            Exit Sub
        End If

        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmCustomizing", "Search", Me.ConvertToDataset, AddressOf SearchOnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub SearchOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again !")
            End If

            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)


            If dr("TrxCode") <> "Y" Then
                ClearView(UI.AppliedRangeTypes.Except, {CUST_CD, CUST_NM})
                MsgBoxLocalized(dr("TrxMsg"))
                CUSTOM_YMD.Focus()
                Exit Sub
            End If

            Me.BindToDataset(ds, "Data")
            Call SearchDetail()
            Me.DataState = UI.DataStates.Retrieved

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub SearchDetail()
        Try
            If GV1.RowCount = 0 Then Exit Sub

            Dim params() As Object = {GV1.GetFocusedRowCellValue("MNGT_NO").ToString(), CUST_CD.Text}
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmCustomizing", "SearchDetail", params, AddressOf searchDetailOnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub searchDetailOnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)

        Try
            If IsNothing(e.Result) Then
                Throw New Exception("Try Again!")
            End If
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            ClearView(UI.AppliedRangeTypes.Except, {WG1, CUST_CD, CUST_NM})

            Me.BindToDataset(ds, "Data")
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If

            Me.DataState = UI.DataStates.Retrieved
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try

    End Sub

    Public Sub SaveData()
        If CUST_CD.Text = "" Then
            MsgBox("거래처를 입력하세요.")
            CUST_CD.Focus()
            Exit Sub
        End If

        If CUSTOM_YMD.Text = "" Then
            MsgBoxLocalized("일자를 입력해주세요.", MessageBoxButtons.OK, "Save", MessageBoxIcon.Error)
            CUSTOM_YMD.Focus()
            Exit Sub
        End If

        If DOWN_PAY.Text = "0" Then
            MsgBoxLocalized("계약금을 입력해주세요.", MessageBoxButtons.OK, "Save", MessageBoxIcon.Error)
            DOWN_PAY.Focus()
            Exit Sub
        End If

        ' Grid DeleteRow Check
        If MandatoryGridValue("GV1") Then Exit Sub
        If MandatoryGridValue("GV2") Then Exit Sub
        If MandatoryGridValue("GV3") Then Exit Sub
        If MandatoryGridValue("GV4") Then Exit Sub

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim insFlag As String = ""

        If MNGT_NO.Text = "" Then
            insFlag = "I"
        Else
            insFlag = "U"
        End If
        'Select Case Me.DataState

        '    Case UI.DataStates.New
        '        insFlag = "I"
        '    Case Else
        '        insFlag = "U"
        'End Select

        Dim ds As DataSet = New DataSet
        ds = Me.ConvertToDataset

        Dim params() As Object = {insFlag, ds}

        Dim dsResult As DataSet
        Try
            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmCustomizing", "Save", params)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        Dim dr As DataRow
        dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") = "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
            Me.BindToDataset(dsResult, "Data")
            Me.DataState = UI.DataStates.Retrieved

            For i As Integer = 0 To GV1.RowCount - 1
                If GV1.GetRowCellValue(i, "MNGT_NO").ToString = ds.Tables("MAIN").Rows(0).Item("MNGT_NO").ToString Then
                    GV1.FocusedRowHandle = i
                    Exit For
                End If
            Next

            'For i As Integer = 0 To GV1.RowCount - 1
            '    If GV1.GetRowCellValue(i, "MNGT_NO").ToString = MngtNo Then
            '        GV1.FocusedRowHandle = i
            '        Exit For
            '    End If
            'Next

            Call SearchDetail()
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing

        Select Case gridView
            Case "GV1"
                'checkNull = {"DOWN_PAY"}
                Param("DOWN_PAY") = GV1_DOWN_PAY.Caption
                Param("CUSTOM_YMD") = GV1_CUSTOM_YMD.Caption

                Return ValidateGridValue(GV1, Param, checkNull)

            Case "GV2"
                'checkNull = {"CUST_COST"}
                Param("CUST_COST") = GV2_CUST_COST.Caption
                Param("CUST_ITEM") = GV2_CUST_ITEM.Caption
                Return ValidateGridValue(GV2, Param, checkNull)

            Case "GV3"
                'checkNull = {"SALES_VAL", "BUY_VAL"}
                Param("SALES_VAL") = GV3_SALES_VAL.Caption
                Param("BUY_VAL") = GV3_BUY_VAL.Caption
                Param("FUND_ITEM") = GV3_FUND_ITEM.Caption
                Param("ISSUED_YMD") = GV3_ISSUED_YMD.Caption

                Return ValidateGridValue(GV3, Param, checkNull)

            Case "GV4"
                'checkNull = {"ESTM_COST"}
                Param("ESTM_COST") = GV4_ESTM_COST.Caption
                Param("ESTM_YMD") = GV4_ESTM_YMD.Caption

                Return ValidateGridValue(GV4, Param, checkNull)
        End Select

        Return False
    End Function

#End Region

#Region "=================Control Events==========="
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub WG1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WG1.Click
        If GV1.RowCount = 0 Then
            Exit Sub
        End If
        Call SearchDetail()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Call DeleteData()
    End Sub

    Private Sub CrmCustomize_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        CUST_CD.Focus()
        Call GridInit()
        Call PopupInit()

        CUST_CD.TextCasing = TextCasings.Upper

        Common.DrawRowIndicator(GV1)
        Common.DrawRowIndicator(GV2)
        Common.DrawRowIndicator(GV3)
        Common.DrawRowIndicator(GV4)
    End Sub

    Private Sub CUST_CD_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CUST_CD.PreviewKeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Call SearchCustomer()
        End If
    End Sub
    Private Sub CUST_LIST_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUST_LIST.EditValueChanged
        If CUST_LIST.EditValue = "" Then Exit Sub
        CUST_CD.Text = CUST_LIST.EditValue

        Call SearchCustomer()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If CUST_CD.Text = "" Then
            MsgBox("거래처를 입력하세요.")
            CUST_CD.Focus()
            Exit Sub
        End If

        Call PrintData(GV1.GetFocusedRowCellValue("MNGT_NO").ToString(), CUST_CD.Text)
    End Sub
#End Region

    Private Sub CrmCustomize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class