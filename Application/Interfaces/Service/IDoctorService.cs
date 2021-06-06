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

        Task<DoctorDto> GetDoctorById(int id);

        Task DeleteDoctor(int id);

        Task UpdateDoctor(Doctor doctor);

        Task<IEnumerable<DoctorDto>> GetDoctorsByExperience(int experience);

        Task<IEnumerable<DoctorDto>> GetDoctorsByWard(int experience);
    }
}
