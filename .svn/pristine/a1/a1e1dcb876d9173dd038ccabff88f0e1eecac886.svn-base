<%@ Page Language="vb" AutoEventWireup="false" CodeFile="Tracing_login.aspx.vb" Inherits="Tracing_login" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title id="PageTitle" runat="server">
   Cargo Tracing Service
</title>
    <style type="text/css">
        .style1
        {
            height: 19px;
        }
        .style3
        {
            width: 216px;
        }
    </style>
</head>

<script type='text/javascript' language="javascript">
    ////*******************************************************************************
    //  Script for ALL
    ////*******************************************************************************

    window.onload = function() {
        //1.<<<<<<<<<<Normal onload settings>>>>>>>>>>
        //Auto select all text when focus
        $('input').focus(function() {
            this.select();
        });

        //Setup the visible block
        var isReloginMode = false;
        var isLogoutMode = false;
        if ($('#LOGOUT_BLOCK').css('display') != 'none') { initLOGOUT_BLOCK(); isLogoutMode = true; }
        if ($('#RE_LOGIN_BLOCK').css('display') != 'none') { initRE_LOGIN_BLOCK(); isReloginMode = true; }
        if ($('#FIRST_LOGIN_BLOCK').css('display') != 'none') { initFIRST_LOGIN_BLOCK(); }

        $(window).resize(function() {
            //fitLOGOUT_BLOCK();
            fitFIRST_LOGIN_BLOCK();
            fitRE_LOGIN_BLOCK();
        }).resize();
        
        
        //2.<<<<<<<<<Detect Session or FormsAuthentication Timeout happens within MDI parent>>>>>>>>>>
        if (!isReloginMode && !isLogoutMode) {
            if (window.top && window.top.mdi) {
                //Case 1: If this window is an opening mdi child (including the code search popup)
                //=> Perform relogin
                window.top.mdi.relogin();
                //Then,Close the just openned mdi child
                window.top.mdi.closeCurrentTab();
                return;
            } else {
                //Case 2: This window is MDI window itself
                if (window.mdi) {
                    window.mdi.relogin();
                    return;
                }
                try {
                    //Case 3: This window is a new browser window opened from the MDI parent
                    if (window.opener && window.opener.mdi) {
                        window.opener.mdi.relogin();
                        alert('Session timeout (3)! Please relogin to MDI parent!');
                        window.close();
                        return;
                    }
                    //Case 4: This window is a new browser window opened form a MDI child
                    if (window.opener && window.opener.top && window.opener.top.mdi) {
                        window.opener.top.mdi.relogin();
                        alert('Session timeout (4)! Please relogin to MDI parent!');
                        window.close();
                        return;
                    }
                }
                catch (err) {
                    //case 5: this window is opened in fullscreen and its openner has been closed
                    return;
                }

            }
        }

    }
   
    //Read a cookie value
    function getCookie(c_name) {
        if (document.cookie.length > 0) {
            c_start = document.cookie.indexOf(c_name + "=");
            if (c_start != -1) {
                c_start = c_start + c_name.length + 1;
                c_end = document.cookie.indexOf(";", c_start);
                if (c_end == -1) c_end = document.cookie.length;
                return unescape(document.cookie.substring(c_start, c_end));
            }
        }
        return "";
    }

    //Write a cookie value
    function setCookie(c_name, value, expiredays) {
        var exdate = new Date();
        exdate.setDate(exdate.getDate() + expiredays);
        document.cookie = c_name + "=" + escape(value) +
            ((expiredays == null) ? "" : ";expires=" + exdate.toUTCString());
    }

    ////*******************************************************************************
    //  Script for FIRST_LOGIN_BLOCK
    ////*******************************************************************************
    function initFIRST_LOGIN_BLOCK() {
        //First focus
        $('#txtUsername').keydown(function(event) {
            if (event.keyCode == '13') {
                event.preventDefault();
                $('#txtPassword').focus();
            }
        });

        $('#txtPassword').keydown(function(event) {
            if (event.keyCode == '13') {
                event.preventDefault();
                $('#btnLogin').click();
            }
        });

        recoverLoginState();
        
    }

    //Centralize div block into screen central
    function fitFIRST_LOGIN_BLOCK() {
        var block = document.getElementById('FIRST_LOGIN_BLOCK');
        if (block.style.display == 'none') { return; }
        var nLeft = (parseInt($(window).width() - $(block).width()) / 2) + $(window).scrollLeft() + "px";
        var nTop = (parseInt($(window).height() - $(block).height()) / 2) + $(window).scrollTop() + "px";
        $(block).css({ 'position': 'absolute', 'left': nLeft, 'top': nTop });
    }



    function btnLogin_onClick() {
        if ($('#txtUsername').val() == '') {
            alert('Please input User ID!');
            $('#txtUsername').focus();
        } else {
            saveLoginState();
            document.getElementById("form1").submit();
        }
    }

    function recoverLoginState() {

        $('#txtUsername').val(getCookie("Username"));
        $('#txtPassword').val(getCookie("Password"));
        
        if (getCookie("chkRememberMe") == 'true') {
            document.getElementById('chkRememberMe').checked = true;
        } else {
            document.getElementById('chkRememberMe').checked = false;
        }

        if (getCookie("chkFullScreen") == 'true') {
            document.getElementById('chkFullScreen').checked = true;
        } else {
            document.getElementById('chkFullScreen').checked = false;
        }
        
        if (getCookie("chkSignMeAuto") == 'true') {
            document.getElementById('chkSignMeAuto').checked = true;
            //Auto login (Pending: Should be disabled during product released)
            if ($("#LOGIN_STATUS").val() != 'FAIL') {
                btnLogin_onClick();
            }
        } else {
            document.getElementById('chkSignMeAuto').checked = false;
        }
        
    }

    function saveLoginState() {
        setCookie("Username", $('#txtUsername').val(), 7);
        var savePassYN = document.getElementById('chkRememberMe').checked;
        setCookie("chkRememberMe", savePassYN, 7);
        var signMeYN = document.getElementById('chkSignMeAuto').checked;
        setCookie("chkSignMeAuto", signMeYN, 7);

        var fullScreen = document.getElementById('chkFullScreen').checked;
        setCookie("chkFullScreen", fullScreen, 7);
        
        if (savePassYN) {
            setCookie("Password", $('#txtPassword').val(), 7);
        } else {
            setCookie("Password", '', 7);
        }
    }



    ////*******************************************************************************
    //  Script for RE_LOGIN_BLOCK
    ////*******************************************************************************
    function initRE_LOGIN_BLOCK() {
        $('#RE_LOGIN_BLOCK').width($(window).width()).height($(window).height());
        if ($('#lblRE_LOGIN_DONE').text() != '') {   //successful message
            //Close the relogin window, restart polling for timeout status
            if (window.top && window.top.mdi) {
                var mdi = window.top.mdi;
                window.setTimeout(function() {
                    mdi.hideTopMostDialog();
                    mdi.startAutoDetectSessionTimeout();
                }, 1000);
            }
            
            
        }

        $('#txtReUsername').keydown(function(event) {
            if (event.keyCode == '13') {
                event.preventDefault();
                $('#txtRePassword').focus();
            }
        }).val(getCookie("Username")).focus();

        $('#txtRePassword').keydown(function(event) {
            if (event.keyCode == '13') {
                event.preventDefault();
                $('#btnReLogin').click();
            }
        });
    }

    function fitRE_LOGIN_BLOCK() {
        if ($('#RE_LOGIN_BLOCK').css('display') == 'none') { return; }
        var windowHeight = $(window).height();
        var PCA = document.getElementById('RE_LOGIN_PCA');
        var HDR = document.getElementById('RE_LOGIN_HDR');
        //Re-calculate size of PGM_CONTENT_AREA to fit the container
        if (PCA && HDR && windowHeight > 0) {
            PCA.style.position = 'absolute';
            PCA.style.left = 0;
            PCA.style.top = $(HDR).height();
            PCA.style.height = (windowHeight - $(HDR).height()) + 'px';
            $(PCA).width('100%');
            $(HDR).width($(PCA).width() + 12);
        }
    }
    
    function btnReLogin_onClick() {
        if ($('#txtReUsername').val() == '') {
            alert('Please input Username!');
            $('#txtReUsername').focus();
        } else {
            document.form1.submit();
        }
    }

    ////*******************************************************************************
    //  Script for LOGOUT_BLOCK
    ////*******************************************************************************

    function initLOGOUT_BLOCK() {
        if ($('#LOGOUT_DONE').css('display') != 'none') {   //successful message
            //Clear the auto login cookie
            setCookie('chkSignMeAuto', false);
            //Close the relogin window
            if (window.top && window.top.mdi) {
                window.setTimeout("window.top.mdi.quit();", 100);
            }
        }
    }

    function btnLogoutConfirm_onClick(){
        document.form1.submit();
    }

    function btnLogoutCancel_onClick() {
        if (window.top && window.top.mdi) {
            window.top.mdi.hideTopMostDialog();
        }
    }

    function Non_Cust_Tracing() {

        document.location.href = "/TRC/Tracing_ncust.aspx";
    }   

