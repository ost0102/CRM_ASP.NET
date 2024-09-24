<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmAsMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmAsMgt))
        Me.RepositoryItemDateBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SEARCH_KEY = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.NEW_POPUP_INPUT = New YJIT.SC.UI.SCControls.CheckBox()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.CUST_CD = New YJIT.SC.UI.SCControls.TextBox()
        Me.POPUP_INPUT = New YJIT.SC.UI.SCControls.CheckBox()
        Me.Label32 = New YJIT.SC.UI.SCControls.Label()
        Me.TO_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.FM_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.lbl_FM_YMD = New YJIT.SC.UI.SCControls.Label()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_HM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_SVC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CONTENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WORK_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PRIORITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PRAR_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CMPT_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CMPT_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SVC_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MATN_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SALES_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FREE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FILE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV1_SYS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_TYPE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEV_CMPT_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEV_CMPT_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RETURN_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_SVC2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit2 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.S_DEPT_AUTH_LIST = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.S_DEPT_CD = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Label29 = New YJIT.SC.UI.SCControls.Label()
        Me.Label26 = New YJIT.SC.UI.SCControls.Label()
        Me.S_PRIORITY = New YJIT.SC.UI.SCControls.CheckBox()
        Me.S_SVC_CD = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Label37 = New YJIT.SC.UI.SCControls.Label()
        Me.S_WORK_USR = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.S_PROC_TYPE = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.REF_TIME = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label5 = New YJIT.SC.UI.SCControls.Label()
        Me.S_ROW_BEST = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.WG7 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV7_PROC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV7_PROC_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV7_CheckBox = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV7_DateType = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WG6 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV6_WORK_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV6_PROC_TYPE_7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV6_PROC_TYPE_0 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.iconImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.NEW_POPUP_INPUT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POPUP_INPUT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.S_DEPT_AUTH_LIST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S_DEPT_CD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S_PRIORITY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S_SVC_CD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S_PROC_TYPE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.WG7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7_CheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7_DateType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'SEARCH_KEY
        '
        Me.SEARCH_KEY.BorderColor = System.Drawing.Color.Silver
        Me.SEARCH_KEY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SEARCH_KEY.DefVal = ""
        Me.SEARCH_KEY.IsDataStateAware = True
        Me.SEARCH_KEY.Location = New System.Drawing.Point(71, 27)
        Me.SEARCH_KEY.Name = "SEARCH_KEY"
        Me.SEARCH_KEY.NextFocus = "S_ROW_BEST"
        Me.SEARCH_KEY.RequiredFor = ""
        Me.SEARCH_KEY.Size = New System.Drawing.Size(198, 22)
        Me.SEARCH_KEY.TabIndex = 1
        Me.SEARCH_KEY.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label1
        '
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(1, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Key"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "Search Key")
        '
        'btnSearch
        '
        Me.btnSearch.Action = "SearchData"
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(626, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(64, 25)
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
        Me.palAutoButton.Controls.Add(Me.NEW_POPUP_INPUT)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Controls.Add(Me.CUST_CD)
        Me.palAutoButton.Controls.Add(Me.POPUP_INPUT)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 7)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(771, 32)
        Me.palAutoButton.TabIndex = 2
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'NEW_POPUP_INPUT
        '
        Me.NEW_POPUP_INPUT.BindingPropertyName = "YesNo"
        Me.NEW_POPUP_INPUT.DefVal = False
        Me.NEW_POPUP_INPUT.EditValue = True
        Me.NEW_POPUP_INPUT.IsDataStateAware = False
        Me.NEW_POPUP_INPUT.Location = New System.Drawing.Point(508, 5)
        Me.NEW_POPUP_INPUT.Name = "NEW_POPUP_INPUT"
        Me.NEW_POPUP_INPUT.NextFocus = ""
        Me.NEW_POPUP_INPUT.Properties.Caption = "Test PopUp 등록"
        Me.NEW_POPUP_INPUT.RequiredFor = ""
        Me.NEW_POPUP_INPUT.Size = New System.Drawing.Size(131, 19)
        Me.NEW_POPUP_INPUT.TabIndex = 240
        Me.NEW_POPUP_INPUT.Visible = False
        Me.Localizer1.SetWordID(Me.NEW_POPUP_INPUT, "Test PopUp 등록")
        Me.NEW_POPUP_INPUT.YesNo = "Y"
        '
        'btnSave
        '
        Me.btnSave.Action = "SaveData"
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(696, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'CUST_CD
        '
        Me.CUST_CD.BorderColor = System.Drawing.Color.Empty
        Me.CUST_CD.DefVal = ""
        Me.CUST_CD.IsDataStateAware = True
        Me.CUST_CD.Location = New System.Drawing.Point(367, 5)
        Me.CUST_CD.Name = "CUST_CD"
        Me.CUST_CD.NextFocus = Nothing
        Me.CUST_CD.RequiredFor = ""
        Me.CUST_CD.Size = New System.Drawing.Size(41, 22)
        Me.CUST_CD.TabIndex = 7
        Me.CUST_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.CUST_CD.Visible = False
        '
        'POPUP_INPUT
        '
        Me.POPUP_INPUT.BindingPropertyName = "YesNo"
        Me.POPUP_INPUT.DefVal = False
        Me.POPUP_INPUT.EditValue = True
        Me.POPUP_INPUT.IsDataStateAware = True
        Me.POPUP_INPUT.Location = New System.Drawing.Point(414, 5)
        Me.POPUP_INPUT.Name = "POPUP_INPUT"
        Me.POPUP_INPUT.NextFocus = "PRT_OPT4"
        Me.POPUP_INPUT.Properties.Caption = "PopUp 등록"
        Me.POPUP_INPUT.RequiredFor = ""
        Me.POPUP_INPUT.Size = New System.Drawing.Size(88, 19)
        Me.POPUP_INPUT.TabIndex = 239
        Me.POPUP_INPUT.Visible = False
        Me.Localizer1.SetWordID(Me.POPUP_INPUT, "PopUp 등록")
        Me.POPUP_INPUT.YesNo = "Y"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.LabelFor = Nothing
        Me.Label32.Location = New System.Drawing.Point(162, 4)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 14)
        Me.Label32.TabIndex = 59
        Me.Label32.Text = "~"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Localizer1.SetWordID(Me.Label32, "~")
        '
        'TO_YMD
        '
        Me.TO_YMD.BorderColor = System.Drawing.Color.Silver
        Me.TO_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TO_YMD.DefVal = ""
        Me.TO_YMD.IconVisible = True
        Me.TO_YMD.IsDataStateAware = True
        Me.TO_YMD.Location = New System.Drawing.Point(178, 4)
        Me.TO_YMD.Name = "TO_YMD"
        Me.TO_YMD.NextFocus = "SEARCH_KEY"
        Me.TO_YMD.RequiredFor = ""
        Me.TO_YMD.Size = New System.Drawing.Size(91, 22)
        Me.TO_YMD.TabIndex = 58
        Me.Localizer1.SetWordID(Me.TO_YMD, "")
        '
        'FM_YMD
        '
        Me.FM_YMD.BorderColor = System.Drawing.Color.Silver
        Me.FM_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FM_YMD.DefVal = ""
        Me.FM_YMD.IconVisible = True
        Me.FM_YMD.IsDataStateAware = True
        Me.FM_YMD.Location = New System.Drawing.Point(71, 4)
        Me.FM_YMD.Name = "FM_YMD"
        Me.FM_YMD.NextFocus = "TO_YMD"
        Me.FM_YMD.RequiredFor = ""
        Me.FM_YMD.Size = New System.Drawing.Size(91, 22)
        Me.FM_YMD.TabIndex = 57
        Me.Localizer1.SetWordID(Me.FM_YMD, "")
        '
        'lbl_FM_YMD
        '
        Me.lbl_FM_YMD.LabelFor = Nothing
        Me.lbl_FM_YMD.Location = New System.Drawing.Point(14, 7)
        Me.lbl_FM_YMD.Name = "lbl_FM_YMD"
        Me.lbl_FM_YMD.Size = New System.Drawing.Size(55, 14)
        Me.lbl_FM_YMD.TabIndex = 8
        Me.lbl_FM_YMD.Text = "등록일자"
        Me.lbl_FM_YMD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_FM_YMD, "등록일자")
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
        Me.WG1.Location = New System.Drawing.Point(6, 118)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit2, Me.RepositoryItemCheckEdit1})
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = True
        Me.WG1.Size = New System.Drawing.Size(1421, 556)
        Me.WG1.TabIndex = 6
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.BestFitMaxRowCount = 10
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_MNGT_NO, Me.GV1_REQ_YMD, Me.GV1_REQ_HM, Me.GV1_REQ_SVC, Me.GV1_CUST_CD, Me.GV1_CUST_NM, Me.GV1_CONTENT, Me.GV1_REQ_USR, Me.GV1_TEL_NO, Me.GV1_REQ_TYPE, Me.GV1_PROC_TYPE, Me.GV1_WORK_USR, Me.GV1_PRIORITY, Me.GV1_PRAR_YMD, Me.GV1_CMPT_YMD, Me.GV1_INS_USR, Me.GV1_RMK, Me.GV1_CMPT_RMK, Me.GV1_USE_YN, Me.GV1_SVC_CD, Me.GV1_MATN_YN, Me.GV1_SALES_NM, Me.GV1_FREE_YN, Me.GV1_FILE_YN, Me.GV1_SYS_ID, Me.GV1_REQ_TYPE2, Me.GV1_DEV_CMPT_YN, Me.GV1_DEV_CMPT_YMD, Me.GV1_RETURN_YN, Me.GV1_REQ_SVC2})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsCustomization.AllowRowSizing = True
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.RowHeight = 10
        Me.GV1.ViewCaption = " 고객 리스트"
        '
        'GV1_MNGT_NO
        '
        Me.GV1_MNGT_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.Caption = "관리번호"
        Me.GV1_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV1_MNGT_NO.Name = "GV1_MNGT_NO"
        Me.GV1_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV1_MNGT_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_MNGT_NO.Width = 85
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        '
        'GV1_REQ_YMD
        '
        Me.GV1_REQ_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_YMD.Caption = "요청일자"
        Me.GV1_REQ_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV1_REQ_YMD.FieldName = "REQ_YMD"
        Me.GV1_REQ_YMD.Name = "GV1_REQ_YMD"
        Me.GV1_REQ_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_REQ_YMD.Width = 73
        Me.Localizer1.SetWordID(Me.GV1_REQ_YMD, "요청일자")
        '
        'GV1_REQ_HM
        '
        Me.GV1_REQ_HM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_HM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_HM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_HM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_HM.Caption = "요청시간"
        Me.GV1_REQ_HM.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GV1_REQ_HM.FieldName = "REQ_HM"
        Me.GV1_REQ_HM.Name = "GV1_REQ_HM"
        Me.GV1_REQ_HM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_REQ_HM.Width = 42
        Me.Localizer1.SetWordID(Me.GV1_REQ_HM, "요청시간")
        '
        'GV1_REQ_SVC
        '
        Me.GV1_REQ_SVC.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_SVC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_SVC.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_SVC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_SVC.Caption = "업무"
        Me.GV1_REQ_SVC.FieldName = "REQ_SVC"
        Me.GV1_REQ_SVC.Name = "GV1_REQ_SVC"
        Me.GV1_REQ_SVC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_REQ_SVC.Width = 57
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "업무")
        '
        'GV1_CUST_CD
        '
        Me.GV1_CUST_CD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_CUST_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_CUST_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.Caption = "코드"
        Me.GV1_CUST_CD.FieldName = "CUST_CD"
        Me.GV1_CUST_CD.Name = "GV1_CUST_CD"
        Me.GV1_CUST_CD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CUST_CD.Width = 57
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "코드")
        '
        'GV1_CUST_NM
        '
        Me.GV1_CUST_NM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_CUST_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_CUST_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_NM.Caption = "거래처 명"
        Me.GV1_CUST_NM.FieldName = "CUST_NM"
        Me.GV1_CUST_NM.Name = "GV1_CUST_NM"
        Me.GV1_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_NM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV1_CUST_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CUST_NM.Width = 85
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "거래처 명")
        '
        'GV1_CONTENT
        '
        Me.GV1_CONTENT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CONTENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CONTENT.Caption = "내용"
        Me.GV1_CONTENT.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GV1_CONTENT.FieldName = "CONTENT"
        Me.GV1_CONTENT.Name = "GV1_CONTENT"
        Me.GV1_CONTENT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CONTENT.Width = 238
        Me.Localizer1.SetWordID(Me.GV1_CONTENT, "내용")
        '
        'GV1_REQ_USR
        '
        Me.GV1_REQ_USR.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_REQ_USR.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_USR.Caption = "요청자"
        Me.GV1_REQ_USR.FieldName = "REQ_USR"
        Me.GV1_REQ_USR.Name = "GV1_REQ_USR"
        Me.GV1_REQ_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_REQ_USR.Width = 52
        Me.Localizer1.SetWordID(Me.GV1_REQ_USR, "요청자")
        '
        'GV1_TEL_NO
        '
        Me.GV1_TEL_NO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_TEL_NO.AppearanceCell.Options.UseFont = True
        Me.GV1_TEL_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TEL_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TEL_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TEL_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TEL_NO.Caption = "연락처"
        Me.GV1_TEL_NO.FieldName = "TEL_NO"
        Me.GV1_TEL_NO.Name = "GV1_TEL_NO"
        Me.GV1_TEL_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_TEL_NO.Width = 76
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "연락처")
        '
        'GV1_REQ_TYPE
        '
        Me.GV1_REQ_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_TYPE.Caption = "요청사항 구분"
        Me.GV1_REQ_TYPE.FieldName = "REQ_TYPE"
        Me.GV1_REQ_TYPE.Name = "GV1_REQ_TYPE"
        Me.GV1_REQ_TYPE.Width = 77
        Me.Localizer1.SetWordID(Me.GV1_REQ_TYPE, "요청사항 구분")
        '
        'GV1_PROC_TYPE
        '
        Me.GV1_PROC_TYPE.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_PROC_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_PROC_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PROC_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROC_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PROC_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROC_TYPE.Caption = "처리내용"
        Me.GV1_PROC_TYPE.FieldName = "PROC_TYPE"
        Me.GV1_PROC_TYPE.Name = "GV1_PROC_TYPE"
        Me.GV1_PROC_TYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PROC_TYPE.Width = 71
        Me.Localizer1.SetWordID(Me.GV1_PROC_TYPE, "처리내용")
        '
        'GV1_WORK_USR
        '
        Me.GV1_WORK_USR.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV1_WORK_USR.AppearanceCell.Options.UseFont = True
        Me.GV1_WORK_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_WORK_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_WORK_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_WORK_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_WORK_USR.Caption = "작업자"
        Me.GV1_WORK_USR.FieldName = "WORK_USR"
        Me.GV1_WORK_USR.Name = "GV1_WORK_USR"
        Me.GV1_WORK_USR.OptionsColumn.AllowEdit = False
        Me.GV1_WORK_USR.OptionsColumn.ReadOnly = True
        Me.GV1_WORK_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_WORK_USR.Width = 104
        Me.Localizer1.SetWordID(Me.GV1_WORK_USR, "작업자")
        '
        'GV1_PRIORITY
        '
        Me.GV1_PRIORITY.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PRIORITY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRIORITY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PRIORITY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRIORITY.Caption = "우선순위"
        Me.GV1_PRIORITY.FieldName = "PRIORITY"
        Me.GV1_PRIORITY.Name = "GV1_PRIORITY"
        Me.GV1_PRIORITY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PRIORITY.Width = 59
        Me.Localizer1.SetWordID(Me.GV1_PRIORITY, "우선순위")
        '
        'GV1_PRAR_YMD
        '
        Me.GV1_PRAR_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PRAR_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRAR_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PRAR_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRAR_YMD.Caption = "예정일자"
        Me.GV1_PRAR_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV1_PRAR_YMD.FieldName = "PRAR_YMD"
        Me.GV1_PRAR_YMD.Name = "GV1_PRAR_YMD"
        Me.GV1_PRAR_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PRAR_YMD.Width = 73
        Me.Localizer1.SetWordID(Me.GV1_PRAR_YMD, "예정일자")
        '
        'GV1_CMPT_YMD
        '
        Me.GV1_CMPT_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CMPT_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CMPT_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CMPT_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CMPT_YMD.Caption = "완료일자"
        Me.GV1_CMPT_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV1_CMPT_YMD.FieldName = "CMPT_YMD"
        Me.GV1_CMPT_YMD.Name = "GV1_CMPT_YMD"
        Me.GV1_CMPT_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_CMPT_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_CMPT_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CMPT_YMD.Width = 71
        Me.Localizer1.SetWordID(Me.GV1_CMPT_YMD, "완료일자")
        '
        'GV1_INS_USR
        '
        Me.GV1_INS_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.Caption = "등록자"
        Me.GV1_INS_USR.FieldName = "INS_USR"
        Me.GV1_INS_USR.Name = "GV1_INS_USR"
        Me.GV1_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV1_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV1_INS_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_INS_USR.Width = 61
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "등록자")
        '
        'GV1_RMK
        '
        Me.GV1_RMK.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RMK.Caption = "비고"
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_RMK.Width = 142
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        '
        'GV1_CMPT_RMK
        '
        Me.GV1_CMPT_RMK.Caption = "답변"
        Me.GV1_CMPT_RMK.FieldName = "CMPT_RMK"
        Me.GV1_CMPT_RMK.Name = "GV1_CMPT_RMK"
        Me.GV1_CMPT_RMK.Width = 78
        Me.Localizer1.SetWordID(Me.GV1_CMPT_RMK, "답변")
        '
        'GV1_USE_YN
        '
        Me.GV1_USE_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_USE_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USE_YN.Caption = "사용여부"
        Me.GV1_USE_YN.FieldName = "USE_YN"
        Me.GV1_USE_YN.Name = "GV1_USE_YN"
        Me.GV1_USE_YN.Width = 48
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "사용여부")
        '
        'GV1_SVC_CD
        '
        Me.GV1_SVC_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SVC_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SVC_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SVC_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SVC_CD.Caption = "시스템"
        Me.GV1_SVC_CD.FieldName = "SVC_CD"
        Me.GV1_SVC_CD.Name = "GV1_SVC_CD"
        Me.GV1_SVC_CD.Width = 46
        Me.Localizer1.SetWordID(Me.GV1_SVC_CD, "시스템")
        '
        'GV1_MATN_YN
        '
        Me.GV1_MATN_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_MATN_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MATN_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MATN_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MATN_YN.Caption = "유지보수"
        Me.GV1_MATN_YN.FieldName = "MATN_YN"
        Me.GV1_MATN_YN.Name = "GV1_MATN_YN"
        Me.GV1_MATN_YN.Width = 47
        Me.Localizer1.SetWordID(Me.GV1_MATN_YN, "유지보수")
        '
        'GV1_SALES_NM
        '
        Me.GV1_SALES_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SALES_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SALES_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SALES_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SALES_NM.Caption = "영업담당"
        Me.GV1_SALES_NM.FieldName = "SALES_NM"
        Me.GV1_SALES_NM.Name = "GV1_SALES_NM"
        Me.GV1_SALES_NM.Width = 54
        Me.Localizer1.SetWordID(Me.GV1_SALES_NM, "영업담당")
        '
        'GV1_FREE_YN
        '
        Me.GV1_FREE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FREE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FREE_YN.Caption = "유상/무상"
        Me.GV1_FREE_YN.FieldName = "FREE_YN"
        Me.GV1_FREE_YN.Name = "GV1_FREE_YN"
        Me.GV1_FREE_YN.Width = 63
        Me.Localizer1.SetWordID(Me.GV1_FREE_YN, "유상/무상")
        '
        'GV1_FILE_YN
        '
        Me.GV1_FILE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FILE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FILE_YN.Caption = "Document"
        Me.GV1_FILE_YN.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV1_FILE_YN.FieldName = "FILE_YN"
        Me.GV1_FILE_YN.Name = "GV1_FILE_YN"
        Me.GV1_FILE_YN.Width = 20
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
        'GV1_SYS_ID
        '
        Me.GV1_SYS_ID.Caption = "System ID"
        Me.GV1_SYS_ID.FieldName = "SYS_ID"
        Me.GV1_SYS_ID.Name = "GV1_SYS_ID"
        Me.Localizer1.SetWordID(Me.GV1_SYS_ID, "System ID")
        '
        'GV1_REQ_TYPE2
        '
        Me.GV1_REQ_TYPE2.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_TYPE2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_TYPE2.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_TYPE2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_TYPE2.Caption = "요청상세"
        Me.GV1_REQ_TYPE2.FieldName = "REQ_TYPE2"
        Me.GV1_REQ_TYPE2.Name = "GV1_REQ_TYPE2"
        Me.GV1_REQ_TYPE2.Visible = True
        Me.GV1_REQ_TYPE2.VisibleIndex = 0
        Me.GV1_REQ_TYPE2.Width = 64
        Me.Localizer1.SetWordID(Me.GV1_REQ_TYPE2, "요청상세")
        '
        'GV1_DEV_CMPT_YN
        '
        Me.GV1_DEV_CMPT_YN.Caption = "개발팀 완료 여부"
        Me.GV1_DEV_CMPT_YN.FieldName = "DEV_CMPT_YN"
        Me.GV1_DEV_CMPT_YN.Name = "GV1_DEV_CMPT_YN"
        Me.Localizer1.SetWordID(Me.GV1_DEV_CMPT_YN, "개발팀 완료 여부")
        '
        'GV1_DEV_CMPT_YMD
        '
        Me.GV1_DEV_CMPT_YMD.Caption = "개발팀 완료 날짜"
        Me.GV1_DEV_CMPT_YMD.FieldName = "DEV_CMPT_YMD"
        Me.GV1_DEV_CMPT_YMD.Name = "GV1_DEV_CMPT_YMD"
        Me.Localizer1.SetWordID(Me.GV1_DEV_CMPT_YMD, "개발팀 완료 날짜")
        '
        'GV1_RETURN_YN
        '
        Me.GV1_RETURN_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_RETURN_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RETURN_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RETURN_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RETURN_YN.Caption = "반려여부"
        Me.GV1_RETURN_YN.FieldName = "RETURN_YN"
        Me.GV1_RETURN_YN.Name = "GV1_RETURN_YN"
        Me.GV1_RETURN_YN.OptionsColumn.AllowEdit = False
        Me.GV1_RETURN_YN.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_RETURN_YN, "반려여부")
        '
        'GV1_REQ_SVC2
        '
        Me.GV1_REQ_SVC2.Caption = "업무구분2"
        Me.GV1_REQ_SVC2.FieldName = "REQ_SVC2"
        Me.GV1_REQ_SVC2.Name = "GV1_REQ_SVC2"
        Me.GV1_REQ_SVC2.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_SVC2.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_SVC2.Visible = True
        Me.GV1_REQ_SVC2.VisibleIndex = 1
        Me.GV1_REQ_SVC2.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC2, "")
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
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.SEARCH_KEY, "")
        Me.Localizer1.SetWordID(Me.Label1, "Search Key")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.NEW_POPUP_INPUT, "Test PopUp 등록")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.CUST_CD, "")
        Me.Localizer1.SetWordID(Me.POPUP_INPUT, "PopUp 등록")
        Me.Localizer1.SetWordID(Me.Label32, "~")
        Me.Localizer1.SetWordID(Me.TO_YMD, "")
        Me.Localizer1.SetWordID(Me.FM_YMD, "")
        Me.Localizer1.SetWordID(Me.lbl_FM_YMD, "등록일자")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV1_REQ_YMD, "요청일자")
        Me.Localizer1.SetWordID(Me.GV1_REQ_HM, "요청시간")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "업무")
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "코드")
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "거래처 명")
        Me.Localizer1.SetWordID(Me.GV1_CONTENT, "내용")
        Me.Localizer1.SetWordID(Me.GV1_REQ_USR, "요청자")
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "연락처")
        Me.Localizer1.SetWordID(Me.GV1_REQ_TYPE, "요청사항 구분")
        Me.Localizer1.SetWordID(Me.GV1_PROC_TYPE, "처리내용")
        Me.Localizer1.SetWordID(Me.GV1_WORK_USR, "작업자")
        Me.Localizer1.SetWordID(Me.GV1_PRIORITY, "우선순위")
        Me.Localizer1.SetWordID(Me.GV1_PRAR_YMD, "예정일자")
        Me.Localizer1.SetWordID(Me.GV1_CMPT_YMD, "완료일자")
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "등록자")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        Me.Localizer1.SetWordID(Me.GV1_CMPT_RMK, "답변")
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "사용여부")
        Me.Localizer1.SetWordID(Me.GV1_SVC_CD, "시스템")
        Me.Localizer1.SetWordID(Me.GV1_MATN_YN, "유지보수")
        Me.Localizer1.SetWordID(Me.GV1_SALES_NM, "영업담당")
        Me.Localizer1.SetWordID(Me.GV1_FREE_YN, "유상/무상")
        Me.Localizer1.SetWordID(Me.GV1_FILE_YN, "Document")
        Me.Localizer1.SetWordID(Me.GV1_SYS_ID, "System ID")
        Me.Localizer1.SetWordID(Me.GV1_REQ_TYPE2, "요청상세")
        Me.Localizer1.SetWordID(Me.GV1_DEV_CMPT_YN, "개발팀 완료 여부")
        Me.Localizer1.SetWordID(Me.GV1_DEV_CMPT_YMD, "개발팀 완료 날짜")
        Me.Localizer1.SetWordID(Me.GV1_RETURN_YN, "반려여부")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC2, "업무구분2")
        Me.Localizer1.SetWordID(Me.GridColumn1, "순번")
        Me.Localizer1.SetWordID(Me.GridColumn2, "사이트명")
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처유형")
        Me.Localizer1.SetWordID(Me.GridColumn4, "담당자")
        Me.Localizer1.SetWordID(Me.GridColumn5, "전화")
        Me.Localizer1.SetWordID(Me.GridColumn6, "DB IP")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.S_DEPT_AUTH_LIST, "")
        Me.Localizer1.SetWordID(Me.S_DEPT_CD, "")
        Me.Localizer1.SetWordID(Me.Label29, "공유부서")
        Me.Localizer1.SetWordID(Me.Label26, "등록부서")
        Me.Localizer1.SetWordID(Me.S_PRIORITY, "우선순위")
        Me.Localizer1.SetWordID(Me.S_SVC_CD, "")
        Me.Localizer1.SetWordID(Me.Label37, "시스템")
        Me.Localizer1.SetWordID(Me.S_WORK_USR, "")
        Me.Localizer1.SetWordID(Me.Label6, "작업자 우선검색")
        Me.Localizer1.SetWordID(Me.S_PROC_TYPE, "")
        Me.Localizer1.SetWordID(Me.Label3, "처리내용")
        Me.Localizer1.SetWordID(Me.REF_TIME, "5")
        Me.Localizer1.SetWordID(Me.Label5, "Refresh")
        Me.Localizer1.SetWordID(Me.S_ROW_BEST, "Yes")
        Me.Localizer1.SetWordID(Me.Label4, "Row Best Fit")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.WG7, "")
        Me.Localizer1.SetWordID(Me.GV7_PROC_TYPE, "처리내용")
        Me.Localizer1.SetWordID(Me.GV7_PROC_CNT, "건수")
        Me.Localizer1.SetWordID(Me.WG6, "")
        Me.Localizer1.SetWordID(Me.GV6_WORK_USR, "작업자")
        Me.Localizer1.SetWordID(Me.GV6_PROC_TYPE_7, "처리중")
        Me.Localizer1.SetWordID(Me.GV6_PROC_TYPE_0, "미확인")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.S_DEPT_AUTH_LIST)
        Me.PanelControl1.Controls.Add(Me.S_DEPT_CD)
        Me.PanelControl1.Controls.Add(Me.Label29)
        Me.PanelControl1.Controls.Add(Me.Label26)
        Me.PanelControl1.Controls.Add(Me.S_PRIORITY)
        Me.PanelControl1.Controls.Add(Me.S_SVC_CD)
        Me.PanelControl1.Controls.Add(Me.Label37)
        Me.PanelControl1.Controls.Add(Me.S_WORK_USR)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.S_PROC_TYPE)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label32)
        Me.PanelControl1.Controls.Add(Me.SEARCH_KEY)
        Me.PanelControl1.Controls.Add(Me.TO_YMD)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.FM_YMD)
        Me.PanelControl1.Controls.Add(Me.lbl_FM_YMD)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 41)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(590, 75)
        Me.PanelControl1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'S_DEPT_AUTH_LIST
        '
        Me.S_DEPT_AUTH_LIST.Location = New System.Drawing.Point(488, 5)
        Me.S_DEPT_AUTH_LIST.Name = "S_DEPT_AUTH_LIST"
        Me.S_DEPT_AUTH_LIST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.S_DEPT_AUTH_LIST.Size = New System.Drawing.Size(95, 21)
        Me.S_DEPT_AUTH_LIST.TabIndex = 253
        Me.Localizer1.SetWordID(Me.S_DEPT_AUTH_LIST, "")
        '
        'S_DEPT_CD
        '
        Me.S_DEPT_CD.Location = New System.Drawing.Point(332, 5)
        Me.S_DEPT_CD.Name = "S_DEPT_CD"
        Me.S_DEPT_CD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.S_DEPT_CD.Size = New System.Drawing.Size(95, 21)
        Me.S_DEPT_CD.TabIndex = 252
        Me.Localizer1.SetWordID(Me.S_DEPT_CD, "")
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.LabelFor = Nothing
        Me.Label29.Location = New System.Drawing.Point(431, 8)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(55, 14)
        Me.Label29.TabIndex = 255
        Me.Label29.Text = "공유부서"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label29, "")
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.LabelFor = Nothing
        Me.Label26.Location = New System.Drawing.Point(275, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 14)
        Me.Label26.TabIndex = 254
        Me.Label26.Text = "등록부서"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label26, "")
        '
        'S_PRIORITY
        '
        Me.S_PRIORITY.BindingPropertyName = "YesNo"
        Me.S_PRIORITY.DefVal = False
        Me.S_PRIORITY.IsDataStateAware = True
        Me.S_PRIORITY.Location = New System.Drawing.Point(486, 50)
        Me.S_PRIORITY.Name = "S_PRIORITY"
        Me.S_PRIORITY.NextFocus = ""
        Me.S_PRIORITY.Properties.Caption = "우선순위"
        Me.S_PRIORITY.RequiredFor = ""
        Me.S_PRIORITY.Size = New System.Drawing.Size(75, 19)
        Me.S_PRIORITY.TabIndex = 251
        Me.Localizer1.SetWordID(Me.S_PRIORITY, "")
        Me.S_PRIORITY.YesNo = "N"
        '
        'S_SVC_CD
        '
        Me.S_SVC_CD.Location = New System.Drawing.Point(332, 27)
        Me.S_SVC_CD.Name = "S_SVC_CD"
        Me.S_SVC_CD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.S_SVC_CD.Size = New System.Drawing.Size(95, 21)
        Me.S_SVC_CD.TabIndex = 247
        Me.Localizer1.SetWordID(Me.S_SVC_CD, "")
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.LabelFor = Nothing
        Me.Label37.Location = New System.Drawing.Point(287, 30)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(43, 14)
        Me.Label37.TabIndex = 246
        Me.Label37.Text = "시스템"
        Me.Localizer1.SetWordID(Me.Label37, "시스템")
        '
        'S_WORK_USR
        '
        Me.S_WORK_USR.BorderColor = System.Drawing.Color.Silver
        Me.S_WORK_USR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_WORK_USR.DefVal = ""
        Me.S_WORK_USR.IsDataStateAware = True
        Me.S_WORK_USR.Location = New System.Drawing.Point(332, 49)
        Me.S_WORK_USR.Name = "S_WORK_USR"
        Me.S_WORK_USR.NextFocus = Nothing
        Me.S_WORK_USR.RequiredFor = ""
        Me.S_WORK_USR.Size = New System.Drawing.Size(95, 22)
        Me.S_WORK_USR.TabIndex = 250
        Me.S_WORK_USR.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(231, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 14)
        Me.Label6.TabIndex = 249
        Me.Label6.Text = "작업자 우선검색"
        Me.Localizer1.SetWordID(Me.Label6, "작업자 우선검색")
        '
        'S_PROC_TYPE
        '
        Me.S_PROC_TYPE.Location = New System.Drawing.Point(488, 27)
        Me.S_PROC_TYPE.Name = "S_PROC_TYPE"
        Me.S_PROC_TYPE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.S_PROC_TYPE.Size = New System.Drawing.Size(95, 21)
        Me.S_PROC_TYPE.TabIndex = 238
        Me.Localizer1.SetWordID(Me.S_PROC_TYPE, "")
        '
        'Label3
        '
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(417, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "처리내용"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label3, "처리내용")
        '
        'REF_TIME
        '
        Me.REF_TIME.CodeType = ""
        Me.REF_TIME.ColumnWidths = ""
        Me.REF_TIME.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.REF_TIME.DataParams = ""
        Me.REF_TIME.DefVal = "5"
        Me.REF_TIME.DisplayMember = "NAME"
        Me.REF_TIME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.REF_TIME.FormattingEnabled = True
        Me.REF_TIME.IsDataStateAware = True
        Me.REF_TIME.ItemDelimiter = ","
        Me.REF_TIME.ItemTextList = "N/A,5분,10분,15분,20분"
        Me.REF_TIME.ItemValueList = "0,5,10,15,20"
        Me.REF_TIME.KeepIntegrity = True
        Me.REF_TIME.Location = New System.Drawing.Point(104, 27)
        Me.REF_TIME.Name = "REF_TIME"
        Me.REF_TIME.NextFocus = "S_SEARCH_PR"
        Me.REF_TIME.NullText = ""
        Me.REF_TIME.RequiredFor = ""
        Me.REF_TIME.SearchKeys = ""
        Me.REF_TIME.Size = New System.Drawing.Size(70, 22)
        Me.REF_TIME.TabIndex = 245
        Me.REF_TIME.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.REF_TIME.ValueMember = "CODE"
        '
        'Label5
        '
        Me.Label5.LabelFor = Nothing
        Me.Label5.Location = New System.Drawing.Point(40, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 244
        Me.Label5.Text = "Refresh"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label5, "Refresh")
        '
        'S_ROW_BEST
        '
        Me.S_ROW_BEST.CodeType = ""
        Me.S_ROW_BEST.ColumnWidths = ""
        Me.S_ROW_BEST.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_ROW_BEST.DataParams = ""
        Me.S_ROW_BEST.DefVal = "Y"
        Me.S_ROW_BEST.DisplayMember = "NAME"
        Me.S_ROW_BEST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_ROW_BEST.FormattingEnabled = True
        Me.S_ROW_BEST.IsDataStateAware = True
        Me.S_ROW_BEST.ItemDelimiter = ","
        Me.S_ROW_BEST.ItemTextList = "Yes,No"
        Me.S_ROW_BEST.ItemValueList = "Y,N"
        Me.S_ROW_BEST.KeepIntegrity = True
        Me.S_ROW_BEST.Location = New System.Drawing.Point(104, 4)
        Me.S_ROW_BEST.Name = "S_ROW_BEST"
        Me.S_ROW_BEST.NextFocus = "REF_TIME"
        Me.S_ROW_BEST.NullText = "--Select--"
        Me.S_ROW_BEST.RequiredFor = ""
        Me.S_ROW_BEST.SearchKeys = ""
        Me.S_ROW_BEST.Size = New System.Drawing.Size(70, 22)
        Me.S_ROW_BEST.TabIndex = 243
        Me.S_ROW_BEST.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_ROW_BEST.ValueMember = "CODE"
        '
        'Label4
        '
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(6, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 242
        Me.Label4.Text = "Row Best Fit"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label4, "Row Best Fit")
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.S_ROW_BEST)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.REF_TIME)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Location = New System.Drawing.Point(598, 41)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(179, 75)
        Me.PanelControl2.TabIndex = 8
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'WG7
        '
        Me.WG7.AllowClientBinding = True
        Me.WG7.DeleteRowConfirmation = False
        Me.WG7.DisplayCurrentRow = False
        Me.WG7.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.WG7.IsDataStateAware = True
        Me.WG7.Location = New System.Drawing.Point(783, 7)
        Me.WG7.MainView = Me.GV7
        Me.WG7.Name = "WG7"
        Me.WG7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GV7_CheckBox, Me.GV7_DateType})
        Me.WG7.SaveLayout = False
        Me.WG7.Size = New System.Drawing.Size(162, 109)
        Me.WG7.TabIndex = 207
        Me.WG7.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV7})
        Me.WG7.Visible = False
        '
        'GV7
        '
        Me.GV7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV7_PROC_TYPE, Me.GV7_PROC_CNT})
        Me.GV7.GridControl = Me.WG7
        Me.GV7.Name = "GV7"
        Me.GV7.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GV7.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV7.OptionsPrint.AutoWidth = False
        Me.GV7.OptionsView.ColumnAutoWidth = False
        Me.GV7.OptionsView.ShowGroupPanel = False
        Me.GV7.OptionsView.ShowIndicator = False
        '
        'GV7_PROC_TYPE
        '
        Me.GV7_PROC_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV7_PROC_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV7_PROC_TYPE.Caption = "처리내용"
        Me.GV7_PROC_TYPE.FieldName = "PROC_TYPE"
        Me.GV7_PROC_TYPE.Name = "GV7_PROC_TYPE"
        Me.GV7_PROC_TYPE.Visible = True
        Me.GV7_PROC_TYPE.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GV7_PROC_TYPE, "")
        '
        'GV7_PROC_CNT
        '
        Me.GV7_PROC_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV7_PROC_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV7_PROC_CNT.Caption = "건수"
        Me.GV7_PROC_CNT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV7_PROC_CNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV7_PROC_CNT.FieldName = "PROC_CNT"
        Me.GV7_PROC_CNT.Name = "GV7_PROC_CNT"
        Me.GV7_PROC_CNT.Visible = True
        Me.GV7_PROC_CNT.VisibleIndex = 1
        Me.GV7_PROC_CNT.Width = 62
        Me.Localizer1.SetWordID(Me.GV7_PROC_CNT, "")
        '
        'GV7_CheckBox
        '
        Me.GV7_CheckBox.AutoHeight = False
        Me.GV7_CheckBox.Name = "GV7_CheckBox"
        Me.GV7_CheckBox.ValueChecked = "Y"
        Me.GV7_CheckBox.ValueUnchecked = "N"
        '
        'GV7_DateType
        '
        Me.GV7_DateType.AutoHeight = False
        Me.GV7_DateType.Mask.EditMask = "9999-99-99"
        Me.GV7_DateType.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.GV7_DateType.Mask.UseMaskAsDisplayFormat = True
        Me.GV7_DateType.Name = "GV7_DateType"
        '
        'WG6
        '
        Me.WG6.AllowClientBinding = True
        Me.WG6.DeleteRowConfirmation = False
        Me.WG6.DisplayCurrentRow = False
        Me.WG6.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.WG6.IsDataStateAware = True
        Me.WG6.Location = New System.Drawing.Point(951, 7)
        Me.WG6.MainView = Me.GV6
        Me.WG6.Name = "WG6"
        Me.WG6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2, Me.RepositoryItemTextEdit3})
        Me.WG6.SaveLayout = False
        Me.WG6.Size = New System.Drawing.Size(200, 109)
        Me.WG6.TabIndex = 208
        Me.WG6.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV6})
        Me.WG6.Visible = False
        '
        'GV6
        '
        Me.GV6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV6_WORK_USR, Me.GV6_PROC_TYPE_7, Me.GV6_PROC_TYPE_0})
        Me.GV6.GridControl = Me.WG6
        Me.GV6.Name = "GV6"
        Me.GV6.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GV6.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV6.OptionsPrint.AutoWidth = False
        Me.GV6.OptionsView.ColumnAutoWidth = False
        Me.GV6.OptionsView.ShowGroupPanel = False
        Me.GV6.OptionsView.ShowIndicator = False
        '
        'GV6_WORK_USR
        '
        Me.GV6_WORK_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV6_WORK_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV6_WORK_USR.Caption = "작업자"
        Me.GV6_WORK_USR.FieldName = "WORK_USR"
        Me.GV6_WORK_USR.Name = "GV6_WORK_USR"
        Me.GV6_WORK_USR.Visible = True
        Me.GV6_WORK_USR.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GV6_WORK_USR, "")
        '
        'GV6_PROC_TYPE_7
        '
        Me.GV6_PROC_TYPE_7.AppearanceHeader.Options.UseTextOptions = True
        Me.GV6_PROC_TYPE_7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV6_PROC_TYPE_7.Caption = "처리중"
        Me.GV6_PROC_TYPE_7.DisplayFormat.FormatString = "{0:N0}"
        Me.GV6_PROC_TYPE_7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV6_PROC_TYPE_7.FieldName = "PROC_TYPE_7"
        Me.GV6_PROC_TYPE_7.Name = "GV6_PROC_TYPE_7"
        Me.GV6_PROC_TYPE_7.Visible = True
        Me.GV6_PROC_TYPE_7.VisibleIndex = 1
        Me.GV6_PROC_TYPE_7.Width = 50
        Me.Localizer1.SetWordID(Me.GV6_PROC_TYPE_7, "")
        '
        'GV6_PROC_TYPE_0
        '
        Me.GV6_PROC_TYPE_0.AppearanceHeader.Options.UseTextOptions = True
        Me.GV6_PROC_TYPE_0.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV6_PROC_TYPE_0.Caption = "미확인"
        Me.GV6_PROC_TYPE_0.DisplayFormat.FormatString = "{0:N0}"
        Me.GV6_PROC_TYPE_0.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV6_PROC_TYPE_0.FieldName = "PROC_TYPE_0"
        Me.GV6_PROC_TYPE_0.Name = "GV6_PROC_TYPE_0"
        Me.GV6_PROC_TYPE_0.Visible = True
        Me.GV6_PROC_TYPE_0.VisibleIndex = 2
        Me.GV6_PROC_TYPE_0.Width = 50
        Me.Localizer1.SetWordID(Me.GV6_PROC_TYPE_0, "")
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "N"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'iconImages
        '
        Me.iconImages.ImageStream = CType(resources.GetObject("iconImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.iconImages.Images.SetKeyName(0, "aligncenter.png")
        Me.iconImages.Images.SetKeyName(1, "alignleft.png")
        Me.iconImages.Images.SetKeyName(2, "alignright.png")
        Me.iconImages.Images.SetKeyName(3, "redo.png")
        Me.iconImages.Images.SetKeyName(4, "select.png")
        Me.iconImages.Images.SetKeyName(5, "undo.png")
        Me.iconImages.Images.SetKeyName(6, "colorchooser.png")
        Me.iconImages.Images.SetKeyName(7, "backcolor.png")
        Me.iconImages.Images.SetKeyName(8, "forecolor.png")
        Me.iconImages.Images.SetKeyName(9, "bulleting.png")
        Me.iconImages.Images.SetKeyName(10, "numbering.png")
        Me.iconImages.Images.SetKeyName(11, "indentdec.png")
        Me.iconImages.Images.SetKeyName(12, "indentinc.png")
        Me.iconImages.Images.SetKeyName(13, "hyperlinkins.png")
        Me.iconImages.Images.SetKeyName(14, "imageins.png")
        Me.iconImages.Images.SetKeyName(15, "table.png")
        Me.iconImages.Images.SetKeyName(16, "Save.png")
        Me.iconImages.Images.SetKeyName(17, "Delete.png")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'CrmAsMgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1435, 678)
        Me.Controls.Add(Me.WG6)
        Me.Controls.Add(Me.WG7)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.WG1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "CrmAsMgt"
        Me.Text = "사이트 지원 등록"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.palAutoButton.PerformLayout()
        CType(Me.NEW_POPUP_INPUT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POPUP_INPUT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.S_DEPT_AUTH_LIST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S_DEPT_CD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S_PRIORITY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S_SVC_CD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S_PROC_TYPE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.WG7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7_CheckBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7_DateType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SEARCH_KEY As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents GV1_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WORK_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents iconImages As DevExpress.Utils.ImageCollection
    Friend WithEvents GV1_REQ_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_HM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_SVC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CONTENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PRAR_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CMPT_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CUST_CD As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents GV1_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_FM_YMD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label32 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents TO_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents FM_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_PROC_TYPE As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_ROW_BEST As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents REF_TIME As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label5 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label37 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_SVC_CD As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents GV1_PRIORITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_WORK_USR As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label6 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents RepositoryItemDateBoxEdit1 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents S_PRIORITY As YJIT.SC.UI.SCControls.CheckBox
    Friend WithEvents POPUP_INPUT As YJIT.SC.UI.SCControls.CheckBox
    Friend WithEvents GV1_USE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SVC_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MATN_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SALES_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateBoxEdit2 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Public WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1_FREE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FILE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV1_SYS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CMPT_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Public WithEvents WG7 As YJIT.SC.UI.SCControls.WebGrid
    Public WithEvents GV7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV7_DateType As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV7_CheckBox As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV7_PROC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV7_PROC_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents WG6 As YJIT.SC.UI.SCControls.WebGrid
    Public WithEvents GV6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV6_WORK_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV6_PROC_TYPE_7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV6_PROC_TYPE_0 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NEW_POPUP_INPUT As YJIT.SC.UI.SCControls.CheckBox
    Friend WithEvents GV1_REQ_TYPE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_DEPT_AUTH_LIST As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents S_DEPT_CD As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Label29 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label26 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV1_DEV_CMPT_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DEV_CMPT_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RETURN_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_SVC2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
