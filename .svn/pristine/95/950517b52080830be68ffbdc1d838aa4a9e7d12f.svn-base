Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz
    Public Class StlPaymentList
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function

        Public Shared Function SaveCard(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            'Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim dt As DataTable
            'Dim dt1 As DataTable
            'Dim CustCd As String = Nothing
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            Dim paramKeyNo As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Dim MngtNo As String = Nothing

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                dt = ds.Tables("WG1")
                For Each dr As DataRow In dt.Rows
                    Select Case dr("_INSFLAG")
                        Case "I"
                            '' Reference Group No 생성
                            'Dim yyyyMMdd As String = Now.ToString("yyyyMMdd")
                            'paramKeyNo = GenerationKeyNo("CRM", "", "", yyyyMMdd, "", "", "")
                            'If ("" & paramKeyNo("TrxCode").ToString) = "E" Then
                            '    ThrowMsg(ErrorOccur, "Error while Key No Create Processing! Error Msg: " & paramKeyNo("TrxMsg").ToString)
                            'Else
                            '    MngtNo = paramKeyNo("KEY_NO").ToString
                            'End If
                            sql = New SqlBox("StlPaymentList@Insert")
                        Case "U"
                            sql = New SqlBox("StlPaymentList@Update")
                            MngtNo = dr("MNGT_NO").ToString
                        Case "D"
                            sql = New SqlBox("StlPaymentList@Delete")
                            MngtNo = dr("MNGT_NO").ToString
                        Case Else
                            Continue For
                    End Select
                    sql.Params("OFFICE_CD") = YJIT.SessionInfo.OfficeCode
                    sql.Params("MNGT_NO") = dr("MNGT_NO").ToString
                    sql.Params("SEQ") = dr("SEQ").ToString
                    sql.Params("ISSUE_YMD") = dr("REQ_YMD").ToString
                    sql.Params("CARD_CD") = dr("CARD_CD").ToString
                    sql.Params("CARD_NM") = dr("CARD_NM").ToString
                    sql.Params("CARD_NO") = ""
                    sql.Params("CRN") = dr("CARD_CRN").ToString
                    sql.Params("CUST_CD") = ""
                    sql.Params("CUST_NM") = dr("CARD_CUST_NM").ToString
                    sql.Params("ACCT_CD") = dr("CARD_ACCT_CD").ToString
                    sql.Params("ACCT_NM") = dr("CARD_ACCT_NM").ToString
                    sql.Params("SUP_AMT") = dr("FARE_LOC_AMT").ToString
                    sql.Params("VAT_AMT") = dr("FARE_VAT_AMT").ToString
                    sql.Params("SVC_AMT") = 0
                    sql.Params("TOT_AMT") = dr("FARE_SUM_AMT").ToString
                    sql.Params("DEDUCT_YN") = "N"
                    sql.Params("RMK") = dr("PAY_RMK").ToString
                    sql.Params("DEPT_CD") = dr("DEPT_CD").ToString
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

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet

        End Function
    End Class
End Namespace
