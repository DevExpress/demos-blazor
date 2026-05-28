using Microsoft.AspNetCore.Identity;

namespace BlazorDemo.CRM.Data {
    public class DemoData(
            ApplicationDbContext dbContext,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager) {

        public static readonly string UserEmail = "admin@dxmail.com";
        public static readonly string UserPassword = "1qaz!QAZ";

        public async Task InitAsync() {
            dbContext.Database.EnsureCreated();

            var email = UserEmail;
            var user = new ApplicationUser {
                UserName = email,
                Email = email,
                EmailConfirmed = true,
                LockoutEnabled = true,
            };
            await userManager.CreateAsync(user, UserPassword);

            var role = await roleManager.FindByNameAsync("Admin");
            if(role == null)
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            await userManager.AddToRoleAsync(user, "Admin");
        }
    }
}
