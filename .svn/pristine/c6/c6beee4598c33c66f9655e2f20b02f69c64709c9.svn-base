Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common


Namespace YJIT.Biz
    Public Class EvbClaimMgt

        'Search
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim param As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim dsRet As DataSet = New DataSet
            Dim resultSet As New Dictionary(Of String, Object)

            resultSet("TrxCode") = "E"
            resultSet("TrxMsg") = "Error"
            resultSet("Data") = dsRet

            Try
                If Not ds.Tables.Contains("params") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("params").Rows(0)

                param("P_YEAR_MONTH") = drHeader("DATA").ToString '년월
                param("P_SEARCH_TYPE") = "I"
                param("R_RTNCD") = ""
                param("R_RTNMSG") = ""
                db.ExecuteProcedure("USP_EVB_CLAIM_CLOSE", param)

                If ("" & param("R_RTNCD").ToString) = "E" Then
                    ThrowMsg(ErrorOccur, "Error while Claim Close Processing!" & vbCrLf & "Error Msg: " & param("R_RTNMSG").ToString)
                End If
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
                Return resultSet
            End Try

            Return YJQuery.Search(ds)
        End Function

        'Save
        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim dt As DataTable = Nothing
            Dim sql As SqlBox = Nothing

            ResultSet("TrxCode") = "E"
            ResultSet("TrxMsg") = "Error"
            ResultSet("Data") = ds

            If Not ds.Tables.Contains("WG1") Then
                ThrowMsg(ErrorOccur, "Grid Data info missing")
            End If

            Try
                db.BeginTransaction()

                dt = ds.Tables("WG1")

                For Each row As DataRow In dt.Rows
                    sql = New SqlBox("EvbClaimMgt@Update")
                    YJQuery.SaveRow(db, sql, "U", row)
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
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

            If ResultSet("TrxCode") = "Y" Then
                ResultSet("Data") = Search(ds)("Data")
            End If

            Return ResultSet
        End Function

        '재정산
        Public Shared Function Recalc(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim param As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim dsRet As DataSet = New DataSet

            ResultSet("TrxCode") = "E"
            ResultSet("TrxMsg") = "Error"
            ResultSet("Data") = dsRet

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                param("P_YEAR_MONTH") = drHeader("YEAR_MONTH").ToString '년월
                param("P_SEARCH_TYPE") = "R"
                param("R_RTNCD") = ""
                param("R_RTNMSG") = ""
                db.ExecuteProcedure("USP_EVB_CLAIM_CLOSE", param)

                If ("" & param("R_RTNCD").ToString) = "E" Then
                    ThrowMsg(ErrorOccur, "Error while Claim Close Processing!" & vbCrLf & "Error Msg: " & param("R_RTNMSG").ToString)
                End If
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
                Return ResultSet
            End Try

            Return YJQuery.Search(ds)
        End Function

        '마감
        Public Shared Function Close(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim dt As DataTable = Nothing
            Dim sql As SqlBox = Nothing

            ResultSet("TrxCode") = "E"
            ResultSet("TrxMsg") = "Error"
            ResultSet("Data") = ds

            If Not ds.Tables.Contains("WG1") Then
                ThrowMsg(ErrorOccur, "Grid Data info missing")
            End If

            Try
                db.BeginTransaction()

                dt = ds.Tables("WG1")

                For Each row As DataRow In dt.Rows
                    If row("CLOSE_YN").ToString = "N" Then
                        sql = New SqlBox("EvbClaimMgt@Close")
                        YJQuery.SaveRow(db, sql, row("_INSFLAG").ToString, row)
                        sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                        db.SqlSet(sql.Text)
                    End If
                Next

                db.Commit()
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "마감이 완료되었습니다."

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            If ResultSet("TrxCode") = "Y" Then
                ResultSet("Data") = Search(ds)("Data")
            End If

            Return ResultSet
        End Function
    End Class
End Namespace