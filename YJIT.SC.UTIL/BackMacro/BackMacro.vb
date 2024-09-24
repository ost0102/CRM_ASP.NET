Imports BankMarcro.Common 
Imports Microsoft.VisualBasic.Devices
Imports System.Reflection
Imports Microsoft.Win32
Imports YJIT.SC.WCF

Public Class BackMacro

    Dim SacnThread(100) As Threading.Thread
    Dim MacroLogic As New MacroLogic
    Public ImageView As ImageView
    ' Dim Imagepath As String

    Public LastCursorPointX As Integer = 0
    Public LastCursorPointY As Integer = 0

    Dim ImageLogRoot As String = Application.StartupPath & "\Log\ImageLog\" 
    Dim LastMonitor As Integer = 0
    Dim AutoThread As Threading.Thread = Nothing
    'Dim ExrateMgt As YJIT.SC.App.MdmExrateMgt


    Delegate Sub SetTextCallback(ByVal [text] As String)
    Delegate Sub SetTextCallback1(ByVal sender As Object, ByVal [text] As String)


#Region " Data "

    '다운 받은 환율 txt 받음
    Public Function GetExrateTxtPath() As String
        Dim obj As Object = FileIO.FileSystem.GetFiles(DownPath.Text)
        Dim ReadFilePath As String = ""
        For Each f In obj
            Try
                Dim n As String = f.ToString.Remove(0, f.ToString.LastIndexOf("\") + 1)

                If n.StartsWith(FileName.Text) And n.ToLower.EndsWith(".txt") Then
                    ReadFilePath = f
                    Exit For
                End If
            Catch ex As Exception
                WriteLog(ex.Message)
            End Try
        Next
        Return ReadFilePath
    End Function
    '환율을 저장시킴
    Public Sub SaveExrate()
        Try
            Dim ReadFilePath As String = GetExrateTxtPath()
            If ReadFilePath = "" Then
                WriteLog("환율파일이 없습니다.")
                Exit Sub
            End If

            Dim ExDate As String = ""
            Dim Fst As Boolean = False
            Dim Txt As String = FileIO.FileSystem.ReadAllText(ReadFilePath, System.Text.Encoding.Default)
            Dim TxtLIst() As String = Txt.Split(vbCrLf)

            For Each t In TxtLIst
                Dim tmp As String = t.Replace(" ", "").Replace(vbLf, "")
                If tmp <> "" Then
                    If tmp.StartsWith("기준일") Then
                        ExDate = tmp.Remove(0, tmp.LastIndexOf(":") + 1).Replace("-", "")
                    End If
                    If tmp.StartsWith("고시시간") Then
                        Dim tmp1 As String = (tmp.Remove(0, tmp.LastIndexOf("(") + 1))
                        tmp1 = tmp1.Substring(0, tmp1.LastIndexOf("회차"))
                        If tmp1 = "1" Then
                            Fst = True
                        End If
                        Exit For
                    End If
                End If
            Next

            If ExDate <> Now.ToString("yyyyMMdd") Then
                WriteLog(ExDate & " -> 금일 환율이 아니므로 로직을 종료합니다.")
                Exit Sub
            End If

            If Fst = False Then
                WriteLog("최초 고시가 아니므로 로직을 종료합니다.")
                Exit Sub
            End If

            If ConnectELVIS() = True Then


                'Open the selected form as a new child
                Dim assContainer As Assembly = Nothing
                Dim assExecuting As Assembly = Assembly.GetExecutingAssembly()
                Dim frmView As Object = Nothing
                Dim dt As DataTable ' ExrateMgt.GetExrateData(ReadFilePath)
                Try
                    'Wizard 오픈 상태 일경우( customs 초기 셋팅 )
                    WriteLog(ExRateDLLName.Text & " 파일을 읽습니다.")
                    assContainer = Assembly.Load(System.IO.File.ReadAllBytes(ExRateDLLName.Text))
                    frmView = assContainer.CreateInstance("YJIT.SC.App" & "." & ExRateDLLName.Text.ToUpper.Replace(".DLL", ""), True)

                    'Dim ExrateMgt As Object
                    'If ExrateMgt Is Nothing Then
                    '    ExrateMgt = New YJIT.SC.App.MdmExrateMgt
                    'End If

                    WriteLog("환율정보를 수집합니다.")
                    dt = frmView.GetExrateData(ReadFilePath)

                    Dim ds As DataSet = frmView.ConvertToDataset
                    ds.Tables("MAIN").Rows(0)("S_EXRT_YMD") = ExDate
                    ds.Tables("MAIN").Rows(0)("EX_DATE") = ExDate
                    ds.Tables("WG1").Merge(dt)

                    Dim C As New DataColumn
                    C.ColumnName = "_InsFlag"
                    C.DefaultValue = "I"
                    C.DataType = GetType(String)

                    If ds.Tables("WG1").Columns.Contains("_InsFlag") Then
                        ds.Tables("WG1").Columns.Remove(ds.Tables("WG1").Columns("_InsFlag"))
                    End If
                    ds.Tables("WG1").Columns.Add(C)

                    WriteLog("접속정보 확인.")

                    Dim dsRet As DataSet
                    Try
                        WriteLog("저장시도합니다.")
                        dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmExrateMgt", "Save", ds)
                    Catch ex As Exception
                        WriteLog(ex.Message)
                        Exit Sub
                    End Try
                    Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

                    If dr("TrxCode").ToString = "Y" Or dr("TrxMsg").ToString.Contains("ORA-00001") Then
                        WriteLog("S" & ExDate)
                        WriteLog(dr("TrxMsg"))
                        WriteLog("완료되었습니다.")
                    Else
                        WriteLog("N" & ExDate)
                        WriteLog(dr("TrxMsg"))
                        WriteLog("해당 오류가 발생 되었습니다.")
                    End If

                    Dim oa As String = ""
                Catch ex As Exception
                    WriteLog(ex.Message)
                End Try

            End If

        Catch ex As Exception

        End Try

    End Sub

    '텍스트 수정
    Public Sub WriteText(ByVal sender As Object, ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If sender.InvokeRequired Then
            Dim d As New SetTextCallback1(AddressOf WriteText)
            Me.Invoke(d, New Object() {sender, [text]})
        Else
            sender.Text = [text]
        End If
    End Sub
    'log (화면만)
    Public Sub WriteLog(ByVal [text] As String)
        If MacroLog.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf WriteLog)
            Me.Invoke(d, New Object() {[text]})
        Else
            MacroLog.Text = [text] & vbCrLf & MacroLog.Text
        End If
    End Sub
    'elvis (crm 커넥트 및 환율 dll 다운로드)
    Private Function ConnectELVIS()
        Try

            YJIT.SC.WCF.WCFBiz.EndPointName = "RemoteDeploymentServer"
            YJIT.SC.WCF.WCFBiz.DataCommunicationFormat = "SOAP" '"JSON" 
            Dim tmpWcfInfo As New YJIT.SC.WCF.SRBiz.BizServiceClient(YJIT.SC.WCF.WCFBiz.EndPointName)
            '=====================================================
            ' 접속 Server IP 로 해당 login form 분계0
            Dim ServerIP As String = tmpWcfInfo.Endpoint.Address.Uri.ToString
            ServerIP = ServerIP.Substring(0, ServerIP.IndexOf("/WCF"))
            YJIT.SC.WCF.WCFBiz.Instance = New YJIT.SC.WCF.WCFBiz("DEMON", "YJITDEMON", Domain.Text)
            Common.DownLoadExDll(ServerIP)
        Catch ex As Exception
            WriteLog("ConnectELVIS " & ex.Message)
            Return False
        End Try
        Return True
    End Function
    '이미지 스캔
    Public Function ScanImage(ByVal index As Integer, ByVal ImageName As String, Optional ByVal Seq As Integer = 1)
        Dim FoundFlag As Boolean = False
        Dim ImagePath As String = GetImagePath(ImageName)
        Dim FindCount As Integer = 1


        Dim PrimaryScreen As Boolean = True
        If ImagePath <> "" Then

            Dim aaa As Integer = 0
            ' Dim scrtake As Bitmap = New Bitmap("D:\example\별이되어라\auto\auto\bin\Debug\Image\Test.bmp")
            Try
                'Dim Imagepath As String = ""
                'Imagepath = GetImagePath(ListBox1.SelectedItem)
                'Dim scrsize As Size = New Size(Common.Monitor.Width, Common.Monitor.Height)
                'Dim ScWidth As Integer = scrsize.Width
                'Dim ModValue As Integer = scrsize.Width Mod 100
                'ScanProcess = (ScWidth - ModValue) / 100

                'If Imagepath = "" Then Exit Function
                'Dim resource As Bitmap = New Bitmap(Imagepath)
                'Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(resource)
                'Dim scrtake As Bitmap = New Bitmap(Common.Monitor.Width, Common.Monitor.Height)
                'Dim a As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(scrtake)

                ''a.CopyFromScreen(New Point(0 + Common.ScanMonitor.Top, 0 + Common.ScanMonitor.Right), New Point(0 + Common.ScanMonitor.Left, 0 + Common.ScanMonitor.Bottom), scrsize)

                ''   a.CopyFromScreen(New Point(0, 0), New Point(-1600, 900), scrsize)
                'a.CopyFromScreen(Common.ScanMonitor.Left, 0, 0, 0, scrsize)
                'If FileIO.FileSystem.DirectoryExists(ImageLogRoot) = False Then
                '    FileIO.FileSystem.CreateDirectory(ImageLogRoot)
                'End If
                'Dim filename As String = ImageLogRoot & Now.ToString("yyyyMMddhhmmss") & ".bmp"
                'scrtake.Save(filename, System.Drawing.Imaging.ImageFormat.Bmp)


                Dim resource As Bitmap = New Bitmap(ImagePath)
                Dim scrtake As Bitmap = New Bitmap(Common.Monitor.Width, Common.Monitor.Height)

                Dim a As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(scrtake)
                Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(resource)

                Dim scrsize As Size = New Size(Common.Monitor.Width, Common.Monitor.Height)
                a.CopyFromScreen(Common.ScanMonitor.Left, 0, 0, 0, scrsize)

                Dim ImagelogYYMMDD As String = ImageLogRoot & Now.ToString("yyyyMMdd") & "\"
                If FileIO.FileSystem.DirectoryExists(ImagelogYYMMDD) = False Then
                    FileIO.FileSystem.CreateDirectory(ImagelogYYMMDD)
                End If

                Dim filename As String = ImagelogYYMMDD & Now.ToString("yyyyMMddhhmmss") & ".Jpeg"
                scrtake.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg)
                'If ModValue > 0 Then
                '    ProcessCount += 1
                'End If

                Dim ColrCheck As Boolean = False
                Dim LastX As String = 0

                Dim s As Integer = ScanMonitor.Left
                Dim e As Integer = ScanMonitor.Right

                If s < 0 Then
                    e = ScanMonitor.Left * -1
                    s = ScanMonitor.Right

                    PrimaryScreen = False
                End If
                For x As Integer = s To e - 1 'scrsize.Width - 1
                    If FoundFlag = True Then Exit Try

                    If scrtake.Width <= x Then Exit For
                    For y As Integer = ScanMonitor.Top To ScanMonitor.Bottom - 1 'scrsize.Height - 1

                        aaa = y
                        If FoundFlag = True Then Exit Try

                        Dim sColr As System.Drawing.Color = scrtake.GetPixel(x, y)
                        Dim rColr As System.Drawing.Color = resource.GetPixel(0, 0)

                        If sColr = rColr Then
                            If scrsize.Height - (y + resource.Height) < 0 Then
                                Continue For
                            End If
                            If scrsize.Width - (x + resource.Width) < 0 Then
                                Continue For
                            End If
                            Dim ExitForFlag As Boolean = False

                            For i = 0 To resource.Width - 1
                                If FoundFlag = True Then Exit Try
                                For j = 0 To resource.Height - 1
                                    If FoundFlag = True Then Exit Try

                                    Dim sColr1 As System.Drawing.Color = scrtake.GetPixel(x + i, y + j)
                                    Dim rColr1 As System.Drawing.Color = resource.GetPixel(i, j)
                                    If sColr1 <> rColr1 Then
                                        ExitForFlag = True
                                        Exit For
                                    End If
                                Next
                                If ExitForFlag = True Then

                                    Exit For
                                End If
                            Next
                            If ExitForFlag = False Then
                                If FindCount <> Seq Then
                                    FindCount += 1
                                    FoundFlag = False
                                    Continue For
                                End If
                                FoundFlag = True
                                '속도 향상 문제

                                LastCursorPointX = x + resource.Width / 2
                                LastCursorPointY = y + resource.Height / 2

                                If PrimaryScreen = False Then
                                    SetCursorPos(ScanMonitor.Left + LastCursorPointX, LastCursorPointY)
                                Else
                                    SetCursorPos(LastCursorPointX, LastCursorPointY)
                                End If


                                a.Dispose()
                                b.Dispose()
                                resource.Dispose()
                                scrtake.Dispose()

                                Return True
                            Else
                                Continue For
                            End If


                        End If

                    Next
                Next

                resource.Dispose()
                scrtake.Dispose()
                a.Dispose()
                b.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '  scrtake.Dispose() 
        End If
        Return False
    End Function
    ' 체크용
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Imagepath As String = ""
        Imagepath = GetImagePath(ListBox1.SelectedItem)
        Dim scrsize As Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Dim ScWidth As Integer = scrsize.Width
        Dim ModValue As Integer = scrsize.Width Mod 100
        ScanProcess = (ScWidth - ModValue) / 100

        If Imagepath = "" Then Exit Sub
        Dim resource As Bitmap = New Bitmap(Imagepath)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(resource)
        Dim scrtake As Bitmap = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Dim a As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(scrtake)
        a.CopyFromScreen(New Point(0, 0), New Point(0, 0), scrsize)

        scrtake.Save(ImageLogRoot & Now.ToString("yyyyMMddhhmmss") & ".bmp", System.Drawing.Imaging.ImageFormat.Bmp)

        ScanImage(0, ListBox1.SelectedItem)
    End Sub
    '이미지 갱신
    Private Sub SetImageList()
        ListBox1.Items.Clear()
        Dim ImageList As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = GetImageList()
        For i = 0 To ImageList.Count - 1
            Dim Name As String = ImageList.Item(i).ToString().Remove(0, ImageList.Item(i).ToString().LastIndexOf("\") + 1)
            ListBox1.Items.Add(Name)
        Next
    End Sub
    '스레드 중지
    Private Sub AutoThreadSuspend()
        If Not AutoThread Is Nothing Then
            If AutoThread.IsAlive Then
                AutoThread.Suspend()
            End If
        End If
    End Sub



    Public Sub DeleteTxtLog()
        Dim n As String = Now.ToString("yyyy-MM-dd")

        If IsDate(LastRun.Text) Then
            If CDate(LastRun.Text) <> CDate(n) Then
                MacroLog.Text = ""
            End If
        Else
            MainForm.WriteText(MainForm.LastRun, Now.ToString("yyyy-MM-dd"))
        End If
    End Sub

    Public Sub DeleteFile()

        Dim obj As Object = FileIO.FileSystem.GetFiles(DownPath.Text)

        For Each f In obj
            Try
                Dim n As String = f.ToString.Remove(0, f.ToString.LastIndexOf("\") + 1)

                If n.StartsWith(FileName.Text) Then
                    FileIO.FileSystem.DeleteFile(f)
                End If
            Catch ex As Exception
                WriteLog(ex.Message)
            End Try


        Next
    End Sub

    Private Sub SetMonitorList()
        ListBox3.Items.Clear()
        Dim ojb As Object = Screen.AllScreens

        For Each s In Screen.AllScreens
            ListBox3.Items.Add(s.DeviceName)
        Next

    End Sub

    Private Function GetMyScreen() As Screen
        Dim myLocation As Point = Me.Location
        Return Screen.FromPoint(myLocation)
    End Function

    Private Sub Form1_Click()
        Dim myScreen As Screen = GetMyScreen()

        Dim screenshot As New Bitmap(1600, 900)
        Using g As Graphics = Graphics.FromImage(screenshot)
            ' CopyFromScreen() has no concept of what monitor it captures from, so the source point must
            ' be in terms of the virtual desktop, not the monitor.
            Dim desiredPoint As New Point(0, 0)
            Dim topLeft As New Point(-1600, 0)
            desiredPoint.Offset(topLeft)

            g.CopyFromScreen(desiredPoint, New Point(0, 0), screenshot.Size)
        End Using

        screenshot.Save(ImageLogRoot & Now.ToString("yyyyMMddhhmmss") & ".bmp")
        screenshot.Dispose()
    End Sub

    Public Sub DeleteImageLog()
        'Dim L As Object = FileIO.FileSystem.GetDirectories(GetImageList
        Dim bbb As Object = GetResolutionList()
        Dim bbba As Object = GetImageList()

        Dim f As Object = FileIO.FileSystem.GetDirectories(ImageLogRoot)


        For Each d In f
            Dim Fname As String = d.ToString.Remove(0, d.ToString.LastIndexOf("\") + 1)
            If IsDate(Fname) Then
                Dim n As String = Now.ToString("yyyy-MM-dd")
                Dim st As Date = CDate(Fname & " " & "00:00" & ":" & "00")
                Dim en As Date = CDate(n & " " & "00:00" & ":" & "00")

                If st.AddDays(+3) < en Then
                    FileIO.FileSystem.DeleteDirectory(d, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
            End If

        Next
        Dim l As String = ""
    End Sub

#End Region
#Region " 컨트롤 이벤트 "

    '중지
    Private Sub btnChageStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Common.pauseFlag = False Then
            Common.pauseFlag = True
            ' MacroStatus.Text = True.ToString
        Else
            Common.pauseFlag = False
            'MacroStatus.Text = False.ToString
        End If

    End Sub
    '커서 이동 샘플
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Threading.Thread.Sleep(2000)
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        SetCursorPos(-1600, 900) ' Where X and Y are in pixel 
        Threading.Thread.Sleep(3000)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

    End Sub
    ' 현재 커서 정보 찾기 
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim p As POINTAPI
        GetCursorPos(p)
        MsgBox(p.x.ToString & " " & p.x.ToString)
    End Sub
    '쓰레드 중지
    Private Sub BtnAutoThreadSuspend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAutoThreadSuspend.Click
        Timer1.Interval = MaskedTextBox1.Text * 1000

        If BtnAutoThreadSuspend.Text = "중지" Then
            BtnAutoThreadSuspend.Text = "시작"
            AutoThreadSuspend()
            Timer1.Stop()
        Else
            BtnAutoThreadSuspend.Text = "중지"
            Timer1.Start()
        End If
    End Sub
    '캡쳐영역 확인
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        For Each s In Screen.AllScreens

            If s.DeviceName = ListBox3.SelectedItem Then
                Common.ScanMonitor.Bottom = s.WorkingArea.Bottom
                Common.ScanMonitor.Left = s.WorkingArea.Left
                Common.ScanMonitor.Right = s.WorkingArea.Right
                Common.ScanMonitor.Top = s.WorkingArea.Top

                Common.Monitor.Width = s.WorkingArea.Width
                Common.Monitor.Height = s.WorkingArea.Height

                Label2.Text = s.WorkingArea.Top
                Label3.Text = s.WorkingArea.Right
                Label5.Text = s.WorkingArea.Left
                Label4.Text = s.WorkingArea.Bottom


                ' ListBox3.Items.Add(s.DeviceName)
            End If

        Next

        Dim Imagepath As String = ""
        Dim scrsize As Size = New Size(Common.Monitor.Width, Common.Monitor.Height)
        Dim scrtake As Bitmap = New Bitmap(Common.Monitor.Width, Common.Monitor.Height)
        Dim a As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(scrtake)
        Dim f As String = Now.ToString("yyyy-MM-dd") & "\"
        a.CopyFromScreen(Common.ScanMonitor.Left, 0, 0, 0, scrsize)
        If FileIO.FileSystem.DirectoryExists(ImageLogRoot & f) = False Then
            FileIO.FileSystem.CreateDirectory(ImageLogRoot & f)
        End If
        Dim filename As String = ImageLogRoot & f & Now.ToString("yyyyMMddhhmmss") & ".Jpeg"
        scrtake.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg)

        If ImageView Is Nothing Then
            ImageView = New ImageView
        End If
        ImageView.SetImage(filename)
        ImageView.Show()
    End Sub

    Private Sub AutoMacro_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        SetImageList()
        SetMonitorList()
        ListBox3.SelectedIndex = LastMonitor
        MainForm = Me
        DownPath.Text = Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() & "\"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim ojb As Object = Screen.AllScreens
        Dim dd As String = ""
        SetMonitorList()
    End Sub

    '듀얼모니터시 체크용
    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged

        If ListBox3.SelectedItem Is Nothing Then
            Exit Sub
        End If
        If ListBox3.SelectedItem = "" Then
            Exit Sub
        End If

        For Each s In Screen.AllScreens

            If s.DeviceName = ListBox3.SelectedItem Then
                Common.ScanMonitor.Bottom = s.WorkingArea.Bottom
                Common.ScanMonitor.Left = s.WorkingArea.Left
                Common.ScanMonitor.Right = s.WorkingArea.Right
                Common.ScanMonitor.Top = s.WorkingArea.Top
                Common.Monitor.Width = s.WorkingArea.Width
                Common.Monitor.Height = s.WorkingArea.Height
                Label2.Text = s.WorkingArea.Top
                Label3.Text = s.WorkingArea.Right
                Label5.Text = s.WorkingArea.Left
                Label4.Text = s.WorkingArea.Bottom
                ' ListBox3.Items.Add(s.DeviceName)
            End If

        Next

        Dim scrsize As Size = New Size(Common.Monitor.Width, Common.Monitor.Height)
        Dim scrtake As Bitmap = New Bitmap(Common.Monitor.Width, Common.Monitor.Height)
        Dim a As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(scrtake)
        a.CopyFromScreen(Common.ScanMonitor.Left, 0, 0, 0, scrsize)

        Dim f As String = Now.ToString("yyyy-MM-dd") & "\"
        If FileIO.FileSystem.DirectoryExists(ImageLogRoot & f) = False Then
            FileIO.FileSystem.CreateDirectory(ImageLogRoot & f)
        End If
        Dim filename As String = ImageLogRoot & f & Now.ToString("yyyyMMddhhmmss") & ".Jpeg"
        scrtake.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg)
        PictureBox1.ImageLocation = filename

    End Sub

    '타이머
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim Ndate As Date = Now
            Dim n As String = Ndate.ToString("yyyy-MM-dd")
            Dim st As Date = CDate(n & " " & StartTime.Text & ":" & "00")
            Dim en As Date = CDate(n & " " & EndTime.Text & ":" & "00")

            If st <= Ndate And en >= Ndate Then
                DeleteImageLog()
                If MacroLog.Text.Contains("S" & Now.ToString("yyyyMMdd")) = False Then
                    Dim d As New MacroLogic
                    AutoThread = New Threading.Thread(AddressOf d.Bank)
                    AutoThread.Start()
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub
    '
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ConnectELVIS()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveExrate()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Me.TopMost = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Me.MacroLog.Location = New System.Drawing.Point(4, 28)
            Me.MacroLog.Size = New System.Drawing.Size(355, 373)

            Me.Size = New System.Drawing.Size(379, 167)
        Else
            Me.MacroLog.Location = New System.Drawing.Point(4, 234)
            Me.MacroLog.Size = New System.Drawing.Size(355, 167)
            Me.Size = New System.Drawing.Size(379, 442)
        End If

    End Sub
#End Region
     
End Class
