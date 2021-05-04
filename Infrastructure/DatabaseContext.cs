using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure
{
    public class DatabaseContext:DbContext
    {
        private readonly string _connString;
        public DatabaseContext(string connString):base()
        {
            _connString = connString;

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
