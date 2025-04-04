using Microsoft.AspNetCore.Mvc;
using TestCoreApp.Data;
using TestCoreApp.Models;

namespace TestCoreApp.Controllers
{
    public class ItemsController : Controller
    {
        public ItemsController(ApplicationDbContext context)
        {
            _context = context;
        }
        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            IEnumerable<Item> itemsList = _context.Items.ToList();
            return View(itemsList);
        }
        public IActionResult New() { 

        return View();
        }
    }
}
