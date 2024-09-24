Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class EdmMainMgt
        Public Shared Function SearchRefresh(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("EdmMainMgt@SearchRefresh")

                sql.Params("EDM_TEAM") = drHeader("EDM_TEAM").ToString

                If drHeader("EDM_TPIC").ToString <> "" Then
                    sql.Params("EDM_TPIC") = drHeader("EDM_TPIC").ToString
                    sql.Blocks("EDM_TPIC") = True
                End If


                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                dt.TableName = "WG_STANDBY"
                ResultDs.Tables.Add(dt)
                ResultSet("TrxCode") = "Y"

                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception

                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function

        Public Shared Function SaveStandby(ByVal RCVD_DTTM As String _
                                        , ByVal RCVD_FILENAME As String _
                                        , ByVal RCVD_PATH As String _
                                        , ByVal RCVD_FAXNO As String _
                                        , ByVal EDM_NAME As String _
                                        , ByVal EDM_RMK As String _
                                        , ByVal EDM_TPIC As String _
                                        , ByVal USR_ID As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True

            Dim dtEDM As DataTable = New DataTable
            Dim drEDM As DataRow = dtEDM.NewRow
            drEDM.Table.Columns.Add("RCVD_DTTM", GetType(String))
            drEDM.Table.Columns.Add("RCVD_PATH", GetType(String))
            drEDM.Table.Columns.Add("RCVD_SENDER", GetType(String))
            drEDM.Table.Columns.Add("STATUS", GetType(String))
            drEDM.Table.Columns.Add("EDM_CLS", GetType(String))
            drEDM.Table.Columns.Add("EDM_TYP", GetType(String))
            drEDM.Table.Columns.Add("EDM_NO", GetType(String))
            drEDM.Table.Columns.Add("EDM_SEQ", GetType(String))
            drEDM.Table.Columns.Add("EDM_TEAM", GetType(String))

            Try

                If String.IsNullOrEmpty(RCVD_FILENAME) Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If



                sql = New SqlBox("EdmMainMgt@Search")

                sql.Params("RCVD_DTTM") = RCVD_DTTM.ToString
                sql.Params("RCVD_FILENAME") = RCVD_FILENAME.ToString

                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    drEDM("RCVD_PATH") = Now.ToString("-yyyy-MM-dd").Replace("-", "/")
                    drEDM("RCVD_SENDER") = USR_ID
                    drEDM("STATUS") = "1"
                    drEDM("EDM_CLS") = ""
                    drEDM("EDM_TYP") = ""
                    drEDM("EDM_NO") = ""
                    drEDM("EDM_SEQ") = ""
                    drEDM("EDM_TEAM") = ""

                    drEDM("RCVD_DTTM") = RCVD_DTTM
                Else
                    drEDM("RCVD_PATH") = dt.Rows(0)("RCVD_PATH").ToString
                    drEDM("RCVD_SENDER") = dt.Rows(0)("RCVD_SENDER").ToString
                    drEDM("STATUS") = dt.Rows(0)("STATUS").ToString
                    drEDM("EDM_CLS") = dt.Rows(0)("EDM_CLS").ToString
                    drEDM("EDM_TYP") = dt.Rows(0)("EDM_TYP").ToString
                    drEDM("EDM_NO") = dt.Rows(0)("EDM_NO").ToString
                    drEDM("EDM_SEQ") = dt.Rows(0)("EDM_SEQ").ToString
                    drEDM("EDM_TEAM") = dt.Rows(0)("EDM_TEAM").ToString

                    drEDM("RCVD_DTTM") = dt.Rows(0)("RCVD_DTTM").ToString
                End If


                '## 중복 체크 
                Do While True
                    sql = New SqlBox("EdmMainMgt@Search")

                    sql.Params("RCVD_DTTM") = drEDM("RCVD_DTTM")
                    sql.Params("RCVD_FILENAME") = RCVD_FILENAME.ToString

                    dt = db.SqlGet(sql.Text, False)

                    If dt.Rows.Count = 0 Then
                        Exit Do
                    Else
                        drEDM("RCVD_DTTM") = dt.Rows(0)("RCVD_DTTM").ToString
                    End If
                Loop



                sql = New SqlBox("EdmMainMgt@InsertStandby")

                sql.Params("RCVD_DTTM") = RCVD_DTTM.ToString
                sql.Params("RCVD_FILENAME") = RCVD_FILENAME.ToString
                sql.Params("RCVD_PATH") = RCVD_PATH.ToString
                sql.Params("RCVD_FAXNO") = RCVD_FAXNO.ToString
                sql.Params("RCVD_SENDER") = drEDM("RCVD_SENDER").ToString
                sql.Params("STATUS") = drEDM("STATUS").ToString
                sql.Params("EDM_NAME") = EDM_NAME.ToString
                sql.Params("EDM_CLS") = drEDM("EDM_CLS").ToString
                sql.Params("EDM_TYP") = drEDM("EDM_TYP").ToString
                sql.Params("EDM_NO") = drEDM("EDM_NO").ToString
                sql.Params("EDM_SEQ") = drEDM("EDM_SEQ").ToString
                sql.Params("EDM_RMK") = EDM_RMK.ToString
                sql.Params("EDM_TEAM") = drEDM("EDM_TEAM").ToString
                sql.Params("EDM_TPIC") = EDM_TPIC.ToString
                sql.Params("USR_ID") = USR_ID.ToString

                db.SqlSet(sql.Text)

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception

                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function

        Public Shared Function SaveDocument(ByVal RCVD_DTTM As String _
                                        , ByVal RCVD_FILENAME As String _
                                        , ByVal RCVD_PATH As String _
                                        , ByVal RCVD_FAXNO As String _
                                        , ByVal RCVD_SENDER As String _
                                        , ByVal STATUS As String _
                                        , ByVal EDM_NAME As String _
                                        , ByVal EDM_CLS As String _
                                        , ByVal EDM_TYP As String _
                                        , ByVal EDM_NO As String _
                                        , ByVal EDM_SEQ As String _
                                        , ByVal EDM_RMK As String _
                                        , ByVal EDM_TEAM As String _
                                        , ByVal EDM_TPIC As String _
                                        , ByVal USR_ID As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True

            Try

                If String.IsNullOrEmpty(RCVD_FILENAME) Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                '## 중복 체크 
                Do While True
                    sql = New SqlBox("EdmMainMgt@Search")

                    sql.Params("RCVD_DTTM") = RCVD_DTTM.ToString
                    sql.Params("RCVD_FILENAME") = RCVD_FILENAME.ToString

                    dt = db.SqlGet(sql.Text, False)

                    If dt.Rows.Count = 0 Then
                        Exit Do
                    Else
                        Throw New Exception("Document Number error, please try save again")
                    End If
                Loop



                sql = New SqlBox("EdmMainMgt@InsertStandby")

                sql.Params("RCVD_DTTM") = RCVD_DTTM.ToString
                sql.Params("RCVD_FILENAME") = RCVD_FILENAME.ToString
                sql.Params("RCVD_PATH") = RCVD_PATH.ToString
                sql.Params("RCVD_FAXNO") = RCVD_FAXNO.ToString
                sql.Params("RCVD_SENDER") = RCVD_SENDER.ToString
                sql.Params("STATUS") = STATUS.ToString
                sql.Params("EDM_NAME") = EDM_NAME.ToString
                sql.Params("EDM_CLS") = EDM_CLS.ToString
                sql.Params("EDM_TYP") = EDM_TYP.ToString
                sql.Params("EDM_NO") = EDM_NO.ToString
                sql.Params("EDM_SEQ") = EDM_SEQ.ToString
                sql.Params("EDM_RMK") = EDM_RMK.ToString
                sql.Params("EDM_TEAM") = EDM_TEAM.ToString
                sql.Params("EDM_TPIC") = EDM_TPIC.ToString
                sql.Params("USR_ID") = USR_ID.ToString

                db.SqlSet(sql.Text)

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception

                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function

        Public Shared Function DeleteStandbyMerge(ByVal RCVD_DTTM As String _
                                         , ByVal RCVD_FILENAME As String _
                                         , ByVal USR_ID As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If String.IsNullOrEmpty(RCVD_FILENAME) Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                sql = New SqlBox("EdmMainMgt@DeleteStandbyMerge")

                sql.Params("RCVD_DTTM") = RCVD_DTTM.ToString
                sql.Params("RCVD_FILENAME") = RCVD_FILENAME.ToString
                sql.Params("USR_ID") = USR_ID.ToString

                db.SqlSet(sql.Text)

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception

                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function

        Public Shared Function DeleteStandby(ByVal RCVD_DTTM As String _
                                         , ByVal RCVD_FILENAME As String _
                                         , ByVal USR_ID As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                If String.IsNullOrEmpty(RCVD_FILENAME) Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                sql = New SqlBox("EdmMainMgt@DeleteStandby")

                sql.Params("RCVD_DTTM") = RCVD_DTTM.ToString
                sql.Params("RCVD_FILENAME") = RCVD_FILENAME.ToString
                sql.Params("USR_ID") = USR_ID.ToString

                db.SqlSet(sql.Text)

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception

                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function

    End Class
End Namespace
