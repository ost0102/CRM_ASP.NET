Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common
Imports System.IO


Namespace YJIT.Biz

    Public Class CrmWBSMgt
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow = Nothing
            Dim insflag As String = String.Empty
            Dim dt As DataTable = Nothing
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("WG2") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                dt = ds.Tables("WG2")

                For Each drHeader In dt.Rows

                    Select Case drHeader("_INSFLAG")
                        Case "D"
                            sql = New SqlBox("CrmWBSMgt@Delete")
                            sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                            sql.Params("SEQ") = drHeader("SEQ").ToString
                            db.SqlSet(sql.Text)
                        Case "I", "U"
                            sql = New SqlBox("CrmWBSMgt@Save")
                            YJQuery.SaveRow(db, sql, insflag, drHeader)
                            sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID
                            db.SqlSet(sql.Text)
                    End Select

                Next

                '전체적인 진척율 업데이트 
                If drHeader("_INSFLAG") = "I" Or drHeader("_INSFLAG") = "U" Then
                    sql = New SqlBox("CrmWBSMgt@UpdateComRate")
                    sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                    db.SqlSet(sql.Text)
                End If

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
                'resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet

        End Function

        Public Shared Function SaveWBS(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim sql As SqlBox = Nothing
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow = Nothing
            Dim insflag As String = String.Empty
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                If String.IsNullOrEmpty(drHeader("MNGT_NO").ToString) Then
                    insflag = "I"
                    drHeader("MNGT_NO") = GenerationKeyNo(db)
                Else
                    insflag = "U"
                End If

                sql = New SqlBox("CrmWBSMgt@SaveWBS")
                YJQuery.SaveRow(db, sql, insflag, drHeader)
                sql.Params("SSN_USR_ID") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)

                '20210120 정지수 DateDiff 함수 사용하여 중간에 수정된 날짜만큼 전체 날짜를 미뤄줄려고 했으나, TO_YMD도 함께 미뤄져 문제가 있을 여지가 있으므로 주석처리
                ''날짜 일괄적용
                'sql = New SqlBox("CrmWBSMgt@UpdateYMD")
                'YJQuery.SaveRow(db, sql, insflag, drHeader)
                'sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
                'db.SqlSet(sql.Text)

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
        Public Shared Function GenerationKeyNo(ByVal db As DBA) As String
            Dim sql As SqlBox = Nothing
            Dim MngtNo As String = String.Empty
            Dim iSeq As Integer = 0
            Dim dt1 As DataTable = Nothing

            Dim i As Integer = 1
            MngtNo = String.Empty
            Do While MngtNo = String.Empty
                If iSeq = 999 Then iSeq = 0
                iSeq += 1
                MngtNo = String.Format("{0}{1}{2}", Format(Now, "yyyyMMddHHmmss"), Now.Millisecond.ToString.PadLeft(3, "0"), iSeq.ToString.PadLeft(3, "0"))
                '중복체크
                sql = New SqlBox("CrmWBSMgt@Search")
                sql.Params("MNGT_NO") = MngtNo
                sql.Blocks("MNGT_NO") = True
                dt1 = db.SqlGet(sql.Text, False)

                If dt1.Rows.Count > 0 Then
                    MngtNo = ""
                    If i = 10 Then Exit Do
                End If
            Loop

            Return MngtNo
        End Function

        Public Shared Function DeleteWBS(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            Dim drHeader As DataRow = Nothing
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("CrmWBSMgt@DeleteWBS")
                sql.Params("MNGT_NO") = drHeader("MNGT_NO").ToString
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

            If resultSet("TrxCode") = "Y" Then
                resultSet("Data") = Search(ds)("Data")
            End If

            Return resultSet
        End Function
    End Class
End Namespace
