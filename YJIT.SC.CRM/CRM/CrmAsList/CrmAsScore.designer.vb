<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmAsScore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmAsScore))
        Me.btnClear = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.S_GRP_CD = New YJIT.SC.UI.SCControls.ComboBox()
        Me.lbl_S_MANUAL_TYPE = New YJIT.SC.UI.SCControls.Label()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_GRP_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COMN_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CD_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_OPT_ITEM10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnClear.Location = New System.Drawing.Point(844, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 25)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.Localizer1.SetWordID(Me.btnClear, "Clear")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(768, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnClear)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(996, 32)
        Me.palAutoButton.TabIndex = 2
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(920, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnClear, "Clear")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.S_GRP_CD, "--Select--")
        Me.Localizer1.SetWordID(Me.lbl_S_MANUAL_TYPE, "관리항목")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_GRP_CD, "그룹코드")
        Me.Localizer1.SetWordID(Me.GV1_COMN_CD, "구분코드")
        Me.Localizer1.SetWordID(Me.GV1_CD_NM, "구분")
        Me.Localizer1.SetWordID(Me.GV1_OPT_ITEM10, "점수")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "Remark")
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "입력자")
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "입력일자")
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "수정자")
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "수정일자")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.S_GRP_CD)
        Me.PanelControl1.Controls.Add(Me.lbl_S_MANUAL_TYPE)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 42)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(996, 66)
        Me.PanelControl1.TabIndex = 0
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'S_GRP_CD
        '
        Me.S_GRP_CD.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_GRP_CD.ColumnWidths = ""
        Me.S_GRP_CD.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_GRP_CD.DataParams = "GroupCode:'T13',NameType:''"
        Me.S_GRP_CD.DefVal = "T10"
        Me.S_GRP_CD.DisplayMember = "NAME"
        Me.S_GRP_CD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_GRP_CD.FormattingEnabled = True
        Me.S_GRP_CD.IsDataStateAware = True
        Me.S_GRP_CD.ItemDelimiter = ","
        Me.S_GRP_CD.ItemTextList = ""
        Me.S_GRP_CD.ItemValueList = ""
        Me.S_GRP_CD.KeepIntegrity = True
        Me.S_GRP_CD.Location = New System.Drawing.Point(82, 5)
        Me.S_GRP_CD.Name = "S_GRP_CD"
        Me.S_GRP_CD.NextFocus = "btnSearch"
        Me.S_GRP_CD.NullText = ""
        Me.S_GRP_CD.SearchKeys = ""
        Me.S_GRP_CD.Size = New System.Drawing.Size(133, 22)
        Me.S_GRP_CD.TabIndex = 49
        Me.S_GRP_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_GRP_CD.ValueMember = "CODE"
        '
        'lbl_S_MANUAL_TYPE
        '
        Me.lbl_S_MANUAL_TYPE.LabelFor = Nothing
        Me.lbl_S_MANUAL_TYPE.Location = New System.Drawing.Point(12, 9)
        Me.lbl_S_MANUAL_TYPE.Name = "lbl_S_MANUAL_TYPE"
        Me.lbl_S_MANUAL_TYPE.Size = New System.Drawing.Size(64, 14)
        Me.lbl_S_MANUAL_TYPE.TabIndex = 50
        Me.lbl_S_MANUAL_TYPE.Text = "관리항목"
        Me.lbl_S_MANUAL_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_MANUAL_TYPE, "")
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
        Me.WG1.Location = New System.Drawing.Point(6, 114)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(996, 520)
        Me.WG1.TabIndex = 3
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GridView1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_GRP_CD, Me.GV1_COMN_CD, Me.GV1_CD_NM, Me.GV1_OPT_ITEM10, Me.GV1_RMK, Me.GV1_INS_USR, Me.GV1_INS_YMD, Me.GV1_UPD_USR, Me.GV1_UPD_YMD})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.ViewCaption = " Manual List"
        '
        'GV1_GRP_CD
        '
        Me.GV1_GRP_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_GRP_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_GRP_CD.Caption = "그룹코드"
        Me.GV1_GRP_CD.FieldName = "GRP_CD"
        Me.GV1_GRP_CD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_GRP_CD.Name = "GV1_GRP_CD"
        Me.GV1_GRP_CD.OptionsColumn.AllowEdit = False
        Me.GV1_GRP_CD.OptionsColumn.ReadOnly = True
        Me.GV1_GRP_CD.Visible = True
        Me.GV1_GRP_CD.VisibleIndex = 0
        Me.GV1_GRP_CD.Width = 132
        Me.Localizer1.SetWordID(Me.GV1_GRP_CD, "")
        '
        'GV1_COMN_CD
        '
        Me.GV1_COMN_CD.Caption = "구분코드"
        Me.GV1_COMN_CD.FieldName = "COMN_CD"
        Me.GV1_COMN_CD.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_COMN_CD.Name = "GV1_COMN_CD"
        Me.GV1_COMN_CD.OptionsColumn.AllowEdit = False
        Me.GV1_COMN_CD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_COMN_CD, "")
        '
        'GV1_CD_NM
        '
        Me.GV1_CD_NM.Caption = "구분"
        Me.GV1_CD_NM.FieldName = "CD_NM"
        Me.GV1_CD_NM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_CD_NM.Name = "GV1_CD_NM"
        Me.GV1_CD_NM.OptionsColumn.AllowEdit = False
        Me.GV1_CD_NM.OptionsColumn.ReadOnly = True
        Me.GV1_CD_NM.Visible = True
        Me.GV1_CD_NM.VisibleIndex = 1
        Me.GV1_CD_NM.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_CD_NM, "")
        '
        'GV1_OPT_ITEM10
        '
        Me.GV1_OPT_ITEM10.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_OPT_ITEM10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_OPT_ITEM10.Caption = "점수"
        Me.GV1_OPT_ITEM10.FieldName = "OPT_ITEM10"
        Me.GV1_OPT_ITEM10.Name = "GV1_OPT_ITEM10"
        Me.GV1_OPT_ITEM10.Visible = True
        Me.GV1_OPT_ITEM10.VisibleIndex = 2
        Me.GV1_OPT_ITEM10.Width = 82
        Me.Localizer1.SetWordID(Me.GV1_OPT_ITEM10, "")
        '
        'GV1_RMK
        '
        Me.GV1_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RMK.Caption = "Remark"
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 3
        Me.GV1_RMK.Width = 191
        Me.Localizer1.SetWordID(Me.GV1_RMK, "")
        '
        'GV1_INS_USR
        '
        Me.GV1_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.Caption = "입력자"
        Me.GV1_INS_USR.FieldName = "INS_USR"
        Me.GV1_INS_USR.Name = "GV1_INS_USR"
        Me.GV1_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV1_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV1_INS_USR.Visible = True
        Me.GV1_INS_USR.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "")
        '
        'GV1_INS_YMD
        '
        Me.GV1_INS_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_YMD.Caption = "입력일자"
        Me.GV1_INS_YMD.FieldName = "INS_YMD"
        Me.GV1_INS_YMD.Name = "GV1_INS_YMD"
        Me.GV1_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_INS_YMD.Visible = True
        Me.GV1_INS_YMD.VisibleIndex = 5
        Me.GV1_INS_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_INS_YMD, "")
        '
        'GV1_UPD_USR
        '
        Me.GV1_UPD_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPD_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_USR.Caption = "수정자"
        Me.GV1_UPD_USR.FieldName = "UPD_USR"
        Me.GV1_UPD_USR.Name = "GV1_UPD_USR"
        Me.GV1_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_USR.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_USR.Visible = True
        Me.GV1_UPD_USR.VisibleIndex = 6
        Me.Localizer1.SetWordID(Me.GV1_UPD_USR, "")
        '
        'GV1_UPD_YMD
        '
        Me.GV1_UPD_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_UPD_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_UPD_YMD.Caption = "수정일자"
        Me.GV1_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV1_UPD_YMD.Name = "GV1_UPD_YMD"
        Me.GV1_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_UPD_YMD.Visible = True
        Me.GV1_UPD_YMD.VisibleIndex = 7
        Me.GV1_UPD_YMD.Width = 130
        Me.Localizer1.SetWordID(Me.GV1_UPD_YMD, "")
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.WG1
        Me.GridView1.Name = "GridView1"
        '
        'CrmAsScore
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1008, 640)
        Me.Controls.Add(Me.WG1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "CrmAsScore"
        Me.Text = "항목별 점수관리"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClear As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_GRP_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_OPT_ITEM10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents S_GRP_CD As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents lbl_S_MANUAL_TYPE As YJIT.SC.UI.SCControls.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GV1_COMN_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CD_NM As DevExpress.XtraGrid.Columns.GridColumn
End Class
