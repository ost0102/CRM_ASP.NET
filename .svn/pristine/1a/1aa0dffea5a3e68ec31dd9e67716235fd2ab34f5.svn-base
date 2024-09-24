Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz
    Public Class CrmAsPrint
        Public Shared Function Print(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow = Nothing

            Dim sql As SqlBox = Nothing
            Dim dt As DataTable = Nothing
            drHeader = ds.Tables("MAIN").Rows(0)

            Try
                sql = New SqlBox("CrmAsPrint@Print")
                sql.Params("MNGT_NO") = drHeader("S_MNGT_NO").ToString
                dt = db.SqlGet(sql.Text)
                If dt Is Nothing Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                dt.TableName = "MainInfo"
                resultDs.Tables.Add(dt)

                sql = New SqlBox("CodeService@User")
                sql.Params("KEY") = YJIT.SessionInfo.UserID
                sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
                sql.Blocks("VALIDATE") = True
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "UserInfo"
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
    End Class
End Namespace
