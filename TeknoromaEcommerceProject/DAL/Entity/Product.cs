using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entity
{
    public class Product:CoreEntity
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public string ProductName { get; set; } 
        public string Description { get; set; }
        public short? UnitsInStock { get; set; }
        public short Quantity { get; set; }
        public string ImagePath { get; set; }        
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public Guid? SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public Guid? BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
