using DAL.Entity;
using MVC.Models.CartModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.ViewModel
{
    public class AddressVM
    {

        public List<CartItem> cartItems { get; set; }
        public List<Shipper> Shippers { get; set; }
        public List<UserAdress> UserAdresses { get; set; }

        
    }
}
