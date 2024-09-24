<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Setup.aspx.vb" Inherits="WCF_Client_Setup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
        function btnLogin_onClick() {
            if ($("#DOMAIN").val() == "") {
                alert("Please input domain!");
                $("#DOMAIN").focus();
                return;
            }
            document.getElementById("form1").submit();
        }

        window.onload = function () {
            document.getElementById("DOMAIN").focus();
        }

        function domain_onKeyDown() {
            if (event.keyCode == 13) {
                btnLogin_onClick();
            }
        }

    </script>
</head>

<body style="background-position:center top; margin-top:0px; background-color:#4d88b8;">
<div style="width:619px; height:446px; margin:0 auto; background-image:url(./images/login_bg2.png); position:relative; top:100px;">
    <form id="form1" runat="server">
        <div style="position:relative; top:316px; left:130px;">
        <table cellpadding="2" cellspacing="0">
            <tr>
              <td width="80" style="text-align:right; font-family:arial; font-size:12px;">Domain</td>
              <td>
              <asp:TextBox ID="DOMAIN" Width="180px" style="height:18px;text-transform:uppercase" onkeydown="domain_onKeyDown();"  runat="server"/>
              </td>
              <td>
                    <a href="#"><img src="./images/login_btn2.png" alt="" border="0" onclick="btnLogin_onClick();" runat="server" /> </a>
              </td>
            </tr>
            <tr>
                <td colspan="3" height="40px"> &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                <asp:Label ID="lblResult" ForeColor="Red" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        </div>
    </form>
</div>
</body>
</html>
