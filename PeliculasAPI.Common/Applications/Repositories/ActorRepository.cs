using PeliculasAPI.Common.Applications.Interfaces;
using PeliculasAPI.Common.DataBase;
using PeliculasAPI.Common.Entities;

namespace PeliculasAPI.Common.Applications.Repositories
{
    public class ActorRepository  : GenericRepository<Actor>, IActorRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ActorRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
