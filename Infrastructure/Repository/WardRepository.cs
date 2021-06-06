using Application.Interfaces.Repositoryplication;
using Domain;

namespace Infrastructure.Repository
{
    public class WardRepository : BaseRepository<Ward>, IWardRepository
    {
        public WardRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
