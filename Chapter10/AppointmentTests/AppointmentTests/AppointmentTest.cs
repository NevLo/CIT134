using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentTests
{
    public class AppointmentTest
    {
        static void Main(string[] args)
        {
            var appointments = new List<Appointment>();
            var run = true;
            do
            {
                DisplayMenu();
                var UserInput = int.Parse(Console.ReadKey().KeyChar.ToString());

                switch (UserInput) {
                    case 1:
                        CreateAppointment(appointments);
                        break;
                    case 2:
                        ShowAppointments(appointments);
                        break;
                }

            } while (run);
            
            
       


        }

        private static void ShowAppointments(List<Appointment> appointments)
        {
            foreach (var a in appointments)
            {
                Console.WriteLine(a.ToString());
            }

        }

        private static void DisplayMenu()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-WELCOME-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("\n\t1)    Create Appointment");
            Console.WriteLine("\n\t2)    Show Appointment");
            Console.WriteLine("\n\t3)    Delete Appointment");
            Console.WriteLine("\n\t4)    Exit");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }

        private static void CreateAppointment(List<Appointment> appointments)
        {
            
            var appt1 = new Appointment()
            {
                Person = new Person()
                {
                    Name = "Tim",
                    Age = 42,
                    IsEvil = true,
                },
                Place = new Place()
                {
                    Location = "Starbucks",
                    Latitude = 45.89172,
                    Longitude = 22.9852,
                },
                DateTime = DateTime.Now.AddDays(7)
            };
            appointments.Add(appt1);
            
        }
    }
}
