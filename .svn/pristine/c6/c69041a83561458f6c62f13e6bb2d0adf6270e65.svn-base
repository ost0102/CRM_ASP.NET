Public Class ClientSessionInfo

    Private Shared _userId As String
    Private Shared _englishName As String
    Private Shared _localName As String
    Private Shared _handPhone As String
    Private Shared _telephone As String
    Private Shared _fax As String
    Private Shared _email As String
    Private Shared _officeCode As String
    Private Shared _organizationCode As String
    Private Shared _organizationName As String
    Private Shared _authorizationType As String
    Private Shared _AccountLevel As String
    Private Shared _SalesLevel As String

    Private Shared _startLoginDateTime As String
    Private Shared _dtUserPgmAuthInfo As DataTable
    Private Shared _dtUserFuncAuthInfo As DataTable
    Private Shared _mainJob As String
    Private Shared _MainBlForm As String

    'for WMS
    Private Shared _defaultWarehouseCode As String
    'for WMS END

    Public Shared Sub SetValues(ByVal drValues As DataRow)
        With drValues
            _userId = .Item("USR_ID") & ""
            _englishName = .Item("ENG_NM") & ""
            _localName = .Item("LOC_NM") & ""
            _handPhone = .Item("HP_NO") & ""
            _telephone = .Item("TEL_NO") & ""
            _fax = .Item("FAX_NO") & ""
            _email = .Item("EMAIL") & ""
            _officeCode = .Item("OFFICE_CD") & ""
            _organizationCode = .Item("DEPT_CD") & ""
            _organizationName = .Item("DEPT_NM") & ""
            _authorizationType = .Item("AUTH_TYPE") & ""
            _AccountLevel = .Item("ACT_LVL") & ""
            _SalesLevel = .Item("SALES_LVL") & ""
            _mainJob = .Item("MAIN_JOB") & ""
            _MainBlForm = .Item("MAIN_BL_FORM") & ""

            _defaultWarehouseCode = .Item("DFT_WH_CD") & ""
        End With
    End Sub

    Public Shared ReadOnly Property AccountLevel() As String
        Get
            Return _AccountLevel
        End Get
    End Property

    Public Shared ReadOnly Property SalesLevel() As String
        Get
            Return _SalesLevel
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's ID
    ''' </summary>
    ''' <value></value>
    Public Shared ReadOnly Property UserID() As String
        Get
            Return _userId
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's english name
    ''' </summary>
    Public Shared ReadOnly Property EnglishName() As String
        Get
            Return _englishName
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's local name
    ''' </summary>
    Public Shared ReadOnly Property LocalName() As String
        Get
            Return _localName
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's handphone
    ''' </summary>
    Public Shared ReadOnly Property HandPhone() As String
        Get
            Return _handPhone
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's Telephone
    ''' </summary>
    Public Shared ReadOnly Property Telephone() As String
        Get
            Return _telephone
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's Fax
    ''' </summary>
    Public Shared ReadOnly Property Fax() As String
        Get
            Return _fax
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's EMAIL
    ''' </summary>
    Public Shared ReadOnly Property Email() As String
        Get
            Return _email
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's office code
    ''' </summary>
    Public Shared ReadOnly Property OfficeCode() As String
        Get
            Return _officeCode
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's organization code
    ''' </summary>
    Public Shared ReadOnly Property OrganizationCode() As String
        Get
            Return _organizationCode
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's organization code
    ''' </summary>
    Public Shared ReadOnly Property OrganizationName() As String
        Get
            Return _organizationName
        End Get
    End Property

    ''' <summary>
    ''' Gets current logon user's authorization type
    ''' </summary>
    Public Shared ReadOnly Property AuthorizationType() As String
        Get
            Return _authorizationType
        End Get
    End Property
    ''' <summary>
    ''' Gets current logon user's start login date time''' 
    ''' </summary>
    ''' <value></value>
    Public Shared Property StartLoginTime() As String
        Get
            Return _startLoginDateTime
        End Get
        Set(ByVal value As String)
            _startLoginDateTime = value
        End Set
    End Property

    ''' <summary>
    ''' Gets current logon user's program authorifty info''' 
    ''' </summary>
    ''' <value></value>
    Public Shared Property UserPgmAuthInfo() As DataTable
        Get
            Return _dtUserPgmAuthInfo
        End Get
        Set(value As DataTable)
            _dtUserPgmAuthInfo = value
        End Set
    End Property

    ''' <summary>
    ''' Gets current logon user's function button authorifty info''' 
    ''' </summary>
    ''' <value></value>
    Public Shared Property UserFuncAuthInfo() As DataTable
        Get
            Return _dtUserFuncAuthInfo
        End Get
        Set(value As DataTable)
            _dtUserFuncAuthInfo = value
        End Set
    End Property

    ''' <summary>
    ''' Gets current logon user's main job
    ''' </summary>
    ''' <value></value>
    Public Shared ReadOnly Property MainJob() As String
        Get
            Return _mainJob
        End Get

    End Property

    ''' <summary>
    ''' Gets current logon user's function default warehouse code''' 
    ''' </summary>
    ''' <value></value>
    Public Shared Property DefaultWarehouseCode() As String
        Get
            Return _defaultWarehouseCode
        End Get
        Set(ByVal value As String)
            _defaultWarehouseCode = value
        End Set
    End Property

    ''' <summary>
    ''' Gets current logon user's main job
    ''' </summary>
    ''' <value></value>
    Public Shared ReadOnly Property MainBlForm() As String
        Get
            Return _MainBlForm
        End Get

    End Property


End Class
