using Microsoft.AspNetCore.Mvc;

namespace eticaretsitesi.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}