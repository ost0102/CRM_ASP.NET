Imports System.Data
Imports System.Reflection
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports System.Collections.Specialized

Public Module RuntimeUpdate
#Region "==========Update at runtime handling (Harry: 20150724)==============="
    Public RU_LocalManifestFile As String = "LocalManifest.inf"
    Public RU_LocalManifest As New System.Collections.ArrayList                    'Local manifest udpates
    Public RU_LogMessage As New System.Text.StringBuilder       'For debuging Runtime Update performance

    Private RU_ProgressBar As Object                            'ProgressDialog form
    Private RU_CurrentFileURL As String
    Private RU_CurrentLocalFilePath As String

    Private sFileURI As String = ""
    Private sLocalFilePath As String = ""
    Private nLocalIndex As Integer = 0
    Private sServerReturn As String = ""

    Public Function RU_ChkUpdateFile(ByVal sFileID As String) As Boolean
        Dim bRtn As Boolean = False
        'Dim sbLogText As New System.Text.StringBuilder
        'Checking log buffer to avoid memory consuming
        If RU_LogMessage.Length > 10000 Then
            RU_LogMessage.Clear()
            RU_LogMessage.AppendLine(">>BUFFER CLEARED!")
        End If

        If sFileID.ToUpper.EndsWith(".EXE") Then
            RU_LogMessage.Insert(0, ">>Skip Runtime Update to *.Exe file!") 'Avoid update running assembly (.Exe)
            Return False
        End If

        Try
            sFileURI = ""
            sLocalFilePath = ""
            nLocalIndex = 0
            sServerReturn = ""

            'sbLogText.AppendLine(vbNewLine & ">>UPDATE PROCESS START (" & Now.ToString("yyyy-MM-dd HH:mm:ss") & ")")
            'sbLogText.AppendLine("+Requested File:" & sFileID)

            Dim sAppRootPath As String = Application.StartupPath
            If Not sAppRootPath.EndsWith("\") Then sAppRootPath &= "\"

            If sFileID.Contains("\Modules\") Then
                sFileURI = sFileID.Substring(sFileID.IndexOf("\Modules\") + 1) 'Path to a module
                sFileURI = sFileURI.Replace("\", "/") 'Expecting : "Modules/id.dll"
            ElseIf sFileID.Contains("\RPT\") Then
                sFileURI = sFileID.Substring(sFileID.IndexOf("\RPT\") + 1) 'Path to a report
                sFileURI = sFileURI.Replace("\", "/") 'Expecting: "RPT/ACT/SlipMng01M.repx
            Else
                sFileURI = sFileID
            End If

            'sbLogText.AppendLine("+Determined FileURI: " & sFileURI)

            '1. Load local manifest if not yet read
            If RU_LocalManifest.Count = 0 Then
                Call loadLocalManifest()
            End If
            '2. Locate the sFileURL in local manifest to get update information
            Dim sLocalModifiedDtm As String = ""
            Dim sServerModifiedDtm As String = ""
            Dim dLocalSize As Double = 0
            Dim dServerSize As Double = 0
            Dim parts() As String
            Dim isLocalManifestFound As Boolean = False
            For nLocalIndex = 0 To RU_LocalManifest.Count - 1
                If RU_LocalManifest(nLocalIndex).StartsWith(sFileURI) Then
                    parts = RU_LocalManifest(nLocalIndex).Split(",")
                    dLocalSize = CDbl("0" & Trim(parts(1)))
                    sLocalModifiedDtm = Trim(parts(2) & "")
                    If parts.Length > 6 Then
                        sLocalModifiedDtm = Trim(parts(6) & "")
                    End If
                    isLocalManifestFound = True
                    Exit For
                End If
            Next
            If isLocalManifestFound = False Then
                'sbLogText.AppendLine("+FileURI could not be located in local manifest!Process cancelled!" & sFileURI)
                'Exit Sub 'We can not find this in local manifest => not update processing
            End If

            '3. Request to server Manifest.aspx to get file update info
            Dim wc As New System.Net.WebClient
            Dim oReader As New StreamReader(wc.OpenRead(Common.AppDeployUrl.Trim & "Manifest.aspx?SingleFileURI=" & sFileURI))
            sServerReturn = Trim(oReader.ReadLine())  'Expect single line only
            oReader.Close()

            If sServerReturn.Trim = "" Then
                'sbLogText.AppendLine("+Manifest server return nothing!" & sFileURI & ".Process cancelled!")
                Return False
            ElseIf Not sServerReturn.StartsWith(sFileURI) AndAlso Not sServerReturn.ToUpper.Contains(sFileURI.ToUpper()) Then
                'sbLogText.AppendLine("+Manifest server return is not matched![" & sServerReturn & "].Process cancelled!")
                Return False
            End If

            parts = sServerReturn.Split(",")
            If parts.Length < 5 Then
                'sbLogText.AppendLine("+Manifest server return is not well-formed![" & sServerReturn & "].Process cancelled!")
                Return False
            End If

            sFileURI = Trim(parts(0) & "")  'Local에 없어서 파일명만 있는 경우를 대비해서 서버 경로를 가져 옴
            dServerSize = CDbl("0" & Trim(parts(1)))
            sServerModifiedDtm = Trim(parts(2) & "")

            '4. Compare the local & server decide to update or not
            Dim isLocalFileFound As Boolean = True
            sLocalFilePath = sAppRootPath & sFileURI.ToString.Replace("/", "\")
            If Not IO.Directory.Exists(sLocalFilePath.Substring(0, sLocalFilePath.LastIndexOf("\") + 1)) Then
                IO.Directory.CreateDirectory(sLocalFilePath.Substring(0, sLocalFilePath.LastIndexOf("\") + 1)) 'Create path if not exist
            End If

            'Further validate realtime file existance
            Dim sLocalLastWriteTime As String = ""
            If Not IO.File.Exists(sLocalFilePath) Then
                isLocalFileFound = False
            Else
                'Further validate the realtime size to avoid last failed download
                Dim fi As New FileInfo(sLocalFilePath)
                '파일을 못 받았을 경우를 위해서 실제 local 파일의 수정시간과 비교
                '국가별로 로컬 시간이 다르기때문에 표준시에서 9시간을 더한 값(한국서버기준)으로 비교함
                sLocalLastWriteTime = fi.LastWriteTimeUtc.AddHours(9).ToString("yyyy-MM-dd HH:mm:ss")
                'sLocalLastWriteTime = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")  
                If fi.Length <> dLocalSize Then
                    isLocalFileFound = False
                End If
            End If
            Dim isUpdateAvailable As Boolean = True
            If isLocalFileFound Then
                If (sLocalModifiedDtm >= sServerModifiedDtm AndAlso sLocalModifiedDtm <> "") AndAlso _
                    (sLocalLastWriteTime >= sServerModifiedDtm AndAlso sLocalLastWriteTime <> "") Then
                    isUpdateAvailable = False
                End If
            End If
            '5. Process to download file if update available
            If isUpdateAvailable Then
                bRtn = True
            Else
                'sbLogText.AppendLine("+File is up-to-date => Quit!")
                bRtn = False
            End If
        Catch ex As Exception
            'sbLogText.AppendLine("ERROR:" & ex.Message)
            bRtn = False
        Finally
            'sbLogText.AppendLine(">>RUNTIME UPDATE END!(" & Now.ToString("yyyy-MM-dd HH:mm:ss") & ")============")
            'RU_LogMessage.Insert(0, sbLogText)
        End Try

        Return bRtn
    End Function
    ''' <summary>
    ''' Runtime update for Module and RPT only
    ''' </summary>
    ''' <param name="sFileID"></param>
    ''' <remarks></remarks>
    Public Function UR_ProcessRuntimeUpdateFile(ByVal sFileID As String) As String
        Dim sbLogText As New System.Text.StringBuilder
        Dim bRtn As String = ""
        Try
            If RU_ChkUpdateFile(sFileID) Then
                sbLogText.AppendLine(vbNewLine & ">>UPDATE PROCESS START (" & Now.ToString("yyyy-MM-dd HH:mm:ss") & ")")
                sbLogText.AppendLine("+Requested File:" & sFileID)
                'sbLogText.AppendLine("+File is out of date =>Start downloading...")

                Dim sUrl As String = Common.AppDeployUrl.Trim & "Downloader.aspx?fileUrl=" & sFileURI

                Try
                    RU_CurrentFileURL = sUrl
                    RU_CurrentLocalFilePath = sLocalFilePath

                    'Try
                    '    Common.UseRuntimeUpdate = "N" 'Temporary disable (to avoid updating ProgressDialog's assembly)
                    '    RU_ProgressBar = SKR.SC.UI.SCView.MainFormInstance.NavigateTo("ProgressDialog", UI.NavigatedWindowModes.Popup, False)
                    'Catch ex As Exception
                    '    sbLogText.AppendLine("+Could not create ProgressDialog instance(=>Download without ProgressDialog):" & ex.Message)
                    '    RU_ProgressBar = Nothing
                    'Finally
                    '    Common.UseRuntimeUpdate = "Y"
                    'End Try

                    'If RU_ProgressBar IsNot Nothing Then
                    '    'Download with progress dialog

                    '    'Define a background thread and start the 
                    '    'long running process in this separate thread
                    '    Dim backgroundThread As _
                    '        New Threading.Thread(AddressOf RU_ProcessDownloadFile)
                    '    ' Start the background process thread
                    '    backgroundThread.Start()
                    '    RU_ProgressBar.ShowDialog()
                    'Else
                    '    'Download without showing proress
                    '    Dim myWC As New System.Net.WebClient
                    '    myWC.DownloadFile(RU_CurrentFileURL, RU_CurrentLocalFilePath)
                    'End If

                    'Download RealTime (background 실행시 실패해도 성공으로 체크하는 경우가 있어서 실시간 처리함) - by mskang 2015.09.25
                    Dim myWC As New System.Net.WebClient
                    myWC.DownloadFile(RU_CurrentFileURL, RU_CurrentLocalFilePath)

                Catch ex As Exception
                    sbLogText.AppendLine("+Failed to download:" & sUrl & vbNewLine & ex.Message)
                    Throw ex
                End Try
                'Finally, store update info to local manifest
                bRtn = RU_CurrentLocalFilePath

                If nLocalIndex < RU_LocalManifest.Count Then
                    RU_LocalManifest(nLocalIndex) = sServerReturn   'LocalManifest 값을 변경함(실제 파일은 프로그램 종료시 반영)
                Else
                    RU_LocalManifest.Add(sServerReturn)   'LocalManifest 값을 추가함(실제 파일은 프로그램 종료시 반영)
                End If

                sbLogText.AppendLine("+Update file sucessfully![" & sServerReturn & "]")
            Else
                sbLogText.AppendLine("+File is up-to-date => Quit!")
            End If
        Catch ex As Exception
            sbLogText.AppendLine("ERROR:" & ex.Message)
        Finally
            sbLogText.AppendLine(">>RUNTIME UPDATE END!(" & Now.ToString("yyyy-MM-dd HH:mm:ss") & ")============")
            RU_LogMessage.Insert(0, sbLogText)
        End Try

        Return bRtn
    End Function
    ''' <summary>
    ''' The long running process (download file)
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RU_ProcessDownloadFile()
        Dim myWC As New System.Net.WebClient

        Try
            myWC.DownloadFile(RU_CurrentFileURL, RU_CurrentLocalFilePath)
        Catch ex As Exception
            RU_LogMessage.Insert(0, ">>Download Thread error!" & ex.Message)
        End Try

        RU_ProgressBar.Close()
    End Sub
    Public Sub loadLocalManifest()
        Try
            Dim oReader As StreamReader
            RU_LocalManifest.Clear()
            Dim sManifestPath As String = Application.StartupPath & "\" & RU_LocalManifestFile
            If File.Exists(sManifestPath) Then
                oReader = New StreamReader(sManifestPath)
                Dim lineCnt As Integer = 0
                While Not oReader.EndOfStream
                    '첫줄 중복입력 방지(업데이트 주소 부분)
                    If lineCnt > 0 Then
                        RU_LocalManifest.Add(oReader.ReadLine())
                    Else
                        oReader.ReadLine() 'The first line contain server URL                  
                    End If
                    lineCnt += 1
                End While
                oReader.Close()
            End If
            RU_LogMessage.AppendLine("*ManifestFile: Loaded!" & RU_LocalManifestFile)
        Catch ex As Exception
            RU_LogMessage.AppendLine("*ManifestFile: Failed to load!" & ex.Message)
        End Try

    End Sub
#End Region
End Module
