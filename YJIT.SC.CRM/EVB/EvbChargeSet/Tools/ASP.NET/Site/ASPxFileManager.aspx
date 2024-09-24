<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        ASPxFileManager1.Enabled = !chbDisabled.Checked;
        chbShowLoadingPanel.Enabled = !chbDisabled.Checked;
        lblShowLoadingPanel.Enabled = !chbDisabled.Checked;
        ASPxFileManager1.RightToLeft = chbRtl.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        ASPxFileManager1.SettingsFileList.View = (FileListView)Enum.Parse(typeof(FileListView), cbxView.Value.ToString());
        
        ShowOptions();
    }
    protected override void LoadOptions() {
        LoadOption<FileListView>("View", delegate(FileListView value) { cbxView.Value = Enum.GetName(typeof(FileListView), value); }, FileListView.Thumbnails);
        LoadOption<bool>("Disabled", delegate(bool value) { chbDisabled.Checked = value; }, false);
        LoadOption<bool>("Rtl", delegate(bool value) { chbRtl.Checked = value; }, false);
    }
    protected override void SaveOptions() {
        SaveOption<FileListView>("View", delegate() { return (FileListView)Enum.Parse(typeof(FileListView), cbxView.Value.ToString()); });
        SaveOption<bool>("Disabled", delegate() { return chbDisabled.Checked; });
        SaveOption<bool>("Rtl", delegate() { return chbRtl.Checked; });
    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="phHead" runat="Server">
    <script type="text/javascript" src="Scripts/PreviewHelpers/ProgressBar.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/CheckBox.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupControl.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/TreeView.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/Menu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/FileManager.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/UploadControl.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" runat="Server">
    <dx:ASPxFileManager ID="ASPxFileManager1" ClientInstanceName="fm" runat="server"
        Text="Sample Text" Width="800px" Height="400px">
        <ClientSideEvents Init="function(s, e) { ASPxTBHelper.AddControlPreviewHelper(ASPxFileManagerPreviewHelper, s); }" />
        <Settings RootFolder="~/" EnableMultiSelect="true" />
        <SettingsFileList view="Thumbnails">
            <DetailsViewSettings ShowHeaderFilterButton="True">
            </DetailsViewSettings>
        </SettingsFileList>
        <SettingsEditing AllowCreate="true" AllowDelete="true" AllowMove="true" AllowRename="true" AllowCopy="true" />
        <SettingsUpload Enabled="true" />
        <SettingsToolbar ShowDownloadButton="true" />
        <SettingsFolders EnableCallBacks="true" />
    </dx:ASPxFileManager>
    <script type="text/javascript">
        ASPxTBHelper.OnSelectionModeChanged = function(selectionMode) {
            if(!ASPxClientControl.GetControlCollection().GetByName('chbShowLoadingPanel'))
                return;
            if(!selectionMode)
                chbShowLoadingPanel.SetChecked(false);
        };
    </script>
</asp:Content>
<asp:Content runat="server" ID="Content3" ContentPlaceHolderID="phOptions">
    <table>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblView" CssClass="label" SkinID="Option" Text="View:"
                    AssociatedControlID="cbxView">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="cbxView" CssClass="editor dropDown" SkinID="Option" AutoPostBack="true"
                    SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Text="Thumbnails" Value="Thumbnails"/>
                        <dx:ListEditItem Text="Details" Value="Details"/>
                    </Items>
                </dx:ASPxComboBox>
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
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowLoadingPanel" CssClass="label" SkinID="Option" Text="Show loading panel:"
                    AssociatedControlID="chbShowLoadingPanel">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowLoadingPanel" CssClass="editor" SkinID="Option" ClientInstanceName="chbShowLoadingPanel">
                    <ClientSideEvents CheckedChanged="function(s,e){ ASPxTBHelper.SetControlLoadingPanelVisibility(fm, s.GetChecked()); }" 
                        Init="function(s,e){ ASPxTBHelper.SetControlLoadingPanelVisibility(fm, s.GetChecked()); }" />
                </dx:ASPxCheckBox>
            </td>
        </tr>
    </table>
</asp:Content>
