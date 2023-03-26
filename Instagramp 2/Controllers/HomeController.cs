using Microsoft.AspNetCore.Mvc;
using ClassLibrary;

namespace Instagramp_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<PostModel> posts = new List<PostModel>();
            posts.Add(new PostModel("sadjaw7as8da6sd", "https://hips.hearstapps.com/hmg-prod/images/alpe-di-siusi-sunrise-with-sassolungo-or-langkofel-royalty-free-image-1623254127.jpg", "Mountain Vilage", "This weekend we went up to the Antiolan mountain range near Antelago Columbia"));
            posts.Add(new PostModel("sadjaw7as8da7sd", "https://hips.hearstapps.com/hmg-prod/images/ama-dablam-mountain-peak-view-from-chola-pass-royalty-free-image-1623254695.jpg", "Card title", "Some quick example text to build on the card title and make up the bulk of the card's"));
            posts.Add(new PostModel("sadjaw7as8da8sd", "https://www.travelmanagers.com.au/wp-content/uploads/2012/08/AdobeStock_254529936_Railroad-to-Denali-National-Park-Alaska_750x500.jpg", "Card title", "Some quick example text to build on the card title and make up the bulk of the card's"));
            return View(posts);
        }
    }
}
