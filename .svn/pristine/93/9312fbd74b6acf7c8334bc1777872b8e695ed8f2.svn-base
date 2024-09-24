Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common
Imports YJIT.Biz.SysDBMgt
Imports System.Data.OracleClient

Namespace YJIT.Biz
    Public Class CrmTaxNotiMgt
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim drDtl As DataRow
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("CrmTaxNotiMgt@Search")

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                '현재시간 블럭문
                sql.Params("ST_HM") = drHeader("ST_HM").ToString
                If drHeader("ST_HM").ToString <> "" Then sql.Blocks("ST_HM") = True

                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function
        Public Shared Function SearchDetail(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim drDtl As DataRow
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("CrmTaxNotiMgt@Search")

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)
                drDtl = ds.Tables("WG1").Rows(0)

                sql.Params("SEQ") = drDtl("SEQ").ToString
                If drDtl("SEQ").ToString <> "" Then sql.Blocks("SEQ") = True

                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable = Nothing
            Dim ErrorOccur As Boolean = True
            Dim cnt As Integer = 0


            resultSet("TrxCode") = "E"
            resultSet("TrxMsg") = "Error"

            Try
                db.BeginTransaction()

                Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)
                Dim nextSeq As String = 0

                If drHeader("_INSFLAG") = "I" Then
                    sql = New SqlBox("CrmTaxNotiMgt@MaxNum")
                    dt = db.SqlGet(sql.Text, False)
                    If dt.Rows.Count > 0 Then
                        nextSeq = dt.Rows(0)("NEXT_NUM").ToString.Trim
                    End If
                End If

                Select Case drHeader("_INSFLAG")
                    Case "I"
                        sql = New SqlBox("CrmTaxNotiMgt@Insert")
                        sql.Params("SEQ") = nextSeq
                    Case "U"
                        sql = New SqlBox("CrmTaxNotiMgt@Update")
                        sql.Params("SEQ") = drHeader("SEQ")
                    Case "D"
                        sql = New SqlBox("CrmTaxNotiMgt@Delete")
                        sql.Params("SEQ") = drHeader("SEQ")
                End Select
                sql.Params("OFFICE_CD") = drHeader("OFFICE_CD")
                sql.Params("NOTI_TYPE") = drHeader("NOTI_TYPE")
                sql.Params("DOMAIN") = drHeader("DOMAIN")
                sql.Params("CYCLE_TYPE") = drHeader("CYCLE_TYPE")
                sql.Params("ST_YMD") = drHeader("ST_YMD")
                sql.Params("ST_HM") = drHeader("ST_HM")
                sql.Params("DAYS") = drHeader("DAYS")
                sql.Params("SUN") = drHeader("SUN")
                sql.Params("MON") = drHeader("MON")
                sql.Params("TUE") = drHeader("TUE")
                sql.Params("WED") = drHeader("WED")
                sql.Params("THU") = drHeader("THU")
                sql.Params("FRI") = drHeader("FRI")
                sql.Params("SAT") = drHeader("SAT")
                sql.Params("DAY1") = drHeader("DAY1")
                sql.Params("DAY2") = drHeader("DAY2")
                sql.Params("DAY3") = drHeader("DAY3")
                sql.Params("DAY4") = drHeader("DAY4")
                sql.Params("DAY5") = drHeader("DAY5")
                sql.Params("DAY5") = drHeader("DAY5")
                sql.Params("SUBJ") = drHeader("SUBJ")
                sql.Params("CONT1") = drHeader("CONT1")
                sql.Params("CONT2") = drHeader("CONT2")
                sql.Params("CONT3") = drHeader("CONT3")
                sql.Params("CONT4") = drHeader("CONT4")

                sql.Params("USR_ID") = SessionInfo.UserID
                sql.Params("USE_YN") = drHeader("USE_YN")

                db.SqlSet(sql.Text)

                db.Commit()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet
        End Function
        Public Shared Function UpdateStatus(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable = Nothing
            Dim ErrorOccur As Boolean = True
            Dim cnt As Integer = 0


            resultSet("TrxCode") = "E"
            resultSet("TrxMsg") = "Error"

            Try
                db.BeginTransaction()

                Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmTaxNotiMgt@UpdateDate")
                sql.Params("SEQ") = drHeader("SEQ")
                db.SqlSet(sql.Text)

                db.Commit()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet
        End Function


        Private Shared Function SaveTable(ByVal db As DBA, ByVal TableName As String, ByRef dt As DataTable) As Integer
            Dim cnt As Integer = 0
            Dim Sql As SqlBox = Nothing

            Select Case TableName.ToUpper
                Case "CRM_PROJECT_MST"
                    For Each dr As DataRow In dt.Rows
                        Select Case dr("_INSFLAG")
                            Case "I"
                                Sql = New SqlBox("CrmProjectMgt@Insert")
                            Case "U"
                                Sql = New SqlBox("CrmProjectMgt@Update")
                            Case "D"
                                Sql = New SqlBox("CrmProjectMgt@Delete")
                        End Select
                        Sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID
                        YJQuery.SaveRow(db, Sql, dr("_INSFLAG"), dr)
                        db.SqlSet(Sql.Text)

                        cnt += 1
                    Next
            End Select

            Return cnt
        End Function
        Public Shared Function Gather(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim sql As SqlBox = Nothing
            Dim db As DBA = New DBA()
            Dim resultDs As New DataSet
            Dim drHeader As DataRow

            If Not ds.Tables.Contains("MAIN") Then
                ThrowMsg(ErrorOccur, "Data info missing.")
            End If
            'Dim dtCustMst As DataTable = ds.Tables("WG1")

            Try
                sql = New SqlBox("CrmTaxNotiMgt@SearchTarget")
                drHeader = ds.Tables("MAIN").Rows(0)

                '현재시간 블럭문
                sql.Params("ST_HM") = drHeader("ST_HM").ToString
                If drHeader("ST_HM").ToString <> "" Then sql.Blocks("ST_HM") = True

                Dim dtt As DataTable = db.SqlGet(sql.Text, False)
                dtt.TableName = "TGT"

                '해당 DB로 연결
                Dim dtr As DataTable
                dtr = New DataTable
                For Each dr As DataRow In dtt.Rows

                    sql = New SqlBox("CrmTaxNotiMgt@SearchEachData")
                    sql.Params("DOMAIN") = dr("DOMAIN").ToString
                    Dim dte As DataTable = db.SqlGet(sql.Text, False)

                    If dte.Rows.Count > 0 Then

                        Dim conn As OracleConnection = getConnection(dte.Rows(0)("DB_IP").ToString, _
                                                dte.Rows(0)("DB_PORT").ToString, _
                                                dte.Rows(0)("DB_SID").ToString, _
                                                dte.Rows(0)("USR_ID").ToString, _
                                                dte.Rows(0)("USR_PWD").ToString)

                        Dim transaction As OracleTransaction

                        Try
                            conn.Open()
                            'transaction = conn.BeginTransaction()
                            Dim sqlstr As String
                            Dim cmd As New OracleCommand
                            cmd.Connection = conn

                            Dim stYmd As String = ""
                            Dim toYmd As String = ""

                            Dim currDay As String = Now.ToString("dd")
                            Dim currMonth As String = Now.ToString("yyyyMM")
                            Dim prevMonth As String = Now.AddMonths(-1).ToString("yyyyMM")


                            Select Case dr("DOMAIN").ToString
                                Case "SISK.ELVIS.COM"
                                    If currDay <= "01" Then
                                        stYmd = prevMonth & "01"
                                        toYmd = prevMonth & "31"
                                    ElseIf currDay <= "17" Then
                                        stYmd = currMonth & "01"
                                        toYmd = currMonth & "10"
                                    ElseIf currDay <= "24" Then
                                        stYmd = currMonth & "01"
                                        toYmd = currMonth & "17"
                                    End If
                                Case Else
                                    If currDay > "10" Then
                                        stYmd = currMonth & "01"
                                        toYmd = currMonth & "31"
                                    Else
                                        stYmd = prevMonth & "01"
                                        toYmd = prevMonth & "31"
                                    End If
                            End Select

                            '매출과 매입 구분
                            If dr("SEQ").ToString = "000001" Then '매출인 경우

                                sqlstr = " SELECT   "
                                sqlstr = sqlstr & "     '" & dr("SEQ") & "' AS NUM "
                                sqlstr = sqlstr & "     ,  MAX(BRANCH_CD) AS BRANCH_CD"
                                sqlstr = sqlstr & "     , TAX_BILL_NO"
                                sqlstr = sqlstr & "     , MAX(ISSUE_YMD) AS ISSUE_YMD"
                                sqlstr = sqlstr & "     , CUST_CD "
                                sqlstr = sqlstr & "     , MAX(CUST_NM) AS CUST_NM"
                                sqlstr = sqlstr & "     , MAX(MNGT_NO) AS MNGT_NO"
                                sqlstr = sqlstr & "     , SUM(LOC_AMT) AS LOC_AMT"
                                sqlstr = sqlstr & "     , SUM(FREE_AMT) AS FREE_AMT"
                                sqlstr = sqlstr & "     , SUM(VAT_AMT) AS VAT_AMT"
                                sqlstr = sqlstr & "     , SUM(FREE_VAT_AMT) AS FREE_AMT_AMT"
                                sqlstr = sqlstr & "     , SUM(LOC_AMT+VAT_AMT) AS SUM_AMT"
                                sqlstr = sqlstr & "     , MAX(INV_NO) AS INV_NO"
                                sqlstr = sqlstr & "     , MAX(VAT_TYPE) AS VAT_TYPE"
                                sqlstr = sqlstr & "     , MAX(RMK) AS RMK"
                                sqlstr = sqlstr & "     , TRIM(MAX(CUST_EMAIL)) AS CUST_EMAIL"
                                sqlstr = sqlstr & "     , MAX(EDI_VENDOR) AS EDI_VENDOR"
                                sqlstr = sqlstr & "     , MAX(EDI_SEND_STATE) AS EDI_SEND_STATE"
                                sqlstr = sqlstr & "     , MAX(SENDER_COMP_NM) AS SENDER_COMP_NM"
                                sqlstr = sqlstr & "     , TRIM(MAX(SENDER_EMAIL)) AS SENDER_EMAIL"
                                sqlstr = sqlstr & "     , MAX(SENDER_ID) AS SENDER_ID"
                                sqlstr = sqlstr & "     , MAX(SENDER_NM) AS SENDER_NM"
                                sqlstr = sqlstr & "     , MAX(SENDER_TEL) AS SENDER_TEL"
                                sqlstr = sqlstr & "     , MAX(EDI_MSG_ID) AS EDI_MSG_ID"
                                sqlstr = sqlstr & "     , MAX(OFFICE_CD) AS OFFICE_CD"
                                sqlstr = sqlstr & "     , MAX(SUBJ) AS SUBJE"
                                sqlstr = sqlstr & "     , MAX(CONT1) AS BODYCONT1"
                                sqlstr = sqlstr & "     , MAX(CONT2) AS BODYCONT2"
                                sqlstr = sqlstr & "     , MAX(CONT3) AS BODYCONT3"
                                sqlstr = sqlstr & "       FROM ( "
                                sqlstr = sqlstr & "       SELECT     A.BRANCH_CD "
                                sqlstr = sqlstr & "             , A.TAX_BILL_NO "
                                sqlstr = sqlstr & "             , MAX(A.ISSUE_YMD) AS ISSUE_YMD "
                                sqlstr = sqlstr & "             , A.CUST_CD "
                                sqlstr = sqlstr & "             , MAX(A.CUST_NM)    AS CUST_NM "
                                sqlstr = sqlstr & "             , MAX(A.MNGT_NO)     AS MNGT_NO "
                                sqlstr = sqlstr & "             , MAX(CASE WHEN X.FREE_YN = 'Y' THEN 0 ELSE X.LOC_AMT END) AS LOC_AMT "
                                sqlstr = sqlstr & "             , MAX(CASE WHEN X.FREE_YN = 'N' THEN 0 ELSE X.LOC_AMT END) AS FREE_AMT "
                                sqlstr = sqlstr & "             , MAX(CASE WHEN X.FREE_YN = 'Y' THEN 0 ELSE X.VAT_AMT END) AS VAT_AMT "
                                sqlstr = sqlstr & "             , MAX(CASE WHEN X.FREE_YN = 'N' THEN 0 ELSE X.VAT_AMT END) AS FREE_VAT_AMT "
                                sqlstr = sqlstr & "             , MAX(A.INV_NO) AS INV_NO "
                                sqlstr = sqlstr & "             , CASE WHEN MAX(A.VAT_TYPE) = '0' THEN '영세' ELSE '과세' END AS VAT_TYPE "
                                sqlstr = sqlstr & "             , MAX(A.RMK) AS RMK "
                                sqlstr = sqlstr & "             , MAX(A.CUST_EMAIL) AS CUST_EMAIL "
                                sqlstr = sqlstr & "             , MAX(CASE A.EDI_VENDOR WHEN 'L' THEN '로지스빌' WHEN 'P' THEN '범한판토스' WHEN 'Z' THEN '타중계' ELSE '' END) AS EDI_VENDOR "
                                sqlstr = sqlstr & "             , UFN_ETAX_STATUS(A.TAX_BILL_NO, MAX(A.EDI_VENDOR),'2') AS EDI_SEND_STATE "
                                sqlstr = sqlstr & "             , (SELECT MAX(NADII3036A) FROM ETB.TAX_HD Y WHERE Y.XML_MSG_ID = A.EDI_MSG_ID) AS SENDER_COMP_NM"
                                sqlstr = sqlstr & "             , (SELECT MAX(COMII_EM) FROM ETB.TAX_HD Y WHERE Y.XML_MSG_ID = A.EDI_MSG_ID) AS SENDER_EMAIL"
                                sqlstr = sqlstr & "             , A.EDI_SEND_USER AS SENDER_ID"
                                sqlstr = sqlstr & "             , MAX(U.LOC_NM) AS SENDER_NM"
                                sqlstr = sqlstr & "             , MAX(U.TEL_NO) AS SENDER_TEL"
                                sqlstr = sqlstr & "             , EDI_MSG_ID     "
                                sqlstr = sqlstr & "             , MAX(A.OFFICE_CD) AS OFFICE_CD"
                                sqlstr = sqlstr & "             , MAX(R.SUBJ) AS SUBJ"
                                sqlstr = sqlstr & "             , MAX(R.CONT1) AS CONT1"
                                sqlstr = sqlstr & "             , MAX(R.CONT2) AS CONT2"
                                sqlstr = sqlstr & "             , MAX(R.CONT3) AS CONT3"
                                sqlstr = sqlstr & "          FROM ACT_TAX_MST A "
                                sqlstr = sqlstr & "               INNER JOIN ACT_TAX_DTL X "
                                sqlstr = sqlstr & "                     ON A.TAX_BILL_NO = X.TAX_BILL_NO  "
                                sqlstr = sqlstr & "               INNER JOIN ACT_INV_DTL D "
                                sqlstr = sqlstr & "                     ON D.TAX_BILL_NO = A.TAX_BILL_NO "
                                sqlstr = sqlstr & "                        AND D.OFFICE_CD = A.OFFICE_CD "
                                sqlstr = sqlstr & "               INNER JOIN ACT_INV_MST M "
                                sqlstr = sqlstr & "                     ON D.INV_NO = M.INV_NO "
                                sqlstr = sqlstr & "                         AND M.OFFICE_CD = D.OFFICE_CD "
                                sqlstr = sqlstr & "               INNER JOIN MDM_CUST_MST C "
                                sqlstr = sqlstr & "                     ON A.CUST_CD = C.CUST_CD     "
                                sqlstr = sqlstr & "               LEFT OUTER JOIN MDM_USER_MST U"
                                sqlstr = sqlstr & "                     ON EDI_SEND_USER = USR_ID "
                                sqlstr = sqlstr & "                 LEFT OUTER JOIN CRM_TAX_NOTI_CUST@DL_CRM R "
                                sqlstr = sqlstr & "                     ON R.OFFICE_CD = A.OFFICE_CD AND R.SEQ = '000001'" 'SEQ조건 추가
                                sqlstr = sqlstr & "         WHERE   A.ISSUE_YMD >= '" & stYmd & "' "
                                sqlstr = sqlstr & "                 AND A.ISSUE_YMD <= '" & toYmd & "' "
                                sqlstr = sqlstr & "                 AND A.EDI_SEND_YMD IS NOT NULL "
                                sqlstr = sqlstr & "                 AND C.AUTO_NOTICE_TAX_YN = 'Y'"
                                sqlstr = sqlstr & "         GROUP BY A.BRANCH_CD, A.TAX_BILL_NO, A.CUST_CD, X.SEQ "
                                sqlstr = sqlstr & "             , DEPOSIT_BANK, EDI_MSG_ID, EDI_SEND_USER "
                                sqlstr = sqlstr & "    ) WHERE TRIM(EDI_SEND_STATE) = '시스템정상' "
                                If drHeader("SAMPLE") = "Y" Then
                                    sqlstr = sqlstr & "     AND TAX_BILL_NO = '" & drHeader("SAMPLENUM") & "' "
                                End If
                                sqlstr = sqlstr & "     GROUP BY TAX_BILL_NO, CUST_CD, CUST_EMAIL "
                                sqlstr = sqlstr & "     ORDER BY CUST_CD, CUST_EMAIL, SENDER_EMAIL "

                                cmd.CommandText = sqlstr
                                cmd.CommandType = CommandType.Text
                                Dim odr As OracleDataReader = cmd.ExecuteReader
                                dtr.Load(odr)

                            ElseIf dr("SEQ").ToString = "000002" Then '매입인 경우
                                sql = New SqlBox("CrmTaxNotiMgt@BuyTax")
                                sql.Params("SEQ") = dr("SEQ").ToString
                                sql.Params("STYMD") = stYmd
                                sql.Params("TOYMD") = toYmd

                                cmd.CommandText = sql.Text
                                cmd.CommandType = CommandType.Text
                                Dim odr As OracleDataReader = cmd.ExecuteReader
                                dtr.Load(odr)
                            End If

                        Catch ex As Exception
                            resultSet("TrxCode") = "E"
                            resultSet("TrxMsg") = ex.Message
                            Return resultSet
                        Finally
                            conn.Close()
                            conn.Dispose()
                        End Try

                    End If

                Next
                dtr.TableName = "WG2"
                resultDs.Tables.Add(dtr)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

                'If dtr.Rows.Count = 0 Then
                '    ThrowMsg(ErrorOccur, "Data not found!")
                'End If

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet

        End Function
        Public Shared Function GatherAtonce(ByVal pDomain As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim sql As SqlBox = Nothing
            Dim db As DBA = New DBA()
            Dim resultDs As New DataSet
            Dim drHeader As DataRow

            Try
                sql = New SqlBox("CrmTaxNotiMgt@SearchTarget")
                Dim dtt As DataTable = db.SqlGet(sql.Text, False)
                dtt.TableName = "TGT"

                '해당 DB로 연결
                Dim dtr As DataTable
                dtr = New DataTable
                For Each dr As DataRow In dtt.Rows

                    sql = New SqlBox("CrmTaxNotiMgt@SearchEachData")
                    sql.Params("DOMAIN") = pDomain
                    Dim dte As DataTable = db.SqlGet(sql.Text, False)

                    If dte.Rows.Count > 0 Then

                        Dim conn As OracleConnection = getConnection(dte.Rows(0)("DB_IP").ToString, _
                                                dte.Rows(0)("DB_PORT").ToString, _
                                                dte.Rows(0)("DB_SID").ToString, _
                                                dte.Rows(0)("USR_ID").ToString, _
                                                dte.Rows(0)("USR_PWD").ToString)

                        Dim transaction As OracleTransaction

                        Try
                            conn.Open()
                            'transaction = conn.BeginTransaction()
                            Dim sqlstr As String
                            Dim cmd As New OracleCommand
                            cmd.Connection = conn

                            Dim stYmd = dtt.Rows(0)("SEND_YMD").ToString
                            Dim toYmd = Mid(dtt.Rows(0)("SEND_YMD").ToString, 1, 6) & "31"

                            sqlstr = " SELECT   "
                            sqlstr = sqlstr & "       MAX(BRANCH_CD) AS BRANCH_CD"
                            sqlstr = sqlstr & "     , TAX_BILL_NO"
                            sqlstr = sqlstr & "     , MAX(ISSUE_YMD) AS ISSUE_YMD"
                            sqlstr = sqlstr & "     , MAX(CUST_NM) AS CUST_NM"
                            sqlstr = sqlstr & "     , MAX(MNGT_NO) AS MNGT_NO"
                            sqlstr = sqlstr & "     , SUM(LOC_AMT) AS LOC_AMT"
                            sqlstr = sqlstr & "     , SUM(FREE_AMT) AS FREE_AMT"
                            sqlstr = sqlstr & "     , SUM(VAT_AMT) AS VAT_AMT"
                            sqlstr = sqlstr & "     , SUM(FREE_VAT_AMT) AS FREE_AMT_AMT"
                            sqlstr = sqlstr & "     , SUM(LOC_AMT+VAT_AMT) AS SUM_AMT"
                            sqlstr = sqlstr & "     , MAX(INV_NO) AS INV_NO"
                            sqlstr = sqlstr & "     , MAX(VAT_TYPE) AS VAT_TYPE"
                            sqlstr = sqlstr & "     , MAX(RMK) AS RMK"
                            sqlstr = sqlstr & "     , MAX(CUST_EMAIL) AS CUST_EMAIL"
                            sqlstr = sqlstr & "     , MAX(EDI_VENDOR) AS EDI_VENDOR"
                            sqlstr = sqlstr & "     , MAX(EDI_SEND_STATE) AS EDI_SEND_STATE"
                            sqlstr = sqlstr & "     , MAX(SENDER_COMP_NM) AS SENDER_COMP_NM"
                            sqlstr = sqlstr & "     , MAX(SENDER_EMAIL) AS SENDER_EMAIL"
                            sqlstr = sqlstr & "     , MAX(SENDER_ID) AS SENDER_ID"
                            sqlstr = sqlstr & "     , MAX(SENDER_NM) AS SENDER_NM"
                            sqlstr = sqlstr & "     , MAX(SENDER_TEL) AS SENDER_TEL"
                            sqlstr = sqlstr & "     , MAX(EDI_MSG_ID) AS EDI_MSG_ID"
                            sqlstr = sqlstr & "     , MAX(OFFICE_CD) AS OFFICE_CD"
                            sqlstr = sqlstr & "     , MAX(SUBJ) AS SUBJE"
                            sqlstr = sqlstr & "     , MAX(CONT1) AS BODYCONT1"
                            sqlstr = sqlstr & "     , MAX(CONT2) AS BODYCONT2"
                            sqlstr = sqlstr & "     , MAX(CONT3) AS BODYCONT3"
                            sqlstr = sqlstr & "       FROM ( "
                            sqlstr = sqlstr & "       SELECT     A.BRANCH_CD "
                            sqlstr = sqlstr & "             , A.TAX_BILL_NO "
                            sqlstr = sqlstr & "             , MAX(A.ISSUE_YMD) AS ISSUE_YMD "
                            sqlstr = sqlstr & "             , MAX(A.CUST_NM)    AS CUST_NM "
                            sqlstr = sqlstr & "             , MAX(A.MNGT_NO)     AS MNGT_NO "
                            sqlstr = sqlstr & "             , MAX(CASE WHEN X.FREE_YN = 'Y' THEN 0 ELSE X.LOC_AMT END) AS LOC_AMT "
                            sqlstr = sqlstr & "             , MAX(CASE WHEN X.FREE_YN = 'N' THEN 0 ELSE X.LOC_AMT END) AS FREE_AMT "
                            sqlstr = sqlstr & "             , MAX(CASE WHEN X.FREE_YN = 'Y' THEN 0 ELSE X.VAT_AMT END) AS VAT_AMT "
                            sqlstr = sqlstr & "             , MAX(CASE WHEN X.FREE_YN = 'N' THEN 0 ELSE X.VAT_AMT END) AS FREE_VAT_AMT "
                            sqlstr = sqlstr & "             , MAX(A.INV_NO) AS INV_NO "
                            sqlstr = sqlstr & "             , CASE WHEN MAX(A.VAT_TYPE) = '0' THEN '영세' ELSE '과세' END AS VAT_TYPE "
                            sqlstr = sqlstr & "             , MAX(A.RMK) AS RMK "
                            sqlstr = sqlstr & "             , MAX(A.CUST_EMAIL) AS CUST_EMAIL "
                            sqlstr = sqlstr & "             , MAX(CASE A.EDI_VENDOR WHEN 'L' THEN '로지스빌' WHEN 'P' THEN '범한판토스' WHEN 'Z' THEN '타중계' ELSE '' END) AS EDI_VENDOR "
                            sqlstr = sqlstr & "             , UFN_ETAX_STATUS(A.TAX_BILL_NO, MAX(A.EDI_VENDOR),'2') AS EDI_SEND_STATE "
                            sqlstr = sqlstr & "             , (SELECT MAX(NADII3036A) FROM ETB.TAX_HD Y WHERE Y.XML_MSG_ID = A.EDI_MSG_ID) AS SENDER_COMP_NM"
                            sqlstr = sqlstr & "             , (SELECT MAX(COMII_EM) FROM ETB.TAX_HD Y WHERE Y.XML_MSG_ID = A.EDI_MSG_ID) AS SENDER_EMAIL"
                            sqlstr = sqlstr & "             , A.EDI_SEND_USER AS SENDER_ID"
                            sqlstr = sqlstr & "             , MAX(U.LOC_NM) AS SENDER_NM"
                            sqlstr = sqlstr & "             , MAX(U.TEL_NO) AS SENDER_TEL"
                            sqlstr = sqlstr & "             , EDI_MSG_ID     "
                            sqlstr = sqlstr & "             , MAX(A.OFFICE_CD) AS OFFICE_CD"
                            sqlstr = sqlstr & "             , MAX(R.SUBJ) AS SUBJ"
                            sqlstr = sqlstr & "             , MAX(R.CONT1) AS CONT1"
                            sqlstr = sqlstr & "             , MAX(R.CONT2) AS CONT2"
                            sqlstr = sqlstr & "             , MAX(R.CONT3) AS CONT3"
                            sqlstr = sqlstr & "          FROM ACT_TAX_MST A "
                            sqlstr = sqlstr & "               INNER JOIN ACT_TAX_DTL X "
                            sqlstr = sqlstr & "                     ON A.TAX_BILL_NO = X.TAX_BILL_NO  "
                            sqlstr = sqlstr & "               INNER JOIN ACT_INV_DTL D "
                            sqlstr = sqlstr & "                     ON D.TAX_BILL_NO = A.TAX_BILL_NO "
                            sqlstr = sqlstr & "                        AND D.OFFICE_CD = A.OFFICE_CD "
                            sqlstr = sqlstr & "               INNER JOIN ACT_INV_MST M "
                            sqlstr = sqlstr & "                     ON D.INV_NO = M.INV_NO "
                            sqlstr = sqlstr & "                         AND M.OFFICE_CD = D.OFFICE_CD "
                            sqlstr = sqlstr & "               INNER JOIN MDM_CUST_MST C "
                            sqlstr = sqlstr & "                     ON A.CUST_CD = C.CUST_CD     "
                            sqlstr = sqlstr & "               LEFT OUTER JOIN MDM_USER_MST U"
                            sqlstr = sqlstr & "                     ON EDI_SEND_USER = USR_ID "
                            sqlstr = sqlstr & "                 LEFT OUTER JOIN CRM_TAX_NOTI_CUST@DL_CRM R "
                            sqlstr = sqlstr & "                     ON R.OFFICE_CD = A.OFFICE_CD "
                            sqlstr = sqlstr & "         WHERE   A.EDI_SEND_YMD >= '" & stYmd & "' "
                            sqlstr = sqlstr & "                 AND A.EDI_SEND_YMD <= '" & toYmd & "' "
                            sqlstr = sqlstr & "                 AND A.EDI_SEND_YMD IS NOT NULL "
                            sqlstr = sqlstr & "         GROUP BY A.BRANCH_CD, A.TAX_BILL_NO, X.SEQ "
                            sqlstr = sqlstr & "             , DEPOSIT_BANK, EDI_MSG_ID, EDI_SEND_USER "
                            'sqlstr = sqlstr & "    ) WHERE EDI_SEND_STATE = '시스템정상' "
                            sqlstr = sqlstr & "    ) where ROWNUM < 3 "
                            sqlstr = sqlstr & "     GROUP BY TAX_BILL_NO"
                            cmd.CommandText = sqlstr
                            cmd.CommandType = CommandType.Text
                            Dim odr As OracleDataReader = cmd.ExecuteReader
                            dtr.Load(odr)

                        Catch ex As Exception
                            resultSet("TrxCode") = "E"
                            resultSet("TrxMsg") = ex.Message
                            Return resultSet
                        Finally
                            conn.Close()
                            conn.Dispose()
                        End Try

                    End If

                Next
                dtr.TableName = "WG2"
                resultDs.Tables.Add(dtr)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

                'If dtr.Rows.Count = 0 Then
                '    ThrowMsg(ErrorOccur, "Data not found!")
                'End If

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet

        End Function
    End Class
End Namespace
