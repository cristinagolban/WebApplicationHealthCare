using Application.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPresentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardController : ControllerBase
    {
        private readonly IWardService _wardService;

        public WardController(IWardService wardService)
        {
            _wardService = wardService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var wards = await _wardService.GetAll();

            return Ok(wards);
        }
    }
}
