<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdmProgramMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdmProgramMgt))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.S_PGM_GRP = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.S_PGM_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.S_SYS_ID = New YJIT.SC.UI.SCControls.ComboBox()
        Me.WG1_PGM_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAddRowWG1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRemoveRowWG1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.WG1_PGM_GRP = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG1_PGM_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG1_FUNC_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG1_PGM_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnDllAuto = New YJIT.SC.UI.SCControls.Button()
        Me.trwFileExplorer = New System.Windows.Forms.TreeView()
        Me.imlFileExplorer = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.S_PGM_GRP)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.S_PGM_ID)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.S_SYS_ID)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1245, 56)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Search Condition"
        Me.Localizer1.SetWordID(Me.GroupControl1, "Search Condition")
        '
        'S_PGM_GRP
        '
        Me.S_PGM_GRP.BorderColor = System.Drawing.Color.Empty
        Me.S_PGM_GRP.DefVal = ""
        Me.S_PGM_GRP.IsDataStateAware = True
        Me.S_PGM_GRP.Location = New System.Drawing.Point(362, 27)
        Me.S_PGM_GRP.MaxLength = 18
        Me.S_PGM_GRP.Name = "S_PGM_GRP"
        Me.S_PGM_GRP.NextFocus = "S_PGM_ID"
        Me.S_PGM_GRP.Size = New System.Drawing.Size(97, 22)
        Me.S_PGM_GRP.TabIndex = 5
        Me.S_PGM_GRP.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(316, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Group"
        Me.Localizer1.SetWordID(Me.Label4, "Group")
        '
        'S_PGM_ID
        '
        Me.S_PGM_ID.BorderColor = System.Drawing.Color.Empty
        Me.S_PGM_ID.DefVal = ""
        Me.S_PGM_ID.IsDataStateAware = True
        Me.S_PGM_ID.Location = New System.Drawing.Point(563, 26)
        Me.S_PGM_ID.MaxLength = 18
        Me.S_PGM_ID.Name = "S_PGM_ID"
        Me.S_PGM_ID.NextFocus = Nothing
        Me.S_PGM_ID.Size = New System.Drawing.Size(147, 22)
        Me.S_PGM_ID.TabIndex = 3
        Me.S_PGM_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(489, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Program ID"
        Me.Localizer1.SetWordID(Me.Label3, "Program ID")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "System"
        Me.Localizer1.SetWordID(Me.Label1, "System")
        '
        'S_SYS_ID
        '
        Me.S_SYS_ID.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_SYS_ID.ColumnWidths = ""
        Me.S_SYS_ID.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_SYS_ID.DataParams = "GroupCode:'S01',NameType:'A'"
        Me.S_SYS_ID.DefVal = ""
        Me.S_SYS_ID.DisplayMember = "NAME"
        Me.S_SYS_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_SYS_ID.FormattingEnabled = True
        Me.S_SYS_ID.IsDataStateAware = False
        Me.S_SYS_ID.ItemDelimiter = ","
        Me.S_SYS_ID.ItemTextList = ""
        Me.S_SYS_ID.ItemValueList = ""
        Me.S_SYS_ID.KeepIntegrity = True
        Me.S_SYS_ID.Location = New System.Drawing.Point(71, 27)
        Me.S_SYS_ID.Name = "S_SYS_ID"
        Me.S_SYS_ID.NextFocus = "S_PGM_GRP"
        Me.S_SYS_ID.NullText = ""
        Me.S_SYS_ID.SearchKeys = ""
        Me.S_SYS_ID.Size = New System.Drawing.Size(226, 22)
        Me.S_SYS_ID.TabIndex = 0
        Me.S_SYS_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_SYS_ID.ValueMember = "CODE"
        '
        'WG1_PGM_NM
        '
        Me.WG1_PGM_NM.BorderColor = System.Drawing.Color.Empty
        Me.WG1_PGM_NM.DefVal = ""
        Me.WG1_PGM_NM.IsDataStateAware = True
        Me.WG1_PGM_NM.Location = New System.Drawing.Point(786, 79)
        Me.WG1_PGM_NM.MaxLength = 50
        Me.WG1_PGM_NM.Name = "WG1_PGM_NM"
        Me.WG1_PGM_NM.NextFocus = Nothing
        Me.WG1_PGM_NM.Size = New System.Drawing.Size(358, 22)
        Me.WG1_PGM_NM.TabIndex = 3
        Me.WG1_PGM_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
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
        Me.WG1.Location = New System.Drawing.Point(309, 102)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(939, 468)
        Me.WG1.TabIndex = 6
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn1, Me.GridColumn3, Me.GridColumn2, Me.GridColumn5, Me.GridColumn4, Me.GridColumn6})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsLayout.StoreAllOptions = True
        Me.GV1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GV1.OptionsPrint.EnableAppearanceOddRow = True
        Me.GV1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "System ID"
        Me.GridColumn7.FieldName = "SYS_ID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 82
        Me.Localizer1.SetWordID(Me.GridColumn7, "System ID")
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Program ID"
        Me.GridColumn1.FieldName = "PGM_ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 152
        Me.Localizer1.SetWordID(Me.GridColumn1, "Program ID")
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Function ID"
        Me.GridColumn3.FieldName = "FUNC_ID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 186
        Me.Localizer1.SetWordID(Me.GridColumn3, "Function ID")
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Name"
        Me.GridColumn2.FieldName = "PGM_NM"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 355
        Me.Localizer1.SetWordID(Me.GridColumn2, "Name")
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Group"
        Me.GridColumn5.FieldName = "PGM_GRP"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 101
        Me.Localizer1.SetWordID(Me.GridColumn5, "Group")
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Type"
        Me.GridColumn4.FieldName = "PGM_TYPE"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 103
        Me.Localizer1.SetWordID(Me.GridColumn4, "Type")
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "DLL NAME"
        Me.GridColumn6.FieldName = "DLL_NAME"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GridColumn6, "DLL NAME")
        '
        'btnAddRowWG1
        '
        Me.btnAddRowWG1.Image = CType(resources.GetObject("btnAddRowWG1.Image"), System.Drawing.Image)
        Me.btnAddRowWG1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddRowWG1.Location = New System.Drawing.Point(308, 78)
        Me.btnAddRowWG1.Name = "btnAddRowWG1"
        Me.btnAddRowWG1.Size = New System.Drawing.Size(26, 24)
        Me.btnAddRowWG1.TabIndex = 5
        Me.Localizer1.SetWordID(Me.btnAddRowWG1, "")
        '
        'btnRemoveRowWG1
        '
        Me.btnRemoveRowWG1.Image = CType(resources.GetObject("btnRemoveRowWG1.Image"), System.Drawing.Image)
        Me.btnRemoveRowWG1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRemoveRowWG1.Location = New System.Drawing.Point(333, 78)
        Me.btnRemoveRowWG1.Name = "btnRemoveRowWG1"
        Me.btnRemoveRowWG1.Size = New System.Drawing.Size(26, 24)
        Me.btnRemoveRowWG1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.btnRemoveRowWG1, "")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1020, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 25)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.Localizer1.SetWordID(Me.btnSearch, "Search")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(1114, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 25)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.Localizer1.SetWordID(Me.btnSave, "Save")
        '
        'WG1_PGM_GRP
        '
        Me.WG1_PGM_GRP.BorderColor = System.Drawing.Color.Empty
        Me.WG1_PGM_GRP.DefVal = ""
        Me.WG1_PGM_GRP.IsDataStateAware = True
        Me.WG1_PGM_GRP.Location = New System.Drawing.Point(359, 79)
        Me.WG1_PGM_GRP.MaxLength = 18
        Me.WG1_PGM_GRP.Name = "WG1_PGM_GRP"
        Me.WG1_PGM_GRP.NextFocus = Nothing
        Me.WG1_PGM_GRP.Size = New System.Drawing.Size(97, 22)
        Me.WG1_PGM_GRP.TabIndex = 0
        Me.WG1_PGM_GRP.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'WG1_PGM_ID
        '
        Me.WG1_PGM_ID.BorderColor = System.Drawing.Color.Empty
        Me.WG1_PGM_ID.DefVal = ""
        Me.WG1_PGM_ID.IsDataStateAware = True
        Me.WG1_PGM_ID.Location = New System.Drawing.Point(456, 79)
        Me.WG1_PGM_ID.MaxLength = 18
        Me.WG1_PGM_ID.Name = "WG1_PGM_ID"
        Me.WG1_PGM_ID.NextFocus = Nothing
        Me.WG1_PGM_ID.Size = New System.Drawing.Size(147, 22)
        Me.WG1_PGM_ID.TabIndex = 1
        Me.WG1_PGM_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'WG1_FUNC_ID
        '
        Me.WG1_FUNC_ID.BorderColor = System.Drawing.Color.Empty
        Me.WG1_FUNC_ID.DefVal = ""
        Me.WG1_FUNC_ID.IsDataStateAware = True
        Me.WG1_FUNC_ID.Location = New System.Drawing.Point(604, 79)
        Me.WG1_FUNC_ID.MaxLength = 18
        Me.WG1_FUNC_ID.Name = "WG1_FUNC_ID"
        Me.WG1_FUNC_ID.NextFocus = Nothing
        Me.WG1_FUNC_ID.Size = New System.Drawing.Size(181, 22)
        Me.WG1_FUNC_ID.TabIndex = 2
        Me.WG1_FUNC_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'WG1_PGM_TYPE
        '
        Me.WG1_PGM_TYPE.CodeType = ""
        Me.WG1_PGM_TYPE.ColumnWidths = ""
        Me.WG1_PGM_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.WG1_PGM_TYPE.DataParams = ""
        Me.WG1_PGM_TYPE.DefVal = ""
        Me.WG1_PGM_TYPE.DisplayMember = "NAME"
        Me.WG1_PGM_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WG1_PGM_TYPE.FormattingEnabled = True
        Me.WG1_PGM_TYPE.IsDataStateAware = True
        Me.WG1_PGM_TYPE.ItemDelimiter = ","
        Me.WG1_PGM_TYPE.ItemTextList = "Program,Function"
        Me.WG1_PGM_TYPE.ItemValueList = "P,F"
        Me.WG1_PGM_TYPE.KeepIntegrity = True
        Me.WG1_PGM_TYPE.Location = New System.Drawing.Point(1146, 78)
        Me.WG1_PGM_TYPE.Name = "WG1_PGM_TYPE"
        Me.WG1_PGM_TYPE.NextFocus = Nothing
        Me.WG1_PGM_TYPE.NullText = "--Select--"
        Me.WG1_PGM_TYPE.SearchKeys = ""
        Me.WG1_PGM_TYPE.Size = New System.Drawing.Size(101, 22)
        Me.WG1_PGM_TYPE.TabIndex = 4
        Me.WG1_PGM_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1_PGM_TYPE.ValueMember = "CODE"
        '
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.btnDllAuto)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(1, 4)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1251, 32)
        Me.palAutoButton.TabIndex = 22
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnDllAuto
        '
        Me.btnDllAuto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDllAuto.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDllAuto.Location = New System.Drawing.Point(927, 3)
        Me.btnDllAuto.Name = "btnDllAuto"
        Me.btnDllAuto.Size = New System.Drawing.Size(87, 25)
        Me.btnDllAuto.TabIndex = 10
        Me.btnDllAuto.Text = "DLL 체크"
        Me.Localizer1.SetWordID(Me.btnDllAuto, "DLL 체크")
        '
        'trwFileExplorer
        '
        Me.trwFileExplorer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trwFileExplorer.HideSelection = False
        Me.trwFileExplorer.ImageIndex = 0
        Me.trwFileExplorer.ImageList = Me.imlFileExplorer
        Me.trwFileExplorer.LabelEdit = True
        Me.trwFileExplorer.Location = New System.Drawing.Point(3, 79)
        Me.trwFileExplorer.Name = "trwFileExplorer"
        Me.trwFileExplorer.SelectedImageIndex = 0
        Me.trwFileExplorer.Size = New System.Drawing.Size(297, 491)
        Me.trwFileExplorer.TabIndex = 36
        Me.Localizer1.SetWordID(Me.trwFileExplorer, "")
        '
        'imlFileExplorer
        '
        Me.imlFileExplorer.ImageStream = CType(resources.GetObject("imlFileExplorer.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlFileExplorer.TransparentColor = System.Drawing.Color.Transparent
        Me.imlFileExplorer.Images.SetKeyName(0, "Computer")
        Me.imlFileExplorer.Images.SetKeyName(1, "HardDrive")
        Me.imlFileExplorer.Images.SetKeyName(2, "CdDrive")
        Me.imlFileExplorer.Images.SetKeyName(3, "OtherDrive")
        Me.imlFileExplorer.Images.SetKeyName(4, "Folder")
        Me.imlFileExplorer.Images.SetKeyName(5, "File")
        Me.imlFileExplorer.Images.SetKeyName(6, "Rename")
        Me.imlFileExplorer.Images.SetKeyName(7, "Refresh")
        Me.imlFileExplorer.Images.SetKeyName(8, "ExeFile")
        Me.imlFileExplorer.Images.SetKeyName(9, "DllFile")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(1, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 14)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Assembly Browsing"
        Me.Localizer1.SetWordID(Me.Label2, "Assembly Browsing")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.GroupControl1, "Search Condition")
        Me.Localizer1.SetWordID(Me.S_PGM_GRP, "")
        Me.Localizer1.SetWordID(Me.Label4, "Group")
        Me.Localizer1.SetWordID(Me.S_PGM_ID, "")
        Me.Localizer1.SetWordID(Me.Label3, "Program ID")
        Me.Localizer1.SetWordID(Me.Label1, "System")
        Me.Localizer1.SetWordID(Me.S_SYS_ID, "")
        Me.Localizer1.SetWordID(Me.WG1_PGM_NM, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GridColumn7, "System ID")
        Me.Localizer1.SetWordID(Me.GridColumn1, "Program ID")
        Me.Localizer1.SetWordID(Me.GridColumn3, "Function ID")
        Me.Localizer1.SetWordID(Me.GridColumn2, "Name")
        Me.Localizer1.SetWordID(Me.GridColumn5, "Group")
        Me.Localizer1.SetWordID(Me.GridColumn4, "Type")
        Me.Localizer1.SetWordID(Me.GridColumn6, "DLL NAME")
        Me.Localizer1.SetWordID(Me.btnAddRowWG1, "")
        Me.Localizer1.SetWordID(Me.btnRemoveRowWG1, "")
        Me.Localizer1.SetWordID(Me.btnSearch, "Search")
        Me.Localizer1.SetWordID(Me.btnSave, "Save")
        Me.Localizer1.SetWordID(Me.WG1_PGM_GRP, "")
        Me.Localizer1.SetWordID(Me.WG1_PGM_ID, "")
        Me.Localizer1.SetWordID(Me.WG1_FUNC_ID, "")
        Me.Localizer1.SetWordID(Me.WG1_PGM_TYPE, "--Select--")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnDllAuto, "DLL 체크")
        Me.Localizer1.SetWordID(Me.trwFileExplorer, "")
        Me.Localizer1.SetWordID(Me.Label2, "Assembly Browsing")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.GroupControl1)
        Me.Panel1.Controls.Add(Me.trwFileExplorer)
        Me.Panel1.Controls.Add(Me.WG1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnRemoveRowWG1)
        Me.Panel1.Controls.Add(Me.btnAddRowWG1)
        Me.Panel1.Controls.Add(Me.WG1_PGM_TYPE)
        Me.Panel1.Controls.Add(Me.WG1_PGM_ID)
        Me.Panel1.Controls.Add(Me.WG1_PGM_GRP)
        Me.Panel1.Controls.Add(Me.WG1_FUNC_ID)
        Me.Panel1.Controls.Add(Me.WG1_PGM_NM)
        Me.Panel1.Location = New System.Drawing.Point(4, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1253, 573)
        Me.Panel1.TabIndex = 37
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'MdmProgramMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1262, 624)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "MdmProgramMgt"
        Me.Text = "Program management"
        Me.Localizer1.SetWordID(Me, "Program management")
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_SYS_ID As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents WG1_PGM_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddRowWG1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemoveRowWG1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG1_PGM_GRP As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG1_PGM_ID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG1_FUNC_ID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG1_PGM_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Private WithEvents trwFileExplorer As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents imlFileExplorer As System.Windows.Forms.ImageList
    Friend WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents S_PGM_ID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_PGM_GRP As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDllAuto As YJIT.SC.UI.SCControls.Button
End Class
