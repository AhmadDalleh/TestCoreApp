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

        //GET
        public IActionResult New(){

        return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(Item item)
        {
            if (item.Name == "100")
            {
                ModelState.AddModelError("Name", "Name can't equal 100");
            }
            if (ModelState.IsValid)
            {
                _context.Items.Add(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(item);
            }
        }
        //GET
        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var item = _context.Items.Find(Id);
            if (item == null)
            {
                return NotFound();
            }

            return View();
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Item item)
        {
            if (item.Name == "100")
            {
                ModelState.AddModelError("Name", "Name can't equal 100");
            }
            if (ModelState.IsValid)
            {
                _context.Items.Update(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(item);
            }
        }



    }
}
