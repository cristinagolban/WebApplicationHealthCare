using ApApplication.Interfaces.Repositoryplication;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class PatientRepository : BaseRepository<Patient> , IPatientRepository
    {
        public PatientRepository(DatabaseContext context ) : base(context)
        {

        }
    }
}
