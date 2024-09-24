Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common
Imports System.Collections.Generic
Imports System.IO


Namespace YJIT.Biz

    Public Class SysBoardList

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim dt As New DataTable

            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                Dim sql As New SqlBox("SysBoardList@Search")
                sql.Params("DATE_FM") = drHeader("S_DATE_FM").ToString
                sql.Params("DATE_TO") = drHeader("S_DATE_TO").ToString
                sql.Params("BOARD_ID") = drHeader("S_BOARD_ID").ToString
                sql.Params("TITLE") = drHeader("S_TITLE").ToString
                sql.Params("OP_CD") = drHeader("S_OP_CD").ToString
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID

                If drHeader("S_DATE_FM").ToString <> "" Then sql.Blocks("DATE_FM") = True
                If drHeader("S_DATE_TO").ToString <> "" Then sql.Blocks("DATE_TO") = True
                If drHeader("S_BOARD_ID").ToString <> "" Then sql.Blocks("BOARD_ID") = True
                If drHeader("S_TITLE").ToString <> "" Then sql.Blocks("TITLE") = True
                If drHeader("S_OP_CD").ToString <> "" Then sql.Blocks("OP_CD") = True
                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "WG1"
                resultDs.Tables.Add(dt)

                sql = New SqlBox("SysBoardList@SearchCustomer")
                sql.Params("S_SVC_CD") = drHeader("S_SVC_CD").ToString
                If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("S_SVC_CD") = True
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
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

        Public Shared Function SearchCustList(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim dt As New DataTable

            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                Dim sql As New SqlBox("SysBoardList@SearchCustList")
                sql.Params("BOARD_ID") = drHeader("BOARD_ID").ToString
                sql.Params("SVC_CD") = drHeader("S_SVC_CD").ToString
                If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("SVC_CD") = True

                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "WG2"
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
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox
            Dim drHeader As DataRow
            Dim ErrorOccur As Boolean = True

            drHeader = ds.Tables("MAIN").Rows(0)
            ' ==============BEGIN UPDATE========================
            Try

                db.BeginTransaction()

                '기존자료 삭제
                sql = New SqlBox("SysBoardList@Delete")
                sql.Params("BOARD_ID") = drHeader("BOARD_ID").ToString
                db.SqlSet(sql.Text)

                dt = ds.Tables("WG2")
                For Each dr As DataRow In dt.Rows
                    If dr("CHK") = "Y" Then
                        sql = New SqlBox("SysBoardList@Insert")
                        sql.Params("BOARD_ID") = drHeader("BOARD_ID").ToString
                        sql.Params("DOMAIN") = dr("DOMAIN").ToString
                        sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                        db.SqlSet(sql.Text)
                    End If
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
