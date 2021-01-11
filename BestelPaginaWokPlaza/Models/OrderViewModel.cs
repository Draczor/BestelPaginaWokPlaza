using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestelPaginaWokPlaza.Models
{
    public class OrderViewModel
    {
        [Required]
        public CustomerModel customerModel { get; set; }
        public OrderModel orderModel { get; set; }
        public OrderDetailsModel orderDetailsModel { get; set; }
        public List<string> time_list { get; set; }
    }
}
