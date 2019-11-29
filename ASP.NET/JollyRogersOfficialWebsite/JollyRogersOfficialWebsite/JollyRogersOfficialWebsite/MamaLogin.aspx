<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="MamaLogin.aspx.cs" Inherits="JollyRogersOfficialWebsite.MamaLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <p>
        <strong>Management Login</strong></p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Please enter login info"></asp:Label>
    </p>
    <p>
        Login:
        <asp:TextBox ID="TextBox1" runat="server" required></asp:TextBox>
    </p>
    <p>
        Password:
        <asp:TextBox type="password" ID="TextBox2" runat="server" required></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check" />
    </p>
</asp:Content>
