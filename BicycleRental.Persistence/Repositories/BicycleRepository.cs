using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;

namespace BicycleRental.Persistence.Repositories
{
    public class BicycleRepository : BaseRepository<Bicycle>, IBicycleRepository
    {
        public BicycleRepository(BicycleRentalDbContext bicycleRentalDbContext) : base(bicycleRentalDbContext)
        {

        }

    }
}
