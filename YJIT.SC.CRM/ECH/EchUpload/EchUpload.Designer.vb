<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EchUpload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EchUpload))
        Me.RepositoryItemDateBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnClear = New YJIT.SC.UI.SCControls.Button()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnFile = New YJIT.SC.UI.SCControls.Button()
        Me.FILE_PATH = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_FILE_PATH = New YJIT.SC.UI.SCControls.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV1_CUST_NM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_CUST_CD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_CUSTOMS_CD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV1_FWB_PIMA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_AMS_PIMA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_6CODE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV1_KTNET_AIR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_KTNET_SEA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_KTNET_NONE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV1_FTP_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_FTP_PW = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV1_KLNET_AIR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_KLNET_SEA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_KLNET_NONE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV1_NACCS_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_NACCS_PW = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_NACCS_CODE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_NACCS_EMAIL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_CHAIN_START_YMD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.ItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.iconImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
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
        Me.Localizer1.SetWordID(Me.GridColumn1, "순번")
        Me.Localizer1.SetWordID(Me.GridColumn2, "사이트명")
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처유형")
        Me.Localizer1.SetWordID(Me.GridColumn4, "담당자")
        Me.Localizer1.SetWordID(Me.GridColumn5, "전화")
        Me.Localizer1.SetWordID(Me.GridColumn6, "DB IP")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnClear, "Clear")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.btnFile, "File")
        Me.Localizer1.SetWordID(Me.FILE_PATH, "")
        Me.Localizer1.SetWordID(Me.lbl_FILE_PATH, "File Path")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GridBand1, "")
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "업체명")
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "업체코드")
        Me.Localizer1.SetWordID(Me.GV1_CUSTOMS_CD, "세관코드")
        Me.Localizer1.SetWordID(Me.gridBand2, "KCNET")
        Me.Localizer1.SetWordID(Me.GV1_FWB_PIMA, "FWB PIMA")
        Me.Localizer1.SetWordID(Me.GV1_AMS_PIMA, "AMS PIMA")
        Me.Localizer1.SetWordID(Me.GV1_6CODE, "6CODE")
        Me.Localizer1.SetWordID(Me.gridBand3, "KTNET")
        Me.Localizer1.SetWordID(Me.GV1_KTNET_AIR, "항공 발신인 식별자")
        Me.Localizer1.SetWordID(Me.GV1_KTNET_SEA, "해운 발신인 식별자")
        Me.Localizer1.SetWordID(Me.GV1_KTNET_NONE, "해운 미사용 식별자")
        Me.Localizer1.SetWordID(Me.gridBand4, "KTNET FTP LOGIN 정보")
        Me.Localizer1.SetWordID(Me.GV1_FTP_ID, "ID")
        Me.Localizer1.SetWordID(Me.GV1_FTP_PW, "PW")
        Me.Localizer1.SetWordID(Me.gridBand5, "KLNET")
        Me.Localizer1.SetWordID(Me.GV1_KLNET_AIR, "항공 발신인 식별자")
        Me.Localizer1.SetWordID(Me.GV1_KLNET_SEA, "해운 발신인 식별자")
        Me.Localizer1.SetWordID(Me.GV1_KLNET_NONE, "해운 미사용 식별자")
        Me.Localizer1.SetWordID(Me.gridBand6, "AFR 정보")
        Me.Localizer1.SetWordID(Me.GV1_NACCS_ID, "NACCS ID")
        Me.Localizer1.SetWordID(Me.GV1_NACCS_PW, "NACCS PW")
        Me.Localizer1.SetWordID(Me.GV1_NACCS_CODE, "NACCS CODE")
        Me.Localizer1.SetWordID(Me.GV1_NACCS_EMAIL, "E-mail")
        Me.Localizer1.SetWordID(Me.GV1_CHAIN_START_YMD, "CHAIN 전환일자")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnClear)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1040, 32)
        Me.palAutoButton.TabIndex = 2
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnClear
        '
        Me.btnClear.Action = ""
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnClear.Location = New System.Drawing.Point(881, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 25)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.Localizer1.SetWordID(Me.btnClear, "Clear")
        '
        'btnSave
        '
        Me.btnSave.Action = "SaveData"
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(957, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'btnFile
        '
        Me.btnFile.Action = ""
        Me.btnFile.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnFile.Location = New System.Drawing.Point(496, 13)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(70, 22)
        Me.btnFile.TabIndex = 95
        Me.btnFile.Text = "File"
        Me.Localizer1.SetWordID(Me.btnFile, "File")
        '
        'FILE_PATH
        '
        Me.FILE_PATH.BorderColor = System.Drawing.Color.Silver
        Me.FILE_PATH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FILE_PATH.DefVal = ""
        Me.FILE_PATH.IsDataStateAware = True
        Me.FILE_PATH.Location = New System.Drawing.Point(96, 13)
        Me.FILE_PATH.MaxLength = 20
        Me.FILE_PATH.Name = "FILE_PATH"
        Me.FILE_PATH.NextFocus = "VOY"
        Me.FILE_PATH.RequiredFor = ""
        Me.FILE_PATH.Size = New System.Drawing.Size(394, 22)
        Me.FILE_PATH.TabIndex = 94
        Me.FILE_PATH.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'lbl_FILE_PATH
        '
        Me.lbl_FILE_PATH.AutoEllipsis = True
        Me.lbl_FILE_PATH.LabelFor = Nothing
        Me.lbl_FILE_PATH.Location = New System.Drawing.Point(5, 13)
        Me.lbl_FILE_PATH.Name = "lbl_FILE_PATH"
        Me.lbl_FILE_PATH.Size = New System.Drawing.Size(85, 22)
        Me.lbl_FILE_PATH.TabIndex = 93
        Me.lbl_FILE_PATH.Text = "File Path"
        Me.lbl_FILE_PATH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_FILE_PATH, "")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_FILE_PATH)
        Me.PanelControl1.Controls.Add(Me.btnFile)
        Me.PanelControl1.Controls.Add(Me.FILE_PATH)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 43)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1040, 47)
        Me.PanelControl1.TabIndex = 96
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.WG1)
        Me.PanelControl2.Location = New System.Drawing.Point(6, 96)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1040, 658)
        Me.PanelControl2.TabIndex = 97
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(2, 2)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit4, Me.ItemCheckEdit1, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit5})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(1036, 654)
        Me.WG1.TabIndex = 89
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2, Me.gridBand3, Me.gridBand4, Me.gridBand5, Me.gridBand6})
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.GV1_CUST_NM, Me.GV1_CUST_CD, Me.GV1_CUSTOMS_CD, Me.GV1_FWB_PIMA, Me.GV1_AMS_PIMA, Me.GV1_6CODE, Me.GV1_KTNET_AIR, Me.GV1_KTNET_SEA, Me.GV1_KTNET_NONE, Me.GV1_FTP_ID, Me.GV1_FTP_PW, Me.GV1_KLNET_AIR, Me.GV1_KLNET_SEA, Me.GV1_KLNET_NONE, Me.GV1_NACCS_ID, Me.GV1_NACCS_PW, Me.GV1_NACCS_CODE, Me.GV1_NACCS_EMAIL, Me.GV1_CHAIN_START_YMD})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 30
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsCustomization.AllowSort = False
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorzLines = False
        Me.GV1.OptionsView.ShowViewCaption = True
        Me.GV1.ViewCaption = " Excel Data"
        '
        'GridBand1
        '
        Me.GridBand1.Columns.Add(Me.GV1_CUST_NM)
        Me.GridBand1.Columns.Add(Me.GV1_CUST_CD)
        Me.GridBand1.Columns.Add(Me.GV1_CUSTOMS_CD)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 346
        Me.Localizer1.SetWordID(Me.GridBand1, "")
        '
        'GV1_CUST_NM
        '
        Me.GV1_CUST_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_NM.Caption = "업체명"
        Me.GV1_CUST_NM.FieldName = "CUST_NM"
        Me.GV1_CUST_NM.Name = "GV1_CUST_NM"
        Me.GV1_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_NM.Visible = True
        Me.GV1_CUST_NM.Width = 200
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "")
        '
        'GV1_CUST_CD
        '
        Me.GV1_CUST_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.Caption = "업체코드"
        Me.GV1_CUST_CD.FieldName = "CUST_CD"
        Me.GV1_CUST_CD.Name = "GV1_CUST_CD"
        Me.GV1_CUST_CD.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_CD.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_CD.Visible = True
        Me.GV1_CUST_CD.Width = 71
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "")
        '
        'GV1_CUSTOMS_CD
        '
        Me.GV1_CUSTOMS_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUSTOMS_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUSTOMS_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUSTOMS_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUSTOMS_CD.Caption = "세관코드"
        Me.GV1_CUSTOMS_CD.FieldName = "CUSTOMS_CD"
        Me.GV1_CUSTOMS_CD.Name = "GV1_CUSTOMS_CD"
        Me.GV1_CUSTOMS_CD.OptionsColumn.AllowEdit = False
        Me.GV1_CUSTOMS_CD.OptionsColumn.ReadOnly = True
        Me.GV1_CUSTOMS_CD.Visible = True
        Me.Localizer1.SetWordID(Me.GV1_CUSTOMS_CD, "")
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "KCNET"
        Me.gridBand2.Columns.Add(Me.GV1_FWB_PIMA)
        Me.gridBand2.Columns.Add(Me.GV1_AMS_PIMA)
        Me.gridBand2.Columns.Add(Me.GV1_6CODE)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.Width = 510
        Me.Localizer1.SetWordID(Me.gridBand2, "")
        '
        'GV1_FWB_PIMA
        '
        Me.GV1_FWB_PIMA.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FWB_PIMA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FWB_PIMA.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FWB_PIMA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FWB_PIMA.Caption = "FWB PIMA"
        Me.GV1_FWB_PIMA.FieldName = "FWB_PIMA"
        Me.GV1_FWB_PIMA.Name = "GV1_FWB_PIMA"
        Me.GV1_FWB_PIMA.OptionsColumn.AllowEdit = False
        Me.GV1_FWB_PIMA.OptionsColumn.ReadOnly = True
        Me.GV1_FWB_PIMA.Visible = True
        Me.GV1_FWB_PIMA.Width = 226
        Me.Localizer1.SetWordID(Me.GV1_FWB_PIMA, "")
        '
        'GV1_AMS_PIMA
        '
        Me.GV1_AMS_PIMA.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_AMS_PIMA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_AMS_PIMA.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_AMS_PIMA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_AMS_PIMA.Caption = "AMS PIMA"
        Me.GV1_AMS_PIMA.FieldName = "AMS_PIMA"
        Me.GV1_AMS_PIMA.Name = "GV1_AMS_PIMA"
        Me.GV1_AMS_PIMA.OptionsColumn.AllowEdit = False
        Me.GV1_AMS_PIMA.OptionsColumn.ReadOnly = True
        Me.GV1_AMS_PIMA.Visible = True
        Me.GV1_AMS_PIMA.Width = 209
        Me.Localizer1.SetWordID(Me.GV1_AMS_PIMA, "")
        '
        'GV1_6CODE
        '
        Me.GV1_6CODE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_6CODE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_6CODE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_6CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_6CODE.Caption = "6CODE"
        Me.GV1_6CODE.FieldName = "6CODE"
        Me.GV1_6CODE.Name = "GV1_6CODE"
        Me.GV1_6CODE.OptionsColumn.AllowEdit = False
        Me.GV1_6CODE.OptionsColumn.ReadOnly = True
        Me.GV1_6CODE.Visible = True
        Me.Localizer1.SetWordID(Me.GV1_6CODE, "")
        '
        'gridBand3
        '
        Me.gridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand3.Caption = "KTNET"
        Me.gridBand3.Columns.Add(Me.GV1_KTNET_AIR)
        Me.gridBand3.Columns.Add(Me.GV1_KTNET_SEA)
        Me.gridBand3.Columns.Add(Me.GV1_KTNET_NONE)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.Width = 406
        Me.Localizer1.SetWordID(Me.gridBand3, "")
        '
        'GV1_KTNET_AIR
        '
        Me.GV1_KTNET_AIR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_KTNET_AIR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KTNET_AIR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_KTNET_AIR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KTNET_AIR.Caption = "항공 발신인 식별자"
        Me.GV1_KTNET_AIR.FieldName = "KTNET_AIR"
        Me.GV1_KTNET_AIR.Name = "GV1_KTNET_AIR"
        Me.GV1_KTNET_AIR.OptionsColumn.AllowEdit = False
        Me.GV1_KTNET_AIR.OptionsColumn.ReadOnly = True
        Me.GV1_KTNET_AIR.Visible = True
        Me.GV1_KTNET_AIR.Width = 144
        Me.Localizer1.SetWordID(Me.GV1_KTNET_AIR, "")
        '
        'GV1_KTNET_SEA
        '
        Me.GV1_KTNET_SEA.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_KTNET_SEA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KTNET_SEA.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_KTNET_SEA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KTNET_SEA.Caption = "해운 발신인 식별자"
        Me.GV1_KTNET_SEA.FieldName = "KTNET_SEA"
        Me.GV1_KTNET_SEA.Name = "GV1_KTNET_SEA"
        Me.GV1_KTNET_SEA.OptionsColumn.AllowEdit = False
        Me.GV1_KTNET_SEA.OptionsColumn.ReadOnly = True
        Me.GV1_KTNET_SEA.Visible = True
        Me.GV1_KTNET_SEA.Width = 138
        Me.Localizer1.SetWordID(Me.GV1_KTNET_SEA, "")
        '
        'GV1_KTNET_NONE
        '
        Me.GV1_KTNET_NONE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_KTNET_NONE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KTNET_NONE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_KTNET_NONE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KTNET_NONE.Caption = "해운 미사용 식별자"
        Me.GV1_KTNET_NONE.FieldName = "KTNET_NONE"
        Me.GV1_KTNET_NONE.Name = "GV1_KTNET_NONE"
        Me.GV1_KTNET_NONE.OptionsColumn.AllowEdit = False
        Me.GV1_KTNET_NONE.OptionsColumn.ReadOnly = True
        Me.GV1_KTNET_NONE.Visible = True
        Me.GV1_KTNET_NONE.Width = 124
        Me.Localizer1.SetWordID(Me.GV1_KTNET_NONE, "")
        '
        'gridBand4
        '
        Me.gridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand4.Caption = "KTNET FTP LOGIN 정보"
        Me.gridBand4.Columns.Add(Me.GV1_FTP_ID)
        Me.gridBand4.Columns.Add(Me.GV1_FTP_PW)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.Width = 208
        Me.Localizer1.SetWordID(Me.gridBand4, "")
        '
        'GV1_FTP_ID
        '
        Me.GV1_FTP_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FTP_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FTP_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FTP_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FTP_ID.Caption = "ID"
        Me.GV1_FTP_ID.FieldName = "FTP_ID"
        Me.GV1_FTP_ID.Name = "GV1_FTP_ID"
        Me.GV1_FTP_ID.OptionsColumn.AllowEdit = False
        Me.GV1_FTP_ID.OptionsColumn.ReadOnly = True
        Me.GV1_FTP_ID.Visible = True
        Me.GV1_FTP_ID.Width = 114
        Me.Localizer1.SetWordID(Me.GV1_FTP_ID, "")
        '
        'GV1_FTP_PW
        '
        Me.GV1_FTP_PW.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FTP_PW.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FTP_PW.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FTP_PW.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FTP_PW.Caption = "PW"
        Me.GV1_FTP_PW.FieldName = "FTP_PW"
        Me.GV1_FTP_PW.Name = "GV1_FTP_PW"
        Me.GV1_FTP_PW.OptionsColumn.AllowEdit = False
        Me.GV1_FTP_PW.OptionsColumn.ReadOnly = True
        Me.GV1_FTP_PW.Visible = True
        Me.GV1_FTP_PW.Width = 94
        Me.Localizer1.SetWordID(Me.GV1_FTP_PW, "")
        '
        'gridBand5
        '
        Me.gridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand5.Caption = "KLNET"
        Me.gridBand5.Columns.Add(Me.GV1_KLNET_AIR)
        Me.gridBand5.Columns.Add(Me.GV1_KLNET_SEA)
        Me.gridBand5.Columns.Add(Me.GV1_KLNET_NONE)
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.Width = 394
        Me.Localizer1.SetWordID(Me.gridBand5, "")
        '
        'GV1_KLNET_AIR
        '
        Me.GV1_KLNET_AIR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_KLNET_AIR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KLNET_AIR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_KLNET_AIR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KLNET_AIR.Caption = "항공 발신인 식별자"
        Me.GV1_KLNET_AIR.FieldName = "KLNET_AIR"
        Me.GV1_KLNET_AIR.Name = "GV1_KLNET_AIR"
        Me.GV1_KLNET_AIR.OptionsColumn.AllowEdit = False
        Me.GV1_KLNET_AIR.OptionsColumn.ReadOnly = True
        Me.GV1_KLNET_AIR.Visible = True
        Me.GV1_KLNET_AIR.Width = 133
        Me.Localizer1.SetWordID(Me.GV1_KLNET_AIR, "")
        '
        'GV1_KLNET_SEA
        '
        Me.GV1_KLNET_SEA.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_KLNET_SEA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KLNET_SEA.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_KLNET_SEA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KLNET_SEA.Caption = "해운 발신인 식별자"
        Me.GV1_KLNET_SEA.FieldName = "KLNET_SEA"
        Me.GV1_KLNET_SEA.Name = "GV1_KLNET_SEA"
        Me.GV1_KLNET_SEA.OptionsColumn.AllowEdit = False
        Me.GV1_KLNET_SEA.OptionsColumn.ReadOnly = True
        Me.GV1_KLNET_SEA.Visible = True
        Me.GV1_KLNET_SEA.Width = 137
        Me.Localizer1.SetWordID(Me.GV1_KLNET_SEA, "")
        '
        'GV1_KLNET_NONE
        '
        Me.GV1_KLNET_NONE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_KLNET_NONE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KLNET_NONE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_KLNET_NONE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_KLNET_NONE.Caption = "해운 미사용 식별자"
        Me.GV1_KLNET_NONE.FieldName = "KLNET_NONE"
        Me.GV1_KLNET_NONE.Name = "GV1_KLNET_NONE"
        Me.GV1_KLNET_NONE.OptionsColumn.AllowEdit = False
        Me.GV1_KLNET_NONE.OptionsColumn.ReadOnly = True
        Me.GV1_KLNET_NONE.Visible = True
        Me.GV1_KLNET_NONE.Width = 124
        Me.Localizer1.SetWordID(Me.GV1_KLNET_NONE, "")
        '
        'gridBand6
        '
        Me.gridBand6.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand6.Caption = "AFR 정보"
        Me.gridBand6.Columns.Add(Me.GV1_NACCS_ID)
        Me.gridBand6.Columns.Add(Me.GV1_NACCS_PW)
        Me.gridBand6.Columns.Add(Me.GV1_NACCS_CODE)
        Me.gridBand6.Columns.Add(Me.GV1_NACCS_EMAIL)
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.Width = 703
        Me.Localizer1.SetWordID(Me.gridBand6, "")
        '
        'GV1_NACCS_ID
        '
        Me.GV1_NACCS_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_NACCS_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_NACCS_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_NACCS_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_NACCS_ID.Caption = "NACCS ID"
        Me.GV1_NACCS_ID.FieldName = "NACCS_ID"
        Me.GV1_NACCS_ID.Name = "GV1_NACCS_ID"
        Me.GV1_NACCS_ID.OptionsColumn.AllowEdit = False
        Me.GV1_NACCS_ID.OptionsColumn.ReadOnly = True
        Me.GV1_NACCS_ID.Visible = True
        Me.GV1_NACCS_ID.Width = 99
        Me.Localizer1.SetWordID(Me.GV1_NACCS_ID, "")
        '
        'GV1_NACCS_PW
        '
        Me.GV1_NACCS_PW.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_NACCS_PW.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_NACCS_PW.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_NACCS_PW.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_NACCS_PW.Caption = "NACCS PW"
        Me.GV1_NACCS_PW.FieldName = "NACCS_PW"
        Me.GV1_NACCS_PW.Name = "GV1_NACCS_PW"
        Me.GV1_NACCS_PW.OptionsColumn.AllowEdit = False
        Me.GV1_NACCS_PW.OptionsColumn.ReadOnly = True
        Me.GV1_NACCS_PW.Visible = True
        Me.GV1_NACCS_PW.Width = 105
        Me.Localizer1.SetWordID(Me.GV1_NACCS_PW, "")
        '
        'GV1_NACCS_CODE
        '
        Me.GV1_NACCS_CODE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_NACCS_CODE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_NACCS_CODE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_NACCS_CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_NACCS_CODE.Caption = "NACCS CODE"
        Me.GV1_NACCS_CODE.FieldName = "NACCS_CODE"
        Me.GV1_NACCS_CODE.Name = "GV1_NACCS_CODE"
        Me.GV1_NACCS_CODE.OptionsColumn.AllowEdit = False
        Me.GV1_NACCS_CODE.OptionsColumn.ReadOnly = True
        Me.GV1_NACCS_CODE.Visible = True
        Me.GV1_NACCS_CODE.Width = 99
        Me.Localizer1.SetWordID(Me.GV1_NACCS_CODE, "")
        '
        'GV1_NACCS_EMAIL
        '
        Me.GV1_NACCS_EMAIL.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_NACCS_EMAIL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_NACCS_EMAIL.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_NACCS_EMAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_NACCS_EMAIL.Caption = "E-mail"
        Me.GV1_NACCS_EMAIL.FieldName = "NACCS_EMAIL"
        Me.GV1_NACCS_EMAIL.Name = "GV1_NACCS_EMAIL"
        Me.GV1_NACCS_EMAIL.OptionsColumn.AllowEdit = False
        Me.GV1_NACCS_EMAIL.OptionsColumn.ReadOnly = True
        Me.GV1_NACCS_EMAIL.Visible = True
        Me.GV1_NACCS_EMAIL.Width = 400
        Me.Localizer1.SetWordID(Me.GV1_NACCS_EMAIL, "")
        '
        'GV1_CHAIN_START_YMD
        '
        Me.GV1_CHAIN_START_YMD.Caption = "CHAIN 전환일자"
        Me.GV1_CHAIN_START_YMD.FieldName = "CHAIN_START_YMD"
        Me.GV1_CHAIN_START_YMD.Name = "GV1_CHAIN_START_YMD"
        Me.GV1_CHAIN_START_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_CHAIN_START_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_CHAIN_START_YMD.Visible = True
        Me.GV1_CHAIN_START_YMD.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_CHAIN_START_YMD, "")
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "#,###,##0.000"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'ItemCheckEdit1
        '
        Me.ItemCheckEdit1.AutoHeight = False
        Me.ItemCheckEdit1.Name = "ItemCheckEdit1"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "###,###,##0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.MaxLength = 8
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
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
        'EchUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 766)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "EchUpload"
        Me.Text = "ELVIS CHAIN Upload"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents iconImages As DevExpress.Utils.ImageCollection
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RepositoryItemDateBoxEdit1 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFile As YJIT.SC.UI.SCControls.Button
    Public WithEvents FILE_PATH As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents lbl_FILE_PATH As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GV1_CUST_CD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_CUSTOMS_CD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_FWB_PIMA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_AMS_PIMA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_6CODE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_KTNET_AIR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_KTNET_SEA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_KTNET_NONE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_FTP_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_FTP_PW As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_KLNET_AIR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_KLNET_SEA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_KLNET_NONE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_NACCS_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_NACCS_PW As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_NACCS_CODE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_NACCS_EMAIL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnClear As YJIT.SC.UI.SCControls.Button
    Private WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV1_CUST_NM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV1_CHAIN_START_YMD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
