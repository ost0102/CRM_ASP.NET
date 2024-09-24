Imports Microsoft.VisualBasic
Imports YJIT.Data
Imports System.Data
Imports System.IO

Namespace YJIT.Biz
    Public Class ComExcelMgt
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
            Dim retCount As Integer = 0

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                Dim sBatchID As String = String.Format("{0}{1}{2}", Format(Now, "yyyyMMddHHmmss"), Now.Millisecond, CInt(Int((99 * Rnd()) + 1)).ToString.PadLeft(3, "0")) 'BATCH_ID
                Dim iSeq As Integer = 1
                For Each dr As DataRow In ds.Tables("WG2").Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            Dim MngtNo As String = String.Empty
                            Dim i As Integer = 1
                            Do While MngtNo = String.Empty
                                MngtNo = String.Format("{0}{1}{2}", Format(Now, "yyyyMMddHHmmss"), Now.Millisecond, iSeq.ToString.PadLeft(3, "0"))
                                '중복체크
                                sql = New SqlBox("ComExcelMgt@SearchCheck")
                                sql.Params("MNGT_NO") = MngtNo
                                sql.Blocks("MNGT_NO") = True
                                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                                If dt.Rows.Count > 0 Then
                                    MngtNo = ""
                                    i += 1
                                    If i = 50 Then Exit Do
                                End If
                            Loop
                            dr("MNGT_NO") = MngtNo

                            sql = New SqlBox("ComExcelMgt@Insert")
                        Case "U"
                            sql = New SqlBox("ComExcelMgt@Update")
                        Case "D"
                            sql = New SqlBox("ComExcelMgt@Delete")
                        Case Else
                            Continue For
                    End Select

                    sql.Params("SYS_ID") = "CRM"
                    sql.Params("WORK_USR") = YJIT.SessionInfo.LocalName
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    sql.Params("BATCH_ID") = sBatchID
                    YJQuery.SaveRow(db, sql, dr("_INSFLAG"), dr)

                    retCount = db.SqlSet(sql.Text)

                    iSeq += 1
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
                resultSet("Data") = ds.Tables("WG2").Copy
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

                sql = New SqlBox("ComExcelMsg@Delete")
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

