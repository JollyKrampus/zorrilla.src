using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace zorrilla.admin.Data
{
    public static class ZorrillaDbInitializer
    {
        public static void InitializeDevelopment(ZorrillaDbContext context, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();

            // Ensure admin role exists.
            var adminRoleName = "Admin";
            if (!roleManager.RoleExistsAsync(adminRoleName).Result)
                roleManager.CreateAsync(new IdentityRole(adminRoleName));

            // Ensure admin user exists and is in admin role.
            var adminUser = userManager.FindByNameAsync("admin").Result;
            if (adminUser == null)
            {
                adminUser = new IdentityUser { UserName = "admin", EmailConfirmed = true };
                var result = userManager.CreateAsync(adminUser, "Admin123!").Result;
                if (result.Succeeded) userManager.AddToRoleAsync(adminUser, adminRoleName);
            }

            // Look for any clients.
            if (!context.Clients.Any())
            {
                var clients = new[]
                {
                    new()
                    {
                        Name = "Client1", Description = "First Client", Address = "Address 1", Phone = "1111111111"
                    },
                    new Client
                    {
                        Name = "Client2", Description = "Second Client", Address = "Address 2", Phone = "2222222222"
                    }
                    // add more clients here...
                };

                foreach (var c in clients) context.Clients.Add(c);
            }

            context.SaveChanges();
        }
    }
}