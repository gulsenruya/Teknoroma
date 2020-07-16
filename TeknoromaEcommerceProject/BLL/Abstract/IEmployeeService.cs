using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        void Add(List<Employee> employees);
        void Update(Employee employee);
        void Remove(Employee employee);
        void Remove(Guid id);
        void RemoveAll(Expression<Func<Employee, bool>> exp);
        Employee GetById(Guid id);
        Employee GetByDefault(Expression<Func<Employee, bool>> exp);
        List<Employee> GetActive();
        List<Employee> GetDefault(Expression<Func<Employee, bool>> exp);
        List<Employee> GetAll();
        bool Any(Expression<Func<Employee, bool>> exp);
    }
}
