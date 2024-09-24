<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        ASPxRoundPanel1.Enabled = !chbDisabled.Checked;
        ASPxRoundPanel1.View = (DevExpress.Web.View)Enum.Parse(typeof(DevExpress.Web.View), cbxViewMode.Value.ToString());
        ASPxRoundPanel1.ShowHeader = cbShowHeader.Checked;
        ASPxRoundPanel1.ShowCollapseButton = cbShowCollapseButton.Checked;
        ASPxRoundPanel1.RightToLeft = chbRtl.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        ShowOptions();
    }
    protected override void LoadOptions() {
        LoadOption<DevExpress.Web.View>("View", value => {
            cbxViewMode.Value = Enum.GetName(typeof(DevExpress.Web.View), value);
        }, DevExpress.Web.View.Standard);
        LoadOption<bool>("ShowHeader", value => {
            cbShowHeader.Checked = value;
        }, true);
        LoadOption<bool>("ShowCollapseButton", showCollapseButton => {
            cbShowCollapseButton.Checked = showCollapseButton;
        }, true);
        LoadOption<bool>("Disabled", value => {
            chbDisabled.Checked = value;
        }, false);
        LoadOption<bool>("Rtl", value => {
            chbRtl.Checked = value;
        }, false);
    }
    protected override void SaveOptions() {
        SaveOption<DevExpress.Web.View>("View",
            () => (DevExpress.Web.View)Enum.Parse(typeof(DevExpress.Web.View), cbxViewMode.Value.ToString()));
        SaveOption<bool>("ShowHeader", () => cbShowHeader.Checked);
        SaveOption<bool>("ShowCollapseButton", () => cbShowCollapseButton.Checked);
        SaveOption<bool>("Disabled", () => chbDisabled.Checked);
        SaveOption<bool>("Rtl", () => chbRtl.Checked);
    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="phHead" Runat="Server">
    <script type="text/javascript" src="Scripts/PreviewHelpers/RoundPanel.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" ShowHeader="true" ClientInstanceName="panel" 
        AllowCollapsing="true" LoadContentViaCallback="true">
        <ClientSideEvents Init="function(s,e) { ASPxTBHelper.AddControlPreviewHelper(ASPxRoundPanelPreviewHelper, s); }"  />
        <PanelCollection>
            <dx:PanelContent runat="server" SupportsDisabledAttribute="True">
                Sample Content<br />
                Sample Content<br />
                Sample Content<br />
                Sample Content<br />
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="phOptions" runat="server">
    <table>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblViewMode" runat="server" SkinID="Option" CssClass="label" Text="View:"
                    AssociatedControlID="cbxViewMode">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="cbxViewMode" SkinID="Option" CssClass="editor dropDown"
                    AutoPostBack="true" SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Text="Standard" Value="Standard"></dx:ListEditItem>
                        <dx:ListEditItem Text="GroupBox" Value="GroupBox"></dx:ListEditItem>
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblShowHeader" runat="server" SkinID="Option" CssClass="label"
                    Text="Show header:" AssociatedControlID="cbShowHeader">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="cbShowHeader" SkinID="Option" CssClass="editor"
                    AutoPostBack="true" Checked="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblShowCollapseButton" runat="server" SkinID="Option" CssClass="label"
                    Text="Show Collapse Button:" AssociatedControlID="cbShowCollapseButton">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="cbShowCollapseButton" SkinID="Option" CssClass="editor"
                    AutoPostBack="true" Checked="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblRtl" SkinID="Option" CssClass="label" Text="Right to left:">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbRtl" SkinID="Option" CssClass="editor" AutoPostBack="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblEnabled" SkinID="Option" CssClass="label" Text="Disabled:"
                    AssociatedControlID="chbDisabled">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbDisabled" SkinID="Option" Checked="false"
                    CssClass="editor" AutoPostBack="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowLoadingPanel" CssClass="label" SkinID="Option" Text="Show loading panel:"
                    AssociatedControlID="chbShowLoadingPanel">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowLoadingPanel" CssClass="editor" SkinID="Option" ClientInstanceName="chbShowLoadingPanel">
                    <ClientSideEvents CheckedChanged="function(s,e){ if(typeof(panel) != 'undefined') ASPxTBHelper.SetControlLoadingPanelVisibility(panel, s.GetChecked()); }"
                        Init="function(s,e){ if(typeof(panel) != 'undefined') ASPxTBHelper.SetControlLoadingPanelVisibility(panel, s.GetChecked()); }" />
                </dx:ASPxCheckBox>
            </td>
        </tr>
    </table>
</asp:Content>
