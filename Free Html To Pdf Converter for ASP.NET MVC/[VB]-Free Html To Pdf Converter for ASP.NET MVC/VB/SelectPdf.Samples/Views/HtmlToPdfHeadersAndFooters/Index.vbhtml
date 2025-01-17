﻿@code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "SelectPdf Free Html To Pdf Converter for .NET - Pdf Headers and Footers with Html to Pdf Converter - VB.NET / ASP.NET MVC"
    ViewBag.Description = "SelectPdf Free Html To Pdf Converter Pdf Headers and Footers with Html to Pdf Converter Sample for VB.NET/ASP.NET MVC. Pdf Library for .NET with full sample code in C# and VB.NET."
    ViewBag.Keywords = "header, footer, pdf library, sample code, html to pdf, pdf converter"
end code

@Using (Html.BeginForm("SubmitAction", "HtmlToPdfHeadersAndFooters", FormMethod.Post))

    @<article class="post type-post status-publish format-standard hentry">
        <header class="entry-header">
            <h1 class="entry-title">SelectPdf Free Html To Pdf Converter - Pdf Headers and Footers with Html to Pdf Converter - VB.NET / ASP.NET MVC Sample</h1>
        </header>
        <!-- .entry-header -->

        <div class="entry-content">
            <p>
                This sample shows how to convert an url to pdf using SelectPdf Pdf Library for .NET and how to set html headers and footers for the generated pdf document.
                <br />
                <br />
                This sample will also show how to add page numbers in the footer of the generated pdf document.
            </p>
            <p>
                Url:<br />
                <input type="text" value="http://selectpdf.com" name="TxtUrl" style="width:90%" />
            </p>
            <div class="col2">
                Header:<br />
                <input type="checkbox" name="ChkHeaderFirstPage" checked="checked">Show on First Page
                <br />
                <input type="checkbox" name="ChkHeaderOddPages" checked="checked">Show on Odd Numbered Pages
                <br />
                <input type="checkbox" name="ChkHeaderEvenPages" checked="checked">Show on Even Numbered Pages
                <br />
                Height:&nbsp;<input type="text" value="50" name="TxtHeaderHeight" style="width:50px" /> px<br />
                <a href="files/header.html" target="_blank">Sample header</a><br />
                <br />
            </div>
            <div class="col2">
                Footer:<br />
                <input type="checkbox" name="ChkFooterFirstPage" checked="checked">Show on First Page
                <br />
                <input type="checkbox" name="ChkFooterOddPages" checked="checked">Show on Odd Numbered Pages
                <br />
                <input type="checkbox" name="ChkFooterEvenPages" checked="checked">Show on Even Numbered Pages
                <br />
                Height:&nbsp;<input type="text" value="30" name="TxtFooterHeight" style="width:50px" /> px<br />
                <input type="checkbox" name="ChkPageNumbering" checked="checked">Add page numbers
                <br />
                <a href="files/footer.html" target="_blank">Sample footer</a><br />
                <br />
            </div>
            <div class="col-clear"></div>
            <p>
                <input type="submit" name="BtnConvert" value="Create PDF" class="mybutton" />
            </p>
        </div>
        <!-- .entry-content -->
    </article>
End Using
    