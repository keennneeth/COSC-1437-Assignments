using System;
using System.Collections.Generic;
using System.Text;

    /*
    * Kenneth Rodriguez
    */

namespace CustomerAndInventory
{
    class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Cost { get; set; } // ProfReynolds - good
        public int Size { get; set; } // ProfReynolds - good
        public int Weight { get; set; } // ProfReynolds - good
    }
}
