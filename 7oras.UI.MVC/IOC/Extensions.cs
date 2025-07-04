namespace _7oras.UI.MVC.IOC
{
    public static class Extensions
    {
        public static IServiceCollection ConfigMVC(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddMaps(AppDomain.CurrentDomain.GetAssemblies()));

            return services;
        }
    }
}
