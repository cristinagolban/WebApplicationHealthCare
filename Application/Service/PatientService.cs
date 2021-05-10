using Application.Interfaces.Service;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class PatientService : IPatientService
    {
        public IPatientService _patientRepository { get; set; }
        public IAppointmentService _appointmentRepository { get; set; }


        public PatientService(IPatientService patientRepository, IAppointmentService appointmentRepository)
        {
            _patientRepository = patientRepository;
            _appointmentRepository = appointmentRepository;
        }

        public async Task<IEnumerable<Appointment>> GetAllAppointmentForPatient(int id)
        {
            return await _appointmentRepository.GetWithFilter(appointment => appointment.Patient.Id == id);

        }
    }
}
