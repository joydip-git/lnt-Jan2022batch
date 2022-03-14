using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PMSApp.RESTfulApiServer.Models;
using PMSApp.RESTfulApiServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace PMSApp.RESTfulApiServer
{
    public class Startup
    {
        //ASP.NET core first creates an object of configuration class and then passes the reference of that object to the StartUp class constructor (dependency injection of Configuration class object into Startup class object)
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
            Console.WriteLine("Start up object created...");
        }

        //this read-only property will return the reference of the Configuration object that has been dependency injected in the Startup class
        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            Console.WriteLine("services created here....");
            //services.AddTransient<IProductDaoImpl, ProductDaoImpl>();
            //services.AddScoped<IProductDaoImpl, ProductDaoImpl>();
            var conStr = this.Configuration.GetConnectionString("ProductsDbConStr");
            //services.AddDbContext<ProductsDbContext>(ServiceLifetime.Singleton);
            Action<DbContextOptionsBuilder> action = (DbContextOptionsBuilder builder) => builder.UseSqlServer(conStr);
            services.AddDbContext<ProductsDbContext>(action, ServiceLifetime.Singleton);
            services.AddSingleton<IProductDaoImpl, ProductDaoImpl>();
            services.AddCors();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Console.WriteLine("middlewares getting registered...");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(
                policyBuilder =>
                policyBuilder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
