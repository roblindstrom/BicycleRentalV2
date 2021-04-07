using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BicycleRental.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BicycleRentalDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BicycleRentalConnectionString")));



            return services;
        }
    }
}
