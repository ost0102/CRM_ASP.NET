Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class CrmCustomize

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

                '커스터마이즈 리스트
                sql = New SqlBox("CrmCustomize@SearchList")
                sql.Params("CUST_CD") = drHeader("CUST_CD").ToString
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                ResultDs.Tables.Add(dt)

                ResultSet("TrxCode") = "Y"
                ResultSet("TrxMsg") = "Success"
                ResultSet("Data") = ResultDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
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

        Public Shared Function SearchDetail(ByVal MNGT_NO As String, ByVal CUST_CD As String) As Dictionary(Of String, Object)
            Dim ResultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim ErrorOccur As Boolean = True

            Try

                sql = New SqlBox("CrmCustomize@SearchMain")
                sql.Params("MNGT_NO") = MNGT_NO
                sql.Params("CUST_CD") = CUST_CD
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "MAIN"
                ResultDs.Tables.Add(dt)

                '비용사용내역
                sql = New SqlBox("CrmCustomize@SearchItem")
                sql.Params("MNGT_NO") = MNGT_NO
                sql.Params("CUST_CD") = CUST_CD
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG2"
                ResultDs.Tables.Add(dt)

                '자금 집행 계획 
                sql = New SqlBox("CrmCustomize@SearchFund")
                sql.Params("MNGT_NO") = MNGT_NO
                sql.Params("CUST_CD") = CUST_CD
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG3"
                ResultDs.Tables.Add(dt)

                '견적서 
                sql = New SqlBox("CrmCustomize@SearchEstm")
                sql.Params("MNGT_NO") = MNGT_NO
                sql.Params("CUST_CD") = CUST_CD
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

        'Print
        Public Shared Function Print(ByVal MNGT_NO As String, ByVal CUST_CD As String) As Dictionary(Of String, Object)
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
                sql = New SqlBox("CrmCustomize@PrintList")
                sql.Params("MNGT_NO") = MNGT_NO
                sql.Params("CUST_CD") = CUST_CD
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "HeaderInfo"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("CrmCustomize@PrintItem")
                sql.Params("MNGT_NO") = MNGT_NO
                sql.Params("CUST_CD") = CUST_CD
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "Detail1"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("CrmCustomize@PrintFund")
                sql.Params("MNGT_NO") = MNGT_NO
                sql.Params("CUST_CD") = CUST_CD
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "Detail2"
                ResultDs.Tables.Add(dt)

                sql = New SqlBox("CrmCustomize@PrintEstm")
                sql.Params("MNGT_NO") = MNGT_NO
                sql.Params("CUST_CD") = CUST_CD
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "Detail3"
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

        Public Shared Function Save(ByVal insFlag As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            Dim CustCode As String = ""
            Dim MngtNo As String = ""
            Dim paramKeyNo As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Dim dt As DataTable = Nothing

            Try

                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)

                CustCode = drHeader("CUST_CD").ToString

                sql = New SqlBox("CrmCustomize@MakeMngtno")
                sql.Params("CUST_CD") = CustCode
                dt = db.SqlGet(sql.Text, False)
                MngtNo = dt.Rows(0).Item("MNGT_NO").ToString

                Select Case insFlag
                    Case "I"
                        sql = New SqlBox("CrmCustomize@Insert")
                        sql.Params("MNGT_NO") = MngtNo
                    Case "U"
                        sql = New SqlBox("CrmCustomize@Update")
                        sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    Case "D"
                        sql = New SqlBox("CrmCustomize@DeleteList")
                        sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                End Select

                sql.Params("CUST_CD") = CustCode
                sql.Params("CUSTOM_YMD") = drHeader("CUSTOM_YMD").ToString
                sql.Params("CUSTOM_DTL") = drHeader("CUSTOM_DTL").ToString
                sql.Params("DOWN_PAY") = drHeader("DOWN_PAY").ToString
                sql.Params("REQUESTOR") = drHeader("REQUESTOR").ToString
                sql.Params("DEVELOPER") = drHeader("DEVELOPER").ToString
                sql.Params("TOT_AMT") = drHeader("TOT_AMT").ToString
                sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)


                dt = ds.Tables("WG2")
                For Each dr2 In dt.Rows
                    Select Case dr2("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmCustomize@InsertItem")
                            If drHeader("MNGT_NO").ToString = "" Then
                                sql.Params("MNGT_NO") = MngtNo
                            End If
                        Case "U"
                            sql = New SqlBox("CrmCustomize@UpdateItem")
                        Case "D"
                            sql = New SqlBox("CrmCustomize@DeleteItem")
                        Case Else
                            Continue For
                    End Select

                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    sql.Params("CUST_CD") = CustCode
                    sql.Params("SEQ") = dr2("SEQ").ToString
                    sql.Params("CUST_ITEM") = dr2("CUST_ITEM").ToString
                    sql.Params("CUST_DTL") = dr2("CUST_DTL").ToString
                    sql.Params("CUST_COST") = dr2("CUST_COST").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next


                dt = ds.Tables("WG3")
                For Each dr2 As DataRow In dt.Rows
                    Select Case dr2("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmCustomize@InsertFund")
                            If drHeader("MNGT_NO").ToString = "" Then
                                sql.Params("MNGT_NO") = MngtNo
                            End If
                        Case "U"
                            sql = New SqlBox("CrmCustomize@UpdateFund")
                        Case "D"
                            sql = New SqlBox("CrmCustomize@DeleteFund")
                        Case Else
                            Continue For
                    End Select

                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    sql.Params("CUST_CD") = CustCode
                    sql.Params("SEQ") = dr2("SEQ").ToString
                    sql.Params("FUND_ITEM") = dr2("FUND_ITEM").ToString
                    sql.Params("SALES_VAL") = dr2("SALES_VAL").ToString
                    sql.Params("ISSUED_YMD") = dr2("ISSUED_YMD").ToString
                    sql.Params("BUY_VAL") = dr2("BUY_VAL").ToString
                    sql.Params("FUND_RMK") = dr2("FUND_RMK").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

                dt = ds.Tables("WG4")
                For Each dr2 In dt.Rows
                    Select Case dr2("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("CrmCustomize@InsertEstm")
                            If drHeader("MNGT_NO").ToString = "" Then
                                sql.Params("MNGT_NO") = MngtNo
                            End If
                        Case "U"
                            sql = New SqlBox("CrmCustomize@UpdateEstm")
                        Case "D"
                            sql = New SqlBox("CrmCustomize@DeleteEstm")
                        Case Else
                            Continue For
                    End Select

                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    sql.Params("CUST_CD") = CustCode
                    sql.Params("SEQ") = dr2("SEQ").ToString
                    sql.Params("ESTM_YMD") = dr2("ESTM_YMD").ToString
                    sql.Params("ESTM_COST") = dr2("ESTM_COST").ToString
                    sql.Params("ESTM_RMK") = dr2("ESTM_RMK").ToString
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID
                    db.SqlSet(sql.Text)
                Next

                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet

        End Function

        'Delete Data
        Public Shared Function Delete(ByVal CustCode As String, ByVal MngtNo As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim drHeader As DataRow = Nothing
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim dt As DataTable = Nothing
            Dim invNo As String = Nothing
            Dim ErrMsg As String = ""

            Try
                db.BeginTransaction()

                sql = New SqlBox("CrmCustomize@Delete")
                sql.Params("CUST_CD") = CustCode
                sql.Params("MNGT_NO") = MngtNo
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

            Return resultSet

        End Function
    End Class


End Namespace
