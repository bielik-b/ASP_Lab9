using aspasp9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aspasp9.Controllers
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
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "IPhone", 35000));
            products.Add(new Product(2, "Samsung", 28000));
            products.Add(new Product(3, "LG", 26500));
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

