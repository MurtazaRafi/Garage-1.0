using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning5.Vehicles
{
    
        public class Car : Vehicle
        {
            public string FuelType { get; set; }
            public Car(string regNr, int nrOfWheels, string color, string fuelType) : base(regNr, nrOfWheels, color)
            {
                FuelType = fuelType;
            }
        }
}
