<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" Inherits="ASPxThemeBuilderSite.BasePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phComponent" runat="Server">
    <script runat="server">
        protected void Page_Load(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(MapPath("~/Images/sample-image200x200.gif"));
            using(System.IO.MemoryStream ms = new System.IO.MemoryStream()) {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                ASPxBinaryImage1.ContentBytes = ms.ToArray();
            }        
        }
    </script>
    <dx:ASPxBinaryImage ID="ASPxBinaryImage1" runat="server" Caption="Caption" AlternateText="Image place" />
</asp:Content>
