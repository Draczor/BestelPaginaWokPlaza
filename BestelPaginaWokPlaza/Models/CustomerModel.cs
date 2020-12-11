using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestelPaginaWokPlaza.Models
{
    public class CustomerModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string street_housenr { get; set; }
        public string postal_code { get; set; }
        public string place { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
    }
}
