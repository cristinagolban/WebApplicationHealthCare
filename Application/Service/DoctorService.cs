using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class DoctorService : IDoctorService
    {
        public IDoctorRepository _doctorRepository { get; set; }
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public void GetAllAvailableDoctors()
        {
            // TODO some logic here
            _doctorRepository.GetAll();
        }
    }
}
