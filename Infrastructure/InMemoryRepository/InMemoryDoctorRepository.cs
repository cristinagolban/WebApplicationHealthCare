using Domain;
using Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AppliApplication.Interfaces.Repositorycation;
using System.Threading.Tasks;
using ApplicApplication.Interfaces.Repositoryation;

namespace Infrastructure.InMemoryRepository
{
    public class InMemoryDoctorRepository : IDoctorRepository
    {
        public List<Doctor> doctors;

        public InMemoryDoctorRepository()
        {
            this.doctors = new List<Doctor>
            {
                //new Doctor
                //{
                //    Id = 001,
                //    Name = "Dragan Ion",
                //    Ward = "ORL"
                //},

                // new Doctor
                //{
                //    Id = 002,
                //    Name = "Miron Flavia",
                //    Ward = "CARDIOLOGY"
                //},
                //  new Doctor
                //{
                //    Id = 003,
                //    Name = "Draghici Dan",
                //    Ward = "ORL"
                //},
                //   new Doctor
                //{
                //    Id = 004,
                //    Name = "Dumitru Mirela",
                //    Ward = "GENERAL"
                //}
            };
        }

        public Task<Doctor> AddEntity(Doctor obj)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetAll()
        {
            throw new NotImplementedException();
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

        public Doctor GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctor(int Id)
        {
            return doctors.FirstOrDefault(d => d.Id == Id);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return doctors;
        }

        public Task<IEnumerable<Doctor>> GetWithFilter(Func<Doctor, bool> p)
        {
            throw new NotImplementedException();
        }

        public void SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task Update(Doctor entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Doctor>> IRepository<Doctor>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<Doctor> IRepository<Doctor>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Doctor>.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
