using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.ViewModel
{
    public class AddressVM
    {
        public List<Shipper> Shippers { get; set; }
        public List<UserAdress> UserAdresses { get; set; }

        
    }
}
