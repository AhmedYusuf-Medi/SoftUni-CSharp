namespace BMR.Web
{
    using BMR.Data;
    using BMR.Data.Common;
    using BMR.Data.Seeding;
    using BMR.Service.Contracts;
    using BMR.Service.Services.Data;

    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    using System;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(o =>
                    {
                       o.Cookie.Name = "auth_cookie";
                       o.SlidingExpiration = true;
                       o.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                    });

            services.AddDbContext<BMRDbContext>(options =>
            options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));

            //Data repositories
            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            //Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBMRService, BMRService>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<IMacroService, MacroService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<BMRDbContext>();

                if (!env.IsDevelopment())
                {
                    dbContext.Database.Migrate();
                }

                new BMRDbContextSeeder()
                    .SeedAsync(dbContext, serviceScope.ServiceProvider)
                    .GetAwaiter()
                    .GetResult();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseStatusCodePagesWithReExecute("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}