using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure
{
    public class DatabaseContext:DbContext
    {
        private readonly string _connString = @"Server=RODSK41011\SQLEXPRESS;Database=HealthCare;Trusted_Connection=True";

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

        public DbSet<DoctorAsistent> DoctorAsistents { get; set; }
    }
}
