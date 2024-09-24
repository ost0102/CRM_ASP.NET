<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmTaxMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmTaxMgt))
        Me.RepositoryItemDateBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.S_CUST_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.CUST_LOC_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_SALESCD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.S_DEPTCD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.S_PRJCD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.S_DEPTNM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_TITLE = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_CRMM = New YJIT.SC.UI.SCControls.MaskedTextBox()
        Me.S_BANK_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_MODIFYGB = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_SALESNM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.Label12 = New YJIT.SC.UI.SCControls.Label()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.Label32 = New YJIT.SC.UI.SCControls.Label()
        Me.Label11 = New YJIT.SC.UI.SCControls.Label()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_REGNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_NAME2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEPTNM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INDIVIDUAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SINGLEPUB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CTRT_STRT_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_ISSUE_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MODIFYGB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_BANK_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_BANK_DAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_BILL_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV1_BILL_VAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TOT_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_EMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SSALESNM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV2_REGNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CUST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_NAME2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_CRDT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_BANK_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_BANK_DAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_BILL_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV2_BILL_VAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_TOT_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_E_MAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_SSALESNM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.WG3 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.iconImages = New DevExpress.Utils.ImageCollection()
        Me.Timer1 = New System.Windows.Forms.Timer()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnSearch
        '
        Me.btnSearch.Action = "SearchData"
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1169, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 24)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 5)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1244, 32)
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
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.GridColumn1, "순번")
        Me.Localizer1.SetWordID(Me.GridColumn2, "사이트명")
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처유형")
        Me.Localizer1.SetWordID(Me.GridColumn4, "담당자")
        Me.Localizer1.SetWordID(Me.GridColumn5, "전화")
        Me.Localizer1.SetWordID(Me.GridColumn6, "DB IP")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.S_CUST_CD, "")
        Me.Localizer1.SetWordID(Me.S_SALESCD, "")
        Me.Localizer1.SetWordID(Me.S_DEPTCD, "")
        Me.Localizer1.SetWordID(Me.S_PRJCD, "")
        Me.Localizer1.SetWordID(Me.S_CRMM, "")
        Me.Localizer1.SetWordID(Me.S_BANK_YN, "--Select--")
        Me.Localizer1.SetWordID(Me.S_MODIFYGB, "--Select--")
        Me.Localizer1.SetWordID(Me.Label12, "최근 입금일")
        Me.Localizer1.SetWordID(Me.Label4, "프로젝트")
        Me.Localizer1.SetWordID(Me.Label1, "자동이체 여부")
        Me.Localizer1.SetWordID(Me.Label2, "귀속 부서")
        Me.Localizer1.SetWordID(Me.Label32, "납부일")
        Me.Localizer1.SetWordID(Me.Label11, "영업 사원")
        Me.Localizer1.SetWordID(Me.Label3, "거래처")
        Me.Localizer1.SetWordID(Me.XtraTabControl1, "")
        Me.Localizer1.SetWordID(Me.XtraTabPage1, "세금계산서 발행(예상)")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_REGNO, "사업자 번호")
        Me.Localizer1.SetWordID(Me.GV1_CUST, "거래처 코드")
        Me.Localizer1.SetWordID(Me.GV1_NAME2, "거래처 명")
        Me.Localizer1.SetWordID(Me.GV1_DEPTNM, "귀속 본부")
        Me.Localizer1.SetWordID(Me.GV1_TITLE, "프로젝트")
        Me.Localizer1.SetWordID(Me.GV1_INDIVIDUAL, "개별발행")
        Me.Localizer1.SetWordID(Me.GV1_SINGLEPUB, "단발발행")
        Me.Localizer1.SetWordID(Me.GV1_CTRT_STRT_YMD, "계약일자")
        Me.Localizer1.SetWordID(Me.GV1_ISSUE_YMD, "발행일자")
        Me.Localizer1.SetWordID(Me.GV1_MODIFYGB, "변경")
        Me.Localizer1.SetWordID(Me.GV1_BANK_YN, "자동이체 여부")
        Me.Localizer1.SetWordID(Me.GV1_BANK_DAY, "자동이체 일자")
        Me.Localizer1.SetWordID(Me.GV1_BILL_AMT, "공급가액")
        Me.Localizer1.SetWordID(Me.GV1_BILL_VAT, "부가세")
        Me.Localizer1.SetWordID(Me.GV1_TOT_AMT, "합계")
        Me.Localizer1.SetWordID(Me.GV1_EMAIL, "거래처 이메일")
        Me.Localizer1.SetWordID(Me.GV1_SSALESNM, "영업사원")
        Me.Localizer1.SetWordID(Me.GridColumn24, "거래처 주소")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "비고")
        Me.Localizer1.SetWordID(Me.XtraTabPage2, "세금계산서 발행 (상태)")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GV2_REGNO, "사업자 번호")
        Me.Localizer1.SetWordID(Me.GV2_CUST, "거래처 코드")
        Me.Localizer1.SetWordID(Me.GV2_NAME2, "거래처 명")
        Me.Localizer1.SetWordID(Me.GridColumn10, "귀속 본부")
        Me.Localizer1.SetWordID(Me.GridColumn11, "프로젝트")
        Me.Localizer1.SetWordID(Me.GridColumn14, "계약일자")
        Me.Localizer1.SetWordID(Me.GV2_CRDT, "발행일자")
        Me.Localizer1.SetWordID(Me.GV2_BANK_YN, "자동이체 여부")
        Me.Localizer1.SetWordID(Me.GV2_BANK_DAY, "자동이체 일자")
        Me.Localizer1.SetWordID(Me.GV2_BILL_AMT, "공급가액")
        Me.Localizer1.SetWordID(Me.GV2_BILL_VAT, "부가세")
        Me.Localizer1.SetWordID(Me.GV2_TOT_AMT, "합계")
        Me.Localizer1.SetWordID(Me.GV2_E_MAIL, "거래처 이메일")
        Me.Localizer1.SetWordID(Me.GV2_SSALESNM, "영업사원")
        Me.Localizer1.SetWordID(Me.XtraTabPage3, "세금계산서 발행 (차이)")
        Me.Localizer1.SetWordID(Me.WG3, "")
        Me.Localizer1.SetWordID(Me.GridColumn7, "사업자 번호")
        Me.Localizer1.SetWordID(Me.GridColumn8, "거래처 코드")
        Me.Localizer1.SetWordID(Me.GridColumn9, "거래처 명")
        Me.Localizer1.SetWordID(Me.GridColumn12, "귀속 본부")
        Me.Localizer1.SetWordID(Me.GridColumn13, "프로젝트")
        Me.Localizer1.SetWordID(Me.GridColumn15, "계약일자")
        Me.Localizer1.SetWordID(Me.GridColumn16, "발행일자")
        Me.Localizer1.SetWordID(Me.GridColumn17, "자동이체 여부")
        Me.Localizer1.SetWordID(Me.GridColumn18, "자동이체 일자")
        Me.Localizer1.SetWordID(Me.GridColumn19, "공급가액")
        Me.Localizer1.SetWordID(Me.GridColumn20, "부가세")
        Me.Localizer1.SetWordID(Me.GridColumn21, "합계")
        Me.Localizer1.SetWordID(Me.GridColumn22, "거래처 이메일")
        Me.Localizer1.SetWordID(Me.GridColumn23, "영업사원")
        Me.Localizer1.SetWordID(Me.GridColumn25, "차이")
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.S_CUST_CD)
        Me.PanelControl1.Controls.Add(Me.CUST_LOC_NM)
        Me.PanelControl1.Controls.Add(Me.S_SALESCD)
        Me.PanelControl1.Controls.Add(Me.S_DEPTCD)
        Me.PanelControl1.Controls.Add(Me.S_PRJCD)
        Me.PanelControl1.Controls.Add(Me.S_DEPTNM)
        Me.PanelControl1.Controls.Add(Me.S_TITLE)
        Me.PanelControl1.Controls.Add(Me.S_CRMM)
        Me.PanelControl1.Controls.Add(Me.S_BANK_YN)
        Me.PanelControl1.Controls.Add(Me.S_MODIFYGB)
        Me.PanelControl1.Controls.Add(Me.S_SALESNM)
        Me.PanelControl1.Controls.Add(Me.Label12)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label32)
        Me.PanelControl1.Controls.Add(Me.Label11)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 43)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1244, 83)
        Me.PanelControl1.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'S_CUST_CD
        '
        Me.S_CUST_CD.AlwaysSetDisplayParams = False
        Me.S_CUST_CD.AutoSuggestion = False
        Me.S_CUST_CD.BorderColor = System.Drawing.Color.Silver
        Me.S_CUST_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_CUST_CD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.S_CUST_CD.CodeType = "YJIT.CodeService.DLCustomer"
        Me.S_CUST_CD.DataParams = ""
        Me.S_CUST_CD.DefVal = ""
        Me.S_CUST_CD.DisplayParams = "Code:@S_CUST_CD,NAME:@CUST_LOC_NM"
        Me.S_CUST_CD.EditPopup = ""
        Me.S_CUST_CD.IconVisible = True
        Me.S_CUST_CD.IsDataStateAware = True
        Me.S_CUST_CD.KeepIntegrity = True
        Me.S_CUST_CD.Location = New System.Drawing.Point(753, 30)
        Me.S_CUST_CD.Name = "S_CUST_CD"
        Me.S_CUST_CD.NextFocus = "S_BANK_YN"
        Me.S_CUST_CD.RequiredFor = ""
        Me.S_CUST_CD.SearchPopup = "CodeMaster"
        Me.S_CUST_CD.Size = New System.Drawing.Size(87, 22)
        Me.S_CUST_CD.SuppressValidateCode = False
        Me.S_CUST_CD.TabIndex = 289
        Me.S_CUST_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_CUST_CD.ValidateKeys = "KEY:@S_CUST_CD"
        '
        'CUST_LOC_NM
        '
        Me.CUST_LOC_NM.AutoEllipsis = True
        Me.CUST_LOC_NM.BorderColor = System.Drawing.Color.Silver
        Me.CUST_LOC_NM.LabelFor = Nothing
        Me.CUST_LOC_NM.Location = New System.Drawing.Point(843, 30)
        Me.CUST_LOC_NM.Name = "CUST_LOC_NM"
        Me.CUST_LOC_NM.Size = New System.Drawing.Size(166, 22)
        Me.CUST_LOC_NM.TabIndex = 287
        Me.CUST_LOC_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'S_SALESCD
        '
        Me.S_SALESCD.AlwaysSetDisplayParams = False
        Me.S_SALESCD.AutoSuggestion = False
        Me.S_SALESCD.BorderColor = System.Drawing.Color.Silver
        Me.S_SALESCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_SALESCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.S_SALESCD.CodeType = "YJIT.CodeService.DLSalse"
        Me.S_SALESCD.DataParams = "Type:''"
        Me.S_SALESCD.DefVal = ""
        Me.S_SALESCD.DisplayParams = "CODE:@S_SALESCD,NAME:@S_SALESNM"
        Me.S_SALESCD.EditPopup = ""
        Me.S_SALESCD.IconVisible = True
        Me.S_SALESCD.IsDataStateAware = True
        Me.S_SALESCD.KeepIntegrity = True
        Me.S_SALESCD.Location = New System.Drawing.Point(401, 30)
        Me.S_SALESCD.Name = "S_SALESCD"
        Me.S_SALESCD.NextFocus = "S_CUST_CD"
        Me.S_SALESCD.RequiredFor = ""
        Me.S_SALESCD.SearchPopup = "CodeMaster"
        Me.S_SALESCD.Size = New System.Drawing.Size(87, 22)
        Me.S_SALESCD.SuppressValidateCode = False
        Me.S_SALESCD.TabIndex = 284
        Me.S_SALESCD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_SALESCD.ValidateKeys = "KEY:@S_SALESCD"
        '
        'S_DEPTCD
        '
        Me.S_DEPTCD.AlwaysSetDisplayParams = False
        Me.S_DEPTCD.AutoSuggestion = False
        Me.S_DEPTCD.BorderColor = System.Drawing.Color.Silver
        Me.S_DEPTCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_DEPTCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.S_DEPTCD.CodeType = "YJIT.CodeService.DL_DEPT"
        Me.S_DEPTCD.DataParams = "Type:''"
        Me.S_DEPTCD.DefVal = ""
        Me.S_DEPTCD.DisplayParams = "CODE:@S_DEPTCD,NAME:@S_DEPTNM"
        Me.S_DEPTCD.EditPopup = ""
        Me.S_DEPTCD.IconVisible = True
        Me.S_DEPTCD.IsDataStateAware = True
        Me.S_DEPTCD.KeepIntegrity = True
        Me.S_DEPTCD.Location = New System.Drawing.Point(401, 5)
        Me.S_DEPTCD.Name = "S_DEPTCD"
        Me.S_DEPTCD.NextFocus = "S_PRJCD"
        Me.S_DEPTCD.RequiredFor = ""
        Me.S_DEPTCD.SearchPopup = "CodeMaster"
        Me.S_DEPTCD.Size = New System.Drawing.Size(87, 22)
        Me.S_DEPTCD.SuppressValidateCode = False
        Me.S_DEPTCD.TabIndex = 284
        Me.S_DEPTCD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DEPTCD.ValidateKeys = "KEY:@S_DEPTCD"
        '
        'S_PRJCD
        '
        Me.S_PRJCD.AlwaysSetDisplayParams = False
        Me.S_PRJCD.AutoSuggestion = False
        Me.S_PRJCD.BorderColor = System.Drawing.Color.Silver
        Me.S_PRJCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_PRJCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.S_PRJCD.CodeType = "YJIT.CodeService.DLProject"
        Me.S_PRJCD.DataParams = "Type:''"
        Me.S_PRJCD.DefVal = ""
        Me.S_PRJCD.DisplayParams = "CODE:@S_PRJCD,NAME:@S_TITLE"
        Me.S_PRJCD.EditPopup = ""
        Me.S_PRJCD.IconVisible = True
        Me.S_PRJCD.IsDataStateAware = True
        Me.S_PRJCD.KeepIntegrity = True
        Me.S_PRJCD.Location = New System.Drawing.Point(753, 5)
        Me.S_PRJCD.Name = "S_PRJCD"
        Me.S_PRJCD.NextFocus = "S_MODIFYGB"
        Me.S_PRJCD.RequiredFor = ""
        Me.S_PRJCD.SearchPopup = "CodeMaster"
        Me.S_PRJCD.Size = New System.Drawing.Size(87, 22)
        Me.S_PRJCD.SuppressValidateCode = False
        Me.S_PRJCD.TabIndex = 285
        Me.S_PRJCD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_PRJCD.ValidateKeys = "KEY:@S_PRJCD"
        '
        'S_DEPTNM
        '
        Me.S_DEPTNM.AutoEllipsis = True
        Me.S_DEPTNM.BorderColor = System.Drawing.Color.Silver
        Me.S_DEPTNM.LabelFor = Nothing
        Me.S_DEPTNM.Location = New System.Drawing.Point(491, 5)
        Me.S_DEPTNM.Name = "S_DEPTNM"
        Me.S_DEPTNM.Size = New System.Drawing.Size(166, 22)
        Me.S_DEPTNM.TabIndex = 282
        Me.S_DEPTNM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'S_TITLE
        '
        Me.S_TITLE.AutoEllipsis = True
        Me.S_TITLE.BorderColor = System.Drawing.Color.Silver
        Me.S_TITLE.LabelFor = Nothing
        Me.S_TITLE.Location = New System.Drawing.Point(843, 5)
        Me.S_TITLE.Name = "S_TITLE"
        Me.S_TITLE.Size = New System.Drawing.Size(166, 22)
        Me.S_TITLE.TabIndex = 282
        Me.S_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'S_CRMM
        '
        Me.S_CRMM.BorderColor = System.Drawing.Color.Silver
        Me.S_CRMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_CRMM.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.S_CRMM.DefVal = Nothing
        Me.S_CRMM.IsDataStateAware = True
        Me.S_CRMM.Location = New System.Drawing.Point(135, 5)
        Me.S_CRMM.Mask = "0000-00"
        Me.S_CRMM.Name = "S_CRMM"
        Me.S_CRMM.NextFocus = "S_DEPTCD"
        Me.S_CRMM.RequiredFor = ""
        Me.S_CRMM.Size = New System.Drawing.Size(61, 22)
        Me.S_CRMM.TabIndex = 281
        Me.S_CRMM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_CRMM.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.Localizer1.SetWordID(Me.S_CRMM, "")
        '
        'S_BANK_YN
        '
        Me.S_BANK_YN.CodeType = ""
        Me.S_BANK_YN.ColumnWidths = ""
        Me.S_BANK_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_BANK_YN.DataParams = ""
        Me.S_BANK_YN.DefVal = ""
        Me.S_BANK_YN.DisplayMember = "NAME"
        Me.S_BANK_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_BANK_YN.FormattingEnabled = True
        Me.S_BANK_YN.IsDataStateAware = True
        Me.S_BANK_YN.ItemDelimiter = ","
        Me.S_BANK_YN.ItemTextList = "ALL,Yes,No"
        Me.S_BANK_YN.ItemValueList = "A,Y,N"
        Me.S_BANK_YN.KeepIntegrity = True
        Me.S_BANK_YN.Location = New System.Drawing.Point(135, 55)
        Me.S_BANK_YN.Name = "S_BANK_YN"
        Me.S_BANK_YN.NextFocus = ""
        Me.S_BANK_YN.NullText = "--Select--"
        Me.S_BANK_YN.RequiredFor = ""
        Me.S_BANK_YN.SearchKeys = ""
        Me.S_BANK_YN.Size = New System.Drawing.Size(110, 22)
        Me.S_BANK_YN.TabIndex = 280
        Me.S_BANK_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_BANK_YN.ValueMember = "CODE"
        '
        'S_MODIFYGB
        '
        Me.S_MODIFYGB.CodeType = ""
        Me.S_MODIFYGB.ColumnWidths = ""
        Me.S_MODIFYGB.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.S_MODIFYGB.DataParams = ""
        Me.S_MODIFYGB.DefVal = ""
        Me.S_MODIFYGB.DisplayMember = "NAME"
        Me.S_MODIFYGB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_MODIFYGB.FormattingEnabled = True
        Me.S_MODIFYGB.IsDataStateAware = True
        Me.S_MODIFYGB.ItemDelimiter = ","
        Me.S_MODIFYGB.ItemTextList = "ALL,Yes,No"
        Me.S_MODIFYGB.ItemValueList = "A,Y,N"
        Me.S_MODIFYGB.KeepIntegrity = True
        Me.S_MODIFYGB.Location = New System.Drawing.Point(135, 30)
        Me.S_MODIFYGB.Name = "S_MODIFYGB"
        Me.S_MODIFYGB.NextFocus = "S_SALESCD"
        Me.S_MODIFYGB.NullText = "--Select--"
        Me.S_MODIFYGB.RequiredFor = ""
        Me.S_MODIFYGB.SearchKeys = ""
        Me.S_MODIFYGB.Size = New System.Drawing.Size(110, 22)
        Me.S_MODIFYGB.TabIndex = 280
        Me.S_MODIFYGB.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_MODIFYGB.ValueMember = "CODE"
        '
        'S_SALESNM
        '
        Me.S_SALESNM.AutoEllipsis = True
        Me.S_SALESNM.BorderColor = System.Drawing.Color.Silver
        Me.S_SALESNM.LabelFor = Nothing
        Me.S_SALESNM.Location = New System.Drawing.Point(492, 30)
        Me.S_SALESNM.Name = "S_SALESNM"
        Me.S_SALESNM.Size = New System.Drawing.Size(165, 22)
        Me.S_SALESNM.TabIndex = 278
        Me.S_SALESNM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoEllipsis = True
        Me.Label12.LabelFor = Nothing
        Me.Label12.Location = New System.Drawing.Point(25, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 22)
        Me.Label12.TabIndex = 274
        Me.Label12.Text = "청구월"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label12, "최근 입금일")
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(671, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 22)
        Me.Label4.TabIndex = 275
        Me.Label4.Text = "프로젝트"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label4, "")
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(28, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 275
        Me.Label1.Text = "자동이체 여부"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "")
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(310, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 22)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "귀속 부서"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "")
        '
        'Label32
        '
        Me.Label32.AutoEllipsis = True
        Me.Label32.LabelFor = Nothing
        Me.Label32.Location = New System.Drawing.Point(44, 30)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(87, 22)
        Me.Label32.TabIndex = 275
        Me.Label32.Text = "정보변경"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label32, "납부일")
        '
        'Label11
        '
        Me.Label11.AutoEllipsis = True
        Me.Label11.LabelFor = Nothing
        Me.Label11.Location = New System.Drawing.Point(307, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 22)
        Me.Label11.TabIndex = 277
        Me.Label11.Text = "영업 사원"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label11, "영업 사원")
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(668, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 22)
        Me.Label3.TabIndex = 276
        Me.Label3.Text = "거래처"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label3, "거래처")
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(6, 132)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1244, 630)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        Me.Localizer1.SetWordID(Me.XtraTabControl1, "")
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.WG1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1239, 604)
        Me.XtraTabPage1.Text = "세금계산서 발행(예상)"
        Me.Localizer1.SetWordID(Me.XtraTabPage1, "")
        '
        'WG1
        '
        Me.WG1.AllowClientBinding = True
        Me.WG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG1.DeleteRowConfirmation = True
        Me.WG1.DisplayCurrentRow = False
        Me.WG1.IsDataStateAware = True
        Me.WG1.Location = New System.Drawing.Point(3, 3)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3})
        Me.WG1.SaveLayout = False
        Me.WG1.Size = New System.Drawing.Size(1240, 597)
        Me.WG1.TabIndex = 248
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1, Me.GridView3})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_REGNO, Me.GV1_CUST, Me.GV1_NAME2, Me.GV1_DEPTNM, Me.GV1_TITLE, Me.GV1_INDIVIDUAL, Me.GV1_SINGLEPUB, Me.GV1_CTRT_STRT_YMD, Me.GV1_ISSUE_YMD, Me.GV1_MODIFYGB, Me.GV1_BANK_YN, Me.GV1_BANK_DAY, Me.GV1_BILL_AMT, Me.GV1_BILL_VAT, Me.GV1_TOT_AMT, Me.GV1_EMAIL, Me.GV1_SSALESNM, Me.GridColumn24, Me.GV1_RMK})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 40
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsPrint.AutoWidth = False
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.RowAutoHeight = True
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorzLines = False
        '
        'GV1_REGNO
        '
        Me.GV1_REGNO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REGNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REGNO.Caption = "사업자 번호"
        Me.GV1_REGNO.FieldName = "REGNO"
        Me.GV1_REGNO.Name = "GV1_REGNO"
        Me.GV1_REGNO.OptionsColumn.AllowEdit = False
        Me.GV1_REGNO.OptionsColumn.ReadOnly = True
        Me.GV1_REGNO.Visible = True
        Me.GV1_REGNO.VisibleIndex = 0
        Me.GV1_REGNO.Width = 120
        Me.Localizer1.SetWordID(Me.GV1_REGNO, "")
        '
        'GV1_CUST
        '
        Me.GV1_CUST.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST.Caption = "거래처 코드"
        Me.GV1_CUST.FieldName = "CUST"
        Me.GV1_CUST.Name = "GV1_CUST"
        Me.GV1_CUST.OptionsColumn.AllowEdit = False
        Me.GV1_CUST.OptionsColumn.ReadOnly = True
        Me.GV1_CUST.Visible = True
        Me.GV1_CUST.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GV1_CUST, "")
        '
        'GV1_NAME2
        '
        Me.GV1_NAME2.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_NAME2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_NAME2.Caption = "거래처 명"
        Me.GV1_NAME2.FieldName = "NAME2"
        Me.GV1_NAME2.Name = "GV1_NAME2"
        Me.GV1_NAME2.OptionsColumn.AllowEdit = False
        Me.GV1_NAME2.OptionsColumn.ReadOnly = True
        Me.GV1_NAME2.Visible = True
        Me.GV1_NAME2.VisibleIndex = 2
        Me.Localizer1.SetWordID(Me.GV1_NAME2, "")
        '
        'GV1_DEPTNM
        '
        Me.GV1_DEPTNM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DEPTNM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DEPTNM.Caption = "귀속 본부"
        Me.GV1_DEPTNM.FieldName = "DEPTNM"
        Me.GV1_DEPTNM.Name = "GV1_DEPTNM"
        Me.GV1_DEPTNM.OptionsColumn.AllowEdit = False
        Me.GV1_DEPTNM.OptionsColumn.ReadOnly = True
        Me.GV1_DEPTNM.Visible = True
        Me.GV1_DEPTNM.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV1_DEPTNM, "")
        '
        'GV1_TITLE
        '
        Me.GV1_TITLE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TITLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TITLE.Caption = "프로젝트"
        Me.GV1_TITLE.FieldName = "TITLE"
        Me.GV1_TITLE.Name = "GV1_TITLE"
        Me.GV1_TITLE.OptionsColumn.AllowEdit = False
        Me.GV1_TITLE.OptionsColumn.ReadOnly = True
        Me.GV1_TITLE.Visible = True
        Me.GV1_TITLE.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GV1_TITLE, "")
        '
        'GV1_INDIVIDUAL
        '
        Me.GV1_INDIVIDUAL.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INDIVIDUAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INDIVIDUAL.Caption = "개별발행"
        Me.GV1_INDIVIDUAL.FieldName = "INDIVIDUAL"
        Me.GV1_INDIVIDUAL.Name = "GV1_INDIVIDUAL"
        Me.GV1_INDIVIDUAL.OptionsColumn.AllowEdit = False
        Me.GV1_INDIVIDUAL.OptionsColumn.ReadOnly = True
        Me.GV1_INDIVIDUAL.Visible = True
        Me.GV1_INDIVIDUAL.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GV1_INDIVIDUAL, "")
        '
        'GV1_SINGLEPUB
        '
        Me.GV1_SINGLEPUB.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SINGLEPUB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SINGLEPUB.Caption = "단발발행"
        Me.GV1_SINGLEPUB.FieldName = "SINGLEPUB"
        Me.GV1_SINGLEPUB.Name = "GV1_SINGLEPUB"
        Me.GV1_SINGLEPUB.OptionsColumn.AllowEdit = False
        Me.GV1_SINGLEPUB.OptionsColumn.ReadOnly = True
        Me.GV1_SINGLEPUB.Visible = True
        Me.GV1_SINGLEPUB.VisibleIndex = 6
        Me.Localizer1.SetWordID(Me.GV1_SINGLEPUB, "")
        '
        'GV1_CTRT_STRT_YMD
        '
        Me.GV1_CTRT_STRT_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CTRT_STRT_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CTRT_STRT_YMD.Caption = "계약일자"
        Me.GV1_CTRT_STRT_YMD.FieldName = "CTRT_STRT_YMD"
        Me.GV1_CTRT_STRT_YMD.Name = "GV1_CTRT_STRT_YMD"
        Me.GV1_CTRT_STRT_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_CTRT_STRT_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_CTRT_STRT_YMD.Visible = True
        Me.GV1_CTRT_STRT_YMD.VisibleIndex = 7
        Me.Localizer1.SetWordID(Me.GV1_CTRT_STRT_YMD, "")
        '
        'GV1_ISSUE_YMD
        '
        Me.GV1_ISSUE_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_ISSUE_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_ISSUE_YMD.Caption = "발행일자"
        Me.GV1_ISSUE_YMD.FieldNameSortGroup = "ISSUE_YMD"
        Me.GV1_ISSUE_YMD.Name = "GV1_ISSUE_YMD"
        Me.GV1_ISSUE_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_ISSUE_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_ISSUE_YMD.Visible = True
        Me.GV1_ISSUE_YMD.VisibleIndex = 8
        Me.Localizer1.SetWordID(Me.GV1_ISSUE_YMD, "")
        '
        'GV1_MODIFYGB
        '
        Me.GV1_MODIFYGB.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MODIFYGB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MODIFYGB.Caption = "변경"
        Me.GV1_MODIFYGB.FieldName = "MODIFYGB"
        Me.GV1_MODIFYGB.Name = "GV1_MODIFYGB"
        Me.GV1_MODIFYGB.OptionsColumn.AllowEdit = False
        Me.GV1_MODIFYGB.OptionsColumn.ReadOnly = True
        Me.GV1_MODIFYGB.Visible = True
        Me.GV1_MODIFYGB.VisibleIndex = 9
        Me.Localizer1.SetWordID(Me.GV1_MODIFYGB, "")
        '
        'GV1_BANK_YN
        '
        Me.GV1_BANK_YN.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.GV1_BANK_YN.AppearanceHeader.Options.UseForeColor = True
        Me.GV1_BANK_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BANK_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BANK_YN.Caption = "자동이체 여부"
        Me.GV1_BANK_YN.FieldName = "BANK_YN"
        Me.GV1_BANK_YN.Name = "GV1_BANK_YN"
        Me.GV1_BANK_YN.OptionsColumn.AllowEdit = False
        Me.GV1_BANK_YN.OptionsColumn.ReadOnly = True
        Me.GV1_BANK_YN.Visible = True
        Me.GV1_BANK_YN.VisibleIndex = 10
        Me.GV1_BANK_YN.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_BANK_YN, "")
        '
        'GV1_BANK_DAY
        '
        Me.GV1_BANK_DAY.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.GV1_BANK_DAY.AppearanceHeader.Options.UseForeColor = True
        Me.GV1_BANK_DAY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BANK_DAY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BANK_DAY.Caption = "자동이체 일자"
        Me.GV1_BANK_DAY.FieldName = "BANK_DAY"
        Me.GV1_BANK_DAY.Name = "GV1_BANK_DAY"
        Me.GV1_BANK_DAY.OptionsColumn.AllowEdit = False
        Me.GV1_BANK_DAY.OptionsColumn.ReadOnly = True
        Me.GV1_BANK_DAY.Visible = True
        Me.GV1_BANK_DAY.VisibleIndex = 11
        Me.GV1_BANK_DAY.Width = 100
        Me.Localizer1.SetWordID(Me.GV1_BANK_DAY, "")
        '
        'GV1_BILL_AMT
        '
        Me.GV1_BILL_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BILL_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_BILL_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BILL_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BILL_AMT.Caption = "공급가액"
        Me.GV1_BILL_AMT.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GV1_BILL_AMT.FieldName = "BILL_AMT"
        Me.GV1_BILL_AMT.Name = "GV1_BILL_AMT"
        Me.GV1_BILL_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_BILL_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_BILL_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BILL_AMT", "{0:N0}")})
        Me.GV1_BILL_AMT.Visible = True
        Me.GV1_BILL_AMT.VisibleIndex = 12
        Me.Localizer1.SetWordID(Me.GV1_BILL_AMT, "")
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "{0:N0}"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'GV1_BILL_VAT
        '
        Me.GV1_BILL_VAT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_BILL_VAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_BILL_VAT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_BILL_VAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_BILL_VAT.Caption = "부가세"
        Me.GV1_BILL_VAT.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GV1_BILL_VAT.FieldName = "BILL_VAT"
        Me.GV1_BILL_VAT.Name = "GV1_BILL_VAT"
        Me.GV1_BILL_VAT.OptionsColumn.AllowEdit = False
        Me.GV1_BILL_VAT.OptionsColumn.ReadOnly = True
        Me.GV1_BILL_VAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BILL_VAT", "{0:N0}")})
        Me.GV1_BILL_VAT.Visible = True
        Me.GV1_BILL_VAT.VisibleIndex = 13
        Me.Localizer1.SetWordID(Me.GV1_BILL_VAT, "")
        '
        'GV1_TOT_AMT
        '
        Me.GV1_TOT_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TOT_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_TOT_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TOT_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TOT_AMT.Caption = "합계"
        Me.GV1_TOT_AMT.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GV1_TOT_AMT.FieldName = "TOT_AMT"
        Me.GV1_TOT_AMT.Name = "GV1_TOT_AMT"
        Me.GV1_TOT_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_TOT_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_TOT_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOT_AMT", "{0:N0}")})
        Me.GV1_TOT_AMT.Visible = True
        Me.GV1_TOT_AMT.VisibleIndex = 14
        Me.Localizer1.SetWordID(Me.GV1_TOT_AMT, "")
        '
        'GV1_EMAIL
        '
        Me.GV1_EMAIL.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_EMAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EMAIL.Caption = "거래처 이메일"
        Me.GV1_EMAIL.FieldName = "EMAIL"
        Me.GV1_EMAIL.Name = "GV1_EMAIL"
        Me.GV1_EMAIL.OptionsColumn.AllowEdit = False
        Me.GV1_EMAIL.OptionsColumn.ReadOnly = True
        Me.GV1_EMAIL.Visible = True
        Me.GV1_EMAIL.VisibleIndex = 15
        Me.Localizer1.SetWordID(Me.GV1_EMAIL, "")
        '
        'GV1_SSALESNM
        '
        Me.GV1_SSALESNM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SSALESNM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SSALESNM.Caption = "영업사원"
        Me.GV1_SSALESNM.FieldName = "SSALESNM"
        Me.GV1_SSALESNM.Name = "GV1_SSALESNM"
        Me.GV1_SSALESNM.OptionsColumn.AllowEdit = False
        Me.GV1_SSALESNM.OptionsColumn.ReadOnly = True
        Me.GV1_SSALESNM.Visible = True
        Me.GV1_SSALESNM.VisibleIndex = 16
        Me.Localizer1.SetWordID(Me.GV1_SSALESNM, "")
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn24.Caption = "거래처 주소"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.OptionsColumn.ReadOnly = True
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 17
        Me.Localizer1.SetWordID(Me.GridColumn24, "")
        '
        'GV1_RMK
        '
        Me.GV1_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RMK.Caption = "비고"
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.OptionsColumn.AllowEdit = False
        Me.GV1_RMK.OptionsColumn.ReadOnly = True
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 18
        Me.Localizer1.SetWordID(Me.GV1_RMK, "")
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.WG1
        Me.GridView3.Name = "GridView3"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.WG2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1239, 604)
        Me.XtraTabPage2.Text = "세금계산서 발행 (상태)"
        Me.Localizer1.SetWordID(Me.XtraTabPage2, "")
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG2.DeleteRowConfirmation = True
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(-1, 4)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit4})
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(1240, 597)
        Me.WG2.TabIndex = 249
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2, Me.GridView2})
        '
        'GV2
        '
        Me.GV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV2_REGNO, Me.GV2_CUST, Me.GV2_NAME2, Me.GridColumn10, Me.GridColumn11, Me.GridColumn14, Me.GV2_CRDT, Me.GV2_BANK_YN, Me.GV2_BANK_DAY, Me.GV2_BILL_AMT, Me.GV2_BILL_VAT, Me.GV2_TOT_AMT, Me.GV2_E_MAIL, Me.GV2_SSALESNM})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.IndicatorWidth = 40
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsPrint.AutoWidth = False
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.RowAutoHeight = True
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorzLines = False
        '
        'GV2_REGNO
        '
        Me.GV2_REGNO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_REGNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_REGNO.Caption = "사업자 번호"
        Me.GV2_REGNO.FieldName = "REGNO"
        Me.GV2_REGNO.Name = "GV2_REGNO"
        Me.GV2_REGNO.OptionsColumn.AllowEdit = False
        Me.GV2_REGNO.OptionsColumn.ReadOnly = True
        Me.GV2_REGNO.Visible = True
        Me.GV2_REGNO.VisibleIndex = 0
        Me.GV2_REGNO.Width = 120
        Me.Localizer1.SetWordID(Me.GV2_REGNO, "")
        '
        'GV2_CUST
        '
        Me.GV2_CUST.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CUST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUST.Caption = "거래처 코드"
        Me.GV2_CUST.FieldName = "CUST"
        Me.GV2_CUST.Name = "GV2_CUST"
        Me.GV2_CUST.OptionsColumn.AllowEdit = False
        Me.GV2_CUST.OptionsColumn.ReadOnly = True
        Me.GV2_CUST.Visible = True
        Me.GV2_CUST.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GV2_CUST, "")
        '
        'GV2_NAME2
        '
        Me.GV2_NAME2.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_NAME2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_NAME2.Caption = "거래처 명"
        Me.GV2_NAME2.FieldName = "NAME2"
        Me.GV2_NAME2.Name = "GV2_NAME2"
        Me.GV2_NAME2.OptionsColumn.AllowEdit = False
        Me.GV2_NAME2.OptionsColumn.ReadOnly = True
        Me.GV2_NAME2.Visible = True
        Me.GV2_NAME2.VisibleIndex = 2
        Me.Localizer1.SetWordID(Me.GV2_NAME2, "")
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "귀속 본부"
        Me.GridColumn10.FieldName = "DEPTNM"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GridColumn10, "")
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "프로젝트"
        Me.GridColumn11.FieldName = "TITLE"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GridColumn11, "")
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "계약일자"
        Me.GridColumn14.FieldName = "CTRT_STRT_YMD"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GridColumn14, "")
        '
        'GV2_CRDT
        '
        Me.GV2_CRDT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CRDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CRDT.Caption = "발행일자"
        Me.GV2_CRDT.FieldName = "CRDT"
        Me.GV2_CRDT.Name = "GV2_CRDT"
        Me.GV2_CRDT.OptionsColumn.AllowEdit = False
        Me.GV2_CRDT.OptionsColumn.ReadOnly = True
        Me.GV2_CRDT.Visible = True
        Me.GV2_CRDT.VisibleIndex = 6
        Me.Localizer1.SetWordID(Me.GV2_CRDT, "")
        '
        'GV2_BANK_YN
        '
        Me.GV2_BANK_YN.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.GV2_BANK_YN.AppearanceHeader.Options.UseForeColor = True
        Me.GV2_BANK_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_BANK_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_BANK_YN.Caption = "자동이체 여부"
        Me.GV2_BANK_YN.FieldName = "BANK_YN"
        Me.GV2_BANK_YN.Name = "GV2_BANK_YN"
        Me.GV2_BANK_YN.OptionsColumn.AllowEdit = False
        Me.GV2_BANK_YN.OptionsColumn.ReadOnly = True
        Me.GV2_BANK_YN.Visible = True
        Me.GV2_BANK_YN.VisibleIndex = 7
        Me.GV2_BANK_YN.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_BANK_YN, "")
        '
        'GV2_BANK_DAY
        '
        Me.GV2_BANK_DAY.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.GV2_BANK_DAY.AppearanceHeader.Options.UseForeColor = True
        Me.GV2_BANK_DAY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_BANK_DAY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_BANK_DAY.Caption = "자동이체 일자"
        Me.GV2_BANK_DAY.FieldName = "BANK_DAY"
        Me.GV2_BANK_DAY.Name = "GV2_BANK_DAY"
        Me.GV2_BANK_DAY.OptionsColumn.AllowEdit = False
        Me.GV2_BANK_DAY.OptionsColumn.ReadOnly = True
        Me.GV2_BANK_DAY.Visible = True
        Me.GV2_BANK_DAY.VisibleIndex = 8
        Me.GV2_BANK_DAY.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_BANK_DAY, "")
        '
        'GV2_BILL_AMT
        '
        Me.GV2_BILL_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_BILL_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_BILL_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_BILL_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_BILL_AMT.Caption = "공급가액"
        Me.GV2_BILL_AMT.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GV2_BILL_AMT.FieldName = "BILL_AMT"
        Me.GV2_BILL_AMT.Name = "GV2_BILL_AMT"
        Me.GV2_BILL_AMT.OptionsColumn.AllowEdit = False
        Me.GV2_BILL_AMT.OptionsColumn.ReadOnly = True
        Me.GV2_BILL_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BILL_AMT", "{0:N0}")})
        Me.GV2_BILL_AMT.Visible = True
        Me.GV2_BILL_AMT.VisibleIndex = 9
        Me.Localizer1.SetWordID(Me.GV2_BILL_AMT, "")
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatString = "{0:N0}"
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GV2_BILL_VAT
        '
        Me.GV2_BILL_VAT.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_BILL_VAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_BILL_VAT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_BILL_VAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_BILL_VAT.Caption = "부가세"
        Me.GV2_BILL_VAT.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GV2_BILL_VAT.FieldName = "BILL_VAT"
        Me.GV2_BILL_VAT.Name = "GV2_BILL_VAT"
        Me.GV2_BILL_VAT.OptionsColumn.AllowEdit = False
        Me.GV2_BILL_VAT.OptionsColumn.ReadOnly = True
        Me.GV2_BILL_VAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BILL_VAT", "{0:N0}")})
        Me.GV2_BILL_VAT.Visible = True
        Me.GV2_BILL_VAT.VisibleIndex = 10
        Me.Localizer1.SetWordID(Me.GV2_BILL_VAT, "")
        '
        'GV2_TOT_AMT
        '
        Me.GV2_TOT_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_TOT_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_TOT_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_TOT_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_TOT_AMT.Caption = "합계"
        Me.GV2_TOT_AMT.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GV2_TOT_AMT.FieldName = "TOT_AMT"
        Me.GV2_TOT_AMT.Name = "GV2_TOT_AMT"
        Me.GV2_TOT_AMT.OptionsColumn.AllowEdit = False
        Me.GV2_TOT_AMT.OptionsColumn.ReadOnly = True
        Me.GV2_TOT_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOT_AMT", "{0:N0}")})
        Me.GV2_TOT_AMT.Visible = True
        Me.GV2_TOT_AMT.VisibleIndex = 11
        Me.Localizer1.SetWordID(Me.GV2_TOT_AMT, "")
        '
        'GV2_E_MAIL
        '
        Me.GV2_E_MAIL.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_E_MAIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_E_MAIL.Caption = "거래처 이메일"
        Me.GV2_E_MAIL.FieldName = "E_MAIL"
        Me.GV2_E_MAIL.Name = "GV2_E_MAIL"
        Me.GV2_E_MAIL.OptionsColumn.AllowEdit = False
        Me.GV2_E_MAIL.OptionsColumn.ReadOnly = True
        Me.GV2_E_MAIL.Visible = True
        Me.GV2_E_MAIL.VisibleIndex = 12
        Me.GV2_E_MAIL.Width = 93
        Me.Localizer1.SetWordID(Me.GV2_E_MAIL, "")
        '
        'GV2_SSALESNM
        '
        Me.GV2_SSALESNM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_SSALESNM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_SSALESNM.Caption = "영업사원"
        Me.GV2_SSALESNM.FieldName = "SSALESNM"
        Me.GV2_SSALESNM.Name = "GV2_SSALESNM"
        Me.GV2_SSALESNM.OptionsColumn.AllowEdit = False
        Me.GV2_SSALESNM.OptionsColumn.ReadOnly = True
        Me.GV2_SSALESNM.Visible = True
        Me.GV2_SSALESNM.VisibleIndex = 13
        Me.Localizer1.SetWordID(Me.GV2_SSALESNM, "")
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.WG2
        Me.GridView2.Name = "GridView2"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.WG3)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1239, 604)
        Me.XtraTabPage3.Text = "세금계산서 발행 (차이)"
        Me.Localizer1.SetWordID(Me.XtraTabPage3, "")
        '
        'WG3
        '
        Me.WG3.AllowClientBinding = True
        Me.WG3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG3.DeleteRowConfirmation = True
        Me.WG3.DisplayCurrentRow = False
        Me.WG3.IsDataStateAware = True
        Me.WG3.Location = New System.Drawing.Point(-1, 4)
        Me.WG3.MainView = Me.GV3
        Me.WG3.Name = "WG3"
        Me.WG3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit5})
        Me.WG3.SaveLayout = False
        Me.WG3.Size = New System.Drawing.Size(1240, 597)
        Me.WG3.TabIndex = 250
        Me.WG3.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3, Me.GridView4})
        '
        'GV3
        '
        Me.GV3.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV3.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn12, Me.GridColumn13, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn25})
        Me.GV3.GridControl = Me.WG3
        Me.GV3.IndicatorWidth = 40
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsPrint.AutoWidth = False
        Me.GV3.OptionsView.ColumnAutoWidth = False
        Me.GV3.OptionsView.RowAutoHeight = True
        Me.GV3.OptionsView.ShowFooter = True
        Me.GV3.OptionsView.ShowGroupPanel = False
        Me.GV3.OptionsView.ShowHorzLines = False
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "사업자 번호"
        Me.GridColumn7.FieldName = "REGNO"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 120
        Me.Localizer1.SetWordID(Me.GridColumn7, "")
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "거래처 코드"
        Me.GridColumn8.FieldName = "CUST"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        Me.Localizer1.SetWordID(Me.GridColumn8, "")
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "거래처 명"
        Me.GridColumn9.FieldName = "NAME2"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GridColumn9, "")
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "귀속 본부"
        Me.GridColumn12.FieldName = "DEPTNM"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GridColumn12, "")
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "프로젝트"
        Me.GridColumn13.FieldName = "TITLE"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GridColumn13, "")
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "계약일자"
        Me.GridColumn15.FieldName = "CTRT_STRT_YMD"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 6
        Me.Localizer1.SetWordID(Me.GridColumn15, "")
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "발행일자"
        Me.GridColumn16.FieldName = "CRDT"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 7
        Me.Localizer1.SetWordID(Me.GridColumn16, "")
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.GridColumn17.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "자동이체 여부"
        Me.GridColumn17.FieldName = "BANK_YN"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 8
        Me.GridColumn17.Width = 100
        Me.Localizer1.SetWordID(Me.GridColumn17, "")
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.GridColumn18.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "자동이체 일자"
        Me.GridColumn18.FieldName = "BANK_DAY"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 9
        Me.GridColumn18.Width = 100
        Me.Localizer1.SetWordID(Me.GridColumn18, "")
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn19.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn19.Caption = "공급가액"
        Me.GridColumn19.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GridColumn19.FieldName = "BILL_AMT"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BILL_AMT", "{0:N0}")})
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 10
        Me.Localizer1.SetWordID(Me.GridColumn19, "")
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.DisplayFormat.FormatString = "{0:N0}"
        Me.RepositoryItemTextEdit5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn20.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn20.Caption = "부가세"
        Me.GridColumn20.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GridColumn20.FieldName = "BILL_VAT"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.OptionsColumn.ReadOnly = True
        Me.GridColumn20.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BILL_VAT", "{0:N0}")})
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 11
        Me.Localizer1.SetWordID(Me.GridColumn20, "")
        '
        'GridColumn21
        '
        Me.GridColumn21.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn21.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn21.Caption = "합계"
        Me.GridColumn21.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GridColumn21.FieldName = "TOT_AMT"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        Me.GridColumn21.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOT_AMT", "{0:N0}")})
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 12
        Me.Localizer1.SetWordID(Me.GridColumn21, "")
        '
        'GridColumn22
        '
        Me.GridColumn22.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn22.Caption = "거래처 이메일"
        Me.GridColumn22.FieldName = "EMAIL"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.ReadOnly = True
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 13
        Me.GridColumn22.Width = 93
        Me.Localizer1.SetWordID(Me.GridColumn22, "")
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn23.Caption = "영업사원"
        Me.GridColumn23.FieldName = "SSALESNM"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.OptionsColumn.ReadOnly = True
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 14
        Me.Localizer1.SetWordID(Me.GridColumn23, "")
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "차이"
        Me.GridColumn25.FieldName = "STATUS"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.OptionsColumn.ReadOnly = True
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GridColumn25, "")
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.WG3
        Me.GridView4.Name = "GridView4"
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
        'CrmTaxMgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 766)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "CrmTaxMgt"
        Me.Text = "세금계산서 예상 발행 조회"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
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
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RepositoryItemDateBoxEdit1 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents S_MODIFYGB As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents S_SALESNM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents Label12 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label32 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label11 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_BANK_YN As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_REGNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_NAME2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DEPTNM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INDIVIDUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SINGLEPUB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CTRT_STRT_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_ISSUE_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_MODIFYGB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BANK_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BANK_DAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BILL_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_BILL_VAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TOT_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_EMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SSALESNM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents S_CRMM As YJIT.SC.UI.SCControls.MaskedTextBox
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV2_REGNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_CUST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_NAME2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_CRDT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_BANK_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_BANK_DAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_BILL_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_BILL_VAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_TOT_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_E_MAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_SSALESNM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WG3 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents S_DEPTCD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents S_PRJCD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents S_TITLE As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents S_CUST_CD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents CUST_LOC_NM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents S_SALESCD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents S_DEPTNM As YJIT.SC.UI.SCControls.TextLabel
End Class
