using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{
    class Engine
    {
        public int Power { get; set; }
        public double Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
        public void print()
        {
            Console.WriteLine($"Power: {Power}");
            Console.WriteLine($"Volume: {Volume}");
            Console.WriteLine($"Engine Type: {Type}");
            Console.WriteLine($"Serial Number: {SerialNumber}");
        }
    }
}
