Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common
Namespace YJIT.Biz

    Public Class CrmAsDaily
  Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function


        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim dtWG1 As DataTable
            Dim dtCHK As DataTable
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)

                dtWG1 = ds.Tables("WG1")

                For Each dr As DataRow In dtWG1.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            Dim MngtNo As String = String.Empty
                            Dim i As Integer = 1
                            Do While MngtNo = String.Empty
                                MngtNo = String.Format("{0}{1}", Format(Now, "yyyyMMddHHmmss"), Now.Millisecond)
                                '중복체크
                                sql = New SqlBox("CrmAsDaily@Search")
                                sql.Params("MNGT_NO") = MngtNo
                                sql.Blocks("MNGT_NO") = True
                                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                                If dt.Rows.Count > 0 Then
                                    MngtNo = ""
                                    i += 1
                                    If i = 10 Then Exit Do
                                End If
                            Loop
                            dr("MNGT_NO") = MngtNo

                            sql = New SqlBox("CrmAsDaily@Insert")
                        Case "U"
                            sql = New SqlBox("CrmAsDaily@Update")
                        Case "D"
                            sql = New SqlBox("CrmAsDaily@Delete")
                        Case Else
                            Continue For
                    End Select
                    sql.Params("SYS_ID") = "CRM"
                    sql.Params("WORK_USR") = YJIT.SessionInfo.LocalName
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    YJQuery.SaveRow(db, sql, dr("_INSFLAG"), dr)
                    db.SqlSet(sql.Text)


                    'DEPT_AUTH_LIST / CrmAsMgt_v4 함께 변경필요
                    Dim DeptAuth() As String = dr("DEPT_AUTH_LIST").ToString.Split(";")
                    If DeptAuth.Count = 1 Then
                        Select Case DeptAuth(0)
                            Case "" '기존 공유자료 제외처리
                                '부서 권한 재설정 
                                sql = New SqlBox("CrmAsMgt_v4@UpdateShareFlag")
                                sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                                sql.Blocks("DEPT_AUTH_LIST") = True
                                db.SqlSet(sql.Text)
                            Case "01"
                                '공유시 'CRM_AS_MST 사용
                                For Each Dept In DeptAuth
                                    If String.IsNullOrEmpty(DeptAuth(0)) Then Continue For
                                    'CrmAsMgt_v4만 사용
                                    'If dr("_INSFLAG").ToString <> "I" AndAlso String.IsNullOrEmpty(drHeader("UPPER_MNGT_NO").ToString) Then Continue For

                                    '## 공유여부 체크
                                    sql = New SqlBox("CrmAsMgt_v4@SearchShare")
                                    sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                                    sql.Params("DEPT_CD") = Dept
                                    dtCHK = db.SqlGet(sql.Text, False)
                                    If dtCHK.Rows.Count <> 0 Then Continue For

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
                                    sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                                    sql.Params("MNGT_NO_NEW") = MngtNoNew
                                    sql.Params("DEPT_CD") = Dept
                                    sql.Params("USR_ID") = SessionInfo.UserID
                                    db.SqlSet(sql.Text)


                                    '신규자료, 온라인접수 처리시 고객지원팀으로 자동공유처시 자료조작
                                    If dr("_INSFLAG").ToString = "I" AndAlso Dept = "01" Then
                                        sql = New SqlBox("CrmAsMgt_v4@UpdateDataModify")
                                        sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                                        db.SqlSet(sql.Text)
                                    End If
                                Next
                            Case Else
                                '부서 권한 재설정 
                                sql = New SqlBox("CrmAsMgt_v4@UpdateShareFlag")
                                sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                                If String.IsNullOrEmpty(dr("DEPT_AUTH_LIST").ToString) Then
                                    sql.Blocks("DEPT_AUTH_LIST") = True
                                End If
                                db.SqlSet(sql.Text)

                                '공유시 CRM_AS_MST_WORK 사용
                                For Each Dept In DeptAuth
                                    If Dept = "" Then Continue For
                                    sql = New SqlBox("CrmAsMgt_v4@InsertShareData")
                                    sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                                    sql.Params("DEPT_CD") = Dept
                                    db.SqlSet(sql.Text)
                                Next
                        End Select
                    Else
                        Throw New Exception("타부서공유 정보가 잘못되었습니다. 작업이 취소되었습니다.")
                    End If

                    '## 개발자 자동배정
                    If Not String.IsNullOrEmpty(dr("DEV_AUTH").ToString) _
                            AndAlso dr("DEV_AUTH").ToString <> dr("DB_DEV_AUTH").ToString Then
                        sql = New SqlBox("CrmAsMgt_v4@MergeWorkData")
                        sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                        sql.Params("USR_ID") = dr("DEV_USR_ID").ToString
                        sql.Params("DEPT_CD") = dr("DEPT_AUTH_LIST").ToString
                        sql.Params("PROC_TYPE") = 0
                        sql.Params("REQ_YMD") = dr("REQ_YMD")
                        sql.Params("REQ_HM") = dr("REQ_HM")
                        sql.Params("RANK") = dr("RANK")
                        sql.Params("RMK") = dr("RMK")
                        sql.Params("SSN_USR_ID") = SessionInfo.UserID
                        db.SqlSet(sql.Text)
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
