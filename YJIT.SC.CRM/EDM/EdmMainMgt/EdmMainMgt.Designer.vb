<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EdmMainMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EdmMainMgt))
        Me.RepositoryItemDateBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.CMD_FIND = New YJIT.SC.UI.SCControls.Button()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.CMD_EDITER = New YJIT.SC.UI.SCControls.Button()
        Me.CMD_MERGE = New YJIT.SC.UI.SCControls.Button()
        Me.CMD_SAVE = New YJIT.SC.UI.SCControls.Button()
        Me.CMD_CANCEL = New YJIT.SC.UI.SCControls.Button()
        Me.Label11 = New YJIT.SC.UI.SCControls.Label()
        Me.WG_STANDBY = New YJIT.SC.UI.SCControls.WebGrid()
        Me.VSG_STANDBY = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV_STANDBY_CHK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpGV_STANDBY_CHK = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV_STANDBY_EDM_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_STANDBY_EDM_TPIC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_STANDBY_RCVD_SENDER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_STANDBY_EDM_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_STANDBY_RCVD_DTTM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_STANDBY_RCVD_PATH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_STANDBY_RCVD_FILENAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_STANDBY_RCVD_FAXNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Zooms = New YJIT.SC.UI.SCControls.TextBox()
        Me.PAGE = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnTifEmail = New YJIT.SC.UI.SCControls.Button()
        Me.btnTifEdit6 = New YJIT.SC.UI.SCControls.Button()
        Me.btnTifEdit5 = New YJIT.SC.UI.SCControls.Button()
        Me.btnTifEdit2 = New YJIT.SC.UI.SCControls.Button()
        Me.btnWidthHeightFit2 = New YJIT.SC.UI.SCControls.Button()
        Me.btnZoomInOut1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnTifPrint = New YJIT.SC.UI.SCControls.Button()
        Me.btnTifEdit4 = New YJIT.SC.UI.SCControls.Button()
        Me.btnTifEdit1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnWidthHeightFit1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnZoomInOut0 = New YJIT.SC.UI.SCControls.Button()
        Me.btnTifPcSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnTifEdit3 = New YJIT.SC.UI.SCControls.Button()
        Me.btnTifEdit0 = New YJIT.SC.UI.SCControls.Button()
        Me.btnWidthHeightFit0 = New YJIT.SC.UI.SCControls.Button()
        Me.btnLeftRightRotate1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnForntBack1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnLeftRightRotate0 = New YJIT.SC.UI.SCControls.Button()
        Me.btnForntBack0 = New YJIT.SC.UI.SCControls.Button()
        Me.btnZooms = New YJIT.SC.UI.SCControls.Button()
        Me.btnPages = New YJIT.SC.UI.SCControls.Button()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.CMD_VSG_UPLOAD = New YJIT.SC.UI.SCControls.Button()
        Me.CMD_VSG_REFRESH = New YJIT.SC.UI.SCControls.Button()
        Me.CMD_VSG_DEL = New YJIT.SC.UI.SCControls.Button()
        Me.CMD_VSG_MERGE = New YJIT.SC.UI.SCControls.Button()
        Me.grpCtrlStandby = New DevExpress.XtraEditors.GroupControl()
        Me.EDM_TPIC = New YJIT.SC.UI.SCControls.ComboBox()
        Me.EDM_TEAM = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label8 = New YJIT.SC.UI.SCControls.Label()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.EDM_NAME = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label9 = New YJIT.SC.UI.SCControls.Label()
        Me.grpCtrlWork = New DevExpress.XtraEditors.GroupControl()
        Me.CUSTNM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.EDM_PART = New YJIT.SC.UI.SCControls.ComboBox()
        Me.PODCD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.POLCD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.Label16 = New YJIT.SC.UI.SCControls.Label()
        Me.Label15 = New YJIT.SC.UI.SCControls.Label()
        Me.CUSTCD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.Label14 = New YJIT.SC.UI.SCControls.Label()
        Me.Label12 = New YJIT.SC.UI.SCControls.Label()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.Label10 = New YJIT.SC.UI.SCControls.Label()
        Me.WORKNM = New YJIT.SC.UI.SCControls.TextBox()
        Me.DateBox1 = New YJIT.SC.UI.SCControls.DateBox()
        Me.DateBox2 = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label13 = New YJIT.SC.UI.SCControls.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.VSG_EDM_TPIC = New YJIT.SC.UI.SCControls.ComboBox()
        Me.VSG_EDM_TEAM = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label20 = New YJIT.SC.UI.SCControls.Label()
        Me.CMD_VSG_COPY = New YJIT.SC.UI.SCControls.Button()
        Me.CMD_VSG_SAVE = New YJIT.SC.UI.SCControls.Button()
        Me.Label19 = New YJIT.SC.UI.SCControls.Label()
        Me.Label17 = New YJIT.SC.UI.SCControls.Label()
        Me.Label18 = New YJIT.SC.UI.SCControls.Label()
        Me.VSG_EDM_RMK = New YJIT.SC.UI.SCControls.TextBox()
        Me.VSG_EDM_NAME = New YJIT.SC.UI.SCControls.TextBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.ImgThumbnail1 = New AxThumbnailLibCtl.AxImgThumbnail()
        Me.btnThumbnailEdit3 = New YJIT.SC.UI.SCControls.Button()
        Me.btnThumbnailEdit2 = New YJIT.SC.UI.SCControls.Button()
        Me.btnThumbnailEdit1 = New YJIT.SC.UI.SCControls.Button()
        Me.btnThumbnailEdit0 = New YJIT.SC.UI.SCControls.Button()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.WG_EDMDOC = New YJIT.SC.UI.SCControls.WebGrid()
        Me.VSG_EDMDOC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV_EDMDOC_ROWSEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_PSEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_EDOCCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_EDOCNM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_REG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_SAVEDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_SAVEUSER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_FILEPATH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_FILENAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_RCVD_DTTM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_RCVD_FILENAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_EDM_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_DBTIMESTAMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_EDMDOC_DOCIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG_BLNO = New YJIT.SC.UI.SCControls.WebGrid()
        Me.VSG_BLNO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV_BLNO_BLNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_BLNO_DOCNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_BLNO_EDM_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_BLNO_BLGB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_BLNO_BLIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG_SEARCH = New YJIT.SC.UI.SCControls.WebGrid()
        Me.VSG_SEARCH = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV_SEARCH_BLNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_SEARCH_DOCNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_SEARCH_EDM_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_SEARCH_BLGB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_SEARCH_BLIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.ImgEdit1 = New AxImgeditLibCtl.AxImgEdit()
        Me.SplitCtrlImgEdit = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.iconImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New YJIT.SC.UI.SCControls.Button()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.WG_STANDBY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSG_STANDBY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpGV_STANDBY_CHK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grpCtrlStandby, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCtrlStandby.SuspendLayout()
        CType(Me.grpCtrlWork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCtrlWork.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.ImgThumbnail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.WG_EDMDOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSG_EDMDOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG_BLNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSG_BLNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VSG_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.ImgEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitCtrlImgEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitCtrlImgEdit.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
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
        'CMD_FIND
        '
        Me.CMD_FIND.Action = "SearchData"
        Me.CMD_FIND.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMD_FIND.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.CMD_FIND.Image = CType(resources.GetObject("CMD_FIND.Image"), System.Drawing.Image)
        Me.CMD_FIND.Location = New System.Drawing.Point(590, 2)
        Me.CMD_FIND.Name = "CMD_FIND"
        Me.CMD_FIND.Size = New System.Drawing.Size(88, 25)
        Me.CMD_FIND.TabIndex = 1
        Me.CMD_FIND.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.CMD_FIND, "Se&arch")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.CMD_EDITER)
        Me.palAutoButton.Controls.Add(Me.CMD_MERGE)
        Me.palAutoButton.Controls.Add(Me.CMD_SAVE)
        Me.palAutoButton.Controls.Add(Me.CMD_CANCEL)
        Me.palAutoButton.Controls.Add(Me.Button1)
        Me.palAutoButton.Controls.Add(Me.CMD_FIND)
        Me.palAutoButton.Controls.Add(Me.Label11)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 7)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1059, 32)
        Me.palAutoButton.TabIndex = 2
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'CMD_EDITER
        '
        Me.CMD_EDITER.Action = "SaveData"
        Me.CMD_EDITER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMD_EDITER.ButtonType = YJIT.SC.UI.ButtonTypes.General
        Me.CMD_EDITER.Image = CType(resources.GetObject("CMD_EDITER.Image"), System.Drawing.Image)
        Me.CMD_EDITER.Location = New System.Drawing.Point(966, 2)
        Me.CMD_EDITER.Name = "CMD_EDITER"
        Me.CMD_EDITER.Size = New System.Drawing.Size(88, 25)
        Me.CMD_EDITER.TabIndex = 4
        Me.CMD_EDITER.Text = "Doc. Edit"
        Me.Localizer1.SetWordID(Me.CMD_EDITER, "Doc. Edit")
        '
        'CMD_MERGE
        '
        Me.CMD_MERGE.Action = "SaveData"
        Me.CMD_MERGE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMD_MERGE.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.CMD_MERGE.Image = CType(resources.GetObject("CMD_MERGE.Image"), System.Drawing.Image)
        Me.CMD_MERGE.Location = New System.Drawing.Point(872, 2)
        Me.CMD_MERGE.Name = "CMD_MERGE"
        Me.CMD_MERGE.Size = New System.Drawing.Size(88, 25)
        Me.CMD_MERGE.TabIndex = 4
        Me.CMD_MERGE.Text = "Doc. Merge"
        Me.Localizer1.SetWordID(Me.CMD_MERGE, "Doc. Merge")
        '
        'CMD_SAVE
        '
        Me.CMD_SAVE.Action = "SaveData"
        Me.CMD_SAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMD_SAVE.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.CMD_SAVE.Image = CType(resources.GetObject("CMD_SAVE.Image"), System.Drawing.Image)
        Me.CMD_SAVE.Location = New System.Drawing.Point(684, 2)
        Me.CMD_SAVE.Name = "CMD_SAVE"
        Me.CMD_SAVE.Size = New System.Drawing.Size(88, 25)
        Me.CMD_SAVE.TabIndex = 4
        Me.CMD_SAVE.Text = "Doc. &Save"
        Me.Localizer1.SetWordID(Me.CMD_SAVE, "Doc. &Save")
        '
        'CMD_CANCEL
        '
        Me.CMD_CANCEL.Action = "DeleteData"
        Me.CMD_CANCEL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMD_CANCEL.ButtonType = YJIT.SC.UI.ButtonTypes.Delete
        Me.CMD_CANCEL.Image = CType(resources.GetObject("CMD_CANCEL.Image"), System.Drawing.Image)
        Me.CMD_CANCEL.Location = New System.Drawing.Point(778, 2)
        Me.CMD_CANCEL.Name = "CMD_CANCEL"
        Me.CMD_CANCEL.Size = New System.Drawing.Size(88, 25)
        Me.CMD_CANCEL.TabIndex = 1
        Me.CMD_CANCEL.Text = "Doc. Cancel"
        Me.Localizer1.SetWordID(Me.CMD_CANCEL, "Doc. Cancel")
        '
        'Label11
        '
        Me.Label11.LabelFor = Nothing
        Me.Label11.Location = New System.Drawing.Point(122, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(305, 20)
        Me.Label11.TabIndex = 242
        Me.Label11.Text = " Call WheelHook(Me.hWnd) / 권한설정후 버튼 활성화 조건 제거"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label11, "Part")
        '
        'WG_STANDBY
        '
        Me.WG_STANDBY.AllowClientBinding = True
        Me.WG_STANDBY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_STANDBY.DeleteRowConfirmation = True
        Me.WG_STANDBY.DisplayCurrentRow = False
        Me.WG_STANDBY.IsDataStateAware = True
        Me.WG_STANDBY.Location = New System.Drawing.Point(5, 36)
        Me.WG_STANDBY.MainView = Me.VSG_STANDBY
        Me.WG_STANDBY.Name = "WG_STANDBY"
        Me.WG_STANDBY.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpGV_STANDBY_CHK})
        Me.WG_STANDBY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG_STANDBY.SaveLayout = False
        Me.WG_STANDBY.Size = New System.Drawing.Size(303, 374)
        Me.WG_STANDBY.TabIndex = 6
        Me.WG_STANDBY.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG_STANDBY.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VSG_STANDBY})
        '
        'VSG_STANDBY
        '
        Me.VSG_STANDBY.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.VSG_STANDBY.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.VSG_STANDBY.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV_STANDBY_CHK, Me.GV_STANDBY_EDM_NAME, Me.GV_STANDBY_EDM_TPIC, Me.GV_STANDBY_RCVD_SENDER, Me.GV_STANDBY_EDM_RMK, Me.GV_STANDBY_RCVD_DTTM, Me.GV_STANDBY_RCVD_PATH, Me.GV_STANDBY_RCVD_FILENAME, Me.GV_STANDBY_RCVD_FAXNO})
        Me.VSG_STANDBY.GridControl = Me.WG_STANDBY
        Me.VSG_STANDBY.Name = "VSG_STANDBY"
        Me.VSG_STANDBY.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.VSG_STANDBY.OptionsCustomization.AllowRowSizing = True
        Me.VSG_STANDBY.OptionsNavigation.EnterMoveNextColumn = True
        Me.VSG_STANDBY.OptionsView.ColumnAutoWidth = False
        Me.VSG_STANDBY.OptionsView.RowAutoHeight = True
        Me.VSG_STANDBY.OptionsView.ShowGroupPanel = False
        Me.VSG_STANDBY.RowHeight = 10
        Me.VSG_STANDBY.ViewCaption = " 고객 리스트"
        '
        'GV_STANDBY_CHK
        '
        Me.GV_STANDBY_CHK.Caption = "V"
        Me.GV_STANDBY_CHK.ColumnEdit = Me.rpGV_STANDBY_CHK
        Me.GV_STANDBY_CHK.FieldName = "CHK"
        Me.GV_STANDBY_CHK.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV_STANDBY_CHK.Name = "GV_STANDBY_CHK"
        Me.GV_STANDBY_CHK.Visible = True
        Me.GV_STANDBY_CHK.VisibleIndex = 0
        Me.GV_STANDBY_CHK.Width = 20
        Me.Localizer1.SetWordID(Me.GV_STANDBY_CHK, "V")
        '
        'rpGV_STANDBY_CHK
        '
        Me.rpGV_STANDBY_CHK.AutoHeight = False
        Me.rpGV_STANDBY_CHK.DisplayValueChecked = "Y"
        Me.rpGV_STANDBY_CHK.DisplayValueUnchecked = "N"
        Me.rpGV_STANDBY_CHK.Name = "rpGV_STANDBY_CHK"
        Me.rpGV_STANDBY_CHK.ValueChecked = "Y"
        Me.rpGV_STANDBY_CHK.ValueUnchecked = "N"
        '
        'GV_STANDBY_EDM_NAME
        '
        Me.GV_STANDBY_EDM_NAME.AppearanceCell.Options.UseTextOptions = True
        Me.GV_STANDBY_EDM_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_EDM_NAME.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_STANDBY_EDM_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_EDM_NAME.Caption = "Title"
        Me.GV_STANDBY_EDM_NAME.FieldName = "EDM_NAME"
        Me.GV_STANDBY_EDM_NAME.Name = "GV_STANDBY_EDM_NAME"
        Me.GV_STANDBY_EDM_NAME.OptionsColumn.AllowEdit = False
        Me.GV_STANDBY_EDM_NAME.OptionsColumn.ReadOnly = True
        Me.GV_STANDBY_EDM_NAME.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_STANDBY_EDM_NAME.Visible = True
        Me.GV_STANDBY_EDM_NAME.VisibleIndex = 1
        Me.GV_STANDBY_EDM_NAME.Width = 115
        Me.Localizer1.SetWordID(Me.GV_STANDBY_EDM_NAME, "Title")
        '
        'GV_STANDBY_EDM_TPIC
        '
        Me.GV_STANDBY_EDM_TPIC.AppearanceCell.Options.UseTextOptions = True
        Me.GV_STANDBY_EDM_TPIC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_EDM_TPIC.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_STANDBY_EDM_TPIC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_EDM_TPIC.Caption = "담당자"
        Me.GV_STANDBY_EDM_TPIC.FieldName = "EDM_TPIC"
        Me.GV_STANDBY_EDM_TPIC.Name = "GV_STANDBY_EDM_TPIC"
        Me.GV_STANDBY_EDM_TPIC.OptionsColumn.AllowEdit = False
        Me.GV_STANDBY_EDM_TPIC.OptionsColumn.ReadOnly = True
        Me.GV_STANDBY_EDM_TPIC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_STANDBY_EDM_TPIC.Visible = True
        Me.GV_STANDBY_EDM_TPIC.VisibleIndex = 2
        Me.GV_STANDBY_EDM_TPIC.Width = 60
        Me.Localizer1.SetWordID(Me.GV_STANDBY_EDM_TPIC, "담당자")
        '
        'GV_STANDBY_RCVD_SENDER
        '
        Me.GV_STANDBY_RCVD_SENDER.AppearanceCell.Options.UseTextOptions = True
        Me.GV_STANDBY_RCVD_SENDER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_RCVD_SENDER.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_STANDBY_RCVD_SENDER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_RCVD_SENDER.Caption = "Sender"
        Me.GV_STANDBY_RCVD_SENDER.FieldName = "RCVD_SENDER"
        Me.GV_STANDBY_RCVD_SENDER.Name = "GV_STANDBY_RCVD_SENDER"
        Me.GV_STANDBY_RCVD_SENDER.OptionsColumn.AllowEdit = False
        Me.GV_STANDBY_RCVD_SENDER.OptionsColumn.ReadOnly = True
        Me.GV_STANDBY_RCVD_SENDER.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_STANDBY_RCVD_SENDER.Visible = True
        Me.GV_STANDBY_RCVD_SENDER.VisibleIndex = 3
        Me.GV_STANDBY_RCVD_SENDER.Width = 90
        Me.Localizer1.SetWordID(Me.GV_STANDBY_RCVD_SENDER, "Sender")
        '
        'GV_STANDBY_EDM_RMK
        '
        Me.GV_STANDBY_EDM_RMK.AppearanceCell.Options.UseTextOptions = True
        Me.GV_STANDBY_EDM_RMK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_EDM_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_STANDBY_EDM_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_EDM_RMK.Caption = "Remark"
        Me.GV_STANDBY_EDM_RMK.FieldName = "EDM_RMK"
        Me.GV_STANDBY_EDM_RMK.Name = "GV_STANDBY_EDM_RMK"
        Me.GV_STANDBY_EDM_RMK.OptionsColumn.AllowEdit = False
        Me.GV_STANDBY_EDM_RMK.OptionsColumn.ReadOnly = True
        Me.GV_STANDBY_EDM_RMK.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_STANDBY_EDM_RMK.Visible = True
        Me.GV_STANDBY_EDM_RMK.VisibleIndex = 4
        Me.GV_STANDBY_EDM_RMK.Width = 100
        Me.Localizer1.SetWordID(Me.GV_STANDBY_EDM_RMK, "Remark")
        '
        'GV_STANDBY_RCVD_DTTM
        '
        Me.GV_STANDBY_RCVD_DTTM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_STANDBY_RCVD_DTTM.AppearanceCell.Options.UseFont = True
        Me.GV_STANDBY_RCVD_DTTM.AppearanceCell.Options.UseTextOptions = True
        Me.GV_STANDBY_RCVD_DTTM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_RCVD_DTTM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_STANDBY_RCVD_DTTM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_RCVD_DTTM.Caption = "수신시간"
        Me.GV_STANDBY_RCVD_DTTM.FieldName = "RCVD_DTTM"
        Me.GV_STANDBY_RCVD_DTTM.Name = "GV_STANDBY_RCVD_DTTM"
        Me.GV_STANDBY_RCVD_DTTM.OptionsColumn.AllowEdit = False
        Me.GV_STANDBY_RCVD_DTTM.OptionsColumn.ReadOnly = True
        Me.GV_STANDBY_RCVD_DTTM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_STANDBY_RCVD_DTTM.Visible = True
        Me.GV_STANDBY_RCVD_DTTM.VisibleIndex = 5
        Me.GV_STANDBY_RCVD_DTTM.Width = 80
        Me.Localizer1.SetWordID(Me.GV_STANDBY_RCVD_DTTM, "수신시간")
        '
        'GV_STANDBY_RCVD_PATH
        '
        Me.GV_STANDBY_RCVD_PATH.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_STANDBY_RCVD_PATH.AppearanceCell.Options.UseFont = True
        Me.GV_STANDBY_RCVD_PATH.AppearanceCell.Options.UseTextOptions = True
        Me.GV_STANDBY_RCVD_PATH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV_STANDBY_RCVD_PATH.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_STANDBY_RCVD_PATH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_RCVD_PATH.Caption = "파일경로"
        Me.GV_STANDBY_RCVD_PATH.FieldName = "RCVD_PATH"
        Me.GV_STANDBY_RCVD_PATH.Name = "GV_STANDBY_RCVD_PATH"
        Me.GV_STANDBY_RCVD_PATH.OptionsColumn.AllowEdit = False
        Me.GV_STANDBY_RCVD_PATH.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV_STANDBY_RCVD_PATH.OptionsColumn.ReadOnly = True
        Me.GV_STANDBY_RCVD_PATH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_STANDBY_RCVD_PATH.Visible = True
        Me.GV_STANDBY_RCVD_PATH.VisibleIndex = 6
        Me.GV_STANDBY_RCVD_PATH.Width = 150
        Me.Localizer1.SetWordID(Me.GV_STANDBY_RCVD_PATH, "파일경로")
        '
        'GV_STANDBY_RCVD_FILENAME
        '
        Me.GV_STANDBY_RCVD_FILENAME.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_STANDBY_RCVD_FILENAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_RCVD_FILENAME.Caption = "파일명"
        Me.GV_STANDBY_RCVD_FILENAME.FieldName = "RCVD_FILENAME"
        Me.GV_STANDBY_RCVD_FILENAME.Name = "GV_STANDBY_RCVD_FILENAME"
        Me.GV_STANDBY_RCVD_FILENAME.OptionsColumn.AllowEdit = False
        Me.GV_STANDBY_RCVD_FILENAME.OptionsColumn.ReadOnly = True
        Me.GV_STANDBY_RCVD_FILENAME.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_STANDBY_RCVD_FILENAME.Visible = True
        Me.GV_STANDBY_RCVD_FILENAME.VisibleIndex = 7
        Me.GV_STANDBY_RCVD_FILENAME.Width = 400
        Me.Localizer1.SetWordID(Me.GV_STANDBY_RCVD_FILENAME, "파일명")
        '
        'GV_STANDBY_RCVD_FAXNO
        '
        Me.GV_STANDBY_RCVD_FAXNO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_STANDBY_RCVD_FAXNO.AppearanceCell.Options.UseFont = True
        Me.GV_STANDBY_RCVD_FAXNO.AppearanceCell.Options.UseTextOptions = True
        Me.GV_STANDBY_RCVD_FAXNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_RCVD_FAXNO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_STANDBY_RCVD_FAXNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_STANDBY_RCVD_FAXNO.Caption = "수신팩스"
        Me.GV_STANDBY_RCVD_FAXNO.FieldName = "RCVD_FAXNO"
        Me.GV_STANDBY_RCVD_FAXNO.Name = "GV_STANDBY_RCVD_FAXNO"
        Me.GV_STANDBY_RCVD_FAXNO.OptionsColumn.AllowEdit = False
        Me.GV_STANDBY_RCVD_FAXNO.OptionsColumn.ReadOnly = True
        Me.GV_STANDBY_RCVD_FAXNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_STANDBY_RCVD_FAXNO.Visible = True
        Me.GV_STANDBY_RCVD_FAXNO.VisibleIndex = 8
        Me.GV_STANDBY_RCVD_FAXNO.Width = 80
        Me.Localizer1.SetWordID(Me.GV_STANDBY_RCVD_FAXNO, "수신팩스")
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
        Me.Localizer1.SetWordID(Me.CMD_FIND, "Se&arch")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.CMD_EDITER, "Doc. Edit")
        Me.Localizer1.SetWordID(Me.CMD_MERGE, "Doc. Merge")
        Me.Localizer1.SetWordID(Me.CMD_SAVE, "Doc. &Save")
        Me.Localizer1.SetWordID(Me.CMD_CANCEL, "Doc. Cancel")
        Me.Localizer1.SetWordID(Me.Label11, "Part")
        Me.Localizer1.SetWordID(Me.WG_STANDBY, "")
        Me.Localizer1.SetWordID(Me.GV_STANDBY_CHK, "V")
        Me.Localizer1.SetWordID(Me.GV_STANDBY_EDM_NAME, "Title")
        Me.Localizer1.SetWordID(Me.GV_STANDBY_EDM_TPIC, "담당자")
        Me.Localizer1.SetWordID(Me.GV_STANDBY_RCVD_SENDER, "Sender")
        Me.Localizer1.SetWordID(Me.GV_STANDBY_EDM_RMK, "Remark")
        Me.Localizer1.SetWordID(Me.GV_STANDBY_RCVD_DTTM, "수신시간")
        Me.Localizer1.SetWordID(Me.GV_STANDBY_RCVD_PATH, "파일경로")
        Me.Localizer1.SetWordID(Me.GV_STANDBY_RCVD_FILENAME, "파일명")
        Me.Localizer1.SetWordID(Me.GV_STANDBY_RCVD_FAXNO, "수신팩스")
        Me.Localizer1.SetWordID(Me.GridColumn1, "순번")
        Me.Localizer1.SetWordID(Me.GridColumn2, "사이트명")
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처유형")
        Me.Localizer1.SetWordID(Me.GridColumn4, "담당자")
        Me.Localizer1.SetWordID(Me.GridColumn5, "전화")
        Me.Localizer1.SetWordID(Me.GridColumn6, "DB IP")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.Zooms, "100")
        Me.Localizer1.SetWordID(Me.PAGE, "")
        Me.Localizer1.SetWordID(Me.btnTifEmail, "")
        Me.Localizer1.SetWordID(Me.btnTifEdit6, "Thumbnail")
        Me.Localizer1.SetWordID(Me.btnTifEdit5, "Save")
        Me.Localizer1.SetWordID(Me.btnTifEdit2, "")
        Me.Localizer1.SetWordID(Me.btnWidthHeightFit2, "")
        Me.Localizer1.SetWordID(Me.btnZoomInOut1, "")
        Me.Localizer1.SetWordID(Me.btnTifPrint, "")
        Me.Localizer1.SetWordID(Me.btnTifEdit4, "")
        Me.Localizer1.SetWordID(Me.btnTifEdit1, "")
        Me.Localizer1.SetWordID(Me.btnWidthHeightFit1, "")
        Me.Localizer1.SetWordID(Me.btnZoomInOut0, "")
        Me.Localizer1.SetWordID(Me.btnTifPcSave, "")
        Me.Localizer1.SetWordID(Me.btnTifEdit3, "")
        Me.Localizer1.SetWordID(Me.btnTifEdit0, "")
        Me.Localizer1.SetWordID(Me.btnWidthHeightFit0, "")
        Me.Localizer1.SetWordID(Me.btnLeftRightRotate1, "90")
        Me.Localizer1.SetWordID(Me.btnForntBack1, "")
        Me.Localizer1.SetWordID(Me.btnLeftRightRotate0, "90")
        Me.Localizer1.SetWordID(Me.btnForntBack0, "")
        Me.Localizer1.SetWordID(Me.btnZooms, "Zoom           %")
        Me.Localizer1.SetWordID(Me.btnPages, "Page        /   0")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.CMD_VSG_UPLOAD, "File Upload")
        Me.Localizer1.SetWordID(Me.CMD_VSG_REFRESH, "Refresh")
        Me.Localizer1.SetWordID(Me.CMD_VSG_DEL, "Delete")
        Me.Localizer1.SetWordID(Me.CMD_VSG_MERGE, "Merge")
        Me.Localizer1.SetWordID(Me.grpCtrlStandby, "Standby Data Search")
        Me.Localizer1.SetWordID(Me.EDM_TPIC, "--Select--")
        Me.Localizer1.SetWordID(Me.EDM_TEAM, "--Select--")
        Me.Localizer1.SetWordID(Me.Label8, "P.I.C")
        Me.Localizer1.SetWordID(Me.Label7, "Team")
        Me.Localizer1.SetWordID(Me.EDM_NAME, "")
        Me.Localizer1.SetWordID(Me.Label9, "Keyword Search")
        Me.Localizer1.SetWordID(Me.grpCtrlWork, "Work Data Search")
        Me.Localizer1.SetWordID(Me.EDM_PART, "--Select--")
        Me.Localizer1.SetWordID(Me.PODCD, "")
        Me.Localizer1.SetWordID(Me.POLCD, "")
        Me.Localizer1.SetWordID(Me.Label16, "P.O.D")
        Me.Localizer1.SetWordID(Me.Label15, "P.O.L")
        Me.Localizer1.SetWordID(Me.CUSTCD, "")
        Me.Localizer1.SetWordID(Me.Label14, "Customer")
        Me.Localizer1.SetWordID(Me.Label12, "B/L No")
        Me.Localizer1.SetWordID(Me.Label1, "Part")
        Me.Localizer1.SetWordID(Me.Label10, "Date")
        Me.Localizer1.SetWordID(Me.WORKNM, "")
        Me.Localizer1.SetWordID(Me.DateBox1, "")
        Me.Localizer1.SetWordID(Me.DateBox2, "")
        Me.Localizer1.SetWordID(Me.Label13, "~")
        Me.Localizer1.SetWordID(Me.GroupControl1, "Standby Data")
        Me.Localizer1.SetWordID(Me.VSG_EDM_TPIC, "--Select--")
        Me.Localizer1.SetWordID(Me.VSG_EDM_TEAM, "--Select--")
        Me.Localizer1.SetWordID(Me.Label20, "Remark")
        Me.Localizer1.SetWordID(Me.CMD_VSG_COPY, "Copy")
        Me.Localizer1.SetWordID(Me.CMD_VSG_SAVE, "Save")
        Me.Localizer1.SetWordID(Me.Label19, "Title")
        Me.Localizer1.SetWordID(Me.Label17, "P.I.C")
        Me.Localizer1.SetWordID(Me.Label18, "Team")
        Me.Localizer1.SetWordID(Me.VSG_EDM_RMK, "")
        Me.Localizer1.SetWordID(Me.VSG_EDM_NAME, "")
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        Me.Localizer1.SetWordID(Me.ImgThumbnail1, "")
        Me.Localizer1.SetWordID(Me.btnThumbnailEdit3, "Delete")
        Me.Localizer1.SetWordID(Me.btnThumbnailEdit2, "Insert")
        Me.Localizer1.SetWordID(Me.btnThumbnailEdit1, "Change")
        Me.Localizer1.SetWordID(Me.btnThumbnailEdit0, "Split")
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        Me.Localizer1.SetWordID(Me.WG_EDMDOC, "")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_ROWSEQ, "Seq")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_PSEQ, "Print Seq")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_EDOCCD, "Code")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_EDOCNM, "Document")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_REG, "Reg")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_SAVEDATE, "Save Date")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_SAVEUSER, "Save User")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_FILEPATH, "File Path")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_FILENAME, "File Name")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_RCVD_DTTM, "File ID")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_RCVD_FILENAME, "File Name")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_EDM_RMK, "Remark")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_DBTIMESTAMP, "DB TimeStamp")
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_DOCIO, "In/Out")
        Me.Localizer1.SetWordID(Me.WG_BLNO, "")
        Me.Localizer1.SetWordID(Me.GV_BLNO_BLNO, "B/L No")
        Me.Localizer1.SetWordID(Me.GV_BLNO_DOCNO, "Doc. No")
        Me.Localizer1.SetWordID(Me.GV_BLNO_EDM_NO, "Edm No")
        Me.Localizer1.SetWordID(Me.GV_BLNO_BLGB, "BL")
        Me.Localizer1.SetWordID(Me.GV_BLNO_BLIO, "In/Out")
        Me.Localizer1.SetWordID(Me.WG_SEARCH, "")
        Me.Localizer1.SetWordID(Me.GV_SEARCH_BLNO, "B/L No")
        Me.Localizer1.SetWordID(Me.GV_SEARCH_DOCNO, "Doc. No")
        Me.Localizer1.SetWordID(Me.GV_SEARCH_EDM_NO, "Edm No")
        Me.Localizer1.SetWordID(Me.GV_SEARCH_BLGB, "BL")
        Me.Localizer1.SetWordID(Me.GV_SEARCH_BLIO, "In/Out")
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        Me.Localizer1.SetWordID(Me.ImgEdit1, "")
        Me.Localizer1.SetWordID(Me.SplitCtrlImgEdit, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.SplitContainerControl2, "SplitContainerControl2")
        Me.Localizer1.SetWordID(Me.Button1, "Se&arch")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Zooms)
        Me.PanelControl1.Controls.Add(Me.PAGE)
        Me.PanelControl1.Controls.Add(Me.btnTifEmail)
        Me.PanelControl1.Controls.Add(Me.btnTifEdit6)
        Me.PanelControl1.Controls.Add(Me.btnTifEdit5)
        Me.PanelControl1.Controls.Add(Me.btnTifEdit2)
        Me.PanelControl1.Controls.Add(Me.btnWidthHeightFit2)
        Me.PanelControl1.Controls.Add(Me.btnZoomInOut1)
        Me.PanelControl1.Controls.Add(Me.btnTifPrint)
        Me.PanelControl1.Controls.Add(Me.btnTifEdit4)
        Me.PanelControl1.Controls.Add(Me.btnTifEdit1)
        Me.PanelControl1.Controls.Add(Me.btnWidthHeightFit1)
        Me.PanelControl1.Controls.Add(Me.btnZoomInOut0)
        Me.PanelControl1.Controls.Add(Me.btnTifPcSave)
        Me.PanelControl1.Controls.Add(Me.btnTifEdit3)
        Me.PanelControl1.Controls.Add(Me.btnTifEdit0)
        Me.PanelControl1.Controls.Add(Me.btnWidthHeightFit0)
        Me.PanelControl1.Controls.Add(Me.btnLeftRightRotate1)
        Me.PanelControl1.Controls.Add(Me.btnForntBack1)
        Me.PanelControl1.Controls.Add(Me.btnLeftRightRotate0)
        Me.PanelControl1.Controls.Add(Me.btnForntBack0)
        Me.PanelControl1.Controls.Add(Me.btnZooms)
        Me.PanelControl1.Controls.Add(Me.btnPages)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(919, 38)
        Me.PanelControl1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'Zooms
        '
        Me.Zooms.BorderColor = System.Drawing.Color.Silver
        Me.Zooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Zooms.DefVal = ""
        Me.Zooms.IsDataStateAware = True
        Me.Zooms.Location = New System.Drawing.Point(413, 8)
        Me.Zooms.Name = "Zooms"
        Me.Zooms.NextFocus = "NONE"
        Me.Zooms.RequiredFor = ""
        Me.Zooms.Size = New System.Drawing.Size(31, 22)
        Me.Zooms.TabIndex = 1
        Me.Zooms.Text = "100"
        Me.Zooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Zooms.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'PAGE
        '
        Me.PAGE.BorderColor = System.Drawing.Color.Silver
        Me.PAGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PAGE.DefVal = ""
        Me.PAGE.IsDataStateAware = True
        Me.PAGE.Location = New System.Drawing.Point(46, 8)
        Me.PAGE.Name = "PAGE"
        Me.PAGE.NextFocus = "NONE"
        Me.PAGE.RequiredFor = ""
        Me.PAGE.Size = New System.Drawing.Size(26, 22)
        Me.PAGE.TabIndex = 1
        Me.PAGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PAGE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'btnTifEmail
        '
        Me.btnTifEmail.Action = "SaveData"
        Me.btnTifEmail.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnTifEmail.Image = CType(resources.GetObject("btnTifEmail.Image"), System.Drawing.Image)
        Me.btnTifEmail.Location = New System.Drawing.Point(610, 5)
        Me.btnTifEmail.Name = "btnTifEmail"
        Me.btnTifEmail.Size = New System.Drawing.Size(30, 28)
        Me.btnTifEmail.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnTifEmail, "")
        '
        'btnTifEdit6
        '
        Me.btnTifEdit6.Action = "SaveData"
        Me.btnTifEdit6.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnTifEdit6.Location = New System.Drawing.Point(849, 5)
        Me.btnTifEdit6.Name = "btnTifEdit6"
        Me.btnTifEdit6.Size = New System.Drawing.Size(65, 28)
        Me.btnTifEdit6.TabIndex = 7
        Me.btnTifEdit6.Text = "Thumbnail"
        Me.Localizer1.SetWordID(Me.btnTifEdit6, "")
        '
        'btnTifEdit5
        '
        Me.btnTifEdit5.Action = "SaveData"
        Me.btnTifEdit5.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnTifEdit5.Location = New System.Drawing.Point(806, 5)
        Me.btnTifEdit5.Name = "btnTifEdit5"
        Me.btnTifEdit5.Size = New System.Drawing.Size(37, 28)
        Me.btnTifEdit5.TabIndex = 7
        Me.btnTifEdit5.Text = "Save"
        Me.Localizer1.SetWordID(Me.btnTifEdit5, "")
        '
        'btnTifEdit2
        '
        Me.btnTifEdit2.Action = "SaveData"
        Me.btnTifEdit2.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnTifEdit2.Image = CType(resources.GetObject("btnTifEdit2.Image"), System.Drawing.Image)
        Me.btnTifEdit2.Location = New System.Drawing.Point(710, 5)
        Me.btnTifEdit2.Name = "btnTifEdit2"
        Me.btnTifEdit2.Size = New System.Drawing.Size(30, 28)
        Me.btnTifEdit2.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnTifEdit2, "")
        '
        'btnWidthHeightFit2
        '
        Me.btnWidthHeightFit2.Action = "SaveData"
        Me.btnWidthHeightFit2.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnWidthHeightFit2.Image = CType(resources.GetObject("btnWidthHeightFit2.Image"), System.Drawing.Image)
        Me.btnWidthHeightFit2.Location = New System.Drawing.Point(245, 5)
        Me.btnWidthHeightFit2.Name = "btnWidthHeightFit2"
        Me.btnWidthHeightFit2.Size = New System.Drawing.Size(30, 28)
        Me.btnWidthHeightFit2.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnWidthHeightFit2, "")
        '
        'btnZoomInOut1
        '
        Me.btnZoomInOut1.Action = "SaveData"
        Me.btnZoomInOut1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnZoomInOut1.Image = CType(resources.GetObject("btnZoomInOut1.Image"), System.Drawing.Image)
        Me.btnZoomInOut1.Location = New System.Drawing.Point(509, 5)
        Me.btnZoomInOut1.Name = "btnZoomInOut1"
        Me.btnZoomInOut1.Size = New System.Drawing.Size(30, 28)
        Me.btnZoomInOut1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnZoomInOut1, "")
        '
        'btnTifPrint
        '
        Me.btnTifPrint.Action = "PrintData"
        Me.btnTifPrint.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnTifPrint.Image = CType(resources.GetObject("btnTifPrint.Image"), System.Drawing.Image)
        Me.btnTifPrint.Location = New System.Drawing.Point(578, 5)
        Me.btnTifPrint.Name = "btnTifPrint"
        Me.btnTifPrint.Size = New System.Drawing.Size(30, 28)
        Me.btnTifPrint.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnTifPrint, "")
        '
        'btnTifEdit4
        '
        Me.btnTifEdit4.Action = "SaveData"
        Me.btnTifEdit4.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnTifEdit4.Image = CType(resources.GetObject("btnTifEdit4.Image"), System.Drawing.Image)
        Me.btnTifEdit4.Location = New System.Drawing.Point(774, 5)
        Me.btnTifEdit4.Name = "btnTifEdit4"
        Me.btnTifEdit4.Size = New System.Drawing.Size(30, 28)
        Me.btnTifEdit4.TabIndex = 7
        Me.btnTifEdit4.Tag = "HideAnnotationToolPalette"
        Me.Localizer1.SetWordID(Me.btnTifEdit4, "")
        '
        'btnTifEdit1
        '
        Me.btnTifEdit1.Action = "SaveData"
        Me.btnTifEdit1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnTifEdit1.Image = CType(resources.GetObject("btnTifEdit1.Image"), System.Drawing.Image)
        Me.btnTifEdit1.Location = New System.Drawing.Point(678, 5)
        Me.btnTifEdit1.Name = "btnTifEdit1"
        Me.btnTifEdit1.Size = New System.Drawing.Size(30, 28)
        Me.btnTifEdit1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnTifEdit1, "")
        '
        'btnWidthHeightFit1
        '
        Me.btnWidthHeightFit1.Action = "SaveData"
        Me.btnWidthHeightFit1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnWidthHeightFit1.Image = CType(resources.GetObject("btnWidthHeightFit1.Image"), System.Drawing.Image)
        Me.btnWidthHeightFit1.Location = New System.Drawing.Point(213, 5)
        Me.btnWidthHeightFit1.Name = "btnWidthHeightFit1"
        Me.btnWidthHeightFit1.Size = New System.Drawing.Size(30, 28)
        Me.btnWidthHeightFit1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnWidthHeightFit1, "")
        '
        'btnZoomInOut0
        '
        Me.btnZoomInOut0.Action = "SaveData"
        Me.btnZoomInOut0.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnZoomInOut0.Image = CType(resources.GetObject("btnZoomInOut0.Image"), System.Drawing.Image)
        Me.btnZoomInOut0.Location = New System.Drawing.Point(476, 5)
        Me.btnZoomInOut0.Name = "btnZoomInOut0"
        Me.btnZoomInOut0.Size = New System.Drawing.Size(30, 28)
        Me.btnZoomInOut0.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnZoomInOut0, "")
        '
        'btnTifPcSave
        '
        Me.btnTifPcSave.Action = "SaveData"
        Me.btnTifPcSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnTifPcSave.Image = CType(resources.GetObject("btnTifPcSave.Image"), System.Drawing.Image)
        Me.btnTifPcSave.Location = New System.Drawing.Point(545, 5)
        Me.btnTifPcSave.Name = "btnTifPcSave"
        Me.btnTifPcSave.Size = New System.Drawing.Size(30, 28)
        Me.btnTifPcSave.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnTifPcSave, "")
        '
        'btnTifEdit3
        '
        Me.btnTifEdit3.Action = "SaveData"
        Me.btnTifEdit3.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnTifEdit3.Image = CType(resources.GetObject("btnTifEdit3.Image"), System.Drawing.Image)
        Me.btnTifEdit3.Location = New System.Drawing.Point(742, 5)
        Me.btnTifEdit3.Name = "btnTifEdit3"
        Me.btnTifEdit3.Size = New System.Drawing.Size(30, 28)
        Me.btnTifEdit3.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnTifEdit3, "")
        '
        'btnTifEdit0
        '
        Me.btnTifEdit0.Action = "SaveData"
        Me.btnTifEdit0.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnTifEdit0.Image = CType(resources.GetObject("btnTifEdit0.Image"), System.Drawing.Image)
        Me.btnTifEdit0.Location = New System.Drawing.Point(646, 5)
        Me.btnTifEdit0.Name = "btnTifEdit0"
        Me.btnTifEdit0.Size = New System.Drawing.Size(30, 28)
        Me.btnTifEdit0.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnTifEdit0, "")
        '
        'btnWidthHeightFit0
        '
        Me.btnWidthHeightFit0.Action = "SaveData"
        Me.btnWidthHeightFit0.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnWidthHeightFit0.Image = CType(resources.GetObject("btnWidthHeightFit0.Image"), System.Drawing.Image)
        Me.btnWidthHeightFit0.Location = New System.Drawing.Point(181, 5)
        Me.btnWidthHeightFit0.Name = "btnWidthHeightFit0"
        Me.btnWidthHeightFit0.Size = New System.Drawing.Size(30, 28)
        Me.btnWidthHeightFit0.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnWidthHeightFit0, "")
        '
        'btnLeftRightRotate1
        '
        Me.btnLeftRightRotate1.Action = "SaveData"
        Me.btnLeftRightRotate1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnLeftRightRotate1.Image = CType(resources.GetObject("btnLeftRightRotate1.Image"), System.Drawing.Image)
        Me.btnLeftRightRotate1.Location = New System.Drawing.Point(323, 5)
        Me.btnLeftRightRotate1.Name = "btnLeftRightRotate1"
        Me.btnLeftRightRotate1.Size = New System.Drawing.Size(40, 28)
        Me.btnLeftRightRotate1.TabIndex = 7
        Me.btnLeftRightRotate1.Text = "90"
        Me.Localizer1.SetWordID(Me.btnLeftRightRotate1, "")
        '
        'btnForntBack1
        '
        Me.btnForntBack1.Action = "SaveData"
        Me.btnForntBack1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnForntBack1.Image = CType(resources.GetObject("btnForntBack1.Image"), System.Drawing.Image)
        Me.btnForntBack1.Location = New System.Drawing.Point(145, 5)
        Me.btnForntBack1.Name = "btnForntBack1"
        Me.btnForntBack1.Size = New System.Drawing.Size(30, 28)
        Me.btnForntBack1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnForntBack1, "")
        '
        'btnLeftRightRotate0
        '
        Me.btnLeftRightRotate0.Action = "SaveData"
        Me.btnLeftRightRotate0.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnLeftRightRotate0.Image = CType(resources.GetObject("btnLeftRightRotate0.Image"), System.Drawing.Image)
        Me.btnLeftRightRotate0.Location = New System.Drawing.Point(281, 5)
        Me.btnLeftRightRotate0.Name = "btnLeftRightRotate0"
        Me.btnLeftRightRotate0.Size = New System.Drawing.Size(40, 28)
        Me.btnLeftRightRotate0.TabIndex = 7
        Me.btnLeftRightRotate0.Text = "90"
        Me.Localizer1.SetWordID(Me.btnLeftRightRotate0, "")
        '
        'btnForntBack0
        '
        Me.btnForntBack0.Action = "SaveData"
        Me.btnForntBack0.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnForntBack0.Image = CType(resources.GetObject("btnForntBack0.Image"), System.Drawing.Image)
        Me.btnForntBack0.Location = New System.Drawing.Point(113, 5)
        Me.btnForntBack0.Name = "btnForntBack0"
        Me.btnForntBack0.Size = New System.Drawing.Size(30, 28)
        Me.btnForntBack0.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnForntBack0, "")
        '
        'btnZooms
        '
        Me.btnZooms.Action = "SaveData"
        Me.btnZooms.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnZooms.Location = New System.Drawing.Point(369, 5)
        Me.btnZooms.Name = "btnZooms"
        Me.btnZooms.Size = New System.Drawing.Size(101, 28)
        Me.btnZooms.TabIndex = 7
        Me.btnZooms.Text = "Zoom           %"
        Me.Localizer1.SetWordID(Me.btnZooms, "")
        '
        'btnPages
        '
        Me.btnPages.Action = "SaveData"
        Me.btnPages.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnPages.Location = New System.Drawing.Point(6, 5)
        Me.btnPages.Name = "btnPages"
        Me.btnPages.Size = New System.Drawing.Size(101, 28)
        Me.btnPages.TabIndex = 7
        Me.btnPages.Text = "Page        /   0"
        Me.Localizer1.SetWordID(Me.btnPages, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.CMD_VSG_UPLOAD)
        Me.PanelControl2.Controls.Add(Me.CMD_VSG_REFRESH)
        Me.PanelControl2.Controls.Add(Me.CMD_VSG_DEL)
        Me.PanelControl2.Controls.Add(Me.CMD_VSG_MERGE)
        Me.PanelControl2.Controls.Add(Me.WG_STANDBY)
        Me.PanelControl2.Location = New System.Drawing.Point(7, 313)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(313, 414)
        Me.PanelControl2.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'CMD_VSG_UPLOAD
        '
        Me.CMD_VSG_UPLOAD.Action = "NewData"
        Me.CMD_VSG_UPLOAD.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_VSG_UPLOAD.Appearance.Options.UseFont = True
        Me.CMD_VSG_UPLOAD.ButtonType = YJIT.SC.UI.ButtonTypes.[New]
        Me.CMD_VSG_UPLOAD.Image = CType(resources.GetObject("CMD_VSG_UPLOAD.Image"), System.Drawing.Image)
        Me.CMD_VSG_UPLOAD.Location = New System.Drawing.Point(215, 5)
        Me.CMD_VSG_UPLOAD.Name = "CMD_VSG_UPLOAD"
        Me.CMD_VSG_UPLOAD.Size = New System.Drawing.Size(93, 25)
        Me.CMD_VSG_UPLOAD.TabIndex = 7
        Me.CMD_VSG_UPLOAD.Text = "File Upload"
        Me.Localizer1.SetWordID(Me.CMD_VSG_UPLOAD, "File Upload")
        '
        'CMD_VSG_REFRESH
        '
        Me.CMD_VSG_REFRESH.Action = "SearchData"
        Me.CMD_VSG_REFRESH.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.CMD_VSG_REFRESH.Image = CType(resources.GetObject("CMD_VSG_REFRESH.Image"), System.Drawing.Image)
        Me.CMD_VSG_REFRESH.Location = New System.Drawing.Point(145, 5)
        Me.CMD_VSG_REFRESH.Name = "CMD_VSG_REFRESH"
        Me.CMD_VSG_REFRESH.Size = New System.Drawing.Size(69, 25)
        Me.CMD_VSG_REFRESH.TabIndex = 7
        Me.CMD_VSG_REFRESH.Text = "Refresh"
        Me.Localizer1.SetWordID(Me.CMD_VSG_REFRESH, "Refresh")
        '
        'CMD_VSG_DEL
        '
        Me.CMD_VSG_DEL.Action = "DeleteData"
        Me.CMD_VSG_DEL.ButtonType = YJIT.SC.UI.ButtonTypes.Delete
        Me.CMD_VSG_DEL.Image = CType(resources.GetObject("CMD_VSG_DEL.Image"), System.Drawing.Image)
        Me.CMD_VSG_DEL.Location = New System.Drawing.Point(75, 5)
        Me.CMD_VSG_DEL.Name = "CMD_VSG_DEL"
        Me.CMD_VSG_DEL.Size = New System.Drawing.Size(69, 25)
        Me.CMD_VSG_DEL.TabIndex = 7
        Me.CMD_VSG_DEL.Text = "Delete"
        Me.Localizer1.SetWordID(Me.CMD_VSG_DEL, "Delete")
        '
        'CMD_VSG_MERGE
        '
        Me.CMD_VSG_MERGE.Action = "SaveData"
        Me.CMD_VSG_MERGE.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.CMD_VSG_MERGE.Image = CType(resources.GetObject("CMD_VSG_MERGE.Image"), System.Drawing.Image)
        Me.CMD_VSG_MERGE.Location = New System.Drawing.Point(5, 5)
        Me.CMD_VSG_MERGE.Name = "CMD_VSG_MERGE"
        Me.CMD_VSG_MERGE.Size = New System.Drawing.Size(69, 25)
        Me.CMD_VSG_MERGE.TabIndex = 7
        Me.CMD_VSG_MERGE.Text = "Merge"
        Me.Localizer1.SetWordID(Me.CMD_VSG_MERGE, "Merge")
        '
        'grpCtrlStandby
        '
        Me.grpCtrlStandby.Controls.Add(Me.EDM_TPIC)
        Me.grpCtrlStandby.Controls.Add(Me.EDM_TEAM)
        Me.grpCtrlStandby.Controls.Add(Me.Label8)
        Me.grpCtrlStandby.Controls.Add(Me.Label7)
        Me.grpCtrlStandby.Controls.Add(Me.EDM_NAME)
        Me.grpCtrlStandby.Controls.Add(Me.Label9)
        Me.grpCtrlStandby.Location = New System.Drawing.Point(7, 201)
        Me.grpCtrlStandby.Name = "grpCtrlStandby"
        Me.grpCtrlStandby.Size = New System.Drawing.Size(313, 106)
        Me.grpCtrlStandby.TabIndex = 9
        Me.grpCtrlStandby.Text = "Standby Data Search"
        Me.Localizer1.SetWordID(Me.grpCtrlStandby, "Standby Data Search")
        '
        'EDM_TPIC
        '
        Me.EDM_TPIC.CodeType = "YJIT.CodeService.CommonCode"
        Me.EDM_TPIC.ColumnWidths = ""
        Me.EDM_TPIC.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.EDM_TPIC.DataParams = "GroupCode:'EDM02',NameType:''"
        Me.EDM_TPIC.DefVal = ""
        Me.EDM_TPIC.DisplayMember = "NAME"
        Me.EDM_TPIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EDM_TPIC.FormattingEnabled = True
        Me.EDM_TPIC.IsDataStateAware = True
        Me.EDM_TPIC.ItemDelimiter = ","
        Me.EDM_TPIC.ItemTextList = ""
        Me.EDM_TPIC.ItemValueList = ""
        Me.EDM_TPIC.KeepIntegrity = True
        Me.EDM_TPIC.Location = New System.Drawing.Point(85, 51)
        Me.EDM_TPIC.Name = "EDM_TPIC"
        Me.EDM_TPIC.NextFocus = "REF_TIME"
        Me.EDM_TPIC.NullText = "--Select--"
        Me.EDM_TPIC.RequiredFor = ""
        Me.EDM_TPIC.SearchKeys = ""
        Me.EDM_TPIC.Size = New System.Drawing.Size(149, 22)
        Me.EDM_TPIC.TabIndex = 245
        Me.EDM_TPIC.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.EDM_TPIC.ValueMember = "CODE"
        '
        'EDM_TEAM
        '
        Me.EDM_TEAM.CodeType = "YJIT.CodeService.CommonCode"
        Me.EDM_TEAM.ColumnWidths = ""
        Me.EDM_TEAM.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.EDM_TEAM.DataParams = "GroupCode:'EDM01',NameType:''"
        Me.EDM_TEAM.DefVal = ""
        Me.EDM_TEAM.DisplayMember = "NAME"
        Me.EDM_TEAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EDM_TEAM.FormattingEnabled = True
        Me.EDM_TEAM.IsDataStateAware = True
        Me.EDM_TEAM.ItemDelimiter = ","
        Me.EDM_TEAM.ItemTextList = ""
        Me.EDM_TEAM.ItemValueList = ""
        Me.EDM_TEAM.KeepIntegrity = True
        Me.EDM_TEAM.Location = New System.Drawing.Point(85, 27)
        Me.EDM_TEAM.Name = "EDM_TEAM"
        Me.EDM_TEAM.NextFocus = "REF_TIME"
        Me.EDM_TEAM.NullText = "--Select--"
        Me.EDM_TEAM.RequiredFor = ""
        Me.EDM_TEAM.SearchKeys = ""
        Me.EDM_TEAM.Size = New System.Drawing.Size(149, 22)
        Me.EDM_TEAM.TabIndex = 244
        Me.EDM_TEAM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.EDM_TEAM.ValueMember = "CODE"
        '
        'Label8
        '
        Me.Label8.LabelFor = Nothing
        Me.Label8.Location = New System.Drawing.Point(7, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "P.I.C"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label8, "")
        '
        'Label7
        '
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(7, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 242
        Me.Label7.Text = "Team"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label7, "")
        '
        'EDM_NAME
        '
        Me.EDM_NAME.BorderColor = System.Drawing.Color.Silver
        Me.EDM_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EDM_NAME.DefVal = ""
        Me.EDM_NAME.IsDataStateAware = True
        Me.EDM_NAME.Location = New System.Drawing.Point(85, 75)
        Me.EDM_NAME.Name = "EDM_NAME"
        Me.EDM_NAME.NextFocus = "S_ROW_BEST"
        Me.EDM_NAME.RequiredFor = ""
        Me.EDM_NAME.Size = New System.Drawing.Size(223, 22)
        Me.EDM_NAME.TabIndex = 1
        Me.EDM_NAME.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label9
        '
        Me.Label9.LabelFor = Nothing
        Me.Label9.Location = New System.Drawing.Point(11, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 33)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Keyword Search"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label9, "")
        '
        'grpCtrlWork
        '
        Me.grpCtrlWork.Controls.Add(Me.CUSTNM)
        Me.grpCtrlWork.Controls.Add(Me.EDM_PART)
        Me.grpCtrlWork.Controls.Add(Me.PODCD)
        Me.grpCtrlWork.Controls.Add(Me.POLCD)
        Me.grpCtrlWork.Controls.Add(Me.Label16)
        Me.grpCtrlWork.Controls.Add(Me.Label15)
        Me.grpCtrlWork.Controls.Add(Me.CUSTCD)
        Me.grpCtrlWork.Controls.Add(Me.Label14)
        Me.grpCtrlWork.Controls.Add(Me.Label12)
        Me.grpCtrlWork.Controls.Add(Me.Label1)
        Me.grpCtrlWork.Controls.Add(Me.Label10)
        Me.grpCtrlWork.Controls.Add(Me.WORKNM)
        Me.grpCtrlWork.Controls.Add(Me.DateBox1)
        Me.grpCtrlWork.Controls.Add(Me.DateBox2)
        Me.grpCtrlWork.Controls.Add(Me.Label13)
        Me.grpCtrlWork.Location = New System.Drawing.Point(7, 45)
        Me.grpCtrlWork.Name = "grpCtrlWork"
        Me.grpCtrlWork.Size = New System.Drawing.Size(313, 150)
        Me.grpCtrlWork.TabIndex = 9
        Me.grpCtrlWork.Text = "Work Data Search"
        Me.Localizer1.SetWordID(Me.grpCtrlWork, "Work Data Search")
        '
        'CUSTNM
        '
        Me.CUSTNM.AutoEllipsis = True
        Me.CUSTNM.BorderColor = System.Drawing.Color.Silver
        Me.CUSTNM.LabelFor = Nothing
        Me.CUSTNM.Location = New System.Drawing.Point(182, 98)
        Me.CUSTNM.Name = "CUSTNM"
        Me.CUSTNM.Size = New System.Drawing.Size(126, 22)
        Me.CUSTNM.TabIndex = 245
        Me.CUSTNM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EDM_PART
        '
        Me.EDM_PART.CodeType = "YJIT.CodeService.CommonCode"
        Me.EDM_PART.ColumnWidths = ""
        Me.EDM_PART.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.EDM_PART.DataParams = "GroupCode:'EDM01',NameType:''"
        Me.EDM_PART.DefVal = ""
        Me.EDM_PART.DisplayMember = "NAME"
        Me.EDM_PART.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EDM_PART.FormattingEnabled = True
        Me.EDM_PART.IsDataStateAware = True
        Me.EDM_PART.ItemDelimiter = ","
        Me.EDM_PART.ItemTextList = ""
        Me.EDM_PART.ItemValueList = ""
        Me.EDM_PART.KeepIntegrity = True
        Me.EDM_PART.Location = New System.Drawing.Point(85, 26)
        Me.EDM_PART.Name = "EDM_PART"
        Me.EDM_PART.NextFocus = "REF_TIME"
        Me.EDM_PART.NullText = "--Select--"
        Me.EDM_PART.RequiredFor = ""
        Me.EDM_PART.SearchKeys = ""
        Me.EDM_PART.Size = New System.Drawing.Size(149, 22)
        Me.EDM_PART.TabIndex = 244
        Me.EDM_PART.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.EDM_PART.ValueMember = "CODE"
        '
        'PODCD
        '
        Me.PODCD.AlwaysSetDisplayParams = False
        Me.PODCD.AutoSuggestion = False
        Me.PODCD.BorderColor = System.Drawing.Color.Empty
        Me.PODCD.CodeType = ""
        Me.PODCD.DataParams = ""
        Me.PODCD.DefVal = ""
        Me.PODCD.DisplayParams = ""
        Me.PODCD.EditPopup = ""
        Me.PODCD.IconVisible = True
        Me.PODCD.IsDataStateAware = True
        Me.PODCD.KeepIntegrity = True
        Me.PODCD.Location = New System.Drawing.Point(243, 122)
        Me.PODCD.Name = "PODCD"
        Me.PODCD.NextFocus = Nothing
        Me.PODCD.RequiredFor = ""
        Me.PODCD.SearchPopup = "CodeMaster"
        Me.PODCD.Size = New System.Drawing.Size(65, 22)
        Me.PODCD.SuppressValidateCode = False
        Me.PODCD.TabIndex = 244
        Me.PODCD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.PODCD.ValidateKeys = ""
        '
        'POLCD
        '
        Me.POLCD.AlwaysSetDisplayParams = False
        Me.POLCD.AutoSuggestion = False
        Me.POLCD.BorderColor = System.Drawing.Color.Empty
        Me.POLCD.CodeType = ""
        Me.POLCD.DataParams = ""
        Me.POLCD.DefVal = ""
        Me.POLCD.DisplayParams = ""
        Me.POLCD.EditPopup = ""
        Me.POLCD.IconVisible = True
        Me.POLCD.IsDataStateAware = True
        Me.POLCD.KeepIntegrity = True
        Me.POLCD.Location = New System.Drawing.Point(85, 122)
        Me.POLCD.Name = "POLCD"
        Me.POLCD.NextFocus = Nothing
        Me.POLCD.RequiredFor = ""
        Me.POLCD.SearchPopup = "CodeMaster"
        Me.POLCD.Size = New System.Drawing.Size(65, 22)
        Me.POLCD.SuppressValidateCode = False
        Me.POLCD.TabIndex = 244
        Me.POLCD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.POLCD.ValidateKeys = ""
        '
        'Label16
        '
        Me.Label16.LabelFor = Nothing
        Me.Label16.Location = New System.Drawing.Point(165, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 242
        Me.Label16.Text = "P.O.D"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label16, "")
        '
        'Label15
        '
        Me.Label15.LabelFor = Nothing
        Me.Label15.Location = New System.Drawing.Point(11, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 242
        Me.Label15.Text = "P.O.L"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label15, "")
        '
        'CUSTCD
        '
        Me.CUSTCD.AlwaysSetDisplayParams = False
        Me.CUSTCD.AutoSuggestion = False
        Me.CUSTCD.BorderColor = System.Drawing.Color.Empty
        Me.CUSTCD.CodeType = ""
        Me.CUSTCD.DataParams = ""
        Me.CUSTCD.DefVal = ""
        Me.CUSTCD.DisplayParams = ""
        Me.CUSTCD.EditPopup = ""
        Me.CUSTCD.IconVisible = True
        Me.CUSTCD.IsDataStateAware = True
        Me.CUSTCD.KeepIntegrity = True
        Me.CUSTCD.Location = New System.Drawing.Point(85, 98)
        Me.CUSTCD.Name = "CUSTCD"
        Me.CUSTCD.NextFocus = Nothing
        Me.CUSTCD.RequiredFor = ""
        Me.CUSTCD.SearchPopup = "CodeMaster"
        Me.CUSTCD.Size = New System.Drawing.Size(91, 22)
        Me.CUSTCD.SuppressValidateCode = False
        Me.CUSTCD.TabIndex = 244
        Me.CUSTCD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.CUSTCD.ValidateKeys = ""
        '
        'Label14
        '
        Me.Label14.LabelFor = Nothing
        Me.Label14.Location = New System.Drawing.Point(11, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 242
        Me.Label14.Text = "Customer"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label14, "")
        '
        'Label12
        '
        Me.Label12.LabelFor = Nothing
        Me.Label12.Location = New System.Drawing.Point(11, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 242
        Me.Label12.Text = "B/L No"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label12, "")
        '
        'Label1
        '
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 242
        Me.Label1.Text = "Part"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "Part")
        '
        'Label10
        '
        Me.Label10.LabelFor = Nothing
        Me.Label10.Location = New System.Drawing.Point(7, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 242
        Me.Label10.Text = "Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label10, "")
        '
        'WORKNM
        '
        Me.WORKNM.BorderColor = System.Drawing.Color.Silver
        Me.WORKNM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WORKNM.DefVal = ""
        Me.WORKNM.IsDataStateAware = True
        Me.WORKNM.Location = New System.Drawing.Point(85, 74)
        Me.WORKNM.Name = "WORKNM"
        Me.WORKNM.NextFocus = "S_ROW_BEST"
        Me.WORKNM.RequiredFor = ""
        Me.WORKNM.Size = New System.Drawing.Size(223, 22)
        Me.WORKNM.TabIndex = 1
        Me.WORKNM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'DateBox1
        '
        Me.DateBox1.BorderColor = System.Drawing.Color.Silver
        Me.DateBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateBox1.DefVal = ""
        Me.DateBox1.IconVisible = True
        Me.DateBox1.IsDataStateAware = True
        Me.DateBox1.Location = New System.Drawing.Point(85, 50)
        Me.DateBox1.Name = "DateBox1"
        Me.DateBox1.NextFocus = "TO_YMD"
        Me.DateBox1.RequiredFor = ""
        Me.DateBox1.Size = New System.Drawing.Size(91, 22)
        Me.DateBox1.TabIndex = 57
        Me.Localizer1.SetWordID(Me.DateBox1, "")
        '
        'DateBox2
        '
        Me.DateBox2.BorderColor = System.Drawing.Color.Silver
        Me.DateBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateBox2.DefVal = ""
        Me.DateBox2.IconVisible = True
        Me.DateBox2.IsDataStateAware = True
        Me.DateBox2.Location = New System.Drawing.Point(203, 50)
        Me.DateBox2.Name = "DateBox2"
        Me.DateBox2.NextFocus = "SEARCH_KEY"
        Me.DateBox2.RequiredFor = ""
        Me.DateBox2.Size = New System.Drawing.Size(91, 22)
        Me.DateBox2.TabIndex = 58
        Me.Localizer1.SetWordID(Me.DateBox2, "")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.LabelFor = Nothing
        Me.Label13.Location = New System.Drawing.Point(182, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 14)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "~"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Localizer1.SetWordID(Me.Label13, "")
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.VSG_EDM_TPIC)
        Me.GroupControl1.Controls.Add(Me.VSG_EDM_TEAM)
        Me.GroupControl1.Controls.Add(Me.Label20)
        Me.GroupControl1.Controls.Add(Me.CMD_VSG_COPY)
        Me.GroupControl1.Controls.Add(Me.CMD_VSG_SAVE)
        Me.GroupControl1.Controls.Add(Me.Label19)
        Me.GroupControl1.Controls.Add(Me.Label17)
        Me.GroupControl1.Controls.Add(Me.Label18)
        Me.GroupControl1.Controls.Add(Me.VSG_EDM_RMK)
        Me.GroupControl1.Controls.Add(Me.VSG_EDM_NAME)
        Me.GroupControl1.Location = New System.Drawing.Point(7, 733)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1238, 56)
        Me.GroupControl1.TabIndex = 9
        Me.GroupControl1.Text = "Standby Data"
        Me.Localizer1.SetWordID(Me.GroupControl1, "Standby Data")
        '
        'VSG_EDM_TPIC
        '
        Me.VSG_EDM_TPIC.CodeType = "YJIT.CodeService.CommonCode"
        Me.VSG_EDM_TPIC.ColumnWidths = ""
        Me.VSG_EDM_TPIC.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.VSG_EDM_TPIC.DataParams = "GroupCode:'EDM02',NameType:''"
        Me.VSG_EDM_TPIC.DefVal = ""
        Me.VSG_EDM_TPIC.DisplayMember = "NAME"
        Me.VSG_EDM_TPIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VSG_EDM_TPIC.FormattingEnabled = True
        Me.VSG_EDM_TPIC.IsDataStateAware = True
        Me.VSG_EDM_TPIC.ItemDelimiter = ","
        Me.VSG_EDM_TPIC.ItemTextList = ""
        Me.VSG_EDM_TPIC.ItemValueList = ""
        Me.VSG_EDM_TPIC.KeepIntegrity = True
        Me.VSG_EDM_TPIC.Location = New System.Drawing.Point(664, 27)
        Me.VSG_EDM_TPIC.Name = "VSG_EDM_TPIC"
        Me.VSG_EDM_TPIC.NextFocus = "REF_TIME"
        Me.VSG_EDM_TPIC.NullText = "--Select--"
        Me.VSG_EDM_TPIC.RequiredFor = ""
        Me.VSG_EDM_TPIC.SearchKeys = ""
        Me.VSG_EDM_TPIC.Size = New System.Drawing.Size(149, 22)
        Me.VSG_EDM_TPIC.TabIndex = 245
        Me.VSG_EDM_TPIC.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.VSG_EDM_TPIC.ValueMember = "CODE"
        '
        'VSG_EDM_TEAM
        '
        Me.VSG_EDM_TEAM.CodeType = "YJIT.CodeService.CommonCode"
        Me.VSG_EDM_TEAM.ColumnWidths = ""
        Me.VSG_EDM_TEAM.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.VSG_EDM_TEAM.DataParams = "GroupCode:'EDM01',NameType:''"
        Me.VSG_EDM_TEAM.DefVal = ""
        Me.VSG_EDM_TEAM.DisplayMember = "NAME"
        Me.VSG_EDM_TEAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VSG_EDM_TEAM.FormattingEnabled = True
        Me.VSG_EDM_TEAM.IsDataStateAware = True
        Me.VSG_EDM_TEAM.ItemDelimiter = ","
        Me.VSG_EDM_TEAM.ItemTextList = ""
        Me.VSG_EDM_TEAM.ItemValueList = ""
        Me.VSG_EDM_TEAM.KeepIntegrity = True
        Me.VSG_EDM_TEAM.Location = New System.Drawing.Point(452, 27)
        Me.VSG_EDM_TEAM.Name = "VSG_EDM_TEAM"
        Me.VSG_EDM_TEAM.NextFocus = "REF_TIME"
        Me.VSG_EDM_TEAM.NullText = "--Select--"
        Me.VSG_EDM_TEAM.RequiredFor = ""
        Me.VSG_EDM_TEAM.SearchKeys = ""
        Me.VSG_EDM_TEAM.Size = New System.Drawing.Size(149, 22)
        Me.VSG_EDM_TEAM.TabIndex = 244
        Me.VSG_EDM_TEAM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.VSG_EDM_TEAM.ValueMember = "CODE"
        '
        'Label20
        '
        Me.Label20.LabelFor = Nothing
        Me.Label20.Location = New System.Drawing.Point(819, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 20)
        Me.Label20.TabIndex = 242
        Me.Label20.Text = "Remark"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label20, "")
        '
        'CMD_VSG_COPY
        '
        Me.CMD_VSG_COPY.Action = "CopyData"
        Me.CMD_VSG_COPY.ButtonType = YJIT.SC.UI.ButtonTypes.Copy
        Me.CMD_VSG_COPY.Image = CType(resources.GetObject("CMD_VSG_COPY.Image"), System.Drawing.Image)
        Me.CMD_VSG_COPY.Location = New System.Drawing.Point(75, 26)
        Me.CMD_VSG_COPY.Name = "CMD_VSG_COPY"
        Me.CMD_VSG_COPY.Size = New System.Drawing.Size(69, 25)
        Me.CMD_VSG_COPY.TabIndex = 7
        Me.CMD_VSG_COPY.Text = "Copy"
        Me.Localizer1.SetWordID(Me.CMD_VSG_COPY, "Copy")
        '
        'CMD_VSG_SAVE
        '
        Me.CMD_VSG_SAVE.Action = "SaveData"
        Me.CMD_VSG_SAVE.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.CMD_VSG_SAVE.Image = CType(resources.GetObject("CMD_VSG_SAVE.Image"), System.Drawing.Image)
        Me.CMD_VSG_SAVE.Location = New System.Drawing.Point(5, 26)
        Me.CMD_VSG_SAVE.Name = "CMD_VSG_SAVE"
        Me.CMD_VSG_SAVE.Size = New System.Drawing.Size(69, 25)
        Me.CMD_VSG_SAVE.TabIndex = 7
        Me.CMD_VSG_SAVE.Text = "Save"
        Me.Localizer1.SetWordID(Me.CMD_VSG_SAVE, "Save")
        '
        'Label19
        '
        Me.Label19.LabelFor = Nothing
        Me.Label19.Location = New System.Drawing.Point(150, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 20)
        Me.Label19.TabIndex = 242
        Me.Label19.Text = "Title"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label19, "")
        '
        'Label17
        '
        Me.Label17.LabelFor = Nothing
        Me.Label17.Location = New System.Drawing.Point(607, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 20)
        Me.Label17.TabIndex = 242
        Me.Label17.Text = "P.I.C"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label17, "")
        '
        'Label18
        '
        Me.Label18.LabelFor = Nothing
        Me.Label18.Location = New System.Drawing.Point(398, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 20)
        Me.Label18.TabIndex = 242
        Me.Label18.Text = "Team"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label18, "")
        '
        'VSG_EDM_RMK
        '
        Me.VSG_EDM_RMK.BorderColor = System.Drawing.Color.Silver
        Me.VSG_EDM_RMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VSG_EDM_RMK.DefVal = ""
        Me.VSG_EDM_RMK.IsDataStateAware = True
        Me.VSG_EDM_RMK.Location = New System.Drawing.Point(881, 27)
        Me.VSG_EDM_RMK.Name = "VSG_EDM_RMK"
        Me.VSG_EDM_RMK.NextFocus = "S_ROW_BEST"
        Me.VSG_EDM_RMK.RequiredFor = ""
        Me.VSG_EDM_RMK.Size = New System.Drawing.Size(167, 22)
        Me.VSG_EDM_RMK.TabIndex = 1
        Me.VSG_EDM_RMK.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'VSG_EDM_NAME
        '
        Me.VSG_EDM_NAME.BorderColor = System.Drawing.Color.Silver
        Me.VSG_EDM_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VSG_EDM_NAME.DefVal = ""
        Me.VSG_EDM_NAME.IsDataStateAware = True
        Me.VSG_EDM_NAME.Location = New System.Drawing.Point(199, 27)
        Me.VSG_EDM_NAME.Name = "VSG_EDM_NAME"
        Me.VSG_EDM_NAME.NextFocus = "S_ROW_BEST"
        Me.VSG_EDM_NAME.RequiredFor = ""
        Me.VSG_EDM_NAME.Size = New System.Drawing.Size(193, 22)
        Me.VSG_EDM_NAME.TabIndex = 1
        Me.VSG_EDM_NAME.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.ImgThumbnail1)
        Me.PanelControl3.Controls.Add(Me.btnThumbnailEdit3)
        Me.PanelControl3.Controls.Add(Me.btnThumbnailEdit2)
        Me.PanelControl3.Controls.Add(Me.btnThumbnailEdit1)
        Me.PanelControl3.Controls.Add(Me.btnThumbnailEdit0)
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(125, 479)
        Me.PanelControl3.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        '
        'ImgThumbnail1
        '
        Me.ImgThumbnail1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgThumbnail1.Location = New System.Drawing.Point(5, 65)
        Me.ImgThumbnail1.Name = "ImgThumbnail1"
        Me.ImgThumbnail1.OcxState = CType(resources.GetObject("ImgThumbnail1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ImgThumbnail1.Size = New System.Drawing.Size(115, 409)
        Me.ImgThumbnail1.TabIndex = 10
        Me.Localizer1.SetWordID(Me.ImgThumbnail1, "")
        '
        'btnThumbnailEdit3
        '
        Me.btnThumbnailEdit3.Action = "DeleteData"
        Me.btnThumbnailEdit3.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnThumbnailEdit3.Location = New System.Drawing.Point(65, 34)
        Me.btnThumbnailEdit3.Name = "btnThumbnailEdit3"
        Me.btnThumbnailEdit3.Size = New System.Drawing.Size(54, 25)
        Me.btnThumbnailEdit3.TabIndex = 7
        Me.btnThumbnailEdit3.Text = "Delete"
        Me.Localizer1.SetWordID(Me.btnThumbnailEdit3, "Delete")
        '
        'btnThumbnailEdit2
        '
        Me.btnThumbnailEdit2.Action = "SaveData"
        Me.btnThumbnailEdit2.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnThumbnailEdit2.Location = New System.Drawing.Point(5, 34)
        Me.btnThumbnailEdit2.Name = "btnThumbnailEdit2"
        Me.btnThumbnailEdit2.Size = New System.Drawing.Size(54, 25)
        Me.btnThumbnailEdit2.TabIndex = 7
        Me.btnThumbnailEdit2.Text = "Insert"
        Me.Localizer1.SetWordID(Me.btnThumbnailEdit2, "Insert")
        '
        'btnThumbnailEdit1
        '
        Me.btnThumbnailEdit1.Action = "DeleteData"
        Me.btnThumbnailEdit1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnThumbnailEdit1.Location = New System.Drawing.Point(65, 5)
        Me.btnThumbnailEdit1.Name = "btnThumbnailEdit1"
        Me.btnThumbnailEdit1.Size = New System.Drawing.Size(54, 25)
        Me.btnThumbnailEdit1.TabIndex = 7
        Me.btnThumbnailEdit1.Text = "Change"
        Me.Localizer1.SetWordID(Me.btnThumbnailEdit1, "Change")
        '
        'btnThumbnailEdit0
        '
        Me.btnThumbnailEdit0.Action = "SaveData"
        Me.btnThumbnailEdit0.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnThumbnailEdit0.Location = New System.Drawing.Point(5, 5)
        Me.btnThumbnailEdit0.Name = "btnThumbnailEdit0"
        Me.btnThumbnailEdit0.Size = New System.Drawing.Size(54, 25)
        Me.btnThumbnailEdit0.TabIndex = 7
        Me.btnThumbnailEdit0.Text = "Split"
        Me.Localizer1.SetWordID(Me.btnThumbnailEdit0, "Split")
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.WG_EDMDOC)
        Me.PanelControl4.Controls.Add(Me.WG_BLNO)
        Me.PanelControl4.Controls.Add(Me.WG_SEARCH)
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(739, 150)
        Me.PanelControl4.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        '
        'WG_EDMDOC
        '
        Me.WG_EDMDOC.AllowClientBinding = True
        Me.WG_EDMDOC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_EDMDOC.DeleteRowConfirmation = True
        Me.WG_EDMDOC.DisplayCurrentRow = False
        Me.WG_EDMDOC.IsDataStateAware = True
        Me.WG_EDMDOC.Location = New System.Drawing.Point(557, 5)
        Me.WG_EDMDOC.MainView = Me.VSG_EDMDOC
        Me.WG_EDMDOC.Name = "WG_EDMDOC"
        Me.WG_EDMDOC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG_EDMDOC.SaveLayout = False
        Me.WG_EDMDOC.Size = New System.Drawing.Size(176, 140)
        Me.WG_EDMDOC.TabIndex = 6
        Me.WG_EDMDOC.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG_EDMDOC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VSG_EDMDOC})
        '
        'VSG_EDMDOC
        '
        Me.VSG_EDMDOC.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.VSG_EDMDOC.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.VSG_EDMDOC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV_EDMDOC_ROWSEQ, Me.GV_EDMDOC_PSEQ, Me.GV_EDMDOC_EDOCCD, Me.GV_EDMDOC_EDOCNM, Me.GV_EDMDOC_REG, Me.GV_EDMDOC_SAVEDATE, Me.GV_EDMDOC_SAVEUSER, Me.GV_EDMDOC_FILEPATH, Me.GV_EDMDOC_FILENAME, Me.GV_EDMDOC_RCVD_DTTM, Me.GV_EDMDOC_RCVD_FILENAME, Me.GV_EDMDOC_EDM_RMK, Me.GV_EDMDOC_DBTIMESTAMP, Me.GV_EDMDOC_DOCIO})
        Me.VSG_EDMDOC.GridControl = Me.WG_EDMDOC
        Me.VSG_EDMDOC.Name = "VSG_EDMDOC"
        Me.VSG_EDMDOC.OptionsBehavior.Editable = False
        Me.VSG_EDMDOC.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.VSG_EDMDOC.OptionsBehavior.ReadOnly = True
        Me.VSG_EDMDOC.OptionsCustomization.AllowRowSizing = True
        Me.VSG_EDMDOC.OptionsNavigation.EnterMoveNextColumn = True
        Me.VSG_EDMDOC.OptionsView.ColumnAutoWidth = False
        Me.VSG_EDMDOC.OptionsView.RowAutoHeight = True
        Me.VSG_EDMDOC.OptionsView.ShowGroupPanel = False
        Me.VSG_EDMDOC.RowHeight = 10
        Me.VSG_EDMDOC.ViewCaption = " 고객 리스트"
        '
        'GV_EDMDOC_ROWSEQ
        '
        Me.GV_EDMDOC_ROWSEQ.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_ROWSEQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_ROWSEQ.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_ROWSEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_ROWSEQ.Caption = "Seq"
        Me.GV_EDMDOC_ROWSEQ.FieldName = "ROWSEQ"
        Me.GV_EDMDOC_ROWSEQ.Name = "GV_EDMDOC_ROWSEQ"
        Me.GV_EDMDOC_ROWSEQ.OptionsColumn.AllowEdit = False
        Me.GV_EDMDOC_ROWSEQ.OptionsColumn.ReadOnly = True
        Me.GV_EDMDOC_ROWSEQ.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_ROWSEQ.Visible = True
        Me.GV_EDMDOC_ROWSEQ.VisibleIndex = 0
        Me.GV_EDMDOC_ROWSEQ.Width = 80
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_ROWSEQ, "")
        '
        'GV_EDMDOC_PSEQ
        '
        Me.GV_EDMDOC_PSEQ.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_PSEQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_PSEQ.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_PSEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_PSEQ.Caption = "Print Seq"
        Me.GV_EDMDOC_PSEQ.FieldName = "PSEQ"
        Me.GV_EDMDOC_PSEQ.Name = "GV_EDMDOC_PSEQ"
        Me.GV_EDMDOC_PSEQ.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_PSEQ.Visible = True
        Me.GV_EDMDOC_PSEQ.VisibleIndex = 1
        Me.GV_EDMDOC_PSEQ.Width = 90
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_PSEQ, "")
        '
        'GV_EDMDOC_EDOCCD
        '
        Me.GV_EDMDOC_EDOCCD.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_EDOCCD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_EDOCCD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_EDOCCD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_EDOCCD.Caption = "Code"
        Me.GV_EDMDOC_EDOCCD.FieldName = "EDOCCD"
        Me.GV_EDMDOC_EDOCCD.Name = "GV_EDMDOC_EDOCCD"
        Me.GV_EDMDOC_EDOCCD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_EDOCCD.Visible = True
        Me.GV_EDMDOC_EDOCCD.VisibleIndex = 2
        Me.GV_EDMDOC_EDOCCD.Width = 60
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_EDOCCD, "")
        '
        'GV_EDMDOC_EDOCNM
        '
        Me.GV_EDMDOC_EDOCNM.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_EDOCNM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_EDOCNM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_EDOCNM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_EDOCNM.Caption = "Document"
        Me.GV_EDMDOC_EDOCNM.FieldName = "EDOCNM"
        Me.GV_EDMDOC_EDOCNM.Name = "GV_EDMDOC_EDOCNM"
        Me.GV_EDMDOC_EDOCNM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_EDOCNM.Visible = True
        Me.GV_EDMDOC_EDOCNM.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_EDOCNM, "")
        '
        'GV_EDMDOC_REG
        '
        Me.GV_EDMDOC_REG.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_EDMDOC_REG.AppearanceCell.Options.UseFont = True
        Me.GV_EDMDOC_REG.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_REG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_REG.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_REG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_REG.Caption = "Reg"
        Me.GV_EDMDOC_REG.FieldName = "REG"
        Me.GV_EDMDOC_REG.Name = "GV_EDMDOC_REG"
        Me.GV_EDMDOC_REG.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_REG.Visible = True
        Me.GV_EDMDOC_REG.VisibleIndex = 4
        Me.GV_EDMDOC_REG.Width = 80
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_REG, "")
        '
        'GV_EDMDOC_SAVEDATE
        '
        Me.GV_EDMDOC_SAVEDATE.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_EDMDOC_SAVEDATE.AppearanceCell.Options.UseFont = True
        Me.GV_EDMDOC_SAVEDATE.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_SAVEDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV_EDMDOC_SAVEDATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_SAVEDATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_SAVEDATE.Caption = "Save Date"
        Me.GV_EDMDOC_SAVEDATE.FieldName = "SAVEDATE"
        Me.GV_EDMDOC_SAVEDATE.Name = "GV_EDMDOC_SAVEDATE"
        Me.GV_EDMDOC_SAVEDATE.OptionsColumn.AllowEdit = False
        Me.GV_EDMDOC_SAVEDATE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV_EDMDOC_SAVEDATE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_SAVEDATE.Visible = True
        Me.GV_EDMDOC_SAVEDATE.VisibleIndex = 5
        Me.GV_EDMDOC_SAVEDATE.Width = 150
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_SAVEDATE, "")
        '
        'GV_EDMDOC_SAVEUSER
        '
        Me.GV_EDMDOC_SAVEUSER.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_SAVEUSER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_SAVEUSER.Caption = "Save User"
        Me.GV_EDMDOC_SAVEUSER.FieldName = "SAVEUSER"
        Me.GV_EDMDOC_SAVEUSER.Name = "GV_EDMDOC_SAVEUSER"
        Me.GV_EDMDOC_SAVEUSER.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_SAVEUSER.Visible = True
        Me.GV_EDMDOC_SAVEUSER.VisibleIndex = 6
        Me.GV_EDMDOC_SAVEUSER.Width = 400
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_SAVEUSER, "")
        '
        'GV_EDMDOC_FILEPATH
        '
        Me.GV_EDMDOC_FILEPATH.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_EDMDOC_FILEPATH.AppearanceCell.Options.UseFont = True
        Me.GV_EDMDOC_FILEPATH.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_FILEPATH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_FILEPATH.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_FILEPATH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_FILEPATH.Caption = "File Path"
        Me.GV_EDMDOC_FILEPATH.FieldName = "FILEPATH"
        Me.GV_EDMDOC_FILEPATH.Name = "GV_EDMDOC_FILEPATH"
        Me.GV_EDMDOC_FILEPATH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_FILEPATH.Visible = True
        Me.GV_EDMDOC_FILEPATH.VisibleIndex = 7
        Me.GV_EDMDOC_FILEPATH.Width = 80
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_FILEPATH, "")
        '
        'GV_EDMDOC_FILENAME
        '
        Me.GV_EDMDOC_FILENAME.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_EDMDOC_FILENAME.AppearanceCell.Options.UseFont = True
        Me.GV_EDMDOC_FILENAME.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_FILENAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_FILENAME.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_FILENAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_FILENAME.Caption = "File Name"
        Me.GV_EDMDOC_FILENAME.FieldName = "FILENAME"
        Me.GV_EDMDOC_FILENAME.Name = "GV_EDMDOC_FILENAME"
        Me.GV_EDMDOC_FILENAME.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_FILENAME.Visible = True
        Me.GV_EDMDOC_FILENAME.VisibleIndex = 8
        Me.GV_EDMDOC_FILENAME.Width = 90
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_FILENAME, "")
        '
        'GV_EDMDOC_RCVD_DTTM
        '
        Me.GV_EDMDOC_RCVD_DTTM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_EDMDOC_RCVD_DTTM.AppearanceCell.Options.UseFont = True
        Me.GV_EDMDOC_RCVD_DTTM.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_RCVD_DTTM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_RCVD_DTTM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_RCVD_DTTM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_RCVD_DTTM.Caption = "File ID"
        Me.GV_EDMDOC_RCVD_DTTM.FieldName = "RCVD_DTTM"
        Me.GV_EDMDOC_RCVD_DTTM.Name = "GV_EDMDOC_RCVD_DTTM"
        Me.GV_EDMDOC_RCVD_DTTM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_RCVD_DTTM.Visible = True
        Me.GV_EDMDOC_RCVD_DTTM.VisibleIndex = 9
        Me.GV_EDMDOC_RCVD_DTTM.Width = 80
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_RCVD_DTTM, "")
        '
        'GV_EDMDOC_RCVD_FILENAME
        '
        Me.GV_EDMDOC_RCVD_FILENAME.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_EDMDOC_RCVD_FILENAME.AppearanceCell.Options.UseFont = True
        Me.GV_EDMDOC_RCVD_FILENAME.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_RCVD_FILENAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_RCVD_FILENAME.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_RCVD_FILENAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_RCVD_FILENAME.Caption = "File Name"
        Me.GV_EDMDOC_RCVD_FILENAME.FieldName = "RCVD_FILENAME"
        Me.GV_EDMDOC_RCVD_FILENAME.Name = "GV_EDMDOC_RCVD_FILENAME"
        Me.GV_EDMDOC_RCVD_FILENAME.OptionsColumn.AllowEdit = False
        Me.GV_EDMDOC_RCVD_FILENAME.OptionsColumn.ReadOnly = True
        Me.GV_EDMDOC_RCVD_FILENAME.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_RCVD_FILENAME.Visible = True
        Me.GV_EDMDOC_RCVD_FILENAME.VisibleIndex = 10
        Me.GV_EDMDOC_RCVD_FILENAME.Width = 80
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_RCVD_FILENAME, "")
        '
        'GV_EDMDOC_EDM_RMK
        '
        Me.GV_EDMDOC_EDM_RMK.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_EDM_RMK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_EDM_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_EDM_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_EDM_RMK.Caption = "Remark"
        Me.GV_EDMDOC_EDM_RMK.FieldName = "EDM_RMK"
        Me.GV_EDMDOC_EDM_RMK.Name = "GV_EDMDOC_EDM_RMK"
        Me.GV_EDMDOC_EDM_RMK.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_EDM_RMK.Visible = True
        Me.GV_EDMDOC_EDM_RMK.VisibleIndex = 11
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_EDM_RMK, "")
        '
        'GV_EDMDOC_DBTIMESTAMP
        '
        Me.GV_EDMDOC_DBTIMESTAMP.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_DBTIMESTAMP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_DBTIMESTAMP.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_DBTIMESTAMP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_DBTIMESTAMP.Caption = "DB TimeStamp"
        Me.GV_EDMDOC_DBTIMESTAMP.FieldName = "DBTIMESTAMP"
        Me.GV_EDMDOC_DBTIMESTAMP.Name = "GV_EDMDOC_DBTIMESTAMP"
        Me.GV_EDMDOC_DBTIMESTAMP.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_DBTIMESTAMP.Visible = True
        Me.GV_EDMDOC_DBTIMESTAMP.VisibleIndex = 12
        Me.GV_EDMDOC_DBTIMESTAMP.Width = 90
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_DBTIMESTAMP, "")
        '
        'GV_EDMDOC_DOCIO
        '
        Me.GV_EDMDOC_DOCIO.AppearanceCell.Options.UseTextOptions = True
        Me.GV_EDMDOC_DOCIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_DOCIO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_EDMDOC_DOCIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_EDMDOC_DOCIO.Caption = "In/Out"
        Me.GV_EDMDOC_DOCIO.FieldName = "DOCIO"
        Me.GV_EDMDOC_DOCIO.Name = "GV_EDMDOC_DOCIO"
        Me.GV_EDMDOC_DOCIO.OptionsColumn.AllowEdit = False
        Me.GV_EDMDOC_DOCIO.OptionsColumn.ReadOnly = True
        Me.GV_EDMDOC_DOCIO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_EDMDOC_DOCIO.Visible = True
        Me.GV_EDMDOC_DOCIO.VisibleIndex = 13
        Me.GV_EDMDOC_DOCIO.Width = 90
        Me.Localizer1.SetWordID(Me.GV_EDMDOC_DOCIO, "")
        '
        'WG_BLNO
        '
        Me.WG_BLNO.AllowClientBinding = True
        Me.WG_BLNO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WG_BLNO.DeleteRowConfirmation = True
        Me.WG_BLNO.DisplayCurrentRow = False
        Me.WG_BLNO.IsDataStateAware = True
        Me.WG_BLNO.Location = New System.Drawing.Point(281, 5)
        Me.WG_BLNO.MainView = Me.VSG_BLNO
        Me.WG_BLNO.Name = "WG_BLNO"
        Me.WG_BLNO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG_BLNO.SaveLayout = False
        Me.WG_BLNO.Size = New System.Drawing.Size(270, 140)
        Me.WG_BLNO.TabIndex = 6
        Me.WG_BLNO.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG_BLNO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VSG_BLNO})
        '
        'VSG_BLNO
        '
        Me.VSG_BLNO.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.VSG_BLNO.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.VSG_BLNO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV_BLNO_BLNO, Me.GV_BLNO_DOCNO, Me.GV_BLNO_EDM_NO, Me.GV_BLNO_BLGB, Me.GV_BLNO_BLIO})
        Me.VSG_BLNO.GridControl = Me.WG_BLNO
        Me.VSG_BLNO.Name = "VSG_BLNO"
        Me.VSG_BLNO.OptionsBehavior.Editable = False
        Me.VSG_BLNO.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.VSG_BLNO.OptionsBehavior.ReadOnly = True
        Me.VSG_BLNO.OptionsCustomization.AllowRowSizing = True
        Me.VSG_BLNO.OptionsNavigation.EnterMoveNextColumn = True
        Me.VSG_BLNO.OptionsView.ColumnAutoWidth = False
        Me.VSG_BLNO.OptionsView.RowAutoHeight = True
        Me.VSG_BLNO.OptionsView.ShowGroupPanel = False
        Me.VSG_BLNO.RowHeight = 10
        Me.VSG_BLNO.ViewCaption = " 고객 리스트"
        '
        'GV_BLNO_BLNO
        '
        Me.GV_BLNO_BLNO.AppearanceCell.Options.UseTextOptions = True
        Me.GV_BLNO_BLNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_BLNO_BLNO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_BLNO_BLNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_BLNO_BLNO.Caption = "B/L No"
        Me.GV_BLNO_BLNO.FieldName = "BLNO"
        Me.GV_BLNO_BLNO.Name = "GV_BLNO_BLNO"
        Me.GV_BLNO_BLNO.OptionsColumn.AllowEdit = False
        Me.GV_BLNO_BLNO.OptionsColumn.ReadOnly = True
        Me.GV_BLNO_BLNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_BLNO_BLNO.Visible = True
        Me.GV_BLNO_BLNO.VisibleIndex = 0
        Me.GV_BLNO_BLNO.Width = 80
        Me.Localizer1.SetWordID(Me.GV_BLNO_BLNO, "")
        '
        'GV_BLNO_DOCNO
        '
        Me.GV_BLNO_DOCNO.AppearanceCell.Options.UseTextOptions = True
        Me.GV_BLNO_DOCNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_BLNO_DOCNO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_BLNO_DOCNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_BLNO_DOCNO.Caption = "Doc. No"
        Me.GV_BLNO_DOCNO.FieldName = "DOCNO"
        Me.GV_BLNO_DOCNO.Name = "GV_BLNO_DOCNO"
        Me.GV_BLNO_DOCNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_BLNO_DOCNO.Visible = True
        Me.GV_BLNO_DOCNO.VisibleIndex = 1
        Me.GV_BLNO_DOCNO.Width = 90
        Me.Localizer1.SetWordID(Me.GV_BLNO_DOCNO, "")
        '
        'GV_BLNO_EDM_NO
        '
        Me.GV_BLNO_EDM_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV_BLNO_EDM_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_BLNO_EDM_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_BLNO_EDM_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_BLNO_EDM_NO.Caption = "Edm No"
        Me.GV_BLNO_EDM_NO.FieldName = "EDM_NO"
        Me.GV_BLNO_EDM_NO.Name = "GV_BLNO_EDM_NO"
        Me.GV_BLNO_EDM_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_BLNO_EDM_NO.Visible = True
        Me.GV_BLNO_EDM_NO.VisibleIndex = 2
        Me.GV_BLNO_EDM_NO.Width = 60
        Me.Localizer1.SetWordID(Me.GV_BLNO_EDM_NO, "")
        '
        'GV_BLNO_BLGB
        '
        Me.GV_BLNO_BLGB.AppearanceCell.Options.UseTextOptions = True
        Me.GV_BLNO_BLGB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_BLNO_BLGB.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_BLNO_BLGB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_BLNO_BLGB.Caption = "BL"
        Me.GV_BLNO_BLGB.FieldName = "BLGB"
        Me.GV_BLNO_BLGB.Name = "GV_BLNO_BLGB"
        Me.GV_BLNO_BLGB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_BLNO_BLGB.Visible = True
        Me.GV_BLNO_BLGB.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV_BLNO_BLGB, "")
        '
        'GV_BLNO_BLIO
        '
        Me.GV_BLNO_BLIO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_BLNO_BLIO.AppearanceCell.Options.UseFont = True
        Me.GV_BLNO_BLIO.AppearanceCell.Options.UseTextOptions = True
        Me.GV_BLNO_BLIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_BLNO_BLIO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_BLNO_BLIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_BLNO_BLIO.Caption = "In/Out"
        Me.GV_BLNO_BLIO.FieldName = "BLIO"
        Me.GV_BLNO_BLIO.Name = "GV_BLNO_BLIO"
        Me.GV_BLNO_BLIO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_BLNO_BLIO.Visible = True
        Me.GV_BLNO_BLIO.VisibleIndex = 4
        Me.GV_BLNO_BLIO.Width = 80
        Me.Localizer1.SetWordID(Me.GV_BLNO_BLIO, "")
        '
        'WG_SEARCH
        '
        Me.WG_SEARCH.AllowClientBinding = True
        Me.WG_SEARCH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WG_SEARCH.DeleteRowConfirmation = True
        Me.WG_SEARCH.DisplayCurrentRow = False
        Me.WG_SEARCH.IsDataStateAware = True
        Me.WG_SEARCH.Location = New System.Drawing.Point(5, 5)
        Me.WG_SEARCH.MainView = Me.VSG_SEARCH
        Me.WG_SEARCH.Name = "WG_SEARCH"
        Me.WG_SEARCH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG_SEARCH.SaveLayout = False
        Me.WG_SEARCH.Size = New System.Drawing.Size(270, 140)
        Me.WG_SEARCH.TabIndex = 6
        Me.WG_SEARCH.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG_SEARCH.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VSG_SEARCH})
        '
        'VSG_SEARCH
        '
        Me.VSG_SEARCH.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.VSG_SEARCH.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.VSG_SEARCH.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV_SEARCH_BLNO, Me.GV_SEARCH_DOCNO, Me.GV_SEARCH_EDM_NO, Me.GV_SEARCH_BLGB, Me.GV_SEARCH_BLIO})
        Me.VSG_SEARCH.GridControl = Me.WG_SEARCH
        Me.VSG_SEARCH.Name = "VSG_SEARCH"
        Me.VSG_SEARCH.OptionsBehavior.Editable = False
        Me.VSG_SEARCH.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.VSG_SEARCH.OptionsBehavior.ReadOnly = True
        Me.VSG_SEARCH.OptionsCustomization.AllowRowSizing = True
        Me.VSG_SEARCH.OptionsNavigation.EnterMoveNextColumn = True
        Me.VSG_SEARCH.OptionsView.ColumnAutoWidth = False
        Me.VSG_SEARCH.OptionsView.RowAutoHeight = True
        Me.VSG_SEARCH.OptionsView.ShowGroupPanel = False
        Me.VSG_SEARCH.RowHeight = 10
        Me.VSG_SEARCH.ViewCaption = " 고객 리스트"
        '
        'GV_SEARCH_BLNO
        '
        Me.GV_SEARCH_BLNO.AppearanceCell.Options.UseTextOptions = True
        Me.GV_SEARCH_BLNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_SEARCH_BLNO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_SEARCH_BLNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_SEARCH_BLNO.Caption = "B/L No"
        Me.GV_SEARCH_BLNO.FieldName = "BLNO"
        Me.GV_SEARCH_BLNO.Name = "GV_SEARCH_BLNO"
        Me.GV_SEARCH_BLNO.OptionsColumn.AllowEdit = False
        Me.GV_SEARCH_BLNO.OptionsColumn.ReadOnly = True
        Me.GV_SEARCH_BLNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_SEARCH_BLNO.Visible = True
        Me.GV_SEARCH_BLNO.VisibleIndex = 0
        Me.GV_SEARCH_BLNO.Width = 80
        Me.Localizer1.SetWordID(Me.GV_SEARCH_BLNO, "B/L No")
        '
        'GV_SEARCH_DOCNO
        '
        Me.GV_SEARCH_DOCNO.AppearanceCell.Options.UseTextOptions = True
        Me.GV_SEARCH_DOCNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_SEARCH_DOCNO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_SEARCH_DOCNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_SEARCH_DOCNO.Caption = "Doc. No"
        Me.GV_SEARCH_DOCNO.FieldName = "DOCNO"
        Me.GV_SEARCH_DOCNO.Name = "GV_SEARCH_DOCNO"
        Me.GV_SEARCH_DOCNO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_SEARCH_DOCNO.Visible = True
        Me.GV_SEARCH_DOCNO.VisibleIndex = 1
        Me.GV_SEARCH_DOCNO.Width = 90
        Me.Localizer1.SetWordID(Me.GV_SEARCH_DOCNO, "Doc. No")
        '
        'GV_SEARCH_EDM_NO
        '
        Me.GV_SEARCH_EDM_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV_SEARCH_EDM_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_SEARCH_EDM_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_SEARCH_EDM_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_SEARCH_EDM_NO.Caption = "Edm No"
        Me.GV_SEARCH_EDM_NO.FieldName = "EDM_NO"
        Me.GV_SEARCH_EDM_NO.Name = "GV_SEARCH_EDM_NO"
        Me.GV_SEARCH_EDM_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_SEARCH_EDM_NO.Visible = True
        Me.GV_SEARCH_EDM_NO.VisibleIndex = 2
        Me.GV_SEARCH_EDM_NO.Width = 60
        Me.Localizer1.SetWordID(Me.GV_SEARCH_EDM_NO, "Edm No")
        '
        'GV_SEARCH_BLGB
        '
        Me.GV_SEARCH_BLGB.AppearanceCell.Options.UseTextOptions = True
        Me.GV_SEARCH_BLGB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_SEARCH_BLGB.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_SEARCH_BLGB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_SEARCH_BLGB.Caption = "BL"
        Me.GV_SEARCH_BLGB.FieldName = "BLGB"
        Me.GV_SEARCH_BLGB.Name = "GV_SEARCH_BLGB"
        Me.GV_SEARCH_BLGB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_SEARCH_BLGB.Visible = True
        Me.GV_SEARCH_BLGB.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV_SEARCH_BLGB, "BL")
        '
        'GV_SEARCH_BLIO
        '
        Me.GV_SEARCH_BLIO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GV_SEARCH_BLIO.AppearanceCell.Options.UseFont = True
        Me.GV_SEARCH_BLIO.AppearanceCell.Options.UseTextOptions = True
        Me.GV_SEARCH_BLIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_SEARCH_BLIO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_SEARCH_BLIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_SEARCH_BLIO.Caption = "In/Out"
        Me.GV_SEARCH_BLIO.FieldName = "BLIO"
        Me.GV_SEARCH_BLIO.Name = "GV_SEARCH_BLIO"
        Me.GV_SEARCH_BLIO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_SEARCH_BLIO.Visible = True
        Me.GV_SEARCH_BLIO.VisibleIndex = 4
        Me.GV_SEARCH_BLIO.Width = 80
        Me.Localizer1.SetWordID(Me.GV_SEARCH_BLIO, "In/Out")
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl5.Controls.Add(Me.ImgEdit1)
        Me.PanelControl5.Location = New System.Drawing.Point(2, 1)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(785, 478)
        Me.PanelControl5.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        '
        'ImgEdit1
        '
        Me.ImgEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgEdit1.Location = New System.Drawing.Point(5, 4)
        Me.ImgEdit1.Name = "ImgEdit1"
        Me.ImgEdit1.OcxState = CType(resources.GetObject("ImgEdit1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ImgEdit1.Size = New System.Drawing.Size(775, 469)
        Me.ImgEdit1.TabIndex = 9
        Me.Localizer1.SetWordID(Me.ImgEdit1, "")
        '
        'SplitCtrlImgEdit
        '
        Me.SplitCtrlImgEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitCtrlImgEdit.Location = New System.Drawing.Point(0, 47)
        Me.SplitCtrlImgEdit.Name = "SplitCtrlImgEdit"
        Me.SplitCtrlImgEdit.Panel1.Controls.Add(Me.PanelControl3)
        Me.SplitCtrlImgEdit.Panel1.Text = "Panel1"
        Me.SplitCtrlImgEdit.Panel2.Controls.Add(Me.PanelControl5)
        Me.SplitCtrlImgEdit.Panel2.Text = "Panel2"
        Me.SplitCtrlImgEdit.Size = New System.Drawing.Size(919, 479)
        Me.SplitCtrlImgEdit.SplitterPosition = 126
        Me.SplitCtrlImgEdit.TabIndex = 10
        Me.SplitCtrlImgEdit.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.SplitCtrlImgEdit, "")
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(326, 45)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.PanelControl4)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.SplitCtrlImgEdit)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(919, 682)
        Me.SplitContainerControl2.SplitterPosition = 150
        Me.SplitContainerControl2.TabIndex = 11
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        Me.Localizer1.SetWordID(Me.SplitContainerControl2, "")
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
        'Button1
        '
        Me.Button1.Action = "SearchData"
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(433, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.Button1, "")
        '
        'EdmMainMgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 795)
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Controls.Add(Me.grpCtrlWork)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grpCtrlStandby)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "EdmMainMgt"
        Me.Text = "EDM"
        Me.Localizer1.SetWordID(Me, "EDM")
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.WG_STANDBY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSG_STANDBY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpGV_STANDBY_CHK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grpCtrlStandby, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCtrlStandby.ResumeLayout(False)
        Me.grpCtrlStandby.PerformLayout()
        CType(Me.grpCtrlWork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCtrlWork.ResumeLayout(False)
        Me.grpCtrlWork.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.ImgThumbnail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.WG_EDMDOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSG_EDMDOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG_BLNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSG_BLNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VSG_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.ImgEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitCtrlImgEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitCtrlImgEdit.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMD_FIND As YJIT.SC.UI.SCControls.Button
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CMD_SAVE As YJIT.SC.UI.SCControls.Button
    Friend WithEvents VSG_STANDBY As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV_STANDBY_RCVD_FAXNO As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents GV_STANDBY_RCVD_DTTM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_STANDBY_RCVD_PATH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents iconImages As DevExpress.Utils.ImageCollection
    Friend WithEvents GV_STANDBY_EDM_TPIC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_STANDBY_RCVD_SENDER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_STANDBY_EDM_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_STANDBY_RCVD_FILENAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_STANDBY_EDM_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RepositoryItemDateBoxEdit1 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Public WithEvents WG_STANDBY As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CMD_VSG_MERGE As YJIT.SC.UI.SCControls.Button
    Friend WithEvents CMD_VSG_DEL As YJIT.SC.UI.SCControls.Button
    Friend WithEvents CMD_VSG_REFRESH As YJIT.SC.UI.SCControls.Button
    Friend WithEvents CMD_VSG_UPLOAD As YJIT.SC.UI.SCControls.Button
    Friend WithEvents grpCtrlStandby As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label8 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label7 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents EDM_NAME As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label9 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents grpCtrlWork As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label10 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label11 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents WORKNM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents DateBox1 As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents DateBox2 As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label13 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents CUSTCD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents CUSTNM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents PODCD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents POLCD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents Label16 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label15 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label14 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label12 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label19 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label17 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label18 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents VSG_EDM_NAME As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents CMD_VSG_COPY As YJIT.SC.UI.SCControls.Button
    Friend WithEvents CMD_VSG_SAVE As YJIT.SC.UI.SCControls.Button
    Friend WithEvents VSG_EDM_RMK As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents CMD_EDITER As YJIT.SC.UI.SCControls.Button
    Friend WithEvents CMD_MERGE As YJIT.SC.UI.SCControls.Button
    Friend WithEvents CMD_CANCEL As YJIT.SC.UI.SCControls.Button
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnThumbnailEdit3 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnThumbnailEdit2 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnThumbnailEdit1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnThumbnailEdit0 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents ImgThumbnail1 As AxThumbnailLibCtl.AxImgThumbnail
    Friend WithEvents PAGE As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents btnWidthHeightFit2 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnWidthHeightFit1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnWidthHeightFit0 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnLeftRightRotate1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnForntBack1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnLeftRightRotate0 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnForntBack0 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnPages As YJIT.SC.UI.SCControls.Button
    Friend WithEvents Zooms As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents btnZooms As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnTifEmail As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnZoomInOut1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnTifPrint As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnZoomInOut0 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnTifPcSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnTifEdit5 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnTifEdit2 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnTifEdit4 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnTifEdit1 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnTifEdit3 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnTifEdit0 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnTifEdit6 As YJIT.SC.UI.SCControls.Button
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Public WithEvents WG_EDMDOC As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents VSG_EDMDOC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV_EDMDOC_ROWSEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_PSEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_EDOCCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_EDOCNM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_REG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_SAVEDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_SAVEUSER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_FILEPATH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_FILENAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_RCVD_DTTM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_RCVD_FILENAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_EDM_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_DBTIMESTAMP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_EDMDOC_DOCIO As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents WG_SEARCH As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents VSG_SEARCH As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV_SEARCH_BLNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_SEARCH_DOCNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_SEARCH_EDM_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_SEARCH_BLGB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_SEARCH_BLIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_STANDBY_CHK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpGV_STANDBY_CHK As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Public WithEvents WG_BLNO As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents VSG_BLNO As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV_BLNO_BLNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_BLNO_DOCNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_BLNO_EDM_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_BLNO_BLGB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_BLNO_BLIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ImgEdit1 As AxImgeditLibCtl.AxImgEdit
    Friend WithEvents SplitCtrlImgEdit As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Label20 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents EDM_TEAM As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents EDM_TPIC As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents VSG_EDM_TPIC As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents VSG_EDM_TEAM As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents EDM_PART As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Button1 As YJIT.SC.UI.SCControls.Button
End Class
