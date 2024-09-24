Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic

Imports System.Windows.Forms

Namespace YJIT.Biz

    Public Class MailDemon
        Public Shared Function sendEmail(ByVal sFrom As String, ByVal sTo As String, ByVal sCC As String, ByVal sSubject As String, ByVal sBody As String, _
                                    Optional ByVal sAttachment As DataTable = Nothing) As String
            'Create instance of main mail message class.
            Dim ReturnMsg As String = ""
            Dim mailMessage As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage()

            'Configure mail mesage
            'Set the From address with user input
            '    mailMessage.From = New System.Net.Mail.MailAddress(txtFromAddress.Text.Trim())
            'Get From address in web.config
            If sFrom <> "" Then
                mailMessage.From = New System.Net.Mail.MailAddress(sFrom)
            End If
            'Another option is the "from" attirbute in the <smtp> element in the web.config.

            'Set additinal addresses
            'mailMessage.To.Add(New System.Net.Mail.MailAddress(sTo))

            If sTo <> "" Then
                Dim s_TO As String() = sTo.Split(New Char() {";"c})

                For i = 0 To s_TO.Length - 1 Step 1
                    If Trim(s_TO(i)) <> "" Then
                        mailMessage.To.Add(New System.Net.Mail.MailAddress(s_TO(i)))
                    End If
                Next
            End If



            If sCC <> "" Then
                Dim s_CC As String() = sCC.Split(New Char() {";"c})

                For i = 0 To s_CC.Length - 1 Step 1
                    If Trim(s_CC(i)) <> "" Then
                        mailMessage.CC.Add(New System.Net.Mail.MailAddress(s_CC(i)))
                    End If 
                Next

            End If
            'mailMessage.Bcc
            'mailMessage.ReplyTo

            'Set additional options
            mailMessage.Priority = Net.Mail.MailPriority.High

            'Text/HTML
            mailMessage.IsBodyHtml = True

            'Set the subjet and body text
            mailMessage.Subject = sSubject

            If mailMessage.IsBodyHtml = True Then
                sBody = sBody.Replace(vbCrLf, "<br>")
            End If
            mailMessage.Body = sBody

            Dim filePath As String = HttpContext.Current.Server.MapPath("/EMAIL/SEND/")

            Dim oAtt As System.Net.Mail.Attachment = Nothing
            'Add one to many attachments
            If Not sAttachment Is Nothing Then
                For i As Integer = 0 To sAttachment.Rows.Count - 1
                    If sAttachment.Rows(i)("NAME") <> "" Then
                        oAtt = New System.Net.Mail.Attachment(filePath & sAttachment.Rows(i)("NAME").ToString)
                        'If System.IO.File.Exists(sAttachment) Then
                        mailMessage.Attachments.Add(oAtt)
                        'End If
                    End If
                Next
            End If

            'Create an instance of the SmtpClient class for sending the email
            'Dim smtpClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient("150.25.10.10")  '? is 
            'Dim smtpClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient(System.Web.Configuration.WebConfigurationManager.AppSettings("smtp"))
            'smtpClient.Host = "smtp.yjit.co.kr"

            Dim smtpClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient()
            'smtpClient.Host = "kornet.net"
            'smtpClient.Credentials = New System.Net.NetworkCredential("khiemvh@yjit.co.kr", "")
            'smtpClient.Host = "relay.hyosung.com"
            'smtpClient.Credentials = New System.Net.NetworkCredential("jongnam.woo@hyosung.com", "")
            'Use a Try/Catch block to trap sending errors
            'Especially useful when looping through multiple sends

            Try
                smtpClient.Send(mailMessage)
            Catch smtpExc As System.Net.Mail.SmtpException
                'Log error information on which email failed.
                'Throw smtpExc
                Return smtpExc.Message
            Catch ex As Exception
                'Log general errors
                Return ex.Message
            Finally
                If Not oAtt Is Nothing Then
                    oAtt.Dispose()
                End If
                ' === 2013.03.22 YMJ
                ' 아래 부분 없을 경우 파일 삭제시 에러 발생함
                mailMessage.Dispose()
            End Try
            Return ReturnMsg
        End Function

        Public Shared Sub sendEmail2(ByVal sFrom As String, ByVal sTo As String, ByVal sCC As String, ByVal sSubject As String, ByVal sBody As String, Optional ByVal sAttachment As String = "")
            'Create instance of main mail message class.
            Dim mailMessage As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage()

            'Configure mail mesage
            'Set the From address with user input
            '    mailMessage.From = New System.Net.Mail.MailAddress(txtFromAddress.Text.Trim())
            'Get From address in web.config
            If sFrom <> "" Then
                mailMessage.From = New System.Net.Mail.MailAddress(sFrom)
            End If
            'Another option is the "from" attirbute in the <smtp> element in the web.config.

            'Set additinal addresses
            mailMessage.To.Add(New System.Net.Mail.MailAddress(sTo))

            If sCC <> "" Then
                mailMessage.CC.Add(New System.Net.Mail.MailAddress(sCC))
            End If
            'mailMessage.Bcc
            'mailMessage.ReplyTo

            'Set additional options
            mailMessage.Priority = Net.Mail.MailPriority.High

            'Text/HTML
            mailMessage.IsBodyHtml = True

            'Set the subjet and body text
            mailMessage.Subject = sSubject
            mailMessage.Body = sBody

            Dim oAtt As System.Net.Mail.Attachment
            'Add one to many attachments
            If sAttachment <> "" Then
                oAtt = New System.Net.Mail.Attachment(sAttachment)
                'If System.IO.File.Exists(sAttachment) Then
                mailMessage.Attachments.Add(oAtt)
                'End If
            End If

            'Create an instance of the SmtpClient class for sending the email
            'Dim smtpClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient("150.25.10.10")  '? is 
            'Dim smtpClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient(System.Web.Configuration.WebConfigurationManager.AppSettings("smtp"))
            'smtpClient.Host = "smtp.yjit.co.kr"
            Dim host As String = ""
            Dim Credentials As String = ""

            If YJIT.SessionOfficeInfo.HqOfficeCode = "ENCHQ" AndAlso YJIT.SessionOfficeInfo.CountryCode = "US" Then
                host = "mail.enc-inc.net"
                Credentials = "brianlee@enc-inc.net"
            Else
                host = "mail.yjit.co.kr"
                Credentials = "yjit@yjit.co.kr"
            End If

            Dim smtpClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient()
            smtpClient.Host = host
            'smtpClient.Credentials = New System.Net.NetworkCredential("khiemvh@yjit.co.kr", "")
            'smtpClient.Host = "relay.hyosung.com"
            smtpClient.Credentials = New System.Net.NetworkCredential(Credentials, "")
            'Use a Try/Catch block to trap sending errors
            'Especially useful when looping through multiple sends
            Try
                smtpClient.Send(mailMessage)
            Catch smtpExc As System.Net.Mail.SmtpException
                'Log error information on which email failed.
                Throw smtpExc
            Catch ex As Exception
                'Log general errors
                Throw ex
            Finally
                If Not oAtt Is Nothing Then
                    oAtt.Dispose()
                End If
            End Try
        End Sub
    End Class
End Namespace
