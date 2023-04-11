using Instagramp_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Instagramp_2.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            List<SearchTermModel> searchTerms = new List<SearchTermModel>();

            searchTerms.Add(new SearchTermModel("Family", "See posts about family!", "https://upload.wikimedia.org/wikipedia/commons/d/df/Family_Portrait.jpg"));
            searchTerms.Add(new SearchTermModel("Friends", "See posts about friends!", "friendspic.jpg"));
            searchTerms.Add(new SearchTermModel("Nature", "See posts about nature!", "naturepic.jpg"));
            searchTerms.Add(new SearchTermModel("Sports", "See posts about sports!", "sportspic.jpg"));
            searchTerms.Add(new SearchTermModel("Food", "See posts about food!", "foodpic.jpg"));
            searchTerms.Add(new SearchTermModel("Other", "See posts about other!", "otherpic.jpg"));

            return View(searchTerms);
        }
    }
}
