using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ovning5.Vehicles;

namespace Ovning5
{
    public class GarageHandler
    {
        public Garage<Vehicle> vehicles; 
        public int NrOfVehicles { get; set; }
        public GarageHandler(int nrOfVehicles)
        {
            NrOfVehicles = nrOfVehicles;
          vehicles = new Garage<Vehicle>(NrOfVehicles);
        }

            
      

        // 
        public void PrintAll()
        {
            
            foreach (var v in vehicles)
            {
                //if (v != null)
                    Console.WriteLine($"Vehicle type: {v.GetType().Name} Regnr: {v.RegNr} Number of wheels {v.NrOfWheels} Color {v.Color}");
            }
        }

        public void PrintVehicleType()
        {
            foreach (var v in vehicles)
            {
                Console.WriteLine($"Vehicle type: {v.GetType().Name} Count: {v.GetType()}");
            }
        }



    }
}
