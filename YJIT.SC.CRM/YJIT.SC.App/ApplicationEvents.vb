Imports Microsoft.Win32
Imports System.Threading
Imports System.Deployment.Application
Imports System.Reflection

Namespace My
    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

            '-------------------------------------------------------------------------------------
            'Setup Application's Fixed CurrentCulture (which determine number format, currency....)
            'It will allow to application use fixed culture settings regardless of computer's locale settings (in Control Panel-> Regional & Language)
            '-------------------------------------------------------------------------------------
            Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US") 'Fixed settings following American standard


            '-------------------------------------------------------------------------------------
            'Setup Application's Default CurrentUICulture (NOTE: this will be changed later when user change language menu)
            '-------------------------------------------------------------------------------------
            Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en-US")

            '-------------------------------------------------------------------------------------
            'Select data communication format
            '-------------------------------------------------------------------------------------
            WCF.WCFBiz.DataCommunicationFormat = "SOAP"

            '-------------------------------------------------------------------------------------
            'Application idle request timeout (default is 360 minutes)
            '-------------------------------------------------------------------------------------
            WCF.WCFBiz.AppSessionRequestTimeout = 360   'application idle timeout (in minutes)

            '-------------------------------------------------------------------------------------
            'Automatically select the EndPointClient and ReportPath based on the running environment
            '-------------------------------------------------------------------------------------
            Dim args() As String = Environment.GetCommandLineArgs
            Common.IsDeploymentMode = False
            If args.Contains("-Deployed") Then
                Common.IsDeploymentMode = True
                Dim sLocalManifest As String = "LocalManifest.inf"
                If IO.File.Exists(Windows.Forms.Application.StartupPath & "\" & sLocalManifest) Then
                    'The first line of local manifest file contains deployment URL
                    Dim sr As New System.IO.StreamReader(Windows.Forms.Application.StartupPath & "\" & sLocalManifest)
                    Common.AppDeployUrl = Trim(sr.ReadLine())
                    sr.Close()
                End If
                WCF.WCFBiz.EndPointName = "RemoteDeploymentServer"
                Common.ReportPath = Windows.Forms.Application.StartupPath & "\RPT\"
                YJIT.SC.UI.SCView.DisplayModuleId = False

                'Load LocalManifest.inf
                Call RuntimeUpdate.loadLocalManifest()
            Else
                WCF.WCFBiz.EndPointName = "LocalDevelopmentServer"
                Common.ReportPath = Windows.Forms.Application.StartupPath & "\RPT\"         'Disabled
                YJIT.SC.UI.SCView.DisplayModuleId = True
            End If

            '-------------------------------------------------------------------------------------
            'Choose login form based on deploy server URL or Port
            '-------------------------------------------------------------------------------------
            Dim tmpWcfInfo As New WCF.SRBiz.BizServiceClient(WCF.WCFBiz.EndPointName)
            '=====================================================
            ' 접속 Server IP 로 해당 login form 분계
            Dim ServerIP As String = tmpWcfInfo.Endpoint.Address.Uri.ToString
            ServerIP = ServerIP.Substring(0, ServerIP.IndexOf("/WCF"))
            Common.ServerIP = ServerIP

            'Have to check whether application is directed from webApp or any other App before login form
            Dim isWebLogin As Boolean = False
            For Each arg As String In args
                If arg.StartsWith("-WebLogin") Then
                    isWebLogin = True
                    Exit For
                End If
            Next

            'My.Application.MainForm = Common.GetWebLoginForm
            If isWebLogin Then
                My.Application.MainForm = Common.GetWebLoginForm
            Else
                My.Application.MainForm = Common.GetLoginForm
            End If
            '=====================================================
            '-------------------------------------------------------------------------------------
            'Enable Whole form skining (if not, title bar will not be skined)
            '-------------------------------------------------------------------------------------
            DevExpress.Skins.SkinManager.EnableFormSkins()
            DevExpress.Skins.SkinManager.EnableMdiFormSkins()
            DevExpress.Skins.SkinManager.EnableFormSkinsIfNotVista()


            '-------------------------------------------------------------------------------------
            'Load module/plugin, then create manifest
            '-------------------------------------------------------------------------------------

            Dim sModulePath As String = System.Windows.Forms.Application.StartupPath & "\Modules\"
            If Not IO.Directory.Exists(sModulePath) Then
                IO.Directory.CreateDirectory(sModulePath)
            End If
            Dim sAssFiles() As String = System.IO.Directory.GetFiles(sModulePath, "*.dll", IO.SearchOption.AllDirectories)
            Dim ass As Assembly

            For Each sAssFile As String In sAssFiles
                If sAssFile.EndsWith("CrmUserNoice.dll") = True Then Continue For

                Try
                    ass = Assembly.Load(System.IO.File.ReadAllBytes(sAssFile))      'This method will not lock assembly file
                    'ass = Assembly.LoadFile(sAssFile)
                Catch ex As Exception
                    MsgBox("Failed to load assembly:" & sAssFile & vbNewLine & ex.Message & vbNewLine & ex.StackTrace)
                    Continue For
                End Try

                For Each tp As Type In ass.GetExportedTypes
                    ModuleManifest(APP_ROOT_NAMESPACE & "." & tp.Name.ToUpper) = sAssFile      'Store assembly file path
                    ModuleLoadedManifest(APP_ROOT_NAMESPACE & "." & tp.Name.ToUpper) = ass     'Store assembly loaded reference
                Next
            Next

            '-------------------------------------------------------------------------------------
            'Setup basic system-level options
            '-------------------------------------------------------------------------------------
            'Auto display form title on the autobutton panel
            YJIT.SC.UI.SCView.DisplayTitleOnButtonPanel = True
            'The language dictionary is case-insensitive of work keys
            Resources.ResourceManager.IgnoreCase = False
            'Set the Application TextCasing 
            YJIT.SC.UI.SCView.AppTextCasing = UI.TextCasings.Upper
            'Set the Application Root namespace
            YJIT.SC.UI.SCView.AppRootNamespace = Common.APP_ROOT_NAMESPACE
            'Set the Application Datebox standard format 
            YJIT.SC.UI.SCControls.DateBox.AppDateFormat = "YYYY-MM-DD"

            YJIT.SC.UI.SCControls.TextBox.AppValidateTextCasing = True

            'Read the user's preferences
            Call loadCurrentUserAppSettings()
        End Sub

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            '20230721 김성은 소스이관
            '-------------------------------------------------------------------------------------
            'Runtime Update (Harry) => Save status to local manifest
            '-------------------------------------------------------------------------------------
            'If Common.IsDeploymentMode = True AndAlso Common.UseRuntimeUpdate = "Y" AndAlso RU_LocalManifest.Count > 0 Then
            If Common.IsDeploymentMode = True AndAlso RU_LocalManifest.Count > 0 Then
                Try
                    'Write the LocalManifest into file (only in runtime update mode)
                    Dim sw As IO.StreamWriter
                    Dim sManifestPath As String = System.Windows.Forms.Application.StartupPath & "\" & RU_LocalManifestFile

                    If Not IO.File.Exists(sManifestPath) Then
                        sw = IO.File.CreateText(sManifestPath)
                    Else
                        sw = New System.IO.StreamWriter(sManifestPath, False)
                    End If

                    Dim sbLocalManifestContent As New System.Text.StringBuilder
                    sbLocalManifestContent.AppendLine(Common.AppDeployUrl)
                    For i As Integer = 0 To RU_LocalManifest.Count - 1
                        sbLocalManifestContent.AppendLine(RU_LocalManifest(i))
                    Next
                    sw.Write(sbLocalManifestContent.ToString)

                    sw.Close()
                    sw.Dispose()
                Catch ex As Exception
                    MsgBoxSC("Failed to save the Runtime Update manifest!" & ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            saveCurrentUserAppSettings()
            'Close the child processes if have
            If Common.ProcBugReporter IsNot Nothing AndAlso Not Common.ProcBugReporter.HasExited Then
                Common.ProcBugReporter.Kill()
            End If
        End Sub


#Region "===============Helper methods=============="
        'Save current user preferences
        Private Sub saveCurrentUserAppSettings()
            'Save selected skin
            Common.SaveUserSetting("UserSkinID", Common.UserSkinID)
            'Save selected language
            Common.SaveUserSetting("UserLanguageID", Common.UserLanguageID)
            'Save AutoSuggestion
            'Common.SaveUserSetting("CodeBoxAutoSuggestion", YJIT.SC.UI.SCView.AppAutoSuggestion.ToString)
            Common.SaveUserSetting("UseTabbedMDI", Common.UseTabbedMDI)
            'Save Login ID/passwrord state
            Common.SaveUserSetting("SavedUserID", Common.SavedUserId)
            Common.SaveUserSetting("SavedUserPwd", Common.SavedUserPwd)
            Common.SaveUserSetting("SavedUserState", Common.SavedUserState)
            Common.SaveUserSetting("SavedSessionDomain", Common.SavedSessionDomain)
            Common.SaveUserSetting("UseRibbonMDI", Common.UseRibbonMDI)
            Common.SaveUserSetting("UseRuntimeUpdate", Common.UseRuntimeUpdate)
        End Sub

        Private Sub loadCurrentUserAppSettings()
            'Restore TabMDI type and check if this is the first time running
            Common.UseTabbedMDI = Common.LoadUserSetting("UseTabbedMDI")
            If Common.UseTabbedMDI = "" Then
                Common.UseTabbedMDI = "Y"   'First time running, use default value and => no recover anymove
                Exit Sub
            End If

            'Restore Skin
            Common.UserSkinID = Common.LoadUserSetting("UserSkinID")
            'Restore Language
            Common.UserLanguageID = Common.LoadUserSetting("UserLanguageID")
            'Restore CodeBoxAutoSuggestion
            'Dim sVal As String = Common.LoadUserSetting("CodeBoxAutoSuggestion")
            'If sVal.ToUpper = "TRUE" Then
            '    YJIT.SC.UI.SCView.AppAutoSuggestion = True
            'Else
            '    YJIT.SC.UI.SCView.AppAutoSuggestion = False
            'End If
            Common.SavedUserId = Common.LoadUserSetting("SavedUserId")
            Common.SavedUserPwd = Common.LoadUserSetting("SavedUserPwd")
            Common.SavedUserState = Common.LoadUserSetting("SavedUserState")
            Common.SavedSessionDomain = Common.LoadUserSetting("SavedSessionDomain")
            Common.UseRibbonMDI = Common.LoadUserSetting("UseRibbonMDI")
            Common.UseRuntimeUpdate = Common.LoadUserSetting("UseRuntimeUpdate")
        End Sub

#End Region


        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            e.ExitApplication = False
            Dim ex As Exception
            Dim sMessage As String
            ex = e.Exception
            sMessage = "Unhandled exception occurs! Please contact system administrator!" & vbCrLf
            sMessage = ">>" & ex.Message
            While ex.InnerException IsNot Nothing
                ex = ex.InnerException
                sMessage = vbNewLine & ">>" & ex.Message
            End While
            sMessage = vbNewLine & "<<==============StackTrace================>>" & vbNewLine & e.Exception.StackTrace
            MsgBox(sMessage)
        End Sub

    End Class
End Namespace

