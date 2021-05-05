using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Repository
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAll();

        Doctor GetById(int Id);


    }
}
