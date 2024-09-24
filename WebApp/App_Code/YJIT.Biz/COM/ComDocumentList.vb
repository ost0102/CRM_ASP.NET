Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common

Namespace YJIT.Biz
    Public Class ComDocumentList


        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)

            'Dim resultSet As New Dictionary(Of String, Object)
            'Dim resultDs As DataSet = New DataSet
            'Dim drHeader As DataRow
            'Dim db As DBA = New DBA()
            'Dim ErrorOccur As Boolean = True

            'Try
            '    Dim sql = New SqlBox("ComDocumentList@Search")

            '    If Not ds.Tables.Contains("MAIN") Then
            '        ThrowMsg(ErrorOccur, "Data info missing.")
            '    End If

            '    drHeader = ds.Tables("MAIN").Rows(0)
            '    sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
            '    sql.Params("REQ_SVC") = drHeader("S_REQ_SVC").ToString
            '    sql.Params("DATE_FM") = drHeader("S_DATE_FM").ToString
            '    sql.Params("DATE_TO") = drHeader("S_DATE_TO").ToString
            '    sql.Params("SHP_CD") = drHeader("S_SHP_CD").ToString
            '    sql.Params("CNE_CD") = drHeader("S_CNE_CD").ToString
            '    sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
            '    sql.Params("POL_CD") = drHeader("S_POL_CD").ToString
            '    sql.Params("POD_CD") = drHeader("S_POD_CD").ToString
            '    sql.Params("OP_CD") = drHeader("S_OP_CD").ToString
            '    sql.Params("VSL") = drHeader("S_VSL").ToString
            '    sql.Params("MBL_NO") = drHeader("S_MBL_NO").ToString
            '    sql.Params("HBL_NO") = drHeader("S_HBL_NO").ToString
            '    sql.Params("EX_IM_TYPE") = drHeader("S_EX_IM_TYPE").ToString
            '    sql.Params("DOC_TYPE") = drHeader("S_DOC_TYPE").ToString
            '    sql.Params("DOC_NO") = drHeader("S_DOC_NO").ToString

            '    If drHeader.Table.Columns.Contains("S_INS_USR") = True Then
            '        sql.Params("INS_USR") = drHeader("S_INS_USR").ToString
            '        If drHeader("S_INS_USR").ToString <> "" Then
            '            sql.Blocks("INS_USR") = True
            '        End If
            '    End If

            '    If drHeader("S_REQ_SVC").ToString <> "" Then sql.Blocks("REQ_SVC") = True
            '    If Trim(drHeader("S_DATE_TYPE")) = "ETD" Then sql.Blocks("DATE_ETD") = True
            '    If Trim(drHeader("S_DATE_TYPE")) = "ETA" Then sql.Blocks("DATE_ETA") = True
            '    If Trim(drHeader("S_DATE_TYPE")) = "REG" Then sql.Blocks("REG_YMD") = True
            '    If Trim(drHeader("S_DATE_FM")) <> "" Then sql.Blocks("DATE_FM") = True
            '    If Trim(drHeader("S_DATE_TO")) <> "" Then sql.Blocks("DATE_TO") = True
            '    If drHeader("S_SHP_CD").ToString <> "" Then sql.Blocks("SHP_CD") = True
            '    If drHeader("S_CNE_CD").ToString <> "" Then sql.Blocks("CNE_CD") = True
            '    If drHeader("CUST_CD").ToString <> "" Then sql.Blocks("CUST_CD") = True
            '    If drHeader("S_POL_CD").ToString <> "" Then sql.Blocks("POL_CD") = True
            '    If drHeader("S_POD_CD").ToString <> "" Then sql.Blocks("POD_CD") = True
            '    If drHeader("S_OP_CD").ToString <> "" Then sql.Blocks("OP_CD") = True
            '    If drHeader("S_VSL").ToString <> "" Then sql.Blocks("VSL") = True
            '    If drHeader("S_MBL_NO").ToString <> "" Then sql.Blocks("MBL_NO") = True
            '    If drHeader("S_HBL_NO").ToString <> "" Then sql.Blocks("HBL_NO") = True
            '    If drHeader("S_EX_IM_TYPE").ToString <> "" Then sql.Blocks("EX_IM_TYPE") = True
            '    If drHeader("S_DOC_TYPE").ToString <> "" Then sql.Blocks("DOC_TYPE") = True
            '    If drHeader("S_DOC_NO").ToString <> "" Then sql.Blocks("DOC_NO") = True

            '    Select Case YJIT.SessionOfficeInfo.HqOfficeCode
            '        Case "ENCHQ"
            '            sql.Blocks("OFFICE_CD") = False
            '        Case Else
            '            sql.Blocks("OFFICE_CD") = True
            '    End Select

            '    Dim dt As DataTable = db.SqlGet(sql.Text, False)

            '    dt.TableName = "WG1"
            '    resultDs.Tables.Add(dt)

            '    resultSet("TrxCode") = "Y"
            '    resultSet("TrxMsg") = "Success"
            '    resultSet("Data") = resultDs

            '    If dt.Rows.Count = 0 Then
            '        ThrowMsg(ErrorOccur, "Data not found!")
            '    End If

            'Catch ex As Exception
            '    If ErrorOccur Then
            '        resultSet("TrxCode") = "E"
            '    Else
            '        resultSet("TrxCode") = "N"
            '    End If
            '    resultSet("TrxMsg") = ex.Message
            'End Try

            'Return resultSet
        End Function

        Public Shared Function Delete(ByVal ds As DataSet) As Dictionary(Of String, Object)
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
                UploadPath = drHeader("UploadPath").ToString

                dt = ds.Tables("WG1")

                For Each dr As DataRow In dt.Rows

                    If dr("_INSFLAG") = "D" Then
                        sql = New SqlBox("ComDocumentMgt@Delete")
                        sql.Params("MNGT_NO") = dr("MNGT_NO").ToString()
                        sql.Params("SEQ") = dr("SEQ")
                        sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
                        db.SqlSet(sql.Text)

                        filename = dr("MNGT_NO").ToString & "_" & dr("SEQ").ToString & "_" & dr("FILE_NM").ToString
                        If dr("_INSFLAG").ToString = "D" And dr("FILE_PATH").ToString <> "" And dr("FILE_NM").ToString() <> "" Then
                            If System.IO.File.Exists(HttpContext.Current.Server.MapPath(dr("FILE_PATH").ToString) & filename) Then
                                System.IO.File.Delete(HttpContext.Current.Server.MapPath(dr("FILE_PATH").ToString) & filename)
                            End If
                            'Copy folder
                            Dim copyFolder As String = "\WCF\UploadFiles\" & SessionInfo.UserID.ToString & "\"
                            If System.IO.File.Exists(HttpContext.Current.Server.MapPath(dr("FILE_PATH").ToString) & filename) Then
                                System.IO.File.Delete(HttpContext.Current.Server.MapPath(dr("FILE_PATH").ToString) & filename)
                            End If
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

    End Class
End Namespace

