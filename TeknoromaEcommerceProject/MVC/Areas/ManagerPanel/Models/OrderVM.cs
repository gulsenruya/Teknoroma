using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Areas.ManagerPanel.Models
{
    public class OrderVM
    {
        public Order Order { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public UserAdress  UserAdress { get; set; }
    }
}
