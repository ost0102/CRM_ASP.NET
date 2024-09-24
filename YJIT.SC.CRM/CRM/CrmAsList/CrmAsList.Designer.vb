<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrmAsList
    Inherits YJIT.SC.UI.SCView

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrmAsList))
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_S_SELF_PROC_YN = New YJIT.SC.UI.SCControls.Label()
        Me.S_SELF_PROC_YN = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_DEPT_CD_M = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.S_PROJECT_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_PROJECT_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.lbl_S_EX_IM_TYPE = New YJIT.SC.UI.SCControls.Label()
        Me.S_EX_IM_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_REQ_TYPE2 = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_DEPT_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_WORK_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_DEPT_AUTH = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label23 = New YJIT.SC.UI.SCControls.Label()
        Me.S_PROC_TYPE = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Label20 = New YJIT.SC.UI.SCControls.Label()
        Me.S_DEPT_CD = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_CUST_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.S_CUST_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_DATE_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_REQ_SVC2 = New YJIT.SC.UI.SCControls.ComboBox()
        Me.S_WORK_USR_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.S_WORK_USR = New YJIT.SC.UI.SCControls.CodeBox()
        Me.Label33 = New YJIT.SC.UI.SCControls.Label()
        Me.S_REQ_SVC = New YJIT.SC.UI.SCControls.ComboBox()
        Me.SEARCH_KEY = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label21 = New YJIT.SC.UI.SCControls.Label()
        Me.S_TO_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.S_FM_YMD = New YJIT.SC.UI.SCControls.DateBox()
        Me.Label32 = New YJIT.SC.UI.SCControls.Label()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.TextBox1 = New YJIT.SC.UI.SCControls.TextBox()
        Me.TextBox2 = New YJIT.SC.UI.SCControls.TextBox()
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.btnCrmAsMst = New YJIT.SC.UI.SCControls.Button()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDeleteCol = New YJIT.SC.UI.SCControls.Button()
        Me.btnSaveCol = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearchCol = New YJIT.SC.UI.SCControls.Button()
        Me.LayOutList = New YJIT.SC.UI.SCControls.ComboBox()
        Me.WG1 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV1_INS_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_WORK_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TAKE_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CONTENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.GV1_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DOC_CNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_USR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_SVC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_SVC2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_TYPE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SHARE_DEPT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PRIORITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PRAR_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CMPT_RMK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GV1_INS_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_FREE_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SYS_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SYS_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CMPT_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_UPPER_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_ORGN_MNGT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_EDU_LV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_REQ_HM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CMPT_YMD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CMPT_HM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_DEV_CMPT_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RETURN_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_RANK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_EX_IM_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SCORE_UNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SCORE_RANK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SCORE_EXIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SCORE_TOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_CUST_DEPT_NM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PROJECT_CD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_PREV_WEEK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV1_SELF_PROC_YN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.xtcMain = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpDetail = New DevExpress.XtraTab.XtraTabPage()
        Me.xtpSummary = New DevExpress.XtraTab.XtraTabPage()
        Me.splitMain = New DevExpress.XtraEditors.SplitContainerControl()
        Me.PGC1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PGV_REQ_COUNT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_SCORE_UNIT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_SCORE_RANK = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_SCORE_EXIM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_SCORE_TOT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_REQ_SVC_NM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_REQ_SVC2_NM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_REQ_TYPE2_NM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_DEPT_NM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_WORK_USR_NM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PGV_EX_IM_TYPE_NM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.WG2 = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.panelSummary = New DevExpress.XtraEditors.PanelControl()
        Me.radioSummary = New YJIT.SC.UI.SCControls.RadioGroup()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dlgSaveExcel = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController()
        Me.DocImage = New DevExpress.Utils.ImageCollection()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.S_DEPT_CD_M.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S_PROC_TYPE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcMain.SuspendLayout()
        Me.xtpDetail.SuspendLayout()
        Me.xtpSummary.SuspendLayout()
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMain.SuspendLayout()
        CType(Me.PGC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSummary.SuspendLayout()
        CType(Me.radioSummary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        Me.Localizer1.SetWordID(Me.lbl_S_SELF_PROC_YN, "자체처리 여부")
        Me.Localizer1.SetWordID(Me.S_SELF_PROC_YN, "--Select--")
        Me.Localizer1.SetWordID(Me.S_DEPT_CD_M, "")
        Me.Localizer1.SetWordID(Me.S_PROJECT_CD, "")
        Me.Localizer1.SetWordID(Me.Label1, "프로젝트")
        Me.Localizer1.SetWordID(Me.Label7, "거래처")
        Me.Localizer1.SetWordID(Me.lbl_S_EX_IM_TYPE, "내근/외근")
        Me.Localizer1.SetWordID(Me.S_EX_IM_TYPE, "내근")
        Me.Localizer1.SetWordID(Me.S_REQ_TYPE2, "--Select--")
        Me.Localizer1.SetWordID(Me.S_DEPT_TYPE, "등록부서")
        Me.Localizer1.SetWordID(Me.S_WORK_TYPE, "등록일자")
        Me.Localizer1.SetWordID(Me.S_DEPT_AUTH, "--Select--")
        Me.Localizer1.SetWordID(Me.Label23, "타부서공유")
        Me.Localizer1.SetWordID(Me.S_PROC_TYPE, "")
        Me.Localizer1.SetWordID(Me.Label20, "상태")
        Me.Localizer1.SetWordID(Me.S_DEPT_CD, "--Select--")
        Me.Localizer1.SetWordID(Me.S_CUST_CD, "")
        Me.Localizer1.SetWordID(Me.S_DATE_TYPE, "등록일자")
        Me.Localizer1.SetWordID(Me.S_REQ_SVC2, "")
        Me.Localizer1.SetWordID(Me.S_WORK_USR, "")
        Me.Localizer1.SetWordID(Me.Label33, "업무구분1,2,3")
        Me.Localizer1.SetWordID(Me.S_REQ_SVC, "--Select--")
        Me.Localizer1.SetWordID(Me.SEARCH_KEY, "")
        Me.Localizer1.SetWordID(Me.Label21, "Search Key")
        Me.Localizer1.SetWordID(Me.S_TO_YMD, "")
        Me.Localizer1.SetWordID(Me.S_FM_YMD, "")
        Me.Localizer1.SetWordID(Me.Label32, "~")
        Me.Localizer1.SetWordID(Me.btnSearch, "조회(&A)")
        Me.Localizer1.SetWordID(Me.TextBox1, "")
        Me.Localizer1.SetWordID(Me.TextBox2, "")
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnNew, "초기화(&C)")
        Me.Localizer1.SetWordID(Me.btnCrmAsMst, "고객지원 등록(&N)")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.btnDeleteCol, " ")
        Me.Localizer1.SetWordID(Me.btnSaveCol, " ")
        Me.Localizer1.SetWordID(Me.btnSearchCol, " ")
        Me.Localizer1.SetWordID(Me.LayOutList, "")
        Me.Localizer1.SetWordID(Me.WG1, "")
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "등록자")
        Me.Localizer1.SetWordID(Me.GV1_WORK_USR, "작업자")
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "코드")
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "거래처 명")
        Me.Localizer1.SetWordID(Me.GV1_REQ_DATE, "요청날짜")
        Me.Localizer1.SetWordID(Me.GV1_TAKE_DATE, "접수일자")
        Me.Localizer1.SetWordID(Me.GV1_PROC_TYPE, "상태")
        Me.Localizer1.SetWordID(Me.GV1_CONTENT, "고객요청사항")
        Me.Localizer1.SetWordID(Me.GV1_RMK, "조치사항")
        Me.Localizer1.SetWordID(Me.GV1_DOC_CNT, "Document")
        Me.Localizer1.SetWordID(Me.GV1_REQ_USR, "요청자")
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "연락처")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "업무구분1")
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC2, "업무구분2")
        Me.Localizer1.SetWordID(Me.GV1_REQ_TYPE2, "업무구분3")
        Me.Localizer1.SetWordID(Me.GV1_SHARE_DEPT, "공유부서")
        Me.Localizer1.SetWordID(Me.GV1_PRIORITY, "우선순위")
        Me.Localizer1.SetWordID(Me.GV1_PRAR_YMD, "예정일자")
        Me.Localizer1.SetWordID(Me.GV1_REQ_TYPE, "요청상태")
        Me.Localizer1.SetWordID(Me.GV1_CMPT_RMK, "답변")
        Me.Localizer1.SetWordID(Me.GV1_INS_DATE, "등록날짜")
        Me.Localizer1.SetWordID(Me.GV1_FREE_YN, "유상/무상")
        Me.Localizer1.SetWordID(Me.GV1_SYS_ID, "System ID")
        Me.Localizer1.SetWordID(Me.GV1_SYS_NM, "접수")
        Me.Localizer1.SetWordID(Me.GV1_CMPT_DATE, "완료날짜")
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "관리번호")
        Me.Localizer1.SetWordID(Me.GV1_UPPER_MNGT_NO, "공유관리번호")
        Me.Localizer1.SetWordID(Me.GV1_ORGN_MNGT_NO, "원본관리번호")
        Me.Localizer1.SetWordID(Me.GV1_EDU_LV, "교육만족도")
        Me.Localizer1.SetWordID(Me.GV1_REQ_YMD, "요청일")
        Me.Localizer1.SetWordID(Me.GV1_REQ_HM, "요청시간")
        Me.Localizer1.SetWordID(Me.GV1_CMPT_YMD, "완료일")
        Me.Localizer1.SetWordID(Me.GV1_CMPT_HM, "완료시간")
        Me.Localizer1.SetWordID(Me.GV1_DEV_CMPT_YN, "개발팀완료")
        Me.Localizer1.SetWordID(Me.GV1_RETURN_YN, "요청반려")
        Me.Localizer1.SetWordID(Me.GV1_RANK, "난이도")
        Me.Localizer1.SetWordID(Me.GV1_EX_IM_TYPE, "내근/외근")
        Me.Localizer1.SetWordID(Me.GV1_SCORE_UNIT, "항목점수")
        Me.Localizer1.SetWordID(Me.GV1_SCORE_RANK, "난이도점수")
        Me.Localizer1.SetWordID(Me.GV1_SCORE_EXIM, "내외근점수")
        Me.Localizer1.SetWordID(Me.GV1_SCORE_TOT, "평가점수")
        Me.Localizer1.SetWordID(Me.GV1_CUST_DEPT_NM, "요청자부서")
        Me.Localizer1.SetWordID(Me.GV1_PROJECT_CD, "프로젝트")
        Me.Localizer1.SetWordID(Me.GV1_PREV_WEEK, "주차")
        Me.Localizer1.SetWordID(Me.GV1_SELF_PROC_YN, "자체처리 여부")
        Me.Localizer1.SetWordID(Me.xtcMain, "")
        Me.Localizer1.SetWordID(Me.xtpDetail, "상세")
        Me.Localizer1.SetWordID(Me.xtpSummary, "합계")
        Me.Localizer1.SetWordID(Me.splitMain, "SplitContainerControl1")
        Me.Localizer1.SetWordID(Me.PGC1, "")
        Me.Localizer1.SetWordID(Me.WG2, "")
        Me.Localizer1.SetWordID(Me.GridColumn1, "등록자")
        Me.Localizer1.SetWordID(Me.GridColumn2, "작업자")
        Me.Localizer1.SetWordID(Me.GridColumn3, "코드")
        Me.Localizer1.SetWordID(Me.GridColumn12, "업무구분1")
        Me.Localizer1.SetWordID(Me.GridColumn13, "업무구분2")
        Me.Localizer1.SetWordID(Me.GridColumn4, "거래처 명")
        Me.Localizer1.SetWordID(Me.GridColumn5, "요청날짜")
        Me.Localizer1.SetWordID(Me.GridColumn6, "상태")
        Me.Localizer1.SetWordID(Me.GridColumn7, "고객요청사항")
        Me.Localizer1.SetWordID(Me.GridColumn8, "조치사항")
        Me.Localizer1.SetWordID(Me.GridColumn9, "Document")
        Me.Localizer1.SetWordID(Me.GridColumn10, "요청자")
        Me.Localizer1.SetWordID(Me.GridColumn11, "연락처")
        Me.Localizer1.SetWordID(Me.GridColumn14, "업무구분3")
        Me.Localizer1.SetWordID(Me.GridColumn15, "공유부서")
        Me.Localizer1.SetWordID(Me.GridColumn16, "우선순위")
        Me.Localizer1.SetWordID(Me.GridColumn17, "예정일자")
        Me.Localizer1.SetWordID(Me.GridColumn18, "요청상태")
        Me.Localizer1.SetWordID(Me.GridColumn19, "답변")
        Me.Localizer1.SetWordID(Me.GridColumn20, "등록날짜")
        Me.Localizer1.SetWordID(Me.GridColumn21, "유상/무상")
        Me.Localizer1.SetWordID(Me.GridColumn22, "System ID")
        Me.Localizer1.SetWordID(Me.GridColumn23, "접수")
        Me.Localizer1.SetWordID(Me.GridColumn24, "완료날짜")
        Me.Localizer1.SetWordID(Me.GridColumn25, "관리번호")
        Me.Localizer1.SetWordID(Me.GridColumn26, "교육만족도")
        Me.Localizer1.SetWordID(Me.GridColumn27, "요청일")
        Me.Localizer1.SetWordID(Me.GridColumn28, "요청시간")
        Me.Localizer1.SetWordID(Me.GridColumn29, "완료일")
        Me.Localizer1.SetWordID(Me.GridColumn30, "완료시간")
        Me.Localizer1.SetWordID(Me.GridColumn31, "개발팀완료")
        Me.Localizer1.SetWordID(Me.GridColumn32, "요청반려")
        Me.Localizer1.SetWordID(Me.GridColumn33, "난이도")
        Me.Localizer1.SetWordID(Me.GridColumn34, "내외근")
        Me.Localizer1.SetWordID(Me.GridColumn35, "항목점수")
        Me.Localizer1.SetWordID(Me.GridColumn36, "난이도점수")
        Me.Localizer1.SetWordID(Me.GridColumn37, "내외근점수")
        Me.Localizer1.SetWordID(Me.GridColumn38, "평가점수")
        Me.Localizer1.SetWordID(Me.panelSummary, "")
        Me.Localizer1.SetWordID(Me.radioSummary, "A")
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Controls.Add(Me.lbl_S_SELF_PROC_YN)
        Me.PanelControl4.Controls.Add(Me.S_SELF_PROC_YN)
        Me.PanelControl4.Controls.Add(Me.S_DEPT_CD_M)
        Me.PanelControl4.Controls.Add(Me.S_PROJECT_NM)
        Me.PanelControl4.Controls.Add(Me.S_PROJECT_CD)
        Me.PanelControl4.Controls.Add(Me.Label1)
        Me.PanelControl4.Controls.Add(Me.Label7)
        Me.PanelControl4.Controls.Add(Me.lbl_S_EX_IM_TYPE)
        Me.PanelControl4.Controls.Add(Me.S_EX_IM_TYPE)
        Me.PanelControl4.Controls.Add(Me.S_REQ_TYPE2)
        Me.PanelControl4.Controls.Add(Me.S_DEPT_TYPE)
        Me.PanelControl4.Controls.Add(Me.S_WORK_TYPE)
        Me.PanelControl4.Controls.Add(Me.S_DEPT_AUTH)
        Me.PanelControl4.Controls.Add(Me.Label23)
        Me.PanelControl4.Controls.Add(Me.S_PROC_TYPE)
        Me.PanelControl4.Controls.Add(Me.Label20)
        Me.PanelControl4.Controls.Add(Me.S_DEPT_CD)
        Me.PanelControl4.Controls.Add(Me.S_CUST_CD)
        Me.PanelControl4.Controls.Add(Me.S_CUST_NM)
        Me.PanelControl4.Controls.Add(Me.S_DATE_TYPE)
        Me.PanelControl4.Controls.Add(Me.S_REQ_SVC2)
        Me.PanelControl4.Controls.Add(Me.S_WORK_USR_NM)
        Me.PanelControl4.Controls.Add(Me.S_WORK_USR)
        Me.PanelControl4.Controls.Add(Me.Label33)
        Me.PanelControl4.Controls.Add(Me.S_REQ_SVC)
        Me.PanelControl4.Controls.Add(Me.SEARCH_KEY)
        Me.PanelControl4.Controls.Add(Me.Label21)
        Me.PanelControl4.Controls.Add(Me.S_TO_YMD)
        Me.PanelControl4.Controls.Add(Me.S_FM_YMD)
        Me.PanelControl4.Controls.Add(Me.Label32)
        Me.PanelControl4.Location = New System.Drawing.Point(5, 38)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1182, 89)
        Me.PanelControl4.TabIndex = 297
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        '
        'lbl_S_SELF_PROC_YN
        '
        Me.lbl_S_SELF_PROC_YN.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_S_SELF_PROC_YN.LabelFor = Nothing
        Me.lbl_S_SELF_PROC_YN.Location = New System.Drawing.Point(889, 31)
        Me.lbl_S_SELF_PROC_YN.Name = "lbl_S_SELF_PROC_YN"
        Me.lbl_S_SELF_PROC_YN.Size = New System.Drawing.Size(84, 20)
        Me.lbl_S_SELF_PROC_YN.TabIndex = 10033
        Me.lbl_S_SELF_PROC_YN.Text = "자체처리 여부"
        Me.lbl_S_SELF_PROC_YN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_SELF_PROC_YN, "자체처리 여부")
        '
        'S_SELF_PROC_YN
        '
        Me.S_SELF_PROC_YN.CodeType = ""
        Me.S_SELF_PROC_YN.ColumnWidths = ""
        Me.S_SELF_PROC_YN.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_SELF_PROC_YN.DataParams = ""
        Me.S_SELF_PROC_YN.DefVal = ""
        Me.S_SELF_PROC_YN.DisplayMember = "NAME"
        Me.S_SELF_PROC_YN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_SELF_PROC_YN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_SELF_PROC_YN.FormattingEnabled = True
        Me.S_SELF_PROC_YN.IsDataStateAware = True
        Me.S_SELF_PROC_YN.ItemDelimiter = ","
        Me.S_SELF_PROC_YN.ItemTextList = "일반 건,자체처리 건"
        Me.S_SELF_PROC_YN.ItemValueList = "N,Y"
        Me.S_SELF_PROC_YN.KeepIntegrity = True
        Me.S_SELF_PROC_YN.Location = New System.Drawing.Point(978, 30)
        Me.S_SELF_PROC_YN.Name = "S_SELF_PROC_YN"
        Me.S_SELF_PROC_YN.NextFocus = "SEARCH_KEY"
        Me.S_SELF_PROC_YN.NullText = "--Select--"
        Me.S_SELF_PROC_YN.SearchKeys = ""
        Me.S_SELF_PROC_YN.Size = New System.Drawing.Size(117, 23)
        Me.S_SELF_PROC_YN.TabIndex = 10032
        Me.S_SELF_PROC_YN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_SELF_PROC_YN.ValueMember = "CODE"
        '
        'S_DEPT_CD_M
        '
        Me.S_DEPT_CD_M.Location = New System.Drawing.Point(465, 5)
        Me.S_DEPT_CD_M.Name = "S_DEPT_CD_M"
        Me.S_DEPT_CD_M.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.S_DEPT_CD_M.Properties.Appearance.Options.UseFont = True
        Me.S_DEPT_CD_M.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.S_DEPT_CD_M.Size = New System.Drawing.Size(44, 22)
        Me.S_DEPT_CD_M.TabIndex = 10031
        Me.S_DEPT_CD_M.Visible = False
        Me.Localizer1.SetWordID(Me.S_DEPT_CD_M, "")
        '
        'S_PROJECT_NM
        '
        Me.S_PROJECT_NM.AutoEllipsis = True
        Me.S_PROJECT_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_PROJECT_NM.LabelFor = Nothing
        Me.S_PROJECT_NM.Location = New System.Drawing.Point(746, 30)
        Me.S_PROJECT_NM.Name = "S_PROJECT_NM"
        Me.S_PROJECT_NM.Size = New System.Drawing.Size(129, 22)
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
        Me.S_PROJECT_CD.IconVisible = True
        Me.S_PROJECT_CD.IsDataStateAware = True
        Me.S_PROJECT_CD.KeepIntegrity = True
        Me.S_PROJECT_CD.Location = New System.Drawing.Point(675, 30)
        Me.S_PROJECT_CD.MaxLength = 10
        Me.S_PROJECT_CD.Name = "S_PROJECT_CD"
        Me.S_PROJECT_CD.NextFocus = "S_SELF_PROC_YN"
        Me.S_PROJECT_CD.SearchPopup = "CodeMaster"
        Me.S_PROJECT_CD.Size = New System.Drawing.Size(70, 22)
        Me.S_PROJECT_CD.SuppressValidateCode = False
        Me.S_PROJECT_CD.TabIndex = 10029
        Me.S_PROJECT_CD.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.S_PROJECT_CD.ValidateKeys = "KEY:@S_PROJECT_CD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(618, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 10028
        Me.Label1.Text = "프로젝트"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(43, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 277
        Me.Label7.Text = "거래처"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label7, "")
        '
        'lbl_S_EX_IM_TYPE
        '
        Me.lbl_S_EX_IM_TYPE.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_S_EX_IM_TYPE.LabelFor = Nothing
        Me.lbl_S_EX_IM_TYPE.Location = New System.Drawing.Point(605, 56)
        Me.lbl_S_EX_IM_TYPE.Name = "lbl_S_EX_IM_TYPE"
        Me.lbl_S_EX_IM_TYPE.Size = New System.Drawing.Size(65, 20)
        Me.lbl_S_EX_IM_TYPE.TabIndex = 10024
        Me.lbl_S_EX_IM_TYPE.Text = "내근/외근"
        Me.lbl_S_EX_IM_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.lbl_S_EX_IM_TYPE, "")
        '
        'S_EX_IM_TYPE
        '
        Me.S_EX_IM_TYPE.CodeType = ""
        Me.S_EX_IM_TYPE.ColumnWidths = ""
        Me.S_EX_IM_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_EX_IM_TYPE.DataParams = ""
        Me.S_EX_IM_TYPE.DefVal = ""
        Me.S_EX_IM_TYPE.DisplayMember = "NAME"
        Me.S_EX_IM_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_EX_IM_TYPE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_EX_IM_TYPE.FormattingEnabled = True
        Me.S_EX_IM_TYPE.IsDataStateAware = True
        Me.S_EX_IM_TYPE.ItemDelimiter = ","
        Me.S_EX_IM_TYPE.ItemTextList = "내근,외근"
        Me.S_EX_IM_TYPE.ItemValueList = "I,E"
        Me.S_EX_IM_TYPE.KeepIntegrity = True
        Me.S_EX_IM_TYPE.Location = New System.Drawing.Point(675, 55)
        Me.S_EX_IM_TYPE.Name = "S_EX_IM_TYPE"
        Me.S_EX_IM_TYPE.NextFocus = "btnSearch"
        Me.S_EX_IM_TYPE.NullText = "--Select--"
        Me.S_EX_IM_TYPE.SearchKeys = ""
        Me.S_EX_IM_TYPE.Size = New System.Drawing.Size(70, 23)
        Me.S_EX_IM_TYPE.TabIndex = 10023
        Me.S_EX_IM_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_EX_IM_TYPE.ValueMember = "CODE"
        '
        'S_REQ_TYPE2
        '
        Me.S_REQ_TYPE2.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_REQ_TYPE2.ColumnWidths = ""
        Me.S_REQ_TYPE2.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_REQ_TYPE2.DataParams = "GroupCode:'T09',NameType:''"
        Me.S_REQ_TYPE2.DefVal = ""
        Me.S_REQ_TYPE2.DisplayMember = "NAME"
        Me.S_REQ_TYPE2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_REQ_TYPE2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_REQ_TYPE2.FormattingEnabled = True
        Me.S_REQ_TYPE2.IsDataStateAware = True
        Me.S_REQ_TYPE2.ItemDelimiter = ","
        Me.S_REQ_TYPE2.ItemTextList = ""
        Me.S_REQ_TYPE2.ItemValueList = ""
        Me.S_REQ_TYPE2.KeepIntegrity = True
        Me.S_REQ_TYPE2.Location = New System.Drawing.Point(525, 55)
        Me.S_REQ_TYPE2.Name = "S_REQ_TYPE2"
        Me.S_REQ_TYPE2.NextFocus = "S_EX_IM_TYPE"
        Me.S_REQ_TYPE2.NullText = "--Select--"
        Me.S_REQ_TYPE2.SearchKeys = ""
        Me.S_REQ_TYPE2.Size = New System.Drawing.Size(66, 23)
        Me.S_REQ_TYPE2.TabIndex = 10022
        Me.S_REQ_TYPE2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_REQ_TYPE2.ValueMember = "CODE"
        '
        'S_DEPT_TYPE
        '
        Me.S_DEPT_TYPE.CodeType = ""
        Me.S_DEPT_TYPE.ColumnWidths = ""
        Me.S_DEPT_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_DEPT_TYPE.DataParams = ""
        Me.S_DEPT_TYPE.DefVal = "W"
        Me.S_DEPT_TYPE.DisplayMember = "NAME"
        Me.S_DEPT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DEPT_TYPE.FormattingEnabled = True
        Me.S_DEPT_TYPE.IsDataStateAware = True
        Me.S_DEPT_TYPE.ItemDelimiter = ","
        Me.S_DEPT_TYPE.ItemTextList = "등록부서,작업자부서,멀티등록부서"
        Me.S_DEPT_TYPE.ItemValueList = "I,W,M"
        Me.S_DEPT_TYPE.KeepIntegrity = True
        Me.S_DEPT_TYPE.Location = New System.Drawing.Point(300, 5)
        Me.S_DEPT_TYPE.Name = "S_DEPT_TYPE"
        Me.S_DEPT_TYPE.NextFocus = "S_DEPT_CD"
        Me.S_DEPT_TYPE.NullText = ""
        Me.S_DEPT_TYPE.SearchKeys = ""
        Me.S_DEPT_TYPE.Size = New System.Drawing.Size(85, 22)
        Me.S_DEPT_TYPE.TabIndex = 10021
        Me.S_DEPT_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DEPT_TYPE.ValueMember = "CODE"
        '
        'S_WORK_TYPE
        '
        Me.S_WORK_TYPE.CodeType = ""
        Me.S_WORK_TYPE.ColumnWidths = ""
        Me.S_WORK_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_WORK_TYPE.DataParams = ""
        Me.S_WORK_TYPE.DefVal = "W"
        Me.S_WORK_TYPE.DisplayMember = "NAME"
        Me.S_WORK_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_WORK_TYPE.FormattingEnabled = True
        Me.S_WORK_TYPE.IsDataStateAware = True
        Me.S_WORK_TYPE.ItemDelimiter = ","
        Me.S_WORK_TYPE.ItemTextList = "등록자,작업자"
        Me.S_WORK_TYPE.ItemValueList = "I,W"
        Me.S_WORK_TYPE.KeepIntegrity = True
        Me.S_WORK_TYPE.Location = New System.Drawing.Point(300, 30)
        Me.S_WORK_TYPE.Name = "S_WORK_TYPE"
        Me.S_WORK_TYPE.NextFocus = "S_WORK_USR"
        Me.S_WORK_TYPE.NullText = ""
        Me.S_WORK_TYPE.SearchKeys = ""
        Me.S_WORK_TYPE.Size = New System.Drawing.Size(85, 22)
        Me.S_WORK_TYPE.TabIndex = 10020
        Me.S_WORK_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_WORK_TYPE.ValueMember = "CODE"
        '
        'S_DEPT_AUTH
        '
        Me.S_DEPT_AUTH.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_DEPT_AUTH.ColumnWidths = ""
        Me.S_DEPT_AUTH.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_DEPT_AUTH.DataParams = "GroupCode:'C03',NameType:''"
        Me.S_DEPT_AUTH.DefVal = ""
        Me.S_DEPT_AUTH.DisplayMember = "NAME"
        Me.S_DEPT_AUTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DEPT_AUTH.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_DEPT_AUTH.FormattingEnabled = True
        Me.S_DEPT_AUTH.IsDataStateAware = True
        Me.S_DEPT_AUTH.ItemDelimiter = ","
        Me.S_DEPT_AUTH.ItemTextList = ""
        Me.S_DEPT_AUTH.ItemValueList = ""
        Me.S_DEPT_AUTH.KeepIntegrity = True
        Me.S_DEPT_AUTH.Location = New System.Drawing.Point(675, 5)
        Me.S_DEPT_AUTH.Name = "S_DEPT_AUTH"
        Me.S_DEPT_AUTH.NextFocus = "S_PROC_TYPE"
        Me.S_DEPT_AUTH.NullText = "--Select--"
        Me.S_DEPT_AUTH.SearchKeys = ""
        Me.S_DEPT_AUTH.Size = New System.Drawing.Size(200, 23)
        Me.S_DEPT_AUTH.TabIndex = 10019
        Me.S_DEPT_AUTH.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DEPT_AUTH.ValueMember = "CODE"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.LabelFor = Nothing
        Me.Label23.Location = New System.Drawing.Point(603, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 15)
        Me.Label23.TabIndex = 10018
        Me.Label23.Text = "타부서공유"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label23, "")
        '
        'S_PROC_TYPE
        '
        Me.S_PROC_TYPE.Location = New System.Drawing.Point(978, 6)
        Me.S_PROC_TYPE.Name = "S_PROC_TYPE"
        Me.S_PROC_TYPE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.S_PROC_TYPE.Size = New System.Drawing.Size(117, 20)
        Me.S_PROC_TYPE.TabIndex = 10015
        Me.Localizer1.SetWordID(Me.S_PROC_TYPE, "")
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.LabelFor = Nothing
        Me.Label20.Location = New System.Drawing.Point(908, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 20)
        Me.Label20.TabIndex = 10016
        Me.Label20.Text = "상태"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label20, "")
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
        Me.S_DEPT_CD.Location = New System.Drawing.Point(391, 5)
        Me.S_DEPT_CD.Name = "S_DEPT_CD"
        Me.S_DEPT_CD.NextFocus = "S_DEPT_AUTH"
        Me.S_DEPT_CD.NullText = "--Select--"
        Me.S_DEPT_CD.SearchKeys = ""
        Me.S_DEPT_CD.Size = New System.Drawing.Size(200, 23)
        Me.S_DEPT_CD.TabIndex = 10014
        Me.S_DEPT_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DEPT_CD.ValueMember = "CODE"
        '
        'S_CUST_CD
        '
        Me.S_CUST_CD.AlwaysSetDisplayParams = True
        Me.S_CUST_CD.AutoSuggestion = False
        Me.S_CUST_CD.BorderColor = System.Drawing.Color.Silver
        Me.S_CUST_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_CUST_CD.CodeType = "YJIT.CodeService.Customer"
        Me.S_CUST_CD.DataParams = ""
        Me.S_CUST_CD.DefVal = ""
        Me.S_CUST_CD.DisplayParams = "Code:@S_CUST_CD,Name:@S_CUST_NM"
        Me.S_CUST_CD.EditPopup = ""
        Me.S_CUST_CD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_CUST_CD.IconVisible = True
        Me.S_CUST_CD.IsDataStateAware = True
        Me.S_CUST_CD.KeepIntegrity = True
        Me.S_CUST_CD.Location = New System.Drawing.Point(90, 30)
        Me.S_CUST_CD.Name = "S_CUST_CD"
        Me.S_CUST_CD.NextFocus = "S_WORK_USR"
        Me.S_CUST_CD.SearchPopup = "CodeMaster"
        Me.S_CUST_CD.Size = New System.Drawing.Size(91, 23)
        Me.S_CUST_CD.SuppressValidateCode = False
        Me.S_CUST_CD.TabIndex = 10012
        Me.S_CUST_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_CUST_CD.ValidateKeys = "KEY:@S_CUST_CD"
        '
        'S_CUST_NM
        '
        Me.S_CUST_NM.AutoEllipsis = True
        Me.S_CUST_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_CUST_NM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_CUST_NM.LabelFor = Nothing
        Me.S_CUST_NM.Location = New System.Drawing.Point(182, 30)
        Me.S_CUST_NM.Name = "S_CUST_NM"
        Me.S_CUST_NM.Size = New System.Drawing.Size(103, 23)
        Me.S_CUST_NM.TabIndex = 10013
        Me.S_CUST_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'S_DATE_TYPE
        '
        Me.S_DATE_TYPE.CodeType = ""
        Me.S_DATE_TYPE.ColumnWidths = ""
        Me.S_DATE_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_DATE_TYPE.DataParams = ""
        Me.S_DATE_TYPE.DefVal = "R"
        Me.S_DATE_TYPE.DisplayMember = "NAME"
        Me.S_DATE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_DATE_TYPE.FormattingEnabled = True
        Me.S_DATE_TYPE.IsDataStateAware = True
        Me.S_DATE_TYPE.ItemDelimiter = ","
        Me.S_DATE_TYPE.ItemTextList = "요청일자,완료일자"
        Me.S_DATE_TYPE.ItemValueList = "R,C"
        Me.S_DATE_TYPE.KeepIntegrity = True
        Me.S_DATE_TYPE.Location = New System.Drawing.Point(15, 5)
        Me.S_DATE_TYPE.Name = "S_DATE_TYPE"
        Me.S_DATE_TYPE.NextFocus = "S_FM_YMD"
        Me.S_DATE_TYPE.NullText = ""
        Me.S_DATE_TYPE.SearchKeys = ""
        Me.S_DATE_TYPE.Size = New System.Drawing.Size(74, 22)
        Me.S_DATE_TYPE.TabIndex = 287
        Me.S_DATE_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_DATE_TYPE.ValueMember = "CODE"
        '
        'S_REQ_SVC2
        '
        Me.S_REQ_SVC2.CodeType = ""
        Me.S_REQ_SVC2.ColumnWidths = ""
        Me.S_REQ_SVC2.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_REQ_SVC2.DataParams = ""
        Me.S_REQ_SVC2.DefVal = "B"
        Me.S_REQ_SVC2.DisplayMember = "NAME"
        Me.S_REQ_SVC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_REQ_SVC2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_REQ_SVC2.FormattingEnabled = True
        Me.S_REQ_SVC2.IsDataStateAware = True
        Me.S_REQ_SVC2.ItemDelimiter = ","
        Me.S_REQ_SVC2.ItemTextList = ""
        Me.S_REQ_SVC2.ItemValueList = ""
        Me.S_REQ_SVC2.KeepIntegrity = True
        Me.S_REQ_SVC2.Location = New System.Drawing.Point(458, 55)
        Me.S_REQ_SVC2.Name = "S_REQ_SVC2"
        Me.S_REQ_SVC2.NextFocus = "S_REQ_TYPE2"
        Me.S_REQ_SVC2.NullText = ""
        Me.S_REQ_SVC2.SearchKeys = ""
        Me.S_REQ_SVC2.Size = New System.Drawing.Size(66, 23)
        Me.S_REQ_SVC2.TabIndex = 285
        Me.S_REQ_SVC2.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_REQ_SVC2.ValueMember = "CODE"
        '
        'S_WORK_USR_NM
        '
        Me.S_WORK_USR_NM.AutoEllipsis = True
        Me.S_WORK_USR_NM.BorderColor = System.Drawing.Color.Silver
        Me.S_WORK_USR_NM.LabelFor = Nothing
        Me.S_WORK_USR_NM.Location = New System.Drawing.Point(462, 30)
        Me.S_WORK_USR_NM.Name = "S_WORK_USR_NM"
        Me.S_WORK_USR_NM.Size = New System.Drawing.Size(129, 22)
        Me.S_WORK_USR_NM.TabIndex = 284
        Me.S_WORK_USR_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'S_WORK_USR
        '
        Me.S_WORK_USR.AlwaysSetDisplayParams = False
        Me.S_WORK_USR.AutoSuggestion = True
        Me.S_WORK_USR.BorderColor = System.Drawing.Color.Silver
        Me.S_WORK_USR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.S_WORK_USR.CodeType = "YJIT.CodeService.User"
        Me.S_WORK_USR.DataParams = "Type:'',Office:@OFFICE_CD"
        Me.S_WORK_USR.DefVal = ""
        Me.S_WORK_USR.DisplayParams = "Code:@S_WORK_USR,Name:@S_WORK_USR_NM"
        Me.S_WORK_USR.EditPopup = ""
        Me.S_WORK_USR.IconVisible = True
        Me.S_WORK_USR.IsDataStateAware = True
        Me.S_WORK_USR.KeepIntegrity = True
        Me.S_WORK_USR.Location = New System.Drawing.Point(391, 30)
        Me.S_WORK_USR.MaxLength = 10
        Me.S_WORK_USR.Name = "S_WORK_USR"
        Me.S_WORK_USR.NextFocus = "S_PROJECT_CD"
        Me.S_WORK_USR.SearchPopup = "CodeMaster"
        Me.S_WORK_USR.Size = New System.Drawing.Size(70, 22)
        Me.S_WORK_USR.SuppressValidateCode = False
        Me.S_WORK_USR.TabIndex = 283
        Me.S_WORK_USR.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.S_WORK_USR.ValidateKeys = "KEY:@S_WORK_USR"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.LabelFor = Nothing
        Me.Label33.Location = New System.Drawing.Point(286, 56)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(99, 20)
        Me.Label33.TabIndex = 276
        Me.Label33.Text = "업무구분1,2,3"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label33, "")
        '
        'S_REQ_SVC
        '
        Me.S_REQ_SVC.CodeType = "YJIT.CodeService.CommonCode"
        Me.S_REQ_SVC.ColumnWidths = ""
        Me.S_REQ_SVC.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.S_REQ_SVC.DataParams = "GroupCode:'T02',NameType:''"
        Me.S_REQ_SVC.DefVal = ""
        Me.S_REQ_SVC.DisplayMember = "NAME"
        Me.S_REQ_SVC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.S_REQ_SVC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.S_REQ_SVC.FormattingEnabled = True
        Me.S_REQ_SVC.IsDataStateAware = True
        Me.S_REQ_SVC.ItemDelimiter = ","
        Me.S_REQ_SVC.ItemTextList = ""
        Me.S_REQ_SVC.ItemValueList = ""
        Me.S_REQ_SVC.KeepIntegrity = True
        Me.S_REQ_SVC.Location = New System.Drawing.Point(391, 55)
        Me.S_REQ_SVC.Name = "S_REQ_SVC"
        Me.S_REQ_SVC.NextFocus = "S_REQ_SVC2"
        Me.S_REQ_SVC.NullText = "--Select--"
        Me.S_REQ_SVC.SearchKeys = ""
        Me.S_REQ_SVC.Size = New System.Drawing.Size(66, 23)
        Me.S_REQ_SVC.TabIndex = 275
        Me.S_REQ_SVC.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.S_REQ_SVC.ValueMember = "CODE"
        '
        'SEARCH_KEY
        '
        Me.SEARCH_KEY.BorderColor = System.Drawing.Color.Silver
        Me.SEARCH_KEY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SEARCH_KEY.DefVal = ""
        Me.SEARCH_KEY.IsDataStateAware = True
        Me.SEARCH_KEY.Location = New System.Drawing.Point(90, 55)
        Me.SEARCH_KEY.Name = "SEARCH_KEY"
        Me.SEARCH_KEY.NextFocus = "S_REQ_SVC"
        Me.SEARCH_KEY.Size = New System.Drawing.Size(195, 22)
        Me.SEARCH_KEY.TabIndex = 4
        Me.SEARCH_KEY.TextCasing = YJIT.SC.UI.TextCasings.Normal
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.LabelFor = Nothing
        Me.Label21.Location = New System.Drawing.Point(16, 59)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 14)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Search Key"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label21, "Search Key")
        '
        'S_TO_YMD
        '
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
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.LabelFor = Nothing
        Me.Label32.Location = New System.Drawing.Point(181, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 14)
        Me.Label32.TabIndex = 59
        Me.Label32.Text = "~"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Localizer1.SetWordID(Me.Label32, "~")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1013, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 25)
        Me.btnSearch.TabIndex = 9999
        Me.btnSearch.Text = "조회(&A)"
        Me.Localizer1.SetWordID(Me.btnSearch, "")
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
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Controls.Add(Me.btnCrmAsMst)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(5, 3)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1306, 32)
        Me.palAutoButton.TabIndex = 278
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(1093, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(78, 25)
        Me.btnNew.TabIndex = 10001
        Me.btnNew.Text = "초기화(&C)"
        Me.Localizer1.SetWordID(Me.btnNew, "초기화(&C)")
        '
        'btnCrmAsMst
        '
        Me.btnCrmAsMst.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrmAsMst.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnCrmAsMst.Image = CType(resources.GetObject("btnCrmAsMst.Image"), System.Drawing.Image)
        Me.btnCrmAsMst.Location = New System.Drawing.Point(1177, 3)
        Me.btnCrmAsMst.Name = "btnCrmAsMst"
        Me.btnCrmAsMst.Size = New System.Drawing.Size(124, 25)
        Me.btnCrmAsMst.TabIndex = 10000
        Me.btnCrmAsMst.Text = "고객지원 등록(&N)"
        Me.Localizer1.SetWordID(Me.btnCrmAsMst, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.btnDeleteCol)
        Me.PanelControl2.Controls.Add(Me.btnSaveCol)
        Me.PanelControl2.Controls.Add(Me.btnSearchCol)
        Me.PanelControl2.Controls.Add(Me.LayOutList)
        Me.PanelControl2.Location = New System.Drawing.Point(1190, 38)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(121, 89)
        Me.PanelControl2.TabIndex = 301
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'btnDeleteCol
        '
        Me.btnDeleteCol.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnDeleteCol.Image = CType(resources.GetObject("btnDeleteCol.Image"), System.Drawing.Image)
        Me.btnDeleteCol.Location = New System.Drawing.Point(58, 4)
        Me.btnDeleteCol.Name = "btnDeleteCol"
        Me.btnDeleteCol.Size = New System.Drawing.Size(24, 22)
        Me.btnDeleteCol.TabIndex = 6
        Me.btnDeleteCol.Text = " "
        Me.Localizer1.SetWordID(Me.btnDeleteCol, " ")
        '
        'btnSaveCol
        '
        Me.btnSaveCol.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSaveCol.Image = CType(resources.GetObject("btnSaveCol.Image"), System.Drawing.Image)
        Me.btnSaveCol.Location = New System.Drawing.Point(32, 4)
        Me.btnSaveCol.Name = "btnSaveCol"
        Me.btnSaveCol.Size = New System.Drawing.Size(24, 22)
        Me.btnSaveCol.TabIndex = 5
        Me.btnSaveCol.Text = " "
        Me.Localizer1.SetWordID(Me.btnSaveCol, " ")
        '
        'btnSearchCol
        '
        Me.btnSearchCol.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearchCol.Image = CType(resources.GetObject("btnSearchCol.Image"), System.Drawing.Image)
        Me.btnSearchCol.Location = New System.Drawing.Point(5, 4)
        Me.btnSearchCol.Name = "btnSearchCol"
        Me.btnSearchCol.Size = New System.Drawing.Size(25, 22)
        Me.btnSearchCol.TabIndex = 4
        Me.btnSearchCol.Text = " "
        Me.Localizer1.SetWordID(Me.btnSearchCol, " ")
        '
        'LayOutList
        '
        Me.LayOutList.CodeType = ""
        Me.LayOutList.ColumnWidths = ""
        Me.LayOutList.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Asynchronous
        Me.LayOutList.DataParams = ""
        Me.LayOutList.DefVal = ""
        Me.LayOutList.DisplayMember = "NAME"
        Me.LayOutList.FormattingEnabled = True
        Me.LayOutList.IsDataStateAware = True
        Me.LayOutList.ItemDelimiter = ","
        Me.LayOutList.ItemTextList = ""
        Me.LayOutList.ItemValueList = ""
        Me.LayOutList.KeepIntegrity = True
        Me.LayOutList.Location = New System.Drawing.Point(5, 27)
        Me.LayOutList.Name = "LayOutList"
        Me.LayOutList.NextFocus = ""
        Me.LayOutList.NullText = ""
        Me.LayOutList.SearchKeys = ""
        Me.LayOutList.Size = New System.Drawing.Size(112, 22)
        Me.LayOutList.TabIndex = 7
        Me.LayOutList.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.LayOutList.ValueMember = "CODE"
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
        Me.WG1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoExEdit3})
        Me.WG1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG1.SaveLayout = True
        Me.WG1.Size = New System.Drawing.Size(1294, 550)
        Me.WG1.TabIndex = 302
        Me.WG1.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV1})
        '
        'GV1
        '
        Me.GV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV1_INS_USR, Me.GV1_WORK_USR, Me.GV1_CUST_CD, Me.GV1_CUST_NM, Me.GV1_REQ_DATE, Me.GV1_TAKE_DATE, Me.GV1_PROC_TYPE, Me.GV1_CONTENT, Me.GV1_RMK, Me.GV1_DOC_CNT, Me.GV1_REQ_USR, Me.GV1_TEL_NO, Me.GV1_REQ_SVC, Me.GV1_REQ_SVC2, Me.GV1_REQ_TYPE2, Me.GV1_SHARE_DEPT, Me.GV1_PRIORITY, Me.GV1_PRAR_YMD, Me.GV1_REQ_TYPE, Me.GV1_CMPT_RMK, Me.GV1_INS_DATE, Me.GV1_FREE_YN, Me.GV1_SYS_ID, Me.GV1_SYS_NM, Me.GV1_CMPT_DATE, Me.GV1_MNGT_NO, Me.GV1_UPPER_MNGT_NO, Me.GV1_ORGN_MNGT_NO, Me.GV1_EDU_LV, Me.GV1_REQ_YMD, Me.GV1_REQ_HM, Me.GV1_CMPT_YMD, Me.GV1_CMPT_HM, Me.GV1_DEV_CMPT_YN, Me.GV1_RETURN_YN, Me.GV1_RANK, Me.GV1_EX_IM_TYPE, Me.GV1_SCORE_UNIT, Me.GV1_SCORE_RANK, Me.GV1_SCORE_EXIM, Me.GV1_SCORE_TOT, Me.GV1_CUST_DEPT_NM, Me.GV1_PROJECT_CD, Me.GV1_PREV_WEEK, Me.GV1_SELF_PROC_YN})
        Me.GV1.GridControl = Me.WG1
        Me.GV1.Name = "GV1"
        Me.GV1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused
        Me.GV1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV1.OptionsView.BestFitMaxRowCount = 10
        Me.GV1.OptionsView.ColumnAutoWidth = False
        Me.GV1.OptionsView.EnableAppearanceEvenRow = True
        Me.GV1.RowHeight = 10
        Me.GV1.ViewCaption = " 고객 리스트"
        '
        'GV1_INS_USR
        '
        Me.GV1_INS_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_INS_USR.AppearanceCell.Options.UseFont = True
        Me.GV1_INS_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_INS_USR.AppearanceHeader.Options.UseFont = True
        Me.GV1_INS_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_USR.Caption = "등록자"
        Me.GV1_INS_USR.FieldName = "INS_USR"
        Me.GV1_INS_USR.Name = "GV1_INS_USR"
        Me.GV1_INS_USR.OptionsColumn.AllowEdit = False
        Me.GV1_INS_USR.OptionsColumn.ReadOnly = True
        Me.GV1_INS_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_INS_USR.Visible = True
        Me.GV1_INS_USR.VisibleIndex = 0
        Me.GV1_INS_USR.Width = 55
        Me.Localizer1.SetWordID(Me.GV1_INS_USR, "")
        '
        'GV1_WORK_USR
        '
        Me.GV1_WORK_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_WORK_USR.AppearanceCell.Options.UseFont = True
        Me.GV1_WORK_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_WORK_USR.AppearanceHeader.Options.UseFont = True
        Me.GV1_WORK_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_WORK_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_WORK_USR.Caption = "작업자"
        Me.GV1_WORK_USR.FieldName = "WORK_USR"
        Me.GV1_WORK_USR.Name = "GV1_WORK_USR"
        Me.GV1_WORK_USR.OptionsColumn.AllowEdit = False
        Me.GV1_WORK_USR.OptionsColumn.ReadOnly = True
        Me.GV1_WORK_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_WORK_USR.Visible = True
        Me.GV1_WORK_USR.VisibleIndex = 1
        Me.GV1_WORK_USR.Width = 55
        Me.Localizer1.SetWordID(Me.GV1_WORK_USR, "")
        '
        'GV1_CUST_CD
        '
        Me.GV1_CUST_CD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_CUST_CD.AppearanceCell.Options.UseFont = True
        Me.GV1_CUST_CD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CUST_CD.AppearanceHeader.Options.UseFont = True
        Me.GV1_CUST_CD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_CD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_CD.Caption = "코드"
        Me.GV1_CUST_CD.FieldName = "CUST_CD"
        Me.GV1_CUST_CD.Name = "GV1_CUST_CD"
        Me.GV1_CUST_CD.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_CD.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_CD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CUST_CD.Width = 57
        Me.Localizer1.SetWordID(Me.GV1_CUST_CD, "")
        '
        'GV1_CUST_NM
        '
        Me.GV1_CUST_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_CUST_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_CUST_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CUST_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_CUST_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CUST_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CUST_NM.Caption = "거래처 명"
        Me.GV1_CUST_NM.FieldName = "CUST_NM"
        Me.GV1_CUST_NM.Name = "GV1_CUST_NM"
        Me.GV1_CUST_NM.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_NM.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_NM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CUST_NM.Visible = True
        Me.GV1_CUST_NM.VisibleIndex = 2
        Me.GV1_CUST_NM.Width = 150
        Me.Localizer1.SetWordID(Me.GV1_CUST_NM, "")
        '
        'GV1_REQ_DATE
        '
        Me.GV1_REQ_DATE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_DATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_DATE.Caption = "요청날짜"
        Me.GV1_REQ_DATE.FieldName = "REQ_DATE"
        Me.GV1_REQ_DATE.Name = "GV1_REQ_DATE"
        Me.GV1_REQ_DATE.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_DATE.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_DATE.Visible = True
        Me.GV1_REQ_DATE.VisibleIndex = 3
        Me.GV1_REQ_DATE.Width = 110
        Me.Localizer1.SetWordID(Me.GV1_REQ_DATE, "")
        '
        'GV1_TAKE_DATE
        '
        Me.GV1_TAKE_DATE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TAKE_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TAKE_DATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TAKE_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TAKE_DATE.Caption = "접수일자"
        Me.GV1_TAKE_DATE.FieldName = "TAKE_DATE"
        Me.GV1_TAKE_DATE.Name = "GV1_TAKE_DATE"
        Me.GV1_TAKE_DATE.OptionsColumn.AllowEdit = False
        Me.GV1_TAKE_DATE.OptionsColumn.ReadOnly = True
        Me.GV1_TAKE_DATE.Visible = True
        Me.GV1_TAKE_DATE.VisibleIndex = 4
        Me.GV1_TAKE_DATE.Width = 110
        Me.Localizer1.SetWordID(Me.GV1_TAKE_DATE, "접수일자")
        '
        'GV1_PROC_TYPE
        '
        Me.GV1_PROC_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_PROC_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_PROC_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PROC_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROC_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PROC_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV1_PROC_TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PROC_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PROC_TYPE.Caption = "상태"
        Me.GV1_PROC_TYPE.FieldName = "PROC_TYPE"
        Me.GV1_PROC_TYPE.Name = "GV1_PROC_TYPE"
        Me.GV1_PROC_TYPE.OptionsColumn.AllowEdit = False
        Me.GV1_PROC_TYPE.OptionsColumn.ReadOnly = True
        Me.GV1_PROC_TYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PROC_TYPE.Visible = True
        Me.GV1_PROC_TYPE.VisibleIndex = 5
        Me.GV1_PROC_TYPE.Width = 61
        Me.Localizer1.SetWordID(Me.GV1_PROC_TYPE, "")
        '
        'GV1_CONTENT
        '
        Me.GV1_CONTENT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_CONTENT.AppearanceCell.Options.UseFont = True
        Me.GV1_CONTENT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CONTENT.AppearanceHeader.Options.UseFont = True
        Me.GV1_CONTENT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CONTENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CONTENT.Caption = "고객요청사항"
        Me.GV1_CONTENT.ColumnEdit = Me.RepositoryItemMemoExEdit3
        Me.GV1_CONTENT.FieldName = "CONTENT"
        Me.GV1_CONTENT.Name = "GV1_CONTENT"
        Me.GV1_CONTENT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_CONTENT.Visible = True
        Me.GV1_CONTENT.VisibleIndex = 6
        Me.GV1_CONTENT.Width = 370
        Me.Localizer1.SetWordID(Me.GV1_CONTENT, "")
        '
        'RepositoryItemMemoExEdit3
        '
        Me.RepositoryItemMemoExEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit3.Name = "RepositoryItemMemoExEdit3"
        Me.RepositoryItemMemoExEdit3.PopupFormSize = New System.Drawing.Size(400, 200)
        Me.RepositoryItemMemoExEdit3.ReadOnly = True
        Me.RepositoryItemMemoExEdit3.ShowIcon = False
        '
        'GV1_RMK
        '
        Me.GV1_RMK.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_RMK.AppearanceCell.Options.UseFont = True
        Me.GV1_RMK.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_RMK.AppearanceHeader.Options.UseFont = True
        Me.GV1_RMK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RMK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RMK.Caption = "조치사항"
        Me.GV1_RMK.ColumnEdit = Me.RepositoryItemMemoExEdit3
        Me.GV1_RMK.FieldName = "RMK"
        Me.GV1_RMK.Name = "GV1_RMK"
        Me.GV1_RMK.OptionsColumn.ReadOnly = True
        Me.GV1_RMK.Visible = True
        Me.GV1_RMK.VisibleIndex = 7
        Me.GV1_RMK.Width = 315
        Me.Localizer1.SetWordID(Me.GV1_RMK, "")
        '
        'GV1_DOC_CNT
        '
        Me.GV1_DOC_CNT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_DOC_CNT.AppearanceCell.Options.UseFont = True
        Me.GV1_DOC_CNT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_DOC_CNT.AppearanceHeader.Options.UseFont = True
        Me.GV1_DOC_CNT.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_DOC_CNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_DOC_CNT.Caption = "Document"
        Me.GV1_DOC_CNT.FieldName = "DOC_CNT"
        Me.GV1_DOC_CNT.Name = "GV1_DOC_CNT"
        Me.GV1_DOC_CNT.OptionsColumn.AllowEdit = False
        Me.GV1_DOC_CNT.OptionsColumn.ReadOnly = True
        Me.GV1_DOC_CNT.Visible = True
        Me.GV1_DOC_CNT.VisibleIndex = 8
        Me.GV1_DOC_CNT.Width = 20
        Me.Localizer1.SetWordID(Me.GV1_DOC_CNT, "")
        '
        'GV1_REQ_USR
        '
        Me.GV1_REQ_USR.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_REQ_USR.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_USR.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_USR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_USR.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_USR.AppearanceHeader.Options.UseFont = True
        Me.GV1_REQ_USR.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_USR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_USR.Caption = "요청자"
        Me.GV1_REQ_USR.FieldName = "REQ_USR"
        Me.GV1_REQ_USR.Name = "GV1_REQ_USR"
        Me.GV1_REQ_USR.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_USR.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_USR.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_REQ_USR.Visible = True
        Me.GV1_REQ_USR.VisibleIndex = 9
        Me.GV1_REQ_USR.Width = 55
        Me.Localizer1.SetWordID(Me.GV1_REQ_USR, "")
        '
        'GV1_TEL_NO
        '
        Me.GV1_TEL_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_TEL_NO.AppearanceCell.Options.UseFont = True
        Me.GV1_TEL_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_TEL_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TEL_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_TEL_NO.AppearanceHeader.Options.UseFont = True
        Me.GV1_TEL_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_TEL_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_TEL_NO.Caption = "연락처"
        Me.GV1_TEL_NO.FieldName = "TEL_NO"
        Me.GV1_TEL_NO.Name = "GV1_TEL_NO"
        Me.GV1_TEL_NO.OptionsColumn.AllowEdit = False
        Me.GV1_TEL_NO.OptionsColumn.ReadOnly = True
        Me.GV1_TEL_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_TEL_NO.Visible = True
        Me.GV1_TEL_NO.VisibleIndex = 10
        Me.GV1_TEL_NO.Width = 96
        Me.Localizer1.SetWordID(Me.GV1_TEL_NO, "")
        '
        'GV1_REQ_SVC
        '
        Me.GV1_REQ_SVC.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_REQ_SVC.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_SVC.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_SVC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_SVC.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_SVC.AppearanceHeader.Options.UseFont = True
        Me.GV1_REQ_SVC.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_REQ_SVC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_SVC.Caption = "업무구분1"
        Me.GV1_REQ_SVC.FieldName = "REQ_SVC"
        Me.GV1_REQ_SVC.Name = "GV1_REQ_SVC"
        Me.GV1_REQ_SVC.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_SVC.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_SVC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_REQ_SVC.Visible = True
        Me.GV1_REQ_SVC.VisibleIndex = 11
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC, "")
        '
        'GV1_REQ_SVC2
        '
        Me.GV1_REQ_SVC2.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_REQ_SVC2.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_SVC2.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_SVC2.AppearanceHeader.Options.UseFont = True
        Me.GV1_REQ_SVC2.Caption = "업무구분2"
        Me.GV1_REQ_SVC2.FieldName = "REQ_SVC2"
        Me.GV1_REQ_SVC2.Name = "GV1_REQ_SVC2"
        Me.GV1_REQ_SVC2.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_SVC2.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_SVC2.Visible = True
        Me.GV1_REQ_SVC2.VisibleIndex = 12
        Me.Localizer1.SetWordID(Me.GV1_REQ_SVC2, "")
        '
        'GV1_REQ_TYPE2
        '
        Me.GV1_REQ_TYPE2.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_REQ_TYPE2.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_TYPE2.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_TYPE2.AppearanceHeader.Options.UseFont = True
        Me.GV1_REQ_TYPE2.Caption = "업무구분3"
        Me.GV1_REQ_TYPE2.FieldName = "REQ_TYPE2"
        Me.GV1_REQ_TYPE2.Name = "GV1_REQ_TYPE2"
        Me.GV1_REQ_TYPE2.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_TYPE2.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_REQ_TYPE2, "")
        '
        'GV1_SHARE_DEPT
        '
        Me.GV1_SHARE_DEPT.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_SHARE_DEPT.AppearanceCell.Options.UseFont = True
        Me.GV1_SHARE_DEPT.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_SHARE_DEPT.AppearanceHeader.Options.UseFont = True
        Me.GV1_SHARE_DEPT.Caption = "공유부서"
        Me.GV1_SHARE_DEPT.FieldName = "SHARE_DEPT"
        Me.GV1_SHARE_DEPT.Name = "GV1_SHARE_DEPT"
        Me.GV1_SHARE_DEPT.OptionsColumn.AllowEdit = False
        Me.GV1_SHARE_DEPT.OptionsColumn.ReadOnly = True
        Me.GV1_SHARE_DEPT.Visible = True
        Me.GV1_SHARE_DEPT.VisibleIndex = 13
        Me.GV1_SHARE_DEPT.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_SHARE_DEPT, "")
        '
        'GV1_PRIORITY
        '
        Me.GV1_PRIORITY.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_PRIORITY.AppearanceCell.Options.UseFont = True
        Me.GV1_PRIORITY.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PRIORITY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRIORITY.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PRIORITY.AppearanceHeader.Options.UseFont = True
        Me.GV1_PRIORITY.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PRIORITY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRIORITY.Caption = "우선순위"
        Me.GV1_PRIORITY.FieldName = "PRIORITY"
        Me.GV1_PRIORITY.Name = "GV1_PRIORITY"
        Me.GV1_PRIORITY.OptionsColumn.AllowEdit = False
        Me.GV1_PRIORITY.OptionsColumn.ReadOnly = True
        Me.GV1_PRIORITY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PRIORITY.Width = 59
        Me.Localizer1.SetWordID(Me.GV1_PRIORITY, "")
        '
        'GV1_PRAR_YMD
        '
        Me.GV1_PRAR_YMD.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_PRAR_YMD.AppearanceCell.Options.UseFont = True
        Me.GV1_PRAR_YMD.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_PRAR_YMD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRAR_YMD.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_PRAR_YMD.AppearanceHeader.Options.UseFont = True
        Me.GV1_PRAR_YMD.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_PRAR_YMD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_PRAR_YMD.Caption = "예정일자"
        Me.GV1_PRAR_YMD.FieldName = "PRAR_YMD"
        Me.GV1_PRAR_YMD.Name = "GV1_PRAR_YMD"
        Me.GV1_PRAR_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_PRAR_YMD.OptionsColumn.ReadOnly = True
        Me.GV1_PRAR_YMD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_PRAR_YMD.Width = 73
        Me.Localizer1.SetWordID(Me.GV1_PRAR_YMD, "")
        '
        'GV1_REQ_TYPE
        '
        Me.GV1_REQ_TYPE.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_REQ_TYPE.AppearanceCell.Options.UseFont = True
        Me.GV1_REQ_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_REQ_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_REQ_TYPE.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_REQ_TYPE.AppearanceHeader.Options.UseFont = True
        Me.GV1_REQ_TYPE.Caption = "요청상태"
        Me.GV1_REQ_TYPE.FieldName = "REQ_TYPE"
        Me.GV1_REQ_TYPE.Name = "GV1_REQ_TYPE"
        Me.GV1_REQ_TYPE.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_TYPE.OptionsColumn.ReadOnly = True
        Me.GV1_REQ_TYPE.Width = 77
        Me.Localizer1.SetWordID(Me.GV1_REQ_TYPE, "")
        '
        'GV1_CMPT_RMK
        '
        Me.GV1_CMPT_RMK.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_CMPT_RMK.AppearanceCell.Options.UseFont = True
        Me.GV1_CMPT_RMK.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_CMPT_RMK.AppearanceHeader.Options.UseFont = True
        Me.GV1_CMPT_RMK.Caption = "답변"
        Me.GV1_CMPT_RMK.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GV1_CMPT_RMK.FieldName = "CMPT_RMK"
        Me.GV1_CMPT_RMK.Name = "GV1_CMPT_RMK"
        Me.GV1_CMPT_RMK.OptionsColumn.AllowEdit = False
        Me.GV1_CMPT_RMK.OptionsColumn.ReadOnly = True
        Me.GV1_CMPT_RMK.Width = 78
        Me.Localizer1.SetWordID(Me.GV1_CMPT_RMK, "")
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GV1_INS_DATE
        '
        Me.GV1_INS_DATE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_INS_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_DATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_INS_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_INS_DATE.Caption = "등록날짜"
        Me.GV1_INS_DATE.FieldName = "INS_DATE"
        Me.GV1_INS_DATE.Name = "GV1_INS_DATE"
        Me.GV1_INS_DATE.OptionsColumn.AllowEdit = False
        Me.GV1_INS_DATE.OptionsColumn.ReadOnly = True
        Me.GV1_INS_DATE.Width = 110
        Me.Localizer1.SetWordID(Me.GV1_INS_DATE, "")
        '
        'GV1_FREE_YN
        '
        Me.GV1_FREE_YN.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_FREE_YN.AppearanceCell.Options.UseFont = True
        Me.GV1_FREE_YN.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_FREE_YN.AppearanceHeader.Options.UseFont = True
        Me.GV1_FREE_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_FREE_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_FREE_YN.Caption = "유상/무상"
        Me.GV1_FREE_YN.FieldName = "FREE_YN"
        Me.GV1_FREE_YN.Name = "GV1_FREE_YN"
        Me.GV1_FREE_YN.OptionsColumn.AllowEdit = False
        Me.GV1_FREE_YN.OptionsColumn.ReadOnly = True
        Me.GV1_FREE_YN.Width = 63
        Me.Localizer1.SetWordID(Me.GV1_FREE_YN, "")
        '
        'GV1_SYS_ID
        '
        Me.GV1_SYS_ID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_SYS_ID.AppearanceCell.Options.UseFont = True
        Me.GV1_SYS_ID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_SYS_ID.AppearanceHeader.Options.UseFont = True
        Me.GV1_SYS_ID.Caption = "System ID"
        Me.GV1_SYS_ID.FieldName = "SYS_ID"
        Me.GV1_SYS_ID.Name = "GV1_SYS_ID"
        Me.GV1_SYS_ID.OptionsColumn.AllowEdit = False
        Me.GV1_SYS_ID.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_SYS_ID, "")
        '
        'GV1_SYS_NM
        '
        Me.GV1_SYS_NM.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_SYS_NM.AppearanceCell.Options.UseFont = True
        Me.GV1_SYS_NM.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SYS_NM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SYS_NM.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_SYS_NM.AppearanceHeader.Options.UseFont = True
        Me.GV1_SYS_NM.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SYS_NM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SYS_NM.Caption = "접수"
        Me.GV1_SYS_NM.FieldName = "SYS_NM"
        Me.GV1_SYS_NM.Name = "GV1_SYS_NM"
        Me.GV1_SYS_NM.OptionsColumn.AllowEdit = False
        Me.GV1_SYS_NM.OptionsColumn.ReadOnly = True
        Me.GV1_SYS_NM.Width = 47
        Me.Localizer1.SetWordID(Me.GV1_SYS_NM, "")
        '
        'GV1_CMPT_DATE
        '
        Me.GV1_CMPT_DATE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_CMPT_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CMPT_DATE.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_CMPT_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_CMPT_DATE.Caption = "완료날짜"
        Me.GV1_CMPT_DATE.FieldName = "CMPT_DATE"
        Me.GV1_CMPT_DATE.Name = "GV1_CMPT_DATE"
        Me.GV1_CMPT_DATE.OptionsColumn.AllowEdit = False
        Me.GV1_CMPT_DATE.OptionsColumn.ReadOnly = True
        Me.GV1_CMPT_DATE.Visible = True
        Me.GV1_CMPT_DATE.VisibleIndex = 14
        Me.GV1_CMPT_DATE.Width = 110
        Me.Localizer1.SetWordID(Me.GV1_CMPT_DATE, "완료날짜")
        '
        'GV1_MNGT_NO
        '
        Me.GV1_MNGT_NO.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV1_MNGT_NO.AppearanceCell.Options.UseFont = True
        Me.GV1_MNGT_NO.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseFont = True
        Me.GV1_MNGT_NO.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_MNGT_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_MNGT_NO.Caption = "관리번호"
        Me.GV1_MNGT_NO.FieldName = "MNGT_NO"
        Me.GV1_MNGT_NO.Name = "GV1_MNGT_NO"
        Me.GV1_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.GV1_MNGT_NO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GV1_MNGT_NO.Visible = True
        Me.GV1_MNGT_NO.VisibleIndex = 15
        Me.GV1_MNGT_NO.Width = 85
        Me.Localizer1.SetWordID(Me.GV1_MNGT_NO, "")
        '
        'GV1_UPPER_MNGT_NO
        '
        Me.GV1_UPPER_MNGT_NO.Caption = "공유관리번호"
        Me.GV1_UPPER_MNGT_NO.FieldName = "UPPER_MNGT_NO"
        Me.GV1_UPPER_MNGT_NO.Name = "GV1_UPPER_MNGT_NO"
        Me.GV1_UPPER_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_UPPER_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_UPPER_MNGT_NO, "")
        '
        'GV1_ORGN_MNGT_NO
        '
        Me.GV1_ORGN_MNGT_NO.Caption = "원본관리번호"
        Me.GV1_ORGN_MNGT_NO.FieldName = "ORGN_MNGT_NO"
        Me.GV1_ORGN_MNGT_NO.Name = "GV1_ORGN_MNGT_NO"
        Me.GV1_ORGN_MNGT_NO.OptionsColumn.AllowEdit = False
        Me.GV1_ORGN_MNGT_NO.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_ORGN_MNGT_NO, "")
        '
        'GV1_EDU_LV
        '
        Me.GV1_EDU_LV.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_EDU_LV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EDU_LV.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_EDU_LV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EDU_LV.Caption = "교육만족도"
        Me.GV1_EDU_LV.FieldName = "EDU_LV"
        Me.GV1_EDU_LV.Name = "GV1_EDU_LV"
        Me.GV1_EDU_LV.OptionsColumn.AllowEdit = False
        Me.GV1_EDU_LV.OptionsColumn.ReadOnly = True
        Me.GV1_EDU_LV.Width = 45
        Me.Localizer1.SetWordID(Me.GV1_EDU_LV, "")
        '
        'GV1_REQ_YMD
        '
        Me.GV1_REQ_YMD.Caption = "요청일"
        Me.GV1_REQ_YMD.FieldName = "REQ_YMD"
        Me.GV1_REQ_YMD.Name = "GV1_REQ_YMD"
        Me.GV1_REQ_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_YMD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_REQ_YMD, "")
        '
        'GV1_REQ_HM
        '
        Me.GV1_REQ_HM.Caption = "요청시간"
        Me.GV1_REQ_HM.FieldName = "REQ_HM"
        Me.GV1_REQ_HM.Name = "GV1_REQ_HM"
        Me.GV1_REQ_HM.OptionsColumn.AllowEdit = False
        Me.GV1_REQ_HM.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_REQ_HM, "")
        '
        'GV1_CMPT_YMD
        '
        Me.GV1_CMPT_YMD.Caption = "완료일"
        Me.GV1_CMPT_YMD.FieldName = "CMPT_YMD"
        Me.GV1_CMPT_YMD.Name = "GV1_CMPT_YMD"
        Me.GV1_CMPT_YMD.OptionsColumn.AllowEdit = False
        Me.GV1_CMPT_YMD.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_CMPT_YMD, "")
        '
        'GV1_CMPT_HM
        '
        Me.GV1_CMPT_HM.Caption = "완료시간"
        Me.GV1_CMPT_HM.FieldName = "CMPT_HM"
        Me.GV1_CMPT_HM.Name = "GV1_CMPT_HM"
        Me.GV1_CMPT_HM.OptionsColumn.AllowEdit = False
        Me.GV1_CMPT_HM.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_CMPT_HM, "")
        '
        'GV1_DEV_CMPT_YN
        '
        Me.GV1_DEV_CMPT_YN.Caption = "개발팀완료"
        Me.GV1_DEV_CMPT_YN.FieldName = "DEV_CMPT_YN"
        Me.GV1_DEV_CMPT_YN.Name = "GV1_DEV_CMPT_YN"
        Me.GV1_DEV_CMPT_YN.OptionsColumn.AllowEdit = False
        Me.GV1_DEV_CMPT_YN.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_DEV_CMPT_YN, "")
        '
        'GV1_RETURN_YN
        '
        Me.GV1_RETURN_YN.Caption = "요청반려"
        Me.GV1_RETURN_YN.FieldName = "RETURN_YN"
        Me.GV1_RETURN_YN.Name = "GV1_RETURN_YN"
        Me.GV1_RETURN_YN.OptionsColumn.AllowEdit = False
        Me.GV1_RETURN_YN.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_RETURN_YN, "")
        '
        'GV1_RANK
        '
        Me.GV1_RANK.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_RANK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RANK.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_RANK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_RANK.Caption = "난이도"
        Me.GV1_RANK.FieldName = "RANK"
        Me.GV1_RANK.Name = "GV1_RANK"
        Me.GV1_RANK.OptionsColumn.AllowEdit = False
        Me.GV1_RANK.OptionsColumn.ReadOnly = True
        Me.GV1_RANK.Visible = True
        Me.GV1_RANK.VisibleIndex = 16
        Me.GV1_RANK.Width = 45
        Me.Localizer1.SetWordID(Me.GV1_RANK, "")
        '
        'GV1_EX_IM_TYPE
        '
        Me.GV1_EX_IM_TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_EX_IM_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_EX_IM_TYPE.Caption = "내근/외근"
        Me.GV1_EX_IM_TYPE.FieldName = "EX_IM_TYPE"
        Me.GV1_EX_IM_TYPE.Name = "GV1_EX_IM_TYPE"
        Me.GV1_EX_IM_TYPE.OptionsColumn.AllowEdit = False
        Me.GV1_EX_IM_TYPE.OptionsColumn.ReadOnly = True
        Me.GV1_EX_IM_TYPE.Visible = True
        Me.GV1_EX_IM_TYPE.VisibleIndex = 17
        Me.GV1_EX_IM_TYPE.Width = 55
        Me.Localizer1.SetWordID(Me.GV1_EX_IM_TYPE, "")
        '
        'GV1_SCORE_UNIT
        '
        Me.GV1_SCORE_UNIT.Caption = "항목점수"
        Me.GV1_SCORE_UNIT.FieldName = "SCORE_UNIT"
        Me.GV1_SCORE_UNIT.Name = "GV1_SCORE_UNIT"
        Me.GV1_SCORE_UNIT.OptionsColumn.AllowEdit = False
        Me.GV1_SCORE_UNIT.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_SCORE_UNIT, "항목점수")
        '
        'GV1_SCORE_RANK
        '
        Me.GV1_SCORE_RANK.Caption = "난이도점수"
        Me.GV1_SCORE_RANK.FieldName = "SCORE_RANK"
        Me.GV1_SCORE_RANK.Name = "GV1_SCORE_RANK"
        Me.GV1_SCORE_RANK.OptionsColumn.AllowEdit = False
        Me.GV1_SCORE_RANK.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_SCORE_RANK, "난이도점수")
        '
        'GV1_SCORE_EXIM
        '
        Me.GV1_SCORE_EXIM.Caption = "내외근점수"
        Me.GV1_SCORE_EXIM.FieldName = "SCORE_EXIM"
        Me.GV1_SCORE_EXIM.Name = "GV1_SCORE_EXIM"
        Me.GV1_SCORE_EXIM.OptionsColumn.AllowEdit = False
        Me.GV1_SCORE_EXIM.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_SCORE_EXIM, "내외근점수")
        '
        'GV1_SCORE_TOT
        '
        Me.GV1_SCORE_TOT.Caption = "평가점수"
        Me.GV1_SCORE_TOT.FieldName = "SCORE_TOT"
        Me.GV1_SCORE_TOT.Name = "GV1_SCORE_TOT"
        Me.GV1_SCORE_TOT.OptionsColumn.AllowEdit = False
        Me.GV1_SCORE_TOT.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV1_SCORE_TOT, "평가점수")
        '
        'GV1_CUST_DEPT_NM
        '
        Me.GV1_CUST_DEPT_NM.Caption = "요청자부서"
        Me.GV1_CUST_DEPT_NM.FieldName = "CUST_DEPT_NM"
        Me.GV1_CUST_DEPT_NM.Name = "GV1_CUST_DEPT_NM"
        Me.GV1_CUST_DEPT_NM.OptionsColumn.AllowEdit = False
        Me.GV1_CUST_DEPT_NM.OptionsColumn.ReadOnly = True
        Me.GV1_CUST_DEPT_NM.Visible = True
        Me.GV1_CUST_DEPT_NM.VisibleIndex = 19
        Me.Localizer1.SetWordID(Me.GV1_CUST_DEPT_NM, "요청자부서")
        '
        'GV1_PROJECT_CD
        '
        Me.GV1_PROJECT_CD.Caption = "프로젝트"
        Me.GV1_PROJECT_CD.FieldName = "PROJECT_CD"
        Me.GV1_PROJECT_CD.Name = "GV1_PROJECT_CD"
        Me.GV1_PROJECT_CD.OptionsColumn.AllowEdit = False
        Me.GV1_PROJECT_CD.OptionsColumn.ReadOnly = True
        Me.GV1_PROJECT_CD.Visible = True
        Me.GV1_PROJECT_CD.VisibleIndex = 18
        Me.Localizer1.SetWordID(Me.GV1_PROJECT_CD, "프로젝트")
        '
        'GV1_PREV_WEEK
        '
        Me.GV1_PREV_WEEK.Caption = "주차"
        Me.GV1_PREV_WEEK.FieldName = "PREV_WEEK"
        Me.GV1_PREV_WEEK.Name = "GV1_PREV_WEEK"
        Me.GV1_PREV_WEEK.OptionsColumn.AllowEdit = False
        Me.GV1_PREV_WEEK.OptionsColumn.ReadOnly = True
        Me.GV1_PREV_WEEK.Visible = True
        Me.GV1_PREV_WEEK.VisibleIndex = 20
        Me.Localizer1.SetWordID(Me.GV1_PREV_WEEK, "주차")
        '
        'GV1_SELF_PROC_YN
        '
        Me.GV1_SELF_PROC_YN.AppearanceCell.Options.UseTextOptions = True
        Me.GV1_SELF_PROC_YN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SELF_PROC_YN.AppearanceHeader.Options.UseTextOptions = True
        Me.GV1_SELF_PROC_YN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GV1_SELF_PROC_YN.Caption = "자체처리 여부"
        Me.GV1_SELF_PROC_YN.FieldName = "SELF_PROC_YN"
        Me.GV1_SELF_PROC_YN.Name = "GV1_SELF_PROC_YN"
        Me.GV1_SELF_PROC_YN.OptionsColumn.AllowEdit = False
        Me.GV1_SELF_PROC_YN.OptionsColumn.ReadOnly = True
        Me.GV1_SELF_PROC_YN.Visible = True
        Me.GV1_SELF_PROC_YN.VisibleIndex = 21
        Me.GV1_SELF_PROC_YN.Width = 90
        Me.Localizer1.SetWordID(Me.GV1_SELF_PROC_YN, "자체처리 여부")
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
        'xtcMain
        '
        Me.xtcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xtcMain.Location = New System.Drawing.Point(5, 133)
        Me.xtcMain.Name = "xtcMain"
        Me.xtcMain.SelectedTabPage = Me.xtpDetail
        Me.xtcMain.Size = New System.Drawing.Size(1306, 586)
        Me.xtcMain.TabIndex = 303
        Me.xtcMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpDetail, Me.xtpSummary})
        Me.Localizer1.SetWordID(Me.xtcMain, "")
        '
        'xtpDetail
        '
        Me.xtpDetail.Appearance.Header.Options.UseTextOptions = True
        Me.xtpDetail.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpDetail.Controls.Add(Me.WG1)
        Me.xtpDetail.Name = "xtpDetail"
        Me.xtpDetail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtpDetail.Size = New System.Drawing.Size(1300, 557)
        Me.xtpDetail.TabPageWidth = 70
        Me.xtpDetail.Text = "상세"
        Me.Localizer1.SetWordID(Me.xtpDetail, "상세")
        '
        'xtpSummary
        '
        Me.xtpSummary.Appearance.Header.Options.UseTextOptions = True
        Me.xtpSummary.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xtpSummary.Controls.Add(Me.splitMain)
        Me.xtpSummary.Controls.Add(Me.panelSummary)
        Me.xtpSummary.Name = "xtpSummary"
        Me.xtpSummary.Size = New System.Drawing.Size(1300, 557)
        Me.xtpSummary.TabPageWidth = 70
        Me.xtpSummary.Text = "합계"
        Me.Localizer1.SetWordID(Me.xtpSummary, "합계")
        '
        'splitMain
        '
        Me.splitMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitMain.Location = New System.Drawing.Point(3, 38)
        Me.splitMain.Name = "splitMain"
        Me.splitMain.Panel1.Controls.Add(Me.PGC1)
        Me.splitMain.Panel1.Text = "Panel1"
        Me.splitMain.Panel2.Controls.Add(Me.WG2)
        Me.splitMain.Panel2.Text = "Panel2"
        Me.splitMain.Size = New System.Drawing.Size(1294, 516)
        Me.splitMain.SplitterPosition = 867
        Me.splitMain.TabIndex = 1
        Me.splitMain.Text = "SplitContainerControl1"
        Me.Localizer1.SetWordID(Me.splitMain, "")
        '
        'PGC1
        '
        Me.PGC1.Appearance.ColumnHeaderArea.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PGC1.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.PGC1.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PGC1.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.PGC1.Appearance.HeaderArea.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PGC1.Appearance.HeaderArea.Options.UseFont = True
        Me.PGC1.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PGC1.Appearance.TotalCell.Options.UseBackColor = True
        Me.PGC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PGC1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PGV_REQ_COUNT, Me.PGV_SCORE_UNIT, Me.PGV_SCORE_RANK, Me.PGV_SCORE_EXIM, Me.PGV_SCORE_TOT, Me.PGV_REQ_SVC_NM, Me.PGV_REQ_SVC2_NM, Me.PGV_REQ_TYPE2_NM, Me.PGV_DEPT_NM, Me.PGV_WORK_USR_NM, Me.PGV_EX_IM_TYPE_NM})
        Me.PGC1.Location = New System.Drawing.Point(0, 0)
        Me.PGC1.Name = "PGC1"
        Me.PGC1.OptionsCustomization.AllowDrag = False
        Me.PGC1.OptionsCustomization.AllowDragInCustomizationForm = False
        Me.PGC1.OptionsCustomization.AllowFilter = False
        Me.PGC1.OptionsPrint.MergeRowFieldValues = False
        Me.PGC1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PGC1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PGC1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PGC1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PGC1.OptionsPrint.PrintUnusedFilterFields = False
        Me.PGC1.OptionsSelection.CellSelection = False
        Me.PGC1.OptionsSelection.MultiSelect = False
        Me.PGC1.OptionsView.ShowColumnHeaders = False
        Me.PGC1.OptionsView.ShowDataHeaders = False
        Me.PGC1.OptionsView.ShowFilterHeaders = False
        Me.PGC1.OptionsView.ShowFilterSeparatorBar = False
        Me.PGC1.OptionsView.ShowRowGrandTotalHeader = False
        Me.PGC1.OptionsView.ShowRowGrandTotals = False
        Me.PGC1.Size = New System.Drawing.Size(867, 516)
        Me.PGC1.TabIndex = 166
        Me.Localizer1.SetWordID(Me.PGC1, "")
        '
        'PGV_REQ_COUNT
        '
        Me.PGV_REQ_COUNT.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PGV_REQ_COUNT.Appearance.Header.Options.UseFont = True
        Me.PGV_REQ_COUNT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGV_REQ_COUNT.AreaIndex = 0
        Me.PGV_REQ_COUNT.Caption = "건수"
        Me.PGV_REQ_COUNT.CellFormat.FormatString = "{0:N0}"
        Me.PGV_REQ_COUNT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGV_REQ_COUNT.FieldName = "REQ_COUNT"
        Me.PGV_REQ_COUNT.Name = "PGV_REQ_COUNT"
        Me.PGV_REQ_COUNT.Width = 50
        '
        'PGV_SCORE_UNIT
        '
        Me.PGV_SCORE_UNIT.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PGV_SCORE_UNIT.Appearance.Header.Options.UseFont = True
        Me.PGV_SCORE_UNIT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGV_SCORE_UNIT.AreaIndex = 1
        Me.PGV_SCORE_UNIT.Caption = "항목"
        Me.PGV_SCORE_UNIT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGV_SCORE_UNIT.FieldName = "SCORE_UNIT"
        Me.PGV_SCORE_UNIT.Name = "PGV_SCORE_UNIT"
        Me.PGV_SCORE_UNIT.Visible = False
        Me.PGV_SCORE_UNIT.Width = 50
        '
        'PGV_SCORE_RANK
        '
        Me.PGV_SCORE_RANK.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGV_SCORE_RANK.AreaIndex = 1
        Me.PGV_SCORE_RANK.Caption = "난이도"
        Me.PGV_SCORE_RANK.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGV_SCORE_RANK.FieldName = "SCORE_RANK"
        Me.PGV_SCORE_RANK.Name = "PGV_SCORE_RANK"
        Me.PGV_SCORE_RANK.Visible = False
        Me.PGV_SCORE_RANK.Width = 50
        '
        'PGV_SCORE_EXIM
        '
        Me.PGV_SCORE_EXIM.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGV_SCORE_EXIM.AreaIndex = 1
        Me.PGV_SCORE_EXIM.Caption = "내외부"
        Me.PGV_SCORE_EXIM.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGV_SCORE_EXIM.FieldName = "SCORE_EXIM"
        Me.PGV_SCORE_EXIM.Name = "PGV_SCORE_EXIM"
        Me.PGV_SCORE_EXIM.Visible = False
        Me.PGV_SCORE_EXIM.Width = 50
        '
        'PGV_SCORE_TOT
        '
        Me.PGV_SCORE_TOT.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PGV_SCORE_TOT.Appearance.Header.Options.UseFont = True
        Me.PGV_SCORE_TOT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PGV_SCORE_TOT.AreaIndex = 1
        Me.PGV_SCORE_TOT.Caption = "평가"
        Me.PGV_SCORE_TOT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PGV_SCORE_TOT.FieldName = "SCORE_TOT"
        Me.PGV_SCORE_TOT.Name = "PGV_SCORE_TOT"
        Me.PGV_SCORE_TOT.Visible = False
        Me.PGV_SCORE_TOT.Width = 50
        '
        'PGV_REQ_SVC_NM
        '
        Me.PGV_REQ_SVC_NM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGV_REQ_SVC_NM.AreaIndex = 0
        Me.PGV_REQ_SVC_NM.Caption = "업무구분1"
        Me.PGV_REQ_SVC_NM.FieldName = "REQ_SVC_NM"
        Me.PGV_REQ_SVC_NM.Name = "PGV_REQ_SVC_NM"
        '
        'PGV_REQ_SVC2_NM
        '
        Me.PGV_REQ_SVC2_NM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGV_REQ_SVC2_NM.AreaIndex = 1
        Me.PGV_REQ_SVC2_NM.Caption = "업무구분2"
        Me.PGV_REQ_SVC2_NM.FieldName = "REQ_SVC2_NM"
        Me.PGV_REQ_SVC2_NM.Name = "PGV_REQ_SVC2_NM"
        '
        'PGV_REQ_TYPE2_NM
        '
        Me.PGV_REQ_TYPE2_NM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGV_REQ_TYPE2_NM.AreaIndex = 2
        Me.PGV_REQ_TYPE2_NM.Caption = "업무구분3"
        Me.PGV_REQ_TYPE2_NM.FieldName = "REQ_TYPE2_NM"
        Me.PGV_REQ_TYPE2_NM.Name = "PGV_REQ_TYPE2_NM"
        '
        'PGV_DEPT_NM
        '
        Me.PGV_DEPT_NM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGV_DEPT_NM.AreaIndex = 3
        Me.PGV_DEPT_NM.Caption = "작업부서"
        Me.PGV_DEPT_NM.FieldName = "DEPT_NM"
        Me.PGV_DEPT_NM.Name = "PGV_DEPT_NM"
        '
        'PGV_WORK_USR_NM
        '
        Me.PGV_WORK_USR_NM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGV_WORK_USR_NM.AreaIndex = 4
        Me.PGV_WORK_USR_NM.Caption = "작업자"
        Me.PGV_WORK_USR_NM.FieldName = "WORK_USR_NM"
        Me.PGV_WORK_USR_NM.Name = "PGV_WORK_USR_NM"
        '
        'PGV_EX_IM_TYPE_NM
        '
        Me.PGV_EX_IM_TYPE_NM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PGV_EX_IM_TYPE_NM.AreaIndex = 5
        Me.PGV_EX_IM_TYPE_NM.Caption = "내근/외근"
        Me.PGV_EX_IM_TYPE_NM.FieldName = "EX_IM_TYPE_NM"
        Me.PGV_EX_IM_TYPE_NM.Name = "PGV_EX_IM_TYPE_NM"
        '
        'WG2
        '
        Me.WG2.AllowClientBinding = True
        Me.WG2.DeleteRowConfirmation = True
        Me.WG2.DisplayCurrentRow = False
        Me.WG2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG2.IsDataStateAware = True
        Me.WG2.Location = New System.Drawing.Point(0, 0)
        Me.WG2.MainView = Me.GV2
        Me.WG2.Name = "WG2"
        Me.WG2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2, Me.RepositoryItemMemoEdit2, Me.RepositoryItemMemoExEdit2})
        Me.WG2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG2.SaveLayout = True
        Me.WG2.Size = New System.Drawing.Size(422, 516)
        Me.WG2.TabIndex = 303
        Me.WG2.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV2})
        '
        'GV2
        '
        Me.GV2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn12, Me.GridColumn13, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38})
        Me.GV2.GridControl = Me.WG2
        Me.GV2.Name = "GV2"
        Me.GV2.OptionsBehavior.Editable = False
        Me.GV2.OptionsBehavior.ReadOnly = True
        Me.GV2.OptionsCustomization.AllowRowSizing = True
        Me.GV2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV2.OptionsView.BestFitMaxRowCount = 10
        Me.GV2.OptionsView.ColumnAutoWidth = False
        Me.GV2.OptionsView.EnableAppearanceEvenRow = True
        Me.GV2.RowHeight = 10
        Me.GV2.ViewCaption = " 고객 리스트"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "등록자"
        Me.GridColumn1.FieldName = "INS_USR"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Width = 55
        Me.Localizer1.SetWordID(Me.GridColumn1, "")
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "작업자"
        Me.GridColumn2.FieldName = "WORK_USR"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Width = 55
        Me.Localizer1.SetWordID(Me.GridColumn2, "")
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "코드"
        Me.GridColumn3.FieldName = "CUST_CD"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Width = 57
        Me.Localizer1.SetWordID(Me.GridColumn3, "")
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn12.AppearanceCell.Options.UseFont = True
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "업무구분1"
        Me.GridColumn12.FieldName = "REQ_SVC"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 0
        Me.GridColumn12.Width = 65
        Me.Localizer1.SetWordID(Me.GridColumn12, "")
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceCell.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.Caption = "업무구분2"
        Me.GridColumn13.FieldName = "REQ_SVC2"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        Me.GridColumn13.Width = 65
        Me.Localizer1.SetWordID(Me.GridColumn13, "")
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceCell.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "거래처 명"
        Me.GridColumn4.FieldName = "CUST_NM"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 150
        Me.Localizer1.SetWordID(Me.GridColumn4, "")
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "요청날짜"
        Me.GridColumn5.FieldName = "REQ_DATE"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Width = 110
        Me.Localizer1.SetWordID(Me.GridColumn5, "")
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn6.AppearanceCell.Options.UseFont = True
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "상태"
        Me.GridColumn6.FieldName = "PROC_TYPE"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 61
        Me.Localizer1.SetWordID(Me.GridColumn6, "")
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "고객요청사항"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.GridColumn7.FieldName = "CONTENT"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 370
        Me.Localizer1.SetWordID(Me.GridColumn7, "")
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn8.AppearanceCell.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "조치사항"
        Me.GridColumn8.FieldName = "RMK"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 315
        Me.Localizer1.SetWordID(Me.GridColumn8, "")
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn9.AppearanceCell.Options.UseFont = True
        Me.GridColumn9.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn9.AppearanceHeader.Options.UseFont = True
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Document"
        Me.GridColumn9.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.GridColumn9.FieldName = "FILE_YN"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 20
        Me.Localizer1.SetWordID(Me.GridColumn9, "")
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
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn10.AppearanceCell.Options.UseFont = True
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "요청자"
        Me.GridColumn10.FieldName = "REQ_USR"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn10.Width = 55
        Me.Localizer1.SetWordID(Me.GridColumn10, "")
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceCell.Options.UseFont = True
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "연락처"
        Me.GridColumn11.FieldName = "TEL_NO"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn11.Width = 96
        Me.Localizer1.SetWordID(Me.GridColumn11, "")
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn14.AppearanceCell.Options.UseFont = True
        Me.GridColumn14.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn14.AppearanceHeader.Options.UseFont = True
        Me.GridColumn14.Caption = "업무구분3"
        Me.GridColumn14.FieldName = "REQ_TYPE2"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn14, "")
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn15.AppearanceCell.Options.UseFont = True
        Me.GridColumn15.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn15.AppearanceHeader.Options.UseFont = True
        Me.GridColumn15.Caption = "공유부서"
        Me.GridColumn15.FieldName = "SHARE_DEPT"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Width = 90
        Me.Localizer1.SetWordID(Me.GridColumn15, "")
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn16.AppearanceCell.Options.UseFont = True
        Me.GridColumn16.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn16.AppearanceHeader.Options.UseFont = True
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "우선순위"
        Me.GridColumn16.FieldName = "PRIORITY"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn16.Width = 59
        Me.Localizer1.SetWordID(Me.GridColumn16, "")
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn17.AppearanceCell.Options.UseFont = True
        Me.GridColumn17.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn17.AppearanceHeader.Options.UseFont = True
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "예정일자"
        Me.GridColumn17.FieldName = "PRAR_YMD"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn17.Width = 73
        Me.Localizer1.SetWordID(Me.GridColumn17, "")
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn18.AppearanceCell.Options.UseFont = True
        Me.GridColumn18.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn18.AppearanceHeader.Options.UseFont = True
        Me.GridColumn18.Caption = "요청상태"
        Me.GridColumn18.FieldName = "REQ_TYPE"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Width = 77
        Me.Localizer1.SetWordID(Me.GridColumn18, "")
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn19.AppearanceCell.Options.UseFont = True
        Me.GridColumn19.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn19.AppearanceHeader.Options.UseFont = True
        Me.GridColumn19.Caption = "답변"
        Me.GridColumn19.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.GridColumn19.FieldName = "CMPT_RMK"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.Width = 78
        Me.Localizer1.SetWordID(Me.GridColumn19, "")
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn20.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn20.Caption = "등록날짜"
        Me.GridColumn20.FieldName = "INS_DATE"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.OptionsColumn.ReadOnly = True
        Me.GridColumn20.Width = 110
        Me.Localizer1.SetWordID(Me.GridColumn20, "")
        '
        'GridColumn21
        '
        Me.GridColumn21.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn21.AppearanceCell.Options.UseFont = True
        Me.GridColumn21.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn21.AppearanceHeader.Options.UseFont = True
        Me.GridColumn21.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn21.Caption = "유상/무상"
        Me.GridColumn21.FieldName = "FREE_YN"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        Me.GridColumn21.Width = 63
        Me.Localizer1.SetWordID(Me.GridColumn21, "")
        '
        'GridColumn22
        '
        Me.GridColumn22.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn22.AppearanceCell.Options.UseFont = True
        Me.GridColumn22.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn22.AppearanceHeader.Options.UseFont = True
        Me.GridColumn22.Caption = "System ID"
        Me.GridColumn22.FieldName = "SYS_ID"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn22, "")
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn23.AppearanceCell.Options.UseFont = True
        Me.GridColumn23.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn23.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn23.AppearanceHeader.Options.UseFont = True
        Me.GridColumn23.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn23.Caption = "접수"
        Me.GridColumn23.FieldName = "SYS_NM"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.OptionsColumn.ReadOnly = True
        Me.GridColumn23.Width = 47
        Me.Localizer1.SetWordID(Me.GridColumn23, "")
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "완료날짜"
        Me.GridColumn24.FieldName = "CMPT_DATE"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.OptionsColumn.ReadOnly = True
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 7
        Me.GridColumn24.Width = 110
        Me.Localizer1.SetWordID(Me.GridColumn24, "완료날짜")
        '
        'GridColumn25
        '
        Me.GridColumn25.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn25.AppearanceCell.Options.UseFont = True
        Me.GridColumn25.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn25.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GridColumn25.AppearanceHeader.Options.UseFont = True
        Me.GridColumn25.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn25.Caption = "관리번호"
        Me.GridColumn25.FieldName = "MNGT_NO"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.OptionsColumn.ReadOnly = True
        Me.GridColumn25.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn25.Width = 85
        Me.Localizer1.SetWordID(Me.GridColumn25, "")
        '
        'GridColumn26
        '
        Me.GridColumn26.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn26.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn26.Caption = "교육만족도"
        Me.GridColumn26.FieldName = "EDU_LV"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        Me.GridColumn26.OptionsColumn.ReadOnly = True
        Me.GridColumn26.Width = 45
        Me.Localizer1.SetWordID(Me.GridColumn26, "")
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "요청일"
        Me.GridColumn27.FieldName = "REQ_YMD"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.AllowEdit = False
        Me.GridColumn27.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn27, "")
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "요청시간"
        Me.GridColumn28.FieldName = "REQ_HM"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.OptionsColumn.AllowEdit = False
        Me.GridColumn28.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn28, "")
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "완료일"
        Me.GridColumn29.FieldName = "CMPT_YMD"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.OptionsColumn.AllowEdit = False
        Me.GridColumn29.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn29, "")
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "완료시간"
        Me.GridColumn30.FieldName = "CMPT_HM"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsColumn.AllowEdit = False
        Me.GridColumn30.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn30, "")
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "개발팀완료"
        Me.GridColumn31.FieldName = "DEV_CMPT_YN"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.AllowEdit = False
        Me.GridColumn31.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn31, "")
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "요청반려"
        Me.GridColumn32.FieldName = "RETURN_YN"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsColumn.AllowEdit = False
        Me.GridColumn32.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn32, "")
        '
        'GridColumn33
        '
        Me.GridColumn33.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn33.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn33.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn33.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn33.Caption = "난이도"
        Me.GridColumn33.FieldName = "RANK"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.AllowEdit = False
        Me.GridColumn33.OptionsColumn.ReadOnly = True
        Me.GridColumn33.Width = 45
        Me.Localizer1.SetWordID(Me.GridColumn33, "")
        '
        'GridColumn34
        '
        Me.GridColumn34.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn34.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn34.Caption = "내외근"
        Me.GridColumn34.FieldName = "EX_IM_TYPE"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.OptionsColumn.AllowEdit = False
        Me.GridColumn34.OptionsColumn.ReadOnly = True
        Me.GridColumn34.Width = 55
        Me.Localizer1.SetWordID(Me.GridColumn34, "")
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "항목점수"
        Me.GridColumn35.FieldName = "SCORE_UNIT"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.OptionsColumn.AllowEdit = False
        Me.GridColumn35.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn35, "항목점수")
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "난이도점수"
        Me.GridColumn36.FieldName = "SCORE_RANK"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.OptionsColumn.AllowEdit = False
        Me.GridColumn36.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn36, "난이도점수")
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "내외근점수"
        Me.GridColumn37.FieldName = "SCORE_EXIM"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.OptionsColumn.AllowEdit = False
        Me.GridColumn37.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GridColumn37, "내외근점수")
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "평가점수"
        Me.GridColumn38.FieldName = "SCORE_TOT"
        Me.GridColumn38.Name = "GridColumn38"
        Me.Localizer1.SetWordID(Me.GridColumn38, "평가점수")
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        Me.RepositoryItemMemoExEdit2.ShowIcon = False
        '
        'panelSummary
        '
        Me.panelSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelSummary.Controls.Add(Me.radioSummary)
        Me.panelSummary.Location = New System.Drawing.Point(3, 3)
        Me.panelSummary.Name = "panelSummary"
        Me.panelSummary.Size = New System.Drawing.Size(1294, 34)
        Me.panelSummary.TabIndex = 279
        Me.Localizer1.SetWordID(Me.panelSummary, "")
        '
        'radioSummary
        '
        Me.radioSummary.BindingPropertyName = "EditValue"
        Me.radioSummary.DefVal = ""
        Me.radioSummary.EditValue = "A"
        Me.radioSummary.IsDataStateAware = True
        Me.radioSummary.Location = New System.Drawing.Point(5, 5)
        Me.radioSummary.Name = "radioSummary"
        Me.radioSummary.NextFocus = ""
        Me.radioSummary.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "작업부서+작업자"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "작업자+업무구분1,2,3"), New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "업무구분1,2,3"), New DevExpress.XtraEditors.Controls.RadioGroupItem("D", "작업자+내근/외근")})
        Me.radioSummary.Size = New System.Drawing.Size(722, 24)
        Me.radioSummary.TabIndex = 0
        Me.Localizer1.SetWordID(Me.radioSummary, "")
        '
        'dlgSaveExcel
        '
        Me.dlgSaveExcel.Filter = "Excel File (*.xls)|*.xls|All Files (*.*)|*.*"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'DocImage
        '
        Me.DocImage.ImageStream = CType(resources.GetObject("DocImage.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.DocImage.Images.SetKeyName(0, "New_gray_16x16.png")
        Me.DocImage.Images.SetKeyName(1, "doc1.png")
        Me.DocImage.Images.SetKeyName(2, "doc2.png")
        '
        'CrmAsList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1318, 722)
        Me.Controls.Add(Me.xtcMain)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CrmAsList"
        Me.Text = "고객지원 작업현황"
        Me.Localizer1.SetWordID(Me, "고객지원 작업현황")
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.S_DEPT_CD_M.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S_PROC_TYPE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.WG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcMain.ResumeLayout(False)
        Me.xtpDetail.ResumeLayout(False)
        Me.xtpSummary.ResumeLayout(False)
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMain.ResumeLayout(False)
        CType(Me.PGC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSummary.ResumeLayout(False)
        CType(Me.radioSummary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents TextBox2 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents TextBox1 As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgSaveExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label32 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents SEARCH_KEY As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents Label21 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDeleteCol As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSaveCol As YJIT.SC.UI.SCControls.Button
    Friend WithEvents btnSearchCol As YJIT.SC.UI.SCControls.Button
    Friend WithEvents LayOutList As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents Label33 As YJIT.SC.UI.SCControls.Label
    Public WithEvents S_REQ_SVC As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents Label7 As YJIT.SC.UI.SCControls.Label
    Public WithEvents S_WORK_USR_NM As YJIT.SC.UI.SCControls.TextLabel
    Public WithEvents S_WORK_USR As YJIT.SC.UI.SCControls.CodeBox
    Public WithEvents S_REQ_SVC2 As YJIT.SC.UI.SCControls.ComboBox
    Public WithEvents WG1 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV1_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUST_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUST_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CONTENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GV1_REQ_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PROC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_WORK_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PRIORITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_SVC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_PRAR_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_SVC2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_INS_USR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_TYPE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CMPT_RMK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DOC_CNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GV1_INS_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_FREE_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SYS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SYS_NM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SHARE_DEPT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents S_DATE_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Public WithEvents S_CUST_NM As YJIT.SC.UI.SCControls.TextLabel
    Public WithEvents S_DEPT_CD As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents S_PROC_TYPE As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Label20 As YJIT.SC.UI.SCControls.Label
    Public WithEvents S_DEPT_AUTH As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents Label23 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents btnCrmAsMst As YJIT.SC.UI.SCControls.Button
    Friend WithEvents GV1_REQ_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CMPT_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_WORK_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents S_DEPT_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GV1_EDU_LV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_REQ_HM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CMPT_YMD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CMPT_HM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_DEV_CMPT_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_RETURN_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtcMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpDetail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpSummary As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PGC1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PGV_REQ_SVC_NM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGV_REQ_COUNT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGV_REQ_TYPE2_NM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents panelSummary As DevExpress.XtraEditors.PanelControl
    Friend WithEvents radioSummary As YJIT.SC.UI.SCControls.RadioGroup
    Friend WithEvents PGV_REQ_SVC2_NM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGV_DEPT_NM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGV_WORK_USR_NM As DevExpress.XtraPivotGrid.PivotGridField
    Public WithEvents S_REQ_TYPE2 As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents lbl_S_EX_IM_TYPE As YJIT.SC.UI.SCControls.Label
    Friend WithEvents S_EX_IM_TYPE As YJIT.SC.UI.SCControls.ComboBox
    Friend WithEvents GV1_EX_IM_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PGV_EX_IM_TYPE_NM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents GV1_RANK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PGV_SCORE_TOT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents GV1_SCORE_UNIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PGV_SCORE_UNIT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents GV1_SCORE_RANK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SCORE_EXIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_SCORE_TOT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PGV_SCORE_EXIM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PGV_SCORE_RANK As DevExpress.XtraPivotGrid.PivotGridField
    Public WithEvents WG2 As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents splitMain As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GV1_UPPER_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_ORGN_MNGT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents S_CUST_CD As YJIT.SC.UI.SCControls.CodeBox
    Public WithEvents S_TO_YMD As YJIT.SC.UI.SCControls.DateBox
    Public WithEvents S_FM_YMD As YJIT.SC.UI.SCControls.DateBox
    Friend WithEvents GV1_PROJECT_CD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_CUST_DEPT_NM As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents S_PROJECT_NM As YJIT.SC.UI.SCControls.TextLabel
    Friend WithEvents S_PROJECT_CD As YJIT.SC.UI.SCControls.CodeBox
    Friend WithEvents Label1 As YJIT.SC.UI.SCControls.Label
    Friend WithEvents GV1_PREV_WEEK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents S_DEPT_CD_M As DevExpress.XtraEditors.CheckedComboBoxEdit
    Private WithEvents DocImage As DevExpress.Utils.ImageCollection
    Friend WithEvents btnNew As UI.SCControls.Button
    Friend WithEvents lbl_S_SELF_PROC_YN As UI.SCControls.Label
    Friend WithEvents S_SELF_PROC_YN As UI.SCControls.ComboBox
    Friend WithEvents GV1_SELF_PROC_YN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV1_TAKE_DATE As DevExpress.XtraGrid.Columns.GridColumn
End Class
