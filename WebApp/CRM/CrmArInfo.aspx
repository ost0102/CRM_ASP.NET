<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CrmArInfo.aspx.vb" Inherits="CrmArInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="CRN" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblIP" runat="server"></asp:Label>
    
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
