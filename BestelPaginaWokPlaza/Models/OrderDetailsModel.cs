using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestelPaginaWokPlaza.Models
{
    public class OrderDetailsModel
    {
        public int id { get; set; }
        public int dish_id { get; set; }
        public decimal order_id { get; set; }
        public int quantity { get; set; }
    }
}
