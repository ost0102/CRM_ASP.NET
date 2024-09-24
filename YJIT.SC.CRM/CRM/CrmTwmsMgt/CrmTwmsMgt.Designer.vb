<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmTwmsMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmTwmsMgt))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Me.GV1_CHK_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CHK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.StandaloneBarDockControl10 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.StandaloneBarDockControl5 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.StandaloneBarDockControl4 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.StandaloneBarDockControl3 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.StandaloneBarDockControl2 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.StandaloneBarDockControl6 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.StandaloneBarDockControl7 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.StandaloneBarDockControl8 = New DevExpress.XtraBars.StandaloneBarDockControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.UNIPASS_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_GBUN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.S_USE_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label27 = New YJIT.SC.UI.SCControls.Label()
        Me.Label37 = New YJIT.SC.UI.SCControls.Label()
        Me.S_SVC_CD = New YJIT.SC.UI.SCControls.ComboBox()
        Me.SEARCH_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.SEARCH_KEY = New YJIT.SC.UI.SCControls.TextBox()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_ADDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_ETC_AMT_INFO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GV1_CEO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_IP_ADDRESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WEBIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PORT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SID_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SCHEMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SCHEMA_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SCHEMA_PW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_VERSION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_PW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_EDI_USERID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_EDI_USERPW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MAIL_BOX_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_NPKI_PW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WH_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REG_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_GBUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SERVER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_LOADER_LOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TAX_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INP_DT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INP_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_DT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_VPN_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_VPN_PW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UNIPASS_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_AT_LOADER_LOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_ATLAS_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_KTNET_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_KTNET_PW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CTRT_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_MATN_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_IDC_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_LICENSE_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USER_QTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_OUTSTAND_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TAX_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit2 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.NUMERIC = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label31 = New YJIT.SC.UI.SCControls.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CHK2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label24 = New YJIT.SC.UI.SCControls.Label()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUMERIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHK2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV1_CHK_CUST_CD
        '
        Me.GV1_CHK_CUST_CD.Caption = "CRM체크컬럼"
        Me.GV1_CHK_CUST_CD.FieldName = "CHK_CUST_CD"
        Me.GV1_CHK_CUST_CD.Name = "GV1_CHK_CUST_CD"
        Me.Localizer1.SetWordID(Me.GV1_CHK_CUST_CD, "CRM체크컬럼")
        '
        'GV1_USE_YN
        '
        Me.GV1_USE_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_USE_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USE_YN.Caption = "사용여부"
        Me.GV1_USE_YN.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV1_USE_YN.FieldName = "USE_YN"
        Me.GV1_USE_YN.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_USE_YN.Name = "GV1_USE_YN"
        Me.GV1_USE_YN.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_USE_YN.Visible = True
        Me.GV1_USE_YN.VisibleIndex = 0
        Me.GV1_USE_YN.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "사용여부")
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "CRM체크컬럼"
        Me.GridColumn31.FieldName = "CHK_CUST_CD"
        Me.GridColumn31.Name = "GridColumn31"
        Me.Localizer1.SetWordID(Me.GridColumn31, "CRM체크컬럼")
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "사용여부"
        Me.GridColumn1.ColumnEdit = Me.CHK
        Me.GridColumn1.FieldName = "USE_YN"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Width = 60
        Me.Localizer1.SetWordID(Me.GridColumn1, "사용여부")
        '
        'CHK
        '
        Me.CHK.AutoHeight = False
        Me.CHK.Name = "CHK"
        Me.CHK.ValueChecked = "Y"
        Me.CHK.ValueUnchecked = "N"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
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
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1382, 31)
        Me.palAutoButton.TabIndex = 1
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnSave
        '
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(1303, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'btnSearch
        '
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1227, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.GV1_CHK_CUST_CD, "CRM체크컬럼")
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "사용여부")
        Me.Localizer1.SetWordID(Me.GridColumn31, "CRM체크컬럼")
        Me.Localizer1.SetWordID(Me.GridColumn1, "사용여부")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl10, "StandaloneBarDockControl10")
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl5, "StandaloneBarDockControl5")
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl4, "StandaloneBarDockControl4")
        Me.Localizer1.SetWordID(Me.standaloneBarDockControl1, "standaloneBarDockControl1")
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl3, "StandaloneBarDockControl3")
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl2, "StandaloneBarDockControl2")
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl6, "StandaloneBarDockControl6")
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl7, "StandaloneBarDockControl7")
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl8, "StandaloneBarDockControl8")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.Label2, "로더 사용여부")
        Me.Localizer1.SetWordID(Me.UNIPASS_YN, "ALL")
        Me.Localizer1.SetWordID(Me.S_GBUN, "--Select--")
        Me.Localizer1.SetWordID(Me.Label1, "시스템")
        Me.Localizer1.SetWordID(Me.S_USE_YN, "YES")
        Me.Localizer1.SetWordID(Me.Label27, "사용여부")
        Me.Localizer1.SetWordID(Me.Label37, "시스템")
        Me.Localizer1.SetWordID(Me.S_SVC_CD, "--Select--")
        Me.Localizer1.SetWordID(Me.SEARCH_TYPE, "Search Key")
        Me.Localizer1.SetWordID(Me.SEARCH_KEY, "")
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "SplitContainerControl2")
        Me.Localizer1.SetWordID(Me.PanelControl7, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "거래처코드")
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "거래처명")
        Me.Localizer1.SetWordID(Me.GV1_CUST_ADDR, "주소")
        Me.Localizer1.SetWordID(Me.GV1_ETC_AMT_INFO, "계약 상세내용")
        Me.Localizer1.SetWordID(Me.GV1_CEO, "대표자")
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "연락처")
        Me.Localizer1.SetWordID(Me.GV1_IP_ADDRESS, "DB주소")
        Me.Localizer1.SetWordID(Me.GV1_WEBIP, "WEB주소")
        Me.Localizer1.SetWordID(Me.GV1_PORT_NO, "포트")
        Me.Localizer1.SetWordID(Me.GV1_SID_NAME, "SID")
        Me.Localizer1.SetWordID(Me.GV1_SCHEMA, "도메인(TNS)")
        Me.Localizer1.SetWordID(Me.GV1_SCHEMA_ID, "DB ID")
        Me.Localizer1.SetWordID(Me.GV1_SCHEMA_PW, "DB PW")
        Me.Localizer1.SetWordID(Me.GV1_VERSION, "소스버젼")
        Me.Localizer1.SetWordID(Me.GV1_INS_ID, "보험료ID")
        Me.Localizer1.SetWordID(Me.GV1_INS_PW, "보험료PW")
        Me.Localizer1.SetWordID(Me.GV1_EDI_USERID, "세관ID")
        Me.Localizer1.SetWordID(Me.GV1_EDI_USERPW, "세관PW")
        Me.Localizer1.SetWordID(Me.GV1_MAIL_BOX_ID, "문서함ID")
        Me.Localizer1.SetWordID(Me.GV1_NPKI_PW, "인증서PW")
        Me.Localizer1.SetWordID(Me.GV1_WH_CODE, "창고부호")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        Me.Localizer1.SetWordID(Me.GV1_REG_NO, "사업자번호")
        Me.Localizer1.SetWordID(Me.GV1_GBUN, "업무구분")
        Me.Localizer1.SetWordID(Me.GV1_SERVER, "VPN유무")
        Me.Localizer1.SetWordID(Me.GV1_LOADER_LOC, "UNIPASS 로더 실행위치")
        Me.Localizer1.SetWordID(Me.GV1_TAX_YN, "계산서전송")
        Me.Localizer1.SetWordID(Me.GV1_INP_DT, "생성일자")
        Me.Localizer1.SetWordID(Me.GV1_INP_USR, "최초생성자")
        Me.Localizer1.SetWordID(Me.GV1_UPD_DT, "수정일자")
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "수정자")
        Me.Localizer1.SetWordID(Me.GV1_VPN_ID, "VPN_ID")
        Me.Localizer1.SetWordID(Me.GV1_VPN_PW, "VPN_PW")
        Me.Localizer1.SetWordID(Me.GV1_UNIPASS_YN, "유니패스사용유무")
        Me.Localizer1.SetWordID(Me.GV1_AT_LOADER_LOC, "ATLASLOADER 실행위치")
        Me.Localizer1.SetWordID(Me.GV1_ATLAS_YN, "ATLAS 사용유무")
        Me.Localizer1.SetWordID(Me.GV1_KTNET_ID, "KTNET ID")
        Me.Localizer1.SetWordID(Me.GV1_KTNET_PW, "KTNET PW")
        Me.Localizer1.SetWordID(Me.GV1_CTRT_AMT, "설치비")
        Me.Localizer1.SetWordID(Me.GV1_MATN_AMT, "월비용")
        Me.Localizer1.SetWordID(Me.GV1_IDC_AMT, "IDC비용")
        Me.Localizer1.SetWordID(Me.GV1_LICENSE_AMT, "라이센스비")
        Me.Localizer1.SetWordID(Me.GV1_USER_QTY, "유저수")
        Me.Localizer1.SetWordID(Me.GV1_OUTSTAND_AMT, "미수금액")
        Me.Localizer1.SetWordID(Me.GV1_TAX_AMT, "계산서 발행금액")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel2, "")
        Me.Localizer1.SetWordID(Me.Label31, "유지보수 목록")
        Me.Localizer1.SetWordID(Me.GroupControl2, "차량 밀크런 스케줄")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GridColumn2, "거래처코드")
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처명")
        Me.Localizer1.SetWordID(Me.GridColumn4, "DB주소")
        Me.Localizer1.SetWordID(Me.GridColumn5, "WEB주소")
        Me.Localizer1.SetWordID(Me.GridColumn6, "포트")
        Me.Localizer1.SetWordID(Me.GridColumn7, "SID")
        Me.Localizer1.SetWordID(Me.GridColumn8, "도메인(TNS)")
        Me.Localizer1.SetWordID(Me.GridColumn9, "DB ID")
        Me.Localizer1.SetWordID(Me.GridColumn10, "DB PW")
        Me.Localizer1.SetWordID(Me.GridColumn11, "소스버젼")
        Me.Localizer1.SetWordID(Me.GridColumn12, "보험료ID")
        Me.Localizer1.SetWordID(Me.GridColumn13, "보험료PW")
        Me.Localizer1.SetWordID(Me.GridColumn14, "세관ID")
        Me.Localizer1.SetWordID(Me.GridColumn15, "세관PW")
        Me.Localizer1.SetWordID(Me.GridColumn16, "문서함ID")
        Me.Localizer1.SetWordID(Me.GridColumn17, "인증서PW")
        Me.Localizer1.SetWordID(Me.GridColumn18, "창고부호")
        Me.Localizer1.SetWordID(Me.GridColumn19, "비고")
        Me.Localizer1.SetWordID(Me.GridColumn20, "사업자번호")
        Me.Localizer1.SetWordID(Me.GridColumn21, "업무구분")
        Me.Localizer1.SetWordID(Me.GridColumn22, "VPN유무")
        Me.Localizer1.SetWordID(Me.GridColumn23, "UNIPASS 로더 실행위치")
        Me.Localizer1.SetWordID(Me.GridColumn24, "계산서전송")
        Me.Localizer1.SetWordID(Me.GridColumn25, "생성일자")
        Me.Localizer1.SetWordID(Me.GridColumn26, "최초생성자")
        Me.Localizer1.SetWordID(Me.GridColumn27, "수정일자")
        Me.Localizer1.SetWordID(Me.GridColumn28, "수정자")
        Me.Localizer1.SetWordID(Me.GridColumn29, "VPN_ID")
        Me.Localizer1.SetWordID(Me.GridColumn30, "VPN_PW")
        Me.Localizer1.SetWordID(Me.GridColumn32, "유니패스사용유무")
        Me.Localizer1.SetWordID(Me.GridColumn33, "ATLAS 실행위치")
        Me.Localizer1.SetWordID(Me.GridColumn34, "ATLAS 사용유무")
        Me.Localizer1.SetWordID(Me.GridColumn35, "KTNET ID")
        Me.Localizer1.SetWordID(Me.GridColumn36, "KTNET PW")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel3, "")
        Me.Localizer1.SetWordID(Me.Label24, "거래처 개별업데이트")
        '
        'StandaloneBarDockControl10
        '
        Me.StandaloneBarDockControl10.AutoSize = True
        Me.StandaloneBarDockControl10.CausesValidation = False
        Me.StandaloneBarDockControl10.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl10.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl10.Name = "StandaloneBarDockControl10"
        Me.StandaloneBarDockControl10.Size = New System.Drawing.Size(1396, 0)
        Me.StandaloneBarDockControl10.Text = "StandaloneBarDockControl10"
        Me.StandaloneBarDockControl10.Visible = False
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl10, "StandaloneBarDockControl10")
        '
        'StandaloneBarDockControl5
        '
        Me.StandaloneBarDockControl5.AutoSize = True
        Me.StandaloneBarDockControl5.CausesValidation = False
        Me.StandaloneBarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl5.Name = "StandaloneBarDockControl5"
        Me.StandaloneBarDockControl5.Size = New System.Drawing.Size(1396, 0)
        Me.StandaloneBarDockControl5.Text = "StandaloneBarDockControl5"
        Me.StandaloneBarDockControl5.Visible = False
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl5, "StandaloneBarDockControl5")
        '
        'StandaloneBarDockControl4
        '
        Me.StandaloneBarDockControl4.AutoSize = True
        Me.StandaloneBarDockControl4.CausesValidation = False
        Me.StandaloneBarDockControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl4.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl4.Name = "StandaloneBarDockControl4"
        Me.StandaloneBarDockControl4.Size = New System.Drawing.Size(1396, 0)
        Me.StandaloneBarDockControl4.Text = "StandaloneBarDockControl4"
        Me.StandaloneBarDockControl4.Visible = False
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl4, "StandaloneBarDockControl4")
        '
        'standaloneBarDockControl1
        '
        Me.standaloneBarDockControl1.AutoSize = True
        Me.standaloneBarDockControl1.CausesValidation = False
        Me.standaloneBarDockControl1.Location = New System.Drawing.Point(977, 338)
        Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
        Me.standaloneBarDockControl1.Size = New System.Drawing.Size(269, 0)
        Me.standaloneBarDockControl1.Text = "standaloneBarDockControl1"
        Me.standaloneBarDockControl1.Visible = False
        Me.Localizer1.SetWordID(Me.standaloneBarDockControl1, "standaloneBarDockControl1")
        '
        'StandaloneBarDockControl3
        '
        Me.StandaloneBarDockControl3.AutoSize = True
        Me.StandaloneBarDockControl3.CausesValidation = False
        Me.StandaloneBarDockControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl3.Name = "StandaloneBarDockControl3"
        Me.StandaloneBarDockControl3.Size = New System.Drawing.Size(1396, 0)
        Me.StandaloneBarDockControl3.Text = "StandaloneBarDockControl3"
        Me.StandaloneBarDockControl3.Visible = False
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl3, "StandaloneBarDockControl3")
        '
        'StandaloneBarDockControl2
        '
        Me.StandaloneBarDockControl2.AutoSize = True
        Me.StandaloneBarDockControl2.CausesValidation = False
        Me.StandaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl2.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl2.Name = "StandaloneBarDockControl2"
        Me.StandaloneBarDockControl2.Size = New System.Drawing.Size(1396, 0)
        Me.StandaloneBarDockControl2.Text = "StandaloneBarDockControl2"
        Me.StandaloneBarDockControl2.Visible = False
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl2, "StandaloneBarDockControl2")
        '
        'StandaloneBarDockControl6
        '
        Me.StandaloneBarDockControl6.AutoSize = True
        Me.StandaloneBarDockControl6.CausesValidation = False
        Me.StandaloneBarDockControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl6.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl6.Name = "StandaloneBarDockControl6"
        Me.StandaloneBarDockControl6.Size = New System.Drawing.Size(1396, 0)
        Me.StandaloneBarDockControl6.Text = "StandaloneBarDockControl6"
        Me.StandaloneBarDockControl6.Visible = False
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl6, "StandaloneBarDockControl6")
        '
        'StandaloneBarDockControl7
        '
        Me.StandaloneBarDockControl7.AutoSize = True
        Me.StandaloneBarDockControl7.CausesValidation = False
        Me.StandaloneBarDockControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl7.Name = "StandaloneBarDockControl7"
        Me.StandaloneBarDockControl7.Size = New System.Drawing.Size(1396, 0)
        Me.StandaloneBarDockControl7.Text = "StandaloneBarDockControl7"
        Me.StandaloneBarDockControl7.Visible = False
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl7, "StandaloneBarDockControl7")
        '
        'StandaloneBarDockControl8
        '
        Me.StandaloneBarDockControl8.AutoSize = True
        Me.StandaloneBarDockControl8.CausesValidation = False
        Me.StandaloneBarDockControl8.Dock = System.Windows.Forms.DockStyle.Top
        Me.StandaloneBarDockControl8.Location = New System.Drawing.Point(0, 0)
        Me.StandaloneBarDockControl8.Name = "StandaloneBarDockControl8"
        Me.StandaloneBarDockControl8.Size = New System.Drawing.Size(1396, 0)
        Me.StandaloneBarDockControl8.Text = "StandaloneBarDockControl8"
        Me.StandaloneBarDockControl8.Visible = False
        Me.Localizer1.SetWordID(Me.StandaloneBarDockControl8, "StandaloneBarDockControl8")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.UNIPASS_YN)
        Me.PanelControl1.Controls.Add(Me.S_GBUN)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.S_USE_YN)
        Me.PanelControl1.Controls.Add(Me.Label27)
        Me.PanelControl1.Controls.Add(Me.Label37)
        Me.PanelControl1.Controls.Add(Me.S_SVC_CD)
        Me.PanelControl1.Controls.Add(Me.SEARCH_TYPE)
        Me.PanelControl1.Controls.Add(Me.SEARCH_KEY)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 42)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1382, 33)
        Me.PanelControl1.TabIndex = 9
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(837, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "로더 사용여부"
        Me.Localizer1.SetWordID(Me.Label2, "로더 사용여부")
        '
        'UNIPASS_YN
        '
        Me.UNIPASS_YN.CodeType = ""
        Me.UNIPASS_YN.ColumnWidths = ""
        Me.UNIPASS_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.UNIPASS_YN.DataParams = ""
        Me.UNIPASS_YN.DefVal = "A"
        Me.UNIPASS_YN.DisplayMember = "NAME"
        Me.UNIPASS_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UNIPASS_YN.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.UNIPASS_YN.FormattingEnabled = True
        Me.UNIPASS_YN.IsDataStateAware = True
        Me.UNIPASS_YN.ItemDelimiter = ","
        Me.UNIPASS_YN.ItemTextList = "YES,NO,ALL"
        Me.UNIPASS_YN.ItemValueList = "Y,N,A"
        Me.UNIPASS_YN.KeepIntegrity = True
        Me.UNIPASS_YN.Location = New System.Drawing.Point(931, 6)
        Me.UNIPASS_YN.Name = "UNIPASS_YN"
        Me.UNIPASS_YN.NextFocus = "Se&arch"
        Me.UNIPASS_YN.NullText = ""
        Me.UNIPASS_YN.SearchKeys = ""
        Me.UNIPASS_YN.Size = New System.Drawing.Size(51, 21)
        Me.UNIPASS_YN.TabIndex = 68
        Me.UNIPASS_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.UNIPASS_YN.ValueMember = "CODE"
        '
        'S_GBUN
        '
        Me.S_GBUN.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_GBUN.ColumnWidths = ""
        Me.S_GBUN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_GBUN.DataParams = "GroupCode:'TW01',NameType:''"
        Me.S_GBUN.DefVal = ""
        Me.S_GBUN.DisplayMember = "NAME"
        Me.S_GBUN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_GBUN.FormattingEnabled = True
        Me.S_GBUN.IsDataStateAware = True
        Me.S_GBUN.ItemDelimiter = ","
        Me.S_GBUN.ItemTextList = ""
        Me.S_GBUN.ItemValueList = ""
        Me.S_GBUN.KeepIntegrity = True
        Me.S_GBUN.Location = New System.Drawing.Point(333, 5)
        Me.S_GBUN.Name = "S_GBUN"
        Me.S_GBUN.NextFocus = "S_USE_YN"
        Me.S_GBUN.NullText = "--Select--"
        Me.S_GBUN.SearchKeys = ""
        Me.S_GBUN.Size = New System.Drawing.Size(120, 22)
        Me.S_GBUN.TabIndex = 67
        Me.S_GBUN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_GBUN.ValueMember = "CODE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(630, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "시스템"
        Me.Localizer1.SetWordID(Me.Label1, "시스템")
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
        Me.S_USE_YN.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.S_USE_YN.FormattingEnabled = True
        Me.S_USE_YN.IsDataStateAware = True
        Me.S_USE_YN.ItemDelimiter = ","
        Me.S_USE_YN.ItemTextList = "YES,NO"
        Me.S_USE_YN.ItemValueList = "Y,N"
        Me.S_USE_YN.KeepIntegrity = True
        Me.S_USE_YN.Location = New System.Drawing.Point(534, 6)
        Me.S_USE_YN.Name = "S_USE_YN"
        Me.S_USE_YN.NextFocus = "Se&arch"
        Me.S_USE_YN.NullText = "--Select--"
        Me.S_USE_YN.SearchKeys = ""
        Me.S_USE_YN.Size = New System.Drawing.Size(68, 21)
        Me.S_USE_YN.TabIndex = 4
        Me.S_USE_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_USE_YN.ValueMember = "CODE"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.LabelFor = Nothing
        Me.Label27.Location = New System.Drawing.Point(473, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 14)
        Me.Label27.TabIndex = 65
        Me.Label27.Text = "사용여부"
        Me.Localizer1.SetWordID(Me.Label27, "사용여부")
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.LabelFor = Nothing
        Me.Label37.Location = New System.Drawing.Point(290, 9)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(37, 14)
        Me.Label37.TabIndex = 63
        Me.Label37.Text = "시스템"
        Me.Localizer1.SetWordID(Me.Label37, "시스템")
        '
        'S_SVC_CD
        '
        Me.S_SVC_CD.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_SVC_CD.ColumnWidths = ""
        Me.S_SVC_CD.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_SVC_CD.DataParams = "GroupCode:'C01',NameType:''"
        Me.S_SVC_CD.DefVal = ""
        Me.S_SVC_CD.DisplayMember = "NAME"
        Me.S_SVC_CD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_SVC_CD.FormattingEnabled = True
        Me.S_SVC_CD.IsDataStateAware = True
        Me.S_SVC_CD.ItemDelimiter = ","
        Me.S_SVC_CD.ItemTextList = ""
        Me.S_SVC_CD.ItemValueList = ""
        Me.S_SVC_CD.KeepIntegrity = True
        Me.S_SVC_CD.Location = New System.Drawing.Point(673, 5)
        Me.S_SVC_CD.Name = "S_SVC_CD"
        Me.S_SVC_CD.NextFocus = "S_USE_YN"
        Me.S_SVC_CD.NullText = "--Select--"
        Me.S_SVC_CD.SearchKeys = ""
        Me.S_SVC_CD.Size = New System.Drawing.Size(120, 22)
        Me.S_SVC_CD.TabIndex = 3
        Me.S_SVC_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_SVC_CD.ValueMember = "CODE"
        '
        'SEARCH_TYPE
        '
        Me.SEARCH_TYPE.BackColor = System.Drawing.SystemColors.Window
        Me.SEARCH_TYPE.CodeType = ""
        Me.SEARCH_TYPE.ColumnWidths = ""
        Me.SEARCH_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.SEARCH_TYPE.DataParams = ""
        Me.SEARCH_TYPE.DefVal = "SEARCH_KEY"
        Me.SEARCH_TYPE.DisplayMember = "NAME"
        Me.SEARCH_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SEARCH_TYPE.FormattingEnabled = True
        Me.SEARCH_TYPE.IsDataStateAware = True
        Me.SEARCH_TYPE.ItemDelimiter = ","
        Me.SEARCH_TYPE.ItemTextList = "Search Key,Customer Code,Server IP"
        Me.SEARCH_TYPE.ItemValueList = "SEARCH_KEY,CUST_CD,SVR_IP"
        Me.SEARCH_TYPE.KeepIntegrity = True
        Me.SEARCH_TYPE.Location = New System.Drawing.Point(6, 5)
        Me.SEARCH_TYPE.Name = "SEARCH_TYPE"
        Me.SEARCH_TYPE.NextFocus = "SEARCH_KEY"
        Me.SEARCH_TYPE.NullText = ""
        Me.SEARCH_TYPE.SearchKeys = ""
        Me.SEARCH_TYPE.Size = New System.Drawing.Size(104, 22)
        Me.SEARCH_TYPE.TabIndex = 0
        Me.SEARCH_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.SEARCH_TYPE.ValueMember = "CODE"
        '
        'SEARCH_KEY
        '
        Me.SEARCH_KEY.BackColor = System.Drawing.SystemColors.Window
        Me.SEARCH_KEY.BorderColor = System.Drawing.Color.Silver
        Me.SEARCH_KEY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SEARCH_KEY.DefVal = ""
        Me.SEARCH_KEY.IsDataStateAware = True
        Me.SEARCH_KEY.Location = New System.Drawing.Point(116, 5)
        Me.SEARCH_KEY.Name = "SEARCH_KEY"
        Me.SEARCH_KEY.NextFocus = "S_SVC_CD"
        Me.SEARCH_KEY.Size = New System.Drawing.Size(163, 22)
        Me.SEARCH_KEY.TabIndex = 2
        Me.SEARCH_KEY.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(6, 81)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Appearance.Options.UseFont = True
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl7)
        Me.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1382, 670)
        Me.SplitContainerControl1.SplitterPosition = 198
        Me.SplitContainerControl1.TabIndex = 390
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "SplitContainerControl2")
        '
        'PanelControl7
        '
        Me.PanelControl7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl7.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.PanelControl7.Appearance.Options.UseFont = True
        Me.PanelControl7.Controls.Add(Me.WG1)
        Me.PanelControl7.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelControl7.Location = New System.Drawing.Point(1, 1)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(1375, 457)
        Me.PanelControl7.TabIndex = 221
        Me.Localizer1.SetWordID(Me.PanelControl7, "")
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
        Me.WG1.Location = New System.Drawing.Point(5, 37)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit2, Me.RepositoryItemMemoEdit2, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemCheckEdit1, Me.RepositoryItemMemoEdit3, Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemDateEdit2, Me.NUMERIC, Me.RepositoryItemButtonEdit1, Me.RepositoryItemTextEdit7})
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = True
        Me.WG1.Size = New System.Drawing.Size(1365, 415)
        Me.WG1.TabIndex = 218
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_USE_YN, Me.GV1_CUST_CD, Me.GV1_CUST_NM, Me.GV1_CUST_ADDR, Me.GV1_ETC_AMT_INFO, Me.GV1_CEO, Me.GV1_TEL_NO, Me.GV1_IP_ADDRESS, Me.GV1_WEBIP, Me.GV1_PORT_NO, Me.GV1_SID_NAME, Me.GV1_SCHEMA, Me.GV1_SCHEMA_ID, Me.GV1_SCHEMA_PW, Me.GV1_VERSION, Me.GV1_INS_ID, Me.GV1_INS_PW, Me.GV1_EDI_USERID, Me.GV1_EDI_USERPW, Me.GV1_MAIL_BOX_ID, Me.GV1_NPKI_PW, Me.GV1_WH_CODE, Me.GV1_RMK, Me.GV1_REG_NO, Me.GV1_GBUN, Me.GV1_SERVER, Me.GV1_LOADER_LOC, Me.GV1_TAX_YN, Me.GV1_INP_DT, Me.GV1_INP_USR, Me.GV1_UPD_DT, Me.GV1_UPD_USR, Me.GV1_VPN_ID, Me.GV1_VPN_PW, Me.GV1_CHK_CUST_CD, Me.GV1_UNIPASS_YN, Me.GV1_AT_LOADER_LOC, Me.GV1_ATLAS_YN, Me.GV1_KTNET_ID, Me.GV1_KTNET_PW, Me.GV1_CTRT_AMT, Me.GV1_MATN_AMT, Me.GV1_IDC_AMT, Me.GV1_LICENSE_AMT, Me.GV1_USER_QTY, Me.GV1_OUTSTAND_AMT, Me.GV1_TAX_AMT})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.GV1_CHK_CUST_CD
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.LightBlue
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue1.Expression = "[CHK_CUST_CD] <> [CUST_CD]"
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.GV1_USE_YN
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.SlateGray
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue2.Expression = "[USE_YN] = 'N' And [CHK_CUST_CD] = [CUST_CD]"
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.GV1.FormatRules.Add(GridFormatRule1)
        Me.GV1.FormatRules.Add(GridFormatRule2)
        Me.GV1.GridControl = Me.WG1
        Me.GV1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "CUST_CD", Me.GV1_CUST_CD, "(Code: Count={0})")})
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsCustomization.AllowRowSizing = True
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.RowAutoHeight = True
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.OptionsView.ShowViewCaption = True
        Me.GV1.RowHeight = 10
        Me.GV1.ViewCaption = " 거래처 목록"
        '
        'GV1_CUST_CD
        '
        Me.GV1_CUST_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.Caption = "거래처코드"
        Me.GV1_CUST_CD.FieldName = "CUST_CD"
        Me.GV1_CUST_CD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_CUST_CD.Name = "GV1_CUST_CD"
        Me.GV1_CUST_CD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CUST_CD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CUST_CD", "{0}")})
        Me.GV1_CUST_CD.Visible = True
        Me.GV1_CUST_CD.VisibleIndex = 1
        Me.GV1_CUST_CD.Width = 79
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "거래처코드")
        '
        'GV1_CUST_NM
        '
        Me.GV1_CUST_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_NM.Caption = "거래처명"
        Me.GV1_CUST_NM.FieldName = "CUST_NM"
        Me.GV1_CUST_NM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_CUST_NM.Name = "GV1_CUST_NM"
        Me.GV1_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CUST_NM.Visible = True
        Me.GV1_CUST_NM.VisibleIndex = 2
        Me.GV1_CUST_NM.Width = 200
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "거래처명")
        '
        'GV1_CUST_ADDR
        '
        Me.GV1_CUST_ADDR.Caption = "주소"
        Me.GV1_CUST_ADDR.FieldName = "CUST_ADDR"
        Me.GV1_CUST_ADDR.Name = "GV1_CUST_ADDR"
        Me.GV1_CUST_ADDR.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_ADDR.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_ADDR.Visible = True
        Me.GV1_CUST_ADDR.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GV1_CUST_ADDR, "")
        '
        'GV1_ETC_AMT_INFO
        '
        Me.GV1_ETC_AMT_INFO.Caption = "계약 상세내용"
        Me.GV1_ETC_AMT_INFO.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GV1_ETC_AMT_INFO.FieldName = "ETC_AMT_INFO"
        Me.GV1_ETC_AMT_INFO.Name = "GV1_ETC_AMT_INFO"
        Me.GV1_ETC_AMT_INFO.OptionsColumn.ReadOnly = True
        Me.GV1_ETC_AMT_INFO.Visible = True
        Me.GV1_ETC_AMT_INFO.VisibleIndex = 41
        Me.GV1_ETC_AMT_INFO.Width = 91
        Me.Localizer1.SetWordID(Me.GV1_ETC_AMT_INFO, "")
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'GV1_CEO
        '
        Me.GV1_CEO.Caption = "대표자"
        Me.GV1_CEO.FieldName = "CEO"
        Me.GV1_CEO.Name = "GV1_CEO"
        Me.GV1_CEO.OptionsColumn.AllowEdit = False
        Me.GV1_CEO.OptionsColumn.ReadOnly = True
        Me.GV1_CEO.Visible = True
        Me.GV1_CEO.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GV1_CEO, "")
        '
        'GV1_TEL_NO
        '
        Me.GV1_TEL_NO.Caption = "연락처"
        Me.GV1_TEL_NO.FieldName = "TEL_NO"
        Me.GV1_TEL_NO.Name = "GV1_TEL_NO"
        Me.GV1_TEL_NO.OptionsColumn.AllowEdit = False
        Me.GV1_TEL_NO.OptionsColumn.ReadOnly = True
        Me.GV1_TEL_NO.Visible = True
        Me.GV1_TEL_NO.VisibleIndex = 6
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "")
        '
        'GV1_IP_ADDRESS
        '
        Me.GV1_IP_ADDRESS.Caption = "DB주소"
        Me.GV1_IP_ADDRESS.FieldName = "IP_ADDRESS"
        Me.GV1_IP_ADDRESS.Name = "GV1_IP_ADDRESS"
        Me.GV1_IP_ADDRESS.Visible = True
        Me.GV1_IP_ADDRESS.VisibleIndex = 7
        Me.GV1_IP_ADDRESS.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_IP_ADDRESS, "DB주소")
        '
        'GV1_WEBIP
        '
        Me.GV1_WEBIP.Caption = "WEB주소"
        Me.GV1_WEBIP.FieldName = "WEBIP"
        Me.GV1_WEBIP.Name = "GV1_WEBIP"
        Me.GV1_WEBIP.Visible = True
        Me.GV1_WEBIP.VisibleIndex = 8
        Me.GV1_WEBIP.Width = 123
        Me.Localizer1.SetWordID(Me.GV1_WEBIP, "WEB주소")
        '
        'GV1_PORT_NO
        '
        Me.GV1_PORT_NO.Caption = "포트"
        Me.GV1_PORT_NO.FieldName = "PORT_NO"
        Me.GV1_PORT_NO.Name = "GV1_PORT_NO"
        Me.GV1_PORT_NO.Visible = True
        Me.GV1_PORT_NO.VisibleIndex = 9
        Me.Localizer1.SetWordID(Me.GV1_PORT_NO, "포트")
        '
        'GV1_SID_NAME
        '
        Me.GV1_SID_NAME.Caption = "SID"
        Me.GV1_SID_NAME.FieldName = "SID_NAME"
        Me.GV1_SID_NAME.Name = "GV1_SID_NAME"
        Me.GV1_SID_NAME.Visible = True
        Me.GV1_SID_NAME.VisibleIndex = 10
        Me.Localizer1.SetWordID(Me.GV1_SID_NAME, "SID")
        '
        'GV1_SCHEMA
        '
        Me.GV1_SCHEMA.Caption = "도메인(TNS)"
        Me.GV1_SCHEMA.FieldName = "SCHEMA"
        Me.GV1_SCHEMA.Name = "GV1_SCHEMA"
        Me.GV1_SCHEMA.Visible = True
        Me.GV1_SCHEMA.VisibleIndex = 11
        Me.GV1_SCHEMA.Width = 117
        Me.Localizer1.SetWordID(Me.GV1_SCHEMA, "도메인(TNS)")
        '
        'GV1_SCHEMA_ID
        '
        Me.GV1_SCHEMA_ID.Caption = "DB ID"
        Me.GV1_SCHEMA_ID.FieldName = "SCHEMA_ID"
        Me.GV1_SCHEMA_ID.Name = "GV1_SCHEMA_ID"
        Me.GV1_SCHEMA_ID.Visible = True
        Me.GV1_SCHEMA_ID.VisibleIndex = 12
        Me.GV1_SCHEMA_ID.Width = 87
        Me.Localizer1.SetWordID(Me.GV1_SCHEMA_ID, "DB ID")
        '
        'GV1_SCHEMA_PW
        '
        Me.GV1_SCHEMA_PW.Caption = "DB PW"
        Me.GV1_SCHEMA_PW.FieldName = "SCHEMA_PW"
        Me.GV1_SCHEMA_PW.Name = "GV1_SCHEMA_PW"
        Me.GV1_SCHEMA_PW.Visible = True
        Me.GV1_SCHEMA_PW.VisibleIndex = 13
        Me.GV1_SCHEMA_PW.Width = 91
        Me.Localizer1.SetWordID(Me.GV1_SCHEMA_PW, "DB PW")
        '
        'GV1_VERSION
        '
        Me.GV1_VERSION.Caption = "소스버젼"
        Me.GV1_VERSION.FieldName = "VERSION"
        Me.GV1_VERSION.Name = "GV1_VERSION"
        Me.GV1_VERSION.Visible = True
        Me.GV1_VERSION.VisibleIndex = 17
        Me.GV1_VERSION.Width = 87
        Me.Localizer1.SetWordID(Me.GV1_VERSION, "소스버젼")
        '
        'GV1_INS_ID
        '
        Me.GV1_INS_ID.Caption = "보험료ID"
        Me.GV1_INS_ID.FieldName = "INS_ID"
        Me.GV1_INS_ID.Name = "GV1_INS_ID"
        Me.GV1_INS_ID.Visible = True
        Me.GV1_INS_ID.VisibleIndex = 18
        Me.GV1_INS_ID.Width = 84
        Me.Localizer1.SetWordID(Me.GV1_INS_ID, "보험료ID")
        '
        'GV1_INS_PW
        '
        Me.GV1_INS_PW.Caption = "보험료PW"
        Me.GV1_INS_PW.FieldName = "INS_PW"
        Me.GV1_INS_PW.Name = "GV1_INS_PW"
        Me.GV1_INS_PW.Visible = True
        Me.GV1_INS_PW.VisibleIndex = 19
        Me.GV1_INS_PW.Width = 78
        Me.Localizer1.SetWordID(Me.GV1_INS_PW, "보험료PW")
        '
        'GV1_EDI_USERID
        '
        Me.GV1_EDI_USERID.Caption = "UNIPASS ID"
        Me.GV1_EDI_USERID.FieldName = "EDI_USERID"
        Me.GV1_EDI_USERID.Name = "GV1_EDI_USERID"
        Me.GV1_EDI_USERID.Visible = True
        Me.GV1_EDI_USERID.VisibleIndex = 20
        Me.Localizer1.SetWordID(Me.GV1_EDI_USERID, "세관ID")
        '
        'GV1_EDI_USERPW
        '
        Me.GV1_EDI_USERPW.Caption = "UNIPASS PW"
        Me.GV1_EDI_USERPW.FieldName = "EDI_USERPW"
        Me.GV1_EDI_USERPW.Name = "GV1_EDI_USERPW"
        Me.GV1_EDI_USERPW.Visible = True
        Me.GV1_EDI_USERPW.VisibleIndex = 21
        Me.Localizer1.SetWordID(Me.GV1_EDI_USERPW, "세관PW")
        '
        'GV1_MAIL_BOX_ID
        '
        Me.GV1_MAIL_BOX_ID.Caption = "문서함ID"
        Me.GV1_MAIL_BOX_ID.FieldName = "MAIL_BOX_ID"
        Me.GV1_MAIL_BOX_ID.Name = "GV1_MAIL_BOX_ID"
        Me.GV1_MAIL_BOX_ID.Visible = True
        Me.GV1_MAIL_BOX_ID.VisibleIndex = 22
        Me.GV1_MAIL_BOX_ID.Width = 93
        Me.Localizer1.SetWordID(Me.GV1_MAIL_BOX_ID, "문서함ID")
        '
        'GV1_NPKI_PW
        '
        Me.GV1_NPKI_PW.Caption = "인증서PW"
        Me.GV1_NPKI_PW.FieldName = "NPKI_PW"
        Me.GV1_NPKI_PW.Name = "GV1_NPKI_PW"
        Me.GV1_NPKI_PW.Visible = True
        Me.GV1_NPKI_PW.VisibleIndex = 23
        Me.Localizer1.SetWordID(Me.GV1_NPKI_PW, "인증서PW")
        '
        'GV1_WH_CODE
        '
        Me.GV1_WH_CODE.Caption = "창고부호"
        Me.GV1_WH_CODE.FieldName = "WH_CODE"
        Me.GV1_WH_CODE.Name = "GV1_WH_CODE"
        Me.GV1_WH_CODE.Visible = True
        Me.GV1_WH_CODE.VisibleIndex = 25
        Me.GV1_WH_CODE.Width = 83
        Me.Localizer1.SetWordID(Me.GV1_WH_CODE, "창고부호")
        '
        'GV1_RMK
        '
        Me.GV1_RMK.Caption = "비고"
        Me.GV1_RMK.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 29
        Me.GV1_RMK.Width = 290
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        '
        'GV1_REG_NO
        '
        Me.GV1_REG_NO.Caption = "사업자번호"
        Me.GV1_REG_NO.FieldName = "REG_NO"
        Me.GV1_REG_NO.Name = "GV1_REG_NO"
        Me.GV1_REG_NO.Visible = True
        Me.GV1_REG_NO.VisibleIndex = 24
        Me.GV1_REG_NO.Width = 86
        Me.Localizer1.SetWordID(Me.GV1_REG_NO, "사업자번호")
        '
        'GV1_GBUN
        '
        Me.GV1_GBUN.Caption = "업무구분"
        Me.GV1_GBUN.FieldName = "GBUN"
        Me.GV1_GBUN.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_GBUN.Name = "GV1_GBUN"
        Me.GV1_GBUN.Visible = True
        Me.GV1_GBUN.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV1_GBUN, "업무구분")
        '
        'GV1_SERVER
        '
        Me.GV1_SERVER.Caption = "VPN유무"
        Me.GV1_SERVER.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV1_SERVER.FieldName = "SERVER"
        Me.GV1_SERVER.Name = "GV1_SERVER"
        Me.GV1_SERVER.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_SERVER.Visible = True
        Me.GV1_SERVER.VisibleIndex = 14
        Me.GV1_SERVER.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_SERVER, "VPN유무")
        '
        'GV1_LOADER_LOC
        '
        Me.GV1_LOADER_LOC.Caption = "UNIPASS 로더 실행위치"
        Me.GV1_LOADER_LOC.FieldName = "LOADER_LOC"
        Me.GV1_LOADER_LOC.Name = "GV1_LOADER_LOC"
        Me.GV1_LOADER_LOC.Visible = True
        Me.GV1_LOADER_LOC.VisibleIndex = 28
        Me.GV1_LOADER_LOC.Width = 141
        Me.Localizer1.SetWordID(Me.GV1_LOADER_LOC, "UNIPASS 로더 실행위치")
        '
        'GV1_TAX_YN
        '
        Me.GV1_TAX_YN.Caption = "계산서전송"
        Me.GV1_TAX_YN.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV1_TAX_YN.FieldName = "TAX_YN"
        Me.GV1_TAX_YN.Name = "GV1_TAX_YN"
        Me.GV1_TAX_YN.Visible = True
        Me.GV1_TAX_YN.VisibleIndex = 26
        Me.GV1_TAX_YN.Width = 82
        Me.Localizer1.SetWordID(Me.GV1_TAX_YN, "계산서전송")
        '
        'GV1_INP_DT
        '
        Me.GV1_INP_DT.Caption = "생성일자"
        Me.GV1_INP_DT.FieldName = "INP_DT"
        Me.GV1_INP_DT.Name = "GV1_INP_DT"
        Me.GV1_INP_DT.OptionsColumn.AllowEdit = False
        Me.GV1_INP_DT.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_INP_DT, "생성일자")
        '
        'GV1_INP_USR
        '
        Me.GV1_INP_USR.Caption = "최초생성자"
        Me.GV1_INP_USR.FieldName = "INP_USR"
        Me.GV1_INP_USR.Name = "GV1_INP_USR"
        Me.GV1_INP_USR.OptionsColumn.AllowEdit = False
        Me.GV1_INP_USR.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_INP_USR, "최초생성자")
        '
        'GV1_UPD_DT
        '
        Me.GV1_UPD_DT.Caption = "수정일자"
        Me.GV1_UPD_DT.FieldName = "UPD_DT"
        Me.GV1_UPD_DT.Name = "GV1_UPD_DT"
        Me.GV1_UPD_DT.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_DT.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_UPD_DT, "수정일자")
        '
        'GV1_UPD_USR
        '
        Me.GV1_UPD_USR.Caption = "수정자"
        Me.GV1_UPD_USR.FieldName = "UPD_USR"
        Me.GV1_UPD_USR.Name = "GV1_UPD_USR"
        Me.GV1_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_USR.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "수정자")
        '
        'GV1_VPN_ID
        '
        Me.GV1_VPN_ID.Caption = "VPN_ID"
        Me.GV1_VPN_ID.FieldName = "VPN_ID"
        Me.GV1_VPN_ID.Name = "GV1_VPN_ID"
        Me.GV1_VPN_ID.Visible = True
        Me.GV1_VPN_ID.VisibleIndex = 15
        Me.Localizer1.SetWordID(Me.GV1_VPN_ID, "VPN_ID")
        '
        'GV1_VPN_PW
        '
        Me.GV1_VPN_PW.Caption = "VPN_PW"
        Me.GV1_VPN_PW.FieldName = "VPN_PW"
        Me.GV1_VPN_PW.Name = "GV1_VPN_PW"
        Me.GV1_VPN_PW.Visible = True
        Me.GV1_VPN_PW.VisibleIndex = 16
        Me.Localizer1.SetWordID(Me.GV1_VPN_PW, "VPN_PW")
        '
        'GV1_UNIPASS_YN
        '
        Me.GV1_UNIPASS_YN.Caption = "유니패스사용유무"
        Me.GV1_UNIPASS_YN.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV1_UNIPASS_YN.FieldName = "UNIPASS_YN"
        Me.GV1_UNIPASS_YN.Name = "GV1_UNIPASS_YN"
        Me.GV1_UNIPASS_YN.Visible = True
        Me.GV1_UNIPASS_YN.VisibleIndex = 27
        Me.GV1_UNIPASS_YN.Width = 94
        Me.Localizer1.SetWordID(Me.GV1_UNIPASS_YN, "유니패스사용유무")
        '
        'GV1_AT_LOADER_LOC
        '
        Me.GV1_AT_LOADER_LOC.Caption = "ATLASLOADER 실행위치"
        Me.GV1_AT_LOADER_LOC.FieldName = "AT_LOADER_LOC"
        Me.GV1_AT_LOADER_LOC.Name = "GV1_AT_LOADER_LOC"
        Me.GV1_AT_LOADER_LOC.Visible = True
        Me.GV1_AT_LOADER_LOC.VisibleIndex = 30
        Me.GV1_AT_LOADER_LOC.Width = 143
        Me.Localizer1.SetWordID(Me.GV1_AT_LOADER_LOC, "")
        '
        'GV1_ATLAS_YN
        '
        Me.GV1_ATLAS_YN.Caption = "ATLAS 사용유무"
        Me.GV1_ATLAS_YN.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV1_ATLAS_YN.FieldName = "ATLAS_YN"
        Me.GV1_ATLAS_YN.Name = "GV1_ATLAS_YN"
        Me.GV1_ATLAS_YN.Visible = True
        Me.GV1_ATLAS_YN.VisibleIndex = 31
        Me.GV1_ATLAS_YN.Width = 116
        Me.Localizer1.SetWordID(Me.GV1_ATLAS_YN, "")
        '
        'GV1_KTNET_ID
        '
        Me.GV1_KTNET_ID.Caption = "KTNET ID"
        Me.GV1_KTNET_ID.FieldName = "KTNET_ID"
        Me.GV1_KTNET_ID.Name = "GV1_KTNET_ID"
        Me.GV1_KTNET_ID.Visible = True
        Me.GV1_KTNET_ID.VisibleIndex = 32
        Me.Localizer1.SetWordID(Me.GV1_KTNET_ID, "")
        '
        'GV1_KTNET_PW
        '
        Me.GV1_KTNET_PW.Caption = "KTNET PW"
        Me.GV1_KTNET_PW.FieldName = "KTNET_PW"
        Me.GV1_KTNET_PW.Name = "GV1_KTNET_PW"
        Me.GV1_KTNET_PW.Visible = True
        Me.GV1_KTNET_PW.VisibleIndex = 33
        Me.Localizer1.SetWordID(Me.GV1_KTNET_PW, "")
        '
        'GV1_CTRT_AMT
        '
        Me.GV1_CTRT_AMT.Caption = "설치비"
        Me.GV1_CTRT_AMT.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.GV1_CTRT_AMT.FieldName = "CTRT_AMT"
        Me.GV1_CTRT_AMT.Name = "GV1_CTRT_AMT"
        Me.GV1_CTRT_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_CTRT_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_CTRT_AMT.Visible = True
        Me.GV1_CTRT_AMT.VisibleIndex = 34
        Me.Localizer1.SetWordID(Me.GV1_CTRT_AMT, "")
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "#,###,###,##0"
        Me.RepositoryItemTextEdit7.Mask.IgnoreMaskBlank = False
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'GV1_MATN_AMT
        '
        Me.GV1_MATN_AMT.Caption = "월비용"
        Me.GV1_MATN_AMT.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.GV1_MATN_AMT.FieldName = "MATN_AMT"
        Me.GV1_MATN_AMT.Name = "GV1_MATN_AMT"
        Me.GV1_MATN_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_MATN_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_MATN_AMT.Visible = True
        Me.GV1_MATN_AMT.VisibleIndex = 35
        Me.Localizer1.SetWordID(Me.GV1_MATN_AMT, "")
        '
        'GV1_IDC_AMT
        '
        Me.GV1_IDC_AMT.Caption = "IDC비용"
        Me.GV1_IDC_AMT.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.GV1_IDC_AMT.FieldName = "IDC_AMT"
        Me.GV1_IDC_AMT.Name = "GV1_IDC_AMT"
        Me.GV1_IDC_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_IDC_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_IDC_AMT.Visible = True
        Me.GV1_IDC_AMT.VisibleIndex = 36
        Me.Localizer1.SetWordID(Me.GV1_IDC_AMT, "")
        '
        'GV1_LICENSE_AMT
        '
        Me.GV1_LICENSE_AMT.Caption = "라이센스비"
        Me.GV1_LICENSE_AMT.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.GV1_LICENSE_AMT.FieldName = "LICENSE_AMT"
        Me.GV1_LICENSE_AMT.Name = "GV1_LICENSE_AMT"
        Me.GV1_LICENSE_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_LICENSE_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_LICENSE_AMT.Visible = True
        Me.GV1_LICENSE_AMT.VisibleIndex = 37
        Me.Localizer1.SetWordID(Me.GV1_LICENSE_AMT, "")
        '
        'GV1_USER_QTY
        '
        Me.GV1_USER_QTY.Caption = "유저수"
        Me.GV1_USER_QTY.FieldName = "USER_QTY"
        Me.GV1_USER_QTY.Name = "GV1_USER_QTY"
        Me.GV1_USER_QTY.OptionsColumn.AllowEdit = False
        Me.GV1_USER_QTY.OptionsColumn.ReadOnly = True
        Me.GV1_USER_QTY.Visible = True
        Me.GV1_USER_QTY.VisibleIndex = 38
        Me.Localizer1.SetWordID(Me.GV1_USER_QTY, "")
        '
        'GV1_OUTSTAND_AMT
        '
        Me.GV1_OUTSTAND_AMT.Caption = "미수금액"
        Me.GV1_OUTSTAND_AMT.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.GV1_OUTSTAND_AMT.FieldName = "OUTSTAND_AMT"
        Me.GV1_OUTSTAND_AMT.Name = "GV1_OUTSTAND_AMT"
        Me.GV1_OUTSTAND_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_OUTSTAND_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_OUTSTAND_AMT.Visible = True
        Me.GV1_OUTSTAND_AMT.VisibleIndex = 39
        Me.Localizer1.SetWordID(Me.GV1_OUTSTAND_AMT, "")
        '
        'GV1_TAX_AMT
        '
        Me.GV1_TAX_AMT.Caption = "계산서 발행금액"
        Me.GV1_TAX_AMT.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.GV1_TAX_AMT.FieldName = "TAX_AMT"
        Me.GV1_TAX_AMT.Name = "GV1_TAX_AMT"
        Me.GV1_TAX_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_TAX_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_TAX_AMT.Visible = True
        Me.GV1_TAX_AMT.VisibleIndex = 40
        Me.Localizer1.SetWordID(Me.GV1_TAX_AMT, "")
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
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "n"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'NUMERIC
        '
        Me.NUMERIC.AutoHeight = False
        Me.NUMERIC.Mask.EditMask = "n0"
        Me.NUMERIC.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.NUMERIC.Mask.UseMaskAsDisplayFormat = True
        Me.NUMERIC.Name = "NUMERIC"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label31, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1353, 26)
        Me.TableLayoutPanel2.TabIndex = 217
        Me.Localizer1.SetWordID(Me.TableLayoutPanel2, "")
        '
        'Label31
        '
        Me.Label31.AutoEllipsis = True
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label31.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label31.LabelFor = Nothing
        Me.Label31.Location = New System.Drawing.Point(3, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(138, 26)
        Me.Label31.TabIndex = 216
        Me.Label31.Text = "유지보수 목록"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label31, "유지보수 목록")
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.WG2)
        Me.GroupControl2.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupControl2.Location = New System.Drawing.Point(4, -6)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(1373, 199)
        Me.GroupControl2.TabIndex = 217
        Me.GroupControl2.Text = "차량 밀크런 스케줄"
        Me.Localizer1.SetWordID(Me.GroupControl2, "차량 밀크런 스케줄")
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
        Me.WG2.Location = New System.Drawing.Point(2, 37)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CHK2})
        Me.WG2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG2.SaveLayout = True
        Me.WG2.Size = New System.Drawing.Size(1370, 155)
        Me.WG2.TabIndex = 387
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36})
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Column = Me.GridColumn31
        GridFormatRule3.Name = "Format0"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.LightBlue
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue3.Expression = "[CHK_CUST_CD] <> [CUST_CD]"
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.ApplyToRow = True
        GridFormatRule4.Column = Me.GridColumn1
        GridFormatRule4.Name = "Format1"
        FormatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.SlateGray
        FormatConditionRuleValue4.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Expression
        FormatConditionRuleValue4.Expression = "[USE_YN] = 'N' And [CHK_CUST_CD] = [CUST_CD]"
        GridFormatRule4.Rule = FormatConditionRuleValue4
        Me.GV2.FormatRules.Add(GridFormatRule3)
        Me.GV2.FormatRules.Add(GridFormatRule4)
        Me.GV2.GridControl = Me.WG2
        Me.GV2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "CUST_CD", Me.GridColumn2, "(Code: Count={0})")})
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsCustomization.AllowRowSizing = True
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.RowAutoHeight = True
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV2.OptionsView.ShowViewCaption = True
        Me.GV2.RowHeight = 10
        Me.GV2.ViewCaption = " 거래처 목록"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "거래처코드"
        Me.GridColumn2.FieldName = "CUST_CD"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CUST_CD", "{0}")})
        Me.GridColumn2.Width = 79
        Me.Localizer1.SetWordID(Me.GridColumn2, "거래처코드")
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "거래처명"
        Me.GridColumn3.FieldName = "CUST_NM"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 181
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처명")
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "DB주소"
        Me.GridColumn4.FieldName = "IP_ADDRESS"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 100
        Me.Localizer1.SetWordID(Me.GridColumn4, "DB주소")
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "WEB주소"
        Me.GridColumn5.FieldName = "WEBIP"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 123
        Me.Localizer1.SetWordID(Me.GridColumn5, "WEB주소")
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "포트"
        Me.GridColumn6.FieldName = "PORT_NO"
        Me.GridColumn6.Name = "GridColumn6"
        Me.Localizer1.SetWordID(Me.GridColumn6, "포트")
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "SID"
        Me.GridColumn7.FieldName = "SID_NAME"
        Me.GridColumn7.Name = "GridColumn7"
        Me.Localizer1.SetWordID(Me.GridColumn7, "SID")
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "도메인(TNS)"
        Me.GridColumn8.FieldName = "SCHEMA"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 117
        Me.Localizer1.SetWordID(Me.GridColumn8, "도메인(TNS)")
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "DB ID"
        Me.GridColumn9.FieldName = "SCHEMA_ID"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 87
        Me.Localizer1.SetWordID(Me.GridColumn9, "DB ID")
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "DB PW"
        Me.GridColumn10.FieldName = "SCHEMA_PW"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 91
        Me.Localizer1.SetWordID(Me.GridColumn10, "DB PW")
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "소스버젼"
        Me.GridColumn11.FieldName = "VERSION"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Width = 87
        Me.Localizer1.SetWordID(Me.GridColumn11, "소스버젼")
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "보험료ID"
        Me.GridColumn12.FieldName = "INS_ID"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 3
        Me.GridColumn12.Width = 102
        Me.Localizer1.SetWordID(Me.GridColumn12, "보험료ID")
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "보험료PW"
        Me.GridColumn13.FieldName = "INS_PW"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        Me.GridColumn13.Width = 96
        Me.Localizer1.SetWordID(Me.GridColumn13, "보험료PW")
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "UNIPASS ID"
        Me.GridColumn14.FieldName = "EDI_USERID"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 5
        Me.GridColumn14.Width = 91
        Me.Localizer1.SetWordID(Me.GridColumn14, "세관ID")
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "UNIPASS PW"
        Me.GridColumn15.FieldName = "EDI_USERPW"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 6
        Me.GridColumn15.Width = 95
        Me.Localizer1.SetWordID(Me.GridColumn15, "세관PW")
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "문서함ID"
        Me.GridColumn16.FieldName = "MAIL_BOX_ID"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 7
        Me.GridColumn16.Width = 99
        Me.Localizer1.SetWordID(Me.GridColumn16, "문서함ID")
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "인증서PW"
        Me.GridColumn17.FieldName = "NPKI_PW"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 8
        Me.GridColumn17.Width = 93
        Me.Localizer1.SetWordID(Me.GridColumn17, "인증서PW")
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "창고부호"
        Me.GridColumn18.FieldName = "WH_CODE"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 11
        Me.GridColumn18.Width = 83
        Me.Localizer1.SetWordID(Me.GridColumn18, "창고부호")
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "비고"
        Me.GridColumn19.ColumnEdit = Me.RepositoryItemMemoExEdit2
        Me.GridColumn19.FieldName = "RMK"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 9
        Me.GridColumn19.Width = 259
        Me.Localizer1.SetWordID(Me.GridColumn19, "비고")
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "사업자번호"
        Me.GridColumn20.FieldName = "REG_NO"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 10
        Me.GridColumn20.Width = 86
        Me.Localizer1.SetWordID(Me.GridColumn20, "사업자번호")
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "업무구분"
        Me.GridColumn21.FieldName = "GBUN"
        Me.GridColumn21.Name = "GridColumn21"
        Me.Localizer1.SetWordID(Me.GridColumn21, "업무구분")
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "VPN유무"
        Me.GridColumn22.ColumnEdit = Me.CHK
        Me.GridColumn22.FieldName = "SERVER"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn22.Width = 60
        Me.Localizer1.SetWordID(Me.GridColumn22, "VPN유무")
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "UNIPASS 로더 실행위치"
        Me.GridColumn23.FieldName = "LOADER_LOC"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 12
        Me.GridColumn23.Width = 141
        Me.Localizer1.SetWordID(Me.GridColumn23, "UNIPASS 로더 실행위치")
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "계산서전송"
        Me.GridColumn24.ColumnEdit = Me.CHK
        Me.GridColumn24.FieldName = "TAX_YN"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 14
        Me.GridColumn24.Width = 82
        Me.Localizer1.SetWordID(Me.GridColumn24, "계산서전송")
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "생성일자"
        Me.GridColumn25.FieldName = "INP_DT"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn25, "생성일자")
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "최초생성자"
        Me.GridColumn26.FieldName = "INP_USR"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        Me.GridColumn26.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn26, "최초생성자")
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "수정일자"
        Me.GridColumn27.FieldName = "UPD_DT"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.AllowEdit = False
        Me.GridColumn27.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn27, "수정일자")
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "수정자"
        Me.GridColumn28.FieldName = "UPD_USR"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.OptionsColumn.AllowEdit = False
        Me.GridColumn28.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn28, "수정자")
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "VPN_ID"
        Me.GridColumn29.FieldName = "VPN_ID"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 1
        Me.GridColumn29.Width = 84
        Me.Localizer1.SetWordID(Me.GridColumn29, "VPN_ID")
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "VPN_PW"
        Me.GridColumn30.FieldName = "VPN_PW"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 2
        Me.GridColumn30.Width = 86
        Me.Localizer1.SetWordID(Me.GridColumn30, "VPN_PW")
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "유니패스사용유무"
        Me.GridColumn32.ColumnEdit = Me.CHK
        Me.GridColumn32.FieldName = "UNIPASS_YN"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 13
        Me.GridColumn32.Width = 94
        Me.Localizer1.SetWordID(Me.GridColumn32, "유니패스사용유무")
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "ATLAS 실행위치"
        Me.GridColumn33.FieldName = "AT_LOADER_LOC"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 15
        Me.Localizer1.SetWordID(Me.GridColumn33, "")
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "ATLAS 사용유무"
        Me.GridColumn34.ColumnEdit = Me.CHK2
        Me.GridColumn34.FieldName = "ATLAS_YN"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 16
        Me.Localizer1.SetWordID(Me.GridColumn34, "")
        '
        'CHK2
        '
        Me.CHK2.AutoHeight = False
        Me.CHK2.Name = "CHK2"
        Me.CHK2.ValueChecked = "Y"
        Me.CHK2.ValueUnchecked = "N"
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "KTNET ID"
        Me.GridColumn35.FieldName = "KTNET_ID"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 17
        Me.Localizer1.SetWordID(Me.GridColumn35, "")
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "KTNET PW"
        Me.GridColumn36.FieldName = "KTNET_PW"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 18
        Me.Localizer1.SetWordID(Me.GridColumn36, "")
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
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1366, 26)
        Me.TableLayoutPanel3.TabIndex = 386
        Me.Localizer1.SetWordID(Me.TableLayoutPanel3, "")
        '
        'Label24
        '
        Me.Label24.AutoEllipsis = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label24.LabelFor = Nothing
        Me.Label24.Location = New System.Drawing.Point(3, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(1270, 26)
        Me.Label24.TabIndex = 217
        Me.Label24.Text = "거래처 개별업데이트"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label24, "거래처 개별업데이트")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'CrmTwmsMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1396, 753)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.StandaloneBarDockControl10)
        Me.Controls.Add(Me.StandaloneBarDockControl5)
        Me.Controls.Add(Me.StandaloneBarDockControl4)
        Me.Controls.Add(Me.standaloneBarDockControl1)
        Me.Controls.Add(Me.StandaloneBarDockControl3)
        Me.Controls.Add(Me.StandaloneBarDockControl2)
        Me.Controls.Add(Me.StandaloneBarDockControl6)
        Me.Controls.Add(Me.StandaloneBarDockControl7)
        Me.Controls.Add(Me.StandaloneBarDockControl8)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "CrmTwmsMgt"
        Me.Text = "Twms 업체 관리화면"
        Me.Localizer1.SetWordID(Me, "Twms 업체 관리화면")
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUMERIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHK2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents dlgSaveExcel As SaveFileDialog
    Private WithEvents StandaloneBarDockControl10 As DevExpress.XtraBars.StandaloneBarDockControl
    Private WithEvents StandaloneBarDockControl5 As DevExpress.XtraBars.StandaloneBarDockControl
    Private WithEvents StandaloneBarDockControl4 As DevExpress.XtraBars.StandaloneBarDockControl
    Private WithEvents standaloneBarDockControl1 As DevExpress.XtraBars.StandaloneBarDockControl
    Private WithEvents StandaloneBarDockControl3 As DevExpress.XtraBars.StandaloneBarDockControl
    Private WithEvents StandaloneBarDockControl2 As DevExpress.XtraBars.StandaloneBarDockControl
    Private WithEvents StandaloneBarDockControl6 As DevExpress.XtraBars.StandaloneBarDockControl
    Private WithEvents StandaloneBarDockControl7 As DevExpress.XtraBars.StandaloneBarDockControl
    Private WithEvents StandaloneBarDockControl8 As DevExpress.XtraBars.StandaloneBarDockControl
    Friend WithEvents CHK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As SCControls.Label
    Friend WithEvents UNIPASS_YN As SCControls.ComboBox
    Friend WithEvents S_GBUN As SCControls.ComboBox
    Friend WithEvents Label1 As SCControls.Label
    Friend WithEvents S_USE_YN As SCControls.ComboBox
    Friend WithEvents Label27 As SCControls.Label
    Friend WithEvents Label37 As SCControls.Label
    Friend WithEvents S_SVC_CD As SCControls.ComboBox
    Public WithEvents SEARCH_TYPE As SCControls.ComboBox
    Public WithEvents SEARCH_KEY As SCControls.TextBox
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents WG1 As SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_USE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV1_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_IP_ADDRESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WEBIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PORT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SID_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SCHEMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SCHEMA_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SCHEMA_PW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_VERSION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_PW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_EDI_USERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_EDI_USERPW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MAIL_BOX_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_NPKI_PW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WH_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GV1_REG_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_GBUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SERVER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_LOADER_LOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TAX_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INP_DT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INP_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_DT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_VPN_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_VPN_PW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CHK_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UNIPASS_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateBoxEdit2 As SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents NUMERIC As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label31 As SCControls.Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents WG2 As SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label24 As SCControls.Label
    Friend WithEvents GV1_AT_LOADER_LOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_ATLAS_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_KTNET_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_KTNET_PW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CHK2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV1_CTRT_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MATN_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_IDC_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_LICENSE_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_USER_QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_OUTSTAND_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TAX_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_CUST_ADDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_ETC_AMT_INFO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CEO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
End Class
