Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic

Imports YJIT.Data
Imports YJIT.Web.UI.WebControls
Imports YJIT.Web.UI.WebControls.CodeBox

Namespace YJIT.CodeService

    Public Class Customer
        Inherits CodeBox.CodeService

        Public Overrides Function List(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Return Nothing

        End Function

        Public Overrides Function Search(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)
            Dim sql As SqlBox = Nothing

            sql = New SqlBox("CodeService@Customer")

            sql.Params("KEY") = searchParams("SearchKey")
            If searchParams("SearchKey").ToString <> "" Then
                sql.Blocks("SEARCH") = True
            End If

            If dataParams.ContainsKey("USE_YN") Then
                sql.Params("USE_YN") = dataParams("USE_YN").ToString
                sql.Blocks("USE_YN") = True
            End If

            Return ExecuteQuery(sql.Text, usePaging, targetPage, pageSize, pageSetSize)

        End Function

        Public Overrides Function Validate(ByVal validateKeys As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object)) As Dictionary(Of String, Object)
            Dim sql As SqlBox = Nothing
            Dim rtnDic As Dictionary(Of String, Object) = Nothing

            '20180720 물류회계 1차 코드검색, 2차 명검색후 1건이면 적용, 그렇지 않으면 코드검색창연동하기 위해서 추가 
            sql = GetValidate(validateKeys, dataParams, "VALIDATE")
            rtnDic = ExecuteQuery(sql.Text, usePaging:=False)

            If IsNothing(rtnDic("Data")) Then
                sql = GetValidate(validateKeys, dataParams, "VALIDATE_LIKE")
                rtnDic = ExecuteQuery(sql.Text, usePaging:=False)
                If Not IsNothing(rtnDic("Data")) Then
                    If CType(rtnDic("Data"), DataTable).Rows.Count > 1 Then
                        rtnDic("Data") = Nothing
                    End If
                End If
            End If


            Return rtnDic
        End Function
        Private Function GetValidate(ByVal validateKeys As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), ByVal ValidateBlocks As String) As SqlBox
            Dim sql As SqlBox = Nothing

            sql = New SqlBox("CodeService@Customer")
            sql.Params("KEY") = validateKeys("KEY")

            If dataParams.ContainsKey("USE_YN") Then
                sql.Params("USE_YN") = dataParams("USE_YN").ToString
                sql.Blocks("USE_YN") = True
            End If

            sql.Blocks(ValidateBlocks) = True

            Return sql
        End Function

    End Class

End Namespace

