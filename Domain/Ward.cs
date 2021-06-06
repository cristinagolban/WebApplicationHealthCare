using System.Collections.Generic;

namespace Domain
{
    public class Ward : BaseEntity
    {
        public string Description { get; set; }

        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
