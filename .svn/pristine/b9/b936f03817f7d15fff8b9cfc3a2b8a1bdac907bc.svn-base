Imports System.Data
Imports System.Reflection
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports System.Collections.Specialized
Imports Microsoft.Office.Interop
Imports Microsoft.AspNet.SignalR.Client.Hubs


Public Module Common

#Region "===================== Ini Api ============================================================================="
    Private AppValuesPath As String = Application.StartupPath & "\LastValue.dat"
    Private FormConvertPath As String = Application.StartupPath & "\FormConvert.dat"

    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32.dll" Alias "GetPrivateProfileStringA" _
(ByVal lpApplicationName As String, _
 ByVal lpKeyName As String, _
 ByVal lpDefault As String, _
 ByVal lpReturnedString As System.Text.StringBuilder, _
 ByVal nSize As Integer, _
 ByVal lpFileName As String) _
As Integer

    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
        (ByVal lpApplicationName As String, _
         ByVal lpKeyName As String, _
         ByVal lpString As String, _
         ByVal lpFileName As String) _
    As Integer


    Public Function ReadIniValue(ByVal FilePath As String, ByVal Group As String, ByVal key As String) As String
        Dim sb As New System.Text.StringBuilder(255)
        Dim i As Integer = GetPrivateProfileString(Group, key, "", sb, 255, FilePath)
        Return sb.ToString()
    End Function

    ''' <summary>
    ''' Write value to INI file
    ''' </summary>
    ''' <param name="Group">The section of the file to write in</param>
    ''' <param name="key">The key in the section to write</param>
    ''' <param name="value">The value to write for the key</param>
    Public Sub WriteIniValue(ByVal FilePath As String, ByVal Group As String, ByVal key As String, ByVal value As String)
        WritePrivateProfileString(Group, key, value, FilePath)
    End Sub


