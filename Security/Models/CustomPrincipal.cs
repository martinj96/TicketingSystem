using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SEDC.TicketingSystem.Security.Models
{
    public interface ICustomPrincipal : System.Security.Principal.IPrincipal
    {
        int UserId { get; set; }

        string UserName { get; set; }

        string FirstName { get; set; }
    }
    public class CustomPrincipal : ICustomPrincipal
    {
        private CustomUserManager _userManager = new CustomUserManager();
        private CustomRoleManager _roleManager = new CustomRoleManager();

        public IIdentity Identity { get; private set; }

        public CustomPrincipal(int id, string username, string fName, string lName)
        {
            UserId = id;
            FirstName = fName;
            LastName = lName;
            this.Identity = new GenericIdentity(username);
        }

        public bool IsInRole(string role)
        {
            return Identity != null && Identity.IsAuthenticated &&
               !string.IsNullOrWhiteSpace(role) && _userManager.isInRole(this.UserId, _roleManager.getRoleId(role));
        }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class CustomPrincipalSerializedModel
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}