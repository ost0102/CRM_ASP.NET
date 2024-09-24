<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YjediManageList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YjediManageList))
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_EDI_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TRANS_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUSTOMS_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SYS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SPEC_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SPEC_VER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SEND_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RECV_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FUNC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DOC_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SEND_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPPER_EDI_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_SVC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FILE_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_IS_CONFIRMED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CREATE_YMDHM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SEND_YMDHM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_IS_VALID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_ACK_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_GENRES_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGV1_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGV1_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LBL_INS_YMD = New YJIT.SC.UI.SCControls.Label()
        Me.TO_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label32 = New YJIT.SC.UI.SCControls.Label()
        Me.FM_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.LBL_EDI_ID = New YJIT.SC.UI.SCControls.Label()
        Me.EDI_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.TRIG_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.DEST_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.ORGN_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.Label8 = New YJIT.SC.UI.SCControls.Label()
        Me.Label101 = New YJIT.SC.UI.SCControls.Label()
        Me.Label54 = New YJIT.SC.UI.SCControls.Label()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
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
        Me.btnSearch.Location = New System.Drawing.Point(886, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 27)
        Me.btnSearch.TabIndex = 100
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnNew)
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
        Me.btnNew.Location = New System.Drawing.Point(972, 4)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1525, 661)
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
        Me.WG1.Location = New System.Drawing.Point(3, 0)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(1522, 658)
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
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_EDI_ID, Me.GV1_TRANS_TYPE, Me.GV1_CUSTOMS_CD, Me.GV1_SYS_ID, Me.GV1_SPEC_CD, Me.GV1_SPEC_VER, Me.GV1_SEND_CD, Me.GV1_RECV_ID, Me.GV1_FUNC_TYPE, Me.GV1_DOC_NO, Me.GV1_SEND_CNT, Me.GV1_UPPER_EDI_ID, Me.GV1_REQ_SVC, Me.GV1_MNGT_NO, Me.GV1_RMK, Me.GV1_FILE_NM, Me.GV1_IS_CONFIRMED, Me.GV1_CREATE_YMDHM, Me.GV1_SEND_YMDHM, Me.GV1_IS_VALID, Me.GV1_ACK_ID, Me.GV1_GENRES_ID, Me.FGV1_INS_USR, Me.FGV1_INS_YMD, Me.FGV1_UPD_USR, Me.FGV1_UPD_YMD})
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
        'GV1_EDI_ID
        '
        Me.GV1_EDI_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_EDI_ID.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.GV1_EDI_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_EDI_ID.AppearanceCell.Options.UseForeColor = True
        Me.GV1_EDI_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_EDI_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EDI_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_EDI_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_EDI_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_EDI_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EDI_ID.Caption = "전송번호"
        Me.GV1_EDI_ID.FieldName = "EDI_ID"
        Me.GV1_EDI_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_EDI_ID.Name = "GV1_EDI_ID"
        Me.GV1_EDI_ID.OptionsColumn.AllowEdit = False
        Me.GV1_EDI_ID.OptionsColumn.ReadOnly = True
        Me.GV1_EDI_ID.Visible = True
        Me.GV1_EDI_ID.VisibleIndex = 0
        Me.GV1_EDI_ID.Width = 170
        Me.Localizer1.SetWordID(Me.GV1_EDI_ID, "전송번호")
        '
        'GV1_TRANS_TYPE
        '
        Me.GV1_TRANS_TYPE.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_TRANS_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_TRANS_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TRANS_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TRANS_TYPE.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_TRANS_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV1_TRANS_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TRANS_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TRANS_TYPE.Caption = "전송타입"
        Me.GV1_TRANS_TYPE.FieldName = "TRANS_TYPE"
        Me.GV1_TRANS_TYPE.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_TRANS_TYPE.Name = "GV1_TRANS_TYPE"
        Me.GV1_TRANS_TYPE.OptionsColumn.AllowEdit = False
        Me.GV1_TRANS_TYPE.OptionsColumn.ReadOnly = True
        Me.GV1_TRANS_TYPE.Visible = True
        Me.GV1_TRANS_TYPE.VisibleIndex = 1
        Me.GV1_TRANS_TYPE.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_TRANS_TYPE, "전송타입")
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
        Me.GV1_CUSTOMS_CD.Name = "GV1_CUSTOMS_CD"
        Me.GV1_CUSTOMS_CD.OptionsColumn.AllowEdit = False
        Me.GV1_CUSTOMS_CD.OptionsColumn.ReadOnly = True
        Me.GV1_CUSTOMS_CD.Visible = True
        Me.GV1_CUSTOMS_CD.VisibleIndex = 2
        Me.GV1_CUSTOMS_CD.Width = 80
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
        Me.GV1_SYS_ID.Name = "GV1_SYS_ID"
        Me.GV1_SYS_ID.OptionsColumn.AllowEdit = False
        Me.GV1_SYS_ID.OptionsColumn.ReadOnly = True
        Me.GV1_SYS_ID.Visible = True
        Me.GV1_SYS_ID.VisibleIndex = 3
        Me.GV1_SYS_ID.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_SYS_ID, "시스템ID")
        '
        'GV1_SPEC_CD
        '
        Me.GV1_SPEC_CD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SPEC_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_SPEC_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SPEC_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SPEC_CD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SPEC_CD.AppearanceHeader.Options.UseFont = True
        Me.GV1_SPEC_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SPEC_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SPEC_CD.Caption = "문서종류"
        Me.GV1_SPEC_CD.FieldName = "SPEC_CD"
        Me.GV1_SPEC_CD.Name = "GV1_SPEC_CD"
        Me.GV1_SPEC_CD.OptionsColumn.AllowEdit = False
        Me.GV1_SPEC_CD.OptionsColumn.ReadOnly = True
        Me.GV1_SPEC_CD.Visible = True
        Me.GV1_SPEC_CD.VisibleIndex = 4
        Me.GV1_SPEC_CD.Width = 95
        Me.Localizer1.SetWordID(Me.GV1_SPEC_CD, "문서종류")
        '
        'GV1_SPEC_VER
        '
        Me.GV1_SPEC_VER.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SPEC_VER.AppearanceCell.Options.UseFont = True
        Me.GV1_SPEC_VER.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SPEC_VER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SPEC_VER.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SPEC_VER.AppearanceHeader.Options.UseFont = True
        Me.GV1_SPEC_VER.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SPEC_VER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SPEC_VER.Caption = "문서버전"
        Me.GV1_SPEC_VER.FieldName = "SPEC_VER"
        Me.GV1_SPEC_VER.Name = "GV1_SPEC_VER"
        Me.GV1_SPEC_VER.OptionsColumn.AllowEdit = False
        Me.GV1_SPEC_VER.OptionsColumn.ReadOnly = True
        Me.GV1_SPEC_VER.Visible = True
        Me.GV1_SPEC_VER.VisibleIndex = 5
        Me.GV1_SPEC_VER.Width = 40
        Me.Localizer1.SetWordID(Me.GV1_SPEC_VER, "문서버전")
        '
        'GV1_SEND_CD
        '
        Me.GV1_SEND_CD.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_SEND_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SEND_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_SEND_CD.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_CD.AppearanceHeader.Options.UseFont = True
        Me.GV1_SEND_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SEND_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEND_CD.Caption = "전송자"
        Me.GV1_SEND_CD.FieldName = "SEND_CD"
        Me.GV1_SEND_CD.Name = "GV1_SEND_CD"
        Me.GV1_SEND_CD.OptionsColumn.AllowEdit = False
        Me.GV1_SEND_CD.OptionsColumn.ReadOnly = True
        Me.GV1_SEND_CD.Visible = True
        Me.GV1_SEND_CD.VisibleIndex = 6
        Me.GV1_SEND_CD.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_SEND_CD, "전송자")
        '
        'GV1_RECV_ID
        '
        Me.GV1_RECV_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_RECV_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_RECV_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RECV_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_RECV_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_RECV_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RECV_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RECV_ID.Caption = "수신자"
        Me.GV1_RECV_ID.FieldName = "RECV_ID"
        Me.GV1_RECV_ID.Name = "GV1_RECV_ID"
        Me.GV1_RECV_ID.OptionsColumn.AllowEdit = False
        Me.GV1_RECV_ID.OptionsColumn.ReadOnly = True
        Me.GV1_RECV_ID.Visible = True
        Me.GV1_RECV_ID.VisibleIndex = 7
        Me.GV1_RECV_ID.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_RECV_ID, "수신자")
        '
        'GV1_FUNC_TYPE
        '
        Me.GV1_FUNC_TYPE.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_FUNC_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_FUNC_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FUNC_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FUNC_TYPE.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_FUNC_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV1_FUNC_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FUNC_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FUNC_TYPE.Caption = "처리타입"
        Me.GV1_FUNC_TYPE.FieldName = "FUNC_TYPE"
        Me.GV1_FUNC_TYPE.Name = "GV1_FUNC_TYPE"
        Me.GV1_FUNC_TYPE.OptionsColumn.AllowEdit = False
        Me.GV1_FUNC_TYPE.OptionsColumn.ReadOnly = True
        Me.GV1_FUNC_TYPE.Visible = True
        Me.GV1_FUNC_TYPE.VisibleIndex = 8
        Me.GV1_FUNC_TYPE.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_FUNC_TYPE, "처리타입")
        '
        'GV1_DOC_NO
        '
        Me.GV1_DOC_NO.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_DOC_NO.AppearanceCell.Options.UseFont = True
        Me.GV1_DOC_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_DOC_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_DOC_NO.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_DOC_NO.AppearanceHeader.Options.UseFont = True
        Me.GV1_DOC_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DOC_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DOC_NO.Caption = "문서번호"
        Me.GV1_DOC_NO.FieldName = "DOC_NO"
        Me.GV1_DOC_NO.Name = "GV1_DOC_NO"
        Me.GV1_DOC_NO.OptionsColumn.AllowEdit = False
        Me.GV1_DOC_NO.OptionsColumn.ReadOnly = True
        Me.GV1_DOC_NO.Visible = True
        Me.GV1_DOC_NO.VisibleIndex = 9
        Me.GV1_DOC_NO.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_DOC_NO, "문서번호")
        '
        'GV1_SEND_CNT
        '
        Me.GV1_SEND_CNT.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_CNT.AppearanceCell.Options.UseFont = True
        Me.GV1_SEND_CNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SEND_CNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_SEND_CNT.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_CNT.AppearanceHeader.Options.UseFont = True
        Me.GV1_SEND_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SEND_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEND_CNT.Caption = "전송횟수"
        Me.GV1_SEND_CNT.FieldName = "SEND_CNT"
        Me.GV1_SEND_CNT.Name = "GV1_SEND_CNT"
        Me.GV1_SEND_CNT.OptionsColumn.AllowEdit = False
        Me.GV1_SEND_CNT.OptionsColumn.ReadOnly = True
        Me.GV1_SEND_CNT.Visible = True
        Me.GV1_SEND_CNT.VisibleIndex = 10
        Me.GV1_SEND_CNT.Width = 40
        Me.Localizer1.SetWordID(Me.GV1_SEND_CNT, "전송횟수")
        '
        'GV1_UPPER_EDI_ID
        '
        Me.GV1_UPPER_EDI_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_UPPER_EDI_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_UPPER_EDI_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_UPPER_EDI_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_UPPER_EDI_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_UPPER_EDI_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_UPPER_EDI_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPPER_EDI_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPPER_EDI_ID.Caption = "이전전송번호"
        Me.GV1_UPPER_EDI_ID.FieldName = "UPPER_EDI_ID"
        Me.GV1_UPPER_EDI_ID.Name = "GV1_UPPER_EDI_ID"
        Me.GV1_UPPER_EDI_ID.OptionsColumn.AllowEdit = False
        Me.GV1_UPPER_EDI_ID.OptionsColumn.ReadOnly = True
        Me.GV1_UPPER_EDI_ID.Visible = True
        Me.GV1_UPPER_EDI_ID.VisibleIndex = 11
        Me.GV1_UPPER_EDI_ID.Width = 110
        Me.Localizer1.SetWordID(Me.GV1_UPPER_EDI_ID, "이전전송번호")
        '
        'GV1_REQ_SVC
        '
        Me.GV1_REQ_SVC.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_REQ_SVC.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_SVC.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_SVC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_SVC.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_REQ_SVC.AppearanceHeader.Options.UseFont = True
        Me.GV1_REQ_SVC.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_SVC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_SVC.Caption = "업무구분"
        Me.GV1_REQ_SVC.FieldName = "REQ_SVC"
        Me.GV1_REQ_SVC.Name = "GV1_REQ_SVC"
        Me.GV1_REQ_SVC.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_SVC.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_SVC.Visible = True
        Me.GV1_REQ_SVC.VisibleIndex = 12
        Me.GV1_REQ_SVC.Width = 80
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "업무구분")
        '
        'GV1_MNGT_NO
        '
        Me.GV1_MNGT_NO.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_MNGT_NO.AppearanceCell.Options.UseFont = True
        Me.GV1_MNGT_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseFont = True
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.Caption = "관리번호"
        Me.GV1_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV1_MNGT_NO.Name = "GV1_MNGT_NO"
        Me.GV1_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV1_MNGT_NO.Visible = True
        Me.GV1_MNGT_NO.VisibleIndex = 13
        Me.GV1_MNGT_NO.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
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
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.OptionsColumn.AllowEdit = False
        Me.GV1_RMK.OptionsColumn.ReadOnly = True
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 14
        Me.GV1_RMK.Width = 140
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        '
        'GV1_FILE_NM
        '
        Me.GV1_FILE_NM.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_FILE_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_FILE_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_FILE_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_FILE_NM.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_FILE_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_FILE_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FILE_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FILE_NM.Caption = "파일명"
        Me.GV1_FILE_NM.FieldName = "FILE_NM"
        Me.GV1_FILE_NM.Name = "GV1_FILE_NM"
        Me.GV1_FILE_NM.OptionsColumn.AllowEdit = False
        Me.GV1_FILE_NM.OptionsColumn.ReadOnly = True
        Me.GV1_FILE_NM.Visible = True
        Me.GV1_FILE_NM.VisibleIndex = 15
        Me.GV1_FILE_NM.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_FILE_NM, "파일명")
        '
        'GV1_IS_CONFIRMED
        '
        Me.GV1_IS_CONFIRMED.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_IS_CONFIRMED.AppearanceCell.Options.UseFont = True
        Me.GV1_IS_CONFIRMED.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_IS_CONFIRMED.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_IS_CONFIRMED.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_IS_CONFIRMED.AppearanceHeader.Options.UseFont = True
        Me.GV1_IS_CONFIRMED.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_IS_CONFIRMED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_IS_CONFIRMED.Caption = "전송확정여부"
        Me.GV1_IS_CONFIRMED.FieldName = "IS_CONFIRMED"
        Me.GV1_IS_CONFIRMED.Name = "GV1_IS_CONFIRMED"
        Me.GV1_IS_CONFIRMED.OptionsColumn.AllowEdit = False
        Me.GV1_IS_CONFIRMED.OptionsColumn.ReadOnly = True
        Me.GV1_IS_CONFIRMED.Visible = True
        Me.GV1_IS_CONFIRMED.VisibleIndex = 16
        Me.GV1_IS_CONFIRMED.Width = 50
        Me.Localizer1.SetWordID(Me.GV1_IS_CONFIRMED, "전송확정여부")
        '
        'GV1_CREATE_YMDHM
        '
        Me.GV1_CREATE_YMDHM.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_CREATE_YMDHM.AppearanceCell.Options.UseFont = True
        Me.GV1_CREATE_YMDHM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CREATE_YMDHM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CREATE_YMDHM.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_CREATE_YMDHM.AppearanceHeader.Options.UseFont = True
        Me.GV1_CREATE_YMDHM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CREATE_YMDHM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CREATE_YMDHM.Caption = "파일생성시간"
        Me.GV1_CREATE_YMDHM.FieldName = "CREATE_YMDHM"
        Me.GV1_CREATE_YMDHM.Name = "GV1_CREATE_YMDHM"
        Me.GV1_CREATE_YMDHM.OptionsColumn.AllowEdit = False
        Me.GV1_CREATE_YMDHM.OptionsColumn.ReadOnly = True
        Me.GV1_CREATE_YMDHM.Visible = True
        Me.GV1_CREATE_YMDHM.VisibleIndex = 17
        Me.GV1_CREATE_YMDHM.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_CREATE_YMDHM, "파일생성시간")
        '
        'GV1_SEND_YMDHM
        '
        Me.GV1_SEND_YMDHM.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_YMDHM.AppearanceCell.Options.UseFont = True
        Me.GV1_SEND_YMDHM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SEND_YMDHM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEND_YMDHM.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_SEND_YMDHM.AppearanceHeader.Options.UseFont = True
        Me.GV1_SEND_YMDHM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SEND_YMDHM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SEND_YMDHM.Caption = "파일전송시간"
        Me.GV1_SEND_YMDHM.FieldName = "SEND_YMDHM"
        Me.GV1_SEND_YMDHM.Name = "GV1_SEND_YMDHM"
        Me.GV1_SEND_YMDHM.OptionsColumn.AllowEdit = False
        Me.GV1_SEND_YMDHM.OptionsColumn.ReadOnly = True
        Me.GV1_SEND_YMDHM.Visible = True
        Me.GV1_SEND_YMDHM.VisibleIndex = 18
        Me.GV1_SEND_YMDHM.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_SEND_YMDHM, "파일전송시간")
        '
        'GV1_IS_VALID
        '
        Me.GV1_IS_VALID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_IS_VALID.AppearanceCell.Options.UseFont = True
        Me.GV1_IS_VALID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_IS_VALID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_IS_VALID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_IS_VALID.AppearanceHeader.Options.UseFont = True
        Me.GV1_IS_VALID.Caption = "최종여부"
        Me.GV1_IS_VALID.FieldName = "IS_VALID"
        Me.GV1_IS_VALID.Name = "GV1_IS_VALID"
        Me.GV1_IS_VALID.OptionsColumn.AllowEdit = False
        Me.GV1_IS_VALID.OptionsColumn.ReadOnly = True
        Me.GV1_IS_VALID.Visible = True
        Me.GV1_IS_VALID.VisibleIndex = 19
        Me.GV1_IS_VALID.Width = 60
        Me.Localizer1.SetWordID(Me.GV1_IS_VALID, "최종여부")
        '
        'GV1_ACK_ID
        '
        Me.GV1_ACK_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_ACK_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_ACK_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_ACK_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_ACK_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_ACK_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_ACK_ID.Caption = "시스템응답ID"
        Me.GV1_ACK_ID.FieldName = "ACK_ID"
        Me.GV1_ACK_ID.Name = "GV1_ACK_ID"
        Me.GV1_ACK_ID.OptionsColumn.AllowEdit = False
        Me.GV1_ACK_ID.OptionsColumn.ReadOnly = True
        Me.GV1_ACK_ID.Visible = True
        Me.GV1_ACK_ID.VisibleIndex = 20
        Me.GV1_ACK_ID.Width = 70
        Me.Localizer1.SetWordID(Me.GV1_ACK_ID, "시스템응답ID")
        '
        'GV1_GENRES_ID
        '
        Me.GV1_GENRES_ID.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_GENRES_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_GENRES_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_GENRES_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1_GENRES_ID.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.GV1_GENRES_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_GENRES_ID.Caption = "사용자응답ID"
        Me.GV1_GENRES_ID.FieldName = "GENRES_ID"
        Me.GV1_GENRES_ID.Name = "GV1_GENRES_ID"
        Me.GV1_GENRES_ID.OptionsColumn.AllowEdit = False
        Me.GV1_GENRES_ID.OptionsColumn.ReadOnly = True
        Me.GV1_GENRES_ID.Visible = True
        Me.GV1_GENRES_ID.VisibleIndex = 21
        Me.GV1_GENRES_ID.Width = 70
        Me.Localizer1.SetWordID(Me.GV1_GENRES_ID, "사용자응답ID")
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
        Me.FGV1_INS_USR.Visible = True
        Me.FGV1_INS_USR.VisibleIndex = 22
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
        Me.FGV1_INS_YMD.Visible = True
        Me.FGV1_INS_YMD.VisibleIndex = 23
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
        Me.FGV1_UPD_USR.Visible = True
        Me.FGV1_UPD_USR.VisibleIndex = 24
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
        Me.FGV1_UPD_YMD.Visible = True
        Me.FGV1_UPD_YMD.VisibleIndex = 25
        Me.FGV1_UPD_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.FGV1_UPD_YMD, "Modified Date")
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
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_EDI_ID, "전송번호")
        Me.Localizer1.SetWordID(Me.GV1_TRANS_TYPE, "전송타입")
        Me.Localizer1.SetWordID(Me.GV1_CUSTOMS_CD, "세관코드")
        Me.Localizer1.SetWordID(Me.GV1_SYS_ID, "시스템ID")
        Me.Localizer1.SetWordID(Me.GV1_SPEC_CD, "문서종류")
        Me.Localizer1.SetWordID(Me.GV1_SPEC_VER, "문서버전")
        Me.Localizer1.SetWordID(Me.GV1_SEND_CD, "전송자")
        Me.Localizer1.SetWordID(Me.GV1_RECV_ID, "수신자")
        Me.Localizer1.SetWordID(Me.GV1_FUNC_TYPE, "처리타입")
        Me.Localizer1.SetWordID(Me.GV1_DOC_NO, "문서번호")
        Me.Localizer1.SetWordID(Me.GV1_SEND_CNT, "전송횟수")
        Me.Localizer1.SetWordID(Me.GV1_UPPER_EDI_ID, "이전전송번호")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "업무구분")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        Me.Localizer1.SetWordID(Me.GV1_FILE_NM, "파일명")
        Me.Localizer1.SetWordID(Me.GV1_IS_CONFIRMED, "전송확정여부")
        Me.Localizer1.SetWordID(Me.GV1_CREATE_YMDHM, "파일생성시간")
        Me.Localizer1.SetWordID(Me.GV1_SEND_YMDHM, "파일전송시간")
        Me.Localizer1.SetWordID(Me.GV1_IS_VALID, "최종여부")
        Me.Localizer1.SetWordID(Me.GV1_ACK_ID, "시스템응답ID")
        Me.Localizer1.SetWordID(Me.GV1_GENRES_ID, "사용자응답ID")
        Me.Localizer1.SetWordID(Me.FGV1_INS_USR, "Creator")
        Me.Localizer1.SetWordID(Me.FGV1_INS_YMD, "Created Date")
        Me.Localizer1.SetWordID(Me.FGV1_UPD_USR, "Modifier")
        Me.Localizer1.SetWordID(Me.FGV1_UPD_YMD, "Modified Date")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.LBL_INS_YMD, "파일전송일자")
        Me.Localizer1.SetWordID(Me.TO_YMD, "")
        Me.Localizer1.SetWordID(Me.Label32, "~")
        Me.Localizer1.SetWordID(Me.FM_YMD, "")
        Me.Localizer1.SetWordID(Me.LBL_EDI_ID, "전송번호")
        Me.Localizer1.SetWordID(Me.EDI_ID, "")
        Me.Localizer1.SetWordID(Me.TRIG_CD, "")
        Me.Localizer1.SetWordID(Me.DEST_CD, "")
        Me.Localizer1.SetWordID(Me.ORGN_CD, "")
        Me.Localizer1.SetWordID(Me.Label7, "*Destination Office")
        Me.Localizer1.SetWordID(Me.Label6, "* Origin Office")
        Me.Localizer1.SetWordID(Me.Label8, "Trig Office")
        Me.Localizer1.SetWordID(Me.Label101, "Booking Carrier Type")
        Me.Localizer1.SetWordID(Me.Label54, "*Biz Type")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LBL_INS_YMD)
        Me.PanelControl1.Controls.Add(Me.TO_YMD)
        Me.PanelControl1.Controls.Add(Me.Label32)
        Me.PanelControl1.Controls.Add(Me.FM_YMD)
        Me.PanelControl1.Controls.Add(Me.LBL_EDI_ID)
        Me.PanelControl1.Controls.Add(Me.EDI_ID)
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
        'LBL_INS_YMD
        '
        Me.LBL_INS_YMD.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBL_INS_YMD.LabelFor = Nothing
        Me.LBL_INS_YMD.Location = New System.Drawing.Point(5, 8)
        Me.LBL_INS_YMD.Name = "LBL_INS_YMD"
        Me.LBL_INS_YMD.Size = New System.Drawing.Size(110, 22)
        Me.LBL_INS_YMD.TabIndex = 372
        Me.LBL_INS_YMD.Text = "파일전송일자"
        Me.LBL_INS_YMD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_INS_YMD, "파일전송일자")
        '
        'TO_YMD
        '
        Me.TO_YMD.BorderColor = System.Drawing.Color.Silver
        Me.TO_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TO_YMD.DefVal = ""
        Me.TO_YMD.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.TO_YMD.IconVisible = True
        Me.TO_YMD.IsDataStateAware = True
        Me.TO_YMD.Location = New System.Drawing.Point(241, 7)
        Me.TO_YMD.Name = "TO_YMD"
        Me.TO_YMD.NextFocus = "btnSearch"
        Me.TO_YMD.Size = New System.Drawing.Size(92, 25)
        Me.TO_YMD.TabIndex = 371
        Me.Localizer1.SetWordID(Me.TO_YMD, "")
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.Label32.LabelFor = Nothing
        Me.Label32.Location = New System.Drawing.Point(219, 8)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 22)
        Me.Label32.TabIndex = 370
        Me.Label32.Text = "~"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Localizer1.SetWordID(Me.Label32, "~")
        '
        'FM_YMD
        '
        Me.FM_YMD.BorderColor = System.Drawing.Color.Silver
        Me.FM_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FM_YMD.DefVal = ""
        Me.FM_YMD.Font = New System.Drawing.Font("맑은 고딕", 9.75!)
        Me.FM_YMD.IconVisible = True
        Me.FM_YMD.IsDataStateAware = True
        Me.FM_YMD.Location = New System.Drawing.Point(121, 7)
        Me.FM_YMD.Name = "FM_YMD"
        Me.FM_YMD.NextFocus = "TO_YMD"
        Me.FM_YMD.Size = New System.Drawing.Size(92, 25)
        Me.FM_YMD.TabIndex = 369
        Me.Localizer1.SetWordID(Me.FM_YMD, "")
        '
        'LBL_EDI_ID
        '
        Me.LBL_EDI_ID.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBL_EDI_ID.LabelFor = Nothing
        Me.LBL_EDI_ID.Location = New System.Drawing.Point(336, 8)
        Me.LBL_EDI_ID.Name = "LBL_EDI_ID"
        Me.LBL_EDI_ID.Size = New System.Drawing.Size(110, 22)
        Me.LBL_EDI_ID.TabIndex = 368
        Me.LBL_EDI_ID.Text = "전송번호"
        Me.LBL_EDI_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_EDI_ID, "전송번호")
        '
        'EDI_ID
        '
        Me.EDI_ID.BorderColor = System.Drawing.Color.Silver
        Me.EDI_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EDI_ID.DefVal = ""
        Me.EDI_ID.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.EDI_ID.IsDataStateAware = True
        Me.EDI_ID.Location = New System.Drawing.Point(452, 7)
        Me.EDI_ID.MaxLength = 20
        Me.EDI_ID.Name = "EDI_ID"
        Me.EDI_ID.NextFocus = "FM_YMD"
        Me.EDI_ID.Size = New System.Drawing.Size(182, 25)
        Me.EDI_ID.TabIndex = 1
        Me.EDI_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
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
        'YjediManageList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1527, 777)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "YjediManageList"
        Me.Text = "송수신 파일내역 조회"
        Me.Localizer1.SetWordID(Me, "송수신 파일내역 조회")
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents btnNew As SCControls.Button
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents EDI_ID As SCControls.TextBox
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
    Friend WithEvents GV1_CUSTOMS_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SYS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_EDI_ID As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GV1_TRANS_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents GV1_SPEC_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SPEC_VER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SEND_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RECV_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FUNC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DOC_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SEND_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_SVC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FILE_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGV1_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_UPPER_EDI_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_IS_CONFIRMED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CREATE_YMDHM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SEND_YMDHM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LBL_EDI_ID As SCControls.Label
    Friend WithEvents GV1_IS_VALID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_ACK_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_GENRES_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LBL_INS_YMD As SCControls.Label
    Friend WithEvents TO_YMD As SCControls.DateBox
    Friend WithEvents Label32 As SCControls.Label
    Friend WithEvents FM_YMD As SCControls.DateBox
End Class
