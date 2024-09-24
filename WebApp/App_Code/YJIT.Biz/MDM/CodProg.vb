Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic

Namespace YJIT.Biz

    Public Class CodProg

        Public Shared Function Search(ByVal sys_id As String, ByVal Pgm_Grp As String, ByVal Pgm_id As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()

            resultSet("TrxCode") = "ERROR"
            resultSet("TrxMsg") = "Page main data is missing!"

            Try
                Dim sql As SqlBox
                sql = New SqlBox("CodProg@SEARCH")
                sql.Params("SYS_ID") = sys_id.Trim
                sql.Params("PGM_GRP") = Pgm_Grp.Trim
                sql.Params("PGM_ID") = Pgm_id.Trim

                If Pgm_Grp.Trim <> "" Then
                    sql.Blocks("PGM_GRP") = True
                End If

                If Pgm_id.Trim <> "" Then
                    sql.Blocks("PGM_ID") = True
                End If

                Dim dt As DataTable
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                resDs.Tables.Add(dt)

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "NODATA"
                    resultSet("TrxMsg") = "Data not found!"
                Else
                    resultSet("TrxCode") = "SUCCESS"
                    resultSet("TrxMsg") = "Operation completed successful!"
                End If

            Catch ex As Exception
                Throw ex
            End Try

            resultSet("Data") = resDs

            Return resultSet
        End Function
        Public Shared Function GetGrpId(ByVal sys_id As String, ByVal pgm_id As String, ByVal func_id As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()

            resultSet("TrxCode") = "ERROR"
            resultSet("TrxMsg") = "Page main data is missing!"

            Try
                Dim sql As SqlBox
                sql = New SqlBox("CodProg@GET_GRP_ID")
                sql.Params("SYS_ID") = sys_id.Trim
                sql.Params("PGM_ID") = pgm_id.Trim
                sql.Params("FUNC_ID") = func_id.Trim
                Dim dt As DataTable
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    resultSet("GRP_ID") = "NODATA"
                Else
                    resultSet("GRP_ID") = dt.Rows(0)("PGM_GRP")
                End If

                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"
            Catch ex As Exception
                Throw ex
            End Try

            Return resultSet
        End Function


        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim dt As DataTable
            Dim dt1 As DataTable
            Dim sql As SqlBox
            Dim updCount As Integer = 0
            Dim PgmId As String = ""
            Dim PgmGrp As String = ""


            '페이지 필수 자료 검토
            Try
                drHeader = ds.Tables("MAIN").Rows(0)
            Catch ex As Exception
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Page main data is missing!"
                Return resultSet
            End Try

            dt1 = ds.Tables("WG1")
            PgmId = drHeader("S_PGM_ID").ToString
            PgmGrp = drHeader("S_PGM_GRP").ToString

            Try
                db.BeginTransaction()
                For Each dr As DataRow In dt1.Rows
                    '====Check realtime existance
                    Dim isExisted As Boolean = False
                    sql = New SqlBox("CodProg@CHK")
                    sql.Params("SYS_ID") = drHeader("S_SYS_ID").Trim
                    sql.Params("PGM_ID") = dr("PGM_ID").Trim
                    sql.Params("FUNC_ID") = dr("FUNC_ID").Trim

                    dt = db.SqlGet(sql.Text, False)
                    If dt.Rows.Count > 0 Then isExisted = True

                    Select Case dr("_INSFLAG")
                        Case "I", "U"
                            If Not isExisted Then
                                sql = New SqlBox("CodProg@INS")                        'Insert
                                sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                            Else
                                sql = New SqlBox("CodProg@UPD")
                                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID         'Update
                            End If
                        Case "D"
                            sql = New SqlBox("CodProg@DEL")                          'Delete
                        Case Else
                            Continue For
                    End Select

                    sql.Params("SYS_ID") = drHeader("S_SYS_ID").Trim
                    sql.Params("PGM_ID") = dr("PGM_ID").Trim
                    sql.Params("FUNC_ID") = dr("FUNC_ID").Trim
                    sql.Params("PGM_NM") = dr("PGM_NM").Trim
                    sql.Params("PGM_TYPE") = dr("PGM_TYPE").Trim
                    sql.Params("PGM_GRP") = dr("PGM_GRP").Trim
                    sql.Params("DLL_NAME") = dr("DLL_NAME").ToString.Trim
                    updCount += db.SqlSet(sql.Text)
                Next
                db.Commit()
            Catch ex As Exception
                db.Rollback()
                Throw ex
            Finally
                db.EndTransaction()
            End Try

            '===Inform successful save==='
            resultSet("TrxCode") = "SUCCESS"
            resultSet("TrxMsg") = "Save done!" & updCount & " row(s) updated!"
            '===Refresh list==="
            resultSet("SearchResult") = Search(drHeader("S_SYS_ID"), PgmGrp, PgmId)

            Return resultSet
        End Function
    End Class
End Namespace
