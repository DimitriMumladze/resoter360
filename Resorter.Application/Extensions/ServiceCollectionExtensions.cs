using Microsoft.Extensions.DependencyInjection;

namespace Resorter.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var applicationAssembly = typeof(ServiceCollectionExtensions).Assembly;          
        }
    }
}