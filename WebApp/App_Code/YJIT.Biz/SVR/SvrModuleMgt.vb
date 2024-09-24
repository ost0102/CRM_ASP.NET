Imports System.Data
Imports YJIT.Data

Namespace YJIT.BIZ
    Public Class SvrModuleMgt
        Public Shared Function SaveTable(ByVal db As DBA, ByVal TableName As String, ByRef dt As DataTable) As Integer
            Dim sql As SqlBox = Nothing
            'Dim ErrorOccur As Boolean = True
            Dim dsRet As DataSet = New DataSet
            'Dim MngtNo As String = String.Empty
            Dim iSeq As Integer = 0
            Dim cnt As Integer = 0

            Select Case TableName.ToUpper
                Case "CRM_SERVER_MST"
                    For iRow = dt.Rows.Count - 1 To 0 Step -1
                        iSeq += 1

                        Dim dr As DataRow = dt.Rows(iRow)

                        Select Case dr("_INSFLAG")
                            Case "I"
                                dr("MNGT_NO") = GenerationKeyNo(db, iSeq)

                                sql = New SqlBox("SvrModuleMgt@Insert")
                            Case "U"
                                sql = New SqlBox("SvrModuleMgt@SearchSaveCount")
                                sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                                Dim dt1 As DataTable = db.SqlGet(sql.Text, False)

                                If dt1.Rows.Count > 0 Then
                                    If dt1.Rows(0)("SAVE_CNT").ToString <> dr("SAVE_CNT").ToString Then
                                        Throw New Exception(String.Format("[Server IP] {0}건 자료가 수정되었습니다. 재조회 후 저장해주세요.", dr("SERVER_IP").ToString))
                                    End If
                                End If
                                sql = New SqlBox("SvrModuleMgt@Update")
                            Case "D"
                                sql = New SqlBox("SvrModuleMgt@Delete")
                            Case Else
                                Continue For
                        End Select

                        sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                        YJQuery.SaveRow(db, sql, dr("_INSFLAG"), dr)

                        db.SqlSet(sql.Text)
                    Next
                Case "CRM_SERVER_MODULE"
                    For iRow = dt.Rows.Count - 1 To 0 Step -1
                        iSeq += 1

                        Dim dr As DataRow = dt.Rows(iRow)

                        Select Case dr("_INSFLAG")
                            Case "I"
                                sql = New SqlBox("SvrModuleMgt@InsertModule")
                            Case "U"
                                sql = New SqlBox("SvrModuleMgt@SearchModuleSaveCount")
                                sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                                Dim dt1 As DataTable = db.SqlGet(sql.Text, False)

                                If dt1.Rows.Count > 0 Then
                                    If dt1.Rows(0)("SAVE_CNT").ToString <> dr("SAVE_CNT").ToString Then
                                        Throw New Exception(String.Format("[Server IP] {0}건 자료가 수정되었습니다. 재조회 후 저장해주세요.", dr("SERVER_IP").ToString))
                                    End If
                                End If
                                sql = New SqlBox("SvrModuleMgt@UpdateModule")
                            Case "D"
                                sql = New SqlBox("SvrModuleMgt@DeleteModule")
                            Case Else
                                Continue For
                        End Select

                        sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                        YJQuery.SaveRow(db, sql, dr("_INSFLAG"), dr)

                        db.SqlSet(sql.Text)
                    Next
                Case Else
                    Throw New Exception(String.Format("저장할 테이블 정보가 없습니다."))
            End Select

            Return cnt
        End Function
        Public Shared Function GenerationKeyNo(ByVal db As DBA, Optional ByRef iSeq As Integer = -1) As String
            Dim sql As SqlBox = Nothing
            Dim MngtNo As String = String.Empty
            Dim dt1 As DataTable = Nothing

            If iSeq = -1 Then iSeq = 0

            Dim i As Integer = 1
            MngtNo = String.Empty
            Do While MngtNo = String.Empty
                If iSeq = 999 Then iSeq = 0
                iSeq += 1
                MngtNo = String.Format("{0}{1}{2}", Format(Now, "yyyyMMddHHmmss"), Now.Millisecond.ToString.PadLeft(3, "0"), iSeq.ToString.PadLeft(3, "0"))
                '중복체크
                sql = New SqlBox("SvrModuleMgt@SearchSaveCount")
                sql.Params("MNGT_NO") = MngtNo
                dt1 = db.SqlGet(sql.Text, False)

                If dt1.Rows.Count > 0 Then
                    MngtNo = ""
                    i += 1
                    If i = 10 Then Exit Do
                End If
            Loop

            Return MngtNo
        End Function
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function
        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            'Dim dt As DataTable = Nothing
            'Dim sql As SqlBox = Nothing
            'Dim ErrorOccur As Boolean = True
            Dim dsRet As DataSet = New DataSet
            Dim MngtNo As String = String.Empty
            'Dim iSeq As Integer = 0

            resultSet("TrxCode") = "E"
            resultSet("TrxMsg") = "Error"
            resultSet("Data") = ds

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("WG1") Then
                    Throw New Exception("Grid Data info missing")
                End If

                Call SaveTable(db, "CRM_SERVER_MST", ds.Tables("WG1"))
                If String.IsNullOrEmpty(MngtNo) Then
                    If ds.Tables("WG1").Rows.Count > 0 Then
                        MngtNo = ds.Tables("WG1").Rows(0)("MNGT_NO").ToString
                    End If
                End If

                ''XML TO DATATABLE
                'For Each row As DataRow In ds.Tables("WG1").Rows
                '    If String.IsNullOrEmpty(row("CRM_SERVER_MODULE").ToString) Then Continue For

                '    Dim xmlDetail As System.IO.StringReader = New System.IO.StringReader(row("CRM_SERVER_MODULE").ToString)
                '    Dim dsDetail As DataSet = New DataSet
                '    dsDetail.ReadXml(xmlDetail)

                '    If Not IsNothing(dsDetail.Tables("ROW")) Then
                '        If Not ds.Tables.Contains("WG2") Then
                '            Dim dtWG2 As DataTable = dsDetail.Tables("ROW").Clone
                '            dtWG2.TableName = "WG2"
                '        End If

                '        For Each row2 As DataRow In dsDetail.Tables("ROW").Rows
                '            row2("MNGT_NO") = row("MNGT_NO").ToString
                '            ds.Tables("WG2").Rows.Add(row2)
                '        Next
                '    End If
                'Next
                Call SaveTable(db, "CRM_SERVER_MODULE", ds.Tables("WG2"))
                If String.IsNullOrEmpty(MngtNo) Then
                    If ds.Tables("WG2").Rows.Count > 0 Then
                        MngtNo = ds.Tables("WG2").Rows(0)("MNGT_NO").ToString
                    End If
                End If

                db.Commit()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("MngtNo") = MngtNo
            Catch ex As Exception
                db.Rollback()

                resultSet("TrxCode") = "E"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet
        End Function

        Public Shared Function SearchSchema(ByVal SchemaGroupName As String, ByVal ServerIP As String, ByVal ModuleType As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As New DataTable

            Try
                ResultSet("TrxCode") = "E"
                ResultSet("TrxMsg") = "Error"
                ResultSet("Data") = ResultDs

                If SchemaGroupName.Length = 0 Then
                    Throw New Exception("Data info missing.")
                End If

                Select Case SchemaGroupName.ToUpper
                    Case "ModuleLog".ToUpper
                        sql = New SqlBox("SvrModuleMgt@SearchModule")
                        sql.Params("SERVER_IP") = ServerIP
                        sql.Blocks("SERVER_IP") = True
                        sql.Params("MODULE_TYPE") = ModuleType
                        sql.Blocks("MODULE_TYPE") = True
                        dt = db.SqlGet(sql.Text, False)
                        dt.TableName = "Module"
                        ResultDs.Tables.Add(dt.Copy)

                        sql = New SqlBox("SvrModuleMgt@SearchTableName")
                        sql.Params("TABLE_NAME") = "CRM_SERVER_MODULE_LOG"
                        dt = db.SqlGet(sql.Text, False)
                        dt.TableName = "ModuleLog"
                        ResultDs.Tables.Add(dt.Copy)
                    Case Else
                        ResultSet("TrxCode") = "N"
                        Throw New Exception("Data not found!")
                End Select

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet

        End Function
        Public Shared Function SaveSchema(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As New DataTable

            Try
                ResultSet("TrxCode") = "E"
                ResultSet("TrxMsg") = "Error"
                ResultSet("Data") = ResultDs


                For Each dtTable As DataTable In ds.Tables
                    Select Case dtTable.TableName.ToUpper
                        Case "WCF_CLIENT_INFO".ToUpper, "Module".ToUpper, "ModuleLog".ToUpper
                            '허용
                        Case "ServerInfoLog".ToUpper, "ServerDbLog".ToUpper
                            'ServerCollectInfo 사용 / 허용
                        Case Else
                            Throw New Exception("Data info missing.")
                    End Select
                Next


                For Each Table As DataTable In ds.Tables
                    If Table.TableName.ToUpper = "WCF_CLIENT_INFO".ToUpper Then Continue For
                    If Table.TableName.ToUpper = "Module".ToUpper Then Continue For

                    For Each Row As DataRow In Table.Rows
                        sql = New SqlBox("SvrModuleMgt@Insert" & Table.TableName)
                        YJQuery.SaveRow(db, sql, "I", Row)
                        db.SqlSet(sql.Text)
                    Next
                Next

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet

        End Function

        '20210531 김민석 RPA 모듈 정보 조회용
        Public Shared Function SearchRPAInfo(ByVal OfficeCode As String) As Dictionary(Of String, Object)
            Return SvrInfoLogList.SearchRPAInfo(OfficeCode)
        End Function
        Public Shared Function SearchCRMToElvis(ByVal domain As String) As Dictionary(Of String, Object)
            '20211219 김성은 외부서버에서 CRM 환율 검색하기 위해서 추가
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try
                If String.IsNullOrEmpty(domain) Then
                    Throw New Exception("Data info missing.")
                End If

                Select Case domain.ToUpper
                    Case "KCTCINTL.COM"
                        '승인된 도메인
                    Case "TWSC.ELVIS.COM"
                        '승인된 도메인
                    Case "GEXX.ELVIS.COM"
                        '승인된 도메인
                    Case Else
                        Throw New Exception("Approval Data info missing.")
                End Select

                sql = New SqlBox("MdmExrateMgt@Search2")
                sql.AllowSqlInjection = True

                sql.Params("OFFICE_CD") = "YJIT"
                sql.Params("S_EXRT_YMD") = Now.ToString("yyyyMMdd")
                sql.Params("S_SEQ") = "001"

                If domain = "TWSC.ELVIS.COM" Then
                    sql.Blocks("CURR_CD") = True
                End If

                dt = db.SqlGet(sql.Text, False)

                ResultDs.Tables.Add(dt)

                dt.TableName = "CRM_EX_RATE"


                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            End Try
            Return ResultSet
        End Function
    End Class
End Namespace
