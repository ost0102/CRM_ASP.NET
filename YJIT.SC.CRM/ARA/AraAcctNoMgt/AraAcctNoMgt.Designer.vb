<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AraAcctNoMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AraAcctNoMgt))
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnClear = New YJIT.SC.UI.SCControls.Button()
        Me.btnQuickMenu = New YJIT.SC.UI.SCControls.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnRefresh = New YJIT.SC.UI.SCControls.Button()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_FI_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_BANK_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REMAIN_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV2_VA_ACCNT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_USE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_ISSUE_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OFFICE_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_BUNS_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_STORE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CURR_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_INV_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_FI_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_OFFICE_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_EMAIL_ADDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_START_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_END_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_GOODS_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_ETC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_INS_HM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_UPD_HM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.USE_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.ISSUE_YMD_TO = New YJIT.SC.UI.SCControls.DateBox()
        Me.btnVABankCDFile = New YJIT.SC.UI.SCControls.Button()
        Me.ISSUE_YMD_FROM = New YJIT.SC.UI.SCControls.DateBox()
        Me.lbl_ISSUE_YMD = New YJIT.SC.UI.SCControls.Label()
        Me.OFFICE_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnKLNETEmail = New YJIT.SC.UI.SCControls.Button()
        Me.lbl_CUST_NM = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_USE_YN = New YJIT.SC.UI.SCControls.Label()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnSearch, "검색(&A)")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSave, "저장(&S)")
        Me.Localizer1.SetWordID(Me.btnClear, "Clear(&C)")
        Me.Localizer1.SetWordID(Me.btnQuickMenu, "QUICK(&Q)")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.btnRefresh, "Refresh")
        Me.Localizer1.SetWordID(Me.Label1, "금융기관")
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_FI_CD, "인증 ID")
        Me.Localizer1.SetWordID(Me.GV1_BANK_NM, "거래처 명")
        Me.Localizer1.SetWordID(Me.GV1_REMAIN_NO, "잔여 수")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GV2_VA_ACCNT_NO, "가상계좌번호")
        Me.Localizer1.SetWordID(Me.GV2_USE_YN, "상태")
        Me.Localizer1.SetWordID(Me.GV2_ISSUE_YMD, "발급일자")
        Me.Localizer1.SetWordID(Me.GV2_OFFICE_NM, "거래처")
        Me.Localizer1.SetWordID(Me.GV2_BUNS_NO, "사업자번호")
        Me.Localizer1.SetWordID(Me.GV2_STORE_ID, "가맹점 ID")
        Me.Localizer1.SetWordID(Me.GV2_CURR_CD, "통화")
        Me.Localizer1.SetWordID(Me.GV2_AMOUNT, "금액")
        Me.Localizer1.SetWordID(Me.GV2_INV_KEY, "인보이스 KEY")
        Me.Localizer1.SetWordID(Me.GV2_FI_CD, "금융기관코드")
        Me.Localizer1.SetWordID(Me.GV2_OFFICE_CD, "거래처코드")
        Me.Localizer1.SetWordID(Me.GV2_EMAIL_ADDR, "이메일")
        Me.Localizer1.SetWordID(Me.GV2_TEL_NO, "전화번호")
        Me.Localizer1.SetWordID(Me.GV2_START_YMD, "유효기간(시작일자)")
        Me.Localizer1.SetWordID(Me.GV2_END_YMD, "유효기간(종료일자)")
        Me.Localizer1.SetWordID(Me.GV2_GOODS_NM, "상품명")
        Me.Localizer1.SetWordID(Me.GV2_ETC_NM, "기타참고사항")
        Me.Localizer1.SetWordID(Me.GV2_INS_USR, "입력자")
        Me.Localizer1.SetWordID(Me.GV2_INS_YMD, "입력일자")
        Me.Localizer1.SetWordID(Me.GV2_INS_HM, "입력시간")
        Me.Localizer1.SetWordID(Me.GV2_UPD_USR, "수정자")
        Me.Localizer1.SetWordID(Me.GV2_UPD_YMD, "수정일자")
        Me.Localizer1.SetWordID(Me.GV2_UPD_HM, "수정시간")
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        Me.Localizer1.SetWordID(Me.USE_YN, "미사용")
        Me.Localizer1.SetWordID(Me.Label2, "~")
        Me.Localizer1.SetWordID(Me.ISSUE_YMD_TO, "    -  -")
        Me.Localizer1.SetWordID(Me.btnVABankCDFile, "가상계좌업로드")
        Me.Localizer1.SetWordID(Me.ISSUE_YMD_FROM, "    -  -")
        Me.Localizer1.SetWordID(Me.lbl_ISSUE_YMD, "발급일자")
        Me.Localizer1.SetWordID(Me.OFFICE_NM, "")
        Me.Localizer1.SetWordID(Me.btnKLNETEmail, "KLNET 이메일 요청")
        Me.Localizer1.SetWordID(Me.lbl_CUST_NM, "발급거래처")
        Me.Localizer1.SetWordID(Me.lbl_USE_YN, "상태")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(951, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(79, 25)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "검색(&A)"
        Me.Localizer1.SetWordID(Me.btnSearch, "검색(&A)")
        '
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnClear)
        Me.palAutoButton.Controls.Add(Me.btnQuickMenu)
        Me.palAutoButton.Location = New System.Drawing.Point(12, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1298, 35)
        Me.palAutoButton.TabIndex = 219
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(1121, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 25)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "저장(&S)"
        Me.Localizer1.SetWordID(Me.btnSave, "저장(&S)")
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClear.Appearance.Options.UseFont = True
        Me.btnClear.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(1036, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 25)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "&Clear"
        Me.Localizer1.SetWordID(Me.btnClear, "Clear(&C)")
        '
        'btnQuickMenu
        '
        Me.btnQuickMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuickMenu.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnQuickMenu.Appearance.Options.UseFont = True
        Me.btnQuickMenu.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnQuickMenu.Location = New System.Drawing.Point(1206, 5)
        Me.btnQuickMenu.Name = "btnQuickMenu"
        Me.btnQuickMenu.Size = New System.Drawing.Size(79, 25)
        Me.btnQuickMenu.TabIndex = 8
        Me.btnQuickMenu.Text = "&QUICK"
        Me.Localizer1.SetWordID(Me.btnQuickMenu, "QUICK(&Q)")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PanelControl2)
        Me.Panel1.Controls.Add(Me.SplitContainerControl1)
        Me.Panel1.Controls.Add(Me.PanelControl3)
        Me.Panel1.Location = New System.Drawing.Point(3, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1316, 890)
        Me.Panel1.TabIndex = 109
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnRefresh)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(9, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(323, 57)
        Me.PanelControl2.TabIndex = 220
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnRefresh.Appearance.Options.UseFont = True
        Me.btnRefresh.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnRefresh.Location = New System.Drawing.Point(239, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(79, 25)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "&Refresh"
        Me.Localizer1.SetWordID(Me.btnRefresh, "Refresh")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "금융기관"
        Me.Localizer1.SetWordID(Me.Label1, "금융기관")
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Location = New System.Drawing.Point(9, 64)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.WG1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.WG2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1298, 790)
        Me.SplitContainerControl1.SplitterPosition = 323
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "")
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
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(323, 790)
        Me.WG1.TabIndex = 12
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_FI_CD, Me.GV1_BANK_NM, Me.GV1_REMAIN_NO})
        Me.GV1.CustomizationFormBounds = New System.Drawing.Rectangle(892, 567, 216, 185)
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.RowHeight = 10
        '
        'GV1_FI_CD
        '
        Me.GV1_FI_CD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV1_FI_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_FI_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FI_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FI_CD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV1_FI_CD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_FI_CD.AppearanceHeader.Options.UseFont = True
        Me.GV1_FI_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FI_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FI_CD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV1_FI_CD.Caption = "금융기관코드"
        Me.GV1_FI_CD.FieldName = "FI_CD"
        Me.GV1_FI_CD.Name = "GV1_FI_CD"
        Me.GV1_FI_CD.Visible = True
        Me.GV1_FI_CD.VisibleIndex = 0
        Me.GV1_FI_CD.Width = 70
        Me.Localizer1.SetWordID(Me.GV1_FI_CD, "인증 ID")
        '
        'GV1_BANK_NM
        '
        Me.GV1_BANK_NM.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV1_BANK_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_BANK_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BANK_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_BANK_NM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV1_BANK_NM.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_BANK_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_BANK_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BANK_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BANK_NM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV1_BANK_NM.Caption = "은행명"
        Me.GV1_BANK_NM.FieldName = "BANK_NM"
        Me.GV1_BANK_NM.Name = "GV1_BANK_NM"
        Me.GV1_BANK_NM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "BANK_NM", "총")})
        Me.GV1_BANK_NM.Visible = True
        Me.GV1_BANK_NM.VisibleIndex = 1
        Me.GV1_BANK_NM.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_BANK_NM, "거래처 명")
        '
        'GV1_REMAIN_NO
        '
        Me.GV1_REMAIN_NO.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV1_REMAIN_NO.AppearanceCell.Options.UseFont = True
        Me.GV1_REMAIN_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REMAIN_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_REMAIN_NO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV1_REMAIN_NO.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_REMAIN_NO.AppearanceHeader.Options.UseFont = True
        Me.GV1_REMAIN_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REMAIN_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REMAIN_NO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV1_REMAIN_NO.Caption = "잔여수"
        Me.GV1_REMAIN_NO.DisplayFormat.FormatString = "{0:###,###,###,##0}"
        Me.GV1_REMAIN_NO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GV1_REMAIN_NO.FieldName = "REMAIN_NO"
        Me.GV1_REMAIN_NO.Name = "GV1_REMAIN_NO"
        Me.GV1_REMAIN_NO.OptionsColumn.AllowEdit = False
        Me.GV1_REMAIN_NO.OptionsColumn.ReadOnly = True
        Me.GV1_REMAIN_NO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "REMAIN_NO", "{0:###,###,###,##0}")})
        Me.GV1_REMAIN_NO.Visible = True
        Me.GV1_REMAIN_NO.VisibleIndex = 2
        Me.GV1_REMAIN_NO.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_REMAIN_NO, "잔여 수")
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.DeleteRowConfirmation = True
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(0, 0)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(970, 790)
        Me.WG2.TabIndex = 13
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV2_VA_ACCNT_NO, Me.GV2_USE_YN, Me.GV2_ISSUE_YMD, Me.GV2_OFFICE_NM, Me.GV2_BUNS_NO, Me.GV2_STORE_ID, Me.GV2_CURR_CD, Me.GV2_AMOUNT, Me.GV2_INV_KEY, Me.GV2_FI_CD, Me.GV2_OFFICE_CD, Me.GV2_EMAIL_ADDR, Me.GV2_TEL_NO, Me.GV2_START_YMD, Me.GV2_END_YMD, Me.GV2_GOODS_NM, Me.GV2_ETC_NM, Me.GV2_INS_USR, Me.GV2_INS_YMD, Me.GV2_INS_HM, Me.GV2_UPD_USR, Me.GV2_UPD_YMD, Me.GV2_UPD_HM})
        Me.GV2.CustomizationFormBounds = New System.Drawing.Rectangle(892, 567, 216, 185)
        Me.GV2.GridControl = Me.WG2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.AutoExpandAllGroups = True
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV2.RowHeight = 10
        '
        'GV2_VA_ACCNT_NO
        '
        Me.GV2_VA_ACCNT_NO.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_VA_ACCNT_NO.AppearanceCell.Options.UseFont = True
        Me.GV2_VA_ACCNT_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_VA_ACCNT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_VA_ACCNT_NO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_VA_ACCNT_NO.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_VA_ACCNT_NO.AppearanceHeader.Options.UseFont = True
        Me.GV2_VA_ACCNT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_VA_ACCNT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_VA_ACCNT_NO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_VA_ACCNT_NO.Caption = "가상계좌번호"
        Me.GV2_VA_ACCNT_NO.FieldName = "VA_ACCNT_NO"
        Me.GV2_VA_ACCNT_NO.Name = "GV2_VA_ACCNT_NO"
        Me.GV2_VA_ACCNT_NO.OptionsColumn.AllowEdit = False
        Me.GV2_VA_ACCNT_NO.OptionsColumn.ReadOnly = True
        Me.GV2_VA_ACCNT_NO.Visible = True
        Me.GV2_VA_ACCNT_NO.VisibleIndex = 0
        Me.GV2_VA_ACCNT_NO.Width = 110
        Me.Localizer1.SetWordID(Me.GV2_VA_ACCNT_NO, "가상계좌번호")
        '
        'GV2_USE_YN
        '
        Me.GV2_USE_YN.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_USE_YN.AppearanceCell.Options.UseFont = True
        Me.GV2_USE_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_USE_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_USE_YN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_USE_YN.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_USE_YN.AppearanceHeader.Options.UseFont = True
        Me.GV2_USE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_USE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_USE_YN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_USE_YN.Caption = "상태"
        Me.GV2_USE_YN.FieldName = "USE_YN"
        Me.GV2_USE_YN.Name = "GV2_USE_YN"
        Me.GV2_USE_YN.OptionsColumn.AllowEdit = False
        Me.GV2_USE_YN.OptionsColumn.ReadOnly = True
        Me.GV2_USE_YN.Visible = True
        Me.GV2_USE_YN.VisibleIndex = 1
        Me.GV2_USE_YN.Width = 70
        Me.Localizer1.SetWordID(Me.GV2_USE_YN, "상태")
        '
        'GV2_ISSUE_YMD
        '
        Me.GV2_ISSUE_YMD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_ISSUE_YMD.AppearanceCell.Options.UseFont = True
        Me.GV2_ISSUE_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_ISSUE_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_ISSUE_YMD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_ISSUE_YMD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_ISSUE_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV2_ISSUE_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_ISSUE_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_ISSUE_YMD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_ISSUE_YMD.Caption = "발급일자"
        Me.GV2_ISSUE_YMD.FieldName = "ISSUE_YMD"
        Me.GV2_ISSUE_YMD.Name = "GV2_ISSUE_YMD"
        Me.GV2_ISSUE_YMD.OptionsColumn.AllowEdit = False
        Me.GV2_ISSUE_YMD.OptionsColumn.ReadOnly = True
        Me.GV2_ISSUE_YMD.Visible = True
        Me.GV2_ISSUE_YMD.VisibleIndex = 2
        Me.GV2_ISSUE_YMD.Width = 90
        Me.Localizer1.SetWordID(Me.GV2_ISSUE_YMD, "발급일자")
        '
        'GV2_OFFICE_NM
        '
        Me.GV2_OFFICE_NM.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_OFFICE_NM.AppearanceCell.Options.UseFont = True
        Me.GV2_OFFICE_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_OFFICE_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_OFFICE_NM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_OFFICE_NM.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_OFFICE_NM.AppearanceHeader.Options.UseFont = True
        Me.GV2_OFFICE_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_OFFICE_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_OFFICE_NM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_OFFICE_NM.Caption = "거래처"
        Me.GV2_OFFICE_NM.FieldName = "OFFICE_NM"
        Me.GV2_OFFICE_NM.Name = "GV2_OFFICE_NM"
        Me.GV2_OFFICE_NM.OptionsColumn.AllowEdit = False
        Me.GV2_OFFICE_NM.OptionsColumn.ReadOnly = True
        Me.GV2_OFFICE_NM.Visible = True
        Me.GV2_OFFICE_NM.VisibleIndex = 3
        Me.GV2_OFFICE_NM.Width = 180
        Me.Localizer1.SetWordID(Me.GV2_OFFICE_NM, "거래처")
        '
        'GV2_BUNS_NO
        '
        Me.GV2_BUNS_NO.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_BUNS_NO.AppearanceCell.Options.UseFont = True
        Me.GV2_BUNS_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_BUNS_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_BUNS_NO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_BUNS_NO.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_BUNS_NO.AppearanceHeader.Options.UseFont = True
        Me.GV2_BUNS_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_BUNS_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_BUNS_NO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_BUNS_NO.Caption = "사업자번호"
        Me.GV2_BUNS_NO.FieldName = "BUNS_NO"
        Me.GV2_BUNS_NO.Name = "GV2_BUNS_NO"
        Me.GV2_BUNS_NO.OptionsColumn.AllowEdit = False
        Me.GV2_BUNS_NO.OptionsColumn.ReadOnly = True
        Me.GV2_BUNS_NO.Visible = True
        Me.GV2_BUNS_NO.VisibleIndex = 4
        Me.GV2_BUNS_NO.Width = 110
        Me.Localizer1.SetWordID(Me.GV2_BUNS_NO, "사업자번호")
        '
        'GV2_STORE_ID
        '
        Me.GV2_STORE_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_STORE_ID.AppearanceCell.Options.UseFont = True
        Me.GV2_STORE_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_STORE_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_STORE_ID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_STORE_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_STORE_ID.AppearanceHeader.Options.UseFont = True
        Me.GV2_STORE_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_STORE_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_STORE_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_STORE_ID.Caption = "가맹점 ID"
        Me.GV2_STORE_ID.FieldName = "STORE_ID"
        Me.GV2_STORE_ID.Name = "GV2_STORE_ID"
        Me.GV2_STORE_ID.OptionsColumn.AllowEdit = False
        Me.GV2_STORE_ID.OptionsColumn.ReadOnly = True
        Me.GV2_STORE_ID.Visible = True
        Me.GV2_STORE_ID.VisibleIndex = 5
        Me.GV2_STORE_ID.Width = 110
        Me.Localizer1.SetWordID(Me.GV2_STORE_ID, "가맹점 ID")
        '
        'GV2_CURR_CD
        '
        Me.GV2_CURR_CD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_CURR_CD.AppearanceCell.Options.UseFont = True
        Me.GV2_CURR_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_CURR_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_CURR_CD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_CURR_CD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_CURR_CD.AppearanceHeader.Options.UseFont = True
        Me.GV2_CURR_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CURR_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CURR_CD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_CURR_CD.Caption = "통화"
        Me.GV2_CURR_CD.FieldName = "CURR_CD"
        Me.GV2_CURR_CD.Name = "GV2_CURR_CD"
        Me.GV2_CURR_CD.OptionsColumn.AllowEdit = False
        Me.GV2_CURR_CD.OptionsColumn.ReadOnly = True
        Me.GV2_CURR_CD.Visible = True
        Me.GV2_CURR_CD.VisibleIndex = 6
        Me.GV2_CURR_CD.Width = 70
        Me.Localizer1.SetWordID(Me.GV2_CURR_CD, "통화")
        '
        'GV2_AMOUNT
        '
        Me.GV2_AMOUNT.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_AMOUNT.AppearanceCell.Options.UseFont = True
        Me.GV2_AMOUNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_AMOUNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_AMOUNT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_AMOUNT.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_AMOUNT.AppearanceHeader.Options.UseFont = True
        Me.GV2_AMOUNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_AMOUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_AMOUNT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_AMOUNT.Caption = "금액"
        Me.GV2_AMOUNT.DisplayFormat.FormatString = "{0:###,###,###,##0}"
        Me.GV2_AMOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GV2_AMOUNT.FieldName = "AMOUNT"
        Me.GV2_AMOUNT.Name = "GV2_AMOUNT"
        Me.GV2_AMOUNT.OptionsColumn.AllowEdit = False
        Me.GV2_AMOUNT.OptionsColumn.ReadOnly = True
        Me.GV2_AMOUNT.Visible = True
        Me.GV2_AMOUNT.VisibleIndex = 7
        Me.GV2_AMOUNT.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_AMOUNT, "금액")
        '
        'GV2_INV_KEY
        '
        Me.GV2_INV_KEY.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_INV_KEY.AppearanceCell.Options.UseFont = True
        Me.GV2_INV_KEY.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_INV_KEY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INV_KEY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_INV_KEY.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_INV_KEY.AppearanceHeader.Options.UseFont = True
        Me.GV2_INV_KEY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_INV_KEY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INV_KEY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_INV_KEY.Caption = "인보이스 KEY"
        Me.GV2_INV_KEY.FieldName = "INV_KEY"
        Me.GV2_INV_KEY.Name = "GV2_INV_KEY"
        Me.GV2_INV_KEY.OptionsColumn.AllowEdit = False
        Me.GV2_INV_KEY.OptionsColumn.ReadOnly = True
        Me.GV2_INV_KEY.Visible = True
        Me.GV2_INV_KEY.VisibleIndex = 8
        Me.GV2_INV_KEY.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_INV_KEY, "인보이스 KEY")
        '
        'GV2_FI_CD
        '
        Me.GV2_FI_CD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_FI_CD.AppearanceCell.Options.UseFont = True
        Me.GV2_FI_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_FI_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_FI_CD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_FI_CD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_FI_CD.AppearanceHeader.Options.UseFont = True
        Me.GV2_FI_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_FI_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_FI_CD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_FI_CD.Caption = "금융기관코드"
        Me.GV2_FI_CD.FieldName = "FI_CD"
        Me.GV2_FI_CD.Name = "GV2_FI_CD"
        Me.GV2_FI_CD.OptionsColumn.AllowEdit = False
        Me.GV2_FI_CD.OptionsColumn.ReadOnly = True
        Me.GV2_FI_CD.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_FI_CD, "금융기관코드")
        '
        'GV2_OFFICE_CD
        '
        Me.GV2_OFFICE_CD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_OFFICE_CD.AppearanceCell.Options.UseFont = True
        Me.GV2_OFFICE_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_OFFICE_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_OFFICE_CD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_OFFICE_CD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_OFFICE_CD.AppearanceHeader.Options.UseFont = True
        Me.GV2_OFFICE_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_OFFICE_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_OFFICE_CD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_OFFICE_CD.Caption = "거래처코드"
        Me.GV2_OFFICE_CD.FieldName = "OFFICE_CD"
        Me.GV2_OFFICE_CD.Name = "GV2_OFFICE_CD"
        Me.GV2_OFFICE_CD.OptionsColumn.AllowEdit = False
        Me.GV2_OFFICE_CD.OptionsColumn.ReadOnly = True
        Me.GV2_OFFICE_CD.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_OFFICE_CD, "거래처코드")
        '
        'GV2_EMAIL_ADDR
        '
        Me.GV2_EMAIL_ADDR.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_EMAIL_ADDR.AppearanceCell.Options.UseFont = True
        Me.GV2_EMAIL_ADDR.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_EMAIL_ADDR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_EMAIL_ADDR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_EMAIL_ADDR.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_EMAIL_ADDR.AppearanceHeader.Options.UseFont = True
        Me.GV2_EMAIL_ADDR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_EMAIL_ADDR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_EMAIL_ADDR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_EMAIL_ADDR.Caption = "이메일"
        Me.GV2_EMAIL_ADDR.FieldName = "EMAIL_ADDR"
        Me.GV2_EMAIL_ADDR.Name = "GV2_EMAIL_ADDR"
        Me.GV2_EMAIL_ADDR.OptionsColumn.AllowEdit = False
        Me.GV2_EMAIL_ADDR.OptionsColumn.ReadOnly = True
        Me.GV2_EMAIL_ADDR.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_EMAIL_ADDR, "이메일")
        '
        'GV2_TEL_NO
        '
        Me.GV2_TEL_NO.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_TEL_NO.AppearanceCell.Options.UseFont = True
        Me.GV2_TEL_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_TEL_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_TEL_NO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_TEL_NO.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_TEL_NO.AppearanceHeader.Options.UseFont = True
        Me.GV2_TEL_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_TEL_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_TEL_NO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_TEL_NO.Caption = "전화번호"
        Me.GV2_TEL_NO.FieldName = "TEL_NO"
        Me.GV2_TEL_NO.Name = "GV2_TEL_NO"
        Me.GV2_TEL_NO.OptionsColumn.AllowEdit = False
        Me.GV2_TEL_NO.OptionsColumn.ReadOnly = True
        Me.GV2_TEL_NO.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_TEL_NO, "전화번호")
        '
        'GV2_START_YMD
        '
        Me.GV2_START_YMD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_START_YMD.AppearanceCell.Options.UseFont = True
        Me.GV2_START_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_START_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_START_YMD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_START_YMD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_START_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV2_START_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_START_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_START_YMD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_START_YMD.Caption = "유효기간(시작일자)"
        Me.GV2_START_YMD.FieldName = "START_YMD"
        Me.GV2_START_YMD.Name = "GV2_START_YMD"
        Me.GV2_START_YMD.OptionsColumn.AllowEdit = False
        Me.GV2_START_YMD.OptionsColumn.ReadOnly = True
        Me.GV2_START_YMD.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_START_YMD, "유효기간(시작일자)")
        '
        'GV2_END_YMD
        '
        Me.GV2_END_YMD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_END_YMD.AppearanceCell.Options.UseFont = True
        Me.GV2_END_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_END_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_END_YMD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_END_YMD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_END_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV2_END_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_END_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_END_YMD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_END_YMD.Caption = "유효기간(종료일자)"
        Me.GV2_END_YMD.FieldName = "END_YMD"
        Me.GV2_END_YMD.Name = "GV2_END_YMD"
        Me.GV2_END_YMD.OptionsColumn.AllowEdit = False
        Me.GV2_END_YMD.OptionsColumn.ReadOnly = True
        Me.GV2_END_YMD.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_END_YMD, "유효기간(종료일자)")
        '
        'GV2_GOODS_NM
        '
        Me.GV2_GOODS_NM.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_GOODS_NM.AppearanceCell.Options.UseFont = True
        Me.GV2_GOODS_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_GOODS_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_GOODS_NM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_GOODS_NM.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_GOODS_NM.AppearanceHeader.Options.UseFont = True
        Me.GV2_GOODS_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_GOODS_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_GOODS_NM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_GOODS_NM.Caption = "상품명"
        Me.GV2_GOODS_NM.FieldName = "GOODS_NM"
        Me.GV2_GOODS_NM.Name = "GV2_GOODS_NM"
        Me.GV2_GOODS_NM.OptionsColumn.AllowEdit = False
        Me.GV2_GOODS_NM.OptionsColumn.ReadOnly = True
        Me.GV2_GOODS_NM.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_GOODS_NM, "상품명")
        '
        'GV2_ETC_NM
        '
        Me.GV2_ETC_NM.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_ETC_NM.AppearanceCell.Options.UseFont = True
        Me.GV2_ETC_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_ETC_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_ETC_NM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_ETC_NM.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_ETC_NM.AppearanceHeader.Options.UseFont = True
        Me.GV2_ETC_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_ETC_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_ETC_NM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_ETC_NM.Caption = "기타참고사항"
        Me.GV2_ETC_NM.FieldName = "ETC_NM"
        Me.GV2_ETC_NM.Name = "GV2_ETC_NM"
        Me.GV2_ETC_NM.OptionsColumn.AllowEdit = False
        Me.GV2_ETC_NM.OptionsColumn.ReadOnly = True
        Me.GV2_ETC_NM.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_ETC_NM, "기타참고사항")
        '
        'GV2_INS_USR
        '
        Me.GV2_INS_USR.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_INS_USR.AppearanceCell.Options.UseFont = True
        Me.GV2_INS_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_INS_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INS_USR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_INS_USR.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_INS_USR.AppearanceHeader.Options.UseFont = True
        Me.GV2_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INS_USR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_INS_USR.Caption = "입력자"
        Me.GV2_INS_USR.FieldName = "INS_USR"
        Me.GV2_INS_USR.Name = "GV2_INS_USR"
        Me.GV2_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV2_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV2_INS_USR.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_INS_USR, "입력자")
        '
        'GV2_INS_YMD
        '
        Me.GV2_INS_YMD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_INS_YMD.AppearanceCell.Options.UseFont = True
        Me.GV2_INS_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_INS_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INS_YMD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_INS_YMD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_INS_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV2_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INS_YMD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_INS_YMD.Caption = "입력일자"
        Me.GV2_INS_YMD.FieldName = "INS_YMD"
        Me.GV2_INS_YMD.Name = "GV2_INS_YMD"
        Me.GV2_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV2_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV2_INS_YMD.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_INS_YMD, "입력일자")
        '
        'GV2_INS_HM
        '
        Me.GV2_INS_HM.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_INS_HM.AppearanceCell.Options.UseFont = True
        Me.GV2_INS_HM.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_INS_HM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INS_HM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_INS_HM.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_INS_HM.AppearanceHeader.Options.UseFont = True
        Me.GV2_INS_HM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_INS_HM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INS_HM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_INS_HM.Caption = "입력시간"
        Me.GV2_INS_HM.FieldName = "INS_HM"
        Me.GV2_INS_HM.Name = "GV2_INS_HM"
        Me.GV2_INS_HM.OptionsColumn.AllowEdit = False
        Me.GV2_INS_HM.OptionsColumn.ReadOnly = True
        Me.GV2_INS_HM.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_INS_HM, "입력시간")
        '
        'GV2_UPD_USR
        '
        Me.GV2_UPD_USR.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_UPD_USR.AppearanceCell.Options.UseFont = True
        Me.GV2_UPD_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_UPD_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_UPD_USR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_UPD_USR.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_UPD_USR.AppearanceHeader.Options.UseFont = True
        Me.GV2_UPD_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_UPD_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_UPD_USR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_UPD_USR.Caption = "수정자"
        Me.GV2_UPD_USR.FieldName = "UPD_USR"
        Me.GV2_UPD_USR.Name = "GV2_UPD_USR"
        Me.GV2_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV2_UPD_USR.OptionsColumn.ReadOnly = True
        Me.GV2_UPD_USR.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_UPD_USR, "수정자")
        '
        'GV2_UPD_YMD
        '
        Me.GV2_UPD_YMD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_UPD_YMD.AppearanceCell.Options.UseFont = True
        Me.GV2_UPD_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_UPD_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_UPD_YMD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_UPD_YMD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_UPD_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV2_UPD_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_UPD_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_UPD_YMD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_UPD_YMD.Caption = "수정일자"
        Me.GV2_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV2_UPD_YMD.Name = "GV2_UPD_YMD"
        Me.GV2_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV2_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.GV2_UPD_YMD.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_UPD_YMD, "수정일자")
        '
        'GV2_UPD_HM
        '
        Me.GV2_UPD_HM.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_UPD_HM.AppearanceCell.Options.UseFont = True
        Me.GV2_UPD_HM.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_UPD_HM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_UPD_HM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_UPD_HM.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV2_UPD_HM.AppearanceHeader.Options.UseFont = True
        Me.GV2_UPD_HM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_UPD_HM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_UPD_HM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV2_UPD_HM.Caption = "수정시간"
        Me.GV2_UPD_HM.FieldName = "UPD_HM"
        Me.GV2_UPD_HM.Name = "GV2_UPD_HM"
        Me.GV2_UPD_HM.OptionsColumn.AllowEdit = False
        Me.GV2_UPD_HM.OptionsColumn.ReadOnly = True
        Me.GV2_UPD_HM.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_UPD_HM, "수정시간")
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.USE_YN)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.ISSUE_YMD_TO)
        Me.PanelControl3.Controls.Add(Me.btnVABankCDFile)
        Me.PanelControl3.Controls.Add(Me.ISSUE_YMD_FROM)
        Me.PanelControl3.Controls.Add(Me.lbl_ISSUE_YMD)
        Me.PanelControl3.Controls.Add(Me.OFFICE_NM)
        Me.PanelControl3.Controls.Add(Me.btnKLNETEmail)
        Me.PanelControl3.Controls.Add(Me.lbl_CUST_NM)
        Me.PanelControl3.Controls.Add(Me.lbl_USE_YN)
        Me.PanelControl3.Location = New System.Drawing.Point(337, 3)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(970, 57)
        Me.PanelControl3.TabIndex = 221
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        '
        'USE_YN
        '
        Me.USE_YN.CodeType = ""
        Me.USE_YN.ColumnWidths = ""
        Me.USE_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.USE_YN.DataParams = ""
        Me.USE_YN.DefVal = "N"
        Me.USE_YN.DisplayMember = "NAME"
        Me.USE_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.USE_YN.FormattingEnabled = True
        Me.USE_YN.IsDataStateAware = True
        Me.USE_YN.ItemDelimiter = ","
        Me.USE_YN.ItemTextList = "사용,미사용"
        Me.USE_YN.ItemValueList = "Y,N"
        Me.USE_YN.KeepIntegrity = True
        Me.USE_YN.Location = New System.Drawing.Point(81, 4)
        Me.USE_YN.Name = "USE_YN"
        Me.USE_YN.NextFocus = "ISSUE_YMD_FROM"
        Me.USE_YN.NullText = "--Select--"
        Me.USE_YN.SearchKeys = ""
        Me.USE_YN.Size = New System.Drawing.Size(100, 22)
        Me.USE_YN.TabIndex = 1
        Me.USE_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.USE_YN.ValueMember = "CODE"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(184, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 22)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "~"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "")
        '
        'ISSUE_YMD_TO
        '
        Me.ISSUE_YMD_TO.BorderColor = System.Drawing.Color.Empty
        Me.ISSUE_YMD_TO.DefVal = ""
        Me.ISSUE_YMD_TO.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ISSUE_YMD_TO.IconVisible = True
        Me.ISSUE_YMD_TO.IsDataStateAware = True
        Me.ISSUE_YMD_TO.Location = New System.Drawing.Point(207, 29)
        Me.ISSUE_YMD_TO.Mask = "0000-00-00"
        Me.ISSUE_YMD_TO.Name = "ISSUE_YMD_TO"
        Me.ISSUE_YMD_TO.NextFocus = "CUST_NM"
        Me.ISSUE_YMD_TO.Size = New System.Drawing.Size(100, 23)
        Me.ISSUE_YMD_TO.TabIndex = 3
        Me.Localizer1.SetWordID(Me.ISSUE_YMD_TO, "")
        '
        'btnVABankCDFile
        '
        Me.btnVABankCDFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVABankCDFile.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnVABankCDFile.Appearance.Options.UseFont = True
        Me.btnVABankCDFile.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnVABankCDFile.Location = New System.Drawing.Point(865, 5)
        Me.btnVABankCDFile.Name = "btnVABankCDFile"
        Me.btnVABankCDFile.Size = New System.Drawing.Size(92, 25)
        Me.btnVABankCDFile.TabIndex = 11
        Me.btnVABankCDFile.Text = "가상계좌업로드"
        Me.Localizer1.SetWordID(Me.btnVABankCDFile, "가상계좌업로드")
        '
        'ISSUE_YMD_FROM
        '
        Me.ISSUE_YMD_FROM.BorderColor = System.Drawing.Color.Empty
        Me.ISSUE_YMD_FROM.DefVal = ""
        Me.ISSUE_YMD_FROM.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ISSUE_YMD_FROM.IconVisible = True
        Me.ISSUE_YMD_FROM.IsDataStateAware = True
        Me.ISSUE_YMD_FROM.Location = New System.Drawing.Point(81, 29)
        Me.ISSUE_YMD_FROM.Mask = "0000-00-00"
        Me.ISSUE_YMD_FROM.Name = "ISSUE_YMD_FROM"
        Me.ISSUE_YMD_FROM.NextFocus = "ISSUE_YMD_TO"
        Me.ISSUE_YMD_FROM.Size = New System.Drawing.Size(100, 23)
        Me.ISSUE_YMD_FROM.TabIndex = 2
        Me.Localizer1.SetWordID(Me.ISSUE_YMD_FROM, "")
        '
        'lbl_ISSUE_YMD
        '
        Me.lbl_ISSUE_YMD.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_ISSUE_YMD.LabelFor = Nothing
        Me.lbl_ISSUE_YMD.Location = New System.Drawing.Point(11, 29)
        Me.lbl_ISSUE_YMD.Name = "lbl_ISSUE_YMD"
        Me.lbl_ISSUE_YMD.Size = New System.Drawing.Size(64, 22)
        Me.lbl_ISSUE_YMD.TabIndex = 4
        Me.lbl_ISSUE_YMD.Text = "발급일자"
        Me.lbl_ISSUE_YMD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_ISSUE_YMD, "발급일자")
        '
        'OFFICE_NM
        '
        Me.OFFICE_NM.BackColor = System.Drawing.SystemColors.Window
        Me.OFFICE_NM.BorderColor = System.Drawing.Color.Silver
        Me.OFFICE_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OFFICE_NM.DefVal = ""
        Me.OFFICE_NM.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.OFFICE_NM.IsDataStateAware = True
        Me.OFFICE_NM.Location = New System.Drawing.Point(420, 29)
        Me.OFFICE_NM.MaxLength = 30
        Me.OFFICE_NM.Name = "OFFICE_NM"
        Me.OFFICE_NM.NextFocus = "btnSearch"
        Me.OFFICE_NM.Size = New System.Drawing.Size(250, 23)
        Me.OFFICE_NM.TabIndex = 4
        Me.OFFICE_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'btnKLNETEmail
        '
        Me.btnKLNETEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKLNETEmail.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnKLNETEmail.Appearance.Options.UseFont = True
        Me.btnKLNETEmail.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnKLNETEmail.Location = New System.Drawing.Point(740, 5)
        Me.btnKLNETEmail.Name = "btnKLNETEmail"
        Me.btnKLNETEmail.Size = New System.Drawing.Size(119, 25)
        Me.btnKLNETEmail.TabIndex = 10
        Me.btnKLNETEmail.Text = "KLNET 이메일 요청"
        Me.btnKLNETEmail.Visible = False
        Me.Localizer1.SetWordID(Me.btnKLNETEmail, "KLNET 이메일 요청")
        '
        'lbl_CUST_NM
        '
        Me.lbl_CUST_NM.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_CUST_NM.LabelFor = Nothing
        Me.lbl_CUST_NM.Location = New System.Drawing.Point(347, 29)
        Me.lbl_CUST_NM.Name = "lbl_CUST_NM"
        Me.lbl_CUST_NM.Size = New System.Drawing.Size(69, 22)
        Me.lbl_CUST_NM.TabIndex = 2
        Me.lbl_CUST_NM.Text = "발급거래처"
        Me.lbl_CUST_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_CUST_NM, "발급거래처")
        '
        'lbl_USE_YN
        '
        Me.lbl_USE_YN.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbl_USE_YN.LabelFor = Nothing
        Me.lbl_USE_YN.Location = New System.Drawing.Point(11, 4)
        Me.lbl_USE_YN.Name = "lbl_USE_YN"
        Me.lbl_USE_YN.Size = New System.Drawing.Size(64, 22)
        Me.lbl_USE_YN.TabIndex = 213
        Me.lbl_USE_YN.Text = "상태"
        Me.lbl_USE_YN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_USE_YN, "상태")
        '
        'AraAcctNoMgt
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1322, 936)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.KeyPreview = True
        Me.Name = "AraAcctNoMgt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ELVIS ARA 가상계좌번호 관리"
        Me.Localizer1.SetWordID(Me, "ELVIS ARA 가상계좌번호 관리")
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnClear As UI.SCControls.Button
    Friend WithEvents btnSave As UI.SCControls.Button
    Friend WithEvents btnQuickMenu As UI.SCControls.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Public WithEvents WG1 As UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_FI_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BANK_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REMAIN_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ISSUE_YMD_TO As UI.SCControls.DateBox
    Friend WithEvents ISSUE_YMD_FROM As UI.SCControls.DateBox
    Friend WithEvents lbl_ISSUE_YMD As UI.SCControls.Label
    Friend WithEvents OFFICE_NM As UI.SCControls.TextBox
    Friend WithEvents lbl_CUST_NM As UI.SCControls.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_USE_YN As UI.SCControls.Label
    Friend WithEvents btnKLNETEmail As UI.SCControls.Button
    Friend WithEvents btnVABankCDFile As UI.SCControls.Button
    Public WithEvents WG2 As UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV2_VA_ACCNT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_USE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_ISSUE_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OFFICE_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_BUNS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_STORE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_CURR_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_INV_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As UI.SCControls.Label
    Friend WithEvents btnRefresh As UI.SCControls.Button
    Friend WithEvents GV2_FI_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_OFFICE_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_EMAIL_ADDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_START_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_END_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_GOODS_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_ETC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_INS_HM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_UPD_HM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As UI.SCControls.Label
    Friend WithEvents USE_YN As UI.SCControls.ComboBox
End Class
