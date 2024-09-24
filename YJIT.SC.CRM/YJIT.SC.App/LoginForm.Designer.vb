<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits YJIT.SC.UI.SCView
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.USER_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.USER_PWD = New YJIT.SC.UI.SCControls.TextBox()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.chkSaveUser = New System.Windows.Forms.CheckBox()
        Me.lblResult = New YJIT.SC.UI.SCControls.Label()
        Me.picProgress = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chkUseRibbon = New System.Windows.Forms.CheckBox()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.Label5 = New YJIT.SC.UI.SCControls.Label()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        CType(Me.picProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USER_ID
        '
        Me.USER_ID.BorderColor = System.Drawing.Color.Empty
        Me.USER_ID.DefVal = ""
        Me.USER_ID.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USER_ID.IsDataStateAware = True
        Me.USER_ID.Location = New System.Drawing.Point(299, 195)
        Me.USER_ID.MaxLength = 20
        Me.USER_ID.Name = "USER_ID"
        Me.USER_ID.NextFocus = "USER_PWD"
        Me.USER_ID.RequiredFor = ""
        Me.USER_ID.Size = New System.Drawing.Size(102, 20)
        Me.USER_ID.TabIndex = 1
        Me.USER_ID.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'USER_PWD
        '
        Me.USER_PWD.BorderColor = System.Drawing.Color.Empty
        Me.USER_PWD.DefVal = ""
        Me.USER_PWD.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USER_PWD.IsDataStateAware = True
        Me.USER_PWD.Location = New System.Drawing.Point(299, 218)
        Me.USER_PWD.MaxLength = 50
        Me.USER_PWD.Name = "USER_PWD"
        Me.USER_PWD.NextFocus = "btnLogin"
        Me.USER_PWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.USER_PWD.RequiredFor = ""
        Me.USER_PWD.Size = New System.Drawing.Size(102, 20)
        Me.USER_PWD.TabIndex = 1
        Me.USER_PWD.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'lblExit
        '
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Image = CType(resources.GetObject("lblExit.Image"), System.Drawing.Image)
        Me.lblExit.Location = New System.Drawing.Point(420, 9)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(30, 22)
        Me.lblExit.TabIndex = 4
        Me.Localizer1.SetWordID(Me.lblExit, "")
        '
        'chkSaveUser
        '
        Me.chkSaveUser.AutoSize = True
        Me.chkSaveUser.BackColor = System.Drawing.Color.Transparent
        Me.chkSaveUser.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.chkSaveUser.ForeColor = System.Drawing.Color.Silver
        Me.chkSaveUser.Location = New System.Drawing.Point(350, 166)
        Me.chkSaveUser.Name = "chkSaveUser"
        Me.chkSaveUser.Size = New System.Drawing.Size(94, 17)
        Me.chkSaveUser.TabIndex = 5
        Me.chkSaveUser.Text = "Remember me"
        Me.chkSaveUser.UseVisualStyleBackColor = False
        Me.Localizer1.SetWordID(Me.chkSaveUser, "Remember me")
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.ForeColor = System.Drawing.Color.Red
        Me.lblResult.LabelFor = Nothing
        Me.lblResult.Location = New System.Drawing.Point(7, 195)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(229, 55)
        Me.lblResult.TabIndex = 2
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Localizer1.SetWordID(Me.lblResult, "")
        '
        'picProgress
        '
        Me.picProgress.BackColor = System.Drawing.Color.Transparent
        Me.picProgress.Image = CType(resources.GetObject("picProgress.Image"), System.Drawing.Image)
        Me.picProgress.Location = New System.Drawing.Point(299, 245)
        Me.picProgress.Name = "picProgress"
        Me.picProgress.Size = New System.Drawing.Size(117, 9)
        Me.picProgress.TabIndex = 7
        Me.picProgress.TabStop = False
        Me.picProgress.Visible = False
        Me.Localizer1.SetWordID(Me.picProgress, "")
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(401, 195)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(55, 47)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.UseVisualStyleBackColor = False
        Me.Localizer1.SetWordID(Me.btnLogin, "")
        '
        'chkUseRibbon
        '
        Me.chkUseRibbon.AutoSize = True
        Me.chkUseRibbon.BackColor = System.Drawing.Color.Transparent
        Me.chkUseRibbon.Location = New System.Drawing.Point(203, 166)
        Me.chkUseRibbon.Name = "chkUseRibbon"
        Me.chkUseRibbon.Size = New System.Drawing.Size(141, 18)
        Me.chkUseRibbon.TabIndex = 5
        Me.chkUseRibbon.Text = "Use Ribbon Interface"
        Me.chkUseRibbon.UseVisualStyleBackColor = False
        Me.chkUseRibbon.Visible = False
        Me.Localizer1.SetWordID(Me.chkUseRibbon, "Use Ribbon Interface")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(228, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Domain"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "Domain")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(223, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "ID")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(223, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label3, "Password")
        '
        'picBackground
        '
        Me.picBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(460, 262)
        Me.picBackground.TabIndex = 6
        Me.picBackground.TabStop = False
        Me.Localizer1.SetWordID(Me.picBackground, "")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.USER_ID, "")
        Me.Localizer1.SetWordID(Me.USER_PWD, "")
        Me.Localizer1.SetWordID(Me.lblExit, "")
        Me.Localizer1.SetWordID(Me.chkSaveUser, "Remember me")
        Me.Localizer1.SetWordID(Me.lblResult, "")
        Me.Localizer1.SetWordID(Me.picProgress, "")
        Me.Localizer1.SetWordID(Me.btnLogin, "")
        Me.Localizer1.SetWordID(Me.chkUseRibbon, "Use Ribbon Interface")
        Me.Localizer1.SetWordID(Me.Label1, "Domain")
        Me.Localizer1.SetWordID(Me.Label2, "ID")
        Me.Localizer1.SetWordID(Me.Label3, "Password")
        Me.Localizer1.SetWordID(Me.picBackground, "")
        Me.Localizer1.SetWordID(Me.Label4, "Customer")
        Me.Localizer1.SetWordID(Me.Label5, "Relationship")
        Me.Localizer1.SetWordID(Me.Label6, "Management")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(18, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 31)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Customer"
        Me.Localizer1.SetWordID(Me.Label4, "")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.LabelFor = Nothing
        Me.Label5.Location = New System.Drawing.Point(18, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 31)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Relationship"
        Me.Localizer1.SetWordID(Me.Label5, "")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(18, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 31)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Management"
        Me.Localizer1.SetWordID(Me.Label6, "")
        '
        'LoginForm
        '
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = CType(resources.GetObject("$this.BackgroundImageStore"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(460, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkUseRibbon)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.picProgress)
        Me.Controls.Add(Me.chkSaveUser)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.USER_PWD)
        Me.Controls.Add(Me.USER_ID)
        Me.Controls.Add(Me.picBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Authentication"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.picProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents USER_ID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents USER_PWD As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents chkSaveUser As System.Windows.Forms.CheckBox
    Friend WithEvents lblResult As YJIT.SC.UI.SCControls.Label
    Friend WithEvents picProgress As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents chkUseRibbon As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents picBackground As System.Windows.Forms.PictureBox
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label5 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label6 As YJIT.SC.UI.SCControls.Label
End Class
