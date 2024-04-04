using aspasp9.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspasp9.ViewComponents
{
    public class ProdTable : ViewComponent
    {
        public IViewComponentResult Invoke(List<Product> products)
        {
            return View(products);
        }
    }
}

