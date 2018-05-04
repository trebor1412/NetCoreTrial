using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace NetCore.NorthWind.Web {
    public class Program {
        public static void Main (string[] args) {
            BuildWebHost (args).Run ();
        }

        public static IWebHost BuildWebHost (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .ConfigureAppConfiguration ((hostContext, config) => {
                var env = hostContext.HostingEnvironment;
                config.SetBasePath (Path.Combine (env.ContentRootPath, "Configuration"))
                      .AddJsonFile (path: "settings.json", optional : false, reloadOnChange : true);
            })
            .UseStartup<Startup> ()
            .Build ();
    }
}