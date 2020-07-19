using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Service
{
    public class UserAdressService:IUserAdressService
    {
        private readonly AppDbContext context;
        public UserAdressService(AppDbContext context)
        {
            this.context = context;
        }       
        public void Add(UserAdress userAdress)
        {
            context.UserAdresses.Add(userAdress);
            context.SaveChanges();
        }

        public List<UserAdress> GetActive()
        {
            return context.UserAdresses.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public UserAdress GetAdress(Guid id)
        {
            return context.UserAdresses.Where(x => x.AppUserId == id).FirstOrDefault();
        }

        public List<UserAdress> GetAll()
        {
            return context.UserAdresses.ToList();
        }

        public UserAdress GetById(Guid id)
        {
            return context.UserAdresses.Find(id);
        }

        public List<UserAdress> GetByIdUser(Guid id)
        {
            return context.UserAdresses.Where(x => x.AppUserId == id && x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public void Remove(Guid id)
        {
            UserAdress userAdress = GetById(id);
            userAdress.Status = DAL.Entity.Enum.Status.Deleted;
            Update(userAdress);
        }

        public void Remove(UserAdress userAdress)
        {
            userAdress.Status = DAL.Entity.Enum.Status.Deleted;
            Update(userAdress);
        }

        public UserAdress SetAdress(Guid id)
        {
            var userAdress = GetById(id);
            List<UserAdress> userAdresses = GetByIdUser(userAdress.AppUserId);
            foreach (var item in userAdresses)
            {
                item.setAdresses = userAdresses;
            }
            return userAdress;
        }

        public void Update(UserAdress userAdress)
        {
            context.Entry(userAdress).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
