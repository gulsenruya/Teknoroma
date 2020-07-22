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
        private readonly ICategoryService categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
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
            ProductVM productVM = new ProductVM();
            productVM.Products = productService.GetActive();
            productVM.Categories = categoryService.GetActive();
            
            return View(productVM);
        }
        //public IActionResult ProductOfCategories(Guid id)
        ////{
        ////    ProductVM productVM = new ProductVM();
        ////    productVM.Categories = categoryService.GetCategories(id);

        ////    foreach (var item in productVM.Categories)
        ////    {
        ////        var products = productService.GetById(item.ID);
        ////        item. = products;
        ////    }
        ////    return View(productVM.Category);

        //}
    }
}