<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="assignment01.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%-- Title of the website--%>
    <title>Centennial</title>
    <%-- Website's icon--%>
    <link rel="icon" type="image/png" href="https://icons8.com/icon/18041/Strawberry" />
    <%-- Website's style sheets--%>
	<style type="text/css">
	.auto-style1 {
		text-align: center;
	}
	.auto-style2 {
	color: #FF0000;
	font-family: Arial, Helvetica, sans-serif;
}
	.auto-style3 {
    line-height: 200%;
	font-family: Arial, Helvetica, sans-serif;
}
	</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
    <p class="auto-style1">
        <span class="auto-style3">
            <%-- Website header--%>
        <strong>Member Registration</strong></span><br class="auto-style3" />
    </p>
    <%-- Handels textboxs as well as their texts beside them--%>
    <p>
        <span class="auto-style3">Please complete the following fields:</span><br class="auto-style3" />
        <%-- First name textbox and corresponding text--%>
        <span class="auto-style3">First Name</span><span class="auto-style2">*</span>: <asp:TextBox ID="TextBoxFirstName" runat="server" required></asp:TextBox>
        <br class="auto-style3" />
        <%-- Last name textbox and corresponding text--%>
        <span class="auto-style3">Last Name</span><span class="auto-style2">*</span>: 
        <asp:TextBox ID="TextBoxLastName" runat="server" required></asp:TextBox>
        <br class="auto-style3" />
        <%-- Address textbox and corresponding text--%>
        <span class="auto-style3">Address</span><span class="auto-style2">*</span><span class="auto-style3">: 
		</span> 
        <asp:TextBox ID="TextBoxAddress" runat="server" Width="287px" required></asp:TextBox>
        <br class="auto-style3" />
        <%-- City textbox and corresponding text--%>
        <span class="auto-style3">City</span><span class="auto-style2">*</span><span class="auto-style3">: 
		</span> 
        <asp:TextBox ID="TextBoxCity" runat="server" required></asp:TextBox>
        <br class="auto-style3" />
        <%-- Province textbox and corresponding text--%>
        <span class="auto-style3">Province</span><span class="auto-style2">*</span><span class="auto-style3">: 
		</span> 
        <asp:TextBox ID="TextBoxProvince" runat="server" Width="31px" style="text-transform:uppercase" pattern="[A-Za-z]{2}" maxlength="2" required></asp:TextBox>
        <br class="auto-style3" />
        <%-- Postal code textbox and corresponding text--%>
        <span class="auto-style3">Postal Code</span><span class="auto-style2">*</span><span class="auto-style3">: 
		</span> 
        <asp:TextBox ID="TextBoxPostalCode" pattern="[A-Za-z][0-9][A-Za-z][0-9][A-Za-z][0-9]" title="Must follow the a0a0a0 format." runat="server" required></asp:TextBox>
        <br class="auto-style3" />
        <%-- Age textbox and corresponding text--%>
		<span class="auto-style3">Age</span><span class="auto-style2">*</span><span class="auto-style3">: 
		</span> 
        <asp:TextBox ID="TextBoxAge" runat="server" Width="31px" maxlength="3" type="number" min="18" max="120" required></asp:TextBox>
        <br class="auto-style3" />
        <%-- Password textbox and corresponding text--%>
		<span class="auto-style3">Password</span><span class="auto-style2">*</span><span class="auto-style3">: 
		</span> 
        <asp:TextBox ID="TextBoxPassword" type="password" pattern="^(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{6,}$" title="Must have at least 6 characters and contain at least one digit
and one upper-case character." runat="server" required></asp:TextBox>
        <br class="auto-style3" />
        <%-- Confirm password textbox and corresponding text--%>
		<span class="auto-style3">Confirm Password</span><span class="auto-style2">*</span><span class="auto-style3">: 
		</span> 
        <asp:TextBox ID="TextBoxAPassword" type="password"  pattern="^(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{6,}$" title="Must have at least 6 characters and contain at least one digit
and one upper-case character." runat="server" required></asp:TextBox>
        <br class="auto-style3" />
        <%-- Email textbox and corresponding text--%>
		<span class="auto-style3">Email</span><span class="auto-style2">*</span><span class="auto-style3">: 
		</span> 
        <asp:TextBox ID="TextBoxEmail" type="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}" runat="server" required></asp:TextBox>
        <br class="auto-style3" />
        <%-- Alternative email textbox and corresponding text--%>
		<span class="auto-style3">Alternative Email: </span> 
		<asp:TextBox ID="TextBoxAEmail" type="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}" runat="server"></asp:TextBox>
		<br class="auto-style3" />
        <%-- Phone textbox and corresponding text--%>
		<span class="auto-style3">Phone: </span> 
        <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
        <br class="auto-style3" />
        </p>
    <p class="auto-style3">
        Enter another member?
        <%-- Keep reg checkbox--%>
        <asp:CheckBox ID="CheckBoxAM" runat="server" OnCheckedChanged="CheckBoxAM_CheckedChanged" />
        </p>
        &nbsp
        <%-- Reg button--%>
	    <asp:Button ID="ButtonReg" runat="server" Text="Register" OnClick="ButtonReg_Click" />
            &nbsp
        <%-- Clear button--%>
        <asp:Button ID="ButtonClear" runat="server" Text="Clear" Width="90px" formnovalidate OnClick="ButtonClear_Click"/>
    </form>
    <%-- Codyright of website--%>
	<p class="auto-style3">@SargisNahapetyan </p>
</body>
</html>
