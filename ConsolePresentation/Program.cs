using Application;
using Infrastructure;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Infrastructure.Repository;
using System.Threading.Tasks;

namespace ConsolePresentation
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            
            using (var dbContext = new DatabaseContext())
            {
                dbContext.Database.Migrate();
            
                var doctorRepository = new DoctorRepository(dbContext);
                var patientRepository = new PatientRepository(dbContext);
                var appointmentRepository = new AppointmentRepository(dbContext);
                var doctorasistentRepository = new DoctorAsistentRepository(dbContext);
                /*
                
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


                    });*/

              


                    await appointmentRepository.AddEntity(new Domain.Appointment
                    {
                        Doctor = await doctorRepository.GetById(3),
                        Patient = await patientRepository.GetById(4),
                        DoctorId = (await doctorRepository.GetById(3)).Id,
                        PatientId = (await patientRepository.GetById(4)).Id,
                        DateTime = new System.DateTime(2021, 10, 02),
                        Description = "voice loss"



                    });
                
                await appointmentRepository.Update(new Appointment
                {
                    Id=5,
                    Description = "headache"

                });
                


               await  doctorRepository.AddEntity(
                    new DoctorAsistent
                    {
                        Name = "doctor asist 1",
                        Ward = "ORL",
                        Experience = 1,
                        StillInCollage = "yes"
                    }

                    );

                await doctorRepository.SaveChangesAsync();
                await appointmentRepository.SaveChangesAsync();
                await patientRepository.SaveChangesAsync();


            }










        }
    }
}
