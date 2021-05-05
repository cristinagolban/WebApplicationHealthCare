using Application.Interfaces.Repository;
using Domain;
using System.Collections.Generic;

namespace Infrastructure.Repository
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(DatabaseContext context) : base(context)
        {
        }


        public Doctor GetDoctor(int id)
        {
            return base.GetById(id);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            throw new System.NotImplementedException();
        }
    }
}
