using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300904358_Nahapetyan__ASS3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Items
            var items = new List<Item>();
            items.Add( new Item(83, "Electric sander", 7, 59.98));
            items.Add( new Item(24, "Power saw", 18, 99.99));
            items.Add(new Item(7, "Sledge hammer", 11, 21.55));
            items.Add(new Item(77, "Hammer", 76, 11.99));
            items.Add(new Item(39, "Lawn mower", 3, 79.95));
            items.Add(new Item(68, "Screwdriver", 106, 7.99));
            items.Add(new Item(56, "Jig Saw", 21, 11.95));
            items.Add(new Item(3, "Wrench", 34, 7.95));


            Console.Write("Current Inventory:");
            foreach (var item in items)
            {
                Console.Write("\n" + $"{item}");
            }


            //1.	Use LINQ to sort the data by item description [1 mark]
            var sortInAscendingOrder =
                from item in items
                orderby item.ItemDesc ascending
                //select item;
                select new
                {
                    item.ItemNum,
                    item.ItemDesc,
                    item.Quantity,
                    item.UnitPrice
                };

            Console.Write("\n\n1. Results of query sorted by item description:");
            foreach (var item in sortInAscendingOrder)
            {
                Console.Write("\n" + $"{item}");
            }


            //2.	Use LINQ to select the item description and quantity, and sort the results by quantity[1 mark]
            var sortInAscendingOrderAndQuanity =
                from item in items
                orderby item.Quantity
                select new
                {
                    item.Quantity,
                    item.ItemDesc
                };

            Console.Write("\n\n2. Results of query sorted by quantity \nwith item description and quantity selected:");
            foreach (var item in sortInAscendingOrderAndQuanity)
            {
                Console.Write("\n" + $"{item}");
            }

            //3.	Use LINQ to select the item description and its total value (i.e., quantity * unit price), order the results by total value [1.5 marks]
            var sortInTotalValue =
                from item in items
                let totalValue = (item.Quantity * item.UnitPrice)
                orderby totalValue
                select new
                {
                    item.ItemDesc,
                    totalValue
                };

            Console.Write("\n\n3. Results of query sorted by total value \nwith item description and total value selected:");
            foreach (var item in sortInTotalValue)
            {
                Console.Write("\n" + $"{item}");
            }

            //4.	Use LINQ to retrieve and display the most expensive item [0.5 mark]
            //For Single Item
            var sortInExpensiveItem =
                (from item in items
                 orderby item.UnitPrice descending
                 select new
                 {
                     item.ItemNum,
                     item.ItemDesc,
                     item.Quantity,
                     item.UnitPrice
                 }).First();

            Console.Write("\n\n4. Results of query sorted by most expensive item:");
            Console.Write("\n" + $"{sortInExpensiveItem}");

            ////For all items
            //var sortInExpensiveItem =
            //    from item in items
            //    orderby item.UnitPrice descending
            //    select new
            //    {
            //        item.ItemNum,
            //        item.ItemDesc,
            //        item.Quantity,
            //        item.UnitPrice
            //    };

            //Console.Write("\n\nResults of query sorted by most expensive item:");
            //foreach (var item in sortInExpensiveItem)
            //{
            //    Console.Write("\n" + $"{item}");
            //}

            Console.ReadLine();
        }


    }
}
