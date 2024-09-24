Imports System.Data
Imports YJIT.BIZ.Common
Imports YJIT.Data

Namespace YJIT.BIZ

    Public Class AraAcctNoMgt

        Public Shared Function CheckVAAccntNo(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As New DataSet
            Dim db As New DBA()
            Dim dr As DataRow
            Dim dt As DataTable
            Dim err As Boolean = True
            Dim strConn As String = GetConnectionString("110.45.209.61", "1521", "ORCL", "PLISM_ARA", "PLISM_ARA")
            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(err, "Data info missing.")
                End If
                dr = ds.Tables("MAIN").Rows(0)
                Dim sql = New SqlBox("AraAcctNoMgt@CheckFICdVAAccntNo")
                Dim dbARA As New DBA(strConn, "ORACLE")
                sql.Params("FI_CD") = dr("FI_CD").ToString.Trim
                sql.Params("VA_ACCNT_NO") = dr("VA_ACCNT_NO").ToString.Trim
                dt = dbARA.SqlGet(sql.Text, False)

                ResultDs.Tables.Add(dt)
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs
                If dt.Rows.Count = 0 Then
                    ThrowMsg(err, "Data not found!")
                End If
            Catch ex As Exception
                If err Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try
            Return ResultSet
        End Function

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As New DataSet
            Dim db As New DBA()
            Dim dr As DataRow
            Dim dt As DataTable
            Dim dt2 As DataTable
            Dim err As Boolean = True
            Dim strConn As String = GetConnectionString("110.45.209.61", "1521", "ORCL", "PLISM_ARA", "PLISM_ARA")
            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(err, "Data info missing.")
                End If
                dr = ds.Tables("MAIN").Rows(0)
                Dim sql = New SqlBox("AraAcctNoMgt@Search")
                Dim dbARA As New DBA(strConn, "ORACLE")
                dt = dbARA.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                For Each rows As DataRow In dt.Rows
                    sql = New SqlBox("CodeService@CommonCode")
                    sql.Params("LANG_CD") = YJIT.SessionOfficeInfo.LanguageCode
                    sql.Params("KEY") = rows("FI_CD").ToString()
                    sql.Params("GRP_CD") = "N25"
                    sql.Blocks("TYPE_A") = True
                    If rows("FI_CD").ToString() <> "" Then
                        sql.Blocks("SEARCH") = True
                    End If
                    dt2 = db.SqlGet(sql.Text, False)
                    If dt2.Rows.Count = 0 Then
                        Exit For
                    Else
                        If dt2.Rows(0)("NAME") Is Nothing Then
                            rows("BANK_NM") = ""
                        Else
                            rows("BANK_NM") = dt2.Rows(0)("NAME").ToString()
                        End If
                    End If
                Next
                ResultDs.Tables.Add(dt)
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs
                If dt.Rows.Count = 0 Then
                    ThrowMsg(err, "Data not found!")
                End If
            Catch ex As Exception
                If err Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try
            Return ResultSet
        End Function

        Public Shared Function SearchDetail(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As New DataSet
            Dim db As New DBA()
            Dim dr As DataRow
            Dim dt As DataTable
            Dim err As Boolean = True
            Dim strConn As String = GetConnectionString("110.45.209.61", "1521", "ORCL", "PLISM_ARA", "PLISM_ARA")
            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(err, "Data info missing.")
                End If
                dr = ds.Tables("MAIN").Rows(0)
                Dim dbARA As New DBA(strConn, "ORACLE")
                Dim sql = New SqlBox("AraAcctNoMgt@SearchDetail")
                sql.Params("FI_CD") = dr("FI_CD").ToString
                sql.Params("ISSUE_YMD_FROM") = dr("ISSUE_YMD_FROM").ToString
                sql.Params("ISSUE_YMD_TO") = dr("ISSUE_YMD_TO").ToString
                sql.Params("OFFICE_NM") = dr("OFFICE_NM").ToString
                sql.Params("USE_YN") = dr("USE_YN").ToString()
                If Trim(dr("USE_YN")) <> "" Then sql.Blocks("USE_YN") = True
                If Trim(dr("ISSUE_YMD_FROM")) <> "" Then sql.Blocks("ISSUE_YMD_FROM") = True
                If Trim(dr("ISSUE_YMD_TO")) <> "" Then sql.Blocks("ISSUE_YMD_TO") = True
                If Trim(dr("OFFICE_NM")) <> "" Then sql.Blocks("OFFICE_NM") = True

                dt = dbARA.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
                ResultDs.Tables.Add(dt)
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs
                If dt.Rows.Count = 0 Then
                    ThrowMsg(err, "Data not found!")
                End If
            Catch ex As Exception
                If err Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try
            Return ResultSet
        End Function

        Public Shared Function Save(ByVal insFlag As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As New DataSet
            Dim db As New DBA()
            Dim strConn As String = GetConnectionString("110.45.209.61", "1521", "ORCL", "PLISM_ARA", "PLISM_ARA")
            Dim dbARA As New DBA(strConn, "ORACLE")
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable
            Dim Err As Boolean = True
            Dim ErrorMsg As String = ""

            Try
                If Not ds.Tables.Contains("WG2") Then
                    ThrowMsg(Err, "Data info missing.")
                End If
                For Each drHeader As DataRow In ds.Tables("WG2").Rows
                    sql = New SqlBox("AraAcctNoMgt@CheckFICdVABankCd")
                    sql.Params("FI_CD") = drHeader("FI_CD").ToString.Trim
                    sql.Params("VA_ACCNT_NO") = drHeader("VA_ACCNT_NO").ToString.Trim
                    dt = dbARA.SqlGet(sql.Text, False)
                    If dt.Rows(0)("CNT") <> 0 Then
                        If insFlag = "I" Then
                            ThrowMsg(Err, drHeader("VA_ACCNT_NO").ToString.Trim & " : " & "Duplicate Code.")
                        End If
                    End If
                Next
                dbARA.BeginTransaction()
                If insFlag = "I" Then
                    For Each drDetail As DataRow In ds.Tables("WG2").Rows
                        sql = New SqlBox("AraAcctNoMgt@Insert")
                        sql.Params("FI_CD") = drDetail("FI_CD").ToString().Trim
                        sql.Params("VA_ACCNT_NO") = drDetail("VA_ACCNT_NO").ToString().Trim
                        sql.Params("INS_USR") = SessionInfo.UserID
                        dbARA.SqlSet(sql.Text)
                    Next
                    'ElseIf insFlag = "U" Then
                    '    For Each drDetail As DataRow In ds.Tables("WG2").Rows
                    '        sql = New SqlBox("AraAcctNoMgt@Update")
                    '        sql.Params("FI_CD") = drDetail("FI_CD").ToString()
                    '        sql.Params("VA_ACCNT_NO") = drDetail("VA_ACCNT_NO").ToString()
                    '        If Trim(drDetail("USE_YN")) <> "" Then sql.Blocks("USE_YN") = True
                    '        sql.Params("USE_YN") = drDetail("USE_YN").ToString()
                    '        If Trim(drDetail("ISSUE_YMD")) <> "" Then sql.Blocks("ISSUE_YMD") = True
                    '        sql.Params("ISSUE_YMD") = drDetail("ISSUE_YMD").ToString()
                    '        If Trim(drDetail("OFFICE_NM")) <> "" Then sql.Blocks("OFFICE_NM") = True
                    '        sql.Params("OFFICE_NM") = drDetail("OFFICE_NM").ToString()
                    '        If Trim(drDetail("BUNS_NO")) <> "" Then sql.Blocks("BUNS_NO") = True
                    '        sql.Params("BUNS_NO") = drDetail("BUNS_NO").ToString()
                    '        If Trim(drDetail("STORE_ID")) <> "" Then sql.Blocks("STORE_ID") = True
                    '        sql.Params("STORE_ID") = drDetail("STORE_ID").ToString()
                    '        If Trim(drDetail("CURR_CD")) <> "" Then sql.Blocks("CURR_CD") = True
                    '        sql.Params("CURR_CD") = drDetail("CURR_CD").ToString()
                    '        If Trim(drDetail("AMOUNT")) <> "" Then sql.Blocks("AMOUNT") = True
                    '        sql.Params("AMOUNT") = drDetail("AMOUNT").ToString()
                    '        If Trim(drDetail("INV_KEY")) <> "" Then sql.Blocks("INV_KEY") = True
                    '        sql.Params("INV_KEY") = drDetail("INV_KEY").ToString()
                    '        sql.Params("UPD_USR") = SessionInfo.UserID
                    '        Dim retCount As Integer = dbARA.SqlSet(sql.Text)
                    '    Next
                End If
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                dbARA.Commit()
            Catch ex As Exception
                dbARA.Rollback()
                Dim ErrMsg As String = ex.Message & vbCrLf & vbCrLf & ErrorMsg
                If Err Then
                    ResultSet("TrxCode") = "E"
                    ErrMsg &= vbCrLf & sql.Text
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ErrMsg
            Finally
                dbARA.EndTransaction()
            End Try
            Return ResultSet
        End Function

    End Class

End Namespace