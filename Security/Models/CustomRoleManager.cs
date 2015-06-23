using SEDC.TicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDC.TicketingSystem.Security.Models
{
    public class CustomRoleManager
    {
        public CustomRoleManager()
        {

        }
        ApplicationDbContext _db = new ApplicationDbContext();
        public void CreateRole(Role role)
        {
            _db.Roles.Add(role);
            _db.SaveChanges();
        }
        public int getRoleId(string role)
        {
            return _db.Roles.FirstOrDefault(r => r.Name == role).RoleId;
        }

    }
}