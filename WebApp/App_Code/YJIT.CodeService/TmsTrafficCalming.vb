Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic

Imports YJIT.Data
Imports YJIT.Web.UI.WebControls
Imports YJIT.Web.UI.WebControls.CodeBox

Namespace YJIT.CodeService

    Public Class TmsTrafficCalming
        Inherits CodeBox.CodeService

        Public Overrides Function List(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)
            Dim sql As New SqlBox("CodeServiceTMS@TmsTrafficCalming_LIST")
            Dim Type As String = dataParams("Type").ToString
            If dataParams.ContainsKey("City") = True Then
                sql.Params("CUST_CD") = dataParams("City") 'If dataParams("City") = "Y" Then sql.Blocks("CustCd") = True
            End If
            'If CustCd <> "" Then
            '    sql.Params("CUST_CD") = CustCd
            '    sql.Blocks("CUST_CD") = True
            'End If
            Select Case Type
                Case "T"
                    sql.Blocks("T") = True
                Case "S"
                    sql.Blocks("S") = True
                Case "P"
                    sql.Blocks("P") = True
                Case "C"
                    sql.Blocks("C") = True
                Case "D"
                    sql.Blocks("D") = True
            End Select
            Return ExecuteQuery(sql.Text, usePaging:=False)
        End Function

        Public Overrides Function Search(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)
            Dim sql As New SqlBox("CodeServiceTMS@TmsTrafficCalming_SEARCH")
            Dim Type As String = dataParams("Type").ToString
            If dataParams.ContainsKey("City") = True Then
                sql.Params("CITY") = dataParams("City") 'If dataParams("City") = "Y" Then sql.Blocks("CustCd") = True
            End If
            Select Case Type
                Case "T"
                    sql.Blocks("T") = True
                Case "S"
                    sql.Blocks("S") = True
                Case "P"
                    sql.Blocks("P") = True
                Case "C"
                    sql.Blocks("C") = True
                Case "D"
                    sql.Blocks("D") = True
            End Select
            sql.Params("CODE") = searchParams("SearchKey").ToString
            Return ExecuteQuery(sql.Text, usePaging, targetPage, pageSize, pageSetSize)
        End Function

        Public Overrides Function Validate(ByVal validateKeys As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object)) As Dictionary(Of String, Object)
            Dim Sql As New SqlBox("CodeServiceTMS@TmsTrafficCalming_VALIDATE")
            Dim Type As String = dataParams("Type").ToString
            If dataParams.ContainsKey("City") = True Then
                Sql.Params("CITY") = dataParams("City") 'If dataParams("City") = "Y" Then sql.Blocks("CustCd") = True
            End If
            Select Case Type
                Case "T"
                    sql.Blocks("T") = True
                Case "S"
                    sql.Blocks("S") = True
                Case "P"
                    sql.Blocks("P") = True
                Case "C"
                    sql.Blocks("C") = True
                Case "D"
                    sql.Blocks("D") = True
            End Select
            Sql.Params("CODE") = validateKeys("KEY").ToString
            Return ExecuteQuery(Sql.Text, usePaging:=False)

        End Function

    End Class
End Namespace

