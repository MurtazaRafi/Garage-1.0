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

            // Garage<Car> cars = new Garage<Car>(10);
            // Ifall har bara getter och ej setter kan bara hämta värdet såhär
            //var car2 = vehicles[1];

            //ToDo gör som en SeedData alternativ
            Garage<Vehicle> vehicles = new Garage<Vehicle>(10);
            Car car = new Car("abc123", 4, "Blue", "Diesel");
            vehicles[0] = car;
            Vehicle bus = new Car("cbe321", 8, "Red", "Gasoline");
            vehicles[1] = bus;
            Boat boat = new Boat("AB12", 0, "Brown", 7.5);
            vehicles[2] = boat;
            Motorcycle motorcycle = new Motorcycle("123MBO", 2, "Red", 1.6);
            vehicles[3] = motorcycle;
            Airplane airplane = new Airplane("DC34b", 3, "White", 33);
            vehicles[4] = airplane;


            Console.WriteLine(vehicles[0].Color + " " + vehicles[1].RegNr);


            Console.ReadKey();
        }
    }
}
