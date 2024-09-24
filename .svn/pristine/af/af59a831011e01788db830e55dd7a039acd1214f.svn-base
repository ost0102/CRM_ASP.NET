Imports System
Imports DevExpress.XtraReports.UserDesigner
Public Class ReportDesigner

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
        frmUpload.txtLocalFullPath.Text = Me.XrDesignPanel1.FileName

        Dim sSeverPath As String = sReportFile.Substring(sReportFile.IndexOf("\RPT\") + 1).Replace("\", "/") 'E.g: RPT/SEA/BL_FORM/
        'NOTE: Make sure upload to customized folder on server (RPT/CUSTOMER/office_cd/...) to not affect other customers
        If Not sSeverPath.ToUpper.StartsWith("RPT/CUSTOMERS/") Then
            If Common.SavedSessionDomain <> "" Then
                'Domain based customer
                sSeverPath = sSeverPath.Insert(4, "CUSTOMERS/" & Common.SavedSessionDomain & "/" & ClientSessionInfo.OfficeCode & "/")
            Else
                'Office only based
                sSeverPath = sSeverPath.Insert(4, "CUSTOMERS/" & ClientSessionInfo.OfficeCode & "/")
            End If
        End If

        frmUpload.txtRemoteFile.Text = sSeverPath 'For use during upload

        frmUpload.ShowDialog()
    End Sub


    Private Sub btnUpload_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpload.EnabledChanged
        'We must use framework button to control user authorities
        'btnDesign enabled only if user have permission
        bbiUploadServer.Enabled = btnUpload.Enabled
    End Sub
End Class