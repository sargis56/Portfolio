<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="JollyRogersOfficialWebsite.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home/Update - We Are JOLLY ROGERS</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
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
                    <asp:HyperLink runat="server" ID="previousPage" Font-Bold="true" ForeColor="Gray" NavigateUrl="~/HomePage_UnityUpdate.aspx" >
                    <<
                    </asp:HyperLink>
                </td>
                <td style="text-align:right;">
                    <asp:HyperLink ID="latestPage" runat="server" Enabled="False" Font-Strikeout="True" ForeColor="Gray">
                    >>
                    </asp:HyperLink> 
                </td>
            </tr>
            <tr>
				<td style="width: 238px">
					<asp:Label runat="server" id="lblContentTitle" text="Website Update!" Font-Bold="True" Font-Size="Large" />
				</td>
				<td class="rightcell">18-DEC-17</td>
                <td rowspan="3">
				    &nbsp;</td>
            </tr>
            <tr>
				<td style="width: 446px" class="centercell" colspan="2">
					<asp:Image runat="server" id="unitylogo" ImageUrl="~/Images/Company Logo Black - Copy.png" />		
					</td>
			</tr>
			<tr>
				<td style="width: 446px" colspan="2">
					<br />
					Our site has been updated with new features! Check out each of the selection!
					<br /><br />
					&nbsp;&nbsp;&nbsp; 
					<asp:Label id="signature" runat="server" cssclass="italics" text="- The Jolly Rogers Team" />
					<br /><br /><br /> 
				</td>
			</tr>
        </table>
    </div>
</asp:Content>
