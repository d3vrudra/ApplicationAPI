using ApplicationAPI.Data;
using ApplicationAPI.Interfaces;
using ApplicationAPI.Services;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ApplicationAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {

            services.AddScoped<ITokenService, TokenService>();

            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;

        }
    }
}
