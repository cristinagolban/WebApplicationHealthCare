using AppliApplication.Interfaces.Repositorycation;
using Domain;

namespace Infrastructure.Repository
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
