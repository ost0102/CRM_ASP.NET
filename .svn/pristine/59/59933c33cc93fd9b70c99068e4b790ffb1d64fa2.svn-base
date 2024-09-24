Imports System
Imports System.IO
Imports System.Drawing
Imports YJIT.SC.UI
Imports DevExpress.Office


Public Class ComSendMail

#Region "=================GetConvertToDataset Function==========="
    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("WG1", "ComSendMail@Search")
            YJSql.Params("USR_ID", ClientSessionInfo.UserID)
            YJSql.Params("CUST_CD", drMAIN("S_CUST_CD").ToString.Trim, False)

            YJSql.SqlBox("WG3", "ComSendMail@SearchList")
            YJSql.Params("MNGT_NO", drMAIN("S_MNGT_NO").ToString.Trim, False)
            YJSql.Params("CUST_CD", drMAIN("CUST_CD").ToString.Trim, False)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    Private Function GetConvertToDataSetDetail() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("MAIN", "ComSendMail@SearchList")
            YJSql.Params("MNGT_NO", drMAIN("S_MNGT_NO").ToString.Trim, False)
            YJSql.Params("SEQ", GV3.GetFocusedDataRow("SEQ").ToString.Trim, False)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    '20171109 김성은 메세지 추가
    Private Function GetConvertToDataSetMailData() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            YJSql.SqlBox("MAIL", "ComSendMail@SearchMailData")
            YJSql.Params("CUST_CD", S_CUST_CD.Text)
            YJSql.Params("DEPT_CD", ClientSessionInfo.OrganizationCode)
            YJSql.Params("MNGT_NO", drMAIN("S_MNGT_NO").ToString.Trim)
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
        Popup.ItemAdd(Action.Other, "WG1_ApplyReceiver", "Apply Receiver")
        Popup.ItemAdd(Action.Other, "WG1_ApplyCC", "Apply C.C", True)
        Popup.ItemAdd(Action.Excel, "WG1_ExportExcel", "&Export Excel")
        Popup.PopUpInit(Me, WG1)

        Popup = New PopupBase
        Popup.ItemAdd(Action.Addrow, "WG2_AddRow", "&Add Row")
        Popup.ItemAdd(Action.DeleteRow, "WG2_DeleteRow", "&Delete Row")
        Popup.ItemAdd(Action.Other, "WG2_Download", "Download", True)
        Popup.PopUpInit(Me, WG2)
    End Sub

    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString
        'Navigato 사용할떄
        Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
        Dim fTarget As Object = Nothing

        Select Case dr("Action").ToString
            Case Action.NavigateTo
                frmMain = Me.MdiParent
                Select Case key
                    'Case "EdmMailMsg"
                    '    fTarget = frmMain.NavigateTo("EdmMailMsg")
                    '    If Not IsNothing(fTarget) Then
                    '        fTarget.SearchData()
                    '    End If
                End Select
            Case Else
                Select Case key
                    Case "WG1_ApplyReceiver"
                        For i As Integer = 0 To GV1.RowCount - 1
                            If GV1.GetRowCellValue(i, "CHK").ToString = "Y" Then
                                If Not String.IsNullOrEmpty(RECEIVER.Text) Then RECEIVER.Text &= ","
                                RECEIVER.Text &= GV1.GetRowCellValue(i, "EMAIL")
                            End If
                        Next
                    Case "WG1_ApplyCC"
                        For i As Integer = 0 To GV1.RowCount - 1
                            If GV1.GetRowCellValue(i, "CHK").ToString = "Y" Then
                                If Not String.IsNullOrEmpty(CC.Text) Then CC.Text &= ","
                                CC.Text &= GV1.GetRowCellValue(i, "EMAIL")
                            End If
                        Next
                    Case "WG2_Download"
                        If GV2.FocusedRowHandle >= 0 < GV2.RowCount Then
                            If GV2.GetFocusedRowCellValue("FULL_PATH").ToString <> "" Then
                                Microsoft.VisualBasic.Shell("explorer " & GV2.GetFocusedRowCellValue("FULL_PATH"), AppWinStyle.NormalFocus)
                            End If
                        Else
                            MsgBoxLocalized("Please select the file to download.", MessageBoxButtons.OK, Me.Text, MessageBoxIcon.Warning)
                        End If
                End Select
        End Select

    End Sub

    Public Sub initDefault()
        'Select Case ClientSessionOfficeInfo.HqOfficeCode
        '    Case "YJITHQ"
        SEND_ID.Text = "mailmaster@yjit.co.kr"
        SEND_PWD.Text = "Yjit0921)#$%"
        SEND_HOST.Text = "mail.yjit.co.kr"
        SEND_PORT.Text = "587"
        SEND_SSL_YN.Text = ""

        SENDER.Text = "help@yjit.co.kr"
        'S_CC.Text = ClientSessionInfo.Email

        MAIL_TYPE.SelectedValue = "H" '한비로
        '    Case "JIOOHQ"
        '        S_SEND_ID.Text = "operator@jiexpress.co.kr"
        '        S_SEND_PWD.Text = "!1307157q"
        '        S_SEND_HOST.Text = "mail.jiexpress.co.kr"
        '        S_SEND_PORT.Text = "587"
        '        S_SEND_SSL_YN.Text = ""

        '        S_SENDER.Text = "jiexpress@hanmail.net" 'ClientSessionInfo.Email
        '        S_CC.Text = "jiexpress@hanmail.net" 'ClientSessionInfo.Email

        '        S_MAIL_TYPE.SelectedValue = "H" '한비로


        '    Case Else
        '        S_SEND_ID.Text = ""
        '        S_SEND_PWD.Text = ""
        '        S_SEND_HOST.Text = ""
        '        S_SEND_PORT.Text = ""
        '        S_SEND_SSL_YN.Text = ""

        '        S_SENDER.Text = ClientSessionInfo.Email
        '        S_MAIL_TYPE.SelectedValue = "M" 'MS OUTLOOK
        'End Select



        If Not String.IsNullOrEmpty(S_CUST_CD.Text) Then
            S_CUST_CD.ValidateCode()
            If String.IsNullOrEmpty(CUST_CD.Text) Then CUST_CD.Text = S_CUST_CD.Text
            Call SearchData()
        End If

    End Sub
