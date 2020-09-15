using System;
using System.Collections.Generic;
using System.Text;
using Ovning5.Vehicles;

namespace Ovning5
{
    public class GarageManager
    {
        UI ui = new UI();
        private static int nrOfVehicles;   
        GarageHandler garageHandler = new GarageHandler(nrOfVehicles);

        public void PrintMenu()
        {
            ui.Print("This is a garage application. Enter how many vehicles the garage should have capacity for");

            //ToDo fixa så att inte kan ge andra värden än int och inte färre än SeedData()
             nrOfVehicles = int.Parse(ui.Read());




            ui.Print("1. Populate the garage with som vehicles " +
                "\n2. Print all vehicles in the garage " +
                "\n3. Print vehicle types and how many of each there are in the garage" +
                "\n4. Park a vehicle " +
                "\n5. Pick up a vehicle" +
                "\n6. Find a vehicle with a given registration number");

            do
            {
                switch (ui.Read())
                {
                    case "1":
                        SeedData();
                        break;
                    case "2":
                        garageHandler.PrintAll();
                        break;
                    case "3":
                        garageHandler.PrintVehicleType();
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice, try again");
                        break;
                };

            } while (true);


        }
        public void SeedData()
        {
            Car car = new Car("abc123", 4, "Blue", "Diesel");

            garageHandler.vehicles.Add(car);


            //Car car2 = new Car("sdf334", 4, "Red", "Gasoline");
            //vehicles[1] = car2;
            //Vehicle bus = new Bus("cbe321", 8, "Red", 12);
            //vehicles[2] = bus;
            //Boat boat = new Boat("AB12", 0, "Brown", 7.5);
            //vehicles[3] = boat;
            //Motorcycle motorcycle = new Motorcycle("123MBO", 2, "Red", 1.6);
            //vehicles[4] = motorcycle;
            //Airplane airplane = new Airplane("DC34b", 3, "White", 33);
            //vehicles[5] = airplane;
        }

    }
}
