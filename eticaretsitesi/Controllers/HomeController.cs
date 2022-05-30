using Microsoft.AspNetCore.Mvc;

namespace eticaretsitesi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}