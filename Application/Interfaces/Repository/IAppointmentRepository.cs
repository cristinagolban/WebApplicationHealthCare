using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public interface IAppointmentRepository
    {
        IEnumerable<Appointment> GetAll();

        Appointment GetById(int Id);

        void AddAppointment();

        IEnumerable<Appointment> GetWithFilter(Func<Appointment, bool> predicateFilter); 

    }
}
