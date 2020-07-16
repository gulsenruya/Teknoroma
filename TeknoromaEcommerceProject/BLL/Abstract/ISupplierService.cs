using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
    public interface ISupplierService
    {
        void Add(Supplier supplier);
        List<Supplier> GetAll();
        List<Supplier> GetActive(); 
        Supplier GetById(Guid id);
        void Update(Supplier supplier);       
        void Remove(Guid id);
        void Remove(Supplier supplier);
    }
}
