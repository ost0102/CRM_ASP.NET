Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO
Imports System.Data.OracleClient

Namespace YJIT.Biz

    Public Class CrmCustomerMgt

        Public Shared Function Delete(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow

            Try

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                db.BeginTransaction()


                '## Data Log 관리
                Dim logStr As String
                logStr = LogCreate("CRM_CUST_MST", "D", drHeader("CUST_CD").ToString)
                If logStr <> "Y" Then
                    ThrowMsg(ErrorOccur, logStr)
                End If


                sql = New SqlBox("CrmCustomerMgt@Delete")
                sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
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

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet

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
            '    '조회 조건 추가 하실때 , 혹은 drHeader 에서 정보 가져올때 
            '    'If drHeader.Table.Columns.Contains("컬럼명") Then
            '    'END if
            '    '으로 작업 부탁 드리겠습니다 - 이병호
            '    If Not ds.Tables.Contains("MAIN") Then
            '        ThrowMsg(ErrorOccur, "Data info missing.")
            '    End If
            '    drHeader = ds.Tables("MAIN").Rows(0)

            '    sql = New SqlBox("CrmCustomerMgt@SearchMain")
            '    sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
            '    If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
            '    sql.Params("SVC_CD") = drHeader("S_SVC_CD").ToString
            '    sql.Params("USE_YN") = drHeader("S_USE_YN").ToString
            '    sql.Params("CUST_TYPE") = drHeader("S_CUST_TYPE").ToString
            '    If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("SVC_CD") = True
            '    If drHeader("S_USE_YN").ToString <> "" Then sql.Blocks("USE_YN") = True
            '    If drHeader("S_CUST_TYPE").ToString <> "" Then sql.Blocks("CUST_TYPE") = True



            '    If drHeader("S_INFO_YN").ToString = "Y" Then
            '        Select Case drHeader("S_INFO_TYPE").ToString
            '            Case "INFO_YN"
            '                sql.Blocks("INFO_Y") = True
            '            Case "STOP_YN"
            '                sql.Blocks("STOP_Y") = True
            '        End Select
            '    ElseIf drHeader("S_INFO_YN").ToString = "N" Then
            '        Select Case drHeader("S_INFO_TYPE").ToString
            '            Case "INFO_YN"
            '                sql.Blocks("INFO_N") = True
            '            Case "STOP_YN"
            '                sql.Blocks("STOP_N") = True
            '        End Select
            '    End If



            '    dt = db.SqlGet(sql.Text, False)


            '    If dt.Rows.Count = 0 Then
            '        ThrowMsg(ErrorOccur, "Data not found!")
            '    End If
            '    dt.TableName = "WG1"
            '    ResultDs.Tables.Add(dt)

            '    If drHeader.Table.Columns.Contains("CUST_CD") Then
            '        'Office's EDI Info Search
            '        sql = New SqlBox("CrmCustomerMgt@SearchEDIInfo")
            '        sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
            '        dt = db.SqlGet(sql.Text, False)
            '        dt.TableName = "WG6"
            '        ResultDs.Tables.Add(dt)
            '    End If

            '    If drHeader.Table.Columns.Contains("HelpPswdReset") Then
            '        sql = New SqlBox("HelpPswdReset@GetDBInfo")
            '        dt = db.SqlGet(sql.Text, False)
            '        dt.TableName = "DomainList"
            '        ResultDs.Tables.Add(dt)
            '    End If
            '    ResultSet("TrxCode") = "Y"
            '    '성공 유무의 메세지는 생략.
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


        Public Shared Function SearchDetail(ByVal CustCode As String) As Dictionary(Of String, Object)
            Dim ds As DataSet = New DataSet

            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable = Nothing
            Dim ARdt As DataTable = Nothing

            Try
                sql = New SqlBox("CrmCustomerMgt@SearchDetail")
                sql.Params("CUST_CD") = CustCode
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If
                dt.TableName = "Main"
                resultDs.Tables.Add(dt)

                'Server Info
                sql = New SqlBox("CrmCustomerMgt@SearchServer")
                sql.Params("CUST_CD") = CustCode
                sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
                resultDs.Tables.Add(dt)


                sql = New SqlBox("CrmAsMgt_v4@SearchHistory")
                sql.Params("CUST_CD") = CustCode
                sql.Blocks("CUST_CD") = True
                sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"
                sql.Params("ROWNUM") = 50
                sql.Blocks("ROWNUM") = True
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG3"
                resultDs.Tables.Add(dt)


                'ETC Info
                sql = New SqlBox("CrmCustomerMgt@SearchCustInfo")
                sql.Params("CUST_CD") = CustCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG4"
                resultDs.Tables.Add(dt)

                'Office's EDI Info Search
                sql = New SqlBox("CrmCustomerMgt@SearchEDIInfo")
                sql.Params("CUST_CD") = CustCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG6"
                resultDs.Tables.Add(dt)


                sql = New SqlBox("CrmCustomerMgt@SearchCustPic")
                sql.Params("CUST_CD") = CustCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG5"
                resultDs.Tables.Add(dt)


                sql = New SqlBox("CrmCustomerMgt@SearchService")
                sql.Params("CUST_CD") = CustCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG7"
                resultDs.Tables.Add(dt)


                sql = New SqlBox("CrmCustomerMgt@SearchRemark")
                sql.Params("CUST_CD") = CustCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG8"
                resultDs.Tables.Add(dt)


                sql = New SqlBox("CrmCustomerMgt@SearchBilling")
                sql.Params("CUST_CD") = CustCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG9"
                resultDs.Tables.Add(dt)

                '20220814 김성은 조회시 다운증상 있어서 주석처리
                'sql = New SqlBox("CrmCustomerMgt@SearchBillingAmt")
                'sql.Params("CUST_CD") = CustCode
                'dt = db.SqlGet(sql.Text, False)
                'dt.TableName = "WG10"
                'resultDs.Tables.Add(dt)


                sql = New SqlBox("CrmCustomerMgt@SearchJoin")
                sql.Params("CUST_CD") = CustCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG11"
                resultDs.Tables.Add(dt)

                '20240328 김성은, 유경민 별도 검색버튼 추가
                'Try
                '    sql = New SqlBox("CrmCustomerMgt@SearchRPAAuthKey")
                '    sql.Params("CUST_CD") = CustCode
                '    Dim dbRPA As DBA = New DBA(CrmSvcAprMgt.GetConnectionString("RPA", ""), "ORACLE")
                '    dt = dbRPA.SqlGet(sql.Text, False)
                '    dt.TableName = "WG_RPA"
                '    resultDs.Tables.Add(dt)
                'Catch ex As Exception
                '    Throw New Exception(ex.Message & "(RPA)")
                'End Try

                '20240530 김정현 Remark(사업부) 추가
                sql = New SqlBox("CrmCustomerMgt@SearchSalesRemark")
                sql.Params("CUST_CD") = CustCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG12"
                resultDs.Tables.Add(dt)

                sql = New SqlBox("CrmArMgt@Search")
                sql.Params("CUST_CD") = CustCode
                sql.Blocks("CUST_CD") = True
                ARdt = db.SqlGet(sql.Text, False)
                ARdt.TableName = "ARINFO"

                CrmArMgt.SaveARInfo(ARdt)

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
        Public Shared Function SearchDetailRPA(ByVal CustCode As String) As Dictionary(Of String, Object)
            Dim ds As DataSet = New DataSet

            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable = Nothing
            Dim ARdt As DataTable = Nothing

            Try
                sql = New SqlBox("CrmCustomerMgt@SearchRPAAuthKey")
                sql.Params("CUST_CD") = CustCode

                Dim dbRPA As DBA = New DBA(CrmSvcAprMgt.GetConnectionString("RPA", ""), "ORACLE")
                dt = dbRPA.SqlGet(sql.Text, False)
                dt.TableName = "WG_RPA"

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

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            Dim insflag As String = ""
            Dim CustCode As String = ""
            Dim dt2 As DataTable = Nothing

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                Dim dr As DataRow = ds.Tables("MAIN").Rows(0)


                If dr("CUST_CD").ToString = "" Then
                    insflag = "I"
                    sql = New SqlBox("CrmCustomerMgt@KeyCreate")
                    dt2 = db.SqlGet(sql.Text, True)
                    CustCode = dt2.Rows(0)("CUST_CD").ToString

                    dr("CUST_CD") = dt2.Rows(0)("CUST_CD").ToString
                Else
                    sql = New SqlBox("CrmCustomerMgt@CheckCustCode")
                    sql.Params("CUST_CD") = dr("CUST_CD").ToString
                    dt2 = db.SqlGet(sql.Text, False)
                    If dt2.Rows.Count = 0 Then
                        insflag = "I"
                    Else
                        insflag = "U"
                    End If
                    CustCode = dr("CUST_CD").ToString
                End If



                '## Data Log 관리
                Dim logStr As String
                logStr = LogCreate("CRM_CUST_MST", insflag, CustCode)
                If logStr <> "Y" Then
                    ThrowMsg(ErrorOccur, logStr)
                End If



                If insflag = "I" Then
                    sql = New SqlBox("CrmCustomerMgt@InsertMain")
                Else
                    sql = New SqlBox("CrmCustomerMgt@UpdateMain")
                End If
                YJQuery.SaveRow(db, sql, insflag, dr)
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)


                'UPDATE REMARK
                'sql = New SqlBox("CrmCustomerMgt@UpdateRemark")
                'sql.Params("CUST_CD") = CustCode
                'sql.Params("RMK") = dr("RMK").ToString
                'db.SqlSet(sql.Text)

                'Server 정보 
                Dim dt As DataTable = ds.Tables("WG2")
                For Each dr2 In dt.Rows
                    dr2("CUST_CD") = CustCode

                    Select Case dr2("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmCustomerMgt@InsertServer")
                        Case "U"
                            sql = New SqlBox("CrmCustomerMgt@UpdateServer")
                        Case "D"
                            sql = New SqlBox("CrmCustomerMgt@DeleteServer")
                    End Select
                    YJQuery.SaveRow(db, sql, insflag, dr2)
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"

                    'sql.Params("CUST_CD") = CustCode
                    'sql.Params("SEQ") = dr2("SEQ").ToString
                    'sql.Params("SVR_TYPE") = dr2("SVR_TYPE").ToString
                    'sql.Params("SVR_IP") = dr2("SVR_IP").ToString
                    'sql.Params("SVR_DESC") = dr2("SVR_DESC").ToString
                    'sql.Params("WIN_ID") = dr2("WIN_ID").ToString
                    'sql.Params("WIN_PWD") = dr2("WIN_PWD").ToString
                    'sql.Params("DB_ID") = dr2("DB_ID").ToString
                    'sql.Params("DB_PWD") = dr2("DB_PWD").ToString
                    'sql.Params("DB_PORT") = dr2("DB_PORT").ToString
                    'sql.Params("DB_SID") = dr2("DB_SID").ToString
                    'sql.Params("TV_ID") = dr2("TV_ID").ToString
                    'sql.Params("TV_PWD") = dr2("TV_PWD").ToString
                    'sql.Params("ORA_VER") = dr2("ORA_VER").ToString
                    'sql.Params("RMK") = dr2("RMK").ToString
                    'sql.Params("MAIN_YN") = dr2("MAIN_YN").ToString
                    'sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    ''20150720 손홍일 아래TNS 빠져있어서 추가
                    'sql.Params("DB_TNS") = dr2("DB_TNS").ToString
                    db.SqlSet(sql.Text)
                Next


                '기타 정보
                dt = ds.Tables("WG4")
                For Each dr2 In dt.Rows
                    Select Case dr2("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmCustomerMgt@InsertCustInfo")
                        Case "U"
                            sql = New SqlBox("CrmCustomerMgt@UpdateCustInfo")
                        Case "D"
                            sql = New SqlBox("CrmCustomerMgt@DeleteCustInfo")
                    End Select
                    sql.Params("CUST_CD") = CustCode
                    YJQuery.SaveRow(db, sql, dr2("_INSFLAG"), dr2)
                    'sql.Params("ITEM_CD") = dr2("ITEM_CD").ToString
                    'sql.Params("ITEM_VAL") = dr2("ITEM_VAL").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

                '담당자 정보
                dt = ds.Tables("WG5")
                For Each dr3 In dt.Rows
                    Select Case dr3("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmCustomerMgt@InsertCustPic")
                        Case "U"
                            sql = New SqlBox("CrmCustomerMgt@UpdateCustPic")
                        Case "D"
                            sql = New SqlBox("CrmCustomerMgt@DeleteCustPic")
                    End Select
                    sql.Params("CUST_CD") = CustCode
                    YJQuery.SaveRow(db, sql, dr3("_INSFLAG"), dr3)
                    'sql.Params("PIC_NM") = dr3("PIC_NM").ToString
                    'sql.Params("RANK") = dr3("RANK").ToString
                    'sql.Params("TEL_NO") = dr3("TEL_NO").ToString
                    'sql.Params("MOBILE") = dr3("MOBILE").ToString
                    'sql.Params("EMAIL") = dr3("EMAIL").ToString
                    'If dr3("MAIN_YN").ToString <> "" Then
                    '    sql.Params("MAIN_YN") = dr3("MAIN_YN").ToString
                    'Else
                    '    sql.Params("MAIN_YN") = "N"
                    'End If

                    'sql.Params("RMK") = dr3("RMK").ToString
                    'sql.Params("SEQ") = dr3("SEQ").ToString()
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)

                Next


                'Office's EDI Info Save
                dt = ds.Tables("WG6")
                For Each dr4 As DataRow In dt.Rows
                    'Office's EDI Info Check
                    If dr4("_INSFLAG") = "I" Then
                        sql = New SqlBox("CrmCustomerMgt@SearchEDIInfoCount")
                        sql.Params("CUST_CD") = CustCode
                        sql.Params("EDI_SYS_CD") = dr4("EDI_SYS_CD").ToString
                        dt = db.SqlGet(sql.Text, False)

                        If dt.Rows.Count > 0 Then
                            ThrowMsg(ErrorOccur, "EDI data already exists!")
                        End If
                    End If

                    Select Case dr4("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmCustomerMgt@InsertEDIInfo")
                        Case "U"
                            sql = New SqlBox("CrmCustomerMgt@UpdateEDIInfo")
                        Case "D"
                            sql = New SqlBox("CrmCustomerMgt@DeleteEDIInfo")
                        Case Else
                            Continue For
                    End Select

                    sql.Params("CUST_CD") = CustCode
                    YJQuery.SaveRow(db, sql, insflag, dr4)
                    'sql.Params("EDI_SYS_CD") = dr4("EDI_SYS_CD").ToString
                    'sql.Params("EDI_SYS_NM") = dr4("EDI_SYS_NM").ToString
                    'sql.Params("ID") = dr4("ID").ToString
                    'sql.Params("PWD") = dr4("PWD").ToString
                    'sql.Params("SENDER_ID") = dr4("SENDER_ID").ToString
                    'sql.Params("MAIL_BOX_ID") = dr4("MAIL_BOX_ID").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID


                    db.SqlSet(sql.Text)
                Next



                dt = ds.Tables("WG7")
                For Each dr7 In dt.Rows
                    dr7("CUST_CD") = CustCode

                    Select Case dr7("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmCustomerMgt@InsertService")
                        Case "U"
                            sql = New SqlBox("CrmCustomerMgt@UpdateService")
                        Case "D"
                            sql = New SqlBox("CrmCustomerMgt@DeleteService")
                        Case Else
                            Continue For
                    End Select
                    YJQuery.SaveRow(db, sql, insflag, dr7)
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next


                dt = ds.Tables("WG8")
                For Each dr8 In dt.Rows
                    dr8("CUST_CD") = CustCode

                    Select Case dr8("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmCustomerMgt@InsertRemark")
                        Case "U"
                            sql = New SqlBox("CrmCustomerMgt@UpdateRemark")
                        Case "D"
                            sql = New SqlBox("CrmCustomerMgt@DeleteRemark")
                        Case Else
                            Continue For
                    End Select
                    YJQuery.SaveRow(db, sql, insflag, dr8)
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next


                dt = ds.Tables("WG9")
                For Each dr9 In dt.Rows
                    dr9("CUST_CD") = CustCode

                    Select Case dr9("_INSFLAG")
                        Case "I"
                            Select Case dr9("SVC_TYPE").ToString
                                Case "S"
                                    sql = New SqlBox("CrmCustomerMgt@SearchBilling")
                                    sql.Params("CUST_CD") = CustCode
                                    sql.Params("SVC_TYPE") = dr9("SVC_TYPE").ToString
                                    sql.Blocks("SVC_TYPE") = True
                                    Dim dtRet As DataTable = db.SqlGet(sql.Text, False)
                                    If dtRet.Rows.Count > 0 Then
                                        ThrowMsg(ErrorOccur, "Duplicate fax sending information.")
                                    End If
                            End Select

                            sql = New SqlBox("CrmCustomerMgt@InsertBilling")
                        Case "U"
                            sql = New SqlBox("CrmCustomerMgt@UpdateBilling")
                        Case "D"
                            sql = New SqlBox("CrmCustomerMgt@DeleteBilling")
                        Case Else
                            Continue For
                    End Select
                    YJQuery.SaveRow(db, sql, insflag, dr9)
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

                If ds.Tables.Contains("WG11") = True Then
                    dt = ds.Tables("WG11")
                    For Each dr11 In dt.Rows
                        dr11("CUST_CD") = CustCode

                        Select Case dr11("_INSFLAG")
                            Case "I"
                                sql = New SqlBox("CrmCustomerMgt@InsertJoin")
                            Case "U"
                                sql = New SqlBox("CrmCustomerMgt@UpdateJoin")
                            Case "D"
                                sql = New SqlBox("CrmCustomerMgt@DeleteJoin")
                            Case Else
                                Continue For
                        End Select
                        YJQuery.SaveRow(db, sql, insflag, dr11)
                        sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                        db.SqlSet(sql.Text)
                    Next
                End If

                '20240530 김정현 Remark(사업부) 추가
                dt = ds.Tables("WG12")
                For Each dr12 In dt.Rows
                    dr12("CUST_CD") = CustCode

                    Select Case dr12("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmCustomerMgt@InsertSalesRemark")
                        Case "U"
                            sql = New SqlBox("CrmCustomerMgt@UpdateSalesRemark")
                        Case "D"
                            sql = New SqlBox("CrmCustomerMgt@DeleteSalesRemark")
                        Case Else
                            Continue For
                    End Select
                    YJQuery.SaveRow(db, sql, insflag, dr12)
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

                If ds.Tables.Contains("WG_RPA") = True Then
                    Try
                        dt = ds.Tables("WG_RPA")
                        For Each drRPA In dt.Rows
                            drRPA("CUST_CD") = CustCode

                            Select Case drRPA("_INSFLAG")
                                Case "I"
                                    sql = New SqlBox("CrmCustomerMgt@InsertRPAAuthKey")
                                Case "U"
                                '수정기능 미제공
                                Case "D"
                                    '삭제기능 미제공
                                Case Else
                                    Continue For
                            End Select
                            YJQuery.SaveRow(db, sql, insflag, drRPA)
                            sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                            Dim dbRPA As DBA = New DBA(CrmSvcAprMgt.GetConnectionString("RPA", ""), "ORACLE")
                            dbRPA.SqlSet(sql.Text)
                        Next
                    Catch ex As Exception
                        Throw New Exception(ex.Message & "(RPA)")
                    End Try
                End If

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


            Try
                Dim confStr As String = DbConfiguration.ActiveSessionDBConnStr
                Dim CN = New OracleConnection(confStr)
                Dim sqlStr As New StringBuilder

                sqlStr.AppendLine("UPDATE CRM_CUST_MST ")
                sqlStr.AppendLine("	  SET RMK = :RMK")
                sqlStr.AppendLine(" WHERE CUST_CD = :CUST_CD")

                Dim SqlCom As New OracleCommand(sqlStr.ToString(), CN)
                SqlCom.Parameters.Add(New OracleParameter(":RMK", ds.Tables("MAIN").Rows(0)("RMK").ToString))
                SqlCom.Parameters.Add(New OracleParameter(":CUST_CD", ds.Tables("MAIN").Rows(0)("CUST_CD").ToString))

                CN.Open()
                SqlCom.ExecuteNonQuery()
                CN.Close()
                SqlCom.Dispose()
            Catch ex As Exception
                resultSet("TrxMsg") = "기본정보는 저장이 완료되었으며, Remark(Sheet) 항목만 저장에 실패했습니다." & vbCrLf & "(" & ex.Message & ")"
            End Try

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = SearchDetail(CustCode)("Data")
            End If

            Return resultSet

        End Function
        'Print
        Public Shared Function Print(ByVal CustCode As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim sql As SqlBox
            ' 결과 값 object
            ' 성공/실패 Status 를 항상 리턴한다.
            Dim db As DBA = New DBA()
            Dim ResultDs As DataSet = New DataSet
            Dim drHeader As DataRow = Nothing
            Dim ErrorOccur As Boolean = False
            Dim dt As DataTable
            Dim cLastYM As String = Nothing

            Try

                sql = New SqlBox("CrmCustomerMgt@Print")
                sql.Params("CUST_CD") = CustCode
                sql.Params("USER_NM") = SessionInfo.LocalName
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "HeaderInfo"
                ResultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                '성공 유무의 메세지는 생략.
                resultSet("TrxMsg") = "Success."
                resultSet("Data") = ResultDs
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            End Try


            Return resultSet

        End Function


        Public Shared Function LogCreate(ByVal TableName As String, ByVal insFlag As String, ByVal MngtNo As String) As String
            Dim db As DBA = New DBA()
            Dim rtnStr As String = "Y"

            Try
                Dim param As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                param("P_TNAME") = TableName
                param("P_FLAG") = insFlag
                param("P_MNGT_NO") = MngtNo
                param("P_USR_ID") = YJIT.SessionInfo.UserID
                param("R_RTNCD") = ""
                param("R_RTNMSG") = ""
                db.ExecuteProcedure("USP_CREATE_LOG", param)
                If ("" & param("R_RTNCD").ToString) = "E" Then
                    rtnStr = "Error while Log Create Processing!" & vbCrLf & " Error Msg: " & param("R_RTNMSG").ToString
                End If
            Catch ex As Exception
                rtnStr = ex.Message
            End Try

            Return rtnStr

        End Function


        Public Shared Function Execute(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = False
            Dim sql As SqlBox = Nothing
            Dim db As DBA = New DBA
            Dim resultDs As New DataSet
            Dim drHeader As DataRow
            Dim dtCustMst As New DataTable

            drHeader = ds.Tables("MAIN").Rows(0)

            sql = New SqlBox("CrmCustomerMgt@DBInfo")
            sql.Params("DOMAIN") = drHeader("DOMAIN").ToString
            '20220721 정지수 DB LINK ELVIS_PLUS 추가 YJITS2022070292
            If drHeader("SVC_CD").ToString = "E21" Then
                sql.Blocks("ELVIS_PLUS") = True
            Else
                sql.Blocks("ELVIS") = True
            End If
            dtCustMst = db.SqlGet(sql.Text, False)

            If dtCustMst.Rows.Count = 0 Then
                resultSet("TrxCode") = "E"
                resultSet("TrxMsg") = "서버정보 등록이 누락되었습니다."
                resultSet("Data") = resultDs
                Return resultSet
            Else
                If String.IsNullOrEmpty(dtCustMst.Rows(0)("DB_IP_EXT").ToString) Then
                    resultSet("TrxCode") = "E"
                    resultSet("TrxMsg") = "공인IP 등록이 누락되었습니다."
                    resultSet("Data") = resultDs
                    Return resultSet
                End If
            End If


            Dim conn As OracleConnection = SysDBMgt.getConnection(dtCustMst.Rows(0)("DB_IP").ToString,
                                                                dtCustMst.Rows(0)("DB_PORT").ToString,
                                                                dtCustMst.Rows(0)("DB_SID").ToString,
                                                                dtCustMst.Rows(0)("USR_ID").ToString,
                                                                dtCustMst.Rows(0)("USR_PWD").ToString)

            Dim transaction As OracleTransaction

            Try
                Try
                    conn.Open()
                Catch ex As Exception
                    conn = SysDBMgt.getConnection(dtCustMst.Rows(0)("DB_IP_EXT").ToString,
                                            dtCustMst.Rows(0)("DB_PORT").ToString,
                                            dtCustMst.Rows(0)("DB_SID").ToString,
                                            dtCustMst.Rows(0)("USR_ID").ToString,
                                            dtCustMst.Rows(0)("USR_PWD").ToString)
                    conn.Open()
                End Try

                transaction = conn.BeginTransaction()

                Dim sqlStr As String = String.Empty
                sqlStr &= " UPDATE MDM_OFFICE_MST "
                sqlStr &= "    SET USER_CNT = '" & drHeader("USER_QTY").ToString & "' "
                sqlStr &= "      , UPD_USR = '" & SessionInfo.UserID & "' "
                sqlStr &= "      , UPD_YMD = UFN_DATE_FORMAT('DATE') "
                sqlStr &= "      , UPD_HM = UFN_DATE_FORMAT('TIME') "
                sqlStr &= "  WHERE OFFICE_CD = '" & drHeader("ELVIS_OFFICE_CD").ToString & "' "
                sqlStr &= "    AND ORG_LVL = 'LB'; "

                For Each subSql As String In sqlStr.Split(";")
                    If subSql.Trim <> "" Then
                        Dim cmd As New OracleCommand(subSql)
                        cmd.Connection = conn
                        cmd.Transaction = transaction
                        cmd.ExecuteNonQuery()
                    End If
                Next

                transaction.Commit()


                sqlStr = ""
                sqlStr &= " UPDATE CRM_CUST_MST " & vbNewLine
                sqlStr &= "    SET USER_QTY = '" & drHeader("USER_QTY").ToString & "' " & vbNewLine
                sqlStr &= "      , UPD_USR = '" & SessionInfo.UserID & "' " & vbNewLine
                sqlStr &= "      , UPD_YMD = UFN_DATE_FORMAT('DATE') " & vbNewLine
                sqlStr &= "      , UPD_HM = UFN_DATE_FORMAT('TIME') " & vbNewLine
                sqlStr &= "  WHERE CUST_CD = '" & drHeader("CUST_CD").ToString & "' "
                db.SqlSet(sqlStr)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

            Catch ex As Exception
                resultSet("TrxCode") = "E"
                resultSet("TrxMsg") = ex.Message
                resultSet("Data") = resultDs

                transaction.Rollback()
            Finally
                conn.Close()
                conn.Dispose()
            End Try


            Return resultSet

        End Function

        '20240425 김정현 미수금액 갱신 로직 추가
        Public Shared Function RefreshRecAmt(ByVal CRN As String, ByVal CustCd As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = True

            db.BeginTransaction()
            Try
                Dim param As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
                param("P_CRN") = CRN
                param("P_CUST_CD") = CustCd
                param("R_RTNCD") = ""
                param("R_RTNMSG") = ""
                db.ExecuteProcedure("USP_ACT_CRM_REC_AMT_CUST", param)
                If ("" & param("R_RTNCD").ToString) = "E" Then
                    ThrowMsg(ErrorOccur, param("R_RTNMSG").ToString)
                End If
                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                resultSet("TrxCode") = "E"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return resultSet
        End Function
    End Class
End Namespace
