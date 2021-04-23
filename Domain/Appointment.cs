using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Appointment : BaseEntity
    {

        public Doctor Doctor;

        public Patient Patient;

        public DateTime DateTime { get; set; }

        public string Description { get; set; }


        public override string ToString()
        {
            return $"Appointment with ID: {this.Id} for patient {this.Patient.Name} at {this.DateTime} for  reasons {this.Description}";
        }

    }
}
