using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace NetCore.Core {
    public static class IServiceCollectionExtension {
        public static void RegisterTypes (this IServiceCollection services) {
            var registrars =
             Assembly.GetEntryAssembly ()
                     .GetReferencedAssemblies ()
                     .Select (x => Assembly.Load (x))
                     .SelectMany (x => x.DefinedTypes)
                     .Where (x => typeof (ITypeRegistrar).GetTypeInfo ().IsAssignableFrom (x.AsType ()))
                     .Where (x => x.IsInterface == false)
                     .Select (p => (ITypeRegistrar) Activator.CreateInstance (p))
                     .OrderBy (p => p.Order);

            foreach (var registrar in registrars) {
                registrar.RegisterTypes(services);
            }
        }
    }
}