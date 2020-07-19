using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Service
{
    public class OrderService:IOrderService
    {
        private readonly AppDbContext appDbContext;
        public OrderService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void Add(Order order)
        {
            appDbContext.Orders.Add(order);
            appDbContext.SaveChanges();
        }

        public List<Order> GetActive()
        {
            return appDbContext.Orders.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public Order GetById(Guid id)
        {
            return appDbContext.Orders.Find(id);
        }

        public List<OrderDetail> GetOrderDetails(Guid id)
        {
            return appDbContext.OrderDetail.Where(x => x.OrderId == id).ToList();
        }

        public List<Order> GetOrders()
        {
            return appDbContext.Orders.ToList();
        }       

        public void Update(Order order)
        {
            appDbContext.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            appDbContext.SaveChanges();
        }

        
    }
}
