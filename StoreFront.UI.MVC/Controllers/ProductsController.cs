using Microsoft.AspNetCore.Mvc;

namespace StoreFront.UI.MVC.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
