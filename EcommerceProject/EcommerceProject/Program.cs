using Data.Context;
using Data.Entities.IdentityEntities;
using EcommerceProject.Extentions;
using EcommerceProject.Middlewares;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProject
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddIdentity<AppUser, AppRole>()
             .AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            builder.Services.AddAplicationServices();
            builder.Services.AddIdentityServices(builder.Configuration);
            builder.Services.AddSwaggerDocumentation();
            var app = builder.Build();
            await ApplySeeding.ApplySeedingAsync(app);

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseMiddleware<ExceptionMiddleware>();

            app.UseHttpsRedirection();
            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            await app.RunAsync();
        }
    }
}
