using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ovning5.Vehicles;

namespace Ovning5
{
    public class GarageHandler
    {
        private Garage<IVehicle> garage;
        private int NrOfVehicles { get; set; }       // Gör till privat?
        public GarageHandler(int nrOfVehicles)
        {
            NrOfVehicles = nrOfVehicles;
            garage = new Garage<IVehicle>(NrOfVehicles);
        }

        // 
        public string PrintAll()
        {
            var builder = new StringBuilder();

            foreach (var v in garage)
            {
                //if (v != null)
                builder.AppendLine($"Vehicle type: {v.GetType().Name} Regnr: {v.RegNr} Number of wheels {v.NrOfWheels} Color {v.Color}");
            }
            return builder.ToString();
        }

        public string GetVehicleTypes()
        {
            var builder = new StringBuilder();
            foreach (var v in garage)
            {
                //ToDo skriv LINQ uttyck för att få typ och antal
                builder.AppendLine($"Vehicle type: {v.GetType().Name} Count: {v.GetType()}");
            }
            return builder.ToString();
        }

        internal bool Add(IVehicle vehicle)
        {
            return garage.Add(vehicle);

        }

        internal bool Remove(IVehicle vehicle)
        {
            return garage.Remove(vehicle);
        }
    }
}
