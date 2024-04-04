using Microsoft.AspNetCore.Mvc;

namespace aspasp9.Controllers
{
    public class ForecastController : Controller
    {
        [HttpGet]
        public IActionResult ForecastForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForecastForm(string city)
        {
            return View("Forecast", city);
        }
        public IActionResult Forecast(string city)
        {
            return View(city);
        }
    }
}

