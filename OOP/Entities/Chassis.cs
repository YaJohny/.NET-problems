using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{
    class Chassis
    {
        public int WheelsNumber { get; set; }
        public string Number { get; set; }
        public int PermissibleLoad { get; set; }
        public void print()
        {
            Console.WriteLine($"Wheels number: {WheelsNumber}");
            Console.WriteLine($"Chassis Number: {Number}");
            Console.WriteLine($"Permissible load: {PermissibleLoad}");
        }
    }
}
