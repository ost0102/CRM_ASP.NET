Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OracleClient
Imports YJIT.Biz.Common
Imports System.Collections.Generic
Imports YJIT.Data

Namespace YJIT.Biz
    Public Class SysDBMgt
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
            Dim dt As New DataTable
            Dim drHeader As DataRow
            Dim ErrorOccur As Boolean = True

            Try
                drHeader = ds.Tables("MAIN").Rows(0)

                Dim sql As New SqlBox("SysDBMgt@SearchSQLList")
                sql.Params("DB_LINK") = drHeader("S_DB_LINK").ToString
                sql.Params("APPLY_SOURCE") = drHeader("S_APPLY_SOURCE").ToString
                dt = db.SqlGet(Sql.Text, False)

                dt.TableName = "WG1"
                resultDs.Tables.Add(dt)

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

        Public Shared Function SearchApplyYn(ByVal SqlId As String, ByVal Apply_Source As String, ByVal DB_LINK As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim ErrorOccur As Boolean = True

            Try
                'Get the list of schemas
                Dim sqlCustMst As String = Nothing
                Dim subSql As String = ""

                Dim sql As New SqlBox("SysDBMgt@SearchDBList")
                sql.Params("DB_LINK") = DB_LINK
                sql.Params("APPLY_SOURCE") = Apply_Source
                sql.Params("SQL_ID") = SqlId
                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "WG2"
                resultDs.Tables.Add(dt)

                sql = New SqlBox("SysDBMgt@ViewSQL")
                sql.Params("SQL_ID") = SqlId
                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count > 0 Then
                    resultSet("SqlStr") = dt.Rows(0)("SQL_STR").ToString
                Else
                    resultSet("SqlStr") = ""
                End If

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
            Dim sql As SqlBox = Nothing
            Dim db As DBA = New DBA()
            Dim resultDs As New DataSet


            Dim dtAlterTable As DataTable = ds.Tables("WG1NEW")
            Dim dtCustMst As DataTable = ds.Tables("WG2")

            Dim dtLog As New DataTable
            dtLog.Columns.Add("DOMAIN")
            dtLog.Columns.Add("RESULT")


            For i As Integer = 0 To dtCustMst.Rows.Count - 1
                If dtCustMst.Rows(i)("CHK").ToString = "Y" Then

                    If dtCustMst.Rows(i)("DB_IP").ToString <> "" AndAlso _
                            dtCustMst.Rows(i)("DB_PORT").ToString <> "" AndAlso _
                            dtCustMst.Rows(i)("DB_SID").ToString <> "" AndAlso _
                            dtCustMst.Rows(i)("USR_ID").ToString <> "" AndAlso _
                            dtCustMst.Rows(i)("USR_PWD").ToString <> "" Then

                        Dim conn As OracleConnection = getConnection(dtCustMst.Rows(i)("DB_IP").ToString,
                                                                        dtCustMst.Rows(i)("DB_PORT").ToString,
                                                                        dtCustMst.Rows(i)("DB_SID").ToString,
                                                                        dtCustMst.Rows(i)("USR_ID").ToString,
                                                                        dtCustMst.Rows(i)("USR_PWD").ToString)

                        Dim transaction As OracleTransaction

                        Try
                            conn.Open()
                            transaction = conn.BeginTransaction()

                            For j As Integer = 0 To dtAlterTable.Rows.Count - 1
                                If dtAlterTable.Rows(j)("CHK").ToString = "Y" Then

                                    Dim dt As DataTable = db.SqlGet("SELECT SQL_STR FROM SYS_ALTER_TABLE WHERE SQL_ID = " & dtAlterTable.Rows(j)("SQL_ID").ToString, False)
                                    Dim sqlStr As String = dt.Rows(0)(0).ToString()

                                    Dim sqlStr1Row As String = String.Empty
                                    If sqlStr.Contains(vbNewLine) Then
                                        For Each arrSqlRow As String In sqlStr.Split(vbCr)
                                            If Not String.IsNullOrEmpty(arrSqlRow.Trim) Then
                                                sqlStr1Row = arrSqlRow
                                                Exit For
                                            End If
                                        Next
                                    ElseIf sqlStr.Contains(vbLf) Then
                                        For Each arrSqlRow As String In sqlStr.Split(vbCr)
                                            If Not String.IsNullOrEmpty(arrSqlRow.Trim) Then
                                                sqlStr1Row = arrSqlRow
                                                Exit For
                                            End If
                                        Next
                                    ElseIf sqlStr.Contains(vbCr) Then
                                        For Each arrSqlRow As String In sqlStr.Split(vbCr)
                                            If Not String.IsNullOrEmpty(arrSqlRow.Trim) Then
                                                sqlStr1Row = arrSqlRow
                                                Exit For
                                            End If
                                        Next
                                    End If

                                    If sqlStr1Row.ToUpper.Contains("PROCEDURE") _
                                        Or sqlStr1Row.ToUpper.Contains("FUNCTION") _
                                        Or sqlStr1Row.ToUpper.Contains("SYS.DBMS_JOB.SUBMIT") Then

                                        Dim strKey As String = ""
                                        If (sqlStr1Row.ToUpper.Contains("SYS.DBMS_JOB.SUBMIT")) Then
                                            strKey = ""
                                        ElseIf (sqlStr1Row.ToUpper.Contains("FUNCTION")) Then
                                            strKey = "FUNCTION"
                                        Else
                                            strKey = "PROCEDURE"
                                        End If

                                        Dim cmd As New OracleCommand()
                                        cmd.Connection = conn
                                        cmd.Transaction = transaction
                                        cmd.CommandText = cmd.CommandText & "BEGIN" & Environment.NewLine
                                        cmd.CommandText = cmd.CommandText & "EXECUTE IMMEDIATE :SQL_STR;" & Environment.NewLine
                                        cmd.CommandText = cmd.CommandText & "END;"
                                        cmd.Parameters.Add("SQL_STR", OracleType.Clob)
                                        cmd.Parameters("SQL_STR").Value = sqlStr
                                        cmd.ExecuteNonQuery()

                                        If Not String.IsNullOrEmpty(strKey) Then
                                            'Compile
                                            Dim alterSQL As String = sqlStr.ToUpper.Split(New String() {strKey}, StringSplitOptions.None)(1)

                                            Select Case strKey
                                                Case "PROCEDURE"
                                                    If alterSQL.Contains(" IS" & vbCrLf) OrElse alterSQL.Contains(" AS" & vbCrLf) Then
                                                        alterSQL = alterSQL.Split(" " & vbCrLf)(1)
                                                    Else
                                                        alterSQL = alterSQL.Split("(")(0)
                                                    End If
                                                Case Else
                                                    alterSQL = alterSQL.Split("(")(0)
                                            End Select
                                            alterSQL = alterSQL.Replace("(", "").Replace(vbCrLf, "") 'USP_SEA_TRACKING_CREATE( / 괄호가 붙어있는 경우 문제됨

                                            alterSQL = "ALTER " & strKey & " " + alterSQL + " COMPILE"
                                            cmd = New OracleCommand()
                                            cmd.CommandText = alterSQL
                                            cmd.Connection = conn
                                            cmd.Transaction = transaction
                                            cmd.ExecuteNonQuery()
                                        End If
                                    Else
                                        For Each subSql As String In sqlStr.Split(";")
                                            If subSql.Trim <> "" Then
                                                Dim cmd As New OracleCommand(subSql)
                                                cmd.Connection = conn
                                                cmd.Transaction = transaction
                                                cmd.ExecuteNonQuery()
                                            End If
                                        Next
                                    End If

                                    'Insert into alter table log
                                    Dim insertLog As String = "INSERT INTO SYS_ALTER_TABLE_LOG (SQL_ID, DOMAIN, INS_USR, INS_YMD, INS_HM)  VALUES( :SQL_ID, :DOMAIN, :INS_USR, :INS_YMD, :INS_HM)"
                                    Dim connectionString = YJIT.Data.DbConfiguration.Current.ConnectionString
                                    Dim sysConn As New OracleClient.OracleConnection(connectionString)
                                    sysConn.Open()
                                    Dim sysCmd As New OracleClient.OracleCommand(insertLog, sysConn)
                                    sysCmd.Parameters.Add("SQL_ID", dtAlterTable.Rows(j)("SQL_ID").ToString)
                                    sysCmd.Parameters.Add("DOMAIN", dtCustMst.Rows(i)("DOMAIN").ToString)
                                    sysCmd.Parameters.Add("INS_USR", SessionInfo.UserID)
                                    sysCmd.Parameters.Add("INS_YMD", Date.Now.ToString("yyyyMMdd"))
                                    sysCmd.Parameters.Add("INS_HM", Date.Now.ToString("HHmmss"))
                                    sysCmd.ExecuteNonQuery()
                                    sysConn.Close()
                                    sysConn.Dispose()
                                End If
                            Next
                            dtLog.Rows.Add(dtCustMst.Rows(i)("DOMAIN").ToString, "Successful")
                            transaction.Commit()
                        Catch ex As Exception
                            transaction.Rollback() 
                            dtLog.Rows.Add(dtCustMst.Rows(i)("DOMAIN").ToString, "Error: " + ex.Message)
                        Finally 
                            conn.Close()
                            conn.Dispose()
                        End Try
                    Else
                        dtLog.Rows.Add(dtCustMst.Rows(i)("DOMAIN").ToString, "Error: Couldn't connect to the database.")
                    End If
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
