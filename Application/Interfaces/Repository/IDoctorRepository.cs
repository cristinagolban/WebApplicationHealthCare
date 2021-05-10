using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppliApplication.Interfaces.Repositorycation
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Doctor>> GetAll();

        Task<Doctor> GetById(int Id);

    }
}
