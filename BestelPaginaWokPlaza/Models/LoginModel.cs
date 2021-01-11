using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestelPaginaWokPlaza.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Vul uw email in.")]
        public string email { get; set; }
        [Required(ErrorMessage = "Vul uw paswoord in.")]
        public string password { get; set; }
        public string user_name { get; set; }
    }
}
