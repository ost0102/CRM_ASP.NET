Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports System.Collections.Generic

Namespace YJIT.Biz

    Public Class MainForm

        Public Shared Function RetrieveLoginInformation() As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()

            'Retrieve current login session information
            Dim sql As SqlBox
            Dim dt As DataTable

            Try
                '1. Retrieve current logon user information============================================================
                sql = New SqlBox("Login@RET_USER")
                sql.Params("UserID") = SessionInfo.UserID
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "UserInfo"
                resDs.Tables.Add(dt)


                '2. Retrieve current logon user information============================================================
                sql = New SqlBox("Login@RET_OFFICE")
                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "OfficeInfo"
                resDs.Tables.Add(dt)

                '3. Retrieve current logon user Accounting settings============================================================
                sql = New SqlBox("Login@RET_OFFICE_ACCT")
                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "OfficeAcctSettings"
                resDs.Tables.Add(dt)

                '4. Retrieve current logon user  settings============================================================



                resultSet("TrxCode") = "SUCCESS"

                resultSet("Data") = resDs
            Catch ex As Exception
                Throw New Exception("Could not retrieve user's login session information!", ex)
            End Try

           

            Return resultSet
        End Function

        Public Shared Function RetrieveUserPgmAuthorities() As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()

            'Retrieve current login session information
            Dim sql As SqlBox
            Dim dt As DataTable

            '1. Init current logon user information============================================================
            'sql = New SqlBox("Login@AuthCheck")
            'sql.Params("USR_ID") = SessionInfo.UserID
            'dt = db.SqlGet(sql.Text, False)

            sql = New SqlBox("Login@SearchUserPgmAuth")
            sql.Params("USR_ID") = SessionInfo.UserID
            dt = db.SqlGet(sql.Text, False)

            If SessionInfo.UserID.ToUpper = "ADMIN" Then
                resultSet("TrxCode") = "ADMIN"       'THIS IS SPECIAL USER THAT HAS FULL CONTROLS OVER SYSTEM
            ElseIf dt.Rows.Count > 0 Then
                resultSet("TrxCode") = "SUCCESS"
            Else
                resultSet("TrxCode") = "NODATA"
                resultSet("TrxMsg") = "Login user is not found!"
            End If

            'resultSet("TrxCode") = "ADMIN" : dt = New DataTable 'For test only

            dt.TableName = "UserPgmAuthInfo"

            resDs.Tables.Add(dt)

            resultSet("Data") = resDs

            Return resultSet
        End Function

        Public Shared Function RetrieveUserFuncAuthorities(ByVal pgmName As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()

            'Retrieve current login session information
            Dim sql As SqlBox
            Dim dt As DataTable

            '1. Init current logon user information============================================================
            sql = New SqlBox("Login@SearchUserFuncAuth")
            sql.Params("USR_ID") = SessionInfo.UserID
            sql.Params("PGM_ID") = pgmName

            dt = db.SqlGet(sql.Text, False)

            If SessionInfo.UserID.ToUpper = "ADMIN" Then
                resultSet("TrxCode") = "ADMIN"       'THIS IS SPECIAL USER THAT HAS FULL CONTROLS OVER SYSTEM
            ElseIf dt.Rows.Count > 0 Then
                resultSet("TrxCode") = "SUCCESS"
            Else
                resultSet("TrxCode") = "NODATA"
                resultSet("TrxMsg") = "Login user is not found!"
            End If
            'resultSet("TrxCode") = "ADMIN" : dt = New DataTable 'For test only


            dt.TableName = "UserFuncAuthInfo"

            resDs.Tables.Add(dt)

            resultSet("Data") = resDs

            Return resultSet
        End Function


        Public Shared Function RetrieveMenu(ByVal userID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            'Retrieve current login session information
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim dtMy As DataTable
            Try
                '1. Init current logon user information============================================================
                sql = New SqlBox("Login@RetrieveMenu")
                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                sql.Params("OFFICE_HQ") = SessionOfficeInfo.HqOfficeCode

                dt = db.SqlGet(sql.Text, False)

                dt.TableName = "Menu"

                'If SessionOfficeInfo.UseLiteVer = "Y" Then
                '    ' My Menu 에 등록된 메뉴 추가 표시
                '    sql = New SqlBox("Login@RetrieveMyMenu")
                '    sql.Params("OFFICE_HQ") = SessionOfficeInfo.HqOfficeCode
                '    sql.Params("USR_ID") = SessionInfo.UserID
                '    dtMy = db.SqlGet(sql.Text, False)
                '    dtMy.TableName = "MyMenu"
                '    dt.Merge(dtMy)
                'End If

                resDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = resDs
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function RetrieveMenuPosition(ByVal userID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            'Retrieve current login session information
            Dim sql As SqlBox
            Dim dt As DataTable
            Try
                '1. Init current logon user information============================================================
                sql = New SqlBox("Login@RetrieveMenuPosition")
                sql.Params("USR_ID") = SessionInfo.UserID

                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "MenuPosition"
                resDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("Data") = resDs
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function RetrieveDLLFileName(ByVal programID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            'Retrieve current login session information
            Dim sql As SqlBox
            Dim dt As DataTable
            Try
                '1. Init current logon user information============================================================
                sql = New SqlBox("Login@RetrieveDLLFileName")
                sql.Params("PGM_ID") = programID

                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "DLL_NAME"
                resDs.Tables.Add(dt)

                resultSet("TrxCode") = "Y"
                resultSet("Data") = resDs
            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

    End Class
End Namespace
