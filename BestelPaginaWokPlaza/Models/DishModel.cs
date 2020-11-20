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
        public string price { get; set; }
        public string category_id { get; set; }
        public string description { get; set; }
    }
}
