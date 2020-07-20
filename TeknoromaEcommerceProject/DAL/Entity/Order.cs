using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class Order : CoreEntity
    {
        public Order()
        {
            //siparişi tamamla dedikten sonra oluşacak olan order detay
            OrderDetails = new List<OrderDetail>();
        }
        public Guid AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Confirmed { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public Guid ShipperId { get; set; }
        public virtual Shipper  Shipper{ get; set; }
        public Guid UserAdressId { get; set; }
        public virtual UserAdress UserAdress { get; set; }

    }
}