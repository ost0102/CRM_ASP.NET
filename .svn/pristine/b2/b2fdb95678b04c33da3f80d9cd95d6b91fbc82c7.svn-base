Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common

Namespace YJIT.Biz

    Public Class MdmGroupAuth

        Public Shared Function Search() As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            Dim dt As DataTable = Nothing

            Try

                sql = New SqlBox("MdmGroupAuth@Search")
                If YJIT.SessionInfo.AuthorizationType <> "0" Then
                    sql.Blocks("AUTH_ADMIN_FALSE") = True
                End If
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"

                resDs.Tables.Add(dt)
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            End Try
            Return resultSet

        End Function


        Public Shared Function SearchGroupAuth(ByVal groupId As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            Dim dt As DataTable = Nothing

            Try
                sql = New SqlBox("MdmGroupAuth@SearchGroupAuth")
                sql.Params("GRP_ID") = groupId
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"

                resDs.Tables.Add(dt)
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            End Try
            Return resultSet

        End Function


        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim dt As DataTable
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True


            db.BeginTransaction()

            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                Dim groupId As String = drHeader("GRP_ID")

                dt = ds.Tables("WG2")
                For Each dr As DataRow In dt.Rows
                    sql = New SqlBox("MdmGroupAuth@Insert")
                    sql.Params("SYS_ID") = dr("SYS_ID").ToString
                    sql.Params("PGM_ID") = dr("PGM_ID").ToString
                    sql.Params("FUNC_ID") = dr("FUNC_ID").ToString
                    sql.Params("GRP_ID") = groupId
                    sql.Params("USE_YN") = dr("USE_YN")
                    sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                    sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
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

        Public Shared Function Apply(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()

            Dim drHeader As DataRow = Nothing
            Dim dt As DataTable = Nothing
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True

            db.BeginTransaction()
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                Select Case drHeader("INS_TYPE").ToString
                    Case "R"
                        sql = New SqlBox("MdmGroupAuth@CopyNew")
                    Case "A"
                        sql = New SqlBox("MdmGroupAuth@CopyAdd")
                    Case Else
                        ThrowMsg(ErrorOccur, "Select Insert Type")
                End Select
                sql.Params("FM_GRP_ID") = drHeader("FM_GRP_ID").ToString
                sql.Params("TO_GRP_ID") = drHeader("TO_GRP_ID").ToString
                sql.Params("USR_ID") = SessionInfo.UserID

                db.SqlSet(sql.Text)

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
