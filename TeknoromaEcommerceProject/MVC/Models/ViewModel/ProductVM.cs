using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.ViewModel
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
