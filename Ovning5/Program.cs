using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Ovning5.Vehicles;

namespace Ovning5
{
    class Program
    {
        static void Main(string[] args)
        {

 
            GarageManager gM = new GarageManager();
            gM.PrintMenu();

            Console.ReadKey();


        }

    }
}
