using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class Shipper:CoreEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        
    }
}
