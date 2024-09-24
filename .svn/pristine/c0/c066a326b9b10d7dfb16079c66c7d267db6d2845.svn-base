Imports System.Data
Imports YJIT.Data
Imports YJIT.BIZ.Common

Namespace YJIT.BIZ
    Public Class YjediSpecDetailMgt
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.SearchYjedi(ds)
        End Function
        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim connectionstring As String =
                    "data source=" &
                        "(description=(cid=gtu_app)" &
                            "(address_list=" &
                                    "(address=" &
                                            "(protocol=tcp)(host=175.45.195.63)(port=1521)" &
                                    ")" &
                            ")(connect_data=(service_name=friendDB)(server=dedicated))" &
                        ");User Id=YJEDI_ESVC;Password=YjEDI#!&%1113;"
            Dim db As DBA = New DBA(connectionstring, "ORACLE")
            Dim drHeader As DataRow
            Dim dt As DataTable
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True

            resultSet("TrxCode") = "E"
            resultSet("TrxMsg") = "Error"
            resultSet("Data") = Nothing

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                dt = ds.Tables("WG1")
                For Each dr As DataRow In dt.Rows
                    Select Case dr("_INSFLAG")
                        Case "I", "U"
                            sql = New SqlBox("YjediSpecDetailMgt@Save")
                        Case "D"
                            sql = New SqlBox("YjediSpecDetailMgt@Delete")
                    End Select

                    sql.Params("USR_ID") = SessionInfo.UserID

                    YJQuery.SaveRow(db, sql, dr("_INSFLAG").ToString, dr)
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