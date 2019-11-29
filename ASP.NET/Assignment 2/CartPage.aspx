<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="_300693835_Assignment02.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 47px;
        }
        .tablestyle {
            border: 1px solid black;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <table class="tablestyle" style="width: 100%;">
        <tr>
            <td class="auto-style1" colspan="3">
                <asp:Label ID="header" runat="server" Font-Bold="True" Font-Size="X-Large" style="text-align: left" text="CART" />
            </td>
        </tr>
        <tr>
            <td class="tablestyle">
            </td>
        </tr>
    </table>
</asp:Content>
