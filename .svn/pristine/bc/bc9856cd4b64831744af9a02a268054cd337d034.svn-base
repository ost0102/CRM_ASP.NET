Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class CrmAsList
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function

        Public Shared Function SaveScore(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow
            Dim dt As DataTable

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                dt = ds.Tables("WG1")
                For Each row In dt.Rows
                    sql = New SqlBox("CrmAsList@SaveScore")
                    YJQuery.SaveRow(db, sql, "U", row)
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

                resultSet("Data") = Search(ds)("Data")
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return resultSet

        End Function



        'Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
        '    Dim ResultSet As New Dictionary(Of String, Object)
        '    Dim ResultDs As DataSet = New DataSet
        '    Dim db As DBA = New DBA()
        '    Dim drHeader As DataRow
        '    Dim sql As SqlBox
        '    Dim dt As DataTable
        '    Dim ErrorOccur As Boolean = True
        '    Try

        '        If Not ds.Tables.Contains("MAIN") Then
        '            ThrowMsg(ErrorOccur, "Data info missing.")
        '        End If
        '        drHeader = ds.Tables("MAIN").Rows(0)

        '        sql = New SqlBox("CrmAsList@Search")
        '        sql.AllowSqlInjection = True

        '        sql.Params("FM_YMD") = drHeader("S_FM_YMD").ToString
        '        If drHeader("S_FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True

        '        sql.Params("TO_YMD") = drHeader("S_TO_YMD").ToString
        '        If drHeader("S_TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True

        '        If drHeader.Table.Columns.Contains("S_DATE_TYPE") = True Then
        '            If drHeader("S_DATE_TYPE") = "R" Then
        '                sql.Blocks("REQ_YMD") = True
        '            ElseIf drHeader("S_DATE_TYPE") = "C" Then
        '                sql.Blocks("CMPT_YMD") = True
        '            Else
        '                sql.Blocks("REQ_YMD") = True
        '            End If
        '        Else
        '            sql.Blocks("REQ_YMD") = True
        '        End If


        '        sql.Blocks("DEPT_TYPE_" & drHeader("S_DEPT_TYPE").ToString) = True
        '        sql.Params("DEPT_CD") = drHeader("S_DEPT_CD").ToString
        '        If drHeader("S_DEPT_CD").ToString <> "" Then sql.Blocks("DEPT_CD") = True

        '        sql.Params("DEPT_AUTH") = drHeader("S_DEPT_AUTH").ToString
        '        If drHeader("S_DEPT_AUTH").ToString <> "" Then sql.Blocks("DEPT_AUTH") = True

        '        sql.Params("CUST_CD") = drHeader("S_CUST_CD").ToString
        '        If drHeader("S_CUST_CD").ToString <> "" Then sql.Blocks("CUST_CD") = True

        '        If drHeader("S_WORK_TYPE") = "W" Then
        '            sql.Blocks("WORK_TYPE_" & drHeader("S_WORK_TYPE").ToString) = True
        '            'sql.Params("WORK_USR_NM") = drHeader("S_WORK_USR_NM").ToString
        '            'If drHeader("S_WORK_USR_NM").ToString <> "" Then sql.Blocks("WORK_USR_NM") = True
        '        ElseIf drHeader("S_WORK_TYPE") = "I" Then
        '            sql.Blocks("WORK_TYPE_" & drHeader("S_WORK_TYPE").ToString) = True
        '            'sql.Params("WORK_USR") = drHeader("S_WORK_USR").ToString
        '            'If drHeader("S_WORK_USR").ToString <> "" Then sql.Blocks("WORK_USR") = True
        '        End If
        '        sql.Params("WORK_USR") = drHeader("S_WORK_USR").ToString
        '        If drHeader("S_WORK_USR").ToString <> "" Then sql.Blocks("WORK_USR") = True

        '        sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
        '        If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True

        '        sql.Params("REQ_SVC") = drHeader("S_REQ_SVC").ToString
        '        If drHeader("S_REQ_SVC").ToString <> "" Then sql.Blocks("REQ_SVC") = True

        '        sql.Params("REQ_SVC2") = drHeader("S_REQ_SVC2").ToString
        '        If drHeader("S_REQ_SVC2").ToString <> "" Then sql.Blocks("REQ_SVC2") = True

        '        If drHeader.Table.Columns.Contains("S_REQ_TYPE2") Then
        '            sql.Params("REQ_TYPE2") = drHeader("S_REQ_TYPE2").ToString
        '            If drHeader("S_REQ_TYPE2").ToString <> "" Then sql.Blocks("REQ_TYPE2") = True
        '        End If

        '        sql.Params("PROC_TYPE") = drHeader("S_PROC_TYPE").ToString.Replace(";", "','").Replace(" ", "")
        '        If drHeader("S_PROC_TYPE").ToString <> "" Then sql.Blocks("PROC_TYPE") = True


        '        If drHeader.Table.Columns.Contains("S_EX_IM_TYPE") Then
        '            sql.Params("EX_IM_TYPE") = drHeader("S_EX_IM_TYPE").ToString
        '            If drHeader("S_EX_IM_TYPE").ToString <> "" Then sql.Blocks("EX_IM_TYPE") = True
        '        End If

        '        If drHeader.Table.Columns.Contains("S_FIRST_DATA_YN") Then
        '            If drHeader("S_FIRST_DATA_YN").ToString = "Y" Then
        '                sql.Blocks("FIRST_DATA_Y") = True
        '            End If
        '        End If

        '        dt = db.SqlGet(sql.Text, False)

        '        If dt.Rows.Count = 0 Then
        '            ThrowMsg(ErrorOccur, "Data not found!")
        '        End If
        '        dt.TableName = "WG1"
        '        ResultDs.Tables.Add(dt)


        '        ResultSet("TrxCode") = "Y"
        '        ResultSet("TrxMsg") = "Success"
        '        ResultSet("Data") = ResultDs

        '    Catch ex As Exception

        '        If ErrorOccur Then
        '            ResultSet("TrxCode") = "E"
        '        Else
        '            ResultSet("TrxCode") = "N"
        '        End If
        '        ResultSet("TrxMsg") = ex.Message
        '    End Try

        '    Return ResultSet
        'End Function
    End Class
End Namespace
