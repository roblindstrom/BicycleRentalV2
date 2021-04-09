using BicycleRental.Domain.Entities;
using System.Threading.Tasks;

namespace BicycleRental.Domain.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        public Task<Order> GetByCompositeKeyId(double customerId, double bicycleid); 
    }
}
