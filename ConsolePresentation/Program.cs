using Application;
using Infrastructure;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Infrastructure.Repository;

namespace ConsolePresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            using (var dbContext = new DatabaseContext())
            {
                dbContext.Database.EnsureCreated();
            
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


                    });

                

                    appointmentRepository.AddEntity(new Domain.Appointment
                    {
                        Doctor = doctorRepository.GetById(3),
                        Patient = patientRepository.GetById(4),
                        DoctorId = doctorRepository.GetById(3).Id,
                        PatientId = patientRepository.GetById(4).Id,
                        DateTime = new System.DateTime(2021, 10, 02),
                        Description = "voice loss"



                    });
                appointmentRepository.Update(new Appointment
                {
                    Id=5,
                    Description = "headache"

                });
                */


                doctorRepository.AddEntity(
                    new DoctorAsistent
                    {
                        Name = "doctor asist 1",
                        Ward = "ORL",
                        Experience = 1,
                        StillInCollage = "yes"
                    }

                    );

                doctorRepository.SaveChanges();
                appointmentRepository.SaveChanges();
                patientRepository.SaveChanges();


            }










        }
    }
}
