using Microsoft.AspNetCore.Mvc;

namespace EfCoreMigrations.Controllers
{
    public class TripController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
