Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.BIZ

    Public Class CrmTwmsMgt

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

            '    'If Not ds.Tables.Contains("MAIN") Then
            '    '    ThrowMsg(ErrorOccur, "Data info missing.")
            '    'End If
            '    'drHeader = ds.Tables("MAIN").Rows(0)

            '    sql = New SqlBox("CrmTwmsMgt@Search")
            '    sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
            '    If drHeader("SEARCH_KEY").ToString <> "" Then sql.Blocks("SEARCH_KEY") = True
            '    sql.Params("SVC_CD") = drHeader("S_SVC_CD").ToString
            '    sql.Params("USE_YN") = drHeader("S_USE_YN").ToString
            '    sql.Params("CUST_TYPE") = drHeader("S_CUST_TYPE").ToString
            '    If drHeader("S_SVC_CD").ToString <> "" Then sql.Blocks("SVC_CD") = True
            '    If drHeader("S_USE_YN").ToString <> "" Then sql.Blocks("USE_YN") = True
            '    If drHeader("S_CUST_TYPE").ToString <> "" Then sql.Blocks("CUST_TYPE") = True
            '    dt = db.SqlGet(sql.Text, False)

            '    If dt.Rows.Count = 0 Then
            '        ThrowMsg(ErrorOccur, "Data not found!")
            '    End If
            '    dt.TableName = "WG1"
            '    ResultDs.Tables.Add(dt)
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

        Public Shared Function Search_detail(ByVal CUST_CD As String) As Dictionary(Of String, Object)

            ' 결과 값 object
            ' 성공/실패 Status 를 항상 리턴한다.
            Dim resultSet As New Dictionary(Of String, Object)

            Dim db As DBA = New DBA()
            'Oracle 접속 (오더 정보를 Ms Sql에 저장 후 
            Dim retDs As DataSet = New DataSet
            Dim Session As HttpSessionState = HttpContext.Current.Session       ' 세션 정보
            Dim retCount As Integer = 0                                         ' SQL 실행 결과 수 (디버깅 용)

            ' ============== 클라이언트에서 보내온 자료에 대한 VALIDATION ========================

            ' 세션에서 필요한 정보 존재성 검토 (클래스 재 컴파일 시 세션이 사라짐)
            If YJIT.SessionInfo.UserID Is Nothing Then
                Throw New Exception("Invalid Session")
            End If

            Dim sql As SqlBox

            Try


                '== 출고정보 조회
                sql = New SqlBox("CrmTwmsMgt@Search_Detail")

                sql.Params("CUST_CD") = CUST_CD
                sql.Params("CRYPTO_KEY") = "Yjit1!43#2^3"

                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                dt.TableName = "WG1"
                retDs.Tables.Add(dt)

                resultSet("Status") = "SUCCESS"
                resultSet("Data") = retDs

            Catch ex As Exception
                ' Transaction Rollback

                ' 에러 전달
                resultSet("Status") = "FAILED"
                'resultSet("StatusMessage") = ex.Message
            Finally

            End Try

            'resultSet("SearchResult") = Search(ds)
            Return resultSet

        End Function

        Public Shared Function CUST_CHK(ByVal CUST_CD As String) As Dictionary(Of String, Object)

            ' 결과 값 object
            ' 성공/실패 Status 를 항상 리턴한다.
            Dim resultSet As New Dictionary(Of String, Object)

            Dim db As DBA = New DBA()
            'Oracle 접속 (오더 정보를 Ms Sql에 저장 후 
            Dim retDs As DataSet = New DataSet
            Dim Session As HttpSessionState = HttpContext.Current.Session       ' 세션 정보
            Dim retCount As Integer = 0                                         ' SQL 실행 결과 수 (디버깅 용)

            ' ============== 클라이언트에서 보내온 자료에 대한 VALIDATION ========================

            ' 세션에서 필요한 정보 존재성 검토 (클래스 재 컴파일 시 세션이 사라짐)
            If YJIT.SessionInfo.UserID Is Nothing Then
                Throw New Exception("Invalid Session")
            End If

            Dim sql As SqlBox

            Try

                '== 거래처 조회
                sql = New SqlBox("CrmTwmsMgt@CUST_CHK")

                sql.Params("CUST_CD") = CUST_CD

                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                dt.TableName = "CUST_CHK"
                retDs.Tables.Add(dt)

                resultSet("Data") = retDs

            Catch ex As Exception
            Finally
            End Try

            'resultSet("SearchResult") = Search(ds)
            Return resultSet

        End Function

        'Public Sub GridInit()
        '    Dim PopUp As PopupBase
        '    Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        '    Dim searchParams As Dictionary(Of String, Object)
        '    Dim dataParams As Dictionary(Of String, Object)

        '    PopUp = New PopupBase
        '    PopUp.ItemAdd(Action.Excel, "WG1_EXCEL", "Export Excel", True)
        '    PopUp.PopUpInit(Me, WG1)

        '    Dim dt2 As New DataTable
        '    dt2.Columns.Add(New DataColumn("CODE", GetType(String)))
        '    dt2.Columns.Add(New DataColumn("NAME", GetType(String)))

        '    AddNewRow(dt2, "E", "ELVIS")
        '    AddNewRow(dt2, "O", "ELVIS(Etc)")
        '    AddNewRow(dt2, "V", "일반")
        '    AddNewRow(dt2, "T", "T/S")
        '    AddNewRow(dt2, "M", "적하목록")
        '    AddNewRow(dt2, "Z", "기타")
        '    AddNewRow(dt2, "L", "운송")
        '    AddNewRow(dt2, "W", "WMS")
        '    AddNewRow(dt2, "B", "보세")
        '    AddNewRow(dt2, "C", "쿠리어")
        '    AddNewRow(dt2, "A", "대리점")
        '    AddNewRow(dt2, "H", "인사급여")

        '    editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        '    editorCombo.DisplayMember = "NAME"
        '    editorCombo.ValueMember = "CODE"
        '    editorCombo.NullText = ""
        '    editorCombo.DataSource = dt2.Copy
        '    GV1.Columns("SVC_CD").ColumnEdit = editorCombo


        '    editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        '    editorCombo.ValueMember = "CODE"
        '    editorCombo.DisplayMember = "NAME"
        '    editorCombo.NullText = " "
        '    searchParams = New Dictionary(Of String, Object)
        '    dataParams = New Dictionary(Of String, Object)
        '    dataParams.Add("GroupCode", "C03")
        '    dataParams.Add("NameType", "")
        '    dataParams.Add("Valid", "V")
        '    editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        '    GV1.Columns("DEPT_CD").ColumnEdit = editorCombo
        'End Sub
        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable = Nothing
            Dim ErrorOccur As Boolean = True
            Dim cnt As Integer = 0


            resultSet("TrxCode") = "E"
            resultSet("TrxMsg") = "Error"

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    Throw New Exception("Data info missing.")
                End If
                If Not ds.Tables.Contains("WG1") Then
                    If ds.Tables("WG1").Rows.Count = 0 Then
                        If Not ds.Tables.Contains("WG2") Then
                            Throw New Exception("Grid Data info missing.")
                        End If
                        If ds.Tables("WG2").Rows.Count = 0 Then
                            Throw New Exception("Grid Data info missing.")
                        End If
                    End If
                End If




                Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)

                For Each dr As DataRow In ds.Tables("WG1").Rows
                    '## Key No 생성
                    If dr("_INSFLAG").ToString = "I" Then
                        Dim i As Integer = 1
                        Do While String.IsNullOrEmpty(dr("CUST_CD").ToString)
                            'dr("MNGT_NO") = String.Format("{0}{1}", Format(Now, "yyyyMMddHHmmss"), Now.Millisecond)
                            '중복체크
                            sql = New SqlBox("CrmTwmsMgt@Search")
                            sql.Params("CUST_CD") = dr("CUST_CD")
                            sql.Blocks("CUST_CD") = True
                            dt = db.SqlGet(sql.Text, False)

                            If dt.Rows.Count > 0 Then
                                dr("CUST_CD") = ""
                                If i = 10 Then Exit Do
                            End If
                        Loop
                    End If


                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmTwmsMgt@CUST_CHK")
                            sql.Params("CUST_CD") = dr("CUST_CD")
                            sql.Blocks("CUST_CD") = True
                            dt = db.SqlGet(sql.Text, False)

                            If dt.Rows.Count > 0 Then
                                Throw New Exception("이미 만들어진 거래처 코드 입니다.")
                            End If

                            sql = New SqlBox("CrmTwmsMgt@Insert")
                            sql.Params("INP_USR") = YJIT.SessionInfo.UserID

                        Case "U"
                            If dr("CUST_CD") = "" Then
                                Throw New Exception("Grid Data info missing.")
                            End If
                            sql = New SqlBox("CrmTwmsMgt@Update")
                            sql.Params("CUST_CD") = dr("CUST_CD")
                            sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                        Case "D"
                            If dr("CUST_CD") = "" Then
                                Throw New Exception("Grid Data info missing.")
                            End If
                            sql = New SqlBox("CrmTwmsMgt@Delete")
                            sql.Params("CUST_CD") = dr("CUST_CD")
                    End Select
                    sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID
                    YJQuery.SaveRow(db, sql, dr("_INSFLAG"), dr)
                    db.SqlSet(sql.Text)

                    cnt += 1
                Next

                For Each dr As DataRow In ds.Tables("WG2").Rows

                    Select Case dr("_INSFLAG")
                        Case "I"

                        Case "U"
                            If dr("CUST_CD") = "" Then
                                Throw New Exception("Grid Data info missing.")
                            End If
                            sql = New SqlBox("CrmTwmsMgt@Update")
                            sql.Params("CUST_CD") = dr("CUST_CD")
                            sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                        Case "D"

                    End Select
                    sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID
                    YJQuery.SaveRow(db, sql, dr("_INSFLAG"), dr)
                    db.SqlSet(sql.Text)

                    cnt += 1
                Next


                db.Commit()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet
        End Function


        Private Shared Function SaveTable(ByVal db As DBA, ByVal TableName As String, ByRef dt As DataTable) As Integer
            Dim cnt As Integer = 0
            Dim Sql As SqlBox = Nothing

            Select Case TableName.ToUpper
                Case "WMS_DB_INFO"
                    For Each dr As DataRow In dt.Rows
                        Select Case dr("_INSFLAG")
                            Case "I"
                                Sql = New SqlBox("CrmTwmsMgt@Insert")
                            Case "U"
                                Sql = New SqlBox("CrmTwmsMgt@Update")
                            Case "D"
                                Sql = New SqlBox("CrmTwmsMgt@Delete")
                        End Select
                        Sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID
                        YJQuery.SaveRow(db, Sql, dr("_INSFLAG"), dr)
                        db.SqlSet(Sql.Text)

                        cnt += 1
                    Next
            End Select

            Return cnt
        End Function

    End Class
End Namespace
