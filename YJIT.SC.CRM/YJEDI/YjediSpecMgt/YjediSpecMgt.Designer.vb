﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YjediSpecMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YjediSpecMgt))
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_CUSTOMS_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SYS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SEND_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RECV_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FWD_QUAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SEND_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SEND_PATH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SEND_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SEND_PSWD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RECV_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RECV_PATH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RECV_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RECV_PSWD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GV1_USE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGV1_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGV1_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGV1LocNum2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.FGV1Vat2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SEND_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.SYS_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.LBL_SEND_ID = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_SYS_ID = New YJIT.SC.UI.SCControls.Label()
        Me.LBL_CUSTOMS_CD = New YJIT.SC.UI.SCControls.Label()
        Me.CUSTOMS_CD = New YJIT.SC.UI.SCControls.TextBox()
        Me.TRIG_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.DEST_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.ORGN_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.Label8 = New YJIT.SC.UI.SCControls.Label()
        Me.Label101 = New YJIT.SC.UI.SCControls.Label()
        Me.Label54 = New YJIT.SC.UI.SCControls.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnQuickWg1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnExpWg1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnAddWG1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnDelWG1 = New YJIT.SC.UI.SCControls.Button()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FGV1LocNum2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FGV1Vat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.LookAndFeel.SkinName = "Blue"
        Me.RepositoryItemTextEdit1.MaxLength = 5
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 100
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.MaxLength = 9
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.MaxLength = 200
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(798, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 27)
        Me.btnSearch.TabIndex = 100
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(970, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 27)
        Me.btnSave.TabIndex = 102
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(3, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1057, 35)
        Me.palAutoButton.TabIndex = 1
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(884, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 27)
        Me.btnNew.TabIndex = 101
        Me.btnNew.Text = "&New"
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.WG1)
        Me.Panel1.Location = New System.Drawing.Point(0, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1525, 634)
        Me.Panel1.TabIndex = 6
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
        Me.WG1.Location = New System.Drawing.Point(3, 1)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.FGV1LocNum2, Me.FGV1Vat2, Me.RepositoryItemMemoExEdit1})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(1522, 630)
        Me.WG1.TabIndex = 178
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GridView14})
        '
        'GV1
        '
        Me.GV1.Appearance.FooterPanel.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1.Appearance.FooterPanel.Options.UseFont = True
        Me.GV1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV1.Appearance.ViewCaption.Options.UseForeColor = True
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_CUSTOMS_CD, Me.GV1_SYS_ID, Me.GV1_SEND_ID, Me.GV1_RECV_ID, Me.GV1_FWD_QUAL, Me.GV1_SEND_TYPE, Me.GV1_SEND_PATH, Me.GV1_SEND_USR_ID, Me.GV1_SEND_PSWD, Me.GV1_RECV_TYPE, Me.GV1_RECV_PATH, Me.GV1_RECV_USR_ID, Me.GV1_RECV_PSWD, Me.GV1_RMK, Me.GV1_USE_YN, Me.FGV1_INS_USR, Me.FGV1_INS_YMD, Me.FGV1_UPD_USR, Me.FGV1_UPD_YMD})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused
        Me.GV1.OptionsCustomization.AllowColumnMoving = False
        Me.GV1.OptionsCustomization.AllowSort = False
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.ViewCaption = " Selling(Debit)"
        '
        'GV1_CUSTOMS_CD
        '
        Me.GV1_CUSTOMS_CD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_CUSTOMS_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_CUSTOMS_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUSTOMS_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUSTOMS_CD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_CUSTOMS_CD.AppearanceHeader.Options.UseFont = True
        Me.GV1_CUSTOMS_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUSTOMS_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUSTOMS_CD.Caption = "세관코드"
        Me.GV1_CUSTOMS_CD.FieldName = "CUSTOMS_CD"
        Me.GV1_CUSTOMS_CD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_CUSTOMS_CD.Name = "GV1_CUSTOMS_CD"
        Me.GV1_CUSTOMS_CD.Visible = True
        Me.GV1_CUSTOMS_CD.VisibleIndex = 0
        Me.GV1_CUSTOMS_CD.Width = 70
        Me.Localizer1.SetWordID(Me.GV1_CUSTOMS_CD, "세관코드")
        '
        'GV1_SYS_ID
        '
        Me.GV1_SYS_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SYS_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_SYS_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SYS_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SYS_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SYS_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_SYS_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SYS_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SYS_ID.Caption = "시스템ID"
        Me.GV1_SYS_ID.FieldName = "SYS_ID"
        Me.GV1_SYS_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_SYS_ID.Name = "GV1_SYS_ID"
        Me.GV1_SYS_ID.Visible = True
        Me.GV1_SYS_ID.VisibleIndex = 1
        Me.GV1_SYS_ID.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_SYS_ID, "시스템ID")
        '
        'GV1_SEND_ID
        '
        Me.GV1_SEND_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_SEND_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_SEND_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SEND_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEND_ID.Caption = "송신ID"
        Me.GV1_SEND_ID.FieldName = "SEND_ID"
        Me.GV1_SEND_ID.Name = "GV1_SEND_ID"
        Me.GV1_SEND_ID.Visible = True
        Me.GV1_SEND_ID.VisibleIndex = 2
        Me.GV1_SEND_ID.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_SEND_ID, "송신ID")
        '
        'GV1_RECV_ID
        '
        Me.GV1_RECV_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_RECV_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_RECV_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RECV_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RECV_ID.Caption = "수신ID"
        Me.GV1_RECV_ID.FieldName = "RECV_ID"
        Me.GV1_RECV_ID.Name = "GV1_RECV_ID"
        Me.GV1_RECV_ID.Visible = True
        Me.GV1_RECV_ID.VisibleIndex = 3
        Me.GV1_RECV_ID.Width = 110
        Me.Localizer1.SetWordID(Me.GV1_RECV_ID, "수신ID")
        '
        'GV1_FWD_QUAL
        '
        Me.GV1_FWD_QUAL.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_FWD_QUAL.AppearanceCell.Options.UseFont = True
        Me.GV1_FWD_QUAL.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_FWD_QUAL.AppearanceHeader.Options.UseFont = True
        Me.GV1_FWD_QUAL.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FWD_QUAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FWD_QUAL.Caption = "포워더 한정어"
        Me.GV1_FWD_QUAL.FieldName = "FWD_QUAL"
        Me.GV1_FWD_QUAL.Name = "GV1_FWD_QUAL"
        Me.GV1_FWD_QUAL.Visible = True
        Me.GV1_FWD_QUAL.VisibleIndex = 4
        Me.GV1_FWD_QUAL.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_FWD_QUAL, "포워더 한정어")
        '
        'GV1_SEND_TYPE
        '
        Me.GV1_SEND_TYPE.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_SEND_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SEND_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEND_TYPE.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV1_SEND_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SEND_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEND_TYPE.Caption = "송신전송방식"
        Me.GV1_SEND_TYPE.FieldName = "SEND_TYPE"
        Me.GV1_SEND_TYPE.Name = "GV1_SEND_TYPE"
        Me.GV1_SEND_TYPE.Visible = True
        Me.GV1_SEND_TYPE.VisibleIndex = 5
        Me.GV1_SEND_TYPE.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_SEND_TYPE, "송신전송방식")
        '
        'GV1_SEND_PATH
        '
        Me.GV1_SEND_PATH.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_PATH.AppearanceCell.Options.UseFont = True
        Me.GV1_SEND_PATH.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SEND_PATH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_SEND_PATH.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_PATH.AppearanceHeader.Options.UseFont = True
        Me.GV1_SEND_PATH.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SEND_PATH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEND_PATH.Caption = "송신경로"
        Me.GV1_SEND_PATH.FieldName = "SEND_PATH"
        Me.GV1_SEND_PATH.Name = "GV1_SEND_PATH"
        Me.GV1_SEND_PATH.Visible = True
        Me.GV1_SEND_PATH.VisibleIndex = 6
        Me.GV1_SEND_PATH.Width = 170
        Me.Localizer1.SetWordID(Me.GV1_SEND_PATH, "송신경로")
        '
        'GV1_SEND_USR_ID
        '
        Me.GV1_SEND_USR_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_USR_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_SEND_USR_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_USR_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_SEND_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SEND_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEND_USR_ID.Caption = "송신인증계정"
        Me.GV1_SEND_USR_ID.FieldName = "SEND_USR_ID"
        Me.GV1_SEND_USR_ID.Name = "GV1_SEND_USR_ID"
        Me.GV1_SEND_USR_ID.Visible = True
        Me.GV1_SEND_USR_ID.VisibleIndex = 7
        Me.GV1_SEND_USR_ID.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_SEND_USR_ID, "송신인증계정")
        '
        'GV1_SEND_PSWD
        '
        Me.GV1_SEND_PSWD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_PSWD.AppearanceCell.Options.UseFont = True
        Me.GV1_SEND_PSWD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_PSWD.AppearanceHeader.Options.UseFont = True
        Me.GV1_SEND_PSWD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SEND_PSWD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEND_PSWD.Caption = "송신인증암호"
        Me.GV1_SEND_PSWD.FieldName = "SEND_PSWD"
        Me.GV1_SEND_PSWD.Name = "GV1_SEND_PSWD"
        Me.GV1_SEND_PSWD.Visible = True
        Me.GV1_SEND_PSWD.VisibleIndex = 8
        Me.GV1_SEND_PSWD.Width = 110
        Me.Localizer1.SetWordID(Me.GV1_SEND_PSWD, "송신인증암호")
        '
        'GV1_RECV_TYPE
        '
        Me.GV1_RECV_TYPE.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_RECV_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_RECV_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RECV_TYPE.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV1_RECV_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RECV_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RECV_TYPE.Caption = "수신전송방식"
        Me.GV1_RECV_TYPE.FieldName = "RECV_TYPE"
        Me.GV1_RECV_TYPE.Name = "GV1_RECV_TYPE"
        Me.GV1_RECV_TYPE.Visible = True
        Me.GV1_RECV_TYPE.VisibleIndex = 9
        Me.GV1_RECV_TYPE.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_RECV_TYPE, "수신전송방식")
        '
        'GV1_RECV_PATH
        '
        Me.GV1_RECV_PATH.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_PATH.AppearanceCell.Options.UseFont = True
        Me.GV1_RECV_PATH.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_PATH.AppearanceHeader.Options.UseFont = True
        Me.GV1_RECV_PATH.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RECV_PATH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RECV_PATH.Caption = "수신경로"
        Me.GV1_RECV_PATH.FieldName = "RECV_PATH"
        Me.GV1_RECV_PATH.Name = "GV1_RECV_PATH"
        Me.GV1_RECV_PATH.Visible = True
        Me.GV1_RECV_PATH.VisibleIndex = 10
        Me.GV1_RECV_PATH.Width = 170
        Me.Localizer1.SetWordID(Me.GV1_RECV_PATH, "수신경로")
        '
        'GV1_RECV_USR_ID
        '
        Me.GV1_RECV_USR_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_USR_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_RECV_USR_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_USR_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_RECV_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RECV_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RECV_USR_ID.Caption = "수신인증계정"
        Me.GV1_RECV_USR_ID.FieldName = "RECV_USR_ID"
        Me.GV1_RECV_USR_ID.Name = "GV1_RECV_USR_ID"
        Me.GV1_RECV_USR_ID.Visible = True
        Me.GV1_RECV_USR_ID.VisibleIndex = 11
        Me.GV1_RECV_USR_ID.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_RECV_USR_ID, "수신인증계정")
        '
        'GV1_RECV_PSWD
        '
        Me.GV1_RECV_PSWD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_PSWD.AppearanceCell.Options.UseFont = True
        Me.GV1_RECV_PSWD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_RECV_PSWD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_RECV_PSWD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_PSWD.AppearanceHeader.Options.UseFont = True
        Me.GV1_RECV_PSWD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RECV_PSWD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RECV_PSWD.Caption = "수신인증암호"
        Me.GV1_RECV_PSWD.FieldName = "RECV_PSWD"
        Me.GV1_RECV_PSWD.Name = "GV1_RECV_PSWD"
        Me.GV1_RECV_PSWD.Visible = True
        Me.GV1_RECV_PSWD.VisibleIndex = 12
        Me.GV1_RECV_PSWD.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_RECV_PSWD, "수신인증암호")
        '
        'GV1_RMK
        '
        Me.GV1_RMK.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RMK.AppearanceCell.Options.UseFont = True
        Me.GV1_RMK.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_RMK.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RMK.AppearanceHeader.Options.UseFont = True
        Me.GV1_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RMK.Caption = "비고"
        Me.GV1_RMK.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 13
        Me.GV1_RMK.Width = 195
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'GV1_USE_YN
        '
        Me.GV1_USE_YN.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_USE_YN.AppearanceCell.Options.UseFont = True
        Me.GV1_USE_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_USE_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USE_YN.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_USE_YN.AppearanceHeader.Options.UseFont = True
        Me.GV1_USE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_USE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_USE_YN.Caption = "사용여부"
        Me.GV1_USE_YN.FieldName = "USE_YN"
        Me.GV1_USE_YN.Name = "GV1_USE_YN"
        Me.GV1_USE_YN.Visible = True
        Me.GV1_USE_YN.VisibleIndex = 14
        Me.GV1_USE_YN.Width = 65
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "사용여부")
        '
        'FGV1_INS_USR
        '
        Me.FGV1_INS_USR.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.FGV1_INS_USR.AppearanceCell.Options.UseFont = True
        Me.FGV1_INS_USR.AppearanceCell.Options.UseTextOptions = True
        Me.FGV1_INS_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FGV1_INS_USR.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.FGV1_INS_USR.AppearanceHeader.Options.UseFont = True
        Me.FGV1_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.FGV1_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FGV1_INS_USR.Caption = "Creator"
        Me.FGV1_INS_USR.FieldName = "INS_USR"
        Me.FGV1_INS_USR.Name = "FGV1_INS_USR"
        Me.FGV1_INS_USR.OptionsColumn.AllowEdit = False
        Me.FGV1_INS_USR.OptionsColumn.ReadOnly = True
        Me.FGV1_INS_USR.Width = 60
        Me.Localizer1.SetWordID(Me.FGV1_INS_USR, "Creator")
        '
        'FGV1_INS_YMD
        '
        Me.FGV1_INS_YMD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.FGV1_INS_YMD.AppearanceCell.Options.UseFont = True
        Me.FGV1_INS_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.FGV1_INS_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FGV1_INS_YMD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.FGV1_INS_YMD.AppearanceHeader.Options.UseFont = True
        Me.FGV1_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.FGV1_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FGV1_INS_YMD.Caption = "Created Date"
        Me.FGV1_INS_YMD.FieldName = "INS_YMD"
        Me.FGV1_INS_YMD.Name = "FGV1_INS_YMD"
        Me.FGV1_INS_YMD.OptionsColumn.AllowEdit = False
        Me.FGV1_INS_YMD.OptionsColumn.ReadOnly = True
        Me.FGV1_INS_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.FGV1_INS_YMD, "Created Date")
        '
        'FGV1_UPD_USR
        '
        Me.FGV1_UPD_USR.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.FGV1_UPD_USR.AppearanceCell.Options.UseFont = True
        Me.FGV1_UPD_USR.AppearanceCell.Options.UseTextOptions = True
        Me.FGV1_UPD_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FGV1_UPD_USR.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.FGV1_UPD_USR.AppearanceHeader.Options.UseFont = True
        Me.FGV1_UPD_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.FGV1_UPD_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FGV1_UPD_USR.Caption = "Modifier"
        Me.FGV1_UPD_USR.FieldName = "UPD_USR"
        Me.FGV1_UPD_USR.Name = "FGV1_UPD_USR"
        Me.FGV1_UPD_USR.OptionsColumn.AllowEdit = False
        Me.FGV1_UPD_USR.OptionsColumn.ReadOnly = True
        Me.FGV1_UPD_USR.Width = 60
        Me.Localizer1.SetWordID(Me.FGV1_UPD_USR, "Modifier")
        '
        'FGV1_UPD_YMD
        '
        Me.FGV1_UPD_YMD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.FGV1_UPD_YMD.AppearanceCell.Options.UseFont = True
        Me.FGV1_UPD_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.FGV1_UPD_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FGV1_UPD_YMD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.FGV1_UPD_YMD.AppearanceHeader.Options.UseFont = True
        Me.FGV1_UPD_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.FGV1_UPD_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FGV1_UPD_YMD.Caption = "Modified Date"
        Me.FGV1_UPD_YMD.FieldName = "UPD_YMD"
        Me.FGV1_UPD_YMD.Name = "FGV1_UPD_YMD"
        Me.FGV1_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.FGV1_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.FGV1_UPD_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.FGV1_UPD_YMD, "Modified Date")
        '
        'FGV1LocNum2
        '
        Me.FGV1LocNum2.AutoHeight = False
        Me.FGV1LocNum2.Mask.EditMask = "#,###,###,##0.00;(#,###,###,##0.00)"
        Me.FGV1LocNum2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.FGV1LocNum2.Mask.UseMaskAsDisplayFormat = True
        Me.FGV1LocNum2.Name = "FGV1LocNum2"
        '
        'FGV1Vat2
        '
        Me.FGV1Vat2.AutoHeight = False
        Me.FGV1Vat2.Mask.EditMask = "#,###,###,##0.00;(#,###,###,##0.00)"
        Me.FGV1Vat2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.FGV1Vat2.Mask.UseMaskAsDisplayFormat = True
        Me.FGV1Vat2.Name = "FGV1Vat2"
        '
        'GridView14
        '
        Me.GridView14.GridControl = Me.WG1
        Me.GridView14.Name = "GridView14"
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_CUSTOMS_CD, "세관코드")
        Me.Localizer1.SetWordID(Me.GV1_SYS_ID, "시스템ID")
        Me.Localizer1.SetWordID(Me.GV1_SEND_ID, "송신ID")
        Me.Localizer1.SetWordID(Me.GV1_RECV_ID, "수신ID")
        Me.Localizer1.SetWordID(Me.GV1_FWD_QUAL, "포워더 한정어")
        Me.Localizer1.SetWordID(Me.GV1_SEND_TYPE, "송신전송방식")
        Me.Localizer1.SetWordID(Me.GV1_SEND_PATH, "송신경로")
        Me.Localizer1.SetWordID(Me.GV1_SEND_USR_ID, "송신인증계정")
        Me.Localizer1.SetWordID(Me.GV1_SEND_PSWD, "송신인증암호")
        Me.Localizer1.SetWordID(Me.GV1_RECV_TYPE, "수신전송방식")
        Me.Localizer1.SetWordID(Me.GV1_RECV_PATH, "수신경로")
        Me.Localizer1.SetWordID(Me.GV1_RECV_USR_ID, "수신인증계정")
        Me.Localizer1.SetWordID(Me.GV1_RECV_PSWD, "수신인증암호")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        Me.Localizer1.SetWordID(Me.GV1_USE_YN, "사용여부")
        Me.Localizer1.SetWordID(Me.FGV1_INS_USR, "Creator")
        Me.Localizer1.SetWordID(Me.FGV1_INS_YMD, "Created Date")
        Me.Localizer1.SetWordID(Me.FGV1_UPD_USR, "Modifier")
        Me.Localizer1.SetWordID(Me.FGV1_UPD_YMD, "Modified Date")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.SEND_ID, "")
        Me.Localizer1.SetWordID(Me.SYS_ID, "")
        Me.Localizer1.SetWordID(Me.LBL_SEND_ID, "송신ID")
        Me.Localizer1.SetWordID(Me.LBL_SYS_ID, "시스템ID")
        Me.Localizer1.SetWordID(Me.LBL_CUSTOMS_CD, "세관코드")
        Me.Localizer1.SetWordID(Me.CUSTOMS_CD, "")
        Me.Localizer1.SetWordID(Me.TRIG_CD, "")
        Me.Localizer1.SetWordID(Me.DEST_CD, "")
        Me.Localizer1.SetWordID(Me.ORGN_CD, "")
        Me.Localizer1.SetWordID(Me.Label7, "*Destination Office")
        Me.Localizer1.SetWordID(Me.Label6, "* Origin Office")
        Me.Localizer1.SetWordID(Me.Label8, "Trig Office")
        Me.Localizer1.SetWordID(Me.Label101, "Booking Carrier Type")
        Me.Localizer1.SetWordID(Me.Label54, "*Biz Type")
        Me.Localizer1.SetWordID(Me.TableLayoutPanel4, "")
        Me.Localizer1.SetWordID(Me.btnQuickWg1, "btnQuickWg1")
        Me.Localizer1.SetWordID(Me.btnExpWg1, "btnExpWg1")
        Me.Localizer1.SetWordID(Me.btnAddWG1, "Button1")
        Me.Localizer1.SetWordID(Me.btnDelWG1, "Button1")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SEND_ID)
        Me.PanelControl1.Controls.Add(Me.SYS_ID)
        Me.PanelControl1.Controls.Add(Me.LBL_SEND_ID)
        Me.PanelControl1.Controls.Add(Me.LBL_SYS_ID)
        Me.PanelControl1.Controls.Add(Me.LBL_CUSTOMS_CD)
        Me.PanelControl1.Controls.Add(Me.CUSTOMS_CD)
        Me.PanelControl1.Controls.Add(Me.TRIG_CD)
        Me.PanelControl1.Controls.Add(Me.DEST_CD)
        Me.PanelControl1.Controls.Add(Me.ORGN_CD)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.Label8)
        Me.PanelControl1.Controls.Add(Me.Label101)
        Me.PanelControl1.Controls.Add(Me.Label54)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 40)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1057, 69)
        Me.PanelControl1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'SEND_ID
        '
        Me.SEND_ID.BorderColor = System.Drawing.Color.Silver
        Me.SEND_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SEND_ID.DefVal = ""
        Me.SEND_ID.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SEND_ID.IsDataStateAware = True
        Me.SEND_ID.Location = New System.Drawing.Point(777, 5)
        Me.SEND_ID.MaxLength = 20
        Me.SEND_ID.Name = "SEND_ID"
        Me.SEND_ID.NextFocus = "btnSearch"
        Me.SEND_ID.Size = New System.Drawing.Size(182, 25)
        Me.SEND_ID.TabIndex = 3
        Me.SEND_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'SYS_ID
        '
        Me.SYS_ID.BorderColor = System.Drawing.Color.Silver
        Me.SYS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SYS_ID.DefVal = ""
        Me.SYS_ID.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SYS_ID.IsDataStateAware = True
        Me.SYS_ID.Location = New System.Drawing.Point(451, 5)
        Me.SYS_ID.MaxLength = 20
        Me.SYS_ID.Name = "SYS_ID"
        Me.SYS_ID.NextFocus = "SEND_ID"
        Me.SYS_ID.Size = New System.Drawing.Size(182, 25)
        Me.SYS_ID.TabIndex = 2
        Me.SYS_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'LBL_SEND_ID
        '
        Me.LBL_SEND_ID.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBL_SEND_ID.LabelFor = Nothing
        Me.LBL_SEND_ID.Location = New System.Drawing.Point(663, 6)
        Me.LBL_SEND_ID.Name = "LBL_SEND_ID"
        Me.LBL_SEND_ID.Size = New System.Drawing.Size(110, 22)
        Me.LBL_SEND_ID.TabIndex = 370
        Me.LBL_SEND_ID.Text = "송신ID"
        Me.LBL_SEND_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_SEND_ID, "송신ID")
        '
        'LBL_SYS_ID
        '
        Me.LBL_SYS_ID.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBL_SYS_ID.LabelFor = Nothing
        Me.LBL_SYS_ID.Location = New System.Drawing.Point(337, 6)
        Me.LBL_SYS_ID.Name = "LBL_SYS_ID"
        Me.LBL_SYS_ID.Size = New System.Drawing.Size(110, 22)
        Me.LBL_SYS_ID.TabIndex = 369
        Me.LBL_SYS_ID.Text = "시스템ID"
        Me.LBL_SYS_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_SYS_ID, "시스템ID")
        '
        'LBL_CUSTOMS_CD
        '
        Me.LBL_CUSTOMS_CD.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBL_CUSTOMS_CD.LabelFor = Nothing
        Me.LBL_CUSTOMS_CD.Location = New System.Drawing.Point(5, 6)
        Me.LBL_CUSTOMS_CD.Name = "LBL_CUSTOMS_CD"
        Me.LBL_CUSTOMS_CD.Size = New System.Drawing.Size(110, 22)
        Me.LBL_CUSTOMS_CD.TabIndex = 368
        Me.LBL_CUSTOMS_CD.Text = "세관코드"
        Me.LBL_CUSTOMS_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_CUSTOMS_CD, "세관코드")
        '
        'CUSTOMS_CD
        '
        Me.CUSTOMS_CD.BorderColor = System.Drawing.Color.Silver
        Me.CUSTOMS_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CUSTOMS_CD.DefVal = ""
        Me.CUSTOMS_CD.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CUSTOMS_CD.IsDataStateAware = True
        Me.CUSTOMS_CD.Location = New System.Drawing.Point(121, 5)
        Me.CUSTOMS_CD.MaxLength = 20
        Me.CUSTOMS_CD.Name = "CUSTOMS_CD"
        Me.CUSTOMS_CD.NextFocus = "SYS_ID"
        Me.CUSTOMS_CD.Size = New System.Drawing.Size(182, 25)
        Me.CUSTOMS_CD.TabIndex = 1
        Me.CUSTOMS_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'TRIG_CD
        '
        Me.TRIG_CD.AlwaysSetDisplayParams = False
        Me.TRIG_CD.AutoSuggestion = False
        Me.TRIG_CD.BorderColor = System.Drawing.Color.Empty
        Me.TRIG_CD.CodeType = "YJIT.CodeService.OfficePartner"
        Me.TRIG_CD.DataParams = "''"
        Me.TRIG_CD.DefVal = ""
        Me.TRIG_CD.DisplayParams = "Code:@TRIG_CD"
        Me.TRIG_CD.EditPopup = ""
        Me.TRIG_CD.IconVisible = True
        Me.TRIG_CD.IsDataStateAware = True
        Me.TRIG_CD.KeepIntegrity = False
        Me.TRIG_CD.Location = New System.Drawing.Point(976, 77)
        Me.TRIG_CD.MaxLength = 10
        Me.TRIG_CD.Name = "TRIG_CD"
        Me.TRIG_CD.NextFocus = "HBL_TYPE"
        Me.TRIG_CD.SearchPopup = "CodeMaster"
        Me.TRIG_CD.Size = New System.Drawing.Size(89, 22)
        Me.TRIG_CD.SuppressValidateCode = False
        Me.TRIG_CD.TabIndex = 23
        Me.TRIG_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.TRIG_CD.ValidateKeys = "OfficeCode:@TRIG_CD"
        Me.TRIG_CD.Visible = False
        '
        'DEST_CD
        '
        Me.DEST_CD.AlwaysSetDisplayParams = False
        Me.DEST_CD.AutoSuggestion = False
        Me.DEST_CD.BorderColor = System.Drawing.Color.Empty
        Me.DEST_CD.CodeType = "YJIT.CodeService.OfficePartner"
        Me.DEST_CD.DataParams = "''"
        Me.DEST_CD.DefVal = ""
        Me.DEST_CD.DisplayParams = "Code:@DEST_CD"
        Me.DEST_CD.EditPopup = ""
        Me.DEST_CD.IconVisible = True
        Me.DEST_CD.IsDataStateAware = True
        Me.DEST_CD.KeepIntegrity = False
        Me.DEST_CD.Location = New System.Drawing.Point(719, 77)
        Me.DEST_CD.MaxLength = 10
        Me.DEST_CD.Name = "DEST_CD"
        Me.DEST_CD.NextFocus = "TRIG_CD"
        Me.DEST_CD.SearchPopup = "CodeMaster"
        Me.DEST_CD.Size = New System.Drawing.Size(89, 22)
        Me.DEST_CD.SuppressValidateCode = False
        Me.DEST_CD.TabIndex = 22
        Me.DEST_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.DEST_CD.ValidateKeys = "OfficeCode:@DEST_CD"
        Me.DEST_CD.Visible = False
        '
        'ORGN_CD
        '
        Me.ORGN_CD.AlwaysSetDisplayParams = False
        Me.ORGN_CD.AutoSuggestion = False
        Me.ORGN_CD.BackColor = System.Drawing.SystemColors.Window
        Me.ORGN_CD.BorderColor = System.Drawing.Color.Empty
        Me.ORGN_CD.CodeType = "YJIT.CodeService.OfficePartner"
        Me.ORGN_CD.DataParams = "''"
        Me.ORGN_CD.DefVal = ""
        Me.ORGN_CD.DisplayParams = "Code:@ORGN_CD"
        Me.ORGN_CD.EditPopup = ""
        Me.ORGN_CD.IconVisible = True
        Me.ORGN_CD.IsDataStateAware = True
        Me.ORGN_CD.KeepIntegrity = False
        Me.ORGN_CD.Location = New System.Drawing.Point(484, 77)
        Me.ORGN_CD.MaxLength = 10
        Me.ORGN_CD.Name = "ORGN_CD"
        Me.ORGN_CD.NextFocus = "DEST_CD"
        Me.ORGN_CD.SearchPopup = "CodeMaster"
        Me.ORGN_CD.Size = New System.Drawing.Size(106, 22)
        Me.ORGN_CD.SuppressValidateCode = False
        Me.ORGN_CD.TabIndex = 21
        Me.ORGN_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.ORGN_CD.ValidateKeys = "OfficeCode:@ORGN_CD"
        Me.ORGN_CD.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(605, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "*Destination Office"
        Me.Label7.Visible = False
        Me.Localizer1.SetWordID(Me.Label7, "*Destination Office")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(388, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "* Origin Office"
        Me.Label6.Visible = False
        Me.Localizer1.SetWordID(Me.Label6, "* Origin Office")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.LabelFor = Nothing
        Me.Label8.Location = New System.Drawing.Point(902, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Trig Office"
        Me.Label8.Visible = False
        Me.Localizer1.SetWordID(Me.Label8, "Trig Office")
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.LabelFor = Nothing
        Me.Label101.Location = New System.Drawing.Point(357, 160)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(120, 14)
        Me.Label101.TabIndex = 0
        Me.Label101.Text = "Booking Carrier Type"
        Me.Localizer1.SetWordID(Me.Label101, "Booking Carrier Type")
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.LabelFor = Nothing
        Me.Label54.Location = New System.Drawing.Point(656, 160)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(60, 14)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "*Biz Type"
        Me.Localizer1.SetWordID(Me.Label54, "*Biz Type")
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TableLayoutPanel4.ColumnCount = 6
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnQuickWg1, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnExpWg1, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnAddWG1, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnDelWG1, 3, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(1112, 109)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(413, 30)
        Me.TableLayoutPanel4.TabIndex = 371
        Me.Localizer1.SetWordID(Me.TableLayoutPanel4, "")
        '
        'btnQuickWg1
        '
        Me.btnQuickWg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnQuickWg1.Image = CType(resources.GetObject("btnQuickWg1.Image"), System.Drawing.Image)
        Me.btnQuickWg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuickWg1.Location = New System.Drawing.Point(386, 3)
        Me.btnQuickWg1.Name = "btnQuickWg1"
        Me.btnQuickWg1.Size = New System.Drawing.Size(24, 24)
        Me.btnQuickWg1.TabIndex = 403
        Me.btnQuickWg1.Text = "btnQuickWg1"
        Me.Localizer1.SetWordID(Me.btnQuickWg1, "btnQuickWg1")
        '
        'btnExpWg1
        '
        Me.btnExpWg1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExpWg1.Image = CType(resources.GetObject("btnExpWg1.Image"), System.Drawing.Image)
        Me.btnExpWg1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExpWg1.Location = New System.Drawing.Point(356, 3)
        Me.btnExpWg1.Name = "btnExpWg1"
        Me.btnExpWg1.Size = New System.Drawing.Size(24, 24)
        Me.btnExpWg1.TabIndex = 402
        Me.btnExpWg1.Text = "btnExpWg1"
        Me.Localizer1.SetWordID(Me.btnExpWg1, "btnExpWg1")
        '
        'btnAddWG1
        '
        Me.btnAddWG1.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddWG1.Appearance.Options.UseForeColor = True
        Me.btnAddWG1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnAddWG1.Image = CType(resources.GetObject("btnAddWG1.Image"), System.Drawing.Image)
        Me.btnAddWG1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddWG1.Location = New System.Drawing.Point(296, 3)
        Me.btnAddWG1.Name = "btnAddWG1"
        Me.btnAddWG1.Size = New System.Drawing.Size(24, 24)
        Me.btnAddWG1.TabIndex = 400
        Me.btnAddWG1.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnAddWG1, "Button1")
        '
        'btnDelWG1
        '
        Me.btnDelWG1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDelWG1.Image = CType(resources.GetObject("btnDelWG1.Image"), System.Drawing.Image)
        Me.btnDelWG1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelWG1.Location = New System.Drawing.Point(326, 3)
        Me.btnDelWG1.Name = "btnDelWG1"
        Me.btnDelWG1.Size = New System.Drawing.Size(24, 24)
        Me.btnDelWG1.TabIndex = 401
        Me.btnDelWG1.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnDelWG1, "Button1")
        '
        'YjediSpecMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1527, 777)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "YjediSpecMgt"
        Me.Text = "스펙 관리"
        Me.Localizer1.SetWordID(Me, "스펙 관리")
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FGV1LocNum2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FGV1Vat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents btnNew As SCControls.Button
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents CUSTOMS_CD As SCControls.TextBox
    Friend WithEvents TRIG_CD As SCControls.CodeBox
    Friend WithEvents DEST_CD As SCControls.CodeBox
    Friend WithEvents ORGN_CD As SCControls.CodeBox
    Friend WithEvents Label7 As SCControls.Label
    Friend WithEvents Label6 As SCControls.Label
    Friend WithEvents Label8 As SCControls.Label
    Friend WithEvents Label101 As SCControls.Label
    Friend WithEvents Label54 As SCControls.Label
    Public WithEvents WG1 As SCControls.WebGrid
    Public WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_SEND_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RECV_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUSTOMS_CD As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GV1_SYS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GV1_FWD_QUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SEND_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SEND_PATH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SEND_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SEND_PSWD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RECV_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RECV_PATH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1LocNum2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_RECV_PSWD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1Vat2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_USE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_RECV_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LBL_CUSTOMS_CD As SCControls.Label
    Public WithEvents SEND_ID As SCControls.TextBox
    Public WithEvents SYS_ID As SCControls.TextBox
    Friend WithEvents LBL_SEND_ID As SCControls.Label
    Friend WithEvents LBL_SYS_ID As SCControls.Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnQuickWg1 As SCControls.Button
    Friend WithEvents btnExpWg1 As SCControls.Button
    Friend WithEvents btnAddWG1 As SCControls.Button
    Friend WithEvents btnDelWG1 As SCControls.Button
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
End Class
