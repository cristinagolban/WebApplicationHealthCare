using System;

namespace Domain
{
    public class Appointment : BaseEntity
    {
        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        public int PatientId { get; set; }

        public Patient Patient { get; set; }

        public DateTime DateTime { get; set; }

        public string Description { get; set; }


        public override string ToString()
        {
            return $"Appointment with ID: {this.Id} for patient {this.Patient.Name} at {this.DateTime} for  reasons {this.Description}";
        }

    }
}
