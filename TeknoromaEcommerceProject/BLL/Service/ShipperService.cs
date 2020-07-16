using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Service
{
    public class ShipperService:IShipperService
    {
        private readonly AppDbContext context;
        public ShipperService(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(Shipper shipper)
        {
            context.Shippers.Add(shipper);
            context.SaveChanges();
        }

        public List<Shipper> GetActive()
        {
            return context.Shippers.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public List<Shipper> GetAll()
        {
            return context.Shippers.ToList();
        }

        public Shipper GetById(Guid id)
        {
            return context.Shippers.Find(id);
        }
        public void Remove(Shipper shipper)
        {
            shipper.Status = DAL.Entity.Enum.Status.Deleted;
            Update(shipper);
        }
        public void Remove(Guid id)
        {
            Shipper shipper = GetById(id);
            shipper.Status = DAL.Entity.Enum.Status.Deleted;
            Update(shipper);

        }

        public void Update(Shipper shipper)
        {
            context.Entry(shipper).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

        }
    }
}
