using NetCore.Core;
using Microsoft.Extensions.DependencyInjection;

namespace NetCore.NorthWind.Service
{
    public class TypeRegistrar : ITypeRegistrar
    {
        public int Order => 20;
        public void RegisterTypes(IServiceCollection services){
            services.AddScoped<IOrderService, OrderService>();
        }
    }
}