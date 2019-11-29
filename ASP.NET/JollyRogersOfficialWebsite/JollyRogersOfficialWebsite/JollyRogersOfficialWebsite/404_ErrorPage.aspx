<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="404_ErrorPage.aspx.cs" Inherits="JollyRogersOfficialWebsite._404_ErrorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>404 Error - We Are JOLLY ROGERS</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <h2>&nbsp&nbsp&nbsp&nbsp&nbsp 404 ERROR (NOT FOUND)</h2>
    <p>The requested URL /<asp:Label runat="server" ID="lblError" />&nbsp;was not found on this server. </p>
</asp:Content>
