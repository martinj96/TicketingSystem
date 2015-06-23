using SEDC.TicketingSystem.Models;
using SEDC.TicketingSystem.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;

namespace SEDC.TicketingSystem.Security
{
    public class Manager
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        private CustomUserManager _userManager = new CustomUserManager();
        private CustomRoleManager _roleManager = new CustomRoleManager();

        public Manager()
        {

        }
        public bool Login(string username, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.UserName == username);
            if (user == null || !Crypto.VerifyHashedPassword(user.Password, password))
                return false;
            return true;
        }
        public bool CreateUser(User newUser)
        {
            var user = _db.Users.FirstOrDefault(u => u.UserName == newUser.UserName);
            if (user != null)
                return false;
            _userManager.CreateUser(newUser);
            return true;
        }
        public bool CreateRole(Role newRole)
        {
            var role = _db.Roles.FirstOrDefault(r => r.Name == newRole.Name);
            if (role != null)
                return false;
            _roleManager.CreateRole(newRole);
            return true;
        }
        public bool addRoleToUser(string roleName, string userName)
        {
            int? roleId = _roleManager.getRoleId(roleName);
            int? userId = _userManager.getUserId(userName);

            if(roleId != null && userId != null
                && _db.UsersInRoles.FirstOrDefault(uir => uir.RoleId == roleId && uir.UserId == userId) == null)
            {
                _userManager.addRoleToUser((int)userId, (int)roleId);
                return true;
            }
            return false;
        }
    }
}