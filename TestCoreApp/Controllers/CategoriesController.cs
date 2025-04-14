using Microsoft.AspNetCore.Mvc;
using TestCoreApp.Repository.Base;
using TestCoreApp.Models;
namespace TestCoreApp.Controllers
{
    public class CategoriesController : Controller
    {
        public CategoriesController(IRepository<Category> repository) 
        {
            _repository = repository;
        }

        private IRepository<Category> _repository;
        public IActionResult Index()
        {
            return View(_repository.FindAll());
        }
    }
}
