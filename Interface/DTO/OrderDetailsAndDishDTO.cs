using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class OrderDetailsAndDishDTO
    {
        public int id { get; set; }
        public int dish_id { get; set; }
        public int order_id { get; set; }
        public int quantity { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int category_id { get; set; }
        public string description { get; set; }
    }
}
