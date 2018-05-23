using System;
using System.Threading.Tasks;
using Elmah.Io.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.Core;
using NetCore.NorthWind.Repository;

namespace NetCore.NorthWind.Web {
    public class Startup {
        private readonly IConfiguration _config;

        public Startup (IConfiguration config) {
            _config = config;
        }

        public void ConfigureServices (IServiceCollection services) {
            services.AddMvc ();
            services.AddDbContext<NorthWindContext> (options => {
                options.UseSqlServer (_config.GetConnectionString ("NorthWind"));
            });

            services.RegisterTypes ();
            services.AddElmahIo (o => {
                o.ApiKey = "2f73f2df9f5c4c1781998307d74588ec";
                o.LogId = new Guid ("978f31cb-3f82-43f0-be37-50ff0c4c3e6e");
            });
        }

        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }
            app.UseElmahIo ();
            app.UseMvcWithDefaultRoute ();
            app.UseStaticFiles ();
        }
    }
}