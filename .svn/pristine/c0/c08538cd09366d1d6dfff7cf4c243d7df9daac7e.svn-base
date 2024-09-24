Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common
Namespace YJIT.BIZ

    Public Class EVBMgmtHistory
        'Search
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function
        Public Shared Function Reprocess(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim dt As DataTable
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True

            ResultSet("TrxCode") = "E"
            ResultSet("TrxMsg") = "Error"
            ResultSet("Data") = ds

            Try
                db.BeginTransaction()

                '일괄 응답 재처리
                dt = ds.Tables("WG2")
                For Each dr As DataRow In dt.Rows
                    Select Case dr("_INSFLAG").ToString
                        Case "U"
                            sql = New SqlBox("EvbMgmtHistory@UpdateAll")
                            With sql
                                .Params("TAX_DOC_NO") = dr("TAX_DOC_NO").ToString
                            End With
                            db.SqlSet(sql.Text)
                        Case Else
                            Continue For
                    End Select
                Next

                dt = ds.Tables("WG3")
                For Each dr As DataRow In dt.Rows
                    Select Case dr("_INSFLAG").ToString
                        Case "U"
                            sql = New SqlBox("EvbMgmtHistory@Update")
                            With sql
                                .Params("TAX_DOC_NO") = dr("TAX_DOC_NO").ToString
                                .Params("SEQ_NO") = dr("SEQ_NO").ToString
                            End With
                            db.SqlSet(sql.Text)
                        Case Else
                            Continue For
                    End Select
                Next
                db.Commit()
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            End Try

            If ResultSet("TrxCode") = "Y" Then
                ResultSet("Data") = Search(ds)("Data")
            End If

            Return ResultSet
        End Function
    End Class
End Namespace
