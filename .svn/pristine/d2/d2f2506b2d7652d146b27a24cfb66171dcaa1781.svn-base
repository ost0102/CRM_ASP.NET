'###################################################################################'
'## VB.NET과 FRAMEWORK 중간에서 개발에 도움을 주기 위함 MIDDLEWARE 개념의 CLASS   ##
'## 개별수정 금지                                                                 ##
'## 고객서비스 센터와 상의해주세요.                                               ##
'###################################################################################'


Imports System.ComponentModel

Public Class YJQuery
    Public DataSet As DataSet

    Public Sub New()
        Dim dtSqlBox As New DataTable
        Dim dtParams As New DataTable
        Dim dtBlocks As New DataTable

        dtSqlBox.Columns.Add("ID", GetType(String))
        dtSqlBox.Columns.Add("TableName", GetType(String))
        dtSqlBox.Columns.Add("AllowSqlInjection", GetType(Boolean))
        dtSqlBox.Columns.Add("IsOptional", GetType(Boolean))
        dtSqlBox.TableName = "SqlBox"

        dtParams.Columns.Add("ID", GetType(String))
        dtParams.Columns.Add("Data", GetType(String))
        dtParams.Columns.Add("TableName", GetType(String))
        dtParams.Columns.Add("IsOptional", GetType(Boolean))
        dtParams.TableName = "Params"

        dtBlocks.Columns.Add("ID", GetType(String))
        dtBlocks.Columns.Add("Data", GetType(Boolean))
        dtBlocks.Columns.Add("TableName", GetType(String))
        dtBlocks.Columns.Add("IsOptional", GetType(Boolean))
        dtBlocks.TableName = "Blocks"

        DataSet = New DataSet
        DataSet.Tables.Add(dtSqlBox)
        DataSet.Tables.Add(dtParams)
        DataSet.Tables.Add(dtBlocks)
    End Sub

    <Category("YJIT"), Description("Specify whether control's data comes from database or not. If true, it will affter the DataState of View form when its value changes")> _
    Public Sub SqlBox(ByVal TableName As String, ByVal ID As String, Optional ByVal AllowSqlInjection As Boolean = False, Optional ByVal IsOptional As Boolean = True)
        Dim dr As DataRow
        dr = DataSet.Tables("SqlBox").NewRow
        dr("ID") = ID
        dr("TableName") = TableName
        dr("AllowSqlInjection") = AllowSqlInjection
        dr("IsOptional") = IsOptional
        DataSet.Tables("SqlBox").Rows.Add(dr)
    End Sub

    Public Sub Params(ByVal ID As String, ByVal Data As String, Optional ByVal IsOptional As Boolean = True)
        If IsOptional = True Then
            If Data.ToString.Trim = "" Then Exit Sub
        End If
        Dim dr As DataRow
        dr = DataSet.Tables("Params").NewRow
        dr("ID") = ID
        dr("TableName") = GetTableName()
        dr("Data") = Data
        dr("IsOptional") = IsOptional
        DataSet.Tables("Params").Rows.Add(dr)

        Call Blocks(ID, Data, IsOptional)
    End Sub

    Public Sub Blocks(ByVal ID As String, ByVal Data As String, Optional ByVal IsOptional As Boolean = True)
        Dim dr As DataRow
        dr = DataSet.Tables("Blocks").NewRow
        dr("ID") = ID
        dr("TableName") = GetTableName()
        If IsOptional = False Then
            dr("Data") = True
        Else
            If Data.ToString.Trim = "" Then
                dr("Data") = False
            Else
                dr("Data") = True
            End If
        End If
        dr("IsOptional") = IsOptional
        DataSet.Tables("Blocks").Rows.Add(dr)
    End Sub

    Private Function GetTableName() As String
        If DataSet.Tables("SqlBox").Rows.Count = 0 Then Return ""
        Return DataSet.Tables("SqlBox").Rows(DataSet.Tables("SqlBox").Rows.Count - 1)("TableName")
    End Function

End Class
