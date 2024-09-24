<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComSendMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComSendMail))
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_CHK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_rpCHK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV1_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PIC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_EMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.S_CUST_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.S_CUST_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.lbl_S_CUST_CD = New YJIT.SC.UI.SCControls.Label()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.S_MNGT_NO = New YJIT.SC.UI.SCControls.TextLabel()
        Me.CUST_CD = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_MSG_TYPE2 = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_MSG_TYPE = New YJIT.SC.UI.SCControls.TextLabel()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnClear = New YJIT.SC.UI.SCControls.Button()
        Me.btnSend = New YJIT.SC.UI.SCControls.Button()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.SENDER = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_SENDER = New YJIT.SC.UI.SCControls.Label()
        Me.RECEIVER = New YJIT.SC.UI.SCControls.TextBox()
        Me.CC = New YJIT.SC.UI.SCControls.TextBox()
        Me.CONTENT = New YJIT.SC.UI.SCControls.TextBox()
        Me.SUBJECT = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_RECEIVER = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_CC = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_SUBJECT = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_CONTENT = New YJIT.SC.UI.SCControls.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SEND_SSL_YN = New YJIT.SC.UI.SCControls.TextLabel()
        Me.SEND_PORT = New YJIT.SC.UI.SCControls.TextLabel()
        Me.SEND_HOST = New YJIT.SC.UI.SCControls.TextLabel()
        Me.SEND_PWD = New YJIT.SC.UI.SCControls.TextLabel()
        Me.SEND_ID = New YJIT.SC.UI.SCControls.TextLabel()
        Me.lbl_MAIL_TYPE = New YJIT.SC.UI.SCControls.Label()
        Me.MAIL_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_FILE_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FILE_FULL_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SVR_FILE_FULL_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.xtcMain = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpMailList = New DevExpress.XtraTab.XtraTabPage()
        Me.xtpSendList = New DevExpress.XtraTab.XtraTabPage()
        Me.WG3 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV3_RECEIVER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_INS_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_CONTENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1_rpCHK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcMain.SuspendLayout()
        Me.xtpMailList.SuspendLayout()
        Me.xtpSendList.SuspendLayout()
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.AllowDrop = True
        Me.WG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = False
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(3, 33)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageComboBox1, Me.RepositoryItemTextEdit1, Me.GV1_rpCHK})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(365, 502)
        Me.WG1.TabIndex = 88
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_CHK, Me.GV1_SEQ, Me.GV1_PIC_NM, Me.GV1_EMAIL})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorzLines = False
        '
        'GV1_CHK
        '
        Me.GV1_CHK.Caption = " "
        Me.GV1_CHK.ColumnEdit = Me.GV1_rpCHK
        Me.GV1_CHK.FieldName = "CHK"
        Me.GV1_CHK.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_CHK.Name = "GV1_CHK"
        Me.GV1_CHK.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV1_CHK.Visible = True
        Me.GV1_CHK.VisibleIndex = 0
        Me.GV1_CHK.Width = 20
        Me.Localizer1.SetWordID(Me.GV1_CHK, " ")
        '
        'GV1_rpCHK
        '
        Me.GV1_rpCHK.AutoHeight = False
        Me.GV1_rpCHK.Name = "GV1_rpCHK"
        Me.GV1_rpCHK.ValueChecked = "Y"
        Me.GV1_rpCHK.ValueUnchecked = "N"
        '
        'GV1_SEQ
        '
        Me.GV1_SEQ.Caption = "Code"
        Me.GV1_SEQ.FieldName = "SEQ"
        Me.GV1_SEQ.Name = "GV1_SEQ"
        Me.GV1_SEQ.OptionsColumn.AllowEdit = False
        Me.GV1_SEQ.OptionsColumn.ReadOnly = True
        Me.GV1_SEQ.Visible = True
        Me.GV1_SEQ.VisibleIndex = 3
        Me.GV1_SEQ.Width = 35
        Me.Localizer1.SetWordID(Me.GV1_SEQ, "Code")
        '
        'GV1_PIC_NM
        '
        Me.GV1_PIC_NM.Caption = "PIC Name"
        Me.GV1_PIC_NM.FieldName = "PIC_NM"
        Me.GV1_PIC_NM.Name = "GV1_PIC_NM"
        Me.GV1_PIC_NM.OptionsColumn.AllowEdit = False
        Me.GV1_PIC_NM.OptionsColumn.ReadOnly = True
        Me.GV1_PIC_NM.Visible = True
        Me.GV1_PIC_NM.VisibleIndex = 1
        Me.GV1_PIC_NM.Width = 99
        Me.Localizer1.SetWordID(Me.GV1_PIC_NM, "PIC Name")
        '
        'GV1_EMAIL
        '
        Me.GV1_EMAIL.Caption = "E-Mail"
        Me.GV1_EMAIL.FieldName = "EMAIL"
        Me.GV1_EMAIL.Name = "GV1_EMAIL"
        Me.GV1_EMAIL.OptionsColumn.AllowEdit = False
        Me.GV1_EMAIL.OptionsColumn.ReadOnly = True
        Me.GV1_EMAIL.Visible = True
        Me.GV1_EMAIL.VisibleIndex = 2
        Me.GV1_EMAIL.Width = 170
        Me.Localizer1.SetWordID(Me.GV1_EMAIL, "E-Mail")
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "dft", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "avi", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "exe", 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "pdf", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "mp3", 9), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "mp4", 10), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "xls", 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "xlsx", 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "jpg", 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "png", 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "rar", 8), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "doc", 11), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "docx", 11), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "ppt", 12), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "pptx", 12), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "txt", 13), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "wmv", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "zip", 15), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "hwp", 16), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "UPLOAD", 19)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'S_CUST_CD
        '
        Me.S_CUST_CD.AlwaysSetDisplayParams = False
        Me.S_CUST_CD.AutoSuggestion = True
        Me.S_CUST_CD.BorderColor = System.Drawing.Color.Silver
        Me.S_CUST_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_CUST_CD.CodeType = "YJIT.CodeService.Customer"
        Me.S_CUST_CD.DataParams = "Type:''"
        Me.S_CUST_CD.DefVal = ""
        Me.S_CUST_CD.DisplayParams = "Code:@S_CUST_CD,CUST_LOCNM:@S_CUST_NM"
        Me.S_CUST_CD.EditPopup = ""
        Me.S_CUST_CD.IconVisible = True
        Me.S_CUST_CD.IsDataStateAware = True
        Me.S_CUST_CD.KeepIntegrity = True
        Me.S_CUST_CD.Location = New System.Drawing.Point(90, 5)
        Me.S_CUST_CD.MaxLength = 10
        Me.S_CUST_CD.Name = "S_CUST_CD"
        Me.S_CUST_CD.NextFocus = "btnSearch"
        Me.S_CUST_CD.RequiredFor = ""
        Me.S_CUST_CD.SearchPopup = "CustomerMaster"
        Me.S_CUST_CD.Size = New System.Drawing.Size(89, 22)
        Me.S_CUST_CD.SuppressValidateCode = False
        Me.S_CUST_CD.TabIndex = 170
        Me.S_CUST_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_CUST_CD.ValidateKeys = "KEY:@S_CUST_CD"
        '
        'S_CUST_NM
        '
        Me.S_CUST_NM.AutoEllipsis = True
        Me.S_CUST_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_CUST_NM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.S_CUST_NM.LabelFor = Nothing
        Me.S_CUST_NM.Location = New System.Drawing.Point(182, 5)
        Me.S_CUST_NM.Name = "S_CUST_NM"
        Me.S_CUST_NM.Size = New System.Drawing.Size(177, 22)
        Me.S_CUST_NM.TabIndex = 114
        Me.S_CUST_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_S_CUST_CD
        '
        Me.lbl_S_CUST_CD.LabelFor = Nothing
        Me.lbl_S_CUST_CD.Location = New System.Drawing.Point(3, 9)
        Me.lbl_S_CUST_CD.Name = "lbl_S_CUST_CD"
        Me.lbl_S_CUST_CD.Size = New System.Drawing.Size(81, 15)
        Me.lbl_S_CUST_CD.TabIndex = 80
        Me.lbl_S_CUST_CD.Text = "Customer"
        Me.lbl_S_CUST_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_CUST_CD, "Customer")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.S_MNGT_NO)
        Me.palAutoButton.Controls.Add(Me.CUST_CD)
        Me.palAutoButton.Controls.Add(Me.S_MSG_TYPE2)
        Me.palAutoButton.Controls.Add(Me.S_MSG_TYPE)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Controls.Add(Me.btnClear)
        Me.palAutoButton.Controls.Add(Me.btnSend)
        Me.palAutoButton.Location = New System.Drawing.Point(2, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(897, 32)
        Me.palAutoButton.TabIndex = 83
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'S_MNGT_NO
        '
        Me.S_MNGT_NO.AutoEllipsis = True
        Me.S_MNGT_NO.BorderColor = System.Drawing.Color.Silver
        Me.S_MNGT_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.S_MNGT_NO.LabelFor = Nothing
        Me.S_MNGT_NO.Location = New System.Drawing.Point(474, 5)
        Me.S_MNGT_NO.Name = "S_MNGT_NO"
        Me.S_MNGT_NO.Size = New System.Drawing.Size(10, 22)
        Me.S_MNGT_NO.TabIndex = 217
        Me.S_MNGT_NO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.S_MNGT_NO.Visible = False
        '
        'CUST_CD
        '
        Me.CUST_CD.AutoEllipsis = True
        Me.CUST_CD.BorderColor = System.Drawing.Color.Silver
        Me.CUST_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CUST_CD.LabelFor = Nothing
        Me.CUST_CD.Location = New System.Drawing.Point(458, 5)
        Me.CUST_CD.Name = "CUST_CD"
        Me.CUST_CD.Size = New System.Drawing.Size(10, 22)
        Me.CUST_CD.TabIndex = 216
        Me.CUST_CD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'S_MSG_TYPE2
        '
        Me.S_MSG_TYPE2.AutoEllipsis = True
        Me.S_MSG_TYPE2.BorderColor = System.Drawing.Color.Silver
        Me.S_MSG_TYPE2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.S_MSG_TYPE2.LabelFor = Nothing
        Me.S_MSG_TYPE2.Location = New System.Drawing.Point(443, 5)
        Me.S_MSG_TYPE2.Name = "S_MSG_TYPE2"
        Me.S_MSG_TYPE2.Size = New System.Drawing.Size(10, 22)
        Me.S_MSG_TYPE2.TabIndex = 215
        Me.S_MSG_TYPE2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.S_MSG_TYPE2.Visible = False
        '
        'S_MSG_TYPE
        '
        Me.S_MSG_TYPE.AutoEllipsis = True
        Me.S_MSG_TYPE.BorderColor = System.Drawing.Color.Silver
        Me.S_MSG_TYPE.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.S_MSG_TYPE.LabelFor = Nothing
        Me.S_MSG_TYPE.Location = New System.Drawing.Point(427, 5)
        Me.S_MSG_TYPE.Name = "S_MSG_TYPE"
        Me.S_MSG_TYPE.Size = New System.Drawing.Size(10, 22)
        Me.S_MSG_TYPE.TabIndex = 214
        Me.S_MSG_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.S_MSG_TYPE.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Action = "SearchData"
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(669, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'btnClear
        '
        Me.btnClear.Action = ""
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnClear.Location = New System.Drawing.Point(745, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 25)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "&Clear"
        Me.Localizer1.SetWordID(Me.btnClear, "&Clear")
        '
        'btnSend
        '
        Me.btnSend.Action = ""
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSend.Location = New System.Drawing.Point(821, 3)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(70, 25)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "&Send"
        Me.Localizer1.SetWordID(Me.btnSend, "&Send")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_CHK, " ")
        Me.Localizer1.SetWordID(Me.GV1_SEQ, "Code")
        Me.Localizer1.SetWordID(Me.GV1_PIC_NM, "PIC Name")
        Me.Localizer1.SetWordID(Me.GV1_EMAIL, "E-Mail")
        Me.Localizer1.SetWordID(Me.S_CUST_CD, "")
        Me.Localizer1.SetWordID(Me.lbl_S_CUST_CD, "Customer")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.btnClear, "&Clear")
        Me.Localizer1.SetWordID(Me.btnSend, "&Send")
        Me.Localizer1.SetWordID(Me.SENDER, "")
        Me.Localizer1.SetWordID(Me.lbl_SENDER, "*Sender")
        Me.Localizer1.SetWordID(Me.RECEIVER, "")
        Me.Localizer1.SetWordID(Me.CC, "")
        Me.Localizer1.SetWordID(Me.CONTENT, "")
        Me.Localizer1.SetWordID(Me.SUBJECT, "")
        Me.Localizer1.SetWordID(Me.lbl_RECEIVER, "*Receiver")
        Me.Localizer1.SetWordID(Me.lbl_CC, "C.C")
        Me.Localizer1.SetWordID(Me.lbl_SUBJECT, "*Subject")
        Me.Localizer1.SetWordID(Me.lbl_CONTENT, "Contents")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.lbl_MAIL_TYPE, "Mail Type")
        Me.Localizer1.SetWordID(Me.MAIL_TYPE, "MS Outlook")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GV1_FILE_NAME, "File Name")
        Me.Localizer1.SetWordID(Me.GV1_FILE_FULL_NAME, "File Full Name")
        Me.Localizer1.SetWordID(Me.GV1_SVR_FILE_FULL_NAME, "Server File Full Name")
        Me.Localizer1.SetWordID(Me.xtcMain, "")
        Me.Localizer1.SetWordID(Me.xtpMailList, "거래처 메일리스트")
        Me.Localizer1.SetWordID(Me.xtpSendList, "전송리스트")
        Me.Localizer1.SetWordID(Me.WG3, "")
        Me.Localizer1.SetWordID(Me.GV3_RECEIVER, "Receiver")
        Me.Localizer1.SetWordID(Me.GV3_INS_DATE, "Date")
        Me.Localizer1.SetWordID(Me.GV3_CONTENT, "Contents")
        '
        'SENDER
        '
        Me.SENDER.BackColor = System.Drawing.SystemColors.Window
        Me.SENDER.BorderColor = System.Drawing.Color.Silver
        Me.SENDER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SENDER.DefVal = ""
        Me.SENDER.IsDataStateAware = True
        Me.SENDER.Location = New System.Drawing.Point(97, 30)
        Me.SENDER.MaxLength = 100
        Me.SENDER.Name = "SENDER"
        Me.SENDER.NextFocus = "S_RECEIVER"
        Me.SENDER.RequiredFor = ""
        Me.SENDER.Size = New System.Drawing.Size(404, 22)
        Me.SENDER.TabIndex = 103
        Me.SENDER.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'lbl_SENDER
        '
        Me.lbl_SENDER.LabelFor = Nothing
        Me.lbl_SENDER.Location = New System.Drawing.Point(9, 33)
        Me.lbl_SENDER.Name = "lbl_SENDER"
        Me.lbl_SENDER.Size = New System.Drawing.Size(79, 14)
        Me.lbl_SENDER.TabIndex = 102
        Me.lbl_SENDER.Text = "*Sender"
        Me.lbl_SENDER.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_SENDER, "*Sender")
        '
        'RECEIVER
        '
        Me.RECEIVER.BorderColor = System.Drawing.Color.Silver
        Me.RECEIVER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RECEIVER.DefVal = ""
        Me.RECEIVER.IsDataStateAware = True
        Me.RECEIVER.Location = New System.Drawing.Point(97, 53)
        Me.RECEIVER.MaxLength = 100
        Me.RECEIVER.Name = "RECEIVER"
        Me.RECEIVER.NextFocus = "S_CC"
        Me.RECEIVER.RequiredFor = ""
        Me.RECEIVER.Size = New System.Drawing.Size(404, 22)
        Me.RECEIVER.TabIndex = 104
        Me.RECEIVER.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'CC
        '
        Me.CC.BorderColor = System.Drawing.Color.Silver
        Me.CC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CC.DefVal = ""
        Me.CC.IsDataStateAware = True
        Me.CC.Location = New System.Drawing.Point(97, 77)
        Me.CC.MaxLength = 200
        Me.CC.Multiline = True
        Me.CC.Name = "CC"
        Me.CC.NextFocus = "S_SUBJECT"
        Me.CC.RequiredFor = ""
        Me.CC.Size = New System.Drawing.Size(404, 50)
        Me.CC.TabIndex = 105
        Me.CC.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'CONTENT
        '
        Me.CONTENT.BorderColor = System.Drawing.Color.Silver
        Me.CONTENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CONTENT.DefVal = ""
        Me.CONTENT.IsDataStateAware = True
        Me.CONTENT.Location = New System.Drawing.Point(97, 154)
        Me.CONTENT.MaxLength = 2000
        Me.CONTENT.Multiline = True
        Me.CONTENT.Name = "CONTENT"
        Me.CONTENT.NextFocus = "btnSend"
        Me.CONTENT.RequiredFor = ""
        Me.CONTENT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CONTENT.Size = New System.Drawing.Size(404, 211)
        Me.CONTENT.TabIndex = 106
        Me.CONTENT.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'SUBJECT
        '
        Me.SUBJECT.BorderColor = System.Drawing.Color.Silver
        Me.SUBJECT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SUBJECT.DefVal = ""
        Me.SUBJECT.IsDataStateAware = True
        Me.SUBJECT.Location = New System.Drawing.Point(97, 130)
        Me.SUBJECT.MaxLength = 200
        Me.SUBJECT.Name = "SUBJECT"
        Me.SUBJECT.NextFocus = "S_CONTENT"
        Me.SUBJECT.RequiredFor = ""
        Me.SUBJECT.Size = New System.Drawing.Size(404, 22)
        Me.SUBJECT.TabIndex = 107
        Me.SUBJECT.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'lbl_RECEIVER
        '
        Me.lbl_RECEIVER.LabelFor = Nothing
        Me.lbl_RECEIVER.Location = New System.Drawing.Point(2, 57)
        Me.lbl_RECEIVER.Name = "lbl_RECEIVER"
        Me.lbl_RECEIVER.Size = New System.Drawing.Size(86, 14)
        Me.lbl_RECEIVER.TabIndex = 108
        Me.lbl_RECEIVER.Text = "*Receiver"
        Me.lbl_RECEIVER.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_RECEIVER, "*Receiver")
        '
        'lbl_CC
        '
        Me.lbl_CC.LabelFor = Nothing
        Me.lbl_CC.Location = New System.Drawing.Point(37, 77)
        Me.lbl_CC.Name = "lbl_CC"
        Me.lbl_CC.Size = New System.Drawing.Size(51, 14)
        Me.lbl_CC.TabIndex = 109
        Me.lbl_CC.Text = "C.C"
        Me.lbl_CC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_CC, "C.C")
        '
        'lbl_SUBJECT
        '
        Me.lbl_SUBJECT.LabelFor = Nothing
        Me.lbl_SUBJECT.Location = New System.Drawing.Point(6, 133)
        Me.lbl_SUBJECT.Name = "lbl_SUBJECT"
        Me.lbl_SUBJECT.Size = New System.Drawing.Size(82, 14)
        Me.lbl_SUBJECT.TabIndex = 110
        Me.lbl_SUBJECT.Text = "*Subject"
        Me.lbl_SUBJECT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_SUBJECT, "*Subject")
        '
        'lbl_CONTENT
        '
        Me.lbl_CONTENT.LabelFor = Nothing
        Me.lbl_CONTENT.Location = New System.Drawing.Point(5, 156)
        Me.lbl_CONTENT.Name = "lbl_CONTENT"
        Me.lbl_CONTENT.Size = New System.Drawing.Size(83, 14)
        Me.lbl_CONTENT.TabIndex = 111
        Me.lbl_CONTENT.Text = "Contents"
        Me.lbl_CONTENT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_CONTENT, "Contents")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.SEND_SSL_YN)
        Me.PanelControl2.Controls.Add(Me.SEND_PORT)
        Me.PanelControl2.Controls.Add(Me.SEND_HOST)
        Me.PanelControl2.Controls.Add(Me.SEND_PWD)
        Me.PanelControl2.Controls.Add(Me.SEND_ID)
        Me.PanelControl2.Controls.Add(Me.lbl_MAIL_TYPE)
        Me.PanelControl2.Controls.Add(Me.MAIL_TYPE)
        Me.PanelControl2.Controls.Add(Me.WG2)
        Me.PanelControl2.Controls.Add(Me.lbl_CONTENT)
        Me.PanelControl2.Controls.Add(Me.lbl_SUBJECT)
        Me.PanelControl2.Controls.Add(Me.lbl_CC)
        Me.PanelControl2.Controls.Add(Me.lbl_RECEIVER)
        Me.PanelControl2.Controls.Add(Me.SUBJECT)
        Me.PanelControl2.Controls.Add(Me.CONTENT)
        Me.PanelControl2.Controls.Add(Me.CC)
        Me.PanelControl2.Controls.Add(Me.RECEIVER)
        Me.PanelControl2.Controls.Add(Me.lbl_SENDER)
        Me.PanelControl2.Controls.Add(Me.SENDER)
        Me.PanelControl2.Location = New System.Drawing.Point(382, 39)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(517, 562)
        Me.PanelControl2.TabIndex = 83
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'SEND_SSL_YN
        '
        Me.SEND_SSL_YN.AutoEllipsis = True
        Me.SEND_SSL_YN.BorderColor = System.Drawing.Color.Silver
        Me.SEND_SSL_YN.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SEND_SSL_YN.LabelFor = Nothing
        Me.SEND_SSL_YN.Location = New System.Drawing.Point(487, 4)
        Me.SEND_SSL_YN.Name = "SEND_SSL_YN"
        Me.SEND_SSL_YN.Size = New System.Drawing.Size(10, 22)
        Me.SEND_SSL_YN.TabIndex = 213
        Me.SEND_SSL_YN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SEND_SSL_YN.Visible = False
        '
        'SEND_PORT
        '
        Me.SEND_PORT.AutoEllipsis = True
        Me.SEND_PORT.BorderColor = System.Drawing.Color.Silver
        Me.SEND_PORT.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SEND_PORT.LabelFor = Nothing
        Me.SEND_PORT.Location = New System.Drawing.Point(471, 4)
        Me.SEND_PORT.Name = "SEND_PORT"
        Me.SEND_PORT.Size = New System.Drawing.Size(10, 22)
        Me.SEND_PORT.TabIndex = 213
        Me.SEND_PORT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SEND_PORT.Visible = False
        '
        'SEND_HOST
        '
        Me.SEND_HOST.AutoEllipsis = True
        Me.SEND_HOST.BorderColor = System.Drawing.Color.Silver
        Me.SEND_HOST.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SEND_HOST.LabelFor = Nothing
        Me.SEND_HOST.Location = New System.Drawing.Point(455, 4)
        Me.SEND_HOST.Name = "SEND_HOST"
        Me.SEND_HOST.Size = New System.Drawing.Size(10, 22)
        Me.SEND_HOST.TabIndex = 213
        Me.SEND_HOST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SEND_HOST.Visible = False
        '
        'SEND_PWD
        '
        Me.SEND_PWD.AutoEllipsis = True
        Me.SEND_PWD.BorderColor = System.Drawing.Color.Silver
        Me.SEND_PWD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SEND_PWD.LabelFor = Nothing
        Me.SEND_PWD.Location = New System.Drawing.Point(439, 4)
        Me.SEND_PWD.Name = "SEND_PWD"
        Me.SEND_PWD.Size = New System.Drawing.Size(10, 22)
        Me.SEND_PWD.TabIndex = 213
        Me.SEND_PWD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SEND_PWD.Visible = False
        '
        'SEND_ID
        '
        Me.SEND_ID.AutoEllipsis = True
        Me.SEND_ID.BorderColor = System.Drawing.Color.Silver
        Me.SEND_ID.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SEND_ID.LabelFor = Nothing
        Me.SEND_ID.Location = New System.Drawing.Point(249, 4)
        Me.SEND_ID.Name = "SEND_ID"
        Me.SEND_ID.Size = New System.Drawing.Size(184, 22)
        Me.SEND_ID.TabIndex = 213
        Me.SEND_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SEND_ID.Visible = False
        '
        'lbl_MAIL_TYPE
        '
        Me.lbl_MAIL_TYPE.AutoEllipsis = True
        Me.lbl_MAIL_TYPE.LabelFor = Nothing
        Me.lbl_MAIL_TYPE.Location = New System.Drawing.Point(12, 5)
        Me.lbl_MAIL_TYPE.Name = "lbl_MAIL_TYPE"
        Me.lbl_MAIL_TYPE.Size = New System.Drawing.Size(76, 22)
        Me.lbl_MAIL_TYPE.TabIndex = 212
        Me.lbl_MAIL_TYPE.Text = "Mail Type"
        Me.lbl_MAIL_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_MAIL_TYPE, "Mail Type")
        '
        'MAIL_TYPE
        '
        Me.MAIL_TYPE.CodeType = ""
        Me.MAIL_TYPE.ColumnWidths = ""
        Me.MAIL_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.MAIL_TYPE.DataParams = ""
        Me.MAIL_TYPE.DefVal = ""
        Me.MAIL_TYPE.DisplayMember = "NAME"
        Me.MAIL_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MAIL_TYPE.Enabled = False
        Me.MAIL_TYPE.FormattingEnabled = True
        Me.MAIL_TYPE.IsDataStateAware = True
        Me.MAIL_TYPE.ItemDelimiter = ","
        Me.MAIL_TYPE.ItemTextList = "MS Outlook,Hanbiro"
        Me.MAIL_TYPE.ItemValueList = "M,H"
        Me.MAIL_TYPE.KeepIntegrity = True
        Me.MAIL_TYPE.Location = New System.Drawing.Point(97, 5)
        Me.MAIL_TYPE.Name = "MAIL_TYPE"
        Me.MAIL_TYPE.NextFocus = ""
        Me.MAIL_TYPE.NullText = ""
        Me.MAIL_TYPE.RequiredFor = ""
        Me.MAIL_TYPE.SearchKeys = ""
        Me.MAIL_TYPE.Size = New System.Drawing.Size(146, 22)
        Me.MAIL_TYPE.TabIndex = 211
        Me.MAIL_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.MAIL_TYPE.ValueMember = "CODE"
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.AllowDrop = True
        Me.WG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG2.DeleteRowConfirmation = False
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(97, 371)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(404, 186)
        Me.WG2.TabIndex = 113
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2, Me.GridView3, Me.GridView2})
        '
        'GV2
        '
        Me.GV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_FILE_NAME, Me.GV1_FILE_FULL_NAME, Me.GV1_SVR_FILE_FULL_NAME})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.Editable = False
        Me.GV2.OptionsBehavior.ReadOnly = True
        Me.GV2.OptionsCustomization.AllowFilter = False
        Me.GV2.OptionsCustomization.AllowSort = False
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorzLines = False
        Me.GV2.OptionsView.ShowVertLines = False
        Me.GV2.OptionsView.ShowViewCaption = True
        Me.GV2.ViewCaption = "  Attachments"
        '
        'GV1_FILE_NAME
        '
        Me.GV1_FILE_NAME.Caption = "File Name"
        Me.GV1_FILE_NAME.FieldName = "FILE_NAME"
        Me.GV1_FILE_NAME.Name = "GV1_FILE_NAME"
        Me.GV1_FILE_NAME.Visible = True
        Me.GV1_FILE_NAME.VisibleIndex = 0
        Me.GV1_FILE_NAME.Width = 365
        Me.Localizer1.SetWordID(Me.GV1_FILE_NAME, "File Name")
        '
        'GV1_FILE_FULL_NAME
        '
        Me.GV1_FILE_FULL_NAME.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FILE_FULL_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FILE_FULL_NAME.Caption = "File Full Name"
        Me.GV1_FILE_FULL_NAME.FieldName = "FILE_FULL_NAME"
        Me.GV1_FILE_FULL_NAME.Name = "GV1_FILE_FULL_NAME"
        Me.GV1_FILE_FULL_NAME.OptionsColumn.AllowEdit = False
        Me.GV1_FILE_FULL_NAME.OptionsColumn.ReadOnly = True
        Me.GV1_FILE_FULL_NAME.Width = 400
        Me.Localizer1.SetWordID(Me.GV1_FILE_FULL_NAME, "File Full Name")
        '
        'GV1_SVR_FILE_FULL_NAME
        '
        Me.GV1_SVR_FILE_FULL_NAME.Caption = "Server File Full Name"
        Me.GV1_SVR_FILE_FULL_NAME.FieldName = "SVR_FILE_FULL_NAME"
        Me.GV1_SVR_FILE_FULL_NAME.Name = "GV1_SVR_FILE_FULL_NAME"
        Me.Localizer1.SetWordID(Me.GV1_SVR_FILE_FULL_NAME, "")
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.WG2
        Me.GridView3.Name = "GridView3"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.WG2
        Me.GridView2.Name = "GridView2"
        '
        'xtcMain
        '
        Me.xtcMain.Location = New System.Drawing.Point(2, 39)
        Me.xtcMain.Name = "xtcMain"
        Me.xtcMain.SelectedTabPage = Me.xtpMailList
        Me.xtcMain.Size = New System.Drawing.Size(376, 562)
        Me.xtcMain.TabIndex = 84
        Me.xtcMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpMailList, Me.xtpSendList})
        Me.Localizer1.SetWordID(Me.xtcMain, "")
        '
        'xtpMailList
        '
        Me.xtpMailList.Controls.Add(Me.WG1)
        Me.xtpMailList.Controls.Add(Me.lbl_S_CUST_CD)
        Me.xtpMailList.Controls.Add(Me.S_CUST_CD)
        Me.xtpMailList.Controls.Add(Me.S_CUST_NM)
        Me.xtpMailList.Name = "xtpMailList"
        Me.xtpMailList.Size = New System.Drawing.Size(371, 536)
        Me.xtpMailList.Text = "거래처 메일리스트"
        Me.Localizer1.SetWordID(Me.xtpMailList, "")
        '
        'xtpSendList
        '
        Me.xtpSendList.Controls.Add(Me.WG3)
        Me.xtpSendList.Name = "xtpSendList"
        Me.xtpSendList.Size = New System.Drawing.Size(370, 535)
        Me.xtpSendList.Text = "전송리스트"
        Me.Localizer1.SetWordID(Me.xtpSendList, "")
        '
        'WG3
        '
        Me.WG3.AllowClientBinding = True
        Me.WG3.AllowDrop = True
        Me.WG3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG3.DeleteRowConfirmation = False
        Me.WG3.DisplayCurrentRow = False
        Me.WG3.IsDataStateAware = True
        Me.WG3.Location = New System.Drawing.Point(3, 3)
        Me.WG3.MainView = Me.GV3
        Me.WG3.Name = "WG3"
        Me.WG3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageComboBox2, Me.RepositoryItemTextEdit2, Me.RepositoryItemCheckEdit1})
        Me.WG3.SaveLayout = False
        Me.WG3.Size = New System.Drawing.Size(364, 529)
        Me.WG3.TabIndex = 89
        Me.WG3.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV3_RECEIVER, Me.GV3_INS_DATE, Me.GV3_CONTENT})
        Me.GV3.GridControl = Me.WG3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV3.OptionsView.ColumnAutoWidth = False
        Me.GV3.OptionsView.ShowGroupPanel = False
        Me.GV3.OptionsView.ShowHorzLines = False
        '
        'GV3_RECEIVER
        '
        Me.GV3_RECEIVER.Caption = "Receiver"
        Me.GV3_RECEIVER.FieldName = "RECEIVER"
        Me.GV3_RECEIVER.Name = "GV3_RECEIVER"
        Me.GV3_RECEIVER.OptionsColumn.AllowEdit = False
        Me.GV3_RECEIVER.OptionsColumn.ReadOnly = True
        Me.GV3_RECEIVER.Visible = True
        Me.GV3_RECEIVER.VisibleIndex = 2
        Me.GV3_RECEIVER.Width = 100
        Me.Localizer1.SetWordID(Me.GV3_RECEIVER, "")
        '
        'GV3_INS_DATE
        '
        Me.GV3_INS_DATE.Caption = "Date"
        Me.GV3_INS_DATE.FieldName = "INS_DATE"
        Me.GV3_INS_DATE.Name = "GV3_INS_DATE"
        Me.GV3_INS_DATE.OptionsColumn.AllowEdit = False
        Me.GV3_INS_DATE.OptionsColumn.ReadOnly = True
        Me.GV3_INS_DATE.Visible = True
        Me.GV3_INS_DATE.VisibleIndex = 0
        Me.GV3_INS_DATE.Width = 110
        Me.Localizer1.SetWordID(Me.GV3_INS_DATE, "")
        '
        'GV3_CONTENT
        '
        Me.GV3_CONTENT.Caption = "Contents"
        Me.GV3_CONTENT.FieldName = "CONTENT"
        Me.GV3_CONTENT.Name = "GV3_CONTENT"
        Me.GV3_CONTENT.OptionsColumn.AllowEdit = False
        Me.GV3_CONTENT.OptionsColumn.ReadOnly = True
        Me.GV3_CONTENT.Visible = True
        Me.GV3_CONTENT.VisibleIndex = 1
        Me.GV3_CONTENT.Width = 170
        Me.Localizer1.SetWordID(Me.GV3_CONTENT, "")
        '
        'RepositoryItemImageComboBox2
        '
        Me.RepositoryItemImageComboBox2.AutoHeight = False
        Me.RepositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "dft", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "avi", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "exe", 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "pdf", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "mp3", 9), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "mp4", 10), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "xls", 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "xlsx", 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "jpg", 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "png", 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "rar", 8), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "doc", 11), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "docx", 11), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "ppt", 12), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "pptx", 12), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "txt", 13), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "wmv", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "zip", 15), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "hwp", 16), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "UPLOAD", 19)})
        Me.RepositoryItemImageComboBox2.Name = "RepositoryItemImageComboBox2"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ComSendMail
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(905, 608)
        Me.Controls.Add(Me.xtcMain)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(525, 646)
        Me.Name = "ComSendMail"
        Me.Text = "Send Email"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1_rpCHK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcMain.ResumeLayout(False)
        Me.xtpMailList.ResumeLayout(False)
        Me.xtpMailList.PerformLayout()
        Me.xtpSendList.ResumeLayout(False)
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_S_CUST_CD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClear As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSend As YJIT.SC.UI.SCControls.Button
    Friend WithEvents S_CUST_NM As YJIT.SC.UI.SCControls.TextLabel
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Public WithEvents S_CUST_CD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents SENDER As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents lbl_SENDER As YJIT.SC.UI.SCControls.Label
    Public WithEvents RECEIVER As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents CC As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents CONTENT As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents SUBJECT As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents lbl_RECEIVER As YJIT.SC.UI.SCControls.Label
    Friend WithEvents lbl_CC As YJIT.SC.UI.SCControls.Label
    Friend WithEvents lbl_SUBJECT As YJIT.SC.UI.SCControls.Label
    Friend WithEvents lbl_CONTENT As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents GV1_rpCHK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_CHK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PIC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_EMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Public WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_FILE_FULL_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SVR_FILE_FULL_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FILE_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_MAIL_TYPE As YJIT.SC.UI.SCControls.Label
    Friend WithEvents MAIL_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents SEND_PWD As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents SEND_ID As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents SEND_SSL_YN As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents SEND_PORT As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents SEND_HOST As YJIT.SC.UI.SCControls.TextLabel
    Public WithEvents S_MSG_TYPE2 As YJIT.SC.UI.SCControls.TextLabel
    Public WithEvents S_MSG_TYPE As YJIT.SC.UI.SCControls.TextLabel
    Public WithEvents CUST_CD As YJIT.SC.UI.SCControls.TextLabel
    Public WithEvents S_MNGT_NO As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents xtcMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpMailList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpSendList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG3 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV3_RECEIVER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_INS_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_CONTENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit




End Class
