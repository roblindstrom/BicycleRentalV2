using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;

namespace BicycleRental.Persistence.Repositories
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(BicycleRentalDbContext bicycleRentalDbContext) : base(bicycleRentalDbContext)
        {

        }
    }
}
