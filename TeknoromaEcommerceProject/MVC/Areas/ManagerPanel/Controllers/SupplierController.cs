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
    public class SupplierController : Controller
    {
        private readonly ISupplierService supplierService;
        // GET: Supplier
        public SupplierController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }
        public ActionResult Index()
        {
            return View(supplierService.GetActive());
        }

        // GET: Supplier/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Supplier/Create
        public ActionResult Create()
        {
            ViewBag.MainCategories = supplierService.GetActive()
               .Select(x => new SelectListItem() { Text = x.CompanyName, Value = x.ID.ToString() });
            return View();
        }

        // POST: Supplier/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Supplier supplier)
        {
            try
            {
                supplierService.Add(supplier);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.MainCategories = supplierService.GetActive()
                   .Select(x => new SelectListItem() { Text = x.CompanyName, Value = x.ID.ToString() });
            return View(supplierService.GetById(id));
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Supplier supplier)
        {
            try
            {
                supplierService.Update(supplier);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(supplierService.GetById(id));
        }

        // POST: Supplier/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Supplier supplier)
        {
            try
            {
                supplierService.Remove(supplier);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}