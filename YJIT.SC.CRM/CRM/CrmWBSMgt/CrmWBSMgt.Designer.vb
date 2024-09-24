<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmWBSMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmWBSMgt))
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btnClear = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.Label32 = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_REQ_SVC = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_RMK = New YJIT.SC.UI.SCControls.Label()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.S_DEPT_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_DEPT_CD = New YJIT.SC.UI.SCControls.ComboBox()
        Me.lbl_I_MNGT_NO = New YJIT.SC.UI.SCControls.Label()
        Me.S_COM_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_SEARCH_KEY = New YJIT.SC.UI.SCControls.TextBox()
        Me.S_SEARCH_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_DATE_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_DATE_TO = New YJIT.SC.UI.SCControls.DateBox()
        Me.S_DATE_FM = New YJIT.SC.UI.SCControls.DateBox()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.MNGT_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_MNGT_NO = New YJIT.SC.UI.SCControls.Label()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROJECT_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FM_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit2 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.GV1_TO_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROC_RATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnQuickFwg1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnExpFwg1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnDelFwg1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnAddFwg1 = New YJIT.SC.UI.SCControls.Button()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV2_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CHK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV2_SORT_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_GRP_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_ACT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCodeBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit()
        Me.GV2_ACT_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_JOB_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_LOC_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DEPT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DEPT_PIC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CUST_PIC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_PLAN_FM_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.GV2_PLAN_TO_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_PROC_FM_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_PROC_TO_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_WORK_RATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_TEST_FM_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_TEST_TO_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_PROC_RATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GV2_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GV2_rpPROC_RATE = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV2_JOB_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCodeBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2_rpPROC_RATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnClear.Location = New System.Drawing.Point(1009, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 25)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.Localizer1.SetWordID(Me.btnClear, "Clear")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(934, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnClear)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1160, 32)
        Me.palAutoButton.TabIndex = 2
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(1083, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'Label32
        '
        Me.Label32.LabelFor = Nothing
        Me.Label32.Location = New System.Drawing.Point(247, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 22)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "~"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Localizer1.SetWordID(Me.Label32, "~")
        '
        'lbl_REQ_SVC
        '
        Me.lbl_REQ_SVC.LabelFor = Nothing
        Me.lbl_REQ_SVC.Location = New System.Drawing.Point(5, 39)
        Me.lbl_REQ_SVC.Name = "lbl_REQ_SVC"
        Me.lbl_REQ_SVC.Size = New System.Drawing.Size(64, 14)
        Me.lbl_REQ_SVC.TabIndex = 239
        Me.lbl_REQ_SVC.Text = "제목"
        Me.lbl_REQ_SVC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_REQ_SVC, "제목")
        '
        'lbl_RMK
        '
        Me.lbl_RMK.LabelFor = Nothing
        Me.lbl_RMK.Location = New System.Drawing.Point(3, 290)
        Me.lbl_RMK.Name = "lbl_RMK"
        Me.lbl_RMK.Size = New System.Drawing.Size(65, 14)
        Me.lbl_RMK.TabIndex = 280
        Me.lbl_RMK.Text = "유튜브 URL"
        Me.lbl_RMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_RMK, "유튜브 URL")
        '
        'Label1
        '
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(4, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 280
        Me.Label1.Text = "유튜브 코드"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "유튜브 코드")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.S_DEPT_TYPE)
        Me.PanelControl1.Controls.Add(Me.S_DEPT_CD)
        Me.PanelControl1.Controls.Add(Me.lbl_I_MNGT_NO)
        Me.PanelControl1.Controls.Add(Me.S_COM_YN)
        Me.PanelControl1.Controls.Add(Me.S_SEARCH_KEY)
        Me.PanelControl1.Controls.Add(Me.S_SEARCH_TYPE)
        Me.PanelControl1.Controls.Add(Me.S_DATE_TYPE)
        Me.PanelControl1.Controls.Add(Me.S_DATE_TO)
        Me.PanelControl1.Controls.Add(Me.S_DATE_FM)
        Me.PanelControl1.Controls.Add(Me.Label32)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 42)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1160, 66)
        Me.PanelControl1.TabIndex = 0
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'S_DEPT_TYPE
        '
        Me.S_DEPT_TYPE.CodeType = ""
        Me.S_DEPT_TYPE.ColumnWidths = ""
        Me.S_DEPT_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_DEPT_TYPE.DataParams = ""
        Me.S_DEPT_TYPE.DefVal = ""
        Me.S_DEPT_TYPE.DisplayMember = "NAME"
        Me.S_DEPT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DEPT_TYPE.FormattingEnabled = True
        Me.S_DEPT_TYPE.IsDataStateAware = True
        Me.S_DEPT_TYPE.ItemDelimiter = ","
        Me.S_DEPT_TYPE.ItemTextList = "등록부서"
        Me.S_DEPT_TYPE.ItemValueList = "I"
        Me.S_DEPT_TYPE.KeepIntegrity = True
        Me.S_DEPT_TYPE.Location = New System.Drawing.Point(21, 34)
        Me.S_DEPT_TYPE.Name = "S_DEPT_TYPE"
        Me.S_DEPT_TYPE.NextFocus = "S_DEPT_CD"
        Me.S_DEPT_TYPE.NullText = ""
        Me.S_DEPT_TYPE.SearchKeys = ""
        Me.S_DEPT_TYPE.Size = New System.Drawing.Size(119, 22)
        Me.S_DEPT_TYPE.TabIndex = 10023
        Me.S_DEPT_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DEPT_TYPE.ValueMember = "CODE"
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
        Me.S_DEPT_CD.Location = New System.Drawing.Point(144, 34)
        Me.S_DEPT_CD.Name = "S_DEPT_CD"
        Me.S_DEPT_CD.NextFocus = "btnSearch"
        Me.S_DEPT_CD.NullText = "--Select--"
        Me.S_DEPT_CD.SearchKeys = ""
        Me.S_DEPT_CD.Size = New System.Drawing.Size(129, 23)
        Me.S_DEPT_CD.TabIndex = 10022
        Me.S_DEPT_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DEPT_CD.ValueMember = "CODE"
        '
        'lbl_I_MNGT_NO
        '
        Me.lbl_I_MNGT_NO.LabelFor = Nothing
        Me.lbl_I_MNGT_NO.Location = New System.Drawing.Point(753, 11)
        Me.lbl_I_MNGT_NO.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_I_MNGT_NO.Name = "lbl_I_MNGT_NO"
        Me.lbl_I_MNGT_NO.Size = New System.Drawing.Size(91, 18)
        Me.lbl_I_MNGT_NO.TabIndex = 19
        Me.lbl_I_MNGT_NO.Text = "프로젝트 상태"
        Me.lbl_I_MNGT_NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_I_MNGT_NO, "관리번호")
        '
        'S_COM_YN
        '
        Me.S_COM_YN.BackColor = System.Drawing.SystemColors.Window
        Me.S_COM_YN.CodeType = ""
        Me.S_COM_YN.ColumnWidths = ""
        Me.S_COM_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_COM_YN.DataParams = ""
        Me.S_COM_YN.DefVal = "N"
        Me.S_COM_YN.DisplayMember = "NAME"
        Me.S_COM_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_COM_YN.FormattingEnabled = True
        Me.S_COM_YN.IsDataStateAware = True
        Me.S_COM_YN.ItemDelimiter = ","
        Me.S_COM_YN.ItemTextList = "진행중,완료"
        Me.S_COM_YN.ItemValueList = "N,Y"
        Me.S_COM_YN.KeepIntegrity = False
        Me.S_COM_YN.Location = New System.Drawing.Point(850, 9)
        Me.S_COM_YN.Name = "S_COM_YN"
        Me.S_COM_YN.NextFocus = "S_DEPT_TYPE"
        Me.S_COM_YN.NullText = ""
        Me.S_COM_YN.SearchKeys = ""
        Me.S_COM_YN.Size = New System.Drawing.Size(119, 22)
        Me.S_COM_YN.TabIndex = 5
        Me.S_COM_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_COM_YN.ValueMember = "CODE"
        '
        'S_SEARCH_KEY
        '
        Me.S_SEARCH_KEY.BorderColor = System.Drawing.Color.Silver
        Me.S_SEARCH_KEY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_SEARCH_KEY.DefVal = ""
        Me.S_SEARCH_KEY.IsDataStateAware = True
        Me.S_SEARCH_KEY.Location = New System.Drawing.Point(511, 9)
        Me.S_SEARCH_KEY.MaxLength = 20
        Me.S_SEARCH_KEY.Name = "S_SEARCH_KEY"
        Me.S_SEARCH_KEY.NextFocus = "S_COM_YN"
        Me.S_SEARCH_KEY.Size = New System.Drawing.Size(222, 22)
        Me.S_SEARCH_KEY.TabIndex = 4
        Me.S_SEARCH_KEY.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'S_SEARCH_TYPE
        '
        Me.S_SEARCH_TYPE.BackColor = System.Drawing.SystemColors.Window
        Me.S_SEARCH_TYPE.CodeType = ""
        Me.S_SEARCH_TYPE.ColumnWidths = ""
        Me.S_SEARCH_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_SEARCH_TYPE.DataParams = ""
        Me.S_SEARCH_TYPE.DefVal = "A"
        Me.S_SEARCH_TYPE.DisplayMember = "NAME"
        Me.S_SEARCH_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_SEARCH_TYPE.FormattingEnabled = True
        Me.S_SEARCH_TYPE.IsDataStateAware = True
        Me.S_SEARCH_TYPE.ItemDelimiter = ","
        Me.S_SEARCH_TYPE.ItemTextList = "자동검색,프로젝트명,등록자"
        Me.S_SEARCH_TYPE.ItemValueList = "A,T,U"
        Me.S_SEARCH_TYPE.KeepIntegrity = False
        Me.S_SEARCH_TYPE.Location = New System.Drawing.Point(388, 9)
        Me.S_SEARCH_TYPE.Name = "S_SEARCH_TYPE"
        Me.S_SEARCH_TYPE.NextFocus = "S_SEARCH_KEY"
        Me.S_SEARCH_TYPE.NullText = ""
        Me.S_SEARCH_TYPE.SearchKeys = ""
        Me.S_SEARCH_TYPE.Size = New System.Drawing.Size(119, 22)
        Me.S_SEARCH_TYPE.TabIndex = 3
        Me.S_SEARCH_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_SEARCH_TYPE.ValueMember = "CODE"
        '
        'S_DATE_TYPE
        '
        Me.S_DATE_TYPE.BackColor = System.Drawing.SystemColors.Window
        Me.S_DATE_TYPE.CodeType = ""
        Me.S_DATE_TYPE.ColumnWidths = ""
        Me.S_DATE_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_DATE_TYPE.DataParams = ""
        Me.S_DATE_TYPE.DefVal = "FT"
        Me.S_DATE_TYPE.DisplayMember = "NAME"
        Me.S_DATE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DATE_TYPE.FormattingEnabled = True
        Me.S_DATE_TYPE.IsDataStateAware = True
        Me.S_DATE_TYPE.ItemDelimiter = ","
        Me.S_DATE_TYPE.ItemTextList = "등록일자,프로젝트기간,프로젝트시작일자,프로젝트종료일자"
        Me.S_DATE_TYPE.ItemValueList = "REG,FT,FM,TO"
        Me.S_DATE_TYPE.KeepIntegrity = False
        Me.S_DATE_TYPE.Location = New System.Drawing.Point(21, 9)
        Me.S_DATE_TYPE.Name = "S_DATE_TYPE"
        Me.S_DATE_TYPE.NextFocus = "S_DATE_FM"
        Me.S_DATE_TYPE.NullText = ""
        Me.S_DATE_TYPE.SearchKeys = ""
        Me.S_DATE_TYPE.Size = New System.Drawing.Size(119, 22)
        Me.S_DATE_TYPE.TabIndex = 0
        Me.S_DATE_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DATE_TYPE.ValueMember = "CODE"
        '
        'S_DATE_TO
        '
        Me.S_DATE_TO.BorderColor = System.Drawing.Color.Silver
        Me.S_DATE_TO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_DATE_TO.DefVal = ""
        Me.S_DATE_TO.IconVisible = True
        Me.S_DATE_TO.IsDataStateAware = True
        Me.S_DATE_TO.Location = New System.Drawing.Point(271, 9)
        Me.S_DATE_TO.Name = "S_DATE_TO"
        Me.S_DATE_TO.NextFocus = "S_SEARCH_TYPE"
        Me.S_DATE_TO.Size = New System.Drawing.Size(95, 22)
        Me.S_DATE_TO.TabIndex = 2
        Me.Localizer1.SetWordID(Me.S_DATE_TO, "")
        '
        'S_DATE_FM
        '
        Me.S_DATE_FM.BackColor = System.Drawing.SystemColors.Window
        Me.S_DATE_FM.BorderColor = System.Drawing.Color.Silver
        Me.S_DATE_FM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_DATE_FM.DefVal = ""
        Me.S_DATE_FM.IconVisible = True
        Me.S_DATE_FM.IsDataStateAware = True
        Me.S_DATE_FM.Location = New System.Drawing.Point(144, 9)
        Me.S_DATE_FM.Name = "S_DATE_FM"
        Me.S_DATE_FM.NextFocus = "S_DATE_TO"
        Me.S_DATE_FM.Size = New System.Drawing.Size(95, 22)
        Me.S_DATE_FM.TabIndex = 1
        Me.Localizer1.SetWordID(Me.S_DATE_FM, "")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnClear, "Clear")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.Label32, "~")
        Me.Localizer1.SetWordID(Me.lbl_REQ_SVC, "제목")
        Me.Localizer1.SetWordID(Me.lbl_RMK, "유튜브 URL")
        Me.Localizer1.SetWordID(Me.Label1, "유튜브 코드")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.S_DEPT_TYPE, "작업자부서")
        Me.Localizer1.SetWordID(Me.S_DEPT_CD, "--Select--")
        Me.Localizer1.SetWordID(Me.lbl_I_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.S_COM_YN, "진행중")
        Me.Localizer1.SetWordID(Me.S_SEARCH_KEY, "")
        Me.Localizer1.SetWordID(Me.S_SEARCH_TYPE, "자동검색")
        Me.Localizer1.SetWordID(Me.S_DATE_TYPE, "등록일자")
        Me.Localizer1.SetWordID(Me.S_DATE_TO, "")
        Me.Localizer1.SetWordID(Me.S_DATE_FM, "")
        Me.Localizer1.SetWordID(Me.MNGT_NO, "")
        Me.Localizer1.SetWordID(Me.lbl_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV1_PROJECT_NM, "프로젝트명")
        Me.Localizer1.SetWordID(Me.GV1_USR_ID, "담당자")
        Me.Localizer1.SetWordID(Me.GV1_FM_YMD, "프로젝트 시작일자")
        Me.Localizer1.SetWordID(Me.GV1_TO_YMD, "프로젝트 종료일자")
        Me.Localizer1.SetWordID(Me.GV1_PROC_RATE, "진척율")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "입력자")
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "입력일자")
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "수정자")
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "수정일자")
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel3, "")
        Me.Localizer1.SetWordID(Me.btnQuickFwg1, "Button1")
        Me.Localizer1.SetWordID(Me.btnExpFwg1, "Button1")
        Me.Localizer1.SetWordID(Me.btnDelFwg1, "Button1")
        Me.Localizer1.SetWordID(Me.btnAddFwg1, "Button1")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GV2_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV2_SEQ, "순서")
        Me.Localizer1.SetWordID(Me.GV2_CHK, "V")
        Me.Localizer1.SetWordID(Me.GV2_SORT_SEQ, "순서")
        Me.Localizer1.SetWordID(Me.GV2_GRP_CD, "구분")
        Me.Localizer1.SetWordID(Me.GV2_ACT_CD, "활동")
        Me.Localizer1.SetWordID(Me.GV2_ACT_NM, "활동명")
        Me.Localizer1.SetWordID(Me.GV2_JOB_NM, "작업명")
        Me.Localizer1.SetWordID(Me.GV2_LOC_CD, "장소")
        Me.Localizer1.SetWordID(Me.GV2_DEPT_CD, "담당부서")
        Me.Localizer1.SetWordID(Me.GV2_DEPT_PIC_NM, "담당자")
        Me.Localizer1.SetWordID(Me.GV2_CUST_PIC_NM, "업체담당자")
        Me.Localizer1.SetWordID(Me.GV2_PLAN_FM_YMD, "계획시작일")
        Me.Localizer1.SetWordID(Me.GV2_PLAN_TO_YMD, "계획종료일")
        Me.Localizer1.SetWordID(Me.GV2_PROC_FM_YMD, "실제시작일")
        Me.Localizer1.SetWordID(Me.GV2_PROC_TO_YMD, "실제종료일")
        Me.Localizer1.SetWordID(Me.GV2_WORK_RATE, "작업기간")
        Me.Localizer1.SetWordID(Me.GV2_TEST_FM_YMD, "테스트시작일")
        Me.Localizer1.SetWordID(Me.GV2_TEST_TO_YMD, "테스트종료일")
        Me.Localizer1.SetWordID(Me.GV2_PROC_RATE, "진척률")
        Me.Localizer1.SetWordID(Me.GV2_RMK, "비고")
        Me.Localizer1.SetWordID(Me.GV2_INS_USR, "입력자")
        Me.Localizer1.SetWordID(Me.GV2_INS_YMD, "입력일자")
        Me.Localizer1.SetWordID(Me.GV2_UPD_USR, "수정자")
        Me.Localizer1.SetWordID(Me.GV2_UPD_YMD, "수정일자")
        Me.Localizer1.SetWordID(Me.GV2_JOB_TYPE, "작업 그룹명")
        '
        'MNGT_NO
        '
        Me.MNGT_NO.BorderColor = System.Drawing.Color.Silver
        Me.MNGT_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MNGT_NO.DefVal = ""
        Me.MNGT_NO.IsDataStateAware = True
        Me.MNGT_NO.Location = New System.Drawing.Point(76, 8)
        Me.MNGT_NO.Name = "MNGT_NO"
        Me.MNGT_NO.NextFocus = "BOARD_TYPE"
        Me.MNGT_NO.ReadOnly = True
        Me.MNGT_NO.Size = New System.Drawing.Size(133, 21)
        Me.MNGT_NO.TabIndex = 15
        Me.MNGT_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'lbl_MNGT_NO
        '
        Me.lbl_MNGT_NO.LabelFor = Nothing
        Me.lbl_MNGT_NO.Location = New System.Drawing.Point(6, 12)
        Me.lbl_MNGT_NO.Name = "lbl_MNGT_NO"
        Me.lbl_MNGT_NO.Size = New System.Drawing.Size(64, 14)
        Me.lbl_MNGT_NO.TabIndex = 16
        Me.lbl_MNGT_NO.Text = "관리번호"
        Me.lbl_MNGT_NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_MNGT_NO, "관리번호")
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
        Me.WG1.Location = New System.Drawing.Point(0, 0)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit2})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(266, 515)
        Me.WG1.TabIndex = 0
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GridView1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_MNGT_NO, Me.GV1_PROJECT_NM, Me.GV1_USR_ID, Me.GV1_FM_YMD, Me.GV1_TO_YMD, Me.GV1_PROC_RATE, Me.GV1_RMK, Me.GV1_INS_USR, Me.GV1_INS_YMD, Me.GV1_UPD_USR, Me.GV1_UPD_YMD})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsBehavior.ReadOnly = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.ViewCaption = "Master List"
        '
        'GV1_MNGT_NO
        '
        Me.GV1_MNGT_NO.Caption = "관리번호"
        Me.GV1_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV1_MNGT_NO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_MNGT_NO.Name = "GV1_MNGT_NO"
        Me.GV1_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        '
        'GV1_PROJECT_NM
        '
        Me.GV1_PROJECT_NM.Caption = "프로젝트명"
        Me.GV1_PROJECT_NM.FieldName = "PROJECT_NM"
        Me.GV1_PROJECT_NM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_PROJECT_NM.Name = "GV1_PROJECT_NM"
        Me.GV1_PROJECT_NM.OptionsColumn.AllowEdit = False
        Me.GV1_PROJECT_NM.OptionsColumn.ReadOnly = True
        Me.GV1_PROJECT_NM.Visible = True
        Me.GV1_PROJECT_NM.VisibleIndex = 0
        Me.GV1_PROJECT_NM.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_PROJECT_NM, "프로젝트명")
        '
        'GV1_USR_ID
        '
        Me.GV1_USR_ID.Caption = "담당자"
        Me.GV1_USR_ID.FieldName = "USR_ID"
        Me.GV1_USR_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_USR_ID.Name = "GV1_USR_ID"
        Me.GV1_USR_ID.OptionsColumn.AllowEdit = False
        Me.GV1_USR_ID.OptionsColumn.ReadOnly = True
        Me.GV1_USR_ID.Visible = True
        Me.GV1_USR_ID.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GV1_USR_ID, "담당자")
        '
        'GV1_FM_YMD
        '
        Me.GV1_FM_YMD.Caption = "프로젝트 시작일"
        Me.GV1_FM_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit2
        Me.GV1_FM_YMD.FieldName = "FM_YMD"
        Me.GV1_FM_YMD.Name = "GV1_FM_YMD"
        Me.GV1_FM_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_FM_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_FM_YMD.Visible = True
        Me.GV1_FM_YMD.VisibleIndex = 2
        Me.GV1_FM_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_FM_YMD, "프로젝트 시작일자")
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
        'GV1_TO_YMD
        '
        Me.GV1_TO_YMD.Caption = "프로젝트 종료일"
        Me.GV1_TO_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit2
        Me.GV1_TO_YMD.FieldName = "TO_YMD"
        Me.GV1_TO_YMD.Name = "GV1_TO_YMD"
        Me.GV1_TO_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_TO_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_TO_YMD.Visible = True
        Me.GV1_TO_YMD.VisibleIndex = 3
        Me.GV1_TO_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_TO_YMD, "프로젝트 종료일자")
        '
        'GV1_PROC_RATE
        '
        Me.GV1_PROC_RATE.Caption = "진척율"
        Me.GV1_PROC_RATE.FieldName = "PROC_RATE"
        Me.GV1_PROC_RATE.Name = "GV1_PROC_RATE"
        Me.GV1_PROC_RATE.OptionsColumn.AllowEdit = False
        Me.GV1_PROC_RATE.OptionsColumn.ReadOnly = True
        Me.GV1_PROC_RATE.Visible = True
        Me.GV1_PROC_RATE.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GV1_PROC_RATE, "진척율")
        '
        'GV1_RMK
        '
        Me.GV1_RMK.Caption = "비고"
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.OptionsColumn.AllowEdit = False
        Me.GV1_RMK.OptionsColumn.ReadOnly = True
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 5
        Me.GV1_RMK.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        '
        'GV1_INS_USR
        '
        Me.GV1_INS_USR.Caption = "입력자"
        Me.GV1_INS_USR.FieldName = "INS_USR"
        Me.GV1_INS_USR.Name = "GV1_INS_USR"
        Me.GV1_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV1_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV1_INS_USR.Visible = True
        Me.GV1_INS_USR.VisibleIndex = 6
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "입력자")
        '
        'GV1_INS_YMD
        '
        Me.GV1_INS_YMD.Caption = "입력일자"
        Me.GV1_INS_YMD.FieldName = "INS_YMD"
        Me.GV1_INS_YMD.Name = "GV1_INS_YMD"
        Me.GV1_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_INS_YMD.Visible = True
        Me.GV1_INS_YMD.VisibleIndex = 7
        Me.GV1_INS_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "입력일자")
        '
        'GV1_UPD_USR
        '
        Me.GV1_UPD_USR.Caption = "수정자"
        Me.GV1_UPD_USR.FieldName = "UPD_USR"
        Me.GV1_UPD_USR.Name = "GV1_UPD_USR"
        Me.GV1_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_USR.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_USR.Visible = True
        Me.GV1_UPD_USR.VisibleIndex = 8
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "수정자")
        '
        'GV1_UPD_YMD
        '
        Me.GV1_UPD_YMD.Caption = "수정일자"
        Me.GV1_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV1_UPD_YMD.Name = "GV1_UPD_YMD"
        Me.GV1_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_YMD.Visible = True
        Me.GV1_UPD_YMD.VisibleIndex = 9
        Me.GV1_UPD_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "수정일자")
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.WG1
        Me.GridView1.Name = "GridView1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Location = New System.Drawing.Point(6, 114)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.WG1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.WG2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1160, 515)
        Me.SplitContainerControl1.SplitterPosition = 266
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.TableLayoutPanel3)
        Me.PanelControl2.Location = New System.Drawing.Point(0, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(886, 29)
        Me.PanelControl2.TabIndex = 3
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnQuickFwg1, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnExpFwg1, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnDelFwg1, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAddFwg1, 3, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(709, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(172, 24)
        Me.TableLayoutPanel3.TabIndex = 220
        Me.Localizer1.SetWordID(Me.TableLayoutPanel3, "")
        '
        'btnQuickFwg1
        '
        Me.btnQuickFwg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnQuickFwg1.Image = CType(resources.GetObject("btnQuickFwg1.Image"), System.Drawing.Image)
        Me.btnQuickFwg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuickFwg1.Location = New System.Drawing.Point(145, 3)
        Me.btnQuickFwg1.Name = "btnQuickFwg1"
        Me.btnQuickFwg1.Size = New System.Drawing.Size(22, 18)
        Me.btnQuickFwg1.TabIndex = 216
        Me.btnQuickFwg1.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnQuickFwg1, "Button1")
        '
        'btnExpFwg1
        '
        Me.btnExpFwg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExpFwg1.Image = CType(resources.GetObject("btnExpFwg1.Image"), System.Drawing.Image)
        Me.btnExpFwg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExpFwg1.Location = New System.Drawing.Point(118, 3)
        Me.btnExpFwg1.Name = "btnExpFwg1"
        Me.btnExpFwg1.Size = New System.Drawing.Size(21, 18)
        Me.btnExpFwg1.TabIndex = 215
        Me.btnExpFwg1.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnExpFwg1, "Button1")
        '
        'btnDelFwg1
        '
        Me.btnDelFwg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDelFwg1.Image = CType(resources.GetObject("btnDelFwg1.Image"), System.Drawing.Image)
        Me.btnDelFwg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelFwg1.Location = New System.Drawing.Point(92, 3)
        Me.btnDelFwg1.Name = "btnDelFwg1"
        Me.btnDelFwg1.Size = New System.Drawing.Size(20, 18)
        Me.btnDelFwg1.TabIndex = 218
        Me.btnDelFwg1.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnDelFwg1, "Button1")
        '
        'btnAddFwg1
        '
        Me.btnAddFwg1.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddFwg1.Appearance.Options.UseForeColor = True
        Me.btnAddFwg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnAddFwg1.Image = CType(resources.GetObject("btnAddFwg1.Image"), System.Drawing.Image)
        Me.btnAddFwg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddFwg1.Location = New System.Drawing.Point(63, 3)
        Me.btnAddFwg1.Name = "btnAddFwg1"
        Me.btnAddFwg1.Size = New System.Drawing.Size(22, 18)
        Me.btnAddFwg1.TabIndex = 217
        Me.btnAddFwg1.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnAddFwg1, "Button1")
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG2.DeleteRowConfirmation = True
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(1, 36)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCodeBoxEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateBoxEdit1, Me.GV2_rpPROC_RATE, Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoExEdit1})
        Me.WG2.SaveLayout = True
        Me.WG2.Size = New System.Drawing.Size(885, 479)
        Me.WG2.TabIndex = 1
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2, Me.GridView3})
        '
        'GV2
        '
        Me.GV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV2_MNGT_NO, Me.GV2_SEQ, Me.GV2_CHK, Me.GV2_SORT_SEQ, Me.GV2_GRP_CD, Me.GV2_ACT_CD, Me.GV2_ACT_NM, Me.GV2_JOB_TYPE, Me.GV2_JOB_NM, Me.GV2_LOC_CD, Me.GV2_DEPT_CD, Me.GV2_DEPT_PIC_NM, Me.GV2_CUST_PIC_NM, Me.GV2_PLAN_FM_YMD, Me.GV2_PLAN_TO_YMD, Me.GV2_PROC_FM_YMD, Me.GV2_PROC_TO_YMD, Me.GV2_WORK_RATE, Me.GV2_TEST_FM_YMD, Me.GV2_TEST_TO_YMD, Me.GV2_PROC_RATE, Me.GV2_RMK, Me.GV2_INS_USR, Me.GV2_INS_YMD, Me.GV2_UPD_USR, Me.GV2_UPD_YMD})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.IndicatorWidth = 40
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GV2.OptionsBehavior.ImmediateUpdateRowPosition = False
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV2.ViewCaption = "Detail List"
        '
        'GV2_MNGT_NO
        '
        Me.GV2_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_MNGT_NO.Caption = "관리번호"
        Me.GV2_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV2_MNGT_NO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV2_MNGT_NO.Name = "GV2_MNGT_NO"
        Me.Localizer1.SetWordID(Me.GV2_MNGT_NO, "관리번호")
        '
        'GV2_SEQ
        '
        Me.GV2_SEQ.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_SEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_SEQ.Caption = "순서"
        Me.GV2_SEQ.FieldName = "SEQ"
        Me.GV2_SEQ.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV2_SEQ.Name = "GV2_SEQ"
        Me.GV2_SEQ.OptionsColumn.AllowEdit = False
        Me.GV2_SEQ.OptionsColumn.ReadOnly = True
        Me.GV2_SEQ.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_SEQ, "순서")
        '
        'GV2_CHK
        '
        Me.GV2_CHK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CHK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CHK.Caption = "V"
        Me.GV2_CHK.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV2_CHK.FieldName = "CHK"
        Me.GV2_CHK.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV2_CHK.Name = "GV2_CHK"
        Me.GV2_CHK.OptionsColumn.AllowMove = False
        Me.GV2_CHK.Visible = True
        Me.GV2_CHK.VisibleIndex = 0
        Me.GV2_CHK.Width = 20
        Me.Localizer1.SetWordID(Me.GV2_CHK, "V")
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'GV2_SORT_SEQ
        '
        Me.GV2_SORT_SEQ.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_SORT_SEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_SORT_SEQ.Caption = "순서"
        Me.GV2_SORT_SEQ.FieldName = "SORT_SEQ"
        Me.GV2_SORT_SEQ.Name = "GV2_SORT_SEQ"
        Me.Localizer1.SetWordID(Me.GV2_SORT_SEQ, "순서")
        '
        'GV2_GRP_CD
        '
        Me.GV2_GRP_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_GRP_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_GRP_CD.Caption = "구분"
        Me.GV2_GRP_CD.FieldName = "GRP_CD"
        Me.GV2_GRP_CD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV2_GRP_CD.Name = "GV2_GRP_CD"
        Me.GV2_GRP_CD.Visible = True
        Me.GV2_GRP_CD.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GV2_GRP_CD, "구분")
        '
        'GV2_ACT_CD
        '
        Me.GV2_ACT_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_ACT_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_ACT_CD.Caption = "활동"
        Me.GV2_ACT_CD.ColumnEdit = Me.RepositoryItemCodeBoxEdit1
        Me.GV2_ACT_CD.FieldName = "ACT_CD"
        Me.GV2_ACT_CD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV2_ACT_CD.Name = "GV2_ACT_CD"
        Me.GV2_ACT_CD.Visible = True
        Me.GV2_ACT_CD.VisibleIndex = 2
        Me.GV2_ACT_CD.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_ACT_CD, "활동")
        '
        'RepositoryItemCodeBoxEdit1
        '
        Me.RepositoryItemCodeBoxEdit1.AlwaysSetDisplayParams = False
        Me.RepositoryItemCodeBoxEdit1.AutoHeight = False
        Me.RepositoryItemCodeBoxEdit1.AutoSuggestion = True
        Me.RepositoryItemCodeBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemCodeBoxEdit1.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, True)})
        Me.RepositoryItemCodeBoxEdit1.CodeType = "YJIT.CodeService.CommonCode"
        Me.RepositoryItemCodeBoxEdit1.DataParams = "GroupCode:'W03',NameType:'A'"
        Me.RepositoryItemCodeBoxEdit1.DisplayParams = "Code:#ACT_CD,Name:#ACT_NM"
        Me.RepositoryItemCodeBoxEdit1.EditPopup = ""
        Me.RepositoryItemCodeBoxEdit1.KeepIntegrity = True
        Me.RepositoryItemCodeBoxEdit1.Name = "RepositoryItemCodeBoxEdit1"
        Me.RepositoryItemCodeBoxEdit1.NextFocus = "ACT_NM"
        Me.RepositoryItemCodeBoxEdit1.SearchPopup = "CodeMaster"
        Me.RepositoryItemCodeBoxEdit1.SuppressValidateCode = False
        Me.RepositoryItemCodeBoxEdit1.SuppressValidateFailedPopup = False
        Me.RepositoryItemCodeBoxEdit1.ValidatedCodes = CType(resources.GetObject("RepositoryItemCodeBoxEdit1.ValidatedCodes"), System.Collections.ArrayList)
        Me.RepositoryItemCodeBoxEdit1.ValidateKeys = "KEY:#ACT_CD"
        '
        'GV2_ACT_NM
        '
        Me.GV2_ACT_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_ACT_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_ACT_NM.Caption = "활동명"
        Me.GV2_ACT_NM.FieldName = "ACT_NM"
        Me.GV2_ACT_NM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV2_ACT_NM.Name = "GV2_ACT_NM"
        Me.Localizer1.SetWordID(Me.GV2_ACT_NM, "활동명")
        '
        'GV2_JOB_NM
        '
        Me.GV2_JOB_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_JOB_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_JOB_NM.Caption = "작업명"
        Me.GV2_JOB_NM.FieldName = "JOB_NM"
        Me.GV2_JOB_NM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV2_JOB_NM.Name = "GV2_JOB_NM"
        Me.GV2_JOB_NM.Visible = True
        Me.GV2_JOB_NM.VisibleIndex = 4
        Me.GV2_JOB_NM.Width = 250
        Me.Localizer1.SetWordID(Me.GV2_JOB_NM, "작업명")
        '
        'GV2_LOC_CD
        '
        Me.GV2_LOC_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_LOC_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_LOC_CD.Caption = "장소"
        Me.GV2_LOC_CD.FieldName = "LOC_CD"
        Me.GV2_LOC_CD.Name = "GV2_LOC_CD"
        Me.GV2_LOC_CD.Visible = True
        Me.GV2_LOC_CD.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GV2_LOC_CD, "장소")
        '
        'GV2_DEPT_CD
        '
        Me.GV2_DEPT_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DEPT_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DEPT_CD.Caption = "담당부서"
        Me.GV2_DEPT_CD.FieldName = "DEPT_CD"
        Me.GV2_DEPT_CD.Name = "GV2_DEPT_CD"
        Me.GV2_DEPT_CD.Visible = True
        Me.GV2_DEPT_CD.VisibleIndex = 6
        Me.GV2_DEPT_CD.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_DEPT_CD, "담당부서")
        '
        'GV2_DEPT_PIC_NM
        '
        Me.GV2_DEPT_PIC_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DEPT_PIC_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DEPT_PIC_NM.Caption = "담당자"
        Me.GV2_DEPT_PIC_NM.FieldName = "DEPT_PIC_NM"
        Me.GV2_DEPT_PIC_NM.Name = "GV2_DEPT_PIC_NM"
        Me.GV2_DEPT_PIC_NM.Visible = True
        Me.GV2_DEPT_PIC_NM.VisibleIndex = 7
        Me.Localizer1.SetWordID(Me.GV2_DEPT_PIC_NM, "담당자")
        '
        'GV2_CUST_PIC_NM
        '
        Me.GV2_CUST_PIC_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CUST_PIC_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUST_PIC_NM.Caption = "업체담당자"
        Me.GV2_CUST_PIC_NM.FieldName = "CUST_PIC_NM"
        Me.GV2_CUST_PIC_NM.Name = "GV2_CUST_PIC_NM"
        Me.GV2_CUST_PIC_NM.Visible = True
        Me.GV2_CUST_PIC_NM.VisibleIndex = 8
        Me.Localizer1.SetWordID(Me.GV2_CUST_PIC_NM, "업체담당자")
        '
        'GV2_PLAN_FM_YMD
        '
        Me.GV2_PLAN_FM_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_PLAN_FM_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_PLAN_FM_YMD.Caption = "계획시작일"
        Me.GV2_PLAN_FM_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV2_PLAN_FM_YMD.FieldName = "PLAN_FM_YMD"
        Me.GV2_PLAN_FM_YMD.Name = "GV2_PLAN_FM_YMD"
        Me.GV2_PLAN_FM_YMD.Visible = True
        Me.GV2_PLAN_FM_YMD.VisibleIndex = 9
        Me.GV2_PLAN_FM_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV2_PLAN_FM_YMD, "계획시작일")
        '
        'RepositoryItemDateBoxEdit1
        '
        Me.RepositoryItemDateBoxEdit1.AutoHeight = False
        Me.RepositoryItemDateBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateBoxEdit1.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemDateBoxEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemDateBoxEdit1.Mask.SaveLiteral = False
        Me.RepositoryItemDateBoxEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateBoxEdit1.Name = "RepositoryItemDateBoxEdit1"
        '
        'GV2_PLAN_TO_YMD
        '
        Me.GV2_PLAN_TO_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_PLAN_TO_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_PLAN_TO_YMD.Caption = "계획종료일"
        Me.GV2_PLAN_TO_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV2_PLAN_TO_YMD.FieldName = "PLAN_TO_YMD"
        Me.GV2_PLAN_TO_YMD.Name = "GV2_PLAN_TO_YMD"
        Me.GV2_PLAN_TO_YMD.Visible = True
        Me.GV2_PLAN_TO_YMD.VisibleIndex = 10
        Me.GV2_PLAN_TO_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV2_PLAN_TO_YMD, "계획종료일")
        '
        'GV2_PROC_FM_YMD
        '
        Me.GV2_PROC_FM_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_PROC_FM_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_PROC_FM_YMD.Caption = "실제시작일"
        Me.GV2_PROC_FM_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV2_PROC_FM_YMD.FieldName = "PROC_FM_YMD"
        Me.GV2_PROC_FM_YMD.Name = "GV2_PROC_FM_YMD"
        Me.GV2_PROC_FM_YMD.Visible = True
        Me.GV2_PROC_FM_YMD.VisibleIndex = 11
        Me.GV2_PROC_FM_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV2_PROC_FM_YMD, "실제시작일")
        '
        'GV2_PROC_TO_YMD
        '
        Me.GV2_PROC_TO_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_PROC_TO_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_PROC_TO_YMD.Caption = "실제종료일"
        Me.GV2_PROC_TO_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV2_PROC_TO_YMD.FieldName = "PROC_TO_YMD"
        Me.GV2_PROC_TO_YMD.Name = "GV2_PROC_TO_YMD"
        Me.GV2_PROC_TO_YMD.Visible = True
        Me.GV2_PROC_TO_YMD.VisibleIndex = 12
        Me.GV2_PROC_TO_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV2_PROC_TO_YMD, "실제종료일")
        '
        'GV2_WORK_RATE
        '
        Me.GV2_WORK_RATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_WORK_RATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_WORK_RATE.Caption = "작업기간"
        Me.GV2_WORK_RATE.FieldName = "WORK_RATE"
        Me.GV2_WORK_RATE.Name = "GV2_WORK_RATE"
        Me.GV2_WORK_RATE.OptionsColumn.AllowEdit = False
        Me.GV2_WORK_RATE.OptionsColumn.ReadOnly = True
        Me.GV2_WORK_RATE.OptionsColumn.ShowInCustomizationForm = False
        Me.GV2_WORK_RATE.Visible = True
        Me.GV2_WORK_RATE.VisibleIndex = 13
        Me.Localizer1.SetWordID(Me.GV2_WORK_RATE, "작업기간")
        '
        'GV2_TEST_FM_YMD
        '
        Me.GV2_TEST_FM_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_TEST_FM_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_TEST_FM_YMD.Caption = "테스트시작일"
        Me.GV2_TEST_FM_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV2_TEST_FM_YMD.FieldName = "TEST_FM_YMD"
        Me.GV2_TEST_FM_YMD.Name = "GV2_TEST_FM_YMD"
        Me.GV2_TEST_FM_YMD.Visible = True
        Me.GV2_TEST_FM_YMD.VisibleIndex = 14
        Me.Localizer1.SetWordID(Me.GV2_TEST_FM_YMD, "테스트시작일")
        '
        'GV2_TEST_TO_YMD
        '
        Me.GV2_TEST_TO_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_TEST_TO_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_TEST_TO_YMD.Caption = "테스트종료일"
        Me.GV2_TEST_TO_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV2_TEST_TO_YMD.FieldName = "TEST_TO_YMD"
        Me.GV2_TEST_TO_YMD.Name = "GV2_TEST_TO_YMD"
        Me.GV2_TEST_TO_YMD.Visible = True
        Me.GV2_TEST_TO_YMD.VisibleIndex = 15
        Me.Localizer1.SetWordID(Me.GV2_TEST_TO_YMD, "테스트종료일")
        '
        'GV2_PROC_RATE
        '
        Me.GV2_PROC_RATE.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_PROC_RATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_PROC_RATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_PROC_RATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_PROC_RATE.Caption = "진척률"
        Me.GV2_PROC_RATE.FieldName = "PROC_RATE"
        Me.GV2_PROC_RATE.Name = "GV2_PROC_RATE"
        Me.GV2_PROC_RATE.Visible = True
        Me.GV2_PROC_RATE.VisibleIndex = 16
        Me.Localizer1.SetWordID(Me.GV2_PROC_RATE, "진척률")
        '
        'GV2_RMK
        '
        Me.GV2_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_RMK.Caption = "비고"
        Me.GV2_RMK.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GV2_RMK.FieldName = "RMK"
        Me.GV2_RMK.Name = "GV2_RMK"
        Me.GV2_RMK.Visible = True
        Me.GV2_RMK.VisibleIndex = 17
        Me.GV2_RMK.Width = 200
        Me.Localizer1.SetWordID(Me.GV2_RMK, "비고")
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None)
        Me.RepositoryItemMemoExEdit1.MaxLength = 100
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'GV2_INS_USR
        '
        Me.GV2_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INS_USR.Caption = "입력자"
        Me.GV2_INS_USR.FieldName = "INS_USR"
        Me.GV2_INS_USR.Name = "GV2_INS_USR"
        Me.GV2_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV2_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV2_INS_USR.OptionsColumn.ShowInCustomizationForm = False
        Me.GV2_INS_USR.Visible = True
        Me.GV2_INS_USR.VisibleIndex = 18
        Me.Localizer1.SetWordID(Me.GV2_INS_USR, "입력자")
        '
        'GV2_INS_YMD
        '
        Me.GV2_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INS_YMD.Caption = "입력일자"
        Me.GV2_INS_YMD.FieldName = "INS_YMD"
        Me.GV2_INS_YMD.Name = "GV2_INS_YMD"
        Me.GV2_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV2_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV2_INS_YMD.OptionsColumn.ShowInCustomizationForm = False
        Me.GV2_INS_YMD.Visible = True
        Me.GV2_INS_YMD.VisibleIndex = 19
        Me.GV2_INS_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV2_INS_YMD, "입력일자")
        '
        'GV2_UPD_USR
        '
        Me.GV2_UPD_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_UPD_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_UPD_USR.Caption = "수정자"
        Me.GV2_UPD_USR.FieldName = "UPD_USR"
        Me.GV2_UPD_USR.Name = "GV2_UPD_USR"
        Me.GV2_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV2_UPD_USR.OptionsColumn.ReadOnly = True
        Me.GV2_UPD_USR.OptionsColumn.ShowInCustomizationForm = False
        Me.GV2_UPD_USR.Visible = True
        Me.GV2_UPD_USR.VisibleIndex = 20
        Me.Localizer1.SetWordID(Me.GV2_UPD_USR, "수정자")
        '
        'GV2_UPD_YMD
        '
        Me.GV2_UPD_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_UPD_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_UPD_YMD.Caption = "수정일자"
        Me.GV2_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV2_UPD_YMD.Name = "GV2_UPD_YMD"
        Me.GV2_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV2_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.GV2_UPD_YMD.OptionsColumn.ShowInCustomizationForm = False
        Me.GV2_UPD_YMD.Visible = True
        Me.GV2_UPD_YMD.VisibleIndex = 21
        Me.GV2_UPD_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV2_UPD_YMD, "수정일자")
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GV2_rpPROC_RATE
        '
        Me.GV2_rpPROC_RATE.AutoHeight = False
        Me.GV2_rpPROC_RATE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GV2_rpPROC_RATE.Items.AddRange(New Object() {"0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.GV2_rpPROC_RATE.Name = "GV2_rpPROC_RATE"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.WG2
        Me.GridView3.Name = "GridView3"
        '
        'GV2_JOB_TYPE
        '
        Me.GV2_JOB_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_JOB_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2_JOB_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_JOB_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_JOB_TYPE.Caption = "작업 그룹명"
        Me.GV2_JOB_TYPE.FieldName = "JOB_TYPE"
        Me.GV2_JOB_TYPE.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV2_JOB_TYPE.Name = "GV2_JOB_TYPE"
        Me.GV2_JOB_TYPE.Visible = True
        Me.GV2_JOB_TYPE.VisibleIndex = 3
        Me.GV2_JOB_TYPE.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_JOB_TYPE, "작업 그룹명")
        '
        'CrmWBSMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1170, 632)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "CrmWBSMgt"
        Me.Text = "WBS 관리"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCodeBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2_rpPROC_RATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClear As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents S_DATE_TO As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents S_DATE_FM As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label32 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_DATE_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents S_SEARCH_KEY As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents S_SEARCH_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents lbl_REQ_SVC As YJIT.SC.UI.SCControls.Label
    Friend WithEvents lbl_RMK As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents MNGT_NO As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents lbl_MNGT_NO As YJIT.SC.UI.SCControls.Label
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROJECT_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FM_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TO_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROC_RATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV2_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_GRP_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_ACT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_JOB_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_LOC_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_DEPT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_DEPT_PIC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_CUST_PIC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_PLAN_FM_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_PLAN_TO_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV2_PROC_FM_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_PROC_TO_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_WORK_RATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_COM_YN As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GV2_CHK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_SORT_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_TEST_FM_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_TEST_TO_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV2_ACT_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCodeBoxEdit1 As YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit
    Friend WithEvents lbl_I_MNGT_NO As YJIT.SC.UI.SCControls.Label
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnQuickFwg1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnExpFwg1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnDelFwg1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnAddFwg1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents RepositoryItemDateBoxEdit1 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemDateBoxEdit2 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents GV2_PROC_RATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_rpPROC_RATE As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents S_DEPT_TYPE As UI.SCControls.ComboBox
    Public WithEvents S_DEPT_CD As UI.SCControls.ComboBox
    Friend WithEvents GV2_JOB_TYPE As DevExpress.XtraGrid.Columns.GridColumn
End Class
