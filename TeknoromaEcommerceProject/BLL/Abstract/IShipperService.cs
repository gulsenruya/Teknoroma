using DAL.Entity;
using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
    public interface IShipperService
    {
        void Add(Shipper shipper);
        List<Shipper> GetAll();
        List<Shipper> GetActive();
        Shipper GetById(Guid id);
        void Update(Shipper shipper);
        void Remove(Guid id);
        void Remove(Shipper shipper);
    }
}
