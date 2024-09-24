<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysDBMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SysDBMgt))
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnExecute = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_CHK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SQL_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SQL_STR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GV1_APPLY_SOURCE_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_APPLY_SOURCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV2_CHK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DB_IP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DB_PORT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DB_SID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_USR_PWD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DOMAIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CTRY_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_APPLY_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_RESULT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WH_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WH_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WH_ADDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WH_PIC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FAX_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_SVC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SQL_STR = New YJIT.SC.UI.SCControls.TextBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.S_DB_LINK = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_APPLY_SOURCE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.SplitContainerControl4 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.GV1_DBLINK = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SplitContainerControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit3.ValueUnchecked = "N"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "N"
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnExecute)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(3, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(998, 35)
        Me.palAutoButton.TabIndex = 1
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExecute.Image = CType(resources.GetObject("btnExecute.Image"), System.Drawing.Image)
        Me.btnExecute.Location = New System.Drawing.Point(913, 5)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(80, 25)
        Me.btnExecute.TabIndex = 6
        Me.btnExecute.Text = "Execute"
        Me.Localizer1.SetWordID(Me.btnExecute, "Execute")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(828, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 25)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnExecute, "Execute")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_CHK, "V")
        Me.Localizer1.SetWordID(Me.GV1_SQL_ID, "ID")
        Me.Localizer1.SetWordID(Me.GV1_TITLE, "Title")
        Me.Localizer1.SetWordID(Me.GV1_SQL_STR, "SQL")
        Me.Localizer1.SetWordID(Me.GV1_APPLY_SOURCE_NM, "Apply Source")
        Me.Localizer1.SetWordID(Me.GV1_APPLY_SOURCE, "APPLY_SOURCE")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GV2_CHK, "V")
        Me.Localizer1.SetWordID(Me.GV2_CUST_NM, "거래처")
        Me.Localizer1.SetWordID(Me.GV2_DB_IP, "IP")
        Me.Localizer1.SetWordID(Me.GV2_DB_PORT, "Port")
        Me.Localizer1.SetWordID(Me.GV2_DB_SID, "SID")
        Me.Localizer1.SetWordID(Me.GV2_USR_ID, "ID")
        Me.Localizer1.SetWordID(Me.GV2_USR_PWD, "Password")
        Me.Localizer1.SetWordID(Me.GV2_DOMAIN, "Domain")
        Me.Localizer1.SetWordID(Me.GV2_CTRY_CD, "국가")
        Me.Localizer1.SetWordID(Me.GV2_APPLY_YN, "Apply")
        Me.Localizer1.SetWordID(Me.GV2_RESULT, "Result")
        Me.Localizer1.SetWordID(Me.GV1_WH_CD, "Warehouse Code")
        Me.Localizer1.SetWordID(Me.GV1_WH_NM, "Warehouse Name")
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "Activity")
        Me.Localizer1.SetWordID(Me.GV1_WH_ADDR, "Address")
        Me.Localizer1.SetWordID(Me.GV1_WH_PIC, "PIC")
        Me.Localizer1.SetWordID(Me.GV1_FAX_NO, "FAX")
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "TEL")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "Service")
        Me.Localizer1.SetWordID(Me.XtraTabControl1, "")
        Me.Localizer1.SetWordID(Me.XtraTabPage1, "Domain List")
        Me.Localizer1.SetWordID(Me.XtraTabPage2, "Sql")
        Me.Localizer1.SetWordID(Me.SQL_STR, "")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.Label2, "시스템 (DB Link)")
        Me.Localizer1.SetWordID(Me.S_DB_LINK, "ELVIS")
        Me.Localizer1.SetWordID(Me.S_APPLY_SOURCE, "지정안함")
        Me.Localizer1.SetWordID(Me.Label4, "Apply Source")
        Me.Localizer1.SetWordID(Me.SplitContainerControl4, "SplitContainerControl4")
        Me.Localizer1.SetWordID(Me.GV1_DBLINK, "DB_LINK")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.DeleteRowConfirmation = False
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG1.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(0, 0)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit1})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(401, 642)
        Me.WG1.TabIndex = 7
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_CHK, Me.GV1_SQL_ID, Me.GV1_TITLE, Me.GV1_SQL_STR, Me.GV1_APPLY_SOURCE_NM, Me.GV1_APPLY_SOURCE, Me.GV1_DBLINK})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsCustomization.AllowColumnMoving = False
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GV1_CHK
        '
        Me.GV1_CHK.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV1_CHK.AppearanceCell.Options.UseFont = True
        Me.GV1_CHK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CHK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CHK.Caption = "V"
        Me.GV1_CHK.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV1_CHK.FieldName = "CHK"
        Me.GV1_CHK.Name = "GV1_CHK"
        Me.GV1_CHK.OptionsColumn.AllowSize = False
        Me.GV1_CHK.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1_CHK.Visible = True
        Me.GV1_CHK.VisibleIndex = 0
        Me.GV1_CHK.Width = 30
        Me.Localizer1.SetWordID(Me.GV1_CHK, "V")
        '
        'GV1_SQL_ID
        '
        Me.GV1_SQL_ID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV1_SQL_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_SQL_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SQL_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SQL_ID.Caption = "ID"
        Me.GV1_SQL_ID.FieldName = "SQL_ID"
        Me.GV1_SQL_ID.Name = "GV1_SQL_ID"
        Me.GV1_SQL_ID.OptionsColumn.AllowEdit = False
        Me.GV1_SQL_ID.OptionsColumn.ReadOnly = True
        Me.GV1_SQL_ID.Visible = True
        Me.GV1_SQL_ID.VisibleIndex = 1
        Me.GV1_SQL_ID.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_SQL_ID, "")
        '
        'GV1_TITLE
        '
        Me.GV1_TITLE.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV1_TITLE.AppearanceCell.Options.UseFont = True
        Me.GV1_TITLE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TITLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TITLE.Caption = "Title"
        Me.GV1_TITLE.FieldName = "TITLE"
        Me.GV1_TITLE.Name = "GV1_TITLE"
        Me.GV1_TITLE.OptionsColumn.AllowEdit = False
        Me.GV1_TITLE.OptionsColumn.ReadOnly = True
        Me.GV1_TITLE.Visible = True
        Me.GV1_TITLE.VisibleIndex = 2
        Me.GV1_TITLE.Width = 189
        Me.Localizer1.SetWordID(Me.GV1_TITLE, "")
        '
        'GV1_SQL_STR
        '
        Me.GV1_SQL_STR.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV1_SQL_STR.AppearanceCell.Options.UseFont = True
        Me.GV1_SQL_STR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SQL_STR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SQL_STR.Caption = "SQL"
        Me.GV1_SQL_STR.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GV1_SQL_STR.FieldName = "SQL_STR"
        Me.GV1_SQL_STR.Name = "GV1_SQL_STR"
        Me.GV1_SQL_STR.OptionsColumn.AllowEdit = False
        Me.GV1_SQL_STR.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1_SQL_STR.OptionsColumn.ReadOnly = True
        Me.GV1_SQL_STR.Width = 200
        Me.Localizer1.SetWordID(Me.GV1_SQL_STR, "")
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.RepositoryItemMemoExEdit1.ReadOnly = True
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'GV1_APPLY_SOURCE_NM
        '
        Me.GV1_APPLY_SOURCE_NM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV1_APPLY_SOURCE_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_APPLY_SOURCE_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_APPLY_SOURCE_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_APPLY_SOURCE_NM.Caption = "Apply Source"
        Me.GV1_APPLY_SOURCE_NM.FieldName = "APPLY_SOURCE_NM"
        Me.GV1_APPLY_SOURCE_NM.Name = "GV1_APPLY_SOURCE_NM"
        Me.GV1_APPLY_SOURCE_NM.OptionsColumn.AllowEdit = False
        Me.GV1_APPLY_SOURCE_NM.OptionsColumn.ReadOnly = True
        Me.GV1_APPLY_SOURCE_NM.Visible = True
        Me.GV1_APPLY_SOURCE_NM.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV1_APPLY_SOURCE_NM, "")
        '
        'GV1_APPLY_SOURCE
        '
        Me.GV1_APPLY_SOURCE.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV1_APPLY_SOURCE.AppearanceCell.Options.UseFont = True
        Me.GV1_APPLY_SOURCE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_APPLY_SOURCE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_APPLY_SOURCE.Caption = "APPLY_SOURCE"
        Me.GV1_APPLY_SOURCE.FieldName = "APPLY_SOURCE"
        Me.GV1_APPLY_SOURCE.Name = "GV1_APPLY_SOURCE"
        Me.Localizer1.SetWordID(Me.GV1_APPLY_SOURCE, "")
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.DeleteRowConfirmation = False
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(0, 0)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(923, 613)
        Me.WG2.TabIndex = 8
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV2_CHK, Me.GV2_CUST_NM, Me.GV2_DB_IP, Me.GV2_DB_PORT, Me.GV2_DB_SID, Me.GV2_USR_ID, Me.GV2_USR_PWD, Me.GV2_DOMAIN, Me.GV2_CTRY_CD, Me.GV2_APPLY_YN, Me.GV2_RESULT})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsCustomization.AllowColumnMoving = False
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GV2_CHK
        '
        Me.GV2_CHK.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_CHK.AppearanceCell.Options.UseFont = True
        Me.GV2_CHK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CHK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CHK.Caption = "V"
        Me.GV2_CHK.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.GV2_CHK.FieldName = "CHK"
        Me.GV2_CHK.Name = "GV2_CHK"
        Me.GV2_CHK.OptionsColumn.AllowSize = False
        Me.GV2_CHK.Visible = True
        Me.GV2_CHK.VisibleIndex = 0
        Me.GV2_CHK.Width = 30
        Me.Localizer1.SetWordID(Me.GV2_CHK, "")
        '
        'GV2_CUST_NM
        '
        Me.GV2_CUST_NM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_CUST_NM.AppearanceCell.Options.UseFont = True
        Me.GV2_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUST_NM.Caption = "거래처"
        Me.GV2_CUST_NM.FieldName = "CUST_NM"
        Me.GV2_CUST_NM.Name = "GV2_CUST_NM"
        Me.GV2_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV2_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV2_CUST_NM.Visible = True
        Me.GV2_CUST_NM.VisibleIndex = 1
        Me.GV2_CUST_NM.Width = 281
        Me.Localizer1.SetWordID(Me.GV2_CUST_NM, "")
        '
        'GV2_DB_IP
        '
        Me.GV2_DB_IP.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_DB_IP.AppearanceCell.Options.UseFont = True
        Me.GV2_DB_IP.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DB_IP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DB_IP.Caption = "IP"
        Me.GV2_DB_IP.FieldName = "DB_IP"
        Me.GV2_DB_IP.Name = "GV2_DB_IP"
        Me.GV2_DB_IP.OptionsColumn.AllowEdit = False
        Me.GV2_DB_IP.OptionsColumn.ReadOnly = True
        Me.GV2_DB_IP.Visible = True
        Me.GV2_DB_IP.VisibleIndex = 2
        Me.GV2_DB_IP.Width = 120
        Me.Localizer1.SetWordID(Me.GV2_DB_IP, "")
        '
        'GV2_DB_PORT
        '
        Me.GV2_DB_PORT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_DB_PORT.AppearanceCell.Options.UseFont = True
        Me.GV2_DB_PORT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DB_PORT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DB_PORT.Caption = "Port"
        Me.GV2_DB_PORT.FieldName = "DB_PORT"
        Me.GV2_DB_PORT.Name = "GV2_DB_PORT"
        Me.GV2_DB_PORT.OptionsColumn.AllowEdit = False
        Me.GV2_DB_PORT.OptionsColumn.ReadOnly = True
        Me.GV2_DB_PORT.Visible = True
        Me.GV2_DB_PORT.VisibleIndex = 3
        Me.GV2_DB_PORT.Width = 45
        Me.Localizer1.SetWordID(Me.GV2_DB_PORT, "")
        '
        'GV2_DB_SID
        '
        Me.GV2_DB_SID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_DB_SID.AppearanceCell.Options.UseFont = True
        Me.GV2_DB_SID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DB_SID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DB_SID.Caption = "SID"
        Me.GV2_DB_SID.FieldName = "DB_SID"
        Me.GV2_DB_SID.Name = "GV2_DB_SID"
        Me.GV2_DB_SID.OptionsColumn.AllowEdit = False
        Me.GV2_DB_SID.OptionsColumn.ReadOnly = True
        Me.GV2_DB_SID.Visible = True
        Me.GV2_DB_SID.VisibleIndex = 4
        Me.GV2_DB_SID.Width = 49
        Me.Localizer1.SetWordID(Me.GV2_DB_SID, "")
        '
        'GV2_USR_ID
        '
        Me.GV2_USR_ID.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_USR_ID.AppearanceCell.Options.UseFont = True
        Me.GV2_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_USR_ID.Caption = "ID"
        Me.GV2_USR_ID.FieldName = "USR_ID"
        Me.GV2_USR_ID.Name = "GV2_USR_ID"
        Me.GV2_USR_ID.OptionsColumn.AllowEdit = False
        Me.GV2_USR_ID.OptionsColumn.ReadOnly = True
        Me.GV2_USR_ID.Visible = True
        Me.GV2_USR_ID.VisibleIndex = 5
        Me.GV2_USR_ID.Width = 89
        Me.Localizer1.SetWordID(Me.GV2_USR_ID, "")
        '
        'GV2_USR_PWD
        '
        Me.GV2_USR_PWD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_USR_PWD.AppearanceCell.Options.UseFont = True
        Me.GV2_USR_PWD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_USR_PWD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_USR_PWD.Caption = "Password"
        Me.GV2_USR_PWD.FieldName = "USR_PWD"
        Me.GV2_USR_PWD.Name = "GV2_USR_PWD"
        Me.GV2_USR_PWD.OptionsColumn.AllowEdit = False
        Me.GV2_USR_PWD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV2_USR_PWD, "")
        '
        'GV2_DOMAIN
        '
        Me.GV2_DOMAIN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_DOMAIN.AppearanceCell.Options.UseFont = True
        Me.GV2_DOMAIN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DOMAIN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DOMAIN.Caption = "Domain"
        Me.GV2_DOMAIN.FieldName = "DOMAIN"
        Me.GV2_DOMAIN.Name = "GV2_DOMAIN"
        Me.GV2_DOMAIN.OptionsColumn.AllowEdit = False
        Me.GV2_DOMAIN.OptionsColumn.ReadOnly = True
        Me.GV2_DOMAIN.Visible = True
        Me.GV2_DOMAIN.VisibleIndex = 6
        Me.GV2_DOMAIN.Width = 134
        Me.Localizer1.SetWordID(Me.GV2_DOMAIN, "")
        '
        'GV2_CTRY_CD
        '
        Me.GV2_CTRY_CD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_CTRY_CD.AppearanceCell.Options.UseFont = True
        Me.GV2_CTRY_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_CTRY_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CTRY_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CTRY_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CTRY_CD.Caption = "국가"
        Me.GV2_CTRY_CD.FieldName = "CTRY_CD"
        Me.GV2_CTRY_CD.Name = "GV2_CTRY_CD"
        Me.GV2_CTRY_CD.OptionsColumn.AllowEdit = False
        Me.GV2_CTRY_CD.OptionsColumn.ReadOnly = True
        Me.GV2_CTRY_CD.Visible = True
        Me.GV2_CTRY_CD.VisibleIndex = 7
        Me.GV2_CTRY_CD.Width = 60
        Me.Localizer1.SetWordID(Me.GV2_CTRY_CD, "")
        '
        'GV2_APPLY_YN
        '
        Me.GV2_APPLY_YN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_APPLY_YN.AppearanceCell.Options.UseFont = True
        Me.GV2_APPLY_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_APPLY_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_APPLY_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_APPLY_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_APPLY_YN.Caption = "Apply"
        Me.GV2_APPLY_YN.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.GV2_APPLY_YN.FieldName = "APPLY_YN"
        Me.GV2_APPLY_YN.Name = "GV2_APPLY_YN"
        Me.GV2_APPLY_YN.OptionsColumn.AllowEdit = False
        Me.GV2_APPLY_YN.OptionsColumn.ReadOnly = True
        Me.GV2_APPLY_YN.Visible = True
        Me.GV2_APPLY_YN.VisibleIndex = 8
        Me.GV2_APPLY_YN.Width = 40
        Me.Localizer1.SetWordID(Me.GV2_APPLY_YN, "")
        '
        'GV2_RESULT
        '
        Me.GV2_RESULT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GV2_RESULT.AppearanceCell.Options.UseFont = True
        Me.GV2_RESULT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_RESULT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_RESULT.Caption = "Result"
        Me.GV2_RESULT.FieldName = "RESULT"
        Me.GV2_RESULT.Name = "GV2_RESULT"
        Me.GV2_RESULT.OptionsColumn.AllowEdit = False
        Me.GV2_RESULT.OptionsColumn.ReadOnly = True
        Me.GV2_RESULT.Visible = True
        Me.GV2_RESULT.VisibleIndex = 9
        Me.GV2_RESULT.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_RESULT, "")
        '
        'GV1_WH_CD
        '
        Me.GV1_WH_CD.Caption = "Warehouse Code"
        Me.GV1_WH_CD.FieldName = "WH_CD"
        Me.GV1_WH_CD.Name = "GV1_WH_CD"
        Me.GV1_WH_CD.OptionsColumn.AllowEdit = False
        Me.GV1_WH_CD.OptionsColumn.ReadOnly = True
        Me.GV1_WH_CD.Visible = True
        Me.GV1_WH_CD.VisibleIndex = 0
        Me.GV1_WH_CD.Width = 105
        Me.Localizer1.SetWordID(Me.GV1_WH_CD, "Warehouse Code")
        '
        'GV1_WH_NM
        '
        Me.GV1_WH_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_WH_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_WH_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_WH_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_WH_NM.Caption = "Warehouse Name"
        Me.GV1_WH_NM.FieldName = "WH_NM"
        Me.GV1_WH_NM.Name = "GV1_WH_NM"
        Me.GV1_WH_NM.Visible = True
        Me.GV1_WH_NM.VisibleIndex = 1
        Me.GV1_WH_NM.Width = 180
        Me.Localizer1.SetWordID(Me.GV1_WH_NM, "Warehouse Name")
        '
        'GV1_USE_YN
        '
        Me.GV1_USE_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_USE_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_USE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_USE_YN.Caption = "Activity"
        Me.GV1_USE_YN.FieldName = "USE_YN"
        Me.GV1_USE_YN.Name = "GV1_USE_YN"
        Me.GV1_USE_YN.Visible = True
        Me.GV1_USE_YN.VisibleIndex = 2
        Me.GV1_USE_YN.Width = 70
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "Activity")
        '
        'GV1_WH_ADDR
        '
        Me.GV1_WH_ADDR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_WH_ADDR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_WH_ADDR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_WH_ADDR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_WH_ADDR.Caption = "Address"
        Me.GV1_WH_ADDR.FieldName = "WH_ADDR"
        Me.GV1_WH_ADDR.Name = "GV1_WH_ADDR"
        Me.GV1_WH_ADDR.Visible = True
        Me.GV1_WH_ADDR.VisibleIndex = 2
        Me.GV1_WH_ADDR.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_WH_ADDR, "Address")
        '
        'GV1_WH_PIC
        '
        Me.GV1_WH_PIC.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_WH_PIC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_WH_PIC.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_WH_PIC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_WH_PIC.Caption = "PIC"
        Me.GV1_WH_PIC.FieldName = "WH_PIC"
        Me.GV1_WH_PIC.Name = "GV1_WH_PIC"
        Me.GV1_WH_PIC.Visible = True
        Me.GV1_WH_PIC.VisibleIndex = 2
        Me.GV1_WH_PIC.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_WH_PIC, "PIC")
        '
        'GV1_FAX_NO
        '
        Me.GV1_FAX_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FAX_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_FAX_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FAX_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_FAX_NO.Caption = "FAX"
        Me.GV1_FAX_NO.FieldName = "FAX_NO"
        Me.GV1_FAX_NO.Name = "GV1_FAX_NO"
        Me.GV1_FAX_NO.Visible = True
        Me.GV1_FAX_NO.VisibleIndex = 2
        Me.GV1_FAX_NO.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_FAX_NO, "FAX")
        '
        'GV1_TEL_NO
        '
        Me.GV1_TEL_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TEL_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_TEL_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TEL_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_TEL_NO.Caption = "TEL"
        Me.GV1_TEL_NO.FieldName = "TEL_NO"
        Me.GV1_TEL_NO.Name = "GV1_TEL_NO"
        Me.GV1_TEL_NO.Visible = True
        Me.GV1_TEL_NO.VisibleIndex = 2
        Me.GV1_TEL_NO.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "TEL")
        '
        'GV1_REQ_SVC
        '
        Me.GV1_REQ_SVC.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_SVC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_REQ_SVC.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_SVC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_REQ_SVC.Caption = "Service"
        Me.GV1_REQ_SVC.FieldName = "REQ_SVC"
        Me.GV1_REQ_SVC.Name = "GV1_REQ_SVC"
        Me.GV1_REQ_SVC.Visible = True
        Me.GV1_REQ_SVC.VisibleIndex = 2
        Me.GV1_REQ_SVC.Width = 70
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "Service")
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(929, 642)
        Me.XtraTabControl1.TabIndex = 9
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.Localizer1.SetWordID(Me.XtraTabControl1, "")
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.WG2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(923, 613)
        Me.XtraTabPage1.Text = "Domain List"
        Me.Localizer1.SetWordID(Me.XtraTabPage1, "")
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.SQL_STR)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(923, 613)
        Me.XtraTabPage2.Text = "Sql"
        Me.Localizer1.SetWordID(Me.XtraTabPage2, "")
        '
        'SQL_STR
        '
        Me.SQL_STR.BorderColor = System.Drawing.Color.Silver
        Me.SQL_STR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SQL_STR.DefVal = ""
        Me.SQL_STR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SQL_STR.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SQL_STR.IsDataStateAware = True
        Me.SQL_STR.Location = New System.Drawing.Point(0, 0)
        Me.SQL_STR.MaxLength = 0
        Me.SQL_STR.Multiline = True
        Me.SQL_STR.Name = "SQL_STR"
        Me.SQL_STR.NextFocus = "WG1"
        Me.SQL_STR.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SQL_STR.Size = New System.Drawing.Size(923, 613)
        Me.SQL_STR.TabIndex = 205
        Me.SQL_STR.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.SQL_STR.WordWrap = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.S_DB_LINK)
        Me.PanelControl1.Controls.Add(Me.S_APPLY_SOURCE)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 46)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(998, 34)
        Me.PanelControl1.TabIndex = 11
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(251, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "시스템 (DB Link)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "")
        '
        'S_DB_LINK
        '
        Me.S_DB_LINK.CodeType = ""
        Me.S_DB_LINK.ColumnWidths = ""
        Me.S_DB_LINK.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_DB_LINK.DataParams = ""
        Me.S_DB_LINK.DefVal = "ELVIS"
        Me.S_DB_LINK.DisplayMember = "NAME"
        Me.S_DB_LINK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DB_LINK.FormattingEnabled = True
        Me.S_DB_LINK.IsDataStateAware = True
        Me.S_DB_LINK.ItemDelimiter = ","
        Me.S_DB_LINK.ItemTextList = "ELVIS,ELVIS PLUS"
        Me.S_DB_LINK.ItemValueList = "ELVIS,ELVIS_PLUS"
        Me.S_DB_LINK.KeepIntegrity = True
        Me.S_DB_LINK.Location = New System.Drawing.Point(351, 7)
        Me.S_DB_LINK.Name = "S_DB_LINK"
        Me.S_DB_LINK.NextFocus = "SEARCH_KEY"
        Me.S_DB_LINK.NullText = ""
        Me.S_DB_LINK.SearchKeys = ""
        Me.S_DB_LINK.Size = New System.Drawing.Size(120, 22)
        Me.S_DB_LINK.TabIndex = 276
        Me.S_DB_LINK.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DB_LINK.ValueMember = "CODE"
        '
        'S_APPLY_SOURCE
        '
        Me.S_APPLY_SOURCE.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_APPLY_SOURCE.ColumnWidths = ""
        Me.S_APPLY_SOURCE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_APPLY_SOURCE.DataParams = "GroupCode:'H01',NameType:''"
        Me.S_APPLY_SOURCE.DefVal = "01"
        Me.S_APPLY_SOURCE.DisplayMember = "NAME"
        Me.S_APPLY_SOURCE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_APPLY_SOURCE.FormattingEnabled = True
        Me.S_APPLY_SOURCE.IsDataStateAware = True
        Me.S_APPLY_SOURCE.ItemDelimiter = ","
        Me.S_APPLY_SOURCE.ItemTextList = ""
        Me.S_APPLY_SOURCE.ItemValueList = ""
        Me.S_APPLY_SOURCE.KeepIntegrity = True
        Me.S_APPLY_SOURCE.Location = New System.Drawing.Point(105, 7)
        Me.S_APPLY_SOURCE.Name = "S_APPLY_SOURCE"
        Me.S_APPLY_SOURCE.NextFocus = "S_USR_NM"
        Me.S_APPLY_SOURCE.NullText = ""
        Me.S_APPLY_SOURCE.SearchKeys = ""
        Me.S_APPLY_SOURCE.Size = New System.Drawing.Size(96, 22)
        Me.S_APPLY_SOURCE.TabIndex = 274
        Me.S_APPLY_SOURCE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_APPLY_SOURCE.ValueMember = "CODE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(20, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 14)
        Me.Label4.TabIndex = 273
        Me.Label4.Text = "Apply Source"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label4, "")
        '
        'SplitContainerControl4
        '
        Me.SplitContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl4.Location = New System.Drawing.Point(3, 86)
        Me.SplitContainerControl4.Name = "SplitContainerControl4"
        Me.SplitContainerControl4.Panel1.Controls.Add(Me.WG1)
        Me.SplitContainerControl4.Panel1.Text = "Panel1"
        Me.SplitContainerControl4.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl4.Panel2.MinSize = 170
        Me.SplitContainerControl4.Panel2.Text = "Panel2"
        Me.SplitContainerControl4.Size = New System.Drawing.Size(1335, 642)
        Me.SplitContainerControl4.SplitterPosition = 401
        Me.SplitContainerControl4.TabIndex = 12
        Me.SplitContainerControl4.Text = "SplitContainerControl4"
        Me.Localizer1.SetWordID(Me.SplitContainerControl4, "SplitContainerControl4")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'GV1_DBLINK
        '
        Me.GV1_DBLINK.Caption = "DB_LINK"
        Me.GV1_DBLINK.FieldName = "DB_LINK"
        Me.GV1_DBLINK.Name = "GV1_DBLINK"
        Me.Localizer1.SetWordID(Me.GV1_DBLINK, "DB_LINK")
        '
        'SysDBMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1342, 731)
        Me.Controls.Add(Me.SplitContainerControl4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "SysDBMgt"
        Me.Text = "변경사항 일괄적용"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.SplitContainerControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_CHK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SQL_STR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WH_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WH_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_USE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WH_ADDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WH_PIC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FAX_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_SVC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_DB_IP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_DB_PORT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_USR_PWD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_CHK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnExecute As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV2_DB_SID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV2_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SQL_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_APPLY_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GV2_DOMAIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_RESULT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SQL_STR As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV2_CTRY_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents S_APPLY_SOURCE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV1_APPLY_SOURCE_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_APPLY_SOURCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl4 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Label2 As SCControls.Label
    Friend WithEvents S_DB_LINK As SCControls.ComboBox
    Friend WithEvents GV1_DBLINK As DevExpress.XtraGrid.Columns.GridColumn
End Class
