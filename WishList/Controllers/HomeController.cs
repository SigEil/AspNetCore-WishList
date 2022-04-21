using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index.cshtml");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
