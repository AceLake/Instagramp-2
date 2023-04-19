using ClassLibrary;
using Instagramp_2.Models;
using Instagramp_2.Service;
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
            var postDAO = new PostDAO();

            var posts = postDAO.GetAll().Where(p => p.Category.Contains("family")).ToList();
            return View(posts);
        }
        public IActionResult Friends()
        {
            var postDAO = new PostDAO();

            var posts = postDAO.GetAll().Where(p => p.Category.Contains("friends")).ToList();
            return View(posts);
        }

        public IActionResult Nature()
        {
            var postDAO = new PostDAO();

            var posts = postDAO.GetAll().Where(p => p.Category.Contains("nature")).ToList();
            return View(posts);
        }

        public IActionResult Sports()
        {
            var postDAO = new PostDAO();

            var posts = postDAO.GetAll().Where(p => p.Category.Contains("sports")).ToList();
            return View(posts);
        }

        public IActionResult Food()
        {
            var postDAO = new PostDAO();

            var posts = postDAO.GetAll().Where(p => p.Category.Contains("food")).ToList();
            return View(posts);
        }

        public IActionResult Other()
        {
            var postDAO = new PostDAO();

            var posts = postDAO.GetAll().Where(p => p.Category.Contains("other")).ToList();
            return View(posts);
        }
    }
}
