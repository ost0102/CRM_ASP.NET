Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO
Imports System.Data.OracleClient

Namespace YJIT.Biz

    Public Class CrmARMgt

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmARMgt@Search")
                'sql = New SqlBox("CrmARMgt@EmailTest")
                sql.Params("INV_YMD") = drHeader("INV_YMD").ToString.Trim
                sql.Params("AR_YMD") = drHeader("AR_YMD").ToString.Trim
                sql.Params("COCD") = drHeader("COCD").ToString.Trim
                sql.Params("SALES_CD") = drHeader("SALES_CD").ToString.Trim
                sql.Params("FNS_YN") = drHeader("FNS_YN").ToString.Trim

                sql.Params("AR_AMT") = drHeader("S_AR_AMT")

                If drHeader("COCD").ToString <> "" Then sql.Blocks("COCD") = True
                If drHeader("AR_YMD").ToString <> "" Then sql.Blocks("AR_YMD") = True
                If drHeader("SALES_CD").ToString <> "" Then sql.Blocks("SALES_CD") = True

                If drHeader("S_AR_AMT").ToString <> "0" And drHeader("S_AR_AMT").ToString <> "" Then
                    If drHeader("S_AR_UP_DOWN").ToString = "U" Then
                        sql.Blocks("UP_AMT") = True
                    Else
                        sql.Blocks("DOWN_AMT") = True
                    End If
                End If


                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

                dt.TableName = "WG1"
                'dt.TableName = "WG2"
                ResultDs.Tables.Add(dt)


                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs



            Catch ex As Exception
                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try


            Return ResultSet
        End Function


        Public Shared Function SendMail(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim Resultdt As New DataTable
            Dim dt As New DataTable

            Dim SEQ As String = ""
            Dim Sender As String = ""

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                Resultdt.Columns.Add("SENDER")
                Resultdt.Columns.Add("RECEIVER")
                Resultdt.Columns.Add("EMAIL")

                Sender = ds.Tables("SINFO").Rows(0)("SENDER").ToString

                db.BeginTransaction()

                ' 선택한 Row -> 메일을 보내는 대상
                For Each dr As DataRow In ds.Tables("WG1").Rows
                    'For Each dr As DataRow In ds.Tables("WG2").Rows  -->TEST용
                    If dr("CHK_FLAG") = "Y" Then
                        Dim sEmailText As New StringBuilder

                        ' 시퀸스 따는 로직
                        sql = New SqlBox("CrmARMgt@SeqMake")
                        dt = db.SqlGet(sql.Text, False)

                        SEQ = dt.Rows(0)("SEQ").ToString

                        Dim a As String = dr("CHDATE").ToString

                        Dim YEAR As String = Left(a, 4)
                        Dim MON As String = Mid(a, 5, 2)
                        Dim DAY As String = Right(a, 2)

                        Dim tanm As String = Left(dr("TANM").ToString, 3)

                        ' 메일 보낼거 만드는 로직
                        With sEmailText
                            .Append("<html>                                                                                                           ")
                            .Append("<body>                                                                                                           ")
                            .Append(" <h2>양재아이티 </h2>                                                                                            ")
                            .Append("<hr></hr>                                                                                                        ")
                            .Append("<p>주 소 : 서울특별시 구로구 디지털로34길 43, 609호,610호(구로동, 코오롱싸이언스밸리1차) (우편번호:08378)</p>    ")
                            .Append("<p>T E L : 1522-7422      F A X : 02-2025-2778</p>                                                              ")
                            .Append("<br /><br />                                                                                                     ")
                            ' --------------
                            .Append("<p>문서번호 : " & Now().ToString("yyyyMMdd") & "-" & SEQ.ToString & "</p>                                                                               ")
                            .Append("<p>시행일자 :" & Now().ToString("yyyy년 MM월 dd일") & "</p>                                                        ")
                            .Append("<p>수    신 :" & dr("TANM").ToString & "</p>                                                                     ")
                            .Append("<p>참    조 :</p>                                                                                                ")
                            .Append("<p>제    목 : 채 권, 채 무 조 회</p>                                                                             ")
                            ' ---------------
                            .Append("<br /><br /><br /><br />                                                                                         ")
                            .Append("<p>" & tanm & " 담당자님 안녕하십니까?</p>                                                           ")
                            .Append("<p>당사의 프로그램을 이용해주셔서 깊은 감사를 드리며, 아울러 귀사의 무궁한 발전을 기원드립니다.</p>              ")
                            .Append("<p>귀사에게 청구된 사용료가 일정기간 연체가 되어 부득이하게 메일을 드립니다.</p>                                 ")
                            .Append("<p>내용을 확인하셔서 입금을 부탁드리며, 궁금한 내용은 언제든지 연락을 주시기 바랍니다.</p>                       ")
                            .Append("<p>당사는 항상 최선을 다하여 귀사에게 서비스 할 것을 약속드리며, 불편사항은 언제든지 연락을 주시면</p>           ")
                            .Append("<p>개선하도록 노력하겠습니다.    </p>                                                                            ")
                            .Append("<p>감사합니다.</p>                                                                                               ")
                            .Append("<br /><br /><br /><br />                                                                                         ")
                            .Append("<p><연체정보></p>                                                                                                ")
                            .Append("<p>기준일 : " & Now().ToString("yyyy년 MM월 dd일") & "</p>                                                       ")
                            .Append("<p>미 수 잔 액 :" & dr("AMT").ToString & "원 </p>                                                                ")
                            .Append("<p>최종입금일 : " & YEAR & "년 " & MON & " 월 " & DAY & " 일" & "</p>                                            ")
                            ' 하드코딩 정보 - 양재아이티 계좌정보 및, 담당자, 직통 번호
                            .Append("<p>계 좌 번 호 : 우리은행 1005-202-553719 (예금주: 양재아이티주식회사)</p>                                       ")
                            .Append("<p>담당자 : 김보경</p>                                                                                           ")
                            .Append("<p>직통 : 070-4365-4687</p>                                                                                      ")
                            .Append("</body>                                                                                                          ")
                            .Append("</html>  ")
                        End With

                        ' EMAIL로 보낼 HTML페이지, 받는사람 이메일
                        Dim Adddr As DataRow = Resultdt.NewRow
                        Adddr("SENDER") = Sender
                        Adddr("EMAIL") = sEmailText.ToString
                        'Adddr("RECEIVER") = "ebkim@yjit.co.kr"
                        Adddr("RECEIVER") = SessionInfo.Email
                        'Adddr("RECEIVER") = dr("RECEIVER").ToString
                        'Adddr("RECEIVER") = dr("E_MAIL").ToString

                        ' 생성한 Email을 dt에 넣어줌
                        Resultdt.Rows.Add(Adddr)

                        ' 메일 로그 저장
                        sql = New SqlBox("CrmARMgt@SearchEmaillog")
                        sql.Params("CUST_CD") = Trim(dr("COCD").ToString)
                        dt = db.SqlGet(sql.Text, False)
                        If dt.Rows.Count > 0 Then
                            sql = New SqlBox("CrmARMgt@UpdateEmailLog")
                            sql.Params("RECEIVER") = Adddr("RECEIVER").ToString
                            'sql.Params("RECEIVER") = dr("RECEIVER").ToString
                            sql.Params("MAIL") = Now.ToString("yyyyMMdd")
                            sql.Params("CUST_CD") = Trim(dr("COCD").ToString)
                            sql.Params("SEQ") = SEQ

                            db.SqlSet(sql.Text)
                        Else
                            sql = New SqlBox("CrmARMgt@InsertEmailLog")
                            sql.Params("SENDER") = Sender.ToString
                            sql.Params("RECEIVER") = Adddr("RECEIVER").ToString
                            'sql.Params("RECEIVER") = dr("RECEIVER").ToString
                            sql.Params("MAIL") = Now.ToString("yyyyMMdd")
                            sql.Params("CUST_CD") = Trim(dr("COCD").ToString)
                            sql.Params("SEQ") = SEQ

                            db.SqlSet(sql.Text)
                        End If
                        End If
                Next

                db.Commit()

                Resultdt.TableName = "EMAILS"
                ResultDs.Tables.Add(Resultdt)

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet
        End Function

    End Class
End Namespace
