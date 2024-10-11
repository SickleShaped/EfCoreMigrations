using Microsoft.AspNetCore.Mvc;

namespace EfCoreMigrations.Controllers
{
    public class PassengerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
