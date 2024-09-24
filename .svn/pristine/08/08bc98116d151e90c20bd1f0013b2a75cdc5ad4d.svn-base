Namespace YJIT

    ''' <summary>
    ''' Application configuration
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Config
        Private Shared _config As System.Configuration.Configuration


        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            _config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/")

        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared Sub Update()
            _config.Save()

        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared ReadOnly Property DBConnStr() As String
            Get
                Dim _dbConnSetting As System.Configuration.ConnectionStringSettings
                Dim _activeDbConn As String
                If _config.AppSettings.Settings("ActiveConn") IsNot Nothing Then
                    _activeDbConn = _config.AppSettings.Settings("ActiveConn").Value
                    _dbConnSetting = _config.ConnectionStrings.ConnectionStrings(_activeDbConn)
                    If _dbConnSetting Is Nothing Then
                        Return ""
                    Else
                        Return _dbConnSetting.ConnectionString
                    End If

                Else
                    Return ""

                End If
            End Get
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property DBType() As String
            Get
                If _config.AppSettings.Settings("DBType") Is Nothing Then
                    Return ""
                End If
                If _config.AppSettings.Settings("DBType").Value IsNot Nothing Then
                    Return _config.AppSettings.Settings("DBType").Value
                Else
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                _config.AppSettings.Settings("DBType").Value = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property SAPConnStr() As String
            Get
                If _config.AppSettings.Settings("SAPConnStr") Is Nothing Then
                    Return ""
                End If
                If _config.AppSettings.Settings("SAPConnStr").Value IsNot Nothing Then
                    Return _config.AppSettings.Settings("SAPConnStr").Value
                Else
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                _config.AppSettings.Settings("SAPConnStr").Value = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property UseEncPass() As Boolean
            Get
                If _config.AppSettings.Settings("UseEncPass") Is Nothing Then
                    Return False
                End If
                If _config.AppSettings.Settings("UseEncPass").Value IsNot Nothing Then
                    If _config.AppSettings.Settings("UseEncPass").Value = "TRUE" Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            End Get
            Set(ByVal value As Boolean)
                _config.AppSettings.Settings("UseEncPass").Value = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property UseSAP() As Boolean
            Get
                If _config.AppSettings.Settings("UseSAP") Is Nothing Then
                    Return False
                End If
                If _config.AppSettings.Settings("UseSAP").Value IsNot Nothing Then
                    If _config.AppSettings.Settings("UseSAP").Value = "TRUE" Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            End Get
            Set(ByVal value As Boolean)
                _config.AppSettings.Settings("UseSAP").Value = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property SysType() As String
            Get
                If _config.AppSettings.Settings("SysType") Is Nothing Then
                    Return ""
                End If
                If _config.AppSettings.Settings("SysType").Value IsNot Nothing Then
                    Return _config.AppSettings.Settings("SysType").Value
                Else
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                _config.AppSettings.Settings("SysType").Value = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property EnableClientSession() As Boolean
            Get
                If _config.AppSettings.Settings("EnableClientSession") Is Nothing Then
                    Return False
                End If
                If _config.AppSettings.Settings("EnableClientSession").Value IsNot Nothing Then
                    If _config.AppSettings.Settings("EnableClientSession").Value = "TRUE" Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            End Get
            Set(ByVal value As Boolean)
                _config.AppSettings.Settings("EnableClientSession").Value = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property RptConnStr() As String
            Get
                If _config.AppSettings.Settings("RptConnStr") Is Nothing Then
                    Return ""
                End If
                If _config.AppSettings.Settings("RptConnStr").Value IsNot Nothing Then
                    Return _config.AppSettings.Settings("RptConnStr").Value
                Else
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                _config.AppSettings.Settings("RptConnStr").Value = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property RptRootPath() As String
            Get
                If _config.AppSettings.Settings("RptRootPath") Is Nothing Then
                    Return ""
                End If
                If _config.AppSettings.Settings("RptRootPath").Value IsNot Nothing Then
                    Return _config.AppSettings.Settings("RptRootPath").Value
                Else
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                _config.AppSettings.Settings("RptRootPath").Value = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property RptRender() As String
            Get
                If _config.AppSettings.Settings("RptRender") Is Nothing Then
                    Return ""
                End If
                If _config.AppSettings.Settings("RptRender").Value IsNot Nothing Then
                    Return _config.AppSettings.Settings("RptRender").Value
                Else
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                _config.AppSettings.Settings("RptRender").Value = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Property AuthType() As String
            Get
                If _config.AppSettings.Settings("AuthType") Is Nothing Then
                    Return ""
                End If
                If _config.AppSettings.Settings("AuthType").Value IsNot Nothing Then
                    Return _config.AppSettings.Settings("AuthType").Value
                Else
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                _config.AppSettings.Settings("AuthType").Value = value
            End Set
        End Property

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="key"></param>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Default Public Property Item(ByVal key As String) As String
            Get
                If _config.AppSettings.Settings(key) Is Nothing Then
                    Return ""
                End If
                If _config.AppSettings.Settings(key).Value IsNot Nothing Then
                    Return _config.AppSettings.Settings(key).Value
                Else
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                _config.AppSettings.Settings(key).Value = value
            End Set
        End Property
    End Class

End Namespace
