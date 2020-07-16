using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        public CategoryController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }
        
        public IActionResult ListProductsOfCategory(Guid id)
        {
            var category = categoryService.GetById(id);
            if (category.MainCategory == null)
            {
                List<Category> categories = categoryService.GetDefault(x => x.MainCategory == category.ID);
                List<Product> products = new List<Product>();
                foreach (var item in categories)
                {
                    products.AddRange(productService.GetDefault(p => p.CategoryId == item.ID));
                }
                return View(products);
            }
            else
            {
                var products =productService.GetDefault(x => x.CategoryId == category.ID);
                return View(products);
            }
           
        }

    }
}