Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class EchCustomerTariff
        Public Shared Function SaveVendorTariff(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim insflag As String = ""
            Dim CustCode As String = ""
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                Dim dt As DataTable = ds.Tables("WG2")
                For Each dr In dt.Rows
                    sql = New SqlBox("EchCustomerTariff@Save")
                    sql.Params("DOC_CD") = dr("DOC_CD").ToString
                    sql.Params("KLNET") = dr("KLNET")
                    sql.Params("KLNET_DC_RATE") = dr("KLNET_DC_RATE")
                    sql.Params("KLNET_TYPE") = dr("KLNET_TYPE").ToString
                    sql.Params("KTNET") = dr("KTNET")
                    sql.Params("KTNET_DC_RATE") = dr("KTNET_DC_RATE")
                    sql.Params("KTNET_TYPE") = dr("KTNET_TYPE").ToString
                    sql.Params("KCNET") = dr("KCNET")
                    sql.Params("KCNET_DC_RATE") = dr("KCNET_DC_RATE")
                    sql.Params("KCNET_TYPE") = dr("KCNET_TYPE").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return resultSet

        End Function
        Public Shared Function SearchVendorTariff(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("EchCustomerTariff@SearchVendorTariff")
                sql.AllowSqlInjection = True
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

                dt.TableName = "WG2"
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

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("EchCustomerTariff@Search")
                sql.AllowSqlInjection = True
                sql.Params("S_CUST_CD") = drHeader("S_CUST_CD").ToString
                sql.Params("S_CUST_NM") = drHeader("S_CUST_NM").ToString
                sql.Params("S_DOC_CD") = drHeader("S_DOC_CD").ToString

                If drHeader("S_CUST_CD").ToString <> "" Then sql.Blocks("S_CUST_CD") = True
                If drHeader("S_CUST_NM").ToString <> "" Then sql.Blocks("S_CUST_NM") = True
                If drHeader("S_DOC_CD").ToString <> "" Then sql.Blocks("S_DOC_CD") = True

                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

                dt.TableName = "WG1"
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

        Public Shared Function SearchECH(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("EchCustomerTariff@SearchChainList")
                sql.AllowSqlInjection = True

                sql.Params("CUST_CD") = drHeader("S_ECH_CUST_CD").ToString
                sql.Params("CUST_LOC_NM") = drHeader("S_ECH_CUST_NM").ToString
                sql.Params("S_DATE") = drHeader("FM_YMD").ToString
                sql.Params("E_DATE") = drHeader("TO_YMD").ToString

                If drHeader("S_ECH_CUST_CD").ToString <> "" Then sql.Blocks("CUST_CD") = True
                If drHeader("S_ECH_CUST_NM").ToString <> "" Then sql.Blocks("CUST_LOC_NM") = True
                If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("S_DATE") = True
                If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("E_DATE") = True

                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

                dt.TableName = "WG3"
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
    End Class
End Namespace
