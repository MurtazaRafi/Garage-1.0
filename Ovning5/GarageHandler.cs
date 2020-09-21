using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ovning5.Vehicles;

[assembly: InternalsVisibleTo("Garage.Test")]
namespace Ovning5
{
    public class GarageHandler : IHandler
    {
        internal Garage<IVehicle> garage;     // ej privat pga kunna köra tester


        private int NrOfVehicles { get; set; }
        public GarageHandler(int nrOfVehicles)
        {
            NrOfVehicles = nrOfVehicles;
            garage = new Garage<IVehicle>(NrOfVehicles);
        }


        public string PrintAll()
        {
            var builder = new StringBuilder();

            foreach (var v in garage)
                builder.AppendLine($"Vehicle type: {v.GetType().Name} Regnr: {v.RegNr} Number of wheels {v.NrOfWheels} Color {v.Color}");

            return builder.ToString();
        }

        public string GetVehicleTypes()
        {
            var builder = new StringBuilder();

            var results = garage.GroupBy(v => v?.GetType().Name,
                (Types, NrOfTypes) => new { TypeOfVehicle = Types?.ToString(), Count = NrOfTypes?.Count() });

            foreach (var item in results)
            {
                if (item.TypeOfVehicle != null)
                    builder.AppendLine($"Vehicle type: {item.TypeOfVehicle}  Count: {item.Count}");
            }

            return builder.ToString();
        }

        internal bool Add(IVehicle vehicle)
        {
            return garage.Add(vehicle);

        }

        internal bool Remove(string regNr)

        {
            return garage.Remove(regNr);
        }


        internal bool UniqueRegNr(string regNr)
        {
            for (int i = 0; i < garage.Count(); i++)
            {
                if (garage[i]?.RegNr.ToLower() == regNr.ToLower())
                    return false;
            }
            return true;
        }

        internal IVehicle GetVehicleByRegNr(string regNr)
        {

            for (int i = 0; i < garage.Count(); i++)
            {
                if (garage[i]?.RegNr.ToLower() == regNr.ToLower())
                {
                    return garage[i];
                }
            }

            return null;


        }

        public string FindVehiclesByPropertyValues(List<(string, string)> propValuePairs, string vehicleType)
        {
            //The vehicles that contain all the properties and it values from the propValuePairs
            List<IVehicle> result = new List<IVehicle>();

            foreach (var vehicle in garage.Where(v => v != null))
            {
                //Retrieves the names of the properties in the vehicle.
                string[] propertiesInVehicle = vehicle.GetType().GetProperties().Select(pi => pi.Name).ToArray();

                //Checks that all the properties in the propValuePairs exists in the vehicle properties
                bool allIncluded = propValuePairs.Select(pvp => pvp.Item1).All(propertiesInVehicle.Contains);



                //If the vehicle contains all the properties
                if (allIncluded)
                {
                    //Checks that all the properties and their values are equal to the ones in the vehicle.

                    bool sameValues = propValuePairs.All((pvp) =>
                    {
                        var value = vehicle.GetType().GetProperty(pvp.Item1).GetValue(vehicle);
                        return value.ToString().ToLower().Equals(pvp.Item2.ToLower());
                    });
                    //If the vehicle is a match then it is added to the result list.
                    if (vehicleType == "none" && sameValues)
                        result.Add(vehicle);

                    if (vehicle.GetType().Name == vehicleType && sameValues)
                        result.Add(vehicle);

                }
            }

            StringBuilder builder = new StringBuilder();

            foreach (var v in result)
                builder.AppendLine($"Vehicle type: {v.GetType().Name} Regnr: {v.RegNr} Number of wheels {v.NrOfWheels} Color {v.Color}");

            return builder.ToString();
        }
    }
}
