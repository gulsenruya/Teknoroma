using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        List<Brand> GetAll();
        List<Brand> GetActive();
        Brand GetById(Guid id);
        void Update(Brand brand);
        void Remove(Guid id);
        void Remove(Brand brand);
    }
}
