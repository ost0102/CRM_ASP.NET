Imports System.Data
Imports YJIT.Data
Imports YJIT.BIZ.Common

Namespace YJIT.BIZ
    Public Class EvbMembers
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function
        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim dt As DataTable = Nothing
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim dr As DataRow = Nothing
            Dim insFlag As String = "U"

            resultSet("trxCode") = "E"
            resultSet("trxMsg") = "Error"
            resultSet("Data") = dsRet

            If Not ds.Tables.Contains("MAIN") Then
                ThrowMsg(ErrorOccur, "Data info missing.")
            End If

            dr = ds.Tables("MAIN").Rows(0)
            Try
                db.BeginTransaction()
                'MAIN TABLE

                sql = New SqlBox("EvbMembers@SaveValidate")
                sql.Params("USER_AUTH_ID") = dr("USER_AUTH_ID").ToString
                sql.Params("BUSN_NO") = dr("BUSN_NO").ToString
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    insFlag = "U"
                Else
                    insFlag = "I"
                End If

                Select Case insFlag
                    Case "I"
                        sql = New SqlBox("EvbMembers@Insert")
                    Case "U"
                        sql = New SqlBox("EvbMembers@Update")
                End Select
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                YJQuery.SaveRow(db, sql, insFlag, dr)
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