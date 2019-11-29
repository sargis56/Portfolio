<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="AboutPage.aspx.cs" Inherits="JollyRogersOfficialWebsite.AboutPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>About Page - We Are JOLLY ROGERS</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <asp:AdRotator ID="advertisements" runat="server" AdvertisementFile="ads.xml" Width="100%" />
    <table style="width: 100%; text-align:center;">
        <tr>
            <td colspan="2">
                <h1>PAGE SELECTION</h1>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" ID="btnOurCrew" OnClick="btnOurCrew_Click" CssClass="tabbtn" Text="OUR CREW" />
            </td>
            <td>
                <asp:Button runat="server" ID="btnTheShip" OnClick="btnTheShip_Click"  CssClass="tabbtn" Text="THE SHIP" />
            </td>
        </tr>
    </table>
</asp:Content>
