using Application.Dtos;
using Application.Interfaces.Service;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIPresentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        #region CRUD
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var doctors = await _doctorService.GetAll();

            return Ok(doctors);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var doctor = await _doctorService.GetDoctorById(id);

            if (doctor == null)
            {
                return NotFound();
            }

            return Ok(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctor([FromBody] CreateDoctorDto doctorDto)
        {
            var createdDoctor = await _doctorService.CreateDoctor(doctorDto);

            return Created("Doctor created.", createdDoctor);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDoctor([FromBody] Doctor doctor)
        {
            await _doctorService.UpdateDoctor(doctor);

            return Ok("Doctor updated.");
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            try
            {
                await _doctorService.DeleteDoctor(id);
            }
            catch
            {
                return BadRequest("No doctor with given id could be found.");
            }

            return Ok("Doctor deleted.");
        }
        #endregion

        [HttpGet]
        [Route("experience/{years}")]
        public async Task<IActionResult> GetDoctorsByExperience(int years)
        {
            var doctors = await _doctorService.GetDoctorsByExperience(years);

            return Ok(doctors);
        }
    }
}
