using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Persistence;
using BicycleRental.Persistence.Repositories;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Reflection;

namespace BicycleRental.Application
{
    public static class ApplicationServiceRegistration
    {
        
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddPersistenceServices(configuration);

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));


            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IBicycleRepository, BicycleRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}
