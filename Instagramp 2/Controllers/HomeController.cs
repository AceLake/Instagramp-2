using Microsoft.AspNetCore.Mvc;

namespace Instagramp_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
