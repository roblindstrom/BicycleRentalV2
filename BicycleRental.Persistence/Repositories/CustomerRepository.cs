using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using System.Threading.Tasks;

namespace BicycleRental.Persistence.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        
        public CustomerRepository(BicycleRentalDbContext bicycleRentalDbContext) : base(bicycleRentalDbContext)
        {
            
        }

        

    }
}
