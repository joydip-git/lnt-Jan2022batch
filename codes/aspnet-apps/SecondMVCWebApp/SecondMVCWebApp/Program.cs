using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondMVCWebApp
{
    //interface IA
    //{
    //    void M1();
    //}
    //abstract class A : IA
    //{
    //    public void M2() { Console.WriteLine("M2"); }
    //    public abstract void M1();
    //}
    //class B : IA
    //{
    //    public void M1() { Console.WriteLine("M1"); }
    //}
    public class Program
    {
        public static void Main(string[] args)
        {
            //A obj = new A();
            //obj.M1();

            //1. create a default builder
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);

            //2. configuring the host builder by supplying the web host configuration
            Action<IWebHostBuilder> configure = (builder) =>
            {
                builder
                 .UseStartup<Startup>();

            };
            hostBuilder = hostBuilder.ConfigureWebHostDefaults(configure);

            //3. createing the web host
            IHost webHost = hostBuilder.Build();

            //4. start running the web host, so that it can now host a web application
            webHost.Run();
        }
        /*
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        */
    }
}
