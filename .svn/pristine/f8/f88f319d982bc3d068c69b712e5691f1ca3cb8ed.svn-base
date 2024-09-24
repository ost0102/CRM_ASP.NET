Imports Microsoft.VisualBasic
Imports YJIT.Data
Imports System.Data
Imports System.IO

Namespace YJIT.Biz
    Public Class ComMailMsg
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function

        Public Shared Sub ThrowMsg(ByRef ErrorOccur As Boolean, ByVal Msg As String)
            ErrorOccur = False
            Throw New Exception(Msg)
        End Sub

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("ComMailMsg@Save")
                YJQuery.SaveRow(db, sql, IIf(String.IsNullOrEmpty(drHeader("COMN_CD").ToString), "I", "U"), drHeader)
                sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID

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

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet

        End Function

        Public Shared Function Delete(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("ComMailMsg@Delete")
                YJQuery.SaveRow(db, sql, "D", drHeader)
                sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID

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

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet

        End Function

    End Class
End Namespace

