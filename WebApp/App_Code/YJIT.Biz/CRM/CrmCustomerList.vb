Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class CrmCustomerList

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)

            'Dim ResultSet As New Dictionary(Of String, Object)
            'Dim ResultDs As DataSet = New DataSet
            'Dim db As DBA = New DBA()
            'Dim drHeader As DataRow
            'Dim sql As SqlBox
            'Dim dt As DataTable
            'Dim ErrorOccur As Boolean = True
            'Try

            '    If Not ds.Tables.Contains("MAIN") Then
            '        ThrowMsg(ErrorOccur, "Data info missing.")
            '    End If
            '    drHeader = ds.Tables("MAIN").Rows(0)

            '    sql = New SqlBox("CrmCustomerList@Search")
            '    sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
            '    If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
            '    sql.Params("SVC_CD") = drHeader("S_SVC_CD").ToString
            '    sql.Params("USE_YN") = drHeader("S_USE_YN").ToString
            '    sql.Params("CUST_TYPE") = drHeader("S_CUST_TYPE").ToString
            '    If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("SVC_CD") = True
            '    If drHeader("S_USE_YN").ToString <> "" Then sql.Blocks("USE_YN") = True
            '    If drHeader("S_CUST_TYPE").ToString <> "" Then sql.Blocks("CUST_TYPE") = True
            '    dt = db.SqlGet(sql.Text, False)

            '    If dt.Rows.Count = 0 Then
            '        ThrowMsg(ErrorOccur, "Data not found!")
            '    End If
            '    dt.TableName = "WG1"
            '    ResultDs.Tables.Add(dt)
            '    ResultSet("TrxCode") = "Y"
            '    '성공 유무의 메세지는 생략.
            '    ResultSet("TrxMsg") = "Success"
            '    ResultSet("Data") = ResultDs

            'Catch ex As Exception

            '    If ErrorOccur Then
            '        ResultSet("TrxCode") = "E"
            '    Else
            '        ResultSet("TrxCode") = "N"
            '    End If
            '    ResultSet("TrxMsg") = ex.Message
            'End Try

            'Return ResultSet
        End Function
    End Class
End Namespace
