Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz
    Public Class CrmDevAsList

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmDevAsList@Search")
                sql.AllowSqlInjection = True
                sql.Params("FM_YMD") = drHeader("S_FM_YMD").ToString
                sql.Params("TO_YMD") = drHeader("S_TO_YMD").ToString

                sql.Params("FM_YMD2") = drHeader("S_FM_YMD").ToString.Substring(0, 4) & "0101"
                sql.Params("TO_YMD2") = drHeader("S_TO_YMD").ToString

                sql.Params("DEPT_CD") = drHeader("S_DEPT_CD").ToString
                sql.Params("WORK_USR") = drHeader("S_WORK_USR").ToString


                If drHeader("S_DEPT_CD").ToString <> "" Then sql.Blocks("DEPT_CD") = True
                If drHeader("S_WORK_USR").ToString <> "" Then sql.Blocks("WORK_USR") = True

                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                ResultDs.Tables.Add(dt)


                ResultSet("TrxCode") = "Y"

                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception

                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function
        Public Shared Function Search3(ByVal ds As DataSet, ByVal sMngtNo As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmAsMgtDev@Search2")
                sql.AllowSqlInjection = True

                sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
                sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
                sql.Params("S_PROC_TYPE") = drHeader("S_DEV_PROC_TYPE").ToString.Replace("; ", "','")
                sql.Params("WORK_USR") = drHeader("S_DEV_WORK_USR").ToString
                sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
                sql.Params("S_MNGT_NO") = sMngtNo
                sql.Params("DEPT_CD") = SessionInfo.OrganizationCode

                If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True
                If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True
                If drHeader("S_DEV_PROC_TYPE").ToString <> "" Then sql.Blocks("S_PROC_TYPE") = True
                If drHeader("S_DEV_WORK_USR").ToString <> "" Then sql.Blocks("WORK_USR") = True
                If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
                sql.Blocks("DEPT_CD") = True

                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                ResultDs.Tables.Add(dt)


                ResultSet("TrxCode") = "Y"

                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception

                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function
        Public Shared Function SearchReq(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmAsMgtDev@SearchReq")
                sql.AllowSqlInjection = True
                'sql.Params("FM_YMD") = Now.ToString("yyyyMM") & "01"
                sql.Params("FM_YMD") = "20190101" 'DateAdd(DateInterval.Day, -30, Now).ToString("yyyyMMdd")
                sql.Params("TO_YMD") = Now.ToString("yyyyMMdd")
                If drHeader("INCLUDE_EXCEPT").ToString = "N" Then
                    sql.Blocks("EXCEPT_LIST") = True
                End If
                sql.Params("DEPT_CD") = SessionInfo.OrganizationCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG3"
                ResultDs.Tables.Add(dt)

                If drHeader("MNGT_NO").ToString <> "" Then
                    sql = New SqlBox("ComDocumentMgt@Search")
                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    If drHeader("MNGT_NO").ToString <> "" Then sql.Blocks("MNGT_NO") = True
                    dt = db.SqlGet(sql.Text, False)
                    dt.TableName = "WG2"
                    ResultDs.Tables.Add(dt)
                End If

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception

                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function

        Public Shared Function SearchFileList(ByVal sMngtNo As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                sql = New SqlBox("ComDocumentMgt@Search")
                sql.Params("MNGT_NO") = sMngtNo
                sql.Blocks("MNGT_NO") = True
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
                ResultDs.Tables.Add(dt)

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception
                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function
        Public Shared Function SearchAssign(ByVal ds As DataSet, ByVal sMngtNo As String, ByVal sDeptCd As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmAsMgtDev@SearchAssign")
                sql.AllowSqlInjection = True
                sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
                sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
                sql.Params("S_PROC_TYPE") = drHeader("S_DEV_PROC_TYPE").ToString.Replace("; ", "','")
                sql.Params("WORK_USR") = drHeader("S_DEV_WORK_USR").ToString
                sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
                sql.Params("S_MNGT_NO") = sMngtNo
                sql.Params("DEPT_CD") = sDeptCd
                sql.Params("WORK_AREA") = drHeader("WORK_AREA").ToString

                If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True
                If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True
                If drHeader("S_DEV_PROC_TYPE").ToString <> "" Then sql.Blocks("S_PROC_TYPE") = True
                If drHeader("S_DEV_WORK_USR").ToString <> "" Then sql.Blocks("WORK_USR") = True
                If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
                If drHeader("WORK_AREA").ToString <> "" Then sql.Blocks("WORK_AREA") = True
                If drHeader("CMPT_YMD_YN").ToString = "Y" Then
                    sql.Blocks("CMPT_YMD") = True
                Else
                    sql.Blocks("REQ_YMD") = True
                End If
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                ResultDs.Tables.Add(dt)


                ResultSet("TrxCode") = "Y"

                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception

                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function
    End Class
End Namespace
