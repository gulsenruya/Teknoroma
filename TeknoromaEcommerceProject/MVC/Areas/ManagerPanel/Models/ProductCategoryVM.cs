using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.ManagerPanel.Models
{
    public class ProductCategoryVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
