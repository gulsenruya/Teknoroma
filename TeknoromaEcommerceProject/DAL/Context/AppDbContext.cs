using DAL.Entity;
using DAL.Entity.Base;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace DAL.Context
{
    public class AppDbContext:IdentityDbContext<AppUser,AppUserRole,Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet <UserAdress> UserAdresses { get; set; }
        public override int SaveChanges()
        {
            var modifiedEntiries = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified || x.State == EntityState.Added).ToList();

            string identity = WindowsIdentity.GetCurrent().Name;
            string computerName = Environment.MachineName;
            DateTime dateTime = DateTime.Now;
            //Todo: AppUser bağlanacak.
            string user = "admin";
            string ip = DAL.Entity.Base.CoreEntity.GetHostName();

            foreach (var item in modifiedEntiries)
            {
                CoreEntity coreEntity = item.Entity as CoreEntity;
                if (item != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        coreEntity.CreatedAdUserName = identity;
                        coreEntity.CreatedComputerName = computerName;
                        coreEntity.CreatedDate = dateTime;
                        coreEntity.CreatedIP = ip;
                        coreEntity.CreatedBy = user;
                    }
                    else if (item.State == EntityState.Modified)
                    {
                        coreEntity.ModifiedAdUserName = identity;
                        coreEntity.ModifiedComputerName = computerName;
                        coreEntity.ModifiedDate = dateTime;
                        coreEntity.ModifiedIP = ip;
                        coreEntity.ModifiedBy = user;
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}
