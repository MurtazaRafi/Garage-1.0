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
        private int NrOfVehicles { get; set; }
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
                builder.AppendLine($"Vehicle type: {v.GetType().Name} Regnr: {v.RegNr} Number of wheels {v.NrOfWheels} Color {v.Color}");

            return builder.ToString();
        }

        public string GetVehicleTypes()
        {
            var builder = new StringBuilder();



            //foreach (var v in garage)
            //{
            //    //ToDo skriv LINQ uttyck för att få typ och antal

            //    builder.AppendLine($"Vehicle type: {v.GetType().Name} Count: {v.GetType()}");

            //}

            garage.GroupByType();

            return builder.ToString();
        }

        // Kallar i två svep för att garage är private (incapsualtion)
        internal bool Add(IVehicle vehicle)
        {
            return garage.Add(vehicle);

        }

        //internal bool Remove(IVehicle vehicle)
        internal bool Remove(string regNr)

        {
            return garage.Remove(regNr);
        }


        internal bool UniqueRegMr(string regNr)
        {
            return garage.UniqueRegNr(regNr);
        }

        internal string GetVehicleByRegNr(string regNr)
        {
            IVehicle v = garage.GetVehicleByRegNr(regNr);
            string message = "A vehicle with that registration number does not exist in the garage";
            if(v != null)
            return $"Vehicle type: {v.GetType().Name} Regnr: {v.RegNr} Number of wheels {v.NrOfWheels} Color {v.Color}";

            return message;
        }
    }
}
