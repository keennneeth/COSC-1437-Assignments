using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAndInventory
{
    class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int DateOrdered { get; set; }
        public int OrderNumber { get; set; }
        public int NumberOfItemsInOrder { get; set; }
        public int OrderTotal { get; set; }
    }
}
