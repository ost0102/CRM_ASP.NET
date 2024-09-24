'Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Exception
'Imports System.Collections.Generic
Imports System.Data.OracleClient

Imports YJIT.Data

Namespace YJIT.Biz
    Public Class YJQuery
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return SearchEx(ds, Nothing)
        End Function
        Public Shared Function SearchYjedi(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim connectionstring As String =
                    "data source=" &
                        "(description=(cid=gtu_app)" &
                            "(address_list=" &
                                    "(address=" &
                                            "(protocol=tcp)(host=175.45.195.63)(port=1521)" &
                                    ")" &
                            ")(connect_data=(service_name=friendDB)(server=dedicated))" &
                        ");User Id=YJEDI_ESVC;Password=YjEDI#!&%1113;"

            'Dim connectionstring As String = "Data Source=CRM;User Id=CRM;Password=CRM1202;Integrated Security=no;Connection Lifetime=0;Min Pool Size=0;Max Pool Size=100;Pooling=true;Unicode=true" />
            Dim dbConnet As DBA = New DBA(connectionstring, "ORACLE")

            Return SearchEx(ds, dbConnet)
        End Function
        Public Shared Function SearchEx(ByVal ds As DataSet, Optional db As DBA = Nothing) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            'Dim db As DBA = New DBA()
            If db Is Nothing Then db = New DBA
            Dim sql As SqlBox = Nothing
            Dim dt As New DataTable

            Try
                ResultSet("TrxCode") = "E"
                ResultSet("TrxMsg") = "Error"
                ResultSet("Data") = ResultDs

                If Not ds.Tables.Contains("SqlBox") Then
                    Throw New Exception("Data info missing.")
                End If

                For Each drSqlBox As DataRow In ds.Tables("SqlBox").Rows
                    sql = New SqlBox(drSqlBox("ID").ToString)
                    sql.AllowSqlInjection = drSqlBox("AllowSqlInjection") ' in 문시 ('A','B') -> (''A'',''B'') 현상 방지 

                    '모든 조회쿼리에 포함해야하는 항목만 추가해주세요.
                    sql.Params("HQ_OFFICE_CD") = YJIT.SessionOfficeInfo.HqOfficeCode
                    sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
                    sql.Params("LANG_CD") = YJIT.SessionOfficeInfo.LanguageCode
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"

                    '화면에서 넘겨준 Params 적용
                    For Each drParams As DataRow In ds.Tables("Params").Select("TableName = '" & drSqlBox("TableName") & "'")
                        sql.Params(drParams("ID")) = drParams("Data").ToString.Trim
                    Next

                    '화면에서 넘겨준 Blocks 적용
                    For Each drBlocks As DataRow In ds.Tables("Blocks").Select("TableName = '" & drSqlBox("TableName") & "'")
                        sql.Blocks(drBlocks("ID")) = drBlocks("Data").ToString.Trim
                    Next

                    dt = db.SqlGet(sql.Text, False)
                    dt.TableName = drSqlBox("TableName")

                    If drSqlBox("IsOptional") = False Then
                        If dt.Rows.Count = 0 Then
                            ResultSet("TrxCode") = "N"
                            Throw New Exception("Data not found!")
                        End If
                    End If
                    ResultDs.Tables.Add(dt.Copy)
                Next

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function
        Public Shared Function SearchTest(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As New DataTable

            Try
                db.BeginTransaction()

                ResultSet("TrxCode") = "E"
                ResultSet("TrxMsg") = "Error"
                ResultSet("Data") = ResultDs

                If Not ds.Tables.Contains("SqlBox") Then
                    Throw New Exception("Data info missing.")
                End If

                For Each drSqlBox As DataRow In ds.Tables("SqlBox").Rows
                    sql = New SqlBox(drSqlBox("ID").ToString)
                    sql.AllowSqlInjection = drSqlBox("AllowSqlInjection") ' in 문시 ('A','B') -> (''A'',''B'') 현상 방지 

                    '모든 조회쿼리에 포함해야하는 항목만 추가해주세요.
                    sql.Params("HQ_OFFICE_CD") = YJIT.SessionOfficeInfo.HqOfficeCode
                    sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
                    sql.Params("LANG_CD") = YJIT.SessionOfficeInfo.LanguageCode
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"

                    '화면에서 넘겨준 Params 적용
                    For Each drParams As DataRow In ds.Tables("Params").Select("TableName = '" & drSqlBox("TableName") & "'")
                        sql.Params(drParams("ID")) = drParams("Data").ToString.Trim
                    Next

                    '화면에서 넘겨준 Blocks 적용
                    For Each drBlocks As DataRow In ds.Tables("Blocks").Select("TableName = '" & drSqlBox("TableName") & "'")
                        sql.Blocks(drBlocks("ID")) = drBlocks("Data").ToString.Trim
                    Next

                    dt = db.SqlGet(sql.Text, False)
                    dt.TableName = drSqlBox("TableName")

                    If drSqlBox("IsOptional") = False Then
                        If dt.Rows.Count = 0 Then
                            ResultSet("TrxCode") = "N"
                            Throw New Exception("Data not found!")
                        End If
                    End If
                    ResultDs.Tables.Add(dt.Copy)
                Next

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet
        End Function
        Public Shared Function SearchReconnect(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim dbConnet As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As New DataTable

            Try
                dbConnet.BeginTransaction()

                ResultSet("TrxCode") = "E"
                ResultSet("TrxMsg") = "Error"
                ResultSet("Data") = ResultDs

                If Not ds.Tables.Contains("SqlBox") Then
                    Throw New Exception("Data info missing.")
                End If

                If Not ds.Tables.Contains("ConnectInfo") Then
                    Throw New Exception("ConnectInfo table info missing.")
                End If

                If ds.Tables("ConnectInfo").Rows.Count = 0 Then
                    Throw New Exception("ConnectInfo data not found.")
                End If

                Dim drConnect As DataRow = ds.Tables("ConnectInfo").Rows(0)
                If String.IsNullOrEmpty(drConnect("DB_IP").ToString) OrElse
                            String.IsNullOrEmpty(drConnect("DB_PORT").ToString) OrElse
                            String.IsNullOrEmpty(drConnect("DB_SID").ToString) OrElse
                            String.IsNullOrEmpty(drConnect("USR_ID").ToString) OrElse
                            String.IsNullOrEmpty(drConnect("USR_PWD").ToString) Then
                    Throw New Exception("IP, PORT, SID, ID, PWD info missing.")
                End If

                Dim connectionstring As String =
                    "data source=" &
                        "(description=(cid=gtu_app)" &
                            "(address_list=" &
                                    "(address=" &
                                            "(protocol=tcp)(host=" & drConnect("db_ip").ToString & ")(port=" & drConnect("db_port").ToString & ")" &
                                    ")" &
                            ")(connect_data=(service_name=" & drConnect("db_sid").ToString & ")(server=dedicated))" &
                        ");User Id=" & drConnect("USR_ID").ToString & ";Password=" & drConnect("USR_PWD").ToString & ";"


                dbConnet = New DBA(connectionstring, "ORACLE")

                For Each drSqlBox As DataRow In ds.Tables("SqlBox").Rows
                    sql = New SqlBox(drSqlBox("ID").ToString)
                    sql.AllowSqlInjection = drSqlBox("AllowSqlInjection") ' in 문시 ('A','B') -> (''A'',''B'') 현상 방지 

                    '모든 조회쿼리에 포함해야하는 항목만 추가해주세요.
                    sql.Params("HQ_OFFICE_CD") = YJIT.SessionOfficeInfo.HqOfficeCode
                    sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
                    sql.Params("LANG_CD") = YJIT.SessionOfficeInfo.LanguageCode
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID

                    '화면에서 넘겨준 Params 적용
                    For Each drParams As DataRow In ds.Tables("Params").Select("TableName = '" & drSqlBox("TableName") & "'")
                        sql.Params(drParams("ID")) = drParams("Data").ToString.Trim
                    Next

                    '화면에서 넘겨준 Blocks 적용
                    For Each drBlocks As DataRow In ds.Tables("Blocks").Select("TableName = '" & drSqlBox("TableName") & "'")
                        sql.Blocks(drBlocks("ID")) = drBlocks("Data").ToString.Trim
                    Next

                    '==2020.12.30 정윤기 : 화면에서 넘겨준 SQL문이 SELECT 문일 경우 dt형식으로 반환하고, 아닐경우 sql문만 실행함
                    If IsSelectSql(sql.Text.ToString.ToUpper) Then
                        dbConnet.SqlSet(sql.Text)
                        Dim dtMsg As DataTable = New DataTable()
                        dtMsg.Columns.AddRange({New DataColumn("Msg")})
                        dtMsg.Rows.Add(New Object() {"Success"})
                        dtMsg.TableName = drSqlBox("TableName")
                        ResultDs.Tables.Add(dtMsg.Copy)
                    Else
                        dt = dbConnet.SqlGet(sql.Text, False)
                        dt.TableName = drSqlBox("TableName")

                        If drSqlBox("IsOptional") = False Then
                            If dt.Rows.Count = 0 Then
                                ResultSet("TrxCode") = "N"
                                Throw New Exception("Data not found!")
                            End If
                        End If
                        ResultDs.Tables.Add(dt.Copy)
                    End If
                Next

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                dbConnet.Commit()
            Catch ex As Exception
                dbConnet.Rollback()
                ResultSet("TrxMsg") = ex.Message
            Finally
                dbConnet.EndTransaction()
            End Try

            Return ResultSet
        End Function

        Public Shared Sub SaveRow(ByRef db As DBA, ByRef Sql As SqlBox, ByVal InsFlag As String, ByRef drHeader As DataRow)
            Dim IsOptional As Boolean = False
            If InsFlag = "I" Then IsOptional = True

            For Each dcCol As DataColumn In drHeader.Table.Columns
                If dcCol.DataType.Name.ToUpper = "BYTE[]" Then
                    Continue For
                End If
                SaveCol(db, Sql, dcCol.ColumnName, drHeader(dcCol.ColumnName).ToString, IsOptional)
            Next
        End Sub

        Private Shared Sub SaveCol(ByRef db As DBA, ByRef Sql As SqlBox, ByVal ColName As String, ByVal ColData As String, ByVal IsOptional As Boolean)
            Sql.Params(ColName) = ColData
            If ColData.ToString.Trim <> "" Then Sql.Blocks(ColName) = True
            If IsOptional = False Then Sql.Blocks(ColName) = True
        End Sub
        Private Shared Function IsSelectSql(ByVal sqlText As String)
            If sqlText.ToString.ToUpper.Contains("INSERT") _
                OrElse sqlText.ToString.ToUpper.Contains("UPDATE") _
                OrElse sqlText.ToString.ToUpper.Contains("DELETE") _
                OrElse sqlText.ToString.ToUpper.Contains("CREATE") _
                OrElse sqlText.ToString.ToUpper.Contains("ALTER") _
                OrElse sqlText.ToString.ToUpper.Contains("DROP") _
                OrElse sqlText.ToString.ToUpper.Contains("TRUNCATE") _
                OrElse sqlText.ToString.ToUpper.Contains("GRANT") _
                OrElse sqlText.ToString.ToUpper.Contains("REVOKE") _
                OrElse sqlText.ToString.ToUpper.Contains("EXEC") _
                OrElse sqlText.ToString.ToUpper.Contains("EXECUTE") _
                OrElse sqlText.ToString.ToUpper.Contains("MERGE") Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class
End Namespace
