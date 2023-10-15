using Microsoft.AspNetCore.Mvc;

namespace ITI_DOO.Controllers
{
    public class DownloadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
