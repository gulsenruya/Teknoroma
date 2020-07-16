using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.ManagerPanel.Models
{
    public class AppUserVM
    {
        [Required(ErrorMessage = "Kullanıcı adı girilmesi zorunlu!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email girilmesi zorunlu!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre girilmesi zorunlu!")]
        public string Password { get; set; }

    }
}
