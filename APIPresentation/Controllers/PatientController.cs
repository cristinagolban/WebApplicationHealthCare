using Application.Dtos;
using Application.Interfaces.Service;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPresentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        #region CRUD
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var patients = await _patientService.GetAll();

            return Ok(patients);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var patient = await _patientService.GetPatientById(id);

            if (patient == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatient([FromBody] CreatePatientDto createpatientDto)
        {
            var createdPatient = await _patientService.CreatePatient(createpatientDto);

            return Created("Doctor created.", createdPatient);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDoctor([FromBody] Patient patient)
        {
            await _patientService.UpdatePatient(patient);

            return Ok("Patient updated.");
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            try
            {
                await _patientService.DeletePatient(id);
            }
            catch
            {
                return BadRequest("No patient with given id could be found.");
            }

            return Ok("Patient deleted.");
        }
        #endregion
    }
}
