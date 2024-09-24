<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmArList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmArList))
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_SLIP_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateType = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_BAL_LOC_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CheckType = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.S_CUST_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.S_CUST_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_SLIP_YMD, "전표일자")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "적요")
        Me.Localizer1.SetWordID(Me.GV1_BAL_LOC_AMT, "미수금액")
        Me.Localizer1.SetWordID(Me.S_CUST_CD, "")
        Me.Localizer1.SetWordID(Me.Label7, "거래처")
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        Me.Localizer1.SetWordID(Me.Label1, "*2018년 1월 이후 발생분")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(572, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 25)
        Me.btnSearch.TabIndex = 9999
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(5, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(651, 32)
        Me.palAutoButton.TabIndex = 278
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
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
        Me.WG1.Location = New System.Drawing.Point(5, 85)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.DateType, Me.CheckType})
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(651, 221)
        Me.WG1.TabIndex = 303
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_SLIP_YMD, Me.GV1_RMK, Me.GV1_BAL_LOC_AMT})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsCustomization.AllowRowSizing = True
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GV1.OptionsView.BestFitMaxRowCount = 10
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV1.RowHeight = 10
        Me.GV1.ViewCaption = " 고객 리스트"
        '
        'GV1_SLIP_YMD
        '
        Me.GV1_SLIP_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SLIP_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SLIP_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SLIP_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SLIP_YMD.Caption = "전표일자"
        Me.GV1_SLIP_YMD.ColumnEdit = Me.DateType
        Me.GV1_SLIP_YMD.FieldName = "SLIP_YMD"
        Me.GV1_SLIP_YMD.Name = "GV1_SLIP_YMD"
        Me.GV1_SLIP_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_SLIP_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_SLIP_YMD.Visible = True
        Me.GV1_SLIP_YMD.VisibleIndex = 0
        Me.GV1_SLIP_YMD.Width = 99
        Me.Localizer1.SetWordID(Me.GV1_SLIP_YMD, "전표일자")
        '
        'DateType
        '
        Me.DateType.AutoHeight = False
        Me.DateType.Mask.EditMask = "9999-99-99"
        Me.DateType.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.DateType.Mask.UseMaskAsDisplayFormat = True
        Me.DateType.Name = "DateType"
        '
        'GV1_RMK
        '
        Me.GV1_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RMK.Caption = "적요"
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.OptionsColumn.AllowEdit = False
        Me.GV1_RMK.OptionsColumn.ReadOnly = True
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 1
        Me.GV1_RMK.Width = 212
        Me.Localizer1.SetWordID(Me.GV1_RMK, "적요")
        '
        'GV1_BAL_LOC_AMT
        '
        Me.GV1_BAL_LOC_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BAL_LOC_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_BAL_LOC_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BAL_LOC_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BAL_LOC_AMT.Caption = "미수금액"
        Me.GV1_BAL_LOC_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV1_BAL_LOC_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_BAL_LOC_AMT.FieldName = "BAL_LOC_AMT"
        Me.GV1_BAL_LOC_AMT.Name = "GV1_BAL_LOC_AMT"
        Me.GV1_BAL_LOC_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_BAL_LOC_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_BAL_LOC_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BAL_LOC_AMT", "{0:N0}")})
        Me.GV1_BAL_LOC_AMT.Visible = True
        Me.GV1_BAL_LOC_AMT.VisibleIndex = 2
        Me.GV1_BAL_LOC_AMT.Width = 124
        Me.Localizer1.SetWordID(Me.GV1_BAL_LOC_AMT, "미수금액")
        '
        'CheckType
        '
        Me.CheckType.AutoHeight = False
        Me.CheckType.Name = "CheckType"
        Me.CheckType.ValueChecked = "Y"
        Me.CheckType.ValueUnchecked = "N"
        '
        'S_CUST_CD
        '
        Me.S_CUST_CD.AlwaysSetDisplayParams = True
        Me.S_CUST_CD.AutoSuggestion = False
        Me.S_CUST_CD.BorderColor = System.Drawing.Color.Silver
        Me.S_CUST_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_CUST_CD.CodeType = "YJIT.CodeService.Customer"
        Me.S_CUST_CD.DataParams = ""
        Me.S_CUST_CD.DefVal = ""
        Me.S_CUST_CD.DisplayParams = "Code:@S_CUST_CD,Name:@S_CUST_NM"
        Me.S_CUST_CD.EditPopup = ""
        Me.S_CUST_CD.Enabled = False
        Me.S_CUST_CD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_CUST_CD.IconVisible = True
        Me.S_CUST_CD.IsDataStateAware = True
        Me.S_CUST_CD.KeepIntegrity = True
        Me.S_CUST_CD.Location = New System.Drawing.Point(72, 7)
        Me.S_CUST_CD.Name = "S_CUST_CD"
        Me.S_CUST_CD.NextFocus = "S_WORK_USR"
        Me.S_CUST_CD.SearchPopup = "CodeMaster"
        Me.S_CUST_CD.Size = New System.Drawing.Size(91, 23)
        Me.S_CUST_CD.SuppressValidateCode = False
        Me.S_CUST_CD.TabIndex = 10015
        Me.S_CUST_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_CUST_CD.ValidateKeys = "KEY:@S_CUST_CD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(23, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 10014
        Me.Label7.Text = "거래처"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label7, "")
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Controls.Add(Me.S_CUST_CD)
        Me.PanelControl4.Controls.Add(Me.S_CUST_NM)
        Me.PanelControl4.Controls.Add(Me.Label1)
        Me.PanelControl4.Controls.Add(Me.Label7)
        Me.PanelControl4.Location = New System.Drawing.Point(5, 41)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(651, 38)
        Me.PanelControl4.TabIndex = 304
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        '
        'S_CUST_NM
        '
        Me.S_CUST_NM.AutoEllipsis = True
        Me.S_CUST_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_CUST_NM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_CUST_NM.LabelFor = Nothing
        Me.S_CUST_NM.Location = New System.Drawing.Point(164, 7)
        Me.S_CUST_NM.Name = "S_CUST_NM"
        Me.S_CUST_NM.Size = New System.Drawing.Size(174, 23)
        Me.S_CUST_NM.TabIndex = 10016
        Me.S_CUST_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(501, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 15)
        Me.Label1.TabIndex = 10014
        Me.Label1.Text = "*2018년 1월 이후 발생분"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "")
        '
        'CrmArList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(663, 315)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.WG1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CrmArList"
        Me.Text = "미수 리스트"
        Me.Localizer1.SetWordID(Me, "미수 리스트")
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Public WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents DateType As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CheckType As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_SLIP_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BAL_LOC_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents S_CUST_NM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label7 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Public WithEvents S_CUST_CD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
End Class
