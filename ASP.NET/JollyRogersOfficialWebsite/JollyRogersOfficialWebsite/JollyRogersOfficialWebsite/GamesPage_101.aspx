<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="GamesPage_101.aspx.cs" Inherits="JollyRogersOfficialWebsite.GamesPage_101" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <title>AMAZON FIGHTERS | Games Page - We Are JOLLY ROGERS</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <div style="padding-left:2em;">
        <asp:AdRotator ID="advertisements" runat="server" AdvertisementFile="ads.xml" Width="100%" />
    <table border="1">
        <tr>
            <td colspan="2" rowspan="2" class="gameBoxArtCover">TO BE UPDATED</td>
            <td colspan="3" style="text-align:center;">
                <h2><asp:Label runat="server" ID="lblGameTitle" /></h2>
            </td>
            <td style="text-align:right; font-style:italic; font-variant:small-caps; letter-spacing:3px;">
                <asp:Label runat="server" ID="lblGameSeries" />
            </td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>Genre: </td>
                        <td>
                            <asp:Label runat="server" ID="lblGenre" />
                        </td>
                    </tr>
                    <tr>
                        <td>Release Date: </td>
                        <td><asp:Label runat="server" ID="lblReleaseDate" /></td>
                    </tr>
                    <tr>
                        <td>Rating: </td>
                        <td><asp:Label runat="server" ID="lblRating" /></td>
                    </tr>
                    <tr>
                        <td>Platform(s): </td>
                        <td><asp:Label runat="server" ID="lblPlatform" /></td>
                    </tr>
                    <tr>
                        <td>Mode(s): </td>
                        <td><asp:Label runat="server" ID="lblMode" /></td>
                    </tr>
                </table>
            </td>
            <td>
                <table>
                    <tr>
                        <td>Publisher: </td>
                        <td><asp:Label runat="server" ID="lblPublisher" /></td>
                    </tr>
                    <tr>
                        <td>Director: </td>
                        <td><asp:Label runat="server" ID="lblDirector" /></td>
                    </tr>
                    <tr>
                        <td>Producer: </td>
                        <td><asp:Label runat="server" ID="lblProducer" /></td>
                    </tr>
                    <tr>
                        <td>Programmer: </td>
                        <td><asp:Label runat="server" ID="lblProgrammer" /></td>
                    </tr>
                    <tr>
                        <td>Artist: </td>
                        <td><asp:Label runat="server" ID="lblArtist" /></td>
                    </tr>
                </table>
            </td>
            <td colspan="2">
                <table style="text-align:center;">
                    <tr><td class="gameTable_Edit">
                        <asp:Button runat="server" ID="download" Text="Download Demo" OnClick="download_Click" />
                        </td></tr>
                    <tr><td class="gameTable_Edit"></td></tr>
                    <tr><td class="gameTable_Edit">
                        <asp:Button runat="server" ID="buy" Text="     Buy Game     "  OnClick="buy_Click" />
                        </td></tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="6"><br /><br />
                <asp:Label runat="server" ID="lblGameDesc" />
            </td>

        </tr>
        </table>
        </div>
</asp:Content>
