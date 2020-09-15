using System;
using System.Linq;
using Ovning5.Vehicles;

namespace Ovning5
{
    class Program
    {
        static void Main(string[] args)
        {

            GarageManager ui = new GarageManager();
            ui.PrintMenu();


            //string[] arr = new string[5];
            //arr.Append("A"); Kan köra extension metod om vill annars ger ny kopia

            // Ifall har bara getter och ej setter kan bara hämta värdet såhär
            //var car2 = vehicles[1];



            
            Console.ReadKey();
        }

     
    }
}
