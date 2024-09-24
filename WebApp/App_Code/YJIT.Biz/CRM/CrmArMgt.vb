Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class CrmArMgt

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
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

                sql = New SqlBox("CrmArMgt@Search")

                sql.Params("CUST_CD") = drHeader("S_CUST_CD").ToString
                sql.Params("USE_YN") = drHeader("S_USE_YN").ToString
                sql.Params("STOP_YN") = drHeader("S_STOP_YN").ToString
                sql.Params("STOP_DELAY") = drHeader("S_STOP_DELAY").ToString
                sql.Params("AR_TYPE") = drHeader("S_AR_TYPE").ToString
                sql.Params("ISSUE_TYPE") = drHeader("S_ISSUE_TYPE").ToString


                sql.Blocks("OVERDUE_TYPE_" & drHeader("S_OVERDUE_TYPE").ToString) = True

                If drHeader("S_CUST_CD").ToString <> "" Then sql.Blocks("CUST_CD") = True
                If drHeader("S_USE_YN").ToString <> "" Then sql.Blocks("USE_YN") = True
                If drHeader("S_STOP_YN").ToString = "Y" Then
                    sql.Blocks("STOP_Y") = True
                ElseIf drHeader("S_STOP_YN").ToString = "N" Then
                    sql.Blocks("STOP_N") = True
                End If
                If drHeader("S_STOP_DELAY").ToString <> "" Then sql.Blocks("STOP_DELAY") = True
                If drHeader("S_AR_TYPE").ToString <> "" Then sql.Blocks("AR_TYPE") = True
                If drHeader("S_ISSUE_TYPE").ToString <> "" Then sql.Blocks("ISSUE_TYPE") = True

                dt = db.SqlGet(Sql.Text, False)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                dt.TableName = "WG1"
                resultDs.Tables.Add(dt)

                SaveARInfo(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function SearchArList(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
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

                sql = New SqlBox("CrmArMgt@SearchArList")
                sql.Params("CUST_CD") = drHeader("S_CUST_CD").ToString
                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                dt.TableName = "WG1"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Dim dt As DataTable = Nothing
            Dim sql As SqlBox = Nothing
            db.BeginTransaction()

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)
                dt = ds.Tables("WG1")

                For Each dr As DataRow In dt.Rows
                    If dr("CHK_FLAG") = "Y" Then
                        Select Case dr("_INSFLAG")
                            Case "U"
                                sql = New SqlBox("CrmArMgt@SaveCustomerInfo")
                            Case Else

                        End Select
                        sql.Params("CUST_CD") = dr("CUST_CD").ToString
                        sql.Params("AR_TYPE") = dr("AR_TYPE").ToString
                        sql.Params("ISSUE_TYPE") = dr("ISSUE_TYPE").ToString
                        sql.Params("CREDIT_PIC_NM") = dr("CREDIT_PIC_NM").ToString
                        sql.Params("INFO_YMD") = dr("INFO_YMD").ToString
                        sql.Params("STOP_YMD") = dr("STOP_YMD").ToString
                        sql.Params("CREDIT_YMD") = dr("CREDIT_YMD").ToString
                        sql.Params("USE_YN") = dr("USE_YN").ToString
                        sql.Params("USR_ID") = SessionInfo.UserID

                        db.SqlSet(sql.Text)
                    End If
                Next

                db.Commit()
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet

        End Function

        Public Shared Function SaveARInfo(ByVal dt As DataTable) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Dim sql As SqlBox = Nothing
            db.BeginTransaction()

            Try
                For Each dr As DataRow In dt.Rows
                    sql = New SqlBox("CrmArMgt@SaveCustomerInfo")
                    sql.Params("CUST_CD") = dr("CUST_CD").ToString
                    sql.Params("AR_TYPE") = dr("AR_TYPE").ToString
                    sql.Params("ISSUE_TYPE") = dr("ISSUE_TYPE").ToString
                    sql.Params("CREDIT_PIC_NM") = dr("CREDIT_PIC_NM").ToString
                    sql.Params("INFO_YMD") = dr("INFO_YMD").ToString
                    sql.Params("STOP_YMD") = dr("STOP_YMD").ToString
                    sql.Params("CREDIT_YMD") = dr("CREDIT_YMD").ToString
                    sql.Params("USE_YN") = dr("USE_YN").ToString
                    sql.Params("USR_ID") = SessionInfo.UserID

                    db.SqlSet(sql.Text)
                Next

                db.Commit()
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet

        End Function

        '20240520 김정현 미수금액 갱신 로직 추가
        Public Shared Function RefreshRecAmt(ds As DataSet) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = True

            db.BeginTransaction()
            Try
                Dim param As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                param("R_RTNCD") = ""
                param("R_RTNMSG") = ""
                db.ExecuteProcedure("USP_ACT_CRM_REC_AMT", param)
                If ("" & param("R_RTNCD").ToString) = "E" Then
                    ThrowMsg(ErrorOccur, param("R_RTNMSG").ToString)
                End If
                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                resultSet("TrxCode") = "E"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return resultSet
        End Function
    End Class
End Namespace
