Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class CrmManualMgt
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function

        Public Shared Function Save(ByVal ds As DataSet, ByVal strUploadPath As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow = Nothing
            Dim insflag As String = String.Empty
            Dim filename As String = String.Empty
            Dim UploadPath As String = String.Empty
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                If String.IsNullOrEmpty(drHeader("MNGT_NO").ToString) Then
                    Dim paramKeyNo As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                    ' Reference Group No 생성
                    Dim groupNo As String = Nothing
                    Dim yyyyMMdd As String = Now.ToString("yyyyMMdd")
                    paramKeyNo = GenerationKeyNo("MNGT_NO", "", "", yyyyMMdd, "YJIT", "M", "")
                    If ("" & paramKeyNo("TrxCode").ToString) = "E" Then
                        ThrowMsg(ErrorOccur, "Error while Key No Create Processing! Error Msg: " & paramKeyNo("TrxMsg").ToString)
                    Else
                        drHeader("MNGT_NO") = paramKeyNo("KEY_NO").ToString
                    End If
                    insflag = "I"
                Else
                    insflag = "U"
                End If

                sql = New SqlBox("CrmManualMgt@Save")
                YJQuery.SaveRow(db, sql, insflag, drHeader)
                sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)





                Dim dt As DataTable = ds.Tables("WG2")
                Dim firstSeqNumber As Integer = ComDocumentMgt.SearchSeq(drHeader("MNGT_NO").ToString)

                For Each dr As DataRow In dt.Rows
                    If dr("SUCCESS").ToString() = "N" Then
                        dr("_INSFLAG") = "D"
                    End If
                    Dim intSeq As Integer
                    If (dr("SEQ") Is DBNull.Value) Then
                        intSeq = firstSeqNumber
                        firstSeqNumber += 1
                    Else
                        intSeq = Integer.Parse(dr("SEQ"))
                    End If
                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("ComDocumentMgt@Insert")
                            sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                            sql.Params("RMK") = dr("RMK").ToString()
                            UploadPath = strUploadPath & drHeader("MNGT_NO").ToString & "/"
                        Case "U"
                            sql = New SqlBox("ComDocumentMgt@Update")
                            sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                            sql.Params("RMK") = dr("RMK").ToString()
                            UploadPath = strUploadPath & drHeader("MNGT_NO").ToString & "/"
                            filename = drHeader("MNGT_NO").ToString & "_" & dr("SEQ") & "_" & SearchFileName(drHeader("MNGT_NO").ToString, intSeq)
                        Case "D"
                            sql = New SqlBox("ComDocumentMgt@Delete")
                            UploadPath = strUploadPath & drHeader("MNGT_NO").ToString & "/"
                            filename = drHeader("MNGT_NO").ToString & "_" & dr("SEQ") & "_" & dr("FILE_NM").ToString
                        Case Else
                            Continue For
                    End Select

                    sql.Params("FILE_PATH") = UploadPath
                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
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
                        If System.IO.File.Exists(HttpContext.Current.Server.MapPath(UploadPath) + filename) Then
                            System.IO.File.Delete(HttpContext.Current.Server.MapPath(UploadPath) + filename)
                        End If
                        'Copy folder
                        Dim copyFolder As String = "\WCF\UploadFiles\" & SessionInfo.UserID.ToString & "\"
                        If System.IO.File.Exists(HttpContext.Current.Server.MapPath(copyFolder) + filename) Then
                            System.IO.File.Delete(HttpContext.Current.Server.MapPath(copyFolder) + filename)
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
                Dim dsRet As DataSet = Search(ds)("Data")
                sql = New SqlBox("ComDocumentMgt@Search")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                sql.Blocks("MNGT_NO") = True
                Dim dtRet As DataTable = db.SqlGet(sql.Text, False)
                dtRet.TableName = "WG2"
                dsRet.Tables.Add(dtRet)

                resultSet("Data") = dsRet
            End If

            Return resultSet

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

        Public Shared Function Delete(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox
            Dim filename As String = ""
            Dim UploadPath As String = ""
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow = Nothing
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)


                sql = New SqlBox("CrmManualMgt@Delete")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                db.SqlSet(sql.Text)



                Dim dt As DataTable = ds.Tables("WG2")
                Dim firstSeqNumber As Integer = ComDocumentMgt.SearchSeq(drHeader("MNGT_NO").ToString)

                For Each dr As DataRow In dt.Rows
                    Select Case dr("_INSFLAG")
                        Case "D"
                            sql = New SqlBox("ComDocumentMgt@Delete")
                            UploadPath = drHeader("UploadPath").ToString & drHeader("MNGT_NO").ToString & "/"
                            filename = drHeader("MNGT_NO").ToString & "_" & dr("SEQ") & "_" & dr("FILE_NM").ToString
                        Case Else
                            Continue For
                    End Select

                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    sql.Params("SEQ") = dr("SEQ").ToString
                    db.SqlSet(sql.Text)

                    If dr("_INSFLAG").ToString = "D" _
                            Or (dr("_INSFLAG").ToString = "U" And (dr("FILE_PATH").ToString <> UploadPath Or dr("FILE_NM").ToString() = "")) Then
                        If System.IO.File.Exists(HttpContext.Current.Server.MapPath(UploadPath) + filename) Then
                            System.IO.File.Delete(HttpContext.Current.Server.MapPath(UploadPath) + filename)
                        End If
                        'Copy folder
                        Dim copyFolder As String = "\WCF\UploadFiles\" & SessionInfo.UserID.ToString & "\"
                        If System.IO.File.Exists(HttpContext.Current.Server.MapPath(copyFolder) + filename) Then
                            System.IO.File.Delete(HttpContext.Current.Server.MapPath(copyFolder) + filename)
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
                Dim dsRet As DataSet = Search(ds)("Data")
                sql = New SqlBox("ComDocumentMgt@Search")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                sql.Blocks("MNGT_NO") = True
                Dim dtRet As DataTable = db.SqlGet(sql.Text, False)
                dtRet.TableName = "WG2"
                dsRet.Tables.Add(dtRet)

                resultSet("Data") = dsRet
            End If

            Return resultSet
        End Function
    End Class
End Namespace
