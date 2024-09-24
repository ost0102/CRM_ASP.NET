<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrmFriendAprMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmFriendAprMgt))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.btnPrint = New YJIT.SC.UI.SCControls.Button()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnApply = New YJIT.SC.UI.SCControls.Button()
        Me.pal = New DevExpress.XtraEditors.PanelControl()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_CHK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV1_APV_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USR_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_HP_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_LOC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_CRN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_LOC_ADDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_BIZCOND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_BIZTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CEO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.GV1_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_APV_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DB_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CRM_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_AUTH_STRT_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_AUTH_END_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_AUTH_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCodeBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit()
        Me.RepositoryItemCodeBoxEdit2 = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit()
        Me.RepositoryItemCodeBoxEdit3 = New YJIT.SC.UI.SCControls.RepositoryItemCodeBoxEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExpFwg1 = New YJIT.SC.UI.SCControls.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.S_LOC_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.S_APV_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.lbl_LOC_NM = New YJIT.SC.UI.SCControls.Label()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.S_USR_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_USR_NM = New YJIT.SC.UI.SCControls.Label()
        Me.S_USR_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_USR_ID = New YJIT.SC.UI.SCControls.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
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
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCodeBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCodeBoxEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCodeBoxEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.Text_Panel.SuspendLayout()
        Me.Combo_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnNew, "&Clear")
        Me.Localizer1.SetWordID(Me.btnPrint, "&Print")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.btnApply, "Apply")
        Me.Localizer1.SetWordID(Me.pal, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_CHK, "V")
        Me.Localizer1.SetWordID(Me.GV1_APV_YN, "승인상태")
        Me.Localizer1.SetWordID(Me.GV1_USR_ID, "ID")
        Me.Localizer1.SetWordID(Me.GV1_USR_NM, "담당자명")
        Me.Localizer1.SetWordID(Me.GV1_HP_NO, "휴대폰 번호")
        Me.Localizer1.SetWordID(Me.GV1_LOC_NM, "사업자명")
        Me.Localizer1.SetWordID(Me.GV1_CRN, "사업자등록번호")
        Me.Localizer1.SetWordID(Me.GV1_LOC_ADDR, "사업장주소")
        Me.Localizer1.SetWordID(Me.GV1_BIZCOND, "업태")
        Me.Localizer1.SetWordID(Me.GV1_BIZTYPE, "종목")
        Me.Localizer1.SetWordID(Me.GV1_CEO, "대표자명")
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "대표전화번호")
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "Insert User")
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "Insert Date")
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "Update User")
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "Update Date")
        Me.Localizer1.SetWordID(Me.GV1_DB_APV_YN, "Status Copy")
        Me.Localizer1.SetWordID(Me.GV1_DB_USR_ID, "DB Cust Code")
        Me.Localizer1.SetWordID(Me.GV1_CRM_CD, "CRM Code")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "MNGT_NO")
        Me.Localizer1.SetWordID(Me.GV1_AUTH_STRT_YMD, "AUTH_STRT_YMD")
        Me.Localizer1.SetWordID(Me.GV1_AUTH_END_YMD, "AUTH_END_YMD")
        Me.Localizer1.SetWordID(Me.GV1_AUTH_KEY, "AUTH_KEY")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel3, "")
        Me.Localizer1.SetWordID(Me.btnExpFwg1, "Button1")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.S_LOC_NM, "")
        Me.Localizer1.SetWordID(Me.S_APV_YN, "--Select--")
        Me.Localizer1.SetWordID(Me.lbl_LOC_NM, "사업자명")
        Me.Localizer1.SetWordID(Me.Label1, "승인상태")
        Me.Localizer1.SetWordID(Me.S_USR_NM, "")
        Me.Localizer1.SetWordID(Me.lbl_USR_NM, "담당자명")
        Me.Localizer1.SetWordID(Me.S_USR_ID, "")
        Me.Localizer1.SetWordID(Me.lbl_USR_ID, "아이디")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
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
        Me.palAutoButton.Controls.Add(Me.btnPrint)
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
        Me.btnNew.Location = New System.Drawing.Point(753, 2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(70, 25)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "초기화(&C)"
        Me.Localizer1.SetWordID(Me.btnNew, "&Clear")
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.ButtonType = YJIT.SC.UI.ButtonTypes.Print
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(905, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(70, 25)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "&Print"
        Me.Localizer1.SetWordID(Me.btnPrint, "")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(829, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "저장(&S)"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(677, 2)
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
        Me.pal.Location = New System.Drawing.Point(6, 82)
        Me.pal.Name = "pal"
        Me.pal.Size = New System.Drawing.Size(996, 553)
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
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemCodeBoxEdit1, Me.RepositoryItemCodeBoxEdit2, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCodeBoxEdit3, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit3})
        Me.WG1.SaveLayout = True
        Me.WG1.Size = New System.Drawing.Size(980, 516)
        Me.WG1.TabIndex = 262
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GridView14, Me.GridView15})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_CHK, Me.GV1_APV_YN, Me.GV1_USR_ID, Me.GV1_USR_NM, Me.GV1_HP_NO, Me.GV1_LOC_NM, Me.GV1_CRN, Me.GV1_LOC_ADDR, Me.GV1_BIZCOND, Me.GV1_BIZTYPE, Me.GV1_CEO, Me.GV1_TEL_NO, Me.GV1_INS_USR, Me.GV1_INS_YMD, Me.GV1_UPD_USR, Me.GV1_UPD_YMD, Me.GV1_DB_APV_YN, Me.GV1_DB_USR_ID, Me.GV1_CRM_CD, Me.GV1_MNGT_NO, Me.GV1_AUTH_STRT_YMD, Me.GV1_AUTH_END_YMD, Me.GV1_AUTH_KEY})
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
        Me.GV1_CHK.ColumnEdit = Me.RepositoryItemCheckEdit1
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
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
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
        'GV1_USR_ID
        '
        Me.GV1_USR_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_USR_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USR_ID.Caption = "ID"
        Me.GV1_USR_ID.FieldName = "USR_ID"
        Me.GV1_USR_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_USR_ID.Name = "GV1_USR_ID"
        Me.GV1_USR_ID.OptionsColumn.AllowEdit = False
        Me.GV1_USR_ID.OptionsColumn.ReadOnly = True
        Me.GV1_USR_ID.Visible = True
        Me.GV1_USR_ID.VisibleIndex = 2
        Me.Localizer1.SetWordID(Me.GV1_USR_ID, "ID")
        '
        'GV1_USR_NM
        '
        Me.GV1_USR_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_USR_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USR_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USR_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USR_NM.Caption = "담당자명"
        Me.GV1_USR_NM.FieldName = "USR_NM"
        Me.GV1_USR_NM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_USR_NM.Name = "GV1_USR_NM"
        Me.GV1_USR_NM.OptionsColumn.AllowEdit = False
        Me.GV1_USR_NM.OptionsColumn.ReadOnly = True
        Me.GV1_USR_NM.Visible = True
        Me.GV1_USR_NM.VisibleIndex = 3
        Me.GV1_USR_NM.Width = 85
        Me.Localizer1.SetWordID(Me.GV1_USR_NM, "담당자명")
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
        Me.GV1_HP_NO.VisibleIndex = 4
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
        'GV1_LOC_NM
        '
        Me.GV1_LOC_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_LOC_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_LOC_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_LOC_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_LOC_NM.Caption = "사업자명"
        Me.GV1_LOC_NM.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GV1_LOC_NM.FieldName = "LOC_NM"
        Me.GV1_LOC_NM.Name = "GV1_LOC_NM"
        Me.GV1_LOC_NM.OptionsColumn.AllowEdit = False
        Me.GV1_LOC_NM.OptionsColumn.ReadOnly = True
        Me.GV1_LOC_NM.Visible = True
        Me.GV1_LOC_NM.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GV1_LOC_NM, "사업자명")
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.MaxLength = 30
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'GV1_CRN
        '
        Me.GV1_CRN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CRN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CRN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CRN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CRN.Caption = "사업자등록번호"
        Me.GV1_CRN.FieldName = "CRN"
        Me.GV1_CRN.Name = "GV1_CRN"
        Me.GV1_CRN.OptionsColumn.AllowEdit = False
        Me.GV1_CRN.OptionsColumn.AllowFocus = False
        Me.GV1_CRN.OptionsColumn.ReadOnly = True
        Me.GV1_CRN.Visible = True
        Me.GV1_CRN.VisibleIndex = 6
        Me.GV1_CRN.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_CRN, "사업자등록번호")
        '
        'GV1_LOC_ADDR
        '
        Me.GV1_LOC_ADDR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_LOC_ADDR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_LOC_ADDR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_LOC_ADDR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_LOC_ADDR.Caption = "사업장주소"
        Me.GV1_LOC_ADDR.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GV1_LOC_ADDR.FieldName = "LOC_ADDR"
        Me.GV1_LOC_ADDR.Name = "GV1_LOC_ADDR"
        Me.GV1_LOC_ADDR.OptionsColumn.AllowEdit = False
        Me.GV1_LOC_ADDR.OptionsColumn.ReadOnly = True
        Me.GV1_LOC_ADDR.Visible = True
        Me.GV1_LOC_ADDR.VisibleIndex = 7
        Me.GV1_LOC_ADDR.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_LOC_ADDR, "사업장주소")
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.MaxLength = 50
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GV1_BIZCOND
        '
        Me.GV1_BIZCOND.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BIZCOND.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BIZCOND.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BIZCOND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BIZCOND.Caption = "업태"
        Me.GV1_BIZCOND.FieldName = "BIZCOND"
        Me.GV1_BIZCOND.Name = "GV1_BIZCOND"
        Me.GV1_BIZCOND.OptionsColumn.AllowEdit = False
        Me.GV1_BIZCOND.OptionsColumn.ReadOnly = True
        Me.GV1_BIZCOND.Visible = True
        Me.GV1_BIZCOND.VisibleIndex = 8
        Me.Localizer1.SetWordID(Me.GV1_BIZCOND, "업태")
        '
        'GV1_BIZTYPE
        '
        Me.GV1_BIZTYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BIZTYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BIZTYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BIZTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BIZTYPE.Caption = "종목"
        Me.GV1_BIZTYPE.FieldName = "BIZTYPE"
        Me.GV1_BIZTYPE.Name = "GV1_BIZTYPE"
        Me.GV1_BIZTYPE.OptionsColumn.AllowEdit = False
        Me.GV1_BIZTYPE.OptionsColumn.AllowFocus = False
        Me.GV1_BIZTYPE.OptionsColumn.ReadOnly = True
        Me.GV1_BIZTYPE.Visible = True
        Me.GV1_BIZTYPE.VisibleIndex = 9
        Me.GV1_BIZTYPE.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_BIZTYPE, "종목")
        '
        'GV1_CEO
        '
        Me.GV1_CEO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CEO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CEO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CEO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CEO.Caption = "대표자명"
        Me.GV1_CEO.FieldName = "CEO"
        Me.GV1_CEO.Name = "GV1_CEO"
        Me.GV1_CEO.OptionsColumn.AllowEdit = False
        Me.GV1_CEO.OptionsColumn.ReadOnly = True
        Me.GV1_CEO.Visible = True
        Me.GV1_CEO.VisibleIndex = 10
        Me.Localizer1.SetWordID(Me.GV1_CEO, "대표자명")
        '
        'GV1_TEL_NO
        '
        Me.GV1_TEL_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TEL_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_TEL_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TEL_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TEL_NO.Caption = "대표전화번호"
        Me.GV1_TEL_NO.FieldName = "TEL_NO"
        Me.GV1_TEL_NO.Name = "GV1_TEL_NO"
        Me.GV1_TEL_NO.OptionsColumn.AllowEdit = False
        Me.GV1_TEL_NO.OptionsColumn.ReadOnly = True
        Me.GV1_TEL_NO.Visible = True
        Me.GV1_TEL_NO.VisibleIndex = 11
        Me.GV1_TEL_NO.Width = 200
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "대표전화번호")
        '
        'GV1_INS_USR
        '
        Me.GV1_INS_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.Caption = "Insert User"
        Me.GV1_INS_USR.FieldName = "INS_USR"
        Me.GV1_INS_USR.Name = "GV1_INS_USR"
        Me.GV1_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV1_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV1_INS_USR.Visible = True
        Me.GV1_INS_USR.VisibleIndex = 12
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "Insert User")
        '
        'GV1_INS_YMD
        '
        Me.GV1_INS_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_YMD.Caption = "Insert Date"
        Me.GV1_INS_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV1_INS_YMD.FieldName = "INS_YMD"
        Me.GV1_INS_YMD.Name = "GV1_INS_YMD"
        Me.GV1_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_INS_YMD.Visible = True
        Me.GV1_INS_YMD.VisibleIndex = 13
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "Insert Date")
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
        'GV1_UPD_USR
        '
        Me.GV1_UPD_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_UPD_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPD_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_USR.Caption = "Update User"
        Me.GV1_UPD_USR.FieldName = "UPD_USR"
        Me.GV1_UPD_USR.Name = "GV1_UPD_USR"
        Me.GV1_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_USR.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_USR.Visible = True
        Me.GV1_UPD_USR.VisibleIndex = 14
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "Update User")
        '
        'GV1_UPD_YMD
        '
        Me.GV1_UPD_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_UPD_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPD_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_YMD.Caption = "Update Date"
        Me.GV1_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV1_UPD_YMD.Name = "GV1_UPD_YMD"
        Me.GV1_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_YMD.Visible = True
        Me.GV1_UPD_YMD.VisibleIndex = 15
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "Update Date")
        '
        'GV1_DB_APV_YN
        '
        Me.GV1_DB_APV_YN.Caption = "DB Status"
        Me.GV1_DB_APV_YN.FieldName = "DB_APV_YN"
        Me.GV1_DB_APV_YN.Name = "GV1_DB_APV_YN"
        Me.GV1_DB_APV_YN.OptionsColumn.AllowEdit = False
        Me.GV1_DB_APV_YN.OptionsColumn.AllowMove = False
        Me.GV1_DB_APV_YN.OptionsColumn.ReadOnly = True
        Me.GV1_DB_APV_YN.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_APV_YN, "Status Copy")
        '
        'GV1_DB_USR_ID
        '
        Me.GV1_DB_USR_ID.Caption = "DB User Id"
        Me.GV1_DB_USR_ID.FieldName = "DB_USR_ID"
        Me.GV1_DB_USR_ID.Name = "GV1_DB_USR_ID"
        Me.GV1_DB_USR_ID.OptionsColumn.AllowMove = False
        Me.GV1_DB_USR_ID.OptionsColumn.AllowShowHide = False
        Me.GV1_DB_USR_ID.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_DB_USR_ID, "DB Cust Code")
        '
        'GV1_CRM_CD
        '
        Me.GV1_CRM_CD.Caption = "CRM Code"
        Me.GV1_CRM_CD.FieldName = "CRM_CD"
        Me.GV1_CRM_CD.Name = "GV1_CRM_CD"
        Me.GV1_CRM_CD.OptionsColumn.AllowEdit = False
        Me.GV1_CRM_CD.OptionsColumn.ReadOnly = True
        Me.GV1_CRM_CD.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_CRM_CD, "")
        '
        'GV1_MNGT_NO
        '
        Me.GV1_MNGT_NO.Caption = "MNGT_NO"
        Me.GV1_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV1_MNGT_NO.Name = "GV1_MNGT_NO"
        Me.GV1_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV1_MNGT_NO.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "")
        '
        'GV1_AUTH_STRT_YMD
        '
        Me.GV1_AUTH_STRT_YMD.Caption = "AUTH_STRT_YMD"
        Me.GV1_AUTH_STRT_YMD.FieldName = "AUTH_STRT_YMD"
        Me.GV1_AUTH_STRT_YMD.Name = "GV1_AUTH_STRT_YMD"
        Me.GV1_AUTH_STRT_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_AUTH_STRT_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_AUTH_STRT_YMD.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_AUTH_STRT_YMD, "")
        '
        'GV1_AUTH_END_YMD
        '
        Me.GV1_AUTH_END_YMD.Caption = "AUTH_END_YMD"
        Me.GV1_AUTH_END_YMD.FieldName = "AUTH_END_YMD"
        Me.GV1_AUTH_END_YMD.Name = "GV1_AUTH_END_YMD"
        Me.GV1_AUTH_END_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_AUTH_END_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_AUTH_END_YMD.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_AUTH_END_YMD, "")
        '
        'GV1_AUTH_KEY
        '
        Me.GV1_AUTH_KEY.Caption = "AUTH_KEY"
        Me.GV1_AUTH_KEY.FieldName = "AUTH_KEY"
        Me.GV1_AUTH_KEY.Name = "GV1_AUTH_KEY"
        Me.GV1_AUTH_KEY.OptionsColumn.AllowEdit = False
        Me.GV1_AUTH_KEY.OptionsColumn.ReadOnly = True
        Me.GV1_AUTH_KEY.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV1_AUTH_KEY, "")
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.MaxLength = 200
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCodeBoxEdit1
        '
        Me.RepositoryItemCodeBoxEdit1.AlwaysSetDisplayParams = True
        Me.RepositoryItemCodeBoxEdit1.AutoHeight = False
        Me.RepositoryItemCodeBoxEdit1.AutoSuggestion = True
        Me.RepositoryItemCodeBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemCodeBoxEdit1.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.RepositoryItemCodeBoxEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemCodeBoxEdit1.CodeType = "YJIT.CodeService.Customer"
        Me.RepositoryItemCodeBoxEdit1.DataParams = "Type:''"
        Me.RepositoryItemCodeBoxEdit1.DisplayParams = "Code:#CUST_CD,CUST_LOCNM:#CUST_NM,CRN:#CRN"
        Me.RepositoryItemCodeBoxEdit1.EditPopup = ""
        Me.RepositoryItemCodeBoxEdit1.KeepIntegrity = True
        Me.RepositoryItemCodeBoxEdit1.Name = "RepositoryItemCodeBoxEdit1"
        Me.RepositoryItemCodeBoxEdit1.NextFocus = Nothing
        Me.RepositoryItemCodeBoxEdit1.SearchPopup = "CodeMaster"
        Me.RepositoryItemCodeBoxEdit1.SuppressValidateCode = False
        Me.RepositoryItemCodeBoxEdit1.SuppressValidateFailedPopup = True
        Me.RepositoryItemCodeBoxEdit1.ValidatedCodes = CType(resources.GetObject("RepositoryItemCodeBoxEdit1.ValidatedCodes"), System.Collections.ArrayList)
        Me.RepositoryItemCodeBoxEdit1.ValidateKeys = "KEY:#CUST_CD"
        Me.RepositoryItemCodeBoxEdit1.ValidateOnEnterKey = True
        '
        'RepositoryItemCodeBoxEdit2
        '
        Me.RepositoryItemCodeBoxEdit2.AlwaysSetDisplayParams = False
        Me.RepositoryItemCodeBoxEdit2.AutoHeight = False
        Me.RepositoryItemCodeBoxEdit2.AutoSuggestion = True
        Me.RepositoryItemCodeBoxEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemCodeBoxEdit2.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, True)})
        Me.RepositoryItemCodeBoxEdit2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemCodeBoxEdit2.CodeType = "YJIT.CodeService.Office"
        Me.RepositoryItemCodeBoxEdit2.DataParams = "Type:'LB'"
        Me.RepositoryItemCodeBoxEdit2.DisplayParams = "Code:#DEF_OFFICE_CD,Name:#DEF_OFFICE_NM"
        Me.RepositoryItemCodeBoxEdit2.EditPopup = ""
        Me.RepositoryItemCodeBoxEdit2.KeepIntegrity = True
        Me.RepositoryItemCodeBoxEdit2.Name = "RepositoryItemCodeBoxEdit2"
        Me.RepositoryItemCodeBoxEdit2.NextFocus = Nothing
        Me.RepositoryItemCodeBoxEdit2.SearchPopup = "CodeMaster"
        Me.RepositoryItemCodeBoxEdit2.SuppressValidateCode = False
        Me.RepositoryItemCodeBoxEdit2.SuppressValidateFailedPopup = False
        Me.RepositoryItemCodeBoxEdit2.ValidatedCodes = CType(resources.GetObject("RepositoryItemCodeBoxEdit2.ValidatedCodes"), System.Collections.ArrayList)
        Me.RepositoryItemCodeBoxEdit2.ValidateKeys = "KEY:#DEF_OFFICE_CD"
        '
        'RepositoryItemCodeBoxEdit3
        '
        Me.RepositoryItemCodeBoxEdit3.AlwaysSetDisplayParams = True
        Me.RepositoryItemCodeBoxEdit3.AutoHeight = False
        Me.RepositoryItemCodeBoxEdit3.AutoSuggestion = True
        Me.RepositoryItemCodeBoxEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemCodeBoxEdit3.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, True)})
        Me.RepositoryItemCodeBoxEdit3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemCodeBoxEdit3.CodeType = "YJIT.CodeService.Customer"
        Me.RepositoryItemCodeBoxEdit3.DataParams = "Type:''"
        Me.RepositoryItemCodeBoxEdit3.DisplayParams = "Code:#CUST_CD,CUST_LOCNM:#CUST_NM,CRN:#CRN"
        Me.RepositoryItemCodeBoxEdit3.EditPopup = ""
        Me.RepositoryItemCodeBoxEdit3.KeepIntegrity = True
        Me.RepositoryItemCodeBoxEdit3.Name = "RepositoryItemCodeBoxEdit3"
        Me.RepositoryItemCodeBoxEdit3.NextFocus = Nothing
        Me.RepositoryItemCodeBoxEdit3.SearchPopup = "CodeMaster"
        Me.RepositoryItemCodeBoxEdit3.SuppressValidateCode = False
        Me.RepositoryItemCodeBoxEdit3.SuppressValidateFailedPopup = False
        Me.RepositoryItemCodeBoxEdit3.ValidatedCodes = CType(resources.GetObject("RepositoryItemCodeBoxEdit3.ValidatedCodes"), System.Collections.ArrayList)
        Me.RepositoryItemCodeBoxEdit3.ValidateKeys = "KEY:#CUST_CD"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 30
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.EditFormat.FormatString = "###-####-####"
        Me.RepositoryItemTextEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.EditMask = "(\(\d\d\d\))?\d{1,3}-\d\d\d\d-\d\d\d\d"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.MaxLength = 50
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
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
        Me.PanelControl1.Controls.Add(Me.S_LOC_NM)
        Me.PanelControl1.Controls.Add(Me.S_APV_YN)
        Me.PanelControl1.Controls.Add(Me.lbl_LOC_NM)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.S_USR_NM)
        Me.PanelControl1.Controls.Add(Me.lbl_USR_NM)
        Me.PanelControl1.Controls.Add(Me.S_USR_ID)
        Me.PanelControl1.Controls.Add(Me.lbl_USR_ID)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 43)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(996, 33)
        Me.PanelControl1.TabIndex = 250
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'S_LOC_NM
        '
        Me.S_LOC_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_LOC_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_LOC_NM.DefVal = ""
        Me.S_LOC_NM.IsDataStateAware = True
        Me.S_LOC_NM.Location = New System.Drawing.Point(810, 5)
        Me.S_LOC_NM.Name = "S_LOC_NM"
        Me.S_LOC_NM.NextFocus = "btnSearch"
        Me.S_LOC_NM.Size = New System.Drawing.Size(165, 22)
        Me.S_LOC_NM.TabIndex = 227
        Me.S_LOC_NM.TextCasing = YJIT.SC.UI.TextCasings.Normal
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
        Me.S_APV_YN.NextFocus = "S_USER_ID"
        Me.S_APV_YN.NullText = "--Select--"
        Me.S_APV_YN.SearchKeys = ""
        Me.S_APV_YN.Size = New System.Drawing.Size(103, 22)
        Me.S_APV_YN.TabIndex = 225
        Me.S_APV_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_APV_YN.ValueMember = "CODE"
        '
        'lbl_LOC_NM
        '
        Me.lbl_LOC_NM.AutoEllipsis = True
        Me.lbl_LOC_NM.LabelFor = Nothing
        Me.lbl_LOC_NM.Location = New System.Drawing.Point(727, 5)
        Me.lbl_LOC_NM.Name = "lbl_LOC_NM"
        Me.lbl_LOC_NM.Size = New System.Drawing.Size(77, 22)
        Me.lbl_LOC_NM.TabIndex = 226
        Me.lbl_LOC_NM.Text = "사업자명"
        Me.lbl_LOC_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_LOC_NM, "사업자명")
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
        'S_USR_NM
        '
        Me.S_USR_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_USR_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_USR_NM.DefVal = ""
        Me.S_USR_NM.IsDataStateAware = True
        Me.S_USR_NM.Location = New System.Drawing.Point(556, 5)
        Me.S_USR_NM.Name = "S_USR_NM"
        Me.S_USR_NM.NextFocus = "S_LOC_NM"
        Me.S_USR_NM.Size = New System.Drawing.Size(165, 22)
        Me.S_USR_NM.TabIndex = 139
        Me.S_USR_NM.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'lbl_USR_NM
        '
        Me.lbl_USR_NM.AutoEllipsis = True
        Me.lbl_USR_NM.LabelFor = Nothing
        Me.lbl_USR_NM.Location = New System.Drawing.Point(462, 5)
        Me.lbl_USR_NM.Name = "lbl_USR_NM"
        Me.lbl_USR_NM.Size = New System.Drawing.Size(84, 22)
        Me.lbl_USR_NM.TabIndex = 138
        Me.lbl_USR_NM.Text = "담당자명"
        Me.lbl_USR_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_USR_NM, "담당자명")
        '
        'S_USR_ID
        '
        Me.S_USR_ID.BorderColor = System.Drawing.Color.Silver
        Me.S_USR_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_USR_ID.DefVal = ""
        Me.S_USR_ID.IsDataStateAware = True
        Me.S_USR_ID.Location = New System.Drawing.Point(291, 5)
        Me.S_USR_ID.Name = "S_USR_ID"
        Me.S_USR_ID.NextFocus = "S_USR_NM"
        Me.S_USR_ID.Size = New System.Drawing.Size(165, 22)
        Me.S_USR_ID.TabIndex = 137
        Me.S_USR_ID.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'lbl_USR_ID
        '
        Me.lbl_USR_ID.AutoEllipsis = True
        Me.lbl_USR_ID.LabelFor = Nothing
        Me.lbl_USR_ID.Location = New System.Drawing.Point(208, 5)
        Me.lbl_USR_ID.Name = "lbl_USR_ID"
        Me.lbl_USR_ID.Size = New System.Drawing.Size(77, 22)
        Me.lbl_USR_ID.TabIndex = 136
        Me.lbl_USR_ID.Text = "아이디"
        Me.lbl_USR_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_USR_ID, "아이디")
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.btnApply)
        Me.PanelControl2.Controls.Add(Me.Text_Panel)
        Me.PanelControl2.Controls.Add(Me.Combo_Panel)
        Me.PanelControl2.Controls.Add(Me.Apply_Type)
        Me.PanelControl2.Location = New System.Drawing.Point(6, 82)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(996, 33)
        Me.PanelControl2.TabIndex = 251
        Me.PanelControl2.Visible = False
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
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
        Me.Text_Panel.Location = New System.Drawing.Point(183, 7)
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
        Me.Apply_Text.NextFocus = "btnApply"
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
        Me.Apply_Status.NextFocus = "S_USER_NM"
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
        Me.Apply_Type.NextFocus = "REQ_SVC2"
        Me.Apply_Type.NullText = "--Select--"
        Me.Apply_Type.SearchKeys = ""
        Me.Apply_Type.Size = New System.Drawing.Size(103, 22)
        Me.Apply_Type.TabIndex = 264
        Me.Apply_Type.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.Apply_Type.ValueMember = "CODE"
        '
        'CrmFriendAprMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1008, 640)
        Me.Controls.Add(Me.pal)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "CrmFriendAprMgt"
        Me.Text = "ELVIS-META 회원 승인관리"
        Me.Localizer1.SetWordID(Me, "FRIEND 회원 승인관리")
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.pal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pal.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCodeBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCodeBoxEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCodeBoxEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
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
    Friend WithEvents S_USR_NM As UI.SCControls.TextBox
    Friend WithEvents lbl_USR_NM As UI.SCControls.Label
    Friend WithEvents S_USR_ID As UI.SCControls.TextBox
    Friend WithEvents lbl_USR_ID As UI.SCControls.Label
    Private WithEvents WG1 As UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents GV1_CHK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV1_LOC_ADDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_LOC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_HP_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCodeBoxEdit3 As UI.SCControls.RepositoryItemCodeBoxEdit
    Friend WithEvents GV1_BIZTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CRN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCodeBoxEdit2 As UI.SCControls.RepositoryItemCodeBoxEdit
    Friend WithEvents GV1_APV_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateBoxEdit1 As UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents GV1_DB_APV_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DB_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CRM_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemCodeBoxEdit1 As UI.SCControls.RepositoryItemCodeBoxEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CEO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents S_LOC_NM As UI.SCControls.TextBox
    Friend WithEvents lbl_LOC_NM As UI.SCControls.Label
    Private WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As UI.SCControls.Label
    Friend WithEvents Text_Panel As Panel
    Friend WithEvents Apply_Text As UI.SCControls.TextBox
    Friend WithEvents Combo_Panel As Panel
    Friend WithEvents Apply_Status As UI.SCControls.ComboBox
    Public WithEvents Apply_Type As UI.SCControls.ComboBox
    Private WithEvents btnSave As UI.SCControls.Button
    Private WithEvents btnNew As UI.SCControls.Button
    Friend WithEvents GV1_USR_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BIZCOND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents btnPrint As UI.SCControls.Button
    Friend WithEvents GV1_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_AUTH_STRT_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_AUTH_END_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_AUTH_KEY As DevExpress.XtraGrid.Columns.GridColumn
End Class
