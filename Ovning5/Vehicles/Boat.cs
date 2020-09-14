using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning5.Vehicles
{
    class Boat : Vehicle
    {
        public double Length { get; set; }
        public Boat(string regNr, int nrOfWheels, string color, double length) : base(regNr, nrOfWheels, color)
        {
            Length = length;
        }

    }
}
