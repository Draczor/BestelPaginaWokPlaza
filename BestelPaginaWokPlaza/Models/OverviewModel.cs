using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestelPaginaWokPlaza.Models
{
    public class OverviewModel
    {
        public List<AllOrderModel> AllOrderList { get; set; }
        public AllOrderModel OneOrder { get; set; }
        public List<OrderDetailsAndDishModel> OrderDetailsAndDishList { get; set; }
    }
}
