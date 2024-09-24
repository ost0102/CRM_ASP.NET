<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgMessageMgt
    Inherits YJIT.SC.UI.SCView

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MsgMessageMgt))
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.btnSend = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnSendTest = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.WG_RCV = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_RCV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV_RCV_MSG_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_DOMAIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_SENDER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_SENDER_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_SEND_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_SYS_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_SYS_TYPE_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_MSG_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_MSG_TYPE_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_JOB_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_JOB_TYPE_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_MSG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_READ_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_KEY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_KEY2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_KEY3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_KEY4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_KEY5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_FIRST_MSG_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_PARENT_MSG_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_PARENT_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_RECEIVER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_READ_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_RECEIVER_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_RCV_FORM_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.rgRecvSend = New YJIT.SC.UI.SCControls.RadioGroup()
        Me.S_READ_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_DATE_TO = New YJIT.SC.UI.SCControls.DateBox()
        Me.S_DATE_FROM = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label12 = New YJIT.SC.UI.SCControls.Label()
        Me.Label13 = New YJIT.SC.UI.SCControls.Label()
        Me.btnReadAll = New YJIT.SC.UI.SCControls.Button()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label14 = New YJIT.SC.UI.SCControls.Label()
        Me.WG_RCV_MSG_TYPE_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_READ = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_READ = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Label11 = New YJIT.SC.UI.SCControls.Label()
        Me.Label10 = New YJIT.SC.UI.SCControls.Label()
        Me.Label8 = New YJIT.SC.UI.SCControls.Label()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.Label5 = New YJIT.SC.UI.SCControls.Label()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.lblReceiver = New YJIT.SC.UI.SCControls.Label()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.WG_RCV_MSG = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_RCV_KEY5 = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_RCV_KEY4 = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_RCV_KEY3 = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_RCV_KEY2 = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_RCV_KEY1 = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_RCV_JOB_TYPE_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_RCV_SEND_DATE = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_RCV_SENDER_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.tabMessage = New DevExpress.XtraTab.XtraTabControl()
        Me.tpReceive = New DevExpress.XtraTab.XtraTabPage()
        Me.tpSend = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.MSG_FIRST_MSG_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.MSG_PARENT_SEQ = New YJIT.SC.UI.SCControls.TextBox()
        Me.MSG_PARENT_MSG_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.MSG_RECEIVER = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label9 = New YJIT.SC.UI.SCControls.Label()
        Me.WG_USER = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_USER = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV_USER_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_USER_ENG_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_USER_LOC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_USER_EMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblReply = New YJIT.SC.UI.SCControls.Label()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.MSG_CONTENT = New YJIT.SC.UI.SCControls.TextBox()
        Me.tpMsgTest = New DevExpress.XtraTab.XtraTabPage()
        Me.T_JOB_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.T_MSG_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.T_SYS_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label15 = New YJIT.SC.UI.SCControls.Label()
        Me.Label16 = New YJIT.SC.UI.SCControls.Label()
        Me.Label27 = New YJIT.SC.UI.SCControls.Label()
        Me.Label26 = New YJIT.SC.UI.SCControls.Label()
        Me.Label17 = New YJIT.SC.UI.SCControls.Label()
        Me.Label18 = New YJIT.SC.UI.SCControls.Label()
        Me.Label19 = New YJIT.SC.UI.SCControls.Label()
        Me.Label20 = New YJIT.SC.UI.SCControls.Label()
        Me.Label21 = New YJIT.SC.UI.SCControls.Label()
        Me.Label25 = New YJIT.SC.UI.SCControls.Label()
        Me.Label22 = New YJIT.SC.UI.SCControls.Label()
        Me.Label23 = New YJIT.SC.UI.SCControls.Label()
        Me.Label30 = New YJIT.SC.UI.SCControls.Label()
        Me.Label29 = New YJIT.SC.UI.SCControls.Label()
        Me.Label28 = New YJIT.SC.UI.SCControls.Label()
        Me.Label24 = New YJIT.SC.UI.SCControls.Label()
        Me.btnSendElvisToAll = New YJIT.SC.UI.SCControls.Button()
        Me.T_MSG = New YJIT.SC.UI.SCControls.TextBox()
        Me.T_PARENT_MSG_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.T_FIRST_MSG_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.T_KEY5 = New YJIT.SC.UI.SCControls.TextBox()
        Me.T_KEY4 = New YJIT.SC.UI.SCControls.TextBox()
        Me.T_KEY3 = New YJIT.SC.UI.SCControls.TextBox()
        Me.T_KEY2 = New YJIT.SC.UI.SCControls.TextBox()
        Me.T_KEY1 = New YJIT.SC.UI.SCControls.TextBox()
        Me.T_RECEIVER = New YJIT.SC.UI.SCControls.TextBox()
        Me.T_SENDER = New YJIT.SC.UI.SCControls.TextBox()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG_RCV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_RCV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.rgRecvSend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.WG_READ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_READ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMessage.SuspendLayout()
        Me.tpReceive.SuspendLayout()
        Me.tpSend.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.WG_USER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_USER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpMsgTest.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.LookAndFeel.SkinName = "Blue"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullText = "N"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.LookAndFeel.SkinName = "Blue"
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.PopupFormSize = New System.Drawing.Size(380, 50)
        Me.RepositoryItemMemoExEdit2.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.RepositoryItemMemoExEdit2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        Me.RepositoryItemMemoExEdit2.WordWrap = False
        '
        'btnSend
        '
        Me.btnSend.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSend.Location = New System.Drawing.Point(380, 536)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(70, 25)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "&Send"
        Me.Localizer1.SetWordID(Me.btnSend, "&Send")
        '
        'palAutoButton
        '
        Me.palAutoButton.Location = New System.Drawing.Point(3, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(958, 32)
        Me.palAutoButton.TabIndex = 1
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnSendTest
        '
        Me.btnSendTest.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSendTest.Location = New System.Drawing.Point(341, 462)
        Me.btnSendTest.Name = "btnSendTest"
        Me.btnSendTest.Size = New System.Drawing.Size(70, 25)
        Me.btnSendTest.TabIndex = 3
        Me.btnSendTest.Text = "&Send"
        Me.Localizer1.SetWordID(Me.btnSendTest, "&Send")
        '
        'btnSearch
        '
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(407, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnSend, "&Send")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSendTest, "&Send")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.WG_RCV, "")
        Me.Localizer1.SetWordID(Me.GV_RCV_MSG_ID, "Message ID")
        Me.Localizer1.SetWordID(Me.GV_RCV_SEQ, "Seq")
        Me.Localizer1.SetWordID(Me.GV_RCV_DOMAIN, "Domain")
        Me.Localizer1.SetWordID(Me.GV_RCV_SENDER, "Sender")
        Me.Localizer1.SetWordID(Me.GV_RCV_SENDER_NM, "Sender")
        Me.Localizer1.SetWordID(Me.GV_RCV_SEND_DATE, "Send Date")
        Me.Localizer1.SetWordID(Me.GV_RCV_SYS_TYPE, "System")
        Me.Localizer1.SetWordID(Me.GV_RCV_SYS_TYPE_NM, "System")
        Me.Localizer1.SetWordID(Me.GV_RCV_MSG_TYPE, "Type")
        Me.Localizer1.SetWordID(Me.GV_RCV_MSG_TYPE_NM, "Type")
        Me.Localizer1.SetWordID(Me.GV_RCV_JOB_TYPE, "Job")
        Me.Localizer1.SetWordID(Me.GV_RCV_JOB_TYPE_NM, "Job")
        Me.Localizer1.SetWordID(Me.GV_RCV_MSG, "Message")
        Me.Localizer1.SetWordID(Me.GV_RCV_READ_YN, "Read")
        Me.Localizer1.SetWordID(Me.GV_RCV_KEY1, "Reference 1")
        Me.Localizer1.SetWordID(Me.GV_RCV_KEY2, "Reference 2")
        Me.Localizer1.SetWordID(Me.GV_RCV_KEY3, "Reference 3")
        Me.Localizer1.SetWordID(Me.GV_RCV_KEY4, "Reference 4")
        Me.Localizer1.SetWordID(Me.GV_RCV_KEY5, "Reference 5")
        Me.Localizer1.SetWordID(Me.GV_RCV_FIRST_MSG_ID, "First Message")
        Me.Localizer1.SetWordID(Me.GV_RCV_PARENT_MSG_ID, "Parent Message")
        Me.Localizer1.SetWordID(Me.GV_RCV_PARENT_SEQ, "Parent SEQ")
        Me.Localizer1.SetWordID(Me.GV_RCV_RECEIVER, "Receiver")
        Me.Localizer1.SetWordID(Me.GV_RCV_READ_DATE, "Read Date")
        Me.Localizer1.SetWordID(Me.GV_RCV_RECEIVER_NM, "Receiver")
        Me.Localizer1.SetWordID(Me.GV_RCV_FORM_NM, "Form Name")
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.rgRecvSend, "R")
        Me.Localizer1.SetWordID(Me.S_READ_YN, "--Select--")
        Me.Localizer1.SetWordID(Me.S_DATE_TO, "")
        Me.Localizer1.SetWordID(Me.S_DATE_FROM, "")
        Me.Localizer1.SetWordID(Me.Label12, "~")
        Me.Localizer1.SetWordID(Me.Label13, "Receive Date")
        Me.Localizer1.SetWordID(Me.btnReadAll, "Read All")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.Label14, "Type")
        Me.Localizer1.SetWordID(Me.WG_RCV_MSG_TYPE_NM, "")
        Me.Localizer1.SetWordID(Me.WG_READ, "")
        Me.Localizer1.SetWordID(Me.GridColumn7, "Message ID")
        Me.Localizer1.SetWordID(Me.GridColumn8, "SEQ")
        Me.Localizer1.SetWordID(Me.GridColumn9, "Receiver")
        Me.Localizer1.SetWordID(Me.GridColumn10, "Date")
        Me.Localizer1.SetWordID(Me.Label11, "Message")
        Me.Localizer1.SetWordID(Me.Label10, "Reference 5")
        Me.Localizer1.SetWordID(Me.Label8, "Reference 4")
        Me.Localizer1.SetWordID(Me.Label7, "Reference 3")
        Me.Localizer1.SetWordID(Me.Label6, "Reference 2")
        Me.Localizer1.SetWordID(Me.Label5, "Reference 1")
        Me.Localizer1.SetWordID(Me.Label4, "Job")
        Me.Localizer1.SetWordID(Me.Label3, "Send Date")
        Me.Localizer1.SetWordID(Me.lblReceiver, "Receiver")
        Me.Localizer1.SetWordID(Me.Label2, "Sender")
        Me.Localizer1.SetWordID(Me.WG_RCV_MSG, "")
        Me.Localizer1.SetWordID(Me.WG_RCV_KEY5, "")
        Me.Localizer1.SetWordID(Me.WG_RCV_KEY4, "")
        Me.Localizer1.SetWordID(Me.WG_RCV_KEY3, "")
        Me.Localizer1.SetWordID(Me.WG_RCV_KEY2, "")
        Me.Localizer1.SetWordID(Me.WG_RCV_KEY1, "")
        Me.Localizer1.SetWordID(Me.WG_RCV_JOB_TYPE_NM, "")
        Me.Localizer1.SetWordID(Me.WG_RCV_SEND_DATE, "")
        Me.Localizer1.SetWordID(Me.WG_RCV_SENDER_NM, "")
        Me.Localizer1.SetWordID(Me.tabMessage, "")
        Me.Localizer1.SetWordID(Me.tpReceive, "Receive")
        Me.Localizer1.SetWordID(Me.tpSend, "Send")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.MSG_FIRST_MSG_ID, "")
        Me.Localizer1.SetWordID(Me.MSG_PARENT_SEQ, "")
        Me.Localizer1.SetWordID(Me.MSG_PARENT_MSG_ID, "")
        Me.Localizer1.SetWordID(Me.MSG_RECEIVER, "")
        Me.Localizer1.SetWordID(Me.Label9, "Message")
        Me.Localizer1.SetWordID(Me.WG_USER, "")
        Me.Localizer1.SetWordID(Me.GV_USER_USR_ID, "UserID")
        Me.Localizer1.SetWordID(Me.GV_USER_ENG_NM, "User Name")
        Me.Localizer1.SetWordID(Me.GV_USER_LOC_NM, "Local Name")
        Me.Localizer1.SetWordID(Me.GV_USER_EMAIL, "EMAIL")
        Me.Localizer1.SetWordID(Me.lblReply, "Reply Message")
        Me.Localizer1.SetWordID(Me.Label1, "Receiver")
        Me.Localizer1.SetWordID(Me.MSG_CONTENT, "")
        Me.Localizer1.SetWordID(Me.tpMsgTest, "Message Test")
        Me.Localizer1.SetWordID(Me.T_JOB_TYPE, "")
        Me.Localizer1.SetWordID(Me.T_MSG_TYPE, "Push")
        Me.Localizer1.SetWordID(Me.T_SYS_TYPE, "ELVIS->ELVIS")
        Me.Localizer1.SetWordID(Me.Label15, "Type")
        Me.Localizer1.SetWordID(Me.Label16, "Message")
        Me.Localizer1.SetWordID(Me.Label27, "Parent MsgID")
        Me.Localizer1.SetWordID(Me.Label26, "First MsgID")
        Me.Localizer1.SetWordID(Me.Label17, "Reference 5")
        Me.Localizer1.SetWordID(Me.Label18, "Reference 4")
        Me.Localizer1.SetWordID(Me.Label19, "Reference 3")
        Me.Localizer1.SetWordID(Me.Label20, "Reference 2")
        Me.Localizer1.SetWordID(Me.Label21, "Reference 1")
        Me.Localizer1.SetWordID(Me.Label25, "Job Type")
        Me.Localizer1.SetWordID(Me.Label22, "Msg Type")
        Me.Localizer1.SetWordID(Me.Label23, "Receiver")
        Me.Localizer1.SetWordID(Me.Label30, "WEB->ELVIS 전송시에 MsgID를 동일하게 넣어서 전송")
        Me.Localizer1.SetWordID(Me.Label29, "WEB->ELVIS : ADMIN / ELVIS->ELVIS/WEB : nnow@yjit.co.kr")
        Me.Localizer1.SetWordID(Me.Label28, "WEB->ELVIS : nnow@yjit.co.kr / ELVIS->ELVIS/WEB : ADMIN")
        Me.Localizer1.SetWordID(Me.Label24, "Sender")
        Me.Localizer1.SetWordID(Me.btnSendElvisToAll, "&Send(ElvisToAll)")
        Me.Localizer1.SetWordID(Me.T_MSG, "")
        Me.Localizer1.SetWordID(Me.T_PARENT_MSG_ID, "")
        Me.Localizer1.SetWordID(Me.T_FIRST_MSG_ID, "")
        Me.Localizer1.SetWordID(Me.T_KEY5, "")
        Me.Localizer1.SetWordID(Me.T_KEY4, "")
        Me.Localizer1.SetWordID(Me.T_KEY3, "")
        Me.Localizer1.SetWordID(Me.T_KEY2, "")
        Me.Localizer1.SetWordID(Me.T_KEY1, "")
        Me.Localizer1.SetWordID(Me.T_RECEIVER, "")
        Me.Localizer1.SetWordID(Me.T_SENDER, "")
        '
        'WG_RCV
        '
        Me.WG_RCV.AllowClientBinding = True
        Me.WG_RCV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_RCV.DeleteRowConfirmation = True
        Me.WG_RCV.DisplayCurrentRow = False
        Me.WG_RCV.IsDataStateAware = True
        Me.WG_RCV.Location = New System.Drawing.Point(0, 71)
        Me.WG_RCV.MainView = Me.GV_RCV
        Me.WG_RCV.Name = "WG_RCV"
        Me.WG_RCV.SaveLayout = False
        Me.WG_RCV.Size = New System.Drawing.Size(482, 497)
        Me.WG_RCV.TabIndex = 5
        Me.WG_RCV.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_RCV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_RCV})
        '
        'GV_RCV
        '
        Me.GV_RCV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV_RCV_MSG_ID, Me.GV_RCV_SEQ, Me.GV_RCV_DOMAIN, Me.GV_RCV_SENDER, Me.GV_RCV_SENDER_NM, Me.GV_RCV_SEND_DATE, Me.GV_RCV_SYS_TYPE, Me.GV_RCV_SYS_TYPE_NM, Me.GV_RCV_MSG_TYPE, Me.GV_RCV_MSG_TYPE_NM, Me.GV_RCV_JOB_TYPE, Me.GV_RCV_JOB_TYPE_NM, Me.GV_RCV_MSG, Me.GV_RCV_READ_YN, Me.GV_RCV_KEY1, Me.GV_RCV_KEY2, Me.GV_RCV_KEY3, Me.GV_RCV_KEY4, Me.GV_RCV_KEY5, Me.GV_RCV_FIRST_MSG_ID, Me.GV_RCV_PARENT_MSG_ID, Me.GV_RCV_PARENT_SEQ, Me.GV_RCV_RECEIVER, Me.GV_RCV_READ_DATE, Me.GV_RCV_RECEIVER_NM, Me.GV_RCV_FORM_NM})
        Me.GV_RCV.GridControl = Me.WG_RCV
        Me.GV_RCV.IndicatorWidth = 40
        Me.GV_RCV.Name = "GV_RCV"
        Me.GV_RCV.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_RCV.OptionsView.ColumnAutoWidth = False
        Me.GV_RCV.OptionsView.ShowGroupPanel = False
        '
        'GV_RCV_MSG_ID
        '
        Me.GV_RCV_MSG_ID.Caption = "Message ID"
        Me.GV_RCV_MSG_ID.FieldName = "MSG_ID"
        Me.GV_RCV_MSG_ID.Name = "GV_RCV_MSG_ID"
        Me.GV_RCV_MSG_ID.OptionsColumn.AllowEdit = False
        Me.GV_RCV_MSG_ID.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_MSG_ID, "Message ID")
        '
        'GV_RCV_SEQ
        '
        Me.GV_RCV_SEQ.Caption = "Seq"
        Me.GV_RCV_SEQ.FieldName = "SEQ"
        Me.GV_RCV_SEQ.Name = "GV_RCV_SEQ"
        Me.GV_RCV_SEQ.OptionsColumn.AllowEdit = False
        Me.GV_RCV_SEQ.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_SEQ, "Seq")
        '
        'GV_RCV_DOMAIN
        '
        Me.GV_RCV_DOMAIN.Caption = "Domain"
        Me.GV_RCV_DOMAIN.FieldName = "DOMAIN"
        Me.GV_RCV_DOMAIN.Name = "GV_RCV_DOMAIN"
        Me.Localizer1.SetWordID(Me.GV_RCV_DOMAIN, "Domain")
        '
        'GV_RCV_SENDER
        '
        Me.GV_RCV_SENDER.Caption = "Sender"
        Me.GV_RCV_SENDER.FieldName = "SENDER"
        Me.GV_RCV_SENDER.Name = "GV_RCV_SENDER"
        Me.GV_RCV_SENDER.OptionsColumn.AllowEdit = False
        Me.GV_RCV_SENDER.OptionsColumn.ReadOnly = True
        Me.GV_RCV_SENDER.Width = 131
        Me.Localizer1.SetWordID(Me.GV_RCV_SENDER, "Sender")
        '
        'GV_RCV_SENDER_NM
        '
        Me.GV_RCV_SENDER_NM.Caption = "Sender"
        Me.GV_RCV_SENDER_NM.FieldName = "SENDER_NM"
        Me.GV_RCV_SENDER_NM.Name = "GV_RCV_SENDER_NM"
        Me.GV_RCV_SENDER_NM.OptionsColumn.AllowEdit = False
        Me.GV_RCV_SENDER_NM.OptionsColumn.ReadOnly = True
        Me.GV_RCV_SENDER_NM.Visible = True
        Me.GV_RCV_SENDER_NM.VisibleIndex = 0
        Me.GV_RCV_SENDER_NM.Width = 119
        Me.Localizer1.SetWordID(Me.GV_RCV_SENDER_NM, "Sender")
        '
        'GV_RCV_SEND_DATE
        '
        Me.GV_RCV_SEND_DATE.Caption = "Send Date"
        Me.GV_RCV_SEND_DATE.FieldName = "SEND_DATE"
        Me.GV_RCV_SEND_DATE.Name = "GV_RCV_SEND_DATE"
        Me.GV_RCV_SEND_DATE.OptionsColumn.AllowEdit = False
        Me.GV_RCV_SEND_DATE.OptionsColumn.ReadOnly = True
        Me.GV_RCV_SEND_DATE.Width = 98
        Me.Localizer1.SetWordID(Me.GV_RCV_SEND_DATE, "Send Date")
        '
        'GV_RCV_SYS_TYPE
        '
        Me.GV_RCV_SYS_TYPE.Caption = "System"
        Me.GV_RCV_SYS_TYPE.FieldName = "SYS_TYPE"
        Me.GV_RCV_SYS_TYPE.Name = "GV_RCV_SYS_TYPE"
        Me.GV_RCV_SYS_TYPE.OptionsColumn.AllowEdit = False
        Me.GV_RCV_SYS_TYPE.OptionsColumn.AllowMove = False
        Me.GV_RCV_SYS_TYPE.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_SYS_TYPE, "System")
        '
        'GV_RCV_SYS_TYPE_NM
        '
        Me.GV_RCV_SYS_TYPE_NM.Caption = "System"
        Me.GV_RCV_SYS_TYPE_NM.FieldName = "SYS_TYPE_NM"
        Me.GV_RCV_SYS_TYPE_NM.Name = "GV_RCV_SYS_TYPE_NM"
        Me.GV_RCV_SYS_TYPE_NM.OptionsColumn.AllowEdit = False
        Me.GV_RCV_SYS_TYPE_NM.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_SYS_TYPE_NM, "System")
        '
        'GV_RCV_MSG_TYPE
        '
        Me.GV_RCV_MSG_TYPE.Caption = "Type"
        Me.GV_RCV_MSG_TYPE.FieldName = "MSG_TYPE"
        Me.GV_RCV_MSG_TYPE.Name = "GV_RCV_MSG_TYPE"
        Me.GV_RCV_MSG_TYPE.OptionsColumn.AllowEdit = False
        Me.GV_RCV_MSG_TYPE.OptionsColumn.ReadOnly = True
        Me.GV_RCV_MSG_TYPE.Visible = True
        Me.GV_RCV_MSG_TYPE.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GV_RCV_MSG_TYPE, "Type")
        '
        'GV_RCV_MSG_TYPE_NM
        '
        Me.GV_RCV_MSG_TYPE_NM.Caption = "Type"
        Me.GV_RCV_MSG_TYPE_NM.FieldName = "MSG_TYPE_NM"
        Me.GV_RCV_MSG_TYPE_NM.Name = "GV_RCV_MSG_TYPE_NM"
        Me.GV_RCV_MSG_TYPE_NM.OptionsColumn.AllowEdit = False
        Me.GV_RCV_MSG_TYPE_NM.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_MSG_TYPE_NM, "Type")
        '
        'GV_RCV_JOB_TYPE
        '
        Me.GV_RCV_JOB_TYPE.Caption = "Job"
        Me.GV_RCV_JOB_TYPE.FieldName = "JOB_TYPE"
        Me.GV_RCV_JOB_TYPE.Name = "GV_RCV_JOB_TYPE"
        Me.GV_RCV_JOB_TYPE.OptionsColumn.AllowEdit = False
        Me.GV_RCV_JOB_TYPE.OptionsColumn.ReadOnly = True
        Me.GV_RCV_JOB_TYPE.Width = 72
        Me.Localizer1.SetWordID(Me.GV_RCV_JOB_TYPE, "Job")
        '
        'GV_RCV_JOB_TYPE_NM
        '
        Me.GV_RCV_JOB_TYPE_NM.Caption = "Job"
        Me.GV_RCV_JOB_TYPE_NM.FieldName = "JOB_TYPE_NM"
        Me.GV_RCV_JOB_TYPE_NM.Name = "GV_RCV_JOB_TYPE_NM"
        Me.GV_RCV_JOB_TYPE_NM.OptionsColumn.AllowEdit = False
        Me.GV_RCV_JOB_TYPE_NM.OptionsColumn.AllowMove = False
        Me.GV_RCV_JOB_TYPE_NM.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_JOB_TYPE_NM, "Job")
        '
        'GV_RCV_MSG
        '
        Me.GV_RCV_MSG.Caption = "Message"
        Me.GV_RCV_MSG.FieldName = "MSG"
        Me.GV_RCV_MSG.Name = "GV_RCV_MSG"
        Me.GV_RCV_MSG.OptionsColumn.AllowEdit = False
        Me.GV_RCV_MSG.OptionsColumn.ReadOnly = True
        Me.GV_RCV_MSG.Visible = True
        Me.GV_RCV_MSG.VisibleIndex = 2
        Me.GV_RCV_MSG.Width = 183
        Me.Localizer1.SetWordID(Me.GV_RCV_MSG, "Message")
        '
        'GV_RCV_READ_YN
        '
        Me.GV_RCV_READ_YN.Caption = "Read"
        Me.GV_RCV_READ_YN.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV_RCV_READ_YN.FieldName = "READ_YN"
        Me.GV_RCV_READ_YN.Name = "GV_RCV_READ_YN"
        Me.GV_RCV_READ_YN.Visible = True
        Me.GV_RCV_READ_YN.VisibleIndex = 3
        Me.GV_RCV_READ_YN.Width = 37
        Me.Localizer1.SetWordID(Me.GV_RCV_READ_YN, "Read")
        '
        'GV_RCV_KEY1
        '
        Me.GV_RCV_KEY1.Caption = "Reference 1"
        Me.GV_RCV_KEY1.FieldName = "KEY1"
        Me.GV_RCV_KEY1.Name = "GV_RCV_KEY1"
        Me.GV_RCV_KEY1.OptionsColumn.AllowEdit = False
        Me.GV_RCV_KEY1.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_KEY1, "Reference 1")
        '
        'GV_RCV_KEY2
        '
        Me.GV_RCV_KEY2.Caption = "Reference 2"
        Me.GV_RCV_KEY2.FieldName = "KEY2"
        Me.GV_RCV_KEY2.Name = "GV_RCV_KEY2"
        Me.GV_RCV_KEY2.OptionsColumn.AllowEdit = False
        Me.GV_RCV_KEY2.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_KEY2, "Reference 2")
        '
        'GV_RCV_KEY3
        '
        Me.GV_RCV_KEY3.Caption = "Reference 3"
        Me.GV_RCV_KEY3.FieldName = "KEY3"
        Me.GV_RCV_KEY3.Name = "GV_RCV_KEY3"
        Me.GV_RCV_KEY3.OptionsColumn.AllowEdit = False
        Me.GV_RCV_KEY3.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_KEY3, "Reference 3")
        '
        'GV_RCV_KEY4
        '
        Me.GV_RCV_KEY4.Caption = "Reference 4"
        Me.GV_RCV_KEY4.FieldName = "KEY4"
        Me.GV_RCV_KEY4.Name = "GV_RCV_KEY4"
        Me.GV_RCV_KEY4.OptionsColumn.AllowEdit = False
        Me.GV_RCV_KEY4.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_KEY4, "Reference 4")
        '
        'GV_RCV_KEY5
        '
        Me.GV_RCV_KEY5.Caption = "Reference 5"
        Me.GV_RCV_KEY5.FieldName = "KEY5"
        Me.GV_RCV_KEY5.Name = "GV_RCV_KEY5"
        Me.GV_RCV_KEY5.OptionsColumn.AllowEdit = False
        Me.GV_RCV_KEY5.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_KEY5, "Reference 5")
        '
        'GV_RCV_FIRST_MSG_ID
        '
        Me.GV_RCV_FIRST_MSG_ID.Caption = "First Message"
        Me.GV_RCV_FIRST_MSG_ID.FieldName = "FIRST_MSG_ID"
        Me.GV_RCV_FIRST_MSG_ID.Name = "GV_RCV_FIRST_MSG_ID"
        Me.GV_RCV_FIRST_MSG_ID.OptionsColumn.AllowEdit = False
        Me.GV_RCV_FIRST_MSG_ID.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_FIRST_MSG_ID, "First Message")
        '
        'GV_RCV_PARENT_MSG_ID
        '
        Me.GV_RCV_PARENT_MSG_ID.Caption = "Parent Message"
        Me.GV_RCV_PARENT_MSG_ID.FieldName = "PARENT_MSG_ID"
        Me.GV_RCV_PARENT_MSG_ID.Name = "GV_RCV_PARENT_MSG_ID"
        Me.GV_RCV_PARENT_MSG_ID.OptionsColumn.AllowEdit = False
        Me.GV_RCV_PARENT_MSG_ID.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_PARENT_MSG_ID, "Parent Message")
        '
        'GV_RCV_PARENT_SEQ
        '
        Me.GV_RCV_PARENT_SEQ.Caption = "Parent SEQ"
        Me.GV_RCV_PARENT_SEQ.FieldName = "PARENT_SEQ"
        Me.GV_RCV_PARENT_SEQ.Name = "GV_RCV_PARENT_SEQ"
        Me.GV_RCV_PARENT_SEQ.OptionsColumn.AllowEdit = False
        Me.GV_RCV_PARENT_SEQ.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_PARENT_SEQ, "Parent SEQ")
        '
        'GV_RCV_RECEIVER
        '
        Me.GV_RCV_RECEIVER.Caption = "Receiver"
        Me.GV_RCV_RECEIVER.FieldName = "RECEIVER"
        Me.GV_RCV_RECEIVER.Name = "GV_RCV_RECEIVER"
        Me.GV_RCV_RECEIVER.OptionsColumn.AllowEdit = False
        Me.GV_RCV_RECEIVER.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_RECEIVER, "Receiver")
        '
        'GV_RCV_READ_DATE
        '
        Me.GV_RCV_READ_DATE.Caption = "Read Date"
        Me.GV_RCV_READ_DATE.FieldName = "READ_DATE"
        Me.GV_RCV_READ_DATE.Name = "GV_RCV_READ_DATE"
        Me.GV_RCV_READ_DATE.OptionsColumn.AllowEdit = False
        Me.GV_RCV_READ_DATE.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_READ_DATE, "Read Date")
        '
        'GV_RCV_RECEIVER_NM
        '
        Me.GV_RCV_RECEIVER_NM.Caption = "Receiver"
        Me.GV_RCV_RECEIVER_NM.FieldName = "RECEIVER_NM"
        Me.GV_RCV_RECEIVER_NM.Name = "GV_RCV_RECEIVER_NM"
        Me.Localizer1.SetWordID(Me.GV_RCV_RECEIVER_NM, "Receiver")
        '
        'GV_RCV_FORM_NM
        '
        Me.GV_RCV_FORM_NM.Caption = "Form Name"
        Me.GV_RCV_FORM_NM.FieldName = "FORM_NM"
        Me.GV_RCV_FORM_NM.Name = "GV_RCV_FORM_NM"
        Me.GV_RCV_FORM_NM.OptionsColumn.AllowEdit = False
        Me.GV_RCV_FORM_NM.OptionsColumn.AllowMove = False
        Me.GV_RCV_FORM_NM.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_RCV_FORM_NM, "Form Name")
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainerControl1.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.rgRecvSend)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.S_READ_YN)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.btnSearch)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.S_DATE_TO)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.S_DATE_FROM)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.btnReadAll)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.WG_RCV)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(953, 568)
        Me.SplitContainerControl1.SplitterPosition = 482
        Me.SplitContainerControl1.TabIndex = 8
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "SplitContainerControl1")
        '
        'rgRecvSend
        '
        Me.rgRecvSend.BindingPropertyName = "EditValue"
        Me.rgRecvSend.DefVal = "R"
        Me.rgRecvSend.EditValue = "R"
        Me.rgRecvSend.IsDataStateAware = True
        Me.rgRecvSend.Location = New System.Drawing.Point(8, 39)
        Me.rgRecvSend.Name = "rgRecvSend"
        Me.rgRecvSend.NextFocus = ""
        Me.rgRecvSend.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgRecvSend.Properties.Appearance.Options.UseBackColor = True
        Me.rgRecvSend.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgRecvSend.Properties.Columns = 2
        Me.rgRecvSend.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("R", "Received"), New DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sent")})
        Me.rgRecvSend.Size = New System.Drawing.Size(173, 27)
        Me.rgRecvSend.TabIndex = 16
        Me.Localizer1.SetWordID(Me.rgRecvSend, "R")
        '
        'S_READ_YN
        '
        Me.S_READ_YN.CodeType = ""
        Me.S_READ_YN.ColumnWidths = ""
        Me.S_READ_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_READ_YN.DataParams = ""
        Me.S_READ_YN.DefVal = "N"
        Me.S_READ_YN.DisplayMember = "NAME"
        Me.S_READ_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_READ_YN.FormattingEnabled = True
        Me.S_READ_YN.IsDataStateAware = True
        Me.S_READ_YN.ItemDelimiter = ","
        Me.S_READ_YN.ItemTextList = "Not Read"
        Me.S_READ_YN.ItemValueList = "N"
        Me.S_READ_YN.KeepIntegrity = True
        Me.S_READ_YN.Location = New System.Drawing.Point(3, 9)
        Me.S_READ_YN.Name = "S_READ_YN"
        Me.S_READ_YN.NextFocus = "S_DATE_FROM"
        Me.S_READ_YN.NullText = "Read"
        Me.S_READ_YN.SearchKeys = ""
        Me.S_READ_YN.Size = New System.Drawing.Size(85, 22)
        Me.S_READ_YN.TabIndex = 15
        Me.S_READ_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_READ_YN.ValueMember = "CODE"
        '
        'S_DATE_TO
        '
        Me.S_DATE_TO.BorderColor = System.Drawing.Color.Empty
        Me.S_DATE_TO.DefVal = ""
        Me.S_DATE_TO.IconVisible = True
        Me.S_DATE_TO.IsDataStateAware = True
        Me.S_DATE_TO.Location = New System.Drawing.Point(293, 9)
        Me.S_DATE_TO.Name = "S_DATE_TO"
        Me.S_DATE_TO.NextFocus = "btnSearch"
        Me.S_DATE_TO.Size = New System.Drawing.Size(100, 22)
        Me.S_DATE_TO.TabIndex = 13
        Me.Localizer1.SetWordID(Me.S_DATE_TO, "")
        '
        'S_DATE_FROM
        '
        Me.S_DATE_FROM.BorderColor = System.Drawing.Color.Empty
        Me.S_DATE_FROM.DefVal = ""
        Me.S_DATE_FROM.IconVisible = True
        Me.S_DATE_FROM.IsDataStateAware = True
        Me.S_DATE_FROM.Location = New System.Drawing.Point(170, 9)
        Me.S_DATE_FROM.Name = "S_DATE_FROM"
        Me.S_DATE_FROM.NextFocus = "S_DATE_TO"
        Me.S_DATE_FROM.Size = New System.Drawing.Size(100, 22)
        Me.S_DATE_FROM.TabIndex = 14
        Me.Localizer1.SetWordID(Me.S_DATE_FROM, "")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.LabelFor = Nothing
        Me.Label12.Location = New System.Drawing.Point(276, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 14)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "~"
        Me.Localizer1.SetWordID(Me.Label12, "~")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.LabelFor = Nothing
        Me.Label13.Location = New System.Drawing.Point(88, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 14)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Receive Date"
        Me.Localizer1.SetWordID(Me.Label13, "Receive Date")
        '
        'btnReadAll
        '
        Me.btnReadAll.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnReadAll.Location = New System.Drawing.Point(407, 40)
        Me.btnReadAll.Name = "btnReadAll"
        Me.btnReadAll.Size = New System.Drawing.Size(70, 25)
        Me.btnReadAll.TabIndex = 6
        Me.btnReadAll.Text = "Read All"
        Me.Localizer1.SetWordID(Me.btnReadAll, "Read All")
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label14)
        Me.PanelControl2.Controls.Add(Me.WG_RCV_MSG_TYPE_NM)
        Me.PanelControl2.Controls.Add(Me.WG_READ)
        Me.PanelControl2.Controls.Add(Me.Label11)
        Me.PanelControl2.Controls.Add(Me.Label10)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.Label7)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.lblReceiver)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.WG_RCV_MSG)
        Me.PanelControl2.Controls.Add(Me.WG_RCV_KEY5)
        Me.PanelControl2.Controls.Add(Me.WG_RCV_KEY4)
        Me.PanelControl2.Controls.Add(Me.WG_RCV_KEY3)
        Me.PanelControl2.Controls.Add(Me.WG_RCV_KEY2)
        Me.PanelControl2.Controls.Add(Me.WG_RCV_KEY1)
        Me.PanelControl2.Controls.Add(Me.WG_RCV_JOB_TYPE_NM)
        Me.PanelControl2.Controls.Add(Me.WG_RCV_SEND_DATE)
        Me.PanelControl2.Controls.Add(Me.WG_RCV_SENDER_NM)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(465, 568)
        Me.PanelControl2.TabIndex = 0
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'Label14
        '
        Me.Label14.LabelFor = Nothing
        Me.Label14.Location = New System.Drawing.Point(4, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 16)
        Me.Label14.TabIndex = 223
        Me.Label14.Text = "Type"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label14, "Type")
        '
        'WG_RCV_MSG_TYPE_NM
        '
        Me.WG_RCV_MSG_TYPE_NM.BorderColor = System.Drawing.Color.Empty
        Me.WG_RCV_MSG_TYPE_NM.DefVal = ""
        Me.WG_RCV_MSG_TYPE_NM.Enabled = False
        Me.WG_RCV_MSG_TYPE_NM.IsDataStateAware = True
        Me.WG_RCV_MSG_TYPE_NM.Location = New System.Drawing.Point(87, 61)
        Me.WG_RCV_MSG_TYPE_NM.MaxLength = 35
        Me.WG_RCV_MSG_TYPE_NM.Name = "WG_RCV_MSG_TYPE_NM"
        Me.WG_RCV_MSG_TYPE_NM.NextFocus = "HHC2"
        Me.WG_RCV_MSG_TYPE_NM.ReadOnly = True
        Me.WG_RCV_MSG_TYPE_NM.Size = New System.Drawing.Size(158, 22)
        Me.WG_RCV_MSG_TYPE_NM.TabIndex = 222
        Me.WG_RCV_MSG_TYPE_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'WG_READ
        '
        Me.WG_READ.AllowClientBinding = True
        Me.WG_READ.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_READ.DeleteRowConfirmation = True
        Me.WG_READ.DisplayCurrentRow = False
        Me.WG_READ.IsDataStateAware = True
        Me.WG_READ.Location = New System.Drawing.Point(87, 470)
        Me.WG_READ.MainView = Me.GV_READ
        Me.WG_READ.Name = "WG_READ"
        Me.WG_READ.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2, Me.RepositoryItemTextEdit1})
        Me.WG_READ.SaveLayout = False
        Me.WG_READ.Size = New System.Drawing.Size(370, 93)
        Me.WG_READ.TabIndex = 221
        Me.WG_READ.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_READ.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_READ})
        Me.WG_READ.Visible = False
        '
        'GV_READ
        '
        Me.GV_READ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GV_READ.GridControl = Me.WG_READ
        Me.GV_READ.IndicatorWidth = 40
        Me.GV_READ.Name = "GV_READ"
        Me.GV_READ.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_READ.OptionsView.ColumnAutoWidth = False
        Me.GV_READ.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Message ID"
        Me.GridColumn7.FieldName = "MSGID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn7, "Message ID")
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "SEQ"
        Me.GridColumn8.FieldName = "SEQ"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn8, "SEQ")
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Receiver"
        Me.GridColumn9.FieldName = "RECEIVER"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 141
        Me.Localizer1.SetWordID(Me.GridColumn9, "Receiver")
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Date"
        Me.GridColumn10.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn10.FieldName = "READ_DATE"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 111
        Me.Localizer1.SetWordID(Me.GridColumn10, "Date")
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "9999-99-99 99:99"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "N"
        '
        'Label11
        '
        Me.Label11.LabelFor = Nothing
        Me.Label11.Location = New System.Drawing.Point(4, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 16)
        Me.Label11.TabIndex = 220
        Me.Label11.Text = "Message"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label11, "Message")
        '
        'Label10
        '
        Me.Label10.LabelFor = Nothing
        Me.Label10.Location = New System.Drawing.Point(4, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 16)
        Me.Label10.TabIndex = 220
        Me.Label10.Text = "Reference 5"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label10, "Reference 5")
        '
        'Label8
        '
        Me.Label8.LabelFor = Nothing
        Me.Label8.Location = New System.Drawing.Point(4, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 220
        Me.Label8.Text = "Reference 4"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label8, "Reference 4")
        '
        'Label7
        '
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(4, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 220
        Me.Label7.Text = "Reference 3"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label7, "Reference 3")
        '
        'Label6
        '
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(4, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 220
        Me.Label6.Text = "Reference 2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label6, "Reference 2")
        '
        'Label5
        '
        Me.Label5.LabelFor = Nothing
        Me.Label5.Location = New System.Drawing.Point(4, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 220
        Me.Label5.Text = "Reference 1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label5, "Reference 1")
        '
        'Label4
        '
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(249, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Job"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label4, "Job")
        '
        'Label3
        '
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(4, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 220
        Me.Label3.Text = "Send Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label3, "Send Date")
        '
        'lblReceiver
        '
        Me.lblReceiver.LabelFor = Nothing
        Me.lblReceiver.Location = New System.Drawing.Point(4, 470)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(77, 14)
        Me.lblReceiver.TabIndex = 220
        Me.lblReceiver.Text = "Receiver"
        Me.lblReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblReceiver.Visible = False
        Me.Localizer1.SetWordID(Me.lblReceiver, "Receiver")
        '
        'Label2
        '
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "Sender"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "Sender")
        '
        'WG_RCV_MSG
        '
        Me.WG_RCV_MSG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_RCV_MSG.BorderColor = System.Drawing.Color.Empty
        Me.WG_RCV_MSG.DefVal = ""
        Me.WG_RCV_MSG.Enabled = False
        Me.WG_RCV_MSG.IsDataStateAware = True
        Me.WG_RCV_MSG.Location = New System.Drawing.Point(87, 229)
        Me.WG_RCV_MSG.MaxLength = 35
        Me.WG_RCV_MSG.Multiline = True
        Me.WG_RCV_MSG.Name = "WG_RCV_MSG"
        Me.WG_RCV_MSG.NextFocus = "HHC2"
        Me.WG_RCV_MSG.ReadOnly = True
        Me.WG_RCV_MSG.Size = New System.Drawing.Size(370, 235)
        Me.WG_RCV_MSG.TabIndex = 219
        Me.WG_RCV_MSG.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'WG_RCV_KEY5
        '
        Me.WG_RCV_KEY5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_RCV_KEY5.BorderColor = System.Drawing.Color.Empty
        Me.WG_RCV_KEY5.DefVal = ""
        Me.WG_RCV_KEY5.Enabled = False
        Me.WG_RCV_KEY5.IsDataStateAware = True
        Me.WG_RCV_KEY5.Location = New System.Drawing.Point(87, 201)
        Me.WG_RCV_KEY5.MaxLength = 35
        Me.WG_RCV_KEY5.Name = "WG_RCV_KEY5"
        Me.WG_RCV_KEY5.NextFocus = "HHC2"
        Me.WG_RCV_KEY5.ReadOnly = True
        Me.WG_RCV_KEY5.Size = New System.Drawing.Size(370, 22)
        Me.WG_RCV_KEY5.TabIndex = 219
        Me.WG_RCV_KEY5.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'WG_RCV_KEY4
        '
        Me.WG_RCV_KEY4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_RCV_KEY4.BorderColor = System.Drawing.Color.Empty
        Me.WG_RCV_KEY4.DefVal = ""
        Me.WG_RCV_KEY4.Enabled = False
        Me.WG_RCV_KEY4.IsDataStateAware = True
        Me.WG_RCV_KEY4.Location = New System.Drawing.Point(87, 173)
        Me.WG_RCV_KEY4.MaxLength = 35
        Me.WG_RCV_KEY4.Name = "WG_RCV_KEY4"
        Me.WG_RCV_KEY4.NextFocus = "HHC2"
        Me.WG_RCV_KEY4.ReadOnly = True
        Me.WG_RCV_KEY4.Size = New System.Drawing.Size(370, 22)
        Me.WG_RCV_KEY4.TabIndex = 219
        Me.WG_RCV_KEY4.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'WG_RCV_KEY3
        '
        Me.WG_RCV_KEY3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_RCV_KEY3.BorderColor = System.Drawing.Color.Empty
        Me.WG_RCV_KEY3.DefVal = ""
        Me.WG_RCV_KEY3.Enabled = False
        Me.WG_RCV_KEY3.IsDataStateAware = True
        Me.WG_RCV_KEY3.Location = New System.Drawing.Point(87, 145)
        Me.WG_RCV_KEY3.MaxLength = 35
        Me.WG_RCV_KEY3.Name = "WG_RCV_KEY3"
        Me.WG_RCV_KEY3.NextFocus = "HHC2"
        Me.WG_RCV_KEY3.ReadOnly = True
        Me.WG_RCV_KEY3.Size = New System.Drawing.Size(370, 22)
        Me.WG_RCV_KEY3.TabIndex = 219
        Me.WG_RCV_KEY3.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'WG_RCV_KEY2
        '
        Me.WG_RCV_KEY2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_RCV_KEY2.BorderColor = System.Drawing.Color.Empty
        Me.WG_RCV_KEY2.DefVal = ""
        Me.WG_RCV_KEY2.Enabled = False
        Me.WG_RCV_KEY2.IsDataStateAware = True
        Me.WG_RCV_KEY2.Location = New System.Drawing.Point(87, 117)
        Me.WG_RCV_KEY2.MaxLength = 35
        Me.WG_RCV_KEY2.Name = "WG_RCV_KEY2"
        Me.WG_RCV_KEY2.NextFocus = "HHC2"
        Me.WG_RCV_KEY2.ReadOnly = True
        Me.WG_RCV_KEY2.Size = New System.Drawing.Size(370, 22)
        Me.WG_RCV_KEY2.TabIndex = 219
        Me.WG_RCV_KEY2.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'WG_RCV_KEY1
        '
        Me.WG_RCV_KEY1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_RCV_KEY1.BorderColor = System.Drawing.Color.Empty
        Me.WG_RCV_KEY1.DefVal = ""
        Me.WG_RCV_KEY1.Enabled = False
        Me.WG_RCV_KEY1.IsDataStateAware = True
        Me.WG_RCV_KEY1.Location = New System.Drawing.Point(87, 89)
        Me.WG_RCV_KEY1.MaxLength = 35
        Me.WG_RCV_KEY1.Name = "WG_RCV_KEY1"
        Me.WG_RCV_KEY1.NextFocus = "HHC2"
        Me.WG_RCV_KEY1.ReadOnly = True
        Me.WG_RCV_KEY1.Size = New System.Drawing.Size(370, 22)
        Me.WG_RCV_KEY1.TabIndex = 219
        Me.WG_RCV_KEY1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'WG_RCV_JOB_TYPE_NM
        '
        Me.WG_RCV_JOB_TYPE_NM.BorderColor = System.Drawing.Color.Empty
        Me.WG_RCV_JOB_TYPE_NM.DefVal = ""
        Me.WG_RCV_JOB_TYPE_NM.Enabled = False
        Me.WG_RCV_JOB_TYPE_NM.IsDataStateAware = True
        Me.WG_RCV_JOB_TYPE_NM.Location = New System.Drawing.Point(314, 64)
        Me.WG_RCV_JOB_TYPE_NM.MaxLength = 35
        Me.WG_RCV_JOB_TYPE_NM.Name = "WG_RCV_JOB_TYPE_NM"
        Me.WG_RCV_JOB_TYPE_NM.NextFocus = "HHC2"
        Me.WG_RCV_JOB_TYPE_NM.ReadOnly = True
        Me.WG_RCV_JOB_TYPE_NM.Size = New System.Drawing.Size(143, 22)
        Me.WG_RCV_JOB_TYPE_NM.TabIndex = 219
        Me.WG_RCV_JOB_TYPE_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'WG_RCV_SEND_DATE
        '
        Me.WG_RCV_SEND_DATE.BorderColor = System.Drawing.Color.Empty
        Me.WG_RCV_SEND_DATE.DefVal = ""
        Me.WG_RCV_SEND_DATE.Enabled = False
        Me.WG_RCV_SEND_DATE.IsDataStateAware = True
        Me.WG_RCV_SEND_DATE.Location = New System.Drawing.Point(87, 33)
        Me.WG_RCV_SEND_DATE.MaxLength = 35
        Me.WG_RCV_SEND_DATE.Name = "WG_RCV_SEND_DATE"
        Me.WG_RCV_SEND_DATE.NextFocus = "HHC2"
        Me.WG_RCV_SEND_DATE.ReadOnly = True
        Me.WG_RCV_SEND_DATE.Size = New System.Drawing.Size(158, 22)
        Me.WG_RCV_SEND_DATE.TabIndex = 219
        Me.WG_RCV_SEND_DATE.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'WG_RCV_SENDER_NM
        '
        Me.WG_RCV_SENDER_NM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_RCV_SENDER_NM.BorderColor = System.Drawing.Color.Empty
        Me.WG_RCV_SENDER_NM.DefVal = ""
        Me.WG_RCV_SENDER_NM.Enabled = False
        Me.WG_RCV_SENDER_NM.IsDataStateAware = True
        Me.WG_RCV_SENDER_NM.Location = New System.Drawing.Point(87, 5)
        Me.WG_RCV_SENDER_NM.MaxLength = 35
        Me.WG_RCV_SENDER_NM.Name = "WG_RCV_SENDER_NM"
        Me.WG_RCV_SENDER_NM.NextFocus = "HHC2"
        Me.WG_RCV_SENDER_NM.ReadOnly = True
        Me.WG_RCV_SENDER_NM.Size = New System.Drawing.Size(370, 22)
        Me.WG_RCV_SENDER_NM.TabIndex = 219
        Me.WG_RCV_SENDER_NM.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'tabMessage
        '
        Me.tabMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMessage.Location = New System.Drawing.Point(3, 43)
        Me.tabMessage.Name = "tabMessage"
        Me.tabMessage.SelectedTabPage = Me.tpReceive
        Me.tabMessage.Size = New System.Drawing.Size(958, 595)
        Me.tabMessage.TabIndex = 56
        Me.tabMessage.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpReceive, Me.tpSend, Me.tpMsgTest})
        Me.Localizer1.SetWordID(Me.tabMessage, "")
        '
        'tpReceive
        '
        Me.tpReceive.Controls.Add(Me.SplitContainerControl1)
        Me.tpReceive.Name = "tpReceive"
        Me.tpReceive.Size = New System.Drawing.Size(953, 568)
        Me.tpReceive.Text = "Receive"
        Me.Localizer1.SetWordID(Me.tpReceive, "Receive")
        '
        'tpSend
        '
        Me.tpSend.Appearance.PageClient.BackColor = System.Drawing.Color.Silver
        Me.tpSend.Appearance.PageClient.Options.UseBackColor = True
        Me.tpSend.Controls.Add(Me.PanelControl1)
        Me.tpSend.Name = "tpSend"
        Me.tpSend.Size = New System.Drawing.Size(952, 566)
        Me.tpSend.Text = "Send"
        Me.Localizer1.SetWordID(Me.tpSend, "Send")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.MSG_FIRST_MSG_ID)
        Me.PanelControl1.Controls.Add(Me.MSG_PARENT_SEQ)
        Me.PanelControl1.Controls.Add(Me.MSG_PARENT_MSG_ID)
        Me.PanelControl1.Controls.Add(Me.MSG_RECEIVER)
        Me.PanelControl1.Controls.Add(Me.btnSend)
        Me.PanelControl1.Controls.Add(Me.Label9)
        Me.PanelControl1.Controls.Add(Me.WG_USER)
        Me.PanelControl1.Controls.Add(Me.lblReply)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.MSG_CONTENT)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(952, 566)
        Me.PanelControl1.TabIndex = 120
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'MSG_FIRST_MSG_ID
        '
        Me.MSG_FIRST_MSG_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MSG_FIRST_MSG_ID.BorderColor = System.Drawing.Color.Empty
        Me.MSG_FIRST_MSG_ID.DefVal = ""
        Me.MSG_FIRST_MSG_ID.Enabled = False
        Me.MSG_FIRST_MSG_ID.IsDataStateAware = True
        Me.MSG_FIRST_MSG_ID.Location = New System.Drawing.Point(271, 12)
        Me.MSG_FIRST_MSG_ID.MaxLength = 35
        Me.MSG_FIRST_MSG_ID.Name = "MSG_FIRST_MSG_ID"
        Me.MSG_FIRST_MSG_ID.NextFocus = "HHC2"
        Me.MSG_FIRST_MSG_ID.ReadOnly = True
        Me.MSG_FIRST_MSG_ID.Size = New System.Drawing.Size(13, 22)
        Me.MSG_FIRST_MSG_ID.TabIndex = 221
        Me.MSG_FIRST_MSG_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.MSG_FIRST_MSG_ID.Visible = False
        '
        'MSG_PARENT_SEQ
        '
        Me.MSG_PARENT_SEQ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MSG_PARENT_SEQ.BorderColor = System.Drawing.Color.Empty
        Me.MSG_PARENT_SEQ.DefVal = ""
        Me.MSG_PARENT_SEQ.Enabled = False
        Me.MSG_PARENT_SEQ.IsDataStateAware = True
        Me.MSG_PARENT_SEQ.Location = New System.Drawing.Point(251, 12)
        Me.MSG_PARENT_SEQ.MaxLength = 35
        Me.MSG_PARENT_SEQ.Name = "MSG_PARENT_SEQ"
        Me.MSG_PARENT_SEQ.NextFocus = "HHC2"
        Me.MSG_PARENT_SEQ.ReadOnly = True
        Me.MSG_PARENT_SEQ.Size = New System.Drawing.Size(13, 22)
        Me.MSG_PARENT_SEQ.TabIndex = 220
        Me.MSG_PARENT_SEQ.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.MSG_PARENT_SEQ.Visible = False
        '
        'MSG_PARENT_MSG_ID
        '
        Me.MSG_PARENT_MSG_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MSG_PARENT_MSG_ID.BorderColor = System.Drawing.Color.Empty
        Me.MSG_PARENT_MSG_ID.DefVal = ""
        Me.MSG_PARENT_MSG_ID.Enabled = False
        Me.MSG_PARENT_MSG_ID.IsDataStateAware = True
        Me.MSG_PARENT_MSG_ID.Location = New System.Drawing.Point(228, 12)
        Me.MSG_PARENT_MSG_ID.MaxLength = 35
        Me.MSG_PARENT_MSG_ID.Name = "MSG_PARENT_MSG_ID"
        Me.MSG_PARENT_MSG_ID.NextFocus = "HHC2"
        Me.MSG_PARENT_MSG_ID.ReadOnly = True
        Me.MSG_PARENT_MSG_ID.Size = New System.Drawing.Size(16, 22)
        Me.MSG_PARENT_MSG_ID.TabIndex = 220
        Me.MSG_PARENT_MSG_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.MSG_PARENT_MSG_ID.Visible = False
        '
        'MSG_RECEIVER
        '
        Me.MSG_RECEIVER.AllowDrop = True
        Me.MSG_RECEIVER.BorderColor = System.Drawing.Color.Silver
        Me.MSG_RECEIVER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MSG_RECEIVER.DefVal = ""
        Me.MSG_RECEIVER.IsDataStateAware = True
        Me.MSG_RECEIVER.Location = New System.Drawing.Point(74, 35)
        Me.MSG_RECEIVER.MaxLength = 100
        Me.MSG_RECEIVER.Multiline = True
        Me.MSG_RECEIVER.Name = "MSG_RECEIVER"
        Me.MSG_RECEIVER.NextFocus = "CC"
        Me.MSG_RECEIVER.Size = New System.Drawing.Size(376, 159)
        Me.MSG_RECEIVER.TabIndex = 0
        Me.MSG_RECEIVER.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'Label9
        '
        Me.Label9.LabelFor = Nothing
        Me.Label9.Location = New System.Drawing.Point(8, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 14)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Message"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label9, "Message")
        '
        'WG_USER
        '
        Me.WG_USER.AllowClientBinding = True
        Me.WG_USER.AllowDrop = True
        Me.WG_USER.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_USER.DeleteRowConfirmation = False
        Me.WG_USER.DisplayCurrentRow = False
        Me.WG_USER.IsDataStateAware = True
        Me.WG_USER.Location = New System.Drawing.Point(456, 5)
        Me.WG_USER.MainView = Me.GV_USER
        Me.WG_USER.Name = "WG_USER"
        Me.WG_USER.SaveLayout = False
        Me.WG_USER.Size = New System.Drawing.Size(491, 556)
        Me.WG_USER.TabIndex = 3
        Me.WG_USER.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_USER.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_USER, Me.GridView4, Me.GridView5})
        '
        'GV_USER
        '
        Me.GV_USER.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV_USER.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV_USER.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV_USER_USR_ID, Me.GV_USER_ENG_NM, Me.GV_USER_LOC_NM, Me.GV_USER_EMAIL})
        Me.GV_USER.GridControl = Me.WG_USER
        Me.GV_USER.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.GV_USER.Name = "GV_USER"
        Me.GV_USER.OptionsBehavior.Editable = False
        Me.GV_USER.OptionsBehavior.ReadOnly = True
        Me.GV_USER.OptionsCustomization.AllowGroup = False
        Me.GV_USER.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV_USER.OptionsFind.AlwaysVisible = True
        Me.GV_USER.OptionsFind.ShowCloseButton = False
        Me.GV_USER.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_USER.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GV_USER.OptionsSelection.MultiSelect = True
        Me.GV_USER.OptionsView.ColumnAutoWidth = False
        Me.GV_USER.OptionsView.ShowGroupPanel = False
        Me.GV_USER.OptionsView.ShowViewCaption = True
        Me.GV_USER.ViewCaption = "  User"
        '
        'GV_USER_USR_ID
        '
        Me.GV_USER_USR_ID.Caption = "UserID"
        Me.GV_USER_USR_ID.FieldName = "USR_ID"
        Me.GV_USER_USR_ID.Name = "GV_USER_USR_ID"
        Me.GV_USER_USR_ID.Visible = True
        Me.GV_USER_USR_ID.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GV_USER_USR_ID, "UserID")
        '
        'GV_USER_ENG_NM
        '
        Me.GV_USER_ENG_NM.Caption = "User Name"
        Me.GV_USER_ENG_NM.FieldName = "ENG_NM"
        Me.GV_USER_ENG_NM.Name = "GV_USER_ENG_NM"
        Me.GV_USER_ENG_NM.Visible = True
        Me.GV_USER_ENG_NM.VisibleIndex = 1
        Me.GV_USER_ENG_NM.Width = 100
        Me.Localizer1.SetWordID(Me.GV_USER_ENG_NM, "User Name")
        '
        'GV_USER_LOC_NM
        '
        Me.GV_USER_LOC_NM.Caption = "Local Name"
        Me.GV_USER_LOC_NM.FieldName = "LOC_NM"
        Me.GV_USER_LOC_NM.Name = "GV_USER_LOC_NM"
        Me.GV_USER_LOC_NM.Visible = True
        Me.GV_USER_LOC_NM.VisibleIndex = 2
        Me.GV_USER_LOC_NM.Width = 114
        Me.Localizer1.SetWordID(Me.GV_USER_LOC_NM, "Local Name")
        '
        'GV_USER_EMAIL
        '
        Me.GV_USER_EMAIL.Caption = "EMAIL"
        Me.GV_USER_EMAIL.FieldName = "EMAIL"
        Me.GV_USER_EMAIL.Name = "GV_USER_EMAIL"
        Me.GV_USER_EMAIL.Visible = True
        Me.GV_USER_EMAIL.VisibleIndex = 3
        Me.GV_USER_EMAIL.Width = 136
        Me.Localizer1.SetWordID(Me.GV_USER_EMAIL, "EMAIL")
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.WG_USER
        Me.GridView4.Name = "GridView4"
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.WG_USER
        Me.GridView5.Name = "GridView5"
        '
        'lblReply
        '
        Me.lblReply.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.lblReply.LabelFor = Nothing
        Me.lblReply.Location = New System.Drawing.Point(71, 6)
        Me.lblReply.Name = "lblReply"
        Me.lblReply.Size = New System.Drawing.Size(151, 26)
        Me.lblReply.TabIndex = 116
        Me.lblReply.Text = "Reply Message"
        Me.lblReply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblReply.Visible = False
        Me.Localizer1.SetWordID(Me.lblReply, "Reply Message")
        '
        'Label1
        '
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(8, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Receiver"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "Receiver")
        '
        'MSG_CONTENT
        '
        Me.MSG_CONTENT.BorderColor = System.Drawing.Color.Silver
        Me.MSG_CONTENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MSG_CONTENT.DefVal = ""
        Me.MSG_CONTENT.IsDataStateAware = True
        Me.MSG_CONTENT.Location = New System.Drawing.Point(74, 200)
        Me.MSG_CONTENT.MaxLength = 4000
        Me.MSG_CONTENT.Multiline = True
        Me.MSG_CONTENT.Name = "MSG_CONTENT"
        Me.MSG_CONTENT.NextFocus = Nothing
        Me.MSG_CONTENT.Size = New System.Drawing.Size(376, 330)
        Me.MSG_CONTENT.TabIndex = 1
        Me.MSG_CONTENT.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'tpMsgTest
        '
        Me.tpMsgTest.Controls.Add(Me.T_JOB_TYPE)
        Me.tpMsgTest.Controls.Add(Me.T_MSG_TYPE)
        Me.tpMsgTest.Controls.Add(Me.T_SYS_TYPE)
        Me.tpMsgTest.Controls.Add(Me.Label15)
        Me.tpMsgTest.Controls.Add(Me.Label16)
        Me.tpMsgTest.Controls.Add(Me.Label27)
        Me.tpMsgTest.Controls.Add(Me.Label26)
        Me.tpMsgTest.Controls.Add(Me.Label17)
        Me.tpMsgTest.Controls.Add(Me.Label18)
        Me.tpMsgTest.Controls.Add(Me.Label19)
        Me.tpMsgTest.Controls.Add(Me.Label20)
        Me.tpMsgTest.Controls.Add(Me.Label21)
        Me.tpMsgTest.Controls.Add(Me.Label25)
        Me.tpMsgTest.Controls.Add(Me.Label22)
        Me.tpMsgTest.Controls.Add(Me.Label23)
        Me.tpMsgTest.Controls.Add(Me.Label30)
        Me.tpMsgTest.Controls.Add(Me.Label29)
        Me.tpMsgTest.Controls.Add(Me.Label28)
        Me.tpMsgTest.Controls.Add(Me.Label24)
        Me.tpMsgTest.Controls.Add(Me.btnSendElvisToAll)
        Me.tpMsgTest.Controls.Add(Me.btnSendTest)
        Me.tpMsgTest.Controls.Add(Me.T_MSG)
        Me.tpMsgTest.Controls.Add(Me.T_PARENT_MSG_ID)
        Me.tpMsgTest.Controls.Add(Me.T_FIRST_MSG_ID)
        Me.tpMsgTest.Controls.Add(Me.T_KEY5)
        Me.tpMsgTest.Controls.Add(Me.T_KEY4)
        Me.tpMsgTest.Controls.Add(Me.T_KEY3)
        Me.tpMsgTest.Controls.Add(Me.T_KEY2)
        Me.tpMsgTest.Controls.Add(Me.T_KEY1)
        Me.tpMsgTest.Controls.Add(Me.T_RECEIVER)
        Me.tpMsgTest.Controls.Add(Me.T_SENDER)
        Me.tpMsgTest.Name = "tpMsgTest"
        Me.tpMsgTest.Size = New System.Drawing.Size(952, 566)
        Me.tpMsgTest.Text = "Message Test"
        Me.Localizer1.SetWordID(Me.tpMsgTest, "Message Test")
        '
        'T_JOB_TYPE
        '
        Me.T_JOB_TYPE.CodeType = "YJIT.CodeService.CommonCode"
        Me.T_JOB_TYPE.ColumnWidths = ""
        Me.T_JOB_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.T_JOB_TYPE.DataParams = "GroupCode:'MSG01',NameType:'A'"
        Me.T_JOB_TYPE.DefVal = "SEA"
        Me.T_JOB_TYPE.DisplayMember = "NAME"
        Me.T_JOB_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.T_JOB_TYPE.FormattingEnabled = True
        Me.T_JOB_TYPE.IsDataStateAware = True
        Me.T_JOB_TYPE.ItemDelimiter = ","
        Me.T_JOB_TYPE.ItemTextList = ""
        Me.T_JOB_TYPE.ItemValueList = ""
        Me.T_JOB_TYPE.KeepIntegrity = False
        Me.T_JOB_TYPE.Location = New System.Drawing.Point(98, 126)
        Me.T_JOB_TYPE.Name = "T_JOB_TYPE"
        Me.T_JOB_TYPE.NextFocus = "T_KEY1"
        Me.T_JOB_TYPE.NullText = "-- Select --"
        Me.T_JOB_TYPE.SearchKeys = ""
        Me.T_JOB_TYPE.Size = New System.Drawing.Size(166, 22)
        Me.T_JOB_TYPE.TabIndex = 281
        Me.T_JOB_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.T_JOB_TYPE.ValueMember = "CODE"
        '
        'T_MSG_TYPE
        '
        Me.T_MSG_TYPE.CodeType = ""
        Me.T_MSG_TYPE.ColumnWidths = ""
        Me.T_MSG_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.T_MSG_TYPE.DataParams = ""
        Me.T_MSG_TYPE.DefVal = "P"
        Me.T_MSG_TYPE.DisplayMember = "NAME"
        Me.T_MSG_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.T_MSG_TYPE.FormattingEnabled = True
        Me.T_MSG_TYPE.IsDataStateAware = True
        Me.T_MSG_TYPE.ItemDelimiter = ","
        Me.T_MSG_TYPE.ItemTextList = "Push,Chat"
        Me.T_MSG_TYPE.ItemValueList = "P,C"
        Me.T_MSG_TYPE.KeepIntegrity = False
        Me.T_MSG_TYPE.Location = New System.Drawing.Point(98, 98)
        Me.T_MSG_TYPE.Name = "T_MSG_TYPE"
        Me.T_MSG_TYPE.NextFocus = "T_JOB_TYPE"
        Me.T_MSG_TYPE.NullText = "--Select--"
        Me.T_MSG_TYPE.SearchKeys = ""
        Me.T_MSG_TYPE.Size = New System.Drawing.Size(166, 22)
        Me.T_MSG_TYPE.TabIndex = 281
        Me.T_MSG_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.T_MSG_TYPE.ValueMember = "CODE"
        '
        'T_SYS_TYPE
        '
        Me.T_SYS_TYPE.CodeType = ""
        Me.T_SYS_TYPE.ColumnWidths = ""
        Me.T_SYS_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.T_SYS_TYPE.DataParams = ""
        Me.T_SYS_TYPE.DefVal = "EE"
        Me.T_SYS_TYPE.DisplayMember = "NAME"
        Me.T_SYS_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.T_SYS_TYPE.FormattingEnabled = True
        Me.T_SYS_TYPE.IsDataStateAware = True
        Me.T_SYS_TYPE.ItemDelimiter = ","
        Me.T_SYS_TYPE.ItemTextList = "ELVIS->ELVIS,ELVIS->WEB,WEB->ELVIS"
        Me.T_SYS_TYPE.ItemValueList = "EE,EW,WE"
        Me.T_SYS_TYPE.KeepIntegrity = False
        Me.T_SYS_TYPE.Location = New System.Drawing.Point(98, 70)
        Me.T_SYS_TYPE.Name = "T_SYS_TYPE"
        Me.T_SYS_TYPE.NextFocus = "T_MSG_TYPE"
        Me.T_SYS_TYPE.NullText = "--Select--"
        Me.T_SYS_TYPE.SearchKeys = ""
        Me.T_SYS_TYPE.Size = New System.Drawing.Size(166, 22)
        Me.T_SYS_TYPE.TabIndex = 281
        Me.T_SYS_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.T_SYS_TYPE.ValueMember = "CODE"
        '
        'Label15
        '
        Me.Label15.LabelFor = Nothing
        Me.Label15.Location = New System.Drawing.Point(15, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 16)
        Me.Label15.TabIndex = 243
        Me.Label15.Text = "Type"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label15, "Type")
        '
        'Label16
        '
        Me.Label16.LabelFor = Nothing
        Me.Label16.Location = New System.Drawing.Point(15, 358)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 16)
        Me.Label16.TabIndex = 236
        Me.Label16.Text = "Message"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label16, "Message")
        '
        'Label27
        '
        Me.Label27.LabelFor = Nothing
        Me.Label27.Location = New System.Drawing.Point(15, 328)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 16)
        Me.Label27.TabIndex = 237
        Me.Label27.Text = "Parent MsgID"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label27, "Parent MsgID")
        '
        'Label26
        '
        Me.Label26.LabelFor = Nothing
        Me.Label26.Location = New System.Drawing.Point(15, 300)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 16)
        Me.Label26.TabIndex = 237
        Me.Label26.Text = "First MsgID"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label26, "First MsgID")
        '
        'Label17
        '
        Me.Label17.LabelFor = Nothing
        Me.Label17.Location = New System.Drawing.Point(15, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 16)
        Me.Label17.TabIndex = 237
        Me.Label17.Text = "Reference 5"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label17, "Reference 5")
        '
        'Label18
        '
        Me.Label18.LabelFor = Nothing
        Me.Label18.Location = New System.Drawing.Point(15, 244)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 16)
        Me.Label18.TabIndex = 234
        Me.Label18.Text = "Reference 4"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label18, "Reference 4")
        '
        'Label19
        '
        Me.Label19.LabelFor = Nothing
        Me.Label19.Location = New System.Drawing.Point(15, 216)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 16)
        Me.Label19.TabIndex = 235
        Me.Label19.Text = "Reference 3"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label19, "Reference 3")
        '
        'Label20
        '
        Me.Label20.LabelFor = Nothing
        Me.Label20.Location = New System.Drawing.Point(15, 188)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 16)
        Me.Label20.TabIndex = 240
        Me.Label20.Text = "Reference 2"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label20, "Reference 2")
        '
        'Label21
        '
        Me.Label21.LabelFor = Nothing
        Me.Label21.Location = New System.Drawing.Point(15, 160)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 16)
        Me.Label21.TabIndex = 241
        Me.Label21.Text = "Reference 1"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label21, "Reference 1")
        '
        'Label25
        '
        Me.Label25.LabelFor = Nothing
        Me.Label25.Location = New System.Drawing.Point(33, 127)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 16)
        Me.Label25.TabIndex = 238
        Me.Label25.Text = "Job Type"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label25, "Job Type")
        '
        'Label22
        '
        Me.Label22.LabelFor = Nothing
        Me.Label22.Location = New System.Drawing.Point(21, 100)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 19)
        Me.Label22.TabIndex = 238
        Me.Label22.Text = "Msg Type"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label22, "Msg Type")
        '
        'Label23
        '
        Me.Label23.LabelFor = Nothing
        Me.Label23.Location = New System.Drawing.Point(15, 49)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 14)
        Me.Label23.TabIndex = 233
        Me.Label23.Text = "Receiver"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label23, "Receiver")
        '
        'Label30
        '
        Me.Label30.LabelFor = Nothing
        Me.Label30.Location = New System.Drawing.Point(270, 301)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(480, 15)
        Me.Label30.TabIndex = 233
        Me.Label30.Text = "WEB->ELVIS 전송시에 MsgID를 동일하게 넣어서 전송"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label30, "WEB->ELVIS 전송시에 MsgID를 동일하게 넣어서 전송")
        '
        'Label29
        '
        Me.Label29.LabelFor = Nothing
        Me.Label29.Location = New System.Drawing.Point(270, 48)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(480, 15)
        Me.Label29.TabIndex = 233
        Me.Label29.Text = "WEB->ELVIS : ADMIN / ELVIS->ELVIS/WEB : nnow@yjit.co.kr"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label29, "WEB->ELVIS : ADMIN / ELVIS->ELVIS/WEB : nnow@yjit.co.kr")
        '
        'Label28
        '
        Me.Label28.LabelFor = Nothing
        Me.Label28.Location = New System.Drawing.Point(270, 21)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(480, 15)
        Me.Label28.TabIndex = 233
        Me.Label28.Text = "WEB->ELVIS : nnow@yjit.co.kr / ELVIS->ELVIS/WEB : ADMIN"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label28, "WEB->ELVIS : nnow@yjit.co.kr / ELVIS->ELVIS/WEB : ADMIN")
        '
        'Label24
        '
        Me.Label24.LabelFor = Nothing
        Me.Label24.Location = New System.Drawing.Point(15, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 14)
        Me.Label24.TabIndex = 233
        Me.Label24.Text = "Sender"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label24, "Sender")
        '
        'btnSendElvisToAll
        '
        Me.btnSendElvisToAll.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSendElvisToAll.Location = New System.Drawing.Point(98, 462)
        Me.btnSendElvisToAll.Name = "btnSendElvisToAll"
        Me.btnSendElvisToAll.Size = New System.Drawing.Size(114, 25)
        Me.btnSendElvisToAll.TabIndex = 3
        Me.btnSendElvisToAll.Text = "&Send(ElvisToAll)"
        Me.Localizer1.SetWordID(Me.btnSendElvisToAll, "&Send(ElvisToAll)")
        '
        'T_MSG
        '
        Me.T_MSG.AllowDrop = True
        Me.T_MSG.BorderColor = System.Drawing.Color.Silver
        Me.T_MSG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_MSG.DefVal = ""
        Me.T_MSG.IsDataStateAware = True
        Me.T_MSG.Location = New System.Drawing.Point(98, 350)
        Me.T_MSG.MaxLength = 100
        Me.T_MSG.Multiline = True
        Me.T_MSG.Name = "T_MSG"
        Me.T_MSG.NextFocus = "btnSendTest"
        Me.T_MSG.Size = New System.Drawing.Size(313, 106)
        Me.T_MSG.TabIndex = 0
        Me.T_MSG.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'T_PARENT_MSG_ID
        '
        Me.T_PARENT_MSG_ID.AllowDrop = True
        Me.T_PARENT_MSG_ID.BorderColor = System.Drawing.Color.Silver
        Me.T_PARENT_MSG_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_PARENT_MSG_ID.DefVal = ""
        Me.T_PARENT_MSG_ID.IsDataStateAware = True
        Me.T_PARENT_MSG_ID.Location = New System.Drawing.Point(98, 322)
        Me.T_PARENT_MSG_ID.MaxLength = 100
        Me.T_PARENT_MSG_ID.Name = "T_PARENT_MSG_ID"
        Me.T_PARENT_MSG_ID.NextFocus = "T_MSG"
        Me.T_PARENT_MSG_ID.Size = New System.Drawing.Size(166, 22)
        Me.T_PARENT_MSG_ID.TabIndex = 0
        Me.T_PARENT_MSG_ID.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'T_FIRST_MSG_ID
        '
        Me.T_FIRST_MSG_ID.AllowDrop = True
        Me.T_FIRST_MSG_ID.BorderColor = System.Drawing.Color.Silver
        Me.T_FIRST_MSG_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_FIRST_MSG_ID.DefVal = ""
        Me.T_FIRST_MSG_ID.IsDataStateAware = True
        Me.T_FIRST_MSG_ID.Location = New System.Drawing.Point(98, 294)
        Me.T_FIRST_MSG_ID.MaxLength = 100
        Me.T_FIRST_MSG_ID.Name = "T_FIRST_MSG_ID"
        Me.T_FIRST_MSG_ID.NextFocus = "T_PARENT_MSG_ID"
        Me.T_FIRST_MSG_ID.Size = New System.Drawing.Size(166, 22)
        Me.T_FIRST_MSG_ID.TabIndex = 0
        Me.T_FIRST_MSG_ID.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'T_KEY5
        '
        Me.T_KEY5.AllowDrop = True
        Me.T_KEY5.BorderColor = System.Drawing.Color.Silver
        Me.T_KEY5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_KEY5.DefVal = ""
        Me.T_KEY5.IsDataStateAware = True
        Me.T_KEY5.Location = New System.Drawing.Point(98, 266)
        Me.T_KEY5.MaxLength = 100
        Me.T_KEY5.Name = "T_KEY5"
        Me.T_KEY5.NextFocus = "T_FIRST_MSG_ID"
        Me.T_KEY5.Size = New System.Drawing.Size(166, 22)
        Me.T_KEY5.TabIndex = 0
        Me.T_KEY5.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'T_KEY4
        '
        Me.T_KEY4.AllowDrop = True
        Me.T_KEY4.BorderColor = System.Drawing.Color.Silver
        Me.T_KEY4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_KEY4.DefVal = ""
        Me.T_KEY4.IsDataStateAware = True
        Me.T_KEY4.Location = New System.Drawing.Point(98, 238)
        Me.T_KEY4.MaxLength = 100
        Me.T_KEY4.Name = "T_KEY4"
        Me.T_KEY4.NextFocus = "T_KEY5"
        Me.T_KEY4.Size = New System.Drawing.Size(166, 22)
        Me.T_KEY4.TabIndex = 0
        Me.T_KEY4.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'T_KEY3
        '
        Me.T_KEY3.AllowDrop = True
        Me.T_KEY3.BorderColor = System.Drawing.Color.Silver
        Me.T_KEY3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_KEY3.DefVal = ""
        Me.T_KEY3.IsDataStateAware = True
        Me.T_KEY3.Location = New System.Drawing.Point(98, 210)
        Me.T_KEY3.MaxLength = 100
        Me.T_KEY3.Name = "T_KEY3"
        Me.T_KEY3.NextFocus = "T_KEY4"
        Me.T_KEY3.Size = New System.Drawing.Size(166, 22)
        Me.T_KEY3.TabIndex = 0
        Me.T_KEY3.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'T_KEY2
        '
        Me.T_KEY2.AllowDrop = True
        Me.T_KEY2.BorderColor = System.Drawing.Color.Silver
        Me.T_KEY2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_KEY2.DefVal = ""
        Me.T_KEY2.IsDataStateAware = True
        Me.T_KEY2.Location = New System.Drawing.Point(98, 182)
        Me.T_KEY2.MaxLength = 100
        Me.T_KEY2.Name = "T_KEY2"
        Me.T_KEY2.NextFocus = "T_KEY3"
        Me.T_KEY2.Size = New System.Drawing.Size(166, 22)
        Me.T_KEY2.TabIndex = 0
        Me.T_KEY2.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'T_KEY1
        '
        Me.T_KEY1.AllowDrop = True
        Me.T_KEY1.BorderColor = System.Drawing.Color.Silver
        Me.T_KEY1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_KEY1.DefVal = ""
        Me.T_KEY1.IsDataStateAware = True
        Me.T_KEY1.Location = New System.Drawing.Point(98, 154)
        Me.T_KEY1.MaxLength = 100
        Me.T_KEY1.Name = "T_KEY1"
        Me.T_KEY1.NextFocus = "T_KEY2"
        Me.T_KEY1.Size = New System.Drawing.Size(166, 22)
        Me.T_KEY1.TabIndex = 0
        Me.T_KEY1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'T_RECEIVER
        '
        Me.T_RECEIVER.AllowDrop = True
        Me.T_RECEIVER.BorderColor = System.Drawing.Color.Silver
        Me.T_RECEIVER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_RECEIVER.DefVal = ""
        Me.T_RECEIVER.IsDataStateAware = True
        Me.T_RECEIVER.Location = New System.Drawing.Point(98, 42)
        Me.T_RECEIVER.MaxLength = 100
        Me.T_RECEIVER.Name = "T_RECEIVER"
        Me.T_RECEIVER.NextFocus = "T_SYS_TYPE"
        Me.T_RECEIVER.Size = New System.Drawing.Size(166, 22)
        Me.T_RECEIVER.TabIndex = 0
        Me.T_RECEIVER.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'T_SENDER
        '
        Me.T_SENDER.AllowDrop = True
        Me.T_SENDER.BorderColor = System.Drawing.Color.Silver
        Me.T_SENDER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_SENDER.DefVal = ""
        Me.T_SENDER.IsDataStateAware = True
        Me.T_SENDER.Location = New System.Drawing.Point(98, 14)
        Me.T_SENDER.MaxLength = 100
        Me.T_SENDER.Name = "T_SENDER"
        Me.T_SENDER.NextFocus = "T_RECEIVER"
        Me.T_SENDER.Size = New System.Drawing.Size(166, 22)
        Me.T_SENDER.TabIndex = 0
        Me.T_SENDER.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'MsgMessageMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(964, 640)
        Me.Controls.Add(Me.tabMessage)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "MsgMessageMgt"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Message Management"
        Me.Localizer1.SetWordID(Me, "Message Management")
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG_RCV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_RCV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.rgRecvSend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.WG_READ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_READ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMessage.ResumeLayout(False)
        Me.tpReceive.ResumeLayout(False)
        Me.tpSend.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.WG_USER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_USER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpMsgTest.ResumeLayout(False)
        Me.tpMsgTest.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSend As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents WG_RCV As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV_RCV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents tabMessage As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpReceive As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpSend As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Public WithEvents MSG_RECEIVER As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents WG_USER As YJIT.SC.UI.SCControls.WebGrid
    Public WithEvents GV_USER As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV_USER_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_USER_ENG_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_USER_LOC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_USER_EMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label9 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GV_RCV_MSG_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_SENDER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_JOB_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_KEY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_KEY2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_KEY3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_KEY4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_KEY5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_MSG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_PARENT_MSG_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_PARENT_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_RECEIVER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_READ_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_READ_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents WG_RCV_MSG As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG_RCV_KEY5 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG_RCV_KEY4 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG_RCV_KEY3 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG_RCV_KEY2 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG_RCV_KEY1 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG_RCV_SEND_DATE As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG_RCV_SENDER_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label10 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label8 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label7 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label6 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label5 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label11 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV_RCV_SEND_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MSG_CONTENT As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents btnReadAll As YJIT.SC.UI.SCControls.Button
    Friend WithEvents S_DATE_TO As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents S_DATE_FROM As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label12 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label13 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_READ_YN As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GV_RCV_SENDER_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblReply As YJIT.SC.UI.SCControls.Label
    Friend WithEvents MSG_PARENT_SEQ As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents MSG_PARENT_MSG_ID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents rgRecvSend As YJIT.SC.UI.SCControls.RadioGroup
    Friend WithEvents lblReceiver As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV_RCV_RECEIVER_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_FORM_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG_READ As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV_READ As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents WG_RCV_JOB_TYPE_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents GV_RCV_JOB_TYPE_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MSG_FIRST_MSG_ID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents GV_RCV_FIRST_MSG_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_DOMAIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_SYS_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_MSG_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label14 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents WG_RCV_MSG_TYPE_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV_RCV_SYS_TYPE_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_RCV_MSG_TYPE_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSendTest As YJIT.SC.UI.SCControls.Button
    Friend WithEvents tpMsgTest As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label15 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label16 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label17 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label18 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label19 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label20 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label21 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label22 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label24 As YJIT.SC.UI.SCControls.Label
    Public WithEvents T_MSG As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents T_KEY5 As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents T_KEY4 As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents T_KEY3 As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents T_KEY2 As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents T_KEY1 As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents T_SENDER As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label23 As YJIT.SC.UI.SCControls.Label
    Public WithEvents T_RECEIVER As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label25 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label27 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label26 As YJIT.SC.UI.SCControls.Label
    Public WithEvents T_PARENT_MSG_ID As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents T_FIRST_MSG_ID As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents T_JOB_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Public WithEvents T_MSG_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Public WithEvents T_SYS_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label30 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label29 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label28 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnSendElvisToAll As YJIT.SC.UI.SCControls.Button
End Class
