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

namespace BestelPaginaWokPlaza.Controllers
{
    public class AdminController : Controller
    {
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

        public IActionResult Login()
        {
            return View();
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

            return View(adminViewModel);
        }

        [HttpPost]
        public Dish GetDishById(int id)
        {
            DishCollection dishCollection = new DishCollection();

            return dishCollection.getDishById(id);
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
    }
}
