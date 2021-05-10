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
            var connString = @"Server=RODSK41011\SQLEXPRESS;Database=HealthCare;Trusted_Connection=True";
            
            
            using (var dbContext = new DatabaseContext(connString))
            {
                dbContext.Database.EnsureCreated();
            
                var doctorRepository = new DoctorRepository(dbContext);
                var patientRepository = new PatientRepository(dbContext);
                var appointmentRepository = new AppointmentRepository(dbContext);
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

                    doctorRepository.SaveChanges();
                    patientRepository.SaveChanges();



                    appointmentRepository.AddEntity(new Domain.Appointment
                    {
                        Doctor = doctorRepository.GetById(3),
                        Patient = patientRepository.GetById(4),
                        DoctorId = doctorRepository.GetById(3).Id,
                        PatientId = patientRepository.GetById(4).Id,
                        DateTime = new System.DateTime(2021, 10, 02),
                        Description = "voice loss"



                    });*/
                appointmentRepository.Update(new Appointment
                {
                    Id=5,
                    Description = "headache"

                });
               
                appointmentRepository.SaveChanges();
                
                // doctorRepository.Update(doctor1);
                // doctorRepository.DeleteById(7);
            }




            /*
            using (var context = new DatabaseContext(connString))
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Database.ExecuteSqlRaw("UPDATE [dbo].[Doctors] Set Ward = 'Card Test' Where Ward=@p0", "Cardiology");

                        var query = context.Appointments
                            .Include(a => a.Doctor)
                           .Where(p => p.Doctor.Ward != String.Empty);

                        foreach (var appointment in query)
                        {
                            appointment.Description += " Test";
                        }

                        context.SaveChanges();

                        dbContextTransaction.Commit();
                    }
                    catch(Exception ex)
                    {
                        var exception = ex;

                        dbContextTransaction.Rollback();
                   }
                }
            }

                using (var context = new DatabaseContext(connString))
                {
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        try
                    {
                        IQueryable<Appointment> appointments = context.Appointments;
                        IQueryable<Doctor> doctors = context.Doctors;

                        var innerJoinQuery = from a in appointments
                                             join d in doctors
                                             on a.DoctorId equals d.Id
                                             select new { DoctorName = d.Name, AppointmentDescription = a.Description };

                        var leftJoinQuery = from d in doctors
                                            join a in appointments
                                            on d.Id equals a.DoctorId into appointmentsAlias
                                            from a in appointmentsAlias.DefaultIfEmpty()
                                            select new { DoctorName = d.Name, AppointmentDescription = a.Description };

                        var crossJoinQuery = from d in doctors
                                             from a in appointments
                                             select new { DoctorName = d.Name, AppointmentDescription = a.Description };

                    }
                    catch (Exception ex)
                    {
                        var exception = ex;

                        dbContextTransaction.Rollback();
                    }
                }
            }*/






        }
    }
}
