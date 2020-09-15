using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning5
{
    public class UI
    {
        GarageHandler garageHandler = new GarageHandler();

        public void PrintMenu()
        {
            Console.WriteLine("This is a garage application. Enter how many vehicles the garage should have capacity for");

            //ToDo fixa så att inte kan ge andra värden än int och inte färre än SeedData()
            int garageCapacity = int.Parse(Console.ReadLine());

            Console.WriteLine("1. Populate the garage with som vehicles " +
                "\n2. Print all vehicles in the garage " +
                "\n3. Print vehicle types and how many of each there are in the garage" +
                "\n4. Park a vehicle " +
                "\n5. Pick up a vehicle" +
                "\n6. Find a vehicle with a given registration number");

            do
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        populateGarage();
                        break;
                    case "2":
                        PrintAll();
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                };

            } while (true);
        }

        private void PrintAll()
        {
            garageHandler.PrintAll();
        }

        public void populateGarage()
        {
            garageHandler.SeedData();
        }
    }
}
