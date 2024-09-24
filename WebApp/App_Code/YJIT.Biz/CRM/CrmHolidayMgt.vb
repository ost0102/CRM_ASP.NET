Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common
Namespace YJIT.BIZ

    Public Class CrmHolidayMgt
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
                        Case "I"

                            '중복체크
                            sql = New SqlBox("CrmHolidayMgt@Search")
                            sql.Params("HD_YMD") = dr("HD_YMD").ToString
                            sql.Blocks("HD_YMD") = True
                            Dim dt As DataTable = db.SqlGet(sql.Text, False)
                            If dt.Rows.Count > 0 Then
                                ThrowMsg(ErrorOccur, "이미 등록된 휴일일자가 존재합니다!" & vbNewLine & "휴일일자: " & Mid(dr("HD_YMD").ToString, 1, 4) & "-" & Mid(dr("HD_YMD").ToString, 5, 2) & "-" & Mid(dr("HD_YMD").ToString, 7, 2))
                            End If

                            sql = New SqlBox("CrmHolidayMgt@Insert")
                        Case "U"
                            sql = New SqlBox("CrmHolidayMgt@Update")
                        Case "D"
                            sql = New SqlBox("CrmHolidayMgt@Delete")
                        Case Else
                            Continue For
                    End Select
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    YJQuery.SaveRow(db, sql, dr("_INSFLAG"), dr)

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
