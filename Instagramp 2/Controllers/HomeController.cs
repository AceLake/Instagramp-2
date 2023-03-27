using Microsoft.AspNetCore.Mvc;
using ClassLibrary;
using Instagramp_2.Service;

namespace Instagramp_2.Controllers
{
    public class HomeController : Controller
    {
        PostDAO postDAO = new PostDAO();
        public IActionResult Index()
        {
            return View(postDAO.GetAll());
        }
    }
}
