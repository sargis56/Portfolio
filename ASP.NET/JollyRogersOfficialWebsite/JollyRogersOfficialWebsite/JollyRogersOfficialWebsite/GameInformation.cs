using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JollyRogersOfficialWebsite
{
    public class GameInformation
    {
        public int GameID { get; set; }
        public string GameTitle { get; set; }
        public string GameSeries { get; set; }
        public string Publisher { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Programmer { get; set; }
        public string Artist { get; set; }
        public string Platforms { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Modes { get; set; }
        public double Price { get; set; }
        public double ShipPrice { get; set; }
        public string GameDescription { get; set; }
        public int Quantity { get; set; }
        public int StockCount { get; set; }

        public GameInformation(int gameId, string gameTitle, 
            string gameSeries, string publisher, string director, string producer, string programmer,
            string artist, string platforms, DateTime releaseDate, string genre, string modes, double price,
            double shipPrice, string gameDesc, int quantity, int stockCount)
        {
            GameID = gameId;
            GameTitle = gameTitle;
            GameSeries = gameSeries;
            Publisher = publisher;
            Director = director;
            Producer = producer;
            Programmer = programmer;
            Artist = artist;
            Platforms = platforms;
            ReleaseDate = releaseDate;
            Genre = genre;
            Modes = modes;
            Price = price;
            ShipPrice = shipPrice;
            GameDescription = gameDesc;
            Quantity = quantity;
            StockCount = stockCount;
        }
    }
}