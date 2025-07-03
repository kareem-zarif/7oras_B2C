using Microsoft.Extensions.DependencyInjection;

namespace _7oras.Application.IOC
{
    public static class Extensions
    {
        public static IServiceCollection ConfigAppAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddMaps(AppDomain.CurrentDomain.GetAssemblies()));

            return services;
        }

        public static IServiceCollection ConfigAppServices(this IServiceCollection services)
        {
            // services.AddScoped<ICategoryService,CategoryService>

            return services;
        }
    }
}
