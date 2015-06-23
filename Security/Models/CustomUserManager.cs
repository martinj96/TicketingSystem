using SEDC.TicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDC.TicketingSystem.Security.Models
{
    public class CustomUserManager
    {
        public CustomUserManager()
        {

        }
        ApplicationDbContext _db = new ApplicationDbContext();
        public void CreateUser(User user){
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        public void addRoleToUser(int uId, int rId){
            var entity = new UsersInRoles(uId, rId);
            _db.UsersInRoles.Add(entity);
            _db.SaveChanges();
        }
        public int getUserId(string user)
        {
            return _db.Users.FirstOrDefault(u => u.UserName == user).UserId;
        }
        public bool isInRole(int uId,int rId)
        {
            var userRoles = _db.UsersInRoles.Where(u => u.UserId == uId).Select(u => u.RoleId).ToList();
            foreach (var role in userRoles)
            {
                if (role == rId)
                    return true;
            }
            return false;
        }
    }
}