<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EvbChargeSet
    Inherits YJIT.SC.UI.SCView

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EvbChargeSet))
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.TablePanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_CHAG_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_BASE_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmtFormat = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_BASE_TAX_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TAX_PRICE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CRD_PRICE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV7_CheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.LicenseNo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TablePanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExpWg1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnQuickWg1 = New YJIT.SC.UI.SCControls.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New YJIT.SC.UI.SCControls.Button()
        Me.Button4 = New YJIT.SC.UI.SCControls.Button()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        Me.TablePanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmtFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV7_CheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicenseNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TablePanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "#,##0.0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.TablePanel3, "")
        Me.Localizer1.SetWordID(Me.btnSearch, "검색(&A)")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_CHAG_CD, "코드")
        Me.Localizer1.SetWordID(Me.GV1_BASE_AMT, "기본 요금")
        Me.Localizer1.SetWordID(Me.GV1_BASE_TAX_CNT, "기본건수")
        Me.Localizer1.SetWordID(Me.GV1_TAX_PRICE, "세금계산서 단가")
        Me.Localizer1.SetWordID(Me.GV1_CRD_PRICE, "입금표 단가")
        Me.Localizer1.SetWordID(Me.TablePanel1, "")
        Me.Localizer1.SetWordID(Me.btnExpWg1, "btnExpWg1")
        Me.Localizer1.SetWordID(Me.btnQuickWg1, "btnQuickWg1")
        Me.Localizer1.SetWordID(Me.Panel2, "")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel1, "")
        Me.Localizer1.SetWordID(Me.Button3, "btnExpWg1")
        Me.Localizer1.SetWordID(Me.Button4, "btnQuickWg1")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.TablePanel3)
        Me.palAutoButton.Location = New System.Drawing.Point(3, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(462, 35)
        Me.palAutoButton.TabIndex = 108
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'TablePanel3
        '
        Me.TablePanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablePanel3.ColumnCount = 3
        Me.TablePanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TablePanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TablePanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TablePanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TablePanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TablePanel3.Controls.Add(Me.btnSearch, 1, 0)
        Me.TablePanel3.Location = New System.Drawing.Point(234, 2)
        Me.TablePanel3.Name = "TablePanel3"
        Me.TablePanel3.RowCount = 1
        Me.TablePanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TablePanel3.Size = New System.Drawing.Size(224, 31)
        Me.TablePanel3.TabIndex = 211
        Me.Localizer1.SetWordID(Me.TablePanel3, "")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(143, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 25)
        Me.btnSearch.TabIndex = 100
        Me.btnSearch.Text = "검색(&A)"
        Me.Localizer1.SetWordID(Me.btnSearch, "검색(&A)")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.WG1)
        Me.Panel1.Controls.Add(Me.TablePanel1)
        Me.Panel1.Location = New System.Drawing.Point(3, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 213)
        Me.Panel1.TabIndex = 109
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(0, 0)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GV7_CheckEdit, Me.LicenseNo, Me.AmtFormat})
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(462, 213)
        Me.WG1.TabIndex = 7
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_CHAG_CD, Me.GV1_BASE_AMT, Me.GV1_BASE_TAX_CNT, Me.GV1_TAX_PRICE, Me.GV1_CRD_PRICE})
        Me.GV1.CustomizationFormBounds = New System.Drawing.Rectangle(892, 567, 216, 185)
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.RowHeight = 10
        Me.GV1.ViewCaption = " 문서 리스트"
        '
        'GV1_CHAG_CD
        '
        Me.GV1_CHAG_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CHAG_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CHAG_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CHAG_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CHAG_CD.Caption = "코드"
        Me.GV1_CHAG_CD.FieldName = "CHAG_CD"
        Me.GV1_CHAG_CD.Name = "GV1_CHAG_CD"
        Me.GV1_CHAG_CD.OptionsColumn.AllowEdit = False
        Me.GV1_CHAG_CD.OptionsColumn.ReadOnly = True
        Me.GV1_CHAG_CD.Visible = True
        Me.GV1_CHAG_CD.VisibleIndex = 0
        Me.GV1_CHAG_CD.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_CHAG_CD, "코드")
        '
        'GV1_BASE_AMT
        '
        Me.GV1_BASE_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BASE_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_BASE_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BASE_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BASE_AMT.Caption = "기본 요금"
        Me.GV1_BASE_AMT.ColumnEdit = Me.AmtFormat
        Me.GV1_BASE_AMT.FieldName = "BASE_AMT"
        Me.GV1_BASE_AMT.Name = "GV1_BASE_AMT"
        Me.GV1_BASE_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_BASE_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_BASE_AMT.Visible = True
        Me.GV1_BASE_AMT.VisibleIndex = 1
        Me.GV1_BASE_AMT.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_BASE_AMT, "기본 요금")
        '
        'AmtFormat
        '
        Me.AmtFormat.AutoHeight = False
        Me.AmtFormat.Mask.EditMask = "###,###,###,##0"
        Me.AmtFormat.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.AmtFormat.Mask.UseMaskAsDisplayFormat = True
        Me.AmtFormat.Name = "AmtFormat"
        '
        'GV1_BASE_TAX_CNT
        '
        Me.GV1_BASE_TAX_CNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BASE_TAX_CNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_BASE_TAX_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BASE_TAX_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BASE_TAX_CNT.Caption = "기본건수"
        Me.GV1_BASE_TAX_CNT.ColumnEdit = Me.AmtFormat
        Me.GV1_BASE_TAX_CNT.FieldName = "BASE_TAX_CNT"
        Me.GV1_BASE_TAX_CNT.Name = "GV1_BASE_TAX_CNT"
        Me.GV1_BASE_TAX_CNT.OptionsColumn.AllowEdit = False
        Me.GV1_BASE_TAX_CNT.OptionsColumn.ReadOnly = True
        Me.GV1_BASE_TAX_CNT.Visible = True
        Me.GV1_BASE_TAX_CNT.VisibleIndex = 2
        Me.GV1_BASE_TAX_CNT.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_BASE_TAX_CNT, "기본건수")
        '
        'GV1_TAX_PRICE
        '
        Me.GV1_TAX_PRICE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TAX_PRICE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_TAX_PRICE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TAX_PRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TAX_PRICE.Caption = "세금계산서 단가"
        Me.GV1_TAX_PRICE.ColumnEdit = Me.AmtFormat
        Me.GV1_TAX_PRICE.FieldName = "TAX_PRICE"
        Me.GV1_TAX_PRICE.Name = "GV1_TAX_PRICE"
        Me.GV1_TAX_PRICE.OptionsColumn.AllowEdit = False
        Me.GV1_TAX_PRICE.OptionsColumn.ReadOnly = True
        Me.GV1_TAX_PRICE.Visible = True
        Me.GV1_TAX_PRICE.VisibleIndex = 3
        Me.GV1_TAX_PRICE.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_TAX_PRICE, "세금계산서 단가")
        '
        'GV1_CRD_PRICE
        '
        Me.GV1_CRD_PRICE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CRD_PRICE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_CRD_PRICE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CRD_PRICE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CRD_PRICE.Caption = "입금표 단가"
        Me.GV1_CRD_PRICE.ColumnEdit = Me.AmtFormat
        Me.GV1_CRD_PRICE.FieldName = "CRD_PRICE"
        Me.GV1_CRD_PRICE.Name = "GV1_CRD_PRICE"
        Me.GV1_CRD_PRICE.OptionsColumn.AllowEdit = False
        Me.GV1_CRD_PRICE.OptionsColumn.ReadOnly = True
        Me.GV1_CRD_PRICE.Visible = True
        Me.GV1_CRD_PRICE.VisibleIndex = 4
        Me.GV1_CRD_PRICE.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_CRD_PRICE, "입금표 단가")
        '
        'GV7_CheckEdit
        '
        Me.GV7_CheckEdit.AutoHeight = False
        Me.GV7_CheckEdit.Name = "GV7_CheckEdit"
        Me.GV7_CheckEdit.ValueChecked = "Y"
        Me.GV7_CheckEdit.ValueUnchecked = "N"
        '
        'LicenseNo
        '
        Me.LicenseNo.AutoHeight = False
        Me.LicenseNo.Mask.EditMask = "###-##-#####"
        Me.LicenseNo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.LicenseNo.Mask.UseMaskAsDisplayFormat = True
        Me.LicenseNo.Name = "LicenseNo"
        '
        'TablePanel1
        '
        Me.TablePanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablePanel1.ColumnCount = 4
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TablePanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TablePanel1.Controls.Add(Me.btnExpWg1, 1, 0)
        Me.TablePanel1.Controls.Add(Me.btnQuickWg1, 2, 0)
        Me.TablePanel1.Location = New System.Drawing.Point(1394, 69)
        Me.TablePanel1.Name = "TablePanel1"
        Me.TablePanel1.RowCount = 1
        Me.TablePanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TablePanel1.Size = New System.Drawing.Size(0, 30)
        Me.TablePanel1.TabIndex = 209
        Me.Localizer1.SetWordID(Me.TablePanel1, "")
        '
        'btnExpWg1
        '
        Me.btnExpWg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExpWg1.Image = CType(resources.GetObject("btnExpWg1.Image"), System.Drawing.Image)
        Me.btnExpWg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExpWg1.Location = New System.Drawing.Point(-60, 3)
        Me.btnExpWg1.Name = "btnExpWg1"
        Me.btnExpWg1.Size = New System.Drawing.Size(24, 24)
        Me.btnExpWg1.TabIndex = 212
        Me.btnExpWg1.Text = "btnExpWg1"
        Me.Localizer1.SetWordID(Me.btnExpWg1, "btnExpWg1")
        '
        'btnQuickWg1
        '
        Me.btnQuickWg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnQuickWg1.Image = CType(resources.GetObject("btnQuickWg1.Image"), System.Drawing.Image)
        Me.btnQuickWg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuickWg1.Location = New System.Drawing.Point(-30, 3)
        Me.btnQuickWg1.Name = "btnQuickWg1"
        Me.btnQuickWg1.Size = New System.Drawing.Size(24, 24)
        Me.btnQuickWg1.TabIndex = 213
        Me.btnQuickWg1.Text = "btnQuickWg1"
        Me.Localizer1.SetWordID(Me.btnQuickWg1, "btnQuickWg1")
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Location = New System.Drawing.Point(481, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 174)
        Me.Panel2.TabIndex = 210
        Me.Localizer1.SetWordID(Me.Panel2, "")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1394, 69)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(0, 30)
        Me.TableLayoutPanel1.TabIndex = 209
        Me.Localizer1.SetWordID(Me.TableLayoutPanel1, "")
        '
        'Button3
        '
        Me.Button3.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.Button3.Location = New System.Drawing.Point(-60, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 24)
        Me.Button3.TabIndex = 212
        Me.Button3.Text = "Button3"
        Me.Localizer1.SetWordID(Me.Button3, "btnExpWg1")
        '
        'Button4
        '
        Me.Button4.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.Button4.Location = New System.Drawing.Point(-30, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 24)
        Me.Button4.TabIndex = 213
        Me.Button4.Text = "Button4"
        Me.Localizer1.SetWordID(Me.Button4, "btnQuickWg1")
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'EvbChargeSet
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(468, 254)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "EvbChargeSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "요금표 관리"
        Me.Localizer1.SetWordID(Me, "요금표 관리")
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.TablePanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmtFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV7_CheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicenseNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TablePanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TablePanel1 As TableLayoutPanel
    Friend WithEvents btnExpWg1 As UI.SCControls.Button
    Friend WithEvents btnQuickWg1 As UI.SCControls.Button
    Public WithEvents WG1 As UI.SCControls.WebGrid
    Friend WithEvents GV7_CheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV1_CHAG_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BASE_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BASE_TAX_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LicenseNo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TablePanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button3 As UI.SCControls.Button
    Friend WithEvents Button4 As UI.SCControls.Button
    Friend WithEvents btnSearch As UI.SCControls.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AmtFormat As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_TAX_PRICE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CRD_PRICE As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
