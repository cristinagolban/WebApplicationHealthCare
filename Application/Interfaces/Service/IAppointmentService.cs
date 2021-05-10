using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Service
{
    public interface IAppointmentService
    {
        Task DeleteById(int id);
        Task<IEnumerable<Appointment>> GetAppointmentsForDoctor(int id);

        Task<IEnumerable<Appointment>> GetAppointmentsForPatient(int id);

        public Task<IEnumerable<Appointment>> GetWithFilter(Func<Appointment, bool> predicateFilter)
        {
            throw new NotImplementedException();
        }

    }
}
