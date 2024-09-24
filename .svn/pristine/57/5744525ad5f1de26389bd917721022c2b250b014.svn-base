Imports YJIT.SC.UI


Public Class CrmAsPrint

#Region "=================Data logic actions==========="
    Private Sub PrintData()
        Try
            If PrintValidate() = False Then Exit Sub

            Dim FileName As String = String.Empty
            Select Case S_PRT_TYPE.Text.ToUpper
                Case "btnMetting".ToUpper
                    FileName = "CrmMeetting.repx"
                Case "btnPayment".ToUpper
                    FileName = "CrmPayment.repx"
                Case Else
                    Throw New Exception("출력물 종류를 확인하지 못했습니다. 작업이 취소되었습니다.")
            End Select

            Dim rpt As DevExpress.XtraReports.UI.XtraReport = Nothing
            'Dim rpt1 As DevExpress.XtraReports.UI.XtraReport = Nothing

            Dim ds As DataSet = Me.ConvertToDataset
            Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 처리중입니다.")
                ds = MethodCallEx(Me, "YJIT.Biz.CrmAsPrint", "Print", ds)
            End Using

            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                Exit Try
            End If

            rpt = RptBaseSetting("CRM", FileName, ds)
            If rpt Is Nothing Then Exit Try
            rpt.CreateDocument()

            Call ReportPrintTool(rpt)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Function PrintValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        'Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            If String.IsNullOrEmpty(S_MNGT_NO.Text) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                'If ErrControl Is Nothing Then ErrControl = MNGT_NO
                ErrMsg &= "관리번호가 누락되었습니다. 작업이 취소되었습니다." & vbNewLine
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
    Private Sub Button_Click(sender As System.Object, e As System.EventArgs) Handles btnMetting.Click, btnPayment.Click
        S_PRT_TYPE.Text = sender.Name
        Call PrintData()
        Me.Close()
    End Sub
#End Region

End Class