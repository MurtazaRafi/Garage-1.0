using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning5.Vehicles
{
    class Bus : Vehicle
    {
        public int NrOfSeats { get; set; }
        public Bus(string regNr, int nrOfWheels, string color, int nrOfSeats) : base(regNr, nrOfWheels, color)
        {
            NrOfSeats = nrOfSeats;
        }

    }
}
