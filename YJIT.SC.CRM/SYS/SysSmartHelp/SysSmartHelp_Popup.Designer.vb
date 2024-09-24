<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysSmartHelp_Popup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SysSmartHelp_Popup))
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.NODE_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnDown = New YJIT.SC.UI.SCControls.Button()
        Me.btnUp = New YJIT.SC.UI.SCControls.Button()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PARENT_NODE_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.PARENT_TITLE = New YJIT.SC.UI.SCControls.TextLabel()
        Me.Label11 = New YJIT.SC.UI.SCControls.Label()
        Me.Label8 = New YJIT.SC.UI.SCControls.Label()
        Me.PARENT_NODE_ID = New YJIT.SC.UI.SCControls.TextLabel()
        Me.Label9 = New YJIT.SC.UI.SCControls.Label()
        Me.Label10 = New YJIT.SC.UI.SCControls.Label()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.Label5 = New YJIT.SC.UI.SCControls.Label()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.btnExit = New YJIT.SC.UI.SCControls.Button()
        Me.TITLE = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.lblResult = New YJIT.SC.UI.SCControls.Label()
        Me.NODE_ID = New YJIT.SC.UI.SCControls.TextLabel()
        Me.INS_USR = New YJIT.SC.UI.SCControls.TextLabel()
        Me.INS_DATE = New YJIT.SC.UI.SCControls.TextLabel()
        Me.UPD_USR = New YJIT.SC.UI.SCControls.TextLabel()
        Me.UPD_DATE = New YJIT.SC.UI.SCControls.TextLabel()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.Label1, "Node ID")
        Me.Localizer1.SetWordID(Me.Label2, "Title")
        Me.Localizer1.SetWordID(Me.Label3, "Node Type")
        Me.Localizer1.SetWordID(Me.NODE_TYPE, "R")
        Me.Localizer1.SetWordID(Me.GroupControl1, "Parent Node Info")
        Me.Localizer1.SetWordID(Me.btnDown, "Down")
        Me.Localizer1.SetWordID(Me.btnUp, "Up")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GridColumn3, "Seq")
        Me.Localizer1.SetWordID(Me.GridColumn1, "Node ID")
        Me.Localizer1.SetWordID(Me.GridColumn2, "Title")
        Me.Localizer1.SetWordID(Me.PARENT_NODE_TYPE, "R")
        Me.Localizer1.SetWordID(Me.Label11, "Node Order")
        Me.Localizer1.SetWordID(Me.Label8, "Parent title")
        Me.Localizer1.SetWordID(Me.Label9, "Type")
        Me.Localizer1.SetWordID(Me.Label10, "Parent ID")
        Me.Localizer1.SetWordID(Me.Label4, "Creator")
        Me.Localizer1.SetWordID(Me.Label5, "at")
        Me.Localizer1.SetWordID(Me.Label6, "Last Updater")
        Me.Localizer1.SetWordID(Me.Label7, "at")
        Me.Localizer1.SetWordID(Me.btnExit, "&Exit")
        Me.Localizer1.SetWordID(Me.TITLE, "")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.lblResult, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(39, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Node ID"
        Me.Localizer1.SetWordID(Me.Label1, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(60, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Title"
        Me.Localizer1.SetWordID(Me.Label2, "")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(282, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Node Type"
        Me.Localizer1.SetWordID(Me.Label3, "")
        '
        'NODE_TYPE
        '
        Me.NODE_TYPE.CodeType = ""
        Me.NODE_TYPE.ColumnWidths = ""
        Me.NODE_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.NODE_TYPE.DataParams = ""
        Me.NODE_TYPE.DefVal = ""
        Me.NODE_TYPE.DisplayMember = "NAME"
        Me.NODE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NODE_TYPE.Enabled = False
        Me.NODE_TYPE.FormattingEnabled = True
        Me.NODE_TYPE.IsDataStateAware = True
        Me.NODE_TYPE.ItemDelimiter = ","
        Me.NODE_TYPE.ItemTextList = "Root,Group,Node"
        Me.NODE_TYPE.ItemValueList = "R,G,N"
        Me.NODE_TYPE.KeepIntegrity = True
        Me.NODE_TYPE.Location = New System.Drawing.Point(356, 10)
        Me.NODE_TYPE.Name = "NODE_TYPE"
        Me.NODE_TYPE.NextFocus = Nothing
        Me.NODE_TYPE.NullText = ""
        Me.NODE_TYPE.RequiredFor = ""
        Me.NODE_TYPE.SearchKeys = ""
        Me.NODE_TYPE.Size = New System.Drawing.Size(126, 22)
        Me.NODE_TYPE.TabIndex = 2
        Me.NODE_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.NODE_TYPE.ValueMember = "CODE"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnDown)
        Me.GroupControl1.Controls.Add(Me.btnUp)
        Me.GroupControl1.Controls.Add(Me.WG1)
        Me.GroupControl1.Controls.Add(Me.PARENT_NODE_TYPE)
        Me.GroupControl1.Controls.Add(Me.PARENT_TITLE)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.PARENT_NODE_ID)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 118)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(470, 212)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Parent Node Info"
        Me.Localizer1.SetWordID(Me.GroupControl1, "")
        '
        'btnDown
        '
        Me.btnDown.Action = ""
        Me.btnDown.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(19, 138)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(59, 23)
        Me.btnDown.TabIndex = 10
        Me.btnDown.Text = "Down"
        Me.Localizer1.SetWordID(Me.btnDown, "")
        '
        'btnUp
        '
        Me.btnUp.Action = ""
        Me.btnUp.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(19, 109)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(59, 23)
        Me.btnUp.TabIndex = 10
        Me.btnUp.Text = "Up"
        Me.Localizer1.SetWordID(Me.btnUp, "")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(84, 74)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(381, 133)
        Me.WG1.TabIndex = 9
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn1, Me.GridColumn2})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsBehavior.ReadOnly = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Seq"
        Me.GridColumn3.FieldName = "DISPLAY_SEQ"
        Me.GridColumn3.Name = "GridColumn3"
        Me.Localizer1.SetWordID(Me.GridColumn3, "")
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Node ID"
        Me.GridColumn1.FieldName = "NODE_ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 90
        Me.Localizer1.SetWordID(Me.GridColumn1, "")
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Title"
        Me.GridColumn2.FieldName = "TITLE"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 273
        Me.Localizer1.SetWordID(Me.GridColumn2, "")
        '
        'PARENT_NODE_TYPE
        '
        Me.PARENT_NODE_TYPE.CodeType = ""
        Me.PARENT_NODE_TYPE.ColumnWidths = ""
        Me.PARENT_NODE_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.PARENT_NODE_TYPE.DataParams = ""
        Me.PARENT_NODE_TYPE.DefVal = ""
        Me.PARENT_NODE_TYPE.DisplayMember = "NAME"
        Me.PARENT_NODE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PARENT_NODE_TYPE.Enabled = False
        Me.PARENT_NODE_TYPE.FormattingEnabled = True
        Me.PARENT_NODE_TYPE.IsDataStateAware = True
        Me.PARENT_NODE_TYPE.ItemDelimiter = ","
        Me.PARENT_NODE_TYPE.ItemTextList = "Root,Group,Node"
        Me.PARENT_NODE_TYPE.ItemValueList = "R,G,N"
        Me.PARENT_NODE_TYPE.KeepIntegrity = True
        Me.PARENT_NODE_TYPE.Location = New System.Drawing.Point(339, 24)
        Me.PARENT_NODE_TYPE.Name = "PARENT_NODE_TYPE"
        Me.PARENT_NODE_TYPE.NextFocus = Nothing
        Me.PARENT_NODE_TYPE.NullText = ""
        Me.PARENT_NODE_TYPE.RequiredFor = ""
        Me.PARENT_NODE_TYPE.SearchKeys = ""
        Me.PARENT_NODE_TYPE.Size = New System.Drawing.Size(126, 22)
        Me.PARENT_NODE_TYPE.TabIndex = 8
        Me.PARENT_NODE_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.PARENT_NODE_TYPE.ValueMember = "CODE"
        '
        'PARENT_TITLE
        '
        Me.PARENT_TITLE.AutoEllipsis = True
        Me.PARENT_TITLE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PARENT_TITLE.LabelFor = Nothing
        Me.PARENT_TITLE.Location = New System.Drawing.Point(85, 48)
        Me.PARENT_TITLE.Name = "PARENT_TITLE"
        Me.PARENT_TITLE.Size = New System.Drawing.Size(380, 23)
        Me.PARENT_TITLE.TabIndex = 7
        Me.PARENT_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.LabelFor = Nothing
        Me.Label11.Location = New System.Drawing.Point(8, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 14)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Node Order"
        Me.Localizer1.SetWordID(Me.Label11, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.LabelFor = Nothing
        Me.Label8.Location = New System.Drawing.Point(11, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 14)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Parent title"
        Me.Localizer1.SetWordID(Me.Label8, "")
        '
        'PARENT_NODE_ID
        '
        Me.PARENT_NODE_ID.AutoEllipsis = True
        Me.PARENT_NODE_ID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PARENT_NODE_ID.LabelFor = Nothing
        Me.PARENT_NODE_ID.Location = New System.Drawing.Point(85, 23)
        Me.PARENT_NODE_ID.Name = "PARENT_NODE_ID"
        Me.PARENT_NODE_ID.Size = New System.Drawing.Size(120, 23)
        Me.PARENT_NODE_ID.TabIndex = 6
        Me.PARENT_NODE_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.LabelFor = Nothing
        Me.Label9.Location = New System.Drawing.Point(298, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 14)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Type"
        Me.Localizer1.SetWordID(Me.Label9, "")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.LabelFor = Nothing
        Me.Label10.Location = New System.Drawing.Point(20, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 14)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Parent ID"
        Me.Localizer1.SetWordID(Me.Label10, "")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(44, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Creator"
        Me.Localizer1.SetWordID(Me.Label4, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.LabelFor = Nothing
        Me.Label5.Location = New System.Drawing.Point(229, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "at"
        Me.Localizer1.SetWordID(Me.Label5, "")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(14, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Last Updater"
        Me.Localizer1.SetWordID(Me.Label6, "")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(229, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "at"
        Me.Localizer1.SetWordID(Me.Label7, "")
        '
        'btnExit
        '
        Me.btnExit.Action = ""
        Me.btnExit.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExit.Location = New System.Drawing.Point(275, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.Localizer1.SetWordID(Me.btnExit, "")
        '
        'TITLE
        '
        Me.TITLE.BorderColor = System.Drawing.Color.Empty
        Me.TITLE.DefVal = ""
        Me.TITLE.IsDataStateAware = True
        Me.TITLE.Location = New System.Drawing.Point(96, 35)
        Me.TITLE.MaxLength = 500
        Me.TITLE.Name = "TITLE"
        Me.TITLE.NextFocus = Nothing
        Me.TITLE.RequiredFor = ""
        Me.TITLE.Size = New System.Drawing.Size(386, 22)
        Me.TITLE.TabIndex = 5
        Me.TITLE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'btnSave
        '
        Me.btnSave.Action = "SaveData"
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(182, 336)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "")
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblResult.LabelFor = Nothing
        Me.lblResult.Location = New System.Drawing.Point(10, 342)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 14)
        Me.lblResult.TabIndex = 7
        Me.Localizer1.SetWordID(Me.lblResult, "")
        '
        'NODE_ID
        '
        Me.NODE_ID.AutoEllipsis = True
        Me.NODE_ID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NODE_ID.ForeColor = System.Drawing.Color.Maroon
        Me.NODE_ID.LabelFor = Nothing
        Me.NODE_ID.Location = New System.Drawing.Point(97, 9)
        Me.NODE_ID.Name = "NODE_ID"
        Me.NODE_ID.Size = New System.Drawing.Size(126, 23)
        Me.NODE_ID.TabIndex = 1
        Me.NODE_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'INS_USR
        '
        Me.INS_USR.AutoEllipsis = True
        Me.INS_USR.BorderColor = System.Drawing.Color.Silver
        Me.INS_USR.LabelFor = Nothing
        Me.INS_USR.Location = New System.Drawing.Point(97, 60)
        Me.INS_USR.Name = "INS_USR"
        Me.INS_USR.Size = New System.Drawing.Size(126, 23)
        Me.INS_USR.TabIndex = 1
        Me.INS_USR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'INS_DATE
        '
        Me.INS_DATE.AutoEllipsis = True
        Me.INS_DATE.BorderColor = System.Drawing.Color.Silver
        Me.INS_DATE.LabelFor = Nothing
        Me.INS_DATE.Location = New System.Drawing.Point(266, 60)
        Me.INS_DATE.Name = "INS_DATE"
        Me.INS_DATE.Size = New System.Drawing.Size(216, 23)
        Me.INS_DATE.TabIndex = 1
        Me.INS_DATE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UPD_USR
        '
        Me.UPD_USR.AutoEllipsis = True
        Me.UPD_USR.BorderColor = System.Drawing.Color.Silver
        Me.UPD_USR.LabelFor = Nothing
        Me.UPD_USR.Location = New System.Drawing.Point(97, 84)
        Me.UPD_USR.Name = "UPD_USR"
        Me.UPD_USR.Size = New System.Drawing.Size(126, 23)
        Me.UPD_USR.TabIndex = 1
        Me.UPD_USR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UPD_DATE
        '
        Me.UPD_DATE.AutoEllipsis = True
        Me.UPD_DATE.BorderColor = System.Drawing.Color.Silver
        Me.UPD_DATE.LabelFor = Nothing
        Me.UPD_DATE.Location = New System.Drawing.Point(266, 84)
        Me.UPD_DATE.Name = "UPD_DATE"
        Me.UPD_DATE.Size = New System.Drawing.Size(216, 23)
        Me.UPD_DATE.TabIndex = 1
        Me.UPD_DATE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SysSmartHelp_Popup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 371)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TITLE)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.NODE_TYPE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UPD_DATE)
        Me.Controls.Add(Me.INS_DATE)
        Me.Controls.Add(Me.UPD_USR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.INS_USR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NODE_ID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SysSmartHelp_Popup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Node Properties"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents NODE_ID As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents NODE_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents INS_USR As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label5 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents INS_DATE As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label6 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label7 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents UPD_USR As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents UPD_DATE As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents PARENT_NODE_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents PARENT_TITLE As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label8 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PARENT_NODE_ID As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label9 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label10 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnExit As YJIT.SC.UI.SCControls.Button
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label11 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents TITLE As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnDown As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnUp As YJIT.SC.UI.SCControls.Button
    Friend WithEvents lblResult As YJIT.SC.UI.SCControls.Label
End Class
