using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Service
{
    public interface IAppointmentService
    {
        IEnumerable<Appointment> GetAppointmentsForDoctor(int id);
    }
}
