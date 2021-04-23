using Application;
using Infrastructure;
using System;
using System.Linq;

namespace ConsolePresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            IAppointmentRepository repository = new InMemoryAppointmentRepository();
            IDoctorRepository docrepository = new InMemoryDoctorRepository();


            var appointment = repository.GetAppointments();
            repository.AddAppointment();

            var doctors = docrepository.GetDoctors();

            foreach (var a in appointment)
            {
                Console.WriteLine($"I, {a.Patient.Name}, have an appointment at doctor {a.Doctor.Name} at {a.DateTime}" +
                    $" for {a.Description}");
                
            }

            Console.WriteLine("DUPA ADD");
            foreach (var a in appointment)
            {

                Console.WriteLine( a.Doctor.ToString());

                
            }
        }
    }
}
