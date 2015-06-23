using SEDC.TicketingSystem.Security.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SEDC.TicketingSystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UsersInRoles> UsersInRoles { get; set; }

        public DbSet<TicketModel> Tickets { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}