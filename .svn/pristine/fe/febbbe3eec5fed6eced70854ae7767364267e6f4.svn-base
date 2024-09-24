<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<script runat="server">
    public class DataObject {
        public int Column0 { get; set; }
        public string Column1 { get; set; }
        public string Column2 { get; set; }
    }
    protected void Page_Load(object sender, EventArgs e) {
        CardView.Enabled = !chbDisabled.Checked;    
        chbShowLoadingPanel.Enabled = !chbDisabled.Checked;
        lblShowLoadingPanel.Enabled = !chbDisabled.Checked;
        CardView.SettingsBehavior.EnableCustomizationWindow = !chbDisabled.Checked;
        CardView.RightToLeft = chbRtl.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        CardView.Settings.LayoutMode = (Layout)Enum.Parse(typeof(Layout), (string)cbLayoutMode.Value);
        CardView.SettingsEditing.Mode = (CardViewEditingMode)Enum.Parse(typeof(CardViewEditingMode), (string)cbEditFormMode.Value);
        CardView.Settings.ShowHeaderPanel = chbShowHeaderPanel.Checked;
        CardView.Settings.ShowTitlePanel = chbShowTitle.Checked;
        CardView.Settings.ShowFilterBar = chbShowFilterBar.Checked ? GridViewStatusBarMode.Visible : GridViewStatusBarMode.Hidden;
        CardView.Settings.ShowStatusBar = chbShowStatusBar.Checked ? GridViewStatusBarMode.Visible : GridViewStatusBarMode.Hidden;
        CardView.SettingsPager.Position = (PagerPosition)Enum.Parse(typeof(PagerPosition), cbxPagerPosition.Value.ToString());
        GridCommandButtonRenderMode buttonType = (GridCommandButtonRenderMode)Enum.Parse(typeof(DevExpress.Web.GridCommandButtonRenderMode), cbxCommandButtonType.Value.ToString());
        CardView.SettingsCommandButton.NewButton.ButtonType = buttonType;
        CardView.SettingsCommandButton.DeleteButton.ButtonType = buttonType;
        CardView.SettingsCommandButton.EditButton.ButtonType = buttonType;
        CardView.SettingsCommandButton.UpdateButton.ButtonType = buttonType;
        CardView.SettingsCommandButton.DeleteButton.ButtonType = buttonType;
        CardView.SettingsLoadingPanel.Mode = (GridViewLoadingPanelMode)Enum.Parse(typeof(GridViewLoadingPanelMode), cbxLoadingPanelMode.Value.ToString());
        CardView.DataSource = CreateDataSource();
        CardView.DataBind();
        if(!IsPostBack) {
            CardView.Selection.SelectCard(3);
            CardView.FocusedCardIndex = 1;
        }
        
        ShowOptions();
    }
    protected override void LoadOptions() {
        LoadOption<Layout>("LayoutMode", delegate(Layout value) { cbLayoutMode.Value = Enum.GetName(typeof(Layout), value); }, Layout.Table);
        LoadOption<CardViewEditingMode>("EditMode", delegate(CardViewEditingMode value) { cbEditFormMode.Value = Enum.GetName(typeof(CardViewEditingMode), value); }, CardViewEditingMode.EditForm);
        LoadOption<PagerPosition>("PagerPostion", delegate(PagerPosition value) { cbxPagerPosition.Value = Enum.GetName(typeof(PagerPosition), value); }, PagerPosition.TopAndBottom);
        LoadOption<GridViewLoadingPanelMode>("LoadingPanelMode", delegate(GridViewLoadingPanelMode value) { cbxLoadingPanelMode.Value = Enum.GetName(typeof(GridViewLoadingPanelMode), value); }, GridViewLoadingPanelMode.ShowAsPopup);
        LoadOption<ButtonType>("ButtonType", delegate(ButtonType value) { cbxCommandButtonType.Value = Enum.GetName(typeof(ButtonType), value); }, ButtonType.Link);
        LoadOption<bool>("ShowHeaderPanel", delegate(bool value) { chbShowHeaderPanel.Checked = value; }, true);
        LoadOption<bool>("ShowTitle", delegate(bool value) { chbShowTitle.Checked = value; }, true);
        LoadOption<bool>("ShowFilterBar", delegate(bool value) { chbShowFilterBar.Checked = value; }, true);
        LoadOption<bool>("ShowStatusBar", delegate(bool value) { chbShowStatusBar.Checked = value; }, false);
        LoadOption<bool>("Disabled", delegate(bool value) { chbDisabled.Checked = value; }, false);
        LoadOption<bool>("Rtl", delegate(bool value) { chbRtl.Checked = value; }, false);
    }
    protected override void SaveOptions() {
        SaveOption<Layout>("LayoutMode", delegate() { return (Layout)Enum.Parse(typeof(Layout), cbLayoutMode.Value.ToString()); });
        SaveOption<CardViewEditingMode>("EditMode", delegate() { return (CardViewEditingMode)Enum.Parse(typeof(CardViewEditingMode), cbEditFormMode.Value.ToString()); });
        SaveOption<PagerPosition>("PagerPostion", delegate() { return (PagerPosition)Enum.Parse(typeof(PagerPosition), cbxPagerPosition.Value.ToString()); });
        SaveOption<GridViewLoadingPanelMode>("LoadingPanelMode", delegate() { return (GridViewLoadingPanelMode)Enum.Parse(typeof(GridViewLoadingPanelMode), cbxLoadingPanelMode.Value.ToString()); });
        SaveOption<ButtonType>("ButtonType", delegate() { return (ButtonType)Enum.Parse(typeof(ButtonType), cbxCommandButtonType.Value.ToString()); });
        SaveOption<bool>("ShowHeaderPanel", delegate() { return chbShowHeaderPanel.Checked; });
        SaveOption<bool>("ShowTitle", delegate() { return chbShowTitle.Checked; });
        SaveOption<bool>("ShowFilterBar", delegate() { return chbShowFilterBar.Checked; });
        SaveOption<bool>("ShowStatusBar", delegate() { return chbShowStatusBar.Checked; });
        SaveOption<bool>("Disabled", delegate() { return chbDisabled.Checked; });
        SaveOption<bool>("Rtl", delegate() { return chbRtl.Checked; });
    }
    protected DataObject[] CreateDataSource() {
        int recordCount = 50;
        DataObject[] data = new DataObject[recordCount];
        for(int i = 0; i < recordCount; i++)
            data[i] = new DataObject { Column0 = i, Column1 = "Data Row", Column2 = "Data Row" };
        return data;
    }
