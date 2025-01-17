﻿<%@ Page Title="Federation Metadata" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>
                    <%: Page.Title %>.</h1>
                <h2>Demonstrates dynamic use of metadata.</h2>
            </hgroup>
            <p>
                This sample shows how to dynamically use WS-Federation Metadata in a ASP.Net Web
                Application. For a more complete explanation of how the sample works, please refer 
                to the readme.html file in the VS solution or to the sample’s <a href="http://code.msdn.microsoft.com/Federation-Metadata-34036040">online description</a>.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Hi
        <%: Page.User.Identity.Name %>!</h3>
    <h4>Your email address is
        <asp:Label ID="emailLabel" runat="server"></asp:Label>.</h4>
    <p>
        Above you can see the name of an authenticated user and an associated email address.
    </p>
    <p>
        You can see all of the claims associated with the authenticated user below. You
        can also browse to the <a href="http://localhost:21402/federationmetadata/2007-06/federationmetadata.xml">
            WS-Federation metadata</a>generated by the WSFederationSecurityTokenService
        in this solution.
    </p>
    <h3>Your claims</h3>
    <p>
        <asp:GridView ID="ClaimsGridView" AutoGenerateColumns="false" runat="server" CellPadding="3">
            <AlternatingRowStyle BackColor="White" />
            <HeaderStyle BackColor="#7AC0DA" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="Issuer" HeaderText="Issuer" Visible="true" />
                <asp:BoundField DataField="OriginalIssuer" HeaderText="Original Issuer" Visible="false" />
                <asp:BoundField DataField="Type" HeaderText="Type" Visible="true" />
                <asp:BoundField DataField="Value" HeaderText="Value" Visible="true" />
                <asp:BoundField DataField="ValueType" HeaderText="Value Type" Visible="false" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
