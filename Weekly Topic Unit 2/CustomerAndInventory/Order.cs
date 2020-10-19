using System;
using System.Collections.Generic;
using System.Text;

  /*
  * Kenneth Rodriguez
  */

namespace CustomerAndInventory
{
    class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string OrderDate { get; set; } // ProfReynolds - good
        public int OrderTotal { get; set; } // ProfReynolds - good
        public int TotalNumberOfItemsInOrder { get; set; } // ProfReynolds - good
    }
}
