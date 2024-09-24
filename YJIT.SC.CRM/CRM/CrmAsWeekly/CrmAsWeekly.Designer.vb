<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmAsWeekly
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmAsWeekly))
        Me.RepositoryItemDateBoxEdit1 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.S_DEPT_CD = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_DATE_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.S_TO_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.S_FM_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.S_PROJECT_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_PROJECT_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.Label12 = New YJIT.SC.UI.SCControls.Label()
        Me.Label8 = New YJIT.SC.UI.SCControls.Label()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.S_TO_YMD_PREV = New YJIT.SC.UI.SCControls.DateBox()
        Me.S_FM_YMD_PREV = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.btnPrev = New YJIT.SC.UI.SCControls.Button()
        Me.btnNext = New YJIT.SC.UI.SCControls.Button()
        Me.S_TO_YMD_NEXT = New YJIT.SC.UI.SCControls.DateBox()
        Me.S_FM_YMD_NEXT = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.xtpSend = New DevExpress.XtraTab.XtraTabPage()
        Me.WG02_EDI = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV02_EDI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridColumn15 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GridColumn16_해상 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn17_해상 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridColumn18_해상 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn1_항공 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn2_항공 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn3_항공 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn1_AMS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn2_AMS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn3_AMS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn1_합계 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn2_합계 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn3_합계 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.xtcAnalysis = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpHelp = New DevExpress.XtraTab.XtraTabPage()
        Me.WG01_PGC = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PGV_PIVOT_CNT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_WORK_USR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_REQ_SVC_GRP = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.xtpSales = New DevExpress.XtraTab.XtraTabPage()
        Me.WG04C = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV04C = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV04C_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV04C_DEPT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV04C_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV04C_ITEM_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpText_100 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV04C_ORD_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV04C_CTRT_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV04C_IDC_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV04C_MATN_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV04C_CMPT_RATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV04C_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.splitLeft = New DevExpress.XtraEditors.SplitContainerControl()
        Me.WG04A = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV04A = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV01A_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV01A_USR_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV01A_MATN_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WG04B = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV04B = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV04B_CTRT_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV04B_CTRT_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV04B_MATN_AMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.xtpDev = New DevExpress.XtraTab.XtraTabPage()
        Me.splitMain = New DevExpress.XtraEditors.SplitContainerControl()
        Me.WG02 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV02 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV02_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_USR_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PROJECT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_RANK_SORT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_SM_SI_CMPT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_REQ_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_SCORE_SUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_SM_SI_PRAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.xtcDetail = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpCmpt = New DevExpress.XtraTab.XtraTabPage()
        Me.WG02_CMPT_ALL = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV02_CMPT_ALL = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemDateBoxEdit4 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.WG02_CMPT = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV02_CMPT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV02_CMPT_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_PRIORITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_REQ_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_REQ_HM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_CONTENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpMemo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GV02_CMPT_REQ_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_PROC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_WORK_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_PRAR_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_CMPT_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_INS_USR_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_FILE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV02_CMPT_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_PGM_MDF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_DELAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_DELAY_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_REQ_SVC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_REQ_SVC2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_REQ_SVC3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_DEV_ERR_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_SHARE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_RANK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_RANK1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_SCORE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_PROJECT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_PROJECT_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_DEV_SCORE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_DEV_SCORE_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_CMPT_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit2 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.xtpPrar = New DevExpress.XtraTab.XtraTabPage()
        Me.WG02_PRAR_ALL = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV02_PRAR_ALL = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemDateBoxEdit5 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.WG02_PRAR = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV02_PRAR = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV02_PRAR_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_PRIORITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_REQ_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_REQ_HM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_CONTENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_REQ_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_PROC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_WORK_USR_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_PRAR_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_CMPT_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_INS_USR_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_FILE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GV02_PRAR_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_PGM_MDF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_DELAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_DELAY_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_REQ_SVC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_REQ_SVC2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_REQ_SVC3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_INS_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_DEV_ERR_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_SHARE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_RANK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_DEV_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_SCORE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_PROJECT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_PROJECT_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_DEV_SCORE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_DEV_SCORE_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_SEQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV02_PRAR_USR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateBoxEdit3 = New YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.S_DEV_PIC_LIST = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.lbl_S_DEV_PIC_LIST = New YJIT.SC.UI.SCControls.Label()
        Me.xtpAccount = New DevExpress.XtraTab.XtraTabPage()
        Me.WebGrid13 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WebGrid14 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WebGrid15 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController()
        Me.rpMemo_200 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.rpNumeric_N0 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV02_PRAR_rpMemoEx = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.xtpSend.SuspendLayout()
        CType(Me.WG02_EDI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV02_EDI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcAnalysis.SuspendLayout()
        Me.xtpHelp.SuspendLayout()
        CType(Me.WG01_PGC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpSales.SuspendLayout()
        CType(Me.WG04C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV04C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpText_100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitLeft.SuspendLayout()
        CType(Me.WG04A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV04A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG04B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV04B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpDev.SuspendLayout()
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMain.SuspendLayout()
        CType(Me.WG02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcDetail.SuspendLayout()
        Me.xtpCmpt.SuspendLayout()
        CType(Me.WG02_CMPT_ALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV02_CMPT_ALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG02_CMPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV02_CMPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpPrar.SuspendLayout()
        CType(Me.WG02_PRAR_ALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV02_PRAR_ALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG02_PRAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV02_PRAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateBoxEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.S_DEV_PIC_LIST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpAccount.SuspendLayout()
        CType(Me.WebGrid13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebGrid14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebGrid15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMemo_200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpNumeric_N0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV02_PRAR_rpMemoEx, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.btnSearch, "조회(&S)")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.S_DEPT_CD, "--Select--")
        Me.Localizer1.SetWordID(Me.S_DATE_TYPE, "등록일자")
        Me.Localizer1.SetWordID(Me.Label1, "부서")
        Me.Localizer1.SetWordID(Me.S_TO_YMD, "")
        Me.Localizer1.SetWordID(Me.S_FM_YMD, "")
        Me.Localizer1.SetWordID(Me.Label2, "~")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.S_PROJECT_CD, "")
        Me.Localizer1.SetWordID(Me.Label12, "프로젝트")
        Me.Localizer1.SetWordID(Me.Label8, "차주일자")
        Me.Localizer1.SetWordID(Me.Label7, "전주일자")
        Me.Localizer1.SetWordID(Me.S_TO_YMD_PREV, "")
        Me.Localizer1.SetWordID(Me.S_FM_YMD_PREV, "")
        Me.Localizer1.SetWordID(Me.Label6, "~")
        Me.Localizer1.SetWordID(Me.btnPrev, "<")
        Me.Localizer1.SetWordID(Me.btnNext, ">")
        Me.Localizer1.SetWordID(Me.S_TO_YMD_NEXT, "")
        Me.Localizer1.SetWordID(Me.S_FM_YMD_NEXT, "")
        Me.Localizer1.SetWordID(Me.Label4, "~")
        Me.Localizer1.SetWordID(Me.xtpSend, "전송 건수")
        Me.Localizer1.SetWordID(Me.WG02_EDI, "")
        Me.Localizer1.SetWordID(Me.gridBand2, "gridBand2")
        Me.Localizer1.SetWordID(Me.GridColumn15, "구분")
        Me.Localizer1.SetWordID(Me.gridBand3, "해상")
        Me.Localizer1.SetWordID(Me.GridColumn16_해상, "고객수")
        Me.Localizer1.SetWordID(Me.GridColumn17_해상, "금주")
        Me.Localizer1.SetWordID(Me.GridColumn18_해상, "월누계")
        Me.Localizer1.SetWordID(Me.gridBand4, "항공")
        Me.Localizer1.SetWordID(Me.BandedGridColumn1_항공, "고객수")
        Me.Localizer1.SetWordID(Me.BandedGridColumn2_항공, "금주")
        Me.Localizer1.SetWordID(Me.BandedGridColumn3_항공, "월누계")
        Me.Localizer1.SetWordID(Me.gridBand5, "AMS")
        Me.Localizer1.SetWordID(Me.BandedGridColumn1_AMS, "고객수")
        Me.Localizer1.SetWordID(Me.BandedGridColumn2_AMS, "금주")
        Me.Localizer1.SetWordID(Me.BandedGridColumn3_AMS, "월누계")
        Me.Localizer1.SetWordID(Me.gridBand6, "합계")
        Me.Localizer1.SetWordID(Me.BandedGridColumn1_합계, "고객수")
        Me.Localizer1.SetWordID(Me.BandedGridColumn2_합계, "금주")
        Me.Localizer1.SetWordID(Me.BandedGridColumn3_합계, "월누계")
        Me.Localizer1.SetWordID(Me.xtcAnalysis, "")
        Me.Localizer1.SetWordID(Me.xtpHelp, "고객지원팀")
        Me.Localizer1.SetWordID(Me.WG01_PGC, "")
        Me.Localizer1.SetWordID(Me.xtpSales, "솔루션사업팀")
        Me.Localizer1.SetWordID(Me.WG04C, "")
        Me.Localizer1.SetWordID(Me.GV04C_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV04C_DEPT_CD, "부서")
        Me.Localizer1.SetWordID(Me.GV04C_CUST_NM, "상호명")
        Me.Localizer1.SetWordID(Me.GV04C_ITEM_NM, "품목")
        Me.Localizer1.SetWordID(Me.GV04C_ORD_AMT, "SI수주금액")
        Me.Localizer1.SetWordID(Me.GV04C_CTRT_AMT, "설치비")
        Me.Localizer1.SetWordID(Me.GV04C_IDC_AMT, "DB임대")
        Me.Localizer1.SetWordID(Me.GV04C_MATN_AMT, "월청구")
        Me.Localizer1.SetWordID(Me.GV04C_CMPT_RATE, "확률")
        Me.Localizer1.SetWordID(Me.GV04C_RMK, "영업상담 내용")
        Me.Localizer1.SetWordID(Me.splitLeft, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.WG04A, "")
        Me.Localizer1.SetWordID(Me.GV01A_USR_ID, "담당자")
        Me.Localizer1.SetWordID(Me.GV01A_USR_CNT, "계약")
        Me.Localizer1.SetWordID(Me.GV01A_MATN_AMT, "금액")
        Me.Localizer1.SetWordID(Me.WG04B, "")
        Me.Localizer1.SetWordID(Me.GV04B_CTRT_TYPE, "구분")
        Me.Localizer1.SetWordID(Me.GV04B_CTRT_CNT, "계약")
        Me.Localizer1.SetWordID(Me.GV04B_MATN_AMT, "금액")
        Me.Localizer1.SetWordID(Me.xtpDev, "개발팀")
        Me.Localizer1.SetWordID(Me.splitMain, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.WG02, "")
        Me.Localizer1.SetWordID(Me.GV02_USR_ID, "담당자ID")
        Me.Localizer1.SetWordID(Me.GV02_USR_NM, "담당자명")
        Me.Localizer1.SetWordID(Me.GV02_PROJECT_CD, "프로젝트코드")
        Me.Localizer1.SetWordID(Me.GV02_RANK_SORT, "직위순서")
        Me.Localizer1.SetWordID(Me.GV02_SM_SI_CMPT, "직무내용")
        Me.Localizer1.SetWordID(Me.GV02_REQ_CNT, "접수")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_CNT, "처리")
        Me.Localizer1.SetWordID(Me.GV02_SCORE_SUM, "난이도")
        Me.Localizer1.SetWordID(Me.GV02_SM_SI_PRAR, "계획")
        Me.Localizer1.SetWordID(Me.xtcDetail, "")
        Me.Localizer1.SetWordID(Me.xtpCmpt, "직무내용 자료")
        Me.Localizer1.SetWordID(Me.WG02_CMPT_ALL, "")
        Me.Localizer1.SetWordID(Me.WG02_CMPT, "")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PRIORITY, "우선순위")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_YMD, "요청일자")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_HM, "요청시간")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_CUST_CD, "코드")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_CUST_NM, "거래처 명")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_CONTENT, "고객 요청내용")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_USR, "요청자")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_TEL_NO, "연락처")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PROC_TYPE, "진행현황")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_WORK_USR, "담당자")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PRAR_YMD, "예정일자")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_CMPT_YMD, "완료일자")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_INS_USR_NM, "등록자")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_FILE_YN, "Document")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_RMK, "개발팀 처리내용")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PGM_MDF, "프로그램 수정사항")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_DELAY, "Delay")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_DELAY_YN, "Delay(Y/N)")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_SVC, "업무구분")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_SVC2, "업무구분2")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_SVC3, "업무구분3")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_INS_YMD, "등록일자")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_DEV_ERR_YN, "결함")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_SHARE_YN, "공유")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_RANK, "난이도")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_RANK1, "개발항목")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_SCORE, "점수")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PROJECT_CD, "프로젝트코드")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PROJECT_NM, "프로젝트명")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_DEV_SCORE, "팀장점수")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_DEV_SCORE_RMK, "팀장점수 비고")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_SEQ, "Seq")
        Me.Localizer1.SetWordID(Me.GV02_CMPT_USR_ID, "USR_ID")
        Me.Localizer1.SetWordID(Me.xtpPrar, "계획 자료")
        Me.Localizer1.SetWordID(Me.WG02_PRAR_ALL, "")
        Me.Localizer1.SetWordID(Me.WG02_PRAR, "")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PRIORITY, "우선순위")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_YMD, "요청일자")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_HM, "요청시간")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_CUST_CD, "코드")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_CUST_NM, "거래처 명")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_CONTENT, "고객 요청내용")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_USR, "요청자")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_TEL_NO, "연락처")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PROC_TYPE, "진행현황")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_WORK_USR_NM, "담당자")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PRAR_YMD, "예정일자")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_CMPT_YMD, "완료일자")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_INS_USR_NM, "등록자")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_FILE_YN, "Document")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_RMK, "개발팀 처리내용")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PGM_MDF, "프로그램 수정사항")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DELAY, "Delay")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DELAY_YN, "Delay(Y/N)")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_SVC, "업무구분")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_SVC2, "업무구분2")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_SVC3, "업무구분3")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_INS_YMD, "등록일자")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DEV_ERR_YN, "결함")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_SHARE_YN, "공유")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_RANK, "난이도")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DEV_ITEM, "개발항목")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_SCORE, "점수")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PROJECT_CD, "프로젝트명")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PROJECT_NM, "프로젝트명")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DEV_SCORE, "팀장점수")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DEV_SCORE_RMK, "팀장점수 비고")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_SEQ, "Seq")
        Me.Localizer1.SetWordID(Me.GV02_PRAR_USR_ID, "USR_ID")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.S_DEV_PIC_LIST, "")
        Me.Localizer1.SetWordID(Me.lbl_S_DEV_PIC_LIST, "담당자")
        Me.Localizer1.SetWordID(Me.xtpAccount, "관리팀")
        Me.Localizer1.SetWordID(Me.WebGrid13, "")
        Me.Localizer1.SetWordID(Me.GridColumn41, "청구구분")
        Me.Localizer1.SetWordID(Me.GridColumn42, "청구금액")
        Me.Localizer1.SetWordID(Me.GridColumn43, "총수금액")
        Me.Localizer1.SetWordID(Me.GridColumn44, "미수잔액")
        Me.Localizer1.SetWordID(Me.GridColumn45, "수금율")
        Me.Localizer1.SetWordID(Me.WebGrid14, "")
        Me.Localizer1.SetWordID(Me.GridColumn32, "청구구분")
        Me.Localizer1.SetWordID(Me.GridColumn37, "청구금액")
        Me.Localizer1.SetWordID(Me.GridColumn38, "총수금액")
        Me.Localizer1.SetWordID(Me.GridColumn39, "미수잔액")
        Me.Localizer1.SetWordID(Me.GridColumn40, "수금율")
        Me.Localizer1.SetWordID(Me.WebGrid15, "")
        Me.Localizer1.SetWordID(Me.GridColumn31, "청구구분")
        Me.Localizer1.SetWordID(Me.GridColumn33, "청구금액")
        Me.Localizer1.SetWordID(Me.GridColumn34, "총수금액")
        Me.Localizer1.SetWordID(Me.GridColumn35, "미수잔액")
        Me.Localizer1.SetWordID(Me.GridColumn36, "수금율")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(916, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 27)
        Me.btnSearch.TabIndex = 9999
        Me.btnSearch.Text = "조회(&S)"
        Me.Localizer1.SetWordID(Me.btnSearch, "")
        '
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(2, 2)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(997, 32)
        Me.palAutoButton.TabIndex = 278
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'S_DEPT_CD
        '
        Me.S_DEPT_CD.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_DEPT_CD.ColumnWidths = ""
        Me.S_DEPT_CD.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_DEPT_CD.DataParams = "GroupCode:'C03',NameType:''"
        Me.S_DEPT_CD.DefVal = ""
        Me.S_DEPT_CD.DisplayMember = "NAME"
        Me.S_DEPT_CD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DEPT_CD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_DEPT_CD.FormattingEnabled = True
        Me.S_DEPT_CD.IsDataStateAware = True
        Me.S_DEPT_CD.ItemDelimiter = ","
        Me.S_DEPT_CD.ItemTextList = ""
        Me.S_DEPT_CD.ItemValueList = ""
        Me.S_DEPT_CD.KeepIntegrity = True
        Me.S_DEPT_CD.Location = New System.Drawing.Point(398, 5)
        Me.S_DEPT_CD.Name = "S_DEPT_CD"
        Me.S_DEPT_CD.NextFocus = "S_PROJECT_CD"
        Me.S_DEPT_CD.NullText = "--Search--"
        Me.S_DEPT_CD.SearchKeys = ""
        Me.S_DEPT_CD.Size = New System.Drawing.Size(195, 23)
        Me.S_DEPT_CD.TabIndex = 10014
        Me.S_DEPT_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DEPT_CD.ValueMember = "CODE"
        '
        'S_DATE_TYPE
        '
        Me.S_DATE_TYPE.CodeType = ""
        Me.S_DATE_TYPE.ColumnWidths = ""
        Me.S_DATE_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_DATE_TYPE.DataParams = ""
        Me.S_DATE_TYPE.DefVal = "C"
        Me.S_DATE_TYPE.DisplayMember = "NAME"
        Me.S_DATE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DATE_TYPE.Enabled = False
        Me.S_DATE_TYPE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_DATE_TYPE.FormattingEnabled = True
        Me.S_DATE_TYPE.IsDataStateAware = True
        Me.S_DATE_TYPE.ItemDelimiter = ","
        Me.S_DATE_TYPE.ItemTextList = "완료일자"
        Me.S_DATE_TYPE.ItemValueList = "C"
        Me.S_DATE_TYPE.KeepIntegrity = True
        Me.S_DATE_TYPE.Location = New System.Drawing.Point(15, 5)
        Me.S_DATE_TYPE.Name = "S_DATE_TYPE"
        Me.S_DATE_TYPE.NextFocus = "S_FM_YMD"
        Me.S_DATE_TYPE.NullText = ""
        Me.S_DATE_TYPE.SearchKeys = ""
        Me.S_DATE_TYPE.Size = New System.Drawing.Size(74, 23)
        Me.S_DATE_TYPE.TabIndex = 287
        Me.S_DATE_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DATE_TYPE.ValueMember = "CODE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(361, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 277
        Me.Label1.Text = "부서"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "")
        '
        'S_TO_YMD
        '
        Me.S_TO_YMD.BackColor = System.Drawing.SystemColors.Window
        Me.S_TO_YMD.BorderColor = System.Drawing.Color.Silver
        Me.S_TO_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_TO_YMD.DefVal = ""
        Me.S_TO_YMD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_TO_YMD.IconVisible = True
        Me.S_TO_YMD.IsDataStateAware = True
        Me.S_TO_YMD.Location = New System.Drawing.Point(194, 5)
        Me.S_TO_YMD.Name = "S_TO_YMD"
        Me.S_TO_YMD.NextFocus = "S_DEPT_CD"
        Me.S_TO_YMD.Size = New System.Drawing.Size(91, 23)
        Me.S_TO_YMD.TabIndex = 0
        Me.Localizer1.SetWordID(Me.S_TO_YMD, "")
        '
        'S_FM_YMD
        '
        Me.S_FM_YMD.BorderColor = System.Drawing.Color.Silver
        Me.S_FM_YMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_FM_YMD.DefVal = ""
        Me.S_FM_YMD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_FM_YMD.IconVisible = True
        Me.S_FM_YMD.IsDataStateAware = True
        Me.S_FM_YMD.Location = New System.Drawing.Point(90, 5)
        Me.S_FM_YMD.Name = "S_FM_YMD"
        Me.S_FM_YMD.NextFocus = "S_TO_YMD"
        Me.S_FM_YMD.Size = New System.Drawing.Size(91, 23)
        Me.S_FM_YMD.TabIndex = 57
        Me.Localizer1.SetWordID(Me.S_FM_YMD, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(181, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "~"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Localizer1.SetWordID(Me.Label2, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.S_PROJECT_NM)
        Me.PanelControl2.Controls.Add(Me.S_PROJECT_CD)
        Me.PanelControl2.Controls.Add(Me.Label12)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.Label7)
        Me.PanelControl2.Controls.Add(Me.S_TO_YMD_PREV)
        Me.PanelControl2.Controls.Add(Me.S_FM_YMD_PREV)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.btnPrev)
        Me.PanelControl2.Controls.Add(Me.btnNext)
        Me.PanelControl2.Controls.Add(Me.S_TO_YMD_NEXT)
        Me.PanelControl2.Controls.Add(Me.S_FM_YMD_NEXT)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.S_DEPT_CD)
        Me.PanelControl2.Controls.Add(Me.S_DATE_TYPE)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.S_TO_YMD)
        Me.PanelControl2.Controls.Add(Me.S_FM_YMD)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Location = New System.Drawing.Point(2, 40)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1251, 69)
        Me.PanelControl2.TabIndex = 297
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'S_PROJECT_NM
        '
        Me.S_PROJECT_NM.AutoEllipsis = True
        Me.S_PROJECT_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_PROJECT_NM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_PROJECT_NM.LabelFor = Nothing
        Me.S_PROJECT_NM.Location = New System.Drawing.Point(742, 5)
        Me.S_PROJECT_NM.Name = "S_PROJECT_NM"
        Me.S_PROJECT_NM.Size = New System.Drawing.Size(129, 24)
        Me.S_PROJECT_NM.TabIndex = 10030
        Me.S_PROJECT_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'S_PROJECT_CD
        '
        Me.S_PROJECT_CD.AlwaysSetDisplayParams = False
        Me.S_PROJECT_CD.AutoSuggestion = True
        Me.S_PROJECT_CD.BorderColor = System.Drawing.Color.Silver
        Me.S_PROJECT_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_PROJECT_CD.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_PROJECT_CD.DataParams = "GroupCode:'T16',NameType:''"
        Me.S_PROJECT_CD.DefVal = ""
        Me.S_PROJECT_CD.DisplayParams = "Code:@S_PROJECT_CD,Name:@S_PROJECT_NM"
        Me.S_PROJECT_CD.EditPopup = ""
        Me.S_PROJECT_CD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_PROJECT_CD.IconVisible = True
        Me.S_PROJECT_CD.IsDataStateAware = True
        Me.S_PROJECT_CD.KeepIntegrity = True
        Me.S_PROJECT_CD.Location = New System.Drawing.Point(671, 5)
        Me.S_PROJECT_CD.MaxLength = 10
        Me.S_PROJECT_CD.Name = "S_PROJECT_CD"
        Me.S_PROJECT_CD.NextFocus = "btnSearch"
        Me.S_PROJECT_CD.SearchPopup = "CodeMaster"
        Me.S_PROJECT_CD.Size = New System.Drawing.Size(70, 23)
        Me.S_PROJECT_CD.SuppressValidateCode = False
        Me.S_PROJECT_CD.TabIndex = 10029
        Me.S_PROJECT_CD.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.S_PROJECT_CD.ValidateKeys = "KEY:@S_PROJECT_CD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.LabelFor = Nothing
        Me.Label12.Location = New System.Drawing.Point(614, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 15)
        Me.Label12.TabIndex = 10028
        Me.Label12.Text = "프로젝트"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label12, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.LabelFor = Nothing
        Me.Label8.Location = New System.Drawing.Point(337, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 15)
        Me.Label8.TabIndex = 10023
        Me.Label8.Text = "차주일자"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label8, "")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(29, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 10022
        Me.Label7.Text = "전주일자"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label7, "")
        '
        'S_TO_YMD_PREV
        '
        Me.S_TO_YMD_PREV.BorderColor = System.Drawing.Color.Silver
        Me.S_TO_YMD_PREV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_TO_YMD_PREV.DefVal = ""
        Me.S_TO_YMD_PREV.Enabled = False
        Me.S_TO_YMD_PREV.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_TO_YMD_PREV.IconVisible = True
        Me.S_TO_YMD_PREV.IsDataStateAware = True
        Me.S_TO_YMD_PREV.Location = New System.Drawing.Point(194, 32)
        Me.S_TO_YMD_PREV.Name = "S_TO_YMD_PREV"
        Me.S_TO_YMD_PREV.NextFocus = ""
        Me.S_TO_YMD_PREV.Size = New System.Drawing.Size(91, 23)
        Me.S_TO_YMD_PREV.TabIndex = 10019
        Me.Localizer1.SetWordID(Me.S_TO_YMD_PREV, "")
        '
        'S_FM_YMD_PREV
        '
        Me.S_FM_YMD_PREV.BorderColor = System.Drawing.Color.Silver
        Me.S_FM_YMD_PREV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_FM_YMD_PREV.DefVal = ""
        Me.S_FM_YMD_PREV.Enabled = False
        Me.S_FM_YMD_PREV.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_FM_YMD_PREV.IconVisible = True
        Me.S_FM_YMD_PREV.IsDataStateAware = True
        Me.S_FM_YMD_PREV.Location = New System.Drawing.Point(90, 32)
        Me.S_FM_YMD_PREV.Name = "S_FM_YMD_PREV"
        Me.S_FM_YMD_PREV.NextFocus = ""
        Me.S_FM_YMD_PREV.Size = New System.Drawing.Size(91, 23)
        Me.S_FM_YMD_PREV.TabIndex = 10020
        Me.Localizer1.SetWordID(Me.S_FM_YMD_PREV, "")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(181, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 15)
        Me.Label6.TabIndex = 10021
        Me.Label6.Text = "~"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Localizer1.SetWordID(Me.Label6, "")
        '
        'btnPrev
        '
        Me.btnPrev.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPrev.Appearance.Options.UseFont = True
        Me.btnPrev.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnPrev.Location = New System.Drawing.Point(287, 5)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(17, 25)
        Me.btnPrev.TabIndex = 305
        Me.btnPrev.Text = "<"
        Me.Localizer1.SetWordID(Me.btnPrev, "")
        '
        'btnNext
        '
        Me.btnNext.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNext.Appearance.Options.UseFont = True
        Me.btnNext.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNext.Location = New System.Drawing.Point(305, 5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(17, 25)
        Me.btnNext.TabIndex = 304
        Me.btnNext.Text = ">"
        Me.Localizer1.SetWordID(Me.btnNext, "")
        '
        'S_TO_YMD_NEXT
        '
        Me.S_TO_YMD_NEXT.BorderColor = System.Drawing.Color.Silver
        Me.S_TO_YMD_NEXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_TO_YMD_NEXT.DefVal = ""
        Me.S_TO_YMD_NEXT.Enabled = False
        Me.S_TO_YMD_NEXT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_TO_YMD_NEXT.IconVisible = True
        Me.S_TO_YMD_NEXT.IsDataStateAware = True
        Me.S_TO_YMD_NEXT.Location = New System.Drawing.Point(502, 32)
        Me.S_TO_YMD_NEXT.Name = "S_TO_YMD_NEXT"
        Me.S_TO_YMD_NEXT.NextFocus = ""
        Me.S_TO_YMD_NEXT.Size = New System.Drawing.Size(91, 23)
        Me.S_TO_YMD_NEXT.TabIndex = 10016
        Me.Localizer1.SetWordID(Me.S_TO_YMD_NEXT, "")
        '
        'S_FM_YMD_NEXT
        '
        Me.S_FM_YMD_NEXT.BorderColor = System.Drawing.Color.Silver
        Me.S_FM_YMD_NEXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_FM_YMD_NEXT.DefVal = ""
        Me.S_FM_YMD_NEXT.Enabled = False
        Me.S_FM_YMD_NEXT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_FM_YMD_NEXT.IconVisible = True
        Me.S_FM_YMD_NEXT.IsDataStateAware = True
        Me.S_FM_YMD_NEXT.Location = New System.Drawing.Point(398, 32)
        Me.S_FM_YMD_NEXT.Name = "S_FM_YMD_NEXT"
        Me.S_FM_YMD_NEXT.NextFocus = ""
        Me.S_FM_YMD_NEXT.Size = New System.Drawing.Size(91, 23)
        Me.S_FM_YMD_NEXT.TabIndex = 10017
        Me.Localizer1.SetWordID(Me.S_FM_YMD_NEXT, "")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(489, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 10018
        Me.Label4.Text = "~"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Localizer1.SetWordID(Me.Label4, "")
        '
        'xtpSend
        '
        Me.xtpSend.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpSend.Appearance.Header.Options.UseFont = True
        Me.xtpSend.Appearance.Header.Options.UseTextOptions = True
        Me.xtpSend.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpSend.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpSend.Appearance.HeaderActive.Options.UseFont = True
        Me.xtpSend.Appearance.HeaderActive.Options.UseTextOptions = True
        Me.xtpSend.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpSend.Controls.Add(Me.WG02_EDI)
        Me.xtpSend.Name = "xtpSend"
        Me.xtpSend.PageVisible = False
        Me.xtpSend.Size = New System.Drawing.Size(1239, 142)
        Me.xtpSend.TabPageWidth = 80
        Me.xtpSend.Text = "전송 건수"
        Me.Localizer1.SetWordID(Me.xtpSend, "전송 건수")
        '
        'WG02_EDI
        '
        Me.WG02_EDI.AllowClientBinding = True
        Me.WG02_EDI.DeleteRowConfirmation = True
        Me.WG02_EDI.DisplayCurrentRow = False
        Me.WG02_EDI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG02_EDI.IsDataStateAware = True
        Me.WG02_EDI.Location = New System.Drawing.Point(0, 0)
        Me.WG02_EDI.MainView = Me.GV02_EDI
        Me.WG02_EDI.Name = "WG02_EDI"
        Me.WG02_EDI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG02_EDI.SaveLayout = True
        Me.WG02_EDI.Size = New System.Drawing.Size(1239, 142)
        Me.WG02_EDI.TabIndex = 308
        Me.WG02_EDI.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG02_EDI.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV02_EDI, Me.GridView13})
        '
        'GV02_EDI
        '
        Me.GV02_EDI.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV02_EDI.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV02_EDI.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand2, Me.gridBand3, Me.gridBand4, Me.gridBand5, Me.gridBand6})
        Me.GV02_EDI.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.GridColumn15, Me.GridColumn16_해상, Me.GridColumn17_해상, Me.GridColumn18_해상, Me.BandedGridColumn1_항공, Me.BandedGridColumn2_항공, Me.BandedGridColumn3_항공, Me.BandedGridColumn1_AMS, Me.BandedGridColumn2_AMS, Me.BandedGridColumn3_AMS, Me.BandedGridColumn1_합계, Me.BandedGridColumn2_합계, Me.BandedGridColumn3_합계})
        Me.GV02_EDI.GridControl = Me.WG02_EDI
        Me.GV02_EDI.Name = "GV02_EDI"
        Me.GV02_EDI.OptionsBehavior.Editable = False
        Me.GV02_EDI.OptionsBehavior.ReadOnly = True
        Me.GV02_EDI.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV02_EDI.OptionsView.BestFitMaxRowCount = 10
        Me.GV02_EDI.OptionsView.ColumnAutoWidth = False
        Me.GV02_EDI.OptionsView.EnableAppearanceEvenRow = True
        Me.GV02_EDI.OptionsView.ShowFooter = True
        Me.GV02_EDI.OptionsView.ShowGroupPanel = False
        Me.GV02_EDI.OptionsView.ShowViewCaption = True
        Me.GV02_EDI.RowHeight = 10
        Me.GV02_EDI.ViewCaption = " ELVIS CHAIN 전송 현황 (총 384 고객)"
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "gridBand2"
        Me.gridBand2.Columns.Add(Me.GridColumn15)
        Me.gridBand2.MinWidth = 20
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 0
        Me.gridBand2.Width = 159
        Me.Localizer1.SetWordID(Me.gridBand2, "")
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn15.AppearanceCell.Options.UseFont = True
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn15.AppearanceHeader.Options.UseFont = True
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "구분"
        Me.GridColumn15.FieldName = "INS_USR"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn15.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "INS_USR", "합계")})
        Me.GridColumn15.Visible = True
        Me.GridColumn15.Width = 159
        Me.Localizer1.SetWordID(Me.GridColumn15, "")
        '
        'gridBand3
        '
        Me.gridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand3.Caption = "해상"
        Me.gridBand3.Columns.Add(Me.GridColumn16_해상)
        Me.gridBand3.Columns.Add(Me.GridColumn17_해상)
        Me.gridBand3.Columns.Add(Me.GridColumn18_해상)
        Me.gridBand3.MinWidth = 20
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 1
        Me.gridBand3.Width = 240
        Me.Localizer1.SetWordID(Me.gridBand3, "")
        '
        'GridColumn16_해상
        '
        Me.GridColumn16_해상.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn16_해상.AppearanceCell.Options.UseFont = True
        Me.GridColumn16_해상.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn16_해상.AppearanceHeader.Options.UseFont = True
        Me.GridColumn16_해상.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16_해상.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16_해상.Caption = "고객수"
        Me.GridColumn16_해상.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn16_해상.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16_해상.FieldName = "CUST_NM"
        Me.GridColumn16_해상.Name = "GridColumn16_해상"
        Me.GridColumn16_해상.OptionsColumn.AllowEdit = False
        Me.GridColumn16_해상.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridColumn16_해상.OptionsColumn.ReadOnly = True
        Me.GridColumn16_해상.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn16_해상.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.GridColumn16_해상.Visible = True
        Me.GridColumn16_해상.Width = 80
        Me.Localizer1.SetWordID(Me.GridColumn16_해상, "")
        '
        'GridColumn17_해상
        '
        Me.GridColumn17_해상.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn17_해상.AppearanceCell.Options.UseFont = True
        Me.GridColumn17_해상.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn17_해상.AppearanceHeader.Options.UseFont = True
        Me.GridColumn17_해상.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17_해상.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17_해상.Caption = "금주"
        Me.GridColumn17_해상.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn17_해상.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn17_해상.FieldName = "WORK_USR"
        Me.GridColumn17_해상.Name = "GridColumn17_해상"
        Me.GridColumn17_해상.OptionsColumn.AllowEdit = False
        Me.GridColumn17_해상.OptionsColumn.ReadOnly = True
        Me.GridColumn17_해상.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn17_해상.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.GridColumn17_해상.Visible = True
        Me.GridColumn17_해상.Width = 80
        Me.Localizer1.SetWordID(Me.GridColumn17_해상, "")
        '
        'GridColumn18_해상
        '
        Me.GridColumn18_해상.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn18_해상.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18_해상.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18_해상.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18_해상.Caption = "월누계"
        Me.GridColumn18_해상.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn18_해상.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn18_해상.FieldName = "REQ_DATE"
        Me.GridColumn18_해상.Name = "GridColumn18_해상"
        Me.GridColumn18_해상.OptionsColumn.AllowEdit = False
        Me.GridColumn18_해상.OptionsColumn.ReadOnly = True
        Me.GridColumn18_해상.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.GridColumn18_해상.Visible = True
        Me.GridColumn18_해상.Width = 80
        Me.Localizer1.SetWordID(Me.GridColumn18_해상, "")
        '
        'gridBand4
        '
        Me.gridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand4.Caption = "항공"
        Me.gridBand4.Columns.Add(Me.BandedGridColumn1_항공)
        Me.gridBand4.Columns.Add(Me.BandedGridColumn2_항공)
        Me.gridBand4.Columns.Add(Me.BandedGridColumn3_항공)
        Me.gridBand4.MinWidth = 20
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 2
        Me.gridBand4.Width = 225
        Me.Localizer1.SetWordID(Me.gridBand4, "")
        '
        'BandedGridColumn1_항공
        '
        Me.BandedGridColumn1_항공.Caption = "고객수"
        Me.BandedGridColumn1_항공.DisplayFormat.FormatString = "{0:n0}"
        Me.BandedGridColumn1_항공.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn1_항공.Name = "BandedGridColumn1_항공"
        Me.BandedGridColumn1_항공.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.BandedGridColumn1_항공.Visible = True
        Me.Localizer1.SetWordID(Me.BandedGridColumn1_항공, "")
        '
        'BandedGridColumn2_항공
        '
        Me.BandedGridColumn2_항공.Caption = "금주"
        Me.BandedGridColumn2_항공.DisplayFormat.FormatString = "{0:n0}"
        Me.BandedGridColumn2_항공.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn2_항공.Name = "BandedGridColumn2_항공"
        Me.BandedGridColumn2_항공.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.BandedGridColumn2_항공.Visible = True
        Me.Localizer1.SetWordID(Me.BandedGridColumn2_항공, "")
        '
        'BandedGridColumn3_항공
        '
        Me.BandedGridColumn3_항공.Caption = "월누계"
        Me.BandedGridColumn3_항공.DisplayFormat.FormatString = "{0:n0}"
        Me.BandedGridColumn3_항공.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn3_항공.Name = "BandedGridColumn3_항공"
        Me.BandedGridColumn3_항공.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.BandedGridColumn3_항공.Visible = True
        Me.Localizer1.SetWordID(Me.BandedGridColumn3_항공, "")
        '
        'gridBand5
        '
        Me.gridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand5.Caption = "AMS"
        Me.gridBand5.Columns.Add(Me.BandedGridColumn1_AMS)
        Me.gridBand5.Columns.Add(Me.BandedGridColumn2_AMS)
        Me.gridBand5.Columns.Add(Me.BandedGridColumn3_AMS)
        Me.gridBand5.MinWidth = 20
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.VisibleIndex = 3
        Me.gridBand5.Width = 225
        Me.Localizer1.SetWordID(Me.gridBand5, "")
        '
        'BandedGridColumn1_AMS
        '
        Me.BandedGridColumn1_AMS.Caption = "고객수"
        Me.BandedGridColumn1_AMS.DisplayFormat.FormatString = "{0:n0}"
        Me.BandedGridColumn1_AMS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn1_AMS.Name = "BandedGridColumn1_AMS"
        Me.BandedGridColumn1_AMS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.BandedGridColumn1_AMS.Visible = True
        Me.Localizer1.SetWordID(Me.BandedGridColumn1_AMS, "")
        '
        'BandedGridColumn2_AMS
        '
        Me.BandedGridColumn2_AMS.Caption = "금주"
        Me.BandedGridColumn2_AMS.DisplayFormat.FormatString = "{0:n0}"
        Me.BandedGridColumn2_AMS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn2_AMS.Name = "BandedGridColumn2_AMS"
        Me.BandedGridColumn2_AMS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.BandedGridColumn2_AMS.Visible = True
        Me.Localizer1.SetWordID(Me.BandedGridColumn2_AMS, "")
        '
        'BandedGridColumn3_AMS
        '
        Me.BandedGridColumn3_AMS.Caption = "월누계"
        Me.BandedGridColumn3_AMS.DisplayFormat.FormatString = "{0:n0}"
        Me.BandedGridColumn3_AMS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn3_AMS.Name = "BandedGridColumn3_AMS"
        Me.BandedGridColumn3_AMS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.BandedGridColumn3_AMS.Visible = True
        Me.Localizer1.SetWordID(Me.BandedGridColumn3_AMS, "")
        '
        'gridBand6
        '
        Me.gridBand6.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand6.Caption = "합계"
        Me.gridBand6.Columns.Add(Me.BandedGridColumn1_합계)
        Me.gridBand6.Columns.Add(Me.BandedGridColumn2_합계)
        Me.gridBand6.Columns.Add(Me.BandedGridColumn3_합계)
        Me.gridBand6.MinWidth = 20
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.VisibleIndex = 4
        Me.gridBand6.Width = 225
        Me.Localizer1.SetWordID(Me.gridBand6, "")
        '
        'BandedGridColumn1_합계
        '
        Me.BandedGridColumn1_합계.Caption = "고객수"
        Me.BandedGridColumn1_합계.DisplayFormat.FormatString = "{0:n0}"
        Me.BandedGridColumn1_합계.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn1_합계.Name = "BandedGridColumn1_합계"
        Me.BandedGridColumn1_합계.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.BandedGridColumn1_합계.Visible = True
        Me.Localizer1.SetWordID(Me.BandedGridColumn1_합계, "")
        '
        'BandedGridColumn2_합계
        '
        Me.BandedGridColumn2_합계.Caption = "금주"
        Me.BandedGridColumn2_합계.DisplayFormat.FormatString = "{0:n0}"
        Me.BandedGridColumn2_합계.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn2_합계.Name = "BandedGridColumn2_합계"
        Me.BandedGridColumn2_합계.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.BandedGridColumn2_합계.Visible = True
        Me.Localizer1.SetWordID(Me.BandedGridColumn2_합계, "")
        '
        'BandedGridColumn3_합계
        '
        Me.BandedGridColumn3_합계.Caption = "월누계"
        Me.BandedGridColumn3_합계.DisplayFormat.FormatString = "{0:n0}"
        Me.BandedGridColumn3_합계.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BandedGridColumn3_합계.Name = "BandedGridColumn3_합계"
        Me.BandedGridColumn3_합계.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:n0}", "")})
        Me.BandedGridColumn3_합계.Visible = True
        Me.Localizer1.SetWordID(Me.BandedGridColumn3_합계, "")
        '
        'GridView13
        '
        Me.GridView13.GridControl = Me.WG02_EDI
        Me.GridView13.Name = "GridView13"
        '
        'xtcAnalysis
        '
        Me.xtcAnalysis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcAnalysis.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtcAnalysis.Appearance.Options.UseFont = True
        Me.xtcAnalysis.Location = New System.Drawing.Point(2, 115)
        Me.xtcAnalysis.Name = "xtcAnalysis"
        Me.xtcAnalysis.SelectedTabPage = Me.xtpHelp
        Me.xtcAnalysis.Size = New System.Drawing.Size(1251, 375)
        Me.xtcAnalysis.TabIndex = 304
        Me.xtcAnalysis.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpSales, Me.xtpDev, Me.xtpHelp, Me.xtpAccount})
        Me.Localizer1.SetWordID(Me.xtcAnalysis, "")
        '
        'xtpHelp
        '
        Me.xtpHelp.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpHelp.Appearance.Header.Options.UseFont = True
        Me.xtpHelp.Appearance.Header.Options.UseTextOptions = True
        Me.xtpHelp.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpHelp.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpHelp.Appearance.HeaderActive.Options.UseFont = True
        Me.xtpHelp.Appearance.HeaderActive.Options.UseTextOptions = True
        Me.xtpHelp.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpHelp.Controls.Add(Me.WG01_PGC)
        Me.xtpHelp.Name = "xtpHelp"
        Me.xtpHelp.Size = New System.Drawing.Size(1245, 345)
        Me.xtpHelp.TabPageWidth = 80
        Me.xtpHelp.Text = "고객지원팀"
        Me.Localizer1.SetWordID(Me.xtpHelp, "")
        '
        'WG01_PGC
        '
        Me.WG01_PGC.Appearance.ColumnHeaderArea.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.WG01_PGC.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.WG01_PGC.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.WG01_PGC.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.WG01_PGC.Appearance.HeaderArea.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.WG01_PGC.Appearance.HeaderArea.Options.UseFont = True
        Me.WG01_PGC.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.WG01_PGC.Appearance.TotalCell.Options.UseBackColor = True
        Me.WG01_PGC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG01_PGC.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PGV_PIVOT_CNT, Me.PGV_WORK_USR, Me.PGV_REQ_SVC_GRP})
        Me.WG01_PGC.Location = New System.Drawing.Point(0, 0)
        Me.WG01_PGC.Name = "WG01_PGC"
        Me.WG01_PGC.OptionsCustomization.AllowDrag = False
        Me.WG01_PGC.OptionsCustomization.AllowDragInCustomizationForm = False
        Me.WG01_PGC.OptionsCustomization.AllowFilter = False
        Me.WG01_PGC.OptionsPrint.MergeRowFieldValues = False
        Me.WG01_PGC.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.WG01_PGC.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.WG01_PGC.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.WG01_PGC.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.WG01_PGC.OptionsPrint.PrintUnusedFilterFields = False
        Me.WG01_PGC.OptionsSelection.CellSelection = False
        Me.WG01_PGC.OptionsSelection.MultiSelect = False
        Me.WG01_PGC.OptionsView.ShowColumnHeaders = False
        Me.WG01_PGC.OptionsView.ShowDataHeaders = False
        Me.WG01_PGC.OptionsView.ShowFilterHeaders = False
        Me.WG01_PGC.OptionsView.ShowFilterSeparatorBar = False
        Me.WG01_PGC.Size = New System.Drawing.Size(1245, 345)
        Me.WG01_PGC.TabIndex = 167
        Me.Localizer1.SetWordID(Me.WG01_PGC, "")
        '
        'PGV_PIVOT_CNT
        '
        Me.PGV_PIVOT_CNT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGV_PIVOT_CNT.AreaIndex = 0
        Me.PGV_PIVOT_CNT.Caption = "건수"
        Me.PGV_PIVOT_CNT.CellFormat.FormatString = "{0:N0}"
        Me.PGV_PIVOT_CNT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGV_PIVOT_CNT.FieldName = "PIVOT_CNT"
        Me.PGV_PIVOT_CNT.Name = "PGV_PIVOT_CNT"
        '
        'PGV_WORK_USR
        '
        Me.PGV_WORK_USR.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PGV_WORK_USR.Appearance.Header.Options.UseFont = True
        Me.PGV_WORK_USR.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PGV_WORK_USR.AreaIndex = 0
        Me.PGV_WORK_USR.Caption = "작업자"
        Me.PGV_WORK_USR.CellFormat.FormatString = "{0:N0}"
        Me.PGV_WORK_USR.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGV_WORK_USR.FieldName = "WORK_USR"
        Me.PGV_WORK_USR.Name = "PGV_WORK_USR"
        Me.PGV_WORK_USR.Width = 50
        '
        'PGV_REQ_SVC_GRP
        '
        Me.PGV_REQ_SVC_GRP.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PGV_REQ_SVC_GRP.Appearance.Header.Options.UseFont = True
        Me.PGV_REQ_SVC_GRP.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGV_REQ_SVC_GRP.AreaIndex = 0
        Me.PGV_REQ_SVC_GRP.Caption = "항목"
        Me.PGV_REQ_SVC_GRP.CellFormat.FormatString = "{0:N0}"
        Me.PGV_REQ_SVC_GRP.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGV_REQ_SVC_GRP.FieldName = "REQ_SVC_GRP"
        Me.PGV_REQ_SVC_GRP.Name = "PGV_REQ_SVC_GRP"
        '
        'xtpSales
        '
        Me.xtpSales.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpSales.Appearance.Header.Options.UseFont = True
        Me.xtpSales.Appearance.Header.Options.UseTextOptions = True
        Me.xtpSales.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpSales.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpSales.Appearance.HeaderActive.Options.UseFont = True
        Me.xtpSales.Appearance.HeaderActive.Options.UseTextOptions = True
        Me.xtpSales.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpSales.Controls.Add(Me.WG04C)
        Me.xtpSales.Controls.Add(Me.splitLeft)
        Me.xtpSales.Name = "xtpSales"
        Me.xtpSales.PageVisible = False
        Me.xtpSales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtpSales.Size = New System.Drawing.Size(1245, 345)
        Me.xtpSales.TabPageWidth = 80
        Me.xtpSales.Text = "솔루션사업팀"
        Me.Localizer1.SetWordID(Me.xtpSales, "")
        '
        'WG04C
        '
        Me.WG04C.AllowClientBinding = True
        Me.WG04C.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG04C.DeleteRowConfirmation = True
        Me.WG04C.DisplayCurrentRow = False
        Me.WG04C.IsDataStateAware = True
        Me.WG04C.Location = New System.Drawing.Point(190, 2)
        Me.WG04C.MainView = Me.GV04C
        Me.WG04C.Name = "WG04C"
        Me.WG04C.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG04C.SaveLayout = False
        Me.WG04C.Size = New System.Drawing.Size(804, 341)
        Me.WG04C.TabIndex = 320
        Me.WG04C.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG04C.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV04C, Me.GridView16})
        '
        'GV04C
        '
        Me.GV04C.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV04C.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV04C.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV04C_MNGT_NO, Me.GV04C_DEPT_CD, Me.GV04C_CUST_NM, Me.GV04C_ITEM_NM, Me.GV04C_ORD_AMT, Me.GV04C_CTRT_AMT, Me.GV04C_IDC_AMT, Me.GV04C_MATN_AMT, Me.GV04C_CMPT_RATE, Me.GV04C_RMK})
        Me.GV04C.GridControl = Me.WG04C
        Me.GV04C.Name = "GV04C"
        Me.GV04C.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GV04C.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV04C.OptionsView.BestFitMaxRowCount = 10
        Me.GV04C.OptionsView.ColumnAutoWidth = False
        Me.GV04C.OptionsView.EnableAppearanceEvenRow = True
        Me.GV04C.OptionsView.ShowGroupPanel = False
        Me.GV04C.RowHeight = 10
        Me.GV04C.ViewCaption = " "
        '
        'GV04C_MNGT_NO
        '
        Me.GV04C_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04C_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04C_MNGT_NO.Caption = "관리번호"
        Me.GV04C_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV04C_MNGT_NO.Name = "GV04C_MNGT_NO"
        Me.GV04C_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV04C_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV04C_MNGT_NO.Width = 20
        Me.Localizer1.SetWordID(Me.GV04C_MNGT_NO, "관리번호")
        '
        'GV04C_DEPT_CD
        '
        Me.GV04C_DEPT_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04C_DEPT_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04C_DEPT_CD.Caption = "부서"
        Me.GV04C_DEPT_CD.FieldName = "DEPT_CD"
        Me.GV04C_DEPT_CD.Name = "GV04C_DEPT_CD"
        Me.GV04C_DEPT_CD.Width = 20
        Me.Localizer1.SetWordID(Me.GV04C_DEPT_CD, "부서")
        '
        'GV04C_CUST_NM
        '
        Me.GV04C_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04C_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04C_CUST_NM.Caption = "상호명"
        Me.GV04C_CUST_NM.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GV04C_CUST_NM.FieldName = "CUST_NM"
        Me.GV04C_CUST_NM.Name = "GV04C_CUST_NM"
        Me.GV04C_CUST_NM.Visible = True
        Me.GV04C_CUST_NM.VisibleIndex = 0
        Me.GV04C_CUST_NM.Width = 120
        Me.Localizer1.SetWordID(Me.GV04C_CUST_NM, "상호명")
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.MaxLength = 100
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'GV04C_ITEM_NM
        '
        Me.GV04C_ITEM_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV04C_ITEM_NM.AppearanceCell.Options.UseFont = True
        Me.GV04C_ITEM_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV04C_ITEM_NM.AppearanceHeader.Options.UseFont = True
        Me.GV04C_ITEM_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04C_ITEM_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04C_ITEM_NM.Caption = "품목"
        Me.GV04C_ITEM_NM.ColumnEdit = Me.rpText_100
        Me.GV04C_ITEM_NM.FieldName = "ITEM_NM"
        Me.GV04C_ITEM_NM.Name = "GV04C_ITEM_NM"
        Me.GV04C_ITEM_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV04C_ITEM_NM.ToolTip = "SI의 경우 사업명"
        Me.GV04C_ITEM_NM.Visible = True
        Me.GV04C_ITEM_NM.VisibleIndex = 3
        Me.GV04C_ITEM_NM.Width = 120
        Me.Localizer1.SetWordID(Me.GV04C_ITEM_NM, "품목")
        '
        'rpText_100
        '
        Me.rpText_100.AutoHeight = False
        Me.rpText_100.MaxLength = 100
        Me.rpText_100.Name = "rpText_100"
        '
        'GV04C_ORD_AMT
        '
        Me.GV04C_ORD_AMT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV04C_ORD_AMT.AppearanceCell.Options.UseFont = True
        Me.GV04C_ORD_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV04C_ORD_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV04C_ORD_AMT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV04C_ORD_AMT.AppearanceHeader.Options.UseFont = True
        Me.GV04C_ORD_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04C_ORD_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04C_ORD_AMT.Caption = "SI수주금액"
        Me.GV04C_ORD_AMT.ColumnEdit = Me.rpText_100
        Me.GV04C_ORD_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV04C_ORD_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV04C_ORD_AMT.FieldName = "ORD_AMT"
        Me.GV04C_ORD_AMT.Name = "GV04C_ORD_AMT"
        Me.GV04C_ORD_AMT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV04C_ORD_AMT.Visible = True
        Me.GV04C_ORD_AMT.VisibleIndex = 4
        Me.GV04C_ORD_AMT.Width = 65
        Me.Localizer1.SetWordID(Me.GV04C_ORD_AMT, "SI수주금액")
        '
        'GV04C_CTRT_AMT
        '
        Me.GV04C_CTRT_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV04C_CTRT_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV04C_CTRT_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04C_CTRT_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04C_CTRT_AMT.Caption = "설치비"
        Me.GV04C_CTRT_AMT.ColumnEdit = Me.rpText_100
        Me.GV04C_CTRT_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV04C_CTRT_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV04C_CTRT_AMT.FieldName = "CTRT_AMT"
        Me.GV04C_CTRT_AMT.Name = "GV04C_CTRT_AMT"
        Me.GV04C_CTRT_AMT.Visible = True
        Me.GV04C_CTRT_AMT.VisibleIndex = 5
        Me.GV04C_CTRT_AMT.Width = 65
        Me.Localizer1.SetWordID(Me.GV04C_CTRT_AMT, "설치비")
        '
        'GV04C_IDC_AMT
        '
        Me.GV04C_IDC_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV04C_IDC_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV04C_IDC_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04C_IDC_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04C_IDC_AMT.Caption = "DB임대"
        Me.GV04C_IDC_AMT.ColumnEdit = Me.rpText_100
        Me.GV04C_IDC_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV04C_IDC_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV04C_IDC_AMT.FieldName = "IDC_AMT"
        Me.GV04C_IDC_AMT.Name = "GV04C_IDC_AMT"
        Me.GV04C_IDC_AMT.Visible = True
        Me.GV04C_IDC_AMT.VisibleIndex = 1
        Me.GV04C_IDC_AMT.Width = 65
        Me.Localizer1.SetWordID(Me.GV04C_IDC_AMT, "DB임대")
        '
        'GV04C_MATN_AMT
        '
        Me.GV04C_MATN_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV04C_MATN_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV04C_MATN_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04C_MATN_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04C_MATN_AMT.Caption = "유지보수"
        Me.GV04C_MATN_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV04C_MATN_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV04C_MATN_AMT.FieldName = "MATN_AMT"
        Me.GV04C_MATN_AMT.Name = "GV04C_MATN_AMT"
        Me.GV04C_MATN_AMT.Visible = True
        Me.GV04C_MATN_AMT.VisibleIndex = 2
        Me.GV04C_MATN_AMT.Width = 65
        Me.Localizer1.SetWordID(Me.GV04C_MATN_AMT, "월청구")
        '
        'GV04C_CMPT_RATE
        '
        Me.GV04C_CMPT_RATE.AppearanceCell.Options.UseTextOptions = True
        Me.GV04C_CMPT_RATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV04C_CMPT_RATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04C_CMPT_RATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04C_CMPT_RATE.Caption = "확률"
        Me.GV04C_CMPT_RATE.FieldName = "CMPT_RATE"
        Me.GV04C_CMPT_RATE.Name = "GV04C_CMPT_RATE"
        Me.GV04C_CMPT_RATE.Visible = True
        Me.GV04C_CMPT_RATE.VisibleIndex = 6
        Me.GV04C_CMPT_RATE.Width = 45
        Me.Localizer1.SetWordID(Me.GV04C_CMPT_RATE, "확률")
        '
        'GV04C_RMK
        '
        Me.GV04C_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04C_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04C_RMK.Caption = "영업상담 내용"
        Me.GV04C_RMK.FieldName = "RMK"
        Me.GV04C_RMK.Name = "GV04C_RMK"
        Me.GV04C_RMK.Visible = True
        Me.GV04C_RMK.VisibleIndex = 7
        Me.GV04C_RMK.Width = 260
        Me.Localizer1.SetWordID(Me.GV04C_RMK, "영업상담 내용")
        '
        'GridView16
        '
        Me.GridView16.GridControl = Me.WG04C
        Me.GridView16.Name = "GridView16"
        '
        'splitLeft
        '
        Me.splitLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.splitLeft.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.splitLeft.Horizontal = False
        Me.splitLeft.Location = New System.Drawing.Point(2, 2)
        Me.splitLeft.Name = "splitLeft"
        Me.splitLeft.Panel1.Controls.Add(Me.WG04A)
        Me.splitLeft.Panel1.Text = "Panel1"
        Me.splitLeft.Panel2.Controls.Add(Me.WG04B)
        Me.splitLeft.Panel2.Text = "Panel2"
        Me.splitLeft.Size = New System.Drawing.Size(183, 341)
        Me.splitLeft.SplitterPosition = 173
        Me.splitLeft.TabIndex = 319
        Me.splitLeft.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.splitLeft, "SplitContainerControl1")
        '
        'WG04A
        '
        Me.WG04A.AllowClientBinding = True
        Me.WG04A.DeleteRowConfirmation = True
        Me.WG04A.DisplayCurrentRow = False
        Me.WG04A.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG04A.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.WG04A.IsDataStateAware = True
        Me.WG04A.Location = New System.Drawing.Point(0, 0)
        Me.WG04A.MainView = Me.GV04A
        Me.WG04A.Name = "WG04A"
        Me.WG04A.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG04A.SaveLayout = False
        Me.WG04A.Size = New System.Drawing.Size(183, 173)
        Me.WG04A.TabIndex = 313
        Me.WG04A.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG04A.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV04A, Me.GridView15})
        '
        'GV04A
        '
        Me.GV04A.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV04A.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV04A.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV01A_USR_ID, Me.GV01A_USR_CNT, Me.GV01A_MATN_AMT})
        Me.GV04A.GridControl = Me.WG04A
        Me.GV04A.Name = "GV04A"
        Me.GV04A.OptionsBehavior.Editable = False
        Me.GV04A.OptionsBehavior.ReadOnly = True
        Me.GV04A.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV04A.OptionsView.BestFitMaxRowCount = 10
        Me.GV04A.OptionsView.ColumnAutoWidth = False
        Me.GV04A.OptionsView.EnableAppearanceEvenRow = True
        Me.GV04A.OptionsView.ShowFooter = True
        Me.GV04A.OptionsView.ShowGroupPanel = False
        Me.GV04A.OptionsView.ShowViewCaption = True
        Me.GV04A.RowHeight = 10
        Me.GV04A.ViewCaption = " 담당별 계약건수"
        '
        'GV01A_USR_ID
        '
        Me.GV01A_USR_ID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV01A_USR_ID.AppearanceCell.Options.UseFont = True
        Me.GV01A_USR_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV01A_USR_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV01A_USR_ID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV01A_USR_ID.AppearanceHeader.Options.UseFont = True
        Me.GV01A_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV01A_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV01A_USR_ID.Caption = "담당자"
        Me.GV01A_USR_ID.FieldName = "USR_ID"
        Me.GV01A_USR_ID.Name = "GV01A_USR_ID"
        Me.GV01A_USR_ID.OptionsColumn.AllowEdit = False
        Me.GV01A_USR_ID.OptionsColumn.ReadOnly = True
        Me.GV01A_USR_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV01A_USR_ID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "USR_ID", "합    계")})
        Me.GV01A_USR_ID.Visible = True
        Me.GV01A_USR_ID.VisibleIndex = 0
        Me.GV01A_USR_ID.Width = 70
        Me.Localizer1.SetWordID(Me.GV01A_USR_ID, "담당자")
        '
        'GV01A_USR_CNT
        '
        Me.GV01A_USR_CNT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV01A_USR_CNT.AppearanceCell.Options.UseFont = True
        Me.GV01A_USR_CNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV01A_USR_CNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV01A_USR_CNT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV01A_USR_CNT.AppearanceHeader.Options.UseFont = True
        Me.GV01A_USR_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV01A_USR_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV01A_USR_CNT.Caption = "계약"
        Me.GV01A_USR_CNT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV01A_USR_CNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV01A_USR_CNT.FieldName = "USR_CNT"
        Me.GV01A_USR_CNT.Name = "GV01A_USR_CNT"
        Me.GV01A_USR_CNT.OptionsColumn.AllowEdit = False
        Me.GV01A_USR_CNT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV01A_USR_CNT.OptionsColumn.ReadOnly = True
        Me.GV01A_USR_CNT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV01A_USR_CNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "USR_CNT", "{0:N0}")})
        Me.GV01A_USR_CNT.Visible = True
        Me.GV01A_USR_CNT.VisibleIndex = 1
        Me.GV01A_USR_CNT.Width = 40
        Me.Localizer1.SetWordID(Me.GV01A_USR_CNT, "계약")
        '
        'GV01A_MATN_AMT
        '
        Me.GV01A_MATN_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV01A_MATN_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV01A_MATN_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV01A_MATN_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV01A_MATN_AMT.Caption = "금액"
        Me.GV01A_MATN_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV01A_MATN_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV01A_MATN_AMT.FieldName = "MATN_AMT"
        Me.GV01A_MATN_AMT.Name = "GV01A_MATN_AMT"
        Me.GV01A_MATN_AMT.Visible = True
        Me.GV01A_MATN_AMT.VisibleIndex = 2
        Me.Localizer1.SetWordID(Me.GV01A_MATN_AMT, "")
        '
        'GridView15
        '
        Me.GridView15.GridControl = Me.WG04A
        Me.GridView15.Name = "GridView15"
        '
        'WG04B
        '
        Me.WG04B.AllowClientBinding = True
        Me.WG04B.DeleteRowConfirmation = True
        Me.WG04B.DisplayCurrentRow = False
        Me.WG04B.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG04B.IsDataStateAware = True
        Me.WG04B.Location = New System.Drawing.Point(0, 0)
        Me.WG04B.MainView = Me.GV04B
        Me.WG04B.Name = "WG04B"
        Me.WG04B.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG04B.SaveLayout = False
        Me.WG04B.Size = New System.Drawing.Size(183, 163)
        Me.WG04B.TabIndex = 314
        Me.WG04B.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG04B.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV04B, Me.GridView14})
        '
        'GV04B
        '
        Me.GV04B.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV04B.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV04B.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV04B_CTRT_TYPE, Me.GV04B_CTRT_CNT, Me.GV04B_MATN_AMT})
        Me.GV04B.GridControl = Me.WG04B
        Me.GV04B.Name = "GV04B"
        Me.GV04B.OptionsBehavior.Editable = False
        Me.GV04B.OptionsBehavior.ReadOnly = True
        Me.GV04B.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV04B.OptionsView.BestFitMaxRowCount = 10
        Me.GV04B.OptionsView.ColumnAutoWidth = False
        Me.GV04B.OptionsView.EnableAppearanceEvenRow = True
        Me.GV04B.OptionsView.ShowFooter = True
        Me.GV04B.OptionsView.ShowGroupPanel = False
        Me.GV04B.OptionsView.ShowViewCaption = True
        Me.GV04B.RowHeight = 10
        Me.GV04B.ViewCaption = " 구분별 총진행건"
        '
        'GV04B_CTRT_TYPE
        '
        Me.GV04B_CTRT_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV04B_CTRT_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV04B_CTRT_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV04B_CTRT_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04B_CTRT_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV04B_CTRT_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV04B_CTRT_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04B_CTRT_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04B_CTRT_TYPE.Caption = "구분"
        Me.GV04B_CTRT_TYPE.FieldName = "CTRT_TYPE"
        Me.GV04B_CTRT_TYPE.Name = "GV04B_CTRT_TYPE"
        Me.GV04B_CTRT_TYPE.OptionsColumn.AllowEdit = False
        Me.GV04B_CTRT_TYPE.OptionsColumn.ReadOnly = True
        Me.GV04B_CTRT_TYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV04B_CTRT_TYPE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "CTRT_TYPE", "합    계")})
        Me.GV04B_CTRT_TYPE.Visible = True
        Me.GV04B_CTRT_TYPE.VisibleIndex = 0
        Me.GV04B_CTRT_TYPE.Width = 70
        Me.Localizer1.SetWordID(Me.GV04B_CTRT_TYPE, "구분")
        '
        'GV04B_CTRT_CNT
        '
        Me.GV04B_CTRT_CNT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV04B_CTRT_CNT.AppearanceCell.Options.UseFont = True
        Me.GV04B_CTRT_CNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV04B_CTRT_CNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV04B_CTRT_CNT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV04B_CTRT_CNT.AppearanceHeader.Options.UseFont = True
        Me.GV04B_CTRT_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04B_CTRT_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04B_CTRT_CNT.Caption = "계약"
        Me.GV04B_CTRT_CNT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV04B_CTRT_CNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV04B_CTRT_CNT.FieldName = "CTRT_CNT"
        Me.GV04B_CTRT_CNT.Name = "GV04B_CTRT_CNT"
        Me.GV04B_CTRT_CNT.OptionsColumn.AllowEdit = False
        Me.GV04B_CTRT_CNT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV04B_CTRT_CNT.OptionsColumn.ReadOnly = True
        Me.GV04B_CTRT_CNT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV04B_CTRT_CNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CTRT_CNT", "{0:N0}")})
        Me.GV04B_CTRT_CNT.Visible = True
        Me.GV04B_CTRT_CNT.VisibleIndex = 1
        Me.GV04B_CTRT_CNT.Width = 40
        Me.Localizer1.SetWordID(Me.GV04B_CTRT_CNT, "계약")
        '
        'GV04B_MATN_AMT
        '
        Me.GV04B_MATN_AMT.AppearanceCell.Options.UseTextOptions = True
        Me.GV04B_MATN_AMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV04B_MATN_AMT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV04B_MATN_AMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV04B_MATN_AMT.Caption = "금액"
        Me.GV04B_MATN_AMT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV04B_MATN_AMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV04B_MATN_AMT.FieldName = "MATN_AMT"
        Me.GV04B_MATN_AMT.Name = "GV04B_MATN_AMT"
        Me.GV04B_MATN_AMT.Visible = True
        Me.GV04B_MATN_AMT.VisibleIndex = 2
        Me.Localizer1.SetWordID(Me.GV04B_MATN_AMT, "")
        '
        'GridView14
        '
        Me.GridView14.GridControl = Me.WG04B
        Me.GridView14.Name = "GridView14"
        '
        'xtpDev
        '
        Me.xtpDev.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpDev.Appearance.Header.Options.UseFont = True
        Me.xtpDev.Appearance.Header.Options.UseTextOptions = True
        Me.xtpDev.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpDev.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpDev.Appearance.HeaderActive.Options.UseFont = True
        Me.xtpDev.Appearance.HeaderActive.Options.UseTextOptions = True
        Me.xtpDev.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpDev.Controls.Add(Me.splitMain)
        Me.xtpDev.Controls.Add(Me.PanelControl1)
        Me.xtpDev.Name = "xtpDev"
        Me.xtpDev.Size = New System.Drawing.Size(1245, 345)
        Me.xtpDev.TabPageWidth = 80
        Me.xtpDev.Text = "개발팀"
        Me.Localizer1.SetWordID(Me.xtpDev, "")
        '
        'splitMain
        '
        Me.splitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitMain.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.splitMain.Horizontal = False
        Me.splitMain.Location = New System.Drawing.Point(0, 32)
        Me.splitMain.Name = "splitMain"
        Me.splitMain.Panel1.Controls.Add(Me.WG02)
        Me.splitMain.Panel1.MinSize = 100
        Me.splitMain.Panel1.Text = "Panel1"
        Me.splitMain.Panel2.Controls.Add(Me.xtcDetail)
        Me.splitMain.Panel2.MinSize = 100
        Me.splitMain.Panel2.Text = "Panel2"
        Me.splitMain.Size = New System.Drawing.Size(1245, 313)
        Me.splitMain.SplitterPosition = 136
        Me.splitMain.TabIndex = 312
        Me.splitMain.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.splitMain, "")
        '
        'WG02
        '
        Me.WG02.AllowClientBinding = True
        Me.WG02.DeleteRowConfirmation = True
        Me.WG02.DisplayCurrentRow = False
        Me.WG02.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG02.IsDataStateAware = True
        Me.WG02.Location = New System.Drawing.Point(0, 0)
        Me.WG02.MainView = Me.GV02
        Me.WG02.Name = "WG02"
        Me.WG02.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG02.SaveLayout = False
        Me.WG02.Size = New System.Drawing.Size(1245, 136)
        Me.WG02.TabIndex = 307
        Me.WG02.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG02.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV02})
        '
        'GV02
        '
        Me.GV02.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV02.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV02.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV02_USR_ID, Me.GV02_USR_NM, Me.GV02_PROJECT_CD, Me.GV02_RANK_SORT, Me.GV02_SM_SI_CMPT, Me.GV02_REQ_CNT, Me.GV02_CMPT_CNT, Me.GV02_SCORE_SUM, Me.GV02_SM_SI_PRAR})
        Me.GV02.GridControl = Me.WG02
        Me.GV02.Name = "GV02"
        Me.GV02.OptionsBehavior.Editable = False
        Me.GV02.OptionsBehavior.ReadOnly = True
        Me.GV02.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV02.OptionsView.BestFitMaxRowCount = 10
        Me.GV02.OptionsView.ColumnAutoWidth = False
        Me.GV02.OptionsView.EnableAppearanceEvenRow = True
        Me.GV02.OptionsView.ShowGroupPanel = False
        Me.GV02.RowHeight = 10
        Me.GV02.ViewCaption = " "
        '
        'GV02_USR_ID
        '
        Me.GV02_USR_ID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_USR_ID.AppearanceCell.Options.UseFont = True
        Me.GV02_USR_ID.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_USR_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_USR_ID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_USR_ID.AppearanceHeader.Options.UseFont = True
        Me.GV02_USR_ID.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_USR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_USR_ID.Caption = "담당자ID"
        Me.GV02_USR_ID.FieldName = "USR_ID"
        Me.GV02_USR_ID.Name = "GV02_USR_ID"
        Me.GV02_USR_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_USR_ID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "INS_USR", "합    계")})
        Me.GV02_USR_ID.Width = 154
        Me.Localizer1.SetWordID(Me.GV02_USR_ID, "담당자ID")
        '
        'GV02_USR_NM
        '
        Me.GV02_USR_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_USR_NM.AppearanceCell.Options.UseFont = True
        Me.GV02_USR_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_USR_NM.AppearanceHeader.Options.UseFont = True
        Me.GV02_USR_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_USR_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_USR_NM.Caption = "담당자명"
        Me.GV02_USR_NM.FieldName = "USR_NM"
        Me.GV02_USR_NM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV02_USR_NM.Name = "GV02_USR_NM"
        Me.GV02_USR_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_USR_NM.Visible = True
        Me.GV02_USR_NM.VisibleIndex = 0
        Me.GV02_USR_NM.Width = 65
        Me.Localizer1.SetWordID(Me.GV02_USR_NM, "담당자명")
        '
        'GV02_PROJECT_CD
        '
        Me.GV02_PROJECT_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PROJECT_CD.AppearanceCell.Options.UseFont = True
        Me.GV02_PROJECT_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PROJECT_CD.AppearanceHeader.Options.UseFont = True
        Me.GV02_PROJECT_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PROJECT_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PROJECT_CD.Caption = "프로젝트코드"
        Me.GV02_PROJECT_CD.DisplayFormat.FormatString = "{0:n0}"
        Me.GV02_PROJECT_CD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV02_PROJECT_CD.FieldName = "PROJECT_CD"
        Me.GV02_PROJECT_CD.Name = "GV02_PROJECT_CD"
        Me.GV02_PROJECT_CD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PROJECT_CD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WORK_USR", "{0:n0}")})
        Me.GV02_PROJECT_CD.Width = 120
        Me.Localizer1.SetWordID(Me.GV02_PROJECT_CD, "프로젝트코드")
        '
        'GV02_RANK_SORT
        '
        Me.GV02_RANK_SORT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_RANK_SORT.AppearanceCell.Options.UseFont = True
        Me.GV02_RANK_SORT.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_RANK_SORT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_RANK_SORT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_RANK_SORT.AppearanceHeader.Options.UseFont = True
        Me.GV02_RANK_SORT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_RANK_SORT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_RANK_SORT.Caption = "직위순서"
        Me.GV02_RANK_SORT.DisplayFormat.FormatString = "{0:n0}"
        Me.GV02_RANK_SORT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV02_RANK_SORT.FieldName = "RANK_SORT"
        Me.GV02_RANK_SORT.Name = "GV02_RANK_SORT"
        Me.GV02_RANK_SORT.OptionsColumn.ShowInCustomizationForm = False
        Me.GV02_RANK_SORT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "REQ_DATE", "{0:n0}")})
        Me.GV02_RANK_SORT.Width = 90
        Me.Localizer1.SetWordID(Me.GV02_RANK_SORT, "직위순서")
        '
        'GV02_SM_SI_CMPT
        '
        Me.GV02_SM_SI_CMPT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_SM_SI_CMPT.AppearanceCell.Options.UseFont = True
        Me.GV02_SM_SI_CMPT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_SM_SI_CMPT.AppearanceHeader.Options.UseFont = True
        Me.GV02_SM_SI_CMPT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_SM_SI_CMPT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_SM_SI_CMPT.Caption = "직무내용"
        Me.GV02_SM_SI_CMPT.FieldName = "SM_SI_CMPT"
        Me.GV02_SM_SI_CMPT.Name = "GV02_SM_SI_CMPT"
        Me.GV02_SM_SI_CMPT.Visible = True
        Me.GV02_SM_SI_CMPT.VisibleIndex = 1
        Me.GV02_SM_SI_CMPT.Width = 500
        Me.Localizer1.SetWordID(Me.GV02_SM_SI_CMPT, "직무내용")
        '
        'GV02_REQ_CNT
        '
        Me.GV02_REQ_CNT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_REQ_CNT.AppearanceCell.Options.UseFont = True
        Me.GV02_REQ_CNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_REQ_CNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV02_REQ_CNT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_REQ_CNT.AppearanceHeader.Options.UseFont = True
        Me.GV02_REQ_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_REQ_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_REQ_CNT.Caption = "접수"
        Me.GV02_REQ_CNT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV02_REQ_CNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV02_REQ_CNT.FieldName = "REQ_CNT"
        Me.GV02_REQ_CNT.Name = "GV02_REQ_CNT"
        Me.GV02_REQ_CNT.Visible = True
        Me.GV02_REQ_CNT.VisibleIndex = 2
        Me.GV02_REQ_CNT.Width = 50
        Me.Localizer1.SetWordID(Me.GV02_REQ_CNT, "접수")
        '
        'GV02_CMPT_CNT
        '
        Me.GV02_CMPT_CNT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_CNT.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_CNT.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_CNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV02_CMPT_CNT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_CNT.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_CNT.Caption = "처리"
        Me.GV02_CMPT_CNT.DisplayFormat.FormatString = "{0:N0}"
        Me.GV02_CMPT_CNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV02_CMPT_CNT.FieldName = "CMPT_CNT"
        Me.GV02_CMPT_CNT.Name = "GV02_CMPT_CNT"
        Me.GV02_CMPT_CNT.Visible = True
        Me.GV02_CMPT_CNT.VisibleIndex = 3
        Me.GV02_CMPT_CNT.Width = 50
        Me.Localizer1.SetWordID(Me.GV02_CMPT_CNT, "처리")
        '
        'GV02_SCORE_SUM
        '
        Me.GV02_SCORE_SUM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_SCORE_SUM.AppearanceCell.Options.UseFont = True
        Me.GV02_SCORE_SUM.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_SCORE_SUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV02_SCORE_SUM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_SCORE_SUM.AppearanceHeader.Options.UseFont = True
        Me.GV02_SCORE_SUM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_SCORE_SUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_SCORE_SUM.Caption = "난이도"
        Me.GV02_SCORE_SUM.DisplayFormat.FormatString = "{0:N1}"
        Me.GV02_SCORE_SUM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV02_SCORE_SUM.FieldName = "SCORE_SUM"
        Me.GV02_SCORE_SUM.Name = "GV02_SCORE_SUM"
        Me.GV02_SCORE_SUM.Visible = True
        Me.GV02_SCORE_SUM.VisibleIndex = 4
        Me.GV02_SCORE_SUM.Width = 50
        Me.Localizer1.SetWordID(Me.GV02_SCORE_SUM, "난이도")
        '
        'GV02_SM_SI_PRAR
        '
        Me.GV02_SM_SI_PRAR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_SM_SI_PRAR.AppearanceCell.Options.UseFont = True
        Me.GV02_SM_SI_PRAR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_SM_SI_PRAR.AppearanceHeader.Options.UseFont = True
        Me.GV02_SM_SI_PRAR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_SM_SI_PRAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_SM_SI_PRAR.Caption = "계획"
        Me.GV02_SM_SI_PRAR.FieldName = "SM_SI_PRAR"
        Me.GV02_SM_SI_PRAR.Name = "GV02_SM_SI_PRAR"
        Me.GV02_SM_SI_PRAR.Visible = True
        Me.GV02_SM_SI_PRAR.VisibleIndex = 5
        Me.GV02_SM_SI_PRAR.Width = 250
        Me.Localizer1.SetWordID(Me.GV02_SM_SI_PRAR, "계획")
        '
        'xtcDetail
        '
        Me.xtcDetail.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtcDetail.Appearance.Options.UseFont = True
        Me.xtcDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcDetail.Location = New System.Drawing.Point(0, 0)
        Me.xtcDetail.Name = "xtcDetail"
        Me.xtcDetail.SelectedTabPage = Me.xtpCmpt
        Me.xtcDetail.Size = New System.Drawing.Size(1245, 172)
        Me.xtcDetail.TabIndex = 303
        Me.xtcDetail.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpCmpt, Me.xtpPrar, Me.xtpSend})
        Me.Localizer1.SetWordID(Me.xtcDetail, "")
        '
        'xtpCmpt
        '
        Me.xtpCmpt.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpCmpt.Appearance.Header.Options.UseFont = True
        Me.xtpCmpt.Appearance.Header.Options.UseTextOptions = True
        Me.xtpCmpt.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpCmpt.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpCmpt.Appearance.HeaderActive.Options.UseFont = True
        Me.xtpCmpt.Appearance.HeaderActive.Options.UseTextOptions = True
        Me.xtpCmpt.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpCmpt.Controls.Add(Me.WG02_CMPT_ALL)
        Me.xtpCmpt.Controls.Add(Me.WG02_CMPT)
        Me.xtpCmpt.Name = "xtpCmpt"
        Me.xtpCmpt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtpCmpt.Size = New System.Drawing.Size(1239, 142)
        Me.xtpCmpt.TabPageWidth = 90
        Me.xtpCmpt.Text = "직무내용 자료"
        Me.Localizer1.SetWordID(Me.xtpCmpt, "직무내용 자료")
        '
        'WG02_CMPT_ALL
        '
        Me.WG02_CMPT_ALL.AllowClientBinding = True
        Me.WG02_CMPT_ALL.DeleteRowConfirmation = True
        Me.WG02_CMPT_ALL.DisplayCurrentRow = False
        Me.WG02_CMPT_ALL.IsDataStateAware = True
        Me.WG02_CMPT_ALL.Location = New System.Drawing.Point(396, 30)
        Me.WG02_CMPT_ALL.MainView = Me.GV02_CMPT_ALL
        Me.WG02_CMPT_ALL.Name = "WG02_CMPT_ALL"
        Me.WG02_CMPT_ALL.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit4, Me.RepositoryItemCheckEdit3})
        Me.WG02_CMPT_ALL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG02_CMPT_ALL.SaveLayout = True
        Me.WG02_CMPT_ALL.Size = New System.Drawing.Size(271, 80)
        Me.WG02_CMPT_ALL.TabIndex = 8
        Me.WG02_CMPT_ALL.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG02_CMPT_ALL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV02_CMPT_ALL})
        Me.WG02_CMPT_ALL.Visible = False
        '
        'GV02_CMPT_ALL
        '
        Me.GV02_CMPT_ALL.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV02_CMPT_ALL.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV02_CMPT_ALL.GridControl = Me.WG02_CMPT_ALL
        Me.GV02_CMPT_ALL.Name = "GV02_CMPT_ALL"
        Me.GV02_CMPT_ALL.OptionsCustomization.AllowRowSizing = True
        Me.GV02_CMPT_ALL.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV02_CMPT_ALL.OptionsView.BestFitMaxRowCount = 10
        Me.GV02_CMPT_ALL.OptionsView.ColumnAutoWidth = False
        Me.GV02_CMPT_ALL.OptionsView.ShowGroupPanel = False
        Me.GV02_CMPT_ALL.RowHeight = 10
        Me.GV02_CMPT_ALL.ViewCaption = " 고객 리스트"
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
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit3.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit3.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit3.ValueUnchecked = "N"
        '
        'WG02_CMPT
        '
        Me.WG02_CMPT.AllowClientBinding = True
        Me.WG02_CMPT.DeleteRowConfirmation = True
        Me.WG02_CMPT.DisplayCurrentRow = False
        Me.WG02_CMPT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG02_CMPT.IsDataStateAware = True
        Me.WG02_CMPT.Location = New System.Drawing.Point(0, 0)
        Me.WG02_CMPT.MainView = Me.GV02_CMPT
        Me.WG02_CMPT.Name = "WG02_CMPT"
        Me.WG02_CMPT.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit2, Me.RepositoryItemCheckEdit1, Me.rpMemo})
        Me.WG02_CMPT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG02_CMPT.SaveLayout = True
        Me.WG02_CMPT.Size = New System.Drawing.Size(1239, 142)
        Me.WG02_CMPT.TabIndex = 7
        Me.WG02_CMPT.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG02_CMPT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV02_CMPT})
        '
        'GV02_CMPT
        '
        Me.GV02_CMPT.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV02_CMPT.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV02_CMPT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV02_CMPT_MNGT_NO, Me.GV02_CMPT_PRIORITY, Me.GV02_CMPT_REQ_YMD, Me.GV02_CMPT_REQ_HM, Me.GV02_CMPT_CUST_CD, Me.GV02_CMPT_CUST_NM, Me.GV02_CMPT_CONTENT, Me.GV02_CMPT_REQ_USR, Me.GV02_CMPT_TEL_NO, Me.GV02_CMPT_PROC_TYPE, Me.GV02_CMPT_WORK_USR, Me.GV02_CMPT_PRAR_YMD, Me.GV02_CMPT_CMPT_YMD, Me.GV02_CMPT_INS_USR_NM, Me.GV02_CMPT_FILE_YN, Me.GV02_CMPT_RMK, Me.GV02_CMPT_PGM_MDF, Me.GV02_CMPT_DELAY, Me.GV02_CMPT_DELAY_YN, Me.GV02_CMPT_REQ_SVC, Me.GV02_CMPT_REQ_SVC2, Me.GV02_CMPT_REQ_SVC3, Me.GV02_CMPT_INS_YMD, Me.GV02_CMPT_DEV_ERR_YN, Me.GV02_CMPT_SHARE_YN, Me.GV02_CMPT_RANK, Me.GV02_CMPT_RANK1, Me.GV02_CMPT_SCORE, Me.GV02_CMPT_PROJECT_CD, Me.GV02_CMPT_PROJECT_NM, Me.GV02_CMPT_DEV_SCORE, Me.GV02_CMPT_DEV_SCORE_RMK, Me.GV02_CMPT_SEQ, Me.GV02_CMPT_USR_ID})
        Me.GV02_CMPT.GridControl = Me.WG02_CMPT
        Me.GV02_CMPT.Name = "GV02_CMPT"
        Me.GV02_CMPT.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused
        Me.GV02_CMPT.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV02_CMPT.OptionsView.BestFitMaxRowCount = 10
        Me.GV02_CMPT.OptionsView.ColumnAutoWidth = False
        Me.GV02_CMPT.OptionsView.ShowGroupPanel = False
        Me.GV02_CMPT.RowHeight = 10
        Me.GV02_CMPT.ViewCaption = " 고객 리스트"
        '
        'GV02_CMPT_MNGT_NO
        '
        Me.GV02_CMPT_MNGT_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_MNGT_NO.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_MNGT_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_MNGT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV02_CMPT_MNGT_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_MNGT_NO.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_MNGT_NO.Caption = "관리번호"
        Me.GV02_CMPT_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV02_CMPT_MNGT_NO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV02_CMPT_MNGT_NO.Name = "GV02_CMPT_MNGT_NO"
        Me.GV02_CMPT_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_MNGT_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_MNGT_NO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_MNGT_NO.Visible = True
        Me.GV02_CMPT_MNGT_NO.VisibleIndex = 0
        Me.GV02_CMPT_MNGT_NO.Width = 100
        Me.Localizer1.SetWordID(Me.GV02_CMPT_MNGT_NO, "관리번호")
        '
        'GV02_CMPT_PRIORITY
        '
        Me.GV02_CMPT_PRIORITY.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_PRIORITY.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_PRIORITY.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_PRIORITY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_PRIORITY.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_PRIORITY.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_PRIORITY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_PRIORITY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_PRIORITY.Caption = "우선순위"
        Me.GV02_CMPT_PRIORITY.FieldName = "PRIORITY"
        Me.GV02_CMPT_PRIORITY.Name = "GV02_CMPT_PRIORITY"
        Me.GV02_CMPT_PRIORITY.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_PRIORITY.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_PRIORITY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_PRIORITY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_PRIORITY.Visible = True
        Me.GV02_CMPT_PRIORITY.VisibleIndex = 1
        Me.GV02_CMPT_PRIORITY.Width = 59
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PRIORITY, "우선순위")
        '
        'GV02_CMPT_REQ_YMD
        '
        Me.GV02_CMPT_REQ_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_REQ_YMD.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_REQ_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_REQ_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_REQ_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_REQ_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_REQ_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_REQ_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_REQ_YMD.Caption = "요청일자"
        Me.GV02_CMPT_REQ_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV02_CMPT_REQ_YMD.FieldName = "REQ_YMD"
        Me.GV02_CMPT_REQ_YMD.Name = "GV02_CMPT_REQ_YMD"
        Me.GV02_CMPT_REQ_YMD.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_REQ_YMD.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_REQ_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_REQ_YMD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_REQ_YMD.Visible = True
        Me.GV02_CMPT_REQ_YMD.VisibleIndex = 4
        Me.GV02_CMPT_REQ_YMD.Width = 106
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_YMD, "요청일자")
        '
        'GV02_CMPT_REQ_HM
        '
        Me.GV02_CMPT_REQ_HM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_REQ_HM.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_REQ_HM.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_REQ_HM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_REQ_HM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_REQ_HM.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_REQ_HM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_REQ_HM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_REQ_HM.Caption = "요청시간"
        Me.GV02_CMPT_REQ_HM.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GV02_CMPT_REQ_HM.FieldName = "REQ_HM"
        Me.GV02_CMPT_REQ_HM.Name = "GV02_CMPT_REQ_HM"
        Me.GV02_CMPT_REQ_HM.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_REQ_HM.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_REQ_HM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_REQ_HM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_REQ_HM.Width = 47
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_HM, "요청시간")
        '
        'GV02_CMPT_CUST_CD
        '
        Me.GV02_CMPT_CUST_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_CUST_CD.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_CUST_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_CUST_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_CUST_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_CUST_CD.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_CUST_CD.Caption = "코드"
        Me.GV02_CMPT_CUST_CD.FieldName = "CUST_CD"
        Me.GV02_CMPT_CUST_CD.Name = "GV02_CMPT_CUST_CD"
        Me.GV02_CMPT_CUST_CD.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_CUST_CD.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_CUST_CD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_CUST_CD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_CUST_CD.Visible = True
        Me.GV02_CMPT_CUST_CD.VisibleIndex = 2
        Me.GV02_CMPT_CUST_CD.Width = 57
        Me.Localizer1.SetWordID(Me.GV02_CMPT_CUST_CD, "코드")
        '
        'GV02_CMPT_CUST_NM
        '
        Me.GV02_CMPT_CUST_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_CUST_NM.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_CUST_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_CUST_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV02_CMPT_CUST_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_CUST_NM.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_CUST_NM.Caption = "거래처 명"
        Me.GV02_CMPT_CUST_NM.FieldName = "CUST_NM"
        Me.GV02_CMPT_CUST_NM.Name = "GV02_CMPT_CUST_NM"
        Me.GV02_CMPT_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_CUST_NM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV02_CMPT_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_CUST_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_CUST_NM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_CUST_NM.Visible = True
        Me.GV02_CMPT_CUST_NM.VisibleIndex = 3
        Me.GV02_CMPT_CUST_NM.Width = 85
        Me.Localizer1.SetWordID(Me.GV02_CMPT_CUST_NM, "거래처 명")
        '
        'GV02_CMPT_CONTENT
        '
        Me.GV02_CMPT_CONTENT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_CONTENT.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_CONTENT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_CONTENT.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_CONTENT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_CONTENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_CONTENT.Caption = "고객 요청내용"
        Me.GV02_CMPT_CONTENT.ColumnEdit = Me.rpMemo
        Me.GV02_CMPT_CONTENT.FieldName = "CONTENT"
        Me.GV02_CMPT_CONTENT.Name = "GV02_CMPT_CONTENT"
        Me.GV02_CMPT_CONTENT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_CONTENT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_CONTENT.Visible = True
        Me.GV02_CMPT_CONTENT.VisibleIndex = 8
        Me.GV02_CMPT_CONTENT.Width = 180
        Me.Localizer1.SetWordID(Me.GV02_CMPT_CONTENT, "고객 요청내용")
        '
        'rpMemo
        '
        Me.rpMemo.AutoHeight = False
        Me.rpMemo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpMemo.Name = "rpMemo"
        Me.rpMemo.PopupFormSize = New System.Drawing.Size(400, 200)
        Me.rpMemo.ReadOnly = True
        Me.rpMemo.ShowIcon = False
        '
        'GV02_CMPT_REQ_USR
        '
        Me.GV02_CMPT_REQ_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_REQ_USR.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_REQ_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_REQ_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_REQ_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_REQ_USR.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_REQ_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_REQ_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_REQ_USR.Caption = "요청자"
        Me.GV02_CMPT_REQ_USR.FieldName = "REQ_USR"
        Me.GV02_CMPT_REQ_USR.Name = "GV02_CMPT_REQ_USR"
        Me.GV02_CMPT_REQ_USR.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_REQ_USR.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_REQ_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_REQ_USR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_REQ_USR.Visible = True
        Me.GV02_CMPT_REQ_USR.VisibleIndex = 11
        Me.GV02_CMPT_REQ_USR.Width = 52
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_USR, "요청자")
        '
        'GV02_CMPT_TEL_NO
        '
        Me.GV02_CMPT_TEL_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_TEL_NO.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_TEL_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_TEL_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_TEL_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_TEL_NO.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_TEL_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_TEL_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_TEL_NO.Caption = "연락처"
        Me.GV02_CMPT_TEL_NO.FieldName = "TEL_NO"
        Me.GV02_CMPT_TEL_NO.Name = "GV02_CMPT_TEL_NO"
        Me.GV02_CMPT_TEL_NO.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_TEL_NO.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_TEL_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_TEL_NO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_TEL_NO.Visible = True
        Me.GV02_CMPT_TEL_NO.VisibleIndex = 13
        Me.GV02_CMPT_TEL_NO.Width = 76
        Me.Localizer1.SetWordID(Me.GV02_CMPT_TEL_NO, "연락처")
        '
        'GV02_CMPT_PROC_TYPE
        '
        Me.GV02_CMPT_PROC_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_PROC_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_PROC_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_PROC_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_PROC_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_PROC_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_PROC_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_PROC_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_PROC_TYPE.Caption = "진행현황"
        Me.GV02_CMPT_PROC_TYPE.FieldName = "PROC_TYPE"
        Me.GV02_CMPT_PROC_TYPE.Name = "GV02_CMPT_PROC_TYPE"
        Me.GV02_CMPT_PROC_TYPE.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_PROC_TYPE.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_PROC_TYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_PROC_TYPE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_PROC_TYPE.Visible = True
        Me.GV02_CMPT_PROC_TYPE.VisibleIndex = 5
        Me.GV02_CMPT_PROC_TYPE.Width = 64
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PROC_TYPE, "진행현황")
        '
        'GV02_CMPT_WORK_USR
        '
        Me.GV02_CMPT_WORK_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_WORK_USR.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_WORK_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_WORK_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_WORK_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_WORK_USR.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_WORK_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_WORK_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_WORK_USR.Caption = "담당자"
        Me.GV02_CMPT_WORK_USR.FieldName = "WORK_USR_NM"
        Me.GV02_CMPT_WORK_USR.Name = "GV02_CMPT_WORK_USR"
        Me.GV02_CMPT_WORK_USR.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_WORK_USR.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_WORK_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_WORK_USR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_WORK_USR.Visible = True
        Me.GV02_CMPT_WORK_USR.VisibleIndex = 14
        Me.GV02_CMPT_WORK_USR.Width = 91
        Me.Localizer1.SetWordID(Me.GV02_CMPT_WORK_USR, "담당자")
        '
        'GV02_CMPT_PRAR_YMD
        '
        Me.GV02_CMPT_PRAR_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_PRAR_YMD.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_PRAR_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_PRAR_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_PRAR_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_PRAR_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_PRAR_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_PRAR_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_PRAR_YMD.Caption = "예정일자"
        Me.GV02_CMPT_PRAR_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV02_CMPT_PRAR_YMD.FieldName = "PRAR_YMD"
        Me.GV02_CMPT_PRAR_YMD.Name = "GV02_CMPT_PRAR_YMD"
        Me.GV02_CMPT_PRAR_YMD.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_PRAR_YMD.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_PRAR_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_PRAR_YMD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_PRAR_YMD.Visible = True
        Me.GV02_CMPT_PRAR_YMD.VisibleIndex = 6
        Me.GV02_CMPT_PRAR_YMD.Width = 73
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PRAR_YMD, "예정일자")
        '
        'GV02_CMPT_CMPT_YMD
        '
        Me.GV02_CMPT_CMPT_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_CMPT_YMD.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_CMPT_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_CMPT_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_CMPT_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_CMPT_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_CMPT_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_CMPT_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_CMPT_YMD.Caption = "완료일자"
        Me.GV02_CMPT_CMPT_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV02_CMPT_CMPT_YMD.FieldName = "CMPT_YMD"
        Me.GV02_CMPT_CMPT_YMD.Name = "GV02_CMPT_CMPT_YMD"
        Me.GV02_CMPT_CMPT_YMD.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_CMPT_YMD.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_CMPT_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_CMPT_YMD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_CMPT_YMD.Visible = True
        Me.GV02_CMPT_CMPT_YMD.VisibleIndex = 7
        Me.GV02_CMPT_CMPT_YMD.Width = 71
        Me.Localizer1.SetWordID(Me.GV02_CMPT_CMPT_YMD, "완료일자")
        '
        'GV02_CMPT_INS_USR_NM
        '
        Me.GV02_CMPT_INS_USR_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_INS_USR_NM.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_INS_USR_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_INS_USR_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_INS_USR_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_INS_USR_NM.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_INS_USR_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_INS_USR_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_INS_USR_NM.Caption = "등록자"
        Me.GV02_CMPT_INS_USR_NM.FieldName = "INS_USR_NM"
        Me.GV02_CMPT_INS_USR_NM.Name = "GV02_CMPT_INS_USR_NM"
        Me.GV02_CMPT_INS_USR_NM.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_INS_USR_NM.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_INS_USR_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_CMPT_INS_USR_NM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_INS_USR_NM.Visible = True
        Me.GV02_CMPT_INS_USR_NM.VisibleIndex = 15
        Me.GV02_CMPT_INS_USR_NM.Width = 61
        Me.Localizer1.SetWordID(Me.GV02_CMPT_INS_USR_NM, "등록자")
        '
        'GV02_CMPT_FILE_YN
        '
        Me.GV02_CMPT_FILE_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_FILE_YN.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_FILE_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_FILE_YN.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_FILE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_FILE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_FILE_YN.Caption = "Document"
        Me.GV02_CMPT_FILE_YN.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GV02_CMPT_FILE_YN.FieldName = "FILE_YN"
        Me.GV02_CMPT_FILE_YN.Name = "GV02_CMPT_FILE_YN"
        Me.GV02_CMPT_FILE_YN.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_FILE_YN.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_FILE_YN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_FILE_YN.Visible = True
        Me.GV02_CMPT_FILE_YN.VisibleIndex = 12
        Me.GV02_CMPT_FILE_YN.Width = 22
        Me.Localizer1.SetWordID(Me.GV02_CMPT_FILE_YN, "Document")
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit1.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'GV02_CMPT_RMK
        '
        Me.GV02_CMPT_RMK.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_RMK.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_RMK.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_RMK.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_RMK.Caption = "개발팀 처리내용"
        Me.GV02_CMPT_RMK.ColumnEdit = Me.rpMemo
        Me.GV02_CMPT_RMK.FieldName = "RMK"
        Me.GV02_CMPT_RMK.Name = "GV02_CMPT_RMK"
        Me.GV02_CMPT_RMK.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_RMK.Visible = True
        Me.GV02_CMPT_RMK.VisibleIndex = 9
        Me.GV02_CMPT_RMK.Width = 180
        Me.Localizer1.SetWordID(Me.GV02_CMPT_RMK, "개발팀 처리내용")
        '
        'GV02_CMPT_PGM_MDF
        '
        Me.GV02_CMPT_PGM_MDF.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_PGM_MDF.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_PGM_MDF.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_PGM_MDF.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_PGM_MDF.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_PGM_MDF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_PGM_MDF.Caption = "프로그램 수정사항"
        Me.GV02_CMPT_PGM_MDF.ColumnEdit = Me.rpMemo
        Me.GV02_CMPT_PGM_MDF.FieldName = "PGM_MDF"
        Me.GV02_CMPT_PGM_MDF.Name = "GV02_CMPT_PGM_MDF"
        Me.GV02_CMPT_PGM_MDF.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_PGM_MDF.Visible = True
        Me.GV02_CMPT_PGM_MDF.VisibleIndex = 10
        Me.GV02_CMPT_PGM_MDF.Width = 150
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PGM_MDF, "프로그램 수정사항")
        '
        'GV02_CMPT_DELAY
        '
        Me.GV02_CMPT_DELAY.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_DELAY.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_DELAY.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_DELAY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_DELAY.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_DELAY.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_DELAY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_DELAY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_DELAY.Caption = "Delay"
        Me.GV02_CMPT_DELAY.FieldName = "DELAY"
        Me.GV02_CMPT_DELAY.Name = "GV02_CMPT_DELAY"
        Me.GV02_CMPT_DELAY.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_DELAY.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_DELAY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_DELAY.Visible = True
        Me.GV02_CMPT_DELAY.VisibleIndex = 16
        Me.GV02_CMPT_DELAY.Width = 50
        Me.Localizer1.SetWordID(Me.GV02_CMPT_DELAY, "Delay")
        '
        'GV02_CMPT_DELAY_YN
        '
        Me.GV02_CMPT_DELAY_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_DELAY_YN.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_DELAY_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_DELAY_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_DELAY_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_DELAY_YN.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_DELAY_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_DELAY_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_DELAY_YN.Caption = "Delay(Y/N)"
        Me.GV02_CMPT_DELAY_YN.FieldName = "DELAY_YN"
        Me.GV02_CMPT_DELAY_YN.Name = "GV02_CMPT_DELAY_YN"
        Me.GV02_CMPT_DELAY_YN.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_DELAY_YN.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_DELAY_YN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_DELAY_YN.Visible = True
        Me.GV02_CMPT_DELAY_YN.VisibleIndex = 17
        Me.GV02_CMPT_DELAY_YN.Width = 50
        Me.Localizer1.SetWordID(Me.GV02_CMPT_DELAY_YN, "Delay(Y/N)")
        '
        'GV02_CMPT_REQ_SVC
        '
        Me.GV02_CMPT_REQ_SVC.Caption = "업무구분"
        Me.GV02_CMPT_REQ_SVC.FieldName = "REQ_SVC"
        Me.GV02_CMPT_REQ_SVC.Name = "GV02_CMPT_REQ_SVC"
        Me.GV02_CMPT_REQ_SVC.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_REQ_SVC.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_REQ_SVC.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_REQ_SVC.Visible = True
        Me.GV02_CMPT_REQ_SVC.VisibleIndex = 18
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_SVC, "업무구분")
        '
        'GV02_CMPT_REQ_SVC2
        '
        Me.GV02_CMPT_REQ_SVC2.Caption = "업무구분2"
        Me.GV02_CMPT_REQ_SVC2.FieldName = "REQ_SVC2"
        Me.GV02_CMPT_REQ_SVC2.Name = "GV02_CMPT_REQ_SVC2"
        Me.GV02_CMPT_REQ_SVC2.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_REQ_SVC2.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_REQ_SVC2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_REQ_SVC2.Visible = True
        Me.GV02_CMPT_REQ_SVC2.VisibleIndex = 19
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_SVC2, "업무구분2")
        '
        'GV02_CMPT_REQ_SVC3
        '
        Me.GV02_CMPT_REQ_SVC3.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_REQ_SVC3.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_REQ_SVC3.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_REQ_SVC3.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_REQ_SVC3.Caption = "업무구분3"
        Me.GV02_CMPT_REQ_SVC3.FieldName = "REQ_SVC3"
        Me.GV02_CMPT_REQ_SVC3.Name = "GV02_CMPT_REQ_SVC3"
        Me.GV02_CMPT_REQ_SVC3.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_REQ_SVC3.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_REQ_SVC3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_REQ_SVC3.Visible = True
        Me.GV02_CMPT_REQ_SVC3.VisibleIndex = 20
        Me.Localizer1.SetWordID(Me.GV02_CMPT_REQ_SVC3, "업무구분3")
        '
        'GV02_CMPT_INS_YMD
        '
        Me.GV02_CMPT_INS_YMD.Caption = "등록일자"
        Me.GV02_CMPT_INS_YMD.FieldName = "INS_YMD"
        Me.GV02_CMPT_INS_YMD.Name = "GV02_CMPT_INS_YMD"
        Me.GV02_CMPT_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_INS_YMD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_INS_YMD.Visible = True
        Me.GV02_CMPT_INS_YMD.VisibleIndex = 21
        Me.Localizer1.SetWordID(Me.GV02_CMPT_INS_YMD, "등록일자")
        '
        'GV02_CMPT_DEV_ERR_YN
        '
        Me.GV02_CMPT_DEV_ERR_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_DEV_ERR_YN.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_DEV_ERR_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_DEV_ERR_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_DEV_ERR_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_DEV_ERR_YN.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_DEV_ERR_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_DEV_ERR_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_DEV_ERR_YN.Caption = "결함"
        Me.GV02_CMPT_DEV_ERR_YN.FieldName = "DEV_ERR_YN"
        Me.GV02_CMPT_DEV_ERR_YN.Name = "GV02_CMPT_DEV_ERR_YN"
        Me.GV02_CMPT_DEV_ERR_YN.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_DEV_ERR_YN.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_DEV_ERR_YN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_DEV_ERR_YN.Visible = True
        Me.GV02_CMPT_DEV_ERR_YN.VisibleIndex = 22
        Me.GV02_CMPT_DEV_ERR_YN.Width = 40
        Me.Localizer1.SetWordID(Me.GV02_CMPT_DEV_ERR_YN, "결함")
        '
        'GV02_CMPT_SHARE_YN
        '
        Me.GV02_CMPT_SHARE_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_SHARE_YN.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_SHARE_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_SHARE_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_SHARE_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_SHARE_YN.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_SHARE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_SHARE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_SHARE_YN.Caption = "공유"
        Me.GV02_CMPT_SHARE_YN.FieldName = "SHARE_YN"
        Me.GV02_CMPT_SHARE_YN.Name = "GV02_CMPT_SHARE_YN"
        Me.GV02_CMPT_SHARE_YN.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_SHARE_YN.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_SHARE_YN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_SHARE_YN.Visible = True
        Me.GV02_CMPT_SHARE_YN.VisibleIndex = 23
        Me.GV02_CMPT_SHARE_YN.Width = 40
        Me.Localizer1.SetWordID(Me.GV02_CMPT_SHARE_YN, "공유")
        '
        'GV02_CMPT_RANK
        '
        Me.GV02_CMPT_RANK.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_RANK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_RANK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_RANK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_RANK.Caption = "난이도"
        Me.GV02_CMPT_RANK.FieldName = "RANK"
        Me.GV02_CMPT_RANK.Name = "GV02_CMPT_RANK"
        Me.GV02_CMPT_RANK.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_RANK.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_RANK.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_RANK.Visible = True
        Me.GV02_CMPT_RANK.VisibleIndex = 24
        Me.GV02_CMPT_RANK.Width = 50
        Me.Localizer1.SetWordID(Me.GV02_CMPT_RANK, "난이도")
        '
        'GV02_CMPT_RANK1
        '
        Me.GV02_CMPT_RANK1.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_RANK1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_RANK1.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_RANK1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_RANK1.Caption = "개발항목"
        Me.GV02_CMPT_RANK1.FieldName = "DEV_ITEM"
        Me.GV02_CMPT_RANK1.Name = "GV02_CMPT_RANK1"
        Me.GV02_CMPT_RANK1.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_RANK1.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_RANK1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_RANK1.Visible = True
        Me.GV02_CMPT_RANK1.VisibleIndex = 25
        Me.GV02_CMPT_RANK1.Width = 100
        Me.Localizer1.SetWordID(Me.GV02_CMPT_RANK1, "개발항목")
        '
        'GV02_CMPT_SCORE
        '
        Me.GV02_CMPT_SCORE.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_CMPT_SCORE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV02_CMPT_SCORE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_CMPT_SCORE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_CMPT_SCORE.Caption = "점수"
        Me.GV02_CMPT_SCORE.FieldName = "SCORE"
        Me.GV02_CMPT_SCORE.Name = "GV02_CMPT_SCORE"
        Me.GV02_CMPT_SCORE.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_SCORE.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_SCORE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_CMPT_SCORE.Visible = True
        Me.GV02_CMPT_SCORE.VisibleIndex = 26
        Me.Localizer1.SetWordID(Me.GV02_CMPT_SCORE, "점수")
        '
        'GV02_CMPT_PROJECT_CD
        '
        Me.GV02_CMPT_PROJECT_CD.Caption = "프로젝트코드"
        Me.GV02_CMPT_PROJECT_CD.FieldName = "PROJECT_CD"
        Me.GV02_CMPT_PROJECT_CD.Name = "GV02_CMPT_PROJECT_CD"
        Me.GV02_CMPT_PROJECT_CD.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_PROJECT_CD.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_PROJECT_CD.Visible = True
        Me.GV02_CMPT_PROJECT_CD.VisibleIndex = 28
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PROJECT_CD, "프로젝트코드")
        '
        'GV02_CMPT_PROJECT_NM
        '
        Me.GV02_CMPT_PROJECT_NM.Caption = "프로젝트명"
        Me.GV02_CMPT_PROJECT_NM.FieldName = "PROJECT_NM"
        Me.GV02_CMPT_PROJECT_NM.Name = "GV02_CMPT_PROJECT_NM"
        Me.GV02_CMPT_PROJECT_NM.Visible = True
        Me.GV02_CMPT_PROJECT_NM.VisibleIndex = 27
        Me.Localizer1.SetWordID(Me.GV02_CMPT_PROJECT_NM, "프로젝트명")
        '
        'GV02_CMPT_DEV_SCORE
        '
        Me.GV02_CMPT_DEV_SCORE.Caption = "팀장점수"
        Me.GV02_CMPT_DEV_SCORE.FieldName = "DEV_SCORE"
        Me.GV02_CMPT_DEV_SCORE.Name = "GV02_CMPT_DEV_SCORE"
        Me.GV02_CMPT_DEV_SCORE.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_DEV_SCORE.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV02_CMPT_DEV_SCORE, "팀장점수")
        '
        'GV02_CMPT_DEV_SCORE_RMK
        '
        Me.GV02_CMPT_DEV_SCORE_RMK.Caption = "팀장점수 비고"
        Me.GV02_CMPT_DEV_SCORE_RMK.FieldName = "DEV_SCORE_RMK"
        Me.GV02_CMPT_DEV_SCORE_RMK.Name = "GV02_CMPT_DEV_SCORE_RMK"
        Me.GV02_CMPT_DEV_SCORE_RMK.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_DEV_SCORE_RMK.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV02_CMPT_DEV_SCORE_RMK, "팀장점수 비고")
        '
        'GV02_CMPT_SEQ
        '
        Me.GV02_CMPT_SEQ.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_SEQ.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_SEQ.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_SEQ.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_SEQ.Caption = "Seq"
        Me.GV02_CMPT_SEQ.FieldName = "SEQ"
        Me.GV02_CMPT_SEQ.Name = "GV02_CMPT_SEQ"
        Me.GV02_CMPT_SEQ.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_SEQ.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_SEQ.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.Localizer1.SetWordID(Me.GV02_CMPT_SEQ, "Seq")
        '
        'GV02_CMPT_USR_ID
        '
        Me.GV02_CMPT_USR_ID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_USR_ID.AppearanceCell.Options.UseFont = True
        Me.GV02_CMPT_USR_ID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_CMPT_USR_ID.AppearanceHeader.Options.UseFont = True
        Me.GV02_CMPT_USR_ID.Caption = "USR_ID"
        Me.GV02_CMPT_USR_ID.FieldName = "USR_ID"
        Me.GV02_CMPT_USR_ID.Name = "GV02_CMPT_USR_ID"
        Me.GV02_CMPT_USR_ID.OptionsColumn.AllowEdit = False
        Me.GV02_CMPT_USR_ID.OptionsColumn.ReadOnly = True
        Me.GV02_CMPT_USR_ID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.Localizer1.SetWordID(Me.GV02_CMPT_USR_ID, "USR_ID")
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
        'xtpPrar
        '
        Me.xtpPrar.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpPrar.Appearance.Header.Options.UseFont = True
        Me.xtpPrar.Appearance.Header.Options.UseTextOptions = True
        Me.xtpPrar.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpPrar.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpPrar.Appearance.HeaderActive.Options.UseFont = True
        Me.xtpPrar.Appearance.HeaderActive.Options.UseTextOptions = True
        Me.xtpPrar.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpPrar.Controls.Add(Me.WG02_PRAR_ALL)
        Me.xtpPrar.Controls.Add(Me.WG02_PRAR)
        Me.xtpPrar.Name = "xtpPrar"
        Me.xtpPrar.Size = New System.Drawing.Size(1239, 142)
        Me.xtpPrar.TabPageWidth = 80
        Me.xtpPrar.Text = "계획 자료"
        Me.Localizer1.SetWordID(Me.xtpPrar, "계획 자료")
        '
        'WG02_PRAR_ALL
        '
        Me.WG02_PRAR_ALL.AllowClientBinding = True
        Me.WG02_PRAR_ALL.DeleteRowConfirmation = True
        Me.WG02_PRAR_ALL.DisplayCurrentRow = False
        Me.WG02_PRAR_ALL.IsDataStateAware = True
        Me.WG02_PRAR_ALL.Location = New System.Drawing.Point(484, 27)
        Me.WG02_PRAR_ALL.MainView = Me.GV02_PRAR_ALL
        Me.WG02_PRAR_ALL.Name = "WG02_PRAR_ALL"
        Me.WG02_PRAR_ALL.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit5, Me.RepositoryItemCheckEdit4})
        Me.WG02_PRAR_ALL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG02_PRAR_ALL.SaveLayout = True
        Me.WG02_PRAR_ALL.Size = New System.Drawing.Size(271, 80)
        Me.WG02_PRAR_ALL.TabIndex = 9
        Me.WG02_PRAR_ALL.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG02_PRAR_ALL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV02_PRAR_ALL})
        Me.WG02_PRAR_ALL.Visible = False
        '
        'GV02_PRAR_ALL
        '
        Me.GV02_PRAR_ALL.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV02_PRAR_ALL.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV02_PRAR_ALL.GridControl = Me.WG02_PRAR_ALL
        Me.GV02_PRAR_ALL.Name = "GV02_PRAR_ALL"
        Me.GV02_PRAR_ALL.OptionsCustomization.AllowRowSizing = True
        Me.GV02_PRAR_ALL.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV02_PRAR_ALL.OptionsView.BestFitMaxRowCount = 10
        Me.GV02_PRAR_ALL.OptionsView.ColumnAutoWidth = False
        Me.GV02_PRAR_ALL.OptionsView.ShowGroupPanel = False
        Me.GV02_PRAR_ALL.RowHeight = 10
        Me.GV02_PRAR_ALL.ViewCaption = " 고객 리스트"
        '
        'RepositoryItemDateBoxEdit5
        '
        Me.RepositoryItemDateBoxEdit5.AutoHeight = False
        Me.RepositoryItemDateBoxEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateBoxEdit5.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemDateBoxEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemDateBoxEdit5.Mask.SaveLiteral = False
        Me.RepositoryItemDateBoxEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateBoxEdit5.Name = "RepositoryItemDateBoxEdit5"
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        Me.RepositoryItemCheckEdit4.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit4.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit4.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit4.ValueUnchecked = "N"
        '
        'WG02_PRAR
        '
        Me.WG02_PRAR.AllowClientBinding = True
        Me.WG02_PRAR.DeleteRowConfirmation = True
        Me.WG02_PRAR.DisplayCurrentRow = False
        Me.WG02_PRAR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG02_PRAR.IsDataStateAware = True
        Me.WG02_PRAR.Location = New System.Drawing.Point(0, 0)
        Me.WG02_PRAR.MainView = Me.GV02_PRAR
        Me.WG02_PRAR.Name = "WG02_PRAR"
        Me.WG02_PRAR.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateBoxEdit3, Me.RepositoryItemCheckEdit2, Me.GV02_PRAR_rpMemoEx})
        Me.WG02_PRAR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG02_PRAR.SaveLayout = True
        Me.WG02_PRAR.Size = New System.Drawing.Size(1239, 142)
        Me.WG02_PRAR.TabIndex = 8
        Me.WG02_PRAR.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG02_PRAR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV02_PRAR})
        '
        'GV02_PRAR
        '
        Me.GV02_PRAR.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV02_PRAR.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV02_PRAR.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV02_PRAR_MNGT_NO, Me.GV02_PRAR_PRIORITY, Me.GV02_PRAR_REQ_YMD, Me.GV02_PRAR_REQ_HM, Me.GV02_PRAR_CUST_CD, Me.GV02_PRAR_CUST_NM, Me.GV02_PRAR_CONTENT, Me.GV02_PRAR_REQ_USR, Me.GV02_PRAR_TEL_NO, Me.GV02_PRAR_PROC_TYPE, Me.GV02_PRAR_WORK_USR_NM, Me.GV02_PRAR_PRAR_YMD, Me.GV02_PRAR_CMPT_YMD, Me.GV02_PRAR_INS_USR_NM, Me.GV02_PRAR_FILE_YN, Me.GV02_PRAR_RMK, Me.GV02_PRAR_PGM_MDF, Me.GV02_PRAR_DELAY, Me.GV02_PRAR_DELAY_YN, Me.GV02_PRAR_REQ_SVC, Me.GV02_PRAR_REQ_SVC2, Me.GV02_PRAR_REQ_SVC3, Me.GV02_PRAR_INS_YMD, Me.GV02_PRAR_DEV_ERR_YN, Me.GV02_PRAR_SHARE_YN, Me.GV02_PRAR_RANK, Me.GV02_PRAR_DEV_ITEM, Me.GV02_PRAR_SCORE, Me.GV02_PRAR_PROJECT_CD, Me.GV02_PRAR_PROJECT_NM, Me.GV02_PRAR_DEV_SCORE, Me.GV02_PRAR_DEV_SCORE_RMK, Me.GV02_PRAR_SEQ, Me.GV02_PRAR_USR_ID})
        Me.GV02_PRAR.GridControl = Me.WG02_PRAR
        Me.GV02_PRAR.Name = "GV02_PRAR"
        Me.GV02_PRAR.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused
        Me.GV02_PRAR.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV02_PRAR.OptionsView.BestFitMaxRowCount = 10
        Me.GV02_PRAR.OptionsView.ColumnAutoWidth = False
        Me.GV02_PRAR.OptionsView.ShowGroupPanel = False
        Me.GV02_PRAR.RowHeight = 10
        Me.GV02_PRAR.ViewCaption = " 고객 리스트"
        '
        'GV02_PRAR_MNGT_NO
        '
        Me.GV02_PRAR_MNGT_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_MNGT_NO.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_MNGT_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_MNGT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV02_PRAR_MNGT_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_MNGT_NO.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_MNGT_NO.Caption = "관리번호"
        Me.GV02_PRAR_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV02_PRAR_MNGT_NO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GV02_PRAR_MNGT_NO.Name = "GV02_PRAR_MNGT_NO"
        Me.GV02_PRAR_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_MNGT_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_MNGT_NO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_MNGT_NO.Visible = True
        Me.GV02_PRAR_MNGT_NO.VisibleIndex = 0
        Me.GV02_PRAR_MNGT_NO.Width = 100
        Me.Localizer1.SetWordID(Me.GV02_PRAR_MNGT_NO, "관리번호")
        '
        'GV02_PRAR_PRIORITY
        '
        Me.GV02_PRAR_PRIORITY.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_PRIORITY.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_PRIORITY.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_PRIORITY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_PRIORITY.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_PRIORITY.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_PRIORITY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_PRIORITY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_PRIORITY.Caption = "우선순위"
        Me.GV02_PRAR_PRIORITY.FieldName = "PRIORITY"
        Me.GV02_PRAR_PRIORITY.Name = "GV02_PRAR_PRIORITY"
        Me.GV02_PRAR_PRIORITY.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_PRIORITY.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_PRIORITY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_PRIORITY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_PRIORITY.Visible = True
        Me.GV02_PRAR_PRIORITY.VisibleIndex = 1
        Me.GV02_PRAR_PRIORITY.Width = 59
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PRIORITY, "우선순위")
        '
        'GV02_PRAR_REQ_YMD
        '
        Me.GV02_PRAR_REQ_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_REQ_YMD.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_REQ_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_REQ_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_REQ_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_REQ_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_REQ_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_REQ_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_REQ_YMD.Caption = "요청일자"
        Me.GV02_PRAR_REQ_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV02_PRAR_REQ_YMD.FieldName = "REQ_YMD"
        Me.GV02_PRAR_REQ_YMD.Name = "GV02_PRAR_REQ_YMD"
        Me.GV02_PRAR_REQ_YMD.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_REQ_YMD.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_REQ_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_REQ_YMD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_REQ_YMD.Visible = True
        Me.GV02_PRAR_REQ_YMD.VisibleIndex = 4
        Me.GV02_PRAR_REQ_YMD.Width = 106
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_YMD, "요청일자")
        '
        'GV02_PRAR_REQ_HM
        '
        Me.GV02_PRAR_REQ_HM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_REQ_HM.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_REQ_HM.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_REQ_HM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_REQ_HM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_REQ_HM.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_REQ_HM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_REQ_HM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_REQ_HM.Caption = "요청시간"
        Me.GV02_PRAR_REQ_HM.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GV02_PRAR_REQ_HM.FieldName = "REQ_HM"
        Me.GV02_PRAR_REQ_HM.Name = "GV02_PRAR_REQ_HM"
        Me.GV02_PRAR_REQ_HM.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_REQ_HM.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_REQ_HM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_REQ_HM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_REQ_HM.Width = 47
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_HM, "요청시간")
        '
        'GV02_PRAR_CUST_CD
        '
        Me.GV02_PRAR_CUST_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_CUST_CD.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_CUST_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_CUST_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_CUST_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_CUST_CD.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_CUST_CD.Caption = "코드"
        Me.GV02_PRAR_CUST_CD.FieldName = "CUST_CD"
        Me.GV02_PRAR_CUST_CD.Name = "GV02_PRAR_CUST_CD"
        Me.GV02_PRAR_CUST_CD.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_CUST_CD.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_CUST_CD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_CUST_CD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_CUST_CD.Visible = True
        Me.GV02_PRAR_CUST_CD.VisibleIndex = 2
        Me.GV02_PRAR_CUST_CD.Width = 57
        Me.Localizer1.SetWordID(Me.GV02_PRAR_CUST_CD, "코드")
        '
        'GV02_PRAR_CUST_NM
        '
        Me.GV02_PRAR_CUST_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_CUST_NM.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_CUST_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_CUST_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV02_PRAR_CUST_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_CUST_NM.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_CUST_NM.Caption = "거래처 명"
        Me.GV02_PRAR_CUST_NM.FieldName = "CUST_NM"
        Me.GV02_PRAR_CUST_NM.Name = "GV02_PRAR_CUST_NM"
        Me.GV02_PRAR_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_CUST_NM.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV02_PRAR_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_CUST_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_CUST_NM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_CUST_NM.Visible = True
        Me.GV02_PRAR_CUST_NM.VisibleIndex = 3
        Me.GV02_PRAR_CUST_NM.Width = 85
        Me.Localizer1.SetWordID(Me.GV02_PRAR_CUST_NM, "거래처 명")
        '
        'GV02_PRAR_CONTENT
        '
        Me.GV02_PRAR_CONTENT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_CONTENT.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_CONTENT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_CONTENT.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_CONTENT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_CONTENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_CONTENT.Caption = "고객 요청내용"
        Me.GV02_PRAR_CONTENT.ColumnEdit = Me.GV02_PRAR_rpMemoEx
        Me.GV02_PRAR_CONTENT.FieldName = "CONTENT"
        Me.GV02_PRAR_CONTENT.Name = "GV02_PRAR_CONTENT"
        Me.GV02_PRAR_CONTENT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_CONTENT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_CONTENT.Visible = True
        Me.GV02_PRAR_CONTENT.VisibleIndex = 8
        Me.GV02_PRAR_CONTENT.Width = 180
        Me.Localizer1.SetWordID(Me.GV02_PRAR_CONTENT, "고객 요청내용")
        '
        'GV02_PRAR_REQ_USR
        '
        Me.GV02_PRAR_REQ_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_REQ_USR.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_REQ_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_REQ_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_REQ_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_REQ_USR.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_REQ_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_REQ_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_REQ_USR.Caption = "요청자"
        Me.GV02_PRAR_REQ_USR.FieldName = "REQ_USR"
        Me.GV02_PRAR_REQ_USR.Name = "GV02_PRAR_REQ_USR"
        Me.GV02_PRAR_REQ_USR.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_REQ_USR.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_REQ_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_REQ_USR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_REQ_USR.Visible = True
        Me.GV02_PRAR_REQ_USR.VisibleIndex = 11
        Me.GV02_PRAR_REQ_USR.Width = 52
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_USR, "요청자")
        '
        'GV02_PRAR_TEL_NO
        '
        Me.GV02_PRAR_TEL_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_TEL_NO.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_TEL_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_TEL_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_TEL_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_TEL_NO.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_TEL_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_TEL_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_TEL_NO.Caption = "연락처"
        Me.GV02_PRAR_TEL_NO.FieldName = "TEL_NO"
        Me.GV02_PRAR_TEL_NO.Name = "GV02_PRAR_TEL_NO"
        Me.GV02_PRAR_TEL_NO.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_TEL_NO.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_TEL_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_TEL_NO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_TEL_NO.Visible = True
        Me.GV02_PRAR_TEL_NO.VisibleIndex = 13
        Me.GV02_PRAR_TEL_NO.Width = 76
        Me.Localizer1.SetWordID(Me.GV02_PRAR_TEL_NO, "연락처")
        '
        'GV02_PRAR_PROC_TYPE
        '
        Me.GV02_PRAR_PROC_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_PROC_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_PROC_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_PROC_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_PROC_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_PROC_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_PROC_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_PROC_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_PROC_TYPE.Caption = "진행현황"
        Me.GV02_PRAR_PROC_TYPE.FieldName = "PROC_TYPE"
        Me.GV02_PRAR_PROC_TYPE.Name = "GV02_PRAR_PROC_TYPE"
        Me.GV02_PRAR_PROC_TYPE.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_PROC_TYPE.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_PROC_TYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_PROC_TYPE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_PROC_TYPE.Visible = True
        Me.GV02_PRAR_PROC_TYPE.VisibleIndex = 5
        Me.GV02_PRAR_PROC_TYPE.Width = 64
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PROC_TYPE, "진행현황")
        '
        'GV02_PRAR_WORK_USR_NM
        '
        Me.GV02_PRAR_WORK_USR_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_WORK_USR_NM.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_WORK_USR_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_WORK_USR_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_WORK_USR_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_WORK_USR_NM.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_WORK_USR_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_WORK_USR_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_WORK_USR_NM.Caption = "담당자"
        Me.GV02_PRAR_WORK_USR_NM.FieldName = "WORK_USR_NM"
        Me.GV02_PRAR_WORK_USR_NM.Name = "GV02_PRAR_WORK_USR_NM"
        Me.GV02_PRAR_WORK_USR_NM.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_WORK_USR_NM.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_WORK_USR_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_WORK_USR_NM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_WORK_USR_NM.Visible = True
        Me.GV02_PRAR_WORK_USR_NM.VisibleIndex = 14
        Me.GV02_PRAR_WORK_USR_NM.Width = 91
        Me.Localizer1.SetWordID(Me.GV02_PRAR_WORK_USR_NM, "담당자")
        '
        'GV02_PRAR_PRAR_YMD
        '
        Me.GV02_PRAR_PRAR_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_PRAR_YMD.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_PRAR_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_PRAR_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_PRAR_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_PRAR_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_PRAR_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_PRAR_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_PRAR_YMD.Caption = "예정일자"
        Me.GV02_PRAR_PRAR_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV02_PRAR_PRAR_YMD.FieldName = "PRAR_YMD"
        Me.GV02_PRAR_PRAR_YMD.Name = "GV02_PRAR_PRAR_YMD"
        Me.GV02_PRAR_PRAR_YMD.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_PRAR_YMD.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_PRAR_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_PRAR_YMD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_PRAR_YMD.Visible = True
        Me.GV02_PRAR_PRAR_YMD.VisibleIndex = 6
        Me.GV02_PRAR_PRAR_YMD.Width = 73
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PRAR_YMD, "예정일자")
        '
        'GV02_PRAR_CMPT_YMD
        '
        Me.GV02_PRAR_CMPT_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_CMPT_YMD.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_CMPT_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_CMPT_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_CMPT_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_CMPT_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_CMPT_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_CMPT_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_CMPT_YMD.Caption = "완료일자"
        Me.GV02_PRAR_CMPT_YMD.ColumnEdit = Me.RepositoryItemDateBoxEdit1
        Me.GV02_PRAR_CMPT_YMD.FieldName = "CMPT_YMD"
        Me.GV02_PRAR_CMPT_YMD.Name = "GV02_PRAR_CMPT_YMD"
        Me.GV02_PRAR_CMPT_YMD.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_CMPT_YMD.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_CMPT_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_CMPT_YMD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_CMPT_YMD.Visible = True
        Me.GV02_PRAR_CMPT_YMD.VisibleIndex = 7
        Me.GV02_PRAR_CMPT_YMD.Width = 71
        Me.Localizer1.SetWordID(Me.GV02_PRAR_CMPT_YMD, "완료일자")
        '
        'GV02_PRAR_INS_USR_NM
        '
        Me.GV02_PRAR_INS_USR_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_INS_USR_NM.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_INS_USR_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_INS_USR_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_INS_USR_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_INS_USR_NM.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_INS_USR_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_INS_USR_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_INS_USR_NM.Caption = "등록자"
        Me.GV02_PRAR_INS_USR_NM.FieldName = "INS_USR_NM"
        Me.GV02_PRAR_INS_USR_NM.Name = "GV02_PRAR_INS_USR_NM"
        Me.GV02_PRAR_INS_USR_NM.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_INS_USR_NM.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_INS_USR_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV02_PRAR_INS_USR_NM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_INS_USR_NM.Visible = True
        Me.GV02_PRAR_INS_USR_NM.VisibleIndex = 15
        Me.GV02_PRAR_INS_USR_NM.Width = 61
        Me.Localizer1.SetWordID(Me.GV02_PRAR_INS_USR_NM, "등록자")
        '
        'GV02_PRAR_FILE_YN
        '
        Me.GV02_PRAR_FILE_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_FILE_YN.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_FILE_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_FILE_YN.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_FILE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_FILE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_FILE_YN.Caption = "Document"
        Me.GV02_PRAR_FILE_YN.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.GV02_PRAR_FILE_YN.FieldName = "FILE_YN"
        Me.GV02_PRAR_FILE_YN.Name = "GV02_PRAR_FILE_YN"
        Me.GV02_PRAR_FILE_YN.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_FILE_YN.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_FILE_YN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_FILE_YN.Visible = True
        Me.GV02_PRAR_FILE_YN.VisibleIndex = 12
        Me.GV02_PRAR_FILE_YN.Width = 22
        Me.Localizer1.SetWordID(Me.GV02_PRAR_FILE_YN, "Document")
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
        'GV02_PRAR_RMK
        '
        Me.GV02_PRAR_RMK.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_RMK.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_RMK.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_RMK.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_RMK.Caption = "개발팀 처리내용"
        Me.GV02_PRAR_RMK.ColumnEdit = Me.GV02_PRAR_rpMemoEx
        Me.GV02_PRAR_RMK.FieldName = "RMK"
        Me.GV02_PRAR_RMK.Name = "GV02_PRAR_RMK"
        Me.GV02_PRAR_RMK.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_RMK.Visible = True
        Me.GV02_PRAR_RMK.VisibleIndex = 9
        Me.GV02_PRAR_RMK.Width = 180
        Me.Localizer1.SetWordID(Me.GV02_PRAR_RMK, "개발팀 처리내용")
        '
        'GV02_PRAR_PGM_MDF
        '
        Me.GV02_PRAR_PGM_MDF.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_PGM_MDF.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_PGM_MDF.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_PGM_MDF.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_PGM_MDF.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_PGM_MDF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_PGM_MDF.Caption = "프로그램 수정사항"
        Me.GV02_PRAR_PGM_MDF.ColumnEdit = Me.GV02_PRAR_rpMemoEx
        Me.GV02_PRAR_PGM_MDF.FieldName = "PGM_MDF"
        Me.GV02_PRAR_PGM_MDF.Name = "GV02_PRAR_PGM_MDF"
        Me.GV02_PRAR_PGM_MDF.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_PGM_MDF.Visible = True
        Me.GV02_PRAR_PGM_MDF.VisibleIndex = 10
        Me.GV02_PRAR_PGM_MDF.Width = 150
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PGM_MDF, "프로그램 수정사항")
        '
        'GV02_PRAR_DELAY
        '
        Me.GV02_PRAR_DELAY.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_DELAY.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_DELAY.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_DELAY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_DELAY.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_DELAY.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_DELAY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_DELAY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_DELAY.Caption = "Delay"
        Me.GV02_PRAR_DELAY.FieldName = "DELAY"
        Me.GV02_PRAR_DELAY.Name = "GV02_PRAR_DELAY"
        Me.GV02_PRAR_DELAY.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_DELAY.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_DELAY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_DELAY.Visible = True
        Me.GV02_PRAR_DELAY.VisibleIndex = 16
        Me.GV02_PRAR_DELAY.Width = 50
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DELAY, "Delay")
        '
        'GV02_PRAR_DELAY_YN
        '
        Me.GV02_PRAR_DELAY_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_DELAY_YN.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_DELAY_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_DELAY_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_DELAY_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_DELAY_YN.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_DELAY_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_DELAY_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_DELAY_YN.Caption = "Delay(Y/N)"
        Me.GV02_PRAR_DELAY_YN.FieldName = "DELAY_YN"
        Me.GV02_PRAR_DELAY_YN.Name = "GV02_PRAR_DELAY_YN"
        Me.GV02_PRAR_DELAY_YN.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_DELAY_YN.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_DELAY_YN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_DELAY_YN.Visible = True
        Me.GV02_PRAR_DELAY_YN.VisibleIndex = 17
        Me.GV02_PRAR_DELAY_YN.Width = 50
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DELAY_YN, "Delay(Y/N)")
        '
        'GV02_PRAR_REQ_SVC
        '
        Me.GV02_PRAR_REQ_SVC.Caption = "업무구분"
        Me.GV02_PRAR_REQ_SVC.FieldName = "REQ_SVC"
        Me.GV02_PRAR_REQ_SVC.Name = "GV02_PRAR_REQ_SVC"
        Me.GV02_PRAR_REQ_SVC.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_REQ_SVC.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_REQ_SVC.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_REQ_SVC.Visible = True
        Me.GV02_PRAR_REQ_SVC.VisibleIndex = 18
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_SVC, "업무구분")
        '
        'GV02_PRAR_REQ_SVC2
        '
        Me.GV02_PRAR_REQ_SVC2.Caption = "업무구분2"
        Me.GV02_PRAR_REQ_SVC2.FieldName = "REQ_SVC2"
        Me.GV02_PRAR_REQ_SVC2.Name = "GV02_PRAR_REQ_SVC2"
        Me.GV02_PRAR_REQ_SVC2.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_REQ_SVC2.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_REQ_SVC2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_REQ_SVC2.Visible = True
        Me.GV02_PRAR_REQ_SVC2.VisibleIndex = 19
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_SVC2, "업무구분2")
        '
        'GV02_PRAR_REQ_SVC3
        '
        Me.GV02_PRAR_REQ_SVC3.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_REQ_SVC3.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_REQ_SVC3.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_REQ_SVC3.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_REQ_SVC3.Caption = "업무구분3"
        Me.GV02_PRAR_REQ_SVC3.FieldName = "REQ_SVC3"
        Me.GV02_PRAR_REQ_SVC3.Name = "GV02_PRAR_REQ_SVC3"
        Me.GV02_PRAR_REQ_SVC3.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_REQ_SVC3.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_REQ_SVC3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_REQ_SVC3.Visible = True
        Me.GV02_PRAR_REQ_SVC3.VisibleIndex = 20
        Me.Localizer1.SetWordID(Me.GV02_PRAR_REQ_SVC3, "업무구분3")
        '
        'GV02_PRAR_INS_YMD
        '
        Me.GV02_PRAR_INS_YMD.Caption = "등록일자"
        Me.GV02_PRAR_INS_YMD.FieldName = "INS_YMD"
        Me.GV02_PRAR_INS_YMD.Name = "GV02_PRAR_INS_YMD"
        Me.GV02_PRAR_INS_YMD.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_INS_YMD.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_INS_YMD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_INS_YMD.Visible = True
        Me.GV02_PRAR_INS_YMD.VisibleIndex = 21
        Me.Localizer1.SetWordID(Me.GV02_PRAR_INS_YMD, "등록일자")
        '
        'GV02_PRAR_DEV_ERR_YN
        '
        Me.GV02_PRAR_DEV_ERR_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_DEV_ERR_YN.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_DEV_ERR_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_DEV_ERR_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_DEV_ERR_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_DEV_ERR_YN.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_DEV_ERR_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_DEV_ERR_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_DEV_ERR_YN.Caption = "결함"
        Me.GV02_PRAR_DEV_ERR_YN.FieldName = "DEV_ERR_YN"
        Me.GV02_PRAR_DEV_ERR_YN.Name = "GV02_PRAR_DEV_ERR_YN"
        Me.GV02_PRAR_DEV_ERR_YN.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_DEV_ERR_YN.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_DEV_ERR_YN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_DEV_ERR_YN.Visible = True
        Me.GV02_PRAR_DEV_ERR_YN.VisibleIndex = 22
        Me.GV02_PRAR_DEV_ERR_YN.Width = 40
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DEV_ERR_YN, "결함")
        '
        'GV02_PRAR_SHARE_YN
        '
        Me.GV02_PRAR_SHARE_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_SHARE_YN.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_SHARE_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_SHARE_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_SHARE_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_SHARE_YN.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_SHARE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_SHARE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_SHARE_YN.Caption = "공유"
        Me.GV02_PRAR_SHARE_YN.FieldName = "SHARE_YN"
        Me.GV02_PRAR_SHARE_YN.Name = "GV02_PRAR_SHARE_YN"
        Me.GV02_PRAR_SHARE_YN.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_SHARE_YN.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_SHARE_YN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_SHARE_YN.Visible = True
        Me.GV02_PRAR_SHARE_YN.VisibleIndex = 23
        Me.GV02_PRAR_SHARE_YN.Width = 40
        Me.Localizer1.SetWordID(Me.GV02_PRAR_SHARE_YN, "공유")
        '
        'GV02_PRAR_RANK
        '
        Me.GV02_PRAR_RANK.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_RANK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_RANK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_RANK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_RANK.Caption = "난이도"
        Me.GV02_PRAR_RANK.FieldName = "RANK"
        Me.GV02_PRAR_RANK.Name = "GV02_PRAR_RANK"
        Me.GV02_PRAR_RANK.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_RANK.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_RANK.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_RANK.Visible = True
        Me.GV02_PRAR_RANK.VisibleIndex = 24
        Me.GV02_PRAR_RANK.Width = 50
        Me.Localizer1.SetWordID(Me.GV02_PRAR_RANK, "난이도")
        '
        'GV02_PRAR_DEV_ITEM
        '
        Me.GV02_PRAR_DEV_ITEM.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_DEV_ITEM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_DEV_ITEM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_DEV_ITEM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_DEV_ITEM.Caption = "개발항목"
        Me.GV02_PRAR_DEV_ITEM.FieldName = "DEV_ITEM"
        Me.GV02_PRAR_DEV_ITEM.Name = "GV02_PRAR_DEV_ITEM"
        Me.GV02_PRAR_DEV_ITEM.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_DEV_ITEM.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_DEV_ITEM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_DEV_ITEM.Visible = True
        Me.GV02_PRAR_DEV_ITEM.VisibleIndex = 25
        Me.GV02_PRAR_DEV_ITEM.Width = 100
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DEV_ITEM, "개발항목")
        '
        'GV02_PRAR_SCORE
        '
        Me.GV02_PRAR_SCORE.AppearanceCell.Options.UseTextOptions = True
        Me.GV02_PRAR_SCORE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV02_PRAR_SCORE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV02_PRAR_SCORE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV02_PRAR_SCORE.Caption = "점수"
        Me.GV02_PRAR_SCORE.FieldName = "SCORE"
        Me.GV02_PRAR_SCORE.Name = "GV02_PRAR_SCORE"
        Me.GV02_PRAR_SCORE.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_SCORE.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_SCORE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV02_PRAR_SCORE.Visible = True
        Me.GV02_PRAR_SCORE.VisibleIndex = 26
        Me.Localizer1.SetWordID(Me.GV02_PRAR_SCORE, "점수")
        '
        'GV02_PRAR_PROJECT_CD
        '
        Me.GV02_PRAR_PROJECT_CD.Caption = "프로젝트명"
        Me.GV02_PRAR_PROJECT_CD.FieldName = "PROJECT_CD"
        Me.GV02_PRAR_PROJECT_CD.Name = "GV02_PRAR_PROJECT_CD"
        Me.GV02_PRAR_PROJECT_CD.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_PROJECT_CD.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_PROJECT_CD.Visible = True
        Me.GV02_PRAR_PROJECT_CD.VisibleIndex = 28
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PROJECT_CD, "프로젝트명")
        '
        'GV02_PRAR_PROJECT_NM
        '
        Me.GV02_PRAR_PROJECT_NM.Caption = "프로젝트명"
        Me.GV02_PRAR_PROJECT_NM.FieldName = "PROJECT_NM"
        Me.GV02_PRAR_PROJECT_NM.Name = "GV02_PRAR_PROJECT_NM"
        Me.GV02_PRAR_PROJECT_NM.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_PROJECT_NM.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_PROJECT_NM.Visible = True
        Me.GV02_PRAR_PROJECT_NM.VisibleIndex = 27
        Me.Localizer1.SetWordID(Me.GV02_PRAR_PROJECT_NM, "프로젝트명")
        '
        'GV02_PRAR_DEV_SCORE
        '
        Me.GV02_PRAR_DEV_SCORE.Caption = "팀장점수"
        Me.GV02_PRAR_DEV_SCORE.FieldName = "DEV_SCORE"
        Me.GV02_PRAR_DEV_SCORE.Name = "GV02_PRAR_DEV_SCORE"
        Me.GV02_PRAR_DEV_SCORE.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_DEV_SCORE.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DEV_SCORE, "팀장점수")
        '
        'GV02_PRAR_DEV_SCORE_RMK
        '
        Me.GV02_PRAR_DEV_SCORE_RMK.Caption = "팀장점수 비고"
        Me.GV02_PRAR_DEV_SCORE_RMK.FieldName = "DEV_SCORE_RMK"
        Me.GV02_PRAR_DEV_SCORE_RMK.Name = "GV02_PRAR_DEV_SCORE_RMK"
        Me.GV02_PRAR_DEV_SCORE_RMK.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_DEV_SCORE_RMK.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV02_PRAR_DEV_SCORE_RMK, "팀장점수 비고")
        '
        'GV02_PRAR_SEQ
        '
        Me.GV02_PRAR_SEQ.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_SEQ.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_SEQ.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_SEQ.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_SEQ.Caption = "Seq"
        Me.GV02_PRAR_SEQ.FieldName = "SEQ"
        Me.GV02_PRAR_SEQ.Name = "GV02_PRAR_SEQ"
        Me.GV02_PRAR_SEQ.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_SEQ.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_SEQ.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.Localizer1.SetWordID(Me.GV02_PRAR_SEQ, "Seq")
        '
        'GV02_PRAR_USR_ID
        '
        Me.GV02_PRAR_USR_ID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_USR_ID.AppearanceCell.Options.UseFont = True
        Me.GV02_PRAR_USR_ID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV02_PRAR_USR_ID.AppearanceHeader.Options.UseFont = True
        Me.GV02_PRAR_USR_ID.Caption = "USR_ID"
        Me.GV02_PRAR_USR_ID.FieldName = "USR_ID"
        Me.GV02_PRAR_USR_ID.Name = "GV02_PRAR_USR_ID"
        Me.GV02_PRAR_USR_ID.OptionsColumn.AllowEdit = False
        Me.GV02_PRAR_USR_ID.OptionsColumn.ReadOnly = True
        Me.GV02_PRAR_USR_ID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.Localizer1.SetWordID(Me.GV02_PRAR_USR_ID, "USR_ID")
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.S_DEV_PIC_LIST)
        Me.PanelControl1.Controls.Add(Me.lbl_S_DEV_PIC_LIST)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1245, 32)
        Me.PanelControl1.TabIndex = 311
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'S_DEV_PIC_LIST
        '
        Me.S_DEV_PIC_LIST.Location = New System.Drawing.Point(85, 5)
        Me.S_DEV_PIC_LIST.Name = "S_DEV_PIC_LIST"
        Me.S_DEV_PIC_LIST.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_DEV_PIC_LIST.Properties.Appearance.Options.UseFont = True
        Me.S_DEV_PIC_LIST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.S_DEV_PIC_LIST.Size = New System.Drawing.Size(318, 22)
        Me.S_DEV_PIC_LIST.TabIndex = 310
        Me.Localizer1.SetWordID(Me.S_DEV_PIC_LIST, "")
        '
        'lbl_S_DEV_PIC_LIST
        '
        Me.lbl_S_DEV_PIC_LIST.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_S_DEV_PIC_LIST.LabelFor = Nothing
        Me.lbl_S_DEV_PIC_LIST.Location = New System.Drawing.Point(22, 6)
        Me.lbl_S_DEV_PIC_LIST.Name = "lbl_S_DEV_PIC_LIST"
        Me.lbl_S_DEV_PIC_LIST.Size = New System.Drawing.Size(57, 22)
        Me.lbl_S_DEV_PIC_LIST.TabIndex = 309
        Me.lbl_S_DEV_PIC_LIST.Text = "담당자"
        Me.lbl_S_DEV_PIC_LIST.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_DEV_PIC_LIST, "")
        '
        'xtpAccount
        '
        Me.xtpAccount.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpAccount.Appearance.Header.Options.UseFont = True
        Me.xtpAccount.Appearance.Header.Options.UseTextOptions = True
        Me.xtpAccount.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpAccount.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.xtpAccount.Appearance.HeaderActive.Options.UseFont = True
        Me.xtpAccount.Appearance.HeaderActive.Options.UseTextOptions = True
        Me.xtpAccount.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpAccount.Controls.Add(Me.WebGrid13)
        Me.xtpAccount.Controls.Add(Me.WebGrid14)
        Me.xtpAccount.Controls.Add(Me.WebGrid15)
        Me.xtpAccount.Name = "xtpAccount"
        Me.xtpAccount.PageVisible = False
        Me.xtpAccount.Size = New System.Drawing.Size(1245, 345)
        Me.xtpAccount.TabPageWidth = 80
        Me.xtpAccount.Text = "관리팀"
        Me.Localizer1.SetWordID(Me.xtpAccount, "")
        '
        'WebGrid13
        '
        Me.WebGrid13.AllowClientBinding = True
        Me.WebGrid13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebGrid13.DeleteRowConfirmation = True
        Me.WebGrid13.DisplayCurrentRow = False
        Me.WebGrid13.IsDataStateAware = True
        Me.WebGrid13.Location = New System.Drawing.Point(2, 516)
        Me.WebGrid13.MainView = Me.GridView7
        Me.WebGrid13.Name = "WebGrid13"
        Me.WebGrid13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WebGrid13.SaveLayout = True
        Me.WebGrid13.Size = New System.Drawing.Size(992, 28)
        Me.WebGrid13.TabIndex = 306
        Me.WebGrid13.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WebGrid13.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7, Me.GridView3})
        '
        'GridView7
        '
        Me.GridView7.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView7.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn41, Me.GridColumn42, Me.GridColumn43, Me.GridColumn44, Me.GridColumn45})
        Me.GridView7.GridControl = Me.WebGrid13
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.Editable = False
        Me.GridView7.OptionsBehavior.ReadOnly = True
        Me.GridView7.OptionsCustomization.AllowRowSizing = True
        Me.GridView7.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView7.OptionsView.BestFitMaxRowCount = 10
        Me.GridView7.OptionsView.ColumnAutoWidth = False
        Me.GridView7.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView7.OptionsView.ShowFooter = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.RowHeight = 10
        Me.GridView7.ViewCaption = " 고객 리스트"
        '
        'GridColumn41
        '
        Me.GridColumn41.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn41.AppearanceCell.Options.UseFont = True
        Me.GridColumn41.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn41.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn41.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn41.AppearanceHeader.Options.UseFont = True
        Me.GridColumn41.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn41.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn41.Caption = "청구구분"
        Me.GridColumn41.FieldName = "INS_USR"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.OptionsColumn.AllowEdit = False
        Me.GridColumn41.OptionsColumn.ReadOnly = True
        Me.GridColumn41.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn41.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "INS_USR", "전주대비 증감액")})
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 0
        Me.GridColumn41.Width = 120
        Me.Localizer1.SetWordID(Me.GridColumn41, "")
        '
        'GridColumn42
        '
        Me.GridColumn42.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn42.AppearanceCell.Options.UseFont = True
        Me.GridColumn42.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn42.AppearanceHeader.Options.UseFont = True
        Me.GridColumn42.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn42.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn42.Caption = "청구금액"
        Me.GridColumn42.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn42.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn42.FieldName = "WORK_USR"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.OptionsColumn.AllowEdit = False
        Me.GridColumn42.OptionsColumn.ReadOnly = True
        Me.GridColumn42.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn42.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WORK_USR", "{0:n0}")})
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 1
        Me.GridColumn42.Width = 170
        Me.Localizer1.SetWordID(Me.GridColumn42, "")
        '
        'GridColumn43
        '
        Me.GridColumn43.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn43.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn43.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn43.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn43.Caption = "총수금액"
        Me.GridColumn43.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn43.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn43.FieldName = "REQ_DATE"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.OptionsColumn.AllowEdit = False
        Me.GridColumn43.OptionsColumn.ReadOnly = True
        Me.GridColumn43.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "REQ_DATE", "{0:n0}")})
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 2
        Me.GridColumn43.Width = 170
        Me.Localizer1.SetWordID(Me.GridColumn43, "")
        '
        'GridColumn44
        '
        Me.GridColumn44.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn44.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn44.Caption = "미수잔액"
        Me.GridColumn44.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn44.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:n0}")})
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 3
        Me.GridColumn44.Width = 170
        Me.Localizer1.SetWordID(Me.GridColumn44, "")
        '
        'GridColumn45
        '
        Me.GridColumn45.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn45.AppearanceCell.Options.UseFont = True
        Me.GridColumn45.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn45.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn45.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn45.AppearanceHeader.Options.UseFont = True
        Me.GridColumn45.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn45.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn45.Caption = "수금율"
        Me.GridColumn45.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn45.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn45.FieldName = "PROC_TYPE"
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.OptionsColumn.AllowEdit = False
        Me.GridColumn45.OptionsColumn.ReadOnly = True
        Me.GridColumn45.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn45.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PROC_TYPE", "{0:n0}")})
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 4
        Me.GridColumn45.Width = 120
        Me.Localizer1.SetWordID(Me.GridColumn45, "")
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.WebGrid13
        Me.GridView3.Name = "GridView3"
        '
        'WebGrid14
        '
        Me.WebGrid14.AllowClientBinding = True
        Me.WebGrid14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebGrid14.DeleteRowConfirmation = True
        Me.WebGrid14.DisplayCurrentRow = False
        Me.WebGrid14.IsDataStateAware = True
        Me.WebGrid14.Location = New System.Drawing.Point(2, 483)
        Me.WebGrid14.MainView = Me.GridView6
        Me.WebGrid14.Name = "WebGrid14"
        Me.WebGrid14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WebGrid14.SaveLayout = True
        Me.WebGrid14.Size = New System.Drawing.Size(992, 28)
        Me.WebGrid14.TabIndex = 305
        Me.WebGrid14.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WebGrid14.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6, Me.GridView2})
        '
        'GridView6
        '
        Me.GridView6.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView6.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn32, Me.GridColumn37, Me.GridColumn38, Me.GridColumn39, Me.GridColumn40})
        Me.GridView6.GridControl = Me.WebGrid14
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsBehavior.ReadOnly = True
        Me.GridView6.OptionsCustomization.AllowRowSizing = True
        Me.GridView6.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView6.OptionsView.BestFitMaxRowCount = 10
        Me.GridView6.OptionsView.ColumnAutoWidth = False
        Me.GridView6.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.RowHeight = 10
        Me.GridView6.ViewCaption = " 고객 리스트"
        '
        'GridColumn32
        '
        Me.GridColumn32.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn32.AppearanceCell.Options.UseFont = True
        Me.GridColumn32.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn32.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn32.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn32.AppearanceHeader.Options.UseFont = True
        Me.GridColumn32.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn32.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn32.Caption = "청구구분"
        Me.GridColumn32.FieldName = "INS_USR"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsColumn.AllowEdit = False
        Me.GridColumn32.OptionsColumn.ReadOnly = True
        Me.GridColumn32.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn32.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "INS_USR", "전주 합계")})
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 0
        Me.GridColumn32.Width = 120
        Me.Localizer1.SetWordID(Me.GridColumn32, "")
        '
        'GridColumn37
        '
        Me.GridColumn37.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn37.AppearanceCell.Options.UseFont = True
        Me.GridColumn37.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn37.AppearanceHeader.Options.UseFont = True
        Me.GridColumn37.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn37.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn37.Caption = "청구금액"
        Me.GridColumn37.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn37.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn37.FieldName = "WORK_USR"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.OptionsColumn.AllowEdit = False
        Me.GridColumn37.OptionsColumn.ReadOnly = True
        Me.GridColumn37.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn37.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WORK_USR", "{0:n0}")})
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 1
        Me.GridColumn37.Width = 170
        Me.Localizer1.SetWordID(Me.GridColumn37, "")
        '
        'GridColumn38
        '
        Me.GridColumn38.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn38.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn38.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn38.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn38.Caption = "총수금액"
        Me.GridColumn38.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn38.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn38.FieldName = "REQ_DATE"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.OptionsColumn.AllowEdit = False
        Me.GridColumn38.OptionsColumn.ReadOnly = True
        Me.GridColumn38.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "REQ_DATE", "{0:n0}")})
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 2
        Me.GridColumn38.Width = 170
        Me.Localizer1.SetWordID(Me.GridColumn38, "")
        '
        'GridColumn39
        '
        Me.GridColumn39.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn39.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn39.Caption = "미수잔액"
        Me.GridColumn39.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn39.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:n0}")})
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 3
        Me.GridColumn39.Width = 170
        Me.Localizer1.SetWordID(Me.GridColumn39, "")
        '
        'GridColumn40
        '
        Me.GridColumn40.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn40.AppearanceCell.Options.UseFont = True
        Me.GridColumn40.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn40.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn40.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn40.AppearanceHeader.Options.UseFont = True
        Me.GridColumn40.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn40.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn40.Caption = "수금율"
        Me.GridColumn40.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn40.FieldName = "PROC_TYPE"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.OptionsColumn.AllowEdit = False
        Me.GridColumn40.OptionsColumn.ReadOnly = True
        Me.GridColumn40.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn40.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PROC_TYPE", "{0:n0}")})
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 4
        Me.GridColumn40.Width = 120
        Me.Localizer1.SetWordID(Me.GridColumn40, "")
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.WebGrid14
        Me.GridView2.Name = "GridView2"
        '
        'WebGrid15
        '
        Me.WebGrid15.AllowClientBinding = True
        Me.WebGrid15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebGrid15.DeleteRowConfirmation = True
        Me.WebGrid15.DisplayCurrentRow = False
        Me.WebGrid15.IsDataStateAware = True
        Me.WebGrid15.Location = New System.Drawing.Point(2, 3)
        Me.WebGrid15.MainView = Me.GridView5
        Me.WebGrid15.Name = "WebGrid15"
        Me.WebGrid15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WebGrid15.SaveLayout = True
        Me.WebGrid15.Size = New System.Drawing.Size(992, 474)
        Me.WebGrid15.TabIndex = 304
        Me.WebGrid15.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WebGrid15.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5, Me.GridView1})
        '
        'GridView5
        '
        Me.GridView5.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView5.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn31, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36})
        Me.GridView5.GridControl = Me.WebGrid15
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsBehavior.ReadOnly = True
        Me.GridView5.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView5.OptionsView.BestFitMaxRowCount = 10
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.RowHeight = 10
        Me.GridView5.ViewCaption = " "
        '
        'GridColumn31
        '
        Me.GridColumn31.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn31.AppearanceCell.Options.UseFont = True
        Me.GridColumn31.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn31.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn31.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn31.AppearanceHeader.Options.UseFont = True
        Me.GridColumn31.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn31.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn31.Caption = "청구구분"
        Me.GridColumn31.FieldName = "INS_USR"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.AllowEdit = False
        Me.GridColumn31.OptionsColumn.ReadOnly = True
        Me.GridColumn31.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn31.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "INS_USR", "합    계")})
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 0
        Me.GridColumn31.Width = 120
        Me.Localizer1.SetWordID(Me.GridColumn31, "")
        '
        'GridColumn33
        '
        Me.GridColumn33.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn33.AppearanceCell.Options.UseFont = True
        Me.GridColumn33.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn33.AppearanceHeader.Options.UseFont = True
        Me.GridColumn33.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn33.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn33.Caption = "청구금액"
        Me.GridColumn33.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn33.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn33.FieldName = "WORK_USR"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.AllowEdit = False
        Me.GridColumn33.OptionsColumn.ReadOnly = True
        Me.GridColumn33.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn33.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WORK_USR", "{0:n0}")})
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 1
        Me.GridColumn33.Width = 170
        Me.Localizer1.SetWordID(Me.GridColumn33, "")
        '
        'GridColumn34
        '
        Me.GridColumn34.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn34.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn34.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn34.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn34.Caption = "총수금액"
        Me.GridColumn34.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn34.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn34.FieldName = "REQ_DATE"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.OptionsColumn.AllowEdit = False
        Me.GridColumn34.OptionsColumn.ReadOnly = True
        Me.GridColumn34.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "REQ_DATE", "{0:n0}")})
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 2
        Me.GridColumn34.Width = 170
        Me.Localizer1.SetWordID(Me.GridColumn34, "")
        '
        'GridColumn35
        '
        Me.GridColumn35.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn35.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn35.Caption = "미수잔액"
        Me.GridColumn35.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn35.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:n0}")})
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 3
        Me.GridColumn35.Width = 170
        Me.Localizer1.SetWordID(Me.GridColumn35, "")
        '
        'GridColumn36
        '
        Me.GridColumn36.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn36.AppearanceCell.Options.UseFont = True
        Me.GridColumn36.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn36.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn36.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn36.AppearanceHeader.Options.UseFont = True
        Me.GridColumn36.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn36.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn36.Caption = "수금율"
        Me.GridColumn36.DisplayFormat.FormatString = "{0:n0}"
        Me.GridColumn36.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn36.FieldName = "PROC_TYPE"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.OptionsColumn.AllowEdit = False
        Me.GridColumn36.OptionsColumn.ReadOnly = True
        Me.GridColumn36.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn36.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PROC_TYPE", "{0:n0}")})
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 4
        Me.GridColumn36.Width = 120
        Me.Localizer1.SetWordID(Me.GridColumn36, "")
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.WebGrid15
        Me.GridView1.Name = "GridView1"
        '
        'rpMemo_200
        '
        Me.rpMemo_200.AutoHeight = False
        Me.rpMemo_200.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpMemo_200.MaxLength = 200
        Me.rpMemo_200.Name = "rpMemo_200"
        '
        'rpNumeric_N0
        '
        Me.rpNumeric_N0.AutoHeight = False
        Me.rpNumeric_N0.DisplayFormat.FormatString = "{0:N0}"
        Me.rpNumeric_N0.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpNumeric_N0.EditFormat.FormatString = "{0:N0}"
        Me.rpNumeric_N0.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpNumeric_N0.Name = "rpNumeric_N0"
        '
        'GV02_PRAR_rpMemoEx
        '
        Me.GV02_PRAR_rpMemoEx.AutoHeight = False
        Me.GV02_PRAR_rpMemoEx.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GV02_PRAR_rpMemoEx.Name = "GV02_PRAR_rpMemoEx"
        Me.GV02_PRAR_rpMemoEx.PopupFormSize = New System.Drawing.Size(400, 200)
        Me.GV02_PRAR_rpMemoEx.ShowIcon = False
        '
        'CrmAsWeekly
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 488)
        Me.Controls.Add(Me.xtcAnalysis)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.palAutoButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.KeyPreview = True
        Me.Name = "CrmAsWeekly"
        Me.Text = "주간업무 보고"
        Me.Localizer1.SetWordID(Me, "")
        CType(Me.RepositoryItemDateBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.xtpSend.ResumeLayout(False)
        CType(Me.WG02_EDI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV02_EDI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcAnalysis.ResumeLayout(False)
        Me.xtpHelp.ResumeLayout(False)
        CType(Me.WG01_PGC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpSales.ResumeLayout(False)
        CType(Me.WG04C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV04C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpText_100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitLeft.ResumeLayout(False)
        CType(Me.WG04A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV04A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG04B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV04B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpDev.ResumeLayout(False)
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMain.ResumeLayout(False)
        CType(Me.WG02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcDetail.ResumeLayout(False)
        Me.xtpCmpt.ResumeLayout(False)
        CType(Me.WG02_CMPT_ALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV02_CMPT_ALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG02_CMPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV02_CMPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpPrar.ResumeLayout(False)
        CType(Me.WG02_PRAR_ALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV02_PRAR_ALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG02_PRAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV02_PRAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateBoxEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.S_DEV_PIC_LIST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpAccount.ResumeLayout(False)
        CType(Me.WebGrid13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebGrid14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebGrid15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMemo_200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpNumeric_N0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV02_PRAR_rpMemoEx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemDateBoxEdit1 As YJIT.SC.UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents S_DEPT_CD As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents S_DATE_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_TO_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents S_FM_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label2 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents S_TO_YMD_NEXT As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents S_FM_YMD_NEXT As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label4 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnPrev As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnNext As YJIT.SC.UI.SCControls.Button
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents Label8 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents Label7 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_TO_YMD_PREV As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents S_FM_YMD_PREV As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents Label6 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents xtpSend As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtcAnalysis As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpHelp As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG01_PGC As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PGV_PIVOT_CNT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGV_WORK_USR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGV_REQ_SVC_GRP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents xtpSales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG04C As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV04C As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV04C_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV04C_DEPT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV04C_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV04C_ITEM_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpText_100 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV04C_ORD_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV04C_CTRT_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV04C_IDC_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV04C_MATN_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV04C_CMPT_RATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV04C_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents splitLeft As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents WG04A As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV04A As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV01A_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV01A_USR_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV01A_MATN_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WG04B As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV04B As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV04B_CTRT_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV04B_CTRT_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV04B_MATN_AMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpDev As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WG02_EDI As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV02_EDI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridColumn16_해상 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn17_해상 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn18_해상 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn1_항공 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2_항공 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3_항공 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn1_AMS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2_AMS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3_AMS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn1_합계 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2_합계 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3_합계 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents WG02 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV02 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV02_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_USR_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PROJECT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_RANK_SORT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_SM_SI_CMPT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpAccount As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WebGrid13 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WebGrid14 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WebGrid15 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xtpPrar As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpCmpt As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtcDetail As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents rpMemo_200 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents rpNumeric_N0 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents S_PROJECT_NM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents S_PROJECT_CD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents Label12 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV02_REQ_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_SCORE_SUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_SM_SI_PRAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents S_DEV_PIC_LIST As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents lbl_S_DEV_PIC_LIST As UI.SCControls.Label
    Friend WithEvents splitMain As DevExpress.XtraEditors.SplitContainerControl
    Public WithEvents WG02_CMPT As UI.SCControls.WebGrid
    Friend WithEvents GV02_CMPT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV02_CMPT_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_PRIORITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_REQ_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_REQ_HM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_CONTENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_REQ_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_PROC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_WORK_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_PRAR_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_CMPT_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_INS_USR_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_FILE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV02_CMPT_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_PGM_MDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_DELAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_DELAY_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_REQ_SVC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_REQ_SVC2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_REQ_SVC3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_DEV_ERR_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_SHARE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_RANK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_RANK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_SCORE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_DEV_SCORE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_DEV_SCORE_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateBoxEdit2 As UI.SCControls.RepositoryItemDateBoxEdit
    Public WithEvents WG02_PRAR As UI.SCControls.WebGrid
    Friend WithEvents GV02_PRAR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV02_PRAR_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_PRIORITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_REQ_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_REQ_HM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_CONTENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_REQ_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_PROC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_WORK_USR_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_PRAR_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_CMPT_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_INS_USR_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_FILE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV02_PRAR_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_PGM_MDF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_DELAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_DELAY_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_REQ_SVC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_REQ_SVC2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_REQ_SVC3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_INS_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_DEV_ERR_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_SHARE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_RANK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_DEV_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_SCORE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_DEV_SCORE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_DEV_SCORE_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_SEQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_USR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateBoxEdit3 As UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents GV02_PRAR_PROJECT_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_CMPT_PROJECT_NM As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents WG02_CMPT_ALL As UI.SCControls.WebGrid
    Friend WithEvents GV02_CMPT_ALL As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateBoxEdit4 As UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Public WithEvents WG02_PRAR_ALL As UI.SCControls.WebGrid
    Friend WithEvents GV02_PRAR_ALL As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateBoxEdit5 As UI.SCControls.RepositoryItemDateBoxEdit
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV02_CMPT_PROJECT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV02_PRAR_PROJECT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpMemo As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents GV02_PRAR_rpMemoEx As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
End Class
