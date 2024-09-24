<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysHelpHyperLink
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SysHelpHyperLink))
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.btnExit = New YJIT.SC.UI.SCControls.Button()
        Me.LINK_URL = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnInsert = New YJIT.SC.UI.SCControls.Button()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.rdoLinkType = New YJIT.SC.UI.SCControls.RadioGroup()
        Me.trwFileExplorer = New System.Windows.Forms.TreeView()
        Me.imlFileExplorer = New System.Windows.Forms.ImageList(Me.components)
        Me.LINK_TOOLTIP = New YJIT.SC.UI.SCControls.TextBox()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.rdoLinkType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.Label2, "Destination")
        Me.Localizer1.SetWordID(Me.btnExit, "&Exit")
        Me.Localizer1.SetWordID(Me.LINK_URL, "")
        Me.Localizer1.SetWordID(Me.btnInsert, "Insert")
        Me.Localizer1.SetWordID(Me.GroupControl1, "Link Options")
        Me.Localizer1.SetWordID(Me.rdoLinkType, "N")
        Me.Localizer1.SetWordID(Me.trwFileExplorer, "")
        Me.Localizer1.SetWordID(Me.LINK_TOOLTIP, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(199, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Destination"
        Me.Localizer1.SetWordID(Me.Label2, "")
        '
        'btnExit
        '
        Me.btnExit.Action = ""
        Me.btnExit.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExit.Location = New System.Drawing.Point(364, 287)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.Localizer1.SetWordID(Me.btnExit, "")
        '
        'LINK_URL
        '
        Me.LINK_URL.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LINK_URL.DefVal = ""
        Me.LINK_URL.IsDataStateAware = True
        Me.LINK_URL.Location = New System.Drawing.Point(199, 150)
        Me.LINK_URL.MaxLength = 500
        Me.LINK_URL.Name = "LINK_URL"
        Me.LINK_URL.NextFocus = Nothing
        Me.LINK_URL.RequiredFor = ""
        Me.LINK_URL.Size = New System.Drawing.Size(296, 22)
        Me.LINK_URL.TabIndex = 5
        Me.LINK_URL.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'btnInsert
        '
        Me.btnInsert.Action = "SaveData"
        Me.btnInsert.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnInsert.Image = CType(resources.GetObject("btnInsert.Image"), System.Drawing.Image)
        Me.btnInsert.Location = New System.Drawing.Point(271, 287)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "Insert"
        Me.Localizer1.SetWordID(Me.btnInsert, "")
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.rdoLinkType)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(483, 59)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Link Options"
        Me.Localizer1.SetWordID(Me.GroupControl1, "")
        '
        'rdoLinkType
        '
        Me.rdoLinkType.BindingPropertyName = "EditValue"
        Me.rdoLinkType.DefVal = Nothing
        Me.rdoLinkType.EditValue = "N"
        Me.rdoLinkType.IsDataStateAware = True
        Me.rdoLinkType.Location = New System.Drawing.Point(5, 26)
        Me.rdoLinkType.Name = "rdoLinkType"
        Me.rdoLinkType.NextFocus = ""
        Me.rdoLinkType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("N", "Help Node"), New DevExpress.XtraEditors.Controls.RadioGroupItem("U", "Free URL")})
        Me.rdoLinkType.RequiredFor = ""
        Me.rdoLinkType.Size = New System.Drawing.Size(473, 26)
        Me.rdoLinkType.TabIndex = 8
        Me.Localizer1.SetWordID(Me.rdoLinkType, "")
        '
        'trwFileExplorer
        '
        Me.trwFileExplorer.HideSelection = False
        Me.trwFileExplorer.ImageIndex = 0
        Me.trwFileExplorer.ImageList = Me.imlFileExplorer
        Me.trwFileExplorer.LabelEdit = True
        Me.trwFileExplorer.Location = New System.Drawing.Point(12, 61)
        Me.trwFileExplorer.Name = "trwFileExplorer"
        Me.trwFileExplorer.SelectedImageIndex = 0
        Me.trwFileExplorer.Size = New System.Drawing.Size(181, 249)
        Me.trwFileExplorer.TabIndex = 8
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
        Me.imlFileExplorer.Images.SetKeyName(8, "SqlFile")
        '
        'LINK_TOOLTIP
        '
        Me.LINK_TOOLTIP.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LINK_TOOLTIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LINK_TOOLTIP.DefVal = ""
        Me.LINK_TOOLTIP.IsDataStateAware = True
        Me.LINK_TOOLTIP.Location = New System.Drawing.Point(199, 178)
        Me.LINK_TOOLTIP.MaxLength = 500
        Me.LINK_TOOLTIP.Multiline = True
        Me.LINK_TOOLTIP.Name = "LINK_TOOLTIP"
        Me.LINK_TOOLTIP.NextFocus = Nothing
        Me.LINK_TOOLTIP.ReadOnly = True
        Me.LINK_TOOLTIP.RequiredFor = ""
        Me.LINK_TOOLTIP.Size = New System.Drawing.Size(296, 45)
        Me.LINK_TOOLTIP.TabIndex = 5
        Me.LINK_TOOLTIP.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'SysHelpHyperLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 321)
        Me.Controls.Add(Me.trwFileExplorer)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.LINK_TOOLTIP)
        Me.Controls.Add(Me.LINK_URL)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SysHelpHyperLink"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Node Properties"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.rdoLinkType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnExit As YJIT.SC.UI.SCControls.Button
    Friend WithEvents LINK_URL As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents btnInsert As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdoLinkType As YJIT.SC.UI.SCControls.RadioGroup
    Private WithEvents trwFileExplorer As System.Windows.Forms.TreeView
    Friend WithEvents imlFileExplorer As System.Windows.Forms.ImageList
    Public WithEvents LINK_TOOLTIP As YJIT.SC.UI.SCControls.TextBox
End Class
