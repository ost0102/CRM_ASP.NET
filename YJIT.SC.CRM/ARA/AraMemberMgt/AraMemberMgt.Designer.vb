<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AraMemberMgt
    Inherits YJIT.SC.UI.SCView

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AraMemberMgt))
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TablePanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExpWg1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnQuickWg1 = New YJIT.SC.UI.SCControls.Button()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_CRM_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_BUSN_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LicenseNo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV7_CheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.PRICE = New YJIT.SC.UI.SCControls.NumericTextBox()
        Me.BASE_ISSUE_CNT = New YJIT.SC.UI.SCControls.NumericTextBox()
        Me.BASE_AMT = New YJIT.SC.UI.SCControls.NumericTextBox()
        Me.RMK = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.Label19 = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_BASE_AMT = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_PRICE = New YJIT.SC.UI.SCControls.Label()
        Me.Label15 = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_RMK = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_BASE_ISSUE_CNT = New YJIT.SC.UI.SCControls.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.MEMB_STATE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.USE_END_DT = New YJIT.SC.UI.SCControls.DateBox()
        Me.USE_START_DT = New YJIT.SC.UI.SCControls.DateBox()
        Me.lbl_USE_START_DT = New YJIT.SC.UI.SCControls.Label()
        Me.ERP_LINK_SERVICE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.lbl_ERP_LINK_SERVICE = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_USE_END_DT = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_MEMB_STATE = New YJIT.SC.UI.SCControls.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnNaviCRM = New System.Windows.Forms.Button()
        Me.CRM_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.BUSN_NO = New YJIT.SC.UI.SCControls.MaskedTextBox()
        Me.btnValidate = New YJIT.SC.UI.SCControls.Button()
        Me.lbl_BUSN_NO = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_CRM_CD = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_CUST_NM = New YJIT.SC.UI.SCControls.Label()
        Me.BIZ_TYPE = New YJIT.SC.UI.SCControls.TextBox()
        Me.BIZ_COND = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_BIZ_COND = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_BIZ_TYPE = New YJIT.SC.UI.SCControls.Label()
        Me.CEO = New YJIT.SC.UI.SCControls.TextBox()
        Me.CUST_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_CEO = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_SUB_BD_NO = New YJIT.SC.UI.SCControls.Label()
        Me.CUST_ADDR = New YJIT.SC.UI.SCControls.TextBox()
        Me.SUB_BD_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_CUST_ADDR = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_ZIP_CD = New YJIT.SC.UI.SCControls.Label()
        Me.ZIP_CD = New YJIT.SC.UI.SCControls.TextBox()
        Me.CRM_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.USE_YN = New YJIT.SC.UI.SCControls.CheckBox()
        Me.SEARCH_KEY = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_SEARCH_KEY = New YJIT.SC.UI.SCControls.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New YJIT.SC.UI.SCControls.Button()
        Me.Button4 = New YJIT.SC.UI.SCControls.Button()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TablePanel1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicenseNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7_CheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.USE_YN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "#,##0.0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSearch, "검색(&A)")
        Me.Localizer1.SetWordID(Me.btnNew, "신규(&N)")
        Me.Localizer1.SetWordID(Me.btnSave, "저장(&S)")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        Me.Localizer1.SetWordID(Me.TablePanel1, "")
        Me.Localizer1.SetWordID(Me.btnExpWg1, "btnExpWg1")
        Me.Localizer1.SetWordID(Me.btnQuickWg1, "btnQuickWg1")
        Me.Localizer1.SetWordID(Me.SplitContainerControl2, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_CRM_CD, "CRM코드")
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "거래처 명")
        Me.Localizer1.SetWordID(Me.GV1_BUSN_NO, "사업자 등록번호")
        Me.Localizer1.SetWordID(Me.GroupControl3, "회사 기본 정보")
        Me.Localizer1.SetWordID(Me.PRICE, "0")
        Me.Localizer1.SetWordID(Me.BASE_ISSUE_CNT, "0")
        Me.Localizer1.SetWordID(Me.BASE_AMT, "0")
        Me.Localizer1.SetWordID(Me.RMK, "")
        Me.Localizer1.SetWordID(Me.Label4, "건")
        Me.Localizer1.SetWordID(Me.Label19, "원")
        Me.Localizer1.SetWordID(Me.lbl_BASE_AMT, "기본요금")
        Me.Localizer1.SetWordID(Me.lbl_PRICE, "단가")
        Me.Localizer1.SetWordID(Me.Label15, "원")
        Me.Localizer1.SetWordID(Me.lbl_RMK, "비고")
        Me.Localizer1.SetWordID(Me.lbl_BASE_ISSUE_CNT, "기본발행건수")
        Me.Localizer1.SetWordID(Me.GroupControl2, "회사 기본 정보")
        Me.Localizer1.SetWordID(Me.MEMB_STATE, "0")
        Me.Localizer1.SetWordID(Me.USE_END_DT, "")
        Me.Localizer1.SetWordID(Me.USE_START_DT, "")
        Me.Localizer1.SetWordID(Me.lbl_USE_START_DT, "사용시작일")
        Me.Localizer1.SetWordID(Me.ERP_LINK_SERVICE, "ELVIS")
        Me.Localizer1.SetWordID(Me.lbl_ERP_LINK_SERVICE, "ERP연동")
        Me.Localizer1.SetWordID(Me.lbl_USE_END_DT, "사용해지일")
        Me.Localizer1.SetWordID(Me.lbl_MEMB_STATE, "회원상태")
        Me.Localizer1.SetWordID(Me.GroupControl1, "회사 기본 정보")
        Me.Localizer1.SetWordID(Me.btnNaviCRM, "")
        Me.Localizer1.SetWordID(Me.CRM_NM, "")
        Me.Localizer1.SetWordID(Me.BUSN_NO, "BUSN_NO")
        Me.Localizer1.SetWordID(Me.btnValidate, "중복체크")
        Me.Localizer1.SetWordID(Me.lbl_BUSN_NO, "*사업자등록번호")
        Me.Localizer1.SetWordID(Me.lbl_CRM_CD, "*CRM 코드")
        Me.Localizer1.SetWordID(Me.lbl_CUST_NM, "*상호명")
        Me.Localizer1.SetWordID(Me.BIZ_TYPE, "")
        Me.Localizer1.SetWordID(Me.BIZ_COND, "")
        Me.Localizer1.SetWordID(Me.lbl_BIZ_COND, "*종목")
        Me.Localizer1.SetWordID(Me.lbl_BIZ_TYPE, "업태")
        Me.Localizer1.SetWordID(Me.CEO, "")
        Me.Localizer1.SetWordID(Me.CUST_NM, "")
        Me.Localizer1.SetWordID(Me.lbl_CEO, "*대표자명")
        Me.Localizer1.SetWordID(Me.lbl_SUB_BD_NO, "종사업장코드")
        Me.Localizer1.SetWordID(Me.CUST_ADDR, "")
        Me.Localizer1.SetWordID(Me.SUB_BD_NO, "")
        Me.Localizer1.SetWordID(Me.lbl_CUST_ADDR, "사업장주소")
        Me.Localizer1.SetWordID(Me.lbl_ZIP_CD, "우편번호")
        Me.Localizer1.SetWordID(Me.ZIP_CD, "")
        Me.Localizer1.SetWordID(Me.CRM_CD, "")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.USE_YN, "회원 계약해지 포함")
        Me.Localizer1.SetWordID(Me.SEARCH_KEY, "")
        Me.Localizer1.SetWordID(Me.lbl_SEARCH_KEY, "검색")
        Me.Localizer1.SetWordID(Me.Panel2, "")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel1, "")
        Me.Localizer1.SetWordID(Me.Button3, "btnExpWg1")
        Me.Localizer1.SetWordID(Me.Button4, "btnQuickWg1")
        '
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Location = New System.Drawing.Point(3, 3)
        Me.palAutoButton.MaximumSize = New System.Drawing.Size(1312, 35)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1312, 35)
        Me.palAutoButton.TabIndex = 108
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1073, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 25)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "검색(&A)"
        Me.Localizer1.SetWordID(Me.btnSearch, "검색(&A)")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.[New]
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(1153, 5)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(74, 25)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "신규(&N)"
        Me.Localizer1.SetWordID(Me.btnNew, "신규(&N)")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(1233, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 25)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "저장(&S)"
        Me.Localizer1.SetWordID(Me.btnSave, "저장(&S)")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TablePanel1)
        Me.Panel1.Location = New System.Drawing.Point(3, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1316, 859)
        Me.Panel1.TabIndex = 109
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'TablePanel1
        '
        Me.TablePanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablePanel1.ColumnCount = 4
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TablePanel1.Controls.Add(Me.btnExpWg1, 1, 0)
        Me.TablePanel1.Controls.Add(Me.btnQuickWg1, 2, 0)
        Me.TablePanel1.Location = New System.Drawing.Point(1394, 69)
        Me.TablePanel1.Name = "TablePanel1"
        Me.TablePanel1.RowCount = 1
        Me.TablePanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TablePanel1.Size = New System.Drawing.Size(67, 30)
        Me.TablePanel1.TabIndex = 209
        Me.Localizer1.SetWordID(Me.TablePanel1, "")
        '
        'btnExpWg1
        '
        Me.btnExpWg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExpWg1.Image = CType(resources.GetObject("btnExpWg1.Image"), System.Drawing.Image)
        Me.btnExpWg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExpWg1.Location = New System.Drawing.Point(6, 3)
        Me.btnExpWg1.Name = "btnExpWg1"
        Me.btnExpWg1.Size = New System.Drawing.Size(24, 24)
        Me.btnExpWg1.TabIndex = 212
        Me.btnExpWg1.Text = "btnExpWg1"
        Me.Localizer1.SetWordID(Me.btnExpWg1, "btnExpWg1")
        '
        'btnQuickWg1
        '
        Me.btnQuickWg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnQuickWg1.Image = CType(resources.GetObject("btnQuickWg1.Image"), System.Drawing.Image)
        Me.btnQuickWg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuickWg1.Location = New System.Drawing.Point(36, 3)
        Me.btnQuickWg1.Name = "btnQuickWg1"
        Me.btnQuickWg1.Size = New System.Drawing.Size(24, 24)
        Me.btnQuickWg1.TabIndex = 213
        Me.btnQuickWg1.Text = "btnQuickWg1"
        Me.Localizer1.SetWordID(Me.btnQuickWg1, "btnQuickWg1")
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl2.Location = New System.Drawing.Point(3, 77)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.WG1)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.AutoScroll = True
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1316, 856)
        Me.SplitContainerControl2.SplitterPosition = 454
        Me.SplitContainerControl2.TabIndex = 210
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        Me.Localizer1.SetWordID(Me.SplitContainerControl2, "SplitContainerControl1")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(0, 0)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GV7_CheckEdit, Me.LicenseNo})
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(454, 856)
        Me.WG1.TabIndex = 10004
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_CRM_CD, Me.GV1_CUST_NM, Me.GV1_BUSN_NO})
        Me.GV1.CustomizationFormBounds = New System.Drawing.Rectangle(892, 567, 216, 185)
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.RowHeight = 10
        Me.GV1.ViewCaption = " 문서 리스트"
        '
        'GV1_CRM_CD
        '
        Me.GV1_CRM_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CRM_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CRM_CD.Caption = "CRM코드"
        Me.GV1_CRM_CD.FieldName = "CRM_CD"
        Me.GV1_CRM_CD.Name = "GV1_CRM_CD"
        Me.GV1_CRM_CD.OptionsColumn.AllowEdit = False
        Me.GV1_CRM_CD.OptionsColumn.ReadOnly = True
        Me.GV1_CRM_CD.Visible = True
        Me.GV1_CRM_CD.VisibleIndex = 0
        Me.GV1_CRM_CD.Width = 70
        Me.Localizer1.SetWordID(Me.GV1_CRM_CD, "CRM코드")
        '
        'GV1_CUST_NM
        '
        Me.GV1_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_NM.Caption = "거래처 명"
        Me.GV1_CUST_NM.FieldName = "CUST_NM"
        Me.GV1_CUST_NM.Name = "GV1_CUST_NM"
        Me.GV1_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_NM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CUST_NM", "총")})
        Me.GV1_CUST_NM.Visible = True
        Me.GV1_CUST_NM.VisibleIndex = 1
        Me.GV1_CUST_NM.Width = 213
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "거래처 명")
        '
        'GV1_BUSN_NO
        '
        Me.GV1_BUSN_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BUSN_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BUSN_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BUSN_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BUSN_NO.Caption = "사업자 등록번호"
        Me.GV1_BUSN_NO.ColumnEdit = Me.LicenseNo
        Me.GV1_BUSN_NO.FieldName = "BUSN_NO"
        Me.GV1_BUSN_NO.Name = "GV1_BUSN_NO"
        Me.GV1_BUSN_NO.OptionsColumn.AllowEdit = False
        Me.GV1_BUSN_NO.OptionsColumn.ReadOnly = True
        Me.GV1_BUSN_NO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "BUSN_NO", "{0:###,###,###,##0}")})
        Me.GV1_BUSN_NO.Visible = True
        Me.GV1_BUSN_NO.VisibleIndex = 2
        Me.GV1_BUSN_NO.Width = 109
        Me.Localizer1.SetWordID(Me.GV1_BUSN_NO, "사업자 등록번호")
        '
        'LicenseNo
        '
        Me.LicenseNo.AutoHeight = False
        Me.LicenseNo.Mask.EditMask = "000-00-00000"
        Me.LicenseNo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.LicenseNo.Mask.UseMaskAsDisplayFormat = True
        Me.LicenseNo.Name = "LicenseNo"
        '
        'GV7_CheckEdit
        '
        Me.GV7_CheckEdit.AutoHeight = False
        Me.GV7_CheckEdit.Name = "GV7_CheckEdit"
        Me.GV7_CheckEdit.ValueChecked = "Y"
        Me.GV7_CheckEdit.ValueUnchecked = "N"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.PRICE)
        Me.GroupControl3.Controls.Add(Me.BASE_ISSUE_CNT)
        Me.GroupControl3.Controls.Add(Me.BASE_AMT)
        Me.GroupControl3.Controls.Add(Me.RMK)
        Me.GroupControl3.Controls.Add(Me.Label4)
        Me.GroupControl3.Controls.Add(Me.Label19)
        Me.GroupControl3.Controls.Add(Me.lbl_BASE_AMT)
        Me.GroupControl3.Controls.Add(Me.lbl_PRICE)
        Me.GroupControl3.Controls.Add(Me.Label15)
        Me.GroupControl3.Controls.Add(Me.lbl_RMK)
        Me.GroupControl3.Controls.Add(Me.lbl_BASE_ISSUE_CNT)
        Me.GroupControl3.Location = New System.Drawing.Point(1, 301)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(852, 149)
        Me.GroupControl3.TabIndex = 223
        Me.GroupControl3.Text = "요금 설정"
        Me.Localizer1.SetWordID(Me.GroupControl3, "회사 기본 정보")
        '
        'PRICE
        '
        Me.PRICE.AllowSpace = False
        Me.PRICE.BindingPropertyName = "Text"
        Me.PRICE.BorderColor = System.Drawing.Color.Silver
        Me.PRICE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PRICE.DefVal = ""
        Me.PRICE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.PRICE.Format = "###,###,##0"
        Me.PRICE.IsDataStateAware = True
        Me.PRICE.Location = New System.Drawing.Point(561, 58)
        Me.PRICE.MaxLength = 15
        Me.PRICE.Name = "PRICE"
        Me.PRICE.NextFocus = "RMK"
        Me.PRICE.Size = New System.Drawing.Size(130, 22)
        Me.PRICE.TabIndex = 20
        Me.PRICE.Text = "0"
        Me.PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PRICE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.PRICE.Value = 0R
        '
        'BASE_ISSUE_CNT
        '
        Me.BASE_ISSUE_CNT.AllowSpace = False
        Me.BASE_ISSUE_CNT.BindingPropertyName = "Text"
        Me.BASE_ISSUE_CNT.BorderColor = System.Drawing.Color.Silver
        Me.BASE_ISSUE_CNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BASE_ISSUE_CNT.DefVal = ""
        Me.BASE_ISSUE_CNT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BASE_ISSUE_CNT.Format = "###,###,##0"
        Me.BASE_ISSUE_CNT.IsDataStateAware = True
        Me.BASE_ISSUE_CNT.Location = New System.Drawing.Point(128, 58)
        Me.BASE_ISSUE_CNT.MaxLength = 10
        Me.BASE_ISSUE_CNT.Name = "BASE_ISSUE_CNT"
        Me.BASE_ISSUE_CNT.NextFocus = "PRICE"
        Me.BASE_ISSUE_CNT.Size = New System.Drawing.Size(130, 22)
        Me.BASE_ISSUE_CNT.TabIndex = 19
        Me.BASE_ISSUE_CNT.Text = "0"
        Me.BASE_ISSUE_CNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BASE_ISSUE_CNT.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.BASE_ISSUE_CNT.Value = 0R
        '
        'BASE_AMT
        '
        Me.BASE_AMT.AllowSpace = False
        Me.BASE_AMT.BindingPropertyName = "Text"
        Me.BASE_AMT.BorderColor = System.Drawing.Color.Silver
        Me.BASE_AMT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BASE_AMT.DefVal = ""
        Me.BASE_AMT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BASE_AMT.Format = "###,###,##0"
        Me.BASE_AMT.IsDataStateAware = True
        Me.BASE_AMT.Location = New System.Drawing.Point(128, 29)
        Me.BASE_AMT.MaxLength = 15
        Me.BASE_AMT.Name = "BASE_AMT"
        Me.BASE_AMT.NextFocus = "BASE_ISSUE_CNT"
        Me.BASE_AMT.Size = New System.Drawing.Size(130, 22)
        Me.BASE_AMT.TabIndex = 18
        Me.BASE_AMT.Text = "0"
        Me.BASE_AMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BASE_AMT.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.BASE_AMT.Value = 0R
        '
        'RMK
        '
        Me.RMK.BorderColor = System.Drawing.Color.Silver
        Me.RMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RMK.DefVal = ""
        Me.RMK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RMK.IsDataStateAware = True
        Me.RMK.Location = New System.Drawing.Point(128, 87)
        Me.RMK.MaxLength = 400
        Me.RMK.Multiline = True
        Me.RMK.Name = "RMK"
        Me.RMK.NextFocus = "btnSave"
        Me.RMK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RMK.Size = New System.Drawing.Size(703, 50)
        Me.RMK.TabIndex = 21
        Me.RMK.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(264, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 22)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "건"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label4, "건")
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label19.LabelFor = Nothing
        Me.Label19.Location = New System.Drawing.Point(264, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 22)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "원"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label19, "원")
        '
        'lbl_BASE_AMT
        '
        Me.lbl_BASE_AMT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_BASE_AMT.LabelFor = Nothing
        Me.lbl_BASE_AMT.Location = New System.Drawing.Point(5, 29)
        Me.lbl_BASE_AMT.Name = "lbl_BASE_AMT"
        Me.lbl_BASE_AMT.Size = New System.Drawing.Size(117, 22)
        Me.lbl_BASE_AMT.TabIndex = 117
        Me.lbl_BASE_AMT.Text = "기본요금"
        Me.lbl_BASE_AMT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_BASE_AMT, "기본요금")
        '
        'lbl_PRICE
        '
        Me.lbl_PRICE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_PRICE.LabelFor = Nothing
        Me.lbl_PRICE.Location = New System.Drawing.Point(433, 58)
        Me.lbl_PRICE.Name = "lbl_PRICE"
        Me.lbl_PRICE.Size = New System.Drawing.Size(124, 22)
        Me.lbl_PRICE.TabIndex = 6
        Me.lbl_PRICE.Text = "단가"
        Me.lbl_PRICE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_PRICE, "단가")
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label15.LabelFor = Nothing
        Me.Label15.Location = New System.Drawing.Point(697, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 22)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "원"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label15, "원")
        '
        'lbl_RMK
        '
        Me.lbl_RMK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_RMK.LabelFor = Nothing
        Me.lbl_RMK.Location = New System.Drawing.Point(5, 87)
        Me.lbl_RMK.Name = "lbl_RMK"
        Me.lbl_RMK.Size = New System.Drawing.Size(117, 22)
        Me.lbl_RMK.TabIndex = 109
        Me.lbl_RMK.Text = "비고"
        Me.lbl_RMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_RMK, "비고")
        '
        'lbl_BASE_ISSUE_CNT
        '
        Me.lbl_BASE_ISSUE_CNT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_BASE_ISSUE_CNT.LabelFor = Nothing
        Me.lbl_BASE_ISSUE_CNT.Location = New System.Drawing.Point(5, 58)
        Me.lbl_BASE_ISSUE_CNT.Name = "lbl_BASE_ISSUE_CNT"
        Me.lbl_BASE_ISSUE_CNT.Size = New System.Drawing.Size(117, 22)
        Me.lbl_BASE_ISSUE_CNT.TabIndex = 107
        Me.lbl_BASE_ISSUE_CNT.Text = "기본발행건수"
        Me.lbl_BASE_ISSUE_CNT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_BASE_ISSUE_CNT, "기본발행건수")
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.MEMB_STATE)
        Me.GroupControl2.Controls.Add(Me.USE_END_DT)
        Me.GroupControl2.Controls.Add(Me.USE_START_DT)
        Me.GroupControl2.Controls.Add(Me.lbl_USE_START_DT)
        Me.GroupControl2.Controls.Add(Me.ERP_LINK_SERVICE)
        Me.GroupControl2.Controls.Add(Me.lbl_ERP_LINK_SERVICE)
        Me.GroupControl2.Controls.Add(Me.lbl_USE_END_DT)
        Me.GroupControl2.Controls.Add(Me.lbl_MEMB_STATE)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 202)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(852, 92)
        Me.GroupControl2.TabIndex = 222
        Me.GroupControl2.Text = "회원 설정"
        Me.Localizer1.SetWordID(Me.GroupControl2, "회사 기본 정보")
        '
        'MEMB_STATE
        '
        Me.MEMB_STATE.CodeType = "YJIT.CodeService.CommonCode"
        Me.MEMB_STATE.ColumnWidths = ""
        Me.MEMB_STATE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.MEMB_STATE.DataParams = "GroupCode:'EVB01',NameType:''"
        Me.MEMB_STATE.DefVal = ""
        Me.MEMB_STATE.DisplayMember = "NAME"
        Me.MEMB_STATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MEMB_STATE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.MEMB_STATE.FormattingEnabled = True
        Me.MEMB_STATE.IsDataStateAware = True
        Me.MEMB_STATE.ItemDelimiter = ","
        Me.MEMB_STATE.ItemTextList = ""
        Me.MEMB_STATE.ItemValueList = ""
        Me.MEMB_STATE.KeepIntegrity = True
        Me.MEMB_STATE.Location = New System.Drawing.Point(561, 29)
        Me.MEMB_STATE.Name = "MEMB_STATE"
        Me.MEMB_STATE.NextFocus = "USE_START_DT"
        Me.MEMB_STATE.NullText = ""
        Me.MEMB_STATE.SearchKeys = ""
        Me.MEMB_STATE.Size = New System.Drawing.Size(117, 22)
        Me.MEMB_STATE.TabIndex = 15
        Me.MEMB_STATE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.MEMB_STATE.ValueMember = "CODE"
        '
        'USE_END_DT
        '
        Me.USE_END_DT.BorderColor = System.Drawing.Color.Silver
        Me.USE_END_DT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.USE_END_DT.DefVal = ""
        Me.USE_END_DT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.USE_END_DT.IconVisible = True
        Me.USE_END_DT.IsDataStateAware = True
        Me.USE_END_DT.Location = New System.Drawing.Point(561, 58)
        Me.USE_END_DT.Name = "USE_END_DT"
        Me.USE_END_DT.NextFocus = "BASE_AMT"
        Me.USE_END_DT.Size = New System.Drawing.Size(98, 22)
        Me.USE_END_DT.TabIndex = 17
        Me.Localizer1.SetWordID(Me.USE_END_DT, "")
        '
        'USE_START_DT
        '
        Me.USE_START_DT.BorderColor = System.Drawing.Color.Silver
        Me.USE_START_DT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.USE_START_DT.DefVal = ""
        Me.USE_START_DT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.USE_START_DT.IconVisible = True
        Me.USE_START_DT.IsDataStateAware = True
        Me.USE_START_DT.Location = New System.Drawing.Point(128, 58)
        Me.USE_START_DT.Name = "USE_START_DT"
        Me.USE_START_DT.NextFocus = "USE_END_DT"
        Me.USE_START_DT.Size = New System.Drawing.Size(98, 22)
        Me.USE_START_DT.TabIndex = 16
        Me.Localizer1.SetWordID(Me.USE_START_DT, "")
        '
        'lbl_USE_START_DT
        '
        Me.lbl_USE_START_DT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_USE_START_DT.LabelFor = Nothing
        Me.lbl_USE_START_DT.Location = New System.Drawing.Point(5, 58)
        Me.lbl_USE_START_DT.Name = "lbl_USE_START_DT"
        Me.lbl_USE_START_DT.Size = New System.Drawing.Size(117, 22)
        Me.lbl_USE_START_DT.TabIndex = 10026
        Me.lbl_USE_START_DT.Text = "사용시작일"
        Me.lbl_USE_START_DT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_USE_START_DT, "사용시작일")
        '
        'ERP_LINK_SERVICE
        '
        Me.ERP_LINK_SERVICE.CodeType = "YJIT.CodeService.CommonCode"
        Me.ERP_LINK_SERVICE.ColumnWidths = ""
        Me.ERP_LINK_SERVICE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.ERP_LINK_SERVICE.DataParams = "GroupCode:'EVB03',NameType:''"
        Me.ERP_LINK_SERVICE.DefVal = ""
        Me.ERP_LINK_SERVICE.DisplayMember = "NAME"
        Me.ERP_LINK_SERVICE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ERP_LINK_SERVICE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ERP_LINK_SERVICE.FormattingEnabled = True
        Me.ERP_LINK_SERVICE.IsDataStateAware = True
        Me.ERP_LINK_SERVICE.ItemDelimiter = ","
        Me.ERP_LINK_SERVICE.ItemTextList = ""
        Me.ERP_LINK_SERVICE.ItemValueList = ""
        Me.ERP_LINK_SERVICE.KeepIntegrity = True
        Me.ERP_LINK_SERVICE.Location = New System.Drawing.Point(128, 29)
        Me.ERP_LINK_SERVICE.Name = "ERP_LINK_SERVICE"
        Me.ERP_LINK_SERVICE.NextFocus = "MEMB_STATE"
        Me.ERP_LINK_SERVICE.NullText = ""
        Me.ERP_LINK_SERVICE.SearchKeys = ""
        Me.ERP_LINK_SERVICE.Size = New System.Drawing.Size(117, 22)
        Me.ERP_LINK_SERVICE.TabIndex = 14
        Me.ERP_LINK_SERVICE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.ERP_LINK_SERVICE.ValueMember = "CODE"
        '
        'lbl_ERP_LINK_SERVICE
        '
        Me.lbl_ERP_LINK_SERVICE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_ERP_LINK_SERVICE.LabelFor = Nothing
        Me.lbl_ERP_LINK_SERVICE.Location = New System.Drawing.Point(5, 29)
        Me.lbl_ERP_LINK_SERVICE.Name = "lbl_ERP_LINK_SERVICE"
        Me.lbl_ERP_LINK_SERVICE.Size = New System.Drawing.Size(117, 22)
        Me.lbl_ERP_LINK_SERVICE.TabIndex = 117
        Me.lbl_ERP_LINK_SERVICE.Text = "ERP연동"
        Me.lbl_ERP_LINK_SERVICE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_ERP_LINK_SERVICE, "ERP연동")
        '
        'lbl_USE_END_DT
        '
        Me.lbl_USE_END_DT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_USE_END_DT.LabelFor = Nothing
        Me.lbl_USE_END_DT.Location = New System.Drawing.Point(433, 58)
        Me.lbl_USE_END_DT.Name = "lbl_USE_END_DT"
        Me.lbl_USE_END_DT.Size = New System.Drawing.Size(124, 22)
        Me.lbl_USE_END_DT.TabIndex = 103
        Me.lbl_USE_END_DT.Text = "사용해지일"
        Me.lbl_USE_END_DT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_USE_END_DT, "사용해지일")
        '
        'lbl_MEMB_STATE
        '
        Me.lbl_MEMB_STATE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_MEMB_STATE.LabelFor = Nothing
        Me.lbl_MEMB_STATE.Location = New System.Drawing.Point(433, 29)
        Me.lbl_MEMB_STATE.Name = "lbl_MEMB_STATE"
        Me.lbl_MEMB_STATE.Size = New System.Drawing.Size(124, 22)
        Me.lbl_MEMB_STATE.TabIndex = 111
        Me.lbl_MEMB_STATE.Text = "회원상태"
        Me.lbl_MEMB_STATE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_MEMB_STATE, "회원상태")
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnNaviCRM)
        Me.GroupControl1.Controls.Add(Me.CRM_NM)
        Me.GroupControl1.Controls.Add(Me.BUSN_NO)
        Me.GroupControl1.Controls.Add(Me.btnValidate)
        Me.GroupControl1.Controls.Add(Me.lbl_BUSN_NO)
        Me.GroupControl1.Controls.Add(Me.lbl_CRM_CD)
        Me.GroupControl1.Controls.Add(Me.lbl_CUST_NM)
        Me.GroupControl1.Controls.Add(Me.BIZ_TYPE)
        Me.GroupControl1.Controls.Add(Me.BIZ_COND)
        Me.GroupControl1.Controls.Add(Me.lbl_BIZ_COND)
        Me.GroupControl1.Controls.Add(Me.lbl_BIZ_TYPE)
        Me.GroupControl1.Controls.Add(Me.CEO)
        Me.GroupControl1.Controls.Add(Me.CUST_NM)
        Me.GroupControl1.Controls.Add(Me.lbl_CEO)
        Me.GroupControl1.Controls.Add(Me.lbl_SUB_BD_NO)
        Me.GroupControl1.Controls.Add(Me.CUST_ADDR)
        Me.GroupControl1.Controls.Add(Me.SUB_BD_NO)
        Me.GroupControl1.Controls.Add(Me.lbl_CUST_ADDR)
        Me.GroupControl1.Controls.Add(Me.lbl_ZIP_CD)
        Me.GroupControl1.Controls.Add(Me.ZIP_CD)
        Me.GroupControl1.Controls.Add(Me.CRM_CD)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(852, 195)
        Me.GroupControl1.TabIndex = 221
        Me.GroupControl1.Text = "회사 기본 정보"
        Me.Localizer1.SetWordID(Me.GroupControl1, "회사 기본 정보")
        '
        'btnNaviCRM
        '
        Me.btnNaviCRM.Image = CType(resources.GetObject("btnNaviCRM.Image"), System.Drawing.Image)
        Me.btnNaviCRM.Location = New System.Drawing.Point(232, 29)
        Me.btnNaviCRM.Name = "btnNaviCRM"
        Me.btnNaviCRM.Size = New System.Drawing.Size(22, 22)
        Me.btnNaviCRM.TabIndex = 10002
        Me.btnNaviCRM.UseVisualStyleBackColor = True
        Me.Localizer1.SetWordID(Me.btnNaviCRM, "")
        '
        'CRM_NM
        '
        Me.CRM_NM.BorderColor = System.Drawing.Color.Silver
        Me.CRM_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRM_NM.DefVal = ""
        Me.CRM_NM.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CRM_NM.IsDataStateAware = True
        Me.CRM_NM.Location = New System.Drawing.Point(238, 29)
        Me.CRM_NM.MaxLength = 50
        Me.CRM_NM.Name = "CRM_NM"
        Me.CRM_NM.NextFocus = ""
        Me.CRM_NM.Size = New System.Drawing.Size(10, 22)
        Me.CRM_NM.TabIndex = 172
        Me.CRM_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.CRM_NM.Visible = False
        '
        'BUSN_NO
        '
        Me.BUSN_NO.BorderColor = System.Drawing.Color.Silver
        Me.BUSN_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BUSN_NO.DefVal = Nothing
        Me.BUSN_NO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BUSN_NO.IsDataStateAware = True
        Me.BUSN_NO.Location = New System.Drawing.Point(561, 29)
        Me.BUSN_NO.Mask = "###-##-#####"
        Me.BUSN_NO.Name = "BUSN_NO"
        Me.BUSN_NO.NextFocus = "CUST_NM"
        Me.BUSN_NO.Size = New System.Drawing.Size(98, 22)
        Me.BUSN_NO.TabIndex = 6
        Me.BUSN_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.BUSN_NO.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.Localizer1.SetWordID(Me.BUSN_NO, "BUSN_NO")
        '
        'btnValidate
        '
        Me.btnValidate.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnValidate.Appearance.Options.UseFont = True
        Me.btnValidate.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnValidate.Enabled = False
        Me.btnValidate.Location = New System.Drawing.Point(665, 28)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(74, 25)
        Me.btnValidate.TabIndex = 10003
        Me.btnValidate.Text = "중복체크"
        Me.Localizer1.SetWordID(Me.btnValidate, "중복체크")
        '
        'lbl_BUSN_NO
        '
        Me.lbl_BUSN_NO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_BUSN_NO.LabelFor = Nothing
        Me.lbl_BUSN_NO.Location = New System.Drawing.Point(433, 29)
        Me.lbl_BUSN_NO.Name = "lbl_BUSN_NO"
        Me.lbl_BUSN_NO.Size = New System.Drawing.Size(124, 22)
        Me.lbl_BUSN_NO.TabIndex = 4
        Me.lbl_BUSN_NO.Text = "*사업자등록번호"
        Me.lbl_BUSN_NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_BUSN_NO, "*사업자등록번호")
        '
        'lbl_CRM_CD
        '
        Me.lbl_CRM_CD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_CRM_CD.LabelFor = Nothing
        Me.lbl_CRM_CD.Location = New System.Drawing.Point(5, 29)
        Me.lbl_CRM_CD.Name = "lbl_CRM_CD"
        Me.lbl_CRM_CD.Size = New System.Drawing.Size(117, 22)
        Me.lbl_CRM_CD.TabIndex = 117
        Me.lbl_CRM_CD.Text = "*CRM 코드"
        Me.lbl_CRM_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_CRM_CD, "*CRM 코드")
        '
        'lbl_CUST_NM
        '
        Me.lbl_CUST_NM.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_CUST_NM.LabelFor = Nothing
        Me.lbl_CUST_NM.Location = New System.Drawing.Point(5, 58)
        Me.lbl_CUST_NM.Name = "lbl_CUST_NM"
        Me.lbl_CUST_NM.Size = New System.Drawing.Size(117, 22)
        Me.lbl_CUST_NM.TabIndex = 6
        Me.lbl_CUST_NM.Text = "*상호명"
        Me.lbl_CUST_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_CUST_NM, "*상호명")
        '
        'BIZ_TYPE
        '
        Me.BIZ_TYPE.BorderColor = System.Drawing.Color.Silver
        Me.BIZ_TYPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BIZ_TYPE.DefVal = ""
        Me.BIZ_TYPE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BIZ_TYPE.IsDataStateAware = True
        Me.BIZ_TYPE.Location = New System.Drawing.Point(128, 87)
        Me.BIZ_TYPE.MaxLength = 50
        Me.BIZ_TYPE.Name = "BIZ_TYPE"
        Me.BIZ_TYPE.NextFocus = "BIZ_COND"
        Me.BIZ_TYPE.Size = New System.Drawing.Size(270, 22)
        Me.BIZ_TYPE.TabIndex = 9
        Me.BIZ_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'BIZ_COND
        '
        Me.BIZ_COND.BorderColor = System.Drawing.Color.Silver
        Me.BIZ_COND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BIZ_COND.DefVal = ""
        Me.BIZ_COND.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BIZ_COND.IsDataStateAware = True
        Me.BIZ_COND.Location = New System.Drawing.Point(561, 87)
        Me.BIZ_COND.MaxLength = 50
        Me.BIZ_COND.Name = "BIZ_COND"
        Me.BIZ_COND.NextFocus = "ZIP_CD"
        Me.BIZ_COND.Size = New System.Drawing.Size(270, 22)
        Me.BIZ_COND.TabIndex = 10
        Me.BIZ_COND.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'lbl_BIZ_COND
        '
        Me.lbl_BIZ_COND.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_BIZ_COND.LabelFor = Nothing
        Me.lbl_BIZ_COND.Location = New System.Drawing.Point(433, 87)
        Me.lbl_BIZ_COND.Name = "lbl_BIZ_COND"
        Me.lbl_BIZ_COND.Size = New System.Drawing.Size(124, 22)
        Me.lbl_BIZ_COND.TabIndex = 113
        Me.lbl_BIZ_COND.Text = "*종목"
        Me.lbl_BIZ_COND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_BIZ_COND, "*종목")
        '
        'lbl_BIZ_TYPE
        '
        Me.lbl_BIZ_TYPE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_BIZ_TYPE.LabelFor = Nothing
        Me.lbl_BIZ_TYPE.Location = New System.Drawing.Point(5, 87)
        Me.lbl_BIZ_TYPE.Name = "lbl_BIZ_TYPE"
        Me.lbl_BIZ_TYPE.Size = New System.Drawing.Size(117, 22)
        Me.lbl_BIZ_TYPE.TabIndex = 103
        Me.lbl_BIZ_TYPE.Text = "업태"
        Me.lbl_BIZ_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_BIZ_TYPE, "업태")
        '
        'CEO
        '
        Me.CEO.BorderColor = System.Drawing.Color.Silver
        Me.CEO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CEO.DefVal = ""
        Me.CEO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CEO.IsDataStateAware = True
        Me.CEO.Location = New System.Drawing.Point(561, 58)
        Me.CEO.MaxLength = 50
        Me.CEO.Name = "CEO"
        Me.CEO.NextFocus = "BIZ_TYPE"
        Me.CEO.Size = New System.Drawing.Size(270, 22)
        Me.CEO.TabIndex = 8
        Me.CEO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'CUST_NM
        '
        Me.CUST_NM.BorderColor = System.Drawing.Color.Silver
        Me.CUST_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CUST_NM.DefVal = ""
        Me.CUST_NM.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CUST_NM.IsDataStateAware = True
        Me.CUST_NM.Location = New System.Drawing.Point(128, 58)
        Me.CUST_NM.MaxLength = 100
        Me.CUST_NM.Name = "CUST_NM"
        Me.CUST_NM.NextFocus = "CEO"
        Me.CUST_NM.Size = New System.Drawing.Size(270, 22)
        Me.CUST_NM.TabIndex = 7
        Me.CUST_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'lbl_CEO
        '
        Me.lbl_CEO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_CEO.LabelFor = Nothing
        Me.lbl_CEO.Location = New System.Drawing.Point(433, 58)
        Me.lbl_CEO.Name = "lbl_CEO"
        Me.lbl_CEO.Size = New System.Drawing.Size(124, 22)
        Me.lbl_CEO.TabIndex = 111
        Me.lbl_CEO.Text = "*대표자명"
        Me.lbl_CEO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_CEO, "*대표자명")
        '
        'lbl_SUB_BD_NO
        '
        Me.lbl_SUB_BD_NO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_SUB_BD_NO.LabelFor = Nothing
        Me.lbl_SUB_BD_NO.Location = New System.Drawing.Point(433, 116)
        Me.lbl_SUB_BD_NO.Name = "lbl_SUB_BD_NO"
        Me.lbl_SUB_BD_NO.Size = New System.Drawing.Size(124, 22)
        Me.lbl_SUB_BD_NO.TabIndex = 105
        Me.lbl_SUB_BD_NO.Text = "종사업장코드"
        Me.lbl_SUB_BD_NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_SUB_BD_NO, "종사업장코드")
        '
        'CUST_ADDR
        '
        Me.CUST_ADDR.BorderColor = System.Drawing.Color.Silver
        Me.CUST_ADDR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CUST_ADDR.DefVal = ""
        Me.CUST_ADDR.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CUST_ADDR.IsDataStateAware = True
        Me.CUST_ADDR.Location = New System.Drawing.Point(128, 145)
        Me.CUST_ADDR.MaxLength = 200
        Me.CUST_ADDR.Multiline = True
        Me.CUST_ADDR.Name = "CUST_ADDR"
        Me.CUST_ADDR.NextFocus = "ERP_LINK_SERVICE"
        Me.CUST_ADDR.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.CUST_ADDR.Size = New System.Drawing.Size(703, 38)
        Me.CUST_ADDR.TabIndex = 13
        Me.CUST_ADDR.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'SUB_BD_NO
        '
        Me.SUB_BD_NO.BorderColor = System.Drawing.Color.Silver
        Me.SUB_BD_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SUB_BD_NO.DefVal = ""
        Me.SUB_BD_NO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SUB_BD_NO.IsDataStateAware = True
        Me.SUB_BD_NO.Location = New System.Drawing.Point(561, 116)
        Me.SUB_BD_NO.MaxLength = 4
        Me.SUB_BD_NO.Name = "SUB_BD_NO"
        Me.SUB_BD_NO.NextFocus = "CUST_ADDR"
        Me.SUB_BD_NO.Size = New System.Drawing.Size(98, 22)
        Me.SUB_BD_NO.TabIndex = 12
        Me.SUB_BD_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'lbl_CUST_ADDR
        '
        Me.lbl_CUST_ADDR.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_CUST_ADDR.LabelFor = Nothing
        Me.lbl_CUST_ADDR.Location = New System.Drawing.Point(5, 145)
        Me.lbl_CUST_ADDR.Name = "lbl_CUST_ADDR"
        Me.lbl_CUST_ADDR.Size = New System.Drawing.Size(117, 22)
        Me.lbl_CUST_ADDR.TabIndex = 109
        Me.lbl_CUST_ADDR.Text = "사업장주소"
        Me.lbl_CUST_ADDR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_CUST_ADDR, "사업장주소")
        '
        'lbl_ZIP_CD
        '
        Me.lbl_ZIP_CD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_ZIP_CD.LabelFor = Nothing
        Me.lbl_ZIP_CD.Location = New System.Drawing.Point(5, 116)
        Me.lbl_ZIP_CD.Name = "lbl_ZIP_CD"
        Me.lbl_ZIP_CD.Size = New System.Drawing.Size(117, 22)
        Me.lbl_ZIP_CD.TabIndex = 107
        Me.lbl_ZIP_CD.Text = "우편번호"
        Me.lbl_ZIP_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_ZIP_CD, "우편번호")
        '
        'ZIP_CD
        '
        Me.ZIP_CD.BorderColor = System.Drawing.Color.Silver
        Me.ZIP_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ZIP_CD.DefVal = ""
        Me.ZIP_CD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ZIP_CD.IsDataStateAware = True
        Me.ZIP_CD.Location = New System.Drawing.Point(128, 116)
        Me.ZIP_CD.MaxLength = 5
        Me.ZIP_CD.Name = "ZIP_CD"
        Me.ZIP_CD.NextFocus = "SUB_BD_NO"
        Me.ZIP_CD.Size = New System.Drawing.Size(98, 22)
        Me.ZIP_CD.TabIndex = 11
        Me.ZIP_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'CRM_CD
        '
        Me.CRM_CD.AlwaysSetDisplayParams = False
        Me.CRM_CD.AutoSuggestion = False
        Me.CRM_CD.BorderColor = System.Drawing.Color.Silver
        Me.CRM_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRM_CD.CodeType = "YJIT.CodeService.Customer"
        Me.CRM_CD.DataParams = "USE_YN:'Y',NameType:''"
        Me.CRM_CD.DefVal = ""
        Me.CRM_CD.DisplayParams = "Code:@CRM_CD,Name:@CRM_NM"
        Me.CRM_CD.EditPopup = ""
        Me.CRM_CD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CRM_CD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CRM_CD.IconVisible = True
        Me.CRM_CD.IsDataStateAware = True
        Me.CRM_CD.KeepIntegrity = True
        Me.CRM_CD.Location = New System.Drawing.Point(128, 29)
        Me.CRM_CD.MaxLength = 10
        Me.CRM_CD.Name = "CRM_CD"
        Me.CRM_CD.NextFocus = "BUSN_NO"
        Me.CRM_CD.SearchPopup = "CodeMaster"
        Me.CRM_CD.Size = New System.Drawing.Size(98, 22)
        Me.CRM_CD.SuppressValidateCode = False
        Me.CRM_CD.TabIndex = 5
        Me.CRM_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.CRM_CD.ValidateKeys = "KEY:@CRM_CD"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.USE_YN)
        Me.PanelControl1.Controls.Add(Me.SEARCH_KEY)
        Me.PanelControl1.Controls.Add(Me.lbl_SEARCH_KEY)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 40)
        Me.PanelControl1.MaximumSize = New System.Drawing.Size(1312, 35)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1312, 35)
        Me.PanelControl1.TabIndex = 211
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'USE_YN
        '
        Me.USE_YN.BindingPropertyName = "YesNo"
        Me.USE_YN.DefVal = False
        Me.USE_YN.IsDataStateAware = True
        Me.USE_YN.Location = New System.Drawing.Point(489, 7)
        Me.USE_YN.Name = "USE_YN"
        Me.USE_YN.NextFocus = "btnSearch"
        Me.USE_YN.Properties.AccessibleName = ""
        Me.USE_YN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.USE_YN.Properties.Appearance.Options.UseFont = True
        Me.USE_YN.Properties.Caption = "회원 계약해지 포함"
        Me.USE_YN.Size = New System.Drawing.Size(132, 19)
        Me.USE_YN.TabIndex = 2
        Me.Localizer1.SetWordID(Me.USE_YN, "")
        Me.USE_YN.YesNo = "N"
        '
        'SEARCH_KEY
        '
        Me.SEARCH_KEY.BorderColor = System.Drawing.Color.Silver
        Me.SEARCH_KEY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SEARCH_KEY.DefVal = ""
        Me.SEARCH_KEY.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SEARCH_KEY.IsDataStateAware = True
        Me.SEARCH_KEY.Location = New System.Drawing.Point(153, 5)
        Me.SEARCH_KEY.MaxLength = 50
        Me.SEARCH_KEY.Name = "SEARCH_KEY"
        Me.SEARCH_KEY.NextFocus = "USE_YN"
        Me.SEARCH_KEY.Size = New System.Drawing.Size(255, 22)
        Me.SEARCH_KEY.TabIndex = 1
        Me.SEARCH_KEY.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'lbl_SEARCH_KEY
        '
        Me.lbl_SEARCH_KEY.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_SEARCH_KEY.LabelFor = Nothing
        Me.lbl_SEARCH_KEY.Location = New System.Drawing.Point(9, 5)
        Me.lbl_SEARCH_KEY.Name = "lbl_SEARCH_KEY"
        Me.lbl_SEARCH_KEY.Size = New System.Drawing.Size(138, 22)
        Me.lbl_SEARCH_KEY.TabIndex = 2
        Me.lbl_SEARCH_KEY.Text = "검색"
        Me.lbl_SEARCH_KEY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_SEARCH_KEY, "검색")
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Location = New System.Drawing.Point(481, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(838, 856)
        Me.Panel2.TabIndex = 210
        Me.Localizer1.SetWordID(Me.Panel2, "")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1394, 69)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(4, 30)
        Me.TableLayoutPanel1.TabIndex = 209
        Me.Localizer1.SetWordID(Me.TableLayoutPanel1, "")
        '
        'Button3
        '
        Me.Button3.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.Button3.Location = New System.Drawing.Point(-57, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 24)
        Me.Button3.TabIndex = 212
        Me.Button3.Text = "Button3"
        Me.Localizer1.SetWordID(Me.Button3, "btnExpWg1")
        '
        'Button4
        '
        Me.Button4.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.Button4.Location = New System.Drawing.Point(-27, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 24)
        Me.Button4.TabIndex = 213
        Me.Button4.Text = "Button4"
        Me.Localizer1.SetWordID(Me.Button4, "btnQuickWg1")
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'AraMemberMgt
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1322, 936)
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.KeyPreview = True
        Me.Name = "AraMemberMgt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ELVIS ARA 회원 관리"
        Me.Localizer1.SetWordID(Me, "ELVIS ARA 회원 관리")
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TablePanel1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicenseNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7_CheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.USE_YN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TablePanel1 As TableLayoutPanel
    Friend WithEvents btnExpWg1 As UI.SCControls.Button
    Friend WithEvents btnQuickWg1 As UI.SCControls.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Public WithEvents WG1 As UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV7_CheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SEARCH_KEY As UI.SCControls.TextBox
    Friend WithEvents lbl_SEARCH_KEY As UI.SCControls.Label
    Friend WithEvents GV1_CRM_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BUSN_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LicenseNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents USE_YN As UI.SCControls.CheckBox
    Friend WithEvents lbl_CUST_ADDR As UI.SCControls.Label
    Friend WithEvents ZIP_CD As UI.SCControls.TextBox
    Friend WithEvents lbl_ZIP_CD As UI.SCControls.Label
    Friend WithEvents SUB_BD_NO As UI.SCControls.TextBox
    Friend WithEvents lbl_SUB_BD_NO As UI.SCControls.Label
    Friend WithEvents CUST_NM As UI.SCControls.TextBox
    Friend WithEvents lbl_BIZ_TYPE As UI.SCControls.Label
    Friend WithEvents btnValidate As UI.SCControls.Button
    Friend WithEvents BIZ_TYPE As UI.SCControls.TextBox
    Friend WithEvents lbl_CUST_NM As UI.SCControls.Label
    Friend WithEvents lbl_BUSN_NO As UI.SCControls.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_CRM_CD As UI.SCControls.Label
    Friend WithEvents BIZ_COND As UI.SCControls.TextBox
    Friend WithEvents lbl_BIZ_COND As UI.SCControls.Label
    Friend WithEvents CEO As UI.SCControls.TextBox
    Friend WithEvents lbl_CEO As UI.SCControls.Label
    Friend WithEvents CUST_ADDR As UI.SCControls.TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button3 As UI.SCControls.Button
    Friend WithEvents Button4 As UI.SCControls.Button
    Public WithEvents BUSN_NO As UI.SCControls.MaskedTextBox
    Friend WithEvents CRM_NM As UI.SCControls.TextBox
    Friend WithEvents btnNaviCRM As Button
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_ERP_LINK_SERVICE As UI.SCControls.Label
    Friend WithEvents lbl_USE_END_DT As UI.SCControls.Label
    Friend WithEvents lbl_MEMB_STATE As UI.SCControls.Label
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_BASE_AMT As UI.SCControls.Label
    Friend WithEvents lbl_PRICE As UI.SCControls.Label
    Friend WithEvents Label19 As UI.SCControls.Label
    Friend WithEvents lbl_RMK As UI.SCControls.Label
    Friend WithEvents lbl_BASE_ISSUE_CNT As UI.SCControls.Label
    Friend WithEvents lbl_USE_START_DT As UI.SCControls.Label
    Friend WithEvents RMK As UI.SCControls.TextBox
    Friend WithEvents Label4 As UI.SCControls.Label
    Friend WithEvents Label15 As UI.SCControls.Label
    Friend WithEvents btnSearch As UI.SCControls.Button
    Friend WithEvents btnNew As UI.SCControls.Button
    Friend WithEvents btnSave As UI.SCControls.Button
    Public WithEvents MEMB_STATE As UI.SCControls.ComboBox
    Friend WithEvents USE_END_DT As UI.SCControls.DateBox
    Friend WithEvents USE_START_DT As UI.SCControls.DateBox
    Public WithEvents ERP_LINK_SERVICE As UI.SCControls.ComboBox
    Public WithEvents BASE_AMT As UI.SCControls.NumericTextBox
    Public WithEvents PRICE As UI.SCControls.NumericTextBox
    Public WithEvents BASE_ISSUE_CNT As UI.SCControls.NumericTextBox
    Private WithEvents CRM_CD As UI.SCControls.CodeBox
End Class
