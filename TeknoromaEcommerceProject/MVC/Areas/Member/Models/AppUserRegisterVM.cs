using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.Member.Models
{
    public class AppUserRegisterVM
    {
        
        [Required(ErrorMessage = "Kullanıcı adı girilmesi zorunlu!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email girilmesi zorunlu!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre girilmesi zorunlu!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı boş olamaz!")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor lütfen şifreleri kontrol ediniz!")]
        public string ConfirmPassword { get; set; }
    }
}
