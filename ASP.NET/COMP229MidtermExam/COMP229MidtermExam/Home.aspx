<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" Theme="MathTheme" CodeBehind="Home.aspx.cs" Inherits="COMP229MidtermExam.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Username: "></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
<asp:Button ID="Button1" runat="server" Text="Login" />
<br />
<asp:Label ID="Label4" runat="server" Text="Tip of the day in math"></asp:Label>
</asp:Content>
