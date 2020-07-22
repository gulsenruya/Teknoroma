using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface  IProductService
    {
        string ContentRootPath { get; }

        void Add(Product product);
        void Add(List<Product> products);
        void Update(Product Product);
        void Remove(Product Product);
        void Remove(Guid id);
        void RemoveAll(Expression<Func<Product, bool>> exp);
        Product GetById(Guid id);
        Product GetByDefault(Expression<Func<Product, bool>> exp);
        List<Product> GetActive();
        List<Product> GetDefault(Expression<Func<Product, bool>> exp);
        List<Product> GetAll();
        bool Any(Expression<Func<Product, bool>> exp);
    }
}
