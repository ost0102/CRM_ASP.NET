Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz
    Public Class CrmAsMgtDev
        Public Shared Function ExceptCancel(ByVal MngtNo As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Try
                db.BeginTransaction()


                sql = New SqlBox("CrmAsMgtDev@ExceptCancel")
                sql.Params("MNGT_NO") = MngtNo
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
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

        Public Shared Function ExceptList(ByVal MngtNo As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Try
                db.BeginTransaction()


                sql = New SqlBox("CrmAsMgtDev@ExceptList")
                sql.Params("MNGT_NO") = MngtNo
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
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
        Public Shared Function AssignData_20181014(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow
            Dim dt As DataTable
            Dim WorkUser As String = ""
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                If drHeader("WORK_USR").ToString = "" Then
                    WorkUser = YJIT.SessionInfo.UserID
                Else
                    WorkUser = drHeader("WORK_USR").ToString
                End If
                '기 배정여부 체크 
                sql = New SqlBox("CrmAsMgtDev@AssignCheck")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    ThrowMsg(ErrorOccur, "이미 배정된 자료 입니다!")
                End If

                sql = New SqlBox("CrmAsMgtDev@AssignData")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                sql.Params("USR_ID") = WorkUser
                sql.Params("PROC_TYPE") = drHeader("PROC_TYPE").ToString
                sql.Params("REQ_SVC") = drHeader("REQ_SVC")
                sql.Params("REQ_SVC2") = drHeader("REQ_SVC2")
                sql.Params("REQ_SVC3") = drHeader("REQ_SVC3")
                sql.Params("PRAR_YMD") = drHeader("PRAR_YMD")
                sql.Params("REQ_YMD") = drHeader("REQ_YMD")
                sql.Params("REQ_HM") = drHeader("REQ_HM")
                sql.Params("CMPT_YMD") = drHeader("CMPT_YMD")
                sql.Params("CMPT_HM") = drHeader("CMPT_HM")
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
        Public Shared Function AssignData2(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow
            Dim dt As DataTable
            Dim WorkUser As String = ""
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                If drHeader("WORK_USR").ToString = "" Then
                    WorkUser = YJIT.SessionInfo.UserID
                Else
                    WorkUser = drHeader("WORK_USR").ToString
                End If
                '기 배정여부 체크 
                sql = New SqlBox("CrmAsMgtDev@AssignCheck")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    ThrowMsg(ErrorOccur, "이미 배정된 자료 입니다!")
                End If

                sql = New SqlBox("CrmAsMgtDev@AssignData2")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                sql.Params("USR_ID") = WorkUser
                sql.Params("PROC_TYPE") = drHeader("PROC_TYPE").ToString
                sql.Params("REQ_SVC") = drHeader("REQ_SVC")
                sql.Params("REQ_SVC2") = drHeader("REQ_SVC2")
                sql.Params("REQ_SVC3") = drHeader("REQ_SVC3")
                sql.Params("PRAR_YMD") = drHeader("PRAR_YMD")
                sql.Params("REQ_YMD") = drHeader("REQ_YMD")
                sql.Params("REQ_HM") = drHeader("REQ_HM")
                sql.Params("CMPT_YMD") = drHeader("CMPT_YMD")
                sql.Params("CMPT_HM") = drHeader("CMPT_HM")
                sql.Params("RANK") = drHeader("RANK")
                'sql.Params("DEV_RMK") = drHeader("DEV_RMK")
                sql.Params("RMK") = drHeader("RMK")
                sql.Params("SSN_USR_ID") = SessionInfo.UserID
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
        Public Shared Function Save2(ByVal ds As DataSet, ByVal strUploadPath As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim insflag As String = ""
            Dim CustCode As String = ""
            Dim drHeader As DataRow
            Dim dt As DataTable
            Dim filename As String = ""
            Dim UploadPath As String = ""
            Dim MngtNo As String = ""

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmAsMgtDev@UpdateMergeWorkUsr2")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO")
                sql.Params("USR_ID") = drHeader("WORK_USR").ToString
                sql.Params("SSN_USR_ID") = SessionInfo.UserID
                db.SqlSet(sql.Text)

                sql = New SqlBox("CrmAsMgtDev@Update2")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                sql.Params("PRAR_YMD") = drHeader("PRAR_YMD")
                sql.Params("CMPT_YMD") = drHeader("CMPT_YMD")
                sql.Params("CMPT_HM") = ""
                sql.Params("PROC_TYPE") = drHeader("PROC_TYPE")
                sql.Params("USR_ID") = drHeader("WORK_USR").ToString
                sql.Params("REQ_SVC") = drHeader("REQ_SVC")
                sql.Params("REQ_SVC2") = drHeader("REQ_SVC2")
                sql.Params("REQ_SVC3") = drHeader("REQ_SVC3")
                sql.Params("RMK") = drHeader("RMK")
                sql.Params("CMPT_RMK") = drHeader("CMPT_RMK")
                ' sql.Params("DEV_RMK") = drHeader("DEV_RMK")
                sql.Params("RANK") = drHeader("RANK")
                sql.Params("DEV_ERR_YN") = drHeader("DEV_ERR_YN")
                sql.Params("DEV_ERR_NM") = drHeader("DEV_ERR_NM")
                sql.Params("SHARE_YN") = drHeader("SHARE_YN")
                db.SqlSet(sql.Text)

                dt = ds.Tables("WG2")
                Dim firstSeqNumber As Integer = ComDocumentMgt.SearchSeq(MngtNo)
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
                            UploadPath = strUploadPath & MngtNo & "/"
                        Case "U"
                            sql = New SqlBox("ComDocumentMgt@Update")
                            sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                            sql.Params("RMK") = dr("RMK").ToString()
                            'UploadPath = strUploadPath & MngtNo & "/"
                            If dr("FILE_PATH").ToString.StartsWith("/") Then
                                UploadPath = dr("FILE_PATH").ToString
                            Else
                                UploadPath = strUploadPath & MngtNo & "/"
                            End If
                            filename = MngtNo & "_" & dr("SEQ") & "_" & SearchFileName(MngtNo, intSeq)
                        Case "D"
                            sql = New SqlBox("ComDocumentMgt@Delete")
                            UploadPath = strUploadPath & MngtNo & "/"
                            filename = MngtNo & "_" & dr("SEQ") & "_" & dr("FILE_NM").ToString
                        Case Else
                            Continue For
                    End Select
                    sql.Params("FILE_PATH") = UploadPath
                    sql.Params("MNGT_NO") = MngtNo
                    sql.Params("SEQ") = intSeq.ToString
                    sql.Params("FILE_NM") = dr("FILE_NM").ToString()
                    If dr.Table.Columns.Contains("FILE_SIZE") = True Then
                        If Not String.IsNullOrEmpty(dr("FILE_SIZE").ToString) Then
                            sql.Blocks("FILE_SIZE") = True
                            sql.Params("FILE_SIZE") = dr("FILE_SIZE").ToString
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

                Dim dic As Dictionary(Of String, Object) = Search(ds)
                dic.TryGetValue("Data", retDs)
                resultSet("Data") = retDs

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return resultSet

        End Function

        Public Shared Function Save3(ByVal ds As DataSet, ByVal strUploadPath As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim insflag As String = ""
            Dim CustCode As String = ""
            Dim drHeader As DataRow
            Dim dt As DataTable
            Dim filename As String = ""
            Dim UploadPath As String = ""
            Dim MngtNo As String = ""

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                If drHeader.Table.Columns.Contains("SAVE_CNT") Then
                    sql = New SqlBox("CrmAsMgt_v3@SearchSaveCount")
                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    Dim dtRet As DataTable = db.SqlGet(sql.Text, False)
                    If dtRet.Rows.Count > 0 Then
                        If dtRet.Rows(0)("SAVE_CNT").ToString <> drHeader("SAVE_CNT").ToString Then
                            ThrowMsg(ErrorOccur, "고객지원 자료가 수정되었습니다. 재조회후 저장해주세요. (버전 화면 : " & drHeader("SAVE_CNT").ToString & ", DB : " & dtRet.Rows(0)("SAVE_CNT").ToString & "   최종수정자 : " & dtRet.Rows(0)("UPD_USR_NM").ToString & ")")
                        End If
                    End If
                End If

                sql = New SqlBox("CrmAsMgtDev@UpdateMergeWorkUsr2")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO")
                sql.Params("USR_ID") = drHeader("WORK_USR").ToString
                sql.Params("SSN_USR_ID") = SessionInfo.UserID
                db.SqlSet(sql.Text)

                sql = New SqlBox("CrmAsMgtDev@Update2")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                sql.Params("PRAR_YMD") = drHeader("PRAR_YMD")
                sql.Params("REQ_YMD") = drHeader("REQ_YMD")
                sql.Blocks("REQ_YMD") = True
                sql.Params("REQ_HM") = drHeader("REQ_HM")
                sql.Blocks("REQ_HM") = True
                sql.Params("CMPT_YMD") = drHeader("CMPT_YMD")
                sql.Params("CMPT_HM") = drHeader("CMPT_HM")
                sql.Params("PROC_TYPE") = drHeader("PROC_TYPE")
                sql.Params("USR_ID") = drHeader("WORK_USR").ToString
                sql.Params("REQ_SVC") = drHeader("REQ_SVC")
                sql.Params("REQ_SVC2") = drHeader("REQ_SVC2")
                sql.Params("REQ_SVC3") = drHeader("REQ_SVC3")
                sql.Params("RMK") = drHeader("RMK")
                sql.Params("CMPT_RMK") = drHeader("CMPT_RMK")
                'sql.Params("DEV_RMK") = drHeader("DEV_RMK")
                sql.Params("RANK") = drHeader("RANK")
                sql.Params("DEV_ERR_YN") = drHeader("DEV_ERR_YN")
                sql.Params("DEV_ERR_NM") = drHeader("DEV_ERR_NM")
                sql.Params("SHARE_YN") = drHeader("SHARE_YN")
                sql.Params("QC_TEST_YN") = drHeader("QC_TEST_YN").ToString
                sql.Params("QC_TESTER") = drHeader("QC_TESTER").ToString
                sql.Params("PGM_MDF") = drHeader("PGM_MDF")

                sql.Params("RANK1") = drHeader("RANK1").ToString
                sql.Params("RANK2") = drHeader("RANK2").ToString
                sql.Params("RANK3") = drHeader("RANK3").ToString
                sql.Params("RANK4") = drHeader("RANK4").ToString
                sql.Params("RANK5") = drHeader("RANK5").ToString
                sql.Params("RANK6") = drHeader("RANK6").ToString
                sql.Params("RANK7") = drHeader("RANK7").ToString
                sql.Params("RANK8") = drHeader("RANK8").ToString
                sql.Params("RANK9") = drHeader("RANK9").ToString
                sql.Params("RANK10") = drHeader("RANK10").ToString
                sql.Params("RANK11") = drHeader("RANK11").ToString
                sql.Params("RANK12") = drHeader("RANK12").ToString
                sql.Params("RANK13") = drHeader("RANK13").ToString
                sql.Params("RANK14") = drHeader("RANK14").ToString
                sql.Params("RANK15") = drHeader("RANK15").ToString
                sql.Params("RANK16") = drHeader("RANK16").ToString
                sql.Params("RANK17") = drHeader("RANK17").ToString

                sql.Params("DEV_SCORE") = drHeader("DEV_SCORE")
                sql.Params("DEV_SCORE_RMK") = drHeader("DEV_SCORE_RMK")

                db.SqlSet(sql.Text)


                dt = ds.Tables("WG2")
                Dim firstSeqNumber As Integer = ComDocumentMgt.SearchSeq(MngtNo)
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
                            UploadPath = strUploadPath & MngtNo & "/"
                        Case "U"
                            sql = New SqlBox("ComDocumentMgt@Update")
                            sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                            sql.Params("RMK") = dr("RMK").ToString()
                            'UploadPath = strUploadPath & MngtNo & "/"
                            If dr("FILE_PATH").ToString.StartsWith("/") Then
                                UploadPath = dr("FILE_PATH").ToString
                            Else
                                UploadPath = strUploadPath & MngtNo & "/"
                            End If
                            filename = MngtNo & "_" & dr("SEQ") & "_" & SearchFileName(MngtNo, intSeq)
                        Case "D"
                            sql = New SqlBox("ComDocumentMgt@Delete")
                            UploadPath = strUploadPath & MngtNo & "/"
                            filename = MngtNo & "_" & dr("SEQ") & "_" & dr("FILE_NM").ToString
                        Case Else
                            Continue For
                    End Select
                    sql.Params("FILE_PATH") = UploadPath
                    sql.Params("MNGT_NO") = MngtNo
                    sql.Params("SEQ") = intSeq.ToString
                    sql.Params("FILE_NM") = dr("FILE_NM").ToString()
                    If dr.Table.Columns.Contains("FILE_SIZE") = True Then
                        If Not String.IsNullOrEmpty(dr("FILE_SIZE").ToString) Then
                            sql.Blocks("FILE_SIZE") = True
                            sql.Params("FILE_SIZE") = dr("FILE_SIZE").ToString
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

                Dim dic As Dictionary(Of String, Object) = Search3(ds, "")
                dic.TryGetValue("Data", retDs)
                dic = SearchInput(ds)
                dic.TryGetValue("Data", retDs)
                resultSet("Data") = retDs

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return resultSet

        End Function

        Public Shared Function SaveInput(ByVal ds As DataSet, ByVal strUploadPath As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim insflag As String = ""
            Dim CustCode As String = ""
            Dim drHeader As DataRow
            Dim dt As DataTable
            Dim filename As String = ""
            Dim UploadPath As String = ""
            Dim MngtNo As String = ""
            Dim SEQ As String = ""
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                insflag = "U"
                MngtNo = drHeader("MNGT_NO").ToString
                SEQ = drHeader("SEQ").ToString

                Select Case insflag
                    Case "U"
                        sql = New SqlBox("CrmAsMgtDev@Update")
                End Select
                sql.Params("MNGT_NO") = MngtNo
                sql.Params("SEQ") = SEQ
                sql.Params("PRAR_YMD") = drHeader("PRAR_YMD")
                sql.Params("PROC_TYPE") = drHeader("PROC_TYPE")
                sql.Params("CMPT_YMD") = drHeader("CMPT_YMD")
                sql.Params("TEST_REQ_YMD") = drHeader("TEST_REQ_YMD")
                sql.Params("TEST_RESULT") = drHeader("TEST_RESULT")
                sql.Params("TEST_CMPT_YMD") = drHeader("TEST_CMPT_YMD")
                sql.Params("TEST_USR_ID") = drHeader("TEST_USR_ID")
                sql.Params("DEV_CONTENT") = drHeader("DEV_CONTENT")
                sql.Params("USR_ID") = drHeader("USR_ID")
                sql.Params("REQ_SVC") = drHeader("REQ_SVC")
                sql.Params("REQ_SVC2") = drHeader("REQ_SVC2")
                sql.Params("REQ_SVC3") = drHeader("REQ_SVC3")
                db.SqlSet(sql.Text)

                dt = ds.Tables("WG2")
                Dim firstSeqNumber As Integer = ComDocumentMgt.SearchSeq(MngtNo)

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
                            UploadPath = strUploadPath & MngtNo & "/"
                        Case "U"
                            sql = New SqlBox("ComDocumentMgt@Update")
                            sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                            sql.Params("RMK") = dr("RMK").ToString()
                            'UploadPath = strUploadPath & MngtNo & "/"
                            If dr("FILE_PATH").ToString.StartsWith("/") Then
                                UploadPath = dr("FILE_PATH").ToString
                            Else
                                UploadPath = strUploadPath & MngtNo & "/"
                            End If
                            filename = MngtNo & "_" & dr("SEQ") & "_" & SearchFileName(MngtNo, intSeq)
                        Case "D"
                            sql = New SqlBox("ComDocumentMgt@Delete")
                            UploadPath = strUploadPath & MngtNo & "/"
                            filename = MngtNo & "_" & dr("SEQ") & "_" & dr("FILE_NM").ToString
                        Case Else
                            Continue For
                    End Select

                    sql.Params("FILE_PATH") = UploadPath
                    sql.Params("MNGT_NO") = MngtNo
                    sql.Params("SEQ") = intSeq.ToString
                    sql.Params("FILE_NM") = dr("FILE_NM").ToString()
                    If dr.Table.Columns.Contains("FILE_SIZE") = True Then
                        If Not String.IsNullOrEmpty(dr("FILE_SIZE").ToString) Then
                            sql.Blocks("FILE_SIZE") = True
                            sql.Params("FILE_SIZE") = dr("FILE_SIZE").ToString
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
                'Dim sqlTxt As String = ""
                ''작업자
                'Dim WorkUsr() As String = drHeader("WORK_USR_LIST").ToString.Split(";")
                'For Each Usr In WorkUsr
                '    If Usr = "" Then Continue For
                '    sql = New SqlBox("CrmAsMgtDev@UpdateMergeWorKUsr")
                '    sql.Params("MNGT_NO") = drHeader("MNGT_NO")
                '    sql.Params("USR_ID") = Usr
                '    sql.Params("WORK_TYPE") = "WORK"
                '    sql.Params("WORK_VALUE") = drHeader("DEV_TEST_RESULT")
                '    sqlTxt &= sql.Text & ";" & vbCrLf
                'Next
                ''테스트 유저
                'Dim TestUsr() As String = drHeader("DEV_TEST_USR").ToString.Split(";")
                'For Each Usr In TestUsr
                '    If Usr = "" Then Continue For
                '    sql = New SqlBox("CrmAsMgtDev@UpdateMergeWorKUsr")
                '    sql.Params("MNGT_NO") = drHeader("MNGT_NO")
                '    sql.Params("USR_ID") = Usr
                '    sql.Params("WORK_TYPE") = "TEST"
                '    sql.Params("WORK_VALUE") = drHeader("DEV_TEST_RESULT")
                '    sqlTxt &= sql.Text & ";" & vbCrLf
                'Next
                'If sqlTxt <> "" Then
                '    db.SqlSet("BEGIN " & vbCrLf & sqlTxt & vbCrLf & "END;")
                'End If
                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

                'sql = New SqlBox("ComDocumentMgt@Search")
                'sql.Params("MNGT_NO") = MngtNo
                'If MngtNo <> "" Then sql.Blocks("MNGT_NO") = True
                'dt = db.SqlGet(sql.Text, False)
                'dt.TableName = "WG2"
                'retDs.Tables.Add(dt)

                Dim dic As Dictionary(Of String, Object) = Search(ds)
                dic.TryGetValue("Data", retDs)
                resultSet("Data") = retDs

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

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
        Public Shared Function SearchInput(ByVal ds As DataSet) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgtDev@SearchInput")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                sql.Params("SEQ") = drHeader("SEQ").ToString
                sql.Params("USR_ID") = drHeader("USR_ID").ToString
                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                dt.TableName = "MAIN"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("ComDocumentMgt@Search")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                If drHeader("MNGT_NO").ToString <> "" Then sql.Blocks("MNGT_NO") = True
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
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


        Public Shared Function SearchCustomer(ByVal ds As DataSet) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgtDev@SearchCustomer")
                sql.Params("SEARCH_KEY") = drHeader("CUST_CD").ToString
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                If dt.Rows.Count = 1 Then
                    ResultSet("CUST_CD") = dt.Rows(0)("CUST_CD").ToString
                    ResultSet("CUST_NM") = dt.Rows(0)("CUST_LOC_NM").ToString
                    ResultSet("TEL_NO") = dt.Rows(0)("TEL_NO").ToString
                ElseIf dt.Rows.Count > 1 Then

                    Dim foundRows As DataRow() = dt.Select("CUST_CD = '" & drHeader("CUST_CD").ToString & "'")
                    If foundRows.Length = 1 Then
                        ResultSet("CUST_CD") = foundRows(0)("CUST_CD").ToString
                        ResultSet("CUST_NM") = foundRows(0)("CUST_LOC_NM").ToString
                        ResultSet("TEL_NO") = foundRows(0)("TEL_NO").ToString
                    Else
                        dt.TableName = "CUST_LIST"
                        ResultDs.Tables.Add(dt)
                        ResultSet("TrxCode") = "M"
                        ResultSet("TrxMsg") = "Success"
                        ResultSet("Data") = ResultDs
                        Return ResultSet
                    End If
                End If
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
        Public Shared Function SearchCustomerPic(ByVal ds As DataSet) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgtDev@SearchCustomerPic")
                sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
                sql.Params("SEARCH_KEY") = drHeader("REQ_USR").ToString
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                If dt.Rows.Count = 1 Then
                    ResultSet("PIC_NM") = dt.Rows(0)("PIC_NM").ToString
                    ResultSet("TEL_NO") = dt.Rows(0)("TEL_NO").ToString
                ElseIf dt.Rows.Count > 1 Then

                    Dim foundRows As DataRow() = dt.Select("PIC_NM = '" & drHeader("REQ_USR").ToString & "'")
                    If foundRows.Length = 1 Then
                        ResultSet("PIC_NM") = foundRows(0)("PIC_NM").ToString
                        ResultSet("TEL_NO") = foundRows(0)("TEL_NO").ToString
                    Else
                        dt.TableName = "CUST_PIC_LIST"
                        ResultDs.Tables.Add(dt)
                        ResultSet("TrxCode") = "M"
                        ResultSet("TrxMsg") = "Success"
                        ResultSet("Data") = ResultDs
                        Return ResultSet
                    End If
                End If
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
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function
        Public Shared Function Search2(ByVal ds As DataSet, ByVal sMngtNo As String) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgtDev@Search2")
                sql.AllowSqlInjection = True

                sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
                sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
                sql.Params("S_PROC_TYPE") = drHeader("S_DEV_PROC_TYPE").ToString.Replace("; ", "','")
                sql.Params("WORK_USR") = drHeader("S_DEV_WORK_USR").ToString
                sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
                sql.Params("S_MNGT_NO") = sMngtNo

                If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True
                If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True
                If drHeader("S_DEV_PROC_TYPE").ToString <> "" Then sql.Blocks("S_PROC_TYPE") = True
                If drHeader("S_DEV_WORK_USR").ToString <> "" Then sql.Blocks("WORK_USR") = True
                If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True

                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
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
        Public Shared Function Search3(ByVal ds As DataSet, ByVal sMngtNo As String) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgtDev@Search2")
                sql.AllowSqlInjection = True

                sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
                sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
                sql.Params("S_PROC_TYPE") = drHeader("S_DEV_PROC_TYPE").ToString.Replace("; ", "','")
                sql.Params("WORK_USR") = drHeader("S_DEV_WORK_USR").ToString
                sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
                sql.Params("S_MNGT_NO") = sMngtNo
                sql.Params("DEPT_CD") = SessionInfo.OrganizationCode

                If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True
                If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True
                If drHeader("S_DEV_PROC_TYPE").ToString <> "" Then sql.Blocks("S_PROC_TYPE") = True
                If drHeader("S_DEV_WORK_USR").ToString <> "" Then sql.Blocks("WORK_USR") = True
                If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
                sql.Blocks("DEPT_CD") = True

                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
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
        Public Shared Function SearchReq(ByVal ds As DataSet) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgtDev@SearchReq")
                sql.AllowSqlInjection = True
                Select Case drHeader("S_YEAR").ToString
                    Case "1" '1년이내
                        sql.Params("FM_YMD") = DateAdd(DateInterval.Year, -1, Now).ToString("yyyyMMdd")
                    Case Else '전체
                        sql.Params("FM_YMD") = "20190101"
                End Select
                sql.Params("TO_YMD") = Now.ToString("yyyyMMdd")
                If drHeader("INCLUDE_EXCEPT").ToString = "N" Then
                    sql.Blocks("EXCEPT_LIST") = True
                End If
                If Not String.IsNullOrEmpty(drHeader("S_DEPT_LIST").ToString.Trim) Then
                    sql.Params("DEPT_CD") = drHeader("S_DEPT_LIST").ToString.Replace(" ", "").Replace(";", "','")
                Else
                    sql.Params("DEPT_CD") = SessionInfo.OrganizationCode
                End If

                If Not String.IsNullOrEmpty(drHeader("S_SEARCH_KEY").ToString) Then
                    sql.Params("SEARCH_KEY") = drHeader("S_SEARCH_KEY").ToString
                    sql.Blocks(drHeader("S_SEARCH_TYPE").ToString) = True
                End If



                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG3"
                ResultDs.Tables.Add(dt)

                If drHeader("MNGT_NO").ToString <> "" Then
                    sql = New SqlBox("ComDocumentMgt@Search")
                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    If drHeader("MNGT_NO").ToString <> "" Then sql.Blocks("MNGT_NO") = True
                    dt = db.SqlGet(sql.Text, False)
                    dt.TableName = "WG2"
                    ResultDs.Tables.Add(dt)
                End If

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

        Public Shared Function SearchFileList(ByVal sMngtNo As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try

                sql = New SqlBox("ComDocumentMgt@Search")
                sql.Params("MNGT_NO") = sMngtNo
                sql.Blocks("MNGT_NO") = True
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
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
        Public Shared Function SearchAssign(ByVal ds As DataSet, ByVal sMngtNo As String, ByVal sDeptCd As String) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgtDev@SearchAssign")
                sql.AllowSqlInjection = True
                sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
                sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
                sql.Params("S_PROC_TYPE") = drHeader("S_DEV_PROC_TYPE").ToString.Replace("; ", "','")
                sql.Params("WORK_USR") = drHeader("S_DEV_WORK_USR").ToString
                sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
                sql.Params("S_MNGT_NO") = sMngtNo
                sql.Params("DEPT_CD") = sDeptCd.Replace(" ", "").Replace(";", "','")
                sql.Params("WORK_AREA") = drHeader("WORK_AREA").ToString

                If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True
                If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True
                If drHeader("S_DEV_PROC_TYPE").ToString <> "" Then sql.Blocks("S_PROC_TYPE") = True
                If drHeader("S_DEV_WORK_USR").ToString <> "" Then sql.Blocks("WORK_USR") = True
                If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
                If drHeader("WORK_AREA").ToString <> "" Then sql.Blocks("WORK_AREA") = True
                If drHeader("CMPT_YMD_YN").ToString = "Y" Then
                    sql.Blocks("CMPT_YMD") = True
                Else
                    sql.Blocks("REQ_YMD") = True
                End If
                If drHeader("PGM_MDF_YN").ToString = "Y" Then
                    sql.Blocks("PGM_MDF") = True
                End If
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
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
    End Class
End Namespace
