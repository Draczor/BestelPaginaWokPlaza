using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class AllOrdersDTO
    {
        //public List<OrderDTO> OrderList { get; set; }
        //public List<OrderDetailsDTO> OrderDetailsList { get; set; }
        //public List<CustomerDTO> CustomerList { get; set; }

        public int id { get; set; }
        public int customer_id { get; set; }
        public decimal total_price { get; set; }
        public string payment_option { get; set; }
        public string status { get; set; }
        public string delivery_time { get; set; }
        public string remarks { get; set; }
        public DateTime dateTime { get; set; }
        public string name { get; set; }
        public string street_housenr { get; set; }
        public string postal_code { get; set; }
        public string place { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
    }
}
