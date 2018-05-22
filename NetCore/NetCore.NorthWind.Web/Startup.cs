using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.NorthWind.Repository;
using NetCore.NorthWind.Service;
using Elmah.Io.AspNetCore;

namespace NetCore.NorthWind.Web {
    public class Startup {
        private readonly IConfiguration _config;

        public Startup (IConfiguration config) {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices (IServiceCollection services) {
            services.AddMvc ();
            services.AddDbContext<NorthWindContext> (options => {
                options.UseSqlServer (_config.GetConnectionString ("NorthWind"));
            });
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderService>();

            services.AddElmahIo(o =>{
                o.ApiKey = "2f73f2df9f5c4c1781998307d74588ec";
                o.LogId = new Guid("978f31cb-3f82-43f0-be37-50ff0c4c3e6e");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }
            app.UseElmahIo();
            app.UseMvcWithDefaultRoute ();
            app.UseStaticFiles ();            
        }
    }
}