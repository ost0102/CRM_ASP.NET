<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        ASPxRibbon1.Enabled = !cbDisabled.Checked;
        ASPxRibbon1.Width = cbShowCollapsedGroups.Checked ? Unit.Pixel(300) : Unit.Pixel(700);
        ShowOptions();
    }
    protected override void LoadOptions() {
        LoadOption<bool>("Disabled", delegate(bool value) { cbDisabled.Checked = value; }, false);
        LoadOption<bool>("ShowCollapsedGroups", delegate(bool value) { cbShowCollapsedGroups.Checked = value; }, false);
    }
    protected override void SaveOptions() {
        SaveOption<bool>("Disabled", delegate() { return cbDisabled.Checked; });
        SaveOption<bool>("ShowCollapsedGroups", delegate() { return cbShowCollapsedGroups.Checked; });
    }
</script>
<asp:Content runat="server" ID="Content4" ContentPlaceHolderID="phHead">
    <script type="text/javascript" src="Scripts/PreviewHelpers/TabControl.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/Menu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupMenu.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/PopupControl.js"></script>
    <script type="text/javascript" src="Scripts/PreviewHelpers/Ribbon.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phComponent" runat="Server">
    <dx:ASPxRibbon ID="ASPxRibbon1" runat="server" ClientInstanceName="ribbon">
        <ClientSideEvents Init="function(s, e) { ASPxTBHelper.AddControlPreviewHelper(ASPxRibbonPreviewHelper, s); }" />
        <Tabs>
            <dx:RibbonTab Text="Item Types" Name="ItemTypes">
                <Groups>
                    <dx:RibbonGroup Text="Buttons">
                        <Items>
                            <dx:RibbonButtonItem Name="Cut" Text="Cut">
                                <SmallImage Url="~/Images/sample-image16x16.png">
                                </SmallImage>
                            </dx:RibbonButtonItem>
                            <dx:RibbonButtonItem Name="Copy" Text="Copy" ToolTip="Copy">
                                <SmallImage Url="~/Images/sample-image16x16.png">
                                </SmallImage>
                            </dx:RibbonButtonItem>
                            <dx:RibbonButtonItem Name="Paste" Text="Paste">
                                <SmallImage Url="~/Images/sample-image16x16.png">
                                </SmallImage>
                            </dx:RibbonButtonItem>
                            <dx:RibbonDropDownButtonItem Name="DropDownButton" Size="Large" Text="Drop Down">
                                <Items>
                                    <dx:RibbonDropDownButtonItem Name="Pdf" Size="Small" Text="Pdf">
                                        <SmallImage Url="~/Images/sample-image16x16.png">
                                        </SmallImage>
                                    </dx:RibbonDropDownButtonItem>
                                    <dx:RibbonDropDownButtonItem Name="Txt" Size="Small" Text="Txt">
                                        <SmallImage Url="~/Images/sample-image16x16.png">
                                        </SmallImage>
                                    </dx:RibbonDropDownButtonItem>
                                    <dx:RibbonDropDownButtonItem Name="Xml" Size="Small" Text="Xml">
                                        <SmallImage Url="~/Images/sample-image16x16.png">
                                        </SmallImage>
                                    </dx:RibbonDropDownButtonItem>
                                </Items>
                                <LargeImage Url="~/Images/sample-image32x32.png">
                                </LargeImage>
                            </dx:RibbonDropDownButtonItem>
                        </Items>
                    </dx:RibbonGroup>
                    <dx:RibbonGroup Text="Editor Items">
                        <Items>
                            <dx:RibbonComboBoxItem Name="ComboBox">
                                <PropertiesComboBox Width="100px" NullText="ComboBox">
                                </PropertiesComboBox>
                                <Items>
                                    <dx:ListEditItem Text="Name" Value="Name" />
                                    <dx:ListEditItem Text="Last Name" Value="Last Name" />
                                    <dx:ListEditItem Text="City" Value="City" />
                                </Items>
                            </dx:RibbonComboBoxItem>
                            <dx:RibbonSpinEditItem Name="SpinEdit">
                                <PropertiesSpinEdit Width="100px" NullText="SpinEdit">
                                </PropertiesSpinEdit>
                            </dx:RibbonSpinEditItem>
                            <dx:RibbonDateEditItem Name="DateEdit">
                                <PropertiesDateEdit Width="100px" NullText="DateEdit">
                                </PropertiesDateEdit>
                            </dx:RibbonDateEditItem>
                            <dx:RibbonTextBoxItem Name="TextBox">
                                <PropertiesTextBox Width="100px" NullText="TextBox">
                                </PropertiesTextBox>
                            </dx:RibbonTextBoxItem>
                        </Items>
                    </dx:RibbonGroup>
                    <dx:RibbonGroup Text="Toggle &amp; Options">
                        <Items>
                            <dx:RibbonOptionButtonItem Name="Option1" OptionGroupName="Group1" Text="Option 1">
                                <SmallImage Url="~/Images/sample-image16x16.png">
                                </SmallImage>
                            </dx:RibbonOptionButtonItem>
                            <dx:RibbonOptionButtonItem Name="Option2" OptionGroupName="Group1" Text="Option 2">
                                <SmallImage Url="~/Images/sample-image16x16.png">
                                </SmallImage>
                            </dx:RibbonOptionButtonItem>
                            <dx:RibbonOptionButtonItem Name="Option3" OptionGroupName="Group1" Text="Option 3">
                                <SmallImage Url="~/Images/sample-image16x16.png">
                                </SmallImage>
                            </dx:RibbonOptionButtonItem>
                            <dx:RibbonToggleButtonItem Name="ToggleButton" Size="Large" Text="Toggle Button">
                                <LargeImage Url="~/Images/sample-image32x32.png">
                                </LargeImage>
                            </dx:RibbonToggleButtonItem>
                        </Items>
                    </dx:RibbonGroup>
                    <dx:RibbonGroup Text="Color">
                        <Items>
                            <dx:RibbonColorButtonItem Name="ColorButton" Text="Color Button" Size="Large" Color="Red">
                                <LargeImage Url="~/Images/sample-image32x32.png">
                                </LargeImage>
                            </dx:RibbonColorButtonItem>
                        </Items>
                    </dx:RibbonGroup>
                </Groups>
            </dx:RibbonTab>
            <dx:RibbonTab Name="Misc" Text="Misc">
                <Groups>
                    <dx:RibbonGroup Name="Find" Text="Find">
                        <Items>
                            <dx:RibbonButtonItem Name="Find" Size="Large" Text="Find">
                                <LargeImage Url="~/Images/sample-image32x32.png">
                                </LargeImage>
                            </dx:RibbonButtonItem>
                            <dx:RibbonToggleButtonItem Name="By ID">
                                <SmallImage Url="~/Images/sample-image16x16.png">
                                </SmallImage>
                            </dx:RibbonToggleButtonItem>
                        </Items>
                    </dx:RibbonGroup>
                    <dx:RibbonGroup Name="Export" Text="Export">
                        <Items>
                            <dx:RibbonDropDownButtonItem Name="Export" Size="Large" Text="Export">
                                <Items>
                                    <dx:RibbonDropDownButtonItem Name="DOC" Text="DOC">
                                        <SmallImage Url="~/Images/sample-image16x16.png">
                                        </SmallImage>
                                    </dx:RibbonDropDownButtonItem>
                                    <dx:RibbonDropDownButtonItem Name="PDF" Text="PDF">
                                        <SmallImage Url="~/Images/sample-image16x16.png">
                                        </SmallImage>
                                    </dx:RibbonDropDownButtonItem>
                                    <dx:RibbonDropDownButtonItem Name="TXT" Text="TXT">
                                        <SmallImage Url="~/Images/sample-image16x16.png">
                                        </SmallImage>
                                    </dx:RibbonDropDownButtonItem>
                                </Items>
                                <LargeImage Url="~/Images/sample-image32x32.png">
                                </LargeImage>
                            </dx:RibbonDropDownButtonItem>
                        </Items>
                    </dx:RibbonGroup>
                </Groups>
            </dx:RibbonTab>
        </Tabs>
    </dx:ASPxRibbon>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="phOptions" runat="server">
    <table>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblEnabled" SkinID="Option" CssClass="label" Text="Disabled:"
                    AssociatedControlID="cbDisabled">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="cbDisabled" SkinID="Option" Checked="false"
                    CssClass="editor" AutoPostBack="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel runat="server" ID="lblShowCollapsedGroups" SkinID="Option" CssClass="label"
                    Text="Show Collapsed Groups:" AssociatedControlID="cbShowCollapsedGroups">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxCheckBox runat="server" ID="cbShowCollapsedGroups" SkinID="Option" CssClass="editor"
                    AutoPostBack="true">
                </dx:ASPxCheckBox>
            </td>
        </tr>
    </table>
</asp:Content>
