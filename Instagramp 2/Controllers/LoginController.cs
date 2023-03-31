using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Service;

namespace RegisterAndLoginApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel user)
        {
            SecurityService securityService = new SecurityService();

            if (securityService.IsValid(user))
            {
                return View("LoginSuccess", user);
            }
            else
            {
                return View("LoginFailure", user);
            }
        }

        public IActionResult ProcessRegister(UserModel user)
        {
            return View();
        }

        public IActionResult RegisterResults(UserModel user)
        {
            //validation is handled on the html, so there is no use for a check here
            //when saving to database is added there will need to be a check here to check if the 
            //databse has gotten the registration
            return View("RegisterSuccess", user);
            
        }
    }
}
