namespace _7oras.Application.IOC
{
    public static class Extensions
    {
        public static IServiceCollection ConfigAppAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddMaps(AppDomain.CurrentDomain.GetAssemblies()));

            return services;
        }

        public static IServiceCollection ConfigAppFluentValidation(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<CategoryAppCreateDtoValidator>();

            // This will register ALL validators in the assembly containing CategoryAppCreateDtoValidator

            services.AddValidatorsFromAssemblyContaining<CategoryAppCreateDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<CategoryAppUpdateDtoValidator>();
            return services;
        }
        public static IServiceCollection ConfigAppServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryAppService, CategoryAppServic>();
            services.AddScoped<ISubCategoryAppService, SubCategoryAppService>();

            return services;
        }
    }
}
