<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysHelpUpload
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
        Me.btnCreate = New YJIT.SC.UI.SCControls.Button()
        Me.pbMain = New System.Windows.Forms.ProgressBar()
        Me.lblTotalResult = New YJIT.SC.UI.SCControls.Label()
        Me.txtInfo = New YJIT.SC.UI.SCControls.TextBox()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Action = ""
        Me.btnCreate.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnCreate.Enabled = False
        Me.btnCreate.Location = New System.Drawing.Point(107, 141)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(77, 23)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Ok"
        '
        'pbMain
        '
        Me.pbMain.Location = New System.Drawing.Point(10, 73)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(303, 23)
        Me.pbMain.TabIndex = 3
        '
        'lblTotalResult
        '
        Me.lblTotalResult.AutoSize = True
        Me.lblTotalResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalResult.LabelFor = Nothing
        Me.lblTotalResult.Location = New System.Drawing.Point(87, 112)
        Me.lblTotalResult.Name = "lblTotalResult"
        Me.lblTotalResult.Size = New System.Drawing.Size(130, 14)
        Me.lblTotalResult.TabIndex = 5
        Me.lblTotalResult.Text = "Uploaded Successfully!"
        Me.lblTotalResult.Visible = False
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.Color.AliceBlue
        Me.txtInfo.BorderColor = System.Drawing.Color.White
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfo.DefVal = ""
        Me.txtInfo.IsDataStateAware = True
        Me.txtInfo.Location = New System.Drawing.Point(12, 12)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.NextFocus = Nothing
        Me.txtInfo.RequiredFor = ""
        Me.txtInfo.Size = New System.Drawing.Size(301, 49)
        Me.txtInfo.TabIndex = 7
        Me.txtInfo.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'SysHelpUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 173)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.lblTotalResult)
        Me.Controls.Add(Me.pbMain)
        Me.Controls.Add(Me.btnCreate)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SysHelpUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Upload to Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreate As YJIT.SC.UI.SCControls.Button
    Friend WithEvents pbMain As System.Windows.Forms.ProgressBar
    Friend WithEvents lblTotalResult As YJIT.SC.UI.SCControls.Label
    Friend WithEvents txtInfo As YJIT.SC.UI.SCControls.TextBox
End Class
