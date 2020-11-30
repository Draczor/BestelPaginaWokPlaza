using BestelPaginaWokPlaza.Models;
using Interface;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace BestelPaginaWokPlaza.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public void AddToCart(int id)
        {

            //get
            string allcookies = Request.Cookies["winkelwagen"];

            //set
            IResponseCookies setcookies = Response.Cookies;
            setcookies.Append("winkelwagen", id.ToString() + " " + allcookies);

        }

        public List<DishDTO> GetAllShoppingCartItems()
        {
            DishCollection dishCollection = new DishCollection();

            if(Request.Cookies["winkelwagen"] != null)
            {
                List<int> dishes = Request.Cookies["winkelwagen"].Split(" ").Where(dish => dish != "").Select(dish => Convert.ToInt32(dish)).ToList();
                List<DishDTO> cartItems = new List<DishDTO>();
                foreach (int dishId in dishes)
                {
                    DishDTO dish = dishCollection.getDishById(dishId);
                    cartItems.Add(dish);
                }

                return cartItems;
            }
            else
            {
                return null;
            }
        }
    }
}
