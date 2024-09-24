Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common
Imports System.Collections.Generic

Imports System.IO


Namespace YJIT.Biz

    Public Class SysBoardMgt


        Public Shared Function CreateKeyNo(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox
            Dim drHeader As DataRow

            Try
                drHeader = ds.Tables("MAIN").Rows(0)

                'Get WG1 detailed data
                sql = New SqlBox("SysBoardMgt@CreateKey")
                sql.Params("YYMM") = Now.ToString("yyyyMMdd").Substring(2, 4)
                dt = db.SqlGet(sql.Text, False)
                Dim BoardId As String = dt.Rows(0)("BOARD_ID").ToString

                resultSet("BOARD_ID") = BoardId
                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"

                db.Commit()


            Catch ex As Exception
                db.Rollback()
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            Finally
                db.EndTransaction()
            End Try
            Return resultSet

        End Function
        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox
            Dim drHeader As DataRow
            Dim ErrorOccur As Boolean = True

            drHeader = ds.Tables("MAIN").Rows(0)
            ' ==============BEGIN UPDATE========================
            Try


                db.BeginTransaction()

                If drHeader("INS_FLAG").ToString = "I" Then
                    sql = New SqlBox("SysBoardMgt@Insert")
                Else
                    sql = New SqlBox("SysBoardMgt@Update")
                End If

                sql.Params("BOARD_ID") = drHeader("BOARD_ID").ToString
                sql.Params("TITLE") = drHeader("TITLE").ToString
                sql.Params("BOARD_BODY") = drHeader("CONTENT").ToString
                sql.Params("BOARD_TYPE") = drHeader("BOARD_TYPE").ToString
                sql.Params("STRT_YMD") = drHeader("STRT_YMD").ToString
                sql.Params("EXP_YMD") = drHeader("EXP_YMD").ToString
                sql.Params("LINK_URL") = drHeader("LINK_URL").ToString
                sql.Params("NOTICE_YN") = drHeader("NOTICE_YN").ToString
                sql.Params("CS_NOTICE_YN") = drHeader("CS_NOTICE_YN").ToString
                sql.Params("EVB_NOTICE_YN") = drHeader("EVB_NOTICE_YN").ToString
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)

                sql = New SqlBox("SysBoardMgt@UpdateContent")
                sql.AllowSqlInjection = True
                sql.Params("BOARD_ID") = drHeader("BOARD_ID").ToString
                Dim sContent As String = String.Empty
                For i = 1 To drHeader("CONTENT").ToString.Count
                    If Not String.IsNullOrEmpty(sContent) Then sContent &= "||"
                    sContent &= "TO_CLOB('" & Mid(drHeader("CONTENT").ToString, i, 3000) & "')"
                    i += (3000 - 1) 'FOR문으로 1이 더 증가됨
                Next
                sql.Params("CONTENT") = sContent
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)


                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"

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

            Return resultSet

        End Function

        Public Shared Function Search(ByVal BoardId As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try


                Dim sql = New SqlBox("SysBoardMgt@Search")
                sql.Params("BOARD_ID") = BoardId
                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                dt.TableName = "Main"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function Delete(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = True
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Try
                db.BeginTransaction()
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                'Delete Main data
                sql = New SqlBox("SysBoardMgt@Delete")
                sql.Params("BOARD_ID") = drHeader("BOARD_ID").ToString
                db.SqlSet(sql.Text)

                'Image file delete
                Dim DirectoryName As String = HttpContext.Current.Server.MapPath("Notice\Data\Notice_" & drHeader("BOARD_ID").ToString & "_files")
                If System.IO.Directory.Exists(DirectoryName) Then
                    Dim picList As String() = System.IO.Directory.GetFiles(DirectoryName, "*.*")
                    For Each f As String In picList
                        System.IO.File.Delete(f)
                    Next
                    System.IO.Directory.Delete(DirectoryName)
                End If

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
            Return ResultSet
        End Function

    End Class
End Namespace
