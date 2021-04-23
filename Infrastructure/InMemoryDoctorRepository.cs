using Domain;
using Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Infrastructure
{
    public class InMemoryDoctorRepository : IDoctorRepository
    {
        public List<Doctor> doctors;

        public InMemoryDoctorRepository()
        {
            this.doctors = new List<Doctor>
            {
                new Doctor
                {
                    Id = 001,
                    Name = "Dragan Ion",
                    Ward = "ORL"
                },

                 new Doctor
                {
                    Id = 002,
                    Name = "Miron Flavia",
                    Ward = "CARDIOLOGY"
                },
                  new Doctor
                {
                    Id = 003,
                    Name = "Draghici Dan",
                    Ward = "ORL"
                },
                   new Doctor
                {
                    Id = 004,
                    Name = "Dumitru Mirela",
                    Ward = "GENERAL"
                }
            };
        }

        public List<Appointment> GetAppointments(int Id)
        {
            foreach (var doctor in doctors)
            {
                if (doctor.Id == Id)
                    return doctor.Appointments;
            }

            return new List<Appointment>();
        }

        public Doctor GetDoctor(int Id)
        {
            return doctors.FirstOrDefault(d => d.Id == Id);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return doctors;
        }
    }
}
