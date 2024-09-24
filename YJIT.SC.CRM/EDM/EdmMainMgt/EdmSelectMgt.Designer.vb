<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EdmSelectMgt
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EdmSelectMgt))
        Me.RepositoryItemDateBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.iconImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.TextLabel1 = New YJIT.SC.UI.SCControls.TextLabel()
        Me.ImgThumbnail1 = New AxThumbnailLibCtl.AxImgThumbnail()
        Me.ImgEdit1 = New AxImgeditLibCtl.AxImgEdit()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ImgThumbnail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemDateBoxEdit1
        '
        Me.RepositoryItemDateBoxEdit1.AutoHeight = False
        Me.RepositoryItemDateBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateBoxEdit1.LookAndFeel.SkinName = "Blue"
        Me.RepositoryItemDateBoxEdit1.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemDateBoxEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemDateBoxEdit1.Mask.SaveLiteral = False
        Me.RepositoryItemDateBoxEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateBoxEdit1.Name = "RepositoryItemDateBoxEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "##:##"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.TextLabel1)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 7)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1059, 32)
        Me.palAutoButton.TabIndex = 2
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "순번"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GridColumn1, "순번")
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "사이트명"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GridColumn2, "사이트명")
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "거래처유형"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처유형")
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "담당자"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GridColumn4, "담당자")
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "전화"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GridColumn5, "전화")
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "DB IP"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GridColumn6, "DB IP")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.GridColumn1, "순번")
        Me.Localizer1.SetWordID(Me.GridColumn2, "사이트명")
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처유형")
        Me.Localizer1.SetWordID(Me.GridColumn4, "담당자")
        Me.Localizer1.SetWordID(Me.GridColumn5, "전화")
        Me.Localizer1.SetWordID(Me.GridColumn6, "DB IP")
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.btnSave, "Send")
        Me.Localizer1.SetWordID(Me.ImgThumbnail1, "")
        Me.Localizer1.SetWordID(Me.ImgEdit1, "")
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.ImgThumbnail1)
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(209, 676)
        Me.PanelControl3.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl5.Controls.Add(Me.ImgEdit1)
        Me.PanelControl5.Location = New System.Drawing.Point(3, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(840, 676)
        Me.PanelControl5.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        '
        'iconImages
        '
        Me.iconImages.ImageStream = CType(resources.GetObject("iconImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.iconImages.Images.SetKeyName(0, "aligncenter.png")
        Me.iconImages.Images.SetKeyName(1, "alignleft.png")
        Me.iconImages.Images.SetKeyName(2, "alignright.png")
        Me.iconImages.Images.SetKeyName(3, "redo.png")
        Me.iconImages.Images.SetKeyName(4, "select.png")
        Me.iconImages.Images.SetKeyName(5, "undo.png")
        Me.iconImages.Images.SetKeyName(6, "colorchooser.png")
        Me.iconImages.Images.SetKeyName(7, "backcolor.png")
        Me.iconImages.Images.SetKeyName(8, "forecolor.png")
        Me.iconImages.Images.SetKeyName(9, "bulleting.png")
        Me.iconImages.Images.SetKeyName(10, "numbering.png")
        Me.iconImages.Images.SetKeyName(11, "indentdec.png")
        Me.iconImages.Images.SetKeyName(12, "indentinc.png")
        Me.iconImages.Images.SetKeyName(13, "hyperlinkins.png")
        Me.iconImages.Images.SetKeyName(14, "imageins.png")
        Me.iconImages.Images.SetKeyName(15, "table.png")
        Me.iconImages.Images.SetKeyName(16, "Save.png")
        Me.iconImages.Images.SetKeyName(17, "Delete.png")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Location = New System.Drawing.Point(6, 45)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl3)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl5)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1059, 676)
        Me.SplitContainerControl1.SplitterPosition = 211
        Me.SplitContainerControl1.TabIndex = 8
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.SplitContainerControl1, "")
        '
        'btnSave
        '
        Me.btnSave.Action = "SaveData"
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(966, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 25)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Send"
        Me.Localizer1.SetWordID(Me.btnSave, "Send")
        '
        'TextLabel1
        '
        Me.TextLabel1.AutoEllipsis = True
        Me.TextLabel1.BorderColor = System.Drawing.Color.Empty
        Me.TextLabel1.LabelFor = Nothing
        Me.TextLabel1.Location = New System.Drawing.Point(499, 4)
        Me.TextLabel1.Name = "TextLabel1"
        Me.TextLabel1.Size = New System.Drawing.Size(461, 25)
        Me.TextLabel1.TabIndex = 9
        Me.TextLabel1.Text = "Fax로 전송할 이미지를 선택해주세요. (마우스 오른쪽 버튼사용)"
        Me.TextLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImgThumbnail1
        '
        Me.ImgThumbnail1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgThumbnail1.Location = New System.Drawing.Point(5, 5)
        Me.ImgThumbnail1.Name = "ImgThumbnail1"
        Me.ImgThumbnail1.OcxState = CType(resources.GetObject("ImgThumbnail1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ImgThumbnail1.Size = New System.Drawing.Size(199, 666)
        Me.ImgThumbnail1.TabIndex = 10
        Me.Localizer1.SetWordID(Me.ImgThumbnail1, "")
        '
        'ImgEdit1
        '
        Me.ImgEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgEdit1.Location = New System.Drawing.Point(5, 4)
        Me.ImgEdit1.Name = "ImgEdit1"
        Me.ImgEdit1.OcxState = CType(resources.GetObject("ImgEdit1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ImgEdit1.Size = New System.Drawing.Size(830, 667)
        Me.ImgEdit1.TabIndex = 9
        Me.Localizer1.SetWordID(Me.ImgEdit1, "")
        '
        'EdmMrg01M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 726)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "EdmMrg01M"
        Me.Text = "Send Fax"
        Me.Localizer1.SetWordID(Me, "Send Fax")
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ImgThumbnail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents iconImages As DevExpress.Utils.ImageCollection
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RepositoryItemDateBoxEdit1 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ImgThumbnail1 As AxThumbnailLibCtl.AxImgThumbnail
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ImgEdit1 As AxImgeditLibCtl.AxImgEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents TextLabel1 As YJIT.SC.UI.SCControls.TextLabel
End Class
