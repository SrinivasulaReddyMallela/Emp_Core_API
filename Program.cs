using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // To load dlls.
                    var p = System.Reflection.Assembly.GetEntryAssembly().Location;
                    p = p.Substring(0, p.LastIndexOf(@"\") + 1);
                    webBuilder.UseSetting(WebHostDefaults.SuppressStatusMessagesKey, "True");
                    webBuilder.UseContentRoot(p);
                    webBuilder.UseStartup<Startup>();
                })
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                var env = hostingContext.HostingEnvironment;
                config.AddJsonFile("appsettings.json", true, true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json",
                        true, true);

                config.AddEnvironmentVariables();
            });
    }
}
