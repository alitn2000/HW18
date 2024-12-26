using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopUI.Interfaces;
using ShopUI.Repositories;
using ShopUI.Services;

namespace ShopUI.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService = new CategoryService();
        public IActionResult CatList()
        {
            return View(_categoryService.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCat(string catName)
        {
           _categoryService.Add(catName);
            return RedirectToAction("Index", "Home");
        }
    }
}
