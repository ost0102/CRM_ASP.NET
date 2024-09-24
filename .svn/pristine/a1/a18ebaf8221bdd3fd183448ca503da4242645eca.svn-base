Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class CrmAsEvent
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function
        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim dt1 As DataTable
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                dt1 = ds.Tables("WG1")

                For Each dr As DataRow In dt1.Rows
                    Select Case dr("_INSFLAG")
                        Case "U"
                            sql = New SqlBox("CrmAsEvent@Update")
                        Case Else
                            Continue For
                    End Select
                    sql.Params("RMK") = dr("RMK").ToString()
                    sql.Params("CMPT_RMK") = dr("CMPT_RMK").ToString()
                    sql.Params("MNGT_NO") = dr("MNGT_NO").ToString()
                    sql.Params("WORK_USR") = YJIT.SessionInfo.UserID

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

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet

        End Function
    End Class
End Namespace
