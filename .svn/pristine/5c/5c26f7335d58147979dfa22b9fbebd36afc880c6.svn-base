Imports System.Reflection
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports YJIT.SC.UI

Public Class MsgMessageMgt
    Public paramMsgID As String = String.Empty
    Private GV1_PopUp As New PopupBase
    Public parentWindow As Object = Nothing '부모창 선언(여기서는 메인폼) 

#Region "=================Data logic actions==========="
    Private Sub SearchData()
        ClearView(AppliedRangeTypes.Except, {WG_USER, MSG_RECEIVER, MSG_CONTENT, S_READ_YN, S_DATE_FROM, S_DATE_TO, rgRecvSend})

        If S_READ_YN.SelectedValue <> "N" OrElse rgRecvSend.SelectedIndex = 1 Then
            If S_DATE_FROM.Text = "" Then
                MsgBoxLocalized("Date if required!")
                S_DATE_FROM.Focus()
            ElseIf S_DATE_TO.Text = "" Then
                MsgBoxLocalized("Date if required!")
                S_DATE_TO.Focus()
            End If
        End If

        Try
            Dim params() As String = {ClientSessionInfo.UserID, S_READ_YN.SelectedValue, S_DATE_FROM.Text, S_DATE_TO.Text, IIf(rgRecvSend.SelectedIndex = 0, "RECEIVED", "SENT")}
            Dim dsRet As DataSet
            'If rgRecvSend.SelectedIndex = 0 Then
            '    dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "Search", params)
            'Else
            '    dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "SearchSent", params)
            'End If
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "Search", params)

            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If

            Me.BindToDataset(dsRet, "Data")

            '파라미터로 전달된 MSGID 선택하기
            If paramMsgID <> String.Empty Then
                Dim selectRowHandle As Integer = GV_RCV.LocateByValue("MSG_ID", paramMsgID)
                If selectRowHandle >= 0 Then
                    '처음에 자동으로 선택된 읽음 표시를 없애줌
                    If selectRowHandle > 0 Then
                        GV_RCV.SetRowCellValue(0, "READ_YN", "N")
                    End If
                    GV_RCV.FocusedRowHandle = selectRowHandle
                    GV_RCV.PostEditor()
                    GV_RCV.UpdateCurrentRow()
                End If
                paramMsgID = String.Empty
            End If

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub SearchDataRead()
        Try
            Dim params() As String = {GV_RCV.GetRowCellValue(GV_RCV.FocusedRowHandle, "MSG_ID")}
            Dim dsRet As DataSet
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "SearchRead", params)

            Dim dr As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            Me.BindToDataset(dsRet, "Data")
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub

    Private Sub SendData()
        If MSG_RECEIVER.Text = "" Then
            MsgBoxLocalized("Receiver is required!")
            MSG_RECEIVER.Focus()
        End If

        If MSG_CONTENT.Text = "" Then
            MsgBoxLocalized("Content is required!")
            MSG_CONTENT.Focus()
        End If

        'Make string array
        Dim rcv() As String = MSG_RECEIVER.Text.Replace(vbCrLf, "").Split(";")
        Dim bSendMsg As Boolean = Common.SendMessageHub(SavedSessionDomain, ClientSessionInfo.UserID, rcv, "EE", "P", "", MSG_CONTENT.Text, MSG_FIRST_MSG_ID.Text, MSG_PARENT_MSG_ID.Text, "", "", "", "", "", "N", "N")

        If bSendMsg Then
            Me.Close() '메시지를 보내고 나서 창을 닫음
        End If
    End Sub

    Private Sub UserSearchData()
        '////////WCF Service Call/////////
        'Build up the parameter (array type)
        Dim dsRet As DataSet
        Dim drPairs As DataRow

        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "SearchUser", {})
            '//////Parsing WCF returned data///////
            drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            If drPairs("TrxCode") = "Y" Then
                Me.BindToDataset(dsRet, "Data")
            ElseIf drPairs("TrxCode") = "E" OrElse drPairs("TrxCode") = "N" Then
                Me.BindToDataset(dsRet, "Data")
                MsgBoxLocalized(drPairs("TrxMsg"))
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Try
        Finally
            'Close Wait Form
        End Try

        '/////Set post datastate/////////
        Me.DataState = UI.DataStates.None
    End Sub

    Private Sub UpdateNoReadMessageCount()
        S_READ_YN.Focus()
        GV_RCV.PostEditor()

        Dim dsRet As DataSet = Nothing
        Dim drPairs As DataRow = Nothing

        Try
            dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "UpdateNoReadMessageCount", {ClientSessionInfo.UserID, Me.ConvertToDataset})

            '//////Parsing WCF returned data///////
            drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

            If drPairs("TrxCode") <> "Y" Then
                MsgBox(drPairs("TrxMsg"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub SearchAuth()
    '    Dim param() As Object = {ClientSessionInfo.UserID}

    '    '////////Validation Check///////////
    '    Try
    '        '////////WCF Service Call/////////
    '        Dim dsRet As DataSet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "SearchAuth", param)
    '        Dim drPairs As DataRow

    '        '//////Parsing WCF returned data///////
    '        drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

    '        ClearView(UI.AppliedRangeTypes.Only, {WG_AUTH1})

    '        If drPairs("TrxCode") = "Y" Then
    '            Me.BindToDataset(dsRet, "Data")
    '        Else
    '            '없어도 메시지 띄우지 않음
    '            'MsgBox(drPairs("TrxMsg"))
    '        End If

    '        '/////Set post datastate/////////
    '        Me.DataState = UI.DataStates.Retrieved
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Exit Sub
    '    End Try
    'End Sub

    'Private Sub AuthAccept()

    '    Dim dsRet As DataSet
    '    Dim Msg As String = ""
    '    Dim drPairs As DataRow
    '    '----------------------------------------------------------------
    '    Try
    '        Dim param() As Object = {Me.ConvertToDataset}
    '        '////////WCF Service Call/////////
    '        dsRet = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.MsgMessageMgt", "SaveAuthMsg", param)

    '        '//////Parsing WCF returned data///////
    '        drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
    '        If drPairs("TrxCode") = "Y" Then
    '            SearchAuth()
    '            MsgBox(drPairs("TrxMsg"))
    '        Else
    '            MsgBox(drPairs("TrxMsg"))
    '            Exit Sub
    '        End If
    '        '/////Set post datastate/////////
    '        Me.DataState = UI.DataStates.Retrieved

    '        '---------------------------------------------------------------------
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Exit Sub
    '    End Try

    'End Sub
#End Region

#Region "=================Control Events================="
    Private Sub MsgMessageMgt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call DrawRowIndicator(GV_RCV)
    End Sub

    Private Sub MsgMessageMgt_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Call PageInit()
        Call PopUpInit()

        If ClientSessionInfo.AuthorizationType.Substring(0, 1) = 0 Then
            T_RECEIVER.Visible = True
            btnSendTest.Visible = True
        End If
    End Sub

    Private Sub MsgMessageMgt_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Call UpdateNoReadMessageCount()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Call SendData()
    End Sub

    Private Sub btnSendTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendTest.Click
        If String.IsNullOrEmpty(T_SENDER.Text) Then
            MsgBox("필수항목이 누락되었습니다.")
            T_SENDER.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(T_RECEIVER.Text) Then
            MsgBox("필수항목이 누락되었습니다.")
            T_RECEIVER.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(T_SYS_TYPE.SelectedValue) Then
            MsgBox("필수항목이 누락되었습니다.")
            T_SYS_TYPE.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(T_MSG_TYPE.SelectedValue) Then
            MsgBox("필수항목이 누락되었습니다.")
            T_MSG_TYPE.Focus()
            Exit Sub
        End If

        Dim bSendMsg As Boolean = Common.SendMessageHub(SavedSessionDomain, T_SENDER.Text, {T_RECEIVER.Text}, T_SYS_TYPE.SelectedValue, T_MSG_TYPE.SelectedValue, T_JOB_TYPE.SelectedValue, T_MSG.Text.Replace(Chr(13), "").Replace(Chr(10), "<br>"), T_FIRST_MSG_ID.Text, T_PARENT_MSG_ID.Text, T_KEY1.Text, T_KEY2.Text, T_KEY3.Text, T_KEY4.Text, T_KEY5.Text, "N", "N")
    End Sub

    Private Sub btnSendElvisToAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendElvisToAll.Click
        If String.IsNullOrEmpty(T_SENDER.Text) Then
            MsgBox("필수항목이 누락되었습니다.")
            T_SENDER.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(T_RECEIVER.Text) Then
            MsgBox("필수항목이 누락되었습니다.")
            T_RECEIVER.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(T_SYS_TYPE.SelectedValue) Then
            MsgBox("필수항목이 누락되었습니다.")
            T_SYS_TYPE.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(T_MSG_TYPE.SelectedValue) Then
            MsgBox("필수항목이 누락되었습니다.")
            T_MSG_TYPE.Focus()
            Exit Sub
        End If

        Dim bSendMsg As Boolean = Common.SendElvisToAll(SavedSessionDomain, T_SENDER.Text, {T_RECEIVER.Text}, T_SYS_TYPE.SelectedValue, T_MSG_TYPE.SelectedValue, T_JOB_TYPE.SelectedValue, T_MSG.Text.Replace(Chr(13), "").Replace(Chr(10), "<br>"), T_FIRST_MSG_ID.Text, T_PARENT_MSG_ID.Text, T_KEY1.Text, T_KEY2.Text, T_KEY3.Text, T_KEY4.Text, T_KEY5.Text, "N", "N")
    End Sub

    Private Sub GV_RCV_FocusedRowChanged(ByVal sender As Object, ByVal e As Views.Base.FocusedRowChangedEventArgs) Handles GV_RCV.FocusedRowChanged
        If GV_RCV.RowCount <= 0 Then Exit Sub
        If GV_RCV.FocusedRowHandle < 0 Then Exit Sub

        If GV_RCV.GetRowCellValue(e.FocusedRowHandle, "READ_YN") <> "Y" Then
            GV_RCV.SetRowCellValue(e.FocusedRowHandle, "READ_YN", "Y")
        End If

        Call SearchDataRead()
    End Sub

    Private Sub GV_RCV_CellValueChanged(ByVal sender As Object, ByVal e As Views.Base.CellValueChangedEventArgs) Handles GV_RCV.CellValueChanged
        Dim msgid As String = GV_RCV.GetRowCellValue(e.RowHandle, "MSG_ID").ToString

        '데이터를 읽었을 경우 해당 메시지 창을 닫음 
        If e.Column.FieldName = "READ_YN" AndAlso e.Value.ToString = "Y" Then
            parentWindow.CloseReadMessage(msgid)
        End If
    End Sub

    Private Sub btnReadAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReadAll.Click
        For i = 0 To GV_RCV.RowCount - 1
            GV_RCV.SetRowCellValue(i, "READ_YN", "Y")
        Next
    End Sub

    Private Sub S_READ_YN_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles S_READ_YN.SelectedIndexChanged
        If rgRecvSend.SelectedIndex <> 0 Then Exit Sub

        If S_READ_YN.SelectedValue = "N" Then
            S_DATE_FROM.Enabled = False
            S_DATE_TO.Enabled = False
        Else
            S_DATE_FROM.Enabled = True
            S_DATE_TO.Enabled = True
        End If
    End Sub

    Private Sub GV_USER_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles GV_USER.DoubleClick
        If GV_USER.RowCount <= 0 OrElse GV_USER.IsGroupRow(GV_USER.FocusedRowHandle) OrElse GV_USER.FocusedRowHandle < 0 Then Exit Sub

        AddReceiver(GV_USER.GetFocusedRowCellValue("USR_ID").ToString())
    End Sub

    Private Sub rgRecvSend_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgRecvSend.SelectedIndexChanged
        If rgRecvSend.SelectedIndex = 0 Then    'Received
            S_READ_YN.Visible = True
            GV_RCV_READ_YN.Visible = True
            lblReceiver.Visible = False
            S_DATE_FROM.Enabled = False
            S_DATE_TO.Enabled = False
            btnReadAll.Visible = True
            WG_READ.Visible = False
        Else    'Sent
            S_READ_YN.Visible = False
            GV_RCV_READ_YN.Visible = False
            lblReceiver.Visible = True
            S_DATE_FROM.Enabled = True
            S_DATE_TO.Enabled = True
            btnReadAll.Visible = False
            WG_READ.Visible = True
        End If

        Call SearchData()
    End Sub

    'Private Sub tabMessage_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabMessage.SelectedPageChanged
    '    '탭이동시 자동 SEARCH
    '    Select Case e.Page.Name
    '        Case "tpAuthMsg"
    '            Call SearchAuth()
    '    End Select
    'End Sub

    'Private Sub btnAuthMsgSend_Click(sender As Object, e As EventArgs)
    '    Call AuthAccept()
    'End Sub

#End Region

#Region "============Client Function============"
    Private Sub PageInit()
        Call SearchData()
        Call UserSearchData()

        S_DATE_FROM.Text = Now.AddMonths(-1).ToString("yyyyMMdd")
        S_DATE_TO.Text = Now.ToString("yyyyMMdd")

        'Find 박스에 포커스가 가는 것을 방지하기 위해서 해줌
        tabMessage.BeginUpdate()
        tabMessage.SelectedTabPageIndex = 1
        tabMessage.SelectedTabPageIndex = 0
        tabMessage.EndUpdate()

        '------------WG RCV----------------
        'GV_RCV.Columns("MSG_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit({"C:Chatting", "P:PushNotification", "M:Message"})
        GV_RCV.Columns("SYS_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:'R10',NameType:''")
        GV_RCV.Columns("MSG_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:'R11',NameType:''")
        GV_RCV.Columns("JOB_TYPE").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:'MSG01',NameType:''")

        ''------------Auth Message----------------
        'GV_AUTH1.Columns("OPT_ITEM1").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:'MSG01',NameType:''")
        'GV_AUTH1.Columns("OPT_ITEM2").ColumnEdit = GridFunc.GetRepositoryItemLookUpEdit("CommonCode", "GroupCode:'MSG02',NameType:''")

    End Sub

    Public Sub PopUpInit()
        Dim PopUp As New PopupBase
        GV1_PopUp.ItemAdd(Action.NavigateTo, "WG_RCV_Navi", "Go to reference")
        GV1_PopUp.ItemAdd(Action.Other, "WG_RCV_Reply", "Send Reply")
        GV1_PopUp.ItemAdd(Action.Excel, "WG_RCV_ExcelExport", "Excel Export")
        GV1_PopUp.PopUpInit(Me, WG_RCV)

        PopUp = New PopupBase
        PopUp.ItemAdd(Action.Other, "WG_USER_AddReceiver", "Add Receiver")
        PopUp.PopUpInit(Me, WG_USER)

        ''AuTH
        'PopUp = New PopupBase
        'PopUp.ItemAdd(Action.Addrow, "WG_Auth1_Addrow", "Add row")
        'PopUp.ItemAdd(Action.DeleteRow, "WG_Auth1_DeleteRow", "Delete Row")
        'PopUp.ItemAdd(Action.Excel, "WG_Auth_Excel", "Download Excel", True)
        'PopUp.PopUpInit(Me, WG_AUTH1)
    End Sub

    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim Key As String = dr("Key")
        Dim Sender As String = ""
        If Not dr("Sender") Is System.DBNull.Value Then Sender = dr("Sender")
        '화면 내에 여러 이벤트가 있을경우 case 문으로 Action 분계

        'Navigato 사용할떄
        'Dim frmMain As YJIT.SC.UI.IMainForm = 
        Dim frmMain As YJIT.SC.UI.IMainForm = SCView.MainFormInstance
        Dim fTarget As Object = Nothing
        Dim rowIndex As Integer = 0
        Try
            Select Case dr("Action")
                Case Action.NavigateTo
                    'frmMain = Me.Owner ' .MdiParent
                    Select Case Key
                        Case "WG_RCV_Navi"
                            If GV_RCV.RowCount <= 0 OrElse GV_RCV.FocusedRowHandle < 0 Then Exit Sub

                            frmMain = SCView.MainFormInstance
                            fTarget = Nothing

                            Dim form_nm As String = GV_RCV.GetRowCellValue(GV_RCV.FocusedRowHandle, "FORM_NM").ToString()
                            Dim key1 As String = GV_RCV.GetRowCellValue(GV_RCV.FocusedRowHandle, "KEY1").ToString()
                            Dim key2 As String = GV_RCV.GetRowCellValue(GV_RCV.FocusedRowHandle, "KEY2").ToString()
                            Dim key3 As String = GV_RCV.GetRowCellValue(GV_RCV.FocusedRowHandle, "KEY3").ToString()
                            Dim key4 As String = GV_RCV.GetRowCellValue(GV_RCV.FocusedRowHandle, "KEY4").ToString()
                            Dim key5 As String = GV_RCV.GetRowCellValue(GV_RCV.FocusedRowHandle, "KEY5").ToString()

                            fTarget = frmMain.NavigateTo(form_nm, NavigatedWindowModes.MDIWindow, True)
                            fTarget.SearchFromMsg(key1, key2, key3, key4, key5)
                    End Select

                Case Action.Other
                    Select Case Key
                        Case "WG_RCV_Reply"
                            If GV_RCV.RowCount <= 0 OrElse GV_RCV.FocusedRowHandle < 0 Then Exit Sub

                            Dim rp_sender As String = GV_RCV.GetFocusedRowCellValue("SENDER_NM").ToString()
                            Dim rp_msg As String = GV_RCV.GetFocusedRowCellValue("MSG").ToString
                            Dim rp_rcvdate As String = GV_RCV.GetFocusedRowCellValue("SEND_DATE").ToString

                            lblReply.Visible = True
                            MSG_RECEIVER.Text = ""
                            AddReceiver(GV_RCV.GetFocusedRowCellValue("SENDER").ToString)
                            MSG_FIRST_MSG_ID.Text = GV_RCV.GetFocusedRowCellValue("FIRST_MSG_ID").ToString()
                            MSG_PARENT_MSG_ID.Text = GV_RCV.GetFocusedRowCellValue("MSG_ID").ToString()
                            'Make original message
                            MSG_CONTENT.Text = vbCrLf & vbCrLf & "====== Message From " & rp_sender & "(" & rp_rcvdate & ")" & vbCrLf & vbCrLf
                            MSG_CONTENT.Text &= rp_msg

                            tabMessage.SelectedTabPageIndex = 1

                            MSG_CONTENT.Focus()
                            MSG_CONTENT.SelectionLength = 0
                        Case "WG_USER_AddReceiver"
                            Call AddReceiver(GV_USER.GetFocusedRowCellValue("USR_ID").ToString())
                    End Select
                Case Action.Addrow
                    Select Case Key
                        ''auth 사용
                        'Case "WG_Auth1_Addrow"
                        '    GV_AUTH1.SetRowCellValue(GV_AUTH1.FocusedRowHandle, "GRP_CD", "MSG03")
                        '    GV_AUTH1.SetRowCellValue(GV_AUTH1.FocusedRowHandle, "CD_NM", ClientSessionInfo.UserID)
                    End Select
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub MenuListBeforeShow(ByRef param As Dictionary(Of String, Boolean))
        If tpReceive.PageVisible = False Then Exit Sub

        'Dim job_type As String = GV_RCV.GetRowCellValue(GV_RCV.FocusedRowHandle, "JOB_TYPE").ToString()
        Dim msgtype As String = GV_RCV.GetRowCellValue(GV_RCV.FocusedRowHandle, "MSG_TYPE").ToString()
        Dim key1 As String = GV_RCV.GetRowCellValue(GV_RCV.FocusedRowHandle, "KEY1").ToString()
        'If key1 = "" OrElse job_type = "ZZ" Then
        '    param("WG_RCV_Navi") = False
        'Else
        '    param("WG_RCV_Navi") = True
        'End If

        'If job_type = "ZZ" Then
        '    param("WG_RCV_Reply") = True
        'Else
        '    param("WG_RCV_Reply") = False
        'End If

        If msgtype = "M" Then
            param("WG_RCV_Navi") = False
            param("WG_RCV_Reply") = True
        Else
            param("WG_RCV_Navi") = True
            param("WG_RCV_Reply") = False
        End If
    End Sub

    Private Function CountReceiver() As Integer
        '현재 수신자의 명수를 센다
        Dim iCnt As Integer = 0

        For Each c As Char In MSG_RECEIVER.Text
            If c = ";" Then
                iCnt += 1
            End If
        Next

        Return iCnt
    End Function

    Private Function AddReceiver(ByVal rcv As String) As Boolean
        Dim bRtn As Boolean = True

        '10명이 넘으면 추가 불가능.
        If CountReceiver() >= 10 Then
            MsgBox("You can select only 10 users.")
            bRtn = False
        Else
            If Not MSG_RECEIVER.Text.Contains(rcv) Then
                MSG_RECEIVER.Text &= rcv & ";" & vbCrLf
            End If
        End If

        Return bRtn
    End Function

    'Private Sub GV_AUTH1_KeyDown(sender As Object, e As KeyEventArgs)
    '    Try
    '        If e.KeyCode <> Keys.Enter Then Exit Sub
    '        If GV_AUTH1.RowCount < 1 Then Exit Sub
    '        If GV_AUTH1.FocusedRowHandle <> GV_AUTH1.RowCount - 1 Then Exit Sub

    '        Select Case GV_AUTH1.FocusedColumn.FieldName
    '            Case "OPT_ITEM2"
    '                WG_AUTH1.AddRow()
    '                GV_AUTH1.SetRowCellValue(GV_AUTH1.FocusedRowHandle, "CD_NM", ClientSessionInfo.UserID)
    '                GV_AUTH1.FocusedColumn = GV_AUTH1.Columns("OPT_ITEM1")
    '                e.Handled = True
    '        End Select

    '    Catch ex As Exception
    '        MsgBoxLocalized(ex.Message)
    '    End Try
    'End Sub
#End Region

#Region "============Drag & Drop Part============"
    Private dragStartGridInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = Nothing

    '==========================================================================================
    ' WG_USER(GV_USER) Event Start
    '==========================================================================================
    Private Sub WG_USER_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles WG_USER.MouseDown
        If e.Button = MouseButtons.Left AndAlso Control.ModifierKeys = Keys.None Then
            dragStartGridInfo = GV_USER.CalcHitInfo(New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub WG_USER_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles WG_USER.MouseMove
        If e.Button = MouseButtons.Left AndAlso dragStartGridInfo IsNot Nothing Then
            Dim dragRect As Rectangle = _
            New Rectangle(New Point(dragStartGridInfo.HitPoint.X - SystemInformation.DragSize.Width / 2, _
            dragStartGridInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize)

            If GV_USER.IsGroupRow(GV_USER.FocusedRowHandle) Then 'Group row는 이동할 수 없음
                Dim count = GV_USER.GetChildRowCount(GV_USER.FocusedRowHandle)
                For i As Integer = 0 To count - 1
                    Dim childRow As Integer = GV_USER.GetChildRowHandle(GV_USER.FocusedRowHandle, i)
                    GV_USER.SelectRow(childRow)
                Next i
            Else
                GV_USER.SelectRow(GV_USER.FocusedRowHandle)
            End If

            If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
                Dim datarow() As DataRow = GetDragData(GV_USER) '여러 줄이 선택될 수 있으므로 현재 Drag되는 데이터를 DataRow 배열로 가져온다
                If datarow IsNot Nothing Then
                    WG_USER.DoDragDrop(datarow, DragDropEffects.Copy)
                End If
            End If

            GV_USER.SelectRow(GV_USER.FocusedRowHandle)
        End If
    End Sub
    '==========================================================================================
    ' WG_USER(GV_USER) Event End
    '==========================================================================================

    '==========================================================================================
    ' Receiver Start
    '==========================================================================================
    Private Sub RECEIVER_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles MSG_RECEIVER.DragEnter, T_RECEIVER.DragEnter, T_KEY5.DragEnter, T_KEY4.DragEnter, T_KEY3.DragEnter, T_KEY2.DragEnter, T_KEY1.DragEnter, T_SENDER.DragEnter, T_MSG.DragEnter, T_FIRST_MSG_ID.DragEnter, T_PARENT_MSG_ID.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub RECEIVER_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles MSG_RECEIVER.DragDrop, T_RECEIVER.DragDrop, T_KEY5.DragDrop, T_KEY4.DragDrop, T_KEY3.DragDrop, T_KEY2.DragDrop, T_KEY1.DragDrop, T_SENDER.DragDrop, T_MSG.DragDrop, T_PARENT_MSG_ID.DragDrop, T_FIRST_MSG_ID.DragDrop
        Dim tb As TextBox = CType(sender, TextBox)
        Dim iCnt As Integer = 0

        If tb Is Nothing Then Exit Sub

        '그리드에서 가져온게 아니면 빠져나감(MenuTree 내부 이동은 MenuTree_AfterDragNode에서 처리)
        If TryCast(e.Data.GetData(GetType(DataRow())), DataRow()) Is Nothing Then
            Exit Sub
        End If

        'WG1_MouseMove 에서 저장한 DataRow 배열을 받아온다
        Dim drSource As DataRow() = CType(e.Data.GetData(GetType(DataRow())), DataRow())

        For i = 0 To drSource.Count() - 1
            If Not AddReceiver(drSource(i)("USR_ID").ToString) Then Exit For '입력에 실패하면 종료
        Next
    End Sub

    ' 선택된 row에 대한 데이터를 반환한다(Multi Row Select).
    Private Function GetDragData(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView) As DataRow()
        Dim selection() As Integer = view.GetSelectedRows()
        If selection Is Nothing Then
            Return Nothing
        End If

        Dim count As Integer = selection.Length
        Dim result(count - 1) As DataRow
        For i As Integer = 0 To count - 1
            If Not view.IsGroupRow(i) Then   '그룹 Row를 제외한 데이터 Row값만 가져온다.
                result(i) = view.GetDataRow(selection(i))
            End If
        Next i

        Return result
    End Function
    '==========================================================================================
    ' Receiver End
    '==========================================================================================
#End Region

    

End Class