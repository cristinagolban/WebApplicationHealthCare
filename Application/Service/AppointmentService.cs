using Application.Interfaces.Service;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class AppointmentService : IAppointmentService
    {
        public IAppointmentRepository _appointmentRepository { get; set; }
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public IEnumerable<Appointment> GetAppointmentsForDoctor(int id)
        {
            return _appointmentRepository.GetWithFilter(appointment => appointment.Doctor.Id == id);
        }
    }
}
