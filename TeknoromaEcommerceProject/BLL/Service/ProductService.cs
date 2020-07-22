using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Service
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext context;

        public string ContentRootPath => throw new NotImplementedException();

        //Context
        public ProductService(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Add(List<Product> products)
        {
            context.Products.AddRange(products);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<Product, bool>> exp)
        {
            return context.Products.Any(exp);
        }

        public List<Product> GetActive()
        {
            return context.Products.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public Product GetByDefault(Expression<Func<Product, bool>> exp)
        {
            return context.Products.FirstOrDefault(exp);
        }

        public Product GetById(Guid id)
        {
            return context.Products.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<Product> GetDefault(Expression<Func<Product, bool>> exp)
        {
            return context.Products.Where(exp).ToList();
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public void Remove(Product Product)
        {
            Product.Status = DAL.Entity.Enum.Status.Deleted;
            Update(Product);
        }

        public void Remove(Guid id)
        {
            Product Product = GetById(id);
            Product.Status = DAL.Entity.Enum.Status.Deleted;
            Update(Product);
        }

        public void RemoveAll(Expression<Func<Product, bool>> exp)
        {
            foreach (var item in GetDefault(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(Product Product)
        {

            context.Entry(Product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
