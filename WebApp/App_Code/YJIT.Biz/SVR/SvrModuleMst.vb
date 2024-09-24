Imports System.Data
Imports YJIT.Data

Namespace YJIT.BIZ
    Public Class SvrModuleMst
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function
        Public Shared Function SearchSchema(ByVal SchemaGroupName As String, ByVal ServerIP As String, ByVal ModuleType As String) As Dictionary(Of String, Object)
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
                    Case "ModuleLog".ToUpper
                        sql = New SqlBox("SvrModuleMst@SearchModule")
                        sql.Params("SERVER_IP") = ServerIP
                        sql.Blocks("SERVER_IP") = True
                        sql.Params("MODULE_TYPE") = ModuleType
                        sql.Blocks("MODULE_TYPE") = True
                        dt = db.SqlGet(sql.Text, False)
                        dt.TableName = "Module"
                        ResultDs.Tables.Add(dt.Copy)

                        sql = New SqlBox("SvrModuleMst@SearchTableName")
                        sql.Params("TABLE_NAME") = "CRM_SERVER_MODULE_LOG"
                        dt = db.SqlGet(sql.Text, False)
                        dt.TableName = "ModuleLog"
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
                        Case "WCF_CLIENT_INFO", "Module".ToUpper, "ModuleLog".ToUpper
                            '허용
                        Case Else
                            Throw New Exception("Data info missing.")
                    End Select
                Next


                For Each Table As DataTable In ds.Tables
                    If Table.TableName.ToUpper = "WCF_CLIENT_INFO".ToUpper Then Continue For
                    If Table.TableName.ToUpper = "Module".ToUpper Then Continue For

                    For Each Row As DataRow In Table.Rows
                        sql = New SqlBox("SvrModuleMst@Insert" & Table.TableName.ToUpper)
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
            Return SvrInfoLogList.SearchRPAInfo(OfficeCode)
        End Function
        Public Shared Function SearchCRMToElvis(ByVal domain As String) As Dictionary(Of String, Object)
            '20211219 김성은 외부서버에서 CRM 환율 검색하기 위해서 추가
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try
                If String.IsNullOrEmpty(domain) Then
                    Throw New Exception("Data info missing.")
                End If

                Select Case domain.ToUpper
                    Case "KCTCINTL.COM"
                        '승인된 도메인
                    Case Else
                        Throw New Exception("Approval Data info missing.")
                End Select

                sql = New SqlBox("MdmExrateMgt@Search2")
                sql.AllowSqlInjection = True

                sql.Params("OFFICE_CD") = "YJIT"
                sql.Params("S_EXRT_YMD") = Now.ToString("yyyyMMdd")
                sql.Params("S_SEQ") = "001"
                dt = db.SqlGet(sql.Text, False)

                ResultDs.Tables.Add(dt)

                dt.TableName = "CRM_EX_RATE"


                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            End Try
            Return ResultSet
        End Function
    End Class
End Namespace
