using Microsoft.EntityFrameworkCore;
using PeliculasAPI.Common.Applications.Interfaces;
using PeliculasAPI.Common.DataBase;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Common.Applications.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IId
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IQueryable<T> GetAll()
        {
            return _applicationDbContext.Set<T>().AsNoTracking();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _applicationDbContext.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _applicationDbContext.Set<T>().AddAsync(entity);
            await SaveAllAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _applicationDbContext.Set<T>().Update(entity);
            await SaveAllAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _applicationDbContext.Set<T>().Remove(entity);
            await SaveAllAsync();
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _applicationDbContext.Set<T>().AnyAsync(e => e.Id == id);

        }

        public async Task<bool> SaveAllAsync()
        {
            return await _applicationDbContext.SaveChangesAsync() > 0;
        }
    }
}
