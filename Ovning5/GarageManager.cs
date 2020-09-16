using System;
using System.Collections.Generic;
using System.Text;
using Ovning5.Vehicles;

namespace Ovning5
{
    public class GarageManager
    {
        UI ui = new UI();   // Gör om till UI till IUI
        private static int nrOfVehicles;
        GarageHandler garageHandler;


        public GarageManager()
        {

            //ToDo fixa så att inte färre än SeedData()
            //Se AskForInt AskForString

            int input = Util.AskForInt("This is a garage application.Enter how many vehicles the garage should have capacity for", ui);

            if (input < 6)

                garageHandler = new GarageHandler(nrOfVehicles);
        }

        public void PrintMenu()
        {

            ui.Print("1. Populate the garage with som vehicles " +
                "\n2. Print all vehicles in the garage " +
                "\n3. Print vehicle types and how many of each there are in the garage" +
                "\n4. Park a vehicle " +
                "\n5. Pick up a vehicle" +
                "\n6. Find a vehicle with a given registration number");

            do
            {
                switch (ui.GetInput())
                {
                    case "1":
                        SeedData();
                        break;
                    case "2":
                        garageHandler.PrintAll();
                        break;
                    case "3":
                        PrintVehicleTypes();
                        break;
                    case "4":
                        Park();
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

        private void PrintVehicleTypes()
        {
            var result = garageHandler.GetVehicleTypes();
            ui.Print(result);
        }

        private bool Park()
        {
            ui.Print("Enter which type of vehicle you want to park \n1. Car \n2. Bus \n3. Boat \n4. Motorcycle \n5. Airplane");
            string vehicleType = ui.GetInput();
            ui.Print("Enter the three required vehicle data");
            string regNr = Util.AskForString("Registration number: ", ui);
            int nrOfWheels = Util.AskForInt("Number of wheels: ", ui);
            string color = Util.AskForAlphabets("Color: ", ui);        //ToDo fixa så att som color ej kan ange siffror

            string fuelType;
            int nrOfSeats;
            switch (vehicleType)
            {
                case "1":

                    do
                    {
                        string input1 = Util.AskForString("Enter fueltype for the car \n1. Gasoline \n2. Diesel", ui);

                        if (input1 == "1")
                        {
                            fuelType = "Gasoline";
                            break;
                        }
                        else if (input1 == "2")
                        {
                            fuelType = "Diesel";
                            break;
                        }
                        else
                            ui.Print("Enter a valid fuel type");
                    } while (true);


                    //IVehicle vehicle = new Car();

                    break;

                case "2":
                    do
                    {
                        int input2 = Util.AskForInt("Enter how many seats the bus should have", ui);      //ToDo begränsa så att ej minus eller 0 och max 30
                        if (input2 < 1)
                            ui.Print("The bus must at least have 1 seat");
                        else if (input2 > 60)
                            ui.Print("The bus cannot have more than 60 seats");
                        else
                            nrOfSeats = input2;
                        break;

                    } while (true);

                    break;
                default:
                    Console.WriteLine("Wrong choice, try again");
                    break;

            }



            return true; //ToDo om alla data given och en vehicle skapad samt placerat då success

            //garageHandler.Add()
            //Success eller Fail
        }

        public void SeedData()
        {
            Car car = new Car("abc123", 4, "Blue", "Diesel");
            garageHandler.Add(car);
            Car car2 = new Car("sdf334", 4, "Red", "Gasoline");
            garageHandler.Add(car2);
            Vehicle bus = new Bus("cbe321", 8, "Red", 12);
            garageHandler.Add(bus);
            Boat boat = new Boat("AB12", 0, "Brown", 7.5);
            garageHandler.Add(boat);
            Motorcycle motorcycle = new Motorcycle("123MBO", 2, "Red", 1.6);
            garageHandler.Add(motorcycle);
            Airplane airplane = new Airplane("DC34b", 3, "White", 33);
            garageHandler.Add(airplane);
        }

    }
}
