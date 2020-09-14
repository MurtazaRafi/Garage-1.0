using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning5.Vehicles
{
    class Motorcycle : Vehicle
    {
        public double CylinderVolume { get; set; }
        public Motorcycle(string regNr, int nrOfWheels, string color, double cylinderVolume) : base(regNr, nrOfWheels, color)
        {
            CylinderVolume = cylinderVolume;
        }

    }
}
