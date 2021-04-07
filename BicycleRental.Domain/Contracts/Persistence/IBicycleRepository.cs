using BicycleRental.Domain.Entities;

namespace BicycleRental.Domain.Contracts.Persistence
{
    public interface IBicycleRepository : IAsyncRepository<Bicycle>
    {
    }
}
