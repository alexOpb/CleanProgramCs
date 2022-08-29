using Microsoft.Extensions.DependencyInjection;

namespace CleanProgramCs.Startup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            return services;
        }
    }
}