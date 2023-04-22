using ClassLibrary;
using Instagramp_2.Models;
using Instagramp_2.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Instagramp_2.Controllers
{
    public class SearchController : Controller
    {
        PostDAO postDAO = new PostDAO();
        List<PostModel> posts = new List<PostModel>();
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
            posts = postDAO.GetAll().Where(p => p.Category == "0").ToList();
            return View(posts);
        }
        public IActionResult Friends()
        {
            posts = postDAO.GetAll().Where(p => p.Category == "1").ToList();
            return View(posts);
        }

        public IActionResult Nature()
        {
            posts = postDAO.GetAll().Where(p => p.Category == "2").ToList();
            return View(posts);
        }

        public IActionResult Sports()
        {
            posts = postDAO.GetAll().Where(p => p.Category == "3").ToList();
            return View(posts);
        }

        public IActionResult Food()
        {
            posts = postDAO.GetAll().Where(p => p.Category == "4").ToList();
            return View(posts);
        }

        public IActionResult Other()
        {
            posts = postDAO.GetAll().Where(p => p.Category == "5").ToList();
            return View(posts);
        }
    }
}
