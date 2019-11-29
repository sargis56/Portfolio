<%@ Page Title="" Language="C#" MasterPageFile="~/FrontPage.Master" AutoEventWireup="true" CodeBehind="ManagementPage.aspx.cs" Inherits="JollyRogersOfficialWebsite.ManagementPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FrontPageContent" runat="server">
    <asp:Label runat="server" id="header" text="Management" Font-Bold="True" Font-Size="X-Large" style="text-align: left" />
    <br />
    <br />
    <strong>Games | Shop Page |
    <asp:LinkButton ID="LinkButtonShopPage" runat="server" OnClick="LinkButtonShopPage_Click">ShopPage.aspx</asp:LinkButton>
    </strong>
    <br />
    <asp:ListView ID="ListViewMamaGame" runat="server" DataKeyNames="gameID" DataSourceID="ManaGameDataSource1" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <td runat="server" style="background-color: #FFFFFF;color: #284775;">gameID:
                <asp:Label ID="gameIDLabel" runat="server" Text='<%# Bind("gameID") %>' />
                <br />
                gameTitle:
                <asp:Label ID="gameTitleLabel" runat="server" Text='<%# Bind("gameTitle") %>' />
                <br />
                gameSeries:
                <asp:Label ID="gameSeriesLabel" runat="server" Text='<%# Bind("gameSeries") %>' />
                <br />
                Publisher:
                <asp:Label ID="PublisherLabel" runat="server" Text='<%# Bind("Publisher") %>' />
                <br />
                Director:
                <asp:Label ID="DirectorLabel" runat="server" Text='<%# Bind("Director") %>' />
                <br />
                Producer:
                <asp:Label ID="ProducerLabel" runat="server" Text='<%# Bind("Producer") %>' />
                <br />
                Programmer:
                <asp:Label ID="ProgrammerLabel" runat="server" Text='<%# Bind("Programmer") %>' />
                <br />
                Artist:
                <asp:Label ID="ArtistLabel" runat="server" Text='<%# Bind("Artist") %>' />
                <br />
                Platforms:
                <asp:Label ID="PlatformsLabel" runat="server" Text='<%# Bind("Platforms") %>' />
                <br />
                releaseDate:
                <asp:Label ID="releaseDateLabel" runat="server" Text='<%# Bind("releaseDate") %>' />
                <br />
                Genre:
                <asp:Label ID="GenreLabel" runat="server" Text='<%# Bind("Genre") %>' />
                <br />
                Modes:
                <asp:Label ID="ModesLabel" runat="server" Text='<%# Bind("Modes") %>' />
                <br />
                Price:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Bind("Price") %>' />
                <br />
                shipPrice:
                <asp:Label ID="shipPriceLabel" runat="server" Text='<%# Bind("shipPrice") %>' />
                <br />
                gameDesc:
                <asp:Label ID="gameDescLabel" runat="server" Text='<%# Bind("gameDesc") %>' />
                <br />
                Quantity:
                <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />
                stockCount:
                <asp:Label ID="stockCountLabel" runat="server" Text='<%# Bind("stockCount") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <td runat="server" style="background-color: #999999;">gameID:
                <asp:Label ID="gameIDLabel1" runat="server" Text='<%# Bind("gameID") %>' />
                <br />
                gameTitle:
                <asp:TextBox ID="gameTitleTextBox" runat="server" Text='<%# Bind("gameTitle") %>' />
                <br />
                gameSeries:
                <asp:TextBox ID="gameSeriesTextBox" runat="server" Text='<%# Bind("gameSeries") %>' />
                <br />
                Publisher:
                <asp:TextBox ID="PublisherTextBox" runat="server" Text='<%# Bind("Publisher") %>' />
                <br />
                Director:
                <asp:TextBox ID="DirectorTextBox" runat="server" Text='<%# Bind("Director") %>' />
                <br />
                Producer:
                <asp:TextBox ID="ProducerTextBox" runat="server" Text='<%# Bind("Producer") %>' />
                <br />
                Programmer:
                <asp:TextBox ID="ProgrammerTextBox" runat="server" Text='<%# Bind("Programmer") %>' />
                <br />
                Artist:
                <asp:TextBox ID="ArtistTextBox" runat="server" Text='<%# Bind("Artist") %>' />
                <br />
                Platforms:
                <asp:TextBox ID="PlatformsTextBox" runat="server" Text='<%# Bind("Platforms") %>' />
                <br />
                releaseDate:
                <asp:TextBox ID="releaseDateTextBox" runat="server" Text='<%# Bind("releaseDate") %>' />
                <br />
                Genre:
                <asp:TextBox ID="GenreTextBox" runat="server" Text='<%# Bind("Genre") %>' />
                <br />
                Modes:
                <asp:TextBox ID="ModesTextBox" runat="server" Text='<%# Bind("Modes") %>' />
                <br />
                Price:
                <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                <br />
                shipPrice:
                <asp:TextBox ID="shipPriceTextBox" runat="server" Text='<%# Bind("shipPrice") %>' />
                <br />
                gameDesc:
                <asp:TextBox ID="gameDescTextBox" runat="server" Text='<%# Bind("gameDesc") %>' />
                <br />
                Quantity:
                <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />
                stockCount:
                <asp:TextBox ID="stockCountTextBox" runat="server" Text='<%# Bind("stockCount") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            </td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <td runat="server" style="">gameID:
                <asp:TextBox ID="gameIDTextBox" runat="server" Text='<%# Bind("gameID") %>' />
                <br />
                gameTitle:
                <asp:TextBox ID="gameTitleTextBox" runat="server" Text='<%# Bind("gameTitle") %>' />
                <br />
                gameSeries:
                <asp:TextBox ID="gameSeriesTextBox" runat="server" Text='<%# Bind("gameSeries") %>' />
                <br />
                Publisher:
                <asp:TextBox ID="PublisherTextBox" runat="server" Text='<%# Bind("Publisher") %>' />
                <br />
                Director:
                <asp:TextBox ID="DirectorTextBox" runat="server" Text='<%# Bind("Director") %>' />
                <br />
                Producer:
                <asp:TextBox ID="ProducerTextBox" runat="server" Text='<%# Bind("Producer") %>' />
                <br />
                Programmer:
                <asp:TextBox ID="ProgrammerTextBox" runat="server" Text='<%# Bind("Programmer") %>' />
                <br />
                Artist:
                <asp:TextBox ID="ArtistTextBox" runat="server" Text='<%# Bind("Artist") %>' />
                <br />
                Platforms:
                <asp:TextBox ID="PlatformsTextBox" runat="server" Text='<%# Bind("Platforms") %>' />
                <br />
                releaseDate:
                <asp:TextBox ID="releaseDateTextBox" runat="server" Text='<%# Bind("releaseDate") %>' />
                <br />
                Genre:
                <asp:TextBox ID="GenreTextBox" runat="server" Text='<%# Bind("Genre") %>' />
                <br />
                Modes:
                <asp:TextBox ID="ModesTextBox" runat="server" Text='<%# Bind("Modes") %>' />
                <br />
                Price:
                <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                <br />
                shipPrice:
                <asp:TextBox ID="shipPriceTextBox" runat="server" Text='<%# Bind("shipPrice") %>' />
                <br />
                gameDesc:
                <asp:TextBox ID="gameDescTextBox" runat="server" Text='<%# Bind("gameDesc") %>' />
                <br />
                Quantity:
                <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />
                stockCount:
                <asp:TextBox ID="stockCountTextBox" runat="server" Text='<%# Bind("stockCount") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            </td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="background-color: #E0FFFF;color: #333333;">gameID:
                <asp:Label ID="gameIDLabel" runat="server" Text='<%# Bind("gameID") %>' />
                <br />
                gameTitle:
                <asp:Label ID="gameTitleLabel" runat="server" Text='<%# Bind("gameTitle") %>' />
                <br />
                gameSeries:
                <asp:Label ID="gameSeriesLabel" runat="server" Text='<%# Bind("gameSeries") %>' />
                <br />
                Publisher:
                <asp:Label ID="PublisherLabel" runat="server" Text='<%# Bind("Publisher") %>' />
                <br />
                Director:
                <asp:Label ID="DirectorLabel" runat="server" Text='<%# Bind("Director") %>' />
                <br />
                Producer:
                <asp:Label ID="ProducerLabel" runat="server" Text='<%# Bind("Producer") %>' />
                <br />
                Programmer:
                <asp:Label ID="ProgrammerLabel" runat="server" Text='<%# Bind("Programmer") %>' />
                <br />
                Artist:
                <asp:Label ID="ArtistLabel" runat="server" Text='<%# Bind("Artist") %>' />
                <br />
                Platforms:
                <asp:Label ID="PlatformsLabel" runat="server" Text='<%# Bind("Platforms") %>' />
                <br />
                releaseDate:
                <asp:Label ID="releaseDateLabel" runat="server" Text='<%# Bind("releaseDate") %>' />
                <br />
                Genre:
                <asp:Label ID="GenreLabel" runat="server" Text='<%# Bind("Genre") %>' />
                <br />
                Modes:
                <asp:Label ID="ModesLabel" runat="server" Text='<%# Bind("Modes") %>' />
                <br />
                Price:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Bind("Price") %>' />
                <br />
                shipPrice:
                <asp:Label ID="shipPriceLabel" runat="server" Text='<%# Bind("shipPrice") %>' />
                <br />
                gameDesc:
                <asp:Label ID="gameDescLabel" runat="server" Text='<%# Bind("gameDesc") %>' />
                <br />
                Quantity:
                <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />
                stockCount:
                <asp:Label ID="stockCountLabel" runat="server" Text='<%# Bind("stockCount") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </table>
            <div style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                <asp:DataPager ID="DataPager1" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <td runat="server" style="background-color: #E2DED6;font-weight: bold;color: #333333;">gameID:
                <asp:Label ID="gameIDLabel" runat="server" Text='<%# Bind("gameID") %>' />
                <br />
                gameTitle:
                <asp:Label ID="gameTitleLabel" runat="server" Text='<%# Bind("gameTitle") %>' />
                <br />
                gameSeries:
                <asp:Label ID="gameSeriesLabel" runat="server" Text='<%# Bind("gameSeries") %>' />
                <br />
                Publisher:
                <asp:Label ID="PublisherLabel" runat="server" Text='<%# Bind("Publisher") %>' />
                <br />
                Director:
                <asp:Label ID="DirectorLabel" runat="server" Text='<%# Bind("Director") %>' />
                <br />
                Producer:
                <asp:Label ID="ProducerLabel" runat="server" Text='<%# Bind("Producer") %>' />
                <br />
                Programmer:
                <asp:Label ID="ProgrammerLabel" runat="server" Text='<%# Bind("Programmer") %>' />
                <br />
                Artist:
                <asp:Label ID="ArtistLabel" runat="server" Text='<%# Bind("Artist") %>' />
                <br />
                Platforms:
                <asp:Label ID="PlatformsLabel" runat="server" Text='<%# Bind("Platforms") %>' />
                <br />
                releaseDate:
                <asp:Label ID="releaseDateLabel" runat="server" Text='<%# Bind("releaseDate") %>' />
                <br />
                Genre:
                <asp:Label ID="GenreLabel" runat="server" Text='<%# Bind("Genre") %>' />
                <br />
                Modes:
                <asp:Label ID="ModesLabel" runat="server" Text='<%# Bind("Modes") %>' />
                <br />
                Price:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Bind("Price") %>' />
                <br />
                shipPrice:
                <asp:Label ID="shipPriceLabel" runat="server" Text='<%# Bind("shipPrice") %>' />
                <br />
                gameDesc:
                <asp:Label ID="gameDescLabel" runat="server" Text='<%# Bind("gameDesc") %>' />
                <br />
                Quantity:
                <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />
                stockCount:
                <asp:Label ID="stockCountLabel" runat="server" Text='<%# Bind("stockCount") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="ManaGameDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:JollyRogersDatabaseConnectionString2 %>" DeleteCommand="DELETE FROM [tblGames] WHERE [gameID] = @original_gameID AND [gameTitle] = @original_gameTitle AND [gameSeries] = @original_gameSeries AND [Publisher] = @original_Publisher AND [Director] = @original_Director AND [Producer] = @original_Producer AND [Programmer] = @original_Programmer AND [Artist] = @original_Artist AND [Platforms] = @original_Platforms AND [releaseDate] = @original_releaseDate AND [Genre] = @original_Genre AND [Modes] = @original_Modes AND (([Price] = @original_Price) OR ([Price] IS NULL AND @original_Price IS NULL)) AND (([shipPrice] = @original_shipPrice) OR ([shipPrice] IS NULL AND @original_shipPrice IS NULL)) AND [gameDesc] = @original_gameDesc AND (([Quantity] = @original_Quantity) OR ([Quantity] IS NULL AND @original_Quantity IS NULL)) AND (([stockCount] = @original_stockCount) OR ([stockCount] IS NULL AND @original_stockCount IS NULL))" InsertCommand="INSERT INTO [tblGames] ([gameID], [gameTitle], [gameSeries], [Publisher], [Director], [Producer], [Programmer], [Artist], [Platforms], [releaseDate], [Genre], [Modes], [Price], [shipPrice], [gameDesc], [Quantity], [stockCount]) VALUES (@gameID, @gameTitle, @gameSeries, @Publisher, @Director, @Producer, @Programmer, @Artist, @Platforms, @releaseDate, @Genre, @Modes, @Price, @shipPrice, @gameDesc, @Quantity, @stockCount)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [tblGames]" UpdateCommand="UPDATE [tblGames] SET [gameTitle] = @gameTitle, [gameSeries] = @gameSeries, [Publisher] = @Publisher, [Director] = @Director, [Producer] = @Producer, [Programmer] = @Programmer, [Artist] = @Artist, [Platforms] = @Platforms, [releaseDate] = @releaseDate, [Genre] = @Genre, [Modes] = @Modes, [Price] = @Price, [shipPrice] = @shipPrice, [gameDesc] = @gameDesc, [Quantity] = @Quantity, [stockCount] = @stockCount WHERE [gameID] = @original_gameID AND [gameTitle] = @original_gameTitle AND [gameSeries] = @original_gameSeries AND [Publisher] = @original_Publisher AND [Director] = @original_Director AND [Producer] = @original_Producer AND [Programmer] = @original_Programmer AND [Artist] = @original_Artist AND [Platforms] = @original_Platforms AND [releaseDate] = @original_releaseDate AND [Genre] = @original_Genre AND [Modes] = @original_Modes AND (([Price] = @original_Price) OR ([Price] IS NULL AND @original_Price IS NULL)) AND (([shipPrice] = @original_shipPrice) OR ([shipPrice] IS NULL AND @original_shipPrice IS NULL)) AND [gameDesc] = @original_gameDesc AND (([Quantity] = @original_Quantity) OR ([Quantity] IS NULL AND @original_Quantity IS NULL)) AND (([stockCount] = @original_stockCount) OR ([stockCount] IS NULL AND @original_stockCount IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_gameID" Type="Int32" />
            <asp:Parameter Name="original_gameTitle" Type="String" />
            <asp:Parameter Name="original_gameSeries" Type="String" />
            <asp:Parameter Name="original_Publisher" Type="String" />
            <asp:Parameter Name="original_Director" Type="String" />
            <asp:Parameter Name="original_Producer" Type="String" />
            <asp:Parameter Name="original_Programmer" Type="String" />
            <asp:Parameter Name="original_Artist" Type="String" />
            <asp:Parameter Name="original_Platforms" Type="String" />
            <asp:Parameter DbType="Date" Name="original_releaseDate" />
            <asp:Parameter Name="original_Genre" Type="String" />
            <asp:Parameter Name="original_Modes" Type="String" />
            <asp:Parameter Name="original_Price" Type="Decimal" />
            <asp:Parameter Name="original_shipPrice" Type="Decimal" />
            <asp:Parameter Name="original_gameDesc" Type="String" />
            <asp:Parameter Name="original_Quantity" Type="Int32" />
            <asp:Parameter Name="original_stockCount" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="gameID" Type="Int32" />
            <asp:Parameter Name="gameTitle" Type="String" />
            <asp:Parameter Name="gameSeries" Type="String" />
            <asp:Parameter Name="Publisher" Type="String" />
            <asp:Parameter Name="Director" Type="String" />
            <asp:Parameter Name="Producer" Type="String" />
            <asp:Parameter Name="Programmer" Type="String" />
            <asp:Parameter Name="Artist" Type="String" />
            <asp:Parameter Name="Platforms" Type="String" />
            <asp:Parameter DbType="Date" Name="releaseDate" />
            <asp:Parameter Name="Genre" Type="String" />
            <asp:Parameter Name="Modes" Type="String" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="shipPrice" Type="Decimal" />
            <asp:Parameter Name="gameDesc" Type="String" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="stockCount" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="gameTitle" Type="String" />
            <asp:Parameter Name="gameSeries" Type="String" />
            <asp:Parameter Name="Publisher" Type="String" />
            <asp:Parameter Name="Director" Type="String" />
            <asp:Parameter Name="Producer" Type="String" />
            <asp:Parameter Name="Programmer" Type="String" />
            <asp:Parameter Name="Artist" Type="String" />
            <asp:Parameter Name="Platforms" Type="String" />
            <asp:Parameter DbType="Date" Name="releaseDate" />
            <asp:Parameter Name="Genre" Type="String" />
            <asp:Parameter Name="Modes" Type="String" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="shipPrice" Type="Decimal" />
            <asp:Parameter Name="gameDesc" Type="String" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="stockCount" Type="Int32" />
            <asp:Parameter Name="original_gameID" Type="Int32" />
            <asp:Parameter Name="original_gameTitle" Type="String" />
            <asp:Parameter Name="original_gameSeries" Type="String" />
            <asp:Parameter Name="original_Publisher" Type="String" />
            <asp:Parameter Name="original_Director" Type="String" />
            <asp:Parameter Name="original_Producer" Type="String" />
            <asp:Parameter Name="original_Programmer" Type="String" />
            <asp:Parameter Name="original_Artist" Type="String" />
            <asp:Parameter Name="original_Platforms" Type="String" />
            <asp:Parameter DbType="Date" Name="original_releaseDate" />
            <asp:Parameter Name="original_Genre" Type="String" />
            <asp:Parameter Name="original_Modes" Type="String" />
            <asp:Parameter Name="original_Price" Type="Decimal" />
            <asp:Parameter Name="original_shipPrice" Type="Decimal" />
            <asp:Parameter Name="original_gameDesc" Type="String" />
            <asp:Parameter Name="original_Quantity" Type="Int32" />
            <asp:Parameter Name="original_stockCount" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <strong>Merch | Shop Page |
    <asp:LinkButton ID="LinkButtonShopPage0" runat="server" OnClick="LinkButtonShopPage_Click">ShopPage.aspx</asp:LinkButton>
    </strong>
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="merchID" DataSourceID="SqlDataSourceMamaMerch" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <td runat="server" style="background-color: #FFFFFF;color: #284775;">merchID:
                <asp:Label ID="merchIDLabel" runat="server" Text='<%# Bind("merchID") %>' />
                <br />merchTitle:
                <asp:Label ID="merchTitleLabel" runat="server" Text='<%# Bind("merchTitle") %>' />
                <br />merchDesc:
                <asp:Label ID="merchDescLabel" runat="server" Text='<%# Bind("merchDesc") %>' />
                <br />Price:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Bind("Price") %>' />
                <br />shipPrice:
                <asp:Label ID="shipPriceLabel" runat="server" Text='<%# Bind("shipPrice") %>' />
                <br />Quantity:
                <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />stockCount:
                <asp:Label ID="stockCountLabel" runat="server" Text='<%# Bind("stockCount") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <td runat="server" style="background-color: #999999;">merchID:
                <asp:Label ID="merchIDLabel1" runat="server" Text='<%# Bind("merchID") %>' />
                <br />merchTitle:
                <asp:TextBox ID="merchTitleTextBox" runat="server" Text='<%# Bind("merchTitle") %>' />
                <br />merchDesc:
                <asp:TextBox ID="merchDescTextBox" runat="server" Text='<%# Bind("merchDesc") %>' />
                <br />Price:
                <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                <br />shipPrice:
                <asp:TextBox ID="shipPriceTextBox" runat="server" Text='<%# Bind("shipPrice") %>' />
                <br />Quantity:
                <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />stockCount:
                <asp:TextBox ID="stockCountTextBox" runat="server" Text='<%# Bind("stockCount") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            </td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <td runat="server" style="">merchID:
                <asp:TextBox ID="merchIDTextBox" runat="server" Text='<%# Bind("merchID") %>' />
                <br />merchTitle:
                <asp:TextBox ID="merchTitleTextBox" runat="server" Text='<%# Bind("merchTitle") %>' />
                <br />merchDesc:
                <asp:TextBox ID="merchDescTextBox" runat="server" Text='<%# Bind("merchDesc") %>' />
                <br />Price:
                <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                <br />shipPrice:
                <asp:TextBox ID="shipPriceTextBox" runat="server" Text='<%# Bind("shipPrice") %>' />
                <br />Quantity:
                <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />stockCount:
                <asp:TextBox ID="stockCountTextBox" runat="server" Text='<%# Bind("stockCount") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            </td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="background-color: #E0FFFF;color: #333333;">merchID:
                <asp:Label ID="merchIDLabel" runat="server" Text='<%# Bind("merchID") %>' />
                <br />merchTitle:
                <asp:Label ID="merchTitleLabel" runat="server" Text='<%# Bind("merchTitle") %>' />
                <br />merchDesc:
                <asp:Label ID="merchDescLabel" runat="server" Text='<%# Bind("merchDesc") %>' />
                <br />Price:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Bind("Price") %>' />
                <br />shipPrice:
                <asp:Label ID="shipPriceLabel" runat="server" Text='<%# Bind("shipPrice") %>' />
                <br />Quantity:
                <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />stockCount:
                <asp:Label ID="stockCountLabel" runat="server" Text='<%# Bind("stockCount") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </table>
            <div style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                <asp:DataPager ID="DataPager1" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <td runat="server" style="background-color: #E2DED6;font-weight: bold;color: #333333;">merchID:
                <asp:Label ID="merchIDLabel" runat="server" Text='<%# Bind("merchID") %>' />
                <br />merchTitle:
                <asp:Label ID="merchTitleLabel" runat="server" Text='<%# Bind("merchTitle") %>' />
                <br />merchDesc:
                <asp:Label ID="merchDescLabel" runat="server" Text='<%# Bind("merchDesc") %>' />
                <br />Price:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Bind("Price") %>' />
                <br />shipPrice:
                <asp:Label ID="shipPriceLabel" runat="server" Text='<%# Bind("shipPrice") %>' />
                <br />Quantity:
                <asp:Label ID="QuantityLabel" runat="server" Text='<%# Bind("Quantity") %>' />
                <br />stockCount:
                <asp:Label ID="stockCountLabel" runat="server" Text='<%# Bind("stockCount") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSourceMamaMerch" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:JollyRogersDatabaseConnectionString2 %>" DeleteCommand="DELETE FROM [tblMerch] WHERE [merchID] = @original_merchID AND [merchTitle] = @original_merchTitle AND [merchDesc] = @original_merchDesc AND (([Price] = @original_Price) OR ([Price] IS NULL AND @original_Price IS NULL)) AND (([shipPrice] = @original_shipPrice) OR ([shipPrice] IS NULL AND @original_shipPrice IS NULL)) AND (([Quantity] = @original_Quantity) OR ([Quantity] IS NULL AND @original_Quantity IS NULL)) AND (([stockCount] = @original_stockCount) OR ([stockCount] IS NULL AND @original_stockCount IS NULL))" InsertCommand="INSERT INTO [tblMerch] ([merchID], [merchTitle], [merchDesc], [Price], [shipPrice], [Quantity], [stockCount]) VALUES (@merchID, @merchTitle, @merchDesc, @Price, @shipPrice, @Quantity, @stockCount)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [tblMerch]" UpdateCommand="UPDATE [tblMerch] SET [merchTitle] = @merchTitle, [merchDesc] = @merchDesc, [Price] = @Price, [shipPrice] = @shipPrice, [Quantity] = @Quantity, [stockCount] = @stockCount WHERE [merchID] = @original_merchID AND [merchTitle] = @original_merchTitle AND [merchDesc] = @original_merchDesc AND (([Price] = @original_Price) OR ([Price] IS NULL AND @original_Price IS NULL)) AND (([shipPrice] = @original_shipPrice) OR ([shipPrice] IS NULL AND @original_shipPrice IS NULL)) AND (([Quantity] = @original_Quantity) OR ([Quantity] IS NULL AND @original_Quantity IS NULL)) AND (([stockCount] = @original_stockCount) OR ([stockCount] IS NULL AND @original_stockCount IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_merchID" Type="Int32" />
            <asp:Parameter Name="original_merchTitle" Type="String" />
            <asp:Parameter Name="original_merchDesc" Type="String" />
            <asp:Parameter Name="original_Price" Type="Decimal" />
            <asp:Parameter Name="original_shipPrice" Type="Decimal" />
            <asp:Parameter Name="original_Quantity" Type="Int32" />
            <asp:Parameter Name="original_stockCount" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="merchID" Type="Int32" />
            <asp:Parameter Name="merchTitle" Type="String" />
            <asp:Parameter Name="merchDesc" Type="String" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="shipPrice" Type="Decimal" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="stockCount" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="merchTitle" Type="String" />
            <asp:Parameter Name="merchDesc" Type="String" />
            <asp:Parameter Name="Price" Type="Decimal" />
            <asp:Parameter Name="shipPrice" Type="Decimal" />
            <asp:Parameter Name="Quantity" Type="Int32" />
            <asp:Parameter Name="stockCount" Type="Int32" />
            <asp:Parameter Name="original_merchID" Type="Int32" />
            <asp:Parameter Name="original_merchTitle" Type="String" />
            <asp:Parameter Name="original_merchDesc" Type="String" />
            <asp:Parameter Name="original_Price" Type="Decimal" />
            <asp:Parameter Name="original_shipPrice" Type="Decimal" />
            <asp:Parameter Name="original_Quantity" Type="Int32" />
            <asp:Parameter Name="original_stockCount" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    </asp:Content>
