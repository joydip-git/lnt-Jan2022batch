using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;

namespace ProductsMVCApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            Action<IEndpointRouteBuilder> endpointBuilderAction = (endpointBuilder) =>
            {    
                endpointBuilder.MapControllerRoute(
                        "Default",
                        "{controller}/{action}/{arg?}",
                        new { controller = "Products", action = "Index" }
                    );
            };
            app.UseEndpoints(endpointBuilderAction);
        }
    }
}
