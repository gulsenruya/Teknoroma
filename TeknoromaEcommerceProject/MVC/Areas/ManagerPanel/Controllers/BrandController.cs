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
    public class BrandController : Controller
    {
        // GET: Brand
        private readonly IBrandService brandService;
        public BrandController(IBrandService brandService)
        {           
            this.brandService = brandService;
        }
        public ActionResult Index()
        {
            return View(brandService.GetActive());
        }

        // GET: Brand/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Brand/Create
        public ActionResult Create()
        {
            ViewBag.Brand = brandService.GetActive()
              .Select(x => new SelectListItem() { Text = x.BrandName, Value = x.ID.ToString() });
            return View();
        }

        // POST: Brand/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand brand)
        {
            try
            {
                brandService.Add(brand);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Brand/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.Brand = brandService.GetActive()
                    .Select(x => new SelectListItem() { Text = x.BrandName, Value = x.ID.ToString() });
            return View(brandService.GetById(id));
        }

        // POST: Brand/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Brand brand)
        {
            try
            {
                brandService.Update(brand);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Brand/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(brandService.GetById(id));
        }

        // POST: Brand/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Brand brand)
        {
            try
            {
                brandService.Remove(brand);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}