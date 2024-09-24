Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic

Imports YJIT.Data
Imports YJIT.Web.UI.WebControls
Imports YJIT.Web.UI.WebControls.CodeBox

Namespace YJIT.CodeService

    ''' <summary>
    ''' Incoterms
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Crm
        Inherits CodeBox.CodeService

        Public Overrides Function List(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Dim Item As String = ""
            Dim Item3 As String = ""
            Dim GroupCode As String = dataParams("GroupCode").ToString
            Dim NameType As String = dataParams("NameType").ToString

            dataParams.TryGetValue("Item", Item)
            dataParams.TryGetValue("Item3", Item3)

            Dim sql As New SqlBox("CodeService@CBTEST_V2")

            sql.Params("GRP_CD") = GroupCode
            sql.Params("LANG_CD") = YJIT.SessionOfficeInfo.LanguageCode
            sql.Params("OPT_ITEM3") = Item3

            If GroupCode = "TEST" Then
                If YJIT.SessionInfo.AuthorizationType = "0" Then
                    sql.Blocks("AUTH_ADMIN_TRUE") = True
                Else
                    sql.Blocks("AUTH_ADMIN_FALSE") = True
                End If
            End If

            If NameType = "B" Then
                sql.Blocks("TYPE_B") = True
            ElseIf NameType = "C" Then
                sql.Blocks("TYPE_C") = True
            Else
                sql.Blocks("TYPE_A") = True
            End If

            If Item <> Nothing Then
                sql.Blocks("OPT_ITEM1") = True
            End If

            If Item3 <> Nothing Then
                sql.Blocks("OPT_ITEM3") = True
            End If

            Return ExecuteQuery(sql.Text, usePaging:=False)

        End Function

        Public Overrides Function Search(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Dim Type As String = dataParams("Type").ToString

            Dim sql As New SqlBox("CodeService@Crm_CD")

            sql.Params("KEY") = searchParams("SearchKey")

            If searchParams("SearchKey").ToString <> "" Then
                sql.Blocks("SEARCH") = True
            End If

            'Select Case Type
            '    Case "LB"
            '        sql.Blocks("OFFICE_LVL") = True
            '    Case Else
            'End Select

            Return ExecuteQuery(sql.Text, usePaging, targetPage, pageSize, pageSetSize)

        End Function

        Public Overrides Function Validate(ByVal validateKeys As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object)) As Dictionary(Of String, Object)

            Dim Type As String = dataParams("Type").ToString

            Dim sql As New SqlBox("CodeService@Crm_CD")

            sql.Params("KEY") = validateKeys("KEY")
            sql.Blocks("VALIDATE") = True

            'Select Case Type
            '    Case "LB"
            '        sql.Blocks("OFFICE_LVL") = True
            '    Case Else
            'End Select

            Return ExecuteQuery(sql.Text, usePaging:=False)

        End Function


    End Class

End Namespace

