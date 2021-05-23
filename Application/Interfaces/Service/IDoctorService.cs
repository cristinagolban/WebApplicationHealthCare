using Application.Dtos;
using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces.Service
{
    public interface IDoctorService
    {
        Task<DoctorDto> CreateDoctor(CreateDoctorDto doctorDto);

        Task<IEnumerable<DoctorDto>> GetAll();

        Task<Doctor> GetDoctorById(int id);

        Task DeleteDoctor(int id);

        Task UpdateDoctor(Doctor doctor);

        Task<IEnumerable<Doctor>> GetDoctorsByExperience(int experience);
    }
}
