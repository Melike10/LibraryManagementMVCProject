using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {


            return View();
        }

    }
}
