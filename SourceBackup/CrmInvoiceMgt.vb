Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO
Imports System.Data.OracleClient

Namespace YJIT.Biz

    Public Class CrmInvoiceMgt

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                Dim CUST_CD As String = drHeader("COCD").ToString
                sql = New SqlBox("CrmInvoiceMgt@Search")
                sql.Params("CUST_CD") = CUST_CD

                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "MAIN"
                ResultDs.Tables.Add(dt)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If 

                sql = New SqlBox("CrmInvoiceMgt@SearchInv")
                sql.Params("CUST_CD") = CUST_CD

                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "WG1"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("CrmInvoiceMgt@UpdateLog")
                sql.Params("CUST_CD") = CUST_CD

                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "WG2"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("CrmInvoiceMgt@SearchService")
                sql.Params("CUST_CD") = CUST_CD

                dt = db.SqlGet(sql.Text, False)

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

        Public Shared Function SaveData(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                db.BeginTransaction()

                dt = ds.Tables("WG1")
                For I = 0 To dt.Rows.Count - 1
                    Dim DR As DataRow = dt.Rows(I) 
                    sql = New SqlBox("CrmInvoiceMgt@SaveData") 
                    sql.Params("USR_ID") = SessionInfo.UserID
                    sql.Params("DB_CUST") = DR("DB_CUST")
                    sql.Params("DB_COMN_CD") = DR("DB_COMN_CD")
                    sql.Params("DB_AROC") = DR("DB_AROC")   
                    sql.Params("CUST") = drHeader("CUST_CD")
                    sql.Params("COMN_CD") = DR("COMN_CD")
                    sql.Params("AROC") = DR("AROC")
                    sql.Params("MODIFYGB") = DR("MODIFYGB")
                    sql.Params("INDIVIDUAL") = DR("INDIVIDUAL")
                    sql.Params("SINGLEPUB") = DR("SINGLEPUB")
                    sql.Params("SDATE") = DR("SDATE")
                    sql.Params("BILL_AMT") = DR("BILL_AMT")
                    sql.Params("BILL_VAT") = DR("BILL_VAT")
                    sql.Params("TAXDD") = DR("TAXDD")
                    sql.Params("DEPTCD") = DR("DEPTCD")
                    sql.Params("PRJCD") = DR("PRJCD")
                    sql.Params("STANDARD_LIST") = DR("STANDARD_LIST")
                    sql.Params("RMK") = DR("RMK")  
                    db.SqlSet(sql.Text)
                Next


                ds.Tables("MAIN").Rows(0)("COCD") = drHeader("CUST_CD") 
                'Dim CUST_CD As String = drHeader("COCD").ToString
                'sql = New SqlBox("CrmInvoiceMgt@Search")
                'sql.Params("CUST_CD") = CUST_CD

                'dt = db.SqlGet(sql.Text, False)

                'If dt.Rows.Count = 0 Then
                '    ThrowMsg(ErrorOccur, "Data not found!")
                'End If

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"


                db.Commit()
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
                 
                Try 
                    ResultDs = Search(ds)("Data")
                    ResultSet("Data") = ResultDs
                Catch ex As Exception

                End Try
            End Try
            Return ResultSet
        End Function

        Public Shared Function DeleteData(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                db.BeginTransaction()

                dt = ds.Tables("WG1") 
                ds.Tables("MAIN").Rows(0)("COCD") = drHeader("CUST_CD")
                sql = New SqlBox("CrmInvoiceMgt@DeleteData") 
                sql.Params("USR_ID") = SessionInfo.UserID 
                sql.Params("DB_CUST") = drHeader("WG1_DB_CUST")
                sql.Params("DB_COMN_CD") = drHeader("WG1_DB_COMN_CD")
                sql.Params("DB_AROC") = drHeader("WG1_DB_AROC")
                db.SqlSet(sql.Text) 

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"


                db.Commit()
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()

                Try
                    ResultDs = Search(ds)("Data")
                    ResultSet("Data") = ResultDs
                Catch ex As Exception

                End Try
            End Try
            Return ResultSet
        End Function

        Public Shared Function SaveTaxInfoData(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                db.BeginTransaction()

                sql = New SqlBox("CrmInvoiceMgt@UpdateTaxInfo")
                sql.Params("CUST_CD") = drHeader("CUST_CD")
                sql.Params("TANM") = drHeader("TANM")
                sql.Params("E_MAIL") = drHeader("EMAIL")
                sql.Params("TELNO") = drHeader("TEL_NO")
                sql.Params("TAX_CK") = drHeader("TAX_CK")
                sql.Params("USR_ID") = SessionInfo.UserID 
                sql.Params("ENDDT") = drHeader("ENDDT")  
                 db.SqlSet(sql.Text) 

                ds.Tables("MAIN").Rows(0)("COCD") = drHeader("CUST_CD")
                'Dim CUST_CD As String = drHeader("COCD").ToString
                'sql = New SqlBox("CrmInvoiceMgt@Search")
                'sql.Params("CUST_CD") = CUST_CD

                'dt = db.SqlGet(sql.Text, False)

                'If dt.Rows.Count = 0 Then
                '    ThrowMsg(ErrorOccur, "Data not found!")
                'End If

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"


                db.Commit()
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()

                Try
                    ResultDs = Search(ds)("Data")
                    ResultSet("Data") = ResultDs
                Catch ex As Exception

                End Try
            End Try
            Return ResultSet
        End Function
        Public Shared Function Print(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmInvoiceMgt@Print")
                sql.Params("CUST_CD") = drHeader("CUST_CD").ToString.Trim

                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "MAIN"
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

        Public Shared Function Certificate(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmInvoiceMgt@PrintCertificate")
                sql.Params("CUST_CD") = drHeader("CUST_CD").ToString.Trim

                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "MAIN"
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
