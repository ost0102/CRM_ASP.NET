Imports YJIT.SC.UI
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraGrid.Views.Grid
Imports YJIT.SC.App.MainForm

Public Class CrmUserNoice

    Public NaviInfo As DataTable = Nothing
    Dim CloseFlag As Boolean = False
    Dim ViewThread As Threading.Thread 
    Public NoticeAction As NoticeAction = NoticeAction.Dialog

    Dim screenWidth As Integer
    Dim screenHeight As Integer

    Delegate Sub _MoveMostion()
    Delegate Sub _SubMoveMostion()

#Region "=================Data logic actions==========="

    Private Sub CloseForm()
        If CloseFlag = True Then
            Dim obj As Object = Common.IMainForm
            obj.CloseMainForm()
        End If

        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub MoveMostion()
        Timer1.Stop()
        If InvokeRequired Then
            Invoke(New _MoveMostion(AddressOf MoveMostion))
            Exit Sub
        End If

        Dim Width As String = Me.Size.Width
        Dim Height As String = Me.Size.Height


        Me.Activate()
        Me.SetDesktopLocation(screenWidth - Width - 13, screenHeight - 143)

        Dim myThread As Threading.Thread
        myThread = New Threading.Thread(AddressOf SubMoveMostion)
        myThread.Start()

        Timer2.Start()
    End Sub

    Private Sub SetLocation()
        screenWidth = Screen.PrimaryScreen.Bounds.Width
        screenHeight = Screen.PrimaryScreen.Bounds.Height

        Dim Width As String = Me.Size.Width
        Dim Height As String = Me.Size.Height

        Me.TopMost = True
        Me.SetDesktopLocation(screenWidth - Width, screenHeight)
    End Sub
    Private Sub FormShown()
        If NoticeAction = NoticeAction.Dialog Then
            SetLocation()
            Timer1.Start()
        ElseIf NoticeAction = NoticeAction.NoHidden Then
            SetLocation()
        ElseIf NoticeAction = NoticeAction.ShowDialog Then 
            Me.StartPosition = FormStartPosition.CenterParent
        End If
    End Sub

    '메세지 클릭시 처리 방법? 
    Private Sub MsgLabelClick()
        If Not NaviInfo Is Nothing Then
            Dim dr As DataRow = NaviInfo.Rows(0)
            Dim FormName As String = dr("FormName")
            Dim Key As String = ""
            For i = 0 To NaviInfo.Columns.Count - 1
                If NaviInfo.Columns(i).ColumnName <> "FormName" Then
                    Key = "AND " & NaviInfo.Columns(i).ColumnName & " = '" & NaviInfo.Rows(0)(NaviInfo.Columns(i).ColumnName) & "'"
                End If
            Next
            Dim Frm As Object = IMainForm.NavigateTo(FormName, NavigatedWindowModes.MDIWindow)
            Frm.NoticeSearchData(Key)
        End If


        Me.TopMost = False
        Me.Hide()
        Timer2.Start()
    End Sub

#End Region
#Region "=================Control Events==========="

    '열릴때 타이머
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ViewThread = New Threading.Thread(AddressOf MoveMostion)
        ViewThread.Start()
    End Sub

    ' 닫힐때 타이머
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        CloseForm()
    End Sub
     
    Private Sub CrmUserNoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        FormShown() 
    End Sub

    Private Sub Msg_Click(sender As System.Object, e As System.EventArgs) Handles Msg.Click
        MsgLabelClick() 
    End Sub 
    
    Public Sub SubMoveMostion()
        If InvokeRequired Then
            Invoke(New _SubMoveMostion(AddressOf SubMoveMostion))
            Exit Sub
        End If 
    End Sub

    Private Sub CrmUserNoice_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
        If NoticeAction = NavigatedWindowModes.Popup Then
            Me.Activate()
        End If
    End Sub

    Private Sub CrmUserNoice_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Me.TopMost = False
        Me.Dispose()
    End Sub

    Private Sub CrmUserNoice_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        MsgLabelClick()
    End Sub
#End Region

  
End Class