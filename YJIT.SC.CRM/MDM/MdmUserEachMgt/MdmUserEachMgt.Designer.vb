<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdmUserEachMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdmUserEachMgt))
        Me.btn_Save = New YJIT.SC.UI.SCControls.Button()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.USR_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label31 = New YJIT.SC.UI.SCControls.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LBL_EMAIL = New YJIT.SC.UI.SCControls.Label()
        Me.EMAIL = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label12 = New YJIT.SC.UI.SCControls.Label()
        Me.Label11 = New YJIT.SC.UI.SCControls.Label()
        Me.ENG_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.LOC_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.HP_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.PSWD1 = New YJIT.SC.UI.SCControls.TextBox()
        Me.TEL_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label8 = New YJIT.SC.UI.SCControls.Label()
        Me.FAX_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label5 = New YJIT.SC.UI.SCControls.Label()
        Me.PSWD = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btn_Save.Image = CType(resources.GetObject("btn_Save.Image"), System.Drawing.Image)
        Me.btn_Save.Location = New System.Drawing.Point(921, 3)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(70, 25)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btn_Save, "&Save")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btn_Save)
        Me.palAutoButton.Location = New System.Drawing.Point(3, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(998, 32)
        Me.palAutoButton.TabIndex = 4
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btn_Save, "&Save")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.USR_ID, "")
        Me.Localizer1.SetWordID(Me.Label31, "User ID")
        Me.Localizer1.SetWordID(Me.GroupControl2, "Basic Information")
        Me.Localizer1.SetWordID(Me.LBL_EMAIL, "E-mail")
        Me.Localizer1.SetWordID(Me.EMAIL, "")
        Me.Localizer1.SetWordID(Me.Label12, "")
        Me.Localizer1.SetWordID(Me.Label11, "암호는 개인 신상자료(주민등록번호 등)가 포함되지 않아야 합니다.")
        Me.Localizer1.SetWordID(Me.ENG_NM, "")
        Me.Localizer1.SetWordID(Me.Label4, "English Name")
        Me.Localizer1.SetWordID(Me.LOC_NM, "")
        Me.Localizer1.SetWordID(Me.Label1, "Local Name")
        Me.Localizer1.SetWordID(Me.Label6, "Tel No")
        Me.Localizer1.SetWordID(Me.HP_NO, "")
        Me.Localizer1.SetWordID(Me.PSWD1, "")
        Me.Localizer1.SetWordID(Me.TEL_NO, "")
        Me.Localizer1.SetWordID(Me.Label8, "Mobile Phone")
        Me.Localizer1.SetWordID(Me.FAX_NO, "")
        Me.Localizer1.SetWordID(Me.Label5, "Fax No")
        Me.Localizer1.SetWordID(Me.PSWD, "")
        Me.Localizer1.SetWordID(Me.Label7, "Confirm Password")
        Me.Localizer1.SetWordID(Me.Label3, "New Password")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.USR_ID)
        Me.PanelControl1.Controls.Add(Me.Label31)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 43)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(998, 34)
        Me.PanelControl1.TabIndex = 5
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'USR_ID
        '
        Me.USR_ID.BorderColor = System.Drawing.Color.Silver
        Me.USR_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.USR_ID.DefVal = ""
        Me.USR_ID.Enabled = False
        Me.USR_ID.IsDataStateAware = True
        Me.USR_ID.Location = New System.Drawing.Point(111, 6)
        Me.USR_ID.Name = "USR_ID"
        Me.USR_ID.NextFocus = "PSWD"
        Me.USR_ID.ReadOnly = True
        Me.USR_ID.Size = New System.Drawing.Size(103, 22)
        Me.USR_ID.TabIndex = 56
        Me.USR_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label31
        '
        Me.Label31.AutoEllipsis = True
        Me.Label31.LabelFor = Nothing
        Me.Label31.Location = New System.Drawing.Point(29, 6)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(76, 22)
        Me.Label31.TabIndex = 55
        Me.Label31.Text = "User ID"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label31, "User ID")
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LBL_EMAIL)
        Me.GroupControl2.Controls.Add(Me.EMAIL)
        Me.GroupControl2.Controls.Add(Me.Label12)
        Me.GroupControl2.Controls.Add(Me.Label11)
        Me.GroupControl2.Controls.Add(Me.ENG_NM)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.LOC_NM)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.HP_NO)
        Me.GroupControl2.Controls.Add(Me.PSWD1)
        Me.GroupControl2.Controls.Add(Me.TEL_NO)
        Me.GroupControl2.Controls.Add(Me.Label8)
        Me.GroupControl2.Controls.Add(Me.FAX_NO)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.PSWD)
        Me.GroupControl2.Controls.Add(Me.Label7)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 83)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(998, 545)
        Me.GroupControl2.TabIndex = 36
        Me.GroupControl2.Text = "Basic Information"
        Me.Localizer1.SetWordID(Me.GroupControl2, "Basic Information")
        '
        'LBL_EMAIL
        '
        Me.LBL_EMAIL.AutoEllipsis = True
        Me.LBL_EMAIL.LabelFor = Nothing
        Me.LBL_EMAIL.Location = New System.Drawing.Point(124, 221)
        Me.LBL_EMAIL.Name = "LBL_EMAIL"
        Me.LBL_EMAIL.Size = New System.Drawing.Size(51, 22)
        Me.LBL_EMAIL.TabIndex = 190
        Me.LBL_EMAIL.Text = "E-mail"
        Me.LBL_EMAIL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_EMAIL, "E-mail")
        '
        'EMAIL
        '
        Me.EMAIL.BorderColor = System.Drawing.Color.Silver
        Me.EMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EMAIL.DefVal = ""
        Me.EMAIL.IsDataStateAware = True
        Me.EMAIL.Location = New System.Drawing.Point(178, 221)
        Me.EMAIL.MaxLength = 50
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.NextFocus = "MAIN_LOC_BANK"
        Me.EMAIL.Size = New System.Drawing.Size(223, 22)
        Me.EMAIL.TabIndex = 189
        Me.EMAIL.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'Label12
        '
        Me.Label12.AutoEllipsis = True
        Me.Label12.LabelFor = Nothing
        Me.Label12.Location = New System.Drawing.Point(60, 364)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(372, 134)
        Me.Label12.TabIndex = 188
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        Me.Localizer1.SetWordID(Me.Label12, "")
        '
        'Label11
        '
        Me.Label11.AutoEllipsis = True
        Me.Label11.LabelFor = Nothing
        Me.Label11.Location = New System.Drawing.Point(60, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(372, 36)
        Me.Label11.TabIndex = 188
        Me.Label11.Text = "암호는 개인 신상자료(주민등록번호 등)가 포함되지 않아야 합니다."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Localizer1.SetWordID(Me.Label11, "암호는 개인 신상자료(주민등록번호 등)가 포함되지 않아야 합니다.")
        '
        'ENG_NM
        '
        Me.ENG_NM.BorderColor = System.Drawing.Color.Silver
        Me.ENG_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ENG_NM.DefVal = ""
        Me.ENG_NM.IsDataStateAware = True
        Me.ENG_NM.Location = New System.Drawing.Point(178, 60)
        Me.ENG_NM.Name = "ENG_NM"
        Me.ENG_NM.NextFocus = "PSWD"
        Me.ENG_NM.Size = New System.Drawing.Size(223, 22)
        Me.ENG_NM.TabIndex = 180
        Me.ENG_NM.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(34, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 22)
        Me.Label4.TabIndex = 181
        Me.Label4.Text = "English Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label4, "English Name")
        '
        'LOC_NM
        '
        Me.LOC_NM.BorderColor = System.Drawing.Color.Silver
        Me.LOC_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LOC_NM.DefVal = ""
        Me.LOC_NM.IsDataStateAware = True
        Me.LOC_NM.Location = New System.Drawing.Point(178, 33)
        Me.LOC_NM.Name = "LOC_NM"
        Me.LOC_NM.NextFocus = "ENG_NM"
        Me.LOC_NM.Size = New System.Drawing.Size(223, 22)
        Me.LOC_NM.TabIndex = 168
        Me.LOC_NM.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(34, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 22)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Local Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "Local Name")
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(34, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 22)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "Tel No"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label6, "Tel No")
        '
        'HP_NO
        '
        Me.HP_NO.BackColor = System.Drawing.SystemColors.Window
        Me.HP_NO.BorderColor = System.Drawing.Color.Silver
        Me.HP_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HP_NO.DefVal = ""
        Me.HP_NO.IsDataStateAware = True
        Me.HP_NO.Location = New System.Drawing.Point(178, 195)
        Me.HP_NO.Name = "HP_NO"
        Me.HP_NO.NextFocus = "EMAIL"
        Me.HP_NO.Size = New System.Drawing.Size(223, 22)
        Me.HP_NO.TabIndex = 172
        Me.HP_NO.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'PSWD1
        '
        Me.PSWD1.BorderColor = System.Drawing.Color.Silver
        Me.PSWD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSWD1.DefVal = ""
        Me.PSWD1.IsDataStateAware = True
        Me.PSWD1.Location = New System.Drawing.Point(178, 114)
        Me.PSWD1.MaxLength = 10
        Me.PSWD1.Name = "PSWD1"
        Me.PSWD1.NextFocus = "TEL_NO"
        Me.PSWD1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PSWD1.Size = New System.Drawing.Size(223, 22)
        Me.PSWD1.TabIndex = 171
        Me.PSWD1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'TEL_NO
        '
        Me.TEL_NO.BorderColor = System.Drawing.Color.Silver
        Me.TEL_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TEL_NO.DefVal = ""
        Me.TEL_NO.IsDataStateAware = True
        Me.TEL_NO.Location = New System.Drawing.Point(178, 141)
        Me.TEL_NO.Name = "TEL_NO"
        Me.TEL_NO.NextFocus = "FAX_NO"
        Me.TEL_NO.Size = New System.Drawing.Size(223, 22)
        Me.TEL_NO.TabIndex = 170
        Me.TEL_NO.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.LabelFor = Nothing
        Me.Label8.Location = New System.Drawing.Point(34, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 22)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Mobile Phone"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label8, "Mobile Phone")
        '
        'FAX_NO
        '
        Me.FAX_NO.BorderColor = System.Drawing.Color.Silver
        Me.FAX_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FAX_NO.DefVal = ""
        Me.FAX_NO.IsDataStateAware = True
        Me.FAX_NO.Location = New System.Drawing.Point(178, 168)
        Me.FAX_NO.Name = "FAX_NO"
        Me.FAX_NO.NextFocus = "HP_NO"
        Me.FAX_NO.Size = New System.Drawing.Size(223, 22)
        Me.FAX_NO.TabIndex = 169
        Me.FAX_NO.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.LabelFor = Nothing
        Me.Label5.Location = New System.Drawing.Point(34, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 22)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Fax No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label5, "Fax No")
        '
        'PSWD
        '
        Me.PSWD.BorderColor = System.Drawing.Color.Silver
        Me.PSWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSWD.DefVal = ""
        Me.PSWD.IsDataStateAware = True
        Me.PSWD.Location = New System.Drawing.Point(178, 87)
        Me.PSWD.MaxLength = 10
        Me.PSWD.Name = "PSWD"
        Me.PSWD.NextFocus = "PSWD1"
        Me.PSWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PSWD.Size = New System.Drawing.Size(223, 22)
        Me.PSWD.TabIndex = 173
        Me.PSWD.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(34, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 22)
        Me.Label7.TabIndex = 174
        Me.Label7.Text = "Confirm Password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label7, "Confirm Password")
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(34, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 22)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "New Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label3, "New Password")
        '
        'MdmUserEachMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1008, 640)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "MdmUserEachMgt"
        Me.Text = "My Information"
        Me.Localizer1.SetWordID(Me, "My Information")
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Save As YJIT.SC.UI.SCControls.Button
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label31 As YJIT.SC.UI.SCControls.Label
    Public WithEvents USR_ID As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Public WithEvents ENG_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Public WithEvents LOC_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label6 As YJIT.SC.UI.SCControls.Label
    Public WithEvents HP_NO As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents PSWD1 As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents TEL_NO As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label8 As YJIT.SC.UI.SCControls.Label
    Public WithEvents FAX_NO As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label5 As YJIT.SC.UI.SCControls.Label
    Public WithEvents PSWD As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label7 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label11 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents LBL_EMAIL As YJIT.SC.UI.SCControls.Label
    Friend WithEvents EMAIL As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label12 As YJIT.SC.UI.SCControls.Label
End Class
