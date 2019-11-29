<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="ContactPage.aspx.cs" Inherits="JollyRogersOfficialWebsite.ContactPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contact Us - We Are JOLLY ROGERS</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <asp:AdRotator ID="advertisements" runat="server" AdvertisementFile="ads.xml" Width="100%" />
    <div style="text-align:center;">
    <asp:Label runat="server" ID="header" Text="CONTACT PAGE" Font-Bold="True" Font-Size="X-Large"/>
        </div>
    <br /><br />
    <b>Phone:</b> 416-269-7100
    <br />
    <br />
    <table>
        <tr>
            <td><b>First Name</b><span class="redfont">*</span>:&nbsp</td>
            <td><asp:TextBox ID="TextBoxFirstName" runat="server" required=""></asp:TextBox></td>
        </tr>
        <tr>
            <td><b>Last Name</b><span class="redfont">*</span>:&nbsp</td>
            <td><asp:TextBox ID="TextBoxLastName" runat="server" required=""></asp:TextBox></td>
        </tr>
        <tr>
            <td><b>Email</b><span class="redfont">*</span>:&nbsp</td>
            <td><asp:TextBox ID="TextBoxEmail" type="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}" runat="server" required=""></asp:TextBox></td>
        </tr>
        <tr>
            <td><b>Subject</b><span class="redfont">*</span>:&nbsp</td>
            <td><asp:TextBox ID="TextBoxSubject" runat="server" required=""></asp:TextBox></td>
        </tr>
        <tr>
            <td><b>Message</b><span class="redfont">*</span>:&nbsp</td>
            <td><asp:TextBox ID="TextBoxMessage" runat="server" required="" Height="85px" Width="239px"></asp:TextBox></td>
        </tr>
        <tr><td colspan="2"><br /></td></tr>
        <tr>
            <td><asp:Button ID="Submit" runat="server" Text=" SUBMIT " CssClass="tabbtn" OnClick="Submit_Click" /></td>
            <td><asp:Button ID="Clear" runat="server" Text="  CLEAR  " CssClass="tabbtn" OnClick="Clear_Click" /></td>
        </tr>
    </table>
</asp:Content>
