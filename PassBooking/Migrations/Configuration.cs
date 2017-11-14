namespace PassBooking.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using PassBooking.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PassBooking.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Identity.Models.ApplicationDbContext";
        }

        protected override void Seed(PassBooking.Models.ApplicationDbContext context)
        {

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

          
            var adminUser = context.Users.FirstOrDefault(u => u.Email == "admin@Gymbokning.se");
            adminUser.FirstName = "Admin";
            adminUser.LastName = "Adminsson";
            adminUser.TimeOfRegistration = DateTime.Parse("2016-09-07 07:25:48");
            var result = userManager.Update(adminUser);


            var eva = context.Users.FirstOrDefault(u => u.Email == "eva@eva.se");
            eva.FirstName = "Eva";
            eva.LastName = "Evadottir";
            eva.TimeOfRegistration = DateTime.Parse("2017-03-23 21:10:25");
            result = userManager.Update(eva);

            var anna = context.Users.FirstOrDefault(u => u.Email == "anna@mail.se");
            anna.FirstName = "Anna";
            anna.LastName = "Annaström";
            anna.TimeOfRegistration = DateTime.Parse("2016-12-13 15:10:00");
            result = userManager.Update(anna);





            //var roleStore = new RoleStore<IdentityRole>(context);
            //var roleManager = new RoleManager<IdentityRole>(roleStore);

            //var roleNames = new [] { "Admin" };

            //foreach (var roleName in roleNames)
            //{
            //    if (context.Roles.Any(r => r.Name == roleName)) continue;

            //    var role = new IdentityRole { Name = roleName };
            //    var result = roleManager.Create(role);
            //    if (!result.Succeeded)
            //    {
            //        throw new Exception(string.Join("\n", result.Errors));
            //    }
            //}

            //var userStore = new UserStore<ApplicationUser>(context);
            //var userManager = new UserManager<ApplicationUser>(userStore);

            //var emails = new[] { "admin@Gymbokning.se", "eva@eva.se", "anna@mail.se" };

            //foreach (var email  in emails)
            //{
            //    if (context.Users.Any(u => u.UserName == email)) continue;

            //    var user = new ApplicationUser { UserName = email, Email = email, FirstName="Admin", LastName="Adminsson", TimeOfRegistration=DateTime.Parse("2016-02-10 08:00:00") };
            //    var result = userManager.Create(user, "password");

            //    if (!result.Succeeded)
            //    {
            //        throw new Exception(string.Join("\n", result.Errors));
            //    }
            //}

            //var adminUser = userManager.FindByName("admin@Gymbokning.se");
            //userManager.AddToRole(adminUser.Id, "Admin");

        }
    }
}
