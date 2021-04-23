using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetDoctors();

        Doctor GetDoctor(int Id);

        List<Appointment> GetAppointments(int Id);
    }
}
