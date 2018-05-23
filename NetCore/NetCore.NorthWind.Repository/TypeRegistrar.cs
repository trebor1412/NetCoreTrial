using NetCore.Core;
using Microsoft.Extensions.DependencyInjection;

namespace NetCore.NorthWind.Repository
{
    public class TypeRegistrar : ITypeRegistrar
    {
        public int Order => 10;
        public void RegisterTypes(IServiceCollection services){

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}