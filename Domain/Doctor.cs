using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string Ward { get; set; }

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public override string ToString()
        {
            var result= $" Dr. {this.Name} specialist at {this.Ward} and his list of patients: ";
            if (this.Appointments is null)
            {
                result = result + " dosen't have patients";
               
            }
            else
            {
                result = result + "{ \n";
                foreach (var appointment in this.Appointments)
                {
                    result = result + appointment.ToString();
                }
                result = result + "} \n";
            }
                
           

            return result;

        }
    }
}
