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

Public Class CrmInvoiceMgt
#Region "=================Client Function==========="
    Private Sub GridInit()
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As New Dictionary(Of String, Object)
        Dim dataParams As New Dictionary(Of String, Object)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C01")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV3.Columns("SVC_CD").ColumnEdit = editorCombo

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = "--Select--"
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "C03")
        dataParams.Add("NameType", "")
        dataParams.Add("Valid", "V")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV3.Columns("DEPT_CD").ColumnEdit = editorCombo

        Common.DrawRowIndicator({GV1, GV2, GV3})

    End Sub
    Public Sub NewData()
        CUST_ADDR.TextAlign = 1 'TopLeft
        ClearView()
        COCD.ReadOnly = False
        COCD.Enabled = True
        COCD.Text = ""
        COCD.Focus()
    End Sub
    Private Sub WG1AddrowDefultSetting(ByVal rowhandle As Integer)
        WG1_SINGLEPUB.SelectedValue = "N"
        WG1_INDIVIDUAL.SelectedValue = "N"
        WG1_MODIFYGB.SelectedValue = "N"
        GV1.SetFocusedRowCellValue("SINGLEPUB", "N")
        GV1.SetFocusedRowCellValue("INDIVIDUAL", "N")
        GV1.SetFocusedRowCellValue("MODIFYGB", "N")
        GV1.FocusedColumn = GV1.Columns("COMN_CD")
        WG1_COMN_CD.Focus()
    End Sub

    Public Sub PopupInit()
        Dim PopUp As PopupBase

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Addrow, "Addrow", "&Addrow")
        PopUp.PopUpInit(Me, WG1)
    End Sub

    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim r As Integer = 0
        Dim Key As String = Dr("Key")
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing
        Select Case Dr("Action") 
            Case Action.Addrow
                Select Case Key
                    Case "WG1"
                        WG1AddrowDefultSetting(GV1.FocusedRowHandle)
                End Select
             
        End Select 
    End Sub

#End Region

