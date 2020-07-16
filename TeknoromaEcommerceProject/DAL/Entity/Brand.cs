using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entity
{
    public class Brand:CoreEntity
    {
        [Required(ErrorMessage = "Marka adı alanı zorunludur!")]        
        [Display(Name = "Marka Adı")]
        public string BrandName { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}
