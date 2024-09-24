Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.Web.UI.WebControls

Namespace YJIT.CodeService

    Public Class Office
        Inherits CodeBox.CodeService

        Public Overrides Function List(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Dim sql As SqlBox = Nothing
            Dim Type As String = dataParams("Type").ToString
            Dim OfficeCode As String = ""
            dataParams.TryGetValue("OfficeCode", OfficeCode)

            Select Case Type
                Case "TREE"
                    sql = New SqlBox("CodeService@OfficeTree")
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                Case "LOC_BANK"
                    sql = New SqlBox("CodeService@OfficeBank")
                    sql.Blocks("LOC_BANK") = True
                Case "ENG_BANK"
                    sql = New SqlBox("CodeService@OfficeBank")
                    sql.Blocks("ENG_BANK") = True
                Case "FRGN_BANK"
                    sql = New SqlBox("CodeService@OfficeBank")
                    sql.Blocks("FRGN_BANK") = True
                Case "LB"
                    sql = New SqlBox("CodeService@Office")
                    sql.Blocks("OFFICE_LVL") = True
                Case "UPPER_ORG"
                    sql = New SqlBox("CodeService@Office")
                    sql.Blocks("UPPER_ORG") = True
            End Select

            If OfficeCode Is Nothing Then
                sql.Params("KEY") = YJIT.SessionInfo.OfficeCode
            Else
                sql.Params("KEY") = OfficeCode
            End If

            'Return ExecuteQuery(sql.Text, usePaging, targetPage, pageSize, pageSetSize)
            Return ExecuteQuery(sql.Text, usePaging:=False)

        End Function

        Public Overrides Function Search(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Dim Type As String = dataParams("Type").ToString

            Dim sql As New SqlBox("CodeService@Office")

            sql.Params("KEY") = searchParams("SearchKey")

            If searchParams("SearchKey").ToString <> "" Then
                sql.Blocks("SEARCH") = True
            End If

            Select Case Type
                Case "LB"
                    sql.Blocks("OFFICE_LVL") = True
                Case Else
            End Select

            Return ExecuteQuery(sql.Text, usePaging, targetPage, pageSize, pageSetSize)
        End Function

        Public Overrides Function Validate(ByVal validateKeys As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object)) As Dictionary(Of String, Object)

            Dim Type As String = dataParams("Type").ToString

            Dim sql As New SqlBox("CodeService@Office")

            sql.Params("KEY") = validateKeys("KEY")
            sql.Blocks("VALIDATE") = True

            Select Case Type
                Case "LB"
                    sql.Blocks("OFFICE_LVL") = True
                Case Else
            End Select

            Return ExecuteQuery(sql.Text, usePaging:=False)

        End Function

    End Class
End Namespace