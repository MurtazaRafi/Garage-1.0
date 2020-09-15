using System;
using System.Linq;
using Ovning5.Vehicles;

namespace Ovning5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] arr = new string[5];
            //arr.Append("A"); Kan köra extension metod om vill annars ger ny kopia

            // Ifall har bara getter och ej setter kan bara hämta värdet såhär
            //var car2 = vehicles[1];



            //ToDo gör som en SeedData alternativ
            UI ui = new UI();
            ui.PrintMenu();
           
            // Rätt?




            //Garage<Car> cars = new Garage<Car>(4);
            //Car car1 = new Car("abc123", 4, "Blue", "Diesel");
            //cars[0] = car1;
            //Car car2 = new Car("sdf334", 4, "Red", "Gasoline");
            //cars[1] = car2;

            //foreach (var v in cars)
            //{
            //    if (v != null)
            //        Console.WriteLine($"Vehicle type: {v.GetType()} Regnr: {v.RegNr} Number of wheels {v.NrOfWheels} Color {v.Color}");
            //}

            Console.ReadKey();
        }

     
    }
}
