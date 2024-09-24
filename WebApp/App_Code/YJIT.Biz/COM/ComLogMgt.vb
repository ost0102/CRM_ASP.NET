Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Exception
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.Biz.Common

Namespace YJIT.Biz

    Public Class ComLogMgt

        Public Shared Function Search(ByVal HBL_NO As String, ByVal S_COL_NM As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("ComLogMgt@Search")

                sql.Params("HBL_NO") = HBL_NO

                If S_COL_NM.ToString.Trim <> "" Then
                    sql.AllowSqlInjection = True
                    sql.Params("COL_NM") = S_COL_NM.Replace(";", "','").Replace(" ", "")
                    sql.Blocks("COL_NM") = True
                    sql.AllowSqlInjection = False
                End If

                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                dt.TableName = "WG1"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

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

        Public Shared Function SearchDetail(ByVal HBL_NO As String, ByVal CHANGE_USR As String, ByVal CHANGE_DATE As String, ByVal S_COL_NM As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("ComLogMgt@SearchDetail")
                sql.Params("HBL_NO") = HBL_NO
                sql.Params("CHANGE_USR") = CHANGE_USR
                sql.Params("CHANGE_DATE") = CHANGE_DATE

                If S_COL_NM.ToString.Trim <> "" Then
                    sql.AllowSqlInjection = True
                    sql.Params("COL_NM") = S_COL_NM.Replace(";", "','").Replace(" ", "")
                    sql.Blocks("COL_NM") = True
                    sql.AllowSqlInjection = False
                End If

                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                dt.TableName = "WG2"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

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

        Public Shared Function SearchColumn(ByVal HBL_NO As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("ComLogMgt@SearchColumn")

                sql.Params("HBL_NO") = HBL_NO

                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                dt.TableName = "S_COLUMN"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

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

        Public Shared Function FieldComments(ByVal FIELD_NM As String) As Dictionary(Of String, Object)
            Dim Session As HttpSessionState = HttpContext.Current.Session       ' 세션 정보
            Dim ssUSR_ID As String = YJIT.SessionInfo.UserID
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = True
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Try
                Dim sql = New SqlBox("ComLogMgt@SearchComment")
                sql.Params("FIELD_NM") = FIELD_NM
                'Search Sql data returned in a DataTable
                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
                resultDs.Tables.Add(dt)


                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
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

    End Class
End Namespace
