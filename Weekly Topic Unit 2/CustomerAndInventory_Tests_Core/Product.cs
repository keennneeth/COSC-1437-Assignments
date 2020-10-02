using System;
using System.Collections.Generic;
using System.Text;

  /*
  * Kenneth Rodriguez
  */

namespace CustomerAndInventory
{
    class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Price { get; set; } // ProfReynolds - good
        public string Reviews { get; set; } // ProfReynolds - good
        public string Instructions { get; set; } // ProfReynolds - good
    }
}
