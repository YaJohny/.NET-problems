using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{
    class PassangerCar
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int PassengersCapacity { get; set; }
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }
        public void print()
        {
            Console.WriteLine("Passanger car");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Passenger Capacity: {PassengersCapacity}");
            Engine.print();
            Chassis.print();
            Transmission.print();
            Console.WriteLine("\n\n\n");
        }
    }

}
