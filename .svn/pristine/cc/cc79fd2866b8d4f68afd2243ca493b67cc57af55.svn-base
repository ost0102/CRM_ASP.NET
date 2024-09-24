Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Exception
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.BIZ.Common
Imports System.Net
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports Newtonsoft.Json
Imports System.IO

Namespace YJIT.BIZ
    Public Class MetaStlMgt
        'Search
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = True
            Dim db As DBA

            db = New DBA(CrmSvcAprMgt.GetConnectionString("META_SYS", ""), "ORACLE")

            Try
                resultSet = YJQuery.SearchEx(ds, db)
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db = Nothing
            End Try

            Return resultSet
        End Function
    End Class
End Namespace
