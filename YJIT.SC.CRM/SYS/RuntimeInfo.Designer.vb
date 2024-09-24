<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RuntimeInfo
    Inherits YJIT.SC.UI.SCView

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RuntimeInfo))
        Me.xtcMain = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpQuery = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.xtcRecall = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpHistory = New DevExpress.XtraTab.XtraTabPage()
        Me.btnSqlHistory = New YJIT.SC.UI.SCControls.Button()
        Me.WG_HISTORY = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_HISTORY = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV_HISTORY_DATETIME = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_HISTORY_QUERY = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.xtcExecute = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpExecute = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.btnExecuteReconnect = New YJIT.SC.UI.SCControls.Button()
        Me.S_DOMAIN = New YJIT.SC.UI.SCControls.TextBox()
        Me.S_EXECUTE = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnExecute = New YJIT.SC.UI.SCControls.Button()
        Me.WG_EXECUTE = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_EXECUTE = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.xtcDomain = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpDomain = New DevExpress.XtraTab.XtraTabPage()
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
        Me.xtpSystem = New DevExpress.XtraTab.XtraTabPage()
        Me.btnLoadLoginList = New YJIT.SC.UI.SCControls.Button()
        Me.btnRuntimeUpdate = New YJIT.SC.UI.SCControls.Button()
        Me.btnLoadRecentSql = New YJIT.SC.UI.SCControls.Button()
        Me.txtRecentSql = New YJIT.SC.UI.SCControls.TextBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnEnvPath = New YJIT.SC.UI.SCControls.Button()
        Me.btnShowFolder = New YJIT.SC.UI.SCControls.Button()
        Me.txtEnvPath = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label10 = New YJIT.SC.UI.SCControls.Label()
        Me.txtAppPath = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.txtReportPath = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtManifestUrl = New YJIT.SC.UI.SCControls.TextBox()
        Me.txtWCFServer = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.xtpSession = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txtUserID = New YJIT.SC.UI.SCControls.TextBox()
        Me.txtAuthLevel = New YJIT.SC.UI.SCControls.TextBox()
        Me.txtOffice = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label9 = New YJIT.SC.UI.SCControls.Label()
        Me.Label5 = New YJIT.SC.UI.SCControls.Label()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.txtDepartment = New YJIT.SC.UI.SCControls.TextBox()
        CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcMain.SuspendLayout()
        Me.xtpQuery.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.xtcRecall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcRecall.SuspendLayout()
        Me.xtpHistory.SuspendLayout()
        CType(Me.WG_HISTORY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_HISTORY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.xtcExecute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcExecute.SuspendLayout()
        Me.xtpExecute.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.WG_EXECUTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_EXECUTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcDomain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcDomain.SuspendLayout()
        Me.xtpDomain.SuspendLayout()
        CType(Me.WG_DOMAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DOMAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpSystem.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.xtpSession.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'xtcMain
        '
        Me.xtcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcMain.Location = New System.Drawing.Point(0, 0)
        Me.xtcMain.Name = "xtcMain"
        Me.xtcMain.SelectedTabPage = Me.xtpQuery
        Me.xtcMain.Size = New System.Drawing.Size(1148, 614)
        Me.xtcMain.TabIndex = 0
        Me.xtcMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpSystem, Me.xtpSession, Me.xtpQuery})
        '
        'xtpQuery
        '
        Me.xtpQuery.Controls.Add(Me.SplitContainerControl1)
        Me.xtpQuery.Name = "xtpQuery"
        Me.xtpQuery.Size = New System.Drawing.Size(1142, 587)
        Me.xtpQuery.Text = "Query Analyzer "
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.xtcRecall)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl3)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1142, 587)
        Me.SplitContainerControl1.SplitterPosition = 304
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'xtcRecall
        '
        Me.xtcRecall.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcRecall.Location = New System.Drawing.Point(0, 0)
        Me.xtcRecall.Name = "xtcRecall"
        Me.xtcRecall.SelectedTabPage = Me.xtpHistory
        Me.xtcRecall.Size = New System.Drawing.Size(304, 587)
        Me.xtcRecall.TabIndex = 0
        Me.xtcRecall.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpHistory})
        '
        'xtpHistory
        '
        Me.xtpHistory.Controls.Add(Me.btnSqlHistory)
        Me.xtpHistory.Controls.Add(Me.WG_HISTORY)
        Me.xtpHistory.Name = "xtpHistory"
        Me.xtpHistory.Size = New System.Drawing.Size(298, 560)
        Me.xtpHistory.Text = "History"
        '
        'btnSqlHistory
        '
        Me.btnSqlHistory.Action = "SearchData"
        Me.btnSqlHistory.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSqlHistory.Image = CType(resources.GetObject("btnSqlHistory.Image"), System.Drawing.Image)
        Me.btnSqlHistory.Location = New System.Drawing.Point(3, 4)
        Me.btnSqlHistory.Name = "btnSqlHistory"
        Me.btnSqlHistory.Size = New System.Drawing.Size(73, 22)
        Me.btnSqlHistory.TabIndex = 4
        Me.btnSqlHistory.Text = "Se&arch"
        '
        'WG_HISTORY
        '
        Me.WG_HISTORY.AllowClientBinding = True
        Me.WG_HISTORY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_HISTORY.DeleteRowConfirmation = True
        Me.WG_HISTORY.DisplayCurrentRow = False
        Me.WG_HISTORY.IsDataStateAware = True
        Me.WG_HISTORY.Location = New System.Drawing.Point(3, 32)
        Me.WG_HISTORY.MainView = Me.GV_HISTORY
        Me.WG_HISTORY.Name = "WG_HISTORY"
        Me.WG_HISTORY.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoEdit1})
        Me.WG_HISTORY.SaveLayout = False
        Me.WG_HISTORY.Size = New System.Drawing.Size(294, 527)
        Me.WG_HISTORY.TabIndex = 0
        Me.WG_HISTORY.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG_HISTORY.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_HISTORY})
        '
        'GV_HISTORY
        '
        Me.GV_HISTORY.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GV_HISTORY.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.GV_HISTORY_DATETIME, Me.GV_HISTORY_QUERY})
        Me.GV_HISTORY.GridControl = Me.WG_HISTORY
        Me.GV_HISTORY.HorzScrollStep = 100
        Me.GV_HISTORY.Name = "GV_HISTORY"
        Me.GV_HISTORY.OptionsFind.AlwaysVisible = True
        Me.GV_HISTORY.OptionsFind.ShowCloseButton = False
        Me.GV_HISTORY.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GV_HISTORY.OptionsSelection.InvertSelection = True
        Me.GV_HISTORY.OptionsSelection.MultiSelect = True
        Me.GV_HISTORY.OptionsView.ColumnAutoWidth = True
        Me.GV_HISTORY.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_HISTORY.OptionsView.ShowBands = False
        Me.GV_HISTORY.OptionsView.ShowGroupPanel = False
        Me.GV_HISTORY.RowSeparatorHeight = 3
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.GV_HISTORY_DATETIME)
        Me.GridBand1.Columns.Add(Me.GV_HISTORY_QUERY)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 219
        '
        'GV_HISTORY_DATETIME
        '
        Me.GV_HISTORY_DATETIME.Caption = "DataTime"
        Me.GV_HISTORY_DATETIME.FieldName = "HISTORY_DATETIME"
        Me.GV_HISTORY_DATETIME.Name = "GV_HISTORY_DATETIME"
        Me.GV_HISTORY_DATETIME.Visible = True
        Me.GV_HISTORY_DATETIME.Width = 219
        '
        'GV_HISTORY_QUERY
        '
        Me.GV_HISTORY_QUERY.Caption = "Query"
        Me.GV_HISTORY_QUERY.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GV_HISTORY_QUERY.FieldName = "HISTORY_QUERY"
        Me.GV_HISTORY_QUERY.Name = "GV_HISTORY_QUERY"
        Me.GV_HISTORY_QUERY.RowIndex = 1
        Me.GV_HISTORY_QUERY.Visible = True
        Me.GV_HISTORY_QUERY.Width = 162
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.LinesCount = 3
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl3.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.xtcExecute)
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.xtcDomain)
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.Size = New System.Drawing.Size(833, 587)
        Me.SplitContainerControl3.SplitterPosition = 263
        Me.SplitContainerControl3.TabIndex = 2
        Me.SplitContainerControl3.Text = "SplitContainerControl3"
        '
        'xtcExecute
        '
        Me.xtcExecute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcExecute.Location = New System.Drawing.Point(0, 0)
        Me.xtcExecute.Name = "xtcExecute"
        Me.xtcExecute.SelectedTabPage = Me.xtpExecute
        Me.xtcExecute.Size = New System.Drawing.Size(565, 587)
        Me.xtcExecute.TabIndex = 1
        Me.xtcExecute.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpExecute})
        '
        'xtpExecute
        '
        Me.xtpExecute.Controls.Add(Me.SplitContainerControl2)
        Me.xtpExecute.Name = "xtpExecute"
        Me.xtpExecute.Size = New System.Drawing.Size(559, 560)
        Me.xtpExecute.Text = "Sql Excute"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.btnExecuteReconnect)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.S_DOMAIN)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.S_EXECUTE)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.btnExecute)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.WG_EXECUTE)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(559, 560)
        Me.SplitContainerControl2.SplitterPosition = 347
        Me.SplitContainerControl2.TabIndex = 5
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'btnExecuteReconnect
        '
        Me.btnExecuteReconnect.Action = "SearchData"
        Me.btnExecuteReconnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecuteReconnect.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExecuteReconnect.Image = CType(resources.GetObject("btnExecuteReconnect.Image"), System.Drawing.Image)
        Me.btnExecuteReconnect.Location = New System.Drawing.Point(424, 4)
        Me.btnExecuteReconnect.Name = "btnExecuteReconnect"
        Me.btnExecuteReconnect.Size = New System.Drawing.Size(135, 22)
        Me.btnExecuteReconnect.TabIndex = 7
        Me.btnExecuteReconnect.Text = "Execute (&Domain)"
        '
        'S_DOMAIN
        '
        Me.S_DOMAIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_DOMAIN.BorderColor = System.Drawing.Color.Empty
        Me.S_DOMAIN.DefVal = ""
        Me.S_DOMAIN.Enabled = False
        Me.S_DOMAIN.IsDataStateAware = True
        Me.S_DOMAIN.Location = New System.Drawing.Point(247, 4)
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
        Me.S_EXECUTE.Size = New System.Drawing.Size(553, 316)
        Me.S_EXECUTE.TabIndex = 5
        Me.S_EXECUTE.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'btnExecute
        '
        Me.btnExecute.Action = "SearchData"
        Me.btnExecute.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExecute.Image = CType(resources.GetObject("btnExecute.Image"), System.Drawing.Image)
        Me.btnExecute.Location = New System.Drawing.Point(3, 4)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(82, 22)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.Text = "&Execute"
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
        Me.WG_EXECUTE.Size = New System.Drawing.Size(559, 208)
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
        '
        'xtcDomain
        '
        Me.xtcDomain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcDomain.Location = New System.Drawing.Point(0, 0)
        Me.xtcDomain.Name = "xtcDomain"
        Me.xtcDomain.SelectedTabPage = Me.xtpDomain
        Me.xtcDomain.Size = New System.Drawing.Size(263, 587)
        Me.xtcDomain.TabIndex = 2
        Me.xtcDomain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpDomain})
        '
        'xtpDomain
        '
        Me.xtpDomain.Controls.Add(Me.btnDomain)
        Me.xtpDomain.Controls.Add(Me.WG_DOMAIN)
        Me.xtpDomain.Name = "xtpDomain"
        Me.xtpDomain.Size = New System.Drawing.Size(257, 560)
        Me.xtpDomain.Text = "Domain"
        '
        'btnDomain
        '
        Me.btnDomain.Action = "SearchData"
        Me.btnDomain.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDomain.Image = CType(resources.GetObject("btnDomain.Image"), System.Drawing.Image)
        Me.btnDomain.Location = New System.Drawing.Point(3, 4)
        Me.btnDomain.Name = "btnDomain"
        Me.btnDomain.Size = New System.Drawing.Size(73, 22)
        Me.btnDomain.TabIndex = 5
        Me.btnDomain.Text = " Sea&rch"
        '
        'WG_DOMAIN
        '
        Me.WG_DOMAIN.AllowClientBinding = True
        Me.WG_DOMAIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_DOMAIN.DeleteRowConfirmation = True
        Me.WG_DOMAIN.DisplayCurrentRow = False
        Me.WG_DOMAIN.IsDataStateAware = True
        Me.WG_DOMAIN.Location = New System.Drawing.Point(1, 31)
        Me.WG_DOMAIN.MainView = Me.GV_DOMAIN
        Me.WG_DOMAIN.Name = "WG_DOMAIN"
        Me.WG_DOMAIN.SaveLayout = False
        Me.WG_DOMAIN.Size = New System.Drawing.Size(254, 527)
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
        Me.GV_DOMAIN.OptionsFind.AlwaysVisible = True
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
        '
        'GV_DOMAIN_USR_ID
        '
        Me.GV_DOMAIN_USR_ID.Caption = "USR_ID"
        Me.GV_DOMAIN_USR_ID.FieldName = "USR_ID"
        Me.GV_DOMAIN_USR_ID.Name = "GV_DOMAIN_USR_ID"
        Me.GV_DOMAIN_USR_ID.Visible = True
        '
        'GV_DOMAIN_DB_IP
        '
        Me.GV_DOMAIN_DB_IP.Caption = "DB_IP"
        Me.GV_DOMAIN_DB_IP.FieldName = "DB_IP"
        Me.GV_DOMAIN_DB_IP.Name = "GV_DOMAIN_DB_IP"
        Me.GV_DOMAIN_DB_IP.Visible = True
        '
        'GV_DOMAIN_DB_SID
        '
        Me.GV_DOMAIN_DB_SID.Caption = "DB_SID"
        Me.GV_DOMAIN_DB_SID.FieldName = "DB_SID"
        Me.GV_DOMAIN_DB_SID.Name = "GV_DOMAIN_DB_SID"
        Me.GV_DOMAIN_DB_SID.Visible = True
        '
        'GV_DOMAIN_USR_PWD
        '
        Me.GV_DOMAIN_USR_PWD.Caption = "USR_PWD"
        Me.GV_DOMAIN_USR_PWD.FieldName = "USR_PWD"
        Me.GV_DOMAIN_USR_PWD.Name = "GV_DOMAIN_USR_PWD"
        Me.GV_DOMAIN_USR_PWD.RowIndex = 1
        Me.GV_DOMAIN_USR_PWD.Visible = True
        '
        'GV_DOMAIN_DB_PORT
        '
        Me.GV_DOMAIN_DB_PORT.Caption = "DB_PORT"
        Me.GV_DOMAIN_DB_PORT.FieldName = "DB_PORT"
        Me.GV_DOMAIN_DB_PORT.Name = "GV_DOMAIN_DB_PORT"
        Me.GV_DOMAIN_DB_PORT.RowIndex = 1
        Me.GV_DOMAIN_DB_PORT.Visible = True
        '
        'GV_DOMAIN_CTRY_CD
        '
        Me.GV_DOMAIN_CTRY_CD.Caption = "CTRY_CD"
        Me.GV_DOMAIN_CTRY_CD.FieldName = "CTRY_CD"
        Me.GV_DOMAIN_CTRY_CD.Name = "GV_DOMAIN_CTRY_CD"
        Me.GV_DOMAIN_CTRY_CD.RowIndex = 1
        Me.GV_DOMAIN_CTRY_CD.Visible = True
        '
        'xtpSystem
        '
        Me.xtpSystem.Controls.Add(Me.btnLoadLoginList)
        Me.xtpSystem.Controls.Add(Me.btnRuntimeUpdate)
        Me.xtpSystem.Controls.Add(Me.btnLoadRecentSql)
        Me.xtpSystem.Controls.Add(Me.txtRecentSql)
        Me.xtpSystem.Controls.Add(Me.GroupControl2)
        Me.xtpSystem.Controls.Add(Me.GroupControl1)
        Me.xtpSystem.Name = "xtpSystem"
        Me.xtpSystem.Size = New System.Drawing.Size(1142, 587)
        Me.xtpSystem.Text = "System environment"
        '
        'btnLoadLoginList
        '
        Me.btnLoadLoginList.Action = ""
        Me.btnLoadLoginList.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnLoadLoginList.Location = New System.Drawing.Point(718, 9)
        Me.btnLoadLoginList.Name = "btnLoadLoginList"
        Me.btnLoadLoginList.Size = New System.Drawing.Size(166, 25)
        Me.btnLoadLoginList.TabIndex = 6
        Me.btnLoadLoginList.Text = "Load Login List"
        '
        'btnRuntimeUpdate
        '
        Me.btnRuntimeUpdate.Action = ""
        Me.btnRuntimeUpdate.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnRuntimeUpdate.Location = New System.Drawing.Point(992, 8)
        Me.btnRuntimeUpdate.Name = "btnRuntimeUpdate"
        Me.btnRuntimeUpdate.Size = New System.Drawing.Size(146, 25)
        Me.btnRuntimeUpdate.TabIndex = 5
        Me.btnRuntimeUpdate.Text = "Runtime Update Log"
        '
        'btnLoadRecentSql
        '
        Me.btnLoadRecentSql.Action = ""
        Me.btnLoadRecentSql.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnLoadRecentSql.Location = New System.Drawing.Point(546, 9)
        Me.btnLoadRecentSql.Name = "btnLoadRecentSql"
        Me.btnLoadRecentSql.Size = New System.Drawing.Size(166, 25)
        Me.btnLoadRecentSql.TabIndex = 3
        Me.btnLoadRecentSql.Text = "Load Recent 20 SQLs"
        '
        'txtRecentSql
        '
        Me.txtRecentSql.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecentSql.BorderColor = System.Drawing.Color.Empty
        Me.txtRecentSql.DefVal = ""
        Me.txtRecentSql.IsDataStateAware = True
        Me.txtRecentSql.Location = New System.Drawing.Point(546, 39)
        Me.txtRecentSql.Multiline = True
        Me.txtRecentSql.Name = "txtRecentSql"
        Me.txtRecentSql.NextFocus = Nothing
        Me.txtRecentSql.ReadOnly = True
        Me.txtRecentSql.RequiredFor = ""
        Me.txtRecentSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecentSql.Size = New System.Drawing.Size(592, 541)
        Me.txtRecentSql.TabIndex = 1
        Me.txtRecentSql.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnEnvPath)
        Me.GroupControl2.Controls.Add(Me.btnShowFolder)
        Me.GroupControl2.Controls.Add(Me.txtEnvPath)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Controls.Add(Me.txtAppPath)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Controls.Add(Me.txtReportPath)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Location = New System.Drawing.Point(13, 9)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(526, 101)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Runtime"
        '
        'btnEnvPath
        '
        Me.btnEnvPath.Action = ""
        Me.btnEnvPath.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnEnvPath.Location = New System.Drawing.Point(475, 27)
        Me.btnEnvPath.Name = "btnEnvPath"
        Me.btnEnvPath.Size = New System.Drawing.Size(43, 23)
        Me.btnEnvPath.TabIndex = 2
        Me.btnEnvPath.Text = "Go"
        '
        'btnShowFolder
        '
        Me.btnShowFolder.Action = ""
        Me.btnShowFolder.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnShowFolder.Location = New System.Drawing.Point(475, 51)
        Me.btnShowFolder.Name = "btnShowFolder"
        Me.btnShowFolder.Size = New System.Drawing.Size(43, 23)
        Me.btnShowFolder.TabIndex = 2
        Me.btnShowFolder.Text = "Go"
        '
        'txtEnvPath
        '
        Me.txtEnvPath.BorderColor = System.Drawing.Color.Empty
        Me.txtEnvPath.DefVal = ""
        Me.txtEnvPath.IsDataStateAware = True
        Me.txtEnvPath.Location = New System.Drawing.Point(122, 27)
        Me.txtEnvPath.Name = "txtEnvPath"
        Me.txtEnvPath.NextFocus = Nothing
        Me.txtEnvPath.ReadOnly = True
        Me.txtEnvPath.RequiredFor = ""
        Me.txtEnvPath.Size = New System.Drawing.Size(345, 22)
        Me.txtEnvPath.TabIndex = 1
        Me.txtEnvPath.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.LabelFor = Nothing
        Me.Label10.Location = New System.Drawing.Point(8, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 14)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Environment Path"
        '
        'txtAppPath
        '
        Me.txtAppPath.BorderColor = System.Drawing.Color.Empty
        Me.txtAppPath.DefVal = ""
        Me.txtAppPath.IsDataStateAware = True
        Me.txtAppPath.Location = New System.Drawing.Point(122, 51)
        Me.txtAppPath.Name = "txtAppPath"
        Me.txtAppPath.NextFocus = Nothing
        Me.txtAppPath.ReadOnly = True
        Me.txtAppPath.RequiredFor = ""
        Me.txtAppPath.Size = New System.Drawing.Size(345, 22)
        Me.txtAppPath.TabIndex = 1
        Me.txtAppPath.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(36, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Startup path"
        '
        'txtReportPath
        '
        Me.txtReportPath.BorderColor = System.Drawing.Color.Empty
        Me.txtReportPath.DefVal = ""
        Me.txtReportPath.IsDataStateAware = True
        Me.txtReportPath.Location = New System.Drawing.Point(121, 74)
        Me.txtReportPath.Name = "txtReportPath"
        Me.txtReportPath.NextFocus = Nothing
        Me.txtReportPath.ReadOnly = True
        Me.txtReportPath.RequiredFor = ""
        Me.txtReportPath.Size = New System.Drawing.Size(345, 22)
        Me.txtReportPath.TabIndex = 1
        Me.txtReportPath.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(35, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Report Path"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtManifestUrl)
        Me.GroupControl1.Controls.Add(Me.txtWCFServer)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 123)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(526, 80)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "WCF information"
        '
        'txtManifestUrl
        '
        Me.txtManifestUrl.BorderColor = System.Drawing.Color.Empty
        Me.txtManifestUrl.DefVal = ""
        Me.txtManifestUrl.IsDataStateAware = True
        Me.txtManifestUrl.Location = New System.Drawing.Point(105, 53)
        Me.txtManifestUrl.Name = "txtManifestUrl"
        Me.txtManifestUrl.NextFocus = Nothing
        Me.txtManifestUrl.ReadOnly = True
        Me.txtManifestUrl.RequiredFor = ""
        Me.txtManifestUrl.Size = New System.Drawing.Size(362, 22)
        Me.txtManifestUrl.TabIndex = 1
        Me.txtManifestUrl.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'txtWCFServer
        '
        Me.txtWCFServer.BorderColor = System.Drawing.Color.Empty
        Me.txtWCFServer.DefVal = ""
        Me.txtWCFServer.IsDataStateAware = True
        Me.txtWCFServer.Location = New System.Drawing.Point(105, 27)
        Me.txtWCFServer.Name = "txtWCFServer"
        Me.txtWCFServer.NextFocus = Nothing
        Me.txtWCFServer.ReadOnly = True
        Me.txtWCFServer.RequiredFor = ""
        Me.txtWCFServer.Size = New System.Drawing.Size(362, 22)
        Me.txtWCFServer.TabIndex = 1
        Me.txtWCFServer.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Manifest URL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(19, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Server URL"
        '
        'xtpSession
        '
        Me.xtpSession.Controls.Add(Me.GroupControl4)
        Me.xtpSession.Name = "xtpSession"
        Me.xtpSession.Size = New System.Drawing.Size(1142, 587)
        Me.xtpSession.Text = "User session"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.txtUserID)
        Me.GroupControl4.Controls.Add(Me.txtAuthLevel)
        Me.GroupControl4.Controls.Add(Me.txtOffice)
        Me.GroupControl4.Controls.Add(Me.Label9)
        Me.GroupControl4.Controls.Add(Me.Label5)
        Me.GroupControl4.Controls.Add(Me.Label7)
        Me.GroupControl4.Controls.Add(Me.Label6)
        Me.GroupControl4.Controls.Add(Me.txtDepartment)
        Me.GroupControl4.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(579, 163)
        Me.GroupControl4.TabIndex = 4
        Me.GroupControl4.Text = "Logon User"
        '
        'txtUserID
        '
        Me.txtUserID.BorderColor = System.Drawing.Color.Empty
        Me.txtUserID.DefVal = ""
        Me.txtUserID.IsDataStateAware = True
        Me.txtUserID.Location = New System.Drawing.Point(105, 27)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.NextFocus = Nothing
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.RequiredFor = ""
        Me.txtUserID.Size = New System.Drawing.Size(123, 22)
        Me.txtUserID.TabIndex = 3
        Me.txtUserID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'txtAuthLevel
        '
        Me.txtAuthLevel.BorderColor = System.Drawing.Color.Empty
        Me.txtAuthLevel.DefVal = ""
        Me.txtAuthLevel.IsDataStateAware = True
        Me.txtAuthLevel.Location = New System.Drawing.Point(105, 114)
        Me.txtAuthLevel.Name = "txtAuthLevel"
        Me.txtAuthLevel.NextFocus = Nothing
        Me.txtAuthLevel.ReadOnly = True
        Me.txtAuthLevel.RequiredFor = ""
        Me.txtAuthLevel.Size = New System.Drawing.Size(446, 22)
        Me.txtAuthLevel.TabIndex = 3
        Me.txtAuthLevel.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'txtOffice
        '
        Me.txtOffice.BorderColor = System.Drawing.Color.Empty
        Me.txtOffice.DefVal = ""
        Me.txtOffice.IsDataStateAware = True
        Me.txtOffice.Location = New System.Drawing.Point(105, 85)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.NextFocus = Nothing
        Me.txtOffice.ReadOnly = True
        Me.txtOffice.RequiredFor = ""
        Me.txtOffice.Size = New System.Drawing.Size(446, 22)
        Me.txtOffice.TabIndex = 3
        Me.txtOffice.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.LabelFor = Nothing
        Me.Label9.Location = New System.Drawing.Point(17, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 14)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Auth Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.LabelFor = Nothing
        Me.Label5.Location = New System.Drawing.Point(17, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "User ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(17, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 14)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Office"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(17, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 14)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Department"
        '
        'txtDepartment
        '
        Me.txtDepartment.BorderColor = System.Drawing.Color.Empty
        Me.txtDepartment.DefVal = ""
        Me.txtDepartment.IsDataStateAware = True
        Me.txtDepartment.Location = New System.Drawing.Point(105, 56)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.NextFocus = Nothing
        Me.txtDepartment.ReadOnly = True
        Me.txtDepartment.RequiredFor = ""
        Me.txtDepartment.Size = New System.Drawing.Size(446, 22)
        Me.txtDepartment.TabIndex = 3
        Me.txtDepartment.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'RuntimeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 614)
        Me.Controls.Add(Me.xtcMain)
        Me.KeyPreview = True
        Me.Name = "RuntimeInfo"
        Me.Text = "Smart client runtime information"
        CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcMain.ResumeLayout(False)
        Me.xtpQuery.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.xtcRecall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcRecall.ResumeLayout(False)
        Me.xtpHistory.ResumeLayout(False)
        CType(Me.WG_HISTORY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_HISTORY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.xtcExecute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcExecute.ResumeLayout(False)
        Me.xtpExecute.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.WG_EXECUTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_EXECUTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcDomain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcDomain.ResumeLayout(False)
        Me.xtpDomain.ResumeLayout(False)
        CType(Me.WG_DOMAIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DOMAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpSystem.ResumeLayout(False)
        Me.xtpSystem.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.xtpSession.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents xtcMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpSystem As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpSession As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAppPath As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents txtReportPath As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents txtUserID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label5 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents txtDepartment As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label6 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents txtOffice As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label7 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtManifestUrl As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents txtWCFServer As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtAuthLevel As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label9 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnShowFolder As YJIT.SC.UI.SCControls.Button
    Friend WithEvents txtRecentSql As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents btnLoadRecentSql As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnEnvPath As YJIT.SC.UI.SCControls.Button
    Friend WithEvents txtEnvPath As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label10 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnRuntimeUpdate As YJIT.SC.UI.SCControls.Button
    Friend WithEvents xtpQuery As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents xtcRecall As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG_HISTORY As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents btnSqlHistory As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV_HISTORY As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GV_HISTORY_DATETIME As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_HISTORY_QUERY As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents xtcExecute As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpExecute As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnExecute As YJIT.SC.UI.SCControls.Button
    Friend WithEvents WG_EXECUTE As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV_EXECUTE As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents S_EXECUTE As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents xtcDomain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpDomain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG_DOMAIN As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV_DOMAIN As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GV_DOMAIN_CUST_NM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_DB_IP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_DB_PORT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_DB_SID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_USR_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_USR_PWD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_DOMAIN As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_DOMAIN_CTRY_CD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents S_DOMAIN As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents btnDomain As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnExecuteReconnect As YJIT.SC.UI.SCControls.Button
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents btnLoadLoginList As YJIT.SC.UI.SCControls.Button
End Class
