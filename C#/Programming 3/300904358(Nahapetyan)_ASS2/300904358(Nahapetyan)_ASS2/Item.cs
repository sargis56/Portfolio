using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300904358_Nahapetyan__ASS2
{
    class Item
    {
        public string StoreItem { get; set; }

        public double Price { get; set; }

        public int Qty { get; set; }

        public double Total { get; set; }

        public string Details
        {
            get
            {
                return $"{StoreItem} was born on {Price} and this is the details of a person {Qty}";
            }
        }
    }
}
