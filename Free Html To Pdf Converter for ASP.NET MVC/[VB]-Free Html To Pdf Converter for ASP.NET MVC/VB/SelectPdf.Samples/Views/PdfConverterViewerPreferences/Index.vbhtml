﻿@code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "SelectPdf Free Html To Pdf Converter for .NET - Setting Pdf Viewer Preferences for the Html to Pdf Converter - VB.NET / ASP.NET MVC"
    ViewBag.Description = "SelectPdf Free Html To Pdf Converter Setting Pdf Viewer Preferences for the Html to Pdf Converter Sample for VB.NET ASP.NET MVC. Pdf Library for .NET with full sample code in C# and VB.NET."
    ViewBag.Keywords = "html to pdf converter, pdf viewer preferences, pdf library, sample code, html to pdf, pdf converter"
End code

@Using (Html.BeginForm("SubmitAction", "PdfConverterViewerPreferences", FormMethod.Post))

    @<article class="post type-post status-publish format-standard hentry">
        <header class="entry-header">
            <h1 class="entry-title">SelectPdf Free Html To Pdf Converter - Setting Pdf Viewer Preferences with the Html to Pdf Converter - VB.NET / ASP.NET MVC Sample</h1>
        </header>
        <!-- .entry-header -->

        <div class="entry-content">
            <p>
                This sample shows how to convert from html to pdf using SelectPdf and set the pdf viewer preferences.
                With the viewer preferences, users can specify how the pdf document will appear in a pdf viewer when it is opened.
            </p>
            <p>
                Url:<br />
                <input type="text" id="TxtUrl" name="TxtUrl" style="width:90%" value="http://selectpdf.com" />
            </p>
            <div class="col2">
                Page Layout:<br />
                <select id="DdlPageLayout" name="DdlPageLayout">
                    <option value="SinglePage">SinglePage</option>
                    <option value="OneColumn" selected>OneColumn</option>
                    <option value="TwoColumnLeft">TwoColumnLeft</option>
                    <option value="TwoColumnRight">TwoColumnRight</option>
                </select><br/>
                <br />
                Page Mode:<br />
                <select id="DdlPageMode" name="DdlPageMode">
                    <option value="UseNone" selected>UseNone</option>
                    <option value="UseOutlines">UseOutlines</option>
                    <option value="UseThumbs">UseThumbs</option>
                    <option value="FullScreen">FullScreen</option>
                    <option value="UseOC">UseOC</option>
                    <option value="UseAttachments">UseAttachments</option>
                </select><br />
                <br />
            </div>
            <div class="col2">
                <input type="checkbox" id="ChkCenterWindow" name="ChkCenterWindow" /> Center Window<br />
                <input type="checkbox" id="ChkDisplayDocTitle" name="ChkDisplayDocTitle" /> Display Doc Title<br />
                <input type="checkbox" id="ChkFitWindow" name="ChkFitWindow" /> Fit Window<br />
                <input type="checkbox" id="ChkHideMenuBar" name="ChkHideMenuBar" /> Hide Menu Bar<br />
                <input type="checkbox" id="ChkHideToolbar" name="ChkHideToolbar" /> Hide Toolbar<br />
                <input type="checkbox" id="ChkHideWindowUI" name="ChkHideWindowUI" /> Hide Window UI<br />
                <br />
            </div>
            <div class="col-clear"></div>
            <p>
                <input type="submit" id="BtnCreatePdf" value="Create PDF" class="mybutton" />
            </p>
        </div>
        <!-- .entry-content -->
    </article>
       
end Using
