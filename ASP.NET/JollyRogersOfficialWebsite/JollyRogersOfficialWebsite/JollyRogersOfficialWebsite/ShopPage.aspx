<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="ShopPage.aspx.cs" Inherits="JollyRogersOfficialWebsite.ShopPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Shop Page - We Are JOLLY ROGERS</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <asp:AdRotator ID="advertisements" runat="server" AdvertisementFile="ads.xml" Width="100%" />
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
   
    <asp:MultiView ID="ShopView2" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <asp:ListView ID="ListView1" runat="server" OnItemCommand="ExecuteItemCommand" DataSourceID="GameDataSource1" DataKeyNames="gameID" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
                <AlternatingItemTemplate>
                    <tr style="background-color:#FFF8DC;">
                        <td>
                            <asp:LinkButton ID="LinkButton1" CommandName="Fart" runat="server">Add to cart</asp:LinkButton>
                        </td>
                        <td>
                            <asp:Label ID="gameIDLabel" runat="server" Text='<%# Eval("gameID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="gameTitleLabel" runat="server" Text='<%# Eval("gameTitle") %>' />
                        </td>
                        <td>
                            <asp:Label ID="gameSeriesLabel" runat="server" Text='<%# Eval("gameSeries") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PublisherLabel" runat="server" Text='<%# Eval("Publisher") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PlatformsLabel" runat="server" Text='<%# Eval("Platforms") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("Price")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="shipPriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("shipPrice")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="gameDescLabel" runat="server" Text='<%# Eval("gameDesc") %>' />
                        </td>
                        <td>
                            <asp:Label ID="releaseDateLabel" runat="server" Text='<%# Eval("releaseDate","{0:dd-MMM-yyyy}") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <tr style="background-color:#008A8C;color: #FFFFFF;">
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        </td>
                        <td>
                            <asp:Label ID="gameIDLabel1" runat="server" Text='<%# Eval("gameID") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="gameTitleTextBox" runat="server" Text='<%# Bind("gameTitle") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="gameSeriesTextBox" runat="server" Text='<%# Bind("gameSeries") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="PublisherTextBox" runat="server" Text='<%# Bind("Publisher") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="PlatformsTextBox" runat="server" Text='<%# Bind("Platforms") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="shipPriceTextBox" runat="server" Text='<%# Bind("shipPrice") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="gameDescTextBox" runat="server" Text='<%# Bind("gameDesc") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="releaseDateTextBox" runat="server" Text='<%# Bind("releaseDate","{0:dd-MMM-yyyy}") %>' />
                        </td>
                    </tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
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
                            <asp:TextBox ID="gameIDTextBox" runat="server" Text='<%# Bind("gameID") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="gameTitleTextBox" runat="server" Text='<%# Bind("gameTitle") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="gameSeriesTextBox" runat="server" Text='<%# Bind("gameSeries") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="PublisherTextBox" runat="server" Text='<%# Bind("Publisher") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="PlatformsTextBox" runat="server" Text='<%# Bind("Platforms") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="shipPriceTextBox" runat="server" Text='<%# Bind("shipPrice") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="gameDescTextBox" runat="server" Text='<%# Bind("gameDesc") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="releaseDateTextBox" runat="server" Text='<%# Bind("releaseDate","{0:dd-MMM-yyyy}") %>' />
                        </td>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="background-color:#DCDCDC;color: #000000;">
                        <td>
                            <asp:LinkButton ID="LinkButton1" CommandName="Fart" runat="server">Add to cart</asp:LinkButton>
                        </td>
                        <td>
                            <asp:Label ID="gameIDLabel" runat="server" Text='<%# Bind("gameID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="gameTitleLabel" runat="server" Text='<%# Bind("gameTitle") %>' />
                        </td>
                        <td>
                            <asp:Label ID="gameSeriesLabel" runat="server" Text='<%# Bind("gameSeries") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PublisherLabel" runat="server" Text='<%# Bind("Publisher") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PlatformsLabel" runat="server" Text='<%# Bind("Platforms") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("Price")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="shipPriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("shipPrice")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="gameDescLabel" runat="server" Text='<%# Bind("gameDesc") %>' />
                        </td>
                        <td>
                            <asp:Label ID="releaseDateLabel" runat="server" Text='<%# Bind("releaseDate","{0:dd-MMM-yyyy}") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                        <th runat="server">Cart</th>
                                        <th runat="server">Game ID</th>
                                        <th runat="server">Game Title</th>
                                        <th runat="server">Series</th>
                                        <th runat="server">Publisher</th>
                                        <th runat="server">Platforms</th>
                                        <th runat="server">Price</th>
                                        <th runat="server">Shiping Price</th>
                                        <th runat="server">Description</th>
                                        <th runat="server">Release Date</th>
                                    </tr>
                                    <tr id="itemPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                        <td>
                            <asp:Label ID="gameIDLabel" runat="server" Text='<%# Bind("gameID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="gameTitleLabel" runat="server" Text='<%# Bind("gameTitle") %>' />
                        </td>
                        <td>
                            <asp:Label ID="gameSeriesLabel" runat="server" Text='<%# Bind("gameSeries") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PublisherLabel" runat="server" Text='<%# Bind("Publisher") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PlatformsLabel" runat="server" Text='<%# Bind("Platforms") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("Price")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="shipPriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("shipPrice")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="gameDescLabel" runat="server" Text='<%# Bind("gameDesc") %>' />
                        </td>
                        <td>
                            <asp:Label ID="releaseDateLabel" runat="server" Text='<%# Bind("releaseDate","{0:dd-MMM-yyyy}") %>' />
                        </td>
                    </tr>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="GameDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JollyRogersDatabaseConnectionString2 %>" SelectCommand="SELECT [gameID], [gameTitle], [gameSeries], [Publisher], [Platforms], [Price], [shipPrice], [gameDesc], [releaseDate] FROM [tblGames]">
            </asp:SqlDataSource>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <asp:ListView ID="ListView2" runat="server" OnItemCommand="ExecuteItemCommandMerch" DataKeyNames="merchID" DataSourceID="MerchDataSource1">
                <AlternatingItemTemplate>
                    <tr style="background-color:#FFF8DC;">
                        <td>
                            <asp:LinkButton ID="LinkButton1" CommandName="Fart2" runat="server">Add to cart</asp:LinkButton>
                        </td>
                        <td>
                            <asp:Label ID="merchIDLabel" runat="server" Text='<%# Bind("merchID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="merchTitleLabel" runat="server" Text='<%# Bind("merchTitle") %>' />
                        </td>
                        <td>
                            <asp:Label ID="merchDescLabel" runat="server" Text='<%# Bind("merchDesc") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("Price")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="shipPriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("shipPrice")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                        </td>
                        <td>
                            <asp:Label ID="stockCountLabel" runat="server" Text='<%# Bind("stockCount") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <tr style="background-color:#008A8C;color: #FFFFFF;">
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        </td>
                        <td>
                            <asp:Label ID="merchIDLabel1" runat="server" Text='<%# Bind("merchID") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="merchTitleTextBox" runat="server" Text='<%# Bind("merchTitle") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="merchDescTextBox" runat="server" Text='<%# Bind("merchDesc") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="shipPriceTextBox" runat="server" Text='<%# Bind("shipPrice") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="stockCountTextBox" runat="server" Text='<%# Bind("stockCount") %>' />
                        </td>
                    </tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <tr style="">
                        <td>
                            <asp:LinkButton ID="LinkButton1" CommandName="Fart2" runat="server">Add to cart</asp:LinkButton>
                        </td>
                        <td>
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        </td>
                        <td>
                            <asp:TextBox ID="merchIDTextBox" runat="server" Text='<%# Bind("merchID") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="merchTitleTextBox" runat="server" Text='<%# Bind("merchTitle") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="merchDescTextBox" runat="server" Text='<%# Bind("merchDesc") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="shipPriceTextBox" runat="server" Text='<%# Bind("shipPrice") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="stockCountTextBox" runat="server" Text='<%# Bind("stockCount") %>' />
                        </td>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="background-color:#DCDCDC;color: #000000;">
                        <td>
                            <asp:LinkButton ID="LinkButton1" CommandName="Fart2" runat="server">Add to cart</asp:LinkButton>
                        </td>
                        <td>
                            <asp:Label ID="merchIDLabel" runat="server" Text='<%# Bind("merchID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="merchTitleLabel" runat="server" Text='<%# Bind("merchTitle") %>' />
                        </td>
                        <td>
                            <asp:Label ID="merchDescLabel" runat="server" Text='<%# Bind("merchDesc") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("Price")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="shipPriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("shipPrice")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                        </td>
                        <td>
                            <asp:Label ID="stockCountLabel" runat="server" Text='<%# Bind("stockCount") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                        <th runat="server"></th>
                                        <th runat="server">ID</th>
                                        <th runat="server">Title</th>
                                        <th runat="server">Description</th>
                                        <th runat="server">Price</th>
                                        <th runat="server">Shiping Price</th>
                                        <th runat="server">Quantity</th>
                                        <th runat="server">Stock Count</th>
                                    </tr>
                                    <tr id="itemPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                        <td>
                            <asp:Label ID="merchIDLabel" runat="server" Text='<%# Bind("merchID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="merchTitleLabel" runat="server" Text='<%# Bind("merchTitle") %>' />
                        </td>
                        <td>
                            <asp:Label ID="merchDescLabel" runat="server" Text='<%# Bind("merchDesc") %>' />
                        </td>
                        <td>
                            <asp:Label ID="PriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("Price")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="shipPriceLabel" runat="server" Text='<%# String.Format("{0:c}", Convert.ToDecimal(Eval("shipPrice")))%>' />
                        </td>
                        <td>
                            <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                        </td>
                        <td>
                            <asp:Label ID="stockCountLabel" runat="server" Text='<%# Bind("stockCount") %>' />
                        </td>
                    </tr>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="MerchDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:JollyRogersDatabaseConnectionString2 %>" SelectCommand="SELECT * FROM [tblMerch]"></asp:SqlDataSource>
            <br />
        </asp:View>
    </asp:MultiView>
    <strong __designer:mapid="4fb">Loot Box |
    <asp:LinkButton ID="LinkButtonCart2" runat="server" OnClick="LinkButtonShopPage_Click">View Loot Box</asp:LinkButton>
    <asp:ListView ID="ListView3" runat="server" DataKeyNames="lootBoxDetailsID" DataSourceID="CartSqlDataSourceShop">
        <AlternatingItemTemplate>
            <tr style="background-color: #FFFFFF;color: #284775;">
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
            <tr style="background-color: #999999;">
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
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
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
            <tr style="background-color: #E0FFFF;color: #333333;">
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
                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color: #E0FFFF;color: #333333;">
                                <th runat="server"></th>
                                <th runat="server">Order ID</th>
                                <th runat="server">Item Name</th>
                                <th runat="server">Price</th>
                                <th runat="server">Quantity</th>
                                <th runat="server">Order Date</th>
                                <th runat="server">Ttem ID</th>
                                <th runat="server">Cart ID</th>
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
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
            <tr style="background-color: #E2DED6;font-weight: bold;color: #333333;">
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
    <br />
    <asp:SqlDataSource ID="CartSqlDataSourceShop" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:JollyRogersDatabaseConnectionString2 %>" DeleteCommand="DELETE FROM [tblLootBoxDetails] WHERE [lootBoxDetailsID] = @original_lootBoxDetailsID AND (([itemName] = @original_itemName) OR ([itemName] IS NULL AND @original_itemName IS NULL)) AND (([itemPrice] = @original_itemPrice) OR ([itemPrice] IS NULL AND @original_itemPrice IS NULL)) AND (([itemQuantity] = @original_itemQuantity) OR ([itemQuantity] IS NULL AND @original_itemQuantity IS NULL)) AND (([itemDate] = @original_itemDate) OR ([itemDate] IS NULL AND @original_itemDate IS NULL)) AND (([itemID] = @original_itemID) OR ([itemID] IS NULL AND @original_itemID IS NULL)) AND (([lootBoxID] = @original_lootBoxID) OR ([lootBoxID] IS NULL AND @original_lootBoxID IS NULL))" InsertCommand="INSERT INTO [tblLootBoxDetails] ([itemName], [itemPrice], [itemQuantity], [itemDate], [itemID], [lootBoxID]) VALUES (@itemName, @itemPrice, @itemQuantity, @itemDate, @itemID, @lootBoxID)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [tblLootBoxDetails]" UpdateCommand="UPDATE [tblLootBoxDetails] SET [itemName] = @itemName, [itemPrice] = @itemPrice, [itemQuantity] = @itemQuantity, [itemDate] = @itemDate, [itemID] = @itemID, [lootBoxID] = @lootBoxID WHERE [lootBoxDetailsID] = @original_lootBoxDetailsID AND (([itemName] = @original_itemName) OR ([itemName] IS NULL AND @original_itemName IS NULL)) AND (([itemPrice] = @original_itemPrice) OR ([itemPrice] IS NULL AND @original_itemPrice IS NULL)) AND (([itemQuantity] = @original_itemQuantity) OR ([itemQuantity] IS NULL AND @original_itemQuantity IS NULL)) AND (([itemDate] = @original_itemDate) OR ([itemDate] IS NULL AND @original_itemDate IS NULL)) AND (([itemID] = @original_itemID) OR ([itemID] IS NULL AND @original_itemID IS NULL)) AND (([lootBoxID] = @original_lootBoxID) OR ([lootBoxID] IS NULL AND @original_lootBoxID IS NULL))">
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
    </strong>
    </asp:Content>
