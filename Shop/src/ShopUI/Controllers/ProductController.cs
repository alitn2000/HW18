using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopUI.Interfaces;
using ShopUI.Services;

namespace InferaStructers.Controllers;

[Authorize]
public class ProductController : Controller
{
    IProductService _productService = new ProductService();
    public IActionResult List()
    {
        return View(_productService.GetAll());
    }


    [HttpGet] 
    public IActionResult Delete(int id)
    {
        _productService.Delete(id);
        return RedirectToAction("List");
    }
}