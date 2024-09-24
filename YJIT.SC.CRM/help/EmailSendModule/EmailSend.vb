Imports System.Text
Imports System.IO
Imports YJIT.SC
Imports YJIT.SC.WCF.SRBiz
Imports System.Net.Mail
Imports System.Net

Public Class EmailSend


    Dim Domain As String = ""
    Dim SenderEmail As String = ""
    Dim IDPswd As String = ""
    Dim SavedAppPath As String = ""
    Dim USR_ID As String = ""

    Delegate Sub SetTextCallback(ByVal obj As Object, ByVal text As String)

    Private Sub SetText(ByVal obj As Object, ByVal text As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        Try
            If CType(obj, Label).InvokeRequired Then
                Dim d As New SetTextCallback(AddressOf SetText)
                Me.Invoke(d, New Object() {obj, text})
            Else
                CType(obj, Label).Text = text
            End If
        Catch ex As Exception

        End Try
      
    End Sub

    Delegate Sub MeCloseCallback(ByVal obj As Object)

    Private Sub MeClose(ByVal obj As Object)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If CType(obj, Form).InvokeRequired Then
            Dim d As New MeCloseCallback(AddressOf MeClose)
            Me.Invoke(d, New Object() {obj})
        Else
            Threading.Thread.Sleep(2000)
            CType(obj, Form).Dispose()
        End If
    End Sub


    Private Sub SetEmail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown 
        Dim t As New Threading.Thread(AddressOf RunThread)
        t.Start()
    End Sub



    Public Sub RunThread()
        If ServerConnect() = False Then
            Exit Sub
        End If

        Try
            If USR_ID = "" Then Throw New Exception("초기화 할 ID 정보 누락.")
            Dim ResultDs As DataSet
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            dt.TableName = "MAIN"
            dt.Columns.Add("USR_ID")
            dt.Rows.Add(USR_ID)
            ResultDs = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MdmUserMgt", "UnLockUser", ds)

            Dim RstDt As DataTable = ResultDs.Tables(0)
            Dim dr As DataRow = RstDt.Rows(0)
            If dr("TrxCode") = "Y" Then

                Dim Rev As String = dr("Email")
                SetText(RevMailLbl, Rev)
                Dim NewPass As String = dr("NewPass")

                Dim Msg0 As String = ("Administrator (the sender) has been initialized by a password.")
                Dim Msg1 As String = ("Your ID has been unlocked.")
                Dim Msg3 As String = ("Your password is as follows:")
                Dim Msg4 As String = NewPass

                Dim Msg5 As String = ("mail has been sent.") & vbCrLf & "( Administrator )"
                Dim TotalMsg As String = Msg0 & vbCrLf & Msg1 & vbCrLf & Msg3 & vbCrLf & "==========================" & vbCrLf & Msg4 & vbCrLf & "=========================="


                EmailSend(Rev, Msg0, TotalMsg)
            Else
                Throw New Exception(dr("Trxmsg"))
            End If

        Catch ex As Exception
            SetText(Label14, ex.Message)
            Exit Sub 
        Finally
            SetText(Label14, "전송 되었습니다.")
            MeClose(Me)
        End Try
    End Sub
    Private Sub EmailSend(ByVal Recv As String, ByVal Subject As String, ByVal Body As String)
         
        If SenderEmail = "" Then
            SenderEmail = "help@yjit.co.kr"
        End If 
        '        Dim message As New MailMessage("lbh@yjit.co.kr", "lbh@yjit.co.kr", "lbh@yjit.co.kr", "lbh@yjit.co.kr")
        Dim message As New MailMessage(SenderEmail, Recv, Subject, Body)
        Dim smtpClient As New SmtpClient("mail.yjit.co.kr")
        smtpClient.UseDefaultCredentials = False
        Dim credentials As New NetworkCredential("system@yjit.co.kr", "elvis2015")
        smtpClient.Credentials = credentials
        smtpClient.Send(message)
         
    End Sub

    Public Function ServerConnect() As Boolean
        Try
            SetAppConfig("RemoteDeploymentServer")

            If Domain = "" Then Return False
            WCF.WCFBiz.EndPointName = "RemoteDeploymentServer"
            WCF.WCFBiz.DataCommunicationFormat = "SOAP"
            YJIT.SC.WCF.WCFBiz.Instance = New YJIT.SC.WCF.WCFBiz("DEMON", "YJITDEMON", Domain)
        Catch ex As Exception
            SetText(Label14, "연결에 실패 했습니다.")
            Return False
        End Try

        Return True
    End Function

    Private Sub SetAppConfig(ByVal EndPointName As String)
        Dim DS1 As New DataSet
        'Dim ServerIp As String = ""
        'Dim ServerPort As String = ""
        'Dim IdentityID As String = ""  
        Dim DefualtPath As String = Application.StartupPath & "\EmailSend.exe.config"

        Dim readPath As String = ""
        
        If Not FileIO.FileSystem.FileExists(DefualtPath) Then
            Exit Sub
        Else
            readPath = DefualtPath
        End If

        DS1.ReadXml(readPath)
        Dim dt As DataTable = Nothing
        dt = DS1.Tables("Setting")
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("Name").ToString.ToUpper = "Domain".ToUpper Then
                Domain = dt.Rows(i)("Value").ToString
                SetText(DomainLbl, Domain)

                Continue For
            End If

            If dt.Rows(i)("Name").ToString.ToUpper = "SenderEmail".ToUpper Then
                SenderEmail = dt.Rows(i)("Value").ToString
                Continue For
            End If
            If dt.Rows(i)("Name").ToString.ToUpper = "IDPswd".ToUpper Then
                IDPswd = dt.Rows(i)("Value").ToString
                Continue For
            End If
            If dt.Rows(i)("Name").ToString.ToUpper = "SavedAppPath".ToUpper Then
                SavedAppPath = dt.Rows(i)("Value").ToString
                SetText(SavedAppPathLbl, SavedAppPath)
                Continue For
            End If

            If dt.Rows(i)("Name").ToString.ToUpper = "USR_ID".ToUpper Then
                USR_ID = dt.Rows(i)("Value").ToString
                SetText(UserIDLbl, USR_ID)
                Continue For
            End If
        Next

        Dim ServerIp As String = ""
        Dim ServerPort As String = ""
        Dim IdentityID As String = ""
        If SavedAppPath.Contains(":") Then
            ServerIp = SavedAppPath.Split(":")(0)
            ServerPort = SavedAppPath.Split(":")(1)
        End If
        dt = DS1.Tables("EndPoint")
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("name").ToString.ToUpper = EndPointName.ToUpper Then
                dt.Rows(i)("address") = "http://" & ServerIp & ":" & ServerPort & "/WCF/BizService.svc"
                IdentityID = dt.Rows(i)("EndPoint_Id")
                Exit For
            End If
        Next
        dt = DS1.Tables("dns")
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("identity_Id").ToString.ToUpper = IdentityID Then
                dt.Rows(i)("Value") = ServerIp
                Exit For
            End If
        Next





    End Sub

 
End Class