using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class AppointmentRepository : BaseRepository<Appointment>
    {
        public AppointmentRepository(DatabaseContext context) : base(context)
        {
                
        }
    }
}
