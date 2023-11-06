using Microsoft.AspNetCore.Mvc;

namespace MusicApplication.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
