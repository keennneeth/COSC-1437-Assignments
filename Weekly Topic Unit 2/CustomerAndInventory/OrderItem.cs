using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAndInventory
{
    class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Cost { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
    }
}
