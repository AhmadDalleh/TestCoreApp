﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestCoreApp.Models;
using TestCoreApp.Repository.Base;

namespace TestCoreApp.Controllers
{
    [Authorize(Roles = clsRoles.roleAdmin)]
    public class CategoriesController : Controller
    {
        public CategoriesController(IUnitOfWork _myUnit)
        {
            //_repository = repository;
            myUnit = _myUnit;
        }

        //private IRepository<Category> _repository;
        private readonly IUnitOfWork myUnit;

        //public IActionResult Index()
        //{
        //    return View(_repository.FindAll());
        //}

        public async Task<IActionResult> Index()
        {
            var oneCat = myUnit.categories.SelectOne(x => x.Name == "Computers");

            var allCat = await myUnit.categories.FindAllAsync("Items");

            return View(allCat);
        }


        //GET
        public IActionResult New()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.ClientFile != null)
                {
                    MemoryStream stream = new MemoryStream();
                    category.ClientFile.CopyTo(stream);
                    category.DbImage= stream.ToArray();
                }
                myUnit.categories.AddOne(category);
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
        }

        //GET
        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var category = myUnit.categories.FindById(Id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                myUnit.categories.UpdateOne(category);
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
        }

        //GET
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var category = myUnit.categories.FindById(Id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Category category)
        {
            myUnit.categories.DeleteOne(category);
            TempData["successData"] = "category has been deleted successfully";
            return RedirectToAction("Index");
        }
    }
}