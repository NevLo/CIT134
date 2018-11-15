using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentTests
{
    public class Place
    {
        public string Location { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public override string ToString()
        {
            return $"Location: {Location}\nLatitude: {Latitude}\nLongitude: {Longitude}";
        }
    }
}
