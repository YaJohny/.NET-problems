using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{
    class Truck
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double TankCapacity { get; set; }
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }

        public void print()
        {
            Console.WriteLine("Truck");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Tank capacity: {TankCapacity}");
            Engine.print();
            Chassis.print();
            Transmission.print();
            Console.WriteLine("\n\n\n");
        }
    }
}
