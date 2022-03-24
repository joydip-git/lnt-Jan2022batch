using Finance_Management.DataAccessLayer.DataAccessLayer;
using Finance_Management.DataAccessLayer;
using Finance_Management.DataAccessLayer.Implementation;
using Finance_Management.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance_Management
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FinancedbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IRegistration, RegistrationDao>();
            //services.AddTransient<IProducts, ProductsDao>();
            services.AddTransient<ILoginType, LoginTypeDao>();
            services.AddTransient<IEmiType, EmiTypeDao>();
            services.AddTransient<IEmiTable, EmiTableDao>();
            services.AddTransient<IuserType, UserTypeDao>();
           // services.AddTransient<IPayments, PaymentsDao>();
           // services.AddTransient<IOrders, OrdersDao>();
             
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
