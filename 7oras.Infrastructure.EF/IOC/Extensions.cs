using _7oras.Domain.Interfaces;
using _7oras.Infrastructure.EF.Data;
using _7oras.Infrastructure.EF.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _7oras.Infrastructure.EF.IOC
{
    public static class Extensions
    {
        public static IServiceCollection ConfigEF(this IServiceCollection services, IConfiguration config)
        {
            var connString = config.GetConnectionString("DefaultConn");

            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(connString);
            });

            services.AddScoped(typeof(IBaseRepo<>), typeof(BaseRepo<>));//resolve and inject all repo automatically when create dbcontext
            services.AddScoped<IUOW, UOW>();

            return services;
        }
    }
}
