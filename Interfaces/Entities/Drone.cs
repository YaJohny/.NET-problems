using Interfaces.Interfaces;
using Interfaces.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    class Drone : IFlyable
    {
        private double speed;
        private Coordinate currentCoordinate;
        public Drone() { }
        public Drone(Coordinate currentCoordinate, double speed)
        {
            this.currentCoordinate = currentCoordinate;
            this.speed = speed;
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
            double timeWithoutBreakInHours = distance / speed; // total time in hours took for drone without any hovers
            int timeInMinutes = (int)timeWithoutBreakInHours * 60;
            return (double)(timeInMinutes + timeInMinutes / 10) / 60;

        }
    }
}
