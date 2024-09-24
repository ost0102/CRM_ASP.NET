<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Manifest.aspx.vb" Inherits="WCF_Client_Manifest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:100%;height:100%;">

        <center><div style="font-size:300%">Comment editor</div></center>
        <br />
        <br />

        <table cellspacing="0" cellpadding="2" width="100%" border="1" style="border:1px solid gray;">
        <tr>
            <th>Seq</th>
            <th>File</th>
            <th>Comment</th>
            <th>Author</th>
        </tr>
        
        <%
            Dim i As Integer = 0
            For Each key As String In dicFileManifest.Keys
                If key.StartsWith("DevExpress.") then Continue for
                i = i + 1
        %>
        <tr>
            <td width="30px"><%Response.Write(i) %></td>
            <td width="100%"><%Response.Write(key) %></td>
            <td><textarea name="<%Response.Write("c_" & key) %>"  cols="50" rows="3"><%Response.Write(dicFileManifestComments(key)) %></textarea></td>
            <td width="100px"><input name="<%Response.Write("a_" & key) %>" maxlength="100" size="15" value="<%Response.Write(dicFileAuthor(key)) %>" /></td>
        </tr>
        <%         
            Next
        %>
        <tr>
            <td colspan=3 align="center">
                <br />
                <input type="submit" value="Update comments!" />
                <br />
                <br />
            </td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
