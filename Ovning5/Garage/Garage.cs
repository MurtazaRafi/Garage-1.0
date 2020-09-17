using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ovning5
{
    public class Garage<T> : IEnumerable<T> where T : IVehicle //IGarage<T>,
    {
        public T[] vehicles;       //ToDo GÖR OM TILL PRIVAT

        public Garage(int nrOfVehicles)
        {
            vehicles = new T[nrOfVehicles];
        }
        internal T this[int index]
        {
            get => vehicles [index];
            set { vehicles[index] = value; }
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in vehicles)
            {
                if (item != null)
                    yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        // ??
        public bool Add(T vehicle)
        {
            //Boolskt returvärde?
            //Titta om garaget är fullt?
            //Är vehicle null?
            bool success = false;

            if (vehicles.Last() != null)
                return false;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    success = true;
                    break;
                }
            }
            return success;
        }

        internal bool UniqueRegNr(string regNr)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i]?.RegNr.ToLower() == regNr.ToLower())
                    return false;
            }
            return true;
        }

        //public bool Remove(T vehicle)
        public bool Remove(string regNr)
        {
            bool succcess = false;
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i]?.RegNr.ToLower() == regNr.ToLower())
                {
                    vehicles[i] = default(T);
                    succcess = true;
                    break;
                }
            }
            return succcess;
        }

        internal T GetVehicleByRegNr(string regNr)
        {
            
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i]?.RegNr.ToLower() == regNr.ToLower())
                {
                    return vehicles[i];
                }
            }

            return default(T);
        }
        internal void GroupByType()
        {
            // Remove null vehicles
            
            var results = vehicles.GroupBy(v => v?.GetType().Name, v => v?.GetType().Name.Length, 
                (Key, NrOfTypes) => new { Key = Key?.ToString() , Count = NrOfTypes?.Count()}); 
            
            //ToDo FIxa så att ej ger nullrefernce exception om alla positioner i arrayen ej fylld 

            foreach (var item in results)
            {
               
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Count);
            }
        }
    }
}
