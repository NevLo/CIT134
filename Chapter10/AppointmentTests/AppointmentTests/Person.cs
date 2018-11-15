using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentTests
{
    public class Person
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public bool IsEvil { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nIsEvil: {IsEvil}";
        }
    }
}
