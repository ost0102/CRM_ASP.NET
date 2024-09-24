<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmCustomize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmCustomize))
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.TOT_AMT = New YJIT.SC.UI.SCControls.NumericTextBox()
        Me.PROFITS = New YJIT.SC.UI.SCControls.NumericTextBox()
        Me.Label12 = New YJIT.SC.UI.SCControls.Label()
        Me.CUSTOM_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.CUSTOM_DTL = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label51 = New YJIT.SC.UI.SCControls.Label()
        Me.Label34 = New YJIT.SC.UI.SCControls.Label()
        Me.DOWN_PAY = New YJIT.SC.UI.SCControls.NumericTextBox()
        Me.Label50 = New YJIT.SC.UI.SCControls.Label()
        Me.DEVELOPER = New YJIT.SC.UI.SCControls.TextBox()
        Me.REQUESTOR = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_FARE_NM = New YJIT.SC.UI.SCControls.Label()
        Me.MNGT_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.lbl_FARE_GRP_CD = New YJIT.SC.UI.SCControls.Label()
        Me.일자 = New YJIT.SC.UI.SCControls.Label()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnPrint = New YJIT.SC.UI.SCControls.Button()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.btnDelete = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.OLD_REQ_USR = New YJIT.SC.UI.SCControls.TextBox()
        Me.OLD_CUST_CD = New YJIT.SC.UI.SCControls.TextBox()
        Me.CUST_PIC_LIST = New DevExpress.XtraEditors.LookUpEdit()
        Me.CUST_LIST = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.CUST_CD = New YJIT.SC.UI.SCControls.TextBox()
        Me.CUST_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.Label37 = New YJIT.SC.UI.SCControls.Label()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV2_CUST_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CUST_DTL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CUST_COST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV2_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.WG3 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV3_FUND_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_ISSUED_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_SALES_VAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV3_BUY_VAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV3_FUND_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.WG4 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV4_ESTM_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_ESTM_COST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV4_ESTM_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_CUSTOM_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_DateEdit = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.GV1_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DOWN_PAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEVELOPER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TOT_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_CUSTOM_DTL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQUESTOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROFITS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.CUST_PIC_LIST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUST_LIST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.WG4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4_DateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Action = "NewData"
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(675, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(70, 25)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "&New"
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.TOT_AMT)
        Me.PanelControl1.Controls.Add(Me.PROFITS)
        Me.PanelControl1.Controls.Add(Me.Label12)
        Me.PanelControl1.Controls.Add(Me.CUSTOM_YMD)
        Me.PanelControl1.Controls.Add(Me.CUSTOM_DTL)
        Me.PanelControl1.Controls.Add(Me.Label51)
        Me.PanelControl1.Controls.Add(Me.Label34)
        Me.PanelControl1.Controls.Add(Me.DOWN_PAY)
        Me.PanelControl1.Controls.Add(Me.Label50)
        Me.PanelControl1.Controls.Add(Me.DEVELOPER)
        Me.PanelControl1.Controls.Add(Me.REQUESTOR)
        Me.PanelControl1.Controls.Add(Me.lbl_FARE_NM)
        Me.PanelControl1.Controls.Add(Me.MNGT_NO)
        Me.PanelControl1.Controls.Add(Me.lbl_FARE_GRP_CD)
        Me.PanelControl1.Controls.Add(Me.일자)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Location = New System.Drawing.Point(525, 44)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(464, 262)
        Me.PanelControl1.TabIndex = 3
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'TOT_AMT
        '
        Me.TOT_AMT.AllowSpace = False
        Me.TOT_AMT.BindingPropertyName = "Text"
        Me.TOT_AMT.BorderColor = System.Drawing.Color.Silver
        Me.TOT_AMT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TOT_AMT.DefVal = ""
        Me.TOT_AMT.Format = "###,##0.##"
        Me.TOT_AMT.IsDataStateAware = True
        Me.TOT_AMT.Location = New System.Drawing.Point(111, 85)
        Me.TOT_AMT.Name = "TOT_AMT"
        Me.TOT_AMT.NextFocus = "CTRT_END_RSN"
        Me.TOT_AMT.ReadOnly = True
        Me.TOT_AMT.RequiredFor = ""
        Me.TOT_AMT.Size = New System.Drawing.Size(110, 22)
        Me.TOT_AMT.TabIndex = 226
        Me.TOT_AMT.Text = "0"
        Me.TOT_AMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TOT_AMT.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.TOT_AMT.Value = 0.0R
        '
        'PROFITS
        '
        Me.PROFITS.AllowSpace = False
        Me.PROFITS.BindingPropertyName = "Text"
        Me.PROFITS.BorderColor = System.Drawing.Color.Silver
        Me.PROFITS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PROFITS.DefVal = ""
        Me.PROFITS.Format = "###,##0.##"
        Me.PROFITS.IsDataStateAware = True
        Me.PROFITS.Location = New System.Drawing.Point(319, 85)
        Me.PROFITS.Name = "PROFITS"
        Me.PROFITS.NextFocus = "DEVELOPER"
        Me.PROFITS.ReadOnly = True
        Me.PROFITS.RequiredFor = ""
        Me.PROFITS.Size = New System.Drawing.Size(113, 22)
        Me.PROFITS.TabIndex = 225
        Me.PROFITS.Text = "0"
        Me.PROFITS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PROFITS.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.PROFITS.Value = 0.0R
        '
        'Label12
        '
        Me.Label12.LabelFor = Nothing
        Me.Label12.Location = New System.Drawing.Point(28, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 14)
        Me.Label12.TabIndex = 223
        Me.Label12.Text = "상세"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label12, "상세")
        '
        'CUSTOM_YMD
        '
        Me.CUSTOM_YMD.BorderColor = System.Drawing.Color.Silver
        Me.CUSTOM_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CUSTOM_YMD.DefVal = ""
        Me.CUSTOM_YMD.IconVisible = True
        Me.CUSTOM_YMD.IsDataStateAware = True
        Me.CUSTOM_YMD.Location = New System.Drawing.Point(111, 57)
        Me.CUSTOM_YMD.Name = "CUSTOM_YMD"
        Me.CUSTOM_YMD.NextFocus = "DOWN_PAY"
        Me.CUSTOM_YMD.RequiredFor = ""
        Me.CUSTOM_YMD.Size = New System.Drawing.Size(111, 22)
        Me.CUSTOM_YMD.TabIndex = 217
        Me.Localizer1.SetWordID(Me.CUSTOM_YMD, "")
        '
        'CUSTOM_DTL
        '
        Me.CUSTOM_DTL.BorderColor = System.Drawing.Color.Silver
        Me.CUSTOM_DTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CUSTOM_DTL.DefVal = ""
        Me.CUSTOM_DTL.IsDataStateAware = True
        Me.CUSTOM_DTL.Location = New System.Drawing.Point(111, 141)
        Me.CUSTOM_DTL.Multiline = True
        Me.CUSTOM_DTL.Name = "CUSTOM_DTL"
        Me.CUSTOM_DTL.NextFocus = ""
        Me.CUSTOM_DTL.RequiredFor = ""
        Me.CUSTOM_DTL.Size = New System.Drawing.Size(321, 92)
        Me.CUSTOM_DTL.TabIndex = 224
        Me.CUSTOM_DTL.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label51
        '
        Me.Label51.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label51.LabelFor = Nothing
        Me.Label51.Location = New System.Drawing.Point(236, 59)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(69, 14)
        Me.Label51.TabIndex = 216
        Me.Label51.Text = "계약금액"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label51, "계약금액")
        '
        'Label34
        '
        Me.Label34.LabelFor = Nothing
        Me.Label34.Location = New System.Drawing.Point(227, 88)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(77, 14)
        Me.Label34.TabIndex = 221
        Me.Label34.Text = "수익금액"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label34, "수익금액")
        '
        'DOWN_PAY
        '
        Me.DOWN_PAY.AllowSpace = False
        Me.DOWN_PAY.BindingPropertyName = "Text"
        Me.DOWN_PAY.BorderColor = System.Drawing.Color.Silver
        Me.DOWN_PAY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DOWN_PAY.DefVal = ""
        Me.DOWN_PAY.Format = "###,##0.##"
        Me.DOWN_PAY.IsDataStateAware = True
        Me.DOWN_PAY.Location = New System.Drawing.Point(319, 57)
        Me.DOWN_PAY.Name = "DOWN_PAY"
        Me.DOWN_PAY.NextFocus = "DEVELOPER"
        Me.DOWN_PAY.RequiredFor = ""
        Me.DOWN_PAY.Size = New System.Drawing.Size(113, 22)
        Me.DOWN_PAY.TabIndex = 219
        Me.DOWN_PAY.Text = "0"
        Me.DOWN_PAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DOWN_PAY.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.DOWN_PAY.Value = 0.0R
        '
        'Label50
        '
        Me.Label50.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label50.LabelFor = Nothing
        Me.Label50.Location = New System.Drawing.Point(15, 87)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(77, 16)
        Me.Label50.TabIndex = 215
        Me.Label50.Text = "비용금액"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label50, "비용금액")
        '
        'DEVELOPER
        '
        Me.DEVELOPER.BorderColor = System.Drawing.Color.Silver
        Me.DEVELOPER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DEVELOPER.DefVal = ""
        Me.DEVELOPER.IsDataStateAware = True
        Me.DEVELOPER.Location = New System.Drawing.Point(111, 113)
        Me.DEVELOPER.MaxLength = 50
        Me.DEVELOPER.Name = "DEVELOPER"
        Me.DEVELOPER.NextFocus = "REQUESTOR"
        Me.DEVELOPER.RequiredFor = ""
        Me.DEVELOPER.Size = New System.Drawing.Size(112, 22)
        Me.DEVELOPER.TabIndex = 37
        Me.DEVELOPER.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'REQUESTOR
        '
        Me.REQUESTOR.BorderColor = System.Drawing.Color.Silver
        Me.REQUESTOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.REQUESTOR.DefVal = ""
        Me.REQUESTOR.IsDataStateAware = True
        Me.REQUESTOR.Location = New System.Drawing.Point(319, 113)
        Me.REQUESTOR.MaxLength = 50
        Me.REQUESTOR.Name = "REQUESTOR"
        Me.REQUESTOR.NextFocus = "CUSTOM_DTL"
        Me.REQUESTOR.RequiredFor = ""
        Me.REQUESTOR.Size = New System.Drawing.Size(113, 22)
        Me.REQUESTOR.TabIndex = 2
        Me.REQUESTOR.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'lbl_FARE_NM
        '
        Me.lbl_FARE_NM.AutoEllipsis = True
        Me.lbl_FARE_NM.LabelFor = Nothing
        Me.lbl_FARE_NM.Location = New System.Drawing.Point(15, 113)
        Me.lbl_FARE_NM.Name = "lbl_FARE_NM"
        Me.lbl_FARE_NM.Size = New System.Drawing.Size(74, 22)
        Me.lbl_FARE_NM.TabIndex = 20
        Me.lbl_FARE_NM.Text = "개발자"
        Me.lbl_FARE_NM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_FARE_NM, "개발자")
        '
        'MNGT_NO
        '
        Me.MNGT_NO.BorderColor = System.Drawing.Color.Silver
        Me.MNGT_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MNGT_NO.DefVal = ""
        Me.MNGT_NO.IsDataStateAware = True
        Me.MNGT_NO.Location = New System.Drawing.Point(111, 29)
        Me.MNGT_NO.MaxLength = 35
        Me.MNGT_NO.Name = "MNGT_NO"
        Me.MNGT_NO.NextFocus = ""
        Me.MNGT_NO.ReadOnly = True
        Me.MNGT_NO.RequiredFor = ""
        Me.MNGT_NO.Size = New System.Drawing.Size(111, 22)
        Me.MNGT_NO.TabIndex = 9
        Me.MNGT_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'lbl_FARE_GRP_CD
        '
        Me.lbl_FARE_GRP_CD.AutoEllipsis = True
        Me.lbl_FARE_GRP_CD.LabelFor = Nothing
        Me.lbl_FARE_GRP_CD.Location = New System.Drawing.Point(27, 29)
        Me.lbl_FARE_GRP_CD.Name = "lbl_FARE_GRP_CD"
        Me.lbl_FARE_GRP_CD.Size = New System.Drawing.Size(69, 22)
        Me.lbl_FARE_GRP_CD.TabIndex = 21
        Me.lbl_FARE_GRP_CD.Text = "견적번호"
        Me.lbl_FARE_GRP_CD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_FARE_GRP_CD, "견적번호")
        '
        '일자
        '
        Me.일자.AutoEllipsis = True
        Me.일자.LabelFor = Nothing
        Me.일자.Location = New System.Drawing.Point(31, 57)
        Me.일자.Name = "일자"
        Me.일자.Size = New System.Drawing.Size(58, 22)
        Me.일자.TabIndex = 23
        Me.일자.Text = "일자"
        Me.일자.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.일자, "일자")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(262, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 14)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "요청자"
        Me.Localizer1.SetWordID(Me.Label4, "요청자")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnPrint)
        Me.palAutoButton.Controls.Add(Me.btnSave)
        Me.palAutoButton.Controls.Add(Me.btnDelete)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 7)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(983, 32)
        Me.palAutoButton.TabIndex = 1
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnPrint
        '
        Me.btnPrint.Action = "PrintData"
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(903, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(70, 25)
        Me.btnPrint.TabIndex = 66
        Me.btnPrint.Text = "&Print"
        Me.Localizer1.SetWordID(Me.btnPrint, "&Print")
        '
        'btnSave
        '
        Me.btnSave.Action = "SaveData"
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(751, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 25)
        Me.btnSave.TabIndex = 65
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'btnDelete
        '
        Me.btnDelete.Action = "DeleteData"
        Me.btnDelete.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(827, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 25)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.Localizer1.SetWordID(Me.btnDelete, "&Delete")
        '
        'btnSearch
        '
        Me.btnSearch.Action = "SearchData"
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(605, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(64, 25)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PanelControl5)
        Me.Panel1.Controls.Add(Me.PanelControl2)
        Me.Panel1.Controls.Add(Me.PanelControl1)
        Me.Panel1.Controls.Add(Me.XtraTabControl1)
        Me.Panel1.Controls.Add(Me.WG1)
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 600)
        Me.Panel1.TabIndex = 6
        Me.Localizer1.SetWordID(Me.Panel1, "")
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.OLD_REQ_USR)
        Me.PanelControl5.Controls.Add(Me.OLD_CUST_CD)
        Me.PanelControl5.Controls.Add(Me.CUST_PIC_LIST)
        Me.PanelControl5.Controls.Add(Me.CUST_LIST)
        Me.PanelControl5.Location = New System.Drawing.Point(899, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(92, 42)
        Me.PanelControl5.TabIndex = 271
        Me.PanelControl5.Visible = False
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        '
        'OLD_REQ_USR
        '
        Me.OLD_REQ_USR.BorderColor = System.Drawing.Color.Silver
        Me.OLD_REQ_USR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OLD_REQ_USR.DefVal = ""
        Me.OLD_REQ_USR.IsDataStateAware = True
        Me.OLD_REQ_USR.Location = New System.Drawing.Point(4, 60)
        Me.OLD_REQ_USR.MaxLength = 30
        Me.OLD_REQ_USR.Name = "OLD_REQ_USR"
        Me.OLD_REQ_USR.NextFocus = ""
        Me.OLD_REQ_USR.RequiredFor = ""
        Me.OLD_REQ_USR.Size = New System.Drawing.Size(101, 22)
        Me.OLD_REQ_USR.TabIndex = 271
        Me.OLD_REQ_USR.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'OLD_CUST_CD
        '
        Me.OLD_CUST_CD.BorderColor = System.Drawing.Color.Silver
        Me.OLD_CUST_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OLD_CUST_CD.DefVal = ""
        Me.OLD_CUST_CD.IsDataStateAware = True
        Me.OLD_CUST_CD.Location = New System.Drawing.Point(5, 32)
        Me.OLD_CUST_CD.MaxLength = 30
        Me.OLD_CUST_CD.Name = "OLD_CUST_CD"
        Me.OLD_CUST_CD.NextFocus = ""
        Me.OLD_CUST_CD.RequiredFor = ""
        Me.OLD_CUST_CD.Size = New System.Drawing.Size(100, 22)
        Me.OLD_CUST_CD.TabIndex = 270
        Me.OLD_CUST_CD.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'CUST_PIC_LIST
        '
        Me.CUST_PIC_LIST.Location = New System.Drawing.Point(29, 5)
        Me.CUST_PIC_LIST.Name = "CUST_PIC_LIST"
        Me.CUST_PIC_LIST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CUST_PIC_LIST.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PIC_NM", 80, "Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEL_NO", 120, "Tel No")})
        Me.CUST_PIC_LIST.Properties.NullText = "--Select--"
        Me.CUST_PIC_LIST.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.CUST_PIC_LIST.Size = New System.Drawing.Size(18, 21)
        Me.CUST_PIC_LIST.TabIndex = 269
        Me.Localizer1.SetWordID(Me.CUST_PIC_LIST, "--Select--")
        '
        'CUST_LIST
        '
        Me.CUST_LIST.Location = New System.Drawing.Point(5, 5)
        Me.CUST_LIST.Name = "CUST_LIST"
        Me.CUST_LIST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CUST_LIST.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUST_CD", 80, "Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUST_LOC_NM", 120, "Name")})
        Me.CUST_LIST.Properties.NullText = "--Select--"
        Me.CUST_LIST.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.CUST_LIST.Size = New System.Drawing.Size(18, 21)
        Me.CUST_LIST.TabIndex = 268
        Me.Localizer1.SetWordID(Me.CUST_LIST, "--Select--")
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.CUST_CD)
        Me.PanelControl2.Controls.Add(Me.CUST_NM)
        Me.PanelControl2.Controls.Add(Me.Label37)
        Me.PanelControl2.Location = New System.Drawing.Point(6, 5)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(983, 33)
        Me.PanelControl2.TabIndex = 6
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'CUST_CD
        '
        Me.CUST_CD.BorderColor = System.Drawing.Color.Silver
        Me.CUST_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CUST_CD.DefVal = ""
        Me.CUST_CD.IsDataStateAware = True
        Me.CUST_CD.Location = New System.Drawing.Point(58, 6)
        Me.CUST_CD.MaxLength = 30
        Me.CUST_CD.Name = "CUST_CD"
        Me.CUST_CD.NextFocus = "btnSearch"
        Me.CUST_CD.RequiredFor = ""
        Me.CUST_CD.Size = New System.Drawing.Size(100, 22)
        Me.CUST_CD.TabIndex = 267
        Me.CUST_CD.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'CUST_NM
        '
        Me.CUST_NM.AutoEllipsis = True
        Me.CUST_NM.BorderColor = System.Drawing.Color.Silver
        Me.CUST_NM.LabelFor = Nothing
        Me.CUST_NM.Location = New System.Drawing.Point(168, 6)
        Me.CUST_NM.Name = "CUST_NM"
        Me.CUST_NM.Size = New System.Drawing.Size(311, 22)
        Me.CUST_NM.TabIndex = 266
        Me.CUST_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.LabelFor = Nothing
        Me.Label37.Location = New System.Drawing.Point(12, 9)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(37, 14)
        Me.Label37.TabIndex = 265
        Me.Label37.Text = "거래처"
        Me.Localizer1.SetWordID(Me.Label37, "거래처")
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(525, 312)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(481, 285)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        Me.Localizer1.SetWordID(Me.XtraTabControl1, "")
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PanelControl3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(476, 259)
        Me.XtraTabPage1.Text = "비용 사용내역"
        Me.Localizer1.SetWordID(Me.XtraTabPage1, "비용 사용내역")
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.WG2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(476, 259)
        Me.PanelControl3.TabIndex = 61
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.DeleteRowConfirmation = False
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(0, 0)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2})
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(476, 259)
        Me.WG2.TabIndex = 272
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2, Me.GridView4, Me.GridView9, Me.GridView10})
        '
        'GV2
        '
        Me.GV2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GV2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV2_CUST_ITEM, Me.GV2_CUST_DTL, Me.GV2_CUST_COST, Me.GV2_SEQ, Me.GV2_MNGT_NO})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.IndicatorWidth = 40
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsCustomization.AllowColumnMoving = False
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorzLines = False
        '
        'GV2_CUST_ITEM
        '
        Me.GV2_CUST_ITEM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CUST_ITEM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUST_ITEM.Caption = "항목"
        Me.GV2_CUST_ITEM.FieldName = "CUST_ITEM"
        Me.GV2_CUST_ITEM.Name = "GV2_CUST_ITEM"
        Me.GV2_CUST_ITEM.Visible = True
        Me.GV2_CUST_ITEM.VisibleIndex = 0
        Me.GV2_CUST_ITEM.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_CUST_ITEM, "항목")
        '
        'GV2_CUST_DTL
        '
        Me.GV2_CUST_DTL.Caption = "내용"
        Me.GV2_CUST_DTL.FieldName = "CUST_DTL"
        Me.GV2_CUST_DTL.Name = "GV2_CUST_DTL"
        Me.GV2_CUST_DTL.Visible = True
        Me.GV2_CUST_DTL.VisibleIndex = 2
        Me.GV2_CUST_DTL.Width = 330
        Me.Localizer1.SetWordID(Me.GV2_CUST_DTL, "내용")
        '
        'GV2_CUST_COST
        '
        Me.GV2_CUST_COST.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_CUST_COST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_CUST_COST.Caption = "금액"
        Me.GV2_CUST_COST.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GV2_CUST_COST.FieldName = "CUST_COST"
        Me.GV2_CUST_COST.Name = "GV2_CUST_COST"
        Me.GV2_CUST_COST.Visible = True
        Me.GV2_CUST_COST.VisibleIndex = 1
        Me.GV2_CUST_COST.Width = 92
        Me.Localizer1.SetWordID(Me.GV2_CUST_COST, "금액")
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Mask.EditMask = "###,###,###,###,###,##0;(###,###,###,###,###,##0)"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'GV2_SEQ
        '
        Me.GV2_SEQ.Caption = "SEQ"
        Me.GV2_SEQ.FieldName = "SEQ"
        Me.GV2_SEQ.Name = "GV2_SEQ"
        Me.Localizer1.SetWordID(Me.GV2_SEQ, "SEQ")
        '
        'GV2_MNGT_NO
        '
        Me.GV2_MNGT_NO.Caption = "견적번호"
        Me.GV2_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV2_MNGT_NO.Name = "GV2_MNGT_NO"
        Me.GV2_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV2_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV2_MNGT_NO.Width = 97
        Me.Localizer1.SetWordID(Me.GV2_MNGT_NO, "견적번호")
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.WG2
        Me.GridView4.Name = "GridView4"
        '
        'GridView9
        '
        Me.GridView9.GridControl = Me.WG2
        Me.GridView9.Name = "GridView9"
        '
        'GridView10
        '
        Me.GridView10.GridControl = Me.WG2
        Me.GridView10.Name = "GridView10"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(474, 259)
        Me.XtraTabPage2.Text = "자금 집행계획"
        Me.Localizer1.SetWordID(Me.XtraTabPage2, "자금 집행계획")
        '
        'PanelControl4
        '
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.WG3)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(474, 259)
        Me.PanelControl4.TabIndex = 62
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        '
        'WG3
        '
        Me.WG3.AllowClientBinding = True
        Me.WG3.DeleteRowConfirmation = False
        Me.WG3.DisplayCurrentRow = False
        Me.WG3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG3.IsDataStateAware = True
        Me.WG3.Location = New System.Drawing.Point(0, 0)
        Me.WG3.MainView = Me.GV3
        Me.WG3.Name = "WG3"
        Me.WG3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.WG3.SaveLayout = False
        Me.WG3.Size = New System.Drawing.Size(474, 259)
        Me.WG3.TabIndex = 272
        Me.WG3.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3, Me.GridView5, Me.GridView7, Me.GridView8})
        '
        'GV3
        '
        Me.GV3.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GV3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV3.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV3_FUND_ITEM, Me.GV3_ISSUED_YMD, Me.GV3_SALES_VAL, Me.GV3_BUY_VAL, Me.GV3_FUND_RMK, Me.GV3_SEQ, Me.GV3_MNGT_NO})
        Me.GV3.GridControl = Me.WG3
        Me.GV3.IndicatorWidth = 40
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsCustomization.AllowColumnMoving = False
        Me.GV3.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV3.OptionsView.ColumnAutoWidth = False
        Me.GV3.OptionsView.ShowGroupPanel = False
        Me.GV3.OptionsView.ShowHorzLines = False
        '
        'GV3_FUND_ITEM
        '
        Me.GV3_FUND_ITEM.Caption = "항목"
        Me.GV3_FUND_ITEM.FieldName = "FUND_ITEM"
        Me.GV3_FUND_ITEM.Name = "GV3_FUND_ITEM"
        Me.GV3_FUND_ITEM.Visible = True
        Me.GV3_FUND_ITEM.VisibleIndex = 0
        Me.GV3_FUND_ITEM.Width = 100
        Me.Localizer1.SetWordID(Me.GV3_FUND_ITEM, "항목")
        '
        'GV3_ISSUED_YMD
        '
        Me.GV3_ISSUED_YMD.Caption = "계산서발행일"
        Me.GV3_ISSUED_YMD.FieldName = "ISSUED_YMD"
        Me.GV3_ISSUED_YMD.Name = "GV3_ISSUED_YMD"
        Me.GV3_ISSUED_YMD.Visible = True
        Me.GV3_ISSUED_YMD.VisibleIndex = 1
        Me.GV3_ISSUED_YMD.Width = 96
        Me.Localizer1.SetWordID(Me.GV3_ISSUED_YMD, "계산서발행일")
        '
        'GV3_SALES_VAL
        '
        Me.GV3_SALES_VAL.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_SALES_VAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV3_SALES_VAL.Caption = "매출 금액"
        Me.GV3_SALES_VAL.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GV3_SALES_VAL.FieldName = "SALES_VAL"
        Me.GV3_SALES_VAL.Name = "GV3_SALES_VAL"
        Me.GV3_SALES_VAL.Visible = True
        Me.GV3_SALES_VAL.VisibleIndex = 2
        Me.GV3_SALES_VAL.Width = 102
        Me.Localizer1.SetWordID(Me.GV3_SALES_VAL, "매출 금액")
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "###,###,###,###,###,##0;(###,###,###,###,###,##0)"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'GV3_BUY_VAL
        '
        Me.GV3_BUY_VAL.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_BUY_VAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV3_BUY_VAL.Caption = "매입 금액"
        Me.GV3_BUY_VAL.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GV3_BUY_VAL.FieldName = "BUY_VAL"
        Me.GV3_BUY_VAL.Name = "GV3_BUY_VAL"
        Me.GV3_BUY_VAL.Visible = True
        Me.GV3_BUY_VAL.VisibleIndex = 3
        Me.GV3_BUY_VAL.Width = 102
        Me.Localizer1.SetWordID(Me.GV3_BUY_VAL, "매입 금액")
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "###,###,###,###,###,##0;(###,###,###,###,###,##0)"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GV3_FUND_RMK
        '
        Me.GV3_FUND_RMK.Caption = "비고"
        Me.GV3_FUND_RMK.FieldName = "FUND_RMK"
        Me.GV3_FUND_RMK.Name = "GV3_FUND_RMK"
        Me.GV3_FUND_RMK.Visible = True
        Me.GV3_FUND_RMK.VisibleIndex = 4
        Me.GV3_FUND_RMK.Width = 300
        Me.Localizer1.SetWordID(Me.GV3_FUND_RMK, "비고")
        '
        'GV3_SEQ
        '
        Me.GV3_SEQ.Caption = "SEQ"
        Me.GV3_SEQ.FieldName = "SEQ"
        Me.GV3_SEQ.Name = "GV3_SEQ"
        Me.Localizer1.SetWordID(Me.GV3_SEQ, "SEQ")
        '
        'GV3_MNGT_NO
        '
        Me.GV3_MNGT_NO.Caption = "견적번호"
        Me.GV3_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV3_MNGT_NO.Name = "GV3_MNGT_NO"
        Me.GV3_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV3_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV3_MNGT_NO.Width = 96
        Me.Localizer1.SetWordID(Me.GV3_MNGT_NO, "견적번호")
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.WG3
        Me.GridView5.Name = "GridView5"
        '
        'GridView7
        '
        Me.GridView7.GridControl = Me.WG3
        Me.GridView7.Name = "GridView7"
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.WG3
        Me.GridView8.Name = "GridView8"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.WG4)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(474, 259)
        Me.XtraTabPage3.Text = "견적서"
        Me.Localizer1.SetWordID(Me.XtraTabPage3, "견적서")
        '
        'WG4
        '
        Me.WG4.AllowClientBinding = True
        Me.WG4.DeleteRowConfirmation = False
        Me.WG4.DisplayCurrentRow = False
        Me.WG4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG4.IsDataStateAware = True
        Me.WG4.Location = New System.Drawing.Point(0, 0)
        Me.WG4.MainView = Me.GV4
        Me.WG4.Name = "WG4"
        Me.WG4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit5})
        Me.WG4.SaveLayout = False
        Me.WG4.Size = New System.Drawing.Size(474, 259)
        Me.WG4.TabIndex = 150
        Me.WG4.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4, Me.GridView2, Me.GridView3, Me.GridView6})
        '
        'GV4
        '
        Me.GV4.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GV4.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV4.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV4_ESTM_YMD, Me.GV4_ESTM_COST, Me.GV4_ESTM_RMK, Me.GV4_SEQ, Me.GV4_MNGT_NO})
        Me.GV4.GridControl = Me.WG4
        Me.GV4.IndicatorWidth = 40
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsCustomization.AllowColumnMoving = False
        Me.GV4.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV4.OptionsView.ColumnAutoWidth = False
        Me.GV4.OptionsView.ShowGroupPanel = False
        Me.GV4.OptionsView.ShowHorzLines = False
        '
        'GV4_ESTM_YMD
        '
        Me.GV4_ESTM_YMD.Caption = "일자"
        Me.GV4_ESTM_YMD.FieldName = "ESTM_YMD"
        Me.GV4_ESTM_YMD.Name = "GV4_ESTM_YMD"
        Me.GV4_ESTM_YMD.Visible = True
        Me.GV4_ESTM_YMD.VisibleIndex = 0
        Me.GV4_ESTM_YMD.Width = 93
        Me.Localizer1.SetWordID(Me.GV4_ESTM_YMD, "일자")
        '
        'GV4_ESTM_COST
        '
        Me.GV4_ESTM_COST.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_ESTM_COST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV4_ESTM_COST.Caption = "금액"
        Me.GV4_ESTM_COST.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GV4_ESTM_COST.FieldName = "ESTM_COST"
        Me.GV4_ESTM_COST.Name = "GV4_ESTM_COST"
        Me.GV4_ESTM_COST.Visible = True
        Me.GV4_ESTM_COST.VisibleIndex = 1
        Me.GV4_ESTM_COST.Width = 125
        Me.Localizer1.SetWordID(Me.GV4_ESTM_COST, "금액")
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "###,###,###,###,###,##0;(###,###,###,###,###,##0)"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'GV4_ESTM_RMK
        '
        Me.GV4_ESTM_RMK.Caption = "비고"
        Me.GV4_ESTM_RMK.FieldName = "ESTM_RMK"
        Me.GV4_ESTM_RMK.Name = "GV4_ESTM_RMK"
        Me.GV4_ESTM_RMK.Visible = True
        Me.GV4_ESTM_RMK.VisibleIndex = 2
        Me.GV4_ESTM_RMK.Width = 359
        Me.Localizer1.SetWordID(Me.GV4_ESTM_RMK, "비고")
        '
        'GV4_SEQ
        '
        Me.GV4_SEQ.Caption = "SEQ"
        Me.GV4_SEQ.FieldName = "SEQ"
        Me.GV4_SEQ.Name = "GV4_SEQ"
        Me.Localizer1.SetWordID(Me.GV4_SEQ, "SEQ")
        '
        'GV4_MNGT_NO
        '
        Me.GV4_MNGT_NO.Caption = "견적번호"
        Me.GV4_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV4_MNGT_NO.Name = "GV4_MNGT_NO"
        Me.GV4_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV4_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV4_MNGT_NO.Width = 100
        Me.Localizer1.SetWordID(Me.GV4_MNGT_NO, "견적번호")
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.WG4
        Me.GridView2.Name = "GridView2"
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.WG4
        Me.GridView3.Name = "GridView3"
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.WG4
        Me.GridView6.Name = "GridView6"
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = False
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(6, 44)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GV4_DateEdit, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit8})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(513, 553)
        Me.WG1.TabIndex = 267
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_CUSTOM_YMD, Me.GV1_MNGT_NO, Me.GV1_DOWN_PAY, Me.GV1_SEQ, Me.GV1_DEVELOPER, Me.GV1_TOT_AMT, Me.GV1_CUSTOM_DTL, Me.GV1_REQUESTOR, Me.GV1_PROFITS})
        Me.GV1.FixedLineWidth = 1
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.Editable = False
        Me.GV1.OptionsBehavior.ReadOnly = True
        Me.GV1.OptionsCustomization.AllowColumnMoving = False
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorzLines = False
        Me.GV1.OptionsView.ShowViewCaption = True
        Me.GV1.ViewCaption = " Customize List"
        '
        'GV1_CUSTOM_YMD
        '
        Me.GV1_CUSTOM_YMD.Caption = "일자"
        Me.GV1_CUSTOM_YMD.ColumnEdit = Me.GV4_DateEdit
        Me.GV1_CUSTOM_YMD.FieldName = "CUSTOM_YMD"
        Me.GV1_CUSTOM_YMD.Name = "GV1_CUSTOM_YMD"
        Me.GV1_CUSTOM_YMD.Visible = True
        Me.GV1_CUSTOM_YMD.VisibleIndex = 1
        Me.GV1_CUSTOM_YMD.Width = 71
        Me.Localizer1.SetWordID(Me.GV1_CUSTOM_YMD, "일자")
        '
        'GV4_DateEdit
        '
        Me.GV4_DateEdit.AutoHeight = False
        Me.GV4_DateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GV4_DateEdit.Mask.EditMask = "9999-99-99"
        Me.GV4_DateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.GV4_DateEdit.Mask.SaveLiteral = False
        Me.GV4_DateEdit.Mask.UseMaskAsDisplayFormat = True
        Me.GV4_DateEdit.Name = "GV4_DateEdit"
        '
        'GV1_MNGT_NO
        '
        Me.GV1_MNGT_NO.Caption = "견적번호"
        Me.GV1_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV1_MNGT_NO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_MNGT_NO.Name = "GV1_MNGT_NO"
        Me.GV1_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV1_MNGT_NO.Visible = True
        Me.GV1_MNGT_NO.VisibleIndex = 0
        Me.GV1_MNGT_NO.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "견적번호")
        '
        'GV1_DOWN_PAY
        '
        Me.GV1_DOWN_PAY.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.GV1_DOWN_PAY.AppearanceCell.Options.UseForeColor = True
        Me.GV1_DOWN_PAY.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_DOWN_PAY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_DOWN_PAY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DOWN_PAY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_DOWN_PAY.Caption = "계약금액"
        Me.GV1_DOWN_PAY.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.GV1_DOWN_PAY.FieldName = "DOWN_PAY"
        Me.GV1_DOWN_PAY.Name = "GV1_DOWN_PAY"
        Me.GV1_DOWN_PAY.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_DOWN_PAY, "계약금액")
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "###,###,###,###,###,##0;(###,###,###,###,###,##0)"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'GV1_SEQ
        '
        Me.GV1_SEQ.Caption = "순번"
        Me.GV1_SEQ.FieldName = "SEQ"
        Me.GV1_SEQ.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV1_SEQ.Name = "GV1_SEQ"
        Me.GV1_SEQ.Width = 35
        Me.Localizer1.SetWordID(Me.GV1_SEQ, "순번")
        '
        'GV1_DEVELOPER
        '
        Me.GV1_DEVELOPER.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_DEVELOPER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_DEVELOPER.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DEVELOPER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DEVELOPER.Caption = "개발자"
        Me.GV1_DEVELOPER.FieldName = "DEVELOPER"
        Me.GV1_DEVELOPER.Name = "GV1_DEVELOPER"
        Me.GV1_DEVELOPER.Width = 71
        Me.Localizer1.SetWordID(Me.GV1_DEVELOPER, "개발자")
        '
        'GV1_TOT_AMT
        '
        Me.GV1_TOT_AMT.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GV1_TOT_AMT.AppearanceCell.Options.UseForeColor = True
        Me.GV1_TOT_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TOT_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_TOT_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TOT_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_TOT_AMT.Caption = "비용금액"
        Me.GV1_TOT_AMT.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.GV1_TOT_AMT.FieldName = "TOT_AMT"
        Me.GV1_TOT_AMT.Name = "GV1_TOT_AMT"
        Me.GV1_TOT_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_TOT_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_TOT_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOT_AMT", "{0:###,###,###,###,##0}")})
        Me.GV1_TOT_AMT.Width = 91
        Me.Localizer1.SetWordID(Me.GV1_TOT_AMT, "비용금액")
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "###,###,###,###,###,##0;(###,###,###,###,###,##0)"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'GV1_CUSTOM_DTL
        '
        Me.GV1_CUSTOM_DTL.Caption = "커스터마이즈 내용"
        Me.GV1_CUSTOM_DTL.FieldName = "CUSTOM_DTL"
        Me.GV1_CUSTOM_DTL.Name = "GV1_CUSTOM_DTL"
        Me.GV1_CUSTOM_DTL.Visible = True
        Me.GV1_CUSTOM_DTL.VisibleIndex = 2
        Me.GV1_CUSTOM_DTL.Width = 202
        Me.Localizer1.SetWordID(Me.GV1_CUSTOM_DTL, "커스터마이즈 내용")
        '
        'GV1_REQUESTOR
        '
        Me.GV1_REQUESTOR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQUESTOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQUESTOR.Caption = "요청자"
        Me.GV1_REQUESTOR.FieldName = "REQUESTOR"
        Me.GV1_REQUESTOR.Name = "GV1_REQUESTOR"
        Me.Localizer1.SetWordID(Me.GV1_REQUESTOR, "요청자")
        '
        'GV1_PROFITS
        '
        Me.GV1_PROFITS.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PROFITS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_PROFITS.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PROFITS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_PROFITS.Caption = "수익금액"
        Me.GV1_PROFITS.ColumnEdit = Me.RepositoryItemTextEdit8
        Me.GV1_PROFITS.FieldName = "PROFITS"
        Me.GV1_PROFITS.Name = "GV1_PROFITS"
        Me.GV1_PROFITS.OptionsColumn.AllowEdit = False
        Me.GV1_PROFITS.OptionsColumn.ReadOnly = True
        Me.GV1_PROFITS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PROFITS", "{0:###,###,###,###,##0}")})
        Me.GV1_PROFITS.Visible = True
        Me.GV1_PROFITS.VisibleIndex = 3
        Me.GV1_PROFITS.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_PROFITS, "수익금액")
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "###,###,###,###,###,##0;(###,###,###,###,###,##0)"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "#,##0.00"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.TOT_AMT, "0")
        Me.Localizer1.SetWordID(Me.PROFITS, "0")
        Me.Localizer1.SetWordID(Me.Label12, "상세")
        Me.Localizer1.SetWordID(Me.CUSTOM_YMD, "")
        Me.Localizer1.SetWordID(Me.CUSTOM_DTL, "")
        Me.Localizer1.SetWordID(Me.Label51, "계약금액")
        Me.Localizer1.SetWordID(Me.Label34, "수익금액")
        Me.Localizer1.SetWordID(Me.DOWN_PAY, "0")
        Me.Localizer1.SetWordID(Me.Label50, "비용금액")
        Me.Localizer1.SetWordID(Me.DEVELOPER, "")
        Me.Localizer1.SetWordID(Me.REQUESTOR, "")
        Me.Localizer1.SetWordID(Me.lbl_FARE_NM, "개발자")
        Me.Localizer1.SetWordID(Me.MNGT_NO, "")
        Me.Localizer1.SetWordID(Me.lbl_FARE_GRP_CD, "견적번호")
        Me.Localizer1.SetWordID(Me.일자, "일자")
        Me.Localizer1.SetWordID(Me.Label4, "요청자")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnPrint, "&Print")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.btnDelete, "&Delete")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.Panel1, "")
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        Me.Localizer1.SetWordID(Me.OLD_REQ_USR, "")
        Me.Localizer1.SetWordID(Me.OLD_CUST_CD, "")
        Me.Localizer1.SetWordID(Me.CUST_PIC_LIST, "--Select--")
        Me.Localizer1.SetWordID(Me.CUST_LIST, "--Select--")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.CUST_CD, "")
        Me.Localizer1.SetWordID(Me.Label37, "거래처")
        Me.Localizer1.SetWordID(Me.XtraTabControl1, "")
        Me.Localizer1.SetWordID(Me.XtraTabPage1, "비용 사용내역")
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GV2_CUST_ITEM, "항목")
        Me.Localizer1.SetWordID(Me.GV2_CUST_DTL, "내용")
        Me.Localizer1.SetWordID(Me.GV2_CUST_COST, "금액")
        Me.Localizer1.SetWordID(Me.GV2_SEQ, "SEQ")
        Me.Localizer1.SetWordID(Me.GV2_MNGT_NO, "견적번호")
        Me.Localizer1.SetWordID(Me.XtraTabPage2, "자금 집행계획")
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        Me.Localizer1.SetWordID(Me.WG3, "")
        Me.Localizer1.SetWordID(Me.GV3_FUND_ITEM, "항목")
        Me.Localizer1.SetWordID(Me.GV3_ISSUED_YMD, "계산서발행일")
        Me.Localizer1.SetWordID(Me.GV3_SALES_VAL, "매출 금액")
        Me.Localizer1.SetWordID(Me.GV3_BUY_VAL, "매입 금액")
        Me.Localizer1.SetWordID(Me.GV3_FUND_RMK, "비고")
        Me.Localizer1.SetWordID(Me.GV3_SEQ, "SEQ")
        Me.Localizer1.SetWordID(Me.GV3_MNGT_NO, "견적번호")
        Me.Localizer1.SetWordID(Me.XtraTabPage3, "견적서")
        Me.Localizer1.SetWordID(Me.WG4, "")
        Me.Localizer1.SetWordID(Me.GV4_ESTM_YMD, "일자")
        Me.Localizer1.SetWordID(Me.GV4_ESTM_COST, "금액")
        Me.Localizer1.SetWordID(Me.GV4_ESTM_RMK, "비고")
        Me.Localizer1.SetWordID(Me.GV4_SEQ, "SEQ")
        Me.Localizer1.SetWordID(Me.GV4_MNGT_NO, "견적번호")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_CUSTOM_YMD, "일자")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "견적번호")
        Me.Localizer1.SetWordID(Me.GV1_DOWN_PAY, "계약금액")
        Me.Localizer1.SetWordID(Me.GV1_SEQ, "순번")
        Me.Localizer1.SetWordID(Me.GV1_DEVELOPER, "개발자")
        Me.Localizer1.SetWordID(Me.GV1_TOT_AMT, "비용금액")
        Me.Localizer1.SetWordID(Me.GV1_CUSTOM_DTL, "커스터마이즈 내용")
        Me.Localizer1.SetWordID(Me.GV1_REQUESTOR, "요청자")
        Me.Localizer1.SetWordID(Me.GV1_PROFITS, "수익금액")
        '
        'CrmCustomize
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1010, 640)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "CrmCustomize"
        Me.Text = "커스터마이즈 상세"
        Me.Localizer1.SetWordID(Me, "커스터마이즈 상세")
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.CUST_PIC_LIST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUST_LIST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.WG4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4_DateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNew As YJIT.SC.UI.SCControls.Button
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents REQUESTOR As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents lbl_FARE_NM As YJIT.SC.UI.SCControls.Label
    Friend WithEvents MNGT_NO As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents lbl_FARE_GRP_CD As YJIT.SC.UI.SCControls.Label
    Friend WithEvents 일자 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents DEVELOPER As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Public WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDelete As YJIT.SC.UI.SCControls.Button
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Public WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_CUSTOM_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_DateEdit As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents GV1_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DOWN_PAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DEVELOPER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TOT_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUSTOM_DTL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQUESTOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROFITS As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents CUST_CD As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents CUST_NM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label37 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Public WithEvents OLD_REQ_USR As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents OLD_CUST_CD As YJIT.SC.UI.SCControls.TextBox
    Public WithEvents CUST_PIC_LIST As DevExpress.XtraEditors.LookUpEdit
    Public WithEvents CUST_LIST As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnPrint As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Public WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Public WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV2_CUST_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_CUST_DTL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_CUST_COST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents WG3 As YJIT.SC.UI.SCControls.WebGrid
    Public WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV3_FUND_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_ISSUED_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_SALES_VAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_BUY_VAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_FUND_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents WG4 As YJIT.SC.UI.SCControls.WebGrid
    Public WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV4_ESTM_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_ESTM_COST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_ESTM_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label51 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label50 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents CUSTOM_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label34 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents DOWN_PAY As YJIT.SC.UI.SCControls.NumericTextBox
    Friend WithEvents Label12 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents CUSTOM_DTL As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents TOT_AMT As YJIT.SC.UI.SCControls.NumericTextBox
    Friend WithEvents PROFITS As YJIT.SC.UI.SCControls.NumericTextBox
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
