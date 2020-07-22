using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Areas.ManagerPanel.Models;
using Microsoft.AspNetCore.Hosting;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using MVC.Reports;
using SelectPdf;

namespace MVC.Areas.ManagerPanel.Controllers
{
    [Area("ManagerPanel")]
    public class ProductController : Controller
    {
        
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly ISupplierService supplierService;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ProductController(IProductService productService, ICategoryService categoryService, ISupplierService supplierService, IWebHostEnvironment hostingEnvironment)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.supplierService = supplierService;
            _hostingEnvironment = hostingEnvironment;
        }
        // GET: Product
        public ActionResult Index()
        {
            ProductCategoryVM productCategoryVM = new ProductCategoryVM();
            productCategoryVM.Products = productService.GetActive();
            productCategoryVM.Categories = categoryService.GetActive();
            return View(productCategoryVM);
        }
       public IActionResult GeneratePdf(string html)
        {
            html = html.Replace("StrTag", "<").Replace("EndTag", ">");
            HtmlToPdf oHtmlToPdf = new HtmlToPdf();
            SelectPdf.PdfDocument oPdfDocument = oHtmlToPdf.ConvertHtmlString(html);
            byte[] pdf = oPdfDocument.Save();
            oPdfDocument.Close();
            return File(
                pdf,
                "application/pdf",
                "ProductList.pdf"
                );

        }
        public IActionResult Pdf(Product product)
        {
            ProductCategoryVM productCategoryVM = new ProductCategoryVM();
            productCategoryVM.Products = productService.GetActive();
          
           
            ProductReport productReport = new ProductReport(_hostingEnvironment);
            return File(productReport.Report(productCategoryVM.Products), "application/pdf");

            
            //HtmlToPdfConverter converter = new HtmlToPdfConverter();
            //WebKitConverterSettings settings = new WebKitConverterSettings();
            //settings.WebKitPath = Path.Combine(_hostingEnvironment.ContentRootPath, "QtBinariesWindows");
            //converter.ConverterSettings = settings;
            //PdfDocument document = converter.Convert("http://localhost:44347/ManagerPanel/Product/product");
            //MemoryStream memory = new MemoryStream();
            //document.Save(memory);

            //return File(memory.ToArray(), System.Net.Mime.MediaTypeNames.Application.Pdf, "Output.pdf");
            
        }
        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.MainCategories = categoryService.GetActive().Select(x => new SelectListItem() { Text = x.CategoryName, Value = x.ID.ToString() });
            ViewBag.Suppliers = supplierService.GetActive().Select(x => new SelectListItem() { Text = x.CompanyName, Value = x.ID.ToString() });
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product,IFormFile image)
        {
            try
            {
                string path;
                if (image == null)
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", "nologo.png");
                    product.ImagePath = "nologo.png";
                }
                else
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", image.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                    product.ImagePath = image.FileName;
                }
                productService.Add(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.MainCategories = categoryService.GetActive().Select(x => new SelectListItem() { Text = x.CategoryName, Value = x.ID.ToString() });
            ViewBag.Suppliers = supplierService.GetActive()
               .Select(x => new SelectListItem() { Text = x.CompanyName, Value = x.ID.ToString() });
            return View(productService.GetById(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Product product, IFormFile image)
        {
            try
            {
                string path;
                if (image == null)
                {
                    if (product.ImagePath != null)
                    {
                        productService.Update(product);
                        return RedirectToAction(nameof(Index));
                    }
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", "nologo.png");
                    product.ImagePath = "nologo.png";
                }
                else
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", image.FileName);
                    using (var stream=new FileStream(path, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                    product.ImagePath = image.FileName;
                }
                productService.Update(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id != null)
            {
                return View(productService.GetById(id));
            }
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Product product)
        {
            productService.Remove(product);
            return RedirectToAction("Index");
        }
    }
}