#End Region



    Public Enum SendMailType
        SettingELVIS = 0
        JoinSR = 1
        CompleteMail = 2
        ARInfo = 3
        STOPInfo = 4
        CONFIRMInfo = 5
    End Enum

    Public Enum DateTimeCase
        yyyyMM = 1
        yyyyMMdd = 2
        MMdd = 3
        HHMI = 4
        HHMISS = 5
    End Enum

    Public Enum ValueType
        ImExPort = 1
        Authority = 2
    End Enum

    Public Enum BlTypes
        M = 1
        H = 2
    End Enum


    Private ContorolsValueDic As Dictionary(Of String, Object)
    Public ProcBugReporter As Process

    ''' <summary>
    ''' Specify the runtime mode of system (Development/Deployment)
    ''' </summary>
    ''' <remarks></remarks>
    Public IsDeploymentMode As Boolean = False

    Public AppDeployUrl As String   'Application Deployment identity, e.g.: http://ip:port/WCF/Client/

    ''' <summary>
    ''' Set the pointer of a class name to its containing assembly name
    ''' </summary>
    ''' <remarks></remarks>
    Public ModuleManifest As New Dictionary(Of String, String)
    Public ModuleLoadedManifest As New Dictionary(Of String, System.Reflection.Assembly)

    ''' <summary>
    ''' Set the path to the folder which contains report definition files
    ''' This will be different in development and deployment mode (see: ApplicationEvent.vb - Application_Start)
    ''' </summary>
    ''' <remarks>This include the last back slash (\) character</remarks>
    Public ReportPath As String = ".\"

    'Define the root namespace of application (used for creating correct instance of object within assembly)
    Public Const APP_ROOT_NAMESPACE As String = "YJIT.SC.App"

    Public UserSkinID As String = ""
    Public UserLanguageID As String = ""
    Public UseTabbedMDI As String = "Y"
    Public SavedUserId As String = ""   ' Used for login in screen's Remember me function
    Public SavedUserPwd As String = ""  '
    Public SavedUserState As String = "" 'Y/N
    Public SavedSessionDomain As String = "" 'Y/N
    Public UseRibbonMDI As String = "" 'Y/N
    Public UseRuntimeUpdate As String = "" 'Y/N : used for update module,report at runtime

    Public CodeServiceAPI As CodeServiceConnector
    Public LoginServiceType As String = "ALL"

    Public _IMainForm As YJIT.SC.UI.IMainForm = Nothing
    ''
    'Private _CommonCodeList As Dictionary(Of String, DataTable) = Nothing
    Public OpenWizard As Boolean = False

    Private _LoginForm As String = "LoginForm"
    Private _ServerIP As String = ""
    Public _CrmAsInputShowPicList As Boolean = True
    Public Property AsShowPicLIst As Boolean
        Get
            Return _CrmAsInputShowPicList
        End Get
        Set(ByVal value As Boolean)
            _CrmAsInputShowPicList = value
        End Set
    End Property

    Public Property IMainForm As YJIT.SC.UI.IMainForm
        Get
            Return _IMainForm
        End Get
        Set(value As YJIT.SC.UI.IMainForm)
            _IMainForm = value
        End Set
    End Property

    'Public Function CommonCodeDataTable(ByVal GroupCode As String, Optional ByVal Reload As Boolean = False) As DataTable
    '    Dim Defaultdt As New DataTable
    '    Defaultdt.Columns.Add("CODE")
    '    Defaultdt.Columns.Add("NAME")
    '    Defaultdt.Rows.Add("", "--Select--")

    '    Try
    '        If _CommonCodeList Is Nothing Then
    '            _CommonCodeList = New Dictionary(Of String, DataTable)
    '        End If
    '        Dim fTarget As Object = IMainForm.NavigateTo("CommonCode")
    '        If fTarget Is Nothing Then
    '            Return Nothing
    '        End If
    '        fTarget.GetCommonCodeList(_CommonCodeList)
    '        Dim dt As DataTable = Nothing
    '        If _CommonCodeList.TryGetValue(GroupCode, dt) = True Then
    '            Return dt
    '        Else
    '            Return Defaultdt
    '        End If

    '    Catch ex As Exception
    '        Return Defaultdt
    '    End Try

    'End Function
#Region "==============  Login Form ============================================"
    '각 업체마다 로그인 폼 다르게 설정

    ' 접속 SERVER IP
    Public Property ServerIP As String
        Get
            Return _ServerIP
        End Get
        Set(ByVal value As String)
            _ServerIP = value
        End Set
    End Property
    '   SERVER IP의 해당하는 화면 폼 명 EX) LoginForm,LoginForm1,LoginForm2
    Public Property FocusLoginFormName As String
        Get
            Return _LoginForm
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    '로그 아웃 할 시 
    Public Property GetLoginFormIntance()
        Get
            Return GetLoginFormObject("Instance")
        End Get
        Set(ByVal value)

        End Set
    End Property

    Public Property GetCreateLoginForm()
        Get
            Return GetLoginFormObject("Create")
        End Get
        Set(ByVal value)

        End Set
    End Property

    Public Property GetWebLoginForm()
        Get
            Return GetWebLoginFormObject("Class")
        End Get
        Set(ByVal value)

        End Set
    End Property

    Public Property GetLoginForm()
        Get
            Return GetLoginFormObject("Class")
        End Get
        Set(ByVal value)

        End Set
    End Property
    '화면의 오브젝트를 가져오는 함수
    Private Function GetLoginFormObject(ByVal OBJType As String) As Object
        Select Case OBJType
            Case "Class"
                'first form instace create(first login)
                Return GetClass()
            Case "Create" 'Create instance again(if lost intance)
                Dim assExecuting As Assembly = Assembly.GetExecutingAssembly()
                Dim frmView As Object = Nothing
                Dim assContainer As Assembly = Nothing
                assContainer = assExecuting
                Return assContainer.CreateInstance(Common.APP_ROOT_NAMESPACE & "." & FocusLoginFormName, True)
            Case "Instance" 'Form load again(logout)
                Return GetClass.Instance
        End Select
        Return Nothing
    End Function
    Private Function GetWebLoginFormObject(ByVal OBJType As String) As Object
        Select Case OBJType
            Case "Class"
                'first form instace create(first login)
                'Return GetWebClass()
                Return Nothing
        End Select
        Return Nothing
    End Function

    '접속 server IP로 어느 화면을 호출할지 결정
    '_LoginForm  : 로그 아웃시 사용. 프로퍼티 속성으로는 common.FocusLoginFormName 
    Private Function GetClass()

        Select Case ServerIP
            Case "http://58.58.177.103:8091"
                '================
                'WMS.J-WALONG
                '================ㅇ
                _LoginForm = "LoginForm2"
                'Return LoginForm2
                Return LoginForm
            Case "http://211.172.244.217:8080"
                '================
                'WMS.DEMO
                '================ㅇ
                _LoginForm = "LoginForm3"
                'Return LoginForm3
                Return LoginForm
                '아직 결정 안났다고 해서 Login form으로 쓰이게 해둠.
                'Case "http://211.48.103.53:8091"
                '    '================
                '    'POLARIS(ECONO)
                '    '================
                '    _LoginForm = "LoginForm1"
                '    Return LoginForm1
            Case Else
                '================
                '그외
                '================
                _LoginForm = "LoginForm"
                Return LoginForm
        End Select
    End Function
#End Region

    Public Sub ExportToExcel(ByRef obj As Object)
        Dim expYn As Boolean = True
        Dim dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        dlgSaveExcel.Filter = "Excel File (*.xlsx)|*.xlsx|Excel File (*.xls)|*.xls|All Files (*.*)|*.*"

        If Not obj Is Nothing Then
            Select Case obj.GetType.FullName
                Case "YJIT.SC.UI.SCControls.WebGrid"
                    If dlgSaveExcel.ShowDialog() = DialogResult.OK Then
                        Dim currentCursor As Cursor = Cursor.Current
                        Try
                            Cursor.Current = Cursors.WaitCursor
                            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(obj.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
                            view.OptionsPrint.ExpandAllGroups = False
                            view.OptionsPrint.AutoWidth = False
                            If UCase(Right(dlgSaveExcel.FileName, 4)) = UCase(".xls") Then
                                view.ExportToXls(dlgSaveExcel.FileName)
                            Else
                                view.ExportToXlsx(dlgSaveExcel.FileName)
                            End If
                        Catch ex As Exception
                            expYn = False
                        End Try
                        Cursor.Current = currentCursor
                    End If
                    'obj.OptionsPrint.ExpandAllDetails = ViewExpandAllDetails
                Case "DevExpress.XtraPivotGrid.PivotGridControl"
                    'ExportExcelPivot(drEx, dlgSaveExcel)
                Case "DevExpress.XtraTreeList.TreeList"
                    'ExportExcelTree(drEx, dlgSaveExcel)
            End Select
        End If

        If dlgSaveExcel.FileName <> "" Then
            If MsgBoxSC("Do you want open this file?", MessageBoxButtons.YesNo, "Open", MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
                process.StartInfo.FileName = dlgSaveExcel.FileName
                process.StartInfo.Verb = "Open"
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                process.Start()
            End If
        End If

    End Sub
    '오피스별 필수값 체크 하기 위한 함수
    Public Function ValidateOfficeValue(ByVal form As Object) As Boolean
        Dim dsRet As New DataSet
        Dim params As Object = {form.Name.ToString.ToUpper}
        Dim ResultMsg As String = ""
        Dim NotExistColumn As String = ""
        Dim NotExistValue As String = ""
        Dim listTitle As String = CType(YJIT.SC.UI.SCView.MainFormInstance, Object).Localizer.GetLocalizedString("Mandatory entry does not exist")
        Dim MsgboxTitle As String = CType(YJIT.SC.UI.SCView.MainFormInstance, Object).Localizer.GetLocalizedString("Validation")

        'Try
        '    dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Common", "GetOfficeMandatory", params)
        'Catch ex As Exception

        'End Try
        Try
            If YJIT.SC.UI.SCView.PreloadedCodeListData IsNot Nothing AndAlso _
                    YJIT.SC.UI.SCView.PreloadedCodeListData.ContainsKey("OfficeMandatory") Then
                Dim dt As DataTable = YJIT.SC.UI.SCView.PreloadedCodeListData("OfficeMandatory").Clone
                If YJIT.SC.UI.SCView.PreloadedCodeListData("OfficeMandatory").Select("PGM_ID = '" & form.Name.ToString.ToUpper & "'").Count > 0 Then
                    dt = YJIT.SC.UI.SCView.PreloadedCodeListData("OfficeMandatory").Select("PGM_ID = '" & form.Name.ToString.ToUpper & "'").CopyToDataTable()
                End If
                dt.TableName = "Data.MandatoryList"
                dsRet.Tables.Add(dt)
            End If
        Catch ex As Exception
            If ClientSessionInfo.UserID.ToUpper = "ADMIN" Then DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Function
        End Try

        Dim Mandatory As DataTable = dsRet.Tables("Data.MandatoryList")
        If Mandatory Is Nothing Then Exit Function
        Dim FormDs As DataSet = form.ConvertToDataset
        Dim FormDt As DataTable = FormDs.Tables("MAIN")
        Dim FocusName As String = ""
        Dim valSeq As String = "√ "

        For i = 0 To Mandatory.Rows.Count - 1
            Dim Control As String = Mandatory.Rows(i)("ITEM_CD").ToString
            Dim Caption As String = Mandatory.Rows(i)("ITEM_NM").ToString.Replace(vbCrLf, "")

            If FormDt.Columns.Contains(Control) Then
                If Trim(FormDt.Rows(0)(Control).ToString) = "" Then
                    NotExistValue &= valSeq & CType(YJIT.SC.UI.SCView.MainFormInstance, Object).Localizer.GetLocalizedString(Caption) & vbCrLf
                    If FocusName = "" Then FocusName = Control
                End If
            Else
                If ClientSessionInfo.UserID.ToUpper = "ADMIN" Then
                    NotExistColumn &= Control & ", "
                    If FocusName = "" Then FocusName = Control
                Else
                    NotExistValue &= Caption & ", "
                    If FocusName = "" Then FocusName = Control
                End If

            End If
        Next


        If NotExistColumn <> "" Then
            NotExistColumn = NotExistColumn.Substring(0, NotExistColumn.Length - 1)
            ResultMsg &= listTitle & vbCrLf & NotExistColumn & vbCrLf
        End If

        If NotExistValue <> "" Then
            NotExistValue = NotExistValue.Substring(0, NotExistValue.Length - 1)
            ResultMsg &= listTitle & vbCrLf & NotExistValue & vbCrLf
        End If

        If ResultMsg = "" Then
            Return False
        Else
            Dim controlList As Control.ControlCollection = CType(form.Controls, Control.ControlCollection)
            GetControlList(controlList, Mandatory, FocusName)

            ResultMsg = ResultMsg.Substring(0, ResultMsg.Length - 1)

            DevExpress.XtraEditors.XtraMessageBox.Show(ResultMsg, MsgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If

    End Function

    Private Sub MandatoryCheck(ByVal control As Control, ByVal Mandatory As DataTable, Optional ByVal FoucsControl As String = "")
        Dim FullName As String = control.Name.ToUpper
        Dim YjitControl As Object = control
        Dim Period As Integer = 0

        If FoucsControl = "" Then
            Dim ExistChk() As DataRow = Mandatory.Select("ITEM_CD = '" & FullName & "'")
            If ExistChk.Length > 0 Then
                Try
                    '프레임워크 컨트롤이 아니면 걍제 에러 발생
                    YjitControl.BorderColor = System.Drawing.Color.Red
                    YjitControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

                    If ExistChk(0)("DFT_DAY").ToString <> "" Then
                        YjitControl.Text = Now.AddDays(ExistChk(0)("DFT_DAY")).ToString("yyyyMMdd")
                    End If

                Catch ex As Exception
                End Try
            End If
        Else
            If FullName = FoucsControl Then
                YjitControl.focus()
            End If
        End If

    End Sub

    Private Sub GetControlList(ByVal controls As Control.ControlCollection, ByVal Mandatory As DataTable, Optional ByVal FoucsControl As String = "")
        For Each Control In controls
            Dim cntr As Control = CType(Control, Control)
            MandatoryCheck(Control, Mandatory, FoucsControl)

            Try
                GetControlList(cntr.Controls, Mandatory, FoucsControl)
            Catch ex As Exception

            End Try
        Next
    End Sub
    Public Function ImportExcel(ByVal PrmPathExcelFile As String) As DataSet
        Dim DtSet As DataSet
        Dim strExt As String
        Dim strConn As String

        Try
            ''''''' Fetch Data from Excel

            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            strExt = Mid(PrmPathExcelFile, InStrRev(PrmPathExcelFile, ".") + 1)
            If UCase(strExt) = "XLS" Then
                strConn = "provider=Microsoft.Jet.OLEDB.4.0; " & _
                            "data source='" & PrmPathExcelFile & " '; " & "Extended Properties=Excel 8.0;"
            Else
                strConn = "provider=Microsoft.ACE.OLEDB.12.0; " & _
                            "data source='" & PrmPathExcelFile & " '; " & "Extended Properties=Excel 12.0;"
            End If
            'MyConnection = New System.Data.OleDb.OleDbConnection(strConn)

            ' Select the data from Sheet1 of the workbook.
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet$]", strConn)

            MyCommand.TableMappings.Add("Table", "ExcelData")

            DtSet = New System.Data.DataSet

            MyCommand.Fill(DtSet)
        Catch ex As Exception
            Throw ex
            DtSet = Nothing
        End Try

        '/// return dataset
        Return DtSet

    End Function

    Public Function FileUpload(ByVal fname As String, Optional ByVal SavePath As String = "/EMAIL/SEND/", Optional ByVal UseAbsolutePath As Boolean = False) As Boolean
        '단건 화면에서 전송
        Dim sFilePath = fname
        Try
            If sFilePath <> "" Then
                '업로드
                Dim sUploadHandler As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "UploadHandler.aspx" 'must be available on server
                ' Create a new WebClient instance.
                Dim wc As New System.Net.WebClient()
                Dim responseArray As Byte()
                Try

                    Dim myQueryStringCollection As New NameValueCollection()
                    If UseAbsolutePath Then ' 절대경로
                        myQueryStringCollection.Add("AbsolutePath", SavePath)
                    Else
                        '상대경로
                        myQueryStringCollection.Add("SavePath", SavePath) 'Ex)  SavePath  :  "/EMAIL/SEND/" 
                    End If

                    Dim infoReader As System.IO.FileInfo
                    infoReader = My.Computer.FileSystem.GetFileInfo(sFilePath)

                    If infoReader.Length <= 10485760 Then
                        wc.QueryString = myQueryStringCollection
                        responseArray = wc.UploadFile(sUploadHandler, "POST", sFilePath)
                    Else
                        responseArray = System.Text.Encoding.ASCII.GetBytes("N" & vbCr & "Upload failed! File size exceeds 10mb limit. " + infoReader.Name)
                    End If


                Catch ex As Exception
                    MsgBox("Upload failed!" & ex.Message)
                    Return False
                End Try
                Dim sResult As String
                Dim encoding As New System.Text.UTF8Encoding
                sResult = encoding.GetString(responseArray)

                '//////////////////WCF Call to process uploaded file////////////////
                Dim parts() As String = sResult.Split(vbCr)

                If sResult.StartsWith("N") Then
                    MsgBox(parts(1))
                    Return False
                    Exit Function
                End If

                If sResult.StartsWith("Y") Then  'Y-> Success
                    ' UPLOAD_FILE_NM.Text = parts(1)
                Else

                    MsgBox("Failed to upload file!")
                    Return False
                    Exit Function
                End If
            End If


            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            Exit Function
        End Try
    End Function

    Public Function TrySubstring(ByVal str As String, ByVal StartIndex As Integer, ByVal length As Integer)
        Dim newStr As String = str
        Try
            newStr = str.Substring(StartIndex, length)
        Catch ex As Exception
            newStr = str
        End Try

        Return newStr
    End Function

    Dim PrintTool As DevExpress.XtraReports.UI.ReportPrintTool
    Public Sub ReportPrintTool(ByVal rpt As DevExpress.XtraReports.UI.XtraReport)
        ' 이병호 추가 


        PrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        PrintTool.PrintingSystem.ContinuousPageNumbering = True
        PrintTool.AutoShowParametersPanel = False
        AddHandler PrintTool.PrintingSystem.StartPrint, AddressOf StartPrint
        AddHandler PrintTool.PrintingSystem.EndPrint, AddressOf EndPrint
        PrintTool.ShowPreview()

    End Sub

    Private Sub StartPrint(ByVal sender As Object, ByVal e As System.EventArgs)
        PrintTool.PreviewForm.Activate()
    End Sub

    Private Sub EndPrint(ByVal sender As Object, ByVal e As System.EventArgs)
        PrintTool.PreviewForm.Activate()
    End Sub


    Public Function SynchronizeUserSessionInfo(ByVal userId As String, Optional ByVal ReqSvc As String = "ALL")
        Dim dsUserSessionInfo As DataSet
        CodeServiceAPI = New CodeServiceConnector
        'Make WCF call to retrieve those information from database
        '////////WCF Service Call/////////
        'Build up the parameter (array type)
        Try
            'Econo 만 해당
            Dim Param_ReqSvc As String = ReqSvc
            If Trim(userId.ToUpper) = "ADMIN" Then Param_ReqSvc = "ALL"


            dsUserSessionInfo = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.WCF.ClientService", "SynchronizeUserSessionInfo", {userId, Param_ReqSvc})

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

        '//////Parsing WCF returned data///////
        Dim drPairs As DataRow
        drPairs = dsUserSessionInfo.Tables("KEY_VALUE_PAIRS").Rows(0)

        If drPairs("TrxCode") = "SUCCESS" Then
            ClientSessionInfo.SetValues(dsUserSessionInfo.Tables("Data.UserInfo").Rows(0))
            ClientSessionInfo.UserPgmAuthInfo = dsUserSessionInfo.Tables("Data.UserPgmAuthInfo")
            ClientSessionInfo.UserFuncAuthInfo = dsUserSessionInfo.Tables("Data.UserFuncAuthInfo")
            ClientSessionOfficeInfo.SetValues(dsUserSessionInfo.Tables("Data.OfficeInfo").Rows(0))

            'Link the user authority info
            YJIT.SC.UI.SCView.UserFuncAuthInfo = ClientSessionInfo.UserFuncAuthInfo
            YJIT.SC.UI.SCView.UserPgmAuthInfo = ClientSessionInfo.UserPgmAuthInfo

            'Get the pre load code list
            YJIT.SC.UI.SCView.PreloadedCodeListData = New Dictionary(Of String, DataTable)

            'Dim sName As String
            'For Each dt As DataTable In dsUserSessionInfo.Tables
            '    If dt.TableName.StartsWith("Data.CodeList.") Then
            '        sName = dt.TableName
            '        sName = sName.Replace("Data.CodeList.", "").Replace(" ", "").Replace("'", "").ToUpper  'Remove prefix, and do not care space,single quote '
            '        dt.TableName = sName
            '        YJIT.SC.UI.SCView.PreloadedCodeListData(sName) = dt
            '    End If
            'Next

            Dim sName As String
            For Each dt As DataTable In dsUserSessionInfo.Tables
                If dt.TableName.StartsWith("Data.CodeList.") Then
                    sName = dt.TableName
                    sName = sName.Replace("Data.CodeList.", "").Replace(" ", "").Replace("'", "").ToUpper  'Remove prefix, and do not care space,single quote '
                    dt.TableName = sName
                    YJIT.SC.UI.SCView.PreloadedCodeListData(sName) = dt
                ElseIf dt.TableName.StartsWith("Data.TableList.") Then
                    sName = dt.TableName
                    sName = sName.Replace("Data.TableList.", "").Replace(" ", "").Replace("'", "") 'Remove prefix, and do not care space,single quote '
                    dt.TableName = sName
                    YJIT.SC.UI.SCView.PreloadedCodeListData(sName) = dt
                End If
            Next

            If ClientSessionOfficeInfo.DateFormat = "" Then
                YJIT.SC.UI.SCControls.DateBox.AppDateFormat = "YYYY-MM-DD"
            Else
                YJIT.SC.UI.SCControls.DateBox.AppDateFormat = ClientSessionOfficeInfo.DateFormat
            End If

        ElseIf drPairs("TrxCode") = "NODATA" Then
            MsgBox(drPairs("TrxMsg"))
            'May quit application
        End If

        Return dsUserSessionInfo
    End Function


    ''' <summary>
    ''' This will:
    ''' +Remove the datatable prefixes appended by the server MethodCall during conversion from dictionary to dataset process
    ''' +Remove the "KEY_VALUE_PAIRS" table which was automatically injected by WCF
    ''' </summary>
    ''' <param name="dsInput"></param>
    ''' <returns>The new dataset with tablename without prefix</returns>
    ''' <remarks>This function is designed to use with Reporting with XtraReports</remarks>

    Public Function AdaptDataSourceForReport(ByVal dsInput As DataSet) As DataSet
        'Remove the datatable prefixes
        For Each dt As DataTable In dsInput.Tables
            Dim sTableName As String = dt.TableName
            If sTableName.Contains(".") Then      'E.g: [Data.WG1] -> [WG1]
                dt.TableName = sTableName.Remove(0, sTableName.IndexOf(".") + 1)
            End If
        Next
        If dsInput.Tables.Contains("KEY_VALUE_PAIRS") Then
            dsInput.Tables.Remove("KEY_VALUE_PAIRS")
        End If

        Return dsInput
    End Function

    ''' <summary>
    ''' Get the final report with check the customized version for each customer
    ''' </summary>
    ''' <param name="relativePath">relative path to the file</param>
    ''' <returns>the final path</returns>
    ''' <remarks>if there is a cusomtized report for customer A, it must be put into the RPT\CUSTOMERS folder...</remarks>
    Public Function GetReportFile(ByVal relativePath As String) As String
        Dim returnPath As String = Common.ReportPath & "CUSTOMERS\" & ClientSessionInfo.OfficeCode & "\" & relativePath
        If IO.File.Exists(returnPath) Then
            Dim fi As IO.FileInfo = New IO.FileInfo(returnPath)
            If fi.Length > 0 Then 'If file size = 0 => not use this file
                Return returnPath
            Else
                Return Common.ReportPath & relativePath
            End If
        Else
            Return Common.ReportPath & relativePath
        End If
    End Function

    ''' <summary>
    ''' Upload a file to WCF server (for *.dll file, repx file or EDM files : options via sFlag)
    ''' </summary>
    ''' <param name="sFilePath">Full local path to file (not starts with /, ends with \)</param>
    ''' <param name="sFileName">Name of file</param>
    ''' <returns>Empty string if failed, otherwise, server path of uploaded file.</returns>
    ''' <remarks>This method used with server handler at WCF/WcfUploadHandler.aspx</remarks>
    Public Function UploadFile(ByVal sFilePath As String, ByVal sFileName As String, Optional ByVal sFlag As String = "") As String
        Dim sFileFullPath As String = sFilePath & sFileName
        If Not IO.File.Exists(sFileFullPath) Then
            MsgBox("Upload file (" & sFileFullPath & ") not exists!")
            Return String.Empty 'Failed
        End If

        Try
            Dim sUploadHandler As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "WcfUploadHandler.aspx" 'must be available on server
            If sFlag <> "" Then sUploadHandler &= sFlag

            ' Create a new WebClient instance.
            Dim wc As New System.Net.WebClient()
            Dim responseArray As Byte()
            Try
                ' Upload the file to the Url using the HTTP 1.0 POST.
                responseArray = wc.UploadFile(sUploadHandler, "POST", sFileFullPath)
            Catch ex As Exception
                MsgBox("Upload failed!" & ex.Message)
                Return String.Empty 'Failed
            End Try
            'Parsing the result
            Dim sResult As String
            Dim encoding As New System.Text.UTF8Encoding
            sResult = encoding.GetString(responseArray)

            Dim parts() As String = sResult.Split(vbCr)
            If parts.Length < 2 Then 'Expected 2 lines (1st line: Y/N, 2nd line: uploaded path/error message)
                Throw New Exception("Upload error! Invalid return message!")
            End If

            Select Case Trim(parts(0))
                Case "Y"
                    Return sResult.Substring(2)   'Return path on server
                Case Else 'N
                    MsgBoxSC("Failed to upload file!" & sResult.Substring(2))
                    Return String.Empty
            End Select
        Catch ex As Exception
            MsgBoxSC(ex.Message)
            Return String.Empty 'Failed
        End Try
    End Function

    '''<remarks>폴더안에 있는 파일 삭제,예외처리까지 해둠</remarks>
    '''     ''' 
    Public Sub DeleteDirectoryFiles(ByVal path As String, Optional ByVal SearchPattern As String = "*.*")
        Try
            If IO.Directory.Exists(path) = False Then
                IO.Directory.CreateDirectory(path)
            Else
                Dim fList As String() = IO.Directory.GetFiles(path, SearchPattern)
                For Each f As String In fList
                    File.Delete(f)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    '''<reamrks> 서버에 파일 전송</reamrks>
    ''' ex) serverPath = /DOC/SEND/
    ''' 서버 폴더 기준으로 사용
    Public Function UploadToServer(ByVal UploadFilePath As String, ByVal serverPath As String) As Boolean

        '단건 화면에서 전송
        Dim sFilePath = UploadFilePath

        Try
            If sFilePath <> "" Then
                '업로드
                Dim sUploadHandler As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "WCF_DLL_UploadHandler.aspx" 'must be available on server
                ' Create a new WebClient instance.
                Dim wc As New System.Net.WebClient()
                Dim responseArray As Byte()
                Try
                    Dim myQueryStringCollection As New NameValueCollection()
                    myQueryStringCollection.Add("SavePATH", serverPath)
                    wc.QueryString = myQueryStringCollection

                    ' Upload the file to the Url using the HTTP 1.0 POST.
                    responseArray = wc.UploadFile(sUploadHandler, "POST", sFilePath)
                Catch ex As Exception
                    DevExpress.XtraEditors.XtraMessageBox.Show("Upload failed!" & ex.Message)
                    Return False

                End Try

                Dim sResult As String
                Dim encoding As New System.Text.UTF8Encoding
                sResult = encoding.GetString(responseArray)

                '//////////////////WCF Call to process uploaded file////////////////
                Dim parts() As String = sResult.Split(vbCr)

                If sResult.StartsWith("N") Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Upload server process failed!" & sResult)
                    Return False
                    Exit Function
                End If

                If sResult.StartsWith("Y") Then  'Y-> Success
                    ' UPLOAD_FILE_NM.Text = parts(1)
                Else

                    DevExpress.XtraEditors.XtraMessageBox.Show("Failed to upload file!")
                    Return False
                    Exit Function
                End If
            End If


            Return True

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)
            Return False
            Exit Function
        End Try
    End Function

    ''' <summary>
    ''' Customs MessageBox for SmartClient which uses Devexpress message style + localized string
    ''' </summary>
    ''' <param name="Message">Message to show</param>
    ''' <param name="Buttons">Buttons to be allowed</param>
    ''' <param name="caption">Box title string</param>
    ''' <param name="localized">True/False</param>
    ''' <returns></returns>
    ''' <remarks>This function works same as YJIT.SC.View.MsgBoxLocalized(), but it can be called anywhere outside a form</remarks>
    Public Function MsgBoxSC(ByVal message As Object, Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK, _
                             Optional ByVal caption As Object = Nothing, Optional ByVal icon As System.Windows.Forms.MessageBoxIcon = MessageBoxIcon.Information, _
                             Optional ByVal defaultButton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1, _
                             Optional ByVal localized As Boolean = True) As MsgBoxResult
        Dim sMsg As String = message & ""
        Dim sTitle As String = caption & ""

        If localized AndAlso My.Resources.ResourceManager IsNot Nothing Then
            If sTitle = "" Then
                sTitle = My.Resources.ResourceManager.GetString("Alert")
                If sTitle = "" Then sTitle = "Alert" 'Not able to find a translation
            End If
            sMsg = My.Resources.ResourceManager.GetString(sMsg)
            If sMsg = "" Then sMsg = message & "" 'Not able to find a translation
        End If

        Return DevExpress.XtraEditors.XtraMessageBox.Show(sMsg, sTitle, buttons, icon, defaultButton)
    End Function

    ''' <summary>
    ''' Display the Bug reporting client tool
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public Sub ShowBugReporterClient()
        Dim bugReporter As String = Application.StartupPath & "\YJIT.Issue.exe"
        Try
            If ProcBugReporter Is Nothing Then
                ' Start the child process.
                ProcBugReporter = New Process
            End If
            ' Redirect the output stream of the child process.
            With ProcBugReporter
                '.StartInfo.UseShellExecute = False
                '.StartInfo.RedirectStandardOutput = False
                .StartInfo.Arguments = "NoSystemTray"                   'Will not allow program to hide in system tray
                .StartInfo.FileName = bugReporter
                .Start()
            End With
        Catch ex As Exception
            MsgBox("Could not load bug reporter client!" & vbNewLine & ex.Message & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    ''' <summary>
    ''' Save user setting
    ''' </summary>
    ''' <param name="sKey">Key name of object</param>
    ''' <param name="sValue">Value to be saved</param>
    ''' <remarks></remarks>
    Public Sub SaveUserSetting(ByVal sKey As String, ByVal sValue As String)
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE", True)
        regKey.CreateSubKey("YJIT.SC.Home\" & Windows.Forms.Application.StartupPath)
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\YJIT.SC.Home\" & Windows.Forms.Application.StartupPath, True)
        Try
            regKey.SetValue(sKey, sValue)
        Catch ex As Exception
            'Unable to save user preference
        Finally
            regKey.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Load a user setting
    ''' </summary>
    ''' <param name="sKey">Key name of object</param>
    ''' <returns></returns>
    ''' <remarks>If not found, return empty</remarks>
    Public Function LoadUserSetting(ByVal sKey As String) As String
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\YJIT.SC.Home\" & Windows.Forms.Application.StartupPath, True)
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

    '날자값 체크
    Public Function ValidateDateTime(ByVal format As DateTimeCase, ByVal value As Object, Optional ByVal UseOnlyNumeric As Boolean = False) As Boolean
        Try
            Dim yyyy As String = "2013"
            Dim mm As String = "01"
            Dim dd As String = "01"
            Dim hh As String = "01"
            Dim mi As String = "01"
            Dim ss As String = "01"
            Dim chkStr As String = value.ToString
            Dim DateTime As String = ""
            Dim chr() As Char = chkStr.ToCharArray
            Dim DateBoolean As Boolean = Nothing

            If UseOnlyNumeric Then
                For i = 0 To chr.Length - 1
                    If IsNumeric(chr(i)) Then
                        DateTime = DateTime & chr(i)
                    End If
                Next
            Else
                DateTime = value.ToString
            End If


            Select Case format
                Case DateTimeCase.yyyyMM
                    yyyy = TrySubstring(DateTime, 0, 4)
                    mm = TrySubstring(DateTime, 4, 2)
                    If DateTime.Length <> 6 Then Return False
                Case DateTimeCase.yyyyMMdd
                    yyyy = TrySubstring(DateTime, 0, 4)
                    mm = TrySubstring(DateTime, 4, 2)
                    dd = TrySubstring(DateTime, 6, 2)
                    If DateTime.Length <> 8 Then Return False
                Case DateTimeCase.MMdd
                    mm = TrySubstring(DateTime, 0, 2)
                    dd = TrySubstring(DateTime, 2, 2)
                    If DateTime.Length <> 4 Then Return False
                Case DateTimeCase.HHMI
                    hh = TrySubstring(DateTime, 0, 2)
                    mi = TrySubstring(DateTime, 2, 2)
                    If DateTime.Length <> 4 Then Return False
                Case DateTimeCase.HHMISS
                    hh = TrySubstring(DateTime, 0, 2)
                    mi = TrySubstring(DateTime, 2, 2)
                    ss = TrySubstring(DateTime, 4, 2)
                    If DateTime.Length <> 6 Then Return False
            End Select
            DateBoolean = IsDate(yyyy & "-" & mm & "-" & dd & " " & hh & ":" & mi & ":" & ss)
            Return DateBoolean
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function SendEmail(ByVal SENDER As String, ByVal RECEIVER As String, ByVal SUBJECT As String, _
                                    Optional ByVal CC As String = "", Optional ByVal CONTENT As String = "", Optional ByVal FileDt As DataTable = Nothing) As Dictionary(Of String, Object)
        Dim RtnDic As New Dictionary(Of String, Object)
        Dim ValueChk As String = ""
        Dim UploadFilePath As String = "/EMAIL/SEND/"
        RtnDic("TrxCode") = "N"
        RtnDic("TrxMsg") = ""


        Try

            If SENDER = "" Then
                ValueChk &= "Sender,"
            End If
            If RECEIVER = "" Then
                ValueChk &= "Receiver,"
            End If
            If SUBJECT = "" Then
                ValueChk &= "Subject,"
            End If

            If ValueChk <> "" Then
                ValueChk = ValueChk.Substring(0, ValueChk.Length - 1)
                Throw New Exception("Data Missing. (" & ValueChk & ")")
            End If
            '파일 전송 목록 테이블
            If Not FileDt Is Nothing Then
                If Not FileDt.Columns.Contains("FULL_PATH") Then
                    Throw New Exception("Data Column Missing. (FULL_PATH)")
                End If

                For i = 0 To FileDt.Rows.Count - 1
                    Dim FilePath As String = FileDt.Rows(i)("FULL_PATH").ToString
                    If Not FileUpload(FilePath, UploadFilePath) Then
                        Throw New Exception("Failed  to Upload  File. (" & FilePath & ")")
                        Continue For
                    End If
                Next
            End If

            Dim dsRet As DataSet
            Dim drPairs As DataRow
            Dim ParamDs As New DataSet
            Dim ParamDt As New DataTable
            ' 기본 정보
            ParamDt.TableName = "MAIN"
            ParamDt.Columns.Add("SENDER")
            ParamDt.Columns.Add("RECEIVER")
            ParamDt.Columns.Add("SUBJECT")
            ParamDt.Columns.Add("CONTENT")
            ParamDt.Columns.Add("CC")
            ParamDt.Rows.Add(SENDER, RECEIVER, SUBJECT, CONTENT.ToString.Replace(vbCrLf, "<BR>").Replace(" ", "&nbsp;"), CC)
            ParamDs.Tables.Add(ParamDt)

            If Not FileDt Is Nothing Then
                '전송한 파일의 정보
                ParamDt = FileDt.Clone
                ParamDt.TableName = "FILEDT"

                If Not ParamDt.Columns.Contains("NAME") Then
                    ParamDt.Columns.Add("NAME")
                End If
                For i = 0 To FileDt.Rows.Count - 1
                    ParamDt.Rows.Add()
                    ParamDt.Rows(i)("FULL_PATH") = FileDt.Rows(i)("FULL_PATH")
                    ParamDt.Rows(i)("FILE_NAME") = FileDt.Rows(i)("FULL_PATH")
                    Dim str As String = ParamDt.Rows(i)("FULL_PATH")
                    ParamDt.Rows(i)("NAME") = str.Substring(str.LastIndexOf("\") + 1, str.Length - 1 - str.LastIndexOf("\"))
                Next
                ParamDs.Tables.Add(ParamDt)
            End If

            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Email", "SendEmail", ParamDs)
            drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
            RtnDic("TrxCode") = drPairs("TrxCode")
            RtnDic("TrxMsg") = drPairs("TrxMsg")
        Catch ex As Exception
            RtnDic("TrxMsg") = ex.Message
        End Try
        Return RtnDic
    End Function


    Public Sub SetMandatoryLine(ByVal cntr As Object)
        Try
            cntr.BorderColor = System.Drawing.Color.Red
            cntr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SetMandatoryLine(ByVal cntrList() As Object)

        For Each cntr In cntrList
            Try
                cntr.BorderColor = System.Drawing.Color.Red
                cntr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Catch ex As Exception

            End Try
        Next

    End Sub

    Private Function GridValueCheckCase(ByVal Item As Object, ByVal GvValue As Object) As Boolean
        Dim ReturnValue As Boolean = False
        '필드가 넘버형일 때 널값이나  0 이면 걸림
        If Not Item Is Nothing Then
            Select Case Item.GetType.FullName
                Case "DevExpress.XtraEditors.Repository.RepositoryItemTextEdit"
                    If Item.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric Then
                        If TryCDbl(GvValue) = 0 Then
                            ReturnValue = True
                        End If
                    End If
            End Select
        End If
        If GvValue = "" Then
            ReturnValue = True
        End If
        Return ReturnValue
    End Function
    '그리드 필수 값 체크


#Region "====  ValidateGridValue  ======="
    Private Function CheckExistGridColumn(ByVal GridView As Object, ByVal FieldName As String) As Boolean
        Dim ChkValue As Object = Nothing
        Select Case GridView.GetType.FullName
            Case "DevExpress.XtraGrid.Views.Grid.GridView"
                ChkValue = CType(GridView, DevExpress.XtraGrid.Views.Grid.GridView).Columns(FieldName)
            Case "DevExpress.XtraGrid.Views.BandedGrid.BandedGridView"
                ChkValue = CType(GridView, DevExpress.XtraGrid.Views.BandedGrid.BandedGridView).Columns(FieldName)
            Case "DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView"
                ChkValue = CType(GridView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView).Columns(FieldName)
        End Select
        If ChkValue Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function GetGridColumnEdit(ByVal GridView As Object, ByVal FieldName As String)
        Dim GetEdit As Object = Nothing
        Select Case GridView.GetType.FullName
            Case "DevExpress.XtraGrid.Views.Grid.GridView"
                GetEdit = CType(GridView, DevExpress.XtraGrid.Views.Grid.GridView).Columns(FieldName).ColumnEdit
            Case "DevExpress.XtraGrid.Views.BandedGrid.BandedGridView"
                GetEdit = CType(GridView, DevExpress.XtraGrid.Views.BandedGrid.BandedGridView).Columns(FieldName).ColumnEdit
            Case "DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView"
                GetEdit = CType(GridView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView).Columns(FieldName).ColumnEdit
        End Select
        Return GetEdit
    End Function

    Private Function GetGridColumn(ByVal GridView As Object, ByVal FieldName As String)
        Dim GetColumn As Object = Nothing
        Select Case GridView.GetType.FullName
            Case "DevExpress.XtraGrid.Views.Grid.GridView"
                GetColumn = CType(GridView, DevExpress.XtraGrid.Views.Grid.GridView).Columns(FieldName)
            Case "DevExpress.XtraGrid.Views.BandedGrid.BandedGridView"
                GetColumn = CType(GridView, DevExpress.XtraGrid.Views.BandedGrid.BandedGridView).Columns(FieldName)
            Case "DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView"
                GetColumn = CType(GridView, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView).Columns(FieldName)
        End Select
        Return GetColumn
    End Function

    Public Function ValidateGridValue(ByVal GridView As Object, ByVal ColumnList As Dictionary(Of String, Object), Optional ByVal MandField() As String = Nothing) As Boolean
        Dim RetrunMsg As String = ""
        Dim RetrunMsg1 As String = ""
        Dim Check As Boolean = False
        Dim FirstRowHandle As Integer = 0
        Dim GvColumn As Object = Nothing
        Dim DeleteRowCount As Integer = 0



        If Not MandField Is Nothing Then
            For i = GridView.RowCount - 1 To 0 Step -1
                If GridView.GetDataRow(i).RowState = DataRowState.Added Then

                    For Each column As String In MandField
                        If CheckExistGridColumn(GridView, column) Then
                            Dim Item As Object = GetGridColumnEdit(GridView, column)
                            Dim GvValue As Object = Trim(GridView.GetRowCellValue(i, column).ToString)
                            '값이 있으면 false
                            Check = GridValueCheckCase(Item, GvValue)

                            If Check = True Then
                                GridView.DeleteRow(i)
                                DeleteRowCount += 1
                                Exit For
                            End If
                        End If
                    Next
                    '해당로우에 필수 값이 하나도 없으면 해당로우 삭제  
                End If
            Next
        End If
        For i = GridView.RowCount - 1 To 0 Step -1
            For Each column As String In ColumnList.Keys
                If CheckExistGridColumn(GridView, column) Then
                    Dim Item As Object = GetGridColumnEdit(GridView, column)
                    Dim GvValue As Object = Trim(GridView.GetRowCellValue(i, column).ToString)

                    ' 그외는 값 체크
                    If GridValueCheckCase(Item, GvValue) Then
                        FirstRowHandle = i
                        GvColumn = GetGridColumn(GridView, column)
                        RetrunMsg = (i + 1).ToString & "Row " & CType(YJIT.SC.UI.SCView.MainFormInstance, Object).Localizer.GetLocalizedString(ColumnList(column)) & vbCrLf & RetrunMsg
                        Exit For
                    End If
                Else
                    RetrunMsg1 &= CType(YJIT.SC.UI.SCView.MainFormInstance, Object).Localizer.GetLocalizedString(ColumnList(column)) & vbCrLf
                End If
            Next
        Next
        If RetrunMsg <> "" Or RetrunMsg1 <> "" Then
            Dim ResultMsg As String = ""
            GridView.FocusedRowHandle = FirstRowHandle
            If Not GvColumn Is Nothing Then
                GridView.FocusedColumn = GvColumn
            End If
            GridView.ShowEditor()
            If RetrunMsg <> "" Then
                RetrunMsg = "Not exist mandatory values!" & vbCrLf & RetrunMsg.Substring(0, RetrunMsg.Length - 2)
            End If

            If RetrunMsg1 <> "" Then
                If RetrunMsg <> "" Then RetrunMsg = RetrunMsg & vbCrLf
                RetrunMsg1 = "Not exist column" & vbCrLf & RetrunMsg1.Substring(0, RetrunMsg1.Length - 2)
            End If

            ResultMsg = RetrunMsg & RetrunMsg1
            DevExpress.XtraEditors.XtraMessageBox.Show(ResultMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return True
        End If
        Return False

    End Function
#End Region

    'dbnull, "" 값 그 외 형변환이 안되는 값은  강제적으로 0 
    Public Function TryCDbl(ByVal value As Object)
        Dim NewValue As Double = 0
        Try
            NewValue = CDbl(value)
        Catch ex As Exception

        End Try
        Return NewValue
    End Function

    'dbnull, "" 값 그 외 형변환이 안되는 값은  강제적으로 0 
    Public Function TryCDec(ByVal value As Object)
        Dim NewValue As Decimal = 0.0
        Try
            NewValue = CDec(value)
        Catch ex As Exception

        End Try
        Return NewValue
    End Function


    '  =====   GetBound   =====
    'LocCtryCD   : 국가 코드
    'REF_NO      : 비엘 번호
    'BlType      : M,H구분자
    'ValueType   : E,I or ORIN,DEST
    'LocCtryCD   : 국가 코드
    'PolCd,PodCd : 포트 코드

    Public Function GetBound(ByVal LocCtryCD As String, ByVal REF_NO As String, ByVal BlType As BlTypes, Optional ByVal ValueType As ValueType = ValueType.ImExPort) As String
        Return GetExImPort("", LocCtryCD, REF_NO, BlType, "", "", ValueType)
    End Function
    'OfficeCd는 추후에 추가될지 몰라서 빈값
    Public Function GetBound(ByVal LocCtryCD As String, ByVal PolCd As String, ByVal PodCd As String, Optional ByVal ValueType As ValueType = ValueType.ImExPort) As String
        Return GetExImPort("", LocCtryCD, "", BlTypes.H, PolCd, PodCd, ValueType)
    End Function

    Private Function GetExImPort(ByVal OfficeCd As String, ByVal LocCtryCD As String, ByVal REF_NO As String, ByVal BlType As BlTypes, ByVal PolCd As String, ByVal PodCd As String, Optional ByVal bound As ValueType = ValueType.ImExPort) As String
        Dim dsRet As DataSet = Nothing
        Dim ReturnValue As String = ""
        Dim BoundType As String = ""
        Dim BlTypeValue As String = ""
        Dim RetrunValue As String = ""
        Select Case bound
            Case ValueType.Authority
                BoundType = "AUTH"
            Case ValueType.ImExPort
                BoundType = "BOUND"
        End Select
        If REF_NO <> "" Then
            Select Case BlType
                Case BlTypes.M
                    BlTypeValue = "M"
                Case BlTypes.H
                    BlTypeValue = "H"
            End Select
        End If

        Dim params As Object = {OfficeCd, LocCtryCD, REF_NO, BlTypeValue, PolCd, PodCd}
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Common", "GetBound", params)
            Dim RtDr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
            RetrunValue = RtDr("BOUND")
        Catch ex As Exception
            RetrunValue = ex.Message
        End Try
        Return RetrunValue

    End Function

    Public Function GetGroupCustInfo(ByVal GroupCustCD As String) As DataTable
        Dim dsRet As DataSet
        Dim dt As DataTable = Nothing
        Dim params As Object = {GroupCustCD}
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Common", "GroupCustInfo", params)
            If dsRet.Tables.Contains("Data.CustomersInfo") Then
                dt = dsRet.Tables("Data.CustomersInfo").Copy
                dt.TableName = "CustomersInfo"
            End If
        Catch ex As Exception

        End Try
        Return dt
    End Function

    Public Function GetCustPicInfo(ByVal CustCode As String, ByVal DeptCode As String) As DataTable
        Dim dsRet As DataSet
        Dim dt As DataTable = Nothing
        Dim params As Object = {CustCode, DeptCode}
        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Common", "CustPicInfo", params)
            If dsRet.Tables.Contains("Data.CustPicInfo") Then
                dt = dsRet.Tables("Data.CustPicInfo").Copy
                dt.TableName = "CustPicInfo"
            End If
        Catch ex As Exception

        End Try
        Return dt
    End Function


#Region "===================  TopText ========="

    ' 화면 상단의 text를 가져오는 함수 
    Public Function TopText(ByVal palAutoButton As DevExpress.XtraEditors.PanelControl) As String
        Dim ReturnString As String = ""
        If palAutoButton.Name.ToUpper <> "palAutoButton".ToUpper Then Return ReturnString
        For Each Control In palAutoButton.Controls
            If Control.GetType.FullName = "YJIT.SC.UI.SCControls.Label" _
                AndAlso Control.name = "" Then
                ReturnString = Control.text
                Exit For
            End If
        Next
        Return ReturnString
    End Function

    ' 화면 상단의 text를 변경 하는 함수
    Public Sub TopText(ByVal palAutoButton As DevExpress.XtraEditors.PanelControl, ByVal Text As String, Optional ByVal ReqSvc As String = Nothing)
        If palAutoButton.Name.ToUpper <> "palAutoButton".ToUpper Then Exit Sub
        For Each Control In palAutoButton.Controls
            If Control.GetType.FullName = "YJIT.SC.UI.SCControls.Label" _
                AndAlso Control.name = "" Then

                CType(Control, YJIT.SC.UI.SCControls.Label).Text = Text
                Dim TempObj As New YJIT.SC.UI.SCControls.Label
                If ReqSvc = "AIR" Then
                    CType(Control, YJIT.SC.UI.SCControls.Label).ForeColor = Drawing.Color.DarkBlue
                End If

                Exit For
            End If
        Next
    End Sub

#End Region

    Public Function NumbericFomat(ByVal value As Double, Optional ByVal Point As Integer = 0, Optional ByVal InvalidMsg As Boolean = False) As String
        Dim NewStr As String = 0
        Dim FormatStr As String = "###,##0"
        'format 을 사용하면 자동으로 반올림하게 되어서 원하는 자리수 이후에 5만큼 뺴쭘
        Dim TempValue As Double = 5 / Math.Pow(10, Point + 1)
        If Point > 0 Then
            FormatStr &= "."
            For i = 1 To Point
                FormatStr &= "0"
            Next
        End If
        Try
            If value <> 0 Then
                NewStr = (value - TempValue).ToString(FormatStr)
            End If

        Catch ex As Exception
            If InvalidMsg Then
                MsgBoxSC("Invalid Data  : " & value.ToString)
            End If
            NewStr = ""
        End Try
        Return NewStr
    End Function

    Public Function ValidateMrn(ByVal Mrn As String) As Boolean
        Dim result As Integer = 0
        Dim Check_Digit As Integer = 0
        Dim Temp As String = ""
        Try

            If Len(Mrn) <> 11 Then Return False

            Temp = Mrn.Substring(0, 10)
            Check_Digit = Mrn.Substring(10, 1)

            result = 0
            If Len(Temp) <> 10 Then Return False


            result = (Asc(Mid(Temp, 1, 1)) * 3) Mod 10
            result = (Asc(Mid(Temp, 2, 1)) * 7) Mod 10 + result
            result = (Asc(Mid(Temp, 3, 1)) * 9) Mod 10 + result
            result = (Asc(Mid(Temp, 4, 1)) * 3) Mod 10 + result
            result = (Asc(Mid(Temp, 5, 1)) * 7) Mod 10 + result
            result = (Asc(Mid(Temp, 6, 1)) * 9) Mod 10 + result
            result = (Asc(Mid(Temp, 7, 1)) * 3) Mod 10 + result
            result = (Asc(Mid(Temp, 8, 1)) * 7) Mod 10 + result
            result = (Asc(Mid(Temp, 9, 1)) * 9) Mod 10 + result
            result = (Asc(Mid(Temp, 10, 1)) * 3) Mod 10 + result

            If Check_Digit = result Mod 10 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try


    End Function


#Region "===================  Report  Fucntion ========="
    'Get Report File  Path
    Public Function GetSubRptFilePath(ByVal FileName As String)
        Return GetRptFilePath("", FileName, True)
    End Function
    Public Function GetRptFilePath(ByVal ReqSvc As String, ByVal FileName As String)
        Return GetRptFilePath(ReqSvc, FileName, False)
    End Function

    Private Function GetRptFilePath(ByVal ReqSvc As String, ByVal FileName As String, ByVal SubRpt As Boolean) As String
        '이병호.
        '리포트 파일 찾는 순서
        '각 폴더마다 국가별->일반 리포트를 찾음. ex) 국가코드 KR  :ArrivalNotice_KR.repx 찾은 후 없으면 ArrivalNotice.repx을 찾음
        '최하위 부터 세관코드 -> 도메인 -> 업무  찾아 검색 함  
        '
        Dim StandardPath As String = Common.ReportPath
        Dim FullPath As String = ""
        Dim ReqSvcFolder As String = ""
        Dim DomainFolder As String = ""
        Dim CustomsCodeFolder As String = ""
        Dim ReportFileName As String = FileName
        Dim CountryReportFileName As String = FileName
        Dim Country As String = ClientSessionOfficeInfo.CountryCode
        'CountryReportFileName 국가별 리포트도 한번 더 찾기 위한 변수 
        If Trim(ClientSessionOfficeInfo.CountryCode) <> "" Then
            CountryReportFileName = FileName.Substring(0, FileName.LastIndexOf(".")) & "_" & Country & FileName.Remove(0, FileName.LastIndexOf("."))
        End If
        '업무 구분
        If Trim(ReqSvc) <> "" Then ReqSvcFolder = ReqSvc & "\"
        '도메인 구분
        If Trim(Common.SavedSessionDomain) <> "" Then DomainFolder = Common.SavedSessionDomain & "\"
        '세관 코드 구분
        If Trim(ClientSessionOfficeInfo.CustomsCode) <> "" Then CustomsCodeFolder = ClientSessionOfficeInfo.CustomsCode & "\"

        If SubRpt = True Then
            'sub report
            StandardPath = StandardPath & "SubRpt\"

        ElseIf SubRpt = False Then
            'header report
            StandardPath = StandardPath & ReqSvcFolder
        End If
        ' 최초 찾는 경로 FullPath
        FullPath = StandardPath & DomainFolder & CustomsCodeFolder '  & ReportFileName

        '경로 정리 마지막에  \ 지움
        If StandardPath.EndsWith("\") Then
            StandardPath = StandardPath.Substring(0, StandardPath.Length - 1)
        End If
        If FullPath.EndsWith("\") Then
            FullPath = FullPath.Substring(0, FullPath.Length - 1)
        End If


        Dim FileNames() As String = {CountryReportFileName, ReportFileName}
        '최하위 폴더에서 상위 폴더로 찾아감

        Do While True
            For i = 0 To FileNames.Length - 1

                If FileIO.FileSystem.FileExists(FullPath & "\" & FileNames(i)) Then
                    FullPath = FullPath & "\" & FileNames(i)
                    Exit Do
                Else
                    '기본 경로까지 찾아보고 없으면 기본 값을 반환
                    If StandardPath = FullPath And i = 0 AndAlso FileNames.Length - 1 Then
                        FullPath = StandardPath & "\" & ReportFileName
                        Exit Do
                    End If
                End If
            Next
            FullPath = FullPath.Substring(0, FullPath.LastIndexOf("\"))

        Loop

        Return FullPath
    End Function

    'rpt 기본적인 리포트 셋팅을 하는 펑션
    'ex) Newelvis\YJIT.SC.FMS\RPT\ACT\ActTrialBalance.repx  호출시
    'reqsvc : ACT
    'FileName : ActTrialBalance
    'DataSource : data
    'RptParameters : Parameters
    'OtherPathUse
    'RequestParameters
    Public Function RptBaseSetting(ByVal ReqSvc As String, ByVal FileName As String, ByVal DataSource As DataSet, _
                                         Optional ByVal RptParameters As Dictionary(Of String, Object) = Nothing, _
                                         Optional ByVal OtherPathUse As Boolean = False, _
                                         Optional ByVal RequestParameters As Boolean = False) As DevExpress.XtraReports.UI.XtraReport

        Dim DomainFolder As String = ""
        Dim CustomsCodeFolder As String = ""
        Dim FullPath As String = ""
        Dim Rpt As New DevExpress.XtraReports.UI.XtraReport

        Try
            If Trim(FileName) = "" Then Throw New Exception("Report File Not Found.")
            If Trim(Common.SavedSessionDomain) <> "" Then DomainFolder = Common.SavedSessionDomain & "\"
            If Trim(ClientSessionOfficeInfo.CustomsCode) <> "" Then CustomsCodeFolder = ClientSessionOfficeInfo.CustomsCode & "\"

            FullPath = GetRptFilePath(ReqSvc, FileName)
            Rpt.LoadLayout(FullPath)
            If Not RptParameters Is Nothing Then
                For Each key In RptParameters.Keys
                    Try
                        Rpt.Parameters(key).Value = RptParameters(key)
                    Catch ex As Exception
                    End Try
                Next
            End If

            'Image Control Find

            Dim ImageList() As String = {"Logo", "TAX_STAMP", "SIGN"}

            For Each ImageType As String In ImageList
                Dim obj As Object = Rpt.FindControl(ImageType, True)
                If Not obj Is Nothing Then
                    If obj.GetType.FullName = "DevExpress.XtraReports.UI.XRPictureBox" Then
                        Try
                            Dim OfficeImagePath As String = Common.ReportPath & "Image\" & DomainFolder & CustomsCodeFolder
                            Dim ImageFullPath As String = OfficeImagePath & ImageType & ".jpg"
                            'custom 폴더에 이미지가 없으면 상위 폴더를 찾음
                            If Not FileIO.FileSystem.FileExists(ImageFullPath) Then
                                ImageFullPath = Common.ReportPath & "Image\" & DomainFolder & ImageType & ".jpg"
                            End If

                            If ImageType = "Logo" Then

                                'Wide형 로고 사용시 디자인 변경 (CAFTHQ,NETL,JEFE,HFBC,WLKL,GLBX)
                                If ClientSessionOfficeInfo.LogoType = "B" Or ClientSessionOfficeInfo.LogoType = "C" Then
                                    Dim obj2 As Object = Rpt.FindControl("CO_NM", True)
                                    Dim obj3 As Object = Rpt.FindControl("CO_ADDR", True)
                                    If Not obj2 Is Nothing Then
                                        CType(obj, DevExpress.XtraReports.UI.XRPictureBox).WidthF = 100
                                        If ClientSessionOfficeInfo.LogoType = "B" Then
                                            CType(obj2, DevExpress.XtraReports.UI.XRLabel).Visible = True
                                        Else
                                            CType(obj2, DevExpress.XtraReports.UI.XRLabel).Visible = False
                                        End If

                                        If ClientSessionOfficeInfo.LogoType = "B" Then
                                            Dim yPos2 As Integer = obj2.Location.Y
                                            CType(obj2, DevExpress.XtraReports.UI.XRLabel).LocationF = New System.Drawing.Point(110, yPos2)
                                            CType(obj2, DevExpress.XtraReports.UI.XRLabel).WidthF = 670
                                        End If

                                        Dim yPos3 As Integer = obj3.Location.Y
                                        CType(obj3, DevExpress.XtraReports.UI.XRLabel).LocationF = New System.Drawing.Point(110, yPos3)
                                        CType(obj3, DevExpress.XtraReports.UI.XRLabel).WidthF = 670

                                    End If
                                End If

                            End If

                            CType(obj, DevExpress.XtraReports.UI.XRPictureBox).ImageUrl = ImageFullPath
                        Catch ex As Exception

                        End Try

                    End If
                End If
            Next

            If RequestParameters = False Then
                Rpt.RequestParameters = False
            End If
            Rpt.DataSource = AdaptDataSourceForReport(DataSource)
            If ClientSessionInfo.OfficeCode = "LOGI" Then
                Rpt.ExportOptions.Pdf.ImageQuality = DevExpress.XtraPrinting.PdfJpegImageQuality.Lowest
            Else
                Rpt.ExportOptions.Pdf.ImageQuality = DevExpress.XtraPrinting.PdfJpegImageQuality.Low
            End If

            Rpt.ShowPrintMarginsWarning = False
            Rpt.ShowPreviewMarginLines = True
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Rpt = Nothing
        End Try
        Return Rpt
    End Function

    'report에 Parameters를 너을 때 해당 리포트에 Parameters가 없을 시 에러발생을 제외 시키는 펑션
    Public Function TryRptParam(ByVal rpt As DevExpress.XtraReports.UI.XtraReport, ByVal RptParameters As Dictionary(Of String, Object)) As DevExpress.XtraReports.UI.XtraReport
        Dim newRpt As DevExpress.XtraReports.UI.XtraReport
        newRpt = rpt
        If Not RptParameters Is Nothing Then
            For Each key In RptParameters.Keys
                Try
                    rpt.Parameters(key).Value = RptParameters(key)
                Catch ex As Exception
                End Try
            Next
        End If
        Return rpt
    End Function

#End Region

    'DrawRowIndicator
#Region "==================    DrawRowIndicator  ===================================="
    'DrawRowIndicator
    'grid 왼쪽 빈 셀에 row count를 그려주는 함수
    ' load, shown 에서  DrawRowIndicator(gv1) , DrawRowIndicator({gv1,gv2}) 사용하면됨
    Public Sub DrawRowIndicator(ByVal GirdView As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal OutputBand As Boolean = False)
        GirdView.OptionsView.ColumnAutoWidth = False
        GirdView.IndicatorWidth = 40
        AddHandler GirdView.CustomDrawRowIndicator, AddressOf GV_CustomDrawRowIndicator
    End Sub

    Public Sub DrawRowIndicator(ByVal GirdView() As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal OutputBand As Boolean = False)
        For Each gv In GirdView
            gv.OptionsView.ColumnAutoWidth = False
            gv.IndicatorWidth = 40
            AddHandler gv.CustomDrawRowIndicator, AddressOf GV_CustomDrawRowIndicator
        Next
    End Sub

#End Region


    Public Sub GV_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)

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
    Public Function DeleteFile(ByVal Directory As String, ByVal Filenm As String) As String
        Dim TrxCode As String = "N"
        Try
            If IO.Directory.Exists(Directory) = False Then
                IO.Directory.CreateDirectory(Directory)
            Else
                ' Dim fList As String() = IO.Directory.GetFiles(Directory, "*.*")
                Dim fList As String() = IO.Directory.GetFiles(Directory, "*.*")
                For Each f As String In fList
                    If f = Filenm Then
                        File.Delete(f)
                    End If
                Next
            End If
            TrxCode = "Y"
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return TrxCode
    End Function

    Public Function DeleteFiles(ByVal Directory As String) As String
        Dim TrxCode As String = "N"
        Try
            If IO.Directory.Exists(Directory) Then
                IO.Directory.CreateDirectory(Directory)
            Else
                Dim fList As String() = IO.Directory.GetFiles(Directory, "*.*")
                For Each f As String In fList
                    File.Delete(f)
                Next
            End If
            TrxCode = "Y"
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return TrxCode
    End Function

    'popup base 에서 사용되는 데이터 param의 기본 유형
    Public Function GetPopupBaseParam(ByVal Key As String, Optional ByVal Sender As String = "", Optional ByVal Action As Action = Action.Other) As DataRow
        Dim dt As New DataTable
        dt.Columns.Add("Key")
        dt.Columns.Add("Sender")
        dt.Columns.Add("Action", GetType(Action))
        dt.Rows.Add(Key, Sender, Action)

        Return dt.Rows(0)
    End Function

#Region "==================    GetLayoutList  ===================================="
    'GetLayoutList
    '그리드 레이아웃을 db에 저장한 리스트를 가져오는 펑션
    'GetLayoutList( office code , 화면명(화면 class명)  )
    Public Function GetLayoutList(ByVal OfficeCd As String, ByVal FormId As String) As DataTable
        Dim params As Object = {OfficeCd, FormId}
        Dim ds As DataSet
        Dim dt As DataTable
        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Common", "GetLayoutList", params)
            dt = ds.Tables("Data.List").Copy
        Catch ex As Exception
            dt = Nothing
        End Try
        Return dt
    End Function

    '그리드 레이아웃을 db에 저장한 레이아웃을 가져오는 펑션
    'GetLayoutList( office code , 화면명(화면 class명) ,  layout명 ) 
    Public Function GetLayout(ByVal OfficeCd As String, ByVal FormId As String, ByVal LayoutName As String) As DataSet
        Dim params As Object = {OfficeCd, FormId, LayoutName}
        Dim ds As DataSet
        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Common", "GetLayout", params)
            ds = AdaptDataSourceForReport(ds)
        Catch ex As Exception
            ds = Nothing
        End Try
        Return ds
    End Function
#End Region


    Public Function GetOfficeConfig(ByVal OfficeCd As String, ByVal Item As String) As DataSet
        Dim ds As DataSet

        'Item
        ' - SeaMfcsVendor : SEA 적하목록 전송 Vendor -> return (KTNET,KLNET,KCNET,TAXON)
        '

        Dim params As Object = {OfficeCd, Item}
        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.Common", "GetOfficeConfig", params)
        Catch ex As Exception
            ds = Nothing
        End Try
        Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        Return ds


    End Function

    'GridValidateCode
    '그리드에 셋팅된 codebox에서 validate 기능을 제공 하는 함수. 
    Public Sub GridValidateCode(ByVal Grid As Object, ByVal FieldNames() As String)
        Dim ErrorMsg As String = ""
        For Each FieldName In FieldNames
            Try
                Dim Column As Object = GetGridColumn(Grid, FieldName)
                If Column Is Nothing Then
                    ErrorMsg &= FieldName & vbCrLf
                    Continue For
                End If
                Grid.FocusedColumn = Column
                Grid.ShowEditor()
                CType(Grid.ActiveEditor, Object).ValidateCode()
            Catch ex As Exception
                ErrorMsg &= ex.Message & vbCrLf
            End Try
        Next
        If ErrorMsg <> "" Then
            ErrorMsg = "Not Exist Column" & vbCrLf & ErrorMsg
            ErrorMsg.Substring(0, ErrorMsg.Length - 2)
            DevExpress.XtraEditors.XtraMessageBox.Show(ErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'MiddleWare
    Public Function MethodCallEx(ByRef FormObj As Object, ByRef controllerID As String, ByRef actionID As String, ByRef dsParams As DataSet) As DataSet
        Dim CurrentCursor As Cursor = FormObj.Cursor
        Try
            FormObj.Cursor = Cursors.WaitCursor
            Return YJIT.SC.WCF.WCFBiz.Instance.MethodCall(controllerID, actionID, dsParams)
        Catch ex As Exception
            FormObj.Cursor = Cursors.Default
            Throw New Exception(ex.Message & " (MethodCallEx)")
        Finally
            If CurrentCursor = Cursors.WaitCursor Then
                FormObj.Cursor = CurrentCursor
            Else
                FormObj.Cursor = Cursors.Default
            End If
        End Try
    End Function

    'MiddleWare
    Public Function MethodCallEx(ByRef FormObj As Object, ByRef controllerID As String, ByRef actionID As String, ByRef aParams() As Object) As DataSet
        Dim CurrentCursor As Cursor = FormObj.Cursor
        Try
            FormObj.Cursor = Cursors.WaitCursor
            Return YJIT.SC.WCF.WCFBiz.Instance.MethodCall(controllerID, actionID, aParams)
        Catch ex As Exception
            FormObj.Cursor = Cursors.Default
            Throw New Exception(ex.Message & " (MethodCallEx)")
        Finally
            If CurrentCursor = Cursors.WaitCursor Then
                FormObj.Cursor = CurrentCursor
            Else
                FormObj.Cursor = Cursors.Default
            End If
        End Try
    End Function


#Region "==================    SaveControlValues  ===================================="

    ' 화면에 있는 컨트롤의 값들을 로컬에 저장 시키는 함수( 기본값 셋팅에 사용 )
    '사용 법 
    ' event-> Shown -> SaveControlValues( me , {cust_cd,eta})
    Public Sub SaveControlValues(ByVal mForm As Object, ByVal Controls() As Control)
        If ContorolsValueDic Is Nothing Then
            ContorolsValueDic = New Dictionary(Of String, Object)
        End If
        ContorolsValueDic(mForm.Name) = Controls
        Form_Shown(mForm)
        AddHandler CType(mForm, YJIT.SC.UI.SCView).FormClosing, AddressOf Form_Closing
    End Sub

    Private Sub Form_Shown(ByVal sender As Object)
        If ContorolsValueDic.ContainsKey(sender.Name) Then
            Dim Controls() As Control = ContorolsValueDic(sender.Name)

            For Each Cntr In Controls
                Dim CntrName As String = Cntr.Name
                Dim FormName As String = sender.Name
                Dim ValueString As String = ReadIniValue(AppValuesPath, FormName, CntrName)

                If ValueString = "" AndAlso Cntr.GetType <> GetType(YJIT.SC.UI.SCControls.WebGrid) Then
                    Continue For
                End If
                Select Case Cntr.GetType
                    Case GetType(YJIT.SC.UI.SCControls.CheckBox)
                        Dim DefualtValue As Boolean = False
                        Try
                            DefualtValue = CBool(ValueString)
                        Catch ex As Exception
                        End Try
                        CType(Cntr, YJIT.SC.UI.SCControls.CheckBox).Checked = DefualtValue
                    Case GetType(YJIT.SC.UI.SCControls.ComboBox)
                        If CType(Cntr, YJIT.SC.UI.SCControls.ComboBox).ComboItemLoadingMode = UI.ComboBoxItemLoadingModes.Synchronous Then
                            CType(Cntr, YJIT.SC.UI.SCControls.ComboBox).SelectedValue = ValueString
                            CType(Cntr, YJIT.SC.UI.SCControls.ComboBox).DefVal = ValueString
                        ElseIf CType(Cntr, YJIT.SC.UI.SCControls.ComboBox).ComboItemLoadingMode = UI.ComboBoxItemLoadingModes.Asynchronous Then
                            CType(Cntr, YJIT.SC.UI.SCControls.ComboBox).SelectedValue = ValueString
                            CType(Cntr, YJIT.SC.UI.SCControls.ComboBox).DefVal = ValueString
                        End If
                    Case GetType(YJIT.SC.UI.SCControls.TextBox)
                        CType(Cntr, YJIT.SC.UI.SCControls.TextBox).Text = ValueString
                    Case GetType(YJIT.SC.UI.SCControls.DateBox)
                        CType(Cntr, YJIT.SC.UI.SCControls.DateBox).Text = ValueString
                    Case GetType(YJIT.SC.UI.SCControls.CodeBox)
                        CType(Cntr, YJIT.SC.UI.SCControls.CodeBox).Text = ValueString
                    Case GetType(YJIT.SC.UI.SCControls.TextLabel)
                        CType(Cntr, YJIT.SC.UI.SCControls.TextLabel).Text = ValueString
                    Case GetType(DevExpress.XtraEditors.CheckedComboBoxEdit)
                        CType(Cntr, DevExpress.XtraEditors.CheckedComboBoxEdit).EditValue = ValueString
                    Case GetType(YJIT.SC.UI.SCControls.WebGrid)
                        LoadGridValue(FormName, Cntr)
                End Select

            Next
        End If
    End Sub

    Private Sub LoadGridValue(ByVal FormName As String, ByVal WG As YJIT.SC.UI.SCControls.WebGrid)
        Dim Gv As Object = CType(WG, YJIT.SC.UI.SCControls.WebGrid).MainView()
        Dim GvName As String = Gv.Name

        '  Dim gv2 As DevExpress.XtraGrid.Views.Grid.GridView = WG.MainView
        Dim Key1 As String = (GvName & "_KeyCode").ToString.ToUpper
        Dim Key2 As String = (GvName & "_KeyValue").ToString.ToUpper

        Dim KeyField As String = ""
        Dim ValueField As String = ""
        For Each Col In Gv.Columns
            Dim CheckKey As String = (Col.Name).ToString.ToUpper
            If Key1 = CheckKey Then
                KeyField = Col.FieldName
            End If
            If Key2 = CheckKey Then
                ValueField = Col.FieldName
            End If
        Next
        If KeyField = "" Or ValueField = "" Then
            Exit Sub
        End If

        For i = 0 To Gv.RowCount - 1
            Dim CreateKey As String = GvName & "_" & Gv.GetRowCellValue(i, KeyField).ToString
            Dim GetValue As String = ReadIniValue(AppValuesPath, FormName, CreateKey)
            If GetValue = "" Then Continue For
            Gv.SetRowCellValue(i, ValueField, GetValue)
        Next


        'Select Case gview.GetType.FullName
        '    Case "DevExpress.XtraGrid.Views.Grid.GridView"
        '        Gv = m_OnlyControl.MainView
        '        Gv.FocusedColumn = Gv.Columns(m_AddFirstFocusColumn)
        '    Case "DevExpress.XtraGrid.Views.BandedGrid.BandedGridView"
        '        Bgv = m_OnlyControl.MainView
        '        Bgv.FocusedColumn = Bgv.Columns(m_AddFirstFocusColumn)
        '    Case "DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView"
        '        Agv = m_OnlyControl.MainView
        '        Agv.FocusedColumn = Agv.Columns(m_AddFirstFocusColumn)
        'End Select

    End Sub
    Public Sub Form_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        If ContorolsValueDic.ContainsKey(sender.Name) Then
            Dim Controls() As Control = ContorolsValueDic(sender.Name)

            For Each Cntr In Controls
                Dim CntrName As String = Cntr.Name
                Dim FormName As String = sender.Name
                Dim ValueString As Object = ""

                Select Case Cntr.GetType
                    Case GetType(DevExpress.XtraEditors.CheckedComboBoxEdit)
                        ValueString = CType(Cntr, DevExpress.XtraEditors.CheckedComboBoxEdit).EditValue
                    Case GetType(YJIT.SC.UI.SCControls.CheckBox)
                        ValueString = CType(Cntr, YJIT.SC.UI.SCControls.CheckBox).Checked.ToString
                    Case GetType(YJIT.SC.UI.SCControls.ComboBox)
                        ' 2014-7-10 이재민 SelectValue 값이 없을 경우에 Form Closing시 Error 발생처리 
                        If CType(Cntr, YJIT.SC.UI.SCControls.ComboBox).Text <> "" Then
                            ValueString = CType(Cntr, YJIT.SC.UI.SCControls.ComboBox).SelectedValue.ToString
                        End If
                    Case GetType(YJIT.SC.UI.SCControls.TextBox)
                        ValueString = CType(Cntr, YJIT.SC.UI.SCControls.TextBox).Text
                    Case GetType(YJIT.SC.UI.SCControls.DateBox)
                        ValueString = CType(Cntr, YJIT.SC.UI.SCControls.DateBox).Text
                    Case GetType(YJIT.SC.UI.SCControls.CodeBox)
                        ValueString = CType(Cntr, YJIT.SC.UI.SCControls.CodeBox).Text
                    Case GetType(YJIT.SC.UI.SCControls.TextLabel)
                        ValueString = CType(Cntr, YJIT.SC.UI.SCControls.TextLabel).Text
                    Case GetType(YJIT.SC.UI.SCControls.WebGrid)
                        SaveGridValue(FormName, Cntr)
                        Continue For
                End Select

                WriteIniValue(AppValuesPath, FormName, CntrName, ValueString)

            Next
        End If

    End Sub
    Private Sub SaveGridValue(ByVal FormName As String, ByVal WG As YJIT.SC.UI.SCControls.WebGrid)
        Dim Gv As Object = CType(WG, YJIT.SC.UI.SCControls.WebGrid).MainView()
        Dim GvName As String = Gv.Name

        Dim gv2 As DevExpress.XtraGrid.Views.Grid.GridView = WG.MainView
        Dim Key1 As String = (GvName & "_KeyCode").ToString.ToUpper
        Dim Key2 As String = (GvName & "_KeyValue").ToString.ToUpper
        Gv.FocusedRowHandle = -200000
        Dim KeyField As String = ""
        Dim ValueField As String = ""
        For Each Col In Gv.Columns
            Dim CheckKey As String = (Col.Name).ToString.ToUpper
            If Key1 = CheckKey Then
                KeyField = Col.FieldName
            End If
            If Key2 = CheckKey Then
                ValueField = Col.FieldName
            End If
        Next
        If KeyField = "" Or ValueField = "" Then
            Exit Sub
        End If

        For i = 0 To Gv.RowCount - 1
            Dim CreateKey As String = GvName & "_" & Gv.GetRowCellValue(i, KeyField).ToString
            Dim GetValue As String = Gv.GetRowCellValue(i, ValueField)
            If GetValue = "" Then Continue For
            WriteIniValue(AppValuesPath, FormName, CreateKey, GetValue)
        Next
    End Sub

    Public Function GetOfficeFormId(ByVal SrcId As String) As String
        Dim returnId As String = SrcId


        If SrcId.ToUpper = "ActBuyTaxMgt".ToUpper Then
            Select Case ClientSessionOfficeInfo.HqOfficeCode
                Case "ECOHQ", "ATCHQ", "ECLHQ"
                    returnId = "ActBuyTaxMgt"
                Case Else
                    returnId = "ActBuyTaxMgt_v1"
            End Select
            'If ClientSessionOfficeInfo.HqOfficeCode = "ECOHQ" OrElse ClientSessionOfficeInfo.HqOfficeCode = "ATCHQ" Then

            '    returnId = "ActBuyTaxMgt"
            'Else
            '    returnId = "ActBuyTaxMgt_v1"
            'End If
        End If


        'If ClientSessionOfficeInfo.HqOfficeCode = "ENCHQ" Then
        '    Select Case SrcId.ToUpper
        '        Case "AirHawbMgt".ToUpper
        '            returnId = "AirHawbMgt_v1"
        '        Case "AirMawbMgt".ToUpper
        '            returnId = "AirMawbMgt_v1"
        '        Case "SeaHouseMgt".ToUpper
        '            returnId = "SeaHouseMgt_v1"
        '        Case "SeaMasterMgt".ToUpper
        '            returnId = "SeaMasterMgt_v1"
        '        Case "AirAwbPrint".ToUpper
        '            returnId = "AirAwbPrint_v1"
        '        Case "SeaHousePrint".ToUpper
        '            returnId = "SeaHousePrint_v1"
        '        Case "SeaHouseList".ToUpper
        '            returnId = "SeaHouseList_v1"
        '        Case "AirHawbList".ToUpper
        '            returnId = "AirHawbList_v1"
        '        Case "ActMonthClosing".ToUpper
        '            returnId = "ActMonthClosing_v1"
        '        Case "OmsJobList".ToUpper
        '            returnId = "OmsJobList_v1"
        '    End Select
        If ClientSessionOfficeInfo.HqOfficeCode = "ECLHQ" Then
            Select Case SrcId.ToUpper
                Case "AirHawbMgt".ToUpper
                    returnId = "AirHawbMgt_v1"
                Case "AirMawbMgt".ToUpper
                    returnId = "AirMawbMgt_v1"
                Case "SeaHouseMgt".ToUpper
                    returnId = "SeaHouseMgt_v1"
                Case "SeaMasterMgt".ToUpper
                    returnId = "SeaMasterMgt_v1"
                Case "AirAwbPrint".ToUpper
                    returnId = "AirAwbPrint_v1"
                Case "SeaHousePrint".ToUpper
                    returnId = "SeaHousePrint_v1"
                Case "SeaHouseList".ToUpper
                    returnId = "SeaHouseList_v1"
                Case "AirHawbList".ToUpper
                    returnId = "AirHawbList_v1"
                Case "ActMonthClosing".ToUpper
                    returnId = "ActMonthClosing_v1"
            End Select
        End If
        If ClientSessionOfficeInfo.HqOfficeCode = "ECOAQ" Or ClientSessionOfficeInfo.HqOfficeCode = "LOHQ" Or ClientSessionOfficeInfo.HqOfficeCode = "ATCHQ" Then
            Select Case SrcId.ToUpper
                Case "AirHawbMgt".ToUpper
                    returnId = "AirHawbMgt_v1"
                Case "AirHawbList".ToUpper
                    returnId = "AirHawbList_v1"
            End Select
        End If

        ' FormConvert.dat  파일을 이용하여 적용 방법
        Select Case ClientSessionOfficeInfo.HqOfficeCode
            Case "LOEXHQ", "KCTCHQ", "ENCHQ"
                returnId = ReadIniValue(FormConvertPath, ClientSessionOfficeInfo.HqOfficeCode, SrcId.ToUpper)
        End Select

        If returnId = "" Then returnId = SrcId

        Return returnId

    End Function


#End Region

#Region "==================  EnableControls ======================="
    '배열 값으로 받은 컨트롤 들을 enable true ,false 를 한꺼번에 처리
    '사용법은 clearView 랑 동일
    'SetEnableControl(UI.AppliedRangeTypes.Only,{control},True}
    ' param = 1 적용 범위, 2 컨트롤 배열, 셋팅할 값
    Public Sub EnableControls(ByVal AppliedRangeType As YJIT.SC.UI.AppliedRangeTypes, Optional ByVal DefualtValue As Boolean = True)
        SetEnableControl(AppliedRangeType, {}, DefualtValue)

    End Sub

    Public Sub EnableControls(ByVal AppliedRangeType As YJIT.SC.UI.AppliedRangeTypes, ByVal CntlList() As Control, Optional ByVal DefualtValue As Boolean = True)
        SetEnableControl(AppliedRangeType, CntlList, DefualtValue)
    End Sub

    Private Sub SetEnableControl(ByVal AppliedRangeType As YJIT.SC.UI.AppliedRangeTypes, ByVal CntlList() As Control, Optional ByVal DefualtValue As Boolean = True)
        Dim MainForm As Object = IMainForm
        Dim Frm As Object = MainForm.ActiveControl

        Select Case AppliedRangeType
            Case UI.AppliedRangeTypes.All
                ChangeEnableControls(AppliedRangeType, Frm.controls, DefualtValue)
            Case UI.AppliedRangeTypes.Except

                ChangeEnableControls(AppliedRangeType, Frm.controls, DefualtValue, CntlList)
            Case UI.AppliedRangeTypes.Only
                For Each cntl As Object In CntlList
                    Try
                        cntl.Enabled = DefualtValue
                    Catch ex As Exception
                    End Try
                Next
        End Select
    End Sub

    Private Sub ChangeEnableControls(ByVal AppliedRangeType As YJIT.SC.UI.AppliedRangeTypes, ByVal controls As Control.ControlCollection, ByVal DefualtValue As Boolean, Optional ByVal ExceptionCntl() As Control = Nothing)
        For Each ObjCntl In controls
            If ObjCntl.Name <> "palAutoButton" Then
                Dim cntl As Control = CType(ObjCntl, Control)
                If Not ExptionControls(cntl.GetType.FullName) Then
                    If YJIT.SC.UI.AppliedRangeTypes.Except = AppliedRangeType Then
                        Dim Exist As Boolean = False
                        For Each excepcntl In ExceptionCntl
                            If Control.ReferenceEquals(cntl, excepcntl) Then
                                Exist = True
                                Continue For
                            End If
                        Next
                        If Exist Then
                            Continue For
                        End If
                    End If
                    cntl.Enabled = DefualtValue
                End If
                Try
                    ChangeEnableControls(AppliedRangeType, cntl.Controls, DefualtValue, ExceptionCntl)
                Catch ex As Exception

                End Try
            End If
        Next
    End Sub

    Private Function ExptionControls(ByVal TypeFullName As String) As Boolean
        Dim ExceptionName() As String = {"TAB", "PANEL", "CONTAINER", "LABEL", "GROUPCONTROL"}
        For Each Names In ExceptionName
            If TypeFullName.ToUpper.Contains(Names) Then
                Return True
            End If
        Next
        Return False
    End Function

    'PanelControl or GroupControl 안에 속해있는 Control 들만 Clear
    'ClearControls(panelcontrol1), ClearControls({panelcontrol1,panelcontrol2})
    'param : 해당 PanelControl or GroupControl
    Public Sub ClearControls(ByVal objs() As Object)
        For Each obj In objs
            Call setClearControls(obj)
        Next
    End Sub
    Public Sub ClearControls(ByVal obj As Object)
        Call setClearControls(obj)
    End Sub

    Private Sub setClearControls(ByVal obj As Object)
        Select Case obj.GetType.FullName
            Case "DevExpress.XtraEditors.PanelControl", "DevExpress.XtraEditors.GroupControl"
                For Each Control As Object In obj.Controls
                    ClearControl(Control)
                Next
        End Select
    End Sub

    Private Sub ClearControl(ByVal obj As Object)
        Select Case obj.GetType.FullName
            Case "YJIT.SC.UI.SCControls.CodeBox", "YJIT.SC.UI.SCControls.CodeBoxEdit", _
                "YJIT.SC.UI.SCControls.DateBox", "YJIT.SC.UI.SCControls.DateBoxEdit", _
                "YJIT.SC.UI.SCControls.MaskedTextBox", "YJIT.SC.UI.SCControls.NumericTextBox", _
                "YJIT.SC.UI.SCControls.TextBox", "YJIT.SC.UI.SCControls.TextLabel", _
                "DevExpress.XtraEditors.MemoExEdit"

                obj.Text = ""
            Case "YJIT.SC.UI.SCControls.ComboBox"
                obj.SelectedValue = ""
                'Case "DevExpress.XtraEditors.PanelControl", "DevExpress.XtraEditors.GroupControl"
                '    setClearControls(obj)
        End Select
    End Sub

    Public Sub setReadOnlyControls(ByRef ctrlList() As Object, ByVal defVal As Boolean)

        For Each ctrl As Object In ctrlList
            Try
                Select Case ctrl.GetType.FullName
                    Case "YJIT.SC.UI.SCControls.ComboBox"
                        ctrl.Enabled = IIf(defVal, False, True)
                    Case Else
                        ctrl.ReadOnly = defVal
                        If defVal Then
                            ctrl.BackColor = SystemColors.Control
                        Else
                            ctrl.BackColor = SystemColors.Window
                        End If
                End Select

            Catch ex As Exception
            End Try
        Next

    End Sub

#End Region

    '#Region "==========Update at runtime handling (Harry: 20150724)==============="
    '    Public RU_LocalManifestFile As String = "LocalManifest.inf"
    '    Public RU_LocalManifest As New System.Collections.ArrayList                    'Local manifest udpates
    '    Public RU_LogMessage As New System.Text.StringBuilder       'For debuging Runtime Update performance

    '    Private RU_ProgressBar As Object                            'ProgressDialog form
    '    Private RU_CurrentFileURL As String
    '    Private RU_CurrentLocalFilePath As String

    '    ''' <summary>
    '    ''' Runtime update for Module and RPT only
    '    ''' </summary>
    '    ''' <param name="sFileID"></param>
    '    ''' <remarks></remarks>
    '    Public Sub UR_ProcessRuntimeUpdateFile(ByVal sFileID As String)
    '        Dim sbLogText As New System.Text.StringBuilder

    '        'Checking log buffer to avoid memory consuming
    '        If RU_LogMessage.Length > 10000 Then
    '            RU_LogMessage.Clear()
    '            RU_LogMessage.AppendLine(">>BUFFER CLEARED!")
    '        End If

    '        If sFileID.ToUpper.EndsWith(".EXE") Then
    '            RU_LogMessage.Insert(0, ">>Skip Runtime Update to *.Exe file!") 'Avoid update running assembly (.Exe)
    '            Exit Sub
    '        End If

    '        Try
    '            sbLogText.AppendLine(vbNewLine & ">>UPDATE PROCESS START (" & Now.ToString("yyyy-MM-dd HH:mm:ss") & ")")
    '            sbLogText.AppendLine("+Requested File:" & sFileID)

    '            Dim sAppRootPath As String = Application.StartupPath
    '            If Not sAppRootPath.EndsWith("\") Then sAppRootPath &= "\"

    '            Dim sFileURI As String = ""
    '            If sFileID.Contains("\Modules\") Then
    '                sFileURI = sFileID.Substring(sFileID.IndexOf("\Modules\") + 1) 'Path to a module
    '                sFileURI = sFileURI.Replace("\", "/") 'Expecting : "Modules/id.dll"
    '            ElseIf sFileID.Contains("\RPT\") Then
    '                sFileURI = sFileID.Substring(sFileID.IndexOf("\RPT\") + 1) 'Path to a report
    '                sFileURI = sFileURI.Replace("\", "/") 'Expecting: "RPT/ACT/SlipMng01M.repx
    '            End If

    '            sbLogText.AppendLine("+Determined FileURI: " & sFileURI)

    '            '1. Load local manifest if not yet read
    '            If RU_LocalManifest.Count = 0 Then
    '                Call loadLocalManifest()
    '            End If

    '            '2. Locate the sFileURL in local manifest to get update information
    '            Dim sLocalModifiedDtm As String = ""
    '            Dim sServerModifiedDtm As String = ""
    '            Dim dLocalSize As Double = 0
    '            Dim dServerSize As Double = 0
    '            Dim parts() As String

    '            Dim isLocalManifestFound As Boolean = False
    '            Dim nLocalIndex As Integer = 0
    '            For nLocalIndex = 0 To RU_LocalManifest.Count - 1
    '                If RU_LocalManifest(nLocalIndex).StartsWith(sFileURI) Then
    '                    parts = RU_LocalManifest(nLocalIndex).Split(",")
    '                    dLocalSize = CDbl("0" & Trim(parts(1)))
    '                    sLocalModifiedDtm = Trim(parts(2) & "")
    '                    isLocalManifestFound = True
    '                    Exit For
    '                End If
    '            Next
    '            If isLocalManifestFound = False Then
    '                sbLogText.AppendLine("+FileURI could not be located in local manifest!Process cancelled!" & sFileURI)
    '                Exit Sub 'We can not find this in local manifest => not update processing
    '            End If

    '            '3. Request to server Manifest.aspx to get file update info
    '            Dim wc As New System.Net.WebClient
    '            Dim oReader As New StreamReader(wc.OpenRead(Common.AppDeployUrl.Trim & "Manifest.aspx?SingleFileURI=" & sFileURI))
    '            Dim sServerReturn As String = Trim(oReader.ReadLine())  'Expect single line only
    '            oReader.Close()

    '            If sServerReturn.Trim = "" Then
    '                sbLogText.AppendLine("+Manifest server return nothing!" & sFileURI & ".Process cancelled!")
    '                Exit Sub
    '            ElseIf Not sServerReturn.StartsWith(sFileURI) Then
    '                sbLogText.AppendLine("+Manifest server return is not matched![" & sServerReturn & "].Process cancelled!")
    '                Exit Sub
    '            End If
    '            parts = sServerReturn.Split(",")
    '            If parts.Length < 5 Then
    '                sbLogText.AppendLine("+Manifest server return is not well-formed![" & sServerReturn & "].Process cancelled!")
    '                Exit Sub
    '            End If

    '            dServerSize = CDbl("0" & Trim(parts(1)))
    '            sServerModifiedDtm = Trim(parts(2) & "")

    '            '4. Compare the local & server decide to update or not
    '            Dim isLocalFileFound As Boolean = True
    '            Dim sLocalFilePath As String = sAppRootPath & sFileURI.ToString.Replace("/", "\")
    '            If Not IO.Directory.Exists(sLocalFilePath.Substring(0, sLocalFilePath.LastIndexOf("\") + 1)) Then
    '                IO.Directory.CreateDirectory(sLocalFilePath.Substring(0, sLocalFilePath.LastIndexOf("\") + 1)) 'Create path if not exist
    '            End If

    '            'Further validate realtime file existance
    '            If Not IO.File.Exists(sLocalFilePath) Then
    '                isLocalFileFound = False
    '            Else
    '                'Further validate the realtime size to avoid last failed download
    '                Dim fi As New FileInfo(sLocalFilePath)
    '                If fi.Length <> dLocalSize Then
    '                    isLocalFileFound = False
    '                End If
    '            End If

    '            Dim isUpdateAvailable As Boolean = True

    '            If isLocalFileFound Then
    '                If sLocalModifiedDtm >= sServerModifiedDtm AndAlso FileIO.FileSystem.FileExists(sFileID) Then
    '                    isUpdateAvailable = False
    '                End If
    '            End If

    '            '5. Process to download file if update available
    '            If isUpdateAvailable Then
    '                sbLogText.AppendLine("+File is out of date =>Start downloading...")

    '                Dim sUrl As String = Common.AppDeployUrl.Trim & "Downloader.aspx?fileUrl=" & sFileURI

    '                Try

    '                    RU_CurrentFileURL = sUrl
    '                    RU_CurrentLocalFilePath = sLocalFilePath

    '                    Try
    '                        Common.UseRuntimeUpdate = "N" 'Temporary disable (to avoid updating ProgressDialog's assembly)
    '                        'RU_ProgressBar = MainForm.MainFormInstance.NavigateTo("ProgressDialog", UI.NavigatedWindowModes.Popup, False)
    '                        RU_ProgressBar = YJIT.SC.UI.SCView.MainFormInstance.NavigateTo("ProgressDialog", UI.NavigatedWindowModes.Popup, False)
    '                    Catch ex As Exception
    '                        sbLogText.AppendLine("+Could not create ProgressDialog instance(=>Download without ProgressDialog):" & ex.Message)
    '                        RU_ProgressBar = Nothing
    '                    Finally
    '                        Common.UseRuntimeUpdate = "Y"
    '                    End Try

    '                    If RU_ProgressBar IsNot Nothing Then
    '                        'Download with progress dialog

    '                        'Define a background thread and start the 
    '                        'long running process in this separate thread
    '                        Dim backgroundThread As _
    '                            New Threading.Thread(AddressOf RU_ProcessDownloadFile)
    '                        ' Start the background process thread
    '                        backgroundThread.Start()

    '                        RU_ProgressBar.ShowDialog()
    '                    Else
    '                        'Download without showing proress
    '                        Dim myWC As New System.Net.WebClient
    '                        myWC.DownloadFile(RU_CurrentFileURL, RU_CurrentLocalFilePath)
    '                    End If
    '                Catch ex As Exception
    '                    sbLogText.AppendLine("+Failed to download:" & sUrl & vbNewLine & ex.Message)
    '                    Throw ex
    '                End Try
    '                'Finally, store update info to local manifest
    '                RU_LocalManifest(nLocalIndex) = sServerReturn
    '                sbLogText.AppendLine("+Update file sucessfully![" & sServerReturn & "]")
    '            Else
    '                sbLogText.AppendLine("+File is up-to-date => Quit!")
    '            End If
    '        Catch ex As Exception
    '            sbLogText.AppendLine("ERROR:" & ex.Message)
    '        Finally
    '            sbLogText.AppendLine(">>RUNTIME UPDATE END!(" & Now.ToString("yyyy-MM-dd HH:mm:ss") & ")============")
    '            RU_LogMessage.Insert(0, sbLogText)

    '        End Try
    '    End Sub

    '    ''' <summary>
    '    ''' The long running process (download file)
    '    ''' </summary>
    '    ''' <remarks></remarks>
    '    Public Sub RU_ProcessDownloadFile()
    '        Dim myWC As New System.Net.WebClient

    '        Try
    '            myWC.DownloadFile(RU_CurrentFileURL, RU_CurrentLocalFilePath)
    '        Catch ex As Exception
    '            RU_LogMessage.Insert(0, ">>Download Thread error!" & ex.Message)
    '        End Try

    '        RU_ProgressBar.Close()
    '    End Sub

    '    Private Sub loadLocalManifest()
    '        Try
    '            Dim oReader As StreamReader
    '            RU_LocalManifest.Clear()
    '            Dim sManifestPath As String = Application.StartupPath & "\" & RU_LocalManifestFile
    '            If File.Exists(sManifestPath) Then
    '                oReader = New StreamReader(sManifestPath)
    '                Dim lineCnt As Integer = 0
    '                While Not oReader.EndOfStream
    '                    If lineCnt > 0 Then
    '                        RU_LocalManifest.Add(oReader.ReadLine())
    '                    Else
    '                        oReader.ReadLine() 'The first line contain server URL                  
    '                    End If
    '                    lineCnt += 1
    '                End While
    '                oReader.Close()
    '            End If
    '            RU_LogMessage.AppendLine("*ManifestFile: Loaded!" & RU_LocalManifestFile)
    '        Catch ex As Exception
    '            RU_LogMessage.AppendLine("*ManifestFile: Failed to load!" & ex.Message)
    '        End Try

    '    End Sub

    '#End Region


#Region "======Message Hub====== '20191101 김성은 알림"
    Public messageHub As IHubProxy = Nothing
    Public HubConnection As Microsoft.AspNet.SignalR.Client.Hubs.HubConnection = Nothing
    ''' <summary>
    ''' Save and Send to message Function
    ''' </summary>
    ''' <param name="receiver">수신자</param>
    ''' <param name="msg">메시지내용</param>
    ''' <param name="jobtype">업무구분</param>
    ''' <param name="key1">레퍼런스번호1</param>
    ''' <param name="key2">레퍼런스번호2</param>
    ''' <param name="key3">레퍼런스번호3</param>
    ''' <param name="key4">레퍼런스번호4</param>
    ''' <param name="key5">레퍼런스번호5</param>
    ''' <param name="parentMsgid">답장에 대한 원본 메시지 ID</param>
    ''' <param name="MsgBoxShow">보낸 후에 Msgbox Show 설정</param>
    ''' <returns>True:Success, False:Fail</returns>
    ''' <remarks>항목 변경시 MainForm.AlertControl1_AlertClick() 함수도 변경해주세요.</remarks>
    Public Function SendMessageHub(ByVal domain As String, ByVal sender As String, ByVal receiver() As String, ByVal reqsvc As String, ByVal msgtype As String, ByVal jobtype As String,
                                   ByVal msg As String, _
                                   Optional ByVal firstMsgid As String = "", _
                                   Optional ByVal parentMsgid As String = "", _
                                   Optional ByVal key1 As String = "", _
                                   Optional ByVal key2 As String = "", _
                                   Optional ByVal key3 As String = "", _
                                   Optional ByVal key4 As String = "", _
                                   Optional ByVal key5 As String = "", _
                                   Optional ByVal firstChatYN As String = "N", _
                                   Optional ByVal MsgBoxShow As String = "Y") As Boolean


        'If HubConnection.State = Microsoft.AspNet.SignalR.Client.ConnectionState.Disconnected Then
        'Call MainForm.ConnectToCallChatHub()
        'End If

        Dim bReturn As Boolean = True

        '전송할 메시지를 테이블에 저장한다.
        Dim rcv As String = String.Join(";", receiver)

        Dim params As Object = {domain, sender, rcv, reqsvc, msgtype, jobtype, msg, firstMsgid, parentMsgid, key1, key2, key3, key4, key5, firstChatYN}
        Dim dsRet As DataSet = Nothing
        Dim drPairs As DataRow = Nothing

        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "SaveMessage", params)

            '//////Parsing WCF returned data///////
            drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            If drPairs("TrxCode") <> "Y" Then
                MsgBox(drPairs("TrxMsg"))
                bReturn = False
            Else
                If Not String.IsNullOrEmpty(drPairs("FIRST_MSG_ID").ToString) Then
                    firstMsgid = drPairs("FIRST_MSG_ID").ToString
                End If

                'Message Hub Server에 sendMessage Function을 호출한다.
                Dim paramrcv As String = String.Empty
                For i = 0 To receiver.Length - 1
                    Try
                        If String.IsNullOrEmpty(receiver(i)) Then Continue For
                        If reqsvc = "EW" Then msg = msg.Replace(vbCrLf, "<br />")
                        '//Param 구조 : DOMAIN | FromID(이메일) | ToID(이메일) | 구분 (W/E) | 형태 (C/P) | 업무 | Message |FIRST_MSG_ID|REF1|REF2|REF3|REF4|REF5| 
                        paramrcv = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}", domain, sender, receiver(i), reqsvc, msgtype, jobtype, msg, firstMsgid, key1, key2, key3, key4, key5)
                        'messageHub.Invoke("SendMessageToAll", paramrcv, msg)
                        messageHub.Invoke("prime_Message", sender, paramrcv)
                        'prime_Message 
                    Catch ex As Exception
                        MsgBox(ex.Message & " (sendMessage)")
                    End Try
                Next

                'Dim paramrcv As String = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", domain, sender, rcv, reqsvc, msgtype, jobtype, msg, firstMsgid)
                'messageHub.Invoke("SendMessageToAll", paramrcv, msg)

                If MsgBoxShow = "Y" Then
                    MsgBox("Your message has been sent to " & rcv)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            bReturn = False
        End Try

        Return bReturn
    End Function


    Public Function SendElvisToAll(ByVal domain As String, ByVal sender As String, ByVal receiver() As String, ByVal reqsvc As String, ByVal msgtype As String, ByVal jobtype As String,
                               ByVal msg As String, _
                               Optional ByVal firstMsgid As String = "", _
                               Optional ByVal parentMsgid As String = "", _
                               Optional ByVal key1 As String = "", _
                               Optional ByVal key2 As String = "", _
                               Optional ByVal key3 As String = "", _
                               Optional ByVal key4 As String = "", _
                               Optional ByVal key5 As String = "", _
                               Optional ByVal firstChatYN As String = "N", _
                               Optional ByVal MsgBoxShow As String = "Y") As Boolean

        Try
            If receiver.Length = 0 Then receiver = {sender}

            Dim paramrcv As String = String.Empty
            For i = 0 To receiver.Length - 1
                '//Param 구조 : DOMAIN | FromID(이메일) | ToID(이메일) | 구분 (W/E) | 형태 (C/P) | 업무 | Message |FIRST_MSG_ID|REF1|REF2|REF3|REF4|REF5| 
                paramrcv = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}", domain, sender, receiver(i), reqsvc, msgtype, jobtype, msg, firstMsgid, key1, key2, key3, key4, key5)
                'messageHub.Invoke("SendMessageToAll", paramrcv, msg)
                messageHub.Invoke("sendMessage_ToElvis", domain, sender, paramrcv)
                'prime_Message 
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " (sendMessage)")
            Return False
        End Try

        Return True
    End Function
#End Region


End Module
