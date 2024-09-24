Imports System.Data
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.Biz.Common

Namespace YJIT.Biz
    Public Class MdmCommonMgt
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

                If SessionInfo.AuthorizationType <> "0" Then
                    sql = New SqlBox("MdmCommonMgt@Search")
                    sql.AllowSqlInjection = True
                    sql.Params("S_GRP_CD") = drHeader("S_GRP_CD").ToString & ""
                    sql.Params("S_GRP_NM") = drHeader("S_GRP_NM").ToString & ""
                    If drHeader("S_GRP_CD").ToString <> "" Then sql.Blocks("GRP_CD") = True
                    If drHeader("S_GRP_NM").ToString <> "" Then sql.Blocks("GRP_NM") = True
                    dt = db.SqlGet(sql.Text, False)
                    dt.TableName = "WG1"
                    If dt.Rows.Count = 0 Then
                        ThrowMsg(ErrorOccur, "Data not found!")
                    End If
                    ResultDs.Tables.Add(dt)
                Else
                    sql = New SqlBox("MdmCommonMgt@SearchAdmin")
                    sql.AllowSqlInjection = True
                    sql.Params("S_GRP_CD") = drHeader("S_GRP_CD").ToString & ""
                    sql.Params("S_GRP_NM") = drHeader("S_GRP_NM").ToString & ""
                    If drHeader("S_GRP_CD").ToString <> "" Then sql.Blocks("GRP_CD") = True
                    If drHeader("S_GRP_NM").ToString <> "" Then sql.Blocks("GRP_NM") = True
                    dt = db.SqlGet(sql.Text, False)
                    dt.TableName = "WG1"
                    If dt.Rows.Count = 0 Then
                        ThrowMsg(ErrorOccur, "Data not found!")
                    End If
                    ResultDs.Tables.Add(dt)
                End If

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            End Try
            Return ResultSet
        End Function
        Public Shared Function SearchCommonCode(ByVal GRP_CD As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim COMN_CD As String
            Dim ErrorOccur As Boolean = True

            Try
                sql = New SqlBox("MdmCommonMgt@SearchCommonCode")
                sql.AllowSqlInjection = True
                sql.Params("GRP_CD") = GRP_CD
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
                ResultDs.Tables.Add(dt)

                If dt.Rows.Count > 0 Then
                    COMN_CD = dt.Rows(0).Item(1)
                    sql = New SqlBox("MdmCommonMgt@SearchLocalLanguage")
                    sql.AllowSqlInjection = True
                    sql.Params("REQ_CD") = COMN_CD
                    sql.Params("ITEM_CD") = GRP_CD
                    dt = db.SqlGet(sql.Text, False)
                    dt.TableName = "WG3"
                    ResultDs.Tables.Add(dt)
                End If

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            End Try
            Return ResultSet
        End Function
        Public Shared Function SearchLocalLanguage(ByVal REQ_CD As String, ByVal ITEM_CD As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True
            Try
                sql = New SqlBox("MdmCommonMgt@SearchLocalLanguage")
                sql.AllowSqlInjection = True
                sql.Params("REQ_CD") = REQ_CD
                sql.Params("ITEM_CD") = ITEM_CD
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG3"
                ResultDs.Tables.Add(dt)
                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs
            Catch ex As Exception
                If ErrorOccur Then ResultSet("TrxCode") = "E" Else ResultSet("TrxCode") = "N"
                ResultSet("TrxMsg") = ex.Message
            End Try
            Return ResultSet
        End Function
        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim dr As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt1 As DataTable = Nothing
            Dim dt2 As DataTable = Nothing
            Dim dt3 As DataTable = Nothing
            Dim ErrorOccur As Boolean = True


            db.BeginTransaction()
            Try
                dt1 = ds.Tables("WG1")
                dt2 = ds.Tables("WG2")
                dt3 = ds.Tables("WG3")

                ' Group List
                For Each dr In dt1.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("MdmCommonMgt@Insert")
                        Case "U"
                            sql = New SqlBox("MdmCommonMgt@Update")
                    End Select
                    sql.Params("GRP_CD") = dr("GRP_CD").ToString
                    sql.Params("GRP_NM") = dr("GRP_NM").ToString
                    sql.Params("MNGT_AUTH_LVL") = dr("MNGT_AUTH_LVL").ToString
                    sql.Params("CD_LEN") = dr("CD_LEN")
                    sql.Params("NAME_TITLE") = dr("NAME_TITLE").ToString
                    sql.Params("TITLE1") = dr("TITLE1").ToString
                    sql.Params("TITLE2") = dr("TITLE2").ToString
                    sql.Params("TITLE3") = dr("TITLE3").ToString
                    sql.Params("TITLE4") = dr("TITLE4").ToString
                    sql.Params("TITLE5") = dr("TITLE5").ToString
                    sql.Params("TITLE6") = dr("TITLE6").ToString
                    sql.Params("TITLE7") = dr("TITLE7").ToString
                    sql.Params("TITLE8") = dr("TITLE8").ToString
                    sql.Params("TITLE9") = dr("TITLE9").ToString
                    sql.Params("TITLE10") = dr("TITLE10").ToString

                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

                ' Code List
                For Each dr In dt2.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("MdmCommonMgt@InsertCommonCode")
                        Case "U"
                            sql = New SqlBox("MdmCommonMgt@UpdateCommonCode")
                        Case "D"
                            sql = New SqlBox("MdmCommonMgt@DeleteCommonCode")
                    End Select
                    sql.Params("GRP_CD") = dr("GRP_CD").ToString
                    sql.Params("COMN_CD") = dr("COMN_CD").ToString
                    sql.Params("CD_NM") = dr("CD_NM").ToString
                    sql.Params("RMK") = dr("RMK").ToString
                    sql.Params("OPT_ITEM1") = dr("OPT_ITEM1").ToString
                    sql.Params("OPT_ITEM2") = dr("OPT_ITEM2").ToString
                    sql.Params("OPT_ITEM3") = dr("OPT_ITEM3").ToString
                    sql.Params("OPT_ITEM4") = dr("OPT_ITEM4").ToString
                    sql.Params("OPT_ITEM5") = dr("OPT_ITEM5").ToString
                    sql.Params("OPT_ITEM6") = dr("OPT_ITEM6").ToString
                    sql.Params("OPT_ITEM7") = dr("OPT_ITEM7").ToString
                    sql.Params("OPT_ITEM8") = dr("OPT_ITEM8").ToString
                    sql.Params("OPT_ITEM9") = dr("OPT_ITEM9").ToString
                    sql.Params("OPT_ITEM10") = dr("OPT_ITEM10").ToString

                    sql.Params("SORT") = dr("SORT").ToString
                    sql.Params("USE_YN") = dr("USE_YN").ToString

                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

                ' Local Language
                For Each dr In dt3.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("MdmCommonMgt@InsertLocalLanguage")
                        Case "U"
                            sql = New SqlBox("MdmCommonMgt@UpdateLocalLanguage")
                        Case "D"
                            sql = New SqlBox("MdmCommonMgt@DeleteLocalLanguage")
                    End Select
                    sql.Params("REQ_CD") = dr("REQ_CD").ToString
                    sql.Params("ITEM_CD") = dr("ITEM_CD").ToString
                    sql.Params("LANG_CD") = dr("LANG_CD").ToString
                    sql.Params("LOC_NM") = dr("LOC_NM").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

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
            ResultSet("Data") = Search(ds)("Data")
            Return ResultSet
        End Function

        Public Shared Function SaveCodeDetail(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim dr As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt1 As DataTable = Nothing
            Dim dt2 As DataTable = Nothing
            Dim dt3 As DataTable = Nothing
            Dim ErrorOccur As Boolean = True

            db.BeginTransaction()
            Try

                dt2 = ds.Tables("WG2")
                dt3 = ds.Tables("WG3")

                ' Code List
                For Each dr In dt2.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("MdmCommonMgt@InsertCommonCode")
                        Case "U"
                            sql = New SqlBox("MdmCommonMgt@UpdateCommonCode")
                        Case "D"
                            sql = New SqlBox("MdmCommonMgt@DeleteCommonCode")
                    End Select
                    sql.Params("GRP_CD") = dr("GRP_CD").ToString
                    sql.Params("COMN_CD") = dr("COMN_CD").ToString
                    sql.Params("CD_NM") = dr("CD_NM").ToString
                    sql.Params("RMK") = dr("RMK").ToString
                    sql.Params("OPT_ITEM1") = dr("OPT_ITEM1").ToString
                    sql.Params("OPT_ITEM2") = dr("OPT_ITEM2").ToString
                    sql.Params("OPT_ITEM3") = dr("OPT_ITEM3").ToString
                    sql.Params("OPT_ITEM4") = dr("OPT_ITEM4").ToString
                    sql.Params("OPT_ITEM5") = dr("OPT_ITEM5").ToString
                    sql.Params("OPT_ITEM6") = dr("OPT_ITEM6").ToString
                    sql.Params("OPT_ITEM7") = dr("OPT_ITEM7").ToString
                    sql.Params("OPT_ITEM8") = dr("OPT_ITEM8").ToString
                    sql.Params("OPT_ITEM9") = dr("OPT_ITEM9").ToString
                    sql.Params("OPT_ITEM10") = dr("OPT_ITEM10").ToString
                    sql.Params("SORT") = dr("SORT").ToString
                    sql.Params("USE_YN") = dr("USE_YN").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

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
            ResultSet("Data") = Search(ds)("Data")
            Return ResultSet
        End Function

        Public Shared Function SaveCodeLanguage(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim dr As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt1 As DataTable = Nothing
            Dim dt2 As DataTable = Nothing
            Dim dt3 As DataTable = Nothing
            Dim ErrorOccur As Boolean = True

            db.BeginTransaction()
            Try

                dt3 = ds.Tables("WG3")

                ' Local Language
                For Each dr In dt3.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("MdmCommonMgt@InsertLocalLanguage")
                        Case "U"
                            sql = New SqlBox("MdmCommonMgt@UpdateLocalLanguage")
                        Case "D"
                            sql = New SqlBox("MdmCommonMgt@DeleteLocalLanguage")
                    End Select
                    sql.Params("REQ_CD") = dr("REQ_CD").ToString
                    sql.Params("ITEM_CD") = dr("ITEM_CD").ToString
                    sql.Params("LANG_CD") = dr("LANG_CD").ToString
                    sql.Params("LOC_NM") = dr("LOC_NM").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

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
            ResultSet("Data") = Search(ds)("Data")
            Return ResultSet
        End Function

    End Class
End Namespace
