using ApApplication.Interfaces.Repositoryplication;
using Application.Dtos;
using Application.Interfaces.Repositoryplication;
using Application.Interfaces.Service;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class PatientService : IPatientService
    {
        private readonly IMapper _mapper;

        private readonly IPatientRepository _patientRepository;
        private readonly IAppointmentRepository _appointmentRepository;


        public PatientService(IPatientRepository patientRepository, 
            IAppointmentRepository appointmentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _patientRepository = patientRepository;
            _appointmentRepository = appointmentRepository;
        }

        public async Task<IEnumerable<Appointment>> GetAllAppointmentForPatient(int id)
        {
            return await _appointmentRepository.GetWithFilter(appointment => appointment.Patient.Id == id);

        }

        public async Task<PatientDto> CreatePatient(CreatePatientDto createPatientDto)
        {
            var patient = _mapper.Map<Patient>(createPatientDto);

            var createdPatient = await _patientRepository.AddEntity(patient);
            await _patientRepository.SaveChangesAsync();

            var patientDto = _mapper.Map<PatientDto>(createdPatient);

            return patientDto;
        }

        public async Task<IEnumerable<PatientDto>> GetAll()
        {
            var patientDto = (await _patientRepository.GetAll())
               .Select(p => _mapper.Map<PatientDto>(p));

            return patientDto;
        }

        public async Task<PatientDto> GetPatientById(int id)
        {

            var patient = (await _patientRepository.GetById(id));
            var patientDto = _mapper.Map<PatientDto>(patient);

            return patientDto;
        }

        public async Task DeletePatient(int id)
        {

            await _patientRepository.DeleteById(id);
            await _patientRepository.SaveChangesAsync();
        }

        public async Task UpdatePatient(Patient patient)
        {

            await _patientRepository.Update(patient);
            await _patientRepository.SaveChangesAsync();
        }
    }
}
