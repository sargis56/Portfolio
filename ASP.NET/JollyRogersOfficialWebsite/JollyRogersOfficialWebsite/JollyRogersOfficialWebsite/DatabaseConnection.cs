using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;

namespace JollyRogersOfficialWebsite
{
    public class DatabaseConnection
    {
        private static SqlConnection cn;
        private static SqlCommand cmd;
        private static SqlDataReader reader;
        private static string query;


        static DatabaseConnection()
        {
            //SARGIS-PC\SQLEXPRESS
            //cn = new SqlConnection(@"Data Source=KRISCAMPBELL-PC\SQLEXPRESS;Initial Catalog=JollyRogersDatabase;Integrated Security=True");
            cn = new SqlConnection(@"Data Source=SARGIS-PC\SQLEXPRESS;Initial Catalog=JollyRogersDatabase;Integrated Security=True");
        }

        public static string GetGameTitleInfo(int gameID)
        {
            string title;
            query = string.Format(@"Select * FROM tblGames WHERE gameID = " + gameID);
            cmd = new SqlCommand(query, cn);
            try
            {
                cn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                title = reader["gameTitle"].ToString();
            }
            finally
            {
                reader.Close();
                cn.Close();
            }
            return title;
        }

        public static GameInformation GetGameInfo(int gameID)
        {
            GameInformation selectGame;
            string gameTitle, gameSeries, publisher, director, producer, programmer, artist, platforms;
            DateTime releaseDate;
            string genre, modes;
            double price, shipPrice;
            string gameDesc;
            int quantity, stockCount;
            query = string.Format(@"Select * FROM tblGames WHERE gameID = " + gameID);
            cmd = new SqlCommand(query, cn);
            try
            {
                cn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();

                gameTitle= reader["gameTitle"].ToString();
                gameSeries = reader["gameSeries"].ToString();
                publisher = reader["publisher"].ToString();
                director = reader["director"].ToString();
                producer = reader["producer"].ToString();
                programmer = reader["programmer"].ToString();
                artist = reader["artist"].ToString();
                platforms = reader["platforms"].ToString();
                releaseDate = Convert.ToDateTime(reader["releaseDate"].ToString());
                genre = reader["genre"].ToString();
                modes = reader["modes"].ToString();
                price = Convert.ToDouble(reader["price"].ToString());
                shipPrice = Convert.ToDouble(reader["shipPrice"].ToString());
                gameDesc = reader["gameDesc"].ToString();
                quantity = Convert.ToInt32(reader["quantity"].ToString());
                stockCount = Convert.ToInt32(reader["stockCount"].ToString());

                selectGame = new GameInformation
                    (gameID, gameTitle, gameSeries, publisher, director, producer, programmer,artist, platforms, releaseDate, genre, modes, 
                    price, shipPrice, gameDesc, quantity, stockCount);
            }
            finally
            {
                reader.Close();
                cn.Close();
            }
            return selectGame;
        }

        public static int GetExistingQuantity(int cartID)
        {
            query = string.Format(@"Select itemQuantity FROM tblLootBoxDetails WHERE itemID = {0}", cartID);
            cmd = new SqlCommand(query, cn);
            int itemQuantity;
            try
            {
                cn.Open();
                reader = cmd.ExecuteReader();
                bool itemPresent = reader.Read();
                if (itemPresent)
                {
                    itemQuantity = Convert.ToInt32(reader["itemQuantity"].ToString());
                }
                else
                {
                    itemQuantity = 0;
                }
            }
            finally
            {
                reader.Close();
                cn.Close();
            }
            return itemQuantity;
        }

        public static void WriteCartInfo(string itemName, double itemPrice, int itemQuantity, string itemDate, int itemID, int lootBoxID)
        {
            string query;
            int quantity = GetExistingQuantity(itemID);
            if (quantity == 0)
            {
                query = string.Format("INSERT into tblLootBoxDetails (itemName, itemPrice, itemQuantity, itemDate, itemID, lootBoxID) VALUES ('{0}', '{1}', '{2}', '{3:yyyymmdd}', '{4}', '{5}')",
                    itemName, itemPrice, itemQuantity, itemDate, itemID, lootBoxID);
            }
            else
            {
                int newQuantity = quantity + 1;
                // Game is already in the cart
                query = string.Format("UPDATE tblLootBoxDetails SET itemQuantity = {0}, itemPrice = {1} WHERE itemID = {2}",
                    newQuantity, newQuantity * itemPrice, itemID);
            }

            
            cmd = new SqlCommand(query, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool CartNotEmpty()
        {
            query = string.Format(@"Select * FROM tblLootBoxDetails");
            cmd = new SqlCommand(query, cn);
            bool itemsPresent;
            try
            {
                cn.Open();
                reader = cmd.ExecuteReader();
                itemsPresent = reader.Read();
            }
            finally
            {
                reader.Close();
                cn.Close();
            }
            return itemsPresent;
        }

        public static void ClearCart()
        {
            query = string.Format(@"Truncate Table tblLootBoxDetails");
            cmd = new SqlCommand(query, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                reader.Close();
                cn.Close();
            }
        }
    }
}