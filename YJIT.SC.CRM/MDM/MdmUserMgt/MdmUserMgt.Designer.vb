<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdmUserMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdmUserMgt))
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_LOC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEPT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEPT_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PSWD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PSWD_CHG_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.RANK = New YJIT.SC.UI.SCControls.ComboBox()
        Me.lbl_USR_TITLE_CD = New YJIT.SC.UI.SCControls.Label()
        Me.RECVMSG_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.lbl_RECVMSG_YN = New YJIT.SC.UI.SCControls.Label()
        Me.AUTH_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.LBL_AUTH_TYPE = New YJIT.SC.UI.SCControls.Label()
        Me.DEPT_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.DEPT_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.LBL_RMK = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_DEPT_CD = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_EMAIL = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_HP_NO = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_FAX_NO = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_TEL_NO = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_PSWD1 = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_PSWD = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_ENG_NM = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_SUB_USR_NM = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_USE_YN = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_SUB_USR_ID = New YJIT.SC.UI.SCControls.Label()
        Me.TEL_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.PSWD1 = New YJIT.SC.UI.SCControls.TextBox()
        Me.ENG_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.USE_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.RMK = New YJIT.SC.UI.SCControls.TextBox()
        Me.FAX_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.PSWD = New YJIT.SC.UI.SCControls.TextBox()
        Me.HP_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.EMAIL = New YJIT.SC.UI.SCControls.TextBox()
        Me.LOC_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.USR_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.S_USER_CNT_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.S_USE_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_USR_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.LBL_S_USR_ID = New YJIT.SC.UI.SCControls.Label()
        Me.S_USR_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.LBL_S_USR_NM = New YJIT.SC.UI.SCControls.Label()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
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
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(921, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(845, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(70, 25)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Location = New System.Drawing.Point(3, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(998, 32)
        Me.palAutoButton.TabIndex = 1
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(769, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_USR_ID, "User ID")
        Me.Localizer1.SetWordID(Me.GV1_LOC_NM, "User Name")
        Me.Localizer1.SetWordID(Me.GV1_DEPT_CD, "Dept Code")
        Me.Localizer1.SetWordID(Me.GV1_DEPT_NM, "Dept Name")
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "Activity")
        Me.Localizer1.SetWordID(Me.GV1_PSWD, "Password(encryption)")
        Me.Localizer1.SetWordID(Me.GV1_PSWD_CHG_YMD, "Password Change Date")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.RANK, "--Select--")
        Me.Localizer1.SetWordID(Me.lbl_USR_TITLE_CD, "Position")
        Me.Localizer1.SetWordID(Me.RECVMSG_YN, "Yes")
        Me.Localizer1.SetWordID(Me.lbl_RECVMSG_YN, "Push Alarm(Y/N)")
        Me.Localizer1.SetWordID(Me.AUTH_TYPE, "--Select--")
        Me.Localizer1.SetWordID(Me.LBL_AUTH_TYPE, "Authority Group")
        Me.Localizer1.SetWordID(Me.DEPT_CD, "")
        Me.Localizer1.SetWordID(Me.LBL_RMK, "Remark")
        Me.Localizer1.SetWordID(Me.LBL_DEPT_CD, "Department")
        Me.Localizer1.SetWordID(Me.LBL_EMAIL, "E-mail")
        Me.Localizer1.SetWordID(Me.LBL_HP_NO, "Mobile Phone")
        Me.Localizer1.SetWordID(Me.LBL_FAX_NO, "FAX No")
        Me.Localizer1.SetWordID(Me.LBL_TEL_NO, "TEL No")
        Me.Localizer1.SetWordID(Me.LBL_PSWD1, "Confirm Password")
        Me.Localizer1.SetWordID(Me.LBL_PSWD, "Password")
        Me.Localizer1.SetWordID(Me.LBL_ENG_NM, "User Name(EN)")
        Me.Localizer1.SetWordID(Me.LBL_SUB_USR_NM, "User Name")
        Me.Localizer1.SetWordID(Me.LBL_USE_YN, "Activity")
        Me.Localizer1.SetWordID(Me.LBL_SUB_USR_ID, "*User Id")
        Me.Localizer1.SetWordID(Me.TEL_NO, "")
        Me.Localizer1.SetWordID(Me.PSWD1, "")
        Me.Localizer1.SetWordID(Me.ENG_NM, "")
        Me.Localizer1.SetWordID(Me.USE_YN, "--Select--")
        Me.Localizer1.SetWordID(Me.RMK, "")
        Me.Localizer1.SetWordID(Me.FAX_NO, "")
        Me.Localizer1.SetWordID(Me.PSWD, "")
        Me.Localizer1.SetWordID(Me.HP_NO, "")
        Me.Localizer1.SetWordID(Me.EMAIL, "")
        Me.Localizer1.SetWordID(Me.LOC_NM, "")
        Me.Localizer1.SetWordID(Me.USR_ID, "")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.S_USER_CNT_YN, "Yes")
        Me.Localizer1.SetWordID(Me.Label6, "Activity")
        Me.Localizer1.SetWordID(Me.S_USE_YN, "--Select--")
        Me.Localizer1.SetWordID(Me.S_USR_ID, "")
        Me.Localizer1.SetWordID(Me.LBL_S_USR_ID, "User Id")
        Me.Localizer1.SetWordID(Me.S_USR_NM, "")
        Me.Localizer1.SetWordID(Me.LBL_S_USR_NM, "User Name")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(3, 84)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(472, 546)
        Me.WG1.TabIndex = 5
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_USR_ID, Me.GV1_LOC_NM, Me.GV1_DEPT_CD, Me.GV1_DEPT_NM, Me.GV1_USE_YN, Me.GV1_PSWD, Me.GV1_PSWD_CHG_YMD})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsBehavior.ReadOnly = True
        Me.GV1.OptionsCustomization.AllowColumnMoving = False
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GV1_USR_ID
        '
        Me.GV1_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USR_ID.Caption = "User ID"
        Me.GV1_USR_ID.FieldName = "USR_ID"
        Me.GV1_USR_ID.Name = "GV1_USR_ID"
        Me.GV1_USR_ID.Visible = True
        Me.GV1_USR_ID.VisibleIndex = 0
        Me.GV1_USR_ID.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_USR_ID, "User ID")
        '
        'GV1_LOC_NM
        '
        Me.GV1_LOC_NM.Caption = "User Name"
        Me.GV1_LOC_NM.FieldName = "LOC_NM"
        Me.GV1_LOC_NM.Name = "GV1_LOC_NM"
        Me.GV1_LOC_NM.Visible = True
        Me.GV1_LOC_NM.VisibleIndex = 1
        Me.GV1_LOC_NM.Width = 81
        Me.Localizer1.SetWordID(Me.GV1_LOC_NM, "User Name")
        '
        'GV1_DEPT_CD
        '
        Me.GV1_DEPT_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DEPT_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DEPT_CD.Caption = "Dept Code"
        Me.GV1_DEPT_CD.FieldName = "DEPT_CD"
        Me.GV1_DEPT_CD.Name = "GV1_DEPT_CD"
        Me.GV1_DEPT_CD.Visible = True
        Me.GV1_DEPT_CD.VisibleIndex = 2
        Me.GV1_DEPT_CD.Width = 76
        Me.Localizer1.SetWordID(Me.GV1_DEPT_CD, "Dept Code")
        '
        'GV1_DEPT_NM
        '
        Me.GV1_DEPT_NM.Caption = "Dept Name"
        Me.GV1_DEPT_NM.FieldName = "DEPT_NM"
        Me.GV1_DEPT_NM.Name = "GV1_DEPT_NM"
        Me.GV1_DEPT_NM.Visible = True
        Me.GV1_DEPT_NM.VisibleIndex = 3
        Me.GV1_DEPT_NM.Width = 111
        Me.Localizer1.SetWordID(Me.GV1_DEPT_NM, "")
        '
        'GV1_USE_YN
        '
        Me.GV1_USE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USE_YN.Caption = "Activity"
        Me.GV1_USE_YN.FieldName = "USE_YN"
        Me.GV1_USE_YN.Name = "GV1_USE_YN"
        Me.GV1_USE_YN.Visible = True
        Me.GV1_USE_YN.VisibleIndex = 4
        Me.GV1_USE_YN.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "Activity")
        '
        'GV1_PSWD
        '
        Me.GV1_PSWD.Caption = "Password(encryption)"
        Me.GV1_PSWD.FieldName = "PSWD"
        Me.GV1_PSWD.Name = "GV1_PSWD"
        Me.GV1_PSWD.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_PSWD, "")
        '
        'GV1_PSWD_CHG_YMD
        '
        Me.GV1_PSWD_CHG_YMD.Caption = "Password Change Date"
        Me.GV1_PSWD_CHG_YMD.FieldName = "PSWD_CHG_YMD"
        Me.GV1_PSWD_CHG_YMD.Name = "GV1_PSWD_CHG_YMD"
        Me.GV1_PSWD_CHG_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_PSWD_CHG_YMD, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.RANK)
        Me.PanelControl2.Controls.Add(Me.lbl_USR_TITLE_CD)
        Me.PanelControl2.Controls.Add(Me.RECVMSG_YN)
        Me.PanelControl2.Controls.Add(Me.lbl_RECVMSG_YN)
        Me.PanelControl2.Controls.Add(Me.AUTH_TYPE)
        Me.PanelControl2.Controls.Add(Me.LBL_AUTH_TYPE)
        Me.PanelControl2.Controls.Add(Me.DEPT_NM)
        Me.PanelControl2.Controls.Add(Me.DEPT_CD)
        Me.PanelControl2.Controls.Add(Me.LBL_RMK)
        Me.PanelControl2.Controls.Add(Me.LBL_DEPT_CD)
        Me.PanelControl2.Controls.Add(Me.LBL_EMAIL)
        Me.PanelControl2.Controls.Add(Me.LBL_HP_NO)
        Me.PanelControl2.Controls.Add(Me.LBL_FAX_NO)
        Me.PanelControl2.Controls.Add(Me.LBL_TEL_NO)
        Me.PanelControl2.Controls.Add(Me.LBL_PSWD1)
        Me.PanelControl2.Controls.Add(Me.LBL_PSWD)
        Me.PanelControl2.Controls.Add(Me.LBL_ENG_NM)
        Me.PanelControl2.Controls.Add(Me.LBL_SUB_USR_NM)
        Me.PanelControl2.Controls.Add(Me.LBL_USE_YN)
        Me.PanelControl2.Controls.Add(Me.LBL_SUB_USR_ID)
        Me.PanelControl2.Controls.Add(Me.TEL_NO)
        Me.PanelControl2.Controls.Add(Me.PSWD1)
        Me.PanelControl2.Controls.Add(Me.ENG_NM)
        Me.PanelControl2.Controls.Add(Me.USE_YN)
        Me.PanelControl2.Controls.Add(Me.RMK)
        Me.PanelControl2.Controls.Add(Me.FAX_NO)
        Me.PanelControl2.Controls.Add(Me.PSWD)
        Me.PanelControl2.Controls.Add(Me.HP_NO)
        Me.PanelControl2.Controls.Add(Me.EMAIL)
        Me.PanelControl2.Controls.Add(Me.LOC_NM)
        Me.PanelControl2.Controls.Add(Me.USR_ID)
        Me.PanelControl2.Location = New System.Drawing.Point(481, 84)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(520, 546)
        Me.PanelControl2.TabIndex = 6
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'RANK
        '
        Me.RANK.CodeType = "YJIT.CodeService.CommonCode"
        Me.RANK.ColumnWidths = ""
        Me.RANK.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.RANK.DataParams = "GroupCode:'C10',NameType:''"
        Me.RANK.DefVal = ""
        Me.RANK.DisplayMember = "NAME"
        Me.RANK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RANK.FormattingEnabled = True
        Me.RANK.IsDataStateAware = True
        Me.RANK.ItemDelimiter = ","
        Me.RANK.ItemTextList = ""
        Me.RANK.ItemValueList = ""
        Me.RANK.KeepIntegrity = True
        Me.RANK.Location = New System.Drawing.Point(363, 148)
        Me.RANK.Name = "RANK"
        Me.RANK.NextFocus = "TEL_NO"
        Me.RANK.NullText = "--Select--"
        Me.RANK.SearchKeys = ""
        Me.RANK.Size = New System.Drawing.Size(150, 22)
        Me.RANK.TabIndex = 228
        Me.RANK.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.RANK.ValueMember = "CODE"
        '
        'lbl_USR_TITLE_CD
        '
        Me.lbl_USR_TITLE_CD.AutoEllipsis = True
        Me.lbl_USR_TITLE_CD.AutoSize = True
        Me.lbl_USR_TITLE_CD.LabelFor = Nothing
        Me.lbl_USR_TITLE_CD.Location = New System.Drawing.Point(308, 152)
        Me.lbl_USR_TITLE_CD.Name = "lbl_USR_TITLE_CD"
        Me.lbl_USR_TITLE_CD.Size = New System.Drawing.Size(49, 14)
        Me.lbl_USR_TITLE_CD.TabIndex = 229
        Me.lbl_USR_TITLE_CD.Text = "Position"
        Me.lbl_USR_TITLE_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_USR_TITLE_CD, "Position")
        '
        'RECVMSG_YN
        '
        Me.RECVMSG_YN.CodeType = ""
        Me.RECVMSG_YN.ColumnWidths = ""
        Me.RECVMSG_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.RECVMSG_YN.DataParams = ""
        Me.RECVMSG_YN.DefVal = "Y"
        Me.RECVMSG_YN.DisplayMember = "NAME"
        Me.RECVMSG_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RECVMSG_YN.FormattingEnabled = True
        Me.RECVMSG_YN.IsDataStateAware = True
        Me.RECVMSG_YN.ItemDelimiter = ","
        Me.RECVMSG_YN.ItemTextList = "Yes,No"
        Me.RECVMSG_YN.ItemValueList = "Y,N"
        Me.RECVMSG_YN.KeepIntegrity = True
        Me.RECVMSG_YN.Location = New System.Drawing.Point(420, 36)
        Me.RECVMSG_YN.Name = "RECVMSG_YN"
        Me.RECVMSG_YN.NextFocus = "ENG_NM"
        Me.RECVMSG_YN.NullText = ""
        Me.RECVMSG_YN.SearchKeys = ""
        Me.RECVMSG_YN.Size = New System.Drawing.Size(93, 22)
        Me.RECVMSG_YN.TabIndex = 227
        Me.RECVMSG_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.RECVMSG_YN.ValueMember = "CODE"
        '
        'lbl_RECVMSG_YN
        '
        Me.lbl_RECVMSG_YN.AutoEllipsis = True
        Me.lbl_RECVMSG_YN.AutoSize = True
        Me.lbl_RECVMSG_YN.LabelFor = Nothing
        Me.lbl_RECVMSG_YN.Location = New System.Drawing.Point(317, 40)
        Me.lbl_RECVMSG_YN.Name = "lbl_RECVMSG_YN"
        Me.lbl_RECVMSG_YN.Size = New System.Drawing.Size(98, 14)
        Me.lbl_RECVMSG_YN.TabIndex = 226
        Me.lbl_RECVMSG_YN.Text = "Push Alarm(Y/N)"
        Me.lbl_RECVMSG_YN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_RECVMSG_YN, "Push Alarm(Y/N)")
        '
        'AUTH_TYPE
        '
        Me.AUTH_TYPE.CodeType = "YJIT.CodeService.CommonCode"
        Me.AUTH_TYPE.ColumnWidths = ""
        Me.AUTH_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.AUTH_TYPE.DataParams = "GroupCode:'S04',NameType:''"
        Me.AUTH_TYPE.DefVal = ""
        Me.AUTH_TYPE.DisplayMember = "NAME"
        Me.AUTH_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AUTH_TYPE.FormattingEnabled = True
        Me.AUTH_TYPE.IsDataStateAware = True
        Me.AUTH_TYPE.ItemDelimiter = ","
        Me.AUTH_TYPE.ItemTextList = ""
        Me.AUTH_TYPE.ItemValueList = ""
        Me.AUTH_TYPE.KeepIntegrity = True
        Me.AUTH_TYPE.Location = New System.Drawing.Point(144, 148)
        Me.AUTH_TYPE.Name = "AUTH_TYPE"
        Me.AUTH_TYPE.NextFocus = "RANK"
        Me.AUTH_TYPE.NullText = "--Select--"
        Me.AUTH_TYPE.SearchKeys = ""
        Me.AUTH_TYPE.Size = New System.Drawing.Size(150, 22)
        Me.AUTH_TYPE.TabIndex = 207
        Me.AUTH_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.AUTH_TYPE.ValueMember = "CODE"
        '
        'LBL_AUTH_TYPE
        '
        Me.LBL_AUTH_TYPE.AutoEllipsis = True
        Me.LBL_AUTH_TYPE.AutoSize = True
        Me.LBL_AUTH_TYPE.LabelFor = Nothing
        Me.LBL_AUTH_TYPE.Location = New System.Drawing.Point(43, 152)
        Me.LBL_AUTH_TYPE.Name = "LBL_AUTH_TYPE"
        Me.LBL_AUTH_TYPE.Size = New System.Drawing.Size(95, 14)
        Me.LBL_AUTH_TYPE.TabIndex = 208
        Me.LBL_AUTH_TYPE.Text = "Authority Group"
        Me.LBL_AUTH_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_AUTH_TYPE, "Authority Group")
        '
        'DEPT_NM
        '
        Me.DEPT_NM.AutoEllipsis = True
        Me.DEPT_NM.BorderColor = System.Drawing.Color.Silver
        Me.DEPT_NM.LabelFor = Nothing
        Me.DEPT_NM.Location = New System.Drawing.Point(250, 232)
        Me.DEPT_NM.Name = "DEPT_NM"
        Me.DEPT_NM.Size = New System.Drawing.Size(263, 22)
        Me.DEPT_NM.TabIndex = 206
        Me.DEPT_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DEPT_CD
        '
        Me.DEPT_CD.AlwaysSetDisplayParams = False
        Me.DEPT_CD.AutoSuggestion = True
        Me.DEPT_CD.BorderColor = System.Drawing.Color.Silver
        Me.DEPT_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DEPT_CD.CodeType = "YJIT.CodeService.CommonCode"
        Me.DEPT_CD.DataParams = "GroupCode:'C03',NameType:'',Valid:'V'"
        Me.DEPT_CD.DefVal = ""
        Me.DEPT_CD.DisplayParams = "Code:@DEPT_CD,Name:@DEPT_NM"
        Me.DEPT_CD.EditPopup = ""
        Me.DEPT_CD.IconVisible = True
        Me.DEPT_CD.IsDataStateAware = True
        Me.DEPT_CD.KeepIntegrity = True
        Me.DEPT_CD.Location = New System.Drawing.Point(144, 232)
        Me.DEPT_CD.MaxLength = 10
        Me.DEPT_CD.Name = "DEPT_CD"
        Me.DEPT_CD.NextFocus = "RMK"
        Me.DEPT_CD.SearchPopup = "CodeMaster"
        Me.DEPT_CD.Size = New System.Drawing.Size(96, 22)
        Me.DEPT_CD.SuppressValidateCode = False
        Me.DEPT_CD.TabIndex = 195
        Me.DEPT_CD.TextCasing = YJIT.SC.UI.TextCasings.Upper
        Me.DEPT_CD.ValidateKeys = "KEY:@DEPT_CD"
        '
        'LBL_RMK
        '
        Me.LBL_RMK.AutoEllipsis = True
        Me.LBL_RMK.LabelFor = Nothing
        Me.LBL_RMK.Location = New System.Drawing.Point(17, 260)
        Me.LBL_RMK.Name = "LBL_RMK"
        Me.LBL_RMK.Size = New System.Drawing.Size(126, 22)
        Me.LBL_RMK.TabIndex = 186
        Me.LBL_RMK.Text = "Remark"
        Me.LBL_RMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_RMK, "Remark")
        '
        'LBL_DEPT_CD
        '
        Me.LBL_DEPT_CD.AutoEllipsis = True
        Me.LBL_DEPT_CD.LabelFor = Nothing
        Me.LBL_DEPT_CD.Location = New System.Drawing.Point(17, 232)
        Me.LBL_DEPT_CD.Name = "LBL_DEPT_CD"
        Me.LBL_DEPT_CD.Size = New System.Drawing.Size(126, 22)
        Me.LBL_DEPT_CD.TabIndex = 184
        Me.LBL_DEPT_CD.Text = "Department"
        Me.LBL_DEPT_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_DEPT_CD, "Department")
        '
        'LBL_EMAIL
        '
        Me.LBL_EMAIL.AutoEllipsis = True
        Me.LBL_EMAIL.LabelFor = Nothing
        Me.LBL_EMAIL.Location = New System.Drawing.Point(309, 204)
        Me.LBL_EMAIL.Name = "LBL_EMAIL"
        Me.LBL_EMAIL.Size = New System.Drawing.Size(51, 22)
        Me.LBL_EMAIL.TabIndex = 183
        Me.LBL_EMAIL.Text = "E-mail"
        Me.LBL_EMAIL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_EMAIL, "E-mail")
        '
        'LBL_HP_NO
        '
        Me.LBL_HP_NO.AutoEllipsis = True
        Me.LBL_HP_NO.LabelFor = Nothing
        Me.LBL_HP_NO.Location = New System.Drawing.Point(17, 204)
        Me.LBL_HP_NO.Name = "LBL_HP_NO"
        Me.LBL_HP_NO.Size = New System.Drawing.Size(126, 22)
        Me.LBL_HP_NO.TabIndex = 182
        Me.LBL_HP_NO.Text = "Mobile Phone"
        Me.LBL_HP_NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_HP_NO, "Mobile Phone")
        '
        'LBL_FAX_NO
        '
        Me.LBL_FAX_NO.AutoEllipsis = True
        Me.LBL_FAX_NO.LabelFor = Nothing
        Me.LBL_FAX_NO.Location = New System.Drawing.Point(309, 176)
        Me.LBL_FAX_NO.Name = "LBL_FAX_NO"
        Me.LBL_FAX_NO.Size = New System.Drawing.Size(51, 22)
        Me.LBL_FAX_NO.TabIndex = 181
        Me.LBL_FAX_NO.Text = "FAX No"
        Me.LBL_FAX_NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_FAX_NO, "FAX No")
        '
        'LBL_TEL_NO
        '
        Me.LBL_TEL_NO.AutoEllipsis = True
        Me.LBL_TEL_NO.LabelFor = Nothing
        Me.LBL_TEL_NO.Location = New System.Drawing.Point(17, 176)
        Me.LBL_TEL_NO.Name = "LBL_TEL_NO"
        Me.LBL_TEL_NO.Size = New System.Drawing.Size(126, 22)
        Me.LBL_TEL_NO.TabIndex = 180
        Me.LBL_TEL_NO.Text = "TEL No"
        Me.LBL_TEL_NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_TEL_NO, "TEL No")
        '
        'LBL_PSWD1
        '
        Me.LBL_PSWD1.AutoEllipsis = True
        Me.LBL_PSWD1.LabelFor = Nothing
        Me.LBL_PSWD1.Location = New System.Drawing.Point(17, 120)
        Me.LBL_PSWD1.Name = "LBL_PSWD1"
        Me.LBL_PSWD1.Size = New System.Drawing.Size(126, 22)
        Me.LBL_PSWD1.TabIndex = 175
        Me.LBL_PSWD1.Text = "Confirm Password"
        Me.LBL_PSWD1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_PSWD1, "Confirm Password")
        '
        'LBL_PSWD
        '
        Me.LBL_PSWD.AutoEllipsis = True
        Me.LBL_PSWD.LabelFor = Nothing
        Me.LBL_PSWD.Location = New System.Drawing.Point(17, 92)
        Me.LBL_PSWD.Name = "LBL_PSWD"
        Me.LBL_PSWD.Size = New System.Drawing.Size(126, 22)
        Me.LBL_PSWD.TabIndex = 174
        Me.LBL_PSWD.Text = "Password"
        Me.LBL_PSWD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_PSWD, "Password")
        '
        'LBL_ENG_NM
        '
        Me.LBL_ENG_NM.AutoEllipsis = True
        Me.LBL_ENG_NM.LabelFor = Nothing
        Me.LBL_ENG_NM.Location = New System.Drawing.Point(17, 64)
        Me.LBL_ENG_NM.Name = "LBL_ENG_NM"
        Me.LBL_ENG_NM.Size = New System.Drawing.Size(126, 22)
        Me.LBL_ENG_NM.TabIndex = 173
        Me.LBL_ENG_NM.Text = "User Name(EN)"
        Me.LBL_ENG_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_ENG_NM, "User Name(EN)")
        '
        'LBL_SUB_USR_NM
        '
        Me.LBL_SUB_USR_NM.AutoEllipsis = True
        Me.LBL_SUB_USR_NM.LabelFor = Nothing
        Me.LBL_SUB_USR_NM.Location = New System.Drawing.Point(17, 36)
        Me.LBL_SUB_USR_NM.Name = "LBL_SUB_USR_NM"
        Me.LBL_SUB_USR_NM.Size = New System.Drawing.Size(126, 22)
        Me.LBL_SUB_USR_NM.TabIndex = 172
        Me.LBL_SUB_USR_NM.Text = "User Name"
        Me.LBL_SUB_USR_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_SUB_USR_NM, "User Name")
        '
        'LBL_USE_YN
        '
        Me.LBL_USE_YN.AutoEllipsis = True
        Me.LBL_USE_YN.LabelFor = Nothing
        Me.LBL_USE_YN.Location = New System.Drawing.Point(367, 8)
        Me.LBL_USE_YN.Name = "LBL_USE_YN"
        Me.LBL_USE_YN.Size = New System.Drawing.Size(47, 22)
        Me.LBL_USE_YN.TabIndex = 171
        Me.LBL_USE_YN.Text = "Activity"
        Me.LBL_USE_YN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_USE_YN, "Activity")
        '
        'LBL_SUB_USR_ID
        '
        Me.LBL_SUB_USR_ID.AutoEllipsis = True
        Me.LBL_SUB_USR_ID.LabelFor = Nothing
        Me.LBL_SUB_USR_ID.Location = New System.Drawing.Point(17, 8)
        Me.LBL_SUB_USR_ID.Name = "LBL_SUB_USR_ID"
        Me.LBL_SUB_USR_ID.Size = New System.Drawing.Size(126, 22)
        Me.LBL_SUB_USR_ID.TabIndex = 170
        Me.LBL_SUB_USR_ID.Text = "User Id"
        Me.LBL_SUB_USR_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_SUB_USR_ID, "*User Id")
        '
        'TEL_NO
        '
        Me.TEL_NO.BorderColor = System.Drawing.Color.Silver
        Me.TEL_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TEL_NO.DefVal = ""
        Me.TEL_NO.IsDataStateAware = True
        Me.TEL_NO.Location = New System.Drawing.Point(144, 176)
        Me.TEL_NO.MaxLength = 30
        Me.TEL_NO.Name = "TEL_NO"
        Me.TEL_NO.NextFocus = "FAX_NO"
        Me.TEL_NO.Size = New System.Drawing.Size(150, 22)
        Me.TEL_NO.TabIndex = 48
        Me.TEL_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'PSWD1
        '
        Me.PSWD1.BorderColor = System.Drawing.Color.Silver
        Me.PSWD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSWD1.DefVal = ""
        Me.PSWD1.IsDataStateAware = True
        Me.PSWD1.Location = New System.Drawing.Point(144, 120)
        Me.PSWD1.MaxLength = 10
        Me.PSWD1.Name = "PSWD1"
        Me.PSWD1.NextFocus = "AUTH_TYPE"
        Me.PSWD1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PSWD1.Size = New System.Drawing.Size(150, 22)
        Me.PSWD1.TabIndex = 46
        Me.PSWD1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'ENG_NM
        '
        Me.ENG_NM.BorderColor = System.Drawing.Color.Silver
        Me.ENG_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ENG_NM.DefVal = ""
        Me.ENG_NM.IsDataStateAware = True
        Me.ENG_NM.Location = New System.Drawing.Point(144, 64)
        Me.ENG_NM.MaxLength = 30
        Me.ENG_NM.Name = "ENG_NM"
        Me.ENG_NM.NextFocus = "PSWD"
        Me.ENG_NM.Size = New System.Drawing.Size(369, 22)
        Me.ENG_NM.TabIndex = 2
        Me.ENG_NM.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'USE_YN
        '
        Me.USE_YN.CodeType = ""
        Me.USE_YN.ColumnWidths = ""
        Me.USE_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.USE_YN.DataParams = ""
        Me.USE_YN.DefVal = ""
        Me.USE_YN.DisplayMember = "NAME"
        Me.USE_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.USE_YN.FormattingEnabled = True
        Me.USE_YN.IsDataStateAware = True
        Me.USE_YN.ItemDelimiter = ","
        Me.USE_YN.ItemTextList = "Active,Inactive"
        Me.USE_YN.ItemValueList = "Y,N"
        Me.USE_YN.KeepIntegrity = True
        Me.USE_YN.Location = New System.Drawing.Point(420, 8)
        Me.USE_YN.Name = "USE_YN"
        Me.USE_YN.NextFocus = "LOC_NM"
        Me.USE_YN.NullText = "--Select--"
        Me.USE_YN.SearchKeys = ""
        Me.USE_YN.Size = New System.Drawing.Size(93, 22)
        Me.USE_YN.TabIndex = 1
        Me.USE_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.USE_YN.ValueMember = "CODE"
        '
        'RMK
        '
        Me.RMK.BorderColor = System.Drawing.Color.Silver
        Me.RMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RMK.DefVal = ""
        Me.RMK.IsDataStateAware = True
        Me.RMK.Location = New System.Drawing.Point(144, 260)
        Me.RMK.MaxLength = 100
        Me.RMK.Multiline = True
        Me.RMK.Name = "RMK"
        Me.RMK.NextFocus = "btnSave"
        Me.RMK.Size = New System.Drawing.Size(369, 36)
        Me.RMK.TabIndex = 202
        Me.RMK.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'FAX_NO
        '
        Me.FAX_NO.BorderColor = System.Drawing.Color.Silver
        Me.FAX_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FAX_NO.DefVal = ""
        Me.FAX_NO.IsDataStateAware = True
        Me.FAX_NO.Location = New System.Drawing.Point(363, 176)
        Me.FAX_NO.MaxLength = 30
        Me.FAX_NO.Name = "FAX_NO"
        Me.FAX_NO.NextFocus = "HP_NO"
        Me.FAX_NO.Size = New System.Drawing.Size(150, 22)
        Me.FAX_NO.TabIndex = 10
        Me.FAX_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'PSWD
        '
        Me.PSWD.BorderColor = System.Drawing.Color.Silver
        Me.PSWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSWD.DefVal = ""
        Me.PSWD.IsDataStateAware = True
        Me.PSWD.Location = New System.Drawing.Point(144, 92)
        Me.PSWD.MaxLength = 10
        Me.PSWD.Name = "PSWD"
        Me.PSWD.NextFocus = "PSWD1"
        Me.PSWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PSWD.Size = New System.Drawing.Size(150, 22)
        Me.PSWD.TabIndex = 4
        Me.PSWD.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'HP_NO
        '
        Me.HP_NO.BorderColor = System.Drawing.Color.Silver
        Me.HP_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HP_NO.DefVal = ""
        Me.HP_NO.IsDataStateAware = True
        Me.HP_NO.Location = New System.Drawing.Point(144, 204)
        Me.HP_NO.MaxLength = 30
        Me.HP_NO.Name = "HP_NO"
        Me.HP_NO.NextFocus = "EMAIL"
        Me.HP_NO.Size = New System.Drawing.Size(150, 22)
        Me.HP_NO.TabIndex = 8
        Me.HP_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'EMAIL
        '
        Me.EMAIL.BorderColor = System.Drawing.Color.Silver
        Me.EMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EMAIL.DefVal = ""
        Me.EMAIL.IsDataStateAware = True
        Me.EMAIL.Location = New System.Drawing.Point(363, 204)
        Me.EMAIL.MaxLength = 50
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.NextFocus = "DEPT_CD"
        Me.EMAIL.Size = New System.Drawing.Size(150, 22)
        Me.EMAIL.TabIndex = 11
        Me.EMAIL.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'LOC_NM
        '
        Me.LOC_NM.BorderColor = System.Drawing.Color.Silver
        Me.LOC_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LOC_NM.DefVal = ""
        Me.LOC_NM.IsDataStateAware = True
        Me.LOC_NM.Location = New System.Drawing.Point(144, 36)
        Me.LOC_NM.MaxLength = 30
        Me.LOC_NM.Name = "LOC_NM"
        Me.LOC_NM.NextFocus = "RECVMSG_YN"
        Me.LOC_NM.Size = New System.Drawing.Size(150, 22)
        Me.LOC_NM.TabIndex = 3
        Me.LOC_NM.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'USR_ID
        '
        Me.USR_ID.BackColor = System.Drawing.SystemColors.Window
        Me.USR_ID.BorderColor = System.Drawing.Color.Silver
        Me.USR_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.USR_ID.DefVal = ""
        Me.USR_ID.Enabled = False
        Me.USR_ID.IsDataStateAware = True
        Me.USR_ID.Location = New System.Drawing.Point(144, 8)
        Me.USR_ID.MaxLength = 10
        Me.USR_ID.Name = "USR_ID"
        Me.USR_ID.NextFocus = "USE_YN"
        Me.USR_ID.Size = New System.Drawing.Size(150, 22)
        Me.USR_ID.TabIndex = 0
        Me.USR_ID.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.S_USER_CNT_YN)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.S_USE_YN)
        Me.PanelControl1.Controls.Add(Me.S_USR_ID)
        Me.PanelControl1.Controls.Add(Me.LBL_S_USR_ID)
        Me.PanelControl1.Controls.Add(Me.S_USR_NM)
        Me.PanelControl1.Controls.Add(Me.LBL_S_USR_NM)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 42)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(998, 36)
        Me.PanelControl1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'S_USER_CNT_YN
        '
        Me.S_USER_CNT_YN.CodeType = ""
        Me.S_USER_CNT_YN.ColumnWidths = ""
        Me.S_USER_CNT_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_USER_CNT_YN.DataParams = ""
        Me.S_USER_CNT_YN.DefVal = "Y"
        Me.S_USER_CNT_YN.DisplayMember = "NAME"
        Me.S_USER_CNT_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_USER_CNT_YN.FormattingEnabled = True
        Me.S_USER_CNT_YN.IsDataStateAware = True
        Me.S_USER_CNT_YN.ItemDelimiter = ","
        Me.S_USER_CNT_YN.ItemTextList = "Yes,No"
        Me.S_USER_CNT_YN.ItemValueList = "Y,N"
        Me.S_USER_CNT_YN.KeepIntegrity = True
        Me.S_USER_CNT_YN.Location = New System.Drawing.Point(663, 8)
        Me.S_USER_CNT_YN.Name = "S_USER_CNT_YN"
        Me.S_USER_CNT_YN.NextFocus = "btnSave"
        Me.S_USER_CNT_YN.NullText = "--Select--"
        Me.S_USER_CNT_YN.SearchKeys = ""
        Me.S_USER_CNT_YN.Size = New System.Drawing.Size(49, 22)
        Me.S_USER_CNT_YN.TabIndex = 219
        Me.S_USER_CNT_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_USER_CNT_YN.ValueMember = "CODE"
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(530, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 22)
        Me.Label6.TabIndex = 201
        Me.Label6.Text = "Activity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label6, "Activity")
        '
        'S_USE_YN
        '
        Me.S_USE_YN.CodeType = ""
        Me.S_USE_YN.ColumnWidths = ""
        Me.S_USE_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_USE_YN.DataParams = ""
        Me.S_USE_YN.DefVal = "Y"
        Me.S_USE_YN.DisplayMember = "NAME"
        Me.S_USE_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_USE_YN.FormattingEnabled = True
        Me.S_USE_YN.IsDataStateAware = True
        Me.S_USE_YN.ItemDelimiter = ","
        Me.S_USE_YN.ItemTextList = "Active,Inactive"
        Me.S_USE_YN.ItemValueList = "Y,N"
        Me.S_USE_YN.KeepIntegrity = True
        Me.S_USE_YN.Location = New System.Drawing.Point(583, 8)
        Me.S_USE_YN.Name = "S_USE_YN"
        Me.S_USE_YN.NextFocus = "LOC_NM"
        Me.S_USE_YN.NullText = "--Select--"
        Me.S_USE_YN.SearchKeys = ""
        Me.S_USE_YN.Size = New System.Drawing.Size(74, 22)
        Me.S_USE_YN.TabIndex = 200
        Me.S_USE_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_USE_YN.ValueMember = "CODE"
        '
        'S_USR_ID
        '
        Me.S_USR_ID.BackColor = System.Drawing.SystemColors.Window
        Me.S_USR_ID.BorderColor = System.Drawing.Color.Silver
        Me.S_USR_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_USR_ID.DefVal = ""
        Me.S_USR_ID.IsDataStateAware = True
        Me.S_USR_ID.Location = New System.Drawing.Point(99, 7)
        Me.S_USR_ID.Name = "S_USR_ID"
        Me.S_USR_ID.NextFocus = "S_USR_NM"
        Me.S_USR_ID.Size = New System.Drawing.Size(99, 22)
        Me.S_USR_ID.TabIndex = 195
        Me.S_USR_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'LBL_S_USR_ID
        '
        Me.LBL_S_USR_ID.AutoEllipsis = True
        Me.LBL_S_USR_ID.BackColor = System.Drawing.Color.Transparent
        Me.LBL_S_USR_ID.LabelFor = Nothing
        Me.LBL_S_USR_ID.Location = New System.Drawing.Point(9, 7)
        Me.LBL_S_USR_ID.Name = "LBL_S_USR_ID"
        Me.LBL_S_USR_ID.Size = New System.Drawing.Size(84, 22)
        Me.LBL_S_USR_ID.TabIndex = 194
        Me.LBL_S_USR_ID.Text = "User Id"
        Me.LBL_S_USR_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_S_USR_ID, "User Id")
        '
        'S_USR_NM
        '
        Me.S_USR_NM.BackColor = System.Drawing.SystemColors.Window
        Me.S_USR_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_USR_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_USR_NM.DefVal = ""
        Me.S_USR_NM.IsDataStateAware = True
        Me.S_USR_NM.Location = New System.Drawing.Point(301, 7)
        Me.S_USR_NM.Name = "S_USR_NM"
        Me.S_USR_NM.NextFocus = "S_SALES_LVL"
        Me.S_USR_NM.Size = New System.Drawing.Size(200, 22)
        Me.S_USR_NM.TabIndex = 2
        Me.S_USR_NM.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'LBL_S_USR_NM
        '
        Me.LBL_S_USR_NM.AutoEllipsis = True
        Me.LBL_S_USR_NM.LabelFor = Nothing
        Me.LBL_S_USR_NM.Location = New System.Drawing.Point(216, 7)
        Me.LBL_S_USR_NM.Name = "LBL_S_USR_NM"
        Me.LBL_S_USR_NM.Size = New System.Drawing.Size(79, 22)
        Me.LBL_S_USR_NM.TabIndex = 151
        Me.LBL_S_USR_NM.Text = "User Name"
        Me.LBL_S_USR_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_S_USR_NM, "User Name")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'MdmUserMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1008, 640)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.WG1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "MdmUserMgt"
        Me.Text = "User Management"
        Me.Localizer1.SetWordID(Me, "User Management")
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnNew As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_LOC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DEPT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_USE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ENG_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents USE_YN As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents RMK As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents FAX_NO As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents PSWD As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents HP_NO As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents EMAIL As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents LOC_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents USR_ID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents PSWD1 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents TEL_NO As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents LBL_ENG_NM As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_SUB_USR_NM As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_USE_YN As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_SUB_USR_ID As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_PSWD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_PSWD1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_TEL_NO As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_FAX_NO As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_HP_NO As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_DEPT_CD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_EMAIL As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_RMK As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents S_USR_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents LBL_S_USR_NM As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_S_USR_ID As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_USR_ID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents DEPT_CD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents DEPT_NM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents GV1_PSWD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PSWD_CHG_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_USE_YN As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GV1_DEPT_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AUTH_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents LBL_AUTH_TYPE As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_USER_CNT_YN As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents RECVMSG_YN As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents lbl_RECVMSG_YN As YJIT.SC.UI.SCControls.Label
    Friend WithEvents RANK As SCControls.ComboBox
    Friend WithEvents lbl_USR_TITLE_CD As SCControls.Label
End Class
