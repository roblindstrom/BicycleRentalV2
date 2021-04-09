using BicycleRental.Domain.Contracts.Persistence;
using BicycleRental.Domain.Entities;
using System.Threading.Tasks;

namespace BicycleRental.Persistence.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        protected new readonly BicycleRentalDbContext _bicycleRentalDbContext;
        public OrderRepository(BicycleRentalDbContext bicycleRentalDbContext) : base(bicycleRentalDbContext)
        {
            _bicycleRentalDbContext = bicycleRentalDbContext;
        }


        public async Task<Order> GetByCompositeKeyId(double customerId, double bicycleid)
        {
            return await _bicycleRentalDbContext.Set<Order>().FindAsync(bicycleid, customerId);
        }
    }
}
