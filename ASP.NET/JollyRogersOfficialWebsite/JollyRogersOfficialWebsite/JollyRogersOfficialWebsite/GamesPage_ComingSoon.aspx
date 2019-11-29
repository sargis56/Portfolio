<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="GamesPage_ComingSoon.aspx.cs" Inherits="JollyRogersOfficialWebsite.GamesPage_ComingSoon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>COMING SOON . . . | Games Page - We Are JOLLY ROGERS</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <asp:AdRotator ID="advertisements" runat="server" AdvertisementFile="ads.xml" Width="100%" />
    <table style="width:100%">
        <tr>
            <td>
                <table border="1" id="tblGame102">
                    <tr>
                        <td rowspan="3" class="gameBoxArtCover">COMING SOON</td>
                        <td style="text-align:center;"><h2>
                            <asp:Label runat="server" ID="lblGameTitle102" /></h2></td>
                        <td rowspan="3">
                            <asp:Button runat="server" ID="btnPreOrder102" Text="Pre-Order" CssClass="tabbtn" OnClick="btnPreOrder_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label runat="server" ID="lblGameDate102" /></td>
                    </tr>
                    <tr>
                        <td><asp:Label runat="server" ID="lblGameDesc102" /><br />
                            <br />
                            <br />
                            <br />
                            <br /></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table border="1" id="tblGame103">
                    <tr>
                        <td rowspan="3" class="gameBoxArtCover">COMING SOON</td>
                        <td style="text-align:center;"><h2>
                            <asp:Label runat="server" ID="lblGameTitle103" /></h2></td>
                        <td rowspan="3">
                            <asp:Button runat="server" ID="btnPreOrder103" Text="Pre-Order" CssClass="tabbtn" OnClick="btnPreOrder_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label runat="server" ID="lblGameDate103" /></td>
                    </tr>
                    <tr>
                        <td><asp:Label runat="server" ID="lblGameDesc103" /><br />
                            <br />
                            <br />
                            <br />
                            <br /></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table border="1" id="tblGame104">
                    <tr>
                        <td rowspan="3" class="gameBoxArtCover">COMING SOON</td>
                        <td style="text-align:center;"><h2>
                            <asp:Label runat="server" ID="lblGameTitle104" /></h2>
                        </td>
                        <td rowspan="3">
                            <asp:Button runat="server" ID="btnPreOrder104" Text="Pre-Order" CssClass="tabbtn" OnClick="btnPreOrder_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label runat="server" ID="lblGameDate104" /></td>
                    </tr>
                    <tr>
                        <td><asp:Label runat="server" ID="lblGameDesc104" /><br />
                            <br />
                            <br />
                            <br />
                            <br /></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
