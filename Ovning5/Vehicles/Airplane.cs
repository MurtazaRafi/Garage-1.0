using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning5.Vehicles
{
    class Airplane : Vehicle
    {
        public double WingSpan { get; set; }
        public Airplane(string regNr, int nrOfWheels, string color, double wingSpan) : base(regNr, nrOfWheels, color)
        {
            WingSpan = wingSpan;
        }

    }
}
