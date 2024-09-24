Imports System.Runtime.InteropServices

Public Module EdmCommon

    'Declare Function GetProfileString Lib "kernel32" Alias "GetProfileStringA" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long) As Long
    'Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer



    Public Declare Function ShellExecute Lib "shell32" _
        Alias "ShellExecuteA" (ByRef hwnd As Integer, ByVal Operation As String,
                               ByVal Filename As String, ByVal Parameters As String,
                               ByVal Directory As String, ByVal ShowCommand As Integer) _
                                As Integer

    Private Declare Function GetDesktopWindow Lib "user32" () As Integer

    'Private Declare Function ShellExecuteEx Lib "shell32.dll" Alias "ShellExecuteExA" (lpExecInfo As SHELLEXECUTEINFO) As Long

    <DllImport("Shell32", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Function ShellExecuteEx(ByRef lpExecInfo As SHELLEXECUTEINFO) As Boolean
    End Function

    Public Structure SHELLEXECUTEINFO
        Public cbSize As Integer
        Public fMask As Integer
        Public hwnd As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpVerb As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpFile As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpParameters As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpDirectory As String
        Dim nShow As Integer
        Dim hInstApp As IntPtr
        Dim lpIDList As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpClass As String
        Public hkeyClass As IntPtr
        Public dwHotKey As Integer
        Public hIcon As IntPtr
        Public hProcess As IntPtr
    End Structure



    Private Const SEE_MASK_CLASSKEY As Long = &H3
    Private Const SEE_MASK_CLASSNAME As Long = &H1
    Private Const SEE_MASK_CONNECTNETDRV As Long = &H80
    Private Const SEE_MASK_DOENVSUBST As Long = &H200
    Private Const SEE_MASK_FLAG_DDEWAIT As Long = &H100
    Private Const SEE_MASK_FLAG_NO_UI As Long = &H400
    Private Const SEE_MASK_HOTKEY As Long = &H20
    Private Const SEE_MASK_ICON As Long = &H10
    Private Const SEE_MASK_IDLIST As Long = &H4
    Private Const SEE_MASK_INVOKEIDLIST As Long = &HC
    Private Const SEE_MASK_NOCLOSEPROCESS As Long = &H40

    Private Const ERROR_FILE_NOT_FOUND As Long = 2&
    Private Const ERROR_PATH_NOT_FOUND As Long = 3&
    Private Const ERROR_BAD_FORMAT As Long = 11&
    Private Const SE_ERR_ACCESSDENIED As Long = 5
    Private Const SE_ERR_ASSOCINCOMPLETE As Long = 27
    Private Const SE_ERR_DDEBUSY As Long = 30
    Private Const SE_ERR_DDEFAIL As Long = 29
    Private Const SE_ERR_DDETIMEOUT As Long = 28
    Private Const SE_ERR_DLLNOTFOUND As Long = 32
    Private Const SE_ERR_FNF As Long = 2
    Private Const SE_ERR_NOASSOC As Long = 31
    Private Const SE_ERR_OOM As Long = 8
    Private Const SE_ERR_PNF As Long = 3
    Private Const SE_ERR_SHARE As Long = 26

    Private Const WAIT_FAILED = -1&
    Private Const WAIT_ABANDONED_0 = &H80&
    Private Const NORMAL_PRIORITY_CLASS = &H20
    Private Const SYNCHRONIZE = &H100000

    Const INFINITE As UInt32 = &HFFFFFFFFUI
    Const WAIT_ABANDONED As UInt32 = &H80UI
    Const WAIT_OBJECT_0 As UInt32 = &H0UI
    Const WAIT_TIMEOUT As UInt32 = &H102UI

    Private Const SW_SHOWNORMAL As Long = 1
    Private Const SW_SHOWMINIMIZED = 2
    Private Const SW_SHOWMAXIMIZED = 3

    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias _
        "GetPrivateProfileStringA" (ByVal lpApplicationName As String, _
            ByVal lpKeyName As String, _
            ByVal lpDefault As String, _
            ByVal lpReturnedString As String, _
            ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    Public Enum EdmGridCheckType
        All = 1
        Checked = 2
    End Enum

    Public Structure EdmErrMsg
        Shared Msg1 As String = "�ڷḦ �����Ͻðڽ��ϱ� ?"
        Shared MSG2 As String = "�ڷḦ �����Ͻðڽ��ϱ� ?"
        Shared Msg3 As String = "ȭ������� �Ͻðڽ��ϱ� ?"
        Shared Msg4 As String = "��� �Ͻðڽ��ϱ� ?"
        Shared Msg5 As String = "���� Ȯ��"
        Shared Msg6 As String = "���� Ȯ��"
        Shared Msg7 As String = "��� Ȯ��"
        Shared MSG8 As String = "�ڷᰡ ����Ǿ����ϴ�."
        Shared MSG9 As String = "�ڷᰡ �����Ǿ����ϴ�. "
        Shared MSG10 As String = "�ڷ� ó���� .."
        Shared MSG11 As String = "�ڷ� ó���� �Ϸ� �Ǿ����ϴ�."
        Shared MSG12 As String = "�ڷḦ ã�� ���� �����ϴ�."
        Shared MSG13 As String = "���ο� �ڷ��Դϴ�."
        Shared MSG14 As String = "������ �ڷ��Դϴ�."
        Shared MSG15 As String = "�۾��� ��ҵǾ����ϴ�."
        Shared MSG16 As String = "�ʼ� �Է� �׸��Դϴ�."
        Shared MSG17 As String = "���ڰ� �߸��Ǿ����ϴ�."
        Shared MSG18 As String = "���ڸ� Ȯ���ϼ���"
        Shared MSG19 As String = "�ڵ带 �Է��ϼ���"
        Shared MSG20 As String = "Ȯ��"
        Shared MSG21 As String = "���"
        Shared MSG22 As String = "�Է��� ���� �ʹ� ��ϴ�."
    End Structure

    Public Structure EdmPath
        Shared ReadOnly Temp As String = Application.StartupPath & "\TMP_OUTPUT\EDM\Temp\"
        Shared ReadOnly Merge As String = Application.StartupPath & "\TMP_OUTPUT\EDM\Merge\"
        Shared ReadOnly Download As String = Application.StartupPath & "\TMP_OUTPUT\EDM\Download\"
        Shared ReadOnly Fax As String = "C:\NETFAX\"
        Shared ReadOnly Upload As String = "/EDM/" & IIf(String.IsNullOrEmpty(SavedSessionDomain), "", SavedSessionDomain & "/") & IIf(String.IsNullOrEmpty(ClientSessionInfo.OfficeCode), "", ClientSessionInfo.OfficeCode & "/")
    End Structure



    Private Structure EDMS_SYSTEMTIME
        Public wYear As Integer
        Public wMonth As Integer
        Public wDayOfWeek As Integer
        Public wDay As Integer
        Public wHour As Integer
        Public wMinute As Integer
        Public wSecond As Integer
        Public wMilliseconds As Integer
    End Structure


    Private Structure EDMS_FILETIME
        Public dwLowDateTime As Long
        Public dwHighDateTime As Long
    End Structure


    Public Sub SetEdmGridStyle(ByRef view As DevExpress.XtraGrid.Views.Grid.GridView())
        Common.DrawRowIndicator(view)

    End Sub

    Function GetEdmGridCheckCount(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal CheckType As EdmGridCheckType = EdmGridCheckType.Checked) As Integer
        Dim CheckedCount As Integer = 0

        Try
            With view
                For i = 0 To .RowCount - 1
                    If .GetRowCellValue(i, "CHK").ToString = "Y" Then
                        CheckedCount += 1
                    End If
                Next
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message & " (GetEdmGridCheckCount)")
        End Try

        Return CheckedCount
    End Function


    Public Sub SetEdmDirectoryClear(ByVal EdmPath As String)
        Try
            If Not IO.Directory.Exists(EdmPath) Then
                IO.Directory.CreateDirectory(EdmPath)
            End If

            Dim FileFullNameList As String() = IO.Directory.GetFiles(EdmPath)
            For Each FileFullName As String In FileFullNameList
                IO.File.Delete(FileFullName)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message & " (SetEdmDirectoryClear)")
        End Try
    End Sub


    Public Function EdmDownLoad(ByVal sourcefile As String, ByVal sourcepath As String, ByVal targetfile As String) As Dictionary(Of String, String)
        Dim retD As New Dictionary(Of String, String)
        Try
            'Me.Cursor = Cursors.WaitCursor

            'Folder validation
            If Not IO.Directory.Exists(EdmPath.Download) Then
                IO.Directory.CreateDirectory(EdmPath.Download)
            End If

            'Default file path and name
            If targetfile = "" Then
                targetfile = IO.Path.Combine(EdmPath.Download & "\", sourcefile)
            End If

            'If target file exists, it will be deleted and overwritten.
            If IO.File.Exists(targetfile) Then
                IO.File.Delete(targetfile)
            End If

            'Copy file to WCF\UploadFiles\UserID folder
            Dim dsResult As DataSet
            Dim dr As DataRow

            dsResult = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EdmCommon", "Copy", {sourcepath, sourcefile})
            dr = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)

            'If the file is copied, it can be downloaded.
            If dr("TrxCode") = "Y" Then
                Dim urlPath As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "UploadFiles/" & ClientSessionInfo.UserID & "/" & sourcefile
                My.Computer.Network.DownloadFile(urlPath, targetfile)
                retD.Add("TrxCode", "Y")
                retD.Add("FileName", IO.Path.GetFileName(targetfile))
                retD.Add("FilePath", IO.Path.GetDirectoryName(targetfile))
                retD.Add("FullName", targetfile)
            Else
                retD.Add("TrxCode", "N")
                retD.Add("TrxMsg", "Couldn't download file! " & dr("TrxMsg").ToString)
            End If
        Catch ex As Exception
            retD.Add("TrxCode", "E")
            retD.Add("TrxMsg", "During download process, error occured! " & ex.Message)
        Finally
            'Me.Cursor = Cursors.Default
        End Try
        Return retD
    End Function


    Public Function EdmUpload(ByVal LocalFileFullName As String, ByVal SaveName As String, Optional ByVal SavePath As String = "/EMAIL/SEND/", Optional ByVal UseAbsolutePath As Boolean = False) As Boolean
        '�ܰ� ȭ�鿡�� ����
        Dim sFilePath = String.Empty
        Try
            Dim tempFile As System.IO.FileInfo = New System.IO.FileInfo(LocalFileFullName)
            sFilePath = tempFile.DirectoryName & "\" & SaveName
            Call System.IO.File.Copy(LocalFileFullName, sFilePath)
        Catch ex As Exception
            Throw New Exception(ex.Message & " (EdmUpload.FileChange)")
        End Try

        Try
            If sFilePath <> "" Then
                '���ε�
                Dim sUploadHandler As String = YJIT.SC.WCF.WCFBiz.Instance.WCFHomeUrl & "UploadHandler.aspx" 'must be available on server
                ' Create a new WebClient instance.
                Dim wc As New System.Net.WebClient()
                Dim responseArray As Byte()
                Try
                    If Not SavePath.ToString.EndsWith("/") Then SavePath = SavePath & "/"


                    Dim myQueryStringCollection As New System.Collections.Specialized.NameValueCollection()
                    If UseAbsolutePath Then ' ������
                        myQueryStringCollection.Add("AbsolutePath", SavePath)
                    Else
                        '�����
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
                    If IO.File.Exists(sFilePath) Then
                        Call System.IO.File.Delete(sFilePath)
                    End If
                Else
                    Throw New Exception("Failed to upload file!")
                    Return False
                End If
            End If



            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            Exit Function
        End Try


    End Function




    Public Function GetEdmFolderMerge(ByVal fsMergePath As String, Optional ByVal view As DevExpress.XtraGrid.Views.Grid.GridView = Nothing) As String

        Dim i As Integer

        Dim arrFileList As String()
        Dim arrFilePage As String()

        Dim fTagetFile As String

        Try
            arrFileList = GetEdmDirectoryFileList(fsMergePath, view)


            'TIF �̹����� �������� Ȯ��
            ReDim arrFilePage(UBound(arrFileList))  'arrFileList�� ���� �迭�� ����

            Dim EdmImgEdit As AxImgeditLibCtl.AxImgEdit = New AxImgeditLibCtl.AxImgEdit
            EdmImgEdit.CreateControl()
            EdmImgEdit.Image = ""

            For i = 0 To UBound(arrFileList)
                'EdmImgEdit.Image = fsMergePath & "\" & arrFileList(i)
                EdmImgEdit.Image = arrFileList(i)
                EdmImgEdit.Display()
                arrFilePage(i) = EdmImgEdit.PageCount
            Next
            '==========================


            '��� �̹��� ����, MERGE
            fTagetFile = GetEdmFileName(ClientSessionOfficeInfo.HqOfficeCode, "EDM")
            'If GetEdmFileFunc("COPY", fsMergePath & "\" & arrFileList(0), fsMergePath & "\" & fTagetFile) = False Then
            If GetEdmFileFunc("COPY", arrFileList(0), fsMergePath & "\" & fTagetFile) = False Then
                Throw New Exception("�������� ���翡 �����߽��ϴ�. " & EdmErrMsg.MSG15)
            End If

            Dim EdmImgAdmin As AxAdminLibCtl.AxImgAdmin = New AxAdminLibCtl.AxImgAdmin
            EdmImgAdmin.CreateControl()
            EdmImgAdmin.Image = fsMergePath & "\" & fTagetFile

            For i = 1 To UBound(arrFileList)
                EdmImgAdmin.Insert(arrFileList(i), 1, 1, arrFilePage(i))
            Next
            '=======================


            EdmImgEdit = Nothing
            EdmImgAdmin = Nothing
        Catch ex As Exception
            Throw New Exception(ex.Message & " (GetEdmFolderMerge)")
        End Try

        Return fTagetFile
    End Function


    Public Function GetEdmDirectoryFileList(fsFILEPATH As String, Optional ByVal view As DevExpress.XtraGrid.Views.Grid.GridView = Nothing) As String()
        Dim tmpflist As String = String.Empty
        Dim flist As String() = Nothing

        Try
            If Not view Is Nothing Then
                '�̹��� ���ս� �����̹��� ���ʿ� �߰��ϵ��� ������ �Ǿ�����
                With view
                    For i = .RowCount - 1 To 0 Step -1
                        If Trim(tmpflist) <> "" Then tmpflist = tmpflist & vbCrLf
                        tmpflist = tmpflist & .GetRowCellValue(i, "FILENAME").ToString
                    Next
                End With
            Else
                Dim FileFullNameList As String() = IO.Directory.GetFiles(fsFILEPATH)
                For Each FileFullName In FileFullNameList
                    If Trim(tmpflist) <> "" Then tmpflist = tmpflist & vbCrLf
                    tmpflist = tmpflist & FileFullName
                Next

                flist = Split(tmpflist, vbCrLf)

                For I = 0 To UBound(flist)
                    For j = 0 To UBound(flist) - 1
                        If flist(j) > flist(j + 1) Then
                            tmpflist = flist(j)
                            flist(j) = flist(j + 1)
                            flist(j + 1) = tmpflist
                        End If
                    Next
                Next

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message & " (GetEdmDirectoryFileList)")
        End Try

        Return flist
    End Function


    Public Function GetEdmFileName(ByVal Edmcd As String, ByVal doctype As String) As String
        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing
        Dim FileName As String = String.Empty

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EdmCommon", "SearchTimestamp", {""})
        Catch ex As Exception
            Throw New Exception(ex.Message & " (GetEdmFileName)")
        End Try

        Try
            dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                Throw New Exception(dr("TrxMsg") & " (GetEdmFileName)")
            End If

            FileName = String.Format("{0}_{1}_{2}_{3}_{4}.tif", doctype _
                                                  , Edmcd _
                                                  , ds.Tables("Data.SearchTimestamp").Rows(0)("TIMEPART").ToString.Substring(0, 8) _
                                                  , ds.Tables("Data.SearchTimestamp").Rows(0)("TIMEPART").ToString.Substring(8, 6) _
                                                  , ds.Tables("Data.SearchTimestamp").Rows(0)("TIMEPART").ToString.Substring(14))
        Catch ex As Exception
            Throw New Exception(ex.Message & " (GetEdmFileName)")
        End Try

        Return FileName

    End Function


    Public Function GetEdmFileFunc(ByVal fsFunc As String, ByVal fsOriginalFile As String, Optional ByVal fsTagetFile As String = Nothing) As Boolean

        Try
            If IO.File.Exists(fsOriginalFile) = False Then
                Throw New Exception("���������� �������� �ʽ��ϴ�." & vbCrLf & EdmErrMsg.MSG15)
            End If

            If Trim(fsTagetFile) <> "" Then
                If IO.File.Exists(fsTagetFile) = True Then
                    Throw New Exception("������ ���ϸ��� �̹� �����մϴ�." & vbCrLf & EdmErrMsg.MSG15)
                End If
            End If

            Select Case Trim(UCase(fsFunc))
                Case "COPY"
                    System.IO.File.Copy(fsOriginalFile, fsTagetFile)
                Case "MOVE", "RENAME"
                    System.IO.File.Move(fsOriginalFile, fsTagetFile)
                Case "DEL", "DELETE"
                    System.IO.File.Delete(fsOriginalFile)
                Case Else
                    Throw New Exception("��ϵ� �׸��� �����ϴ�." & EdmErrMsg.MSG20)
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message & " (GetEdmFileFunc)")
            Return False
        End Try

        Return True
    End Function



    Public Function GetDefaultPrinterName() As String
        Dim oPS As New System.Drawing.Printing.PrinterSettings

        Try
            GetDefaultPrinterName = oPS.PrinterName
        Catch ex As System.Exception
            GetDefaultPrinterName = ""
        Finally
            oPS = Nothing
        End Try
    End Function

    Public Sub SetDefaultPrinterName(ByVal PrinterName As String)
        Try
            Shell(String.Format("rundll32 printui.dll,PrintUIEntry /y /n ""{0}""", PrinterName))    '�⺻ �����ͷ� ����
        Catch ex As System.Exception
            MsgBox(ex.Message & " (SetDefaultPrinterName)")
        End Try
    End Sub


    Public Sub CreateFaxImage(C_Cnt As Integer)
        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgDrv", "PrtType", 0)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgData0", "ImgPage", IIf(C_Cnt = 1, 0, C_Cnt))
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgData0", "PrintPageCount", 0)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgData0", "DirName", "C:\NETFAX\IT")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgData0", "ImgName", Format(Now, "yyyyMMdd") & ".TIF")

            'If IO.File.Exists("C:\YJIMGDRV\YjImgExe.exe") = True OrElse IO.File.Exists("C:\NETFAX\YjImgExe.exe") = True Then
            '���� ���ߵ� �̹�������Ʈ�� ��ġ�Ȱ��

            '��¸ż� ����
            'Call SetRegValue(HKEY_LOCAL_MACHINE, "SOFTWARE\YJIT\YjImgDrv", "ImgPage", IIf(C_Cnt = 1, 0, C_Cnt), REG_DWORD) ' Long ����

            'My.Computer.Registry.LocalMachine.CreateSubKey("MyTestKey")
            ' Change MyTestKeyValue to This is a test value. 
            'Call SaveRegSetting(HKEY_LOCAL_MACHINE, "SOFTWARE\Wow6432Node\YJIT\YjImgDrv", "ImgPage", IIf(C_Cnt = 1, 0, C_Cnt))
            'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgDrv", "ImgPage", IIf(C_Cnt = 1, 0, C_Cnt))



            '������ ��½� .BMP ������ .TIF�� �����Ǵ� .BMP ���Ͽ� �������� ����
            'Call SaveRegSetting(HKEY_LOCAL_MACHINE, "SOFTWARE\YJIT\YjImgDrv", "PrintPageCount", 0)
            ''Call SetRegValue(HKEY_LOCAL_MACHINE, "SOFTWARE\YJIT\YjImgDrv", "PrintPageCount", 0, REG_DWORD) ' Long ����
            'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgDrv", "PrintPageCount", 0)


            '��°�� �� ���ϸ� ����
            'Call SaveRegSetting(HKEY_LOCAL_MACHINE, "SOFTWARE\YJIT\YjImgDrv", "ImgName", EdmPath.Fax & "IT\" & Format(Now, "yyyyMMdd") & ".TIF")
            ''Call SetRegValue(HKEY_LOCAL_MACHINE, "SOFTWARE\YJIT\YjImgDrv", "ImgName", EdmPath.Fax & "IT\" & Format(Now, "yyyyMMdd") & ".TIF", REG_SZ)
            'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgDrv", "ImgName", EdmPath.Fax & "IT\" & Format(Now, "yyyyMMddhhmmss") & ".TIF")
            'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgData1", "ImgName", EdmPath.Fax & "IT\" & Format(Now, "yyyyMMddhhmmss") & ".TIF")

            '�ѽ� ���� üũ�� ���� ��� ����
            If IO.Directory.Exists(EdmPath.Fax) = False Then
                MsgBox("�ѽ����� ���� ������ �����߽��ϴ�. �ٽ� �õ��Ͻñ� �ٶ��ϴ�.", vbInformation, EdmErrMsg.MSG20)
                Exit Sub
            End If

            '�ѽ� ������ ���� ����
            'Call FaxInfo_File_Delete()
            Call SetEdmDirectoryClear(EdmPath.Fax + "OUTBOX\")
            Call SetEdmDirectoryClear(EdmPath.Fax + "IT\")
            'Else
            '    Fax_Report_Count = C_Cnt
            '    Fax_Receiver_count = 1
            '    Fax_Header_Count = 1
            '    'netfax.ini �� print�� ���� write
            '    '        If Fax_Ready(Fax_Report_Count, "MAIL") = False Then
            '    '            Exit Sub
            '    '        End If
            '    If Fax_Ready(Fax_Report_Count, "3") = False Then
            '        Exit Function
            '    End If

            '    Call Fax_File_Open("MASTER")
            '    Call Fax_Master("MAIL")
            '    Call Fax_File_Close()
            '    Call Fax_File_Open("HEADER")
            '    Call Fax_Header("MAIL", "", "")
            '    Call Write_Address("")
            '    Call Fax_File_Close()
            'End If
        Catch ex As Exception
            MsgBox(ex.Message & " (CreateFaxImage)")
        End Try
    End Sub

    Public Sub ShellandWait(ByVal ProcessPath As String)
        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.Start()

            'Wait until the process passes back an exit code 
            objProcess.WaitForExit()

            'Free resources associated with this process
            objProcess.Close()
        Catch
            MessageBox.Show("Could not start process " & ProcessPath, "Error")
        End Try
    End Sub







    '<StructLayout(LayoutKind.Sequential)> _
    'Public Structure SHELLEXECUTEINFO
    '    Public cbSize As Integer
    '    Public fMask As UInteger
    '    Public hwnd As IntPtr
    '    Public lpVerb As [String]
    '    Public lpFile As [String]
    '    Public lpParameters As [String]
    '    Public lpDirectory As [String]
    '    Public nShow As Integer
    '    Public hInstApp As Integer
    '    Public lpIDList As Integer
    '    Public lpClass As [String]
    '    Public hkeyClass As Integer
    '    Public dwHotKey As UInteger
    '    Public hIcon As Integer
    '    Public hProcess As Integer
    'End Structure

    Private Const SW_SHOW As Integer = 5


    Private Structure STARTUPINFO
        Dim cb As Long
        Dim lpReserved As String
        Dim lpDesktop As String
        Dim lptitle As String
        Dim dwX As Long
        Dim dwY As Long
        Dim dwXSize As Long
        Dim dwYSize As Long
        Dim dwXCountChars As Long
        Dim dwYCountChars As Long
        Dim dwFillAttribute As Long
        Dim dwFlags As Long
        Dim wShowWindow As Integer
        Dim cbReserved2 As Integer
        Dim lpReserved2 As Long
        Dim hStdInput As Long
        Dim hStdOutput As Long
        Dim hStdError As Long
    End Structure

    Private Structure PROCESS_INFORMATION
        Dim hProcess As Long
        Dim hThread As Long
        Dim dwProcessId As Long
        Dim dwThreadID As Long
    End Structure



    <DllImport("kernel32", SetLastError:=True)> _
    Function WaitForSingleObject( _
     ByVal handle As IntPtr, _
     ByVal milliseconds As UInt32) As UInt32
    End Function

    Private Declare Function CreateProcess Lib "kernel32" Alias "CreateProcessA" _
    (ByVal lpApplicationName As Long, _
    ByVal lpCommandLine As String, _
    ByVal lpProcessAttributes As Long, _
    ByVal lpThreadAttributes As Long, _
    ByVal bInheritHandles As Long, _
    ByVal dwCreationFlags As Long, _
    ByVal lpEnvironment As Long, _
    ByVal lpCurrentDriectory As Long, _
    lpStartupInfo As STARTUPINFO, _
    lpProcessInformation As PROCESS_INFORMATION) As Long



    '<DllImport("kernel32.dll", SetLastError:=True)> _
    'Public Shared Function CloseHandle(ByVal hObject As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    'End Function

    Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal hObject As IntPtr) As Boolean
    Declare Function CloseHandle Lib "kernel32" Alias "CloseHandle" (ByVal hObject As Integer) As Integer

    Declare Function GetDefaultPrinter Lib "winspool.drv" Alias "GetDefaultPrinterA" (ByVal szPrinter As Text.StringBuilder, ByRef bufferSize As Int32) As Boolean

    Declare Function SetDefaultPrinter Lib "winspool.drv" Alias "SetDefaultPrinterA" (ByVal szPrinter As String) As Boolean


    '�ش� Shell�� ������ ����� ������ ���
    Public Function RunAndWait(RunCommand As String, fsIPVERB As String) As Boolean
        Try

            Dim lHnd As Long
            Dim lRVal As Long

            Dim sMsg As String


            RunAndWait = False

            lHnd = GetDesktopWindow()


            Dim sei As New SHELLEXECUTEINFO
            sei.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(sei)
            sei.lpVerb = fsIPVERB
            sei.lpFile = RunCommand
            sei.nShow = SW_SHOW
            sei.lpParameters = "/T ITFAX Printer Driver"

            If Not ShellExecuteEx(sei) Then
                Dim ex As New System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error())
                Throw New Exception(ex.Message & " (ShellExecuteEx)")
            End If

            RunAndWait = True

            'Dim sei As SHELLEXECUTEINFO


            ''With sei
            ''    ' Size of the structure
            ''    .cbSize = System.Runtime.InteropServices.Marshal.SizeOf(sei)
            ''    ' Use the optional hProcess element of the structure.
            ''    .fMask = SEE_MASK_NOCLOSEPROCESS
            ''    ' Handle to the window calling this function.
            ''    .hwnd = lHnd
            ''    ' The action to perform: open the file.
            ''    '.lpVerb = "Print" '"open"
            ''    .lpVerb = fsIPVERB
            ''    ' The file to open.
            ''    .lpFile = RunCommand
            ''    ' No additional parameters are needed here.
            ''    .lpParameters = "/T ITFAX Printer Driver"
            ''    ' The default directory -- not really necessary in this case.
            ''    .lpDirectory = "C:"
            ''    ' Simply display the window.
            ''    .nShow = SW_SHOWNORMAL
            ''    ' The other elements of the structure are either not used
            ''    ' or will be set when the function returns.
            ''End With


            '' Open the file using its associated program.
            'lRVal = ShellExecuteEx(sei)

            'If lRVal = 0 Then
            '    'There was an error
            '    Select Case sei.hInstApp
            '        Case SE_ERR_FNF
            '            sMsg = "File not found"
            '        Case SE_ERR_PNF
            '            sMsg = "Path not found"
            '        Case SE_ERR_ACCESSDENIED
            '            sMsg = "Access denied"
            '        Case SE_ERR_OOM
            '            sMsg = "Out of memory"
            '        Case SE_ERR_DLLNOTFOUND
            '            sMsg = "DLL not found"
            '        Case SE_ERR_SHARE
            '            sMsg = "A sharing violation occurred"
            '        Case SE_ERR_ASSOCINCOMPLETE
            '            sMsg = "Incomplete or invalid file association"
            '        Case SE_ERR_DDETIMEOUT
            '            sMsg = "DDE Time out"
            '        Case SE_ERR_DDEFAIL
            '            sMsg = "DDE transaction failed"
            '        Case SE_ERR_DDEBUSY
            '            sMsg = "DDE busy"
            '        Case SE_ERR_NOASSOC
            '            sMsg = "No association for file extension"
            '        Case ERROR_BAD_FORMAT
            '            sMsg = "Invalid EXE file or error in EXE image"
            '        Case Else
            '            sMsg = "Unknown error"
            '    End Select

            '    MsgBox(sMsg)

            'Else

            '    '���Ѵ��
            '    Call WaitForSingleObject(sei.hProcess, INFINITE)

            '    Call CloseHandle(sei.hProcess)

            '    RunAndWait = True

            'End If
        Catch ex As Exception
            Throw New Exception(ex.Message & " (RunAndWait)")
        End Try
    End Function


    Public Sub PrintDocumentUsingShellExecute(ByVal szPrinter As String, ByVal szDocumentPath As String)

        Dim szDefaultPrinter As Text.StringBuilder = New Text.StringBuilder(256)
        Dim bufferSize As Integer = szDefaultPrinter.Capacity

        ' get the default printer
        GetDefaultPrinter(szDefaultPrinter, bufferSize)

        ' change the default printer
        If String.Compare(szPrinter, szDefaultPrinter.ToString(), True) <> 0 Then
            SetDefaultPrinter(szPrinter)
        End If

        ' send the document  to the print 
        Dim printProcess As Process = New Process
        printProcess.StartInfo.FileName = szDocumentPath
        printProcess.StartInfo.Verb = "Print"
        printProcess.StartInfo.CreateNoWindow = True
        printProcess.Start()

        'set default printer back to original
        If String.Compare(szPrinter, szDefaultPrinter.ToString()) <> 0 Then
            SetDefaultPrinter(szDefaultPrinter.ToString())
        End If

    End Sub



    Public Function SetFileToImage(ByVal fsTEMP_FAXPATH As String, ByVal fsTEMP_FAXNAME As String, ByRef fsTEMP_NETFAXNAME As String) As Boolean
        Dim EdmDrvName As String = String.Empty
        Dim EdmImgPrtName As String = "ITFAX Printer Driver"

        Try
            EdmDrvName = GetDefaultPrinterName()
            Call SetDefaultPrinterName(EdmImgPrtName)
            Call CreateFaxImage(1)



            'Imports System.IO
            'Dim path As String = "c:\temp\MyTest.txt"
            'RawPrinterHelper.SendStringToPrinter("WindowsPrinterName", File.ReadAllText(path))


            'If RunAndWait(fsTEMP_FAXPATH & "\" & fsTEMP_FAXNAME, "print") = False Then
            '    Call SetDefaultPrinterName(EdmDrvName)
            '    'MsgBox "�̹����� �������� �ʾҽ��ϴ�."
            '    Return False
            'End If



            'Dim MyProcess As New Process
            'MyProcess.StartInfo.CreateNoWindow = False
            'MyProcess.StartInfo.CreateNoWindow = True
            'MyProcess.StartInfo.Verb = "print"
            'MyProcess.StartInfo.FileName = fsTEMP_FAXPATH & "\" & fsTEMP_FAXNAME
            'MyProcess.Start()
            'MyProcess.WaitForExit(10000)
            'MyProcess.CloseMainWindow()
            'MyProcess.Close()




            Call PrintDocumentUsingShellExecute("ITFAX Printer Driver", fsTEMP_FAXPATH & "\" & fsTEMP_FAXNAME)




            '            Dim pathToExecutable As String = "AcroRd32.exe"
            '            Dim sReport = "C:Test.PDF" 'Complete name/path of PDF file
            '            Dim SPrinter = "HP Officejet 5600 seriese" 'Name Of printer 
            'Dim starter As New ProcessStartInfo(pathToExecutable, ��/t �� + sReport + �� �� + sPrinter + ���� 
            '            Dim Process As New Process()
            'Process.StartInfo = starter Process.Start() 


            'String pathToExecutable = @"AcroRd32.exe" ;
            'String s1Reports= @"D:\TestDocs\PrintScreenUI.pdf"; 
            'String SPrinter= @"\\ccrnt008\HPLaser2F"; 
            'ProcessStartInfo starter = new ProcessStartInfo(pathToExecutable, "/t " + s1Reports + " " + SPrinter + " " ; 
            'Process ps = new Process(); 
            'ps.StartInfo = starter;
            'ps.Start();
            'ps.WaitForExit(10000);
            'ps.CloseMainWindow();
            'ps.Close();



            'If RunAndWait(fsTEMP_FAXPATH & "\" & fsTEMP_FAXNAME, "print") = False Then
            '    Call SetDefaultPrinterName(EdmImgPrtName)
            '    'MsgBox "�̹����� �������� �ʾҽ��ϴ�."
            '    Return False
            'End If

            Call SetDefaultPrinterName(EdmImgPrtName)

            Call SetPrintCheckReg()

            '������ �̹��� Ȯ��
            fsTEMP_FAXPATH = "C:\NETFAX\IT\"
            If Right(fsTEMP_FAXPATH, 1) <> "\" Then fsTEMP_FAXPATH = fsTEMP_FAXPATH & "\"
            fsTEMP_NETFAXNAME = "*.tif"
            If GetCreateTifFileName(fsTEMP_FAXPATH, fsTEMP_NETFAXNAME) = False Then
                'MsgBox "�̹����� �������� �ʾҽ��ϴ�."
                Return False
            End If
            '==================
        Catch ex As Exception
            Throw New Exception(ex.Message & " (SetFileToImage)")
        End Try

        Return True

    End Function

    Public Sub SetPrintCheckReg()
        '20120903 �輺��    �ð��� �ʹ� ���� �ɷ��� ���� �߰���
        '                   ���缳�� ��°��� �ʱ�ȭ �Ǵ� ��� �μⰡ �����ɷ� �Ǵ�
        Try
            If IO.File.Exists("C:\NETFAX\YjImgUI.exe") = True Then
                Do While (1)
                    'Dim sTmp As String = GetRegSetting(HKEY_LOCAL_MACHINE, "SOFTWARE\YJIT\YjImgDrv", "PrtType")
                    Dim sTmp As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\YJIT\YjImgDrv", "PrtType", Nothing)
                    If sTmp = 0 Then Exit Do
                    Threading.Thread.Sleep(500) ' 500 milliseconds = 0.5 seconds
                Loop
            Else
                Threading.Thread.Sleep(500) ' 500 milliseconds = 0.5 seconds
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " (SetPrintCheckReg)")
        End Try
    End Sub

    Public Function GetCreateTifFileName(ByVal fsFOLDER As String, ByRef fsFILENAME As String) As Boolean
        Dim CHK_FILENAME As String = String.Empty
        Dim Tcnt As Integer = 0

        Try
            Call SetPrintCheckReg()

            If Right(fsFOLDER, 1) <> "\" Then fsFOLDER = fsFOLDER & "\"

            '5�ʵ��� ���� ���� üũ
            Do While (1)
                If Tcnt > 20 Then Exit Do
                CHK_FILENAME = Dir(fsFOLDER & fsFILENAME)
                If Trim(CHK_FILENAME) <> "" Then
                    Exit Do
                End If
                Threading.Thread.Sleep(500) ' 500 milliseconds = 0.5 seconds
                Tcnt += 1
            Loop

            If Trim(CHK_FILENAME) <> "" Then
                '�˻��� ���ϸ��� ��ȯ��
                fsFILENAME = CHK_FILENAME
                '----------------------
                Return True
            Else
                fsFILENAME = ""
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " (GetCreateTifFileName)")
            Return False
        End Try
    End Function


    Public Sub SET_TIF_FRONT_BACK(fIMGEDIT As AxImgeditLibCtl.AxImgEdit, ByVal fsFRONT_BACK As String, ctrlPAGE As Control)
        Try
            Dim lngNewPg As Integer


            If fIMGEDIT.Image = "" Then
                MsgBox("No image Selected.")
                Exit Sub
            End If

            If fIMGEDIT.ImageModified Then   '��������
                If MsgBox("�̹����� ������ �����Ͻðڽ��ϱ�?", vbYesNo, EdmErrMsg.MSG20) = vbYes Then
                    fIMGEDIT.Save()
                    'Call EDMS_Ftp_Upload(GB_COMKEY, EDMS_FTP_SERVER, EDMS_FTP_USER, EDMS_FTP_PassW, EDMS_Ftp_PORT, fIMGEDIT.Tag, Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1), FileDownPath, Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1))
                    If Not EdmUpload(EdmPath.Download & Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1), Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1), fIMGEDIT.Tag) Then
                        Throw New Exception("�������۽� ������ �߻��߽��ϴ�. ")
                    End If
                End If
            End If

            If fsFRONT_BACK = "BACK" Then
                lngNewPg = fIMGEDIT.Page + 1
                If lngNewPg > fIMGEDIT.PageCount Then
                    Exit Sub
                End If
            ElseIf fsFRONT_BACK = "FRONT" Then
                lngNewPg = fIMGEDIT.Page - 1
                If lngNewPg < 1 Then
                    Exit Sub
                End If
            ElseIf fsFRONT_BACK = "PAGE" Then
                If fIMGEDIT.PageCount < ctrlPAGE.Text Then
                    MsgBox("��ϵ��� ���� �������Դϴ�. �������������� �̵��մϴ�.", vbInformation, EdmErrMsg.MSG20)
                    lngNewPg = fIMGEDIT.PageCount
                ElseIf ctrlPAGE.Text < 1 Then
                    MsgBox("��ϵ��� ���� �������Դϴ�. ù�������� �̵��մϴ�.", vbInformation, EdmErrMsg.MSG20)
                    lngNewPg = 1
                Else
                    lngNewPg = ctrlPAGE.Text
                End If
            Else
                Exit Sub
            End If

            ctrlPAGE.Text = lngNewPg
            fIMGEDIT.Page = lngNewPg
            fIMGEDIT.Display()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub SET_TIF_WIDTH_HEIGHT_FIT(fIMGEDIT As AxImgeditLibCtl.AxImgEdit, ByVal fsWIDTH_HEIGHT As String, ctrlZOOM As Control)
        Try
            If fIMGEDIT.Image = "" Then
                MsgBox("No image Selected.")
                Exit Sub
            End If

            If fsWIDTH_HEIGHT = "WIDTH_HEIGHT" Then
                fIMGEDIT.FitTo(0)
            ElseIf fsWIDTH_HEIGHT = "WIDTH" Then
                fIMGEDIT.FitTo(1)
            ElseIf fsWIDTH_HEIGHT = "HEIGHT" Then
                fIMGEDIT.FitTo(2)
            End If

            ctrlZOOM.Text = Str(fIMGEDIT.Zoom)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub SET_TIF_LEFT_RIGHT_ROTATE(fIMGEDIT As AxImgeditLibCtl.AxImgEdit, ByVal fsLEFT_RIGHT_ROTATE As String, ByVal fsFILEPATH As String)
        Try
            If fIMGEDIT.Image = "" Then
                MsgBox("No image Selected.")
                Exit Sub
            End If

            If fsLEFT_RIGHT_ROTATE = "RIGHT" Then
                fIMGEDIT.RotateRight()
            Else
                fIMGEDIT.RotateLeft()
            End If

            fIMGEDIT.Save()

            'Call EDMS_Ftp_Upload(GB_COMKEY, EDMS_FTP_SERVER, EDMS_FTP_USER, EDMS_FTP_PassW, EDMS_Ftp_PORT, fsFILEPATH, Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1), FileDownPath, Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1))
            If Not EdmUpload(EdmPath.Download & Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1), Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1), fsFILEPATH) Then
                Throw New Exception("�������۽� ������ �߻��߽��ϴ�. ")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub SET_TIF_ZOOMS(fIMGEDIT As AxImgeditLibCtl.AxImgEdit, ByVal fsZOOMS As String, ctrlZOOM As Control)
        Try
            If fIMGEDIT.Image = "" Then
                MsgBox("No image Selected.")
                Exit Sub
            End If

            If fsZOOMS > 300 Or fsZOOMS < 2 Then
                MsgBox("Wrong Number!")
                Exit Sub
            End If

            fIMGEDIT.Zoom = Trim(fsZOOMS)

            fIMGEDIT.Refresh()
            ctrlZOOM.Text = Trim(Str(fIMGEDIT.Zoom))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub SET_TIF_ZOOM_IN_OUT(fIMGEDIT As AxImgeditLibCtl.AxImgEdit, ByVal fsZOOM_IN_OUT As String, ctrlZOOM As Control)
        Try
            If fIMGEDIT.Image = "" Then
                MsgBox("No image Selected.")
                Exit Sub
            End If

            If fsZOOM_IN_OUT = "IN" Then
                If fIMGEDIT.Zoom > 5 Then
                    fIMGEDIT.Zoom = fIMGEDIT.Zoom - 5
                End If
            Else
                If fIMGEDIT.Zoom < 500 Then
                    fIMGEDIT.Zoom = fIMGEDIT.Zoom + 5
                End If
            End If

            fIMGEDIT.Refresh()
            ctrlZOOM.Text = Str(fIMGEDIT.Zoom)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function fCHECK_NETFAX_SETUP() As Integer
        Try
            fCHECK_NETFAX_SETUP = -1

            '20080828 �輺��    ����    �������� �������� ��ġ���� üũ
            If Not IO.Directory.Exists(EdmPath.Fax) Then
                MsgBox("�ѽ� ��ġ�� ����ϼ���.", vbInformation, "Ȯ��")
                Exit Function
            End If

            fCHECK_NETFAX_SETUP = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub FaxInfo_File_Delete()
        Try
            If System.IO.Directory.Exists(EdmPath.Fax & "OUTBOX\") Then
                For Each fname In IO.Directory.GetFiles(EdmPath.Fax & "OUTBOX\")
                    System.IO.File.Delete(IO.Path.Combine(EdmPath.Fax & "OUTBOX\", fname))
                Next
            End If

            If System.IO.Directory.Exists(EdmPath.Fax & "IT\") Then
                For Each fname In IO.Directory.GetFiles(EdmPath.Fax & "IT\")
                    System.IO.File.Delete(IO.Path.Combine(EdmPath.Fax & "IT\", fname))
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GetDriverAndPort(ByVal buffer As String, DriverName As String, PrinterPort As String)
        Dim iDriver As Integer
        Dim iPort As Integer
        Dim PrinterName As String

        DriverName = ""
        PrinterName = ""
        iDriver = InStr(buffer, ",")
        If iDriver > 0 Then
            DriverName = Left(buffer, iDriver - 1)
            iPort = InStr(iDriver + 1, buffer, ",")
            If iPort > 0 Then
                PrinterPort = Mid(buffer, iDriver + 1, iPort - iDriver - 1)
            End If
        End If

    End Sub


    Public Sub SET_TIF_PC_SAVE(fIMGEDIT As AxImgeditLibCtl.AxImgEdit)
        Try
            Dim EdmCurrentPrtDrvName As String = String.Empty
            Dim EdmImgPrtName As String = "ITFAX Printer Driver"

            'Dim R As Integer
            'Dim buffer As String
            Dim DriverName As String = String.Empty
            Dim PrinterPort As String = String.Empty
            Dim PrinterName As String = String.Empty

            Dim tmpFILENAME As String = String.Empty
            Dim tmpFILEPATH As String = String.Empty


            If fIMGEDIT.Image = "" Then
                MsgBox("No image selected")
                Exit Sub
            End If

            'Yes : Include Annotation      / ������ ������ �̹����� ���� / ITFAX�� ����ؼ� �̹��� �����
            'No : Not Include Annotation   / ������ ������ �������� ���� / �ִ� �״�� ���� / �Ϲ������� ������ ������ �̹������� Ȯ�ξȵ�

            Select MsgBox("Save Your PC?" & vbCrLf & vbCrLf & "Yes : Include Annotation" & vbCrLf & "No : Not Include Annotation", vbYesNoCancel)
                Case vbCancel
                    Exit Sub
                Case vbYes
                    '�ѽ���ġ ���� üũ
                    If fCHECK_NETFAX_SETUP = -1 Then Exit Sub
                    '�ѽ� ���� ���� ���� ����
                    Call FaxInfo_File_Delete()

                    'EdmDrvName = Printer.DeviceName '�⺻ ������ ������ ���

                    EdmCurrentPrtDrvName = GetDefaultPrinterName()

                    'Call PrinterSet(EdmDrvName)
                    Call SetDefaultPrinterName(EdmImgPrtName)

                    'Call Create_Image(1)
                    Call CreateFaxImage(1)


                    '����Ʈ ���� ������
                    'buffer = Space(1024)
                    'PrinterName = EdmImgPrtName
                    'R = GetProfileString("PrinterPorts", PrinterName, "", buffer, Len(buffer))
                    'GetDriverAndPort(buffer, DriverName, PrinterPort)

                    Dim query As String = String.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", EdmImgPrtName)
                    Dim searcher As Management.ManagementObjectSearcher = New Management.ManagementObjectSearcher(query)
                    Dim coll As Management.ManagementObjectCollection = searcher.Get()
                    For Each EachPrinter As Management.ManagementObject In coll
                        PrinterName = EachPrinter("Name").ToString
                        DriverName = EachPrinter("DriverName").ToString
                        PrinterPort = EachPrinter("PortName").ToString
                    Next



                    If DriverName <> "" And PrinterPort <> "" Then
                        ''�߰� ������ ������ �̹����� �����ϱ� ���ؼ� ȭ�鿡 �ִ� ���� �״�� �̹��� ����Ʈ�� �����
                        'EdmMain.EdmImgAdmin.Image = fIMGEDIT.Image
                        ''EdmMain.EdmImgAdmin.ShowPrintDialog
                        'EdmMain.EdmImgAdmin.PrintOutputFormat = OutFitPage
                        'fIMGEDIT.PrintImage(EdmMain.EdmImgAdmin.PrintStartPage, EdmMain.EdmImgAdmin.PrintEndPage, EdmMain.EdmImgAdmin.PrintOutputFormat, EdmMain.EdmImgAdmin.PrintAnnotations, PrinterName, DriverName, PrinterPort)
                        ''==========================================================================================
                        Dim EdmImgAdmin As AxAdminLibCtl.AxImgAdmin = New AxAdminLibCtl.AxImgAdmin
                        EdmImgAdmin.CreateControl()
                        EdmImgAdmin.Image = fIMGEDIT.Image
                        EdmImgAdmin.PrintOutputFormat = AdminLibCtl.PrintFormatValue.OutFitPage
                        fIMGEDIT.PrintImage(EdmImgAdmin.PrintStartPage, EdmImgAdmin.PrintEndPage, EdmImgAdmin.PrintOutputFormat, EdmImgAdmin.PrintAnnotations, PrinterName, DriverName, PrinterPort)
                    End If




                    Call SetDefaultPrinterName(EdmCurrentPrtDrvName)


                    '������ �̹��� Ȯ��
                    'Dim MyName As String
                    'MyName = "*.Tif"
                    'If GET_CREATE_TIF_FILENAME(EdmFaxPath & "IT", MyName) = False Then
                    '    MsgBox("�̹����� �������� �ʾҽ��ϴ�.")
                    '    Exit Sub
                    'End If
                    '==================
                    Dim MyName As String = "*.Tif"
                    If GetCreateTifFileName(EdmPath.Fax & "IT\", MyName) = False Then
                        MsgBox("�̹����� �������� �ʾҽ��ϴ�.")
                        Exit Sub
                    End If

                    tmpFILEPATH = EdmPath.Fax & "IT\" & MyName
                Case vbNo
                    tmpFILEPATH = fIMGEDIT.Image
            End Select



            Dim dlgSave = New System.Windows.Forms.SaveFileDialog()
            dlgSave.Filter = "Tif�̹�������(*.tif)|*.tif"
            dlgSave.DefaultExt = "*.tif"
            dlgSave.FileName = GetEdmFileName(ClientSessionOfficeInfo.HqOfficeCode, "EDM") 'GET_EDM_FILENAME(GB_COMEDI, "EDM")
            dlgSave.ShowDialog()

            tmpFILENAME = dlgSave.FileName
            FileCopy(tmpFILEPATH, tmpFILENAME)   '������ ������ ����

            MsgBox("Save Complete!", vbOKOnly)    '�ʱ�ȭ
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub SET_TIF_PRINT(fIMGEDIT As AxImgeditLibCtl.AxImgEdit)
        Try
            If fIMGEDIT.Image = "" Then
                MsgBox("No image selected")
                Exit Sub
            End If


            If MsgBox("Will You print?", vbOKCancel) = vbOK Then
                'EdmMain.EdmImgAdmin.Image = fIMGEDIT.Image
                'EdmMain.EdmImgAdmin.ShowPrintDialog()
                'EdmMain.EdmImgAdmin.PrintOutputFormat = OutFitPage
                'fIMGEDIT.PrintImage(EdmMain.EdmImgAdmin.PrintStartPage, EdmMain.EdmImgAdmin.PrintEndPage, EdmMain.EdmImgAdmin.PrintOutputFormat, EdmMain.EdmImgAdmin.PrintAnnotations)

                'Dim R As Integer
                'Dim buffer As String
                Dim DriverName As String = String.Empty
                Dim PrinterPort As String = String.Empty
                Dim PrinterName As String



                Dim EdmImgAdmin As AxAdminLibCtl.AxImgAdmin = New AxAdminLibCtl.AxImgAdmin
                EdmImgAdmin.CreateControl()
                EdmImgAdmin.Image = fIMGEDIT.Image
                EdmImgAdmin.ShowPrintDialog()
                EdmImgAdmin.PrintOutputFormat = AdminLibCtl.PrintFormatValue.OutFitPage

                'buffer = Space(1024)
                'PrinterName = GetDefaultPrinterName()
                ''R = GetProfileString("PrinterPorts", PrinterName, "", buffer, Len(buffer))
                'R = GetPrivateProfileString("PrinterPorts", PrinterName, "None", buffer, Len(buffer), "\\serveradres\PrinterGuide.ini")
                'GetDriverAndPort(buffer, DriverName, PrinterPort)

                Dim query As String = String.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", GetDefaultPrinterName())
                Dim searcher As Management.ManagementObjectSearcher = New Management.ManagementObjectSearcher(query)
                Dim coll As Management.ManagementObjectCollection = searcher.Get()
                For Each EachPrinter As Management.ManagementObject In coll
                    PrinterName = EachPrinter("Name").ToString
                    DriverName = EachPrinter("DriverName").ToString
                    PrinterPort = EachPrinter("PortName").ToString
                Next


                fIMGEDIT.PrintImage(EdmImgAdmin.PrintStartPage, EdmImgAdmin.PrintEndPage, EdmImgAdmin.PrintOutputFormat, EdmImgAdmin.PrintAnnotations, PrinterName, DriverName, PrinterPort)


            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub SET_TIF_EMAIL(fIMGEDIT As AxImgeditLibCtl.AxImgEdit, ByVal fsDOCUMENT As String, ByVal fsCUSTCD As String, ByVal fsCUST_ATTNCD As String, Optional ByVal fsFAXNO As String = "")
        Dim EdmCurrentPrtDrvName As String = String.Empty
        Dim EdmImgPrtName As String = "ITFAX Printer Driver"


        Try
            'Dim R As Integer
            'Dim buffer As String
            Dim DriverName As String = String.Empty
            Dim PrinterPort As String = String.Empty
            Dim PrinterName As String


            If fIMGEDIT.Image = "" Then
                MsgBox("No image selected")
                Exit Sub
            End If


            If fCHECK_NETFAX_SETUP() = -1 Then Exit Sub


            Call FaxInfo_File_Delete()


            'EdmDrvName = Printer.DeviceName '�⺻ ������ ������ ���

            EdmCurrentPrtDrvName = GetDefaultPrinterName()

            'Call PrinterSet(EdmDrvName)
            Call SetDefaultPrinterName(EdmImgPrtName)

            'Call Create_Image(1)
            Call CreateFaxImage(1)


            MsgBox("Ȯ�� - ��ȸ ���� Ȯ���ؾ��� (SET_TIF_EMAIL)")
            'Call Fax_Title(fsCUSTCD, fsCUST_ATTNCD, fsDOCUMENT, fsFAXNO)



            ''����Ʈ ���� ������
            'buffer = Space(1024)
            'PrinterName = EdmImgPrtName
            ''R = GetProfileString("PrinterPorts", PrinterName, "", buffer, Len(buffer))
            'R = GetPrivateProfileString("PrinterPorts", "PrinterName", "None", buffer, Len(buffer), "\\serveradres\PrinterGuide.ini")

            'GetDriverAndPort(buffer, DriverName, PrinterPort)


            Dim query As String = String.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", GetDefaultPrinterName())
            Dim searcher As Management.ManagementObjectSearcher = New Management.ManagementObjectSearcher(query)
            Dim coll As Management.ManagementObjectCollection = searcher.Get()
            For Each EachPrinter As Management.ManagementObject In coll
                PrinterName = EachPrinter("Name").ToString
                DriverName = EachPrinter("DriverName").ToString
                PrinterPort = EachPrinter("PortName").ToString
            Next


            If DriverName <> "" And PrinterPort <> "" Then

                Dim EdmImgAdmin As AxAdminLibCtl.AxImgAdmin = New AxAdminLibCtl.AxImgAdmin
                EdmImgAdmin.CreateControl()

                '�߰� ������ ������ �̹����� �����ϱ� ���ؼ� ȭ�鿡 �ִ� ���� �״�� �̹��� ����Ʈ�� �����
                EdmImgAdmin.Image = fIMGEDIT.Image
                'EDMMAIN.EDMIMGADMIN.ShowPrintDialog
                EdmImgAdmin.PrintOutputFormat = AdminLibCtl.PrintFormatValue.OutFitPage
                fIMGEDIT.PrintImage(EdmImgAdmin.PrintStartPage, EdmImgAdmin.PrintEndPage, EdmImgAdmin.PrintOutputFormat, EdmImgAdmin.PrintAnnotations, PrinterName, DriverName, PrinterPort)
                '==========================================================================================

                ''20101005 �輺��    ��Ȥ ITFAX PRINTER�� �����ִ� ��� �ִٰ��ؼ� �̵�
                'If Printer.DeviceName = EdmImgPrtName Then Call PrinterSet(EdmDrvName)
                ''=====================================================================


                If fIMGEDIT.PageCount > 1 Then
                    Dim frmMain As YJIT.SC.UI.IMainForm = Nothing
                    Dim fTarget As Object = Nothing
                    frmMain = _IMainForm
                    fTarget = frmMain.NavigateTo("EdmSelectMgt", UI.NavigatedWindowModes.Dialog, False)
                    If Not IsNothing(fTarget) Then
                        fTarget.ShowDialog()
                    End If
                End If


                MsgBox("Ȯ�� - �ѽ� ������ ����")
                '20101005 �輺��    �ٿ�, ����, OUTLOOK, MS OUTLOOK ����
                'If FAX_SEND_GB = "HELPKOREA" Then
                '    COSNDFAX_HELPKOREA.Show vbModal
                'Else
                'EdmSnd01M.Show(vbModal)
                'If Printer.DeviceName = EdmImgPrtName Then Call PrinterSet(EdmDrvName)
                ''End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            'If Printer.DeviceName = EdmImgPrtName Then Call PrinterSet(EdmDrvName)
            Call SetDefaultPrinterName(EdmCurrentPrtDrvName)
        End Try
    End Sub



    Public Sub SET_TIF_INSERT_DELETE_SPLIT_CHANGE(fIMGTHUMB As AxThumbnailLibCtl.AxImgThumbnail, fIMGEDIT As AxImgeditLibCtl.AxImgEdit, ByVal fsINSERT_DELETE_SPLIT_CHANGE As String, ByVal fsFILEPATH As String, ctrlPAGE As Control, ctrlPAGES As Control, ctrlZOOM As Control)
        Try
            Dim temp As String
            Dim I As Integer
            Dim strOrigFile, strAppendFile As String
            Dim PageappendFile, CuRpageORIGFile As Integer
            Dim fFILENAME As String

            If fIMGEDIT.Image = "" Then
                MsgBox("No image Selected.")
                Exit Sub
            End If


            fFILENAME = Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1)


            temp = ""

            Select Case UCase(fsINSERT_DELETE_SPLIT_CHANGE)
                Case "DELETE"

                    If fIMGEDIT.PageCount = 1 Then
                        MsgBox("������ ���� �ϳ��Դϴ�.")
                        Exit Sub
                    End If
                    If fIMGEDIT.PageCount = fIMGTHUMB.SelectedThumbCount Then
                        MsgBox("��� �ϳ��� �������� �����ؾ� �մϴ�.")
                        Exit Sub
                    End If
                    If MsgBox("���õ� �������� �����Ͻðڽ��ϱ�?", vbOKCancel) = vbCancel Then
                        Exit Sub
                    End If

                    fIMGEDIT.SaveAs(EdmPath.Temp & "TEMP1.TIF") '�������Ͽ��� ������ ��� ����ϱ� ���ؼ� ����

                    Dim EdmImgAdmin As AxAdminLibCtl.AxImgAdmin = New AxAdminLibCtl.AxImgAdmin
                    EdmImgAdmin.CreateControl()
                    EdmImgAdmin.Image = EdmPath.Temp & "TEMP1.TIF"

                    For I = fIMGTHUMB.ThumbCount To 1 Step -1
                        If fIMGTHUMB.get_ThumbSelected(I) = True Then
                            fIMGEDIT.Image = ""
                            fIMGEDIT.ClearDisplay()
                            EdmImgAdmin.DeletePages(I, 1)
                        End If
                    Next I

                    fIMGEDIT.Image = EdmImgAdmin.Image

                    FileCopy(EdmPath.Temp & "TEMP1.TIF", EdmPath.Download & fFILENAME)

                Case "SPLIT"


                    If fIMGTHUMB.SelectedThumbCount < 1 Then
                        Exit Sub
                    End If

                    If MsgBox("���õ� �̹����� �и��Ͻðڽ��ϱ�?", vbOKCancel) = vbCancel Then
                        Exit Sub
                    End If

                    Select Case MsgBox("�и��� �������� �������� �����Ͻðڽ��ϱ�?", vbYesNoCancel)
                        Case vbCancel
                            Exit Sub
                        Case vbNo
                            fIMGEDIT.SaveAs(EdmPath.Temp & "TEMP.TIF")

                            strOrigFile = fIMGEDIT.Image

                            Dim EdmImgAdmin As AxAdminLibCtl.AxImgAdmin = New AxAdminLibCtl.AxImgAdmin
                            EdmImgAdmin.CreateControl()
                            EdmImgAdmin.Image = EdmPath.Temp & "TEMP.TIF"

                            For I = fIMGTHUMB.ThumbCount To 1 Step -1
                                If fIMGTHUMB.get_ThumbSelected(I) = False Then
                                    EdmImgAdmin.DeletePages(I, 1)
                                End If
                            Next I

                            Dim dlgSave = New System.Windows.Forms.SaveFileDialog()
                            dlgSave.Filter = "Tif�̹�������(*.tif)|*.tif"
                            dlgSave.DefaultExt = "*.tif"
                            dlgSave.FileName = Now.ToString("yyyyMMdd")

                            If dlgSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                temp = dlgSave.FileName
                            Else
                                Exit Sub
                            End If

                            FileCopy(EdmPath.Temp & "TEMP.TIF", temp)
                        Case Else
                            If fIMGTHUMB.SelectedThumbCount = fIMGTHUMB.ThumbCount Then
                                MsgBox("��� �ϳ��� �������� �����ؾ��մϴ�")
                                Exit Sub
                            End If

                            fIMGEDIT.SaveAs(EdmPath.Temp & "TEMP.TIF")

                            Dim EdmImgAdmin As AxAdminLibCtl.AxImgAdmin = New AxAdminLibCtl.AxImgAdmin
                            EdmImgAdmin.CreateControl()
                            EdmImgAdmin.Image = EdmPath.Temp & "TEMP.TIF"

                            For I = fIMGTHUMB.ThumbCount To 1 Step -1
                                If fIMGTHUMB.get_ThumbSelected(I) = False Then
                                    EdmImgAdmin.DeletePages(I, 1)
                                End If
                            Next I


                            Dim dlgSave = New System.Windows.Forms.SaveFileDialog()
                            dlgSave.Filter = "Tif�̹�������(*.tif)|*.tif"
                            dlgSave.DefaultExt = "*.tif"
                            dlgSave.FileName = Now.ToString("yyyyMMdd")

                            If dlgSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                temp = dlgSave.FileName
                            Else
                                Exit Sub
                            End If

                            FileCopy(EdmPath.Temp & "TEMP.TIF", temp)

                            fIMGEDIT.SaveAs(EdmPath.Temp & "TEMP1.TIF") '�������Ͽ��� ������ ��� ����ϱ� ���ؼ� ����
                            EdmImgAdmin.Image = EdmPath.Temp & "TEMP1.TIF"

                            For I = fIMGTHUMB.ThumbCount To 1 Step -1
                                If fIMGTHUMB.get_ThumbSelected(I) = True Then
                                    fIMGEDIT.Image = ""
                                    fIMGEDIT.ClearDisplay()
                                    EdmImgAdmin.DeletePages(I, 1)
                                End If
                            Next I

                            fIMGEDIT.Image = EdmImgAdmin.Image

                            FileCopy(EdmPath.Temp & "TEMP1.TIF", EdmPath.Download & fFILENAME)
                    End Select

                Case "CHANGE"

                    'Dim i As Integer
                    'Dim RES As Integer
                    Dim Fpage As Integer
                    Dim Lpage As Integer
                    Dim Ffile As String
                    Dim Lfile As String

                    If fIMGTHUMB.SelectedThumbCount <> 2 Then
                        MsgBox("�̹����� 2�� �����ϼ���")
                        Exit Sub
                    End If

                    If MsgBox("���õ� �̹��� ��ġ�� �ٲٽðڽ��ϱ�?", vbOKCancel) = vbCancel Then
                        Exit Sub
                    End If

                    Fpage = fIMGTHUMB.FirstSelectedThumb
                    Lpage = fIMGTHUMB.LastSelectedThumb

                    Dim EdmImgAdmin As AxAdminLibCtl.AxImgAdmin = New AxAdminLibCtl.AxImgAdmin
                    EdmImgAdmin.CreateControl()
                    EdmImgAdmin.Image = ""

                    fIMGEDIT.Page = Lpage
                    fIMGEDIT.Display()
                    fIMGEDIT.Refresh()




                    fIMGEDIT.SavePage(EdmPath.Temp & "TEMP2.Tif", 1, 1, 1, 1, True, 1)
                    fIMGEDIT.Page = Fpage
                    fIMGEDIT.Display()
                    fIMGEDIT.Refresh()
                    fIMGEDIT.SavePage(EdmPath.Temp & "TEMP1.Tif", 1, 1, 1, 1, True, 1)
                    fIMGEDIT.Display()
                    fIMGEDIT.Refresh()

                    EdmImgAdmin.Image = fIMGEDIT.Image
                    fIMGEDIT.Image = ""
                    fIMGEDIT.ClearDisplay()

                    fIMGTHUMB.Image = ""
                    'fIMGTHUMB.ClearThumbs
                    fIMGTHUMB.Refresh()
                    EdmImgAdmin.DeletePages(Fpage, 1)
                    If Fpage > Lpage Then
                        EdmImgAdmin.DeletePages(Lpage, 1)
                    Else
                        EdmImgAdmin.DeletePages(Lpage - 1, 1)
                    End If
                    EdmImgAdmin.Insert(EdmPath.Temp & "TEMP2.Tif", 1, Fpage, 1)
                    EdmImgAdmin.Insert(EdmPath.Temp & "TEMP1.Tif", 1, Lpage, 1)

                Case Else '"INSERT"

                    Dim ofd As OpenFileDialog = New OpenFileDialog()
                    ofd.AddExtension = True
                    ofd.Filter = "Tif����(*.Tif;*.Tiff)|*.tif;*.Tiff"
                    ofd.DefaultExt = "*.tif"

                    ofd.Multiselect = False
                    ofd.FileName = ""

                    If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                        temp = ofd.FileName
                    Else
                        Exit Sub
                    End If

                    Dim Pass As String
                    Pass = InputBox("������ ������ �� �������� �����ּ��� ( 1 - " & (fIMGEDIT.PageCount + 1) & " )", "������ġ��", fIMGEDIT.Page) '�޴�������
                    If Pass = "" Then
                        MsgBox("�۾����")
                        Exit Sub
                    End If

                    strOrigFile = fIMGEDIT.Image
                    strAppendFile = temp
                    CuRpageORIGFile = CInt(Pass)    'fIMGEDIT.Page

                    Dim EdmImgAdmin As AxAdminLibCtl.AxImgAdmin = New AxAdminLibCtl.AxImgAdmin
                    EdmImgAdmin.CreateControl()
                    EdmImgAdmin.Image = strOrigFile
                    fIMGEDIT.Image = strAppendFile
                    fIMGEDIT.Refresh()
                    fIMGEDIT.Page = 1

                    fIMGEDIT.Display()
                    PageappendFile = fIMGEDIT.PageCount
                    EdmImgAdmin.Insert(strAppendFile, 1, CuRpageORIGFile, PageappendFile) '������ ����,������������ ����������, ������������ ��������

                    fIMGEDIT.Page = 1
                    fIMGEDIT.FitTo(1)
            End Select


            'Call EDMS_Ftp_Upload(GB_COMKEY, EDMS_FTP_SERVER, EDMS_FTP_USER, EDMS_FTP_PassW, EDMS_Ftp_PORT, fsFILEPATH, fFILENAME, FileDownPath, fFILENAME)
            If Not EdmUpload(EdmPath.Download & fFILENAME, fFILENAME, fsFILEPATH) Then
                Throw New Exception("�������۽� ������ �߻��߽��ϴ�. ")
            End If


            Call SET_TIF_VIEW(fIMGEDIT, fsFILEPATH, fFILENAME, ctrlPAGE, ctrlPAGES, ctrlZOOM, fIMGTHUMB)



            Call SetEdmDirectoryClear(EdmPath.Temp)
            Call SetEdmDirectoryClear(EdmPath.Merge)
            
        Catch ex As Exception
            Throw New Exception(ex.Message & " (SET_TIF_INSERT_DELETE_SPLIT_CHANGE)")
        End Try
    End Sub


    Public Function SET_TIF_VIEW(fIMGEDIT As AxImgeditLibCtl.AxImgEdit, ByVal fsFILEPATH As String, ByVal fsFILENAME As String, ctrlPAGE As Control, ctrlPAGES As Control, ctrlZOOM As Control, fTHUMBNAIL As AxThumbnailLibCtl.AxImgThumbnail) As Boolean


        Try
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor


            Dim x As Integer ', Attr%, 
            Dim aa As String '$, 
            Dim L As Integer
            Dim sTime As EDMS_SYSTEMTIME
            Dim lTime As EDMS_FILETIME

            Dim i As Long

            Dim tmpPAGE As String = String.Empty
            Dim tmpFILEPATH As String
            Dim tmpLOCATION As String


            If fsFILEPATH.ToString.StartsWith("/") Then
                tmpLOCATION = "REMOTE"
            Else
                tmpLOCATION = "LOCAL"
            End If


            '## ���� �̹����� ������ ��� ������ ���忩�� üũ
            If tmpLOCATION = "REMOTE" Then
                If fIMGEDIT.ImageModified Then   '��������
                    If MsgBox("�̹����� ����Ǿ����ϴ�. ������ �����Ͻðڽ��ϱ�?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                        fIMGEDIT.Save()
                        'Call EDMS_Ftp_Upload(GB_COMKEY, EDMS_FTP_SERVER, EDMS_FTP_USER, EDMS_FTP_PassW, EDMS_Ftp_PORT, fIMGEDIT.Tag, Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1), FileDownPath, Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1))
                        If Not EdmUpload(EdmPath.Download & Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1), Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1), fIMGEDIT.Tag) Then
                            Throw New Exception("�������۽� ������ �߻��߽��ϴ�. ")
                        End If
                    End If
                End If
            End If


            '## ��Ƽ�̹����� 1�������� �ƴѰ�� �ش� ������ ������ �ִٰ� ���� ��ħ�Ŀ����������� �ǵ����ֱ� ���ؼ� �߰�
            If IsNumeric(ctrlPAGE.Text) = True Then
                If CDbl(ctrlPAGE.Text) > 1 Then
                    If Trim(UCase(fsFILENAME)) = Trim(UCase(Mid(fIMGEDIT.Image, InStrRev(fIMGEDIT.Image, "\") + 1))) Then
                        tmpPAGE = ctrlPAGE.Text
                    End If
                End If
            End If


            '## ��Ʈ�� �ʱ�ȭ
            fIMGEDIT.ClearDisplay()


            If Not fTHUMBNAIL Is Nothing Then
                fTHUMBNAIL.Image = ""
            End If


            Dim fileInfo As IO.FileInfo = New IO.FileInfo(fsFILENAME)

            If fileInfo.Extension.ToUpper.StartsWith(".TIF") Then

                If tmpLOCATION = "REMOTE" Then
                    If System.IO.Directory.Exists(EdmPath.Download) = False Then
                        System.IO.Directory.CreateDirectory(EdmPath.Download)
                    End If


                    Dim retD As New Dictionary(Of String, String)
                    'Public Function DownLoadFile(strPrefix As String, sourcefile As String, sourcepath As String, targetfile As String) As System.Collections.Generic.Dictionary(Of String, String)
                    retD = EdmDownLoad(fsFILENAME, _
                                 fsFILEPATH, _
                                 EdmPath.Download & fileInfo.Name)

                    If retD("TrxCode").ToString <> "Y" Then
                        MsgBox(retD("TrxMsg").ToString)
                        Return False
                    End If


                    'If IsBeingFtp(EDMS_FTP_SERVER, EDMS_FTP_USER, EDMS_FTP_PassW, EDMS_Ftp_PORT, fsFILEPATH, fsFILENAME) = False Then
                    '    '������ �ش� ������ ���� ��� ����
                    '    MsgBox("������ ������ �̵��Ǿ��ų� �����Ǿ����ϴ�." & vbCrLf & vbCrLf & "�ڷḦ �ٽ� �ҷ��ɴϴ�.", vbInformation, EdmErrMsg.MSG20)
                    '    'Call CMD_VSG_REFRESH_Click
                    '    '�ٸ� �Լ����� ȣ���ؼ� ����ϴ� ��� �־ ����
                    '    'Screen.MousePointer = 0
                    '    Exit Function
                    'End If


                    '## ���� / ��Ź���� ����Ǽ� �ʿ������ ����
                    ''## �̹��� ������ �ٽ� Ŭ���� ����� ������ �ٷ� ����ȵǰ� ������ ����Ǵ� ��찡 �־ ���� �߰�
                    'If IsBeing(FileDownPath & "\" & fsFILENAME) = True Then
                    '    Kill(FileDownPath & "\" & fsFILENAME)
                    'End If

                    ''������ �ش� ������ �ִ� ��� ����
                    'Call Ftp_Download(GB_COMKEY, EDMS_FTP_SERVER, EDMS_FTP_USER, EDMS_FTP_PassW, EDMS_Ftp_PORT, fsFILENAME, fsFILEPATH, FileDownPath)
                    ''Call ImageDisplay(FileDownPath, fsFILENAME)


                    '## ���� / �ٿ�ε�� ���п��� üũ�� ������
                    ''�������� �ִ� ��츸 ó��
                    'If IsBeing(FileDownPath & "\" & fsFILENAME, 0) = False Then
                    '    MsgBox("�ش����� �ٿ�ε忡 ���� �߽��ϴ�. �ٽ� �õ��Ͻñ� �ٶ��ϴ�.", vbInformation)
                    '    '�ٸ� �Լ����� ȣ���ؼ� ����ϴ� ��� �־ ����
                    '    'Screen.MousePointer = 0
                    '    Exit Function
                    'End If

                    tmpFILEPATH = EdmPath.Download
                Else
                    tmpFILEPATH = fsFILEPATH
                End If


                fIMGEDIT.ClearDisplay()
                fIMGEDIT.Image = tmpFILEPATH & "\" & fsFILENAME
                fIMGEDIT.Page = 1
                fIMGEDIT.FitTo(1)

                '## �̹��� ����� ������ ���ε��ϱ� ���� ��� ����
                fIMGEDIT.Tag = fsFILEPATH

                '## ��������� ��� ��� �����Ǽ� �ʱ�ȭ ó��
                fIMGEDIT.SelectTool(0)


                ctrlZOOM.Text = fIMGEDIT.Zoom
                ctrlPAGE.Text = 1


                '## ������ ����������� ǥ���ϱ� ���ؼ� �߰�
                fIMGEDIT.Zoom = ctrlZOOM.Text


                '## ǥ�� �ڸ��� �������
                ctrlPAGES.Text = "Page          /" & fIMGEDIT.PageCount.ToString.PadLeft(5)


                fIMGEDIT.Display()


                '## ��Ƽ�̹����� 1�������� �ƴѰ�� �ش� ������ ������ �ִٰ� ���� ��ħ�� ������������ �ǵ����ֱ� ���ؼ� �߰�
                If Not String.IsNullOrEmpty(tmpPAGE) Then
                    If fIMGEDIT.PageCount >= tmpPAGE Or tmpPAGE > 1 Then
                        If fIMGEDIT.Image = "" Then
                            Throw New Exception("No image Selected.")
                        End If
                        fIMGEDIT.Page = Trim(tmpPAGE)
                        fIMGEDIT.Display()
                        ctrlPAGE.Text = Trim(tmpPAGE)
                    End If
                End If
                '====================================================================================================================================


                fIMGEDIT.SelectTool(1)
                fIMGEDIT.MousePointer = 23


                If Not fTHUMBNAIL Is Nothing Then
                    fTHUMBNAIL.Image = fIMGEDIT.Image

                    '## �ӽ��ּ� / ������ ���� ��
                    'EdmMain.EdmImgAdmin.Image = fIMGEDIT.Image

                    'fTHUMBNAIL.DisplayThumbs(1, 0) 'üũ �޴��� ���� 
                    fTHUMBNAIL.DisplayThumbs()
                    fTHUMBNAIL.ScrollDirection = ThumbnailLibCtl.ScrollConstants.Vertical  'Set vertical scrolling
                    fTHUMBNAIL.Refresh()
                End If
            End If

            Cursor.Current = currentCursor
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
            Return False
        End Try

        Return True

    End Function

End Module
