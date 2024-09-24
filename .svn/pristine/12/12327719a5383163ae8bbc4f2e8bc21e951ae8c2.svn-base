Imports System.IO


Public Class Common

    Public Shared RunProcess As Boolean = False

    Public Shared MainForm As BackMacro
    Public Shared ScanMonitor As RECT
    Public Shared Monitor As MonitorInfo

    Public Shared ScanProcess As Integer = 1

    Public Shared RedRoomSeq As Integer = 1
    '신발 구매 flag
    Public Shared pauseFlag As Boolean = False
    '해상도
    'Public Shared Resolution As String = ""

    Public Structure POINTAPI
        Public x As Integer
        Public y As Integer
    End Structure

    Public Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    Public Structure MonitorInfo
        Public Width As Integer
        Public Height As Integer
    End Structure

    Public Structure WINDOWPLACEMENT
        Public Length As Integer
        Public flags As Integer
        Public showCmd As Integer
        Public ptMinPosition As POINTAPI
        Public ptMaxPosition As POINTAPI
        Public rcNormalPosition As RECT
    End Structure


    Public Declare Function GetWindowPlacement Lib "user32" (ByVal hwnd As IntPtr, ByRef lpwndpl As WINDOWPLACEMENT) As Integer

    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr


    Public Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer
    Public Declare Function SetCursorPos Lib "user32" (ByVal X As Short, ByVal Y As Short) As Integer
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)

    ' 마우스 이벤트
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_MOVE = &H1
    Public Const MOUSEEVENTF_ABSOLUTE = &H8000
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10



    Public Shared Function GetImagePath(ByVal ImageName As String) As String
        Dim ImageList As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = FileIO.FileSystem.GetFiles(Application.StartupPath & "\Image\")

        If ImageName Is Nothing Then Return ""
        For i = 0 To ImageList.Count - 1

            Dim ImagePath As String = ImageList.Item(i)
            Dim ImageName1 As String = ImagePath.Remove(0, ImagePath.LastIndexOf("\") + 1)

            If ImageName.ToUpper = ImageName1.ToUpper Then
                Return ImagePath
            End If

        Next

        Return ""
    End Function

    Public Shared Function GetResolutionList() As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Dim ResolutionList As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = FileIO.FileSystem.GetDirectories(Application.StartupPath & "\Image")

        Return ResolutionList
    End Function

    Public Shared Function GetImageList() As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Dim ImageList As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = FileIO.FileSystem.GetFiles(Application.StartupPath & "\Image\")
        Return ImageList
    End Function


    Public Shared Sub MouseClick()
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Sub

    Public Shared Sub WriteLog(ByVal Text As String)
        ' common.mainform.MacroLog.Text &= Text & vbCrLf
        Common.MainForm.WriteLog(Text)
    End Sub

    Public Shared Function BaseAction(ByVal ImageName As String, Optional ByVal SleepTime As Integer = 2000 _
                         , Optional ByVal MoveX As Integer = 0 _
                         , Optional ByVal MoveY As Integer = 0 _
                         , Optional ByVal ReSearch As Boolean = True _
                         , Optional ByVal ReSearchCnt As Integer = 5 _
                         , Optional ByVal Click As Boolean = True _
                         , Optional ByVal Seq As Integer = 1)
        Dim Result As Boolean
        Dim Cnt As Integer = 0
        Do While True
            Result = Common.MainForm.ScanImage(Common.ScanProcess, ImageName & ".bmp", Seq)
            Threading.Thread.Sleep(SleepTime)
            Cnt += 1
            If Result = True Then
                If MoveX <> 0 Or MoveY <> 0 Then
                    SetCursorPos(Common.MainForm.LastCursorPointX + MoveX, Common.MainForm.LastCursorPointY + MoveY)
                End If
                If Click Then
                    Threading.Thread.Sleep(2000)
                    MouseClick()
                Else
                    Threading.Thread.Sleep(1000)
                End If
                Return True
            Else
                If ReSearch = True Then
                    If Cnt > ReSearchCnt Then
                        Exit Do
                    End If
                Else
                    Return False
                End If
            End If
        Loop
        Return False
    End Function

    Public Shared Function TryCInt(ByVal value As Object)
        Dim NewVal As Integer = 0
        Try
            NewVal = CInt(value)
        Catch ex As Exception

        End Try
        Return NewVal
    End Function

    'crm 서버 dll파일을 다운로드
    Public Shared Sub DownLoadExDll(ByVal ServerIp As String)

        Dim arlServerManifest As New ArrayList          'Server manifest updates  

        Dim sAppPluginUrl As String = ServerIp & "/wcf/client/"
        arlServerManifest.Clear()
        Dim wc As New System.Net.WebClient
        Dim oReader As New StreamReader(wc.OpenRead(sAppPluginUrl & "Manifest.aspx"))

        Dim cnt As Integer = 0

        While Not oReader.EndOfStream

            Dim t As String = oReader.ReadLine.ToString

            If t.ToUpper.Contains(MainForm.ExRateDLLName.Text.ToUpper) Then
                arlServerManifest.Add(t)
            End If

            cnt += 1
        End While
        oReader.Close()

        Dim mod_url As String = ""
        If arlServerManifest.Count > 0 Then
            If MainForm.ServerDllInfo.Text = arlServerManifest(0) Then
                Exit Sub
            End If
            Dim obj() As String = arlServerManifest(0).ToString.Split(",")
            If obj.Length > 0 Then
                mod_url = obj(0)
            End If
        End If

        Dim sPlugin As String = mod_url

        'Update this plugin
        Dim sUrl As String = sAppPluginUrl.Trim & "Downloader.aspx?fileUrl=" & sPlugin

        'Dim sPendingPostfix As String = ""

        Dim sLocalPath As String = Application.StartupPath & sPlugin.ToString.Replace("/", "\").Replace("Modules", "")
        Dim sLocalFolderPath As String = Application.StartupPath & "\"
        If Not Directory.Exists(sLocalFolderPath) Then
            'Create folder structure if not exists
            Directory.CreateDirectory(sLocalFolderPath)
        End If


        Dim remoteFile As Uri = Nothing
        Uri.TryCreate(sUrl, System.UriKind.Absolute, remoteFile)
        Try
            Dim sFile As String = sLocalPath.Substring(sLocalPath.LastIndexOf("\") + 1)
            wc.DownloadFileAsync(remoteFile, sLocalPath)
            'wc.DownloadFile(sUrl, sLocalPath)
            MainForm.WriteText(MainForm.ServerDllInfo, arlServerManifest(0))
        Catch ex As Exception
            If TypeOf (ex) Is System.Net.WebException Then
                Try
                    Uri.TryCreate(sUrl, System.UriKind.Absolute, remoteFile)
                Catch ex1 As Exception
                    If TypeOf (ex) Is System.Net.WebException Then
                        Uri.TryCreate(sUrl, System.UriKind.Absolute, remoteFile)
                    Else
                        Exit Sub
                    End If
                End Try
            Else
                Exit Sub
            End If
        End Try
    End Sub
End Class
