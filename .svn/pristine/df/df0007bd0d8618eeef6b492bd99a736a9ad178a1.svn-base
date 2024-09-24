Imports System.Data
Imports System.Collections.Generic
Imports YJIT.Data

Public Enum LoginResult As Integer
    Successful = 0
    UserClosed = 1                'USE_YN = 'Y' or 'N'
    UserNotFound = 2
    WrongPassword = 3
    PasswordChange = 4
    UserLock = 5
    UserUnlock = 6
End Enum

Namespace YJIT

    ''' <summary>
    ''' Wrapper object of current authenticated/logged in user
    ''' </summary>
    ''' <remarks>Shared properties of this class are unique for each user session</remarks>
    Public Class SessionInfo

        ''' <summary>
        ''' Gets or set current logon user's ID
        ''' </summary>
        ''' <value></value>
        Public Shared Property MainJob() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.MAIN_JOB")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.MAIN_JOB") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's ID
        ''' </summary>
        ''' <value></value>
        Public Shared Property UserID() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.USR_ID")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.USR_ID") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's english name
        ''' </summary>
        Public Shared Property EnglishName() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.ENG_NM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.ENG_NM") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's local name
        ''' </summary>
        Public Shared Property LocalName() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.LOCAL_NM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.LOCAL_NM") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's handphone
        ''' </summary>
        Public Shared Property HandPhone() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.HP")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.HP") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's Telephone
        ''' </summary>
        Public Shared Property Telephone() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.TEL")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.TEL") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's Fax
        ''' </summary>
        Public Shared Property Fax() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.FAX")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.FAX") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's EMAIL
        ''' </summary>
        Public Shared Property Email() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.EMAIL")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.EMAIL") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's office code
        ''' </summary>
        Public Shared Property OfficeCode() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.OFFICE_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.OFFICE_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's organization code
        ''' </summary>
        Public Shared Property OrganizationCode() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.ORG_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.ORG_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's organization name
        ''' </summary>
        Public Shared Property OrganizationName() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.ORG_NM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.ORG_NM") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's Sales authorization level
        ''' </summary>
        Public Shared Property SalesLevel() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.SALES_LVL")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.SALES_LVL") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's authorization type
        ''' </summary>
        Public Shared Property AuthorizationType() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.AUTH_TYPE")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.AUTH_TYPE") = value
            End Set
        End Property

        Public Shared Property AccountLevel() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.ACT_LVL")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.ACT_LVL") = value
            End Set
        End Property



        ''' <summary>
        ''' Added By Bilgun
        ''' Gets or sets the default page for each user.
        ''' </summary>
        Public Shared Property AspxDefaultPage() As String
            Get
                Return HttpContext.Current.Session("MdmExtUsrMst.FIRST_LOAD_FORM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmExtUsrMst.FIRST_LOAD_FORM") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's english name
        ''' </summary>
        Public Shared Property MainBlForm() As String
            Get
                Return HttpContext.Current.Session("MdmUserMst.MAIN_BL_FORM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmUserMst.MAIN_BL_FORM") = value
            End Set
        End Property




        ''' <summary>
        ''' Process  user login
        ''' </summary>
        ''' <param name="sUserID">Input the user name</param>
        ''' <param name="sPassword">Input the password</param>
        ''' <returns>True: Successful, False: Failed</returns>
        ''' <remarks></remarks>
        Public Shared Function AuthenticateUser(ByVal sUserID As String, ByVal sPassword As String, Optional ByVal UseEncPass As Boolean = False, Optional ByRef dictReturn As Dictionary(Of String, Object) = Nothing) As LoginResult
            Dim db As DBA = New DBA()
            'Anti SQL Injection
            Dim arBlackList() As String = {"'", """", "(", ")", "{", "}", "-", "/", "\", " "}

            sUserID = sUserID.Trim
            sPassword = sPassword.Trim

            'Do not accept empty ID
            If sUserID = "" Then Return LoginResult.UserNotFound

            'Anti SQL injection by acception only username & password with non-backlist chars
            For i As Integer = 0 To arBlackList.Length - 1
                If sUserID.Contains(arBlackList(i)) Then
                    Return LoginResult.UserNotFound
                End If
                If sPassword.Contains(arBlackList(i)) Then
                    Return LoginResult.WrongPassword
                End If
            Next
            'Try to login and return to client
            Try
                Dim sql As SqlBox
                sql = New SqlBox("Login@CheckUser")
                sql.Params("UserID") = sUserID
                Dim dt As DataTable
                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count > 0 Then 
                    Dim LoginSuccess As Boolean = False

                    If YJIT.Utils.StringUtils.Md5Verify(sPassword, dt.Rows(0).Item("Password")) Then
                        LoginSuccess = True
                    Else
                        LoginSuccess = False
                    End If

                    'If String.Equals(sPassword, dt.Rows(0)("Password"), StringComparison.CurrentCulture) Then
                    '    LoginSuccess = True
                    'Else
                    '    LoginSuccess = False
                    'End If

                    If LoginSuccess Then
                        Return LoginResult.Successful
                    Else
                        Return LoginResult.WrongPassword
                    End If
                Else
                    Return LoginResult.UserNotFound
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Shared Function AuthenticateExternalUser(ByVal sUserID As String, ByVal sPassword As String, Optional ByVal UseEncPass As Boolean = False) As LoginResult
            Dim db As DBA = New DBA()
            'Anti SQL Injection
            Dim arBlackList() As String = {"'", """", "(", ")", "{", "}", "-", "/", "\", " "}

            sUserID = sUserID.Trim
            sPassword = sPassword.Trim

            'Do not accept empty ID
            If sUserID = "" Then Return LoginResult.UserNotFound

            'Anti SQL injection by acception only username & password with non-backlist chars
            For i As Integer = 0 To arBlackList.Length - 1
                If sUserID.Contains(arBlackList(i)) Then
                    Return LoginResult.UserNotFound
                End If
                If sPassword.Contains(arBlackList(i)) Then
                    Return LoginResult.WrongPassword
                End If
            Next
            'Try to login and return to client
            Try
                Dim sql As SqlBox
                sql = New SqlBox("ExternalLogin@CheckUser")
                sql.Params("UserID") = sUserID
                Dim dt As DataTable
                dt = db.SqlGet(sql.Text, False)

                If dt.Rows.Count > 0 Then
                    Dim PassWdFlag As String = dt.Rows(0)("CHANGE_PASS").ToString

                    'Detect locked/closed user
                    If dt.Rows(0)("UseYN") <> "Y" Then
                        Return LoginResult.UserClosed
                    End If

                    If dt.Rows(0)("LOCK_YN") = "Y" Then
                        Return LoginResult.UserLock
                    End If

                    Dim LoginSuccess As Boolean = False
                    'Verify password
                    If UseEncPass Then
                        If YJIT.Utils.StringUtils.Md5Verify(sPassword, dt.Rows(0).Item("Password")) Then
                            LoginSuccess = True
                        Else
                            LoginSuccess = False
                        End If
                    Else
                        If String.Equals(sPassword, dt.Rows(0)("Password"), StringComparison.CurrentCulture) Then
                            LoginSuccess = True
                        Else
                            LoginSuccess = False
                        End If
                    End If
                    sql = New SqlBox("ExternalLogin@UpdateFailCnt")
                    sql.Params("USR_ID") = sUserID
                    If LoginSuccess Then
                        sql.Blocks("SUCCESS") = True
                    Else
                        sql.Blocks("FAILED") = True
                    End If
                    db.SqlSet(sql.Text)


                    If LoginSuccess Then
                        If SessionOfficeInfo.Domain = "WMS.J-WALONG.COM" Then
                            Return LoginResult.Successful
                        End If
                        If PassWdFlag = "Y" Then
                            Return LoginResult.PasswordChange
                        ElseIf dt.Rows(0)("LOCK_YN").ToString = "R" Then
                            Return LoginResult.UserUnlock
                        End If
                        Return LoginResult.Successful
                    Else
                        Return LoginResult.WrongPassword
                    End If
                Else
                    Return LoginResult.UserNotFound
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        ''' <summary>
        ''' This method loads all authorization information such as which menu the user can use.
        ''' Also, set the session information here
        ''' </summary>
        ''' <param name="sUserID"></param>
        ''' <remarks>Return a dataset of session user information which will be used in client</remarks>
        Public Shared Function AuthorizeUser(ByVal sUserID As String) As DataSet
            Dim resDs As DataSet = New DataSet
            Dim db As New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim usrAuthCode As String = String.Empty

            '1. Init current logon user information============================================================
            sql = New SqlBox("Login@SearchUser")
            sql.Params("UserID") = sUserID

            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "UserInfo"
            resDs.Tables.Add(dt)

            'Even this user has been authenticated, we still check it existance
            If dt.Rows.Count = 0 Then
                Throw New Exception("Could not authorize user! User information is not existed!")       'It may be just deleted
            Else
                With dt.Rows(0)
                    SessionInfo.UserID = .Item("USR_ID") & ""
                    SessionInfo.EnglishName = .Item("ENG_NM") & ""
                    SessionInfo.LocalName = .Item("LOC_NM") & ""
                    SessionInfo.HandPhone = ""
                    SessionInfo.Telephone = ""
                    SessionInfo.Fax = ""
                    SessionInfo.Email = .Item("EMAIL")
                    SessionInfo.OfficeCode = .Item("OFFICE_CD")
                    SessionInfo.OrganizationCode = .Item("DEPT_CD").ToString
                    SessionInfo.OrganizationName = ""
                    SessionInfo.SalesLevel = ""
                    SessionInfo.AuthorizationType = .Item("AUTH_TYPE").ToString
                    SessionInfo.AccountLevel = ""
                    SessionInfo.MainJob = ""
                    SessionInfo.AspxDefaultPage = "/SEA/SeaCustSrMgt/ShippingRequestList.aspx"
                    SessionInfo.MainBlForm = ""
                    'SessionInfo.Email = .Item("GROUP_EMAIL")
                End With
            End If

            '2. Init the current login user's office information======================================================
            sql = New SqlBox("Login@SearchOffice")
            sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "OfficeInfo"
            resDs.Tables.Add(dt)

            'Even this user has been authenticated, we still check it existance
            If dt.Rows.Count = 0 Then
                Throw New Exception("Could not find Office information! ")       'It may be just deleted
            Else
                With dt.Rows(0)
                    SessionOfficeInfo.OfficeName = .Item("OFFICE_NM").ToString
                    SessionOfficeInfo.LocalName = .Item("LOC_NM").ToString
                    SessionOfficeInfo.LocalAddress = .Item("LOC_ADDR").ToString
                    SessionOfficeInfo.EnglishAddress = .Item("ENG_ADDR").ToString
                    SessionOfficeInfo.BlAddress = ""
                    SessionOfficeInfo.CurrencyCode = ""
                    SessionOfficeInfo.CountryCode = ""
                    SessionOfficeInfo.DecimalPoint = """"
                    SessionOfficeInfo.AirPortCode = ""
                    SessionOfficeInfo.AirPortName = ""
                    SessionOfficeInfo.SeaPortCode = ""
                    SessionOfficeInfo.SeaPortName = ""
                    SessionOfficeInfo.AirBlPrefix = .Item("AIR_BL_PREFIX").ToString
                    SessionOfficeInfo.SeaBlPrefix = .Item("SEA_BL_PREFIX").ToString
                    SessionOfficeInfo.OfficePrefix = .Item("OFFICE_PREFIX").ToString
                    SessionOfficeInfo.HqOfficeCode = .Item("HQ_OFFICE_CD").ToString
                    SessionOfficeInfo.DecimalNumberFormat = ""
                    SessionOfficeInfo.LanguageCode = .Item("LANG_CD").ToString
                    SessionOfficeInfo.CustomsCode = .Item("CUSTOMS_CD").ToString
                    SessionOfficeInfo.AirFrtCode = ""
                    SessionOfficeInfo.SeaFrtCode = ""
                    SessionOfficeInfo.VatPer = ""
                    SessionOfficeInfo.City = ""
                    SessionOfficeInfo.AutoSlipByTax = ""
                    SessionOfficeInfo.AutoInvoice = ""
                    SessionOfficeInfo.VatFreightCode = ""
                    SessionOfficeInfo.VatFreightName = ""
                    SessionOfficeInfo.PfmByOperator = ""
                    SessionOfficeInfo.DateFormat = ""
                    SessionOfficeInfo.EstablishYear = ""
                    SessionOfficeInfo.FcurExrateRequired = ""
                    SessionOfficeInfo.UsingTracking = ""
                    SessionOfficeInfo.eTruckBankInterface = ""
                    SessionOfficeInfo.LogoType = ""

                End With
            End If

            Return resDs

        End Function


        ''' <summary>
        ''' Added by Bilguun
        ''' Authorizes web users. This method loads all authorization information such as which menu the user can use.
        ''' Also, set the session information here
        ''' </summary>
        ''' <param name="sUserID"></param>
        ''' <remarks>Return a dataset of session user information which will be used in client</remarks>
        Public Shared Function AuthorizeExternalUser(ByVal sUserID As String) As DataSet
            Dim resDs As DataSet = New DataSet
            Dim db As New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable
            Dim usrAuthCode As String = String.Empty

            '1. Init current logon user information============================================================
            sql = New SqlBox("ExternalLogin@SearchUser")
            sql.Params("UserID") = sUserID

            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "UserInfo"
            resDs.Tables.Add(dt)

            'Even this user has been authenticated, we still check it existance
            If dt.Rows.Count = 0 Then
                Throw New Exception("Could not authorize user! User information is not existed!")       'It may be just deleted
            Else
                With dt.Rows(0)
                    SessionInfo.UserID = .Item("USR_ID") & ""
                    SessionInfo.EnglishName = .Item("ENG_NM") & ""
                    SessionInfo.LocalName = .Item("LOC_NM") & ""
                    SessionInfo.HandPhone = .Item("HP_NO") & ""
                    SessionInfo.Telephone = .Item("TEL_NO") & ""
                    SessionInfo.Fax = .Item("FAX_NO") & ""
                    SessionInfo.Email = .Item("EMAIL") & ""
                    SessionInfo.OfficeCode = .Item("OFFICE_CD") & ""
                    SessionInfo.AuthorizationType = .Item("AUTH_TYPE") & ""
                    SessionInfo.AspxDefaultPage = .Item("FIRST_LOAD_FORM") & ""
                End With
            End If

            '2. Init the current login user's office information======================================================
            sql = New SqlBox("ExternalLogin@SearchOffice")
            sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "OfficeInfo"
            resDs.Tables.Add(dt)

            'Even this user has been authenticated, we still check it existance
            If dt.Rows.Count = 0 Then
                'Throw New Exception("Could not find Office information! ")       'It may be just deleted
            Else
                With dt.Rows(0)
                    SessionOfficeInfo.OfficeName = .Item("OFFICE_NM") & ""
                    SessionOfficeInfo.LocalName = .Item("LOC_NM") & ""
                    SessionOfficeInfo.LocalAddress = .Item("LOC_ADDR") & ""
                    SessionOfficeInfo.EnglishAddress = .Item("ENG_ADDR") & ""
                    SessionOfficeInfo.BlAddress = .Item("BL_ADDR") & ""
                    SessionOfficeInfo.CurrencyCode = .Item("CURR_CD") & ""
                    SessionOfficeInfo.CountryCode = .Item("CTRY_CD") & ""
                    SessionOfficeInfo.DecimalPoint = .Item("DCM_POINT") & ""
                    SessionOfficeInfo.AirPortCode = .Item("AIR_PORT_CD") & ""
                    SessionOfficeInfo.AirPortName = .Item("AIR_PORT_NM") & ""
                    SessionOfficeInfo.SeaPortCode = .Item("SEA_PORT_CD") & ""
                    SessionOfficeInfo.SeaPortName = .Item("SEA_PORT_NM") & ""
                    SessionOfficeInfo.AirBlPrefix = .Item("AIR_BL_PREFIX") & ""
                    SessionOfficeInfo.SeaBlPrefix = .Item("SEA_BL_PREFIX") & ""
                    SessionOfficeInfo.OfficePrefix = .Item("OFFICE_PREFIX") & ""
                    SessionOfficeInfo.HqOfficeCode = .Item("HQ_OFFICE_CD") & ""
                    SessionOfficeInfo.DecimalNumberFormat = "N(15," & SessionOfficeInfo.DecimalPoint & ")"
                    SessionOfficeInfo.LanguageCode = .Item("LANG_CD") & ""
                    SessionOfficeInfo.CustomsCode = .Item("CUSTOMS_CD") & ""
                    SessionOfficeInfo.AirFrtCode = .Item("AIR_FRT_CD") & ""
                    SessionOfficeInfo.SeaFrtCode = .Item("SEA_FRT_CD") & ""
                    SessionOfficeInfo.VatPer = .Item("VAT_PER") & ""
                    SessionOfficeInfo.City = .Item("CITY_CD") & ""
                    SessionOfficeInfo.AutoSlipByTax = .Item("AUTO_SLIP_BY_TAX") & ""
                    SessionOfficeInfo.AutoInvoice = .Item("AUTO_INVOICE") & ""
                    SessionOfficeInfo.VatFreightCode = .Item("VAT_FRT_CD") & ""
                    SessionOfficeInfo.VatFreightName = .Item("VAT_FRT_NM") & ""
                    SessionOfficeInfo.PfmByOperator = .Item("PFM_BY_OP") & ""

                End With
            End If

            Return resDs

        End Function

    End Class


End Namespace
