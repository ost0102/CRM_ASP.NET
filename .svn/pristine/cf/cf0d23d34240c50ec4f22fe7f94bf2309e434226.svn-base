Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic

Imports YJIT.Data
Imports YJIT.Web.UI.WebControls
Imports YJIT.Web.UI.WebControls.CodeBox

Namespace YJIT.CodeService

    ''' <summary>
    ''' User
    ''' </summary>
    ''' <remarks></remarks>
    Public Class User
        Inherits CodeBox.CodeService

        Public Overrides Function List(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Dim Type As String = dataParams("Type").ToString
            Dim Dept As String = String.Empty : dataParams.TryGetValue("DEPT", Dept)

            Dim sql As New SqlBox("CodeService@User")
            '1804017/cshwang/User Search와 동일하게 변경/crm:YJITS2018043945
            'If Type = "Salesman" Then
            '    sql.Blocks("SALESMAN") = True
            'End If
            If Type = "ENG_NM" Then
                sql.Blocks("ENG_NM") = True
            Else
                sql.Blocks("LOC_NM") = True
            End If

            If Not String.IsNullOrEmpty(Dept) Then
                sql.Params("DEPT_CD") = Dept
                sql.Blocks("DEPT_CD") = True
            End If

            Dim OBJ As Dictionary(Of String, Object) = ExecuteQuery(sql.Text, usePaging = False, targetPage, pageSize, pageSetSize)
            For Each dt In OBJ.Values
                If Not dt Is Nothing Then
                    For I = dt.Columns.Count - 1 To 0 Step -1
                        If Not dt.Columns(I).ColumnName.Contains("CODE") AndAlso _
                           Not dt.Columns(I).ColumnName.Contains("NAME") Then
                            dt.Columns.RemoveAt(I)
                        End If
                    Next
                End If
            Next

            Return OBJ


        End Function

        Public Overrides Function Search(ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As Dictionary(Of String, Object)

            Dim Type As String = dataParams("Type").ToString
            Dim Office As String = dataParams("Office").ToString
            Dim Dept As String = String.Empty : dataParams.TryGetValue("Dept", Dept)

            Dim sql As New SqlBox("CodeService@User")
            sql.Params("KEY") = searchParams("SearchKey").ToString
            sql.Params("OFFICE_CD") = Office

            If Not String.IsNullOrEmpty(Dept) Then
                sql.Params("DEPT_CD") = Dept
                sql.Blocks("DEPT_CD") = True
            End If

            If searchParams("SearchKey").ToString <> "" Then
                sql.Blocks("SEARCH") = True
            End If
            If Type = "ENG_NM" Then
                sql.Blocks("ENG_NM") = True
            Else
                sql.Blocks("LOC_NM") = True
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
            Dim Type As String = dataParams("Type").ToString
            Dim Office As String = dataParams("Office").ToString

            Dim sql As SqlBox = New SqlBox("CodeService@User")
            sql.Params("KEY") = validateKeys("KEY")
            sql.Params("OFFICE_CD") = Office
            If Type = "ENG_NM" Then
                sql.Blocks("ENG_NM") = True
            Else
                sql.Blocks("LOC_NM") = True
            End If
            sql.Blocks(ValidateBlocks) = True

            Return sql
        End Function
    End Class


End Namespace
