Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic

Imports YJIT.Data
Imports YJIT.Web.UI.WebControls
Imports YJIT.Web.UI.WebControls.CodeBox

Namespace YJIT.CodeService

    Public Class DLCustomer
        Inherits CodeBox.CodeService

        Public Overrides Function List(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Return Nothing

        End Function

        Public Overrides Function Search(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)
            Dim sql As SqlBox = Nothing

            sql = New SqlBox("CodeService@DLCustomer")
            sql.Params("KEY") = searchParams("SearchKey")
            If searchParams("SearchKey").ToString <> "" Then
                sql.Blocks("SEARCH") = True
            End If
            Return ExecuteQuery(sql.Text, usePaging, targetPage, pageSize, pageSetSize)

        End Function

        Public Overrides Function Validate(ByVal validateKeys As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object)) As Dictionary(Of String, Object)

            Dim sql As SqlBox = Nothing

            sql = New SqlBox("CodeService@DLCustomer")
            sql.Params("KEY") = validateKeys("KEY")
            sql.Blocks("VALIDATE") = True

            Return ExecuteQuery(sql.Text, usePaging:=False)

        End Function

    End Class

End Namespace

