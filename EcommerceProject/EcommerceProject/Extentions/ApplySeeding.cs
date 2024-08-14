using Data.Context;
using Data.Entities.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Repositories;

namespace EcommerceProject.Extentions
{
    public static class ApplySeeding
    {
        public static async Task ApplySeedingAsync(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                var logger = loggerFactory.CreateLogger<AppDbContext>();

                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    var userManager = services.GetRequiredService<UserManager<AppUser>>();
                    var roleManager = services.GetRequiredService<RoleManager<AppRole>>();
                    logger.LogInformation("Applying migrations...");

                    logger.LogInformation("Seeding users...");
                    await AddIdentityContextSeed.SeedUserAsync(userManager, roleManager);
                    logger.LogInformation("User seeding completed.");
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred during seeding");
                }
            }
        }
    }
}
