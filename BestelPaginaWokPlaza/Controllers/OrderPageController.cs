using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BestelPaginaWokPlaza.Models;
using Logic;
using Interface;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BestelPaginaWokPlaza.Controllers
{
    public class OrderPageController : Controller
    {
        private readonly ILogger<OrderPageController> _logger;

        public OrderPageController(ILogger<OrderPageController> logger)
        {
            _logger = logger;
        }

        public IActionResult Order()
        {
            Category category = new Category();
            DishCollection dishCollection = new DishCollection();
            AdminViewModel adminViewModel = new AdminViewModel();

            List<CategoryDTO> categories = category.getCategory();
            adminViewModel.categoryList = categories.Select(category => new SelectListItem
            {
                Value = category.id.ToString(),
                Text = category.category_name
            }).ToList();


            List<DishDTO> dishes = dishCollection.getDishList();
            adminViewModel.dishList = dishes.Select(dish => new DishModel { id = dish.id, name = dish.name, price = dish.price, category_id = dish.category_id, description = dish.description }).ToList();

            return View(adminViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddToCart()
        {

            return RedirectToAction("Order", "OrderPage");
        }

        public IActionResult CheckOut()
        {

            return View();
        }
    }
}
