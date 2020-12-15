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

        [HttpGet]
        public IActionResult CheckOut()
        {
            OrderViewModel orderViewModel = new OrderViewModel();

            var startTime = DateTime.Parse("16:00");
            var endTime = DateTime.Parse("20:00");
            List<string> time_list = new List<string>();

            while (startTime < endTime)
            {

                time_list.Add(startTime.ToShortTimeString());
                startTime = startTime.AddMinutes(15);
            }
            orderViewModel.time_list = time_list;

            return View(orderViewModel);
        }

        [HttpPost]
        public IActionResult CheckOut(OrderViewModel orderViewModel)
        {
            CustomerDTO customerDTO = new CustomerDTO();
            customerDTO.name = orderViewModel.customerModel.name;
            customerDTO.street_housenr = orderViewModel.customerModel.street_housenr;
            customerDTO.postal_code = orderViewModel.customerModel.postal_code;
            customerDTO.place = orderViewModel.customerModel.place;
            customerDTO.email = orderViewModel.customerModel.email;
            customerDTO.phone_number = orderViewModel.customerModel.phone_number;

            Customer customer = new Customer();
            ShoppingCartController shoppingCartController = new ShoppingCartController();

            OrderDTO orderDTO = new OrderDTO();
            orderDTO.customer_id = customer.addCustommer(customerDTO);
            orderDTO.total_price = shoppingCartController.CalcTotalPrice(Request.Cookies["winkelwagen"]);
            orderDTO.payment_option = orderViewModel.orderModel.payment_option;
            orderDTO.status = "Nieuw";
            orderDTO.delivery_time = orderViewModel.orderModel.delivery_time;
            orderDTO.remarks = orderViewModel.orderModel.remarks;
            orderDTO.dateTime = DateTime.Now;

            Order order = new Order();
            int lastInsertedOrderID = order.placeOrder(orderDTO);

            List<Dish> DishList = shoppingCartController.GetAllShoppingCartItems(Request.Cookies["winkelwagen"]);
            var groupedDishList = DishList.GroupBy(u => u.id).Select(grp => grp.ToList()).ToList();

            foreach (List<Dish> dishList in groupedDishList)
            {
                OrderDetailsDTO orderDetailsDTO = new OrderDetailsDTO();
                orderDetailsDTO.dish_id = dishList[0].id;
                orderDetailsDTO.order_id = lastInsertedOrderID;
                orderDetailsDTO.quantity = dishList.Count();

                OrderDetails orderDetails = new OrderDetails();
                orderDetails.insertOrderDetails(orderDetailsDTO);
            }

            return RedirectToAction("Order", "OrderPage");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
