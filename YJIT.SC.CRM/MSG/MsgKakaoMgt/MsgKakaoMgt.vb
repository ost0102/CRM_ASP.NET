Imports System.Collections.Specialized
Imports System.IO
Imports System.Net
Imports System.Net.Json
Imports System.Text
Imports System.Web
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports YJIT.SC.UI
Public Class MsgKakaoMgt

    Private Sub MsgKakaoMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.Print("MsgKakaoMgt_Load")

        Call Common.DrawRowIndicator(GV1)

        Select Case ClientSessionInfo.AuthorizationType.Substring(0, 1)
            Case "0", "1"
                xtcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True
            Case Else
                xtcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        End Select

        If AuthSendType.SelectedIndex = 0 Then
            xtcMain.SelectedTabPage = xtpSite
        Else
            xtcMain.SelectedTabPage = xtpMsg
        End If

        For Each ctrl As Control In CType(SCView.MainFormInstance, MainForm).Controls
            If ctrl.Name = "PalBackground" Then
                For Each ctrl2 As Control In ctrl.Controls
                    If ctrl2.Name = "webviewPCKakao" Then
                        panelPCKakao.Controls.Add(CType(ctrl2, WebView2))
                        CType(ctrl2, WebView2).Visible = True
                        CType(ctrl2, WebView2).Dock = DockStyle.Fill
                        AddHandler CType(ctrl2, WebView2).TextChanged, AddressOf WebView_TextChanged
                        AddHandler CType(ctrl2, WebView2).WebMessageReceived, AddressOf WebView_WebMessageReceived
                        AddHandler CType(ctrl2, WebView2).StyleChanged, AddressOf WebView_StyleChanged
                        AddHandler CType(ctrl2, WebView2).SourceChanged, AddressOf WebView_SourceChanged
                        AddHandler CType(ctrl2, WebView2).HelpRequested, AddressOf WebView_HelpRequested
                        AddHandler CType(ctrl2, WebView2).HandleCreated, AddressOf WebView_HandleCreated
                        AddHandler CType(ctrl2, WebView2).CursorChanged, AddressOf WebView_CursorChanged
                        AddHandler CType(ctrl2, WebView2).CoreWebView2InitializationCompleted, AddressOf WebView_CoreWebView2InitializationCompleted
                    End If
                Next
            End If
        Next

    End Sub
    Private Sub MsgKakaoMgt_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Debug.Print("MsgKakaoMgt_Shown")

        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", Me.Localizer1.GetLocalizedString("PC카톡 자료 연동중..."))
            If Not String.IsNullOrEmpty(clientID.Text) Then
                dlg.Caption = String.Format("{0} 처리중...", lbl_authCD.Text)
                Call AuthCDData()
                'If xtcMain.SelectedTabPage.Name = xtpSite.Name Then
                '    Me.Size = New Drawing.Size(507, 587)
                'Else
                '    Me.Size = New Drawing.Size(507, 226)
                'End If
            End If
            If Not String.IsNullOrEmpty(authCD.Text) Then
                dlg.Caption = String.Format("{0} 처리중...", lbl_accessToken.Text)
                Call AccessTokenData()
            End If
            If Not String.IsNullOrEmpty(accessToken.Text) Then
                dlg.Caption = String.Format("{0} 처리중...", lbl_FriendList.Text)
                Call FriendListData()
            End If

            Call SendAutoKakao(dlg)
        End Using
    End Sub
    Public Sub SendAutoKakao(ByVal dlg As DevExpress.Utils.WaitDialogForm)
        If AuthSendType.SelectedIndex = 1 Then
            dlg.Caption = String.Format("{0} 자동 메세지 처리중...", lbl_FriendList.Text)

            Do While GV1.RowCount = 0
                Application.DoEvents()
                Threading.Thread.Sleep(1000)
            Loop

            If SendAutoMsg.YesNo = "Y" Then
                Call MsgData()
            End If
            If SendAutoMsgFriends.YesNo = "Y" Then
                Call MsgFriendData()
            End If
            Me.Close()
        End If
    End Sub
    Private Sub btnDevKakaoSite_Click(sender As Object, e As EventArgs) Handles btnDevKakaoSite.Click
        Debug.Print("btnDevKakaoSite_Click")
        'Clien ID 발급사이트
        System.Diagnostics.Process.Start("https://developers.kakao.com/")
    End Sub
    Private Sub btnAuthCD_Click(sender As Object, e As EventArgs) Handles btnAuthCD.Click
        Debug.Print("btnAuthCD_Click")
        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", Me.Localizer1.GetLocalizedString("인증코드 생성중..."))
            Call AuthCDData()
        End Using
    End Sub
    Private Sub AuthCDData()
        Debug.Print("AuthCDData")
        'WebBrowser1.Navigate("https://kauth.kakao.com/oauth/authorize?client_id=" & clientID.Text & "&redirect_uri=http://localhost&response_type=code&scope=talk_message,profile,friends")
        If Not CType(panelPCKakao.Controls(0), WebView2).CoreWebView2 Is Nothing Then
            CType(panelPCKakao.Controls(0), WebView2).CoreWebView2.Navigate("https://kauth.kakao.com/oauth/authorize?client_id=" & clientID.Text & "&redirect_uri=http://localhost&response_type=code&scope=talk_message,profile,friends")
        End If

        'apiResult.Text = String.Empty
        'Do Until WebBrowser1.ReadyState = WebBrowserReadyState.Complete
        '    Application.DoEvents()
        '    If Not String.IsNullOrEmpty(apiResult.Text) Then Exit Do
        'Loop
    End Sub
    Private Sub btnAccessToken_Click(sender As Object, e As EventArgs) Handles btnAccessToken.Click
        Debug.Print("btnAccessToken_Click")
        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", Me.Localizer1.GetLocalizedString("토큰 생성중..."))
            Call AccessTokenData()
        End Using
    End Sub
    Private Sub AccessTokenData()
        Debug.Print("AccessTokenData")
        If Not String.IsNullOrEmpty(accessToken.Text) Then Exit Sub

        '{"access_token""t2GlVkSp2xu48_YeyIQkGEyaQKaAiK-koZELlgopb7gAAAF4GXDqqQ","token_type":"bearer","refresh_token":"3XlUKF7fb-AJtZJLiCcsxAZo0aQK-qcPMsZm_wopb7gAAAF4GXDqpw","expires_in":21599,"refresh_token_expires_in":5183999}
        Dim apiResult As String = GetRestAPI("POST", "https://kauth.kakao.com/oauth/token", "", String.Format("grant_type=authorization_code&client_id={0}&redirect_uri=http://localhost&code={1}", clientID.Text, authCD.Text))
        Dim translatedText As String = String.Empty
        Dim jo As JObject = JObject.Parse(apiResult)
        accessToken.Text = jo("access_token").ToString
        refreshToken.Text = jo("refresh_token").ToString
    End Sub
    Private Sub btnMsg_Click(sender As Object, e As EventArgs) Handles btnMsg.Click
        Debug.Print("btnMsg_Click")
        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", Me.Localizer1.GetLocalizedString("나에게 메세지 보내기..."))
            Call MsgData()
            Me.Close()
        End Using
    End Sub
    Public Sub MsgData()
        Debug.Print("MsgData")
        Dim arrResLink As JsonArrayCollection = New JsonArrayCollection("link")
        Dim ResLink As JsonObjectCollection = New JsonObjectCollection()
        ResLink.Add(New JsonStringValue("web_url", "https://developers.kakao.com"))
        ResLink.Add(New JsonStringValue("mobile_web_url", "https://developers.kakao.com"))
        arrResLink.Add(ResLink)

        Dim Res As JsonObjectCollection = New JsonObjectCollection()
        Res.Add(New JsonStringValue("object_type", "text"))
        Res.Add(New JsonStringValue("text", kakaoMSG.Text))
        Res.Add(New JsonStringValue("link", ResLink.ToString))
        Res.Add(arrResLink)
        Res.Add(New JsonStringValue("button_title", "바로 확인"))

        Dim strResult As String = GetRestAPI("POST", "https://kapi.kakao.com/v2/api/talk/memo/default/send", accessToken.Text, String.Format("template_object={0}", Res.ToString.Replace("[", "").Replace("]", "")))
    End Sub
    Private Sub btnFriendList_Click(sender As Object, e As EventArgs) Handles btnFriendList.Click
        Debug.Print("btnFriendList_Click")
        Call FriendListData()
    End Sub
    Private Sub FriendListData()
        Debug.Print("FriendListData")
        Dim apiResult As String = GetRestAPI("GET", "https://kapi.kakao.com/v1/api/talk/friends", accessToken.Text, "friend_order=nickname&limit=9999&order=asc")

        Dim dt As DataTable = JsonToDatatable(apiResult)
        dt.Columns.Add("CHK", GetType(String))
        For Each row As DataRow In dt.Rows
            row("CHK") = "N"
        Next

        Dim arrKakaoID() As String = SendAutoMsgList.Text.ToString.Split(CChar(","))
        For Each kakaoID As String In arrKakaoID
            If String.IsNullOrEmpty(kakaoID) Then Continue For
            Dim rowList() As DataRow = dt.Select("id = '" & kakaoID & "'")
            If rowList.Length = 0 Then MsgBoxLocalized(String.Format("등록된 {0} id가 없습니다. 확인이 필요합니다.", kakaoID))

            For Each row As DataRow In rowList
                row("CHK") = "Y"
            Next
        Next

        WG1.DataSource = dt
    End Sub
    Private Sub btnMsgFriend_Click(sender As Object, e As EventArgs) Handles btnMsgFriend.Click
        Debug.Print("btnMsgFriend_Click")
        '친구에게 기본메세지 보내기
        '참고사항 https://developers.kakao.com/docs/latest/ko/message/rest-api#send-friend
        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", Me.Localizer1.GetLocalizedString("친구에게 기본메세지 보내기..."))
            Call MsgFriendData()
        End Using
    End Sub
    Private Sub MsgFriendData()
        Debug.Print("MsgFriendData")
        If CType(WG1.DataSource, DataTable).Select("CHK = 'Y'").Length = 0 Then
            MsgBoxLocalized("체크된 리스트가 없습니다.")
            Exit Sub
        End If

        Dim arrResLink As JsonArrayCollection = New JsonArrayCollection("link")
        Dim ResLink As JsonObjectCollection = New JsonObjectCollection()
        ResLink.Add(New JsonStringValue("web_url", "https://developers.kakao.com"))
        ResLink.Add(New JsonStringValue("mobile_web_url", "https://developers.kakao.com"))
        arrResLink.Add(ResLink)

        Dim Res As JsonObjectCollection = New JsonObjectCollection()
        Res.Add(New JsonStringValue("object_type", "text"))
        Res.Add(New JsonStringValue("text", kakaoMSG.Text))
        Res.Add(New JsonStringValue("link", ResLink.ToString))
        Res.Add(arrResLink)
        Res.Add(New JsonStringValue("button_title", "바로 확인"))

        Dim arrUUIDS As String = "["
        'arrUUIDS = arrUUIDS.Replace("""yvjN9cz8zfXZ4NDn1-XW4dL-yvLB9M38iQ""", """yvjN9cz8zfXZ4NDn1-XW4dL-yvLB9M38iQ"",""yv_J_cv9y_3I5NXj2urY7drj0PzI8MP2z_57""")
        'arrUUIDS = arrUUIDS & """" & GV1.GetFocusedDataRow("UUID").ToString & """"
        For Each row As DataRow In CType(WG1.DataSource, DataTable).Rows
            If row("CHK").ToString <> "Y" Then Continue For

            If Not arrUUIDS = "[" Then arrUUIDS &= ","
            arrUUIDS = arrUUIDS & """" & row("UUID").ToString & """"
        Next

        'arrUUIDS = arrUUIDS & """" & txtFriendList.Text.Replace(",", """,""") & """"
        'arrUUIDS = arrUUIDS & ",""" & "test" & """"
        arrUUIDS = arrUUIDS & "]"


        Dim strResult As String = GetRestAPI("POST", "https://kapi.kakao.com/v1/api/talk/friends/message/default/send", accessToken.Text, String.Format("receiver_uuids={0}&template_object={1}", arrUUIDS, Res.ToString.Replace("[", "").Replace("]", "")))
    End Sub

    'Dim cntReadyState As Integer = 0
    'Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    '    apiResult.Text &= Now.ToString("yyyy-MM-dd hh:mm:ss") & " / " & WebBrowser1.ReadyState & " / " & WebBrowser1.DocumentTitle & " / " & WebBrowser1.Url.Host & " / " & WebBrowser1.Url.LocalPath & vbNewLine
    '    Debug.Print(apiResult.Text)

    '    If WebBrowser1.Url.Query.StartsWith("?code") Then
    '        Dim query As NameValueCollection = HttpUtility.ParseQueryString(WebBrowser1.Url.Query)
    '        authCD.Text = query("code").ToString

    '        If optAuthSendType.SelectedIndex = 0 Then
    '            Me.Close()
    '        Else
    '            xtcMain.SelectedTabPage = xtpMsg

    '            If Not String.IsNullOrEmpty(authCD.Text) Then
    '                Call AccessTokenData()
    '            End If
    '            If Not String.IsNullOrEmpty(accessToken.Text) Then
    '                Call FriendListData()
    '            End If
    '        End If
    '    Else
    '        xtcMain.SelectedTabPage = xtpSite
    '    End If

    '    cntReadyState += 1
    'End Sub

    Private Function GetRestAPI(methodParam As String, urlParam As String, tokenParam As String, dataParam As String) As String
        Dim url As String = urlParam
        If methodParam.ToUpper = "GET" Then
            url = String.Format("{0}?{1}", urlParam, dataParam)
        End If

        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        If Not String.IsNullOrEmpty(tokenParam) Then
            request.Headers.Add("Authorization", String.Format("Bearer {0}", tokenParam))
        End If
        request.Method = methodParam.ToUpper
        request.ContentType = "application/x-www-form-urlencoded"


        Try
            If methodParam.ToUpper = "POST" Then
                Dim byteDataParams As Byte() = Encoding.UTF8.GetBytes(dataParam)
                request.ContentLength = byteDataParams.Length

                Dim st As Stream = request.GetRequestStream()
                st.Write(byteDataParams, 0, byteDataParams.Length)
                st.Close()
            End If

            Dim response As HttpWebResponse = Nothing
            Try
                response = CType(request.GetResponse(), HttpWebResponse)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Dim stream As Stream = response.GetResponseStream()
            Dim reader As StreamReader = New StreamReader(stream, Encoding.UTF8)
            Dim txtResponse As String = reader.ReadToEnd()
            stream.Close()
            response.Close()
            reader.Close()

            apiResult.Text = txtResponse
        Catch ex As Exception
            apiResult.Text = ex.Message
            Return apiResult.Text
        End Try

        Return apiResult.Text
    End Function
    Private Function JsonToDatatable(ByVal json As String) As DataTable
        Dim jsonLinq As JObject = JObject.Parse(json)
        Dim srcArray As JToken = jsonLinq.Descendants().Where(Function(d) TypeOf d Is JArray).First()
        Dim trgArray As JArray = New JArray()

        For Each row As JObject In srcArray.Children(Of JObject)()
            Dim cleanRow As JObject = New JObject()
            For Each column As JProperty In row.Properties()
                If TypeOf column.Value Is JValue Then
                    cleanRow.Add(column.Name, column.Value)
                End If
            Next
            trgArray.Add(cleanRow)
        Next

        Return JsonConvert.DeserializeObject(Of DataTable)(trgArray.ToString())
    End Function

    Private Sub WebView_SourceChanged(sender As Object, e As CoreWebView2SourceChangedEventArgs)
        Debug.Print("WebView_SourceChanged / " & CType(sender, WebView2).Source.AbsoluteUri)

        apiResult.Text = CType(sender, WebView2).Source.Query

        If apiResult.Text.StartsWith("?code=") Then
            Dim query As NameValueCollection = HttpUtility.ParseQueryString(apiResult.Text)
            authCD.Text = query("code").ToString

            'If optAuthSendType.SelectedIndex = 0 Then
            '    Debug.Print("WebView_SourceChanged / Me.Close()")
            '    Me.Close()
            'Else
            Debug.Print("WebView_SourceChanged / xtpMsg")
            xtcMain.SelectedTabPage = xtpMsg

            If Not String.IsNullOrEmpty(authCD.Text) Then
                Call AccessTokenData()
            End If
            If Not String.IsNullOrEmpty(accessToken.Text) Then
                Call FriendListData()
            End If
            'End If
        Else
            Debug.Print("WebView_SourceChanged / xtpSite")
            xtcMain.SelectedTabPage = xtpSite
        End If

    End Sub

    Private Sub WebView_CoreWebView2InitializationCompleted(sender As Object, e As CoreWebView2InitializationCompletedEventArgs)
        Debug.Print("WebView_CoreWebView2InitializationCompleted")
        Debug.Print(e.IsSuccess.ToString)
    End Sub

    Private Sub WebView_CursorChanged(sender As Object, e As EventArgs)
        Debug.Print("WebView_CursorChanged")
    End Sub

    Private Sub WebView_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs)
        Debug.Print("WebView_GiveFeedback")
    End Sub

    Private Sub WebView_HandleCreated(sender As Object, e As EventArgs)
        Debug.Print("WebView_HandleCreated")
    End Sub

    Private Sub WebView_HandleDestroyed(sender As Object, e As EventArgs)
        Debug.Print("WebView_HandleDestroyed")
    End Sub

    Private Sub WebView_HelpRequested(sender As Object, hlpevent As HelpEventArgs)
        Debug.Print("WebView_HelpRequested")
        Debug.Print(hlpevent.Handled.ToString)
        Debug.Print(hlpevent.MousePos.ToString)
    End Sub
    Private Sub WebView_StyleChanged(sender As Object, e As EventArgs)
        Debug.Print("WebView_StyleChanged")
    End Sub

    Private Sub WebView_WebMessageReceived(sender As Object, e As CoreWebView2WebMessageReceivedEventArgs)
        Debug.Print("WebView_WebMessageReceived")
        Debug.Print(e.Source)
        Debug.Print(e.TryGetWebMessageAsString)
        Debug.Print(e.WebMessageAsJson)
    End Sub
    Private Sub WebView_TextChanged(sender As Object, e As EventArgs)
        Debug.Print("WebView_TextChanged")
    End Sub

    Private Sub MsgKakaoMgt_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        For Each ctrl As Control In CType(SCView.MainFormInstance, MainForm).Controls
            If ctrl.Name = "PalBackground" Then
                For Each ctrl2 As Control In panelPCKakao.Controls
                    If ctrl2.Name = "webviewPCKakao" Then
                        RemoveHandler CType(ctrl2, WebView2).TextChanged, AddressOf WebView_TextChanged
                        RemoveHandler CType(ctrl2, WebView2).WebMessageReceived, AddressOf WebView_WebMessageReceived
                        RemoveHandler CType(ctrl2, WebView2).StyleChanged, AddressOf WebView_StyleChanged
                        RemoveHandler CType(ctrl2, WebView2).SourceChanged, AddressOf WebView_SourceChanged
                        RemoveHandler CType(ctrl2, WebView2).HelpRequested, AddressOf WebView_HelpRequested
                        RemoveHandler CType(ctrl2, WebView2).HandleCreated, AddressOf WebView_HandleCreated
                        RemoveHandler CType(ctrl2, WebView2).CursorChanged, AddressOf WebView_CursorChanged
                        RemoveHandler CType(ctrl2, WebView2).CoreWebView2InitializationCompleted, AddressOf WebView_CoreWebView2InitializationCompleted
                        CType(ctrl2, WebView2).Visible = False
                        ctrl.Controls.Add(CType(ctrl2, WebView2))
                    End If
                Next
            End If
        Next
    End Sub


    Private Sub AuthSendType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AuthSendType.SelectedIndexChanged
        MsgBox(AuthSendType.SelectedIndex)
    End Sub
End Class