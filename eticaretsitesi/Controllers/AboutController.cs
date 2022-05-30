using Microsoft.AspNetCore.Mvc;

namespace eticaretsitesi.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}