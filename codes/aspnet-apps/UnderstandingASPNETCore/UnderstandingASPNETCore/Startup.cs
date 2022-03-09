using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingASPNETCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //minimal services for basic MVC web application
            //do not provide support for authorization, validation etc.
            //services.AddMvcCore();

            //to create any type of MVC application, such as view based application, web api type application etc. practically all MVC related services are registered
            //services.AddMvc();

            //to create non-mvc type, page based application
            //here pages are requsted and reponse is sent
            //services.AddRazorPages();

            //to create MVC appliaction without View (V). basically we use thos to create Web API type application
            //here in this application the actions return everything possible, except a view. this is used for webapplications, which wants to return some data to front-end application with design, such as ASp.NET Core MVC web application with View, Angular, React JS etc. front end applications
            //services.AddControllers();

            //to create MVC application with support for controller, routing, view etc.
            //here actions of controllers are requested, which might return HTML (View) or even migt return something else (Json, Rediection, string etc.) as response
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //this line registers EndpointRoutingMiddleware, if you need endpoint routing in your application
            app.UseRouting();
            /*
             * if the client makes the following requests. the routes are created: 
             * localhost:1000/Home/Index => (Route: controller:Home, action:Index, id:null)
             * localhost:1000/Home/Get/100 => (Route: controller:Home, action:Get, id:"100")
             * localhost:1000/Home/GetAll => (Route: controller:Home, action:GetAll, id:null)
             */

            //this registers a EndpointMiddleware in the middleware pipeline
            //this middleware registration is possible when you have registered the EndpointRoutingMiddleware (the previous line is mandatory)
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("home", "{controller}/{action}/{id?}", new { controller = "Home", action = "Index" });
            });
        }
    }
}
