<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="ShopPage_OfficalHat.aspx.cs" Inherits="JollyRogersOfficialWebsite.ShopPage_OfficalHat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Official Hat | Shop Page - We Are JOLLY ROGERS</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
        <table style="width: 100%;" class="tablestyle">
        <tr>
             <td colspan="3" style="text-align:center;height:47px;">

					<asp:Label runat="server" id="header" text="SHOP PAGE" Font-Bold="True" Font-Size="X-Large" style="text-align: left" />
             </td>
        </tr>
                <tr>
             <td rowspan="2" class="tablestyle">

                 <asp:Image ID="ImageOfficalHat" runat="server" Height="172px" ImageUrl="~/Images/propeller-beanie-hat.jpg" Width="185px" />

             </td>
             <td colspan="2" class="tablestyle">

                 Offical Hat</td>
        </tr>
                <tr>
             <td class="tablestyle">

                 Price: $15.00</td>
             <td class="tablestyle">

                 <asp:Button ID="ButtonBuyNow" runat="server" Text="Buy It Now" />

             </td>
        </tr>
                <tr>
             <td class="tablestyle">

                 <asp:Button ID="ButtonMoreImages" runat="server" Text="More Images" />

             </td>
             <td class="tablestyle">

                 Quantity:
                 <asp:TextBox ID="TextBoxQuantity" runat="server" Width="42px"  maxlength="2" type="number" min="1" max="99"></asp:TextBox>

             </td>
             <td class="tablestyle">

                 <asp:Button ID="ButtonAddCart" runat="server" Text="Add To Cart" OnClick="ButtonAddCart_Click" />

             </td>
        </tr>
                <tr>
             <td colspan="3" class="tablestyle">

                 The offical Jolly Rogers hat.</td>
        </tr>
    </table>
</asp:Content>
