using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create host builder
            IHostBuilder hostBuilder = CreateHostBuilder(args);

            //now create the web host using the builder object
            IHost webHost = hostBuilder.Build();

            //now run the created web host, which will be able to host the any type of web application
            webHost.Run();
        }
        //public static void ConfigureHost(IWebHostBuilder builder)
        //{
        //    //UserStartup<T>();
        //    builder.UseStartup<Startup>();
        //}
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            //creating a default builder object
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);

            //reconfiguring the builder object
            //to this function you should pass an object of Action<IWebHostBuilder> containing the logic for configuration of web host
            //the function returns the re-configured host builder

            //delegate void Action<in T>(T obj);
            //delegate void Action<IWebHostBuilder>(IWebHostBuilder obj);
            //Action<int> printDel = (int num) => Console.WriteLine(num);
            //printDel(12);

            //1. when you have pre-defined function
            //Action<IWebHostBuilder> webBuilderDel = new Action<IWebHostBuilder>(Program.ConfigureHost);

            //2.a. when you do not have pre-defined function and create an anonymous method
            //Action<IWebHostBuilder> webBuilderDel = delegate (IWebHostBuilder builder)
            //{
            //    builder.UseStartup<Startup>();
            //};

            //2.b. when you do not have pre-defined function and create an anonymous method using Lambda expression
            //Action<IWebHostBuilder> webBuilderDel= (IWebHostBuilder builder)=> builder.UseStartup<Startup>();
            //hostBuilder = hostBuilder.ConfigureWebHostDefaults(webBuilderDel);


            //hostBuilder = hostBuilder.ConfigureWebHostDefaults((IWebHostBuilder builder) => builder.UseStartup<Startup>());
            hostBuilder = hostBuilder.ConfigureWebHostDefaults((builder) => builder.UseStartup<Startup>());

            return hostBuilder;
        }
    }
}
