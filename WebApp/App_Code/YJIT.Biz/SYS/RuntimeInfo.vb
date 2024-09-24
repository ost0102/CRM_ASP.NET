Imports System
Imports System.IO
Imports System.Data
Imports System.Collections.Generic

Imports YJIT.Data
Imports YJIT.Utils
Imports YJIT.Biz


Namespace YJIT.Sys

    Public Class RuntimeInfo
        Public Shared Function GetRecentSqlLog() As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            resultSet("TrxCode") = "Y"
            resultSet("TrxMsg") = "Success"
            resultSet("RecentSqlLog") = DBA.GetRecentSqlLog()
            Return resultSet
        End Function
        Public Shared Function GetLoginListLog() As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ds As DataSet = New DataSet
            Dim dt As DataTable = YJIT.WCF.BizService.GetLoginList()
            ds.Tables.Add(dt.Copy)

            resultSet("LoginList") = CType(ds, DataSet).GetXml
            Return resultSet
        End Function
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function

        Public Shared Function SearchReconnect(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.SearchReconnect(ds)
        End Function
    End Class
End Namespace
