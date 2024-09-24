<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysBoardList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SysBoardList))
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.LBL_TITLE = New YJIT.SC.UI.SCControls.Label()
        Me.S_TITLE = New YJIT.SC.UI.SCControls.TextBox()
        Me.LBL_MNGT_NO = New YJIT.SC.UI.SCControls.Label()
        Me.S_BOARD_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.S_SVC_CD = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label37 = New YJIT.SC.UI.SCControls.Label()
        Me.S_OP_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_OP_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.Label14 = New YJIT.SC.UI.SCControls.Label()
        Me.S_DATE_TO = New YJIT.SC.UI.SCControls.DateBox()
        Me.S_DATE_FM = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label32 = New YJIT.SC.UI.SCControls.Label()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_BOARD_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USR_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_EDIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_NOTICE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV1_BOARD_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.iconImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV2_CHK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV2_DOMAIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_WEB_IP_EXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DB_IP_EXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CTRY_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_LANG_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_ELVIS_BILL_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BOARD_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.TITLE = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Location = New System.Drawing.Point(5, 2)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1241, 32)
        Me.palAutoButton.TabIndex = 83
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(1160, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1001, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 25)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(1084, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(70, 25)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        Me.Localizer1.SetWordID(Me.LBL_TITLE, "Subject")
        Me.Localizer1.SetWordID(Me.S_TITLE, "")
        Me.Localizer1.SetWordID(Me.LBL_MNGT_NO, "No")
        Me.Localizer1.SetWordID(Me.S_BOARD_ID, "")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.S_SVC_CD, "--Select--")
        Me.Localizer1.SetWordID(Me.Label37, "시스템")
        Me.Localizer1.SetWordID(Me.S_OP_CD, "")
        Me.Localizer1.SetWordID(Me.Label14, "User Name")
        Me.Localizer1.SetWordID(Me.S_DATE_TO, "")
        Me.Localizer1.SetWordID(Me.S_DATE_FM, "")
        Me.Localizer1.SetWordID(Me.Label32, "~")
        Me.Localizer1.SetWordID(Me.Label3, "Date")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_BOARD_SEQ, "#")
        Me.Localizer1.SetWordID(Me.GV1_TITLE, "Subject")
        Me.Localizer1.SetWordID(Me.GV1_USR_NM, "Name")
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "Date")
        Me.Localizer1.SetWordID(Me.GV1_EDIT, " ")
        Me.Localizer1.SetWordID(Me.GV1_NOTICE_YN, "Notice Y/N")
        Me.Localizer1.SetWordID(Me.GV1_BOARD_ID, "ID")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GV2_CHK, "V")
        Me.Localizer1.SetWordID(Me.GV2_DOMAIN, "Domain")
        Me.Localizer1.SetWordID(Me.GV2_CUST_CD, "코드")
        Me.Localizer1.SetWordID(Me.GV2_CUST_NM, "거래처")
        Me.Localizer1.SetWordID(Me.GV2_WEB_IP_EXT, "WEB IP (외부)")
        Me.Localizer1.SetWordID(Me.GV2_DB_IP_EXT, "DB IP (외부)")
        Me.Localizer1.SetWordID(Me.GV2_CTRY_CD, "국가")
        Me.Localizer1.SetWordID(Me.GV2_LANG_CD, "언어")
        Me.Localizer1.SetWordID(Me.GV2_ELVIS_BILL_YN, "ELVIS BILL")
        Me.Localizer1.SetWordID(Me.BOARD_ID, "")
        Me.Localizer1.SetWordID(Me.TITLE, "")
        Me.Localizer1.SetWordID(Me.Label1, "No")
        Me.Localizer1.SetWordID(Me.Label2, "Subject")
        '
        'LBL_TITLE
        '
        Me.LBL_TITLE.LabelFor = Nothing
        Me.LBL_TITLE.Location = New System.Drawing.Point(417, 5)
        Me.LBL_TITLE.Name = "LBL_TITLE"
        Me.LBL_TITLE.Size = New System.Drawing.Size(71, 22)
        Me.LBL_TITLE.TabIndex = 91
        Me.LBL_TITLE.Text = "Subject"
        Me.LBL_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_TITLE, "Subject")
        '
        'S_TITLE
        '
        Me.S_TITLE.BackColor = System.Drawing.SystemColors.Window
        Me.S_TITLE.BorderColor = System.Drawing.Color.Silver
        Me.S_TITLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_TITLE.DefVal = ""
        Me.S_TITLE.IsDataStateAware = True
        Me.S_TITLE.Location = New System.Drawing.Point(494, 5)
        Me.S_TITLE.MaxLength = 100
        Me.S_TITLE.Name = "S_TITLE"
        Me.S_TITLE.NextFocus = "USR_ID"
        Me.S_TITLE.Size = New System.Drawing.Size(188, 22)
        Me.S_TITLE.TabIndex = 92
        Me.S_TITLE.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'LBL_MNGT_NO
        '
        Me.LBL_MNGT_NO.LabelFor = Nothing
        Me.LBL_MNGT_NO.Location = New System.Drawing.Point(292, 5)
        Me.LBL_MNGT_NO.Name = "LBL_MNGT_NO"
        Me.LBL_MNGT_NO.Size = New System.Drawing.Size(38, 22)
        Me.LBL_MNGT_NO.TabIndex = 115
        Me.LBL_MNGT_NO.Text = "#"
        Me.LBL_MNGT_NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_MNGT_NO, "No")
        '
        'S_BOARD_ID
        '
        Me.S_BOARD_ID.BackColor = System.Drawing.SystemColors.Window
        Me.S_BOARD_ID.BorderColor = System.Drawing.Color.Silver
        Me.S_BOARD_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_BOARD_ID.DefVal = ""
        Me.S_BOARD_ID.IsDataStateAware = True
        Me.S_BOARD_ID.Location = New System.Drawing.Point(336, 5)
        Me.S_BOARD_ID.MaxLength = 100
        Me.S_BOARD_ID.Name = "S_BOARD_ID"
        Me.S_BOARD_ID.NextFocus = "TITLE"
        Me.S_BOARD_ID.Size = New System.Drawing.Size(78, 22)
        Me.S_BOARD_ID.TabIndex = 116
        Me.S_BOARD_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.S_SVC_CD)
        Me.PanelControl1.Controls.Add(Me.Label37)
        Me.PanelControl1.Controls.Add(Me.S_OP_NM)
        Me.PanelControl1.Controls.Add(Me.S_OP_CD)
        Me.PanelControl1.Controls.Add(Me.Label14)
        Me.PanelControl1.Controls.Add(Me.S_DATE_TO)
        Me.PanelControl1.Controls.Add(Me.S_DATE_FM)
        Me.PanelControl1.Controls.Add(Me.Label32)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.S_TITLE)
        Me.PanelControl1.Controls.Add(Me.LBL_TITLE)
        Me.PanelControl1.Controls.Add(Me.S_BOARD_ID)
        Me.PanelControl1.Controls.Add(Me.LBL_MNGT_NO)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 41)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1241, 33)
        Me.PanelControl1.TabIndex = 118
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'S_SVC_CD
        '
        Me.S_SVC_CD.CodeType = ""
        Me.S_SVC_CD.ColumnWidths = ""
        Me.S_SVC_CD.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_SVC_CD.DataParams = ""
        Me.S_SVC_CD.DefVal = "E"
        Me.S_SVC_CD.DisplayMember = "NAME"
        Me.S_SVC_CD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_SVC_CD.FormattingEnabled = True
        Me.S_SVC_CD.IsDataStateAware = True
        Me.S_SVC_CD.ItemDelimiter = ","
        Me.S_SVC_CD.ItemTextList = "ELVIS,일반,T/S,적하목록,기타"
        Me.S_SVC_CD.ItemValueList = "E,V,T,M,Z"
        Me.S_SVC_CD.KeepIntegrity = True
        Me.S_SVC_CD.Location = New System.Drawing.Point(1044, 6)
        Me.S_SVC_CD.Name = "S_SVC_CD"
        Me.S_SVC_CD.NextFocus = "USE_YN"
        Me.S_SVC_CD.NullText = "--Select--"
        Me.S_SVC_CD.SearchKeys = ""
        Me.S_SVC_CD.Size = New System.Drawing.Size(120, 22)
        Me.S_SVC_CD.TabIndex = 174
        Me.S_SVC_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_SVC_CD.ValueMember = "CODE"
        Me.S_SVC_CD.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.LabelFor = Nothing
        Me.Label37.Location = New System.Drawing.Point(995, 10)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(37, 14)
        Me.Label37.TabIndex = 173
        Me.Label37.Text = "시스템"
        Me.Label37.Visible = False
        Me.Localizer1.SetWordID(Me.Label37, "시스템")
        '
        'S_OP_NM
        '
        Me.S_OP_NM.AutoEllipsis = True
        Me.S_OP_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_OP_NM.LabelFor = Nothing
        Me.S_OP_NM.Location = New System.Drawing.Point(866, 5)
        Me.S_OP_NM.Name = "S_OP_NM"
        Me.S_OP_NM.Size = New System.Drawing.Size(122, 22)
        Me.S_OP_NM.TabIndex = 172
        Me.S_OP_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'S_OP_CD
        '
        Me.S_OP_CD.AlwaysSetDisplayParams = False
        Me.S_OP_CD.AutoSuggestion = True
        Me.S_OP_CD.BorderColor = System.Drawing.Color.Silver
        Me.S_OP_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_OP_CD.CodeType = "YJIT.CodeService.User"
        Me.S_OP_CD.DataParams = ""
        Me.S_OP_CD.DefVal = ""
        Me.S_OP_CD.DisplayParams = "Code:@S_OP_CD,ENG_NM:@S_OP_NM"
        Me.S_OP_CD.EditPopup = ""
        Me.S_OP_CD.IconVisible = True
        Me.S_OP_CD.IsDataStateAware = True
        Me.S_OP_CD.KeepIntegrity = True
        Me.S_OP_CD.Location = New System.Drawing.Point(777, 5)
        Me.S_OP_CD.MaxLength = 10
        Me.S_OP_CD.Name = "S_OP_CD"
        Me.S_OP_CD.NextFocus = "S_EX_IM_TYPE"
        Me.S_OP_CD.SearchPopup = "CodeMaster"
        Me.S_OP_CD.Size = New System.Drawing.Size(86, 22)
        Me.S_OP_CD.SuppressValidateCode = False
        Me.S_OP_CD.TabIndex = 171
        Me.S_OP_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_OP_CD.ValidateKeys = "KEY:@S_OP_CD"
        '
        'Label14
        '
        Me.Label14.AutoEllipsis = True
        Me.Label14.LabelFor = Nothing
        Me.Label14.Location = New System.Drawing.Point(688, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 22)
        Me.Label14.TabIndex = 170
        Me.Label14.Text = "User Name"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label14, "User Name")
        '
        'S_DATE_TO
        '
        Me.S_DATE_TO.BorderColor = System.Drawing.Color.Silver
        Me.S_DATE_TO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_DATE_TO.DefVal = ""
        Me.S_DATE_TO.IconVisible = True
        Me.S_DATE_TO.IsDataStateAware = True
        Me.S_DATE_TO.Location = New System.Drawing.Point(186, 5)
        Me.S_DATE_TO.Name = "S_DATE_TO"
        Me.S_DATE_TO.NextFocus = "ANDOR"
        Me.S_DATE_TO.Size = New System.Drawing.Size(95, 22)
        Me.S_DATE_TO.TabIndex = 132
        Me.Localizer1.SetWordID(Me.S_DATE_TO, "")
        '
        'S_DATE_FM
        '
        Me.S_DATE_FM.BorderColor = System.Drawing.Color.Silver
        Me.S_DATE_FM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_DATE_FM.DefVal = ""
        Me.S_DATE_FM.IconVisible = True
        Me.S_DATE_FM.IsDataStateAware = True
        Me.S_DATE_FM.Location = New System.Drawing.Point(63, 5)
        Me.S_DATE_FM.Name = "S_DATE_FM"
        Me.S_DATE_FM.NextFocus = "S_DATE_TO"
        Me.S_DATE_FM.Size = New System.Drawing.Size(95, 22)
        Me.S_DATE_FM.TabIndex = 131
        Me.Localizer1.SetWordID(Me.S_DATE_FM, "")
        '
        'Label32
        '
        Me.Label32.LabelFor = Nothing
        Me.Label32.Location = New System.Drawing.Point(164, 6)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 22)
        Me.Label32.TabIndex = 130
        Me.Label32.Text = "~"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Localizer1.SetWordID(Me.Label32, "~")
        '
        'Label3
        '
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(7, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 22)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label3, "Date")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(5, 80)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit5, Me.RepositoryItemMemoExEdit3, Me.RepositoryItemTextEdit11, Me.btnEdit, Me.RepositoryItemImageComboBox2, Me.RepositoryItemCheckEdit2})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(713, 487)
        Me.WG1.TabIndex = 119
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GridView15})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_BOARD_SEQ, Me.GV1_TITLE, Me.GV1_USR_NM, Me.GV1_INS_YMD, Me.GV1_EDIT, Me.GV1_NOTICE_YN, Me.GV1_BOARD_ID})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsCustomization.AllowColumnMoving = False
        Me.GV1.OptionsCustomization.AllowSort = False
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GV1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.RowAutoHeight = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowIndicator = False
        Me.GV1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GV1_BOARD_SEQ
        '
        Me.GV1_BOARD_SEQ.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_BOARD_SEQ.AppearanceCell.Options.UseFont = True
        Me.GV1_BOARD_SEQ.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_BOARD_SEQ.AppearanceHeader.Options.UseFont = True
        Me.GV1_BOARD_SEQ.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BOARD_SEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BOARD_SEQ.Caption = "#"
        Me.GV1_BOARD_SEQ.FieldName = "BOARD_SEQ"
        Me.GV1_BOARD_SEQ.Name = "GV1_BOARD_SEQ"
        Me.GV1_BOARD_SEQ.OptionsColumn.AllowEdit = False
        Me.GV1_BOARD_SEQ.OptionsColumn.ReadOnly = True
        Me.GV1_BOARD_SEQ.Visible = True
        Me.GV1_BOARD_SEQ.VisibleIndex = 0
        Me.GV1_BOARD_SEQ.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_BOARD_SEQ, "")
        '
        'GV1_TITLE
        '
        Me.GV1_TITLE.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV1_TITLE.AppearanceCell.Options.UseFont = True
        Me.GV1_TITLE.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_TITLE.AppearanceHeader.Options.UseFont = True
        Me.GV1_TITLE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TITLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TITLE.Caption = "Subject"
        Me.GV1_TITLE.FieldName = "TITLE"
        Me.GV1_TITLE.Name = "GV1_TITLE"
        Me.GV1_TITLE.OptionsColumn.AllowEdit = False
        Me.GV1_TITLE.OptionsColumn.ReadOnly = True
        Me.GV1_TITLE.Visible = True
        Me.GV1_TITLE.VisibleIndex = 1
        Me.GV1_TITLE.Width = 350
        Me.Localizer1.SetWordID(Me.GV1_TITLE, "")
        '
        'GV1_USR_NM
        '
        Me.GV1_USR_NM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_USR_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_USR_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_USR_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USR_NM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_USR_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_USR_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USR_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USR_NM.Caption = "Name"
        Me.GV1_USR_NM.FieldName = "USR_NM"
        Me.GV1_USR_NM.Name = "GV1_USR_NM"
        Me.GV1_USR_NM.OptionsColumn.AllowEdit = False
        Me.GV1_USR_NM.OptionsColumn.ReadOnly = True
        Me.GV1_USR_NM.Visible = True
        Me.GV1_USR_NM.VisibleIndex = 2
        Me.GV1_USR_NM.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_USR_NM, "")
        '
        'GV1_INS_YMD
        '
        Me.GV1_INS_YMD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_INS_YMD.AppearanceCell.Options.UseFont = True
        Me.GV1_INS_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_YMD.AppearanceHeader.BackColor = System.Drawing.Color.Black
        Me.GV1_INS_YMD.AppearanceHeader.BackColor2 = System.Drawing.Color.Red
        Me.GV1_INS_YMD.AppearanceHeader.BorderColor = System.Drawing.Color.Yellow
        Me.GV1_INS_YMD.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_INS_YMD.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseBackColor = True
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseBorderColor = True
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_YMD.Caption = "Date"
        Me.GV1_INS_YMD.FieldName = "INS_YMD"
        Me.GV1_INS_YMD.Name = "GV1_INS_YMD"
        Me.GV1_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_INS_YMD.Visible = True
        Me.GV1_INS_YMD.VisibleIndex = 3
        Me.GV1_INS_YMD.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "")
        '
        'GV1_EDIT
        '
        Me.GV1_EDIT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Underline)
        Me.GV1_EDIT.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.GV1_EDIT.AppearanceCell.Options.UseFont = True
        Me.GV1_EDIT.AppearanceCell.Options.UseForeColor = True
        Me.GV1_EDIT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_EDIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EDIT.Caption = " "
        Me.GV1_EDIT.FieldName = "EDIT"
        Me.GV1_EDIT.Name = "GV1_EDIT"
        Me.GV1_EDIT.OptionsColumn.AllowEdit = False
        Me.GV1_EDIT.OptionsColumn.ReadOnly = True
        Me.GV1_EDIT.Visible = True
        Me.GV1_EDIT.VisibleIndex = 4
        Me.GV1_EDIT.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_EDIT, "")
        '
        'GV1_NOTICE_YN
        '
        Me.GV1_NOTICE_YN.Caption = "Notice Y/N"
        Me.GV1_NOTICE_YN.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.GV1_NOTICE_YN.FieldName = "NOTICE_YN"
        Me.GV1_NOTICE_YN.Name = "GV1_NOTICE_YN"
        Me.GV1_NOTICE_YN.OptionsColumn.AllowEdit = False
        Me.GV1_NOTICE_YN.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_NOTICE_YN, "")
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'GV1_BOARD_ID
        '
        Me.GV1_BOARD_ID.Caption = "ID"
        Me.GV1_BOARD_ID.FieldName = "BOARD_ID"
        Me.GV1_BOARD_ID.Name = "GV1_BOARD_ID"
        Me.GV1_BOARD_ID.OptionsColumn.AllowEdit = False
        Me.GV1_BOARD_ID.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_BOARD_ID, "")
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit5.MaxLength = 10
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.AutoHeight = False
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.DisplayFormat.FormatString = "yyyy-MM-dd"
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.PopupFormSize = New System.Drawing.Size(380, 50)
        Me.RepositoryItemMemoExEdit3.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.RepositoryItemMemoExEdit3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
        Me.RepositoryItemMemoExEdit3.WordWrap = False
        '
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.AutoHeight = False
        Me.RepositoryItemTextEdit11.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemTextEdit11.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit11.MaxLength = 30
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        '
        'btnEdit
        '
        Me.btnEdit.AutoHeight = False
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.SingleClick = True
        '
        'RepositoryItemImageComboBox2
        '
        Me.RepositoryItemImageComboBox2.AutoHeight = False
        Me.RepositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "UNMARKED", 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "MARKED", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "Y", 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "N", 16)})
        Me.RepositoryItemImageComboBox2.Name = "RepositoryItemImageComboBox2"
        Me.RepositoryItemImageComboBox2.SmallImages = Me.iconImages
        '
        'iconImages
        '
        Me.iconImages.ImageStream = CType(resources.GetObject("iconImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.iconImages.Images.SetKeyName(0, "email_attachment.png")
        Me.iconImages.Images.SetKeyName(1, "email_attachment_open.png")
        Me.iconImages.Images.SetKeyName(2, "email_new.png")
        Me.iconImages.Images.SetKeyName(3, "email_open.png")
        Me.iconImages.Images.SetKeyName(4, "Attachment.png")
        '
        'GridView15
        '
        Me.GridView15.GridControl = Me.WG1
        Me.GridView15.Name = "GridView15"
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG2.DeleteRowConfirmation = False
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(724, 103)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(522, 464)
        Me.WG2.TabIndex = 120
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV2_CHK, Me.GV2_DOMAIN, Me.GV2_CUST_CD, Me.GV2_CUST_NM, Me.GV2_WEB_IP_EXT, Me.GV2_DB_IP_EXT, Me.GV2_CTRY_CD, Me.GV2_LANG_CD, Me.GV2_ELVIS_BILL_YN})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsCustomization.AllowColumnMoving = False
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GV2_CHK
        '
        Me.GV2_CHK.Caption = "V"
        Me.GV2_CHK.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV2_CHK.FieldName = "CHK"
        Me.GV2_CHK.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV2_CHK.Name = "GV2_CHK"
        Me.GV2_CHK.Visible = True
        Me.GV2_CHK.VisibleIndex = 0
        Me.GV2_CHK.Width = 25
        Me.Localizer1.SetWordID(Me.GV2_CHK, "")
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'GV2_DOMAIN
        '
        Me.GV2_DOMAIN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV2_DOMAIN.AppearanceCell.Options.UseFont = True
        Me.GV2_DOMAIN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DOMAIN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DOMAIN.Caption = "Domain"
        Me.GV2_DOMAIN.FieldName = "DOMAIN"
        Me.GV2_DOMAIN.Name = "GV2_DOMAIN"
        Me.GV2_DOMAIN.OptionsColumn.AllowEdit = False
        Me.GV2_DOMAIN.OptionsColumn.ReadOnly = True
        Me.GV2_DOMAIN.Visible = True
        Me.GV2_DOMAIN.VisibleIndex = 1
        Me.GV2_DOMAIN.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_DOMAIN, "")
        '
        'GV2_CUST_CD
        '
        Me.GV2_CUST_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_CUST_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUST_CD.Caption = "코드"
        Me.GV2_CUST_CD.FieldName = "CUST_CD"
        Me.GV2_CUST_CD.Name = "GV2_CUST_CD"
        Me.GV2_CUST_CD.OptionsColumn.AllowEdit = False
        Me.GV2_CUST_CD.OptionsColumn.ReadOnly = True
        Me.GV2_CUST_CD.Width = 80
        Me.Localizer1.SetWordID(Me.GV2_CUST_CD, "")
        '
        'GV2_CUST_NM
        '
        Me.GV2_CUST_NM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV2_CUST_NM.AppearanceCell.Options.UseFont = True
        Me.GV2_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUST_NM.Caption = "거래처"
        Me.GV2_CUST_NM.FieldName = "CUST_NM"
        Me.GV2_CUST_NM.Name = "GV2_CUST_NM"
        Me.GV2_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV2_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV2_CUST_NM.Visible = True
        Me.GV2_CUST_NM.VisibleIndex = 2
        Me.GV2_CUST_NM.Width = 200
        Me.Localizer1.SetWordID(Me.GV2_CUST_NM, "")
        '
        'GV2_WEB_IP_EXT
        '
        Me.GV2_WEB_IP_EXT.Caption = "WEB IP (외부)"
        Me.GV2_WEB_IP_EXT.FieldName = "WEB_IP_EXT"
        Me.GV2_WEB_IP_EXT.Name = "GV2_WEB_IP_EXT"
        Me.GV2_WEB_IP_EXT.OptionsColumn.AllowEdit = False
        Me.GV2_WEB_IP_EXT.OptionsColumn.ReadOnly = True
        Me.GV2_WEB_IP_EXT.Visible = True
        Me.GV2_WEB_IP_EXT.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV2_WEB_IP_EXT, "WEB IP (외부)")
        '
        'GV2_DB_IP_EXT
        '
        Me.GV2_DB_IP_EXT.Caption = "DB IP (외부)"
        Me.GV2_DB_IP_EXT.FieldName = "DB_IP_EXT"
        Me.GV2_DB_IP_EXT.Name = "GV2_DB_IP_EXT"
        Me.GV2_DB_IP_EXT.OptionsColumn.AllowEdit = False
        Me.GV2_DB_IP_EXT.OptionsColumn.ReadOnly = True
        Me.GV2_DB_IP_EXT.Visible = True
        Me.GV2_DB_IP_EXT.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GV2_DB_IP_EXT, "DB IP (외부)")
        '
        'GV2_CTRY_CD
        '
        Me.GV2_CTRY_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_CTRY_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CTRY_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CTRY_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CTRY_CD.Caption = "국가"
        Me.GV2_CTRY_CD.FieldName = "CTRY_CD"
        Me.GV2_CTRY_CD.Name = "GV2_CTRY_CD"
        Me.GV2_CTRY_CD.OptionsColumn.AllowEdit = False
        Me.GV2_CTRY_CD.OptionsColumn.ReadOnly = True
        Me.GV2_CTRY_CD.Visible = True
        Me.GV2_CTRY_CD.VisibleIndex = 5
        Me.GV2_CTRY_CD.Width = 50
        Me.Localizer1.SetWordID(Me.GV2_CTRY_CD, "")
        '
        'GV2_LANG_CD
        '
        Me.GV2_LANG_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_LANG_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_LANG_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_LANG_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_LANG_CD.Caption = "언어"
        Me.GV2_LANG_CD.FieldName = "LANG_CD"
        Me.GV2_LANG_CD.Name = "GV2_LANG_CD"
        Me.GV2_LANG_CD.OptionsColumn.AllowEdit = False
        Me.GV2_LANG_CD.OptionsColumn.ReadOnly = True
        Me.GV2_LANG_CD.Visible = True
        Me.GV2_LANG_CD.VisibleIndex = 6
        Me.GV2_LANG_CD.Width = 50
        Me.Localizer1.SetWordID(Me.GV2_LANG_CD, "")
        '
        'GV2_ELVIS_BILL_YN
        '
        Me.GV2_ELVIS_BILL_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_ELVIS_BILL_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_ELVIS_BILL_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_ELVIS_BILL_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_ELVIS_BILL_YN.Caption = "ELVIS BILL"
        Me.GV2_ELVIS_BILL_YN.FieldName = "ELVIS_BILL_YN"
        Me.GV2_ELVIS_BILL_YN.Name = "GV2_ELVIS_BILL_YN"
        Me.GV2_ELVIS_BILL_YN.OptionsColumn.AllowEdit = False
        Me.GV2_ELVIS_BILL_YN.OptionsColumn.ReadOnly = True
        Me.GV2_ELVIS_BILL_YN.OptionsColumn.ShowInCustomizationForm = False
        Me.GV2_ELVIS_BILL_YN.Visible = True
        Me.GV2_ELVIS_BILL_YN.VisibleIndex = 7
        Me.GV2_ELVIS_BILL_YN.Width = 50
        Me.Localizer1.SetWordID(Me.GV2_ELVIS_BILL_YN, "ELVIS BILL")
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'BOARD_ID
        '
        Me.BOARD_ID.BackColor = System.Drawing.Color.OldLace
        Me.BOARD_ID.BorderColor = System.Drawing.Color.Silver
        Me.BOARD_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BOARD_ID.DefVal = ""
        Me.BOARD_ID.IsDataStateAware = True
        Me.BOARD_ID.Location = New System.Drawing.Point(746, 78)
        Me.BOARD_ID.MaxLength = 100
        Me.BOARD_ID.Name = "BOARD_ID"
        Me.BOARD_ID.NextFocus = "TITLE"
        Me.BOARD_ID.ReadOnly = True
        Me.BOARD_ID.Size = New System.Drawing.Size(78, 22)
        Me.BOARD_ID.TabIndex = 121
        Me.BOARD_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BOARD_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'TITLE
        '
        Me.TITLE.BackColor = System.Drawing.Color.OldLace
        Me.TITLE.BorderColor = System.Drawing.Color.Silver
        Me.TITLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TITLE.DefVal = ""
        Me.TITLE.IsDataStateAware = True
        Me.TITLE.Location = New System.Drawing.Point(892, 78)
        Me.TITLE.MaxLength = 100
        Me.TITLE.Name = "TITLE"
        Me.TITLE.NextFocus = "USR_ID"
        Me.TITLE.ReadOnly = True
        Me.TITLE.Size = New System.Drawing.Size(354, 22)
        Me.TITLE.TabIndex = 122
        Me.TITLE.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'Label1
        '
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(724, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 22)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "#"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "No")
        '
        'Label2
        '
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(830, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Subject"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "Subject")
        '
        'SysBoardList
        '
        Me.AllowMdiBar = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1251, 608)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TITLE)
        Me.Controls.Add(Me.BOARD_ID)
        Me.Controls.Add(Me.WG2)
        Me.Controls.Add(Me.WG1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(525, 646)
        Me.Name = "SysBoardList"
        Me.Text = "공지사항 리스트"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnNew As YJIT.SC.UI.SCControls.Button
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Private WithEvents iconImages As DevExpress.Utils.ImageCollection
    Friend WithEvents LBL_TITLE As YJIT.SC.UI.SCControls.Label
    Public WithEvents S_TITLE As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents LBL_MNGT_NO As YJIT.SC.UI.SCControls.Label
    Public WithEvents S_BOARD_ID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Public WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_BOARD_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_USR_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_DATE_TO As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents S_DATE_FM As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label32 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_OP_NM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents S_OP_CD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents Label14 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV2_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_DOMAIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_CTRY_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_LANG_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV2_CHK As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents BOARD_ID As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents TITLE As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV1_EDIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV2_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SVC_CD As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label37 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV2_DB_IP_EXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_NOTICE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV1_BOARD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_WEB_IP_EXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_ELVIS_BILL_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
