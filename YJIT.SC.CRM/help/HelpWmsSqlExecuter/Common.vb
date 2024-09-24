Imports System.Text
Imports System.IO
Imports YJIT.SC
Imports YJIT.SC.WCF.SRBiz
Imports System.Net.Mail
Imports System.Net

Public Class HelpCommon

    Enum RootType
        System = 0
        OfficeList = 1
        UserList = 2
        Sql = 3
    End Enum

    Public Shared SpliteKey As Char = ChrW(35)
    Public Shared InI As Inifile
    Public Shared DbConn As DbConnet
    Private Shared _DomainInfo As DataTable


    Public Shared Function SetDbInfoSetting(ByVal Domain As String, ByRef DataInfo As Dictionary(Of String, String)) As Boolean
        '  Domain = DomainList.EditValue
        Dim dr() As DataRow = HelpCommon.DomainInfo.Select("DOMAIN  = " & "'" & Domain & "'")
        If dr.Length > 0 Then
            If DataInfo Is Nothing Then
                DataInfo = New Dictionary(Of String, String)
            End If
            DataInfo("USR_ID") = dr(0)("USR_ID").ToString
            DataInfo("USR_PWD") = dr(0)("USR_PWD").ToString
            DataInfo("DB_IP") = dr(0)("DB_IP").ToString
            DataInfo("DB_PORT") = dr(0)("DB_PORT").ToString
            DataInfo("DB_SID") = dr(0)("DB_SID").ToString

            'DataInfo("SavedUserID") = dr(0)("SavedUserID").ToString
            'DataInfo("SavedUserPwd") = dr(0)("SavedUserPwd").ToString

            Return True
        End If
        Return False
    End Function

    Shared Property DomainInfo() As DataTable
        Get
            If _DomainInfo Is Nothing Then
                _DomainInfo = New DataTable
                _DomainInfo.Columns.Add("Domain")
            End If
            Return _DomainInfo.Copy
        End Get
        Set(value As DataTable)
            _DomainInfo = value.Copy
        End Set
    End Property

    '설치 경로 오픈
    Public Shared Sub OpenInstallRoot(ByVal DOMAIN As String)
        If DOMAIN = "" Then Exit Sub
        Dim DIC As Object = GetBaseInfo(DOMAIN)
        If DIC("AssemblyName") = "" Then Exit Sub
        Dim sAppRootPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If Not sAppRootPath.EndsWith("\") Then sAppRootPath &= "\"
        sAppRootPath &= "YJIT.SC Home\" & DIC("AssemblyName") & "\"

        Shell("Explorer " & sAppRootPath, AppWinStyle.NormalFocus)
    End Sub

    'ini파일에서 domain 정보 가져옴
    Public Shared Function GetBaseInfo(ByVal DOMAIN As String) As Dictionary(Of String, String)
        Dim Dic As New Dictionary(Of String, String)
        Dim dr() As DataRow = DomainInfo.Select("Domain = '" & DOMAIN & "'")
        If dr.Length > 0 Then
            Dim SavedUserID As String = dr(0)("SavedUserID").ToString
            Dim SavedUserPwd As String = dr(0)("SavedUserPwd").ToString
            Dim SavedAppPath As String = dr(0)("SavedAppPath").ToString
            Dim AssemblyName As String = dr(0)("AssemblyName").ToString

            Dic("SavedUserID") = SavedUserID
            Dic("SavedUserPwd") = SavedUserPwd
            Dic("SavedAppPath") = SavedAppPath
            Dic("AssemblyName") = AssemblyName
        End If


        Return Dic
    End Function

    '레지값에 셋팅
    Public Shared Sub SetDomain(ByVal AssemblyName As String, Optional Key As String = "", Optional value As String = "")
        Dim sAppRootPath As String = ""
        sAppRootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If Not sAppRootPath.EndsWith("\") Then sAppRootPath &= "\"
        sAppRootPath &= "YJIT.SC Home\" & AssemblyName & "\"
        SaveUserSetting(Key, value, sAppRootPath)
    End Sub

    Public Shared Function LoadSession(ByVal AssemblyName As String, ByVal key As String)
        Dim sAppRootPath As String = ""
        sAppRootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If Not sAppRootPath.EndsWith("\") Then sAppRootPath &= "\"
        'sAppRootPath &= "YJIT.SC Home\" & System.Reflection.Assembly.GetExecutingAssembly.GetName().Name & "\"
        sAppRootPath &= "YJIT.SC Home\" & AssemblyName & "\"
        Return loadUserSetting(key, sAppRootPath)
    End Function

    Public Shared Function loadUserSetting(ByVal sKey As String, ByVal sAppRootPath As String) As String
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\YJIT.SC.Home\" & sAppRootPath, True)
        If regKey IsNot Nothing Then
            Try
                Return regKey.GetValue(sKey, "")
            Catch ex As Exception
                'not handle
            Finally
                regKey.Close()
            End Try
        End If
        Return ""
    End Function

    Public Shared Sub SaveUserSetting(ByVal sKey As String, ByVal sValue As String, ByVal sAppRootPath As String)
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE", True)
        regKey.CreateSubKey("YJIT.SC.Home\" & sAppRootPath)
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\YJIT.SC.Home\" & sAppRootPath, True)
        Try
            regKey.SetValue(sKey, sValue)
        Catch ex As Exception
            'Unable to save user preference
        Finally
            regKey.Close()
        End Try
    End Sub

    Public Shared Function GetFilePath(ByVal Type As RootType, ByVal Domain As String) As String
        Dim RootPath As String = Application.StartupPath
        Dim FileName As String = ""
        Select Case Type
            Case HelpCommon.RootType.System
                FileName = "DomainList.Xml"
            Case RootType.Sql
                FileName = "SystemSql.sql"
            Case Else
                FileName = Type.ToString & ".Xml"
        End Select

        Select Case Type
            Case HelpCommon.RootType.System, RootType.Sql
                RootPath = RootPath & "\EmailSend\"
            Case Else
                RootPath = RootPath & "\EmailSend\" & Domain & "\"
        End Select

        If Not FileIO.FileSystem.DirectoryExists(RootPath) Then
            FileIO.FileSystem.CreateDirectory(RootPath)
        End If
        Return RootPath & FileName
    End Function

    Public Shared Function ReadXml(ByVal Domain As String, ByVal XmlType As RootType) As DataTable


        Dim RootPath As String = GetFilePath(XmlType, Domain)
        Dim FileName As String = RootPath.Remove(0, RootPath.LastIndexOf("\") + 1)
        Dim DS1 As New DataSet

        If Not FileIO.FileSystem.FileExists(RootPath) Then
            Return New DataTable
        End If

        DS1.ReadXml(RootPath)
        If DS1.Tables(FileName) Is Nothing Then
            Return New DataTable
        End If
        Return DS1.Tables(FileName)

    End Function

    Public Shared Sub WriteXml(ByVal Domain As String, ByVal XmlType As RootType, ByVal dt As DataTable)

        Dim RootPath As String = GetFilePath(XmlType, Domain)
        Dim FileName As String = RootPath.Remove(0, RootPath.LastIndexOf("\") + 1)

        If FileIO.FileSystem.FileExists(RootPath) Then
            FileIO.FileSystem.DeleteFile(RootPath)
        End If

        Dim wFile As System.IO.FileStream
        Dim byteData() As Byte

        Dim ds As New DataSet
        Dim DT1 As DataTable = dt.Copy
        DT1.TableName = FileName
        ds.Tables.Add(DT1.Copy)

        byteData = Encoding.UTF8.GetBytes(ds.GetXml)
        wFile = New FileStream(RootPath, FileMode.Append)
        wFile.Write(byteData, 0, byteData.Length)
        wFile.Close()

    End Sub

    Public Shared Sub SetDomainListColmuns(ByRef dt As DataTable)

        Dim colNames() As String = {"Chk", "DOMAIN", "SavedUserID", "SavedAppPath", "SavedUserPwd", "AssemblyName", "CheckLogin"}

        If dt Is Nothing Then Exit Sub
        For Each KEY In colNames

            Dim Exist As Boolean = False
            For i = 0 To dt.Columns.Count - 1
                If KEY.ToUpper = dt.Columns(i).ColumnName.ToUpper Then
                    Exist = True
                    Exit For
                End If
            Next
            If Exist = False Then
                If KEY = "Chk" Then
                    If dt.Columns.Contains("Chk") = False Then
                        dt.Columns.Add(KEY, GetType(Boolean))
                    End If
                Else
                    If dt.Columns.Contains(KEY) = False Then
                        dt.Columns.Add(KEY)
                    End If
                End If

            End If

        Next

    End Sub

    Public Shared Sub DrawRowIndicator(ByVal GirdView As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal OutputBand As Boolean = False)
        GirdView.OptionsView.ColumnAutoWidth = False
        GirdView.IndicatorWidth = 40
        AddHandler GirdView.CustomDrawRowIndicator, AddressOf GV_CustomDrawRowIndicator
    End Sub

    Public Shared Sub DrawRowIndicator(ByVal GirdView() As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal OutputBand As Boolean = False)
        For Each gv In GirdView
            gv.OptionsView.ColumnAutoWidth = False
            gv.IndicatorWidth = 40
            AddHandler gv.CustomDrawRowIndicator, AddressOf GV_CustomDrawRowIndicator
        Next
    End Sub

    Public Shared Sub GV_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)

        Dim rowIndex As Integer = e.RowHandle
        If e.Info.IsRowIndicator Then
            If rowIndex >= 0 Then
                rowIndex += 1
                e.Info.DisplayText = rowIndex.ToString()
            End If
        Else
            If sender.OptionsView.ShowColumnHeaders = True Then
                If e.Info.Kind = DevExpress.Utils.Drawing.IndicatorKind.Header Then
                    e.Info.DisplayText = "No"
                End If
            Else
                If e.Info.Kind = DevExpress.Utils.Drawing.IndicatorKind.Band Then
                    e.Info.DisplayText = "No"
                End If
            End If
        End If
        e.Info.ImageIndex = -1
    End Sub

    Public Shared Function GetSql(ByVal SqlID As String) As String

        Dim RootPath As String = GetFilePath(RootType.Sql, "")
        Dim _SqlID As String = (SqlID).ToUpper
        Dim str As String = ""
        Try
            Dim SqlText As String = FileIO.FileSystem.ReadAllText(RootPath)
            Dim sql() As String = SqlText.Split(SpliteKey)

            For Each s In sql

                Dim LfKey() As String = s.Split(vbLf)

                If LfKey.Length > 0 Then
                    If LfKey(0).ToUpper = _SqlID Then
                        Return s.Remove(0, _SqlID.Length)
                    End If
                End If

                Dim VbLfKey() As String = s.Split(vbLf)
                If VbLfKey.Length > 0 Then
                    If VbLfKey(0).ToUpper = _SqlID Then
                        Return s.Remove(0, _SqlID.Length)
                    End If
                End If

                Dim VbCrKey() As String = s.Split(vbCr)
                If VbCrKey.Length > 0 Then
                    If VbCrKey(0).ToUpper = _SqlID Then
                        Return s.Remove(0, _SqlID.Length)
                    End If
                End If

                Dim VbCrlFKey() As String = s.Split(vbCrLf)
                If VbCrlFKey.Length > 0 Then
                    If VbCrlFKey(0).ToUpper = _SqlID Then
                        Return s.Remove(0, _SqlID.Length)
                    End If
                End If

            Next
        Catch ex As Exception

        End Try
        Return str
    End Function

    Public Shared Function SetSql(ByVal Domain As String _
                                      , ByVal SqlID As String _
                                      , Optional ByVal ParamDic As Dictionary(Of String, String) = Nothing _
                                      , Optional ByVal BlockDic As Dictionary(Of String, String) = Nothing _
                                      , Optional ByVal SqlText As String = "") As DataTable

        Try
            Dim DataDic As New Dictionary(Of String, String)

            If SetDbInfoSetting(Domain, DataDic) Then

                For Each KEY In DataDic.Keys
                    Select Case KEY
                        Case "DB_IP", "DB_PORT", "DB_SID", "USR_ID", "USR_PWD"
                            If DataDic(KEY) Is Nothing Then
                                Return New DataTable
                            End If
                            If DataDic(KEY) = "" Then
                                Return New DataTable
                            End If
                    End Select
                Next
                HelpCommon.DbConn = New DbConnet(DataDic("DB_IP"), DataDic("DB_PORT"), DataDic("DB_SID"), DataDic("USR_ID"), DataDic("USR_PWD"))
                If HelpCommon.DbConn.DbConnect = False Then

                    Return New DataTable
                End If

                If Not ParamDic Is Nothing Then
                    For Each key In ParamDic.Keys
                        HelpCommon.DbConn.SqlParam(key) = ParamDic(key)
                    Next
                End If

                If Not BlockDic Is Nothing Then
                    For Each key In BlockDic.Keys

                    Next
                End If

                Dim dt As DataTable = HelpCommon.DbConn.SetSql(SqlID, SqlText)
                Return dt

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return New DataTable
    End Function

    Public Shared Function DomainExist(ByVal Domain As String)

        If DomainInfo.Select("Domain = '" & Domain & "'").Length > 0 Then
            Return True
        End If
        Return False
    End Function
     
    

     

End Class
