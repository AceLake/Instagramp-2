using ClassLibrary;
using Instagramp_2.Service;
using Microsoft.AspNetCore.Mvc;

namespace Instagramp_2.Controllers
{
    public class ProfileController : Controller
    {
        PostDAO repo = new PostDAO();
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult AddPost()
        {
            return View();
        }
        public IActionResult PostSuccess(PostModel post)
        {
            repo.Create(post);
            return View(post);
        }
    }
}
