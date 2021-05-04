using Application;
using Infrastructure;
using Domain;

namespace ConsolePresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var connString = @"Server=RODSK41011\SQLEXPRESS;Database=HealthCare;Trusted_Connection=True";

            using (var dbContext = new DatabaseContext(connString))
            {
                dbContext.Database.EnsureCreated();

                var doctorRepository = new DoctorRepository(dbContext);
                var patientRepository = new PatientRepository(dbContext);
                var appointmentRepository = new AppointmentRepository(dbContext);

                doctorRepository.AddEntity(new Domain.Doctor
                {
                    Name = "Dobrescu Dan",
                    Ward = "ORL"
                });

                doctorRepository.AddEntity(new Domain.Doctor
                {
                    Name = "Ionescu Roxana",
                    Ward = "Cardiology"

                });

                doctorRepository.AddEntity(new Domain.Doctor
                {
                    Name = "Dragomir Dana",
                    Ward = "Cardiology"

                });

                doctorRepository.AddEntity(new Domain.Doctor
                {
                    Name = "Petcu Amalia",
                    Ward = "Urology"

                });

                doctorRepository.AddEntity(new Domain.Doctor
                {
                    Name = "Babescu Ioana",
                    Ward = "Pulmonology"

                });

                patientRepository.AddEntity(new Domain.Patient
                {
                    Name = "Golban Cristina",
                    Email = "cristina.golban@yahoo.com",
                    

                });

                patientRepository.AddEntity(new Domain.Patient
                {
                    Name = "Burescu Petre",
                    Email = "burescu.p@yahoo.com",


                });

                patientRepository.AddEntity(new Domain.Patient
                {
                    Name = "Parcel Denisa",
                    Email = "denisa.denisa98@yahoo.com",


                });

                patientRepository.AddEntity(new Domain.Patient
                {
                    Name = "Dumitrescu Daniel",
                    Email = "d.daniel88@yahoo.com",


                });

                 var doctor1 = new Doctor{Name="Patrscu Paul", Ward = "ORL" };
                 var patient1 = new Patient { Name = "Patrscu Paul", Email="paul.p@gmail.com" };


                appointmentRepository.AddEntity(new Domain.Appointment
                {
                    Doctor = doctor1,
                    Patient = patient1,
                    DoctorId = doctor1.Id,
                    PatientId = patient1.Id,
                    DateTime = new System.DateTime(2021,02,02),
                    Description = "ear pain"

                   

                });

                doctorRepository.DeleteById(1);
            }
        }
    }
}
