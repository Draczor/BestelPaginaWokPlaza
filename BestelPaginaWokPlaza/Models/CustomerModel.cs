using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestelPaginaWokPlaza.Models
{
    public class CustomerModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Vul uw naam in.")]
        public string name { get; set; }
        [Required(ErrorMessage = "Vul uw straat en huisnummer in.")]
        public string street_housenr { get; set; }
        [RegularExpression(@"\d{4}[ ]?[A-Z,a-z]{2}", ErrorMessage = "Ongeldig postcode.")]
        [Required(ErrorMessage = "Vul uw postcode in. (voorbeeld: 6085HH)")]
        public string postal_code { get; set; }
        [Required(ErrorMessage = "Vul uw woonplaats in.")]
        public string place { get; set; }
        [Required(ErrorMessage = "Vul uw email in.")]
        public string email { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "Uw telefoonnummer mag alleen cijfers bevatten.")]
        [Required(ErrorMessage = "Vul uw telefoonnummer in.")]
        public string phone_number { get; set; }
    }
}
