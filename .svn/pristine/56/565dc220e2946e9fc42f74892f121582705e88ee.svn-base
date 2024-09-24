Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports YJIT.Biz.Common
Imports YJIT.Data
Namespace YJIT.Biz
    Public Class SysTableMgt

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim ErrorOccur As Boolean = True
            Dim db As DBA = New DBA()
            Try
                Dim dr As DataRow = ds.Tables("MAIN").Rows(0)

                Dim sql As New StringBuilder
                sql.Append("SELECT SQL_ID, TITLE, INS_USR, INS_YMD , (SELECT CD_NM FROM MDM_COM_CODE WHERE GRP_CD = 'H01' AND  COMN_CD =  APPLY_SOURCE) AS APPLY_SOURCE FROM SYS_ALTER_TABLE WHERE SQL_TYPE = 'O'" & Environment.NewLine)

                If dr("S_SQL_ID").ToString.Trim <> "" Then
                    sql.Append("AND SQL_ID = '" & dr("S_SQL_ID").ToString.Trim & "'" & Environment.NewLine)
                End If
                If dr("S_INS_YMD_FROM").ToString.Trim <> "" Then
                    sql.Append("AND INS_YMD >= '" & dr("S_INS_YMD_FROM").ToString.Trim & "'" & Environment.NewLine)
                End If
                If dr("S_INS_YMD_TO").ToString.Trim <> "" Then
                    sql.Append("AND INS_YMD <= '" & dr("S_INS_YMD_TO").ToString.Trim & "'" & Environment.NewLine)
                End If
                If dr("S_USR_NM").ToString.Trim <> "" Then
                    sql.Append("AND INS_USR LIKE '%" & dr("S_USR_NM").ToString.Trim & "%'" & Environment.NewLine)
                End If 
                If dr("S_APPLY_SOURCE").ToString.Trim <> "" Then
                    sql.Append("AND APPLY_SOURCE = '" & dr("S_APPLY_SOURCE").ToString.Trim & "'" & Environment.NewLine)
                End If
                sql.Append("ORDER BY SQL_ID DESC")

                Dim dt As DataTable = db.SqlGet(sql.ToString, False)

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
        Public Shared Function SearchDetail(ByVal SQL_ID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim ErrorOccur As Boolean = True
            Dim db As DBA = New DBA()
            Try
                Dim sql As String = "SELECT SQL_ID, TITLE, USE_YN, RMK, SQL_STR , APPLY_SOURCE  FROM SYS_ALTER_TABLE WHERE SQL_ID = '" & SQL_ID & "'"
                Dim dt As DataTable = db.SqlGet(sql)

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
        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim retDs As DataSet = New DataSet
            Dim db As New DBA

            Dim ErrorOccur As Boolean = True
            Dim sql As SqlBox
            Dim SqlId As String = ""

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


                Dim connectionString = YJIT.Data.DbConfiguration.Current.ConnectionString

                sql = New SqlBox("SysTableMgt@Update")
                sql.Params("SQL_ID") = SqlId
                sql.Params("SQL_TYPE") = "O"
                sql.Params("TITLE") = drHeader("TITLE").ToString
                sql.Params("RMK") = drHeader("RMK").ToString
                sql.Params("USE_YN") = drHeader("USE_YN").ToString
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                sql.Params("UPD_YMD") = Date.Now.ToString("yyyyMMdd")
                sql.Params("UPD_HM") = Date.Now.ToString("HHMM")
                sql.Params("APPLY_SOURCE") = drHeader("APPLY_SOURCE").ToString
                Dim conn As New OracleClient.OracleConnection(connectionString)
                conn.Open()
                Dim cmd As New OracleClient.OracleCommand(sql.Text, conn)
                cmd.Parameters.Add("SQL_STR", drHeader("SQL_STR").ToString)
                cmd.ExecuteNonQuery()
                conn.Dispose()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("SqlId") = SqlId

            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
            End Try

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If
            Return resultSet

        End Function
        Public Shared Function NewData(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim ErrorOccur As Boolean = True
            Dim db As DBA = New DBA()
            Try
                Dim sql As String = "SELECT NVL(MAX(SQL_ID),0) + 1 AS SQL_ID FROM SYS_ALTER_TABLE"
                Dim dt As DataTable = db.SqlGet(sql)


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

    End Class
End Namespace
