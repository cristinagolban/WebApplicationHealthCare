﻿using ApplicApplication.Interfaces.Repositoryation;
using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.InMemoryRepository
{
    public class InMemoryAppointmentRepository : Application.Interfaces.Repositoryplication.IAppointmentRepository
    {
        private List<Appointment> appointments;
        public InMemoryAppointmentRepository()
        {
            //this.appointments = new List<Appointment>
            //{
            //    new Appointment
            //    { Id = 1,
            //        Doctor=new Doctor{ Id = 123, Name = "Doru Stefan", Ward = "ORL" },
            //        Patient=  new Patient{ Id = 222, Name = "Doris Stanca" },
            //        DateTime= new System.DateTime(1999,7,7),
            //        Description="headacke" 
            //    },

            //    new Appointment
            //    { Id = 2,
            //        Doctor=new Doctor{ Id = 124, Name = "Ioana Mihaela", Ward = "CARDIOLOGY" },
            //        Patient=  new Patient{ Id = 223, Name = "Petre Dan"},
            //        DateTime= new System.DateTime(1987,2,5),
            //        Description="not felling well"
            //    }

            //};
        }

        public void AddAppointment()
        {
            foreach (var a in appointments)
            {
                a.Doctor.Appointments.Add(a);
                a.Patient.Appointments.Add(a);
            }
        }

        public Task<Appointment> AddEntity(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Appointment GetAppointment(int Id)
        {
            return appointments.FirstOrDefault(a => a.Id == Id);
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            return appointments;
        }

        public Appointment GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetWithFilter(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Appointment>> GetWithFilter(Func<Appointment, bool> p)
        {
            throw new NotImplementedException();
        }

        public void SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task Update(Appointment entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Appointment>> IRepository<Appointment>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<Appointment> IRepository<Appointment>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Appointment>.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
