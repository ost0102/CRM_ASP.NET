<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        ASPxColorEdit1.Enabled = !chbDisabled.Checked;
        
        lblShowError.Enabled = !chbDisabled.Checked;
        chbShowError.Enabled = !chbDisabled.Checked;
        ASPxColorEdit1.ValidationSettings.EnableCustomValidation = chbShowError.Checked;
        ASPxColorEdit1.IsValid = !chbShowError.Checked;
        
        ASPxColorEdit1.RightToLeft = chbRtl.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        ShowOptions();
    }
    protected override void LoadOptions() {
        LoadOption<bool>("ShowError", delegate(bool value) { chbShowError.Checked = value; }, false);
        LoadOption<bool>("Disabled", delegate(bool value) { chbDisabled.Checked = value; }, false);
        LoadOption<bool>("Rtl", delegate(bool value) { chbRtl.Checked = value; }, false);
    }
    protected override void SaveOptions() {
        SaveOption<bool>("ShowError", delegate() { return chbShowError.Checked; });
        SaveOption<bool>("Disabled", delegate() { return chbDisabled.Checked; });
        SaveOption<bool>("Rtl", delegate() { return chbRtl.Checked; });
    }
</script>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="phHead">
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupControl.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/DropDownEdit.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/ColorEdit.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" runat="Server">
    <dx:ASPxColorEdit ID="ASPxColorEdit1" runat="server" Color="Green" ClientInstanceName="colorEdit" EnableCustomColors="true">
        <ClientSideEvents Init="function(s, e) { ASPxTBHelper.AddControlPreviewHelper(ASPxColorEditPreviewHelper, s); }" />
        <ValidationSettings ErrorText="Sample error text">
        </ValidationSettings>
    </dx:ASPxColorEdit>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="phOptions" runat="server">
    <table>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowError" SkinID="Option" CssClass="label" Text="Show error frame:"
                    AssociatedControlID="chbShowError">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowError" SkinID="Option" CssClass="editor" AutoPostBack="true"
                    ClientInstanceName="chbShowError">
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
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowColorDialog" SkinID="Option" CssClass="label" Text="Show custom color dialog:"
                    AssociatedControlID="chbShowColorDialog">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowColorDialog" CssClass="editor" SkinID="Option" ClientInstanceName="chbShowLoadingPanel">
                    <ClientSideEvents CheckedChanged="function(s,e){ ASPxTBHelper.GetControlPreviewHelper(colorEdit.name).SetCustomColorDialog(s.GetChecked()); }" 
                        Init="function(s,e){ ASPxTBHelper.GetControlPreviewHelper(colorEdit.name).SetCustomColorDialog(s.GetChecked()); }" />
                </dx:ASPxCheckBox>
            </td>
        </tr>
        </tr>
    </table>
</asp:Content>
