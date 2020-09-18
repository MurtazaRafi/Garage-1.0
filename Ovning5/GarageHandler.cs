using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Ovning5.Vehicles;

[assembly: InternalsVisibleTo("Garage.Test")]
namespace Ovning5
{
    public class GarageHandler
    {
        public Garage<IVehicle> garage;     // ej privat pga kunna köra tester

        // public Garage<IVehicle> result = new Garage<IVehicle>(10);      // För att kunna lägga till från filtren

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

       
        public string FilterArray(string vehicleType, string color, int nrOfWheels)
        {
            StringBuilder builder = new StringBuilder();
            var resultat = garage.Where(v=> v.GetType().Name.ToLower() == vehicleType)
                .Where(v => v.Color.ToLower() == color)
                .Where(v => v.NrOfWheels == nrOfWheels);
            foreach (var item in resultat)
            {
                builder.AppendLine($"Vehicle type: {item.GetType().Name} Ristration Number: {item.RegNr} " +
                    $"Color: {item.Color} Number of wheels: {item.NrOfWheels}");
            }
            return builder.ToString();

            //string vehicleType = "Bus";
            //string colorInput = "Red";
            //Garage<IVehicle> result = new Garage<IVehicle>(10);
            //Predicate<object> filterMethod = color => (string)color == colorInput;
            //foreach (var item in garage)
            //{
            //    Predicate<object> filterMethod2 = nrOfWheel => (int)nrOfWheel == 8;
            //    object value = null ;
            //    object value2 = null;

             //ToDo Klura ut så att ej behöver skriva 6 olika varjanter av if om kör denna metod
            //    value = item.GetType().GetProperty("Color").GetValue(item);
            //    value2 = item.GetType().GetProperty("NrOfWheels").GetValue(item);

            //    Console.WriteLine(filterMethod(value));

            //    if (filterMethod(value) && filterMethod2(value2) && item.GetType().Name == vehicleType)
            //        result.Add(item);
            //    else if (filterMethod(value) && filterMethod2(value2))
            //        result.Add(item);
            //}
            
            //return result;

        }

        //public void PrintResultsFromArray(string colorInput)
        //{
           
        //    var result = FilterArray();

        //    if (result[0] == null)
        //        Console.WriteLine("Empty");         //ToDo ta bort console.writeline
        //    else
        //    {
        //        foreach (var item in result)
        //            Console.WriteLine($"{item.GetType().Name} {item.Color}");

        //    }
        //}
    }
}
