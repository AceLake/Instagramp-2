using Instagramp_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Instagramp_2.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            List<SearchTermModel> searchTerms = new List<SearchTermModel>();

            searchTerms.Add(new SearchTermModel("Family", "See posts about family!", "img/familypic.jpg"));
            searchTerms.Add(new SearchTermModel("Friends", "See posts about friends!", "img/friendspic.jpg"));
            searchTerms.Add(new SearchTermModel("Nature", "See posts about nature!", "img/naturepic.jpg"));
            searchTerms.Add(new SearchTermModel("Sports", "See posts about sports!", "img/sportspic.jpg"));
            searchTerms.Add(new SearchTermModel("Food", "See posts about food!", "img/foodpic.jpg"));
            searchTerms.Add(new SearchTermModel("Other", "See posts about all other topics!", "img/otherpic.jpg"));

            return View(searchTerms);
        }
    }
}
