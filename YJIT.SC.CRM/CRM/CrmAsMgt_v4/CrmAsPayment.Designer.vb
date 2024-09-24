<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrmAsPayment
    Inherits YJIT.SC.UI.SCView

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmAsPayment))
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.GV_PAY_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_PAY_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_PAY_CARD_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_PAY_FARE_LOC_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpAmt = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV_PAY_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_PAY_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_PAY_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_PAY_UPD_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_PAY_UPD_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New YJIT.SC.UI.SCControls.Button()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnDelWg = New YJIT.SC.UI.SCControls.Button()
        Me.btnAddWg = New YJIT.SC.UI.SCControls.Button()
        Me.btnExpWg = New YJIT.SC.UI.SCControls.Button()
        Me.btnQuickFwg = New YJIT.SC.UI.SCControls.Button()
        Me.GV_PAY_CARD_ACCT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG_PAY = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_PAY = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV_PAY_CARD_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_PAY_CARD_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_PAY_CARD_ACCT_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoExEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.rpCRN = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TextBox1 = New YJIT.SC.UI.SCControls.TextBox()
        Me.TextBox2 = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.WG_PAY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_PAY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCRN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.GV_PAY_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV_PAY_SEQ, "순번")
        Me.Localizer1.SetWordID(Me.GV_PAY_CARD_TYPE, "법인/개인")
        Me.Localizer1.SetWordID(Me.GV_PAY_FARE_LOC_AMT, "금액")
        Me.Localizer1.SetWordID(Me.GV_PAY_RMK, "내역")
        Me.Localizer1.SetWordID(Me.GV_PAY_INS_USR, "입력자")
        Me.Localizer1.SetWordID(Me.GV_PAY_INS_YMD, "입력일자")
        Me.Localizer1.SetWordID(Me.GV_PAY_UPD_USR, "수정자")
        Me.Localizer1.SetWordID(Me.GV_PAY_UPD_YMD, "수정일자")
        Me.Localizer1.SetWordID(Me.btnSave, "적용(&S)")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnCancel, "취소(&C)")
        Me.Localizer1.SetWordID(Me.GridColumn28, "")
        Me.Localizer1.SetWordID(Me.btnDelWg, "Button1")
        Me.Localizer1.SetWordID(Me.btnAddWg, "Button1")
        Me.Localizer1.SetWordID(Me.btnExpWg, "Button1")
        Me.Localizer1.SetWordID(Me.btnQuickFwg, "Button1")
        Me.Localizer1.SetWordID(Me.GV_PAY_CARD_ACCT_CD, "적요")
        Me.Localizer1.SetWordID(Me.WG_PAY, "")
        Me.Localizer1.SetWordID(Me.GV_PAY_CARD_CD, "카드코드")
        Me.Localizer1.SetWordID(Me.GV_PAY_CARD_NM, "카드명")
        Me.Localizer1.SetWordID(Me.GV_PAY_CARD_ACCT_NM, "계정과목명")
        Me.Localizer1.SetWordID(Me.TextBox1, "")
        Me.Localizer1.SetWordID(Me.TextBox2, "")
        Me.Localizer1.SetWordID(Me.Label3, "요청사항")
        '
        'GV_PAY_MNGT_NO
        '
        Me.GV_PAY_MNGT_NO.Caption = "관리번호"
        Me.GV_PAY_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV_PAY_MNGT_NO.Name = "GV_PAY_MNGT_NO"
        Me.GV_PAY_MNGT_NO.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV_PAY_MNGT_NO, "관리번호")
        '
        'GV_PAY_SEQ
        '
        Me.GV_PAY_SEQ.Caption = "순번"
        Me.GV_PAY_SEQ.FieldName = "SEQ"
        Me.GV_PAY_SEQ.Name = "GV_PAY_SEQ"
        Me.GV_PAY_SEQ.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV_PAY_SEQ, "순번")
        '
        'GV_PAY_CARD_TYPE
        '
        Me.GV_PAY_CARD_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV_PAY_CARD_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV_PAY_CARD_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV_PAY_CARD_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_PAY_CARD_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV_PAY_CARD_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV_PAY_CARD_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_PAY_CARD_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_PAY_CARD_TYPE.Caption = "법인/개인"
        Me.GV_PAY_CARD_TYPE.FieldName = "CARD_TYPE"
        Me.GV_PAY_CARD_TYPE.Name = "GV_PAY_CARD_TYPE"
        Me.GV_PAY_CARD_TYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_PAY_CARD_TYPE.Visible = True
        Me.GV_PAY_CARD_TYPE.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV_PAY_CARD_TYPE, "법인/개인")
        '
        'GV_PAY_FARE_LOC_AMT
        '
        Me.GV_PAY_FARE_LOC_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV_PAY_FARE_LOC_AMT.AppearanceCell.Options.UseFont = True
        Me.GV_PAY_FARE_LOC_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV_PAY_FARE_LOC_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV_PAY_FARE_LOC_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV_PAY_FARE_LOC_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV_PAY_FARE_LOC_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_PAY_FARE_LOC_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_PAY_FARE_LOC_AMT.Caption = "금액"
        Me.GV_PAY_FARE_LOC_AMT.ColumnEdit = Me.rpAmt
        Me.GV_PAY_FARE_LOC_AMT.FieldName = "FARE_LOC_AMT"
        Me.GV_PAY_FARE_LOC_AMT.Name = "GV_PAY_FARE_LOC_AMT"
        Me.GV_PAY_FARE_LOC_AMT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_PAY_FARE_LOC_AMT.Visible = True
        Me.GV_PAY_FARE_LOC_AMT.VisibleIndex = 1
        Me.GV_PAY_FARE_LOC_AMT.Width = 97
        Me.Localizer1.SetWordID(Me.GV_PAY_FARE_LOC_AMT, "금액")
        '
        'rpAmt
        '
        Me.rpAmt.AutoHeight = False
        Me.rpAmt.Mask.EditMask = "#,###,###,##0;(#,###,###,##0)"
        Me.rpAmt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpAmt.Mask.SaveLiteral = False
        Me.rpAmt.Mask.UseMaskAsDisplayFormat = True
        Me.rpAmt.Name = "rpAmt"
        '
        'GV_PAY_RMK
        '
        Me.GV_PAY_RMK.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV_PAY_RMK.AppearanceCell.Options.UseFont = True
        Me.GV_PAY_RMK.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV_PAY_RMK.AppearanceHeader.Options.UseFont = True
        Me.GV_PAY_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_PAY_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_PAY_RMK.Caption = "내역"
        Me.GV_PAY_RMK.FieldName = "RMK"
        Me.GV_PAY_RMK.Name = "GV_PAY_RMK"
        Me.GV_PAY_RMK.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV_PAY_RMK.Visible = True
        Me.GV_PAY_RMK.VisibleIndex = 2
        Me.GV_PAY_RMK.Width = 240
        Me.Localizer1.SetWordID(Me.GV_PAY_RMK, "내역")
        '
        'GV_PAY_INS_USR
        '
        Me.GV_PAY_INS_USR.Caption = "입력자"
        Me.GV_PAY_INS_USR.FieldName = "INS_USR"
        Me.GV_PAY_INS_USR.Name = "GV_PAY_INS_USR"
        Me.GV_PAY_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV_PAY_INS_USR.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_PAY_INS_USR, "입력자")
        '
        'GV_PAY_INS_YMD
        '
        Me.GV_PAY_INS_YMD.Caption = "입력일자"
        Me.GV_PAY_INS_YMD.FieldName = "INS_YMD"
        Me.GV_PAY_INS_YMD.Name = "GV_PAY_INS_YMD"
        Me.GV_PAY_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV_PAY_INS_YMD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_PAY_INS_YMD, "입력일자")
        '
        'GV_PAY_UPD_USR
        '
        Me.GV_PAY_UPD_USR.Caption = "수정자"
        Me.GV_PAY_UPD_USR.FieldName = "UPD_USR"
        Me.GV_PAY_UPD_USR.Name = "GV_PAY_UPD_USR"
        Me.GV_PAY_UPD_USR.OptionsColumn.AllowEdit = False
        Me.GV_PAY_UPD_USR.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_PAY_UPD_USR, "수정자")
        '
        'GV_PAY_UPD_YMD
        '
        Me.GV_PAY_UPD_YMD.Caption = "수정일자"
        Me.GV_PAY_UPD_YMD.FieldName = "UPD_YMD"
        Me.GV_PAY_UPD_YMD.Name = "GV_PAY_UPD_YMD"
        Me.GV_PAY_UPD_YMD.OptionsColumn.AllowEdit = False
        Me.GV_PAY_UPD_YMD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_PAY_UPD_YMD, "수정일자")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(419, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 72
        Me.btnSave.Text = "적용(&S)"
        Me.Localizer1.SetWordID(Me.btnSave, "적용(&S)")
        '
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.btnCancel)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Location = New System.Drawing.Point(5, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(573, 32)
        Me.palAutoButton.TabIndex = 278
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(495, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 25)
        Me.btnCancel.TabIndex = 73
        Me.btnCancel.Text = "취소(&C)"
        Me.Localizer1.SetWordID(Me.btnCancel, "취소(&C)")
        '
        'GridColumn28
        '
        Me.GridColumn28.Name = "GridColumn28"
        Me.Localizer1.SetWordID(Me.GridColumn28, "")
        '
        'btnDelWg
        '
        Me.btnDelWg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelWg.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDelWg.Image = CType(resources.GetObject("btnDelWg.Image"), System.Drawing.Image)
        Me.btnDelWg.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelWg.Location = New System.Drawing.Point(504, 41)
        Me.btnDelWg.Name = "btnDelWg"
        Me.btnDelWg.Size = New System.Drawing.Size(21, 20)
        Me.btnDelWg.TabIndex = 306
        Me.btnDelWg.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnDelWg, "Button1")
        '
        'btnAddWg
        '
        Me.btnAddWg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddWg.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddWg.Appearance.Options.UseForeColor = True
        Me.btnAddWg.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnAddWg.Image = CType(resources.GetObject("btnAddWg.Image"), System.Drawing.Image)
        Me.btnAddWg.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddWg.Location = New System.Drawing.Point(477, 41)
        Me.btnAddWg.Name = "btnAddWg"
        Me.btnAddWg.Size = New System.Drawing.Size(21, 20)
        Me.btnAddWg.TabIndex = 304
        Me.btnAddWg.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnAddWg, "Button1")
        '
        'btnExpWg
        '
        Me.btnExpWg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpWg.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExpWg.Image = CType(resources.GetObject("btnExpWg.Image"), System.Drawing.Image)
        Me.btnExpWg.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnExpWg.Location = New System.Drawing.Point(531, 41)
        Me.btnExpWg.Name = "btnExpWg"
        Me.btnExpWg.Size = New System.Drawing.Size(21, 20)
        Me.btnExpWg.TabIndex = 303
        Me.btnExpWg.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnExpWg, "Button1")
        '
        'btnQuickFwg
        '
        Me.btnQuickFwg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuickFwg.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnQuickFwg.Image = CType(resources.GetObject("btnQuickFwg.Image"), System.Drawing.Image)
        Me.btnQuickFwg.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnQuickFwg.Location = New System.Drawing.Point(558, 41)
        Me.btnQuickFwg.Name = "btnQuickFwg"
        Me.btnQuickFwg.Size = New System.Drawing.Size(20, 20)
        Me.btnQuickFwg.TabIndex = 305
        Me.btnQuickFwg.Text = "Button1"
        Me.Localizer1.SetWordID(Me.btnQuickFwg, "Button1")
        '
        'GV_PAY_CARD_ACCT_CD
        '
        Me.GV_PAY_CARD_ACCT_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV_PAY_CARD_ACCT_CD.AppearanceCell.Options.UseFont = True
        Me.GV_PAY_CARD_ACCT_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV_PAY_CARD_ACCT_CD.AppearanceHeader.Options.UseFont = True
        Me.GV_PAY_CARD_ACCT_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_PAY_CARD_ACCT_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_PAY_CARD_ACCT_CD.Caption = "적요"
        Me.GV_PAY_CARD_ACCT_CD.FieldName = "CARD_ACCT_CD"
        Me.GV_PAY_CARD_ACCT_CD.Name = "GV_PAY_CARD_ACCT_CD"
        Me.GV_PAY_CARD_ACCT_CD.Visible = True
        Me.GV_PAY_CARD_ACCT_CD.VisibleIndex = 0
        Me.GV_PAY_CARD_ACCT_CD.Width = 120
        Me.Localizer1.SetWordID(Me.GV_PAY_CARD_ACCT_CD, "적요")
        '
        'WG_PAY
        '
        Me.WG_PAY.AllowClientBinding = True
        Me.WG_PAY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_PAY.DeleteRowConfirmation = False
        Me.WG_PAY.DisplayCurrentRow = False
        Me.WG_PAY.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.WG_PAY.IsDataStateAware = True
        Me.WG_PAY.Location = New System.Drawing.Point(5, 64)
        Me.WG_PAY.MainView = Me.GV_PAY
        Me.WG_PAY.Name = "WG_PAY"
        Me.WG_PAY.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoExEdit4, Me.rpAmt, Me.rpCRN})
        Me.WG_PAY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG_PAY.SaveLayout = False
        Me.WG_PAY.Size = New System.Drawing.Size(573, 204)
        Me.WG_PAY.TabIndex = 302
        Me.WG_PAY.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG_PAY.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_PAY})
        '
        'GV_PAY
        '
        Me.GV_PAY.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV_PAY.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV_PAY.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV_PAY_MNGT_NO, Me.GV_PAY_SEQ, Me.GV_PAY_CARD_TYPE, Me.GV_PAY_FARE_LOC_AMT, Me.GV_PAY_CARD_CD, Me.GV_PAY_CARD_NM, Me.GV_PAY_CARD_ACCT_CD, Me.GV_PAY_CARD_ACCT_NM, Me.GV_PAY_RMK, Me.GV_PAY_INS_USR, Me.GV_PAY_INS_YMD, Me.GV_PAY_UPD_USR, Me.GV_PAY_UPD_YMD})
        Me.GV_PAY.GridControl = Me.WG_PAY
        Me.GV_PAY.Name = "GV_PAY"
        Me.GV_PAY.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_PAY.OptionsView.BestFitMaxRowCount = 10
        Me.GV_PAY.OptionsView.ColumnAutoWidth = False
        Me.GV_PAY.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_PAY.OptionsView.ShowGroupPanel = False
        Me.GV_PAY.RowHeight = 10
        Me.GV_PAY.ViewCaption = " 고객지원등록(최근50건)"
        '
        'GV_PAY_CARD_CD
        '
        Me.GV_PAY_CARD_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV_PAY_CARD_CD.AppearanceHeader.Options.UseFont = True
        Me.GV_PAY_CARD_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_PAY_CARD_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_PAY_CARD_CD.Caption = "카드코드"
        Me.GV_PAY_CARD_CD.FieldName = "CARD_CD"
        Me.GV_PAY_CARD_CD.Name = "GV_PAY_CARD_CD"
        Me.GV_PAY_CARD_CD.OptionsColumn.AllowEdit = False
        Me.GV_PAY_CARD_CD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_PAY_CARD_CD, "카드코드")
        '
        'GV_PAY_CARD_NM
        '
        Me.GV_PAY_CARD_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV_PAY_CARD_NM.AppearanceHeader.Options.UseFont = True
        Me.GV_PAY_CARD_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_PAY_CARD_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_PAY_CARD_NM.Caption = "카드명"
        Me.GV_PAY_CARD_NM.FieldName = "CARD_NM"
        Me.GV_PAY_CARD_NM.Name = "GV_PAY_CARD_NM"
        Me.GV_PAY_CARD_NM.OptionsColumn.AllowEdit = False
        Me.GV_PAY_CARD_NM.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_PAY_CARD_NM, "카드명")
        '
        'GV_PAY_CARD_ACCT_NM
        '
        Me.GV_PAY_CARD_ACCT_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV_PAY_CARD_ACCT_NM.AppearanceCell.Options.UseFont = True
        Me.GV_PAY_CARD_ACCT_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV_PAY_CARD_ACCT_NM.AppearanceHeader.Options.UseFont = True
        Me.GV_PAY_CARD_ACCT_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV_PAY_CARD_ACCT_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV_PAY_CARD_ACCT_NM.Caption = "계정과목명"
        Me.GV_PAY_CARD_ACCT_NM.FieldName = "CARD_ACCT_NM"
        Me.GV_PAY_CARD_ACCT_NM.Name = "GV_PAY_CARD_ACCT_NM"
        Me.GV_PAY_CARD_ACCT_NM.OptionsColumn.ShowInCustomizationForm = False
        Me.Localizer1.SetWordID(Me.GV_PAY_CARD_ACCT_NM, "계정과목명")
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit2.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit2.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "N"
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.MaxLength = 200
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemMemoExEdit4
        '
        Me.RepositoryItemMemoExEdit4.AutoHeight = False
        Me.RepositoryItemMemoExEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit4.Name = "RepositoryItemMemoExEdit4"
        Me.RepositoryItemMemoExEdit4.ShowIcon = False
        '
        'rpCRN
        '
        Me.rpCRN.AutoHeight = False
        Me.rpCRN.Mask.EditMask = "000-00-00000"
        Me.rpCRN.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.rpCRN.Mask.SaveLiteral = False
        Me.rpCRN.Mask.UseMaskAsDisplayFormat = True
        Me.rpCRN.Name = "rpCRN"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 14)
        Me.Label3.TabIndex = 307
        Me.Label3.Text = "그리드 변경시 CrmAsMgt_v4 부분도 동일하게 복사해줘야 합니다."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        Me.Localizer1.SetWordID(Me.Label3, "요청사항")
        '
        'imageCollection1
        '
        Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection1.Images.SetKeyName(0, "지결_신규.png")
        Me.imageCollection1.Images.SetKeyName(1, "지결_등록.png")
        Me.imageCollection1.Images.SetKeyName(2, "지결_완료.png")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'CrmAsPayment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(582, 272)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDelWg)
        Me.Controls.Add(Me.btnAddWg)
        Me.Controls.Add(Me.btnExpWg)
        Me.Controls.Add(Me.btnQuickFwg)
        Me.Controls.Add(Me.WG_PAY)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CrmAsPayment"
        Me.Text = "고객지원 비용등록"
        Me.Localizer1.SetWordID(Me, "고객지원 비용등록")
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.WG_PAY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_PAY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCRN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents TextBox2 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents TextBox1 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Public WithEvents WG_PAY As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV_PAY As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV_PAY_CARD_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_PAY_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GV_PAY_FARE_LOC_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemMemoExEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Public WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents imageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents rpAmt As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnDelWg As UI.SCControls.Button
    Friend WithEvents btnAddWg As UI.SCControls.Button
    Friend WithEvents btnExpWg As UI.SCControls.Button
    Friend WithEvents btnQuickFwg As UI.SCControls.Button
    Friend WithEvents GV_PAY_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_PAY_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_PAY_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_PAY_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_PAY_UPD_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_PAY_UPD_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancel As UI.SCControls.Button
    Friend WithEvents rpCRN As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV_PAY_CARD_ACCT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_PAY_CARD_ACCT_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_PAY_CARD_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_PAY_CARD_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As UI.SCControls.Label
End Class
