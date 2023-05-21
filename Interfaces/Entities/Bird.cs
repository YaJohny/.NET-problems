using Interfaces.Interfaces;
using Interfaces.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    class Bird : IFlyable
    {
        private double speed;
        private Coordinate currentCoordinate { get; set; }
        
        public double Speed {
            set
            {
                if (value < 0 || value > 20)
                    Console.WriteLine("The bird speed can not be less than 0 or greater than 20");
                else
                    speed = value;
            }
            get { return speed; }
        }

        public Bird() { }

        public Bird(Coordinate currentCoordinate, double speed)
        {
            this.currentCoordinate = currentCoordinate;
            Speed = speed;
        }
        public void FlyTo(Coordinate newPoint)
        {
            currentCoordinate = newPoint;
        }
        public double GetFlyTime(Coordinate destination)
        {
            double distance = Math.Sqrt(Math.Pow((currentCoordinate.X - destination.X), 2) 
                + Math.Pow((currentCoordinate.Y - destination.Y), 2) 
                + Math.Pow((currentCoordinate.Z - destination.Z), 2));
            double timeWithoutBreak = distance / speed; // total time in hours took for birds without any break
            return timeWithoutBreak + ((int)timeWithoutBreak / 24 * 4); // birds must have a rest 4 hours/day  
        }
    }
}
