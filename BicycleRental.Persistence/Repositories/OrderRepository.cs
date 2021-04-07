using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;

namespace BicycleRental.Persistence.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(BicycleRentalDbContext bicycleRentalDbContext) : base(bicycleRentalDbContext)
        {

        }


    }
}
