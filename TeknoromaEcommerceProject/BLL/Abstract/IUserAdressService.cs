﻿using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
    public interface IUserAdressService
    {
        void Add(UserAdress userAdress);
        List<UserAdress> GetAll();
        List<UserAdress> GetActive();
        UserAdress GetById(Guid id);
        void Update(UserAdress userAdress);
        void Remove(Guid id);
        void Remove(UserAdress userAdress);
    }
}