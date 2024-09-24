Imports System.Data
Imports YJIT.Data
Imports YJIT.BIZ.Common

Namespace YJIT.BIZ
    Public Class AraMemberMgt

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)
            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString) 'ARA 개발DB
            Dim db As DBA = New DBA(strConn, "ORACLE")
            Dim dt As New DataTable
            Dim ErrorOccur As Boolean = True

            Try
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("AraMemberMgt@Search")
                sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
                sql.Params("USE_YN") = drHeader("USE_YN").ToString

                If Trim(drHeader("SEARCH_KEY")) <> "" Then sql.Blocks("SEARCH_KEY") = True
                If Trim(drHeader("USE_YN")) <> "" Then sql.Blocks("USE_YN") = True

                dt = db.SqlGet(sql.Text.Replace(";", "','"), False)
                dt.TableName = "WG1"

                ResultDs.Tables.Add(dt)
                ResultSet("TrxCode") = "Y"

                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "No Data")
                End If


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

        Public Shared Function SearchDetail(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim sql As SqlBox = Nothing
            Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)
            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString) 'ARA 개발DB
            Dim db As DBA = New DBA(strConn, "ORACLE")
            Dim dt As New DataTable
            Dim ErrorOccur As Boolean = True

            Try
                drHeader = ds.Tables("MAIN").Rows(0)
                sql = New SqlBox("AraMemberMgt@SearchDetail")
                sql.Params("CRM_CD") = drHeader("CRM_CD")

                dt = db.SqlGet(sql.Text.Replace(";", "','"), False)
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

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim dsRet As DataSet = New DataSet
            Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)
            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString) 'ARA 개발DB
            Dim db As DBA = New DBA(strConn, "ORACLE")
            Dim dt As DataTable = Nothing
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim insFlag As String = "U"

            If Not ds.Tables.Contains("MAIN") Then
                ThrowMsg(ErrorOccur, "Data info missing.")
            End If

            db.BeginTransaction()
            Try
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("AraMemberMgt@SaveValidate")
                sql.Params("CRM_CD") = drHeader("CRM_CD").ToString
                sql.Params("BUSN_NO") = drHeader("BUSN_NO").ToString
                dt = db.SqlGet(sql.Text, False)

                ResultSet("TrxCode") = "Y"

                If dt.Rows.Count = 0 Then
                    sql = New SqlBox("AraMemberMgt@Insert")
                Else
                    sql = New SqlBox("AraMemberMgt@Update")
                End If

                sql.Params("CRM_CD") = drHeader("CRM_CD").ToString
                sql.Params("BUSN_NO") = drHeader("BUSN_NO").ToString.Replace("-", "")
                sql.Params("CUST_NM") = drHeader("CUST_NM").ToString
                sql.Params("CEO") = drHeader("CEO").ToString
                sql.Params("BIZ_TYPE") = drHeader("BIZ_TYPE").ToString
                sql.Params("BIZ_COND") = drHeader("BIZ_COND").ToString
                sql.Params("ZIP_CD") = drHeader("ZIP_CD").ToString.Trim
                sql.Params("SUB_BD_NO") = drHeader("SUB_BD_NO").ToString
                sql.Params("CUST_ADDR") = drHeader("CUST_ADDR").ToString
                sql.Params("ERP_LINK_SERVICE") = drHeader("ERP_LINK_SERVICE").ToString
                sql.Params("MEMB_STATE") = drHeader("MEMB_STATE").ToString
                sql.Params("USE_START_DT") = drHeader("USE_START_DT").ToString.Replace("-", "")
                sql.Params("USE_END_DT") = drHeader("USE_END_DT").ToString.Replace("-", "")
                sql.Params("BASE_AMT") = drHeader("BASE_AMT")
                sql.Params("BASE_ISSUE_CNT") = drHeader("BASE_ISSUE_CNT")
                sql.Params("PRICE") = drHeader("PRICE")
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID

                db.SqlSet(sql.Text)

                db.Commit()

                ResultSet("CRM_CD") = drHeader("CRM_CD").ToString
                ResultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return ResultSet

        End Function

        Public Shared Function CrnValidate(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)
            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString) 'ARA 개발DB
            Dim db As DBA = New DBA(strConn, "ORACLE")
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable
            Dim errorOccur As Boolean = True

            Try
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("AraMemberMgt@CrnValidate")
                sql.Params("BUSN_NO") = drHeader("BUSN_NO").ToString

                dt = db.SqlGet(sql.Text.Replace(";", "','"), False)

                dt.TableName = "MAIN"
                ResultDs.Tables.Add(dt)
                ResultSet("TrxCode") = "Y"

                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

                If dt.Rows.Count <> 0 Then
                    ThrowMsg(errorOccur, "해당 사업자번호는 이미 존재하는 사업자번호입니다.")
                End If

            Catch ex As Exception
                If errorOccur Then
                    ResultSet("TrxCode") = "E"
                Else
                    ResultSet("TrxCode") = "N"
                End If
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet

        End Function

        Public Shared Function SearchCust(ByVal ds As DataSet) As Dictionary(Of String, Object)

            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow
            Dim sql As SqlBox = Nothing
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True

            Try
                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("AraMemberMgt@SearchCust")
                sql.Params("CRM_CD") = drHeader("CRM_CD").ToString

                dt = db.SqlGet(sql.Text.Replace(";", "','"), False)
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

    End Class
End Namespace