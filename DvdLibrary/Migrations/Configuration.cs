namespace DvdLibrary.Migrations
{
    using DvdLibrary.Models.Identity;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DvdLibrary.Models.Identity.DvdLibraryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DvdLibraryDbContext context)
        {
            // Load the user and role managers with our custom models
            var userMgr = new UserManager<AppUser>(new UserStore<AppUser>(context));
            var roleMgr = new RoleManager<AppRole>(new RoleStore<AppRole>(context));

            // have we loaded roles already?
            if (roleMgr.RoleExists("DvdLibraryApp"))
                return;

            // create the admin role
            roleMgr.Create(new AppRole() { Name = "DvdLibraryApp" });

            // create the default user
            var user = new AppUser()
            {
                UserName = "DvdLibraryApp"
            };

            // create the user with the manager class
            userMgr.Create(user, "Testing123!");

            // add the user to the admin role
            userMgr.AddToRole(user.Id, "DvdLibraryApp");
        }
    }
}
