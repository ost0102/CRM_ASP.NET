<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdmMappingMgt
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdmMappingMgt))
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_OFFICE_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TABLE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FM_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FM_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TO_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TO_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FIELD_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FIELD_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPPER_FM_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PK_TABLE_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PK_FM_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PK_FM_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PK_TO_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PkgLst_Date = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpCheckBox = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Awbadv_Num3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GV1_RP_TEXTBOX = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.S_COMN_CD = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_RMK = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.S_TO_CD = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.lbMappingType = New YJIT.SC.UI.SCControls.Label()
        Me.Label19 = New YJIT.SC.UI.SCControls.Label()
        Me.S_FM_CD = New YJIT.SC.UI.SCControls.TextBox()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PkgLst_Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Awbadv_Num3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMemoExEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1_RP_TEXTBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.Panel1, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_OFFICE_CD, "Office Code")
        Me.Localizer1.SetWordID(Me.GV1_TABLE_ID, "Table ID")
        Me.Localizer1.SetWordID(Me.GV1_FM_TYPE, "Mapping Type")
        Me.Localizer1.SetWordID(Me.GV1_FM_CD, "From Code")
        Me.Localizer1.SetWordID(Me.GV1_TO_CD, "To Code")
        Me.Localizer1.SetWordID(Me.GV1_TO_NM, "To Name")
        Me.Localizer1.SetWordID(Me.GV1_FIELD_ID, "Field ID")
        Me.Localizer1.SetWordID(Me.GV1_FIELD_TYPE, "Field Type")
        Me.Localizer1.SetWordID(Me.GV1_UPPER_FM_CD, "Upper From Code")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "Remark")
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "Creator")
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "Created Date")
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "Modifier")
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "Modified Date")
        Me.Localizer1.SetWordID(Me.GV1_PK_TABLE_ID, "Update key")
        Me.Localizer1.SetWordID(Me.GV1_PK_FM_TYPE, "Update key")
        Me.Localizer1.SetWordID(Me.GV1_PK_FM_CD, "Update key")
        Me.Localizer1.SetWordID(Me.GV1_PK_TO_CD, "Update key")
        Me.Localizer1.SetWordID(Me.GroupControl1, "Select Condition")
        Me.Localizer1.SetWordID(Me.S_COMN_CD, "--Select--")
        Me.Localizer1.SetWordID(Me.S_RMK, "")
        Me.Localizer1.SetWordID(Me.Label3, "Remark")
        Me.Localizer1.SetWordID(Me.S_TO_CD, "")
        Me.Localizer1.SetWordID(Me.Label2, "To Code")
        Me.Localizer1.SetWordID(Me.Label1, "From Code")
        Me.Localizer1.SetWordID(Me.lbMappingType, "* 공통코드 : E11")
        Me.Localizer1.SetWordID(Me.Label19, "Mapping Type")
        Me.Localizer1.SetWordID(Me.S_FM_CD, "")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.btnNew, "&Clear")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.WG1)
        Me.Panel1.Controls.Add(Me.GroupControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1007, 597)
        Me.Panel1.TabIndex = 3
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = False
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(6, 87)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.PkgLst_Date, Me.rpCheckBox, Me.Awbadv_Num3, Me.rpMemoExEdit, Me.GV1_RP_TEXTBOX})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(997, 505)
        Me.WG1.TabIndex = 84
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GV1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_OFFICE_CD, Me.GV1_TABLE_ID, Me.GV1_FM_TYPE, Me.GV1_FM_CD, Me.GV1_TO_CD, Me.GV1_TO_NM, Me.GV1_FIELD_ID, Me.GV1_FIELD_TYPE, Me.GV1_UPPER_FM_CD, Me.GV1_RMK, Me.GV1_INS_USR, Me.GV1_INS_YMD, Me.GV1_UPD_USR, Me.GV1_UPD_YMD, Me.GV1_PK_TABLE_ID, Me.GV1_PK_FM_TYPE, Me.GV1_PK_FM_CD, Me.GV1_PK_TO_CD})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "9"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "7"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod
        StyleFormatCondition3.Appearance.BorderColor = System.Drawing.Color.DarkKhaki
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseBorderColor = True
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "3"
        Me.GV1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsPrint.AutoWidth = False
        Me.GV1.OptionsView.AllowHtmlDrawHeaders = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.ViewCaption = "Mapping Information"
        '
        'GV1_OFFICE_CD
        '
        Me.GV1_OFFICE_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_OFFICE_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_OFFICE_CD.Caption = "Office Code"
        Me.GV1_OFFICE_CD.FieldName = "OFFICE_CD"
        Me.GV1_OFFICE_CD.Name = "GV1_OFFICE_CD"
        Me.GV1_OFFICE_CD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_OFFICE_CD, "Office Code")
        '
        'GV1_TABLE_ID
        '
        Me.GV1_TABLE_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TABLE_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TABLE_ID.Caption = "Table ID"
        Me.GV1_TABLE_ID.FieldName = "TABLE_ID"
        Me.GV1_TABLE_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_TABLE_ID.Name = "GV1_TABLE_ID"
        Me.GV1_TABLE_ID.Visible = True
        Me.GV1_TABLE_ID.VisibleIndex = 0
        Me.GV1_TABLE_ID.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_TABLE_ID, "Table ID")
        '
        'GV1_FM_TYPE
        '
        Me.GV1_FM_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FM_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_FM_TYPE.Caption = "Mapping Type"
        Me.GV1_FM_TYPE.FieldName = "FM_TYPE"
        Me.GV1_FM_TYPE.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_FM_TYPE.Name = "GV1_FM_TYPE"
        Me.GV1_FM_TYPE.Visible = True
        Me.GV1_FM_TYPE.VisibleIndex = 1
        Me.GV1_FM_TYPE.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_FM_TYPE, "Mapping Type")
        '
        'GV1_FM_CD
        '
        Me.GV1_FM_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FM_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_FM_CD.Caption = "From Code"
        Me.GV1_FM_CD.FieldName = "FM_CD"
        Me.GV1_FM_CD.Name = "GV1_FM_CD"
        Me.GV1_FM_CD.Visible = True
        Me.GV1_FM_CD.VisibleIndex = 2
        Me.GV1_FM_CD.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_FM_CD, "From Code")
        '
        'GV1_TO_CD
        '
        Me.GV1_TO_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TO_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_TO_CD.Caption = "To Code"
        Me.GV1_TO_CD.FieldName = "TO_CD"
        Me.GV1_TO_CD.Name = "GV1_TO_CD"
        Me.GV1_TO_CD.Visible = True
        Me.GV1_TO_CD.VisibleIndex = 3
        Me.GV1_TO_CD.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_TO_CD, "To Code")
        '
        'GV1_TO_NM
        '
        Me.GV1_TO_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TO_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_TO_NM.Caption = "To Name"
        Me.GV1_TO_NM.FieldName = "TO_NM"
        Me.GV1_TO_NM.Name = "GV1_TO_NM"
        Me.GV1_TO_NM.Visible = True
        Me.GV1_TO_NM.VisibleIndex = 4
        Me.GV1_TO_NM.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_TO_NM, "To Name")
        '
        'GV1_FIELD_ID
        '
        Me.GV1_FIELD_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FIELD_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_FIELD_ID.Caption = "Field ID"
        Me.GV1_FIELD_ID.FieldName = "FIELD_ID"
        Me.GV1_FIELD_ID.Name = "GV1_FIELD_ID"
        Me.GV1_FIELD_ID.Visible = True
        Me.GV1_FIELD_ID.VisibleIndex = 5
        Me.GV1_FIELD_ID.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_FIELD_ID, "Field ID")
        '
        'GV1_FIELD_TYPE
        '
        Me.GV1_FIELD_TYPE.Caption = "Field Type"
        Me.GV1_FIELD_TYPE.FieldName = "FIELD_TYPE"
        Me.GV1_FIELD_TYPE.Name = "GV1_FIELD_TYPE"
        Me.GV1_FIELD_TYPE.Visible = True
        Me.GV1_FIELD_TYPE.VisibleIndex = 6
        Me.Localizer1.SetWordID(Me.GV1_FIELD_TYPE, "Field Type")
        '
        'GV1_UPPER_FM_CD
        '
        Me.GV1_UPPER_FM_CD.Caption = "Upper From Code"
        Me.GV1_UPPER_FM_CD.FieldName = "UPPER_FM_CD"
        Me.GV1_UPPER_FM_CD.Name = "GV1_UPPER_FM_CD"
        Me.GV1_UPPER_FM_CD.Visible = True
        Me.GV1_UPPER_FM_CD.VisibleIndex = 7
        Me.Localizer1.SetWordID(Me.GV1_UPPER_FM_CD, "Upper From Code")
        '
        'GV1_RMK
        '
        Me.GV1_RMK.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_RMK.Caption = "Remark"
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 8
        Me.GV1_RMK.Width = 200
        Me.Localizer1.SetWordID(Me.GV1_RMK, "Remark")
        '
        'GV1_INS_USR
        '
        Me.GV1_INS_USR.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GV1_INS_USR.AppearanceCell.Options.UseForeColor = True
        Me.GV1_INS_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GV1_INS_USR.AppearanceHeader.Options.UseForeColor = True
        Me.GV1_INS_USR.Caption = "Creator"
        Me.GV1_INS_USR.FieldName = "INS_USR"
        Me.GV1_INS_USR.Name = "GV1_INS_USR"
        Me.GV1_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV1_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV1_INS_USR.Visible = True
        Me.GV1_INS_USR.VisibleIndex = 9
        Me.GV1_INS_USR.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "Creator")
        '
        'GV1_INS_YMD
        '
        Me.GV1_INS_YMD.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GV1_INS_YMD.AppearanceCell.Options.UseForeColor = True
        Me.GV1_INS_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_YMD.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseForeColor = True
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GV1_INS_YMD.Caption = "Created Date"
        Me.GV1_INS_YMD.FieldName = "INS_YMD"
        Me.GV1_INS_YMD.Name = "GV1_INS_YMD"
        Me.GV1_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_INS_YMD.Visible = True
        Me.GV1_INS_YMD.VisibleIndex = 10
        Me.GV1_INS_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "Created Date")
        '
        'GV1_UPD_USR
        '
        Me.GV1_UPD_USR.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GV1_UPD_USR.AppearanceCell.Options.UseForeColor = True
        Me.GV1_UPD_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_UPD_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_USR.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GV1_UPD_USR.AppearanceHeader.Options.UseForeColor = True
        Me.GV1_UPD_USR.Caption = "Modifier"
        Me.GV1_UPD_USR.FieldName = "UPD_USR"
        Me.GV1_UPD_USR.Name = "GV1_UPD_USR"
        Me.GV1_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_USR.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_USR.Visible = True
        Me.GV1_UPD_USR.VisibleIndex = 11
        Me.GV1_UPD_USR.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "Modifier")
        '
        'GV1_UPD_YMD
        '
        Me.GV1_UPD_YMD.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GV1_UPD_YMD.AppearanceCell.Options.UseForeColor = True
        Me.GV1_UPD_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_UPD_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_YMD.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GV1_UPD_YMD.AppearanceHeader.Options.UseForeColor = True
        Me.GV1_UPD_YMD.Caption = "Modified Date"
        Me.GV1_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV1_UPD_YMD.Name = "GV1_UPD_YMD"
        Me.GV1_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_YMD.Visible = True
        Me.GV1_UPD_YMD.VisibleIndex = 12
        Me.GV1_UPD_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "Modified Date")
        '
        'GV1_PK_TABLE_ID
        '
        Me.GV1_PK_TABLE_ID.Caption = "Update key"
        Me.GV1_PK_TABLE_ID.Name = "GV1_PK_TABLE_ID"
        Me.Localizer1.SetWordID(Me.GV1_PK_TABLE_ID, "")
        '
        'GV1_PK_FM_TYPE
        '
        Me.GV1_PK_FM_TYPE.Caption = "Update key"
        Me.GV1_PK_FM_TYPE.Name = "GV1_PK_FM_TYPE"
        Me.Localizer1.SetWordID(Me.GV1_PK_FM_TYPE, "")
        '
        'GV1_PK_FM_CD
        '
        Me.GV1_PK_FM_CD.Caption = "Update key"
        Me.GV1_PK_FM_CD.Name = "GV1_PK_FM_CD"
        Me.Localizer1.SetWordID(Me.GV1_PK_FM_CD, "")
        '
        'GV1_PK_TO_CD
        '
        Me.GV1_PK_TO_CD.Caption = "Update key"
        Me.GV1_PK_TO_CD.Name = "GV1_PK_TO_CD"
        Me.Localizer1.SetWordID(Me.GV1_PK_TO_CD, "")
        '
        'PkgLst_Date
        '
        Me.PkgLst_Date.AutoHeight = False
        Me.PkgLst_Date.Mask.EditMask = "9999-99-99"
        Me.PkgLst_Date.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.PkgLst_Date.Mask.UseMaskAsDisplayFormat = True
        Me.PkgLst_Date.Name = "PkgLst_Date"
        '
        'rpCheckBox
        '
        Me.rpCheckBox.AutoHeight = False
        Me.rpCheckBox.Name = "rpCheckBox"
        Me.rpCheckBox.ValueChecked = "Y"
        Me.rpCheckBox.ValueUnchecked = "N"
        '
        'Awbadv_Num3
        '
        Me.Awbadv_Num3.AutoHeight = False
        Me.Awbadv_Num3.Mask.EditMask = "9,999.999"
        Me.Awbadv_Num3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.Awbadv_Num3.Mask.UseMaskAsDisplayFormat = True
        Me.Awbadv_Num3.Name = "Awbadv_Num3"
        '
        'rpMemoExEdit
        '
        Me.rpMemoExEdit.AutoHeight = False
        Me.rpMemoExEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpMemoExEdit.Name = "rpMemoExEdit"
        Me.rpMemoExEdit.PopupFormMinSize = New System.Drawing.Size(200, 50)
        Me.rpMemoExEdit.PopupFormSize = New System.Drawing.Size(300, 80)
        Me.rpMemoExEdit.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.rpMemoExEdit.ReadOnly = True
        Me.rpMemoExEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.rpMemoExEdit.ShowIcon = False
        '
        'GV1_RP_TEXTBOX
        '
        Me.GV1_RP_TEXTBOX.AutoHeight = False
        Me.GV1_RP_TEXTBOX.Mask.EditMask = "9999-99-99"
        Me.GV1_RP_TEXTBOX.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.GV1_RP_TEXTBOX.Mask.SaveLiteral = False
        Me.GV1_RP_TEXTBOX.Mask.UseMaskAsDisplayFormat = True
        Me.GV1_RP_TEXTBOX.Name = "GV1_RP_TEXTBOX"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.S_COMN_CD)
        Me.GroupControl1.Controls.Add(Me.S_RMK)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.S_TO_CD)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.lbMappingType)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.S_FM_CD)
        Me.GroupControl1.Location = New System.Drawing.Point(6, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(997, 80)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Select Condition"
        Me.Localizer1.SetWordID(Me.GroupControl1, "Select Condition")
        '
        'S_COMN_CD
        '
        Me.S_COMN_CD.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_COMN_CD.ColumnWidths = ""
        Me.S_COMN_CD.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_COMN_CD.DataParams = "GroupCode:'E11',NameType:''"
        Me.S_COMN_CD.DefVal = ""
        Me.S_COMN_CD.DisplayMember = "name"
        Me.S_COMN_CD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_COMN_CD.FormattingEnabled = True
        Me.S_COMN_CD.IsDataStateAware = True
        Me.S_COMN_CD.ItemDelimiter = ","
        Me.S_COMN_CD.ItemTextList = ""
        Me.S_COMN_CD.ItemValueList = ""
        Me.S_COMN_CD.KeepIntegrity = True
        Me.S_COMN_CD.Location = New System.Drawing.Point(117, 28)
        Me.S_COMN_CD.Name = "S_COMN_CD"
        Me.S_COMN_CD.NextFocus = "S_RMK"
        Me.S_COMN_CD.NullText = "--Select--"
        Me.S_COMN_CD.SearchKeys = ""
        Me.S_COMN_CD.Size = New System.Drawing.Size(159, 22)
        Me.S_COMN_CD.TabIndex = 243
        Me.S_COMN_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_COMN_CD.ValueMember = "CODE"
        '
        'S_RMK
        '
        Me.S_RMK.BackColor = System.Drawing.SystemColors.Window
        Me.S_RMK.BorderColor = System.Drawing.Color.Silver
        Me.S_RMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_RMK.DefVal = ""
        Me.S_RMK.IsDataStateAware = True
        Me.S_RMK.Location = New System.Drawing.Point(423, 28)
        Me.S_RMK.Name = "S_RMK"
        Me.S_RMK.NextFocus = "S_FM_CD"
        Me.S_RMK.Size = New System.Drawing.Size(159, 22)
        Me.S_RMK.TabIndex = 242
        Me.S_RMK.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label3
        '
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(311, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 241
        Me.Label3.Text = "Remark"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label3, "Remark")
        '
        'S_TO_CD
        '
        Me.S_TO_CD.BackColor = System.Drawing.SystemColors.Window
        Me.S_TO_CD.BorderColor = System.Drawing.Color.Silver
        Me.S_TO_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_TO_CD.DefVal = ""
        Me.S_TO_CD.IsDataStateAware = True
        Me.S_TO_CD.Location = New System.Drawing.Point(423, 54)
        Me.S_TO_CD.Name = "S_TO_CD"
        Me.S_TO_CD.NextFocus = "btnSearch"
        Me.S_TO_CD.Size = New System.Drawing.Size(159, 22)
        Me.S_TO_CD.TabIndex = 240
        Me.S_TO_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label2
        '
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(311, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 22)
        Me.Label2.TabIndex = 239
        Me.Label2.Text = "To Code"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "To Code")
        '
        'Label1
        '
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(10, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 238
        Me.Label1.Text = "From Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "From Code")
        '
        'lbMappingType
        '
        Me.lbMappingType.LabelFor = Nothing
        Me.lbMappingType.Location = New System.Drawing.Point(878, 52)
        Me.lbMappingType.Name = "lbMappingType"
        Me.lbMappingType.Size = New System.Drawing.Size(104, 22)
        Me.lbMappingType.TabIndex = 236
        Me.lbMappingType.Text = "* 공통코드 : E11"
        Me.lbMappingType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbMappingType.Visible = False
        Me.Localizer1.SetWordID(Me.lbMappingType, "* 공통코드 : E11")
        '
        'Label19
        '
        Me.Label19.LabelFor = Nothing
        Me.Label19.Location = New System.Drawing.Point(10, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 22)
        Me.Label19.TabIndex = 236
        Me.Label19.Text = "Mapping Type"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label19, "Mapping Type")
        '
        'S_FM_CD
        '
        Me.S_FM_CD.BackColor = System.Drawing.SystemColors.Window
        Me.S_FM_CD.BorderColor = System.Drawing.Color.Silver
        Me.S_FM_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_FM_CD.DefVal = ""
        Me.S_FM_CD.IsDataStateAware = True
        Me.S_FM_CD.Location = New System.Drawing.Point(117, 54)
        Me.S_FM_CD.Name = "S_FM_CD"
        Me.S_FM_CD.NextFocus = "S_TO_CD"
        Me.S_FM_CD.Size = New System.Drawing.Size(159, 22)
        Me.S_FM_CD.TabIndex = 189
        Me.S_FM_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(997, 32)
        Me.palAutoButton.TabIndex = 2
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(912, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 216
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(744, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 25)
        Me.btnSearch.TabIndex = 214
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(828, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(78, 25)
        Me.btnNew.TabIndex = 215
        Me.btnNew.Text = "&Clear"
        Me.Localizer1.SetWordID(Me.btnNew, "")
        '
        'MdmMappingMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1008, 640)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "MdmMappingMgt"
        Me.Text = "Interface Mapping Management"
        Me.Localizer1.SetWordID(Me, "Interface Mapping Management")
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PkgLst_Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Awbadv_Num3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMemoExEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1_RP_TEXTBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents rpCheckBox As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rpMemoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents PkgLst_Date As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Awbadv_Num3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents S_FM_CD As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnNew As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label19 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV1_RP_TEXTBOX As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents S_RMK As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_TO_CD As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV1_OFFICE_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TABLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FM_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FM_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TO_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TO_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_COMN_CD As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV1_FIELD_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PK_TABLE_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PK_FM_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PK_FM_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PK_TO_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbMappingType As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV1_FIELD_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPPER_FM_CD As DevExpress.XtraGrid.Columns.GridColumn
End Class
