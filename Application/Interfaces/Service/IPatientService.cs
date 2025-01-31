﻿using Application.Dtos;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Service
{
    public interface IPatientService
    {
        // Task<IEnumerable<Patient>> GetAppointmentsForPatient(int id);
        //Task<IEnumerable<Patient>> GetWithFilter(Func<object, bool> p);
        Task<PatientDto> CreatePatient(CreatePatientDto patientDto);

        Task<IEnumerable<PatientDto>> GetAll();

        Task<PatientDto> GetPatientById(int id);

        Task DeletePatient(int id);

        Task UpdatePatient(Patient patient);
        public Task<IEnumerable<Appointment>> GetWithFilter(Func<Patient, bool> predicateFilter)
        {
            throw new NotImplementedException();
        }

        public Task <IEnumerable<Appointment>> GetAllAppointmentForPatient(int id);
    }
}
