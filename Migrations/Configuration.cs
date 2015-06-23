namespace SEDC.TicketingSystem.Migrations
{
    using SEDC.TicketingSystem.Security;
    using SEDC.TicketingSystem.Security.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Helpers;

    internal sealed class Configuration : DbMigrationsConfiguration<SEDC.TicketingSystem.Models.ApplicationDbContext>
    {
        private Manager _manager = new Manager();
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SEDC.TicketingSystem.Models.ApplicationDbContext context)
        {
            User nUser = new User("admin", "afName", "alName", Crypto.HashPassword("password"));
            _manager.CreateUser(nUser);
            nUser = new User("user", "ufName", "ulName", Crypto.HashPassword("password"));
            _manager.CreateUser(nUser);
            Role nRole = new Role("Admin");
            _manager.CreateRole(nRole);
            _manager.addRoleToUser("Admin", "admin");
        }
    }
}
