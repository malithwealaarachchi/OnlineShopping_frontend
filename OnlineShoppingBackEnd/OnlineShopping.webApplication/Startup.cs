using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineShopping.Common.Interfaces;
using OnlineShopping.Business.AccountBusiness;
using OnlineShopping.Data;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using OnlineShopping.Data.Entities;
using OnlineShopping.Common.BusinessInterfaces;
using OnlineShopping.Business.ProductBusiness;

namespace OnlineShopping.webApplication
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        private readonly IConfiguration _config;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
             services.AddCors(options =>
             {
                 options.AddPolicy(MyAllowSpecificOrigins,
                                   builder =>
                                   {
                                       builder.WithOrigins("http://localhost:44302",
                                                           "http://localhost:4200")
                                                           .AllowAnyHeader()
                                                           .AllowAnyMethod();
                                   });
             });

            //ConfigureDatabase(services);
            services.AddControllers();
                 
            services.AddDbContextPool<OnlineshoppingContext>(Options => Options.UseSqlServer(_config.GetConnectionString("OnlineShoppingDBConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<OnlineshoppingContext>();

           
            services.AddScoped<ILoginBusiness, LoginBusiness>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductsBusiness, ProductsBusiness>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }           

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            
            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthentication();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
       // protected virtual void ConfigureDatabase(IServiceCollection services)
       // {
            //if (_currentEnvironment.IsEnvironment("Test"))
            //{
            //    return;
            //}

            //if (_currentEnvironment.IsDevelopment() && Configuration.GetValue<bool>("UseInMemoryDataBase"))
            //{
            //    services.AddDbContext<ChallengesContext>(c => c.UseInMemoryDatabase("Vinnovate"));
            //}
            //else
            
                //services.AddDbContext<OnlineshoppingContext>(c =>

                //c.UseSqlServer(_config.GetConnectionString("OnlineShoppingDBConnection")));
            
        //}
    }
}
