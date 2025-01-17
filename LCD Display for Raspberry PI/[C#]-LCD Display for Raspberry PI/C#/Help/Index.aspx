﻿<%@ Page Language="C#" EnableViewState="False" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>

<head>
<title>LCDisplay - Table of Content</title>
<link rel="stylesheet" href="TOC.css">
<link rel="shortcut icon" href="favicon.ico"/>
<script type="text/javascript" src="TOC.js"></script>
</head>

<body onload="javascript: Initialize('.aspx');" onresize="javascript: ResizeTree();">
<form id="IndexForm" runat="server">

<div id="TOCDiv" class="TOCDiv">

<div id="divSearchOpts" class="SearchOpts" style="height: 90px; display: none;">
<img class="TOCLink" onclick="javascript: ShowHideSearch(false);"
		src="Close.png" height="24" width="24" alt="Hide Search" title="Hide Search" style="float: right;"/>
	<span class="Title">Keyword(s) to search:</span>
<input id="txtSearchText" type="text" style="width: 100%;"
  onkeypress="javascript: return OnSearchTextKeyPress(event);" /><br />
	<input id="chkSortByTitle" type="checkbox" /><label for="chkSortByTitle">&nbsp;Sort results by title</label>
	<input type="button" value="Search" onclick="javascript: return PerformSearch();" style="float: right;" />
</div>

<div id="divIndexOpts" class="IndexOpts" style="height: 28px; display: none;">
<img class="TOCLink" onclick="javascript: ShowHideIndex(false);"
		src="Close.png" height="24" width="24" alt="Hide Keyword Index" title="Hide Keyword Index" style="float: right;"/>
	<span class="Title">Keyword Index</span>
</div>

<div id="divNavOpts" class="NavOpts" style="height: 28px;">
    <img class="TOCLink" onclick="javascript: SyncTOC();" src="SyncTOC.png"
        height="24" width="24" alt="Sync to TOC" title="Sync to TOC" />
    <img class="TOCLink" onclick="javascript: ExpandOrCollapseAll(true);"
        src="ExpandAll.png" height="24" width="24" alt="Expand all" title="Expand all" />
    <img class="TOCLink" onclick="javascript: ExpandOrCollapseAll(false);"
        src="CollapseAll.png" height="24" width="24" alt="Collapse all" title="Collapse all" />
    <img class="TOCLink" onclick="javascript: ShowHideIndex(true);"
        src="Index.png" height="24" width="24" alt="Keyword Index" title="Keyword Index" />
    <img class="TOCLink" onclick="javascript: ShowHideSearch(true);"
        src="Search.png" height="24" width="24" alt="Search" title="Search" />
    <img class="TOCLink" onclick="javascript: ShowDirectLink();"
        src="Link.png" height="24" width="24" alt="Get direct link to the displayed topic" title="Get direct link to the displayed topic" />
    <a href="#" onclick="javascript: TopicContent.history.go(-1); return false;">
		<img class="TOCLink" style="float: right;" 
        src="Back.png" height="24" width="24" alt="Previous page" title="Previous page" /></a>
</div>

<div class="Tree" id="divSearchResults" style="display: none;"
    onselectstart="javascript: return false;">
</div>

<div class="Tree" id="divIndexResults" style="display: none;"
    onselectstart="javascript: return false;">
</div>

<div class="Tree" id="divTree" onselectstart="javascript: return false;">
<asp:Literal ID="lcTOC" runat="server" />
</div>

</div>

<div id="TOCSizer" class="TOCSizer" onmousedown="OnMouseDown(event)" onselectstart="javascript: return false;"></div>

<iframe id="TopicContent" name="TopicContent" class="TopicContent" src="html/n-i2clibrary.htm">
This page uses an IFRAME but your browser does not support it.
</iframe>

</form>

</body>

</html>

<script runat="server">
//=============================================================================
// System  : Sandcastle Help File Builder
// File    : Index.aspx
// Author  : Eric Woodruff  (Eric@EWoodruff.us)
// Updated : 02/18/2012
// Note    : Copyright 2007-2012, Eric Woodruff, All rights reserved
// Compiler: Microsoft C#
//
// This file contains the code used to display the index page for a website
// produced by the help file builder.  The root nodes are loaded for the table
// of content.  Child nodes are loaded dynamically when first expanded using
// an Ajax call.
//
// This code is published under the Microsoft Public License (Ms-PL).  A copy
// of the license should be distributed with the code.  It can also be found
// at the project website: http://SHFB.CodePlex.com.   This notice, the
// author's name, and all copyright notices must remain intact in all
// applications, documentation, and source files.
//
// Version     Date     Who  Comments
// ============================================================================
// 1.5.0.0  06/21/2007  EFW  Created the code
// 1.9.4.0  02/18/2012  EFW  Merged code from tom103 to show direct link
//=============================================================================

protected void Page_Load(object sender, EventArgs e)
{
    StringBuilder sb = new StringBuilder(10240);
    string id, url, target, title;

    XPathDocument toc = new XPathDocument(Server.MapPath("WebTOC.xml"));
    XPathNavigator navToc = toc.CreateNavigator();
    XPathNodeIterator root = navToc.Select("HelpTOC/*");

    foreach(XPathNavigator node in root)
    {
        if(node.HasChildren)
        {
            // Write out a parent TOC entry
            id = node.GetAttribute("Id", String.Empty);
            title = node.GetAttribute("Title", String.Empty);
            url = node.GetAttribute("Url", String.Empty);

            if(!String.IsNullOrEmpty(url))
                target = " target=\"TopicContent\"";
            else
            {
                url = "#";
                target = String.Empty;
            }

            sb.AppendFormat("<div class=\"TreeNode\">\r\n" +
                "<img class=\"TreeNodeImg\" " +
                "onclick=\"javascript: Toggle(this);\" " +
                "src=\"Collapsed.png\"/><a class=\"UnselectedNode\" " +
                "onclick=\"javascript: return Expand(this);\" " +
                "href=\"{0}\"{1}>{2}</a>\r\n" +
                "<div id=\"{3}\" class=\"Hidden\"></div>\r\n</div>\r\n",
                url, target, HttpUtility.HtmlEncode(title), id);
        }
        else
        {
            title = node.GetAttribute("Title", String.Empty);
            url = node.GetAttribute("Url", String.Empty);

            if(String.IsNullOrEmpty(url))
                url = "about:blank";

            // Write out a TOC entry that has no children
            sb.AppendFormat("<div class=\"TreeItem\">\r\n" +
                "<img src=\"Item.gif\"/>" +
                "<a class=\"UnselectedNode\" " +
                "onclick=\"javascript: return SelectNode(this);\" " +
                "href=\"{0}\" target=\"TopicContent\">{1}</a>\r\n" +
                "</div>\r\n", url, HttpUtility.HtmlEncode(title));
        }
    }

    lcTOC.Text = sb.ToString();
}
</script>