</script>
<asp:Content runat="server" ID="Content3" ContentPlaceHolderID="phHead">
    <script type="text/javascript" src="Scripts/PreviewHelpers/CheckBox.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupControl.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/Menu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupMenu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/Pager.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/CardView.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" runat="Server">
    <dx:ASPxCardView ID="CardView" runat="server" AutoGenerateColumns="False" KeyFieldName="Column0" Width="800" ClientInstanceName="cv">
        <Columns>
            <dx:CardViewColumn FieldName="Column0">
                <Settings HeaderFilterMode="CheckedList" />
            </dx:CardViewColumn>
            <dx:CardViewColumn FieldName="Column1" />
            <dx:CardViewColumn FieldName="Column2" />
        </Columns>
        <CardLayoutProperties>
            <Items>
                <dx:CardViewLayoutGroup GroupBoxDecoration="None" ColCount="2">
                    <Items>
                        <dx:CardViewCommandLayoutItem HorizontalAlign="Left" ShowSelectCheckbox="true" />
                        <dx:CardViewCommandLayoutItem ShowEditButton="true" ShowNewButton="true" ShowDeleteButton="true" HorizontalAlign="Right" />
                    </Items>
                    <CellStyle Paddings-Padding="0" />
                    <ParentContainerStyle Paddings-Padding="0" />
                </dx:CardViewLayoutGroup>
                <dx:CardViewColumnLayoutItem ColumnName="Column0" />
                <dx:CardViewColumnLayoutItem ColumnName="Column1" />
                <dx:CardViewColumnLayoutItem ColumnName="Column2" />
                <dx:EditModeCommandLayoutItem ShowUpdateButton="true" ShowCancelButton="true" />
            </Items>
        </CardLayoutProperties>
        <Templates>
            <TitlePanel>
                Title Panel
            </TitlePanel>
            <StatusBar>
                Status Bar
            </StatusBar>
        </Templates>
        <SettingsBehavior AllowFocusedCard="true" EnableCardHotTrack="true" EnableCustomizationWindow="true" />
        <SettingsEditing Mode="EditForm" />
        <Settings ShowFilterBar="Visible" ShowHeaderFilterButton="true" ShowTitlePanel="true" ShowHeaderPanel="true" ShowStatusBar="Visible" />
        <SettingsPager Position="TopAndBottom">
            <SettingsTableLayout RowsPerPage="2" />
            <AllButton Visible="true" />
            <FirstPageButton Visible="true" />
            <LastPageButton Visible="true" />
            <PrevPageButton Visible="true" />
            <NextPageButton Visible="true" />
			<PageSizeItemSettings Visible="true" Items="5, 10, 20" />
        </SettingsPager>
        <SettingsCommandButton>
            <NewButton Text="New" Image-Url="Images/sample-image14x14.gif" />
            <EditButton Text="Edit" Image-Url="Images/sample-image14x14.gif" />
            <UpdateButton Text="Update" Image-Url="Images/sample-image14x14.gif" />
            <CancelButton Text="Cancel" Image-Url="Images/sample-image14x14.gif" />
            <DeleteButton Text="Delete" Image-Url="Images/sample-image14x14.gif" />
        </SettingsCommandButton>
        <ClientSideEvents Init="function(s, e) { ASPxTBHelper.AddControlPreviewHelper(ASPxCardViewPreviewHelper, s); }" />
    </dx:ASPxCardView>
    <script type="text/javascript">
        ASPxTBHelper.OnSelectionModeChanged = function (selectionMode) {
            if(!ASPxClientControl.GetControlCollection().GetByName('chbShowLoadingPanel'))
                return;
            if (!selectionMode)
                chbShowLoadingPanel.SetChecked(false);
        };
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="phOptions" runat="server">
    <table>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblLayoutMode" CssClass="label" SkinID="Option" Text="Layout mode:" AssociatedControlID="cbLayoutMode" />
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="cbLayoutMode" AutoPostBack="true" CssClass="editor dropDown" SkinID="Option" SelectedIndex="0" Width="165px">
                    <Items>
                        <dx:ListEditItem Text="Table" Value="Table" />
                        <dx:ListEditItem Text="Flow" Value="Flow" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblEditFormMode" CssClass="label" SkinID="Option"
                    Text="Edit form mode:" AssociatedControlID="cbEditFormMode">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="cbEditFormMode" AutoPostBack="true" CssClass="editor dropDown"
                    SkinID="Option" SelectedIndex="1" Width="165px">
                    <Items>
                        <dx:ListEditItem Text="EditForm" Value="EditForm" />
                        <dx:ListEditItem Text="PopupEditForm" Value="PopupEditForm" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
           <td>
                <dx:ASPxLabel ID="lblPagerPosition" runat="server" SkinID="Option" CssClass="label" Text="Pager position:"
                    AssociatedControlID="cbxPagerPosition">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="cbxPagerPosition" SkinID="Option" CssClass="editor dropDown"
                    AutoPostBack="true" SelectedIndex="0" Width="165px">
                    <Items>
                        <dx:ListEditItem Text="TopAndBottom" Value="TopAndBottom"></dx:ListEditItem>
                        <dx:ListEditItem Text="Top" Value="Top"></dx:ListEditItem>
                        <dx:ListEditItem Text="Bottom" Value="Bottom"></dx:ListEditItem>
                    </Items>
                </dx:ASPxComboBox>
            </td> 
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblCommandButtonType" SkinID="Option" CssClass="label"
                    Text="Command button type:" AssociatedControlID="cbxCommandButtonType">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="cbxCommandButtonType" SkinID="Option" CssClass="editor"
                    AutoPostBack="true" SelectedIndex="0">
                    <Items>
                        <dx:ListEditItem Text="Link" Value="Link" />
                        <dx:ListEditItem Text="Button" Value="Button" />
                        <dx:ListEditItem Text="Image" Value="Image" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowHeaderPanel" CssClass="label" SkinID="Option"
                    Text="Show header panel:" AssociatedControlID="chbShowHeaderPanel">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowHeaderPanel" CssClass="editor" SkinID="Option" AutoPostBack="true" Checked="true" />
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowCustWindow" CssClass="label" SkinID="Option"
                    Text="Show customization window:" AssociatedControlID="chbShowCustWindow">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowCustWindow" CssClass="editor" SkinID="Option">
                    <ClientSideEvents
                        CheckedChanged="function(s, e) { ASPxTBHelper.GetControlPreviewHelper(cv.name).SetCustomizationWindowVisibility(s.GetChecked()); }" />
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowTitle" CssClass="label" SkinID="Option"
                    Text="Show title:" AssociatedControlID="chbShowTitle">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowTitle" CssClass="editor" SkinID="Option" AutoPostBack="true"
                    Checked="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowFilterBar" CssClass="label" SkinID="Option"
                    Text="Show filter bar:" AssociatedControlID="chbShowFilterBar">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowFilterBar" CssClass="editor" SkinID="Option" AutoPostBack="true"
                    Checked="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowStatusBar" CssClass="label" SkinID="Option"
                    Text="Show status bar:" AssociatedControlID="chbShowStatusBar">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowStatusBar" CssClass="editor" SkinID="Option" AutoPostBack="true">
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
        <tr>
           <td>
                <dx:ASPxLabel ID="lblLoadingPanelMode" runat="server" SkinID="Option" CssClass="label" Text="Loading panel mode:"
                    AssociatedControlID="cbxLoadingPanelMode">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="cbxLoadingPanelMode" SkinID="Option" CssClass="editor dropDown"
                    AutoPostBack="true" SelectedIndex="0" Width="165px">
                    <Items>
                        <dx:ListEditItem Text="ShowAsPopup" Value="ShowAsPopup"></dx:ListEditItem>
                        <dx:ListEditItem Text="ShowOnStatusBar" Value="ShowOnStatusBar"></dx:ListEditItem>
                    </Items>
                </dx:ASPxComboBox>
            </td> 
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowLoadingPanel" CssClass="label" SkinID="Option"
                    Text="Show loading panel:" AssociatedControlID="chbShowLoadingPanel">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="chbShowLoadingPanel" CssClass="editor" SkinID="Option"
                    ClientInstanceName="chbShowLoadingPanel">
                    <ClientSideEvents CheckedChanged="function(s, e) { ASPxTBHelper.SetControlLoadingPanelVisibility(cv, s.GetChecked()); }" 
                        Init="function(s,e){ ASPxTBHelper.SetControlLoadingPanelVisibility(cv, s.GetChecked()); }" />
                </dx:ASPxCheckBox>
            </td>
        </tr>
    </table>
</asp:Content>
