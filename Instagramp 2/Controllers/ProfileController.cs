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

            return View(repo.GetAll());
        }
        public IActionResult UploadImage()
        {
            return View("Upload");
        }

        public IActionResult PostSuccess(PostModel post)
        {
            repo.Create(post);
            return View("Index", repo.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> ProcessUpload(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                ModelState.AddModelError("", "Please select a file to upload.");
                return View();
            }

            var fileName = Path.GetFileName(file.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            ViewBag.Message = "File uploaded successfully.";
            ViewBag.FilePath = $"/uploads/{fileName}";

            return View("AddPost");
        }

        public IActionResult AddPost()
        {
            return View();
        }
    }
}
