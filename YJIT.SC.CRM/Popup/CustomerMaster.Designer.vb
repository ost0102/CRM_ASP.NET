<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerMaster
    Inherits YJIT.SC.UI.SCCodeView

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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerMaster))
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnClear = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.txtKeyword = New YJIT.SC.UI.SCControls.TextBox()
        Me.SEARCH_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.flpPageList = New System.Windows.Forms.FlowLayoutPanel()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        GridLevelNode1.RelationName = "Level1"
        Me.WG1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.WG1.Location = New System.Drawing.Point(8, 78)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(647, 298)
        Me.WG1.TabIndex = 1
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3, Me.GridColumn2, Me.GridColumn6, Me.GridColumn4, Me.GridColumn5})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Code"
        Me.GridColumn1.FieldName = "CODE"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 90
        Me.Localizer1.SetWordID(Me.GridColumn1, "Code")
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Name"
        Me.GridColumn3.FieldName = "CUST_LOCNM"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 208
        Me.Localizer1.SetWordID(Me.GridColumn3, "Name")
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Address"
        Me.GridColumn2.FieldName = "OFFICE_ADDR"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 155
        Me.Localizer1.SetWordID(Me.GridColumn2, "Address")
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "시스템"
        Me.GridColumn6.FieldName = "SVC_CD"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GridColumn6, "시스템")
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Biz No"
        Me.GridColumn4.FieldName = "CRN"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 86
        Me.Localizer1.SetWordID(Me.GridColumn4, "Biz No")
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Owner"
        Me.GridColumn5.FieldName = "CEO"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 87
        Me.Localizer1.SetWordID(Me.GridColumn5, "Owner")
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnClear)
        Me.GroupControl1.Controls.Add(Me.btnSearch)
        Me.GroupControl1.Controls.Add(Me.txtKeyword)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(645, 58)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Search Conditions"
        Me.Localizer1.SetWordID(Me.GroupControl1, "Search Conditions")
        '
        'btnClear
        '
        Me.btnClear.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnClear.Location = New System.Drawing.Point(473, 25)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 25)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.Localizer1.SetWordID(Me.btnClear, "Clear")
        '
        'btnSearch
        '
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Location = New System.Drawing.Point(403, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(65, 25)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.Localizer1.SetWordID(Me.btnSearch, "Search")
        '
        'txtKeyword
        '
        Me.txtKeyword.BorderColor = System.Drawing.Color.Empty
        Me.txtKeyword.DefVal = ""
        Me.txtKeyword.IsDataStateAware = True
        Me.txtKeyword.Location = New System.Drawing.Point(6, 28)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.NextFocus = Nothing
        Me.txtKeyword.Size = New System.Drawing.Size(391, 22)
        Me.txtKeyword.TabIndex = 0
        Me.txtKeyword.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'SEARCH_TYPE
        '
        Me.SEARCH_TYPE.CodeType = ""
        Me.SEARCH_TYPE.ColumnWidths = ""
        Me.SEARCH_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.SEARCH_TYPE.DataParams = ""
        Me.SEARCH_TYPE.DefVal = "1"
        Me.SEARCH_TYPE.DisplayMember = "NAME"
        Me.SEARCH_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SEARCH_TYPE.FormattingEnabled = True
        Me.SEARCH_TYPE.IsDataStateAware = True
        Me.SEARCH_TYPE.ItemDelimiter = ","
        Me.SEARCH_TYPE.ItemTextList = "Local Name,English Name,Office Address,B/L Print Address,CEO,REG No,Country"
        Me.SEARCH_TYPE.ItemValueList = "1,2,3,4,5,6,7"
        Me.SEARCH_TYPE.KeepIntegrity = True
        Me.SEARCH_TYPE.Location = New System.Drawing.Point(751, 13)
        Me.SEARCH_TYPE.Name = "SEARCH_TYPE"
        Me.SEARCH_TYPE.NextFocus = Nothing
        Me.SEARCH_TYPE.NullText = "--Select--"
        Me.SEARCH_TYPE.SearchKeys = ""
        Me.SEARCH_TYPE.Size = New System.Drawing.Size(136, 22)
        Me.SEARCH_TYPE.TabIndex = 3
        Me.SEARCH_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.SEARCH_TYPE.ValueMember = "CODE"
        Me.SEARCH_TYPE.Visible = False
        '
        'flpPageList
        '
        Me.flpPageList.Location = New System.Drawing.Point(14, 382)
        Me.flpPageList.Name = "flpPageList"
        Me.flpPageList.Size = New System.Drawing.Size(409, 24)
        Me.flpPageList.TabIndex = 2
        Me.Localizer1.SetWordID(Me.flpPageList, "")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GridColumn1, "Code")
        Me.Localizer1.SetWordID(Me.GridColumn3, "Name")
        Me.Localizer1.SetWordID(Me.GridColumn2, "Address")
        Me.Localizer1.SetWordID(Me.GridColumn6, "시스템")
        Me.Localizer1.SetWordID(Me.GridColumn4, "Biz No")
        Me.Localizer1.SetWordID(Me.GridColumn5, "Owner")
        Me.Localizer1.SetWordID(Me.GroupControl1, "Search Conditions")
        Me.Localizer1.SetWordID(Me.btnClear, "Clear")
        Me.Localizer1.SetWordID(Me.btnSearch, "Search")
        Me.Localizer1.SetWordID(Me.txtKeyword, "")
        Me.Localizer1.SetWordID(Me.SEARCH_TYPE, "--Select--")
        Me.Localizer1.SetWordID(Me.flpPageList, "")
        '
        'CustomerMaster
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(663, 409)
        Me.Controls.Add(Me.SEARCH_TYPE)
        Me.Controls.Add(Me.flpPageList)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.WG1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Code"
        Me.Localizer1.SetWordID(Me, "Search Code")
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents txtKeyword As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClear As YJIT.SC.UI.SCControls.Button
    Friend WithEvents flpPageList As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SEARCH_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
