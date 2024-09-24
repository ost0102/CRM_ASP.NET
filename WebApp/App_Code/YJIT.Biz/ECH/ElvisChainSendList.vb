Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class ElvisChainSendList

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

                sql = New SqlBox("ElvisChainSendList@Search")
                sql.AllowSqlInjection = True
                sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
                sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
                sql.Params("CUST_CD") = drHeader("S_CUST_CD").ToString
                sql.Params("CUST_NM") = drHeader("S_CUST_NM").ToString
                sql.Params("DOC_CD") = drHeader("S_DOC_CD").ToString

                If drHeader("S_CUST_CD").ToString <> "" Then sql.Blocks("CUST_CD") = True
                If drHeader("S_CUST_NM").ToString <> "" Then sql.Blocks("CUST_NM") = True
                If drHeader("S_DOC_CD").ToString <> "" Then sql.Blocks("DOC_CD") = True

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
    End Class
End Namespace
