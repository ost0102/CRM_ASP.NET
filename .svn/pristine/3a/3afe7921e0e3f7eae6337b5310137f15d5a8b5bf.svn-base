Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz


    Public Class ComDocumentMgt

        Private Declare Ansi Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
                                (ByVal lpApplicationName As String, _
                                 ByVal lpKeyName As String, _
                                 ByVal lpString As String, _
                                 ByVal lpFileName As String) _
                            As Integer

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try

                sql = New SqlBox("ComDocumentMgt@Search")
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                sql.Params("MNGT_NO") = drHeader("S_MNGT_NO").ToString

                If drHeader("S_MNGT_NO").ToString <> "" Then sql.Blocks("MNGT_NO") = True

                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                dt.TableName = "WG2"
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
        Public Shared Function Save(ByVal ds As DataSet, ByVal strUploadPath As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim dt As DataTable
            Dim sql As SqlBox
            Dim filename As String = ""
            Dim UploadPath As String = ""
            Dim ErrorOccur As Boolean = True
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                If String.IsNullOrEmpty(drHeader("S_MNGT_NO").ToString) Then
                    ThrowMsg(ErrorOccur, "[Reference No] Data info missing.")
                End If

                dt = ds.Tables("WG2")
                Dim firstSeqNumber As Integer = SearchSeq(drHeader("S_MNGT_NO").ToString())


                Dim saveDatetime As String = Now.ToString("yyyy-MM-dd HH:mm:ss.fff") & "    " & drHeader("S_MNGT_NO").ToString & "    "

                WritePrivateProfileString("ComDocumentMgt", saveDatetime & "    " & "1                ", "", HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))

                For Each dr As DataRow In dt.Rows

                    If dr("SUCCESS").ToString() = "N" Then
                        dr("_INSFLAG") = "D"
                    End If

                    Dim intSeq As Integer

                    If (dr("SEQ") Is DBNull.Value) Then
                        intSeq = firstSeqNumber
                        firstSeqNumber += 1

                        WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Seq              ", "New", HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                    Else
                        intSeq = Integer.Parse(dr("SEQ"))

                        WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Seq              ", "Old", HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                    End If


                    WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Seq              ", dr("MNGT_NO") & " / " & dr("SEQ") & " / " & dr("FILE_PATH"), HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))

                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("ComDocumentMgt@Insert")
                            sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                            sql.Params("RMK") = dr("RMK").ToString()
                            UploadPath = strUploadPath & dr("MNGT_NO") & "/"

                            WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Insert                ", UploadPath, HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                        Case "U"
                            sql = New SqlBox("ComDocumentMgt@Update")
                            sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                            sql.Params("RMK") = dr("RMK").ToString()
                            UploadPath = strUploadPath & dr("MNGT_NO") & "/"
                            filename = dr("MNGT_NO").ToString & "_" & dr("SEQ") & "_" & SearchFileName(drHeader("S_MNGT_NO").ToString, intSeq)

                            WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Update                ", UploadPath, HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                        Case "D"
                            sql = New SqlBox("ComDocumentMgt@Delete")
                            UploadPath = strUploadPath & dr("MNGT_NO") & "/"
                            filename = drHeader("S_MNGT_NO").ToString & "_" & dr("SEQ") & "_" & dr("FILE_NM").ToString

                            WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Delete                ", UploadPath, HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                        Case Else
                            Continue For
                    End Select

                    sql.Params("FILE_PATH") = UploadPath
                    sql.Params("MNGT_NO") = drHeader("S_MNGT_NO").ToString()
                    sql.Params("SEQ") = intSeq.ToString
                    sql.Params("FILE_NM") = dr("FILE_NM").ToString()

                    If dr.Table.Columns.Contains("FILE_SIZE") = True Then
                        If Not String.IsNullOrEmpty(dr("FILE_SIZE").ToString) Then
                            sql.Blocks("FILE_SIZE") = True
                            sql.Params("FILE_SIZE") = dr("FILE_SIZE").ToString
                        End If
                    End If
                    
                    If dr.Table.Columns.Contains("DOC_TYPE") = True Then
                        If Not String.IsNullOrEmpty(dr("DOC_TYPE").ToString) Then
                            sql.Params("DOC_TYPE") = dr("DOC_TYPE").ToString()
                            sql.Blocks("DOC_TYPE") = True
                        End If
                    End If

                    sql.Params("SCREEN") = drHeader("SCREEN").ToString()
                    db.SqlSet(sql.Text)

                    If dr("_INSFLAG").ToString = "D" _
                            Or (dr("_INSFLAG").ToString = "U" And (dr("FILE_PATH").ToString <> UploadPath Or dr("FILE_NM").ToString() = "")) Then

                        WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Delte File Path        ", HttpContext.Current.Server.MapPath(UploadPath) + filename, HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                        WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Delete File            ", System.IO.File.Exists(HttpContext.Current.Server.MapPath(UploadPath) + filename), HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                        If System.IO.File.Exists(HttpContext.Current.Server.MapPath(UploadPath) + filename) Then
                            System.IO.File.Delete(HttpContext.Current.Server.MapPath(UploadPath) & filename)
                            WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Delete File Complete    ", "", HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                        End If
                        'Copy folder

                        Dim copyFolder As String = "\WCF\UploadFiles\" & SessionInfo.UserID.ToString & "\"


                        WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Move File Path        ", HttpContext.Current.Server.MapPath(copyFolder) + filename, HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                        WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Move File             ", System.IO.File.Exists(HttpContext.Current.Server.MapPath(copyFolder) + filename), HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                        If System.IO.File.Exists(HttpContext.Current.Server.MapPath(copyFolder) + filename) Then
                            System.IO.File.Delete(HttpContext.Current.Server.MapPath(copyFolder) + filename)
                            WritePrivateProfileString("ComDocumentMgt", saveDatetime & intSeq & "    " & "Move File Complete    ", "", HttpContext.Current.Server.MapPath("CrmDocumentLog.txt"))
                        End If
                    End If

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
        Public Shared Function GetSequence(ByVal ds As DataSet, ByVal MNGT_NO As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim dt As New DataTable
            Dim ErrorOccur As Boolean = True
            Try
                dt.Columns.Add("SEQ")
                dt.Rows.Add(SearchSeq(MNGT_NO))
                dt.TableName = "Main"
                retDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = retDs

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
        Public Shared Function Delete(ByVal MNGT_NO As String, ByVal SEQ As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox
            Dim filename As String = ""
            Dim UploadPath As String = ""
            Dim ErrorOccur As Boolean = True
            Try
                db.BeginTransaction()

                sql = New SqlBox("ComDocumentMgt@Delete")
                sql.Params("MNGT_NO") = MNGT_NO
                sql.Params("SEQ") = SEQ
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

            Return resultSet
        End Function
        Public Shared Function Copy(ByVal filepath As String, ByVal filename As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim copyFolder As String = "\WCF\UploadFiles\" & SessionInfo.UserID.ToString & "\"
            Try
                copyFolder = HttpContext.Current.Server.MapPath(copyFolder)
                If System.IO.Directory.Exists(copyFolder) Then
                    For Each fname In IO.Directory.GetFiles(copyFolder)
                        System.IO.File.Delete(Path.Combine(copyFolder, fname))
                    Next
                Else
                    System.IO.Directory.CreateDirectory(copyFolder)
                End If

                If System.IO.File.Exists(HttpContext.Current.Server.MapPath(filepath & filename)) Then
                    System.IO.File.Copy(HttpContext.Current.Server.MapPath(filepath & filename), copyFolder & filename)
                    resultSet("TrxCode") = "Y"
                    resultSet("TrxMsg") = "File is copied"
                Else
                    resultSet("TrxCode") = "N"
                    resultSet("TrxMsg") = "Source file not found"
                End If
            Catch ex As Exception
                resultSet("TrxCode") = "E"
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function
        Public Shared Function SearchSeq(ByVal MNGT_NO As String) As Integer
            Dim intSeq As Integer = 0
            Try
                Dim db As DBA = New DBA()
                Dim strSql As String = "SELECT NVL(MAX(SEQ),0) + 1 AS SEQ FROM COM_DOC_MST WHERE MNGT_NO = '" & MNGT_NO & "'"
                Dim dt As DataTable = db.SqlGet(strSql, False)
                If dt.Rows.Count > 0 Then
                    intSeq = Integer.Parse(dt.Rows(0).Item("SEQ"))
                End If
            Catch ex As Exception
            End Try
            Return intSeq
        End Function
        Public Shared Function SearchFileName(ByVal MNGT_NO As String, ByVal SEQ As Integer) As String
            Dim strFileName As String = ""
            Try
                Dim db As DBA = New DBA()
                Dim strSql As String = "SELECT FILE_NM FROM COM_DOC_MST WHERE MNGT_NO = '" & MNGT_NO & "' AND SEQ = '" & SEQ.ToString & "'"
                Dim dt As DataTable = db.SqlGet(strSql, False)
                If dt.Rows.Count > 0 Then
                    strFileName = dt.Rows(0).Item("FILE_NM").ToString
                End If
            Catch ex As Exception
            End Try
            Return strFileName
        End Function

    End Class
End Namespace
