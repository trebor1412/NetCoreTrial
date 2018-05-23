using NetCore.Core;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace NetCore.NorthWind.Service
{
    public class TypeRegistrar : ITypeRegistrar
    {
        public int Order => 20;
        public void RegisterTypes(IServiceCollection services){
            services.AddAutoMapper();
            services.AddScoped<IOrderService, OrderService>();
        }
    }
}