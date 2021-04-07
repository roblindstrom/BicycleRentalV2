using System.Collections.Generic;
using System.Threading.Tasks;

namespace BicycleRental.Domain.Contracts.Persistence
{
    public interface IAsyncRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(double ID);

        Task<IReadOnlyList<TEntity>> ListAllAsync();

        Task<TEntity> AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}
