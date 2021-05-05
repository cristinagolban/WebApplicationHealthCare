using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(DatabaseContext context) : base(context)
        {
                
        }

        public void AddAppointment()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetWithFilter(Func<Appointment, bool> predicateFilter)
        {
            throw new NotImplementedException();
        }
    }
}
