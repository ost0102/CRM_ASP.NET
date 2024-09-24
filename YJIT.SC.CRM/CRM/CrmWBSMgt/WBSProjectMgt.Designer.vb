<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WBSProjectMgt
    Inherits YJIT.SC.UI.SCView

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WBSProjectMgt))
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.btnDelete = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.MNGT_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_MNGT_NO = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_RMK = New YJIT.SC.UI.SCControls.Label()
        Me.RMK = New YJIT.SC.UI.SCControls.TextBox()
        Me.PROJECT_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_PROJECT_NM = New YJIT.SC.UI.SCControls.Label()
        Me.USR_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_USR_ID = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_YMD = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_YMD2 = New YJIT.SC.UI.SCControls.Label()
        Me.FM_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.TO_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROJECT_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit2 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.DB_FM_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.FM_DAY = New YJIT.SC.UI.SCControls.TextBox()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnSave, "저장(&S)")
        Me.Localizer1.SetWordID(Me.btnNew, "신규(&N)")
        Me.Localizer1.SetWordID(Me.btnDelete, "삭제(&D)")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.MNGT_NO, "")
        Me.Localizer1.SetWordID(Me.lbl_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.lbl_RMK, "비고")
        Me.Localizer1.SetWordID(Me.RMK, "")
        Me.Localizer1.SetWordID(Me.PROJECT_NM, "")
        Me.Localizer1.SetWordID(Me.lbl_PROJECT_NM, "프로젝트명")
        Me.Localizer1.SetWordID(Me.USR_ID, "")
        Me.Localizer1.SetWordID(Me.lbl_USR_ID, "담당자")
        Me.Localizer1.SetWordID(Me.lbl_YMD, "프로젝트 기간")
        Me.Localizer1.SetWordID(Me.lbl_YMD2, "~")
        Me.Localizer1.SetWordID(Me.FM_YMD, "")
        Me.Localizer1.SetWordID(Me.TO_YMD, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV1_PROJECT_NM, "프로젝트명")
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.DB_FM_YMD, "")
        Me.Localizer1.SetWordID(Me.FM_DAY, "")
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(471, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 25)
        Me.btnSave.TabIndex = 101
        Me.btnSave.Text = "저장(&S)"
        Me.Localizer1.SetWordID(Me.btnSave, "저장(&S)")
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.[New]
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(391, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(74, 25)
        Me.btnNew.TabIndex = 100
        Me.btnNew.Text = "신규(&N)"
        Me.Localizer1.SetWordID(Me.btnNew, "신규(&N)")
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.btnDelete.Appearance.Options.UseFont = True
        Me.btnDelete.ButtonType = YJIT.SC.UI.ButtonTypes.Delete
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(551, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 25)
        Me.btnDelete.TabIndex = 103
        Me.btnDelete.Text = "삭제(&D)"
        Me.Localizer1.SetWordID(Me.btnDelete, "삭제(&D)")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Controls.Add(Me.btnDelete)
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(632, 32)
        Me.palAutoButton.TabIndex = 2
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(315, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 104
        Me.btnSearch.Text = "Se&arch"
        Me.btnSearch.Visible = False
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'MNGT_NO
        '
        Me.MNGT_NO.BorderColor = System.Drawing.Color.Silver
        Me.MNGT_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MNGT_NO.DefVal = ""
        Me.MNGT_NO.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.MNGT_NO.IsDataStateAware = True
        Me.MNGT_NO.Location = New System.Drawing.Point(91, 20)
        Me.MNGT_NO.MaxLength = 20
        Me.MNGT_NO.Name = "MNGT_NO"
        Me.MNGT_NO.NextFocus = ""
        Me.MNGT_NO.ReadOnly = True
        Me.MNGT_NO.Size = New System.Drawing.Size(226, 23)
        Me.MNGT_NO.TabIndex = 112
        Me.MNGT_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'lbl_MNGT_NO
        '
        Me.lbl_MNGT_NO.AutoSize = True
        Me.lbl_MNGT_NO.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.lbl_MNGT_NO.LabelFor = Nothing
        Me.lbl_MNGT_NO.Location = New System.Drawing.Point(30, 22)
        Me.lbl_MNGT_NO.Name = "lbl_MNGT_NO"
        Me.lbl_MNGT_NO.Size = New System.Drawing.Size(55, 15)
        Me.lbl_MNGT_NO.TabIndex = 111
        Me.lbl_MNGT_NO.Text = "관리번호"
        Me.lbl_MNGT_NO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_MNGT_NO, "관리번호")
        '
        'lbl_RMK
        '
        Me.lbl_RMK.AutoSize = True
        Me.lbl_RMK.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.lbl_RMK.LabelFor = Nothing
        Me.lbl_RMK.Location = New System.Drawing.Point(54, 172)
        Me.lbl_RMK.Name = "lbl_RMK"
        Me.lbl_RMK.Size = New System.Drawing.Size(31, 15)
        Me.lbl_RMK.TabIndex = 113
        Me.lbl_RMK.Text = "비고"
        Me.lbl_RMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_RMK, "비고")
        '
        'RMK
        '
        Me.RMK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RMK.BorderColor = System.Drawing.Color.Silver
        Me.RMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RMK.DefVal = ""
        Me.RMK.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.RMK.IsDataStateAware = True
        Me.RMK.Location = New System.Drawing.Point(91, 170)
        Me.RMK.MaxLength = 300
        Me.RMK.Multiline = True
        Me.RMK.Name = "RMK"
        Me.RMK.NextFocus = "btnSave"
        Me.RMK.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.RMK.Size = New System.Drawing.Size(264, 320)
        Me.RMK.TabIndex = 4
        Me.RMK.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'PROJECT_NM
        '
        Me.PROJECT_NM.BorderColor = System.Drawing.Color.Silver
        Me.PROJECT_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PROJECT_NM.DefVal = ""
        Me.PROJECT_NM.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.PROJECT_NM.IsDataStateAware = True
        Me.PROJECT_NM.Location = New System.Drawing.Point(91, 57)
        Me.PROJECT_NM.MaxLength = 100
        Me.PROJECT_NM.Name = "PROJECT_NM"
        Me.PROJECT_NM.NextFocus = "USR_ID"
        Me.PROJECT_NM.Size = New System.Drawing.Size(226, 23)
        Me.PROJECT_NM.TabIndex = 0
        Me.PROJECT_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'lbl_PROJECT_NM
        '
        Me.lbl_PROJECT_NM.AutoSize = True
        Me.lbl_PROJECT_NM.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.lbl_PROJECT_NM.LabelFor = Nothing
        Me.lbl_PROJECT_NM.Location = New System.Drawing.Point(18, 59)
        Me.lbl_PROJECT_NM.Name = "lbl_PROJECT_NM"
        Me.lbl_PROJECT_NM.Size = New System.Drawing.Size(67, 15)
        Me.lbl_PROJECT_NM.TabIndex = 115
        Me.lbl_PROJECT_NM.Text = "프로젝트명"
        Me.lbl_PROJECT_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_PROJECT_NM, "프로젝트명")
        '
        'USR_ID
        '
        Me.USR_ID.BorderColor = System.Drawing.Color.Silver
        Me.USR_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.USR_ID.DefVal = ""
        Me.USR_ID.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.USR_ID.IsDataStateAware = True
        Me.USR_ID.Location = New System.Drawing.Point(91, 95)
        Me.USR_ID.MaxLength = 10
        Me.USR_ID.Name = "USR_ID"
        Me.USR_ID.NextFocus = "FM_YMD"
        Me.USR_ID.Size = New System.Drawing.Size(90, 23)
        Me.USR_ID.TabIndex = 1
        Me.USR_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'lbl_USR_ID
        '
        Me.lbl_USR_ID.AutoSize = True
        Me.lbl_USR_ID.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.lbl_USR_ID.LabelFor = Nothing
        Me.lbl_USR_ID.Location = New System.Drawing.Point(42, 97)
        Me.lbl_USR_ID.Name = "lbl_USR_ID"
        Me.lbl_USR_ID.Size = New System.Drawing.Size(43, 15)
        Me.lbl_USR_ID.TabIndex = 117
        Me.lbl_USR_ID.Text = "담당자"
        Me.lbl_USR_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_USR_ID, "담당자")
        '
        'lbl_YMD
        '
        Me.lbl_YMD.AutoSize = True
        Me.lbl_YMD.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.lbl_YMD.LabelFor = Nothing
        Me.lbl_YMD.Location = New System.Drawing.Point(2, 133)
        Me.lbl_YMD.Name = "lbl_YMD"
        Me.lbl_YMD.Size = New System.Drawing.Size(83, 15)
        Me.lbl_YMD.TabIndex = 119
        Me.lbl_YMD.Text = "프로젝트 기간"
        Me.lbl_YMD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_YMD, "프로젝트 기간")
        '
        'lbl_YMD2
        '
        Me.lbl_YMD2.LabelFor = Nothing
        Me.lbl_YMD2.Location = New System.Drawing.Point(196, 131)
        Me.lbl_YMD2.Name = "lbl_YMD2"
        Me.lbl_YMD2.Size = New System.Drawing.Size(16, 22)
        Me.lbl_YMD2.TabIndex = 167
        Me.lbl_YMD2.Text = "~"
        Me.lbl_YMD2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Localizer1.SetWordID(Me.lbl_YMD2, "~")
        '
        'FM_YMD
        '
        Me.FM_YMD.BorderColor = System.Drawing.Color.Silver
        Me.FM_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FM_YMD.DefVal = ""
        Me.FM_YMD.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.FM_YMD.IconVisible = True
        Me.FM_YMD.IsDataStateAware = True
        Me.FM_YMD.Location = New System.Drawing.Point(91, 132)
        Me.FM_YMD.Name = "FM_YMD"
        Me.FM_YMD.NextFocus = "TO_YMD"
        Me.FM_YMD.Size = New System.Drawing.Size(102, 23)
        Me.FM_YMD.TabIndex = 2
        Me.Localizer1.SetWordID(Me.FM_YMD, "")
        '
        'TO_YMD
        '
        Me.TO_YMD.BorderColor = System.Drawing.Color.Silver
        Me.TO_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TO_YMD.DefVal = ""
        Me.TO_YMD.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.TO_YMD.IconVisible = True
        Me.TO_YMD.IsDataStateAware = True
        Me.TO_YMD.Location = New System.Drawing.Point(215, 132)
        Me.TO_YMD.Name = "TO_YMD"
        Me.TO_YMD.NextFocus = "RMK"
        Me.TO_YMD.Size = New System.Drawing.Size(102, 23)
        Me.TO_YMD.TabIndex = 3
        Me.Localizer1.SetWordID(Me.TO_YMD, "")
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
        Me.WG1.Location = New System.Drawing.Point(0, 0)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit2})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(266, 490)
        Me.WG1.TabIndex = 1
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GridView1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_MNGT_NO, Me.GV1_PROJECT_NM})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsBehavior.ReadOnly = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.ViewCaption = "Master List"
        '
        'GV1_MNGT_NO
        '
        Me.GV1_MNGT_NO.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.GV1_MNGT_NO.AppearanceCell.Options.UseFont = True
        Me.GV1_MNGT_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_MNGT_NO.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseFont = True
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.Caption = "관리번호"
        Me.GV1_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV1_MNGT_NO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_MNGT_NO.Name = "GV1_MNGT_NO"
        Me.GV1_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        '
        'GV1_PROJECT_NM
        '
        Me.GV1_PROJECT_NM.AppearanceCell.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.GV1_PROJECT_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_PROJECT_NM.AppearanceHeader.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.GV1_PROJECT_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_PROJECT_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PROJECT_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROJECT_NM.Caption = "프로젝트명"
        Me.GV1_PROJECT_NM.FieldName = "PROJECT_NM"
        Me.GV1_PROJECT_NM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_PROJECT_NM.Name = "GV1_PROJECT_NM"
        Me.GV1_PROJECT_NM.OptionsColumn.AllowEdit = False
        Me.GV1_PROJECT_NM.OptionsColumn.ReadOnly = True
        Me.GV1_PROJECT_NM.Visible = True
        Me.GV1_PROJECT_NM.VisibleIndex = 0
        Me.GV1_PROJECT_NM.Width = 220
        Me.Localizer1.SetWordID(Me.GV1_PROJECT_NM, "프로젝트명")
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
        'GridView1
        '
        Me.GridView1.GridControl = Me.WG1
        Me.GridView1.Name = "GridView1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Location = New System.Drawing.Point(6, 43)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.WG1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.DB_FM_YMD)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.FM_DAY)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.TO_YMD)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.FM_YMD)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lbl_YMD2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lbl_YMD)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lbl_USR_ID)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.USR_ID)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lbl_PROJECT_NM)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PROJECT_NM)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.RMK)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lbl_RMK)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lbl_MNGT_NO)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.MNGT_NO)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(627, 493)
        Me.SplitContainerControl1.SplitterPosition = 268
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "")
        '
        'DB_FM_YMD
        '
        Me.DB_FM_YMD.BorderColor = System.Drawing.Color.Silver
        Me.DB_FM_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DB_FM_YMD.DefVal = ""
        Me.DB_FM_YMD.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.DB_FM_YMD.IconVisible = True
        Me.DB_FM_YMD.IsDataStateAware = True
        Me.DB_FM_YMD.Location = New System.Drawing.Point(10, 250)
        Me.DB_FM_YMD.Name = "DB_FM_YMD"
        Me.DB_FM_YMD.NextFocus = "TO_YMD"
        Me.DB_FM_YMD.Size = New System.Drawing.Size(102, 23)
        Me.DB_FM_YMD.TabIndex = 170
        Me.DB_FM_YMD.Visible = False
        Me.Localizer1.SetWordID(Me.DB_FM_YMD, "")
        '
        'FM_DAY
        '
        Me.FM_DAY.BorderColor = System.Drawing.Color.Silver
        Me.FM_DAY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FM_DAY.DefVal = ""
        Me.FM_DAY.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.FM_DAY.IsDataStateAware = True
        Me.FM_DAY.Location = New System.Drawing.Point(21, 211)
        Me.FM_DAY.MaxLength = 5
        Me.FM_DAY.Name = "FM_DAY"
        Me.FM_DAY.NextFocus = ""
        Me.FM_DAY.Size = New System.Drawing.Size(74, 23)
        Me.FM_DAY.TabIndex = 169
        Me.FM_DAY.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.FM_DAY.Visible = False
        '
        'WBSProjectMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(639, 540)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "WBSProjectMgt"
        Me.Text = "WBS Project Management"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents btnSave As UI.SCControls.Button
    Friend WithEvents btnNew As UI.SCControls.Button
    Friend WithEvents btnDelete As UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_MNGT_NO As UI.SCControls.Label
    Friend WithEvents lbl_RMK As UI.SCControls.Label
    Friend WithEvents RMK As UI.SCControls.TextBox
    Friend WithEvents lbl_PROJECT_NM As UI.SCControls.Label
    Friend WithEvents lbl_USR_ID As UI.SCControls.Label
    Friend WithEvents lbl_YMD As UI.SCControls.Label
    Friend WithEvents lbl_YMD2 As UI.SCControls.Label
    Public WithEvents FM_YMD As UI.SCControls.DateBox
    Public WithEvents TO_YMD As UI.SCControls.DateBox
    Friend WithEvents WG1 As UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROJECT_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateBoxEdit2 As UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Public WithEvents MNGT_NO As UI.SCControls.TextBox
    Public WithEvents PROJECT_NM As UI.SCControls.TextBox
    Public WithEvents USR_ID As UI.SCControls.TextBox
    Friend WithEvents btnSearch As UI.SCControls.Button
    Public WithEvents FM_DAY As UI.SCControls.TextBox
    Public WithEvents DB_FM_YMD As UI.SCControls.DateBox
End Class
