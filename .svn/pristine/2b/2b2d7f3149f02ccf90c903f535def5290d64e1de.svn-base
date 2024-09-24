<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        ASPxSpinEdit1.Enabled = !chbDisabled.Checked;
        
        lblShowError.Enabled = !chbDisabled.Checked;
        chbShowError.Enabled = !chbDisabled.Checked;
        ASPxSpinEdit1.ValidationSettings.EnableCustomValidation = chbShowError.Checked;
        ASPxSpinEdit1.IsValid = !chbShowError.Checked;
        
        ASPxSpinEdit1.RightToLeft = chbRtl.Checked ? DefaultBoolean.True : 