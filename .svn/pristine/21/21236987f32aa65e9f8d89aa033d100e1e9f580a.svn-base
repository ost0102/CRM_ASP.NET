Imports System.Data
Imports YJIT.Data

Namespace YJIT.BIZ
    Public Class SvrInfoLogList
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function
        Public Shared Function SearchSchema(ByVal SchemaGroupName As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As New DataTable

            Try
                ResultSet("TrxCode") = "E"
                ResultSet("TrxMsg") = "Error"
                ResultSet("Data") = ResultDs

                If SchemaGroupName.Length = 0 Then
                    Throw New Exception("Data info missing.")
                End If

                Select Case SchemaGroupName.ToUpper
                    Case "SvrInfoLog".ToUpper
                        sql = New SqlBox("SvrInfoLogList@SearchTableName")
                        sql.Params("TABLE_NAME") = "CRM_SERVER_INFO_LOG"
                        dt = db.SqlGet(sql.Text, False)
                        dt.TableName = "CRM_SERVER_INFO_LOG"
                        ResultDs.Tables.Add(dt.Copy)

                        sql = New SqlBox("SvrInfoLogList@SearchTableName")
                        sql.Params("TABLE_NAME") = "CRM_SERVER_DB_DTL"
                        dt = db.SqlGet(sql.Text, False)
                        dt.TableName = "CRM_SERVER_DB_DTL"
                        ResultDs.Tables.Add(dt.Copy)
                    Case Else
                        ResultSet("TrxCode") = "N"
                        Throw New Exception("Data not found!")
                End Select

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet

        End Function
        Public Shared Function SaveSchema(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As New DataTable

            Try
                ResultSet("TrxCode") = "E"
                ResultSet("TrxMsg") = "Error"
                ResultSet("Data") = ResultDs


                For Each dtTable As DataTable In ds.Tables
                    Select Case dtTable.TableName.ToUpper
                        Case "WCF_CLIENT_INFO", "CRM_SERVER_INFO_LOG", "CRM_SERVER_DB_DTL"
                            '허용
                        Case Else
                            Throw New Exception("Data info missing.")
                    End Select
                Next


                For Each Table As DataTable In ds.Tables
                    If Table.TableName.ToUpper = "WCF_CLIENT_INFO".ToUpper Then Continue For

                    For Each Row As DataRow In Table.Rows
                        sql = New SqlBox("SvrInfoLogList@Insert" & Table.TableName.ToUpper)
                        YJQuery.SaveRow(db, sql, "I", Row)
                        db.SqlSet(sql.Text)
                    Next
                Next

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet

        End Function

        '20210531 김민석 RPA 모듈 정보 조회용
        Public Shared Function SearchRPAInfo(ByVal OfficeCode As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable = Nothing
            Dim dtCRM As New DataTable
            Dim dtRPA As New DataTable

            Try
                ResultSet("TrxCode") = "E"
                ResultSet("TrxMsg") = "Error"
                ResultSet("Data") = ResultDs

                sql = New SqlBox("SvrInfoLogList@SearchRPAInfo")
                sql.Params("OFFICE_CD") = OfficeCode
                dtCRM = db.SqlGet(sql.Text, False)
                dtCRM.TableName = "CRM_INFO"

                Try
                    Dim custCd As String = String.Empty
                    If dtCRM.Rows.Count >= 1 Then custCd = dtCRM.Rows(0)("CUST_CD").ToString

                    sql = New SqlBox("SvrInfoLogList@SearchRPAAuthKey")
                    sql.Params("CUST_CD") = custCd
                    Dim dbRPA As DBA = New DBA(CrmSvcAprMgt.GetConnectionString("RPA", ""), "ORACLE")
                    dtRPA = dbRPA.SqlGet(sql.Text, False)
                    dtRPA.TableName = "RPA_INFO"
                Catch ex As Exception
                    Throw New Exception(ex.Message & "(RPA)")
                End Try

                Dim vLINQ = From vCRM In dtCRM
                            Group Join vRPA In dtRPA On vCRM.Field(Of String)("CUST_CD").ToString Equals vRPA.Field(Of String)("CUST_CD").ToString
                            Into vCRMRPA = Group
                            From vRPA In vCRMRPA.DefaultIfEmpty()
                            Select CUST_CD = vCRM.Field(Of String)("CUST_CD").ToString,
                                   DB_ID = vCRM.Field(Of String)("DB_ID").ToString,
                                   DB_PWD = vCRM.Field(Of String)("DB_PWD").ToString,
                                   SVR_IP = vCRM.Field(Of String)("SVR_IP").ToString,
                                   MNGT_NO = If(vRPA Is Nothing, String.Empty, vRPA.Field(Of String)("MNGT_NO").ToString),
                                   AUTH_KEY = If(vRPA Is Nothing, String.Empty, vRPA.Field(Of String)("AUTH_KEY").ToString)
                dt = LinqToDataTable(vLINQ)
                dt.TableName = "CRM_RPA_INFO"
                ResultDs.Tables.Add(dt.Copy)

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet

        End Function
        Private Shared Function LinqToDataTable(Of T)(source As IEnumerable(Of T)) As DataTable
            Dim properties As Reflection.PropertyInfo() = GetType(T).GetProperties()

            Dim output As New DataTable()

            For Each prop In properties
                output.Columns.Add(prop.Name, prop.PropertyType)
            Next

            For Each item In source
                Dim row As DataRow = output.NewRow()

                For Each prop In properties
                    row(prop.Name) = prop.GetValue(item, Nothing)
                Next

                output.Rows.Add(row)
            Next

            Return output
        End Function
    End Class
End Namespace
