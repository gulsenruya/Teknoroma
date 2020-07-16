using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModel;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index(Guid id)
        {
            ProductVM productVM = new ProductVM()
            {
                Product = productService.GetById(id)
            };
            ViewBag.ProductID = id;
            return View(productVM);
        }
        public IActionResult AllProducts(Guid id)
        {
            return View(productService.GetActive());
        }
    }
}