<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        ShowOptions();
    }
</script>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="phHead">
    <script type="text/javascript" src="Scripts/PreviewHelpers/TabControl.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/Menu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupMenu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupControl.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/Ribbon.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/RichEdit.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" runat="Server">
    <dx:ASPxRichEdit ID="ASPxRichEdit1" runat="server" Width="800px" ClientInstanceName="RichEdit" ShowConfirmOnLosingChanges="false">
        <ClientSideEvents Init="function(s, e) { ASPxTBHelper.AddControlPreviewHelper(ASPxRichEditPreviewHelper, s); }" />
    </dx:ASPxRichEdit>
    <script type="text/javascript">
        ASPxTBHelper.OnSelectionModeChanged = function(selectionMode) {
            if(!ASPxClientControl.GetControlCollection().GetByName('chbShowLoadingPanel'))
                return;
            if(!selectionMode)
                chbShowLoadingPanel.SetChecked(false);
        };
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="phOptions" runat="server">
    <table>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowLoadingPanel" CssClass="label" SkinID="Option" Text="Show loading panel:"
                    AssociatedControlID="chbShowLoadingPanel">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowLoadingPanel" CssClass="editor" SkinID="Option" ClientInstanceName="chbShowLoadingPanel">
                    <ClientSideEvents CheckedChanged="function(s,e){ ASPxTBHelper.SetControlLoadingPanelVisibility(RichEdit, s.GetChecked()); }"
                        Init="function(s,e){ ASPxTBHelper.SetControlLoadingPanelVisibility(RichEdit, s.GetChecked()); }" />
                </dx:ASPxCheckBox>
            </td>
        </tr>
    </table>
</asp:Content>
