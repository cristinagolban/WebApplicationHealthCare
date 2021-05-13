using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public override string ToString()
        {
            return $"Patient {this.Name} with ID: {this.Id} ";
        }
    }
}
