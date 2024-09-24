Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Exception
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.Biz.Common
Imports System.Windows.Forms

Namespace YJIT.Biz
    Public Class EchAccountExcelUpDown
        
        Public Shared Function SearchAFR(ByVal ds As DataSet, ByVal vJob As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable

            Dim ErrorOccur As Boolean = True

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                If vJob = "FIND" Then
                    drHeader = ds.Tables("MAIN").Rows(0)

                    sql = New SqlBox("EchAccountExcelUpDown@SearchAFR")
                    sql.AllowSqlInjection = True
                    sql.Params("SEARCH_TYPE") = drHeader("SEARCH_TYPE").ToString
                    sql.Params("DOC_STR_YYYYMM") = yjitSubstr(drHeader("S_STR_YMD").ToString, 0, 6)
                    sql.Params("DOC_END_YYYYMM") = yjitSubstr(drHeader("S_END_YMD").ToString, 0, 6)

                    sql.Params("CUST_CD") = drHeader("S_ECH_CUST_CD").ToString.Trim
                    sql.Params("CUST_LOC_NM") = drHeader("S_ECH_CUST_NM").ToString.Trim
                    sql.Params("CUSTOMS_4CODE") = drHeader("S_ECH_4CODE").ToString.Trim

                    If drHeader("S_END_YMD").ToString <> "" Then
                        sql.Blocks("END_YMD") = True
                    End If

                    If drHeader("S_ECH_CUST_CD").ToString.Trim <> "" Then
                        sql.Blocks("CUST_CD") = True
                    End If

                    If drHeader("S_ECH_CUST_NM").ToString.Trim <> "" Then
                        sql.Blocks("CUST_NM") = True
                    End If

                    If drHeader("S_ECH_4CODE").ToString.Trim <> "" Then
                        sql.Blocks("CUSTOMS_4CODE") = True
                    End If

                    sql.Blocks("SelectAFR") = True
                    dt = db.SqlGet(sql.Text, False)
                Else
                    For Each dr As DataRow In ds.Tables("WG2").Rows
                        If dr("DOC_YYYYMM").ToString <> "" Then
                            sql = New SqlBox("EchAccountExcelUpDown@SearchAFR")
                            sql.AllowSqlInjection = True
                            sql.Params("CUSTOMS_4CD") = dr("CUSTOMS_4CODE").ToString
                            sql.Params("KL_SNDID") = dr("SND_ID").ToString
                            sql.Params("SND_GUBUN") = "KLAFR"

                            sql.Blocks("CRMCode") = True
                            dt = db.SqlGet(sql.Text, False)

                            If dt.Rows.Count > 0 Then
                                dr("CUST_CD") = dt.Rows(0)("CUST_CD").ToString
                                dr("CUST_LOC_NM") = dt.Rows(0)("CUST_LOC_NM").ToString
                                dr("CUSTOMS_4CODE") = dt.Rows(0)("CHAIN_ID").ToString

                                sql = New SqlBox("EchAccountExcelUpDown@SearchAFR")
                                sql.AllowSqlInjection = True
                                sql.Params("DOC_YYYYMM") = dr("DOC_YYYYMM").ToString
                                sql.Params("CUSTOMS_4CD") = dr("CUSTOMS_4CODE").ToString

                                sql.Blocks("SendData") = True
                                dt = db.SqlGet(sql.Text, False)

                                If dt.Rows.Count > 0 Then
                                    dr("CHAIN_HBL_COUNT") = dt.Rows(0)("BL_COUNT")
                                Else
                                    dr("CHAIN_HBL_COUNT") = 0
                                End If
                            Else
                                dr("CUST_CD") = ""
                                dr("CUST_LOC_NM") = ""
                                dr("CUSTOMS_4CODE") = ""
                            End If

                            If Not dr("KL_HBL_COUNT") Is DBNull.Value And Not dr("CHAIN_HBL_COUNT") Is DBNull.Value Then
                                If dr("KL_HBL_COUNT") <> dr("CHAIN_HBL_COUNT") Then
                                    dr("BL_CNT_CK") = "Y"
                                End If
                            End If

                            If dr("KL_HBL_COUNT") Is DBNull.Value And Not dr("CHAIN_HBL_COUNT") Is DBNull.Value Then
                                dr("BL_CNT_CK") = "Y"
                            End If

                            If Not dr("KL_HBL_COUNT") Is DBNull.Value And dr("CHAIN_HBL_COUNT") Is DBNull.Value Then
                                dr("BL_CNT_CK") = "Y"
                            End If
                        End If
                    Next
                    dt.Clear()
                    dt = ds.Tables("WG2").Copy
                End If

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

        Public Shared Function ReloadCRMInfo(ByVal vCustoms4Code As String, ByVal strYYYYMM As String, ByVal vTab As String, ByVal vKLSENDID As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ResultDt As DataTable = New DataTable("ReLoad")
            Dim SNDID As String = ""

            Dim ErrorOccur As Boolean = True

            Try
                If vCustoms4Code = "" Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                If vTab = "AFR" Then
                    SNDID = "KL_AFRID"
                Else
                    SNDID = "KL_MFCSID"
                End If

                sql = New SqlBox("EchAccountExcelUpDown@SearchAFR")
                sql.AllowSqlInjection = True
                sql.Params("CUSTOMS_4CD") = vCustoms4Code
                sql.Params("SND_GUBUN") = SNDID
                sql.Params("KL_SNDID") = vKLSENDID

                sql.Blocks("CRMCode") = True
                dt = db.SqlGet(sql.Text, False)

                ResultDt.Columns.Add("CUST_CD", GetType(String))
                ResultDt.Columns.Add("CUST_LOC_NM", GetType(String))
                ResultDt.Columns.Add("CHAIN_HBL_COUNT", GetType(Integer))

                If dt.Rows.Count > 0 Then

                    ResultDt.Rows.Add(dt.Rows(0)("CUST_CD").ToString, dt.Rows(0)("CUST_LOC_NM").ToString, 0)

                    If vTab = "AFR" Then
                        sql = New SqlBox("EchAccountExcelUpDown@SearchAFR")
                        sql.AllowSqlInjection = True
                        sql.Params("DOC_YYYYMM") = strYYYYMM
                        sql.Params("CUSTOMS_4CD") = vCustoms4Code

                        sql.Blocks("SendData") = True
                        dt = db.SqlGet(sql.Text, False)

                        If dt.Rows.Count > 0 Then
                            ResultDt.Rows(0)("CHAIN_HBL_COUNT") = dt.Rows(0)("BL_COUNT")
                        Else
                            ResultDt.Rows(0)("CHAIN_HBL_COUNT") = 0
                        End If
                    End If
                Else
                    ResultDt.Rows.Add("", "", 0)
                End If

                ResultDs.Tables.Add(ResultDt)
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

        Public Shared Function SearchMFCS(ByVal ds As DataSet, ByVal vJob As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable

            Dim ErrorOccur As Boolean = True

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                If vJob = "FIND" Then
                    drHeader = ds.Tables("MAIN").Rows(0)

                    sql = New SqlBox("EchAccountExcelUpDown@SearchMFCS")
                    sql.AllowSqlInjection = True
                    sql.Params("SEARCH_TYPE") = drHeader("SEARCH_TYPE").ToString
                    sql.Params("DOC_STR_YYYYMM") = yjitSubstr(drHeader("S_STR_YMD").ToString, 0, 6)
                    sql.Params("DOC_END_YYYYMM") = yjitSubstr(drHeader("S_END_YMD").ToString, 0, 6)
                    sql.Params("CUST_CD") = drHeader("S_ECH_CUST_CD").ToString.Trim
                    sql.Params("CUST_LOC_NM") = drHeader("S_ECH_CUST_NM").ToString.Trim
                    sql.Params("CUSTOMS_4CODE") = drHeader("S_ECH_4CODE").ToString.Trim

                    If drHeader("S_END_YMD").ToString.Trim <> "" Then
                        sql.Blocks("END_YMD") = True
                    End If

                    If drHeader("S_ECH_CUST_CD").ToString.Trim <> "" Then
                        sql.Blocks("CUST_CD") = True
                    End If

                    If drHeader("S_ECH_CUST_NM").ToString.Trim <> "" Then
                        sql.Blocks("CUST_NM") = True
                    End If

                    If drHeader("S_ECH_4CODE").ToString.Trim <> "" Then
                        sql.Blocks("CUSTOMS_4CODE") = True
                    End If

                    sql.Blocks("SelectMFCS") = True
                    dt = db.SqlGet(sql.Text, False)
                Else
                    For Each dr As DataRow In ds.Tables("WG1").Rows
                        If dr("DOC_YYYYMM").ToString <> "" Then
                            sql = New SqlBox("EchAccountExcelUpDown@SearchAFR")
                            sql.AllowSqlInjection = True
                            sql.Params("CUSTOMS_4CD") = dr("CUSTOMS_4CODE").ToString
                            sql.Params("KL_SNDID") = dr("SND_ID").ToString
                            sql.Params("SND_GUBUN") = "KLMFCS"

                            sql.Blocks("CRMCode") = True
                            dt = db.SqlGet(sql.Text, False)

                            If dt.Rows.Count > 0 Then
                                dr("CUST_CD") = dt.Rows(0)("CUST_CD").ToString
                                dr("CUST_LOC_NM") = dt.Rows(0)("CUST_LOC_NM").ToString
                                dr("CUSTOMS_4CODE") = dt.Rows(0)("CHAIN_ID").ToString
                            Else
                                dr("CUST_CD") = ""
                                dr("CUST_LOC_NM") = ""
                                dr("CUSTOMS_4CODE") = ""
                            End If

                        End If
                    Next
                    dt.Clear()
                    dt = ds.Tables("WG1").Copy
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

        Public Shared Function SearchUDR(ByVal ds As DataSet, ByVal vJob As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim RetDt As DataTable
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable

            Dim ErrorOccur As Boolean = True

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                If vJob = "FIND" Then
                    sql = New SqlBox("EchAccountExcelUpDown@SearchMFCS")
                    sql.AllowSqlInjection = True
                    sql.Params("SEARCH_TYPE") = drHeader("SEARCH_TYPE").ToString
                    sql.Params("DOC_STR_YYYYMM") = yjitSubstr(drHeader("S_STR_YMD").ToString, 0, 6)
                    sql.Params("DOC_END_YYYYMM") = yjitSubstr(drHeader("S_END_YMD").ToString, 0, 6)
                    sql.Params("CUST_CD") = drHeader("S_ECH_CUST_CD").ToString.Trim
                    sql.Params("CUST_LOC_NM") = drHeader("S_ECH_CUST_NM").ToString.Trim
                    sql.Params("CUSTOMS_4CODE") = drHeader("S_ECH_4CODE").ToString.Trim

                    If drHeader("S_END_YMD").ToString.Trim <> "" Then
                        sql.Blocks("END_YMD") = True
                    End If

                    If drHeader("S_ECH_CUST_CD").ToString.Trim <> "" Then
                        sql.Blocks("CUST_CD") = True
                    End If

                    If drHeader("S_ECH_CUST_NM").ToString.Trim <> "" Then
                        sql.Blocks("CUST_NM") = True
                    End If

                    If drHeader("S_ECH_4CODE").ToString.Trim <> "" Then
                        sql.Blocks("CUSTOMS_4CODE") = True
                    End If

                    sql.Blocks("SelectMFCSDetail") = True
                    dt = db.SqlGet(sql.Text, False)
                Else
                    sql = New SqlBox("EchAccountExcelUpDown@SearchMFCS")
                    sql.AllowSqlInjection = True
                    sql.Params("DOC_YYYYMM") = ds.Tables("WG3").Rows(0)("DOC_YYYYMM")
                    sql.Params("USER_ID") = YJIT.SessionInfo.UserID

                    sql.Blocks("SEL_UDR_TMP") = True
                    dt = db.SqlGet(sql.Text, False)
                End If

                dt.TableName = "WG3"
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

        Public Shared Function SearchAccount(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable

            Dim ErrorOccur As Boolean = True

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("EchAccountExcelUpDown@SearchAccount")
                sql.AllowSqlInjection = True
                sql.Params("SEARCH_TYPE") = drHeader("SEARCH_TYPE").ToString
                sql.Params("S_STR_YM") = yjitSubstr(drHeader("S_STR_YMD").ToString, 0, 6)
                sql.Params("S_END_YM") = yjitSubstr(drHeader("S_END_YMD").ToString, 0, 6)
                sql.Params("S_CUST_CD") = drHeader("S_ECH_CUST_CD").ToString.Trim
                sql.Params("S_CUST_NM") = drHeader("S_ECH_CUST_NM").ToString.Trim
                sql.Params("S_CUSTOMS_4CD") = drHeader("S_ECH_4CODE").ToString.Trim

                If drHeader("S_END_YMD").ToString.Trim <> "" Then
                    sql.Blocks("S_END_YM") = True
                End If

                If drHeader("S_ECH_CUST_CD").ToString.Trim <> "" Then
                    sql.Blocks("S_CUST_CD") = True
                End If

                If drHeader("S_ECH_CUST_NM").ToString.Trim <> "" Then
                    sql.Blocks("S_CUST_NM") = True
                End If

                If drHeader("S_ECH_4CODE").ToString.Trim <> "" Then
                    sql.Blocks("S_CUSTOMS_4CD") = True
                End If

                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "WG4"
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

        Public Shared Function SaveUDR_APPLY(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDS As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                ' == Transaction 시작 =================================================
                db.BeginTransaction()

                Dim proParams = New Dictionary(Of String, Object)

                proParams.Add("P_USERID", YJIT.SessionInfo.UserID)
                proParams.Add("P_YYYYMM", ds.Tables("WG3").Rows(0)("DOC_YYYYMM").ToString)
                proParams.Add("R_RTNCD", "")
                proParams.Add("R_RTNMSG", "")

                db.ExecuteProcedure("ECH_KL_MFCS_DETAIL_SELECT", proParams)
                If ("" & proParams("R_RTNCD").ToString) = "E" Then
                    ThrowMsg(ErrorOccur, "Error while Processing!" & vbCrLf & proParams("R_RTNMSG").ToString)
                End If

                db.Commit()
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet
        End Function

        Public Shared Function SaveAFR(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            'Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim RtDT As DataTable

            Dim ErrorOccur As Boolean = True

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                dt = ds.Tables("WG2")

                ' == Transaction 시작 =================================================
                db.BeginTransaction()

                sql = New SqlBox("EchAccountExcelUpDown@SearchAFR")
                sql.AllowSqlInjection = True
                sql.Params("DOC_YYYYMM") = ds.Tables("WG2").Rows(0)("DOC_YYYYMM").ToString
                sql.Blocks("ECH_KL_AFR_ACC") = True
                RtDT = db.SqlGet(sql.Text, False)

                If RtDT.Rows.Count > 0 Then
                    sql = New SqlBox("EchAccountExcelUpDown@InsertAFR")
                    sql.AllowSqlInjection = True
                    sql.Params("DOC_YYYYMM") = ds.Tables("WG2").Rows(0)("DOC_YYYYMM").ToString
                    sql.Blocks("AFR_CLEAR") = True

                    db.SqlSet(sql.Text)
                End If

                For Each dr As DataRow In dt.Rows
                    If dr("DOC_YYYYMM").ToString <> "" Then
                        sql = New SqlBox("EchAccountExcelUpDown@InsertAFR")
                        sql.AllowSqlInjection = True
                        sql.Params("DOC_YYYYMM") = dr("DOC_YYYYMM").ToString
                        sql.Params("INV_YM") = dr("INV_YM").ToString
                        sql.Params("KLNET_ID") = dr("SND_ID").ToString
                        sql.Params("KLNET_CUST_NM") = dr("KLNET_CUST_NM").ToString
                        sql.Params("KL_HBL_COUNT") = dr("KL_HBL_COUNT").ToString
                        sql.Params("CUSTOMS_4CODE") = dr("CUSTOMS_4CODE").ToString
                        sql.Params("KLNET_ACC_AMT") = dr("KLNET_ACC_AMT")
                        sql.Params("KLNET_COMMISSION") = dr("KLNET_COMMISSION")
                        sql.Params("CUST_CD") = dr("CUST_CD")
                        sql.Params("CUST_LOC_NM") = dr("CUST_LOC_NM")
                        sql.Params("CHAIN_HBL_COUNT") = dr("CHAIN_HBL_COUNT")

                        sql.Blocks("INSERT_MOD") = True

                        db.SqlSet(sql.Text)
                    End If
                Next

                db.Commit()
                ' == Transaction 끝 =================================================

                'ResultSet("Data") = Search()("Data")
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet
        End Function

        Public Shared Function SaveUDR(ByVal ds As DataSet, Optional ByVal vBF As Boolean = True) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            'Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim RtDT As DataTable

            Dim ErrorOccur As Boolean = True

            'vBF - False : Save Before(Select), True : Save After
            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                dt = ds.Tables("WG3")

                ' == Transaction 시작 =================================================
                db.BeginTransaction()

                If Not vBF Then

                    sql = New SqlBox("EchAccountExcelUpDown@SearchMFCS")
                    sql.AllowSqlInjection = True
                    sql.Params("DOC_YYYYMM") = dt.Rows(0)("DOC_YYYYMM")
                    sql.Params("USER_ID") = YJIT.SessionInfo.UserID
                    sql.Blocks("UDR_SELECT_CLEAR") = True
                    RtDT = db.SqlGet(sql.Text, False)

                    If RtDT.Rows.Count > 0 Then
                        sql = New SqlBox("EchAccountExcelUpDown@InsertUDR")
                        sql.AllowSqlInjection = True
                        sql.Params("DOC_YYYYMM") = dt.Rows(0)("DOC_YYYYMM")
                        sql.Params("USER_ID") = YJIT.SessionInfo.UserID
                        sql.Blocks("UDR_SELECT_CLEAR") = True

                        db.SqlSet(sql.Text)
                    End If

                    For Each dr As DataRow In dt.Rows
                        If dr("DOC_YYYYMM").ToString <> "" Then
                            sql = New SqlBox("EchAccountExcelUpDown@InsertUDR")
                            sql.AllowSqlInjection = True
                            sql.Params("DOC_YYYYMM") = dr("DOC_YYYYMM").ToString
                            sql.Params("INV_YM") = dr("INV_YM").ToString
                            sql.Params("CUSTOMS_4CODE") = dr("CUSTOMS_4CODE").ToString
                            sql.Params("SND_ID") = dr("SND_ID").ToString
                            sql.Params("RECV_ID") = dr("RECV_ID").ToString
                            sql.Params("THIS_IPM") = dr("THIS_IPM").ToString
                            sql.Params("DOC_NM") = dr("DOC_NM").ToString
                            sql.Params("BGM") = dr("BGM").ToString
                            sql.Params("SND_RECV") = dr("SND_RECV").ToString
                            sql.Params("SND_BYTE") = dr("SND_BYTE").ToString
                            sql.Params("KEY_NO") = dr("KEY_NO").ToString
                            sql.Params("DOC_ITEM") = dr("DOC_ITEM").ToString
                            sql.Params("USER_ID") = YJIT.SessionInfo.UserID

                            sql.Blocks("UDR_SELECT_LST") = True
                            db.SqlSet(sql.Text)
                        End If
                    Next

                Else
                    sql = New SqlBox("EchAccountExcelUpDown@SearchMFCS")
                    sql.AllowSqlInjection = True
                    sql.Params("DOC_YYYYMM") = dt.Rows(0)("DOC_YYYYMM")
                    sql.Blocks("UDR_SAVE_CLEAR") = True
                    RtDT = db.SqlGet(sql.Text, False)

                    If RtDT.Rows.Count > 0 Then
                        sql = New SqlBox("EchAccountExcelUpDown@InsertUDR")
                        sql.AllowSqlInjection = True
                        sql.Params("DOC_YYYYMM") = dt.Rows(1)("DOC_YYYYMM")
                        sql.Blocks("UDR_INSERT_CLEAR") = True

                        db.SqlSet(sql.Text)
                    End If

                    If dt.Rows.Count > 0 Then
                        sql = New SqlBox("EchAccountExcelUpDown@InsertUDR")
                        sql.AllowSqlInjection = True
                        sql.Params("DOC_YYYYMM") = dt.Rows(0)("DOC_YYYYMM")
                        sql.Params("USER_ID") = YJIT.SessionInfo.UserID

                        sql.Blocks("INSERT_MOD") = True

                        db.SqlSet(sql.Text)
                    End If
                End If

                db.Commit()
                ' == Transaction 끝 =================================================

                'ResultSet("Data") = Search()("Data")
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet
        End Function

        Public Shared Function SaveMFCS(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            'Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim RtDT As DataTable

            Dim ErrorOccur As Boolean = True

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                dt = ds.Tables("WG1")

                ' == Transaction 시작 =================================================
                db.BeginTransaction()

                sql = New SqlBox("EchAccountExcelUpDown@SearchMFCS")
                sql.AllowSqlInjection = True
                sql.Params("DOC_YYYYMM") = ds.Tables("WG1").Rows(0)("DOC_YYYYMM").ToString

                sql.Blocks("ECH_MFCS_ACC") = True
                RtDT = db.SqlGet(sql.Text, False)

                If RtDT.Rows.Count > 0 Then
                    sql = New SqlBox("EchAccountExcelUpDown@InsertMFCS")
                    sql.AllowSqlInjection = True
                    sql.Params("DOC_YYYYMM") = ds.Tables("WG1").Rows(0)("DOC_YYYYMM").ToString
                    sql.Blocks("MFCS_ACC_CLEAR") = True

                    db.SqlSet(sql.Text)
                End If

                For Each dr As DataRow In dt.Rows
                    If dr("DOC_YYYYMM").ToString <> "" Then

                        sql = New SqlBox("EchAccountExcelUpDown@InsertMFCS")
                        sql.AllowSqlInjection = True
                        sql.Params("DOC_YYYYMM") = dr("DOC_YYYYMM").ToString
                        sql.Params("INV_YM") = dr("INV_YM").ToString
                        sql.Params("SND_ID") = dr("SND_ID").ToString
                        sql.Params("RECV_ID") = dr("RECV_ID").ToString
                        sql.Params("DOC_NM") = dr("DOC_NM").ToString
                        sql.Params("CUSTOMS_4CODE") = dr("CUSTOMS_4CODE").ToString
                        sql.Params("SEND_RECV") = dr("SND_RECV").ToString
                        sql.Params("TOT_SND_BYTE") = dr("TOT_SND_BYTE")
                        sql.Params("ACC_SND_BYTE") = dr("ACC_SND_BYTE")
                        sql.Params("ACC_AMT") = dr("ACC_AMT")
                        sql.Params("COMMISSION") = dr("COMMISSION")
                        sql.Params("REMARK") = dr("REMARK").ToString
                        sql.Params("CHAIN_TOT_BYTE") = "0"
                        sql.Params("CUST_CD") = dr("CUST_CD").ToString
                        sql.Params("CUST_LOC_NM") = dr("CUST_LOC_NM").ToString

                        sql.Blocks("INSERT_MOD") = True

                        db.SqlSet(sql.Text)
                    End If
                Next
                db.Commit()
                ' == Transaction 끝 =================================================

                'ResultSet("Data") = Search()("Data")
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet
        End Function

    End Class

End Namespace
