Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Exception
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.BIZ.Common
Imports System.Net
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports Newtonsoft.Json
Imports System.IO

Namespace YJIT.BIZ
    Public Class FrndDocumentMgt
        '암호화, 복호화에 사용될 KEY
        Public Shared KEY As String = "yjit2022frnd246810135791098765432197531108642"
        Public Shared KEY_128 As String = KEY.Substring(0, 128 / 8)
        Public Shared KEY_256 As String = KEY.Substring(0, 256 / 8)

        Public Shared mngt_no As String = "20210524134433594070"
        Public Shared usr_id As String = "webdev@yjit.co.kr "
        Public Shared auth_key As String = "9sWDbs6hHagHcu6kenb6qr5KylRygGRE+7Ifa7LJ8Kiaw8v8yOuIVnh70uE9hm9Z"

        Private Shared Function GetRestAPI(ByVal methodParam As String, ByVal urlParam As String, ByVal tokenParam As String, ByVal dataParam As String) As String
            Dim url As String = urlParam
            If methodParam.ToUpper = "GET" Then
                url = String.Format("{0}?{1}", urlParam, dataParam)
            End If

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Headers.Add("Authorization-Type", "N")
            If Not String.IsNullOrEmpty(tokenParam) Then
                request.Headers.Add("Authorization-Token", tokenParam)
            End If

            request.Method = methodParam.ToUpper
            'request.ContentType = "application/x-www-form-urlencoded"
            request.ContentType = "application/json;charset=UTF-8"

            If methodParam.ToUpper = "POST" Then
                Dim byteDataParams As Byte() = Encoding.UTF8.GetBytes(dataParam)
                request.ContentLength = byteDataParams.Length

                Dim st As Stream = request.GetRequestStream()
                st.Write(byteDataParams, 0, byteDataParams.Length)
                st.Close()
            End If

            Dim response As HttpWebResponse = Nothing
            Try
                response = CType(request.GetResponse(), HttpWebResponse)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Dim stream As Stream = response.GetResponseStream()

            Dim reader As StreamReader = New StreamReader(stream, Encoding.UTF8)
            Dim text As String = reader.ReadToEnd()
            stream.Close()
            response.Close()
            reader.Close()

            Return text

        End Function
        'Search
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            'ByVal status As String, ByVal fm_ymd As String, ByVal to_ymd As String, ByVal doc_type As String, ByVal doc_nm As String
            Dim xmlhttp = CreateObject("Microsoft.XMLHTTP")
            Dim strResponseText As String
            Dim db As DBA = New DBA(CrmSvcAprMgt.GetConnectionString("FRIEND_SYS", ""), "ORACLE")
            Dim apiurl As String = "http://apimeta.yjit.co.kr/api/Template/GetTemplateList"

            Dim dicResponse As New Dictionary(Of String, Object)
            Dim dtRspnRes As DataTable = New DataTable
            Dim dtRspnDoc As DataTable = New DataTable
            Dim dtRspnDataset As DataSet = New DataSet
            Dim dicParams As New Dictionary(Of String, Object)
            Dim jsonString As String = ""

            Dim ErrorOccur As Boolean = True
            Dim resultSet As New Dictionary(Of String, Object)

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                Dim dr As DataRow = ds.Tables("MAIN").Rows(0)

                dicParams("FM_YMD") = dr("S_FM_YMD").ToString
                dicParams("TO_YMD") = dr("S_TO_YMD").ToString
                If Not String.IsNullOrEmpty(dr("S_APV_YN").ToString) Then
                    dicParams("APV_YN") = dr("S_APV_YN").ToString
                End If
                If Not String.IsNullOrEmpty(dr("S_TMPLT_TYPE").ToString) Then
                    dicParams("TMPLT_TYPE") = dr("S_TMPLT_TYPE").ToString
                End If
                If Not String.IsNullOrEmpty(dr("S_TMPLT_NM").ToString) Then
                    dicParams("TMPLT_NM") = dr("S_TMPLT_NM").ToString
                End If
                jsonString = Json.Serialize(dicParams, True)
                strResponseText = GetRestAPI("POST", apiurl, mngt_no + "^" + usr_id + "^" + auth_key, "[" & jsonString & "]")

                If strResponseText <> "" Then
                    'Response 실제문서에는 정상적으로 Response 해주지만 VB 단에서 (") 더블컨테이션에 대해서 특수문자 처리가 자동으로 들어간다
                    '문제가 되는 (") 더블컨테이션을 제거해준다.
                    strResponseText = strResponseText.Replace("\""", """")
                    strResponseText = strResponseText.Replace("""{", "{")
                    strResponseText = strResponseText.Replace("}""", "}")

                    ' 정리된 Response 문서를 Dictionary 에 담는다.
                    dicResponse = YJIT.Json.Deserialize(strResponseText, GetType(Dictionary(Of String, Object)))

                    'Table1이 없으면 건너뜀
                    If dicResponse.Count = 1 Then
                        dtRspnRes = YJIT.Json.Deserialize(dicResponse("Result").ToString, GetType(DataTable))
                        If dtRspnRes.Rows(0)("trxCode") <> "Y" Then
                            ThrowMsg(True, dtRspnRes.Rows(0)("trxMsg").ToString)
                        Else
                            ThrowMsg(True, "자료가 없습니다")
                        End If
                    End If

                    '결과테이블
                    dtRspnRes = YJIT.Json.Deserialize(dicResponse("Result").ToString, GetType(DataTable))
                    '오류시 건너뜀
                    If dtRspnRes.Rows(0)("trxCode") <> "Y" Then
                        ThrowMsg(True, dtRspnRes.Rows(0)("trxMsg").ToString)
                    End If
                    '자료테이블
                    dtRspnDoc = YJIT.Json.Deserialize(dicResponse("Table1").ToString, GetType(DataTable))

                    If dtRspnDoc.Columns.Contains("RMK") Then
                        dtRspnDoc.Columns.Add("DB_APV_YN")
                        For index = 0 To dtRspnDoc.Rows.Count - 1
                            '띄어쓰기 만들기
                            dtRspnDoc.Rows(index)("RMK") = dtRspnDoc.Rows(index)("RMK").ToString.Replace("\r", String.Empty).Replace("\n", vbNewLine)
                            '수정 유무를 알기 위해 추가. 
                            dtRspnDoc.Rows(index)("DB_APV_YN") = dtRspnDoc.Rows(index)("APV_YN").ToString
                        Next
                    End If

                    dtRspnDoc.TableName = "WG1"
                    dtRspnDataset.Tables.Add(dtRspnDoc)
                    resultSet("Data") = dtRspnDataset
                    resultSet("TrxCode") = "Y"
                    resultSet("TrxMsg") = "Success"
                Else
                    resultSet("TrxCode") = "N"
                    resultSet("TrxMsg") = "Fail"
                End If
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try
            Return resultSet
        End Function
        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True

            Dim strResponseText As String
            Dim apiurl As String = "http://apimeta.yjit.co.kr/api/Template/SetTmpltApvStatus"
            Dim dicParams As New Dictionary(Of String, Object)
            Dim jsonString As String = ""

            Try
                If Not ds.Tables.Contains("WG1") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                Dim dtWG1 As DataTable = ds.Tables("WG1")

                For Each dr As DataRow In dtWG1.Rows

                    dicParams("APV_YN") = dr("APV_YN")
                    dicParams("NC_OCR_ID") = dr("NC_OCR_ID")
                    dicParams("TMPLT_ID") = dr("TMPLT_ID")
                    jsonString = Json.Serialize(dicParams, True)
                    strResponseText = GetRestAPI("POST", apiurl, mngt_no + "^" + usr_id + "^" + auth_key, "[" & jsonString & "]")
                Next

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
            End Try

            Return resultSet
        End Function

        Public Shared Function FileDownload(ByVal tmplt_id As String) As Dictionary(Of String, Object)
            Dim xmlhttp = CreateObject("Microsoft.XMLHTTP")
            Dim strResponseText As String
            Dim db As DBA = New DBA(CrmSvcAprMgt.GetConnectionString("FRIEND_SYS", ""), "ORACLE")
            Dim apiurl As String = "http://apimeta.yjit.co.kr/api/Template/GetTemplatePath"

            Dim dicResponse As New Dictionary(Of String, Object)
            Dim dtRspnRes As DataTable = New DataTable
            Dim dtRspnDoc As DataTable = New DataTable
            Dim dtRspnDataset As DataSet = New DataSet
            Dim dicParams As New Dictionary(Of String, Object)
            Dim jsonString As String = ""

            Dim ErrorOccur As Boolean = True
            Dim resultSet As New Dictionary(Of String, Object)

            Try
                db.BeginTransaction()

                dicParams("TMPLT_ID") = tmplt_id
                jsonString = Json.Serialize(dicParams, True)
                strResponseText = GetRestAPI("POST", apiurl, mngt_no + "^" + usr_id + "^" + auth_key, "[" & jsonString & "]")

                If strResponseText <> "" Then
                    'Response 실제문서에는 정상적으로 Response 해주지만 VB 단에서 (") 더블컨테이션에 대해서 특수문자 처리가 자동으로 들어간다
                    '문제가 되는 (") 더블컨테이션을 제거해준다.
                    strResponseText = strResponseText.Replace("\""", """")
                    strResponseText = strResponseText.Replace("""{", "{")
                    strResponseText = strResponseText.Replace("}""", "}")

                    ' 정리된 Response 문서를 Dictionary 에 담는다.
                    dicResponse = YJIT.Json.Deserialize(strResponseText, GetType(Dictionary(Of String, Object)))

                    'Table1이 없으면 건너뜀
                    If dicResponse.Count = 1 Then
                        ThrowMsg(False, "가져올 자료가 존재하지 않습니다.")
                    End If

                    '결과테이블
                    dtRspnRes = YJIT.Json.Deserialize(dicResponse("Result").ToString, GetType(DataTable))
                    '오류시 건너뜀
                    If dtRspnRes.Rows(0)("trxCode") <> "Y" Then
                        ThrowMsg(True, "자료를 가져오는 중 오류가 발생하였습니다.")
                    End If
                    '자료테이블
                    dtRspnDoc = YJIT.Json.Deserialize(dicResponse("Table1").ToString, GetType(DataTable))

                    dtRspnDoc.TableName = "Table1"
                    dtRspnDataset.Tables.Add(dtRspnDoc)
                    resultSet("Data") = dtRspnDataset
                    resultSet("TrxCode") = "Y"
                    resultSet("TrxMsg") = "Success"
                Else
                    resultSet("TrxCode") = "N"
                    resultSet("TrxMsg") = "Fail"
                End If
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try
            Return resultSet
        End Function

        Public Shared Function SendMail(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim sql As SqlBox = Nothing
            Dim smtpClient As System.Net.Mail.SmtpClient = Nothing
            Dim count As Integer = 0
            '오류난 이메일 담고있는 변수
            Dim Errstr As String = String.Empty
            Dim ErrMsg As String = String.Empty

            Try
                If SessionInfo.Email = "" Then
                    ThrowMsg(ErrorOccur, "Register your email in User Management - Manage My Information!")
                End If
                If IsNothing(ds.Tables("EMAIL_INFO")) Then ThrowMsg(ErrorOccur, "An error occurred while sending the email. (EMAIL_INFO) Missing table")
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E1" Else ResultSet("TrxCode") = "N1"
                ResultSet("TrxMsg") = ex.Message
                ResultSet("TrxStr") = Errstr
                Return ResultSet
            End Try

            Try

                For Each dr As DataRow In ds.Tables("EMAIL_INFO").Rows
                    Try
                        'db.BeginTransaction()

                        '인증키 값 추가
                        Dim AuthKey As String = Now.ToString("yyyyMMddhhmmssffftt") & Int(Rnd() * 9)
                        Dim Domain As String = SessionOfficeInfo.Domain

                        ''사용자관련 메일(회원가입 승인, 거절, 중지)는 자동링크를 타지 않음으로 암호화 하지 않음
                        'If dr("PKGE_TYPE").ToString <> "USR" Then
                        '    ''암호화 풀어서 인증키 암호화 된것으로 같이 추가
                        '    'Dim encryptString As String = decryptAES256(dr("BTN_URL").ToString)

                        '    ''버튼 링크되어있는 암호화 복호화하기
                        '    'Dim BtnUrl = JsonConvert.DeserializeObject(encryptString)

                        '    Dim ht As Hashtable = New Hashtable()
                        '    ht.Add("AUTH_KEY", AuthKey)

                        '    Dim encryptString As String = JsonConvert.SerializeObject(ht)
                        '    dr("BTN_URL") = encryptAES256(encryptString)

                        '    ht = New Hashtable()
                        '    ht.Add("DOMAIN", Domain)

                        '    encryptString = JsonConvert.SerializeObject(ht)
                        '    Domain = encryptAES256(encryptString)

                        'End If

                        Dim mailMessage As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage()
                        mailMessage.From = New System.Net.Mail.MailAddress("friend@yjit.co.kr")

                        'If SessionInfo.AuthorizationType.Substring(0, 1) = "0" OrElse SessionInfo.UserID = "ELVIS" Then
                        '    mailMessage.To.Add(New System.Net.Mail.MailAddress("yjkim@yjit.co.kr"))
                        '    mailMessage.CC.Add(New System.Net.Mail.MailAddress("nnow@yjit.co.kr"))
                        '    mailMessage.CC.Add(New System.Net.Mail.MailAddress("ebkim@yjit.co.kr"))
                        'Else
                        Dim ToMail() As String = dr("CUST_PIC_MAIL").ToString.Split(";")
                        For i As Integer = 0 To ToMail.Length - 1
                            mailMessage.To.Add(New System.Net.Mail.MailAddress(ToMail(i)))

                        Next
                        'End If


                        'mailMessage.Bcc
                        'mailMessage.ReplyTo
                        mailMessage.Priority = Net.Mail.MailPriority.High
                        mailMessage.IsBodyHtml = True
                        mailMessage.Subject = dr("TITLE").ToString

                        ''파일 첨부 로직 추가
                        'If Not IsNothing(ds.Tables("FILE_INFO")) Then
                        '    For Each drFile As DataRow In ds.Tables("FILE_INFO").Rows
                        '        If drFile("MNGT_NO").ToString = dr("MNGT_NO").ToString Then
                        '            Dim oAtt As System.Net.Mail.Attachment
                        '            For Each dr As DataRow In dsRet.Tables("WG2").Rows
                        '                If System.IO.File.Exists(HttpContext.Current.Server.MapPath(drFile("FILE_PATH").ToString & drFile("FILE_NM").ToString)) Then
                        '                    mailMessage.Attachments.Add(New System.Net.Mail.Attachment(HttpContext.Current.Server.MapPath(drFile("FILE_PATH").ToString & drFile("FILE_NM").ToString)))
                        '                End If
                        '            Next
                        '        End If

                        '    Next
                        'End If

                        Dim sBody As String = ""
                        sBody &= "<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">" & Chr(13) & Chr(10)
                        sBody &= "<html xmlns=""http://www.w3.org/1999/xhtml"">" & Chr(13) & Chr(10)
                        sBody &= "<head>" & Chr(13) & Chr(10)
                        sBody &= "<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />" & Chr(13) & Chr(10)
                        sBody &= "    <!--[if !mso]><!-->" & Chr(13) & Chr(10)
                        sBody &= "        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />" & Chr(13) & Chr(10)
                        sBody &= "    <!--<![endif]-->" & Chr(13) & Chr(10)
                        sBody &= "    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">" & Chr(13) & Chr(10)
                        sBody &= "    <title></title>" & Chr(13) & Chr(10)
                        sBody &= "</head>" & Chr(13) & Chr(10)
                        sBody &= "<body style=""margin: 0; padding: 0;"">" & Chr(13) & Chr(10)
                        sBody &= "   " & Chr(13) & Chr(10)
                        sBody &= "   <!-- 메일시작 -->" & Chr(13) & Chr(10)
                        sBody &= "   <div style=""max-width: 700px;margin: 0 auto;width: 100%;"" align=""center"">" & Chr(13) & Chr(10)
                        sBody &= "      <table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""100%"" align=""center"" style=""margin: 0 auto;"">" & Chr(13) & Chr(10)
                        sBody &= "         <tr>" & Chr(13) & Chr(10)
                        sBody &= "            <td valign=""middle"" style=""padding:0 13px;background-color: #ec6126;color: #ffffff;font-size: 20px;height:70px;letter-spacing:-1px;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;"">" & Chr(13) & Chr(10)
                        sBody &= " 						              <div style='max-width: 610px;margin: 0 auto'> 안녕하세요. <strong>양재아이티</strong> 입니다.</div>" & Chr(13) & Chr(10)
                        sBody &= "            </td>" & Chr(13) & Chr(10)
                        sBody &= "         </tr>" & Chr(13) & Chr(10)

                        If dr("SUB_TITLE").ToString <> "" Then
                            sBody &= "         <tr>" & Chr(13) & Chr(10)
                            sBody &= "            <td valign=""top"" align=""center"" style=""padding:80px 0 50px;background-color: #ffffff;color: #666666;font-size: 15px;letter-spacing:-1px;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">" & Chr(13) & Chr(10)
                            sBody &= "               <span style=""font-weight: 600;color: #111111;""><pre>" & dr("SUB_TITLE").ToString & "</pre></span>" & Chr(13) & Chr(10)
                            sBody &= "            </td>" & Chr(13) & Chr(10)
                            sBody &= "         </tr>" & Chr(13) & Chr(10)
                        End If

                        If IsNothing(ds.Tables("EMAIL_CONTENT")) Then ThrowMsg(ErrorOccur, "An error occurred while sending the email. (EMAIL_CONTENT) Missing table")

                        sBody &= "         <tr>" & Chr(13) & Chr(10)
                        sBody &= "            <td valign=""top"" style=""padding:0 13px;"">" & Chr(13) & Chr(10)
                        sBody &= "               <div style=""max-width: 610px;margin: 0 auto"">" & Chr(13) & Chr(10)
                        sBody &= "                  <table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""100%"" style=""border-top: 2px solid #222222;width: 100%;"">" & Chr(13) & Chr(10)

                        For Each drContent As DataRow In ds.Tables("EMAIL_CONTENT").Rows
                            If drContent("MNGT_NO").ToString = dr("MNGT_NO").ToString Then
                                If ds.Tables("EMAIL_CONTENT").Columns.Contains("TYPE") AndAlso Not ds.Tables("EMAIL_INFO").Columns.Contains("TYPE") AndAlso drContent("TYPE").ToString <> dr("TYPE").ToString Then Exit For
                                sBody &= "                <tr>" & Chr(13) & Chr(10)
                                'sBody &= "                        <td valign=""middle"" align=""center"" width=""40%"" style=""width:40%;padding:0;height:43px;font-size: 14px;color: #333333;background-color: #f8f8f8;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;"">" & Chr(13) & Chr(10)
                                sBody &= "                        <td valign=""middle"" align=""center"" width=""40%"" style=""width:20%;padding:0;height:43px;font-size: 14px;color: #333333;background-color: #f8f8f8;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;"">" & Chr(13) & Chr(10)
                                sBody &= "                              <strong>" & drContent("COLUMN").ToString & "</strong>" & Chr(13) & Chr(10)
                                sBody &= "                        </td>  " & Chr(13) & Chr(10)
                                If drContent("COLUMN").ToString <> "설치 주소" Then
                                    'sBody &= "                        <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">" & Chr(13) & Chr(10)
                                    sBody &= "                        <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;width: 30%;"">" & Chr(13) & Chr(10)
                                    sBody &= " 				              <Pre>" & drContent("DATA").ToString & "</Pre> " & Chr(13) & Chr(10)
                                    sBody &= "                        </td> " & Chr(13) & Chr(10)
                                Else
                                    'sBody &= "                        <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">" & Chr(13) & Chr(10)
                                    sBody &= "                        <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;width: 30%;"" colspan=""3"">" & Chr(13) & Chr(10)
                                    sBody &= " 				              <a href='" & drContent("DATA").ToString & "'>" & drContent("DATA").ToString & "</a> " & Chr(13) & Chr(10)
                                    sBody &= "                        </td> " & Chr(13) & Chr(10)
                                End If
                                If ds.Tables("EMAIL_CONTENT").Columns.Contains("COLUMN2") AndAlso ds.Tables("EMAIL_CONTENT").Columns.Contains("DATA2") Then
                                    If drContent("COLUMN").ToString <> "설치 주소" Then
                                        'sBody &= "                      <td valign=""middle"" align=""center"" width=""40%"" style=""width:40%;padding:0;height:43px;font-size: 14px;color: #333333;background-color: #f8f8f8;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;"">" & Chr(13) & Chr(10)
                                        sBody &= "                      <td valign=""middle"" align=""center"" width=""40%"" style=""width:20%;padding:0;height:43px;font-size: 14px;color: #333333;background-color: #f8f8f8;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;"">" & Chr(13) & Chr(10)
                                        sBody &= "                          <strong>" & drContent("COLUMN2").ToString & "</strong>" & Chr(13) & Chr(10)
                                        sBody &= "                    </td>  "
                                        'sBody &= "                        <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">" & Chr(13) & Chr(10)
                                        sBody &= "                        <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;width: 30%;"">" & Chr(13) & Chr(10)
                                        sBody &= " 				          <Pre>" & drContent("DATA2").ToString & "</Pre> " & Chr(13) & Chr(10)
                                        sBody &= "                     </td> "
                                    Else
                                        'sBody &= "                      <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;""></td>"
                                    End If
                                End If
                                sBody &= "                </tr>" & Chr(13) & Chr(10)
                            End If
                        Next
                        sBody &= " 	               </table> " & Chr(13) & Chr(10)
                        sBody &= " 	             </div> " & Chr(13) & Chr(10)
                        sBody &= "             </td>"
                        sBody &= "         </tr>"
                        If Not IsNothing(ds.Tables("EMAIL_CONTENT_SUMMARY1")) Then
                            If dr("PKGE_TYPE").ToString = "QUO" Then
                                sBody &= "         <tr>"
                                sBody &= "            <td valign=""middle"" align=""center"" width=""28%"" style=""width:28%;padding:0;height:43px;font-size: 14px;color: #333333;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;"">"
                                sBody &= "                <center>" & ds.Tables("EMAIL_CONTENT_SUMMARY1")(0)("TITLE") & "</center>" & Chr(13) & Chr(10)
                                sBody &= "            </td> "
                                sBody &= "        </tr> "
                            End If
                            sBody &= "         <tr>"
                            sBody &= "            <td valign=""top"" style=""padding:0 13px;"">"
                            sBody &= "               <div style=""max-width: 610px;margin: 0 auto"">"
                            sBody &= "                  <table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""100%"" style=""border-top: 2px solid #222222;width: 100%;"">"
                            For Each drSummary As DataRow In ds.Tables("EMAIL_CONTENT_SUMMARY1").Rows
                                If drSummary("MNGT_NO").ToString = dr("MNGT_NO").ToString Then
                                    If ds.Tables("EMAIL_CONTENT_SUMMARY1").Columns.Contains("TYPE") AndAlso ds.Tables("EMAIL_INFO").Columns.Contains("TYPE") AndAlso drSummary("TYPE").ToString <> dr("TYPE").ToString Then Exit For
                                    sBody &= "                   <tr>"
                                    sBody &= "                         <td valign=""middle"" align=""center"" width=""28%"" style=""width:28%;padding:0;height:43px;font-size: 14px;color: #333333;background-color: #f8f8f8;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;"">"
                                    sBody &= "                              <strong>" & drSummary("COLUMN").ToString & "</strong> " & Chr(13) & Chr(10)
                                    sBody &= "                        </td> "
                                    sBody &= "                        <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">"
                                    If drSummary("DATA").ToString.StartsWith("http://") Then
                                        sBody &= " 				              <a href='" & drSummary("DATA").ToString & "'>" & drSummary("DATA").ToString & "</a> " & Chr(13) & Chr(10)
                                    Else
                                        sBody &= " 				              <Pre>" & drSummary("DATA").ToString & "</Pre>  " & Chr(13) & Chr(10)
                                    End If
                                    sBody &= "                        </td>"
                                    If ds.Tables("EMAIL_CONTENT_SUMMARY1").Columns.Contains("COLUMN2") AndAlso ds.Tables("EMAIL_CONTENT_SUMMARY1").Columns.Contains("DATA2") Then
                                        sBody &= "                     <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">"
                                        sBody &= "                          <strong>" & drSummary("COLUMN2").ToString & "</strong>  " & Chr(13) & Chr(10)
                                        sBody &= "                     </td>"
                                        sBody &= "                        <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">" & Chr(13) & Chr(10)
                                        sBody &= " 				          <Pre>" & drSummary("DATA2").ToString & "</Pre>  " & Chr(13) & Chr(10)
                                        sBody &= "                       </td>"
                                    End If
                                    sBody &= "                      </tr>" & Chr(13) & Chr(10)
                                End If
                            Next
                            sBody &= "                  </table>"
                            sBody &= "               </div>"
                            sBody &= "            </td>"
                            sBody &= "         </tr>"
                        End If

                        If Not IsNothing(ds.Tables("EMAIL_CONTENT_SUMMARY2")) Then
                            sBody &= "                                 </BR> </BR></BR>" & Chr(13) & Chr(10)
                            If ds.Tables("EMAIL_INFO")(0)("PKGE_TYPE").ToString = "QUO" Then
                                sBody &= "         <tr>"
                                sBody &= "            <td valign=""middle"" align=""center"" width=""28%"" style=""width:28%;padding:0;height:43px;font-size: 14px;color: #333333;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;"">"
                                sBody &= "                <center>" & ds.Tables("EMAIL_CONTENT_SUMMARY2")(0)("TITLE") & "</center>" & Chr(13) & Chr(10)
                                sBody &= "            </td> "
                                sBody &= "        </tr> "
                            End If

                            sBody &= "         <tr>"
                            sBody &= "            <td valign=""top"" style=""padding:0 13px;"">"
                            sBody &= "               <div style=""max-width: 610px;margin: 0 auto"">"
                            sBody &= "                  <table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""100%"" style=""border-top: 2px solid #222222;width: 100%;"">"

                            For Each drSummary As DataRow In ds.Tables("EMAIL_CONTENT_SUMMARY2").Rows
                                If drSummary("MNGT_NO").ToString = dr("MNGT_NO").ToString Then
                                    If ds.Tables("EMAIL_CONTENT_SUMMARY2").Columns.Contains("TYPE") AndAlso ds.Tables("EMAIL_INFO").Columns.Contains("TYPE") AndAlso drSummary("TYPE").ToString <> dr("TYPE").ToString Then Exit For
                                    sBody &= "                   <tr>"
                                    sBody &= "                         <td valign=""middle"" align=""center"" width=""28%"" style=""width:28%;padding:0;height:43px;font-size: 14px;color: #333333;background-color: #f8f8f8;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;"">"
                                    sBody &= "                              <strong>" & drSummary("COLUMN").ToString & "</strong>  " & Chr(13) & Chr(10)
                                    sBody &= "                          </td>"
                                    sBody &= "                        <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">"
                                    sBody &= " 				               <Pre>" & drSummary("DATA").ToString & "</Pre>  " & Chr(13) & Chr(10)
                                    sBody &= "                         </td>"
                                    If ds.Tables("EMAIL_CONTENT_SUMMARY2").Columns.Contains("COLUMN2") AndAlso ds.Tables("EMAIL_CONTENT_SUMMAR2Y").Columns.Contains("DATA2") Then
                                        sBody &= "                      <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">"
                                        sBody &= "                           <strong>" & drSummary("COLUMN2").ToString & "</strong>  " & Chr(13) & Chr(10)
                                        sBody &= "                      </td>"
                                        sBody &= "                      <td valign=""middle"" align=""left"" style=""padding:0 0 0 20px;height:43px;font-size: 14px;color: #888888;border-bottom: 1px solid #eaeaea;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">"
                                        sBody &= " 				            <Pre>" & drSummary("DATA2").ToString & "</Pre>  " & Chr(13) & Chr(10)
                                        sBody &= "                      </td>"
                                    End If
                                    sBody &= "                   </tr>" & Chr(13) & Chr(10)
                                End If
                            Next
                            sBody &= "                  </table>"
                            sBody &= "               </div>"
                            sBody &= "            </td>"
                            sBody &= "         </tr>"
                        End If

                        If Not IsNothing(ds.Tables("EMAIL_CONTENT_RMK")) Then
                            For Each drRmk As DataRow In ds.Tables("EMAIL_CONTENT_RMK").Rows
                                sBody &= "         <tr>"
                                sBody &= "            <td valign=""middle""  width=""28%"" style=""width:28%;padding:0;height:43px;font-size: 14px;color: #888888;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;"">"
                                sBody &= "  &nbsp;&nbsp;&nbsp;" & drRmk("RMK").ToString & Chr(13) & Chr(10)
                                sBody &= "            </td> "
                                sBody &= "        </tr> "
                            Next
                        End If

                        sBody &= "         <tr>"
                        sBody &= "            <td valign=""middle"" align=""center"" style=""padding: 40px 0 88px"">"
                        sBody &= "               "
                        'sBody &= "               <div style=""display:inline-block;width:200px;max-width:100%;vertical-align:top"">"
                        'sBody &= "                       <table style=""table-layout:fixed;width:200px;"" border=""0"" cellpadding=""0"" cellspacing=""0"">"
                        'sBody &= "                           <tbody>"
                        'sBody &= "                              <tr>"
                        'sBody &= "                                 <td>"
                        'sBody &= "                                       <table style=""table-layout:fixed;width:100%;background:#ec6126"" border=""0"" cellpadding=""0"" cellspacing=""0"">"
                        'sBody &= "                                           <tbody>"
                        'sBody &= "                                              <tr>"
                        'sBody &= "                                                 <td height=""56"" style=""text-align:center;"">"
                        '' sBody &= " 			                            				<form action=""http://" & SessionOfficeInfo.PrimeURL.ToString & "/reTurnAPI/CallMailPage"" accept-charset=""utf-8"" name = ""PrimeMail"" method = ""post""  target=""_blank""> " & Chr(13) & Chr(10)
                        ''sBody &= " 			    					                         <input type=""hidden"" id=""paramStr"" name=""paramStr"" value=" & dr("BTN_URL").ToString & "> " & Chr(13) & Chr(10)
                        '' sBody &= " 								                           <center> <input type=""submit"" value=" & dr("BTN_NM").ToString & " style=""border:none;display:block;54px;font-size:18px;color:#fff;text-decoration:none;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;text-decoration: none;background:#ec6126"" rel=""noreferrer noopener  "" > </center>" & Chr(13) & Chr(10)
                        ''If ds.Tables("EMAIL_INFO")(0)("PKGE_TYPE").ToString <> "USR" Then
                        ''    sBody &= "                                                       <a href=""http://" & SessionOfficeInfo.PrimeURL & "/reTurnAPI/CallMailPage?param=" & dr("BTN_URL").ToString & "&params=" & Domain & """ style=""text-decoration:none !important; display:block;54px;font-size:18px;color:#fff;text-decoration:none;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;text-decoration: none;"" rel=""noreferrer noopener"" target=""_blank"">" & dr("BTN_NM").ToString & "</a>"
                        ''    'sBody &= "                                                       <a href=""http://" & SessionOfficeInfo.PrimeURL.ToString & "/reTurnAPI/CallMailPage?param=" & dr("BTN_URL").ToString & """ style=""text-decoration:none !important; display:block;54px;font-size:18px;color:#fff;text-decoration:none;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;text-decoration: none;"" rel=""noreferrer noopener"" target=""_blank"">" & dr("BTN_NM").ToString & "</a>"
                        ''Else
                        ''    sBody &= "                                                       <a href=" & dr("BTN_URL").ToString & " style=""text-decoration:none !important; display:block;54px;font-size:18px;color:#fff;text-decoration:none;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 600;text-decoration: none;"" rel=""noreferrer noopener"" target=""_blank"">" & dr("BTN_NM").ToString & "</a>"
                        ''End If
                        '' sBody &= " 						                            	</form>	 " & Chr(13) & Chr(10)
                        'sBody &= "                                                    </td>"
                        'sBody &= "                                                </tr>"
                        'sBody &= "                                            </tbody>"
                        'sBody &= "                                        </table>"
                        'sBody &= "                                    </td>"
                        'sBody &= "                                </tr>"
                        'sBody &= "                            </tbody>"
                        'sBody &= "                        </table>"
                        'sBody &= "                   </div>"
                        sBody &= "               "
                        sBody &= "            </td>"
                        sBody &= "         </tr>"

                        If dr("PKGE_TYPE").ToString = "QUO" Then
                            sBody &= "         <tr>"
                            sBody &= "            <td valign=""middle"" align=""center"" style=""padding:0 13px;background-color: #f2f2f2;height: 89px;"">"
                            sBody &= "               <div style=""max-width: 610px;margin: 0 auto;"">"
                            sBody &= "                  <p style=""font-size: 13px;color: #999999;font-family:'Noto Sans KR', 'Noto Sans', 'Malgun Gothic', 'Apple SD Gothic Neo', sans-serif;font-weight: 300;margin: 6px 0 0;"">본 메일은 발신 전용이므로 회신할 수 없습니다.</p>"
                            sBody &= "               </div>"
                            sBody &= "            </td>"
                            sBody &= "         </tr>   "
                        End If
                        sBody &= "      </table>"
                        sBody &= "   </div>"
                        sBody &= "   <!-- //메일시작 -->"
                        sBody &= "   "
                        sBody &= "   "
                        sBody &= "</body>"
                        sBody &= "</html>"
                        mailMessage.Body = sBody
                        smtpClient = New System.Net.Mail.SmtpClient()
                        smtpClient.Host = "mail.yjit.co.kr"

                        smtpClient.EnableSsl = False
                        smtpClient.Port = "587"
                        smtpClient.Credentials = New System.Net.NetworkCredential("mailmaster@yjit.co.kr", "Yjit0921)#$%")

                        Try
                            smtpClient.Send(mailMessage)
                        Catch smtpExc As System.Net.Mail.SmtpException
                            'Log error information on which email failed.
                            Throw New Exception(smtpExc.Message)
                        Catch ex As Exception
                            'Log general errors
                            Throw New Exception(ex.Message)
                        End Try

                        count = count + 1

                        ''자동링크를 걸기 위한 테이블 작업(인증키)
                        'sql = New SqlBox("FrndDocumentMgt@InsertMailAuthkey")
                        'sql.Params("AUTH_KEY") = AuthKey
                        'sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                        'sql.Params("USR_ID") = SessionInfo.UserID
                        'sql.Params("SEND_MAIL") = SessionInfo.Email
                        'sql.Params("RECEIVE_MAIL") = dr("CUST_PIC_MAIL").ToString
                        'sql.Params("MAIL_CONTENT") = sBody
                        'If ds.Tables("EMAIL_INFO").Columns.Contains("JOB_TYPE") Then
                        '    sql.Blocks("JOB_TYPE") = True
                        '    sql.Params("JOB_TYPE") = dr("JOB_TYPE").ToString
                        'End If
                        'If ds.Tables("EMAIL_INFO").Columns.Contains("FLAG") Then
                        '    sql.Blocks("FLAG") = True
                        '    sql.Params("FLAG") = dr("FLAG").ToString
                        'End If
                        'If ds.Tables("EMAIL_INFO").Columns.Contains("DOMAIN") Then
                        '    sql.Blocks("DOMAIN") = True
                        '    sql.Params("DOMAIN") = dr("DOMAIN").ToString
                        'End If
                        'If ds.Tables("EMAIL_INFO").Columns.Contains("REF1") Then
                        '    sql.Blocks("REF1") = True
                        '    sql.Params("REF1") = dr("REF1").ToString
                        'End If
                        'If ds.Tables("EMAIL_INFO").Columns.Contains("REF2") Then
                        '    sql.Blocks("REF2") = True
                        '    sql.Params("REF2") = dr("REF2").ToString
                        'End If
                        'If ds.Tables("EMAIL_INFO").Columns.Contains("REF3") Then
                        '    sql.Blocks("REF3") = True
                        '    sql.Params("REF3") = dr("REF3").ToString
                        'End If
                        'If ds.Tables("EMAIL_INFO").Columns.Contains("REF4") Then
                        '    sql.Blocks("REF4") = True
                        '    sql.Params("REF4") = dr("REF4").ToString
                        'End If
                        'If ds.Tables("EMAIL_INFO").Columns.Contains("REF5") Then
                        '    sql.Blocks("REF5") = True
                        '    sql.Params("REF5") = dr("REF5").ToString
                        'End If
                        'db.SqlSet(sql.Text)

                        'db.Commit()
                    Catch ex As Exception
                        'db.Rollback()
                        'Throw New Exception(ex.Message)
                        If String.IsNullOrEmpty(Errstr) Then
                            Errstr = dr("CUST_PIC_MAIL").ToString
                            ErrMsg = ex.Message
                        Else
                            Errstr = Errstr & "," & dr("CUST_PIC_MAIL").ToString
                        End If
                    Finally
                        'db.EndTransaction()
                    End Try
                Next

                If Not String.IsNullOrEmpty(Errstr) Then
                    Throw New Exception(Errstr)
                End If


                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Send Mail successful!"

            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ErrMsg
                ResultSet("TrxStr") = Errstr
                ResultSet("trxStrMsg") = ds.Tables("EMAIL_INFO").Rows.Count
                ResultSet("trxEndMsg") = count
            End Try

            Return ResultSet
        End Function
        '암호화 
        'Public Shared Function encryptAES256(ByVal rtnStr As String) As String
        '    Try

        '        Dim rtnStrBytes() As Byte = Encoding.UTF8.GetBytes(rtnStr)
        '        Dim rm As RijndaelManaged = New RijndaelManaged()
        '        rm.Mode = CipherMode.CBC
        '        rm.Padding = PaddingMode.PKCS7
        '        rm.KeySize = 256

        '        Dim ms As MemoryStream = New MemoryStream()
        '        Dim encryptor As ICryptoTransform = rm.CreateEncryptor(Encoding.UTF8.GetBytes(KEY_256), Encoding.UTF8.GetBytes(KEY_128))
        '        Dim CryptoStream As CryptoStream = New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
        '        CryptoStream.Write(rtnStrBytes, 0, rtnStrBytes.Length)
        '        CryptoStream.FlushFinalBlock()

        '        Dim encryptBytes() As Byte = ms.ToArray()
        '        Dim encryptString As String = Convert.ToBase64String(encryptBytes)

        '        CryptoStream.Close()
        '        ms.Close()

        '        Return encryptString
        '    Catch ex As Exception
        '        Return String.Empty
        '    End Try
        'End Function

        'Public Shared Function UnLockUser(ByVal ds As DataSet) As Dictionary(Of String, Object)
        '    Dim resultSet As New Dictionary(Of String, Object)
        '    Dim db As DBA = New DBA()
        '    Dim retDs As DataSet = New DataSet
        '    Dim sql As SqlBox
        '    Dim ErrorOccur As Boolean = True
        '    '오류난 이메일 담고있는 변수
        '    Dim Errstr As String = String.Empty
        '    '임시비밀번호 메일전송
        '    Dim dtEmail As DataTable = ds.Tables("WG1").Clone

        '    Try
        '        If Not ds.Tables.Contains("WG1") Then
        '            ThrowMsg(ErrorOccur, "Data info missing.")
        '        End If

        '        dtEmail.TableName = "WG1"

        '        'Dim dr As DataRow = ds.Tables("MAIN").Rows(0)

        '        For Each dr As DataRow In ds.Tables("WG1").Rows
        '            Try
        '                db.BeginTransaction()
        '                Dim NewPass As String = ""
        '                Dim Email As String = dr("EMAIL").ToString()
        '                Dim ran As New Random
        '                For a = 1 To 10
        '                    Dim Key As Integer = ran.Next(0, 10)
        '                    Dim Value As Integer
        '                    If Key Mod 2 = 0 Then
        '                        Value = ran.Next(65, 90)
        '                    Else
        '                        Value = ran.Next(48, 57)
        '                    End If
        '                    NewPass &= Chr(Value)
        '                Next

        '                If Trim(Email) = "" Then
        '                    ThrowMsg(ErrorOccur, "Email not found.")
        '                ElseIf Not Email.Contains("@") Then
        '                    ThrowMsg(ErrorOccur, "Email format is not.")
        '                End If

        '                sql = New SqlBox("FrndDocumentMgt@UnlockPassword")
        '                sql.Params("PSWD") = NewPass
        '                sql.Params("EMAIL") = dr("EMAIL")
        '                sql.Params("USR_ID") = SessionInfo.UserID.ToString
        '                db.SqlSet(sql.Text)


        '                sql = New SqlBox("FrndDocumentMgt@SearchUnlockPassword")
        '                sql.Params("EMAIL") = dr("EMAIL")
        '                Dim dt As DataTable = db.SqlGet(sql.Text)

        '                sql = New SqlBox("FrndDocumentMgt@InsertLog")
        '                sql.Params("EMAIL") = dr("EMAIL")
        '                sql.Params("WORK_USR_ID") = SessionInfo.UserID
        '                sql.Params("FLAG") = "I"
        '                sql.Params("COL_NM") = "PSWD"
        '                sql.Params("OLD_VAL") = dr("PSWD").ToString
        '                If dt.Rows.Count > 0 Then sql.Params("NEW_VAL") = dt(0)("PSWD").ToString
        '                db.SqlSet(sql.Text)
        '                db.Commit()

        '                dr("PSWD") = NewPass

        '                dtEmail.ImportRow(dr)

        '            Catch ex As Exception
        '                db.Rollback()
        '                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
        '                If String.IsNullOrEmpty(Errstr) Then
        '                    Errstr = dr("EMAIL").ToString
        '                Else
        '                    Errstr = Errstr & "," & dr("EMAIL").ToString
        '                End If
        '            Finally
        '                db.EndTransaction()
        '            End Try
        '        Next

        '        If Not String.IsNullOrEmpty(Errstr) Then Throw New Exception(Errstr)
        '        resultSet("TrxCode") = "Y"
        '        resultSet("TrxMsg") = "Success"

        '    Catch ex As Exception
        '        resultSet("TrxMsg") = ex.Message
        '        resultSet("TrxStr") = Errstr
        '    Finally
        '        resultSet("Data") = dtEmail
        '    End Try

        '    Return resultSet

        'End Function

        'Public Shared Function InsertMailAuth(ByVal ds As DataSet) As Dictionary(Of String, Object)
        '    Dim ResultSet As New Dictionary(Of String, Object)
        '    Dim db As DBA = New DBA()
        '    Dim ErrorOccur As Boolean = True
        '    Dim drHeader As DataRow
        '    Dim sql As SqlBox = Nothing

        '    drHeader = ds.Tables("MAIN").Rows(0)
        '    db.BeginTransaction()

        '    Try
        '        sql = New SqlBox("FrndDocumentMgt@InsertMailAuthkey")
        '        sql.Params("CUST_MAIL") = drHeader("PIC_MAIL").ToString
        '        sql.Params("PKGE_TYPE") = drHeader("MNGT_NO_TYPE").ToString
        '        sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
        '        sql.Params("USR_ID") = SessionInfo.UserID
        '        db.SqlSet(sql.Text)

        '        db.Commit()
        '        ResultSet("TrxCode") = "Y"
        '        ResultSet("TrxMsg") = "Success"

        '    Catch ex As Exception
        '        db.Rollback()
        '        If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
        '        ResultSet("TrxMsg") = ex.Message
        '    Finally
        '        db.EndTransaction()
        '    End Try

        '    Return ResultSet

        'End Function


        'Public Shared Function CreateUser(ByVal ds As DataSet) As Dictionary(Of String, Object)
        '    Dim resultSet As New Dictionary(Of String, Object)
        '    Dim sql As SqlBox = Nothing
        '    Dim ErrorOccur As Boolean = True
        '    Dim dbOLD As New DBA(GetConnectionString("ELVIS_FRIEND", ""), "ORACLE")
        '    Dim dbADMIN As New DBA(GetConnectionString("ELVIS_FRIEND", ""), "ORACLE")

        '    Try
        '        If Not ds.Tables.Contains("WG1") Then
        '            ThrowMsg(ErrorOccur, "Data info missing.")
        '        End If


        '        For Each row As DataRow In ds.Tables("WG1").Rows
        '            Dim dbNEW As New DBA(GetConnectionString("NEW", row("ELVIS_ID").ToString), "ORACLE")

        '            Try
        '                Dim strQuery As String = String.Empty
        '                Try
        '                    strQuery = String.Empty
        '                    strQuery &= vbNewLine & String.Format(" CREATE USER {0}", row("ELVIS_ID").ToString)
        '                    strQuery &= vbNewLine & String.Format(" IDENTIFIED BY ""{0}""", GetCreatePassword(row("ELVIS_ID").ToString))
        '                    strQuery &= vbNewLine & String.Format(" Default TABLESPACE ELVIS")
        '                    strQuery &= vbNewLine & String.Format(" TEMPORARY TABLESPACE TEMP")
        '                    strQuery &= vbNewLine & String.Format(" PROFILE Default")
        '                    strQuery &= vbNewLine & String.Format(" ACCOUNT UNLOCK")

        '                    dbADMIN.SqlSet(strQuery)
        '                Catch ex As Exception
        '                    Throw New Exception(ex.Message & "(계정생성)")
        '                End Try

        '                Try
        '                    dbADMIN.SqlSet(String.Format(" GRANT CONNECT To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT RESOURCE To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" ALTER USER {0} Default ROLE ALL", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT DEBUG ANY PROCEDURE To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT DEBUG CONNECT SESSION To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT CREATE TRIGGER To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT UNLIMITED TABLESPACE To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT CREATE Public DATABASE LINK To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT CREATE DATABASE LINK To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT CREATE VIEW To {0}", row("ELVIS_ID").ToString))
        '                Catch ex As Exception
        '                    Throw New Exception(ex.Message & "(계정권한생성)")
        '                End Try

        '                Try
        '                    dbADMIN.SqlSet(String.Format(" GRANT Select On ECH_IF.EDI_KL_AFR_LOG To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT Select On ECH_IF.EDI_KL_CUS_LOG To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT Select On ECH_IF.EDI_KL_KLQ_LOG To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT INSERT, SELECT, UPDATE On ETB.ACCOUNT_HD To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT Select On ETB.APERAK_DTL To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT Select On ETB.APERAK_HD To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT INSERT, Select On ETB.ATTACH_TBL To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT INSERT, Select, UPDATE On ETB.KLADDI_DTL To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT INSERT, Select, UPDATE On ETB.KLADDI_HD To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT INSERT, Select, UPDATE On ETB.MAPOUT_KEY To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT INSERT, Select, UPDATE On ETB.MAPOUT_KEY_LOG To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT INSERT, Select, UPDATE On ETB.TAX_DTL To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT INSERT, Select, UPDATE On ETB.TAX_HD To {0}", row("ELVIS_ID").ToString))
        '                    dbADMIN.SqlSet(String.Format(" GRANT INSERT, Select, UPDATE On ETB.TAX_ITEM To {0}", row("ELVIS_ID").ToString))
        '                Catch ex As Exception
        '                    '일단 스킵
        '                End Try


        '                Try
        '                    Dim dtTableList As DataTable = Nothing
        '                    Dim dtTable As DataTable = Nothing
        '                    Dim dtScript As DataTable = Nothing

        '                    strQuery = String.Empty
        '                    strQuery &= vbNewLine & String.Format(" SELECT TNAME ", row("ELVIS_ID").ToString)
        '                    strQuery &= vbNewLine & String.Format(" FROM TAB")
        '                    strQuery &= vbNewLine & String.Format(" WHERE TABTYPE='TABLE'")
        '                    dtTable = dbOLD.SqlGet(strQuery, False)
        '                    For Each rowTable As DataRow In dtTable.Rows
        '                        strQuery = String.Empty
        '                        strQuery &= vbNewLine & String.Format(" SELECT REPLACE(DBMS_METADATA.GET_DDL('TABLE','{0}','ELVIS'),'""ELVIS"".','""{1}"".') AS SCRIPT", rowTable("TNAME").ToString, row("ELVIS_ID").ToString)
        '                        strQuery &= vbNewLine & String.Format(" FROM ALL_USERS")
        '                        strQuery &= vbNewLine & String.Format(" WHERE USERNAME='ELVIS'")
        '                        dtScript = dbOLD.SqlGet(strQuery, False)
        '                        For Each rowScript As DataRow In dtScript.Rows
        '                            If dtTableList Is Nothing Then dtTableList = dtScript.Clone
        '                            dtTableList.Merge(dtScript.Copy)
        '                        Next
        '                    Next

        '                    For Each rowScript As DataRow In dtTableList.Rows
        '                        dbNEW.SqlSet(rowScript("SCRIPT").ToString)
        '                    Next
        '                Catch ex As Exception
        '                    Throw New Exception(ex.Message & "(테이블생성)")
        '                End Try
        '            Catch ex As Exception
        '                Throw New Exception(ex.Message)
        '            Finally
        '                dbOLD = Nothing
        '                dbADMIN = Nothing
        '                dbNEW = Nothing
        '            End Try
        '        Next

        '        '최종 계정 생성시간 검색후 메세지 표시 예정

        '        resultSet("TrxCode") = "Y"
        '        resultSet("TrxMsg") = "Success"
        '    Catch ex As Exception
        '        If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
        '        resultSet("TrxMsg") = ex.Message
        '    End Try

        '    Return resultSet
        'End Function
        'Private Shared Function GetCreatePassword(ByVal UserName As String) As String
        '    Return Mid(UserName, InStr(UserName, "_") + 1)
        'End Function
        'Private Shared Function GetConnectionString(ByVal ServerName As String, ByVal UserName As String) As String
        '    Dim conntionString As String = String.Empty

        '    Select Case ServerName.ToUpper
        '        Case "ELVIS_FRIEND"
        '            conntionString = "DATA SOURCE=" &
        '                   "(DESCRIPTION=(CID=GTU_APP)" &
        '                   "  (ADDRESS_LIST=" &
        '                   "    (ADDRESS=" &
        '                   "      (PROTOCOL=TCP)(HOST=175.45.195.63)(PORT=1521)" &
        '                   "    )" &
        '                   "  )" &
        '                   "  (CONNECT_DATA=(SERVICE_NAME=friendDB)(SERVER=DEDICATED))" &
        '                   ");USER ID=ELVIS_FRIEND;PASSWORD=FRIEND#!&%;"
        '        Case "CRM"
        '            conntionString = "DATA SOURCE=" &
        '                               "(DESCRIPTION=(CID=GTU_APP)" &
        '                               "  (ADDRESS_LIST=" &
        '                               "    (ADDRESS=" &
        '                               "      (PROTOCOL=TCP)(HOST=110.45.209.36)(PORT=1521)" &
        '                               "    )" &
        '                               "  )" &
        '                               "  (CONNECT_DATA=(SERVICE_NAME=ORCL)(SERVER=DEDICATED))" &
        '                               ");USER ID=CRM;PASSWORD=CRM1202;"
        '        Case "FRIEND_SYS"
        '            conntionString = "DATA SOURCE=" &
        '                                   "(DESCRIPTION=(CID=GTU_APP)" &
        '                                   "  (ADDRESS_LIST=" &
        '                                   "    (ADDRESS=" &
        '                                   "      (PROTOCOL=TCP)(HOST=175.45.195.63)(PORT=1521)" &
        '                                   "    )" &
        '                                   "  )" &
        '                                   "  (CONNECT_DATA=(SERVICE_NAME=friendDB)(SERVER=DEDICATED))" &
        '                                   ");USER ID=FRIEND_SYS;PASSWORD=FRIEND#!&%;"
        '    End Select

        '    Return conntionString
        'End Function
    End Class
End Namespace
