using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure
{
    public class DatabaseContext:DbContext
    {
        string _connString = "Data Source=.;Initial Catalog=HealthCare;Integrated Security=True;";

        public DatabaseContext():base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
