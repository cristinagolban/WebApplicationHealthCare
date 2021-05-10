using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Service
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetAllAvaibleDoctors();

        //Task<>
    }
}
