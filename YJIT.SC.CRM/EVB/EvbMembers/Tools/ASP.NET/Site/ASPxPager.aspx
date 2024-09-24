<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        ASPxPager1.Enabled = !chbDisabled.Checked;
        ASPxPager1.SeoFriendly = chbSeoFriendly.Checked ? SEOFriendlyMode.Enabled : SEOFriendlyMode.Disabled;
        ASPxPager1.RightToLeft = chbRtl.Checked ? DefaultBoolean.True : DefaultBoolean.False;
         
        if(chbSeoFriendly.Checked) {
            ASPxPager1.SeoFriendly = SEOFriendlyMode.Enabled;
            ASPxPager1.SeoNavigateUrlFormatString = "#{0}";
        } else {
            ASPxPager1.SeoFriendly = SEOFriendlyMode.Disabled;
            ASPxPager1.SeoNavigateUrlFormatString = "";    
        }
        
        ShowOptions();
    }
    protected override void LoadOptions() {
        LoadOption<bool>("SeoFriendly", delegate(bool value) { chbSeoFriendly.Checked = value; }, false);
        LoadOption<bool>("Disabled", delegate(bool value) { chbDisabled.Checked = value; }, false);
        LoadOption<bool>("Rtl", delegate(bool value) { chbRtl.Checked = value; }, false);
    }
    protected override void SaveOptions() {
        SaveOption<bool>("SeoFriendly", delegate() { return chbSeoFriendly.Checked; });
        SaveOption<bool>("Disabled", delegate() { return chbDisabled.Checked; });
        SaveOption<bool>("Rtl", delegate() { return chbRtl.Checked; });
    }
    protected string PagerClientID {
        get { return string.Format("'{0}'", ASPxPager1.ClientID); }
    }
</script>
<asp:Content runat="server" ID="Content3" ContentPlaceHolderID="phHead">
    <script type="text/javascript" src="Scripts/PreviewHelpers/Menu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupMenu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/Pager.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" runat="Server">
        <dx:ASPxPager ID="ASPxPager1" runat="server" ItemCount="1000" NumericButtonCount="6">
            <Summary Visible="true"/>
            <AllButton Visible="true"/>
            <FirstPageButton Visible="true"/>
            <LastPageButton Visible="true"/>
            <NextPageButton Visible="true"/>
            <PrevPageButton Visible="true"/>
            <PageSizeItemSettings Visible="true" />
        </dx:ASPxPager>
    
    <script type="text/javascript">
        ASPxTBHelper.AddControlPreviewHelper(ASPxPagerPreviewHelper, window[<%= PagerClientID %>]);
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="phOptions" runat="server">
    <table>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblSeoFriendly" runat="server" SkinID="Option" CssClass="label" Text="SEO friendly:"
                    AssociatedControlID="chbSeoFriendly">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbSeoFriendly" SkinID="Option" AutoPostBack="true">
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
