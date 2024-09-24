Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz
    Public Class CrmAsMgt_v4
        Public Shared Function Save(ByVal ds As DataSet, ByVal strUploadPath As String) As Dictionary(Of String, Object)
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


                If drHeader("MNGT_NO").ToString <> "" Then
                    insflag = "U"
                    MngtNo = drHeader("MNGT_NO").ToString
                Else
                    insflag = "I"

                    If Not String.IsNullOrEmpty(drHeader("ORGN_MNGT_NO").ToString) Then
                        Dim i As Integer = 1
                        Do While MngtNo = String.Empty
                            MngtNo = String.Format("{0}{1}", Format(Now, "yyyyMMddHHmmss"), Now.Millisecond)
                            '중복체크
                            sql = New SqlBox("CrmAsMgt_v4@SearchSaveCount")
                            sql.Params("MNGT_NO") = MngtNo
                            dt = db.SqlGet(sql.Text, False)

                            If dt.Rows.Count > 0 Then
                                MngtNo = ""
                                If i = 10 Then Exit Do
                            End If
                        Loop
                        'MngtNo = Mid(drHeader("ORGN_MNGT_NO").ToString, 1, 19) & "A"
                        drHeader("MNGT_NO") = MngtNo
                    Else
                        Dim paramKeyNo As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                        ' Reference Group No 생성
                        Dim yyyyMMdd As String = Now.ToString("yyyyMMdd")
                        paramKeyNo = GenerationKeyNo("MNGT_NO", "", "", yyyyMMdd, "YJIT", "S", "")
                        If ("" & paramKeyNo("TrxCode").ToString) = "E" Then
                            ThrowMsg(ErrorOccur, "Error while Key No Create Processing! Error Msg: " & paramKeyNo("TrxMsg").ToString)
                        Else
                            MngtNo = paramKeyNo("KEY_NO").ToString
                        End If
                        drHeader("MNGT_NO") = MngtNo
                    End If

                    'Dim paramKeyNo As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                    '' Reference Group No 생성
                    'Dim yyyyMMdd As String = Now.ToString("yyyyMMdd")
                    'paramKeyNo = GenerationKeyNo("MNGT_NO", "", "", yyyyMMdd, "YJIT", "S", "")
                    'If ("" & paramKeyNo("TrxCode").ToString) = "E" Then
                    '    ThrowMsg(ErrorOccur, "Error while Key No Create Processing! Error Msg: " & paramKeyNo("TrxMsg").ToString)
                    'Else
                    '    MngtNo = paramKeyNo("KEY_NO").ToString
                    'End If
                    'drHeader("MNGT_NO") = MngtNo
                End If


                If String.IsNullOrEmpty(drHeader("UPPER_MNGT_NO").ToString) Then
                    drHeader("UPPER_MNGT_NO") = MngtNo
                End If



                Select Case insflag
                    Case "I"
                        sql = New SqlBox("CrmAsMgt_v4@Insert")
                    Case "U"
                        sql = New SqlBox("CrmAsMgt_v4@SearchSaveCount")
                        sql.Params("MNGT_NO") = MngtNo
                        Dim dtRet As DataTable = db.SqlGet(sql.Text, False)
                        If dtRet.Rows.Count > 0 Then
                            If dtRet.Rows(0)("SAVE_CNT").ToString <> drHeader("SAVE_CNT").ToString Then
                                ThrowMsg(ErrorOccur, "자료가 수정되었습니다. 재조회후 저장해주세요. (버전 화면 : " & drHeader("SAVE_CNT").ToString & ", DB : " & dtRet.Rows(0)("SAVE_CNT").ToString & "   최종수정자 : " & dtRet.Rows(0)("UPD_USR_NM").ToString & ")")
                            End If
                        End If

                        sql = New SqlBox("CrmAsMgt_v4@Update")
                    Case "D"
                        sql = New SqlBox("CrmAsMgt_v4@Delete")
                End Select
                sql.Params("YYMM") = Now.ToString("yyyyMMdd").Substring(2, 4)
                sql.Params("MNGT_NO") = MngtNo
                Select Case drHeader("SYS_ID").ToString
                    Case "CRM", "MAIL"
                        sql.Blocks("CONTENT_Y") = True
                End Select
                YJQuery.SaveRow(db, sql, insflag, drHeader)
                sql.Params("USR_DEPT_CD") = SessionInfo.OrganizationCode
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)

                '20181022 김성은 하단으로 이동
                'sql = New SqlBox("CrmAsMgt_v4@Update2")
                'sql.Params("MNGT_NO") = MngtNo
                'db.SqlSet(sql.Text)


                If Not String.IsNullOrEmpty(drHeader("ORGN_MNGT_NO").ToString) Then
                    sql = New SqlBox("CrmAsMgt_v4@UpdateDataLink")
                    sql.Params("ORGN_MNGT_NO") = drHeader("ORGN_MNGT_NO").ToString
                    sql.Params("PROC_TYPE") = drHeader("PROC_TYPE").ToString
                    sql.Params("RMK") = drHeader("RMK").ToString
                    sql.Params("CMPT_RMK") = drHeader("CMPT_RMK").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                End If


                If Not String.IsNullOrEmpty(drHeader("REQ_USR").ToString) Then
                    sql = New SqlBox("CrmAsMgt_v4@InsertPicInfo")
                    sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
                    If drHeader("REQ_USR").ToString.Trim = "" Then
                        sql.Params("PIC_NM") = " "
                    Else
                        sql.Params("PIC_NM") = drHeader("REQ_USR").ToString
                    End If
                    sql.Params("TEL_NO") = drHeader("TEL_NO").ToString

                    sql.Params("REQ_EMAIL") = drHeader("REQ_EMAIL").ToString
                    If drHeader("REQ_EMAIL").ToString.Trim <> "" Then sql.Blocks("REQ_EMAIL") = True

                    db.SqlSet(sql.Text)
                End If




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

                dt = ds.Tables("WG3")

                For Each DR In dt.Rows
                    Select Case DR("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmAsMgt_v4@InsertWorkDetail")
                        Case "U"
                            sql = New SqlBox("CrmAsMgt_v4@UpdateWorkDetail")
                        Case "D"
                            sql = New SqlBox("CrmAsMgt_v4@DeleteWorkDetail")
                    End Select
                    sql.AllowSqlInjection = True
                    sql.Params("MNGT_NO") = MngtNo
                    sql.Params("SEQ") = DR("SEQ")
                    sql.Params("USR_ID") = DR("USR_ID")
                    sql.Params("TEST_RESULT") = DR("TEST_RESULT")
                    sql.Params("CONTENT") = DR("CONTENT")
                    sql.Params("PROC_TYPE") = DR("PROC_TYPE")
                    sql.Params("DEV_CONTENT") = DR("DEV_CONTENT")
                    sql.Params("ORG_USR_ID") = DR("ORG_USR_ID")
                    sql.Params("REQ_SVC") = drHeader("REQ_SVC").ToString
                    sql.Params("REQ_TYPE") = drHeader("REQ_TYPE").ToString
                    db.SqlSet(sql.Text)
                Next


                dt = ds.Tables("WG_PAY")
                For Each dr In dt.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmAsMgt_v4@InsertPay")
                        Case "U"
                            sql = New SqlBox("CrmAsMgt_v4@UpdatePay")
                        Case "D"
                            sql = New SqlBox("CrmAsMgt_v4@DeletePay")
                    End Select
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    sql.Params("MNGT_NO") = MngtNo
                    YJQuery.SaveRow(db, sql, dr("_INSFLAG"), dr)
                    db.SqlSet(sql.Text)
                Next



                'DEPT_AUTH_LIST / CrmAsDaily 함께 변경필요
                Dim DeptAuth() As String = drHeader("DEPT_AUTH_LIST").ToString.Split(";")
                If DeptAuth.Count = 1 Then
                    Select Case DeptAuth(0)
                        Case "" '기존 공유자료 제외처리
                            '부서 권한 재설정 
                            sql = New SqlBox("CrmAsMgt_v4@UpdateShareFlag")
                            sql.Params("MNGT_NO") = MngtNo
                            sql.Blocks("DEPT_AUTH_LIST") = True
                            db.SqlSet(sql.Text)
                        Case "01"
                            '공유시 'CRM_AS_MST 사용
                            For Each Dept In DeptAuth
                                If String.IsNullOrEmpty(DeptAuth(0)) Then Continue For
                                If insflag <> "I" AndAlso String.IsNullOrEmpty(drHeader("UPPER_MNGT_NO").ToString) Then Continue For

                                '## 공유여부 체크
                                sql = New SqlBox("CrmAsMgt_v4@SearchShare")
                                sql.Params("MNGT_NO") = MngtNo
                                sql.Params("DEPT_CD") = Dept
                                dt = db.SqlGet(sql.Text, False)
                                If dt.Rows.Count <> 0 Then Continue For

                                '## 미등록시에만 적용
                                Dim MngtNoNew As String = String.Empty
                                Dim paramKeyNo As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                                ' Reference Group No 생성
                                Dim yyyyMMdd As String = Now.ToString("yyyyMMdd")
                                paramKeyNo = GenerationKeyNo("MNGT_NO", "", "", yyyyMMdd, "YJIT", "S", "")
                                If ("" & paramKeyNo("TrxCode").ToString) = "E" Then
                                    ThrowMsg(ErrorOccur, "Error while Key No Create Processing! Error Msg: " & paramKeyNo("TrxMsg").ToString)
                                Else
                                    MngtNoNew = paramKeyNo("KEY_NO").ToString
                                End If

                                sql = New SqlBox("CrmAsMgt_v4@InsertShare")
                                sql.Params("MNGT_NO") = MngtNo
                                sql.Params("MNGT_NO_NEW") = MngtNoNew
                                sql.Params("DEPT_CD") = Dept
                                sql.Params("USR_ID") = SessionInfo.UserID
                                db.SqlSet(sql.Text)


                                '신규자료, 온라인접수 처리시 고객지원팀으로 자동공유처시 자료조작
                                If insflag = "I" AndAlso Dept = "01" Then
                                    sql = New SqlBox("CrmAsMgt_v4@UpdateDataModify")
                                    sql.Params("MNGT_NO") = MngtNo
                                    db.SqlSet(sql.Text)
                                End If
                            Next
                        Case Else
                            '부서 권한 재설정 
                            sql = New SqlBox("CrmAsMgt_v4@UpdateShareFlag")
                            sql.Params("MNGT_NO") = MngtNo
                            If String.IsNullOrEmpty(drHeader("DEPT_AUTH_LIST").ToString) Then
                                sql.Blocks("DEPT_AUTH_LIST") = True
                            End If
                            db.SqlSet(sql.Text)

                            '공유시 CRM_AS_MST_WORK 사용
                            For Each Dept In DeptAuth
                                If Dept = "" Then Continue For
                                sql = New SqlBox("CrmAsMgt_v4@InsertShareData")
                                sql.Params("MNGT_NO") = MngtNo
                                sql.Params("DEPT_CD") = Dept
                                db.SqlSet(sql.Text)
                            Next
                            '20191107 김성은 / 개발팀 평가를 위해서 특송,플랫폼 모두 기존방식으로 적용
                            'Case "02", "05", "07", "03", "09"
                            '    '부서 권한 재설정 
                            '    sql = New SqlBox("CrmAsMgt_v4@UpdateShareFlag")
                            '    sql.Params("MNGT_NO") = MngtNo
                            '    db.SqlSet(sql.Text)

                            '    '공유시 CRM_AS_MST_WORK 사용
                            '    For Each Dept In DeptAuth
                            '        If Dept = "" Then Continue For
                            '        sql = New SqlBox("CrmAsMgt_v4@InsertShareData")
                            '        sql.Params("MNGT_NO") = MngtNo
                            '        sql.Params("DEPT_CD") = Dept
                            '        db.SqlSet(sql.Text)
                            '    Next
                            'Case Else
                            '    '공유시 'CRM_AS_MST 사용
                            '    For Each Dept In DeptAuth
                            '        If String.IsNullOrEmpty(DeptAuth(0)) Then Continue For
                            '        If insflag <> "I" AndAlso String.IsNullOrEmpty(drHeader("UPPER_MNGT_NO").ToString) Then Continue For

                            '        '## 공유여부 체크
                            '        sql = New SqlBox("CrmAsMgt_v4@SearchShare")
                            '        sql.Params("MNGT_NO") = MngtNo
                            '        sql.Params("DEPT_CD") = Dept
                            '        dt = db.SqlGet(sql.Text, False)
                            '        If dt.Rows.Count <> 0 Then Continue For



                            '        '## 미등록시에만 적용
                            '        Dim MngtNoNew As String = String.Empty
                            '        Dim paramKeyNo As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                            '        ' Reference Group No 생성
                            '        Dim yyyyMMdd As String = Now.ToString("yyyyMMdd")
                            '        paramKeyNo = GenerationKeyNo("MNGT_NO", "", "", yyyyMMdd, "YJIT", "S", "")
                            '        If ("" & paramKeyNo("TrxCode").ToString) = "E" Then
                            '            ThrowMsg(ErrorOccur, "Error while Key No Create Processing! Error Msg: " & paramKeyNo("TrxMsg").ToString)
                            '        Else
                            '            MngtNoNew = paramKeyNo("KEY_NO").ToString
                            '        End If

                            '        sql = New SqlBox("CrmAsMgt_v4@InsertShare")
                            '        sql.Params("MNGT_NO") = MngtNo
                            '        sql.Params("MNGT_NO_NEW") = MngtNoNew
                            '        sql.Params("DEPT_CD") = Dept
                            '        sql.Params("USR_ID") = SessionInfo.UserID
                            '        db.SqlSet(sql.Text)


                            '        '신규자료, 온라인접수 처리시 고객지원팀으로 자동공유처시 자료조작
                            '        If insflag = "I" AndAlso Dept = "01" Then
                            '            sql = New SqlBox("CrmAsMgt_v4@UpdateDataModify")
                            '            sql.Params("MNGT_NO") = MngtNo
                            '            db.SqlSet(sql.Text)
                            '        End If
                            '    Next
                    End Select

                Else
                    Throw New Exception("타부서공유 정보가 잘못되었습니다. 작업이 취소되었습니다.")
                End If

                If Not String.IsNullOrEmpty(drHeader("WORK_USR").ToString) Then
                    sql = New SqlBox("CrmAsMgtDev@UpdateMergeWorKUsr")
                    sql.Params("MNGT_NO") = MngtNo
                    sql.Params("USR_ID") = drHeader("WORK_USR").ToString
                    sql.Params("SSN_USR_ID") = SessionInfo.UserID
                    db.SqlSet(sql.Text)
                End If

                sql = New SqlBox("CrmAsMgt_v4@Update2")
                sql.Params("MNGT_NO") = MngtNo
                db.SqlSet(sql.Text)


                '## 개발자 자동배정
                If Not String.IsNullOrEmpty(drHeader("DEV_AUTH").ToString) _
                        AndAlso drHeader("DEV_AUTH").ToString <> drHeader("DB_DEV_AUTH").ToString Then
                    sql = New SqlBox("CrmAsMgt_v4@MergeWorkData")
                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    sql.Params("USR_ID") = drHeader("DEV_USR_ID").ToString
                    sql.Params("DEPT_CD") = drHeader("DEPT_AUTH_LIST").ToString
                    sql.Params("PROC_TYPE") = 0
                    sql.Params("REQ_YMD") = drHeader("REQ_YMD")
                    sql.Params("REQ_HM") = drHeader("REQ_HM")
                    sql.Params("RANK") = drHeader("RANK")
                    sql.Params("RMK") = drHeader("RMK")
                    sql.Params("SSN_USR_ID") = SessionInfo.UserID
                    db.SqlSet(sql.Text)
                End If

                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

                resultSet("Data") = Search(ds)("Data")
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return resultSet

        End Function

        Public Shared Function Cancel(ByVal MngtNo As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim dt As DataTable = Nothing

            Try
                db.BeginTransaction()

                If String.IsNullOrEmpty(MngtNo) Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                sql = New SqlBox("CrmAsMgt_v4@CancelCheck")
                sql.Params("MNGT_NO") = MngtNo
                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count <> 0 Then
                    ThrowMsg(ErrorOccur, dt.Rows(0)("DEPT_NM").ToString & " 부서로 공유된 자료입니다. 배정취소할 수 없습니다.")
                End If


                sql = New SqlBox("CrmAsMgt_v4@Cancel")
                sql.Params("MNGT_NO") = MngtNo
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)


                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = Nothing
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

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgt_v4@Search")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                sql.Params("DEPT_CD") = SessionInfo.OrganizationCode
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


                sql = New SqlBox("CrmAsMgt_v4@SearchWorkDetail")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG3"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("CrmAsMgt_v4@SearchPay")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG_PAY"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("CrmAsMgt_v4@SearchHistory")
                sql.Params("CUST_CD") = ResultDs.Tables("MAIN").Rows(0)("CUST_CD").ToString
                sql.Blocks("CUST_CD") = True
                sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"
                sql.Params("DEPT_CD") = drHeader("DEPT_CD").ToString
                sql.Params("ROWNUM") = 200
                sql.Blocks("ROWNUM") = True
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    dt.TableName = "WG41"
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

        Public Shared Function SearchAccount(ByVal CRN As String, CUST_CD As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try
                sql = New SqlBox("CrmAsMgt_v4@SearchAccount")
                sql.Params("CRN") = CRN
                sql.Params("CUST_CD") = CUST_CD
                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "MAIN"
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

        Public Shared Function SearchNew(ByVal ds As DataSet) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgt_v4@SearchNew")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                sql.Params("DEPT_CD") = SessionInfo.OrganizationCode
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


                sql = New SqlBox("CrmAsMgt_v4@SearchWorkDetail")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG3"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("CrmAsMgt_v4@SearchHistory")
                sql.Params("CUST_CD") = ResultDs.Tables("MAIN").Rows(0)("CUST_CD").ToString
                sql.Blocks("CUST_CD") = True
                sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"
                sql.Params("DEPT_CD") = drHeader("DEPT_CD").ToString
                sql.Params("ROWNUM") = 200
                sql.Blocks("ROWNUM") = True
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    dt.TableName = "WG41"
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


        Public Shared Function SearchCustomer(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Dim strCustCd As String = String.Empty
            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmAsMgt_v4@SearchCustomer")
                sql.Params("SEARCH_KEY") = drHeader("CUST_CD").ToString
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                If dt.Rows.Count = 1 Then
                    ResultSet("CUST_CD") = dt.Rows(0)("CUST_CD").ToString
                    ResultSet("CUST_NM") = dt.Rows(0)("CUST_LOC_NM").ToString
                    ResultSet("TEL_NO") = dt.Rows(0)("TEL_NO").ToString
                    ResultSet("CHAIN_YN") = dt.Rows(0)("CHAIN_YN").ToString

                    strCustCd = dt.Rows(0)("CUST_CD").ToString
                ElseIf dt.Rows.Count > 1 Then

                    Dim foundRows As DataRow() = dt.Select("CUST_CD = '" & drHeader("CUST_CD").ToString & "'")
                    If foundRows.Length = 1 Then
                        ResultSet("CUST_CD") = foundRows(0)("CUST_CD").ToString
                        ResultSet("CUST_NM") = foundRows(0)("CUST_LOC_NM").ToString
                        ResultSet("TEL_NO") = foundRows(0)("TEL_NO").ToString
                        ResultSet("CHAIN_YN") = foundRows(0)("CHAIN_YN").ToString

                        strCustCd = foundRows(0)("CUST_CD").ToString
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

                sql = New SqlBox("CrmAsMgt_v4@SearchCustomerPic")
                sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
                sql.Params("SEARCH_KEY") = drHeader("REQ_USR").ToString
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                If dt.Rows.Count = 1 Then
                    ResultSet("PIC_NM") = dt.Rows(0)("PIC_NM").ToString
                    ResultSet("TEL_NO") = dt.Rows(0)("TEL_NO").ToString
                    ResultSet("RANK_NM") = dt.Rows(0)("RANK_NM").ToString
                    ResultSet("EMAIL") = dt.Rows(0)("EMAIL").ToString
                ElseIf dt.Rows.Count > 1 Then

                    Dim foundRows As DataRow() = dt.Select("PIC_NM = '" & drHeader("REQ_USR").ToString & "'")
                    If foundRows.Length = 1 Then
                        ResultSet("PIC_NM") = foundRows(0)("PIC_NM").ToString
                        ResultSet("TEL_NO") = foundRows(0)("TEL_NO").ToString
                        ResultSet("RANK_NM") = foundRows(0)("RANK_NM").ToString
                        ResultSet("EMAIL") = foundRows(0)("EMAIL").ToString
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


        'Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
        '    Dim ResultSet As New Dictionary(Of String, Object)
        '    Dim ResultDs As DataSet = New DataSet
        '    Dim db As DBA = New DBA()
        '    Dim drHeader As DataRow
        '    Dim sql As SqlBox
        '    Dim dt As DataTable
        '    Dim ErrorOccur As Boolean = True
        '    Try

        '        If Not ds.Tables.Contains("MAIN") Then
        '            ThrowMsg(ErrorOccur, "Data info missing.")
        '        End If
        '        drHeader = ds.Tables("MAIN").Rows(0)

        '        sql = New SqlBox("CrmAsMgt_v4@Search")
        '        sql.AllowSqlInjection = True
        '        sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
        '        sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
        '        sql.Params("S_PROC_TYPE") = drHeader("S_PROC_TYPE").ToString.Replace(";", "','").Replace(" ", "")
        '        sql.Params("S_SVC_CD") = drHeader("S_SVC_CD").ToString.Replace(";", "','").Replace(" ", "")
        '        sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
        '        sql.Params("WORK_USR") = drHeader("S_WORK_USR").ToString
        '        sql.Params("S_REQ_SVC") = drHeader("S_REQ_SVC").ToString

        '        If drHeader.Table.Columns.Contains("S_DATE_TYPE") = True Then
        '            If drHeader("S_DATE_TYPE") = "R" Then
        '                sql.Blocks("S_REQ_YMD") = True
        '            ElseIf drHeader("S_DATE_TYPE") = "C" Then
        '                sql.Blocks("S_CMPT_YMD") = True
        '            Else
        '                sql.Blocks("S_REQ_YMD") = True
        '            End If
        '        Else
        '            sql.Blocks("S_REQ_YMD") = True
        '        End If

        '        If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True
        '        If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True
        '        If drHeader("S_PROC_TYPE").ToString <> "" Then sql.Blocks("S_PROC_TYPE") = True
        '        If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("S_SVC_CD") = True
        '        If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
        '        If drHeader("S_WORK_USR").ToString <> "" Then sql.Blocks("WORK_USR") = True
        '        If drHeader("S_REQ_SVC").ToString <> "" Then sql.Blocks("S_REQ_SVC") = True

        '        sql.Params("S_DEPT_CD") = drHeader("S_DEPT_CD").ToString.Replace(";", "','").Replace(" ", "")
        '        sql.Params("S_DEPT_AUTH_LIST") = drHeader("S_DEPT_AUTH_LIST").ToString.Replace(";", "','").Replace(" ", "")
        '        ' 
        '        If drHeader("S_DEPT_CD").ToString <> "" Then sql.Blocks("S_DEPT_CD") = True
        '        If drHeader("S_DEPT_AUTH_LIST").ToString <> "" Then sql.Blocks("S_DEPT_AUTH_LIST") = True

        '        sql.Params("DEPT_CD") = SessionInfo.OrganizationCode

        '        If drHeader("S_PRIORITY").ToString = "Y" Then sql.Blocks("S_PRIORITY") = True

        '        dt = db.SqlGet(sql.Text, False)

        '        If dt.Rows.Count = 0 Then
        '            ThrowMsg(ErrorOccur, "Data not found!")
        '        End If
        '        dt.TableName = "WG1"
        '        ResultDs.Tables.Add(dt)


        '        ResultSet("TrxCode") = "Y"
        '        ResultSet("TrxMsg") = "Success"
        '        ResultSet("Data") = ResultDs

        '    Catch ex As Exception

        '        If ErrorOccur Then
        '            ResultSet("TrxCode") = "E"
        '        Else
        '            ResultSet("TrxCode") = "N"
        '        End If
        '        ResultSet("TrxMsg") = ex.Message
        '    End Try

        '    Return ResultSet
        'End Function

        'Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
        '    Dim resultSet As New Dictionary(Of String, Object)
        '    Dim db As DBA = New DBA()
        '    Dim retDs As DataSet = New DataSet
        '    Dim sql As SqlBox = Nothing
        '    Dim ErrorOccur As Boolean = True
        '    Dim insflag As String = ""
        '    Dim CustCode As String = ""
        '    Try
        '        db.BeginTransaction()

        '        If Not ds.Tables.Contains("MAIN") Then
        '            ThrowMsg(ErrorOccur, "Data info missing.")
        '        End If


        '        Dim dt As DataTable = ds.Tables("WG1")
        '        For Each dr In dt.Rows
        '            Select Case dr("_INSFLAG")
        '                Case "I"
        '                    sql = New SqlBox("CrmAsMgt_v4@Insert")
        '                Case "U"
        '                    sql = New SqlBox("CrmAsMgt_v4@Update")
        '                Case "D"
        '                    sql = New SqlBox("CrmAsMgt_v4@Delete")
        '            End Select
        '            sql.Params("YYMM") = Now.ToString("yyyyMMdd").Substring(2, 4)
        '            sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
        '            sql.Params("REQ_YMD") = dr("REQ_YMD").ToString
        '            sql.Params("REQ_HM") = dr("REQ_HM").ToString
        '            sql.Params("REQ_SVC") = dr("REQ_SVC").ToString
        '            sql.Params("CUST_CD") = dr("CUST_CD").ToString
        '            sql.Params("CONTENT") = dr("CONTENT").ToString
        '            sql.Params("REQ_USR") = dr("REQ_USR").ToString
        '            sql.Params("TEL_NO") = dr("TEL_NO").ToString
        '            sql.Params("PROC_TYPE") = dr("PROC_TYPE").ToString
        '            sql.Params("REQ_TYPE") = dr("REQ_TYPE").ToString
        '            sql.Params("PRIORITY") = dr("PRIORITY").ToString
        '            If dr("PROC_TYPE").ToString = "1" Or dr("PROC_TYPE").ToString = "2" Or
        '                dr("PROC_TYPE").ToString = "7" Or dr("PROC_TYPE").ToString = "8" Then
        '                sql.Params("WORK_USR") = YJIT.SessionInfo.LocalName
        '            Else
        '                sql.Params("WORK_USR") = ""
        '            End If
        '            'sql.Params("WORK_USR") = dr("WORK_USR").ToString
        '            sql.Params("PRAR_YMD") = dr("PRAR_YMD").ToString
        '            If dr("PROC_TYPE").ToString = "1" Or dr("PROC_TYPE").ToString = "2" Then
        '                sql.Params("CMPT_YMD") = Now.ToString("yyyyMMdd")
        '            Else
        '                sql.Params("CMPT_YMD") = ""
        '            End If
        '            'sql.Params("CMPT_YMD") = dr("CMPT_YMD").ToString
        '            sql.Params("RMK") = dr("RMK").ToString
        '            sql.Params("FREE_YN") = dr("FREE_YN").ToString
        '            sql.Params("USR_ID") = YJIT.SessionInfo.UserID
        '            db.SqlSet(sql.Text)
        '        Next

        '        db.Commit()
        '        resultSet("TrxCode") = "Y"
        '        resultSet("TrxMsg") = "Success"
        '    Catch ex As Exception
        '        db.Rollback()
        '        If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
        '        resultSet("TrxMsg") = ex.Message
        '    Finally
        '        db.EndTransaction()
        '    End Try

        '    Return resultSet

        'End Function
        Public Shared Function SearchHistory(ByVal ds As DataSet) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgt_v4@SearchHistory")
                sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
                sql.Blocks("CUST_CD") = True
                sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"
                sql.Params("ROWNUM") = 200
                sql.Blocks("ROWNUM") = True
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    dt.TableName = "WG41"
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
                sql = New SqlBox("CrmAsMgt_v4@Print")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
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
