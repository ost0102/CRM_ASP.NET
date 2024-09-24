<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmAsPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmAsPrint))
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.TextBox1 = New YJIT.SC.UI.SCControls.TextBox()
        Me.TextBox2 = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnPayment = New YJIT.SC.UI.SCControls.Button()
        Me.btnMetting = New YJIT.SC.UI.SCControls.Button()
        Me.palTop = New DevExpress.XtraEditors.PanelControl()
        Me.S_PRT_TYPE = New YJIT.SC.UI.SCControls.TextBox()
        Me.S_MNGT_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.TextBox1, "")
        Me.Localizer1.SetWordID(Me.TextBox2, "")
        Me.Localizer1.SetWordID(Me.btnPayment, "지출결의서")
        Me.Localizer1.SetWordID(Me.btnMetting, "회의록")
        Me.Localizer1.SetWordID(Me.palTop, "")
        Me.Localizer1.SetWordID(Me.S_PRT_TYPE, "")
        Me.Localizer1.SetWordID(Me.S_MNGT_NO, "")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.BorderColor = System.Drawing.Color.Silver
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DefVal = ""
        Me.TextBox1.IsDataStateAware = True
        Me.TextBox1.Location = New System.Drawing.Point(117, 4)
        Me.TextBox1.MaxLength = 30
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NextFocus = "TEL_NO"
        Me.TextBox1.Size = New System.Drawing.Size(618, 21)
        Me.TextBox1.TabIndex = 231
        Me.TextBox1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.BorderColor = System.Drawing.Color.Silver
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.DefVal = ""
        Me.TextBox2.IsDataStateAware = True
        Me.TextBox2.Location = New System.Drawing.Point(199, 131)
        Me.TextBox2.MaxLength = 30
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.NextFocus = "TEL_NO"
        Me.TextBox2.Size = New System.Drawing.Size(145, 21)
        Me.TextBox2.TabIndex = 234
        Me.TextBox2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'btnPayment
        '
        Me.btnPayment.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnPayment.Enabled = False
        Me.btnPayment.Image = CType(resources.GetObject("btnPayment.Image"), System.Drawing.Image)
        Me.btnPayment.Location = New System.Drawing.Point(107, 7)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(87, 40)
        Me.btnPayment.TabIndex = 5
        Me.btnPayment.Text = "지출결의서"
        Me.Localizer1.SetWordID(Me.btnPayment, "지출결의서")
        '
        'btnMetting
        '
        Me.btnMetting.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnMetting.Image = CType(resources.GetObject("btnMetting.Image"), System.Drawing.Image)
        Me.btnMetting.Location = New System.Drawing.Point(9, 7)
        Me.btnMetting.Name = "btnMetting"
        Me.btnMetting.Size = New System.Drawing.Size(87, 40)
        Me.btnMetting.TabIndex = 4
        Me.btnMetting.Text = "회의록"
        Me.Localizer1.SetWordID(Me.btnMetting, "회의록")
        '
        'palTop
        '
        Me.palTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palTop.Controls.Add(Me.S_PRT_TYPE)
        Me.palTop.Controls.Add(Me.S_MNGT_NO)
        Me.palTop.Controls.Add(Me.btnPayment)
        Me.palTop.Controls.Add(Me.btnMetting)
        Me.palTop.Location = New System.Drawing.Point(5, 3)
        Me.palTop.Name = "palTop"
        Me.palTop.Size = New System.Drawing.Size(204, 56)
        Me.palTop.TabIndex = 278
        Me.Localizer1.SetWordID(Me.palTop, "")
        '
        'S_PRT_TYPE
        '
        Me.S_PRT_TYPE.BackColor = System.Drawing.SystemColors.Window
        Me.S_PRT_TYPE.BorderColor = System.Drawing.Color.Silver
        Me.S_PRT_TYPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_PRT_TYPE.DefVal = ""
        Me.S_PRT_TYPE.IsDataStateAware = True
        Me.S_PRT_TYPE.Location = New System.Drawing.Point(194, 34)
        Me.S_PRT_TYPE.MaxLength = 30
        Me.S_PRT_TYPE.Name = "S_PRT_TYPE"
        Me.S_PRT_TYPE.NextFocus = ""
        Me.S_PRT_TYPE.ReadOnly = True
        Me.S_PRT_TYPE.Size = New System.Drawing.Size(10, 22)
        Me.S_PRT_TYPE.TabIndex = 233
        Me.S_PRT_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_PRT_TYPE.Visible = False
        '
        'S_MNGT_NO
        '
        Me.S_MNGT_NO.BackColor = System.Drawing.SystemColors.Window
        Me.S_MNGT_NO.BorderColor = System.Drawing.Color.Silver
        Me.S_MNGT_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_MNGT_NO.DefVal = ""
        Me.S_MNGT_NO.IsDataStateAware = True
        Me.S_MNGT_NO.Location = New System.Drawing.Point(183, 34)
        Me.S_MNGT_NO.MaxLength = 30
        Me.S_MNGT_NO.Name = "S_MNGT_NO"
        Me.S_MNGT_NO.NextFocus = ""
        Me.S_MNGT_NO.ReadOnly = True
        Me.S_MNGT_NO.Size = New System.Drawing.Size(10, 22)
        Me.S_MNGT_NO.TabIndex = 233
        Me.S_MNGT_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_MNGT_NO.Visible = False
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'CrmAsPrint
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(213, 64)
        Me.Controls.Add(Me.palTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CrmAsPrint"
        Me.Text = "출력물을 선택해주세요."
        Me.Localizer1.SetWordID(Me, "출력물을 선택해주세요.")
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palTop.ResumeLayout(False)
        Me.palTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents TextBox2 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents TextBox1 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents btnPayment As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnMetting As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palTop As DevExpress.XtraEditors.PanelControl
    Public WithEvents S_MNGT_NO As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents S_PRT_TYPE As YJIT.SC.UI.SCControls.TextBox
End Class
