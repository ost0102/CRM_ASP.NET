Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO

Namespace YJIT.Biz

    Public Class EchSendList
        Public Shared Function SearchSummary(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable = Nothing
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("EchSendList@SearchSummary")
                sql.AllowSqlInjection = True
                sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
                sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
                sql.Params("CUST_CD") = drHeader("S_CUST_CD").ToString
                sql.Params("CUST_NM") = drHeader("S_CUST_NM").ToString
                sql.Params("DOC_CD") = drHeader("S_DOC_CD").ToString
                sql.Params("VENDOR") = drHeader("S_VENDOR").ToString
                sql.Params("CRM_CUST_CD") = drHeader("S_CRM_CUST_CD").ToString

                If drHeader("S_CUST_CD").ToString <> "" Then sql.Blocks("CUST_CD") = True
                If drHeader("S_CUST_NM").ToString <> "" Then sql.Blocks("CUST_NM") = True
                If drHeader("S_DOC_CD").ToString <> "" Then sql.Blocks("DOC_CD") = True
                If drHeader("S_VENDOR").ToString <> "" Then sql.Blocks("VENDOR") = True
                If drHeader("S_CRM_CUST_CD").ToString <> "" Then sql.Blocks("CRM_CUST_CD") = True

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
        Public Shared Function SearchSendStatus(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim sql2 As SqlBox
            Dim dt As DataTable = Nothing
            Dim dt2 As DataTable = Nothing
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                db.BeginTransaction()

                sql = New SqlBox("EchSendList@Delete")
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)


                For i = 0 To 1
                    sql = New SqlBox("EchSendList@SearchSummary")
                    sql.AllowSqlInjection = True
                    If i = 0 Then
                        sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
                    Else
                        sql.Params("FM_YMD") = drHeader("FM_YMD").ToString.Substring(0, 6) & "01"
                    End If
                    sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
                    sql.Params("CUST_CD") = drHeader("S_CUST_CD").ToString
                    sql.Params("CUST_NM") = drHeader("S_CUST_NM").ToString
                    sql.Params("DOC_CD") = drHeader("S_DOC_CD").ToString
                    sql.Params("VENDOR") = drHeader("S_VENDOR").ToString

                    If drHeader("S_CUST_CD").ToString <> "" Then sql.Blocks("CUST_CD") = True
                    If drHeader("S_CUST_NM").ToString <> "" Then sql.Blocks("CUST_NM") = True
                    If drHeader("S_DOC_CD").ToString <> "" Then sql.Blocks("DOC_CD") = True
                    If drHeader("S_VENDOR").ToString <> "" Then sql.Blocks("VENDOR") = True

                    sql2 = New SqlBox("EchSendList@InsertData")
                    sql2.AllowSqlInjection = True
                    sql2.Params("USR_ID") = YJIT.SessionInfo.UserID
                    sql2.Params("SEQ") = i
                    sql2.Params("BODY") = sql.Text
                    db.SqlSet(sql2.Text)

                Next

                'sql2 = New SqlBox("EchSendList@InsertData2")
                'sql2.AllowSqlInjection = True
                'sql2.Params("USR_ID") = YJIT.SessionInfo.UserID
                'sql2.Params("SEQ") = 3
                'sql2.Params("BODY") = sql.Text
                'db.SqlSet(sql2.Text)

                sql = New SqlBox("EchSendList@SearchStatus")
                sql.AllowSqlInjection = True
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("EchSendList@SearchCustCnt")
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "SearchCustCnt"
                ResultDs.Tables.Add(dt)

                ResultSet("TrxCode") = "Y"


                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

                db.Commit()

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet

        End Function
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

                sql = New SqlBox("EchSendList@Search")
                sql.AllowSqlInjection = True
                sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
                sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
                sql.Params("CUST_CD") = drHeader("S_CUST_CD").ToString
                sql.Params("CUST_NM") = drHeader("S_CUST_NM").ToString
                sql.Params("DOC_CD") = drHeader("S_DOC_CD").ToString
                sql.Params("CRM_CUST_CD") = drHeader("S_CRM_CUST_CD").ToString

                If drHeader("S_CUST_CD").ToString <> "" Then sql.Blocks("CUST_CD") = True
                If drHeader("S_CUST_NM").ToString <> "" Then sql.Blocks("CUST_NM") = True
                If drHeader("S_DOC_CD").ToString <> "" Then sql.Blocks("DOC_CD") = True
                If drHeader("S_CRM_CUST_CD").ToString <> "" Then sql.Blocks("CRM_CUST_CD") = True

                Select Case drHeader("S_TYPE")
                    Case "A"
                    Case "M"
                        sql.Blocks("MFCS") = True
                    Case "F"
                        sql.Blocks("AFR") = True
                End Select

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

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

    End Class
End Namespace