</script>
<body style="background:#eee url(App_Themes/Default/Images/Econo/login_bg.jpg) 100% 0 no-repeat; background-size:100%; margin:0;">
    <form id="form1" runat="server"> 
        <div id="FIRST_LOGIN_BLOCK" style="min-width:95%; margin:0 auto; position: absolute; top: 0px;" runat="server" >
            <div style="width:429px; margin:0 auto; padding:0px 0px 50px 0px;"><img src="App_Themes/Default/Images/Econo/login_top2.png" />
            </div>
            <asp:HiddenField ID="LOGIN_STATUS" runat="server"/>
            <div style="width:621px; min-height:250px; margin:0 auto; padding:305px 0px 0px 0px; background:url(App_Themes/Default/Images/Econo/login_box2.png) no-repeat">
                <table border="0" align="center">
                    <tr>
                        <td height="55">
                            <asp:DropDownList ID="CNTR_HBL_TYPE" runat="server">
                                <asp:ListItem Value="B">B/L No.</asp:ListItem>
                                <asp:ListItem Value="C">Container No.</asp:ListItem>
                            </asp:DropDownList>
                            </td>
                        <td>
                            <asp:TextBox ID="CNTR_HBL_NO"  CssClass="TextBox" runat="server" style="width:150px;"/>
                        </td>
                        <td width="90" align="center">
                            <asp:ImageButton ID="btnSearch" runat="server" 
                                ImageUrl="App_Themes/Default/Images/Econo/login_btn_search.png" 
                                BorderStyle="None" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right"><a href="#"><img src="App_Themes/Default/Images/Econo/login_txt_id.png" alt="Search" border="0" /></a></td>
                        <td width="155"> 
                            <asp:TextBox ID="txtUsername"  CssClass="TextBox" runat="server" style="width:150px;" 
                                TabIndex="1" />
                        </td>
                       
                        <td rowspan="2">
                            <%--<input type="submit" id="Submit1" onclick="btnLogin_onClick();return false;" value="Login!" tabindex="3" />--%>
                            <asp:ImageButton ID="btnLogin" runat="server" style="border:none; height:47px; width:85px" ImageUrl="App_Themes/Default/Images/Econo/login_btn.png"  />
                        </td>
                    </tr>
                    <tr>
                        <td align="right"><a href="#"><img src="App_Themes/Default/Images/Econo/login_txt_pw.png" alt="Search" border="0" /></a></td>
                        <td width="155"> <asp:TextBox ID="txtPassword"  CssClass="TextBox" runat="server" 
                                TextMode="Password" style="width:150px;" TabIndex="2" /></td>
                    </tr>
                    <tr>
                            <td colspan=3 style="font-size:11px; font-family:Arial;" class="style1">
                            <ywc:Label ID="lblMessage" runat="server" Font-Names="Courier" ForeColor="Red" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>

