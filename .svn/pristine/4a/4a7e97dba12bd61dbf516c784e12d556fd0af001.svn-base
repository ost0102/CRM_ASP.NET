Imports System.Data
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.Biz.Common

Namespace YJIT.Biz
    Public Class MdmExrateMgt_v1

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True

            ResultSet("TrxCode") = "E"
            ResultSet("TrxMsg") = "ERROR"
            ResultSet("Data") = ResultDs

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("MdmExrateMgt_v1@Search")
                sql.AllowSqlInjection = True

                sql.Params("OFFICE_CD") = "YJIT"
                sql.Params("S_EXRT_YMD") = drHeader("S_EXRT_YMD").ToString.Replace("-", "")
                If drHeader("S_SEQ") <> "" Then
                    sql.Params("SEQ") = drHeader("S_SEQ").ToString
                Else
                    sql.Params("SEQ") = "001"
                End If

                dt = db.SqlGet(sql.Text, False)

                ResultDs.Tables.Add(dt)

                dt.TableName = "WG1"


                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"


            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            End Try
            Return ResultSet
        End Function

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim dr As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable = Nothing
            Dim ErrorOccur As Boolean = True

            db.BeginTransaction()

            Try
                drHeader = ds.Tables("MAIN").Rows(0)
                 
                ' Ex. Rate Info
                dt = ds.Tables("WG1")
                For Each dr In dt.Rows
                    If Not dt.Columns.Contains("SEQ") Then dt.Columns.Add("SEQ", GetType(String))
                    If dr("SEQ").ToString = "" Then dr("SEQ") = "001"

                    '고시회차가 '001'일 경우 기존+신규 테이블 저장. 그 외에는 신규 테이블만 저장


                    If dr("SEQ").ToString = "001" Then
                        ResultSet("SEQ_001") = "자료저장중 서버에서 오류가 발생했습니다. 환율을 수동으로 등록해주세요."

                        '기존 테이블 업데이트 
                        Select Case dr("_InsFlag")
                            Case "I"
                                sql = New SqlBox("MdmExrateMgt_v1@Insert")
                            Case "U"
                                sql = New SqlBox("MdmExrateMgt_v1@Update")
                            Case "D"
                                sql = New SqlBox("MdmExrateMgt_v1@Delete")
                        End Select

                        sql.Params("OFFICE_CD") = "YJIT"
                        sql.Params("BASE_CURR") = "KRW"
                        sql.Params("CURR_CD") = dr("CURR_CD").ToString
                        sql.Params("EXRT_YMD") = drHeader("S_EXRT_YMD").ToString.Replace("-", "")
                        sql.Params("CURR_UNIT") = dr("CURR_UNIT")
                        sql.Params("CASH_BUYRT") = dr("CASH_BUYRT")
                        sql.Params("CASH_SELLRT") = dr("CASH_SELLRT")
                        sql.Params("WIRE_RECV_EXRT") = dr("WIRE_RECV_EXRT")
                        sql.Params("WIRE_SEND_EXRT") = dr("WIRE_SEND_EXRT")
                        sql.Params("EXCH_BASERT") = dr("EXCH_BASERT")
                        sql.Params("USD_CONV_RT") = dr("USD_CONV_RT")
                        sql.Params("RMK") = dr("RMK").ToString
                        If ds.Tables("MAIN").Columns.Contains("USR_ID") Then
                            sql.Params("USR_ID") = "DEMON"
                        Else
                            sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                        End If
                        db.SqlSet(sql.Text)
                    Else
                        ResultSet("SEQ_001") = ""
                    End If


                    Select Case dr("_InsFlag")
                        Case "I"
                            sql = New SqlBox("MdmExrateMgt_v1@Insert2")
                        Case "U"
                            sql = New SqlBox("MdmExrateMgt_v1@Update2")
                        Case "D"
                            sql = New SqlBox("MdmExrateMgt_v1@Delete2")
                    End Select

                    sql.Params("OFFICE_CD") = "YJIT"
                    sql.Params("BASE_CURR") = "KRW"
                    sql.Params("CURR_CD") = dr("CURR_CD").ToString
                    sql.Params("EXRT_YMD") = drHeader("S_EXRT_YMD").ToString.Replace("-", "")
                    sql.Params("CURR_UNIT") = dr("CURR_UNIT")
                    sql.Params("CASH_BUYRT") = dr("CASH_BUYRT")
                    sql.Params("CASH_SELLRT") = dr("CASH_SELLRT")
                    sql.Params("WIRE_RECV_EXRT") = dr("WIRE_RECV_EXRT")
                    sql.Params("WIRE_SEND_EXRT") = dr("WIRE_SEND_EXRT")
                    sql.Params("EXCH_BASERT") = dr("EXCH_BASERT")
                    sql.Params("USD_CONV_RT") = dr("USD_CONV_RT")
                    sql.Params("RMK") = dr("RMK").ToString
                    If ds.Tables("MAIN").Columns.Contains("USR_ID") Then
                        sql.Params("USR_ID") = "DEMON"
                    Else
                        sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    End If
                    sql.Params("SEQ") = dr("SEQ").ToString
                    db.SqlSet(sql.Text)
                Next

                ' 주말환율
                Dim Wdt As DataTable = Nothing
                sql = New SqlBox("MdmExrateMgt@WeekDay")
                sql.Params("EX_DATE") = drHeader("S_EXRT_YMD").ToString
                Wdt = db.SqlGet(sql.Text, False)
                Dim EXDATE As String
                EXDATE = drHeader("S_EXRT_YMD").ToString
                If Wdt.Rows(0)("EX_DATE").ToString = 6 Then

                    Dim yyyy As String = "2013"
                    Dim mm As String = "01"
                    Dim dd As String = "01"
                    Dim t As String
                    yyyy = EXDATE.Substring(0, 4)
                    mm = EXDATE.Substring(4, 2)
                    dd = EXDATE.Substring(6, 2)

                    Dim d As Date = CDate(yyyy & "-" & mm & "-" & dd)
                    For I = 1 To 2
                        t = d.AddDays(I).ToString("yyyyMMdd")
                        For Each dr In dt.Rows

                            sql = New SqlBox("MdmExrateMgt@Merge")

                            sql.Params("OFFICE_CD") = "YJIT"
                            sql.Params("BASE_CURR") = "KRW"
                            sql.Params("CURR_CD") = dr("CURR_CD").ToString
                            sql.Params("EXRT_YMD") = t.ToString.Replace("-", "")
                            sql.Params("CURR_UNIT") = dr("CURR_UNIT")
                            sql.Params("CASH_BUYRT") = dr("CASH_BUYRT")
                            sql.Params("CASH_SELLRT") = dr("CASH_SELLRT")
                            sql.Params("WIRE_RECV_EXRT") = dr("WIRE_RECV_EXRT")
                            sql.Params("WIRE_SEND_EXRT") = dr("WIRE_SEND_EXRT")
                            sql.Params("EXCH_BASERT") = dr("EXCH_BASERT")
                            sql.Params("USD_CONV_RT") = dr("USD_CONV_RT")
                            sql.Params("RMK") = dr("RMK").ToString
                            If ds.Tables("MAIN").Columns.Contains("USR_ID") Then
                                sql.Params("USR_ID") = "DEMON"
                            Else
                                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                            End If

                            db.SqlSet(sql.Text)

                            sql = New SqlBox("MdmExrateMgt@Merge2")

                            sql.Params("OFFICE_CD") = "YJIT"
                            sql.Params("BASE_CURR") = "KRW"
                            sql.Params("CURR_CD") = dr("CURR_CD").ToString
                            sql.Params("EXRT_YMD") = t.ToString.Replace("-", "")
                            sql.Params("CURR_UNIT") = dr("CURR_UNIT")
                            sql.Params("CASH_BUYRT") = dr("CASH_BUYRT")
                            sql.Params("CASH_SELLRT") = dr("CASH_SELLRT")
                            sql.Params("WIRE_RECV_EXRT") = dr("WIRE_RECV_EXRT")
                            sql.Params("WIRE_SEND_EXRT") = dr("WIRE_SEND_EXRT")
                            sql.Params("EXCH_BASERT") = dr("EXCH_BASERT")
                            sql.Params("USD_CONV_RT") = dr("USD_CONV_RT")
                            sql.Params("RMK") = dr("RMK").ToString
                            sql.Params("SEQ") = dr("SEQ").ToString
                            If ds.Tables("MAIN").Columns.Contains("USR_ID") Then
                                sql.Params("USR_ID") = "DEMON"
                            Else
                                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                            End If

                            db.SqlSet(sql.Text)
                        Next

                    Next

                End If

                db.Commit()
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try
            ResultSet("Data") = Search(ds)("Data")
            Return ResultSet
        End Function

        Public Shared Function Delete(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim dr As DataRow
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            db.BeginTransaction()
            Try
                dr = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("MdmExrateMgt_v1@DeleteAll")
                sql.Params("EXRT_YMD") = dr("S_EXRT_YMD").ToString.Replace("-", "")
                sql.Params("OFFICE_CD") = "YJIT"
                sql.Params("BASE_CURR") = "KRW"

                db.SqlSet(sql.Text)

                db.Commit()
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try
            Return ResultSet
        End Function

        Public Shared Function Copy(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim dr As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable = Nothing
            Dim ErrorOccur As Boolean = True

            Dim FromDate As Date
            Dim ToDate As Date
            Dim FROM_DATE As String
            Dim TO_DATE As String
            Dim EXRT_DATE As String
            Dim CURR_DATE As String
            Dim PeriodCount As Integer
            Dim sbResult As StringBuilder = New StringBuilder

            db.BeginTransaction()

            Try
                drHeader = ds.Tables("MAIN").Rows(0)
                dt = ds.Tables("WG1")

                FROM_DATE = drHeader("FROM_DATE").ToString.Replace("-", "")
                TO_DATE = drHeader("TO_DATE").ToString.Replace("-", "")
                EXRT_DATE = drHeader("S_EXRT_YMD").ToString.Replace("-", "")
                FromDate = Date.Parse(FROM_DATE.Substring(0, 4) + "-" + FROM_DATE.Substring(4, 2) + "-" + FROM_DATE.Substring(6, 2))
                ToDate = Date.Parse(TO_DATE.Substring(0, 4) + "-" + TO_DATE.Substring(4, 2) + "-" + TO_DATE.Substring(6, 2))
                PeriodCount = DateDiff(DateInterval.Day, FromDate, ToDate)

                For i = 0 To PeriodCount
                    ToDate = FromDate.AddDays(+i)
                    CURR_DATE = ToDate.ToString("yyyyMMdd")

                    sql = New SqlBox("MdmExrateMgt_v1@Check")
                    sql.Params("OFFICE_CD") = "YJIT"
                    sql.Params("BASE_CURR") = "KRW"
                    sql.Params("CURR_DATE") = CURR_DATE
                    Dim retDt As DataTable = db.SqlGet(sql.Text, False)

                    If retDt.Rows.Count = 0 Then
                        sql = New SqlBox("MdmExrateMgt_v1@Copy")
                        sql.Params("OFFICE_CD") = "YJIT"
                        sql.Params("BASE_CURR") = "KRW"
                        sql.Params("EXRT_YMD") = EXRT_DATE
                        sql.Params("CURR_DATE") = CURR_DATE
                        sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                        db.SqlSet(sql.Text)
                    Else
                        sbResult.Append(CURR_DATE.Substring(0, 4) & "-" & CURR_DATE.Substring(4, 2) & "-" & CURR_DATE.Substring(6, 2) & " exchange rate is skipped.")
                        sbResult.AppendLine()
                    End If
                Next
                db.Commit()
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success" & Environment.NewLine & sbResult.ToString
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try
            ResultSet("Data") = Search(ds)("Data")
            Return ResultSet
        End Function

        Public Shared Function GetExRate(ByVal CURR_CD As String, ByVal EXRT_YMD As String, ByVal CURR_CLS As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim Session As HttpSessionState = HttpContext.Current.Session       ' 세션 정보
            Dim db As DBA = New DBA()

            Dim sql As New SqlBox("MdmExrateMgt_v1@GetExRate")
            sql.Params("BASE_CURR") = "KRW"  '

            If CURR_CD = "KRW" Then
                sql.Params("CURR_CD") = "USD"
            Else
                sql.Params("CURR_CD") = CURR_CD
            End If
            sql.Params("EXRT_YMD") = EXRT_YMD
            sql.Params("CURR_CLS") = CURR_CLS
            sql.Params("OFFICE_CD") = "YJIT"
            Dim dt As DataTable = db.SqlGet(sql.Text)

            Try
                If dt Is Nothing Then

                    resultSet("TrxCode") = "ERROR"
                    resultSet("TrxMsg") = "Exchange Rate is not exist!"

                    resultSet("EX_RATE") = 1
                    resultSet("USD_EX_RATE") = 1
                    resultSet("CURR_UNIT") = 1

                    Return resultSet
                Else
                    If CURR_CD = "KRW" Then
                        resultSet("EX_RATE") = 1
                        resultSet("USD_EX_RATE") = dt.Rows(0)("EX_RATE")
                        resultSet("CURR_UNIT") = 1
                    Else
                        resultSet("EX_RATE") = dt.Rows(0)("EX_RATE")
                        resultSet("USD_EX_RATE") = dt.Rows(0)("USD_EX_RATE")
                        resultSet("CURR_UNIT") = dt.Rows(0)("CURR_UNIT")
                    End If
                End If
            Catch ex As Exception
                ' 에러 발생 경우 초기화 값으로 return 됨.
            End Try

            resultSet("TrxCode") = "SUCCESS"
            resultSet("TrxMsg") = "Process successful!"

            Return resultSet

        End Function

        Public Shared Function InsertAS(ByVal MSG As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim dr As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable = Nothing
            Dim ErrorOccur As Boolean = True

            db.BeginTransaction()

            Try
                'drHeader = ds.Tables("MAIN").Rows(0)
                sql = New SqlBox("MdmExrateMgt_v1@InsertAS")
                sql.Params("MNGT_NO") = String.Format("{0}", Now.ToString("yyyyMMddHHmmssffffff"))
                sql.Params("CONTENT") = MSG

                db.SqlSet(sql.Text)


                db.Commit()
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try
            Return ResultSet
        End Function

    End Class
End Namespace
