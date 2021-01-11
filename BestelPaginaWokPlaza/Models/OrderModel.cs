using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestelPaginaWokPlaza.Models
{
    public class OrderModel
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public decimal total_price { get; set; }
        [Required(ErrorMessage = "Kies een betaalmethode.")]
        public string payment_option { get; set; }
        public string status { get; set; }
        public string delivery_time { get; set; }
        public string remarks { get; set; }
        public DateTime dateTime { get; set; }
    }
}
