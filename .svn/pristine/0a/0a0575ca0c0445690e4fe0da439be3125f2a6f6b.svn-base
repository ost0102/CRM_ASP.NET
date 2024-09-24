Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic
Imports YJIT.Biz.Common

Namespace YJIT.Biz
    Public Class MdmUserEachMgt

        Public Shared Function Search(ByVal userID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql As New SqlBox("MdmUserEachMgt@Search")

                sql.Params("USR_ID") = YJIT.SessionInfo.UserID

                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                dt.TableName = "Main"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function Save(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If
                drHeader = ds.Tables("MAIN").Rows(0)


                If SessionOfficeInfo.HqOfficeCode = "ENCHQ" Or SessionOfficeInfo.HqOfficeCode = "LOHQ" Or SessionOfficeInfo.HqOfficeCode = "KORAHQ" _
                    Or SessionOfficeInfo.HqOfficeCode = "LLCFHQ" Then

                    If drHeader("PSWD1").ToString <> "" Then
                        Dim CHR() As Char = drHeader("PSWD").ToString.ToCharArray

                        Dim Upper As Boolean = False
                        Dim Lower As Boolean = False
                        Dim Spec As Boolean = False
                        Dim Num As Boolean = False
                        If SessionOfficeInfo.HqOfficeCode = "LOHQ" Then
                            If CHR.Length < 8 Then ThrowMsg(ErrorOccur, "비밀번호는 8자리 이상이여야 합니다.")
                        ElseIf SessionOfficeInfo.HqOfficeCode = "KORAHQ" Then
                            If CHR.Length < 6 Then ThrowMsg(ErrorOccur, "비밀번호는 6자리 이상이여야 합니다.")
                        Else
                            If CHR.Length < 10 Then ThrowMsg(ErrorOccur, "비밀번호는 10자리 이상이여야 합니다.")
                        End If

                        For I = 0 To CHR.Length - 1
                            Dim AscIndex As Integer = Asc(CHR(I))
                            '97~122 소문자
                            '65~90  대문자
                            '48~57 숫자
                            If AscIndex < 0 Then
                                ThrowMsg(ErrorOccur, "비밀번호에 알 수없는 값이 있습니다.")
                            ElseIf AscIndex >= 97 And AscIndex <= 122 Then
                                Lower = True
                            ElseIf AscIndex >= 65 And AscIndex <= 90 Then
                                Upper = True ' 소문자 체크는 일단 안함
                            ElseIf AscIndex = 32 Then
                                '스페이스
                            ElseIf AscIndex >= 48 And AscIndex <= 57 Then
                                Num = True
                            Else
                                Spec = True
                            End If

                            If I > 0 Then
                                Dim preAscIndex As Integer = Asc(CHR(I - 1))
                                If AscIndex = preAscIndex Then
                                    ThrowMsg(ErrorOccur, "연속 된 문자 또는 숫자를 사용 하실 수 없습니다.")
                                End If
                            End If
                        Next
                        If SessionOfficeInfo.HqOfficeCode = "KORAHQ" Then
                            If (Upper = False And Lower = False) OrElse Num = False Then
                                ThrowMsg(ErrorOccur, "비밀번호에 문자,숫자가 포함 되어야합니다.")
                            End If
                        ElseIf SessionOfficeInfo.HqOfficeCode = "LLCFHQ" Then
                            If (Upper = False And Lower = False) OrElse Num = False Or Spec = False Then
                                ThrowMsg(ErrorOccur, "비밀번호에 문자,숫자,특수문자가 포함 되어야합니다.")
                            End If
                        Else
                            If Upper = False OrElse Lower = False OrElse Num = False Then
                                ThrowMsg(ErrorOccur, "비밀번호에 문자, 숫자,특수문자가 포함 되어야합니다.")
                            End If
                        End If
                    End If
                End If
                sql = New SqlBox("MdmUserEachMgt@Update")

                sql.Params("ENG_NM") = drHeader("ENG_NM").ToString
                sql.Params("LOC_NM") = drHeader("LOC_NM").ToString
                sql.Params("PSWD") = drHeader("PSWD").ToString
                sql.Params("HP_NO") = drHeader("HP_NO").ToString
                sql.Params("TEL_NO") = drHeader("TEL_NO").ToString
                sql.Params("FAX_NO") = drHeader("FAX_NO").ToString
                sql.Params("EMAIL") = drHeader("EMAIL").ToString
                sql.Params("USR_ID") = drHeader("USR_ID").ToString

                If drHeader("PSWD1") <> "" Then
                    sql.Blocks("PSWD") = True
                End If

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

