Imports System
Imports System.Data
Imports System.Collections.Generic
Imports System.Reflection
Imports System.ServiceModel.Activation
Imports System.ServiceModel

Namespace YJIT.WCF

    ''' <summary>
    ''' The main gateway to access all the biz-logic
    ''' </summary>
    ''' <remarks>
    ''' 1. InstanceContextMode = PerSession: one service instance per all calls from one Proxy Client
    ''' 2. Make sure all exceptions must be handled here, otherwise, the WCF service instance will turn to Fault state,
    '''    which will not be able to call next time
    ''' 3. In case of server exception, try to inform client the message, so that developer can debug at the server biz-logic
    ''' </remarks>
    <AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Required), ServiceBehavior(AddressFilterMode:=AddressFilterMode.Any, InstanceContextMode:=InstanceContextMode.PerSession)> _
    Public Class BizService
        Implements IBizService
        Public Shared preloadDS As DataSet = Nothing '20170403 김성은 중복체크 / 변수 선언 

        Enum LoginStatus
            NewSetting = 0
            EndSetting = 1
            Notexist = 2
        End Enum

        Private Function getDictParamFromTable(ByVal dsSource As DataSet, ByVal sTablename As String) As Dictionary(Of String, Object)
            Dim dictResult As New Dictionary(Of String, Object)
            Dim dtSource As DataTable = dsSource.Tables(sTablename)
            For i As Integer = 0 To dtSource.Columns.Count - 1
                dictResult(dtSource.Columns(i).ColumnName) = dtSource.Rows(0)(dtSource.Columns(i).ColumnName)
            Next
            Return dictResult
        End Function
        Private Function getArrayParamFromTable(ByVal dsSource As DataSet, ByVal sTableName As String) As Array
            Dim dtSource As DataTable = dsSource.Tables(sTableName)
            Dim arrResult(dtSource.Columns.Count - 1) As Object
            For i As Integer = 0 To dtSource.Columns.Count - 1
                arrResult(i) = dtSource.Rows(0)(i)
            Next
            Return arrResult
        End Function

        Public Overridable Function MethodCall(ByVal controllerID As String, ByVal actionID As String, ByVal dsParams As DataSet) As System.Data.DataSet Implements IBizService.MethodCall
            Dim dictReturn As New Dictionary(Of String, Object)
            'Extract client info
            Dim dtClientInfo As DataTable = dsParams.Tables("WCF_CLIENT_INFO")
            'Before all, check & process domain info to register session-domain

            '이병호 20140210 login status -> customs  setting or end setting or found not info
            Dim LgStatus As LoginStatus = processSessionDomain(dtClientInfo)

            'Try
            '    If LgStatus = LoginStatus.Notexist Then
            '        dictReturn("Status") = "FAIL"
            '        dictReturn("StatusMessage") = "Domain is invalid! Please contact Administrator!" '"Could not process your domain information!"
            '        Return dict2Ds(dictReturn, Nothing, "")
            '    End If
            'Catch ex As Exception
            '    dictReturn("Status") = "FAIL"
            '    dictReturn("StatusMessage") = "Could not process Session Domain!" & ex.Message
            '    Return dict2Ds(dictReturn, Nothing, "")
            'End Try

            '20170403 김성은 중복체크 / 로그인시 중복 체크 
            Call GetSingleLogin(SingleLoginType.TableAdd, preloadDS, dsParams)


            '20170403 김성은 중복체크 / 로그인시 중복 체크 
            Call GetSingleLogin(SingleLoginType.RowAdd, preloadDS, dsParams)


            If controllerID = "YJIT.Biz" AndAlso actionID = "ResetLogin" Then
                '20170403 김성은 중복체크 / 로그인시 중복 체크 
                Try
                    Call GetSingleLogin(SingleLoginType.RowRemove, preloadDS, dsParams)

                    dictReturn("Status") = "SUCCESS"
                    dictReturn("StatusMessage") = "기존 아이디가 로그아웃 되었습니다." 'The ID loged out at the other place.
                Catch ex As Exception
                    dictReturn("Status") = "FAIL"
                    dictReturn("StatusMessage") = ex.Message
                End Try
            ElseIf controllerID = "YJIT.Biz" AndAlso actionID = "RequestLogin" Then
                'First time, WCF client must pass this login
                Try
                    Dim userID As String = dsParams.Tables("WCF_CLIENT_INFO").Rows(0)("USERID")
                    Dim userPwd As String = dsParams.Tables("WCF_CLIENT_INFO").Rows(0)("PASSWORD")

                    '20170403 김성은 중복체크 / 로그인시 중복 체크 
                    Try
                        Select Case GetSingleLogin(SingleLoginType.MacAddrCheck, preloadDS, dsParams)
                            Case False
                                dictReturn("Status") = "LOGIN_DUPLICATE"
                                dictReturn("StatusMessage") = "같은 아이디로 로그인 되어 있으므로 중복 로그인 할 수 없습니다." 'You cannot logon becase the ID already log in at the other place.

                                Dim drLoginInfo() As DataRow = preloadDS.Tables("SINGLE_LOGIN").Select("DOMAIN = '" & dsParams.Tables("WCF_CLIENT_INFO").Rows(0)("DOMAIN") & "' AND USR_ID = '" & dsParams.Tables("WCF_CLIENT_INFO").Rows(0)("USERID") & "' ")
                                dictReturn("StatusMessage2") = String.Format("(IP Address : {0}, MAC Address : {1}, Login Datetime : {2})", drLoginInfo(0)("IP_ADDR"), drLoginInfo(0)("MAC_ADDR"), drLoginInfo(0)("LOGIN_DATE"))

                                Return dict2Ds(dictReturn, Nothing, "")
                        End Select
                    Catch ex As Exception
                        dictReturn("Status") = "FAIL"
                        dictReturn("StatusMessage") = ex.Message
                    End Try

                    Select Case YJIT.SessionInfo.AuthenticateUser(userID, userPwd, YJIT.Config.UseEncPass, dictReturn)
                        Case LoginResult.Successful
                            HttpContext.Current.Session("YJIT.SC.WCF.CONNECTION") = "Y"  'Connection detect

                            'If LgStatus = LoginStatus.NewSetting Then
                            '    dictReturn("Status") = "WIZARD"
                            '    dictReturn("StatusMessage") = ""
                            'Else
                            '    dictReturn("Status") = "SUCCESS"
                            '    dictReturn("StatusMessage") = "User is authenticated!"
                            'End If
                            dictReturn("Status") = "SUCCESS"
                            dictReturn("StatusMessage") = "User is authenticated!"
                        Case LoginResult.UserClosed
                            dictReturn("Status") = "FAIL"
                            dictReturn("StatusMessage") = "User has been closed!"
                        Case LoginResult.UserNotFound
                            dictReturn("Status") = "FAIL"
                            dictReturn("StatusMessage") = "User is not found!"
                        Case LoginResult.WrongPassword
                            dictReturn("Status") = "FAIL"
                            dictReturn("StatusMessage") = "Password is incorrect!" & " (" & dictReturn("FailCnt") & " times)"
                        Case LoginResult.UserLock
                            dictReturn("Status") = "FAIL"
                            dictReturn("StatusMessage") = "This user has been locked."
                        Case LoginResult.PasswordChange
                            dictReturn("Status") = "CHANGE"
                            dictReturn("StatusMessage") = "This password has used more than three months."
                        Case LoginResult.UserUnlock
                            dictReturn("Status") = "UNLOCK"
                            dictReturn("StatusMessage") = "This ID was initialised a password by Administrator."
                        Case Else
                            dictReturn("Status") = "FAIL"
                            dictReturn("StatusMessage") = "Login failed! Unknown reason!"
                    End Select


                Catch ex As Exception
                    dictReturn("Status") = "FAIL"
                    dictReturn("StatusMessage") = "Error while authenticate user!" & ex.Message
                End Try
            ElseIf Not dsParams.Tables.Contains("WCF_CLIENT_INFO") Then
                dictReturn("Status") = "INVALID_CLIENT_INFO"
            Else
                Dim CheckUser As Boolean = False
                If Not authenticateWCFClient(dtClientInfo) Then
                    dictReturn("Status") = "UNAUTHORIZED"
                Else
                    '20170403 김성은 중복체크 / 로그인시 중복 체크 
                    Try
                        Select Case GetSingleLogin(SingleLoginType.MacAddrCheck, preloadDS, dsParams)
                            Case False
                                dictReturn("Status") = "FAIL"
                                dictReturn("StatusMessage") = "다른곳에서 같은 아이디로 로그인 되어 있습니다. 확인 후 재로그인 하십시오." 'The ID loged on at the other place. Please log on again.
                                dictReturn("TrxCode") = "FAIL"
                                dictReturn("TrxMsg") = "다른곳에서 같은 아이디로 로그인 되어 있습니다. 확인 후 재로그인 하십시오." 'The ID loged on at the other place. Please log on again.

                                Return dict2Ds(dictReturn, Nothing, "")
                        End Select
                    Catch ex As Exception
                        dictReturn("Status") = "FAIL"
                        dictReturn("StatusMessage") = ex.Message
                    End Try

                    Try
                        'Create the parameter arrays based on each situations
                        Dim params(1) As Object

                        If controllerID.ToUpper.StartsWith("YJIT.CODESERVICE.") Then
                            'This is the code service request, and should be handle specially
                            Select Case actionID.ToUpper
                                Case "LIST", "SEARCH"            'Code list & search are same call
                                    Dim dictSearchParamValues As Dictionary(Of String, Object) = getDictParamFromTable(dsParams, "SEARCH_KEY_VALUES")
                                    Dim dictDataParamValues As Dictionary(Of String, Object) = getDictParamFromTable(dsParams, "DATA_PARAM_VALUES")
                                    Dim arrOtherParamValues() As Object = getArrayParamFromTable(dsParams, "OTHER_PARAM_VALUES")
                                    ReDim params(arrOtherParamValues.Length + 2 - 1)
                                    params(0) = dictSearchParamValues
                                    params(1) = dictDataParamValues
                                    For i As Integer = 0 To arrOtherParamValues.Length - 1
                                        params(i + 2) = arrOtherParamValues(i)
                                    Next

                                Case "VALIDATE"
                                    Dim dictValidateKeyValues As Dictionary(Of String, Object) = getDictParamFromTable(dsParams, "VALIDATE_KEY_VALUES")
                                    Dim dictDataParamValues As Dictionary(Of String, Object) = getDictParamFromTable(dsParams, "DATA_PARAM_VALUES")
                                    ReDim params(1)
                                    params(0) = dictValidateKeyValues
                                    params(1) = dictDataParamValues
                            End Select
                        Else
                            If dsParams.Tables.Contains("ARRAY_VALUES") Then
                                'The parameters of function is array
                                Dim dt As DataTable = dsParams.Tables("ARRAY_VALUES")
                                ReDim params(dt.Columns.Count - 1)
                                For i As Integer = 0 To dt.Columns.Count - 1
                                    If "" & dt.Rows(0)(i) = "MISSING_MAIN_DATASET" Then
                                        'The only one dataset within parameters array
                                        params(i) = dsParams
                                    Else
                                        params(i) = dt.Rows(0)(i)
                                    End If
                                Next
                                'Optional: remove the array_values table
                                dsParams.Tables.Remove(dt)
                            Else
                                'The parameter is dataset type
                                ReDim params(0)
                                params(0) = dsParams
                            End If
                        End If

                        dictReturn = invokeMethod(controllerID, actionID, params)

                        If dictReturn Is Nothing Then
                            dictReturn = New Dictionary(Of String, Object)
                            dictReturn("Status") = "RETURN_NOTHING"
                            dictReturn("StatusMessage") = "Server method returns nothing!"
                        End If

                    Catch ex As Exception
                        dictReturn("Status") = "SERVER_ERROR"
                        dictReturn("StatusMessage") = getDebugTextInfo(ex)
                    End Try
                End If

            End If
            Return dict2Ds(dictReturn, Nothing, "")
        End Function

        Public Function MethodCallJson(ByVal controllerId As String, ByVal actionId As String, ByVal dsParams As System.Data.DataSet) As String Implements IBizService.MethodCallJson
            Dim ds As DataSet = Me.MethodCall(controllerId, actionId, dsParams)
            'Harry(2014/03/10): tested carefully => fastJSON has faster performance & optimized output (especially datatable data) than NewtonSoft's JSON.NET
            'Ref: http://fastjson.codeplex.com/
            Return fastJSON.JSON.Instance.ToJSON(ds)
        End Function


#Region "===========Helper methods============"

        '20170403 김성은 중복체크
        Public Shared Function GetLoginList() As DataTable
            Return preloadDS.Tables("SINGLE_LOGIN")
        End Function

        Private Function GetDomainList() As DataTable
            Dim dbAdmin As New YJIT.Data.DBA(YJIT.Data.DbConfiguration.Current.ConnectionString, YJIT.Data.DbConfiguration.Current.DatabaseType)
            Dim sql As New YJIT.Data.SqlBox("Login@GetDmoainList")
            Dim dt As DataTable = dbAdmin.SqlGet(sql.Text, False)
            dt.TableName = "DomainList"
            Return dt
        End Function
        'Harry (20130926): If user login with domain =>Create own domain-based session

        Private Function processSessionDomain(ByVal dtInfo As DataTable) As LoginStatus
            Dim domain As String = ""
            If dtInfo.Columns.Contains("DOMAIN") Then 'Optional
                domain = Trim(dtInfo.Rows(0)("DOMAIN"))
            End If

            If domain = "" Then 'User login without domain information => accept to login to db defined in web.config
                YJIT.Data.DbConfiguration.ActiveSessionDomain = String.Empty
                YJIT.Data.DbConfiguration.ActiveSessionDBConnStr = String.Empty
                YJIT.Data.DbConfiguration.ActiveSessionDBType = String.Empty
                SessionOfficeInfo.Domain = String.Empty
            Else
                '현재 세션 도메인과 호출한 도메인을 비교후
                '처음(호출시(로그인))
                If YJIT.Data.DbConfiguration.ActiveSessionDomain <> domain Then 'Only process if different

                    'Dim dbAdmin As New YJIT.Data.DBA(YJIT.Data.DbConfiguration.Current.ConnectionString, YJIT.Data.DbConfiguration.Current.DatabaseType)
                    'Dim sql As New YJIT.Data.SqlBox("Login@GET_DOMAIN_DB_INFO")
                    'sql.Params("DOMAIN") = domain
                    'Dim dt As DataTable = dbAdmin.SqlGet(sql.Text, False)
                    'If dt.Rows.Count > 0 Then 'Domain information found 

                    '    SessionOfficeInfo.Domain = domain
                    '    If YJIT.Data.DbConfiguration.Current.DatabaseType = "ORACLE" Then
                    '        'Set the session domain name (per session)
                    '        YJIT.Data.DbConfiguration.ActiveSessionDomain = domain
                    '        'Make up connection string manually
                    '        YJIT.Data.DbConfiguration.ActiveSessionDBConnStr = "Data Source=" & dt.Rows(0)("TNS_NM") & _
                    '            ";User Id=" & dt.Rows(0)("USR_ID") & ";Password=" & dt.Rows(0)("USR_PWD") & _
                    '            ";Integrated Security=no;Connection Lifetime=0;Min Pool Size=0;Max Pool Size=100;Pooling=true;Unicode=true"
                    '        YJIT.Data.DbConfiguration.ActiveSessionDBType = "ORACLE"
                    '    Else
                    '        'Pending: Define custom connection string for other database
                    '    End If

                    '    SessionOfficeInfo.CustomsSetting = "N"
                    '    'Return LoginStatus.EndSetting

                    'Else
                    '    Return LoginStatus.Notexist
                    'End If

                    SessionOfficeInfo.Domain = domain
                    YJIT.Data.DbConfiguration.ActiveSessionDomain = domain
                    YJIT.Data.DbConfiguration.ActiveSessionDBConnStr = YJIT.Data.DbConfiguration.Current.ConnectionString
                    YJIT.Data.DbConfiguration.ActiveSessionDBType = "ORACLE"
                    SessionOfficeInfo.CustomsSetting = "N"
                    Return LoginStatus.EndSetting

                Else
                    '서비스 콜할때 
                    'SessionOfficeInfo.CustomsSetting 셋팅한값에따라 리턴
                    If SessionOfficeInfo.CustomsSetting = "Y" Then
                        Return LoginStatus.NewSetting
                    Else
                        Return LoginStatus.EndSetting
                    End If
                End If
            End If
            'Process Domain ok
            Return LoginStatus.Notexist
        End Function

        Private Function authenticateWCFClient(ByVal dtInfo As DataTable) As Boolean
            If dtInfo Is Nothing OrElse dtInfo.Rows.Count = 0 Then
                Return False
            Else
                Dim userId As String = dtInfo.Rows(0)("USERID")
                Dim passWord As String = dtInfo.Rows(0)("PASSWORD")

                If userId = "DEMON" And passWord = "YJITDEMON" Then
                    Return True
                ElseIf userId = "KCTCINTL" And passWord = "KCTCINTL!@!(1102" Then
                    Return True
                ElseIf userId = "ELVIS_TWSC" And passWord = "TWSC!)%#0705" Then
                    Return True
                ElseIf userId = "ELVIS_SEBANG" And passWord = "GEXX@)@#0703" Then
                    Return True
                End If
                'Check if the client session has been setup from previous WCF request
                If SessionInfo.UserID = userId AndAlso userId <> "" Then
                    Return True
                Else 'Timeout or new request
                    Dim RESULT As LoginResult = SessionInfo.AuthenticateUser(userId, passWord, YJIT.Config.UseEncPass)
                    If RESULT = LoginResult.Successful Or RESULT = LoginResult.PasswordChange Then
                        'The AuthenticateUser() function if true will then re-create the session info of client
                        If SessionOfficeInfo.CustomsSetting = "N" Then
                            SessionInfo.AuthorizeUser(userId)
                        End If

                        'CONNECTION JUST LOST => Will not handel here because WCF Client will receive System.ServiceModel.CommunicationException("Unrecognized messae version")
                        'Return True
                        If HttpContext.Current.Session("YJIT.SC.WCF.CONNECTION") & "" = "" Then     'WCF Connection Lost
                            Return False
                        Else
                            Return True
                        End If
                    Else
                        Return False
                    End If
                End If
            End If
        End Function
        Private Function authenticateExternalWCFClient(ByVal dtInfo As DataTable) As Boolean
            If dtInfo Is Nothing OrElse dtInfo.Rows.Count = 0 Then
                Return False
            Else
                Dim userId As String = dtInfo.Rows(0)("USERID")
                Dim passWord As String = dtInfo.Rows(0)("PASSWORD")

                'Check if the client session has been setup from previous WCF request
                If SessionInfo.UserID = userId AndAlso userId <> "" Then
                    Return True
                Else 'Timeout or new request
                    Dim RESULT As LoginResult = SessionInfo.AuthenticateExternalUser(userId, passWord, YJIT.Config.UseEncPass)
                    If RESULT = LoginResult.Successful Or RESULT = LoginResult.PasswordChange Then
                        'The AuthenticateUser() function if true will then re-create the session info of client
                        If SessionOfficeInfo.CustomsSetting = "N" Then
                            SessionInfo.AuthorizeExternalUser(userId)
                        End If
                        Return True
                    Else
                        Return False
                    End If
                End If
            End If
        End Function

        Private Function invokeMethod(ByVal controllerID As String, ByVal actionID As String, ByVal parameters() As Object) As Dictionary(Of String, Object)
            Dim ass As Assembly = Assembly.GetAssembly(Me.GetType)
            Dim sCodeURI As String = controllerID
            Dim oCodeInstance As Object
            Dim mtdInfo As MethodInfo
            Dim dictRet As Dictionary(Of String, Object) = Nothing
            oCodeInstance = ass.CreateInstance(sCodeURI, True)

            If oCodeInstance IsNot Nothing Then
                mtdInfo = oCodeInstance.GetType.GetMethod(actionID)
                If mtdInfo IsNot Nothing Then
                    Try
                        'Try to adapt parameter types
                        Dim defParams() As ParameterInfo = mtdInfo.GetParameters()
                        If defParams.Length <> parameters.Length Then
                            Throw New Exception("Number of parameters is not matched between method calling and definition!")
                        End If

                        'dictRet = mtdInfo.Invoke(oCodeInstance, Nothing, Nothing, parameters, Nothing)

                        'Dim startDateTime As DateTime = Now
                        dictRet = mtdInfo.Invoke(oCodeInstance, Nothing, Nothing, parameters, Nothing)
                        'Dim endDateTime As DateTime = Now

                        'Try
                        '    If controllerID.StartsWith("YJIT.CodeService") Then
                        '        YJIT.Biz.SysWcfLog.Save(controllerID & "." & actionID, parameters, startDateTime, endDateTime, "", "", Nothing, SessionInfo.UserID, SessionInfo.OfficeCode)
                        '    Else
                        '        YJIT.Biz.SysWcfLog.Save(controllerID & "." & actionID, parameters, startDateTime, endDateTime, dictRet("TrxCode"), dictRet("TrxMsg"), Nothing, SessionInfo.UserID, SessionInfo.OfficeCode)
                        '    End If
                        'Catch ex As Exception
                        '    Dim dicTrxCode As String = String.Empty
                        '    Dim dicTrxMsg As String = String.Empty
                        '    If dictRet.ContainsKey("TrxCode") Then dicTrxCode = dictRet("TrxCode")
                        '    If dictRet.ContainsKey("TrxMsg") Then dicTrxMsg = dictRet("TrxMsg")
                        '    endDateTime = Now
                        '    Call SendErrMsg(ex.Message, controllerID & "." & actionID, parameters, startDateTime, endDateTime, dicTrxCode, dicTrxMsg)
                        'End Try
                    Catch ex As Exception
                        Throw New Exception(controllerID & "->" & actionID & " is failed to invoke!", ex)
                    End Try
                Else
                    Throw New Exception(controllerID & "->" & actionID & " is not defined!")
                End If
            Else
                Throw New Exception(controllerID & " is not defined!")
            End If

            'Return to the caller
            Return dictRet
        End Function

        Private Sub SendErrMsg(ByVal ErrMsg As String, ByVal WcfId As String, ByVal Params() As Object, ByVal StartYmdhm As DateTime, ByVal EndYmdhm As DateTime, ByVal RtnCd As String, ByVal RtnMsg As String)
            Try
                Dim sBody As String = "CRM SysWcfLog 오류가 발생했습니다."
                sBody &= vbCrLf & ErrMsg
                sBody &= vbCrLf & vbCrLf & vbCrLf & "## 상세정보 ##"
                sBody &= vbCrLf & "Domain : " & SessionOfficeInfo.Domain
                sBody &= vbCrLf & "WcfId : " & WcfId
                Dim paramsDS As String = String.Empty
                Dim paramsSTR As String = String.Empty
                For Each param As Object In Params
                    If TypeOf param Is DataSet Then
                        paramsDS = paramsDS & CType(param, DataSet).GetXml
                    Else
                        If paramsSTR <> "" Then paramsSTR = paramsSTR & ","

                        paramsSTR = paramsSTR & param.ToString
                    End If
                Next
                If Not String.IsNullOrEmpty(paramsDS) AndAlso Not String.IsNullOrEmpty(paramsSTR) Then
                    sBody &= vbCrLf & "Params(DataSet) : " & paramsDS
                    sBody &= vbCrLf & "Params(String) : " & paramsSTR
                ElseIf Not String.IsNullOrEmpty(paramsDS) Then
                    sBody &= vbCrLf & "Params(DataSet) : " & paramsDS
                ElseIf Not String.IsNullOrEmpty(paramsSTR) Then
                    sBody &= vbCrLf & "Params(String) : " & paramsSTR
                Else
                    sBody &= vbCrLf & "Params() : "
                End If
                sBody &= vbCrLf & "StartYmdhm : " & StartYmdhm
                sBody &= vbCrLf & "EndYmdhm : " & EndYmdhm
                sBody &= vbCrLf & "ResHm : " & (EndYmdhm - StartYmdhm).TotalSeconds
                sBody &= vbCrLf & "RtnCd : " & RtnCd
                sBody &= vbCrLf & "RtnMsg : " & RtnMsg
                sBody &= vbCrLf & "UserCode : " & SessionInfo.UserID
                sBody &= vbCrLf & "OfficeCode : " & SessionInfo.OfficeCode

                Call YJIT.BIZ.MailDemon.sendEmail("nnow@yjit.co.kr", "nnow@yjit.co.kr", "", "[양재아이티] SysWcfLog 오류건", sBody, Nothing)
            Catch ex As Exception
                'LOG 생성시 오류발생하면 기존처리에 영향을 안주도록 별도 처리
            End Try
        End Sub

        ''' <summary>
        ''' Create a dataset from a dictionary of [Dictionary|Dataset|Datatable|String,Object...]
        ''' in order to be returned from WCF Services
        ''' </summary>
        ''' <param name="dict"></param>
        ''' <param name="dsTarget"></param>
        ''' <param name="sDtPrefix"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function dict2Ds(ByVal dict As Dictionary(Of String, Object), ByVal dsTarget As DataSet, Optional ByVal sDtPrefix As String = "") As DataSet
            Dim dtKeyValuePairs As DataTable

            'Process top level of data
            If dsTarget Is Nothing Then
                dsTarget = New DataSet
            End If

            If Not dsTarget.Tables.Contains("KEY_VALUE_PAIRS") Then
                'Init the only one Key_value_pairs table
                dtKeyValuePairs = New DataTable("KEY_VALUE_PAIRS")
                'And add the only row for this
                dtKeyValuePairs.Rows.Add(dtKeyValuePairs.NewRow())
                'Also, must be added to the dsTarget
                dsTarget.Tables.Add(dtKeyValuePairs)
            Else
                dtKeyValuePairs = dsTarget.Tables("KEY_VALUE_PAIRS")
            End If

            For Each key As String In dict.Keys
                key = key.Trim
                Dim sNewKey As String = key
                If sDtPrefix <> "" Then 'From the second level toward
                    sNewKey = sDtPrefix & "." & key
                End If

                If TypeOf (dict(key)) Is DataSet Then           'Process child dataset
                    Dim dsChild As DataSet = dict(key)
                    For i As Integer = dsChild.Tables.Count - 1 To 0 Step -1
                        Dim dtChild As DataTable = dsChild.Tables(i)
                        dsChild.Tables.Remove(dtChild)  'Must detach from its current dataset
                        dtChild.TableName = sNewKey & "." & dtChild.TableName
                        dsTarget.Tables.Add(dtChild)    'Attach to new dataset
                    Next
                ElseIf TypeOf (dict(key)) Is DataTable Then     'Process child datatable
                    Dim dtChild As DataTable = dict(key)
                    dtChild.TableName = sNewKey & "." & dtChild.TableName
                    dsTarget.Tables.Add(dtChild)
                ElseIf TypeOf (dict(key)) Is IDictionary Then   'Process child dictionary (recursion algorithm)
                    dict2Ds(dict(key), dsTarget, sNewKey)
                Else        'Other types are all considered as generic (Pendng: need the handling for other non-generic data structure if necessary)
                    dtKeyValuePairs.Columns.Add(sNewKey)
                    dtKeyValuePairs.Rows(0)(sNewKey) = dict(key)
                End If
            Next

            'NOTE: make sure there is always Status of return data
            If Not dtKeyValuePairs.Columns.Contains("Status") Then
                dtKeyValuePairs.Columns.Add("Status")
                dtKeyValuePairs.Rows(0)("Status") = "UNKNOWN"
            End If

            Return dsTarget
        End Function

        ''' <summary>
        ''' Try to extract the exception source to inform client about the source reason of exception
        ''' </summary>
        ''' <param name="ex"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function getDebugTextInfo(ByVal ex As Exception) As String
            Dim sReturn As String = ""

            'Used to extract DB related exception info
            Dim oDbExeption As YJIT.Data.DBException = Nothing

            If ex Is Nothing Then
                sReturn = ""
            End If

            While ex.InnerException IsNot Nothing
                If TypeOf ex Is YJIT.Data.DBException Then
                    oDbExeption = ex
                End If
                ex = ex.InnerException
            End While

            If oDbExeption IsNot Nothing Then
                sReturn = "<<DB Exception>> " & oDbExeption.Message & vbNewLine _
                          & "<<SQL>> " & vbNewLine & oDbExeption.Sql & vbNewLine & "===============================" & vbNewLine
            End If

            sReturn &= ex.Message & vbNewLine & ex.StackTrace

            Return sReturn
        End Function

        'Added by Bilgun, External user Login
        Public Function ExternalLogin(ByVal dsParams As DataSet) As System.Data.DataSet

            Dim dictReturn As New Dictionary(Of String, Object)
            Dim dtClientInfo As DataTable = dsParams.Tables("WCF_CLIENT_INFO")
            Dim LgStatus As LoginStatus = processSessionDomain(dtClientInfo)

            Try
                Dim userID As String = dsParams.Tables("WCF_CLIENT_INFO").Rows(0)("USERID")
                Dim userPwd As String = dsParams.Tables("WCF_CLIENT_INFO").Rows(0)("PASSWORD")
                Select Case YJIT.SessionInfo.AuthenticateExternalUser(userID, userPwd, YJIT.Config.UseEncPass)
                    Case LoginResult.Successful
                        If LgStatus = LoginStatus.NewSetting Then
                            dictReturn("Status") = "WIZARD"
                            dictReturn("StatusMessage") = ""
                        Else
                            dictReturn("Status") = "SUCCESS"
                            dictReturn("StatusMessage") = "User is authenticated!"
                        End If
                    Case LoginResult.UserClosed
                        dictReturn("Status") = "FAIL"
                        dictReturn("StatusMessage") = "User has been closed!"
                    Case LoginResult.UserNotFound
                        dictReturn("Status") = "FAIL"
                        dictReturn("StatusMessage") = "User is not found!"
                    Case LoginResult.WrongPassword
                        dictReturn("Status") = "FAIL"
                        dictReturn("StatusMessage") = "Password is incorrect!"
                    Case LoginResult.UserLock
                        dictReturn("Status") = "FAIL"
                        dictReturn("StatusMessage") = "This user has been locked."
                    Case LoginResult.PasswordChange
                        dictReturn("Status") = "CHANGE"
                        dictReturn("StatusMessage") = "This password has used more than three months."
                    Case LoginResult.UserUnlock
                        dictReturn("Status") = "UNLOCK"
                        dictReturn("StatusMessage") = "This ID was initialised a password by Administrator."
                    Case Else
                        dictReturn("Status") = "FAIL"
                        dictReturn("StatusMessage") = "Login failed! Unknown reason!"
                End Select
            Catch ex As Exception
                dictReturn("Status") = "FAIL"
                dictReturn("StatusMessage") = "Error while authenticate user!" & ex.Message
            End Try

            If Not authenticateExternalWCFClient(dtClientInfo) Then
                dictReturn("Status") = "UNAUTHORIZED"
            End If

            Return dict2Ds(dictReturn, Nothing, "")

        End Function

        '20170403 김성은 중복체크 / 로그인시 중복 체크 
        Enum SingleLoginType
            RowCount = 0
            MacAddrCheck = 1
            RowRemove = 2
            RowAdd = 3
            TableAdd = 4
        End Enum

        '20170403 김성은 중복체크 / 로그인시 중복 체크 
        Private Shared Function GetSingleLogin(ByVal SingleLoginType As SingleLoginType, ByRef dsSingleLogin As DataSet, ByVal dsClientInfo As DataSet) As Boolean
            Try
                If SingleLoginType = SingleLoginType.TableAdd Then
                    If dsSingleLogin Is Nothing Then
                        Dim dt As DataTable = New DataTable
                        dt.TableName = "SINGLE_LOGIN"
                        dt.Columns.Add("DOMAIN", GetType(String))
                        dt.Columns.Add("USR_ID", GetType(String))
                        dt.Columns.Add("IP_ADDR", GetType(String))
                        dt.Columns.Add("MAC_ADDR", GetType(String))
                        dt.Columns.Add("LOGIN_DATE", GetType(String))
                        dsSingleLogin = New DataSet
                        dsSingleLogin.Tables.Add(dt)
                    End If
                Else
                    If Not dsSingleLogin Is Nothing Then
                        If dsSingleLogin.Tables.Contains("SINGLE_LOGIN") Then
                            If Not dsClientInfo.Tables("WCF_CLIENT_INFO").Columns.Contains("MAC_ADDR") Then
                                '컬럼 추가조건 추가된 경우 체크로직 스킵처리
                                Return True
                            End If

                            Dim dt As DataTable = dsSingleLogin.Tables("SINGLE_LOGIN")
                            Dim dr() As DataRow = dt.Select("DOMAIN = '" & dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("DOMAIN") & "' AND USR_ID = '" & dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("USERID") & "' ")
                            Select Case SingleLoginType
                                Case SingleLoginType.RowCount
                                    '기본자료 확인
                                    If dr.Count = 0 Then
                                        Return False
                                    End If
                                Case SingleLoginType.MacAddrCheck
                                    '맥주소 동일한지 확인
                                    If dr.Count > 0 Then
                                        If dr(0)("MAC_ADDR") <> dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("MAC_ADDR") Then
                                            Return False
                                        End If
                                    End If
                                Case SingleLoginType.RowRemove
                                    '기존 로긴정보 삭제
                                    If dr.Count > 0 Then
                                        dt.Rows.Remove(dr(0))
                                    End If
                                Case SingleLoginType.RowAdd
                                    If dr.Count = 0 Then
                                        '신규추가
                                        Dim drNew As DataRow = dt.NewRow()
                                        drNew("DOMAIN") = dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("DOMAIN")
                                        drNew("USR_ID") = dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("USERID")
                                        If String.IsNullOrEmpty(dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("IP_ADDR")) Then
                                            drNew("IP_ADDR") = dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("USERID")
                                        Else
                                            drNew("IP_ADDR") = dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("IP_ADDR")
                                        End If
                                        If String.IsNullOrEmpty(dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("MAC_ADDR")) Then
                                            drNew("MAC_ADDR") = dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("USERID")
                                        Else
                                            drNew("MAC_ADDR") = dsClientInfo.Tables("WCF_CLIENT_INFO").Rows(0)("MAC_ADDR")
                                        End If
                                        drNew("LOGIN_DATE") = Now.ToString("yyyy-MM-dd HH:mm:ss")
                                        dt.Rows.Add(drNew)
                                        'Else '추가한 이유 모르겠음 / 다음날 로그인하는 부분을 왜 체크하는건지? 
                                        '    If preloadDR(0)("LOGIN_DATE").ToString <> Now.ToString("yyyyMMdd").ToString Then
                                        '        preloadDT.Rows.Remove(preloadDR(0))

                                        '        Dim drNew As DataRow = preloadDT.NewRow()
                                        '        'drNew("HQ_OFFICE_CD") = SessionOfficeInfo.HqOfficeCode '값이 적용된 이후 체크해야함
                                        '        'drNew("OFFICE_CD") = SessionInfo.OfficeCode
                                        '        drNew("DOMAIN") = Domain
                                        '        drNew("USR_ID") = userID
                                        '        drNew("IP_ADDR") = IpAddr
                                        '        drNew("MAC_ADDR") = MacAddr
                                        '        drNew("LOGIN_DATE") = Now.ToString("yyyyMMdd")
                                        '        preloadDT.Rows.Add(drNew)
                                        '    End If
                                    End If
                            End Select
                        End If
                    End If
                End If

                Return True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

#End Region

    End Class

End Namespace