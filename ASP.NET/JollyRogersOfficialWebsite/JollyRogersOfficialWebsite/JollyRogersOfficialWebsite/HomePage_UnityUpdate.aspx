<%@ Page Title="Unity Update" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="HomePage_UnityUpdate.aspx.cs" Inherits="JollyRogersOfficialWebsite.HomePage_UnityUpdate" %>

<asp:Content ID="Headline" ContentPlaceHolderID="head" runat="server">
	<title>Unity Update | 12-OCT-17 - We Are JOLLY ROGERS</title>
</asp:Content>
    
<asp:Content ID="Content" ContentPlaceHolderID="FrontPageContent" runat="server">
	<div>
		<table style="width: 100%">
			<tr> 
				<td colspan="3" class="centercell">
					<asp:AdRotator ID="advertisements" runat="server" AdvertisementFile="ads.xml" />
				</td>
			</tr>
			<tr> 
				<td colspan="3" style="height: 47px" class="centercell">
					<asp:Label runat="server" id="header" text="UPDATE PAGE" Font-Bold="True" Font-Size="X-Large" />
				</td>
			</tr>
            <tr>
                <td colspan="2">
                    <asp:HyperLink runat="server" ID="previousPage" Enabled="false" Font-Strikeout="true" ForeColor="Gray" >
                    <<
                    </asp:HyperLink>
                </td>
                <td style="text-align:right;">
                    <asp:HyperLink ID="latestPage" runat="server" NavigateUrl="~/HomePage.aspx" Font-Bold="True" ForeColor="Gray">
                    >>
                    </asp:HyperLink> 
                </td>
            </tr>
			<tr>
				<td style="width: 238px">
					<asp:Label runat="server" id="title" text="Unity update." Font-Bold="True" Font-Size="Large" />
				</td>
				<td class="rightcell">12-OCT-17</td>
				<td rowspan="3">
				    &nbsp;</td>
			</tr>
			<tr>
				<td style="width: 446px" class="centercell" colspan="2">
					<asp:Image runat="server" id="unitylogo" ImageUrl="Images/UnityLogo.png" />		
					</td>
			</tr>
			<tr>
				<td style="width: 446px" colspan="2">
					<br />
					We here at Jolly Rogers are bringing down the sails as we've 
					progressing through our latest creation: One Bone.
					
					Powered using the Unity engine, we hope to show you screenshots in 
					our next update. But for now, here's a list on what we've got done:
					<br />
					<asp:BulletedList runat="server" id="oct12bulst">
						<asp:ListItem>Repository Creation</asp:ListItem>
						<asp:ListItem>Basic Programming</asp:ListItem>
						<asp:ListItem>Few Character Animations</asp:ListItem>
						<asp:ListItem>8 Directional Shooting Mechanic</asp:ListItem>
					</asp:BulletedList>
					<br />
					As you can see, we're well on our way to the X. 
					<br /><br />
					&nbsp;&nbsp;&nbsp; 
					<asp:Label id="signature" runat="server" cssclass="italics" text="- The Jolly Rogers Team" />
					<br /><br /><br /> 
				</td>
			</tr>
		</table>
	</div>
</asp:Content>

