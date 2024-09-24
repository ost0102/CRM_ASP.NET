<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage"%>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        ASPxImageZoom1.Enabled = !chbDisabled.Checked;
        ShowOptions();
    }
    protected override void LoadOptions() {
        LoadOption<bool>("Disabled", delegate(bool value) { chbDisabled.Checked = value; }, false);
    }
    protected override void SaveOptions() {
        SaveOption<bool>("Disabled", delegate() { return chbDisabled.Checked; });
    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="phHead" Runat="Server">
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupControl.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/ImageZoom.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" Runat="Server">
    <dx:ASPxImageZoom ID="ASPxImageZoom1" runat="server" ImageUrl="~\Images\sample-image200x200.gif" LargeImageUrl="~\Images\sample-image500x500.gif" 
        ExpandWindowText="Sample Expand Window Text" ZoomWindowText="Sample Zoom Window Text" ClientInstanceName="ASPxImageZoom1">
    </dx:ASPxImageZoom>
     <script type="text/javascript">
         ASPxTBHelper.AddControlPreviewHelper(ASPxImageZoomPreviewHelper, ASPxTBHelper.FindControlByName("ASPxImageZoom1"));
     </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="phOptions" Runat="Server">
    <table>
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
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowZoomWindow" CssClass="label" SkinID="Option" Text="Show Zoom Window: ">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowZoomWindow" CssClass="editor" SkinID="Option" ClientInstanceName="chbShowZoomWindow">
                    <ClientSideEvents Init="function(s,e){ ASPxTBHelper.GetControlPreviewHelper(ASPxImageZoom1.name).ChangeZoomWindowVisibility(s.GetChecked()); }"
                        CheckedChanged="function(s,e){ ASPxTBHelper.GetControlPreviewHelper(ASPxImageZoom1.name).ChangeZoomWindowVisibility(s.GetChecked()); }" />
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowExpandWindow" CssClass="label" SkinID="Option" Text="Show Expand Window: ">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowExpandWindow" CssClass="editor" SkinID="Option" ClientInstanceName="chbShowExpandWindow">
                    <ClientSideEvents CheckedChanged="function(s,e){ ASPxTBHelper.GetControlPreviewHelper(ASPxImageZoom1.name).ChangeExpandWindowVisibility(s.GetChecked()); s.SetChecked(false); }" />
                </dx:ASPxCheckBox>
            </td>
        </tr>
    </table>
</asp:Content>
