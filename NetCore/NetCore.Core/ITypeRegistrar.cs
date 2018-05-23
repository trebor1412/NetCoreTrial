using Microsoft.Extensions.DependencyInjection;

namespace NetCore.Core
{
    public interface ITypeRegistrar
    {
        int Order { get; }

        void RegisterTypes(IServiceCollection services);
    }
}