#Region "=================Data logic actions==========="
    Private Sub SearchData()
        Dim dsRet As New DataSet

        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.CrmInvoiceMgt", "Search", Me.ConvertToDataset, AddressOf search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)



        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
                Exit Sub
            End If

            Me.BindToDataset(ds, "Data")
            If GV1.RowCount = 0 Then
                WG1.AddRow()
                WG1AddrowDefultSetting(GV1.FocusedRowHandle)
            End If
            DisplayTotal()
            WG1_COMN_CD.Focus()
            Me.DataState = UI.DataStates.Retrieved
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub DisplayTotal()
        Dim sumBillAmt As Double = 0
        Dim sumVatAmt As Double = 0

        For i As Integer = 0 To GV1.RowCount - 1
            sumBillAmt = sumBillAmt + TryCDbl(GV1.GetRowCellValue(i, "BILL_AMT"))
            sumVatAmt = sumVatAmt + TryCDbl(GV1.GetRowCellValue(i, "BILL_VAT"))
        Next

        TOTAL_FARE_LOC_AMT.Value = sumBillAmt
        TOTAL_VAT_AMT.Value = sumVatAmt
        TOTAL_TOT_AMT.Value = sumBillAmt + sumVatAmt

    End Sub

    Private Sub SetListMsg(ByRef msg As String, ByVal key As String)
        If msg <> "" Then
            msg &= ", "
        End If
        msg &= key
    End Sub

    Private Function Gv1DataCheck() As Boolean
        Dim ErrorMsg As String = ""
        For i = 0 To GV1.RowCount - 1
            Dim RowErrorMsg As String = ""
            Try
                'GV1.GetRowCellValue(i,"").ToString

                If GV1.GetRowCellValue(i, "AROC").ToString = "" Then
                    SetListMsg(RowErrorMsg, "항목 코드")
                End If

                Dim SDATE As String = GV1.GetRowCellValue(i, "SDATE").ToString
                If IsDate(Mid(SDATE, 1, 4) & "-" & Mid(SDATE, 5, 2) + "-" & Mid(SDATE, 7, 2)) = False Then
                    SetListMsg(RowErrorMsg, "시작일자")
                End If

                If GV1.GetRowCellValue(i, "TAXDD").ToString = "" Then
                    GV1.SetRowCellValue(i, "TAXDD", "20")
                Else
                    If IsNumeric(GV1.GetRowCellValue(i, "TAXDD")) = False Then
                        SetListMsg(RowErrorMsg, "발의일자")
                    Else
                        If TryCDbl(GV1.GetRowCellValue(i, "TAXDD")) < 1 Or TryCDbl(GV1.GetRowCellValue(i, "TAXDD")) > 31 Then
                            SetListMsg(RowErrorMsg, "발의일자(1~31)")
                        End If
                    End If
                End If

                If GV1.GetRowCellValue(i, "BILL_AMT").ToString = "" Then
                    GV1.SetRowCellValue("BILL_AMT", i, 0)
                Else
                    If IsNumeric(GV1.GetRowCellValue(i, "BILL_AMT")) = False Then
                        SetListMsg(RowErrorMsg, "공급가액")
                    End If
                End If

                If GV1.GetRowCellValue(i, "BILL_VAT").ToString = "" Then
                    GV1.SetRowCellValue("BILL_VAT", i, 0)
                Else
                    If IsNumeric(GV1.GetRowCellValue(i, "BILL_VAT")) = False Then
                        SetListMsg(RowErrorMsg, "부가세금액")
                    End If
                End If

                If RowErrorMsg <> "" Then
                    RowErrorMsg = (i + 1) & "행 " & RowErrorMsg
                    If ErrorMsg <> "" Then
                        ErrorMsg = ErrorMsg & vbCrLf
                    End If
                    ErrorMsg = ErrorMsg & RowErrorMsg
                End If
            Catch ex As Exception

            End Try
        Next

        If ErrorMsg <> "" Then
            ErrorMsg = "아래 자료 확인 후 저장 시도하십시요." & vbCrLf & ErrorMsg
            MsgBoxLocalized(ErrorMsg)
            Return True
        End If

        Try

            Dim Param As New Dictionary(Of String, Object)
            Dim checkNull() As String = Nothing
            checkNull = {"COMN_CD", "AROC"}
            Param("COMN_CD") = GV1_COMN_CD.Caption
            Param("AROC") = GV1_AROC.Caption
            Return ValidateGridValue(GV1, Param, checkNull)
        Catch ex As Exception
            Return True
        End Try
        Return False
    End Function
    Private Sub DeleteData()
        Dim dsRet As DataSet = Nothing
        If MsgBoxLocalized("선택한 항목을 삭제 하시겠습니까?", MessageBoxButtons.YesNo, "Delete", MessageBoxIcon.Question) = MsgBoxResult.No Then
            Exit Sub
        End If
        WG1_DB_CUST.Text = Trim(UCase(WG1_DB_CUST.Text))
        If WG1_DB_CUST.Text = "" Or WG1_DB_AROC.Text = "" Or WG1_DB_COMN_CD.Text = "" Then
            MsgBoxLocalized("삭제 가능한 자료가 아닙니다.")
            Exit Sub
        End If

        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmInvoiceMgt", "DeleteData", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.BindToDataset(dsRet, "Data")
    End Sub

    Private Sub SaveTaxInfoData()

        Dim dsRet As DataSet = Nothing
        CUST_CD.Text = Trim(UCase(CUST_CD.Text))
        If CUST_CD.Text = "" Then
            MsgBoxLocalized("자료 조회 후 작업하십시요.")
            Exit Sub
        End If
        If MsgBoxLocalized("저장 하시겠습니까?", MessageBoxButtons.YesNo, "Save", MessageBoxIcon.Question) = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmInvoiceMgt", "SaveTaxInfoData", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.BindToDataset(dsRet, "Data")
    End Sub

    Private Sub SaveData()
        Dim dsRet As DataSet = Nothing
        CUST_CD.Text = Trim(UCase(CUST_CD.Text))
        If CUST_CD.Text = "" Then
            MsgBoxLocalized("자료 조회 후 작업하십시요.")
            Exit Sub
        End If

        If Gv1DataCheck() = True Then
            Exit Sub
        End If
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmInvoiceMgt", "SaveData", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
        Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Warning", MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.BindToDataset(dsRet, "Data")
    End Sub

    Private Sub PrintData()
        Dim ds As DataSet = Me.ConvertToDataset
        Dim MsgRtn As Object = Nothing

        MsgRtn = MsgBoxLocalized("Print Preview?", MessageBoxButtons.YesNoCancel, "Comfirm", MessageBoxIcon.Question)
        If MsgRtn = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmInvoiceMgt", "Print", ds)
        Catch ex As Exception
        End Try

        Dim rpt As DevExpress.XtraReports.UI.XtraReport = Nothing
        rpt = RptBaseSetting("STL", "CustomerBill.repx", ds)
        ReportPrintTool(rpt)
    End Sub

    Private Sub PrintCertificate()
        Dim ds As DataSet = Me.ConvertToDataset
        Dim MsgRtn As Object = Nothing

        MsgRtn = MsgBoxLocalized("Print Preview?", MessageBoxButtons.YesNoCancel, "Comfirm", MessageBoxIcon.Question)
        If MsgRtn = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmInvoiceMgt", "Certificate", ds)
        Catch ex As Exception
        End Try

        Dim rpt As DevExpress.XtraReports.UI.XtraReport = Nothing
        rpt = RptBaseSetting("STL", "Certificate.repx", ds)
        ReportPrintTool(rpt)
    End Sub

