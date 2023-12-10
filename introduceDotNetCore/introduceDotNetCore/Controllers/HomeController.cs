using introduceDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace introduceDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ad = "Sezin Eren";
            ViewBag.Saat = DateTime.Now.Hour;
            List<string> list = new List<string>()
            {
                "Antalya","Eskişehir","İstanbul"
            };

            List<Product> products = new()
            {
                new(){ Id=1, Name="Klavye", Description="Bluetooth "},
                new(){ Id=1, Name="Mouse", Description="Logitech"},
                new(){ Id=1, Name="Monitör", Description="HD"},


            };

            IndexViewModel model = new()
            {
                Cities = list,
                Products = products
            };



            ViewBag.Sehirler = list;
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //sayfayı oluşturur
            //var product = new Product { Name = "Test" };
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            //sayfada "ekle" butonuna bastığınızda çalışacak
            if (ModelState.IsValid)
            {
                return View("Success", product);
            }

            return View();
        }
        //[HttpPost]
        //public IActionResult Baska(double price)
        //{
        //    return RedirectToAction("Index");
        //}



    }
}
