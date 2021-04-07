using BicycleRental.Domain.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleRental.Persistence.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly BicycleRentalDbContext _bicycleRentalDbContext;

        public BaseRepository(BicycleRentalDbContext dbContext)
        {
            _bicycleRentalDbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(double id)
        {
            return await _bicycleRentalDbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _bicycleRentalDbContext.Set<T>().ToListAsync();
        }

        public async virtual Task<IReadOnlyList<T>> GetPagedReponseAsync(int page, int size)
        {
            return await _bicycleRentalDbContext.Set<T>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _bicycleRentalDbContext.Set<T>().AddAsync(entity);
            await _bicycleRentalDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _bicycleRentalDbContext.Entry(entity).State = EntityState.Modified;
            await _bicycleRentalDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _bicycleRentalDbContext.Set<T>().Remove(entity);
            await _bicycleRentalDbContext.SaveChangesAsync();
        }
    }
}
