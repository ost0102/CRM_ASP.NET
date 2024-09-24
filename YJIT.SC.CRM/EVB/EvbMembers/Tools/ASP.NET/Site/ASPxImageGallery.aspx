<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<script runat="server">
    public class DataObject {
        public string ImageUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public string MediumImageUrl { get; set; }
        public string Text { get; set; }
    }
    protected void Page_Load(object sender, EventArgs e) {
        ASPxImageGallery1.Enabled = !chbDisabled.Checked;
        chbShowLoadingPanel.Enabled = !chbDisabled.Checked;
        lblShowLoadingPanel.Enabled = !chbDisabled.Checked;
        ASPxImageGallery1.Layout = (Layout)Enum.Parse(typeof(Layout), cbxLayout.Value.ToString());
        ASPxImageGallery1.DataSource = CreateDataSource();
        ASPxImageGallery1.DataBind();
        ShowOptions();
    }
    protected override void LoadOptions() {
        LoadOption<Layout>("Layout", delegate(Layout value) { cbxLayout.Value = Enum.GetName(typeof(Layout), value); }, Layout.Table);
        LoadOption<bool>("Disabled", delegate(bool value) { chbDisabled.Checked = value; }, false);
    }
    protected override void SaveOptions() {
        SaveOption<Layout>("Layout", delegate() { return (Layout)Enum.Parse(typeof(Layout), cbxLayout.Value.ToString()); });
        SaveOption<bool>("Disabled", delegate() { return chbDisabled.Checked; });
    }
    protected DataObject[] CreateDataSource() {
        int recordCount = 25;
        DataObject[] data = new DataObject[recordCount];
        for(int i = 0; i < recordCount; i++) {
            data[i] = new DataObject { 
                ImageUrl = @"~\Images\sample-image200x200.gif", 
                MediumImageUrl = @"~\Images\sample-image50x50.gif", 
                ThumbnailUrl = @"~\Images\sample-image50x50.gif",
                Text = "Image" + i.ToString() 
            };
        }
        return data;
    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="phHead" Runat="Server">
    <script type="text/javascript" src="Scripts/PreviewHelpers/Menu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupMenu.js"></script>
	<script type="text/javascript" src="Scripts/PreviewHelpers/Pager.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/DataView.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/ImageSlider.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/ImageGallery.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" Runat="Server">
    <dx:ASPxImageGallery ID="ASPxImageGallery1" runat="server"
        ClientInstanceName="ASPxImageGallery1" HideEmptyRows="false" 
        ImageUrlField="ImageUrl" FullscreenViewerThumbnailUrlField="ThumbnailUrl" ThumbnailUrlField="MediumImageUrl" TextField="Text"        
        ThumbnailWidth="150px" ThumbnailHeight="150px" EncodeHtml="false" TextVisibility="Always">
        <ClientSideEvents Init="function(s,e) { ASPxTBHelper.AddControlPreviewHelper(ASPxImageGalleryPreviewHelper, s); }"  />
        <SettingsTableLayout ColumnCount="4" RowsPerPage="1" />
        <SettingsFullscreenViewer NavigationBarVisibility="Always" NavigationButtonVisibility="Always" />
        <PagerSettings ShowNumericButtons="true">
            <AllButton Visible="true" />
            <FirstPageButton Visible="true"/>
            <LastPageButton Visible="true"/>
            <NextPageButton Visible="true"/>
            <PrevPageButton Visible="true"/>
            <Summary Visible="false"/>
            <PageSizeItemSettings Visible="true" Items="2,3,4"/>
        </PagerSettings>
    </dx:ASPxImageGallery>
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
                <dx:ASPxLabel runat="server" ID="lblLayout" CssClass="label" SkinID="Option" Text="Layout:"
                    AssociatedControlID="cbxLayout">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="cbxLayout" CssClass="editor dropDown" SkinID="Option" AutoPostBack="true"
                    SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Text="Table" Value="Table"/>
                        <dx:ListEditItem Text="Flow" Value="Flow"/>
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
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowLoadingPanel" CssClass="label" SkinID="Option" Text="Show loading panel: ">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowLoadingPanel" CssClass="editor" SkinID="Option" ClientInstanceName="chbShowLoadingPanel">
                    <ClientSideEvents CheckedChanged="function(s,e){ ASPxTBHelper.SetControlLoadingPanelVisibility(ASPxImageGallery1, s.GetChecked()); }"
                        Init="function(s,e){ ASPxTBHelper.SetControlLoadingPanelVisibility(ASPxImageGallery1, s.GetChecked()); }" />
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowFullscreenViewer" CssClass="label" SkinID="Option" Text="Show Fullscreen Viewer: ">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowFullscreenViewer" CssClass="editor" SkinID="Option" ClientInstanceName="chbShowFullscreenViewer">
                    <ClientSideEvents CheckedChanged="function(s,e){ ASPxTBHelper.GetControlPreviewHelper(ASPxImageGallery1.name).ChangeFullscreenViewerVisibility(s.GetChecked()); s.SetChecked(false); }" />
                </dx:ASPxCheckBox>
            </td>
        </tr>
    </table>
</asp:Content>
