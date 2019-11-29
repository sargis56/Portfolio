<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="ThankYouPage.aspx.cs" Inherits="JollyRogersOfficialWebsite.ThankYouPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <asp:Label ID="header" runat="server" Font-Bold="True" Font-Size="X-Large" style="text-align: left" text="Thank you for your purchase" />
    <br />
    <br />
    <asp:Button ID="ReturnHome" runat="server" OnClick="ReturnHome_Click" Text="Return To Homepage" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonReturnShop" runat="server" OnClick="ButtonReturnShop_Click" Text="Return To Shop" />
</asp:Content>
