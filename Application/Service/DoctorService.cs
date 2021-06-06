using AppliApplication.Interfaces.Repositorycation;
using Application.Dtos;
using Application.Interfaces.Service;
using AutoMapper;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Service
{
    public class DoctorService : IDoctorService
    {
        private readonly IMapper _mapper;
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _doctorRepository = doctorRepository;
        }

        public async Task<DoctorDto> CreateDoctor(CreateDoctorDto createDoctorDto)
        {
            var doctor = _mapper.Map<Doctor>(createDoctorDto);

            var createdDoctor = await _doctorRepository.AddEntity(doctor);
            await _doctorRepository.SaveChangesAsync();

            var doctorDto = _mapper.Map<DoctorDto>(createdDoctor);

            return doctorDto;
        }

        public async Task DeleteDoctor(int id)
        {
            await _doctorRepository.DeleteById(id);
            await _doctorRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<DoctorDto>> GetAll()
        {
            var doctorsDto = (await _doctorRepository.GetAll())
                .Select(d => _mapper.Map<DoctorDto>(d));

            return doctorsDto;
        }

        public async Task<DoctorDto> GetDoctorById(int id)
        {

            var doctor = (await _doctorRepository.GetById(id));
            var doctorsDto = _mapper.Map<DoctorDto>(doctor);

            return doctorsDto;
        }
       
        public async Task UpdateDoctor(Doctor doctor)
        {
            await _doctorRepository.Update(doctor);
            await _doctorRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<DoctorDto>> GetDoctorsByExperience(int experience)
        {
            var doctors = (await _doctorRepository.GetWithFilter
                (d => d.Experience >= experience))
                .Select(d => _mapper.Map<DoctorDto>(d));


            return doctors;
        }

        public async Task<IEnumerable<DoctorDto>> GetDoctorsByWard(int wardId)
        {
            var doctors = (await _doctorRepository.GetWithFilter
               (d => d.WardId == wardId))
               .Select(d => _mapper.Map<DoctorDto>(d));

            return doctors;
        }
    }
}
