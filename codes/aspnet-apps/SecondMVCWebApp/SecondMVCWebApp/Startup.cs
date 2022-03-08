using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondMVCWebApp
{
    public class Startup
    {
        //this method is called when the web host is being created
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        //this method is called after the web host is created and starts running
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline. (what are the middlewares to be used, register here with the request-response/middleware pipleine)
        //The middleware pipeline is represented by the interface IApplicationBuilder
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //Action<IEndpointRouteBuilder> endpointConfigDel =
            //    (IEndpointRouteBuilder endpointBuilder) => endpointBuilder.MapDefaultControllerRoute();
            ////{ controller = Home,action = Index,id = null}

            Action<IEndpointRouteBuilder> endpointConfigDel =
               (IEndpointRouteBuilder endpointBuilder) =>
               endpointBuilder.MapControllerRoute("default", "{controller}/{action}/{id?}", new { controller = "Home", action = "SayHi" });

            //{ path:'/home/:id'}

            app.UseEndpoints(endpointConfigDel);

            //app.UseEndpoints();
        }
}
    //class MVCMIDDLEWARE
    //{
    //    public void Invoke() { }
    //}
}
