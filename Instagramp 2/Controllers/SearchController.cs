using Instagramp_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Instagramp_2.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            List<SearchTermModel> searchTerms = new List<SearchTermModel>();

            searchTerms.Add(new SearchTermModel("Family", "See posts about family!", "img/familypic.jpg", "Family", "Search"));
            searchTerms.Add(new SearchTermModel("Friends", "See posts about friends!", "img/dawgsoutpic.jpg", "Friends", "Search"));
            searchTerms.Add(new SearchTermModel("Nature", "See posts about nature!", "img/naturepic.jpg", "Nature", "Search"));
            searchTerms.Add(new SearchTermModel("Sports", "See posts about sports!", "img/sportspic.jpg", "Sports", "Search"));
            searchTerms.Add(new SearchTermModel("Food", "See posts about food!", "img/foodpic.jpg", "Food", "Search"));
            searchTerms.Add(new SearchTermModel("Other", "See posts about all other topics!", "img/otherpic.jpg", "Other", "Search"));

            return View(searchTerms);
        }

        public IActionResult Family()
        {
            return View("Family");
        }
        public IActionResult Friends()
        {
            return View("Friends");
        }

        public IActionResult Nature()
        {
            return View("Nature");
        }

        public IActionResult Sports()
        {
            return View("Sports");
        }

        public IActionResult Food()
        {
            return View("Food");
        }

        public IActionResult Other()
        {
            return View("Other");
        }
    }
}
