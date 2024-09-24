Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.Exception

Namespace YJIT.Biz

    Public Class MdmUserAuth

        Public Shared Function SearchUser(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ResultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim ErrorOccur As Boolean = True
            Dim sql As SqlBox

            Try

                Dim dt As DataTable

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("MdmUserAuth@Search")

                sql.Params("AUTH_TP") = drHeader("S_GRP_ID").ToString
                sql.Params("OFFICE_CD") = drHeader("S_OFFICE_CD").ToString
                sql.Params("PGM_ID") = drHeader("S_PGM_ID").ToString

                If drHeader("S_GRP_ID").ToString <> "" Then sql.Blocks("AUTH_TP") = True
                If drHeader("S_OFFICE_CD").ToString <> "" Then sql.Blocks("OFFICE_CD") = True
                If drHeader("S_PGM_ID").ToString <> "" Then sql.Blocks("PGM_ID") = True

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


        Public Shared Function SearchUserAuth(ByVal userId As String, ByVal AuthGroup As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox

            Try
                sql = New SqlBox("MdmUserAuth@SearchUserAuth")
                sql.Params("USR_ID") = userId
                sql.Params("GRP_ID") = AuthGroup
                Dim dt As DataTable
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
                resDs.Tables.Add(dt)

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "NODATA"
                    resultSet("TrxMsg") = "Data not found!"
                Else
                    resultSet("TrxCode") = "SUCCESS"
                End If

            Catch ex As Exception
                Throw ex
            End Try

            resultSet("Data") = resDs

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
                Dim userId As String = drHeader("USR_ID").ToString
                Dim GrpId As String = drHeader("GRP_ID").ToString

                dt = ds.Tables("WG2")
                For Each dr As DataRow In dt.Rows
                    sql = New SqlBox("MdmUserAuth@Insert")
                    sql.Params("SYS_ID") = dr("SYS_ID")
                    sql.Params("PGM_ID") = dr("PGM_ID")
                    sql.Params("FUNC_ID") = dr("FUNC_ID")
                    sql.Params("USR_ID") = userId
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

    End Class


End Namespace