#End Region

#Region "=================Data logic actions==========="
    Public Sub SearchData()
        Try
            If SearchValidate() = False Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSet()

            dsRet = MethodCallEx(Me, "YJIT.Biz.ComSendMail", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    Me.BindToDataset(dsRet, "Data")


                    '20171109 김성은 메세지 추가
                    If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing _
                            AndAlso YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("MDM_COM_CODE") Then
                        dsRet = GetConvertToDataSetMailData()
                        dsRet = MethodCallEx(Me, "YJIT.Biz.ComSendMail", "Search", {dsRet})
                        drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

                        Select Case drPairs("TrxCode")
                            Case "Y"
                                '메일종류, 메일상세종류, 부서명
                                Dim dtQuery As String = "GRP_CD='S31' AND OPT_ITEM1 = '" & S_MSG_TYPE.Text & "' AND OPT_ITEM2 = '" & S_MSG_TYPE2.Text & "' AND OPT_ITEM3 = '" & ClientSessionInfo.OrganizationCode & "' "
                                Dim drMdm() As DataRow = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select(dtQuery)
                                If drMdm.Count = 0 Then
                                    '메일종류, 메일상세종류
                                    dtQuery = "GRP_CD='S31' AND OPT_ITEM1 = '" & S_MSG_TYPE.Text & "' AND OPT_ITEM2 = '" & S_MSG_TYPE2.Text & "' "
                                    drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select(dtQuery)
                                End If
                                If drMdm.Count = 0 Then
                                    '메일종류
                                    dtQuery = "GRP_CD='S31' AND OPT_ITEM1 = '" & S_MSG_TYPE.Text & "' "
                                    drMdm = YJIT.SC.UI.SCView.PreloadedCodeListData("MDM_COM_CODE").Select(dtQuery)
                                End If
                                If drMdm.Count > 0 Then
                                    For Each dr As DataRow In dsRet.Tables("Data.MAIL").Rows
                                        SUBJECT.Text = drMdm(0)("CD_NM").ToString
                                        CONTENT.Text = drMdm(0)("RMK").ToString
                                        For Each col As DataColumn In dr.Table.Columns
                                            SUBJECT.Text = SUBJECT.Text.Replace("#" & col.ColumnName, dr(col).ToString)
                                            CONTENT.Text = CONTENT.Text.Replace("#" & col.ColumnName, dr(col).ToString)
                                        Next
                                    Next
                                End If
                        End Select
                    End If

                    Me.DataState = UI.DataStates.None
                Case "N"
                    Call ClearView(AppliedRangeTypes.Only, {WG1})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.None
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
            'If String.IsNullOrEmpty(S_COMN_CD.SelectedValue.ToString) Then
            '    If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = S_COMN_CD
            '    ErrMsg &= "Please input the [Mapping Type]" & vbNewLine
            'End If

            If String.IsNullOrEmpty(S_CUST_CD.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = S_CUST_CD
                ErrMsg &= "Please input the [" & lbl_S_CUST_CD.Text & "]" & vbNewLine
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

    Public Sub SearchDetailData()
        Try
            If GV3.RowCount = 0 Then Exit Sub

            Dim dsRet As DataSet = GetConvertToDataSetDetail()

            dsRet = MethodCallEx(Me, "YJIT.Biz.ComSendMail", "Search", {dsRet})
            Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Select Case drPairs("TrxCode")
                Case "Y"
                    'Call ClearView(AppliedRangeTypes.Only, {WG1})
                    Me.BindToDataset(dsRet, "Data")
                    Me.DataState = UI.DataStates.None
                Case "N"
                    'Call ClearView(AppliedRangeTypes.Only, {WG1})
                    MsgBoxLocalized(drPairs("TrxMsg"))
                    Me.DataState = UI.DataStates.None
                Case Else
                    MsgBoxLocalized(drPairs("TrxMsg"))
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Public Sub SendData()
        If SendValidate() = False Then Exit Sub

        Try
            Select Case MAIL_TYPE.SelectedValue
                Case "H" '한비로
                    Dim dsRet As DataSet = Me.ConvertToDataset

                    Dim smtpClient As System.Net.Mail.SmtpClient = Nothing
                    Try
                        For Each dr As DataRow In dsRet.Tables("WG2").Rows
                            If Not System.IO.File.Exists(dr("FILE_FULL_NAME").ToString) Then
                                MsgBoxLocalized("File not found." & "(" & dr("FILE_NAME").ToString & ")")
                                Exit Sub
                            End If
                        Next





                        Dim mailMessage As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage()
                        mailMessage.From = New System.Net.Mail.MailAddress(dsRet.Tables("MAIN").Rows(0)("SENDER").ToString)

                        For Each ReceiverMail As String In dsRet.Tables("MAIN").Rows(0)("RECEIVER").ToString.Replace(";", ",").Split(",")
                            mailMessage.To.Add(New System.Net.Mail.MailAddress(ReceiverMail))
                        Next

                        If Not String.IsNullOrEmpty(dsRet.Tables("MAIN").Rows(0)("CC").ToString) Then
                            For Each CcMail As String In dsRet.Tables("MAIN").Rows(0)("CC").ToString.Replace(";", ",").Split(",")
                                mailMessage.CC.Add(New System.Net.Mail.MailAddress(CcMail))
                            Next
                        End If
                        'mailMessage.Bcc
                        'mailMessage.ReplyTo
                        mailMessage.Priority = Net.Mail.MailPriority.High
                        mailMessage.IsBodyHtml = True

                        mailMessage.Subject = dsRet.Tables("MAIN").Rows(0)("SUBJECT").ToString


                        Dim sBody As String = dsRet.Tables("MAIN").Rows(0)("CONTENT").ToString
                        sBody = sBody.Replace(Chr(13), "").Replace(Chr(10), "<BR>")
                        mailMessage.Body = sBody

                        Dim oAtt As System.Net.Mail.Attachment
                        For Each dr As DataRow In dsRet.Tables("WG2").Rows
                            oAtt = New System.Net.Mail.Attachment(dr("FILE_FULL_NAME").ToString)
                            If System.IO.File.Exists(dr("FILE_FULL_NAME").ToString) Then
                                mailMessage.Attachments.Add(oAtt)
                            End If
                        Next


                        'Create an instance of the SmtpClient class for sending the email
                        smtpClient = New System.Net.Mail.SmtpClient()
                        'smtpClient.Host = S_SEND_HOST.Text
                        'smtpClient.EnableSsl = True
                        'smtpClient.Port = 465
                        'smtpClient.Credentials = New System.Net.NetworkCredential("kaebi79", "daum2776!")


                        smtpClient.Host = SEND_HOST.Text
                        If SEND_SSL_YN.Text = "Y" Then
                            smtpClient.EnableSsl = True
                        ElseIf SEND_SSL_YN.Text = "N" Then
                            smtpClient.EnableSsl = False
                        End If
                        smtpClient.Port = SEND_PORT.Text
                        smtpClient.Credentials = New System.Net.NetworkCredential(SEND_ID.Text, SEND_PWD.Text)

                        'Use a Try/Catch block to trap sending errors
                        'Especially useful when looping through multiple sends
                        Try
                            smtpClient.Send(mailMessage)

                            dsRet = MethodCallEx(Me, "YJIT.Biz.ComSendMail", "Save", Me.ConvertToDataset)
                            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
                            If dr("TrxCode") <> "Y" Then
                                Throw New Exception("메일전송완료후 로그저장시 오류가 발생했습니다." & vbNewLine & dr("TrxMsg"))
                            End If
                        Catch smtpExc As System.Net.Mail.SmtpException
                            'Log error information on which email failed.
                            Throw New Exception(smtpExc.Message)
                        Catch ex As Exception
                            'Log general errors
                            Throw New Exception(ex.Message)
                        End Try

                        MsgBoxLocalized("Success")
                        Me.Close()

                    Catch ex As Exception
                        MsgBoxLocalized(ex.Message)
                    Finally
                        smtpClient = Nothing
                    End Try
                    'Case "M" 'MS Outlook
                    '    Dim oApp As Interop.Outlook.Application
                    '    oApp = New Interop.Outlook.Application

                    '    Dim oMsg As Interop.Outlook.MailItem
                    '    oMsg = oApp.CreateItem(Interop.Outlook.OlItemType.olMailItem)
                    '    oMsg.GetInspector.Activate()

                    '    '제목
                    '    oMsg.Subject = ""
                    '    '본문
                    '    Dim Signature As String = oMsg.HTMLBody
                    '    Dim HtmlBody As String = "<span style='font-family:맑은 고딕; font-size:10pt; color:windowtext'>"
                    '    HtmlBody &= ""
                    '    HtmlBody &= ""
                    '    HtmlBody &= "<br>" & Signature & "</span>"
                    '    oMsg.HTMLBody = HtmlBody
                    '    '받는사람
                    '    oMsg.To = ""
                    '    '참조
                    '    oMsg.CC = ""
                    '    '파일첨부
                    '    If CType(WG2.DataSource, DataTable).Rows.Count > 0 Then
                    '        For Each dr As DataRow In CType(WG2.DataSource, DataTable).Rows
                    '            oMsg.Attachments.Add(dr("FILE_FULL_NAME").ToString)
                    '        Next
                    '    End If
                    '    '아웃룩 전송화면 표시
                    '    oMsg.GetInspector().Display(False)
                Case Else
                    MsgBoxLocalized("Mail method is not set.")
            End Select
        Catch ex As Exception
            Throw New Exception("Error while sending email!" & ex.Message)
        End Try

        'Dim RtnDic As Dictionary(Of String, Object) = SendEmail(SENDER.Text, RECEIVER.Text, SUBJECT.Text, CC.Text, CONTENT.Text, WG2.DataSource)

        'MsgBoxLocalized(RtnDic("TrxMsg"))
    End Sub
    Private Function SendValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing
        Dim ErrTabPage As DevExpress.XtraTab.XtraTabPage = Nothing

        Try
            'If String.IsNullOrEmpty(S_COMN_CD.SelectedValue.ToString) Then
            '    If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
            '    If ErrControl Is Nothing Then ErrControl = S_COMN_CD
            '    ErrMsg &= "Please input the [Mapping Type]" & vbNewLine
            'End If

            If String.IsNullOrEmpty(SENDER.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = SENDER
                ErrMsg &= "Please input the [" & lbl_SENDER.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(RECEIVER.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = RECEIVER
                ErrMsg &= "Please input the [" & lbl_RECEIVER.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(SUBJECT.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = SUBJECT
                ErrMsg &= "Please input the [" & lbl_SUBJECT.Text & "]" & vbNewLine
            End If

            If String.IsNullOrEmpty(SEND_HOST.Text.ToString) Then
                'If ErrTabPage Is Nothing Then ErrTabPage = XtraTabPage4
                If ErrControl Is Nothing Then ErrControl = SUBJECT
                ErrMsg &= "Your mail settings are missing." & vbNewLine
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
    Private Sub ComSendMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComSendMail_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        PopupInit()
        SetMandatoryLine(Me)

        Call initDefault()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearView()
        Call initDefault()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Call SendData()
    End Sub

    Private Sub S_MAIL_TYPE_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAIL_TYPE.SelectedValueChanged
        Select Case MAIL_TYPE.SelectedValue
            Case "M"
                SEND_ID.Visible = False
            Case Else
                SEND_ID.Visible = True
        End Select
    End Sub

    Private Sub GV2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If GV2.GetFocusedRowCellValue("FULL_PATH").ToString <> "" Then
                Microsoft.VisualBasic.Shell("explorer " & GV2.GetFocusedRowCellValue("FULL_PATH"), AppWinStyle.NormalFocus)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GV3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV3.Click
        Call SearchDetailData()
    End Sub

    Private Sub GV3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV3.KeyDown
        If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageUp Or e.KeyCode = Keys.PageDown) Then
            Call SearchDetailData()
        End If
    End Sub

#End Region



End Class
