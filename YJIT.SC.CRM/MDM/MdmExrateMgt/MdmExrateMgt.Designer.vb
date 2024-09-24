<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdmExrateMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdmExrateMgt))
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.lbl_COPY_EXRT = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_DASH = New YJIT.SC.UI.SCControls.Label()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.ABGV1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.Currency = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Code = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ABGV1_CURR_CD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Unit = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ABGV1_CURR_UNIT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Cash = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Buying = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ABGV1_CASH_BUYRT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Selling = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ABGV1_CASH_SELLRT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TelegraphicTransfer = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Sending = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ABGV1_WIRE_SEND_EXRT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Receiving = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ABGV1_WIRE_RECV_EXRT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Standard = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ABGV1_EXCH_BASERT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ABGV1_USD_CONV_RT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Remark = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.ABGV1_RMK = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.EX_DATE = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.FILE_PATH = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnDelete = New YJIT.SC.UI.SCControls.Button()
        Me.btnFileUpload = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.btnCopyExchangeRate = New YJIT.SC.UI.SCControls.Button()
        Me.TO_DATE = New YJIT.SC.UI.SCControls.DateBox()
        Me.FROM_DATE = New YJIT.SC.UI.SCControls.DateBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Button1 = New YJIT.SC.UI.SCControls.Button()
        Me.S_EXRT_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.lbl_S_EXRT_YMD = New YJIT.SC.UI.SCControls.Label()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ABGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.LookAndFeel.SkinName = "Blue"
        Me.RepositoryItemTextEdit1.MaxLength = 10
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 100
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.MaxLength = 4
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.MaxLength = 200
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'lbl_COPY_EXRT
        '
        Me.lbl_COPY_EXRT.AutoEllipsis = True
        Me.lbl_COPY_EXRT.LabelFor = Nothing
        Me.lbl_COPY_EXRT.Location = New System.Drawing.Point(531, 6)
        Me.lbl_COPY_EXRT.Name = "lbl_COPY_EXRT"
        Me.lbl_COPY_EXRT.Size = New System.Drawing.Size(130, 22)
        Me.lbl_COPY_EXRT.TabIndex = 5
        Me.lbl_COPY_EXRT.Text = "Copy Exchange Rate"
        Me.lbl_COPY_EXRT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_COPY_EXRT, "Copy Exchange Rate")
        '
        'lbl_DASH
        '
        Me.lbl_DASH.AutoEllipsis = True
        Me.lbl_DASH.LabelFor = Nothing
        Me.lbl_DASH.Location = New System.Drawing.Point(766, 6)
        Me.lbl_DASH.Name = "lbl_DASH"
        Me.lbl_DASH.Size = New System.Drawing.Size(25, 20)
        Me.lbl_DASH.TabIndex = 3
        Me.lbl_DASH.Text = "~"
        Me.lbl_DASH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Localizer1.SetWordID(Me.lbl_DASH, "~")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = False
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.EmbeddedNavigator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(6, 37)
        Me.WG1.MainView = Me.ABGV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit8, Me.RepositoryItemTextEdit9, Me.RepositoryItemTextEdit10, Me.RepositoryItemTextEdit11, Me.RepositoryItemTextEdit12})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(996, 556)
        Me.WG1.TabIndex = 2
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ABGV1})
        '
        'ABGV1
        '
        Me.ABGV1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.Currency, Me.Cash, Me.TelegraphicTransfer, Me.Standard, Me.GridBand1, Me.Remark})
        Me.ABGV1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.ABGV1_CURR_CD, Me.ABGV1_CURR_UNIT, Me.ABGV1_CASH_BUYRT, Me.ABGV1_CASH_SELLRT, Me.ABGV1_WIRE_SEND_EXRT, Me.ABGV1_WIRE_RECV_EXRT, Me.ABGV1_EXCH_BASERT, Me.ABGV1_USD_CONV_RT, Me.ABGV1_RMK})
        Me.ABGV1.GridControl = Me.WG1
        Me.ABGV1.IndicatorWidth = 40
        Me.ABGV1.Name = "ABGV1"
        Me.ABGV1.NewItemRowText = "Click here to add a new row"
        Me.ABGV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp
        Me.ABGV1.OptionsCustomization.AllowColumnMoving = False
        Me.ABGV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.ABGV1.OptionsPrint.ExpandAllGroups = False
        Me.ABGV1.OptionsPrint.PrintBandHeader = False
        Me.ABGV1.OptionsPrint.PrintFooter = False
        Me.ABGV1.OptionsPrint.PrintGroupFooter = False
        Me.ABGV1.OptionsView.ShowColumnHeaders = False
        Me.ABGV1.OptionsView.ShowFooter = True
        Me.ABGV1.OptionsView.ShowGroupPanel = False
        Me.ABGV1.OptionsView.ShowHorzLines = False
        '
        'Currency
        '
        Me.Currency.AppearanceHeader.Options.UseTextOptions = True
        Me.Currency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Currency.Caption = "통화코드"
        Me.Currency.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.Code, Me.Unit})
        Me.Currency.Name = "Currency"
        Me.Currency.Width = 160
        Me.Localizer1.SetWordID(Me.Currency, "통화코드")
        '
        'Code
        '
        Me.Code.AppearanceHeader.Options.UseTextOptions = True
        Me.Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Code.Caption = "Code"
        Me.Code.Columns.Add(Me.ABGV1_CURR_CD)
        Me.Code.Name = "Code"
        Me.Code.Width = 80
        Me.Localizer1.SetWordID(Me.Code, "Code")
        '
        'ABGV1_CURR_CD
        '
        Me.ABGV1_CURR_CD.AppearanceCell.Options.UseTextOptions = True
        Me.ABGV1_CURR_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ABGV1_CURR_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.ABGV1_CURR_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABGV1_CURR_CD.Caption = "Currency Code"
        Me.ABGV1_CURR_CD.FieldName = "CURR_CD"
        Me.ABGV1_CURR_CD.Name = "ABGV1_CURR_CD"
        Me.ABGV1_CURR_CD.Visible = True
        Me.ABGV1_CURR_CD.Width = 80
        Me.Localizer1.SetWordID(Me.ABGV1_CURR_CD, "Currency Code")
        '
        'Unit
        '
        Me.Unit.AppearanceHeader.Options.UseTextOptions = True
        Me.Unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Unit.Caption = "Unit"
        Me.Unit.Columns.Add(Me.ABGV1_CURR_UNIT)
        Me.Unit.Name = "Unit"
        Me.Unit.Width = 80
        Me.Localizer1.SetWordID(Me.Unit, "Unit")
        '
        'ABGV1_CURR_UNIT
        '
        Me.ABGV1_CURR_UNIT.AppearanceCell.Options.UseTextOptions = True
        Me.ABGV1_CURR_UNIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ABGV1_CURR_UNIT.AppearanceHeader.Options.UseTextOptions = True
        Me.ABGV1_CURR_UNIT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABGV1_CURR_UNIT.Caption = "Unit"
        Me.ABGV1_CURR_UNIT.FieldName = "CURR_UNIT"
        Me.ABGV1_CURR_UNIT.Name = "ABGV1_CURR_UNIT"
        Me.ABGV1_CURR_UNIT.Visible = True
        Me.ABGV1_CURR_UNIT.Width = 80
        Me.Localizer1.SetWordID(Me.ABGV1_CURR_UNIT, "Unit")
        '
        'Cash
        '
        Me.Cash.AppearanceHeader.Options.UseTextOptions = True
        Me.Cash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cash.Caption = "현찰"
        Me.Cash.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.Buying, Me.Selling})
        Me.Cash.Name = "Cash"
        Me.Cash.Width = 200
        Me.Localizer1.SetWordID(Me.Cash, "현찰")
        '
        'Buying
        '
        Me.Buying.AppearanceHeader.Options.UseTextOptions = True
        Me.Buying.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Buying.Caption = "사실때"
        Me.Buying.Columns.Add(Me.ABGV1_CASH_BUYRT)
        Me.Buying.Name = "Buying"
        Me.Buying.ToolTip = "현찰 사실때"
        Me.Buying.Width = 100
        Me.Localizer1.SetWordID(Me.Buying, "사실때")
        '
        'ABGV1_CASH_BUYRT
        '
        Me.ABGV1_CASH_BUYRT.AppearanceCell.Options.UseTextOptions = True
        Me.ABGV1_CASH_BUYRT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ABGV1_CASH_BUYRT.AppearanceHeader.Options.UseTextOptions = True
        Me.ABGV1_CASH_BUYRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABGV1_CASH_BUYRT.Caption = "Cash Buying"
        Me.ABGV1_CASH_BUYRT.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.ABGV1_CASH_BUYRT.FieldName = "CASH_BUYRT"
        Me.ABGV1_CASH_BUYRT.Name = "ABGV1_CASH_BUYRT"
        Me.ABGV1_CASH_BUYRT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CASH_BUYRT", "{0:n2}")})
        Me.ABGV1_CASH_BUYRT.Visible = True
        Me.ABGV1_CASH_BUYRT.Width = 100
        Me.Localizer1.SetWordID(Me.ABGV1_CASH_BUYRT, "Cash Buying")
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "###,###,##0.00"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'Selling
        '
        Me.Selling.AppearanceHeader.Options.UseTextOptions = True
        Me.Selling.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Selling.Caption = "파실때"
        Me.Selling.Columns.Add(Me.ABGV1_CASH_SELLRT)
        Me.Selling.Name = "Selling"
        Me.Selling.ToolTip = "현찰 파실때"
        Me.Selling.Width = 100
        Me.Localizer1.SetWordID(Me.Selling, "파실때")
        '
        'ABGV1_CASH_SELLRT
        '
        Me.ABGV1_CASH_SELLRT.AppearanceCell.Options.UseTextOptions = True
        Me.ABGV1_CASH_SELLRT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ABGV1_CASH_SELLRT.AppearanceHeader.Options.UseTextOptions = True
        Me.ABGV1_CASH_SELLRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABGV1_CASH_SELLRT.Caption = "Cash Selling"
        Me.ABGV1_CASH_SELLRT.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.ABGV1_CASH_SELLRT.FieldName = "CASH_SELLRT"
        Me.ABGV1_CASH_SELLRT.Name = "ABGV1_CASH_SELLRT"
        Me.ABGV1_CASH_SELLRT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CASH_SELLRT", "{0:n2}")})
        Me.ABGV1_CASH_SELLRT.Visible = True
        Me.ABGV1_CASH_SELLRT.Width = 100
        Me.Localizer1.SetWordID(Me.ABGV1_CASH_SELLRT, "Cash Selling")
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "###,###,##0.00"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'TelegraphicTransfer
        '
        Me.TelegraphicTransfer.AppearanceHeader.Options.UseTextOptions = True
        Me.TelegraphicTransfer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TelegraphicTransfer.Caption = "송금"
        Me.TelegraphicTransfer.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.Sending, Me.Receiving})
        Me.TelegraphicTransfer.Name = "TelegraphicTransfer"
        Me.TelegraphicTransfer.Width = 200
        Me.Localizer1.SetWordID(Me.TelegraphicTransfer, "송금")
        '
        'Sending
        '
        Me.Sending.AppearanceHeader.Options.UseTextOptions = True
        Me.Sending.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Sending.Caption = "보내실때"
        Me.Sending.Columns.Add(Me.ABGV1_WIRE_SEND_EXRT)
        Me.Sending.Name = "Sending"
        Me.Sending.ToolTip = "송금 전신환 보내실때"
        Me.Sending.Width = 100
        Me.Localizer1.SetWordID(Me.Sending, "보내실때")
        '
        'ABGV1_WIRE_SEND_EXRT
        '
        Me.ABGV1_WIRE_SEND_EXRT.AppearanceCell.Options.UseTextOptions = True
        Me.ABGV1_WIRE_SEND_EXRT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ABGV1_WIRE_SEND_EXRT.AppearanceHeader.Options.UseTextOptions = True
        Me.ABGV1_WIRE_SEND_EXRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABGV1_WIRE_SEND_EXRT.Caption = "Telegraphic Transfer Sending"
        Me.ABGV1_WIRE_SEND_EXRT.ColumnEdit = Me.RepositoryItemTextEdit11
        Me.ABGV1_WIRE_SEND_EXRT.FieldName = "WIRE_SEND_EXRT"
        Me.ABGV1_WIRE_SEND_EXRT.Name = "ABGV1_WIRE_SEND_EXRT"
        Me.ABGV1_WIRE_SEND_EXRT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WIRE_SEND_EXRT", "{0:n2}")})
        Me.ABGV1_WIRE_SEND_EXRT.Visible = True
        Me.ABGV1_WIRE_SEND_EXRT.Width = 100
        Me.Localizer1.SetWordID(Me.ABGV1_WIRE_SEND_EXRT, "Telegraphic Transfer Sending")
        '
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.AutoHeight = False
        Me.RepositoryItemTextEdit11.Mask.EditMask = "###,###,##0.00"
        Me.RepositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit11.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        '
        'Receiving
        '
        Me.Receiving.AppearanceHeader.Options.UseTextOptions = True
        Me.Receiving.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Receiving.Caption = "받으실때"
        Me.Receiving.Columns.Add(Me.ABGV1_WIRE_RECV_EXRT)
        Me.Receiving.Name = "Receiving"
        Me.Receiving.ToolTip = "송금 전신환 받으실때"
        Me.Receiving.Width = 100
        Me.Localizer1.SetWordID(Me.Receiving, "받으실때")
        '
        'ABGV1_WIRE_RECV_EXRT
        '
        Me.ABGV1_WIRE_RECV_EXRT.AppearanceCell.Options.UseTextOptions = True
        Me.ABGV1_WIRE_RECV_EXRT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ABGV1_WIRE_RECV_EXRT.AppearanceHeader.Options.UseTextOptions = True
        Me.ABGV1_WIRE_RECV_EXRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABGV1_WIRE_RECV_EXRT.Caption = "Telegraphic Transfer Receiving"
        Me.ABGV1_WIRE_RECV_EXRT.ColumnEdit = Me.RepositoryItemTextEdit12
        Me.ABGV1_WIRE_RECV_EXRT.FieldName = "WIRE_RECV_EXRT"
        Me.ABGV1_WIRE_RECV_EXRT.Name = "ABGV1_WIRE_RECV_EXRT"
        Me.ABGV1_WIRE_RECV_EXRT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WIRE_RECV_EXRT", "{0:n2}")})
        Me.ABGV1_WIRE_RECV_EXRT.Visible = True
        Me.ABGV1_WIRE_RECV_EXRT.Width = 100
        Me.Localizer1.SetWordID(Me.ABGV1_WIRE_RECV_EXRT, "Telegraphic Transfer Receiving")
        '
        'RepositoryItemTextEdit12
        '
        Me.RepositoryItemTextEdit12.AutoHeight = False
        Me.RepositoryItemTextEdit12.Mask.EditMask = "###,###,##0.00"
        Me.RepositoryItemTextEdit12.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit12.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit12.Name = "RepositoryItemTextEdit12"
        '
        'Standard
        '
        Me.Standard.AppearanceHeader.Options.UseTextOptions = True
        Me.Standard.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Standard.Caption = "매매기준율"
        Me.Standard.Columns.Add(Me.ABGV1_EXCH_BASERT)
        Me.Standard.Name = "Standard"
        Me.Standard.ToolTip = "매매 기준율"
        Me.Standard.Width = 100
        Me.Localizer1.SetWordID(Me.Standard, "매매기준율")
        '
        'ABGV1_EXCH_BASERT
        '
        Me.ABGV1_EXCH_BASERT.AppearanceCell.Options.UseTextOptions = True
        Me.ABGV1_EXCH_BASERT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ABGV1_EXCH_BASERT.AppearanceHeader.Options.UseTextOptions = True
        Me.ABGV1_EXCH_BASERT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABGV1_EXCH_BASERT.Caption = "Standard"
        Me.ABGV1_EXCH_BASERT.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.ABGV1_EXCH_BASERT.FieldName = "EXCH_BASERT"
        Me.ABGV1_EXCH_BASERT.Name = "ABGV1_EXCH_BASERT"
        Me.ABGV1_EXCH_BASERT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EXCH_BASERT", "{0:n2}")})
        Me.ABGV1_EXCH_BASERT.Visible = True
        Me.ABGV1_EXCH_BASERT.Width = 100
        Me.Localizer1.SetWordID(Me.ABGV1_EXCH_BASERT, "Standard")
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "미화 환산율"
        Me.GridBand1.Columns.Add(Me.ABGV1_USD_CONV_RT)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.ToolTip = "미화 환산율"
        Me.GridBand1.Width = 116
        Me.Localizer1.SetWordID(Me.GridBand1, "미화 환산율")
        '
        'ABGV1_USD_CONV_RT
        '
        Me.ABGV1_USD_CONV_RT.AppearanceCell.Options.UseTextOptions = True
        Me.ABGV1_USD_CONV_RT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ABGV1_USD_CONV_RT.AppearanceHeader.Options.UseTextOptions = True
        Me.ABGV1_USD_CONV_RT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABGV1_USD_CONV_RT.Caption = "US$ Convert"
        Me.ABGV1_USD_CONV_RT.ColumnEdit = Me.RepositoryItemTextEdit10
        Me.ABGV1_USD_CONV_RT.FieldName = "USD_CONV_RT"
        Me.ABGV1_USD_CONV_RT.Name = "ABGV1_USD_CONV_RT"
        Me.ABGV1_USD_CONV_RT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "USD_CONV_RT", "{0:n4}")})
        Me.ABGV1_USD_CONV_RT.Visible = True
        Me.ABGV1_USD_CONV_RT.Width = 116
        Me.Localizer1.SetWordID(Me.ABGV1_USD_CONV_RT, "US$ Convert")
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.AutoHeight = False
        Me.RepositoryItemTextEdit10.Mask.EditMask = "###,###,##0.0000"
        Me.RepositoryItemTextEdit10.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit10.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'Remark
        '
        Me.Remark.AppearanceHeader.Options.UseTextOptions = True
        Me.Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Remark.Caption = "Remark"
        Me.Remark.Columns.Add(Me.ABGV1_RMK)
        Me.Remark.Name = "Remark"
        Me.Remark.Width = 150
        Me.Localizer1.SetWordID(Me.Remark, "Remark")
        '
        'ABGV1_RMK
        '
        Me.ABGV1_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.ABGV1_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABGV1_RMK.Caption = "Remark"
        Me.ABGV1_RMK.FieldName = "RMK"
        Me.ABGV1_RMK.Name = "ABGV1_RMK"
        Me.ABGV1_RMK.Visible = True
        Me.ABGV1_RMK.Width = 150
        Me.Localizer1.SetWordID(Me.ABGV1_RMK, "Remark")
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "###,###,##0.0000"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "###,###,##0.0000"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.EX_DATE)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.FILE_PATH)
        Me.palAutoButton.Controls.Add(Me.btnDelete)
        Me.palAutoButton.Controls.Add(Me.btnFileUpload)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(996, 31)
        Me.palAutoButton.TabIndex = 1
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'EX_DATE
        '
        Me.EX_DATE.BorderColor = System.Drawing.Color.Silver
        Me.EX_DATE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EX_DATE.DefVal = ""
        Me.EX_DATE.IsDataStateAware = True
        Me.EX_DATE.Location = New System.Drawing.Point(412, 6)
        Me.EX_DATE.Name = "EX_DATE"
        Me.EX_DATE.NextFocus = Nothing
        Me.EX_DATE.RequiredFor = ""
        Me.EX_DATE.Size = New System.Drawing.Size(116, 22)
        Me.EX_DATE.TabIndex = 28
        Me.EX_DATE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.EX_DATE.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Action = "SaveData"
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(833, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'FILE_PATH
        '
        Me.FILE_PATH.BorderColor = System.Drawing.Color.Silver
        Me.FILE_PATH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FILE_PATH.DefVal = ""
        Me.FILE_PATH.IsDataStateAware = True
        Me.FILE_PATH.Location = New System.Drawing.Point(534, 5)
        Me.FILE_PATH.Name = "FILE_PATH"
        Me.FILE_PATH.NextFocus = Nothing
        Me.FILE_PATH.RequiredFor = ""
        Me.FILE_PATH.Size = New System.Drawing.Size(93, 22)
        Me.FILE_PATH.TabIndex = 27
        Me.FILE_PATH.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.FILE_PATH.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Action = "DeleteData"
        Me.btnDelete.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(911, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 25)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "&Delete"
        Me.Localizer1.SetWordID(Me.btnDelete, "&Delete")
        '
        'btnFileUpload
        '
        Me.btnFileUpload.Action = "DownloadData"
        Me.btnFileUpload.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnFileUpload.Location = New System.Drawing.Point(633, 7)
        Me.btnFileUpload.Name = "btnFileUpload"
        Me.btnFileUpload.Size = New System.Drawing.Size(87, 22)
        Me.btnFileUpload.TabIndex = 26
        Me.btnFileUpload.Text = "Excel &Upload"
        Me.btnFileUpload.Visible = False
        Me.Localizer1.SetWordID(Me.btnFileUpload, "Excel &Upload")
        '
        'btnSearch
        '
        Me.btnSearch.Action = "SearchData"
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(755, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 25)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'btnCopyExchangeRate
        '
        Me.btnCopyExchangeRate.Action = ""
        Me.btnCopyExchangeRate.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnCopyExchangeRate.Location = New System.Drawing.Point(894, 6)
        Me.btnCopyExchangeRate.Name = "btnCopyExchangeRate"
        Me.btnCopyExchangeRate.Size = New System.Drawing.Size(87, 22)
        Me.btnCopyExchangeRate.TabIndex = 12
        Me.btnCopyExchangeRate.Text = "&Copy"
        Me.Localizer1.SetWordID(Me.btnCopyExchangeRate, "&Copy")
        '
        'TO_DATE
        '
        Me.TO_DATE.BorderColor = System.Drawing.Color.Silver
        Me.TO_DATE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TO_DATE.DefVal = ""
        Me.TO_DATE.IconVisible = True
        Me.TO_DATE.IsDataStateAware = True
        Me.TO_DATE.Location = New System.Drawing.Point(789, 6)
        Me.TO_DATE.Name = "TO_DATE"
        Me.TO_DATE.NextFocus = "btnCopyExchangeRate"
        Me.TO_DATE.RequiredFor = ""
        Me.TO_DATE.Size = New System.Drawing.Size(100, 22)
        Me.TO_DATE.TabIndex = 11
        Me.Localizer1.SetWordID(Me.TO_DATE, "")
        '
        'FROM_DATE
        '
        Me.FROM_DATE.BorderColor = System.Drawing.Color.Silver
        Me.FROM_DATE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FROM_DATE.DefVal = ""
        Me.FROM_DATE.IconVisible = True
        Me.FROM_DATE.IsDataStateAware = True
        Me.FROM_DATE.Location = New System.Drawing.Point(667, 6)
        Me.FROM_DATE.Name = "FROM_DATE"
        Me.FROM_DATE.NextFocus = "TO_DATE"
        Me.FROM_DATE.RequiredFor = ""
        Me.FROM_DATE.Size = New System.Drawing.Size(100, 22)
        Me.FROM_DATE.TabIndex = 10
        Me.Localizer1.SetWordID(Me.FROM_DATE, "")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.WG1)
        Me.Panel1.Controls.Add(Me.PanelControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 596)
        Me.Panel1.TabIndex = 6
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCopyExchangeRate)
        Me.PanelControl1.Controls.Add(Me.TO_DATE)
        Me.PanelControl1.Controls.Add(Me.Button1)
        Me.PanelControl1.Controls.Add(Me.FROM_DATE)
        Me.PanelControl1.Controls.Add(Me.S_EXRT_YMD)
        Me.PanelControl1.Controls.Add(Me.lbl_S_EXRT_YMD)
        Me.PanelControl1.Controls.Add(Me.lbl_DASH)
        Me.PanelControl1.Controls.Add(Me.lbl_COPY_EXRT)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(996, 33)
        Me.PanelControl1.TabIndex = 3
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'Button1
        '
        Me.Button1.Action = "DownloadData"
        Me.Button1.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.Button1.Location = New System.Drawing.Point(262, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 22)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Text &Upload"
        Me.Button1.ToolTip = "외환은행 환율 텍스트 파일 업로드"
        Me.Localizer1.SetWordID(Me.Button1, "Text &Upload")
        '
        'S_EXRT_YMD
        '
        Me.S_EXRT_YMD.BorderColor = System.Drawing.Color.Silver
        Me.S_EXRT_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_EXRT_YMD.DefVal = ""
        Me.S_EXRT_YMD.IconVisible = True
        Me.S_EXRT_YMD.IsDataStateAware = True
        Me.S_EXRT_YMD.Location = New System.Drawing.Point(140, 6)
        Me.S_EXRT_YMD.Name = "S_EXRT_YMD"
        Me.S_EXRT_YMD.NextFocus = "WG1"
        Me.S_EXRT_YMD.RequiredFor = ""
        Me.S_EXRT_YMD.Size = New System.Drawing.Size(100, 22)
        Me.S_EXRT_YMD.TabIndex = 25
        Me.Localizer1.SetWordID(Me.S_EXRT_YMD, "")
        '
        'lbl_S_EXRT_YMD
        '
        Me.lbl_S_EXRT_YMD.AutoEllipsis = True
        Me.lbl_S_EXRT_YMD.LabelFor = Nothing
        Me.lbl_S_EXRT_YMD.Location = New System.Drawing.Point(14, 6)
        Me.lbl_S_EXRT_YMD.Name = "lbl_S_EXRT_YMD"
        Me.lbl_S_EXRT_YMD.Size = New System.Drawing.Size(120, 22)
        Me.lbl_S_EXRT_YMD.TabIndex = 24
        Me.lbl_S_EXRT_YMD.Text = "기준일"
        Me.lbl_S_EXRT_YMD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_EXRT_YMD, "기준일")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.lbl_COPY_EXRT, "Copy Exchange Rate")
        Me.Localizer1.SetWordID(Me.lbl_DASH, "~")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.Currency, "통화코드")
        Me.Localizer1.SetWordID(Me.Code, "Code")
        Me.Localizer1.SetWordID(Me.ABGV1_CURR_CD, "Currency Code")
        Me.Localizer1.SetWordID(Me.Unit, "Unit")
        Me.Localizer1.SetWordID(Me.ABGV1_CURR_UNIT, "Unit")
        Me.Localizer1.SetWordID(Me.Cash, "현찰")
        Me.Localizer1.SetWordID(Me.Buying, "사실때")
        Me.Localizer1.SetWordID(Me.ABGV1_CASH_BUYRT, "Cash Buying")
        Me.Localizer1.SetWordID(Me.Selling, "파실때")
        Me.Localizer1.SetWordID(Me.ABGV1_CASH_SELLRT, "Cash Selling")
        Me.Localizer1.SetWordID(Me.TelegraphicTransfer, "송금")
        Me.Localizer1.SetWordID(Me.Sending, "보내실때")
        Me.Localizer1.SetWordID(Me.ABGV1_WIRE_SEND_EXRT, "Telegraphic Transfer Sending")
        Me.Localizer1.SetWordID(Me.Receiving, "받으실때")
        Me.Localizer1.SetWordID(Me.ABGV1_WIRE_RECV_EXRT, "Telegraphic Transfer Receiving")
        Me.Localizer1.SetWordID(Me.Standard, "매매기준율")
        Me.Localizer1.SetWordID(Me.ABGV1_EXCH_BASERT, "Standard")
        Me.Localizer1.SetWordID(Me.GridBand1, "미화 환산율")
        Me.Localizer1.SetWordID(Me.ABGV1_USD_CONV_RT, "US$ Convert")
        Me.Localizer1.SetWordID(Me.Remark, "Remark")
        Me.Localizer1.SetWordID(Me.ABGV1_RMK, "Remark")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.EX_DATE, "")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.FILE_PATH, "")
        Me.Localizer1.SetWordID(Me.btnDelete, "&Delete")
        Me.Localizer1.SetWordID(Me.btnFileUpload, "Excel &Upload")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.btnCopyExchangeRate, "&Copy")
        Me.Localizer1.SetWordID(Me.TO_DATE, "")
        Me.Localizer1.SetWordID(Me.FROM_DATE, "")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.Button1, "Text &Upload")
        Me.Localizer1.SetWordID(Me.S_EXRT_YMD, "")
        Me.Localizer1.SetWordID(Me.lbl_S_EXRT_YMD, "기준일")
        '
        'MdmExrateMgt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1008, 640)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "MdmExrateMgt"
        Me.Text = "Exchange Rate Management"
        Me.Localizer1.SetWordID(Me, "Exchange Rate Management")
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ABGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.palAutoButton.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_DASH As YJIT.SC.UI.SCControls.Label
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents lbl_COPY_EXRT As YJIT.SC.UI.SCControls.Label
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents TO_DATE As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents FROM_DATE As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents btnCopyExchangeRate As YJIT.SC.UI.SCControls.Button
    Friend WithEvents ABGV1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents ABGV1_CURR_CD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ABGV1_CURR_UNIT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ABGV1_CASH_SELLRT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ABGV1_EXCH_BASERT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ABGV1_USD_CONV_RT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ABGV1_CASH_BUYRT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFileUpload As YJIT.SC.UI.SCControls.Button
    Friend WithEvents lbl_S_EXRT_YMD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnDelete As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents ABGV1_WIRE_SEND_EXRT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ABGV1_WIRE_RECV_EXRT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemTextEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents FILE_PATH As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Button1 As YJIT.SC.UI.SCControls.Button
    Public WithEvents S_EXRT_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents ABGV1_RMK As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Currency As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Code As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Unit As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Cash As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Buying As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Selling As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents TelegraphicTransfer As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Sending As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Receiving As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Standard As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Remark As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EX_DATE As YJIT.SC.UI.SCControls.TextBox
End Class
