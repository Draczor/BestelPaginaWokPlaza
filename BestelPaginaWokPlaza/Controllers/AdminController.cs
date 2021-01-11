using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestelPaginaWokPlaza.Models;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace BestelPaginaWokPlaza.Controllers
{
    public class AdminController : Controller
    {
        private const string SessionLogin = "false";

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(AdminViewModel adminViewModel)
        {
            Category category = new Category();
            category.addCategory(new CategoryDTO { category_name = adminViewModel.categoryDTO.category_name });
            return RedirectToAction("Management", "Admin");
        }

        [HttpGet]
        public IActionResult AddDish()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDish(AdminViewModel adminViewModel)
        {
            if (adminViewModel.dishModel.description == null)
            {
                adminViewModel.dishModel.description = "";
            }

            DishCollection dishCollection = new DishCollection();
            dishCollection.addDish(new Dish { 
                name = adminViewModel.dishModel.name, 
                price = adminViewModel.dishModel.price, 
                category_id = adminViewModel.dishModel.category_id, 
                description = adminViewModel.dishModel.description 
            });

            return RedirectToAction("Management", "Admin");
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString(SessionLogin) == "true")
            {
                return RedirectToAction("Management", "Admin");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.email = loginModel.email;
            userDTO.password = loginModel.password;

            User user = new User();

            if (ModelState.IsValid)
            {
                if (user.login(userDTO) == true)
                {
                    HttpContext.Session.SetString(SessionLogin, "true");
                    return RedirectToAction("Management", "Admin");
                }
                else
                {
                    TempData["loginErrorMsg"] = "Incorrecte inlog gegevens.";
                    ViewData["loginErrorMsg"] = TempData["loginErrorMsg"];
                    return View(loginModel);
                }
            }
            return View(loginModel);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString(SessionLogin, "false");

            return RedirectToAction("Order", "OrderPage");
        }

        public IActionResult Management()
        {
            Category category = new Category();
            DishCollection dishCollection = new DishCollection();
            AdminViewModel adminViewModel = new AdminViewModel();

            List<CategoryDTO> categories = category.getCategory();
            adminViewModel.categoryList = categories.Select(category => new SelectListItem { 
                Value = category.id.ToString(), 
                Text = category.category_name 
            }).ToList();

            List<DishDTO> dishes = dishCollection.getDishList();
            adminViewModel.dishList = dishes.Select(dish => new DishModel { id = dish.id, name = dish.name, price = dish.price, category_id = dish.category_id, description = dish.description }).ToList();

            if (HttpContext.Session.GetString(SessionLogin) != "true")
            {
                return RedirectToAction("Login", "Admin");
            }

            return View(adminViewModel);
        }

        [HttpPost]
        public Dish GetDishById(int id)
        {
            DishCollection dishCollection = new DishCollection();

            return dishCollection.getDishById(id);
        }

        [HttpGet]
        public List<OrderDetailsAndDishDTO> ReturnDishAndOrderDetailsByOrderID(int id)
        {
            OrderDetails orderDetails = new OrderDetails();

            return orderDetails.returnDishAndOrderDetailsByOrderIDList(id);
        }

        [HttpGet]
        public IActionResult UpdateDish()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateDish(AdminViewModel adminViewModel)
        {
            if (adminViewModel.dishModel.description == null)
            {
                adminViewModel.dishModel.description = "";
            }

            Dish dish = new Dish();
            dish.id = adminViewModel.dishModel.id;
            dish.name = adminViewModel.dishModel.name;
            dish.price = adminViewModel.dishModel.price;
            dish.category_id = adminViewModel.dishModel.category_id;
            dish.description = adminViewModel.dishModel.description;
            dish.updateDish();

            return RedirectToAction("Management", "Admin");
        }

        [HttpPost]
        public IActionResult DeleteDish(AdminViewModel adminViewModel)
        {
            DishCollection dishCollection = new DishCollection();

            dishCollection.deleteDish(adminViewModel.dishModel.id);
            return RedirectToAction("Management", "Admin");
        }

        [HttpGet]
        public IActionResult OrderOverView()
        {
            if (HttpContext.Session.GetString(SessionLogin) != "true")
            {
                return RedirectToAction("Login", "Admin");
            }

            Order order = new Order();
            OverviewModel overviewModel = new OverviewModel();

            List<AllOrdersDTO> orders = order.returnAllOrders();

            overviewModel.AllOrderList = orders.Select(order => new AllOrderModel { 
                id = order.id, 
                customer_id = order.customer_id,
                total_price = order.total_price,
                payment_option = order.payment_option,
                status = order.status,
                delivery_time = order.delivery_time,
                remarks = order.remarks,
                dateTime = order.dateTime,
                name = order.name,
                street_housenr = order.street_housenr,
                postal_code = order.postal_code,
                place = order.place,
                email = order.email,
                phone_number = order.phone_number,
            }).ToList();
            
            return View(overviewModel);
        }

        [HttpGet]
        public IActionResult SelectedOrder()
        {
            Order order = new Order();
            OverviewModel overviewModel = new OverviewModel();

            List<AllOrdersDTO> orders = order.returnAllOrders();

            overviewModel.AllOrderList = orders.Select(order => new AllOrderModel
            {
                id = order.id,
                customer_id = order.customer_id,
                total_price = order.total_price,
                payment_option = order.payment_option,
                status = order.status,
                delivery_time = order.delivery_time,
                remarks = order.remarks,
                dateTime = order.dateTime,
                name = order.name,
                street_housenr = order.street_housenr,
                postal_code = order.postal_code,
                place = order.place,
                email = order.email,
                phone_number = order.phone_number,
            }).ToList();

            return View(overviewModel);
        }
    }
}
