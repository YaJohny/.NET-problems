using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{
    internal class Scooter
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public double Weight { get; set; }
        public int MaxSpeed { get; set; }
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        
        public void print()
        {
            Console.WriteLine("Scooter");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Maximum speed: {MaxSpeed}");
            Engine.print();
            Chassis.print();
            Console.WriteLine("\n\n\n");
        }
    }
}
