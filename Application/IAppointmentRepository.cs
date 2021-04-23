using Domain;
using System.Collections.Generic;

namespace Application
{
    public interface IAppointmentRepository
    {
        IEnumerable<Appointment> GetAppointments();

        Appointment GetAppointment(int Id);

        void AddAppointment();
    }
}
