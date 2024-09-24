Imports System.Net, System.Net.Sockets
Imports System.Text
Imports System.Management

Public Module frmClient
    Dim clientSocket As Socket
    Dim byteData(1023) As Byte
    Dim ipEndPoint As IPEndPoint
    Dim _UserID As String = ""
    Dim _Domain As String = ""
    Dim _UserName As String = ""

    Public Sub RunClient(ByVal Domain As String, ByVal UserID As String, ByVal UserName As String)
        clientSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

        Dim ServerInfo As String = Common.ServerIP.ToUpper.Replace("HTTP://", "")
        Dim s() As String = ServerInfo.Split(":")
        If s(0) = "LOCALHOST" Then
            s(0) = "127.0.0.1"
        End If
        Dim ipAddress As IPAddress = ipAddress.Parse(s(0))
        ipEndPoint = New IPEndPoint(ipAddress, 8886)
        clientSocket.BeginConnect(ipEndPoint, New AsyncCallback(AddressOf OnConnect), Nothing)
        _UserID = UserID
        _Domain = Domain
        _UserName = UserName
    End Sub

    Private Sub OnConnect(ByVal ar As IAsyncResult)

        Try
            Dim ds As DataSet = GetSendDataSet("Infomation")
            Dim dt As DataTable = ds.Tables("Infomation")
            dt.Rows.Add()
            dt.Rows(0)("DOMAIN") = _Domain
            dt.Rows(0)("FR_USR_ID") = _UserID
            dt.Rows(0)("TO_USR_ID") = ""
            dt.Rows(0)("MSG") = ""
            dt.Rows(0)("FR_USR_NAME") = _UserName
            dt.Rows(0)("MSG_CODE") = ""

            ' dt.Rows.Add(_Domain, _UserID, "", "", _UserName, "")


            '  Dim ByteMessage() As Byte = Encoding.Default.GetBytes("Info^UserID:" & _UserID & ",Domain:" & _Domain & ",UserName:" & _UserName)
            Dim ByteMessage() As Byte = Encoding.Default.GetBytes(ds.GetXml)
            If clientSocket.Connected = True Then
                clientSocket.BeginSendTo(ByteMessage, 0, ByteMessage.Length, SocketFlags.None, ipEndPoint, New AsyncCallback(AddressOf SendMsg), clientSocket)
            End If

            clientSocket.EndConnect(ar)
            ReDim byteData(1023)
            clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
                                      New AsyncCallback(AddressOf OnRecieve), clientSocket)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SendMsg(ByVal ar As IAsyncResult)
        
    End Sub

    Private Function GetSendDataSet(ByVal PushType As String, Optional ByVal SearchKey As Dictionary(Of String, String) = Nothing)
        Dim Ds As New DataSet
        Dim DT As New DataTable

        Dim Domain As String = Common.SavedSessionDomain
        Dim UserID As String = ClientSessionInfo.UserID
        Dim UserName As String = ClientSessionInfo.LocalName

        DT.TableName = PushType
        DT.Columns.Add("DOMAIN")
        DT.Columns.Add("FR_USR_ID")
        DT.Columns.Add("TO_USR_ID")
        DT.Columns.Add("MSG")
        DT.Columns.Add("FR_USR_NAME")
        DT.Columns.Add("MSG_CODE")

        Ds.Tables.Add(DT)


        If Not SearchKey Is Nothing Then
            DT = New DataTable
            DT.Rows.Add()
            For Each key In SearchKey.Keys
                DT.Columns.Add(key)
                DT.Rows(0)(key) = SearchKey(key)
            Next
            DT.TableName = "SearchKey"
            Ds.Tables.Add(DT)
        End If

        Return Ds
    End Function

    '신규 글 등록시 해당 유저에게 알림 ( Navigate 기능 )
    ' msg 는 MsgCode 가 있다면 Msg는 무시후 MsgCode에 대한 메세지를 전송
    Public Sub PushToUserMsg(ByVal ToUserID As String, ByVal MsgCode As String, ByVal Msg As String, Optional ByVal SearchKey As Dictionary(Of String, String) = Nothing)
        Try
            If ipEndPoint Is Nothing Then Exit Sub
            If Msg = "" And MsgCode = "" Then Exit Sub

            Dim Ds As DataSet = GetSendDataSet("PushToUserMsg", SearchKey)
            Dim Dt As DataTable = Ds.Tables("PushToUserMsg")

            Dim Domain As String = Common.SavedSessionDomain
            Dim UserID As String = ClientSessionInfo.UserID
            Dim UserName As String = ClientSessionInfo.LocalName

            Dt.Rows.Add()
            Dt.Rows(0)("DOMAIN") = Domain
            Dt.Rows(0)("FR_USR_ID") = UserID
            Dt.Rows(0)("TO_USR_ID") = ToUserID
            Dt.Rows(0)("MSG") = Msg
            Dt.Rows(0)("FR_USR_NAME") = UserName
            Dt.Rows(0)("MSG_CODE") = MsgCode 

            ' Dt.Rows.Add(Domain, UserID, ToUserID, Msg, MsgCode)

            PushMsg(Ds.GetXml)

        Catch ex As Exception

        End Try
    End Sub

    '신규 글 등록시 유저에게 알림
    Public Sub PushRegisterMsg(ByVal MsgCode As String, ByVal Msg As String)
        Try
            If ipEndPoint Is Nothing Then Exit Sub
            If Msg = "" And MsgCode = "" Then Exit Sub


            Dim Ds As DataSet = GetSendDataSet("PushRegisterMsg")
            Dim DT As DataTable = Ds.Tables("PushRegisterMsg")

            Dim Domain As String = Common.SavedSessionDomain
            Dim UserID As String = ClientSessionInfo.UserID
            Dim UserName As String = ClientSessionInfo.LocalName

            DT.Rows.Add()
            DT.Rows(0)("DOMAIN") = Domain
            DT.Rows(0)("FR_USR_ID") = UserID 
            DT.Rows(0)("MSG") = Msg
            DT.Rows(0)("FR_USR_NAME") = UserName
            DT.Rows(0)("MSG_CODE") = MsgCode

            ' DT.Rows.Add(Domain, UserID, "", Msg, MsgCode)

            Ds.Tables.Add(DT)
            PushMsg(Ds.GetXml)

        Catch ex As Exception

        End Try
    End Sub
     
    Private Sub PushMsg(ByVal DataInfo As String)
        Try
            
            Dim ByteMessage() As Byte = System.Text.Encoding.Default.GetBytes(DataInfo)

            If clientSocket.Connected = True Then
                clientSocket.BeginSendTo(ByteMessage, 0, ByteMessage.Length, SocketFlags.None, ipEndPoint, New AsyncCallback(AddressOf SendMsg), clientSocket)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OnRecieve(ByVal ar As IAsyncResult)
        Dim client As Socket = ar.AsyncState

        Try
             
            Dim dd As Object = client.Available
            If client.Connected Then

                client.EndReceive(ar)
                Dim bytesRec As Byte() = byteData

                Dim message As String = System.Text.Encoding.Default.GetString(bytesRec)
                Read(message)
                ReDim byteData(1023)
                clientSocket.BeginReceive(byteData, 0, byteData.Length, SocketFlags.None, _
                                          New AsyncCallback(AddressOf OnRecieve), clientSocket)
            Else
                clientSocket.Dispose()
            End If
        Catch ex As Exception

        End Try


    End Sub
     
    Delegate Sub _Read(ByVal msg As String)
    Private Sub Read(ByVal msg As String)
        Dim MainForm As Object = Common.IMainForm
        MainForm.RcvMsg(msg)
        'Dim myThread As Threading.Thread
        'myThread = New Threading.Thread(AddressOf MainForm.MoveMostion)
        'myThread.Start()

        'Common.IMainForm
        'If InvokeRequired Then
        '    Invoke(New _Read(AddressOf Read), msg)
        '    Exit Sub
        'End If
        'RichTextBox1.Text &= msg
    End Sub

    Public Sub CloseClient()
        '20170403 김성은 중복체크 / 로그인시 중복 체크 
        Try
            Call MethodCallEx(MainForm, "YJIT.Biz", "ResetLogin", {""})
        Catch ex As Exception
        End Try

        '20230808 김성은 폼종료시 상태 관련 메세지 스킵처리
        Dim Imain As Object = Common.IMainForm
        For Each frm As Object In Imain.MdiChildren
            frm.DataState = UI.DataStates.None
        Next




        '## 마지막 로직 ##
        If clientSocket Is Nothing Then Exit Sub
        Try
            If clientSocket.Connected = True Then
                clientSocket.Disconnect(False)
            End If
        Catch ex As Exception
            clientSocket.Dispose()
        End Try
    End Sub

    Public Function Connected()

        If clientSocket Is Nothing Then Return False
        If clientSocket.Connected = False Then Return False
         
        Return True
    End Function
End Module