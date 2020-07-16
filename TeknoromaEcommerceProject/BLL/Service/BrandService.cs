using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Service
{
    public class BrandService : IBrandService
    {
        private readonly AppDbContext context;

        public BrandService(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(Brand brand)
        {
            context.Brands.Add(brand);
            context.SaveChanges();
        }

        public List<Brand> GetActive()
        {
            return context.Brands.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public List<Brand> GetAll()
        {
            return context.Brands.ToList();
        }

        public Brand GetById(Guid id)
        {
            return context.Brands.Find(id); 
        }

        public void Remove(Guid id)
        {
            Brand brand = GetById(id);
            brand.Status = DAL.Entity.Enum.Status.Deleted;
            Update(brand);
        }

        public void Remove(Brand brand)
        {
            brand.Status = DAL.Entity.Enum.Status.Deleted;
            Update(brand);
        }

        public void Update(Brand brand)
        {
            context.Entry(brand).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
