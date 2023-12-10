using Microsoft.AspNetCore.Mvc;
using miniShop.Models;
using miniShop.Services;
using System.Diagnostics;

namespace miniShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var products = new List<Product>()
            //{
            //    new(){ Id=1, Name="Çikolata", Price=20, Description="Sütlü..."},
            //    new(){ Id=2, Name="Gözlük", Price=20, Description="aaa..."},
            //    new(){ Id=3, Name="Pijama", Price=20, Description="bbb..."},
            //    new(){ Id=4, Name="Elfeneri", Price=20, Description="ccc..."},

            //};

            var productService = new ProductService();
            var products = productService.GetProducts();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}