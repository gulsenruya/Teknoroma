using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC.Areas.ManagerPanel.Controllers
{
    [Area("ManagerPanel")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        // GET: Category
        public ActionResult Index()
        {
            return View(categoryService.GetActive());
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            ViewBag.MainCategories = categoryService.GetActive()
                .Select(x => new SelectListItem() { Text = x.CategoryName, Value = x.ID.ToString() });
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {

                categoryService.Add(category);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();

            }
        }
            // GET: Category/Edit/5
            public ActionResult Edit(Guid id)
            {
                ViewBag.MainCategories = categoryService.GetActive()
                    .Select(x => new SelectListItem() { Text = x.CategoryName, Value = x.ID.ToString() });
                return View(categoryService.GetById(id));
            }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            try
            {
                categoryService.Update(category);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(categoryService.GetById(id));
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Category category)
        {
           
                categoryService.Remove(category);

                return RedirectToAction(nameof(Index));
            
           
        }
    }
}