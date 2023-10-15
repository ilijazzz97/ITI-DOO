using Microsoft.AspNetCore.Mvc;

namespace ITI_DOO.Controllers
{
    public class SoftverController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
