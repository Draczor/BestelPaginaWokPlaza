using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestelPaginaWokPlaza.Models
{
    public class DishModel
    {
        public int dish_id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int category_id { get; set; }
        public string description { get; set; }
    }
    
}
