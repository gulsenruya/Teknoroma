using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entity
{
    public class Supplier:CoreEntity
    {
        [Required(ErrorMessage = "Tedarikçi adı alanı zorunludur!")] 
        [Display(Name = "Tedarikçi Adı")]
        public string CompanyName { get; set; }
        [Display(Name = "Açıklama")]        
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
