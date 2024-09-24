<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComMailMsg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComMailMsg))
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_GRP_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COMN_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SUBJECT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CONTENTS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MSG_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MSG_TYPE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEPT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnDelete = New YJIT.SC.UI.SCControls.Button()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.GRP_CD = New YJIT.SC.UI.SCControls.TextLabel()
        Me.lbl_GRP_CD = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_COMN_CD = New YJIT.SC.UI.SCControls.Label()
        Me.COMN_CD = New YJIT.SC.UI.SCControls.TextLabel()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.CONTENTS = New YJIT.SC.UI.SCControls.TextBox()
        Me.SUBJECT = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_SUBJECT = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_CONTENTS = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_REQ_SVC = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_DEPT_CD = New YJIT.SC.UI.SCControls.Label()
        Me.MSG_TYPE2 = New YJIT.SC.UI.SCControls.ComboBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DEPT_CD = New YJIT.SC.UI.SCControls.ComboBox()
        Me.MSG_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.grpCtrlRmkList = New DevExpress.XtraEditors.GroupControl()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV2_TAG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CAPTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpCtrlRmkList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCtrlRmkList.SuspendLayout()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.AllowDrop = True
        Me.WG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = False
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(3, 4)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(860, 163)
        Me.WG1.TabIndex = 88
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_GRP_CD, Me.GV1_COMN_CD, Me.GV1_SUBJECT, Me.GV1_CONTENTS, Me.GV1_MSG_TYPE, Me.GV1_MSG_TYPE2, Me.GV1_DEPT_CD})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsBehavior.ReadOnly = True
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorzLines = False
        '
        'GV1_GRP_CD
        '
        Me.GV1_GRP_CD.Caption = "Group Code"
        Me.GV1_GRP_CD.FieldName = "GRP_CD"
        Me.GV1_GRP_CD.Name = "GV1_GRP_CD"
        Me.GV1_GRP_CD.OptionsColumn.AllowEdit = False
        Me.GV1_GRP_CD.OptionsColumn.ReadOnly = True
        Me.GV1_GRP_CD.Width = 20
        Me.Localizer1.SetWordID(Me.GV1_GRP_CD, "Group Code")
        '
        'GV1_COMN_CD
        '
        Me.GV1_COMN_CD.Caption = "Code"
        Me.GV1_COMN_CD.FieldName = "COMN_CD"
        Me.GV1_COMN_CD.Name = "GV1_COMN_CD"
        Me.GV1_COMN_CD.OptionsColumn.AllowEdit = False
        Me.GV1_COMN_CD.OptionsColumn.ReadOnly = True
        Me.GV1_COMN_CD.Visible = True
        Me.GV1_COMN_CD.VisibleIndex = 0
        Me.GV1_COMN_CD.Width = 42
        Me.Localizer1.SetWordID(Me.GV1_COMN_CD, "Code")
        '
        'GV1_SUBJECT
        '
        Me.GV1_SUBJECT.Caption = "Subject"
        Me.GV1_SUBJECT.FieldName = "SUBJECT"
        Me.GV1_SUBJECT.Name = "GV1_SUBJECT"
        Me.GV1_SUBJECT.Visible = True
        Me.GV1_SUBJECT.VisibleIndex = 1
        Me.GV1_SUBJECT.Width = 181
        Me.Localizer1.SetWordID(Me.GV1_SUBJECT, "Subject")
        '
        'GV1_CONTENTS
        '
        Me.GV1_CONTENTS.Caption = "Contents"
        Me.GV1_CONTENTS.FieldName = "CONTENTS"
        Me.GV1_CONTENTS.Name = "GV1_CONTENTS"
        Me.GV1_CONTENTS.Visible = True
        Me.GV1_CONTENTS.VisibleIndex = 2
        Me.GV1_CONTENTS.Width = 222
        Me.Localizer1.SetWordID(Me.GV1_CONTENTS, "Contents")
        '
        'GV1_MSG_TYPE
        '
        Me.GV1_MSG_TYPE.Caption = "MSG Type"
        Me.GV1_MSG_TYPE.FieldName = "MSG_TYPE"
        Me.GV1_MSG_TYPE.Name = "GV1_MSG_TYPE"
        Me.GV1_MSG_TYPE.Visible = True
        Me.GV1_MSG_TYPE.VisibleIndex = 3
        Me.GV1_MSG_TYPE.Width = 66
        Me.Localizer1.SetWordID(Me.GV1_MSG_TYPE, "MSG Type")
        '
        'GV1_MSG_TYPE2
        '
        Me.GV1_MSG_TYPE2.Caption = "MSG Type2"
        Me.GV1_MSG_TYPE2.FieldName = "MSG_TYPE2"
        Me.GV1_MSG_TYPE2.Name = "GV1_MSG_TYPE2"
        Me.GV1_MSG_TYPE2.Visible = True
        Me.GV1_MSG_TYPE2.VisibleIndex = 4
        Me.GV1_MSG_TYPE2.Width = 71
        Me.Localizer1.SetWordID(Me.GV1_MSG_TYPE2, "MSG Type2")
        '
        'GV1_DEPT_CD
        '
        Me.GV1_DEPT_CD.Caption = "Department"
        Me.GV1_DEPT_CD.FieldName = "DEPT_CD"
        Me.GV1_DEPT_CD.Name = "GV1_DEPT_CD"
        Me.GV1_DEPT_CD.Visible = True
        Me.GV1_DEPT_CD.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GV1_DEPT_CD, "Department")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnDelete)
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.GRP_CD)
        Me.palAutoButton.Controls.Add(Me.lbl_GRP_CD)
        Me.palAutoButton.Location = New System.Drawing.Point(2, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(897, 32)
        Me.palAutoButton.TabIndex = 83
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnDelete
        '
        Me.btnDelete.Action = "DeleteData"
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(820, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 25)
        Me.btnDelete.TabIndex = 302
        Me.btnDelete.Text = "&Delete"
        Me.Localizer1.SetWordID(Me.btnDelete, "&Delete")
        '
        'btnNew
        '
        Me.btnNew.Action = "NewData"
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(668, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(70, 25)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "&New"
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        '
        'btnSearch
        '
        Me.btnSearch.Action = "SearchData"
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(592, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'btnSave
        '
        Me.btnSave.Action = "SaveData"
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(744, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'GRP_CD
        '
        Me.GRP_CD.AutoEllipsis = True
        Me.GRP_CD.BorderColor = System.Drawing.Color.Silver
        Me.GRP_CD.LabelFor = Nothing
        Me.GRP_CD.Location = New System.Drawing.Point(486, 6)
        Me.GRP_CD.Name = "GRP_CD"
        Me.GRP_CD.Size = New System.Drawing.Size(75, 22)
        Me.GRP_CD.TabIndex = 301
        Me.GRP_CD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GRP_CD.Visible = False
        '
        'lbl_GRP_CD
        '
        Me.lbl_GRP_CD.LabelFor = Nothing
        Me.lbl_GRP_CD.Location = New System.Drawing.Point(398, 10)
        Me.lbl_GRP_CD.Name = "lbl_GRP_CD"
        Me.lbl_GRP_CD.Size = New System.Drawing.Size(82, 14)
        Me.lbl_GRP_CD.TabIndex = 112
        Me.lbl_GRP_CD.Text = "Group Code"
        Me.lbl_GRP_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_GRP_CD.Visible = False
        Me.Localizer1.SetWordID(Me.lbl_GRP_CD, "Group Code")
        '
        'lbl_COMN_CD
        '
        Me.lbl_COMN_CD.LabelFor = Nothing
        Me.lbl_COMN_CD.Location = New System.Drawing.Point(690, 19)
        Me.lbl_COMN_CD.Name = "lbl_COMN_CD"
        Me.lbl_COMN_CD.Size = New System.Drawing.Size(82, 14)
        Me.lbl_COMN_CD.TabIndex = 113
        Me.lbl_COMN_CD.Text = "Code"
        Me.lbl_COMN_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_COMN_CD, "Code")
        '
        'COMN_CD
        '
        Me.COMN_CD.AutoEllipsis = True
        Me.COMN_CD.BorderColor = System.Drawing.Color.Silver
        Me.COMN_CD.LabelFor = Nothing
        Me.COMN_CD.Location = New System.Drawing.Point(778, 15)
        Me.COMN_CD.Name = "COMN_CD"
        Me.COMN_CD.Size = New System.Drawing.Size(75, 22)
        Me.COMN_CD.TabIndex = 300
        Me.COMN_CD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_GRP_CD, "Group Code")
        Me.Localizer1.SetWordID(Me.GV1_COMN_CD, "Code")
        Me.Localizer1.SetWordID(Me.GV1_SUBJECT, "Subject")
        Me.Localizer1.SetWordID(Me.GV1_CONTENTS, "Contents")
        Me.Localizer1.SetWordID(Me.GV1_MSG_TYPE, "MSG Type")
        Me.Localizer1.SetWordID(Me.GV1_MSG_TYPE2, "MSG Type2")
        Me.Localizer1.SetWordID(Me.GV1_DEPT_CD, "Department")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnDelete, "&Delete")
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.lbl_GRP_CD, "Group Code")
        Me.Localizer1.SetWordID(Me.lbl_COMN_CD, "Code")
        Me.Localizer1.SetWordID(Me.CONTENTS, "")
        Me.Localizer1.SetWordID(Me.SUBJECT, "")
        Me.Localizer1.SetWordID(Me.lbl_SUBJECT, "Subject")
        Me.Localizer1.SetWordID(Me.lbl_CONTENTS, "Contents")
        Me.Localizer1.SetWordID(Me.lbl_REQ_SVC, "Service")
        Me.Localizer1.SetWordID(Me.lbl_DEPT_CD, "Department")
        Me.Localizer1.SetWordID(Me.MSG_TYPE2, "--Select--")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.DEPT_CD, "--Select--")
        Me.Localizer1.SetWordID(Me.MSG_TYPE, "--Select--")
        Me.Localizer1.SetWordID(Me.grpCtrlRmkList, "Tag Infomation (Double Click)")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GV2_TAG, "Tag")
        Me.Localizer1.SetWordID(Me.GV2_RMK, "Remark")
        Me.Localizer1.SetWordID(Me.GV2_CAPTION, "Caption")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'CONTENTS
        '
        Me.CONTENTS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CONTENTS.BorderColor = System.Drawing.Color.Silver
        Me.CONTENTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CONTENTS.DefVal = ""
        Me.CONTENTS.IsDataStateAware = True
        Me.CONTENTS.Location = New System.Drawing.Point(85, 79)
        Me.CONTENTS.MaxLength = 2000
        Me.CONTENTS.Multiline = True
        Me.CONTENTS.Name = "CONTENTS"
        Me.CONTENTS.NextFocus = "btnSave"
        Me.CONTENTS.RequiredFor = ""
        Me.CONTENTS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CONTENTS.Size = New System.Drawing.Size(768, 309)
        Me.CONTENTS.TabIndex = 106
        Me.CONTENTS.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'SUBJECT
        '
        Me.SUBJECT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SUBJECT.BorderColor = System.Drawing.Color.Silver
        Me.SUBJECT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SUBJECT.DefVal = ""
        Me.SUBJECT.IsDataStateAware = True
        Me.SUBJECT.Location = New System.Drawing.Point(85, 55)
        Me.SUBJECT.MaxLength = 200
        Me.SUBJECT.Name = "SUBJECT"
        Me.SUBJECT.NextFocus = "CONTENTS"
        Me.SUBJECT.RequiredFor = ""
        Me.SUBJECT.Size = New System.Drawing.Size(768, 22)
        Me.SUBJECT.TabIndex = 107
        Me.SUBJECT.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'lbl_SUBJECT
        '
        Me.lbl_SUBJECT.LabelFor = Nothing
        Me.lbl_SUBJECT.Location = New System.Drawing.Point(20, 57)
        Me.lbl_SUBJECT.Name = "lbl_SUBJECT"
        Me.lbl_SUBJECT.Size = New System.Drawing.Size(59, 14)
        Me.lbl_SUBJECT.TabIndex = 110
        Me.lbl_SUBJECT.Text = "Subject"
        Me.lbl_SUBJECT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_SUBJECT, "Subject")
        '
        'lbl_CONTENTS
        '
        Me.lbl_CONTENTS.LabelFor = Nothing
        Me.lbl_CONTENTS.Location = New System.Drawing.Point(19, 81)
        Me.lbl_CONTENTS.Name = "lbl_CONTENTS"
        Me.lbl_CONTENTS.Size = New System.Drawing.Size(60, 14)
        Me.lbl_CONTENTS.TabIndex = 111
        Me.lbl_CONTENTS.Text = "Contents"
        Me.lbl_CONTENTS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_CONTENTS, "Contents")
        '
        'lbl_REQ_SVC
        '
        Me.lbl_REQ_SVC.LabelFor = Nothing
        Me.lbl_REQ_SVC.Location = New System.Drawing.Point(9, 18)
        Me.lbl_REQ_SVC.Name = "lbl_REQ_SVC"
        Me.lbl_REQ_SVC.Size = New System.Drawing.Size(70, 14)
        Me.lbl_REQ_SVC.TabIndex = 114
        Me.lbl_REQ_SVC.Text = "MSG Type"
        Me.lbl_REQ_SVC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_REQ_SVC, "Service")
        '
        'lbl_DEPT_CD
        '
        Me.lbl_DEPT_CD.LabelFor = Nothing
        Me.lbl_DEPT_CD.Location = New System.Drawing.Point(325, 17)
        Me.lbl_DEPT_CD.Name = "lbl_DEPT_CD"
        Me.lbl_DEPT_CD.Size = New System.Drawing.Size(82, 14)
        Me.lbl_DEPT_CD.TabIndex = 114
        Me.lbl_DEPT_CD.Text = "Department"
        Me.lbl_DEPT_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_DEPT_CD, "Department")
        '
        'MSG_TYPE2
        '
        Me.MSG_TYPE2.CodeType = "YJIT.CodeService.CommonCode"
        Me.MSG_TYPE2.ColumnWidths = ""
        Me.MSG_TYPE2.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.MSG_TYPE2.DataParams = "GroupCode:'C08',OPT_ITEM1:'001',NameType:''"
        Me.MSG_TYPE2.DefVal = ""
        Me.MSG_TYPE2.DisplayMember = "name"
        Me.MSG_TYPE2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MSG_TYPE2.FormattingEnabled = True
        Me.MSG_TYPE2.IsDataStateAware = True
        Me.MSG_TYPE2.ItemDelimiter = ","
        Me.MSG_TYPE2.ItemTextList = ""
        Me.MSG_TYPE2.ItemValueList = ""
        Me.MSG_TYPE2.KeepIntegrity = True
        Me.MSG_TYPE2.Location = New System.Drawing.Point(200, 14)
        Me.MSG_TYPE2.Name = "MSG_TYPE2"
        Me.MSG_TYPE2.NextFocus = "DEPT_CD"
        Me.MSG_TYPE2.NullText = ""
        Me.MSG_TYPE2.RequiredFor = ""
        Me.MSG_TYPE2.SearchKeys = ""
        Me.MSG_TYPE2.Size = New System.Drawing.Size(122, 22)
        Me.MSG_TYPE2.TabIndex = 302
        Me.MSG_TYPE2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.MSG_TYPE2.ValueMember = "CODE"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.DEPT_CD)
        Me.PanelControl1.Controls.Add(Me.MSG_TYPE)
        Me.PanelControl1.Controls.Add(Me.lbl_COMN_CD)
        Me.PanelControl1.Controls.Add(Me.lbl_CONTENTS)
        Me.PanelControl1.Controls.Add(Me.lbl_REQ_SVC)
        Me.PanelControl1.Controls.Add(Me.COMN_CD)
        Me.PanelControl1.Controls.Add(Me.lbl_SUBJECT)
        Me.PanelControl1.Controls.Add(Me.MSG_TYPE2)
        Me.PanelControl1.Controls.Add(Me.SUBJECT)
        Me.PanelControl1.Controls.Add(Me.lbl_DEPT_CD)
        Me.PanelControl1.Controls.Add(Me.CONTENTS)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 173)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(860, 393)
        Me.PanelControl1.TabIndex = 92
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'DEPT_CD
        '
        Me.DEPT_CD.CodeType = "YJIT.CodeService.CommonCode"
        Me.DEPT_CD.ColumnWidths = ""
        Me.DEPT_CD.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.DEPT_CD.DataParams = "GroupCode:'C03',NameType:''"
        Me.DEPT_CD.DefVal = ""
        Me.DEPT_CD.DisplayMember = "NAME"
        Me.DEPT_CD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DEPT_CD.FormattingEnabled = True
        Me.DEPT_CD.IsDataStateAware = True
        Me.DEPT_CD.ItemDelimiter = ","
        Me.DEPT_CD.ItemTextList = ""
        Me.DEPT_CD.ItemValueList = ""
        Me.DEPT_CD.KeepIntegrity = True
        Me.DEPT_CD.Location = New System.Drawing.Point(411, 15)
        Me.DEPT_CD.Name = "DEPT_CD"
        Me.DEPT_CD.NextFocus = "SUBJECT"
        Me.DEPT_CD.NullText = "--Select--"
        Me.DEPT_CD.RequiredFor = ""
        Me.DEPT_CD.SearchKeys = ""
        Me.DEPT_CD.Size = New System.Drawing.Size(147, 22)
        Me.DEPT_CD.TabIndex = 10000
        Me.DEPT_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.DEPT_CD.ValueMember = "CODE"
        '
        'MSG_TYPE
        '
        Me.MSG_TYPE.CodeType = "YJIT.CodeService.CommonCode"
        Me.MSG_TYPE.ColumnWidths = ""
        Me.MSG_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.MSG_TYPE.DataParams = "GroupCode:'C07',NameType:''"
        Me.MSG_TYPE.DefVal = ""
        Me.MSG_TYPE.DisplayMember = "NAME"
        Me.MSG_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MSG_TYPE.FormattingEnabled = True
        Me.MSG_TYPE.IsDataStateAware = True
        Me.MSG_TYPE.ItemDelimiter = ","
        Me.MSG_TYPE.ItemTextList = ""
        Me.MSG_TYPE.ItemValueList = ""
        Me.MSG_TYPE.KeepIntegrity = True
        Me.MSG_TYPE.Location = New System.Drawing.Point(85, 14)
        Me.MSG_TYPE.Name = "MSG_TYPE"
        Me.MSG_TYPE.NextFocus = "MSG_TYPE2"
        Me.MSG_TYPE.NullText = ""
        Me.MSG_TYPE.RequiredFor = ""
        Me.MSG_TYPE.SearchKeys = ""
        Me.MSG_TYPE.Size = New System.Drawing.Size(109, 22)
        Me.MSG_TYPE.TabIndex = 308
        Me.MSG_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.MSG_TYPE.ValueMember = "CODE"
        '
        'grpCtrlRmkList
        '
        Me.grpCtrlRmkList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCtrlRmkList.Controls.Add(Me.WG2)
        Me.grpCtrlRmkList.Location = New System.Drawing.Point(869, 6)
        Me.grpCtrlRmkList.Name = "grpCtrlRmkList"
        Me.grpCtrlRmkList.Size = New System.Drawing.Size(390, 563)
        Me.grpCtrlRmkList.TabIndex = 108
        Me.grpCtrlRmkList.Text = "Tag Infomation (Double Click)"
        Me.Localizer1.SetWordID(Me.grpCtrlRmkList, "")
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.AllowDrop = True
        Me.WG2.DeleteRowConfirmation = False
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(2, 23)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(386, 538)
        Me.WG2.TabIndex = 89
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV2_TAG, Me.GV2_RMK, Me.GV2_CAPTION})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.IndicatorWidth = 40
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.Editable = False
        Me.GV2.OptionsBehavior.ReadOnly = True
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorzLines = False
        '
        'GV2_TAG
        '
        Me.GV2_TAG.Caption = "Tag"
        Me.GV2_TAG.FieldName = "TAG"
        Me.GV2_TAG.Name = "GV2_TAG"
        Me.GV2_TAG.OptionsColumn.AllowEdit = False
        Me.GV2_TAG.OptionsColumn.ReadOnly = True
        Me.GV2_TAG.Visible = True
        Me.GV2_TAG.VisibleIndex = 0
        Me.GV2_TAG.Width = 109
        Me.Localizer1.SetWordID(Me.GV2_TAG, "Tag")
        '
        'GV2_RMK
        '
        Me.GV2_RMK.Caption = "Remark"
        Me.GV2_RMK.FieldName = "RMK"
        Me.GV2_RMK.Name = "GV2_RMK"
        Me.GV2_RMK.OptionsColumn.AllowEdit = False
        Me.GV2_RMK.OptionsColumn.ReadOnly = True
        Me.GV2_RMK.Visible = True
        Me.GV2_RMK.VisibleIndex = 1
        Me.GV2_RMK.Width = 214
        Me.Localizer1.SetWordID(Me.GV2_RMK, "Remark")
        '
        'GV2_CAPTION
        '
        Me.GV2_CAPTION.Caption = "Caption"
        Me.GV2_CAPTION.FieldName = "CAPTION"
        Me.GV2_CAPTION.Name = "GV2_CAPTION"
        Me.Localizer1.SetWordID(Me.GV2_CAPTION, "")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PanelControl1)
        Me.Panel1.Controls.Add(Me.grpCtrlRmkList)
        Me.Panel1.Controls.Add(Me.WG1)
        Me.Panel1.Location = New System.Drawing.Point(2, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 569)
        Me.Panel1.TabIndex = 109
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ComMailMsg
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1266, 608)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(525, 646)
        Me.Name = "ComMailMsg"
        Me.Text = "Mail Message Management"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.grpCtrlRmkList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCtrlRmkList.ResumeLayout(False)
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents CONTENTS As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents SUBJECT As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents lbl_SUBJECT As YJIT.SC.UI.SCControls.Label
    Friend WithEvents lbl_CONTENTS As YJIT.SC.UI.SCControls.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_GRP_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COMN_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SUBJECT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CONTENTS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MSG_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MSG_TYPE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DEPT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_GRP_CD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents lbl_COMN_CD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents lbl_REQ_SVC As YJIT.SC.UI.SCControls.Label
    Friend WithEvents lbl_DEPT_CD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents COMN_CD As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents MSG_TYPE2 As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GRP_CD As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents btnNew As YJIT.SC.UI.SCControls.Button
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpCtrlRmkList As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV2_TAG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MSG_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents btnDelete As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV2_CAPTION As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents DEPT_CD As YJIT.SC.UI.SCControls.ComboBox




End Class
