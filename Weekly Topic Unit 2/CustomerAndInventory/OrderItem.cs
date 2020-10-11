﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAndInventory
{
    class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int ProductCost { get; set; }
        public int ProductWeight { get; set; }
        public int ProductSize { get; set; }
    }
}
