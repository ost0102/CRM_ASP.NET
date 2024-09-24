<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrmProjectMgt
    Inherits YJIT.SC.UI.SCView

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmProjectMgt))
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.lbl_S_DEPT_CD = New YJIT.SC.UI.SCControls.Label()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.xtpReport = New DevExpress.XtraTab.XtraTabPage()
        Me.splitRight = New DevExpress.XtraEditors.SplitContainerControl()
        Me.WG5 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV5_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV5_VALUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG6 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV6_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV6_VALUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.splitLeft = New DevExpress.XtraEditors.SplitContainerControl()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WG2_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG2_USR_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG3 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV3_CTRT_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_CTRT_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG4 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV4_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_CTRT_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_ORD_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_CTRT_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_MATN_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_COST_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_PROFIT_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_PROFIT_RATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_BIZ_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_ITEM_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpText_100 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_ORD_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpNumeric_N0 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_CTRT_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MATN_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COST_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROFIT_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CMPT_RATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CTRT_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpCTRT_YMD = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_BIZ_COND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TAX_START_MONTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpTAX_START_MONTH = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_CTRT_RCV_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SETUP_TAX_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MONTH_TAX_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_OUTSTAND_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_JOIN_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_JOIN_ROUTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpMemo_400 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GV1_PIC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpText_50 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_PIC_MOBILE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpText_30 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_PIC_EMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpText_64 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtpInput = New DevExpress.XtraTab.XtraTabPage()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEPT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_BIZ_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROD_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_IDC_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.MODIFY_YN = New YJIT.SC.UI.SCControls.TextBox()
        Me.S_DEPT_CD = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_DATE_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_TO_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.S_FM_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.S_TO_YM = New System.Windows.Forms.MaskedTextBox()
        Me.S_FM_YM = New System.Windows.Forms.MaskedTextBox()
        Me.S_USR_ID_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_USR_ID = New YJIT.SC.UI.SCControls.CodeBox()
        Me.S_CUST_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.S_PROC_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.lbl_S_PROC_TYPE = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_S_USR_ID = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_S_CUST_NM = New YJIT.SC.UI.SCControls.Label()
        Me.xtcMAIN = New DevExpress.XtraTab.XtraTabControl()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.xtpReport.SuspendLayout()
        CType(Me.splitRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitRight.SuspendLayout()
        CType(Me.WG5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitLeft.SuspendLayout()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpText_100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpNumeric_N0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCTRT_YMD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpTAX_START_MONTH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMemo_400, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpText_50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpText_30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpText_64, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpInput.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.xtcMAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcMAIN.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1042, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 25)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "조회(&A)"
        Me.Localizer1.SetWordID(Me.btnSearch, "조회(&A)")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(1122, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "저장(&S)"
        Me.Localizer1.SetWordID(Me.btnSave, "저장(&S)")
        '
        'lbl_S_DEPT_CD
        '
        Me.lbl_S_DEPT_CD.AutoSize = True
        Me.lbl_S_DEPT_CD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_S_DEPT_CD.LabelFor = Nothing
        Me.lbl_S_DEPT_CD.Location = New System.Drawing.Point(328, 9)
        Me.lbl_S_DEPT_CD.Name = "lbl_S_DEPT_CD"
        Me.lbl_S_DEPT_CD.Size = New System.Drawing.Size(31, 15)
        Me.lbl_S_DEPT_CD.TabIndex = 277
        Me.lbl_S_DEPT_CD.Text = "부서"
        Me.lbl_S_DEPT_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_DEPT_CD, "부서")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(191, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 14)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "~"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Localizer1.SetWordID(Me.Label2, "~")
        '
        'xtpReport
        '
        Me.xtpReport.Controls.Add(Me.splitRight)
        Me.xtpReport.Controls.Add(Me.splitLeft)
        Me.xtpReport.Controls.Add(Me.WG4)
        Me.xtpReport.Name = "xtpReport"
        Me.xtpReport.Size = New System.Drawing.Size(1197, 629)
        Me.xtpReport.TabPageWidth = 110
        Me.xtpReport.Text = "영업진행 집계현황"
        Me.Localizer1.SetWordID(Me.xtpReport, "영업진행 집계현황")
        '
        'splitRight
        '
        Me.splitRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitRight.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.splitRight.Horizontal = False
        Me.splitRight.Location = New System.Drawing.Point(1001, 3)
        Me.splitRight.Name = "splitRight"
        Me.splitRight.Panel1.Controls.Add(Me.WG5)
        Me.splitRight.Panel1.Text = "Panel1"
        Me.splitRight.Panel2.Controls.Add(Me.WG6)
        Me.splitRight.Panel2.Text = "Panel2"
        Me.splitRight.Size = New System.Drawing.Size(193, 627)
        Me.splitRight.SplitterPosition = 312
        Me.splitRight.TabIndex = 319
        Me.splitRight.Text = "SplitContainerControl2"
        Me.Localizer1.SetWordID(Me.splitRight, "SplitContainerControl2")
        '
        'WG5
        '
        Me.WG5.AllowClientBinding = True
        Me.WG5.DeleteRowConfirmation = True
        Me.WG5.DisplayCurrentRow = False
        Me.WG5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG5.IsDataStateAware = True
        Me.WG5.Location = New System.Drawing.Point(0, 0)
        Me.WG5.MainView = Me.GV5
        Me.WG5.Name = "WG5"
        Me.WG5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG5.SaveLayout = False
        Me.WG5.Size = New System.Drawing.Size(193, 312)
        Me.WG5.TabIndex = 317
        Me.WG5.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV5})
        '
        'GV5
        '
        Me.GV5.Appearance.ViewCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV5.Appearance.ViewCaption.Options.UseFont = True
        Me.GV5.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV5.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV5_CODE, Me.GV5_VALUE})
        Me.GV5.GridControl = Me.WG5
        Me.GV5.Name = "GV5"
        Me.GV5.OptionsBehavior.Editable = False
        Me.GV5.OptionsBehavior.ReadOnly = True
        Me.GV5.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV5.OptionsView.BestFitMaxRowCount = 10
        Me.GV5.OptionsView.ColumnAutoWidth = False
        Me.GV5.OptionsView.EnableAppearanceEvenRow = True
        Me.GV5.OptionsView.ShowColumnHeaders = False
        Me.GV5.OptionsView.ShowGroupPanel = False
        Me.GV5.OptionsView.ShowViewCaption = True
        Me.GV5.RowHeight = 10
        Me.GV5.ViewCaption = " ⑦ 순증"
        '
        'GV5_CODE
        '
        Me.GV5_CODE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV5_CODE.AppearanceCell.Options.UseFont = True
        Me.GV5_CODE.AppearanceCell.Options.UseTextOptions = True
        Me.GV5_CODE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV5_CODE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV5_CODE.AppearanceHeader.Options.UseFont = True
        Me.GV5_CODE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV5_CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV5_CODE.Caption = "순증"
        Me.GV5_CODE.FieldName = "CODE"
        Me.GV5_CODE.Name = "GV5_CODE"
        Me.GV5_CODE.OptionsColumn.AllowEdit = False
        Me.GV5_CODE.OptionsColumn.ReadOnly = True
        Me.GV5_CODE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV5_CODE.Visible = True
        Me.GV5_CODE.VisibleIndex = 0
        Me.GV5_CODE.Width = 70
        Me.Localizer1.SetWordID(Me.GV5_CODE, "순증")
        '
        'GV5_VALUE
        '
        Me.GV5_VALUE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV5_VALUE.AppearanceCell.Options.UseFont = True
        Me.GV5_VALUE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV5_VALUE.AppearanceHeader.Options.UseFont = True
        Me.GV5_VALUE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV5_VALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV5_VALUE.Caption = "건수/금액"
        Me.GV5_VALUE.DisplayFormat.FormatString = "{0:N0}"
        Me.GV5_VALUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV5_VALUE.FieldName = "VALUE"
        Me.GV5_VALUE.Name = "GV5_VALUE"
        Me.GV5_VALUE.OptionsColumn.AllowEdit = False
        Me.GV5_VALUE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV5_VALUE.OptionsColumn.ReadOnly = True
        Me.GV5_VALUE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV5_VALUE.Visible = True
        Me.GV5_VALUE.VisibleIndex = 1
        Me.GV5_VALUE.Width = 80
        Me.Localizer1.SetWordID(Me.GV5_VALUE, "건수/금액")
        '
        'WG6
        '
        Me.WG6.AllowClientBinding = True
        Me.WG6.DeleteRowConfirmation = True
        Me.WG6.DisplayCurrentRow = False
        Me.WG6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG6.IsDataStateAware = True
        Me.WG6.Location = New System.Drawing.Point(0, 0)
        Me.WG6.MainView = Me.GV6
        Me.WG6.Name = "WG6"
        Me.WG6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG6.SaveLayout = False
        Me.WG6.Size = New System.Drawing.Size(193, 310)
        Me.WG6.TabIndex = 316
        Me.WG6.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        '
        'GV6
        '
        Me.GV6.Appearance.ViewCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV6.Appearance.ViewCaption.Options.UseFont = True
        Me.GV6.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV6.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV6_CODE, Me.GV6_VALUE})
        Me.GV6.GridControl = Me.WG6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsBehavior.Editable = False
        Me.GV6.OptionsBehavior.ReadOnly = True
        Me.GV6.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV6.OptionsView.BestFitMaxRowCount = 10
        Me.GV6.OptionsView.ColumnAutoWidth = False
        Me.GV6.OptionsView.EnableAppearanceEvenRow = True
        Me.GV6.OptionsView.ShowColumnHeaders = False
        Me.GV6.OptionsView.ShowGroupPanel = False
        Me.GV6.OptionsView.ShowViewCaption = True
        Me.GV6.RowHeight = 10
        Me.GV6.ViewCaption = " 인하/해지 금액"
        '
        'GV6_CODE
        '
        Me.GV6_CODE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV6_CODE.AppearanceCell.Options.UseFont = True
        Me.GV6_CODE.AppearanceCell.Options.UseTextOptions = True
        Me.GV6_CODE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV6_CODE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV6_CODE.AppearanceHeader.Options.UseFont = True
        Me.GV6_CODE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV6_CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV6_CODE.Caption = "인하/해지"
        Me.GV6_CODE.FieldName = "CODE"
        Me.GV6_CODE.Name = "GV6_CODE"
        Me.GV6_CODE.OptionsColumn.AllowEdit = False
        Me.GV6_CODE.OptionsColumn.ReadOnly = True
        Me.GV6_CODE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV6_CODE.Visible = True
        Me.GV6_CODE.VisibleIndex = 0
        Me.GV6_CODE.Width = 70
        Me.Localizer1.SetWordID(Me.GV6_CODE, "담당자")
        '
        'GV6_VALUE
        '
        Me.GV6_VALUE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV6_VALUE.AppearanceCell.Options.UseFont = True
        Me.GV6_VALUE.AppearanceCell.Options.UseTextOptions = True
        Me.GV6_VALUE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV6_VALUE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV6_VALUE.AppearanceHeader.Options.UseFont = True
        Me.GV6_VALUE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV6_VALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV6_VALUE.Caption = "건수/금액"
        Me.GV6_VALUE.DisplayFormat.FormatString = "{0:N0}"
        Me.GV6_VALUE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV6_VALUE.FieldName = "VALUE"
        Me.GV6_VALUE.Name = "GV6_VALUE"
        Me.GV6_VALUE.OptionsColumn.AllowEdit = False
        Me.GV6_VALUE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV6_VALUE.OptionsColumn.ReadOnly = True
        Me.GV6_VALUE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV6_VALUE.Visible = True
        Me.GV6_VALUE.VisibleIndex = 1
        Me.GV6_VALUE.Width = 80
        Me.Localizer1.SetWordID(Me.GV6_VALUE, "계약")
        '
        'splitLeft
        '
        Me.splitLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.splitLeft.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.splitLeft.Horizontal = False
        Me.splitLeft.Location = New System.Drawing.Point(3, 3)
        Me.splitLeft.Name = "splitLeft"
        Me.splitLeft.Panel1.Controls.Add(Me.WG2)
        Me.splitLeft.Panel1.Text = "Panel1"
        Me.splitLeft.Panel2.Controls.Add(Me.WG3)
        Me.splitLeft.Panel2.Text = "Panel2"
        Me.splitLeft.Size = New System.Drawing.Size(176, 625)
        Me.splitLeft.SplitterPosition = 312
        Me.splitLeft.TabIndex = 318
        Me.splitLeft.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.splitLeft, "SplitContainerControl1")
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
        Me.WG2.Size = New System.Drawing.Size(176, 312)
        Me.WG2.TabIndex = 313
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Appearance.ViewCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2.Appearance.ViewCaption.Options.UseFont = True
        Me.GV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.WG2_USR_ID, Me.WG2_USR_CNT})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.Editable = False
        Me.GV2.OptionsBehavior.ReadOnly = True
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.BestFitMaxRowCount = 10
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.EnableAppearanceEvenRow = True
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowViewCaption = True
        Me.GV2.RowHeight = 10
        Me.GV2.ViewCaption = " 담당별 계약건수"
        '
        'WG2_USR_ID
        '
        Me.WG2_USR_ID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WG2_USR_ID.AppearanceCell.Options.UseFont = True
        Me.WG2_USR_ID.AppearanceCell.Options.UseTextOptions = True
        Me.WG2_USR_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WG2_USR_ID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.WG2_USR_ID.AppearanceHeader.Options.UseFont = True
        Me.WG2_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.WG2_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WG2_USR_ID.Caption = "담당자"
        Me.WG2_USR_ID.FieldName = "USR_ID"
        Me.WG2_USR_ID.Name = "WG2_USR_ID"
        Me.WG2_USR_ID.OptionsColumn.AllowEdit = False
        Me.WG2_USR_ID.OptionsColumn.ReadOnly = True
        Me.WG2_USR_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.WG2_USR_ID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "USR_ID", "합    계")})
        Me.WG2_USR_ID.Visible = True
        Me.WG2_USR_ID.VisibleIndex = 0
        Me.WG2_USR_ID.Width = 70
        Me.Localizer1.SetWordID(Me.WG2_USR_ID, "담당자")
        '
        'WG2_USR_CNT
        '
        Me.WG2_USR_CNT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WG2_USR_CNT.AppearanceCell.Options.UseFont = True
        Me.WG2_USR_CNT.AppearanceCell.Options.UseTextOptions = True
        Me.WG2_USR_CNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.WG2_USR_CNT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.WG2_USR_CNT.AppearanceHeader.Options.UseFont = True
        Me.WG2_USR_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.WG2_USR_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.WG2_USR_CNT.Caption = "계약"
        Me.WG2_USR_CNT.DisplayFormat.FormatString = "{0:N0}"
        Me.WG2_USR_CNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.WG2_USR_CNT.FieldName = "USR_CNT"
        Me.WG2_USR_CNT.Name = "WG2_USR_CNT"
        Me.WG2_USR_CNT.OptionsColumn.AllowEdit = False
        Me.WG2_USR_CNT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.WG2_USR_CNT.OptionsColumn.ReadOnly = True
        Me.WG2_USR_CNT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.WG2_USR_CNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "USR_CNT", "{0:N0}")})
        Me.WG2_USR_CNT.Visible = True
        Me.WG2_USR_CNT.VisibleIndex = 1
        Me.WG2_USR_CNT.Width = 40
        Me.Localizer1.SetWordID(Me.WG2_USR_CNT, "계약")
        '
        'WG3
        '
        Me.WG3.AllowClientBinding = True
        Me.WG3.DeleteRowConfirmation = True
        Me.WG3.DisplayCurrentRow = False
        Me.WG3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG3.IsDataStateAware = True
        Me.WG3.Location = New System.Drawing.Point(0, 0)
        Me.WG3.MainView = Me.GV3
        Me.WG3.Name = "WG3"
        Me.WG3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG3.SaveLayout = False
        Me.WG3.Size = New System.Drawing.Size(176, 308)
        Me.WG3.TabIndex = 314
        Me.WG3.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Appearance.ViewCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3.Appearance.ViewCaption.Options.UseFont = True
        Me.GV3.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV3.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV3_CTRT_TYPE, Me.GV3_CTRT_CNT})
        Me.GV3.GridControl = Me.WG3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsBehavior.Editable = False
        Me.GV3.OptionsBehavior.ReadOnly = True
        Me.GV3.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV3.OptionsView.BestFitMaxRowCount = 10
        Me.GV3.OptionsView.ColumnAutoWidth = False
        Me.GV3.OptionsView.EnableAppearanceEvenRow = True
        Me.GV3.OptionsView.ShowFooter = True
        Me.GV3.OptionsView.ShowGroupPanel = False
        Me.GV3.OptionsView.ShowViewCaption = True
        Me.GV3.RowHeight = 10
        Me.GV3.ViewCaption = " 구분별 총진행건"
        '
        'GV3_CTRT_TYPE
        '
        Me.GV3_CTRT_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_CTRT_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV3_CTRT_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_CTRT_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_CTRT_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_CTRT_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV3_CTRT_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_CTRT_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_CTRT_TYPE.Caption = "구분"
        Me.GV3_CTRT_TYPE.FieldName = "CTRT_TYPE"
        Me.GV3_CTRT_TYPE.Name = "GV3_CTRT_TYPE"
        Me.GV3_CTRT_TYPE.OptionsColumn.AllowEdit = False
        Me.GV3_CTRT_TYPE.OptionsColumn.ReadOnly = True
        Me.GV3_CTRT_TYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_CTRT_TYPE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "CTRT_TYPE", "합    계")})
        Me.GV3_CTRT_TYPE.Visible = True
        Me.GV3_CTRT_TYPE.VisibleIndex = 0
        Me.GV3_CTRT_TYPE.Width = 70
        Me.Localizer1.SetWordID(Me.GV3_CTRT_TYPE, "구분")
        '
        'GV3_CTRT_CNT
        '
        Me.GV3_CTRT_CNT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_CTRT_CNT.AppearanceCell.Options.UseFont = True
        Me.GV3_CTRT_CNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_CTRT_CNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV3_CTRT_CNT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_CTRT_CNT.AppearanceHeader.Options.UseFont = True
        Me.GV3_CTRT_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_CTRT_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_CTRT_CNT.Caption = "계약"
        Me.GV3_CTRT_CNT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV3_CTRT_CNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV3_CTRT_CNT.FieldName = "CTRT_CNT"
        Me.GV3_CTRT_CNT.Name = "GV3_CTRT_CNT"
        Me.GV3_CTRT_CNT.OptionsColumn.AllowEdit = False
        Me.GV3_CTRT_CNT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV3_CTRT_CNT.OptionsColumn.ReadOnly = True
        Me.GV3_CTRT_CNT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_CTRT_CNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CTRT_CNT", "{0:N0}")})
        Me.GV3_CTRT_CNT.Visible = True
        Me.GV3_CTRT_CNT.VisibleIndex = 1
        Me.GV3_CTRT_CNT.Width = 40
        Me.Localizer1.SetWordID(Me.GV3_CTRT_CNT, "계약")
        '
        'WG4
        '
        Me.WG4.AllowClientBinding = True
        Me.WG4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG4.DeleteRowConfirmation = True
        Me.WG4.DisplayCurrentRow = False
        Me.WG4.IsDataStateAware = True
        Me.WG4.Location = New System.Drawing.Point(185, 3)
        Me.WG4.MainView = Me.GV4
        Me.WG4.Name = "WG4"
        Me.WG4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG4.SaveLayout = False
        Me.WG4.Size = New System.Drawing.Size(810, 627)
        Me.WG4.TabIndex = 315
        Me.WG4.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Appearance.ViewCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4.Appearance.ViewCaption.Options.UseFont = True
        Me.GV4.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV4.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV4_USR_ID, Me.GV4_CTRT_CNT, Me.GV4_ORD_AMT, Me.GV4_CTRT_AMT, Me.GV4_MATN_AMT, Me.GV4_COST_AMT, Me.GV4_PROFIT_AMT, Me.GV4_PROFIT_RATE})
        Me.GV4.GridControl = Me.WG4
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsBehavior.Editable = False
        Me.GV4.OptionsBehavior.ReadOnly = True
        Me.GV4.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV4.OptionsView.BestFitMaxRowCount = 10
        Me.GV4.OptionsView.ColumnAutoWidth = False
        Me.GV4.OptionsView.EnableAppearanceEvenRow = True
        Me.GV4.OptionsView.ShowFooter = True
        Me.GV4.OptionsView.ShowGroupPanel = False
        Me.GV4.OptionsView.ShowViewCaption = True
        Me.GV4.RowHeight = 10
        Me.GV4.ViewCaption = " 담당자별 총계약"
        '
        'GV4_USR_ID
        '
        Me.GV4_USR_ID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_USR_ID.AppearanceCell.Options.UseFont = True
        Me.GV4_USR_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_USR_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_USR_ID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_USR_ID.AppearanceHeader.Options.UseFont = True
        Me.GV4_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_USR_ID.Caption = "담당자"
        Me.GV4_USR_ID.FieldName = "USR_ID"
        Me.GV4_USR_ID.Name = "GV4_USR_ID"
        Me.GV4_USR_ID.OptionsColumn.AllowEdit = False
        Me.GV4_USR_ID.OptionsColumn.ReadOnly = True
        Me.GV4_USR_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV4_USR_ID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "USR_ID", "합    계")})
        Me.GV4_USR_ID.Visible = True
        Me.GV4_USR_ID.VisibleIndex = 0
        Me.GV4_USR_ID.Width = 70
        Me.Localizer1.SetWordID(Me.GV4_USR_ID, "담당자")
        '
        'GV4_CTRT_CNT
        '
        Me.GV4_CTRT_CNT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_CTRT_CNT.AppearanceCell.Options.UseFont = True
        Me.GV4_CTRT_CNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_CTRT_CNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV4_CTRT_CNT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_CTRT_CNT.AppearanceHeader.Options.UseFont = True
        Me.GV4_CTRT_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_CTRT_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_CTRT_CNT.Caption = "총계약건"
        Me.GV4_CTRT_CNT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV4_CTRT_CNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV4_CTRT_CNT.FieldName = "CTRT_CNT"
        Me.GV4_CTRT_CNT.Name = "GV4_CTRT_CNT"
        Me.GV4_CTRT_CNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CTRT_CNT", "{0:N0}")})
        Me.GV4_CTRT_CNT.Visible = True
        Me.GV4_CTRT_CNT.VisibleIndex = 1
        Me.GV4_CTRT_CNT.Width = 60
        Me.Localizer1.SetWordID(Me.GV4_CTRT_CNT, "총계약건")
        '
        'GV4_ORD_AMT
        '
        Me.GV4_ORD_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_ORD_AMT.AppearanceCell.Options.UseFont = True
        Me.GV4_ORD_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_ORD_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV4_ORD_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_ORD_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV4_ORD_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_ORD_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_ORD_AMT.Caption = "① 총계약(SI)"
        Me.GV4_ORD_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV4_ORD_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV4_ORD_AMT.FieldName = "ORD_AMT"
        Me.GV4_ORD_AMT.Name = "GV4_ORD_AMT"
        Me.GV4_ORD_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ORD_AMT", "{0:N0}")})
        Me.GV4_ORD_AMT.Visible = True
        Me.GV4_ORD_AMT.VisibleIndex = 2
        Me.GV4_ORD_AMT.Width = 100
        Me.Localizer1.SetWordID(Me.GV4_ORD_AMT, "① 총계약(SI)")
        '
        'GV4_CTRT_AMT
        '
        Me.GV4_CTRT_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_CTRT_AMT.AppearanceCell.Options.UseFont = True
        Me.GV4_CTRT_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_CTRT_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV4_CTRT_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_CTRT_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV4_CTRT_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_CTRT_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_CTRT_AMT.Caption = "② 설치비"
        Me.GV4_CTRT_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV4_CTRT_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV4_CTRT_AMT.FieldName = "CTRT_AMT"
        Me.GV4_CTRT_AMT.Name = "GV4_CTRT_AMT"
        Me.GV4_CTRT_AMT.OptionsColumn.AllowEdit = False
        Me.GV4_CTRT_AMT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV4_CTRT_AMT.OptionsColumn.ReadOnly = True
        Me.GV4_CTRT_AMT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV4_CTRT_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CTRT_AMT", "{0:N0}")})
        Me.GV4_CTRT_AMT.Visible = True
        Me.GV4_CTRT_AMT.VisibleIndex = 3
        Me.GV4_CTRT_AMT.Width = 95
        Me.Localizer1.SetWordID(Me.GV4_CTRT_AMT, "② 설치비")
        '
        'GV4_MATN_AMT
        '
        Me.GV4_MATN_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_MATN_AMT.AppearanceCell.Options.UseFont = True
        Me.GV4_MATN_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_MATN_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV4_MATN_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_MATN_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV4_MATN_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_MATN_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_MATN_AMT.Caption = "③ 월청구"
        Me.GV4_MATN_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV4_MATN_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV4_MATN_AMT.FieldName = "MATN_AMT"
        Me.GV4_MATN_AMT.Name = "GV4_MATN_AMT"
        Me.GV4_MATN_AMT.OptionsColumn.AllowEdit = False
        Me.GV4_MATN_AMT.OptionsColumn.ReadOnly = True
        Me.GV4_MATN_AMT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV4_MATN_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MATN_AMT", "{0:N0}")})
        Me.GV4_MATN_AMT.Visible = True
        Me.GV4_MATN_AMT.VisibleIndex = 4
        Me.GV4_MATN_AMT.Width = 95
        Me.Localizer1.SetWordID(Me.GV4_MATN_AMT, "③ 월청구")
        '
        'GV4_COST_AMT
        '
        Me.GV4_COST_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_COST_AMT.AppearanceCell.Options.UseFont = True
        Me.GV4_COST_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_COST_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV4_COST_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_COST_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV4_COST_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_COST_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_COST_AMT.Caption = "④ 수행원가"
        Me.GV4_COST_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV4_COST_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV4_COST_AMT.FieldName = "COST_AMT"
        Me.GV4_COST_AMT.Name = "GV4_COST_AMT"
        Me.GV4_COST_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "COST_AMT", "{0:N0}")})
        Me.GV4_COST_AMT.Visible = True
        Me.GV4_COST_AMT.VisibleIndex = 5
        Me.GV4_COST_AMT.Width = 95
        Me.Localizer1.SetWordID(Me.GV4_COST_AMT, "④ 수행원가")
        '
        'GV4_PROFIT_AMT
        '
        Me.GV4_PROFIT_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_PROFIT_AMT.AppearanceCell.Options.UseFont = True
        Me.GV4_PROFIT_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_PROFIT_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV4_PROFIT_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_PROFIT_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV4_PROFIT_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_PROFIT_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_PROFIT_AMT.Caption = "⑤ 공여이익(①+②+④)"
        Me.GV4_PROFIT_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV4_PROFIT_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV4_PROFIT_AMT.FieldName = "PROFIT_AMT"
        Me.GV4_PROFIT_AMT.Name = "GV4_PROFIT_AMT"
        Me.GV4_PROFIT_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PROFIT_AMT", "{0:N0}")})
        Me.GV4_PROFIT_AMT.Visible = True
        Me.GV4_PROFIT_AMT.VisibleIndex = 6
        Me.GV4_PROFIT_AMT.Width = 100
        Me.Localizer1.SetWordID(Me.GV4_PROFIT_AMT, "⑤ 공여이익(①+②+④)")
        '
        'GV4_PROFIT_RATE
        '
        Me.GV4_PROFIT_RATE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_PROFIT_RATE.AppearanceCell.Options.UseFont = True
        Me.GV4_PROFIT_RATE.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_PROFIT_RATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV4_PROFIT_RATE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV4_PROFIT_RATE.AppearanceHeader.Options.UseFont = True
        Me.GV4_PROFIT_RATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_PROFIT_RATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_PROFIT_RATE.Caption = "⑥ 이익률"
        Me.GV4_PROFIT_RATE.DisplayFormat.FormatString = "{0:N0}"
        Me.GV4_PROFIT_RATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV4_PROFIT_RATE.FieldName = "PROFIT_RATE"
        Me.GV4_PROFIT_RATE.Name = "GV4_PROFIT_RATE"
        Me.GV4_PROFIT_RATE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PROFIT_RATE", "{0:N0}")})
        Me.GV4_PROFIT_RATE.Visible = True
        Me.GV4_PROFIT_RATE.VisibleIndex = 7
        Me.GV4_PROFIT_RATE.Width = 65
        Me.Localizer1.SetWordID(Me.GV4_PROFIT_RATE, "⑥ 이익률")
        '
        'GV1_BIZ_TYPE
        '
        Me.GV1_BIZ_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_BIZ_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_BIZ_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BIZ_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BIZ_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_BIZ_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV1_BIZ_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BIZ_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BIZ_TYPE.Caption = "구분"
        Me.GV1_BIZ_TYPE.FieldName = "BIZ_TYPE"
        Me.GV1_BIZ_TYPE.Name = "GV1_BIZ_TYPE"
        Me.GV1_BIZ_TYPE.Visible = True
        Me.GV1_BIZ_TYPE.VisibleIndex = 3
        Me.GV1_BIZ_TYPE.Width = 45
        Me.Localizer1.SetWordID(Me.GV1_BIZ_TYPE, "구분")
        '
        'GV1_CUST_CD
        '
        Me.GV1_CUST_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CUST_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_CUST_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CUST_CD.AppearanceHeader.Options.UseFont = True
        Me.GV1_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.Caption = "상호"
        Me.GV1_CUST_CD.FieldName = "CUST_CD"
        Me.GV1_CUST_CD.Name = "GV1_CUST_CD"
        Me.GV1_CUST_CD.Visible = True
        Me.GV1_CUST_CD.VisibleIndex = 4
        Me.GV1_CUST_CD.Width = 70
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "상호")
        '
        'GV1_ITEM_NM
        '
        Me.GV1_ITEM_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_ITEM_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_ITEM_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_ITEM_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_ITEM_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_ITEM_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_ITEM_NM.Caption = "품목"
        Me.GV1_ITEM_NM.ColumnEdit = Me.rpText_100
        Me.GV1_ITEM_NM.FieldName = "ITEM_NM"
        Me.GV1_ITEM_NM.Name = "GV1_ITEM_NM"
        Me.GV1_ITEM_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_ITEM_NM.ToolTip = "SI의 경우 사업명"
        Me.GV1_ITEM_NM.Visible = True
        Me.GV1_ITEM_NM.VisibleIndex = 6
        Me.GV1_ITEM_NM.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_ITEM_NM, "품목")
        '
        'rpText_100
        '
        Me.rpText_100.AutoHeight = False
        Me.rpText_100.MaxLength = 100
        Me.rpText_100.Name = "rpText_100"
        '
        'GV1_ORD_AMT
        '
        Me.GV1_ORD_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_ORD_AMT.AppearanceCell.Options.UseFont = True
        Me.GV1_ORD_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_ORD_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_ORD_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_ORD_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV1_ORD_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_ORD_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_ORD_AMT.Caption = "SI수주금액"
        Me.GV1_ORD_AMT.ColumnEdit = Me.rpNumeric_N0
        Me.GV1_ORD_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV1_ORD_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_ORD_AMT.FieldName = "ORD_AMT"
        Me.GV1_ORD_AMT.Name = "GV1_ORD_AMT"
        Me.GV1_ORD_AMT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_ORD_AMT.Visible = True
        Me.GV1_ORD_AMT.VisibleIndex = 7
        Me.GV1_ORD_AMT.Width = 65
        Me.Localizer1.SetWordID(Me.GV1_ORD_AMT, "SI수주금액")
        '
        'rpNumeric_N0
        '
        Me.rpNumeric_N0.AutoHeight = False
        Me.rpNumeric_N0.DisplayFormat.FormatString = "{0:N0}"
        Me.rpNumeric_N0.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpNumeric_N0.EditFormat.FormatString = "{0:N0}"
        Me.rpNumeric_N0.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpNumeric_N0.Name = "rpNumeric_N0"
        '
        'GV1_CTRT_AMT
        '
        Me.GV1_CTRT_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CTRT_AMT.AppearanceCell.Options.UseFont = True
        Me.GV1_CTRT_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CTRT_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_CTRT_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CTRT_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV1_CTRT_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CTRT_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CTRT_AMT.Caption = "설치비"
        Me.GV1_CTRT_AMT.ColumnEdit = Me.rpNumeric_N0
        Me.GV1_CTRT_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV1_CTRT_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_CTRT_AMT.FieldName = "CTRT_AMT"
        Me.GV1_CTRT_AMT.Name = "GV1_CTRT_AMT"
        Me.GV1_CTRT_AMT.Visible = True
        Me.GV1_CTRT_AMT.VisibleIndex = 8
        Me.GV1_CTRT_AMT.Width = 65
        Me.Localizer1.SetWordID(Me.GV1_CTRT_AMT, "설치비")
        '
        'GV1_MATN_AMT
        '
        Me.GV1_MATN_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_MATN_AMT.AppearanceCell.Options.UseFont = True
        Me.GV1_MATN_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_MATN_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_MATN_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_MATN_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV1_MATN_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MATN_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MATN_AMT.Caption = "유지보수"
        Me.GV1_MATN_AMT.ColumnEdit = Me.rpNumeric_N0
        Me.GV1_MATN_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV1_MATN_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_MATN_AMT.FieldName = "MATN_AMT"
        Me.GV1_MATN_AMT.Name = "GV1_MATN_AMT"
        Me.GV1_MATN_AMT.Visible = True
        Me.GV1_MATN_AMT.VisibleIndex = 10
        Me.GV1_MATN_AMT.Width = 65
        Me.Localizer1.SetWordID(Me.GV1_MATN_AMT, "월청구")
        '
        'GV1_COST_AMT
        '
        Me.GV1_COST_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_COST_AMT.AppearanceCell.Options.UseFont = True
        Me.GV1_COST_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COST_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_COST_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_COST_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV1_COST_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COST_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COST_AMT.Caption = "수행원가"
        Me.GV1_COST_AMT.ColumnEdit = Me.rpNumeric_N0
        Me.GV1_COST_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV1_COST_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_COST_AMT.FieldName = "COST_AMT"
        Me.GV1_COST_AMT.Name = "GV1_COST_AMT"
        Me.GV1_COST_AMT.Visible = True
        Me.GV1_COST_AMT.VisibleIndex = 11
        Me.GV1_COST_AMT.Width = 65
        Me.Localizer1.SetWordID(Me.GV1_COST_AMT, "수행원가")
        '
        'GV1_PROFIT_AMT
        '
        Me.GV1_PROFIT_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PROFIT_AMT.AppearanceCell.Options.UseFont = True
        Me.GV1_PROFIT_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PROFIT_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_PROFIT_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PROFIT_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV1_PROFIT_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PROFIT_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROFIT_AMT.Caption = "공여이익"
        Me.GV1_PROFIT_AMT.ColumnEdit = Me.rpNumeric_N0
        Me.GV1_PROFIT_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV1_PROFIT_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_PROFIT_AMT.FieldName = "PROFIT_AMT"
        Me.GV1_PROFIT_AMT.Name = "GV1_PROFIT_AMT"
        Me.GV1_PROFIT_AMT.Visible = True
        Me.GV1_PROFIT_AMT.VisibleIndex = 12
        Me.GV1_PROFIT_AMT.Width = 65
        Me.Localizer1.SetWordID(Me.GV1_PROFIT_AMT, "공여이익")
        '
        'GV1_CMPT_RATE
        '
        Me.GV1_CMPT_RATE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CMPT_RATE.AppearanceCell.Options.UseFont = True
        Me.GV1_CMPT_RATE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CMPT_RATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_CMPT_RATE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CMPT_RATE.AppearanceHeader.Options.UseFont = True
        Me.GV1_CMPT_RATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CMPT_RATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CMPT_RATE.Caption = "확률"
        Me.GV1_CMPT_RATE.FieldName = "CMPT_RATE"
        Me.GV1_CMPT_RATE.Name = "GV1_CMPT_RATE"
        Me.GV1_CMPT_RATE.Visible = True
        Me.GV1_CMPT_RATE.VisibleIndex = 13
        Me.GV1_CMPT_RATE.Width = 45
        Me.Localizer1.SetWordID(Me.GV1_CMPT_RATE, "확률")
        '
        'GV1_PROC_TYPE
        '
        Me.GV1_PROC_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PROC_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_PROC_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PROC_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV1_PROC_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PROC_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROC_TYPE.Caption = "영업상태"
        Me.GV1_PROC_TYPE.FieldName = "PROC_TYPE"
        Me.GV1_PROC_TYPE.Name = "GV1_PROC_TYPE"
        Me.GV1_PROC_TYPE.Visible = True
        Me.GV1_PROC_TYPE.VisibleIndex = 14
        Me.GV1_PROC_TYPE.Width = 92
        Me.Localizer1.SetWordID(Me.GV1_PROC_TYPE, "영업상태")
        '
        'GV1_CTRT_YMD
        '
        Me.GV1_CTRT_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CTRT_YMD.AppearanceCell.Options.UseFont = True
        Me.GV1_CTRT_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CTRT_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CTRT_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CTRT_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV1_CTRT_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CTRT_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CTRT_YMD.Caption = "계약일"
        Me.GV1_CTRT_YMD.ColumnEdit = Me.rpCTRT_YMD
        Me.GV1_CTRT_YMD.FieldName = "CTRT_YMD"
        Me.GV1_CTRT_YMD.Name = "GV1_CTRT_YMD"
        Me.GV1_CTRT_YMD.Visible = True
        Me.GV1_CTRT_YMD.VisibleIndex = 15
        Me.GV1_CTRT_YMD.Width = 65
        Me.Localizer1.SetWordID(Me.GV1_CTRT_YMD, "계약일")
        '
        'rpCTRT_YMD
        '
        Me.rpCTRT_YMD.AutoHeight = False
        Me.rpCTRT_YMD.Mask.EditMask = "([123][0-9])[0-9][0-9]-(0[1-9]|1[012])"
        Me.rpCTRT_YMD.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.rpCTRT_YMD.Mask.SaveLiteral = False
        Me.rpCTRT_YMD.Mask.UseMaskAsDisplayFormat = True
        Me.rpCTRT_YMD.Name = "rpCTRT_YMD"
        '
        'GV1_BIZ_COND
        '
        Me.GV1_BIZ_COND.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_BIZ_COND.AppearanceCell.Options.UseFont = True
        Me.GV1_BIZ_COND.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_BIZ_COND.AppearanceHeader.Options.UseFont = True
        Me.GV1_BIZ_COND.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BIZ_COND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BIZ_COND.Caption = "구분상세"
        Me.GV1_BIZ_COND.FieldName = "BIZ_COND"
        Me.GV1_BIZ_COND.Name = "GV1_BIZ_COND"
        Me.GV1_BIZ_COND.OptionsColumn.AllowEdit = False
        Me.GV1_BIZ_COND.OptionsColumn.ReadOnly = True
        Me.GV1_BIZ_COND.Visible = True
        Me.GV1_BIZ_COND.VisibleIndex = 16
        Me.Localizer1.SetWordID(Me.GV1_BIZ_COND, "구분상세")
        '
        'GV1_TAX_START_MONTH
        '
        Me.GV1_TAX_START_MONTH.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_TAX_START_MONTH.AppearanceCell.Options.UseFont = True
        Me.GV1_TAX_START_MONTH.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_TAX_START_MONTH.AppearanceHeader.Options.UseFont = True
        Me.GV1_TAX_START_MONTH.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TAX_START_MONTH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TAX_START_MONTH.Caption = "최초청구월"
        Me.GV1_TAX_START_MONTH.ColumnEdit = Me.rpTAX_START_MONTH
        Me.GV1_TAX_START_MONTH.FieldName = "TAX_START_MONTH"
        Me.GV1_TAX_START_MONTH.Name = "GV1_TAX_START_MONTH"
        Me.GV1_TAX_START_MONTH.ToolTip = "SI의 경우 매출 계획"
        Me.GV1_TAX_START_MONTH.Visible = True
        Me.GV1_TAX_START_MONTH.VisibleIndex = 17
        Me.Localizer1.SetWordID(Me.GV1_TAX_START_MONTH, "최초청구월")
        '
        'rpTAX_START_MONTH
        '
        Me.rpTAX_START_MONTH.AutoHeight = False
        Me.rpTAX_START_MONTH.Mask.EditMask = "([123][0-9])[0-9][0-9]-(0[1-9]|1[012])"
        Me.rpTAX_START_MONTH.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.rpTAX_START_MONTH.Mask.SaveLiteral = False
        Me.rpTAX_START_MONTH.Mask.UseMaskAsDisplayFormat = True
        Me.rpTAX_START_MONTH.Name = "rpTAX_START_MONTH"
        '
        'GV1_CTRT_RCV_YN
        '
        Me.GV1_CTRT_RCV_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CTRT_RCV_YN.AppearanceCell.Options.UseFont = True
        Me.GV1_CTRT_RCV_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CTRT_RCV_YN.AppearanceHeader.Options.UseFont = True
        Me.GV1_CTRT_RCV_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CTRT_RCV_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CTRT_RCV_YN.Caption = "계약서"
        Me.GV1_CTRT_RCV_YN.FieldName = "CTRT_RCV_YN"
        Me.GV1_CTRT_RCV_YN.Name = "GV1_CTRT_RCV_YN"
        Me.GV1_CTRT_RCV_YN.Visible = True
        Me.GV1_CTRT_RCV_YN.VisibleIndex = 18
        Me.GV1_CTRT_RCV_YN.Width = 55
        Me.Localizer1.SetWordID(Me.GV1_CTRT_RCV_YN, "계약서")
        '
        'GV1_SETUP_TAX_YN
        '
        Me.GV1_SETUP_TAX_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_SETUP_TAX_YN.AppearanceCell.Options.UseFont = True
        Me.GV1_SETUP_TAX_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_SETUP_TAX_YN.AppearanceHeader.Options.UseFont = True
        Me.GV1_SETUP_TAX_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SETUP_TAX_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SETUP_TAX_YN.Caption = "설치비청구 여부"
        Me.GV1_SETUP_TAX_YN.FieldName = "SETUP_TAX_YN"
        Me.GV1_SETUP_TAX_YN.Name = "GV1_SETUP_TAX_YN"
        Me.GV1_SETUP_TAX_YN.Visible = True
        Me.GV1_SETUP_TAX_YN.VisibleIndex = 19
        Me.GV1_SETUP_TAX_YN.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_SETUP_TAX_YN, "설치비청구 여부")
        '
        'GV1_MONTH_TAX_YN
        '
        Me.GV1_MONTH_TAX_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_MONTH_TAX_YN.AppearanceCell.Options.UseFont = True
        Me.GV1_MONTH_TAX_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_MONTH_TAX_YN.AppearanceHeader.Options.UseFont = True
        Me.GV1_MONTH_TAX_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MONTH_TAX_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MONTH_TAX_YN.Caption = "월청구 여부"
        Me.GV1_MONTH_TAX_YN.FieldName = "MONTH_TAX_YN"
        Me.GV1_MONTH_TAX_YN.Name = "GV1_MONTH_TAX_YN"
        Me.GV1_MONTH_TAX_YN.ToolTip = "관리팀 확인항목"
        Me.GV1_MONTH_TAX_YN.Visible = True
        Me.GV1_MONTH_TAX_YN.VisibleIndex = 20
        Me.GV1_MONTH_TAX_YN.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_MONTH_TAX_YN, "월청구 여부")
        '
        'GV1_OUTSTAND_AMT
        '
        Me.GV1_OUTSTAND_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_OUTSTAND_AMT.AppearanceCell.Options.UseFont = True
        Me.GV1_OUTSTAND_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_OUTSTAND_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_OUTSTAND_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_OUTSTAND_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV1_OUTSTAND_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_OUTSTAND_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_OUTSTAND_AMT.Caption = "청구잔액"
        Me.GV1_OUTSTAND_AMT.ColumnEdit = Me.rpNumeric_N0
        Me.GV1_OUTSTAND_AMT.FieldName = "OUTSTAND_AMT"
        Me.GV1_OUTSTAND_AMT.Name = "GV1_OUTSTAND_AMT"
        Me.GV1_OUTSTAND_AMT.Visible = True
        Me.GV1_OUTSTAND_AMT.VisibleIndex = 21
        Me.Localizer1.SetWordID(Me.GV1_OUTSTAND_AMT, "청구잔액")
        '
        'GV1_JOIN_TYPE
        '
        Me.GV1_JOIN_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_JOIN_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_JOIN_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_JOIN_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV1_JOIN_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_JOIN_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_JOIN_TYPE.Caption = "영업구분"
        Me.GV1_JOIN_TYPE.ColumnEdit = Me.rpText_100
        Me.GV1_JOIN_TYPE.FieldName = "JOIN_TYPE"
        Me.GV1_JOIN_TYPE.Name = "GV1_JOIN_TYPE"
        Me.GV1_JOIN_TYPE.Visible = True
        Me.GV1_JOIN_TYPE.VisibleIndex = 22
        Me.Localizer1.SetWordID(Me.GV1_JOIN_TYPE, "영업구분")
        '
        'GV1_JOIN_ROUTE
        '
        Me.GV1_JOIN_ROUTE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_JOIN_ROUTE.AppearanceCell.Options.UseFont = True
        Me.GV1_JOIN_ROUTE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_JOIN_ROUTE.AppearanceHeader.Options.UseFont = True
        Me.GV1_JOIN_ROUTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_JOIN_ROUTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_JOIN_ROUTE.Caption = "유입경로"
        Me.GV1_JOIN_ROUTE.ColumnEdit = Me.rpText_100
        Me.GV1_JOIN_ROUTE.FieldName = "JOIN_ROUTE"
        Me.GV1_JOIN_ROUTE.Name = "GV1_JOIN_ROUTE"
        Me.GV1_JOIN_ROUTE.Visible = True
        Me.GV1_JOIN_ROUTE.VisibleIndex = 23
        Me.Localizer1.SetWordID(Me.GV1_JOIN_ROUTE, "유입경로")
        '
        'GV1_RMK
        '
        Me.GV1_RMK.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_RMK.AppearanceCell.Options.UseFont = True
        Me.GV1_RMK.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_RMK.AppearanceHeader.Options.UseFont = True
        Me.GV1_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RMK.Caption = "영업상담 내용"
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 24
        Me.GV1_RMK.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_RMK, "영업상담 내용")
        '
        'rpMemo_400
        '
        Me.rpMemo_400.AutoHeight = False
        Me.rpMemo_400.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpMemo_400.MaxLength = 400
        Me.rpMemo_400.Name = "rpMemo_400"
        Me.rpMemo_400.ShowIcon = False
        '
        'GV1_PIC_NM
        '
        Me.GV1_PIC_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PIC_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_PIC_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PIC_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_PIC_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PIC_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PIC_NM.Caption = "고객담당자"
        Me.GV1_PIC_NM.ColumnEdit = Me.rpText_100
        Me.GV1_PIC_NM.FieldName = "PIC_NM"
        Me.GV1_PIC_NM.Name = "GV1_PIC_NM"
        Me.GV1_PIC_NM.Visible = True
        Me.GV1_PIC_NM.VisibleIndex = 25
        Me.GV1_PIC_NM.Width = 85
        Me.Localizer1.SetWordID(Me.GV1_PIC_NM, "고객담당자")
        '
        'rpText_50
        '
        Me.rpText_50.AutoHeight = False
        Me.rpText_50.MaxLength = 50
        Me.rpText_50.Name = "rpText_50"
        '
        'GV1_PIC_MOBILE
        '
        Me.GV1_PIC_MOBILE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PIC_MOBILE.AppearanceCell.Options.UseFont = True
        Me.GV1_PIC_MOBILE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PIC_MOBILE.AppearanceHeader.Options.UseFont = True
        Me.GV1_PIC_MOBILE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PIC_MOBILE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PIC_MOBILE.Caption = "핸드폰"
        Me.GV1_PIC_MOBILE.ColumnEdit = Me.rpText_30
        Me.GV1_PIC_MOBILE.FieldName = "PIC_MOBILE"
        Me.GV1_PIC_MOBILE.Name = "GV1_PIC_MOBILE"
        Me.GV1_PIC_MOBILE.Visible = True
        Me.GV1_PIC_MOBILE.VisibleIndex = 26
        Me.GV1_PIC_MOBILE.Width = 85
        Me.Localizer1.SetWordID(Me.GV1_PIC_MOBILE, "핸드폰")
        '
        'rpText_30
        '
        Me.rpText_30.AutoHeight = False
        Me.rpText_30.MaxLength = 30
        Me.rpText_30.Name = "rpText_30"
        '
        'GV1_PIC_EMAIL
        '
        Me.GV1_PIC_EMAIL.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PIC_EMAIL.AppearanceCell.Options.UseFont = True
        Me.GV1_PIC_EMAIL.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PIC_EMAIL.AppearanceHeader.Options.UseFont = True
        Me.GV1_PIC_EMAIL.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PIC_EMAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PIC_EMAIL.Caption = "이메일"
        Me.GV1_PIC_EMAIL.ColumnEdit = Me.rpText_64
        Me.GV1_PIC_EMAIL.FieldName = "PIC_EMAIL"
        Me.GV1_PIC_EMAIL.Name = "GV1_PIC_EMAIL"
        Me.GV1_PIC_EMAIL.Visible = True
        Me.GV1_PIC_EMAIL.VisibleIndex = 27
        Me.GV1_PIC_EMAIL.Width = 85
        Me.Localizer1.SetWordID(Me.GV1_PIC_EMAIL, "이메일")
        '
        'rpText_64
        '
        Me.rpText_64.AutoHeight = False
        Me.rpText_64.MaxLength = 64
        Me.rpText_64.Name = "rpText_64"
        '
        'GV1_INS_USR
        '
        Me.GV1_INS_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_INS_USR.AppearanceCell.Options.UseFont = True
        Me.GV1_INS_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_INS_USR.AppearanceHeader.Options.UseFont = True
        Me.GV1_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.Caption = "입력자"
        Me.GV1_INS_USR.FieldName = "INS_USR"
        Me.GV1_INS_USR.Name = "GV1_INS_USR"
        Me.GV1_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV1_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV1_INS_USR.Visible = True
        Me.GV1_INS_USR.VisibleIndex = 28
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "입력자")
        '
        'GV1_INS_YMD
        '
        Me.GV1_INS_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_INS_YMD.AppearanceCell.Options.UseFont = True
        Me.GV1_INS_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_YMD.Caption = "입력일자"
        Me.GV1_INS_YMD.FieldName = "INS_YMD"
        Me.GV1_INS_YMD.Name = "GV1_INS_YMD"
        Me.GV1_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_INS_YMD.Visible = True
        Me.GV1_INS_YMD.VisibleIndex = 29
        Me.GV1_INS_YMD.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "입력일자")
        '
        'GV1_UPD_USR
        '
        Me.GV1_UPD_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_UPD_USR.AppearanceCell.Options.UseFont = True
        Me.GV1_UPD_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_UPD_USR.AppearanceHeader.Options.UseFont = True
        Me.GV1_UPD_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPD_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_USR.Caption = "수정자"
        Me.GV1_UPD_USR.FieldName = "UPD_USR"
        Me.GV1_UPD_USR.Name = "GV1_UPD_USR"
        Me.GV1_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_USR.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_USR.Visible = True
        Me.GV1_UPD_USR.VisibleIndex = 30
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "수정자")
        '
        'GV1_UPD_YMD
        '
        Me.GV1_UPD_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_UPD_YMD.AppearanceCell.Options.UseFont = True
        Me.GV1_UPD_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_UPD_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV1_UPD_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPD_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_YMD.Caption = "수정일자"
        Me.GV1_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV1_UPD_YMD.Name = "GV1_UPD_YMD"
        Me.GV1_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_YMD.Visible = True
        Me.GV1_UPD_YMD.VisibleIndex = 31
        Me.GV1_UPD_YMD.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "수정일자")
        '
        'xtpInput
        '
        Me.xtpInput.Appearance.Header.Options.UseTextOptions = True
        Me.xtpInput.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpInput.Controls.Add(Me.WG1)
        Me.xtpInput.Name = "xtpInput"
        Me.xtpInput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtpInput.Size = New System.Drawing.Size(1197, 629)
        Me.xtpInput.TabPageWidth = 110
        Me.xtpInput.Text = "영업진행 입력"
        Me.Localizer1.SetWordID(Me.xtpInput, "영업진행 입력")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(3, 4)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpNumeric_N0, Me.rpMemo_400, Me.rpText_50, Me.rpText_30, Me.rpText_64, Me.rpText_100, Me.rpCTRT_YMD, Me.rpTAX_START_MONTH})
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(1192, 625)
        Me.WG1.TabIndex = 302
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_MNGT_NO, Me.GV1_DEPT_CD, Me.GV1_BIZ_YMD, Me.GV1_USR_ID, Me.GV1_PROD_CD, Me.GV1_BIZ_TYPE, Me.GV1_CUST_CD, Me.GV1_CUST_NM, Me.GV1_ITEM_NM, Me.GV1_ORD_AMT, Me.GV1_CTRT_AMT, Me.GV1_IDC_AMT, Me.GV1_MATN_AMT, Me.GV1_COST_AMT, Me.GV1_PROFIT_AMT, Me.GV1_CMPT_RATE, Me.GV1_PROC_TYPE, Me.GV1_CTRT_YMD, Me.GV1_BIZ_COND, Me.GV1_TAX_START_MONTH, Me.GV1_CTRT_RCV_YN, Me.GV1_SETUP_TAX_YN, Me.GV1_MONTH_TAX_YN, Me.GV1_OUTSTAND_AMT, Me.GV1_JOIN_TYPE, Me.GV1_JOIN_ROUTE, Me.GV1_RMK, Me.GV1_PIC_NM, Me.GV1_PIC_MOBILE, Me.GV1_PIC_EMAIL, Me.GV1_INS_USR, Me.GV1_INS_YMD, Me.GV1_UPD_USR, Me.GV1_UPD_YMD})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.BestFitMaxRowCount = 10
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.EnableAppearanceEvenRow = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.RowHeight = 10
        Me.GV1.ViewCaption = " "
        '
        'GV1_MNGT_NO
        '
        Me.GV1_MNGT_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_MNGT_NO.AppearanceCell.Options.UseFont = True
        Me.GV1_MNGT_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseFont = True
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.Caption = "관리번호"
        Me.GV1_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV1_MNGT_NO.Name = "GV1_MNGT_NO"
        Me.GV1_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV1_MNGT_NO.Width = 20
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        '
        'GV1_DEPT_CD
        '
        Me.GV1_DEPT_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DEPT_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_DEPT_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DEPT_CD.AppearanceHeader.Options.UseFont = True
        Me.GV1_DEPT_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DEPT_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DEPT_CD.Caption = "부서"
        Me.GV1_DEPT_CD.FieldName = "DEPT_CD"
        Me.GV1_DEPT_CD.Name = "GV1_DEPT_CD"
        Me.GV1_DEPT_CD.Width = 20
        Me.Localizer1.SetWordID(Me.GV1_DEPT_CD, "부서")
        '
        'GV1_BIZ_YMD
        '
        Me.GV1_BIZ_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_BIZ_YMD.AppearanceCell.Options.UseFont = True
        Me.GV1_BIZ_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BIZ_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BIZ_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_BIZ_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV1_BIZ_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BIZ_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BIZ_YMD.Caption = "*영업시작일"
        Me.GV1_BIZ_YMD.FieldName = "BIZ_YMD"
        Me.GV1_BIZ_YMD.Name = "GV1_BIZ_YMD"
        Me.GV1_BIZ_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_BIZ_YMD.Visible = True
        Me.GV1_BIZ_YMD.VisibleIndex = 0
        Me.GV1_BIZ_YMD.Width = 85
        Me.Localizer1.SetWordID(Me.GV1_BIZ_YMD, "*영업시작일")
        '
        'GV1_USR_ID
        '
        Me.GV1_USR_ID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_USR_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_USR_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_USR_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USR_ID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_USR_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USR_ID.Caption = "*담당자"
        Me.GV1_USR_ID.FieldName = "USR_ID"
        Me.GV1_USR_ID.Name = "GV1_USR_ID"
        Me.GV1_USR_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV1_USR_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_USR_ID.Visible = True
        Me.GV1_USR_ID.VisibleIndex = 1
        Me.GV1_USR_ID.Width = 73
        Me.Localizer1.SetWordID(Me.GV1_USR_ID, "*담당자")
        '
        'GV1_PROD_CD
        '
        Me.GV1_PROD_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PROD_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_PROD_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PROD_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROD_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PROD_CD.AppearanceHeader.Options.UseFont = True
        Me.GV1_PROD_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PROD_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROD_CD.Caption = "*상품"
        Me.GV1_PROD_CD.FieldName = "PROD_CD"
        Me.GV1_PROD_CD.Name = "GV1_PROD_CD"
        Me.GV1_PROD_CD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PROD_CD.Visible = True
        Me.GV1_PROD_CD.VisibleIndex = 2
        Me.GV1_PROD_CD.Width = 62
        Me.Localizer1.SetWordID(Me.GV1_PROD_CD, "*상품")
        '
        'GV1_CUST_NM
        '
        Me.GV1_CUST_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CUST_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_CUST_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CUST_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_NM.Caption = "*상호명"
        Me.GV1_CUST_NM.ColumnEdit = Me.rpText_100
        Me.GV1_CUST_NM.FieldName = "CUST_NM"
        Me.GV1_CUST_NM.Name = "GV1_CUST_NM"
        Me.GV1_CUST_NM.Visible = True
        Me.GV1_CUST_NM.VisibleIndex = 5
        Me.GV1_CUST_NM.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "*상호명")
        '
        'GV1_IDC_AMT
        '
        Me.GV1_IDC_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_IDC_AMT.AppearanceCell.Options.UseFont = True
        Me.GV1_IDC_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_IDC_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_IDC_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_IDC_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV1_IDC_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_IDC_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_IDC_AMT.Caption = "DB임대"
        Me.GV1_IDC_AMT.ColumnEdit = Me.rpNumeric_N0
        Me.GV1_IDC_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV1_IDC_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_IDC_AMT.FieldName = "IDC_AMT"
        Me.GV1_IDC_AMT.Name = "GV1_IDC_AMT"
        Me.GV1_IDC_AMT.Visible = True
        Me.GV1_IDC_AMT.VisibleIndex = 9
        Me.GV1_IDC_AMT.Width = 65
        Me.Localizer1.SetWordID(Me.GV1_IDC_AMT, "DB임대")
        '
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.MODIFY_YN)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(3, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1203, 32)
        Me.palAutoButton.TabIndex = 278
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'MODIFY_YN
        '
        Me.MODIFY_YN.BorderColor = System.Drawing.Color.Empty
        Me.MODIFY_YN.DefVal = "N"
        Me.MODIFY_YN.Enabled = False
        Me.MODIFY_YN.IsDataStateAware = True
        Me.MODIFY_YN.Location = New System.Drawing.Point(673, 4)
        Me.MODIFY_YN.Name = "MODIFY_YN"
        Me.MODIFY_YN.NextFocus = Nothing
        Me.MODIFY_YN.Size = New System.Drawing.Size(16, 22)
        Me.MODIFY_YN.TabIndex = 12
        Me.MODIFY_YN.Text = "N"
        Me.MODIFY_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.MODIFY_YN.Visible = False
        '
        'S_DEPT_CD
        '
        Me.S_DEPT_CD.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_DEPT_CD.ColumnWidths = ""
        Me.S_DEPT_CD.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_DEPT_CD.DataParams = "GroupCode:'C03',NameType:''"
        Me.S_DEPT_CD.DefVal = ""
        Me.S_DEPT_CD.DisplayMember = "NAME"
        Me.S_DEPT_CD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DEPT_CD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_DEPT_CD.FormattingEnabled = True
        Me.S_DEPT_CD.IsDataStateAware = True
        Me.S_DEPT_CD.ItemDelimiter = ","
        Me.S_DEPT_CD.ItemTextList = ""
        Me.S_DEPT_CD.ItemValueList = ""
        Me.S_DEPT_CD.KeepIntegrity = True
        Me.S_DEPT_CD.Location = New System.Drawing.Point(365, 5)
        Me.S_DEPT_CD.Name = "S_DEPT_CD"
        Me.S_DEPT_CD.NextFocus = "S_CUST_NM"
        Me.S_DEPT_CD.NullText = "--Select--"
        Me.S_DEPT_CD.SearchKeys = ""
        Me.S_DEPT_CD.Size = New System.Drawing.Size(145, 23)
        Me.S_DEPT_CD.TabIndex = 3
        Me.S_DEPT_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DEPT_CD.ValueMember = "CODE"
        '
        'S_DATE_TYPE
        '
        Me.S_DATE_TYPE.CodeType = ""
        Me.S_DATE_TYPE.ColumnWidths = ""
        Me.S_DATE_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_DATE_TYPE.DataParams = ""
        Me.S_DATE_TYPE.DefVal = "B"
        Me.S_DATE_TYPE.DisplayMember = "NAME"
        Me.S_DATE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DATE_TYPE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_DATE_TYPE.FormattingEnabled = True
        Me.S_DATE_TYPE.IsDataStateAware = True
        Me.S_DATE_TYPE.ItemDelimiter = ","
        Me.S_DATE_TYPE.ItemTextList = "영업시작일,계약일"
        Me.S_DATE_TYPE.ItemValueList = "B,C"
        Me.S_DATE_TYPE.KeepIntegrity = True
        Me.S_DATE_TYPE.Location = New System.Drawing.Point(13, 5)
        Me.S_DATE_TYPE.Name = "S_DATE_TYPE"
        Me.S_DATE_TYPE.NextFocus = "S_FM_YMD"
        Me.S_DATE_TYPE.NullText = ""
        Me.S_DATE_TYPE.SearchKeys = ""
        Me.S_DATE_TYPE.Size = New System.Drawing.Size(85, 23)
        Me.S_DATE_TYPE.TabIndex = 0
        Me.S_DATE_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DATE_TYPE.ValueMember = "CODE"
        '
        'S_TO_YMD
        '
        Me.S_TO_YMD.BorderColor = System.Drawing.Color.Silver
        Me.S_TO_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_TO_YMD.DefVal = ""
        Me.S_TO_YMD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_TO_YMD.IconVisible = True
        Me.S_TO_YMD.IsDataStateAware = True
        Me.S_TO_YMD.Location = New System.Drawing.Point(204, 5)
        Me.S_TO_YMD.Name = "S_TO_YMD"
        Me.S_TO_YMD.NextFocus = "S_DEPT_CD"
        Me.S_TO_YMD.Size = New System.Drawing.Size(91, 23)
        Me.S_TO_YMD.TabIndex = 2
        Me.Localizer1.SetWordID(Me.S_TO_YMD, "")
        '
        'S_FM_YMD
        '
        Me.S_FM_YMD.BorderColor = System.Drawing.Color.Silver
        Me.S_FM_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_FM_YMD.DefVal = ""
        Me.S_FM_YMD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_FM_YMD.IconVisible = True
        Me.S_FM_YMD.IsDataStateAware = True
        Me.S_FM_YMD.Location = New System.Drawing.Point(100, 5)
        Me.S_FM_YMD.Name = "S_FM_YMD"
        Me.S_FM_YMD.NextFocus = "S_TO_YMD"
        Me.S_FM_YMD.Size = New System.Drawing.Size(91, 23)
        Me.S_FM_YMD.TabIndex = 1
        Me.Localizer1.SetWordID(Me.S_FM_YMD, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.S_TO_YM)
        Me.PanelControl2.Controls.Add(Me.S_FM_YM)
        Me.PanelControl2.Controls.Add(Me.S_USR_ID_NM)
        Me.PanelControl2.Controls.Add(Me.S_USR_ID)
        Me.PanelControl2.Controls.Add(Me.S_CUST_NM)
        Me.PanelControl2.Controls.Add(Me.S_PROC_TYPE)
        Me.PanelControl2.Controls.Add(Me.S_DEPT_CD)
        Me.PanelControl2.Controls.Add(Me.S_DATE_TYPE)
        Me.PanelControl2.Controls.Add(Me.lbl_S_PROC_TYPE)
        Me.PanelControl2.Controls.Add(Me.lbl_S_USR_ID)
        Me.PanelControl2.Controls.Add(Me.lbl_S_CUST_NM)
        Me.PanelControl2.Controls.Add(Me.lbl_S_DEPT_CD)
        Me.PanelControl2.Controls.Add(Me.S_TO_YMD)
        Me.PanelControl2.Controls.Add(Me.S_FM_YMD)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Location = New System.Drawing.Point(3, 38)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1203, 64)
        Me.PanelControl2.TabIndex = 297
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'S_TO_YM
        '
        Me.S_TO_YM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_TO_YM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_TO_YM.Location = New System.Drawing.Point(259, 5)
        Me.S_TO_YM.Mask = "0000-09"
        Me.S_TO_YM.Name = "S_TO_YM"
        Me.S_TO_YM.Size = New System.Drawing.Size(14, 23)
        Me.S_TO_YM.TabIndex = 112
        Me.S_TO_YM.Visible = False
        Me.Localizer1.SetWordID(Me.S_TO_YM, "-")
        '
        'S_FM_YM
        '
        Me.S_FM_YM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_FM_YM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_FM_YM.Location = New System.Drawing.Point(155, 5)
        Me.S_FM_YM.Mask = "0000-09"
        Me.S_FM_YM.Name = "S_FM_YM"
        Me.S_FM_YM.Size = New System.Drawing.Size(14, 23)
        Me.S_FM_YM.TabIndex = 111
        Me.S_FM_YM.Visible = False
        Me.Localizer1.SetWordID(Me.S_FM_YM, "-")
        '
        'S_USR_ID_NM
        '
        Me.S_USR_ID_NM.AutoEllipsis = True
        Me.S_USR_ID_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_USR_ID_NM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_USR_ID_NM.LabelFor = Nothing
        Me.S_USR_ID_NM.Location = New System.Drawing.Point(942, 5)
        Me.S_USR_ID_NM.Name = "S_USR_ID_NM"
        Me.S_USR_ID_NM.Size = New System.Drawing.Size(134, 23)
        Me.S_USR_ID_NM.TabIndex = 10034
        Me.S_USR_ID_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'S_USR_ID
        '
        Me.S_USR_ID.AlwaysSetDisplayParams = True
        Me.S_USR_ID.AutoSuggestion = False
        Me.S_USR_ID.BorderColor = System.Drawing.Color.Silver
        Me.S_USR_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_USR_ID.CodeType = "YJIT.CodeService.User"
        Me.S_USR_ID.DataParams = ""
        Me.S_USR_ID.DefVal = ""
        Me.S_USR_ID.DisplayParams = "Code:@S_USR_ID,Name:@S_USR_ID_NM"
        Me.S_USR_ID.EditPopup = ""
        Me.S_USR_ID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_USR_ID.IconVisible = True
        Me.S_USR_ID.IsDataStateAware = True
        Me.S_USR_ID.KeepIntegrity = True
        Me.S_USR_ID.Location = New System.Drawing.Point(861, 5)
        Me.S_USR_ID.Name = "S_USR_ID"
        Me.S_USR_ID.NextFocus = "S_PROC_TYPE"
        Me.S_USR_ID.SearchPopup = "CodeMaster"
        Me.S_USR_ID.Size = New System.Drawing.Size(79, 23)
        Me.S_USR_ID.SuppressValidateCode = False
        Me.S_USR_ID.TabIndex = 5
        Me.S_USR_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_USR_ID.ValidateKeys = "KEY:@S_USR_ID"
        '
        'S_CUST_NM
        '
        Me.S_CUST_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_CUST_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_CUST_NM.DefVal = ""
        Me.S_CUST_NM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_CUST_NM.IsDataStateAware = True
        Me.S_CUST_NM.Location = New System.Drawing.Point(603, 5)
        Me.S_CUST_NM.Name = "S_CUST_NM"
        Me.S_CUST_NM.NextFocus = "S_USR_ID"
        Me.S_CUST_NM.Size = New System.Drawing.Size(160, 23)
        Me.S_CUST_NM.TabIndex = 4
        Me.S_CUST_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'S_PROC_TYPE
        '
        Me.S_PROC_TYPE.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_PROC_TYPE.ColumnWidths = ""
        Me.S_PROC_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_PROC_TYPE.DataParams = "GroupCode:'P03',NameType:''"
        Me.S_PROC_TYPE.DefVal = ""
        Me.S_PROC_TYPE.DisplayMember = "NAME"
        Me.S_PROC_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_PROC_TYPE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_PROC_TYPE.FormattingEnabled = True
        Me.S_PROC_TYPE.IsDataStateAware = True
        Me.S_PROC_TYPE.ItemDelimiter = ","
        Me.S_PROC_TYPE.ItemTextList = ""
        Me.S_PROC_TYPE.ItemValueList = ""
        Me.S_PROC_TYPE.KeepIntegrity = True
        Me.S_PROC_TYPE.Location = New System.Drawing.Point(100, 34)
        Me.S_PROC_TYPE.Name = "S_PROC_TYPE"
        Me.S_PROC_TYPE.NextFocus = "btnSearch"
        Me.S_PROC_TYPE.NullText = "--Select--"
        Me.S_PROC_TYPE.SearchKeys = ""
        Me.S_PROC_TYPE.Size = New System.Drawing.Size(91, 23)
        Me.S_PROC_TYPE.TabIndex = 3
        Me.S_PROC_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_PROC_TYPE.ValueMember = "CODE"
        '
        'lbl_S_PROC_TYPE
        '
        Me.lbl_S_PROC_TYPE.AutoSize = True
        Me.lbl_S_PROC_TYPE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_S_PROC_TYPE.LabelFor = Nothing
        Me.lbl_S_PROC_TYPE.Location = New System.Drawing.Point(43, 38)
        Me.lbl_S_PROC_TYPE.Name = "lbl_S_PROC_TYPE"
        Me.lbl_S_PROC_TYPE.Size = New System.Drawing.Size(55, 15)
        Me.lbl_S_PROC_TYPE.TabIndex = 277
        Me.lbl_S_PROC_TYPE.Text = "영업상태"
        Me.lbl_S_PROC_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_PROC_TYPE, "영업상태")
        '
        'lbl_S_USR_ID
        '
        Me.lbl_S_USR_ID.AutoSize = True
        Me.lbl_S_USR_ID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_S_USR_ID.LabelFor = Nothing
        Me.lbl_S_USR_ID.Location = New System.Drawing.Point(812, 9)
        Me.lbl_S_USR_ID.Name = "lbl_S_USR_ID"
        Me.lbl_S_USR_ID.Size = New System.Drawing.Size(43, 15)
        Me.lbl_S_USR_ID.TabIndex = 277
        Me.lbl_S_USR_ID.Text = "담당자"
        Me.lbl_S_USR_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_USR_ID, "담당자")
        '
        'lbl_S_CUST_NM
        '
        Me.lbl_S_CUST_NM.AutoSize = True
        Me.lbl_S_CUST_NM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_S_CUST_NM.LabelFor = Nothing
        Me.lbl_S_CUST_NM.Location = New System.Drawing.Point(556, 9)
        Me.lbl_S_CUST_NM.Name = "lbl_S_CUST_NM"
        Me.lbl_S_CUST_NM.Size = New System.Drawing.Size(43, 15)
        Me.lbl_S_CUST_NM.TabIndex = 277
        Me.lbl_S_CUST_NM.Text = "상호명"
        Me.lbl_S_CUST_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_CUST_NM, "상호명")
        '
        'xtcMAIN
        '
        Me.xtcMAIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcMAIN.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtcMAIN.Appearance.Options.UseFont = True
        Me.xtcMAIN.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtcMAIN.AppearancePage.Header.Options.UseFont = True
        Me.xtcMAIN.Location = New System.Drawing.Point(3, 108)
        Me.xtcMAIN.Name = "xtcMAIN"
        Me.xtcMAIN.SelectedTabPage = Me.xtpInput
        Me.xtcMAIN.Size = New System.Drawing.Size(1203, 659)
        Me.xtcMAIN.TabIndex = 304
        Me.xtcMAIN.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpReport, Me.xtpInput})
        Me.Localizer1.SetWordID(Me.xtcMAIN, "")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnSearch, "조회(&A)")
        Me.Localizer1.SetWordID(Me.btnSave, "저장(&S)")
        Me.Localizer1.SetWordID(Me.lbl_S_DEPT_CD, "부서")
        Me.Localizer1.SetWordID(Me.Label2, "~")
        Me.Localizer1.SetWordID(Me.xtpReport, "영업진행 집계현황")
        Me.Localizer1.SetWordID(Me.splitRight, "SplitContainerControl2")
        Me.Localizer1.SetWordID(Me.WG5, "")
        Me.Localizer1.SetWordID(Me.GV5_CODE, "순증")
        Me.Localizer1.SetWordID(Me.GV5_VALUE, "건수/금액")
        Me.Localizer1.SetWordID(Me.WG6, "")
        Me.Localizer1.SetWordID(Me.GV6_CODE, "담당자")
        Me.Localizer1.SetWordID(Me.GV6_VALUE, "계약")
        Me.Localizer1.SetWordID(Me.splitLeft, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.WG2_USR_ID, "담당자")
        Me.Localizer1.SetWordID(Me.WG2_USR_CNT, "계약")
        Me.Localizer1.SetWordID(Me.WG3, "")
        Me.Localizer1.SetWordID(Me.GV3_CTRT_TYPE, "구분")
        Me.Localizer1.SetWordID(Me.GV3_CTRT_CNT, "계약")
        Me.Localizer1.SetWordID(Me.WG4, "")
        Me.Localizer1.SetWordID(Me.GV4_USR_ID, "담당자")
        Me.Localizer1.SetWordID(Me.GV4_CTRT_CNT, "총계약건")
        Me.Localizer1.SetWordID(Me.GV4_ORD_AMT, "① 총계약(SI)")
        Me.Localizer1.SetWordID(Me.GV4_CTRT_AMT, "② 설치비")
        Me.Localizer1.SetWordID(Me.GV4_MATN_AMT, "③ 월청구")
        Me.Localizer1.SetWordID(Me.GV4_COST_AMT, "④ 수행원가")
        Me.Localizer1.SetWordID(Me.GV4_PROFIT_AMT, "⑤ 공여이익(①+②+④)")
        Me.Localizer1.SetWordID(Me.GV4_PROFIT_RATE, "⑥ 이익률")
        Me.Localizer1.SetWordID(Me.GV1_BIZ_TYPE, "구분")
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "상호")
        Me.Localizer1.SetWordID(Me.GV1_ITEM_NM, "품목")
        Me.Localizer1.SetWordID(Me.GV1_ORD_AMT, "SI수주금액")
        Me.Localizer1.SetWordID(Me.GV1_CTRT_AMT, "설치비")
        Me.Localizer1.SetWordID(Me.GV1_MATN_AMT, "월청구")
        Me.Localizer1.SetWordID(Me.GV1_COST_AMT, "수행원가")
        Me.Localizer1.SetWordID(Me.GV1_PROFIT_AMT, "공여이익")
        Me.Localizer1.SetWordID(Me.GV1_CMPT_RATE, "확률")
        Me.Localizer1.SetWordID(Me.GV1_PROC_TYPE, "영업상태")
        Me.Localizer1.SetWordID(Me.GV1_CTRT_YMD, "계약일")
        Me.Localizer1.SetWordID(Me.GV1_BIZ_COND, "구분상세")
        Me.Localizer1.SetWordID(Me.GV1_TAX_START_MONTH, "최초청구월")
        Me.Localizer1.SetWordID(Me.GV1_CTRT_RCV_YN, "계약서")
        Me.Localizer1.SetWordID(Me.GV1_SETUP_TAX_YN, "설치비청구 여부")
        Me.Localizer1.SetWordID(Me.GV1_MONTH_TAX_YN, "월청구 여부")
        Me.Localizer1.SetWordID(Me.GV1_OUTSTAND_AMT, "청구잔액")
        Me.Localizer1.SetWordID(Me.GV1_JOIN_TYPE, "영업구분")
        Me.Localizer1.SetWordID(Me.GV1_JOIN_ROUTE, "유입경로")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "영업상담 내용")
        Me.Localizer1.SetWordID(Me.GV1_PIC_NM, "고객담당자")
        Me.Localizer1.SetWordID(Me.GV1_PIC_MOBILE, "핸드폰")
        Me.Localizer1.SetWordID(Me.GV1_PIC_EMAIL, "이메일")
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "입력자")
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "입력일자")
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "수정자")
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "수정일자")
        Me.Localizer1.SetWordID(Me.xtpInput, "영업진행 입력")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV1_DEPT_CD, "부서")
        Me.Localizer1.SetWordID(Me.GV1_BIZ_YMD, "*영업시작일")
        Me.Localizer1.SetWordID(Me.GV1_USR_ID, "*담당자")
        Me.Localizer1.SetWordID(Me.GV1_PROD_CD, "*상품")
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "*상호명")
        Me.Localizer1.SetWordID(Me.GV1_IDC_AMT, "DB임대")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.MODIFY_YN, "N")
        Me.Localizer1.SetWordID(Me.S_DEPT_CD, "--Select--")
        Me.Localizer1.SetWordID(Me.S_DATE_TYPE, "영업시작일")
        Me.Localizer1.SetWordID(Me.S_TO_YMD, "")
        Me.Localizer1.SetWordID(Me.S_FM_YMD, "")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.S_TO_YM, "-")
        Me.Localizer1.SetWordID(Me.S_FM_YM, "-")
        Me.Localizer1.SetWordID(Me.S_USR_ID, "")
        Me.Localizer1.SetWordID(Me.S_CUST_NM, "")
        Me.Localizer1.SetWordID(Me.S_PROC_TYPE, "--Select--")
        Me.Localizer1.SetWordID(Me.lbl_S_PROC_TYPE, "영업상태")
        Me.Localizer1.SetWordID(Me.lbl_S_USR_ID, "담당자")
        Me.Localizer1.SetWordID(Me.lbl_S_CUST_NM, "상호명")
        Me.Localizer1.SetWordID(Me.xtcMAIN, "")
        '
        'CrmProjectMgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 766)
        Me.Controls.Add(Me.xtcMAIN)
        Me.Controls.Add(Me.palAutoButton)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "CrmProjectMgt"
        Me.Text = "영업진행현황"
        Me.Localizer1.SetWordID(Me, "영업진행현황")
        Me.xtpReport.ResumeLayout(False)
        CType(Me.splitRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitRight.ResumeLayout(False)
        CType(Me.WG5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitLeft.ResumeLayout(False)
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpText_100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpNumeric_N0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCTRT_YMD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpTAX_START_MONTH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMemo_400, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpText_50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpText_30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpText_64, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpInput.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.palAutoButton.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.xtcMAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcMAIN.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents S_DEPT_CD As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents S_DATE_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents lbl_S_DEPT_CD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_TO_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents S_FM_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents xtpReport As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_BIZ_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROD_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BIZ_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_ITEM_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_ORD_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CTRT_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MATN_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COST_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROFIT_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CMPT_RATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CTRT_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BIZ_COND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TAX_START_MONTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CTRT_RCV_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MONTH_TAX_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_OUTSTAND_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_JOIN_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_JOIN_ROUTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PIC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtcMAIN As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GV1_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PIC_MOBILE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PIC_EMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpNumeric_N0 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents MODIFY_YN As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents GV1_SETUP_TAX_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents rpMemo_400 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents rpText_50 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpText_30 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpText_64 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpText_100 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents WG3 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV3_CTRT_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_CTRT_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WG2_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG2_USR_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG4 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV4_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_MATN_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_ORD_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_CTRT_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_COST_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_PROFIT_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_PROFIT_RATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG5 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV5_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV5_VALUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG6 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV6_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV6_VALUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DEPT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_CTRT_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents splitRight As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents splitLeft As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GV1_IDC_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCTRT_YMD As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lbl_S_PROC_TYPE As UI.SCControls.Label
    Friend WithEvents lbl_S_USR_ID As UI.SCControls.Label
    Friend WithEvents lbl_S_CUST_NM As UI.SCControls.Label
    Friend WithEvents S_CUST_NM As UI.SCControls.TextBox
    Private WithEvents S_USR_ID As UI.SCControls.CodeBox
    Friend WithEvents S_USR_ID_NM As UI.SCControls.TextLabel
    Friend WithEvents S_PROC_TYPE As UI.SCControls.ComboBox
    Friend WithEvents S_TO_YM As MaskedTextBox
    Friend WithEvents S_FM_YM As MaskedTextBox
    Friend WithEvents rpTAX_START_MONTH As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
