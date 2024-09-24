Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class CrmDMPrint

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

                sql = New SqlBox("CrmDMPrint@Search")
                sql.AllowSqlInjection = True
                sql.Params("LOC_FRGN_TYPE") = drHeader("S_LOC_FRGN_TYPE").ToString
                sql.Params("CTRY") = drHeader("S_CTRY").ToString
                sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
                sql.Params("SVC_CD") = drHeader("S_SVC_CD").ToString
                sql.Params("SALES_NM") = drHeader("S_SALES_NM").ToString
                If drHeader("S_LOC_FRGN_TYPE").ToString = "L" Then sql.Blocks("LOC") = True
                If drHeader("S_LOC_FRGN_TYPE").ToString = "F" Then sql.Blocks("FRGN") = True
                If drHeader("S_CTRY").ToString <> "" Then sql.Blocks("CTRY") = True
                If drHeader("CUST_CD").ToString <> "" Then sql.Blocks("CUST_CD") = True
                If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("SVC_CD") = True
                If drHeader("S_SALES_NM").ToString <> "" Then sql.Blocks("SALES_NM") = True

                If drHeader("CUST_ORDER_A").ToString = "Y" Then sql.Blocks("CUST_ORDER_A") = True
                If drHeader("CUST_ORDER_Z").ToString = "Y" Then sql.Blocks("CUST_ORDER_Z") = True
                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
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



        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim insflag As String = ""
            Dim CustCode As String = ""
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If


                Dim dt As DataTable = ds.Tables("WG1")
                For Each dr In dt.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmAsMgt@Insert")
                        Case "U"
                            sql = New SqlBox("CrmAsMgt@Update")
                        Case "D"
                            sql = New SqlBox("CrmAsMgt@Delete")
                    End Select
                    sql.Params("YYMM") = Now.ToString("yyyyMMdd").Substring(2, 4)
                    sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                    sql.Params("REQ_YMD") = dr("REQ_YMD").ToString
                    sql.Params("REQ_HM") = dr("REQ_HM").ToString
                    sql.Params("REQ_SVC") = dr("REQ_SVC").ToString
                    sql.Params("CUST_CD") = dr("CUST_CD").ToString
                    sql.Params("CONTENT") = dr("CONTENT").ToString
                    sql.Params("REQ_USR") = dr("REQ_USR").ToString
                    sql.Params("TEL_NO") = dr("TEL_NO").ToString
                    sql.Params("PROC_TYPE") = dr("PROC_TYPE").ToString
                    sql.Params("PRIORITY") = dr("PRIORITY").ToString
                    If dr("PROC_TYPE").ToString = "1" Or dr("PROC_TYPE").ToString = "2" Or
                        dr("PROC_TYPE").ToString = "7" Or dr("PROC_TYPE").ToString = "8" Then
                        sql.Params("WORK_USR") = YJIT.SessionInfo.LocalName
                    Else
                        sql.Params("WORK_USR") = ""
                    End If
                    'sql.Params("WORK_USR") = dr("WORK_USR").ToString
                    sql.Params("PRAR_YMD") = dr("PRAR_YMD").ToString
                    If dr("PROC_TYPE").ToString = "1" Or dr("PROC_TYPE").ToString = "2" Then
                        sql.Params("CMPT_YMD") = Now.ToString("yyyyMMdd")
                    Else
                        sql.Params("CMPT_YMD") = ""
                    End If
                    'sql.Params("CMPT_YMD") = dr("CMPT_YMD").ToString
                    sql.Params("RMK") = dr("RMK").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return resultSet

        End Function


    End Class
End Namespace
