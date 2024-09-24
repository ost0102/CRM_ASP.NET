<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BwsCargoList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BwsCargoList))
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.GV_CARGO_EDI_REMARK = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_IN_TRANS_TERM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_DATE = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Localizer1 = New YJIT.SC.UI.SCControls.Localizer(Me.components)
        Me.WHNM = New YJIT.SC.UI.SCControls.TextBox()
        Me.WHCD = New YJIT.SC.UI.SCControls.TextBox()
        Me.Label11 = New YJIT.SC.UI.SCControls.Label()
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
        Me.palAutoButton = New DevExpress.XtraEditors.PanelControl()
        Me.btnNew = New YJIT.SC.UI.SCControls.Button()
        Me.btnSearch = New YJIT.SC.UI.SCControls.Button()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.WG_DO = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_DO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV_DO_LICENSE_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_DO_RPNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_DO_DO_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_DO_QTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_DO_WGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_DO_DO_DT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WG_ISU = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_ISU = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GVI_GINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_RPNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_LICENSE_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_ISSUED_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_QTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_WGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_CBM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_EDI_REMARK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_EDI_SEND_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVI_GI_DT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WG_CNTR = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_CNTR = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GV_CNTR_CNTRNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_Text11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV_CNTR_CNTRTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_Text4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV_CNTR_SEAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_Text10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV_CNTR_SEAL2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV_CNTR_QTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_Num0 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV_CNTR_UNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_Text2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV_CNTR_WGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_Num2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV_CNTR_CBM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GV2_Text1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WG_CARGO = New YJIT.SC.UI.SCControls.WebGrid()
        Me.GV_CARGO = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV_CARGO_GRNO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_GR_DT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_GR_TM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_TIME = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GV_CARGO_MRNNO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_HBLNO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_VENDORNM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_BUYERNM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_FWDNM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_RECV_TYPE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_DNG_YN = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_TS_YN = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV_CARGO_QTY = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_GWT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_CWT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV_CARGO_GR_QTY = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_GR_WGT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_GR_CBM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.GV_CARGO_CNTRNO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_MRN = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_MSN = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_HSN = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_DELNO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_HADT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_ETA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_VESSEL = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_PLT_NO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_GOODS_NM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_CNT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_GR_RMK = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_EDI_INS_REMARK = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV_CARGO_EDI_STATUS = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GV1_ChkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.DATE_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.REF_NO = New YJIT.SC.UI.SCControls.TextBox()
        Me.REF_TYPE = New YJIT.SC.UI.SCControls.ComboBox()
        Me.Label50 = New YJIT.SC.UI.SCControls.Label()
        Me.TO_DT = New YJIT.SC.UI.SCControls.DateBox()
        Me.FROM_DT = New YJIT.SC.UI.SCControls.DateBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.GV1_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.palAutoButton.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.WG_DO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG_ISU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_ISU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG_CNTR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_CNTR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2_Text11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2_Text4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2_Text10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2_Num0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2_Text2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2_Num2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV2_Text1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WG_CARGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_CARGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1_TIME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV1_ChkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV_CARGO_EDI_REMARK
        '
        Me.GV_CARGO_EDI_REMARK.Caption = "전송결과"
        Me.GV_CARGO_EDI_REMARK.FieldName = "EDI_REMARK"
        Me.GV_CARGO_EDI_REMARK.Name = "GV_CARGO_EDI_REMARK"
        Me.GV_CARGO_EDI_REMARK.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_EDI_REMARK.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_EDI_REMARK.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_EDI_REMARK.Visible = True
        Me.GV_CARGO_EDI_REMARK.Width = 154
        Me.Localizer1.SetWordID(Me.GV_CARGO_EDI_REMARK, "전송결과")
        '
        'GV_CARGO_IN_TRANS_TERM
        '
        Me.GV_CARGO_IN_TRANS_TERM.Caption = "운송기한"
        Me.GV_CARGO_IN_TRANS_TERM.ColumnEdit = Me.GV1_DATE
        Me.GV_CARGO_IN_TRANS_TERM.FieldName = "IN_TRANS_TERM"
        Me.GV_CARGO_IN_TRANS_TERM.Name = "GV_CARGO_IN_TRANS_TERM"
        Me.GV_CARGO_IN_TRANS_TERM.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_IN_TRANS_TERM.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_IN_TRANS_TERM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_IN_TRANS_TERM.Width = 90
        Me.Localizer1.SetWordID(Me.GV_CARGO_IN_TRANS_TERM, "운송기한")
        '
        'GV1_DATE
        '
        Me.GV1_DATE.AutoHeight = False
        Me.GV1_DATE.Mask.EditMask = "9999-99-99"
        Me.GV1_DATE.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.GV1_DATE.Mask.UseMaskAsDisplayFormat = True
        Me.GV1_DATE.Name = "GV1_DATE"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Mask.EditMask = "#,###,###,##0"
        Me.RepositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit7.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.Mask.EditMask = "###,###,##0.000"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.Mask.EditMask = "###,###,##0.000"
        Me.RepositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit9.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.MaxLength = 11
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 4
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "#,###,###,##0"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.MaxLength = 2
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Mask.EditMask = "###,###,##0.00"
        Me.RepositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit5.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemTextEdit6.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.AutoHeight = False
        Me.RepositoryItemTextEdit10.Mask.EditMask = "9999-99-99"
        Me.RepositoryItemTextEdit10.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemTextEdit10.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit10.MaxLength = 1
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'Localizer1
        '
        Me.Localizer1.ResourceManager = Nothing
        Me.Localizer1.SetWordID(Me.GV_CARGO_EDI_REMARK, "전송결과")
        Me.Localizer1.SetWordID(Me.GV_CARGO_IN_TRANS_TERM, "운송기한")
        Me.Localizer1.SetWordID(Me.WHNM, "")
        Me.Localizer1.SetWordID(Me.WHCD, "")
        Me.Localizer1.SetWordID(Me.Label11, "창고코드")
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
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        Me.Localizer1.SetWordID(Me.WG_DO, "")
        Me.Localizer1.SetWordID(Me.GV_DO_LICENSE_NO, "근거번호")
        Me.Localizer1.SetWordID(Me.GV_DO_RPNO, "반출승인번호")
        Me.Localizer1.SetWordID(Me.GV_DO_DO_TYPE, "승인유형")
        Me.Localizer1.SetWordID(Me.GV_DO_QTY, "수량")
        Me.Localizer1.SetWordID(Me.GV_DO_WGT, "중량")
        Me.Localizer1.SetWordID(Me.GV_DO_DO_DT, "승인일자")
        Me.Localizer1.SetWordID(Me.WG_ISU, "")
        Me.Localizer1.SetWordID(Me.GVI_GINO, "반출번호")
        Me.Localizer1.SetWordID(Me.GVI_RPNO, "반출승인번호")
        Me.Localizer1.SetWordID(Me.GVI_LICENSE_NO, "근거번호")
        Me.Localizer1.SetWordID(Me.GVI_ISSUED_TYPE, "반출구분")
        Me.Localizer1.SetWordID(Me.GVI_QTY, "수량")
        Me.Localizer1.SetWordID(Me.GVI_WGT, "중량")
        Me.Localizer1.SetWordID(Me.GVI_CBM, "용적")
        Me.Localizer1.SetWordID(Me.GVI_EDI_REMARK, "전송결과")
        Me.Localizer1.SetWordID(Me.GVI_EDI_SEND_NO, "신고번호")
        Me.Localizer1.SetWordID(Me.GVI_GI_DT, "반출일자")
        Me.Localizer1.SetWordID(Me.WG_CNTR, "")
        Me.Localizer1.SetWordID(Me.GV_CNTR_CNTRNO, "컨테이너 번호")
        Me.Localizer1.SetWordID(Me.GV_CNTR_CNTRTYPE, "타입")
        Me.Localizer1.SetWordID(Me.GV_CNTR_SEAL1, "Seal No1")
        Me.Localizer1.SetWordID(Me.GV_CNTR_SEAL2, "Seal No2")
        Me.Localizer1.SetWordID(Me.GV_CNTR_QTY, "수량")
        Me.Localizer1.SetWordID(Me.GV_CNTR_UNIT, "단위")
        Me.Localizer1.SetWordID(Me.GV_CNTR_WGT, "중량")
        Me.Localizer1.SetWordID(Me.GV_CNTR_CBM, "용적")
        Me.Localizer1.SetWordID(Me.WG_CARGO, "")
        Me.Localizer1.SetWordID(Me.GridBand1, "반입정보")
        Me.Localizer1.SetWordID(Me.GV_CARGO_GRNO, "반입번호")
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_DT, "반입일자")
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_TM, "시간")
        Me.Localizer1.SetWordID(Me.GV_CARGO_MRNNO, "화물관리번호")
        Me.Localizer1.SetWordID(Me.GV_CARGO_HBLNO, "House B/L")
        Me.Localizer1.SetWordID(Me.GV_CARGO_VENDORNM, "화주")
        Me.Localizer1.SetWordID(Me.GV_CARGO_BUYERNM, "수화인")
        Me.Localizer1.SetWordID(Me.GV_CARGO_FWDNM, "포워더")
        Me.Localizer1.SetWordID(Me.GV_CARGO_RECV_TYPE, "반입구분")
        Me.Localizer1.SetWordID(Me.GV_CARGO_DNG_YN, "DNG")
        Me.Localizer1.SetWordID(Me.GV_CARGO_TS_YN, "TS")
        Me.Localizer1.SetWordID(Me.gridBand2, "반입예정")
        Me.Localizer1.SetWordID(Me.GV_CARGO_QTY, "수량")
        Me.Localizer1.SetWordID(Me.GV_CARGO_GWT, "중량")
        Me.Localizer1.SetWordID(Me.GV_CARGO_CWT, "용적")
        Me.Localizer1.SetWordID(Me.gridBand3, "반입")
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_QTY, "수량")
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_WGT, "중량")
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_CBM, "용적")
        Me.Localizer1.SetWordID(Me.gridBand4, "기타 정보")
        Me.Localizer1.SetWordID(Me.GV_CARGO_CNTRNO, "컨테이너번호")
        Me.Localizer1.SetWordID(Me.GV_CARGO_MRN, "MRN")
        Me.Localizer1.SetWordID(Me.GV_CARGO_MSN, "MSN")
        Me.Localizer1.SetWordID(Me.GV_CARGO_HSN, "HSN")
        Me.Localizer1.SetWordID(Me.GV_CARGO_DELNO, "반입예정번호")
        Me.Localizer1.SetWordID(Me.GV_CARGO_HADT, "반입예정일자")
        Me.Localizer1.SetWordID(Me.GV_CARGO_ETA, "입항일자")
        Me.Localizer1.SetWordID(Me.GV_CARGO_VESSEL, "선명")
        Me.Localizer1.SetWordID(Me.GV_CARGO_PLT_NO, "장치위치")
        Me.Localizer1.SetWordID(Me.GV_CARGO_GOODS_NM, "품명")
        Me.Localizer1.SetWordID(Me.GV_CARGO_CNT, "컨테이너 수량")
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_RMK, "비고")
        Me.Localizer1.SetWordID(Me.GV_CARGO_EDI_INS_REMARK, "보험료 전송결과")
        Me.Localizer1.SetWordID(Me.GV_CARGO_EDI_STATUS, "EDI_STATUS")
        Me.Localizer1.SetWordID(Me.GroupControl3, "조회 조건")
        Me.Localizer1.SetWordID(Me.DATE_TYPE, "House B/L")
        Me.Localizer1.SetWordID(Me.REF_NO, "")
        Me.Localizer1.SetWordID(Me.REF_TYPE, "House B/L")
        Me.Localizer1.SetWordID(Me.Label50, "/")
        Me.Localizer1.SetWordID(Me.TO_DT, "")
        Me.Localizer1.SetWordID(Me.FROM_DT, "")
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        '
        'WHNM
        '
        Me.WHNM.BorderColor = System.Drawing.Color.Silver
        Me.WHNM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WHNM.DefVal = ""
        Me.WHNM.IsDataStateAware = True
        Me.WHNM.Location = New System.Drawing.Point(131, 23)
        Me.WHNM.MaxLength = 50
        Me.WHNM.Name = "WHNM"
        Me.WHNM.NextFocus = "MRN"
        Me.WHNM.ReadOnly = True
        Me.WHNM.Size = New System.Drawing.Size(139, 22)
        Me.WHNM.TabIndex = 354
        Me.WHNM.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'WHCD
        '
        Me.WHCD.BorderColor = System.Drawing.Color.Silver
        Me.WHCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WHCD.DefVal = ""
        Me.WHCD.IsDataStateAware = True
        Me.WHCD.Location = New System.Drawing.Point(66, 23)
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
        Me.Label11.Location = New System.Drawing.Point(1, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 22)
        Me.Label11.TabIndex = 353
        Me.Label11.Text = "창고"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Localizer1.SetWordID(Me.Label11, "창고코드")
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
        Me.CUST_CD.ReadOnly = True
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
        'palAutoButton
        '
        Me.palAutoButton.Controls.Add(Me.btnNew)
        Me.palAutoButton.Controls.Add(Me.btnSearch)
        Me.palAutoButton.Location = New System.Drawing.Point(6, 7)
        Me.palAutoButton.Name = "palAutoButton"
        Me.palAutoButton.Size = New System.Drawing.Size(1252, 35)
        Me.palAutoButton.TabIndex = 15
        Me.Localizer1.SetWordID(Me.palAutoButton, "")
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.ButtonType = YJIT.SC.UI.ButtonTypes.[New]
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(1075, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(83, 28)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "&New"
        Me.Localizer1.SetWordID(Me.btnNew, "&New")
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ButtonType = YJIT.SC.UI.ButtonTypes.Search
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1164, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(83, 28)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Se&arch"
        Me.Localizer1.SetWordID(Me.btnSearch, "Se&arch")
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.PanelControl5)
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.WG_CARGO)
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 81)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1252, 645)
        Me.PanelControl1.TabIndex = 16
        Me.Localizer1.SetWordID(Me.PanelControl1, "")
        '
        'WG_DO
        '
        Me.WG_DO.AllowClientBinding = True
        Me.WG_DO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_DO.DeleteRowConfirmation = True
        Me.WG_DO.DisplayCurrentRow = False
        Me.WG_DO.IsDataStateAware = True
        Me.WG_DO.Location = New System.Drawing.Point(5, 0)
        Me.WG_DO.MainView = Me.GV_DO
        Me.WG_DO.Name = "WG_DO"
        Me.WG_DO.SaveLayout = False
        Me.WG_DO.Size = New System.Drawing.Size(391, 112)
        Me.WG_DO.TabIndex = 347
        Me.WG_DO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_DO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_DO})
        '
        'GV_DO
        '
        Me.GV_DO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV_DO_LICENSE_NO, Me.GV_DO_RPNO, Me.GV_DO_DO_TYPE, Me.GV_DO_QTY, Me.GV_DO_WGT, Me.GV_DO_DO_DT})
        Me.GV_DO.GridControl = Me.WG_DO
        Me.GV_DO.Name = "GV_DO"
        Me.GV_DO.OptionsBehavior.Editable = False
        Me.GV_DO.OptionsBehavior.ReadOnly = True
        Me.GV_DO.OptionsView.ColumnAutoWidth = False
        Me.GV_DO.OptionsView.ShowGroupPanel = False
        '
        'GV_DO_LICENSE_NO
        '
        Me.GV_DO_LICENSE_NO.Caption = "근거번호"
        Me.GV_DO_LICENSE_NO.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GV_DO_LICENSE_NO.FieldName = "LICENSE_NO"
        Me.GV_DO_LICENSE_NO.Name = "GV_DO_LICENSE_NO"
        Me.GV_DO_LICENSE_NO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_DO_LICENSE_NO.Visible = True
        Me.GV_DO_LICENSE_NO.VisibleIndex = 2
        Me.GV_DO_LICENSE_NO.Width = 95
        Me.Localizer1.SetWordID(Me.GV_DO_LICENSE_NO, "근거번호")
        '
        'GV_DO_RPNO
        '
        Me.GV_DO_RPNO.Caption = "반출승인번호"
        Me.GV_DO_RPNO.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GV_DO_RPNO.FieldName = "RPNO"
        Me.GV_DO_RPNO.Name = "GV_DO_RPNO"
        Me.GV_DO_RPNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_DO_RPNO.Visible = True
        Me.GV_DO_RPNO.VisibleIndex = 3
        Me.GV_DO_RPNO.Width = 118
        Me.Localizer1.SetWordID(Me.GV_DO_RPNO, "반출승인번호")
        '
        'GV_DO_DO_TYPE
        '
        Me.GV_DO_DO_TYPE.Caption = "승인유형"
        Me.GV_DO_DO_TYPE.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GV_DO_DO_TYPE.FieldName = "DO_TYPE"
        Me.GV_DO_DO_TYPE.Name = "GV_DO_DO_TYPE"
        Me.GV_DO_DO_TYPE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_DO_DO_TYPE.Visible = True
        Me.GV_DO_DO_TYPE.VisibleIndex = 5
        Me.GV_DO_DO_TYPE.Width = 50
        Me.Localizer1.SetWordID(Me.GV_DO_DO_TYPE, "승인유형")
        '
        'GV_DO_QTY
        '
        Me.GV_DO_QTY.AppearanceCell.Options.UseTextOptions = True
        Me.GV_DO_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV_DO_QTY.Caption = "수량"
        Me.GV_DO_QTY.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.GV_DO_QTY.FieldName = "QTY"
        Me.GV_DO_QTY.Name = "GV_DO_QTY"
        Me.GV_DO_QTY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_DO_QTY.Visible = True
        Me.GV_DO_QTY.VisibleIndex = 0
        Me.GV_DO_QTY.Width = 60
        Me.Localizer1.SetWordID(Me.GV_DO_QTY, "수량")
        '
        'GV_DO_WGT
        '
        Me.GV_DO_WGT.AppearanceCell.Options.UseTextOptions = True
        Me.GV_DO_WGT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV_DO_WGT.Caption = "중량"
        Me.GV_DO_WGT.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.GV_DO_WGT.FieldName = "WGT"
        Me.GV_DO_WGT.Name = "GV_DO_WGT"
        Me.GV_DO_WGT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_DO_WGT.Visible = True
        Me.GV_DO_WGT.VisibleIndex = 1
        Me.GV_DO_WGT.Width = 80
        Me.Localizer1.SetWordID(Me.GV_DO_WGT, "중량")
        '
        'GV_DO_DO_DT
        '
        Me.GV_DO_DO_DT.Caption = "승인일자"
        Me.GV_DO_DO_DT.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.GV_DO_DO_DT.Name = "GV_DO_DO_DT"
        Me.GV_DO_DO_DT.Visible = True
        Me.GV_DO_DO_DT.VisibleIndex = 4
        Me.GV_DO_DO_DT.Width = 83
        Me.Localizer1.SetWordID(Me.GV_DO_DO_DT, "")
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
        Me.WG_ISU.Location = New System.Drawing.Point(4, 5)
        Me.WG_ISU.MainView = Me.GV_ISU
        Me.WG_ISU.Name = "WG_ISU"
        Me.WG_ISU.SaveLayout = False
        Me.WG_ISU.Size = New System.Drawing.Size(829, 235)
        Me.WG_ISU.TabIndex = 346
        Me.WG_ISU.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_ISU.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_ISU, Me.GridView2})
        '
        'GV_ISU
        '
        Me.GV_ISU.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GVI_GINO, Me.GVI_RPNO, Me.GVI_LICENSE_NO, Me.GVI_ISSUED_TYPE, Me.GVI_QTY, Me.GVI_WGT, Me.GVI_CBM, Me.GVI_EDI_REMARK, Me.GVI_EDI_SEND_NO, Me.GVI_GI_DT})
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
        Me.GVI_GINO.Name = "GVI_GINO"
        Me.GVI_GINO.OptionsColumn.AllowEdit = False
        Me.GVI_GINO.OptionsColumn.ReadOnly = True
        Me.GVI_GINO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_GINO.Visible = True
        Me.GVI_GINO.VisibleIndex = 3
        Me.GVI_GINO.Width = 100
        Me.Localizer1.SetWordID(Me.GVI_GINO, "반출번호")
        '
        'GVI_RPNO
        '
        Me.GVI_RPNO.Caption = "반출승인번호"
        Me.GVI_RPNO.FieldName = "RPNO"
        Me.GVI_RPNO.Name = "GVI_RPNO"
        Me.GVI_RPNO.OptionsColumn.AllowEdit = False
        Me.GVI_RPNO.OptionsColumn.ReadOnly = True
        Me.GVI_RPNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_RPNO.Visible = True
        Me.GVI_RPNO.VisibleIndex = 9
        Me.GVI_RPNO.Width = 107
        Me.Localizer1.SetWordID(Me.GVI_RPNO, "")
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
        Me.GVI_LICENSE_NO.VisibleIndex = 7
        Me.GVI_LICENSE_NO.Width = 97
        Me.Localizer1.SetWordID(Me.GVI_LICENSE_NO, "")
        '
        'GVI_ISSUED_TYPE
        '
        Me.GVI_ISSUED_TYPE.Caption = "반출구분"
        Me.GVI_ISSUED_TYPE.FieldName = "ISSUED_TYPE"
        Me.GVI_ISSUED_TYPE.Name = "GVI_ISSUED_TYPE"
        Me.GVI_ISSUED_TYPE.OptionsColumn.AllowEdit = False
        Me.GVI_ISSUED_TYPE.OptionsColumn.ReadOnly = True
        Me.GVI_ISSUED_TYPE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_ISSUED_TYPE.Visible = True
        Me.GVI_ISSUED_TYPE.VisibleIndex = 8
        Me.Localizer1.SetWordID(Me.GVI_ISSUED_TYPE, "")
        '
        'GVI_QTY
        '
        Me.GVI_QTY.AppearanceCell.Options.UseTextOptions = True
        Me.GVI_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GVI_QTY.Caption = "수량"
        Me.GVI_QTY.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.GVI_QTY.FieldName = "QTY"
        Me.GVI_QTY.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GVI_QTY.Name = "GVI_QTY"
        Me.GVI_QTY.OptionsColumn.AllowEdit = False
        Me.GVI_QTY.OptionsColumn.ReadOnly = True
        Me.GVI_QTY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_QTY.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QTY", "SUM={0:0}")})
        Me.GVI_QTY.Visible = True
        Me.GVI_QTY.VisibleIndex = 0
        Me.GVI_QTY.Width = 65
        Me.Localizer1.SetWordID(Me.GVI_QTY, "수량")
        '
        'GVI_WGT
        '
        Me.GVI_WGT.AppearanceCell.Options.UseTextOptions = True
        Me.GVI_WGT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GVI_WGT.Caption = "중량"
        Me.GVI_WGT.ColumnEdit = Me.RepositoryItemTextEdit8
        Me.GVI_WGT.FieldName = "WGT"
        Me.GVI_WGT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GVI_WGT.Name = "GVI_WGT"
        Me.GVI_WGT.OptionsColumn.AllowEdit = False
        Me.GVI_WGT.OptionsColumn.ReadOnly = True
        Me.GVI_WGT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_WGT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "WGT", "SUM={0:0.###}")})
        Me.GVI_WGT.Visible = True
        Me.GVI_WGT.VisibleIndex = 1
        Me.GVI_WGT.Width = 85
        Me.Localizer1.SetWordID(Me.GVI_WGT, "중량")
        '
        'GVI_CBM
        '
        Me.GVI_CBM.AppearanceCell.Options.UseTextOptions = True
        Me.GVI_CBM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GVI_CBM.Caption = "용적"
        Me.GVI_CBM.ColumnEdit = Me.RepositoryItemTextEdit9
        Me.GVI_CBM.FieldName = "CBM"
        Me.GVI_CBM.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GVI_CBM.Name = "GVI_CBM"
        Me.GVI_CBM.OptionsColumn.AllowEdit = False
        Me.GVI_CBM.OptionsColumn.ReadOnly = True
        Me.GVI_CBM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_CBM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CBM", "SUM={0:0.###}")})
        Me.GVI_CBM.Visible = True
        Me.GVI_CBM.VisibleIndex = 2
        Me.GVI_CBM.Width = 80
        Me.Localizer1.SetWordID(Me.GVI_CBM, "용적")
        '
        'GVI_EDI_REMARK
        '
        Me.GVI_EDI_REMARK.Caption = "전송결과"
        Me.GVI_EDI_REMARK.FieldName = "EDI_REMARK"
        Me.GVI_EDI_REMARK.Name = "GVI_EDI_REMARK"
        Me.GVI_EDI_REMARK.OptionsColumn.AllowEdit = False
        Me.GVI_EDI_REMARK.OptionsColumn.ReadOnly = True
        Me.GVI_EDI_REMARK.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_EDI_REMARK.Visible = True
        Me.GVI_EDI_REMARK.VisibleIndex = 5
        Me.GVI_EDI_REMARK.Width = 119
        Me.Localizer1.SetWordID(Me.GVI_EDI_REMARK, "")
        '
        'GVI_EDI_SEND_NO
        '
        Me.GVI_EDI_SEND_NO.Caption = "신고번호"
        Me.GVI_EDI_SEND_NO.FieldName = "SEND_NO"
        Me.GVI_EDI_SEND_NO.Name = "GVI_EDI_SEND_NO"
        Me.GVI_EDI_SEND_NO.OptionsColumn.AllowEdit = False
        Me.GVI_EDI_SEND_NO.OptionsColumn.ReadOnly = True
        Me.GVI_EDI_SEND_NO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_EDI_SEND_NO.Visible = True
        Me.GVI_EDI_SEND_NO.VisibleIndex = 6
        Me.GVI_EDI_SEND_NO.Width = 144
        Me.Localizer1.SetWordID(Me.GVI_EDI_SEND_NO, "")
        '
        'GVI_GI_DT
        '
        Me.GVI_GI_DT.Caption = "반출일자"
        Me.GVI_GI_DT.ColumnEdit = Me.RepositoryItemTextEdit10
        Me.GVI_GI_DT.FieldName = "GI_DT"
        Me.GVI_GI_DT.Name = "GVI_GI_DT"
        Me.GVI_GI_DT.OptionsColumn.AllowEdit = False
        Me.GVI_GI_DT.OptionsColumn.ReadOnly = True
        Me.GVI_GI_DT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GVI_GI_DT.Visible = True
        Me.GVI_GI_DT.VisibleIndex = 4
        Me.Localizer1.SetWordID(Me.GVI_GI_DT, "")
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.WG_ISU
        Me.GridView2.Name = "GridView2"
        '
        'WG_CNTR
        '
        Me.WG_CNTR.AllowClientBinding = True
        Me.WG_CNTR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_CNTR.DeleteRowConfirmation = True
        Me.WG_CNTR.DisplayCurrentRow = False
        Me.WG_CNTR.IsDataStateAware = True
        Me.WG_CNTR.Location = New System.Drawing.Point(5, 5)
        Me.WG_CNTR.MainView = Me.GV_CNTR
        Me.WG_CNTR.Name = "WG_CNTR"
        Me.WG_CNTR.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GV2_Text11, Me.GV2_Text4, Me.GV2_Text10, Me.GV2_Num0, Me.GV2_Text2, Me.GV2_Num2, Me.GV2_Text1})
        Me.WG_CNTR.SaveLayout = False
        Me.WG_CNTR.Size = New System.Drawing.Size(391, 117)
        Me.WG_CNTR.TabIndex = 181
        Me.WG_CNTR.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_CNTR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_CNTR})
        '
        'GV_CNTR
        '
        Me.GV_CNTR.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GV_CNTR_CNTRNO, Me.GV_CNTR_CNTRTYPE, Me.GV_CNTR_SEAL1, Me.GV_CNTR_SEAL2, Me.GV_CNTR_QTY, Me.GV_CNTR_UNIT, Me.GV_CNTR_WGT, Me.GV_CNTR_CBM})
        Me.GV_CNTR.GridControl = Me.WG_CNTR
        Me.GV_CNTR.Name = "GV_CNTR"
        Me.GV_CNTR.OptionsBehavior.Editable = False
        Me.GV_CNTR.OptionsBehavior.ReadOnly = True
        Me.GV_CNTR.OptionsView.ColumnAutoWidth = False
        Me.GV_CNTR.OptionsView.ShowGroupPanel = False
        '
        'GV_CNTR_CNTRNO
        '
        Me.GV_CNTR_CNTRNO.Caption = "컨테이너 번호"
        Me.GV_CNTR_CNTRNO.ColumnEdit = Me.GV2_Text11
        Me.GV_CNTR_CNTRNO.FieldName = "CNTRNO"
        Me.GV_CNTR_CNTRNO.Name = "GV_CNTR_CNTRNO"
        Me.GV_CNTR_CNTRNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CNTR_CNTRNO.Visible = True
        Me.GV_CNTR_CNTRNO.VisibleIndex = 0
        Me.GV_CNTR_CNTRNO.Width = 95
        Me.Localizer1.SetWordID(Me.GV_CNTR_CNTRNO, "컨테이너 번호")
        '
        'GV2_Text11
        '
        Me.GV2_Text11.AutoHeight = False
        Me.GV2_Text11.MaxLength = 11
        Me.GV2_Text11.Name = "GV2_Text11"
        '
        'GV_CNTR_CNTRTYPE
        '
        Me.GV_CNTR_CNTRTYPE.Caption = "타입"
        Me.GV_CNTR_CNTRTYPE.ColumnEdit = Me.GV2_Text4
        Me.GV_CNTR_CNTRTYPE.FieldName = "CNTRTYPE"
        Me.GV_CNTR_CNTRTYPE.Name = "GV_CNTR_CNTRTYPE"
        Me.GV_CNTR_CNTRTYPE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CNTR_CNTRTYPE.Visible = True
        Me.GV_CNTR_CNTRTYPE.VisibleIndex = 1
        Me.GV_CNTR_CNTRTYPE.Width = 55
        Me.Localizer1.SetWordID(Me.GV_CNTR_CNTRTYPE, "타입")
        '
        'GV2_Text4
        '
        Me.GV2_Text4.AutoHeight = False
        Me.GV2_Text4.MaxLength = 4
        Me.GV2_Text4.Name = "GV2_Text4"
        '
        'GV_CNTR_SEAL1
        '
        Me.GV_CNTR_SEAL1.Caption = "Seal No1"
        Me.GV_CNTR_SEAL1.ColumnEdit = Me.GV2_Text10
        Me.GV_CNTR_SEAL1.FieldName = "SEAL1"
        Me.GV_CNTR_SEAL1.Name = "GV_CNTR_SEAL1"
        Me.GV_CNTR_SEAL1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CNTR_SEAL1.Visible = True
        Me.GV_CNTR_SEAL1.VisibleIndex = 2
        Me.GV_CNTR_SEAL1.Width = 80
        Me.Localizer1.SetWordID(Me.GV_CNTR_SEAL1, "Seal No1")
        '
        'GV2_Text10
        '
        Me.GV2_Text10.AutoHeight = False
        Me.GV2_Text10.MaxLength = 10
        Me.GV2_Text10.Name = "GV2_Text10"
        '
        'GV_CNTR_SEAL2
        '
        Me.GV_CNTR_SEAL2.Caption = "Seal No2"
        Me.GV_CNTR_SEAL2.ColumnEdit = Me.GV2_Text10
        Me.GV_CNTR_SEAL2.FieldName = "SEAL2"
        Me.GV_CNTR_SEAL2.Name = "GV_CNTR_SEAL2"
        Me.GV_CNTR_SEAL2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CNTR_SEAL2.Visible = True
        Me.GV_CNTR_SEAL2.VisibleIndex = 3
        Me.GV_CNTR_SEAL2.Width = 80
        Me.Localizer1.SetWordID(Me.GV_CNTR_SEAL2, "Seal No2")
        '
        'GV_CNTR_QTY
        '
        Me.GV_CNTR_QTY.AppearanceCell.Options.UseTextOptions = True
        Me.GV_CNTR_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV_CNTR_QTY.Caption = "수량"
        Me.GV_CNTR_QTY.ColumnEdit = Me.GV2_Num0
        Me.GV_CNTR_QTY.FieldName = "QTY"
        Me.GV_CNTR_QTY.Name = "GV_CNTR_QTY"
        Me.GV_CNTR_QTY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CNTR_QTY.Visible = True
        Me.GV_CNTR_QTY.VisibleIndex = 4
        Me.GV_CNTR_QTY.Width = 60
        Me.Localizer1.SetWordID(Me.GV_CNTR_QTY, "수량")
        '
        'GV2_Num0
        '
        Me.GV2_Num0.AutoHeight = False
        Me.GV2_Num0.Mask.EditMask = "#,###,###,##0"
        Me.GV2_Num0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.GV2_Num0.Mask.UseMaskAsDisplayFormat = True
        Me.GV2_Num0.Name = "GV2_Num0"
        '
        'GV_CNTR_UNIT
        '
        Me.GV_CNTR_UNIT.Caption = "단위"
        Me.GV_CNTR_UNIT.ColumnEdit = Me.GV2_Text2
        Me.GV_CNTR_UNIT.FieldName = "UNIT"
        Me.GV_CNTR_UNIT.Name = "GV_CNTR_UNIT"
        Me.GV_CNTR_UNIT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CNTR_UNIT.Visible = True
        Me.GV_CNTR_UNIT.VisibleIndex = 5
        Me.GV_CNTR_UNIT.Width = 50
        Me.Localizer1.SetWordID(Me.GV_CNTR_UNIT, "단위")
        '
        'GV2_Text2
        '
        Me.GV2_Text2.AutoHeight = False
        Me.GV2_Text2.MaxLength = 2
        Me.GV2_Text2.Name = "GV2_Text2"
        '
        'GV_CNTR_WGT
        '
        Me.GV_CNTR_WGT.AppearanceCell.Options.UseTextOptions = True
        Me.GV_CNTR_WGT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV_CNTR_WGT.Caption = "중량"
        Me.GV_CNTR_WGT.ColumnEdit = Me.GV2_Num2
        Me.GV_CNTR_WGT.FieldName = "WGT"
        Me.GV_CNTR_WGT.Name = "GV_CNTR_WGT"
        Me.GV_CNTR_WGT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CNTR_WGT.Visible = True
        Me.GV_CNTR_WGT.VisibleIndex = 6
        Me.GV_CNTR_WGT.Width = 80
        Me.Localizer1.SetWordID(Me.GV_CNTR_WGT, "중량")
        '
        'GV2_Num2
        '
        Me.GV2_Num2.AutoHeight = False
        Me.GV2_Num2.Mask.EditMask = "###,###,##0.00"
        Me.GV2_Num2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.GV2_Num2.Mask.UseMaskAsDisplayFormat = True
        Me.GV2_Num2.Name = "GV2_Num2"
        '
        'GV_CNTR_CBM
        '
        Me.GV_CNTR_CBM.AppearanceCell.Options.UseTextOptions = True
        Me.GV_CNTR_CBM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GV_CNTR_CBM.Caption = "용적"
        Me.GV_CNTR_CBM.ColumnEdit = Me.GV2_Num2
        Me.GV_CNTR_CBM.FieldName = "CBM"
        Me.GV_CNTR_CBM.Name = "GV_CNTR_CBM"
        Me.GV_CNTR_CBM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CNTR_CBM.Visible = True
        Me.GV_CNTR_CBM.VisibleIndex = 7
        Me.GV_CNTR_CBM.Width = 70
        Me.Localizer1.SetWordID(Me.GV_CNTR_CBM, "용적")
        '
        'GV2_Text1
        '
        Me.GV2_Text1.AutoHeight = False
        Me.GV2_Text1.MaxLength = 1
        Me.GV2_Text1.Name = "GV2_Text1"
        '
        'WG_CARGO
        '
        Me.WG_CARGO.AllowClientBinding = True
        Me.WG_CARGO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WG_CARGO.DeleteRowConfirmation = True
        Me.WG_CARGO.DisplayCurrentRow = False
        Me.WG_CARGO.IsDataStateAware = True
        Me.WG_CARGO.Location = New System.Drawing.Point(6, 61)
        Me.WG_CARGO.MainView = Me.GV_CARGO
        Me.WG_CARGO.Name = "WG_CARGO"
        Me.WG_CARGO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GV1_DATE, Me.GV1_ChkEdit, Me.GV1_TIME})
        Me.WG_CARGO.SaveLayout = True
        Me.WG_CARGO.Size = New System.Drawing.Size(1241, 328)
        Me.WG_CARGO.TabIndex = 77
        Me.WG_CARGO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.WG_CARGO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_CARGO})
        '
        'GV_CARGO
        '
        Me.GV_CARGO.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GV_CARGO.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GV_CARGO.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2, Me.gridBand3, Me.gridBand4})
        Me.GV_CARGO.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.GV_CARGO_DELNO, Me.GV_CARGO_GRNO, Me.GV_CARGO_GR_DT, Me.GV_CARGO_GR_TM, Me.GV_CARGO_RECV_TYPE, Me.GV_CARGO_MRNNO, Me.GV_CARGO_HBLNO, Me.GV_CARGO_BUYERNM, Me.GV_CARGO_ETA, Me.GV_CARGO_VESSEL, Me.GV_CARGO_HADT, Me.GV_CARGO_GOODS_NM, Me.GV_CARGO_QTY, Me.GV_CARGO_GWT, Me.GV_CARGO_CWT, Me.GV_CARGO_GR_QTY, Me.GV_CARGO_GR_WGT, Me.GV_CARGO_GR_CBM, Me.GV_CARGO_VENDORNM, Me.GV_CARGO_PLT_NO, Me.GV_CARGO_MRN, Me.GV_CARGO_MSN, Me.GV_CARGO_HSN, Me.GV_CARGO_FWDNM, Me.GV_CARGO_TS_YN, Me.GV_CARGO_CNT, Me.GV_CARGO_DNG_YN, Me.GV_CARGO_GR_RMK, Me.GV_CARGO_CNTRNO, Me.GV_CARGO_IN_TRANS_TERM, Me.GV_CARGO_EDI_REMARK, Me.GV_CARGO_EDI_INS_REMARK, Me.GV_CARGO_EDI_STATUS})
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.GV_CARGO_EDI_REMARK
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Expression = "Trim([EDI_REMARK]) != '접수통보'"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.LightGreen
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.GV_CARGO_IN_TRANS_TERM
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition4.Expression = "[IN_TRANS_TERM] <= Replace(Today(),'-','')" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " And" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Trim([EDI_REMARK]) != '접수통보' A" &
    "ND  [IN_TRANS_TERM] !=""     -  -    """
        Me.GV_CARGO.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3, StyleFormatCondition4})
        Me.GV_CARGO.GridControl = Me.WG_CARGO
        Me.GV_CARGO.Name = "GV_CARGO"
        Me.GV_CARGO.OptionsView.ShowFooter = True
        Me.GV_CARGO.OptionsView.ShowGroupPanel = False
        Me.GV_CARGO.ViewCaption = " 반입리스트"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "반입정보"
        Me.GridBand1.Columns.Add(Me.GV_CARGO_GRNO)
        Me.GridBand1.Columns.Add(Me.GV_CARGO_GR_DT)
        Me.GridBand1.Columns.Add(Me.GV_CARGO_GR_TM)
        Me.GridBand1.Columns.Add(Me.GV_CARGO_MRNNO)
        Me.GridBand1.Columns.Add(Me.GV_CARGO_HBLNO)
        Me.GridBand1.Columns.Add(Me.GV_CARGO_VENDORNM)
        Me.GridBand1.Columns.Add(Me.GV_CARGO_BUYERNM)
        Me.GridBand1.Columns.Add(Me.GV_CARGO_FWDNM)
        Me.GridBand1.Columns.Add(Me.GV_CARGO_RECV_TYPE)
        Me.GridBand1.Columns.Add(Me.GV_CARGO_DNG_YN)
        Me.GridBand1.Columns.Add(Me.GV_CARGO_TS_YN)
        Me.GridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 761
        Me.Localizer1.SetWordID(Me.GridBand1, "")
        '
        'GV_CARGO_GRNO
        '
        Me.GV_CARGO_GRNO.Caption = "반입번호"
        Me.GV_CARGO_GRNO.FieldName = "GRNO"
        Me.GV_CARGO_GRNO.Name = "GV_CARGO_GRNO"
        Me.GV_CARGO_GRNO.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_GRNO.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_GRNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_GRNO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "GRNO", "Count = {0:N0}")})
        Me.GV_CARGO_GRNO.Visible = True
        Me.GV_CARGO_GRNO.Width = 93
        Me.Localizer1.SetWordID(Me.GV_CARGO_GRNO, "")
        '
        'GV_CARGO_GR_DT
        '
        Me.GV_CARGO_GR_DT.Caption = "반입일자"
        Me.GV_CARGO_GR_DT.ColumnEdit = Me.GV1_DATE
        Me.GV_CARGO_GR_DT.FieldName = "GR_DT"
        Me.GV_CARGO_GR_DT.Name = "GV_CARGO_GR_DT"
        Me.GV_CARGO_GR_DT.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_GR_DT.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_GR_DT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_GR_DT.Visible = True
        Me.GV_CARGO_GR_DT.Width = 82
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_DT, "")
        '
        'GV_CARGO_GR_TM
        '
        Me.GV_CARGO_GR_TM.Caption = "시간"
        Me.GV_CARGO_GR_TM.ColumnEdit = Me.GV1_TIME
        Me.GV_CARGO_GR_TM.FieldName = "GR_TM"
        Me.GV_CARGO_GR_TM.Name = "GV_CARGO_GR_TM"
        Me.GV_CARGO_GR_TM.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_GR_TM.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_GR_TM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_GR_TM.Visible = True
        Me.GV_CARGO_GR_TM.Width = 46
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_TM, "")
        '
        'GV1_TIME
        '
        Me.GV1_TIME.AutoHeight = False
        Me.GV1_TIME.Mask.EditMask = "99:99:99"
        Me.GV1_TIME.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.GV1_TIME.Mask.UseMaskAsDisplayFormat = True
        Me.GV1_TIME.Name = "GV1_TIME"
        '
        'GV_CARGO_MRNNO
        '
        Me.GV_CARGO_MRNNO.Caption = "화물관리번호"
        Me.GV_CARGO_MRNNO.FieldName = "MRNNO"
        Me.GV_CARGO_MRNNO.Name = "GV_CARGO_MRNNO"
        Me.GV_CARGO_MRNNO.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_MRNNO.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_MRNNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_MRNNO.Visible = True
        Me.GV_CARGO_MRNNO.Width = 123
        Me.Localizer1.SetWordID(Me.GV_CARGO_MRNNO, "")
        '
        'GV_CARGO_HBLNO
        '
        Me.GV_CARGO_HBLNO.Caption = "House B/L"
        Me.GV_CARGO_HBLNO.FieldName = "HBLNO"
        Me.GV_CARGO_HBLNO.Name = "GV_CARGO_HBLNO"
        Me.GV_CARGO_HBLNO.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_HBLNO.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_HBLNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_HBLNO.Visible = True
        Me.GV_CARGO_HBLNO.Width = 103
        Me.Localizer1.SetWordID(Me.GV_CARGO_HBLNO, "")
        '
        'GV_CARGO_VENDORNM
        '
        Me.GV_CARGO_VENDORNM.Caption = "화주"
        Me.GV_CARGO_VENDORNM.FieldName = "VENDORNM"
        Me.GV_CARGO_VENDORNM.Name = "GV_CARGO_VENDORNM"
        Me.GV_CARGO_VENDORNM.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_VENDORNM.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_VENDORNM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_VENDORNM.Visible = True
        Me.GV_CARGO_VENDORNM.Width = 110
        Me.Localizer1.SetWordID(Me.GV_CARGO_VENDORNM, "")
        '
        'GV_CARGO_BUYERNM
        '
        Me.GV_CARGO_BUYERNM.Caption = "수화인"
        Me.GV_CARGO_BUYERNM.FieldName = "BUYERNM"
        Me.GV_CARGO_BUYERNM.Name = "GV_CARGO_BUYERNM"
        Me.GV_CARGO_BUYERNM.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_BUYERNM.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_BUYERNM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_BUYERNM.Width = 139
        Me.Localizer1.SetWordID(Me.GV_CARGO_BUYERNM, "")
        '
        'GV_CARGO_FWDNM
        '
        Me.GV_CARGO_FWDNM.Caption = "포워더"
        Me.GV_CARGO_FWDNM.FieldName = "FWDNM"
        Me.GV_CARGO_FWDNM.Name = "GV_CARGO_FWDNM"
        Me.GV_CARGO_FWDNM.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_FWDNM.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_FWDNM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_FWDNM.Visible = True
        Me.GV_CARGO_FWDNM.Width = 106
        Me.Localizer1.SetWordID(Me.GV_CARGO_FWDNM, "")
        '
        'GV_CARGO_RECV_TYPE
        '
        Me.GV_CARGO_RECV_TYPE.Caption = "반입구분"
        Me.GV_CARGO_RECV_TYPE.FieldName = "RECV_TYPE"
        Me.GV_CARGO_RECV_TYPE.Name = "GV_CARGO_RECV_TYPE"
        Me.GV_CARGO_RECV_TYPE.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_RECV_TYPE.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_RECV_TYPE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_RECV_TYPE.Width = 61
        Me.Localizer1.SetWordID(Me.GV_CARGO_RECV_TYPE, "")
        '
        'GV_CARGO_DNG_YN
        '
        Me.GV_CARGO_DNG_YN.Caption = "DNG"
        Me.GV_CARGO_DNG_YN.FieldName = "DNG_YN"
        Me.GV_CARGO_DNG_YN.Name = "GV_CARGO_DNG_YN"
        Me.GV_CARGO_DNG_YN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_DNG_YN.Visible = True
        Me.GV_CARGO_DNG_YN.Width = 37
        Me.Localizer1.SetWordID(Me.GV_CARGO_DNG_YN, "")
        '
        'GV_CARGO_TS_YN
        '
        Me.GV_CARGO_TS_YN.Caption = "TS"
        Me.GV_CARGO_TS_YN.FieldName = "TS_YN"
        Me.GV_CARGO_TS_YN.Name = "GV_CARGO_TS_YN"
        Me.GV_CARGO_TS_YN.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_TS_YN.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_TS_YN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_TS_YN.Visible = True
        Me.GV_CARGO_TS_YN.Width = 61
        Me.Localizer1.SetWordID(Me.GV_CARGO_TS_YN, "")
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "반입예정"
        Me.gridBand2.Columns.Add(Me.GV_CARGO_QTY)
        Me.gridBand2.Columns.Add(Me.GV_CARGO_GWT)
        Me.gridBand2.Columns.Add(Me.GV_CARGO_CWT)
        Me.gridBand2.MinWidth = 20
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.Visible = False
        Me.gridBand2.VisibleIndex = -1
        Me.gridBand2.Width = 200
        Me.Localizer1.SetWordID(Me.gridBand2, "")
        '
        'GV_CARGO_QTY
        '
        Me.GV_CARGO_QTY.Caption = "수량"
        Me.GV_CARGO_QTY.DisplayFormat.FormatString = "#,##0"
        Me.GV_CARGO_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV_CARGO_QTY.FieldName = "QTY"
        Me.GV_CARGO_QTY.Name = "GV_CARGO_QTY"
        Me.GV_CARGO_QTY.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_QTY.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_QTY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_QTY.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QTY", "{0:N0}")})
        Me.GV_CARGO_QTY.Width = 55
        Me.Localizer1.SetWordID(Me.GV_CARGO_QTY, "")
        '
        'GV_CARGO_GWT
        '
        Me.GV_CARGO_GWT.Caption = "중량"
        Me.GV_CARGO_GWT.DisplayFormat.FormatString = "#,##.000"
        Me.GV_CARGO_GWT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV_CARGO_GWT.FieldName = "GWT"
        Me.GV_CARGO_GWT.Name = "GV_CARGO_GWT"
        Me.GV_CARGO_GWT.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_GWT.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_GWT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_GWT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GWT", "{0:N2}")})
        Me.GV_CARGO_GWT.Width = 80
        Me.Localizer1.SetWordID(Me.GV_CARGO_GWT, "")
        '
        'GV_CARGO_CWT
        '
        Me.GV_CARGO_CWT.Caption = "용적"
        Me.GV_CARGO_CWT.DisplayFormat.FormatString = "#,##0.000"
        Me.GV_CARGO_CWT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV_CARGO_CWT.FieldName = "CWT"
        Me.GV_CARGO_CWT.Name = "GV_CARGO_CWT"
        Me.GV_CARGO_CWT.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_CWT.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_CWT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_CWT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CWT", "{0:N3}")})
        Me.GV_CARGO_CWT.Width = 65
        Me.Localizer1.SetWordID(Me.GV_CARGO_CWT, "")
        '
        'gridBand3
        '
        Me.gridBand3.Caption = "반입"
        Me.gridBand3.Columns.Add(Me.GV_CARGO_GR_QTY)
        Me.gridBand3.Columns.Add(Me.GV_CARGO_GR_WGT)
        Me.gridBand3.Columns.Add(Me.GV_CARGO_GR_CBM)
        Me.gridBand3.MinWidth = 20
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 1
        Me.gridBand3.Width = 200
        Me.Localizer1.SetWordID(Me.gridBand3, "")
        '
        'GV_CARGO_GR_QTY
        '
        Me.GV_CARGO_GR_QTY.Caption = "수량"
        Me.GV_CARGO_GR_QTY.DisplayFormat.FormatString = "#,##0"
        Me.GV_CARGO_GR_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV_CARGO_GR_QTY.FieldName = "GR_QTY"
        Me.GV_CARGO_GR_QTY.Name = "GV_CARGO_GR_QTY"
        Me.GV_CARGO_GR_QTY.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_GR_QTY.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_GR_QTY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_GR_QTY.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GR_QTY", "{0:N0}")})
        Me.GV_CARGO_GR_QTY.Visible = True
        Me.GV_CARGO_GR_QTY.Width = 55
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_QTY, "")
        '
        'GV_CARGO_GR_WGT
        '
        Me.GV_CARGO_GR_WGT.Caption = "중량"
        Me.GV_CARGO_GR_WGT.DisplayFormat.FormatString = "#,##0.000"
        Me.GV_CARGO_GR_WGT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV_CARGO_GR_WGT.FieldName = "GR_WGT"
        Me.GV_CARGO_GR_WGT.Name = "GV_CARGO_GR_WGT"
        Me.GV_CARGO_GR_WGT.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_GR_WGT.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_GR_WGT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_GR_WGT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GR_WGT", "{0:N2}")})
        Me.GV_CARGO_GR_WGT.Visible = True
        Me.GV_CARGO_GR_WGT.Width = 80
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_WGT, "")
        '
        'GV_CARGO_GR_CBM
        '
        Me.GV_CARGO_GR_CBM.Caption = "용적"
        Me.GV_CARGO_GR_CBM.DisplayFormat.FormatString = "#,##0.000"
        Me.GV_CARGO_GR_CBM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GV_CARGO_GR_CBM.FieldName = "GR_CBM"
        Me.GV_CARGO_GR_CBM.Name = "GV_CARGO_GR_CBM"
        Me.GV_CARGO_GR_CBM.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_GR_CBM.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_GR_CBM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_GR_CBM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GR_CBM", "{0:N3}")})
        Me.GV_CARGO_GR_CBM.Visible = True
        Me.GV_CARGO_GR_CBM.Width = 65
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_CBM, "")
        '
        'gridBand4
        '
        Me.gridBand4.Caption = "기타 정보"
        Me.gridBand4.Columns.Add(Me.GV_CARGO_EDI_REMARK)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_CNTRNO)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_MRN)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_MSN)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_HSN)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_DELNO)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_HADT)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_ETA)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_VESSEL)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_PLT_NO)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_GOODS_NM)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_CNT)
        Me.gridBand4.Columns.Add(Me.GV_CARGO_GR_RMK)
        Me.gridBand4.MinWidth = 20
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 2
        Me.gridBand4.Width = 997
        Me.Localizer1.SetWordID(Me.gridBand4, "")
        '
        'GV_CARGO_CNTRNO
        '
        Me.GV_CARGO_CNTRNO.Caption = "컨테이너번호"
        Me.GV_CARGO_CNTRNO.FieldName = "CNTRNO"
        Me.GV_CARGO_CNTRNO.Name = "GV_CARGO_CNTRNO"
        Me.GV_CARGO_CNTRNO.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_CNTRNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.Localizer1.SetWordID(Me.GV_CARGO_CNTRNO, "")
        '
        'GV_CARGO_MRN
        '
        Me.GV_CARGO_MRN.Caption = "MRN"
        Me.GV_CARGO_MRN.FieldName = "MRN"
        Me.GV_CARGO_MRN.Name = "GV_CARGO_MRN"
        Me.GV_CARGO_MRN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_MRN.Visible = True
        Me.GV_CARGO_MRN.Width = 120
        Me.Localizer1.SetWordID(Me.GV_CARGO_MRN, "")
        '
        'GV_CARGO_MSN
        '
        Me.GV_CARGO_MSN.Caption = "MSN"
        Me.GV_CARGO_MSN.FieldName = "MSN"
        Me.GV_CARGO_MSN.Name = "GV_CARGO_MSN"
        Me.GV_CARGO_MSN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_MSN.Visible = True
        Me.GV_CARGO_MSN.Width = 77
        Me.Localizer1.SetWordID(Me.GV_CARGO_MSN, "")
        '
        'GV_CARGO_HSN
        '
        Me.GV_CARGO_HSN.Caption = "HSN"
        Me.GV_CARGO_HSN.FieldName = "HSN"
        Me.GV_CARGO_HSN.Name = "GV_CARGO_HSN"
        Me.GV_CARGO_HSN.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_HSN.Visible = True
        Me.GV_CARGO_HSN.Width = 77
        Me.Localizer1.SetWordID(Me.GV_CARGO_HSN, "")
        '
        'GV_CARGO_DELNO
        '
        Me.GV_CARGO_DELNO.Caption = "반입예정번호"
        Me.GV_CARGO_DELNO.FieldName = "DELNO"
        Me.GV_CARGO_DELNO.Name = "GV_CARGO_DELNO"
        Me.GV_CARGO_DELNO.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_DELNO.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_DELNO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_DELNO.Visible = True
        Me.GV_CARGO_DELNO.Width = 93
        Me.Localizer1.SetWordID(Me.GV_CARGO_DELNO, "")
        '
        'GV_CARGO_HADT
        '
        Me.GV_CARGO_HADT.Caption = "반입예정일자"
        Me.GV_CARGO_HADT.ColumnEdit = Me.GV1_DATE
        Me.GV_CARGO_HADT.FieldName = "HATD"
        Me.GV_CARGO_HADT.Name = "GV_CARGO_HADT"
        Me.GV_CARGO_HADT.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_HADT.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_HADT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_HADT.Width = 93
        Me.Localizer1.SetWordID(Me.GV_CARGO_HADT, "")
        '
        'GV_CARGO_ETA
        '
        Me.GV_CARGO_ETA.Caption = "입항일자"
        Me.GV_CARGO_ETA.ColumnEdit = Me.GV1_DATE
        Me.GV_CARGO_ETA.FieldName = "ETA"
        Me.GV_CARGO_ETA.Name = "GV_CARGO_ETA"
        Me.GV_CARGO_ETA.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_ETA.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_ETA.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_ETA.Visible = True
        Me.GV_CARGO_ETA.Width = 93
        Me.Localizer1.SetWordID(Me.GV_CARGO_ETA, "")
        '
        'GV_CARGO_VESSEL
        '
        Me.GV_CARGO_VESSEL.Caption = "선명"
        Me.GV_CARGO_VESSEL.FieldName = "VESSEL"
        Me.GV_CARGO_VESSEL.Name = "GV_CARGO_VESSEL"
        Me.GV_CARGO_VESSEL.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_VESSEL.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_VESSEL.Visible = True
        Me.Localizer1.SetWordID(Me.GV_CARGO_VESSEL, "선명")
        '
        'GV_CARGO_PLT_NO
        '
        Me.GV_CARGO_PLT_NO.Caption = "장치위치"
        Me.GV_CARGO_PLT_NO.FieldName = "PLT_NO"
        Me.GV_CARGO_PLT_NO.Name = "GV_CARGO_PLT_NO"
        Me.GV_CARGO_PLT_NO.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_PLT_NO.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_PLT_NO.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_PLT_NO.Visible = True
        Me.GV_CARGO_PLT_NO.Width = 83
        Me.Localizer1.SetWordID(Me.GV_CARGO_PLT_NO, "")
        '
        'GV_CARGO_GOODS_NM
        '
        Me.GV_CARGO_GOODS_NM.Caption = "품명"
        Me.GV_CARGO_GOODS_NM.FieldName = "GOODS_NM"
        Me.GV_CARGO_GOODS_NM.Name = "GV_CARGO_GOODS_NM"
        Me.GV_CARGO_GOODS_NM.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_GOODS_NM.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_GOODS_NM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_GOODS_NM.Visible = True
        Me.GV_CARGO_GOODS_NM.Width = 161
        Me.Localizer1.SetWordID(Me.GV_CARGO_GOODS_NM, "")
        '
        'GV_CARGO_CNT
        '
        Me.GV_CARGO_CNT.Caption = "컨테이너 수량"
        Me.GV_CARGO_CNT.FieldName = "CNT"
        Me.GV_CARGO_CNT.Name = "GV_CARGO_CNT"
        Me.GV_CARGO_CNT.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_CNT.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_CNT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_CNT.Width = 115
        Me.Localizer1.SetWordID(Me.GV_CARGO_CNT, "")
        '
        'GV_CARGO_GR_RMK
        '
        Me.GV_CARGO_GR_RMK.Caption = "비고"
        Me.GV_CARGO_GR_RMK.FieldName = "GR_RMK"
        Me.GV_CARGO_GR_RMK.Name = "GV_CARGO_GR_RMK"
        Me.GV_CARGO_GR_RMK.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_GR_RMK.OptionsColumn.ReadOnly = True
        Me.GV_CARGO_GR_RMK.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GV_CARGO_GR_RMK.Visible = True
        Me.GV_CARGO_GR_RMK.Width = 64
        Me.Localizer1.SetWordID(Me.GV_CARGO_GR_RMK, "")
        '
        'GV_CARGO_EDI_INS_REMARK
        '
        Me.GV_CARGO_EDI_INS_REMARK.Caption = "보험료 전송결과"
        Me.GV_CARGO_EDI_INS_REMARK.FieldName = "EDI_SEND_INS_REMARK"
        Me.GV_CARGO_EDI_INS_REMARK.Name = "GV_CARGO_EDI_INS_REMARK"
        Me.GV_CARGO_EDI_INS_REMARK.OptionsColumn.AllowEdit = False
        Me.GV_CARGO_EDI_INS_REMARK.OptionsColumn.ReadOnly = True
        Me.Localizer1.SetWordID(Me.GV_CARGO_EDI_INS_REMARK, "")
        '
        'GV_CARGO_EDI_STATUS
        '
        Me.GV_CARGO_EDI_STATUS.Caption = "EDI_STATUS"
        Me.GV_CARGO_EDI_STATUS.FieldName = "EDI_STATUS"
        Me.GV_CARGO_EDI_STATUS.Name = "GV_CARGO_EDI_STATUS"
        Me.Localizer1.SetWordID(Me.GV_CARGO_EDI_STATUS, "")
        '
        'GV1_ChkEdit
        '
        Me.GV1_ChkEdit.AutoHeight = False
        Me.GV1_ChkEdit.Caption = ""
        Me.GV1_ChkEdit.Name = "GV1_ChkEdit"
        Me.GV1_ChkEdit.ValueChecked = 1
        Me.GV1_ChkEdit.ValueUnchecked = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.DATE_TYPE)
        Me.GroupControl3.Controls.Add(Me.REF_NO)
        Me.GroupControl3.Controls.Add(Me.WHNM)
        Me.GroupControl3.Controls.Add(Me.WHCD)
        Me.GroupControl3.Controls.Add(Me.REF_TYPE)
        Me.GroupControl3.Controls.Add(Me.Label11)
        Me.GroupControl3.Controls.Add(Me.Label50)
        Me.GroupControl3.Controls.Add(Me.TO_DT)
        Me.GroupControl3.Controls.Add(Me.FROM_DT)
        Me.GroupControl3.Location = New System.Drawing.Point(6, 5)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1240, 50)
        Me.GroupControl3.TabIndex = 5
        Me.GroupControl3.Text = "조회 조건"
        Me.Localizer1.SetWordID(Me.GroupControl3, "조회 조건")
        '
        'DATE_TYPE
        '
        Me.DATE_TYPE.CodeType = ""
        Me.DATE_TYPE.ColumnWidths = ""
        Me.DATE_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.DATE_TYPE.DataParams = ""
        Me.DATE_TYPE.DefVal = "O"
        Me.DATE_TYPE.DisplayMember = "NAME"
        Me.DATE_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DATE_TYPE.FormattingEnabled = True
        Me.DATE_TYPE.IsDataStateAware = True
        Me.DATE_TYPE.ItemDelimiter = ","
        Me.DATE_TYPE.ItemTextList = "반입예정일,반입일,반출일"
        Me.DATE_TYPE.ItemValueList = "O,R,I"
        Me.DATE_TYPE.KeepIntegrity = False
        Me.DATE_TYPE.Location = New System.Drawing.Point(276, 23)
        Me.DATE_TYPE.Name = "DATE_TYPE"
        Me.DATE_TYPE.NextFocus = "FROM_DT"
        Me.DATE_TYPE.NullText = ""
        Me.DATE_TYPE.SearchKeys = ""
        Me.DATE_TYPE.Size = New System.Drawing.Size(82, 22)
        Me.DATE_TYPE.TabIndex = 355
        Me.DATE_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.DATE_TYPE.ValueMember = "CODE"
        '
        'REF_NO
        '
        Me.REF_NO.BackColor = System.Drawing.SystemColors.Window
        Me.REF_NO.BorderColor = System.Drawing.Color.Empty
        Me.REF_NO.DefVal = ""
        Me.REF_NO.IsDataStateAware = True
        Me.REF_NO.Location = New System.Drawing.Point(692, 23)
        Me.REF_NO.MaxLength = 30
        Me.REF_NO.Name = "REF_NO"
        Me.REF_NO.NextFocus = "btnSearch"
        Me.REF_NO.Size = New System.Drawing.Size(164, 22)
        Me.REF_NO.TabIndex = 104
        Me.REF_NO.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        '
        'REF_TYPE
        '
        Me.REF_TYPE.CodeType = ""
        Me.REF_TYPE.ColumnWidths = ""
        Me.REF_TYPE.ComboItemLoadingMode = YJIT.SC.UI.ComboBoxItemLoadingModes.Synchronous
        Me.REF_TYPE.DataParams = ""
        Me.REF_TYPE.DefVal = "H"
        Me.REF_TYPE.DisplayMember = "NAME"
        Me.REF_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.REF_TYPE.FormattingEnabled = True
        Me.REF_TYPE.IsDataStateAware = True
        Me.REF_TYPE.ItemDelimiter = ","
        Me.REF_TYPE.ItemTextList = "House B/L,반입번호,신고번호,컨테이너번호,화물관리번호,수하인"
        Me.REF_TYPE.ItemValueList = "H,R,S,C,M,B"
        Me.REF_TYPE.KeepIntegrity = False
        Me.REF_TYPE.Location = New System.Drawing.Point(590, 22)
        Me.REF_TYPE.Name = "REF_TYPE"
        Me.REF_TYPE.NextFocus = "REF_NO"
        Me.REF_TYPE.NullText = ""
        Me.REF_TYPE.SearchKeys = ""
        Me.REF_TYPE.Size = New System.Drawing.Size(96, 22)
        Me.REF_TYPE.TabIndex = 103
        Me.REF_TYPE.TextCasing = YJIT.SC.UI.TextCasings.Inherit
        Me.REF_TYPE.ValueMember = "CODE"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.LabelFor = Nothing
        Me.Label50.Location = New System.Drawing.Point(459, 24)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(16, 14)
        Me.Label50.TabIndex = 101
        Me.Label50.Text = "~"
        Me.Localizer1.SetWordID(Me.Label50, "/")
        '
        'TO_DT
        '
        Me.TO_DT.BorderColor = System.Drawing.Color.Empty
        Me.TO_DT.DefVal = ""
        Me.TO_DT.IconVisible = True
        Me.TO_DT.IsDataStateAware = True
        Me.TO_DT.Location = New System.Drawing.Point(477, 23)
        Me.TO_DT.Name = "TO_DT"
        Me.TO_DT.NextFocus = "REF_TYPE"
        Me.TO_DT.Size = New System.Drawing.Size(92, 22)
        Me.TO_DT.TabIndex = 100
        Me.Localizer1.SetWordID(Me.TO_DT, "")
        '
        'FROM_DT
        '
        Me.FROM_DT.BorderColor = System.Drawing.Color.Empty
        Me.FROM_DT.DefVal = ""
        Me.FROM_DT.IconVisible = True
        Me.FROM_DT.IsDataStateAware = True
        Me.FROM_DT.Location = New System.Drawing.Point(364, 23)
        Me.FROM_DT.Name = "FROM_DT"
        Me.FROM_DT.NextFocus = "TO_DT"
        Me.FROM_DT.Size = New System.Drawing.Size(92, 22)
        Me.FROM_DT.TabIndex = 99
        Me.Localizer1.SetWordID(Me.FROM_DT, "")
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.WG_ISU)
        Me.PanelControl3.Location = New System.Drawing.Point(0, 395)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(838, 245)
        Me.PanelControl3.TabIndex = 16
        Me.Localizer1.SetWordID(Me.PanelControl3, "")
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Controls.Add(Me.WG_DO)
        Me.PanelControl4.Location = New System.Drawing.Point(845, 523)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(401, 117)
        Me.PanelControl4.TabIndex = 348
        Me.Localizer1.SetWordID(Me.PanelControl4, "")
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl5.Controls.Add(Me.WG_CNTR)
        Me.PanelControl5.Location = New System.Drawing.Point(845, 395)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(401, 127)
        Me.PanelControl5.TabIndex = 349
        Me.Localizer1.SetWordID(Me.PanelControl5, "")
        '
        'BwsCargoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.palAutoButton)
        Me.Controls.Add(Me.PanelControl2)
        Me.KeyPreview = True
        Me.Name = "BwsCargoList"
        Me.Text = "보세창고 화물 조회"
        Me.Localizer1.SetWordID(Me, "보세창고 화물 조회")
        CType(Me.GV1_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Localizer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.palAutoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.palAutoButton.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.WG_DO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG_ISU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_ISU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG_CNTR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_CNTR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2_Text11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2_Text4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2_Text10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2_Num0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2_Text2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2_Num2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV2_Text1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WG_CARGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_CARGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1_TIME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV1_ChkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Localizer1 As YJIT.SC.UI.SCControls.Localizer
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Button4 As Button
    Friend WithEvents Label7 As UI.SCControls.Label
    Public WithEvents CUST_NM As UI.SCControls.TextLabel
    Friend WithEvents Label2 As UI.SCControls.Label
    Friend WithEvents Label1 As UI.SCControls.Label
    Friend WithEvents LBL_S_SQL_ID As UI.SCControls.Label
    Friend WithEvents Label5 As UI.SCControls.Label
    Friend WithEvents Label4 As UI.SCControls.Label
    Friend WithEvents Label3 As UI.SCControls.Label
    Public WithEvents WHNM As UI.SCControls.TextBox
    Public WithEvents WHCD As UI.SCControls.TextBox
    Friend WithEvents Label11 As UI.SCControls.Label
    Friend WithEvents palAutoButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnNew As UI.SCControls.Button
    Friend WithEvents btnSearch As UI.SCControls.Button
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents WG_CNTR As UI.SCControls.WebGrid
    Friend WithEvents GV_CNTR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV_CNTR_CNTRNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_Text11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV_CNTR_CNTRTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_Text4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV_CNTR_SEAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_Text10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV_CNTR_SEAL2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_CNTR_QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_Num0 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV_CNTR_UNIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_Text2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV_CNTR_WGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_Num2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV_CNTR_CBM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV2_Text1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents WG_CARGO As UI.SCControls.WebGrid
    Friend WithEvents GV_CARGO As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV_CARGO_GRNO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_GR_DT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_DATE As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV_CARGO_GR_TM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_TIME As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GV_CARGO_MRNNO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_HBLNO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_VENDORNM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_BUYERNM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_FWDNM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_RECV_TYPE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_DNG_YN As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_TS_YN As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV_CARGO_QTY As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_GWT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_CWT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV_CARGO_GR_QTY As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_GR_WGT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_GR_CBM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GV_CARGO_EDI_REMARK As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_CNTRNO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_MRN As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_MSN As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_HSN As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_DELNO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_HADT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_ETA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_VESSEL As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_PLT_NO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_GOODS_NM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_CNT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_GR_RMK As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_IN_TRANS_TERM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_EDI_INS_REMARK As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV_CARGO_EDI_STATUS As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GV1_ChkEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Public WithEvents DATE_TYPE As UI.SCControls.ComboBox
    Public WithEvents REF_NO As UI.SCControls.TextBox
    Public WithEvents REF_TYPE As UI.SCControls.ComboBox
    Friend WithEvents Label50 As UI.SCControls.Label
    Public WithEvents TO_DT As UI.SCControls.DateBox
    Public WithEvents FROM_DT As UI.SCControls.DateBox
    Friend WithEvents WG_ISU As UI.SCControls.WebGrid
    Friend WithEvents GV_ISU As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVI_GINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_RPNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_LICENSE_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_ISSUED_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_WGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_CBM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_EDI_REMARK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_EDI_SEND_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WG_DO As UI.SCControls.WebGrid
    Friend WithEvents GV_DO As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GV_DO_LICENSE_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_DO_RPNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_DO_DO_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_DO_QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_DO_WGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_DO_DO_DT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVI_GI_DT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public WithEvents CUST_CD As UI.SCControls.CodeBox
    Public WithEvents USR_PWD As UI.SCControls.TextBox
    Public WithEvents USR_ID As UI.SCControls.TextBox
    Public WithEvents DOMAIN As UI.SCControls.TextBox
    Public WithEvents CTRY_CD As UI.SCControls.TextBox
    Public WithEvents DB_SID As UI.SCControls.TextBox
    Public WithEvents DB_PORT As UI.SCControls.TextBox
    Public WithEvents DB_IP As UI.SCControls.TextBox
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
End Class
