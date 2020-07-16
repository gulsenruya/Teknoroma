using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Service
{
    public class SupplierService : ISupplierService
    {
        private readonly AppDbContext context;
        public SupplierService (AppDbContext context)
        {
            this.context = context;
        }
        public void Add(Supplier supplier)
        {
            context.Suppliers.Add(supplier);
            context.SaveChanges();
        }

        public List<Supplier> GetActive()
        {
            return context.Suppliers.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public List<Supplier> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public Supplier GetById(Guid id)
        {
            return context.Suppliers.Find(id);
        }
        public void Remove(Supplier supplier)
        {
            supplier.Status = DAL.Entity.Enum.Status.Deleted;
            Update(supplier);
        }
        public void Remove(Guid id)
        {
            Supplier supplier = GetById(id);
            supplier.Status = DAL.Entity.Enum.Status.Deleted;
            Update(supplier);

        }

        public void Update(Supplier supplier)
        {
            context.Entry(supplier).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

        }
    }
}
