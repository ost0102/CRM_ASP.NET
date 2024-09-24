
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Exception
Imports System.Collections.Generic

Imports YJIT.Data
Imports System.Windows.Forms
Imports System.IO

Namespace YJIT.Biz

    Public Class EMAIL

        Public Shared Sub ChkColumn(ByVal ds As DataSet, ByRef ResultMsg As String, ByVal ColumnNames() As String)

            For Each ColumnName In ColumnNames
                If Not ds.Tables("MAIN").Columns.Contains(ColumnName) Then
                    ResultMsg &= ColumnName & ","
                End If
            Next

        End Sub
        Public Shared Function SendEmail(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim resultMsg As String = ""
            Dim FileDt As DataTable
            Dim filePath As String = HttpContext.Current.Server.MapPath("/EMAIL/SEND/")
            Dim ErrorOccur As Boolean = False 
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    Throw New Exception("Data Table Missing. (MAIN)")
                End If
                ChkColumn(ds, resultMsg, New String() {"SENDER", "RECEIVER", "SUBJECT", "CONTENT", "CC"})
                If resultMsg <> "" Then
                    resultMsg = resultMsg.Substring(0, resultMsg.Length - 1)
                    Throw New Exception("Data Columns Missing. (" & resultMsg & ")")
                End If 
                drHeader = ds.Tables("MAIN").Rows(0) 
                FileDt = ds.Tables("FILEDT")
                If Not FileDt Is Nothing Then
                    If FileDt.Columns.Contains("_InsFlag") Then
                        For i = FileDt.Rows.Count - 1 To 0 Step -1
                            If FileDt.Rows(i)("_InsFlag") = "D" Then
                                FileDt.Rows.RemoveAt(i)
                            End If
                        Next
                    End If
                End If

                If YJIT.SessionOfficeInfo.HqOfficeCode = "ENCHQ" AndAlso YJIT.SessionOfficeInfo.CountryCode = "US" Then
                    YJIT.Biz.MailDemon.sendEmail2(drHeader("SENDER").ToString, drHeader("RECEIVER"), drHeader("CC"), drHeader("SUBJECT").ToString, drHeader("CONTENT").ToString)

                Else
                    resultMsg = YJIT.Biz.MailDemon.sendEmail(drHeader("SENDER").ToString, drHeader("RECEIVER"), drHeader("CC"), _
                                                  drHeader("SUBJECT").ToString, drHeader("CONTENT").ToString, FileDt)
                End If
                
                
                If resultMsg <> "" Then 
                    Throw New Exception(resultMsg)
                End If
                ' 파일 삭제
                If Not FileDt Is Nothing Then
                    For Each FileDetail As DataRow In FileDt.Rows
                        Dim filename As String = FileDetail("NAME").ToString
                        filename = filePath & filename
                        File.Delete(filename)
                    Next
                End If 
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Sent E-mail"
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            End Try 
            Return resultSet
        End Function
    End Class
End Namespace
