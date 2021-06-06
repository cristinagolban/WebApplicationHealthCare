using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class CreatePatientDto
    {
        public string Name { get; set; }
        public string email { get; set; }
        public int Age { get; set; }
    }
}
