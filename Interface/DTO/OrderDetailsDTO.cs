using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class OrderDetailsDTO
    {
        public int id { get; set; }
        public int dish_id { get; set; }
        public int order_id { get; set; }
        public int quantity { get; set; }
    }
}
