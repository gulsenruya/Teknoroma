using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Areas.ManagerPanel.Models;

namespace MVC.Areas.ManagerPanel.Controllers
{
    [Area("ManagerPanel")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IUserAdressService userAdressService;
        private readonly IProductService productService;
        public OrderController(IOrderService orderService,IUserAdressService userAdressService,IProductService productService)
        {
            this.orderService = orderService;
            this.userAdressService = userAdressService;
            this.productService = productService;
        }
        // GET: Order
        public ActionResult Index()
        {
            return View(orderService.GetActive());
        }

        // GET: Order/Details/5
        public ActionResult Details(Guid id)
        {
            OrderVM orderVM = new OrderVM();
            orderVM.Order = orderService.GetById(id);
            orderVM.OrderDetails = orderService.GetOrderDetails(id);
            orderVM.UserAdress = userAdressService.GetById(orderVM.Order.ID);
            foreach (var item in orderVM.OrderDetails)
            {
                var products = productService.GetById(item.ProductId);
                item.Products = products;
            }
            return View(orderVM);
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}