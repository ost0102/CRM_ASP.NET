<%@ Page Language="VB" AutoEventWireup="false" CodeFile="XmlARAP.aspx.vb" Inherits="XmlARAP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="FM_DT" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TO_DT" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="PRT_OPTION" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblIP" runat="server"></asp:Label>
    
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
