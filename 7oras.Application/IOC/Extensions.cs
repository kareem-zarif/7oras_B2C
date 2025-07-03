

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
            services.AddScoped<ICategoryAppService, CategoryAppServic>();

            return services;
        }
    }
}
