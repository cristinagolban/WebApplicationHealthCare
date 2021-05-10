using AppliApplication.Interfaces.Repositorycation;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class DoctorService : IDoctorService
    {
        public IDoctorRepository _doctorRepository { get; set; }
        public IAppointmentRepository _appointmentRepository { get; set; }


        public DoctorService(IDoctorRepository doctorRepository, IAppointmentRepository appointmentRepository)
        {
            _doctorRepository = doctorRepository;
            _appointmentRepository = appointmentRepository;
        }
        public  async Task<IEnumerable<Doctor>> GetAllAvaibleDoctors()
        {
             return await _doctorRepository.GetAll();
        }
    }
}
