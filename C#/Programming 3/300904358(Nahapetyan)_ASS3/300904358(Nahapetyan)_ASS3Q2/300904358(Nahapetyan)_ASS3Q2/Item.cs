using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300904358_Nahapetyan__ASS3Q2
{
    class Item
    {
        public int ItemNum { get; }
        public string ItemDesc { get; }
        public int Quantity { get; }
        public double UnitPrice { get; }

        public Item(int itemNum, string itemDesc, int quantity, double unitPrice)
        {
            ItemNum = itemNum;
            ItemDesc = itemDesc;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public override string ToString() => $"{ItemNum} {ItemDesc} {Quantity} {UnitPrice,0:C}";
    }
}
