using Interfaces.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    interface IFlyable
    {
        void FlyTo(Coordinate newPoint);
        double GetFlyTime(Coordinate destination);
    }
}
