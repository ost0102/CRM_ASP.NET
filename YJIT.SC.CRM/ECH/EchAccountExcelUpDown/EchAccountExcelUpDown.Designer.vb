<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EchAccountExcelUpDown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EchAccountExcelUpDown))
        Me.Gv2Num2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Gv2Num0 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemDateBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.xtcKLNET = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpACC = New DevExpress.XtraTab.XtraTabPage()
        Me.WG4 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV4_INV_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit4 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.GV4_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_AFR_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_MFCS_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV4_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.xtpAFR = New DevExpress.XtraTab.XtraTabPage()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV2_DOC_YYYYMM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_INV_YM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_CUST_CD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_CUST_LOC_NM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_KLNET_CUST_NM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV2_KL_HBL_COUNT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_SND_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_CUSTOMS_4CODE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_KLNET_ACC_AMT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_KLNET_COMMISSION = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.CHAIN = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV2_CHAIN_HBL_COUNT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV2_BL_CNT_CK = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSave = New YJIT.SC.UI.SCControls.Button()
        Me.lbl_FILE_PATH = New YJIT.SC.UI.SCControls.Label()
        Me.btnFile = New YJIT.SC.UI.SCControls.Button()
        Me.FILE_PATH = New YJIT.SC.UI.SCControls.TextBox()
        Me.xtpMFCS = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnApply = New YJIT.SC.UI.SCControls.Button()
        Me.btnUDRSave = New YJIT.SC.UI.SCControls.Button()
        Me.WG3 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV3_DOC_YYYYMM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_INV_YM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_CUSTOMS_4CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_CUST_LOC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_SND_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_RECV_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_DOC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_THIS_IPM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_BGM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_SND_RECV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_SND_BYTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_DOC_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_KEY_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_CHAIN_SND_BYTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_SND_CK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit2 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.btnUDRFile = New YJIT.SC.UI.SCControls.Button()
        Me.TextBox3 = New YJIT.SC.UI.SCControls.TextBox()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnMFCSSave = New YJIT.SC.UI.SCControls.Button()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_DOC_YYYYMM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_INV_YM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SND_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RECV_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DOC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SND_RECV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TOT_SND_BYTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_ACC_SND_BYTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_ACC_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_COMMISSION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REMARK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUSTOMS_4CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_LOC_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit3 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.btnMFCSFile = New YJIT.SC.UI.SCControls.Button()
        Me.TextBox1 = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnClear = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.SEARCH_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.S_END_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.S_ECH_CUST_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.S_ECH_4CODE = New YJIT.SC.UI.SCControls.TextBox()
        Me.S_ECH_CUST_NM = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.S_STR_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.btnSearchAll = New YJIT.SC.UI.SCControls.Button()
        Me.iconImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Gv2Num2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gv2Num0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcKLNET, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcKLNET.SuspendLayout()
        Me.xtpACC.SuspendLayout()
        CType(Me.WG4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpAFR.SuspendLayout()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.xtpMFCS.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gv2Num2
        '
        Me.Gv2Num2.AutoHeight = False
        Me.Gv2Num2.Mask.EditMask = "#,###,###,##0"
        Me.Gv2Num2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Gv2Num2.Mask.SaveLiteral = False
        Me.Gv2Num2.Mask.UseMaskAsDisplayFormat = True
        Me.Gv2Num2.Name = "Gv2Num2"
        '
        'Gv2Num0
        '
        Me.Gv2Num0.Mask.EditMask = "#,###,###,##0"
        Me.Gv2Num0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Gv2Num0.Mask.SaveLiteral = False
        Me.Gv2Num0.Mask.UseMaskAsDisplayFormat = True
        Me.Gv2Num0.Name = "Gv2Num0"
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
        Me.Localizer1.SetWordID(Me.GridColumn1, "순번")
        Me.Localizer1.SetWordID(Me.GridColumn2, "사이트명")
        Me.Localizer1.SetWordID(Me.GridColumn3, "거래처유형")
        Me.Localizer1.SetWordID(Me.GridColumn4, "담당자")
        Me.Localizer1.SetWordID(Me.GridColumn5, "전화")
        Me.Localizer1.SetWordID(Me.GridColumn6, "DB IP")
        Me.Localizer1.SetWordID(Me.xtcKLNET, "")
        Me.Localizer1.SetWordID(Me.xtpACC, "3. 업체별 정산내역")
        Me.Localizer1.SetWordID(Me.WG4, "")
        Me.Localizer1.SetWordID(Me.GV4_INV_YMD, "정산일자")
        Me.Localizer1.SetWordID(Me.GV4_CUST_CD, "거래처코드")
        Me.Localizer1.SetWordID(Me.GV4_AFR_AMT, "AFR 전송료")
        Me.Localizer1.SetWordID(Me.GV4_MFCS_AMT, "MFCS 전송료")
        Me.Localizer1.SetWordID(Me.GV4_CUST_NM, "거래처명")
        Me.Localizer1.SetWordID(Me.xtpAFR, "1. AFR")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GridBand7, "")
        Me.Localizer1.SetWordID(Me.GV2_DOC_YYYYMM, "전송년월")
        Me.Localizer1.SetWordID(Me.GV2_INV_YM, "청구년월")
        Me.Localizer1.SetWordID(Me.GV2_CUST_CD, "CRM 거래처 코드")
        Me.Localizer1.SetWordID(Me.GV2_CUST_LOC_NM, "CRM 거래처 명")
        Me.Localizer1.SetWordID(Me.GV2_KLNET_CUST_NM, "거래처 명")
        Me.Localizer1.SetWordID(Me.GridBand8, "KLNET")
        Me.Localizer1.SetWordID(Me.GV2_KL_HBL_COUNT, "HBL건수")
        Me.Localizer1.SetWordID(Me.GV2_SND_ID, "식별자")
        Me.Localizer1.SetWordID(Me.GV2_CUSTOMS_4CODE, "4코드")
        Me.Localizer1.SetWordID(Me.GV2_KLNET_ACC_AMT, "청구액")
        Me.Localizer1.SetWordID(Me.GV2_KLNET_COMMISSION, "수수료")
        Me.Localizer1.SetWordID(Me.GridBand9, "KTNET")
        Me.Localizer1.SetWordID(Me.CHAIN, "CHAIN")
        Me.Localizer1.SetWordID(Me.GV2_CHAIN_HBL_COUNT, "HBL건수")
        Me.Localizer1.SetWordID(Me.GV2_BL_CNT_CK, "CHECK")
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        Me.Localizer1.SetWordID(Me.lbl_FILE_PATH, "File Path")
        Me.Localizer1.SetWordID(Me.btnFile, "File")
        Me.Localizer1.SetWordID(Me.FILE_PATH, "")
        Me.Localizer1.SetWordID(Me.xtpMFCS, "2. MFCS")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.btnApply, "Se&arch")
        Me.Localizer1.SetWordID(Me.btnUDRSave, "&Save")
        Me.Localizer1.SetWordID(Me.WG3, "")
        Me.Localizer1.SetWordID(Me.GV3_DOC_YYYYMM, "전송년월")
        Me.Localizer1.SetWordID(Me.GV3_INV_YM, "청구년월")
        Me.Localizer1.SetWordID(Me.GV3_CUSTOMS_4CODE, "4코드")
        Me.Localizer1.SetWordID(Me.GV3_CUST_CD, "CRM 거래처코드")
        Me.Localizer1.SetWordID(Me.GV3_CUST_LOC_NM, "CRM 거래처명")
        Me.Localizer1.SetWordID(Me.GV3_SND_ID, "송신식별자")
        Me.Localizer1.SetWordID(Me.GV3_RECV_ID, "수신식별자")
        Me.Localizer1.SetWordID(Me.GV3_DOC_NM, "문서명")
        Me.Localizer1.SetWordID(Me.GV3_THIS_IPM, "THIS_IPM")
        Me.Localizer1.SetWordID(Me.GV3_BGM, "BGM")
        Me.Localizer1.SetWordID(Me.GV3_SND_RECV, "S/R")
        Me.Localizer1.SetWordID(Me.GV3_SND_BYTE, "BYTE")
        Me.Localizer1.SetWordID(Me.GV3_DOC_ITEM, "품목")
        Me.Localizer1.SetWordID(Me.GV3_KEY_NO, "KEY")
        Me.Localizer1.SetWordID(Me.GV3_CHAIN_SND_BYTE, "CHAIN BYTE")
        Me.Localizer1.SetWordID(Me.GV3_SND_CK, "전송체크")
        Me.Localizer1.SetWordID(Me.Label1, "File Path")
        Me.Localizer1.SetWordID(Me.btnUDRFile, "File")
        Me.Localizer1.SetWordID(Me.TextBox3, "")
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        Me.Localizer1.SetWordID(Me.btnMFCSSave, "&Save")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_DOC_YYYYMM, "전송년월")
        Me.Localizer1.SetWordID(Me.GV1_INV_YM, "청구년월")
        Me.Localizer1.SetWordID(Me.GV1_SND_ID, "송신식별자")
        Me.Localizer1.SetWordID(Me.GV1_RECV_ID, "수신식별자")
        Me.Localizer1.SetWordID(Me.GV1_DOC_NM, "문서명")
        Me.Localizer1.SetWordID(Me.GV1_SND_RECV, "S/R")
        Me.Localizer1.SetWordID(Me.GV1_TOT_SND_BYTE, "실전송량")
        Me.Localizer1.SetWordID(Me.GV1_ACC_SND_BYTE, "과금전송량")
        Me.Localizer1.SetWordID(Me.GV1_ACC_AMT, "사용료(KB*250원)")
        Me.Localizer1.SetWordID(Me.GV1_COMMISSION, "수수료")
        Me.Localizer1.SetWordID(Me.GV1_REMARK, "비고")
        Me.Localizer1.SetWordID(Me.GV1_CUSTOMS_4CODE, "4 코드")
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "거래처코드")
        Me.Localizer1.SetWordID(Me.GV1_CUST_LOC_NM, "거래처명")
        Me.Localizer1.SetWordID(Me.Label3, "File Path")
        Me.Localizer1.SetWordID(Me.btnMFCSFile, "File")
        Me.Localizer1.SetWordID(Me.TextBox1, "")
        Me.Localizer1.SetWordID(Me.btnClear, "Clear")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.SEARCH_TYPE, "Search Key")
        Me.Localizer1.SetWordID(Me.Label4, "~")
        Me.Localizer1.SetWordID(Me.S_END_YMD, "    -  -")
        Me.Localizer1.SetWordID(Me.S_ECH_CUST_CD, "")
        Me.Localizer1.SetWordID(Me.S_ECH_4CODE, "")
        Me.Localizer1.SetWordID(Me.S_ECH_CUST_NM, "")
        Me.Localizer1.SetWordID(Me.Label2, "거래처 코드 / 명 / 4CODE")
        Me.Localizer1.SetWordID(Me.S_STR_YMD, "    -  -")
        Me.Localizer1.SetWordID(Me.btnSearchAll, "Se&arch")
        '
        'xtcKLNET
        '
        Me.xtcKLNET.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcKLNET.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtcKLNET.Location = New System.Drawing.Point(5, 40)
        Me.xtcKLNET.Name = "xtcKLNET"
        Me.xtcKLNET.SelectedTabPage = Me.xtpACC
        Me.xtcKLNET.Size = New System.Drawing.Size(1038, 713)
        Me.xtcKLNET.TabIndex = 281
        Me.xtcKLNET.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpAFR, Me.xtpMFCS, Me.xtpACC})
        Me.Localizer1.SetWordID(Me.xtcKLNET, "")
        '
        'xtpACC
        '
        Me.xtpACC.Controls.Add(Me.WG4)
        Me.xtpACC.Name = "xtpACC"
        Me.xtpACC.Size = New System.Drawing.Size(1032, 686)
        Me.xtpACC.Text = "3. 업체별 정산내역"
        Me.Localizer1.SetWordID(Me.xtpACC, "")
        '
        'WG4
        '
        Me.WG4.AllowClientBinding = True
        Me.WG4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG4.DeleteRowConfirmation = True
        Me.WG4.DisplayCurrentRow = False
        Me.WG4.IsDataStateAware = True
        Me.WG4.Location = New System.Drawing.Point(2, 2)
        Me.WG4.MainView = Me.GV4
        Me.WG4.Name = "WG4"
        Me.WG4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit4, Me.RepositoryItemMemoEdit4, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit8})
        Me.WG4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG4.SaveLayout = True
        Me.WG4.Size = New System.Drawing.Size(1027, 680)
        Me.WG4.TabIndex = 107
        Me.WG4.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV4})
        '
        'GV4
        '
        Me.GV4.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV4.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV4_INV_YMD, Me.GV4_CUST_CD, Me.GV4_AFR_AMT, Me.GV4_MFCS_AMT, Me.GV4_CUST_NM})
        Me.GV4.GridControl = Me.WG4
        Me.GV4.IndicatorWidth = 50
        Me.GV4.LevelIndent = 1
        Me.GV4.Name = "GV4"
        Me.GV4.OptionsCustomization.AllowRowSizing = True
        Me.GV4.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV4.OptionsView.ColumnAutoWidth = False
        Me.GV4.OptionsView.RowAutoHeight = True
        Me.GV4.OptionsView.ShowFooter = True
        Me.GV4.OptionsView.ShowGroupPanel = False
        Me.GV4.OptionsView.ShowHorzLines = False
        Me.GV4.RowHeight = 10
        Me.GV4.ViewCaption = " 거래처 목록"
        '
        'GV4_INV_YMD
        '
        Me.GV4_INV_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_INV_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_INV_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_INV_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_INV_YMD.Caption = "정산일자"
        Me.GV4_INV_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit4
        Me.GV4_INV_YMD.FieldName = "INV_YMD"
        Me.GV4_INV_YMD.Name = "GV4_INV_YMD"
        Me.GV4_INV_YMD.OptionsColumn.AllowEdit = False
        Me.GV4_INV_YMD.OptionsColumn.ReadOnly = True
        Me.GV4_INV_YMD.Visible = True
        Me.GV4_INV_YMD.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GV4_INV_YMD, "정산일자")
        '
        'RepositoryItemDateBoxEdit4
        '
        Me.RepositoryItemDateBoxEdit4.AutoHeight = False
        Me.RepositoryItemDateBoxEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateBoxEdit4.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemDateBoxEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemDateBoxEdit4.Mask.SaveLiteral = False
        Me.RepositoryItemDateBoxEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateBoxEdit4.Name = "RepositoryItemDateBoxEdit4"
        '
        'GV4_CUST_CD
        '
        Me.GV4_CUST_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_CUST_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_CUST_CD.Caption = "거래처코드"
        Me.GV4_CUST_CD.FieldName = "CUST_CD"
        Me.GV4_CUST_CD.Name = "GV4_CUST_CD"
        Me.GV4_CUST_CD.OptionsColumn.AllowEdit = False
        Me.GV4_CUST_CD.OptionsColumn.ReadOnly = True
        Me.GV4_CUST_CD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CUST_CD", "", 0.0R)})
        Me.GV4_CUST_CD.Visible = True
        Me.GV4_CUST_CD.VisibleIndex = 1
        Me.GV4_CUST_CD.Width = 100
        Me.Localizer1.SetWordID(Me.GV4_CUST_CD, "")
        '
        'GV4_AFR_AMT
        '
        Me.GV4_AFR_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_AFR_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV4_AFR_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_AFR_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_AFR_AMT.Caption = "AFR 전송료"
        Me.GV4_AFR_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV4_AFR_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV4_AFR_AMT.FieldName = "AFR_AMT"
        Me.GV4_AFR_AMT.Name = "GV4_AFR_AMT"
        Me.GV4_AFR_AMT.OptionsColumn.AllowEdit = False
        Me.GV4_AFR_AMT.OptionsColumn.ReadOnly = True
        Me.GV4_AFR_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AFR_AMT", "{0:N0}")})
        Me.GV4_AFR_AMT.Visible = True
        Me.GV4_AFR_AMT.VisibleIndex = 3
        Me.GV4_AFR_AMT.Width = 150
        Me.Localizer1.SetWordID(Me.GV4_AFR_AMT, "")
        '
        'GV4_MFCS_AMT
        '
        Me.GV4_MFCS_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV4_MFCS_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV4_MFCS_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV4_MFCS_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV4_MFCS_AMT.Caption = "MFCS 전송료"
        Me.GV4_MFCS_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV4_MFCS_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV4_MFCS_AMT.FieldName = "MFCS_AMT"
        Me.GV4_MFCS_AMT.Name = "GV4_MFCS_AMT"
        Me.GV4_MFCS_AMT.OptionsColumn.AllowEdit = False
        Me.GV4_MFCS_AMT.OptionsColumn.ReadOnly = True
        Me.GV4_MFCS_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MFCS_AMT", "{0:N0}")})
        Me.GV4_MFCS_AMT.Visible = True
        Me.GV4_MFCS_AMT.VisibleIndex = 4
        Me.GV4_MFCS_AMT.Width = 150
        Me.Localizer1.SetWordID(Me.GV4_MFCS_AMT, "")
        '
        'GV4_CUST_NM
        '
        Me.GV4_CUST_NM.Caption = "거래처명"
        Me.GV4_CUST_NM.FieldName = "CUST_NM"
        Me.GV4_CUST_NM.Name = "GV4_CUST_NM"
        Me.GV4_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV4_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV4_CUST_NM.Visible = True
        Me.GV4_CUST_NM.VisibleIndex = 2
        Me.GV4_CUST_NM.Width = 250
        Me.Localizer1.SetWordID(Me.GV4_CUST_NM, "")
        '
        'RepositoryItemMemoEdit4
        '
        Me.RepositoryItemMemoEdit4.Name = "RepositoryItemMemoEdit4"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "n"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'xtpAFR
        '
        Me.xtpAFR.AutoScroll = True
        Me.xtpAFR.Controls.Add(Me.WG2)
        Me.xtpAFR.Controls.Add(Me.PanelControl3)
        Me.xtpAFR.Name = "xtpAFR"
        Me.xtpAFR.Size = New System.Drawing.Size(1032, 686)
        Me.xtpAFR.Text = "1. AFR"
        Me.Localizer1.SetWordID(Me.xtpAFR, "")
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG2.DeleteRowConfirmation = True
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(0, 44)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG2.SaveLayout = False
        Me.WG2.Size = New System.Drawing.Size(1032, 639)
        Me.WG2.TabIndex = 8
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand7, Me.GridBand8, Me.GridBand9, Me.CHAIN})
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.GV2_DOC_YYYYMM, Me.GV2_INV_YM, Me.GV2_CUST_CD, Me.GV2_CUST_LOC_NM, Me.GV2_KLNET_CUST_NM, Me.GV2_KL_HBL_COUNT, Me.GV2_SND_ID, Me.GV2_CUSTOMS_4CODE, Me.GV2_KLNET_ACC_AMT, Me.GV2_KLNET_COMMISSION, Me.GV2_CHAIN_HBL_COUNT, Me.GV2_BL_CNT_CK})
        Me.GV2.FooterPanelHeight = 40
        Me.GV2.GridControl = Me.WG2
        Me.GV2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KL_HBL_COUNT", Me.GV2_KL_HBL_COUNT, "{0:n0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.GV2.IndicatorWidth = 50
        Me.GV2.LevelIndent = 1
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GV2.OptionsCustomization.AllowBandMoving = False
        Me.GV2.OptionsCustomization.AllowColumnMoving = False
        Me.GV2.OptionsCustomization.AllowRowSizing = True
        Me.GV2.OptionsNavigation.AutoMoveRowFocus = False
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsPrint.AutoWidth = False
        Me.GV2.OptionsPrint.ExpandAllDetails = True
        Me.GV2.OptionsPrint.PrintDetails = True
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.RowAutoHeight = True
        Me.GV2.OptionsView.ShowFooter = True
        Me.GV2.OptionsView.ShowGroupPanel = False
        Me.GV2.OptionsView.ShowHorzLines = False
        Me.GV2.RowHeight = 10
        Me.GV2.ViewCaption = "AFR 정산자료"
        '
        'GridBand7
        '
        Me.GridBand7.Columns.Add(Me.GV2_DOC_YYYYMM)
        Me.GridBand7.Columns.Add(Me.GV2_INV_YM)
        Me.GridBand7.Columns.Add(Me.GV2_CUST_CD)
        Me.GridBand7.Columns.Add(Me.GV2_CUST_LOC_NM)
        Me.GridBand7.Columns.Add(Me.GV2_KLNET_CUST_NM)
        Me.GridBand7.Name = "GridBand7"
        Me.GridBand7.Width = 655
        Me.Localizer1.SetWordID(Me.GridBand7, "")
        '
        'GV2_DOC_YYYYMM
        '
        Me.GV2_DOC_YYYYMM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_DOC_YYYYMM.AppearanceCell.Options.UseFont = True
        Me.GV2_DOC_YYYYMM.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_DOC_YYYYMM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DOC_YYYYMM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_DOC_YYYYMM.AppearanceHeader.Options.UseFont = True
        Me.GV2_DOC_YYYYMM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_DOC_YYYYMM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_DOC_YYYYMM.Caption = "전송년월"
        Me.GV2_DOC_YYYYMM.FieldName = "DOC_YYYYMM"
        Me.GV2_DOC_YYYYMM.Name = "GV2_DOC_YYYYMM"
        Me.GV2_DOC_YYYYMM.OptionsColumn.AllowEdit = False
        Me.GV2_DOC_YYYYMM.OptionsColumn.AllowMove = False
        Me.GV2_DOC_YYYYMM.OptionsColumn.ReadOnly = True
        Me.GV2_DOC_YYYYMM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV2_DOC_YYYYMM.Visible = True
        Me.GV2_DOC_YYYYMM.Width = 80
        Me.Localizer1.SetWordID(Me.GV2_DOC_YYYYMM, "")
        '
        'GV2_INV_YM
        '
        Me.GV2_INV_YM.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_INV_YM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INV_YM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_INV_YM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_INV_YM.Caption = "청구년월"
        Me.GV2_INV_YM.FieldName = "INV_YM"
        Me.GV2_INV_YM.Name = "GV2_INV_YM"
        Me.GV2_INV_YM.OptionsColumn.AllowMove = False
        Me.GV2_INV_YM.Visible = True
        Me.Localizer1.SetWordID(Me.GV2_INV_YM, "")
        '
        'GV2_CUST_CD
        '
        Me.GV2_CUST_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_CUST_CD.AppearanceCell.Options.UseFont = True
        Me.GV2_CUST_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_CUST_CD.AppearanceHeader.Options.UseFont = True
        Me.GV2_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUST_CD.Caption = "CRM 거래처 코드"
        Me.GV2_CUST_CD.FieldName = "CUST_CD"
        Me.GV2_CUST_CD.Name = "GV2_CUST_CD"
        Me.GV2_CUST_CD.OptionsColumn.AllowMove = False
        Me.GV2_CUST_CD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV2_CUST_CD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.GV2_CUST_CD.Visible = True
        Me.GV2_CUST_CD.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_CUST_CD, "")
        '
        'GV2_CUST_LOC_NM
        '
        Me.GV2_CUST_LOC_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CUST_LOC_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUST_LOC_NM.Caption = "CRM 거래처 명"
        Me.GV2_CUST_LOC_NM.FieldName = "CUST_LOC_NM"
        Me.GV2_CUST_LOC_NM.Name = "GV2_CUST_LOC_NM"
        Me.GV2_CUST_LOC_NM.OptionsColumn.AllowEdit = False
        Me.GV2_CUST_LOC_NM.OptionsColumn.AllowMove = False
        Me.GV2_CUST_LOC_NM.OptionsColumn.ReadOnly = True
        Me.GV2_CUST_LOC_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV2_CUST_LOC_NM.Visible = True
        Me.GV2_CUST_LOC_NM.Width = 200
        Me.Localizer1.SetWordID(Me.GV2_CUST_LOC_NM, "")
        '
        'GV2_KLNET_CUST_NM
        '
        Me.GV2_KLNET_CUST_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_KLNET_CUST_NM.AppearanceCell.Options.UseFont = True
        Me.GV2_KLNET_CUST_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_KLNET_CUST_NM.AppearanceHeader.Options.UseFont = True
        Me.GV2_KLNET_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_KLNET_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_KLNET_CUST_NM.Caption = "거래처 명"
        Me.GV2_KLNET_CUST_NM.FieldName = "KLNET_CUST_NM"
        Me.GV2_KLNET_CUST_NM.Name = "GV2_KLNET_CUST_NM"
        Me.GV2_KLNET_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV2_KLNET_CUST_NM.OptionsColumn.AllowMove = False
        Me.GV2_KLNET_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV2_KLNET_CUST_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV2_KLNET_CUST_NM.Visible = True
        Me.GV2_KLNET_CUST_NM.Width = 200
        Me.Localizer1.SetWordID(Me.GV2_KLNET_CUST_NM, "")
        '
        'GridBand8
        '
        Me.GridBand8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand8.Caption = "KLNET"
        Me.GridBand8.Columns.Add(Me.GV2_KL_HBL_COUNT)
        Me.GridBand8.Columns.Add(Me.GV2_SND_ID)
        Me.GridBand8.Columns.Add(Me.GV2_CUSTOMS_4CODE)
        Me.GridBand8.Columns.Add(Me.GV2_KLNET_ACC_AMT)
        Me.GridBand8.Columns.Add(Me.GV2_KLNET_COMMISSION)
        Me.GridBand8.Name = "GridBand8"
        Me.GridBand8.Width = 430
        Me.Localizer1.SetWordID(Me.GridBand8, "")
        '
        'GV2_KL_HBL_COUNT
        '
        Me.GV2_KL_HBL_COUNT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_KL_HBL_COUNT.AppearanceCell.Options.UseFont = True
        Me.GV2_KL_HBL_COUNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_KL_HBL_COUNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_KL_HBL_COUNT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_KL_HBL_COUNT.AppearanceHeader.Options.UseFont = True
        Me.GV2_KL_HBL_COUNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_KL_HBL_COUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_KL_HBL_COUNT.Caption = "HBL건수"
        Me.GV2_KL_HBL_COUNT.ColumnEdit = Me.Gv2Num2
        Me.GV2_KL_HBL_COUNT.FieldName = "KL_HBL_COUNT"
        Me.GV2_KL_HBL_COUNT.Name = "GV2_KL_HBL_COUNT"
        Me.GV2_KL_HBL_COUNT.OptionsColumn.AllowEdit = False
        Me.GV2_KL_HBL_COUNT.OptionsColumn.AllowMove = False
        Me.GV2_KL_HBL_COUNT.OptionsColumn.ReadOnly = True
        Me.GV2_KL_HBL_COUNT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV2_KL_HBL_COUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KL_HBL_COUNT", "{0:0,0}")})
        Me.GV2_KL_HBL_COUNT.Visible = True
        Me.GV2_KL_HBL_COUNT.Width = 80
        Me.Localizer1.SetWordID(Me.GV2_KL_HBL_COUNT, "")
        '
        'GV2_SND_ID
        '
        Me.GV2_SND_ID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_SND_ID.AppearanceCell.Options.UseFont = True
        Me.GV2_SND_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_SND_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_SND_ID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_SND_ID.AppearanceHeader.Options.UseFont = True
        Me.GV2_SND_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_SND_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_SND_ID.Caption = "식별자"
        Me.GV2_SND_ID.FieldName = "SND_ID"
        Me.GV2_SND_ID.Name = "GV2_SND_ID"
        Me.GV2_SND_ID.OptionsColumn.AllowEdit = False
        Me.GV2_SND_ID.OptionsColumn.AllowMove = False
        Me.GV2_SND_ID.OptionsColumn.ReadOnly = True
        Me.GV2_SND_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV2_SND_ID.Visible = True
        Me.GV2_SND_ID.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_SND_ID, "")
        '
        'GV2_CUSTOMS_4CODE
        '
        Me.GV2_CUSTOMS_4CODE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_CUSTOMS_4CODE.AppearanceCell.Options.UseFont = True
        Me.GV2_CUSTOMS_4CODE.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_CUSTOMS_4CODE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUSTOMS_4CODE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_CUSTOMS_4CODE.AppearanceHeader.Options.UseFont = True
        Me.GV2_CUSTOMS_4CODE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CUSTOMS_4CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CUSTOMS_4CODE.Caption = "4코드"
        Me.GV2_CUSTOMS_4CODE.FieldName = "CUSTOMS_4CODE"
        Me.GV2_CUSTOMS_4CODE.Name = "GV2_CUSTOMS_4CODE"
        Me.GV2_CUSTOMS_4CODE.OptionsColumn.AllowMove = False
        Me.GV2_CUSTOMS_4CODE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV2_CUSTOMS_4CODE.Visible = True
        Me.GV2_CUSTOMS_4CODE.Width = 50
        Me.Localizer1.SetWordID(Me.GV2_CUSTOMS_4CODE, "")
        '
        'GV2_KLNET_ACC_AMT
        '
        Me.GV2_KLNET_ACC_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_KLNET_ACC_AMT.AppearanceCell.Options.UseFont = True
        Me.GV2_KLNET_ACC_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_KLNET_ACC_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_KLNET_ACC_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_KLNET_ACC_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV2_KLNET_ACC_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_KLNET_ACC_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_KLNET_ACC_AMT.Caption = "청구액"
        Me.GV2_KLNET_ACC_AMT.ColumnEdit = Me.Gv2Num0
        Me.GV2_KLNET_ACC_AMT.FieldName = "KLNET_ACC_AMT"
        Me.GV2_KLNET_ACC_AMT.Name = "GV2_KLNET_ACC_AMT"
        Me.GV2_KLNET_ACC_AMT.OptionsColumn.AllowEdit = False
        Me.GV2_KLNET_ACC_AMT.OptionsColumn.AllowMove = False
        Me.GV2_KLNET_ACC_AMT.OptionsColumn.ReadOnly = True
        Me.GV2_KLNET_ACC_AMT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV2_KLNET_ACC_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KLNET_ACC_AMT", "{0:0,0}", 0.0R)})
        Me.GV2_KLNET_ACC_AMT.Visible = True
        Me.GV2_KLNET_ACC_AMT.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_KLNET_ACC_AMT, "")
        '
        'GV2_KLNET_COMMISSION
        '
        Me.GV2_KLNET_COMMISSION.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_KLNET_COMMISSION.AppearanceCell.Options.UseFont = True
        Me.GV2_KLNET_COMMISSION.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_KLNET_COMMISSION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_KLNET_COMMISSION.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_KLNET_COMMISSION.AppearanceHeader.Options.UseFont = True
        Me.GV2_KLNET_COMMISSION.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_KLNET_COMMISSION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_KLNET_COMMISSION.Caption = "수수료"
        Me.GV2_KLNET_COMMISSION.ColumnEdit = Me.Gv2Num2
        Me.GV2_KLNET_COMMISSION.FieldName = "KLNET_COMMISSION"
        Me.GV2_KLNET_COMMISSION.Name = "GV2_KLNET_COMMISSION"
        Me.GV2_KLNET_COMMISSION.OptionsColumn.AllowEdit = False
        Me.GV2_KLNET_COMMISSION.OptionsColumn.AllowMove = False
        Me.GV2_KLNET_COMMISSION.OptionsColumn.ReadOnly = True
        Me.GV2_KLNET_COMMISSION.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV2_KLNET_COMMISSION.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KLNET_COMMISSION", "{0:0,0}", 0.0R)})
        Me.GV2_KLNET_COMMISSION.Visible = True
        Me.GV2_KLNET_COMMISSION.Width = 100
        Me.Localizer1.SetWordID(Me.GV2_KLNET_COMMISSION, "")
        '
        'GridBand9
        '
        Me.GridBand9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand9.Caption = "KTNET"
        Me.GridBand9.Name = "GridBand9"
        Me.GridBand9.Visible = False
        Me.GridBand9.Width = 100
        Me.Localizer1.SetWordID(Me.GridBand9, "")
        '
        'CHAIN
        '
        Me.CHAIN.AppearanceHeader.Options.UseTextOptions = True
        Me.CHAIN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CHAIN.Caption = "CHAIN"
        Me.CHAIN.Columns.Add(Me.GV2_CHAIN_HBL_COUNT)
        Me.CHAIN.Name = "CHAIN"
        Me.CHAIN.Width = 80
        Me.Localizer1.SetWordID(Me.CHAIN, "")
        '
        'GV2_CHAIN_HBL_COUNT
        '
        Me.GV2_CHAIN_HBL_COUNT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_CHAIN_HBL_COUNT.AppearanceCell.Options.UseFont = True
        Me.GV2_CHAIN_HBL_COUNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV2_CHAIN_HBL_COUNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV2_CHAIN_HBL_COUNT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV2_CHAIN_HBL_COUNT.AppearanceHeader.Options.UseFont = True
        Me.GV2_CHAIN_HBL_COUNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV2_CHAIN_HBL_COUNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV2_CHAIN_HBL_COUNT.Caption = "HBL건수"
        Me.GV2_CHAIN_HBL_COUNT.ColumnEdit = Me.Gv2Num0
        Me.GV2_CHAIN_HBL_COUNT.FieldName = "CHAIN_HBL_COUNT"
        Me.GV2_CHAIN_HBL_COUNT.Name = "GV2_CHAIN_HBL_COUNT"
        Me.GV2_CHAIN_HBL_COUNT.OptionsColumn.AllowEdit = False
        Me.GV2_CHAIN_HBL_COUNT.OptionsColumn.AllowMove = False
        Me.GV2_CHAIN_HBL_COUNT.OptionsColumn.ReadOnly = True
        Me.GV2_CHAIN_HBL_COUNT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV2_CHAIN_HBL_COUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CHAIN_HBL_COUNT", "{0:0,0}", 0.0R)})
        Me.GV2_CHAIN_HBL_COUNT.Visible = True
        Me.GV2_CHAIN_HBL_COUNT.Width = 80
        Me.Localizer1.SetWordID(Me.GV2_CHAIN_HBL_COUNT, "")
        '
        'GV2_BL_CNT_CK
        '
        Me.GV2_BL_CNT_CK.Caption = "CHECK"
        Me.GV2_BL_CNT_CK.FieldName = "BL_CNT_CK"
        Me.GV2_BL_CNT_CK.Name = "GV2_BL_CNT_CK"
        Me.GV2_BL_CNT_CK.OptionsColumn.AllowEdit = False
        Me.GV2_BL_CNT_CK.OptionsColumn.AllowMove = False
        Me.GV2_BL_CNT_CK.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV2_BL_CNT_CK, "")
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnSave)
        Me.PanelControl3.Controls.Add(Me.lbl_FILE_PATH)
        Me.PanelControl3.Controls.Add(Me.btnFile)
        Me.PanelControl3.Controls.Add(Me.FILE_PATH)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1032, 43)
        Me.PanelControl3.TabIndex = 7
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(941, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 99
        Me.btnSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnSave, "&Save")
        '
        'lbl_FILE_PATH
        '
        Me.lbl_FILE_PATH.AutoEllipsis = True
        Me.lbl_FILE_PATH.LabelFor = Nothing
        Me.lbl_FILE_PATH.Location = New System.Drawing.Point(9, 15)
        Me.lbl_FILE_PATH.Name = "lbl_FILE_PATH"
        Me.lbl_FILE_PATH.Size = New System.Drawing.Size(85, 22)
        Me.lbl_FILE_PATH.TabIndex = 96
        Me.lbl_FILE_PATH.Text = "File Path"
        Me.lbl_FILE_PATH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_FILE_PATH, "")
        '
        'btnFile
        '
        Me.btnFile.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnFile.Location = New System.Drawing.Point(500, 15)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(70, 22)
        Me.btnFile.TabIndex = 98
        Me.btnFile.Text = "File"
        Me.Localizer1.SetWordID(Me.btnFile, "File")
        '
        'FILE_PATH
        '
        Me.FILE_PATH.BorderColor = System.Drawing.Color.Silver
        Me.FILE_PATH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FILE_PATH.DefVal = ""
        Me.FILE_PATH.IsDataStateAware = True
        Me.FILE_PATH.Location = New System.Drawing.Point(100, 15)
        Me.FILE_PATH.MaxLength = 20
        Me.FILE_PATH.Name = "FILE_PATH"
        Me.FILE_PATH.NextFocus = "VOY"
        Me.FILE_PATH.Size = New System.Drawing.Size(394, 23)
        Me.FILE_PATH.TabIndex = 97
        Me.FILE_PATH.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'xtpMFCS
        '
        Me.xtpMFCS.AutoScroll = True
        Me.xtpMFCS.Controls.Add(Me.PanelControl1)
        Me.xtpMFCS.Controls.Add(Me.PanelControl4)
        Me.xtpMFCS.Name = "xtpMFCS"
        Me.xtpMFCS.Size = New System.Drawing.Size(1032, 686)
        Me.xtpMFCS.Text = "2. MFCS"
        Me.Localizer1.SetWordID(Me.xtpMFCS, "")
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btnApply)
        Me.PanelControl1.Controls.Add(Me.btnUDRSave)
        Me.PanelControl1.Controls.Add(Me.WG3)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.btnUDRFile)
        Me.PanelControl1.Controls.Add(Me.TextBox3)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1032, 415)
        Me.PanelControl1.TabIndex = 10
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnApply.Image = CType(resources.GetObject("btnApply.Image"), System.Drawing.Image)
        Me.btnApply.Location = New System.Drawing.Point(838, 14)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(87, 25)
        Me.btnApply.TabIndex = 107
        Me.btnApply.Text = "Apply Prss"
        Me.Localizer1.SetWordID(Me.btnApply, "Se&arch")
        '
        'btnUDRSave
        '
        Me.btnUDRSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUDRSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnUDRSave.Image = CType(resources.GetObject("btnUDRSave.Image"), System.Drawing.Image)
        Me.btnUDRSave.Location = New System.Drawing.Point(931, 13)
        Me.btnUDRSave.Name = "btnUDRSave"
        Me.btnUDRSave.Size = New System.Drawing.Size(75, 25)
        Me.btnUDRSave.TabIndex = 106
        Me.btnUDRSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnUDRSave, "&Save")
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
        Me.WG3.Location = New System.Drawing.Point(0, 46)
        Me.WG3.MainView = Me.GV3
        Me.WG3.Name = "WG3"
        Me.WG3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit2, Me.RepositoryItemMemoEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.WG3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG3.SaveLayout = True
        Me.WG3.Size = New System.Drawing.Size(1032, 369)
        Me.WG3.TabIndex = 105
        Me.WG3.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV3})
        '
        'GV3
        '
        Me.GV3.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV3.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV3_DOC_YYYYMM, Me.GV3_INV_YM, Me.GV3_CUSTOMS_4CODE, Me.GV3_CUST_CD, Me.GV3_CUST_LOC_NM, Me.GV3_SND_ID, Me.GV3_RECV_ID, Me.GV3_DOC_NM, Me.GV3_THIS_IPM, Me.GV3_BGM, Me.GV3_SND_RECV, Me.GV3_SND_BYTE, Me.GV3_DOC_ITEM, Me.GV3_KEY_NO, Me.GV3_CHAIN_SND_BYTE, Me.GV3_SND_CK})
        Me.GV3.GridControl = Me.WG3
        Me.GV3.IndicatorWidth = 70
        Me.GV3.LevelIndent = 1
        Me.GV3.Name = "GV3"
        Me.GV3.OptionsCustomization.AllowColumnMoving = False
        Me.GV3.OptionsCustomization.AllowRowSizing = True
        Me.GV3.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV3.OptionsView.ColumnAutoWidth = False
        Me.GV3.OptionsView.RowAutoHeight = True
        Me.GV3.OptionsView.ShowFooter = True
        Me.GV3.OptionsView.ShowGroupPanel = False
        Me.GV3.OptionsView.ShowHorzLines = False
        Me.GV3.RowHeight = 10
        Me.GV3.ViewCaption = " 거래처 목록"
        '
        'GV3_DOC_YYYYMM
        '
        Me.GV3_DOC_YYYYMM.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_DOC_YYYYMM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_DOC_YYYYMM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_DOC_YYYYMM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_DOC_YYYYMM.Caption = "전송년월"
        Me.GV3_DOC_YYYYMM.FieldName = "DOC_YYYYMM"
        Me.GV3_DOC_YYYYMM.Name = "GV3_DOC_YYYYMM"
        Me.GV3_DOC_YYYYMM.OptionsColumn.AllowEdit = False
        Me.GV3_DOC_YYYYMM.OptionsColumn.ReadOnly = True
        Me.GV3_DOC_YYYYMM.Visible = True
        Me.GV3_DOC_YYYYMM.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GV3_DOC_YYYYMM, "")
        '
        'GV3_INV_YM
        '
        Me.GV3_INV_YM.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_INV_YM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_INV_YM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_INV_YM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_INV_YM.Caption = "청구년월"
        Me.GV3_INV_YM.FieldName = "INV_YM"
        Me.GV3_INV_YM.Name = "GV3_INV_YM"
        Me.GV3_INV_YM.OptionsColumn.AllowEdit = False
        Me.GV3_INV_YM.OptionsColumn.ReadOnly = True
        Me.GV3_INV_YM.Visible = True
        Me.GV3_INV_YM.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GV3_INV_YM, "")
        '
        'GV3_CUSTOMS_4CODE
        '
        Me.GV3_CUSTOMS_4CODE.Caption = "4코드"
        Me.GV3_CUSTOMS_4CODE.FieldName = "CUSTOMS_4CODE"
        Me.GV3_CUSTOMS_4CODE.Name = "GV3_CUSTOMS_4CODE"
        Me.GV3_CUSTOMS_4CODE.OptionsColumn.AllowEdit = False
        Me.GV3_CUSTOMS_4CODE.OptionsColumn.ReadOnly = True
        Me.GV3_CUSTOMS_4CODE.Visible = True
        Me.GV3_CUSTOMS_4CODE.VisibleIndex = 2
        Me.Localizer1.SetWordID(Me.GV3_CUSTOMS_4CODE, "")
        '
        'GV3_CUST_CD
        '
        Me.GV3_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_CUST_CD.Caption = "CRM 거래처코드"
        Me.GV3_CUST_CD.FieldName = "CUST_CD"
        Me.GV3_CUST_CD.Name = "GV3_CUST_CD"
        Me.GV3_CUST_CD.OptionsColumn.AllowEdit = False
        Me.GV3_CUST_CD.OptionsColumn.ReadOnly = True
        Me.GV3_CUST_CD.Visible = True
        Me.GV3_CUST_CD.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV3_CUST_CD, "")
        '
        'GV3_CUST_LOC_NM
        '
        Me.GV3_CUST_LOC_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_CUST_LOC_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_CUST_LOC_NM.Caption = "CRM 거래처명"
        Me.GV3_CUST_LOC_NM.FieldName = "CUST_LOC_NM"
        Me.GV3_CUST_LOC_NM.Name = "GV3_CUST_LOC_NM"
        Me.GV3_CUST_LOC_NM.OptionsColumn.AllowEdit = False
        Me.GV3_CUST_LOC_NM.OptionsColumn.ReadOnly = True
        Me.GV3_CUST_LOC_NM.Visible = True
        Me.GV3_CUST_LOC_NM.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GV3_CUST_LOC_NM, "")
        '
        'GV3_SND_ID
        '
        Me.GV3_SND_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_SND_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_SND_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_SND_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_SND_ID.Caption = "송신식별자"
        Me.GV3_SND_ID.FieldName = "SND_ID"
        Me.GV3_SND_ID.Name = "GV3_SND_ID"
        Me.GV3_SND_ID.OptionsColumn.AllowEdit = False
        Me.GV3_SND_ID.OptionsColumn.ReadOnly = True
        Me.GV3_SND_ID.Visible = True
        Me.GV3_SND_ID.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GV3_SND_ID, "")
        '
        'GV3_RECV_ID
        '
        Me.GV3_RECV_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_RECV_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_RECV_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_RECV_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_RECV_ID.Caption = "수신식별자"
        Me.GV3_RECV_ID.FieldName = "RECV_ID"
        Me.GV3_RECV_ID.Name = "GV3_RECV_ID"
        Me.GV3_RECV_ID.OptionsColumn.AllowEdit = False
        Me.GV3_RECV_ID.OptionsColumn.ReadOnly = True
        Me.GV3_RECV_ID.Visible = True
        Me.GV3_RECV_ID.VisibleIndex = 6
        Me.Localizer1.SetWordID(Me.GV3_RECV_ID, "")
        '
        'GV3_DOC_NM
        '
        Me.GV3_DOC_NM.Caption = "문서명"
        Me.GV3_DOC_NM.FieldName = "DOC_NM"
        Me.GV3_DOC_NM.Name = "GV3_DOC_NM"
        Me.GV3_DOC_NM.OptionsColumn.AllowEdit = False
        Me.GV3_DOC_NM.OptionsColumn.ReadOnly = True
        Me.GV3_DOC_NM.Visible = True
        Me.GV3_DOC_NM.VisibleIndex = 7
        Me.Localizer1.SetWordID(Me.GV3_DOC_NM, "")
        '
        'GV3_THIS_IPM
        '
        Me.GV3_THIS_IPM.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_THIS_IPM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_THIS_IPM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_THIS_IPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_THIS_IPM.Caption = "THIS_IPM"
        Me.GV3_THIS_IPM.FieldName = "THIS_IPM"
        Me.GV3_THIS_IPM.Name = "GV3_THIS_IPM"
        Me.GV3_THIS_IPM.OptionsColumn.AllowEdit = False
        Me.GV3_THIS_IPM.OptionsColumn.ReadOnly = True
        Me.GV3_THIS_IPM.Visible = True
        Me.GV3_THIS_IPM.VisibleIndex = 8
        Me.Localizer1.SetWordID(Me.GV3_THIS_IPM, "")
        '
        'GV3_BGM
        '
        Me.GV3_BGM.Caption = "BGM"
        Me.GV3_BGM.FieldName = "BGM"
        Me.GV3_BGM.Name = "GV3_BGM"
        Me.GV3_BGM.OptionsColumn.AllowEdit = False
        Me.GV3_BGM.OptionsColumn.ReadOnly = True
        Me.GV3_BGM.Visible = True
        Me.GV3_BGM.VisibleIndex = 9
        Me.Localizer1.SetWordID(Me.GV3_BGM, "")
        '
        'GV3_SND_RECV
        '
        Me.GV3_SND_RECV.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_SND_RECV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_SND_RECV.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_SND_RECV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_SND_RECV.Caption = "S/R"
        Me.GV3_SND_RECV.FieldName = "SND_RECV"
        Me.GV3_SND_RECV.Name = "GV3_SND_RECV"
        Me.GV3_SND_RECV.OptionsColumn.AllowEdit = False
        Me.GV3_SND_RECV.OptionsColumn.ReadOnly = True
        Me.GV3_SND_RECV.Visible = True
        Me.GV3_SND_RECV.VisibleIndex = 10
        Me.Localizer1.SetWordID(Me.GV3_SND_RECV, "")
        '
        'GV3_SND_BYTE
        '
        Me.GV3_SND_BYTE.AppearanceCell.Options.UseTextOptions = True
        Me.GV3_SND_BYTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV3_SND_BYTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_SND_BYTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_SND_BYTE.Caption = "BYTE"
        Me.GV3_SND_BYTE.FieldName = "SND_BYTE"
        Me.GV3_SND_BYTE.Name = "GV3_SND_BYTE"
        Me.GV3_SND_BYTE.OptionsColumn.AllowEdit = False
        Me.GV3_SND_BYTE.OptionsColumn.ReadOnly = True
        Me.GV3_SND_BYTE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SND_BYTE", "{0:0,0}", 0.0R)})
        Me.GV3_SND_BYTE.Visible = True
        Me.GV3_SND_BYTE.VisibleIndex = 11
        Me.Localizer1.SetWordID(Me.GV3_SND_BYTE, "")
        '
        'GV3_DOC_ITEM
        '
        Me.GV3_DOC_ITEM.Caption = "품목"
        Me.GV3_DOC_ITEM.FieldName = "DOC_ITEM"
        Me.GV3_DOC_ITEM.Name = "GV3_DOC_ITEM"
        Me.GV3_DOC_ITEM.OptionsColumn.AllowEdit = False
        Me.GV3_DOC_ITEM.OptionsColumn.ReadOnly = True
        Me.GV3_DOC_ITEM.Visible = True
        Me.GV3_DOC_ITEM.VisibleIndex = 12
        Me.Localizer1.SetWordID(Me.GV3_DOC_ITEM, "")
        '
        'GV3_KEY_NO
        '
        Me.GV3_KEY_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV3_KEY_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV3_KEY_NO.Caption = "KEY"
        Me.GV3_KEY_NO.FieldName = "KEY_NO"
        Me.GV3_KEY_NO.Name = "GV3_KEY_NO"
        Me.GV3_KEY_NO.OptionsColumn.AllowEdit = False
        Me.GV3_KEY_NO.OptionsColumn.ReadOnly = True
        Me.GV3_KEY_NO.Visible = True
        Me.GV3_KEY_NO.VisibleIndex = 13
        Me.Localizer1.SetWordID(Me.GV3_KEY_NO, "")
        '
        'GV3_CHAIN_SND_BYTE
        '
        Me.GV3_CHAIN_SND_BYTE.Caption = "CHAIN BYTE"
        Me.GV3_CHAIN_SND_BYTE.FieldName = "CHAIN_SND_BYTE"
        Me.GV3_CHAIN_SND_BYTE.Name = "GV3_CHAIN_SND_BYTE"
        Me.GV3_CHAIN_SND_BYTE.OptionsColumn.AllowEdit = False
        Me.GV3_CHAIN_SND_BYTE.OptionsColumn.ReadOnly = True
        Me.GV3_CHAIN_SND_BYTE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CHAIN_SND_BYTE", "{0:0,0}", 0.0R)})
        Me.GV3_CHAIN_SND_BYTE.Visible = True
        Me.GV3_CHAIN_SND_BYTE.VisibleIndex = 14
        Me.Localizer1.SetWordID(Me.GV3_CHAIN_SND_BYTE, "")
        '
        'GV3_SND_CK
        '
        Me.GV3_SND_CK.Caption = "전송체크"
        Me.GV3_SND_CK.FieldName = "SND_CK"
        Me.GV3_SND_CK.Name = "GV3_SND_CK"
        Me.GV3_SND_CK.OptionsColumn.AllowEdit = False
        Me.GV3_SND_CK.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV3_SND_CK, "")
        '
        'RepositoryItemDateBoxEdit2
        '
        Me.RepositoryItemDateBoxEdit2.AutoHeight = False
        Me.RepositoryItemDateBoxEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateBoxEdit2.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemDateBoxEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemDateBoxEdit2.Mask.SaveLiteral = False
        Me.RepositoryItemDateBoxEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateBoxEdit2.Name = "RepositoryItemDateBoxEdit2"
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "n"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 22)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "File Path"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "")
        '
        'btnUDRFile
        '
        Me.btnUDRFile.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnUDRFile.Location = New System.Drawing.Point(500, 16)
        Me.btnUDRFile.Name = "btnUDRFile"
        Me.btnUDRFile.Size = New System.Drawing.Size(70, 22)
        Me.btnUDRFile.TabIndex = 103
        Me.btnUDRFile.Text = "File"
        Me.Localizer1.SetWordID(Me.btnUDRFile, "File")
        '
        'TextBox3
        '
        Me.TextBox3.BorderColor = System.Drawing.Color.Silver
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.DefVal = ""
        Me.TextBox3.IsDataStateAware = True
        Me.TextBox3.Location = New System.Drawing.Point(100, 16)
        Me.TextBox3.MaxLength = 20
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.NextFocus = "VOY"
        Me.TextBox3.Size = New System.Drawing.Size(394, 23)
        Me.TextBox3.TabIndex = 102
        Me.TextBox3.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Controls.Add(Me.btnMFCSSave)
        Me.PanelControl4.Controls.Add(Me.WG1)
        Me.PanelControl4.Controls.Add(Me.Label3)
        Me.PanelControl4.Controls.Add(Me.btnMFCSFile)
        Me.PanelControl4.Controls.Add(Me.TextBox1)
        Me.PanelControl4.Location = New System.Drawing.Point(0, 418)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1032, 273)
        Me.PanelControl4.TabIndex = 8
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        '
        'btnMFCSSave
        '
        Me.btnMFCSSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMFCSSave.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnMFCSSave.Image = CType(resources.GetObject("btnMFCSSave.Image"), System.Drawing.Image)
        Me.btnMFCSSave.Location = New System.Drawing.Point(931, 13)
        Me.btnMFCSSave.Name = "btnMFCSSave"
        Me.btnMFCSSave.Size = New System.Drawing.Size(75, 25)
        Me.btnMFCSSave.TabIndex = 108
        Me.btnMFCSSave.Text = "&Save"
        Me.Localizer1.SetWordID(Me.btnMFCSSave, "&Save")
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
        Me.WG1.Location = New System.Drawing.Point(0, 45)
        Me.WG1.MainView = Me.GV1
        Me.WG1.Name = "WG1"
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit3, Me.RepositoryItemMemoEdit3, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6})
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = True
        Me.WG1.Size = New System.Drawing.Size(1032, 228)
        Me.WG1.TabIndex = 106
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_DOC_YYYYMM, Me.GV1_INV_YM, Me.GV1_SND_ID, Me.GV1_RECV_ID, Me.GV1_DOC_NM, Me.GV1_SND_RECV, Me.GV1_TOT_SND_BYTE, Me.GV1_ACC_SND_BYTE, Me.GV1_ACC_AMT, Me.GV1_COMMISSION, Me.GV1_REMARK, Me.GV1_CUSTOMS_4CODE, Me.GV1_CUST_CD, Me.GV1_CUST_LOC_NM})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.IndicatorWidth = 50
        Me.GV1.LevelIndent = 1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsCustomization.AllowColumnMoving = False
        Me.GV1.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV1.OptionsCustomization.AllowRowSizing = True
        Me.GV1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsPrint.AutoWidth = False
        Me.GV1.OptionsPrint.ExpandAllDetails = True
        Me.GV1.OptionsPrint.PrintDetails = True
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.RowAutoHeight = True
        Me.GV1.OptionsView.ShowFooter = True
        Me.GV1.OptionsView.ShowGroupPanel = False
        Me.GV1.OptionsView.ShowHorzLines = False
        Me.GV1.RowHeight = 10
        Me.GV1.ViewCaption = " 거래처 목록"
        '
        'GV1_DOC_YYYYMM
        '
        Me.GV1_DOC_YYYYMM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_DOC_YYYYMM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DOC_YYYYMM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DOC_YYYYMM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DOC_YYYYMM.Caption = "전송년월"
        Me.GV1_DOC_YYYYMM.FieldName = "DOC_YYYYMM"
        Me.GV1_DOC_YYYYMM.Name = "GV1_DOC_YYYYMM"
        Me.GV1_DOC_YYYYMM.OptionsColumn.AllowEdit = False
        Me.GV1_DOC_YYYYMM.OptionsColumn.ReadOnly = True
        Me.GV1_DOC_YYYYMM.Visible = True
        Me.GV1_DOC_YYYYMM.VisibleIndex = 0
        Me.Localizer1.SetWordID(Me.GV1_DOC_YYYYMM, "")
        '
        'GV1_INV_YM
        '
        Me.GV1_INV_YM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INV_YM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INV_YM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INV_YM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INV_YM.Caption = "청구년월"
        Me.GV1_INV_YM.FieldName = "INV_YM"
        Me.GV1_INV_YM.Name = "GV1_INV_YM"
        Me.GV1_INV_YM.Visible = True
        Me.GV1_INV_YM.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GV1_INV_YM, "")
        '
        'GV1_SND_ID
        '
        Me.GV1_SND_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SND_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SND_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SND_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SND_ID.Caption = "송신식별자"
        Me.GV1_SND_ID.FieldName = "SND_ID"
        Me.GV1_SND_ID.Name = "GV1_SND_ID"
        Me.GV1_SND_ID.OptionsColumn.AllowEdit = False
        Me.GV1_SND_ID.OptionsColumn.ReadOnly = True
        Me.GV1_SND_ID.Visible = True
        Me.GV1_SND_ID.VisibleIndex = 2
        Me.Localizer1.SetWordID(Me.GV1_SND_ID, "")
        '
        'GV1_RECV_ID
        '
        Me.GV1_RECV_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_RECV_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RECV_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RECV_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RECV_ID.Caption = "수신식별자"
        Me.GV1_RECV_ID.FieldName = "RECV_ID"
        Me.GV1_RECV_ID.Name = "GV1_RECV_ID"
        Me.GV1_RECV_ID.OptionsColumn.AllowEdit = False
        Me.GV1_RECV_ID.OptionsColumn.ReadOnly = True
        Me.GV1_RECV_ID.Visible = True
        Me.GV1_RECV_ID.VisibleIndex = 3
        Me.Localizer1.SetWordID(Me.GV1_RECV_ID, "")
        '
        'GV1_DOC_NM
        '
        Me.GV1_DOC_NM.Caption = "문서명"
        Me.GV1_DOC_NM.FieldName = "DOC_NM"
        Me.GV1_DOC_NM.Name = "GV1_DOC_NM"
        Me.GV1_DOC_NM.OptionsColumn.AllowEdit = False
        Me.GV1_DOC_NM.OptionsColumn.ReadOnly = True
        Me.GV1_DOC_NM.Visible = True
        Me.GV1_DOC_NM.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GV1_DOC_NM, "")
        '
        'GV1_SND_RECV
        '
        Me.GV1_SND_RECV.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SND_RECV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SND_RECV.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SND_RECV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SND_RECV.Caption = "S/R"
        Me.GV1_SND_RECV.FieldName = "SND_RECV"
        Me.GV1_SND_RECV.Name = "GV1_SND_RECV"
        Me.GV1_SND_RECV.OptionsColumn.AllowEdit = False
        Me.GV1_SND_RECV.OptionsColumn.ReadOnly = True
        Me.GV1_SND_RECV.Visible = True
        Me.GV1_SND_RECV.VisibleIndex = 5
        Me.Localizer1.SetWordID(Me.GV1_SND_RECV, "")
        '
        'GV1_TOT_SND_BYTE
        '
        Me.GV1_TOT_SND_BYTE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TOT_SND_BYTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_TOT_SND_BYTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TOT_SND_BYTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TOT_SND_BYTE.Caption = "실전송량"
        Me.GV1_TOT_SND_BYTE.DisplayFormat.FormatString = "{0:0,0}"
        Me.GV1_TOT_SND_BYTE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_TOT_SND_BYTE.FieldName = "TOT_SND_BYTE"
        Me.GV1_TOT_SND_BYTE.Name = "GV1_TOT_SND_BYTE"
        Me.GV1_TOT_SND_BYTE.OptionsColumn.AllowEdit = False
        Me.GV1_TOT_SND_BYTE.OptionsColumn.ReadOnly = True
        Me.GV1_TOT_SND_BYTE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOT_SND_BYTE", "{0:0,0}", 0.0R)})
        Me.GV1_TOT_SND_BYTE.Visible = True
        Me.GV1_TOT_SND_BYTE.VisibleIndex = 6
        Me.Localizer1.SetWordID(Me.GV1_TOT_SND_BYTE, "")
        '
        'GV1_ACC_SND_BYTE
        '
        Me.GV1_ACC_SND_BYTE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_ACC_SND_BYTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_ACC_SND_BYTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_ACC_SND_BYTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_ACC_SND_BYTE.Caption = "과금전송량"
        Me.GV1_ACC_SND_BYTE.DisplayFormat.FormatString = "{0:0,0}"
        Me.GV1_ACC_SND_BYTE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_ACC_SND_BYTE.FieldName = "ACC_SND_BYTE"
        Me.GV1_ACC_SND_BYTE.Name = "GV1_ACC_SND_BYTE"
        Me.GV1_ACC_SND_BYTE.OptionsColumn.AllowEdit = False
        Me.GV1_ACC_SND_BYTE.OptionsColumn.ReadOnly = True
        Me.GV1_ACC_SND_BYTE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ACC_SND_BYTE", "{0:0,0}", 0.0R)})
        Me.GV1_ACC_SND_BYTE.Visible = True
        Me.GV1_ACC_SND_BYTE.VisibleIndex = 7
        Me.Localizer1.SetWordID(Me.GV1_ACC_SND_BYTE, "")
        '
        'GV1_ACC_AMT
        '
        Me.GV1_ACC_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_ACC_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_ACC_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_ACC_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_ACC_AMT.Caption = "사용료(KB*250원)"
        Me.GV1_ACC_AMT.DisplayFormat.FormatString = "{0:0,0}"
        Me.GV1_ACC_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_ACC_AMT.FieldName = "ACC_AMT"
        Me.GV1_ACC_AMT.Name = "GV1_ACC_AMT"
        Me.GV1_ACC_AMT.OptionsColumn.AllowEdit = False
        Me.GV1_ACC_AMT.OptionsColumn.ReadOnly = True
        Me.GV1_ACC_AMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ACC_AMT", "{0:0,0}", 0.0R)})
        Me.GV1_ACC_AMT.Visible = True
        Me.GV1_ACC_AMT.VisibleIndex = 8
        Me.Localizer1.SetWordID(Me.GV1_ACC_AMT, "")
        '
        'GV1_COMMISSION
        '
        Me.GV1_COMMISSION.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_COMMISSION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV1_COMMISSION.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_COMMISSION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_COMMISSION.Caption = "수수료"
        Me.GV1_COMMISSION.DisplayFormat.FormatString = "{0:0,0}"
        Me.GV1_COMMISSION.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV1_COMMISSION.FieldName = "COMMISSION"
        Me.GV1_COMMISSION.Name = "GV1_COMMISSION"
        Me.GV1_COMMISSION.OptionsColumn.AllowEdit = False
        Me.GV1_COMMISSION.OptionsColumn.ReadOnly = True
        Me.GV1_COMMISSION.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "COMMISSION", "{0:0,0}", 0.0R)})
        Me.GV1_COMMISSION.Visible = True
        Me.GV1_COMMISSION.VisibleIndex = 9
        Me.Localizer1.SetWordID(Me.GV1_COMMISSION, "")
        '
        'GV1_REMARK
        '
        Me.GV1_REMARK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REMARK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REMARK.Caption = "비고"
        Me.GV1_REMARK.FieldName = "REMARK"
        Me.GV1_REMARK.Name = "GV1_REMARK"
        Me.GV1_REMARK.OptionsColumn.AllowEdit = False
        Me.GV1_REMARK.OptionsColumn.ReadOnly = True
        Me.GV1_REMARK.Visible = True
        Me.GV1_REMARK.VisibleIndex = 10
        Me.Localizer1.SetWordID(Me.GV1_REMARK, "")
        '
        'GV1_CUSTOMS_4CODE
        '
        Me.GV1_CUSTOMS_4CODE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUSTOMS_4CODE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUSTOMS_4CODE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUSTOMS_4CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUSTOMS_4CODE.Caption = "4 코드"
        Me.GV1_CUSTOMS_4CODE.FieldName = "CUSTOMS_4CODE"
        Me.GV1_CUSTOMS_4CODE.Name = "GV1_CUSTOMS_4CODE"
        Me.GV1_CUSTOMS_4CODE.Visible = True
        Me.GV1_CUSTOMS_4CODE.VisibleIndex = 11
        Me.Localizer1.SetWordID(Me.GV1_CUSTOMS_4CODE, "")
        '
        'GV1_CUST_CD
        '
        Me.GV1_CUST_CD.Caption = "거래처코드"
        Me.GV1_CUST_CD.FieldName = "CUST_CD"
        Me.GV1_CUST_CD.Name = "GV1_CUST_CD"
        Me.GV1_CUST_CD.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_CD.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_CD.Visible = True
        Me.GV1_CUST_CD.VisibleIndex = 12
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "")
        '
        'GV1_CUST_LOC_NM
        '
        Me.GV1_CUST_LOC_NM.Caption = "거래처명"
        Me.GV1_CUST_LOC_NM.FieldName = "CUST_LOC_NM"
        Me.GV1_CUST_LOC_NM.Name = "GV1_CUST_LOC_NM"
        Me.GV1_CUST_LOC_NM.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_LOC_NM.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_LOC_NM.Visible = True
        Me.GV1_CUST_LOC_NM.VisibleIndex = 13
        Me.Localizer1.SetWordID(Me.GV1_CUST_LOC_NM, "")
        '
        'RepositoryItemDateBoxEdit3
        '
        Me.RepositoryItemDateBoxEdit3.AutoHeight = False
        Me.RepositoryItemDateBoxEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateBoxEdit3.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemDateBoxEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemDateBoxEdit3.Mask.SaveLiteral = False
        Me.RepositoryItemDateBoxEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateBoxEdit3.Name = "RepositoryItemDateBoxEdit3"
        '
        'RepositoryItemMemoEdit3
        '
        Me.RepositoryItemMemoEdit3.Name = "RepositoryItemMemoEdit3"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "n"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(9, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 22)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "File Path"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label3, "")
        '
        'btnMFCSFile
        '
        Me.btnMFCSFile.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnMFCSFile.Location = New System.Drawing.Point(500, 16)
        Me.btnMFCSFile.Name = "btnMFCSFile"
        Me.btnMFCSFile.Size = New System.Drawing.Size(70, 22)
        Me.btnMFCSFile.TabIndex = 103
        Me.btnMFCSFile.Text = "File"
        Me.Localizer1.SetWordID(Me.btnMFCSFile, "File")
        '
        'TextBox1
        '
        Me.TextBox1.BorderColor = System.Drawing.Color.Silver
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DefVal = ""
        Me.TextBox1.IsDataStateAware = True
        Me.TextBox1.Location = New System.Drawing.Point(100, 16)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NextFocus = "VOY"
        Me.TextBox1.Size = New System.Drawing.Size(394, 23)
        Me.TextBox1.TabIndex = 102
        Me.TextBox1.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnClear.Location = New System.Drawing.Point(963, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(70, 25)
        Me.btnClear.TabIndex = 100
        Me.btnClear.Text = "Clear"
        Me.Localizer1.SetWordID(Me.btnClear, "Clear")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.SEARCH_TYPE)
        Me.palAutoButton.Controls.Add(Me.Label4)
        Me.palAutoButton.Controls.Add(Me.S_END_YMD)
        Me.palAutoButton.Controls.Add(Me.S_ECH_CUST_CD)
        Me.palAutoButton.Controls.Add(Me.btnClear)
        Me.palAutoButton.Controls.Add(Me.S_ECH_4CODE)
        Me.palAutoButton.Controls.Add(Me.S_ECH_CUST_NM)
        Me.palAutoButton.Controls.Add(Me.Label2)
        Me.palAutoButton.Controls.Add(Me.S_STR_YMD)
        Me.palAutoButton.Controls.Add(Me.btnSearchAll)
        Me.palAutoButton.Location = New System.Drawing.Point(5, 2)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1040, 32)
        Me.palAutoButton.TabIndex = 282
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'SEARCH_TYPE
        '
        Me.SEARCH_TYPE.CodeType = ""
        Me.SEARCH_TYPE.ColumnWidths = ""
        Me.SEARCH_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.SEARCH_TYPE.DataParams = ""
        Me.SEARCH_TYPE.DefVal = "SND_YM"
        Me.SEARCH_TYPE.DisplayMember = "NAME"
        Me.SEARCH_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SEARCH_TYPE.FormattingEnabled = True
        Me.SEARCH_TYPE.IsDataStateAware = True
        Me.SEARCH_TYPE.ItemDelimiter = ","
        Me.SEARCH_TYPE.ItemTextList = "전송년월,청구년월"
        Me.SEARCH_TYPE.ItemValueList = "SND_YM,INV_YM"
        Me.SEARCH_TYPE.KeepIntegrity = True
        Me.SEARCH_TYPE.Location = New System.Drawing.Point(91, 6)
        Me.SEARCH_TYPE.Name = "SEARCH_TYPE"
        Me.SEARCH_TYPE.NextFocus = "S_STR_YMD"
        Me.SEARCH_TYPE.NullText = ""
        Me.SEARCH_TYPE.SearchKeys = ""
        Me.SEARCH_TYPE.Size = New System.Drawing.Size(92, 22)
        Me.SEARCH_TYPE.TabIndex = 10016
        Me.SEARCH_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.SEARCH_TYPE.ValueMember = "CODE"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(279, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 19)
        Me.Label4.TabIndex = 10015
        Me.Label4.Text = "~"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label4, "")
        '
        'S_END_YMD
        '
        Me.S_END_YMD.BorderColor = System.Drawing.Color.Silver
        Me.S_END_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_END_YMD.DefVal = ""
        Me.S_END_YMD.IconVisible = True
        Me.S_END_YMD.IsDataStateAware = True
        Me.S_END_YMD.Location = New System.Drawing.Point(293, 6)
        Me.S_END_YMD.Mask = "0000-00-00"
        Me.S_END_YMD.Name = "S_END_YMD"
        Me.S_END_YMD.NextFocus = "S_ECH_CUST_CD"
        Me.S_END_YMD.Size = New System.Drawing.Size(93, 22)
        Me.S_END_YMD.TabIndex = 10014
        Me.S_END_YMD.ValidatingType = GetType(Date)
        Me.Localizer1.SetWordID(Me.S_END_YMD, "")
        '
        'S_ECH_CUST_CD
        '
        Me.S_ECH_CUST_CD.AlwaysSetDisplayParams = True
        Me.S_ECH_CUST_CD.AutoSuggestion = False
        Me.S_ECH_CUST_CD.BorderColor = System.Drawing.Color.Silver
        Me.S_ECH_CUST_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_ECH_CUST_CD.CodeType = "YJIT.CodeService.Customer"
        Me.S_ECH_CUST_CD.DataParams = ""
        Me.S_ECH_CUST_CD.DefVal = ""
        Me.S_ECH_CUST_CD.DisplayParams = "Code:@S_ECH_CUST_CD,Name:@S_ECH_CUST_NM"
        Me.S_ECH_CUST_CD.EditPopup = ""
        Me.S_ECH_CUST_CD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_ECH_CUST_CD.IconVisible = True
        Me.S_ECH_CUST_CD.IsDataStateAware = True
        Me.S_ECH_CUST_CD.KeepIntegrity = True
        Me.S_ECH_CUST_CD.Location = New System.Drawing.Point(553, 5)
        Me.S_ECH_CUST_CD.Name = "S_ECH_CUST_CD"
        Me.S_ECH_CUST_CD.NextFocus = "S_ECH_CUST_NM"
        Me.S_ECH_CUST_CD.SearchPopup = "CodeMaster"
        Me.S_ECH_CUST_CD.Size = New System.Drawing.Size(91, 23)
        Me.S_ECH_CUST_CD.SuppressValidateCode = False
        Me.S_ECH_CUST_CD.TabIndex = 10013
        Me.S_ECH_CUST_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_ECH_CUST_CD.ValidateKeys = "KEY:@S_ECH_CUST_CD"
        '
        'S_ECH_4CODE
        '
        Me.S_ECH_4CODE.BorderColor = System.Drawing.Color.Silver
        Me.S_ECH_4CODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_ECH_4CODE.DefVal = ""
        Me.S_ECH_4CODE.IsDataStateAware = True
        Me.S_ECH_4CODE.Location = New System.Drawing.Point(810, 5)
        Me.S_ECH_4CODE.Name = "S_ECH_4CODE"
        Me.S_ECH_4CODE.NextFocus = "btnSearchAll"
        Me.S_ECH_4CODE.Size = New System.Drawing.Size(77, 22)
        Me.S_ECH_4CODE.TabIndex = 104
        Me.S_ECH_4CODE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'S_ECH_CUST_NM
        '
        Me.S_ECH_CUST_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_ECH_CUST_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_ECH_CUST_NM.DefVal = ""
        Me.S_ECH_CUST_NM.IsDataStateAware = True
        Me.S_ECH_CUST_NM.Location = New System.Drawing.Point(647, 5)
        Me.S_ECH_CUST_NM.Name = "S_ECH_CUST_NM"
        Me.S_ECH_CUST_NM.NextFocus = "S_ECH_4CODE"
        Me.S_ECH_CUST_NM.Size = New System.Drawing.Size(160, 22)
        Me.S_ECH_CUST_NM.TabIndex = 103
        Me.S_ECH_CUST_NM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(379, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 19)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "거래처 코드 / 명 / 4CODE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "")
        '
        'S_STR_YMD
        '
        Me.S_STR_YMD.BorderColor = System.Drawing.Color.Silver
        Me.S_STR_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_STR_YMD.DefVal = ""
        Me.S_STR_YMD.IconVisible = True
        Me.S_STR_YMD.IsDataStateAware = True
        Me.S_STR_YMD.Location = New System.Drawing.Point(184, 6)
        Me.S_STR_YMD.Mask = "0000-00-00"
        Me.S_STR_YMD.Name = "S_STR_YMD"
        Me.S_STR_YMD.NextFocus = "S_END_YMD"
        Me.S_STR_YMD.Size = New System.Drawing.Size(93, 22)
        Me.S_STR_YMD.TabIndex = 100
        Me.S_STR_YMD.ValidatingType = GetType(Date)
        Me.Localizer1.SetWordID(Me.S_STR_YMD, "")
        '
        'btnSearchAll
        '
        Me.btnSearchAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchAll.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearchAll.Image = CType(resources.GetObject("btnSearchAll.Image"), System.Drawing.Image)
        Me.btnSearchAll.Location = New System.Drawing.Point(893, 3)
        Me.btnSearchAll.Name = "btnSearchAll"
        Me.btnSearchAll.Size = New System.Drawing.Size(64, 25)
        Me.btnSearchAll.TabIndex = 6
        Me.btnSearchAll.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearchAll, "Se&arch")
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
        'EchAccountExcelUpDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 766)
        Me.Controls.Add(Me.palAutoButton)
        Me.Controls.Add(Me.xtcKLNET)
        Me.KeyPreview = True
        Me.Name = "EchAccountExcelUpDown"
        Me.Text = "청구내역"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.Gv2Num2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gv2Num0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcKLNET, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcKLNET.ResumeLayout(False)
        Me.xtpACC.ResumeLayout(False)
        CType(Me.WG4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpAFR.ResumeLayout(False)
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.xtpMFCS.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.WG3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        Me.palAutoButton.PerformLayout()
        CType(Me.iconImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
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
    Friend WithEvents xtcKLNET As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpAFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GV2_DOC_YYYYMM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_CUST_CD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_KLNET_CUST_NM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_KL_HBL_COUNT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_SND_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_CUSTOMS_4CODE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_KLNET_ACC_AMT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_KLNET_COMMISSION As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV2_CHAIN_HBL_COUNT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_FILE_PATH As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnFile As YJIT.SC.UI.SCControls.Button
    Public WithEvents FILE_PATH As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents xtpMFCS As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents xtpACC As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Gv2Num2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Gv2Num0 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV2_CUST_LOC_NM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSearchAll As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV2_BL_CNT_CK As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Label3 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnMFCSFile As YJIT.SC.UI.SCControls.Button
    Public WithEvents TextBox1 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents S_STR_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents S_ECH_4CODE As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents S_ECH_CUST_NM As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnUDRFile As YJIT.SC.UI.SCControls.Button
    Public WithEvents TextBox3 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG3 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV3_DOC_YYYYMM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_CUST_LOC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_SND_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_RECV_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_DOC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_THIS_IPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_BGM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_SND_RECV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_SND_BYTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_KEY_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateBoxEdit2 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_DOC_YYYYMM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SND_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RECV_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DOC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SND_RECV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TOT_SND_BYTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REMARK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateBoxEdit3 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV1_ACC_SND_BYTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_ACC_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_COMMISSION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_CUSTOMS_4CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_CHAIN_SND_BYTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUSTOMS_4CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_SND_CK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClear As YJIT.SC.UI.SCControls.Button
    Private WithEvents btnSave As YJIT.SC.UI.SCControls.Button
    Private WithEvents btnUDRSave As YJIT.SC.UI.SCControls.Button
    Private WithEvents btnMFCSSave As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV1_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUST_LOC_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnApply As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV3_DOC_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents S_ECH_CUST_CD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents S_END_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents WG4 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV4_INV_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_AFR_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_MFCS_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV4_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateBoxEdit4 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemMemoEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV2_INV_YM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents CHAIN As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV1_INV_YM As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents SEARCH_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GV3_INV_YM As DevExpress.XtraGrid.Columns.GridColumn
End Class
