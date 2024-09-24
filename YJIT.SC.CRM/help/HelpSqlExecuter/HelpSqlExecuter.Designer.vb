<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpSqlExecuter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpSqlExecuter))
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnClear = New YJIT.SC.UI.SCControls.Button()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.xtcDomain = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpDomain = New DevExpress.XtraTab.XtraTabPage()
        Me.WG_SQL = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_SQL = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GVS_TITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVS_SQL_STR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDomain = New YJIT.SC.UI.SCControls.Button()
        Me.WG_DOMAIN = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_DOMAIN = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV_DOMAIN_DOMAIN = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_DOMAIN_CUST_NM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV_DOMAIN_USR_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_DOMAIN_DB_IP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_DOMAIN_DB_SID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_DOMAIN_USR_PWD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_DOMAIN_DB_PORT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_DOMAIN_CTRY_CD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.xtcExecute = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpExecute = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.btnExecuteReconnect = New YJIT.SC.UI.SCControls.Button()
        Me.splSqlSettings = New DevExpress.XtraEditors.PanelControl()
        Me.S_DOMAIN = New YJIT.SC.UI.SCControls.TextBox()
        Me.S_EXECUTE = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_EXECUTE = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_EXECUTE = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Label37 = New YJIT.SC.UI.SCControls.Label()
        Me.S_SVC_CD = New YJIT.SC.UI.SCControls.ComboBox()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.xtcDomain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcDomain.SuspendLayout()
        Me.xtpDomain.SuspendLayout()
        CType(Me.WG_SQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_SQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG_DOMAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DOMAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcExecute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcExecute.SuspendLayout()
        Me.xtpExecute.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.splSqlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG_EXECUTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_EXECUTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.btnClear)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 7)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1252, 35)
        Me.palAutoButton.TabIndex = 4
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnClear
        '
        Me.btnClear.Action = "NewData"
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(1164, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 28)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.Localizer1.SetWordID(Me.btnClear, "&Clear")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnClear, "&Clear")
        Me.Localizer1.SetWordID(Me.SplitContainerControl3, "SplitContainerControl3")
        Me.Localizer1.SetWordID(Me.xtcDomain, "")
        Me.Localizer1.SetWordID(Me.xtpDomain, "Domain")
        Me.Localizer1.SetWordID(Me.WG_SQL, "")
        Me.Localizer1.SetWordID(Me.GVS_TITLE, "TITLE")
        Me.Localizer1.SetWordID(Me.GVS_SQL_STR, "SQL")
        Me.Localizer1.SetWordID(Me.btnDomain, " Sea&rch")
        Me.Localizer1.SetWordID(Me.WG_DOMAIN, "")
        Me.Localizer1.SetWordID(Me.GridBand3, "GridBand1")
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_DOMAIN, "Domain")
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_CUST_NM, "거래처")
        Me.Localizer1.SetWordID(Me.gridBand4, "gridBand4")
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_USR_ID, "USR_ID")
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_DB_IP, "DB_IP")
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_DB_SID, "DB_SID")
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_USR_PWD, "USR_PWD")
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_DB_PORT, "DB_PORT")
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_CTRY_CD, "CTRY_CD")
        Me.Localizer1.SetWordID(Me.xtcExecute, "")
        Me.Localizer1.SetWordID(Me.xtpExecute, "Sql Execute")
        Me.Localizer1.SetWordID(Me.SplitContainerControl2, "SplitContainerControl2")
        Me.Localizer1.SetWordID(Me.btnExecuteReconnect, "Execute (&Domain)")
        Me.Localizer1.SetWordID(Me.splSqlSettings, "")
        Me.Localizer1.SetWordID(Me.S_DOMAIN, "")
        Me.Localizer1.SetWordID(Me.S_EXECUTE, "")
        Me.Localizer1.SetWordID(Me.WG_EXECUTE, "")
        Me.Localizer1.SetWordID(Me.GridBand2, "GridBand1")
        Me.Localizer1.SetWordID(Me.Label37, "시스템")
        Me.Localizer1.SetWordID(Me.S_SVC_CD, "--Select--")
        '
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl3.Location = New System.Drawing.Point(6, 45)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.xtcDomain)
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.xtcExecute)
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.Size = New System.Drawing.Size(1252, 681)
        Me.SplitContainerControl3.SplitterPosition = 472
        Me.SplitContainerControl3.TabIndex = 9
        Me.SplitContainerControl3.Text = "SplitContainerControl3"
        Me.Localizer1.SetWordID(Me.SplitContainerControl3, "")
        '
        'xtcDomain
        '
        Me.xtcDomain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcDomain.Location = New System.Drawing.Point(0, 0)
        Me.xtcDomain.Name = "xtcDomain"
        Me.xtcDomain.SelectedTabPage = Me.xtpDomain
        Me.xtcDomain.Size = New System.Drawing.Size(472, 681)
        Me.xtcDomain.TabIndex = 2
        Me.xtcDomain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpDomain})
        Me.Localizer1.SetWordID(Me.xtcDomain, "")
        '
        'xtpDomain
        '
        Me.xtpDomain.Controls.Add(Me.Label37)
        Me.xtpDomain.Controls.Add(Me.S_SVC_CD)
        Me.xtpDomain.Controls.Add(Me.WG_SQL)
        Me.xtpDomain.Controls.Add(Me.btnDomain)
        Me.xtpDomain.Controls.Add(Me.WG_DOMAIN)
        Me.xtpDomain.Name = "xtpDomain"
        Me.xtpDomain.Size = New System.Drawing.Size(466, 654)
        Me.xtpDomain.Text = "Domain"
        Me.Localizer1.SetWordID(Me.xtpDomain, "")
        '
        'WG_SQL
        '
        Me.WG_SQL.AllowClientBinding = True
        Me.WG_SQL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_SQL.DeleteRowConfirmation = True
        Me.WG_SQL.DisplayCurrentRow = False
        Me.WG_SQL.IsDataStateAware = True
        Me.WG_SQL.Location = New System.Drawing.Point(237, 32)
        Me.WG_SQL.MainView = Me.GV_SQL
        Me.WG_SQL.Name = "WG_SQL"
        Me.WG_SQL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG_SQL.SaveLayout = False
        Me.WG_SQL.Size = New System.Drawing.Size(226, 620)
        Me.WG_SQL.TabIndex = 8
        Me.WG_SQL.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_SQL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_SQL})
        '
        'GV_SQL
        '
        Me.GV_SQL.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV_SQL.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV_SQL.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GVS_TITLE, Me.GVS_SQL_STR})
        Me.GV_SQL.GridControl = Me.WG_SQL
        Me.GV_SQL.Name = "GV_SQL"
        Me.GV_SQL.OptionsBehavior.Editable = False
        Me.GV_SQL.OptionsBehavior.ReadOnly = True
        Me.GV_SQL.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_SQL.OptionsView.ColumnAutoWidth = False
        Me.GV_SQL.OptionsView.ShowGroupPanel = False
        Me.GV_SQL.RowHeight = 10
        Me.GV_SQL.ViewCaption = " 고객 리스트"
        '
        'GVS_TITLE
        '
        Me.GVS_TITLE.Caption = "TITLE"
        Me.GVS_TITLE.FieldName = "TITLE"
        Me.GVS_TITLE.Name = "GVS_TITLE"
        Me.GVS_TITLE.Visible = True
        Me.GVS_TITLE.VisibleIndex = 0
        Me.GVS_TITLE.Width = 182
        Me.Localizer1.SetWordID(Me.GVS_TITLE, "TITLE")
        '
        'GVS_SQL_STR
        '
        Me.GVS_SQL_STR.Caption = "SQL"
        Me.GVS_SQL_STR.FieldName = "SQL_STR"
        Me.GVS_SQL_STR.Name = "GVS_SQL_STR"
        Me.GVS_SQL_STR.Visible = True
        Me.GVS_SQL_STR.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GVS_SQL_STR, "SQL")
        '
        'btnDomain
        '
        Me.btnDomain.Action = "SearchData"
        Me.btnDomain.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDomain.Image = CType(resources.GetObject("btnDomain.Image"), System.Drawing.Image)
        Me.btnDomain.Location = New System.Drawing.Point(390, 4)
        Me.btnDomain.Name = "btnDomain"
        Me.btnDomain.Size = New System.Drawing.Size(73, 22)
        Me.btnDomain.TabIndex = 5
        Me.btnDomain.Text = " Sea&rch"
        Me.Localizer1.SetWordID(Me.btnDomain, "")
        '
        'WG_DOMAIN
        '
        Me.WG_DOMAIN.AllowClientBinding = True
        Me.WG_DOMAIN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WG_DOMAIN.DeleteRowConfirmation = True
        Me.WG_DOMAIN.DisplayCurrentRow = False
        Me.WG_DOMAIN.IsDataStateAware = True
        Me.WG_DOMAIN.Location = New System.Drawing.Point(1, 32)
        Me.WG_DOMAIN.MainView = Me.GV_DOMAIN
        Me.WG_DOMAIN.Name = "WG_DOMAIN"
        Me.WG_DOMAIN.SaveLayout = False
        Me.WG_DOMAIN.Size = New System.Drawing.Size(230, 620)
        Me.WG_DOMAIN.TabIndex = 1
        Me.WG_DOMAIN.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG_DOMAIN.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_DOMAIN})
        '
        'GV_DOMAIN
        '
        Me.GV_DOMAIN.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand3, Me.gridBand4})
        Me.GV_DOMAIN.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.GV_DOMAIN_CUST_NM, Me.GV_DOMAIN_DB_IP, Me.GV_DOMAIN_DB_PORT, Me.GV_DOMAIN_DB_SID, Me.GV_DOMAIN_USR_ID, Me.GV_DOMAIN_USR_PWD, Me.GV_DOMAIN_DOMAIN, Me.GV_DOMAIN_CTRY_CD})
        Me.GV_DOMAIN.GridControl = Me.WG_DOMAIN
        Me.GV_DOMAIN.HorzScrollStep = 100
        Me.GV_DOMAIN.Name = "GV_DOMAIN"
        Me.GV_DOMAIN.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GV_DOMAIN.OptionsSelection.InvertSelection = True
        Me.GV_DOMAIN.OptionsSelection.MultiSelect = True
        Me.GV_DOMAIN.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_DOMAIN.OptionsView.ShowBands = False
        Me.GV_DOMAIN.OptionsView.ShowGroupPanel = False
        Me.GV_DOMAIN.RowSeparatorHeight = 3
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "GridBand1"
        Me.GridBand3.Columns.Add(Me.GV_DOMAIN_DOMAIN)
        Me.GridBand3.Columns.Add(Me.GV_DOMAIN_CUST_NM)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 182
        Me.Localizer1.SetWordID(Me.GridBand3, "")
        '
        'GV_DOMAIN_DOMAIN
        '
        Me.GV_DOMAIN_DOMAIN.Caption = "Domain"
        Me.GV_DOMAIN_DOMAIN.FieldName = "DOMAIN"
        Me.GV_DOMAIN_DOMAIN.Name = "GV_DOMAIN_DOMAIN"
        Me.GV_DOMAIN_DOMAIN.OptionsColumn.AllowEdit = False
        Me.GV_DOMAIN_DOMAIN.OptionsColumn.ReadOnly = True
        Me.GV_DOMAIN_DOMAIN.Visible = True
        Me.GV_DOMAIN_DOMAIN.Width = 182
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_DOMAIN, "")
        '
        'GV_DOMAIN_CUST_NM
        '
        Me.GV_DOMAIN_CUST_NM.Caption = "거래처"
        Me.GV_DOMAIN_CUST_NM.FieldName = "CUST_NM"
        Me.GV_DOMAIN_CUST_NM.Name = "GV_DOMAIN_CUST_NM"
        Me.GV_DOMAIN_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV_DOMAIN_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV_DOMAIN_CUST_NM.RowIndex = 1
        Me.GV_DOMAIN_CUST_NM.Visible = True
        Me.GV_DOMAIN_CUST_NM.Width = 182
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_CUST_NM, "")
        '
        'gridBand4
        '
        Me.gridBand4.Caption = "gridBand4"
        Me.gridBand4.Columns.Add(Me.GV_DOMAIN_USR_ID)
        Me.gridBand4.Columns.Add(Me.GV_DOMAIN_DB_IP)
        Me.gridBand4.Columns.Add(Me.GV_DOMAIN_DB_SID)
        Me.gridBand4.Columns.Add(Me.GV_DOMAIN_USR_PWD)
        Me.gridBand4.Columns.Add(Me.GV_DOMAIN_DB_PORT)
        Me.gridBand4.Columns.Add(Me.GV_DOMAIN_CTRY_CD)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.Visible = False
        Me.gridBand4.Width = 225
        Me.Localizer1.SetWordID(Me.gridBand4, "")
        '
        'GV_DOMAIN_USR_ID
        '
        Me.GV_DOMAIN_USR_ID.Caption = "USR_ID"
        Me.GV_DOMAIN_USR_ID.FieldName = "USR_ID"
        Me.GV_DOMAIN_USR_ID.Name = "GV_DOMAIN_USR_ID"
        Me.GV_DOMAIN_USR_ID.Visible = True
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_USR_ID, "")
        '
        'GV_DOMAIN_DB_IP
        '
        Me.GV_DOMAIN_DB_IP.Caption = "DB_IP"
        Me.GV_DOMAIN_DB_IP.FieldName = "DB_IP"
        Me.GV_DOMAIN_DB_IP.Name = "GV_DOMAIN_DB_IP"
        Me.GV_DOMAIN_DB_IP.Visible = True
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_DB_IP, "")
        '
        'GV_DOMAIN_DB_SID
        '
        Me.GV_DOMAIN_DB_SID.Caption = "DB_SID"
        Me.GV_DOMAIN_DB_SID.FieldName = "DB_SID"
        Me.GV_DOMAIN_DB_SID.Name = "GV_DOMAIN_DB_SID"
        Me.GV_DOMAIN_DB_SID.Visible = True
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_DB_SID, "")
        '
        'GV_DOMAIN_USR_PWD
        '
        Me.GV_DOMAIN_USR_PWD.Caption = "USR_PWD"
        Me.GV_DOMAIN_USR_PWD.FieldName = "USR_PWD"
        Me.GV_DOMAIN_USR_PWD.Name = "GV_DOMAIN_USR_PWD"
        Me.GV_DOMAIN_USR_PWD.RowIndex = 1
        Me.GV_DOMAIN_USR_PWD.Visible = True
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_USR_PWD, "")
        '
        'GV_DOMAIN_DB_PORT
        '
        Me.GV_DOMAIN_DB_PORT.Caption = "DB_PORT"
        Me.GV_DOMAIN_DB_PORT.FieldName = "DB_PORT"
        Me.GV_DOMAIN_DB_PORT.Name = "GV_DOMAIN_DB_PORT"
        Me.GV_DOMAIN_DB_PORT.RowIndex = 1
        Me.GV_DOMAIN_DB_PORT.Visible = True
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_DB_PORT, "")
        '
        'GV_DOMAIN_CTRY_CD
        '
        Me.GV_DOMAIN_CTRY_CD.Caption = "CTRY_CD"
        Me.GV_DOMAIN_CTRY_CD.FieldName = "CTRY_CD"
        Me.GV_DOMAIN_CTRY_CD.Name = "GV_DOMAIN_CTRY_CD"
        Me.GV_DOMAIN_CTRY_CD.RowIndex = 1
        Me.GV_DOMAIN_CTRY_CD.Visible = True
        Me.Localizer1.SetWordID(Me.GV_DOMAIN_CTRY_CD, "")
        '
        'xtcExecute
        '
        Me.xtcExecute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcExecute.Location = New System.Drawing.Point(0, 0)
        Me.xtcExecute.Name = "xtcExecute"
        Me.xtcExecute.SelectedTabPage = Me.xtpExecute
        Me.xtcExecute.Size = New System.Drawing.Size(775, 681)
        Me.xtcExecute.TabIndex = 1
        Me.xtcExecute.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpExecute})
        Me.Localizer1.SetWordID(Me.xtcExecute, "")
        '
        'xtpExecute
        '
        Me.xtpExecute.Controls.Add(Me.SplitContainerControl2)
        Me.xtpExecute.Name = "xtpExecute"
        Me.xtpExecute.Size = New System.Drawing.Size(769, 654)
        Me.xtpExecute.Text = "Sql Execute"
        Me.Localizer1.SetWordID(Me.xtpExecute, "Sql Execute")
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.btnExecuteReconnect)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.splSqlSettings)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.S_DOMAIN)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.S_EXECUTE)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.WG_EXECUTE)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(769, 654)
        Me.SplitContainerControl2.SplitterPosition = 347
        Me.SplitContainerControl2.TabIndex = 5
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        Me.Localizer1.SetWordID(Me.SplitContainerControl2, "")
        '
        'btnExecuteReconnect
        '
        Me.btnExecuteReconnect.Action = "SearchData"
        Me.btnExecuteReconnect.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExecuteReconnect.Image = CType(resources.GetObject("btnExecuteReconnect.Image"), System.Drawing.Image)
        Me.btnExecuteReconnect.Location = New System.Drawing.Point(180, 4)
        Me.btnExecuteReconnect.Name = "btnExecuteReconnect"
        Me.btnExecuteReconnect.Size = New System.Drawing.Size(135, 22)
        Me.btnExecuteReconnect.TabIndex = 7
        Me.btnExecuteReconnect.Text = "Execute (&Domain)"
        Me.Localizer1.SetWordID(Me.btnExecuteReconnect, "")
        '
        'splSqlSettings
        '
        Me.splSqlSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splSqlSettings.Location = New System.Drawing.Point(508, 31)
        Me.splSqlSettings.Name = "splSqlSettings"
        Me.splSqlSettings.Size = New System.Drawing.Size(258, 315)
        Me.splSqlSettings.TabIndex = 8
        Me.Localizer1.SetWordID(Me.splSqlSettings, "")
        '
        'S_DOMAIN
        '
        Me.S_DOMAIN.BorderColor = System.Drawing.Color.Empty
        Me.S_DOMAIN.DefVal = ""
        Me.S_DOMAIN.Enabled = False
        Me.S_DOMAIN.IsDataStateAware = True
        Me.S_DOMAIN.Location = New System.Drawing.Point(3, 4)
        Me.S_DOMAIN.Name = "S_DOMAIN"
        Me.S_DOMAIN.NextFocus = Nothing
        Me.S_DOMAIN.RequiredFor = ""
        Me.S_DOMAIN.Size = New System.Drawing.Size(171, 22)
        Me.S_DOMAIN.TabIndex = 6
        Me.S_DOMAIN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'S_EXECUTE
        '
        Me.S_EXECUTE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_EXECUTE.BorderColor = System.Drawing.Color.Empty
        Me.S_EXECUTE.DefVal = ""
        Me.S_EXECUTE.IsDataStateAware = True
        Me.S_EXECUTE.Location = New System.Drawing.Point(3, 31)
        Me.S_EXECUTE.Multiline = True
        Me.S_EXECUTE.Name = "S_EXECUTE"
        Me.S_EXECUTE.NextFocus = Nothing
        Me.S_EXECUTE.RequiredFor = ""
        Me.S_EXECUTE.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.S_EXECUTE.Size = New System.Drawing.Size(499, 315)
        Me.S_EXECUTE.TabIndex = 5
        Me.S_EXECUTE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'WG_EXECUTE
        '
        Me.WG_EXECUTE.AllowClientBinding = True
        Me.WG_EXECUTE.DeleteRowConfirmation = True
        Me.WG_EXECUTE.DisplayCurrentRow = False
        Me.WG_EXECUTE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG_EXECUTE.IsDataStateAware = True
        Me.WG_EXECUTE.Location = New System.Drawing.Point(0, 0)
        Me.WG_EXECUTE.MainView = Me.GV_EXECUTE
        Me.WG_EXECUTE.Name = "WG_EXECUTE"
        Me.WG_EXECUTE.SaveLayout = False
        Me.WG_EXECUTE.Size = New System.Drawing.Size(769, 302)
        Me.WG_EXECUTE.TabIndex = 0
        Me.WG_EXECUTE.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG_EXECUTE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_EXECUTE})
        '
        'GV_EXECUTE
        '
        Me.GV_EXECUTE.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.GV_EXECUTE.GridControl = Me.WG_EXECUTE
        Me.GV_EXECUTE.HorzScrollStep = 100
        Me.GV_EXECUTE.Name = "GV_EXECUTE"
        Me.GV_EXECUTE.OptionsFind.AlwaysVisible = True
        Me.GV_EXECUTE.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GV_EXECUTE.OptionsSelection.InvertSelection = True
        Me.GV_EXECUTE.OptionsSelection.MultiSelect = True
        Me.GV_EXECUTE.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_EXECUTE.OptionsView.ShowBands = False
        Me.GV_EXECUTE.OptionsView.ShowGroupPanel = False
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "GridBand1"
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 131
        Me.Localizer1.SetWordID(Me.GridBand2, "")
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.LabelFor = Nothing
        Me.Label37.Location = New System.Drawing.Point(11, 8)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(37, 14)
        Me.Label37.TabIndex = 11
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
        Me.S_SVC_CD.Location = New System.Drawing.Point(60, 4)
        Me.S_SVC_CD.Name = "S_SVC_CD"
        Me.S_SVC_CD.NextFocus = "S_USE_YN"
        Me.S_SVC_CD.NullText = "--Select--"
        Me.S_SVC_CD.RequiredFor = ""
        Me.S_SVC_CD.SearchKeys = ""
        Me.S_SVC_CD.Size = New System.Drawing.Size(120, 22)
        Me.S_SVC_CD.TabIndex = 12
        Me.S_SVC_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_SVC_CD.ValueMember = "CODE"
        '
        'HelpSqlExecuter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.SplitContainerControl3)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "HelpSqlExecuter"
        Me.Text = "Sql Executer"
        Me.Localizer1.SetWordID(Me, "Sql Executer")
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.xtcDomain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcDomain.ResumeLayout(False)
        Me.xtpDomain.ResumeLayout(False)
        Me.xtpDomain.PerformLayout()
        CType(Me.WG_SQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_SQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG_DOMAIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DOMAIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcExecute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcExecute.ResumeLayout(False)
        Me.xtpExecute.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.splSqlSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG_EXECUTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_EXECUTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents btnClear As YJIT.SC.UI.SCControls.Button
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents xtcDomain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpDomain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnDomain As YJIT.SC.UI.SCControls.Button
    Friend WithEvents WG_DOMAIN As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV_DOMAIN As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV_DOMAIN_DOMAIN As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_CUST_NM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV_DOMAIN_USR_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_DB_IP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_DB_SID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_USR_PWD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_DB_PORT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_CTRY_CD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents xtcExecute As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpExecute As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents btnExecuteReconnect As YJIT.SC.UI.SCControls.Button
    Friend WithEvents splSqlSettings As DevExpress.XtraEditors.PanelControl
    Friend WithEvents S_DOMAIN As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents S_EXECUTE As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG_EXECUTE As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV_EXECUTE As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents WG_SQL As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV_SQL As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVS_TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVS_SQL_STR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label37 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_SVC_CD As YJIT.SC.UI.SCControls.ComboBox
End Class
