Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO

Namespace YJIT.Biz
    Public Class CrmMaintenanceMgt
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

            '    sql = New SqlBox("CrmMaintenanceMgt@Search")
            '    sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
            '    sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
            '    sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
            '    sql.Params("SVC_CD") = drHeader("S_SVC_CD").ToString
            '    sql.Params("MATN_YN") = drHeader("S_MATN_YN").ToString

            '    If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True
            '    If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True
            '    If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
            '    If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("SVC_CD") = True
            '    If drHeader("S_MATN_YN").ToString <> "" Then sql.Blocks("MATN_YN") = True

            '    dt = db.SqlGet(sql.Text, False)
            '    dt.TableName = "WG1"

            '    If dt.Rows.Count = 0 Then
            '        ThrowMsg(ErrorOccur, "Data not found!")
            '    End If

            '    ResultDs.Tables.Add(dt)

            '    sql = New SqlBox("CrmMaintenanceMgt@SearchPivot")
            '    sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
            '    sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
            '    sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
            '    sql.Params("SVC_CD") = drHeader("S_SVC_CD").ToString
            '    sql.Params("MATN_YN") = drHeader("S_MATN_YN").ToString

            '    If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True
            '    If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True
            '    If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
            '    If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("SVC_CD") = True
            '    If drHeader("S_MATN_YN").ToString <> "" Then sql.Blocks("MATN_YN") = True

            '    dt = db.SqlGet(sql.Text, False)
            '    dt.TableName = "PGC1"

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
