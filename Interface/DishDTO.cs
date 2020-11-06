using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class DishDTO
    {
        public int dish_id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int category_id { get; set; }
        public string description { get; set; }
    }
}
