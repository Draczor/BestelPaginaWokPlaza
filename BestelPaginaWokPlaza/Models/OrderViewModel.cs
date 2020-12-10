using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestelPaginaWokPlaza.Models
{
    public class OrderViewModel
    {
        public CustomerModel customerModel { get; set; }
        public OrderModel orderModel { get; set; }
        public OrderDetailsModel orderDetailsModel { get; set; }
    }
}
