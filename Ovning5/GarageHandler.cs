using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ovning5.Vehicles;

namespace Ovning5
{
    public class GarageHandler
    {

        Garage<Vehicle> vehicles = new Garage<Vehicle>(10);
        public void SeedData()
        {
            Car car = new Car("abc123", 4, "Blue", "Diesel");
            vehicles[0] = car;
            Vehicle bus = new Bus("cbe321", 8, "Red", 12);
            vehicles[1] = bus;
            Boat boat = new Boat("AB12", 0, "Brown", 7.5);
            vehicles[2] = boat;
            Motorcycle motorcycle = new Motorcycle("123MBO", 2, "Red", 1.6);
            vehicles[3] = motorcycle;
            Airplane airplane = new Airplane("DC34b", 3, "White", 33);
            vehicles[4] = airplane;
        }


        public void PrintAll()
        {
            // Extrahera
            foreach (var v in vehicles)
            {
                if (v != null)
                    Console.WriteLine($"Vehicle type: {v.GetType().Name} Regnr: {v.RegNr} Number of wheels {v.NrOfWheels} Color {v.Color}");
            }

        }

    }
}
