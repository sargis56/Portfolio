<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="GamesPage.aspx.cs" Inherits="JollyRogersOfficialWebsite.GamesPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Games Page - We Are JOLLY ROGERS</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <asp:AdRotator ID="advertisements" runat="server" AdvertisementFile="ads.xml" Width="100%" />
    <table style="width: 100%; text-align:center;">
        <tr>
            <td colspan="3">
                <h1>PAGE SELECTION</h1>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="btnPage_100" OnClick="btnPage_100_Click" CssClass="tabbtn" />
            </td>
            <td>
                <asp:Button runat="server" ID="btnPage_101" OnClick="btnPage_101_Click" CssClass="tabbtn" />
            </td>
            <td>
                <asp:Button runat="server" ID="btnPage_ComingSoon" OnClick="btnPage_ComingSoon_Click" CssClass="tabbtn" />
            </td>
        </tr>
    </table>
</asp:Content>
