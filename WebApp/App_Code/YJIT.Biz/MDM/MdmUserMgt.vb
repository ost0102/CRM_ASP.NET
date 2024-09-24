Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common
Imports System.Collections.Generic

Namespace YJIT.Biz
    Public Class MdmUserMgt

        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("MdmUserMgt@Search")

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                drHeader = ds.Tables("MAIN").Rows(0)

                sql.Params("USR_ID") = drHeader("S_USR_ID").ToString
                sql.Params("USR_NM") = drHeader("S_USR_NM").ToString
                sql.Params("USE_YN") = drHeader("S_USE_YN").ToString

                If drHeader("S_USR_ID").ToString <> "" Then sql.Blocks("USR_ID") = True
                If drHeader("S_USR_NM").ToString <> "" Then sql.Blocks("USR_NM") = True
                If drHeader("S_USE_YN").ToString <> "" Then sql.Blocks("USE_YN") = True

                If drHeader("S_USER_CNT_YN").ToString <> "" Then
                    sql.Params("USER_CNT_YN") = drHeader("S_USER_CNT_YN").ToString
                    sql.Blocks("USER_CNT_YN") = True
                End If

                If drHeader.Table.Columns.Contains("RECVMSG_YN") Then
                    sql.Params("RECVMSG_YN") = drHeader("RECVMSG_YN").ToString
                    sql.Blocks("RECVMSG_YN") = True
                End If

                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
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

        Public Shared Function InitLookUp(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("MdmUserMgt@InitLookUp")
                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                dt.TableName = "Main"
                resultDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resultDs

            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function SearchDetail(ByVal USR_ID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("MdmUserMgt@SearchDetail")

                sql.Params("USR_ID") = USR_ID

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

        Public Shared Function SearchDetailOffice(ByVal USR_ID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql = New SqlBox("MdmUserMgt@SearchDetailOffice")

                sql.Params("USR_ID") = USR_ID

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
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet
            Dim dt1 As DataTable
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            dt1 = ds.Tables("WG1")

            Try
                db.BeginTransaction()

                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                Dim dr As DataRow = ds.Tables("MAIN").Rows(0)

                sql = New SqlBox("MdmUserMgt@Search")
                sql.Params("USR_ID") = dr("USR_ID").ToString()
                sql.Blocks("INS_USR_ID") = True
                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                If dt.Rows.Count = 0 Then
                    sql = New SqlBox("MdmUserMgt@Insert")
                    sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                    sql.Params("PSWD") = dr("PSWD").ToString()
                Else
                    sql = New SqlBox("MdmUserMgt@Update")
                    sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                    If (dr("PSWD").ToString <> "") Then
                        sql.Params("PSWD") = dr("PSWD").ToString()
                        sql.Blocks("PSWD") = True
                    End If
                End If

                sql.Params("USR_ID") = dr("USR_ID").ToString()
                sql.Params("ENG_NM") = dr("ENG_NM").ToString()
                sql.Params("LOC_NM") = dr("LOC_NM").ToString()
                sql.Params("HP_NO") = dr("HP_NO").ToString()
                sql.Params("TEL_NO") = dr("TEL_NO").ToString()
                sql.Params("FAX_NO") = dr("FAX_NO").ToString()
                sql.Params("EMAIL") = dr("EMAIL").ToString()
                sql.Params("DEPT_CD") = dr("DEPT_CD").ToString()
                sql.Params("USE_YN") = dr("USE_YN").ToString()
                sql.Params("RMK") = dr("RMK").ToString()
                sql.Params("AUTH_TYPE") = dr("AUTH_TYPE").ToString()
                If dr.Table.Columns.Contains("RECVMSG_YN") Then
                    sql.Params("RECVMSG_YN") = dr("RECVMSG_YN").ToString
                    sql.Blocks("RECVMSG_YN") = True
                End If
                sql.Params("RANK") = dr("RANK").ToString()

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

        Public Shared Function UnLockUser(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim retDs As DataSet = New DataSet 
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True 

            Try
                If Not ds.Tables.Contains("MAIN") Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                Dim dr As DataRow = ds.Tables("MAIN").Rows(0)

                db.BeginTransaction()
                Dim NewPass As String = ""
                Dim Email As String = ""
                Dim ran As New Random
                For a = 1 To 10
                    Dim Key As Integer = ran.Next(0, 10)
                    Dim Value As Integer
                    If Key Mod 2 = 0 Then
                        Value = ran.Next(65, 90)
                    Else
                        Value = ran.Next(48, 57)
                    End If
                    NewPass &= Chr(Value)
                Next
                 
                sql = New SqlBox("MdmUserMgt@SearchDetail") 
                sql.Params("USR_ID") = dr("USR_ID") 
                Dim dt As DataTable = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    Email = dt.Rows(0)("EMAIL").ToString()
                End If
                If Trim(Email) = "" Then
                    ThrowMsg(ErrorOccur, "Email not found.")
                ElseIf Not Email.Contains("@") Then 
                    ThrowMsg(ErrorOccur, "Email format is not.")
                End If
                resultSet("Email") = Email


                sql = New SqlBox("Login@UpdateFailCnt")
                sql.Params("PSWD") = NewPass
                sql.Params("USR_ID") = dr("USR_ID")
                sql.Blocks("UNLOCK") = True
                db.SqlSet(sql.Text)

                resultSet("NewPass") = NewPass


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

        Public Shared Function ValidateUserId(ByVal UserId As String) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            Dim dt As DataTable
            Dim ResultSet As New Dictionary(Of String, Object)

            Try
                Dim sql As New SqlBox("MdmUserMgt@CheckUserId")
                sql.Params("USR_ID") = UserId
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    ResultSet("TrxCode") = "E"
                    ResultSet("TrxMsg") = "Error"
                Else
                    ResultSet("TrxCode") = "Y"
                    ResultSet("TrxMsg") = "Success"
                End If
            Catch ex As Exception
                ResultSet("TrxCode") = "E"
                ResultSet("TrxMsg") = ex.Message
            End Try

            Return ResultSet
        End Function

    End Class
End Namespace