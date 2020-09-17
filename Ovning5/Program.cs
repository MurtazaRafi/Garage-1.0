using System;
using System.Linq;
using Ovning5.Vehicles;

namespace Ovning5
{
    class Program
    {
        static void Main(string[] args)
        {

            //GarageHandler gH = new GarageHandler(10);
            //gH.TestingSettingOutOfBounds();

            GarageManager gM = new GarageManager();
            gM.PrintMenu();



            //string[] arr = new string[5];
            //arr.Append("A"); Kan köra extension metod om vill annars ger ny kopia

            // Ifall har bara getter och ej setter kan bara hämta värdet såhär
            //var car2 = vehicles[1];


            // Linq inspiration
            /* list.ForEach(m => action?.Invoke(m));

            var startsWithA = employees
              .Where(e => e.Name.StartsWith("S"))
              .Where(e => e.Name.EndsWith("a"))
              .Select(e => e.Salary)
              .Sum();

            var namesLength = employees
                .Where(e => e.Salary > 11000)
                .Select(e => new EmpDto
                {
                    Name = e.Name.ToUpper(),
                    NamesLength = e.Name.Length
                })
                .ToArray();
            */

            Console.ReadKey();
        }

     
    }
}
