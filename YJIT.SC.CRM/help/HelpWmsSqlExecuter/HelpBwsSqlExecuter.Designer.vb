<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelpBwsSqlExecuter
    Inherits YJIT.SC.UI.SCView

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpBwsSqlExecuter))
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnClear = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.panel = New DevExpress.XtraEditors.PanelControl()
        Me.btnSql = New YJIT.SC.UI.SCControls.Button()
        Me.WG_SQL = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_SQL = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GVS_TITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVS_SQL_STR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.Label13 = New YJIT.SC.UI.SCControls.Label()
        Me.RPNO = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label10 = New YJIT.SC.UI.SCControls.Label()
        Me.WG_ISU = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_ISU = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GVI_GINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_RPNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_GBUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_LICENSE_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_ISSUED_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_QTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GVI_WGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GVI_CBM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GVI_EDI_REMARK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_ISU_SEND_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GINO = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnUpdateIsu = New YJIT.SC.UI.SCControls.Button()
        Me.Label8 = New YJIT.SC.UI.SCControls.Label()
        Me.ISU_SEND_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.Label12 = New YJIT.SC.UI.SCControls.Label()
        Me.DELNO = New YJIT.SC.UI.SCControls.TextBox()
        Me.LableGRNO = New YJIT.SC.UI.SCControls.Label()
        Me.WG_RCP = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_RCP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GVR_GRNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVR_DELNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVR_LICENSE_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVR_QTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_Num0 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GVR_WGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_Num2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GVR_CBM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_NUM3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GVR_EDI_REMARK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVR_RCP_SEND_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVR_GBUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV3_Text11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV3_Text4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV3_Text10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV3_Text2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV3_Text1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GVR_Button = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GRNO = New YJIT.SC.UI.SCControls.TextBox()
        Me.btnUpdateRcp = New YJIT.SC.UI.SCControls.Button()
        Me.Label9 = New YJIT.SC.UI.SCControls.Label()
        Me.RCP_SEND_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.WHNM = New YJIT.SC.UI.SCControls.TextBox()
        Me.WHCD = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label11 = New YJIT.SC.UI.SCControls.Label()
        Me.WG_WH = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_WH = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV_WHNM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_WHCD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCargoList = New YJIT.SC.UI.SCControls.Button()
        Me.MRN = New YJIT.SC.UI.SCControls.MaskedTextBox()
        Me.btnClear2 = New YJIT.SC.UI.SCControls.Button()
        Me.Label6 = New YJIT.SC.UI.SCControls.Label()
        Me.HBLNO = New YJIT.SC.UI.SCControls.TextBox()
        Me.LableHBL = New YJIT.SC.UI.SCControls.Label()
        Me.xtcExecute = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpExecute = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.btnRefresh = New YJIT.SC.UI.SCControls.Button()
        Me.btnExecuteReconnect = New YJIT.SC.UI.SCControls.Button()
        Me.splSqlSettings = New DevExpress.XtraEditors.PanelControl()
        Me.S_EXECUTE = New YJIT.SC.UI.SCControls.TextBox()
        Me.WG_EXECUTE = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_EXECUTE = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.CTRY_CD = New YJIT.SC.UI.SCControls.TextBox()
        Me.DB_SID = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label5 = New YJIT.SC.UI.SCControls.Label()
        Me.DB_PORT = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label4 = New YJIT.SC.UI.SCControls.Label()
        Me.DB_IP = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label3 = New YJIT.SC.UI.SCControls.Label()
        Me.USR_PWD = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label2 = New YJIT.SC.UI.SCControls.Label()
        Me.USR_ID = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label1 = New YJIT.SC.UI.SCControls.Label()
        Me.DOMAIN = New YJIT.SC.UI.SCControls.TextBox()
        Me.LBL_S_SQL_ID = New YJIT.SC.UI.SCControls.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CUST_CD = New YJIT.SC.UI.SCControls.CodeBox()
        Me.Label7 = New YJIT.SC.UI.SCControls.Label()
        Me.CUST_NM = New YJIT.SC.UI.SCControls.TextLabel()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.WG_SQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_SQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.WG_ISU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_ISU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.WG_RCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_RCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3_Num0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3_Num2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3_NUM3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3_Text11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3_Text4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3_Text10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3_Text2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV3_Text1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVR_Button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG_WH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_WH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.xtcExecute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcExecute.SuspendLayout()
        Me.xtpExecute.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.splSqlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG_EXECUTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_EXECUTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        Me.SuspendLayout()
        '
        'palAutoButton
        '
        Me.palAutoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.palAutoButton.Controls.Add(Me.btnClear)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 7)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1252, 35)
        Me.palAutoButton.TabIndex = 4
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(1164, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 28)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.Localizer1.SetWordID(Me.btnClear, "&Clear")
        '
        'btnSearch
        '
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(245, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(104, 22)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = " Sea&rch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Sea&rch")
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnClear, "&Clear")
        Me.Localizer1.SetWordID(Me.btnSearch, "Sea&rch")
        Me.Localizer1.SetWordID(Me.SplitContainerControl3, "SplitContainerControl3")
        Me.Localizer1.SetWordID(Me.panel, "Sql ID")
        Me.Localizer1.SetWordID(Me.btnSql, " Sea&rch")
        Me.Localizer1.SetWordID(Me.WG_SQL, "")
        Me.Localizer1.SetWordID(Me.GVS_TITLE, "TITLE")
        Me.Localizer1.SetWordID(Me.GVS_SQL_STR, "SQL")
        Me.Localizer1.SetWordID(Me.PanelControl1, "Sql ID")
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        Me.Localizer1.SetWordID(Me.Label13, "반출승인번호")
        Me.Localizer1.SetWordID(Me.RPNO, "")
        Me.Localizer1.SetWordID(Me.Label10, "반출번호")
        Me.Localizer1.SetWordID(Me.WG_ISU, "")
        Me.Localizer1.SetWordID(Me.GVI_GINO, "반출번호")
        Me.Localizer1.SetWordID(Me.GVI_RPNO, "반출승인번호")
        Me.Localizer1.SetWordID(Me.GVI_GBUN, "구분")
        Me.Localizer1.SetWordID(Me.GVI_LICENSE_NO, "근거번호")
        Me.Localizer1.SetWordID(Me.GVI_ISSUED_TYPE, "반출구분")
        Me.Localizer1.SetWordID(Me.GVI_QTY, "수량")
        Me.Localizer1.SetWordID(Me.GVI_WGT, "중량")
        Me.Localizer1.SetWordID(Me.GVI_CBM, "용적")
        Me.Localizer1.SetWordID(Me.GVI_EDI_REMARK, "전송결과")
        Me.Localizer1.SetWordID(Me.GVI_ISU_SEND_NO, "신고번호")
        Me.Localizer1.SetWordID(Me.GINO, "")
        Me.Localizer1.SetWordID(Me.btnUpdateIsu, "접수통보 변경")
        Me.Localizer1.SetWordID(Me.Label8, "반출 신고번호")
        Me.Localizer1.SetWordID(Me.ISU_SEND_NO, "")
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        Me.Localizer1.SetWordID(Me.Label12, "반입예정번호")
        Me.Localizer1.SetWordID(Me.DELNO, "")
        Me.Localizer1.SetWordID(Me.LableGRNO, "반입번호")
        Me.Localizer1.SetWordID(Me.WG_RCP, "")
        Me.Localizer1.SetWordID(Me.GVR_GRNO, "반입번호")
        Me.Localizer1.SetWordID(Me.GVR_DELNO, "반입예정번호")
        Me.Localizer1.SetWordID(Me.GVR_LICENSE_NO, "근거번호")
        Me.Localizer1.SetWordID(Me.GVR_QTY, "수량")
        Me.Localizer1.SetWordID(Me.GVR_WGT, "중량")
        Me.Localizer1.SetWordID(Me.GVR_CBM, "용적")
        Me.Localizer1.SetWordID(Me.GVR_EDI_REMARK, "전송결과")
        Me.Localizer1.SetWordID(Me.GVR_RCP_SEND_NO, "신고번호")
        Me.Localizer1.SetWordID(Me.GVR_GBUN, "구분")
        Me.Localizer1.SetWordID(Me.GRNO, "")
        Me.Localizer1.SetWordID(Me.btnUpdateRcp, "접수통보 변경")
        Me.Localizer1.SetWordID(Me.Label9, "반입 신고번호")
        Me.Localizer1.SetWordID(Me.RCP_SEND_NO, "")
        Me.Localizer1.SetWordID(Me.WHNM, "")
        Me.Localizer1.SetWordID(Me.WHCD, "")
        Me.Localizer1.SetWordID(Me.Label11, "창고코드")
        Me.Localizer1.SetWordID(Me.WG_WH, "")
        Me.Localizer1.SetWordID(Me.GV_WHNM, "창고명")
        Me.Localizer1.SetWordID(Me.GV_WHCD, "코드")
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        Me.Localizer1.SetWordID(Me.btnCargoList, "화물 조회")
        Me.Localizer1.SetWordID(Me.MRN, "           -    -")
        Me.Localizer1.SetWordID(Me.btnClear2, "&Clear")
        Me.Localizer1.SetWordID(Me.Label6, "화물관리번호")
        Me.Localizer1.SetWordID(Me.HBLNO, "")
        Me.Localizer1.SetWordID(Me.LableHBL, "HB/L No.")
        Me.Localizer1.SetWordID(Me.xtcExecute, "")
        Me.Localizer1.SetWordID(Me.xtpExecute, "Sql Execute")
        Me.Localizer1.SetWordID(Me.SplitContainerControl2, "SplitContainerControl2")
        Me.Localizer1.SetWordID(Me.btnRefresh, "&Refresh")
        Me.Localizer1.SetWordID(Me.btnExecuteReconnect, "Execute")
        Me.Localizer1.SetWordID(Me.splSqlSettings, "")
        Me.Localizer1.SetWordID(Me.S_EXECUTE, "")
        Me.Localizer1.SetWordID(Me.WG_EXECUTE, "")
        Me.Localizer1.SetWordID(Me.GridBand2, "GridBand1")
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        Me.Localizer1.SetWordID(Me.CTRY_CD, "")
        Me.Localizer1.SetWordID(Me.DB_SID, "")
        Me.Localizer1.SetWordID(Me.Label5, "SID")
        Me.Localizer1.SetWordID(Me.DB_PORT, "")
        Me.Localizer1.SetWordID(Me.Label4, "Port")
        Me.Localizer1.SetWordID(Me.DB_IP, "")
        Me.Localizer1.SetWordID(Me.Label3, "IP")
        Me.Localizer1.SetWordID(Me.USR_PWD, "")
        Me.Localizer1.SetWordID(Me.Label2, "PW")
        Me.Localizer1.SetWordID(Me.USR_ID, "")
        Me.Localizer1.SetWordID(Me.Label1, "ID")
        Me.Localizer1.SetWordID(Me.DOMAIN, "")
        Me.Localizer1.SetWordID(Me.LBL_S_SQL_ID, "Domain")
        Me.Localizer1.SetWordID(Me.Button4, "")
        Me.Localizer1.SetWordID(Me.CUST_CD, "")
        Me.Localizer1.SetWordID(Me.Label7, "거래처")
        Me.Localizer1.SetWordID(Me.PanelControl6, "")
        '
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl3.Location = New System.Drawing.Point(6, 83)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.panel)
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.xtcExecute)
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.Size = New System.Drawing.Size(1252, 643)
        Me.SplitContainerControl3.SplitterPosition = 756
        Me.SplitContainerControl3.TabIndex = 9
        Me.SplitContainerControl3.Text = "SplitContainerControl3"
        Me.Localizer1.SetWordID(Me.SplitContainerControl3, "")
        '
        'panel
        '
        Me.panel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.panel.Controls.Add(Me.btnSql)
        Me.panel.Controls.Add(Me.WG_SQL)
        Me.panel.Location = New System.Drawing.Point(475, 1)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(281, 643)
        Me.panel.TabIndex = 12
        Me.Localizer1.SetWordID(Me.panel, "Sql ID")
        '
        'btnSql
        '
        Me.btnSql.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSql.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnSql.Image = CType(resources.GetObject("btnSql.Image"), System.Drawing.Image)
        Me.btnSql.Location = New System.Drawing.Point(203, 5)
        Me.btnSql.Name = "btnSql"
        Me.btnSql.Size = New System.Drawing.Size(73, 22)
        Me.btnSql.TabIndex = 9
        Me.btnSql.Text = " Sea&rch"
        Me.Localizer1.SetWordID(Me.btnSql, "")
        '
        'WG_SQL
        '
        Me.WG_SQL.AllowClientBinding = True
        Me.WG_SQL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_SQL.DeleteRowConfirmation = True
        Me.WG_SQL.DisplayCurrentRow = False
        Me.WG_SQL.IsDataStateAware = True
        Me.WG_SQL.Location = New System.Drawing.Point(5, 33)
        Me.WG_SQL.MainView = Me.GV_SQL
        Me.WG_SQL.Name = "WG_SQL"
        Me.WG_SQL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WG_SQL.SaveLayout = False
        Me.WG_SQL.Size = New System.Drawing.Size(271, 606)
        Me.WG_SQL.TabIndex = 8
        Me.WG_SQL.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_SQL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_SQL})
        '
        'GV_SQL
        '
        Me.GV_SQL.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV_SQL.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV_SQL.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GVS_TITLE, Me.GVS_SQL_STR})
        Me.GV_SQL.GridControl = Me.WG_SQL
        Me.GV_SQL.Name = "GV_SQL"
        Me.GV_SQL.OptionsBehavior.Editable = False
        Me.GV_SQL.OptionsBehavior.ReadOnly = True
        Me.GV_SQL.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_SQL.OptionsView.ColumnAutoWidth = False
        Me.GV_SQL.OptionsView.ShowGroupPanel = False
        Me.GV_SQL.RowHeight = 10
        Me.GV_SQL.ViewCaption = " 고객 리스트"
        '
        'GVS_TITLE
        '
        Me.GVS_TITLE.Caption = "TITLE"
        Me.GVS_TITLE.FieldName = "TITLE"
        Me.GVS_TITLE.Name = "GVS_TITLE"
        Me.GVS_TITLE.Visible = True
        Me.GVS_TITLE.VisibleIndex = 0
        Me.GVS_TITLE.Width = 182
        Me.Localizer1.SetWordID(Me.GVS_TITLE, "TITLE")
        '
        'GVS_SQL_STR
        '
        Me.GVS_SQL_STR.Caption = "SQL"
        Me.GVS_SQL_STR.FieldName = "SQL_STR"
        Me.GVS_SQL_STR.Name = "GVS_SQL_STR"
        Me.GVS_SQL_STR.Visible = True
        Me.GVS_SQL_STR.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GVS_SQL_STR, "SQL")
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.PanelControl6)
        Me.PanelControl1.Controls.Add(Me.PanelControl5)
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(466, 643)
        Me.PanelControl1.TabIndex = 13
        Me.Localizer1.SetWordID(Me.PanelControl1, "Sql ID")
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl5.Controls.Add(Me.Label13)
        Me.PanelControl5.Controls.Add(Me.RPNO)
        Me.PanelControl5.Controls.Add(Me.Label10)
        Me.PanelControl5.Controls.Add(Me.WG_ISU)
        Me.PanelControl5.Controls.Add(Me.GINO)
        Me.PanelControl5.Controls.Add(Me.btnUpdateIsu)
        Me.PanelControl5.Controls.Add(Me.Label8)
        Me.PanelControl5.Controls.Add(Me.ISU_SEND_NO)
        Me.PanelControl5.Location = New System.Drawing.Point(3, 391)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(458, 247)
        Me.PanelControl5.TabIndex = 345
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.LabelFor = Nothing
        Me.Label13.Location = New System.Drawing.Point(5, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 22)
        Me.Label13.TabIndex = 352
        Me.Label13.Text = "반출승인번호"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label13, "반출승인번호")
        '
        'RPNO
        '
        Me.RPNO.BorderColor = System.Drawing.Color.Silver
        Me.RPNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RPNO.DefVal = ""
        Me.RPNO.IsDataStateAware = True
        Me.RPNO.Location = New System.Drawing.Point(104, 3)
        Me.RPNO.MaxLength = 50
        Me.RPNO.Name = "RPNO"
        Me.RPNO.NextFocus = "MRN"
        Me.RPNO.ReadOnly = True
        Me.RPNO.Size = New System.Drawing.Size(137, 22)
        Me.RPNO.TabIndex = 351
        Me.RPNO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.LabelFor = Nothing
        Me.Label10.Location = New System.Drawing.Point(245, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 22)
        Me.Label10.TabIndex = 347
        Me.Label10.Text = "반출번호"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label10, "반출번호")
        '
        'WG_ISU
        '
        Me.WG_ISU.AllowClientBinding = True
        Me.WG_ISU.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_ISU.DeleteRowConfirmation = False
        Me.WG_ISU.DisplayCurrentRow = False
        Me.WG_ISU.IsDataStateAware = True
        Me.WG_ISU.Location = New System.Drawing.Point(5, 56)
        Me.WG_ISU.MainView = Me.GV_ISU
        Me.WG_ISU.Name = "WG_ISU"
        Me.WG_ISU.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit8, Me.RepositoryItemTextEdit4, Me.RepositoryItemButtonEdit1})
        Me.WG_ISU.SaveLayout = False
        Me.WG_ISU.Size = New System.Drawing.Size(449, 187)
        Me.WG_ISU.TabIndex = 345
        Me.WG_ISU.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_ISU.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_ISU, Me.GridView2})
        '
        'GV_ISU
        '
        Me.GV_ISU.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GVI_GINO, Me.GVI_RPNO, Me.GVI_GBUN, Me.GVI_LICENSE_NO, Me.GVI_ISSUED_TYPE, Me.GVI_QTY, Me.GVI_WGT, Me.GVI_CBM, Me.GVI_EDI_REMARK, Me.GVI_ISU_SEND_NO})
        Me.GV_ISU.GridControl = Me.WG_ISU
        Me.GV_ISU.Name = "GV_ISU"
        Me.GV_ISU.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_ISU.OptionsView.ColumnAutoWidth = False
        Me.GV_ISU.OptionsView.ShowGroupPanel = False
        '
        'GVI_GINO
        '
        Me.GVI_GINO.Caption = "반출번호"
        Me.GVI_GINO.FieldName = "GINO"
        Me.GVI_GINO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GVI_GINO.Name = "GVI_GINO"
        Me.GVI_GINO.OptionsColumn.AllowEdit = False
        Me.GVI_GINO.OptionsColumn.ReadOnly = True
        Me.GVI_GINO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_GINO.Visible = True
        Me.GVI_GINO.VisibleIndex = 1
        Me.GVI_GINO.Width = 100
        Me.Localizer1.SetWordID(Me.GVI_GINO, "반출번호")
        '
        'GVI_RPNO
        '
        Me.GVI_RPNO.Caption = "반출승인번호"
        Me.GVI_RPNO.FieldName = "RPNO"
        Me.GVI_RPNO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GVI_RPNO.Name = "GVI_RPNO"
        Me.GVI_RPNO.OptionsColumn.AllowEdit = False
        Me.GVI_RPNO.OptionsColumn.ReadOnly = True
        Me.GVI_RPNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_RPNO.Visible = True
        Me.GVI_RPNO.VisibleIndex = 2
        Me.GVI_RPNO.Width = 107
        Me.Localizer1.SetWordID(Me.GVI_RPNO, "")
        '
        'GVI_GBUN
        '
        Me.GVI_GBUN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GVI_GBUN.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GVI_GBUN.AppearanceCell.Options.UseFont = True
        Me.GVI_GBUN.AppearanceCell.Options.UseForeColor = True
        Me.GVI_GBUN.Caption = "구분"
        Me.GVI_GBUN.FieldName = "GBUN"
        Me.GVI_GBUN.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GVI_GBUN.Name = "GVI_GBUN"
        Me.GVI_GBUN.Visible = True
        Me.GVI_GBUN.VisibleIndex = 0
        Me.GVI_GBUN.Width = 50
        Me.Localizer1.SetWordID(Me.GVI_GBUN, "")
        '
        'GVI_LICENSE_NO
        '
        Me.GVI_LICENSE_NO.Caption = "근거번호"
        Me.GVI_LICENSE_NO.FieldName = "LICENSE_NO"
        Me.GVI_LICENSE_NO.Name = "GVI_LICENSE_NO"
        Me.GVI_LICENSE_NO.OptionsColumn.AllowEdit = False
        Me.GVI_LICENSE_NO.OptionsColumn.ReadOnly = True
        Me.GVI_LICENSE_NO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_LICENSE_NO.Visible = True
        Me.GVI_LICENSE_NO.VisibleIndex = 8
        Me.GVI_LICENSE_NO.Width = 97
        Me.Localizer1.SetWordID(Me.GVI_LICENSE_NO, "")
        '
        'GVI_ISSUED_TYPE
        '
        Me.GVI_ISSUED_TYPE.Caption = "반출구분"
        Me.GVI_ISSUED_TYPE.FieldName = "ISSUED_TYPE"
        Me.GVI_ISSUED_TYPE.Name = "GVI_ISSUED_TYPE"
        Me.GVI_ISSUED_TYPE.Visible = True
        Me.GVI_ISSUED_TYPE.VisibleIndex = 9
        Me.Localizer1.SetWordID(Me.GVI_ISSUED_TYPE, "")
        '
        'GVI_QTY
        '
        Me.GVI_QTY.AppearanceCell.Options.UseTextOptions = True
        Me.GVI_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GVI_QTY.Caption = "수량"
        Me.GVI_QTY.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GVI_QTY.FieldName = "QTY"
        Me.GVI_QTY.Name = "GVI_QTY"
        Me.GVI_QTY.OptionsColumn.AllowEdit = False
        Me.GVI_QTY.OptionsColumn.ReadOnly = True
        Me.GVI_QTY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_QTY.Visible = True
        Me.GVI_QTY.VisibleIndex = 5
        Me.GVI_QTY.Width = 65
        Me.Localizer1.SetWordID(Me.GVI_QTY, "수량")
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "#,###,###,##0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GVI_WGT
        '
        Me.GVI_WGT.AppearanceCell.Options.UseTextOptions = True
        Me.GVI_WGT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GVI_WGT.Caption = "중량"
        Me.GVI_WGT.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GVI_WGT.FieldName = "WGT"
        Me.GVI_WGT.Name = "GVI_WGT"
        Me.GVI_WGT.OptionsColumn.AllowEdit = False
        Me.GVI_WGT.OptionsColumn.ReadOnly = True
        Me.GVI_WGT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_WGT.Visible = True
        Me.GVI_WGT.VisibleIndex = 6
        Me.GVI_WGT.Width = 85
        Me.Localizer1.SetWordID(Me.GVI_WGT, "중량")
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Mask.EditMask = "###,###,##0.00"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'GVI_CBM
        '
        Me.GVI_CBM.AppearanceCell.Options.UseTextOptions = True
        Me.GVI_CBM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GVI_CBM.Caption = "용적"
        Me.GVI_CBM.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GVI_CBM.FieldName = "CBM"
        Me.GVI_CBM.Name = "GVI_CBM"
        Me.GVI_CBM.OptionsColumn.AllowEdit = False
        Me.GVI_CBM.OptionsColumn.ReadOnly = True
        Me.GVI_CBM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_CBM.Visible = True
        Me.GVI_CBM.VisibleIndex = 7
        Me.GVI_CBM.Width = 80
        Me.Localizer1.SetWordID(Me.GVI_CBM, "용적")
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "###,###,##0.000"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GVI_EDI_REMARK
        '
        Me.GVI_EDI_REMARK.Caption = "전송결과"
        Me.GVI_EDI_REMARK.FieldName = "EDI_REMARK"
        Me.GVI_EDI_REMARK.Name = "GVI_EDI_REMARK"
        Me.GVI_EDI_REMARK.OptionsColumn.AllowEdit = False
        Me.GVI_EDI_REMARK.OptionsColumn.ReadOnly = True
        Me.GVI_EDI_REMARK.Visible = True
        Me.GVI_EDI_REMARK.VisibleIndex = 3
        Me.GVI_EDI_REMARK.Width = 119
        Me.Localizer1.SetWordID(Me.GVI_EDI_REMARK, "")
        '
        'GVI_ISU_SEND_NO
        '
        Me.GVI_ISU_SEND_NO.Caption = "신고번호"
        Me.GVI_ISU_SEND_NO.FieldName = "ISU_SEND_NO"
        Me.GVI_ISU_SEND_NO.Name = "GVI_ISU_SEND_NO"
        Me.GVI_ISU_SEND_NO.OptionsColumn.AllowEdit = False
        Me.GVI_ISU_SEND_NO.OptionsColumn.ReadOnly = True
        Me.GVI_ISU_SEND_NO.Visible = True
        Me.GVI_ISU_SEND_NO.VisibleIndex = 4
        Me.GVI_ISU_SEND_NO.Width = 144
        Me.Localizer1.SetWordID(Me.GVI_ISU_SEND_NO, "")
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.MaxLength = 11
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.MaxLength = 4
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.MaxLength = 10
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 2
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.MaxLength = 1
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.RepositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.RepositoryItemButtonEdit1.UseReadOnlyAppearance = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.WG_ISU
        Me.GridView2.Name = "GridView2"
        '
        'GINO
        '
        Me.GINO.BorderColor = System.Drawing.Color.Silver
        Me.GINO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GINO.DefVal = ""
        Me.GINO.IsDataStateAware = True
        Me.GINO.Location = New System.Drawing.Point(316, 3)
        Me.GINO.MaxLength = 50
        Me.GINO.Name = "GINO"
        Me.GINO.NextFocus = "MRN"
        Me.GINO.ReadOnly = True
        Me.GINO.Size = New System.Drawing.Size(137, 22)
        Me.GINO.TabIndex = 346
        Me.GINO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'btnUpdateIsu
        '
        Me.btnUpdateIsu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateIsu.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.btnUpdateIsu.Image = CType(resources.GetObject("btnUpdateIsu.Image"), System.Drawing.Image)
        Me.btnUpdateIsu.Location = New System.Drawing.Point(318, 28)
        Me.btnUpdateIsu.Name = "btnUpdateIsu"
        Me.btnUpdateIsu.Size = New System.Drawing.Size(135, 22)
        Me.btnUpdateIsu.TabIndex = 348
        Me.btnUpdateIsu.Text = "접수통보 변경"
        Me.Localizer1.SetWordID(Me.btnUpdateIsu, "접수통보 변경")
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.LabelFor = Nothing
        Me.Label8.Location = New System.Drawing.Point(5, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 22)
        Me.Label8.TabIndex = 350
        Me.Label8.Text = "반출 신고번호"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label8, "반출 신고번호")
        '
        'ISU_SEND_NO
        '
        Me.ISU_SEND_NO.BorderColor = System.Drawing.Color.Silver
        Me.ISU_SEND_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ISU_SEND_NO.DefVal = ""
        Me.ISU_SEND_NO.IsDataStateAware = True
        Me.ISU_SEND_NO.Location = New System.Drawing.Point(104, 28)
        Me.ISU_SEND_NO.MaxLength = 50
        Me.ISU_SEND_NO.Name = "ISU_SEND_NO"
        Me.ISU_SEND_NO.NextFocus = "MRN"
        Me.ISU_SEND_NO.ReadOnly = True
        Me.ISU_SEND_NO.Size = New System.Drawing.Size(206, 22)
        Me.ISU_SEND_NO.TabIndex = 349
        Me.ISU_SEND_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Controls.Add(Me.Label12)
        Me.PanelControl4.Controls.Add(Me.DELNO)
        Me.PanelControl4.Controls.Add(Me.LableGRNO)
        Me.PanelControl4.Controls.Add(Me.WG_RCP)
        Me.PanelControl4.Controls.Add(Me.GRNO)
        Me.PanelControl4.Controls.Add(Me.btnUpdateRcp)
        Me.PanelControl4.Controls.Add(Me.Label9)
        Me.PanelControl4.Controls.Add(Me.RCP_SEND_NO)
        Me.PanelControl4.Location = New System.Drawing.Point(3, 168)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(458, 220)
        Me.PanelControl4.TabIndex = 338
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.LabelFor = Nothing
        Me.Label12.Location = New System.Drawing.Point(6, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 22)
        Me.Label12.TabIndex = 346
        Me.Label12.Text = "반입예정번호"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label12, "반입예정번호")
        '
        'DELNO
        '
        Me.DELNO.BorderColor = System.Drawing.Color.Silver
        Me.DELNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DELNO.DefVal = ""
        Me.DELNO.IsDataStateAware = True
        Me.DELNO.Location = New System.Drawing.Point(104, 3)
        Me.DELNO.MaxLength = 50
        Me.DELNO.Name = "DELNO"
        Me.DELNO.NextFocus = "MRN"
        Me.DELNO.ReadOnly = True
        Me.DELNO.Size = New System.Drawing.Size(135, 22)
        Me.DELNO.TabIndex = 345
        Me.DELNO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'LableGRNO
        '
        Me.LableGRNO.ForeColor = System.Drawing.Color.Black
        Me.LableGRNO.LabelFor = Nothing
        Me.LableGRNO.Location = New System.Drawing.Point(245, 3)
        Me.LableGRNO.Name = "LableGRNO"
        Me.LableGRNO.Size = New System.Drawing.Size(67, 22)
        Me.LableGRNO.TabIndex = 337
        Me.LableGRNO.Text = "반입번호"
        Me.LableGRNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LableGRNO, "반입번호")
        '
        'WG_RCP
        '
        Me.WG_RCP.AllowClientBinding = True
        Me.WG_RCP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_RCP.DeleteRowConfirmation = False
        Me.WG_RCP.DisplayCurrentRow = False
        Me.WG_RCP.IsDataStateAware = True
        Me.WG_RCP.Location = New System.Drawing.Point(5, 56)
        Me.WG_RCP.MainView = Me.GV_RCP
        Me.WG_RCP.Name = "WG_RCP"
        Me.WG_RCP.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GV3_Text11, Me.GV3_Text4, Me.GV3_Text10, Me.GV3_Num0, Me.GV3_Text2, Me.GV3_Num2, Me.GV3_Text1, Me.GV3_NUM3, Me.GVR_Button})
        Me.WG_RCP.SaveLayout = False
        Me.WG_RCP.Size = New System.Drawing.Size(448, 159)
        Me.WG_RCP.TabIndex = 6
        Me.WG_RCP.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_RCP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_RCP, Me.GridView3})
        '
        'GV_RCP
        '
        Me.GV_RCP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GVR_GRNO, Me.GVR_DELNO, Me.GVR_LICENSE_NO, Me.GVR_QTY, Me.GVR_WGT, Me.GVR_CBM, Me.GVR_EDI_REMARK, Me.GVR_RCP_SEND_NO, Me.GVR_GBUN})
        Me.GV_RCP.GridControl = Me.WG_RCP
        Me.GV_RCP.Name = "GV_RCP"
        Me.GV_RCP.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_RCP.OptionsView.ColumnAutoWidth = False
        Me.GV_RCP.OptionsView.ShowGroupPanel = False
        '
        'GVR_GRNO
        '
        Me.GVR_GRNO.Caption = "반입번호"
        Me.GVR_GRNO.FieldName = "GRNO"
        Me.GVR_GRNO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GVR_GRNO.Name = "GVR_GRNO"
        Me.GVR_GRNO.OptionsColumn.AllowEdit = False
        Me.GVR_GRNO.OptionsColumn.ReadOnly = True
        Me.GVR_GRNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVR_GRNO.Visible = True
        Me.GVR_GRNO.VisibleIndex = 1
        Me.GVR_GRNO.Width = 100
        Me.Localizer1.SetWordID(Me.GVR_GRNO, "반입번호")
        '
        'GVR_DELNO
        '
        Me.GVR_DELNO.Caption = "반입예정번호"
        Me.GVR_DELNO.FieldName = "DELNO"
        Me.GVR_DELNO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GVR_DELNO.Name = "GVR_DELNO"
        Me.GVR_DELNO.OptionsColumn.AllowEdit = False
        Me.GVR_DELNO.OptionsColumn.ReadOnly = True
        Me.GVR_DELNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVR_DELNO.Visible = True
        Me.GVR_DELNO.VisibleIndex = 2
        Me.GVR_DELNO.Width = 107
        Me.Localizer1.SetWordID(Me.GVR_DELNO, "")
        '
        'GVR_LICENSE_NO
        '
        Me.GVR_LICENSE_NO.Caption = "근거번호"
        Me.GVR_LICENSE_NO.FieldName = "LICENSE_NO"
        Me.GVR_LICENSE_NO.Name = "GVR_LICENSE_NO"
        Me.GVR_LICENSE_NO.OptionsColumn.AllowEdit = False
        Me.GVR_LICENSE_NO.OptionsColumn.ReadOnly = True
        Me.GVR_LICENSE_NO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVR_LICENSE_NO.Visible = True
        Me.GVR_LICENSE_NO.VisibleIndex = 8
        Me.GVR_LICENSE_NO.Width = 97
        Me.Localizer1.SetWordID(Me.GVR_LICENSE_NO, "")
        '
        'GVR_QTY
        '
        Me.GVR_QTY.AppearanceCell.Options.UseTextOptions = True
        Me.GVR_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GVR_QTY.Caption = "수량"
        Me.GVR_QTY.ColumnEdit = Me.GV3_Num0
        Me.GVR_QTY.FieldName = "QTY"
        Me.GVR_QTY.Name = "GVR_QTY"
        Me.GVR_QTY.OptionsColumn.AllowEdit = False
        Me.GVR_QTY.OptionsColumn.ReadOnly = True
        Me.GVR_QTY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVR_QTY.Visible = True
        Me.GVR_QTY.VisibleIndex = 5
        Me.GVR_QTY.Width = 65
        Me.Localizer1.SetWordID(Me.GVR_QTY, "수량")
        '
        'GV3_Num0
        '
        Me.GV3_Num0.AutoHeight = False
        Me.GV3_Num0.Mask.EditMask = "#,###,###,##0"
        Me.GV3_Num0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.GV3_Num0.Mask.UseMaskAsDisplayFormat = True
        Me.GV3_Num0.Name = "GV3_Num0"
        '
        'GVR_WGT
        '
        Me.GVR_WGT.AppearanceCell.Options.UseTextOptions = True
        Me.GVR_WGT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GVR_WGT.Caption = "중량"
        Me.GVR_WGT.ColumnEdit = Me.GV3_Num2
        Me.GVR_WGT.FieldName = "WGT"
        Me.GVR_WGT.Name = "GVR_WGT"
        Me.GVR_WGT.OptionsColumn.AllowEdit = False
        Me.GVR_WGT.OptionsColumn.ReadOnly = True
        Me.GVR_WGT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVR_WGT.Visible = True
        Me.GVR_WGT.VisibleIndex = 6
        Me.GVR_WGT.Width = 85
        Me.Localizer1.SetWordID(Me.GVR_WGT, "중량")
        '
        'GV3_Num2
        '
        Me.GV3_Num2.AutoHeight = False
        Me.GV3_Num2.Mask.EditMask = "###,###,##0.00"
        Me.GV3_Num2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.GV3_Num2.Mask.UseMaskAsDisplayFormat = True
        Me.GV3_Num2.Name = "GV3_Num2"
        '
        'GVR_CBM
        '
        Me.GVR_CBM.AppearanceCell.Options.UseTextOptions = True
        Me.GVR_CBM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GVR_CBM.Caption = "용적"
        Me.GVR_CBM.ColumnEdit = Me.GV3_NUM3
        Me.GVR_CBM.FieldName = "CBM"
        Me.GVR_CBM.Name = "GVR_CBM"
        Me.GVR_CBM.OptionsColumn.AllowEdit = False
        Me.GVR_CBM.OptionsColumn.ReadOnly = True
        Me.GVR_CBM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVR_CBM.Visible = True
        Me.GVR_CBM.VisibleIndex = 7
        Me.GVR_CBM.Width = 80
        Me.Localizer1.SetWordID(Me.GVR_CBM, "용적")
        '
        'GV3_NUM3
        '
        Me.GV3_NUM3.AutoHeight = False
        Me.GV3_NUM3.Mask.EditMask = "###,###,##0.000"
        Me.GV3_NUM3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.GV3_NUM3.Mask.UseMaskAsDisplayFormat = True
        Me.GV3_NUM3.Name = "GV3_NUM3"
        '
        'GVR_EDI_REMARK
        '
        Me.GVR_EDI_REMARK.Caption = "전송결과"
        Me.GVR_EDI_REMARK.FieldName = "EDI_REMARK"
        Me.GVR_EDI_REMARK.Name = "GVR_EDI_REMARK"
        Me.GVR_EDI_REMARK.OptionsColumn.AllowEdit = False
        Me.GVR_EDI_REMARK.OptionsColumn.ReadOnly = True
        Me.GVR_EDI_REMARK.Visible = True
        Me.GVR_EDI_REMARK.VisibleIndex = 3
        Me.GVR_EDI_REMARK.Width = 119
        Me.Localizer1.SetWordID(Me.GVR_EDI_REMARK, "")
        '
        'GVR_RCP_SEND_NO
        '
        Me.GVR_RCP_SEND_NO.Caption = "신고번호"
        Me.GVR_RCP_SEND_NO.FieldName = "RCP_SEND_NO"
        Me.GVR_RCP_SEND_NO.Name = "GVR_RCP_SEND_NO"
        Me.GVR_RCP_SEND_NO.OptionsColumn.AllowEdit = False
        Me.GVR_RCP_SEND_NO.OptionsColumn.ReadOnly = True
        Me.GVR_RCP_SEND_NO.Visible = True
        Me.GVR_RCP_SEND_NO.VisibleIndex = 4
        Me.GVR_RCP_SEND_NO.Width = 144
        Me.Localizer1.SetWordID(Me.GVR_RCP_SEND_NO, "")
        '
        'GVR_GBUN
        '
        Me.GVR_GBUN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GVR_GBUN.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GVR_GBUN.AppearanceCell.Options.UseFont = True
        Me.GVR_GBUN.AppearanceCell.Options.UseForeColor = True
        Me.GVR_GBUN.Caption = "구분"
        Me.GVR_GBUN.FieldName = "GBUN"
        Me.GVR_GBUN.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GVR_GBUN.Name = "GVR_GBUN"
        Me.GVR_GBUN.Visible = True
        Me.GVR_GBUN.VisibleIndex = 0
        Me.GVR_GBUN.Width = 50
        Me.Localizer1.SetWordID(Me.GVR_GBUN, "")
        '
        'GV3_Text11
        '
        Me.GV3_Text11.AutoHeight = False
        Me.GV3_Text11.MaxLength = 11
        Me.GV3_Text11.Name = "GV3_Text11"
        '
        'GV3_Text4
        '
        Me.GV3_Text4.AutoHeight = False
        Me.GV3_Text4.MaxLength = 4
        Me.GV3_Text4.Name = "GV3_Text4"
        '
        'GV3_Text10
        '
        Me.GV3_Text10.AutoHeight = False
        Me.GV3_Text10.MaxLength = 10
        Me.GV3_Text10.Name = "GV3_Text10"
        '
        'GV3_Text2
        '
        Me.GV3_Text2.AutoHeight = False
        Me.GV3_Text2.MaxLength = 2
        Me.GV3_Text2.Name = "GV3_Text2"
        '
        'GV3_Text1
        '
        Me.GV3_Text1.AutoHeight = False
        Me.GV3_Text1.MaxLength = 1
        Me.GV3_Text1.Name = "GV3_Text1"
        '
        'GVR_Button
        '
        Me.GVR_Button.AutoHeight = False
        Me.GVR_Button.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.GVR_Button.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.GVR_Button.Name = "GVR_Button"
        Me.GVR_Button.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.GVR_Button.UseReadOnlyAppearance = False
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.WG_RCP
        Me.GridView3.Name = "GridView3"
        '
        'GRNO
        '
        Me.GRNO.BorderColor = System.Drawing.Color.Silver
        Me.GRNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GRNO.DefVal = ""
        Me.GRNO.IsDataStateAware = True
        Me.GRNO.Location = New System.Drawing.Point(318, 4)
        Me.GRNO.MaxLength = 50
        Me.GRNO.Name = "GRNO"
        Me.GRNO.NextFocus = "MRN"
        Me.GRNO.ReadOnly = True
        Me.GRNO.Size = New System.Drawing.Size(135, 22)
        Me.GRNO.TabIndex = 336
        Me.GRNO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'btnUpdateRcp
        '
        Me.btnUpdateRcp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateRcp.ButtonType = YJIT.SC.UI.ButtonTypes.Save
        Me.btnUpdateRcp.Image = CType(resources.GetObject("btnUpdateRcp.Image"), System.Drawing.Image)
        Me.btnUpdateRcp.Location = New System.Drawing.Point(318, 28)
        Me.btnUpdateRcp.Name = "btnUpdateRcp"
        Me.btnUpdateRcp.Size = New System.Drawing.Size(135, 22)
        Me.btnUpdateRcp.TabIndex = 338
        Me.btnUpdateRcp.Text = "접수통보 변경"
        Me.Localizer1.SetWordID(Me.btnUpdateRcp, "접수통보 변경")
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.LabelFor = Nothing
        Me.Label9.Location = New System.Drawing.Point(6, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 22)
        Me.Label9.TabIndex = 344
        Me.Label9.Text = "반입 신고번호"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label9, "반입 신고번호")
        '
        'RCP_SEND_NO
        '
        Me.RCP_SEND_NO.BorderColor = System.Drawing.Color.Silver
        Me.RCP_SEND_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RCP_SEND_NO.DefVal = ""
        Me.RCP_SEND_NO.IsDataStateAware = True
        Me.RCP_SEND_NO.Location = New System.Drawing.Point(104, 28)
        Me.RCP_SEND_NO.MaxLength = 50
        Me.RCP_SEND_NO.Name = "RCP_SEND_NO"
        Me.RCP_SEND_NO.NextFocus = "MRN"
        Me.RCP_SEND_NO.ReadOnly = True
        Me.RCP_SEND_NO.Size = New System.Drawing.Size(206, 22)
        Me.RCP_SEND_NO.TabIndex = 343
        Me.RCP_SEND_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'WHNM
        '
        Me.WHNM.BorderColor = System.Drawing.Color.Silver
        Me.WHNM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WHNM.DefVal = ""
        Me.WHNM.IsDataStateAware = True
        Me.WHNM.Location = New System.Drawing.Point(150, 4)
        Me.WHNM.MaxLength = 50
        Me.WHNM.Name = "WHNM"
        Me.WHNM.NextFocus = "MRN"
        Me.WHNM.ReadOnly = True
        Me.WHNM.Size = New System.Drawing.Size(180, 22)
        Me.WHNM.TabIndex = 354
        Me.WHNM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'WHCD
        '
        Me.WHCD.BorderColor = System.Drawing.Color.Silver
        Me.WHCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WHCD.DefVal = ""
        Me.WHCD.IsDataStateAware = True
        Me.WHCD.Location = New System.Drawing.Point(85, 4)
        Me.WHCD.MaxLength = 50
        Me.WHCD.Name = "WHCD"
        Me.WHCD.NextFocus = "MRN"
        Me.WHCD.ReadOnly = True
        Me.WHCD.Size = New System.Drawing.Size(59, 22)
        Me.WHCD.TabIndex = 352
        Me.WHCD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.LabelFor = Nothing
        Me.Label11.Location = New System.Drawing.Point(20, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 22)
        Me.Label11.TabIndex = 353
        Me.Label11.Text = "창고"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label11, "창고코드")
        '
        'WG_WH
        '
        Me.WG_WH.AllowClientBinding = True
        Me.WG_WH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_WH.DeleteRowConfirmation = False
        Me.WG_WH.DisplayCurrentRow = False
        Me.WG_WH.IsDataStateAware = True
        Me.WG_WH.Location = New System.Drawing.Point(5, 28)
        Me.WG_WH.MainView = Me.GV_WH
        Me.WG_WH.Name = "WG_WH"
        Me.WG_WH.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit13, Me.RepositoryItemTextEdit14, Me.RepositoryItemTextEdit15, Me.RepositoryItemTextEdit9, Me.RepositoryItemTextEdit10, Me.RepositoryItemTextEdit11, Me.RepositoryItemTextEdit16, Me.RepositoryItemTextEdit12, Me.RepositoryItemButtonEdit2})
        Me.WG_WH.SaveLayout = True
        Me.WG_WH.Size = New System.Drawing.Size(448, 65)
        Me.WG_WH.TabIndex = 351
        Me.WG_WH.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_WH.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_WH, Me.GridView4})
        '
        'GV_WH
        '
        Me.GV_WH.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV_WHNM, Me.GV_WHCD})
        Me.GV_WH.GridControl = Me.WG_WH
        Me.GV_WH.Name = "GV_WH"
        Me.GV_WH.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_WH.OptionsView.ColumnAutoWidth = False
        Me.GV_WH.OptionsView.ShowGroupPanel = False
        '
        'GV_WHNM
        '
        Me.GV_WHNM.Caption = "창고명"
        Me.GV_WHNM.FieldName = "WHNM"
        Me.GV_WHNM.Name = "GV_WHNM"
        Me.GV_WHNM.OptionsColumn.AllowEdit = False
        Me.GV_WHNM.OptionsColumn.ReadOnly = True
        Me.GV_WHNM.Visible = True
        Me.GV_WHNM.VisibleIndex = 0
        Me.GV_WHNM.Width = 205
        Me.Localizer1.SetWordID(Me.GV_WHNM, "")
        '
        'GV_WHCD
        '
        Me.GV_WHCD.Caption = "코드"
        Me.GV_WHCD.FieldName = "WHCD"
        Me.GV_WHCD.Name = "GV_WHCD"
        Me.GV_WHCD.OptionsColumn.AllowEdit = False
        Me.GV_WHCD.OptionsColumn.ReadOnly = True
        Me.GV_WHCD.Visible = True
        Me.GV_WHCD.VisibleIndex = 1
        Me.Localizer1.SetWordID(Me.GV_WHCD, "")
        '
        'RepositoryItemTextEdit13
        '
        Me.RepositoryItemTextEdit13.AutoHeight = False
        Me.RepositoryItemTextEdit13.MaxLength = 11
        Me.RepositoryItemTextEdit13.Name = "RepositoryItemTextEdit13"
        '
        'RepositoryItemTextEdit14
        '
        Me.RepositoryItemTextEdit14.AutoHeight = False
        Me.RepositoryItemTextEdit14.MaxLength = 4
        Me.RepositoryItemTextEdit14.Name = "RepositoryItemTextEdit14"
        '
        'RepositoryItemTextEdit15
        '
        Me.RepositoryItemTextEdit15.AutoHeight = False
        Me.RepositoryItemTextEdit15.MaxLength = 10
        Me.RepositoryItemTextEdit15.Name = "RepositoryItemTextEdit15"
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.Mask.EditMask = "#,###,###,##0"
        Me.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.AutoHeight = False
        Me.RepositoryItemTextEdit10.MaxLength = 2
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.AutoHeight = False
        Me.RepositoryItemTextEdit11.Mask.EditMask = "###,###,##0.00"
        Me.RepositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit11.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        '
        'RepositoryItemTextEdit16
        '
        Me.RepositoryItemTextEdit16.AutoHeight = False
        Me.RepositoryItemTextEdit16.MaxLength = 1
        Me.RepositoryItemTextEdit16.Name = "RepositoryItemTextEdit16"
        '
        'RepositoryItemTextEdit12
        '
        Me.RepositoryItemTextEdit12.AutoHeight = False
        Me.RepositoryItemTextEdit12.Mask.EditMask = "###,###,##0.000"
        Me.RepositoryItemTextEdit12.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit12.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit12.Name = "RepositoryItemTextEdit12"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.RepositoryItemButtonEdit2.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        Me.RepositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.RepositoryItemButtonEdit2.UseReadOnlyAppearance = False
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.WG_WH
        Me.GridView4.Name = "GridView4"
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.btnCargoList)
        Me.PanelControl3.Controls.Add(Me.MRN)
        Me.PanelControl3.Controls.Add(Me.btnClear2)
        Me.PanelControl3.Controls.Add(Me.Label6)
        Me.PanelControl3.Controls.Add(Me.btnSearch)
        Me.PanelControl3.Controls.Add(Me.HBLNO)
        Me.PanelControl3.Controls.Add(Me.LableHBL)
        Me.PanelControl3.Location = New System.Drawing.Point(3, 106)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(458, 56)
        Me.PanelControl3.TabIndex = 5
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        '
        'btnCargoList
        '
        Me.btnCargoList.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnCargoList.Image = CType(resources.GetObject("btnCargoList.Image"), System.Drawing.Image)
        Me.btnCargoList.Location = New System.Drawing.Point(355, 30)
        Me.btnCargoList.Name = "btnCargoList"
        Me.btnCargoList.Size = New System.Drawing.Size(98, 22)
        Me.btnCargoList.TabIndex = 347
        Me.btnCargoList.Text = "화물 조회"
        Me.Localizer1.SetWordID(Me.btnCargoList, "")
        '
        'MRN
        '
        Me.MRN.BorderColor = System.Drawing.Color.Silver
        Me.MRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MRN.DefVal = Nothing
        Me.MRN.IsDataStateAware = True
        Me.MRN.Location = New System.Drawing.Point(87, 30)
        Me.MRN.Mask = "&&&&&&&&&&&-&&&&-CCCC"
        Me.MRN.Name = "MRN"
        Me.MRN.NextFocus = "btnSearch"
        Me.MRN.Size = New System.Drawing.Size(152, 22)
        Me.MRN.TabIndex = 337
        Me.MRN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.Localizer1.SetWordID(Me.MRN, "")
        '
        'btnClear2
        '
        Me.btnClear2.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnClear2.Image = CType(resources.GetObject("btnClear2.Image"), System.Drawing.Image)
        Me.btnClear2.Location = New System.Drawing.Point(245, 5)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(104, 21)
        Me.btnClear2.TabIndex = 336
        Me.btnClear2.Text = "Clear"
        Me.Localizer1.SetWordID(Me.btnClear2, "&Clear")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.LabelFor = Nothing
        Me.Label6.Location = New System.Drawing.Point(7, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 14)
        Me.Label6.TabIndex = 336
        Me.Label6.Text = "화물관리번호"
        Me.Localizer1.SetWordID(Me.Label6, "화물관리번호")
        '
        'HBLNO
        '
        Me.HBLNO.BorderColor = System.Drawing.Color.Silver
        Me.HBLNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HBLNO.DefVal = ""
        Me.HBLNO.IsDataStateAware = True
        Me.HBLNO.Location = New System.Drawing.Point(87, 4)
        Me.HBLNO.MaxLength = 50
        Me.HBLNO.Name = "HBLNO"
        Me.HBLNO.NextFocus = "MRN"
        Me.HBLNO.Size = New System.Drawing.Size(152, 22)
        Me.HBLNO.TabIndex = 334
        Me.HBLNO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'LableHBL
        '
        Me.LableHBL.ForeColor = System.Drawing.Color.Black
        Me.LableHBL.LabelFor = Nothing
        Me.LableHBL.Location = New System.Drawing.Point(22, 3)
        Me.LableHBL.Name = "LableHBL"
        Me.LableHBL.Size = New System.Drawing.Size(59, 22)
        Me.LableHBL.TabIndex = 335
        Me.LableHBL.Text = "HB/L No."
        Me.LableHBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LableHBL, "HB/L No.")
        '
        'xtcExecute
        '
        Me.xtcExecute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcExecute.Location = New System.Drawing.Point(0, 0)
        Me.xtcExecute.Name = "xtcExecute"
        Me.xtcExecute.SelectedTabPage = Me.xtpExecute
        Me.xtcExecute.Size = New System.Drawing.Size(491, 643)
        Me.xtcExecute.TabIndex = 1
        Me.xtcExecute.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpExecute})
        Me.Localizer1.SetWordID(Me.xtcExecute, "")
        '
        'xtpExecute
        '
        Me.xtpExecute.Controls.Add(Me.SplitContainerControl2)
        Me.xtpExecute.Name = "xtpExecute"
        Me.xtpExecute.Size = New System.Drawing.Size(485, 614)
        Me.xtpExecute.Text = "Sql Execute"
        Me.Localizer1.SetWordID(Me.xtpExecute, "Sql Execute")
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.btnRefresh)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.btnExecuteReconnect)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.splSqlSettings)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.S_EXECUTE)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.WG_EXECUTE)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(485, 620)
        Me.SplitContainerControl2.SplitterPosition = 302
        Me.SplitContainerControl2.TabIndex = 5
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        Me.Localizer1.SetWordID(Me.SplitContainerControl2, "")
        '
        'btnRefresh
        '
        Me.btnRefresh.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(141, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(74, 22)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "&Refresh"
        Me.Localizer1.SetWordID(Me.btnRefresh, "")
        '
        'btnExecuteReconnect
        '
        Me.btnExecuteReconnect.ButtonType = YJIT.SC.UI.ButtonTypes.None
        Me.btnExecuteReconnect.Image = CType(resources.GetObject("btnExecuteReconnect.Image"), System.Drawing.Image)
        Me.btnExecuteReconnect.Location = New System.Drawing.Point(3, 3)
        Me.btnExecuteReconnect.Name = "btnExecuteReconnect"
        Me.btnExecuteReconnect.Size = New System.Drawing.Size(126, 22)
        Me.btnExecuteReconnect.TabIndex = 7
        Me.btnExecuteReconnect.Text = "Execute"
        Me.Localizer1.SetWordID(Me.btnExecuteReconnect, "")
        '
        'splSqlSettings
        '
        Me.splSqlSettings.Location = New System.Drawing.Point(3, 31)
        Me.splSqlSettings.Name = "splSqlSettings"
        Me.splSqlSettings.Size = New System.Drawing.Size(212, 315)
        Me.splSqlSettings.TabIndex = 8
        Me.Localizer1.SetWordID(Me.splSqlSettings, "")
        '
        'S_EXECUTE
        '
        Me.S_EXECUTE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.S_EXECUTE.BorderColor = System.Drawing.Color.Empty
        Me.S_EXECUTE.DefVal = ""
        Me.S_EXECUTE.IsDataStateAware = True
        Me.S_EXECUTE.Location = New System.Drawing.Point(221, 3)
        Me.S_EXECUTE.Multiline = True
        Me.S_EXECUTE.Name = "S_EXECUTE"
        Me.S_EXECUTE.NextFocus = Nothing
        Me.S_EXECUTE.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.S_EXECUTE.Size = New System.Drawing.Size(261, 298)
        Me.S_EXECUTE.TabIndex = 5
        Me.S_EXECUTE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'WG_EXECUTE
        '
        Me.WG_EXECUTE.AllowClientBinding = True
        Me.WG_EXECUTE.DeleteRowConfirmation = True
        Me.WG_EXECUTE.DisplayCurrentRow = False
        Me.WG_EXECUTE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WG_EXECUTE.IsDataStateAware = True
        Me.WG_EXECUTE.Location = New System.Drawing.Point(0, 0)
        Me.WG_EXECUTE.MainView = Me.GV_EXECUTE
        Me.WG_EXECUTE.Name = "WG_EXECUTE"
        Me.WG_EXECUTE.SaveLayout = False
        Me.WG_EXECUTE.Size = New System.Drawing.Size(485, 313)
        Me.WG_EXECUTE.TabIndex = 0
        Me.WG_EXECUTE.TextCasing = YJIT.SC.UI.TextCasings.Normal
        Me.WG_EXECUTE.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_EXECUTE})
        '
        'GV_EXECUTE
        '
        Me.GV_EXECUTE.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.GV_EXECUTE.GridControl = Me.WG_EXECUTE
        Me.GV_EXECUTE.HorzScrollStep = 100
        Me.GV_EXECUTE.Name = "GV_EXECUTE"
        Me.GV_EXECUTE.OptionsFind.AlwaysVisible = True
        Me.GV_EXECUTE.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GV_EXECUTE.OptionsSelection.InvertSelection = True
        Me.GV_EXECUTE.OptionsSelection.MultiSelect = True
        Me.GV_EXECUTE.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_EXECUTE.OptionsView.ShowBands = False
        Me.GV_EXECUTE.OptionsView.ShowGroupPanel = False
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "GridBand1"
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.VisibleIndex = 0
        Me.GridBand2.Width = 131
        Me.Localizer1.SetWordID(Me.GridBand2, "")
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.CTRY_CD)
        Me.PanelControl2.Controls.Add(Me.DB_SID)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Controls.Add(Me.DB_PORT)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.DB_IP)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.USR_PWD)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.USR_ID)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.DOMAIN)
        Me.PanelControl2.Controls.Add(Me.LBL_S_SQL_ID)
        Me.PanelControl2.Controls.Add(Me.Button4)
        Me.PanelControl2.Controls.Add(Me.CUST_CD)
        Me.PanelControl2.Controls.Add(Me.Label7)
        Me.PanelControl2.Controls.Add(Me.CUST_NM)
        Me.PanelControl2.Location = New System.Drawing.Point(6, 45)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1252, 33)
        Me.PanelControl2.TabIndex = 14
        Me.Localizer1.SetWordID(Me.PanelControl2, "")
        '
        'CTRY_CD
        '
        Me.CTRY_CD.BackColor = System.Drawing.SystemColors.Window
        Me.CTRY_CD.BorderColor = System.Drawing.Color.Silver
        Me.CTRY_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CTRY_CD.DefVal = ""
        Me.CTRY_CD.IsDataStateAware = True
        Me.CTRY_CD.Location = New System.Drawing.Point(1233, 5)
        Me.CTRY_CD.Name = "CTRY_CD"
        Me.CTRY_CD.NextFocus = "S_INS_YMD_FROM"
        Me.CTRY_CD.ReadOnly = True
        Me.CTRY_CD.Size = New System.Drawing.Size(13, 22)
        Me.CTRY_CD.TabIndex = 10019
        Me.CTRY_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.CTRY_CD.Visible = False
        '
        'DB_SID
        '
        Me.DB_SID.BackColor = System.Drawing.SystemColors.Window
        Me.DB_SID.BorderColor = System.Drawing.Color.Silver
        Me.DB_SID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DB_SID.DefVal = ""
        Me.DB_SID.IsDataStateAware = True
        Me.DB_SID.Location = New System.Drawing.Point(1164, 5)
        Me.DB_SID.Name = "DB_SID"
        Me.DB_SID.NextFocus = "S_INS_YMD_FROM"
        Me.DB_SID.ReadOnly = True
        Me.DB_SID.Size = New System.Drawing.Size(55, 22)
        Me.DB_SID.TabIndex = 10017
        Me.DB_SID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.LabelFor = Nothing
        Me.Label5.Location = New System.Drawing.Point(1116, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 22)
        Me.Label5.TabIndex = 10016
        Me.Label5.Text = "SID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label5, "SID")
        '
        'DB_PORT
        '
        Me.DB_PORT.BackColor = System.Drawing.SystemColors.Window
        Me.DB_PORT.BorderColor = System.Drawing.Color.Silver
        Me.DB_PORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DB_PORT.DefVal = ""
        Me.DB_PORT.IsDataStateAware = True
        Me.DB_PORT.Location = New System.Drawing.Point(1055, 5)
        Me.DB_PORT.Name = "DB_PORT"
        Me.DB_PORT.NextFocus = "DB_SID"
        Me.DB_PORT.ReadOnly = True
        Me.DB_PORT.Size = New System.Drawing.Size(55, 22)
        Me.DB_PORT.TabIndex = 10015
        Me.DB_PORT.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.LabelFor = Nothing
        Me.Label4.Location = New System.Drawing.Point(1007, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 22)
        Me.Label4.TabIndex = 10014
        Me.Label4.Text = "Port"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label4, "Port")
        '
        'DB_IP
        '
        Me.DB_IP.BackColor = System.Drawing.SystemColors.Window
        Me.DB_IP.BorderColor = System.Drawing.Color.Silver
        Me.DB_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DB_IP.DefVal = ""
        Me.DB_IP.IsDataStateAware = True
        Me.DB_IP.Location = New System.Drawing.Point(838, 5)
        Me.DB_IP.Name = "DB_IP"
        Me.DB_IP.NextFocus = "DB_PORT"
        Me.DB_IP.ReadOnly = True
        Me.DB_IP.Size = New System.Drawing.Size(163, 22)
        Me.DB_IP.TabIndex = 10013
        Me.DB_IP.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.LabelFor = Nothing
        Me.Label3.Location = New System.Drawing.Point(803, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 22)
        Me.Label3.TabIndex = 10012
        Me.Label3.Text = "IP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label3, "IP")
        '
        'USR_PWD
        '
        Me.USR_PWD.BackColor = System.Drawing.SystemColors.Window
        Me.USR_PWD.BorderColor = System.Drawing.Color.Silver
        Me.USR_PWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.USR_PWD.DefVal = ""
        Me.USR_PWD.IsDataStateAware = True
        Me.USR_PWD.Location = New System.Drawing.Point(698, 5)
        Me.USR_PWD.Name = "USR_PWD"
        Me.USR_PWD.NextFocus = "DB_IP"
        Me.USR_PWD.ReadOnly = True
        Me.USR_PWD.Size = New System.Drawing.Size(99, 22)
        Me.USR_PWD.TabIndex = 10011
        Me.USR_PWD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.LabelFor = Nothing
        Me.Label2.Location = New System.Drawing.Point(650, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 22)
        Me.Label2.TabIndex = 10010
        Me.Label2.Text = "PW"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label2, "PW")
        '
        'USR_ID
        '
        Me.USR_ID.BackColor = System.Drawing.SystemColors.Window
        Me.USR_ID.BorderColor = System.Drawing.Color.Silver
        Me.USR_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.USR_ID.DefVal = ""
        Me.USR_ID.IsDataStateAware = True
        Me.USR_ID.Location = New System.Drawing.Point(545, 5)
        Me.USR_ID.Name = "USR_ID"
        Me.USR_ID.NextFocus = "USR_PWD"
        Me.USR_ID.ReadOnly = True
        Me.USR_ID.Size = New System.Drawing.Size(99, 22)
        Me.USR_ID.TabIndex = 10009
        Me.USR_ID.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.LabelFor = Nothing
        Me.Label1.Location = New System.Drawing.Point(514, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 22)
        Me.Label1.TabIndex = 10008
        Me.Label1.Text = "ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label1, "ID")
        '
        'DOMAIN
        '
        Me.DOMAIN.BackColor = System.Drawing.SystemColors.Window
        Me.DOMAIN.BorderColor = System.Drawing.Color.Silver
        Me.DOMAIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DOMAIN.DefVal = ""
        Me.DOMAIN.IsDataStateAware = True
        Me.DOMAIN.Location = New System.Drawing.Point(370, 5)
        Me.DOMAIN.Name = "DOMAIN"
        Me.DOMAIN.NextFocus = "USR_ID"
        Me.DOMAIN.ReadOnly = True
        Me.DOMAIN.Size = New System.Drawing.Size(137, 22)
        Me.DOMAIN.TabIndex = 10007
        Me.DOMAIN.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'LBL_S_SQL_ID
        '
        Me.LBL_S_SQL_ID.AutoEllipsis = True
        Me.LBL_S_SQL_ID.BackColor = System.Drawing.Color.Transparent
        Me.LBL_S_SQL_ID.LabelFor = Nothing
        Me.LBL_S_SQL_ID.Location = New System.Drawing.Point(303, 5)
        Me.LBL_S_SQL_ID.Name = "LBL_S_SQL_ID"
        Me.LBL_S_SQL_ID.Size = New System.Drawing.Size(61, 22)
        Me.LBL_S_SQL_ID.TabIndex = 10006
        Me.LBL_S_SQL_ID.Text = "Domain"
        Me.LBL_S_SQL_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.LBL_S_SQL_ID, "Domain")
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(275, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(22, 25)
        Me.Button4.TabIndex = 10005
        Me.Button4.UseVisualStyleBackColor = True
        Me.Localizer1.SetWordID(Me.Button4, "")
        '
        'CUST_CD
        '
        Me.CUST_CD.AlwaysSetDisplayParams = False
        Me.CUST_CD.AutoSuggestion = False
        Me.CUST_CD.BackColor = System.Drawing.SystemColors.Window
        Me.CUST_CD.BorderColor = System.Drawing.Color.Silver
        Me.CUST_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CUST_CD.CodeType = "YJIT.CodeService.Customer"
        Me.CUST_CD.DataParams = "USE_YN:'Y',NameType:''"
        Me.CUST_CD.DefVal = ""
        Me.CUST_CD.DisplayParams = "Code:@CUST_CD,Name:@CUST_NM,CRN:@CRN,BANK_YN:@BANK_YN"
        Me.CUST_CD.EditPopup = ""
        Me.CUST_CD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CUST_CD.IconVisible = True
        Me.CUST_CD.IsDataStateAware = True
        Me.CUST_CD.KeepIntegrity = True
        Me.CUST_CD.Location = New System.Drawing.Point(72, 5)
        Me.CUST_CD.Name = "CUST_CD"
        Me.CUST_CD.NextFocus = "HBLNO"
        Me.CUST_CD.SearchPopup = "CodeMaster"
        Me.CUST_CD.Size = New System.Drawing.Size(63, 23)
        Me.CUST_CD.SuppressValidateCode = False
        Me.CUST_CD.TabIndex = 10002
        Me.CUST_CD.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.CUST_CD.ValidateKeys = "KEY:@CUST_CD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.LabelFor = Nothing
        Me.Label7.Location = New System.Drawing.Point(30, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 10003
        Me.Label7.Text = "거래처"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label7, "거래처")
        '
        'CUST_NM
        '
        Me.CUST_NM.AutoEllipsis = True
        Me.CUST_NM.BorderColor = System.Drawing.Color.Silver
        Me.CUST_NM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CUST_NM.LabelFor = Nothing
        Me.CUST_NM.Location = New System.Drawing.Point(136, 5)
        Me.CUST_NM.Name = "CUST_NM"
        Me.CUST_NM.Size = New System.Drawing.Size(140, 23)
        Me.CUST_NM.TabIndex = 10004
        Me.CUST_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelControl6
        '
        Me.PanelControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl6.Controls.Add(Me.Label11)
        Me.PanelControl6.Controls.Add(Me.WHCD)
        Me.PanelControl6.Controls.Add(Me.WHNM)
        Me.PanelControl6.Controls.Add(Me.WG_WH)
        Me.PanelControl6.Location = New System.Drawing.Point(3, 6)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(458, 98)
        Me.PanelControl6.TabIndex = 5
        Me.Localizer1.SetWordID(Me.PanelControl6, "")
        '
        'HelpBwsSqlExecuter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.SplitContainerControl3)
        Me.Controls.Add(Me.palAutoButton)
        Me.KeyPreview = True
        Me.Name = "HelpBwsSqlExecuter"
        Me.Text = "보세창고 유지보수 관리"
        Me.Localizer1.SetWordID(Me, "보세창고 유지보수 관리")
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        CType(Me.WG_SQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_SQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.WG_ISU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_ISU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.WG_RCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_RCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3_Num0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3_Num2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3_NUM3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3_Text11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3_Text4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3_Text10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3_Text2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV3_Text1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVR_Button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG_WH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_WH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.xtcExecute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcExecute.ResumeLayout(False)
        Me.xtpExecute.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.splSqlSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG_EXECUTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_EXECUTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.PanelControl6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents btnClear As YJIT.SC.UI.SCControls.Button
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents btnSearch As YJIT.SC.UI.SCControls.Button
    Friend WithEvents xtcExecute As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpExecute As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents btnExecuteReconnect As YJIT.SC.UI.SCControls.Button
    Friend WithEvents splSqlSettings As DevExpress.XtraEditors.PanelControl
    Friend WithEvents S_EXECUTE As YJIT.SC.UI.SCControls.TextBox
    Friend WithEvents WG_EXECUTE As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV_EXECUTE As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents WG_SQL As YJIT.SC.UI.SCControls.WebGrid
    Friend WithEvents GV_SQL As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVS_TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVS_SQL_STR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Button4 As Button
    Private WithEvents CUST_CD As UI.SCControls.CodeBox
    Friend WithEvents Label7 As UI.SCControls.Label
    Public WithEvents CUST_NM As UI.SCControls.TextLabel
    Friend WithEvents USR_PWD As UI.SCControls.TextBox
    Friend WithEvents Label2 As UI.SCControls.Label
    Friend WithEvents USR_ID As UI.SCControls.TextBox
    Friend WithEvents Label1 As UI.SCControls.Label
    Friend WithEvents DOMAIN As UI.SCControls.TextBox
    Friend WithEvents LBL_S_SQL_ID As UI.SCControls.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents MRN As UI.SCControls.MaskedTextBox
    Friend WithEvents btnClear2 As UI.SCControls.Button
    Friend WithEvents Label6 As UI.SCControls.Label
    Public WithEvents HBLNO As UI.SCControls.TextBox
    Friend WithEvents LableHBL As UI.SCControls.Label
    Friend WithEvents CTRY_CD As UI.SCControls.TextBox
    Friend WithEvents DB_SID As UI.SCControls.TextBox
    Friend WithEvents Label5 As UI.SCControls.Label
    Friend WithEvents DB_PORT As UI.SCControls.TextBox
    Friend WithEvents Label4 As UI.SCControls.Label
    Friend WithEvents DB_IP As UI.SCControls.TextBox
    Friend WithEvents Label3 As UI.SCControls.Label
    Public WithEvents ISU_SEND_NO As UI.SCControls.TextBox
    Friend WithEvents Label8 As UI.SCControls.Label
    Friend WithEvents btnUpdateIsu As UI.SCControls.Button
    Public WithEvents GINO As UI.SCControls.TextBox
    Friend WithEvents Label10 As UI.SCControls.Label
    Friend WithEvents WG_ISU As UI.SCControls.WebGrid
    Friend WithEvents GV_ISU As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVI_GINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_RPNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_LICENSE_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_ISSUED_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GVI_WGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GVI_CBM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GVI_EDI_REMARK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_ISU_SEND_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents RCP_SEND_NO As UI.SCControls.TextBox
    Friend WithEvents Label9 As UI.SCControls.Label
    Friend WithEvents btnUpdateRcp As UI.SCControls.Button
    Public WithEvents GRNO As UI.SCControls.TextBox
    Friend WithEvents LableGRNO As UI.SCControls.Label
    Friend WithEvents WG_RCP As UI.SCControls.WebGrid
    Friend WithEvents GV_RCP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVR_GRNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVR_DELNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVR_LICENSE_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVR_QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_Num0 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV3_Text2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GVR_WGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_Num2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GVR_CBM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_NUM3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GVR_EDI_REMARK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVR_RCP_SEND_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV3_Text11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV3_Text4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV3_Text10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV3_Text1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GVR_Button As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSql As UI.SCControls.Button
    Public WithEvents WHNM As UI.SCControls.TextBox
    Public WithEvents WHCD As UI.SCControls.TextBox
    Friend WithEvents Label11 As UI.SCControls.Label
    Friend WithEvents WG_WH As UI.SCControls.WebGrid
    Friend WithEvents GV_WH As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV_WHNM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_WHCD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRefresh As UI.SCControls.Button
    Friend WithEvents GVI_GBUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVR_GBUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label13 As UI.SCControls.Label
    Public WithEvents RPNO As UI.SCControls.TextBox
    Friend WithEvents Label12 As UI.SCControls.Label
    Public WithEvents DELNO As UI.SCControls.TextBox
    Friend WithEvents btnCargoList As UI.SCControls.Button
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
End Class
