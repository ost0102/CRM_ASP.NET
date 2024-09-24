Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Public Class ReportViewer

    Private m_Report As XtraReport = New XtraReport
    Private m_ReportFile As String = String.Empty

#Region "============Constructors=========="

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

#End Region

#Region "===========Properties==========="

    ''' <summary>
    ''' Gets/Sets XtraReport object instance
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Report As XtraReport
        Get
            Return m_Report
        End Get
    End Property

    ''' <summary>
    ''' Full path to report file
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Only when report was load from separated design file (*.repx)</remarks>
    Public ReadOnly Property ReportFile As String
        Get
            If m_Report Is Nothing Then
                Return String.Empty
            Else
                Return m_ReportFile
            End If
        End Get
    End Property

    ''' <summary>
    ''' Auto show/hide parameter panel on the left of report viewer
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AutoShowParametersPanel As Boolean = False

#End Region

#Region "===========Methods=========="

    Public Sub LoadLayoutFile(ByVal sReportFile As String)
        Try
            Me.Report.LoadLayout(sReportFile)
            m_ReportFile = sReportFile  'Store file path for later reference (Report designer)
            Try
                If sReportFile <> "" Then bsiReportPath.Hint = sReportFile.Substring(sReportFile.IndexOf("\RPT\"))
            Catch ex As Exception
                'it's ok
            End Try
        Catch ex As Exception
            MsgBoxSC("Could not load report layout from " & sReportFile)
        End Try
    End Sub

    Public Sub LoadReport(ByVal rpt As DevExpress.XtraReports.UI.XtraReport)
        m_Report = rpt
        m_ReportFile = ""  'Store file path for later reference (Report designer)
    End Sub

#End Region

#Region "===========Control events============="

    ''' <summary>
    ''' Show the report file with current settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Overloads Sub ShowReportPreview(ByVal createDocument As Boolean)

        'Auto set request param as false as default
        Me.Report.RequestParameters = False

        'auto disable printing margin status
        Me.Report.ShowPrintMarginsWarning = False

        Me.PrintControl1.PrintingSystem = Me.Report.PrintingSystem

        '=======================Dynamic set Logo======================'
        Dim picLogo As Object = Me.Report.FindControl("pbLogo", True)
        If picLogo IsNot Nothing Then
            Dim sLogoPath As String = ""
            'Get logo path with priority (Logo.png or Logo.jpg)
            sLogoPath = Common.GetReportFile("Logo.png")

            If Not IO.File.Exists(sLogoPath) Then sLogoPath = Common.GetReportFile("Logo.jpg")
            If IO.File.Exists(sLogoPath) Then
                picLogo.Image = New System.Drawing.Bitmap(sLogoPath)
            End If
        End If
        '============================================================='

        If createDocument Then Me.Report.CreateDocument()

        'Set show/hide parameter panel
        If AutoShowParametersPanel Then
            Me.PrintControl1.DockManager.Panels(1).Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        Else
            Me.PrintControl1.DockManager.Panels(1).Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        End If
    End Sub

    Public Overloads Sub ShowReportPreview()
        Call ShowReportPreview(True)
    End Sub


    'Protected Overrides Sub ProcessUserFuncAuthorities(Optional ByVal parent As System.Windows.Forms.Control = Nothing)
    'Disable authority control temporary
    'MyBase.ProcessUserFuncAuthorities(parent)
    'End Sub

    Private Sub bbiDesign_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDesign.ItemClick
        Call btnDesign_Click(Me, Nothing)
    End Sub

    Private Sub btnDesign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesign.Click
        If Me.ReportFile.Trim = "" Then
            MsgBoxSC("Could not determine report layout file (*.repx)!" & vbNewLine & "Please use ReportViewer.LoadLayoutFile() to load your report!")
            Exit Sub
        End If

        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        If frmMain Is Nothing Then frmMain = Me.ParentForm
        Dim frm As Object = frmMain.NavigateTo("ReportDesigner")
        AddHandler CType(frm, SC.UI.SCView).Shown, AddressOf ReportDesigner_Shown
        frm.LoadReport(Me.ReportFile)
    End Sub

    Private Sub ReportDesigner_Shown(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.Close()  'Close/remain the viewer 
    End Sub

    Private Sub btnDesign_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDesign.EnabledChanged
        'We must use framework button to control user authorities
        'btnDesign enabled only if user have permission
        bbiDesign.Enabled = btnDesign.Enabled
    End Sub

#End Region

End Class