using Company.data.Context;
using Company.Repositry.Interfaces;
using Company.Repositry.Repositiers;
using Microsoft.EntityFrameworkCore;
using Company.data;
using Microsoft.AspNetCore.Identity;
using Company.Services.Employees;
using Company.Services.Departments_Services;
using Company.Services.Employees.DTO;

namespace Assignment3_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<CompanyDBcontext>(
                option=>option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
                );

            builder.Services.AddScoped<EmployeeInterface, EmployeeRep>();
            builder.Services.AddScoped<IEmployeeService, EmpService>();
            builder.Services.AddScoped<IdepartmentRep, DepRep>();
            builder.Services.AddScoped<ISdepartment, DepartmentServices>();
            builder.Services.AddAutoMapper(x => x.AddProfile(new EmployeeProfile()));
            builder.Services.AddAutoMapper(x => x.AddProfile(new DepartmentProfile()));

            builder.Services.AddIdentity<ApplicationUsers, IdentityRole>(config =>
            {
                config.Password.RequiredUniqueChars = 2;
                config.Password.RequireUppercase = true;
                config.Password.RequireLowercase = true;
                config.Password.RequireDigit = true;
                config.Password.RequireNonAlphanumeric = true;
                config.User.RequireUniqueEmail = true;
                config.Lockout.AllowedForNewUsers = true;
                config.Lockout.MaxFailedAccessAttempts = 3;
                config.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
            }).AddEntityFrameworkStores<CompanyDBcontext>().AddDefaultTokenProviders();
            builder.Services.ConfigureApplicationCookie(options => {
            options.Cookie.HttpOnly=true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                //reset cookie in case user is active
                options.SlidingExpiration = true;
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                //Cross site attack
                options.Cookie.SameSite = SameSiteMode.Strict;
            
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=SignUp}");

            app.Run();
        }
    }
}