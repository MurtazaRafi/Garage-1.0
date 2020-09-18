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

            List<Person> list = new List<Person>(4);
            Person person1 = new Person(18);
            list.Add(person1);
            Person person2 = new Person(15);
            list.Add(person2);
            Person person3 = new Person(25);
            list.Add(person3);
            Person person4 = new Person(27);
            list.Add(person4);

            var result = FilterList(list, "Age", age => (int)age >= 18);
            foreach (var item in result)
            {
                var person = item as Person;
                Console.WriteLine(person.Age);            // Vfr ser inte item.Age??
            }
        
            Console.ReadKey();




        }

        // Ha det här i GarageHandler klassen
        private static IList FilterList(IList list, string propName, Predicate<object> filterMethod)
        {
            //IVehicle[] result = new IVehicle[10];
            var result = new List<object>();
            foreach (var item in list)
            {
                var value = item.GetType().GetProperty(propName).GetValue(item);
                if (filterMethod(value))
                {
                    result.Add(item);
                }
            }
            return result;

        }

    }
}
