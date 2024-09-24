<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage"%>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        ASPxImageZoomNavigator1.Enabled = !chbDisabled.Checked;
        ASPxImageZoomNavigator1.Orientation = (Orientation)Enum.Parse(typeof(Orientation), (string)cbxOrientation.Value);
        ShowOptions();
    }
    protected override void LoadOptions() {
        LoadOption<Orientation>("Orientation", delegate(Orientation value) { cbxOrientation.Value = Enum.GetName(typeof(Orientation), value); }, Orientation.Horizontal);
        LoadOption<bool>("Disabled", delegate(bool value) { chbDisabled.Checked = value; }, false);
    }
    protected override void SaveOptions() {
        SaveOption<Orientation>("Orientation", delegate() { return (Orientation)Enum.Parse(typeof(Orientation), cbxOrientation.Value.ToString()); });
        SaveOption<bool>("Disabled", delegate() { return chbDisabled.Checked; });
    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="phHead" Runat="Server">
    <script type="text/javascript" src="Scripts/PreviewHelpers/ImageZoomNavigator.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" Runat="Server">
    <dx:ASPxImageZoomNavigator ID="ASPxImageZoomNavigator1" runat="server">
        <ClientSideEvents Init="function(s,e) { ASPxTBHelper.AddControlPreviewHelper(ASPxImageZoomNavigatorPreviewHelper, s); }" />
        <Items>
            <dx:ImageZoomNavigatorItem ImageUrl="~\Images\sample-image200x200.gif" ThumbnailUrl="~\Images\sample-image50x50.gif" />
            <dx:ImageZoomNavigatorItem ImageUrl="~\Images\sample-image200x200.gif" ThumbnailUrl="~\Images\sample-image50x50.gif" />
            <dx:ImageZoomNavigatorItem ImageUrl="~\Images\sample-image200x200.gif" ThumbnailUrl="~\Images\sample-image50x50.gif" />
            <dx:ImageZoomNavigatorItem ImageUrl="~\Images\sample-image200x200.gif" ThumbnailUrl="~\Images\sample-image50x50.gif" />
            <dx:ImageZoomNavigatorItem ImageUrl="~\Images\sample-image200x200.gif" ThumbnailUrl="~\Images\sample-image50x50.gif" />
            <dx:ImageZoomNavigatorItem ImageUrl="~\Images\sample-image200x200.gif" ThumbnailUrl="~\Images\sample-image50x50.gif" />
            <dx:ImageZoomNavigatorItem ImageUrl="~\Images\sample-image200x200.gif" ThumbnailUrl="~\Images\sample-image50x50.gif" />
            <dx:ImageZoomNavigatorItem ImageUrl="~\Images\sample-image200x200.gif" ThumbnailUrl="~\Images\sample-image50x50.gif" />
        </Items>
    </dx:ASPxImageZoomNavigator>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="phOptions" Runat="Server">
    <table>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblOrientation" runat="server" SkinID="Option" CssClass="label" Text="Orientation:"
                    AssociatedControlID="cbxOrientation">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="cbxOrientation" SkinID="Option" CssClass="editor dropDown"
                    AutoPostBack="true" SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Text="Horizontal" Value="Horizontal"></dx:ListEditItem>
                        <dx:ListEditItem Text="Vertical" Value="Vertical"></dx:ListEditItem>
                    </Items>
                </dx:ASPxComboBox>
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
