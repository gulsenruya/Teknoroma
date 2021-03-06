﻿using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
    public interface IOrderService
    {
        void Add(Order order);
        List<Order> GetOrders();
        List<Order> GetActive();
        List<Order> GetByIdUser(Guid id);
        void Update(Order order);
        Order GetById(Guid id);
        List<OrderDetail> GetOrderDetails(Guid id);
        
        void Delete(Guid id);

    }
}
