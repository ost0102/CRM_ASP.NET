Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz
    Public Class CrmCustomerPicList

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Dim strCustCd As String = String.Empty
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmCustomerPicList@Search")
                sql.Params("SEARCH_KEY") = drHeader("S_SEARCH_KEY").ToString
                sql.Params("SVC_CD") = drHeader("S_SVC_CD").ToString
                If drHeader("S_SEARCH_KEY").ToString <> "" Then
                    sql.Blocks("SEARCH_KEY") = True
                End If
                If drHeader("S_SVC_CD").ToString <> "" Then
                    sql.Blocks("SVC_CD") = True
                End If
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
