<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdmCommonMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdmCommonMgt))
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.S_GRP_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.S_GRP_CD = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_S_GRP_NM = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_S_GRP_CD = New YJIT.SC.UI.SCControls.Label()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_GRP_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_GRP_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MNGT_AUTH_LVL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CD_LEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_NAME_TITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.btnAddWg3 = New YJIT.SC.UI.SCControls.Button()
        Me.btnExpWg3 = New YJIT.SC.UI.SCControls.Button()
        Me.btnDelWg3 = New YJIT.SC.UI.SCControls.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.btnAddWg2 = New YJIT.SC.UI.SCControls.Button()
        Me.btnExpWg2 = New YJIT.SC.UI.SCControls.Button()
        Me.btnDelWg2 = New YJIT.SC.UI.SCControls.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label39 = New YJIT.SC.UI.SCControls.Label()
        Me.btnAddWg1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnExpWg1 = New YJIT.SC.UI.SCControls.Button()
        Me.WG3 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV3_ITEM_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_REQ_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_LANG_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_LOC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV2_GRP_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_COMN_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CD_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OPT_ITEM1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OPT_ITEM2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OPT_ITEM3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OPT_ITEM4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OPT_ITEM5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OPT_ITEM6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OPT_ITEM7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OPT_ITEM8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OPT_ITEM9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OPT_ITEM10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_SORT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_ItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GV2_USE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2_ItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.LookAndFeel.SkinName = "Blue"
        Me.RepositoryItemTextEdit1.MaxLength = 10
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 100
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.MaxLength = 4
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.MaxLength = 200
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'S_GRP_NM
        '
        Me.S_GRP_NM.BackColor = System.Drawing.SystemColors.Window
        Me.S_GRP_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_GRP_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_GRP_NM.DefVal = ""
        Me.S_GRP_NM.IsDataStateAware = True
        Me.S_GRP_NM.Location = New System.Drawing.Point(267, 5)
        Me.S_GRP_NM.MaxLength = 50
        Me.S_GRP_NM.Name = "S_GRP_NM"
        Me.S_GRP_NM.NextFocus = "WG1"
        Me.S_GRP_NM.Size = New System.Drawing.Size(174, 22)
        Me.S_GRP_NM.TabIndex = 1
        Me.S_GRP_NM.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'S_GRP_CD
        '
        Me.S_GRP_CD.BorderColor = System.Drawing.Color.Silver
        Me.S_GRP_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_GRP_CD.DefVal = ""
        Me.S_GRP_CD.IsDataStateAware = True
        Me.S_GRP_CD.Location = New System.Drawing.Point(91, 5)
        Me.S_GRP_CD.MaxLength = 10
        Me.S_GRP_CD.Name = "S_GRP_CD"
        Me.S_GRP_CD.NextFocus = "S_GRP_NM"
        Me.S_GRP_CD.Size = New System.Drawing.Size(73, 22)
        Me.S_GRP_CD.TabIndex = 0
        Me.S_GRP_CD.TextCasing = YJIT.SC.UI.TextCasings.Upper
        '
        'lbl_S_GRP_NM
        '
        Me.lbl_S_GRP_NM.AutoEllipsis = True
        Me.lbl_S_GRP_NM.LabelFor = Nothing
        Me.lbl_S_GRP_NM.Location = New System.Drawing.Point(181, 5)
        Me.lbl_S_GRP_NM.Name = "lbl_S_GRP_NM"
        Me.lbl_S_GRP_NM.Size = New System.Drawing.Size(80, 22)
        Me.lbl_S_GRP_NM.TabIndex = 5
        Me.lbl_S_GRP_NM.Text = "Group Name"
        Me.lbl_S_GRP_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_GRP_NM, "Group Name")
        '
        'lbl_S_GRP_CD
        '
        Me.lbl_S_GRP_CD.AutoEllipsis = True
        Me.lbl_S_GRP_CD.LabelFor = Nothing
        Me.lbl_S_GRP_CD.Location = New System.Drawing.Point(5, 5)
        Me.lbl_S_GRP_CD.Name = "lbl_S_GRP_CD"
        Me.lbl_S_GRP_CD.Size = New System.Drawing.Size(80, 22)
        Me.lbl_S_GRP_CD.TabIndex = 4
        Me.lbl_S_GRP_CD.Text = "Group Code"
        Me.lbl_S_GRP_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_GRP_CD, "Group Code")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSearch.Appearance.Options.UseForeColor = True
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(843, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(919, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.EmbeddedNavigator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(6, 63)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit5})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(996, 241)
        Me.WG1.TabIndex = 2
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_GRP_CD, Me.GV1_GRP_NM, Me.GV1_MNGT_AUTH_LVL, Me.GV1_CD_LEN, Me.GV1_NAME_TITLE, Me.GV1_TITLE1, Me.GV1_TITLE2, Me.GV1_TITLE3, Me.GV1_TITLE4, Me.GV1_TITLE5, Me.GV1_TITLE6, Me.GV1_TITLE7, Me.GV1_TITLE8, Me.GV1_TITLE9, Me.GV1_TITLE10, Me.GV1_INS_USR, Me.GV1_INS_YMD, Me.GV1_UPD_USR, Me.GV1_UPD_YMD})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsCustomization.AllowColumnMoving = False
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.ViewCaption = " Group List"
        '
        'GV1_GRP_CD
        '
        Me.GV1_GRP_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_GRP_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_GRP_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_GRP_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_GRP_CD.Caption = "Group Code"
        Me.GV1_GRP_CD.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GV1_GRP_CD.FieldName = "GRP_CD"
        Me.GV1_GRP_CD.Name = "GV1_GRP_CD"
        Me.GV1_GRP_CD.OptionsColumn.AllowEdit = False
        Me.GV1_GRP_CD.OptionsColumn.ReadOnly = True
        Me.GV1_GRP_CD.Visible = True
        Me.GV1_GRP_CD.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GV1_GRP_CD, "Group Code")
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'GV1_GRP_NM
        '
        Me.GV1_GRP_NM.Caption = "Group Name"
        Me.GV1_GRP_NM.FieldName = "GRP_NM"
        Me.GV1_GRP_NM.Name = "GV1_GRP_NM"
        Me.GV1_GRP_NM.Visible = True
        Me.GV1_GRP_NM.VisibleIndex = 1
        Me.GV1_GRP_NM.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_GRP_NM, "Group Name")
        '
        'GV1_MNGT_AUTH_LVL
        '
        Me.GV1_MNGT_AUTH_LVL.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_MNGT_AUTH_LVL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_MNGT_AUTH_LVL.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MNGT_AUTH_LVL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_MNGT_AUTH_LVL.Caption = "Admin"
        Me.GV1_MNGT_AUTH_LVL.FieldName = "MNGT_AUTH_LVL"
        Me.GV1_MNGT_AUTH_LVL.Name = "GV1_MNGT_AUTH_LVL"
        Me.GV1_MNGT_AUTH_LVL.Visible = True
        Me.GV1_MNGT_AUTH_LVL.VisibleIndex = 2
        Me.GV1_MNGT_AUTH_LVL.Width = 70
        Me.Localizer1.SetWordID(Me.GV1_MNGT_AUTH_LVL, "Admin")
        '
        'GV1_CD_LEN
        '
        Me.GV1_CD_LEN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CD_LEN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_CD_LEN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CD_LEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_CD_LEN.Caption = "Length"
        Me.GV1_CD_LEN.FieldName = "CD_LEN"
        Me.GV1_CD_LEN.Name = "GV1_CD_LEN"
        Me.GV1_CD_LEN.Visible = True
        Me.GV1_CD_LEN.VisibleIndex = 3
        Me.GV1_CD_LEN.Width = 49
        Me.Localizer1.SetWordID(Me.GV1_CD_LEN, "Length")
        '
        'GV1_NAME_TITLE
        '
        Me.GV1_NAME_TITLE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_NAME_TITLE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_NAME_TITLE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_NAME_TITLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_NAME_TITLE.Caption = "Code Title"
        Me.GV1_NAME_TITLE.FieldName = "NAME_TITLE"
        Me.GV1_NAME_TITLE.Name = "GV1_NAME_TITLE"
        Me.GV1_NAME_TITLE.Visible = True
        Me.GV1_NAME_TITLE.VisibleIndex = 4
        Me.GV1_NAME_TITLE.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_NAME_TITLE, "Code Title")
        '
        'GV1_TITLE1
        '
        Me.GV1_TITLE1.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TITLE1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_TITLE1.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TITLE1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_TITLE1.Caption = "Title1"
        Me.GV1_TITLE1.FieldName = "TITLE1"
        Me.GV1_TITLE1.Name = "GV1_TITLE1"
        Me.GV1_TITLE1.Visible = True
        Me.GV1_TITLE1.VisibleIndex = 5
        Me.GV1_TITLE1.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_TITLE1, "Title1")
        '
        'GV1_TITLE2
        '
        Me.GV1_TITLE2.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TITLE2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_TITLE2.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TITLE2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_TITLE2.Caption = "Title2"
        Me.GV1_TITLE2.FieldName = "TITLE2"
        Me.GV1_TITLE2.Name = "GV1_TITLE2"
        Me.GV1_TITLE2.Visible = True
        Me.GV1_TITLE2.VisibleIndex = 6
        Me.GV1_TITLE2.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_TITLE2, "Title2")
        '
        'GV1_TITLE3
        '
        Me.GV1_TITLE3.Caption = "Title3"
        Me.GV1_TITLE3.FieldName = "TITLE3"
        Me.GV1_TITLE3.Name = "GV1_TITLE3"
        Me.GV1_TITLE3.Visible = True
        Me.GV1_TITLE3.VisibleIndex = 7
        Me.GV1_TITLE3.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_TITLE3, "Title3")
        '
        'GV1_TITLE4
        '
        Me.GV1_TITLE4.Caption = "Title4"
        Me.GV1_TITLE4.FieldName = "TITLE4"
        Me.GV1_TITLE4.Name = "GV1_TITLE4"
        Me.GV1_TITLE4.Visible = True
        Me.GV1_TITLE4.VisibleIndex = 8
        Me.GV1_TITLE4.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_TITLE4, "Title4")
        '
        'GV1_TITLE5
        '
        Me.GV1_TITLE5.Caption = "Title5"
        Me.GV1_TITLE5.FieldName = "TITLE5"
        Me.GV1_TITLE5.Name = "GV1_TITLE5"
        Me.GV1_TITLE5.Visible = True
        Me.GV1_TITLE5.VisibleIndex = 9
        Me.GV1_TITLE5.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_TITLE5, "Title5")
        '
        'GV1_TITLE6
        '
        Me.GV1_TITLE6.Caption = "Title6"
        Me.GV1_TITLE6.FieldName = "TITLE6"
        Me.GV1_TITLE6.Name = "GV1_TITLE6"
        Me.GV1_TITLE6.Visible = True
        Me.GV1_TITLE6.VisibleIndex = 10
        Me.GV1_TITLE6.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_TITLE6, "Title6")
        '
        'GV1_TITLE7
        '
        Me.GV1_TITLE7.Caption = "Title7"
        Me.GV1_TITLE7.FieldName = "TITLE7"
        Me.GV1_TITLE7.Name = "GV1_TITLE7"
        Me.GV1_TITLE7.Visible = True
        Me.GV1_TITLE7.VisibleIndex = 11
        Me.GV1_TITLE7.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_TITLE7, "Title7")
        '
        'GV1_TITLE8
        '
        Me.GV1_TITLE8.Caption = "Title8"
        Me.GV1_TITLE8.FieldName = "TITLE8"
        Me.GV1_TITLE8.Name = "GV1_TITLE8"
        Me.GV1_TITLE8.Visible = True
        Me.GV1_TITLE8.VisibleIndex = 12
        Me.GV1_TITLE8.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_TITLE8, "Title8")
        '
        'GV1_TITLE9
        '
        Me.GV1_TITLE9.Caption = "Title9"
        Me.GV1_TITLE9.FieldName = "TITLE9"
        Me.GV1_TITLE9.Name = "GV1_TITLE9"
        Me.GV1_TITLE9.Visible = True
        Me.GV1_TITLE9.VisibleIndex = 13
        Me.GV1_TITLE9.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_TITLE9, "Title9")
        '
        'GV1_TITLE10
        '
        Me.GV1_TITLE10.Caption = "Title10"
        Me.GV1_TITLE10.FieldName = "TITLE10"
        Me.GV1_TITLE10.Name = "GV1_TITLE10"
        Me.GV1_TITLE10.Visible = True
        Me.GV1_TITLE10.VisibleIndex = 14
        Me.GV1_TITLE10.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_TITLE10, "Title10")
        '
        'GV1_INS_USR
        '
        Me.GV1_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.Caption = "Creator"
        Me.GV1_INS_USR.FieldName = "INS_USR"
        Me.GV1_INS_USR.Name = "GV1_INS_USR"
        Me.GV1_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV1_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV1_INS_USR.Visible = True
        Me.GV1_INS_USR.VisibleIndex = 15
        Me.GV1_INS_USR.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "Creator")
        '
        'GV1_INS_YMD
        '
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_YMD.Caption = "Created Date"
        Me.GV1_INS_YMD.FieldName = "INS_YMD"
        Me.GV1_INS_YMD.Name = "GV1_INS_YMD"
        Me.GV1_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_INS_YMD.Visible = True
        Me.GV1_INS_YMD.VisibleIndex = 16
        Me.GV1_INS_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "Created Date")
        '
        'GV1_UPD_USR
        '
        Me.GV1_UPD_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPD_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_USR.Caption = "Modifier"
        Me.GV1_UPD_USR.FieldName = "UPD_USR"
        Me.GV1_UPD_USR.Name = "GV1_UPD_USR"
        Me.GV1_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_USR.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_USR.Visible = True
        Me.GV1_UPD_USR.VisibleIndex = 17
        Me.GV1_UPD_USR.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "Modifier")
        '
        'GV1_UPD_YMD
        '
        Me.GV1_UPD_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPD_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_YMD.Caption = "Modified Date"
        Me.GV1_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV1_UPD_YMD.Name = "GV1_UPD_YMD"
        Me.GV1_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_YMD.Visible = True
        Me.GV1_UPD_YMD.VisibleIndex = 18
        Me.GV1_UPD_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "Modified Date")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(996, 31)
        Me.palAutoButton.TabIndex = 1
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.S_GRP_CD)
        Me.PanelControl2.Controls.Add(Me.lbl_S_GRP_CD)
        Me.PanelControl2.Controls.Add(Me.S_GRP_NM)
        Me.PanelControl2.Controls.Add(Me.lbl_S_GRP_NM)
        Me.PanelControl2.Location = New System.Drawing.Point(6, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(996, 33)
        Me.PanelControl2.TabIndex = 0
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.WG3)
        Me.Panel1.Controls.Add(Me.WG2)
        Me.Panel1.Controls.Add(Me.PanelControl2)
        Me.Panel1.Controls.Add(Me.WG1)
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 596)
        Me.Panel1.TabIndex = 6
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAddWg3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExpWg3, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnDelWg3, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(644, 310)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(358, 26)
        Me.TableLayoutPanel2.TabIndex = 211
        Me.Localizer1.SetWordID(Me.TableLayoutPanel2, "")
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 26)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Local Language"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label2, "Local Language")
        '
        'btnAddWg3
        '
        Me.btnAddWg3.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddWg3.Appearance.Options.UseForeColor = True
        Me.btnAddWg3.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnAddWg3.Image = CType(resources.GetObject("btnAddWg3.Image"), System.Drawing.Image)
        Me.btnAddWg3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddWg3.Location = New System.Drawing.Point(241, 3)
        Me.btnAddWg3.Name = "btnAddWg3"
        Me.btnAddWg3.Size = New System.Drawing.Size(21, 20)
        Me.btnAddWg3.TabIndex = 213
        Me.btnAddWg3.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnAddWg3, "Button1")
        '
        'btnExpWg3
        '
        Me.btnExpWg3.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExpWg3.Image = CType(resources.GetObject("btnExpWg3.Image"), System.Drawing.Image)
        Me.btnExpWg3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExpWg3.Location = New System.Drawing.Point(301, 3)
        Me.btnExpWg3.Name = "btnExpWg3"
        Me.btnExpWg3.Size = New System.Drawing.Size(21, 20)
        Me.btnExpWg3.TabIndex = 212
        Me.btnExpWg3.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnExpWg3, "Button1")
        '
        'btnDelWg3
        '
        Me.btnDelWg3.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDelWg3.Image = CType(resources.GetObject("btnDelWg3.Image"), System.Drawing.Image)
        Me.btnDelWg3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelWg3.Location = New System.Drawing.Point(271, 3)
        Me.btnDelWg3.Name = "btnDelWg3"
        Me.btnDelWg3.Size = New System.Drawing.Size(21, 20)
        Me.btnDelWg3.TabIndex = 214
        Me.btnDelWg3.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnDelWg3, "Button1")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddWg2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExpWg2, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDelWg2, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 310)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(635, 26)
        Me.TableLayoutPanel1.TabIndex = 210
        Me.Localizer1.SetWordID(Me.TableLayoutPanel1, "")
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 26)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "Common Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label1, "Common Code")
        '
        'btnAddWg2
        '
        Me.btnAddWg2.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddWg2.Appearance.Options.UseForeColor = True
        Me.btnAddWg2.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnAddWg2.Image = CType(resources.GetObject("btnAddWg2.Image"), System.Drawing.Image)
        Me.btnAddWg2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddWg2.Location = New System.Drawing.Point(518, 3)
        Me.btnAddWg2.Name = "btnAddWg2"
        Me.btnAddWg2.Size = New System.Drawing.Size(21, 20)
        Me.btnAddWg2.TabIndex = 213
        Me.btnAddWg2.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnAddWg2, "Button1")
        '
        'btnExpWg2
        '
        Me.btnExpWg2.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExpWg2.Image = CType(resources.GetObject("btnExpWg2.Image"), System.Drawing.Image)
        Me.btnExpWg2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExpWg2.Location = New System.Drawing.Point(578, 3)
        Me.btnExpWg2.Name = "btnExpWg2"
        Me.btnExpWg2.Size = New System.Drawing.Size(21, 20)
        Me.btnExpWg2.TabIndex = 212
        Me.btnExpWg2.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnExpWg2, "Button1")
        '
        'btnDelWg2
        '
        Me.btnDelWg2.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDelWg2.Image = CType(resources.GetObject("btnDelWg2.Image"), System.Drawing.Image)
        Me.btnDelWg2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelWg2.Location = New System.Drawing.Point(548, 3)
        Me.btnDelWg2.Name = "btnDelWg2"
        Me.btnDelWg2.Size = New System.Drawing.Size(21, 20)
        Me.btnDelWg2.TabIndex = 214
        Me.btnDelWg2.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnDelWg2, "Button1")
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label39, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAddWg1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnExpWg1, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 36)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(996, 26)
        Me.TableLayoutPanel3.TabIndex = 209
        Me.Localizer1.SetWordID(Me.TableLayoutPanel3, "")
        '
        'Label39
        '
        Me.Label39.AutoEllipsis = True
        Me.Label39.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label39.LabelFor = Nothing
        Me.Label39.Location = New System.Drawing.Point(3, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(900, 26)
        Me.Label39.TabIndex = 215
        Me.Label39.Text = "Group List"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label39, "Group List")
        '
        'btnAddWg1
        '
        Me.btnAddWg1.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddWg1.Appearance.Options.UseForeColor = True
        Me.btnAddWg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnAddWg1.Image = CType(resources.GetObject("btnAddWg1.Image"), System.Drawing.Image)
        Me.btnAddWg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddWg1.Location = New System.Drawing.Point(909, 3)
        Me.btnAddWg1.Name = "btnAddWg1"
        Me.btnAddWg1.Size = New System.Drawing.Size(21, 20)
        Me.btnAddWg1.TabIndex = 213
        Me.btnAddWg1.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnAddWg1, "Button1")
        '
        'btnExpWg1
        '
        Me.btnExpWg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExpWg1.Image = CType(resources.GetObject("btnExpWg1.Image"), System.Drawing.Image)
        Me.btnExpWg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExpWg1.Location = New System.Drawing.Point(939, 3)
        Me.btnExpWg1.Name = "btnExpWg1"
        Me.btnExpWg1.Size = New System.Drawing.Size(21, 20)
        Me.btnExpWg1.TabIndex = 212
        Me.btnExpWg1.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnExpWg1, "Button1")
        '
        'WG3
        '
        Me.WG3.AllowClientBinding = True
        Me.WG3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG3.DeleteRowConfirmation = True
        Me.WG3.DisplayCurrentRow = False
        Me.WG3.EmbeddedNavigator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG3.IsDataStateAware = True
        Me.WG3.Location = New System.Drawing.Point(644, 339)
        Me.WG3.MainView = Me.GV3
        Me.WG3.Name = "WG3"
        Me.WG3.SaveLayout = False
        Me.WG3.Size = New System.Drawing.Size(358, 246)
        Me.WG3.TabIndex = 4
        Me.WG3.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV3.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV3_ITEM_CD, Me.GV3_REQ_CD, Me.GV3_LANG_CD, Me.GV3_LOC_NM})
        Me.GV3.GridControl = Me.WG3
        Me.GV3.IndicatorWidth = 40
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsCustomization.AllowColumnMoving = False
        Me.GV3.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV3.OptionsView.ColumnAutoWidth = False
        Me.GV3.OptionsView.ShowGroupPanel = False
        Me.GV3.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV3.ViewCaption = " Local Language"
        '
        'GV3_ITEM_CD
        '
        Me.GV3_ITEM_CD.Caption = "Group Code"
        Me.GV3_ITEM_CD.FieldName = "ITEM_CD"
        Me.GV3_ITEM_CD.Name = "GV3_ITEM_CD"
        Me.Localizer1.SetWordID(Me.GV3_ITEM_CD, "Group Code")
        '
        'GV3_REQ_CD
        '
        Me.GV3_REQ_CD.Caption = "Common Code"
        Me.GV3_REQ_CD.FieldName = "REQ_CD"
        Me.GV3_REQ_CD.Name = "GV3_REQ_CD"
        Me.Localizer1.SetWordID(Me.GV3_REQ_CD, "Common Code")
        '
        'GV3_LANG_CD
        '
        Me.GV3_LANG_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_LANG_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV3_LANG_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_LANG_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV3_LANG_CD.Caption = "Language"
        Me.GV3_LANG_CD.FieldName = "LANG_CD"
        Me.GV3_LANG_CD.Name = "GV3_LANG_CD"
        Me.GV3_LANG_CD.Visible = True
        Me.GV3_LANG_CD.VisibleIndex = 0
        Me.GV3_LANG_CD.Width = 100
        Me.Localizer1.SetWordID(Me.GV3_LANG_CD, "Language")
        '
        'GV3_LOC_NM
        '
        Me.GV3_LOC_NM.Caption = "Local Name"
        Me.GV3_LOC_NM.FieldName = "LOC_NM"
        Me.GV3_LOC_NM.Name = "GV3_LOC_NM"
        Me.GV3_LOC_NM.Visible = True
        Me.GV3_LOC_NM.VisibleIndex = 1
        Me.GV3_LOC_NM.Width = 210
        Me.Localizer1.SetWordID(Me.GV3_LOC_NM, "Local Name")
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG2.DeleteRowConfirmation = True
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.EmbeddedNavigator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(6, 339)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GV2_ItemMemoExEdit1})
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(632, 246)
        Me.WG2.TabIndex = 3
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV2_GRP_CD, Me.GV2_COMN_CD, Me.GV2_CD_NM, Me.GV2_OPT_ITEM1, Me.GV2_OPT_ITEM2, Me.GV2_OPT_ITEM3, Me.GV2_OPT_ITEM4, Me.GV2_OPT_ITEM5, Me.GV2_OPT_ITEM6, Me.GV2_OPT_ITEM7, Me.GV2_OPT_ITEM8, Me.GV2_OPT_ITEM9, Me.GV2_OPT_ITEM10, Me.GV2_SORT, Me.GV2_RMK, Me.GV2_USE_YN, Me.GV2_INS_USR, Me.GV2_INS_YMD, Me.GV2_UPD_USR, Me.GV2_UPD_YMD})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.IndicatorWidth = 40
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsCustomization.AllowColumnMoving = False
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV2.ViewCaption = " Common Code"
        '
        'GV2_GRP_CD
        '
        Me.GV2_GRP_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_GRP_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_GRP_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_GRP_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_GRP_CD.Caption = "Group Code"
        Me.GV2_GRP_CD.FieldName = "GRP_CD"
        Me.GV2_GRP_CD.Name = "GV2_GRP_CD"
        Me.GV2_GRP_CD.OptionsColumn.AllowEdit = False
        Me.GV2_GRP_CD.OptionsColumn.ReadOnly = True
        Me.GV2_GRP_CD.Visible = True
        Me.GV2_GRP_CD.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GV2_GRP_CD, "Group Code")
        '
        'GV2_COMN_CD
        '
        Me.GV2_COMN_CD.Caption = "Code"
        Me.GV2_COMN_CD.FieldName = "COMN_CD"
        Me.GV2_COMN_CD.Name = "GV2_COMN_CD"
        Me.GV2_COMN_CD.OptionsColumn.AllowEdit = False
        Me.GV2_COMN_CD.OptionsColumn.ReadOnly = True
        Me.GV2_COMN_CD.Visible = True
        Me.GV2_COMN_CD.VisibleIndex = 1
        Me.GV2_COMN_CD.Width = 72
        Me.Localizer1.SetWordID(Me.GV2_COMN_CD, "Code")
        '
        'GV2_CD_NM
        '
        Me.GV2_CD_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_CD_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_CD_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CD_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_CD_NM.Caption = "Code Title"
        Me.GV2_CD_NM.FieldName = "CD_NM"
        Me.GV2_CD_NM.Name = "GV2_CD_NM"
        Me.GV2_CD_NM.Visible = True
        Me.GV2_CD_NM.VisibleIndex = 2
        Me.GV2_CD_NM.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_CD_NM, "Code Title")
        '
        'GV2_OPT_ITEM1
        '
        Me.GV2_OPT_ITEM1.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_OPT_ITEM1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_OPT_ITEM1.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_OPT_ITEM1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_OPT_ITEM1.Caption = "Title1"
        Me.GV2_OPT_ITEM1.FieldName = "OPT_ITEM1"
        Me.GV2_OPT_ITEM1.Name = "GV2_OPT_ITEM1"
        Me.GV2_OPT_ITEM1.Visible = True
        Me.GV2_OPT_ITEM1.VisibleIndex = 3
        Me.GV2_OPT_ITEM1.Width = 90
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM1, "Title1")
        '
        'GV2_OPT_ITEM2
        '
        Me.GV2_OPT_ITEM2.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_OPT_ITEM2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_OPT_ITEM2.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_OPT_ITEM2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_OPT_ITEM2.Caption = "Title2"
        Me.GV2_OPT_ITEM2.FieldName = "OPT_ITEM2"
        Me.GV2_OPT_ITEM2.Name = "GV2_OPT_ITEM2"
        Me.GV2_OPT_ITEM2.Visible = True
        Me.GV2_OPT_ITEM2.VisibleIndex = 4
        Me.GV2_OPT_ITEM2.Width = 90
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM2, "Title2")
        '
        'GV2_OPT_ITEM3
        '
        Me.GV2_OPT_ITEM3.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_OPT_ITEM3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_OPT_ITEM3.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_OPT_ITEM3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_OPT_ITEM3.Caption = "Title3"
        Me.GV2_OPT_ITEM3.FieldName = "OPT_ITEM3"
        Me.GV2_OPT_ITEM3.Name = "GV2_OPT_ITEM3"
        Me.GV2_OPT_ITEM3.Visible = True
        Me.GV2_OPT_ITEM3.VisibleIndex = 5
        Me.GV2_OPT_ITEM3.Width = 90
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM3, "Title3")
        '
        'GV2_OPT_ITEM4
        '
        Me.GV2_OPT_ITEM4.Caption = "Title4"
        Me.GV2_OPT_ITEM4.FieldName = "OPT_ITEM4"
        Me.GV2_OPT_ITEM4.Name = "GV2_OPT_ITEM4"
        Me.GV2_OPT_ITEM4.Visible = True
        Me.GV2_OPT_ITEM4.VisibleIndex = 6
        Me.GV2_OPT_ITEM4.Width = 90
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM4, "Title4")
        '
        'GV2_OPT_ITEM5
        '
        Me.GV2_OPT_ITEM5.Caption = "Title5"
        Me.GV2_OPT_ITEM5.FieldName = "OPT_ITEM5"
        Me.GV2_OPT_ITEM5.Name = "GV2_OPT_ITEM5"
        Me.GV2_OPT_ITEM5.Visible = True
        Me.GV2_OPT_ITEM5.VisibleIndex = 7
        Me.GV2_OPT_ITEM5.Width = 90
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM5, "Title5")
        '
        'GV2_OPT_ITEM6
        '
        Me.GV2_OPT_ITEM6.Caption = "Title6"
        Me.GV2_OPT_ITEM6.FieldName = "OPT_ITEM6"
        Me.GV2_OPT_ITEM6.Name = "GV2_OPT_ITEM6"
        Me.GV2_OPT_ITEM6.Visible = True
        Me.GV2_OPT_ITEM6.VisibleIndex = 8
        Me.GV2_OPT_ITEM6.Width = 90
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM6, "Title6")
        '
        'GV2_OPT_ITEM7
        '
        Me.GV2_OPT_ITEM7.Caption = "Title7"
        Me.GV2_OPT_ITEM7.FieldName = "OPT_ITEM7"
        Me.GV2_OPT_ITEM7.Name = "GV2_OPT_ITEM7"
        Me.GV2_OPT_ITEM7.Visible = True
        Me.GV2_OPT_ITEM7.VisibleIndex = 9
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM7, "Title7")
        '
        'GV2_OPT_ITEM8
        '
        Me.GV2_OPT_ITEM8.Caption = "Title8"
        Me.GV2_OPT_ITEM8.FieldName = "OPT_ITEM8"
        Me.GV2_OPT_ITEM8.Name = "GV2_OPT_ITEM8"
        Me.GV2_OPT_ITEM8.Visible = True
        Me.GV2_OPT_ITEM8.VisibleIndex = 10
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM8, "Title8")
        '
        'GV2_OPT_ITEM9
        '
        Me.GV2_OPT_ITEM9.Caption = "Title9"
        Me.GV2_OPT_ITEM9.FieldName = "OPT_ITEM9"
        Me.GV2_OPT_ITEM9.Name = "GV2_OPT_ITEM9"
        Me.GV2_OPT_ITEM9.Visible = True
        Me.GV2_OPT_ITEM9.VisibleIndex = 11
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM9, "Title9")
        '
        'GV2_OPT_ITEM10
        '
        Me.GV2_OPT_ITEM10.Caption = "Title10"
        Me.GV2_OPT_ITEM10.FieldName = "OPT_ITEM10"
        Me.GV2_OPT_ITEM10.Name = "GV2_OPT_ITEM10"
        Me.GV2_OPT_ITEM10.Visible = True
        Me.GV2_OPT_ITEM10.VisibleIndex = 12
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM10, "Title10")
        '
        'GV2_SORT
        '
        Me.GV2_SORT.Caption = "Sort"
        Me.GV2_SORT.FieldName = "SORT"
        Me.GV2_SORT.Name = "GV2_SORT"
        Me.GV2_SORT.Visible = True
        Me.GV2_SORT.VisibleIndex = 13
        Me.GV2_SORT.Width = 50
        Me.Localizer1.SetWordID(Me.GV2_SORT, "Sort")
        '
        'GV2_RMK
        '
        Me.GV2_RMK.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_RMK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_RMK.Caption = "Remark"
        Me.GV2_RMK.ColumnEdit = Me.GV2_ItemMemoExEdit1
        Me.GV2_RMK.FieldName = "RMK"
        Me.GV2_RMK.Name = "GV2_RMK"
        Me.GV2_RMK.Visible = True
        Me.GV2_RMK.VisibleIndex = 14
        Me.GV2_RMK.Width = 200
        Me.Localizer1.SetWordID(Me.GV2_RMK, "Remark")
        '
        'GV2_ItemMemoExEdit1
        '
        Me.GV2_ItemMemoExEdit1.AutoHeight = False
        Me.GV2_ItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GV2_ItemMemoExEdit1.Name = "GV2_ItemMemoExEdit1"
        Me.GV2_ItemMemoExEdit1.PopupFormSize = New System.Drawing.Size(600, 0)
        '
        'GV2_USE_YN
        '
        Me.GV2_USE_YN.Caption = "Use(Y/N)"
        Me.GV2_USE_YN.FieldName = "USE_YN"
        Me.GV2_USE_YN.Name = "GV2_USE_YN"
        Me.GV2_USE_YN.Visible = True
        Me.GV2_USE_YN.VisibleIndex = 15
        Me.Localizer1.SetWordID(Me.GV2_USE_YN, "Use(Y/N)")
        '
        'GV2_INS_USR
        '
        Me.GV2_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INS_USR.Caption = "Creator"
        Me.GV2_INS_USR.FieldName = "INS_USR"
        Me.GV2_INS_USR.Name = "GV2_INS_USR"
        Me.GV2_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV2_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV2_INS_USR.Visible = True
        Me.GV2_INS_USR.VisibleIndex = 16
        Me.GV2_INS_USR.Width = 60
        Me.Localizer1.SetWordID(Me.GV2_INS_USR, "Creator")
        '
        'GV2_INS_YMD
        '
        Me.GV2_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INS_YMD.Caption = "Created Date"
        Me.GV2_INS_YMD.FieldName = "INS_YMD"
        Me.GV2_INS_YMD.Name = "GV2_INS_YMD"
        Me.GV2_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV2_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV2_INS_YMD.Visible = True
        Me.GV2_INS_YMD.VisibleIndex = 17
        Me.GV2_INS_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV2_INS_YMD, "Created Date")
        '
        'GV2_UPD_USR
        '
        Me.GV2_UPD_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_UPD_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_UPD_USR.Caption = "Modifier"
        Me.GV2_UPD_USR.FieldName = "UPD_USR"
        Me.GV2_UPD_USR.Name = "GV2_UPD_USR"
        Me.GV2_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV2_UPD_USR.OptionsColumn.ReadOnly = True
        Me.GV2_UPD_USR.Visible = True
        Me.GV2_UPD_USR.VisibleIndex = 18
        Me.GV2_UPD_USR.Width = 60
        Me.Localizer1.SetWordID(Me.GV2_UPD_USR, "Modifier")
        '
        'GV2_UPD_YMD
        '
        Me.GV2_UPD_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_UPD_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_UPD_YMD.Caption = "Modified Date"
        Me.GV2_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV2_UPD_YMD.Name = "GV2_UPD_YMD"
        Me.GV2_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV2_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.GV2_UPD_YMD.Visible = True
        Me.GV2_UPD_YMD.VisibleIndex = 19
        Me.GV2_UPD_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV2_UPD_YMD, "Modified Date")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.S_GRP_NM, "")
        Me.Localizer1.SetWordID(Me.S_GRP_CD, "")
        Me.Localizer1.SetWordID(Me.lbl_S_GRP_NM, "Group Name")
        Me.Localizer1.SetWordID(Me.lbl_S_GRP_CD, "Group Code")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_GRP_CD, "Group Code")
        Me.Localizer1.SetWordID(Me.GV1_GRP_NM, "Group Name")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_AUTH_LVL, "Admin")
        Me.Localizer1.SetWordID(Me.GV1_CD_LEN, "Length")
        Me.Localizer1.SetWordID(Me.GV1_NAME_TITLE, "Code Title")
        Me.Localizer1.SetWordID(Me.GV1_TITLE1, "Title1")
        Me.Localizer1.SetWordID(Me.GV1_TITLE2, "Title2")
        Me.Localizer1.SetWordID(Me.GV1_TITLE3, "Title3")
        Me.Localizer1.SetWordID(Me.GV1_TITLE4, "Title4")
        Me.Localizer1.SetWordID(Me.GV1_TITLE5, "Title5")
        Me.Localizer1.SetWordID(Me.GV1_TITLE6, "Title6")
        Me.Localizer1.SetWordID(Me.GV1_TITLE7, "Title7")
        Me.Localizer1.SetWordID(Me.GV1_TITLE8, "Title8")
        Me.Localizer1.SetWordID(Me.GV1_TITLE9, "Title9")
        Me.Localizer1.SetWordID(Me.GV1_TITLE10, "Title10")
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "Creator")
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "Created Date")
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "Modifier")
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "Modified Date")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel2, "")
        Me.Localizer1.SetWordID(Me.Label2, "Local Language")
        Me.Localizer1.SetWordID(Me.btnAddWg3, "Button1")
        Me.Localizer1.SetWordID(Me.btnExpWg3, "Button1")
        Me.Localizer1.SetWordID(Me.btnDelWg3, "Button1")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel1, "")
        Me.Localizer1.SetWordID(Me.Label1, "Common Code")
        Me.Localizer1.SetWordID(Me.btnAddWg2, "Button1")
        Me.Localizer1.SetWordID(Me.btnExpWg2, "Button1")
        Me.Localizer1.SetWordID(Me.btnDelWg2, "Button1")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel3, "")
        Me.Localizer1.SetWordID(Me.Label39, "Group List")
        Me.Localizer1.SetWordID(Me.btnAddWg1, "Button1")
        Me.Localizer1.SetWordID(Me.btnExpWg1, "Button1")
        Me.Localizer1.SetWordID(Me.WG3, "")
        Me.Localizer1.SetWordID(Me.GV3_ITEM_CD, "Group Code")
        Me.Localizer1.SetWordID(Me.GV3_REQ_CD, "Common Code")
        Me.Localizer1.SetWordID(Me.GV3_LANG_CD, "Language")
        Me.Localizer1.SetWordID(Me.GV3_LOC_NM, "Local Name")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GV2_GRP_CD, "Group Code")
        Me.Localizer1.SetWordID(Me.GV2_COMN_CD, "Code")
        Me.Localizer1.SetWordID(Me.GV2_CD_NM, "Code Title")
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM1, "Title1")
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM2, "Title2")
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM3, "Title3")
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM4, "Title4")
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM5, "Title5")
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM6, "Title6")
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM7, "Title7")
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM8, "Title8")
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM9, "Title9")
        Me.Localizer1.SetWordID(Me.GV2_OPT_ITEM10, "Title10")
        Me.Localizer1.SetWordID(Me.GV2_SORT, "Sort")
        Me.Localizer1.SetWordID(Me.GV2_RMK, "Remark")
        Me.Localizer1.SetWordID(Me.GV2_USE_YN, "Use(Y/N)")
        Me.Localizer1.SetWordID(Me.GV2_INS_USR, "Creator")
        Me.Localizer1.SetWordID(Me.GV2_INS_YMD, "Created Date")
        Me.Localizer1.SetWordID(Me.GV2_UPD_USR, "Modifier")
        Me.Localizer1.SetWordID(Me.GV2_UPD_YMD, "Modified Date")
        '
        'MdmCommonMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1008, 640)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "MdmCommonMgt"
        Me.Text = "Common Code Management"
        Me.Localizer1.SetWordID(Me, "Common Code Management")
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2_ItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents lbl_S_GRP_CD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_GRP_CD As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents S_GRP_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents lbl_S_GRP_NM As YJIT.SC.UI.SCControls.Label
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_GRP_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_GRP_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MNGT_AUTH_LVL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CD_LEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_NAME_TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents WG3 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV3_LANG_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_LOC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV2_GRP_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_COMN_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_CD_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OPT_ITEM1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OPT_ITEM2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OPT_ITEM3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OPT_ITEM4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OPT_ITEM5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OPT_ITEM6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_ITEM_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_REQ_CD As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents GV2_SORT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_ItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OPT_ITEM7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OPT_ITEM8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OPT_ITEM9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OPT_ITEM10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_USE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAddWg1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnExpWg1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents Label39 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnAddWg3 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnExpWg3 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnDelWg3 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnAddWg2 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnExpWg2 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnDelWg2 As YJIT.SC.UI.SCControls.Button
End Class
