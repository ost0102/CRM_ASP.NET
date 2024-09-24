Imports Microsoft.VisualBasic


Namespace YJIT

    Public Class SessionCompanyInfo

        ''' <summary>
        ''' Gets or sets company code
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property Code() As String
            Get
                Return HttpContext.Current.Session("TM_CUST_MST.CUST_ID")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("TM_CUST_MST.CUST_ID") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets company name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property Name() As String
            Get
                Return HttpContext.Current.Session("TM_CUST_MST.CUST_NM")
            End Get
            Set(ByVal value As String)
                HttpContext.Current.Session("TM_CUST_MST.CUST_NM") = value
            End Set
        End Property

        '.....additional properties
    End Class

End Namespace
