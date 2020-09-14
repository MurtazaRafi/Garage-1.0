using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning5
{
    public abstract class Vehicle : IVehicle
    {
        public string RegNr { get; set; } //ToDo fixa så att kan ej sätta vilket som helst värde
        public int NrOfWheels { get; set; } //ToDo fixa så att kan ej sätta vilket som helst värde
        public string Color { get; set; } //ToDo fixa så att kan ej sätta vilket som helst värde

        public Vehicle(string regNr, int nrOfWheels, string color)
        {
            RegNr = regNr;
            NrOfWheels = nrOfWheels;
            Color = color;
        }
    }
}
