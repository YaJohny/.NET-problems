using Interfaces.Entities;
using Interfaces.Structures;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird(new Coordinate(10,10,10), 10);
            bird.FlyTo(new Coordinate(20,20,20));
            Console.WriteLine("Bird fly time: "
                + Math.Round(bird.GetFlyTime(new Coordinate(100,100,100)), 2));

            Airplane airplane = new Airplane(new Coordinate(10,10,10));
            airplane.FlyTo(new Coordinate(20,20,20));
            Console.WriteLine("Airplane fly time: " 
                + Math.Round(airplane.GetFlyTime(new Coordinate(100, 100, 100)), 2));

            Drone drone = new Drone(new Coordinate(10,10,10), 20);
            drone.FlyTo(new Coordinate(20, 20, 20));
            Console.WriteLine("Drone fly time: " 
                + Math.Round(drone.GetFlyTime(new Coordinate(100, 100, 100)), 2));
        }
    }
}