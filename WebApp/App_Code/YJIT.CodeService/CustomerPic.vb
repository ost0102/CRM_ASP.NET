Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic

Imports YJIT.Data
Imports YJIT.Web.UI.WebControls
Imports YJIT.Web.UI.WebControls.CodeBox

Namespace YJIT.CodeService
    ''' <summary>
    ''' Customer Pic 코드
    ''' </summary>
    ''' <remarks></remarks>
    Public Class CustomerPic
        Inherits CodeBox.CodeService

        Public Overrides Function List(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Dim Type As String = dataParams("Type").ToString
            Dim Customer As String = dataParams("Customer").ToString

            Dim sql As New SqlBox("CodeService@CustomerPic")

            sql.Params("CUST_CD") = Customer
            sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
            sql.Params("REQ_SVC") = Type

            If Type <> "" Then
                sql.Blocks("REQ_SVC") = True
            End If

            Return ExecuteQuery(sql.Text, usePaging:=False)


        End Function

        Public Overrides Function Search(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Dim Customer As String = dataParams("Customer").ToString
            Dim SearchKey As String = searchParams("SearchKey").ToString

            Dim sql As New SqlBox("CodeService@CustomerPic")

            sql.Params("CUST_CD") = Customer
            sql.Params("KEY") = SearchKey

            If SearchKey <> "" Then
                sql.Blocks("SEARCH") = True
            End If


            Return ExecuteQuery(sql.Text, usePaging, targetPage, pageSize, pageSetSize)

        End Function

        Public Overrides Function Validate(ByVal validateKeys As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object)) As Dictionary(Of String, Object)


            Dim Customer As String = dataParams("Customer").ToString
            Dim Key As String = validateKeys("KEY")

            Dim sql As New SqlBox("CodeService@CustomerPic")
            sql.Params("CUST_CD") = Customer
            sql.Params("KEY") = Key
            sql.Blocks("VALIDATE") = True

            Return ExecuteQuery(sql.Text, usePaging:=False)


        End Function


    End Class


End Namespace
