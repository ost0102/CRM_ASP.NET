<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailView
    Inherits System.Windows.Forms.Form

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
        Me.RMK = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RMK
        '
        Me.RMK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RMK.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RMK.Location = New System.Drawing.Point(0, 0)
        Me.RMK.Name = "RMK"
        Me.RMK.ReadOnly = True
        Me.RMK.Size = New System.Drawing.Size(689, 646)
        Me.RMK.TabIndex = 0
        Me.RMK.Text = ""
        '
        'DetailView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 646)
        Me.Controls.Add(Me.RMK)
        Me.Name = "DetailView"
        Me.Text = "DetailView"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents RMK As System.Windows.Forms.RichTextBox
End Class
