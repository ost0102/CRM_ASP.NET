Imports System
Imports DevExpress.XtraReports.UserDesigner
Public Class SysEURD

    'Open report from object
    Public Sub OpenReport(ByVal newReport As DevExpress.XtraReports.UI.XtraReport)
        XrDesignPanel1.OpenReport(newReport)
    End Sub

    'Open report from file path
    Public Sub LoadReport(ByVal sReportFile As String)
        XrDesignPanel1.OpenReport(sReportFile)
        'Hide New, Open functions
        CommandBarItem31.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        CommandBarItem32.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub bbiUploadServer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiUploadServer.ItemClick
        Dim frmUpload As New ReportUpload
        Dim sReportFile As String = Me.XrDesignPanel1.FileName
        sReportFile = sReportFile.Substring(sReportFile.IndexOf("\RPT\"))
        frmUpload.txtLocalFile.Text = sReportFile 'Just for showing
        frmUpload.txtRemoteFile.Text = sReportFile 'Just for showing
        frmUpload.txtLocalFullPath.Text = Me.XrDesignPanel1.FileName

        frmUpload.ShowDialog()
    End Sub

    Private Sub SysEURD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

   
End Class