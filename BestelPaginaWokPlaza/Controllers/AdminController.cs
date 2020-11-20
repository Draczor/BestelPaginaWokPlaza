using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestelPaginaWokPlaza.Models;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Interface;

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
        public IActionResult AddCategory(CategoryModel categoryModel)
        {
            Category category = new Category();
            category.addCategory(new CategoryDTO { category_name = categoryModel.category_name });
            return RedirectToAction("AddCategory", "Admin");
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Management()
        {
            return View();
        }
    }
}
