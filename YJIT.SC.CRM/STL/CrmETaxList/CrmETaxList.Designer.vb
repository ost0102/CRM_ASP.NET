<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmETaxList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmETaxList))
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.btnExecute = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.GV1_WH_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WH_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_USE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WH_ADDR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WH_PIC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FAX_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_SVC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV2_SVC_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DB_IP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DB_PORT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DB_SID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_USR_PWD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_DOMAIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_RESULT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_ERROR_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label37 = New YJIT.SC.UI.SCControls.Label()
        Me.S_SVC_CD = New YJIT.SC.UI.SCControls.ComboBox()
        Me.LBL_S_SQL_ID = New YJIT.SC.UI.SCControls.Label()
        Me.SEND_YYMM = New YJIT.SC.UI.SCControls.MaskedTextBox()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.Numeric = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Numeric, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Controls.Add(Me.btnExecute)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(3, 12)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1057, 35)
        Me.palAutoButton.TabIndex = 1
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(883, 5)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 25)
        Me.btnNew.TabIndex = 219
        Me.btnNew.Text = "&New"
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExecute.Image = CType(resources.GetObject("btnExecute.Image"), System.Drawing.Image)
        Me.btnExecute.Location = New System.Drawing.Point(969, 5)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(80, 25)
        Me.btnExecute.TabIndex = 218
        Me.btnExecute.Text = "Execute"
        Me.Localizer1.SetWordID(Me.btnExecute, "Execute")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(797, 5)
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
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        Me.Localizer1.SetWordID(Me.btnExecute, "Execute")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.GV1_WH_CD, "Warehouse Code")
        Me.Localizer1.SetWordID(Me.GV1_WH_NM, "Warehouse Name")
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "Activity")
        Me.Localizer1.SetWordID(Me.GV1_WH_ADDR, "Address")
        Me.Localizer1.SetWordID(Me.GV1_WH_PIC, "PIC")
        Me.Localizer1.SetWordID(Me.GV1_FAX_NO, "FAX")
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "TEL")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "Service")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GV2_SVC_CD, "Service")
        Me.Localizer1.SetWordID(Me.GV2_CUST_NM, "거래처")
        Me.Localizer1.SetWordID(Me.GV2_DB_IP, "IP")
        Me.Localizer1.SetWordID(Me.GV2_DB_PORT, "Port")
        Me.Localizer1.SetWordID(Me.GV2_DB_SID, "SID")
        Me.Localizer1.SetWordID(Me.GV2_USR_ID, "ID")
        Me.Localizer1.SetWordID(Me.GV2_USR_PWD, "Password")
        Me.Localizer1.SetWordID(Me.GV2_DOMAIN, "Domain")
        Me.Localizer1.SetWordID(Me.GV2_RESULT, "Result")
        Me.Localizer1.SetWordID(Me.GV2_ERROR_YN, "GridColumn1")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.Label37, "시스템")
        Me.Localizer1.SetWordID(Me.S_SVC_CD, "ELVIS")
        Me.Localizer1.SetWordID(Me.LBL_S_SQL_ID, "전송월")
        Me.Localizer1.SetWordID(Me.SEND_YYMM, "")
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
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG2.DeleteRowConfirmation = False
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(3, 93)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoExEdit2, Me.Numeric})
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(1057, 523)
        Me.WG2.TabIndex = 9
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV2_SVC_CD, Me.GV2_CUST_NM, Me.GV2_DB_IP, Me.GV2_DB_PORT, Me.GV2_DB_SID, Me.GV2_USR_ID, Me.GV2_USR_PWD, Me.GV2_DOMAIN, Me.GV2_RESULT, Me.GV2_ERROR_YN})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsCustomization.AllowColumnMoving = False
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GV2_SVC_CD
        '
        Me.GV2_SVC_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_SVC_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_SVC_CD.Caption = "Service"
        Me.GV2_SVC_CD.FieldName = "SVC_CD"
        Me.GV2_SVC_CD.Name = "GV2_SVC_CD"
        Me.GV2_SVC_CD.OptionsColumn.AllowEdit = False
        Me.GV2_SVC_CD.OptionsColumn.ReadOnly = True
        Me.GV2_SVC_CD.Visible = True
        Me.GV2_SVC_CD.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GV2_SVC_CD, "Service")
        '
        'GV2_CUST_NM
        '
        Me.GV2_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUST_NM.Caption = "거래처"
        Me.GV2_CUST_NM.FieldName = "CUST_NM"
        Me.GV2_CUST_NM.Name = "GV2_CUST_NM"
        Me.GV2_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV2_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV2_CUST_NM.Visible = True
        Me.GV2_CUST_NM.VisibleIndex = 1
        Me.GV2_CUST_NM.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_CUST_NM, "")
        '
        'GV2_DB_IP
        '
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
        Me.GV2_DB_PORT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DB_PORT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DB_PORT.Caption = "Port"
        Me.GV2_DB_PORT.FieldName = "DB_PORT"
        Me.GV2_DB_PORT.Name = "GV2_DB_PORT"
        Me.GV2_DB_PORT.OptionsColumn.AllowEdit = False
        Me.GV2_DB_PORT.OptionsColumn.ReadOnly = True
        Me.GV2_DB_PORT.Visible = True
        Me.GV2_DB_PORT.VisibleIndex = 3
        Me.GV2_DB_PORT.Width = 40
        Me.Localizer1.SetWordID(Me.GV2_DB_PORT, "")
        '
        'GV2_DB_SID
        '
        Me.GV2_DB_SID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DB_SID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DB_SID.Caption = "SID"
        Me.GV2_DB_SID.FieldName = "DB_SID"
        Me.GV2_DB_SID.Name = "GV2_DB_SID"
        Me.GV2_DB_SID.OptionsColumn.AllowEdit = False
        Me.GV2_DB_SID.OptionsColumn.ReadOnly = True
        Me.GV2_DB_SID.Visible = True
        Me.GV2_DB_SID.VisibleIndex = 4
        Me.GV2_DB_SID.Width = 40
        Me.Localizer1.SetWordID(Me.GV2_DB_SID, "")
        '
        'GV2_USR_ID
        '
        Me.GV2_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_USR_ID.Caption = "ID"
        Me.GV2_USR_ID.FieldName = "USR_ID"
        Me.GV2_USR_ID.Name = "GV2_USR_ID"
        Me.GV2_USR_ID.OptionsColumn.AllowEdit = False
        Me.GV2_USR_ID.OptionsColumn.ReadOnly = True
        Me.GV2_USR_ID.Visible = True
        Me.GV2_USR_ID.VisibleIndex = 5
        Me.GV2_USR_ID.Width = 50
        Me.Localizer1.SetWordID(Me.GV2_USR_ID, "")
        '
        'GV2_USR_PWD
        '
        Me.GV2_USR_PWD.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV2_USR_PWD.AppearanceCell.Options.UseFont = True
        Me.GV2_USR_PWD.Caption = "Password"
        Me.GV2_USR_PWD.FieldName = "USR_PWD"
        Me.GV2_USR_PWD.Name = "GV2_USR_PWD"
        Me.GV2_USR_PWD.OptionsColumn.AllowEdit = False
        Me.GV2_USR_PWD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV2_USR_PWD, "")
        '
        'GV2_DOMAIN
        '
        Me.GV2_DOMAIN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DOMAIN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DOMAIN.Caption = "Domain"
        Me.GV2_DOMAIN.FieldName = "DOMAIN"
        Me.GV2_DOMAIN.Name = "GV2_DOMAIN"
        Me.GV2_DOMAIN.OptionsColumn.AllowEdit = False
        Me.GV2_DOMAIN.OptionsColumn.ReadOnly = True
        Me.GV2_DOMAIN.Visible = True
        Me.GV2_DOMAIN.VisibleIndex = 6
        Me.GV2_DOMAIN.Width = 50
        Me.Localizer1.SetWordID(Me.GV2_DOMAIN, "")
        '
        'GV2_RESULT
        '
        Me.GV2_RESULT.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_RESULT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_RESULT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_RESULT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_RESULT.Caption = "Result"
        Me.GV2_RESULT.ColumnEdit = Me.Numeric
        Me.GV2_RESULT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV2_RESULT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV2_RESULT.FieldName = "RESULT"
        Me.GV2_RESULT.Name = "GV2_RESULT"
        Me.GV2_RESULT.OptionsColumn.AllowEdit = False
        Me.GV2_RESULT.OptionsColumn.ReadOnly = True
        Me.GV2_RESULT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RESULT", "{0:N0}")})
        Me.GV2_RESULT.Visible = True
        Me.GV2_RESULT.VisibleIndex = 7
        Me.GV2_RESULT.Width = 117
        Me.Localizer1.SetWordID(Me.GV2_RESULT, "")
        '
        'GV2_ERROR_YN
        '
        Me.GV2_ERROR_YN.Caption = "GridColumn1"
        Me.GV2_ERROR_YN.FieldName = "ERROR_YN"
        Me.GV2_ERROR_YN.Name = "GV2_ERROR_YN"
        Me.Localizer1.SetWordID(Me.GV2_ERROR_YN, "")
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label37)
        Me.PanelControl1.Controls.Add(Me.S_SVC_CD)
        Me.PanelControl1.Controls.Add(Me.LBL_S_SQL_ID)
        Me.PanelControl1.Controls.Add(Me.SEND_YYMM)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 53)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1057, 34)
        Me.PanelControl1.TabIndex = 0
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.LabelFor = Nothing
        Me.Label37.Location = New System.Drawing.Point(213, 10)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(43, 14)
        Me.Label37.TabIndex = 216
        Me.Label37.Text = "시스템"
        Me.Localizer1.SetWordID(Me.Label37, "시스템")
        '
        'S_SVC_CD
        '
        Me.S_SVC_CD.CodeType = ""
        Me.S_SVC_CD.ColumnWidths = ""
        Me.S_SVC_CD.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_SVC_CD.DataParams = ""
        Me.S_SVC_CD.DefVal = ""
        Me.S_SVC_CD.DisplayMember = "NAME"
        Me.S_SVC_CD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_SVC_CD.FormattingEnabled = True
        Me.S_SVC_CD.IsDataStateAware = True
        Me.S_SVC_CD.ItemDelimiter = ","
        Me.S_SVC_CD.ItemTextList = "ELVIS,일반"
        Me.S_SVC_CD.ItemValueList = "E,V"
        Me.S_SVC_CD.KeepIntegrity = True
        Me.S_SVC_CD.Location = New System.Drawing.Point(262, 6)
        Me.S_SVC_CD.Name = "S_SVC_CD"
        Me.S_SVC_CD.NextFocus = "btnSearch"
        Me.S_SVC_CD.NullText = "--Select--"
        Me.S_SVC_CD.SearchKeys = ""
        Me.S_SVC_CD.Size = New System.Drawing.Size(120, 22)
        Me.S_SVC_CD.TabIndex = 217
        Me.S_SVC_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_SVC_CD.ValueMember = "CODE"
        '
        'LBL_S_SQL_ID
        '
        Me.LBL_S_SQL_ID.AutoEllipsis = True
        Me.LBL_S_SQL_ID.BackColor = System.Drawing.Color.Transparent
        Me.LBL_S_SQL_ID.LabelFor = Nothing
        Me.LBL_S_SQL_ID.Location = New System.Drawing.Point(32, 6)
        Me.LBL_S_SQL_ID.Name = "LBL_S_SQL_ID"
        Me.LBL_S_SQL_ID.Size = New System.Drawing.Size(61, 22)
        Me.LBL_S_SQL_ID.TabIndex = 215
        Me.LBL_S_SQL_ID.Text = "전송월"
        Me.LBL_S_SQL_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_S_SQL_ID, "전송월")
        '
        'SEND_YYMM
        '
        Me.SEND_YYMM.BorderColor = System.Drawing.Color.Silver
        Me.SEND_YYMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SEND_YYMM.DefVal = Nothing
        Me.SEND_YYMM.IsDataStateAware = True
        Me.SEND_YYMM.Location = New System.Drawing.Point(99, 6)
        Me.SEND_YYMM.Mask = "9999-99"
        Me.SEND_YYMM.Name = "SEND_YYMM"
        Me.SEND_YYMM.NextFocus = "S_SVC_CD"
        Me.SEND_YYMM.Size = New System.Drawing.Size(63, 22)
        Me.SEND_YYMM.TabIndex = 0
        Me.SEND_YYMM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.SEND_YYMM.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.Localizer1.SetWordID(Me.SEND_YYMM, "")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'Numeric
        '
        Me.Numeric.AutoHeight = False
        Me.Numeric.Mask.EditMask = "#,###,###,##0"
        Me.Numeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Numeric.Mask.UseMaskAsDisplayFormat = True
        Me.Numeric.Name = "Numeric"
        '
        'CrmETaxList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1068, 623)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.WG2)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "CrmETaxList"
        Me.Text = "고객사별 세금계산서 전송 체크"
        Me.Localizer1.SetWordID(Me, "고객사별 세금계산서 전송 체크")
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.Numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents GV1_WH_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WH_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_USE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WH_ADDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WH_PIC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FAX_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_SVC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnNew As YJIT.SC.UI.SCControls.Button
    Friend WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV2_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_DB_IP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_DB_PORT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_DB_SID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_USR_PWD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_DOMAIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_RESULT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GV2_ERROR_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SEND_YYMM As YJIT.SC.UI.SCControls.MaskedTextBox
    Friend WithEvents LBL_S_SQL_ID As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnExecute As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV2_SVC_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label37 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_SVC_CD As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Numeric As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
