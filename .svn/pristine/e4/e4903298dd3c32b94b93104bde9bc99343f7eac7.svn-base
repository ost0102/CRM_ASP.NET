Imports Microsoft.VisualBasic


Namespace YJIT

    Public Class SessionOfficeInfo
        ''' <summary>
        ''' Gets or sets Domain 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Shared Property Domain() As String
            Get
                Return HttpContext.Current.Session("Domain")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("Domain") = value
            End Set
        End Property
        ''' <summary>
        ''' Gets or sets Language Code
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Shared Property CustomsSetting As String
            Get
                Dim value As String = HttpContext.Current.Session("CustomsSetting").ToString
                If value = "" Then
                    value = "Y"
                End If
                Return value
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("CustomsSetting") = value
            End Set
        End Property


        ''' <summary>
        ''' Gets or sets Language Code
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property LanguageCode() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.LANG_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.LANG_CD") = value
            End Set
        End Property


        ''' <summary>
        ''' Gets or sets office name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property Name() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.NOR_NAME")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.NOR_NAME") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets local name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property LocalName() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.LOCAL_NM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.LOCAL_NM") = value
            End Set
        End Property

        Public Shared Property Address() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.CADDR")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.NOR_ADDR") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets address
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property LocalAddress() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.LOC_ADDR")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.LOC_ADDR") = value
            End Set
        End Property

        Public Shared Property EnglishAddress() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.ENG_ADDR")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.ENG_ADDR") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets city
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property City() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.CITY_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.CITY_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or set current logon user's country code
        ''' </summary>
        Public Shared Property CountryCode() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.CTRY_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.CTRY_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets currency
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property OfficeName() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.OFFICE_NM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.OFFICE_NM") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets currency
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property CurrencyCode() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.CURR_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.CURR_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets local bank information
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property ForeignBankInfo() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.FCUR_BANK_INFO")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.FCUR_BANK_INFO") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets local currency decimal point
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property DecimalPoint() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.DECIMAL_POINT")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.DECIMAL_POINT") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets local currency decimal point
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property DecimalNumberFormat() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.DECIMAL_NUMBER_FORMAT")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.DECIMAL_NUMBER_FORMAT") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets local Air Port
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property AirPortCode() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.AIR_PORT_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.AIR_PORT_CD") = value
            End Set
        End Property

        Public Shared Property AirPortName() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.AIR_PORT_NM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.AIR_PORT_NM") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets local Sea Port
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property SeaPortCode() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.SEA_PORT_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.SEA_PORT_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets local Sea Port
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property SeaPortName() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.SEA_PORT_NM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.SEA_PORT_NM") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Air B/L Prefix
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property AirBlPrefix() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.AIR_BL_PREFIX")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.AIR_BL_PREFIX") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Sea B/L Prefix
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property SeaBlPrefix() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.SEA_BL_PREFIX")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.SEA_BL_PREFIX") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Office Customs code
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property CustomsCode() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.CUSTOMS_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.CUSTOMS_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets office accoutn prefix
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property OfficePrefix() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.OFFICE_PREFIX")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.OFFICE_PREFIX") = value
            End Set
        End Property
        ''' <summary>
        ''' Gets or sets HQ office code
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property HqOfficeCode() As String
            Get
                Return HttpContext.Current.Session("MdmOfficeMst.HQ_OFFICE_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmOfficeMst.HQ_OFFICE_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Air Freight code
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property AirFrtCode() As String
            Get
                Return HttpContext.Current.Session("MdmFrtMst.AIR_FRT_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmFrtMst.AIR_FRT_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Sea Freight code
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property SeaFrtCode() As String
            Get
                Return HttpContext.Current.Session("MdmFrtMst.SEA_FRT_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MdmFrtMst.SEA_FRT_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Office B/L Address
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property BlAddress() As String
            Get
                Return HttpContext.Current.Session("MDM_CUST_MST.BL_ADDR")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_CUST_MST.BL_ADDR") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Office VAT percent
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property VatPer() As String
            Get
                Return HttpContext.Current.Session("MDM_OFFICE_MST.VAT_PER")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_OFFICE_MST.VAT_PER") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Office Create Slip by Selling Tax
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property AutoSlipByTax() As String
            Get
                Return HttpContext.Current.Session("MDM_OFFICE_CONFIG.AUTO_SLIP")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_OFFICE_CONFIG.AUTO_SLIP") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Office Create Invoice by Freight
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property AutoInvoice() As String
            Get
                Return HttpContext.Current.Session("MDM_OFFICE_CONFIG.AUTO_INV")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_OFFICE_CONFIG.AUTO_INV") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Office 증치세 운임코드
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property VatFreightCode() As String
            Get
                Return HttpContext.Current.Session("MDM_FRT_MST.PROXY_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_FRT_MST.PROXY_CD") = value
            End Set
        End Property

        Public Shared Property VatFreightName() As String
            Get
                Return HttpContext.Current.Session("MDM_FRT_MST.PROXY_NM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_FRT_MST.PROXY_NM") = value
            End Set

        End Property
        Public Shared Property PfmByOperator() As String
            Get
                Return HttpContext.Current.Session("MDM_OFFICE_CONFIG.PFM_BY_OP")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_OFFICE_CONFIG.PFM_BY_OP") = value
            End Set

        End Property

        Public Shared Property DateFormat() As String
            Get
                Return HttpContext.Current.Session("MDM_OFFICE_MST.DATE_FORMAT")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_OFFICE_MST.DATE_FORMAT") = value
            End Set
        End Property
        ''' <summary>
        ''' Gets or sets Office 설립연도
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Property EstablishYear() As String
            Get
                Return HttpContext.Current.Session("MDM_OFFICE_MST.FOUND_YEAR")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_OFFICE_MST.FOUND_YEAR") = value
            End Set
        End Property
        ''' <summary>
        ''' Gets or sets Office 외화환율 체크 여부
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Property FcurExrateRequired() As String
            Get
                Return HttpContext.Current.Session("MDM_OFFICE_CONFIG.ITEM_CD")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_OFFICE_CONFIG.ITEM_CD") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets Tracking관리 사용 여부
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property UsingTracking() As String
            Get
                Return HttpContext.Current.Session("MDM_OFFICE_CONFIG.TRACKING_YN")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_OFFICE_CONFIG.TRACKING_YN") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets eTruck Bank Interface 사용 여부
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property eTruckBankInterface() As String
            Get
                Return HttpContext.Current.Session("MDM_OFFICE_CONFIG.ETRUCK_BANK_YN")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_OFFICE_CONFIG.ETRUCK_BANK_YN") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets 회사로고 형태
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property LogoType() As String
            Get
                Return HttpContext.Current.Session("MDM_OFFICE_CONFIG.LOGO_TYPE")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("MDM_OFFICE_CONFIG.LOGO_TYPE") = value
            End Set
        End Property

    End Class

End Namespace
