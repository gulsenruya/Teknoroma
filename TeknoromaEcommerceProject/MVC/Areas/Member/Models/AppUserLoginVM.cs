using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Member.Models
{
    public class AppUserLoginVM
    {        
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre boş olamaz!")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
