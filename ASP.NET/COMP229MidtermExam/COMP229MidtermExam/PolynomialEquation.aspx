<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" Theme="MathTheme" CodeBehind="PolynomialEquation.aspx.cs" Inherits="COMP229MidtermExam.PolynomialEquation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span lang="EN-US" style="font-size:14.0pt;line-height:
107%;font-family:&quot;Calibri&quot;,sans-serif;mso-ascii-theme-font:minor-latin;
mso-fareast-font-family:Calibri;mso-fareast-theme-font:minor-latin;mso-hansi-theme-font:
minor-latin;mso-bidi-font-family:Arial;mso-bidi-theme-font:minor-bidi;
mso-ansi-language:EN-US;mso-fareast-language:EN-US;mso-bidi-language:AR-SA"><asp:Label ID="Label6" runat="server" BackColor="White" Text="Polynomial Equation"></asp:Label>
<br />
<br />
<asp:Image ID="Image1" runat="server" ImageUrl="~/Images/stuff.jpg" Width="683px" />
<br />
</span>
<asp:Image ID="Image2" runat="server" ImageUrl="~/Images/stuff2.jpg" Width="654px" />
<br />
<br />
<asp:Label ID="Label1" runat="server" BackColor="White" Text="A="></asp:Label>
<asp:TextBox ID="TextBoxA" runat="server" TextMode="number" SkinID="txtSkin">0</asp:TextBox>
&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label2" runat="server" BackColor="White" Text="B="></asp:Label>
<asp:TextBox ID="TextBoxB" runat="server" TextMode="number" SkinID="txtSkin">0</asp:TextBox>
&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label3" runat="server" BackColor="White" Text="C="></asp:Label>
<asp:TextBox ID="TextBoxC" runat="server" TextMode="number" SkinID="txtSkin">0</asp:TextBox>
<br />
&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label4" runat="server" BackColor="White" Text="X1="></asp:Label>
<asp:TextBox ID="TextBoxAnswer1" TextMode="number" runat="server">0</asp:TextBox>
&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label5" runat="server" BackColor="White" Text="X2="></asp:Label>
<asp:TextBox ID="TextBoxAnswer2" TextMode="number" runat="server">0</asp:TextBox>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calc X1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Calc X2" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Calc X1 and X2" />
<br />
</asp:Content>
