<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="ShopPage.aspx.cs" Inherits="_300693835_Assignment02.ShopPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 200px;
        }
        .tablestyle {
            border: 1px solid black;
        }
        .tablestyle2 {
            border: 1px solid black;
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <table style="width: 100%;">
        <tr>
             <td colspan="3" style="height: 47px" class="centercell">

					<asp:Label runat="server" id="header" text="SHOP PAGE" Font-Bold="True" Font-Size="X-Large" style="text-align: left" />
             </td>
        </tr>
                <tr>
             <td>

					 <asp:Button ID="GamesBut" runat="server" OnClick="GamesBut_Click" style="z-index: 1; left: 389px; position: absolute" Text="GAMES" />
    <asp:Button ID="MerchBut" runat="server" OnClick="MerchBut_Click" style="z-index: 1; left: 481px; position: absolute" Text="MERCH" />
             <br/>
                 <br/>
             </td>
        </tr>
    </table>
   
    <asp:MultiView ID="ShopView" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <table style="width: 100%;" class="tablestyle">
                <tr>
                    <td class="tablestyle2" rowspan="3">
                        <asp:ImageButton ID="ImageButtonGame1" runat="server" ImageUrl="Images/Company Logo Black - Copy.png" OnClick="ImageButtonGame1_Click" />
                    </td>
                    <td class="tablestyle">
                        <asp:HyperLink ID="HyperLinkGame1" runat="server" NavigateUrl="~/ShopPage_OneBone.aspx">One Bone</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="tablestyle">Price: $20.99</td>
                </tr>
                <tr>
                    <td class="tablestyle">Best game ever</td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <table style="width: 100%;"  class="tablestyle">
                <tr class="tablestyle">
                    <td class="tablestyle2" rowspan="3">
                        <asp:ImageButton ID="ImageButtonMerch1" runat="server" ImageUrl="~/Images/propeller-beanie-hat.jpg" Width="199px" OnClick="ImageButtonMerch1_Click" />
                    </td>
                    <td class="tablestyle">
                        <asp:HyperLink ID="HyperLinkMerch1" runat="server" NavigateUrl="~/ShopPage_OfficalHat.aspx">Offical Hat</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="tablestyle">Price: $15.00</td>
                </tr>
                <tr">
                    <td class="tablestyle">The offical Jolly Rogers hat.</td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>

</asp:Content>
