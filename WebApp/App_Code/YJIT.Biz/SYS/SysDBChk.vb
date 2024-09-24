Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OracleClient
Imports YJIT.Biz.Common
Imports System.Collections.Generic


Imports YJIT.Data

Namespace YJIT.Biz
    Public Class SysDBChk
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

                Dim sql As New SqlBox("SysDBChk@SearchSQLList")
                sql.Params("DB_LINK") = drHeader("S_DB_LINK").ToString
                sql.Params("APPLY_SOURCE") = drHeader("S_APPLY_SOURCE").ToString

                If drHeader("S_APPLY_SOURCE").ToString <> "" Then sql.Blocks("APPLY_SOURCE") = True

                dt = db.SqlGet(sql.Text, False)

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

        Public Shared Function SearchApplyYn(ByVal ds As DataSet, ByVal SqlId As String, ByVal Apply_Source As String, ByVal DB_LINK As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim drHeader As DataRow
            Dim ErrorOccur As Boolean = True

            Try

                drHeader = ds.Tables("MAIN").Rows(0)

                Dim sql As New SqlBox("SysDBChk@SearchDBList")
                sql.Params("DB_LINK") = DB_LINK
                sql.Params("APPLY_SOURCE") = Apply_Source
                sql.Params("SQL_ID") = SqlId

                If drHeader("S_APPLY_SOURCE").ToString <> "" Then sql.Blocks("APPLY_SOURCE") = True

                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
                resultDs.Tables.Add(dt)

                sql = New SqlBox("SysDBChk@ViewSQL")
                sql.Params("SQL_ID") = SqlId
                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "Main"
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

        Public Shared Function Execute(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim ERROR_YN As Boolean = False
            Dim sql As SqlBox = Nothing
            Dim db As DBA = New DBA()
            Dim resultDs As New DataSet
            Dim sbRes As New StringBuilder

            Dim dtAlterTable As DataTable = ds.Tables("WG1NEW")
            Dim dtCustMst As DataTable = ds.Tables("WG2")

            Dim dtLog As New DataTable
            dtLog.Columns.Add("DOMAIN")
            dtLog.Columns.Add("RESULT")
            dtLog.Columns.Add("ERROR_YN")



            For i As Integer = 0 To dtCustMst.Rows.Count - 1
                If dtCustMst.Rows(i)("CHK").ToString = "Y" Then

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
                            For j As Integer = 0 To dtAlterTable.Rows.Count - 1
                                sbRes.AppendLine("ID = " & dtAlterTable.Rows(j)("SQL_ID"))
                                If dtAlterTable.Rows(j)("CHK").ToString = "Y" Then


                                    Dim dt As DataTable = db.SqlGet("SELECT SQL_STR SQL_STR FROM SYS_ALTER_TABLE WHERE SQL_ID = " & dtAlterTable.Rows(j)("SQL_ID").ToString, False)
                                    Dim sqlStr As String = dt.Rows(0)(0).ToString()
                                    Dim dtRes As New DataTable
                                    For Each subSql As String In sqlStr.Split(";")
                                        If subSql.Trim <> "" Then
                                            Try
                                                dtRes = SelectSql(conn, subSql)
                                                sbRes.AppendLine(dtRes.Rows.Count.ToString + " row(s) affected.")
                                                If dtRes.Rows.Count > 0 Then
                                                    ERROR_YN = True
                                                    For Each Col As DataColumn In dtRes.Columns
                                                        sbRes.AppendLine(String.Format("{0} : {1}", Col.ColumnName, dtRes.Rows(0)(Col.ColumnName).ToString))
                                                    Next
                                                End If
                                            Catch ex As Exception
                                                sbRes.AppendLine(ex.Message)
                                                ERROR_YN = True
                                                dtLog.Rows.Add(dtCustMst.Rows(i)("DOMAIN").ToString, sbRes.ToString.Replace(vbNewLine, "|"))
                                            End Try
                                        End If
                                    Next

                                End If
                            Next
                            dtLog.Rows.Add(dtCustMst.Rows(i)("DOMAIN").ToString, sbRes.ToString.Replace(vbNewLine, "|"), ERROR_YN)
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
                End If
            Next
            dtLog.TableName = "Log"
            resultDs.Tables.Add(dtLog)
            resultSet("TrxCode") = "Y"
            resultSet("TrxMsg") = "Success"
            resultSet("Data") = resultDs
            Return resultSet

        End Function

        Public Shared Function ExecuteString(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim ERROR_YN As Boolean = False
            Dim sql As SqlBox = Nothing
            Dim db As DBA = New DBA()
            Dim resultDs As New DataSet
            Dim sbRes As New StringBuilder

            Dim dtAlterTable As DataTable = ds.Tables("WG1NEW")
            Dim dtCustMst As DataTable = ds.Tables("WG2")

            Dim dtLog As New DataTable
            dtLog.Columns.Add("DOMAIN")
            dtLog.Columns.Add("RESULT")
            dtLog.Columns.Add("ERROR_YN")

            Dim dtWG3 As DataTable = New DataTable("WG3")



            For i As Integer = 0 To dtCustMst.Rows.Count - 1
                If dtCustMst.Rows(i)("CHK").ToString = "Y" Then

                    If dtCustMst.Rows(i)("DB_IP").ToString <> "" AndAlso
                            dtCustMst.Rows(i)("DB_PORT").ToString <> "" AndAlso
                            dtCustMst.Rows(i)("DB_SID").ToString <> "" AndAlso
                            dtCustMst.Rows(i)("USR_ID").ToString <> "" AndAlso
                            dtCustMst.Rows(i)("USR_PWD").ToString <> "" Then

                        Try
                            Dim conn As OracleConnection = getConnection(dtCustMst.Rows(i)("DB_IP").ToString,
                                                                            dtCustMst.Rows(i)("DB_PORT").ToString,
                                                                            dtCustMst.Rows(i)("DB_SID").ToString,
                                                                            dtCustMst.Rows(i)("USR_ID").ToString,
                                                                            dtCustMst.Rows(i)("USR_PWD").ToString)
                            conn.Open()
                            sbRes = New StringBuilder
                            ERROR_YN = False
                            For j As Integer = 0 To dtAlterTable.Rows.Count - 1
                                sbRes.AppendLine("ID = " & dtAlterTable.Rows(j)("SQL_ID"))
                                If dtAlterTable.Rows(j)("CHK").ToString = "Y" Then


                                    Dim dt As DataTable = db.SqlGet("SELECT SQL_STR SQL_STR FROM SYS_ALTER_TABLE WHERE SQL_ID = " & dtAlterTable.Rows(j)("SQL_ID").ToString, False)
                                    Dim sqlStr As String = dt.Rows(0)(0).ToString()
                                    Dim dtRes As New DataTable
                                    'For Each subSql As String In sqlStr.Split(";")
                                    If sqlStr.Trim <> "" Then
                                        Try
                                            dtRes = SelectSql(conn, sqlStr)
                                            sbRes.AppendLine(dtRes.Rows.Count.ToString + " row(s) affected.")
                                            If dtRes.Rows.Count > 0 Then
                                                ERROR_YN = True
                                                For Each Col As DataColumn In dtRes.Columns
                                                    sbRes.AppendLine(String.Format("{0} : {1}", Col.ColumnName, dtRes.Rows(0)(Col.ColumnName).ToString))
                                                Next

                                                dtWG3.Merge(dtRes) '자료량이 많아서 문제가 된다면 화면에서 거래처별 자료검색하는 형태로 변경해야함
                                            End If
                                        Catch ex As Exception
                                            sbRes.AppendLine(ex.Message)
                                            ERROR_YN = True
                                            dtLog.Rows.Add(dtCustMst.Rows(i)("DOMAIN").ToString, sbRes.ToString.Replace(vbNewLine, "|"))
                                        End Try

                                    End If
                                    'Next

                                End If
                            Next
                            dtLog.Rows.Add(dtCustMst.Rows(i)("DOMAIN").ToString, sbRes.ToString.Replace(vbNewLine, "|"), ERROR_YN)
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
                End If
            Next
            dtLog.TableName = "Log"
            resultDs.Tables.Add(dtLog)
            resultDs.Tables.Add(dtWG3)
            resultSet("TrxCode") = "Y"
            resultSet("TrxMsg") = "Success"
            resultSet("Data") = resultDs
            Return resultSet

        End Function

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim retDs As DataSet = New DataSet
            Dim db As New DBA
            Dim SqlId As String = ""
            Dim Apply_Source As String = ""
            Dim DB_LINK As String = ""

            Dim ErrorOccur As Boolean = True
            Dim sql As SqlBox


            Try
                Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)


                If drHeader("SQL_ID").ToString = "" Then

                    sql = New SqlBox("SysTableMgt@CreateKey")
                    Dim dt = db.SqlGet(sql.Text, False)
                    If dt.Rows.Count = 0 Then
                        ThrowMsg(ErrorOccur, "Key create error!")
                    End If
                    SqlId = dt.Rows(0)("SQL_ID").ToString

                    sql = New SqlBox("SysTableMgt@Insert")
                    sql.Params("SQL_ID") = SqlId
                    sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                    sql.Params("INS_YMD") = Date.Now.ToString("yyyyMMdd")
                    sql.Params("INS_HM") = Date.Now.ToString("HHMM")
                    db.SqlSet(sql.Text)
                Else
                    SqlId = drHeader("SQL_ID").ToString
                End If

                Apply_Source = drHeader("S_APPLY_SOURCE").ToString
                DB_LINK = drHeader("S_DB_LINK").ToString

                Dim connectionString = YJIT.Data.DbConfiguration.Current.ConnectionString

                sql = New SqlBox("SysTableMgt@Update")
                sql.Params("SQL_ID") = SqlId
                sql.Params("SQL_TYPE") = "S"
                sql.Params("TITLE") = drHeader("TITLE").ToString
                sql.Params("APPLY_SOURCE") = drHeader("APPLY_SOURCE").ToString
                sql.Params("RMK") = drHeader("RMK").ToString
                sql.Params("USE_YN") = drHeader("USE_YN").ToString
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                sql.Params("UPD_YMD") = Date.Now.ToString("yyyyMMdd")
                sql.Params("UPD_HM") = Date.Now.ToString("HHMM")


                Dim conn As New OracleClient.OracleConnection(connectionString)
                conn.Open()
                Dim cmd As New OracleClient.OracleCommand(sql.Text, conn)
                cmd.Parameters.Add("SQL_STR", drHeader("SQL_STR").ToString)
                cmd.ExecuteNonQuery()
                conn.Dispose()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
            End Try

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = SearchApplyYn(ds, SqlId, Apply_Source, DB_LINK)("Data")
            End If
            Return resultSet

        End Function
    End Class
End Namespace
