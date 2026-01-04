using Microsoft.AspNetCore.Mvc;
using Mini_E_Commerce_Web_API.Models;
using Mini_E_Commerce_Web_API.Services;

namespace Mini_E_Commerce_Web_API.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> AllProducts()
        {
            var products =await _productService.GetAllProducts();
            return View(products);
        }
    }
}
