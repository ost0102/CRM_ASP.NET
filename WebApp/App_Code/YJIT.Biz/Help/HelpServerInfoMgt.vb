Imports System.Data
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.Biz.Common

Namespace YJIT.Biz
    Public Class HelpServerInfoMgt

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
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
                            sql = New SqlBox("HelpServerInfoMgt@Insert")
                        Case "U"
                            sql = New SqlBox("HelpServerInfoMgt@Update")
                        Case "D"
                            sql = New SqlBox("HelpServerInfoMgt@Delete")
                    End Select
                    sql.Params("DB_LINK") = dr("DB_LINK").ToString
                    sql.Params("SVC_CD") = dr("SVC_CD").ToString
                    sql.Params("DOMAIN") = dr("DOMAIN").ToString
                    sql.Params("APPLY_SOURCE") = dr("APPLY_SOURCE").ToString
                    sql.Params("DB_DOMAIN") = dr("DB_DOMAIN").ToString
                    sql.Params("WEB_IP") = dr("WEB_IP").ToString
                    sql.Params("WEB_IP_EXT") = dr("WEB_IP_EXT").ToString
                    sql.Params("WEB_PORT") = dr("WEB_PORT").ToString
                    sql.Params("TNS_NM") = dr("TNS_NM").ToString
                    sql.Params("USR_ID") = dr("USR_ID").ToString
                    sql.Params("USR_PWD") = dr("USR_PWD").ToString
                    sql.Params("NEW_CUST_YN") = dr("NEW_CUST_YN").ToString
                    sql.Params("DB_IP") = dr("DB_IP").ToString
                    sql.Params("DB_IP_EXT") = dr("DB_IP_EXT").ToString
                    sql.Params("DB_PORT") = dr("DB_PORT").ToString
                    sql.Params("DB_SID") = dr("DB_SID").ToString
                    sql.Params("CUST_CD") = dr("CUST_CD").ToString
                    sql.Params("CUST_NM") = dr("CUST_NM").ToString
                    sql.Params("CUST_LOC_NM") = dr("CUST_LOC_NM").ToString
                    sql.Params("TB_CHG_YN") = dr("TB_CHG_YN").ToString
                    sql.Params("USE_YN") = dr("USE_YN").ToString
                    sql.Params("DATA_CHK") = dr("DATA_CHK").ToString
                    sql.Params("WCF_LOG_YN") = dr("WCF_LOG_YN").ToString
                    sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                    sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
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
