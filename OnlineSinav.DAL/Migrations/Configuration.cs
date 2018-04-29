namespace OnlineSinav.DAL.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineSinav.DAL.Concrete.EntityFramework.OnlineSinavDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OnlineSinav.DAL.Concrete.EntityFramework.OnlineSinavDbContext context)
        {
            UserRole role = new UserRole()
            {
                Role = "Admin",
                IsActive = true
            };
            context.UserRoles.Add(role);

            role = new UserRole()
            {
                IsActive = true,
                Role = "User"
            };
            context.UserRoles.Add(role);
            context.SaveChanges();

            role = context.UserRoles.FirstOrDefault(a => a.Role == "Admin");

            User u = new User()
            {
                Email = "ccaliskan@mail.com",
                IsActive = true,
                Name = "Cemal",
                SurName = "Çalýþkan",
                Password = "1234",
                UserRole = role,
                UserRoleID = role.UserRoleID
            };
            context.Users.Add(u);
            context.SaveChanges();
        }
    }
}
