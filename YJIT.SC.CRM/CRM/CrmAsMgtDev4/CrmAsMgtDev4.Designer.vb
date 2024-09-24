<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmAsMgtDev4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmAsMgtDev4))
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.S_SEARCH_KEY = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.SCREEN = New YJIT.SC.UI.SCControls.TextBox()
        Me.INCLUDE_EXCEPT = New YJIT.SC.UI.SCControls.CheckBox()
        Me.btnRefresh = New YJIT.SC.UI.SCControls.Button()
        Me.REF_TIME = New YJIT.SC.UI.SCControls.ComboBox()
        Me.lblTime = New YJIT.SC.UI.SCControls.Label()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.Label32 = New YJIT.SC.UI.SCControls.Label()
        Me.S_TO_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.S_FM_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PRIORITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_HM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CONTENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WORK_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PRAR_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CMPT_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_USR_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FILE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DELAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DELAY_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_SVC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_SVC2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_SVC3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEV_CMPT_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEV_ERR_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SHARE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEV_ERR_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RANK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit2 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.S_WORK_AREA = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label5 = New YJIT.SC.UI.SCControls.Label()
        Me.S_WORK_USR = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.S_PROC_TYPE = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.MainSplit = New DevExpress.XtraEditors.SplitContainerControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.WG3 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV3_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_PRIORITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_REQ_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_REQ_HM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_REQ_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_CONTENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_PROC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_INS_USR_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_REQ_SVC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_SYS_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_SVC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_EXCEPT_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_DEV_PIC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ModifySplit = New DevExpress.XtraEditors.SplitContainerControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.FileInputSplit = New DevExpress.XtraEditors.SplitContainerControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.OhterDeptListPanel = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.SAVE_CNT = New YJIT.SC.UI.SCControls.TextBox()
        Me.RANK_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.INS_USR_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.CmdAssign = New YJIT.SC.UI.SCControls.Button()
        Me.MNGT_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label8 = New YJIT.SC.UI.SCControls.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.REQ_USR = New YJIT.SC.UI.SCControls.TextLabel()
        Me.Label26 = New YJIT.SC.UI.SCControls.Label()
        Me.PRIORITY = New YJIT.SC.UI.SCControls.TextLabel()
        Me.Label10 = New YJIT.SC.UI.SCControls.Label()
        Me.AS_REQ_YMD = New YJIT.SC.UI.SCControls.TextLabel()
        Me.CUST_CD = New YJIT.SC.UI.SCControls.TextLabel()
        Me.TEL_NO = New YJIT.SC.UI.SCControls.TextLabel()
        Me.Label23 = New YJIT.SC.UI.SCControls.Label()
        Me.CUST_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.Label9 = New YJIT.SC.UI.SCControls.Label()
        Me.Label20 = New YJIT.SC.UI.SCControls.Label()
        Me.CONTENT = New YJIT.SC.UI.SCControls.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.DevDeptListPanel = New DevExpress.XtraEditors.PanelControl()
        Me.Label33 = New YJIT.SC.UI.SCControls.Label()
        Me.REQ_HM = New YJIT.SC.UI.SCControls.MaskedTextBox()
        Me.REQ_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.CMPT_HM = New YJIT.SC.UI.SCControls.MaskedTextBox()
        Me.Label31 = New YJIT.SC.UI.SCControls.Label()
        Me.SHARE_YN = New YJIT.SC.UI.SCControls.CheckBox()
        Me.DEV_ERR_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label30 = New YJIT.SC.UI.SCControls.Label()
        Me.DEV_ERR_YN = New YJIT.SC.UI.SCControls.CheckBox()
        Me.RANK = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label17 = New YJIT.SC.UI.SCControls.Label()
        Me.WORK_USR = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label12 = New YJIT.SC.UI.SCControls.Label()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.xtcETC = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Label13 = New YJIT.SC.UI.SCControls.Label()
        Me.DEV_RMK = New YJIT.SC.UI.SCControls.TextBox()
        Me.RMK = New YJIT.SC.UI.SCControls.TextBox()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.CMPT_RMK = New YJIT.SC.UI.SCControls.TextBox()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.Button3 = New YJIT.SC.UI.SCControls.Button()
        Me.TextBox4 = New YJIT.SC.UI.SCControls.TextBox()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.gridBand20 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand21 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand22 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV2_FILE_ICON = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_FILE_NM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_UPLOAD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_SUCCESS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand32 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV2_FILE_PATH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV2_FILE_SIZE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV2_RMK = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV2_MNGT_NO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_SEQ = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_INS_YMD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.REQ_SVC3 = New YJIT.SC.UI.SCControls.ComboBox()
        Me.REQ_SVC2 = New YJIT.SC.UI.SCControls.ComboBox()
        Me.REQ_SVC = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label29 = New YJIT.SC.UI.SCControls.Label()
        Me.PROC_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.CMPT_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label21 = New YJIT.SC.UI.SCControls.Label()
        Me.Label28 = New YJIT.SC.UI.SCControls.Label()
        Me.Label19 = New YJIT.SC.UI.SCControls.Label()
        Me.PRAR_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label11 = New YJIT.SC.UI.SCControls.Label()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.Timer2 = New System.Windows.Forms.Timer()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.INCLUDE_EXCEPT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.S_PROC_TYPE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplit.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifySplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ModifySplit.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.FileInputSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FileInputSplit.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.OhterDeptListPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OhterDeptListPanel.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.DevDeptListPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DevDeptListPanel.SuspendLayout()
        CType(Me.SHARE_YN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEV_ERR_YN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcETC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcETC.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.LookAndFeel.SkinName = "Blue"
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit2.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit2.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "N"
        '
        'RepositoryItemDateBoxEdit1
        '
        Me.RepositoryItemDateBoxEdit1.AutoHeight = False
        Me.RepositoryItemDateBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateBoxEdit1.LookAndFeel.SkinName = "Blue"
        Me.RepositoryItemDateBoxEdit1.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemDateBoxEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemDateBoxEdit1.Mask.SaveLiteral = False
        Me.RepositoryItemDateBoxEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateBoxEdit1.Name = "RepositoryItemDateBoxEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "##:##"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'S_SEARCH_KEY
        '
        Me.S_SEARCH_KEY.BorderColor = System.Drawing.Color.Silver
        Me.S_SEARCH_KEY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_SEARCH_KEY.DefVal = ""
        Me.S_SEARCH_KEY.IsDataStateAware = True
        Me.S_SEARCH_KEY.Location = New System.Drawing.Point(796, 8)
        Me.S_SEARCH_KEY.Name = "S_SEARCH_KEY"
        Me.S_SEARCH_KEY.NextFocus = "S_ROW_BEST"
        Me.S_SEARCH_KEY.RequiredFor = ""
        Me.S_SEARCH_KEY.Size = New System.Drawing.Size(125, 23)
        Me.S_SEARCH_KEY.TabIndex = 1
        Me.S_SEARCH_KEY.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label1
        '
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(724, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Key"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "Search Key")
        '
        'btnSearch
        '
        Me.btnSearch.Action = "SearchData"
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(928, 7)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(96, 25)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.SCREEN)
        Me.palAutoButton.Controls.Add(Me.INCLUDE_EXCEPT)
        Me.palAutoButton.Controls.Add(Me.btnRefresh)
        Me.palAutoButton.Controls.Add(Me.REF_TIME)
        Me.palAutoButton.Controls.Add(Me.lblTime)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 7)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1426, 35)
        Me.palAutoButton.TabIndex = 2
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'SCREEN
        '
        Me.SCREEN.BorderColor = System.Drawing.Color.Silver
        Me.SCREEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SCREEN.DefVal = ""
        Me.SCREEN.IsDataStateAware = True
        Me.SCREEN.Location = New System.Drawing.Point(512, 8)
        Me.SCREEN.Name = "SCREEN"
        Me.SCREEN.NextFocus = "S_ROW_BEST"
        Me.SCREEN.RequiredFor = ""
        Me.SCREEN.Size = New System.Drawing.Size(98, 23)
        Me.SCREEN.TabIndex = 1
        Me.SCREEN.Text = "개발팀개발현황"
        Me.SCREEN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.SCREEN.Visible = False
        '
        'INCLUDE_EXCEPT
        '
        Me.INCLUDE_EXCEPT.BindingPropertyName = "YesNo"
        Me.INCLUDE_EXCEPT.DefVal = False
        Me.INCLUDE_EXCEPT.IsDataStateAware = True
        Me.INCLUDE_EXCEPT.Location = New System.Drawing.Point(1041, 9)
        Me.INCLUDE_EXCEPT.Name = "INCLUDE_EXCEPT"
        Me.INCLUDE_EXCEPT.NextFocus = ""
        Me.INCLUDE_EXCEPT.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.INCLUDE_EXCEPT.Properties.Appearance.Options.UseFont = True
        Me.INCLUDE_EXCEPT.Properties.Caption = "제외건 포함"
        Me.INCLUDE_EXCEPT.RequiredFor = ""
        Me.INCLUDE_EXCEPT.Size = New System.Drawing.Size(102, 20)
        Me.INCLUDE_EXCEPT.TabIndex = 10009
        Me.Localizer1.SetWordID(Me.INCLUDE_EXCEPT, "제외건 포함")
        Me.INCLUDE_EXCEPT.YesNo = "N"
        '
        'btnRefresh
        '
        Me.btnRefresh.Action = "SearchData"
        Me.btnRefresh.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(930, 7)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(96, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "&Refresh"
        Me.Localizer1.SetWordID(Me.btnRefresh, "&Refresh")
        '
        'REF_TIME
        '
        Me.REF_TIME.CodeType = ""
        Me.REF_TIME.ColumnWidths = ""
        Me.REF_TIME.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.REF_TIME.DataParams = ""
        Me.REF_TIME.DefVal = "1"
        Me.REF_TIME.DisplayMember = "NAME"
        Me.REF_TIME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.REF_TIME.FormattingEnabled = True
        Me.REF_TIME.IsDataStateAware = True
        Me.REF_TIME.ItemDelimiter = ","
        Me.REF_TIME.ItemTextList = "N/A,1분,3분,5분,10분"
        Me.REF_TIME.ItemValueList = "0,1,3,5,10"
        Me.REF_TIME.KeepIntegrity = True
        Me.REF_TIME.Location = New System.Drawing.Point(873, 7)
        Me.REF_TIME.Name = "REF_TIME"
        Me.REF_TIME.NextFocus = "S_SEARCH_PR"
        Me.REF_TIME.NullText = ""
        Me.REF_TIME.RequiredFor = ""
        Me.REF_TIME.SearchKeys = ""
        Me.REF_TIME.Size = New System.Drawing.Size(51, 23)
        Me.REF_TIME.TabIndex = 245
        Me.REF_TIME.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.REF_TIME.ValueMember = "CODE"
        '
        'lblTime
        '
        Me.lblTime.LabelFor = Nothing
        Me.lblTime.Location = New System.Drawing.Point(696, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(171, 21)
        Me.lblTime.TabIndex = 244
        Me.lblTime.Text = "Refresh"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lblTime, "Refresh")
        '
        'btnSave
        '
        Me.btnSave.Action = "SaveData"
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(85, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 36)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.LabelFor = Nothing
        Me.Label32.Location = New System.Drawing.Point(157, 13)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(15, 15)
        Me.Label32.TabIndex = 59
        Me.Label32.Text = "~"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Localizer1.SetWordID(Me.Label32, "~")
        '
        'S_TO_YMD
        '
        Me.S_TO_YMD.BorderColor = System.Drawing.Color.Silver
        Me.S_TO_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_TO_YMD.DefVal = ""
        Me.S_TO_YMD.IconVisible = True
        Me.S_TO_YMD.IsDataStateAware = True
        Me.S_TO_YMD.Location = New System.Drawing.Point(171, 8)
        Me.S_TO_YMD.Name = "S_TO_YMD"
        Me.S_TO_YMD.NextFocus = "AA"
        Me.S_TO_YMD.RequiredFor = ""
        Me.S_TO_YMD.Size = New System.Drawing.Size(91, 23)
        Me.S_TO_YMD.TabIndex = 58
        Me.Localizer1.SetWordID(Me.S_TO_YMD, "")
        '
        'S_FM_YMD
        '
        Me.S_FM_YMD.BorderColor = System.Drawing.Color.Silver
        Me.S_FM_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_FM_YMD.DefVal = ""
        Me.S_FM_YMD.IconVisible = True
        Me.S_FM_YMD.IsDataStateAware = True
        Me.S_FM_YMD.Location = New System.Drawing.Point(67, 8)
        Me.S_FM_YMD.Name = "S_FM_YMD"
        Me.S_FM_YMD.NextFocus = "S_TO_YMD"
        Me.S_FM_YMD.RequiredFor = ""
        Me.S_FM_YMD.Size = New System.Drawing.Size(91, 23)
        Me.S_FM_YMD.TabIndex = 57
        Me.Localizer1.SetWordID(Me.S_FM_YMD, "")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(10, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "등록일자"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "등록일자")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(0, 41)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit2, Me.RepositoryItemCheckEdit1})
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(1422, 173)
        Me.WG1.TabIndex = 6
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.BestFitMaxRowCount = 10
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_MNGT_NO, Me.GV1_PRIORITY, Me.GV1_REQ_YMD, Me.GV1_REQ_HM, Me.GV1_CUST_CD, Me.GV1_CUST_NM, Me.GV1_CONTENT, Me.GV1_REQ_USR, Me.GV1_TEL_NO, Me.GV1_PROC_TYPE, Me.GV1_WORK_USR, Me.GV1_PRAR_YMD, Me.GV1_CMPT_YMD, Me.GV1_INS_USR_NM, Me.GV1_FILE_YN, Me.GV1_RMK, Me.GV1_DELAY, Me.GV1_DELAY_YN, Me.GV1_REQ_SVC, Me.GV1_REQ_SVC2, Me.GV1_REQ_SVC3, Me.GV1_INS_YMD, Me.GV1_DEV_CMPT_YMD, Me.GV1_DEV_ERR_YN, Me.GV1_SHARE_YN, Me.GV1_DEV_ERR_NM, Me.GV1_RANK})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsCustomization.AllowRowSizing = True
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.RowHeight = 10
        Me.GV1.ViewCaption = " 고객 리스트"
        '
        'GV1_MNGT_NO
        '
        Me.GV1_MNGT_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_MNGT_NO.AppearanceCell.Options.UseFont = True
        Me.GV1_MNGT_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseFont = True
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.Caption = "관리번호"
        Me.GV1_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV1_MNGT_NO.Name = "GV1_MNGT_NO"
        Me.GV1_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV1_MNGT_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_MNGT_NO.Visible = True
        Me.GV1_MNGT_NO.VisibleIndex = 0
        Me.GV1_MNGT_NO.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        '
        'GV1_PRIORITY
        '
        Me.GV1_PRIORITY.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PRIORITY.AppearanceCell.Options.UseFont = True
        Me.GV1_PRIORITY.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PRIORITY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRIORITY.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PRIORITY.AppearanceHeader.Options.UseFont = True
        Me.GV1_PRIORITY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PRIORITY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRIORITY.Caption = "우선순위"
        Me.GV1_PRIORITY.FieldName = "PRIORITY"
        Me.GV1_PRIORITY.Name = "GV1_PRIORITY"
        Me.GV1_PRIORITY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PRIORITY.Visible = True
        Me.GV1_PRIORITY.VisibleIndex = 1
        Me.GV1_PRIORITY.Width = 59
        Me.Localizer1.SetWordID(Me.GV1_PRIORITY, "우선순위")
        '
        'GV1_REQ_YMD
        '
        Me.GV1_REQ_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_YMD.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV1_REQ_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_YMD.Caption = "요청일자"
        Me.GV1_REQ_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV1_REQ_YMD.FieldName = "REQ_YMD"
        Me.GV1_REQ_YMD.Name = "GV1_REQ_YMD"
        Me.GV1_REQ_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_REQ_YMD.Visible = True
        Me.GV1_REQ_YMD.VisibleIndex = 4
        Me.GV1_REQ_YMD.Width = 73
        Me.Localizer1.SetWordID(Me.GV1_REQ_YMD, "요청일자")
        '
        'GV1_REQ_HM
        '
        Me.GV1_REQ_HM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_HM.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_HM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_HM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_HM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_HM.AppearanceHeader.Options.UseFont = True
        Me.GV1_REQ_HM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_HM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_HM.Caption = "요청시간"
        Me.GV1_REQ_HM.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GV1_REQ_HM.FieldName = "REQ_HM"
        Me.GV1_REQ_HM.Name = "GV1_REQ_HM"
        Me.GV1_REQ_HM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_REQ_HM.Visible = True
        Me.GV1_REQ_HM.VisibleIndex = 5
        Me.GV1_REQ_HM.Width = 47
        Me.Localizer1.SetWordID(Me.GV1_REQ_HM, "요청시간")
        '
        'GV1_CUST_CD
        '
        Me.GV1_CUST_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CUST_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_CUST_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CUST_CD.AppearanceHeader.Options.UseFont = True
        Me.GV1_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.Caption = "코드"
        Me.GV1_CUST_CD.FieldName = "CUST_CD"
        Me.GV1_CUST_CD.Name = "GV1_CUST_CD"
        Me.GV1_CUST_CD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CUST_CD.Visible = True
        Me.GV1_CUST_CD.VisibleIndex = 2
        Me.GV1_CUST_CD.Width = 57
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "코드")
        '
        'GV1_CUST_NM
        '
        Me.GV1_CUST_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CUST_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_CUST_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_CUST_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CUST_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_NM.Caption = "거래처 명"
        Me.GV1_CUST_NM.FieldName = "CUST_NM"
        Me.GV1_CUST_NM.Name = "GV1_CUST_NM"
        Me.GV1_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_NM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV1_CUST_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CUST_NM.Visible = True
        Me.GV1_CUST_NM.VisibleIndex = 3
        Me.GV1_CUST_NM.Width = 85
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "거래처 명")
        '
        'GV1_CONTENT
        '
        Me.GV1_CONTENT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CONTENT.AppearanceCell.Options.UseFont = True
        Me.GV1_CONTENT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CONTENT.AppearanceHeader.Options.UseFont = True
        Me.GV1_CONTENT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CONTENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CONTENT.Caption = "고객 요청내용"
        Me.GV1_CONTENT.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GV1_CONTENT.FieldName = "CONTENT"
        Me.GV1_CONTENT.Name = "GV1_CONTENT"
        Me.GV1_CONTENT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CONTENT.Visible = True
        Me.GV1_CONTENT.VisibleIndex = 9
        Me.GV1_CONTENT.Width = 217
        Me.Localizer1.SetWordID(Me.GV1_CONTENT, "고객 요청내용")
        '
        'GV1_REQ_USR
        '
        Me.GV1_REQ_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_USR.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_USR.AppearanceHeader.Options.UseFont = True
        Me.GV1_REQ_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_USR.Caption = "요청자"
        Me.GV1_REQ_USR.FieldName = "REQ_USR"
        Me.GV1_REQ_USR.Name = "GV1_REQ_USR"
        Me.GV1_REQ_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_REQ_USR.Visible = True
        Me.GV1_REQ_USR.VisibleIndex = 12
        Me.GV1_REQ_USR.Width = 52
        Me.Localizer1.SetWordID(Me.GV1_REQ_USR, "요청자")
        '
        'GV1_TEL_NO
        '
        Me.GV1_TEL_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_TEL_NO.AppearanceCell.Options.UseFont = True
        Me.GV1_TEL_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TEL_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TEL_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_TEL_NO.AppearanceHeader.Options.UseFont = True
        Me.GV1_TEL_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TEL_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TEL_NO.Caption = "연락처"
        Me.GV1_TEL_NO.FieldName = "TEL_NO"
        Me.GV1_TEL_NO.Name = "GV1_TEL_NO"
        Me.GV1_TEL_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_TEL_NO.Visible = True
        Me.GV1_TEL_NO.VisibleIndex = 13
        Me.GV1_TEL_NO.Width = 76
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "연락처")
        '
        'GV1_PROC_TYPE
        '
        Me.GV1_PROC_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PROC_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_PROC_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PROC_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROC_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PROC_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV1_PROC_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PROC_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROC_TYPE.Caption = "진행현황"
        Me.GV1_PROC_TYPE.FieldName = "PROC_TYPE"
        Me.GV1_PROC_TYPE.Name = "GV1_PROC_TYPE"
        Me.GV1_PROC_TYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PROC_TYPE.Visible = True
        Me.GV1_PROC_TYPE.VisibleIndex = 6
        Me.GV1_PROC_TYPE.Width = 64
        Me.Localizer1.SetWordID(Me.GV1_PROC_TYPE, "진행현황")
        '
        'GV1_WORK_USR
        '
        Me.GV1_WORK_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_WORK_USR.AppearanceCell.Options.UseFont = True
        Me.GV1_WORK_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_WORK_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_WORK_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_WORK_USR.AppearanceHeader.Options.UseFont = True
        Me.GV1_WORK_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_WORK_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_WORK_USR.Caption = "담당자"
        Me.GV1_WORK_USR.FieldName = "WORK_USR_NM"
        Me.GV1_WORK_USR.Name = "GV1_WORK_USR"
        Me.GV1_WORK_USR.OptionsColumn.AllowEdit = False
        Me.GV1_WORK_USR.OptionsColumn.ReadOnly = True
        Me.GV1_WORK_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_WORK_USR.Visible = True
        Me.GV1_WORK_USR.VisibleIndex = 14
        Me.GV1_WORK_USR.Width = 91
        Me.Localizer1.SetWordID(Me.GV1_WORK_USR, "담당자")
        '
        'GV1_PRAR_YMD
        '
        Me.GV1_PRAR_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PRAR_YMD.AppearanceCell.Options.UseFont = True
        Me.GV1_PRAR_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PRAR_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRAR_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PRAR_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV1_PRAR_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PRAR_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRAR_YMD.Caption = "예정일자"
        Me.GV1_PRAR_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV1_PRAR_YMD.FieldName = "PRAR_YMD"
        Me.GV1_PRAR_YMD.Name = "GV1_PRAR_YMD"
        Me.GV1_PRAR_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PRAR_YMD.Visible = True
        Me.GV1_PRAR_YMD.VisibleIndex = 7
        Me.GV1_PRAR_YMD.Width = 73
        Me.Localizer1.SetWordID(Me.GV1_PRAR_YMD, "예정일자")
        '
        'GV1_CMPT_YMD
        '
        Me.GV1_CMPT_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CMPT_YMD.AppearanceCell.Options.UseFont = True
        Me.GV1_CMPT_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CMPT_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CMPT_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CMPT_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV1_CMPT_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CMPT_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CMPT_YMD.Caption = "완료일자"
        Me.GV1_CMPT_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV1_CMPT_YMD.FieldName = "CMPT_YMD"
        Me.GV1_CMPT_YMD.Name = "GV1_CMPT_YMD"
        Me.GV1_CMPT_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_CMPT_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_CMPT_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CMPT_YMD.Visible = True
        Me.GV1_CMPT_YMD.VisibleIndex = 8
        Me.GV1_CMPT_YMD.Width = 71
        Me.Localizer1.SetWordID(Me.GV1_CMPT_YMD, "완료일자")
        '
        'GV1_INS_USR_NM
        '
        Me.GV1_INS_USR_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_INS_USR_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_INS_USR_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_USR_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_INS_USR_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_INS_USR_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_USR_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR_NM.Caption = "등록자"
        Me.GV1_INS_USR_NM.FieldName = "INS_USR_NM"
        Me.GV1_INS_USR_NM.Name = "GV1_INS_USR_NM"
        Me.GV1_INS_USR_NM.OptionsColumn.AllowEdit = False
        Me.GV1_INS_USR_NM.OptionsColumn.ReadOnly = True
        Me.GV1_INS_USR_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_INS_USR_NM.Visible = True
        Me.GV1_INS_USR_NM.VisibleIndex = 15
        Me.GV1_INS_USR_NM.Width = 61
        Me.Localizer1.SetWordID(Me.GV1_INS_USR_NM, "등록자")
        '
        'GV1_FILE_YN
        '
        Me.GV1_FILE_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_FILE_YN.AppearanceCell.Options.UseFont = True
        Me.GV1_FILE_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_FILE_YN.AppearanceHeader.Options.UseFont = True
        Me.GV1_FILE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FILE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FILE_YN.Caption = "Document"
        Me.GV1_FILE_YN.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV1_FILE_YN.FieldName = "FILE_YN"
        Me.GV1_FILE_YN.Name = "GV1_FILE_YN"
        Me.GV1_FILE_YN.Visible = True
        Me.GV1_FILE_YN.VisibleIndex = 11
        Me.GV1_FILE_YN.Width = 22
        Me.Localizer1.SetWordID(Me.GV1_FILE_YN, "Document")
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit1.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'GV1_RMK
        '
        Me.GV1_RMK.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_RMK.AppearanceCell.Options.UseFont = True
        Me.GV1_RMK.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_RMK.AppearanceHeader.Options.UseFont = True
        Me.GV1_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RMK.Caption = "개발팀 처리내용"
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 10
        Me.GV1_RMK.Width = 217
        Me.Localizer1.SetWordID(Me.GV1_RMK, "개발팀 처리내용")
        '
        'GV1_DELAY
        '
        Me.GV1_DELAY.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DELAY.AppearanceCell.Options.UseFont = True
        Me.GV1_DELAY.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_DELAY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DELAY.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DELAY.AppearanceHeader.Options.UseFont = True
        Me.GV1_DELAY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DELAY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DELAY.Caption = "Delay"
        Me.GV1_DELAY.FieldName = "DELAY"
        Me.GV1_DELAY.Name = "GV1_DELAY"
        Me.GV1_DELAY.OptionsColumn.AllowEdit = False
        Me.GV1_DELAY.OptionsColumn.ReadOnly = True
        Me.GV1_DELAY.Visible = True
        Me.GV1_DELAY.VisibleIndex = 16
        Me.GV1_DELAY.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_DELAY, "Delay")
        '
        'GV1_DELAY_YN
        '
        Me.GV1_DELAY_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DELAY_YN.AppearanceCell.Options.UseFont = True
        Me.GV1_DELAY_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_DELAY_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DELAY_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DELAY_YN.AppearanceHeader.Options.UseFont = True
        Me.GV1_DELAY_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DELAY_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DELAY_YN.Caption = "Delay(Y/N)"
        Me.GV1_DELAY_YN.FieldName = "DELAY_YN"
        Me.GV1_DELAY_YN.Name = "GV1_DELAY_YN"
        Me.GV1_DELAY_YN.OptionsColumn.AllowEdit = False
        Me.GV1_DELAY_YN.OptionsColumn.ReadOnly = True
        Me.GV1_DELAY_YN.Visible = True
        Me.GV1_DELAY_YN.VisibleIndex = 17
        Me.GV1_DELAY_YN.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_DELAY_YN, "Delay(Y/N)")
        '
        'GV1_REQ_SVC
        '
        Me.GV1_REQ_SVC.Caption = "업무구분"
        Me.GV1_REQ_SVC.FieldName = "REQ_SVC"
        Me.GV1_REQ_SVC.Name = "GV1_REQ_SVC"
        Me.GV1_REQ_SVC.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_SVC.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_SVC.Visible = True
        Me.GV1_REQ_SVC.VisibleIndex = 18
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "업무구분")
        '
        'GV1_REQ_SVC2
        '
        Me.GV1_REQ_SVC2.Caption = "업무구분2"
        Me.GV1_REQ_SVC2.FieldName = "REQ_SVC2"
        Me.GV1_REQ_SVC2.Name = "GV1_REQ_SVC2"
        Me.GV1_REQ_SVC2.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_SVC2.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_SVC2.Visible = True
        Me.GV1_REQ_SVC2.VisibleIndex = 19
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC2, "업무구분2")
        '
        'GV1_REQ_SVC3
        '
        Me.GV1_REQ_SVC3.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_SVC3.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_SVC3.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_SVC3.AppearanceHeader.Options.UseFont = True
        Me.GV1_REQ_SVC3.Caption = "업무구분3"
        Me.GV1_REQ_SVC3.FieldName = "REQ_SVC3"
        Me.GV1_REQ_SVC3.Name = "GV1_REQ_SVC3"
        Me.GV1_REQ_SVC3.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_SVC3.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_SVC3.Visible = True
        Me.GV1_REQ_SVC3.VisibleIndex = 20
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC3, "업무구분3")
        '
        'GV1_INS_YMD
        '
        Me.GV1_INS_YMD.Caption = "등록일자"
        Me.GV1_INS_YMD.FieldName = "INS_YMD"
        Me.GV1_INS_YMD.Name = "GV1_INS_YMD"
        Me.GV1_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_INS_YMD.Visible = True
        Me.GV1_INS_YMD.VisibleIndex = 21
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "등록일자")
        '
        'GV1_DEV_CMPT_YMD
        '
        Me.GV1_DEV_CMPT_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DEV_CMPT_YMD.AppearanceCell.Options.UseFont = True
        Me.GV1_DEV_CMPT_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DEV_CMPT_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV1_DEV_CMPT_YMD.Caption = "개발팀 처리완료"
        Me.GV1_DEV_CMPT_YMD.FieldName = "DEV_CMPT_YMD"
        Me.GV1_DEV_CMPT_YMD.Name = "GV1_DEV_CMPT_YMD"
        Me.GV1_DEV_CMPT_YMD.Width = 99
        Me.Localizer1.SetWordID(Me.GV1_DEV_CMPT_YMD, "개발팀 처리완료")
        '
        'GV1_DEV_ERR_YN
        '
        Me.GV1_DEV_ERR_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DEV_ERR_YN.AppearanceCell.Options.UseFont = True
        Me.GV1_DEV_ERR_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_DEV_ERR_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DEV_ERR_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DEV_ERR_YN.AppearanceHeader.Options.UseFont = True
        Me.GV1_DEV_ERR_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DEV_ERR_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DEV_ERR_YN.Caption = "결함"
        Me.GV1_DEV_ERR_YN.FieldName = "DEV_ERR_YN"
        Me.GV1_DEV_ERR_YN.Name = "GV1_DEV_ERR_YN"
        Me.GV1_DEV_ERR_YN.OptionsColumn.AllowEdit = False
        Me.GV1_DEV_ERR_YN.OptionsColumn.ReadOnly = True
        Me.GV1_DEV_ERR_YN.Visible = True
        Me.GV1_DEV_ERR_YN.VisibleIndex = 22
        Me.GV1_DEV_ERR_YN.Width = 40
        Me.Localizer1.SetWordID(Me.GV1_DEV_ERR_YN, "결함")
        '
        'GV1_SHARE_YN
        '
        Me.GV1_SHARE_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_SHARE_YN.AppearanceCell.Options.UseFont = True
        Me.GV1_SHARE_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SHARE_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SHARE_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_SHARE_YN.AppearanceHeader.Options.UseFont = True
        Me.GV1_SHARE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SHARE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SHARE_YN.Caption = "공유"
        Me.GV1_SHARE_YN.FieldName = "SHARE_YN"
        Me.GV1_SHARE_YN.Name = "GV1_SHARE_YN"
        Me.GV1_SHARE_YN.OptionsColumn.AllowEdit = False
        Me.GV1_SHARE_YN.OptionsColumn.ReadOnly = True
        Me.GV1_SHARE_YN.Visible = True
        Me.GV1_SHARE_YN.VisibleIndex = 23
        Me.GV1_SHARE_YN.Width = 40
        Me.Localizer1.SetWordID(Me.GV1_SHARE_YN, "공유")
        '
        'GV1_DEV_ERR_NM
        '
        Me.GV1_DEV_ERR_NM.Caption = "Err Nm"
        Me.GV1_DEV_ERR_NM.FieldName = "DEV_ERR_NM"
        Me.GV1_DEV_ERR_NM.Name = "GV1_DEV_ERR_NM"
        Me.GV1_DEV_ERR_NM.OptionsColumn.AllowEdit = False
        Me.GV1_DEV_ERR_NM.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_DEV_ERR_NM, "Err Nm")
        '
        'GV1_RANK
        '
        Me.GV1_RANK.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_RANK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RANK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RANK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RANK.Caption = "난이도"
        Me.GV1_RANK.FieldName = "RANK"
        Me.GV1_RANK.Name = "GV1_RANK"
        Me.GV1_RANK.Visible = True
        Me.GV1_RANK.VisibleIndex = 24
        Me.GV1_RANK.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_RANK, "난이도")
        '
        'RepositoryItemDateBoxEdit2
        '
        Me.RepositoryItemDateBoxEdit2.AutoHeight = False
        Me.RepositoryItemDateBoxEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateBoxEdit2.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemDateBoxEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemDateBoxEdit2.Mask.SaveLiteral = False
        Me.RepositoryItemDateBoxEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateBoxEdit2.Name = "RepositoryItemDateBoxEdit2"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "순번"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GridColumn1, "순번")
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "사이트명"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GridColumn2, "사이트명")
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "거래처유형"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처유형")
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "담당자"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GridColumn4, "담당자")
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "전화"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GridColumn5, "전화")
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "DB IP"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GridColumn6, "DB IP")
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.S_FM_YMD)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.S_WORK_AREA)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.S_WORK_USR)
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.S_PROC_TYPE)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.S_SEARCH_KEY)
        Me.PanelControl1.Controls.Add(Me.S_TO_YMD)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.Label32)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1422, 41)
        Me.PanelControl1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'S_WORK_AREA
        '
        Me.S_WORK_AREA.CodeType = ""
        Me.S_WORK_AREA.ColumnWidths = ""
        Me.S_WORK_AREA.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_WORK_AREA.DataParams = ""
        Me.S_WORK_AREA.DefVal = ""
        Me.S_WORK_AREA.DisplayMember = "NAME"
        Me.S_WORK_AREA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_WORK_AREA.FormattingEnabled = True
        Me.S_WORK_AREA.IsDataStateAware = True
        Me.S_WORK_AREA.ItemDelimiter = ","
        Me.S_WORK_AREA.ItemTextList = "서울,부산"
        Me.S_WORK_AREA.ItemValueList = "서울,부산"
        Me.S_WORK_AREA.KeepIntegrity = True
        Me.S_WORK_AREA.Location = New System.Drawing.Point(648, 9)
        Me.S_WORK_AREA.Name = "S_WORK_AREA"
        Me.S_WORK_AREA.NextFocus = "S_SEARCH_KEY"
        Me.S_WORK_AREA.NullText = " "
        Me.S_WORK_AREA.RequiredFor = ""
        Me.S_WORK_AREA.SearchKeys = ""
        Me.S_WORK_AREA.Size = New System.Drawing.Size(73, 23)
        Me.S_WORK_AREA.TabIndex = 294
        Me.S_WORK_AREA.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_WORK_AREA.ValueMember = "CODE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.LabelFor = Nothing
        Me.Label5.Location = New System.Drawing.Point(603, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 293
        Me.Label5.Text = "근무지"
        Me.Localizer1.SetWordID(Me.Label5, "근무지")
        '
        'S_WORK_USR
        '
        Me.S_WORK_USR.CodeType = ""
        Me.S_WORK_USR.ColumnWidths = ""
        Me.S_WORK_USR.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_WORK_USR.DataParams = ""
        Me.S_WORK_USR.DefVal = ""
        Me.S_WORK_USR.DisplayMember = "NAME"
        Me.S_WORK_USR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_WORK_USR.FormattingEnabled = True
        Me.S_WORK_USR.IsDataStateAware = True
        Me.S_WORK_USR.ItemDelimiter = ","
        Me.S_WORK_USR.ItemTextList = ""
        Me.S_WORK_USR.ItemValueList = ""
        Me.S_WORK_USR.KeepIntegrity = True
        Me.S_WORK_USR.Location = New System.Drawing.Point(498, 9)
        Me.S_WORK_USR.Name = "S_WORK_USR"
        Me.S_WORK_USR.NextFocus = "S_WORK_AREA"
        Me.S_WORK_USR.NullText = "--Select--"
        Me.S_WORK_USR.RequiredFor = ""
        Me.S_WORK_USR.SearchKeys = ""
        Me.S_WORK_USR.Size = New System.Drawing.Size(100, 23)
        Me.S_WORK_USR.TabIndex = 290
        Me.S_WORK_USR.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_WORK_USR.ValueMember = "CODE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(453, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 249
        Me.Label6.Text = "담당자"
        Me.Localizer1.SetWordID(Me.Label6, "담당자")
        '
        'S_PROC_TYPE
        '
        Me.S_PROC_TYPE.Location = New System.Drawing.Point(331, 9)
        Me.S_PROC_TYPE.Name = "S_PROC_TYPE"
        Me.S_PROC_TYPE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.S_PROC_TYPE.Size = New System.Drawing.Size(117, 21)
        Me.S_PROC_TYPE.TabIndex = 238
        Me.Localizer1.SetWordID(Me.S_PROC_TYPE, "")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(265, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "처리내용"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label3, "처리내용")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.MainSplit)
        Me.PanelControl2.Location = New System.Drawing.Point(6, 46)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1426, 746)
        Me.PanelControl2.TabIndex = 282
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'MainSplit
        '
        Me.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplit.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.MainSplit.Horizontal = False
        Me.MainSplit.Location = New System.Drawing.Point(2, 2)
        Me.MainSplit.Name = "MainSplit"
        Me.MainSplit.Panel1.Controls.Add(Me.PanelControl3)
        Me.MainSplit.Panel1.Text = "Panel1"
        Me.MainSplit.Panel2.Controls.Add(Me.ModifySplit)
        Me.MainSplit.Panel2.MinSize = 340
        Me.MainSplit.Panel2.Text = "Panel2"
        Me.MainSplit.Size = New System.Drawing.Size(1422, 742)
        Me.MainSplit.SplitterPosition = 320
        Me.MainSplit.TabIndex = 280
        Me.MainSplit.Text = "SplitContainerControl2"
        Me.Localizer1.SetWordID(Me.MainSplit, "SplitContainerControl2")
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.SplitContainerControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1422, 396)
        Me.PanelControl3.TabIndex = 279
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.WG3)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.WG1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1422, 396)
        Me.SplitContainerControl1.SplitterPosition = 176
        Me.SplitContainerControl1.TabIndex = 7
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "SplitContainerControl1")
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
        Me.WG3.Size = New System.Drawing.Size(1422, 176)
        Me.WG3.TabIndex = 7
        Me.WG3.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV3.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV3.BestFitMaxRowCount = 10
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV3_MNGT_NO, Me.GV3_PRIORITY, Me.GV3_CUST_CD, Me.GV3_CUST_NM, Me.GV3_REQ_YMD, Me.GV3_REQ_HM, Me.GV3_REQ_USR, Me.GV3_TEL_NO, Me.GV3_CONTENT, Me.GV3_PROC_TYPE, Me.GV3_INS_USR_NM, Me.GV3_REQ_SVC, Me.GV3_SYS_NM, Me.GV3_INS_YMD, Me.GV3_SVC_NM, Me.GV3_EXCEPT_YN, Me.GV3_DEV_PIC})
        Me.GV3.GridControl = Me.WG3
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsCustomization.AllowRowSizing = True
        Me.GV3.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV3.OptionsView.ColumnAutoWidth = False
        Me.GV3.OptionsView.ShowGroupPanel = False
        Me.GV3.RowHeight = 10
        Me.GV3.ViewCaption = " 고객 리스트"
        '
        'GV3_MNGT_NO
        '
        Me.GV3_MNGT_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_MNGT_NO.AppearanceCell.Options.UseFont = True
        Me.GV3_MNGT_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_MNGT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_MNGT_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_MNGT_NO.AppearanceHeader.Options.UseFont = True
        Me.GV3_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_MNGT_NO.Caption = "관리번호"
        Me.GV3_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV3_MNGT_NO.Name = "GV3_MNGT_NO"
        Me.GV3_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV3_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV3_MNGT_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_MNGT_NO.Visible = True
        Me.GV3_MNGT_NO.VisibleIndex = 0
        Me.GV3_MNGT_NO.Width = 100
        Me.Localizer1.SetWordID(Me.GV3_MNGT_NO, "관리번호")
        '
        'GV3_PRIORITY
        '
        Me.GV3_PRIORITY.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_PRIORITY.AppearanceCell.Options.UseFont = True
        Me.GV3_PRIORITY.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_PRIORITY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_PRIORITY.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_PRIORITY.AppearanceHeader.Options.UseFont = True
        Me.GV3_PRIORITY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_PRIORITY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_PRIORITY.Caption = "우선순위"
        Me.GV3_PRIORITY.FieldName = "PRIORITY"
        Me.GV3_PRIORITY.Name = "GV3_PRIORITY"
        Me.GV3_PRIORITY.OptionsColumn.AllowEdit = False
        Me.GV3_PRIORITY.OptionsColumn.ReadOnly = True
        Me.GV3_PRIORITY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_PRIORITY.Visible = True
        Me.GV3_PRIORITY.VisibleIndex = 1
        Me.GV3_PRIORITY.Width = 59
        Me.Localizer1.SetWordID(Me.GV3_PRIORITY, "우선순위")
        '
        'GV3_CUST_CD
        '
        Me.GV3_CUST_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_CUST_CD.AppearanceCell.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GV3_CUST_CD.AppearanceCell.Options.UseFont = True
        Me.GV3_CUST_CD.AppearanceCell.Options.UseForeColor = True
        Me.GV3_CUST_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_CUST_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_CUST_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_CUST_CD.AppearanceHeader.Options.UseFont = True
        Me.GV3_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_CUST_CD.Caption = "코드"
        Me.GV3_CUST_CD.FieldName = "CUST_CD"
        Me.GV3_CUST_CD.Name = "GV3_CUST_CD"
        Me.GV3_CUST_CD.OptionsColumn.AllowEdit = False
        Me.GV3_CUST_CD.OptionsColumn.ReadOnly = True
        Me.GV3_CUST_CD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_CUST_CD.Visible = True
        Me.GV3_CUST_CD.VisibleIndex = 2
        Me.GV3_CUST_CD.Width = 57
        Me.Localizer1.SetWordID(Me.GV3_CUST_CD, "코드")
        '
        'GV3_CUST_NM
        '
        Me.GV3_CUST_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_CUST_NM.AppearanceCell.Options.UseFont = True
        Me.GV3_CUST_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_CUST_NM.AppearanceHeader.Options.UseFont = True
        Me.GV3_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_CUST_NM.Caption = "거래처 명"
        Me.GV3_CUST_NM.FieldName = "CUST_NM"
        Me.GV3_CUST_NM.Name = "GV3_CUST_NM"
        Me.GV3_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV3_CUST_NM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV3_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV3_CUST_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_CUST_NM.Visible = True
        Me.GV3_CUST_NM.VisibleIndex = 3
        Me.GV3_CUST_NM.Width = 85
        Me.Localizer1.SetWordID(Me.GV3_CUST_NM, "거래처 명")
        '
        'GV3_REQ_YMD
        '
        Me.GV3_REQ_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_REQ_YMD.AppearanceCell.Options.UseFont = True
        Me.GV3_REQ_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_REQ_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_REQ_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_REQ_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV3_REQ_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_REQ_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_REQ_YMD.Caption = "요청일자"
        Me.GV3_REQ_YMD.FieldName = "REQ_YMD"
        Me.GV3_REQ_YMD.Name = "GV3_REQ_YMD"
        Me.GV3_REQ_YMD.OptionsColumn.AllowEdit = False
        Me.GV3_REQ_YMD.OptionsColumn.ReadOnly = True
        Me.GV3_REQ_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_REQ_YMD.Visible = True
        Me.GV3_REQ_YMD.VisibleIndex = 4
        Me.GV3_REQ_YMD.Width = 73
        Me.Localizer1.SetWordID(Me.GV3_REQ_YMD, "요청일자")
        '
        'GV3_REQ_HM
        '
        Me.GV3_REQ_HM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_REQ_HM.AppearanceCell.Options.UseFont = True
        Me.GV3_REQ_HM.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_REQ_HM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_REQ_HM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_REQ_HM.AppearanceHeader.Options.UseFont = True
        Me.GV3_REQ_HM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_REQ_HM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_REQ_HM.Caption = "시간"
        Me.GV3_REQ_HM.FieldName = "REQ_HM"
        Me.GV3_REQ_HM.Name = "GV3_REQ_HM"
        Me.GV3_REQ_HM.OptionsColumn.AllowEdit = False
        Me.GV3_REQ_HM.OptionsColumn.ReadOnly = True
        Me.GV3_REQ_HM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_REQ_HM.Visible = True
        Me.GV3_REQ_HM.VisibleIndex = 5
        Me.GV3_REQ_HM.Width = 47
        Me.Localizer1.SetWordID(Me.GV3_REQ_HM, "시간")
        '
        'GV3_REQ_USR
        '
        Me.GV3_REQ_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_REQ_USR.AppearanceCell.Options.UseFont = True
        Me.GV3_REQ_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_REQ_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_REQ_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_REQ_USR.AppearanceHeader.Options.UseFont = True
        Me.GV3_REQ_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_REQ_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_REQ_USR.Caption = "거래처 요청자"
        Me.GV3_REQ_USR.FieldName = "REQ_USR"
        Me.GV3_REQ_USR.Name = "GV3_REQ_USR"
        Me.GV3_REQ_USR.OptionsColumn.AllowEdit = False
        Me.GV3_REQ_USR.OptionsColumn.ReadOnly = True
        Me.GV3_REQ_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_REQ_USR.Visible = True
        Me.GV3_REQ_USR.VisibleIndex = 6
        Me.GV3_REQ_USR.Width = 52
        Me.Localizer1.SetWordID(Me.GV3_REQ_USR, "요청자")
        '
        'GV3_TEL_NO
        '
        Me.GV3_TEL_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_TEL_NO.AppearanceCell.Options.UseFont = True
        Me.GV3_TEL_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_TEL_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_TEL_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_TEL_NO.AppearanceHeader.Options.UseFont = True
        Me.GV3_TEL_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_TEL_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_TEL_NO.Caption = "연락처"
        Me.GV3_TEL_NO.FieldName = "TEL_NO"
        Me.GV3_TEL_NO.Name = "GV3_TEL_NO"
        Me.GV3_TEL_NO.OptionsColumn.AllowEdit = False
        Me.GV3_TEL_NO.OptionsColumn.ReadOnly = True
        Me.GV3_TEL_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_TEL_NO.Visible = True
        Me.GV3_TEL_NO.VisibleIndex = 7
        Me.GV3_TEL_NO.Width = 76
        Me.Localizer1.SetWordID(Me.GV3_TEL_NO, "연락처")
        '
        'GV3_CONTENT
        '
        Me.GV3_CONTENT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_CONTENT.AppearanceCell.Options.UseFont = True
        Me.GV3_CONTENT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_CONTENT.AppearanceHeader.Options.UseFont = True
        Me.GV3_CONTENT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_CONTENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_CONTENT.Caption = "고객요청사항"
        Me.GV3_CONTENT.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.GV3_CONTENT.FieldName = "CONTENT"
        Me.GV3_CONTENT.Name = "GV3_CONTENT"
        Me.GV3_CONTENT.OptionsColumn.AllowEdit = False
        Me.GV3_CONTENT.OptionsColumn.ReadOnly = True
        Me.GV3_CONTENT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_CONTENT.Visible = True
        Me.GV3_CONTENT.VisibleIndex = 8
        Me.GV3_CONTENT.Width = 317
        Me.Localizer1.SetWordID(Me.GV3_CONTENT, "고객요청사항")
        '
        'GV3_PROC_TYPE
        '
        Me.GV3_PROC_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_PROC_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV3_PROC_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_PROC_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_PROC_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_PROC_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV3_PROC_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_PROC_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_PROC_TYPE.Caption = "상태"
        Me.GV3_PROC_TYPE.FieldName = "PROC_TYPE"
        Me.GV3_PROC_TYPE.Name = "GV3_PROC_TYPE"
        Me.GV3_PROC_TYPE.OptionsColumn.AllowEdit = False
        Me.GV3_PROC_TYPE.OptionsColumn.ReadOnly = True
        Me.GV3_PROC_TYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_PROC_TYPE.Visible = True
        Me.GV3_PROC_TYPE.VisibleIndex = 9
        Me.GV3_PROC_TYPE.Width = 64
        Me.Localizer1.SetWordID(Me.GV3_PROC_TYPE, "상태")
        '
        'GV3_INS_USR_NM
        '
        Me.GV3_INS_USR_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_INS_USR_NM.AppearanceCell.Options.UseFont = True
        Me.GV3_INS_USR_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_INS_USR_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_INS_USR_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_INS_USR_NM.AppearanceHeader.Options.UseFont = True
        Me.GV3_INS_USR_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_INS_USR_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_INS_USR_NM.Caption = "등록자"
        Me.GV3_INS_USR_NM.FieldName = "INS_USR_NM"
        Me.GV3_INS_USR_NM.Name = "GV3_INS_USR_NM"
        Me.GV3_INS_USR_NM.OptionsColumn.AllowEdit = False
        Me.GV3_INS_USR_NM.OptionsColumn.ReadOnly = True
        Me.GV3_INS_USR_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_INS_USR_NM.Visible = True
        Me.GV3_INS_USR_NM.VisibleIndex = 10
        Me.GV3_INS_USR_NM.Width = 61
        Me.Localizer1.SetWordID(Me.GV3_INS_USR_NM, "등록자")
        '
        'GV3_REQ_SVC
        '
        Me.GV3_REQ_SVC.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_REQ_SVC.AppearanceCell.Options.UseFont = True
        Me.GV3_REQ_SVC.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_REQ_SVC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_REQ_SVC.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_REQ_SVC.AppearanceHeader.Options.UseFont = True
        Me.GV3_REQ_SVC.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_REQ_SVC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_REQ_SVC.Caption = "업무구분"
        Me.GV3_REQ_SVC.FieldName = "REQ_SVC"
        Me.GV3_REQ_SVC.Name = "GV3_REQ_SVC"
        Me.GV3_REQ_SVC.OptionsColumn.AllowEdit = False
        Me.GV3_REQ_SVC.OptionsColumn.ReadOnly = True
        Me.GV3_REQ_SVC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV3_REQ_SVC.Visible = True
        Me.GV3_REQ_SVC.VisibleIndex = 11
        Me.GV3_REQ_SVC.Width = 80
        Me.Localizer1.SetWordID(Me.GV3_REQ_SVC, "업무구분")
        '
        'GV3_SYS_NM
        '
        Me.GV3_SYS_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_SYS_NM.AppearanceCell.Options.UseFont = True
        Me.GV3_SYS_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_SYS_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_SYS_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_SYS_NM.AppearanceHeader.Options.UseFont = True
        Me.GV3_SYS_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_SYS_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_SYS_NM.Caption = "접수"
        Me.GV3_SYS_NM.FieldName = "SYS_NM"
        Me.GV3_SYS_NM.Name = "GV3_SYS_NM"
        Me.GV3_SYS_NM.OptionsColumn.AllowEdit = False
        Me.GV3_SYS_NM.OptionsColumn.ReadOnly = True
        Me.GV3_SYS_NM.Visible = True
        Me.GV3_SYS_NM.VisibleIndex = 12
        Me.GV3_SYS_NM.Width = 47
        Me.Localizer1.SetWordID(Me.GV3_SYS_NM, "접수")
        '
        'GV3_INS_YMD
        '
        Me.GV3_INS_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_INS_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_INS_YMD.Caption = "입력일자"
        Me.GV3_INS_YMD.FieldName = "INS_YMD"
        Me.GV3_INS_YMD.Name = "GV3_INS_YMD"
        Me.GV3_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV3_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV3_INS_YMD.Visible = True
        Me.GV3_INS_YMD.VisibleIndex = 13
        Me.GV3_INS_YMD.Width = 73
        Me.Localizer1.SetWordID(Me.GV3_INS_YMD, "입력일자")
        '
        'GV3_SVC_NM
        '
        Me.GV3_SVC_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV3_SVC_NM.AppearanceCell.Options.UseFont = True
        Me.GV3_SVC_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_SVC_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_SVC_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_SVC_NM.AppearanceHeader.Options.UseFont = True
        Me.GV3_SVC_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_SVC_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_SVC_NM.Caption = "시스템"
        Me.GV3_SVC_NM.FieldName = "SVC_NM"
        Me.GV3_SVC_NM.Name = "GV3_SVC_NM"
        Me.GV3_SVC_NM.OptionsColumn.AllowEdit = False
        Me.GV3_SVC_NM.OptionsColumn.ReadOnly = True
        Me.GV3_SVC_NM.Visible = True
        Me.GV3_SVC_NM.VisibleIndex = 14
        Me.GV3_SVC_NM.Width = 46
        Me.Localizer1.SetWordID(Me.GV3_SVC_NM, "시스템")
        '
        'GV3_EXCEPT_YN
        '
        Me.GV3_EXCEPT_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_EXCEPT_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_EXCEPT_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_EXCEPT_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_EXCEPT_YN.Caption = "제외"
        Me.GV3_EXCEPT_YN.FieldName = "EXCEPT_YN"
        Me.GV3_EXCEPT_YN.Name = "GV3_EXCEPT_YN"
        Me.GV3_EXCEPT_YN.OptionsColumn.AllowEdit = False
        Me.GV3_EXCEPT_YN.OptionsColumn.ReadOnly = True
        Me.GV3_EXCEPT_YN.Visible = True
        Me.GV3_EXCEPT_YN.VisibleIndex = 15
        Me.GV3_EXCEPT_YN.Width = 50
        Me.Localizer1.SetWordID(Me.GV3_EXCEPT_YN, "제외")
        '
        'GV3_DEV_PIC
        '
        Me.GV3_DEV_PIC.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_DEV_PIC.AppearanceCell.Options.UseFont = True
        Me.GV3_DEV_PIC.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_DEV_PIC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_DEV_PIC.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV3_DEV_PIC.AppearanceHeader.Options.UseFont = True
        Me.GV3_DEV_PIC.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_DEV_PIC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_DEV_PIC.Caption = "담당개발자"
        Me.GV3_DEV_PIC.FieldName = "DEV_PIC"
        Me.GV3_DEV_PIC.Name = "GV3_DEV_PIC"
        Me.GV3_DEV_PIC.OptionsColumn.AllowEdit = False
        Me.GV3_DEV_PIC.OptionsColumn.ReadOnly = True
        Me.GV3_DEV_PIC.Visible = True
        Me.GV3_DEV_PIC.VisibleIndex = 16
        Me.GV3_DEV_PIC.Width = 100
        Me.Localizer1.SetWordID(Me.GV3_DEV_PIC, "담당개발자")
        '
        'ModifySplit
        '
        Me.ModifySplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModifySplit.Location = New System.Drawing.Point(0, 0)
        Me.ModifySplit.Name = "ModifySplit"
        Me.ModifySplit.Panel1.Controls.Add(Me.PanelControl4)
        Me.ModifySplit.Panel1.Text = "Panel1"
        Me.ModifySplit.Panel2.Controls.Add(Me.GroupControl3)
        Me.ModifySplit.Panel2.Text = "Panel2"
        Me.ModifySplit.Size = New System.Drawing.Size(1422, 340)
        Me.ModifySplit.SplitterPosition = 586
        Me.ModifySplit.TabIndex = 281
        Me.ModifySplit.Text = "ModifySplit"
        Me.Localizer1.SetWordID(Me.ModifySplit, "ModifySplit")
        '
        'PanelControl4
        '
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.FileInputSplit)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(586, 340)
        Me.PanelControl4.TabIndex = 279
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        '
        'FileInputSplit
        '
        Me.FileInputSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileInputSplit.Horizontal = False
        Me.FileInputSplit.Location = New System.Drawing.Point(0, 0)
        Me.FileInputSplit.Name = "FileInputSplit"
        Me.FileInputSplit.Panel1.Controls.Add(Me.PanelControl5)
        Me.FileInputSplit.Panel1.Text = "Panel1"
        Me.FileInputSplit.Panel2.Text = "Panel2"
        Me.FileInputSplit.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.FileInputSplit.Size = New System.Drawing.Size(586, 340)
        Me.FileInputSplit.SplitterPosition = 185
        Me.FileInputSplit.TabIndex = 283
        Me.FileInputSplit.Text = "FileInputSplit"
        Me.Localizer1.SetWordID(Me.FileInputSplit, "FileInputSplit")
        '
        'PanelControl5
        '
        Me.PanelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl5.Controls.Add(Me.GroupControl2)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(586, 340)
        Me.PanelControl5.TabIndex = 279
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.OhterDeptListPanel)
        Me.GroupControl2.Controls.Add(Me.Button2)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(586, 340)
        Me.GroupControl2.TabIndex = 293
        Me.GroupControl2.Text = "요청 사항"
        Me.Localizer1.SetWordID(Me.GroupControl2, "요청 사항")
        '
        'OhterDeptListPanel
        '
        Me.OhterDeptListPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.OhterDeptListPanel.Appearance.Options.UseBackColor = True
        Me.OhterDeptListPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.OhterDeptListPanel.Controls.Add(Me.PanelControl8)
        Me.OhterDeptListPanel.Controls.Add(Me.CONTENT)
        Me.OhterDeptListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OhterDeptListPanel.Location = New System.Drawing.Point(2, 23)
        Me.OhterDeptListPanel.Name = "OhterDeptListPanel"
        Me.OhterDeptListPanel.Size = New System.Drawing.Size(582, 315)
        Me.OhterDeptListPanel.TabIndex = 285
        Me.Localizer1.SetWordID(Me.OhterDeptListPanel, "")
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.SAVE_CNT)
        Me.PanelControl8.Controls.Add(Me.RANK_NM)
        Me.PanelControl8.Controls.Add(Me.INS_USR_NM)
        Me.PanelControl8.Controls.Add(Me.CmdAssign)
        Me.PanelControl8.Controls.Add(Me.MNGT_NO)
        Me.PanelControl8.Controls.Add(Me.Label8)
        Me.PanelControl8.Controls.Add(Me.Button1)
        Me.PanelControl8.Controls.Add(Me.REQ_USR)
        Me.PanelControl8.Controls.Add(Me.Label26)
        Me.PanelControl8.Controls.Add(Me.PRIORITY)
        Me.PanelControl8.Controls.Add(Me.Label10)
        Me.PanelControl8.Controls.Add(Me.AS_REQ_YMD)
        Me.PanelControl8.Controls.Add(Me.CUST_CD)
        Me.PanelControl8.Controls.Add(Me.TEL_NO)
        Me.PanelControl8.Controls.Add(Me.Label23)
        Me.PanelControl8.Controls.Add(Me.CUST_NM)
        Me.PanelControl8.Controls.Add(Me.Label9)
        Me.PanelControl8.Controls.Add(Me.Label20)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl8.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(197, 315)
        Me.PanelControl8.TabIndex = 10003
        Me.Localizer1.SetWordID(Me.PanelControl8, "")
        '
        'SAVE_CNT
        '
        Me.SAVE_CNT.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.SAVE_CNT.BorderColor = System.Drawing.Color.Silver
        Me.SAVE_CNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SAVE_CNT.DefVal = ""
        Me.SAVE_CNT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SAVE_CNT.IsDataStateAware = True
        Me.SAVE_CNT.Location = New System.Drawing.Point(177, 50)
        Me.SAVE_CNT.MaxLength = 30
        Me.SAVE_CNT.Name = "SAVE_CNT"
        Me.SAVE_CNT.NextFocus = ""
        Me.SAVE_CNT.ReadOnly = True
        Me.SAVE_CNT.RequiredFor = ""
        Me.SAVE_CNT.Size = New System.Drawing.Size(16, 23)
        Me.SAVE_CNT.TabIndex = 10003
        Me.SAVE_CNT.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'RANK_NM
        '
        Me.RANK_NM.AutoEllipsis = True
        Me.RANK_NM.BorderColor = System.Drawing.Color.Silver
        Me.RANK_NM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RANK_NM.LabelFor = Nothing
        Me.RANK_NM.Location = New System.Drawing.Point(157, 178)
        Me.RANK_NM.Name = "RANK_NM"
        Me.RANK_NM.Size = New System.Drawing.Size(35, 24)
        Me.RANK_NM.TabIndex = 10007
        Me.RANK_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'INS_USR_NM
        '
        Me.INS_USR_NM.BorderColor = System.Drawing.Color.Silver
        Me.INS_USR_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.INS_USR_NM.DefVal = ""
        Me.INS_USR_NM.IsDataStateAware = True
        Me.INS_USR_NM.Location = New System.Drawing.Point(65, 98)
        Me.INS_USR_NM.Name = "INS_USR_NM"
        Me.INS_USR_NM.NextFocus = "S_ROW_BEST"
        Me.INS_USR_NM.ReadOnly = True
        Me.INS_USR_NM.RequiredFor = ""
        Me.INS_USR_NM.Size = New System.Drawing.Size(128, 23)
        Me.INS_USR_NM.TabIndex = 10006
        Me.INS_USR_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'CmdAssign
        '
        Me.CmdAssign.Action = "SaveData"
        Me.CmdAssign.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.CmdAssign.Appearance.Options.UseFont = True
        Me.CmdAssign.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.CmdAssign.Image = CType(resources.GetObject("CmdAssign.Image"), System.Drawing.Image)
        Me.CmdAssign.Location = New System.Drawing.Point(65, 6)
        Me.CmdAssign.Name = "CmdAssign"
        Me.CmdAssign.Size = New System.Drawing.Size(128, 36)
        Me.CmdAssign.TabIndex = 10005
        Me.CmdAssign.Text = "배정"
        Me.Localizer1.SetWordID(Me.CmdAssign, "배정")
        '
        'MNGT_NO
        '
        Me.MNGT_NO.BorderColor = System.Drawing.Color.Silver
        Me.MNGT_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MNGT_NO.DefVal = ""
        Me.MNGT_NO.IsDataStateAware = True
        Me.MNGT_NO.Location = New System.Drawing.Point(65, 74)
        Me.MNGT_NO.Name = "MNGT_NO"
        Me.MNGT_NO.NextFocus = "S_ROW_BEST"
        Me.MNGT_NO.ReadOnly = True
        Me.MNGT_NO.RequiredFor = ""
        Me.MNGT_NO.Size = New System.Drawing.Size(128, 23)
        Me.MNGT_NO.TabIndex = 10003
        Me.MNGT_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.LabelFor = Nothing
        Me.Label8.Location = New System.Drawing.Point(5, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 15)
        Me.Label8.TabIndex = 251
        Me.Label8.Text = "요청일"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label8, "요청일자")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 25)
        Me.Button1.TabIndex = 10002
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        Me.Localizer1.SetWordID(Me.Button1, "...")
        '
        'REQ_USR
        '
        Me.REQ_USR.AutoEllipsis = True
        Me.REQ_USR.BorderColor = System.Drawing.Color.Silver
        Me.REQ_USR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.REQ_USR.LabelFor = Nothing
        Me.REQ_USR.Location = New System.Drawing.Point(65, 178)
        Me.REQ_USR.Name = "REQ_USR"
        Me.REQ_USR.Size = New System.Drawing.Size(91, 24)
        Me.REQ_USR.TabIndex = 241
        Me.REQ_USR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label26.LabelFor = Nothing
        Me.Label26.Location = New System.Drawing.Point(5, 76)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 15)
        Me.Label26.TabIndex = 282
        Me.Label26.Text = "관리번호"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label26, "관리번호")
        '
        'PRIORITY
        '
        Me.PRIORITY.AutoEllipsis = True
        Me.PRIORITY.BorderColor = System.Drawing.Color.Silver
        Me.PRIORITY.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PRIORITY.LabelFor = Nothing
        Me.PRIORITY.Location = New System.Drawing.Point(65, 228)
        Me.PRIORITY.Name = "PRIORITY"
        Me.PRIORITY.Size = New System.Drawing.Size(126, 24)
        Me.PRIORITY.TabIndex = 241
        Me.PRIORITY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.LabelFor = Nothing
        Me.Label10.Location = New System.Drawing.Point(5, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 239
        Me.Label10.Text = "거래처"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label10, "거래처")
        '
        'AS_REQ_YMD
        '
        Me.AS_REQ_YMD.AutoEllipsis = True
        Me.AS_REQ_YMD.BorderColor = System.Drawing.Color.Silver
        Me.AS_REQ_YMD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AS_REQ_YMD.LabelFor = Nothing
        Me.AS_REQ_YMD.Location = New System.Drawing.Point(65, 49)
        Me.AS_REQ_YMD.Name = "AS_REQ_YMD"
        Me.AS_REQ_YMD.Size = New System.Drawing.Size(111, 24)
        Me.AS_REQ_YMD.TabIndex = 241
        Me.AS_REQ_YMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CUST_CD
        '
        Me.CUST_CD.AutoEllipsis = True
        Me.CUST_CD.BorderColor = System.Drawing.Color.Silver
        Me.CUST_CD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CUST_CD.LabelFor = Nothing
        Me.CUST_CD.Location = New System.Drawing.Point(65, 125)
        Me.CUST_CD.Name = "CUST_CD"
        Me.CUST_CD.Size = New System.Drawing.Size(102, 24)
        Me.CUST_CD.TabIndex = 241
        Me.CUST_CD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TEL_NO
        '
        Me.TEL_NO.AutoEllipsis = True
        Me.TEL_NO.BorderColor = System.Drawing.Color.Silver
        Me.TEL_NO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TEL_NO.LabelFor = Nothing
        Me.TEL_NO.Location = New System.Drawing.Point(65, 203)
        Me.TEL_NO.Name = "TEL_NO"
        Me.TEL_NO.Size = New System.Drawing.Size(126, 24)
        Me.TEL_NO.TabIndex = 281
        Me.TEL_NO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label23.LabelFor = Nothing
        Me.Label23.Location = New System.Drawing.Point(5, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 15)
        Me.Label23.TabIndex = 239
        Me.Label23.Text = "등록자"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label23, "등록자")
        '
        'CUST_NM
        '
        Me.CUST_NM.AutoEllipsis = True
        Me.CUST_NM.BorderColor = System.Drawing.Color.Silver
        Me.CUST_NM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CUST_NM.LabelFor = Nothing
        Me.CUST_NM.Location = New System.Drawing.Point(65, 150)
        Me.CUST_NM.Name = "CUST_NM"
        Me.CUST_NM.Size = New System.Drawing.Size(127, 24)
        Me.CUST_NM.TabIndex = 241
        Me.CUST_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.LabelFor = Nothing
        Me.Label9.Location = New System.Drawing.Point(5, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 15)
        Me.Label9.TabIndex = 243
        Me.Label9.Text = "요청자"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label9, "요청자")
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label20.LabelFor = Nothing
        Me.Label20.Location = New System.Drawing.Point(5, 232)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 15)
        Me.Label20.TabIndex = 271
        Me.Label20.Text = "우선순위"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label20, "우선순위")
        '
        'CONTENT
        '
        Me.CONTENT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CONTENT.BackColor = System.Drawing.SystemColors.Window
        Me.CONTENT.BorderColor = System.Drawing.Color.Silver
        Me.CONTENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CONTENT.DefVal = ""
        Me.CONTENT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONTENT.IsDataStateAware = True
        Me.CONTENT.Location = New System.Drawing.Point(199, 3)
        Me.CONTENT.MaxLength = 0
        Me.CONTENT.Multiline = True
        Me.CONTENT.Name = "CONTENT"
        Me.CONTENT.NextFocus = """"""
        Me.CONTENT.ReadOnly = True
        Me.CONTENT.RequiredFor = ""
        Me.CONTENT.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.CONTENT.Size = New System.Drawing.Size(380, 309)
        Me.CONTENT.TabIndex = 229
        Me.CONTENT.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.CONTENT.WordWrap = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(537, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 21)
        Me.Button2.TabIndex = 10001
        Me.Button2.UseVisualStyleBackColor = True
        Me.Localizer1.SetWordID(Me.Button2, "")
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.DevDeptListPanel)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(830, 340)
        Me.GroupControl3.TabIndex = 293
        Me.GroupControl3.Text = "솔루션 개발팀"
        Me.Localizer1.SetWordID(Me.GroupControl3, "솔루션 개발팀")
        '
        'DevDeptListPanel
        '
        Me.DevDeptListPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DevDeptListPanel.Appearance.Options.UseBackColor = True
        Me.DevDeptListPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DevDeptListPanel.Controls.Add(Me.Label33)
        Me.DevDeptListPanel.Controls.Add(Me.REQ_HM)
        Me.DevDeptListPanel.Controls.Add(Me.REQ_YMD)
        Me.DevDeptListPanel.Controls.Add(Me.CMPT_HM)
        Me.DevDeptListPanel.Controls.Add(Me.Label31)
        Me.DevDeptListPanel.Controls.Add(Me.SHARE_YN)
        Me.DevDeptListPanel.Controls.Add(Me.DEV_ERR_NM)
        Me.DevDeptListPanel.Controls.Add(Me.Label30)
        Me.DevDeptListPanel.Controls.Add(Me.DEV_ERR_YN)
        Me.DevDeptListPanel.Controls.Add(Me.RANK)
        Me.DevDeptListPanel.Controls.Add(Me.Label17)
        Me.DevDeptListPanel.Controls.Add(Me.WORK_USR)
        Me.DevDeptListPanel.Controls.Add(Me.btnSave)
        Me.DevDeptListPanel.Controls.Add(Me.Label12)
        Me.DevDeptListPanel.Controls.Add(Me.Label7)
        Me.DevDeptListPanel.Controls.Add(Me.xtcETC)
        Me.DevDeptListPanel.Controls.Add(Me.REQ_SVC3)
        Me.DevDeptListPanel.Controls.Add(Me.REQ_SVC2)
        Me.DevDeptListPanel.Controls.Add(Me.REQ_SVC)
        Me.DevDeptListPanel.Controls.Add(Me.Label29)
        Me.DevDeptListPanel.Controls.Add(Me.PROC_TYPE)
        Me.DevDeptListPanel.Controls.Add(Me.CMPT_YMD)
        Me.DevDeptListPanel.Controls.Add(Me.Label21)
        Me.DevDeptListPanel.Controls.Add(Me.Label28)
        Me.DevDeptListPanel.Controls.Add(Me.Label19)
        Me.DevDeptListPanel.Controls.Add(Me.PRAR_YMD)
        Me.DevDeptListPanel.Controls.Add(Me.Label11)
        Me.DevDeptListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DevDeptListPanel.Location = New System.Drawing.Point(2, 23)
        Me.DevDeptListPanel.Name = "DevDeptListPanel"
        Me.DevDeptListPanel.Size = New System.Drawing.Size(826, 315)
        Me.DevDeptListPanel.TabIndex = 284
        Me.Localizer1.SetWordID(Me.DevDeptListPanel, "")
        '
        'Label33
        '
        Me.Label33.LabelFor = Nothing
        Me.Label33.Location = New System.Drawing.Point(5, 217)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 21)
        Me.Label33.TabIndex = 308
        Me.Label33.Text = "시작일자"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label33, "시작일자")
        '
        'REQ_HM
        '
        Me.REQ_HM.BorderColor = System.Drawing.Color.Silver
        Me.REQ_HM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.REQ_HM.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.REQ_HM.DefVal = Nothing
        Me.REQ_HM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.REQ_HM.IsDataStateAware = True
        Me.REQ_HM.Location = New System.Drawing.Point(177, 215)
        Me.REQ_HM.Mask = "90:00"
        Me.REQ_HM.Name = "REQ_HM"
        Me.REQ_HM.NextFocus = "CMPT_YMD"
        Me.REQ_HM.RequiredFor = ""
        Me.REQ_HM.Size = New System.Drawing.Size(31, 23)
        Me.REQ_HM.TabIndex = 307
        Me.REQ_HM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.REQ_HM.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.REQ_HM.ValidatingType = GetType(Date)
        Me.Localizer1.SetWordID(Me.REQ_HM, "")
        '
        'REQ_YMD
        '
        Me.REQ_YMD.BorderColor = System.Drawing.Color.Silver
        Me.REQ_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.REQ_YMD.DefVal = ""
        Me.REQ_YMD.IconVisible = True
        Me.REQ_YMD.IsDataStateAware = True
        Me.REQ_YMD.Location = New System.Drawing.Point(85, 215)
        Me.REQ_YMD.Name = "REQ_YMD"
        Me.REQ_YMD.NextFocus = "REQ_HM"
        Me.REQ_YMD.RequiredFor = ""
        Me.REQ_YMD.Size = New System.Drawing.Size(91, 23)
        Me.REQ_YMD.TabIndex = 306
        Me.Localizer1.SetWordID(Me.REQ_YMD, "")
        '
        'CMPT_HM
        '
        Me.CMPT_HM.BorderColor = System.Drawing.Color.Silver
        Me.CMPT_HM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CMPT_HM.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.CMPT_HM.DefVal = Nothing
        Me.CMPT_HM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CMPT_HM.IsDataStateAware = True
        Me.CMPT_HM.Location = New System.Drawing.Point(177, 239)
        Me.CMPT_HM.Mask = "90:00"
        Me.CMPT_HM.Name = "CMPT_HM"
        Me.CMPT_HM.NextFocus = "DEV_TEST_CHK_YMD"
        Me.CMPT_HM.RequiredFor = ""
        Me.CMPT_HM.Size = New System.Drawing.Size(31, 23)
        Me.CMPT_HM.TabIndex = 305
        Me.CMPT_HM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.CMPT_HM.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.CMPT_HM.ValidatingType = GetType(Date)
        Me.Localizer1.SetWordID(Me.CMPT_HM, "")
        '
        'Label31
        '
        Me.Label31.LabelFor = Nothing
        Me.Label31.Location = New System.Drawing.Point(5, 289)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(77, 21)
        Me.Label31.TabIndex = 304
        Me.Label31.Text = "내부 공유"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label31, "내부 공유")
        '
        'SHARE_YN
        '
        Me.SHARE_YN.BindingPropertyName = "YesNo"
        Me.SHARE_YN.DefVal = False
        Me.SHARE_YN.IsDataStateAware = True
        Me.SHARE_YN.Location = New System.Drawing.Point(85, 289)
        Me.SHARE_YN.Name = "SHARE_YN"
        Me.SHARE_YN.NextFocus = "PRT_OPT4"
        Me.SHARE_YN.Properties.Caption = ""
        Me.SHARE_YN.RequiredFor = ""
        Me.SHARE_YN.Size = New System.Drawing.Size(25, 19)
        Me.SHARE_YN.TabIndex = 303
        Me.Localizer1.SetWordID(Me.SHARE_YN, "")
        Me.SHARE_YN.YesNo = "N"
        '
        'DEV_ERR_NM
        '
        Me.DEV_ERR_NM.BorderColor = System.Drawing.Color.Silver
        Me.DEV_ERR_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DEV_ERR_NM.DefVal = ""
        Me.DEV_ERR_NM.IsDataStateAware = True
        Me.DEV_ERR_NM.Location = New System.Drawing.Point(107, 263)
        Me.DEV_ERR_NM.Name = "DEV_ERR_NM"
        Me.DEV_ERR_NM.NextFocus = "S_ROW_BEST"
        Me.DEV_ERR_NM.ReadOnly = True
        Me.DEV_ERR_NM.RequiredFor = ""
        Me.DEV_ERR_NM.Size = New System.Drawing.Size(101, 23)
        Me.DEV_ERR_NM.TabIndex = 300
        Me.DEV_ERR_NM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DEV_ERR_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label30
        '
        Me.Label30.LabelFor = Nothing
        Me.Label30.Location = New System.Drawing.Point(5, 263)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 21)
        Me.Label30.TabIndex = 302
        Me.Label30.Text = "결함"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label30, "결함")
        '
        'DEV_ERR_YN
        '
        Me.DEV_ERR_YN.BindingPropertyName = "YesNo"
        Me.DEV_ERR_YN.DefVal = False
        Me.DEV_ERR_YN.IsDataStateAware = True
        Me.DEV_ERR_YN.Location = New System.Drawing.Point(85, 265)
        Me.DEV_ERR_YN.Name = "DEV_ERR_YN"
        Me.DEV_ERR_YN.NextFocus = "PRT_OPT4"
        Me.DEV_ERR_YN.Properties.Caption = ""
        Me.DEV_ERR_YN.RequiredFor = ""
        Me.DEV_ERR_YN.Size = New System.Drawing.Size(25, 19)
        Me.DEV_ERR_YN.TabIndex = 301
        Me.Localizer1.SetWordID(Me.DEV_ERR_YN, "")
        Me.DEV_ERR_YN.YesNo = "N"
        '
        'RANK
        '
        Me.RANK.CodeType = ""
        Me.RANK.ColumnWidths = ""
        Me.RANK.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.RANK.DataParams = ""
        Me.RANK.DefVal = ""
        Me.RANK.DisplayMember = "NAME"
        Me.RANK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RANK.FormattingEnabled = True
        Me.RANK.IsDataStateAware = True
        Me.RANK.ItemDelimiter = ","
        Me.RANK.ItemTextList = "상,중,하"
        Me.RANK.ItemValueList = "A,B,C"
        Me.RANK.KeepIntegrity = True
        Me.RANK.Location = New System.Drawing.Point(85, 167)
        Me.RANK.Name = "RANK"
        Me.RANK.NextFocus = "PRAR_YMD"
        Me.RANK.NullText = " "
        Me.RANK.RequiredFor = ""
        Me.RANK.SearchKeys = ""
        Me.RANK.Size = New System.Drawing.Size(123, 23)
        Me.RANK.TabIndex = 297
        Me.RANK.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.RANK.ValueMember = "CODE"
        '
        'Label17
        '
        Me.Label17.LabelFor = Nothing
        Me.Label17.Location = New System.Drawing.Point(5, 169)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 21)
        Me.Label17.TabIndex = 296
        Me.Label17.Text = "난이도"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label17, "난이도")
        '
        'WORK_USR
        '
        Me.WORK_USR.CodeType = ""
        Me.WORK_USR.ColumnWidths = ""
        Me.WORK_USR.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.WORK_USR.DataParams = ""
        Me.WORK_USR.DefVal = ""
        Me.WORK_USR.DisplayMember = "NAME"
        Me.WORK_USR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WORK_USR.FormattingEnabled = True
        Me.WORK_USR.IsDataStateAware = True
        Me.WORK_USR.ItemDelimiter = ","
        Me.WORK_USR.ItemTextList = ""
        Me.WORK_USR.ItemValueList = ""
        Me.WORK_USR.KeepIntegrity = True
        Me.WORK_USR.Location = New System.Drawing.Point(85, 143)
        Me.WORK_USR.Name = "WORK_USR"
        Me.WORK_USR.NextFocus = "RANK"
        Me.WORK_USR.NullText = " "
        Me.WORK_USR.RequiredFor = ""
        Me.WORK_USR.SearchKeys = ""
        Me.WORK_USR.Size = New System.Drawing.Size(123, 23)
        Me.WORK_USR.TabIndex = 293
        Me.WORK_USR.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WORK_USR.ValueMember = "CODE"
        '
        'Label12
        '
        Me.Label12.LabelFor = Nothing
        Me.Label12.Location = New System.Drawing.Point(29, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 21)
        Me.Label12.TabIndex = 292
        Me.Label12.Text = "3)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label12, "3)")
        '
        'Label7
        '
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(5, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 21)
        Me.Label7.TabIndex = 291
        Me.Label7.Text = "2)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label7, "2)")
        '
        'xtcETC
        '
        Me.xtcETC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcETC.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.xtcETC.Appearance.Options.UseBackColor = True
        Me.xtcETC.Location = New System.Drawing.Point(214, 6)
        Me.xtcETC.Name = "xtcETC"
        Me.xtcETC.SelectedTabPage = Me.XtraTabPage2
        Me.xtcETC.Size = New System.Drawing.Size(605, 306)
        Me.xtcETC.TabIndex = 279
        Me.xtcETC.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage1})
        Me.Localizer1.SetWordID(Me.xtcETC, "")
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Label13)
        Me.XtraTabPage2.Controls.Add(Me.DEV_RMK)
        Me.XtraTabPage2.Controls.Add(Me.RMK)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(600, 280)
        Me.XtraTabPage2.Text = "개발팀 처리결과"
        Me.Localizer1.SetWordID(Me.XtraTabPage2, "개발팀 처리결과")
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.LabelFor = Nothing
        Me.Label13.Location = New System.Drawing.Point(9, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 21)
        Me.Label13.TabIndex = 287
        Me.Label13.Text = "비고"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label13, "비고")
        '
        'DEV_RMK
        '
        Me.DEV_RMK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DEV_RMK.BackColor = System.Drawing.SystemColors.Window
        Me.DEV_RMK.BorderColor = System.Drawing.Color.Silver
        Me.DEV_RMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DEV_RMK.DefVal = ""
        Me.DEV_RMK.IsDataStateAware = True
        Me.DEV_RMK.Location = New System.Drawing.Point(9, 219)
        Me.DEV_RMK.MaxLength = 0
        Me.DEV_RMK.Multiline = True
        Me.DEV_RMK.Name = "DEV_RMK"
        Me.DEV_RMK.NextFocus = "btnSave"
        Me.DEV_RMK.RequiredFor = ""
        Me.DEV_RMK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DEV_RMK.Size = New System.Drawing.Size(585, 56)
        Me.DEV_RMK.TabIndex = 286
        Me.DEV_RMK.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'RMK
        '
        Me.RMK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RMK.BackColor = System.Drawing.SystemColors.Window
        Me.RMK.BorderColor = System.Drawing.Color.Silver
        Me.RMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RMK.DefVal = ""
        Me.RMK.IsDataStateAware = True
        Me.RMK.Location = New System.Drawing.Point(9, 9)
        Me.RMK.MaxLength = 0
        Me.RMK.Multiline = True
        Me.RMK.Name = "RMK"
        Me.RMK.NextFocus = "DEV_RMK"
        Me.RMK.RequiredFor = ""
        Me.RMK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RMK.Size = New System.Drawing.Size(585, 186)
        Me.RMK.TabIndex = 259
        Me.RMK.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.CMPT_RMK)
        Me.XtraTabPage3.Controls.Add(Me.PanelControl9)
        Me.XtraTabPage3.Controls.Add(Me.TextBox4)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(599, 279)
        Me.XtraTabPage3.Text = "고객게시판 답변"
        Me.Localizer1.SetWordID(Me.XtraTabPage3, "고객게시판 답변")
        '
        'CMPT_RMK
        '
        Me.CMPT_RMK.BackColor = System.Drawing.Color.Linen
        Me.CMPT_RMK.BorderColor = System.Drawing.Color.Silver
        Me.CMPT_RMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CMPT_RMK.DefVal = ""
        Me.CMPT_RMK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CMPT_RMK.IsDataStateAware = True
        Me.CMPT_RMK.Location = New System.Drawing.Point(0, 36)
        Me.CMPT_RMK.MaxLength = 0
        Me.CMPT_RMK.Multiline = True
        Me.CMPT_RMK.Name = "CMPT_RMK"
        Me.CMPT_RMK.NextFocus = "btnSave"
        Me.CMPT_RMK.RequiredFor = ""
        Me.CMPT_RMK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CMPT_RMK.Size = New System.Drawing.Size(599, 243)
        Me.CMPT_RMK.TabIndex = 261
        Me.CMPT_RMK.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.Button3)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl9.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(599, 36)
        Me.PanelControl9.TabIndex = 262
        Me.Localizer1.SetWordID(Me.PanelControl9, "")
        '
        'Button3
        '
        Me.Button3.Action = "SearchData"
        Me.Button3.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.Button3.Location = New System.Drawing.Point(7, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 25)
        Me.Button3.TabIndex = 261
        Me.Button3.Text = "고객 답변 등록"
        Me.Localizer1.SetWordID(Me.Button3, "고객 답변 등록")
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.BorderColor = System.Drawing.Color.Silver
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.DefVal = ""
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.IsDataStateAware = True
        Me.TextBox4.Location = New System.Drawing.Point(0, 0)
        Me.TextBox4.MaxLength = 0
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.NextFocus = "btnSave"
        Me.TextBox4.RequiredFor = ""
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(599, 279)
        Me.TextBox4.TabIndex = 260
        Me.TextBox4.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.WG2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(599, 279)
        Me.XtraTabPage1.Text = "첨부파일"
        Me.Localizer1.SetWordID(Me.XtraTabPage1, "첨부파일")
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.AllowDrop = True
        Me.WG2.DeleteRowConfirmation = False
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(0, 0)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageComboBox1, Me.RepositoryItemTextEdit3, Me.RepositoryItemMemoExEdit1})
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(599, 279)
        Me.WG2.TabIndex = 277
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand20, Me.gridBand21, Me.gridBand22, Me.gridBand32, Me.gridBand3, Me.gridBand1, Me.gridBand2})
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.GV2_FILE_NM, Me.GV2_MNGT_NO, Me.GV2_FILE_PATH, Me.GV2_FILE_ICON, Me.GV2_UPLOAD, Me.GV2_SEQ, Me.GV2_INS_YMD, Me.GV2_SUCCESS, Me.GV2_RMK, Me.GV2_FILE_SIZE})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.IndicatorWidth = 40
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsCustomization.AllowColumnMoving = False
        Me.GV2.OptionsCustomization.AllowFilter = False
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsPrint.AutoWidth = False
        Me.GV2.OptionsPrint.PrintHeader = False
        Me.GV2.OptionsView.ShowColumnHeaders = False
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorzLines = False
        Me.GV2.OptionsView.ShowVertLines = False
        '
        'gridBand20
        '
        Me.gridBand20.Caption = "Type"
        Me.gridBand20.MinWidth = 20
        Me.gridBand20.Name = "gridBand20"
        Me.gridBand20.Visible = False
        Me.gridBand20.Width = 100
        Me.Localizer1.SetWordID(Me.gridBand20, "Type")
        '
        'gridBand21
        '
        Me.gridBand21.Caption = "Document No"
        Me.gridBand21.MinWidth = 20
        Me.gridBand21.Name = "gridBand21"
        Me.gridBand21.Visible = False
        Me.gridBand21.Width = 200
        Me.Localizer1.SetWordID(Me.gridBand21, "Document No")
        '
        'gridBand22
        '
        Me.gridBand22.Caption = "File"
        Me.gridBand22.Columns.Add(Me.GV2_FILE_ICON)
        Me.gridBand22.Columns.Add(Me.GV2_FILE_NM)
        Me.gridBand22.Columns.Add(Me.GV2_UPLOAD)
        Me.gridBand22.Columns.Add(Me.GV2_SUCCESS)
        Me.gridBand22.MinWidth = 20
        Me.gridBand22.Name = "gridBand22"
        Me.gridBand22.Width = 307
        Me.Localizer1.SetWordID(Me.gridBand22, "File")
        '
        'GV2_FILE_ICON
        '
        Me.GV2_FILE_ICON.Caption = "File Icon"
        Me.GV2_FILE_ICON.FieldName = "FILE_ICON"
        Me.GV2_FILE_ICON.Name = "GV2_FILE_ICON"
        Me.GV2_FILE_ICON.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV2_FILE_ICON.OptionsColumn.FixedWidth = True
        Me.GV2_FILE_ICON.OptionsColumn.ReadOnly = True
        Me.GV2_FILE_ICON.Visible = True
        Me.GV2_FILE_ICON.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_FILE_ICON, "File Icon")
        '
        'GV2_FILE_NM
        '
        Me.GV2_FILE_NM.Caption = "File"
        Me.GV2_FILE_NM.FieldName = "FILE_NM"
        Me.GV2_FILE_NM.Name = "GV2_FILE_NM"
        Me.GV2_FILE_NM.OptionsColumn.AllowEdit = False
        Me.GV2_FILE_NM.Visible = True
        Me.GV2_FILE_NM.Width = 241
        Me.Localizer1.SetWordID(Me.GV2_FILE_NM, "File")
        '
        'GV2_UPLOAD
        '
        Me.GV2_UPLOAD.FieldName = "UPLOAD"
        Me.GV2_UPLOAD.Name = "GV2_UPLOAD"
        Me.GV2_UPLOAD.OptionsColumn.AllowEdit = False
        Me.GV2_UPLOAD.OptionsColumn.FixedWidth = True
        Me.GV2_UPLOAD.OptionsColumn.ReadOnly = True
        Me.GV2_UPLOAD.Visible = True
        Me.GV2_UPLOAD.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_UPLOAD, "")
        '
        'GV2_SUCCESS
        '
        Me.GV2_SUCCESS.Caption = "Success"
        Me.GV2_SUCCESS.FieldName = "SUCCESS"
        Me.GV2_SUCCESS.Name = "GV2_SUCCESS"
        Me.GV2_SUCCESS.OptionsColumn.AllowEdit = False
        Me.GV2_SUCCESS.OptionsColumn.FixedWidth = True
        Me.GV2_SUCCESS.OptionsColumn.ReadOnly = True
        Me.GV2_SUCCESS.Visible = True
        Me.GV2_SUCCESS.Width = 26
        Me.Localizer1.SetWordID(Me.GV2_SUCCESS, "Success")
        '
        'gridBand32
        '
        Me.gridBand32.Caption = "Full path"
        Me.gridBand32.Columns.Add(Me.GV2_FILE_PATH)
        Me.gridBand32.MinWidth = 20
        Me.gridBand32.Name = "gridBand32"
        Me.gridBand32.Visible = False
        Me.gridBand32.Width = 120
        Me.Localizer1.SetWordID(Me.gridBand32, "Full path")
        '
        'GV2_FILE_PATH
        '
        Me.GV2_FILE_PATH.Caption = "Full path"
        Me.GV2_FILE_PATH.FieldName = "FILE_PATH"
        Me.GV2_FILE_PATH.Name = "GV2_FILE_PATH"
        Me.GV2_FILE_PATH.Width = 120
        Me.Localizer1.SetWordID(Me.GV2_FILE_PATH, "Full path")
        '
        'gridBand3
        '
        Me.gridBand3.Caption = "Size"
        Me.gridBand3.Columns.Add(Me.GV2_FILE_SIZE)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.Width = 101
        Me.Localizer1.SetWordID(Me.gridBand3, "Size")
        '
        'GV2_FILE_SIZE
        '
        Me.GV2_FILE_SIZE.Caption = "Size"
        Me.GV2_FILE_SIZE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GV2_FILE_SIZE.FieldName = "FILE_SIZE"
        Me.GV2_FILE_SIZE.Name = "GV2_FILE_SIZE"
        Me.GV2_FILE_SIZE.OptionsColumn.AllowEdit = False
        Me.GV2_FILE_SIZE.OptionsColumn.ReadOnly = True
        Me.GV2_FILE_SIZE.Visible = True
        Me.GV2_FILE_SIZE.Width = 101
        Me.Localizer1.SetWordID(Me.GV2_FILE_SIZE, "Size")
        '
        'gridBand1
        '
        Me.gridBand1.Caption = "Remark"
        Me.gridBand1.Columns.Add(Me.GV2_RMK)
        Me.gridBand1.Name = "gridBand1"
        Me.gridBand1.Width = 98
        Me.Localizer1.SetWordID(Me.gridBand1, "Remark")
        '
        'GV2_RMK
        '
        Me.GV2_RMK.Caption = "Remark"
        Me.GV2_RMK.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GV2_RMK.FieldName = "RMK"
        Me.GV2_RMK.Name = "GV2_RMK"
        Me.GV2_RMK.Visible = True
        Me.GV2_RMK.Width = 98
        Me.Localizer1.SetWordID(Me.GV2_RMK, "Remark")
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "Screen"
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.Visible = False
        Me.Localizer1.SetWordID(Me.gridBand2, "Screen")
        '
        'GV2_MNGT_NO
        '
        Me.GV2_MNGT_NO.Caption = "MNGT NO"
        Me.GV2_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV2_MNGT_NO.Name = "GV2_MNGT_NO"
        Me.GV2_MNGT_NO.Visible = True
        Me.GV2_MNGT_NO.Width = 70
        Me.Localizer1.SetWordID(Me.GV2_MNGT_NO, "MNGT NO")
        '
        'GV2_SEQ
        '
        Me.GV2_SEQ.Caption = "SEQ"
        Me.GV2_SEQ.FieldName = "SEQ"
        Me.GV2_SEQ.Name = "GV2_SEQ"
        Me.GV2_SEQ.Visible = True
        Me.Localizer1.SetWordID(Me.GV2_SEQ, "SEQ")
        '
        'GV2_INS_YMD
        '
        Me.GV2_INS_YMD.Caption = "Inserted Date"
        Me.GV2_INS_YMD.FieldName = "INS_YMD"
        Me.GV2_INS_YMD.Name = "GV2_INS_YMD"
        Me.Localizer1.SetWordID(Me.GV2_INS_YMD, "Inserted Date")
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "dft", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "avi", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "exe", 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "pdf", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "mp3", 9), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "mp4", 10), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "xls", 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "xlsx", 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "jpg", 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "png", 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "rar", 8), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "doc", 11), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "docx", 11), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "ppt", 12), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "pptx", 12), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "txt", 13), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "wmv", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "zip", 15), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "hwp", 16), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "UPLOAD", 19)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'REQ_SVC3
        '
        Me.REQ_SVC3.CodeType = "YJIT.CodeService.CommonCode"
        Me.REQ_SVC3.ColumnWidths = ""
        Me.REQ_SVC3.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.REQ_SVC3.DataParams = "GroupCode:'Z03',NameType:''"
        Me.REQ_SVC3.DefVal = ""
        Me.REQ_SVC3.DisplayMember = "NAME"
        Me.REQ_SVC3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.REQ_SVC3.FormattingEnabled = True
        Me.REQ_SVC3.IsDataStateAware = True
        Me.REQ_SVC3.ItemDelimiter = ","
        Me.REQ_SVC3.ItemTextList = ""
        Me.REQ_SVC3.ItemValueList = ""
        Me.REQ_SVC3.KeepIntegrity = True
        Me.REQ_SVC3.Location = New System.Drawing.Point(85, 95)
        Me.REQ_SVC3.Name = "REQ_SVC3"
        Me.REQ_SVC3.NextFocus = "PROC_TYPE"
        Me.REQ_SVC3.NullText = " "
        Me.REQ_SVC3.RequiredFor = ""
        Me.REQ_SVC3.SearchKeys = ""
        Me.REQ_SVC3.Size = New System.Drawing.Size(123, 23)
        Me.REQ_SVC3.TabIndex = 290
        Me.REQ_SVC3.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.REQ_SVC3.ValueMember = "CODE"
        '
        'REQ_SVC2
        '
        Me.REQ_SVC2.CodeType = "YJIT.CodeService.CommonCode"
        Me.REQ_SVC2.ColumnWidths = ""
        Me.REQ_SVC2.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.REQ_SVC2.DataParams = "GroupCode:'T11',NameType:''"
        Me.REQ_SVC2.DefVal = "B"
        Me.REQ_SVC2.DisplayMember = "NAME"
        Me.REQ_SVC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.REQ_SVC2.FormattingEnabled = True
        Me.REQ_SVC2.IsDataStateAware = True
        Me.REQ_SVC2.ItemDelimiter = ","
        Me.REQ_SVC2.ItemTextList = ""
        Me.REQ_SVC2.ItemValueList = ""
        Me.REQ_SVC2.KeepIntegrity = True
        Me.REQ_SVC2.Location = New System.Drawing.Point(85, 71)
        Me.REQ_SVC2.Name = "REQ_SVC2"
        Me.REQ_SVC2.NextFocus = "REQ_SVC3"
        Me.REQ_SVC2.NullText = "--Select--"
        Me.REQ_SVC2.RequiredFor = ""
        Me.REQ_SVC2.SearchKeys = ""
        Me.REQ_SVC2.Size = New System.Drawing.Size(123, 23)
        Me.REQ_SVC2.TabIndex = 289
        Me.REQ_SVC2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.REQ_SVC2.ValueMember = "CODE"
        '
        'REQ_SVC
        '
        Me.REQ_SVC.CodeType = "YJIT.CodeService.CommonCode"
        Me.REQ_SVC.ColumnWidths = ""
        Me.REQ_SVC.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.REQ_SVC.DataParams = "GroupCode:'Z01',NameType:''"
        Me.REQ_SVC.DefVal = ""
        Me.REQ_SVC.DisplayMember = "NAME"
        Me.REQ_SVC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.REQ_SVC.FormattingEnabled = True
        Me.REQ_SVC.IsDataStateAware = True
        Me.REQ_SVC.ItemDelimiter = ","
        Me.REQ_SVC.ItemTextList = ""
        Me.REQ_SVC.ItemValueList = ""
        Me.REQ_SVC.KeepIntegrity = True
        Me.REQ_SVC.Location = New System.Drawing.Point(85, 47)
        Me.REQ_SVC.Name = "REQ_SVC"
        Me.REQ_SVC.NextFocus = "REQ_SVC2"
        Me.REQ_SVC.NullText = " "
        Me.REQ_SVC.RequiredFor = ""
        Me.REQ_SVC.SearchKeys = ""
        Me.REQ_SVC.Size = New System.Drawing.Size(123, 23)
        Me.REQ_SVC.TabIndex = 287
        Me.REQ_SVC.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.REQ_SVC.ValueMember = "CODE"
        '
        'Label29
        '
        Me.Label29.LabelFor = Nothing
        Me.Label29.Location = New System.Drawing.Point(5, 49)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 21)
        Me.Label29.TabIndex = 288
        Me.Label29.Text = "업무구분 1)"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label29, "업무구분 1)")
        '
        'PROC_TYPE
        '
        Me.PROC_TYPE.CodeType = "YJIT.CodeService.CommonCode"
        Me.PROC_TYPE.ColumnWidths = ""
        Me.PROC_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.PROC_TYPE.DataParams = "GroupCode:'T07',NameType:''"
        Me.PROC_TYPE.DefVal = ""
        Me.PROC_TYPE.DisplayMember = "NAME"
        Me.PROC_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PROC_TYPE.FormattingEnabled = True
        Me.PROC_TYPE.IsDataStateAware = True
        Me.PROC_TYPE.ItemDelimiter = ","
        Me.PROC_TYPE.ItemTextList = ""
        Me.PROC_TYPE.ItemValueList = ""
        Me.PROC_TYPE.KeepIntegrity = True
        Me.PROC_TYPE.Location = New System.Drawing.Point(85, 119)
        Me.PROC_TYPE.Name = "PROC_TYPE"
        Me.PROC_TYPE.NextFocus = "WORK_USR"
        Me.PROC_TYPE.NullText = ""
        Me.PROC_TYPE.RequiredFor = ""
        Me.PROC_TYPE.SearchKeys = ""
        Me.PROC_TYPE.Size = New System.Drawing.Size(123, 23)
        Me.PROC_TYPE.TabIndex = 276
        Me.PROC_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.PROC_TYPE.ValueMember = "CODE"
        '
        'CMPT_YMD
        '
        Me.CMPT_YMD.BorderColor = System.Drawing.Color.Silver
        Me.CMPT_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CMPT_YMD.DefVal = ""
        Me.CMPT_YMD.IconVisible = True
        Me.CMPT_YMD.IsDataStateAware = True
        Me.CMPT_YMD.Location = New System.Drawing.Point(85, 239)
        Me.CMPT_YMD.Name = "CMPT_YMD"
        Me.CMPT_YMD.NextFocus = "CMPT_HM"
        Me.CMPT_YMD.RequiredFor = ""
        Me.CMPT_YMD.Size = New System.Drawing.Size(91, 23)
        Me.CMPT_YMD.TabIndex = 252
        Me.Localizer1.SetWordID(Me.CMPT_YMD, "")
        '
        'Label21
        '
        Me.Label21.LabelFor = Nothing
        Me.Label21.Location = New System.Drawing.Point(5, 119)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 21)
        Me.Label21.TabIndex = 275
        Me.Label21.Text = "진행현황"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label21, "진행현황")
        '
        'Label28
        '
        Me.Label28.LabelFor = Nothing
        Me.Label28.Location = New System.Drawing.Point(5, 240)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 21)
        Me.Label28.TabIndex = 251
        Me.Label28.Text = "완료일자"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label28, "완료일자")
        '
        'Label19
        '
        Me.Label19.LabelFor = Nothing
        Me.Label19.Location = New System.Drawing.Point(36, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 21)
        Me.Label19.TabIndex = 284
        Me.Label19.Text = "담당자"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label19, "담당자")
        '
        'PRAR_YMD
        '
        Me.PRAR_YMD.BorderColor = System.Drawing.Color.Silver
        Me.PRAR_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PRAR_YMD.DefVal = ""
        Me.PRAR_YMD.IconVisible = True
        Me.PRAR_YMD.IsDataStateAware = True
        Me.PRAR_YMD.Location = New System.Drawing.Point(85, 191)
        Me.PRAR_YMD.Name = "PRAR_YMD"
        Me.PRAR_YMD.NextFocus = "REQ_YMD"
        Me.PRAR_YMD.RequiredFor = ""
        Me.PRAR_YMD.Size = New System.Drawing.Size(91, 23)
        Me.PRAR_YMD.TabIndex = 252
        Me.Localizer1.SetWordID(Me.PRAR_YMD, "")
        '
        'Label11
        '
        Me.Label11.LabelFor = Nothing
        Me.Label11.Location = New System.Drawing.Point(5, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 21)
        Me.Label11.TabIndex = 251
        Me.Label11.Text = "예정일자"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label11, "예정일자")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.S_SEARCH_KEY, "")
        Me.Localizer1.SetWordID(Me.Label1, "Search Key")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.SCREEN, "사이트 지원 등록")
        Me.Localizer1.SetWordID(Me.INCLUDE_EXCEPT, "제외건 포함")
        Me.Localizer1.SetWordID(Me.btnRefresh, "&Refresh")
        Me.Localizer1.SetWordID(Me.REF_TIME, "5분")
        Me.Localizer1.SetWordID(Me.lblTime, "Refresh")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.Label32, "~")
        Me.Localizer1.SetWordID(Me.S_TO_YMD, "")
        Me.Localizer1.SetWordID(Me.S_FM_YMD, "")
        Me.Localizer1.SetWordID(Me.Label2, "등록일자")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV1_PRIORITY, "우선순위")
        Me.Localizer1.SetWordID(Me.GV1_REQ_YMD, "요청일자")
        Me.Localizer1.SetWordID(Me.GV1_REQ_HM, "요청시간")
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "코드")
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "거래처 명")
        Me.Localizer1.SetWordID(Me.GV1_CONTENT, "고객 요청내용")
        Me.Localizer1.SetWordID(Me.GV1_REQ_USR, "요청자")
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "연락처")
        Me.Localizer1.SetWordID(Me.GV1_PROC_TYPE, "진행현황")
        Me.Localizer1.SetWordID(Me.GV1_WORK_USR, "담당자")
        Me.Localizer1.SetWordID(Me.GV1_PRAR_YMD, "예정일자")
        Me.Localizer1.SetWordID(Me.GV1_CMPT_YMD, "완료일자")
        Me.Localizer1.SetWordID(Me.GV1_INS_USR_NM, "등록자")
        Me.Localizer1.SetWordID(Me.GV1_FILE_YN, "Document")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "개발팀 처리내용")
        Me.Localizer1.SetWordID(Me.GV1_DELAY, "Delay")
        Me.Localizer1.SetWordID(Me.GV1_DELAY_YN, "Delay(Y/N)")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "업무구분")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC2, "업무구분2")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC3, "업무구분3")
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "등록일자")
        Me.Localizer1.SetWordID(Me.GV1_DEV_CMPT_YMD, "개발팀 처리완료")
        Me.Localizer1.SetWordID(Me.GV1_DEV_ERR_YN, "결함")
        Me.Localizer1.SetWordID(Me.GV1_SHARE_YN, "공유")
        Me.Localizer1.SetWordID(Me.GV1_DEV_ERR_NM, "Err Nm")
        Me.Localizer1.SetWordID(Me.GV1_RANK, "난이도")
        Me.Localizer1.SetWordID(Me.GridColumn1, "순번")
        Me.Localizer1.SetWordID(Me.GridColumn2, "사이트명")
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처유형")
        Me.Localizer1.SetWordID(Me.GridColumn4, "담당자")
        Me.Localizer1.SetWordID(Me.GridColumn5, "전화")
        Me.Localizer1.SetWordID(Me.GridColumn6, "DB IP")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.S_WORK_AREA, " ")
        Me.Localizer1.SetWordID(Me.Label5, "근무지")
        Me.Localizer1.SetWordID(Me.S_WORK_USR, "--Select--")
        Me.Localizer1.SetWordID(Me.Label6, "담당자")
        Me.Localizer1.SetWordID(Me.S_PROC_TYPE, "")
        Me.Localizer1.SetWordID(Me.Label3, "처리내용")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.MainSplit, "SplitContainerControl2")
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.WG3, "")
        Me.Localizer1.SetWordID(Me.GV3_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV3_PRIORITY, "우선순위")
        Me.Localizer1.SetWordID(Me.GV3_CUST_CD, "코드")
        Me.Localizer1.SetWordID(Me.GV3_CUST_NM, "거래처 명")
        Me.Localizer1.SetWordID(Me.GV3_REQ_YMD, "요청일자")
        Me.Localizer1.SetWordID(Me.GV3_REQ_HM, "시간")
        Me.Localizer1.SetWordID(Me.GV3_REQ_USR, "요청자")
        Me.Localizer1.SetWordID(Me.GV3_TEL_NO, "연락처")
        Me.Localizer1.SetWordID(Me.GV3_CONTENT, "고객요청사항")
        Me.Localizer1.SetWordID(Me.GV3_PROC_TYPE, "상태")
        Me.Localizer1.SetWordID(Me.GV3_INS_USR_NM, "등록자")
        Me.Localizer1.SetWordID(Me.GV3_REQ_SVC, "업무구분")
        Me.Localizer1.SetWordID(Me.GV3_SYS_NM, "접수")
        Me.Localizer1.SetWordID(Me.GV3_INS_YMD, "입력일자")
        Me.Localizer1.SetWordID(Me.GV3_SVC_NM, "시스템")
        Me.Localizer1.SetWordID(Me.GV3_EXCEPT_YN, "제외")
        Me.Localizer1.SetWordID(Me.GV3_DEV_PIC, "담당개발자")
        Me.Localizer1.SetWordID(Me.ModifySplit, "ModifySplit")
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        Me.Localizer1.SetWordID(Me.FileInputSplit, "FileInputSplit")
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        Me.Localizer1.SetWordID(Me.GroupControl2, "요청 사항")
        Me.Localizer1.SetWordID(Me.OhterDeptListPanel, "")
        Me.Localizer1.SetWordID(Me.PanelControl8, "")
        Me.Localizer1.SetWordID(Me.SAVE_CNT, "")
        Me.Localizer1.SetWordID(Me.INS_USR_NM, "")
        Me.Localizer1.SetWordID(Me.CmdAssign, "배정")
        Me.Localizer1.SetWordID(Me.MNGT_NO, "")
        Me.Localizer1.SetWordID(Me.Label8, "요청일자")
        Me.Localizer1.SetWordID(Me.Button1, "...")
        Me.Localizer1.SetWordID(Me.Label26, "관리번호")
        Me.Localizer1.SetWordID(Me.Label10, "거래처")
        Me.Localizer1.SetWordID(Me.Label23, "등록자")
        Me.Localizer1.SetWordID(Me.Label9, "요청자")
        Me.Localizer1.SetWordID(Me.Label20, "우선순위")
        Me.Localizer1.SetWordID(Me.CONTENT, "")
        Me.Localizer1.SetWordID(Me.Button2, "")
        Me.Localizer1.SetWordID(Me.GroupControl3, "솔루션 개발팀")
        Me.Localizer1.SetWordID(Me.DevDeptListPanel, "")
        Me.Localizer1.SetWordID(Me.Label33, "시작일자")
        Me.Localizer1.SetWordID(Me.REQ_HM, "")
        Me.Localizer1.SetWordID(Me.REQ_YMD, "")
        Me.Localizer1.SetWordID(Me.CMPT_HM, "")
        Me.Localizer1.SetWordID(Me.Label31, "내부 공유")
        Me.Localizer1.SetWordID(Me.SHARE_YN, "")
        Me.Localizer1.SetWordID(Me.DEV_ERR_NM, "")
        Me.Localizer1.SetWordID(Me.Label30, "결함")
        Me.Localizer1.SetWordID(Me.DEV_ERR_YN, "")
        Me.Localizer1.SetWordID(Me.RANK, " ")
        Me.Localizer1.SetWordID(Me.Label17, "난이도")
        Me.Localizer1.SetWordID(Me.WORK_USR, "--Select--")
        Me.Localizer1.SetWordID(Me.Label12, "3)")
        Me.Localizer1.SetWordID(Me.Label7, "2)")
        Me.Localizer1.SetWordID(Me.xtcETC, "")
        Me.Localizer1.SetWordID(Me.XtraTabPage2, "개발팀 처리결과")
        Me.Localizer1.SetWordID(Me.Label13, "비고")
        Me.Localizer1.SetWordID(Me.DEV_RMK, "")
        Me.Localizer1.SetWordID(Me.RMK, "")
        Me.Localizer1.SetWordID(Me.XtraTabPage3, "고객게시판 답변")
        Me.Localizer1.SetWordID(Me.CMPT_RMK, "")
        Me.Localizer1.SetWordID(Me.PanelControl9, "")
        Me.Localizer1.SetWordID(Me.Button3, "고객 답변 등록")
        Me.Localizer1.SetWordID(Me.TextBox4, "")
        Me.Localizer1.SetWordID(Me.XtraTabPage1, "첨부파일")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.gridBand20, "Type")
        Me.Localizer1.SetWordID(Me.gridBand21, "Document No")
        Me.Localizer1.SetWordID(Me.gridBand22, "File")
        Me.Localizer1.SetWordID(Me.GV2_FILE_ICON, "File Icon")
        Me.Localizer1.SetWordID(Me.GV2_FILE_NM, "File")
        Me.Localizer1.SetWordID(Me.GV2_UPLOAD, "")
        Me.Localizer1.SetWordID(Me.GV2_SUCCESS, "Success")
        Me.Localizer1.SetWordID(Me.gridBand32, "Full path")
        Me.Localizer1.SetWordID(Me.GV2_FILE_PATH, "Full path")
        Me.Localizer1.SetWordID(Me.gridBand3, "Size")
        Me.Localizer1.SetWordID(Me.GV2_FILE_SIZE, "Size")
        Me.Localizer1.SetWordID(Me.gridBand1, "Remark")
        Me.Localizer1.SetWordID(Me.GV2_RMK, "Remark")
        Me.Localizer1.SetWordID(Me.gridBand2, "Screen")
        Me.Localizer1.SetWordID(Me.GV2_MNGT_NO, "MNGT NO")
        Me.Localizer1.SetWordID(Me.GV2_SEQ, "SEQ")
        Me.Localizer1.SetWordID(Me.GV2_INS_YMD, "Inserted Date")
        Me.Localizer1.SetWordID(Me.REQ_SVC3, "--Select--")
        Me.Localizer1.SetWordID(Me.REQ_SVC2, "--Select--")
        Me.Localizer1.SetWordID(Me.REQ_SVC, "--Select--")
        Me.Localizer1.SetWordID(Me.Label29, "업무구분 1)")
        Me.Localizer1.SetWordID(Me.PROC_TYPE, "")
        Me.Localizer1.SetWordID(Me.CMPT_YMD, "")
        Me.Localizer1.SetWordID(Me.Label21, "진행현황")
        Me.Localizer1.SetWordID(Me.Label28, "완료일자")
        Me.Localizer1.SetWordID(Me.Label19, "담당자")
        Me.Localizer1.SetWordID(Me.PRAR_YMD, "")
        Me.Localizer1.SetWordID(Me.Label11, "예정일자")
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'CrmAsMgtDev4
        '
        Me.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1435, 796)
        Me.Controls.Add(Me.palAutoButton)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "CrmAsMgtDev4"
        Me.Text = "개발팀 작업현황 (테스트중)"
        Me.Localizer1.SetWordID(Me, "개발팀 작업현황 (테스트중)")
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.palAutoButton.PerformLayout()
        CType(Me.INCLUDE_EXCEPT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.S_PROC_TYPE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplit.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifySplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ModifySplit.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.FileInputSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FileInputSplit.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.OhterDeptListPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OhterDeptListPanel.ResumeLayout(False)
        Me.OhterDeptListPanel.PerformLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        Me.PanelControl8.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.DevDeptListPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DevDeptListPanel.ResumeLayout(False)
        Me.DevDeptListPanel.PerformLayout()
        CType(Me.SHARE_YN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEV_ERR_YN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcETC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcETC.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_REQ_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_SEARCH_KEY As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV1_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WORK_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_REQ_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_HM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CONTENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PRAR_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CMPT_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label32 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_TO_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents S_FM_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_PROC_TYPE As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents GV1_INS_USR_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents REF_TIME As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents lblTime As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV1_PRIORITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents RepositoryItemDateBoxEdit1 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemDateBoxEdit2 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Public WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1_FILE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents MainSplit As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PRAR_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label11 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents DevDeptListPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label19 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents xtcETC As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents gridBand20 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand21 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand22 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV2_FILE_ICON As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_FILE_NM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_UPLOAD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_SUCCESS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand32 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV2_FILE_PATH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV2_FILE_SIZE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV2_RMK As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV2_MNGT_NO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_SEQ As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_INS_YMD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents RMK As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents CMPT_RMK As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents TextBox4 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CMPT_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label28 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PROC_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label21 As YJIT.SC.UI.SCControls.Label
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents REQ_SVC As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label29 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV1_DEV_CMPT_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SCREEN As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents REQ_SVC2 As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents REQ_SVC3 As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GV1_DELAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DELAY_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_SVC3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ModifySplit As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents FileInputSplit As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents OhterDeptListPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label26 As YJIT.SC.UI.SCControls.Label
    Public WithEvents AS_REQ_YMD As YJIT.SC.UI.SCControls.TextLabel
    Public WithEvents TEL_NO As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label8 As YJIT.SC.UI.SCControls.Label
    Public WithEvents CONTENT As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents CUST_NM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label20 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label9 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label23 As YJIT.SC.UI.SCControls.Label
    Public WithEvents CUST_CD As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label10 As YJIT.SC.UI.SCControls.Label
    Public WithEvents PRIORITY As YJIT.SC.UI.SCControls.TextLabel
    Public WithEvents REQ_USR As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Public WithEvents WG3 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV3_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_REQ_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_REQ_HM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_CONTENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_REQ_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_PROC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_PRIORITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_INS_USR_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_REQ_SVC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_SVC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_SYS_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnRefresh As YJIT.SC.UI.SCControls.Button
    Public WithEvents S_WORK_USR As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents MNGT_NO As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label12 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label7 As YJIT.SC.UI.SCControls.Label
    Public WithEvents WORK_USR As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents CmdAssign As YJIT.SC.UI.SCControls.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Button3 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents INS_USR_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents INCLUDE_EXCEPT As YJIT.SC.UI.SCControls.CheckBox
    Friend WithEvents GV3_EXCEPT_YN As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents RANK_NM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents SAVE_CNT As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label13 As YJIT.SC.UI.SCControls.Label
    Public WithEvents DEV_RMK As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents RANK As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label17 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label31 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents SHARE_YN As YJIT.SC.UI.SCControls.CheckBox
    Friend WithEvents DEV_ERR_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label30 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents DEV_ERR_YN As YJIT.SC.UI.SCControls.CheckBox
    Public WithEvents S_WORK_AREA As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label5 As YJIT.SC.UI.SCControls.Label
    Public WithEvents CMPT_HM As YJIT.SC.UI.SCControls.MaskedTextBox
    Friend WithEvents Label33 As YJIT.SC.UI.SCControls.Label
    Public WithEvents REQ_HM As YJIT.SC.UI.SCControls.MaskedTextBox
    Friend WithEvents REQ_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents GV1_DEV_ERR_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SHARE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DEV_ERR_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_DEV_PIC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RANK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_SVC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_SVC2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
