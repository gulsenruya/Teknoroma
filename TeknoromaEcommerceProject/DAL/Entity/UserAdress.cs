using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entity
{
    public class UserAdress: CoreEntity
    {
        [Required(ErrorMessage = "Ad girilmesi zorunludur")]
        [Display(Name = "Adınız")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad girilmesi zorunludur")]
        [Display(Name = "Soyadınız")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email girilmesi zorunludur")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon girilmesi zorunludur")]
        [Display(Name = "Telefon numaranız")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Üke girilmesi zorunludur")]
        [Display(Name = "Ülke")]
        public string City { get; set; }
        [Required(ErrorMessage = "Şehir girilmesi zorunludur")]
        [Display(Name = "Şehir")]
        public string Town { get; set; }
        [Required(ErrorMessage = "Adres girilmesi zorunludur")]
        [Display(Name = "Adres")]
        public string FullAdress { get; set; }        
        public Guid AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
