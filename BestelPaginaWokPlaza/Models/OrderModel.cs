﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestelPaginaWokPlaza.Models
{
    public class OrderModel
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public decimal total_price { get; set; }
        public string payment_option { get; set; }
        public string delivery_time { get; set; }
        public string remarks { get; set; }
        public DateTime dateTime { get; set; }
    }
}
