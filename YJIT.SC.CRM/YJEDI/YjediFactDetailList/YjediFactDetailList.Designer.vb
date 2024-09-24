<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YjediFactDetailList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YjediFactDetailList))
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_EDI_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_ORG_DATA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SEG_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_GRP_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UNH_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_LOC_DTM_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGV1LocNum2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.FGV1Vat2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.Label54 = New YJIT.SC.UI.SCControls.Label()
        Me.Label101 = New YJIT.SC.UI.SCControls.Label()
        Me.Label8 = New YJIT.SC.UI.SCControls.Label()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.ORGN_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.DEST_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.TRIG_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.EDI_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.LBL_EDI_ID = New YJIT.SC.UI.SCControls.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FGV1LocNum2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FGV1Vat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.LookAndFeel.SkinName = "Blue"
        Me.RepositoryItemTextEdit1.MaxLength = 5
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
        Me.RepositoryItemTextEdit3.MaxLength = 9
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.MaxLength = 200
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(886, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 27)
        Me.btnSearch.TabIndex = 100
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(3, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1057, 35)
        Me.palAutoButton.TabIndex = 1
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(972, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 27)
        Me.btnNew.TabIndex = 101
        Me.btnNew.Text = "&New"
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.WG1)
        Me.Panel1.Location = New System.Drawing.Point(0, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1525, 661)
        Me.Panel1.TabIndex = 6
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = False
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(3, 0)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.FGV1LocNum2, Me.FGV1Vat2})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(1522, 658)
        Me.WG1.TabIndex = 178
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GridView14})
        '
        'GV1
        '
        Me.GV1.Appearance.FooterPanel.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1.Appearance.FooterPanel.Options.UseFont = True
        Me.GV1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV1.Appearance.ViewCaption.Options.UseForeColor = True
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_EDI_ID, Me.GV1_SEQ, Me.GV1_ORG_DATA, Me.GV1_SEG_ID, Me.GV1_GRP_CD, Me.GV1_UNH_SEQ, Me.GV1_LOC_DTM_SEQ, Me.GV1_COL1, Me.GV1_COL2, Me.GV1_COL3, Me.GV1_COL4, Me.GV1_COL5, Me.GV1_COL6, Me.GV1_COL7, Me.GV1_COL8, Me.GV1_COL9, Me.GV1_COL10, Me.GV1_COL11, Me.GV1_COL12, Me.GV1_COL13, Me.GV1_COL14, Me.GV1_COL15, Me.GV1_COL16, Me.GV1_COL17, Me.GV1_COL18, Me.GV1_COL19, Me.GV1_COL20, Me.GV1_COL21, Me.GV1_COL22, Me.GV1_COL23, Me.GV1_COL24, Me.GV1_COL25, Me.GV1_COL26, Me.GV1_COL27, Me.GV1_COL28, Me.GV1_COL29, Me.GV1_COL30})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp
        Me.GV1.OptionsCustomization.AllowColumnMoving = False
        Me.GV1.OptionsCustomization.AllowSort = False
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.ViewCaption = " Selling(Debit)"
        '
        'GV1_EDI_ID
        '
        Me.GV1_EDI_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_EDI_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_EDI_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_EDI_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EDI_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_EDI_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_EDI_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_EDI_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EDI_ID.Caption = "전송번호"
        Me.GV1_EDI_ID.FieldName = "EDI_ID"
        Me.GV1_EDI_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_EDI_ID.Name = "GV1_EDI_ID"
        Me.GV1_EDI_ID.OptionsColumn.AllowEdit = False
        Me.GV1_EDI_ID.OptionsColumn.ReadOnly = True
        Me.GV1_EDI_ID.Visible = True
        Me.GV1_EDI_ID.VisibleIndex = 0
        Me.GV1_EDI_ID.Width = 170
        Me.Localizer1.SetWordID(Me.GV1_EDI_ID, "전송번호")
        '
        'GV1_SEQ
        '
        Me.GV1_SEQ.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_SEQ.AppearanceCell.Options.UseFont = True
        Me.GV1_SEQ.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SEQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_SEQ.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_SEQ.AppearanceHeader.Options.UseFont = True
        Me.GV1_SEQ.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEQ.Caption = "순번"
        Me.GV1_SEQ.FieldName = "SEQ"
        Me.GV1_SEQ.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_SEQ.Name = "GV1_SEQ"
        Me.GV1_SEQ.OptionsColumn.AllowEdit = False
        Me.GV1_SEQ.OptionsColumn.ReadOnly = True
        Me.GV1_SEQ.Visible = True
        Me.GV1_SEQ.VisibleIndex = 1
        Me.GV1_SEQ.Width = 40
        Me.Localizer1.SetWordID(Me.GV1_SEQ, "순번")
        '
        'GV1_ORG_DATA
        '
        Me.GV1_ORG_DATA.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_ORG_DATA.AppearanceCell.Options.UseFont = True
        Me.GV1_ORG_DATA.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_ORG_DATA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_ORG_DATA.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_ORG_DATA.AppearanceHeader.Options.UseFont = True
        Me.GV1_ORG_DATA.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_ORG_DATA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_ORG_DATA.Caption = "원본자료"
        Me.GV1_ORG_DATA.FieldName = "ORG_DATA"
        Me.GV1_ORG_DATA.Name = "GV1_ORG_DATA"
        Me.GV1_ORG_DATA.OptionsColumn.AllowEdit = False
        Me.GV1_ORG_DATA.OptionsColumn.ReadOnly = True
        Me.GV1_ORG_DATA.Visible = True
        Me.GV1_ORG_DATA.VisibleIndex = 2
        Me.GV1_ORG_DATA.Width = 110
        Me.Localizer1.SetWordID(Me.GV1_ORG_DATA, "원본자료")
        '
        'GV1_SEG_ID
        '
        Me.GV1_SEG_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_SEG_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_SEG_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SEG_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_SEG_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_SEG_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_SEG_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SEG_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEG_ID.Caption = "Segment ID"
        Me.GV1_SEG_ID.FieldName = "SEG_ID"
        Me.GV1_SEG_ID.Name = "GV1_SEG_ID"
        Me.GV1_SEG_ID.OptionsColumn.AllowEdit = False
        Me.GV1_SEG_ID.OptionsColumn.ReadOnly = True
        Me.GV1_SEG_ID.Visible = True
        Me.GV1_SEG_ID.VisibleIndex = 3
        Me.GV1_SEG_ID.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_SEG_ID, "Segment ID")
        '
        'GV1_GRP_CD
        '
        Me.GV1_GRP_CD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_GRP_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_GRP_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_GRP_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_GRP_CD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_GRP_CD.AppearanceHeader.Options.UseFont = True
        Me.GV1_GRP_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_GRP_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_GRP_CD.Caption = "그룹코드"
        Me.GV1_GRP_CD.FieldName = "GRP_CD"
        Me.GV1_GRP_CD.Name = "GV1_GRP_CD"
        Me.GV1_GRP_CD.OptionsColumn.AllowEdit = False
        Me.GV1_GRP_CD.OptionsColumn.ReadOnly = True
        Me.GV1_GRP_CD.Visible = True
        Me.GV1_GRP_CD.VisibleIndex = 4
        Me.GV1_GRP_CD.Width = 70
        Me.Localizer1.SetWordID(Me.GV1_GRP_CD, "그룹코드")
        '
        'GV1_UNH_SEQ
        '
        Me.GV1_UNH_SEQ.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_UNH_SEQ.AppearanceCell.Options.UseFont = True
        Me.GV1_UNH_SEQ.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_UNH_SEQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_UNH_SEQ.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_UNH_SEQ.AppearanceHeader.Options.UseFont = True
        Me.GV1_UNH_SEQ.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UNH_SEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UNH_SEQ.Caption = "UNH 순번"
        Me.GV1_UNH_SEQ.FieldName = "UNH_SEQ"
        Me.GV1_UNH_SEQ.Name = "GV1_UNH_SEQ"
        Me.GV1_UNH_SEQ.OptionsColumn.AllowEdit = False
        Me.GV1_UNH_SEQ.OptionsColumn.ReadOnly = True
        Me.GV1_UNH_SEQ.Visible = True
        Me.GV1_UNH_SEQ.VisibleIndex = 5
        Me.GV1_UNH_SEQ.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_UNH_SEQ, "UNH 순번")
        '
        'GV1_LOC_DTM_SEQ
        '
        Me.GV1_LOC_DTM_SEQ.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_LOC_DTM_SEQ.AppearanceCell.Options.UseFont = True
        Me.GV1_LOC_DTM_SEQ.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_LOC_DTM_SEQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_LOC_DTM_SEQ.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_LOC_DTM_SEQ.AppearanceHeader.Options.UseFont = True
        Me.GV1_LOC_DTM_SEQ.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_LOC_DTM_SEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_LOC_DTM_SEQ.Caption = "DTM 순번"
        Me.GV1_LOC_DTM_SEQ.FieldName = "LOC_DTM_SEQ"
        Me.GV1_LOC_DTM_SEQ.Name = "GV1_LOC_DTM_SEQ"
        Me.GV1_LOC_DTM_SEQ.OptionsColumn.AllowEdit = False
        Me.GV1_LOC_DTM_SEQ.OptionsColumn.ReadOnly = True
        Me.GV1_LOC_DTM_SEQ.Visible = True
        Me.GV1_LOC_DTM_SEQ.VisibleIndex = 6
        Me.GV1_LOC_DTM_SEQ.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_LOC_DTM_SEQ, "DTM 순번")
        '
        'GV1_COL1
        '
        Me.GV1_COL1.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL1.AppearanceCell.Options.UseFont = True
        Me.GV1_COL1.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL1.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL1.AppearanceHeader.Options.UseFont = True
        Me.GV1_COL1.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL1.Caption = "칼럼1"
        Me.GV1_COL1.FieldName = "COL1"
        Me.GV1_COL1.Name = "GV1_COL1"
        Me.GV1_COL1.OptionsColumn.AllowEdit = False
        Me.GV1_COL1.OptionsColumn.ReadOnly = True
        Me.GV1_COL1.Visible = True
        Me.GV1_COL1.VisibleIndex = 7
        Me.GV1_COL1.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL1, "칼럼1")
        '
        'GV1_COL2
        '
        Me.GV1_COL2.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL2.AppearanceCell.Options.UseFont = True
        Me.GV1_COL2.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL2.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL2.AppearanceHeader.Options.UseFont = True
        Me.GV1_COL2.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL2.Caption = "칼럼2"
        Me.GV1_COL2.FieldName = "COL2"
        Me.GV1_COL2.Name = "GV1_COL2"
        Me.GV1_COL2.OptionsColumn.AllowEdit = False
        Me.GV1_COL2.OptionsColumn.ReadOnly = True
        Me.GV1_COL2.Visible = True
        Me.GV1_COL2.VisibleIndex = 8
        Me.GV1_COL2.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL2, "칼럼2")
        '
        'GV1_COL3
        '
        Me.GV1_COL3.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL3.AppearanceCell.Options.UseFont = True
        Me.GV1_COL3.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL3.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL3.AppearanceHeader.Options.UseFont = True
        Me.GV1_COL3.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL3.Caption = "칼럼3"
        Me.GV1_COL3.FieldName = "COL3"
        Me.GV1_COL3.Name = "GV1_COL3"
        Me.GV1_COL3.OptionsColumn.AllowEdit = False
        Me.GV1_COL3.OptionsColumn.ReadOnly = True
        Me.GV1_COL3.Visible = True
        Me.GV1_COL3.VisibleIndex = 9
        Me.GV1_COL3.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL3, "칼럼3")
        '
        'GV1_COL4
        '
        Me.GV1_COL4.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL4.AppearanceCell.Options.UseFont = True
        Me.GV1_COL4.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL4.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL4.AppearanceHeader.Options.UseFont = True
        Me.GV1_COL4.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL4.Caption = "칼럼4"
        Me.GV1_COL4.FieldName = "COL4"
        Me.GV1_COL4.Name = "GV1_COL4"
        Me.GV1_COL4.OptionsColumn.AllowEdit = False
        Me.GV1_COL4.OptionsColumn.ReadOnly = True
        Me.GV1_COL4.Visible = True
        Me.GV1_COL4.VisibleIndex = 10
        Me.GV1_COL4.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL4, "칼럼4")
        '
        'GV1_COL5
        '
        Me.GV1_COL5.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL5.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL5.Caption = "칼럼5"
        Me.GV1_COL5.FieldName = "COL5"
        Me.GV1_COL5.Name = "GV1_COL5"
        Me.GV1_COL5.OptionsColumn.AllowEdit = False
        Me.GV1_COL5.OptionsColumn.ReadOnly = True
        Me.GV1_COL5.Visible = True
        Me.GV1_COL5.VisibleIndex = 11
        Me.GV1_COL5.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL5, "칼럼5")
        '
        'GV1_COL6
        '
        Me.GV1_COL6.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL6.AppearanceCell.Options.UseFont = True
        Me.GV1_COL6.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL6.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL6.AppearanceHeader.Options.UseFont = True
        Me.GV1_COL6.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL6.Caption = "칼럼6"
        Me.GV1_COL6.FieldName = "COL6"
        Me.GV1_COL6.Name = "GV1_COL6"
        Me.GV1_COL6.OptionsColumn.AllowEdit = False
        Me.GV1_COL6.OptionsColumn.ReadOnly = True
        Me.GV1_COL6.Visible = True
        Me.GV1_COL6.VisibleIndex = 12
        Me.GV1_COL6.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL6, "칼럼6")
        '
        'GV1_COL7
        '
        Me.GV1_COL7.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL7.AppearanceCell.Options.UseFont = True
        Me.GV1_COL7.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL7.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL7.AppearanceHeader.Options.UseFont = True
        Me.GV1_COL7.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL7.Caption = "칼럼7"
        Me.GV1_COL7.FieldName = "COL7"
        Me.GV1_COL7.Name = "GV1_COL7"
        Me.GV1_COL7.OptionsColumn.AllowEdit = False
        Me.GV1_COL7.OptionsColumn.ReadOnly = True
        Me.GV1_COL7.Visible = True
        Me.GV1_COL7.VisibleIndex = 13
        Me.GV1_COL7.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL7, "칼럼7")
        '
        'GV1_COL8
        '
        Me.GV1_COL8.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL8.AppearanceCell.Options.UseFont = True
        Me.GV1_COL8.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL8.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL8.AppearanceHeader.Options.UseFont = True
        Me.GV1_COL8.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL8.Caption = "칼럼8"
        Me.GV1_COL8.FieldName = "COL8"
        Me.GV1_COL8.Name = "GV1_COL8"
        Me.GV1_COL8.OptionsColumn.AllowEdit = False
        Me.GV1_COL8.OptionsColumn.ReadOnly = True
        Me.GV1_COL8.Visible = True
        Me.GV1_COL8.VisibleIndex = 14
        Me.GV1_COL8.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL8, "칼럼8")
        '
        'GV1_COL9
        '
        Me.GV1_COL9.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL9.AppearanceCell.Options.UseFont = True
        Me.GV1_COL9.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL9.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_COL9.AppearanceHeader.Options.UseFont = True
        Me.GV1_COL9.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL9.Caption = "칼럼9"
        Me.GV1_COL9.FieldName = "COL9"
        Me.GV1_COL9.Name = "GV1_COL9"
        Me.GV1_COL9.OptionsColumn.AllowEdit = False
        Me.GV1_COL9.OptionsColumn.ReadOnly = True
        Me.GV1_COL9.Visible = True
        Me.GV1_COL9.VisibleIndex = 15
        Me.GV1_COL9.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL9, "칼럼9")
        '
        'GV1_COL10
        '
        Me.GV1_COL10.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL10.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL10.Caption = "칼럼10"
        Me.GV1_COL10.FieldName = "COL10"
        Me.GV1_COL10.Name = "GV1_COL10"
        Me.GV1_COL10.OptionsColumn.AllowEdit = False
        Me.GV1_COL10.OptionsColumn.ReadOnly = True
        Me.GV1_COL10.Visible = True
        Me.GV1_COL10.VisibleIndex = 16
        Me.GV1_COL10.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL10, "칼럼10")
        '
        'GV1_COL11
        '
        Me.GV1_COL11.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL11.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL11.Caption = "칼럼11"
        Me.GV1_COL11.FieldName = "COL11"
        Me.GV1_COL11.Name = "GV1_COL11"
        Me.GV1_COL11.OptionsColumn.AllowEdit = False
        Me.GV1_COL11.OptionsColumn.ReadOnly = True
        Me.GV1_COL11.Visible = True
        Me.GV1_COL11.VisibleIndex = 17
        Me.GV1_COL11.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL11, "칼럼11")
        '
        'GV1_COL12
        '
        Me.GV1_COL12.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL12.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL12.Caption = "칼럼12"
        Me.GV1_COL12.FieldName = "COL12"
        Me.GV1_COL12.Name = "GV1_COL12"
        Me.GV1_COL12.OptionsColumn.AllowEdit = False
        Me.GV1_COL12.OptionsColumn.ReadOnly = True
        Me.GV1_COL12.Visible = True
        Me.GV1_COL12.VisibleIndex = 18
        Me.GV1_COL12.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL12, "칼럼12")
        '
        'GV1_COL13
        '
        Me.GV1_COL13.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL13.Caption = "칼럼13"
        Me.GV1_COL13.FieldName = "COL13"
        Me.GV1_COL13.Name = "GV1_COL13"
        Me.GV1_COL13.OptionsColumn.AllowEdit = False
        Me.GV1_COL13.OptionsColumn.ReadOnly = True
        Me.GV1_COL13.Visible = True
        Me.GV1_COL13.VisibleIndex = 19
        Me.GV1_COL13.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL13, "칼럼13")
        '
        'GV1_COL14
        '
        Me.GV1_COL14.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL14.Caption = "칼럼14"
        Me.GV1_COL14.FieldName = "COL14"
        Me.GV1_COL14.Name = "GV1_COL14"
        Me.GV1_COL14.OptionsColumn.AllowEdit = False
        Me.GV1_COL14.OptionsColumn.ReadOnly = True
        Me.GV1_COL14.Visible = True
        Me.GV1_COL14.VisibleIndex = 20
        Me.GV1_COL14.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL14, "칼럼14")
        '
        'GV1_COL15
        '
        Me.GV1_COL15.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL15.Caption = "칼럼15"
        Me.GV1_COL15.FieldName = "COL15"
        Me.GV1_COL15.Name = "GV1_COL15"
        Me.GV1_COL15.OptionsColumn.AllowEdit = False
        Me.GV1_COL15.OptionsColumn.ReadOnly = True
        Me.GV1_COL15.Visible = True
        Me.GV1_COL15.VisibleIndex = 21
        Me.GV1_COL15.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL15, "칼럼15")
        '
        'GV1_COL16
        '
        Me.GV1_COL16.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL16.Caption = "칼럼16"
        Me.GV1_COL16.FieldName = "COL16"
        Me.GV1_COL16.Name = "GV1_COL16"
        Me.GV1_COL16.OptionsColumn.AllowEdit = False
        Me.GV1_COL16.OptionsColumn.ReadOnly = True
        Me.GV1_COL16.Visible = True
        Me.GV1_COL16.VisibleIndex = 22
        Me.GV1_COL16.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL16, "칼럼15")
        '
        'GV1_COL17
        '
        Me.GV1_COL17.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL17.Caption = "칼럼17"
        Me.GV1_COL17.FieldName = "COL17"
        Me.GV1_COL17.Name = "GV1_COL17"
        Me.GV1_COL17.OptionsColumn.AllowEdit = False
        Me.GV1_COL17.OptionsColumn.ReadOnly = True
        Me.GV1_COL17.Visible = True
        Me.GV1_COL17.VisibleIndex = 23
        Me.GV1_COL17.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL17, "칼럼17")
        '
        'GV1_COL18
        '
        Me.GV1_COL18.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL18.Caption = "칼럼18"
        Me.GV1_COL18.FieldName = "COL18"
        Me.GV1_COL18.Name = "GV1_COL18"
        Me.GV1_COL18.OptionsColumn.AllowEdit = False
        Me.GV1_COL18.OptionsColumn.ReadOnly = True
        Me.GV1_COL18.Visible = True
        Me.GV1_COL18.VisibleIndex = 24
        Me.GV1_COL18.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL18, "칼럼18")
        '
        'GV1_COL19
        '
        Me.GV1_COL19.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL19.Caption = "칼럼19"
        Me.GV1_COL19.FieldName = "COL19"
        Me.GV1_COL19.Name = "GV1_COL19"
        Me.GV1_COL19.OptionsColumn.AllowEdit = False
        Me.GV1_COL19.OptionsColumn.ReadOnly = True
        Me.GV1_COL19.Visible = True
        Me.GV1_COL19.VisibleIndex = 25
        Me.GV1_COL19.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL19, "칼럼19")
        '
        'GV1_COL20
        '
        Me.GV1_COL20.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL20.Caption = "칼럼20"
        Me.GV1_COL20.FieldName = "COL20"
        Me.GV1_COL20.Name = "GV1_COL20"
        Me.GV1_COL20.OptionsColumn.AllowEdit = False
        Me.GV1_COL20.OptionsColumn.ReadOnly = True
        Me.GV1_COL20.Visible = True
        Me.GV1_COL20.VisibleIndex = 26
        Me.GV1_COL20.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL20, "칼럼20")
        '
        'GV1_COL21
        '
        Me.GV1_COL21.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL21.Caption = "칼럼21"
        Me.GV1_COL21.FieldName = "COL21"
        Me.GV1_COL21.Name = "GV1_COL21"
        Me.GV1_COL21.OptionsColumn.AllowEdit = False
        Me.GV1_COL21.OptionsColumn.ReadOnly = True
        Me.GV1_COL21.Visible = True
        Me.GV1_COL21.VisibleIndex = 27
        Me.GV1_COL21.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL21, "칼럼21")
        '
        'GV1_COL22
        '
        Me.GV1_COL22.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL22.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL22.Caption = "칼럼22"
        Me.GV1_COL22.FieldName = "COL22"
        Me.GV1_COL22.Name = "GV1_COL22"
        Me.GV1_COL22.OptionsColumn.AllowEdit = False
        Me.GV1_COL22.OptionsColumn.ReadOnly = True
        Me.GV1_COL22.Visible = True
        Me.GV1_COL22.VisibleIndex = 28
        Me.GV1_COL22.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL22, "칼럼22")
        '
        'GV1_COL23
        '
        Me.GV1_COL23.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL23.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL23.Caption = "칼럼23"
        Me.GV1_COL23.FieldName = "COL23"
        Me.GV1_COL23.Name = "GV1_COL23"
        Me.GV1_COL23.OptionsColumn.AllowEdit = False
        Me.GV1_COL23.OptionsColumn.ReadOnly = True
        Me.GV1_COL23.Visible = True
        Me.GV1_COL23.VisibleIndex = 29
        Me.GV1_COL23.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL23, "칼럼23")
        '
        'GV1_COL24
        '
        Me.GV1_COL24.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL24.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL24.Caption = "칼럼24"
        Me.GV1_COL24.FieldName = "COL24"
        Me.GV1_COL24.Name = "GV1_COL24"
        Me.GV1_COL24.OptionsColumn.AllowEdit = False
        Me.GV1_COL24.OptionsColumn.ReadOnly = True
        Me.GV1_COL24.Visible = True
        Me.GV1_COL24.VisibleIndex = 30
        Me.GV1_COL24.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL24, "칼럼24")
        '
        'GV1_COL25
        '
        Me.GV1_COL25.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL25.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL25.Caption = "칼럼25"
        Me.GV1_COL25.FieldName = "COL25"
        Me.GV1_COL25.Name = "GV1_COL25"
        Me.GV1_COL25.OptionsColumn.AllowEdit = False
        Me.GV1_COL25.OptionsColumn.ReadOnly = True
        Me.GV1_COL25.Visible = True
        Me.GV1_COL25.VisibleIndex = 31
        Me.GV1_COL25.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL25, "칼럼25")
        '
        'GV1_COL26
        '
        Me.GV1_COL26.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL26.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL26.Caption = "칼럼26"
        Me.GV1_COL26.FieldName = "COL26"
        Me.GV1_COL26.Name = "GV1_COL26"
        Me.GV1_COL26.OptionsColumn.AllowEdit = False
        Me.GV1_COL26.OptionsColumn.ReadOnly = True
        Me.GV1_COL26.Visible = True
        Me.GV1_COL26.VisibleIndex = 32
        Me.GV1_COL26.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL26, "칼럼26")
        '
        'GV1_COL27
        '
        Me.GV1_COL27.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL27.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL27.Caption = "칼럼27"
        Me.GV1_COL27.FieldName = "COL27"
        Me.GV1_COL27.Name = "GV1_COL27"
        Me.GV1_COL27.OptionsColumn.AllowEdit = False
        Me.GV1_COL27.OptionsColumn.ReadOnly = True
        Me.GV1_COL27.Visible = True
        Me.GV1_COL27.VisibleIndex = 33
        Me.GV1_COL27.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL27, "칼럼27")
        '
        'GV1_COL28
        '
        Me.GV1_COL28.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL28.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL28.Caption = "칼럼28"
        Me.GV1_COL28.FieldName = "COL28"
        Me.GV1_COL28.Name = "GV1_COL28"
        Me.GV1_COL28.OptionsColumn.AllowEdit = False
        Me.GV1_COL28.OptionsColumn.ReadOnly = True
        Me.GV1_COL28.Visible = True
        Me.GV1_COL28.VisibleIndex = 34
        Me.GV1_COL28.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL28, "칼럼28")
        '
        'GV1_COL29
        '
        Me.GV1_COL29.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL29.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL29.Caption = "칼럼29"
        Me.GV1_COL29.FieldName = "COL29"
        Me.GV1_COL29.Name = "GV1_COL29"
        Me.GV1_COL29.OptionsColumn.AllowEdit = False
        Me.GV1_COL29.OptionsColumn.ReadOnly = True
        Me.GV1_COL29.Visible = True
        Me.GV1_COL29.VisibleIndex = 35
        Me.GV1_COL29.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL29, "칼럼29")
        '
        'GV1_COL30
        '
        Me.GV1_COL30.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL30.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_COL30.Caption = "칼럼30"
        Me.GV1_COL30.FieldName = "COL30"
        Me.GV1_COL30.Name = "GV1_COL30"
        Me.GV1_COL30.OptionsColumn.AllowEdit = False
        Me.GV1_COL30.OptionsColumn.ReadOnly = True
        Me.GV1_COL30.Visible = True
        Me.GV1_COL30.VisibleIndex = 36
        Me.GV1_COL30.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_COL30, "칼럼30")
        '
        'FGV1LocNum2
        '
        Me.FGV1LocNum2.AutoHeight = False
        Me.FGV1LocNum2.Mask.EditMask = "#,###,###,##0.00;(#,###,###,##0.00)"
        Me.FGV1LocNum2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.FGV1LocNum2.Mask.UseMaskAsDisplayFormat = True
        Me.FGV1LocNum2.Name = "FGV1LocNum2"
        '
        'FGV1Vat2
        '
        Me.FGV1Vat2.AutoHeight = False
        Me.FGV1Vat2.Mask.EditMask = "#,###,###,##0.00;(#,###,###,##0.00)"
        Me.FGV1Vat2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.FGV1Vat2.Mask.UseMaskAsDisplayFormat = True
        Me.FGV1Vat2.Name = "FGV1Vat2"
        '
        'GridView14
        '
        Me.GridView14.GridControl = Me.WG1
        Me.GridView14.Name = "GridView14"
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_EDI_ID, "전송번호")
        Me.Localizer1.SetWordID(Me.GV1_SEQ, "순번")
        Me.Localizer1.SetWordID(Me.GV1_ORG_DATA, "원본자료")
        Me.Localizer1.SetWordID(Me.GV1_SEG_ID, "Segment ID")
        Me.Localizer1.SetWordID(Me.GV1_GRP_CD, "그룹코드")
        Me.Localizer1.SetWordID(Me.GV1_UNH_SEQ, "UNH 순번")
        Me.Localizer1.SetWordID(Me.GV1_LOC_DTM_SEQ, "DTM 순번")
        Me.Localizer1.SetWordID(Me.GV1_COL1, "칼럼1")
        Me.Localizer1.SetWordID(Me.GV1_COL2, "칼럼2")
        Me.Localizer1.SetWordID(Me.GV1_COL3, "칼럼3")
        Me.Localizer1.SetWordID(Me.GV1_COL4, "칼럼4")
        Me.Localizer1.SetWordID(Me.GV1_COL5, "칼럼5")
        Me.Localizer1.SetWordID(Me.GV1_COL6, "칼럼6")
        Me.Localizer1.SetWordID(Me.GV1_COL7, "칼럼7")
        Me.Localizer1.SetWordID(Me.GV1_COL8, "칼럼8")
        Me.Localizer1.SetWordID(Me.GV1_COL9, "칼럼9")
        Me.Localizer1.SetWordID(Me.GV1_COL10, "칼럼10")
        Me.Localizer1.SetWordID(Me.GV1_COL11, "칼럼11")
        Me.Localizer1.SetWordID(Me.GV1_COL12, "칼럼12")
        Me.Localizer1.SetWordID(Me.GV1_COL13, "칼럼13")
        Me.Localizer1.SetWordID(Me.GV1_COL14, "칼럼14")
        Me.Localizer1.SetWordID(Me.GV1_COL15, "칼럼15")
        Me.Localizer1.SetWordID(Me.GV1_COL16, "칼럼15")
        Me.Localizer1.SetWordID(Me.GV1_COL17, "칼럼17")
        Me.Localizer1.SetWordID(Me.GV1_COL18, "칼럼18")
        Me.Localizer1.SetWordID(Me.GV1_COL19, "칼럼19")
        Me.Localizer1.SetWordID(Me.GV1_COL20, "칼럼20")
        Me.Localizer1.SetWordID(Me.GV1_COL21, "칼럼21")
        Me.Localizer1.SetWordID(Me.GV1_COL22, "칼럼22")
        Me.Localizer1.SetWordID(Me.GV1_COL23, "칼럼23")
        Me.Localizer1.SetWordID(Me.GV1_COL24, "칼럼24")
        Me.Localizer1.SetWordID(Me.GV1_COL25, "칼럼25")
        Me.Localizer1.SetWordID(Me.GV1_COL26, "칼럼26")
        Me.Localizer1.SetWordID(Me.GV1_COL27, "칼럼27")
        Me.Localizer1.SetWordID(Me.GV1_COL28, "칼럼28")
        Me.Localizer1.SetWordID(Me.GV1_COL29, "칼럼29")
        Me.Localizer1.SetWordID(Me.GV1_COL30, "칼럼30")
        Me.Localizer1.SetWordID(Me.Label54, "*Biz Type")
        Me.Localizer1.SetWordID(Me.Label101, "Booking Carrier Type")
        Me.Localizer1.SetWordID(Me.Label8, "Trig Office")
        Me.Localizer1.SetWordID(Me.Label6, "* Origin Office")
        Me.Localizer1.SetWordID(Me.Label7, "*Destination Office")
        Me.Localizer1.SetWordID(Me.ORGN_CD, "")
        Me.Localizer1.SetWordID(Me.DEST_CD, "")
        Me.Localizer1.SetWordID(Me.TRIG_CD, "")
        Me.Localizer1.SetWordID(Me.EDI_ID, "")
        Me.Localizer1.SetWordID(Me.LBL_EDI_ID, "전송번호")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.LabelFor = Nothing
        Me.Label54.Location = New System.Drawing.Point(656, 160)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(60, 14)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "*Biz Type"
        Me.Localizer1.SetWordID(Me.Label54, "*Biz Type")
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.LabelFor = Nothing
        Me.Label101.Location = New System.Drawing.Point(357, 160)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(120, 14)
        Me.Label101.TabIndex = 0
        Me.Label101.Text = "Booking Carrier Type"
        Me.Localizer1.SetWordID(Me.Label101, "Booking Carrier Type")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.LabelFor = Nothing
        Me.Label8.Location = New System.Drawing.Point(902, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Trig Office"
        Me.Label8.Visible = False
        Me.Localizer1.SetWordID(Me.Label8, "Trig Office")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(388, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "* Origin Office"
        Me.Label6.Visible = False
        Me.Localizer1.SetWordID(Me.Label6, "* Origin Office")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(605, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "*Destination Office"
        Me.Label7.Visible = False
        Me.Localizer1.SetWordID(Me.Label7, "*Destination Office")
        '
        'ORGN_CD
        '
        Me.ORGN_CD.AlwaysSetDisplayParams = False
        Me.ORGN_CD.AutoSuggestion = False
        Me.ORGN_CD.BackColor = System.Drawing.SystemColors.Window
        Me.ORGN_CD.BorderColor = System.Drawing.Color.Empty
        Me.ORGN_CD.CodeType = "YJIT.CodeService.OfficePartner"
        Me.ORGN_CD.DataParams = "''"
        Me.ORGN_CD.DefVal = ""
        Me.ORGN_CD.DisplayParams = "Code:@ORGN_CD"
        Me.ORGN_CD.EditPopup = ""
        Me.ORGN_CD.IconVisible = True
        Me.ORGN_CD.IsDataStateAware = True
        Me.ORGN_CD.KeepIntegrity = False
        Me.ORGN_CD.Location = New System.Drawing.Point(484, 77)
        Me.ORGN_CD.MaxLength = 10
        Me.ORGN_CD.Name = "ORGN_CD"
        Me.ORGN_CD.NextFocus = "DEST_CD"
        Me.ORGN_CD.SearchPopup = "CodeMaster"
        Me.ORGN_CD.Size = New System.Drawing.Size(106, 22)
        Me.ORGN_CD.SuppressValidateCode = False
        Me.ORGN_CD.TabIndex = 21
        Me.ORGN_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.ORGN_CD.ValidateKeys = "OfficeCode:@ORGN_CD"
        Me.ORGN_CD.Visible = False
        '
        'DEST_CD
        '
        Me.DEST_CD.AlwaysSetDisplayParams = False
        Me.DEST_CD.AutoSuggestion = False
        Me.DEST_CD.BorderColor = System.Drawing.Color.Empty
        Me.DEST_CD.CodeType = "YJIT.CodeService.OfficePartner"
        Me.DEST_CD.DataParams = "''"
        Me.DEST_CD.DefVal = ""
        Me.DEST_CD.DisplayParams = "Code:@DEST_CD"
        Me.DEST_CD.EditPopup = ""
        Me.DEST_CD.IconVisible = True
        Me.DEST_CD.IsDataStateAware = True
        Me.DEST_CD.KeepIntegrity = False
        Me.DEST_CD.Location = New System.Drawing.Point(719, 77)
        Me.DEST_CD.MaxLength = 10
        Me.DEST_CD.Name = "DEST_CD"
        Me.DEST_CD.NextFocus = "TRIG_CD"
        Me.DEST_CD.SearchPopup = "CodeMaster"
        Me.DEST_CD.Size = New System.Drawing.Size(89, 22)
        Me.DEST_CD.SuppressValidateCode = False
        Me.DEST_CD.TabIndex = 22
        Me.DEST_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.DEST_CD.ValidateKeys = "OfficeCode:@DEST_CD"
        Me.DEST_CD.Visible = False
        '
        'TRIG_CD
        '
        Me.TRIG_CD.AlwaysSetDisplayParams = False
        Me.TRIG_CD.AutoSuggestion = False
        Me.TRIG_CD.BorderColor = System.Drawing.Color.Empty
        Me.TRIG_CD.CodeType = "YJIT.CodeService.OfficePartner"
        Me.TRIG_CD.DataParams = "''"
        Me.TRIG_CD.DefVal = ""
        Me.TRIG_CD.DisplayParams = "Code:@TRIG_CD"
        Me.TRIG_CD.EditPopup = ""
        Me.TRIG_CD.IconVisible = True
        Me.TRIG_CD.IsDataStateAware = True
        Me.TRIG_CD.KeepIntegrity = False
        Me.TRIG_CD.Location = New System.Drawing.Point(976, 77)
        Me.TRIG_CD.MaxLength = 10
        Me.TRIG_CD.Name = "TRIG_CD"
        Me.TRIG_CD.NextFocus = "HBL_TYPE"
        Me.TRIG_CD.SearchPopup = "CodeMaster"
        Me.TRIG_CD.Size = New System.Drawing.Size(89, 22)
        Me.TRIG_CD.SuppressValidateCode = False
        Me.TRIG_CD.TabIndex = 23
        Me.TRIG_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.TRIG_CD.ValidateKeys = "OfficeCode:@TRIG_CD"
        Me.TRIG_CD.Visible = False
        '
        'EDI_ID
        '
        Me.EDI_ID.BorderColor = System.Drawing.Color.Silver
        Me.EDI_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EDI_ID.DefVal = ""
        Me.EDI_ID.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.EDI_ID.IsDataStateAware = True
        Me.EDI_ID.Location = New System.Drawing.Point(121, 5)
        Me.EDI_ID.MaxLength = 20
        Me.EDI_ID.Name = "EDI_ID"
        Me.EDI_ID.NextFocus = "btnSearch"
        Me.EDI_ID.Size = New System.Drawing.Size(182, 25)
        Me.EDI_ID.TabIndex = 1
        Me.EDI_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'LBL_EDI_ID
        '
        Me.LBL_EDI_ID.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBL_EDI_ID.LabelFor = Nothing
        Me.LBL_EDI_ID.Location = New System.Drawing.Point(5, 6)
        Me.LBL_EDI_ID.Name = "LBL_EDI_ID"
        Me.LBL_EDI_ID.Size = New System.Drawing.Size(110, 22)
        Me.LBL_EDI_ID.TabIndex = 368
        Me.LBL_EDI_ID.Text = "전송번호"
        Me.LBL_EDI_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_EDI_ID, "전송번호")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LBL_EDI_ID)
        Me.PanelControl1.Controls.Add(Me.EDI_ID)
        Me.PanelControl1.Controls.Add(Me.TRIG_CD)
        Me.PanelControl1.Controls.Add(Me.DEST_CD)
        Me.PanelControl1.Controls.Add(Me.ORGN_CD)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.Label8)
        Me.PanelControl1.Controls.Add(Me.Label101)
        Me.PanelControl1.Controls.Add(Me.Label54)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 40)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1057, 69)
        Me.PanelControl1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'YjediFactDetailList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1527, 777)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "YjediFactDetailList"
        Me.Text = "송수신 이력조회"
        Me.Localizer1.SetWordID(Me, "송수신 이력조회")
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FGV1LocNum2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FGV1Vat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents btnNew As SCControls.Button
    Public WithEvents WG1 As SCControls.WebGrid
    Public WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_ORG_DATA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SEG_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_EDI_ID As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GV1_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GV1_GRP_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UNH_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_LOC_DTM_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1LocNum2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_COL6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1Vat2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_COL8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_COL5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label54 As SCControls.Label
    Friend WithEvents Label101 As SCControls.Label
    Friend WithEvents Label8 As SCControls.Label
    Friend WithEvents Label6 As SCControls.Label
    Friend WithEvents Label7 As SCControls.Label
    Friend WithEvents ORGN_CD As SCControls.CodeBox
    Friend WithEvents DEST_CD As SCControls.CodeBox
    Friend WithEvents TRIG_CD As SCControls.CodeBox
    Public WithEvents EDI_ID As SCControls.TextBox
    Friend WithEvents LBL_EDI_ID As SCControls.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
