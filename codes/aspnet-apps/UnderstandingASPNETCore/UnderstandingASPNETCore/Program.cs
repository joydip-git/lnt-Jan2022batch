using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingASPNETCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hostBuilder = CreateHostBuilder(args);
            IHost host = hostBuilder.Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            IHostBuilder genericHostBuilder = Host.CreateDefaultBuilder(args);
            genericHostBuilder = genericHostBuilder.ConfigureWebHostDefaults(
                webBuilder =>
               {
                   webBuilder.UseStartup<Startup>();
               });
            return genericHostBuilder;
        }
    }
}
