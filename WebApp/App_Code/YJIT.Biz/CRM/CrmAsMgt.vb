Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz
    Public Class CrmAsMgt
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

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                Dim paramKeyNo As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                ' Reference Group No 생성
                Dim groupNo As String = Nothing
                Dim yyyyMMdd As String = Now.ToString("yyyyMMdd")
                paramKeyNo = GenerationKeyNo("MNGT_NO", "", "", yyyyMMdd, "YJIT", "S", "")
                If ("" & paramKeyNo("TrxCode").ToString) = "E" Then
                    ThrowMsg(ErrorOccur, "Error while Key No Create Processing! Error Msg: " & paramKeyNo("TrxMsg").ToString)
                Else
                    groupNo = paramKeyNo("KEY_NO").ToString
                End If

                If drHeader("MNGT_NO").ToString <> "" Then
                    insflag = "U"
                    MngtNo = drHeader("MNGT_NO").ToString
                Else
                    insflag = "I"
                    MngtNo = groupNo
                End If

                Select Case insflag
                    Case "I"
                        sql = New SqlBox("CrmAsMgt@Insert")
                    Case "U"
                        sql = New SqlBox("CrmAsMgt@Update")
                    Case "D"
                        sql = New SqlBox("CrmAsMgt@Delete")
                End Select
                sql.Params("YYMM") = Now.ToString("yyyyMMdd").Substring(2, 4)
                sql.Params("MNGT_NO") = MngtNo
                sql.Params("USR_DEPT_CD") = SessionInfo.OrganizationCode
                'sql.Params("REQ_YMD") = drHeader("REQ_YMD").ToString
                'sql.Params("REQ_HM") = drHeader("REQ_HM").ToString
                'sql.Params("REQ_SVC") = drHeader("REQ_SVC").ToString
                'sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
                'sql.Params("CONTENT") = drHeader("CONTENT").ToString
                'sql.Params("REQ_USR") = drHeader("REQ_USR").ToString
                'sql.Params("TEL_NO") = drHeader("TEL_NO").ToString
                'sql.Params("PROC_TYPE") = drHeader("PROC_TYPE").ToString
                'sql.Params("REQ_TYPE") = drHeader("REQ_TYPE").ToString
                'sql.Params("PRIORITY") = drHeader("PRIORITY").ToString
                'sql.Params("WORK_USR") = drHeader("WORK_USR").ToString
                'sql.Params("PRAR_YMD") = drHeader("PRAR_YMD").ToString
                'sql.Params("CMPT_YMD") = drHeader("CMPT_YMD").ToString
                'sql.Params("RMK") = drHeader("RMK").ToString
                'sql.Params("FREE_YN") = drHeader("FREE_YN").ToString
                'sql.Params("USR_ID") = YJIT.SessionInfo.UserID

                YJQuery.SaveRow(db, sql, insflag, drHeader)
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)


                If Not String.IsNullOrEmpty(drHeader("REQ_USR").ToString) Then
                    sql = New SqlBox("CrmAsMgt@InsertPicInfo")
                    sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
                    If drHeader("REQ_USR").ToString.Trim = "" Then
                        sql.Params("PIC_NM") = " "
                    Else
                        sql.Params("PIC_NM") = drHeader("REQ_USR").ToString
                    End If
                    sql.Params("TEL_NO") = drHeader("TEL_NO").ToString
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



                dt = ds.Tables("WG4")

                For Each DR In dt.Rows
                    Select Case DR("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmAsMgt_v2@InsertWorkDetail")
                        Case "U"
                            sql = New SqlBox("CrmAsMgt_v2@UpdateWorkDetail")
                        Case "D"
                            sql = New SqlBox("CrmAsMgt_v2@DeleteWorkDetail")
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
                    db.SqlSet(sql.Text)
                Next



                'DEPT_AUTH_LIST
                Dim sqlTxt As String = ""

                Dim DeptAuth() As String = drHeader("DEPT_AUTH_LIST").ToString.Split(";")
                For Each Dept In DeptAuth
                    If Dept = "" Then Continue For
                    sql = New SqlBox("CrmAsMgt_v2@InsertShareData")
                    sql.Params("MNGT_NO") = MngtNo
                    sql.Params("DEPT_CD") = Dept
                    sqlTxt &= sql.Text & ";" & vbCrLf
                Next

                '작업자 
                sql = New SqlBox("CrmAsMgtDev@DeleteWorkUser")
                sql.Params("MNGT_NO") = MngtNo
                db.SqlSet(sql.Text)

                Dim WorkUsr() As String = drHeader("WORK_USR_LIST").ToString.Split(";")
                For Each Usr In WorkUsr
                    If Usr = "" Then Continue For
                    sql = New SqlBox("CrmAsMgtDev@UpdateMergeWorKUsr")
                    sql.Params("MNGT_NO") = MngtNo
                    sql.Params("USR_ID") = Usr
                    sql.Params("SSN_USR_ID") = SessionInfo.UserID
                    'sql.Params("WORK_TYPE") = "WORK"
                    'sql.Params("WORK_VALUE") = "N"
                    sqlTxt &= sql.Text & ";" & vbCrLf
                Next


                If sqlTxt <> "" Then
                    db.SqlSet("BEGIN " & vbCrLf & sqlTxt & vbCrLf & "END;")
                End If


                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

                'If drHeader("WORK_USR").ToString = "이병호" Then
                '    If insflag = "I" Then
                '        sql = New SqlBox("CrmAsMgt@SearchToUserID")
                '        sql.Params("LOC_NM") = drHeader("WORK_USR").ToString
                '        sql.Params("FLAG") = insflag
                '        dt = db.SqlGet(sql.Text, False)
                '        dt.TableName = "UserList"
                '        retDs.Tables.Add(dt)
                '    Else
                '        sql = New SqlBox("CrmAsMgt@SearchInsertUser")
                '        sql.Params("MNGT_NO") = MngtNo
                '        sql.Params("FLAG") = insflag
                '        dt = db.SqlGet(sql.Text, False)
                '        dt.TableName = "UserList"
                '        retDs.Tables.Add(dt)
                '    End If
                'End If

                sql = New SqlBox("ComDocumentMgt@Search")
                sql.Params("MNGT_NO") = MngtNo
                If MngtNo <> "" Then sql.Blocks("MNGT_NO") = True
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
                retDs.Tables.Add(dt)

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

                sql = New SqlBox("CrmAsMgt@SearchInput")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
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


                If ds.Tables.Contains("WG3") = True Then
                    '단일검색 성공시 기타 정보 포함
                    sql = New SqlBox("CrmCustomerMgt@SearchMain")
                    sql.Params("CUST_CD") = ResultDs.Tables("MAIN").Rows(0)("CUST_CD").ToString
                    sql.Blocks("CUST_CD") = True
                    sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"
                    dt = db.SqlGet(sql.Text, False)
                    If dt.Rows.Count > 0 Then
                        dt.TableName = "WG1"
                        ResultDs.Tables.Add(dt)
                    End If

                    sql = New SqlBox("CrmAsMgt@Search")
                    sql.Params("CUST_CD") = ResultDs.Tables("MAIN").Rows(0)("CUST_CD").ToString
                    sql.Blocks("CUST_CD") = True
                    sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"
                    sql.Params("ROWNUM") = 50
                    sql.Blocks("ROWNUM") = True

                    dt = db.SqlGet(sql.Text, False)
                    If dt.Rows.Count > 0 Then
                        dt.TableName = "WG3"
                        ResultDs.Tables.Add(dt)
                    End If



                    sql = New SqlBox("CrmAsMgt_v2@SearchWorkDetail")
                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    dt = db.SqlGet(sql.Text, False)
                    dt.TableName = "WG4"
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

                sql = New SqlBox("CrmAsMgt@SearchCustomer")
                sql.Params("SEARCH_KEY") = drHeader("CUST_CD").ToString
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                If dt.Rows.Count = 1 Then
                    ResultSet("CUST_CD") = dt.Rows(0)("CUST_CD").ToString
                    ResultSet("CUST_NM") = dt.Rows(0)("CUST_LOC_NM").ToString
                    ResultSet("TEL_NO") = dt.Rows(0)("TEL_NO").ToString

                    strCustCd = dt.Rows(0)("CUST_CD").ToString
                ElseIf dt.Rows.Count > 1 Then

                    Dim foundRows As DataRow() = dt.Select("CUST_CD = '" & drHeader("CUST_CD").ToString & "'")
                    If foundRows.Length = 1 Then
                        ResultSet("CUST_CD") = foundRows(0)("CUST_CD").ToString
                        ResultSet("CUST_NM") = foundRows(0)("CUST_LOC_NM").ToString
                        ResultSet("TEL_NO") = foundRows(0)("TEL_NO").ToString

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

                If ds.Tables.Contains("WG3") = True Then
                    If Not String.IsNullOrEmpty(strCustCd) Then
                        '단일검색 성공시 기타 정보 포함
                        sql = New SqlBox("CrmCustomerMgt@SearchMain")
                        sql.Params("CUST_CD") = strCustCd
                        sql.Blocks("CUST_CD") = True
                        sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"

                        dt = db.SqlGet(sql.Text, False)
                        If dt.Rows.Count > 0 Then
                            dt.TableName = "WG1"
                            ResultDs.Tables.Add(dt)
                        End If

                        sql = New SqlBox("CrmAsMgt@Search")
                        sql.Params("CUST_CD") = strCustCd
                        sql.Blocks("CUST_CD") = True
                        sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"
                        sql.Params("ROWNUM") = 50
                        sql.Blocks("ROWNUM") = True

                        dt = db.SqlGet(sql.Text, False)
                        If dt.Rows.Count > 0 Then
                            dt.TableName = "WG3"
                            ResultDs.Tables.Add(dt)
                        End If
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

                sql = New SqlBox("CrmAsMgt@SearchCustomerPic")
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
                ElseIf dt.Rows.Count > 1 Then

                    Dim foundRows As DataRow() = dt.Select("PIC_NM = '" & drHeader("REQ_USR").ToString & "'")
                    If foundRows.Length = 1 Then
                        ResultSet("PIC_NM") = foundRows(0)("PIC_NM").ToString
                        ResultSet("TEL_NO") = foundRows(0)("TEL_NO").ToString
                        ResultSet("RANK_NM") = foundRows(0)("RANK_NM").ToString
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

            'Dim ResultSet As New Dictionary(Of String, Object)
            'Dim ResultDs As DataSet = New DataSet
            'Dim db As DBA = New DBA()
            'Dim drHeader As DataRow
            'Dim sql As SqlBox
            'Dim dt As DataTable
            'Dim ErrorOccur As Boolean = True
            'Try

            '    If Not ds.Tables.Contains("MAIN") Then
            '        ThrowMsg(ErrorOccur, "Data info missing.")
            '    End If
            '    drHeader = ds.Tables("MAIN").Rows(0)

            '    sql = New SqlBox("CrmAsMgt@Search")
            '    sql.AllowSqlInjection = True
            '    sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
            '    sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
            '    sql.Params("S_PROC_TYPE") = drHeader("S_PROC_TYPE").ToString.Replace(";", "','").Replace(" ", "")
            '    sql.Params("S_SVC_CD") = drHeader("S_SVC_CD").ToString.Replace(";", "','").Replace(" ", "")
            '    sql.Params("S_MNGT_NO") = drHeader("S_MNGT_NO").ToString
            '    sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
            '    sql.Params("SEARCH_PR") = drHeader("S_SEARCH_PR").ToString

            '    If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
            '    If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True
            '    If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True
            '    If drHeader("S_PROC_TYPE").ToString <> "" Then sql.Blocks("S_PROC_TYPE") = True
            '    If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("S_SVC_CD") = True
            '    If drHeader("S_SEARCH_PR").ToString <> "" Then sql.Blocks("WORK_USR") = True
            '    If drHeader("S_PRIORITY").ToString = "Y" Then sql.Blocks("PRIORITY") = True


            '    dt = db.SqlGet(sql.Text, False)

            '    If dt.Rows.Count = 0 Then
            '        ThrowMsg(ErrorOccur, "Data not found!")
            '    End If
            '    dt.TableName = "WG1"
            '    ResultDs.Tables.Add(dt)
            '    ResultSet("TrxCode") = "Y"

            '    ResultSet("TrxMsg") = "Success"
            '    ResultSet("Data") = ResultDs

            'Catch ex As Exception

            '    If ErrorOccur Then
            '        ResultSet("TrxCode") = "E"
            '    Else
            '        ResultSet("TrxCode") = "N"
            '    End If
            '    ResultSet("TrxMsg") = ex.Message
            'End Try

            'Return ResultSet
        End Function



        Public Shared Function SearchOld(ByVal ds As DataSet) As Dictionary(Of String, Object)
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

                sql = New SqlBox("CrmAsMgt@Search")
                sql.AllowSqlInjection = True
                sql.Params("FM_YMD") = drHeader("FM_YMD").ToString
                sql.Params("TO_YMD") = drHeader("TO_YMD").ToString
                sql.Params("S_PROC_TYPE") = drHeader("S_PROC_TYPE").ToString.Replace(";", "','").Replace(" ", "")
                sql.Params("S_SVC_CD") = drHeader("S_SVC_CD").ToString.Replace(";", "','").Replace(" ", "")
                sql.Params("S_MNGT_NO") = drHeader("S_MNGT_NO").ToString
                sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
                sql.Params("WORK_USR") = drHeader("S_WORK_USR").ToString

                If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
                If drHeader("FM_YMD").ToString <> "" Then sql.Blocks("FM_YMD") = True
                If drHeader("TO_YMD").ToString <> "" Then sql.Blocks("TO_YMD") = True
                If drHeader("S_PROC_TYPE").ToString <> "" Then sql.Blocks("S_PROC_TYPE") = True
                If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("S_SVC_CD") = True
                If drHeader("S_WORK_USR").ToString <> "" Then sql.Blocks("WORK_USR") = True
                If drHeader("S_PRIORITY").ToString = "Y" Then sql.Blocks("PRIORITY") = True


                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
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

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim insflag As String = ""
            Dim CustCode As String = ""
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If


                Dim dt As DataTable = ds.Tables("WG1")
                For Each dr In dt.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmAsMgt@Insert")
                        Case "U"
                            sql = New SqlBox("CrmAsMgt@Update")
                        Case "D"
                            sql = New SqlBox("CrmAsMgt@Delete")
                    End Select
                    sql.Params("YYMM") = Now.ToString("yyyyMMdd").Substring(2, 4)
                    sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                    sql.Params("REQ_YMD") = dr("REQ_YMD").ToString
                    sql.Params("REQ_HM") = dr("REQ_HM").ToString
                    sql.Params("REQ_SVC") = dr("REQ_SVC").ToString
                    sql.Params("CUST_CD") = dr("CUST_CD").ToString
                    sql.Params("CONTENT") = dr("CONTENT").ToString
                    sql.Params("REQ_USR") = dr("REQ_USR").ToString
                    sql.Params("TEL_NO") = dr("TEL_NO").ToString
                    sql.Params("PROC_TYPE") = dr("PROC_TYPE").ToString
                    sql.Params("REQ_TYPE") = dr("REQ_TYPE").ToString
                    sql.Params("PRIORITY") = dr("PRIORITY").ToString
                    If dr("PROC_TYPE").ToString = "1" Or dr("PROC_TYPE").ToString = "2" Or
                        dr("PROC_TYPE").ToString = "7" Or dr("PROC_TYPE").ToString = "8" Then
                        sql.Params("WORK_USR") = YJIT.SessionInfo.LocalName
                    Else
                        sql.Params("WORK_USR") = ""
                    End If
                    'sql.Params("WORK_USR") = dr("WORK_USR").ToString
                    sql.Params("PRAR_YMD") = dr("PRAR_YMD").ToString
                    If dr("PROC_TYPE").ToString = "1" Or dr("PROC_TYPE").ToString = "2" Then
                        sql.Params("CMPT_YMD") = Now.ToString("yyyyMMdd")
                    Else
                        sql.Params("CMPT_YMD") = ""
                    End If
                    'sql.Params("CMPT_YMD") = dr("CMPT_YMD").ToString
                    sql.Params("RMK") = dr("RMK").ToString
                    sql.Params("FREE_YN") = dr("FREE_YN").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
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

            Return resultSet

        End Function




    End Class
End Namespace
