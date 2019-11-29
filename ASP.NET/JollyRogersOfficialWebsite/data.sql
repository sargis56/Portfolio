USE [JollyRogersDatabase]
DROP TABLE [dbo].[tblCustomer]
DROP TABLE [dbo].[tblLootBox]
DROP TABLE [dbo].[tblLootBoxDetails]
DROP TABLE [dbo].[tblGames]
DROP TABLE [dbo].[tblMerch]

CREATE TABLE [dbo].[tblCustomer](
	[customerID] [int] NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[phone] [int] NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[paymentInfo] [nvarchar](50) NOT NULL,
	[creditNo] [int] NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED (
	[customerID] ASC)
	WITH (
		PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, 
		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) 
	ON [PRIMARY]

CREATE TABLE [dbo].[tblLootBox](
	[lootBoxID] [int] NOT NULL,
	[lootBoxTotalPrice] [money] NOT NULL,
	[lootBoxQuantity] [int] NOT NULL,
	[lootBoxDate] [date] NOT NULL,
	[customerID] [int] NULL,
 CONSTRAINT [PK_tblLootBox] PRIMARY KEY CLUSTERED (
	[lootBoxID] ASC)
	WITH (
		PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, 
		IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) 
	ON [PRIMARY]

CREATE TABLE [dbo].[tblLootBoxDetails](
	[lootBoxDetailsID] [int] NOT NULL IDENTITY,
	[itemName] [nvarchar] (50) NULL,
	[itemPrice] [money] NULL,
	[itemQuantity] [int] NULL,
	[itemDate] [date] NULL,
	[itemID] [int] NULL,
	[lootBoxID] [int] NULL,
 CONSTRAINT [PK_tblLootBoxDetails] PRIMARY KEY CLUSTERED (
	[lootBoxDetailsID] ASC)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, 
		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) 
	ON [PRIMARY]


CREATE TABLE [dbo].[tblGames](
	[gameID] [int] NOT NULL,
	[gameTitle] [nvarchar](50) NOT NULL,
	[gameSeries] [nvarchar](50) NOT NULL,
	[publisher] [nvarchar](50) NOT NULL,
	[director] [nvarchar](50) NOT NULL,
	[producer] [nvarchar](50) NOT NULL,
	[programmer] [nvarchar](50) NOT NULL,
	[artist] [nvarchar](50) NOT NULL,
	[platforms] [nvarchar](50) NOT NULL,
	[releaseDate] [date] NOT NULL,
	[genre] [nchar](50) NOT NULL,
	[modes] [nchar](50) NOT NULL,
	[price] [money] NULL,
	[shipPrice] [money] NULL,
	[gameDesc] [nvarchar](200) NOT NULL,
	[quantity] [int] NULL,
	[stockCount] [int] NULL,
 CONSTRAINT [PK_tblGames] PRIMARY KEY CLUSTERED (
	[gameID] ASC)
	WITH (
		PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) 
	ON [PRIMARY]

INSERT INTO [dbo].[tblGames]
	VALUES (100,'One Bone','One Bone Series','Jolly Rogers','Winston Heraldo',
			'Winston Heraldo','Sargis Naphatyen','Kris Campbell','Playstation 4, Steam, Xbox One',
			'2018-01-12','2D/Adventure','Single Player',69.99,9.99,'Travel the world with your pirate crew.'
			,0,1000);
INSERT INTO [dbo].[tblGames]
	VALUES (101,'Amazon Fighters','Amazon Fighters Series','Jolly Rogers','Winston Heraldo',
			'Winston Heraldo','Sargis Naphatyen','Kris Campbell','Playstation 4, Steam, Xbox One',
			'2018-11-20','Fighter','Multiplayers',49.99,9.99,'Battle your friends with the toughest of Amazons!'
			,0,1000);
INSERT INTO [dbo].[tblGames]
	VALUES (102,'Vessel Chronicles','Vessel Chronicles Series','Jolly Rogers','Winston Heraldo',
			'Winston Heraldo','Sargis Naphatyen','Kris Campbell','Steam, iOS, Android',
			'2019-09-16','RPG','Online Multiplayers',19.99,0.00,'Build your ship, set sail, destroy rivals!'
			,0,0);
INSERT INTO [dbo].[tblGames]
	VALUES (103,'One Bone 2','One Bone Series','Jolly Rogers','Winston Heraldo',
			'Winston Heraldo','Sargis Naphatyen','Kris Campbell','Playstation 4, Steam, Xbox One',
			'2020-02-28','2D/Adventure','Single Player',69.99,0.00,'The Quest continues...'
			,0,0);
INSERT INTO [dbo].[tblGames]
	VALUES (104,'Dead Sea Atlantis','One Bone Series','Jolly Rogers','Winston Heraldo',
			'Winston Heraldo','Sargis Naphatyen','Kris Campbell','Steam, iOS, Android',
			'2021-05-25','2D/Adventure','Single Player',14.99,0.00,'To discover the ruins of Atlantis...'
			,0,0);

CREATE TABLE [dbo].[tblMerch](
	[merchID] [int] NOT NULL,
	[merchTitle] [nvarchar](50) NOT NULL,
	[merchDesc] [nvarchar](200) NOT NULL,
	[price] [money] NULL,
	[shipPrice] [money] NULL,
	[quantity] [int] NULL,
	[stockCount] [int] NULL,
 CONSTRAINT [PK_tblMerch] PRIMARY KEY CLUSTERED (
	[merchID] ASC)
	WITH (
		PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, 
		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) 
	ON [PRIMARY]

INSERT INTO [dbo].[tblMerch]
	VALUES (200,'Jolly Rogers Fitted Cap', 'Rep your favorite game company!',29.99,0.00,0,50);
INSERT INTO [dbo].[tblMerch]
	VALUES (201,'Ones Shirt', 'Official One Bones shirt!',19.99,9.99,0,100);
INSERT INTO [dbo].[tblMerch]
	VALUES (202,'Amazon Fighters Shirt', 'Offical Amazon Fighters shirt!',19.99,9.99,0,100);
INSERT INTO [dbo].[tblMerch]
	VALUES (203,'Jolly Rogers Mug', 'Drink your favourite breverage using this mug',9.99,4.99,0,50);