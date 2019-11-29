<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="JollyRogersOfficialWebsite.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Loot Box Page - We Are JOLLY ROGERS</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <table class="tablestyle" style="width: 100%;">
        <tr>
            <td class="cartPageTextA" colspan="3">
                <asp:Label ID="header" runat="server" Font-Bold="True" Font-Size="X-Large" style="text-align: left" text="LOOT BOX" />
            </td>
        </tr>
        <tr>
            <td class="tablestyle">
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">View Shop</asp:LinkButton>
                <strong>
                <br />
                Current Loot Box</strong><asp:ListView ID="ListView1" runat="server" DataKeyNames="lootBoxDetailsID" DataSourceID="LootBoxDataSource1" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
                    <AlternatingItemTemplate>
                        <tr style="background-color: #FFFFFF; color: #284775;">
                            <td>
                                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                            </td>
                            <td>
                                <asp:Label ID="lootBoxDetailsIDLabel" runat="server" Text='<%# Bind("lootBoxDetailsID") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemNameLabel" runat="server" Text='<%# Bind("itemName") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemPriceLabel" runat="server" Text='<%# Bind("itemPrice") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemQuantityLabel" runat="server" Text='<%# Bind("itemQuantity") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemDateLabel" runat="server" Text='<%# Bind("itemDate","{0:dd-MMM-yyyy}") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemIDLabel" runat="server" Text='<%# Bind("itemID") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lootBoxIDLabel" runat="server" Text='<%# Bind("lootBoxID") %>' />
                            </td>
                        </tr>
                    </AlternatingItemTemplate>
                    <EditItemTemplate>
                        <tr style="background-color: #999999; ">
                            <td>
                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                            </td>
                            <td>
                                <asp:Label ID="lootBoxDetailsIDLabel1" runat="server" Text='<%# Bind("lootBoxDetailsID") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="itemNameTextBox" runat="server" Text='<%# Bind("itemName") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="itemPriceTextBox" runat="server" Text='<%# Bind("itemPrice") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="itemQuantityTextBox" runat="server" Text='<%# Bind("itemQuantity") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="itemDateTextBox" runat="server" Text='<%# Bind("itemDate","{0:dd-MMM-yyyy}") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="itemIDTextBox" runat="server" Text='<%# Bind("itemID") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="lootBoxIDTextBox" runat="server" Text='<%# Bind("lootBoxID") %>' />
                            </td>
                        </tr>
                    </EditItemTemplate>
                    <EmptyDataTemplate>
                        <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                            <tr>
                                <td>No data was returned.</td>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                    <InsertItemTemplate>
                        <tr style="">
                            <td>
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:TextBox ID="itemNameTextBox" runat="server" Text='<%# Bind("itemName") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="itemPriceTextBox" runat="server" Text='<%# Bind("itemPrice") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="itemQuantityTextBox" runat="server" Text='<%# Bind("itemQuantity") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="itemDateTextBox" runat="server" Text='<%# Bind("itemDate","{0:dd-MMM-yyyy}") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="itemIDTextBox" runat="server" Text='<%# Bind("itemID") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="lootBoxIDTextBox" runat="server" Text='<%# Bind("lootBoxID") %>' />
                            </td>
                        </tr>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <tr style="background-color: #E0FFFF; color: #333333;">
                            <td>
                                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                            </td>
                            <td>
                                <asp:Label ID="lootBoxDetailsIDLabel" runat="server" Text='<%# Bind("lootBoxDetailsID") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemNameLabel" runat="server" Text='<%# Bind("itemName") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemPriceLabel" runat="server" Text='<%# Bind("itemPrice") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemQuantityLabel" runat="server" Text='<%# Bind("itemQuantity") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemDateLabel" runat="server" Text='<%# Bind("itemDate","{0:dd-MMM-yyyy}") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemIDLabel" runat="server" Text='<%# Bind("itemID") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lootBoxIDLabel" runat="server" Text='<%# Bind("lootBoxID") %>' />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <table runat="server">
                            <tr runat="server">
                                <td runat="server">
                                    <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                                        <tr runat="server" style="background-color: #E0FFFF; color: #333333;">
                                            <th runat="server"></th>
                                            <th runat="server">lootBoxDetailsID</th>
                                            <th runat="server">itemName</th>
                                            <th runat="server">itemPrice</th>
                                            <th runat="server">itemQuantity</th>
                                            <th runat="server">itemDate</th>
                                            <th runat="server">itemID</th>
                                            <th runat="server">lootBoxID</th>
                                        </tr>
                                        <tr id="itemPlaceholder" runat="server">
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr runat="server">
                                <td runat="server" style="text-align: center; background-color: #5D7B9D; font-family: Verdana, Arial, Helvetica, sans-serif; color: #FFFFFF;">
                                    <asp:DataPager ID="DataPager1" runat="server">
                                        <Fields>
                                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                        </Fields>
                                    </asp:DataPager>
                                </td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                    <SelectedItemTemplate>
                        <tr style="background-color: #E2DED6; font-weight: bold; color: #333333;">
                            <td>
                                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                            </td>
                            <td>
                                <asp:Label ID="lootBoxDetailsIDLabel" runat="server" Text='<%# Bind("lootBoxDetailsID") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemNameLabel" runat="server" Text='<%# Bind("itemName") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemPriceLabel" runat="server" Text='<%# Bind("itemPrice") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemQuantityLabel" runat="server" Text='<%# Bind("itemQuantity") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemDateLabel" runat="server" Text='<%# Bind("itemDate","{0:dd-MMM-yyyy}") %>' />
                            </td>
                            <td>
                                <asp:Label ID="itemIDLabel" runat="server" Text='<%# Bind("itemID") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lootBoxIDLabel" runat="server" Text='<%# Bind("lootBoxID") %>' />
                            </td>
                        </tr>
                    </SelectedItemTemplate>
                </asp:ListView>
                <asp:SqlDataSource ID="LootBoxDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JollyRogersDatabaseConnectionString2 %>" SelectCommand="SELECT * FROM [tblLootBoxDetails]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [tblLootBoxDetails] WHERE [lootBoxDetailsID] = @original_lootBoxDetailsID AND (([itemName] = @original_itemName) OR ([itemName] IS NULL AND @original_itemName IS NULL)) AND (([itemPrice] = @original_itemPrice) OR ([itemPrice] IS NULL AND @original_itemPrice IS NULL)) AND (([itemQuantity] = @original_itemQuantity) OR ([itemQuantity] IS NULL AND @original_itemQuantity IS NULL)) AND (([itemDate] = @original_itemDate) OR ([itemDate] IS NULL AND @original_itemDate IS NULL)) AND (([itemID] = @original_itemID) OR ([itemID] IS NULL AND @original_itemID IS NULL)) AND (([lootBoxID] = @original_lootBoxID) OR ([lootBoxID] IS NULL AND @original_lootBoxID IS NULL))" InsertCommand="INSERT INTO [tblLootBoxDetails] ([itemName], [itemPrice], [itemQuantity], [itemDate], [itemID], [lootBoxID]) VALUES (@itemName, @itemPrice, @itemQuantity, @itemDate, @itemID, @lootBoxID)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [tblLootBoxDetails] SET [itemName] = @itemName, [itemPrice] = @itemPrice, [itemQuantity] = @itemQuantity, [itemDate] = @itemDate, [itemID] = @itemID, [lootBoxID] = @lootBoxID WHERE [lootBoxDetailsID] = @original_lootBoxDetailsID AND (([itemName] = @original_itemName) OR ([itemName] IS NULL AND @original_itemName IS NULL)) AND (([itemPrice] = @original_itemPrice) OR ([itemPrice] IS NULL AND @original_itemPrice IS NULL)) AND (([itemQuantity] = @original_itemQuantity) OR ([itemQuantity] IS NULL AND @original_itemQuantity IS NULL)) AND (([itemDate] = @original_itemDate) OR ([itemDate] IS NULL AND @original_itemDate IS NULL)) AND (([itemID] = @original_itemID) OR ([itemID] IS NULL AND @original_itemID IS NULL)) AND (([lootBoxID] = @original_lootBoxID) OR ([lootBoxID] IS NULL AND @original_lootBoxID IS NULL))">
                    <DeleteParameters>
                        <asp:Parameter Name="original_lootBoxDetailsID" Type="Int32" />
                        <asp:Parameter Name="original_itemName" Type="String" />
                        <asp:Parameter Name="original_itemPrice" Type="Decimal" />
                        <asp:Parameter Name="original_itemQuantity" Type="Int32" />
                        <asp:Parameter DbType="Date" Name="original_itemDate" />
                        <asp:Parameter Name="original_itemID" Type="Int32" />
                        <asp:Parameter Name="original_lootBoxID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="itemName" Type="String" />
                        <asp:Parameter Name="itemPrice" Type="Decimal" />
                        <asp:Parameter Name="itemQuantity" Type="Int32" />
                        <asp:Parameter DbType="Date" Name="itemDate" />
                        <asp:Parameter Name="itemID" Type="Int32" />
                        <asp:Parameter Name="lootBoxID" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="itemName" Type="String" />
                        <asp:Parameter Name="itemPrice" Type="Decimal" />
                        <asp:Parameter Name="itemQuantity" Type="Int32" />
                        <asp:Parameter DbType="Date" Name="itemDate" />
                        <asp:Parameter Name="itemID" Type="Int32" />
                        <asp:Parameter Name="lootBoxID" Type="Int32" />
                        <asp:Parameter Name="original_lootBoxDetailsID" Type="Int32" />
                        <asp:Parameter Name="original_itemName" Type="String" />
                        <asp:Parameter Name="original_itemPrice" Type="Decimal" />
                        <asp:Parameter Name="original_itemQuantity" Type="Int32" />
                        <asp:Parameter DbType="Date" Name="original_itemDate" />
                        <asp:Parameter Name="original_itemID" Type="Int32" />
                        <asp:Parameter Name="original_lootBoxID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <strong>Check Out:<br />
                </strong>
                <asp:Label ID="orderInfo" runat="server"></asp:Label>
                <br />
                <table>
                    <tr>
                        <td>
                            <span class="cartPageTextB">First Name</span><span class="redfont">*</span>:</td>
                        <td>
                            <asp:TextBox ID="TextBoxFirstName" runat="server" required=""></asp:TextBox>
                            <br class="cartPageTextB" /></td>
                    </tr>
                    <tr>
                        <td>
                            <%-- Last name textbox and corresponding text--%>
                            <span class="cartPageTextB">Last Name</span><span class="redfont">*</span>:</td>
                        <td>
                            <asp:TextBox ID="TextBoxLastName" runat="server" required=""></asp:TextBox>
                            <br class="cartPageTextB" /></td>
                    </tr>
                    <tr>
                        <td> <%-- Address textbox and corresponding text--%>
                            <span class="cartPageTextB">Address</span><span class="redfont">*</span><span class="cartPageTextB">: </span></td>
                        <td>
                            <asp:TextBox ID="TextBoxAddress" runat="server" required="" Width="287px"></asp:TextBox>
                            <br class="cartPageTextB" /></td>
                    </tr>
                    <tr>
                        <td><%-- City textbox and corresponding text--%>
                            <span class="cartPageTextB">City</span><span class="redfont">*</span><span class="cartPageTextB">: </span></td>
                        <td>
                            <asp:TextBox ID="TextBoxCity" runat="server" required=""></asp:TextBox>
                            <br class="cartPageTextB" /></td>
                    </tr>
                    <tr>
                        <td><%-- Province textbox and corresponding text--%>
                            <span class="cartPageTextB">Province</span><span class="redfont">*</span><span class="cartPageTextB">: </span></td>
                        <td>
                            <asp:TextBox ID="TextBoxProvince" runat="server" maxlength="2" pattern="[A-Za-z]{2}" required="" style="text-transform:uppercase" Width="31px"></asp:TextBox>
                            <br class="cartPageTextB" /></td>
                    </tr>
                    <tr>
                        <td><%-- Postal code textbox and corresponding text--%>
                            <span class="cartPageTextB">Postal Code</span><span class="redfont">*</span><span class="cartPageTextB">: </span></td>
                        <td>
                            <asp:TextBox ID="TextBoxPostalCode" runat="server" pattern="[A-Za-z][0-9][A-Za-z][0-9][A-Za-z][0-9]" required="" title="Must follow the a0a0a0 format."></asp:TextBox>
                            <br class="cartPageTextB" /></td>
                    </tr>
                    <tr>
                        <td><%-- Age textbox and corresponding text--%>
                            <span class="cartPageTextB">Age</span><span class="redfont">*</span><span class="cartPageTextB">: </span></td>
                        <td>
                            <asp:TextBox ID="TextBoxAge" runat="server" max="120" maxlength="3" min="18" required="" type="number" Width="31px"></asp:TextBox>
                            <br class="cartPageTextB" /></td>
                    </tr>
                    <tr>
                        <td><%-- Email textbox and corresponding text--%>
                            <span class="cartPageTextB">Email</span><span class="redfont">*</span><span class="cartPageTextB">: </span></td>
                        <td>
                            <asp:TextBox ID="TextBoxEmail" runat="server" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}" required="" type="email"></asp:TextBox>
                            <br class="cartPageTextB" /></td>
                    </tr>
                    <tr>
                        <td>
                            <span class="cartPageTextB">Card Number<span class="redfont">*</span>: </span></td>
                        <td>
                            <asp:TextBox ID="TextBoxAEmail" runat="server" pattern="[0-9]{13,16}" required=""></asp:TextBox>
                            <br class="cartPageTextB" /></td>
                    </tr>
                    <tr>
                        <td><%-- Phone textbox and corresponding text--%>
                            <span class="cartPageTextB">Phone: </span></td>
                        <td>
                            <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
                            <br /></td>
                    </tr>
                </table>
                <asp:Button ID="Button1" runat="server" Text="Confirm Purchase" OnClick="Button1_Click" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
