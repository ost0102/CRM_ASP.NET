Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OracleClient
Imports YJIT.Biz.Common
Imports System.Collections.Generic


Imports YJIT.Data

Namespace YJIT.Biz
    Public Class CrmETaxList
        Public Shared Function getConnection(ByVal IP As String, ByVal port As String, ByVal SID As String, ByVal userID As String, ByVal password As String) As OracleConnection
            Dim connectionString As String =
                "Data Source=" & _
                    "(DESCRIPTION=(CID=GTU_APP)" & _
                        "(ADDRESS_LIST=" & _
                                "(ADDRESS=" & _
                                        "(PROTOCOL=TCP)(HOST=" & IP & ")(PORT=" & port & ")" & _
                                ")" & _
                        ")(CONNECT_DATA=(SERVICE_NAME=" & SID & ")(SERVER=DEDICATED))" & _
                    ");User Id=" & userID & ";Password=" & password & ";"
            Return New OracleConnection(connectionString)
        End Function

        Public Shared Function SelectSql(ByVal conn As OracleConnection, ByVal sql As String) As DataTable
            Dim cmd As New OracleCommand
            Dim adapter As New OracleDataAdapter
            Dim retDS As New DataSet

            With cmd
                .Connection = conn
                .CommandText = sql
                .CommandType = CommandType.Text
            End With


            adapter.SelectCommand = cmd
            adapter.Fill(retDS)

            Return retDS.Tables(0).Copy
        End Function

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow

            If Not ds.Tables.Contains("MAIN") Then
                ThrowMsg(ErrorOccur, "Data info missing.")
            End If
            drHeader = ds.Tables("MAIN").Rows(0)

            Try
                'Get the list of schemas
                Dim sqlCustMst As String = "SELECT 'N' AS CHK, SVC_CD, USR_ID, USR_PWD, DB_IP AS DB_IP, DB_PORT, DB_SID, CUST_NM,DOMAIN, '' AS RESULT, 'FALSE' AS ERROR_YN" & _
                                                         "  FROM SYS_CUST_MST@ELVIS" & _
                                                         " WHERE DATA_CHK = 'Y' AND USE_YN='Y'"
                If drHeader("S_SVC_CD").ToString <> "" Then
                    sqlCustMst = sqlCustMst + "     AND SVC_CD = '" & drHeader("S_SVC_CD").ToString & "'"
                End If
                sqlCustMst = sqlCustMst + " ORDER BY SVC_CD, CUST_NM"
                Dim dtCustMst As DataTable = db.SqlGet(sqlCustMst, False)
                dtCustMst.TableName = "WG2"
                resultDs.Tables.Add(dtCustMst)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

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

        Public Shared Function Execute(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim ERROR_YN As Boolean = False
            Dim sql As SqlBox = Nothing
            Dim db As DBA = New DBA()
            Dim resultDs As New DataSet
            Dim sbRes As New StringBuilder
            Dim drHeader As DataRow
            Dim sqlStr As String = ""

            If Not ds.Tables.Contains("MAIN") Then
                ThrowMsg(ErrorOccur, "Data info missing.")
            End If
            drHeader = ds.Tables("MAIN").Rows(0)

            Dim dtCustMst As DataTable = ds.Tables("WG2")

            Dim dtLog As New DataTable
            dtLog.Columns.Add("DOMAIN")
            dtLog.Columns.Add("RESULT", GetType(Double))
            dtLog.Columns.Add("ERROR_YN")



            For i As Integer = 0 To dtCustMst.Rows.Count - 1
                If dtCustMst.Rows(i)("DB_IP").ToString <> "" AndAlso _
                        dtCustMst.Rows(i)("DB_PORT").ToString <> "" AndAlso _
                        dtCustMst.Rows(i)("DB_SID").ToString <> "" AndAlso _
                        dtCustMst.Rows(i)("USR_ID").ToString <> "" AndAlso _
                        dtCustMst.Rows(i)("USR_PWD").ToString <> "" Then

                    Try
                        Dim conn As OracleConnection = getConnection(dtCustMst.Rows(i)("DB_IP").ToString, _
                                                                        dtCustMst.Rows(i)("DB_PORT").ToString, _
                                                                        dtCustMst.Rows(i)("DB_SID").ToString, _
                                                                        dtCustMst.Rows(i)("USR_ID").ToString, _
                                                                        dtCustMst.Rows(i)("USR_PWD").ToString)
                        conn.Open()
                        sbRes = New StringBuilder
                        ERROR_YN = False

                        If dtCustMst.Rows(i)("SVC_CD").ToString = "V" Then
                            sqlStr = "SELECT COUNT(TAXNO) AS TOT_CNT FROM AC_TAX WHERE TO_CHAR(SENDDT,'YYYYMMDD') BETWEEN '" & drHeader("SEND_YYMM").ToString & "01' AND '" & drHeader("SEND_YYMM").ToString & "31'"
                        Else
                            sqlStr = "SELECT COUNT(TAX_BILL_NO) AS TOT_CNT FROM ACT_TAX_MST WHERE EDI_SEND_YMD BETWEEN '" & drHeader("SEND_YYMM").ToString & "01' AND '" & drHeader("SEND_YYMM").ToString & "31'"
                        End If
                        Dim dtRes As New DataTable
                        For Each subSql As String In sqlStr.Split(";")
                            If subSql.Trim <> "" Then
                                Try
                                    dtRes = SelectSql(conn, subSql)
                                    sbRes.Append(dtRes.Rows(0)("TOT_CNT").ToString)
                                    sbRes.Replace(vbCrLf, "")
                                    If dtRes.Rows.Count > 0 Then
                                        ERROR_YN = True
                                    End If
                                Catch ex As Exception
                                    sbRes.AppendLine(ex.Message)
                                    ERROR_YN = True
                                    dtLog.Rows.Add(dtCustMst.Rows(i)("DOMAIN").ToString, sbRes.ToString)
                                End Try
                            End If
                        Next

                        dtLog.Rows.Add(dtCustMst.Rows(i)("DOMAIN").ToString, sbRes.ToString, ERROR_YN)
                        conn.Dispose()
                    Catch ex As Exception
                        dtLog.TableName = "Log"
                        resultDs.Tables.Add(dtLog)
                        resultSet("TrxCode") = "N"
                        resultSet("TrxMsg") = dtCustMst.Rows(i)("DOMAIN").ToString & vbCrLf & "Error: Couldn't connect to the database."
                        resultSet("Data") = resultDs
                        Return resultSet
                    End Try
                Else
                    dtLog.Rows.Add(dtCustMst.Rows(i)("DOMAIN").ToString, "Error: Couldn't connect to the database.")
                End If
            Next

            dtLog.TableName = "Log"
            resultDs.Tables.Add(dtLog)
            resultSet("TrxCode") = "Y"
            resultSet("TrxMsg") = "Success"
            resultSet("Data") = resultDs
            Return resultSet

        End Function

    End Class
End Namespace
