using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Common.Applications.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int id);

        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> ExistAsync(int id);
        Task<bool> SaveAllAsync();
    }
}
