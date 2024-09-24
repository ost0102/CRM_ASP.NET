<%@ Page Language="VB" AutoEventWireup="false" CodeFile="HelpViewer.aspx.vb" Inherits="WCF_SmartHelp_HelpViewer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="/WCF/SmartHelp/Common/jquery-1.4.2.js"></script>
    <script type="text/javascript" src="/WCF/SmartHelp/Common/splitter_v1/splitter.js"></script>
    
	<script src="/WCF/SmartHelp/Common/jquery_tree_v2/src/jquery.xmltree.plugin.min.2.0.js" type="text/javascript"></script>
	<link rel="stylesheet" href="/WCF/SmartHelp/Common/jquery_tree_v2/style/xmltree.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="/WCF/SmartHelp/Common/smarthelp.css" type="text/css" media="screen" />

    <script type="text/javascript">
        $(document).ready(function () {
            /* Init splitter */
            $("#splitterContainer").splitter({ minAsize: 100, maxAsize: 500, splitVertical: true, A: $('#leftPane'), B: $('#rightPane'), slave: $("#rightSplitterContainer"), closeableto: 0 });
            $("#rightSplitterContainer").splitter({ splitHorizontal: true, A: $('#rightTopPane'), B: $('#rightBottomPane'), closeableto: 100 });

            /* Init tree */
            var options = {
                xmlUrl: '/WCF/SmartHelp/HelpTree.aspx',
                initialExpanded: false,
                loadingText: 'Loading...',
                loadingError: 'Error: Loading Error.',
                toggleSpeed: 400,
                storeState: true
            };
            $('#xmlMenuTree').xmltree(options);
        });
    </script>
</head>
<body>
<div id="top" style="height:35px">
    <div class="wrap">
        <div class="clearfix">
            <!-- Main Navigation -->
            <ul class="nav">
                <li><a href="./HelpViewer.aspx"> Logis@FMS Online Help </a> </li>
                <!-- this is sample menu -->
                <%--<li><a href="./HelpViewer.aspx"><span>Main Menu</span></a>
                    <ul>
                        <li><a href="#">Sub Menu &amp; one</a></li>
                        <li><a href="#">Sub Menu &amp; two</a></li>
                        <li><a href="#">Sub Menu &amp; three</a></li>
                    </ul>
                </li>--%>
            </ul>
        </div>
    </div>
</div>
<div id="splitterContainer" style="height:96%">
	<div id="leftPane" style="width: 300px; height: 100%;overflow:auto;" >
		<div id="xmlMenuTree" ></div>
	</div> <!-- #leftPane -->
	<div id="rightPane" style="height:100%;">
	    <div id="nodePositionPath" style="height:3%;background:white;font-weight:bold;padding-left:5px;padding-top:4px;">
        </div>
	    <div id="rightSplitterContainer" style="height:96%;">
            <iframe src="" name="help_content" style="width:100%;height:100%;border-left:0;border-top:0;" />
        </div> <!-- #rightSplitterContainer-->
    </div> <!-- #rightPane -->
</div>

</body>
</html>
