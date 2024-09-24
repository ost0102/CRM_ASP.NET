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
    Public Class CommonCode
        Inherits CodeBox.CodeService

        Public Overrides Function List(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Dim Item As String = ""
            Dim Item2 As String = ""
            Dim Item3 As String = ""
            Dim ColItem3 As String = ""
            Dim OptItem1 As String = ""
            Dim GroupCode As String = dataParams("GroupCode").ToString
            Dim NameType As String = dataParams("NameType").ToString
            Dim SearchType As String = ""

            dataParams.TryGetValue("OPT_ITEM1", OptItem1)
            dataParams.TryGetValue("Item", Item)
            dataParams.TryGetValue("Item2", Item2)
            dataParams.TryGetValue("Item3", Item3)
            dataParams.TryGetValue("ColItem3", ColItem3)
            dataParams.TryGetValue("SearchType", SearchType)


            Dim sql As New SqlBox("CodeService@CommonCode")

            sql.Params("GRP_CD") = GroupCode
            sql.Params("LANG_CD") = YJIT.SessionOfficeInfo.LanguageCode
            sql.Params("OPT_ITEM3") = Item3

            If GroupCode = "S04" Then
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

            If OptItem1 <> Nothing Then
                sql.Params("OPT_ITEM1") = OptItem1
                sql.Blocks("OPT_ITEM1") = True
            End If

            If Item <> Nothing Then
                sql.Blocks("Item") = True
            End If

            If Item2 <> Nothing Then
                sql.Blocks("Item2") = True
            End If

            If Item3 <> Nothing Then
                sql.Blocks("OPT_ITEM3") = True
            End If

            If ColItem3 <> Nothing Then
                sql.Blocks("ColItem3") = True
            End If

            If SearchType <> Nothing Then
                sql.Blocks("SEARCHTYPE_" & SearchType.ToUpper) = True
            End If

            Select Case GroupCode
                Case "T16"
                    sql.Blocks("ORDER_BY_CODE_DESC") = True
                Case Else
                    sql.Blocks("ORDER_BY_DEFAULT") = True
            End Select

            'Return ExecuteQuery(sql.Text, usePaging = False, targetPage, pageSize, pageSetSize)
            Return ExecuteQuery(sql.Text, usePaging:=False)

        End Function

        Public Overrides Function Search(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Dim GroupCode As String = dataParams("GroupCode").ToString
            Dim NameType As String = dataParams("NameType").ToString
            Dim SearchKey As String = searchParams("SearchKey")


            Dim sql As New SqlBox("CodeService@CommonCode")

            sql.Params("GRP_CD") = GroupCode
            sql.Params("KEY") = SearchKey
            sql.Params("LANG_CD") = YJIT.SessionOfficeInfo.LanguageCode

            If SearchKey <> "" Then
                sql.Blocks("SEARCH") = True
            End If

            If NameType = "B" Then
                sql.Blocks("TYPE_B") = True
            ElseIf NameType = "C" Then
                sql.Blocks("TYPE_C") = True
            Else
                sql.Blocks("TYPE_A") = True
            End If

            Select Case GroupCode
                Case "T16"
                    sql.Blocks("ORDER_BY_CODE_DESC") = True
                Case Else
                    sql.Blocks("ORDER_BY_DEFAULT") = True
            End Select


            Return ExecuteQuery(sql.Text, usePaging, targetPage, pageSize, pageSetSize)

        End Function

        Public Overrides Function Validate(ByVal validateKeys As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object)) As Dictionary(Of String, Object)

            Dim GroupCode As String = dataParams("GroupCode").ToString
            Dim NameType As String = dataParams("NameType").ToString
            Dim Key As String = validateKeys("KEY")

            Dim sql As New SqlBox("CodeService@CommonCode")

            sql.Params("GRP_CD") = GroupCode
            sql.Params("KEY") = Key
            sql.Params("LANG_CD") = YJIT.SessionOfficeInfo.LanguageCode

            If NameType = "B" Then
                sql.Blocks("TYPE_B") = True
            ElseIf NameType = "C" Then
                sql.Blocks("TYPE_C") = True
            Else
                sql.Blocks("TYPE_A") = True
            End If
            sql.Blocks("VALIDATE") = True

            sql.Blocks("ColItem3") = True


            Return ExecuteQuery(sql.Text, usePaging:=False)

        End Function

    End Class

End Namespace

