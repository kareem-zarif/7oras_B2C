using _7oras.Infrastructure.EF.Data;
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

            //add scoped //repo ,UOW

            return services;
        }
    }
}
