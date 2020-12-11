using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class OrderDTO
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public decimal total_price { get; set; }
        public string payment_option { get; set; }
        public string status { get; set; }
        public string delivery_time { get; set; }
        public string remarks { get; set; }
        public DateTime dateTime { get; set; }
    }
}
