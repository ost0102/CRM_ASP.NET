<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        ASPxCallbackPanel1.Enabled = !chbDisabled.Checked;
        ASPxCallbackPanel1.Controls.Add(new LiteralControl("Sample Content"));
        ASPxCallbackPanel1.RightToLeft = chbRtl.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        ASPxCallbackPanel1.FixedPosition = (PanelFixedPosition)Enum.Parse(typeof(PanelFixedPosition), cbxFixedPosition.Value.ToString());
        if(ASPxCallbackPanel1.FixedPosition != PanelFixedPosition.None) {
            ASPxCallbackPanel1.Width = 100;
            ASPxCallbackPanel1.Height = 100;
            ASPxCallbackPanel1.Styles.ExpandBar.Width = Unit.Empty;
            ASPxCallbackPanel1.CssClass = "";
        } else {
            ASPxCallbackPanel1.Width = 300;
            ASPxCallbackPanel1.Height = 200;
            ASPxCallbackPanel1.Styles.ExpandBar.Width = 300;
            ASPxCallbackPanel1.CssClass = "control";
        }
        ASPxCallbackPanel1.Collapsible = chbСollapsible.Checked;
                
        ShowOptions();
    }
    protected override void LoadOptions() {
        LoadOption<PanelFixedPosition>("FixedPosition", delegate(PanelFixedPosition value) { cbxFixedPosition.Value = Enum.GetName(typeof(PanelFixedPosition), value); }, PanelFixedPosition.None);
        LoadOption<bool>("Expandable", delegate(bool value) { chbСollapsible.Checked = value; }, false);
        LoadOption<bool>("Disabled", delegate(bool value) { chbDisabled.Checked = value; }, false);
        LoadOption<bool>("Rtl", delegate(bool value) { chbRtl.Checked = value; }, false);
    }
    protected override void SaveOptions() {
        SaveOption<PanelFixedPosition>("FixedPosition", delegate() { return (PanelFixedPosition)Enum.Parse(typeof(PanelFixedPosition), cbxFixedPosition.Value.ToString()); });
        SaveOption<bool>("Expandable", delegate() { return chbСollapsible.Checked; });
        SaveOption<bool>("Disabled", delegate() { return chbDisabled.Checked; });
        SaveOption<bool>("Rtl", delegate() { return chbRtl.Checked; });
    }
</script>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="phHead">
    <script type="text/javascript" src="Scripts/PreviewHelpers/Panel.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/CallbackPanel.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" runat="Server">
    <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" ClientInstanceName="ASPxCallbackPanel1" runat="server" CssClass="control" Width="300px" Height="200px">
        <ClientSideEvents Init="function(s, e) { ASPxTBHelper.AddControlPreviewHelper(ASPxCallbackPanelPreviewHelper, s); }"/>
    </dx:ASPxCallbackPanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="phOptions" runat="server">
    <table>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblFixedPosition" CssClass="label" SkinID="Option" Text="Fixed Position:"
                    AssociatedControlID="cbxFixedPosition">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="cbxFixedPosition" CssClass="editor dropDown" SkinID="Option" AutoPostBack="true"
                    SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Text="None" Value="None"/>
                        <dx:ListEditItem Text="WindowLeft" Value="WindowLeft"/>
                        <dx:ListEditItem Text="WindowRight" Value="WindowRight"/>
                        <dx:ListEditItem Text="WindowTop" Value="WindowTop"/>
                        <dx:ListEditItem Text="WindowBottom" Value="WindowBottom"/>
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblСollapsible" SkinID="Option" CssClass="label" Text="Сollapsible:"
                    AssociatedControlID="chbСollapsible">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbСollapsible" SkinID="Option" CssClass="editor" AutoPostBack="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblRtl" SkinID="Option" CssClass="label" Text="Right to left:"
                    AssociatedControlID="chbRtl">
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
                <dx:ASPxCheckBox runat="server" ID="chbDisabled" SkinID="Option" Checked="false" CssClass="editor" AutoPostBack="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
    </table>
</asp:Content>
