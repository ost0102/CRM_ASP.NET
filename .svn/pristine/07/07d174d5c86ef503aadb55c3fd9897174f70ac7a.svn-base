Imports System.Data
Imports YJIT.Data

Namespace YJIT.Biz
    Public Class CrmProjectMgt
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable = Nothing
            Dim ErrorOccur As Boolean = True
            Dim cnt As Integer = 0


            resultSet("TrxCode") = "E"
            resultSet("TrxMsg") = "Error"

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    Throw New Exception("Data info missing.")
                End If
                If Not ds.Tables.Contains("WG1") Then
                    Throw New Exception("Grid Data info missing.")
                End If
                If ds.Tables("WG1").Rows.Count = 0 Then
                    Throw New Exception("Grid Data info missing.")
                End If

                Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)

                For Each dr As DataRow In ds.Tables("WG1").Rows
                    '## Key No 생성
                    If dr("_INSFLAG").ToString = "I" Then
                        Dim i As Integer = 1
                        Do While String.IsNullOrEmpty(dr("MNGT_NO").ToString)
                            dr("MNGT_NO") = String.Format("{0}{1}", Format(Now, "yyyyMMddHHmmss"), Now.Millisecond)
                            '중복체크
                            sql = New SqlBox("CrmProjectMgt@Search")
                            sql.Params("MNGT_NO") = dr("MNGT_NO")
                            sql.Blocks("MNGT_NO") = True
                            dt = db.SqlGet(sql.Text, False)

                            If dt.Rows.Count > 0 Then
                                dr("MNGT_NO") = ""
                                If i = 10 Then Exit Do
                            End If
                        Loop
                    End If


                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmProjectMgt@Insert")
                        Case "U"
                            sql = New SqlBox("CrmProjectMgt@Update")
                        Case "D"
                            sql = New SqlBox("CrmProjectMgt@Delete")
                    End Select
                    sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID
                    YJQuery.SaveRow(db, sql, dr("_INSFLAG"), dr)
                    db.SqlSet(sql.Text)

                    cnt += 1
                Next

                db.Commit()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet
        End Function


        Private Shared Function SaveTable(ByVal db As DBA, ByVal TableName As String, ByRef dt As DataTable) As Integer
            Dim cnt As Integer = 0
            Dim Sql As SqlBox = Nothing

            Select Case TableName.ToUpper
                Case "CRM_PROJECT_MST"
                    For Each dr As DataRow In dt.Rows
                        Select Case dr("_INSFLAG")
                            Case "I"
                                Sql = New SqlBox("CrmProjectMgt@Insert")
                            Case "U"
                                Sql = New SqlBox("CrmProjectMgt@Update")
                            Case "D"
                                Sql = New SqlBox("CrmProjectMgt@Delete")
                        End Select
                        Sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID
                        YJQuery.SaveRow(db, Sql, dr("_INSFLAG"), dr)
                        db.SqlSet(Sql.Text)

                        cnt += 1
                    Next
            End Select

            Return cnt
        End Function

    End Class
End Namespace
