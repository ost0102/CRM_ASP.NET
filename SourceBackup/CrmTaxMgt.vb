Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO
Imports System.Data.OracleClient

Namespace YJIT.Biz

    Public Class CrmTaxMgt

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
                 
                sql = New SqlBox("CrmTaxMgt@SearchExpected")  
                sql.Params("CRMM") = drHeader("S_CRMM")
                sql.Params("MODIFYGB") = drHeader("S_MODIFYGB")
                sql.Params("COCD") = drHeader("S_CUST_CD")
                sql.Params("DEPTCD") = drHeader("S_DEPTCD")
                sql.Params("SALESCD") = drHeader("S_SALESCD")
                sql.Params("PRJCD") = drHeader("S_PRJCD")
                If drHeader("S_MODIFYGB") <> "" Then sql.Blocks("MODIFYGB") = True 'Enabling sql block
                If drHeader("S_CUST_CD") <> "" Then sql.Blocks("COCD") = True 'Enabling sql block
                If drHeader("S_DEPTCD") <> "" Then sql.Blocks("DEPTCD") = True 'Enabling sql block
                If drHeader("S_SALESCD") <> "" Then sql.Blocks("SALESCD") = True 'Enabling sql block
                If drHeader("S_PRJCD") <> "" Then sql.Blocks("PRJCD") = True 'Enabling sql block
                 
                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "WG1"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("CrmTaxMgt@SearchCompare")
                sql.Params("CRMM") = drHeader("S_CRMM")
                sql.Params("MODIFYGB") = drHeader("S_MODIFYGB")
                sql.Params("COCD") = drHeader("S_CUST_CD")
                sql.Params("DEPTCD") = drHeader("S_DEPTCD")
                sql.Params("SALESCD") = drHeader("S_SALESCD")
                sql.Params("PRJCD") = drHeader("S_PRJCD")
                If drHeader("S_MODIFYGB") <> "" Then sql.Blocks("MODIFYGB") = True 'Enabling sql block
                If drHeader("S_CUST_CD") <> "" Then sql.Blocks("COCD") = True 'Enabling sql block
                If drHeader("S_DEPTCD") <> "" Then sql.Blocks("DEPTCD") = True 'Enabling sql block
                If drHeader("S_SALESCD") <> "" Then sql.Blocks("SALESCD") = True 'Enabling sql block
                If drHeader("S_PRJCD") <> "" Then sql.Blocks("PRJCD") = True 'Enabling sql block
                dt = db.SqlGet(sql.Text, False) 
                dt.TableName = "WG2"
                ResultDs.Tables.Add(dt)



                sql = New SqlBox("CrmTaxMgt@SearchDiff")
                sql.Params("CRMM") = drHeader("S_CRMM")
                sql.Params("MODIFYGB") = drHeader("S_MODIFYGB")
                sql.Params("COCD") = drHeader("S_CUST_CD")
                sql.Params("DEPTCD") = drHeader("S_DEPTCD")
                sql.Params("SALESCD") = drHeader("S_SALESCD")
                sql.Params("PRJCD") = drHeader("S_PRJCD")
                If drHeader("S_MODIFYGB") <> "" Then sql.Blocks("MODIFYGB") = True 'Enabling sql block
                If drHeader("S_CUST_CD") <> "" Then sql.Blocks("COCD") = True 'Enabling sql block
                If drHeader("S_DEPTCD") <> "" Then sql.Blocks("DEPTCD") = True 'Enabling sql block
                If drHeader("S_SALESCD") <> "" Then sql.Blocks("SALESCD") = True 'Enabling sql block
                If drHeader("S_PRJCD") <> "" Then sql.Blocks("PRJCD") = True 'Enabling sql block
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG3"
                ResultDs.Tables.Add(dt)
                'sql = New SqlBox("CrmTaxMgt@SearchDiff")
                'sql.Params("CUST_CD") = CUST_CD

                'dt = db.SqlGet(sql.Text, False)

                'dt.TableName = "WG2"
                'ResultDs.Tables.Add(dt)

                'sql = New SqlBox("CrmTaxMgt@SearchCompare")
                'sql.Params("CUST_CD") = CUST_CD

                'dt = db.SqlGet(sql.Text, False)

                'dt.TableName = "WG3"
                'ResultDs.Tables.Add(dt)

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
