<%@ Page Language="vb" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title id="PageTitle" runat="server">
    Login!
</title>
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
    
function btnLogin_onclick() {

}

</script>

<body>


    <form id="form1" runat="server">
       <asp:HiddenField ID="LOGIN_STATUS" runat="server" />
		<div id="FIRST_LOGIN_BLOCK" style="width:800px;height:600px" runat="server">
            <table cellspacing="0" cellpadding="0" border="0" align="center">
                <tr>
                    <td colspan="2">
                      <%--  <object id="welcome" width="800" height="516" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"
                            codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,79,0">
                            <param name="movie" value="<%#ThemeURL %>Images/welcome.swf">
                            <param name="bgcolor" value="#FFFFFF">
                            <param name="quality" value="high">
                            <param name="seamlesstabbing" value="false">
                            <param name="allowscriptaccess" value="samedomain">
                            <embed type="application/x-shockwave-flash" pluginspage="http://www.adobe.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash"
                                name="welcome" width="800" height="516" src="<%#ThemeURL %>Images/welcome.swf"
                                bgcolor="#FFFFFF" quality="high" seamlesstabbing="false" allowscriptaccess="samedomain">
                              <noembed>
                              </noembed>
                            </embed>
                        </object>--%>
                        <img src="/App_Themes/Default/Images/main_page/main_mcigis.jpg" width="800" height="516"></img>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <table width="100%" border="0" bgcolor="#FFFFFF" cellpadding="0" cellspacing="0">
                            <tr>
                                <td height="2px" colspan="8">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td width="100%" bgcolor="#2D6799" colspan="8">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 50px; font-weight: bold; color: #5E2128">Domain:</td>
                                <td><asp:TextBox ID="txtDomain"  CssClass="TextBox" runat="server" Width="100px" /></td>
                                <td style="width: 30px;height:45px;text-align: right; font-weight: bold; color: #5E2128">
                                    ID
                                </td>
                                <td align="left" >
                                    <asp:TextBox ID="txtUsername" CssClass="TextBox" runat="server" Width="80px" />
                                </td>
                                <td style="width: 50px; font-weight: bold; color: #5E2128">
                                    Password
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="txtPassword"  CssClass="TextBox" runat="server" TextMode="Password"
                                        Width="80px" />
                                </td>                                
                                <td width="50px">
                                    <input type="submit" id="btnLogin" onclick="btnLogin_onClick();return false;" value="Login!" style="font-weight: bold;
                                        width: 70px; height: 20px; border: 1px solid #3a6ea5" onclick="return btnLogin_onclick()" />
                                </td>
                                <td>
                                   <asp:CheckBox Width="200px" ID="chkFullScreen" Text="Full screen" runat="server" />
                                    <%--<img id="Img1" src="<%#ThemeURL %>Images/activex.jpg" border="0" alt="title" />--%>
                                </td>                                
                            </tr>
                            <tr>
                                <td colspan="5"></td>                                
                                <td colspan="2" align="right">
                                    <asp:CheckBox ID="chkRememberMe" Text="Remember me" runat="server" />
                                </td>                                
                                <td>
                                    <asp:CheckBox ID="chkSignMeAuto" Text="Sign me in automatically" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td width="100%" bgcolor="#2D6799" colspan="7">
                                </td>
                            </tr>                                                                            
                        </table>
                    </td>
                </tr>  
                                  
                <tr>
                    <td width="540px">
                        <ywc:Label ID="lblMessage" runat="server" Font-Names="Courier" ForeColor="Red" />&nbsp;
                        &nbsp;
                    </td>
                </tr>
            </table>
        </div>
   
        <div id="RE_LOGIN_BLOCK" style="width:100%;height:100%;" runat="server">
            <ywc:PageHeader ID="RE_LOGIN_HDR" Width="100%" runat="server" DataDriven="False" />
            <table id="RE_LOGIN_PCA" border="0" cellspacing="0" Width="100%" cellpadding="0" class="pgm_content_container" style="border-bottom:#c0c0c0 1px solid;height: auto">
                <tr>
                    <td align="center">
                        <br />
                        <div id="RE_LOGIN_UI" runat="server">
                            <table cellspacing="0" cellpadding="0" width="100%">
                                <tr>
                                    <td width="120px" align="right">
                                        ID
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtReUsername" runat="server" Width="100px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td width="120px" align="right">
                                        Password
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtRePassword" TextMode="Password" runat="server" Width="100px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" align="center">
                                        <br />
                                        <input type="submit" id="btnReLogin" onclick="btnReLogin_onClick();return false;" value="Login!"
                                            style="font-weight: bold; width: 70px; height: 20px; border: 1px solid #3a6ea5" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <br />
                        
                        <asp:Label ID="lblRE_LOGIN_FAILED" runat="server" ForeColor="Red" />&nbsp;
                        
                        <div id="RE_LOGIN_DONE" style="display:none;text-align:center;" runat="server">
                            <asp:Label ID="lblRE_LOGIN_DONE" runat="server" ForeColor="Gray" />&nbsp;
                            <br />
                            <img src="/App_Themes/Default/Images/progress/ajax-loader-small-squares.gif" align="center">
                        </div>
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
        
        <div id="LOGOUT_BLOCK" style="width:300px; height: 200px;" runat="server">
            <ywc:PageHeader ID="LOGOUT_HDR" runat="server" Width="100%" DataDriven="False" />
            <table id="LOGOUT_PCA" border="0" cellspacing="0" cellpadding="0" class="pgm_content_container" style="border-bottom:#c0c0c0 1px solid;height: auto">
                <tr>
                    <td>
                        <br />
                        <div id="LOGOUT_CONFIRM_UI" style="text-align:center;vertical-align:top" runat="server">
                            Are you sure you want to logout? <br /><br />
                            <input type="submit" id="btnLogoutConfirm" onclick="btnLogoutConfirm_onClick();return false;" value="Sure"
                                            style="font-weight: bold; width: 70px; height: 20px; border: 1px solid #3a6ea5" />
                                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <input type="submit" id="btnLogoutCancel" onclick="btnLogoutCancel_onClick();return false;" value="Cancel"
                                            style="font-weight: bold; width: 70px; height: 20px; border: 1px solid #3a6ea5" />
                            <br />
                        </div>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <br />
                        <br />
                        <div id="LOGOUT_DONE" style="display:none;text-align:center;" runat="server">
                            <asp:Label ID="lblLOGOUT_DONE" runat="server" ForeColor="Gray" />&nbsp;
                            <br />
                            <img src="/App_Themes/Default/Images/progress/ajax-loader-small-squares.gif" align="center">
                        </div>
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

