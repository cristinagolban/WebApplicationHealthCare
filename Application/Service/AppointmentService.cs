using Application.Interfaces.Repositoryplication;
using Application.Interfaces.Service;
using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Service
{
    public class AppointmentService : IAppointmentService
    {
        public IAppointmentRepository _appointmentRepository { get; set; }
        public  AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public async Task<IEnumerable<Appointment>> GetAppointmentsForDoctor(int id)
        {
             return await _appointmentRepository.GetWithFilter(appointment => appointment.Doctor.Id == id);

        }

        public async Task DeleteById(int id)
        {
            _appointmentRepository = (IAppointmentRepository)_appointmentRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsForPatient(int id)
        {
            return await _appointmentRepository.GetWithFilter(appointment => appointment.Patient.Id == id);
        }
    }
}
