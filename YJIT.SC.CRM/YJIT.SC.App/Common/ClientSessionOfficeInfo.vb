Public Class ClientSessionOfficeInfo

    Private Shared _name As String
    Private Shared _localName As String
    Private Shared _address As String
    Private Shared _countryCode As String
    Private Shared _officeName As String
    Private Shared _currencyCode As String
    Private Shared _decimalPoint As String
    Private Shared _airPortCode As String
    Private Shared _airPortName As String
    Private Shared _seaPortCode As String
    Private Shared _seaPortName As String
    Private Shared _airBlPrefix As String
    Private Shared _officePrefix As String
    Private Shared _hqOfficeCode As String
    Private Shared _upperOffice As String
    Private Shared _languageCode As String
    Private Shared _AirFrtCode As String
    Private Shared _SeaFrtCode As String
    Private Shared _BlAddress As String
    Private Shared _CustomsCode As String
    Private Shared _VatPer As String
    Private Shared _City As String
    Private Shared _AutoSlipByTax As String
    Private Shared _AutoInvoice As String
    Private Shared _VatFreightCode As String
    Private Shared _VatFreightName As String
    Private Shared _PfmByOperator As String
    Private Shared _DateFormat As String
    Private Shared _EstablishYear As String
    Private Shared _FcurExrateRequired As String
    Private Shared _UsingTracking As String
    Private Shared _eTruckBankInterface As String
    Private Shared _LogoType As String

    Public Shared Sub SetValues(ByVal drValues As DataRow)
        With drValues
            _officeName = .Item("OFFICE_NM") & ""
            _localName = .Item("LOC_NM") & ""
            _currencyCode = .Item("CURR_CD") & ""
            _countryCode = .Item("CTRY_CD") & ""
            _decimalPoint = .Item("DCM_POINT") & ""
            _airPortCode = .Item("AIR_PORT_CD") & ""
            _airPortName = .Item("AIR_PORT_NM") & ""
            _seaPortCode = .Item("SEA_PORT_CD") & ""
            _seaPortName = .Item("SEA_PORT_NM") & ""
            _airBlPrefix = .Item("AIR_BL_PREFIX") & ""
            _officePrefix = .Item("OFFICE_PREFIX") & ""
            _hqOfficeCode = .Item("HQ_OFFICE_CD") & ""
            _address = .Item("LOC_ADDR") & ""
            _upperOffice = .Item("UPPER_ORG_CD") & ""
            _languageCode = .Item("LANG_CD") & ""
            _AirFrtCode = .Item("AIR_FRT_CD") & ""
            _SeaFrtCode = .Item("SEA_FRT_CD") & ""
            _BlAddress = .Item("BL_ADDR") & ""
            _CustomsCode = .Item("CUSTOMS_CD") & ""
            _VatPer = .Item("VAT_PER") & ""
            _City = .Item("CITY_CD") & ""
            _AutoSlipByTax = .Item("AUTO_SLIP_BY_TAX") & ""
            _AutoInvoice = .Item("AUTO_INVOICE") & ""
            _VatFreightCode = .Item("VAT_FRT_CD") & ""
            _VatFreightName = .Item("VAT_FRT_NM") & ""
            _PfmByOperator = .Item("PFM_BY_OP") & ""
            _DateFormat = .Item("DATE_FORMAT") & ""
            _EstablishYear = .Item("FOUND_YEAR") & ""
            _FcurExrateRequired = .Item("FCUR_EXRT_YN") & ""
            _UsingTracking = .Item("TRACKING_YN") & ""
            _eTruckBankInterface = .Item("ETRUCK_BANK_YN") & ""
            _LogoType = .Item("LOGO_TYPE") & ""

        End With
    End Sub

    Public Shared ReadOnly Property UpperOffice() As String
        Get
            Return _UpperOffice
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets office name
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Shared ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets local name
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property LocalName() As String
        Get
            Return _localName
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets address
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property Address() As String
        Get
            Return _address
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets city
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property City() As String
        Get
            Return _city
        End Get
    End Property

    ''' <summary>
    ''' Gets or set current logon user's country code
    ''' </summary>
    Public Shared ReadOnly Property CountryCode() As String
        Get
            Return _countryCode
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets currency
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property OfficeName() As String
        Get
            Return _officeName
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets currency
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property CurrencyCode() As String
        Get
            Return _currencyCode
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets local currency decimal point
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property DecimalPoint() As String
        Get
            Return _decimalPoint
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets local Air Port
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property AirPortCode() As String
        Get
            Return _airPortCode
        End Get
    End Property
    Public Shared ReadOnly Property AirPortName() As String
        Get
            Return _airPortName
        End Get
    End Property


    ''' <summary>
    ''' Gets or sets local Sea Port
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property SeaPortCode() As String
        Get
            Return _seaPortCode
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets local Sea Port
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property SeaPortName() As String
        Get
            Return _seaPortName
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets Air B/L Prefix
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property AirBlPrefix() As String
        Get
            Return _airBlPrefix
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets office prefix
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property OfficePrefix() As String
        Get
            Return _officePrefix
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets HQ office code
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property HqOfficeCode() As String
        Get
            Return _hqOfficeCode
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets Language Code
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property LanguageCode() As String
        Get
            Return _LanguageCode
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets Air freight Code
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property AirFrtCode() As String
        Get
            Return _AirFrtCode
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets Ocean freight Code
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property SeaFrtCode() As String
        Get
            Return _SeaFrtCode
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets Office B/L Address
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property BlAddress() As String
        Get
            Return _BlAddress
        End Get
    End Property

    ''' <summary>
    ''' Gets  Office CustomsCode
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property CustomsCode() As String
        Get
            Return _CustomsCode
        End Get
    End Property

    ''' <summary>
    ''' Gets  Office VAT Percent
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property VatPer() As String
        Get
            Return _VatPer
        End Get
    End Property

    ''' <summary>
    ''' Gets  Office Create Slip by Selling Tax
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property AutoSlipByTax() As String
        Get
            Return _AutoSlipByTax
        End Get
    End Property

    ''' <summary>
    ''' Gets  Office Create Invoice by Freight
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property AutoInvoice() As String
        Get
            Return _AutoInvoice
        End Get
    End Property

    ''' <summary>
    ''' 증치세 운임코드/명
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property VatFreightCode() As String
        Get
            Return _VatFreightCode
        End Get
    End Property
    Public Shared ReadOnly Property VatFreightName() As String
        Get
            Return _VatFreightName
        End Get
    End Property
    ''' <summary>
    ''' 실적조회시 Operator 필수
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property PfmByOperator() As String
        Get
            Return _PfmByOperator
        End Get
    End Property

    ''' <summary>
    ''' Office별 Date Format
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property DateFormat() As String
        Get
            Return _DateFormat
        End Get
    End Property

    ''' <summary>
    ''' Office 설립년도
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property EstablishYear() As String
        Get
            Return _EstablishYear
        End Get
    End Property
    ''' <summary>
    ''' 비엘운임입력시 외화환율 필수 여부
    ''' </summary>
    Public Shared ReadOnly Property FcurExrateRequired() As String
        Get
            Return _FcurExrateRequired
        End Get
    End Property

    ''' <summary>
    ''' Tracking 사용 여부
    ''' </summary>
    Public Shared ReadOnly Property UsingTracking() As String
        Get
            Return _UsingTracking
        End Get
    End Property

    ''' <summary>
    ''' KL-NET eTrucking Bank 사용 여부
    ''' </summary>
    Public Shared ReadOnly Property eTruckBankInterface() As String
        Get
            Return _eTruckBankInterface
        End Get
    End Property

    ''' <summary>
    ''' 회사 로고 형태
    ''' </summary>
    Public Shared ReadOnly Property LogoType() As String
        Get
            Return _LogoType
        End Get
    End Property
End Class
