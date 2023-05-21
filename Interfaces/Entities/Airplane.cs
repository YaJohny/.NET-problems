using Interfaces.Interfaces;
using Interfaces.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    class Airplane : IFlyable
    {
        private double speed = 200;
        private int acceleration = 1;
        private Coordinate currentCoordinate;

        public Coordinate CurrentCoordinate {
            set
            {
                if(value.Z < 1)
                {
                    Console.WriteLine("Airplane is not capable to fly below 1 km high");
                }
                else
                {
                    currentCoordinate = value;
                }
            }
            get { return currentCoordinate; } 
        }
        public Airplane() { }
        public Airplane(Coordinate newPoint)
        { 
            CurrentCoordinate = newPoint;
        }
        public double getFlyDistance(Coordinate destination)
        {
            return Math.Sqrt(Math.Pow((currentCoordinate.X - destination.X), 2) 
                + Math.Pow((currentCoordinate.Y - destination.Y), 2)
                + Math.Pow((currentCoordinate.Z - destination.Z), 2));
        }
        public void FlyTo(Coordinate newPoint)
        {
            currentCoordinate = newPoint;
        }

        public double GetFlyTime(Coordinate destination)
        {
            return (-speed + Math.Sqrt(Math.Pow(speed,2) + 2 * acceleration * getFlyDistance(destination))) / acceleration;
        }

    }
}
