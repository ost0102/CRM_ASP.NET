<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrmBigAprMgt
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmBigAprMgt))
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnApply = New YJIT.SC.UI.SCControls.Button()
        Me.pal = New DevExpress.XtraEditors.PanelControl()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_CHK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV1_APV_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_EMAIL_MSG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CRM_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_OFFICE_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CRN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpCRN = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_OFFICE_ADDR_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_OFFICE_ADDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_OFFICE_ADDR2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_EMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_HP_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_FOR_CRN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL_LAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL_SCH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL_SFI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL_TER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL_TRK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COL_UNI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PSWD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_APV_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_EMAIL_MSG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_CRM_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_COL_LAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_COL_SCH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_COL_SFI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_COL_TER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_COL_TRK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_COL_UNI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExpFwg1 = New YJIT.SC.UI.SCControls.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.S_CRN = New YJIT.SC.UI.SCControls.TextBox()
        Me.S_APV_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.lbl_CRN = New YJIT.SC.UI.SCControls.Label()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.S_EMAIL = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_Mail = New YJIT.SC.UI.SCControls.Label()
        Me.S_OFFICE_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_OFFICE_NM = New YJIT.SC.UI.SCControls.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Combo_Panel2 = New System.Windows.Forms.Panel()
        Me.Apply_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.Text_Panel = New System.Windows.Forms.Panel()
        Me.Apply_Text = New YJIT.SC.UI.SCControls.TextBox()
        Me.Combo_Panel = New System.Windows.Forms.Panel()
        Me.Apply_Status = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Apply_Type = New YJIT.SC.UI.SCControls.ComboBox()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.pal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pal.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCRN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Combo_Panel2.SuspendLayout()
        Me.Text_Panel.SuspendLayout()
        Me.Combo_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnNew, "&Clear")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.btnApply, "Apply")
        Me.Localizer1.SetWordID(Me.pal, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_CHK, "V")
        Me.Localizer1.SetWordID(Me.GV1_APV_YN, "승인상태")
        Me.Localizer1.SetWordID(Me.GV1_EMAIL_MSG, "거절사유")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV1_CRM_CD, "CRM코드")
        Me.Localizer1.SetWordID(Me.GV1_OFFICE_NM, "업체명")
        Me.Localizer1.SetWordID(Me.GV1_CRN, "사업자번호")
        Me.Localizer1.SetWordID(Me.GV1_OFFICE_ADDR_CD, "우편번호")
        Me.Localizer1.SetWordID(Me.GV1_OFFICE_ADDR, "사업장 주소")
        Me.Localizer1.SetWordID(Me.GV1_OFFICE_ADDR2, "사업장 주소(상세)")
        Me.Localizer1.SetWordID(Me.GV1_EMAIL, "E-Mail")
        Me.Localizer1.SetWordID(Me.GV1_HP_NO, "휴대폰 번호")
        Me.Localizer1.SetWordID(Me.GV1_FOR_CRN, "포워더 사업자등록번호")
        Me.Localizer1.SetWordID(Me.GV1_COL_LAT, "선적자동화")
        Me.Localizer1.SetWordID(Me.GV1_COL_SCH, "스케줄")
        Me.Localizer1.SetWordID(Me.GV1_COL_SFI, "해상운임")
        Me.Localizer1.SetWordID(Me.GV1_COL_TER, "터미널")
        Me.Localizer1.SetWordID(Me.GV1_COL_TRK, "화물추적")
        Me.Localizer1.SetWordID(Me.GV1_COL_UNI, "수입화물/수출이행")
        Me.Localizer1.SetWordID(Me.GV1_USR_ID, "아이디")
        Me.Localizer1.SetWordID(Me.GV1_PSWD, "암호")
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "입력자")
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "입력일자")
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "수정자")
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "수정일자")
        Me.Localizer1.SetWordID(Me.GV1_DB_APV_YN, "Status Copy")
        Me.Localizer1.SetWordID(Me.GV1_DB_EMAIL_MSG, "GV1_DB_EMAIL_MSG")
        Me.Localizer1.SetWordID(Me.GV1_DB_CRM_CD, "DB CRM Code")
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_LAT, "선적자동화")
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_SCH, "스케줄")
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_SFI, "해상운임")
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_TER, "터미널")
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_TRK, "화물추적")
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_UNI, "수입화물/수출이행")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel3, "")
        Me.Localizer1.SetWordID(Me.btnExpFwg1, "Button1")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.S_CRN, "")
        Me.Localizer1.SetWordID(Me.S_APV_YN, "--Select--")
        Me.Localizer1.SetWordID(Me.lbl_CRN, "사업자번호")
        Me.Localizer1.SetWordID(Me.Label1, "승인상태")
        Me.Localizer1.SetWordID(Me.S_EMAIL, "")
        Me.Localizer1.SetWordID(Me.lbl_Mail, "E-mail")
        Me.Localizer1.SetWordID(Me.S_OFFICE_NM, "")
        Me.Localizer1.SetWordID(Me.lbl_OFFICE_NM, "업체명")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.Combo_Panel2, "")
        Me.Localizer1.SetWordID(Me.Apply_YN, "--Select--")
        Me.Localizer1.SetWordID(Me.Label2, "일괄적용")
        Me.Localizer1.SetWordID(Me.Text_Panel, "")
        Me.Localizer1.SetWordID(Me.Apply_Text, "")
        Me.Localizer1.SetWordID(Me.Combo_Panel, "")
        Me.Localizer1.SetWordID(Me.Apply_Status, "--Select--")
        Me.Localizer1.SetWordID(Me.Apply_Type, "--Select--")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(996, 32)
        Me.palAutoButton.TabIndex = 85
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNew.Location = New System.Drawing.Point(836, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(70, 25)
        Me.btnNew.TabIndex = 211
        Me.btnNew.Text = "초기화(&C)"
        Me.Localizer1.SetWordID(Me.btnNew, "&Clear")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(912, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "저장(&S)"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(760, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "조회(&A)"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'btnApply
        '
        Me.btnApply.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnApply.Location = New System.Drawing.Point(354, 4)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(70, 25)
        Me.btnApply.TabIndex = 258
        Me.btnApply.Text = "적용"
        Me.Localizer1.SetWordID(Me.btnApply, "Apply")
        '
        'pal
        '
        Me.pal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pal.Controls.Add(Me.WG1)
        Me.pal.Controls.Add(Me.TableLayoutPanel3)
        Me.pal.Location = New System.Drawing.Point(6, 121)
        Me.pal.Name = "pal"
        Me.pal.Size = New System.Drawing.Size(996, 514)
        Me.pal.TabIndex = 251
        Me.Localizer1.SetWordID(Me.pal, "")
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
        Me.WG1.Location = New System.Drawing.Point(8, 30)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.rpCheckEdit, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit6, Me.rpCRN})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(980, 477)
        Me.WG1.TabIndex = 262
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GridView14, Me.GridView15})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_CHK, Me.GV1_APV_YN, Me.GV1_EMAIL_MSG, Me.GV1_MNGT_NO, Me.GV1_CRM_CD, Me.GV1_USR_ID, Me.GV1_OFFICE_NM, Me.GV1_CRN, Me.GV1_OFFICE_ADDR_CD, Me.GV1_OFFICE_ADDR, Me.GV1_OFFICE_ADDR2, Me.GV1_EMAIL, Me.GV1_HP_NO, Me.GV1_FOR_CRN, Me.GV1_COL_LAT, Me.GV1_COL_SCH, Me.GV1_COL_SFI, Me.GV1_COL_TER, Me.GV1_COL_TRK, Me.GV1_COL_UNI, Me.GV1_PSWD, Me.GV1_INS_USR, Me.GV1_INS_YMD, Me.GV1_UPD_USR, Me.GV1_UPD_YMD, Me.GV1_DB_APV_YN, Me.GV1_DB_EMAIL_MSG, Me.GV1_DB_CRM_CD, Me.GV1_DB_COL_LAT, Me.GV1_DB_COL_SCH, Me.GV1_DB_COL_SFI, Me.GV1_DB_COL_TER, Me.GV1_DB_COL_TRK, Me.GV1_DB_COL_UNI})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.ViewCaption = " Freight Infomation"
        Me.GV1.ViewCaptionHeight = 10
        '
        'GV1_CHK
        '
        Me.GV1_CHK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CHK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CHK.Caption = "V"
        Me.GV1_CHK.ColumnEdit = Me.rpCheckEdit
        Me.GV1_CHK.FieldName = "CHK"
        Me.GV1_CHK.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_CHK.Name = "GV1_CHK"
        Me.GV1_CHK.OptionsColumn.AllowMove = False
        Me.GV1_CHK.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1_CHK.Visible = True
        Me.GV1_CHK.VisibleIndex = 0
        Me.GV1_CHK.Width = 20
        Me.Localizer1.SetWordID(Me.GV1_CHK, "V")
        '
        'rpCheckEdit
        '
        Me.rpCheckEdit.AutoHeight = False
        Me.rpCheckEdit.Name = "rpCheckEdit"
        Me.rpCheckEdit.ValueChecked = "Y"
        Me.rpCheckEdit.ValueUnchecked = "N"
        '
        'GV1_APV_YN
        '
        Me.GV1_APV_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_APV_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_APV_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_APV_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_APV_YN.Caption = "승인상태"
        Me.GV1_APV_YN.FieldName = "APV_YN"
        Me.GV1_APV_YN.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_APV_YN.Name = "GV1_APV_YN"
        Me.GV1_APV_YN.Visible = True
        Me.GV1_APV_YN.VisibleIndex = 1
        Me.GV1_APV_YN.Width = 65
        Me.Localizer1.SetWordID(Me.GV1_APV_YN, "승인상태")
        '
        'GV1_EMAIL_MSG
        '
        Me.GV1_EMAIL_MSG.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_EMAIL_MSG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_EMAIL_MSG.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_EMAIL_MSG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EMAIL_MSG.Caption = "거절사유"
        Me.GV1_EMAIL_MSG.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GV1_EMAIL_MSG.FieldName = "EMAIL_MSG"
        Me.GV1_EMAIL_MSG.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_EMAIL_MSG.Name = "GV1_EMAIL_MSG"
        Me.GV1_EMAIL_MSG.OptionsColumn.AllowMove = False
        Me.GV1_EMAIL_MSG.Visible = True
        Me.GV1_EMAIL_MSG.VisibleIndex = 2
        Me.GV1_EMAIL_MSG.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_EMAIL_MSG, "거절사유")
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.MaxLength = 200
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GV1_MNGT_NO
        '
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.Caption = "관리번호"
        Me.GV1_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV1_MNGT_NO.Name = "GV1_MNGT_NO"
        Me.GV1_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        '
        'GV1_CRM_CD
        '
        Me.GV1_CRM_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CRM_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CRM_CD.Caption = "CRM코드"
        Me.GV1_CRM_CD.FieldName = "CRM_CD"
        Me.GV1_CRM_CD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_CRM_CD.Name = "GV1_CRM_CD"
        Me.GV1_CRM_CD.Visible = True
        Me.GV1_CRM_CD.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV1_CRM_CD, "CRM코드")
        '
        'GV1_OFFICE_NM
        '
        Me.GV1_OFFICE_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_OFFICE_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_OFFICE_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_OFFICE_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_OFFICE_NM.Caption = "업체명"
        Me.GV1_OFFICE_NM.FieldName = "OFFICE_NM"
        Me.GV1_OFFICE_NM.Name = "GV1_OFFICE_NM"
        Me.GV1_OFFICE_NM.OptionsColumn.AllowEdit = False
        Me.GV1_OFFICE_NM.OptionsColumn.ReadOnly = True
        Me.GV1_OFFICE_NM.Visible = True
        Me.GV1_OFFICE_NM.VisibleIndex = 6
        Me.GV1_OFFICE_NM.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_OFFICE_NM, "업체명")
        '
        'GV1_CRN
        '
        Me.GV1_CRN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CRN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CRN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CRN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CRN.Caption = "사업자번호"
        Me.GV1_CRN.ColumnEdit = Me.rpCRN
        Me.GV1_CRN.FieldName = "CRN"
        Me.GV1_CRN.Name = "GV1_CRN"
        Me.GV1_CRN.OptionsColumn.AllowEdit = False
        Me.GV1_CRN.OptionsColumn.ReadOnly = True
        Me.GV1_CRN.Visible = True
        Me.GV1_CRN.VisibleIndex = 8
        Me.GV1_CRN.Width = 94
        Me.Localizer1.SetWordID(Me.GV1_CRN, "사업자번호")
        '
        'rpCRN
        '
        Me.rpCRN.AutoHeight = False
        Me.rpCRN.Mask.EditMask = "999-99-99999"
        Me.rpCRN.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.rpCRN.Mask.SaveLiteral = False
        Me.rpCRN.Mask.UseMaskAsDisplayFormat = True
        Me.rpCRN.Name = "rpCRN"
        '
        'GV1_OFFICE_ADDR_CD
        '
        Me.GV1_OFFICE_ADDR_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_OFFICE_ADDR_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_OFFICE_ADDR_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_OFFICE_ADDR_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_OFFICE_ADDR_CD.Caption = "우편번호"
        Me.GV1_OFFICE_ADDR_CD.FieldName = "OFFICE_ADDR_CD"
        Me.GV1_OFFICE_ADDR_CD.Name = "GV1_OFFICE_ADDR_CD"
        Me.GV1_OFFICE_ADDR_CD.OptionsColumn.AllowEdit = False
        Me.GV1_OFFICE_ADDR_CD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_OFFICE_ADDR_CD, "우편번호")
        '
        'GV1_OFFICE_ADDR
        '
        Me.GV1_OFFICE_ADDR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_OFFICE_ADDR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_OFFICE_ADDR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_OFFICE_ADDR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_OFFICE_ADDR.Caption = "사업장 주소"
        Me.GV1_OFFICE_ADDR.FieldName = "OFFICE_ADDR"
        Me.GV1_OFFICE_ADDR.Name = "GV1_OFFICE_ADDR"
        Me.GV1_OFFICE_ADDR.OptionsColumn.AllowEdit = False
        Me.GV1_OFFICE_ADDR.OptionsColumn.ReadOnly = True
        Me.GV1_OFFICE_ADDR.Width = 200
        Me.Localizer1.SetWordID(Me.GV1_OFFICE_ADDR, "사업장 주소")
        '
        'GV1_OFFICE_ADDR2
        '
        Me.GV1_OFFICE_ADDR2.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_OFFICE_ADDR2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_OFFICE_ADDR2.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_OFFICE_ADDR2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_OFFICE_ADDR2.Caption = "사업장 주소(상세)"
        Me.GV1_OFFICE_ADDR2.FieldName = "OFFICE_ADDR2"
        Me.GV1_OFFICE_ADDR2.Name = "GV1_OFFICE_ADDR2"
        Me.GV1_OFFICE_ADDR2.OptionsColumn.AllowEdit = False
        Me.GV1_OFFICE_ADDR2.OptionsColumn.ReadOnly = True
        Me.GV1_OFFICE_ADDR2.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_OFFICE_ADDR2, "사업장 주소(상세)")
        '
        'GV1_EMAIL
        '
        Me.GV1_EMAIL.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_EMAIL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_EMAIL.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_EMAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EMAIL.Caption = "E-Mail"
        Me.GV1_EMAIL.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GV1_EMAIL.FieldName = "EMAIL"
        Me.GV1_EMAIL.Name = "GV1_EMAIL"
        Me.GV1_EMAIL.OptionsColumn.AllowEdit = False
        Me.GV1_EMAIL.OptionsColumn.ReadOnly = True
        Me.GV1_EMAIL.Visible = True
        Me.GV1_EMAIL.VisibleIndex = 7
        Me.GV1_EMAIL.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_EMAIL, "E-Mail")
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.MaxLength = 50
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GV1_HP_NO
        '
        Me.GV1_HP_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_HP_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_HP_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_HP_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_HP_NO.Caption = "휴대폰 번호"
        Me.GV1_HP_NO.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.GV1_HP_NO.FieldName = "HP_NO"
        Me.GV1_HP_NO.Name = "GV1_HP_NO"
        Me.GV1_HP_NO.OptionsColumn.AllowEdit = False
        Me.GV1_HP_NO.OptionsColumn.AllowMove = False
        Me.GV1_HP_NO.OptionsColumn.ReadOnly = True
        Me.GV1_HP_NO.Visible = True
        Me.GV1_HP_NO.VisibleIndex = 9
        Me.GV1_HP_NO.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_HP_NO, "휴대폰 번호")
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.EditFormat.FormatString = "###-####-####"
        Me.RepositoryItemTextEdit6.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit6.Mask.EditMask = "(\(\d\d\d\))?\d{1,3}-\d\d\d\d-\d\d\d\d"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.MaxLength = 50
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'GV1_FOR_CRN
        '
        Me.GV1_FOR_CRN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FOR_CRN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FOR_CRN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FOR_CRN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FOR_CRN.Caption = "포워더 사업자등록번호"
        Me.GV1_FOR_CRN.ColumnEdit = Me.rpCRN
        Me.GV1_FOR_CRN.FieldName = "FOR_CRN"
        Me.GV1_FOR_CRN.Name = "GV1_FOR_CRN"
        Me.GV1_FOR_CRN.OptionsColumn.AllowEdit = False
        Me.GV1_FOR_CRN.OptionsColumn.ReadOnly = True
        Me.GV1_FOR_CRN.Visible = True
        Me.GV1_FOR_CRN.VisibleIndex = 5
        Me.GV1_FOR_CRN.Width = 115
        Me.Localizer1.SetWordID(Me.GV1_FOR_CRN, "포워더 사업자등록번호")
        '
        'GV1_COL_LAT
        '
        Me.GV1_COL_LAT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL_LAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_LAT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL_LAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_LAT.Caption = "선적자동화"
        Me.GV1_COL_LAT.ColumnEdit = Me.rpCheckEdit
        Me.GV1_COL_LAT.FieldName = "COL_LAT"
        Me.GV1_COL_LAT.Name = "GV1_COL_LAT"
        Me.GV1_COL_LAT.Visible = True
        Me.GV1_COL_LAT.VisibleIndex = 10
        Me.GV1_COL_LAT.Width = 45
        Me.Localizer1.SetWordID(Me.GV1_COL_LAT, "선적자동화")
        '
        'GV1_COL_SCH
        '
        Me.GV1_COL_SCH.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL_SCH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_SCH.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL_SCH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_SCH.Caption = "스케줄"
        Me.GV1_COL_SCH.ColumnEdit = Me.rpCheckEdit
        Me.GV1_COL_SCH.FieldName = "COL_SCH"
        Me.GV1_COL_SCH.Name = "GV1_COL_SCH"
        Me.GV1_COL_SCH.Visible = True
        Me.GV1_COL_SCH.VisibleIndex = 11
        Me.GV1_COL_SCH.Width = 45
        Me.Localizer1.SetWordID(Me.GV1_COL_SCH, "스케줄")
        '
        'GV1_COL_SFI
        '
        Me.GV1_COL_SFI.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL_SFI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_SFI.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL_SFI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_SFI.Caption = "해상운임"
        Me.GV1_COL_SFI.ColumnEdit = Me.rpCheckEdit
        Me.GV1_COL_SFI.FieldName = "COL_SFI"
        Me.GV1_COL_SFI.Name = "GV1_COL_SFI"
        Me.GV1_COL_SFI.Visible = True
        Me.GV1_COL_SFI.VisibleIndex = 12
        Me.GV1_COL_SFI.Width = 45
        Me.Localizer1.SetWordID(Me.GV1_COL_SFI, "해상운임")
        '
        'GV1_COL_TER
        '
        Me.GV1_COL_TER.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL_TER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_TER.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL_TER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_TER.Caption = "터미널"
        Me.GV1_COL_TER.ColumnEdit = Me.rpCheckEdit
        Me.GV1_COL_TER.FieldName = "COL_TER"
        Me.GV1_COL_TER.Name = "GV1_COL_TER"
        Me.GV1_COL_TER.Visible = True
        Me.GV1_COL_TER.VisibleIndex = 13
        Me.GV1_COL_TER.Width = 45
        Me.Localizer1.SetWordID(Me.GV1_COL_TER, "터미널")
        '
        'GV1_COL_TRK
        '
        Me.GV1_COL_TRK.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL_TRK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_TRK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL_TRK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_TRK.Caption = "화물추적"
        Me.GV1_COL_TRK.ColumnEdit = Me.rpCheckEdit
        Me.GV1_COL_TRK.FieldName = "COL_TRK"
        Me.GV1_COL_TRK.Name = "GV1_COL_TRK"
        Me.GV1_COL_TRK.Visible = True
        Me.GV1_COL_TRK.VisibleIndex = 14
        Me.GV1_COL_TRK.Width = 45
        Me.Localizer1.SetWordID(Me.GV1_COL_TRK, "화물추적")
        '
        'GV1_COL_UNI
        '
        Me.GV1_COL_UNI.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COL_UNI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_UNI.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COL_UNI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COL_UNI.Caption = "수입화물/수출이행"
        Me.GV1_COL_UNI.ColumnEdit = Me.rpCheckEdit
        Me.GV1_COL_UNI.FieldName = "COL_UNI"
        Me.GV1_COL_UNI.Name = "GV1_COL_UNI"
        Me.GV1_COL_UNI.Visible = True
        Me.GV1_COL_UNI.VisibleIndex = 15
        Me.GV1_COL_UNI.Width = 45
        Me.Localizer1.SetWordID(Me.GV1_COL_UNI, "수입화물/수출이행")
        '
        'GV1_USR_ID
        '
        Me.GV1_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USR_ID.Caption = "아이디"
        Me.GV1_USR_ID.FieldName = "USR_ID"
        Me.GV1_USR_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_USR_ID.Name = "GV1_USR_ID"
        Me.GV1_USR_ID.Visible = True
        Me.GV1_USR_ID.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GV1_USR_ID, "아이디")
        '
        'GV1_PSWD
        '
        Me.GV1_PSWD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PSWD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PSWD.Caption = "암호"
        Me.GV1_PSWD.FieldName = "PSWD"
        Me.GV1_PSWD.Name = "GV1_PSWD"
        Me.GV1_PSWD.OptionsColumn.AllowEdit = False
        Me.GV1_PSWD.OptionsColumn.ReadOnly = True
        Me.GV1_PSWD.Width = 55
        Me.Localizer1.SetWordID(Me.GV1_PSWD, "암호")
        '
        'GV1_INS_USR
        '
        Me.GV1_INS_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.Caption = "입력자"
        Me.GV1_INS_USR.FieldName = "INS_USR"
        Me.GV1_INS_USR.Name = "GV1_INS_USR"
        Me.GV1_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV1_INS_USR.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "입력자")
        '
        'GV1_INS_YMD
        '
        Me.GV1_INS_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_YMD.Caption = "입력일자"
        Me.GV1_INS_YMD.FieldName = "INS_YMD"
        Me.GV1_INS_YMD.Name = "GV1_INS_YMD"
        Me.GV1_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_INS_YMD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "입력일자")
        '
        'GV1_UPD_USR
        '
        Me.GV1_UPD_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPD_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_USR.Caption = "수정자"
        Me.GV1_UPD_USR.FieldName = "UPD_USR"
        Me.GV1_UPD_USR.Name = "GV1_UPD_USR"
        Me.GV1_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_USR.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "수정자")
        '
        'GV1_UPD_YMD
        '
        Me.GV1_UPD_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPD_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_YMD.Caption = "수정일자"
        Me.GV1_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV1_UPD_YMD.Name = "GV1_UPD_YMD"
        Me.GV1_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "수정일자")
        '
        'GV1_DB_APV_YN
        '
        Me.GV1_DB_APV_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DB_APV_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DB_APV_YN.Caption = "DB Status"
        Me.GV1_DB_APV_YN.FieldName = "DB_APV_YN"
        Me.GV1_DB_APV_YN.Name = "GV1_DB_APV_YN"
        Me.GV1_DB_APV_YN.OptionsColumn.AllowEdit = False
        Me.GV1_DB_APV_YN.OptionsColumn.AllowMove = False
        Me.GV1_DB_APV_YN.OptionsColumn.ReadOnly = True
        Me.GV1_DB_APV_YN.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_APV_YN, "Status Copy")
        '
        'GV1_DB_EMAIL_MSG
        '
        Me.GV1_DB_EMAIL_MSG.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DB_EMAIL_MSG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DB_EMAIL_MSG.Caption = "GV1_DB_EMAIL_MSG"
        Me.GV1_DB_EMAIL_MSG.FieldName = "DB_EMAIL_MSG"
        Me.GV1_DB_EMAIL_MSG.Name = "GV1_DB_EMAIL_MSG"
        Me.GV1_DB_EMAIL_MSG.OptionsColumn.AllowEdit = False
        Me.GV1_DB_EMAIL_MSG.OptionsColumn.ReadOnly = True
        Me.GV1_DB_EMAIL_MSG.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_EMAIL_MSG, "GV1_DB_EMAIL_MSG")
        '
        'GV1_DB_CRM_CD
        '
        Me.GV1_DB_CRM_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DB_CRM_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DB_CRM_CD.Caption = "DB CRM Code"
        Me.GV1_DB_CRM_CD.FieldName = "DB_CRM_CD"
        Me.GV1_DB_CRM_CD.Name = "GV1_DB_CRM_CD"
        Me.GV1_DB_CRM_CD.OptionsColumn.AllowEdit = False
        Me.GV1_DB_CRM_CD.OptionsColumn.ReadOnly = True
        Me.GV1_DB_CRM_CD.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_CRM_CD, "")
        '
        'GV1_DB_COL_LAT
        '
        Me.GV1_DB_COL_LAT.Caption = "선적자동화"
        Me.GV1_DB_COL_LAT.FieldName = "DB_COL_LAT"
        Me.GV1_DB_COL_LAT.Name = "GV1_DB_COL_LAT"
        Me.GV1_DB_COL_LAT.OptionsColumn.AllowEdit = False
        Me.GV1_DB_COL_LAT.OptionsColumn.ReadOnly = True
        Me.GV1_DB_COL_LAT.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_LAT, "선적자동화")
        '
        'GV1_DB_COL_SCH
        '
        Me.GV1_DB_COL_SCH.Caption = "스케줄"
        Me.GV1_DB_COL_SCH.FieldName = "DB_COL_SCH"
        Me.GV1_DB_COL_SCH.Name = "GV1_DB_COL_SCH"
        Me.GV1_DB_COL_SCH.OptionsColumn.AllowEdit = False
        Me.GV1_DB_COL_SCH.OptionsColumn.ReadOnly = True
        Me.GV1_DB_COL_SCH.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_SCH, "스케줄")
        '
        'GV1_DB_COL_SFI
        '
        Me.GV1_DB_COL_SFI.Caption = "해상운임"
        Me.GV1_DB_COL_SFI.FieldName = "DB_COL_SFI"
        Me.GV1_DB_COL_SFI.Name = "GV1_DB_COL_SFI"
        Me.GV1_DB_COL_SFI.OptionsColumn.AllowEdit = False
        Me.GV1_DB_COL_SFI.OptionsColumn.ReadOnly = True
        Me.GV1_DB_COL_SFI.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_SFI, "해상운임")
        '
        'GV1_DB_COL_TER
        '
        Me.GV1_DB_COL_TER.Caption = "터미널"
        Me.GV1_DB_COL_TER.FieldName = "DB_COL_TER"
        Me.GV1_DB_COL_TER.Name = "GV1_DB_COL_TER"
        Me.GV1_DB_COL_TER.OptionsColumn.AllowEdit = False
        Me.GV1_DB_COL_TER.OptionsColumn.ReadOnly = True
        Me.GV1_DB_COL_TER.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_TER, "터미널")
        '
        'GV1_DB_COL_TRK
        '
        Me.GV1_DB_COL_TRK.Caption = "화물추적"
        Me.GV1_DB_COL_TRK.FieldName = "DB_COL_TRK"
        Me.GV1_DB_COL_TRK.Name = "GV1_DB_COL_TRK"
        Me.GV1_DB_COL_TRK.OptionsColumn.AllowEdit = False
        Me.GV1_DB_COL_TRK.OptionsColumn.ReadOnly = True
        Me.GV1_DB_COL_TRK.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_TRK, "화물추적")
        '
        'GV1_DB_COL_UNI
        '
        Me.GV1_DB_COL_UNI.Caption = "수입화물/수출이행"
        Me.GV1_DB_COL_UNI.FieldName = "DB_COL_UNI"
        Me.GV1_DB_COL_UNI.Name = "GV1_DB_COL_UNI"
        Me.GV1_DB_COL_UNI.OptionsColumn.AllowEdit = False
        Me.GV1_DB_COL_UNI.OptionsColumn.ReadOnly = True
        Me.GV1_DB_COL_UNI.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_COL_UNI, "수입화물/수출이행")
        '
        'GridView14
        '
        Me.GridView14.GridControl = Me.WG1
        Me.GridView14.Name = "GridView14"
        '
        'GridView15
        '
        Me.GridView15.GridControl = Me.WG1
        Me.GridView15.Name = "GridView15"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnExpFwg1, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(953, 1)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(35, 26)
        Me.TableLayoutPanel3.TabIndex = 250
        Me.Localizer1.SetWordID(Me.TableLayoutPanel3, "")
        '
        'btnExpFwg1
        '
        Me.btnExpFwg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExpFwg1.Image = CType(resources.GetObject("btnExpFwg1.Image"), System.Drawing.Image)
        Me.btnExpFwg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExpFwg1.Location = New System.Drawing.Point(8, 3)
        Me.btnExpFwg1.Name = "btnExpFwg1"
        Me.btnExpFwg1.Size = New System.Drawing.Size(21, 20)
        Me.btnExpFwg1.TabIndex = 215
        Me.btnExpFwg1.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnExpFwg1, "Button1")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.S_CRN)
        Me.PanelControl1.Controls.Add(Me.S_APV_YN)
        Me.PanelControl1.Controls.Add(Me.lbl_CRN)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.S_EMAIL)
        Me.PanelControl1.Controls.Add(Me.lbl_Mail)
        Me.PanelControl1.Controls.Add(Me.S_OFFICE_NM)
        Me.PanelControl1.Controls.Add(Me.lbl_OFFICE_NM)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 43)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(996, 33)
        Me.PanelControl1.TabIndex = 250
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'S_CRN
        '
        Me.S_CRN.BorderColor = System.Drawing.Color.Silver
        Me.S_CRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_CRN.DefVal = ""
        Me.S_CRN.IsDataStateAware = True
        Me.S_CRN.Location = New System.Drawing.Point(811, 5)
        Me.S_CRN.Name = "S_CRN"
        Me.S_CRN.NextFocus = "btnSearch"
        Me.S_CRN.Size = New System.Drawing.Size(120, 22)
        Me.S_CRN.TabIndex = 227
        Me.S_CRN.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'S_APV_YN
        '
        Me.S_APV_YN.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_APV_YN.ColumnWidths = ""
        Me.S_APV_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_APV_YN.DataParams = "GroupCode:'R06',NameType:'A'"
        Me.S_APV_YN.DefVal = ""
        Me.S_APV_YN.DisplayMember = "NAME"
        Me.S_APV_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_APV_YN.FormattingEnabled = True
        Me.S_APV_YN.IsDataStateAware = True
        Me.S_APV_YN.ItemDelimiter = ","
        Me.S_APV_YN.ItemTextList = ""
        Me.S_APV_YN.ItemValueList = ""
        Me.S_APV_YN.KeepIntegrity = False
        Me.S_APV_YN.Location = New System.Drawing.Point(74, 5)
        Me.S_APV_YN.Name = "S_APV_YN"
        Me.S_APV_YN.NextFocus = "S_OFFICE_NM"
        Me.S_APV_YN.NullText = "--Select--"
        Me.S_APV_YN.SearchKeys = ""
        Me.S_APV_YN.Size = New System.Drawing.Size(103, 22)
        Me.S_APV_YN.TabIndex = 225
        Me.S_APV_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_APV_YN.ValueMember = "CODE"
        '
        'lbl_CRN
        '
        Me.lbl_CRN.AutoEllipsis = True
        Me.lbl_CRN.LabelFor = Nothing
        Me.lbl_CRN.Location = New System.Drawing.Point(688, 5)
        Me.lbl_CRN.Name = "lbl_CRN"
        Me.lbl_CRN.Size = New System.Drawing.Size(117, 22)
        Me.lbl_CRN.TabIndex = 226
        Me.lbl_CRN.Text = "사업자번호"
        Me.lbl_CRN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_CRN, "사업자번호")
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "승인상태"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "승인상태")
        '
        'S_EMAIL
        '
        Me.S_EMAIL.BorderColor = System.Drawing.Color.Silver
        Me.S_EMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_EMAIL.DefVal = ""
        Me.S_EMAIL.IsDataStateAware = True
        Me.S_EMAIL.Location = New System.Drawing.Point(562, 5)
        Me.S_EMAIL.Name = "S_EMAIL"
        Me.S_EMAIL.NextFocus = "S_CRN"
        Me.S_EMAIL.Size = New System.Drawing.Size(120, 22)
        Me.S_EMAIL.TabIndex = 139
        Me.S_EMAIL.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'lbl_Mail
        '
        Me.lbl_Mail.AutoEllipsis = True
        Me.lbl_Mail.LabelFor = Nothing
        Me.lbl_Mail.Location = New System.Drawing.Point(500, 5)
        Me.lbl_Mail.Name = "lbl_Mail"
        Me.lbl_Mail.Size = New System.Drawing.Size(52, 22)
        Me.lbl_Mail.TabIndex = 138
        Me.lbl_Mail.Text = "E-mail"
        Me.lbl_Mail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_Mail, "E-mail")
        '
        'S_OFFICE_NM
        '
        Me.S_OFFICE_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_OFFICE_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_OFFICE_NM.DefVal = ""
        Me.S_OFFICE_NM.IsDataStateAware = True
        Me.S_OFFICE_NM.Location = New System.Drawing.Point(329, 5)
        Me.S_OFFICE_NM.Name = "S_OFFICE_NM"
        Me.S_OFFICE_NM.NextFocus = "S_EMAIL"
        Me.S_OFFICE_NM.Size = New System.Drawing.Size(120, 22)
        Me.S_OFFICE_NM.TabIndex = 137
        Me.S_OFFICE_NM.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'lbl_OFFICE_NM
        '
        Me.lbl_OFFICE_NM.AutoEllipsis = True
        Me.lbl_OFFICE_NM.LabelFor = Nothing
        Me.lbl_OFFICE_NM.Location = New System.Drawing.Point(246, 5)
        Me.lbl_OFFICE_NM.Name = "lbl_OFFICE_NM"
        Me.lbl_OFFICE_NM.Size = New System.Drawing.Size(77, 22)
        Me.lbl_OFFICE_NM.TabIndex = 136
        Me.lbl_OFFICE_NM.Text = "업체명"
        Me.lbl_OFFICE_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_OFFICE_NM, "업체명")
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Combo_Panel2)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Text_Panel)
        Me.PanelControl2.Controls.Add(Me.btnApply)
        Me.PanelControl2.Controls.Add(Me.Combo_Panel)
        Me.PanelControl2.Controls.Add(Me.Apply_Type)
        Me.PanelControl2.Location = New System.Drawing.Point(6, 82)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(996, 33)
        Me.PanelControl2.TabIndex = 251
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'Combo_Panel2
        '
        Me.Combo_Panel2.Controls.Add(Me.Apply_YN)
        Me.Combo_Panel2.Location = New System.Drawing.Point(588, 4)
        Me.Combo_Panel2.Name = "Combo_Panel2"
        Me.Combo_Panel2.Size = New System.Drawing.Size(89, 27)
        Me.Combo_Panel2.TabIndex = 267
        Me.Localizer1.SetWordID(Me.Combo_Panel2, "")
        '
        'Apply_YN
        '
        Me.Apply_YN.CodeType = ""
        Me.Apply_YN.ColumnWidths = ""
        Me.Apply_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.Apply_YN.DataParams = ""
        Me.Apply_YN.DefVal = "Y"
        Me.Apply_YN.DisplayMember = "NAME"
        Me.Apply_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Apply_YN.FormattingEnabled = True
        Me.Apply_YN.IsDataStateAware = True
        Me.Apply_YN.ItemDelimiter = ","
        Me.Apply_YN.ItemTextList = "Yes,No"
        Me.Apply_YN.ItemValueList = "Y,N"
        Me.Apply_YN.KeepIntegrity = False
        Me.Apply_YN.Location = New System.Drawing.Point(3, 2)
        Me.Apply_YN.Name = "Apply_YN"
        Me.Apply_YN.NextFocus = ""
        Me.Apply_YN.NullText = ""
        Me.Apply_YN.SearchKeys = ""
        Me.Apply_YN.Size = New System.Drawing.Size(81, 22)
        Me.Apply_YN.TabIndex = 226
        Me.Apply_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.Apply_YN.ValueMember = "CODE"
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(4, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 266
        Me.Label2.Text = "일괄적용"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "일괄적용")
        '
        'Text_Panel
        '
        Me.Text_Panel.Controls.Add(Me.Apply_Text)
        Me.Text_Panel.Location = New System.Drawing.Point(430, 5)
        Me.Text_Panel.Name = "Text_Panel"
        Me.Text_Panel.Size = New System.Drawing.Size(152, 26)
        Me.Text_Panel.TabIndex = 265
        Me.Localizer1.SetWordID(Me.Text_Panel, "")
        '
        'Apply_Text
        '
        Me.Apply_Text.BorderColor = System.Drawing.Color.Silver
        Me.Apply_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Apply_Text.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Apply_Text.DefVal = ""
        Me.Apply_Text.IsDataStateAware = True
        Me.Apply_Text.Location = New System.Drawing.Point(3, 2)
        Me.Apply_Text.Name = "Apply_Text"
        Me.Apply_Text.NextFocus = ""
        Me.Apply_Text.Size = New System.Drawing.Size(146, 22)
        Me.Apply_Text.TabIndex = 136
        Me.Apply_Text.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'Combo_Panel
        '
        Me.Combo_Panel.Controls.Add(Me.Apply_Status)
        Me.Combo_Panel.Location = New System.Drawing.Point(182, 2)
        Me.Combo_Panel.Name = "Combo_Panel"
        Me.Combo_Panel.Size = New System.Drawing.Size(89, 27)
        Me.Combo_Panel.TabIndex = 262
        Me.Localizer1.SetWordID(Me.Combo_Panel, "")
        '
        'Apply_Status
        '
        Me.Apply_Status.CodeType = "YJIT.CodeService.CommonCode"
        Me.Apply_Status.ColumnWidths = ""
        Me.Apply_Status.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.Apply_Status.DataParams = "GroupCode:'R06',NameType:'A'"
        Me.Apply_Status.DefVal = ""
        Me.Apply_Status.DisplayMember = "NAME"
        Me.Apply_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Apply_Status.FormattingEnabled = True
        Me.Apply_Status.IsDataStateAware = True
        Me.Apply_Status.ItemDelimiter = ","
        Me.Apply_Status.ItemTextList = ""
        Me.Apply_Status.ItemValueList = ""
        Me.Apply_Status.KeepIntegrity = False
        Me.Apply_Status.Location = New System.Drawing.Point(3, 2)
        Me.Apply_Status.Name = "Apply_Status"
        Me.Apply_Status.NextFocus = ""
        Me.Apply_Status.NullText = "--Select--"
        Me.Apply_Status.SearchKeys = ""
        Me.Apply_Status.Size = New System.Drawing.Size(81, 22)
        Me.Apply_Status.TabIndex = 226
        Me.Apply_Status.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.Apply_Status.ValueMember = "CODE"
        '
        'Apply_Type
        '
        Me.Apply_Type.CodeType = ""
        Me.Apply_Type.ColumnWidths = ""
        Me.Apply_Type.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.Apply_Type.DataParams = ""
        Me.Apply_Type.DefVal = ""
        Me.Apply_Type.DisplayMember = "NAME"
        Me.Apply_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Apply_Type.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apply_Type.FormattingEnabled = True
        Me.Apply_Type.IsDataStateAware = True
        Me.Apply_Type.ItemDelimiter = ","
        Me.Apply_Type.ItemTextList = ""
        Me.Apply_Type.ItemValueList = ""
        Me.Apply_Type.KeepIntegrity = True
        Me.Apply_Type.Location = New System.Drawing.Point(74, 5)
        Me.Apply_Type.Name = "Apply_Type"
        Me.Apply_Type.NextFocus = ""
        Me.Apply_Type.NullText = "--Select--"
        Me.Apply_Type.SearchKeys = ""
        Me.Apply_Type.Size = New System.Drawing.Size(103, 22)
        Me.Apply_Type.TabIndex = 264
        Me.Apply_Type.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.Apply_Type.ValueMember = "CODE"
        '
        'CrmBigAprMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1008, 640)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.pal)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "CrmBigAprMgt"
        Me.Text = "엘비스빅 승인관리"
        Me.Localizer1.SetWordID(Me, "엘비스빅 승인관리")
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.pal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pal.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCRN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.Combo_Panel2.ResumeLayout(False)
        Me.Text_Panel.ResumeLayout(False)
        Me.Text_Panel.PerformLayout()
        Me.Combo_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Private WithEvents btnSearch As UI.SCControls.Button
    Friend WithEvents pal As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnApply As UI.SCControls.Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnExpFwg1 As UI.SCControls.Button
    Private WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents S_APV_YN As UI.SCControls.ComboBox
    Friend WithEvents Label1 As UI.SCControls.Label
    Friend WithEvents S_EMAIL As UI.SCControls.TextBox
    Friend WithEvents lbl_Mail As UI.SCControls.Label
    Friend WithEvents S_OFFICE_NM As UI.SCControls.TextBox
    Friend WithEvents lbl_OFFICE_NM As UI.SCControls.Label
    Private WithEvents WG1 As UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GV1_CHK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV1_EMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_HP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_OFFICE_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CRN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_APV_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_EMAIL_MSG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DB_APV_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DB_EMAIL_MSG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DB_CRM_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_OFFICE_ADDR_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_OFFICE_ADDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_OFFICE_ADDR2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_CRN As UI.SCControls.TextBox
    Friend WithEvents lbl_CRN As UI.SCControls.Label
    Private WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As UI.SCControls.Label
    Friend WithEvents Text_Panel As Panel
    Friend WithEvents Apply_Text As UI.SCControls.TextBox
    Friend WithEvents Combo_Panel As Panel
    Friend WithEvents Apply_Status As UI.SCControls.ComboBox
    Public WithEvents Apply_Type As UI.SCControls.ComboBox
    Private WithEvents btnSave As UI.SCControls.Button
    Private WithEvents btnNew As UI.SCControls.Button
    Friend WithEvents GV1_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CRM_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FOR_CRN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PSWD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL_LAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL_SCH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL_SFI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL_TER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL_TRK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COL_UNI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DB_COL_LAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DB_COL_SCH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DB_COL_SFI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DB_COL_TER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DB_COL_TRK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DB_COL_UNI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCRN As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Combo_Panel2 As Panel
    Friend WithEvents Apply_YN As UI.SCControls.ComboBox
End Class
