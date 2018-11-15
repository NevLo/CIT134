using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentTests
{
    public class Appointment
    {
        public Person Person { get; set; }
        public Place Place { get; set; }
        public DateTime DateTime { get; set; }

        public Appointment()
        {
            Person = new Person();
            Place = new Place();
            DateTime = DateTime.Now;
        }
        public override string ToString()
        {
            var result = Person.ToString() + "\n";
            result += Place.ToString() + "\n";
            result += DateTime.ToString() + "\n";
            return result;
        }

    }
}
