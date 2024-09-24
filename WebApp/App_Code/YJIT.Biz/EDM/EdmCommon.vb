Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class EdmCommon
        Public Shared Function SearchTimestamp(ByVal EmptyData As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try
                sql = New SqlBox("EdmCommon@SearchTimestamp")

                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                dt.TableName = "SearchTimestamp"
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





        'IIS 셋팅후 가상폴더 생성해야함
        Public Shared Function Copy(ByVal filepath As String, ByVal filename As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim copyFolder As String = "\WCF\UploadFiles\" & SessionInfo.UserID.ToString & "\"

            Try
                copyFolder = HttpContext.Current.Server.MapPath(copyFolder)

                If System.IO.Directory.Exists(copyFolder) Then
                    For Each fname In IO.Directory.GetFiles(copyFolder)
                        Dim tempFile As IO.FileInfo = New System.IO.FileInfo(fname)
                        Select Case tempFile.Extension.ToString.ToUpper
                            Case ".TIF", ".TIFF"
                                System.IO.File.Delete(Path.Combine(fname))
                        End Select
                    Next
                Else
                    System.IO.Directory.CreateDirectory(copyFolder)
                End If

                If Not filepath.StartsWith("/EDM") Then filepath = "/EDM" & filepath

                Dim FileFullName As String = filepath & "/" & filename
                If System.IO.File.Exists(HttpContext.Current.Server.MapPath(FileFullName)) Then
                    System.IO.File.Copy(HttpContext.Current.Server.MapPath(FileFullName), copyFolder & filename)
                    resultSet("TrxCode") = "Y"
                    resultSet("TrxMsg") = "File is copied"
                Else
                    resultSet("TrxCode") = "N"
                    resultSet("TrxMsg") = "Source file not found" & vbCrLf & HttpContext.Current.Server.MapPath(FileFullName).ToString
                End If
            Catch ex As Exception
                resultSet("TrxCode") = "E"
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function


    End Class
End Namespace
