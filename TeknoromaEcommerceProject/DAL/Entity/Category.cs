using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entity
{
    public class Category:CoreEntity
    {

        [Required(ErrorMessage = "Kategori adı alanı zorunludur!")]   
        [Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Ana Kategori")]
        public Guid? MainCategory { get; set; }
    }
}
