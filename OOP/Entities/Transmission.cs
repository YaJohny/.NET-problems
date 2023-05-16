using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{
    internal class Transmission
    {
        public string Type { get; set; }
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }
        public void print()
        {
            Console.WriteLine($"Transmission Type: {Type}");
            Console.WriteLine($"Number of gears: {NumberOfGears}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
        }
    }
}
