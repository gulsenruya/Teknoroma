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
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext context;
        public EmployeeService(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void Add(List<Employee> employees)
        {
            context.Employees.AddRange(employees);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<Employee, bool>> exp)
        {
            return context.Employees.Any(exp);
        }

        public List<Employee> GetActive()
        {
            return context.Employees.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee GetByDefault(Expression<Func<Employee, bool>> exp)
        {
            return context.Employees.FirstOrDefault(exp);
        }

        public Employee GetById(Guid id)
        {
            return context.Employees.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<Employee> GetDefault(Expression<Func<Employee, bool>> exp)
        {
            return context.Employees.Where(exp).ToList();
        }

        public void Remove(Employee employee)
        {
            employee.Status = DAL.Entity.Enum.Status.Deleted;
            Update(employee);
        }

        public void Remove(Guid id)
        {
            Employee employee = GetById(id);
            employee.Status = DAL.Entity.Enum.Status.Deleted;
            Update(employee);
        }

        public void RemoveAll(Expression<Func<Employee, bool>> exp)
        {
            foreach (var item in GetDefault(exp))
            {
                item.Status = DAL.Entity.Enum.Status.Deleted;
                Update(item);
            }
        }

        public void Update(Employee employee)
        {
            context.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
