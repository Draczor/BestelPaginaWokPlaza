using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BestelPaginaWokPlaza.Models
{
    public class AdminViewModel
    {
        public CategoryDTO categoryDTO { get; set; }
        public List<SelectListItem> categoryList { get; set; } 
        public DishModel dishModel { get; set; } 
    }
}
