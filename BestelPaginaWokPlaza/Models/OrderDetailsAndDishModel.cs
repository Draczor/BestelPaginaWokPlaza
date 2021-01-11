using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class OrderDetailsAndDishModel
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
