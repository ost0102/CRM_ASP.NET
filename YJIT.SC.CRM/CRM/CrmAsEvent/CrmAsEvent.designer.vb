<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmAsEvent
    Inherits YJIT.SC.UI.SCView

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmAsEvent))
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.Label18 = New YJIT.SC.UI.SCControls.Label()
        Me.REQ_SVC = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_PROC_TYPE = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Label20 = New YJIT.SC.UI.SCControls.Label()
        Me.S_DATE_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_TO_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label32 = New YJIT.SC.UI.SCControls.Label()
        Me.S_FM_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.TextBox1 = New YJIT.SC.UI.SCControls.TextBox()
        Me.TextBox2 = New YJIT.SC.UI.SCControls.TextBox()
        Me.Button1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_CHK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RpCheckBox = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV1_REQ_SVC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CONTENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CMPT_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.RMK = New YJIT.SC.UI.SCControls.TextBox()
        Me.CMPT_RMK = New YJIT.SC.UI.SCControls.TextBox()
        Me.SaveEvent = New YJIT.SC.UI.SCControls.Button()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.S_PROC_TYPE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMemoExEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        Me.Localizer1.SetWordID(Me.Label18, "업무구분1")
        Me.Localizer1.SetWordID(Me.REQ_SVC, "")
        Me.Localizer1.SetWordID(Me.S_PROC_TYPE, "")
        Me.Localizer1.SetWordID(Me.Label20, "상태")
        Me.Localizer1.SetWordID(Me.S_DATE_TYPE, "요청일자")
        Me.Localizer1.SetWordID(Me.S_TO_YMD, "")
        Me.Localizer1.SetWordID(Me.Label32, "~")
        Me.Localizer1.SetWordID(Me.S_FM_YMD, "")
        Me.Localizer1.SetWordID(Me.TextBox1, "")
        Me.Localizer1.SetWordID(Me.TextBox2, "")
        Me.Localizer1.SetWordID(Me.Button1, "저장(&S)")
        Me.Localizer1.SetWordID(Me.btnSearch, "조회(&A)")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_CHK, "V")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC_NM, "업무구분1")
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "거래처 명")
        Me.Localizer1.SetWordID(Me.GV1_REQ_DATE, "요청날짜")
        Me.Localizer1.SetWordID(Me.GV1_REQ_USR, "요청자")
        Me.Localizer1.SetWordID(Me.GV1_PROC_TYPE, "상태")
        Me.Localizer1.SetWordID(Me.GV1_CONTENT, "고객요청사항")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "조치사항")
        Me.Localizer1.SetWordID(Me.GV1_CMPT_RMK, "답변")
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "연락처")
        Me.Localizer1.SetWordID(Me.Label6, "조치사항")
        Me.Localizer1.SetWordID(Me.Label1, "고객지원 답변")
        Me.Localizer1.SetWordID(Me.RMK, "")
        Me.Localizer1.SetWordID(Me.CMPT_RMK, "")
        Me.Localizer1.SetWordID(Me.SaveEvent, "일괄적용")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Controls.Add(Me.Label18)
        Me.PanelControl4.Controls.Add(Me.REQ_SVC)
        Me.PanelControl4.Controls.Add(Me.S_PROC_TYPE)
        Me.PanelControl4.Controls.Add(Me.Label20)
        Me.PanelControl4.Controls.Add(Me.S_DATE_TYPE)
        Me.PanelControl4.Controls.Add(Me.S_TO_YMD)
        Me.PanelControl4.Controls.Add(Me.Label32)
        Me.PanelControl4.Controls.Add(Me.S_FM_YMD)
        Me.PanelControl4.Location = New System.Drawing.Point(5, 41)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1306, 33)
        Me.PanelControl4.TabIndex = 297
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.LabelFor = Nothing
        Me.Label18.Location = New System.Drawing.Point(350, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 14)
        Me.Label18.TabIndex = 308
        Me.Label18.Text = "업무구분1"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label18, "")
        '
        'REQ_SVC
        '
        Me.REQ_SVC.CodeType = ""
        Me.REQ_SVC.ColumnWidths = ""
        Me.REQ_SVC.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.REQ_SVC.DataParams = "GroupCode:'T02',NameType:'',DeptCode:@DEPT_CD"
        Me.REQ_SVC.DefVal = "B"
        Me.REQ_SVC.DisplayMember = "NAME"
        Me.REQ_SVC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.REQ_SVC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.REQ_SVC.FormattingEnabled = True
        Me.REQ_SVC.IsDataStateAware = True
        Me.REQ_SVC.ItemDelimiter = ","
        Me.REQ_SVC.ItemTextList = ""
        Me.REQ_SVC.ItemValueList = ""
        Me.REQ_SVC.KeepIntegrity = True
        Me.REQ_SVC.Location = New System.Drawing.Point(418, 6)
        Me.REQ_SVC.Name = "REQ_SVC"
        Me.REQ_SVC.NextFocus = "REQ_SVC2"
        Me.REQ_SVC.NullText = ""
        Me.REQ_SVC.SearchKeys = ""
        Me.REQ_SVC.Size = New System.Drawing.Size(119, 23)
        Me.REQ_SVC.TabIndex = 307
        Me.REQ_SVC.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.REQ_SVC.ValueMember = "CODE"
        '
        'S_PROC_TYPE
        '
        Me.S_PROC_TYPE.Location = New System.Drawing.Point(634, 7)
        Me.S_PROC_TYPE.Name = "S_PROC_TYPE"
        Me.S_PROC_TYPE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.S_PROC_TYPE.Size = New System.Drawing.Size(117, 21)
        Me.S_PROC_TYPE.TabIndex = 3
        Me.Localizer1.SetWordID(Me.S_PROC_TYPE, "")
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.LabelFor = Nothing
        Me.Label20.Location = New System.Drawing.Point(601, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 14)
        Me.Label20.TabIndex = 10018
        Me.Label20.Text = "상태"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label20, "")
        '
        'S_DATE_TYPE
        '
        Me.S_DATE_TYPE.CodeType = ""
        Me.S_DATE_TYPE.ColumnWidths = ""
        Me.S_DATE_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_DATE_TYPE.DataParams = ""
        Me.S_DATE_TYPE.DefVal = "R"
        Me.S_DATE_TYPE.DisplayMember = "NAME"
        Me.S_DATE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DATE_TYPE.FormattingEnabled = True
        Me.S_DATE_TYPE.IsDataStateAware = True
        Me.S_DATE_TYPE.ItemDelimiter = ","
        Me.S_DATE_TYPE.ItemTextList = "요청일자,완료일자"
        Me.S_DATE_TYPE.ItemValueList = "R,C"
        Me.S_DATE_TYPE.KeepIntegrity = True
        Me.S_DATE_TYPE.Location = New System.Drawing.Point(31, 6)
        Me.S_DATE_TYPE.Name = "S_DATE_TYPE"
        Me.S_DATE_TYPE.NextFocus = "S_FM_YMD"
        Me.S_DATE_TYPE.NullText = ""
        Me.S_DATE_TYPE.SearchKeys = ""
        Me.S_DATE_TYPE.Size = New System.Drawing.Size(74, 22)
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
        Me.S_TO_YMD.Location = New System.Drawing.Point(210, 6)
        Me.S_TO_YMD.Name = "S_TO_YMD"
        Me.S_TO_YMD.NextFocus = "S_PROC_TYPE"
        Me.S_TO_YMD.Size = New System.Drawing.Size(91, 23)
        Me.S_TO_YMD.TabIndex = 2
        Me.Localizer1.SetWordID(Me.S_TO_YMD, "")
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.LabelFor = Nothing
        Me.Label32.Location = New System.Drawing.Point(197, 10)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 14)
        Me.Label32.TabIndex = 305
        Me.Label32.Text = "~"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Localizer1.SetWordID(Me.Label32, "~")
        '
        'S_FM_YMD
        '
        Me.S_FM_YMD.BorderColor = System.Drawing.Color.Silver
        Me.S_FM_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_FM_YMD.DefVal = ""
        Me.S_FM_YMD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_FM_YMD.IconVisible = True
        Me.S_FM_YMD.IsDataStateAware = True
        Me.S_FM_YMD.Location = New System.Drawing.Point(106, 6)
        Me.S_FM_YMD.Name = "S_FM_YMD"
        Me.S_FM_YMD.NextFocus = "S_TO_YMD"
        Me.S_FM_YMD.Size = New System.Drawing.Size(91, 23)
        Me.S_FM_YMD.TabIndex = 1
        Me.Localizer1.SetWordID(Me.S_FM_YMD, "")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.BorderColor = System.Drawing.Color.Silver
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DefVal = ""
        Me.TextBox1.IsDataStateAware = True
        Me.TextBox1.Location = New System.Drawing.Point(117, 4)
        Me.TextBox1.MaxLength = 30
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NextFocus = "TEL_NO"
        Me.TextBox1.Size = New System.Drawing.Size(618, 21)
        Me.TextBox1.TabIndex = 231
        Me.TextBox1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.BorderColor = System.Drawing.Color.Silver
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.DefVal = ""
        Me.TextBox2.IsDataStateAware = True
        Me.TextBox2.Location = New System.Drawing.Point(199, 131)
        Me.TextBox2.MaxLength = 30
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NextFocus = "TEL_NO"
        Me.TextBox2.Size = New System.Drawing.Size(145, 21)
        Me.TextBox2.TabIndex = 234
        Me.TextBox2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1227, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "저장(&S)"
        Me.Localizer1.SetWordID(Me.Button1, "")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1147, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 25)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "조회(&A)"
        Me.Localizer1.SetWordID(Me.btnSearch, "")
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
        Me.WG1.Location = New System.Drawing.Point(5, 153)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RpCheckBox, Me.rpMemoExEdit})
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(1306, 563)
        Me.WG1.TabIndex = 302
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.BestFitMaxRowCount = 10
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_CHK, Me.GV1_REQ_SVC_NM, Me.GV1_CUST_NM, Me.GV1_REQ_DATE, Me.GV1_REQ_USR, Me.GV1_PROC_TYPE, Me.GV1_CONTENT, Me.GV1_RMK, Me.GV1_CMPT_RMK, Me.GV1_TEL_NO})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsCustomization.AllowRowSizing = True
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.EnableAppearanceEvenRow = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.RowHeight = 10
        Me.GV1.ViewCaption = " 고객 리스트"
        '
        'GV1_CHK
        '
        Me.GV1_CHK.Caption = "V"
        Me.GV1_CHK.ColumnEdit = Me.RpCheckBox
        Me.GV1_CHK.FieldName = "CHK"
        Me.GV1_CHK.Name = "GV1_CHK"
        Me.GV1_CHK.Visible = True
        Me.GV1_CHK.VisibleIndex = 0
        Me.GV1_CHK.Width = 20
        Me.Localizer1.SetWordID(Me.GV1_CHK, "")
        '
        'RpCheckBox
        '
        Me.RpCheckBox.AutoHeight = False
        Me.RpCheckBox.Name = "RpCheckBox"
        Me.RpCheckBox.ValueChecked = "Y"
        Me.RpCheckBox.ValueUnchecked = "N"
        '
        'GV1_REQ_SVC_NM
        '
        Me.GV1_REQ_SVC_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_SVC_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_REQ_SVC_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_SVC_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_SVC_NM.Caption = "업무구분1"
        Me.GV1_REQ_SVC_NM.FieldName = "REQ_SVC_NM"
        Me.GV1_REQ_SVC_NM.Name = "GV1_REQ_SVC_NM"
        Me.GV1_REQ_SVC_NM.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_SVC_NM.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_SVC_NM.Visible = True
        Me.GV1_REQ_SVC_NM.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC_NM, "업무구분1")
        '
        'GV1_CUST_NM
        '
        Me.GV1_CUST_NM.Caption = "거래처 명"
        Me.GV1_CUST_NM.FieldName = "CUST_NM"
        Me.GV1_CUST_NM.Name = "GV1_CUST_NM"
        Me.GV1_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_NM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV1_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CUST_NM.Visible = True
        Me.GV1_CUST_NM.VisibleIndex = 2
        Me.GV1_CUST_NM.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "")
        '
        'GV1_REQ_DATE
        '
        Me.GV1_REQ_DATE.Caption = "요청날짜"
        Me.GV1_REQ_DATE.FieldName = "REQ_DATE"
        Me.GV1_REQ_DATE.Name = "GV1_REQ_DATE"
        Me.GV1_REQ_DATE.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_DATE.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_DATE.Visible = True
        Me.GV1_REQ_DATE.VisibleIndex = 5
        Me.GV1_REQ_DATE.Width = 110
        Me.Localizer1.SetWordID(Me.GV1_REQ_DATE, "")
        '
        'GV1_REQ_USR
        '
        Me.GV1_REQ_USR.Caption = "요청자"
        Me.GV1_REQ_USR.FieldName = "REQ_USR"
        Me.GV1_REQ_USR.Name = "GV1_REQ_USR"
        Me.GV1_REQ_USR.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_USR.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_REQ_USR.Visible = True
        Me.GV1_REQ_USR.VisibleIndex = 3
        Me.GV1_REQ_USR.Width = 64
        Me.Localizer1.SetWordID(Me.GV1_REQ_USR, "")
        '
        'GV1_PROC_TYPE
        '
        Me.GV1_PROC_TYPE.Caption = "상태"
        Me.GV1_PROC_TYPE.FieldName = "PROC_TYPE"
        Me.GV1_PROC_TYPE.Name = "GV1_PROC_TYPE"
        Me.GV1_PROC_TYPE.OptionsColumn.AllowEdit = False
        Me.GV1_PROC_TYPE.OptionsColumn.ReadOnly = True
        Me.GV1_PROC_TYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PROC_TYPE.Visible = True
        Me.GV1_PROC_TYPE.VisibleIndex = 6
        Me.GV1_PROC_TYPE.Width = 61
        Me.Localizer1.SetWordID(Me.GV1_PROC_TYPE, "")
        '
        'GV1_CONTENT
        '
        Me.GV1_CONTENT.Caption = "고객요청사항"
        Me.GV1_CONTENT.ColumnEdit = Me.rpMemoExEdit
        Me.GV1_CONTENT.CustomizationCaption = "RepositoryItemMemoEdit1"
        Me.GV1_CONTENT.FieldName = "CONTENT"
        Me.GV1_CONTENT.Name = "GV1_CONTENT"
        Me.GV1_CONTENT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CONTENT.Visible = True
        Me.GV1_CONTENT.VisibleIndex = 7
        Me.GV1_CONTENT.Width = 240
        Me.Localizer1.SetWordID(Me.GV1_CONTENT, "")
        '
        'rpMemoExEdit
        '
        Me.rpMemoExEdit.AutoHeight = False
        Me.rpMemoExEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpMemoExEdit.Name = "rpMemoExEdit"
        Me.rpMemoExEdit.ShowIcon = False
        '
        'GV1_RMK
        '
        Me.GV1_RMK.Caption = "조치사항"
        Me.GV1_RMK.ColumnEdit = Me.rpMemoExEdit
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 8
        Me.GV1_RMK.Width = 240
        Me.Localizer1.SetWordID(Me.GV1_RMK, "")
        '
        'GV1_CMPT_RMK
        '
        Me.GV1_CMPT_RMK.Caption = "답변"
        Me.GV1_CMPT_RMK.ColumnEdit = Me.rpMemoExEdit
        Me.GV1_CMPT_RMK.FieldName = "CMPT_RMK"
        Me.GV1_CMPT_RMK.Name = "GV1_CMPT_RMK"
        Me.GV1_CMPT_RMK.Visible = True
        Me.GV1_CMPT_RMK.VisibleIndex = 9
        Me.GV1_CMPT_RMK.Width = 240
        Me.Localizer1.SetWordID(Me.GV1_CMPT_RMK, "")
        '
        'GV1_TEL_NO
        '
        Me.GV1_TEL_NO.Caption = "연락처"
        Me.GV1_TEL_NO.FieldName = "TEL_NO"
        Me.GV1_TEL_NO.Name = "GV1_TEL_NO"
        Me.GV1_TEL_NO.OptionsColumn.AllowEdit = False
        Me.GV1_TEL_NO.OptionsColumn.ReadOnly = True
        Me.GV1_TEL_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_TEL_NO.Visible = True
        Me.GV1_TEL_NO.VisibleIndex = 4
        Me.GV1_TEL_NO.Width = 96
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(30, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "조치사항"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label6, "조치사항")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(374, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 14)
        Me.Label1.TabIndex = 10023
        Me.Label1.Text = "고객지원 답변"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "고객지원 답변")
        '
        'RMK
        '
        Me.RMK.BackColor = System.Drawing.SystemColors.Window
        Me.RMK.BorderColor = System.Drawing.Color.Silver
        Me.RMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RMK.DefVal = ""
        Me.RMK.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RMK.IsDataStateAware = True
        Me.RMK.Location = New System.Drawing.Point(91, 8)
        Me.RMK.MaxLength = 0
        Me.RMK.Multiline = True
        Me.RMK.Name = "RMK"
        Me.RMK.NextFocus = "CMPT_RMK"
        Me.RMK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RMK.Size = New System.Drawing.Size(275, 49)
        Me.RMK.TabIndex = 10
        Me.RMK.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'CMPT_RMK
        '
        Me.CMPT_RMK.BackColor = System.Drawing.SystemColors.Window
        Me.CMPT_RMK.BorderColor = System.Drawing.Color.Silver
        Me.CMPT_RMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CMPT_RMK.DefVal = ""
        Me.CMPT_RMK.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CMPT_RMK.IsDataStateAware = True
        Me.CMPT_RMK.Location = New System.Drawing.Point(463, 8)
        Me.CMPT_RMK.MaxLength = 0
        Me.CMPT_RMK.Multiline = True
        Me.CMPT_RMK.Name = "CMPT_RMK"
        Me.CMPT_RMK.NextFocus = "SaveEvent"
        Me.CMPT_RMK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CMPT_RMK.Size = New System.Drawing.Size(275, 49)
        Me.CMPT_RMK.TabIndex = 11
        Me.CMPT_RMK.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'SaveEvent
        '
        Me.SaveEvent.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.SaveEvent.Image = CType(resources.GetObject("SaveEvent.Image"), System.Drawing.Image)
        Me.SaveEvent.Location = New System.Drawing.Point(744, 8)
        Me.SaveEvent.Name = "SaveEvent"
        Me.SaveEvent.Size = New System.Drawing.Size(78, 25)
        Me.SaveEvent.TabIndex = 12
        Me.SaveEvent.Text = "일괄적용"
        Me.Localizer1.SetWordID(Me.SaveEvent, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.SaveEvent)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.CMPT_RMK)
        Me.PanelControl2.Controls.Add(Me.RMK)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(5, 80)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1306, 67)
        Me.PanelControl2.TabIndex = 306
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.Button1)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(5, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1306, 32)
        Me.palAutoButton.TabIndex = 278
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'CrmAsEvent
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1318, 722)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.WG1)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CrmAsEvent"
        Me.Text = "일괄완료작업"
        Me.Localizer1.SetWordID(Me, "일괄완료작업")
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.S_PROC_TYPE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMemoExEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents TextBox2 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents TextBox1 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Public WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents S_DATE_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents S_TO_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label32 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_FM_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents S_PROC_TYPE As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Label20 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Button1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents Label6 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Public WithEvents RMK As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents CMPT_RMK As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents SaveEvent As YJIT.SC.UI.SCControls.Button
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GV1_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CHK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RpCheckBox As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV1_REQ_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CONTENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CMPT_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents rpMemoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents Label18 As YJIT.SC.UI.SCControls.Label
    Public WithEvents REQ_SVC As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GV1_REQ_SVC_NM As DevExpress.XtraGrid.Columns.GridColumn
End Class
