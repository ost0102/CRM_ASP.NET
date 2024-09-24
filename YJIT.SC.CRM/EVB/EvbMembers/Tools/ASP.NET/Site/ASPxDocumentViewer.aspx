<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="phHead">
    <script type="text/javascript" src="Scripts/PreviewHelpers/Menu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/TreeView.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/CheckBox.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/Splitter.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/ReportDocumentMap.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/ReportToolbar.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/DocumentViewer.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" runat="Server">
    <dx:ASPxDocumentViewer runat="server" ID="ASPxDocumentViewer" ReportTypeName="XtraReport1" ClientInstanceName="documentViewer">
    </dx:ASPxDocumentViewer>
    <script type="text/javascript">
        ASPxTBHelper.AddControlPreviewHelper(ASPxDocumentViewerPreviewHelper, documentViewer);
        var savedRestoreSelectionMode = ASPxTBHelper.RestoreSelectionMode;
        ASPxTBHelper.RestoreSelectionMode = function() {
            savedRestoreSelectionMode.call(ASPxTBHelper);
            ASPxTBHelper.SetControlLoadingPanelVisibility(documentViewer.GetViewer(), ASPxTBHelper.selectionMode);
        }
        ASPxTBHelper.OnSelectionModeChanged = function(selectionMode) {
            ASPxTBHelper.SetControlLoadingPanelVisibility(documentViewer.GetViewer(), selectionMode);
        };
    </script>
</asp:Content>
