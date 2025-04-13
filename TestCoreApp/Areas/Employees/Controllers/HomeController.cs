using Microsoft.AspNetCore.Mvc;

namespace TestCoreApp.Areas.Employees.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
