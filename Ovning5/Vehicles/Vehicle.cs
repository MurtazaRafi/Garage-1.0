using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning5
{
    public abstract class Vehicle : IVehicle
    {
        public string RegNr { get; set; }   
        public int NrOfWheels { get; set; } 
        public string Color { get; set; }   

        public Vehicle(string regNr, int nrOfWheels, string color)
        {
            RegNr = regNr;
            NrOfWheels = nrOfWheels;
            Color = color;
        }

    }
}
