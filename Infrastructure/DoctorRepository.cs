using Domain;

namespace Infrastructure
{
    public class DoctorRepository : BaseRepository<Doctor>
    {
        public DoctorRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
