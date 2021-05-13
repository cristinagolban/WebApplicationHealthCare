using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class DoctorAsistentRepository : BaseRepository<DoctorAsistent>
    {
        public DoctorAsistentRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
