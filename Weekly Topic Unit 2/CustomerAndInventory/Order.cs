using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAndInventory
{
    class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string OrderDate { get; set; }
        public int OrderTotal { get; set; }
        public int TotalNumberOfItemsInOrder { get; set; }
    }
}