#End Region

#Region "=================Control Events==========="

    Private Sub COCD_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles COCD.PreviewKeyDown
        If e.KeyCode = Keys.Enter AndAlso COCD.Text <> "" Then
            Call SearchData()
        End If
    End Sub

    Private Sub GV1_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GV1.RowCellClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Exit Sub
        End If
    End Sub
    Private Sub GV1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanged
        If e.Column.FieldName = "BILL_AMT" Or e.Column.FieldName = "BILL_VAT" Then
            Call DisplayTotal()
        End If
    End Sub
    Private Sub GV1_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV1.CellValueChanging
        Dim fieldName = GV1.FocusedColumn.FieldName
        If fieldName = "CHK_FLAG" Then
            If GV1.GetRowCellValue(GV1.FocusedRowHandle, "CHK_FLAG") = "Y" Then
                GV1.SetRowCellValue(GV1.FocusedRowHandle, "CHK_FLAG", "N")
            Else
                GV1.SetRowCellValue(GV1.FocusedRowHandle, "CHK_FLAG", "Y")
            End If
        End If
    End Sub

    Private Sub BTN_CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CLEAR.Click
        NewData()
    End Sub

    Private Sub CrmInvoiceMgt_SHOWN(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        PopupInit()

        NewData()

    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveData()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call PrintData()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call PrintCertificate()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteData()
    End Sub

    Private Sub WG1_MODIFYGB_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles WG1_MODIFYGB.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            e.IsInputKey = True
            WG1.AddRow()
            WG1AddrowDefultSetting(GV1.FocusedRowHandle)
            WG1_COMN_CD.Focus()
        End If
    End Sub
    Private Sub btnTaxInfoSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaxInfoSave.Click
        SaveTaxInfoData()
    End Sub

    Private Sub WG1_BILL_AMT_EditValueChanged(oldValue As System.Object, newValue As System.Object) Handles WG1_BILL_AMT.EditValueChanged
        Dim bill_vat As Double = 0
        bill_vat = CDbl(WG1_BILL_AMT.Text) * 0.1
        WG1_BILL_VAT.Text = bill_vat
    End Sub
#End Region

End Class