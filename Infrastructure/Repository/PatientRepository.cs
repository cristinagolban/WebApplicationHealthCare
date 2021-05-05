using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class PatientRepository : BaseRepository<Patient>
    {
        public PatientRepository(DatabaseContext context ) : base(context)
        {

        }
    }
}
