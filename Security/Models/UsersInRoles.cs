using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SEDC.TicketingSystem.Security.Models
{
    public class UsersInRoles
    {
        public UsersInRoles()
        {

        }
        public UsersInRoles(int uId,int rId)
        {
            UserId = uId;
            RoleId = rId;
        }
        [Key]
        [Column(Order = 1)] 
        public int UserId { get; set; }
        [Key]
        [Column(Order = 2)] 
        public int RoleId { get; set; }
    }
}